// HGRP VFX Refract — Unified Fix shader (single "Distortion" pass collapsed to one URP transparent forward pass).
// Screen-space refraction / heat-haze particle: samples a refract texture (T0) to build a UV distortion,
// then samples the scene-color grab (HGRP distortion grab T1 -> URP _CameraOpaqueTexture) at the distorted
// screen UV. Optional Mask / RBOffset variants add a second texture lookup that the refraction blends with.
// Merged from: vfxrefract base b175 (HG_ENABLE_MV) + b177 (_USE_MASK) + b179 (_USE_RBOFFSET).
//
// Keywords: _USE_MASK, _USE_RBOFFSET   (mutually exclusive feature branches, mirroring the source ladder)
// Kept: refract-tex rotate+dir mapping, Bi_Refract [0,1]->[-1,1] remap, RefractIsNormal distortion,
//   intensity = (1-LODFade.y? -> 1)*_Intensity*_SurfaceType*vertColor.a, screen-UV scene refraction,
//   two-band near-camera fade, Mask second-tex screen-locked blend (b177), RBOffset max() screen blend (b179).
// Removed (pixel-neutral pipeline infra substituted by URP, or sandbox-dropped):
//   - GPU skinning (ByteAddressBuffer T0 blendweights, vertex blob b174) — static mesh, TransformObjectToWorld.
//   - SV_Target1 transparent motion-vector MRT (HG_ENABLE_MV second target) — motion-vector pipeline plumbing,
//     zero color contribution; URP particle path has no transparent-MV buffer here. (see gaps / TODO)
//   - TAA jitter (_TaaJitterStrength), NonJittered/Prev VP matrices, _PrevCamPosRWS (only fed the dropped MV).
//   - HDRP grab-buffer T1 + _GlobalMipBias mip bias -> URP SampleSceneColor(_CameraOpaqueTexture).
//   - _VFXParams0.w particle-time global -> _Time.y.
//   - SRP_INSTANCING_ON, and all higher feature keywords not in the merged set
//     (_USE_POLARUV/_USE_RGBOFFSET/_USE_DISSOLVE/_USE_BLEND/_USE_SATURATION/_USE_SPREAD/_USE_FRESNEL_MASK/_USE_TRAIL/_USE_SOFTBLEND).
//
// NOTE: HGRP packoffset-aliased symbol names are preserved 1:1 to the blob math even where the inspector label
//   differs (HGRP remaps via its ParamBlob): the UV rotation angle is _TintColorAlpha (blob b175:91), the
//   Bi_Refract remap factor is _EnableTransparentMV_at_52 (blob b175:95), and the screen-distortion scales are
//   _RefractTexUVRotate / _RefractSwitchUV (blob b175:97-98). They are exposed below under their real-feature
//   property names with the alias documented, so the merged shader is editable while staying bit-faithful.

