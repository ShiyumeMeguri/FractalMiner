// HGRP WaterTextureProcess — Unified Fix shader (4 full-screen processing passes for the
//   HGRP water mask/foam/wetness pipeline). NOT a lit surface: every pass is a fullscreen
//   blit that reads simulation render-targets + a packed water-sim constant buffer and writes
//   scalar/vector masks into the water RTs. The fullscreen triangle is generated procedurally
//   from SV_VertexID (the SPIR-V spvBitfieldInsert vertex trick), so no mesh attributes are read.
//
// Merged from: watertextureprocessps.shader (HGRP/WaterTextureProcess), passes:
//   Sub0_Pass0  WaterPrepassTextureProcess      (blob Vertex_b2 / Fragment_b3 base; _b4/_b5 = HG_WATER_DESKTOP_QUALITY_LOW)
//   Sub0_Pass1  WaterProxyDisplacement          (skeleton-inlined blob 7 / 8)
//   Sub0_Pass2  WaterTesellationTextureProcess  (skeleton-inlined blob 10 / 11)
//   Sub0_Pass3  WaterApplyWetnessPS             (skeleton-inlined blob 13 / 14)
// Keywords: HG_WATER_DESKTOP_QUALITY_LOW (Pass0 only)
// Kept: 1:1 math/constants/branch-bounds for all 4 passes — depth->worldXZ reconstruction via
//   _WiderFoVInvViewProjMatrix, foam-noise sampling from the Texture2DArray with two triangle-wave
//   animated layers + a 3rd disturbed layer, ripple-buffer fetch + edge mask, wetness MRT constants,
//   proxy-displacement copy w/ depth passthrough, tessellation color+depth copy.
// Removed (pixel-neutral pipeline infra substituted by URP / SPIR-V cruft dropped):
//   SPIRV_Cross_VertexInfo (gl_BaseVertexARB / SPIRV_Cross_BaseVertex) and the spvBitfieldInsert
//   polyfills — replaced by GetFullScreenTriangleVertexPosition/TexCoord; SPIRV_Cross_Input/_Output
//   I/O statics -> clean Attributes/Varyings; `((-0.0f)-x)` -> -x; register/packoffset/space layouts.
//   #pragma use_dxc / HLSLSupport.cginc (URP provides equivalents).
//
// NOTE: This shader is driven entirely by the HGRP water-simulation system, which has NO URP
//   equivalent. `_WaterData` (1298 x float4 packed sim buffer) and `_WiderFoVInvViewProjMatrix`
//   (widened-FoV inverse VP) are ENGINE-SIDE: their VALUES can only be produced by a host C#
//   WaterSystem ScriptableRenderFeature (sim solve + matrix build), not by any material texture or
//   formula. All math that CONSUMES them is ported 1:1 (depth->world reconstruction, foam fetch,
//   ripple/edge/mirror composite, wetness MRT constants). `_VFXParams0.w` (sim time),
//   `_WaterInteractionParams0`, `_GlobalMipBias`, and the input RTs T0..T5 are likewise fed by that
//   system and exposed here as material bindings so the math stays faithful and inspectable.
//   Texture/data semantics (from sample sites): T0 = foam/ripple noise Texture2DArray (slice index
//   in _WaterData[idx].z/.w bits); T1 = packed water-id (id = round(T1.a*255)); T2 = scene depth
//   (linear-ish, .x==0 means sky/no-water -> early out); T3 = mirror-sampled mask; T4 = ripple
//   accumulation buffer; T5 = secondary ripple buffer. _WaterData stride per water-id = 20 float4,
//   base offset (id*20 + N) then the engine adds the global +10 header for per-id rows.

