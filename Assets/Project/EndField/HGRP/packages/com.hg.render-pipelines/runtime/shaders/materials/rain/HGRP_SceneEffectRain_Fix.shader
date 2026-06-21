// SceneEffectRain — procedural rain/snow streak billboard overlay (single transparent ForwardOnly pass).
// Merged from: sceneeffectrain.shader BASE variant (catch-all #else):
//   Sub0_Pass0_Vertex_b4.hlsl  (Keywords: HG_ENABLE_MV)        — streak geometry build + camera-relative reprojection
//   Sub0_Pass0_Fragment_b5.hlsl (Keywords: HG_ENABLE_MV)       — noise sample + tent edge-fade + distance/near fade -> _RainColor
// Keywords: _RAIN_LIGHTING (optional ambient tint, see NOTE), _SNOW_COLLISION (no-op on geometry — see NOTE)
// Kept: the full procedural per-particle streak displacement (grid-cell snap, wind/fall direction frame,
//       sine streak wobble, screen-space width correction, billboard facing), the fragment tent edge-fade,
//       distance-fade + near-fade, _RainTex0 noise alpha remap, _RainColor output. All MATH 1:1 from b4/b5.
// Removed (pixel-neutral pipeline infra substituted by URP, or HGRP-only globals with no URP equivalent):
//   - camera-relative-rendering (RWS) globals _WorldSpaceCameraPos_Internal/_PrevCamPosRWS_Internal,
//     _NonJitteredViewNoTransProjMatrix/_PrevNonJitteredViewNoTransProjMatrix -> URP TransformWorldToHClip / UNITY_MATRIX_VP
//     (VP_noTrans * (posWS-camPos) == VP * posWS; result identical).
//   - TAA jitter (_TaaJitterStrength.zw applied to gl_Position.xy) — pixel-neutral, dropped.
//   - motion-vector previous-frame reprojection (TEXCOORD_3 / _PrevNonJitteredViewNoTransProjMatrix / HG_ENABLE_MV) — MV target dropped.
//   - SV_Target1 GBuffer-normal write (0.5,0.5,1,0) — URP forward has no second target.
//   - _GlobalMipBias on noise sample -> SAMPLE_TEXTURE2D (bias 0).
//
// Ported (closed 1:1 from b5/b9; HGRP CBUFFER globals re-exposed as material data — §2 INFRA table):
//   - vertical-occlusion rain-wetness shadow (b5:90-103): _VerticalOcclusionMap + _WorldToVerticalOcclusionMap +
//     _VerticalOcclusionMapScrollOffset + gate _RainWetnessParam4.y, SampleCmpLevelZero. WS = interpolated positionWS
//     (== the source's _InvViewProjMatrix depth-reconstruction). Host rain-wetness system binds matrix/offset/gate.
//   - RAIN_LIGHTING output blend (b9:1450-1457): lerp(_RainColor.rgb, SH*_RainColor.rgb*_EnvironmentGlobalParams0.x,
//     _RainMaskParams.y) + luminance alpha boost; SH-diffuse ambient (b9:541-543 _IVDefaultSHA*) -> URP SampleSH(viewNormal).
//
// ENGINE-SIDE (only legitimate residue — needs an HGRP host render-feature/GPU buffer, NOT a material texture/formula):
//   - RAIN_LIGHTING higher-order IV/clipmap SH bands + sky-occlusion term (_GraphicsFeaturesGlobalParam0.z) +
//     reflection-probe term (Fragment_b9 _IVParam*/_IVDefaultSHA clipmap loop + ByteAddressBuffer light binning +
//     _ReflectionProbeGlobalDatas[32]). These additive terms are held at the SOURCE DEFAULT 0 (b9:652-654/900-902/
//     954-957), so the ported blend equals b9 exactly when the host image-volume-clipmap GI + reflection-probe
//     binning systems are absent; wiring them requires those C# systems to fill the StructuredBuffers.
//
// NOTE: _SNOW_COLLISION is byte-identical to the base in the VERTEX stage (b6 == b4) and only re-routes the FRAGMENT
//   to the heavy RAIN_LIGHTING-style path; with the engine-side GI residue absent it has no pixel-distinct math here,
//   so it is kept only as a declared keyword (no behavioral branch). _RAIN_LIGHTING now reproduces the b9 output-blend
//   structure 1:1, fed by URP SampleSH as the faithful stand-in for the IV-clipmap default-SH diffuse.
// _RainParams      = (.x phase/time, .y minWidth, .z lengthScale, .w densityCull-vs-instanceLOD).
// _RainDirectionParams = (.x worldX, .y worldY, .z worldZ wind/fall target, .w sideSwayAmplitude).
// _RainMaskParams  = (.z extraWidthScale; .x/.y/.w unused in BASE).
// _RainTex0_ST     = (.xy noise UV scale, .z noise bias add, .w noise contrast scale).
// Mesh channels: TEXCOORD0(.xy) = quad corner reference pos, TEXCOORD1 = (.x noisePhaseX,.y density/LOD key,.z noisePhaseZ),
//   POSITION = quad corner OS, TEXCOORD4 = previous-frame OS (MV, dropped).

