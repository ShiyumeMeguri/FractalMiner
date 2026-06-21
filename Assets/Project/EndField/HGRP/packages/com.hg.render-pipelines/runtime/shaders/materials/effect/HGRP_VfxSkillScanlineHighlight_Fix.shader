// HGRP VFX Skill Scanline-Highlight — single transparent unlit ForwardOnly pass.
// Merged from: vfxskillscanlinehighlight.shader (single inlined SPIRV-Cross variant — Vertex blob 1, Fragment blob 2; NO keyword ladder, NO sub-blob folder).
// Keywords: <none> (this decompiled shader has no #pragma multi_compile_local; it is one variant only).
// Kept (1:1 math): instanced per-mesh-row height stepping, billboard up/forward orthonormal basis from object center→aim direction, height-map (T0) vertical-displacement sample, the c0..c3 4x3 affine-inverse world transform, world→clip projection, distance-to-emitter (TEXCOORD0.y) varying, the bottom-edge/band scanline RGB mask (×4×BeamTint /exposure), the time-cosine + per-instance ramp + horizontal sin/triangle alpha envelope.
// Removed (pixel-neutral pipeline infra, substituted by URP): TAA jitter (_NonJitteredViewNoTransProjMatrix + _TaaJitterStrength → UNITY_MATRIX_VP, jitter dropped), HGRP global cbuffer (_WorldSpaceCameraPos_Internal → _WorldSpaceCameraPos), SPIRV-Cross gl_* I/O statics + SPIRV_Cross_Input/Output plumbing, gl_BaseInstanceARB (URP SV_InstanceID is already 0-based so the `- gl_BaseInstanceARB` subtraction collapses to identity).
//
// NOTE: This is a DRIVER-FED VFX. The c0..c7 cbuffer (_ScanLineHighlightHeight[5] in the vertex view; named fields in the fragment view) and the per-instance object data (CB2_m0[9]) are filled by the HGRP skill-VFX C# system every frame. URP has NO global equivalent, so they are re-exposed as material uniforms (a _ScanLineHighlightMatrix float4[5] mirroring the vertex array + named scalars/vectors mirroring the fragment view + a _ScanLineObjectData float4[9] mirroring CB2_m0). They MUST be populated by a C# MaterialPropertyBlock / per-instance feeder to render correctly — see TODO(1:1) below.
//   The vertex cbuffer aliases the SAME bytes as the fragment cbuffer: array[0]=(_ScanLineHighlightHeight,_CountPerArray,_MeshHeight, c0.w), array[1]=_ScanLineCenterPos, array[2]=_ScanLineParams1, array[3]=c3(unnamed in frag), array[4]=_ScanLineParams8. The vertex treats array[0..3] as the rows of a 4-column affine matrix it inverts.
//   _ScanLineHighlightBeamTint RGB = emissive beam color (×4, /post-exposure). _MeshHeight = mesh row count (the "scanline" axis). TEXCOORD0 = mesh UV (.y is the height-fraction along the beam, .x is the cross-beam fraction).