Shader "HGRP/WaterTextureProcess_Fix"
{
    Properties
    {
        [HideInInspector] _MainTex ("BaseMap", 2D) = "black" {}

        [Header(Water Sim Inputs (fed by HGRP water system))]
        _FoamNoiseArray   ("Foam/Ripple Noise Array (T0)", 2DArray) = "" {}
        _WaterIdTex       ("Water Id (T1, .a*255)", 2D) = "black" {}
        _SceneDepthTex    ("Scene Depth (T2, .x)", 2D) = "black" {}
        _MaskMirrorTex    ("Mask Mirror (T3)", 2D) = "black" {}
        _RippleBufferTex  ("Ripple Buffer (T4)", 2D) = "black" {}
        _RippleBuffer2Tex ("Ripple Buffer 2 (T5)", 2D) = "black" {}
        _ProxyColorTex    ("Proxy/Tess Color (Pass1/2 T0)", 2D) = "black" {}
        _ProxyDepthTex    ("Proxy/Tess Depth (Pass2 T1 / Pass1 T2)", 2D) = "black" {}
        _WetnessMaskTex   ("Wetness Mask (Pass3 T0)", 2D) = "black" {}

        [Header(Water Sim Globals (no URP equivalent))]
        _GlobalMipBias            ("Global Mip Bias", Float) = 0
        _VFXParams0               ("VFX Params0 (.w = sim time)", Vector) = (0,0,0,0)
        _WaterInteractionParams0  ("Water Interaction Params0 (.zw = origin)", Vector) = (0,0,0,0)

        [HideInInspector] _ZTest ("__zt", Float) = 8   // Always
        [HideInInspector] _StencilRef       ("__sref", Float) = 0
        [HideInInspector] _StencilReadMask   ("__srm", Float) = 7
        [HideInInspector] _StencilWriteMask  ("__swm", Float) = 0
    }

    SubShader
    {
        Tags { "RenderPipeline"="UniversalPipeline" }
        LOD 100

        // -----------------------------------------------------------------------------------------
        // Shared HLSL: URP core + the HGRP water-sim bindings + the fullscreen-triangle vertex + helpers
        // -----------------------------------------------------------------------------------------
        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

        // _WaterData packed sim buffer: HGRP declares `cbuffer type_WaterData { float4 _WaterData_f_0[1298] }`
        // (blob Fragment_b3 lines 18-21). Kept verbatim size because every index below (e.g. [13u].z,
        // [idRow19+10u].w) is a literal address into it; all addressing math reading it is ported 1:1.
        // ENGINE-SIDE (cannot be closed in-shader): the 1298 float4 ROWS THEMSELVES are produced and
        //   uploaded each frame by the HGRP water-simulation host system (per-water-id sim state: the
        //   inverse-VP rows [4..7], interaction extents [9],[11],[13], and the per-id 20-row blocks of
        //   foam/ripple/displacement coefficients). No material texture or formula yields these values —
        //   a C# ScriptableRenderFeature (the WaterSystem pass) must compute the sim and bind this buffer
        //   (mirrors HGRP's WaterSystem.PushSimulationData -> ConstantBuffer<ShaderVariablesWater>).
        CBUFFER_START(WaterData)
            float4 _WaterData_f_0[1298];
        CBUFFER_END

        // Sim globals re-exposed as material uniforms (HGRP type_ShaderVariablesGlobal fields).
        // The depth->world reconstruction MATH that consumes this matrix is ported 1:1 in Pass 1
        // (rows [0..3], cols .x/.z/.w; see Frag below). ENGINE-SIDE (cannot be closed in-shader):
        //   _WiderFoVInvViewProjMatrix is a column_major inverse view-projection built from a WIDENED
        //   FoV (so off-screen water reconstructs correctly), an HGRP global at packoffset(c77) — blob
        //   Fragment_b3 line 12 / Fragment_b8 line 148. URP's UNITY_MATRIX_I_VP is the CURRENT camera's
        //   inverse VP (normal FoV), NOT this widened one, so it is not a valid substitute. The host
        //   WaterSystem ScriptableRenderFeature must compute (proj(widenedFoV) * view)^-1 on the CPU and
        //   set it via material.SetMatrix / a CommandBuffer global before this pass.
        CBUFFER_START(UnityPerMaterial)
            float4x4 _WiderFoVInvViewProjMatrix;
            float    _GlobalMipBias;          // blob line 13 (packoffset c108)
            float4   _VFXParams0;             // blob line 14 (packoffset c185); .w = sim time
            float4   _WaterInteractionParams0;// blob line 15 (packoffset c224); .zw = interaction origin
            float4   _MainTex_ST;
        CBUFFER_END

        TEXTURE2D_ARRAY(_FoamNoiseArray);  SAMPLER(sampler_LinearRepeat); // T0  (sampler_LinearRepeat)
        TEXTURE2D(_WaterIdTex);            SAMPLER(sampler_LinearClamp);  // T1  (sampler_LinearClamp)
        TEXTURE2D(_SceneDepthTex);                                        // T2  (sampler_LinearClamp)
        TEXTURE2D(_MaskMirrorTex);         SAMPLER(sampler_LinearMirror); // T3  (sampler_LinearMirror)
        TEXTURE2D(_RippleBufferTex);                                      // T4  (sampler_LinearRepeat)
        TEXTURE2D(_RippleBuffer2Tex);                                     // T5  (sampler_LinearRepeat)
        TEXTURE2D(_ProxyColorTex);         SAMPLER(sampler_PointClamp);   // Pass1/2 color (S0)
        TEXTURE2D(_ProxyDepthTex);                                        // Pass1/2 depth
        TEXTURE2D(_WetnessMaskTex);                                       // Pass3 wetness src

        // asfloat((cond ? 0xffffffff : 0) & 1065353216u) == (cond ? 1.0 : 0.0).
        // 1065353216u == asuint(1.0f); 0xffffffff & 0x3f800000 == 0x3f800000 == 1.0f.
        // blob Fragment_b3 line 71 / skeleton line 245.
        float SelectOne(bool cond) { return cond ? 1.0f : 0.0f; }

        // Triangle wave used for tileable foam-noise crossfade weight:
        // weight = 1 - |(-x)*2 + 1| = 1 - |1 - 2x|. blob Fragment_b3 lines 109,114 / skeleton 227,229.
        float TriWeight(float x) { return ((-abs(mad(-x, 2.0f, 1.0f))) + 1.0f); }

        // ---- Fullscreen-triangle vertex (replaces the SV_VertexID spvBitfieldInsert trick) ----
        // 1:1 with blob Vertex_b2 lines 56-67 (identical in Vertex_b4 lines 56-67): the clip pos AND
        // the uv are BOTH derived from the SAME two vertexID bits, so they are computed together here
        // rather than via two URP helpers (GetFullScreenTriangleTexCoord would re-apply the platform
        // UNITY_UV_STARTS_AT_TOP flip and break the GL Y mapping the foam-RT fetches assume).
        //   bitX = asfloat( spvBitfieldInsert(0, vid, 1, 1) )  -> bit0(vid) placed at bit1 => {0,2}
        //   bitY = asfloat( vid & 2u )                          -> bit1(vid)               => {0,2}
        //   clip.x = bitX*2-1, clip.y = bitY*2-1, z=w=1; uv = (bitX, 1 - bitY).
        // source = Sub0_Pass0_Vertex_b2.hlsl lines 58-66.
        struct AttributesFS { uint vertexID : SV_VertexID; };

        struct VaryingsFS
        {
            float4 positionCS : SV_POSITION;
            float2 uv         : TEXCOORD1;
        };

        VaryingsFS VertFullscreen(AttributesFS input)
        {
            VaryingsFS o;
            // spvBitfieldInsert(0u, vid, 1, 1): Mask=((1<<1)-1)<<1=2 -> ((vid<<1)&2) == bit0(vid)*2.
            float bitX = float((input.vertexID << 1u) & 2u); // _34 (Vertex_b2 line 59) -> {0,2}
            float bitY = float(input.vertexID & 2u);         // _35 (Vertex_b2 line 60) -> {0,2}
            o.positionCS = float4(mad(bitX, 2.0f, -1.0f),    // gl_Position.x (line 61)
                                  mad(bitY, 2.0f, -1.0f),    // gl_Position.y (line 62)
                                  1.0f, 1.0f);               // gl_Position.z=w=1 (lines 65-66)
            o.uv = float2(bitX, (-bitY) + 1.0f);             // TEXCOORD.x=_34, .y=1-_35 (lines 63-64)
            return o;
        }
        ENDHLSL

        // =========================================================================================
        // Pass 0 — WaterPrepassTextureProcess
        // Reconstructs world XZ from depth, fetches ripple/foam, writes foam/wetness scalar + depth.
        // =========================================================================================
        Pass
        {
            Name "WaterPrepassTextureProcess"
            Tags { "LightMode"="WaterPrepassTextureProcess" }
            ZTest Always
            ZWrite Off
            Cull Off

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex VertFullscreen
            #pragma fragment Frag
            // blob: #pragma multi_compile_local _ HG_WATER_DESKTOP_QUALITY_LOW (skeleton line 17)
            #pragma multi_compile_local _ HG_WATER_DESKTOP_QUALITY_LOW

            struct FragOut
            {
                float value : SV_Target0;
                float depth : SV_Depth;
            };

            FragOut Frag(VaryingsFS input)
            {
                FragOut o;
                float2 uv = input.uv;

            #if defined(HG_WATER_DESKTOP_QUALITY_LOW)
                // LOW variant (blob Fragment_b5 lines 28-32): write 0, copy depth through from T0.x.
                // 1:1, source = Sub0_Pass0_Fragment_b5.hlsl lines 30-31
                //   (SV_Target = 0; gl_FragDepth = T0.SampleLevel(sampler_LinearClamp, uv, 0).x).
                // _b5 declares a SINGLE plain Texture2D at register t0 (blob Fragment_b5 line 10), so the
                // foam-array slot is gone and t0 is the scene-depth RT: this is the cheap variant of the
                // SAME WaterPrepassTextureProcess pass, whose base path passes the scene depth straight
                // through (Fragment_b3 line 51 `_62 = T2.x` -> line 139 `gl_FragDepth = _62`). Same source,
                // same sampler (sampler_LinearClamp, s0) -> bind _SceneDepthTex, NOT the Pass1/2 proxy depth.
                o.value = 0.0f;
                o.depth = SAMPLE_TEXTURE2D_LOD(_SceneDepthTex, sampler_LinearClamp, uv, 0).x;
                return o;
            #else
                // ---- BASE variant — blob Fragment_b3 lines 48-140 ----
                float depthSample = SAMPLE_TEXTURE2D_LOD(_SceneDepthTex, sampler_LinearClamp, uv, 0).x; // _60.x (b3 50-51)
                o.depth = depthSample;                                                                  // gl_FragDepth = _62 (b3 139)

                if (depthSample != 0.0f) // (b3 52)
                {
                    // water id = round(T1.a * 255) (b3 54)
                    uint waterId = uint(int(SAMPLE_TEXTURE2D_LOD(_WaterIdTex, sampler_LinearClamp, uv, 0).w * 255.0f));

                    // NDC xy from uv: x = uv.x*2-1, y = -(uv.y*2-1) (b3 55-56)
                    float ndcX = mad(uv.x, 2.0f, -1.0f);
                    float ndcY = -mad(uv.y, 2.0f, -1.0f);

                    // World XZW reconstruction. UNLIKE Pass 1, the base prepass reads the inverse-VP
                    // rows from the _WaterData buffer slots [4],[5],[6],[7] (NOT _WiderFoVInvViewProjMatrix).
                    // Faithful 1:1 to b3 57-59: row0=[4u], row1=[5u], row2=[6u], row3=[7u]; cols .x/.z/.w.
                    // posX = data[6].x*depth + data[4].x*ndcX + ndcY*data[5].x + data[7].x   (b3 57)
                    float wpX = mad(_WaterData_f_0[6u].x, depthSample,
                                    mad(_WaterData_f_0[4u].x, ndcX, ndcY * _WaterData_f_0[5u].x))
                                + _WaterData_f_0[7u].x;
                    float wpZ = mad(_WaterData_f_0[6u].z, depthSample,
                                    mad(_WaterData_f_0[4u].z, ndcX, ndcY * _WaterData_f_0[5u].z))
                                + _WaterData_f_0[7u].z;   // (b3 58)
                    float wpW = mad(_WaterData_f_0[6u].w, depthSample,
                                    mad(_WaterData_f_0[4u].w, ndcX, ndcY * _WaterData_f_0[5u].w))
                                + _WaterData_f_0[7u].w;   // (b3 59)
                    float worldX = wpX / wpW; // _126 (b3 60)
                    float worldZ = wpZ / wpW; // _127 (b3 61)

                    // Interaction-space uv for the mirror mask (b3 62-65)
                    float negHalf = -_WaterData_f_0[13u].z;                       // _137
                    float twoZ    = _WaterData_f_0[13u].z + _WaterData_f_0[13u].z;// _150
                    float interU  = ((-(_WaterInteractionParams0.z + negHalf)) + worldX) / twoZ; // _151
                    float interV  = ((-(_WaterInteractionParams0.w + negHalf)) + worldZ) / twoZ; // _152

                    uint idRow19 = (waterId * 20u) + 19u; // _161
                    uint idRow24 = (waterId * 20u) + 24u; // _164

                    // Mirror-mask term: T3(-interU,-interV).w * row21.w * row22.z (b3 66-68)
                    float mirrorMask =
                        (SAMPLE_TEXTURE2D_LOD(_MaskMirrorTex, sampler_LinearMirror, float2(-interU, -interV), 0).w
                         * _WaterData_f_0[((waterId * 20u) + 21u) + 10u].w)
                        * _WaterData_f_0[((waterId * 20u) + 22u) + 10u].z; // _182

                    // Edge falloff select: 1.0 if (0.5 - len(clamp(inter)-0.5)) >= 0 else 0.0 (b3 69-71)
                    float edgeU = clamp(interU, 0.0f, 1.0f) + (-0.5f); // _186
                    float edgeV = clamp(interV, 0.0f, 1.0f) + (-0.5f); // _188
                    float edgeSelect = SelectOne(((-sqrt(dot(float2(edgeU, edgeV), float2(edgeU, edgeV)))) + 0.5f) >= 0.0f); // _201

                    // Branch: only do the expensive foam sampling when foam/wetness rows are enabled (b3 72)
                    if ((((0.0f < _WaterData_f_0[idRow24 + 10u].x) ? 4294967295u : 0u)
                       | ((0.0f < _WaterData_f_0[idRow19 + 10u].w) ? 4294967295u : 0u)) != 0u)
                    {
                        uint idRow13 = (waterId * 20u) + 13u; // _218
                        uint idRow15 = (waterId * 20u) + 15u; // _220
                        uint idRow18 = (waterId * 20u) + 18u; // _223
                        uint idRow23 = (waterId * 20u) + 23u; // _226

                        // Ripple-buffer fetch: localXZ (relative to row9) -> texel uv via 1/384 (b3 78-91)
                        float locX = worldX + (-_WaterData_f_0[9u].z);  // _235
                        float locZ = worldZ + (-_WaterData_f_0[9u].w);  // _236
                        float ripX = locX + (-_WaterData_f_0[11u].z);   // _244
                        float ripZ = locZ + (-_WaterData_f_0[11u].w);   // _245
                        const float TEXEL = 0.00260416674427688121795654296875f; // 1.0/384.0 (b3 82-84)
                        float centX = mad(ripX, TEXEL, -0.5f); // _253
                        float centZ = mad(ripZ, TEXEL, -0.5f); // _254

                        // T4 ripple at (rip*TEXEL + row11.xy) (b3 84)
                        float4 ripple = SAMPLE_TEXTURE2D_LOD(_RippleBufferTex, sampler_LinearRepeat,
                                            float2(mad(ripX, TEXEL, _WaterData_f_0[11u].x),
                                                   mad(ripZ, TEXEL, _WaterData_f_0[11u].y)), 0); // _262
                        float rX = ripple.x, rY = ripple.y, rZ = ripple.z; // _264/_265/_266

                        // T5 secondary ripple at (loc/row13.w + 0.5) (b3 88)
                        float4 ripple2 = SAMPLE_TEXTURE2D_LOD(_RippleBuffer2Tex, sampler_LinearRepeat,
                                            float2((locX / _WaterData_f_0[13u].w) + 0.5f,
                                                   (locZ / _WaterData_f_0[13u].w) + 0.5f), 0); // _275

                        // Center blend weight: clamp((max(2|centZ|,2|centX|) - 0.9)*10, 0,1) (b3 89)
                        float centerBlend = clamp((max(abs(centZ) + abs(centZ), abs(centX) + abs(centX))
                                                   + (-0.89999997615814208984375f)) * 10.0f, 0.0f, 1.0f); // _285
                        float bX = mad(centerBlend, (-rX) + ripple2.x, rX); // _292
                        float bY = mad(centerBlend, (-rY) + ripple2.y, rY); // _293

                        // Displacement vector from ripple (rows 23/26) (b3 92-101)
                        uint r23p10 = idRow23 + 10u; // _295/_306/_310
                        float negY = -_WaterData_f_0[r23p10].y; // _299
                        float negZ = -_WaterData_f_0[r23p10].z; // _301
                        float dispX = mad(mad(_WaterData_f_0[r23p10].x, bX + negY, _WaterData_f_0[r23p10].y), 2.0f, -1.0f) * 1.0f;   // _325
                        float dispY = mad(mad(_WaterData_f_0[r23p10].x, bY + negZ, _WaterData_f_0[r23p10].z), 2.0f, -1.0f) * (-1.0f);// _326
                        uint r17p10 = ((waterId * 20u) + 17u) + 10u; // _333
                        float dx = dispX * _WaterData_f_0[r17p10].w; // _337
                        float dy = dispY * _WaterData_f_0[r17p10].w; // _338

                        // Foam layer A: triangle-wave phase from sim time (_VFXParams0.w) (b3 102-114)
                        float r18y = _WaterData_f_0[idRow18 + 10u].y;
                        float phaseA = mad(_VFXParams0.w, r18y, -floor(_VFXParams0.w * r18y));    // _357
                        float halfA  = mad(_VFXParams0.w, r18y, 0.5f);                            // _365
                        float halfAf = halfA + (-floor(halfA));                                   // _368
                        float mipBias = mad(0.5f + (-_WaterData_f_0[((waterId * 20u) + 16u) + 10u].w), 10.0f, _GlobalMipBias); // _379
                        float scrollA = mad(_VFXParams0.w, r18y, -phaseA) * r18y;                 // _397
                        uint r15p10 = idRow15 + 10u; // _398/_427/_467/_515/_540
                        // slice index for the array = _WaterData[idRow24+10].z bits (b3 108)
                        float sliceZ = asfloat(asuint(_WaterData_f_0[idRow24 + 10u]).z);
                        float4 foamA = SAMPLE_TEXTURE2D_ARRAY_BIAS(_FoamNoiseArray, sampler_LinearRepeat,
                                          float2(mad(mad(-dx, phaseA, worldX), _WaterData_f_0[r15p10].x, scrollA),
                                                 mad(mad(-dy, phaseA, worldZ), _WaterData_f_0[r15p10].x, scrollA)),
                                          sliceZ, mipBias); // _413
                        float wA = TriWeight(phaseA); // _422

                        // Foam layer A2 (half-phase) (b3 110-114)
                        float scrollA2 = mad(_VFXParams0.w, r18y, -halfAf); // _441
                        uint r18p10 = idRow18 + 10u; // _442
                        float4 foamA2 = SAMPLE_TEXTURE2D_ARRAY_BIAS(_FoamNoiseArray, sampler_LinearRepeat,
                                           float2(mad(scrollA2, _WaterData_f_0[r18p10].y, mad(mad(-dx, halfAf, worldX), _WaterData_f_0[r15p10].x, 0.5f)),
                                                  mad(scrollA2, _WaterData_f_0[r18p10].y, mad(mad(-dy, halfAf, worldZ), _WaterData_f_0[r15p10].x, 0.5f))),
                                           sliceZ, mipBias); // _454
                        float wA2 = TriWeight(halfAf); // _462

                        // Foam layer B (row13 phase) (b3 116-127)
                        uint r13p10 = idRow13 + 10u; // _475(.z)/_486/_546(.y)
                        float r13y = _WaterData_f_0[r13p10].y;
                        float halfB  = mad(_VFXParams0.w, r13y, 0.5f); // _490
                        float oneB   = mad(_VFXParams0.w, r13y, 1.0f); // _491
                        float halfBf = halfB + (-floor(halfB));        // _496
                        float oneBf  = oneB  + (-floor(oneB));         // _497
                        float scrollB  = halfB + (-oneBf);             // _509
                        float scrollB2 = (halfB + (-halfBf)) * r13y;   // _514

                        // slice index for layer B = _WaterData[idRow24+10].w bits (b3 127)
                        float sliceW = asfloat(asuint(_WaterData_f_0[idRow24 + 10u]).w);
                        // Displacement scale for layer B: r15p10.w (_467.w) * r13p10.z (_475.z); uv mul = r15p10.y (_515.y/_540.y).
                        float r15w = _WaterData_f_0[r15p10].w;
                        float r13z = _WaterData_f_0[r13p10].z;
                        float r15y = _WaterData_f_0[r15p10].y;
                        // foamB1: reproject worldX/Z (= wpX/wpW, wpZ/wpW) by halfBf-scaled displacement (b3 127)
                        float foamB1 = SAMPLE_TEXTURE2D_ARRAY_BIAS(_FoamNoiseArray, sampler_LinearRepeat,
                                          float2(mad(mad(-((dispX * r15w) * r13z), halfBf, wpX / wpW), r15y, scrollB2),
                                                 mad(mad(-((dispY * r15w) * r13z), halfBf, wpZ / wpW), r15y, scrollB2)),
                                          sliceW, mipBias).z;
                        // foamB2: oneBf-scaled displacement, +0.5 offset (b3 127)
                        float foamB2 = SAMPLE_TEXTURE2D_ARRAY_BIAS(_FoamNoiseArray, sampler_LinearRepeat,
                                          float2(mad(scrollB, r13y, mad(mad(-((dispX * r15w) * r13z), oneBf, worldX), r15y, 0.5f)),
                                                 mad(scrollB, r13y, mad(mad(-((dispY * r15w) * r13z), oneBf, worldZ), r15y, 0.5f))),
                                          sliceW, mipBias).z;
                        // _563 = mad( foamB1, TriWeight(halfBf), TriWeight(oneBf)*foamB2 ) - 0.5  (b3 127-128)
                        float foamB = mad(foamB1, TriWeight(halfBf), TriWeight(oneBf) * foamB2) + (-0.5f); // _563

                        // ---- Final composite (b3 128) ----
                        // SV = mad(mirrorMask, edgeSelect,
                        //          mad( (foamA.w*wA + wA2*foamA2.w) * row13.x,
                        //               lerp(rZ, ripple2.z, centerBlend),
                        //               mad( foamB, row19.w,
                        //                    (mad(foamA.z, wA, wA2*foamA2.z) - 0.5) * row24.x ) ) )
                        float foamAlpha = mad(foamA.w, wA, wA2 * foamA2.w) * _WaterData_f_0[idRow13 + 10u].x;
                        float zBlend    = mad(centerBlend, (-rZ) + ripple2.z, rZ);
                        float inner = mad(foamB, _WaterData_f_0[idRow19 + 10u].w,
                                          (mad(foamA.z, wA, wA2 * foamA2.z) + (-0.5f)) * _WaterData_f_0[idRow24 + 10u].x);
                        o.value = mad(mirrorMask, edgeSelect, mad(foamAlpha, zBlend, inner));
                    }
                    else
                    {
                        // No foam rows: just the edge-masked mirror term (b3 132)
                        o.value = edgeSelect * mirrorMask;
                    }
                }
                else
                {
                    o.value = 0.0f; // sky / no water (b3 137)
                }
                return o;
            #endif
            }
            ENDHLSL
        }

        // =========================================================================================
        // Pass 1 — WaterProxyDisplacement  (skeleton-inlined blob 7 vert / blob 8 frag, lines 67-262)
        // Same depth->world reconstruction + a single-layer foam fetch; writes one scalar (no depth out).
        // =========================================================================================
        Pass
        {
            Name "WaterProxyDisplacement"
            Tags { "LightMode"="WaterProxyDisplacement" }
            ZTest Always
            ZWrite Off
            Cull Off

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex VertFullscreen
            #pragma fragment Frag

            float Frag(VaryingsFS input) : SV_Target
            {
                float2 uv = input.uv;
                // T2.x depth-ish mask (skeleton 183-185)
                float depthSample = SAMPLE_TEXTURE2D_LOD(_SceneDepthTex, sampler_LinearClamp, uv, 0).x; // _57.x
                if (depthSample != 0.0f) // _59 (skeleton 185)
                {
                    uint waterId = uint(int(SAMPLE_TEXTURE2D_LOD(_WaterIdTex, sampler_LinearClamp, uv, 0).w * 255.0f)); // _72 (187)
                    uint r13 = (waterId * 20u) + 13u; // _75 (188)
                    uint r15 = (waterId * 20u) + 15u; // _78 (189)
                    uint r18 = (waterId * 20u) + 18u; // _81 (190)
                    uint r23 = (waterId * 20u) + 23u; // _84 (191)

                    float ndcX = mad(uv.x, 2.0f, -1.0f);    // _91 (192)
                    float ndcY = -mad(uv.y, 2.0f, -1.0f);   // _95 (193)

                    // depth->world (skeleton 194-198)
                    float wpX = mad(_WiderFoVInvViewProjMatrix[2].x, depthSample,
                                    mad(_WiderFoVInvViewProjMatrix[0].x, ndcX, ndcY * _WiderFoVInvViewProjMatrix[1].x))
                                + _WiderFoVInvViewProjMatrix[3].x; // _131
                    float wpZ = mad(_WiderFoVInvViewProjMatrix[2].z, depthSample,
                                    mad(_WiderFoVInvViewProjMatrix[0].z, ndcX, ndcY * _WiderFoVInvViewProjMatrix[1].z))
                                + _WiderFoVInvViewProjMatrix[3].z; // _132
                    float wpW = mad(_WiderFoVInvViewProjMatrix[2].w, depthSample,
                                    mad(_WiderFoVInvViewProjMatrix[0].w, ndcX, ndcY * _WiderFoVInvViewProjMatrix[1].w))
                                + _WiderFoVInvViewProjMatrix[3].w; // _133
                    float worldX = wpX / wpW; // _136
                    float worldZ = wpZ / wpW; // _137

                    float negHalf = -_WaterData_f_0[13u].z;                        // _146 (199)
                    float twoZ    = _WaterData_f_0[13u].z + _WaterData_f_0[13u].z; // _159 (200)
                    float interU  = ((-(_WaterInteractionParams0.z + negHalf)) + worldX) / twoZ; // _160
                    float interV  = ((-(_WaterInteractionParams0.w + negHalf)) + worldZ) / twoZ; // _161

                    // Ripple fetch T4 (skeleton 203)
                    float4 ripple = SAMPLE_TEXTURE2D_LOD(_RippleBufferTex, sampler_LinearRepeat,
                                        float2(((worldX + (-_WaterData_f_0[9u].z)) / _WaterData_f_0[13u].w) + 0.5f,
                                               ((worldZ + (-_WaterData_f_0[9u].w)) / _WaterData_f_0[13u].w) + 0.5f), 0); // _180
                    float rX = ripple.x, rY = ripple.y; // _182/_183

                    uint r23p10 = r23 + 10u; // _185/_197/_201
                    float negY = -_WaterData_f_0[r23p10].y; // _190
                    float negZ = -_WaterData_f_0[r23p10].z; // _192
                    float dispX = mad(mad(_WaterData_f_0[r23p10].x, rX + negY, _WaterData_f_0[r23p10].y), 2.0f, -1.0f) * 1.0f;   // _217
                    float dispY = mad(mad(_WaterData_f_0[r23p10].x, rY + negZ, _WaterData_f_0[r23p10].z), 2.0f, -1.0f) * (-1.0f);// _218
                    uint r24 = (waterId * 20u) + 24u; // _220
                    uint r17p10 = ((waterId * 20u) + 17u) + 10u; // _231
                    float dx = dispX * _WaterData_f_0[r17p10].w; // _235
                    float dy = dispY * _WaterData_f_0[r17p10].w; // _236

                    float r18y = _WaterData_f_0[r18 + 10u].y;
                    float phaseA = mad(_VFXParams0.w, r18y, -floor(_VFXParams0.w * r18y)); // _255
                    float scrollA = mad(_VFXParams0.w, r18y, -phaseA) * r18y;              // _273
                    uint r15p10 = r15 + 10u; // _274/_295
                    float halfA  = mad(_VFXParams0.w, r18y, 0.5f); // _287
                    float halfAf = halfA + (-floor(halfA));        // _290
                    float scrollA2 = mad(_VFXParams0.w, r18y, -halfAf); // _309
                    uint r18p10 = r18 + 10u; // _310
                    float mipBias = mad(0.5f + (-_WaterData_f_0[((waterId * 20u) + 16u) + 10u].w), 10.0f, _GlobalMipBias); // _326
                    float sliceZ = asfloat(asuint(_WaterData_f_0[r24 + 10u]).z); // (226)

                    float4 foamA = SAMPLE_TEXTURE2D_ARRAY_BIAS(_FoamNoiseArray, sampler_LinearRepeat,
                                      float2(mad(mad(-dx, phaseA, worldX), _WaterData_f_0[r15p10].x, scrollA),
                                             mad(mad(-dy, phaseA, worldZ), _WaterData_f_0[r15p10].x, scrollA)),
                                      sliceZ, mipBias); // _337
                    float wA = TriWeight(phaseA); // _346

                    float4 foamA2 = SAMPLE_TEXTURE2D_ARRAY_BIAS(_FoamNoiseArray, sampler_LinearRepeat,
                                       float2(mad(scrollA2, _WaterData_f_0[r18p10].y, mad(mad(-dx, halfAf, worldX), _WaterData_f_0[r15p10].x, 0.5f)),
                                              mad(scrollA2, _WaterData_f_0[r18p10].y, mad(mad(-dy, halfAf, worldZ), _WaterData_f_0[r15p10].x, 0.5f))),
                                       sliceZ, mipBias); // _353
                    float wA2 = TriWeight(halfAf); // _361

                    // Layer B (row13) (skeleton 230-244)
                    uint r13p10 = r13 + 10u;  // _374(.z)/_385/_484(.y)
                    float r13y = _WaterData_f_0[r13p10].y;
                    float halfB = mad(_VFXParams0.w, r13y, 0.5f); // _389
                    float oneB  = mad(_VFXParams0.w, r13y, 1.0f); // _390
                    float halfBf = halfB + (-floor(halfB));       // _395
                    float oneBf  = oneB  + (-floor(oneB));        // _396
                    float scrollB  = halfB + (-oneBf);            // _447
                    float scrollB2 = (halfB + (-halfBf)) * r13y;  // _452
                    // Displacement scale: r15p10.w (_366=_78+10=r15+10, .w) * r13p10.z (_374=_75+10=r13+10, .z).
                    // uv multiplier: r15p10.y (_453/_478=_78+10=r15+10, .y).
                    float r15w = _WaterData_f_0[r15p10].w;
                    float r13z = _WaterData_f_0[r13p10].z;
                    float r15y = _WaterData_f_0[r15p10].y;
                    float sliceW = asfloat(asuint(_WaterData_f_0[r24 + 10u]).w); // (244)

                    float foamB1 = SAMPLE_TEXTURE2D_ARRAY_BIAS(_FoamNoiseArray, sampler_LinearRepeat,
                                      float2(mad(mad(-((dispX * r15w) * r13z), halfBf, wpX / wpW), r15y, scrollB2),
                                             mad(mad(-((dispY * r15w) * r13z), halfBf, wpZ / wpW), r15y, scrollB2)),
                                      sliceW, mipBias).z; // first T0 in _501
                    float foamB2 = SAMPLE_TEXTURE2D_ARRAY_BIAS(_FoamNoiseArray, sampler_LinearRepeat,
                                      float2(mad(scrollB, r13y, mad(mad(-((dispX * r15w) * r13z), oneBf, worldX), r15y, 0.5f)),
                                             mad(scrollB, r13y, mad(mad(-((dispY * r15w) * r13z), oneBf, worldZ), r15y, 0.5f))),
                                      sliceW, mipBias).z; // second T0 in _501
                    float foamB = mad(foamB1, TriWeight(halfBf), TriWeight(oneBf) * foamB2) + (-0.5f); // _501

                    // Edge select (skeleton 237-238)
                    float edgeU = clamp(interU, 0.0f, 1.0f) + (-0.5f); // _421
                    float edgeV = clamp(interV, 0.0f, 1.0f) + (-0.5f); // _423
                    float edgeSelect = SelectOne(((-sqrt(dot(float2(edgeU, edgeV), float2(edgeU, edgeV)))) + 0.5f) >= 0.0f);

                    // Mirror-mask term (skeleton 245, T3 + rows 21/22)
                    float mirrorMask =
                        (SAMPLE_TEXTURE2D_LOD(_MaskMirrorTex, sampler_LinearMirror, float2(-interU, -interV), 0).w
                         * _WaterData_f_0[((waterId * 20u) + 21u) + 10u].w)
                        * _WaterData_f_0[((waterId * 20u) + 22u) + 10u].z;

                    // Final composite (skeleton 245):
                    //   mad(foamAlpha, ripple.z, mad(mirrorMask, edgeSelect, mad(foamB, row19.w, foamZ*row24.x)))
                    float foamAlpha = mad(foamA.w, wA, wA2 * foamA2.w) * _WaterData_f_0[r13 + 10u].x;
                    float inner = mad(foamB, _WaterData_f_0[((waterId * 20u) + 19u) + 10u].w,
                                      (mad(foamA.z, wA, wA2 * foamA2.z) + (-0.5f)) * _WaterData_f_0[r24 + 10u].x);
                    return mad(foamAlpha, ripple.z, mad(mirrorMask, edgeSelect, inner));
                }
                return 0.0f; // skeleton 249
            }
            ENDHLSL
        }

        // =========================================================================================
        // Pass 2 — WaterTesellationTextureProcess (skeleton-inlined blob 11, lines 388-396)
        // Plain copy: color RGBA from T0, depth from T1.x. Writes stencil ref (Replace).
        // =========================================================================================
        Pass
        {
            Name "WaterTesellationTextureProcess"
            Tags { "LightMode"="WaterTesellationTextureProcess" }
            ZTest Always
            ZWrite Off
            Cull Off
            Stencil { Ref [_StencilRef] Comp Always Pass Replace Fail Keep ZFail Keep }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex VertFullscreen
            #pragma fragment Frag

            struct FragOut
            {
                float4 color : SV_Target0;
                float  depth : SV_Depth;
            };

            FragOut Frag(VaryingsFS input)
            {
                FragOut o;
                o.color = SAMPLE_TEXTURE2D_LOD(_ProxyColorTex, sampler_PointClamp, input.uv, 0);        // _37 (blob 390-394)
                o.depth = SAMPLE_TEXTURE2D_LOD(_ProxyDepthTex, sampler_PointClamp, input.uv, 0).x;      // (blob 395)
                return o;
            }
            ENDHLSL
        }

        // =========================================================================================
        // Pass 3 — WaterApplyWetnessPS (skeleton-inlined blob 14, lines 557-580)
        // 5 MRTs of mostly-constant wetness defaults; MRT3.w / MRT4.w come from T0 (wetness mask).
        // Per-RT Blend/ColorMask preserved from skeleton lines 414-423.
        // =========================================================================================
        Pass
        {
            Name "WaterApplyWetnessPS"
            Tags { "LightMode"="WaterApplyWetnessPS" }
            Blend 0 DstColor Zero, DstColor Zero
            ColorMask RGB 0
            Blend 1 Zero One, Zero One
            ColorMask 0 1
            Blend 2 Zero One, Zero One
            ColorMask 0 2
            Blend 3 DstColor Zero, DstColor Zero
            ColorMask R 3
            Blend 4 DstColor Zero, DstColor Zero
            ColorMask RGB 4
            ZWrite Off
            Cull Off
            Stencil { Ref [_StencilRef] ReadMask [_StencilReadMask] WriteMask [_StencilWriteMask] Comp Equal Pass Keep Fail Keep ZFail Keep }

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex VertFullscreen
            #pragma fragment Frag

            struct FragOut
            {
                float4 t0 : SV_Target0;
                float4 t1 : SV_Target1;
                float4 t2 : SV_Target2;
                float4 t3 : SV_Target3;
                float4 t4 : SV_Target4;
            };

            FragOut Frag(VaryingsFS input)
            {
                FragOut o;
                // blob 14 lines 559-579
                o.t0 = float4(1.0f, 1.0f, 1.0f, 1.0f);
                o.t1 = float4(0.0f, 0.0f, 0.0f, 0.0f);
                o.t2 = float4(0.0f, 0.0f, 0.0f, 0.0f);
                float4 wet = SAMPLE_TEXTURE2D_BIAS(_WetnessMaskTex, sampler_LinearClamp, input.uv, _GlobalMipBias); // _67 (line 574)
                o.t3 = float4(0.5f, 0.5f, 1.0f, wet.y); // .w = _67.y (line 575)
                o.t4 = float4(1.0f, 1.0f, 1.0f, wet.x); // .w = _67.x (line 576)
                return o;
            }
            ENDHLSL
        }
    }
}
