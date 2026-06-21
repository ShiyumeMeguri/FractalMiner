// HGRP Wetness Decal — screen-space deferred wetness projector (single "WetnessDecal" pass).
// A unit-cube (or procedural circular-sector) decal volume rendered Cull Front / ZTest Greater:
// it reconstructs world position from the camera depth buffer, projects it into the decal's
// object space, clips to the [-0.5,0.5]^3 box, applies a camera distance-fade and the per-instance
// packed alpha, and writes (1 + value/255) into R+G of the wetness target with BlendOp Min so the
// decal DARKENS (accumulates wetness) where the volume covers visible geometry.
//
// Merged from: wetnessdecal/Sub0_Pass0_{Vertex_b2,Fragment_b3} (base, no keywords)
//          and wetnessdecal/Sub0_Pass0_{Vertex_b4,Fragment_b5} (_USE_MASK).
// Keywords: _USE_MASK
// Kept (1:1 math, cited per block):
//   - Vertex: procedural sector-fan geometry (atan2 minimax poly + sin/cos fan, gated by packedMisc&255==2),
//             camera-relative world transform, HClip projection.
//   - Fragment: depth->WS reconstruction via inverse-VP, WS->decal-object clip box, camera distance-fade,
//               per-instance packed alpha (packedColor>>24) * _OverallOpacity, +1/255 Min-blend encoding.
//   - _USE_MASK: depth-derivative WS normal, dominant-axis (tri-planar-ish) mask UV projection with
//                uvTilingOffset + _BaseColorMap_ST, soft-blend edge falloff, mask-tex LOD bias.
// Removed (pixel-neutral pipeline infra substituted by URP, or sandbox-irrelevant):
//   - DOTS/ECS per-instance cbuffer (ECSPerDrawArray[256]); GPU instancing. The per-instance fields
//     (packedColor alpha, sectorAngle, packedMisc shape/lod flags, uvTilingOffset) have NO URP global,
//     so they are re-exposed as material properties: _DecalAlpha255 / _SectorAngle / _DecalShapeFlag /
//     _DecalLodPx / _UVTilingOffset (see CBUFFER). object<->world from unity_ObjectToWorld / unity_WorldToObject.
//   - TAA jitter (_TaaJitterStrength) — jitter is a temporal pipeline concern, dropped (pixel-neutral).
//   - Camera-relative rendering: HGRP subtracts _WorldSpaceCameraPos in WS then uses a translation-removed
//     VP (_NonJitteredViewNoTransProjMatrix). URP path uses absolute WS + UNITY_MATRIX_VP (TransformWorldToHClip),
//     mathematically equivalent for the final clip position.
//   - _ScreenSize.zw (1/w,1/h) -> declared as _CameraDepthTexture_TexelSize.xy (URP supplies it).
//
// NOTE: source output is a float2 (R,G) wetness mask; both channels receive the same value.
//   Render target is expected to be set up by the wetness feature; this shader only emits the Min-blended mark.
// NOTE: _CameraDepthTexture must be available (URP DepthTexture enabled / decal renderer feature event).

