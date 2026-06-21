// HGRP Tree-Foliage Card-Mesh LOD (impostor/billboard foliage) — ForwardLit + ShadowCaster + DepthOnly + DepthNormals.
// Merged from: treefoliagecardmeshlod.shader (foliage/) — base (#else) blobs:
//   GBuffer  vert Sub0_Pass0_Vertex_b18 / frag Sub0_Pass0_Fragment_b19  (the deferred surface-pack pass)
//   Shadow   vert Sub0_Pass1_Vertex_b111 (+_ALPHATEST_ON b113/b114) / frag b112
//   DepthOnly vert Sub0_Pass2_Vertex_b159 / frag b160 (empty)
//   Feature deltas read: b21(_ALPHATEST_ON), b23(_BLEND_COLOR), b25(_USE_SPHERE_SHADOW_PROXY), b28(_LEAF_OFFSET_COVER_TRUNK).
// Keywords: _ALPHATEST_ON, _BLEND_COLOR, _USE_SPHERE_SHADOW_PROXY, _LEAF_OFFSET_COVER_TRUNK, _CROSS_CARD_VIEW_CULLING
//   (_TwoSidedNormal back-face flip is a plain uniform, unconditional in the base blob — no keyword.)
// Kept: 2-map foliage surface (BaseColor RGBA, NormalMap RG=normal B=roughness/SSS A=AO), DXT-style normal
//   decode + NormalScale, two-sided normal flip (vertex-color gated), roughness range (RoughnessMin/Max with
//   CardmeshCaptureMode), distance-faded translucency/transmission, backface-GI ambient boost, occlusion
//   (OcclusionStrength + OcclusionShadow), FAKE directional shadow (Strength/Pow), sphere-shadow proxy (×4),
//   leaf-part vertex offset to cover trunk, base-color tint-cover / blend-color, alpha clip + shadow alpha clip.
//   Lit via URP GetMainLight (GGX) + SampleSH ambient + GlossyEnvironmentReflection.
// Removed (pixel-neutral pipeline infra substituted by URP, per STYLE_BIBLE §2 / CORE_MATH §2.12):
//   the HGRP 5-MRT deferred GBuffer pack (octahedral-normal encode, screen-derivative LOD-crossfade dither,
//   bitfield 8-bit channel packing into SV_Target0..4) — replaced by direct URP forward lighting of the same
//   surface; HG_ENABLE_MV / TaaJitter / prev-frame reprojection / NonJitteredViewProj (URP MotionVectors pass);
//   packed-octahedral vertex NORMAL.x decode + per-draw camera-relative RWS (URP GetVertexNormalInputs /
//   unity_ObjectToWorld); SRP/ECS instancing; the bespoke directional-light cbuffer (URP GetMainLight);
//   RayTracingReflection pass (empty stub in source → dropped).
//
// NOTE: vertex-color.x (COLOR.r, = blob TEXCOORD_4.x) is the LEAF↔TRUNK coverage gate, used everywhere as
//   lerp(featureValue_for_leaf, alt_for_trunk, color.x). color.y participates in the two-sided back-face flip.
// NOTE: _NormalMap legend — RG = tangent normal, B = roughness/transmission source, A = ambient-occlusion.
//   _BaseColorMap — RGB = albedo, A = coverage/alpha (drives _ALPHATEST_ON clip).
// _CROSS_CARD_VIEW_CULLING (DepthOnly view-angle card culling): CLOSED. Despite the name it is NOT a
//   vertex card-collapse — the b165 vertex position is byte-identical to the base b161 transform; the
//   keyword only adds octa-normal output (URP infra) plus a FRAGMENT view-angle alpha-clip threshold lift
//   (edge-on crossed cards fade out). Ported 1:1 from b166:81-87 (FoliageCrossCardClipThreshold + DepthOnly frag).

