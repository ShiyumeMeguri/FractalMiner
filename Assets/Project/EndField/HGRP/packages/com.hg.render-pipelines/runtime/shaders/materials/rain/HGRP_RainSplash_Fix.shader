// HGRP RainSplash — GPU-driven procedural rain-splash billboard particles (single ForwardOnly pass).
// Merged from: rainsplash.shader base variant (Vertex b3 / Fragment b4, no keywords) — the catch-all #else.
// Keywords: (none kept). Source exposed RAIN_LIGHTING and SRP_INSTANCING_ON multi_compile_local.
// Kept:
//   - Vertex: full GPU particle placement (1:1). Each "vertex" is a corner of a screen-grid splash quad.
//     Camera is snapped to a world cell grid; per-cell pseudo-random jitter + depth-layer index;
//     the cell center is projected through the Vertical-Occlusion-Map (VOM) projection, the VOM is
//     sampled for ground height, then un-projected back to world; the quad is built camera-facing in
//     XZ with a vertical billboard, size driven by particle life, distance fade, and culled to NaN
//     when outside the active-particle ratio.  (blob Sub0_Pass0_Vertex_b3.hlsl)
//   - Fragment: splash sprite atlas sample + 3-frame animation select (RGB = 3 frames, seed picks the
//     frame by thirds) * _RainColor * fade.  (blob Sub0_Pass0_Fragment_b4.hlsl)
// Removed (pixel-neutral pipeline infra substituted by URP, OR HGRP-only globals that have no URP twin):
//   - TAA jitter (_TaaJitterStrength.zw applied to clip xy, blob b3 lines 143-144) — dropped per WF#2 (pixel-neutral).
//   - SRP_INSTANCING_ON — the instancing-only vertex variant (b7) is byte-identical to base except an
//     UNUSED instanceID passthrough; instancing dropped, no math change.
//   - RAIN_LIGHTING — the lit fragment variant (b6, 1415 lines) is an HGRP reflection-probe CLIPMAP-GI
//     evaluation (_ReflectionProbeGlobalDatas[32] world clipmap, T9..T14 3D irradiance/SH volumes,
//     light-binning ByteAddressBuffer, CSM/punctual/ASM shadow atlas). NONE of these exist in URP; the
//     base (unlit, _RainColor-tinted) splash is the visually-dominant path. See gaps / TODO below.
//
// NOTE: This is NOT a surface shader — it has no lighting/PBR. It is a procedural particle vertex
//   program + a flat textured billboard fragment. CoreMath/CoreSurface are intentionally NOT included.
// NOTE: The HGRP rain-system globals (WorldToVerticalOcclusionMap, the VOM projection CB1, the active
//   ratio / cell size / size-curve packed into the matrix rows, VOM scroll offset) have NO URP global
//   equivalent — they are produced by HGRP's rain C# feature. They are declared here as plain uniforms
//   so the math stays 1:1; a host system must feed them (same data the HGRP feature wrote).
// NOTE: Camera-relative reconstruction. HGRP renders camera-relative and the blob applies
//   _NonJitteredViewNoTransProjMatrix (view with translation zeroed x proj) to a corner that already had
//   _WorldSpaceCameraPos subtracted (b3 142-150). URP renders absolute-world and UNITY_MATRIX_VP keeps the
//   view translation, so the absolute world corner is reconstructed (corner + _WorldSpaceCameraPos) before
//   mul(UNITY_MATRIX_VP, .) — algebraically identical (P*V*corner = P*R*(corner-camPos)). See vert positionCS.
// NOTE: _ViewMatrix is column-major in the blob; `_ViewMatrix[c].z` = V._m2c. The camera-fwd XZ taps map to
//   UNITY_MATRIX_V._m20 / ._m22 (NOT [0].z/[2].z, which are row-major _m02/_m22). See vert camRX/camRZ.
// Vertex attribute legend (from blob SPIRV_Cross_Input): POSITION = quad corner (local), uv0(TEXCOORD0)
//   = corner offset, uv1(TEXCOORD1) = (.x particle/column seed [0,1], .y depth-layer seed [0,1]).

