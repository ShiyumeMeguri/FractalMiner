// HGRP VFX Ice — refractive/emissive transparent VFX surface, single ForwardOnly pass.
// Merged from: vfxice.shader (HGRP/Effect/VFXIce) — base variant blob b30(vert)/b31(frag),
//   deltas b33(_USE_FRESNEL), b35(_PARALLAX_MAP), b37(_PARALLAX_MAP+_USE_FRESNEL),
//   b39(+_USE_ICEGROW), b41(+_USE_SOFTBLEND), b45(_USE_DISSOLVE).
// Keywords: _USE_FRESNEL, _PARALLAX_MAP, _USE_ICEGROW, _USE_SOFTBLEND, _USE_DISSOLVE
// Kept: _MainTex (RGB base-color tint, A opacity) + _NREMap (XY normal / Z roughness-unused / W emission) blend,
//   PosUV vs MeshUV select (_UVSet), tiling/offset, tint+emissive, HDR clamp, exposure divide,
//   view-space Fresnel rim (exp2/log2 pow, bias, flip, opacity coupling, color blend),
//   steep parallax march into _ParallaxTex.x heightfield (variable step count, occlusion-mapping refine),
//   dissolve (opacity- or texture-channel + directional schedule), soft-particle scene-depth fade,
//   ice-grow height-banded alpha gate (_USE_ICEGROW: fragment-side, saturate(_MainTex.w - |worldY-growFront| + _GrowSchedule)),
//   Houdini-VAT-in-particle alpha gate, blend-state-driven alpha/additive select.
// Removed: GPU skinning (BLENDWEIGHTS/BLENDINDICES + bone ByteAddressBuffer → static mesh),
//   HGRP motion vectors / SV_Target1 MRT (URP has its own MotionVectors pass),
//   TAA jitter, packed-octahedral vertex normal/tangent decode (Unity-standard meshes),
//   camera-relative world space (URP absolute WS), per-draw instancing array, _VAT_RIGIDBODY (Houdini rigid-body VAT).
//
// NOTE: the decompiled per-material cbuffer field NAMES are scrambled (compiler packoffset packing
//   shuffles which logical property lands in each slot per variant). All property names below are
//   recovered from the SOURCE Properties block + each variant's math structure, NOT the blob field names.
// NOTE: TEXTURE ROLE (the decompiler also SWAPPED the texture sampler-suffix names). Proof: b33/b37 decode a
//   tangent-space NORMAL (mad(x,2,-1)+derive-Z) from the "MainTex"-suffixed sampler — a normal can only come from
//   a normal map, so that register physically holds _NREMap (default "bump"). Propagated consistently, the surface is:
//   COLOR TINT = _MainTex.rgb * _TintColor ; OPACITY/alpha-additive = _MainTex.w ; NORMAL seed = _NREMap.xy ;
//   EMISSION = _NREMap.w * _EmmissiveColor. (NRE = Normal-XY / Roughness-Z[unused] / Emission-W.) The c4 color slot
//   is _EmmissiveColor in the no-fresnel paths and _FresnelColor under _USE_FRESNEL; the parallax inner-lerp target is _ParallaxColor.

