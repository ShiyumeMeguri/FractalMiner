// Volumetric Light Beam (VLB) — single-pass procedural cone beam, transparent additive/alpha.
// Merged from: vlbgeneratedshader.shader (Hidden/VLB_HGRP_SinglePass), Sub0/Pass0.
//   Vertex base = vlbgeneratedshader/Sub0_Pass0_Vertex_b8.hlsl   (catch-all #else)
//   Vertex DB+Noise = vlbgeneratedshader/Sub0_Pass0_Vertex_b14.hlsl (noise UVW + depth-blend screen UV)
//   Fragment base = vlbgeneratedshader/Sub0_Pass0_Fragment_b9.hlsl (catch-all #else)
//   Fragment DEPTH_BLEND = ...Fragment_b11.hlsl ; +USE_FOG = ...Fragment_b13.hlsl ; +NOISE_3D = ...Fragment_b15.hlsl
// Keywords: VLB_DEPTH_BLEND, VLB_NOISE_3D  (kept as shader_feature)
// Kept (all 1:1 math): cone radial intensity + caps, inside/outside alpha lerp, Glare frontal/behind
//   Fresnel power, distance-fade (near + second), linear<->quad attenuation lerp, camera near-clip fade,
//   additional world clipping plane, Blend Mode (Alpha=0 / Additive=1) intensity-vs-color split,
//   VFX color-grade (luma desat via _VFXParams1), Depth-Blend soft scene intersection, 3D noise modulation.
// Removed (HGRP infra -> URP facilities, pixel-neutral): TAA jitter (_TaaJitterStrength applied to clip x/y),
//   _NonJitteredViewNoTransProjMatrix -> UNITY_MATRIX_VP applied (matrix-on-LEFT) to the ABSOLUTE world cone
//   position (camPos added back, since URP VP includes the view translation; cf. HGRP_RainSplash_Fix:327-338),
//   HGRP atmosphere+exponential fog (VLB_USE_FOG, b13) -> URP MixFog, _ExposureParams/_VFXParams0.w time -> _NoiseObjW,
//   SRP_INSTANCING_ON variant (instancing dropped).
//
// NOTE: VLB packs its cone geometry into the per-draw float4[12] register array via MaterialPropertyBlock
//   (the decompiled _unity_ObjectToWorld[7u..11u] are NOT Unity's object matrix — they are VLB cone data:
//   [9u].xy = cone radius x/y, [10u].xyz = cone slope/forward scale, [11u].z = cone Z scale,
//   [7u].xw + [8u].xyz = noise object-space TRS, driven by the VLB C# component).
//   These are re-exposed below as material Vectors (_VlbConeRow7.._VlbConeRow11) so the CPU side fills
//   the SAME values it already uploads (CLOSED 1:1 — binding rename, not a behavioral change; see the
//   vertex header). The same per-draw class covers _unity_Float4x5_Param0.x (HG VFX SceneEffect darken),
//   folded to its identity default at the fragment color-grade. The ONLY genuinely engine-side residual is
//   the TAA sub-pixel jitter (_TaaJitterStrength, host TAA render-feature) — documented at the vertex.
// NOTE: TEXCOORD_3.w = mesh uv.x carries the "is-cap" side flag in [0,1]; TEXCOORD_4.w = mesh uv.y carries
//   the inside/outside (and cap) lerp flag in [0,1]. Preserved exactly.

