// HGRP VFXCaptureMesh — unlit, transparent, particle-aware VFX surface that captures a (skinned)
//   mesh into an offscreen render target — single ForwardOnly pass.
// The base blob math is the SAME unlit VFX core as the rest of the HGVfx family: scrolling/rotating
//   UV → MainTex → tint × vertex-color × intensity → exposure normalize → premultiplied-alpha out.
// (source = vfxcapturemesh/Sub0_Pass0_Fragment_b29.hlsl:80-109, base catch-all #else)
//
// Merged from: Sub0_Pass0_*_b28/b29 (base = catch-all #else, kw HG_ENABLE_MV),
//   b31/b35 (_USE_FRESNEL — view-dir NdotV fresnel toward _FresnelColor),
//   b33 (_USE_DISSOLVE — dissolve-tex edge mask + emissive edge),
//   b37 (_USE_MASK + _USE_SCREENUV — second-tex modulation + screen/world reprojected UV channel).
// Keywords: _USE_FRESNEL, _USE_DISSOLVE, _USE_SCREENUV, _USE_MASK
// Kept (math 1:1 from the blobs): particle UV scroll/rotate/weights (MainTex + Mask + Dissolve),
//   _UseMainTex/MaskTexAsAlpha channel select, vertex-color × tint × intensity, exposure normalize
//   (clamp 0..1000), premultiplied-alpha output with additive/alpha gate (1-_BlendMode),
//   fresnel rim (pow(saturate(NdotV+bias),power) flip → lerp to _FresnelColor) + fresnel-opacity,
//   dissolve edge (clamp(((-edge)·sharp),0,1) → emissive edge color + schedule offset),
//   screen-UV reconstruction (depth-aware world XZ projected through view, polar/world V option).
// Removed (pixel-neutral pipeline infra substituted by URP, or sandbox-irrelevant):
//   GPU skinning (T0 ByteAddressBuffer skin-matrix palette + BLENDWEIGHTS/BLENDINDICES; URP skins
//     automatically — see Vertex_b28.hlsl:72-328, IDENTICAL across all variants),
//   motion vectors / SV_Target1 + HG_ENABLE_MV + prev-frame matrices + TAA jitter (separate URP MV pass;
//     Fragment_b29.hlsl:99-108 SV_Target1 dropped),
//   camera-relative-world rebasing (_WorldSpaceCameraPos_Internal subtract) — URP uses absolute WS,
//   _GlobalMipBias on the sampler, _unity_LODFade crossfade, _VFXParams0.w time (-> URP _Time.y),
//   _IgnorePostExposure exposure global re-exposed as a material Vector (_ExposureParams).
//
// NOTE: the fresnel variant (b31/b35) reuses the same packoffset slots the dissolve variant uses for
//   different uniforms (compiler aliasing): c11=_FresnelBias, c11.z=_FresnelPower, c11.w=_FresnelFlip,
//   _FresnelColor lives in a separate type_Globals cbuffer. They are exposed here under their TRUE
//   semantic names (matching the source Properties block lines 37-42).
// NOTE: _MainUVSet/_MaskUVSet/_DissolveUVSet (UV0/UV1/PolarUV/ScreenUV) are baked into the *Weights
//   vectors by the material editor — UV0=(1,0,0,0), UV1=(0,1,0,0), ScreenUV uses .w; the HLSL just
//   dots the weights, so the enum is inspector-only metadata (HideInInspector weights carry it).