Shader "HGRP/RainSplash_Fix"
{
    Properties
    {
        _RainTex0 ("RainTexture0 (splash atlas, RGB = 3 anim frames)", 2D) = "white" {}
        _RainTex1_ST ("RainTex1_ST", Vector) = (1, 1, 1, 1)
        _RainParams ("RainParams", Vector) = (1, 1, 1, 1)
        _RainColor ("RainColor", Color) = (1, 1, 1, 1)

        // Render-state plumbing (source: Blend SrcAlpha OneMinusSrcAlpha,One One / ZWrite Off / Cull Off).
        [HideInInspector] _SrcBlend ("__src", Float) = 5        // SrcAlpha
        [HideInInspector] _DstBlend ("__dst", Float) = 10       // OneMinusSrcAlpha
        [HideInInspector] _ZWrite ("__zw", Float) = 0
    }

    SubShader
    {
        Tags
        {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType"     = "Transparent"
            "Queue"          = "Transparent"
        }
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _RainTex0_ST;
                float4 _RainTex1_ST;
                float4 _RainParams;
                float4 _RainColor;
            CBUFFER_END

            // ---- HGRP rain-system globals (no URP equivalent; host must supply) ----
            // _WorldToVOM: column_major World->VerticalOcclusionMap basis, BUT its rows also pack rain
            //   params (decompiled access pattern, blob b3):
            //     [1u].x = active-particle ratio gate ; [2u].x = world cell size ;
            //     [2u].y = column jitter phase ; [2u].z/.w = particle-life size lerp endpoints ;
            //     [0u].x = grid resolution ; [0u].y = inv-grid texel.   (rows [0..3] are still a 4x4 basis)
            // _VOMProj: the VOM projection matrix (CB1UBO CB1_m0[0..3]) + CB1_m0[4].xy = VOM UV scroll.
            float4x4 _WorldToVOM;
            float4x4 _VOMProj;
            float4   _VOMScrollOffset;   // = CB1_m0[4]; .xy used
            TEXTURE2D(_VerticalOcclusionMap);  SAMPLER(sampler_VerticalOcclusionMap);

            TEXTURE2D(_RainTex0);              SAMPLER(sampler_RainTex0);

            // sign(x) as float (-1 / 0 / +1). Blob spells this as the int-mask expression
            //   float(int((0u - (0<x?~0:0)) + (x<0?~0:0)))  (b3 lines 62-63).
            float SignF(float x)
            {
                return (x > 0.0) ? 1.0 : ((x < 0.0) ? -1.0 : 0.0);
            }

            // GPU-mirror of HLSL `frac`-with-sign used by the blob: `(a>=-a) ? frac(|a|) : -frac(|a|)`
            // — i.e. trunc-toward-zero fractional, matching b3 lines 128-129 / 146-147.
            float SignedFrac(float a)
            {
                float f = frac(abs(a));
                return (a >= -a) ? f : -f;
            }
        ENDHLSL

        Pass
        {
            Name "RainSplash"
            Tags { "LightMode" = "UniversalForwardOnly" }

            // Source: Blend SrcAlpha OneMinusSrcAlpha, One One ; ZWrite Off ; Cull Off ; ZClip On.
            Blend [_SrcBlend] [_DstBlend], One One
            ZWrite [_ZWrite]
            ZTest LEqual
            Cull Off

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag

            struct Attributes
            {
                float3 positionOS : POSITION;   // quad corner (local)
                float2 uv0        : TEXCOORD0;   // corner offset
                float2 uv1        : TEXCOORD1;   // .x = particle/column seed, .y = depth-layer seed
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;   // blob TEXCOORD_2  (atlas uv)
                float2 fadeSeed   : TEXCOORD1;   // blob TEXCOORD_1_1: .x = distance fade, .y = anim seed
            };

            // ============================================================
            // Vertex — GPU procedural splash placement.
            // 1:1 source = rainsplash/Sub0_Pass0_Vertex_b3.hlsl  (the catch-all #else, no keywords).
            // ============================================================
            Varyings vert(Attributes IN)
            {
                Varyings OUT;

                // Gate: cull this particle when its column seed exceeds the active-particle ratio.
                // (b3 line 57)  if (_WorldToVOM[1].x >= uv1.x)
                if (_WorldToVOM[1].x >= IN.uv1.x)
                {
                    // cellSize2 = 2 * cellSize.            (b3 line 59: _61)
                    float cellSize  = _WorldToVOM[2].x;
                    float cellSize2 = cellSize + cellSize;

                    // Corner signs from local quad position.   (b3 lines 60-63: _72,_73,_88,_89)
                    float dX = -IN.uv0.x + IN.positionOS.x;          // _72
                    float dY = IN.positionOS.y;                      // _73  (asfloat(0u) = 0)
                    float signX = SignF(dX);                         // _88
                    float signY = SignF(dY);                         // _89

                    // Per-column / depth-layer pseudo-random and offsets.  (b3 lines 64-69)
                    //   _111: column phase from frac(seed*32) + jitterPhase, scaled by a [0.7..1.3] depth ramp.
                    float colPhase = (frac(IN.uv1.x * 32.0) + _WorldToVOM[2].y)
                                   * mad(mad(frac(IN.uv1.y * 128.0), 2.0, -1.0), 0.3, 1.0);   // _111
                    float layerIdx = frac(floor(colPhase) * 0.1);                              // _115
                    float depthRamp = mad(IN.uv1.y, 2.0, -1.0);                                // _128  (uv1.y*2-1)
                    float jitterA  = frac(layerIdx + IN.uv1.x);                                // _139  (also anim seed)
                    // _143 / _144: per-cell sub-offset (X / Z) within the grid, in cell units.
                    float offX = mad(mad(jitterA, 2.0, -1.0), 0.2,
                                     mad(depthRamp, 0.2, IN.uv0.x + IN.uv0.x));                 // _143
                    float offZ = mad(mad(frac(layerIdx - IN.uv1.x), 2.0, -1.0), 0.2,
                                     mad(depthRamp, 0.2, IN.uv0.y + IN.uv0.y));                 // _144

                    // Snap camera to the cell grid and build the cell-center world position.
                    // (b3 lines 70-75: _153,_164,_166,_200,_201,_202)
                    float invCell2 = 0.5 / cellSize;                                           // _153
                    float camGX = floor(invCell2 * _WorldSpaceCameraPos.x);                    // _164
                    float camGZ = floor(invCell2 * _WorldSpaceCameraPos.z);                    // _166
                    // _200/_202: wrap-correct the snapped cell against the sub-offset (the asfloat(mask&1.0)
                    //   term adds one extra cell when the offset would overshoot the camera).
                    float cellX = mad(camGX, cellSize2,
                                      mad((mad(-camGX, cellSize2, _WorldSpaceCameraPos.x)
                                            >= mad(offX, cellSize, cellSize)) ? 1.0 : 0.0,
                                          cellSize2, offX * cellSize));                         // _200
                    float cellY = mad(floor(invCell2 * _WorldSpaceCameraPos.y), cellSize2,
                                      _WorldSpaceCameraPos.y);                                  // _201
                    float cellZ = mad(camGZ, cellSize2,
                                      mad((mad(-camGZ, cellSize2, _WorldSpaceCameraPos.z)
                                            >= mad(offZ, cellSize, cellSize)) ? 1.0 : 0.0,
                                          cellSize2, offZ * cellSize));                         // _202

                    // Project the cell center through the VOM projection and sample ground height.
                    // (b3 lines 76-80: _232,_233,_234,_248,_250)
                    float pX = mad(_VOMProj[2].x, cellZ, mad(_VOMProj[0].x, cellX, cellY * _VOMProj[1].x)) + _VOMProj[3].x; // _232
                    float pY = mad(_VOMProj[2].y, cellZ, mad(_VOMProj[0].y, cellX, cellY * _VOMProj[1].y)) + _VOMProj[3].y; // _233
                    float pW = mad(_VOMProj[2].w, cellZ, mad(_VOMProj[0].w, cellX, cellY * _VOMProj[1].w)) + _VOMProj[3].w; // _234
                    float2 vomUV = float2(mad(pX, 0.5, 0.5) + _VOMScrollOffset.x,
                                          (-mad(pY, 0.5, 0.5) + 1.0) + _VOMScrollOffset.y);     // sample uv
                    float groundH = SAMPLE_TEXTURE2D_LOD(_VerticalOcclusionMap, sampler_VerticalOcclusionMap, vomUV, 0.0).x; // _250

                    // Inverse of the VOM projection (cofactor expansion) to bring the sampled clip point
                    // (pX,pY,groundH,pW) back to world.  (b3 lines 81-123)
                    // --- 2x2 minors of rows 1,2 (for inverse rows touching col indices) ---
                    float m12_wz = _VOMProj[1].w * _VOMProj[2].z;   // _261
                    float m12_zw = _VOMProj[1].z * _VOMProj[2].w;   // _262
                    float m12_yw = _VOMProj[1].y * _VOMProj[2].w;   // _263
                    float m12_wy = _VOMProj[1].w * _VOMProj[2].y;   // _264
                    float m12_wx = _VOMProj[1].w * _VOMProj[2].x;   // _277
                    float m12_xw = _VOMProj[1].x * _VOMProj[2].w;   // _278
                    float m12_zy = _VOMProj[1].z * _VOMProj[2].y;   // _279
                    float m12_yz = _VOMProj[1].y * _VOMProj[2].z;   // _280
                    // cofactor row 0 numerator (col 0).  (_307)
                    float cof00 = mad(m12_yz, _VOMProj[3].w, mad(-m12_zy, _VOMProj[3].w,
                                  mad(-m12_yw, _VOMProj[3].z, mad(m12_wy, _VOMProj[3].z,
                                  mad(m12_zw, _VOMProj[3].y, -(m12_wz * _VOMProj[3].y))))));
                    // --- minors of rows 0,2 ---
                    float m02_zw = _VOMProj[0].z * _VOMProj[2].w;   // _318
                    float m02_wz = _VOMProj[0].w * _VOMProj[2].z;   // _319
                    float m02_wy = _VOMProj[0].w * _VOMProj[2].y;   // _320
                    float m02_yw = _VOMProj[0].y * _VOMProj[2].w;   // _321
                    float m02_wx = _VOMProj[0].w * _VOMProj[2].x;   // _334
                    float m02_xw = _VOMProj[0].x * _VOMProj[2].w;   // _335
                    float m02_yz = _VOMProj[0].y * _VOMProj[2].z;   // _336
                    float m02_zy = _VOMProj[0].z * _VOMProj[2].y;   // _337
                    float cof10 = mad(-m02_yz, _VOMProj[3].w, mad(m02_zy, _VOMProj[3].w,
                                  mad(m02_yw, _VOMProj[3].z, mad(-m02_wy, _VOMProj[3].z,
                                  mad(m02_wz, _VOMProj[3].y, -(m02_zw * _VOMProj[3].y))))));     // _364
                    // --- minors of rows 0,1 ---
                    float m01_wz = _VOMProj[0].w * _VOMProj[1].z;   // _375
                    float m01_zw = _VOMProj[0].z * _VOMProj[1].w;   // _376
                    float m01_yw = _VOMProj[0].y * _VOMProj[1].w;   // _377
                    float m01_wy = _VOMProj[0].w * _VOMProj[1].y;   // _378
                    float m01_wx = _VOMProj[0].w * _VOMProj[1].x;   // _391
                    float m01_xw = _VOMProj[0].x * _VOMProj[1].w;   // _392
                    float m01_zy = _VOMProj[0].z * _VOMProj[1].y;   // _393
                    float m01_yz = _VOMProj[0].y * _VOMProj[1].z;   // _394
                    float cof20 = mad(m01_yz, _VOMProj[3].w, mad(-m01_zy, _VOMProj[3].w,
                                  mad(-m01_yw, _VOMProj[3].z, mad(m01_wy, _VOMProj[3].z,
                                  mad(m01_zw, _VOMProj[3].y, -(m01_wz * _VOMProj[3].y))))));     // _421

                    // 1/determinant.  (_465)
                    float invDet = 1.0 / mad(_VOMProj[3].x,
                                       mad(-m01_yz, _VOMProj[2].w, mad(m01_zy, _VOMProj[2].w,
                                       mad(m01_yw, _VOMProj[2].z, mad(-m01_wy, _VOMProj[2].z,
                                       mad(m01_wz, _VOMProj[2].y, -(m01_zw * _VOMProj[2].y)))))),
                                       mad(_VOMProj[2].x, cof20, mad(_VOMProj[0].x, cof00, cof10 * _VOMProj[1].x)));

                    // remaining minors used by the inverse columns.  (_476.._507)
                    float m12_zx = _VOMProj[1].z * _VOMProj[2].x;   // _476
                    float m12_xz = _VOMProj[1].x * _VOMProj[2].z;   // _477
                    float m12_yx = _VOMProj[1].y * _VOMProj[2].x;   // _478
                    float m12_xy = _VOMProj[1].x * _VOMProj[2].y;   // _479
                    float m02_zx = _VOMProj[0].z * _VOMProj[2].x;   // _490
                    float m02_xz = _VOMProj[0].x * _VOMProj[2].z;   // _491
                    float m02_yx = _VOMProj[0].y * _VOMProj[2].x;   // _492
                    float m02_xy = _VOMProj[0].x * _VOMProj[2].y;   // _493
                    float m01_zx = _VOMProj[0].z * _VOMProj[1].x;   // _504
                    float m01_xz = _VOMProj[0].x * _VOMProj[1].z;   // _505
                    float m01_yx = _VOMProj[0].y * _VOMProj[1].x;   // _506
                    float m01_xy = _VOMProj[0].x * _VOMProj[1].y;   // _507

                    float4 clipPt = float4(pX, pY, groundH, pW);

                    // World X/Y/Z = inverse-projection rows · clipPt.  (b3 lines 121-123: _745,_748,_751)
                    float worldX = dot(float4(cof00 * invDet,
                        invDet * mad(-m12_xz, _VOMProj[3].w, mad(m12_zx, _VOMProj[3].w,
                                 mad(m12_xw, _VOMProj[3].z, mad(-m12_wx, _VOMProj[3].z,
                                 mad(m12_wz, _VOMProj[3].x, -(m12_zw * _VOMProj[3].x)))))),
                        invDet * mad(m12_xy, _VOMProj[3].w, mad(-m12_yx, _VOMProj[3].w,
                                 mad(-m12_xw, _VOMProj[3].y, mad(m12_wx, _VOMProj[3].y,
                                 mad(m12_yw, _VOMProj[3].x, -(m12_wy * _VOMProj[3].x)))))),
                        invDet * mad(-m12_xy, _VOMProj[3].z, mad(m12_yx, _VOMProj[3].z,
                                 mad(m12_xz, _VOMProj[3].y, mad(-m12_zx, _VOMProj[3].y,
                                 mad(m12_zy, _VOMProj[3].x, -(m12_yz * _VOMProj[3].x))))))), clipPt); // _745

                    float worldY = dot(float4(cof10 * invDet,
                        invDet * mad(m02_xz, _VOMProj[3].w, mad(-m02_zx, _VOMProj[3].w,
                                 mad(-m02_xw, _VOMProj[3].z, mad(m02_wx, _VOMProj[3].z,
                                 mad(m02_zw, _VOMProj[3].x, -(m02_wz * _VOMProj[3].x)))))),
                        invDet * mad(-m02_xy, _VOMProj[3].w, mad(m02_yx, _VOMProj[3].w,
                                 mad(m02_xw, _VOMProj[3].y, mad(-m02_wx, _VOMProj[3].y,
                                 mad(m02_wy, _VOMProj[3].x, -(m02_yw * _VOMProj[3].x)))))),
                        invDet * mad(m02_xy, _VOMProj[3].z, mad(-m02_yx, _VOMProj[3].z,
                                 mad(-m02_xz, _VOMProj[3].y, mad(m02_zx, _VOMProj[3].y,
                                 mad(m02_yz, _VOMProj[3].x, -(m02_zy * _VOMProj[3].x))))))), clipPt); // _748

                    float worldZ = dot(float4(cof20 * invDet,
                        invDet * mad(-m01_xz, _VOMProj[3].w, mad(m01_zx, _VOMProj[3].w,
                                 mad(m01_xw, _VOMProj[3].z, mad(-m01_wx, _VOMProj[3].z,
                                 mad(m01_wz, _VOMProj[3].x, -(m01_zw * _VOMProj[3].x)))))),
                        invDet * mad(m01_xy, _VOMProj[3].w, mad(-m01_yx, _VOMProj[3].w,
                                 mad(-m01_xw, _VOMProj[3].y, mad(m01_wx, _VOMProj[3].y,
                                 mad(m01_yw, _VOMProj[3].x, -(m01_wy * _VOMProj[3].x)))))),
                        invDet * mad(-m01_xy, _VOMProj[3].z, mad(m01_yx, _VOMProj[3].z,
                                 mad(m01_xz, _VOMProj[3].y, mad(-m01_zx, _VOMProj[3].y,
                                 mad(m01_zy, _VOMProj[3].x, -(m01_yz * _VOMProj[3].x))))))), clipPt); // _751

                    // Billboard build.  (b3 lines 124-152)
                    // _767: quad half-size = lerp(life-size endpoints) by column seed.
                    float sizeLerp = mad(IN.uv1.x, -_WorldToVOM[2].z + _WorldToVOM[2].w, _WorldToVOM[2].z); // _767
                    float worldYoff = mad(_WorldToVOM[0].w, sizeLerp, worldY);                  // _771
                    // _778/_782/_785/_788: quantize Y-extent by grid resolution.
                    float gridRes  = _WorldToVOM[0].x * _WorldToVOM[0].x;                       // _778
                    float quantY   = floor(gridRes * frac(colPhase)) / gridRes;                 // _782
                    float quantYf  = SignedFrac(quantY) * gridRes;                              // _788  ( = gridRes * signedFrac )

                    // Camera FORWARD projected into XZ (the billboard right vector is its 90deg rotation).
                    // Blob reads _ViewMatrix[0].z and _ViewMatrix[2].z. _ViewMatrix is the column-major HGRP
                    // view matrix, so SPIRV-Cross `[col].z` = math element (row=z, col) = V._m2{col}:
                    //   _792 = -_ViewMatrix[0].z = -V._m20 = -forward.x ;  _796 = -_ViewMatrix[2].z = -V._m22 = -forward.z.
                    // URP map (STYLE_BIBLE 2: `_ViewMatrix[N].z` -> UNITY_MATRIX_V._m2N). NOTE: must be ._m20/._m22,
                    // NOT [0].z/[2].z — UNITY_MATRIX_V[0].z is row-major = _m02 (= right.z) and would mix basis axes.
                    // (b3 lines 130-132: _792,_796,_800)
                    float camRX = -UNITY_MATRIX_V._m20;                                         // _792  (-forward.x)
                    float camRZ = -UNITY_MATRIX_V._m22;                                         // _796  (-forward.z)
                    float camRInvLen = rsqrt(dot(float2(camRX, camRZ), float2(camRX, camRZ)));  // _800

                    // Distance-fade vector (cell-space delta camera->splash).  (b3 lines 133-136)
                    float invCell = 1.0 / cellSize;                                             // _823
                    float fadeX = invCell * (-worldX + _WorldSpaceCameraPos.x);                 // _824
                    float fadeY = invCell * (-worldYoff + _WorldSpaceCameraPos.y);              // _825
                    float fadeZ = invCell * (-worldZ + _WorldSpaceCameraPos.z);                 // _826

                    // Final billboard corner in world space.  (b3 lines 137-141: _827,_847,_848,_849)
                    float cornerXext = signX * sizeLerp;                                        // _827
                    // posWS.x: camera-right * (vertical 0 contribution) folded with worldX, plus signX extent.
                    float posWSx = dot(float2(mad(camRInvLen, 0.0, -((camRZ * camRInvLen) * 1.0)), worldX),
                                       float2(cornerXext, 1.0)) - _WorldSpaceCameraPos.x;       // _847
                    float posWSy = dot(1.0.xx, float2(signY * sizeLerp, worldYoff)) - _WorldSpaceCameraPos.y; // _848
                    float posWSz = dot(float2(mad(camRX * camRInvLen, 1.0, -(camRInvLen * 0.0)), worldZ),
                                       float2(cornerXext, 1.0)) - _WorldSpaceCameraPos.z;       // _849

                    // Clip position.  (b3 lines 142-150)
                    // Source applies _NonJitteredViewNoTransProjMatrix (= P x V-with-translation-row-zeroed,
                    // HGRP camera-relative rendering) to the camera-RELATIVE corner posWS{x,y,z} (each already
                    // subtracted _WorldSpaceCameraPos above). URP renders in ABSOLUTE world and UNITY_MATRIX_VP =
                    // P x V INCLUDES the view translation, so feeding the camera-relative vector straight in would
                    // remove the camera translation twice (constant R*camPos world shift -> splashes drift with
                    // the camera). Reconstruct the absolute world corner first:
                    //   P*V*corner = P*(R*corner + t) = P*(R*corner - R*camPos) = P*R*(corner - camPos)  [t=-R*camPos]
                    // which is exactly the source's V-no-translation applied to (corner-camPos). So add camPos back.
                    // TAA jitter (b3 lines 143-144, _TaaJitterStrength.zw on clip xy) intentionally dropped (pixel-neutral).
                    float3 worldCorner = float3(posWSx, posWSy, posWSz) + _WorldSpaceCameraPos.xyz;
                    OUT.positionCS = mul(UNITY_MATRIX_VP, float4(worldCorner, 1.0));

                    // Out atlas uv from corner signs + grid texel.  (b3 lines 145-148: _914,_918,TEXCOORD_2)
                    float gx = quantYf / _WorldToVOM[0].x;                                      // _914
                    OUT.uv.x = mad(clamp(signX, 0.0, 1.0), _WorldToVOM[0].y,
                                   (SignedFrac(gx) * _WorldToVOM[0].x) * _WorldToVOM[0].y);     // TEXCOORD_2.x
                    OUT.uv.y = mad(clamp(signY, 0.0, 1.0), _WorldToVOM[0].y,
                                   (-floor(quantYf * _WorldToVOM[0].y) + (-1.0 + _WorldToVOM[0].x)) * _WorldToVOM[0].y); // TEXCOORD_2.y

                    // Fade alpha + anim seed.  (b3 lines 151-152)
                    OUT.fadeSeed.x = max(-min(dot(float3(fadeX, fadeY, fadeZ), float3(fadeX, fadeY, fadeZ)), 1.0) + 1.0, 0.5);
                    OUT.fadeSeed.y = jitterA;
                }
                else
                {
                    // Culled: degenerate to NaN clip pos, passthrough uvs.  (b3 lines 156-163)
                    OUT.positionCS = float4(0.0 / 0.0, 0.0 / 0.0, 0.0 / 0.0, 0.0 / 0.0);
                    OUT.uv = IN.uv0;
                    OUT.fadeSeed = IN.uv1;
                }

                return OUT;
            }

            // ============================================================
            // Fragment — splash atlas, 3-frame animation select, tint, fade.
            // 1:1 source = rainsplash/Sub0_Pass0_Fragment_b4.hlsl  (catch-all #else, no keywords).
            // ============================================================
            float4 frag(Varyings IN) : SV_Target
            {
                // Sample the splash atlas (RGB holds 3 animation frames).  (b4 lines 38-39)
                float4 atlas = SAMPLE_TEXTURE2D_LOD(_RainTex0, sampler_RainTex0, IN.uv, 0.0);

                // Frame select by anim seed (fadeSeed.y) crossing thirds.  (b4 lines 40-41)
                //   seed < 1/3  -> R ;  [1/3,2/3) -> G ;  >= 2/3 -> B.
                float frame = atlas.x;
                frame = mad((IN.fadeSeed.y >= (1.0 / 3.0)) ? 1.0 : 0.0, -frame + atlas.y, frame); // _62
                frame = mad((IN.fadeSeed.y >= (2.0 / 3.0)) ? 1.0 : 0.0, -frame + atlas.z, frame); // SV_Target.w inner

                float4 col;
                col.rgb = _RainColor.rgb;
                col.a   = (frame * _RainColor.w) * IN.fadeSeed.x;   // (b4 line 41)  * fade
                return col;
            }
            ENDHLSL
        }
    }
}
