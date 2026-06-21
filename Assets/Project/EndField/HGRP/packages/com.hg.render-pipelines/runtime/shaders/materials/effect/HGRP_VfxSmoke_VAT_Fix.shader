// HGRP VFX Smoke VAT (Houdini Vertex-Animation-Texture playback) — single ForwardOnly transparent pass.
// Merged from: vfxsmoke_vat base variant (#else catch-all):
//   Sub0_Pass0_Vertex_b2.hlsl   (keywords: HG_ENABLE_MV)            — VAT decode + object->world->clip
//   Sub0_Pass0_Fragment_b3.hlsl (keywords: HG_ENABLE_MV)            — tinted-unlit surface + fog
//   cross-referenced with Sub0_Pass0_Vertex_b4 (SRP_INSTANCING_ON) which names the material fields literally.
//
// Keywords (shader_feature): none compiled in the supplied blobs — the source `multi_compile_local` list is
//   only `_ HG_ENABLE_MV` and `_ SRP_INSTANCING_ON`. ALL the property `[Toggle(_USE_*)]` keywords
//   (_USE_FRESNEL/_USE_DISSOLVE/_USE_COLORRAMP/_USE_VAT_COLORTEX/_USE_VERTOFFSET/_USE_LIGHTING/
//    _USE_DISTANCEFADE/_UNLOAD_ROT_TEX/_USE_VAT_COLORTEX) are NOT in the multi_compile list, so the
//   decompiled base blob contains NONE of those feature branches. They are carried as inspector properties
//   only (so materials author the same), and listed in gaps (no blob to port them from).
//
// Kept (1:1 from base blobs):
//   - VAT playback: auto/manual frame select -> LookupTable frame-row addressing -> 16-bit hi/lo UV decode
//     -> Position & Rotation texture sampling -> per-vertex position decode (pin region / HDR raw / LDR
//     bounds-remap) -> quaternion-rotated normal & tangent with inverse-(scale^2) correction -> world normal/tangent.
//   - Surface: color = vertexColor.rgb * _Color.rgb ; alpha = _Opacity.
//   - VFX color grade (b3:194-198) desat-toward-luma + per-channel tint, 1:1. The HG global _VFXParams1 has no URP
//     equivalent so it is re-exposed as the authorable material Vector _HgVFXParams1 (STYLE_BIBLE §2 re-exposure;
//     renamed _Hg* to avoid the URP global name clash). Default (1,1,1,1) = prior identity grade, byte-identical.
//   - HGRP atmosphere + exponential + volumetric fog -> URP fog (MixFog) infra substitute (ENGINE-SIDE: the 3 fog
//     layers are pipeline globals + an engine-produced froxel volume, not material data; see frag note + gaps).
//   - Surface-type / blend-mode plumbing (_SurfaceType opaque/transparent, _BlendMode alpha/additive,
//     _CullMode) via [HideInInspector] blend-state floats (STYLE_BIBLE §6 pattern).
//
// Removed (pixel-neutral pipeline infra substituted by URP, per STYLE_BIBLE §2):
//   - SRP/GPU instancing (SRP_INSTANCING_ON: SRP_UnityPerDrawArray / CB1UBO per-instance buffers).
//   - TAA jitter (_TaaJitterStrength), camera-relative world space (_WorldSpaceCameraPos_Internal offset).
//   - Motion vectors: the entire prev-frame clip computation (TEXCOORD_6) + the forward-pass SV_Target1
//     MRT pack (motion vector + responsive-transparent bit). URP has a dedicated MotionVectors pass.
//   - HGRP bespoke 3-layer fog (atmosphere/exponential/volumetric froxel) -> URP MixFog.
//   - _NonJitteredViewNoTransProjMatrix -> UNITY_MATRIX_VP ; _ViewMatrix/_InvViewProjMatrix -> URP globals.
//
// NOTE: VAT textures encode Houdini sim data. _TextureFormat (HDR=1 raw / LDR=0 bounds-remapped) and the
//   LookupTable decode scale (HDR=2048 / LDR=255, selected by frac(_boundMinX) bit) are 1:1 load-bearing.
//   Vertex UV TEXCOORD.y <= 0.1 is the "pin" region (decoded position forced to 0). _B_surfaceNormals gates
//   tangent output (0 when off). Rotation texture RGB(A) = a quaternion (LDR-remapped (v-0.5)*2).

