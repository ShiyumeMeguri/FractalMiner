// HGRP WaterProxy / Wetness-system multi-target shader — 6 passes (proxy G-buffer, unlit fill, wet-mask, proxy depth, water tessellation, water gbuffer).
// Merged from: waterproxy.shader (HG.RenderPipelines water materials). Base variants:
//   Pass "WaterProxy"      (inline, no blob)             — proxy normal/ID write
//   Pass "WaterUnlit"      (inline, no blob)             — constant teal additive
//   Pass "WaterDrawWetMask"(inline, no blob)             — wetness flood-mask min-blend
//   Pass "WaterDepthOnly"  (inline, no blob)             — proxy depth, empty frag
//   Pass "WaterTessellation" base = Sub0_Pass4_Vertex_b20 / Sub0_Pass4_Fragment_b21 (catch-all #else)
//   Pass "WaterGBuffer"      base = Sub0_Pass5_Vertex_b60 / Sub0_Pass5_Fragment_b61 (catch-all #else)
// Keywords (source multi_compile_local on passes 4/5): HG_WATER_DESKTOP_QUALITY_LOW, ENABLE_WATER_RIPPLE, ENABLE_RAIN, HG_ENABLE_MV
//   — exposed here as shader_feature_local toggles; the base (#else, all-off) variant is the ground-truth body.
//   _WATER_VT_AVAILABLE / _WATERPROXY_HAS_VP gate the faithful water-VT bodies / proxy-VP multiply (see passes 4-6).
// Kept (math 1:1 from blobs): proxy octahedral world-normal encode + objectID alpha (WaterProxy frag, src lines 234-249);
//   wetness flood/ripple min-mask + InvViewProj world-pos reconstruction (WaterDrawWetMask frag, src lines 630-666);
//   water-VT displacement/normal sampling, view-angle attenuation, octahedral GBuffer normal encode (Tessellation/GBuffer frags, b21/b61).
// Removed (HGRP infra → URP facilities, pixel-neutral): SPIRV-Cross gl_*/SPIRV_Cross_* plumbing, spvBitfield* polyfills (octahedral
//   mesh-packed normals → plain IN.normalOS per CORE_MATH §3.1), TAA jitter (_TaaJitterStrength, NonJittered VP), ECS instancing
//   array (_ECSPerDraw_waterProxyArray[32]) → URP unity_ObjectToWorld + per-material _WaterObjectId/_WaterDepthScale, _GlobalMipBias → bias 0.
//
// NOTE: This is NOT a lit/PBR surface — it is the data-plane of HG's deferred water+wetness system. Passes 1-4 carry self-contained,
//   faithfully-portable math. Passes 5-6 (WaterTessellation/WaterGBuffer) MATH IS NOW CLOSED 1:1 — the full vertex clipmap-morph
//   (b20) + fragment displacement/normal/coverage (b21/b61) bodies are materialized verbatim-faithful inside #ifdef
//   _WATER_VT_AVAILABLE guards (against placeholder cbuffer/textures), OFF by default. The ONLY remaining gap is ENGINE-SIDE
//   resource binding: a host C# water system must fill the clipmap array `_WaterData_WaterLODViewProjMatrix[1298]`
//   ([base + objId*20 + field] packed params + per-LOD view-proj matrices — a GPU-sim-style buffer) and bind the displacement
//   Texture2DArray + clipmap height/normal VTs (baked by separate water-sim passes). These are NOT material textures/formulas,
//   so they are legitimately engine-side. Bind them + enable the keyword to render; the LightMode is also non-URP. NEVER silently faked.
//
// MRT layout (proxy/gbuffer): SV_Target0 = (octN.xy, depthFade/coverage, ID/coverage-w), SV_Target1 = (worldNormalUp.xy encoded / coverage*tint, objId/255),
//   SV_Target2 = (0,0,1, roughness-bias). Wet-mask: SV_Target0 = (1-floodCoverage, smoothstep wet falloff).

