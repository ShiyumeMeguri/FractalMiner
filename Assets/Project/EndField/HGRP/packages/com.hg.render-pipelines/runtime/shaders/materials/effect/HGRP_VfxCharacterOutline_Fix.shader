// HGRP VFX Character Outline — inverted-hull screen-space outline, flat tint output.
//   One pass (HGRP "ForwardOnly" -> URP "SRPDefaultUnlit"): expands the silhouette along the
//   clip-space projected (optionally smoothed) normal by a FOV-corrected, distance-attenuated,
//   min-pixel-width-clamped width, with a depth bias; the fragment emits a flat exposure-scaled
//   _TintColor optionally faded toward the screen center, then fogged.
//
// Merged from: vfxcharacteroutline.shader (HGRP/Effect/VFXCharacterOutline).
//   Base variant blobs (catch-all #else): Sub0_Pass0_Vertex_b16.hlsl / Sub0_Pass0_Fragment_b17.hlsl
//   Focus-center delta: Sub0_Pass0_Fragment_b19.hlsl (_USE_FOCUS_SCREEN_CENTER)
// Keywords: _USE_FOCUS_SCREEN_CENTER
// Kept: inverted-hull outline extrusion (FOV correction via atan(tan(fov/2)) poly, π/8 width scale,
//   ×10 width gain, far-width clamp, distance attenuation, min-pixel-width floor using min(screenW,screenH),
//   Z depth bias with ortho/perspective split), smooth-normal (UV2 tangent-space) vs vertex-normal toggle,
//   flat tint × intensity / post-exposure, focus-screen-center radial fade, premultiplied-alpha tint output
//   (SV_Target.w = tint alpha unconditionally; opaque/transparent is selected by bound _SrcBlend/_DstBlend, not the frag).
// Removed: GPU skinning (ByteAddressBuffer skin matrices) -> URP static GetVertexPositionInputs/GetVertexNormalInputs,
//   motion vectors / SV_Target1 (HG_ENABLE_MV, prev-frame matrices, _EnableTransparentMV, _Responsive MV write),
//   TAA jitter, instancing (SRP_INSTANCING_ON), dither (DITHER), baked-skinning mesh (BAKED_SKINNING_MESH),
//   HGRP atmospheric scattering + exponential + volumetric froxel fog -> URP MixFog.
//
// NOTE: _ExposureParams is an HGRP global (post-exposure); URP has no equivalent, so it is re-exposed
//   as a material Vector (.x = exposure multiplier), gated by _IgnorePostExposure (blob Fragment_b17 line 112).
// NOTE: the octahedral normal/tangent unpack in the skinned base blob (Vertex_b16 lines 150-219, the
//   asuint(NORMAL.x)&1073741824 branch + 1/511 decode) is GPU-skinning vertex-stream packing; on the
//   clean static path the equivalent data arrives as normalOS/tangentOS/uv2 and is handled by URP.

