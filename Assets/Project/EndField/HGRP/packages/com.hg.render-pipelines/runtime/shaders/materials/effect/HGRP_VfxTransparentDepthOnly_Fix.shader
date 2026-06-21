// VFX Transparent Depth-Only — depth (+ optional dissolve clip / vertex offset) prepass for transparent VFX.
// The original HGRP "ForwardOnly" pass uses `Blend Zero One` (writes NOTHING to color) and exists purely
// to lay down depth + a motion-vector buffer (SV_Target1) for transparent effects, with an optional
// VFX_CHARACTER_DISSOLVE clip that `discard`s dissolved fragments and an optional _USE_VERTOFFSET vertex
// scroll. In URP this becomes a DepthOnly pass (the real depth write) plus a color-neutral Unlit pass that
// carries the identical dissolve discard so the depth/coverage matches 1:1.
//
// Merged from: vfxtransparentdepthonly.shader  (Sub0_Pass0, base #else = b18 vertex / b19 fragment)
//   Fragment base       : b19 (HG_ENABLE_MV)                          — color=0, motion=(0.5,0.5)
//   Fragment dissolve   : b43 (HG_ENABLE_MV + VFX_CHARACTER_DISSOLVE) — view-space dissolve clip + emissive edge
//   Vertex base         : b18 (HG_ENABLE_MV)                          — skinned/static pos -> clip
//   Vertex offset       : b20 (HG_ENABLE_MV + _USE_VERTOFFSET)        — _OffsetTex-driven vertex displacement
// Keywords: _USE_VERTOFFSET (vertex offset), _VFX_CHARACTER_DISSOLVE (dissolve clip)
//
// Kept (1:1): dissolve mask field + discard threshold + emissive-edge color (blob b43:106-122), incl.
//   max(per-draw progress, _frameCount) carried by material _HgVfxCustomProgress (b43:112);
//   FULL _USE_VERTOFFSET chain — custom-data UV blend (_OffsetUVSet) + _OffsetTex_ST tiling + _OffsetSpeed
//   time/custom scroll, bidirectional remap (_Bi_Offset), _OffsetDir.w intensity, Object/World/Normal direction
//   resolved to WORLD space (TransformObjectToWorldDir), _558 amplitude, added to positionWS (b20:262-271,488-490).
//   Stale b20 cbuffer alias names decoded vs clean sibling characternpr_vfx (Fragment_b249.hlsl:159-170);
//   color-neutral output (Blend Zero One => fragment color is discarded by the blend, only depth/clip matter);
//   _SurfaceType / _CullMode / ZTest plumbing.
// Removed (pixel-neutral pipeline infra substituted by URP, or sandbox-dropped):
//   motion vectors + SV_Target1 (b18:288-298, b19:25-28) — URP has no combined transparent depth+MV pass;
//   GPU skinning via T0 ByteAddressBuffer + _unity_LODFade.w gate (b18:68-269, b20:282-487) — static mesh in sandbox;
//   octahedral normal unpack in the offset vert (b20:171-230) — normalOS used directly;
//   camera-relative world space (_WorldSpaceCameraPos_Internal subtraction, b18:280-282) — URP uses absolute WS;
//   TAA jitter (_TaaJitterStrength, b18:286-287); _NonJitteredViewNoTransProjMatrix -> UNITY_MATRIX_VP;
//   instancing (SRP_INSTANCING_ON), DEBUG_REGULART, BAKED_SKINNING_MESH (no behavioral delta in this shader);
//   _GlobalMipBias declaration — URP provides it (float2, Input.hlsl:112); SampleBias uses URP _GlobalMipBias.x.
// ENGINE-SIDE (not ported, needs a host system): _VAT_SOFTBODY / _UNLOAD_ROT_TEX Houdini VAT (samples
//   _PositionTexture/_RotationTexture/_LookupTable driven by per-draw frame scheduling _displayFrame/
//   _gameTimeAtFirstFrame/_playbackSpeed/_houdiniFPS, blob b22) — requires a C# VAT-playback render feature
//   to fill the per-draw frame uniforms; out of this shader's keyword scope (_USE_VERTOFFSET/_VFX_CHARACTER_DISSOLVE).
//
// NOTE: the dissolve cbuffer ALIASES generic "_boundMin/_boundMax" names onto packed dissolve scalars
//   (compiler packoffset reuse, b43:42-52); they are dissolve params here, NOT mesh bounds. Channel legend
//   below in CBUFFER. The dissolve UV is built in VIEW space (b43:109-112) from (worldPos - objectOrigin).