Shader "HGRP/VfxCaptureMesh_Fix" {
    Properties {
        [Header(Base)]
        [Enum(Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableZTest ("Disable ZTest", Float) = 0
        [ToggleUI] _DisableVertColor ("Disable VertColor", Float) = 0
        [ToggleUI] _InParticle ("Use In Particle", Float) = 1
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1
        [HideInInspector] _ProcedureAlpha ("Procedure Alpha", Float) = 1
        _TintColor ("TintColor", Color) = (1, 1, 1, 1)
        _TintColorIntensity ("Tint Color Intensity (Default 1)", Range(1, 100)) = 1
        _ExpThreshold ("Exp Threshold", Range(0, 1)) = 1
        _ExpIntensity ("Exp Intensity", Range(0, 100)) = 0
        _TintColorAlpha ("Tint Color Alpha (Default 1)", Range(0, 10)) = 1
        [Enum(NormalTransparent, 0, ResponsiveTransparent, 1)] _Responsive ("Responsive Transparent", Float) = 0
        [ToggleUI] _EnableTransparentMV ("Enable Transparent MV", Float) = 0
        // Exposure global re-exposed as a material Vector (HGRP _ExposureParams has no URP equivalent).
        _ExposureParams ("ExposureParams (.x = postExposure)", Vector) = (1, 0, 0, 0)

        [Header(Main Tex)]
        _MainTex ("Main Tex", 2D) = "white" {}
        [ToggleUI] _MainTexUseDisturb ("Main Tex Use Disturb", Float) = 1
        [ToggleUI] _UseMainTexAsAlpha ("UseMainTexAsAlpha", Float) = 1
        _MainTexUVSpeed ("MainTexUVSpeed(XY:By Time,ZW:By Custom1.X)", Vector) = (0, 0, 0, 0)
        _MainTexUVRotate ("MainTexUVRotate(Degree)", Float) = 0
        [HideInInspector] _MainTexUVRotateMat ("MainTexUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _MainUVSet ("Main UV Set", Float) = 0
        [HideInInspector] _MainTexUVWeights ("_MainTexUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Mask)]
        [Toggle(_USE_MASK)] _UseMask ("Use Mask (affects Alpha only)", Float) = 0
        _MaskTex ("Mask Tex", 2D) = "white" {}
        _MaskTexUseDisturb ("Mask Tex Use Disturb", Range(0, 1)) = 0
        [ToggleUI] _UseMaskTexAsAlpha ("UseMaskTexAsAlpha", Float) = 1
        _MaskTexUVSpeed ("MaskTexUVSpeed(XY:By Time,ZW:By Custom1.Y)", Vector) = (0, 0, 0, 0)
        _MaskTexUVRotate ("MaskTexUVRotate(Degree)", Float) = 0
        [HideInInspector] _MaskTexUVRotateMat ("MaskTexUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _MaskUVSet ("Mask UV Set", Float) = 0
        [HideInInspector] _MaskTexUVWeights ("_MaskTexUVWeights", Vector) = (1, 0, 0, 0)

        [Header(Fresnel)]
        [Toggle(_USE_FRESNEL)] _UseFresnel ("Use Fresnel", Float) = 0
        [HDR] [Gamma] _FresnelColor ("Fresnel Color", Color) = (1, 1, 1, 1)
        _FresnelBias ("Fresnel Bias(Default:0)", Range(-1, 2)) = 0
        _FresnelAffectOpacity ("Fresnel Affect Opacity", Range(0, 1)) = 1
        _FresnelPower ("Fresnel Power(Default:1)", Range(1, 10)) = 1
        [ToggleUI] _FresnelFlip ("Fresnel Flip", Float) = 0.001

        [Header(Dissolve)]
        [Toggle(_USE_DISSOLVE)] _UseDissolve ("Use Dissolve", Float) = 0
        _DissolveTex ("Dissolve Tex", 2D) = "white" {}
        [ToggleUI] _DissolveTexUseDisturb ("Dissolve Tex Use Disturb", Float) = 1
        _DissolveUVSpeed ("DissolveUVSpeed(XY:By Time,ZW:By Custom1.Y)", Vector) = (0, 0, 0, 0)
        _DissolveUVRotate ("DissolveUVRotate(Degree)", Float) = 0
        [HideInInspector] _DissolveUVRotateMat ("DissolveUVRotateMat", Vector) = (1, 0, 0, 1)
        [Enum(UV0, 0, UV1, 1, PolarUV, 2, ScreenUV, 3)] _DissolveUVSet ("Dissolve UV Set", Float) = 0
        [HideInInspector] _DissolveUVWeights ("DissolveUVWeights", Vector) = (1, 0, 0, 0)
        _DissolveScheduleOffset ("Dissolve Schedule Offset", Range(0, 2)) = 0
        _DissolveEdgeSharp ("Dissolve Edge Sharp", Range(0.001, 100)) = 1
        _DissolveEmissiveEdge ("Dissolve Edge Emissive", Range(0, 0.5)) = 0
        [HDR] [Gamma] _DissolveEmissiveColor ("Dissolve Edge Emissive Color", Color) = (0, 0, 0, 0)

        [Header(Screen UV)]
        [Toggle(_USE_SCREENUV)] _UseScreenUV ("Use Screen UV", Float) = 0
        [ToggleUI] _UsePosYAsScreenV ("Use world Y as V", Float) = 0
        [ToggleUI] _ScreenUVUseDepth ("Screen UV affected by camera distance", Float) = 1
        _OverrideLocalPos ("Override character Local pos", Vector) = (0, 0, 0, 0)
        // [0,1] flag (blob c14.z, named _LocalPivortSpace): 0 = screen-centered UV, 1 = pivot-relative
        //   view-space UV. Derived by the material editor; not a hand-set property in the source.
        [HideInInspector] _LocalPivortSpace ("__localPivotSpace", Float) = 1

        // Blend/state plumbing (driven by a material editor / OnValidate, as in the HGRP source).
        // Source ForwardOnly defaults: Blend [_SrcBlend] [_DstBlend], ZTest [_ZTest], ZWrite [_ZWrite], Cull [_CullMode].
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _AlphaSrcBlend ("__alphaSrc", Float) = 1
        [HideInInspector] _AlphaDstBlend ("__alphaDst", Float) = 0
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
                // Base
                float _SurfaceType;
                float _BlendMode;
                float _Responsive;
                float _EnableTransparentMV;
                float _InParticle;
                float _DisableVertColor;
                float _TintColorIntensity;
                float _TintColorAlpha;
                float _IgnorePostExposure;
                float _ProcedureAlpha;
                float _ExpThreshold;
                float _ExpIntensity;
                float4 _TintColor;
                float4 _ExposureParams;
                // MainTex
                float _UseMainTexAsAlpha;
                float _MainTexUseDisturb;
                float4 _MainTexUVSpeed;
                float4 _MainTexUVRotateMat;
                float4 _MainTexUVWeights;
                float4 _MainTex_ST;
                // Mask
                float _UseMaskTexAsAlpha;
                float _MaskTexUseDisturb;
                float4 _MaskTex_ST;
                float4 _MaskTexUVSpeed;
                float4 _MaskTexUVRotateMat;
                float4 _MaskTexUVWeights;
                // Fresnel
                float4 _FresnelColor;
                float _FresnelBias;
                float _FresnelAffectOpacity;
                float _FresnelPower;
                float _FresnelFlip;
                // Dissolve
                float _DissolveTexUseDisturb;
                float _DissolveScheduleOffset;
                float _DissolveEdgeSharp;
                float _DissolveEmissiveEdge;
                float4 _DissolveTex_ST;
                float4 _DissolveUVSpeed;
                float4 _DissolveUVRotateMat;
                float4 _DissolveUVWeights;
                float4 _DissolveEmissiveColor;
                // Screen UV
                float _UsePosYAsScreenV;
                float _ScreenUVUseDepth;
                float _LocalPivortSpace;
                float4 _OverrideLocalPos;
                // Render state
                float _TransparentSortPriority;
            CBUFFER_END

            TEXTURE2D(_MainTex);      SAMPLER(sampler_MainTex);
            TEXTURE2D(_MaskTex);      SAMPLER(sampler_MaskTex);
            TEXTURE2D(_DissolveTex);  SAMPLER(sampler_DissolveTex);

            // Luma weights used by the responsive-MV alpha threshold (blob Fragment_b29.hlsl:99).
            static const float3 LUM = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625);

            // VFX UV: channel-weight blend (UV0/UV1) → time + custom-data scroll → 2x2 rotate about 0.5
            //   → tiling/offset (ST). The ScreenUV channel feeds .w of the weights (see computeVFXUV_Screen).
            // (blob Fragment_b29.hlsl:83 — one fused mad expression; expanded here.)
            float2 computeVFXUV(float2 uv0, float2 uv1, float4 weights, float4 speed,
                                float time, float customData, float4 rotateMat, float4 st,
                                float screenU, float screenV)
            {
                // uv = uv0*w.x + uv1*w.y + screenUV*w.w  + time/custom scroll
                float u = mad(speed.z, customData, mad(speed.x, time,
                              mad(screenU, weights.w, mad(uv0.x, weights.x, uv1.x * weights.y))));
                float v = mad(speed.w, customData, mad(speed.y, time,
                              mad(screenV, weights.w, mad(uv0.y, weights.x, uv1.y * weights.y))));
                // Rotate the (uv-0.5) vector by rotateMat (column-stored as x,y,z,w = m00,m01,m10,m11).
                float cu = u - 0.5;
                float cv = v - 0.5;
                float ru = (cv * rotateMat.z) + (cu * rotateMat.x) + 0.5;
                float rv = (cv * rotateMat.w) + (cu * rotateMat.y) + 0.5;
                return float2(mad(ru, st.x, st.z), mad(rv, st.y, st.w));
            }
        ENDHLSL

        Pass {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] [_DstBlend], [_AlphaSrcBlend] [_AlphaDstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _USE_FRESNEL
            #pragma shader_feature_local _USE_DISSOLVE
            #pragma shader_feature_local _USE_SCREENUV
            #pragma shader_feature_local _USE_MASK

            struct Attributes {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 color      : COLOR;
                float4 texcoord0  : TEXCOORD0; // UV0 in .xy, UV1 in .zw (particle path)
                float4 texcoord1  : TEXCOORD1; // particle custom data (.z = dissolve schedule)
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float4 uv0uv1     : TEXCOORD0; // pass-through texcoord0 (TEXCOORD in blob)
                float4 customData  : TEXCOORD1; // pass-through texcoord1 (TEXCOORD_1 in blob)
                float4 vertColor   : TEXCOORD2; // TEXCOORD_2 in blob
                float3 normalWS    : TEXCOORD3;
                float3 positionWS  : TEXCOORD4;
            };

            // Vertex: the blob (Vertex_b28.hlsl:72-328) does GPU-skinning capture + camera-relative
            //   world rebasing + a non-jittered VP; URP skins automatically and uses absolute WS, so the
            //   clean transform is the standard URP object→world→clip. (1:1 on the *geometric* result.)
            Varyings vert(Attributes v)
            {
                Varyings o;
                VertexPositionInputs posIn = GetVertexPositionInputs(v.positionOS);
                o.positionCS = posIn.positionCS;
                o.positionWS = posIn.positionWS;
                o.normalWS   = TransformObjectToWorldNormal(v.normalOS);
                o.uv0uv1     = v.texcoord0;
                o.customData = v.texcoord1;
                o.vertColor  = v.color;
                return o;
            }

            half4 frag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                float time = _Time.y; // replaces _VFXParams0.w (blob Fragment_b29.hlsl:83)

                // ---- Particle-aware UV base (blob Fragment_b29.hlsl:82-83) ----
                // custom1X drives MainTex speed.zw; custom1Y drives Mask/Dissolve speed.zw.
                float custom1X = input.customData.x * _InParticle;
                float custom1Y = input.customData.y * _InParticle;
                float2 uv0 = input.uv0uv1.xy;
                // _InParticle=1 → uv1 = texcoord0.zw ; _InParticle=0 → uv1 = texcoord1.xy
                float2 uv1 = float2(
                    mad(input.uv0uv1.z, _InParticle, (-(input.customData.x * _InParticle))) + input.customData.x,
                    mad(input.uv0uv1.w, _InParticle, (-(input.customData.y * _InParticle))) + input.customData.y
                );

                // ---- Screen-space UV channel (blob Fragment_b37.hlsl:106-117 / b35:105-118) ----
                // Reconstruct world XZ from depth (ortho/persp via UNITY_MATRIX_I_VP), re-origin to the
                // object pivot (unity_ObjectToWorld._m03/_m13/_m23), project through the view matrix.
                float screenU = 0.0;
                float screenV = 0.0;
                #ifdef _USE_SCREENUV
                {
                    // NDC from pixel coords (blob b37:106-107). _ScreenSize.zw == 1/width,1/height == _ScreenParams.zw-1.
                    float2 screenUV01 = GetNormalizedScreenSpaceUV(input.positionCS);
                    float ndcX = mad(screenUV01.x, 2.0, -1.0);
                    float ndcY = (-0.0) - mad(screenUV01.y, 2.0, -1.0);
                    // World pos from depth via inverse view-proj (blob b37:108-112).
                    float4 clip = float4(ndcX, ndcY, input.positionCS.z, 1.0);
                    float4 worldH = mul(UNITY_MATRIX_I_VP, clip);
                    float3 worldP = worldH.xyz / worldH.w;
                    // Re-origin to object pivot (blob b37:110-112: subtract _unity_ObjectToWorld[3].xyz).
                    float3 rel = worldP - float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);
                    // Screen-centered fallback coords (blob b37:113-114).
                    float scrCx = mad(screenUV01.x, 2.0, -1.0);
                    float scrCy = (mad(screenUV01.y, 2.0, -1.0) / _ScreenParams.x) * _ScreenParams.y;
                    // Depth scale: distance of pivot along view forward minus near plane (blob b37:115).
                    float pivotViewZ = mul(UNITY_MATRIX_V, float4(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23, 1.0)).z;
                    float depthScale = mad(max(((-0.0) - pivotViewZ) + ((-0.0) - _ProjectionParams.y), 1.0),
                                           _ScreenUVUseDepth, 1.0 + ((-0.0) - _ScreenUVUseDepth));
                    // U = depthScale * lerp(scrCx, viewX(rel), _LocalPivortSpace) (blob b37:116).
                    float3 relViewX = mul((float3x3)UNITY_MATRIX_V, rel);
                    screenU = depthScale * mad(_LocalPivortSpace, relViewX.x - scrCx, scrCx);
                    // V: world-Y option vs view-Y; minus offset when _UsePosYAsScreenV (blob b37:117).
                    float viewYsel = (0.0 != _UsePosYAsScreenV) ? worldP.y : mad(_LocalPivortSpace, relViewX.y - scrCy, scrCy);
                    screenV = mad((-0.0) - _ScreenUVUseDepth, _UsePosYAsScreenV, depthScale * viewYsel);
                }
                #endif

                // ---- DISSOLVE tex sample (blob Fragment_b33.hlsl:104) ----
                #ifdef _USE_DISSOLVE
                    float2 dissolveUV = computeVFXUV(uv0, uv1, _DissolveUVWeights, _DissolveUVSpeed,
                                                     time, custom1Y, _DissolveUVRotateMat, _DissolveTex_ST,
                                                     screenU, screenV);
                    float4 dissolveSample = SAMPLE_TEXTURE2D(_DissolveTex, sampler_DissolveTex, dissolveUV);
                #endif

                // ---- MAIN tex sample (blob Fragment_b29.hlsl:83-88) ----
                float2 mainUV = computeVFXUV(uv0, uv1, _MainTexUVWeights, _MainTexUVSpeed,
                                             time, custom1X, _MainTexUVRotateMat, _MainTex_ST,
                                             screenU, screenV);
                float4 mainSample = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, mainUV);

                // ---- Tint × vertex-color × intensity (blob Fragment_b29.hlsl:91-93) ----
                // lerp(mainRGB, 1, _UseMainTexAsAlpha): when UseAsAlpha, RGB comes from tint only.
                float3 mainColorFactor = lerp(mainSample.rgb, float3(1.0, 1.0, 1.0), _UseMainTexAsAlpha);
                // lerp(vcRGB, 1, _DisableVertColor)
                float3 vcAdj = lerp(input.vertColor.rgb, float3(1.0, 1.0, 1.0), _DisableVertColor);
                float3 color = mainColorFactor * (vcAdj * _TintColor.rgb * _TintColorIntensity);

                // ---- Alpha (blob Fragment_b29.hlsl:94) ----
                // lerp(mainA, mainR, _UseMainTexAsAlpha)
                float mainAlpha = lerp(mainSample.a, mainSample.r, _UseMainTexAsAlpha);
                // lerp(vcA, 1, _DisableVertColor)
                float vcAlphaAdj = lerp(input.vertColor.a, 1.0, _DisableVertColor);
                float baseAlpha = mainAlpha * (vcAlphaAdj * _TintColor.a * _TintColorAlpha);

                // ---- MASK modulation (blob Fragment_b37.hlsl:136-139) ----
                // Mask multiplies BOTH color (per-channel) and alpha. lerp(maskCh, 1, _UseMaskTexAsAlpha).
                #ifdef _USE_MASK
                    float2 maskUV = computeVFXUV(uv0, uv1, _MaskTexUVWeights, _MaskTexUVSpeed,
                                                 time, custom1Y, _MaskTexUVRotateMat, _MaskTex_ST,
                                                 screenU, screenV);
                    float4 maskSample = SAMPLE_TEXTURE2D(_MaskTex, sampler_MaskTex, maskUV);
                    color.r *= lerp(maskSample.r, 1.0, _UseMaskTexAsAlpha);
                    color.g *= lerp(maskSample.g, 1.0, _UseMaskTexAsAlpha);
                    color.b *= lerp(maskSample.b, 1.0, _UseMaskTexAsAlpha);
                    baseAlpha *= lerp(maskSample.a, maskSample.r, _UseMaskTexAsAlpha);
                #endif

                // ---- FRESNEL (blob Fragment_b31.hlsl:99-110, 127-130 / b35:134-148) ----
                // pow(saturate(NdotV + bias), power) → flip → blend color toward _FresnelColor.
                // Edge term also scales alpha through _FresnelAffectOpacity (dissolveScheduleOffset slot).
                #ifdef _USE_FRESNEL
                    // View dir (blob b31:102-105): persp (orthoParams.w==0) → camPos - worldPos;
                    //   ortho (orthoParams.w!=0) → the raw view-Z row (_ViewMatrix[col].z == V._m2x), NOT negated.
                    float3 viewVec = (0.0 != unity_OrthoParams.w)
                        ? float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22)
                        : (_WorldSpaceCameraPos - input.positionWS);
                    float3 viewDir = viewVec * rsqrt(max(dot(viewVec, viewVec), 9.9999999392252902907785028219223e-09));
                    // Back-face flips the normal sign (blob b31:107-108: ((-0.0f)-x) == -x).
                    float3 nrm = isFrontFace ? input.normalWS : -input.normalWS;
                    float ndotv = clamp(dot(viewDir, nrm) + _FresnelBias, 0.0, 1.0);
                    float fresnel = exp2(log2(ndotv) * _FresnelPower); // pow(ndotv, power)
                    float invFresnel = ((-0.0) - fresnel) + 1.0;
                    float fresnelTerm = mad(_FresnelFlip, ((-0.0) - invFresnel) + fresnel, invFresnel);
                    float fresnelBlend = fresnelTerm * _FresnelColor.a;
                    // color = lerp(color, _FresnelColor.rgb, fresnelBlend) (blob b31:127-129).
                    color.r = mad(fresnelBlend, mad((-0.0) - color.r, 1.0, _FresnelColor.r), color.r);
                    color.g = mad(fresnelBlend, mad((-0.0) - color.g, 1.0, _FresnelColor.g), color.g);
                    color.b = mad(fresnelBlend, mad((-0.0) - color.b, 1.0, _FresnelColor.b), color.b);
                    // Alpha = lerp(1, fresnelTerm, _FresnelAffectOpacity) * saturate(alpha) (blob b31:130 / b39:169).
                    //   The blob saturates the (alpha * mask) product BEFORE the fresnel-opacity factor;
                    //   the outer clamp(...,0,1) is the final-alpha clamp below. Saturating here is load-bearing:
                    //   omitting it lets an over-driven alpha (_TintColorAlpha up to 10) overpower the rim opacity.
                    baseAlpha = mad(fresnelTerm, _FresnelAffectOpacity, 1.0 + ((-0.0) - _FresnelAffectOpacity)) * clamp(baseAlpha, 0.0, 1.0);
                #endif

                // ---- DISSOLVE edge + emissive (blob Fragment_b33.hlsl:114-120) ----
                #ifdef _USE_DISSOLVE
                    // Threshold ramp: dissolveTex.r - ((custom1Z·schedule)*2.02 - 1.01)  (blob b33:114).
                    float dissolveSchedule = mad(input.customData.z, _InParticle, _DissolveScheduleOffset);
                    float dissolveEdge = ((-0.0) - mad(dissolveSchedule, 2.019999980926513671875, -1.0099999904632568359375)) + dissolveSample.r;
                    // Emissive edge mask = saturate((-edge + emissiveEdge) * sharp) (blob b33:115).
                    float emissiveMask = clamp((((-0.0) - dissolveEdge) + _DissolveEmissiveEdge) * _DissolveEdgeSharp, 0.0, 1.0);
                    // color = lerp(color, emissiveMask*emissiveColor*intensity, emissiveMask) (blob b33:117-119).
                    color.r = mad(emissiveMask, mad(emissiveMask * _DissolveEmissiveColor.r, _TintColorIntensity, (-0.0) - color.r), color.r);
                    color.g = mad(emissiveMask, mad(emissiveMask * _DissolveEmissiveColor.g, _TintColorIntensity, (-0.0) - color.g), color.g);
                    color.b = mad(emissiveMask, mad(emissiveMask * _DissolveEmissiveColor.b, _TintColorIntensity, (-0.0) - color.b), color.b);
                    // Body mask = saturate(edge * sharp) multiplies alpha (blob b33:120).
                    baseAlpha *= clamp(dissolveEdge * _DissolveEdgeSharp, 0.0, 1.0);
                #endif

                // ---- Exposure normalize (blob Fragment_b29.hlsl:90-93) ----
                float exposureScale = mad(_ExposureParams.x, _IgnorePostExposure, 1.0 + ((-0.0) - _IgnorePostExposure));
                color = min(max(color / exposureScale, 0.0), 1000.0);

                // ---- Final alpha clamp (blob Fragment_b29.hlsl:94) ----
                float finalAlpha = clamp(baseAlpha, 0.0, 1.0);

                // ---- Premultiplied-alpha output (blob Fragment_b29.hlsl:95-98) ----
                // RGB premultiplied by alpha; out.a = (1 - _BlendMode) * alpha (additive → a=0).
                return half4(finalAlpha * color, (1.0 + ((-0.0) - _BlendMode)) * finalAlpha);
            }

            ENDHLSL
        }
    }
}