Shader "HGRP/VfxCharacterOutline_Fix" {
    Properties {
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 1

        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1
        [ToggleUI] _OutlineAverageNormal ("Use Smooth Normal (UV2)", Float) = 1
        _OutlineWidth ("Outline Width", Range(0, 1)) = 0.05
        _OutlineFarWidth ("Far Distance Width Cap", Range(5, 100)) = 100
        _OutlineOffsetZ ("Outline Offset Z", Range(0, 1)) = 0

        _TintColor ("Tint Color", Color) = (1, 1, 1, 1)
        _TintColorIntensity ("Tint Color Intensity", Range(1, 100)) = 1
        _TintColorAlpha ("Tint Color Alpha", Range(0, 1)) = 1

        [Toggle(_USE_FOCUS_SCREEN_CENTER)] _UseFocusScreenCenter ("Focus Only At Screen Center", Float) = 0
        _FocusScreenCenterInnerSize ("Focus Inner Size", Range(0, 1)) = 0.5
        _FocusScreenCenterOuterRange ("Focus Fade Range", Range(0, 1)) = 0.5

        // Post-exposure (HGRP global re-exposed; .x = exposure multiplier)
        _ExposureParams ("Exposure Params (.x = exposure)", Vector) = (1, 0, 0, 0)

        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
    }

    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
        }
        LOD 300

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float _SurfaceType;
                float _IgnorePostExposure;
                float _OutlineAverageNormal;
                float _OutlineWidth;
                float _OutlineFarWidth;
                float _OutlineOffsetZ;
                float4 _TintColor;
                float _TintColorIntensity;
                float _TintColorAlpha;
                float _FocusScreenCenterInnerSize;
                float _FocusScreenCenterOuterRange;
                float4 _ExposureParams;
            CBUFFER_END

            // atan(tan(fov/2)) reconstructed from the projection matrix, via the same rational
            // approximation the blob emits (Vertex_b16 lines 496-505). Input t = |1/P._m11|.
            // 0.0872929 / -0.301895 / 1.5707964 (=pi/2) are the blob's exact poly constants.
            float OutlineHalfFov(float tanHalf)
            {
                bool small = abs(tanHalf) < 1.0;
                float t = small ? abs(tanHalf) : (1.0 / abs(tanHalf));
                float t2 = t * t;
                float approx = mad(mad(t2, 0.0872929021716117858886718750, -0.30189499258995056152343750), t2, 1.0);
                float angle = small ? (t * approx) : mad(-approx, t, 1.57079637050628662109375);
                return (tanHalf < 0.0) ? -angle : angle;
            }
        ENDHLSL

        // ================================================================
        // Outline (inverted hull). HGRP "ForwardOnly" -> URP "SRPDefaultUnlit".
        // ================================================================
        Pass {
            Name "Outline"
            Tags { "LightMode"="SRPDefaultUnlit" }
            Blend [_SrcBlend] [_DstBlend], One One
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _USE_FOCUS_SCREEN_CENTER
            #pragma multi_compile_fog

            struct Attributes {
                float3 positionOS  : POSITION;
                float3 normalOS    : NORMAL;
                float4 tangentOS   : TANGENT;
                float2 uv          : TEXCOORD0;
                float2 smoothNrmTS : TEXCOORD2; // packed smooth-normal XY (tangent space)
            };

            struct Varyings {
                float4 positionCS : SV_Position;
                float3 positionWS : TEXCOORD0;
                float  fogFactor  : TEXCOORD1;
            };

            Varyings vert(Attributes input)
            {
                Varyings o = (Varyings)0;

                VertexPositionInputs posIn = GetVertexPositionInputs(input.positionOS);
                VertexNormalInputs   nrmIn = GetVertexNormalInputs(input.normalOS, input.tangentOS);

                o.positionWS = posIn.positionWS;

                // --- Choose extrusion normal: smooth (UV2 tangent-space) or vertex normal ---
                // Vertex_b16 lines 491-495: _926 = 0.5 < _OutlineAverageNormal;
                //   _942 = sqrt(-min(dot(uv2,uv2),1)+1) (reconstruct TS Z);
                //   smoothWS = normalWS*Z + tangentWS*uv2.x + (tangentSign*bitangent)*uv2.y.
                // _786 (Vertex_b16 line 478) = tangentOS.w * sign(worldTransform.w) -> URP tangentWS.w sign.
                float3 extrudeNormalWS = nrmIn.normalWS;
                if (_OutlineAverageNormal > 0.5) {
                    float2 ts = input.smoothNrmTS;
                    float z = sqrt(-min(dot(ts, ts), 1.0) + 1.0);
                    float tangentSign = input.tangentOS.w * GetOddNegativeScale();
                    float3 bitWS = cross(nrmIn.normalWS, nrmIn.tangentWS) * tangentSign;
                    extrudeNormalWS = nrmIn.tangentWS * ts.x + bitWS * ts.y + nrmIn.normalWS * z;
                }

                float4 clipPos = posIn.positionCS;

                // --- Project extrusion normal to clip-space XY (rotation only) ---
                // Vertex_b16 lines 503-505: via NonJitteredViewNoTransProj rotation -> URP UNITY_MATRIX_VP.
                float2 screenN = mul((float3x3)UNITY_MATRIX_VP, extrudeNormalWS).xy;
                float screenNInvLen = rsqrt(dot(screenN, screenN)); // _1027

                // --- FOV half-angle from projection (Vertex_b16 lines 496-502) ---
                float tanHalf = -1.0 / UNITY_MATRIX_P._m11; // _983
                float halfFov = OutlineHalfFov(tanHalf);     // _1005

                // --- Width: pi/8 / halfFov * _OutlineWidth * 10 (Vertex_b16 line 506) ---
                float width = (0.392699033021926879882812500 / halfFov) * _OutlineWidth * 10.0; // _1049
                // Distance attenuation: clamp(clipW * halfFov * 4.583662..., 0, _OutlineFarWidth) (line 507)
                float distAtten = min(max((clipPos.w * halfFov) * 4.583662509918212890625, 0.0), _OutlineFarWidth); // _1060

                // --- Screen-space offset (Vertex_b16 lines 508-511) ---
                // aspect on x only (screenN.y term multiplies by 1.0 = asfloat(1065353216u)); ×0.005.
                float aspect = _ScreenParams.y / _ScreenParams.x;
                float2 offset;
                offset.x = (distAtten * (width * (screenNInvLen * screenN.x * aspect))) * 0.004999999888241291046142578125; // _1063
                offset.y = (distAtten * (width * (screenNInvLen * screenN.y))) * 0.004999999888241291046142578125;          // _1065

                // --- Min pixel width floor (Vertex_b16 line 512) ---
                // single scalar 1/min(screenH,screenW) for BOTH axes; max-extent uses 16*pi = 50.265476.
                float minPixel = (1.0 / min(_ScreenParams.y, _ScreenParams.x))
                               * min(50.265476226806640625 / halfFov, max(clipPos.w, 0.0)); // _1076
                // (abs(offset) < minPixel) ? minPixel * sign(offset) : offset   (lines 513-514, pre-jitter)
                offset.x = (abs(offset.x) < minPixel) ? (minPixel * sign(offset.x)) : offset.x;
                offset.y = (abs(offset.y) < minPixel) ? (minPixel * sign(offset.y)) : offset.y;

                clipPos.xy += offset;

                // --- Z depth bias (Vertex_b16 lines 515-516) ---
                // Perspective: viewZ = -clipW - 0.1*_OutlineOffsetZ; z = clipW*(viewZ*P._m22 + P._m23)/(-viewZ).
                // Ortho: z += (-0.1 * _OutlineOffsetZ)/_ProjectionParams.z.
                if (unity_OrthoParams.w == 0.0) {
                    float viewZ = mad(_OutlineOffsetZ, -0.100000001490116119384765625, -clipPos.w); // _1136
                    clipPos.z = (clipPos.w * mad(viewZ, UNITY_MATRIX_P._m22, UNITY_MATRIX_P._m23)) / (-viewZ);
                } else {
                    clipPos.z += (-0.100000001490116119384765625 * _OutlineOffsetZ) / _ProjectionParams.z;
                }

                o.positionCS = clipPos;
                o.fogFactor = ComputeFogFactor(clipPos.z);
                return o;
            }

            float4 frag(Varyings input) : SV_Target
            {
                // --- Tint alpha (Fragment_b17 line 111) ---
                // _177 = saturate(saturate(_TintColor.w) * _TintColorAlpha)
                float tintAlpha = clamp(clamp(_TintColor.w, 0.0, 1.0) * _TintColorAlpha, 0.0, 1.0);

                #ifdef _USE_FOCUS_SCREEN_CENTER
                    // Focus-screen-center radial fade (Fragment_b19 lines 95-96,113-117).
                    // Pixel distance from screen center / min(screenW,screenH), remapped through
                    // (-d + inner)/outer + 1, saturated, folded into tint alpha.
                    // _48/_49 = uint(gl_FragCoord.xy): the integer pixel index, so floor() the
                    //   URP SV_Position (= gl_FragCoord) to drop the +0.5 sub-pixel center (1:1 with blob).
                    float2 fragCoord = floor(input.positionCS.xy);
                    float2 fromCenter = fragCoord - float2(floor(0.5 * _ScreenParams.x), floor(0.5 * _ScreenParams.y));
                    float centerDist = sqrt(dot(fromCenter, fromCenter)) / min(_ScreenParams.y, _ScreenParams.x);
                    float focus = clamp(((-centerDist + _FocusScreenCenterInnerSize) / _FocusScreenCenterOuterRange) + 1.0, 0.0, 1.0);
                    tintAlpha = clamp(clamp(focus * _TintColor.w, 0.0, 1.0) * _TintColorAlpha, 0.0, 1.0);
                #endif

                // --- Exposure-scaled, alpha-premultiplied tint (Fragment_b17 lines 112, 183-185, 191) ---
                // _200 = _IgnorePostExposure!=0 ? _ExposureParams.x : 1.0
                // SV_Target.rgb = _177 * saturate0..1000( _TintColorIntensity * _TintColor.rgb / exposure )
                //   then fog-modulated (_795*_290 transmit + inscatter). _177 (=tintAlpha) premultiplies
                //   the RGB because the pass is premultiplied-alpha (Blend One [_DstBlend]). SV_Target.w = _177.
                float exposure = (_IgnorePostExposure != 0.0) ? _ExposureParams.x : 1.0;
                float3 color = tintAlpha * min(max((_TintColorIntensity * _TintColor.rgb) / exposure, 0.0), 1000.0);

                // HGRP atmospheric + exponential + volumetric fog (transmittance _290 + inscatter _792)
                // -> URP MixFog (infra substitution).
                color = MixFog(color, input.fogFactor);

                // Output alpha = _177 (tintAlpha) UNCONDITIONALLY. The blob writes SV_Target.w = _177
                //   for every surface type (Fragment_b17 line 191 / Fragment_b19 line 195) — the
                //   opaque/transparent split lives in the bound blend state (_SrcBlend/_DstBlend, , One One),
                //   NOT in the fragment alpha. No _SurfaceType branch on the alpha exists in the blob.
                return float4(color, tintAlpha);
            }
            ENDHLSL
        }
    }
}