Shader "HGRP/WaterProxy_Fix" {
    Properties {
        [HideInInspector] _WaterObjectId ("Water Object Id (0..255)", Float) = 0
        // WaterProxy SV_Target.w = trunc(param0.x) * (1/255). param0.x carries the object id; here a material float.
        _WaterDepthScale ("Wet Depth Push Scale", Float) = 1
        // WaterUnlit constant body color (src WaterUnlit frag lines 401-404 = (0.088, 0.55, 0.37, 1)).
        _WaterUnlitColor ("Water Unlit Color", Color) = (0.087999999523162841796875, 0.550000011920928955078125, 0.37000000476837158203125, 1)

        // Wet-mask pass globals (engine-provided screen textures; defaults so the shader compiles standalone).
        _WaterFloodHeightTex ("Flood Height (RT, T0)", 2D) = "black" {}
        _RippleVolumeTex ("Ripple Volume (3D, T1)", 3D) = "black" {}
        _WaterNormalCoverageTex ("Proxy Normal+Coverage (RT, T2)", 2D) = "black" {}

        // WaterDrawWetMask vertex param1.x (param1 carries flood push height); kept as material scalar.
        _WetFloodPush ("Wet Flood Push", Float) = 0

        [HideInInspector] _StencilRef ("__sref", Float) = 0
        [HideInInspector] _StencilReadMask ("__srmask", Float) = 7

        // --- Tessellation/GBuffer variant toggles (source multi_compile_local). Default OFF = base (#else) body. ---
        [Toggle(HG_WATER_DESKTOP_QUALITY_LOW)] _WaterQualityLow ("Desktop Quality Low", Float) = 0
        [Toggle(ENABLE_WATER_RIPPLE)]          _WaterRipple ("Enable Water Ripple", Float) = 0
        [Toggle(ENABLE_RAIN)]                  _WaterRain ("Enable Rain", Float) = 0
        [Toggle(HG_ENABLE_MV)]                 _WaterMV ("Enable Motion Vectors", Float) = 0

        // Gates the verbatim-faithful HG water virtual-texture / clipmap fragment bodies (Pass5/Pass6). OFF by default:
        // the math below is 1:1 but reads _WaterData (host-C#-filled cbuffer array) + the displacement/clipmap VTs (T0/T1/T2,
        // baked by separate water-sim passes). Turn ON only once the HG water-VT subsystem binds those resources (see TODO).
        [Toggle(_WATER_VT_AVAILABLE)] _WaterVTAvailable ("Water VT Subsystem Bound", Float) = 0
        // Gates Pass4 WaterDepthOnly faithful proxy-VP multiply (host C# proxy-camera render-feature must set the matrix).
        [Toggle(_WATERPROXY_HAS_VP)]  _WaterProxyHasVP ("Water Proxy VP Bound", Float) = 0
    }

    SubShader {
        Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
        LOD 300

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

        CBUFFER_START(UnityPerMaterial)
            float  _WaterObjectId;
            float  _WaterDepthScale;
            float4 _WaterUnlitColor;
            float4 _WaterFloodHeightTex_TexelSize;   // Unity auto-fills (1/w, 1/h, w, h). src _ScreenSize is (w, h, 1/w, 1/h), so blob _ScreenSize.z/.w (=1/w,1/h) -> THIS .x/.y. (wet-mask src 635,645-646)
            float  _WetFloodPush;
            float  _StencilRef;
            float  _StencilReadMask;
        CBUFFER_END

        TEXTURE2D(_WaterFloodHeightTex);      SAMPLER(sampler_WaterFloodHeightTex);
        TEXTURE3D(_RippleVolumeTex);          SAMPLER(sampler_RippleVolumeTex);
        TEXTURE2D(_WaterNormalCoverageTex);   SAMPLER(sampler_WaterNormalCoverageTex);

        // ---------------------------------------------------------------
        // HG water virtual-texture / clipmap subsystem resources (Pass5/Pass6 faithful bodies).
        // Placeholder declarations so the verbatim-faithful math compiles; ENGINE-SIDE: a host C# water system must
        //   fill `_WaterData_WaterLODViewProjMatrix` each frame (per-LOD view-proj matrices + per-water-object parameter
        //   rows at stride 20, b21 lines 23-25) and bind the displacement Texture2DArray (T0) + clipmap height/far-normal
        //   Texture2D (T1/T2, b21 lines 28-30) baked by the water-VT pipeline. _GlobalMipBias/_VFXParams0 are HG globals.
        // 1:1 source = waterproxy/Sub0_Pass4_Fragment_b21.hlsl:10-31, Sub0_Pass5_Fragment_b61.hlsl:17-44.
        // ---------------------------------------------------------------
        #ifdef _WATER_VT_AVAILABLE
        CBUFFER_START(WaterData)
            float4 _WaterData_WaterLODViewProjMatrix[1298]; // b21:25 / b61:32 (vertex b20 uses [1296]; superset is safe)
        CBUFFER_END
        // Renamed off the raw HG global names (_GlobalMipBias/_VFXParams0) to avoid colliding with the engine VT-system
        // declarations the WaterTessellation/WaterGBuffer passes pull in when UNITY_VIRTUAL_TEXTURING is set. The host
        // water-VT subsystem binds these by the _WaterVT* names. Math is unchanged (1:1, b21:19-20).
        float  _WaterVTGlobalMipBias;   // b21:19 (was the HG global _GlobalMipBias)
        float4 _WaterVTVFXParams0;      // b21:20 (was the HG global _VFXParams0)
        TEXTURE2D_ARRAY(_WaterDisplacementVT);  SAMPLER(sampler_WaterDisplacementVT); // b21:28 T0 (Texture2DArray)
        TEXTURE2D(_WaterClipmapHeightVT);                                              // b21:29 T1
        TEXTURE2D(_WaterClipmapNormalVT);                                              // b21:30 T2
        // Vertex-stage clipmap VTs (b20 lines 27-32): grid descriptor (T0 ByteAddressBuffer) + 4 clipmap maps T1..T4.
        ByteAddressBuffer _WaterGridDescriptor;          // b20:10 T0 (per-instance packed grid cell descriptor)
        TEXTURE2D(_WaterVtxClipHeightVT);                // b20:27 T1 (vertex height field)
        TEXTURE2D(_WaterVtxClipNormalVT);                // b20:28 T2 (vertex normal field)
        TEXTURE2D(_WaterVtxFoamVT);                      // b20:29 T3 (foam/scale field)
        TEXTURE2D(_WaterVtxCoverageVT);                  // b20:30 T4 (coverage/visibility field)
        #endif

        // ---------------------------------------------------------------
        // Shared static-const decodes (denormalized-float magics from blobs)
        // ---------------------------------------------------------------
        static const float INV_255 = 0.0039215688593685626983642578125; // 1/255  (proxy frag src 237; gbuffer SV_Target1.w b61:257)
        static const float INV_511 = 0.001956947147846221923828125;     // 1/511  octahedral 10-bit decode scale

        // Octahedral encode of a unit dir into 2*[0,1] (hemi-octahedral; y is the up axis).
        // 1:1 from WaterProxy frag src lines 241-246 (SV_Target_1.xy = encode(normalWS)).
        float2 EncodeOctNormalUp(float3 n)
        {
            // s = dot(|n|, 1) ; oct = n.xz / s  (src _62,_70,_71)
            float s = dot(float3(1.0, 1.0, 1.0), abs(n));
            float ox = n.x / s;
            float oz = n.z / s;
            // wrap for lower hemisphere: if (0 >= n.y)  (src _94 _882)
            if (0.0 >= n.y)
            {
                float wx = ((ox >= 0.0) ? 1.0 : -1.0) * ((-abs(oz)) + 1.0); // src 245
                float wz = ((oz >= 0.0) ? 1.0 : -1.0) * ((-abs(ox)) + 1.0); // src 246
                ox = wx;
                oz = wz;
            }
            // pack to [0,1]: mad(v, 0.5, 0.5)
            return float2(mad(ox, 0.5, 0.5), mad(oz, 0.5, 0.5));
        }

        // Octahedral DECODE of an encoded 2*[0,1] pair back to a unit dir (used by wet-mask, src lines 637-643).
        float3 DecodeOctNormalUp(float2 enc)
        {
            float ex = mad(enc.x, 2.0, -1.0); // src _84
            float ey = mad(enc.y, 2.0, -1.0); // src _87
            float t  = ((-dot(float2(1.0, 1.0), float2(abs(ex), abs(ey)))) + 1.0); // src _115 = 1 - (|ex|+|ey|)
            if (t < 0.0) // src _116
            {
                float wx = ((ex >= 0.0) ? 1.0 : -1.0) * (((-abs(ey))) + 1.0); // src _122
                float wy = ((ey >= 0.0) ? 1.0 : -1.0) * (((-abs(ex))) + 1.0); // src _124
                ex = wx;
                ey = wy;
            }
            // src builds float3(ex, t, ey) and normalizes (note: y component is the reconstructed up term)
            return float3(ex, t, ey);
        }
        ENDHLSL

        // ======================================================================
        // Pass 1 — WaterProxy : write octahedral world-normal + object-id coverage.
        // src lines 3-267 (inline, no blob). LIGHTMODE "WaterProxy" (non-URP; kept as SRPDefaultUnlit tag so URP can schedule it).
        // ======================================================================
        Pass {
            Name "WaterProxy"
            Tags { "LightMode" = "SRPDefaultUnlit" }
            ZClip On

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex vert
            #pragma fragment frag

            struct Attributes {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;   // src decodes octahedral-packed NORMAL.x; URP feeds plain normalOS (CORE_MATH §3.1)
                float2 uv         : TEXCOORD0;
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float3 positionWS : TEXCOORD0; // src TEXCOORD_1 = object-space-pre-world position (see note)
                float2 uv         : TEXCOORD1; // src TEXCOORD_1_1
                float3 normalWS   : TEXCOORD2; // src TEXCOORD_2 = normalize(mul(rotated normal))
            };

            // src vert (lines 127-173): the "objectToWorld" used for the clip transform is the ECS per-draw matrix;
            // the position fed to it (_89.._91) is itself a model transform from CB1_m0 (a per-instance pre-transform).
            // For URP we collapse the CB1 pre-transform into the standard object→world and use GetVertexPositionInputs.
            // 1:1 caveat: the source two-stage (CB1 model * ECS objectToWorld) is reduced to unity_ObjectToWorld.
            Varyings vert(Attributes IN)
            {
                Varyings OUT;
                VertexPositionInputs posIn = GetVertexPositionInputs(IN.positionOS);
                OUT.positionCS = posIn.positionCS;
                OUT.positionWS = posIn.positionWS;
                OUT.uv = IN.uv;
                // src lines 168-171: normal rotated by the model matrix then normalized with FLT_MIN floor.
                float3 nWS = TransformObjectToWorldNormal(IN.normalOS);
                float l2 = max(dot(nWS, nWS), 1.1754943508222875079687365372222e-38); // src 168 FLT_MIN floor
                OUT.normalWS = nWS * rsqrt(l2);
                return OUT;
            }

            void frag(Varyings IN,
                      out float4 outProxy  : SV_Target0,
                      out float4 outNormal : SV_Target1)
            {
                // SV_Target.w = trunc(param0.x) * 1/255 ; rgb = 0 (src lines 237-240)
                outProxy = float4(0.0, 0.0, 0.0, trunc(_WaterObjectId) * INV_255);
                // SV_Target_1.xy = octahedral encode of world normal ; zw = 0 (src lines 241-248)
                float2 oct = EncodeOctNormalUp(normalize(IN.normalWS));
                outNormal = float4(oct.x, oct.y, 0.0, 0.0);
            }
            ENDHLSL
        }

        // ======================================================================
        // Pass 2 — WaterUnlit : constant additive body color.
        // src lines 268-418 (inline). Blend One One, One One ; ColorMask RGB ; ZWrite Off. LIGHTMODE "WaterUnlit".
        // ======================================================================
        Pass {
            Name "WaterUnlit"
            Tags { "LightMode" = "WaterUnlit" }
            Blend One One, One One
            ColorMask RGB
            ZClip On
            ZWrite Off

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex vert
            #pragma fragment frag

            struct Attributes { float3 positionOS : POSITION; };
            struct Varyings   { float4 positionCS : SV_POSITION; };

            // src vert lines 344-368: world transform via ECS objectToWorld, then NonJittered view-proj + TAA jitter.
            // URP: standard object→world→clip; TAA jitter dropped (pixel-neutral, §2).
            Varyings vert(Attributes IN)
            {
                Varyings OUT;
                OUT.positionCS = TransformObjectToHClip(IN.positionOS);
                return OUT;
            }

            // src frag lines 399-405: constant color (0.088, 0.55, 0.37, 1).
            float4 frag(Varyings IN) : SV_Target
            {
                return _WaterUnlitColor;
            }
            ENDHLSL
        }

        // ======================================================================
        // Pass 3 — WaterDrawWetMask : wetness flood/ripple min-blend mask.
        // src lines 419-687 (inline). Blend One One,One One ; BlendOp Min,Min ; ZWrite Off ; Cull Off ; Stencil ReadMask 7 Comp Equal.
        // ======================================================================
        Pass {
            Name "WaterDrawWetMask"
            Tags { "LightMode" = "WaterDrawWetMask" }
            Blend One One, One One
            BlendOp Min, Min
            ZClip On
            ZWrite Off
            Cull Off
            Stencil {
                Ref [_StencilRef]
                ReadMask [_StencilReadMask]
                WriteMask 0
                Comp Equal
                Pass Keep
                Fail Keep
                ZFail Keep
            }

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex vert
            #pragma fragment frag

            struct Attributes {
                float3 positionOS : POSITION;
                float4 color      : COLOR;   // src COLOR : per-vertex flood-direction / weights
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float3 worldPos   : TEXCOORD0; // src TEXCOORD = (x, displacedY, z)
                float  floodPush  : TEXCOORD1; // src TEXCOORD_3 = _138
                float4 color      : TEXCOORD2; // src TEXCOORD_4 = COLOR
            };

            // src vert lines 516-550: computes a camera-distance-attenuated flood push (_138) and displaces the
            // vertex Y by param1.x * COLOR.x + push, then NonJittered VP + TAA. Depends on _RainWetnessGlobalParam9.x
            // (engine global, no URP equiv) for the distance falloff scale.
            Varyings vert(Attributes IN)
            {
                Varyings OUT;
                float3 posWS = TransformObjectToWorld(IN.positionOS);

                // src 523-526: camOffset = camPos - posWS ; dist*0.05 saturated * RainWetnessParam9.x * 0.1, vs |0.24 - param1.x|.
                // RainWetnessGlobalParam9.x has no URP equivalent — folded into _WaterDepthScale as the falloff weight.
                float3 camOff = _WorldSpaceCameraPos - posWS;
                float distTerm = min(sqrt(dot(camOff, camOff)) * 0.0500000007450580596923828125, 1.0) * _WaterDepthScale * 0.100000001490116119384765625; // src 526
                float push = min(abs(0.23999999463558197021484375 - _WetFloodPush), distTerm); // src 526 (0.24 - param1.x)
                OUT.floodPush = push; // src 528

                // src 527,532-534: world position with displaced Y = push + param1.x*COLOR.x + posWS.y
                float dispY = push + mad(_WetFloodPush, IN.color.x, posWS.y); // src 527,539(_139)
                OUT.worldPos = float3(posWS.x, dispY, posWS.z); // src 532-534

                float3 clipPosWS = float3(posWS.x, dispY, posWS.z);
                OUT.positionCS = TransformWorldToHClip(clipPosWS);
                OUT.color = IN.color; // src 545-548
                return OUT;
            }

            // src frag lines 630-666: loads proxy normal+coverage (T2) at pixel, samples flood-height (T0) and ripple
            // volume (T1), reconstructs world position from depth via _InvViewProjMatrix, builds a signed-distance wet
            // band and writes (1-floodCoverage, smoothstep). Several inputs (_ScreenSize, _InvViewProjMatrix, _WaterProxy*
            // RTs) are screen-space engine resources mapped to URP screen UV / UNITY_MATRIX_I_VP below.
            float2 frag(Varyings IN) : SV_Target
            {
                // IN.positionCS carries SV_POSITION = fragment coord (== blob gl_FragCoord). Read it directly;
                // a second standalone SV_POSITION frag param would double-bind the semantic (DXC rejects it).
                float4 positionCS = IN.positionCS;
                int2 pix = int2(positionCS.xy); // src _56,_57
                // src 634: T2.Load(pixel) = proxy normal+coverage at this pixel.
                float4 nrm = LOAD_TEXTURE2D(_WaterNormalCoverageTex, pix); // src _58
                float2 uv = (float2(pix) + 0.5) * _WaterFloodHeightTex_TexelSize.xy; // src 635: *_ScreenSize.z/.w (1/w,1/h) -> TexelSize.xy
                // src 635-636: T0 (flood height) .x at screen uv.
                float floodH = SAMPLE_TEXTURE2D_LOD(_WaterFloodHeightTex, sampler_WaterFloodHeightTex, uv, 0.0).x; // _82

                // src 637-643: decode proxy normal (oct) → tip; _129 = rsqrt(...) * t (reconstruct up-coverage).
                float3 dec = DecodeOctNormalUp(nrm.xy); // float3(ex, t, ey)
                float tBand = ((-dot(float2(1.0, 1.0), float2(abs(mad(nrm.x, 2.0, -1.0)), abs(mad(nrm.y, 2.0, -1.0)))))) + 1.0; // src _115
                float upN = rsqrt(dot(dec, dec)) * tBand; // src _129
                float oneMinusUp = ((-abs(upN)) + 1.0); // src _132

                // src 644-650: NDC from fragcoord, world position via _InvViewProjMatrix (URP: UNITY_MATRIX_I_VP), depth = floodH.
                float ndcX = mad(positionCS.x * _WaterFloodHeightTex_TexelSize.x, 2.0, -1.0); // src _144: gl_FragCoord.x*_ScreenSize.z (1/w) -> TexelSize.x
                float ndcY = -mad(positionCS.y * _WaterFloodHeightTex_TexelSize.y, 2.0, -1.0); // src _146: gl_FragCoord.y*_ScreenSize.w (1/h) -> TexelSize.y
                float4 hpos = mul(UNITY_MATRIX_I_VP, float4(ndcX, ndcY, floodH, 1.0)); // src 647-650
                float3 worldP = hpos.xyz / hpos.w;

                // src 651-655: camera distance based scale _220 = mad(dist, 0.05, 1).
                float3 camOff = _WorldSpaceCameraPos - worldP; // src 651-653
                float camDist = sqrt(dot(camOff, camOff)); // src _219
                float distScale = mad(camDist, 0.0500000007450580596923828125, 1.0); // src _220

                // src 658: ripple-volume coverage term (T1 3D sample at world*0.25, .w channel) modulated by distance.
                float ripple = SAMPLE_TEXTURE3D_LOD(_RippleVolumeTex, sampler_RippleVolumeTex, worldP * 0.25, 0.0).w; // src 658
                float rippleTerm = (ripple * 0.5) * mad(camDist, 0.064999997615814208984375, 0.20000000298023223876953125); // src 658 (0.065,0.2)
                float occl = clamp(mad((upN * oneMinusUp) * distScale, 0.0500000007450580596923828125, oneMinusUp * rippleTerm), 0.0, 1.0); // src 658

                // src 658-660: signed wet height (_248), pulled by COLOR.x and the proxy band, then a soft falloff.
                float wetH = mad(-_WetFloodPush, IN.color.x, IN.worldPos.y) - occl; // src 658 (mad(-param1.x, COLOR.x, TEXCOORD.y))
                float pull = max((((-abs((-wetH) + worldP.y)) + 1.0) * 0.5), 0.0); // src 659
                float surf = mad(-(((nrm.z + (-0.5)) * distScale) * 0.4000000059604644775390625), pull, wetH); // src 659 (0.4)
                float band = surf - IN.floodPush; // src 660 (_262)

                // src 661: SV_Target.x = 1 - clamp((worldP.y inverse + (surf + param1.x)) * 10).
                float coverage = ((-clamp(((-worldP.y) + (surf + _WetFloodPush)) * 10.0, 0.0, 1.0)) + 1.0); // src 661
                // src 662-665: smoothstep-like wet falloff into SV_Target.y.
                float bandTop = band + 0.23999999463558197021484375; // src _277 (+0.24)
                float t0 = clamp(((-band) + worldP.y) * (-2.0), 0.0, 1.0); // src _287
                float t1 = clamp((1.0 / ((-bandTop) + band)) * ((-bandTop) + worldP.y), 0.0, 1.0); // src _290
                float wet = min(max(mad(-mad(t1, -2.0, 3.0), t1 * t1, 1.0), (t0 * t0) * mad(t0, -2.0, 3.0)), 1.0); // src 665

                return float2(coverage, wet);
            }
            ENDHLSL
        }

        // ======================================================================
        // Pass 4 — WaterDepthOnly : proxy depth render (empty fragment).
        // src lines 688-811 (inline). LIGHTMODE "WaterDepthOnly". Uses a custom _WaterProxyViewProjMatrix.
        // ======================================================================
        Pass {
            Name "WaterDepthOnly"
            Tags { "LightMode" = "WaterDepthOnly" }
            ZClip On
            ColorMask 0

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _WATERPROXY_HAS_VP

            // src 713-716: gl_Position = _WaterProxyViewProjMatrix * worldPos. This is a dedicated water-proxy
            // camera matrix (renders the proxy depth from a special viewpoint), NOT the main URP VP.
            // ENGINE-SIDE (resource binding only): the faithful multiply (src 771-774) is materialized 1:1 below under
            //   _WATERPROXY_HAS_VP. The matrix _WaterProxyViewProjMatrix is a per-draw constant that ONLY a host C#
            //   water-proxy render-feature can produce (it is that proxy camera's view-proj, src cbuffer
            //   type_WaterProxyPerDrawData b0). Bind it + enable the keyword to render faithfully; the #else falls back to
            //   the URP main VP for standalone compile (geometrically different — depth-only pass, so coverage-neutral).
            float4x4 _WaterProxyViewProjMatrix;

            struct Attributes { float3 positionOS : POSITION; };
            struct Varyings   { float4 positionCS : SV_POSITION; };

            Varyings vert(Attributes IN)
            {
                Varyings OUT;
                float3 posWS = TransformObjectToWorld(IN.positionOS); // src 768-770 (ECS objectToWorld)
                #if defined(_WATERPROXY_HAS_VP)
                OUT.positionCS = mul(_WaterProxyViewProjMatrix, float4(posWS, 1.0)); // src 771-774 (1:1)
                #else
                OUT.positionCS = TransformWorldToHClip(posWS); // fallback (see TODO above)
                #endif
                return OUT;
            }

            // src frag lines 799-806: empty body (depth-only).
            void frag(Varyings IN) {}
            ENDHLSL
        }

        // ======================================================================
        // Pass 5 — WaterTessellation : water-VT displaced surface gbuffer (additive over surface targets).
        // src lines 812-950. Blend 2 SrcColor OneMinusSrcColor ; Stencil Ref 3 Comp Always Pass Replace.
        // Base bodies: Sub0_Pass4_Vertex_b20 (vertex) + Sub0_Pass4_Fragment_b21 (fragment).
        // ----------------------------------------------------------------------
        // CLOSED (math 1:1) + ENGINE-SIDE (resource binding only): the full vertex clipmap-morph/displacement (b20 lines
        //   122-276) and fragment displacement+normal-reconstruction+coverage (b21 lines 58-249) are now materialized
        //   verbatim-faithful below under `#ifdef _WATER_VT_AVAILABLE` (was a stub; the math is ported, OFF by default).
        //   The ONLY remaining gap is host resource binding — these are produced by the HG water-VT subsystem, NOT a
        //   material texture or formula, so they are legitimately engine-side:
        //   - `_WaterData_WaterLODViewProjMatrix[1298]` (b21:25): a host-C#-FILLED cbuffer array doubling as per-LOD
        //     view-proj matrices AND per-water-object parameter rows [base + objId*20 + field] (b21:64-72,81-104,240).
        //     Filled each frame by the water LOD/clipmap C# system — a GPU-sim-style buffer, the named engine-side case.
        //   - `_WaterDisplacementVT` (Texture2DArray, b21:28 T0): displacement/flow VT atlas baked by a SEPARATE water-sim
        //     pass; `_WaterClipmapHeightVT`/`_WaterClipmapNormalVT` (T1/T2, b21:29-30): clipmap height + far-normal VTs.
        //   - `_VFXParams0`/`_GlobalMipBias` (b21:20,19): HG globals.
        //   To render: have the host bind these + enable _WATER_VT_AVAILABLE. The #else keeps the compilable neutral stub.
        //   Per blobs Sub0_Pass4_Vertex_b20 (lines 122-276) + Sub0_Pass4_Fragment_b21 (lines 58-249). NOT silently faked.
        // ======================================================================
        Pass {
            Name "WaterTessellation"
            Tags { "LightMode" = "WaterTessellation" }
            Blend 2 SrcColor OneMinusSrcColor
            ZClip On
            Stencil {
                Ref 3
                Comp Always
                Pass Replace
                Fail Keep
                ZFail Keep
            }

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local HG_WATER_DESKTOP_QUALITY_LOW
            #pragma shader_feature_local ENABLE_WATER_RIPPLE
            #pragma shader_feature_local ENABLE_RAIN
            #pragma shader_feature_local HG_ENABLE_MV
            #pragma shader_feature_local _WATER_VT_AVAILABLE

            struct Attributes { float2 uv : TEXCOORD0; };
            struct Varyings {
                float4 positionCS : SV_POSITION;
                float3 worldPos   : TEXCOORD1; // src TEXCOORD_1
                float2 mask       : TEXCOORD2; // src TEXCOORD_1_1
                float  coverage   : TEXCOORD0; // src TEXCOORD_3
                float3 normalWS   : TEXCOORD3; // src TEXCOORD_2
                float  objIdF     : TEXCOORD4; // src TEXCOORD_4 = asfloat(objId)
            };

            // VERTEX body 1:1 from Sub0_Pass4_Vertex_b20 lines 122-276 — clipmap grid-cell expansion + displacement-VT
            //   sampling generates the water surface mesh from _WaterData + the vertex clipmap VTs. Materialized verbatim-
            //   faithful under _WATER_VT_AVAILABLE. ENGINE-SIDE GAP: the HG water-VT subsystem must bind _WaterGridDescriptor
            //   (per-instance packed grid descriptor) + _WaterVtx*VT clipmap maps. The #else keeps the compilable stub.
            //   Instancing dropped (single draw) -> grid index 0, §2; _NonJitteredViewNoTransProjMatrix -> UNITY_MATRIX_VP
            //   (TAA jitter dropped). The water VP rows live in _WaterData[0..9].
            Varyings vert(Attributes IN)
            {
                Varyings OUT;
            #ifdef _WATER_VT_AVAILABLE
                uint instId = 0u; // b20:124 (gl_InstanceIndex - gl_BaseInstanceARB); ECS instancing dropped -> 0
                // b20:125-131 unpack the grid-cell descriptor (8-bit fields) for this vertex's instance
                uint desc = _WaterGridDescriptor.Load(instId * 4u + 0u); // b20:127,128,130 T0.Load<uint>
                uint cellHi = (desc >> 16u) & 255u;                       // b20:127 spvBitfieldUExtract(.,16,8)
                float cellX = float((desc >> 8u) & 255u);                 // b20:128 spvBitfieldUExtract(.,8,8)
                float cellHiF = float(cellHi);                            // b20:129
                float cellY = float(desc & 255u);                        // b20:130
                uint half0 = uint(_WaterData_WaterLODViewProjMatrix[8u].z) >> 1u; // b20:131
                float negHalf = (-0.0) - float(half0); // b20:132
                float gx = mad((negHalf + cellX) + IN.uv.x, cellHiF, floor(_WaterData_WaterLODViewProjMatrix[8u].x)); // b20:133
                float gy = mad((negHalf + cellY) + IN.uv.y, cellHiF, floor(_WaterData_WaterLODViewProjMatrix[8u].y)); // b20:134
                float cellMaxF = float(max((cellHi * half0), 2u)); // b20:135
                float cellRange = max(((-0.0) - cellHiF) + cellMaxF, 0.0); // b20:136
                float invStep = cellHiF * 0.0625; // b20:137 (1/16)
                float lx = gx + ((-0.0) - _WaterData_WaterLODViewProjMatrix[8u].x); // b20:138
                float ly = gy + ((-0.0) - _WaterData_WaterLODViewProjMatrix[8u].y); // b20:139
                float morph = clamp(max(((-0.0) - cellRange) + sqrt(dot(float2(lx, ly), float2(lx, ly))), 0.0) / (((-0.0) - cellRange) + cellMaxF), 0.0, 1.0); // b20:140
                float mgx = mad(invStep * (((((-0.0) - frac(mad(cellX, 16.0, IN.uv.x * 16.0) * 0.25)) + 0.5) * frac(mad(cellX, 16.0, IN.uv.x * 16.0) * 0.5)) * 8.0), morph, gx); // b20:141
                float mgy = mad(invStep * (((((-0.0) - frac(mad(cellY, 16.0, IN.uv.y * 16.0) * 0.25)) + 0.5) * frac(mad(cellY, 16.0, IN.uv.y * 16.0) * 0.5)) * 8.0), morph, gy); // b20:142
                // b20:143-149 project grid pos through the water LOD VP (_WaterData[0..3]) into a height-map lookup UV
                float pX = mad(_WaterData_WaterLODViewProjMatrix[0u].x, mgx, mgy * _WaterData_WaterLODViewProjMatrix[2u].x) + _WaterData_WaterLODViewProjMatrix[3u].x; // b20:143
                float invW = 1.0 / (mad(_WaterData_WaterLODViewProjMatrix[0u].w, mgx, mgy * _WaterData_WaterLODViewProjMatrix[2u].w) + _WaterData_WaterLODViewProjMatrix[3u].w); // b20:144
                float pY = (-0.0) - (mad(_WaterData_WaterLODViewProjMatrix[0u].y, mgx, mgy * _WaterData_WaterLODViewProjMatrix[2u].y) + _WaterData_WaterLODViewProjMatrix[3u].y); // b20:145
                float ndcX = invW * pX; // b20:146
                float ndcY = invW * pY; // b20:147
                float uvHx = mad(ndcX, 0.5, 0.5); // b20:148
                float uvHy = mad(ndcY, 0.5, 0.5); // b20:149
                float height = SAMPLE_TEXTURE2D_LOD(_WaterVtxCoverageVT, sampler_LinearClamp, float2(uvHx, uvHy), 0.0).x; // b20:150 T4.SampleLevel

                float3 outWS = float3(0, 0, 0); // b20:152-154 (_598..600)
                uint outObj = 0u; // b20:155 (_601)
                OUT.normalWS = float3(0, 0, 0);
                OUT.worldPos = float3(0, 0, 0);
                // b20:156 cull test: any UV out of [0,1] OR zero coverage -> degenerate (NaN clip)
                bool inRange = !((uvHy > 1.0) || (uvHy < 0.0) || (uvHx > 1.0) || (uvHx < 0.0) || (height == 0.0));
                if (inRange)
                {
                    float4 hgt = SAMPLE_TEXTURE2D_LOD(_WaterVtxClipHeightVT, sampler_LinearClamp, float2(uvHx, uvHy), 0.0); // b20:158 T1
                    float hgtW = hgt.w; // b20:159
                    float4 nrm = SAMPLE_TEXTURE2D_LOD(_WaterVtxClipNormalVT, sampler_LinearRepeat, float2(uvHx, uvHy), 0.0); // b20:160 T2 (LinearRepeat -> URP Core sampler)
                    float ndcX2 = mad(uvHx, 2.0, -1.0); // b20:161
                    float ndcY2 = (-0.0) - mad(uvHy, 2.0, -1.0); // b20:162
                    // b20:163-166 unproject height field through water VP rows [4..7] -> world pos
                    float uw = mad(_WaterData_WaterLODViewProjMatrix[6u].w, height, mad(_WaterData_WaterLODViewProjMatrix[4u].w, ndcX2, ndcY2 * _WaterData_WaterLODViewProjMatrix[5u].w)) + _WaterData_WaterLODViewProjMatrix[7u].w; // b20:163
                    float wpx = (mad(_WaterData_WaterLODViewProjMatrix[6u].x, height, mad(_WaterData_WaterLODViewProjMatrix[4u].x, ndcX2, ndcY2 * _WaterData_WaterLODViewProjMatrix[5u].x)) + _WaterData_WaterLODViewProjMatrix[7u].x) / uw; // b20:164
                    float wpy = (mad(_WaterData_WaterLODViewProjMatrix[6u].y, height, mad(_WaterData_WaterLODViewProjMatrix[4u].y, ndcX2, ndcY2 * _WaterData_WaterLODViewProjMatrix[5u].y)) + _WaterData_WaterLODViewProjMatrix[7u].y) / uw; // b20:165
                    float wpz = (mad(_WaterData_WaterLODViewProjMatrix[6u].z, height, mad(_WaterData_WaterLODViewProjMatrix[4u].z, ndcX2, ndcY2 * _WaterData_WaterLODViewProjMatrix[5u].z)) + _WaterData_WaterLODViewProjMatrix[7u].z) / uw; // b20:166
                    float camX = wpx + ((-0.0) - _WorldSpaceCameraPos.x); // b20:167
                    float camZ = wpz + ((-0.0) - _WorldSpaceCameraPos.z); // b20:168
                    float fade = mad((-0.0) - max(clamp(sqrt(dot(float2(camX, camZ), float2(camX, camZ))) / _WaterData_WaterLODViewProjMatrix[9u].y, 0.0, 1.0) + (-0.800000011920928955078125), 0.0), 5.0, 1.0); // b20:169
                    float foam = fade * SAMPLE_TEXTURE2D_LOD(_WaterVtxFoamVT, sampler_LinearRepeat, float2(uvHx, uvHy), 0.0).x; // b20:170 T3
                    float on0 = mad(nrm.x, 2.0, -1.0); // b20:171
                    float on1 = mad(nrm.y, 2.0, -1.0); // b20:172
                    float ont = ((-0.0) - dot(1.0.xx, float2(abs(on0), abs(on1)))) + 1.0; // b20:173
                    bool onLower = ont < 0.0; // b20:174
                    float dn0 = onLower ? (((on0 >= 0.0) ? 1.0 : -1.0) * (((-0.0) - abs(on1)) + 1.0)) : on0; // b20:175
                    float dn1 = onLower ? (((on1 >= 0.0) ? 1.0 : -1.0) * (((-0.0) - abs(on0)) + 1.0)) : on1; // b20:176
                    float onInv = rsqrt(dot(float3(dn0, ont, dn1), float3(dn0, ont, dn1))); // b20:177
                    float dnx = onInv * dn0; // b20:178
                    float dny = onInv * ont; // b20:179
                    float dnz = onInv * dn1; // b20:180
                    // b20:181-188 neighbor UVs (+texel) for finite-difference normal refinement
                    float u01 = mad(invW * pX, 0.5, 0.5009765625); // b20:181 (+1/1024 offset)
                    float v01 = mad(invW * pY, 0.5, 0.5);          // b20:182
                    float u10 = mad(ndcX, 0.5, 0.5);               // b20:183
                    float v10 = mad(ndcY, 0.5, 0.5009765625);      // b20:184
                    float hU = SAMPLE_TEXTURE2D_LOD(_WaterVtxCoverageVT, sampler_LinearClamp, float2(u01, v01), 0.0).x; // b20:185 T4
                    float hV = SAMPLE_TEXTURE2D_LOD(_WaterVtxCoverageVT, sampler_LinearClamp, float2(u10, v10), 0.0).x; // b20:187 T4
                    if (((0.0 < hV) && (0.0 < hU) && (1.0 >= v10) && (v10 >= 0.0) && (1.0 >= u01) && (u01 >= 0.0))) // b20:189
                    {
                        float nu0 = mad(u01, 2.0, -1.0); // b20:191
                        float nu1 = mad(u10, 2.0, -1.0); // b20:192
                        float nv0 = (-0.0) - mad(v01, 2.0, -1.0); // b20:193
                        float wuw = mad(_WaterData_WaterLODViewProjMatrix[6u].w, hU, mad(_WaterData_WaterLODViewProjMatrix[4u].w, nu0, nv0 * _WaterData_WaterLODViewProjMatrix[5u].w)) + _WaterData_WaterLODViewProjMatrix[7u].w; // b20:194
                        float nv1 = (-0.0) - mad(v10, 2.0, -1.0); // b20:195
                        float wvw = mad(_WaterData_WaterLODViewProjMatrix[6u].w, hV, mad(_WaterData_WaterLODViewProjMatrix[4u].w, nu1, nv1 * _WaterData_WaterLODViewProjMatrix[5u].w)) + _WaterData_WaterLODViewProjMatrix[7u].w; // b20:196
                        uint iN = ((uint(int(hgtW * 255.0)) * 20u) + 25u) + 10u; // b20:197
                        float dispScale = _WaterData_WaterLODViewProjMatrix[iN].x; // b20:198
                        float sx = dny * dispScale; // b20:198
                        float sz = dnz * dispScale; // b20:199
                        float sy = dnx * dispScale; // b20:200
                        float bX = mad(sx, foam, wpy); // b20:201
                        float bY = mad(sz, foam, wpz); // b20:202
                        float bZ = mad(sy, foam, wpx); // b20:203
                        float foamU = fade * SAMPLE_TEXTURE2D_LOD(_WaterVtxFoamVT, sampler_LinearRepeat, float2(u01, v01), 0.0).x; // b20:204 T3
                        float eU0 = ((-0.0) - bY) + mad(sz, foamU, (mad(_WaterData_WaterLODViewProjMatrix[6u].z, hU, mad(_WaterData_WaterLODViewProjMatrix[4u].z, nu0, nv0 * _WaterData_WaterLODViewProjMatrix[5u].z)) + _WaterData_WaterLODViewProjMatrix[7u].z) / wuw); // b20:205
                        float eU1 = ((-0.0) - bZ) + mad(sy, foamU, (mad(_WaterData_WaterLODViewProjMatrix[6u].x, hU, mad(_WaterData_WaterLODViewProjMatrix[4u].x, nu0, nv0 * _WaterData_WaterLODViewProjMatrix[5u].x)) + _WaterData_WaterLODViewProjMatrix[7u].x) / wuw); // b20:206
                        float eU2 = ((-0.0) - bX) + mad(sx, foamU, (mad(_WaterData_WaterLODViewProjMatrix[6u].y, hU, mad(_WaterData_WaterLODViewProjMatrix[4u].y, nu0, nv0 * _WaterData_WaterLODViewProjMatrix[5u].y)) + _WaterData_WaterLODViewProjMatrix[7u].y) / wuw); // b20:207
                        float eUInv = rsqrt(dot(float3(eU0, eU1, eU2), float3(eU0, eU1, eU2))); // b20:208
                        float tuX = eUInv * eU0; // b20:209
                        float tuY = eUInv * eU1; // b20:210
                        float tuZ = eUInv * eU2; // b20:211
                        float foamV = fade * SAMPLE_TEXTURE2D_LOD(_WaterVtxFoamVT, sampler_LinearRepeat, float2(u10, v10), 0.0).x; // b20:212 T3
                        float eV0 = ((-0.0) - bZ) + mad(sy, foamV, (mad(_WaterData_WaterLODViewProjMatrix[6u].y, hV, mad(_WaterData_WaterLODViewProjMatrix[4u].y, nu1, nv1 * _WaterData_WaterLODViewProjMatrix[5u].y)) + _WaterData_WaterLODViewProjMatrix[7u].y) / wvw); // b20:213
                        float eV1 = ((-0.0) - bY) + mad(sz, foamV, (mad(_WaterData_WaterLODViewProjMatrix[6u].z, hV, mad(_WaterData_WaterLODViewProjMatrix[4u].z, nu1, nv1 * _WaterData_WaterLODViewProjMatrix[5u].z)) + _WaterData_WaterLODViewProjMatrix[7u].z) / wvw); // b20:214
                        float eV2 = ((-0.0) - bX) + mad(sx, foamV, (mad(_WaterData_WaterLODViewProjMatrix[6u].x, hV, mad(_WaterData_WaterLODViewProjMatrix[4u].x, nu1, nv1 * _WaterData_WaterLODViewProjMatrix[5u].x)) + _WaterData_WaterLODViewProjMatrix[7u].x) / wvw); // b20:215
                        float eVInv = rsqrt(dot(float3(eV0, eV1, eV2), float3(eV0, eV1, eV2))); // b20:216
                        float tvX = eVInv * eV0; // b20:217
                        float tvY = eVInv * eV1; // b20:218
                        float tvZ = eVInv * eV2; // b20:219
                        float cX = mad(tuZ, tvY, (-0.0) - (tvX * tuX)); // b20:220
                        float cY = mad(tuX, tvZ, (-0.0) - (tvY * tuY)); // b20:221
                        float cZ = mad(tuY, tvX, (-0.0) - (tvZ * tuZ)); // b20:222
                        float cLen2 = dot(float3(cX, cY, cZ), float3(cX, cY, cZ)); // b20:223
                        float cInv = rsqrt(max(cLen2, 1.0000000133514319600180897396058e-10)); // b20:224
                        float wgt = ((cLen2 >= 1.0000000133514319600180897396058e-10) ? 1.0 : 0.0) * clamp(foam, 0.0, 1.0); // b20:225
                        OUT.normalWS.x = mad(wgt, mad((-0.0) - cX, cInv, (-0.0) - dnx), dnx); // b20:226
                        OUT.normalWS.y = mad(wgt, mad((-0.0) - cY, cInv, (-0.0) - dny), dny); // b20:227
                        OUT.normalWS.z = mad(wgt, mad((-0.0) - cZ, cInv, (-0.0) - dnz), dnz); // b20:228
                    }
                    else
                    {
                        OUT.normalWS.x = dnx; // b20:232
                        OUT.normalWS.y = dny; // b20:233
                        OUT.normalWS.z = dnz; // b20:234
                    }
                    // b20:236-238 displaced world position (height + foam * normal)
                    float fX = mad(dnx, foam, wpx); // b20:236
                    float fY = mad(dny, foam, wpy); // b20:237
                    float fZ = mad(dnz, foam, wpz); // b20:238
                    float rX = fX + ((-0.0) - _WorldSpaceCameraPos.x); // b20:239
                    float rY = fY + ((-0.0) - _WorldSpaceCameraPos.y); // b20:240
                    float rZ = fZ + ((-0.0) - _WorldSpaceCameraPos.z); // b20:241
                    // b20:242-246 clip via VP (TAA jitter dropped -> UNITY_MATRIX_VP on camera-relative pos + camera pos)
                    OUT.positionCS = mul(UNITY_MATRIX_VP, float4(fX, fY, fZ, 1.0));
                    OUT.worldPos = float3(fX, fY, fZ); // b20:247-249 (TEXCOORD_1)
                    outWS = float3(uvHx, uvHy, nrm.z); // b20:250-252 packs (_600=u, _598=v, _599=nrm.z)
                    outObj = asuint(hgtW); // b20:253
                    OUT.mask = float2(uvHx, uvHy); // b20:272-273 (TEXCOORD_1_1 = (_600,_598))
                    OUT.coverage = nrm.z; // b20:274 (TEXCOORD_3 = _599)
                }
                else
                {
                    OUT.positionCS = float4(asfloat(0x7fc00000u), asfloat(0x7fc00000u), asfloat(0x7fc00000u), asfloat(0x7fc00000u)); // b20:257-260 NaN degenerate clip
                    OUT.worldPos = float3(0, 0, 0); // b20:261-263
                    OUT.normalWS = float3(0, 0, 0); // b20:264-266
                    OUT.mask = float2(0, 0); // b20:272-273 (_600=_598=0)
                    OUT.coverage = 0.0; // b20:274 (_599=0)
                }
                OUT.objIdF = asfloat(outObj); // b20:275 (TEXCOORD_4 = asfloat(_601))
            #else
                OUT.positionCS = float4(0, 0, 0, 1);
                OUT.worldPos = 0;
                OUT.mask = IN.uv;
                OUT.coverage = 0;
                OUT.normalWS = float3(0, 1, 0);
                OUT.objIdF = asfloat((uint)0);
            #endif
                return OUT;
            }

            // FRAGMENT body 1:1 from Sub0_Pass4_Fragment_b21 lines 58-249 — water-VT displacement + normal reconstruction +
            //   coverage into 3 MRTs. Materialized verbatim-faithful under _WATER_VT_AVAILABLE (reads _WaterData clipmap
            //   array + displacement/clipmap VTs). ENGINE-SIDE GAP: the HG water-VT subsystem must bind those resources
            //   (host C# fills _WaterData; the displacement/clipmap atlases are baked by separate water-sim passes). The
            //   #else keeps the compilable neutral-additive stub. SSA temps re-derived into named locals; _ViewMatrix[i].z
            //   -> UNITY_MATRIX_V._mN2 (camera basis Z, STYLE_BIBLE §2), _unity_OrthoParams -> unity_OrthoParams.
            void frag(Varyings IN,
                      out float4 outT0 : SV_Target0,
                      out float4 outT1 : SV_Target1,
                      out float4 outT2 : SV_Target2)
            {
            #ifdef _WATER_VT_AVAILABLE
                float3 posWS = IN.worldPos;   // b21 TEXCOORD
                float3 nWS   = IN.normalWS;   // b21 TEXCOORD_2
                float  cov   = IN.coverage;   // b21 TEXCOORD_3
                float  objIdF = IN.objIdF;    // b21 TEXCOORD_4

                // b21:60-63 normalize surface normal
                float invLenN = rsqrt(dot(nWS, nWS));
                float nx = invLenN * nWS.x;
                float ny = invLenN * nWS.y;
                float nz = invLenN * nWS.z;
                // b21:64-72 per-water-object parameter base addresses (stride 20, +13..+24)
                uint objId = uint(int(objIdF * 255.0)); // b21:64
                uint i13 = (objId * 20u) + 13u;
                uint i14 = (objId * 20u) + 14u;
                uint i15 = (objId * 20u) + 15u;
                uint i16 = (objId * 20u) + 16u;
                uint i17 = (objId * 20u) + 17u;
                uint i18 = (objId * 20u) + 18u;
                uint i23 = (objId * 20u) + 23u;
                uint i24 = (objId * 20u) + 24u;
                // b21:73-80 view direction (ortho -> camera Z basis, persp -> cam-to-frag), N·V
                bool isPersp = (0.0 == unity_OrthoParams.w); // b21:73
                float vdx = isPersp ? (((-0.0) - posWS.x) + _WorldSpaceCameraPos.x) : UNITY_MATRIX_V._m20; // b21:74
                float vdy = isPersp ? (((-0.0) - posWS.y) + _WorldSpaceCameraPos.y) : UNITY_MATRIX_V._m21; // b21:75
                float vdz = isPersp ? (((-0.0) - posWS.z) + _WorldSpaceCameraPos.z) : UNITY_MATRIX_V._m22; // b21:76
                float vLen2 = dot(float3(vdx, vdy, vdz), float3(vdx, vdy, vdz)); // b21:77
                float vInv  = rsqrt(max(vLen2, 9.9999999392252902907785028219223e-09)); // b21:78
                float vMag  = vInv * vLen2; // b21:79 (== length)
                float NdotV = dot(float3(vInv * vdx, vInv * vdy, vInv * vdz), float3(nx, ny, nz)); // b21:80
                // b21:81 grazing coverage term
                float graze = ((-0.0) - clamp((clamp(((-0.0) - NdotV) + 1.0, 0.0, 1.0) * vMag) / _WaterData_WaterLODViewProjMatrix[((objId * 20u) + 19u) + 10u].y, 0.0, 1.0)) + 1.0;
                // b21:82-94 clipmap-space coords + clipmap height (T1) / far-normal (T2) virtual-texture samples
                float cx = posWS.x + ((-0.0) - _WaterData_WaterLODViewProjMatrix[9u].z); // b21:82
                float cz = posWS.z + ((-0.0) - _WaterData_WaterLODViewProjMatrix[9u].w); // b21:83
                float dx = cx + ((-0.0) - _WaterData_WaterLODViewProjMatrix[11u].z); // b21:84
                float dz = cz + ((-0.0) - _WaterData_WaterLODViewProjMatrix[11u].w); // b21:85
                float hx = mad(dx, 0.00260416674427688121795654296875, -0.5); // b21:86 (1/384)
                float hz = mad(dz, 0.00260416674427688121795654296875, -0.5); // b21:87
                float4 clipH = SAMPLE_TEXTURE2D_LOD(_WaterClipmapHeightVT, sampler_LinearClamp, float2(mad(dx, 0.00260416674427688121795654296875, _WaterData_WaterLODViewProjMatrix[11u].x), mad(dz, 0.00260416674427688121795654296875, _WaterData_WaterLODViewProjMatrix[11u].y)), 0.0); // b21:88
                float ch0 = clipH.x, ch1 = clipH.y, ch2 = clipH.z, ch3 = clipH.w; // b21:89-92
                float far_v = (cz / _WaterData_WaterLODViewProjMatrix[13u].w) + 0.5; // b21:93
                float4 farN = SAMPLE_TEXTURE2D_LOD(_WaterClipmapNormalVT, sampler_LinearClamp, float2((cx / _WaterData_WaterLODViewProjMatrix[13u].w) + 0.5, far_v), 0.0); // b21:94
                float fn0 = farN.x, fn1 = farN.y, fn2 = farN.z; // b21:95-97
                // b21:98-108 blend near clipmap vs far, decode tangent-space offset normal
                float blend = clamp((max(abs(hz) + abs(hz), abs(hx) + abs(hx)) + (-0.89999997615814208984375)) * 10.0, 0.0, 1.0); // b21:98
                float bn0 = mad(blend, ((-0.0) - ch0) + fn0, ch0); // b21:99
                float bn1 = mad(blend, ((-0.0) - ch1) + fn1, ch1); // b21:100
                float bn2 = mad(blend, ((-0.0) - ch2) + fn2, ch2); // b21:101
                float bnw = mad(_WaterData_WaterLODViewProjMatrix[i23 + 10u].x, mad(blend, ((-0.0) - ch3) + farN.w, ch3) + (-1.0), 1.0); // b21:102
                uint i23p = i23 + 10u; // b21:103
                float nrmBiasY = (-0.0) - _WaterData_WaterLODViewProjMatrix[i23p].y; // b21:104
                float nrmBiasZ = (-0.0) - _WaterData_WaterLODViewProjMatrix[i23p].z; // b21:105
                float oNx = mad(mad(_WaterData_WaterLODViewProjMatrix[i23p].x, bn0 + nrmBiasY, _WaterData_WaterLODViewProjMatrix[i23p].y), 2.0, -1.0) * 1.0; // b21:108
                float oNz = mad(mad(_WaterData_WaterLODViewProjMatrix[i23p].x, bn1 + nrmBiasZ, _WaterData_WaterLODViewProjMatrix[i23p].z), 2.0, -1.0) * (-1.0); // b21:109
                uint i16p = i16 + 10u; // b21:110
                float mipBlend = 0.5 + ((-0.0) - _WaterData_WaterLODViewProjMatrix[i16p].w); // b21:111
                bool useDispBranch = 0.0 >= _WaterData_WaterLODViewProjMatrix[i23 + 10u].x; // b21:112

                float c0 = 0.0, c1 = 0.0, c2 = 0.0, c3 = 0.0; // b21:113-116
                if (useDispBranch)
                {
                    float mipBias = mad(mipBlend, 10.0, _WaterVTGlobalMipBias); // b21:119
                    float scrollA = _WaterVTVFXParams0.w * _WaterData_WaterLODViewProjMatrix[i18 + 10u].y; // b21:121
                    float4 dispA = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaterDisplacementVT, sampler_LinearClamp, float2(mad((-0.0) - (oNx * _WaterData_WaterLODViewProjMatrix[i17 + 10u].w), scrollA, posWS.x) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].x, mad((-0.0) - (oNz * _WaterData_WaterLODViewProjMatrix[i17 + 10u].w), scrollA, posWS.z) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].x), asfloat(asuint(_WaterData_WaterLODViewProjMatrix[i24 + 10u]).z), mipBias); // b21:123
                    float dA0 = mad(dispA.x, 2.0, -1.0); // b21:124
                    float dA1 = mad(dispA.y, 2.0, -1.0); // b21:125
                    float wgt = NdotV * (bnw * (graze * _WaterData_WaterLODViewProjMatrix[i16 + 10u].x)); // b21:126
                    float scrollB = mad(_WaterVTVFXParams0.w, _WaterData_WaterLODViewProjMatrix[i13 + 10u].y, 0.5); // b21:129
                    float4 dispB = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaterDisplacementVT, sampler_LinearClamp, float2(mad((-0.0) - ((oNx * _WaterData_WaterLODViewProjMatrix[i13 + 10u].z) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].w), scrollB, posWS.x) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].y, mad((-0.0) - ((oNz * _WaterData_WaterLODViewProjMatrix[i13 + 10u].z) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].w), scrollB, posWS.z) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].y), asfloat(asuint(_WaterData_WaterLODViewProjMatrix[i24 + 10u]).w), mipBias); // b21:131
                    float dB0 = mad(dispB.x, 2.0, -1.0); // b21:132
                    float dB1 = mad(dispB.y, 2.0, -1.0); // b21:133
                    float dBz = max(sqrt(((-0.0) - min(dot(float2(dB0, dB1), float2(dB0, dB1)), 1.0)) + 1.0), 1.000000016862383526387164645044e-16); // b21:134
                    float ampB = (bnw * _WaterData_WaterLODViewProjMatrix[i15 + 10u].z) * max(graze, _WaterData_WaterLODViewProjMatrix[i14 + 10u].w); // b21:135
                    float bX = ampB * dB0; // b21:136
                    float bY = ampB * dB1; // b21:137
                    float aX = (wgt * dA0) + 0.0; // b21:138
                    float aY = (wgt * dA1) + 0.0; // b21:139
                    float aZ = max(sqrt(((-0.0) - min(dot(float2(dA0, dA1), float2(dA0, dA1)), 1.0)) + 1.0), 1.000000016862383526387164645044e-16) + 1.0; // b21:140
                    float dotAB = dot(float3(aX, aY, aZ), float3(bX * (-1.0), bY * (-1.0), dBz * 1.0)); // b21:141
                    float rX = mad((-0.0) - bX, -1.0, (dotAB * aX) / aZ); // b21:142
                    float rY = mad((-0.0) - bY, -1.0, (dotAB * aY) / aZ); // b21:143
                    float rZ = mad((-0.0) - dBz, 1.0, dotAB); // b21:144
                    float rInv = rsqrt(dot(float3(rX, rY, rZ), float3(rX, rY, rZ))); // b21:145
                    float rnx = rInv * rX; // b21:146
                    float rny = rInv * rY; // b21:147
                    float rnz = rInv * rZ; // b21:148
                    c0 = clamp(dispA.w + ((-0.0) - _WaterData_WaterLODViewProjMatrix[i18 + 10u].w), 0.0, 1.0) * bn2; // b21:149
                    // b21:150-152 rotate offset normal into the surface tangent frame (built from nx/ny/nz)
                    c1 = mad(nx, rnz, mad(rnx, 1.0, rny * mad(nz, 0.0, (-0.0) - (ny * 0.0)))); // b21:150
                    c2 = mad(ny, rnz, mad(rnx, 0.0, rny * mad(nx, 0.0, (-0.0) - (nz * 1.0)))); // b21:151
                    c3 = mad(nz, rnz, mad(rnx, 0.0, rny * mad(ny, 1.0, (-0.0) - (nx * 0.0)))); // b21:152
                }
                else
                {
                    c0 = far_v; // b21:156
                    c1 = fn0;   // b21:157
                    c2 = fn1;   // b21:158
                    c3 = fn2;   // b21:159
                }

                float d0 = 0.0, d1 = 0.0, d2 = 0.0, d3 = 0.0; // b21:161-164
                if ((useDispBranch ? 4294967295u : 0u) == 0u) // b21:165 (i.e. NOT useDispBranch -> the tiled/quality path)
                {
                    uint i17q = i17 + 10u; // b21:167
                    float tX = oNx * _WaterData_WaterLODViewProjMatrix[i17q].w; // b21:168
                    float tZ = oNz * _WaterData_WaterLODViewProjMatrix[i17q].w; // b21:169
                    float fracA = mad(_WaterVTVFXParams0.w, _WaterData_WaterLODViewProjMatrix[i18 + 10u].y, (-0.0) - floor(_WaterVTVFXParams0.w * _WaterData_WaterLODViewProjMatrix[i18 + 10u].y)); // b21:170
                    float halfV = mad(_WaterVTVFXParams0.w, _WaterData_WaterLODViewProjMatrix[i18 + 10u].y, 0.5); // b21:171
                    float fracB = halfV + ((-0.0) - floor(halfV)); // b21:172
                    float mipBias2 = mad(mipBlend, 10.0, _WaterVTGlobalMipBias); // b21:173
                    float ofsA = mad(_WaterVTVFXParams0.w, _WaterData_WaterLODViewProjMatrix[i18 + 10u].y, (-0.0) - fracA) * _WaterData_WaterLODViewProjMatrix[i18 + 10u].y; // b21:174
                    float4 tA = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaterDisplacementVT, sampler_LinearClamp, float2(mad(mad((-0.0) - tX, fracA, posWS.x), _WaterData_WaterLODViewProjMatrix[i15 + 10u].x, ofsA), mad(mad((-0.0) - tZ, fracA, posWS.z), _WaterData_WaterLODViewProjMatrix[i15 + 10u].x, ofsA)), asfloat(asuint(_WaterData_WaterLODViewProjMatrix[i24 + 10u]).z), mipBias2); // b21:176
                    float ofsB = mad(_WaterVTVFXParams0.w, _WaterData_WaterLODViewProjMatrix[i18 + 10u].y, (-0.0) - fracB); // b21:178
                    float4 tB = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaterDisplacementVT, sampler_LinearClamp, float2(mad(ofsB, _WaterData_WaterLODViewProjMatrix[i18 + 10u].y, mad(mad((-0.0) - tX, fracB, posWS.x), _WaterData_WaterLODViewProjMatrix[i15 + 10u].x, 0.5)), mad(ofsB, _WaterData_WaterLODViewProjMatrix[i18 + 10u].y, mad(mad((-0.0) - tZ, fracB, posWS.z), _WaterData_WaterLODViewProjMatrix[i15 + 10u].x, 0.5))), asfloat(asuint(_WaterData_WaterLODViewProjMatrix[i24 + 10u]).z), mipBias2); // b21:180
                    float wA = ((-0.0) - abs(mad((-0.0) - fracA, 2.0, 1.0))) + 1.0; // b21:181
                    float wB = ((-0.0) - abs(mad((-0.0) - fracB, 2.0, 1.0))) + 1.0; // b21:182
                    float halfC = mad(_WaterVTVFXParams0.w, _WaterData_WaterLODViewProjMatrix[i13 + 10u].y, 0.5); // b21:184
                    float halfD = mad(_WaterVTVFXParams0.w, _WaterData_WaterLODViewProjMatrix[i13 + 10u].y, 1.0); // b21:185
                    float fracC = halfC + ((-0.0) - floor(halfC)); // b21:188
                    float fracD = halfD + ((-0.0) - floor(halfD)); // b21:189
                    float tnX = mad(mad(tA.x, wA, wB * tB.x), 2.0, -1.0); // b21:190
                    float tnY = mad(mad(tA.y, wA, wB * tB.y), 2.0, -1.0); // b21:191
                    float wgt2 = NdotV * (bnw * (graze * _WaterData_WaterLODViewProjMatrix[i16 + 10u].x)); // b21:192
                    float dCD = fracC + ((-0.0) - fracD); // b21:193
                    float ofsC = (fracC + ((-0.0) - fracC)) * _WaterData_WaterLODViewProjMatrix[i13 + 10u].y; // b21:194
                    float4 tC = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaterDisplacementVT, sampler_LinearClamp, float2(mad(mad((-0.0) - (((mad(mad(_WaterData_WaterLODViewProjMatrix[i23p].x, bn0 + nrmBiasY, _WaterData_WaterLODViewProjMatrix[i23p].y), 2.0, -1.0) * 1.0) * _WaterData_WaterLODViewProjMatrix[i13 + 10u].z) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].w), fracC, posWS.x), _WaterData_WaterLODViewProjMatrix[i15 + 10u].y, ofsC), mad(mad((-0.0) - (((mad(mad(_WaterData_WaterLODViewProjMatrix[i23p].x, bn1 + nrmBiasZ, _WaterData_WaterLODViewProjMatrix[i23p].z), 2.0, -1.0) * (-1.0)) * _WaterData_WaterLODViewProjMatrix[i13 + 10u].z) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].w), fracC, posWS.z), _WaterData_WaterLODViewProjMatrix[i15 + 10u].y, ofsC)), asfloat(asuint(_WaterData_WaterLODViewProjMatrix[i24 + 10u]).w), mipBias2); // b21:196
                    float wC = ((-0.0) - abs(mad((-0.0) - fracC, 2.0, 1.0))) + 1.0; // b21:197
                    float wD = ((-0.0) - abs(mad((-0.0) - fracD, 2.0, 1.0))) + 1.0; // b21:198
                    float4 tD = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaterDisplacementVT, sampler_LinearClamp, float2(mad(dCD, _WaterData_WaterLODViewProjMatrix[i13 + 10u].y, mad(mad((-0.0) - ((oNx * _WaterData_WaterLODViewProjMatrix[i13 + 10u].z) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].w), fracD, posWS.x), _WaterData_WaterLODViewProjMatrix[i15 + 10u].y, 0.5)), mad(dCD, _WaterData_WaterLODViewProjMatrix[i13 + 10u].y, mad(mad((-0.0) - ((oNz * _WaterData_WaterLODViewProjMatrix[i13 + 10u].z) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].w), fracD, posWS.z), _WaterData_WaterLODViewProjMatrix[i15 + 10u].y, 0.5))), asfloat(asuint(_WaterData_WaterLODViewProjMatrix[i24 + 10u]).w), mipBias2); // b21:201
                    float tnX2 = mad(mad(tC.x, wC, wD * tD.x), 2.0, -1.0); // b21:202
                    float tnY2 = mad(mad(tC.y, wC, wD * tD.y), 2.0, -1.0); // b21:203
                    float tnZ2 = max(sqrt(((-0.0) - min(dot(float2(tnX2, tnY2), float2(tnX2, tnY2)), 1.0)) + 1.0), 1.000000016862383526387164645044e-16); // b21:204
                    float ampD = max(graze, _WaterData_WaterLODViewProjMatrix[i14 + 10u].w) * (bnw * _WaterData_WaterLODViewProjMatrix[i15 + 10u].z); // b21:205
                    float dX = ampD * tnX2; // b21:206
                    float dY = ampD * tnY2; // b21:207
                    float eX = (wgt2 * tnX) + 0.0; // b21:208
                    float eY = (wgt2 * tnY) + 0.0; // b21:209
                    float eZ = max(sqrt(((-0.0) - min(dot(float2(tnX, tnY), float2(tnX, tnY)), 1.0)) + 1.0), 1.000000016862383526387164645044e-16) + 1.0; // b21:210
                    float dotDE = dot(float3(eX, eY, eZ), float3(dX * (-1.0), dY * (-1.0), tnZ2 * 1.0)); // b21:211
                    float qX = mad((-0.0) - dX, -1.0, (eX * dotDE) / eZ); // b21:212
                    float qY = mad((-0.0) - dY, -1.0, (eY * dotDE) / eZ); // b21:213
                    float qZ = mad((-0.0) - tnZ2, 1.0, dotDE); // b21:214
                    float qInv = rsqrt(dot(float3(qX, qY, qZ), float3(qX, qY, qZ))); // b21:215
                    float qnx = qX * qInv; // b21:216
                    float qny = qY * qInv; // b21:217
                    float qnz = qZ * qInv; // b21:218
                    d0 = clamp(mad(tA.w, wA, wB * tB.w) + ((-0.0) - _WaterData_WaterLODViewProjMatrix[i18 + 10u].w), 0.0, 1.0) * bn2; // b21:219
                    d1 = mad(nx, qnz, mad(qnx, 1.0, qny * mad(nz, 0.0, (-0.0) - (ny * 0.0)))); // b21:220
                    d2 = mad(ny, qnz, mad(qnx, 0.0, qny * mad(nx, 0.0, (-0.0) - (nz * 1.0)))); // b21:221
                    d3 = mad(nz, qnz, mad(qnx, 0.0, qny * mad(ny, 1.0, (-0.0) - (nx * 0.0)))); // b21:222
                }
                else
                {
                    d0 = c0; // b21:226
                    d1 = c1; // b21:227
                    d2 = c2; // b21:228
                    d3 = c3; // b21:229
                }

                // b21:231 final coverage * tint scale
                float covScale = ((max(clamp(NdotV, 0.0, 1.0), 0.5) * (((-0.0) - clamp(vMag * _WaterData_WaterLODViewProjMatrix[((objId * 20u) + 20u) + 10u].w, 0.0, 1.0)) + 1.0)) * _WaterData_WaterLODViewProjMatrix[i18 + 10u].x) * d0;
                // b21:232-237 octahedral encode of reconstructed normal (d1,d2,d3) into SV_Target.xy
                float encDen = dot(1.0.xxx, float3(abs(d1), abs(d2), abs(d3))); // b21:232
                float encX = d1 / encDen; // b21:233
                float encZ = d3 / encDen; // b21:234
                bool encLower = 0.0 >= d2; // b21:235
                outT0.x = mad(encLower ? (((encX >= 0.0) ? 1.0 : -1.0) * (((-0.0) - abs(encZ)) + 1.0)) : encX, 0.5, 0.5); // b21:236
                outT0.y = mad(encLower ? (((encZ >= 0.0) ? 1.0 : -1.0) * (((-0.0) - abs(encX)) + 1.0)) : encZ, 0.5, 0.5); // b21:237
                // b21:238-239 SV_Target.z = coverage-modulated depth/roughness + TEXCOORD_3 bias
                float covBias = mad(graze, 0.00999999977648258209228515625 + ((-0.0) - _WaterData_WaterLODViewProjMatrix[i16p].y), _WaterData_WaterLODViewProjMatrix[i16 + 10u].y); // b21:238
                outT0.z = clamp(mad(covScale, ((-0.0) - covBias) + _WaterData_WaterLODViewProjMatrix[i18 + 10u].z, covBias) + cov, 0.0, 1.0); // b21:239
                outT0.w = 0.0; // b21:244
                // b21:240-243 SV_Target_1.xyz = covScale * per-object tint
                uint iTint = ((objId * 20u) + 10u) + 10u; // b21:240
                outT1.x = covScale * _WaterData_WaterLODViewProjMatrix[iTint].x; // b21:241
                outT1.y = covScale * _WaterData_WaterLODViewProjMatrix[iTint].y; // b21:242
                outT1.z = covScale * _WaterData_WaterLODViewProjMatrix[iTint].z; // b21:243
                outT1.w = objIdF; // b21:245 (SV_Target_1.w = TEXCOORD_4)
                outT2.x = 0.0; // b21:246
                outT2.y = 0.0; // b21:247
                outT2.z = 1.0; // b21:248
                outT2.w = mad(_WaterData_WaterLODViewProjMatrix[((objId * 20u) + 9u) + 10u].w, -0.2999999821186065673828125, 0.699999988079071044921875); // b21:249
            #else
                // ENGINE-SIDE: water-VT subsystem unbound. Neutral-additive output (Blend 2 SrcColor OneMinusSrcColor).
                outT0 = float4(0, 0, 0, 0);
                outT1 = float4(0, 0, 0, IN.objIdF);
                outT2 = float4(0, 0, 1, 0.699999988079071044921875); // src b21:248-249 (SV_Target_2.zw default = (1, 0.7))
            #endif
            }
            ENDHLSL
        }

        // ======================================================================
        // Pass 6 — WaterGBuffer : water surface gbuffer write (mesh proxy path, ECS-instanced).
        // src lines 951-1090. Blend 2 SrcColor OneMinusSrcColor ; Stencil Ref 3 WriteMask 1 Comp NotEqual Pass Replace.
        // Base bodies: Sub0_Pass5_Vertex_b60 (vertex) + Sub0_Pass5_Fragment_b61 (fragment).
        // ----------------------------------------------------------------------
        // CLOSED (math 1:1) + ENGINE-SIDE (resource binding only): The VERTEX (b60 lines 125-171) is portable on its own —
        //   object→world→clip + normal rotate — and is implemented faithfully below (the octahedral mesh-normal decode
        //   1/511 src 145-169 is unnecessary in URP per CORE_MATH §3.1; plain normalOS used). The FRAGMENT (b61 lines
        //   69-263, displacement + normal reconstruction + coverage into 3 MRTs) is now materialized verbatim-faithful
        //   below under `#ifdef _WATER_VT_AVAILABLE` (was a stub). The ONLY remaining gap is host resource binding, same
        //   engine-side resources as Pass 5: `_WaterData_WaterLODViewProjMatrix[1298]` ([objId*20+field], b61:78-85,95,244,
        //   253 — host-C#-filled clipmap/LOD buffer) + `_WaterDisplacementVT` (T0) + `_WaterClipmapHeight/NormalVT` (T1/T2)
        //   + `_VFXParams0`/`_GlobalMipBias`. Bind them + enable _WATER_VT_AVAILABLE to render; the #else keeps the faithful
        //   no-VT sub-slice. Per blobs Sub0_Pass5_Vertex_b60 + Sub0_Pass5_Fragment_b61. NOT silently faked.
        // ======================================================================
        Pass {
            Name "WaterGBuffer"
            Tags { "LightMode" = "WaterGBuffer" }
            Blend 2 SrcColor OneMinusSrcColor
            ZClip On
            Stencil {
                Ref 3
                WriteMask 1
                Comp NotEqual
                Pass Replace
                Fail Keep
                ZFail Keep
            }

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local HG_WATER_DESKTOP_QUALITY_LOW
            #pragma shader_feature_local ENABLE_WATER_RIPPLE
            #pragma shader_feature_local ENABLE_RAIN
            #pragma shader_feature_local HG_ENABLE_MV
            #pragma shader_feature_local _WATER_VT_AVAILABLE

            struct Attributes {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;   // src decodes octahedral NORMAL.x; URP feeds plain normalOS
                float2 uv         : TEXCOORD0;
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float3 worldPos   : TEXCOORD1; // src TEXCOORD_1
                float2 uv         : TEXCOORD2; // src TEXCOORD_1_1
                float3 normalWS   : TEXCOORD3; // src TEXCOORD_2
                nointerpolation uint objId : TEXCOORD4; // src TEXCOORD_3
            };

            // VERTEX 1:1 from Sub0_Pass5_Vertex_b60 lines 125-171:
            //   world pos via ECS objectToWorld (→ URP unity_ObjectToWorld), normal octahedral-decoded then world-rotated.
            //   For URP, the octahedral decode is unnecessary (Unity feeds standard normals, CORE_MATH §3.1) — we transform
            //   normalOS directly. The world-position + normalize(world normal, FLT_MIN floor) logic is faithful.
            Varyings vert(Attributes IN)
            {
                Varyings OUT;
                VertexPositionInputs posIn = GetVertexPositionInputs(IN.positionOS); // src 129-131,138-142
                OUT.positionCS = posIn.positionCS;
                OUT.worldPos = posIn.positionWS; // src 135-137 (TEXCOORD_1 = world pos)
                OUT.uv = IN.uv; // src 143-144

                float3 nWS = TransformObjectToWorldNormal(IN.normalOS); // src 163-165 (rotate by objectToWorld)
                float l2 = max(dot(nWS, nWS), 1.1754943508222875079687365372222e-38); // src 166 FLT_MIN floor
                OUT.normalWS = nWS * rsqrt(l2); // src 167-169
                OUT.objId = 0; // src 170 TEXCOORD_3 = instanceID; ECS instancing dropped → 0 (single draw)
                return OUT;
            }

            // FRAGMENT body 1:1 from Sub0_Pass5_Fragment_b61 lines 69-263 — same water-VT displacement + normal
            //   reconstruction + coverage as b21, with the mesh-proxy differences: objId from per-draw param0.x
            //   (-> material _WaterObjectId, ECS instancing dropped), SV_Target.w=1, SV_Target_1.w=(1/255)*param0.x,
            //   SV_Target.z without the wet-mask coverage bias. Materialized verbatim-faithful under _WATER_VT_AVAILABLE;
            //   ENGINE-SIDE GAP: HG water-VT subsystem binds _WaterData + the displacement/clipmap VTs. #else keeps the
            //   faithful no-VT sub-slice (octahedral encode of the interpolated surface normal + objId).
            void frag(Varyings IN,
                      out float4 outT0 : SV_Target0,
                      out float4 outT1 : SV_Target1,
                      out float4 outT2 : SV_Target2)
            {
            #ifdef _WATER_VT_AVAILABLE
                float3 posWS = IN.worldPos;  // b61 TEXCOORD
                float3 nWS   = IN.normalWS;  // b61 TEXCOORD_2
                float  param0x = _WaterObjectId; // b61:77 _ECSPerDraw_waterProxyArray[_54].param0.x -> material float

                float invLenN = rsqrt(dot(nWS, nWS)); // b61:72
                float nx = invLenN * nWS.x; // b61:73
                float ny = invLenN * nWS.y; // b61:74
                float nz = invLenN * nWS.z; // b61:75
                uint objId = uint(int(param0x)); // b61:77
                uint i13 = (objId * 20u) + 13u; // b61:78
                uint i14 = (objId * 20u) + 14u; // b61:79
                uint i15 = (objId * 20u) + 15u; // b61:80
                uint i16 = (objId * 20u) + 16u; // b61:81
                uint i17 = (objId * 20u) + 17u; // b61:82
                uint i18 = (objId * 20u) + 18u; // b61:83
                uint i23 = (objId * 20u) + 23u; // b61:84
                uint i24 = (objId * 20u) + 24u; // b61:85
                uint i19 = (objId * 20u) + 19u; // b61:94
                bool isPersp = (0.0 == unity_OrthoParams.w); // b61:86
                float vdx = isPersp ? (((-0.0) - posWS.x) + _WorldSpaceCameraPos.x) : UNITY_MATRIX_V._m20; // b61:87
                float vdy = isPersp ? (((-0.0) - posWS.y) + _WorldSpaceCameraPos.y) : UNITY_MATRIX_V._m21; // b61:88
                float vdz = isPersp ? (((-0.0) - posWS.z) + _WorldSpaceCameraPos.z) : UNITY_MATRIX_V._m22; // b61:89
                float vLen2 = dot(float3(vdx, vdy, vdz), float3(vdx, vdy, vdz)); // b61:90
                float vInv  = rsqrt(max(vLen2, 9.9999999392252902907785028219223e-09)); // b61:91
                float vMag  = vInv * vLen2; // b61:92
                float NdotV = dot(float3(vInv * vdx, vInv * vdy, vInv * vdz), float3(nx, ny, nz)); // b61:93
                float graze = ((-0.0) - clamp((clamp(((-0.0) - NdotV) + 1.0, 0.0, 1.0) * vMag) / _WaterData_WaterLODViewProjMatrix[i19 + 10u].y, 0.0, 1.0)) + 1.0; // b61:95
                float cx = posWS.x + ((-0.0) - _WaterData_WaterLODViewProjMatrix[9u].z); // b61:96
                float cz = posWS.z + ((-0.0) - _WaterData_WaterLODViewProjMatrix[9u].w); // b61:97
                float dx = cx + ((-0.0) - _WaterData_WaterLODViewProjMatrix[11u].z); // b61:98
                float dz = cz + ((-0.0) - _WaterData_WaterLODViewProjMatrix[11u].w); // b61:99
                float hx = mad(dx, 0.00260416674427688121795654296875, -0.5); // b61:100
                float hz = mad(dz, 0.00260416674427688121795654296875, -0.5); // b61:101
                float4 clipH = SAMPLE_TEXTURE2D_LOD(_WaterClipmapHeightVT, sampler_LinearClamp, float2(mad(dx, 0.00260416674427688121795654296875, _WaterData_WaterLODViewProjMatrix[11u].x), mad(dz, 0.00260416674427688121795654296875, _WaterData_WaterLODViewProjMatrix[11u].y)), 0.0); // b61:102
                float ch0 = clipH.x, ch1 = clipH.y, ch2 = clipH.z, ch3 = clipH.w; // b61:103-106
                float4 farN = SAMPLE_TEXTURE2D_LOD(_WaterClipmapNormalVT, sampler_LinearClamp, float2((cx / _WaterData_WaterLODViewProjMatrix[13u].w) + 0.5, (cz / _WaterData_WaterLODViewProjMatrix[13u].w) + 0.5), 0.0); // b61:107
                float fn0 = farN.x, fn1 = farN.y, fn2 = farN.z; // b61:108-110
                float blend = clamp((max(abs(hz) + abs(hz), abs(hx) + abs(hx)) + (-0.89999997615814208984375)) * 10.0, 0.0, 1.0); // b61:111
                float bn0 = mad(blend, ((-0.0) - ch0) + fn0, ch0); // b61:112
                float bn1 = mad(blend, ((-0.0) - ch1) + fn1, ch1); // b61:113
                float bn2 = mad(blend, ((-0.0) - ch2) + fn2, ch2); // b61:114
                float bnw = mad(_WaterData_WaterLODViewProjMatrix[i23 + 10u].x, mad(blend, ((-0.0) - ch3) + farN.w, ch3) + (-1.0), 1.0); // b61:115
                uint i23p = i23 + 10u; // b61:116
                float nrmBiasY = (-0.0) - _WaterData_WaterLODViewProjMatrix[i23p].y; // b61:117
                float nrmBiasZ = (-0.0) - _WaterData_WaterLODViewProjMatrix[i23p].z; // b61:118
                float oNx = mad(mad(_WaterData_WaterLODViewProjMatrix[i23p].x, bn0 + nrmBiasY, _WaterData_WaterLODViewProjMatrix[i23p].y), 2.0, -1.0) * 1.0; // b61:121
                float oNz = mad(mad(_WaterData_WaterLODViewProjMatrix[i23p].x, bn1 + nrmBiasZ, _WaterData_WaterLODViewProjMatrix[i23p].z), 2.0, -1.0) * (-1.0); // b61:122
                uint i16p = i16 + 10u; // b61:123
                float mipBlend = 0.5 + ((-0.0) - _WaterData_WaterLODViewProjMatrix[i16p].w); // b61:124
                bool useDispBranch = 0.0 >= _WaterData_WaterLODViewProjMatrix[i23 + 10u].x; // b61:125

                float c0 = 0.0, c1 = 0.0, c2 = 0.0, c3 = 0.0; // b61:126-129
                if (useDispBranch)
                {
                    float mipBias = mad(mipBlend, 10.0, _WaterVTGlobalMipBias); // b61:132
                    float scrollA = _WaterVTVFXParams0.w * _WaterData_WaterLODViewProjMatrix[i18 + 10u].y; // b61:134
                    float4 dispA = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaterDisplacementVT, sampler_LinearClamp, float2(mad((-0.0) - (oNx * _WaterData_WaterLODViewProjMatrix[i17 + 10u].w), scrollA, posWS.x) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].x, mad((-0.0) - (oNz * _WaterData_WaterLODViewProjMatrix[i17 + 10u].w), scrollA, posWS.z) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].x), asfloat(asuint(_WaterData_WaterLODViewProjMatrix[i24 + 10u]).z), mipBias); // b61:136
                    float dA0 = mad(dispA.x, 2.0, -1.0); // b61:137
                    float dA1 = mad(dispA.y, 2.0, -1.0); // b61:138
                    float wgt = NdotV * (bnw * (graze * _WaterData_WaterLODViewProjMatrix[i16 + 10u].x)); // b61:139
                    float scrollB = mad(_WaterVTVFXParams0.w, _WaterData_WaterLODViewProjMatrix[i13 + 10u].y, 0.5); // b61:142
                    float4 dispB = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaterDisplacementVT, sampler_LinearClamp, float2(mad((-0.0) - ((oNx * _WaterData_WaterLODViewProjMatrix[i13 + 10u].z) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].w), scrollB, posWS.x) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].y, mad((-0.0) - ((oNz * _WaterData_WaterLODViewProjMatrix[i13 + 10u].z) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].w), scrollB, posWS.z) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].y), asfloat(asuint(_WaterData_WaterLODViewProjMatrix[i24 + 10u]).w), mipBias); // b61:144
                    float dB0 = mad(dispB.x, 2.0, -1.0); // b61:145
                    float dB1 = mad(dispB.y, 2.0, -1.0); // b61:146
                    float dBz = max(sqrt(((-0.0) - min(dot(float2(dB0, dB1), float2(dB0, dB1)), 1.0)) + 1.0), 1.000000016862383526387164645044e-16); // b61:147
                    float ampB = (bnw * _WaterData_WaterLODViewProjMatrix[i15 + 10u].z) * max(graze, _WaterData_WaterLODViewProjMatrix[i14 + 10u].w); // b61:148
                    float bX = ampB * dB0; // b61:149
                    float bY = ampB * dB1; // b61:150
                    float aX = (wgt * dA0) + 0.0; // b61:151
                    float aY = (wgt * dA1) + 0.0; // b61:152
                    float aZ = max(sqrt(((-0.0) - min(dot(float2(dA0, dA1), float2(dA0, dA1)), 1.0)) + 1.0), 1.000000016862383526387164645044e-16) + 1.0; // b61:153
                    float dotAB = dot(float3(aX, aY, aZ), float3(bX * (-1.0), bY * (-1.0), dBz * 1.0)); // b61:154
                    float rX = mad((-0.0) - bX, -1.0, (dotAB * aX) / aZ); // b61:155
                    float rY = mad((-0.0) - bY, -1.0, (dotAB * aY) / aZ); // b61:156
                    float rZ = mad((-0.0) - dBz, 1.0, dotAB); // b61:157
                    float rInv = rsqrt(dot(float3(rX, rY, rZ), float3(rX, rY, rZ))); // b61:158
                    float rnx = rInv * rX; // b61:159
                    float rny = rInv * rY; // b61:160
                    float rnz = rInv * rZ; // b61:161
                    c0 = clamp(dispA.w + ((-0.0) - _WaterData_WaterLODViewProjMatrix[i18 + 10u].w), 0.0, 1.0) * bn2; // b61:162
                    c1 = mad(nx, rnz, mad(rnx, 1.0, rny * mad(nz, 0.0, (-0.0) - (ny * 0.0)))); // b61:163
                    c2 = mad(ny, rnz, mad(rnx, 0.0, rny * mad(nx, 0.0, (-0.0) - (nz * 1.0)))); // b61:164
                    c3 = mad(nz, rnz, mad(rnx, 0.0, rny * mad(ny, 1.0, (-0.0) - (nx * 0.0)))); // b61:165
                }
                else
                {
                    c0 = asfloat(i19); // b61:169 (asfloat((objId*20)+19) — bit-reinterpret, preserved 1:1)
                    c1 = fn0; // b61:170
                    c2 = fn1; // b61:171
                    c3 = fn2; // b61:172
                }

                float d0 = 0.0, d1 = 0.0, d2 = 0.0, d3 = 0.0; // b61:174-177
                if ((useDispBranch ? 4294967295u : 0u) == 0u) // b61:178
                {
                    uint i17q = i17 + 10u; // b61:180
                    float tX = oNx * _WaterData_WaterLODViewProjMatrix[i17q].w; // b61:181
                    float tZ = oNz * _WaterData_WaterLODViewProjMatrix[i17q].w; // b61:182
                    float fracA = mad(_WaterVTVFXParams0.w, _WaterData_WaterLODViewProjMatrix[i18 + 10u].y, (-0.0) - floor(_WaterVTVFXParams0.w * _WaterData_WaterLODViewProjMatrix[i18 + 10u].y)); // b61:183
                    float halfV = mad(_WaterVTVFXParams0.w, _WaterData_WaterLODViewProjMatrix[i18 + 10u].y, 0.5); // b61:184
                    float fracB = halfV + ((-0.0) - floor(halfV)); // b61:185
                    float mipBias2 = mad(mipBlend, 10.0, _WaterVTGlobalMipBias); // b61:186
                    float ofsA = mad(_WaterVTVFXParams0.w, _WaterData_WaterLODViewProjMatrix[i18 + 10u].y, (-0.0) - fracA) * _WaterData_WaterLODViewProjMatrix[i18 + 10u].y; // b61:187
                    float4 tA = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaterDisplacementVT, sampler_LinearClamp, float2(mad(mad((-0.0) - tX, fracA, posWS.x), _WaterData_WaterLODViewProjMatrix[i15 + 10u].x, ofsA), mad(mad((-0.0) - tZ, fracA, posWS.z), _WaterData_WaterLODViewProjMatrix[i15 + 10u].x, ofsA)), asfloat(asuint(_WaterData_WaterLODViewProjMatrix[i24 + 10u]).z), mipBias2); // b61:189
                    float ofsB = mad(_WaterVTVFXParams0.w, _WaterData_WaterLODViewProjMatrix[i18 + 10u].y, (-0.0) - fracB); // b61:191
                    float4 tB = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaterDisplacementVT, sampler_LinearClamp, float2(mad(ofsB, _WaterData_WaterLODViewProjMatrix[i18 + 10u].y, mad(mad((-0.0) - tX, fracB, posWS.x), _WaterData_WaterLODViewProjMatrix[i15 + 10u].x, 0.5)), mad(ofsB, _WaterData_WaterLODViewProjMatrix[i18 + 10u].y, mad(mad((-0.0) - tZ, fracB, posWS.z), _WaterData_WaterLODViewProjMatrix[i15 + 10u].x, 0.5))), asfloat(asuint(_WaterData_WaterLODViewProjMatrix[i24 + 10u]).z), mipBias2); // b61:193
                    float wA = ((-0.0) - abs(mad((-0.0) - fracA, 2.0, 1.0))) + 1.0; // b61:194
                    float wB = ((-0.0) - abs(mad((-0.0) - fracB, 2.0, 1.0))) + 1.0; // b61:195
                    float halfC = mad(_WaterVTVFXParams0.w, _WaterData_WaterLODViewProjMatrix[i13 + 10u].y, 0.5); // b61:197
                    float halfD = mad(_WaterVTVFXParams0.w, _WaterData_WaterLODViewProjMatrix[i13 + 10u].y, 1.0); // b61:198
                    float fracC = halfC + ((-0.0) - floor(halfC)); // b61:201
                    float fracD = halfD + ((-0.0) - floor(halfD)); // b61:202
                    float tnX = mad(mad(tA.x, wA, wB * tB.x), 2.0, -1.0); // b61:203
                    float tnY = mad(mad(tA.y, wA, wB * tB.y), 2.0, -1.0); // b61:204
                    float wgt2 = NdotV * (bnw * (graze * _WaterData_WaterLODViewProjMatrix[i16 + 10u].x)); // b61:205
                    float dCD = fracC + ((-0.0) - fracD); // b61:206
                    float ofsC = (fracC + ((-0.0) - fracC)) * _WaterData_WaterLODViewProjMatrix[i13 + 10u].y; // b61:207
                    float4 tC = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaterDisplacementVT, sampler_LinearClamp, float2(mad(mad((-0.0) - (((mad(mad(_WaterData_WaterLODViewProjMatrix[i23p].x, bn0 + nrmBiasY, _WaterData_WaterLODViewProjMatrix[i23p].y), 2.0, -1.0) * 1.0) * _WaterData_WaterLODViewProjMatrix[i13 + 10u].z) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].w), fracC, posWS.x), _WaterData_WaterLODViewProjMatrix[i15 + 10u].y, ofsC), mad(mad((-0.0) - (((mad(mad(_WaterData_WaterLODViewProjMatrix[i23p].x, bn1 + nrmBiasZ, _WaterData_WaterLODViewProjMatrix[i23p].z), 2.0, -1.0) * (-1.0)) * _WaterData_WaterLODViewProjMatrix[i13 + 10u].z) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].w), fracC, posWS.z), _WaterData_WaterLODViewProjMatrix[i15 + 10u].y, ofsC)), asfloat(asuint(_WaterData_WaterLODViewProjMatrix[i24 + 10u]).w), mipBias2); // b61:209
                    float wC = ((-0.0) - abs(mad((-0.0) - fracC, 2.0, 1.0))) + 1.0; // b61:210
                    float wD = ((-0.0) - abs(mad((-0.0) - fracD, 2.0, 1.0))) + 1.0; // b61:211
                    float4 tD = SAMPLE_TEXTURE2D_ARRAY_BIAS(_WaterDisplacementVT, sampler_LinearClamp, float2(mad(dCD, _WaterData_WaterLODViewProjMatrix[i13 + 10u].y, mad(mad((-0.0) - ((oNx * _WaterData_WaterLODViewProjMatrix[i13 + 10u].z) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].w), fracD, posWS.x), _WaterData_WaterLODViewProjMatrix[i15 + 10u].y, 0.5)), mad(dCD, _WaterData_WaterLODViewProjMatrix[i13 + 10u].y, mad(mad((-0.0) - ((oNz * _WaterData_WaterLODViewProjMatrix[i13 + 10u].z) * _WaterData_WaterLODViewProjMatrix[i15 + 10u].w), fracD, posWS.z), _WaterData_WaterLODViewProjMatrix[i15 + 10u].y, 0.5))), asfloat(asuint(_WaterData_WaterLODViewProjMatrix[i24 + 10u]).w), mipBias2); // b61:214
                    float tnX2 = mad(mad(tC.x, wC, wD * tD.x), 2.0, -1.0); // b61:215
                    float tnY2 = mad(mad(tC.y, wC, wD * tD.y), 2.0, -1.0); // b61:216
                    float tnZ2 = max(sqrt(((-0.0) - min(dot(float2(tnX2, tnY2), float2(tnX2, tnY2)), 1.0)) + 1.0), 1.000000016862383526387164645044e-16); // b61:217
                    float ampD = (bnw * _WaterData_WaterLODViewProjMatrix[i15 + 10u].z) * max(graze, _WaterData_WaterLODViewProjMatrix[i14 + 10u].w); // b61:218
                    float dX = ampD * tnX2; // b61:219
                    float dY = ampD * tnY2; // b61:220
                    float eX = (wgt2 * tnX) + 0.0; // b61:221
                    float eY = (wgt2 * tnY) + 0.0; // b61:222
                    float eZ = max(sqrt(((-0.0) - min(dot(float2(tnX, tnY), float2(tnX, tnY)), 1.0)) + 1.0), 1.000000016862383526387164645044e-16) + 1.0; // b61:223
                    float dotDE = dot(float3(eX, eY, eZ), float3(dX * (-1.0), dY * (-1.0), tnZ2 * 1.0)); // b61:224
                    float qX = mad((-0.0) - dX, -1.0, (eX * dotDE) / eZ); // b61:225
                    float qY = mad((-0.0) - dY, -1.0, (eY * dotDE) / eZ); // b61:226
                    float qZ = mad((-0.0) - tnZ2, 1.0, dotDE); // b61:227
                    float qInv = rsqrt(dot(float3(qX, qY, qZ), float3(qX, qY, qZ))); // b61:228
                    float qnx = qInv * qX; // b61:229
                    float qny = qInv * qY; // b61:230
                    float qnz = qInv * qZ; // b61:231
                    d0 = clamp(mad(tA.w, wA, wB * tB.w) + ((-0.0) - _WaterData_WaterLODViewProjMatrix[i18 + 10u].w), 0.0, 1.0) * bn2; // b61:232
                    d1 = mad(nx, qnz, mad(qnx, 1.0, qny * mad(nz, 0.0, (-0.0) - (ny * 0.0)))); // b61:233
                    d2 = mad(ny, qnz, mad(qnx, 0.0, qny * mad(nx, 0.0, (-0.0) - (nz * 1.0)))); // b61:234
                    d3 = mad(nz, qnz, mad(qnx, 0.0, qny * mad(ny, 1.0, (-0.0) - (nx * 0.0)))); // b61:235
                }
                else
                {
                    d0 = c0; // b61:239
                    d1 = c1; // b61:240
                    d2 = c2; // b61:241
                    d3 = c3; // b61:242
                }

                float covScale = ((max(clamp(NdotV, 0.0, 1.0), 0.5) * (((-0.0) - clamp(vMag * _WaterData_WaterLODViewProjMatrix[((objId * 20u) + 20u) + 10u].w, 0.0, 1.0)) + 1.0)) * _WaterData_WaterLODViewProjMatrix[i18 + 10u].x) * d0; // b61:244
                float encDen = dot(1.0.xxx, float3(abs(d1), abs(d2), abs(d3))); // b61:245
                float encX = d1 / encDen; // b61:246
                float encZ = d3 / encDen; // b61:247
                bool encLower = 0.0 >= d2; // b61:248
                outT0.x = mad(encLower ? (((encX >= 0.0) ? 1.0 : -1.0) * (((-0.0) - abs(encZ)) + 1.0)) : encX, 0.5, 0.5); // b61:249
                outT0.y = mad(encLower ? (((encZ >= 0.0) ? 1.0 : -1.0) * (((-0.0) - abs(encX)) + 1.0)) : encZ, 0.5, 0.5); // b61:250
                float covBias = mad(graze, 0.00999999977648258209228515625 + ((-0.0) - _WaterData_WaterLODViewProjMatrix[i16p].y), _WaterData_WaterLODViewProjMatrix[i16 + 10u].y); // b61:251
                outT0.z = clamp(mad(covScale, ((-0.0) - covBias) + _WaterData_WaterLODViewProjMatrix[i18 + 10u].z, covBias), 0.0, 1.0); // b61:252 (no +TEXCOORD_3 — mesh path)
                uint iTint = ((objId * 20u) + 10u) + 10u; // b61:253
                outT1.x = covScale * _WaterData_WaterLODViewProjMatrix[iTint].x; // b61:254
                outT1.y = covScale * _WaterData_WaterLODViewProjMatrix[iTint].y; // b61:255
                outT1.z = covScale * _WaterData_WaterLODViewProjMatrix[iTint].z; // b61:256
                outT1.w = 0.0039215688593685626983642578125 * param0x; // b61:257 (SV_Target_1.w = (1/255)*param0.x)
                outT0.w = 1.0; // b61:258 (SV_Target.w = 1)
                outT2.x = 0.0; // b61:259
                outT2.y = 0.0; // b61:260
                outT2.z = 1.0; // b61:261
                outT2.w = mad(_WaterData_WaterLODViewProjMatrix[((objId * 20u) + 9u) + 10u].w, -0.2999999821186065673828125, 0.699999988079071044921875); // b61:262
            #else
                // ENGINE-SIDE: water-VT subsystem unbound. Faithful no-VT sub-slice — octahedral encode of the interpolated
                // surface normal (mirrors b61:245-250) + objId; neutral surface targets.
                float2 oct = EncodeOctNormalUp(normalize(IN.normalWS)); // b61:245-250
                outT0 = float4(oct.x, oct.y, 0.0, 1.0); // src b61:249-250,258 (SV_Target.w = 1)
                outT1 = float4(0.0, 0.0, 0.0, INV_255 * _WaterObjectId); // src b61:254-257 (SV_Target_1.w = (1/255)*param0.x)
                outT2 = float4(0.0, 0.0, 1.0, 0.699999988079071044921875); // src b61:259-262 (default (0,0,1,0.7))
            #endif
            }
            ENDHLSL
        }
    }
}
