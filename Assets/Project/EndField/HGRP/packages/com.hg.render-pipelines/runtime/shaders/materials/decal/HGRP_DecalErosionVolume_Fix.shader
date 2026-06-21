// HGRP DecalErosionVolume (deferred screen-space radiation/erosion decal) -> URP. Single "Erosion" pass.
// Merged from: decalerosionvolume blob b2 (Vertex, base) + b3 (Fragment, base).  Catch-all (#else) variant = HG_ENABLE_MV only; SRP_INSTANCING_ON delta (b4/b5) is pure per-draw-array instancing infra (dropped).
// Keywords (source): HG_ENABLE_MV, SRP_INSTANCING_ON  — both are pipeline infra (motion-vector MRT + instanced ObjectToWorld array), neither survives the URP port.
// Kept (1:1 math): depth->WS reconstruction (_InvViewProjMatrix), planar radiation falloff (_FullCoverRange/_Range smooth coverage), polar-angle SDF UV (acos poly atan2 + (angle+PI)/2PI + _OffsetX), SDF erosion mask (T1.x), erosion-ring SDF along scene normal (_RingSize/_RingSpeed/_RingRange/_zPower/_BumpRate), dual normal-array blend by mask channel (T4 by floor(T3.x*6)/floor(T3.y*6), lerp by T3.z), tangent-space->WS normal transform via the MESH TBN (vertex normalWS=TEXCOORD_2 + tangentWS=TEXCOORD_3.xyz + handedness .w, carried through GetVertexNormalInputs), ring-normal perturb, matcap (T2 by camera-relative view dir), target color lerp (_TargetColor1<->_TargetColor2 by SDF.y) + matcap tint, metallic/roughness writeout, octahedral normal pack.
// Removed (pixel-neutral pipeline infra, substituted by URP / dropped): GPU instancing (UnityPerDrawArray), HG motion-vector MRT (TEXCOORD_6 prev-frame clip + _TaaJitterStrength), TAA jitter, the HGRP 5-MRT deferred GBuffer write (SV_Target0..4) -> see TODO(1:1): URP has no identical GBuffer layout; this pass resolves to a single forward color (emission target SV_Target_4, the visible decal color) and documents the unmapped channels.
//
// NOTE: this is a *deferred decal* — it reads the camera depth (T0 = _CameraDepthTexture) and the deferred normal buffer (T5 = packed scene GBuffer normal) and writes the decal's contribution into the scene GBuffer. URP forward has no scene-normal-readback in a decal pass; the scene-normal read (T5) and the depth-of-the-surface-under-decal read (T0) are kept as _CameraDepthTexture + _CameraNormalsTexture samples (DepthNormals prepass / deferred), but their availability depends on the renderer. See TODO(1:1) markers.
//   T1 = _SdfMap (radiation SDF, .x=erosion mask, .y=color blend, .z=tilling-bias term). T2 = _MatcapMap. T3 = _BlendMaskTex (.x/.y = normal-array slice selectors *6, .z = blend, .w = decal output alpha mask). T4 = _NormalMapArray. T5 = scene deferred normal (octahedral). T0 = scene depth.
//   _TargetColor1[11] in the vertex blob is the instanced ObjectToWorld(rows 0..3) + prev-frame matrices packed as a material array for motion vectors — replaced wholesale by URP unity_ObjectToWorld / GetVertexPositionInputs.