Shader "HGRP/VlbGeneratedShader_Fix" {
    Properties {
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        _ColorFlat ("Color", Color) = (1, 1, 1, 1)

        [Header(Cone)]
        _ConeParams0 ("xy:_ConeRadius zw:_ConeSlopeCosSin", Vector) = (0, 0, 0, 0)
        _ConeParams1 ("xyz:_LocalForwardDirection w:_DrawCap", Vector) = (0, 0, 0, 0)
        _ConeGeomProps ("_ConeGeomProps (axis Z bias)", Float) = 0
        _DistanceFallOff ("xy:fadeStart/End z:_ w:fallOffEnd", Vector) = (0, 0, 0, 0)

        [Header(Alpha and Glare)]
        _AlphaInside ("Alpha Inside", Float) = 1
        _AlphaOutside ("Alpha Outside", Float) = 1
        _FresnelPow ("Fresnel Pow", Range(0, 15)) = 1
        _GlareFrontal ("Glare Frontal", Range(0, 1)) = 0.5
        _GlareBehind ("Glare from Behind", Range(0, 1)) = 0.5

        [Header(Distance Fade)]
        _DistanceCamClipping ("Camera Clipping Distance", Float) = 0.5
        _DistanceFadeStart ("Distance Fade Start", Range(0.001, 3000)) = 0.001
        _DistanceFadeEnd ("Distance Fade End", Range(0.001, 3000)) = 0.001
        _DistanceFadeStartSecond ("Distance Fade Start Second", Range(0.001, 3000)) = 0.001
        _DistanceFadeEndSecond ("Distance Fade End Second", Range(0.001, 3000)) = 0.001
        _AttenuationLerpLinearQuad ("Lerp attenuation linear<->quad", Float) = 0.5

        [Header(Tilt)]
        _TiltVectorX ("_TiltVectorX", Float) = 0
        _TiltVectorY ("_TiltVectorY", Float) = 0

        [Header(Depth Blend)]
        [Toggle(VLB_DEPTH_BLEND)] _UseDepthBlend ("Use Depth Blend", Float) = 0
        _DepthBlendDistance ("Depth Blend Distance", Float) = 2
        [ToggleUI] _DepthBlendCapOff ("Depth Blend Cap Off", Float) = 0

        [Header(Clipping Plane)]
        [ToggleUI] _UseClippingPlane ("Use Clipping Plane", Float) = 0
        _AdditionalClippingPlaneWS ("AdditionalClippingPlaneWS", Vector) = (0, 0, 0, 0)
        _ClippingPlaneTransition ("ClippingPlaneTransition", Range(0.01, 10)) = 1

        [Header(Noise 3D)]
        [Toggle(VLB_NOISE_3D)] _UseNoise3D ("Use 3D Noise", Float) = 0
        _VLB_NoiseTex3D ("NoiseTex3D", 3D) = "" {}
        _NoiseVelocity ("xyz:Noise Velocity w:Noise Mode", Vector) = (0, 0, 0, 0)
        _NoiseScale ("xyz:Noise Scale w:Noise Intensity", Vector) = (0, 0, 0, 0)
        _NoiseIntensity ("_NoiseIntensity", Float) = 0

        [Header(VFX Color Adjustment)]
        _VFXParams1 ("VFX Tint.rgb w:Saturation", Vector) = (1, 1, 1, 1)
        _NoiseObjW ("Noise object-space time scalar", Float) = 0

        [Header(VLB Cone Per-Draw Data (CPU-filled, see header NOTE))]
        _VlbConeRow7 ("ConeRow7 (x,_,_,w noise TRS)", Vector) = (0, 0, 0, 0)
        _VlbConeRow8 ("ConeRow8 (xyz noise scale)", Vector) = (0, 0, 0, 0)
        _VlbConeRow9 ("ConeRow9 (x,y cone radius)", Vector) = (1, 1, 0, 0)
        _VlbConeRow10 ("ConeRow10 (xyz slope/forward)", Vector) = (0, 0, 1, 0)
        _VlbConeRow11 ("ConeRow11 (z cone Z scale)", Vector) = (0, 0, 1, 0)

        [Header(Blend State)]
        [Enum(UnityEngine.Rendering.BlendMode)] _BlendSrcFactor ("BlendSrcFactor", Float) = 1
        [Enum(UnityEngine.Rendering.BlendMode)] _BlendDstFactor ("BlendDstFactor", Float) = 1
    }

    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
            "IgnoreProjector"="True"
            "DisableBatching"="True"
        }
        LOD 200

        Pass {
            Name "VlbForward"
            // Source: vlbgeneratedshader.shader:45-48 — Blend [_BlendSrcFactor][_BlendDstFactor] both targets,
            //   ZClip On, ZWrite Off, Cull Front (cone is rendered back-faces so the camera sees the inside).
            Blend [_BlendSrcFactor] [_BlendDstFactor], [_BlendSrcFactor] [_BlendDstFactor]
            ZWrite Off
            ZTest LEqual
            Cull Front
            Tags { "LightMode"="UniversalForwardOnly" }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag

            #pragma shader_feature_local VLB_DEPTH_BLEND
            #pragma shader_feature_local VLB_NOISE_3D

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

            // ---- Decoded magic constants (denormalized-float bit patterns -> real values) ----
            static const float VLB_ONE          = 1.0;                              // asfloat(1065353216u)
            static const float VLB_FALLOFF_K    = 5.000000476837158203125;          // ~5.0  cap-falloff slope (b9:99)
            static const float VLB_CAP_EPS_BIAS = 1.00100004673004150390625;        // ~1.001 cap mix bias (b9:132)
            static const float VLB_DRAWCAP_EPS  = 9.9999997473787516355514526367188e-06; // 1e-5 drawCap compare bias (b9:136)
            static const float3 VLB_LUMA = float3(0.21267290413379669189453125,
                                                  0.715152204036712646484375,
                                                  0.072175003588199615478515625); // Rec.709 luma (b9:145)

            CBUFFER_START(UnityPerMaterial)
                float  _GlareFrontal;
                float  _GlareBehind;
                float  _AlphaInside;
                float  _AlphaOutside;
                float  _DistanceFadeStart;
                float  _DistanceFadeEnd;
                float  _DistanceFadeStartSecond;
                float  _DistanceFadeEndSecond;
                float  _TiltVectorX;
                float  _TiltVectorY;
                float  _AttenuationLerpLinearQuad;
                float  _FresnelPow;
                float  _DistanceCamClipping;
                float  _ClippingPlaneTransition;
                float  _DepthBlendDistance;
                float  _DepthBlendCapOff;
                float  _ConeGeomProps;
                float  _BlendMode;
                float  _UseClippingPlane;
                float  _NoiseIntensity;
                float  _NoiseObjW;
                float4 _ColorFlat;
                float4 _AdditionalClippingPlaneWS;
                float4 _NoiseVelocity;
                float4 _NoiseScale;
                float4 _ConeParams0;
                float4 _ConeParams1;
                float4 _DistanceFallOff;
                float4 _VFXParams1;
                // VLB per-draw cone data re-exposed (CPU fills these; see header NOTE). Replaces
                // the decompiled _unity_ObjectToWorld[7u..11u] register slots from the VLB MPB upload.
                float4 _VlbConeRow7;
                float4 _VlbConeRow8;
                float4 _VlbConeRow9;
                float4 _VlbConeRow10;
                float4 _VlbConeRow11;
            CBUFFER_END

            TEXTURE3D(_VLB_NoiseTex3D);    SAMPLER(sampler_VLB_NoiseTex3D);

            // URP supplies a clamped point/linear sampler for the camera depth read.
            #ifdef VLB_DEPTH_BLEND
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"
            #endif

            // smoothstep01: (t*t)*(3-2t) on a pre-clamped t — the decompiler's mad(t,-2,3)*t*t idiom.
            float Vlb_Smooth01(float t) { return (t * t) * mad(t, -2.0, 3.0); }

            struct Attributes
            {
                float4 positionOS : POSITION;   // VLB parametric cone vertex (.z = radial param)
                float2 uv         : TEXCOORD0;   // .x = side/cap flag, .y = inside/outside flag
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float4 coneDist   : TEXCOORD1; // TEXCOORD_1 in blob: .xyz cone-axis pos, .w near-clip W (camera-relative)
                float3 conePos2   : TEXCOORD2; // TEXCOORD_1_1: cone-axis pos (unrotated-by-tilt variant)
                float3 worldPos   : TEXCOORD3; // TEXCOORD_2: world-space position (clip plane + fog)
                float4 viewPos    : TEXCOORD4; // TEXCOORD_3: .xyz view-space pos, .w = uv.x side flag
                float4 camRel     : TEXCOORD5; // TEXCOORD_4: .xyz camera-relative cone vector, .w = uv.y flag
            #if defined(VLB_DEPTH_BLEND) && defined(VLB_NOISE_3D)
                float3 noiseUVW   : TEXCOORD6; // TEXCOORD_5 (b14): 3D noise sample coord
                float4 depthProj  : TEXCOORD7; // TEXCOORD_6 (b14): screen-proj for depth-blend
            #elif defined(VLB_DEPTH_BLEND)
                float4 depthProj  : TEXCOORD6; // TEXCOORD_5 (b8 path): screen-proj for depth-blend
            #elif defined(VLB_NOISE_3D)
                float3 noiseUVW   : TEXCOORD6;
            #endif
            };

            // =====================================================================================
            // VERTEX — 1:1 from Sub0_Pass0_Vertex_b8.hlsl:72-161 (noise/depth additions from b14:182-189).
            //
            // CLOSED (1:1) — two INFRA substitutions, both faithful (math/constants/signs verbatim):
            //   (a) cone geometry: _unity_ObjectToWorld[7u..11u] (a per-draw float4[12] register array filled by
            //       the VLB C# component's MaterialPropertyBlock, b14:54-57,92-184) -> re-exposed as material Vectors
            //       _VlbConeRow7.._Row11 (read into row7..row11 below). The CPU fills the SAME values it already
            //       uploads, so this is a binding rename, not a behavioral change. vs b8:75-160 / b14:182-189.
            //   (b) projection: _NonJitteredViewNoTransProjMatrix (HGRP no-translation VP, b8:88-92) -> UNITY_MATRIX_VP
            //       applied to the ABSOLUTE world cone position (camPos folded back, RainSplash-established
            //       transpose/translation equivalence; see positionCS below). Pixel-identical.
            //
            // ENGINE-SIDE RESIDUAL (the only un-closeable delta): the blob also folds a TAA sub-pixel JITTER into
            //   clip.x/.y — b14:106-107 mad(-(W*_TaaJitterStrength.z), 2, clip.x) / mad(-(W*_TaaJitterStrength.w),
            //   -2, clip.y). _TaaJitterStrength is an HGRP ShaderVariablesGlobal (c101) written ONLY by HG's
            //   temporal-AA ScriptableRenderFeature per frame; URP's no-TAA forward path has no such global and the
            //   jitter is sub-pixel by construction, so it is dropped (pixel-neutral per PORT DISCIPLINE). A URP TAA
            //   render-feature porting that jitter would re-add the two mad() terms. NOT a material formula.
            // =====================================================================================
            Varyings vert(Attributes IN)
            {
                Varyings OUT = (Varyings)0;

                float3 camPos = _WorldSpaceCameraPos;
                float4x4 vpMat = UNITY_MATRIX_VP;   // substitutes _NonJitteredViewNoTransProjMatrix (jitter dropped)
                float4x4 vMat  = UNITY_MATRIX_V;    // substitutes _ViewMatrix

                // Cone data rows (re-exposed per-draw slots).
                float4 row7  = _VlbConeRow7;
                float4 row8  = _VlbConeRow8;
                float4 row9  = _VlbConeRow9;
                float4 row10 = _VlbConeRow10;
                float4 row11 = _VlbConeRow11;

                float zz = IN.positionOS.z * IN.positionOS.z;                       // _43 (b8:74)
                float r  = max(row9.y, row9.x);                                     // _67/_68 (b8:75-76)
                float rz = r * row10.z;                                             // _72 (b8:77)
                float rx = row9.x / r;                                              // _79 (b8:78)
                float a  = mad(zz, (-rx) + (row9.y / r), rx);                       // _84 (b8:79)
                float px = mad(IN.positionOS.x, a, ((zz * row10.x) * row11.z) / rz); // _90 (b8:80)
                float py = mad(IN.positionOS.y, a, ((zz * row10.y) * row11.z) / rz); // _91 (b8:81)

                // Cone-local position carried into the camera-relative frame (b8:82-84).
                float c0 = mad(_TiltVectorX, zz, mad(_GlareFrontal, px, py * _DistanceFadeStart))        + _DistanceCamClipping;
                float c1 = mad(_TiltVectorY, zz, mad(_GlareBehind,  px, py * _DistanceFadeEnd))          + _ClippingPlaneTransition;
                float c2 = mad(_AttenuationLerpLinearQuad, zz, mad(_AlphaInside, px, py * _DistanceFadeStartSecond)) + _DepthBlendDistance;

                // b8:85-87 form the camera-RELATIVE position (c - camPos) the HGRP no-translation VP consumes
                // (_140/_141/_142). Under URP we instead feed the ABSOLUTE position (c0,c1,c2) to UNITY_MATRIX_VP
                // (which carries the view translation), so this subtraction is folded away — see positionCS below.

                // Clip-space projection (URP VP substitutes _NonJitteredViewNoTransProjMatrix; jitter dropped).
                // 1:1 = b8:88-92. The blob's matrices are cbuffer column_major uploaded from Unity's
                //   row-major Matrix4x4, so SPIRV-Cross indexing is TRANSPOSED vs the math matrix:
                //   blob M[col].row == math M._m{row}{col} (verified by the sibling RainSplash port,
                //   HGRP_RainSplash_Fix.shader:302-338, and VfxRadialBlur:198-203). The SSA chain
                //   out.j = sum_i v_i*M[i][j] therefore decodes to the STANDARD transform
                //   mul(M_math, v_column) — matrix-on-LEFT, NOT mul(v,M).
                // Camera-relative: the blob feeds the camera-RELATIVE position (c - camPos) into the
                //   HGRP no-translation VP. URP UNITY_MATRIX_VP = P*V INCLUDES the view translation, so we
                //   must apply it to the ABSOLUTE world position (= c, i.e. add camPos back) or the camera
                //   translation is subtracted twice and the beam drifts with the camera
                //   (RainSplash:327-338: P*V*c = P*R*(c - camPos)). worldPos below is exactly (c0,c1,c2).
                OUT.positionCS = mul(vpMat, float4(c0, c1, c2, 1.0));               // b8:88-92 (mul(VP, absWorld))

                float z11 = asfloat(asuint(row11).z);                              // _243 (b8:94)

                // TEXCOORD_1.w: near-clip W = the .w of the VP-projected SECOND position. b8:93 projects the
                // camera-RELATIVE offset (-camPos + {DistanceCamClipping, ClippingPlaneTransition,
                // DepthBlendDistance}) through the no-translation VP and keeps .w. Same column-major decode
                // (blob M[col].w == math M._m3{col}) -> this is mul(VP_math, posCol).w with matrix-on-LEFT,
                // and the camPos must be added back to feed UNITY_MATRIX_VP (P*V incl. translation), exactly
                // like positionCS above. Absolute position = (DistanceCamClipping, ClippingPlaneTransition,
                // DepthBlendDistance) (camera-independent cone clip params).
                OUT.coneDist.w = mul(vpMat, float4(_DistanceCamClipping, _ClippingPlaneTransition, _DepthBlendDistance, 1.0)).w; // b8:93
                OUT.coneDist.x = px * r;                                            // _67 used as scale (b8:95)
                OUT.coneDist.y = py * r;                                            // (b8:96)
                OUT.coneDist.z = zz * z11;                                          // (b8:97)

                OUT.conePos2.x = (a * IN.positionOS.x) * r;                         // TEXCOORD_1_1 (b8:98)
                OUT.conePos2.y = (a * IN.positionOS.y) * r;                         // (b8:99)
                OUT.conePos2.z = zz * z11;                                          // (b8:100)

                OUT.worldPos = float3(c0, c1, c2);                                 // TEXCOORD_2 (b8:101-103)

                // TEXCOORD_3: view-space position (vMat substitutes _ViewMatrix, the FULL view matrix incl.
                // translation), .w = uv.x flag. b8:104-106 adds _ViewMatrix[3].xyz (translation column) and
                // feeds the ABSOLUTE world position (c0,c1,c2) — so no camPos reconstruction (unlike the VP
                // cases). Same column-major transpose decode -> mul(V_math, absWorld), matrix-on-LEFT
                // (== TransformWorldToView; RainSplash:302-306 establishes _ViewMatrix[col].row == V._m{row}{col}).
                OUT.viewPos.xyz = mul(vMat, float4(c0, c1, c2, 1.0)).xyz;          // b8:104-106 (mul(V, absWorld))
                OUT.viewPos.w   = IN.uv.x;                                          // (b8:107)

                // ---- camera-relative cone "tangent" vector (TEXCOORD_4) — the big dot()-of-cofactor block.
                // 1:1 transcription of b8:108-160. This reconstructs the inverse cone-basis times camera,
                // i.e. where the camera sits relative to the cone, used by the fragment for inside/outside.
                float k307 = _AlphaInside  * _FresnelPow;                           // (b8:108)
                float k308 = _AlphaOutside * _AttenuationLerpLinearQuad;
                float k309 = _AlphaOutside * _TiltVectorY;
                float k310 = _GlareBehind  * _FresnelPow;
                float k341 = _AlphaOutside * _TiltVectorX;                          // (b8:112)
                float k342 = _GlareFrontal * _FresnelPow;
                float k343 = _GlareBehind  * _AttenuationLerpLinearQuad;
                float k344 = _AlphaInside  * _TiltVectorY;
                float m353 = mad(-k343, _DepthBlendCapOff, mad(k344, _DepthBlendCapOff, mad(k310, _DepthBlendDistance, mad(-k309, _DepthBlendDistance, mad(k308, _ClippingPlaneTransition, -(k307 * _ClippingPlaneTransition)))))); // _353 (b8:116)
                float k368 = _DistanceFadeEndSecond * _AttenuationLerpLinearQuad;   // (b8:117)
                float k369 = _DistanceFadeStartSecond * _FresnelPow;
                float k370 = _DistanceFadeEnd * _FresnelPow;
                float k371 = _DistanceFadeEndSecond * _TiltVectorY;
                float k402 = _DistanceFadeEndSecond * _TiltVectorX;                 // (b8:121)
                float k403 = _DistanceFadeStart * _FresnelPow;
                float k404 = _DistanceFadeStartSecond * _TiltVectorY;
                float k405 = _DistanceFadeEnd * _AttenuationLerpLinearQuad;
                float m414 = mad(k405, _DepthBlendCapOff, mad(-k404, _DepthBlendCapOff, mad(-k370, _DepthBlendDistance, mad(k371, _DepthBlendDistance, mad(k369, _ClippingPlaneTransition, -(k368 * _ClippingPlaneTransition)))))); // _414 (b8:125)
                float k429 = _AlphaOutside * _DistanceFadeStartSecond;             // (b8:126)
                float k430 = _AlphaInside  * _DistanceFadeEndSecond;
                float k431 = _GlareBehind  * _DistanceFadeEndSecond;
                float k432 = _AlphaOutside * _DistanceFadeEnd;
                float k463 = _AlphaOutside * _DistanceFadeStart;                   // (b8:130)
                float k464 = _GlareFrontal * _DistanceFadeEndSecond;
                float k465 = _AlphaInside  * _DistanceFadeEnd;
                float k466 = _GlareBehind  * _DistanceFadeStartSecond;
                float m475 = mad(k466, _DepthBlendCapOff, mad(-k465, _DepthBlendCapOff, mad(-k431, _DepthBlendDistance, mad(k432, _DepthBlendDistance, mad(k430, _ClippingPlaneTransition, -(k429 * _ClippingPlaneTransition)))))); // _475 (b8:134)
                // _511 = 1 / determinant-ish term (b8:135)
                float inv511 = 1.0 / mad(_DistanceCamClipping,
                                    mad(-k466, _FresnelPow, mad(k465, _FresnelPow, mad(k431, _AttenuationLerpLinearQuad, mad(-k432, _AttenuationLerpLinearQuad, mad(k429, _TiltVectorY, -(k430 * _TiltVectorY)))))),
                                    mad(_TiltVectorX, m475, mad(_GlareFrontal, m414, m353 * _DistanceFadeStart)));
                float k532 = _DistanceFadeStartSecond * _TiltVectorX;             // (b8:136)
                float k533 = _DistanceFadeStart * _AttenuationLerpLinearQuad;
                float k534 = _DistanceFadeEnd * _TiltVectorX;
                float k535 = _DistanceFadeStart * _TiltVectorY;
                float4 camH = float4(camPos.x, camPos.y, camPos.z, VLB_ONE);       // _610/_612/_614/_615 (b8:140-143)

                // _617 : camera dotted with first cofactor row (b8:144)
                float d617 = dot(float4(inv511 * m414,
                    inv511 * mad(-k533, _DepthBlendCapOff, mad(k532, _DepthBlendCapOff, mad(k403, _DepthBlendDistance, mad(-k402, _DepthBlendDistance, mad(k368, _DistanceCamClipping, -(k369 * _DistanceCamClipping)))))),
                    inv511 * mad(k535, _DepthBlendCapOff, mad(-k534, _DepthBlendCapOff, mad(-k403, _ClippingPlaneTransition, mad(k402, _ClippingPlaneTransition, mad(k370, _DistanceCamClipping, -(k371 * _DistanceCamClipping)))))),
                    inv511 * mad(-k535, _DepthBlendDistance, mad(k534, _DepthBlendDistance, mad(k533, _ClippingPlaneTransition, mad(-k532, _ClippingPlaneTransition, mad(k404, _DistanceCamClipping, -(k405 * _DistanceCamClipping))))))), camH);

                float k660 = _AlphaInside  * _TiltVectorX;                         // (b8:145)
                float k661 = _GlareFrontal * _AttenuationLerpLinearQuad;
                float k662 = _GlareBehind  * _TiltVectorX;
                float k663 = _GlareFrontal * _TiltVectorY;
                // _713 : camera dotted with second cofactor row (b8:149)
                float d713 = dot(float4(inv511 * m353,
                    inv511 * mad(k661, _DepthBlendCapOff, mad(-k660, _DepthBlendCapOff, mad(-k342, _DepthBlendDistance, mad(k341, _DepthBlendDistance, mad(k307, _DistanceCamClipping, -(k308 * _DistanceCamClipping)))))),
                    inv511 * mad(-k663, _DepthBlendCapOff, mad(k662, _DepthBlendCapOff, mad(k342, _ClippingPlaneTransition, mad(-k341, _ClippingPlaneTransition, mad(k309, _DistanceCamClipping, -(k310 * _DistanceCamClipping)))))),
                    inv511 * mad(k663, _DepthBlendDistance, mad(-k662, _DepthBlendDistance, mad(-k661, _ClippingPlaneTransition, mad(k660, _ClippingPlaneTransition, mad(k343, _DistanceCamClipping, -(k344 * _DistanceCamClipping))))))), camH);

                float k756 = _AlphaInside  * _DistanceFadeStart;                   // (b8:150)
                float k757 = _GlareFrontal * _DistanceFadeStartSecond;
                float k758 = _GlareBehind  * _DistanceFadeStart;
                float k759 = _GlareFrontal * _DistanceFadeEnd;
                // _809 : camera dotted with third cofactor row (b8:154)
                float d809 = dot(float4(inv511 * m475,
                    inv511 * mad(-k757, _DepthBlendCapOff, mad(k756, _DepthBlendCapOff, mad(k464, _DepthBlendDistance, mad(-k463, _DepthBlendDistance, mad(k429, _DistanceCamClipping, -(k430 * _DistanceCamClipping)))))),
                    inv511 * mad(k759, _DepthBlendCapOff, mad(-k758, _DepthBlendCapOff, mad(-k464, _ClippingPlaneTransition, mad(k463, _ClippingPlaneTransition, mad(k431, _DistanceCamClipping, -(k432 * _DistanceCamClipping)))))),
                    inv511 * mad(-k759, _DepthBlendDistance, mad(k758, _DepthBlendDistance, mad(k757, _ClippingPlaneTransition, mad(-k756, _ClippingPlaneTransition, mad(k465, _DistanceCamClipping, -(k466 * _DistanceCamClipping))))))), camH);

                float a814 = z11 * d809;                                            // _814 (b8:155)
                float a818 = a814 / row10.z;                                        // _818 (b8:156)
                OUT.camRel.x = mad(-row10.x, a818, r * d617);                       // _ (b8:157)
                OUT.camRel.y = mad(-row10.y, a818, r * d713);                       // (b8:158)
                OUT.camRel.z = a814;                                               // (b8:159)
                OUT.camRel.w = IN.uv.y;                                            // (b8:160)

            #if defined(VLB_NOISE_3D)
                // 3D-noise object-space sample coord (b14:182-185). _VFXParams0.w (HG time) -> _NoiseObjW.
                OUT.noiseUVW.x = mad(mad(row7.w, mad(px, r, -c0), c0), row8.x, _NoiseObjW * row7.x);
                OUT.noiseUVW.y = mad(mad(row7.w, mad(py, r, -c1), c1), row8.y, _NoiseObjW * row7.y);
                OUT.noiseUVW.z = mad(mad(row7.w, mad(zz, z11, -c2), c2), row8.z, _NoiseObjW * row7.z);
            #endif

            #if defined(VLB_DEPTH_BLEND)
                // Screen-projection for the depth-blend scene read.
                // b14:186-189 builds it from the clip x/y the blob already computed; we use URP's
                // ComputeScreenPos on the clip position (equivalent, no TAA jitter term). TEXCOORD_3.z (view z)
                // is needed by the fragment too — supplied via viewPos.z above. depthProj.z carries -viewZ.
                float4 sp = ComputeScreenPos(OUT.positionCS);                       // = (clip.xy*0.5*ParamsX + 0.5*w, _, w)
                OUT.depthProj.x = sp.x;
                OUT.depthProj.y = sp.y;
                OUT.depthProj.z = -OUT.viewPos.z;                                   // TEXCOORD_6.z = -_305 (b14:127)
                OUT.depthProj.w = OUT.positionCS.w;                                 // _188 (b14:189)
            #endif

                return OUT;
            }

            // =====================================================================================
            // FRAGMENT — 1:1 from Sub0_Pass0_Fragment_b9.hlsl:94-151 (base), with
            //   VLB_DEPTH_BLEND additions from b11:100-160 and VLB_NOISE_3D additions from b15:135-153.
            // Output is SV_Target0 = float4(color.rgb, alpha); color/alpha split by _BlendMode
            //   (Additive=1 -> color carries intensity, alpha gated; Alpha=0 -> alpha carries intensity).
            // =====================================================================================
            float4 frag(Varyings IN) : SV_Target
            {
                // Re-bind interpolators to blob frag names BY SEMANTIC REGISTER (not by physical .xyz):
                //   frag TEXCOORD   (TEXCOORD1, float4) <- vertex TEXCOORD_1   = coneDist  (.xyz beam pos, .w nearClipW/fade)
                //   frag TEXCOORD_1 (TEXCOORD2, float3) <- vertex TEXCOORD_1_1 = conePos2  (cone-normal source)
                //   frag TEXCOORD_2 (TEXCOORD3, float3) <- worldPos ; TEXCOORD_3 (TEXCOORD4) <- viewPos ; TEXCOORD_4 (TEXCOORD5) <- camRel
                float3 t0xyz = IN.coneDist.xyz;        // frag TEXCOORD.xyz  (radial fall-off, b9:96 uses .x/.y/.z)
                float  t0z   = IN.coneDist.z;          // frag TEXCOORD.z    (depth-blend distance, b11:103)
                float  t0w   = IN.coneDist.w;          // frag TEXCOORD.w    (second-distance fade coord, b9:135)
                float3 t1    = IN.conePos2;            // frag TEXCOORD_1    (cone normal/axis, b9:102-103)
                float3 t2    = IN.worldPos;            // frag TEXCOORD_2
                float4 t3    = IN.viewPos;             // frag TEXCOORD_3
                float4 t4    = IN.camRel;              // frag TEXCOORD_4

                // ---- radial fall-off along the beam (b9:96-101) ----
                float dAxis = mad(t0xyz.y, _TiltVectorY, mad(t0xyz.x, _TiltVectorX, abs(t0xyz.z))); // _53
                float fo0   = clamp(dAxis / _DistanceFallOff.w, 0.0, 1.0);                          // _67
                float fo1   = clamp((dAxis - _DistanceFallOff.x) / (_DistanceFallOff.y - _DistanceFallOff.x), 0.0, 1.0); // _77
                float foCap = min((fo1 - 1.0) * (-VLB_FALLOFF_K), 1.0);                             // _82  (~ -5)
                float fo1i  = 1.0 - fo1;                                                            // _91
                float fo1s  = Vlb_Smooth01(fo1i);                                                   // _97

                // ---- cone normal vs view-to-fragment, Fresnel/glare (b9:102-131) ----
                float axisZ = t1.z + _ConeGeomProps;                                                // _114
                float invN  = rsqrt(dot(float3(t1.x, t1.y, axisZ), float3(t1.x, t1.y, axisZ)));     // _118
                float n0x = invN * t1.x, n0y = invN * t1.y, n0z = invN * axisZ;                     // _119-121

                float e0 = t1.x - t4.x, e1 = t1.y - t4.y, e2 = t1.z - t4.z;                         // _137-139
                float invV = rsqrt(dot(float3(e0, e1, e2), float3(e0, e1, e2)));                    // _143
                float v0 = invV * e0, v1 = invV * e1, v2 = invV * e2;                               // _144-146
                float capT = clamp(mad(e2, invV, -1.0) * (-0.5), 0.0, 1.0);                         // _150

                float vDotN = dot(float3(-v0, -v1, -v2), float3(n0x, n0y, n0z));                    // _154
                float tg0 = mad(-n0x, vDotN, -v0);                                                  // _163
                float tg1 = mad(-n0y, vDotN, -v1);                                                  // _164
                float tg2 = mad(-n0z, vDotN, -v2);                                                  // _165
                float invT = rsqrt(dot(float3(tg0, tg1, tg2), float3(tg0, tg1, tg2)));              // _169

                float invR = rsqrt(dot(float2(t1.x, t1.y), float2(t1.x, t1.y)));                    // _185
                float side = mad(t4.w, 2.0, -1.0);                                                  // _201  (uv.y in [0,1] -> [-1,1])
                float s0 = side * ((invR * t1.x) * _ConeParams0.z);                                // _203
                float s1 = side * ((invR * t1.y) * _ConeParams0.z);                                // _204
                float s2 = side * (-_ConeParams0.w);                                               // _209
                float sDotT = dot(float3(s0, s1, s2), float3(invT * tg0, invT * tg1, invT * tg2)); // _210
                float fwdDot = dot(float3(v0, v1, v2), float3(_ConeParams1.x, _ConeParams1.y, _ConeParams1.z)); // _225
                float coneEdge = clamp(mad(abs(fwdDot), (-sDotT) + dot(float3(s0, s1, s2), float3(-v0, -v1, -v2)), sDotT), 0.0, 1.0); // _232
                float coneS = Vlb_Smooth01(coneEdge);                                               // _235
                float coneNonZero = asfloat(((-coneS) >= 0.0) ? 0u : 0x3F800000u);                 // _242  (coneS>0 ? 1 : 0)

                float alphaIO = mad(t4.w, (-_AlphaInside) + _AlphaOutside, _AlphaInside);           // _262 inside/outside alpha lerp
                // Fresnel-glare power on the cone term (b9:131):
                float glare = mad(t4.w, (-_GlareFrontal) + _GlareBehind, _GlareFrontal);            // inner mad
                float fresPow = mad(abs(fwdDot), min(((-glare) + 1.0) * 1.5, _FresnelPow) + (-_FresnelPow), _FresnelPow);
                float coneFres = exp2(log2(coneS) * fresPow);                                       // _297 = pow(coneS, fresPow)
                float capMix = mad(t3.w, mad(-coneNonZero, coneFres, VLB_CAP_EPS_BIAS), coneFres * coneNonZero); // _304

                // ---- camera near-clip fade (b9:133) ----
                float camClip = clamp((abs(t3.z) - _ProjectionParams.y) / _DistanceCamClipping, 0.0, 1.0); // _323
                float blendInv = 1.0 - _BlendMode;                                                  // _358 (==_186 elsewhere)

                // ---- depth-blend factor (default = 1; replaced under VLB_DEPTH_BLEND) ----
                float depthBlend = 1.0;
                float capDist    = 1.0;     // VLB_DEPTH_BLEND replaces both
            #if defined(VLB_DEPTH_BLEND)
                // b11:100-105 / b13:144-149 / b15:135-140.
                float2 duv = IN.depthProj.xy / IN.depthProj.w;                                      // screen UV
                float sceneRaw = SampleSceneDepth(duv);                                             // T0.SampleLevel(_CameraDepthTexture)
                float sceneEye = 1.0 / mad(_ZBufferParams.z, sceneRaw, _ZBufferParams.w);           // _84 linear eye depth
                float dbT  = clamp(abs(t0z) / _DepthBlendDistance, 0.0, 1.0);                        // _120 (b11:103) = |TEXCOORD.z|
                capDist    = mad(_DepthBlendCapOff, mad(_DepthBlendDistance, dbT, -_DepthBlendDistance), _DepthBlendDistance); // _138 (b11:104)
                // ortho/persp scene-vs-beam eye-depth difference, softened by capDist (_140, b11:105):
                float beamEye  = max(IN.depthProj.z - _ProjectionParams.y, 0.0);                    // max(TEXCOORD_5.z - near, 0)
                float orthoEye = mad(unity_OrthoParams.w, (-sceneEye) + mad((-_ProjectionParams.y) + _ProjectionParams.z, (-sceneRaw) + 1.0, _ProjectionParams.y), sceneEye);
                depthBlend = clamp(((-beamEye) + max(orthoEye - _ProjectionParams.y, 0.0)) / capDist, 0.0, 1.0); // _140
            #endif

                // ---- 3D noise factor (default = 1; replaced under VLB_NOISE_3D) ----
                // NOTE(1:1, source = vlbgeneratedshader.shader:55-58,102-116 ladder): the source ONLY ever compiles
                //   VLB_NOISE_3D TOGETHER with VLB_DEPTH_BLEND (blobs b14/b15, b22/b23 — no noise-without-depth-blend
                //   variant exists). Both shipped pieces ARE ported 1:1 below: b15:141 (noiseFac = mad(_NoiseScale.w,
                //   noise.w-1, 1)) unconditionally, and b15:144's radial |v2|^10 lerp nested under VLB_DEPTH_BLEND
                //   (exactly where the blob places it). When _UseNoise3D is toggled ALONE (no depth-blend), the plain
                //   noiseFac is applied without that radial lerp — this is the only path with no source blob to bind;
                //   it is an asset extrapolation, not a feature drop. Nothing here is engine-side. vs b15:141-144.
                float noiseFac = 1.0;
            #if defined(VLB_NOISE_3D)
                // b15:141 : noiseFac = mad(_NoiseScale.w, noise.w - 1, 1)
                float noiseSample = SAMPLE_TEXTURE3D(_VLB_NoiseTex3D, sampler_VLB_NoiseTex3D, IN.noiseUVW).w; // T1.Sample
                noiseFac = mad(_NoiseScale.w, noiseSample - 1.0, 1.0);                              // _386
                #if defined(VLB_DEPTH_BLEND)
                // b15:144 raises the radial coord |v2| to the 10th power and lerps the noise in by it.
                float radialPow = exp2(log2(abs(v2)) * 10.0);                                       // pow(|_98|,10)
                noiseFac = mad(radialPow, (-noiseFac) + 1.0, noiseFac);                             // _ (b15:144 inner)
                #endif
            #endif

                // ---- additional world clipping plane (b9:136 inner / b11:143) ----
                float planeDist = dot(float3(_AdditionalClippingPlaneWS.x, _AdditionalClippingPlaneWS.y, _AdditionalClippingPlaneWS.z), t2) + _AdditionalClippingPlaneWS.w;
                float planeFac  = mad(clamp(planeDist / _ClippingPlaneTransition, 0.0, 1.0), _UseClippingPlane, 1.0 - _UseClippingPlane);

                // ---- draw-cap gate (b9:136 inner) : drawCap (_ConeParams1.w) vs side flag ----
                float drawCapGate = asfloat(((_ConeParams1.w >= (t3.w - VLB_DRAWCAP_EPS)) ? 0xFFFFFFFFu : 0u) & 0x3F800000u);

                // smoothstep on near-clip fade (b9:136): camClip^2*(3-2camClip)
                float camClipS = Vlb_Smooth01(camClip);

                // ---- second distance-fade (the long product, b9:136) ----
                float fadeS = abs(t0w);                                                              // _387
                float fadeSecond = clamp((fadeS - _DistanceFadeStartSecond) / (_DistanceFadeEndSecond - _DistanceFadeStartSecond), 0.0, 1.0);
                float fadeFirst  = clamp((fadeS - _DistanceFadeStart) / (_DistanceFadeEnd - _DistanceFadeStart), 0.0, 1.0);

                // depthBlend smooth-gate term: under VLB_DEPTH_BLEND the blob multiplies an extra
                // (min(dbT*100,1) * (capDist>0 ? ... : ...)) factor — folded as depthGate below.
            #if defined(VLB_DEPTH_BLEND)
                float depthEdge = mad(asfloat(((0.0 >= capDist) ? 0xFFFFFFFFu : 0u) & 0x3F800000u), (-depthBlend) + 1.0, depthBlend);
                float depthGate = mad(min(dbT * 100.0, 1.0), depthEdge - 1.0, 1.0);                 // b11:143
            #else
                float depthGate = 1.0;
            #endif

                // capMix combine with coneNonZero/coneFres (b9:413 numerator pieces, _242/_297/_304)
                float capMixCombined = mad(t4.w, mad(coneNonZero, coneFres, -capMix), capMix);      // mad(TEXCOORD_4.w, mad(_242,_297,-_304),_304)
                float capEdge        = mad(-t4.w, t3.w, 1.0);                                        // mad(-TEXCOORD_4.w, TEXCOORD_3.w, 1)

                // The big intensity product (_413 base / _443 depth-blend / _463 noise):
                float coreClip = drawCapGate * (camClipS * (noiseFac * planeFac));                  // base path folds noiseFac=1
            #if defined(VLB_DEPTH_BLEND)
                coreClip = drawCapGate * (camClipS * (depthGate * (noiseFac * planeFac)));          // b11:143 / b15:144
            #endif
                float coreIntensity = fadeSecond * (capMixCombined * (capEdge * coreClip)) * fadeFirst; // _413

                // ---- inside/outside + cap smoothing, linear<->quad attenuation (b9:137-138) ----
                float capSmoothMin = min(Vlb_Smooth01(capT), 1.0);                                  // _424
                float attenLin = 1.0 / mad(fo1 * fo1, 25.0, 1.0);                                   // 1/(1+25*fo1^2)
                float attenQuad = min(Vlb_Smooth01(foCap), 1.0);                                    // smooth(_82)
                float atten = mad(_AttenuationLerpLinearQuad, mad(attenLin, attenQuad, -fo1s), fo1s); // _ (b9:138 inner)
                float foMix = mad(t3.w, (-fo0) + 1.0, fo0);                                          // mad(TEXCOORD_3.w, 1-_67, _67)
                float capLerp = mad(t4.w, mad(capSmoothMin, -2.0, 1.0), capSmoothMin);              // mad(TEXCOORD_4.w, 1-2cap, cap)
                float intensity = capLerp * (foMix * (atten * coreIntensity));                      // _429

                // ---- Blend Mode split (b9:139-146) ----
                float modeIntensity = mad(intensity, _BlendMode, blendInv);                         // _433  (Additive: intensity; Alpha: 1)
                float modeColor     = mad(alphaIO * _ColorFlat.w, _BlendMode, blendInv);            // _437
                float3 tinted = float3(modeColor * _ColorFlat.x, modeColor * _ColorFlat.y, modeColor * _ColorFlat.z); // _443-445

                // ---- VFX color-grade (luma desaturate via _VFXParams1, b9:144-150) ----
                // exposureInv = 1 - _unity_Float4x5_Param0.x (b9:144 _450 / b11:154 _556 / b15:159 _589).
                // _unity_Float4x5_Param0 lives in cbuffer type_UnityPerDraw (register b1, packoffset c11, b9:35-39)
                // — the HG VFX SceneEffect "Dark" darken/fade per-draw MaterialPropertyBlock value, identical class
                // to _VlbConeRow* (the other per-draw b1 slots). For a standalone URP material with no SceneEffect /
                // VFX graph active, this slot takes its DEFAULT identity (Param0.x = 0) => exposureInv = 1.0. That is
                // the source's defined un-pulsed steady state (NOT a guess), matching the whole _Fix family
                // (HGRP_LitEffect_Fix:674-677, HGRP_LitEffectBlend_Fix:41-45, HGRP_VfxRadialBlur_Fix:182). A
                // ScriptableRenderFeature porting HG's HGVfxSceneEffect would write this per renderer to drive the fade.
                float exposureInv = 1.0; // = 1 - _unity_Float4x5_Param0.x (per-draw VFX darken; identity default 0)
                float luma = dot(float3(exposureInv * tinted.x, exposureInv * tinted.y, exposureInv * tinted.z), VLB_LUMA); // _455

                float outA = intensity * (exposureInv * (mad(_BlendMode, (-alphaIO) + 1.0, alphaIO) * _ColorFlat.w)); // SV_Target.w (_429*...)
                float negL = -luma;
                float3 outRGB;
                outRGB.x = modeIntensity * (mad(_VFXParams1.w, mad(tinted.x, exposureInv, negL), luma) * _VFXParams1.x); // SV_Target.x
                outRGB.y = modeIntensity * (mad(_VFXParams1.w, mad(tinted.y, exposureInv, negL), luma) * _VFXParams1.y); // SV_Target.y
                outRGB.z = modeIntensity * (mad(_VFXParams1.w, mad(tinted.z, exposureInv, negL), luma) * _VFXParams1.z); // SV_Target.z

                return float4(outRGB, outA);
            }
            ENDHLSL
        }
    }
    Fallback Off
}