Shader "HGRP/Effect/VfxSmoke_VAT_Fix"
{
    Properties
    {
        // --- Surface / blend plumbing ---
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        _Opacity ("Opacity", Range(0, 1)) = 1
        [Enum(NormalTransparent, 0, ResponsiveTransparent, 1)] _Responsive ("Responsive Transparent", Float) = 0
        [ToggleUI] _EnableTransparentMV ("Enable Transparent MV", Float) = 0
        _Color ("Tint", Color) = (1, 1, 1, 1)

        // --- VAT playback ---
        [Space(10)]
        [ToggleUI] _B_autoPlayback ("Auto Playback", Float) = 0
        _gameTimeAtFirstFrame ("Game Time at First Frame", Float) = 0
        _displayFrame ("Display Frame", Float) = 0
        _playbackSpeed ("Playback Speed", Float) = 0
        _houdiniFPS ("Houdini FPS", Float) = 0
        [ToggleUI] _HoudiniVATInParticle ("VAT In Particle", Float) = 0

        // --- VAT textures ---
        [Space(10)]
        _PositionTexture ("Position Texture", 2D) = "white" {}
        _RotationTexture ("Rotation Texture", 2D) = "white" {}
        _LookupTable ("Lookup Table", 2D) = "white" {}
        [ToggleUI] _B_surfaceNormals ("Support Surface Normal Maps", Float) = 0
        [ToggleUI] _TextureFormat ("Texture Format (1:HDR; 0:LDR)", Float) = 1

        // --- Houdini VAT bounds (baked, hidden) ---
        [HideInInspector] _frameCount ("Frame Count", Float) = 0
        [HideInInspector] _boundMaxX ("Bound Max X", Float) = 0
        [HideInInspector] _boundMaxY ("Bound Max Y", Float) = 0
        [HideInInspector] _boundMaxZ ("Bound Max Z", Float) = 0
        [HideInInspector] _boundMinX ("Bound Min X", Float) = 0
        [HideInInspector] _boundMinY ("Bound Min Y", Float) = 0
        [HideInInspector] _boundMinZ ("Bound Min Z", Float) = 0

        // --- VFX color grade (re-exposed HG global, STYLE_BIBLE §2 pattern) ---
        // _VFXParams1 is an HGRP `type_ShaderVariablesGlobal` global (Fragment_b3:40, packoffset c186) with NO
        // URP equivalent. Per the same re-exposure recipe used for _CharacterParams*/_ExposureParams, it becomes a
        // material Vector so materials can author it. Renamed `_Hg*` (HG-specific; avoids URP/HDRP global name clash).
        //   .xyz = per-channel post tint ; .w = saturation (0 = grayscale toward luma, 1 = full chroma).
        // Default (1,1,1,1) reproduces the prior identity grade byte-for-byte.
        [Header(VFX Color Adjust)]
        _HgVFXParams1 ("VFX Grade (.xyz=tint .w=saturation)", Vector) = (1, 1, 1, 1)

        // --- Carried-but-unported feature properties (no blob; see header/gaps) ---
        [Header(Tint Color Adjust)]
        _LightColor ("Light Color", Color) = (1, 1, 1, 0)
        _LightDir ("Light Dir", Vector) = (1, 0, 0, 0)
        _LightIntensity ("Light Intensity", Float) = 1

        // --- Render-state plumbing (driven by material editor / OnValidate) ---
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _ZWrite ("__zw", Float) = 0
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 1
        [HideInInspector] _TransparentSortPriority ("_TransparentSortPriority", Float) = 0
    }

    SubShader
    {
        Tags
        {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Transparent"
            "Queue" = "Transparent"
        }
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Surface / blend
                float  _SurfaceType;
                float  _BlendMode;
                float  _Opacity;
                float  _Responsive;
                float  _EnableTransparentMV;
                float4 _Color;
                // VAT playback
                float  _B_autoPlayback;
                float  _gameTimeAtFirstFrame;
                float  _displayFrame;
                float  _playbackSpeed;
                float  _houdiniFPS;
                float  _HoudiniVATInParticle;
                // VAT decode flags
                float  _B_surfaceNormals;
                float  _TextureFormat;
                // VAT texture STs
                float4 _PositionTexture_ST;
                float4 _RotationTexture_ST;
                float4 _LookupTable_ST;
                // Houdini bounds
                float  _frameCount;
                float  _boundMaxX;
                float  _boundMaxY;
                float  _boundMaxZ;
                float  _boundMinX;
                float  _boundMinY;
                float  _boundMinZ;
                // VFX color grade (re-exposed HG global; renamed _Hg* to dodge URP global clash)
                float4 _HgVFXParams1;
                // Carried (unported feature) uniforms
                float4 _LightColor;
                float4 _LightDir;
                float  _LightIntensity;
            CBUFFER_END

            // VAT data textures. Wrap modes preserved from the decompiled sampler names:
            //   _RotationTexture -> LinearClamp  (sampler_LinearClamp_RotationTexture, b2:56)
            //   _PositionTexture -> LinearRepeat (sampler_LinearRepeat_PositionTexture, b2:57)
            //   _LookupTable     -> LinearMirror (sampler_LinearMirror_LookupTable,    b2:58)
            TEXTURE2D(_RotationTexture);  SAMPLER(sampler_RotationTexture);
            TEXTURE2D(_PositionTexture);  SAMPLER(sampler_PositionTexture);
            TEXTURE2D(_LookupTable);      SAMPLER(sampler_LookupTable);

            // Rec.709 luma (b3:194 — 0.21267290413379669, 0.715152204036712, 0.072175003588199)
            static const float3 LUMA_REC709 = float3(0.21267290413379669189453125,
                                                     0.715152204036712646484375,
                                                     0.072175003588199615478515625);

            // LookupTable hi/lo decode scale: HDR=2048 (asfloat(1157627904u)), LDR=255 (asfloat(1132396544u))
            // selected by a fractional bit of _boundMinX (b2:96 / b4:106).
            static const float VAT_LUT_SCALE_HDR = 2048.0;
            static const float VAT_LUT_SCALE_LDR = 255.0;
        ENDHLSL

        // =========================================================================================
        // ForwardOnly — the single VAT pass. (source LIGHTMODE "ForwardOnly" -> URP UniversalForwardOnly)
        // Source render-state (vfxsmoke_vat.shader:83-96): Blend 0 [_SrcBlend][_DstBlend],[_AlphaSrc][_AlphaDst]
        //   ColorMask RA -> URP outputs a single RGBA target; ZClip On (URP default) ; ZTest/ZWrite/Cull bound ;
        //   Stencil Ref/WriteMask Comp Always Pass Replace -> HGRP stencil tagging infra, dropped for URP.
        // =========================================================================================
        Pass
        {
            Name "ForwardOnly"
            Tags { "LightMode" = "UniversalForwardOnly" }

            Blend [_SrcBlend] [_DstBlend]
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex vert
            #pragma fragment frag

            struct Attributes
            {
                float3 positionOS : POSITION;   // unused for VAT geometry (position comes from VAT textures);
                                                //   kept so URP can still bind a mesh.
                float2 uv0        : TEXCOORD0;   // b2 TEXCOORD (.x = U addresses LUT column, .y = V / pin gate)
                float4 custom1    : TEXCOORD1;   // b2 TEXCOORD_1 (.w = particle frame data when VAT-in-particle)
                float4 prevOS     : TEXCOORD4;   // b2 TEXCOORD_4 (MV fallback prev-OS pos) — unused after MV drop
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv0        : TEXCOORD0;   // -> b3 TEXCOORD_2 (raw uv)
                float2 uvBounds   : TEXCOORD1;   // -> b2 TEXCOORD_1_1 (normalized-bounds UV, unused in base frag)
                float3 normalWS   : TEXCOORD2;   // -> b3 TEXCOORD_2 (world normal, VAT-rotated)
                float4 tangentWS  : TEXCOORD3;   // -> b3 TEXCOORD_3 (world tangent.xyz, .w=0)
                float4 vertColor  : TEXCOORD4;   // -> b3 TEXCOORD_4 (base = (1,1,1,1))
                float3 positionWS : TEXCOORD5;   // world pos
                float  fogFactor  : TEXCOORD6;   // URP fog (computed in vert from clip-space Z)
            };

            // ---- VAT frame selection (b4:109 named / b2:94) ----------------------------------------
            // auto:   floor(frac((houdiniFPS / (frameCount - 0.01)) * (gameTime - gameTimeAtFirstFrame)
            //                 * playbackSpeed) * frameCount) + 1, then / frameCount   (playbackSpeed INSIDE frac)
            // manual: floor((VATInParticle ? custom1.w : 0) + (displayFrame + extraFrame)) - 1, then / frameCount
            //   (extraFrame is a per-instance custom slot in the instanced variant; non-instanced base has it
            //    folded into _displayFrame, so it is 0 here.)
            float ComputeVATFrame(float4 custom1)
            {
                float gameTime = _Time.y;   // b2 _VFXParams0.w / b4 unity_MatrixPreviousM[3].w = engine game time
                // b2:94 / b4:109: floor( frac( (fps/(frameCount-0.01))*(t-t0) * playbackSpeed ) * frameCount ) + 1
                //   NOTE: _playbackSpeed is INSIDE frac() in the blob (it scales the phase before wrap),
                //   NOT a post-frac multiply. Moving it outside changes which frame is selected.
                float autoFrame = floor(frac((_houdiniFPS / (-0.00999999977648258209228515625 + _frameCount))
                                             * (gameTime - _gameTimeAtFirstFrame)
                                             * _playbackSpeed)
                                        * _frameCount) + 1.0;
                float inParticleFrame = (_HoudiniVATInParticle != 0.0) ? custom1.w : 0.0;
                float manualFrame = floor(inParticleFrame + _displayFrame) - 1.0;
                float frame = (_B_autoPlayback != 0.0) ? autoFrame : manualFrame;
                return frame / _frameCount;
            }

            // ---- Decode per-vertex VAT UV into Position/Rotation textures (b4:106-113 / b2:96-99) ----
            // The LookupTable row is addressed by (1 - uv.y) + frameRow; column by frac-ish(_boundMinZ)*uv.x.
            float2 ComputeVATSampleUV(float2 uv0, float frame)
            {
                float lutScale = (mad(_boundMinX, -10.0, -floor(-10.0 * _boundMinX)) >= 0.5)
                                 ? VAT_LUT_SCALE_HDR : VAT_LUT_SCALE_LDR;             // b4:106
                float frameFract = frac(abs(frame));                                  // b4:110
                float frameSigned = (frame >= -frame) ? frameFract : -frameFract;     // b4:111 sign(frame)*fract
                float frameRow = (frameSigned * _frameCount) / _frameCount;           // b4:111 (==frameSigned)

                float lutColScale = mad(_boundMinZ, 10.0, -ceil(10.0 * _boundMinZ)) + 1.0;          // b4:111
                float lutRowScale = -(floor(-(10.0 * _boundMaxX)) + mad(_boundMaxX, 10.0, 1.0));    // b4:111
                float2 lutUV;
                lutUV.x = lutColScale * uv0.x;
                lutUV.y = mad(lutRowScale, ((1.0 - uv0.y) + frameRow), 1.0);

                float4 lut = SAMPLE_TEXTURE2D_LOD(_LookupTable, sampler_LookupTable, lutUV, 0.0);    // b4:111

                // 16-bit hi/lo recombine -> [0,1] UV into the Position/Rotation textures (b4:112-113)
                float u = (lut.y / lutScale) + lut.x;
                float v = (1.0 - ((lut.w / lutScale) + lut.z));
                return float2(u, v);
            }

            Varyings vert(Attributes v)
            {
                Varyings o = (Varyings)0;

                float frame = ComputeVATFrame(v.custom1);
                float2 vatUV = ComputeVATSampleUV(v.uv0, frame);

                // GROUND-TRUTH TEXTURE ROLE ROUTING (b2:100-108 / b4:114-122):
                //   The blob's register t0 carries sampler `sampler_LinearClamp_RotationTexture`  -> Unity prop _RotationTexture.
                //   Its sample (_228/_213 .xyz) feeds the POSITION decode (_278/_280/_282 -> world pos).   <-- _RotationTexture = POSITION
                //   The blob's register t1 carries sampler `sampler_LinearRepeat_PositionTexture` -> Unity prop _PositionTexture.
                //   Its sample (_234/_219 .xyzw) feeds the QUATERNION (_429.. -> normal/tangent rotation). <-- _PositionTexture = QUATERNION
                //   The decompiled property NAMES are inverted vs their data role; the math + wrap modes are the truth
                //   (Clamp pairs with the position data — correct, positions must not wrap; Repeat pairs with the quaternion).
                //   Therefore: position <- _RotationTexture(Clamp); quaternion <- _PositionTexture(Repeat).
                //   [VISUAL-VERIFY] If an A/B against original VAT playback shows positions garbled, this single
                //   routing is the one knob to flip (swap the two texture properties below).
                float4 pos = SAMPLE_TEXTURE2D_LOD(_RotationTexture, sampler_RotationTexture, vatUV, 0.0); // t0=_RotationTexture -> POSITION (b4:114)
                float4 rot = SAMPLE_TEXTURE2D_LOD(_PositionTexture, sampler_PositionTexture, vatUV, 0.0); // t1=_PositionTexture -> QUATERNION (b4:118)

                // --- Position decode (b4:123-128) ---
                // pin region (uv.y <= 0.1) -> 0 ; HDR (_TextureFormat!=0) -> raw ; LDR -> bounds remap [0,1]->[min,max]
                bool   pinRegion = (0.100000001490116119384765625 >= v.uv0.y);   // b4:105
                bool   isHDR     = (_TextureFormat != 0.0);                       // b4:107
                float3 boundDelta = float3(_boundMaxX - _boundMinX,
                                           _boundMaxY - _boundMinY,
                                           _boundMaxZ - _boundMinZ);             // b4:123-125
                float3 boundMin   = float3(_boundMinX, _boundMinY, _boundMinZ);
                float3 decodedPos = pinRegion ? float3(0.0, 0.0, 0.0)
                                              : (isHDR ? pos.xyz
                                                       : (boundDelta * pos.xyz + boundMin)); // b4:126-128

                // --- Normalized-bounds secondary UV (b4:129-131) -> TEXCOORD_1_1 (unused by base frag) ---
                float invB = decodedPos.y / boundDelta.y;
                o.uvBounds.x = mad(decodedPos.x / boundDelta.x, 2.0, invB) * 0.3333333432674407958984375;
                o.uvBounds.y = mad(decodedPos.z / boundDelta.z, 2.0, invB) * 0.3333333432674407958984375;

                // --- Object -> World -> Clip (b4:135-144 ; b2:116-128) ---
                // HGRP did mul(unity_ObjectToWorld, decodedPos) in camera-relative WS then VP;
                // URP: absolute WS via unity_ObjectToWorld then TransformWorldToHClip. (TAA jitter dropped.)
                float3 positionWS = mul(unity_ObjectToWorld, float4(decodedPos, 1.0)).xyz;
                o.positionWS = positionWS;
                o.positionCS = TransformWorldToHClip(positionWS);
                o.fogFactor = ComputeFogFactor(o.positionCS.z);   // URP: clip-space Z before w-divide

                // --- Quaternion-rotated NORMAL (b4:158-176 ; b2:142-160) ---
                // The quaternion lives in the t1/_PositionTexture sample (`rot` after the role-routing above).
                // LDR-remap (v-0.5)*2 when _TextureFormat==0, raw when HDR.  (b4:150-157 / b2:134-141)
                float qx = isHDR ? rot.x : ((rot.x - 0.5) + (rot.x - 0.5));   // b4:154 / b2:138
                float qy = isHDR ? rot.y : ((rot.y - 0.5) + (rot.y - 0.5));   // b4:155 / b2:139
                float qz = isHDR ? rot.z : ((rot.z - 0.5) + (rot.z - 0.5));   // b4:156 / b2:140
                float qw = isHDR ? rot.w : ((rot.w - 0.5) + (rot.w - 0.5));   // b4:157 / b2:141

                // Quaternion * basis (first half), then rotate base normal +Z (b4:158-163 / b2:142-147)
                float n0 = mad(qw, 1.0, mad(qz, 0.0, -(qx * 0.0)));   // = qw
                float n1 = mad(qw, 0.0, mad(qx, 1.0, -(qy * 0.0)));   // = qx
                float n2 = mad(qw, 0.0, mad(qy, 0.0, -(qz * 1.0)));   // = -qz
                float3 rotN = float3(mad(mad(qy, n1, -(qz * n0)), 2.0, 0.0),    // b4:161 / b2:145
                                     mad(mad(qz, n2, -(qx * n1)), 2.0, 1.0),    // b4:162 / b2:146
                                     mad(mad(qx, n0, -(qy * n2)), 2.0, 0.0));   // b4:163 / b2:147
                float rotNlen = rsqrt(dot(rotN, rotN));                          // b4:164 / b2:148

                // Inverse-(scale^2) correction. The blob reads vec = (CB1[0].i, CB1[1].i, CB1[2].i) (b4:165-173 / b2:149-157).
                // With column_major storage CB1[k] is math COLUMN k, so (CB1[0].x,CB1[1].x,CB1[2].x) = (M00,M01,M02)
                // = math ROW 0 of objToWorld == unity_ObjectToWorld[0].xyz. The blob divides by dot(row_i,row_i);
                // we reproduce that EXACTLY (this is HG's chosen normalization; faithful to the blob, not re-derived).
                float3 rowX = unity_ObjectToWorld[0].xyz;
                float3 rowY = unity_ObjectToWorld[1].xyz;
                float3 rowZ = unity_ObjectToWorld[2].xyz;
                float3 nScaled = float3((rotNlen * rotN.x) * (1.0 / dot(rowX, rowX)),   // b4:174 / b2:158
                                        (rotNlen * rotN.y) * (1.0 / dot(rowY, rowY)),   // b4:175 / b2:159
                                        (rotNlen * rotN.z) * (1.0 / dot(rowZ, rowZ)));  // b4:176 / b2:160
                // World normal transform (b4:179-181 / b2:161-163). CB1[0].x*ns.x+CB1[1].x*ns.y+CB1[2].x*ns.z
                // == (M_math row0)·ns == mul((float3x3)M, ns) in HLSL (URP unity_ObjectToWorld[i] = math row i).
                float3 worldN = mul((float3x3)unity_ObjectToWorld, nScaled);            // b4:179-181 / b2:161-163
                float worldNlen = rsqrt(max(dot(worldN, worldN),
                                            1.1754943508222875079687365372222e-38));    // b4:182 / b2:164 (FLT_MIN guard)
                o.normalWS = worldNlen * worldN;

                // --- Quaternion-rotated TANGENT (b4:186-205 ; b2:168-185) ---
                // base tangent from columns (0,0,-1)/(0,-1,0); gated to zero by _B_surfaceNormals.
                float t0 = mad(qw, 0.0, mad(qz, -1.0, -(qx * 0.0)));   // = -qz   b4:186 / b2:168
                float t1 = mad(qw, 0.0, mad(qx, 0.0, -(qy * -1.0)));   // =  qy   b4:187 / b2:169
                float t2 = mad(qw, -1.0, mad(qy, 0.0, -(qz * 0.0)));   // = -qw   b4:188 / b2:170
                float3 rotT = float3(mad(mad(qy, t1, -(qz * t0)), 2.0, -1.0),   // b4:189 / b2:171
                                     mad(mad(qz, t2, -(qx * t1)), 2.0, 0.0),    // b4:190 / b2:172
                                     mad(mad(qx, t0, -(qy * t2)), 2.0, 0.0));   // b4:191 / b2:173
                float rotTlen = rsqrt(dot(rotT, rotT));                          // b4:192 / b2:174
                // _B_surfaceNormals gate: when off, mask tangent to 0 (b4:193-196 / b2:175-178)
                float surfMask = (_B_surfaceNormals != 0.0) ? 1.0 : 0.0;
                float3 tScaled = (rotTlen * rotT) * surfMask;
                // World tangent transform, same mul(M, v) as the normal but NO inverse-scale (b4:199-201 / b2:179-181).
                float3 worldT = mul((float3x3)unity_ObjectToWorld, tScaled);    // b4:199-201 / b2:179-181
                float worldTlen = rsqrt(max(dot(worldT, worldT),
                                            1.1754943508222875079687365372222e-38)); // b4:202 / b2:182
                o.tangentWS = float4(worldTlen * worldT, 0.0);                   // b4:203-206 / b2:183-186, .w=0

                // --- Vertex color (b4:207-210) base = (1,1,1,1) ---
                o.vertColor = float4(1.0, 1.0, 1.0, 1.0);

                o.uv0 = v.uv0;
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                // --- Surface (b3:117-120) : color = vertexColor * _Color ; alpha = _Opacity ---
                float3 color = input.vertColor.rgb * _Color.rgb;
                float  alpha = _Opacity;

                // --- HGRP fog (atmosphere + exponential + volumetric, b3:101-193) -> URP MixFog (INFRA substitute) ---
                // The decompiled base fragment bakes HG's bespoke 3-layer fog into the forward pass. The three layers
                // are NOT material data and CANNOT be ported into this shader — each needs a host render-pipeline system:
                //   1. Atmosphere fog  (b3:125-131,189-193): driven by _AtmosphereFogParams0..5, HGRP `type_ShaderVariablesGlobal`
                //      globals written per-frame by the HG atmosphere/Fog volume component.
                //   2. Exponential fog (b3:155-188): driven by _ExponentialFogParams0..5, same global cbuffer, set by the Fog volume.
                //   3. Volumetric froxel fog (b3:136-170): samples T0 — a Texture3D froxel scattering volume produced by a
                //      SEPARATE HGRP volumetric-lighting compute pass (froxel injection + integration), indexed by screen XY +
                //      log-depth slice. This is an engine-produced GPU volume, not a material texture.
                // ENGINE-SIDE: closing the HG fog 1:1 requires a host URP ScriptableRendererFeature that (a) binds equivalent
                //   _Atmosphere/_ExponentialFogParams globals from a fog-volume component and (b) runs a volumetric-froxel
                //   compute pass to fill the T0 scattering volume. URP's faithful stand-in until that exists is MixFog over the
                //   per-vertex fog factor (STYLE_BIBLE §2: "HGRP bespoke 3-layer fog -> URP MixFog").
                color = MixFog(color, input.fogFactor);

                // --- VFX color grade (b3:194-198) : desaturate toward luma then per-channel tint ---  1:1, source = Fragment_b3:194-198
                // SV_Target.{x,y,z} = mad(_VFXParams1.w, (channel - luma), luma) * _VFXParams1.{x,y,z}
                //   where luma = dot(rgb, LUMA_REC709) (b3:194) and (_839 + channel) == (channel - luma) (b3:195-198).
                // _VFXParams1 is an HGRP `type_ShaderVariablesGlobal` global with no URP equivalent; re-exposed as the
                // material Vector _HgVFXParams1 (renamed to avoid the URP global name clash). Default (1,1,1,1) keeps
                // the identity grade byte-identical. Math/branch-bounds/swizzles are the blob's verbatim.
                float luma = dot(color, LUMA_REC709);                                   // b3:194
                color = mad(_HgVFXParams1.www, (color - luma), luma) * _HgVFXParams1.xyz; // b3:196-198

                // --- Output (b3:204) ---
                // Source ColorMask RA + premultiplied additive/alpha blend. _BlendMode: 1=additive -> a path
                // mirrors HG (alpha written, RGB factor bound via _SrcBlend). Keep alpha = _Opacity (b3:204).
                return half4(color, alpha);
            }
            ENDHLSL
        }
    }

    Fallback Off
}