Shader "HGRP/DecalErosionVolume_Fix" {
    Properties {
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2

        [Header(Radiation Region)]
        _RadiationCenterWS ("Radiation Center (World)", Vector) = (0, 0, 0, 0)
        _FullCoverRange ("Full Cover Range", Range(0, 500)) = 1
        _Range ("Radiation Range", Range(0, 500)) = 1
        _AngleRange ("Angle Range", Range(0, 1)) = 0
        _AngleOffset ("Angle Offset", Range(0, 1)) = 0
        _TargetMetallic ("Target Metallic", Range(0, 1)) = 1
        _TargetRoughness ("Target Roughness", Range(0, 1)) = 1
        _TargetSpecular ("Target Specular", Range(0, 1)) = 1
        _TargetOpacity ("Target Opacity", Range(0, 1)) = 1

        [Header(Color)]
        [HDR] _TargetColor1 ("Target Color 1", Color) = (1, 1, 1, 1)
        [HDR] _TargetColor2 ("Target Color 2", Color) = (1, 1, 1, 1)

        [Header(Normal)]
        _BlendMaskTex ("Blend Mask (R/G slice, B blend, A alpha)", 2D) = "white" {}
        _NormalMapArray ("Normal Map Array", 2DArray) = "white" {}
        _NormalMap ("Normal Map", 2D) = "bump" {}
        _NormalScale ("Normal Scale", Range(0, 2)) = 1
        _NormalTilling ("Normal Tilling", Range(0, 50)) = 1
        _NormalPixSize ("Normal Pix Size", Range(0, 10)) = 1

        [Header(Radiation SDF)]
        _SdfMap ("SDF Map", 2D) = "white" {}
        _SdfTillingX ("SDF Tilling X", Range(0, 20)) = 1
        _SdfTillingY ("SDF Tilling Y", Range(0, 20)) = 1
        _OffsetX ("Offset X", Range(0, 5)) = 1
        _OffsetY ("Offset Y", Range(-2, 2)) = 1
        _Scale ("Overall Scale", Range(0, 5)) = 1

        [Header(Center Ring)]
        _RingSize ("Ring Size", Range(0, 1)) = 1
        _RingSpeed ("Ring Speed", Range(0, 50)) = 1
        _RingRange ("Ring Range", Range(0, 50)) = 1
        _BumpRate ("Bump Rate", Range(0, 1)) = 1
        _zPower ("Z Power", Range(0, 2)) = 1
        _RingNormalScale ("Ring Normal Scale", Range(0, 1)) = 1

        [Header(Matcap)]
        _MatcapMap ("Matcap Map", 2D) = "white" {}
        _MatcapStrength ("Matcap Strength", Range(0, 1)) = 1
        _MatcapColor ("Matcap Color", Color) = (1, 1, 1, 1)
        _ChangeSpeed ("Move Response", Range(0, 10)) = 1
        _TillingX ("Tilling X", Range(0, 2)) = 1
        _TillingY ("Tilling Y", Range(0, 2)) = 1
        _CameraSpeed ("Camera Speed", Range(0, 1)) = 1

        [Header(Stencil)]
        _StencilReadMask ("Stencil Read Mask", Float) = 255
        _StencilWriteMask ("Stencil Write Mask", Float) = 255
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 6
    }

    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
        }
        LOD 300

        // Shared HLSL: includes, cbuffer, textures, helpers. The source carries everything in one
        // pass blob; we lift the common machinery here and keep the pass thin.
        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"
            // Scene depth + scene normals readback (DepthNormals prepass / deferred GBuffer).
            // These provide SampleSceneDepth() and SampleSceneNormals() + declare _CameraDepthTexture /
            // _CameraNormalsTexture (URP substitutes for the HG-bound T0 depth / T5 GBuffer-normal).
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareDepthTexture.hlsl"
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/DeclareNormalsTexture.hlsl"

            // HG global LOD-bias: the blob samples every texture with _GlobalMipBias (blob b3 cbuffer c108;
            // blob 122,159,163,164,221). URP ALSO provides a global named _GlobalMipBias (float2, Input.hlsl:112,
            // consumed by Core.hlsl SAMPLE_TEXTURE2D[_ARRAY]_BIAS as .x bias / .y grad-mult), so re-declaring it
            // here is a guaranteed redefinition clash (esp. under UNITY_VIRTUAL_TEXTURING). The semantics match
            // (a mip bias), so we DELETE the redundant decl and pass the blob's pixel-neutral substitution value
            // 0.0 as the explicit bias argument at each site — URP's BIAS macro then folds in its own global
            // _GlobalMipBias.x exactly as intended, leaving the math 1:1 (blob bias = 0). (compile-hardening #1)

            CBUFFER_START(UnityPerMaterial)
                // --- Color (blob b3 cbuffer c0..c2) ---
                float4 _TargetColor1;      // packoffset(c0)
                float4 _TargetColor2;      // packoffset(c1)
                float4 _MatcapColor;       // packoffset(c2)
                // --- Radiation region (c3..) ---
                float4 _RadiationCenterWS; // packoffset(c3)
                float  _Range;             // packoffset(c4)
                float  _Scale;             // packoffset(c4.w)
                float  _SdfTillingX;       // packoffset(c5)
                float  _SdfTillingY;       // packoffset(c5.y)
                float  _OffsetX;           // packoffset(c5.z)
                float  _OffsetY;           // packoffset(c5.w)
                float  _NormalTilling;     // packoffset(c6)
                float  _RingSize;          // packoffset(c6.z)
                float  _zPower;            // packoffset(c6.w)
                float  _RingRange;         // packoffset(c7)
                float  _RingNormalScale;   // packoffset(c7.y)
                float  _TillingX;          // packoffset(c7.z)
                float  _TillingY;          // packoffset(c7.w)
                float  _TargetMetallic;    // packoffset(c8)
                float  _TargetRoughness;   // packoffset(c8.y)
                float  _NormalScale;       // packoffset(c9.y)
                float  _RingSpeed;         // packoffset(c9.w)
                float  _BumpRate;          // packoffset(c10)
                float  _FullCoverRange;    // packoffset(c10.y)
                float  _MatcapStrength;    // packoffset(c10.z)
                float  _ChangeSpeed;       // packoffset(c10.w)
                float  _CameraSpeed;       // packoffset(c11)
                // Inspector-only / unused-by-math uniforms (kept for material compat)
                float  _AngleRange;
                float  _AngleOffset;
                float  _TargetSpecular;
                float  _TargetOpacity;
                float  _NormalPixSize;
            CBUFFER_END

            // TODO(1:1, ENGINE-SIDE): HGRP binds its own deferred depth (T0) + GBuffer-normal (T5) globally
            //   (blob b3:55-60, 137 T5.Load, 148 T0.SampleLevel). The SAMPLING + decode MATH is ported 1:1
            //   below (SampleSceneDepth / SampleSceneNormals, same oct decode). What remains engine-side is
            //   the PRODUCER of these buffers: a URP DepthNormals prepass (ScriptableRenderer must enable
            //   DepthNormals/deferred so _CameraDepthTexture + _CameraNormalsTexture are populated before this
            //   pass). That host-renderer config is not expressible in the shader; no math is missing.
            TEXTURE2D(_SdfMap);               SAMPLER(sampler_SdfMap);              // T1 (LinearRepeat)
            TEXTURE2D(_MatcapMap);            SAMPLER(sampler_MatcapMap);           // T2 (LinearMirror)
            TEXTURE2D(_BlendMaskTex);         SAMPLER(sampler_BlendMaskTex);        // T3 (LinearMirrorOnce)
            TEXTURE2D_ARRAY(_NormalMapArray); SAMPLER(sampler_PointClamp_NormalMapArray); // T4 (PointClamp)

            // ---- magic-constant decodes (see STYLE_BIBLE §4) ----
            static const float FLT_MIN_DENORM = 1.1754943508222875079687365372222e-38f; // FLT_MIN (blob 212,232)
            static const float EPS_1EM16      = 1.000000016862383526387164645044e-16f;   // 1e-16 normal floor (blob 167,172)

            // atan2 via acos-style minimax poly (blob b3:113-119).
            // Returns angle in [-PI/2, PI/2]-ish range fed into the (a<0 ? -r : r) sign fixups below.
            float Atan2Poly(float y, float x) {
                // _142 = x/y ; ratio, branchless quadrant fold (blob 113-118)
                float t   = x / y;                                   // _142
                bool  inUnit = abs(t) < 1.0f;                        // _145
                float a   = inUnit ? abs(t) : (1.0f / abs(t));       // _150
                float a2  = a * a;                                   // _151
                // poly: mad(mad(a2, 0.0872929f, -0.3018950f), a2, 1.0f)   (blob 117)
                float p   = mad(mad(a2, 0.087292902171611785888671875f, -0.3018949925899505615234375f), a2, 1.0f); // _155
                // _163 = inUnit ? a*p : (PI/2 - a*p)   ; (-p)*a + 1.5707964   (blob 118)
                float r   = inUnit ? (a * p) : mad(-p, a, 1.57079637050628662109375f);
                // sign fixups: quadrant by sign(x),sign(y) (blob 119)
                // sx = (x>=0 ? +PI : -PI)  via asfloat(1078530010u / 3226013658u) = +/-3.14159274
                float sx  = (x >= 0.0f) ? 3.14159274101257324f : -3.14159274101257324f;
                // s(y) flag: (y<0 ? 1.0 : 0.0)
                float syFlag = (y < 0.0f) ? 1.0f : 0.0f;
                // rSigned = (x<0 ? -r : r)
                float rSigned = (t < 0.0f) ? -r : r;
                return mad(sx, syFlag, rSigned);                     // sx*syFlag + rSigned, before +PI
            }

            // Octahedral encode of a unit vector -> [0,1]^2 (blob b3:248-253), matches the HG GBuffer normal pack.
            float2 OctEncode(float3 n) {
                float s = dot(1.0f.xxx, float3(abs(n.x), abs(n.y), abs(n.z)));  // _866 (L1 norm)
                float ox = n.x / s;   // _869
                float oz = n.z / s;   // _870
                bool  lower = 0.0f >= n.y; // _871 (lower hemisphere wrap)
                float ex = lower ? (((ox >= 0.0f) ? 1.0f : -1.0f) * (1.0f - abs(oz))) : ox; // _SV_Target_3.x pre-bias
                float ey = lower ? (((oz >= 0.0f) ? 1.0f : -1.0f) * (1.0f - abs(ox))) : oz; // _SV_Target_3.y pre-bias
                return float2(mad(ex, 0.5f, 0.5f), mad(ey, 0.5f, 0.5f));        // *0.5+0.5 (blob 252-253)
            }

            // Octahedral decode (mirror of the encode T5 read, blob b3:138-147).
            float3 OctDecode(float2 e) {
                float ex = mad(e.x, 2.0f, -1.0f); // _267
                float ey = mad(e.y, 2.0f, -1.0f); // _268
                float z  = ((-0.0f) - dot(1.0f.xx, float2(abs(ex), abs(ey)))) + 1.0f; // _275 (= 1 - |x| - |y|)
                bool  lower = z < 0.0f;            // _276
                float nx = lower ? (((ex >= 0.0f) ? 1.0f : -1.0f) * (1.0f - abs(ey))) : ex; // _296
                float ny = lower ? (((ey >= 0.0f) ? 1.0f : -1.0f) * (1.0f - abs(ex))) : ey; // _298
                float inv = rsqrt(dot(float3(nx, z, ny), float3(nx, z, ny)));               // _302
                return float3(inv * nx, inv * z, inv * ny);                                 // (_303,_304,_305) note swizzle: (x, y=z-comp, z=ny)
            }
        ENDHLSL

        Pass {
            Name "Erosion"
            // Source render-state (decalerosionvolume.shader:57-70).
            Blend SrcAlpha OneMinusSrcAlpha, SrcAlpha OneMinusSrcAlpha
            ColorMask RGB
            ZClip On
            ZTest Less
            ZWrite Off
            Cull [_CullMode]
            Stencil {
                Ref [_StencilRef]
                WriteMask 39
                Comp NotEqual
                Pass Replace
                Fail Keep
                ZFail Keep
            }
            // TODO(1:1): source LightMode "Erosion" is an HGRP deferred-decal queue tag; retarget to a
            //   URP-renderable mode ("SRPDefaultUnlit") so the decal volume rasterizes in forward. The
            //   true 1:1 binding requires a custom ScriptableRenderPass that injects this after the
            //   GBuffer/DepthNormals are populated (so _CameraDepthTexture/_CameraNormalsTexture exist).
            Tags { "LightMode"="SRPDefaultUnlit" }

            HLSLPROGRAM
                #pragma target 4.5
                #pragma vertex vert
                #pragma fragment frag

                // Decal volume vertex: source transforms object verts to clip via the (instanced)
                // ObjectToWorld + NonJittered VP (blob b2:201-203, 222-247). URP collapses this to the
                // standard object->clip path. The octahedral-normal-UNPACK of the mesh normal/tangent
                // (blob b2:128-200, the SRP_INSTANCING low-precision NORMAL/TANGENT codec) and the
                // motion-vector outputs (TEXCOORD_5/6/7, blob b2:240-246) are pipeline infra and dropped.
                // BUT the per-vertex WS normal (TEXCOORD_2, blob b2:213-218,233-235) and WS tangent
                // (TEXCOORD_3.xyz + handedness .w, blob b2:219-221,237-240) ARE consumed by the fragment's
                // mixedN TBN transform (blob b3:186-188) — so they are carried here via the URP equivalent
                // GetVertexNormalInputs(normalOS, tangentOS) -> normalWS / tangentWS / bitangentWS
                // (bitangentWS already folds the mikkts handedness sign = blob's _261 = sign(TANGENT.w)).
                struct Attributes {
                    float3 positionOS : POSITION;
                    float3 normalOS   : NORMAL;
                    float4 tangentOS  : TANGENT;
                    float2 uv         : TEXCOORD0;
                };

                struct Varyings {
                    float4 positionCS  : SV_Position;
                    float2 uv          : TEXCOORD0;
                    float3 normalWS    : TEXCOORD1;   // blob TEXCOORD_2 (mesh normal WS, b2:233-235)
                    float3 tangentWS   : TEXCOORD2;   // blob TEXCOORD_3.xyz (mesh tangent WS, b2:237-239)
                    float3 bitangentWS : TEXCOORD3;   // blob _261 * cross(TEXCOORD_2,TEXCOORD_3) (b2:240 sign baked)
                };

                Varyings vert(Attributes input) {
                    Varyings o = (Varyings)0;
                    VertexPositionInputs posIn = GetVertexPositionInputs(input.positionOS); // blob b2:201-203 + VP 222-224
                    VertexNormalInputs  nrmIn = GetVertexNormalInputs(input.normalOS, input.tangentOS); // blob b2:213-221,237-240
                    o.positionCS  = posIn.positionCS;
                    o.uv          = input.uv;                                                // TEXCOORD passthrough (blob b2:249-250)
                    o.normalWS    = nrmIn.normalWS;                                          // TEXCOORD_2
                    o.tangentWS   = nrmIn.tangentWS;                                         // TEXCOORD_3.xyz
                    o.bitangentWS = nrmIn.bitangentWS;                                       // sign(TANGENT.w)*cross(N,T) = _261*cross(TEXCOORD_2,TEXCOORD_3)
                    return o;
                }

                float4 frag(Varyings input, float4 positionCS : SV_Position) : SV_Target {
                    // ---- Screen-space setup (blob b3:106-111) ----
                    // NDC from frag coord. URP _ScreenSize -> (_ScreenParams.xy, 1/ _ScreenParams.xy in .zw).
                    float2 screenUV = positionCS.xy / _ScreenParams.xy;                  // (gl_FragCoord.xy * _ScreenSize.zw)
                    float ndcX =  mad(screenUV.x, 2.0f, -1.0f);                          // _82
                    float ndcYr = mad(screenUV.y, 2.0f, -1.0f);                          // _85
                    float ndcY  = (-0.0f) - ndcYr;                                       // _86 (flip)

                    // Reconstruct WS position of the *decal volume fragment* from its own clip depth via
                    // inverse VP. blob uses _InvViewProjMatrix (c24). URP: UNITY_MATRIX_I_VP.
                    // _126 = w of inv-VP * ndc ; _136/_137 = (xz / w) - radiationCenter.xz
                    float fragDepth = positionCS.z;                                      // gl_FragCoord.z
                    // mul(UNITY_MATRIX_I_VP, float4(ndcX,ndcY,depth,1)); per-row dot. SPIRV-Cross column_major
                    // M[col].comp == _m{comp_row}{col}, so blob _InvViewProjMatrix[2u].w == _m32 etc. (NOT _m23).
                    float invW = mad(UNITY_MATRIX_I_VP._m32, fragDepth, mad(UNITY_MATRIX_I_VP._m30, ndcX, ndcY * UNITY_MATRIX_I_VP._m31)) + UNITY_MATRIX_I_VP._m33; // _126
                    float wx   = (mad(UNITY_MATRIX_I_VP._m02, fragDepth, mad(UNITY_MATRIX_I_VP._m00, ndcX, ndcY * UNITY_MATRIX_I_VP._m01)) + UNITY_MATRIX_I_VP._m03) / invW; // _136
                    float wz   = (mad(UNITY_MATRIX_I_VP._m22, fragDepth, mad(UNITY_MATRIX_I_VP._m20, ndcX, ndcY * UNITY_MATRIX_I_VP._m21)) + UNITY_MATRIX_I_VP._m23) / invW; // _137
                    float px = wx + ((-0.0f) - _RadiationCenterWS.x);                    // _136
                    float pz = wz + ((-0.0f) - _RadiationCenterWS.z);                    // _137

                    // ---- Polar SDF UV (blob b3:112-122) ----
                    float dist = sqrt(dot(float2(px, pz), float2(px, pz)));              // _141
                    float angle = Atan2Poly(pz, px);                                     // _163 + sign fixups (Atan2Poly returns pre-(+PI))
                    // U = (angle + PI) * (1/2PI) + _OffsetX     (blob 119)
                    float u = mad(angle + 3.1415927410125732421875f, 0.15915493667125701904296875f, _OffsetX); // _186
                    // radiation falloff _215 (blob 120-121):
                    float covDelta = dist + ((-0.0f) - _FullCoverRange);                 // _193
                    float covMask  = (_Range >= dist) ? 1.0f : 0.0f;                     // asfloat((_Range>=dist?-1:0)&1.0)
                    float coverage = covMask * (((-0.0f) - ((covDelta * clamp(covDelta, 0.0f, 1.0f)) / (_Range + ((-0.0f) - _FullCoverRange)))) + 1.0f); // _215
                    // V = clamp((dist/_Range * _Scale - _OffsetY) * _SdfTillingY, 0,1)  (blob 122)
                    float sdfV = clamp(mad(dist / _Range, _Scale, (-0.0f) - _OffsetY) * _SdfTillingY, 0.0f, 1.0f);
                    float4 sdf = SAMPLE_TEXTURE2D_BIAS(_SdfMap, sampler_SdfMap, float2(u * _SdfTillingX, sdfV), 0.0); // _243 (T1, LinearRepeat); blob bias=_GlobalMipBias=0
                    float sdfBlend = sdf.y;                                              // _246
                    float erosion  = coverage * sdf.x;                                   // _248

                    // ---- defaults for the "outside erosion" (else) branch (blob b3:231-242) ----
                    float roughOut = 1.0f;          // SV_Target_3.z
                    float alphaMask = 0.0f;         // SV_Target_3.w
                    float3 nWS = float3(0.0f, 0.0f, 1.0f);  // (_850,_849,_848) — overwritten in else by the MESH normal (TEXCOORD_2)
                    float metallic = 0.0f;          // _851
                    float3 outColor = float3(1.0f, 1.0f, 1.0f); // (_854,_853,_852)

                    // Scene normal under this pixel (the "else" branch passes it straight through; the
                    // "if" branch decodes + perturbs it). blob b3:137-147: T5.Load(uint2 pixel) -> OctDecode
                    // -> (_303,_304,_305). NOTE(infra, 1:1-equivalent): URP's _CameraNormalsTexture stores the
                    // SAME octahedral pack (UnpackNormalOctQuadEncode under _GBUFFER_NORMALS_OCT) and
                    // SampleSceneNormals() runs the decode internally — yielding the identical decoded WS normal
                    // the blob's OctDecode() produces. The blob's intermediate oct PAIR is not separately exposed
                    // by URP, so we consume the decoded normal directly (the math result is identical). The
                    // standalone OctDecode() helper above mirrors blob b3:138-147 for reference / verification.
                    float3 sNrm = SampleSceneNormals(screenUV);                          // (_303,_304,_305) scene WS normal

                    if (0.0f < erosion) {
                        // ---- reconstruct the WS position of the SCENE surface under the decal (blob b3:148-158) ----
                        // T0 = scene depth at this pixel; rebuild its WS pos via inv-VP, then camera-relative.
                        float sceneDepth = SampleSceneDepth(screenUV);                  // T0.SampleLevel(...).x = _320
                        // Same column_major transpose convention as the decal-fragment reconstruction above.
                        float invW2 = mad(UNITY_MATRIX_I_VP._m32, sceneDepth, mad(UNITY_MATRIX_I_VP._m30, ndcX, ndcY * UNITY_MATRIX_I_VP._m31)) + UNITY_MATRIX_I_VP._m33; // _361
                        float sxw = (mad(UNITY_MATRIX_I_VP._m02, sceneDepth, mad(UNITY_MATRIX_I_VP._m00, ndcX, ndcY * UNITY_MATRIX_I_VP._m01)) + UNITY_MATRIX_I_VP._m03) / invW2; // _362
                        float syw = (mad(UNITY_MATRIX_I_VP._m12, sceneDepth, mad(UNITY_MATRIX_I_VP._m10, ndcX, ndcY * UNITY_MATRIX_I_VP._m11)) + UNITY_MATRIX_I_VP._m13) / invW2; // _363
                        float szw = (mad(UNITY_MATRIX_I_VP._m22, sceneDepth, mad(UNITY_MATRIX_I_VP._m20, ndcX, ndcY * UNITY_MATRIX_I_VP._m21)) + UNITY_MATRIX_I_VP._m23) / invW2; // _364

                        // view direction WS (ortho-aware): perspective => camPos - worldPos, ortho => view fwd col.
                        // blob 155-158: _369 = (0==_unity_OrthoParams.w); fwd = ortho? _ViewMatrix[i].z : camPos - pos
                        bool persp = (0.0f == unity_OrthoParams.w);                     // _369
                        float vdx = persp ? (((-0.0f) - sxw) + _WorldSpaceCameraPos.x) : UNITY_MATRIX_V._m20; // _389
                        float vdy = persp ? (((-0.0f) - syw) + _WorldSpaceCameraPos.y) : UNITY_MATRIX_V._m21; // _396
                        float vdz = persp ? (((-0.0f) - szw) + _WorldSpaceCameraPos.z) : UNITY_MATRIX_V._m22; // _403

                        // ---- normal-array blend (blob b3:159-185) ----
                        float4 blendMask = SAMPLE_TEXTURE2D_BIAS(_BlendMaskTex, sampler_BlendMaskTex, input.uv, 0.0); // _412 (T3, LinearMirrorOnce); blob bias=_GlobalMipBias=0
                        float blendZ = blendMask.z;                                     // _416
                        float2 naUV = (input.uv * _NormalTilling) * 10.0f;             // (_428,_430)
                        float sliceA = floor(max(blendMask.x * 6.0f, 0.0f));           // _443 slice
                        float sliceB = floor(max(blendMask.y * 6.0f, 0.0f));           // _451 slice
                        float4 na0 = SAMPLE_TEXTURE2D_ARRAY_BIAS(_NormalMapArray, sampler_PointClamp_NormalMapArray, naUV, sliceA, 0.0); // _443; blob bias=_GlobalMipBias=0
                        float4 na1 = SAMPLE_TEXTURE2D_ARRAY_BIAS(_NormalMapArray, sampler_PointClamp_NormalMapArray, naUV, sliceB, 0.0); // _451; blob bias=_GlobalMipBias=0
                        // DXT5nm-style decode: x = (r*a)*2-1, y = g*2-1, z = sqrt(1 - min(x^2+y^2,1)) (blob 165-167)
                        float n0x = mad(na0.x * na0.w, 2.0f, -1.0f);                    // _457
                        float n0y = mad(na0.y, 2.0f, -1.0f);                            // _458
                        float n0z = max(sqrt(((-0.0f) - min(dot(float2(n0x, n0y), float2(n0x, n0y)), 1.0f)) + 1.0f), EPS_1EM16); // _466
                        float n1x = mad(na1.x * na1.w, 2.0f, -1.0f);                    // _475
                        float n1y = mad(na1.y, 2.0f, -1.0f);                            // _476
                        float n1z = max(sqrt(((-0.0f) - min(dot(float2(n1x, n1y), float2(n1x, n1y)), 1.0f)) + 1.0f), EPS_1EM16); // _484
                        n0x *= _NormalScale; n0y *= _NormalScale;                       // _472,_473
                        n1x *= _NormalScale; n1y *= _NormalScale;                       // _488,_489
                        float inv0 = rsqrt(dot(float3(n0x, n0y, n0z), float3(n0x, n0y, n0z))); // _493
                        float inv1 = rsqrt(dot(float3(n1x, n1y, n1z), float3(n1x, n1y, n1z))); // _501
                        float wA = clamp(blendZ, 0.0f, 1.0f);                          // _497
                        float wB = clamp(((-0.0f) - blendZ) + 1.0f, 0.0f, 1.0f);       // _507 (= 1 - blendZ)
                        // blended tangent-space normal (blob 179-185)
                        float tnx = mad(inv0 * n0x, wA, wB * (inv1 * n1x));            // _511
                        float tny = mad(inv0 * n0y, wA, wB * (inv1 * n1y));            // _512
                        float tnz = mad(inv0 * n0z, wA, wB * (inv1 * n1z));            // _513
                        float invT = rsqrt(dot(float3(tnx, tny, tnz), float3(tnx, tny, tnz))); // _517
                        tnx *= invT; tny *= invT; tnz *= invT;                          // (_518,_519,_520)

                        // ---- TBN: transform the blended tangent-space normal into WS via the MESH basis ----
                        // 1:1, source = Sub0_Pass0_Fragment_b3.hlsl:186-188 (the _575/_576/_577 row structure).
                        // Decoding the blob's mad/cross spelling per component:
                        //   _575 = tnz*TEXCOORD_2.x + tnx*TEXCOORD_3.x + tny*(_261*(TEXCOORD_2.y*TEXCOORD_3.z - TEXCOORD_2.z*TEXCOORD_3.y))
                        // i.e. coeff(tnx)=TEXCOORD_3 (tangent T), coeff(tny)=_261*cross(TEXCOORD_2,TEXCOORD_3) (bitangent B),
                        //      coeff(tnz)=TEXCOORD_2 (normal N). TEXCOORD_2/_3 are the MESH normal/tangent from the
                        // vertex stage (b2:213-221,233-240), NOT the depth-buffer scene normal (sNrm). The handedness
                        // _261 = sign(TANGENT.w) (blob b3:136, b2:240) is already baked into bitangentWS by URP.
                        float3 N = input.normalWS;                                       // TEXCOORD_2
                        float3 T = input.tangentWS;                                      // TEXCOORD_3.xyz
                        float3 B = input.bitangentWS;                                    // _261 * cross(TEXCOORD_2, TEXCOORD_3)
                        // mixedN = tnx*T + tny*B + tnz*N   (blob 186-188 coefficient mapping above)
                        float3 mixedN = tnx * T + tny * B + tnz * N;                    // (_575,_576,_577)

                        // ---- erosion ring along the radial SDF (blob b3:189-216) ----
                        float ringHalf = _RingSize * _BumpRate;                         // _584
                        float ringTwo  = _RingSize + _RingSize;                         // _591
                        // NOTE(infra substitution): blob b3:191 drives ring phase from _VFXParams0.w — an HG
                        //   global (cbuffer c185) filled per-frame by the HG VFX/particle C# system (Visual
                        //   Effect Graph time/param feed), NOT a material texture or formula. URP has no such
                        //   global; the pixel-neutral 1:1 substitution for its time-like scalar is _Time.y
                        //   (URP seconds). The downstream math (frac(phase*0.05), sawtooth wrap) is ported 1:1.
                        float ringPhase = _Time.y * _RingSpeed;                         // _599 (blob: _VFXParams0.w * _RingSpeed)
                        float ringT = mad(ringPhase, 0.05f, (-0.0f) - floor(ringPhase * 0.05f)); // _604 (frac(phase*0.05))
                        // radial vector from center to scene point, projected off the scene normal (sNrm)
                        float rcx = ((-0.0f) - sxw) + _RadiationCenterWS.x;            // _613
                        float rcy = ((-0.0f) - syw) + _RadiationCenterWS.y;            // _614
                        float rcz = ((-0.0f) - szw) + _RadiationCenterWS.z;            // _615
                        float dN  = dot(float3(rcx, rcy, rcz), sNrm);                  // _616 (along scene normal)
                        float tx = mad((-0.0f) - sNrm.x, dN, rcx);                     // _622 (tangential part)
                        float ty = mad((-0.0f) - sNrm.y, dN, rcy);                     // _623
                        float tz = mad((-0.0f) - sNrm.z, dN, rcz);                     // _624
                        float tDist = sqrt(dot(float3(tx, ty, tz), float3(tx, ty, tz))); // _628
                        // ring sawtooth: wrap tDist into [0, ringTwo) offset by ringT (blob 201)
                        float ringMod = mad((-0.0f) - ringT, ringTwo, mad((-0.0f) - floor(mad((-0.0f) - ringT, ringTwo, tDist) / ringTwo), ringTwo, tDist)); // _636
                        float ringMask = (abs(ringMod + ((-0.0f) - _RingSize)) < ringHalf) ? 1.0f : -1.0f; // _645
                        float ringNorm = ringMod / _RingSize;                          // _652
                        float ringFrac = frac(abs(ringNorm));                          // _656
                        // ring height profile (blob 205): exp2(log2(|...|/max(ringHalf,1e-3)) * _zPower)
                        float ringSigned = (ringNorm >= ((-0.0f) - ringNorm)) ? ringFrac : ((-0.0f) - ringFrac);
                        float ringH = exp2(log2(abs(mad(ringSigned, _RingSize, (-0.0f) - ringHalf)) / max(ringHalf, 0.001000000047497451305389404296875f)) * _zPower); // _673
                        // perturbed radial normal (blob 206-209)
                        float prx = mad(ringMask * tx, ringH, sNrm.x);                 // _674
                        float pry = mad(ringMask * ty, ringH, sNrm.y);                 // _675
                        float prz = mad(ringMask * tz, ringH, sNrm.z);                 // _676
                        float invP = rsqrt(dot(float3(prx, pry, prz), float3(prx, pry, prz))); // _680
                        float ringFall = clamp(((-0.0f) - (tDist / _RingRange)) + 1.0f, 0.0f, 1.0f); // _688
                        float ringW = (ringFall * ringFall) * _RingNormalScale;        // _693

                        // ---- final WS normal: mixedN + ringW*(normalize(perturbed) - sceneN) (blob 212-216) ----
                        float invMix = rsqrt(max(dot(mixedN, mixedN), FLT_MIN_DENORM)); // _708
                        float fnx = mad(mixedN.x, invMix, mad(ringW, mad(prx, invP, (-0.0f) - sNrm.x), sNrm.x)); // _709
                        float fny = mad(mixedN.y, invMix, mad(ringW, mad(pry, invP, (-0.0f) - sNrm.y), sNrm.y)); // _710
                        float fnz = mad(mixedN.z, invMix, mad(ringW, mad(prz, invP, (-0.0f) - sNrm.z), sNrm.z)); // _711
                        float invF = rsqrt(max(dot(float3(fnx, fny, fnz), float3(fnx, fny, fnz)), FLT_MIN_DENORM)); // _716
                        nWS = float3(invF * fnx, invF * fny, invF * fnz);              // (_850,_849,_848) order set below

                        // ---- matcap (blob b3:217-221) ----
                        // matcap UV.x = u * _TillingX ; UV.y = compound camera/ws-motion term * _TillingX
                        float camToCenter = sqrt(dot(float3(_WorldSpaceCameraPos.x - _RadiationCenterWS.x,
                                                            _WorldSpaceCameraPos.y - _RadiationCenterWS.y,
                                                            _WorldSpaceCameraPos.z - _RadiationCenterWS.z),
                                                     float3(_WorldSpaceCameraPos.x - _RadiationCenterWS.x,
                                                            _WorldSpaceCameraPos.y - _RadiationCenterWS.y,
                                                            _WorldSpaceCameraPos.z - _RadiationCenterWS.z))); // sqrt(dot(_769..)) blob 218-220
                        float vInv = rsqrt(dot(float3(vdx, vdy, vdz), float3(vdx, vdy, vdz)));
                        float matV = mad(vInv * vdy, _CameraSpeed,
                                         mad(max(mad((-0.0f) - sdf.z, 20.0f, dist + _FullCoverRange), 0.100000001490116119384765625f), _TillingY,
                                             (camToCenter * _ChangeSpeed) * 0.100000001490116119384765625f)) * _TillingX; // blob 221 inner
                        float4 matcap = SAMPLE_TEXTURE2D_BIAS(_MatcapMap, sampler_MatcapMap, float2(u * _TillingX, matV), 0.0); // _804 (T2, LinearMirror); blob bias=_GlobalMipBias=0

                        roughOut = _TargetRoughness;       // SV_Target_3.z (blob 222)
                        metallic = _TargetMetallic;        // _851
                        // target color = lerp(_TargetColor1, _TargetColor2, sdf.y) + coverage*matcap*matcapStrength*matcapColor (blob 227-229)
                        outColor.x = mad((coverage * matcap.x) * _MatcapStrength, _MatcapColor.x, mad(sdfBlend, ((-0.0f) - _TargetColor1.x) + _TargetColor2.x, _TargetColor1.x)); // _854
                        outColor.y = mad((coverage * matcap.y) * _MatcapStrength, _MatcapColor.y, mad(sdfBlend, ((-0.0f) - _TargetColor1.y) + _TargetColor2.y, _TargetColor1.y)); // _853
                        outColor.z = mad((coverage * matcap.z) * _MatcapStrength, _MatcapColor.z, mad(sdfBlend, ((-0.0f) - _TargetColor1.z) + _TargetColor2.z, _TargetColor1.z)); // _852
                        // .w mask combining erosion alpha with the surface mask (blob 217)
                        alphaMask = min(erosion, blendMask.w);
                    } else {
                        // else branch (blob 231-242): roughness=1, no mask, pass the MESH normal, white emission.
                        // blob b3:235-237: _850=TEXCOORD_2.x, _849=TEXCOORD_2.y, _848=TEXCOORD_2.z -> nWS = TEXCOORD_2
                        // (the per-vertex mesh normalWS carried as input.normalWS), NOT the depth-buffer scene normal.
                        roughOut = 1.0f;
                        alphaMask = 0.0f;
                        nWS = input.normalWS;               // TEXCOORD_2 passthrough (_850,_849,_848)
                        metallic = 0.0f;
                        outColor = float3(1.0f, 1.0f, 1.0f);
                    }

                    float outAlpha = max(erosion, 0.0f);    // _855

                    // ---- octahedral-pack the WS normal (blob 244-253) — written to GBuffer normal target ----
                    float invN = rsqrt(dot(nWS, nWS));      // _859
                    float3 nN = nWS * invN;                 // (_860,_861,_862)
                    float2 octN = OctEncode(nN);            // SV_Target_3.xy

                    // ============================================================
                    // HG 5-MRT deferred GBuffer write (blob b3:254-271):
                    //   SV_Target0 = float4(0,0,0, _855)                 ; albedo (black) + coverage alpha
                    //   SV_Target1 = float4(0.5,0.5,0,0)                 ; (HG pack: AO/spec defaults)
                    //   SV_Target2 = float4(_851, 1, 1, _855)            ; metallic + flags + alpha
                    //   SV_Target3 = float4(octN.x, octN.y, _rough, _maskA) ; normal + roughness + mask
                    //   SV_Target4 = float4(_854,_853,_852, _855)        ; EMISSION color (the visible decal)
                    // TODO(1:1, ENGINE-SIDE — host ScriptableRenderPass MRT): URP has no matching 5-MRT GBuffer
                    //   here. SV_Target_4 (emission) is the visible decal contribution; we output it as the single
                    //   forward color with its coverage alpha (_855), and the source pass blend
                    //   `Blend SrcAlpha OneMinusSrcAlpha` reproduces SV_Target_4's straight-alpha composite 1:1.
                    //   The metallic/roughness/normal/AO channels (SV_Target0..3) CANNOT be injected into the
                    //   scene GBuffer from a forward pass — that is the legitimate engine-side gap: a deferred-decal
                    //   ScriptableRenderPass must bind these 5 MRTs (scene GBuffer0..4) and run this fragment so the
                    //   already-computed octN/roughOut/alphaMask/metallic land in their target channels. No shader
                    //   math is missing (all 5 targets' values are derived above); only the host MRT binding is.
                    // ============================================================
                    return float4(outColor, outAlpha);
                }
            ENDHLSL
        }
    }
    Fallback Off
}
