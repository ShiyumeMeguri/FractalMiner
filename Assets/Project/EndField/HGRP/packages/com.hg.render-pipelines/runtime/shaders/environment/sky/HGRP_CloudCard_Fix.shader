// HGRP CloudCard — transparent unlit billboard cloud card (sky/environment) — single ForwardOnly pass.
// Merged from: cloudcard.shader (inlined base blob 1=Vertex / blob 2=Fragment; only keyword SRP_INSTANCING_ON, dropped).
// Keywords: (none — base variant only). The _UseAtlas sub-rect path has NO decompiled branch in the source (the source
//   emits the base variant only), so there is no math to port — the atlas uniforms are kept inert for material compat.
// Kept: 6-color cloud grading (3-stop Shadows/Midtones/Highlights gradient driven by CloudMap.G + world-Y Top/Bottom
//   gradient with per-end strength), CloudMap RGBA (R=density/luma, G=vertical-gradient mask, A=opacity),
//   forced far-plane sky depth (clipPos.z=0), HGRP atmosphere + exponential-height + volumetric-froxel fog (ported 1:1
//   from blob lines 254-321; fog params re-exposed as material Vectors, froxel Texture3D is host-fed — see ENGINE-SIDE),
//   post saturation+exposure grade (_PostGrade), premultiplied-alpha output.
// Removed: GPU instancing (SRP_INSTANCING_ON / per-draw array), TAA jitter (_TaaJitterStrength), DXC-only plumbing.
// ENGINE-SIDE: _VolumetricLightingTexture (blob T0, Texture3D froxel) is produced by an HGRP VolumetricLighting compute
//   pass (camera-frustum froxel integration), not a material texture; URP has no such buffer. It is declared + sampled
//   1:1 (so wiring a host volumetric pass is a no-code change), reads neutral until that pass binds it. The whole froxel
//   branch is gated by _VolumetricFogParams0.z>0, so at URP defaults (param 0) it is never taken.
//
// NOTE: the 6 grade colors are HGRP per-draw-slot packed in the blob (unity_ObjectToWorld rows / unity_LODFade /
//   unity_WorldTransformParams / unity_MatrixPreviousM). URP has no such per-instance channel, so they are re-exposed
//   as plain material colors: _BaseColor (cloud tint*density, blob O2W[1]), _ShadowsColor (O2W[3]),
//   _MidtonesColor (unity_LODFade), _HighlightsColor (O2W[2]), _TopColor (unity_WorldTransformParams),
//   _BottomColor (unity_MatrixPreviousM[0]); _TopColorStrength=prevM[1].x, _BottomColorStrength=prevM[1].y.
// CloudMap channels: R = cloud luminance/density, G = vertical gradient selector (0..1), A = opacity.