Shader "HGRP/VfxSkillScanlineHighlight_Fix" {
    Properties {
        [Header(Scanline Highlight)]
        // Fragment cbuffer c0..c7 named view (driver-fed; re-exposed for inspector visibility).
        _MeshHeight ("Mesh Height (row count)", Float) = 1
        _CountPerArray ("Count Per Array", Float) = 1
        _ScanLineHighlightHeight ("Scanline Highlight Height", Float) = 0
        _ScanLineCenterPos ("Scanline Center Pos", Vector) = (0, 0, 0, 0)
        _ScanLineParams1 ("Scanline Params 1", Vector) = (0, 0, 0, 0)
        _ScanLineParams8 ("Scanline Params 8 (.x .y ramp, .z .w intensity)", Vector) = (0, 0, 1, 1)
        _ScanLineParams9 ("Scanline Params 9 (.x time-freq, .y cos-amp)", Vector) = (1, 1, 0, 0)
        _ScanLineParams10 ("Scanline Params 10 (.w exposure-mix)", Vector) = (0, 0, 0, 0)
        [HDR] _ScanLineHighlightBeamTint ("Beam Tint", Color) = (1, 1, 1, 1)

        [Header(Exposure)]
        _ExposureParams ("Exposure Params (.x post-exposure)", Vector) = (1, 0, 0, 0)

        [HideInInspector] _SrcBlend ("__src", Float) = 5   // SrcAlpha
        [HideInInspector] _DstBlend ("__dst", Float) = 10  // OneMinusSrcAlpha
        [HideInInspector] _ZWrite ("__zw", Float) = 0
        [HideInInspector] _Cull ("__cull", Float) = 0       // Off (source: Cull Off)
    }

    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
        }
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // ---- Fragment named view (c0..c7) ----
                float  _ScanLineHighlightHeight;   // c0.x
                float  _CountPerArray;             // c0.y
                float  _MeshHeight;                // c0.z
                float4 _ScanLineCenterPos;         // c1
                float4 _ScanLineParams1;           // c2
                float4 _ScanLineParams8;           // c4
                float4 _ScanLineParams9;           // c5
                float4 _ScanLineParams10;          // c6
                float4 _ScanLineHighlightBeamTint; // c7
                float4 _ExposureParams;            // global c109 → material Vector
                float  _SrcBlend;
                float  _DstBlend;
                float  _ZWrite;
                float  _Cull;
            CBUFFER_END

            // ============================================================
            // Driver-fed arrays. URP has no global equivalent for the HGRP
            // type_cb0 / CB2UBO; a per-instance C# feeder must fill these.
            // TODO(1:1): wire a MaterialPropertyBlock / per-instance system to
            //   populate _ScanLineHighlightMatrix[5] (= vertex view of c0..c4)
            //   and _ScanLineObjectData[9] (= CB2_m0[9] per-instance object data)
            //   each frame, OR the vertex transform is undefined. The HLSL math
            //   below is 1:1 vs vfxskillscanlinehighlight.shader vertex lines 79-163.
            // ============================================================
            float4 _ScanLineHighlightMatrix[5]; // vertex view: [0..3]=affine rows, mirrors named c0..c3
            float4 _ScanLineObjectData[9];      // CB2_m0[9]: [1].xyz=object center, [8].xyz=aim point, [1].w=phase, [2].y=height step, [0].z=z-blend flag

            // T0 height-displacement texture, sampled with linear-clamp (source: T0 + sampler_LinearClamp, vfxskillscanlinehighlight.shader:44-45,100).
            // URP has no inline `sampler_linear_clamp` (HDRP-only); the per-texture SAMPLER() below inherits the BOUND
            // texture's import settings, so the driver that binds _ScanHeightMap MUST set FilterMode=Bilinear + WrapMode=Clamp
            // to match the source's sampler_LinearClamp exactly (part of the TODO(1:1) driver-binding contract above).
            TEXTURE2D(_ScanHeightMap);  SAMPLER(sampler_ScanHeightMap);
        ENDHLSL

        Pass {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }
            // Source: Blend SrcAlpha OneMinusSrcAlpha (RGB & alpha), ZWrite Off, Cull Off, ZClip On.
            Blend [_SrcBlend] [_DstBlend], [_SrcBlend] [_DstBlend]
            ZWrite [_ZWrite]
            Cull [_Cull]
            ZTest LEqual

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag

            struct Attributes {
                float3 positionOS : POSITION;   // source POSITION (object-local row offset, transformed by the inverted affine)
                float2 uv         : TEXCOORD0;  // source TEXCOORD
                uint   instanceID : SV_InstanceID;
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0; // source TEXCOORD_1 (mesh uv)
                float2 emitterUV  : TEXCOORD1; // source TEXCOORD_1_1 (.x = instance index, .y = distance-to-object-center)
                nointerpolation uint instanceIdx : TEXCOORD2; // source TEXCOORD_2
            };

            // -------------------------------------------------------------
            // Vertex — 1:1 vfxskillscanlinehighlight.shader lines 79-163.
            // Re-spelled from mad()/((-0.0f)-x); magic floats decoded inline.
            // Naming: M = _ScanLineHighlightMatrix (vertex view of c0..c3),
            //         O = _ScanLineObjectData (CB2_m0).
            // -------------------------------------------------------------
            Varyings vert(Attributes v)
            {
                Varyings o;

                #define M _ScanLineHighlightMatrix
                #define O _ScanLineObjectData

                // URP SV_InstanceID is already 0-based, so (instanceID - gl_BaseInstanceARB) == instanceID. (lines 94,160,163,168-169)
                uint instIdx = v.instanceID;

                // --- billboard "up" axis = normalize(aim - center) (lines 79-85) ---
                // dir = (O[8]-O[1]) + 1e-6 (the +1e-6 avoids a zero-length axis).
                float dirX = (O[8].x - O[1].x) + 1e-06; // line 79
                float dirY = (O[8].y - O[1].y) + 1e-06; // line 80
                float dirZ = (O[8].z - O[1].z) + 1e-06; // line 81
                float dirInvLen = rsqrt(dot(float3(dirX, dirY, dirZ), float3(dirX, dirY, dirZ))); // line 82
                float upX = dirInvLen * dirX; // line 83 (_76)
                float upY = dirInvLen * dirY; // line 84 (_77)
                float upZ = dirInvLen * dirZ; // line 85 (_78)

                // --- orthonormal basis perpendicular to up (lines 86-93) ---
                // If |up.y|>0.999 cross with X axis, else cross with Y axis (degenerate-pole guard).
                bool  upNearY = (0.999 < abs(upY));                  // line 86 (_81)
                float selA = upNearY ? 0.0 : 1.0;                    // line 87 (_87 = asfloat(_81?0u:1.0))
                float selB = upNearY ? 1.0 : 0.0;                    // line 88 (_89 = (mask & 1.0))
                float selZero = 0.0;                                 // line 89 (_90 = asfloat(0u))
                // crossA = cross(up, chosenAxis) (lines 90-92, _103/_104/_105)
                float crossX = (-upY) * selB - ((-upZ) * selA);      // line 90 (_103)
                float crossY = (-upZ) * selZero - ((-upX) * selB);   // line 91 (_104)
                float crossZ = (-upX) * selA - ((-upY) * selZero);   // line 92 (_105)
                float crossInvLen = rsqrt(dot(float3(crossX, crossY, crossZ), float3(crossX, crossY, crossZ))); // line 93 (_109)

                // --- per-instance height offset along up (lines 94-96) ---
                // step = (instIdx + 1 + frac(O[1].w)) * O[2].y
                float heightStep = (float(instIdx + 1u) + frac(O[1].w)) * O[2].y; // line 94 (_128)
                float worldX = mad(upX, heightStep, O[1].x); // line 95 (_133)  (only X & Z stepped — Y omitted by source)
                float worldZ = mad(upZ, heightStep, O[1].z); // line 96 (_134)

                // --- map stepped world XZ through the c0..c2 affine to a 0..1 height-map UV (lines 97-99) ---
                // mWS_n = M[0].n*worldX + M[1].n*camY + M[2].n*worldZ + M[3].n   (for n in x,y,w)
                float mappedX = mad(M[2].x, worldZ, mad(M[0].x, worldX, _WorldSpaceCameraPos.y * M[1].x)) + M[3].x; // line 97 (_169)
                float mappedY = mad(M[2].y, worldZ, mad(M[0].y, worldX, _WorldSpaceCameraPos.y * M[1].y)) + M[3].y; // line 98 (_170)
                float mappedW = mad(M[2].w, worldZ, mad(M[0].w, worldX, _WorldSpaceCameraPos.y * M[1].w)) + M[3].w; // line 99 (_171)

                // --- sample height-displacement texture (lines 100-101) ---
                // uv = (mappedX*0.5+0.5 + M[4].x, (1 - (mappedY*0.5+0.5)) + M[4].y)
                float2 heightUV = float2(mad(mappedX, 0.5, 0.5) + M[4].x,
                                         (1.0 - mad(mappedY, 0.5, 0.5)) + M[4].y); // line 100 (_188 uv)
                float heightSample = SAMPLE_TEXTURE2D_LOD(_ScanHeightMap, sampler_ScanHeightMap, heightUV, 0.0).x; // lines 100-101 (_188.x → _190)

                // --- invert the 3x3 (M[0..2] rows) to map the displaced point back to world (lines 102-144) ---
                // This is the standard cofactor/adjugate inverse of the upper-left 3x3 with M[3] as the
                // 4th column; reused verbatim. det = 1 / (sum below). (lines 102-129 build _201.._405)
                // cofactor terms (lines 102-110):
                float c201 = M[0].z * M[2].w; float c202 = M[0].w * M[2].z;
                float c203 = M[0].w * M[2].y; float c204 = M[0].y * M[2].w;
                float c235 = M[0].w * M[2].x; float c236 = M[0].x * M[2].w;
                float c237 = M[0].y * M[2].z; float c238 = M[0].z * M[2].y;
                float adj247 = mad(-c237, M[3].w, mad(c238, M[3].w, mad(c204, M[3].z, mad(-c203, M[3].z, mad(c202, M[3].y, -(c201 * M[3].y)))))); // line 110 (_247)
                // (lines 111-119):
                float c262 = M[1].w * M[2].z; float c263 = M[1].z * M[2].w;
                float c264 = M[1].y * M[2].w; float c265 = M[1].w * M[2].y;
                float c296 = M[1].w * M[2].x; float c297 = M[1].x * M[2].w;
                float c298 = M[1].z * M[2].y; float c299 = M[1].y * M[2].z;
                float adj308 = mad(c299, M[3].w, mad(-c298, M[3].w, mad(-c264, M[3].z, mad(c265, M[3].z, mad(c263, M[3].y, -(c262 * M[3].y)))))); // line 119 (_308)
                // (lines 120-128):
                float c323 = M[0].w * M[1].z; float c324 = M[0].z * M[1].w;
                float c325 = M[0].y * M[1].w; float c326 = M[0].w * M[1].y;
                float c357 = M[0].w * M[1].x; float c358 = M[0].x * M[1].w;
                float c359 = M[0].z * M[1].y; float c360 = M[0].y * M[1].z;
                float adj369 = mad(c360, M[3].w, mad(-c359, M[3].w, mad(-c325, M[3].z, mad(c326, M[3].z, mad(c324, M[3].y, -(c323 * M[3].y)))))); // line 128 (_369)
                // determinant reciprocal (line 129, _405):
                float invDet = 1.0 / mad(M[3].x,
                                         mad(-c360, M[2].w, mad(c359, M[2].w, mad(c325, M[2].z, mad(-c326, M[2].z, mad(c323, M[2].y, -(c324 * M[2].y)))))),
                                         mad(M[2].x, adj369, mad(M[0].x, adj308, adj247 * M[1].x)));

                // inverse-matrix rows × displaced point (lines 130-144).
                // The transformed point P (x,z,y-up) = inverseAffine · (mappedX, mappedY, heightSample, mappedW).
                float i425 = M[1].z * M[2].x; float i426 = M[1].x * M[2].z;
                float i427 = M[1].y * M[2].x; float i428 = M[1].x * M[2].y;
                float worldXform = dot(float4(
                    invDet * adj308,
                    invDet * mad(-i426, M[3].w, mad(i425, M[3].w, mad(c297, M[3].z, mad(-c296, M[3].z, mad(c262, M[3].x, -(c263 * M[3].x)))))),
                    invDet * mad(i428, M[3].w, mad(-i427, M[3].w, mad(-c297, M[3].y, mad(c296, M[3].y, mad(c264, M[3].x, -(c265 * M[3].x)))))),
                    invDet * mad(-i428, M[3].z, mad(i427, M[3].z, mad(i426, M[3].y, mad(-i425, M[3].y, mad(c298, M[3].x, -(c299 * M[3].x))))))),
                    float4(mappedX, mappedY, heightSample, mappedW)); // line 134 (_499)

                float j542 = M[0].z * M[1].x; float j543 = M[0].x * M[1].z;
                float j544 = M[0].y * M[1].x; float j545 = M[0].x * M[1].y;
                float worldXformZ = dot(float4(
                    invDet * adj369,
                    invDet * mad(-j543, M[3].w, mad(j542, M[3].w, mad(c358, M[3].z, mad(-c357, M[3].z, mad(c323, M[3].x, -(c324 * M[3].x)))))),
                    invDet * mad(j545, M[3].w, mad(-j544, M[3].w, mad(-c358, M[3].y, mad(c357, M[3].y, mad(c325, M[3].x, -(c326 * M[3].x)))))),
                    invDet * mad(-j545, M[3].z, mad(j544, M[3].z, mad(j543, M[3].y, mad(-j542, M[3].y, mad(c359, M[3].x, -(c360 * M[3].x))))))),
                    float4(mappedX, mappedY, heightSample, mappedW)); // line 139 (_595)

                float k638 = M[0].z * M[2].x; float k639 = M[0].x * M[2].z;
                float k640 = M[0].y * M[2].x; float k641 = M[0].x * M[2].y;
                float worldXformY = dot(float4(
                    adj247 * invDet,
                    invDet * mad(k639, M[3].w, mad(-k638, M[3].w, mad(-c236, M[3].z, mad(c235, M[3].z, mad(c201, M[3].x, -(c202 * M[3].x)))))),
                    invDet * mad(-k641, M[3].w, mad(k640, M[3].w, mad(c236, M[3].y, mad(-c235, M[3].y, mad(c203, M[3].x, -(c204 * M[3].x)))))),
                    invDet * mad(k641, M[3].z, mad(-k640, M[3].z, mad(-k639, M[3].y, mad(k638, M[3].y, mad(c237, M[3].x, -(c238 * M[3].x))))))),
                    float4(mappedX, mappedY, heightSample, mappedW)); // line 144 (_691)

                // --- place the mesh-local vertex (POSITION) into world using the billboard basis (lines 145-147) ---
                // posWS.x = -up.x*P.z + 0*P.y + (cross·invLen).x*P.x + worldXform
                float posWSX = mad(-upX, v.positionOS.z, mad(selZero, v.positionOS.y, mad(crossInvLen * crossX, v.positionOS.x, worldXform))); // line 145 (_710)
                float posWSZ = mad(-upZ, v.positionOS.z, mad(selB,    v.positionOS.y, mad(crossInvLen * crossZ, v.positionOS.x, worldXformZ))); // line 146 (_712)
                // posWS.y blends the billboarded Y back toward worldXformY by O[0].z (line 147, _718)
                float posWSYbill = mad(-upY, v.positionOS.z, mad(selA, v.positionOS.y, mad(crossInvLen * crossY, v.positionOS.x, worldXformY)));
                float posWSY = mad(O[0].z, (-worldXformY) + posWSYbill, worldXformY); // line 147 (_718)

                // --- distance from object center (lines 151-154) ---
                float relObjX = posWSX - O[1].x; // line 151 (_738)
                float relObjY = posWSY - O[1].y; // line 152 (_739)
                float relObjZ = posWSZ - O[1].z; // line 153 (_740)
                o.emitterUV.y = sqrt(dot(float3(relObjX, relObjY, relObjZ), float3(relObjX, relObjY, relObjZ))); // line 154 (distance-to-center)

                // --- world → clip (lines 155-159). TAA jitter dropped. ---
                // Source feeds the camera-RELATIVE position (posWS - camPos, lines 148-150) into
                // _NonJitteredViewNoTransProjMatrix (view with translation zeroed) — the camera-relative-
                // rendering idiom. That is mathematically identical to full VP × absolute posWS, so we use
                // the absolute world position with URP's UNITY_MATRIX_VP (do NOT subtract camPos again).
                float4 clip = mul(UNITY_MATRIX_VP, float4(posWSX, posWSY, posWSZ, 1.0));
                o.positionCS = clip;
                // TODO(1:1): source applies TAA jitter offset to clip.xy (lines 156-157):
                //   clip.x += -(clip.w * _TaaJitterStrength.z) * 2;  clip.y += -(clip.w * _TaaJitterStrength.w) * -2;
                //   intentionally REMOVED (TAA jitter is pipeline infra; URP TAA injects its own jitter).

                o.emitterUV.x = float(instIdx); // line 160 (instance index as float)
                o.uv = v.uv;                    // lines 161-162 (TEXCOORD → TEXCOORD_1)
                o.instanceIdx = instIdx;        // line 163 (TEXCOORD_2)

                #undef M
                #undef O
                return o;
            }

            // -------------------------------------------------------------
            // Fragment — 1:1 vfxskillscanlinehighlight.shader lines 230-243.
            // input.uv          = source TEXCOORD  (.y = height-fraction, .x = cross-beam)
            // input.emitterUV.x = source TEXCOORD_1.x (instance index)
            // input.emitterUV.y = source TEXCOORD_1.y (distance to emitter center)
            // -------------------------------------------------------------
            half4 frag(Varyings input) : SV_Target
            {
                float2 uv = input.uv;

                // bottom-edge thresholds along the beam (lines 230-232)
                float edge01 = 0.1 / _MeshHeight;            // line 230 (_33)
                bool  belowLow = uv.y < edge01;              // line 231 (_47)
                float heightUnits = uv.y * _MeshHeight;      // line 232 (_56)

                // RGB vertical-edge mask (line 233, _76):
                //   bandTerm = (uv.y < 0.2/_MeshHeight) && (edge01 < uv.y) ? (heightUnits*-10+3) : 1
                //   lowTerm  = belowLow ? (heightUnits*20) : 1
                //   mask = bandTerm * lowTerm
                bool inBand = (uv.y < (0.2 / _MeshHeight)) && (edge01 < uv.y);
                float bandTerm = inBand ? mad(heightUnits, -10.0, 3.0) : 1.0;
                float lowTerm  = belowLow ? (heightUnits * 20.0) : 1.0;
                float rgbMask = bandTerm * lowTerm; // _76

                // post-exposure divisor (line 234, _100)
                float exposureDiv = mad(_ScanLineParams10.w, (-1.0 + _ExposureParams.x), 1.0);

                // RGB = mask * 4 * beamTint / exposureDiv (lines 235-237)
                float3 rgb = (rgbMask * (4.0 * _ScanLineHighlightBeamTint.rgb)) / exposureDiv;

                // --- alpha envelope ---
                float instNorm = saturate((1.0 / _CountPerArray) * input.emitterUV.x); // line 238 (_127)
                float ramp135  = 1.0 - _ScanLineParams8.x;                              // line 239 (_135)
                // cosine wave over time + emitter distance, scaled, plus per-instance ramp, plus beam-height offset (line 240, _160)
                float wave = cos(mad(_Time.z, _ScanLineParams9.x, input.emitterUV.y)) * _ScanLineParams9.y;
                float rampMix = mad(instNorm, (-ramp135) + (1.0 - _ScanLineParams8.y), ramp135);
                float heightOff = (uv.y - _ScanLineHighlightHeight) + 1.0;
                float band160 = max(-mad(wave, 0.1, rampMix + heightOff) + 1.0, 0.0); // _160

                float crossCentered = uv.x - 0.5;            // line 241 (_164)
                float crossSpan = crossCentered + crossCentered; // line 242 (_166 = 2*(uv.x-0.5))

                // horizontal triangle/sin profile × squared band × per-instance intensity (line 243)
                float lowAlphaTerm = belowLow ? (heightUnits * 10.0) : 1.0; // (_47 ? _56*10 : 1)
                float sinProfile = min(sin(-(abs(crossSpan) * 1.5707964)) + 1.0, 0.95); // π/2, clamp 0.95
                float bandSq = (band160 * band160) * (1.0 - abs(crossSpan));
                float instIntensity = mad(instNorm, (-_ScanLineParams8.z) + _ScanLineParams8.w, _ScanLineParams8.z);
                float alpha = lowAlphaTerm * (sinProfile * (bandSq * instIntensity));

                return half4(rgb, alpha);
            }
            ENDHLSL
        }
    }
}
