// HGRP VFX Six-Way Smoke — single transparent particle pass (ForwardOnly -> UniversalForwardOnly).
// A volumetric-smoke lit-card shader: a "six-way lightmap" (positive/negative axis occlusion atlas)
// is gathered with a Beer-Lambert absorption model, lit by ambient SH + main directional light +
// additional punctual lights, then VFX color-graded. The base (no-lightmap) variant is a pure
// vertex-color * tint card; _USE_SIXWAY_LIGHTMAP turns on the actual smoke shading.
//
// Merged from: vfxsmoke_sixway.shader (HGRP) — base catch-all Vertex_b200 / Fragment_b201
//   + _USE_SIXWAY_LIGHTMAP variant Vertex_b202 / Fragment_b203 (the lit-smoke ground truth).
// Keywords: _USE_SIXWAY_LIGHTMAP (six-way smoke lighting on/off).
// Kept: TintColor + intensity + exp-threshold emissive curve, near-camera double fade,
//   straight (non-premultiplied) color/alpha output + alpha/additive blend via bound [_SrcBlend]/[_DstBlend]
//   render-state (exactly as the blob — material editor sets factors per _SurfaceType/_BlendMode),
//   six-way lightmap absorption gather (σ from _AbsorptionRange, per-channel tint absorption exp),
//   env-light saturation, ambient SH irradiance, main directional six-way absorption + shadow,
//   additional punctual lights six-way absorption, VFX color-grade (saturation + tint).
// Removed: GPU skinning + octahedral vertex (NORMAL.x packed) — URP feeds Unity-standard meshes;
//   HGRP TAA jitter / motion vectors (SV_Target1 MRT dropped — URP has its own MotionVectors pass);
//   HGRP IV (image-volume) 3D-texture ambient cascade -> URP SampleSH(N); HGRP tiled/z-binned light
//   culling + half-packed light buffer + cubemap-face cookie LUT + per-light PCF shadow atlas ->
//   URP GetAdditionalLight / GetMainLight + their shadow attenuation; cloud-shadow / fake-planar-
//   reflection screen reprojection; SRP instancing; _GlobalMipBias (-> 0); _VFXParams0.w (time) -> _Time.y.
//
// NOTE: the six "axes" are tangentWS (+/-), normalWS (+/-), and bitangent=cross(tangent,normal) (+/-);
//   the positive-axes lightmap RGB = occlusion along (+T,+N,+B-ish) and the negative-axes lightmap RGB
//   = occlusion along the opposite three — matching Unity VFX Graph's six-way lightmap convention.
// NOTE: _VFXColorGrade (.xyz tint, .w saturation) re-exposes HGRP global _VFXParams1 (neutral = (1,1,1,1)).
//   _AmbientIntensity / _EnvLightSaturation drive the SH-ambient term that HGRP read from the IV volume.