Shader "HGRP/SceneEffectRain_Fix"
{
    Properties
    {
        _RainTex0 ("Rain Noise (R)", 2D) = "white" {}
        _RainParams ("Rain Params (x:phase y:minWidth z:lenScale w:densityCull)", Vector) = (1, 1, 1, 1)
        [HDR] _RainColor ("Rain Color", Color) = (1, 1, 1, 1)
        _RainDirectionParams ("Rain Direction (xyz:windTarget w:sway)", Vector) = (0, 0, 0, 0)
        _RainMaskParams ("Rain Mask (y:lightingBlend z:widthScale)", Vector) = (0, 0, 0, 0)
        _RainSmear ("Rain View-Normal Smear (was _RainWetnessGlobalParam4.z)", Float) = 0

        [Toggle(_RAIN_LIGHTING)] _RainLighting ("Rain Lighting (ambient tint)", Float) = 0
        [Toggle(_SNOW_COLLISION)] _SnowCollision ("Snow Collision (keyword only)", Float) = 0

        // Vertical-occlusion rain-wetness shadow (HGRP rain-wetness globals re-exposed as material data — see §2 INFRA table).
        // _RainWetnessParam4.y gates the SampleCmp; .z drives _RainSmear (above). Host rain-wetness system binds these.
        [HDR] _EnvironmentGlobalParams0 ("Environment Global Params0 (.x ambient .y skyMul)", Vector) = (1, 1, 1, 1)
        _RainWetnessParam4 ("Rain Wetness Param4 (.y occlusionEnable)", Vector) = (0, 0, 0, 0)
        _VerticalOcclusionMap ("Vertical Occlusion Map (depth)", 2D) = "white" {}
        _VerticalOcclusionMapScrollOffset ("Vert-Occlusion UV Scroll Offset", Vector) = (0, 0, 0, 0)

        // Blend-state plumbing (driven by material editor; BASE = SrcAlpha/OneMinusSrcAlpha, ZWrite Off, Cull Off).
        [HideInInspector] _SrcBlend ("__src", Float) = 5   // SrcAlpha
        [HideInInspector] _DstBlend ("__dst", Float) = 10  // OneMinusSrcAlpha
        [HideInInspector] _ZWrite ("__zw", Float) = 0
        [HideInInspector] _Cull ("__cull", Float) = 0      // Off
    }

    SubShader
    {
        Tags
        {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
        }
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _RainTex0_ST;
                float4 _RainColor;
                float4 _RainParams;
                float4 _RainDirectionParams;
                float4 _RainMaskParams;
                float  _RainSmear;
                // Vertical-occlusion rain shadow + RAIN_LIGHTING blend (HGRP globals re-exposed; §2 INFRA table).
                float4 _EnvironmentGlobalParams0;                 // b9:42  (.x ambient mul, .y sky mul)
                float4 _RainWetnessParam4;                        // b5:41  _RainWetnessGlobalParam4 (.y occlusion gate)
                float4 _VerticalOcclusionMapScrollOffset;         // b5:47  UV scroll offset
                float4x4 _WorldToVerticalOcclusionMap;            // b5:46  world->occlusion-map (host SetMatrix)
            CBUFFER_END

            TEXTURE2D(_RainTex0);              SAMPLER(sampler_RainTex0);
            // Vertical-occlusion depth map sampled with a comparison sampler (b5:56,59 T0 / SampleCmpLevelZero).
            TEXTURE2D(_VerticalOcclusionMap); SAMPLER_CMP(sampler_VerticalOcclusionMap);

            // Magic-constant decodes (all from b4/b5):
            static const float RAIN_TWO_PI = 6.283185482025146484375;     // b4:148,149  (2*pi). Renamed from TWO_PI: URP Core Macros.hlsl:24 defines a 'TWO_PI' macro -> name clash (syntax error). Value byte-identical to b4.
            static const float PI_CONST  = 3.1415927410125732421875;      // b4:161      (pi)
            static const float FOUR_TENTHS_PI = 1.256637096405029296875;  // b4:160      (0.4*pi == 2*pi*0.2)
            static const float FLT_MIN_C = 1.1754943508222875079687365372222e-38; // b4:166 (FLT_MIN, degenerate-len guard)
        ENDHLSL

        Pass
        {
            Name "SceneEffectRain"
            Tags { "LightMode"="UniversalForwardOnly" }

            Blend [_SrcBlend] [_DstBlend], One One   // source: 'Blend SrcAlpha OneMinusSrcAlpha, One One' (separate alpha-channel additive) — sceneeffectrain.shader:12
            ZWrite [_ZWrite]
            ZTest LEqual          // source: ZClip On, depth-tested transparent
            Cull [_Cull]

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag

            #pragma shader_feature_local _RAIN_LIGHTING
            #pragma shader_feature_local _SNOW_COLLISION

            struct Attributes
            {
                float3 positionOS : POSITION;    // b4: POSITION  (quad corner, object space)
                float4 cornerRef  : TEXCOORD0;   // b4: TEXCOORD  (.xy quad corner reference pos)
                float4 noiseKey   : TEXCOORD1;   // b4: TEXCOORD_1(.x phaseX,.y density/LOD,.z phaseZ)
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                // b4 SPIRV_Cross_Output: TEXCOORD_2 (TEXCOORD1) packs corner-sign + noise UV
                float4 cornerUV   : TEXCOORD0;   // .xy corner sign (0..1), .zw noise UV
                // b4: TEXCOORD_1_1 (TEXCOORD2) .x = distance fade (smoothstep), .yzw = 1
                float4 fade       : TEXCOORD1;
                float3 positionWS : TEXCOORD2;   // for ambient (RAIN_LIGHTING) + view dir
            };

            // ------------------------------------------------------------------
            // Vertex — procedural streak build. 1:1 from Sub0_Pass0_Vertex_b4.hlsl:88-221.
            // ------------------------------------------------------------------
            Varyings vert(Attributes v)
            {
                Varyings o = (Varyings)0;

                // World-space position of the quad corner (b4:90-92 build camera-RELATIVE pos
                // _92/_93/_94 = ObjectToWorld*POSITION - camPos; here we keep plain WS and subtract
                // camera pos only where the source does, since final reprojection is VP*posWS either way).
                float3 posWS = TransformObjectToWorld(v.positionOS);          // == _unity_ObjectToWorld * POSITION
                float3 objOriginWS = float3(unity_ObjectToWorld._m03,
                                            unity_ObjectToWorld._m13,
                                            unity_ObjectToWorld._m23);        // b4: _unity_ObjectToWorld[3u].xyz

                // density / per-instance LOD cull (b4:107). Cull by emitting a degenerate (NaN) clip vertex.
                if (_RainParams.w >= v.noiseKey.y)
                {
                    // object uniform scale = |ObjectToWorld column0| (b4:109-112)
                    float3 c0 = float3(unity_ObjectToWorld._m00, unity_ObjectToWorld._m10, unity_ObjectToWorld._m20);
                    float scale = sqrt(dot(c0, c0));          // _302
                    float cell  = scale + scale;              // _303  (grid cell = 2*scale)

                    // noiseKey remapped to [-1,1] (b4:114-116)
                    float k0 = mad(v.noiseKey.x, 2.0, -1.0);  // _310
                    float k1 = mad(v.noiseKey.y, 2.0, -1.0);  // _313
                    float k2 = mad(v.noiseKey.z, 2.0, -1.0);  // _314

                    // quad corner sign from (corner - cornerRef) (b4:117-120). sign() in {-1,0,1}.
                    float dx = v.positionOS.x - v.cornerRef.x;   // _325
                    float dy = v.positionOS.y - v.cornerRef.y;   // _326
                    float signX = sign(dx);                      // _341
                    float signY = sign(dy);                      // _342

                    // snap object origin XZ to grid cell, then place the corner within the cell (b4:121-124)
                    float gx = floor(objOriginWS.x / cell);      // _349
                    float gz = floor(objOriginWS.z / cell);      // _350
                    float cellX = mad(gx, cell, mad(((mad(-gx, cell, objOriginWS.x) >= mad(v.cornerRef.x, scale, scale)) ? 1.0 : 0.0), cell, scale * v.cornerRef.x)); // _378
                    float cellZ = mad(gz, cell, mad(((mad(-gz, cell, objOriginWS.z) >= mad(v.positionOS.z, scale, scale)) ? 1.0 : 0.0), cell, scale * v.positionOS.z)); // _379
                    float cellY = objOriginWS.y;                 // _384

                    // wind/fall direction = (RainDirection - cellPos) (b4:393-405), normalized -> (d3,d4,d5)
                    float wY = -cellY  + _RainDirectionParams.y;  // _393
                    float wZ = -cellZ  + _RainDirectionParams.z;  // _394
                    float wX = -cellX  + _RainDirectionParams.x;  // _395
                    float wLen2 = dot(float3(wY, wZ, wX), float3(wY, wZ, wX)); // _396
                    float wLen  = sqrt(wLen2);                    // _399
                    float streakLen = wLen * 0.800000011920928955078125; // _400  (0.8 * distance)
                    float wInv = rsqrt(wLen2);                    // _402
                    float dirY = wY * wInv;                       // _403
                    float dirZ = wZ * wInv;                       // _404
                    float dirX = wX * wInv;                       // _405

                    // build orthonormal frame around the fall direction (b4:412-431)
                    float t0 = mad(dirX, 0.0, -(dirZ * 1.0));     // _412
                    float t1 = mad(dirY, 1.0, -(dirX * 0.0));     // _413
                    float tInv = rsqrt(dot(float2(t0, t1), float2(t0, t1))); // _419
                    float bx = tInv * t0;                         // _420
                    float by = tInv * t1;                         // _421
                    float bz = tInv * mad(dirZ, 0.0, -(dirY * 0.0)); // _422
                    float nx = mad(by, dirX, -(dirZ * bz));       // _429
                    float ny = mad(bz, dirY, -(dirX * bx));       // _430
                    float nz = mad(bx, dirZ, -(dirY * by));       // _431

                    // streak animation phase (b4:439-465)
                    float phase    = frac(v.cornerRef.y - _RainParams.x);  // _439
                    float phaseSum = v.cornerRef.y + _RainParams.x;        // _445
                    float sway     = (scale * k1) * _RainDirectionParams.w; // _450
                    float a0 = mad(phaseSum, 0.5, k0) * RAIN_TWO_PI;             // _455
                    float a1 = mad(phaseSum, 0.20000000298023223876953125, k2) * RAIN_TWO_PI; // _457
                    float c0a = cos(a0);                                    // _460
                    float c1a = cos(a1);                                    // _461
                    float s0a = k0 * sin(a0);                               // _464
                    float s1a = k2 * sin(a1);                               // _465
                    float swayU = sway * mad(c0a, k0, s0a);                 // _468
                    float swayV = dot(mad(c1a, k2, s1a).xx, sway.xx);       // _469

                    // displaced streak position (b4:479-485)
                    float along = streakLen * mad(phase, 2.0, -1.0);       // _479
                    float px = cellX + mad(dirX, along, mad(nz, swayU, swayV * bz)); // _483
                    float py = cellY + mad(dirY, along, mad(nx, swayU, swayV * bx)); // _484
                    float pz = cellZ + mad(dirZ, along, mad(ny, swayU, swayV * by)); // _485

                    // streak tangent (for billboard width direction) (b4:494-516)
                    float tanA = sway * mad(k2 * c1a, FOUR_TENTHS_PI, -(s1a * FOUR_TENTHS_PI)); // _494
                    float tanB = sway * mad(s0a, -PI_CONST, (k0 * c0a) * PI_CONST);            // _495
                    float tanC = (phase * wLen) * (-1.60000002384185791015625);               // _503
                    float sx = mad(dirY, tanC, mad(nx, tanB, tanA * bx));   // _505
                    float sy = mad(dirZ, tanC, mad(ny, tanB, tanA * by));   // _506
                    float sz = mad(dirX, tanC, mad(nz, tanB, tanA * bz));   // _507
                    float sInv = rsqrt(max(dot(float3(sx, sy, sz), float3(sx, sy, sz)), FLT_MIN_C)); // _513
                    float stx = sx * sInv;                                  // _514
                    float sty = sy * sInv;                                  // _515
                    float stz = sz * sInv;                                  // _516

                    // distance of displaced streak from object origin (b4:525-531)
                    float ox = px - objOriginWS.x;                          // _525
                    float oy = py - objOriginWS.y;                          // _526
                    float oz = pz - objOriginWS.z;                          // _527
                    float dist = sqrt(dot(float3(ox, oy, oz), float3(ox, oy, oz))); // _531

                    // screen-space width correction (b4:553-572).
                    // _ProjMatrix[1].y -> UNITY_MATRIX_P._m11 (vertical FOV term);
                    // _ScreenParams.z = 1 + 1/width -> (_ScreenParams.z - 1) used.
                    float widthBase = max(((((-1.0) / UNITY_MATRIX_P._m11) * dist) * (-1.0 + _ScreenParams.z)) * (3.0 + _RainMaskParams.z), _RainParams.y); // _553
                    float distFadeIn = -min(dist, 1.0) + 1.0;              // _556
                    float widthX = mad(widthBase * distFadeIn, 14.0, widthBase);            // _558
                    float widthY = mad(distFadeIn * _RainParams.z, 6.5, _RainParams.z);     // _567
                    float wOffX = signX * widthX;                          // _569
                    float wOffY = signY * widthY;                          // _570
                    float cornerSX = clamp(signX, 0.0, 1.0);              // _571
                    float cornerSY = clamp(signY, 0.0, 1.0);              // _572

                    // ground-plane projected direction of the cell from origin (b4:581-589)
                    float fx = cellX - objOriginWS.x;                      // _581
                    float fz = cellZ - objOriginWS.z;                      // _583
                    float fInv = rsqrt(dot(float2(fx, fz), float2(fx, fz))); // _587
                    float fnx = fInv * fx;                                 // _588
                    float fnz = fInv * fz;                                 // _589

                    // camera-forward basis from view matrix (b4:594-604): _ViewMatrix[*].z -> UNITY_MATRIX_V._m2*
                    float camFwdX = UNITY_MATRIX_V._m20;                   // _594
                    float camFwdY = UNITY_MATRIX_V._m21;                   // _599
                    float camFwdZ = UNITY_MATRIX_V._m22;                   // _604

                    // billboard-blend factor by distance (b4:612-637): smoothstep over [0.4*scale .. scale]
                    float bb = clamp(mad(-scale, 0.4000000059604644775390625, dist) * (1.0 / (scale * 0.60000002384185791015625)), 0.0, 1.0); // _612
                    float bbS = (bb * bb) * mad(bb, -2.0, 3.0);            // _616  (smoothstep)
                    float vbX = mad(bbS, mad(fx, fInv, camFwdX), -camFwdX); // _623
                    float vbY = mad(bbS, mad(cellY - objOriginWS.y, fInv, camFwdY), -camFwdY); // _624
                    float vbZ = mad(bbS, mad(fz, fInv, camFwdZ), -camFwdZ); // _625
                    float vbInv = rsqrt(dot(float3(vbX, vbY, vbZ), float3(vbX, vbY, vbZ))); // _629
                    float vbZn = vbInv * vbZ;                              // _630
                    float vbXn = vbInv * vbX;                              // _631
                    float vb2Inv = rsqrt(dot(float2(vbZn, vbXn), float2(vbZn, vbXn))); // _635
                    float vbZ2 = vb2Inv * vbZn;                            // _636
                    float vbX2 = vb2Inv * vbXn;                            // _637

                    // final corner WS position: streak pos + width offsets along billboard tangents,
                    // plus view-normal smear (_RainWetnessGlobalParam4.z -> _RainSmear) (b4:662-692).
                    float gpInv = rsqrt(max(dot(float2(fnx, fnz), float2(fnx, fnz)), FLT_MIN_C)); // _662
                    float wpX = mad(gpInv * fnx, _RainSmear, dot(float3(mad(0.0, sty, -(stx * vbZ2)), stz, px), float3(wOffX, wOffY, 1.0))); // _690
                    float wpY = mad(gpInv * _RainSmear, 0.0, dot(float3(mad(vbZ2, stz, -(sty * vbX2)), stx, py), float3(wOffX, wOffY, 1.0))); // _691
                    float wpZ = mad(gpInv * fnz, _RainSmear, dot(float3(mad(vbX2, stx, -(stz * 0.0)), sty, pz), float3(wOffX, wOffY, 1.0))); // _692
                    float3 finalWS = float3(wpX, wpY, wpZ);

                    // reproject: source uses _NonJitteredViewNoTransProjMatrix * (finalWS) with TAA jitter (dropped).
                    // VP_noTrans * (posWS - camPos) == VP * posWS -> TransformWorldToHClip(finalWS). (b4:207-215)
                    o.positionCS = TransformWorldToHClip(finalWS);
                    o.positionWS = finalWS;

                    // corner sign + noise UV (b4:210-217):
                    // TEXCOORD_2.z = 2*(cornerSX*widthX) - k0 ; .w = signY*widthY - streakLen*(k1+phase)
                    o.cornerUV.x = cornerSX;                                                       // _571
                    o.cornerUV.y = cornerSY;                                                       // _572
                    o.cornerUV.z = mad(2.0, cornerSX * widthX, -mad(v.noiseKey.x, 2.0, -1.0));     // _ (b4:210)
                    o.cornerUV.w = mad(cornerSY, widthY, -(streakLen * (k1 + phase)));             // _ (b4:211)

                    // distance fade (b4:762, 213): smoothstep(0,1, dist-0.5)
                    float df = clamp(dist + (-0.5), 0.0, 1.0);                                     // _762
                    o.fade.x = (df * df) * mad(df, -2.0, 3.0);                                     // smoothstep
                    o.fade.yzw = float3(1.0, 1.0, 1.0);
                }
                else
                {
                    // density cull -> NaN clip pos collapses the triangle (b4:224-235)
                    o.positionCS = asfloat(0x7fc00000u).xxxx;
                    o.cornerUV   = float4(0.0, 0.0, 0.0, 0.0);
                    o.fade       = float4(0.0, 0.0, 0.0, 0.0);
                    o.positionWS = posWS;
                }
                return o;
            }

            // ------------------------------------------------------------------
            // Fragment — noise + tent fade -> _RainColor. 1:1 from Sub0_Pass0_Fragment_b5.hlsl:84-111.
            // ------------------------------------------------------------------
            half4 frag(Varyings input) : SV_Target
            {
                // rain noise sample (b5:86): T1 = _RainTex0, UV = cornerUV.zw * _RainTex0_ST.xy.
                // _GlobalMipBias dropped -> plain sample.
                float4 noise = SAMPLE_TEXTURE2D(_RainTex0, sampler_RainTex0,
                                   float2(input.cornerUV.z * _RainTex0_ST.x,
                                          input.cornerUV.w * _RainTex0_ST.y));

                // tent edge-fade in corner space (b5:87-88): tent(x) = 0.5 - |0.5 - x|
                float tentX = -abs(-input.cornerUV.x + 0.5) + 0.5;   // _86
                float tentY = -abs(-input.cornerUV.y + 0.5) + 0.5;   // _87

                // vertical-occlusion rain shadow (b5:90-103). 1:1: gated by _RainWetnessParam4.y > 0.5; when off, 1.0.
                // The source reconstructs WS from gl_FragCoord+depth via _InvViewProjMatrix (b5:92-97) — that WS IS
                // the streak fragment position, which the port already carries interpolated, so use input.positionWS
                // directly (identical value; depth-reconstruction infra -> URP-carried positionWS, §2).
                float occlusion = 1.0;   // b5:102 else-branch  asfloat(1065353216u) == 1.0
                if (_RainWetnessParam4.y > 0.5)   // b5:90
                {
                    // world -> vertical-occlusion-map transform (b5:98). mul(mtx, float4(WS,1)) == the row dots.
                    float3 occMap = mul((float3x3)_WorldToVerticalOcclusionMap, input.positionWS)
                                  + float3(_WorldToVerticalOcclusionMap._m03,
                                           _WorldToVerticalOcclusionMap._m13,
                                           _WorldToVerticalOcclusionMap._m23);
                    // UV: u = occ.x*0.5 + scroll.x + 0.5 ; v = -(occ.y*0.5 + 0.5) + scroll.y + 1.0  (b5:98)
                    float occU = mad(occMap.x, 0.5, _VerticalOcclusionMapScrollOffset.x) + 0.5;
                    float occV = (-mad(occMap.y, 0.5, 0.5) + _VerticalOcclusionMapScrollOffset.y) + 1.0;
                    // compare depth = max(occ.z, 0.00048828125)  (b5:98 z-arg)
                    float occZ = max(occMap.z, 0.00048828125);
                    occlusion = SAMPLE_TEXTURE2D_SHADOW(_VerticalOcclusionMap, sampler_VerticalOcclusionMap,
                                                        float3(occU, occV, occZ));   // b5:98 SampleCmpLevelZero
                }

                // alpha (b5:104). Source reads vertex TEXCOORD_1_1 as fragment TEXCOORD_1:
                //   TEXCOORD_1.y == fade.y (==1.0), TEXCOORD_1.x == fade.x (distance fade).
                //   A = (fade.y * _RainColor.w)
                //       * ( (2*tentY clamped) * (2*tentX clamped) * occlusion ) * fade.x * remap(noise.x)
                //   remap(noise.x) = _RainTex0_ST.z + _RainTex0_ST.w * (2*noise.x - 1)
                float noiseRemap = mad(_RainTex0_ST.w, mad(noise.x, 2.0, -1.0), _RainTex0_ST.z);
                float tentTerm = max(tentY + tentY, 0.0) * max(tentX + tentX, 0.0);   // b9:280 _234
                float alpha = (input.fade.y * _RainColor.w)
                            * (((tentTerm * occlusion) * input.fade.x) * noiseRemap);   // == b9:_315 outer-scaled

                // color (b5:105-107) = _RainColor.rgb.
                float3 color = _RainColor.rgb;

                #ifdef _RAIN_LIGHTING
                    // RAIN_LIGHTING output blend — 1:1 from Sub0_Pass0_Fragment_b9.hlsl:1450-1457.
                    // The GI irradiance _706/_711/_716 (b9:541-543) is an SH-diffuse evaluation built from the
                    // IV-default SH coeffs _IVDefaultSHA* in the streak view-normal direction; per §2 the IV-clipmap
                    // ambient maps to URP SampleSH(normal). The streak view-normal is the world view-vector from the
                    // streak to the camera (b9:268-275: persp -> camPos - posWS, ortho -> _ViewMatrix col2).
                    //   ENGINE-SIDE (held at source defaults 0 — b9:652-654 sky _1413-15, b9:900-902 _2361-63,
                    //   b9:954-957 reflection _2453/_2457-61): the higher-order IV-clipmap SH bands, the sky-occlusion
                    //   term (_GraphicsFeaturesGlobalParam0.z), and the reflection-probe term require the HGRP
                    //   image-volume-clipmap GI render-feature + reflection-probe ByteAddressBuffer binning to fill.
                    float3 viewVec = (unity_OrthoParams.w > 0.5)
                                     ? float3(UNITY_MATRIX_V._m20, UNITY_MATRIX_V._m21, UNITY_MATRIX_V._m22)  // b9:269-271 ortho (_ViewMatrix col2)
                                     : (_WorldSpaceCameraPos - input.positionWS);                            // b9:269-271 persp (camPos - posWS)
                    float3 viewNormal = viewVec * rsqrt(max(dot(viewVec, viewVec), 9.9999999392252902907785028219223e-09)); // b9:272-275
                    float3 ambient = SampleSH(viewNormal);   // b9:541-543 (_IVDefaultSHA* diffuse SH -> URP SampleSH, §2)

                    // irradiance = SH * _RainColor.rgb * _EnvironmentGlobalParams0.x  (b9:1450-1452, engine-side adds = 0).
                    float3 irradiance = (ambient * _RainColor.rgb) * _EnvironmentGlobalParams0.x;
                    // color = lerp(_RainColor.rgb, irradiance, _RainMaskParams.y)  (b9:1454-1456).
                    color = mad(_RainMaskParams.y.xxx, irradiance - _RainColor.rgb, _RainColor.rgb);

                    // alpha luminance boost (b9:1457): _2703 = _234^3; factor = (_2703^2)*luminance(irradiance).
                    //   A = base_315 * (1 + _RainMaskParams.y*((_234^3)^2 * lum(irr) - 1)).
                    float t3   = tentTerm * (tentTerm * tentTerm);                                          // b9:1453 _2703
                    float lumI = dot(float3(0.2989999949932098388671875, 0.58700001239776611328125, 0.114000000059604644775390625), irradiance); // b9:1457
                    alpha *= mad(_RainMaskParams.y, mad((t3 * t3), lumI, -1.0), 1.0);                       // b9:1457
                #endif

                return half4(color, alpha);
            }
            ENDHLSL
        }
    }
}