Shader "HGRP/CloudCard_Fix" {
    Properties {
        [Header(Cloud)]
        [HDR] _BaseColor ("Base Color (x cloud R density)", Color) = (1, 1, 1, 1)
        _CloudMap ("Cloud Map (R=luma G=grad A=opacity)", 2D) = "white" {}

        [Header(Color Grading (by CloudMap.G))]
        [HDR] _HighlightsColor ("Highlights Color", Color) = (1, 1, 1, 1)
        [HDR] _MidtonesColor ("Midtones Color", Color) = (1, 1, 1, 1)
        [HDR] _ShadowsColor ("Shadows Color", Color) = (1, 1, 1, 1)

        [Header(Vertical Gradient (by world Y))]
        [HDR] _TopColor ("Top Color", Color) = (1, 1, 1, 1)
        _TopColorStrength ("Top Color Strength", Range(0, 1)) = 1
        [HDR] _BottomColor ("Bottom Color", Color) = (1, 1, 1, 1)
        _BottomColorStrength ("Bottom Color Strength", Range(0, 1)) = 1

        [Header(Post Grade)]
        // .xyz = per-channel post-exposure tint, .w = saturation (1=full color, 0=grayscale). Identity = (1,1,1,1).
        _PostGrade ("Post Grade (.xyz exposure, .w saturation)", Vector) = (1, 1, 1, 1)

        [Header(Atlas (unsupported — base path only))]
        [Toggle] _UseAtlas ("Use Atlas", Float) = 0
        _AtlasWidth ("Atlas Width", Float) = 2048
        _AtlasHeight ("Atlas Height", Float) = 2048
        _CloudWidth ("Cloud Width", Float) = 256
        _CloudHeight ("Cloud Height", Float) = 256
        _CloudIndexX ("Cloud Index X", Float) = 1
        _CloudIndexY ("Cloud Index Y", Float) = 1

        [Header(HG Fog (re-exposed globals - default 0 keeps fog inert))]
        // Same names as HGRP_MattePainting_Fix / HGRP_FogSimple_Fix so one host fog-volume bind feeds all three.
        _AtmosphereFogParams0 ("Atmosphere Fog 0", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams1 ("Atmosphere Fog 1", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams2 ("Atmosphere Fog 2", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams3 ("Atmosphere Fog 3", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams4 ("Atmosphere Fog 4", Vector) = (0, 0, 0, 0)
        _AtmosphereFogParams5 ("Atmosphere Fog 5", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams0 ("Exponential Fog 0", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams1 ("Exponential Fog 1", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams2 ("Exponential Fog 2", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams3 ("Exponential Fog 3", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams4 ("Exponential Fog 4", Vector) = (0, 0, 0, 0)
        _ExponentialFogParams5 ("Exponential Fog 5", Vector) = (0, 0, 0, 0)
        _VolumetricFogParams0 ("Volumetric Fog 0", Vector) = (0, 0, 0, 0)
        _VolumetricFogParams1 ("Volumetric Fog 1", Vector) = (0, 0, 0, 0)
        _VolumetricFogParams2 ("Volumetric Fog 2", Vector) = (0, 0, 0, 0)
        _VolumetricFogParams3 ("Volumetric Fog 3", Vector) = (0, 0, 0, 0)
        _VolumetricFogParams4 ("Volumetric Fog 4", Vector) = (0, 0, 0, 0)

        [Header(Render State)]
        [Enum(UnityEngine.Rendering.BlendMode)] _SrcBlend ("__src", Float) = 5   // SrcAlpha
        [Enum(UnityEngine.Rendering.BlendMode)] _DstBlend ("__dst", Float) = 10  // OneMinusSrcAlpha
        [HideInInspector] _ZWrite ("__zw", Float) = 0
        [Enum(UnityEngine.Rendering.CullMode)] _Cull ("__cull", Float) = 0       // Off (billboard, two-sided)
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0
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
                float4 _BaseColor;
                float4 _HighlightsColor;
                float4 _MidtonesColor;
                float4 _ShadowsColor;
                float4 _TopColor;
                float  _TopColorStrength;
                float4 _BottomColor;
                float  _BottomColorStrength;
                float4 _CloudMap_ST;
                float4 _PostGrade;
                // Atlas (unused by base path; kept for material compat)
                float _UseAtlas;
                float _AtlasWidth;
                float _AtlasHeight;
                float _CloudWidth;
                float _CloudHeight;
                float _CloudIndexX;
                float _CloudIndexY;
                float _TransparentSortPriority;

                // HG fog globals re-exposed as material Vectors (no URP equivalent — default 0 => fog branch is an
                // exact passthrough no-op: transmittance=1, inscatter=0). Same names/convention as HGRP_MattePainting_Fix
                // and HGRP_FogSimple_Fix so one host fog-volume bind feeds all three. (blob cbuffer lines 178-194.)
                float4 _AtmosphereFogParams0;
                float4 _AtmosphereFogParams1;
                float4 _AtmosphereFogParams2;
                float4 _AtmosphereFogParams3;
                float4 _AtmosphereFogParams4;
                float4 _AtmosphereFogParams5;
                float4 _ExponentialFogParams0;
                float4 _ExponentialFogParams1;
                float4 _ExponentialFogParams2;
                float4 _ExponentialFogParams3;
                float4 _ExponentialFogParams4;
                float4 _ExponentialFogParams5;
                float4 _VolumetricFogParams0;
                float4 _VolumetricFogParams1;
                float4 _VolumetricFogParams2;
                float4 _VolumetricFogParams3;
                float4 _VolumetricFogParams4;
            CBUFFER_END

            TEXTURE2D(_CloudMap);   SAMPLER(sampler_CloudMap);
            // HG volumetric froxel texture (blob T0, Texture3D, line 203) — produced by an HGRP VolumetricLighting
            // compute pass (camera-frustum froxel integration); no URP source. Sampled 1:1 in the _VolumetricFogParams0.z
            // froxel path; reads neutral until a host volumetric pass binds it.
            TEXTURE3D(_VolumetricLightingTexture); SAMPLER(sampler_VolumetricLightingTexture);

            // Rec.709 luma weights — blob line 322 float3(0.21267290,0.71515220,0.07217500).
            static const float3 LUMA_709 = float3(0.21267290413379669, 0.715152204036712646, 0.072175003588199615);

            // HG fog constants (shared with HGRP_MattePainting_Fix / HGRP_FogSimple_Fix). LOG2_E folds the blob's
            // exp2(x*LOG2_E)==exp(x) spelling (blob 1.44269502162933349609375f); VIEW_EPS = 1e-8 view-length floor
            // (blob line 234); BLUE_UNPACK = 1/32766 16-bit blue-noise unpack (blob line 288 froxel taps).
            static const float LOG2_E      = 1.44269502162933349609375;
            static const float VIEW_EPS    = 9.9999999392252902907785028219223e-09;
            static const float BLUE_UNPACK = 3.05180437862873077392578125e-05;

            // (1-exp2(-x))/x with a series fallback near 0; the blob spells this inline as
            // asfloat(|x|>5.96e-08 ? asuint((1-exp2(-x))/x) : asuint(mad(-x,0.2402265,0.6931472))). blob lines 285,305.
            float HgExpM1OverX(float x)
            {
                return (5.9604644775390625e-08 < abs(x))
                       ? ((((-0.0) - exp2((-0.0) - x)) + 1.0) / x)
                       : mad((-0.0) - x, 0.2402265071868896484375, 0.693147182464599609375);
            }
        ENDHLSL

        Pass {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }
            // Source (blob skeleton lines 34-36): Blend SrcAlpha OneMinusSrcAlpha, One OneMinusSrcAlpha; ZWrite Off; ZClip On.
            Blend [_SrcBlend] [_DstBlend], One OneMinusSrcAlpha
            ZWrite [_ZWrite]
            ZTest LEqual
            Cull [_Cull]

            HLSLPROGRAM
            // 4.5: the volumetric-froxel fog path needs SM4.5 integer ops (PCG hash) + Texture3D LOD sampling
            // (source was target 5.0); mirrors HGRP_MattePainting_Fix / HGRP_FogSimple_Fix.
            #pragma target 4.5
            #pragma vertex vert
            #pragma fragment frag

            struct Attributes {
                float3 positionOS : POSITION;
                float2 uv         : TEXCOORD0;
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float3 positionWS : TEXCOORD0;
                float2 uv         : TEXCOORD1;
            };

            Varyings vert(Attributes v)
            {
                Varyings o;

                // World-space position (blob vertex lines 119-128). Source computes camera-relative pos then
                // re-adds camera pos to recover positionWS for the fragment; URP TransformObjectToWorld is the same.
                float3 positionWS = TransformObjectToWorld(v.positionOS);
                o.positionWS = positionWS;

                // Clip position via view-no-translation * proj on the camera-relative position (blob lines 129-132).
                // TransformWorldToHClip(positionWS) is the URP equivalent (TAA jitter term _TaaJitterStrength dropped).
                o.positionCS = TransformWorldToHClip(positionWS);
                // Sky card forced to far plane: blob line 133 gl_Position.z = 0 (DX clip-space far).
                // UNITY_RAW_FAR_CLIP_VALUE is 0 under reversed-Z (the source's target), 1 otherwise.
                o.positionCS.z = UNITY_RAW_FAR_CLIP_VALUE * o.positionCS.w;

                // UV: blob lines 134-135  uv * _CloudMap_ST.xy + _CloudMap_ST.zw.
                o.uv = v.uv * _CloudMap_ST.xy + _CloudMap_ST.zw;
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                // ---- View direction (blob lines 229-238) ----
                // Ortho/persp selector (blob _51 = 0 == _unity_OrthoParams.w): perspective builds (camPos - posWS),
                // ortho uses the camera forward column _ViewMatrix[i].z == UNITY_MATRIX_V[i].z. Then len^2/rsqrt/dir.
                // Feeds the HG fog blocks below (rayDir _107/_108/_109, |viewVec| _110). eps 9.9999e-09 = 1e-8 (VIEW_EPS).
                bool isPersp = (0.0 == unity_OrthoParams.w);                         // blob _51
                float3 viewVec;
                viewVec.x = isPersp ? (((-0.0) - input.positionWS.x) + _WorldSpaceCameraPos.x) : UNITY_MATRIX_V[0].z; // blob _95
                viewVec.y = isPersp ? (((-0.0) - input.positionWS.y) + _WorldSpaceCameraPos.y) : UNITY_MATRIX_V[1].z; // blob _97
                viewVec.z = isPersp ? (((-0.0) - input.positionWS.z) + _WorldSpaceCameraPos.z) : UNITY_MATRIX_V[2].z; // blob _99
                float viewLenSq = dot(viewVec, viewVec);                             // blob _100
                float viewInvLen = rsqrt(max(viewLenSq, VIEW_EPS));                  // blob _106
                float3 rayDir = viewVec * viewInvLen;                               // blob _107/_108/_109
                float rayLenView = viewLenSq * viewInvLen;                           // blob _110 = |viewVec|

                // ---- Sample cloud map (blob lines 239-242). R=density, G=gradient, A=opacity ----
                float4 cloud = SAMPLE_TEXTURE2D(_CloudMap, sampler_CloudMap, input.uv); // blob _121
                float cloudR = cloud.x;                                            // blob _123
                float cloudG = cloud.y;                                            // blob _124
                float invG   = 1.0 - cloudG;                                       // blob _135

                // ---- 3-stop color grade selected by CloudMap.G (blob lines 243-250) ----
                // gradMid = lerp(Shadows, Midtones, 1-G); then lerp(gradMid, Highlights, G).  RGB + A together.
                // Shadows = O2W[3] (blob), Midtones = unity_LODFade, Highlights = O2W[2].
                float4 gradMid = lerp(_ShadowsColor, _MidtonesColor, invG);        // blob _165/_166/_167/_168
                float4 grade   = lerp(gradMid, _HighlightsColor, cloudG);          // blob _183/_184/_185/_186

                // ---- World-Y vertical gradient weights (blob lines 251-252) ----
                // _193 = posWS.y * TopColorStrength ; _220 = (1 - posWS.y) * BottomColorStrength.
                float wTop = input.positionWS.y * _TopColorStrength;               // blob _193
                float wBot = (1.0 - input.positionWS.y) * _BottomColorStrength;    // blob _220

                // ---- Blend grade toward Top/Bottom colors, averaged (blob lines 319-321 multiplier + line 253 alpha) ----
                // gradeFinal = 0.5*lerp(grade, Top, wTop) + 0.5*lerp(grade, Bottom, wBot), per RGBA channel.
                float4 gradeTop = lerp(grade, _TopColor,    wTop);
                float4 gradeBot = lerp(grade, _BottomColor, wBot);
                float4 gradeFinal = 0.5 * gradeTop + 0.5 * gradeBot;

                // ---- Cloud RGB = density(R) * BaseColor * gradeFinal.rgb (blob lines 319-321 outer term) ----
                float3 cloudColor = (cloudR * _BaseColor.rgb) * gradeFinal.rgb;

                // ---- Cloud alpha = cloudMap.A * gradeFinal.a * BaseColor.a (blob line 253) ----
                float alpha = cloud.w * gradeFinal.a * _BaseColor.a;

                // ---- HG atmosphere + exponential-height + volumetric-froxel fog (blob lines 254-321) ----
                // Ported 1:1 from the HG fog math (same lineage as HGRP_MattePainting_Fix b11 / HGRP_FogSimple_Fix). The
                // analytic atmosphere + height fog is pure formula on the re-exposed HG fog Vectors; the volumetric branch
                // samples the froxel Texture3D (engine-side, neutral until a host VolumetricLighting pass fills it). At
                // zero params: atmTrans=1, fogDensity=1, inscatter=0 => compose is an exact passthrough of cloudColor.
                {
                    // --- atmosphere transmittance + phase (blob lines 254-260, 317-318), from _AtmosphereFogParams* ---
                    float aDen = max(mad(input.positionWS.y, _AtmosphereFogParams3.w, _AtmosphereFogParams4.w), 0.00999999977648258209228515625); // blob _280
                    float aOpt = (exp2(mad(input.positionWS.y, _AtmosphereFogParams3.w, _AtmosphereFogParams5.w) * LOG2_E)
                                  * ((((-0.0) - exp2(aDen * (-LOG2_E))) + 1.0) / aDen))
                                 * ((-0.0) - max(mad(rayLenView, _AtmosphereFogParams1.w, (-0.0) - _AtmosphereFogParams0.w), 0.0)); // blob _304
                    float aTransR = exp2((aOpt * _AtmosphereFogParams2.x) * LOG2_E);   // blob _317
                    float aTransG = exp2((aOpt * _AtmosphereFogParams2.y) * LOG2_E);   // blob _318
                    float aTransB = exp2((aOpt * _AtmosphereFogParams2.z) * LOG2_E);   // blob _319
                    float aCos = dot(float3((-0.0) - rayDir.x, (-0.0) - rayDir.y, (-0.0) - rayDir.z),
                                     float3(_AtmosphereFogParams1.x, _AtmosphereFogParams1.y, _AtmosphereFogParams1.z)); // blob _328
                    float aPhaseDen = ((-0.0) - dot(aCos.xx, _AtmosphereFogParams2.w.xx)) + mad(_AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0); // blob _345
                    float rayleighPh = mad(aCos, aCos, 1.0) * 0.0596831031143665313720703125; // blob _817 = (1+cos^2)*3/(16pi)
                    float miePh = mad((-0.0) - _AtmosphereFogParams2.w, _AtmosphereFogParams2.w, 1.0)
                                  / max((aPhaseDen * 12.56637096405029296875) * sqrt(aPhaseDen), 0.001000000047497451305389404296875); // blob _846

                    // --- exponential-height + volumetric-froxel transmittance(_809) & inscatter(_810/_811/_812) ---
                    float fogDensity = 0.0;                    // blob _809
                    float3 fogColor  = float3(0.0, 0.0, 0.0);  // blob _810/_811/_812
                    if (0.0 < _VolumetricFogParams0.z)
                    {
                        // --- volumetric froxel path (blob lines 265-299) ---
                        uint px = uint(input.positionCS.x);   // blob _355
                        uint py = uint(input.positionCS.y);   // blob _356
                        // PCG-ish hash chain seeded by pixel + frame (blob lines 269-274). Source used _FrameCount;
                        // _Time.w (URP) is the nearest per-frame analog (matches HGRP_MattePainting_Fix / HGRP_FogSimple_Fix).
                        uint h0 = (py * 1664525u) + 1013904223u;                                   // blob _367
                        uint h1 = ((7u & (uint)_Time.w) * 1664525u) + 1013904223u;                 // blob _369
                        uint h2 = (h0 * h1) + ((px * 1664525u) + 1013904223u);                     // blob _371
                        uint h3 = (h1 * h2) + h0;                                                  // blob _373
                        uint h4 = (h2 * h3) + h1;                                                  // blob _375
                        uint h5 = (h3 * h4) + h2;                                                  // blob _377

                        // Camera-forward basis is the SAME column-2 vector used by the ortho view-vec above
                        // (blob _384 second arg = -(_ViewMatrix[0].z, _ViewMatrix[1].z, _ViewMatrix[2].z), i.e. column 2,
                        // NOT row 2). _ViewMatrix and UNITY_MATRIX_V are the same world->view matrix; M[i].z is row i's z.
                        float camForwardDotRay = dot(float3((-0.0) - rayDir.x, (-0.0) - rayDir.y, (-0.0) - rayDir.z),
                                                     float3((-0.0) - UNITY_MATRIX_V[0].z, (-0.0) - UNITY_MATRIX_V[1].z, (-0.0) - UNITY_MATRIX_V[2].z)); // blob _384
                        float heightAboveCam = input.positionWS.y + ((-0.0) - _WorldSpaceCameraPos.y);  // blob _393
                        float marchScale = asfloat(asuint(1.0 / camForwardDotRay) & ((5.9604644775390625e-08 < camForwardDotRay) ? 0xffffffffu : 0u)) * _VolumetricFogParams0.w; // blob _405
                        float invRayLen = 1.0 / rayLenView;                                       // blob _406
                        float marchT    = invRayLen * marchScale;                                 // blob _407
                        float sampleY   = mad(marchT, heightAboveCam, _WorldSpaceCameraPos.y);    // blob _411
                        float remHeight = mad((-0.0) - marchT, heightAboveCam, heightAboveCam);   // blob _413
                        float remFrac   = mad((-0.0) - marchScale, invRayLen, 1.0);               // blob _415

                        float e0 = max(remHeight * _ExponentialFogParams0.z, -127.0);             // blob _422
                        float e3 = max(remHeight * _ExponentialFogParams3.x, -127.0);             // blob _429
                        float fogIntegral = mad(
                            exp2((-0.0) - max((sampleY + ((-0.0) - _ExponentialFogParams0.x)) * _ExponentialFogParams0.z, -127.0)) * _ExponentialFogParams0.y,
                            HgExpM1OverX(e0),
                            HgExpM1OverX(e3) * (exp2((-0.0) - max((sampleY + ((-0.0) - _ExponentialFogParams3.z)) * _ExponentialFogParams3.x, -127.0)) * _ExponentialFogParams3.y)); // blob _491
                        float baseDen  = clamp(mad(rayLenView, _ExponentialFogParams1.w, _ExponentialFogParams1.z), 0.0, 1.0); // blob _503
                        float totalDen = min(baseDen + (clamp(mad(rayLenView, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0, 1.0)
                                         + max(min(exp2((-0.0) - ((rayLenView * remFrac) * fogIntegral)), 1.0), _ExponentialFogParams2.w)), 1.0); // blob _516

                        // froxel scattering color from the volumetric 3D texture (blob line 288). The blob's froxel-Z
                        // expression is `1.0f / gl_FragCoord.w`, but main() (blob line 332) already did
                        // `gl_FragCoord.w = 1.0 / gl_FragCoord.w` on the rasterizer value (SV_Position.w = 1/w_clip).
                        // So `1.0/gl_FragCoord.w` in the body resolves back to the rasterizer SV_Position.w (= 1/w_clip),
                        // which URP delivers directly as input.positionCS.w. (Do NOT re-invert it here.)
                        float viewZ = input.positionCS.w;
                        float3 froxelUVW = float3(
                            mad(mad(float(h5 >> 16u), BLUE_UNPACK, -1.0), _VolumetricFogParams4.w, float(px)) * _VolumetricFogParams2.x,
                            mad(mad(float(((h4 * h5) + h3) >> 16u), BLUE_UNPACK, -1.0), _VolumetricFogParams4.w, float(py)) * _VolumetricFogParams2.y,
                            (log2(mad(viewZ, _VolumetricFogParams1.x, _VolumetricFogParams1.y)) * _VolumetricFogParams1.z) / _VolumetricFogParams0.z);
                        float4 froxel = SAMPLE_TEXTURE3D_LOD(_VolumetricLightingTexture, sampler_VolumetricLightingTexture, froxelUVW, 0.0); // blob _565
                        float froxelMask  = clamp((viewZ + ((-0.0) - _VolumetricFogParams3.z)) * 1000000.0, 0.0, 1.0); // blob _582
                        float froxelTrans = mad(froxelMask, froxel.w + (-1.0), 1.0);              // blob _590
                        float invTotalDen = ((-0.0) - totalDen) + 1.0;                            // blob _592
                        float heightCol = exp2(log2(clamp(dot(rayDir, float3(_ExponentialFogParams4.x, _ExponentialFogParams4.y, _ExponentialFogParams4.z)), 0.0, 1.0)) * _ExponentialFogParams5.w); // blob _609
                        float dirTrans  = ((-0.0) - min(exp2((-0.0) - (max(mad(remFrac, rayLenView, (-0.0) - _ExponentialFogParams4.w), 0.0) * fogIntegral)), 1.0)) + 1.0; // blob _629
                        float invBaseDen = ((-0.0) - baseDen) + 1.0;                              // blob _634
                        fogDensity = totalDen * froxelTrans;                                      // blob _809
                        fogColor.x = mad(mad(_ExponentialFogParams2.x, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.x))), froxelTrans, mad(froxelMask, froxel.x + (-0.0), 0.0)); // blob _810
                        fogColor.y = mad(mad(_ExponentialFogParams2.y, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.y))), froxelTrans, mad(froxelMask, froxel.y + (-0.0), 0.0)); // blob _811
                        fogColor.z = mad(mad(_ExponentialFogParams2.z, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.z))), froxelTrans, mad(froxelMask, froxel.z + (-0.0), 0.0)); // blob _812
                    }
                    else
                    {
                        // --- analytic exponential-height fog path, no froxel (blob lines 300-315) ---
                        float heightAboveCam = input.positionWS.y + ((-0.0) - _WorldSpaceCameraPos.y);  // blob _656
                        float e3 = max(heightAboveCam * _ExponentialFogParams3.x, -127.0);        // blob _665
                        float e0 = max(heightAboveCam * _ExponentialFogParams0.z, -127.0);        // blob _666
                        float fogIntegral = mad(
                            exp2((-0.0) - max((_WorldSpaceCameraPos.y + ((-0.0) - _ExponentialFogParams0.x)) * _ExponentialFogParams0.z, -127.0)) * _ExponentialFogParams0.y,
                            HgExpM1OverX(e0),
                            HgExpM1OverX(e3) * (exp2((-0.0) - max((_WorldSpaceCameraPos.y + ((-0.0) - _ExponentialFogParams3.z)) * _ExponentialFogParams3.x, -127.0)) * _ExponentialFogParams3.y)); // blob _732
                        float baseDen  = clamp(mad(rayLenView, _ExponentialFogParams1.w, _ExponentialFogParams1.z), 0.0, 1.0); // blob _743
                        float totalDen = min(baseDen + (clamp(mad(rayLenView, _ExponentialFogParams1.y, _ExponentialFogParams1.x), 0.0, 1.0)
                                         + max(min(exp2((-0.0) - (rayLenView * fogIntegral)), 1.0), _ExponentialFogParams2.w)), 1.0); // blob _755
                        float invTotalDen = ((-0.0) - totalDen) + 1.0;                            // blob _757
                        float heightCol = exp2(log2(clamp(dot(rayDir, float3(_ExponentialFogParams4.x, _ExponentialFogParams4.y, _ExponentialFogParams4.z)), 0.0, 1.0)) * _ExponentialFogParams5.w); // blob _772
                        // dirTrans uses viewLenSq*viewInvLen == rayLenView; blob _792 spells mad(_100,_106,...).
                        float dirTrans  = ((-0.0) - min(exp2((-0.0) - (max(mad(viewLenSq, viewInvLen, (-0.0) - _ExponentialFogParams4.w), 0.0) * fogIntegral)), 1.0)) + 1.0; // blob _792
                        float invBaseDen = ((-0.0) - baseDen) + 1.0;                              // blob _797
                        fogDensity = totalDen;                                                    // blob _809
                        fogColor.x = mad(_ExponentialFogParams2.x, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.x))); // blob _810
                        fogColor.y = mad(_ExponentialFogParams2.y, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.y))); // blob _811
                        fogColor.z = mad(_ExponentialFogParams2.z, invTotalDen, invBaseDen * (dirTrans * (heightCol * _ExponentialFogParams5.z))); // blob _812
                    }

                    // ---- compose: cloudColor*atmTrans*fogDensity + ((clamp(atmInscatter,0,1)*255)*(1-atmTrans)*fogDensity
                    // + heightInscatter), per channel (blob lines 319-321 outer mad). atmInscatter = clamp(AtmFog4*miePh +
                    // AtmFog3*rayleighPh + AtmFog5, 0, 1). ----
                    float3 fogged;
                    fogged.x = mad(cloudColor.x, fogDensity * aTransR, mad((clamp(mad(_AtmosphereFogParams4.x, miePh, mad(_AtmosphereFogParams3.x, rayleighPh, _AtmosphereFogParams5.x)), 0.0, 1.0) * 255.0) * (((-0.0) - aTransR) + 1.0), fogDensity, fogColor.x)); // blob _874
                    fogged.y = mad(cloudColor.y, fogDensity * aTransG, mad((clamp(mad(_AtmosphereFogParams4.y, miePh, mad(_AtmosphereFogParams3.y, rayleighPh, _AtmosphereFogParams5.y)), 0.0, 1.0) * 255.0) * (((-0.0) - aTransG) + 1.0), fogDensity, fogColor.y)); // blob _875
                    fogged.z = mad(cloudColor.z, fogDensity * aTransB, mad((clamp(mad(_AtmosphereFogParams4.z, miePh, mad(_AtmosphereFogParams3.z, rayleighPh, _AtmosphereFogParams5.z)), 0.0, 1.0) * 255.0) * (((-0.0) - aTransB) + 1.0), fogDensity, fogColor.z)); // blob _876
                    cloudColor = fogged;
                }

                // ---- Post saturation + exposure grade (blob lines 322-326) ----
                // luma = dot(rgb, Rec709); out = lerp(luma, rgb, _PostGrade.w) * _PostGrade.xyz.
                // Source _VFXParams1: .w = saturation, .xyz = per-channel post-exposure (identity = (1,1,1,1)).
                float luma = dot(cloudColor, LUMA_709);                            // blob _877
                float3 outColor;
                outColor.x = mad(_PostGrade.w, cloudColor.x - luma, luma) * _PostGrade.x; // blob _874 line 324
                outColor.y = mad(_PostGrade.w, cloudColor.y - luma, luma) * _PostGrade.y; // blob _875 line 325
                outColor.z = mad(_PostGrade.w, cloudColor.z - luma, luma) * _PostGrade.z; // blob _876 line 326

                // Output. Source render-state Blend SrcAlpha OneMinusSrcAlpha (straight alpha on RGB), alpha-channel
                // factors One/OneMinusSrcAlpha; RGB is NOT premultiplied in-shader (the SrcAlpha blend does it).
                return half4(outColor, alpha);
            }
            ENDHLSL
        }
    }

    FallBack Off
}