Shader "HGRP/WetnessDecal_Fix" {
    Properties {
        [Header(Main Properties)]
        _OverallOpacity ("Overall Opacity", Range(0, 1)) = 1
        _DistanceFade ("Distance Fade", Range(1, 1000)) = 300

        [Header(Mask)]
        [Toggle(_USE_MASK)] _UseMask ("Use Mask", Float) = 0
        _BaseColorMap ("Mask Tex", 2D) = "white" {}
        [ToggleUI] _MaskTexUseDisturb ("Mask Tex Use Disturb", Float) = 0
        _SoftBias ("Soft Bias", Float) = 0
        [ToggleUI] _UseSoftBlend ("Use SoftBlend", Float) = 0

        [Header(Per-Instance (was ECS per-draw))]
        // Was ECSPerDrawArray fields; no URP global equivalent, re-exposed as material uniforms.
        _DecalAlpha255 ("Decal Alpha (0-255, was packedColor>>24)", Range(0, 255)) = 255
        _SectorAngle ("Sector Angle (deg, was ECSPerDrawArray_sectorAngle)", Float) = 360
        [Enum(Box,0,SectorFan,2)] _DecalShapeFlag ("Shape (was packedMisc&255)", Float) = 0
        _DecalLodPx ("Decal Pixel Size (was packedMisc>>16, mask LOD)", Float) = 256
        _UVTilingOffset ("UV Tiling/Offset (was ECSPerDrawArray_uvTilingOffset)", Vector) = (1, 1, 0, 0)
    }

    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent+100"
        }
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float  _OverallOpacity;
                float  _DistanceFade;
                // Mask (_USE_MASK)
                float  _MaskTexUseDisturb;
                float  _SoftBias;
                float  _UseSoftBlend;
                float4 _BaseColorMap_ST;
                float4 _BaseColorMap_TexelSize;
                // Per-instance (was ECSPerDrawArray)
                float  _DecalAlpha255;
                float  _SectorAngle;
                float  _DecalShapeFlag;
                float  _DecalLodPx;
                float4 _UVTilingOffset;
            CBUFFER_END

            TEXTURE2D(_BaseColorMap);   SAMPLER(sampler_BaseColorMap);

            // ---- magic-constant decodes (see header) ----
            static const float INV255       = 0.0039215688593685626983642578125; // 1/255
            static const float SECTOR_DEG    = 0.011111111380159854888916015625;  // 1/90 (sectorAngle deg scale)
            static const float SECTOR_RADIUS = 0.000727220554836094379425048828125; // pi/(180*24) cos() scale
            static const float NEG_PI        = -3.1415927410125732;               // asfloat(3226013659u) = -pi
            static const float HALF_PI       = 1.57079637050628662109375;         // pi/2
            static const float LEN_EPS       = 9.9999999392252902907785028219223e-09; // 1e-8

            // atan(|t|) minimax polynomial for t in [0,1] (blob Vertex_b2 lines 65-67).
            // _56 = poly(_48) evaluated on _48 = (min/max of |z|,|x|)^2.
            float WetnessDecal_AtanUnitPoly(float ratioSq)
            {
                return mad(ratioSq,
                       mad(ratioSq,
                       mad(ratioSq,
                       mad(ratioSq, 0.02083509974181652069091796875f, -0.08513300120830535888671875f),
                           0.1801410019397735595703125f),
                          -0.33029949665069580078125f),
                           0.999866008758544921875f);
            }
        ENDHLSL

        Pass {
            Name "WetnessDecal"
            // Source render-state (skeleton lines 21-34): Blend One One,One One / BlendOp Min,Min /
            // ZTest Greater / ZWrite Off / Cull Front. (HGRP Stencil ReadMask 7 Comp Equal dropped —
            // SRP stencil-tag bucketing has no URP analogue; the wetness renderer feature owns the stencil.)
            Blend One One, One One
            BlendOp Min, Min
            ZTest Greater
            ZWrite Off
            Cull Front

            Tags { "LightMode"="UniversalForwardOnly" }

            HLSLPROGRAM
            #pragma target 4.5
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _USE_MASK

            struct Attributes {
                float3 positionOS : POSITION;
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
            #ifdef _USE_MASK
                float maskLodBias : TEXCOORD0; // TEXCOORD.x (mip bias), TEXCOORD.y is always 0 -> dropped
            #endif
            };

            // =========================================================================
            // VERTEX  (1:1 from Vertex_b2 lines 63-88 ; _USE_MASK delta = Vertex_b4 lines 100-101)
            // Procedural decal mesh: box passthrough OR circular-sector fan (gated by _DecalShapeFlag==2).
            // =========================================================================
            Varyings vert(Attributes v)
            {
                Varyings o;
                float3 P = v.positionOS;

                // --- atan2-style sector angle of (P.x, P.z) (blob Vertex_b2 lines 65-68) ---
                // _47 = (1/max(|z|,|x|)) * min(|z|,|x|)  = tan of the smaller angle.
                float ratio   = (1.0f / max(abs(P.z), abs(P.x))) * min(abs(P.z), abs(P.x)); // _47
                float ratioSq = ratio * ratio;                                              // _48
                float poly    = WetnessDecal_AtanUnitPoly(ratioSq);                          // _56
                // _87: base atan, plus pi/2 complement when |z|<|x|, plus -pi when z<-z (z<0 half-plane).
                float atanBase = mad(ratio, poly,
                                     asfloat(((abs(P.z) < abs(P.x)) ? 0xFFFFFFFFu : 0u)
                                             & asuint(mad(poly * ratio, -2.0f, HALF_PI))));    // _56*_47 term
                float angle    = asfloat(((P.z < -P.z) ? 0xFFFFFFFFu : 0u) & asuint(NEG_PI)) + atanBase; // _87

                // --- quadrant sign: negate when (max>=0 && min<0) (blob line 71/84: _114) ---
                float zMin = min(P.z, P.x);  // _92
                float zMax = max(P.z, P.x);  // _100
                bool  negQuad = (zMax >= -zMax) && (zMin < -zMin);
                float sectorRad = ((negQuad ? -angle : angle) * _SectorAngle) * SECTOR_DEG;   // _114 (deg->units)

                // --- fan radius and shape select (blob lines 72-76 / 85-89) ---
                float fanRadius = 0.5f / cos(SECTOR_RADIUS * _SectorAngle);                   // _124
                // _137: mask to zero out the origin vertex (POSITION.x==0 && POSITION.z==0).
                uint  nonOriginMask = ((P.x != 0.0f) ? 0xFFFFFFFFu : 0u) | ((P.z != 0.0f) ? 0xFFFFFFFFu : 0u);
                bool  isSectorFan   = ((255u & (uint)_DecalShapeFlag) == 2u);                 // _151
                float planarX = isSectorFan ? asfloat(asuint(sin(sectorRad) * fanRadius) & nonOriginMask) : P.x; // _156
                float planarZ = isSectorFan ? asfloat(asuint(cos(sectorRad) * fanRadius) & nonOriginMask) : P.z; // _157

                // --- object -> world -> clip (blob lines 79-86) ---
                // HGRP builds WS camera-relative then a translation-removed VP; URP uses absolute WS + VP.
                float3 posOS = float3(planarX, P.y, planarZ);
                float3 posWS = TransformObjectToWorld(posOS);
                o.positionCS = TransformWorldToHClip(posWS);

            #ifdef _USE_MASK
                // Mask mip bias (blob Vertex_b4 lines 100-101):
                //   TEXCOORD.x = max(floor(log2( min(tiling.xy)*texHeight / max(decalPx * screenH /255, 1e-3) )), 0)
                float texHeight = _BaseColorMap_TexelSize.w; // Unity _TexelSize = (1/w,1/h,w,h) -> .w = height
                float worldTexels = min(_UVTilingOffset.y, _UVTilingOffset.x) * texHeight;
                float screenScale = max((_DecalLodPx * _ScreenParams.y) * INV255, 0.001000000047497451305389404296875f);
                o.maskLodBias = max(floor(log2(worldTexels / screenScale)), 0.0f);
            #endif
                return o;
            }

            // =========================================================================
            // FRAGMENT  (1:1 from Fragment_b3 lines 79-103 ; _USE_MASK delta = Fragment_b5 lines 87-130)
            // =========================================================================
            float2 frag(Varyings input) : SV_Target
            {
                // --- screen UV / NDC (blob Fragment_b3 lines 82-85) ---
                // _53 = 2*(pixel.x/W)-1 = ndc.x ; _80 = -(2*(pixel.y/H)-1) = -ndc.y . The blob HARDCODES
                // the NDC.y negation because HGRP's _InvViewProjMatrix is built against the D3D-style
                // (Y-up) clip convention. URP's UNITY_MATRIX_I_VP follows the SAME Unity clip convention,
                // but the platform Y-flip is gated on UNITY_UV_STARTS_AT_TOP — so we use URP's canonical
                // reconstruction helper, which feeds (uv*2-1) with `clip.y=-clip.y` ONLY when
                // UNITY_UV_STARTS_AT_TOP (D3D/Metal/consoles) and leaves it un-flipped on GL/Vulkan.
                // On a Y-up-NDC platform this reproduces the blob's -ndcY EXACTLY (resolves the prior
                // right-side-up risk); on a non-flip platform the literal -ndcY would have been wrong,
                // so this is the correct platform-portable 1:1 equivalent. (vs Fragment_b3:82-89.)
                float2 invScreen = _CameraDepthTexture_TexelSize.xy; // (1/w, 1/h) == _ScreenSize.zw
                float2 pixel     = input.positionCS.xy;
                float2 uvScreen  = pixel.xy * invScreen;                                          // [0,1] (uv.y=0 at top) -> ComputeClipSpacePosition does *2-1
                // _77/_84: depth at integer pixel (floor(pos)+0.5)/size sampled with LinearClamp @LOD0.
                // That UV is exactly the texel center, so this is a point load -> LOAD_TEXTURE2D_X (1:1, stereo-safe).
                float  rawDepth  = LOAD_TEXTURE2D_X(_CameraDepthTexture, uint2(floor(pixel.xy))).x;

                // --- reconstruct world position via inverse view-proj (blob lines 86-89) ---
                // ComputeWorldSpacePosition: clip=(uv*2-1, depth, 1); flip clip.y iff UNITY_UV_STARTS_AT_TOP;
                // ws = mul(UNITY_MATRIX_I_VP, clip).xyz / .w . Column-major blob M[col].comp*v[comp]+... ==
                // mul(I_VP, ndc4); the helper's mul(I_VP, clip4)/w is the same product (Common.hlsl:1388).
                float3 posWS = ComputeWorldSpacePosition(uvScreen, rawDepth, UNITY_MATRIX_I_VP);  // _126/_127/_128 (/_125)
                float  wsX   = posWS.x;
                float  wsY   = posWS.y;
                float  wsZ   = posWS.z;

                // --- world -> decal object space (blob lines 91-93) ---
                // Blob = mul(worldToObject, float4(ws,1)). URP: TransformWorldToObject == mul(unity_WorldToObject,..).
                float3 objPos = TransformWorldToObject(float3(wsX, wsY, wsZ)); // _169..171 / _176..178
                float  objX = objPos.x;
                float  objY = objPos.y;
                float  objZ = objPos.z;

                // --- clip to the [-0.5, 0.5]^3 decal box (blob line 94 / 102) ---
                bool outside = (min(-objX + 0.5f, objX + 0.5f) < 0.0f)
                            || (min(-objY + 0.5f, objY + 0.5f) < 0.0f)
                            || (min(-objZ + 0.5f, objZ + 0.5f) < 0.0f);
                if (outside) discard;

                // --- camera distance-fade (blob lines 95-100 / 103-107,127) ---
                // ortho: view space basis Z column ; persp: (camPos - ws). _238/_245 = |vec|^2.
                // ortho basis: blob _ViewMatrix[0].z,[1].z,[2].z (column_major) = view-row2 = camera forward WS
                //            = UNITY_MATRIX_V[2].xyz (row-major). persp: (camPos - ws).
                bool isOrtho = (0.0f == unity_OrthoParams.w);                                     // _202/_209
                float vx = isOrtho ? UNITY_MATRIX_V[2].x : (-wsX + _WorldSpaceCameraPos.x);        // _222/_229
                float vy = isOrtho ? UNITY_MATRIX_V[2].y : (-wsY + _WorldSpaceCameraPos.y);        // _229/_236
                float vz = isOrtho ? UNITY_MATRIX_V[2].z : (-wsZ + _WorldSpaceCameraPos.z);        // _237/_244
                float distSq = dot(float3(vx, vy, vz), float3(vx, vy, vz));                        // _238/_245
                // dist = rsqrt(max(distSq,eps))*distSq == sqrt(distSq) ; fade = 1 - saturate(dist/_DistanceFade).
                float dist = rsqrt(max(distSq, LEN_EPS)) * distSq;
                float fade = -clamp(dist / _DistanceFade, 0.0f, 1.0f) + 1.0f;

                // --- per-instance packed alpha * overall opacity (blob line 100 / 127) ---
                float instAlpha = _DecalAlpha255; // was float(packedColor >> 24u)
                float wetness   = fade * instAlpha * _OverallOpacity;

            #ifdef _USE_MASK
                // === MASK variant: dominant-axis tri-planar mask projection (blob Fragment_b5 lines 108-127) ===
                // Reconstruct WS surface normal from depth derivatives of the reconstructed WS position.
                // _261.._263 = cross( ddx(ws), ddy(ws) ) component-wise (blob lines 108-117).
                float dyz = ddy_coarse(wsZ), dyx = ddy_coarse(wsX), dyy = ddy_coarse(wsY); // _249,_250,_251
                float dxy = ddx_coarse(wsY), dxz = ddx_coarse(wsZ), dxx = ddx_coarse(wsX); // _252,_253,_254
                float nx = mad(dyy, dxz, -(dxy * dyz));   // _261
                float ny = mad(dyz, dxx, -(dxz * dyx));   // _262
                float nz = mad(dyx, dxy, -(dxx * dyy));   // _263
                float nrm = rsqrt(dot(float3(nx, ny, nz), float3(nx, ny, nz))); // _267
                float3 N = float3(nx, ny, nz) * nrm;       // _268,_269,_270

                // Project N onto the decal's world-space axes (blob lines 121-123).
                // Blob reads objectToWorld[r].{x,y,z} (column_major) = objectToWorld COLUMN r = the world
                // direction of object axis r. URP unity_ObjectToWorld columns r=0/1/2 = ._mX0/._mX1/._mX2.
                float3 axisX = float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20);
                float3 axisY = float3(unity_ObjectToWorld._m01, unity_ObjectToWorld._m11, unity_ObjectToWorld._m21);
                float3 axisZ = float3(unity_ObjectToWorld._m02, unity_ObjectToWorld._m12, unity_ObjectToWorld._m22);
                float nDotX = dot(N, axisX); // _276
                float nDotY = dot(N, axisY); // _285
                float nDotZ = dot(N, axisZ); // _294

                // Dominant-axis selectors (blob lines 124-125): which object axis the surface faces.
                bool sel309 = 0.0f < (-max(abs(nDotX), abs(nDotZ)) + abs(nDotY)); // _309 (Y dominant over X,Z)
                bool sel310 = 0.0f < (-max(abs(nDotZ), abs(nDotY)) + abs(nDotX)); // _310 (X dominant over Z,Y)

                // Pick the two in-plane object coords for the chosen projection plane (blob line 127).
                // U source: sel310 ? objY : objX .  V source: (sel310||sel309) ? objZ : objY .
                float uSrc = sel310 ? objY : objX;
                float vSrc = (sel310 || sel309) ? objZ : objY;
                // soft-blend axis coord: sel310 ? objX : (sel309 ? objY : objZ).
                float softSrc = sel310 ? objX : (sel309 ? objY : objZ);

                // UV = ((src+0.5)*uvTiling + uvOffset) * _BaseColorMap_ST.xy + _BaseColorMap_ST.zw (blob line 127).
                float u = mad(mad(uSrc + 0.5f, _UVTilingOffset.x, _UVTilingOffset.z), _BaseColorMap_ST.x, _BaseColorMap_ST.z);
                float vCoord = mad(mad(vSrc + 0.5f, _UVTilingOffset.y, _UVTilingOffset.w), _BaseColorMap_ST.y, _BaseColorMap_ST.w);
                float maskA = SAMPLE_TEXTURE2D_LOD(_BaseColorMap, sampler_BaseColorMap, float2(u, vCoord), input.maskLodBias).x;

                // Soft-blend edge falloff (blob line 127):
                //   clamp( _SoftBias*_UseSoftBlend + (1 - 2*|softSrc|), 0, 1 ).
                float soft = clamp(mad(_SoftBias, _UseSoftBlend, mad(-abs(softSrc), 2.0f, 1.0f)), 0.0f, 1.0f);

                // _397 = -( maskA * soft * wetness ) ; combined into the final negative value.
                wetness = maskA * soft * wetness;
            #endif

                // --- encode: out = 1 + (-wetness)/255 so BlendOp Min darkens (blob lines 101-102 / 128-129) ---
                // base/Fragment_b3 _267 is already negative ( -(...) ); we computed positive 'wetness', negate here.
                float encoded = mad(-wetness, INV255, 1.0f);
                return float2(encoded, encoded);
            }
            ENDHLSL
        }
    }
}