Shader "HGRP/Foliage/TreeFoliageCardMeshLOD_Fix" {
    Properties {
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 0
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        // Source default _CullMode = 2 (Front). Foliage cards are double-sided → default Both here.
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 0
        [HideInInspector] _ShadowCullMode ("Shadow Render Face", Float) = 0
        _ShadowBias ("Shadow Bias", Range(-5, 10)) = 0

        _BaseColor ("Base Color", Color) = (1, 1, 1, 1)
        _BaseColorMap ("Base Color (RGB) Coverage (A)", 2D) = "white" {}
        _BaseColorTintCover ("Base Color Tint Cover", Range(0, 1)) = 0
        _BaseColorBrighterScale ("Albedo Brighter", Range(1, 3)) = 1
        _RoughnessMin ("Roughness Min", Range(0, 1)) = 0
        _RoughnessMax ("Roughness Max", Range(0, 1)) = 1
        _OcclusionStrength ("AO Strength", Range(0, 1)) = 1
        _OcclusionShadow ("AO Affects Shadow", Range(0, 1)) = 0
        // Foliage is dielectric; expose Specular as the dielectric F0 scale (URP lighting infra).
        _Specular ("Specular Scale", Range(0, 1)) = 1

        _NormalMap ("Normal (RG) Roughness/SSS (B) AO (A)", 2D) = "bump" {}
        _NormalScale ("Normal Scale", Range(0, 3)) = 1
        // _TwoSidedNormal is a plain uniform in source ([ToggleUI], not a keyword) — it biases the
        // back-face normal-flip decision (b19:184); the flip itself is unconditional in the base blob.
        [ToggleUI] _TwoSidedNormal ("Invert Back-Face Normal", Float) = 0

        [Header(Fake Direct Shadow)]
        _FakeDirectionalShadowStrength ("Fake Dir Shadow Strength", Range(0, 2)) = 0
        _FakeDirectionalShadowPow ("Fake Dir Shadow Pow", Range(0.01, 5)) = 1

        [Header(Translucency)]
        _SubsurfaceIntensity ("Subsurface Intensity", Range(0, 1)) = 0
        _Transmission ("Transmission", Range(0, 1)) = 0.2
        [Toggle] _TransmissionDistanceFade ("Transmission Distance Fade", Float) = 0
        _backfaceGiIntensity ("Backface GI Intensity", Range(0, 0.5)) = 0

        [Header(Blossom Alpha)]
        [Toggle(_BLEND_COLOR)] _EnableBlendColor ("Blend Color (raw albedo, no tint-cover)", Float) = 0

        [Header(Sphere Shadow Proxy)]
        [Toggle(_USE_SPHERE_SHADOW_PROXY)] _UseSphereShadowProxy ("Use Sphere Shadow Proxy", Float) = 0
        _SphereShadowParams0 ("Sphere0 (XYZ=OS center, W=radius)", Vector) = (0, 0, 0, 1)
        _SphereShadowParams1 ("Sphere1 (XYZ=OS center, W=radius)", Vector) = (0, 0, 0, 1)
        _SphereShadowParams2 ("Sphere2 (XYZ=OS center, W=radius)", Vector) = (0, 0, 0, 1)
        _SphereShadowParams3 ("Sphere3 (XYZ=OS center, W=radius)", Vector) = (0, 0, 0, 1)
        _SphereShadowStrength ("Sphere Shadow Strength", Range(0, 1)) = 1
        _SphereShadowHardness ("Sphere Shadow Hardness", Range(0, 1)) = 0.5

        [Header(Alpha Test)]
        [Toggle(_ALPHATEST_ON)] _EnableAlphaTest ("Alpha Test", Float) = 0
        _AlphaClipThreshold ("Clip", Range(0, 1)) = 0.5
        _ShadowAlphaClipThreshold ("Shadow Clip", Range(0, 1)) = 0.2

        [Header(Leaf Offset)]
        [Toggle(_LEAF_OFFSET_COVER_TRUNK)] _EnableLeafCoverTrunk ("Leaf Card Covers Trunk", Float) = 0
        _LeafPartVertexOffset ("Leaf Part Vertex Offset", Range(0, 0.1)) = 0.05

        [Header(Cross Card View Culling)]
        // DepthOnly-pass feature: when a crossed billboard card is viewed edge-on, raise its alpha-clip
        // threshold toward 1.01 so the thin edge fades out. Source keyword lives only on the DepthOnly pass.
        [Toggle(_CROSS_CARD_VIEW_CULLING)] _CrossCardViewCulling ("Cross-Card View Culling", Float) = 0
        _CrossCardViewCullingThreshold ("View Culling Threshold", Range(0, 1)) = 0.1
        _CrossCardViewCullingFadeValue ("View Culling Fade", Range(0, 1)) = 0.8

        // _CardmeshCaptureMode 0 = Capture Transmission, 1 = Capture Roughness (b19:228 branch).
        [Enum(Capture Transmission, 0, Capture Roughness, 1)] _CardmeshCaptureMode ("Cardmesh Capture Mode", Float) = 0
    }

    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Opaque"
            "Queue"="Geometry"
        }
        LOD 600

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

        CBUFFER_START(UnityPerMaterial)
            float4 _BaseColor;
            float4 _BaseColorMap_ST;
            float4 _NormalMap_ST;
            float  _BaseColorTintCover;
            float  _BaseColorBrighterScale;
            float  _RoughnessMin;
            float  _RoughnessMax;
            float  _OcclusionStrength;
            float  _OcclusionShadow;
            float  _Specular;
            float  _NormalScale;
            float  _TwoSidedNormal;
            float  _FakeDirectionalShadowStrength;
            float  _FakeDirectionalShadowPow;
            float  _SubsurfaceIntensity;
            float  _Transmission;
            float  _TransmissionDistanceFade;
            float  _backfaceGiIntensity;
            // Sphere shadow proxy
            float4 _SphereShadowParams0;
            float4 _SphereShadowParams1;
            float4 _SphereShadowParams2;
            float4 _SphereShadowParams3;
            float  _SphereShadowStrength;
            float  _SphereShadowHardness;
            // Alpha test
            float  _AlphaClipThreshold;
            float  _ShadowAlphaClipThreshold;
            // Leaf offset
            float  _LeafPartVertexOffset;
            float  _CardmeshCaptureMode;
            // Cross-card view culling (DepthOnly-pass alpha-clip threshold modulation, b166:35-36)
            float  _CrossCardViewCullingThreshold;
            float  _CrossCardViewCullingFadeValue;
            // NOTE: _ShadowBias is NOT declared here — URP's Shadows.hlsl owns the global `float4 _ShadowBias`
            //   (x=depth bias, y=normal bias), driven by light/shadow settings and consumed by ApplyShadowBias.
            //   The source's per-material Offset[_ShadowBias] (Properties) has no URP CBUFFER analog; declaring
            //   it here collides with URP's global (redefinition). Kept as an inspector-only Property no-op.
        CBUFFER_END

        TEXTURE2D(_BaseColorMap);   SAMPLER(sampler_BaseColorMap);
        TEXTURE2D(_NormalMap);      SAMPLER(sampler_NormalMap);

        // Decoded magic constants (denormalized-float → real value), blob authority cited inline:
        // 0.001956947147846221923828125 = 1/511 (octahedral 10-bit decode) — vertex path, dropped here.
        // 0.100000001490116119384765625  = 0.1  (transmission distance-fade slope, b19:224)
        // 0.800000011920928955078125     = 0.8  (roughness capture-transmission blend, b19:231)
        // 1.1754943508222875079687365372222e-38 = FLT_MIN (normalize rsqrt guard, b19:217,229)
        // 9.9999999392252902907785028219223e-09  = 1e-8 (denominator epsilon)
        static const float FLT_MIN_GUARD = 1.1754943508222875079687365372222e-38;
        static const float HGRP_EPS_VIS      = 9.9999997473787516355514526367188e-05; // = 1e-4 ; Smith-vis denom floor, b9:981
        static const float HGRP_GRAZING_FLOOR = 0.0476190485060214996337890625;       // = 1/21 ; multiscatter-diffuse grazing floor, b9:977-979

        // ------------------------------------------------------------------
        // HG deferred-lighting BRDF energy (CoreMath.hlsl, ground truth litforward/Sub0_Pass0_Fragment_b9).
        // The foliage GBuffer blob (b19/b25) has NO lighting — it packs surface params consumed by HG's
        // deferred lit pass, which is the SAME math as the lit family. To light foliage faithfully in the
        // forward port we mirror that exact energy model (CORE_MATH §1.4 substitution), NOT a bespoke poly.
        // ------------------------------------------------------------------
        // §2.6 env-BRDF F0 scale/bias for ambient reflection (b9:326-329,1261).
        void HgEnvBRDF(float roughness, float NoV, float3 f0, out float envSpecScale, out float envSpecBias)
        {
            float oneMinusRough = mad(roughness, -1.0, 1.0);                                       // 1-rough, b9:326 (_520)
            float envF = mad(min(oneMinusRough * oneMinusRough, exp2(NoV * -9.27999973297119140625)),
                             oneMinusRough,
                             mad(roughness, -0.0274999998509883880615234375, 0.0425000004470348358154296875)); // b9:328 (_536)
            envSpecScale = mad(envF, -1.03999996185302734375,
                               mad(roughness, -0.572000026702880859375, 1.03999996185302734375));               // b9:329 (_537)
            envSpecBias  = mad(envF, 1.03999996185302734375,
                               mad(roughness, 0.02199999988079071044921875, -0.039999999105930328369140625))
                         * saturate(f0.g * 50.0);                                                               // b9:1261 (_3103)
        }
        // §2.6 analytic split-sum DFG (Karis/Lazarov EnvBRDFApprox) (b9:974-975, _2183).
        float HgEnvBRDFApproxDFG(float roughness)
        {
            float t = mad(roughness, -1.0, 1.0);                                                   // 1-rough, b9:974 (_2174)
            return min(mad(t, mad(t, mad(-t, 0.38302600383758544921875, -0.076194703578948974609375),
                                  1.04997003078460693359375),
                           0.4092549979686737060546875),
                       0.999000012874603271484375);                                                // b9:975 (_2183)
        }
        // §2.7 Cook-Torrance GGX-D + Smith height-correlated Vis + Schlick F (b9:964-983). Returns (D*Vis)*F.
        float3 HgDirectSpecular(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
        {
            float a   = roughness * roughness;                                                     // b9:967 (_2159)
            float a2  = a * a;                                                                     // b9:968 (_2160)
            float nv  = min(NoV, 1.0);                                                             // b9:966 (_2158)
            float d   = mad(mad(NoH, a2, -NoH), NoH, 1.0);                                         // b9:969 (_2163)
            float visDenom = nv  * sqrt(mad(mad(-NoL, a2, NoL), NoL, a2))
                           + NoL * sqrt(mad(mad(-nv,  a2, nv ), nv , a2))
                           + HGRP_EPS_VIS;                                                         // b9:981 (_2217)
            float DV  = (a2 / (d * d)) * (0.5 / visDenom);
            float oneMinusVoH = mad(-VoH, 1.0, 1.0);                                               // 1-VoH, b9:970 (_2169)
            float sq   = oneMinusVoH * oneMinusVoH;
            float quad = sq * sq;
            float Fc   = oneMinusVoH * quad;                                                       // (1-VoH)^5, b9:973 (_2172)
            float oneMinusFc = mad(-quad, oneMinusVoH, 1.0);                                       // b9:980 (_2198)
            float3 F   = mad(f0, oneMinusFc.xxx, Fc.xxx);                                          // lerp(F0,1,Fc), b9:983
            return DV * F;
        }
        // §2.7 full per-light energy bracket: min(max(msDiff + min(spec,2048),0),1000) (b9:975-983).
        float3 HgDirectLightEnergy(float roughness, float3 f0, float NoL, float NoH, float NoV, float VoH)
        {
            float3 specE = HgDirectSpecular(roughness, f0, NoL, NoH, NoV, VoH);                    // (D*Vis)*F, b9:981·983
            float  dfg   = HgEnvBRDFApproxDFG(roughness);                                          // b9:975 (_2183)
            float  oneMinusDfg = mad(-dfg, 1.0, 1.0);                                              // 1-dfg, b9:976 (_2186)
            float  dfgEnergy = dfg / oneMinusDfg;                                                  // analytic _2240 (T9 product -> dfg)
            float3 gz    = mad((1.0.xxx - f0), HGRP_GRAZING_FLOOR, f0);                            // lerp(F0,1,1/21), b9:977-979 (_2193)
            float3 msDiff = (dfgEnergy * (gz * gz)) / mad(-gz, oneMinusDfg.xxx, 1.0.xxx);          // b9:983 term A
            return min(max(msDiff + min(specE, 2048.0), 0.0), 1000.0);                             // b9:983 clamp
        }

        struct Attributes {
            float3 positionOS : POSITION;
            float3 normalOS   : NORMAL;
            float4 tangentOS  : TANGENT;
            float4 color      : COLOR;
            float2 uv0        : TEXCOORD0;
        };

        struct Varyings {
            float4 positionCS : SV_POSITION;
            float3 positionWS : TEXCOORD0;
            float2 uv         : TEXCOORD1;
            float3 normalWS   : TEXCOORD2;
            float4 tangentWS  : TEXCOORD3;   // .xyz tangent, .w handedness sign
            float4 color      : TEXCOORD4;
            float3 positionOS : TEXCOORD5;   // object-space pos for sphere-shadow proxy (blob TEXCOORD_7)
        };

        // ------------------------------------------------------------------
        // Leaf-part vertex offset (b28:198-203,258-260, _LEAF_OFFSET_COVER_TRUNK).
        // Pushes leaf cards along their world normal, away from the view, to cover trunk.
        //   viewDot = dot(-cameraForward, N)
        //   offsetMag = (1 - color.x) * _LeafPartVertexOffset * -sign(viewDot)
        //   positionWS += (offsetMag * N) * (1 - unity_ObjectToWorld._m01)   // _279 scale, b28:203/258
        // ------------------------------------------------------------------
        float3 ApplyLeafOffset(float3 positionWS, float3 normalWS, float colorX)
        {
        #ifdef _LEAF_OFFSET_COVER_TRUNK
            float3 camFwd = -UNITY_MATRIX_V[2].xyz;                       // -_ViewMatrix[*].z (camera forward WS), b28:198
            float viewDot = dot(camFwd, normalWS);
            float offsetMag = ((1.0 - colorX) * _LeafPartVertexOffset) * (-sign(viewDot)); // _271, b28:199
            // _279 = 1 - unity_ObjectToWorld[1u].x (= 1 - _m01, world-X of the object's local-Y axis); the
            //   blob scales the whole offset term by it at b28:258-260 mad(_272,_279,base). 1:1 (= 1 for
            //   upright/unrotated instances; orientation-dependent by design).
            float m01 = unity_ObjectToWorld._m01;                        // O2W[1u].x (column-major col1.x), b28:203
            float offsetScale = 1.0 - m01;                              // _279, b28:203
            positionWS = mad(offsetMag * offsetScale, normalWS, positionWS); // b28:258-260 (offset*N*_279 + posWS)
        #endif
            return positionWS;
        }

        Varyings vertForward(Attributes IN)
        {
            Varyings OUT = (Varyings)0;
            VertexPositionInputs posIn = GetVertexPositionInputs(IN.positionOS);
            VertexNormalInputs   nrmIn = GetVertexNormalInputs(IN.normalOS, IN.tangentOS);

            float3 positionWS = ApplyLeafOffset(posIn.positionWS, nrmIn.normalWS, IN.color.x);

            OUT.positionWS = positionWS;
            OUT.positionCS = TransformWorldToHClip(positionWS);
            OUT.uv         = TRANSFORM_TEX(IN.uv0, _BaseColorMap);
            OUT.normalWS   = nrmIn.normalWS;
            // tangent sign: blob VS folds sign(_f_0[5].w) into tangent.w (b18:237); URP's
            // GetOddNegativeScale × tangentOS.w is the faithful handedness for the TBN cross.
            OUT.tangentWS  = float4(nrmIn.tangentWS, IN.tangentOS.w * GetOddNegativeScale());
            OUT.color      = IN.color;
            OUT.positionOS = IN.positionOS;
            return OUT;
        }

        // ------------------------------------------------------------------
        // Surface struct produced from the 2 foliage maps (GBuffer base b19/b25 math, 1:1).
        // ------------------------------------------------------------------
        struct FoliageSurface {
            float3 albedo;
            float3 normalWS;
            float  roughness;     // linear (perceptual) roughness
            float  occlusion;     // final AO (b19 _373)
            float  transmission;  // translucency amount (b19 _357/_358)
            float  subsurface;    // SSS intensity, leaf-gated (b19 _514 source)
            float  backfaceGi;    // ambient backface boost, leaf-gated (b19 _452 source)
            float  alpha;         // base coverage (A of _BaseColorMap)
        };

        FoliageSurface BuildFoliageSurface(Varyings IN, bool isFrontFace)
        {
            FoliageSurface s = (FoliageSurface)0;

            // tangent handedness sign _85 = (tangent.w > 0) ? +1 : -1   (b19:183)
            float tangentSign = (IN.tangentWS.w > 0.0) ? 1.0 : -1.0;

            // two-sided front sign _92 (b19:184), unconditional in the base blob:
            //   frontFace → +1 ; back → ((color.x + _TwoSidedNormal + color.y) >= 0.5) ? -1 : +1
            float frontSign = isFrontFace ? 1.0
                            : (((IN.color.x + _TwoSidedNormal + IN.color.y) >= 0.5) ? -1.0 : 1.0);

            // --- BASE COLOR / albedo (T0 = _BaseColorMap, b19:185-195) ---
            // URP SAMPLE_TEXTURE2D_BIAS folds _GlobalMipBias.x (= HGRP "_GlobalMipBias") automatically.
            float4 baseTex = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, IN.uv, 0.0);
            float3 albedoRaw = baseTex.xyz;                              // _105,_106,_107

            // tint-cover toward flat _BaseColor (b19:190-195). _110 = color.x != 0 (leaf gate):
            //   leaf  (color.x!=0) → raw albedo
            //   trunk (color.x==0) → lerp(saturate(raw*_BaseColor*Brighter), _BaseColor, _BaseColorTintCover)
            float3 albedoTrunkBase = saturate(albedoRaw * _BaseColor.xyz * _BaseColorBrighterScale); // _129..131
            float3 albedoTrunk = mad(_BaseColorTintCover.xxx, (_BaseColor.xyz - albedoTrunkBase), albedoTrunkBase); // _193..195
            bool   isLeaf = IN.color.x != 0.0;                          // _110
            float3 albedo;
        #ifdef _BLEND_COLOR
            // _BLEND_COLOR (b23:263-265): output RAW base-color sample, no tint-cover blend.
            albedo = albedoRaw;
        #else
            albedo = isLeaf ? albedoRaw : albedoTrunk;                  // b19:193-195
        #endif

            // --- NORMAL / roughness-source / AO  (T1 = _NormalMap, b19:196-227) ---
            float4 nrm = SAMPLE_TEXTURE2D_BIAS(_NormalMap, sampler_NormalMap, IN.uv, 0.0);
            float nrmRough = nrm.z;                                      // _171 (B = roughness/transmission src)
            float nrmAO    = nrm.w;                                     // _172 (A = ambient occlusion)
            // DXT-style tangent-normal decode with derived length (b19:199-213):
            //   nx0 = 2*r-1 ; ny0 = 2*g-1
            //   len2 = 1 - nx0^2 - ny0^2 ; len = sqrt(len2) ; nz = 2*len2 - 1
            //   nx = 2*len*nx0*_NormalScale ; ny = 2*len*ny0*_NormalScale
            float nx0 = mad(nrm.x, 2.0, -1.0);                          // _173
            float ny0 = mad(nrm.y, 2.0, -1.0);                          // _176
            float len2 = 1.0 - nx0 * nx0 - ny0 * ny0;                   // _182 = dot((nx,ny,1),(-nx,-ny,1))
            float lenN = sqrt(len2);                                    // _185
            float nz0 = mad(len2, 2.0, -1.0);                           // _190
            float nx = (mad(lenN * nx0, 2.0, 0.0)) * _NormalScale;     // _194
            float ny = (mad(lenN * ny0, 2.0, 0.0)) * _NormalScale;     // _195
            // normalize (nx,ny,nz0), then apply two-sided sign to the tangent-plane xy (b19:206-213):
            float invTb = rsqrt(dot(float3(nx, ny, nz0), float3(nx, ny, nz0))); // _199
            float tnZ = invTb * nz0;                                    // _202
            float tnX = frontSign * (invTb * nx);                      // _203 (= _92 * ...)
            float tnY = frontSign * (invTb * ny);                     // _204
            float invTb2 = rsqrt(dot(float3(tnX, tnY, tnZ), float3(tnX, tnY, tnZ))); // _208
            tnX *= invTb2; tnY *= invTb2; tnZ *= invTb2;               // _209,_210,_211

            // TBN → world normal (b19:214-227). N=TEXCOORD_2, T=TEXCOORD_3.xyz,
            // B = tangentSign * cross(N, T) (the _85-scaled cross terms), then ×frontSign & normalize.
            float3 N = IN.normalWS;
            float3 T = IN.tangentWS.xyz;
            float3 B = tangentSign * cross(N, T);                       // _85 * (N×T) per component, b19:214-216
            float3 nWS = T * tnX + B * tnY + N * tnZ;                   // _266,_267,_268
            float invN = rsqrt(max(dot(nWS, nWS), FLT_MIN_GUARD));     // _274
            float3 normalWS = frontSign * (nWS * invN);                // _278,_279,_280 (= _92 * ...)

            // --- distance fade for transmission (b19:221-225) ---
            // distFade = (_TransmissionDistanceFade!=0) ? smoothstep01(saturate((dist-60)*-0.1)) : 1
            float3 camToObj = _WorldSpaceCameraPos - unity_ObjectToWorld._m03_m13_m23; // _299..301 (cam - obj origin)
            float objDist = sqrt(dot(camToObj, camToObj));
            float distT = saturate((objDist - 60.0) * -0.100000001490116119384765625); // _310
            float distFade = (_TransmissionDistanceFade != 0.0)
                           ? (distT * distT) * mad(distT, -2.0, 3.0)   // smoothstep poly _318
                           : 1.0;

            // --- roughness + transmission, branched by capture mode (b19:228-237) ---
            float transmission, roughnessLin;
            if (_CardmeshCaptureMode < 0.5)
            {
                transmission = distFade * (nrmRough * _Transmission);                          // _357
                roughnessLin = mad((_RoughnessMax - _RoughnessMin), 0.800000011920928955078125, _RoughnessMin); // _358
            }
            else
            {
                transmission = distFade * _Transmission;                                       // _357
                roughnessLin = mad(nrmRough, (_RoughnessMax - _RoughnessMin), _RoughnessMin);  // _358
            }

            // --- occlusion (b19:238-239) ---
            // occBase = saturate(mad(nrmAO, _OcclusionStrength, 1 - _OcclusionStrength)) = lerp(1-? ); _368
            // ao = lerp(occBase, nrmAO, color.x)  (leaf uses raw AO, trunk uses strength-scaled)   _373
            float occBase = saturate(mad(nrmAO, _OcclusionStrength, 1.0 - _OcclusionStrength)); // _368
            float ao = mad(IN.color.x, (nrmAO - occBase), occBase);    // _373

            s.albedo       = albedo;
            s.normalWS     = normalWS;
            s.roughness    = roughnessLin;
            s.occlusion    = ao;
            s.transmission = transmission;
            // subsurface (b19:260) & backface GI (b19:247) are leaf-gated: lerp(value, 0, color.x):
            s.subsurface   = mad(IN.color.x, -_SubsurfaceIntensity, _SubsurfaceIntensity);  // _514 source
            s.backfaceGi   = mad(IN.color.x, -_backfaceGiIntensity, _backfaceGiIntensity);  // _452 source
            s.alpha        = baseTex.w;
            return s;
        }

        // ------------------------------------------------------------------
        // Fake directional shadow (b19:264-265, b25:315).
        //   fake = saturate(1 - _FakeDirectionalShadowStrength * pow(NoL*0.5+0.5, _FakeDirectionalShadowPow))
        //        × (1 + _OcclusionShadow*(ao-1))
        // NoL here uses the FAKE (capture-time) light dir baked into the surface — we substitute the URP
        // main-light dir (the faithful "the one directional light" infra map, CORE_MATH §2.7).
        // ------------------------------------------------------------------
        float ComputeFakeDirShadow(float3 normalWS, float3 lightDir, float ao)
        {
            float NoL = dot(normalWS, lightDir);                        // _557 dot
            float wrap = mad(NoL, 0.5, 0.5);                            // mad(...,0.5,0.5)
            // exp2(log2(wrap) * pow) == pow(wrap, _FakeDirectionalShadowPow)  (b19:265 spelling)
            float shaped = exp2(log2(wrap) * _FakeDirectionalShadowPow);
            float fake = saturate(mad(-shaped, _FakeDirectionalShadowStrength, 1.0)); // _557
            float aoShadow = mad(_OcclusionShadow, ao - 1.0, 1.0);     // _536
            return fake * aoShadow;
        }

        // ------------------------------------------------------------------
        // Sphere-shadow proxy (b25:254-316, _USE_SPHERE_SHADOW_PROXY).
        // For each sphere i: d = sphereCenter.xyz - positionOS ; project onto shading normal frame
        //   along = dot(N, d)  (clamped ≥0) ;  perp = d - along*N
        //   occ_i = 1 - saturate( (length(max0(along)·N-axis residual) - radius) / (1.001 - hardness) )
        // result factor = 1 - _SphereShadowStrength * min(dot(occ4,occ4), 1)
        // The blob projects d into the per-component object→world basis (b25:247-253 _417/_418/_419 = the
        // object-space dir of the FAKE light, normalized). We faithfully reproduce its geometry: build the
        // 3 basis dots, take max0 of the along-light component, residual perp, distance to sphere surface.
        // ------------------------------------------------------------------
        float ComputeSphereShadow(float3 positionOS, float3 lightDirWS)
        {
        #ifdef _USE_SPHERE_SHADOW_PROXY
            // _417/_418/_419: light dir expressed in object basis rows, normalized (b25:247-251).
            float3 lo = float3(
                dot(lightDirWS, unity_ObjectToWorld._m00_m10_m20),     // _384
                dot(lightDirWS, unity_ObjectToWorld._m01_m11_m21),     // _397
                dot(lightDirWS, unity_ObjectToWorld._m02_m12_m22));    // _410
            lo = lo * rsqrt(dot(lo, lo));                              // _416 normalize → _417,_418,_419

            float invHard = 1.00100004673004150390625 - _SphereShadowHardness; // _593 (1.001 - hardness)

            float4 occ;
            UNITY_UNROLL
            for (int i = 0; i < 4; ++i)
            {
                float4 sph = (i == 0) ? _SphereShadowParams0
                           : (i == 1) ? _SphereShadowParams1
                           : (i == 2) ? _SphereShadowParams2 : _SphereShadowParams3;
                float3 d = sph.xyz - positionOS;                        // _427/_458/_486 (center - posOS)
                float along = dot(lo, d);                              // _516 (signed along-light dist)
                // residual = d - along*lo  (per b25:274-285, mad(-along, lo, d_component))
                float3 resid = mad(-along.xxx, lo, d);                 // _528,_536,_544
                float alongMax = max(along, 0.0);                     // _520
                // distance to sphere surface along the proxy axis (b25:287):
                float distAxis = sqrt(alongMax * alongMax + dot(resid, resid)); // sqrt(max0^2 + |resid|^2)
                occ[i] = 1.0 - saturate((distAxis - sph.w) / invHard); // _607..610
            }
            // factor = 1 - strength * min(dot(occ,occ), 1)   (b25:316)
            return mad(_SphereShadowStrength, -min(dot(occ, occ), 1.0), 1.0);
        #else
            return 1.0;
        #endif
        }

        // ------------------------------------------------------------------
        // Forward lighting composite = HG deferred lit model (CoreMath.hlsl / b9), since the foliage GBuffer
        // surface is consumed by HG's deferred lit pass. URP infra substitution for the deferred pack:
        //   - Direct = HgDirectLightEnergy (GGX-D + Smith-Vis + Schlick-F + multiscatter diffuse), b9:975-983.
        //   - Ambient diffuse = SampleSH(N)*AO, boosted on backfaces by s.backfaceGi (b19 _452 intent), b9:1325 A.
        //   - Ambient spec = GlossyEnvironmentReflection * (f0*envSpecScale+envSpecBias), un-occluded, b9:1325 B.
        //   - Translucency: back-lit transmission term added (s.transmission), wrapped NoL (foliage-specific).
        //   - Fake directional shadow × sphere shadow modulate the direct term, LEAF-GATED (trunk-only) per
        //     b19:267/b25:318 — the source's deferred SV_Target_2 shadow channels lit by HG deferred light.
        // ------------------------------------------------------------------
        float4 LitComposite(Varyings IN, FoliageSurface s)
        {
            float3 N = s.normalWS;
            float3 V = GetWorldSpaceNormalizeViewDir(IN.positionWS);

            // PBR split (CORE_MATH §2.3): dielectric F0 = 0.08*_Specular; foliage metallic = 0.
            float3 diffuseColor = s.albedo;                            // metallic 0 → diffuse = albedo
            float3 f0 = (0.07999999821186065673828125 * _Specular).xxx; // 0.08*_Specular
            float perceptualRoughness = s.roughness;

            float4 shadowCoord = TransformWorldToShadowCoord(IN.positionWS);
            Light mainLight = GetMainLight(shadowCoord);
            float3 L = mainLight.direction;

            float fakeShadow  = ComputeFakeDirShadow(N, L, s.occlusion);          // b19:264-265 (_795 = _557*_536)
            float sphereShadow = ComputeSphereShadow(IN.positionOS, L);           // b25:316 (_804)
            // LEAF GATE (b19:267 / b25:318): the fake-dir + sphere shadow (incl. AO-affects-shadow) is
            // packed as lerp(fakeShadow*sphereShadow, 1.0, color.x) — i.e. TRUNK-only (color.x==0). Leaf
            // cards (color.x==1) are fully exempt (factor 1.0). Reproduce that gate, do NOT apply to leaves.
            float trunkShadow = lerp(fakeShadow * sphereShadow, 1.0, IN.color.x); // b19:267 mad(color.x, 1-_795*_804, _795*_804)
            float atten = mainLight.shadowAttenuation * mainLight.distanceAttenuation
                        * trunkShadow;

            float NoV = max(dot(N, V), 0.0);                          // b9:327 (_531)

            // --- Ambient SPECULAR env-BRDF (b9:326-329,1261). HG uses envSpecScale/envSpecBias, NOT the
            //     raw DFG poly; the reflection is NOT occluded (b9:1325 term B passes occlusion=1). ---
            float envSpecScale, envSpecBias;
            HgEnvBRDF(perceptualRoughness, NoV, f0, envSpecScale, envSpecBias);   // b9:326-329,1261
            float3 R = reflect(-V, N);                                            // b9:578-582 (_991..993)
            float3 envRefl = GlossyEnvironmentReflection(R, IN.positionWS, perceptualRoughness, 1.0); // occ=1, b9:1325 term B
            float3 envSpec = envRefl * (f0 * envSpecScale + envSpecBias);         // b9:1325 term B

            // --- Ambient DIFFUSE = SH(N), AO-weighted, backface-GI boosted (b19 _452 backface-GI channel). ---
            float3 ambient = SampleSH(N) * (1.0 + s.backfaceGi);
            float3 ambientDiffuse = ambient * diffuseColor * s.occlusion;        // b9:1325 term A

            // --- Direct MAIN light: full HG energy bracket (multiscatter diffuse + spec), b9:983.
            //     out = (energy*NoL + diffuse*NoL) * lightColor * atten   (leaf-gated atten from above). ---
            float3 H  = normalize(L + V);                                         // b9:957-963
            float NoL = saturate(dot(L, N));                                      // b9:964 (_2153)
            float NoH = saturate(dot(N, H));                                      // b9:965 (_2157)
            float VoH = saturate(dot(V, H));                                      // b9:970
            float3 energy = HgDirectLightEnergy(perceptualRoughness, f0, NoL, NoH, NoV, VoH); // b9:975-983
            float3 directLight = mad(energy, NoL.xxx, diffuseColor * NoL) * (atten * mainLight.color); // b9:983

            // Additional (punctual) lights — same energy bracket (b9:1228-1234). Plain indexed loop (no
            // LIGHT_LOOP_BEGIN macro, which couples to InputData/cluster state we don't build). Fake/sphere
            // shadow are main-light-only (the source's directional fake-shadow has no punctual analog).
        #ifdef _ADDITIONAL_LIGHTS
            uint pixelLightCount = GetAdditionalLightsCount();
            for (uint lightIndex = 0u; lightIndex < pixelLightCount; ++lightIndex)
            {
                Light light = GetAdditionalLight(lightIndex, IN.positionWS);
                float3 Li = light.direction;
                float3 Hi = normalize(Li + V);
                float NoLi = saturate(dot(Li, N));
                float NoHi = saturate(dot(N, Hi));
                float VoHi = saturate(dot(V, Hi));
                float3 energyi = HgDirectLightEnergy(perceptualRoughness, f0, NoLi, NoHi, NoV, VoHi);
                float atteni = light.distanceAttenuation * light.shadowAttenuation;
                directLight += mad(energyi, NoLi.xxx, diffuseColor * NoLi) * (atteni * light.color);
            }
        #endif

            // Translucency / transmission: back-lit wrap term (foliage light through leaf).
            // s.transmission is the blob transmission amount (b19 _357); apply as -L lit diffuse.
            float backNoL = saturate(dot(-N, L));
            float3 translucency = diffuseColor * (s.transmission * backNoL) * mainLight.color * mainLight.shadowAttenuation;

            float3 color = ambientDiffuse + envSpec + directLight + translucency;
            return float4(color, s.alpha);
        }

        // Alpha clip helper (forward + depth + depthnormals). Base GBuffer frag does NOT clip; the clip
        // lives in the keyword branch (shadow uses _ShadowAlphaClipThreshold, b114:67). Forward/depth use
        // _AlphaClipThreshold against _BaseColorMap.a (the coverage channel).
        void FoliageAlphaClip(float2 uv)
        {
        #ifdef _ALPHATEST_ON
            float coverage = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, uv, 0.0).w;
            clip(coverage - _AlphaClipThreshold);
        #endif
        }

        // ------------------------------------------------------------------
        // Cross-card view culling (DepthOnly pass, _CROSS_CARD_VIEW_CULLING; b166:81-87).
        // Crossed billboard cards seen edge-on show a thin sliver; this lifts the alpha-clip
        // threshold toward 1.01 (>1 ⇒ everything clips ⇒ card vanishes) as the card turns edge-on.
        //   camFwd     = normalize(_ViewMatrix[*].z)            (view-Z basis, world space; abs() ⇒ sign-free)
        //   faceOn     = abs(dot(camFwd, normalWS))             (1 = facing camera, 0 = edge-on)
        //   t          = clamp( ((1-fade) + faceOn - threshold) / ((1-fade)+(1-fade)), 0, 1 )   (b166:81,86)
        //   s          = t*t*(3 - 2*t)                          (smoothstep, b166:87)
        //   clipThresh = lerp(1.0099999904632568359375, _AlphaClipThreshold, s)                 (b166:87)
        // Returns the (possibly raised) clip threshold; with the keyword off it is _AlphaClipThreshold.
        // ------------------------------------------------------------------
        float FoliageCrossCardClipThreshold(float3 normalWS)
        {
        #ifdef _CROSS_CARD_VIEW_CULLING
            // _58 = -1 + fade  (b166:81). camera-forward = view matrix row-2 (== _ViewMatrix[*].z), normalized.
            float cardFade = _CrossCardViewCullingFadeValue;
            float negFadeBias = -1.0 + cardFade;                                       // _58, b166:81
            float3 viewFwdRow = UNITY_MATRIX_V[2].xyz;                                 // (_ViewMatrix[0].z,[1].z,[2].z), b166:82-84
            float  invLen = rsqrt(max(dot(viewFwdRow, viewFwdRow), FLT_MIN_GUARD));    // _90, b166:85
            float3 camFwd = invLen * viewFwdRow;
            float  faceOn = abs(dot(camFwd, normalWS));                                // |dot(camFwd,N)|, b166:86
            // _117 = clamp( ((-_58) + (faceOn - threshold)) * (1 / ((-_58) + (1 - fade))), 0, 1 )  (b166:86)
            float  denom = (-negFadeBias) + (1.0 - cardFade);                          // = 2*(1-fade)
            float  t = clamp(((-negFadeBias) + (faceOn - _CrossCardViewCullingThreshold)) * (1.0 / denom), 0.0, 1.0);
            float  s = (t * t) * mad(t, -2.0, 3.0);                                    // smoothstep poly, b166:87
            // lerp(1.0099999904632568359375, _AlphaClipThreshold, s) = mad(s, AlphaClip-1.01, 1.01)
            return mad(s, -1.0099999904632568359375 + _AlphaClipThreshold, 1.0099999904632568359375); // b166:87
        #else
            return _AlphaClipThreshold;
        #endif
        }

        // Cross-card-aware alpha clip used only by the DepthOnly pass (where the source keyword lives).
        void FoliageDepthAlphaClip(float2 uv, float3 normalWS)
        {
        #ifdef _ALPHATEST_ON
            float coverage = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, uv, 0.0).w;
            clip(coverage - FoliageCrossCardClipThreshold(normalWS));                  // b166:87 (base path: threshold = _AlphaClipThreshold)
        #endif
        }
        ENDHLSL

        // =====================================================================
        // FORWARD  (HGRP GBuffer surface → URP forward lighting)
        // Source render-state: ZClip On, ZTest [_ZTestGBuffer], Cull [_CullMode],
        //   Stencil Ref/Replace (deferred material-id — dropped in forward).
        // =====================================================================
        Pass {
            Name "ForwardLit"
            Tags { "LightMode"="UniversalForwardOnly" }
            ZTest LEqual
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vertForward
            #pragma fragment fragForward

            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local _BLEND_COLOR
            #pragma shader_feature_local _USE_SPHERE_SHADOW_PROXY
            #pragma shader_feature_local _LEAF_OFFSET_COVER_TRUNK

            #pragma multi_compile _ _MAIN_LIGHT_SHADOWS _MAIN_LIGHT_SHADOWS_CASCADE _MAIN_LIGHT_SHADOWS_SCREEN
            #pragma multi_compile_fragment _ _SHADOWS_SOFT
            #pragma multi_compile _ _ADDITIONAL_LIGHTS_VERTEX _ADDITIONAL_LIGHTS
            #pragma multi_compile_fragment _ _ADDITIONAL_LIGHT_SHADOWS
            #pragma multi_compile_fragment _ _REFLECTION_PROBE_BLENDING
            #pragma multi_compile _ LIGHTMAP_ON
            #pragma multi_compile_fog

            float4 fragForward(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                FoliageAlphaClip(IN.uv);
                FoliageSurface s = BuildFoliageSurface(IN, isFrontFace);
                float4 col = LitComposite(IN, s);
                col.rgb = MixFog(col.rgb, ComputeFogFactor(IN.positionCS.z));
                return col;
            }
            ENDHLSL
        }

        // =====================================================================
        // SHADOW CASTER  (source: vert b111 / b113 +_ALPHATEST_ON; frag b112 empty / b114 clip)
        //   Source: Cull [_ShadowCullMode], Offset [_ShadowBias],0. URP ApplyShadowBias is the
        //   faithful substitute for HG's shadow-VP baked bias (CORE_MATH §4.1).
        // =====================================================================
        Pass {
            Name "ShadowCaster"
            Tags { "LightMode"="ShadowCaster" }
            ZWrite On
            ZTest LEqual
            ColorMask 0
            Cull [_ShadowCullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vertShadow
            #pragma fragment fragShadow
            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local _LEAF_OFFSET_COVER_TRUNK
            #pragma multi_compile_vertex _ _CASTING_PUNCTUAL_LIGHT_SHADOW

            float3 _LightDirection;
            float3 _LightPosition;

            struct ShadowAttributes {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 color      : COLOR;
                float2 uv0        : TEXCOORD0;
            };
            struct ShadowVaryings {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
            };

            ShadowVaryings vertShadow(ShadowAttributes IN)
            {
                ShadowVaryings OUT = (ShadowVaryings)0;
                float3 positionWS = TransformObjectToWorld(IN.positionOS);
                float3 normalWS   = TransformObjectToWorldNormal(IN.normalOS);
                positionWS = ApplyLeafOffset(positionWS, normalWS, IN.color.x);   // b115 keeps the leaf offset

            #if _CASTING_PUNCTUAL_LIGHT_SHADOW
                float3 lightDirectionWS = normalize(_LightPosition - positionWS);
            #else
                float3 lightDirectionWS = _LightDirection;
            #endif
                float4 positionCS = TransformWorldToHClip(ApplyShadowBias(positionWS, normalWS, lightDirectionWS));
            #if UNITY_REVERSED_Z
                positionCS.z = min(positionCS.z, UNITY_NEAR_CLIP_VALUE);
            #else
                positionCS.z = max(positionCS.z, UNITY_NEAR_CLIP_VALUE);
            #endif
                OUT.positionCS = positionCS;
                OUT.uv = TRANSFORM_TEX(IN.uv0, _BaseColorMap);
                return OUT;
            }

            float4 fragShadow(ShadowVaryings IN) : SV_Target
            {
                // Shadow uses _ShadowAlphaClipThreshold (b114:67), NOT _AlphaClipThreshold.
            #ifdef _ALPHATEST_ON
                float coverage = SAMPLE_TEXTURE2D_BIAS(_BaseColorMap, sampler_BaseColorMap, IN.uv, 0.0).w;
                clip(coverage - _ShadowAlphaClipThreshold);
            #endif
                return 0;
            }
            ENDHLSL
        }

        // =====================================================================
        // DEPTH ONLY  (source: vert b159 / frag b160 empty). Forward+ / depth-prepass.
        // =====================================================================
        Pass {
            Name "DepthOnly"
            Tags { "LightMode"="DepthOnly" }
            ZWrite On
            ColorMask R
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vertDepth
            #pragma fragment fragDepth
            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local _LEAF_OFFSET_COVER_TRUNK
            #pragma shader_feature_local _CROSS_CARD_VIEW_CULLING

            struct DepthAttributes {
                float3 positionOS : POSITION;
                float3 normalOS   : NORMAL;
                float4 color      : COLOR;
                float2 uv0        : TEXCOORD0;
            };
            struct DepthVaryings {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;
                float3 normalWS   : TEXCOORD1;   // geometric world normal for _CROSS_CARD_VIEW_CULLING (b165 decoded TEXCOORD_1_1)
            };

            DepthVaryings vertDepth(DepthAttributes IN)
            {
                DepthVaryings OUT = (DepthVaryings)0;
                float3 positionWS = TransformObjectToWorld(IN.positionOS);
                float3 normalWS   = TransformObjectToWorldNormal(IN.normalOS);
                positionWS = ApplyLeafOffset(positionWS, normalWS, IN.color.x);
                OUT.positionCS = TransformWorldToHClip(positionWS);
                OUT.uv = TRANSFORM_TEX(IN.uv0, _BaseColorMap);
                // _CROSS_CARD_VIEW_CULLING: b165 decodes the packed-octahedral vertex normal and outputs it
                //   as TEXCOORD_1_1 (b165:219-222). The URP-infra substitute for that octa decode is
                //   TransformObjectToWorldNormal (the geometric world normal); the view-angle clip math
                //   itself lives in the fragment (b166:81-87), gated below.
                OUT.normalWS = normalWS;
                return OUT;
            }

            float4 fragDepth(DepthVaryings IN) : SV_Target
            {
                // Base path: plain alpha clip (b162:69). With _CROSS_CARD_VIEW_CULLING the clip threshold is
                //   view-angle modulated to fade edge-on crossed cards (b166:81-87).
                FoliageDepthAlphaClip(IN.uv, IN.normalWS);
                return 0;
            }
            ENDHLSL
        }

        // =====================================================================
        // DEPTH NORMALS  (URP SSAO / depth-normals prepass; maps the GBuffer normal need).
        //   Not a 1:1 source pass — URP infra so foliage participates in SSAO/decals.
        // =====================================================================
        Pass {
            Name "DepthNormals"
            Tags { "LightMode"="DepthNormals" }
            ZWrite On
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vertForward
            #pragma fragment fragDepthNormals
            #pragma shader_feature_local _ALPHATEST_ON
            #pragma shader_feature_local _LEAF_OFFSET_COVER_TRUNK

            float4 fragDepthNormals(Varyings IN, bool isFrontFace : SV_IsFrontFace) : SV_Target
            {
                FoliageAlphaClip(IN.uv);
                FoliageSurface s = BuildFoliageSurface(IN, isFrontFace);
                return float4(NormalizeNormalPerPixel(s.normalWS), 0.0);
            }
            ENDHLSL
        }
    }

    FallBack "Hidden/Universal Render Pipeline/FallbackError"
}