Shader "HGRP/VfxSmoke_SixWay_Fix" {
    Properties {
        [Header(Base)]
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableZTest ("Disable ZTest", Float) = 0
        [ToggleUI] _DisableVertColor ("Disable VertColor", Float) = 0
        [ToggleUI] _InParticle ("Use In Particle", Float) = 1
        _TintColor ("TintColor", Color) = (1, 1, 1, 1)
        _TintColorIntensity ("Tint Color Intensity", Range(1, 100)) = 1
        _ExpThreshold ("Exp Threshold", Range(0, 1)) = 1
        _ExpIntensity ("Exp Intensity", Range(0, 100)) = 0
        _TintColorAlpha ("Tint Color Alpha", Range(0, 10)) = 1
        [Enum(NormalTransparent, 0, ResponsiveTransparent, 1)] _Responsive ("Responsive Transparent", Float) = 0
        [ToggleUI] _EnableTransparentMV ("Enable Transparent MV", Float) = 0
        [ToggleUI] _UsePosYAsScreenV ("Use World Y as Screen V", Float) = 0

        [Header(Six Way Light Map)]
        [Toggle(_USE_SIXWAY_LIGHTMAP)] _SixWayLightMap ("Six Way Light Map", Float) = 0
        _PositiveAxesLightmap ("Positive Axes Lightmap", 2D) = "white" {}
        _NegativeAxesLightmap ("Negative Axes Lightmap", 2D) = "white" {}
        _LightMapControls ("LightMap Controls (XY: Tiling, ZW: Offset)", Vector) = (1, 1, 0, 0)
        _LightMapUVSpeed ("LightMapUVSpeed (XY:By Time, ZW:By Custom1.X)", Vector) = (0, 0, 0, 0)
        _LightMapUVRotate ("LightMapUVRotate (Degree)", Float) = 0
        _AbsorptionRange ("Absorption Strength", Range(0, 1)) = 1
        _EnvLightSaturation ("Env Light Saturation", Range(0.1, 3)) = 1
        _AmbientIntensity ("Ambient Intensity (IV substitute)", Range(0, 4)) = 1

        [Header(Near Camera Fade)]
        _UseNearCameraFade ("Use Near Camera Fade", Float) = 0
        _NearCameraFadeDistanceStart ("Fade Disappear 1", Range(0.001, 3000)) = 0.001
        _NearCameraFadeDistanceEnd ("Fade Appear 1", Range(0.001, 3000)) = 10
        _NearCameraFadeDistanceEnd2 ("Fade Appear 2", Range(0.002, 3000)) = 100
        _NearCameraFadeDistanceStart2 ("Fade Disappear 2", Range(0.001, 3000)) = 120

        [Header(VFX Color Adjustment)]
        _VFXColorGrade ("VFX Color Grade (.xyz Tint, .w Saturation)", Vector) = (1, 1, 1, 1)

        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 0
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0
    }

    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
        }
        LOD 600

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

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
                float _ExpThreshold;
                float _ExpIntensity;
                float _UsePosYAsScreenV;
                float4 _TintColor;
                // Six-Way Lightmap
                float4 _PositiveAxesLightmap_ST;
                float4 _NegativeAxesLightmap_ST;
                float4 _LightMapControls;
                float4 _LightMapUVSpeed;
                float _LightMapUVRotate;
                float _AbsorptionRange;
                float _EnvLightSaturation;
                float _AmbientIntensity;
                // Near Camera Fade
                float _UseNearCameraFade;
                float _NearCameraFadeDistanceStart;
                float _NearCameraFadeDistanceEnd;
                float _NearCameraFadeDistanceEnd2;
                float _NearCameraFadeDistanceStart2;
                // VFX Color Adjustment
                float4 _VFXColorGrade;
                // Render state
                float _TransparentSortPriority;
            CBUFFER_END

            TEXTURE2D(_PositiveAxesLightmap);   SAMPLER(sampler_PositiveAxesLightmap);
            TEXTURE2D(_NegativeAxesLightmap);   SAMPLER(sampler_NegativeAxesLightmap);

            // ----- shared constants (decoded denormalized-float magics) -----
            // (SMOKE_ prefix avoids collisions with URP core #defines such as INV_PI/PI in Common.hlsl)
            static const float3 SMOKE_LUMA = float3(0.21267290413379669189453125, 0.715152204036712646484375, 0.072175003588199615478515625); // Rec.709 (blob 577)
            static const float SMOKE_INV_PI = 0.3183098733425140380859375;             // 1/pi (blob 294)
            static const float SMOKE_ABSORB_SCALE = 1.46694219112396240234375;         // absorption-range -> sigma scale (blob 294)
            static const float SMOKE_ABSORB_TINT_EXP = 0.43067657947540283203125;      // tint -> per-channel absorption exponent (blob 565-567)
            static const float SMOKE_DEG2RAD = 0.01745329238474369049072265625;        // pi/180 (blob 274)

            // Beer-Lambert per-channel absorption of one lightmap occlusion sample.
            // sigma = absorption coefficient, occ = raw [0,1] occlusion, tintExp = per-tint-channel exponent.
            // min(sigma, sigma * (occ/sigma)^tintExp) implemented exactly as the blob's exp2(tintExp*log2(occ/sigma)) (blob 568-576).
            float AbsorbChannel(float sigma, float occ, float tintExp)
            {
                float ld = log2(clamp(occ / sigma, 0.0, 1.0));
                return min(sigma, sigma * exp2(tintExp * ld));
            }

            // Six-way isotropic gather: sum the 6 axis-occlusion samples through the absorption curve (blob 574-576).
            float SixWayGather(float sigma, float3 posOcc, float3 negOcc, float tintExp)
            {
                return AbsorbChannel(sigma, posOcc.x, tintExp) + AbsorbChannel(sigma, posOcc.y, tintExp)
                     + AbsorbChannel(sigma, posOcc.z, tintExp) + AbsorbChannel(sigma, negOcc.x, tintExp)
                     + AbsorbChannel(sigma, negOcc.y, tintExp) + AbsorbChannel(sigma, negOcc.z, tintExp);
            }

            // Six-way directional gather: project light dir onto the 3 axes, pick pos/neg occlusion per axis sign,
            // weight by the squared projection, absorb (blob 587-598, 894-901). axisT/axisN/axisB are the orthonormal axes.
            // Returns the per-RGB absorbed directional response for absorption exponents (expR,expG,expB).
            float3 SixWayDirectional(float sigma, float3 lightDir, float3 axisT, float3 axisN, float3 axisB,
                                     float3 posOcc, float3 negOcc, float3 absorbExp)
            {
                // dots of light dir with each axis (blob 894-896): axisT=dot(TEXCOORD_5,L), axisB=dot(cross,L),
                // axisN=dot(-TEXCOORD_4,L). The N axis is NEGATED (blob 896 dots float3(-TEXCOORD_4.xyz)),
                // exactly as the main-light path (blob 589). Sign of dN flips the pos/neg occlusion select below.
                float dT = dot(axisT, lightDir);
                float dB = dot(axisB, lightDir);
                float dN = dot(-axisN, lightDir);
                // per-axis occlusion select by sign of projection (blob 590 / 898): >=0 -> positive axis lightmap, else negative
                float occT = (dT >= 0.0) ? posOcc.x : negOcc.x;
                float occB = (dB >= 0.0) ? posOcc.y : negOcc.y;
                float occN = (dN >= 0.0) ? posOcc.z : negOcc.z;
                // weighted occlusion = sum(dot^2 * occ_axis) (blob 590 / 898)
                float occ = clamp(dot(float3(dT * dT, dB * dB, dN * dN), float3(occT, occB, occN)) / sigma, 0.0, 1.0);
                float ld = log2(occ);
                float3 c;
                c.x = min(sigma, sigma * exp2(ld * absorbExp.x));
                c.y = min(sigma, sigma * exp2(ld * absorbExp.y));
                c.z = min(sigma, sigma * exp2(ld * absorbExp.z));
                return c;
            }
        ENDHLSL

        Pass {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }
            Blend [_SrcBlend] [_DstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _USE_SIXWAY_LIGHTMAP
            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
            #pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS
            #pragma multi_compile_fragment _ _SHADOWS_SOFT
            // Forward+ clustered light loop (replaces HGRP's own tiled/z-binned light binning for additional lights).
            #pragma multi_compile_fragment _ _FORWARD_PLUS

            struct Attributes {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float4 color      : COLOR;
                float4 texcoord0  : TEXCOORD0; // uv0
                float4 texcoord1  : TEXCOORD1; // particle custom data / uv1
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float3 positionWS : TEXCOORD0;  // absolute world pos (blob VS _436..438 -> frag TEXCOORD)
                float4 uv0        : TEXCOORD1;  // texcoord0 (blob TEXCOORD_1)
                float4 customData : TEXCOORD2;  // texcoord1 (blob TEXCOORD_2; .x = custom1 lightmap scroll)
                float3 normalWS   : TEXCOORD3;  // world normal = six-way "up/forward" axis (blob TEXCOORD_4)
                float4 tangentWS  : TEXCOORD4;  // world tangent.xyz + sign.w = six-way "right" axis (blob TEXCOORD_5)
                float4 vertColor  : TEXCOORD5;  // vertex color (blob TEXCOORD_6)
            };

            Varyings vert(Attributes v)
            {
                Varyings o = (Varyings)0;

                // Object -> world -> clip. HGRP works camera-relative then re-adds cam pos; URP positionWS is already
                // absolute world, matching the blob's _436..438 = camRelPos + _WorldSpaceCameraPos (blob VS 288-290,412-414).
                VertexPositionInputs posIn = GetVertexPositionInputs(v.positionOS);
                VertexNormalInputs   nrmIn = GetVertexNormalInputs(v.normalOS, v.tangentOS);

                o.positionCS = posIn.positionCS;
                o.positionWS = posIn.positionWS;
                // normalize'd world normal / tangent (blob VS _403..406 normal, _879 tangent) (blob 281-284,384-388)
                o.normalWS  = normalize(nrmIn.normalWS);
                o.tangentWS = float4(normalize(nrmIn.tangentWS), v.tangentOS.w * GetOddNegativeScale());

                o.uv0        = v.texcoord0;
                o.customData = v.texcoord1;
                o.vertColor  = v.color;
                // NOTE: blob VS also carried texcoord3.xyz (TEXCOORD_3_1.xyz) and a precomputed cloud/sun-shadow
                // factor in TEXCOORD_3.w. texcoord3.xyz fed ONLY the dropped fake-planar-reflection screen reproject,
                // and TEXCOORD_3.w (the directional gate) is replaced by URP main-light shadowing — so neither is
                // interpolated here; the directional path runs unconditionally (gate == 1) in the fragment.
                return o;
            }

            half4 frag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                float time = _Time.y; // replaces HGRP _VFXParams0.w (blob 278-279)

                // ---- vertex-color tint (blob 282-285) ----
                bool disableVC = (0.0 != _DisableVertColor);
                float3 tintRGB;
                tintRGB.x = (disableVC ? 1.0 : input.vertColor.x) * _TintColor.x;
                tintRGB.y = (disableVC ? 1.0 : input.vertColor.y) * _TintColor.y;
                tintRGB.z = (disableVC ? 1.0 : input.vertColor.z) * _TintColor.z;
                float tintA = (disableVC ? 1.0 : input.vertColor.w) * _TintColor.w;

                // ---- exp-threshold emissive curve per channel (blob 299-302) ----
                // expC = clamp( mad(max(mad(tint,intensity,-thresh),0), expIntensity, tint*intensity), 0, 1000 )
                float negThresh = -_ExpThreshold;
                float3 expColor;
                expColor.x = min(max(mad(max(mad(tintRGB.x, _TintColorIntensity, negThresh), 0.0), _ExpIntensity, tintRGB.x * _TintColorIntensity), 0.0), 1000.0);
                expColor.y = min(max(mad(max(mad(tintRGB.y, _TintColorIntensity, negThresh), 0.0), _ExpIntensity, tintRGB.y * _TintColorIntensity), 0.0), 1000.0);
                expColor.z = min(max(mad(max(mad(tintRGB.z, _TintColorIntensity, negThresh), 0.0), _ExpIntensity, tintRGB.z * _TintColorIntensity), 0.0), 1000.0);

                // ---- near-camera double fade (blob 298 / b201 69) ----
                // The blob's fade operand is `1.0/gl_FragCoord.w` AFTER main() overwrote gl_FragCoord.w with
                // `1.0/(delivered SV_Position.w)` (blob main 1132). The two reciprocals cancel, so the operand is the
                // RAW delivered SV_Position.w. URP delivers the identical hardware value in input.positionCS.w, so the
                // 1:1 operand is input.positionCS.w used DIRECTLY (no extra reciprocal). (blob 298, main 1132)
                float eyeDist = input.positionCS.w;
                float nearFade = 1.0;
                if (0.0 != _UseNearCameraFade)
                {
                    nearFade = clamp((eyeDist - _NearCameraFadeDistanceStart) / (-_NearCameraFadeDistanceStart + _NearCameraFadeDistanceEnd), 0.0, 1.0)
                             * clamp((eyeDist - _NearCameraFadeDistanceStart2) / (-_NearCameraFadeDistanceStart2 + _NearCameraFadeDistanceEnd2), 0.0, 1.0);
                }
                // base output alpha gate (without lightmap density) (blob 298 _377)
                float fadeTintA = clamp(nearFade * (tintA * _TintColorAlpha), 0.0, 1.0);

                float3 outColor;
                float  outAlpha;

            #ifdef _USE_SIXWAY_LIGHTMAP
                // ===================== SIX-WAY SMOKE LIGHTING (blob Fragment_b203) =====================
                float3 positionWS = input.positionWS;
                // NOTE: blob 266-273 built a normalized view dir V, but it fed ONLY the dropped HGRP punctual-light
                // reflection-vector / spot-cone soft-edge path (blob 612-616,873-881); URP's GetAdditionalLight
                // owns that, so V is not needed here.

                // ---- six-way lightmap UV: scroll (time + custom1.X) -> rotate -> tiling/offset (blob 274-281) ----
                float rot = SMOKE_DEG2RAD * _LightMapUVRotate;
                float sinR = sin(rot);
                float cosR = cos(rot);
                float custom1X = input.customData.x * _InParticle;                                  // blob 277
                float2 lmUV;
                lmUV.x = mad(_LightMapUVSpeed.z, custom1X, mad(_LightMapUVSpeed.x, time, input.uv0.x)) - 0.5; // blob 278
                lmUV.y = mad(_LightMapUVSpeed.w, custom1X, mad(_LightMapUVSpeed.y, time, input.uv0.y)) - 0.5; // blob 279
                float2 lmRot;
                lmRot.x = mad(dot(lmUV, float2(cosR, sinR)) + 0.5, _LightMapControls.x, _LightMapControls.z);  // blob 280
                lmRot.y = mad(dot(lmUV, float2(-sinR, cosR)) + 0.5, _LightMapControls.y, _LightMapControls.w);  // blob 281

                // ---- sample positive / negative axes lightmaps (blob 286-293) ----
                // HGRP samples positive with LinearMirrorOnce, negative with PointClamp + _GlobalMipBias; URP uses bias 0.
                float4 posTex = SAMPLE_TEXTURE2D(_PositiveAxesLightmap, sampler_PositiveAxesLightmap, lmRot); // T1 (blob 286)
                float4 negTex = SAMPLE_TEXTURE2D(_NegativeAxesLightmap, sampler_NegativeAxesLightmap, lmRot); // T2 (blob 290)
                float3 posOcc = posTex.xyz; // RGB = +axis occlusion (blob 287-289 _265/_266/_267)
                float3 negOcc = negTex.xyz; // RGB = -axis occlusion (blob 291-293 _275/_276/_277)

                // ---- absorption coefficient sigma (blob 294) ----
                float sigma = (SMOKE_INV_PI + _AbsorptionRange) * SMOKE_ABSORB_SCALE;

                // ---- orthonormal six-way axes (blob 295-297) ----
                float3 axisT = input.tangentWS.xyz;                       // "right" (TEXCOORD_5)
                float3 axisN = input.normalWS;                           // "up/forward" (TEXCOORD_4)
                // bitangent = -cross(normal, tangent) exactly as blob _322..324 (blob 295-297)
                float3 axisB;
                axisB.x = mad(-axisN.y, axisT.z, -((-axisN.z) * axisT.y));
                axisB.y = mad(-axisN.z, axisT.x, -((-axisN.x) * axisT.z));
                axisB.z = mad(-axisN.x, axisT.y, -((-axisN.y) * axisT.x));

                // ---- per-tint-channel absorption exponents (blob 565-567) ----
                float3 absorbExp;
                absorbExp.x = mad(log2(expColor.x), -SMOKE_ABSORB_TINT_EXP, 1.0); // blob 565
                absorbExp.y = mad(log2(expColor.y), -SMOKE_ABSORB_TINT_EXP, 1.0); // blob 566
                absorbExp.z = mad(log2(expColor.z), -SMOKE_ABSORB_TINT_EXP, 1.0); // blob 567

                // ---- six-way isotropic ambient gather (sum of 6 absorbed axis samples) (blob 574-576) ----
                float gR = SixWayGather(sigma, posOcc, negOcc, absorbExp.x); // blob 574
                float gG = SixWayGather(sigma, posOcc, negOcc, absorbExp.y); // blob 575
                float gB = SixWayGather(sigma, posOcc, negOcc, absorbExp.z); // blob 576

                // ---- ambient SH irradiance (HGRP IV volume -> URP SampleSH) (blob 313-557) ----
                // HGRP gathered an image-volume directional SH (_639/_641/_643) scaled by _IVDefaultSHA*; URP's SampleSH(N)
                // is the faithful infra substitute. axisN (world normal) is the evaluation direction; _AmbientIntensity
                // re-exposes the HGRP env intensity the IV result was multiplied by.
                float3 ambient = max(SampleSH(axisN), 0.0) * _AmbientIntensity;
                float3 ambientIrr = float3(ambient.x * gR, ambient.y * gG, ambient.z * gB); // blob 555-557 form (_639*_754 etc.)

                // ---- env light saturation on the ambient gather (blob 577-581) ----
                // _EnvLightSaturation lerps each channel between the gather luma and the per-channel ambient*gather.
                float gLuma = dot(ambientIrr, SMOKE_LUMA); // blob 577 (luma of _639*_754, _641*_755, _643*_756)
                float negGLuma = -gLuma;
                float3 envColor;
                envColor.x = mad(_EnvLightSaturation, mad(gR, ambient.x, negGLuma), gLuma); // blob 579 (_773)
                envColor.y = mad(_EnvLightSaturation, mad(gG, ambient.y, negGLuma), gLuma); // blob 580 (_774)
                envColor.z = mad(_EnvLightSaturation, mad(gB, ambient.z, negGLuma), gLuma); // blob 581 (_775)

                // ---- main directional light six-way absorption (blob 585-605) ----
                // HGRP gates by TEXCOORD_3.w>0.001 (precomputed cloud/sun atten); URP supplies real shadow attenuation.
                float4 shadowCoord = TransformWorldToShadowCoord(positionWS);
                Light mainLight = GetMainLight(shadowCoord);
                float3 mainDir = mainLight.direction; // URP direction points TOWARD the light; HGRP -_LightDir is the same (blob 587 negates the stored dir)
                float3 dirColor = float3(0.0, 0.0, 0.0);
                // blob 585 gated this on TEXCOORD_3.w>0.001 (precomputed sun-visibility); URP applies real shadowing
                // via mainLight.shadowAttenuation, so the directional six-way term runs unconditionally.
                {
                    // project (toward-light) dir onto the three axes (blob 587-589: dot(axis, -storedDir) = dot(axis, mainDir))
                    float dT = dot(axisT, mainDir);
                    float dB = dot(axisB, mainDir);
                    float dN = dot(-axisN, mainDir); // blob 589 uses -TEXCOORD_4
                    float occT = (dT >= 0.0) ? posOcc.x : negOcc.x; // blob 590
                    float occB = (dB >= 0.0) ? posOcc.y : negOcc.y;
                    float occN = (dN >= 0.0) ? posOcc.z : negOcc.z;
                    float ld = log2(clamp(dot(float3(dT * dT, dB * dB, dN * dN), float3(occT, occB, occN)) / sigma, 0.0, 1.0)); // blob 590
                    float3 atten = float3(min(sigma, sigma * exp2(ld * absorbExp.x)),
                                          min(sigma, sigma * exp2(ld * absorbExp.y)),
                                          min(sigma, sigma * exp2(ld * absorbExp.z))); // blob 591-593
                    // blob 591-593: atten *= mainLightColor (_LightDataBuffer[1].xyz). blob 594-598 then applied a
                    // directional shadow ramp T4(uv=(TEXCOORD_3.w,0.5)) as lerp(atten, atten*ramp, 1-w); HGRP's cloud/
                    // sun-shadow chain is replaced by URP mainLight.shadowAttenuation (the faithful infra substitute).
                    float3 lightCol = mainLight.color * mainLight.shadowAttenuation;
                    dirColor = atten * lightCol;
                }

                // ---- additional punctual lights six-way absorption (blob 631-1106) ----
                // HGRP iterated a tiled/z-binned light list with per-light PCF shadow + cookie; URP's GetAdditionalLight
                // is the faithful infra substitute. Per light: same six-way absorption as the directional path,
                // scaled by the light color * its own attenuation/shadow (blob 899-901 multiply _2232*_2607*_1835).
                float3 addColor = float3(0.0, 0.0, 0.0);
            #if defined(_ADDITIONAL_LIGHTS) || defined(_FORWARD_PLUS)
                // URP's LIGHT_LOOP_BEGIN cluster (Forward+) expansion reads inputData.positionWS /
                // .normalizedScreenSpaceUV by that exact name, so supply a minimal InputData called `inputData`.
                // The non-cluster path uses only lightIndex and ignores this.
                InputData inputData = (InputData)0;
                inputData.positionWS = positionWS;
                inputData.normalizedScreenSpaceUV = GetNormalizedScreenSpaceUV(input.positionCS);
                uint pixelLightCount = GetAdditionalLightsCount();
                LIGHT_LOOP_BEGIN(pixelLightCount)
                    Light addLight = GetAdditionalLight(lightIndex, positionWS, half4(1, 1, 1, 1));
                    float3 lAtten = SixWayDirectional(sigma, addLight.direction, axisT, axisN, axisB, posOcc, negOcc, absorbExp); // blob 894-901
                    // blob 899-901: absorbed *= lightColor (_LightDataBuffer[_3335].xyz) * shadow(_2607) * attenuation(_2232) * angAtten(_1835).
                    // URP's GetAdditionalLight folds range/spot/shadow into color*distanceAttenuation*shadowAttenuation.
                    float3 lCol = addLight.color * (addLight.shadowAttenuation * addLight.distanceAttenuation);
                    addColor += lAtten * lCol;
                LIGHT_LOOP_END
            #endif

                // ---- VFX color-grade (applied TWICE, exactly as the blob) (blob 1107-1116) ----
                // _VFXColorGrade.w = saturation (lerp channel<->luma); _VFXColorGrade.xyz = tint. (HGRP _VFXParams1.)
                // Pass 1 (blob 1107-1111): grade env (_773..775), tint, then ADD (directional + additional) — the
                // additional sum is multiplied by the loop's accumulated self-shadow scalar _1390 (blob 1109 mad(_1392,_1390,_1199)).
                // _1390 is initialized to 1 (blob 623) and only re-scaled by shadow-only occluder lights (HGRP light-type
                // w>=1.5, blob 1087-1093 `_1668 = _2225 * _1391`): a punctual light that casts a PCF self-shadow on the
                // smoke but emits NO color (its RGB contribution _2265/_2267/_2269 = 0, blob 1094-1096). URP's
                // GetAdditionalLight has no such "shadow-only occluder that dims the aggregate of other lights" concept,
                // so _1390 is engine-side-unrepresentable and faithfully reduces to 1 here (consistent with the dropped
                // HGRP light-binning/PCF-atlas apparatus; the directional+additional color sum is otherwise exact).
                float envLuma = dot(envColor, SMOKE_LUMA);                            // blob 1107 (_1525)
                float negEnvLuma = -envLuma;                                          // blob 1108 (_1528)
                float3 pass1;
                pass1.x = mad(mad(_VFXColorGrade.w, negEnvLuma + envColor.x, envLuma), _VFXColorGrade.x, dirColor.x + addColor.x); // blob 1109
                pass1.y = mad(mad(_VFXColorGrade.w, negEnvLuma + envColor.y, envLuma), _VFXColorGrade.y, dirColor.y + addColor.y); // blob 1110
                pass1.z = mad(mad(_VFXColorGrade.w, negEnvLuma + envColor.z, envLuma), _VFXColorGrade.z, dirColor.z + addColor.z); // blob 1111
                // Pass 2 (blob 1112-1116): grade the whole composite again with the same saturation + tint.
                float p1Luma = dot(pass1, SMOKE_LUMA);                                // blob 1112 (_1550)
                float negP1Luma = -p1Luma;                                            // blob 1113 (_1553)
                float3 graded;
                graded.x = mad(_VFXColorGrade.w, negP1Luma + pass1.x, p1Luma) * _VFXColorGrade.x; // blob 1114
                graded.y = mad(_VFXColorGrade.w, negP1Luma + pass1.y, p1Luma) * _VFXColorGrade.y; // blob 1115
                graded.z = mad(_VFXColorGrade.w, negP1Luma + pass1.z, p1Luma) * _VFXColorGrade.z; // blob 1116

                outColor = graded;                  // blob 1123-1125 (SV_Target.xyz = _1568/_1569/_1570)
                outAlpha = fadeTintA * posTex.w;    // blob 303,1126 _404 = _377 * _263.w (clamped fade-tint * lightmap density)
            #else
                // ===================== BASE (no lightmap) — pure tint card (blob Fragment_b201) =====================
                // Base variant outputs black RGB with computed alpha (blob b201 70-73: SV_Target.xyz = 0).
                outColor = float3(0.0, 0.0, 0.0);
                outAlpha = fadeTintA; // blob b201 69 _114
            #endif

                // ---- straight (non-premultiplied) output, exactly as the blob (blob 1123-1126 / b201 70-73) ----
                // The blob writes SV_Target.xyz = graded (NO premultiply) and SV_Target.w = _404 (straight alpha),
                // and relies on the bound render-state (Blend [_SrcBlend][_DstBlend], set by the material editor per
                // _SurfaceType/_BlendMode: SrcAlpha/OneMinusSrcAlpha for Alpha, One/One for Additive) to do the blend.
                // Do NOT premultiply here and do NOT gate alpha to 0 for additive — that would darken additive smoke by
                // its own alpha (the blob adds full `graded`, not `alpha*graded`) and is not what the blob computes.
                return half4(outColor, outAlpha);
            }
            ENDHLSL
        }
    }
}