Shader "HGRP/Effect/VfxRefract_Fix" {
    Properties {
        [Header(Base)]
        [Enum(Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableZTest ("Disable ZTest", Float) = 0
        [ToggleUI] _DisableParticleInstanceColor ("Disable Particle Instance Color", Float) = 0
        _TintColorAlpha ("Refract UV Rotate (Degree) [blob alias _TintColorAlpha]", Range(0, 10)) = 1
        [HideInInspector] _ProcedureAlpha ("Procedure Alpha", Float) = 1
        _Intensity ("Refract Intensity (also VertColor.a)", Range(0, 1)) = 1
        [ToggleUI] _Bi_Refract ("Refract in 2 Direction [blob alias _EnableTransparentMV_at_52]", Float) = 0

        [Header(Refract Tex)]
        _RefractTex ("Refract Tex", 2D) = "white" {}
        [ToggleUI] _RefractIsNormal ("Refract Is Normal", Float) = 1
        _RefractUVSpeed ("Refract UV Speed (XY:By Time, ZW:By Custom1.X)", Vector) = (0, 0, 0, 0)
        _RefractTexUVRotate ("Refract Distortion Scale X (screen, blob _RefractTexUVRotate)", Float) = 0
        _RefractSwitchUV ("Refract Distortion Scale Y (screen, blob _RefractSwitchUV)", Float) = 0
        _RefractDir ("Refract Dir (XY:Scale In Screen, ZW:Offset)", Vector) = (1, 1, 0, 0)

        [Header(Mask Variant)]
        [Toggle(_USE_MASK)] _UseMask ("Use Mask", Float) = 0
        _MaskTex ("Mask Tex", 2D) = "white" {}
        [ToggleUI] _UseMaskTexAsAlpha ("UseMaskTexAsAlpha (mask R<->A select)", Float) = 1
        [ToggleUI] _MaskTexUseRefract ("MaskTexUseRefract", Float) = 0
        _MaskTexUVSpeed ("MaskTexUVSpeed (XY:Time, ZW:Custom1.Y)", Vector) = (0, 0, 0, 0)
        _MaskTexUVRotate ("MaskTexUVRotate (Degree)", Float) = 0
        // blob b177 reuses _FresnelPower(.z)/_UseMaskTexAsAlpha(.y)/_MaskTexUseRefract(.w) as the mask-UV
        // rotation matrix row + offsets via packoffset aliasing; exposed here under their literal names.
        _FresnelPower ("Mask UV rot/offset aux (blob alias _FresnelPower)", Float) = 1

        [Header(RBOffset Variant)]
        [Toggle(_USE_RBOFFSET)] _UseRBOffset ("Use RBOffset", Float) = 0
        // blob b179 reuses _RefractUVSpeed.z (RB lerp), _MaskTexUVSpeed.xyz / _MaskTex_ST.xyz (per-channel
        // max blend weights), _MaskTexUVRotate / _UseMaskTexAsAlpha_at_148 (RB offset UV step on X/Y),
        // _Intensity_at_60 (normal-len blend). All preserved 1:1 below; tuned via these same fields.

        [Header(Near Camera Fade)]
        _UseNearCameraFade ("Use Near Camera Fade", Float) = 0
        _NearCameraFadeDistanceStart ("Fade Start 1", Range(0.001, 3000)) = 0.001
        _NearCameraFadeDistanceEnd ("Fade End 1", Range(0.001, 3000)) = 10
        _NearCameraFadeDistanceEnd2 ("Fade End 2", Range(0.002, 3000)) = 100
        _NearCameraFadeDistanceStart2 ("Fade Start 2", Range(0.001, 3000)) = 120

        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
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
            // Provides _CameraOpaqueTexture + SampleSceneColor() — the URP equivalent of the HGRP
            // distortion grab buffer (blob T1 / sampler_LinearClamp). Requires Opaque Texture enabled on the URP asset.
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareOpaqueTexture.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Base
                float _SurfaceType;
                float _BlendMode;
                float _Intensity;
                float _Intensity_at_60;        // blob c3.w — RBOffset normal-length blend factor (b179:116)
                float _TintColorAlpha;         // blob c4   — refract-tex UV rotation angle (degrees), b175:91
                float _Bi_Refract;             // blob c4.y — exposed; remap factor below is _EnableTransparentMV_at_52
                float _EnableTransparentMV_at_52; // blob c3.y — Bi_Refract [0,1]->[-1,1] remap factor (b175:95)
                float _DisableParticleInstanceColor;
                float _ProcedureAlpha;
                // Refract Tex
                float _RefractIsNormal;        // blob c2.z
                float _RefractTexUVRotate;     // blob c5   — screen distortion scale X (b175:97)
                float _RefractSwitchUV;        // blob c5.y — screen distortion scale Y (b175:98)
                float4 _RefractDir;            // blob c6   — xy = scale-in-screen, zw = offset (b175:94)
                float4 _RefractTex_ST;         // blob c7
                float4 _RefractUVSpeed;        // blob c8   — .y used in b177 mask lerp, .z in b179 RB lerp
                // Mask (b177)
                float _UseMaskTexAsAlpha;          // blob c8.y
                float _UseMaskTexAsAlpha_at_148;   // blob c9.y — mask-UV / RB-offset aux (b177:118 / b179:124)
                float _FresnelPower;               // blob c8.z
                float _FresnelPower_at_152;        // blob c9.z — mask-UV X rotation-row offset (b177:118)
                float _MaskTexUseRefract;          // blob c8.w
                float _MaskTexUseRefract_at_156;   // blob c9.w — mask-UV Y rotation-row offset (b177:118)
                float _MaskTexUVRotate;            // blob c9   — mask UV rotation angle / RB offset step X
                float4 _MaskTex_ST;                // blob c10  — .xyz used as RB per-channel weight B (b179:125-127)
                float4 _MaskTexUVSpeed;            // blob c11  — .xyz used as RB per-channel weight A (b179:125-127)
                // Near Camera Fade
                float _UseNearCameraFade;
                float _NearCameraFadeDistanceStart;
                float _NearCameraFadeDistanceEnd;
                float _NearCameraFadeDistanceEnd2;
                float _NearCameraFadeDistanceStart2;
                // Render state
                float _TransparentSortPriority;
            CBUFFER_END

            TEXTURE2D(_RefractTex);   SAMPLER(sampler_RefractTex);   // blob T0, sampler_LinearRepeat_RefractTex
            TEXTURE2D(_MaskTex);      SAMPLER(sampler_MaskTex);      // blob T1/T2 secondary tex (mask variant)

            static const float DEG2RAD = 0.01745329238474369049072265625; // pi/180 (blob b175:91)

            // Rotate a 2D vector by (cos,sin). Decompiler spelling: dot(v,(c,s)) and dot(v,(-s,c)).
            // 1:1 source = blob b175:94 (float2(c,s) / float2(-s,c)).
            float2 RotateUV(float2 v, float s, float c)
            {
                return float2(dot(v, float2(c, s)), dot(v, float2((-0.0) - s, c)));
            }
        ENDHLSL

        Pass {
            Name "Refraction"
            LOD 600
            Tags { "LightMode"="UniversalForwardOnly" } // HGRP "Distortion" -> URP transparent forward; scene grab via _CameraOpaqueTexture
            Blend [_SrcBlend] [_DstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _USE_MASK
            #pragma shader_feature_local _USE_RBOFFSET

            struct Attributes {
                float3 positionOS : POSITION;
                float4 color      : COLOR;
                float2 texcoord0  : TEXCOORD0; // blob vertex TEXCOORD (uv0)  -> frag TEXCOORD
                float2 texcoord1  : TEXCOORD1; // blob vertex TEXCOORD_1 (uv1) -> frag TEXCOORD_1
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float2 uv0        : TEXCOORD0; // = blob frag TEXCOORD   (b175 uses .x/.y)
                float2 uv1        : TEXCOORD1; // = blob frag TEXCOORD_1 (b175 uses .x; b177 .y)
                float4 vertColor  : TEXCOORD2; // = blob frag TEXCOORD_2 (.w = intensity weight)
                float3 positionWS : TEXCOORD3; // for near-camera fade view-Z
            };

            Varyings vert(Attributes v)
            {
                Varyings o;
                // Static-mesh world transform (replaces skinning vertex blob b174). 1:1 clip = TransformWorldToHClip.
                float3 posWS = TransformObjectToWorld(v.positionOS);
                o.positionCS = TransformWorldToHClip(posWS);
                o.positionWS = posWS;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                // Particle instance color; blob multiplies COLOR by (1-customData) when DisableParticleInstanceColor,
                // but the catch-all path only consumes .w (vertColor alpha) as the intensity weight (b175:96).
                o.vertColor = v.color;
                return o;
            }

            // Reconstruct view-space distance for the two-band near fade.
            // Source (blob b175:103-107) rebuilds world pos from _InvViewProjMatrix * screen-clip then projects
            // onto _ViewMatrix row 2 (view-Z). Since this fragment IS the particle, positionWS already equals that
            // reconstructed point, so abs(view-Z) = abs(TransformWorldToView(posWS).z). 1:1 result.
            float NearCameraFade(float3 positionWS)
            {
                if (0.0 == _UseNearCameraFade)
                    return 1.0;
                float viewZ = abs(TransformWorldToView(positionWS).z);
                // Two clamped bands (b175:107): far band uses (Start2,End2), near band uses (Start,End).
                float band2 = clamp((viewZ + ((-0.0) - _NearCameraFadeDistanceStart2))
                                    / (((-0.0) - _NearCameraFadeDistanceStart2) + _NearCameraFadeDistanceEnd2), 0.0, 1.0);
                float band1 = clamp((viewZ + ((-0.0) - _NearCameraFadeDistanceStart))
                                    / (((-0.0) - _NearCameraFadeDistanceStart) + _NearCameraFadeDistanceEnd), 0.0, 1.0);
                return band2 * band1;
            }

            half4 frag(Varyings input) : SV_Target
            {
                float vfxTime = _Time.y; // replaces _VFXParams0.w particle time

                // ---- Refract-tex UV (blob b175:89-90) ----
                // _RefractTex_ST.zw scrolls by uv1.x, _RefractTex_ST.xy scrolls by time, centered at -0.5 for rotation.
                float rtX = mad(_RefractTex_ST.z, input.uv1.x, mad(_RefractTex_ST.x, vfxTime, input.uv0.x)) + (-0.5);
                float rtY = mad(_RefractTex_ST.w, input.uv1.x, mad(_RefractTex_ST.y, vfxTime, input.uv0.y)) + (-0.5);

                // Rotate by _TintColorAlpha degrees (blob b175:91-94 — packoffset-aliased angle), +0.5 recenter,
                // then map into screen via _RefractDir (xy=scale, zw=offset).
                float ang = DEG2RAD * _TintColorAlpha;
                float sa = sin(ang);
                float ca = cos(ang);
                float2 rotated = RotateUV(float2(rtX, rtY), sa, ca) + 0.5;
                // Map into screen via _RefractDir: xy = scale, zw = offset (blob b175:94).
                float2 refractUV = float2(mad(rotated.x, _RefractDir.x, _RefractDir.z),
                                          mad(rotated.y, _RefractDir.y, _RefractDir.w));

                float4 refractSample = SAMPLE_TEXTURE2D(_RefractTex, sampler_RefractTex, refractUV);

                // Bi_Refract remap of R channel: [0,1]->[-1,1] when factor=1 (blob b175:95).
                float refR = mad(refractSample.x, 1.0 + _EnableTransparentMV_at_52, (-0.0) - _EnableTransparentMV_at_52);

                // Intensity weight = (1 - LODFade.y) * _Intensity * _SurfaceType * vertColor.a (blob b175:96).
                // LOD crossfade removed (static) -> (1 - 0) = 1.
                float intensity = (1.0 * (_Intensity * _SurfaceType)) * input.vertColor.w;

                // Base screen UV (blob: gl_FragCoord.xy * _ScreenSize.zw).
                float2 screenUV = input.positionCS.xy * (rcp(_ScaledScreenParams.xy));

                // ---- Screen distortion offsets (blob b175:97-99) ----
                float offX = (refR * _RefractTexUVRotate) * intensity;
                float offY = (refR * _RefractSwitchUV) * intensity;
                // _RefractIsNormal path adds a second normal-derived term (uses refractSample.w and .y).
                float distX = mad(_RefractIsNormal,
                                  mad(mad(refR * refractSample.w, 2.0, -1.0) * intensity, _RefractTexUVRotate, (-0.0) - offX),
                                  offX);
                float distY = mad(_RefractIsNormal,
                                  mad(mad(refractSample.y, 2.0, -1.0) * intensity, _RefractSwitchUV, (-0.0) - offY),
                                  offY);

                float3 outColor;
                float outAlpha;

            #if defined(_USE_MASK)
                // ===== Mask variant (blob b177) =====
                // Mask UV (b177:112-118): _MaskTex_ST scroll by uv1.y + time, rotate by _RefractUVSpeed.x degrees,
                // then a screen-locked offset by (distX,distY)*_RefractUVSpeed.w plus aliased rotation-row offsets.
                float mX = mad(_MaskTex_ST.z, input.uv1.y, mad(_MaskTex_ST.x, vfxTime, input.uv0.x)) + (-0.5);
                float mY = mad(_MaskTex_ST.w, input.uv1.y, mad(_MaskTex_ST.y, vfxTime, input.uv0.y)) + (-0.5);
                float mAng = DEG2RAD * _RefractUVSpeed.x;
                float msa = sin(mAng);
                float mca = cos(mAng);
                // b177:118 — note the aliased offsets: X uses (_MaskTexUVRotate, _FresnelPower_at_152),
                //                                      Y uses (_UseMaskTexAsAlpha_at_148, _MaskTexUseRefract_at_156).
                float maskU = mad(distX, _RefractUVSpeed.w,
                                  mad(dot(float2(mX, mY), float2(mca, msa)) + 0.5, _MaskTexUVRotate, _FresnelPower_at_152));
                float maskV = mad(distY, _RefractUVSpeed.w,
                                  mad(dot(float2(mX, mY), float2((-0.0) - msa, mca)) + 0.5, _UseMaskTexAsAlpha_at_148, _MaskTexUseRefract_at_156));

                // Scene grab at the distorted screen UV (b177:117 — T2 == scene buffer; gl_FragCoord.xy*_ScreenSize.zw + dist).
                float3 scene = SampleSceneColor(screenUV + float2(distX, distY));
                // Mask tex (b177:118 — T1 == _MaskTex), sampled at the mask UV.
                float4 maskSample = SAMPLE_TEXTURE2D(_MaskTex, sampler_MaskTex, float2(maskU, maskV));

                // b177:128-131 — lerp scene RGB toward maskSample.rgb by _RefractUVSpeed.y (==1 here uses scene*mask),
                // and alpha = lerp(mask.w, mask.x, _RefractUVSpeed.y) * nearFade.  asfloat(1065353216u)=1.0.
                const float ONE = 1.0;
                outColor.x = clamp(mad(_RefractUVSpeed.y, ((-0.0) - maskSample.x) + ONE, maskSample.x) * scene.x, 0.0, 1000.0);
                outColor.y = clamp(mad(_RefractUVSpeed.y, ((-0.0) - maskSample.y) + ONE, maskSample.y) * scene.y, 0.0, 1000.0);
                outColor.z = clamp(mad(_RefractUVSpeed.y, ((-0.0) - maskSample.z) + ONE, maskSample.z) * scene.z, 0.0, 1000.0);
                float maskAlpha = mad(_RefractUVSpeed.y, ((-0.0) - maskSample.w) + maskSample.x, maskSample.w) * ONE;
                outAlpha = clamp(maskAlpha * NearCameraFade(input.positionWS), 0.0, 1.0);

            #elif defined(_USE_RBOFFSET)
                // ===== RBOffset variant (blob b179) =====
                // Distortion uses the same screen offsets, but the secondary sample is the scene grab itself,
                // re-sampled at a small per-channel offset (chromatic RB split).
                float intensityRB = ((_Intensity * _SurfaceType) * 1.0) * input.vertColor.w; // b179:109 (LODFade->1)
                float t154 = intensityRB * mad(refR * refractSample.w, 2.0, -1.0);  // b179:110
                float t155 = intensityRB * mad(refractSample.y, 2.0, -1.0);          // b179:111
                float t160 = t154 * _RefractTexUVRotate;                              // b179:112
                float t161 = t155 * _RefractSwitchUV;                                 // b179:113
                float t178 = intensityRB * (refR * _RefractTexUVRotate);             // b179:114
                float t179 = intensityRB * (refR * _RefractSwitchUV);                // b179:115
                // Normal-length blend (b179:116): blends refraction magnitude into an offset weight via _Intensity_at_60.
                float t188 = mad(mad(_RefractIsNormal, ((-0.0) - refR) + sqrt(dot(float2(t160, t161), float2(t160, t161))), refR),
                                 _Intensity_at_60, 1.0 + ((-0.0) - _Intensity_at_60));

                float sX = screenUV.x + mad(_RefractIsNormal, mad(t154, _RefractTexUVRotate, (-0.0) - t178), t178); // b179:117
                float sY = screenUV.y + mad(_RefractIsNormal, mad(t155, _RefractSwitchUV, (-0.0) - t179), t179);  // b179:118
                float t226 = input.vertColor.w * _Intensity;                          // b179:119

                // Primary scene grab (b179:120) + RB-offset scene grab (b179:124). 0.01 == blob 0.00999999...f.
                const float RBSTEP = 0.00999999977648258209228515625;
                float3 scene0 = SampleSceneColor(float2(sX, sY));
                float3 sceneRB = SampleSceneColor(float2(
                    mad((RBSTEP * _MaskTexUVRotate) * t226, t188, sX),
                    mad((RBSTEP * _UseMaskTexAsAlpha_at_148) * t226, t188, sY)));

                // b179:125-127 — per channel: lerp(scene0, max(sceneRB*_MaskTexUVSpeed, scene0*_MaskTex_ST), _RefractUVSpeed.z).
                outColor.x = clamp(mad(_RefractUVSpeed.z, ((-0.0) - scene0.x) + max(sceneRB.x * _MaskTexUVSpeed.x, scene0.x * _MaskTex_ST.x), scene0.x), 0.0, 1000.0);
                outColor.y = clamp(mad(_RefractUVSpeed.z, ((-0.0) - scene0.y) + max(sceneRB.y * _MaskTexUVSpeed.y, scene0.y * _MaskTex_ST.y), scene0.y), 0.0, 1000.0);
                outColor.z = clamp(mad(_RefractUVSpeed.z, ((-0.0) - scene0.z) + max(sceneRB.z * _MaskTexUVSpeed.z, scene0.z * _MaskTex_ST.z), scene0.z), 0.0, 1000.0);
                outAlpha = NearCameraFade(input.positionWS); // b179:132

            #else
                // ===== Base variant (blob b175) =====
                // Scene grab at distorted screen UV (b175:99 — T1 == scene buffer; gl_FragCoord.xy*_ScreenSize.zw + dist).
                float3 scene = SampleSceneColor(screenUV + float2(distX, distY));
                outColor = clamp(scene, 0.0, 1000.0); // b175:100-102
                outAlpha = NearCameraFade(input.positionWS); // b175:107
            #endif

                return half4(outColor, outAlpha);
            }
            ENDHLSL
        }
    }
}