Shader "HGRP/VfxTransparentDepthOnly_Fix"
{
    Properties
    {
        [Enum(Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2
        [ToggleUI] _DisableZTest ("Disable ZTest", Float) = 0
        [ToggleUI] _DisableVertColor ("Disable VertColor", Float) = 0
        [ToggleUI] _InParticle ("Use In Particle", Float) = 1

        // ---- Vertex offset (scroll) ----
        [Toggle(_USE_VERTOFFSET)] _UseVertexOffset ("Use Vertex Offset", Float) = 0
        _OffsetTex ("Offset Tex", 2D) = "white" {}
        _OffsetSpeed ("Offset Speed (XY:By Time, ZW:By Custom)", Vector) = (0, 0, 0, 0)
        _OffsetDir ("Offset Dir (XYZ:Axis, W:By CustomY)", Vector) = (0, 0, 0, 0)
        [Enum(Object, 0, World, 1, Normal, 2)] _OffsetSwitchDir ("Dir Switcher", Float) = 0
        _OffsetIntensity ("Offset Intensity", Float) = 0
        [ToggleUI] _Bi_Offset ("Use Two Direction Offset", Float) = 0
        [Enum(UV0, 0, UV1, 1)] _OffsetUVSet ("Vertex Offset UV Set", Float) = 0

        // ---- Dissolve clip (VFX_CHARACTER_DISSOLVE) ----
        [Toggle(_VFX_CHARACTER_DISSOLVE)] _UseDissolveClip ("Use Dissolve Clip", Float) = 0
        _DissolveTex ("Dissolve Tex", 2D) = "white" {}
        [HDR] _DissolveEmissiveColor ("Dissolve Emissive Color", Color) = (0, 0, 0, 0)
        _CutOffDirection ("Cutoff Direction (XYZ)", Vector) = (0, 0, 0, 0)
        _CutOffPosY ("Cutoff Pos", Float) = 0
        // Per-draw VFX custom-data progress (b43:112 _unity_Float4x5_Param2.w, type_UnityPerDraw register b1).
        //   HG-specific (no URP global). Renamed _Hg* (compile-hardening #1) so a host MaterialPropertyBlock can
        //   drive it per-particle; default 0 => max(0,_frameCount)=_frameCount (base path byte-identical).
        _HgVfxCustomProgress ("VFX Custom Progress (per-draw)", Float) = 0
        // NOTE: _GlobalMipBias is NOT declared here — URP provides it (float2, Input.hlsl:112). Declaring a
        //   shader-private `float _GlobalMipBias` redefines the URP global (compile error under Core.hlsl /
        //   UNITY_VIRTUAL_TEXTURING). The dissolve SampleBias uses URP's _GlobalMipBias.x, value 0 by default
        //   (== blob bias), so the math stays 1:1 (compile-hardening #1; sibling DecalErosionVolume/LitEffect).
        // Packed dissolve scalars (aliased onto _bound* / _frame* by the compiler, see header NOTE):
        _frameCount ("Dissolve Progress (frameCount)", Float) = 0
        _boundMaxX ("Dissolve EdgeSharpen (boundMaxX)", Float) = 1
        _boundMaxY ("Dissolve EdgeOffset (boundMaxY)", Float) = 0
        _boundMaxZ ("Dissolve UV-View Blend (boundMaxZ)", Float) = 0
        _boundMinX ("Dissolve UVSetSelect (boundMinX)", Float) = 0
        _boundMinY ("Dissolve FieldScaleA (boundMinY)", Float) = 0
        _boundMinZ ("Dissolve FieldScaleB (boundMinZ)", Float) = 1

        // ---- Blend/state plumbing (source ForwardOnly = `Blend Zero One, Zero One`, color-neutral) ----
        [HideInInspector] _SrcBlend ("__src", Float) = 0     // Zero
        [HideInInspector] _DstBlend ("__dst", Float) = 1     // One
        [HideInInspector] _ZTest ("__zt", Float) = 4         // LEqual
        [HideInInspector] _ZWrite ("__zw", Float) = 1
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
    }

    SubShader
    {
        Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Transparent" "Queue" = "Transparent" }
        LOD 100

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

        CBUFFER_START(UnityPerMaterial)
            float  _SurfaceType;
            float  _CullMode;
            float  _DisableZTest;
            float  _DisableVertColor;
            float  _InParticle;

            // Vertex offset
            float4 _OffsetTex_ST;
            float4 _OffsetSpeed;
            float4 _OffsetDir;
            float  _OffsetSwitchDir;
            float  _OffsetIntensity;
            float  _Bi_Offset;
            float  _OffsetUVSet;

            // Dissolve (aliased packed scalars; see header NOTE)
            float4 _DissolveTex_ST;
            float4 _DissolveEmissiveColor;
            float4 _CutOffDirection;
            float  _CutOffPosY;
            // (_GlobalMipBias intentionally absent — provided by URP as float2; see Properties NOTE / compile-hardening #1)
            float  _frameCount;     // dissolve progress driver       (blob b43:42)
            float  _boundMaxX;      // edge sharpen / field scale      (blob b43:44 ; *_boundMaxX in b43:113-114)
            float  _boundMaxY;      // edge offset for emissive band   (blob b43:43 ; b43:114)
            float  _boundMaxZ;      // view-UV vs vertex-UV blend       (blob b43:43 ; b43:112)
            float  _boundMinX;      // UV-set select (!=0 -> TEXCOORD_2) (blob b43:42 ; b43:106)
            float  _boundMinY;      // dissolve field scale A           (blob b43:42 ; b43:112)
            float  _boundMinZ;      // dissolve field scale B           (blob b43:42 ; b43:112)
            float  _HgVfxCustomProgress; // per-draw VFX progress (b43:112 _unity_Float4x5_Param2.w); default 0

            float  _StencilRef;
        CBUFFER_END

        // Source samples both maps through SRP global LinearClamp samplers
        // (b20:68 sampler_LinearClamp_OffsetTex, b43:56 sampler_LinearClamp_DissolveTex);
        // URP provides sampler_LinearClamp (GlobalSamplers.hlsl via Core.hlsl) — use it so the
        // view-space dissolve UV (can exceed [0,1]) clamps exactly like the source instead of
        // inheriting the texture's import wrap mode.
        TEXTURE2D(_OffsetTex);
        TEXTURE2D(_DissolveTex);

        // ============================================================
        // Vertex offset — 1:1 math of blob b20 (Sub0_Pass0_Vertex_b20.hlsl). Returns the WORLD-SPACE offset
        // vector (_551,_552,_553)*_558 that b20 adds to the world position (b20:488-490); Vert adds it to
        // positionWS and re-derives clip (= base path when the keyword is off).
        // The decompiled b20 cbuffer ALIASES the offset uniforms onto stale dissolve-named packoffset slots
        // (b20:55-64). Real names recovered by matching the SAME packing in the clean sibling characternpr_vfx
        // cbuffer (Fragment_b249.hlsl:159-170, anchored on _Bi_Offset@c37):
        //   c20.x _Bi_Offset              -> _Bi_Offset
        //   c20.y _DissolveScheduleOffset -> _OffsetSwitchDir   (1=World,2=Normal,0=Object)
        //   c20.z _DissolveEdgeSharp      -> _OffsetUVSet        (UV0/UV1 blend factor; _497 = 1-_OffsetUVSet)
        //   c20.w _DissolveEmissiveEdge   -> _OffsetIntensity
        //   c21.x _DissolveUseViewUV \                          tiling .x/.z of _OffsetTex_ST (inner mad)
        //   c21.z _UseCutOff          } -> _OffsetTex_ST.x/.z
        //   c21.y _DissolveUVSet     \                          tiling .y/.w of _OffsetTex_ST (inner mad)
        //   c21.w _UseDissolve        } -> _OffsetTex_ST.y/.w
        //   c22   _CutOffPosY_at_352  (float4) -> _OffsetDir     (.xyz axis, .w "By CustomY")
        //   c23   _DissolveTex_ST_at_368 (float4) -> _OffsetSpeed (.xy By Time, .zw By Custom)
        // b20 fuses this with octahedral normal unpack (b20:171-230), GPU skinning (T0 ByteAddressBuffer,
        // b20:282-487) and camera-relative MV (b20:488-533) — all INFRA dropped (static mesh, no MV).
        //   _379  = uv1.y * _InParticle                                                       (b20:262)
        //   blendUV = lerp(uv0.xy, _InParticle*(uv0.zw-uv1.xy)+uv1.xy, _OffsetUVSet)          (b20:268 inner)
        //   offUV = _OffsetSpeed.zw*_379 + _OffsetSpeed.xy*time + (blendUV*_OffsetTex_ST.xy + _OffsetTex_ST.zw) (b20:268)
        //   s     = mad(tex.x, 1+_Bi_Offset, -_Bi_Offset)  bidirectional [0,1]->[-1,1] remap  (b20:268 _550)
        //   intensity = mad(_OffsetDir.w, _379, _OffsetIntensity)                             (b20:266 _472)
        //   dirWS = World(_OffsetDir.xyz) | Normal(O2WDir(normalOS)) | Object(O2WDir(_OffsetDir.xyz)) by switch (b20:269-271)
        //   offWS = dirWS * (s * intensity) * (1 - O2W._m10)                                  (b20:488-490 _551*_558)
        // ============================================================
        float3 ComputeVertexOffsetWS(float3 positionOS, float3 normalOS, float4 uv0, float4 uv1)
        {
        #ifdef _USE_VERTOFFSET
            // _379: per-vertex custom-data driver = uv1.y * _InParticle (b20:262)
            float custom = uv1.y * _InParticle;

            // UV blend (b20:268 inner): blendUV = lerp( uv0.xy , _InParticle*(uv0.zw - uv1.xy) + uv1.xy , _OffsetUVSet )
            //   blob blend factor = _DissolveEdgeSharp (c20.z) = _OffsetUVSet; _497 = 1 - _OffsetUVSet (b20:267).
            //   uv0.zw carry per-particle custom data (blob TEXCOORD0 float4).
            float blend    = _OffsetUVSet;                                                                  // b20:268 _DissolveEdgeSharp
            float invBlend = 1.0 - blend;                                                                   // b20:267 _497
            float2 customUV = float2(mad(uv0.z, _InParticle, -(uv1.x * _InParticle)) + uv1.x,
                                     mad(uv0.w, _InParticle, -(uv1.y * _InParticle)) + uv1.y);              // b20:268 inner-inner
            float2 blendUV  = float2(mad(customUV.x, blend, invBlend * uv0.x),
                                     mad(customUV.y, blend, invBlend * uv0.y));                              // b20:268 inner lerp
            // tiling of blendUV by _OffsetTex_ST, then scroll: _OffsetSpeed.xy*time + _OffsetSpeed.zw*custom (b20:268).
            //   blob time term is _VFXParams0.w (per-draw VFX effect time) -> _Time.y (sibling CharacterNPR_VFX convention).
            float2 tiledUV = mad(blendUV, _OffsetTex_ST.xy, _OffsetTex_ST.zw);                              // b20:268 inner-outer mad
            float2 offUV;
            offUV.x = mad(_OffsetSpeed.z, custom, mad(_OffsetSpeed.x, _Time.y, tiledUV.x));                 // b20:268 outer (x)
            offUV.y = mad(_OffsetSpeed.w, custom, mad(_OffsetSpeed.y, _Time.y, tiledUV.y));                 // b20:268 outer (y)

            // _550: _OffsetTex sample (LOD 0), bidirectional remap [0,1]->[-1,1] via _Bi_Offset (b20:268)
            float s = SAMPLE_TEXTURE2D_LOD(_OffsetTex, sampler_LinearClamp, offUV, 0.0).x;
            s = mad(s, 1.0 + _Bi_Offset, -_Bi_Offset);

            // _472: intensity = mad(_OffsetDir.w, _379, _OffsetIntensity) (b20:266). _OffsetDir.w=0 default => _OffsetIntensity.
            float intensity = mad(_OffsetDir.w, custom, _OffsetIntensity);

            // direction -> WORLD space (b20:269-271): _385=(1==switch)=World uses _OffsetDir.xyz directly (world axis);
            //   _386=(2==switch)=Normal uses O2W*normalOS; else (0)=Object uses O2W*_OffsetDir.xyz. The Object/Normal
            //   cases transform the OS direction by unity_ObjectToWorld (TransformObjectToWorldDir = O2W linear part,
            //   matching b20's mad(CB2[2],dz,mad(CB2[0],dx,dy*CB2[1])) column-major O2W*dir).
            float3 dirWS;
            if (_OffsetSwitchDir == 1.0)        dirWS = _OffsetDir.xyz;                                     // b20:269-271 _385 World
            else if (_OffsetSwitchDir == 2.0)   dirWS = TransformObjectToWorldDir(normalOS, false);         // b20:269-271 _386 Normal
            else                                dirWS = TransformObjectToWorldDir(_OffsetDir.xyz, false);   // b20:269-271 else Object

            // _558 amplitude scale = 1 - unity_ObjectToWorld._m10 (b20:272,488-490).
            float amp = 1.0 - unity_ObjectToWorld._m10;                                 // b20:272 _558

            return dirWS * (s * intensity * amp);                                       // b20:488-490 _551*_558 (world-space offset)
        #else
            return 0.0.xxx;
        #endif
        }

        // ============================================================
        // Dissolve field + discard (1:1 from blob b43:103-123).
        // Builds a view-space dissolve UV from (worldPos - objectOrigin), samples _DissolveTex, forms a signed
        // field _175 and discards where clamp(_175*_boundMaxX,0,1) - 0.01 < 0. Returns the emissive edge color.
        // ============================================================
        float3 DissolveClipAndEdge(float3 positionWS, float2 uv0, float2 uv1)
        {
            float3 emissive = 0.0.xxx;
        #ifdef _VFX_CHARACTER_DISSOLVE
            // UV-set select: _boundMinX != 0 -> use second UV set (b43:106-108)
            bool   useUV2 = (0.0 != _boundMinX);
            float2 selUV  = useUV2 ? uv1 : uv0;

            // object-local world offset = worldPos - objectOrigin (b43:109-111; unity_ObjectToWorld._m03/13/23)
            float3 objOrigin = float3(unity_ObjectToWorld._m03, unity_ObjectToWorld._m13, unity_ObjectToWorld._m23);
            float3 localWS = positionWS - objOrigin;

            // view-space X/Y of that offset, blended toward selUV by _boundMaxZ (b43:112)
            float viewX = dot(UNITY_MATRIX_V._m00_m01_m02, localWS);   // _ViewMatrix row0 . localWS
            float viewY = dot(UNITY_MATRIX_V._m10_m11_m12, localWS);   // _ViewMatrix row1 . localWS
            float dux = mad(_boundMaxZ, viewX - selUV.x, selUV.x);
            float duy = mad(_boundMaxZ, viewY - selUV.y, selUV.y);
            float2 disUV = float2(mad(dux, _DissolveTex_ST.x, _DissolveTex_ST.z),
                                  mad(duy, _DissolveTex_ST.y, _DissolveTex_ST.w));

            // progress remap: -(max(_param2.w,_frameCount)*2.02 - 1.01) + texSample   (b43:112)
            //   Source progress = max(_unity_Float4x5_Param2.w, _frameCount). The per-draw .w is carried 1:1 by
            //   material-bindable _HgVfxCustomProgress (default 0 => max collapses to _frameCount).
            float progress = max(_HgVfxCustomProgress, _frameCount);                    // b43:112 max(_param2.w,_frameCount)
            float remap    = -mad(progress, 2.019999980926513671875, -1.0099999904632568359375); // b43:112 constants
            float texS     = SAMPLE_TEXTURE2D_BIAS(_DissolveTex, sampler_LinearClamp, disUV, _GlobalMipBias.x).x; // b43:112 T0.SampleBias(...,_GlobalMipBias); URP _GlobalMipBias.x (Input.hlsl:112), default 0

            // signed dissolve field _175 (b43:112): boundMinY * (-(dir.localWS) + CutOffPosY) + (remap + texS)*boundMinZ
            float dirTerm = -dot(positionWS, _CutOffDirection.xyz) + _CutOffPosY;
            float field   = mad(_boundMinY, dirTerm, (remap + texS) * _boundMinZ);

            // discard where clamp(field*boundMaxX,0,1) - 0.01 < 0   (b43:113)
            clip((clamp(field * _boundMaxX, 0.0, 1.0) - 0.00999999977648258209228515625));

            // emissive edge band: clamp((-field + boundMaxY)*boundMaxX,0,1) * _DissolveEmissiveColor  (b43:114-117)
            float band = clamp((-field + _boundMaxY) * _boundMaxX, 0.0, 1.0);
            emissive = band * _DissolveEmissiveColor.rgb;
        #endif
            return emissive;
        }

        struct Attributes
        {
            float3 positionOS : POSITION;
            float3 normalOS   : NORMAL;
            // uv0 is float4 (blob TEXCOORD0 is float4): .xy = mesh UV, .zw = per-particle custom data the b20
            //   offset-UV blend consumes in the vertex stage (b20:268). Dissolve uses only .xy (b43:107).
            float4 uv0        : TEXCOORD0;
            float4 uv1        : TEXCOORD1;
        };

        struct Varyings
        {
            float4 positionCS : SV_POSITION;
            float3 positionWS : TEXCOORD0;
            float2 uv0        : TEXCOORD1;
            float2 uv1        : TEXCOORD2;
        };

        Varyings Vert(Attributes input)
        {
            Varyings output = (Varyings)0;
            // Base path: OS -> WS/CS via URP VP (b18:283-285,311). The b20 offset is added in WORLD space
            // (b20:488-490 mad(_551,_558, worldPos)); when _USE_VERTOFFSET is off ComputeVertexOffsetWS=0 so
            // positionWS is unchanged and TransformWorldToHClip == vpi.positionCS (base path byte-identical).
            VertexPositionInputs vpi = GetVertexPositionInputs(input.positionOS);
            float3 offsetWS = ComputeVertexOffsetWS(input.positionOS, input.normalOS, input.uv0, input.uv1);
            float3 positionWS = vpi.positionWS + offsetWS;
            output.positionWS = positionWS;
            output.positionCS = TransformWorldToHClip(positionWS);
            output.uv0 = input.uv0.xy;
            output.uv1 = input.uv1.xy;
            return output;
        }
        ENDHLSL

        // ====================================================================
        // DepthOnly — the actual depth write (replaces HGRP transparent depth half of ForwardOnly).
        // ====================================================================
        Pass
        {
            Name "DepthOnly"
            Tags { "LightMode" = "DepthOnly" }

            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]
            ColorMask 0

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex Vert
            #pragma fragment FragDepth
            #pragma shader_feature_local _USE_VERTOFFSET
            #pragma shader_feature_local _VFX_CHARACTER_DISSOLVE

            void FragDepth(Varyings input)
            {
                // dissolve discard so the depth buffer matches the visible (un-dissolved) coverage (b43:113)
                DissolveClipAndEdge(input.positionWS, input.uv0, input.uv1);
            }
            ENDHLSL
        }

        // ====================================================================
        // Color pass — color-neutral (Blend Zero One): fragment output is discarded by the blend, so this
        // contributes ONLY depth + the dissolve `discard`, faithfully reproducing the source ForwardOnly pass.
        // Source frag (b19:21-24): color=(0,0,0,0). Dissolve (b43:115-118): color=band*_DissolveEmissiveColor, a=0.
        // ====================================================================
        Pass
        {
            Name "VfxDepthColorNeutral"
            Tags { "LightMode" = "SRPDefaultUnlit" }

            Blend [_SrcBlend] [_DstBlend]   // Zero One  => dst kept, source color discarded (b: `Blend Zero One`)
            ZTest [_ZTest]
            ZWrite [_ZWrite]
            Cull [_CullMode]

            HLSLPROGRAM
            #pragma target 3.0
            #pragma vertex Vert
            #pragma fragment FragColor
            #pragma shader_feature_local _USE_VERTOFFSET
            #pragma shader_feature_local _VFX_CHARACTER_DISSOLVE

            float4 FragColor(Varyings input) : SV_Target
            {
                // base: color = 0 (b19:21-24). dissolve: emissive edge, alpha = 0 (b43:115-118).
                float3 emissive = DissolveClipAndEdge(input.positionWS, input.uv0, input.uv1);
                return float4(emissive, 0.0);
            }
            ENDHLSL
        }
    }
}