Shader "HGRP/Effect/VFXIce_Fix" {
    Properties {
        [Header(Surface)]
        [Enum(Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableZTest ("Disable ZTest", Float) = 0
        [Enum(Off, 0, On, 1)] _VFXIceZWrite ("ZWrite", Float) = 0
        [Enum(MeshUV, 0, PosUV, 1)] _UVSet ("UV Set", Float) = 0
        _TilingOffset ("Tiling And Offset", Vector) = (1, 1, 0, 0)
        [ToggleUI] _EnableTransparentMV ("Enable Transparent MV", Float) = 0
        [ToggleUI] _HoudiniVATInParticle ("Houdini VAT In Particle", Float) = 0
        [ToggleUI] _TextureFormat ("Texture Format (On:HDR, Off:LDR)", Float) = 1
        [ToggleUI] _IgnorePostExposure ("Ignore Post Exposure", Float) = 1
        _TintColorAlpha ("Tint Color Alpha (Default 1)", Range(0, 10)) = 1

        [Header(Maps)]
        _MainTex ("Base Color Tex (W:Opacity)", 2D) = "white" {}
        [HDR] [Gamma] _TintColor ("Tint Color", Color) = (1, 1, 1, 1)
        [HDR] [Gamma] _EmmissiveColor ("Emmissive Color", Color) = (1, 1, 1, 1)
        _NREMap ("NRE Map (XY:Normal, Z:Roughness, W:Emission)", 2D) = "bump" {}
        _NormalScale ("Normal Scale", Range(0, 5)) = 1
        _RoughnessMin ("Roughness Min", Range(0, 1)) = 0
        _RoughnessMax ("Roughness Max", Range(0, 1)) = 1

        [Header(Ice Grow)]
        [Toggle(_USE_ICEGROW)] _UseIceGrow ("Use Ice Grow", Float) = 0
        _CharHeight ("Char Height", Float) = 1.8
        _GrowStart ("Grow Start", Float) = 0.9
        _GrowSchedule ("Grow Schedule", Float) = 0

        [Header(Parallax)]
        [Toggle(_PARALLAX_MAP)] _UseParallax ("Use Parallax", Float) = 0
        _ParallaxTex ("Parallax Tex", 2D) = "white" {}
        _ParallaxMarchNum ("Parallax March Num", Range(1, 5)) = 3
        _ParallaxScale ("Parallax Scale", Range(0, 1)) = 1
        [HDR] [Gamma] _ParallaxColor ("Parallax Color", Color) = (0, 0, 0, 1)

        [Header(Dissolve)]
        [Toggle(_USE_DISSOLVE)] _UseDissolve ("Use Dissolve", Float) = 0
        [Enum(Opacity, 0, DissolveTex, 1)] _DissolveTexChannel ("Dissolve Channel", Float) = 0
        _DissolveTex ("Dissolve Tex", 2D) = "white" {}
        _DissolveScheduleOffset ("Dissolve Schedule", Float) = 0
        _DissolveDir ("Dissolve Dir", Vector) = (0, 0, 0, 0)

        [Header(Soft Blend)]
        [Toggle(_USE_SOFTBLEND)] _UseSoftBlend ("Use SoftBlend", Float) = 0
        _SoftDistance ("Soft Distance", Range(0.001, 10)) = 0.001
        _SoftBias ("Soft Bias", Float) = 0

        [Header(Fresnel)]
        [Toggle(_USE_FRESNEL)] _UseFresnel ("Use Fresnel", Float) = 0
        [HDR] [Gamma] _FresnelColor ("Fresnel Color", Color) = (1, 1, 1, 1)
        _FresnelBias ("Fresnel Bias (Default 0)", Range(-1, 2)) = 0
        _FresnelAffectOpacity ("Fresnel Affect Opacity", Range(0, 1)) = 1
        _FresnelPower ("Fresnel Power (Default 1)", Range(1, 10)) = 1
        [ToggleUI] _FresnelFlip ("Fresnel Flip", Float) = 0.001

        // Exposure params (HGRP global _ExposureParams re-exposed as a material Vector)
        _ExposureParams ("Exposure Params", Vector) = (1, 0, 0, 0)

        // --- Blend-state plumbing (driven by a material editor / OnValidate, not the shader) ---
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 0
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 1
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
        [HideInInspector] _StencilWriteMask ("__stencilWriteMask", Float) = 255
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
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Surface / common
                float  _SurfaceType;
                float  _BlendMode;
                float  _UVSet;
                float4 _TilingOffset;
                float  _EnableTransparentMV;
                float  _HoudiniVATInParticle;
                float  _TextureFormat;
                float  _IgnorePostExposure;
                float  _TintColorAlpha;
                // Maps / color
                float4 _TintColor;
                float4 _EmmissiveColor;
                float4 _MainTex_ST;
                float4 _NREMap_ST;
                float  _NormalScale;
                float  _RoughnessMin;
                float  _RoughnessMax;
                // Ice grow
                float  _CharHeight;
                float  _GrowStart;
                float  _GrowSchedule;
                // Parallax
                float4 _ParallaxTex_ST;
                float  _ParallaxMarchNum;
                float  _ParallaxScale;
                float4 _ParallaxColor;
                // Dissolve
                float4 _DissolveTex_ST;
                float  _DissolveTexChannel;
                float  _DissolveScheduleOffset;
                float4 _DissolveDir;
                // Soft blend
                float  _SoftDistance;
                float  _SoftBias;
                // Fresnel
                float4 _FresnelColor;
                float  _FresnelBias;
                float  _FresnelAffectOpacity;
                float  _FresnelPower;
                float  _FresnelFlip;
                // Exposure (HGRP _ExposureParams.x = post-exposure multiplier)
                float4 _ExposureParams;
            CBUFFER_END

            TEXTURE2D(_NREMap);      SAMPLER(sampler_NREMap);       // Normal-XY / Roughness-Z(unused) / Emission-W (default "bump")
            TEXTURE2D(_MainTex);     SAMPLER(sampler_MainTex);      // base color RGB (×_TintColor) + opacity A
            TEXTURE2D(_ParallaxTex); SAMPLER(sampler_ParallaxTex);  // parallax heightfield (marched .x) in _PARALLAX_MAP variants
            TEXTURE2D(_DissolveTex); SAMPLER(sampler_DissolveTex);  // dissolve mask in _USE_DISSOLVE variants

            // Normal-XY deadzone: |n|<0.012 → 0 (blob b33:120-121, b39:148-149)
            static const float NORMAL_DEADZONE = 0.01200000010430812835693359375;
            // rsqrt normalize guard = FLT_MIN (blob b33:132 / vertex b30:484)
            static const float FLT_MIN_GUARD   = 1.1754943508222875079687365372222e-38;
            // 1e-8 view-len epsilon (blob b33:137)
            static const float VIEW_LEN_EPS    = 9.9999999392252902907785028219223e-09;

            // ----------------------------------------------------------------
            // UV: PosUV (project reconstructed object-relative world pos onto
            // normalized object X-axis) vs MeshUV, then * tiling + offset.
            // (blob b31:96-106; b33:103-115)  positionWS here is absolute WS.
            // ----------------------------------------------------------------
            float2 ComputeSurfaceUV(float2 meshUV, float3 positionWS, out float2 rawUV)
            {
                // object-relative position (HGRP did NDC→WS then -_unity_ObjectToWorld[3]; URP carries WS, subtract origin)
                float3 objRelPos = positionWS - float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);
                // normalized object X-axis (blob: ObjectToWorld[0].xyz / dot(col0,col0))  → unit when no scale
                float3 objX  = float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20);
                float  invLenSq = 1.0 / dot(objX, objX);
                float2 posUV;
                posUV.x = dot(objX * invLenSq, objRelPos) + 1.0;   // blob b31:105
                posUV.y = positionWS.y;                            // blob b31:106 (the .y of recon pos == WS.y here)
                rawUV = (_UVSet != 0.0) ? posUV : meshUV;          // blob _173/_176 (the select BEFORE tiling — used by dissolve UV)
                return rawUV * _TilingOffset.xy + _TilingOffset.zw; // blob b31:105-106 mad(uv, ST.xy, ST.zw)
            }

            // View direction (perspective: cam→P normalized; ortho: +ViewMatrix row2 = (_m20,_m21,_m22), the view-space Z basis).
            // (blob b33:133-137 — ortho branch is _ViewMatrix[col].z with NO negation: _338 = _ViewMatrix[0u].z etc.)
            float3 ComputeViewDir(float3 positionWS)
            {
                float3 v = (unity_OrthoParams.w == 0.0)                                            // URP provides unity_OrthoParams (no leading _); blob spelled it _unity_OrthoParams (HGRP). STYLE_BIBLE §2 map.
                         ? (_WorldSpaceCameraPos - positionWS)
                         : float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22); // blob b33:134-136 (un-negated)
                return v * rsqrt(max(dot(v, v), VIEW_LEN_EPS));
            }

            // Decode NRE.xy → tangent-space normal (deadzone, derive Z, scale). (blob b33:118-128, b39:146-156)
            float3 DecodeNRENormal(float2 nreXY, float scale)
            {
                float nx = mad(nreXY.x, 2.0, -1.0);
                float ny = mad(nreXY.y, 2.0, -1.0);
                nx = (abs(nx) < NORMAL_DEADZONE) ? 0.0 : nx;
                ny = (abs(ny) < NORMAL_DEADZONE) ? 0.0 : ny;
                float3 n;
                n.x = nx * scale;
                n.y = ny * scale;
                n.z = mad(scale, sqrt(max(1.0 - dot(float2(nx, ny), float2(nx, ny)), 0.0)) - 1.0, 1.0);
                return normalize(n);   // rsqrt(dot) — blob b33:125-128
            }

            // Tangent-space normal → world via TBN (T=tangentWS, B=sign*cross(N,T), N=normalWS).
            // (blob b33:129-131)
            float3 NormalTangentToWorld(float3 nTS, float3 N, float4 tangentWS)
            {
                float3 T = tangentWS.xyz;
                float  bSign = (tangentWS.w > 0.0) ? 1.0 : -1.0;
                float3 B = bSign * cross(N, T);
                float3 nWS = nTS.z * N + nTS.x * T + nTS.y * B;
                return nWS * rsqrt(max(dot(nWS, nWS), FLT_MIN_GUARD));
            }
        ENDHLSL

        Pass {
            Name "ForwardOnly"
            Tags { "LightMode"="UniversalForwardOnly" }

            Blend [_SrcBlend] [_DstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]
            Stencil {
                Ref [_StencilRef]
                WriteMask [_StencilWriteMask]
                Comp Always
                Pass Replace
                Fail Keep
                ZFail Keep
            }

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            #pragma shader_feature_local _USE_FRESNEL
            #pragma shader_feature_local _PARALLAX_MAP
            #pragma shader_feature_local _USE_ICEGROW
            #pragma shader_feature_local _USE_SOFTBLEND
            #pragma shader_feature_local _USE_DISSOLVE

            struct Attributes {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 tangentOS  : TANGENT;
                float4 color      : COLOR;
                float2 uv0        : TEXCOORD0;
                float2 uv1        : TEXCOORD1;
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;   // mesh UV (blob VS TEXCOORD_2 = TEXCOORD.xy)
                float3 normalWS   : TEXCOORD1;   // blob VS TEXCOORD_2_1
                float4 tangentWS  : TEXCOORD2;   // .xyz + sign in .w (blob VS TEXCOORD_3)
                float4 color      : TEXCOORD3;   // vertex color (blob VS TEXCOORD_4_1)
                float3 positionWS : TEXCOORD4;
                float4 screenPos  : TEXCOORD5;   // for scene-depth soft blend
            };

            Varyings vert(Attributes v)
            {
                Varyings o = (Varyings)0;

                float3 positionOS = v.positionOS;

                #ifdef _USE_ICEGROW
                    // 1:1 (VERTEX delta is empty — source = vfxice/Sub0_Pass0_Vertex_b38.hlsl:170-544 vs Sub0_Pass0_Vertex_b30.hlsl:134-512):
                    //   _USE_ICEGROW carries NO vertex DISPLACEMENT — b38 position/normal/tangent + clip-pos pipeline is byte-identical to base
                    //   b30 (the 8-bone GPU-skinning branch is present in BOTH; differences are only packoffset name-scrambling). So no vertex math.
                    //   *** BUT the icegrow delta is NOT empty: it lives in the FRAGMENT as an alpha grow-gate ***. See the grow-gate block in
                    //   frag() below (cited to b39:253 vs b37:252). A prior audit pass WRONGLY concluded "CONFIRMED-EMPTY DELTA / _GrowSchedule
                    //   never read" — that missed the b39 SV_Target.w leading factor. Do not re-delete the fragment grow-gate.
                #endif

                VertexPositionInputs posIn = GetVertexPositionInputs(positionOS);
                VertexNormalInputs   nrmIn = GetVertexNormalInputs(v.normalOS, v.tangentOS);

                o.positionCS = posIn.positionCS;
                o.positionWS = posIn.positionWS;
                o.normalWS   = nrmIn.normalWS;                                   // blob VS _782..784 normalize
                o.tangentWS  = float4(nrmIn.tangentWS, v.tangentOS.w * GetOddNegativeScale()); // blob VS _806..808 + .w sign
                o.uv         = v.uv0;
                o.color      = v.color;
                o.screenPos  = ComputeScreenPos(o.positionCS);
                return o;
            }

            half4 frag(Varyings input, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                float3 positionWS = input.positionWS;
                float3 normalWS   = normalize(input.normalWS);
                float4 tangentWS  = input.tangentWS;

                // ---- UV ----  (blob b31:105-106 / b33:114-115); rawUV = pre-tiling select (blob _173/_176) for dissolve UV
                float2 rawUV;
                float2 uv = ComputeSurfaceUV(input.uv, positionWS, rawUV);

                // ---- View dir ----  (blob b33:133-137)
                float3 V = ComputeViewDir(positionWS);

                // ================= PARALLAX (steep march into _ParallaxTex.x heightfield) =================
                // (blob b35:139-207, b37:162-238, b39:166-239)
                // TEXTURE-ROLE (3-tex parallax, decompiler ROTATED the s0/s1/s2 sampler suffixes — disambiguated the same way as the base
                //   path: b37:142 decodes the NORMAL from s2 ⇒ s2 = physical _NREMap; the march heightfield is s1 ⇒ physical _ParallaxTex;
                //   the ×_TintColor tint base is s0 ⇒ physical _MainTex). So: march into _ParallaxTex (height = refined .x), tint base from
                //   _MainTex, normal seed .xy + emission .w from _NREMap sampled at BASE uv (b37:140-141 _277/_278, NOT the refined uv).
                #ifdef _PARALLAX_MAP
                    // Build TBN-projected view ray in UV space.
                    float bSignP = (tangentWS.w > 0.0) ? 1.0 : -1.0;
                    float3 Bp = bSignP * cross(normalWS, tangentWS.xyz);
                    float vT = dot(tangentWS.xyz, V);                              // blob b35:135 / b39:162
                    float vB = dot(Bp, V);                                         // blob b35:136 / b39:163
                    float vN = dot(normalWS, V);                                   // blob b35:137 / b39:164
                    float invLenTBN = rsqrt(dot(float3(vT, vB, vN), float3(vT, vB, vN)));
                    float marchNum = min(20.0, _ParallaxMarchNum);                 // blob b35:143 / b39:170
                    float invMarch = 1.0 / marchNum;
                    float denomA = mad(vN, invLenTBN, 0.4199999868869781494140625);// blob b35:145 / b39:172 (+0.42)
                    float denomB = max(invLenTBN * vN, 0.001000000047497451305389404296875); // blob b35:146 / b39:173
                    float scaleP = -_ParallaxScale;                               // blob b35:147 / b39:174
                    float stepU = (((invLenTBN * vT) / denomA) / denomB) * scaleP; // blob b35:148 / b39:175
                    float stepV = (((invLenTBN * vB) / denomA) / denomB) * scaleP; // blob b35:149 / b39:176
                    float du = invMarch * stepU;                                  // blob b35:150
                    float dv = invMarch * stepV;                                  // blob b35:151
                    float loopEnd = marchNum + 1.0;                               // blob b35:152

                    // gradients are of the RAW (pre-tiling) UV — blob b35:139-142 ddx/ddy(_221/_222) where _221/_222 are the
                    // un-tiled pos/mesh select (the sample POSITION is the parallax-tiled uv, but the GRAD args use the raw-UV
                    // derivatives; ×_GlobalMipBiasPow2≈1 dropped).
                    float2 ddxUV = float2(ddx_coarse(rawUV.x), ddx_coarse(rawUV.y));
                    float2 ddyUV = float2(ddy_coarse(rawUV.x), ddy_coarse(rawUV.y));

                    // 1:1 (source = vfxice/Sub0_Pass0_Fragment_b35.hlsl:129-130 _262/_263, b37:156-157 _366/_367): the parallax
                    // heightfield marches in its OWN _ParallaxTex_ST frame, NOT the base _TilingOffset frame. The blob samples the
                    // base color/normal at _232/_233 = rawUV*_TilingOffset (c9 slot, the shared tiling present even in base b31),
                    // but the march heightfield at _262/_263 = rawUV*_ParallaxTex_ST (c5 in b35 / c7 in b37 — a SEPARATE cbuffer
                    // slot that only appears in _PARALLAX_MAP variants ⇒ the auto _ParallaxTex_ST). Two distinct slots = two distinct
                    // float4s. Defaults coincide (both (1,1,0,0)) so this was invisible at defaults, but is a real 1:1 deviation once
                    // _ParallaxTex_ST ≠ _TilingOffset. Re-derive rawUV through _ParallaxTex_ST for the march/refine sample positions.
                    float2 puv = mad(rawUV, _ParallaxTex_ST.xy, _ParallaxTex_ST.zw); // blob b35:129-130 (rawUV * _ParallaxTex_ST)

                    float curU = du, curV = dv;                                   // blob b35:173-174 init (_379=_361=du, _388=_362=dv — BOTH offset one step)
                    float prevU = 0.0, prevV = 0.0;
                    float layerHeight = 1.0 - invMarch;                           // blob b35:169 _386
                    float prevLayer = 1.0;                                        // blob b35:170 _390
                    float sampledH = 0.0, prevSampledH = 0.0;
                    [loop] for (float i = 0.0; i < loopEnd; i += 1.0)             // blob b35:177-205
                    {
                        sampledH = SAMPLE_TEXTURE2D_GRAD(_ParallaxTex, sampler_ParallaxTex, puv + float2(curU, curV), ddxUV, ddyUV).x; // blob b35:182 march = s1 (physical _ParallaxTex) at _262/_263
                        if (layerHeight < sampledH) break;                        // blob b35:183
                        prevU = curU; prevV = curV;
                        prevSampledH = sampledH;
                        prevLayer = layerHeight;
                        curU += du; curV += dv;
                        layerHeight -= invMarch;
                    }
                    // occlusion-mapping interpolation between last two layers (blob b35:206)
                    //   _426 = (_384 - _390) / ((_386 - _390) + (_384 - _408))
                    //        = (prevSampledH - prevLayer) / ((layerHeight - prevLayer) + (prevSampledH - afterH))
                    float afterH = sampledH;
                    float num   = prevSampledH - prevLayer;                       // _384 - _390
                    float den   = (layerHeight - prevLayer) + (prevSampledH - afterH); // (_386-_390)+(_384-_408)
                    float t     = num / den;
                    float2 finalUV = puv + float2(mad(du, t, prevU), mad(dv, t, prevV)); // blob b35:207 (march frame = _ParallaxTex_ST)
                    float  heightX   = SAMPLE_TEXTURE2D(_ParallaxTex, sampler_ParallaxTex, finalUV).x; // blob b35:207-208 _435.x (refined _ParallaxTex height)
                    float4 mainSample= SAMPLE_TEXTURE2D(_MainTex,  sampler_MainTex,  uv);  // blob b35:126 _240 (s0 = physical _MainTex → tint base, opacity .w)
                    float4 nreSample = SAMPLE_TEXTURE2D(_NREMap,   sampler_NREMap,   uv);  // blob b35:127 _250 (s2 = physical _NREMap → normal seed .xy, emission .w) — base uv
                    // tint part = lerp(_MainTex.rgb * _TintColor.rgb, _ParallaxColor.rgb, height)
                    //   (blob b35:210-212 / b37:240-242 / b39:241-243: mad(height, mad(-_240.x, _TintColor.x, _ParallaxColor.x),
                    //    _240.x * _TintColor.x) = lerp(_MainTex*_TintColor, _ParallaxColor, height). The lerp target is _ParallaxColor
                    //    (c4 slot, == _FresnelColor only when _USE_FRESNEL; here the parallax tint). _ParallaxScale is the MARCH depth scale
                    //    only — NOT the tint scale. Outer fresnel lerp to _FresnelColor + the emissive add happen below, shared with base.)
                    float3 color;
                    color.x = mad(heightX, mad(-mainSample.x, _TintColor.x, _ParallaxColor.x), mainSample.x * _TintColor.x); // blob b35:210
                    color.y = mad(heightX, mad(-mainSample.y, _TintColor.y, _ParallaxColor.y), mainSample.y * _TintColor.y); // blob b35:211
                    color.z = mad(heightX, mad(-mainSample.z, _TintColor.z, _ParallaxColor.z), mainSample.z * _TintColor.z); // blob b35:212
                    // emissive term = _NREMap.w * _EmmissiveColor (blob b35:210-212 outer mad(_EmmissiveColor, _252=_250.w, ...)).
                    float3 emissiveTerm = nreSample.w * _EmmissiveColor.xyz;   // _250.w (physical _NREMap.w emission)
                    float baseOpacity = mainSample.w;                         // blob b35:217 alpha additive _240.w (physical _MainTex.w opacity)
                #else
                    // ================= BASE color (no parallax) =================
                    float4 nreSample  = SAMPLE_TEXTURE2D(_NREMap,  sampler_NREMap,  uv); // blob b31:107 _190
                    float4 mainSample = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, uv); // blob b31:108 _200
                    // tint part = _MainTex.rgb * _TintColor.rgb ; emissive part = _NREMap.w * _EmmissiveColor.rgb
                    //   (blob b31:112-114: mad(_190.x, c3.x=_TintColor.x, _200.w * c4=_EmmissiveColor.x).
                    //    TEXTURE-ROLE: the decompiler SWAPPED the two sampler suffixes. Proof: b33:118/b37:142 decode a tangent-space
                    //    NORMAL (mad(x,2,-1)+derive-Z) from the sampler_MainTex-bound texture — a normal can only come from the normal
                    //    map, so that register physically holds _NREMap (default "bump"). Hence the sampler_NREMap-bound texture (_190)
                    //    physically holds _MainTex (base color, default "white"). Propagating consistently: base-color tint = _MainTex.rgb
                    //    (the _190.xyz operand), emission = _NREMap.w (the _200.w operand), normal seed = _NREMap.xy, opacity = _MainTex.w.
                    //    Since this shader (correctly) decodes the normal from _NREMap below, the color/emissive MUST use the same physical
                    //    reading. The c4 slot is _FresnelColor only under _USE_FRESNEL; in the no-fresnel base it is _EmmissiveColor.)
                    float3 color = mainSample.xyz * _TintColor.xyz;          // blob b31:112-114 _190.xyz (physical _MainTex base color) * _TintColor
                    float3 emissiveTerm = nreSample.w * _EmmissiveColor.xyz; // blob b31:112-114 _200.w (physical _NREMap.w = "E" emission) * _EmmissiveColor
                    float baseOpacity = mainSample.w;                        // blob b31:110 alpha additive = _190.w (physical _MainTex.w opacity)
                #endif

                // ================= NORMAL (from NRE.xy) → world =================
                // (blob b33:118-131 — used by Fresnel; in base b31 no per-pixel normal is built)
                float3 normalForFresnel = normalWS;
                #if defined(_USE_FRESNEL) || defined(_PARALLAX_MAP)
                    float3 nTS = DecodeNRENormal(nreSample.xy, _NormalScale);    // blob b33:118-128
                    normalForFresnel = NormalTangentToWorld(nTS, normalWS, tangentWS); // blob b33:129-131
                #endif

                // ================= FRESNEL rim =================
                float fresnelTerm = 1.0;
                #ifdef _USE_FRESNEL
                    // exp2(log2(saturate(dot(V,N)+bias)) * power)  ==  pow(saturate(NoV+bias), power)
                    // (blob b33:138)
                    float NoV = dot(V, normalForFresnel) + _FresnelBias;
                    float fresnel = exp2(log2(saturate(NoV)) * _FresnelPower);
                    float invFresnel = 1.0 - fresnel;                            // blob b33:139
                    fresnelTerm = mad(_FresnelFlip, fresnel - invFresnel, invFresnel); // blob b33:140
                    float fresnelBlend = fresnelTerm * _FresnelColor.w;          // blob b33:141 _387
                    // color = lerp(tintPart, _FresnelColor.rgb, fresnelBlend)   (blob b33:143-145 / b37:245-247 / b39:246-248)
                    //   blob inner: mad(fresnelBlend, mad(-color.x, 1, _FresnelColor.x), color.x) = lerp(color.x, _FresnelColor.x, fb).
                    //   The lerp SOURCE is the tint part only (NRE*_TintColor or the parallax inner-lerp); there is NO _NormalScale
                    //   factor (b33's per-channel weight _SoftDistance/_SoftBias slot == _TintColor, already baked into `color`).
                    color.x = mad(fresnelBlend, _FresnelColor.x - color.x, color.x);
                    color.y = mad(fresnelBlend, _FresnelColor.y - color.y, color.y);
                    color.z = mad(fresnelBlend, _FresnelColor.z - color.z, color.z);
                #endif

                // Emissive-from-opacity term, added AFTER the fresnel lerp (blob b31/b33/b35/b37/b39: the
                // mad(_EmmissiveColor.x, MainTex.w, <fresnel-lerped tint>) outer term — outside the rim blend).
                color += emissiveTerm;

                // ================= Exposure ================= (blob b31:111 / b33:142)
                float exposureScale = mad(_ExposureParams.x, _TextureFormat, 1.0 - _TextureFormat);
                color = min(max(color, 0.0), 1000.0) / exposureScale;            // blob b31:112-114 clamp[0,1000]/exp

                // ================= ALPHA =================
                // alpha = (vatBase + _HoudiniVATInParticle*(clamp(vatBase*sample + dot(objRelPos,dir) + bias, 0,1) - vatBase)) * _TintColorAlpha
                //   (blob b31:110 / b33:147 / b45:115). vatBase = 1 with no fresnel, = fresnelOpacity (_497) with fresnel.
                //   The clamp's `sample` is the NRE.w / ParallaxTex.w channel (== baseOpacity, set per path above). The fresnel
                //   coupling _497 multiplies ONLY the sample, not the dot/bias (b33:147 mad(_497,_254.w,dot(...))).
                //   bias: blob uses _houdiniFPS (Houdini-VAT frame rate — dropped VAT infra); _DissolveScheduleOffset is the URP
                //   stand-in scalar bias into the same clamp slot.
                float3 objRelPos = positionWS - float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);

                // fresnel-affects-opacity factor (blob b33:146 _497); 1 when no fresnel.
                float fresnelOpacity = 1.0;
                #ifdef _USE_FRESNEL
                    fresnelOpacity = mad(fresnelTerm, _FresnelAffectOpacity, 1.0 - _FresnelAffectOpacity); // blob b33:146
                #endif

                // VAT positional schedule = dot(objRelPos, dir). Base/no-dissolve uses the Houdini stretch-by-velocity
                // direction (blob b31:110 cols·{_B_stretchByVel/_SoftDistance/_SoftBias}) — that is VAT-velocity infra
                // (dropped with GPU skinning / VAT mesh), so it is 0 here. Dissolve replaces it with the _DissolveDir gradient.
                float vatDot = 0.0;
                float vatSample = fresnelOpacity * baseOpacity;                  // blob: _497 * NRE.w (or *1 when no fresnel)
                #ifdef _USE_DISSOLVE
                    // dissolve sample: Opacity channel (NRE.w via baseOpacity) or DissolveTex.r, + directional schedule (blob b45:115)
                    //   1:1, source = vfxice/Sub0_Pass0_Fragment_b45.hlsl:115. The DissolveTex UV uses the auto _DissolveTex_ST (c3 slot,
                    //   a 4-component tile.xy/offset.zw transform of the PRE-tiling rawUV: mad(_173,c3.x,c3.z)/mad(_176,c3.y,c3.w)), NOT
                    //   _DissolveDir. _DissolveDir (c6, only 3 used components x/y/z) is the SEPARATE world-gradient direction below — two
                    //   distinct cbuffer slots ⇒ two distinct properties. (A prior pass used _DissolveDir here, which at its (0,0,0,0)
                    //   default samples a constant texel; _DissolveTex_ST defaults (1,1,0,0) → samples at surface rawUV, the correct behavior.)
                    float2 dissolveUV = mad(rawUV, _DissolveTex_ST.xy, _DissolveTex_ST.zw); // blob b45:115 mad(rawUV, _DissolveTex_ST.xy, _DissolveTex_ST.zw)
                    float dissSample = (_DissolveTexChannel != 0.0)
                                     ? SAMPLE_TEXTURE2D(_DissolveTex, sampler_DissolveTex, dissolveUV).x
                                     : baseOpacity;
                    vatSample = fresnelOpacity * dissSample;
                    // directional gradient over object-relative pos (DissolveDir mapped into object axes via O2W columns)
                    float3 dissDirWS = float3(
                        mad(unity_ObjectToWorld._m20, _DissolveDir.z, mad(unity_ObjectToWorld._m00, _DissolveDir.x, unity_ObjectToWorld._m10 * _DissolveDir.y)),
                        mad(unity_ObjectToWorld._m21, _DissolveDir.z, mad(unity_ObjectToWorld._m01, _DissolveDir.x, unity_ObjectToWorld._m11 * _DissolveDir.y)),
                        mad(unity_ObjectToWorld._m22, _DissolveDir.z, mad(unity_ObjectToWorld._m02, _DissolveDir.x, unity_ObjectToWorld._m12 * _DissolveDir.y)));
                    vatDot = dot(objRelPos, dissDirWS);                          // blob b45:115 inner dot
                #endif
                float vatClamp = clamp(vatSample + vatDot + _DissolveScheduleOffset, 0.0, 1.0); // blob b31/b33/b45 clamp + (houdiniFPS→)_DissolveScheduleOffset
                float alpha = mad(_HoudiniVATInParticle, vatClamp - fresnelOpacity, fresnelOpacity) * _TintColorAlpha; // blob b31:110 / b33:147

                // ================= ICE GROW (height-banded alpha grow-gate) =================
                // 1:1, source = vfxice/Sub0_Pass0_Fragment_b39.hlsl:253 (the _USE_ICEGROW SV_Target.w LEADING factor, absent from the
                //   parallax+fresnel base b37:252). Decoded byte-for-byte from b39:253:
                //     ((-0.0) - (abs(_125 - c8.x) + ((-0.0) - c8.y))) + _285.w
                //       = _285.w - abs(worldY - c8.x) + c8.y                       (− abs band, +schedule additive)
                //   _125 = reconstructed ABSOLUTE world-space Y of the fragment (positionWS.y); _285 = T0 (ParallaxTex-suffixed s0) =
                //   physical _MainTex per the 3-tex rotation ⇒ _285.w == baseOpacity (_MainTex.w). c8.y is the slot the prior pass itself
                //   identified as _GrowSchedule (additive widen-over-time term, sign verified +). c8.x is the grow-front world height;
                //   the host folds the two exposed start params into that single uniform — reconstructed here as _GrowStart*_CharHeight
                //   (normalized start fraction × character height = world-Y frontier; defaults 0.9*1.8=1.62). The whole gate multiplies the
                //   VAT alpha BEFORE *_TintColorAlpha in the blob; alpha already carries *_TintColorAlpha here, so alpha*=growGate is the
                //   same product (scalar, commutative). Gate math (texture .w + position + saturate, signs/clamp exact) is 1:1; only the
                //   3-exposed-param → 1-uniform composition for c8.x is a host-precompute reconstruction (see residual risk).
                #ifdef _USE_ICEGROW
                    float growFront = _GrowStart * _CharHeight;                                       // c8.x host-precomputed grow-front world-Y
                    float growGate  = saturate(baseOpacity - abs(positionWS.y - growFront) + _GrowSchedule); // blob b39:253 _285.w - abs(worldY-c8.x) + c8.y
                    alpha *= growGate;
                #endif

                // ================= SOFT BLEND (scene-depth particle fade) =================
                // (blob b41:151-155): fade = saturate((sceneDepthVS - fragDepthVS + bias) / softDistance)
                #ifdef _USE_SOFTBLEND
                    float2 screenUV = input.screenPos.xy / max(input.screenPos.w, 1e-6);
                    float sceneRawDepth = SampleSceneDepth(screenUV);
                    float sceneEye = LinearEyeDepth(sceneRawDepth, _ZBufferParams);
                    float fragEye  = LinearEyeDepth(input.positionCS.z, _ZBufferParams);
                    float softFade = saturate((abs(sceneEye) - abs(fragEye) + _SoftBias) / _SoftDistance); // blob b41:154-155
                    alpha *= softFade;
                #endif

                // ================= OUTPUT =================
                // Blob writes SV_Target = (color, alpha) RAW — b31:112-114 (color, post-exposure, NOT premultiplied) + b31:110
                // (SV_Target.w = alpha). The premultiply / additive selection is done by the BLEND STATE, not the shader:
                // Blend [_SrcBlend] [_DstBlend] driven by _BlendMode (Additive→One/One, Alpha→SrcAlpha/OneMinusSrcAlpha,
                // premultiplied→One/OneMinusSrcAlpha). Hardcoding color*alpha here would double-multiply in SrcAlpha modes, so
                // we emit raw color to stay 1:1 with the blob and let the material's blend factors combine it.
                return half4(color, alpha);
            }
            ENDHLSL
        }
    }
}
