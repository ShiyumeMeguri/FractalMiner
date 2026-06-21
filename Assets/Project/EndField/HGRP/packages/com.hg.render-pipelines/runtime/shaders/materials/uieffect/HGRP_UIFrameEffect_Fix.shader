// HGRP UIEffect/FrameEffect — single transparent ForwardOnly pass (sprite-sheet frame player + glitch/jitter + additive overlay).
// Merged from: uiframeeffect.shader  (base blob Sub0_Pass0_Vertex_b4 / Sub0_Pass0_Fragment_b5; glitch+additive delta Sub0_Pass0_Fragment_b7)
// Keywords: _ENABLE_GLITCH_EFFECT, _ENABLE_ADDITIVE_TEX
// Kept: sprite-sheet cell addressing (_Frame/_RowsColumns) with _ScaleOffset zoom+offset and half-texel edge clamp,
//   particle-aware UV (_InParticle / _MainUVSet) + UV scroll (_MainTexUVSpeed) + UV rotation (_MainTexUVRotate),
//   HDR tint (_TintColor), Glitch line displacement + Jitter (hash frac(sin(dot))),
//   Additive overlay texture (_AdditiveTex/_AdditiveTexIntensity), Alpha/Additive output (_BlendMode), Surface Type, Cull, Stencil.
// Removed (HGRP pipeline infra → URP facilities or dropped): TAA jitter (_TaaJitterStrength), motion vectors + SV_Target1 MRT
//   (HG_ENABLE_MV / prev-frame matrices / _EnableTransparentMV / _Responsive), atmosphere+volumetric fog block
//   (_AtmosphereFogParams*/_ExponentialFogParams*/_VolumetricFogParams*/blue-noise T1 → URP MixFog), camera-relative
//   world-space rebasing (_WorldSpaceCameraPos_Internal), _GlobalMipBias (→ SAMPLE_BIAS 0), particle-instance color
//   (_unity_Float4x5_Param2 / _DisableParticleInstanceColor), _ForceMoveToFarPlane, SRP instancing. Vertex COLOR is passed
//   through but UNUSED by the fragment (the blobs never read it — see frag NOTE), so the sprite is not vertex-tinted.
//   The vertex UV-scroll time _VFXParams0.w (VFX seconds, b4:121-122) → _Time.y; the GLITCH/JITTER time is _Time.x (b7:117,125).
//
// NOTE: source writes a second MRT (SV_Target1 = transparent motion vectors); URP forward has no such target, so it is dropped.
//   With fog removed, the source fog-transmittance factor (_872/_1057) is 1.0, so color = tintedSprite; MixFog applies on top.
//   _BlendMode: 0 = Alpha, 1 = Additive (output a = 0). RGB is premultiplied (rgb*outA) → pair with Blend One OneMinusSrcAlpha
//   (_SrcBlend=1). Matches HGRP_CharacterNPR_VFX_Fix output convention.

Shader "HGRP/UIFrameEffect_Fix" {
    Properties {
        [Enum(Both, 0, Back, 1, Front, 2)] _CullMode ("Render Face", Float) = 2

        [Header(Sprite Sheet)]
        [Toggle(_EMISSIVE_MAP)] _EnableEmissiveMap ("Static Frame Control", Float) = 1
        _MainTex ("Frame Atlas", 2D) = "black" {}
        [HDR] [Gamma] _TintColor ("Tint Color (Emissive)", Color) = (1, 1, 1, 1)
        _Frame ("Frame Index", Float) = 1
        _RowsColumns ("Rows / Columns", Vector) = (1, 1, 0, 0)
        _ScaleOffset ("Scale (xy) / Offset (zw)", Vector) = (1, 1, 0, 0)
        [HideInInspector] _MainTexUVRotate ("Main UV Rotate (deg)", Float) = 0
        [HideInInspector] _MainUVSet ("Main UV Set", Float) = 0
        [HideInInspector] _MainTexUVSpeed ("Main UV Speed", Vector) = (0, 0, 0, 0)
        [HideInInspector] _InParticle ("In Particle", Float) = 0

        [Header(Glitch)]
        [Toggle(_ENABLE_GLITCH_EFFECT)] _EnableGlitchEffect ("Enable Glitch", Float) = 0
        _LinesWidth ("Glitch Width", Range(0, 1)) = 1
        _Amount ("Glitch Frequency", Range(0, 1)) = 0.5
        _Offset ("Glitch Amplitude", Range(0, 1)) = 0.5
        _Threshold ("Jitter Frequency", Range(0, 1)) = 1
        _Intensity ("Jitter Amplitude", Range(0, 0.01)) = 0.0059

        [Header(Additive Overlay)]
        [Toggle(_ENABLE_ADDITIVE_TEX)] _EnableAdditiveTex ("Enable Additive Tex", Float) = 0
        _AdditiveTex ("Additive Tex", 2D) = "white" {}
        _AdditiveTexIntensity ("Additive Tex Intensity", Range(0, 1)) = 1

        [Header(Surface)]
        [Enum(Opaque, 0, Transparent, 1)] _SurfaceType ("Surface Type", Float) = 1
        [Enum(Alpha, 0, Additive, 1)] _BlendMode ("Blend Type", Float) = 0

        // Render-state plumbing (driven by material editor / OnValidate)
        [HideInInspector] _ZWrite ("__zw", Float) = 0
        // RGB is premultiplied by alpha in-shader (frag returns rgb*outA), so the src factor must be One,
        // not SrcAlpha — pairing SrcAlpha with a premultiplied output double-applies alpha. (One, OneMinusSrcAlpha)
        [HideInInspector] _SrcBlend ("__src", Float) = 1
        [HideInInspector] _DstBlend ("__dst", Float) = 10
        [HideInInspector] _ZTest ("__zt", Float) = 4
        [HideInInspector] _StencilRef ("__stencilRef", Float) = 0
        [HideInInspector] _StencilReadMask ("__stencilReadMask", Float) = 255
        [HideInInspector] _StencilWriteMask ("__stencilWriteMask", Float) = 255
        [HideInInspector] _StencilComp ("__stencilComp", Float) = 8
        [HideInInspector] _StencilOp ("__stencilOp", Float) = 0
    }

    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Transparent"
            "Queue"="Transparent"
        }
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Sprite sheet
                float4 _MainTex_ST;
                float4 _MainTex_TexelSize;   // Unity-provided (1/w, 1/h, w, h) — used for half-texel edge clamp
                float4 _TintColor;
                float  _Frame;
                float4 _RowsColumns;
                float4 _ScaleOffset;
                float  _MainTexUVRotate;
                float  _MainUVSet;
                float4 _MainTexUVSpeed;
                float  _InParticle;
                // Glitch
                float  _LinesWidth;
                float  _Amount;
                float  _Offset;
                float  _Threshold;
                float  _Intensity;
                // Additive overlay
                float4 _AdditiveTex_ST;
                float  _AdditiveTexIntensity;
                // Surface
                float  _SurfaceType;
                float  _BlendMode;
            CBUFFER_END

            TEXTURE2D(_MainTex);      SAMPLER(sampler_MainTex);
            TEXTURE2D(_AdditiveTex);  SAMPLER(sampler_AdditiveTex);

            // π/180 — _MainTexUVRotate degrees→radians (blob Vertex_b4:123 const 0.01745329238474369...)
            static const float DEG2RAD = 0.01745329251994329577f;
            // hash constants for frac(sin(dot(p, K)))*S — (blob Fragment_b7:120,123,125,134,243)
            static const float2 HASH_K = float2(12.98980045318603515625f, 78.233001708984375f);
            static const float  HASH_S = 43758.546875f;

            // sign(x) the way the blob spells it: float(int((0u-(0<x?~0:0)) + (x<0?~0:0)))  (blob Fragment_b5:199 / b7:124,216)
            float SignBits(float x)
            {
                return (x > 0.0 ? 1.0 : 0.0) - (x < 0.0 ? 1.0 : 0.0);
            }

            // 2x2 UV rotation about 0.5 center — (blob Vertex_b4:123-129)
            // returns sprite-local UV pre-_MainTex_ST tiling, centered then re-biased by +0.5.
            float2 RotateMainUV(float2 baseUv)
            {
                float ang  = DEG2RAD * _MainTexUVRotate;        // b4:123
                float s    = sin(ang);                          // b4:124
                float c    = cos(ang);                          // b4:125
                float2 cen = baseUv + (-0.5);                   // b4:121-122 ("+ (-0.5)")
                float2 outUv;
                outUv.x = (dot(cen, float2( c, s)) + 0.5);      // b4:126
                outUv.y = (dot(cen, float2(-s, c)) + 0.5);      // b4:127
                return outUv;
            }

            // Sprite-sheet cell base offset (col/row) from _Frame & _RowsColumns — (blob Fragment_b5:115-120 / b7:301-338)
            // cellU = (1/cols) base U offset for current frame's column; cellV similarly. invCols/invRows = cell extents.
            void ComputeCell(out float invCols, out float invRows, out float cellU, out float cellV)
            {
                invCols = 1.0 / _RowsColumns.y;   // b5:115  (.y = columns)
                invRows = 1.0 / _RowsColumns.x;   // b5:116  (.x = rows)
                // clamped frame index → row-major linear index, divided by columns: integer part = row, frac = column band
                float idx = trunc(min(mad(_RowsColumns.x, _RowsColumns.y, -1.0),
                                      max(trunc(-1.0 + _Frame), 0.0))) / _RowsColumns.y;   // b5:117
                float fr  = frac(abs(idx));                                                // b5:118
                cellU = invCols * ((idx >= -idx ? fr : -fr) * _RowsColumns.y);             // b5:119
                cellV = mad(-(floor(idx) + 1.0), invRows, 1.0);                            // b5:120
            }

            // Map a sprite-local UV (uv in [0,1] cell space) through _ScaleOffset zoom/offset into the atlas cell,
            // then clamp to the cell interior by half a texel to avoid bleeding neighbours — (blob Fragment_b5:121 / b7:137)
            float AtlasAxis(float uvLocal, float scale, float offset, float invExtent, float cellBase, float texel)
            {
                // (uvLocal-0.5)/max(0.001,scale)+0.5 → *invExtent → +cellBase → -offset*invExtent  (b5:121 inner mads)
                float v = mad(((uvLocal + (-0.5)) / max(0.001, scale)) + 0.5, invExtent, cellBase);   // inner mad
                v = mad(-offset, invExtent, v);                                                        // - offset*invExtent
                float lo = cellBase + texel;
                float hi = (invExtent + (-texel)) + cellBase;
                return min(hi, max(v, lo));    // b5:121 min(hi, max(inner, lo))
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
                Ref       [_StencilRef]
                ReadMask  [_StencilReadMask]
                WriteMask [_StencilWriteMask]
                Comp      [_StencilComp]
                Pass      [_StencilOp]
                Fail      Keep
                ZFail     Keep
            }

            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma multi_compile_fog
            #pragma shader_feature_local _ENABLE_GLITCH_EFFECT
            #pragma shader_feature_local _ENABLE_ADDITIVE_TEX

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Lighting.hlsl"

            struct Attributes {
                float3 positionOS : POSITION;
                float4 color      : COLOR;
                float4 texcoord0  : TEXCOORD0; // UV0 (.xy), polar/UV1 carry (.zw)
                float4 texcoord1  : TEXCOORD1; // particle custom data / UV1
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                float4 spriteUV   : TEXCOORD0; // .xy = raw UV0 (glitch domain), .zw = rotated+tiled atlas UV
                float4 color      : TEXCOORD1;
                float  fogFactor  : TEXCOORD2;
            };

            Varyings vert(Attributes v)
            {
                Varyings o = (Varyings)0;

                // World→clip. Source builds clip from _NonJitteredViewNoTransProjMatrix in camera-relative space
                // (blob Vertex_b4:106-115); URP TransformObjectToHClip(+GetVertexPositionInputs) is the pixel-neutral equivalent.
                VertexPositionInputs posIn = GetVertexPositionInputs(v.positionOS);
                o.positionCS = posIn.positionCS;
                o.fogFactor  = ComputeFogFactor(posIn.positionCS.z);

                // ---- UV assembly (blob Vertex_b4:119-129) ----
                float inP   = v.texcoord1.x * _InParticle;        // b4:119  (_177)
                bool  uvSet = (0.0 != _MainUVSet);                // b4:120  (_199)
                // particle-aware UV0 select + scroll by _MainTexUVSpeed (.xy by _Time.y[was _VFXParams0.w], .zw by inP)
                float u = mad(_MainTexUVSpeed.z, inP,
                              mad(_MainTexUVSpeed.x, _Time.y,
                                  uvSet ? (mad(v.texcoord0.z, _InParticle, -inP) + v.texcoord1.x) : v.texcoord0.x))
                        + (-0.5);                                  // b4:121  (_223)
                float w = mad(_MainTexUVSpeed.w, inP,
                              mad(_MainTexUVSpeed.y, _Time.y,
                                  uvSet ? (mad(v.texcoord0.w, _InParticle, -(v.texcoord1.y * _InParticle)) + v.texcoord1.y) : v.texcoord0.y))
                        + (-0.5);                                  // b4:122  (_225)

                // rotate about center, re-bias +0.5, then _MainTex_ST tile/offset (b4:123-127)
                float ang = DEG2RAD * _MainTexUVRotate;
                float si  = sin(ang);
                float co  = cos(ang);
                o.spriteUV.z = mad(dot(float2(u, w), float2( co, si)) + 0.5, _MainTex_ST.x, _MainTex_ST.z); // b4:126
                o.spriteUV.w = mad(dot(float2(u, w), float2(-si, co)) + 0.5, _MainTex_ST.y, _MainTex_ST.w); // b4:127
                o.spriteUV.x = v.texcoord0.x;   // b4:128 (raw UV0.x — glitch/frame addressing domain)
                o.spriteUV.y = v.texcoord0.y;   // b4:129 (raw UV0.y)

                o.color = v.color;              // vertex color passed through to match blob varying layout (b4:130-134);
                                                // NOTE: frag does NOT consume it — the base/delta fragment blobs never read
                                                // the COLOR interpolator, so the sprite is NOT tinted by vertex color (see frag).
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                // ---- sprite-sheet cell + texel ----
                float invCols, invRows, cellU, cellV;
                ComputeCell(invCols, invRows, cellU, cellV);   // b5:115-120
                float2 texel = _MainTex_TexelSize.xy;          // (1/w,1/h) — half-texel clamp uses these (b5:121 _MainTex_TexelSize.xy)

                // ---- frame UV (default path: raw UV0 = input.spriteUV.xy) ----
                float uvX = input.spriteUV.x;
                float uvY = input.spriteUV.y;

                #ifdef _ENABLE_GLITCH_EFFECT
                    // ===== Glitch line displacement + Jitter (blob Fragment_b7:117-135) =====
                    float t   = 0.00999999977648258209228515625 * _Time.x;             // b7:117 (0.01 * _Time.x — engine _Time.x = t/20, kept 1:1; NOT _VFXParams0.w)
                    float tf  = frac(abs(t));                                           // b7:118
                    float ts  = (t >= -t) ? tf : -tf;                                   // b7:119  signed frac
                    // per-line random magnitude (blob b7:120-121)
                    float r0  = frac(sin(dot(mad(floor(uvY * 8.0), 0.125, floor(ts * 4000.0) * 25.0).xx, HASH_K)) * HASH_S) * 24.0; // b7:120
                    float ln  = mad(floor((r0 * ts) * 1000.0) / r0, 6.0, uvY);          // b7:121  line coordinate
                    float lw  = 8.0 * _LinesWidth;                                       // b7:122
                    // glitch presence (two hashes - 1) gated by _Amount, scaled by _Offset & sign (blob b7:123-124)
                    float g   = (frac(sin(dot((floor(ln * 7.0) * 0.14285714924335479736328125).xx, HASH_K)) * HASH_S)
                               + frac(sin(dot((floor(lw * ln) / lw).xx, HASH_K)) * HASH_S)) + (-1.0);   // b7:123
                    float off = (clamp((-(1.0 + (-_Amount)) + abs(g)) * 2.5, 0.0, 1.0) * SignBits(g)) * _Offset; // b7:124
                    // Jitter: time/row hash → ±1, gated by _Threshold, scaled by _Intensity (blob b7:125,134)
                    float j   = mad(frac(sin(dot(float2(uvY, _Time.x), HASH_K)) * HASH_S), 2.0, -1.0);  // b7:125  (_283) — _Time.x kept 1:1
                    float gx  = clamp((off * 0.100000001490116119384765625) + uvX, 0.0, 1.0);           // b7:126  (_294)
                    float gy  = clamp(0.0 + uvY, 0.0, 1.0);                                              // b7:127  (_295, asfloat(0u)=0)
                    // jitter only displaces X by _Intensity when |j|>=1-_Threshold (blob b7:134-135)
                    float jx  = frac((j * ((abs(j) >= (1.0 + (-_Threshold))) ? 1.0 : 0.0) * _Intensity) + gx);     // b7:134 (_357)
                    float jy  = frac(0.0 + gy);                                                           // b7:135 (_358)
                    float ceilOff = (-ceil(off)) + 1.0;                                                   // b7:136 (_361)
                    // blend displaced vs original by ceil(off): if any glitch offset → use jittered, else original (b7:137 inner)
                    uvX = mad(ceilOff, gx + (-jx), jx);   // b7:137 inner x: mad(_361, _294-_357, _357)
                    uvY = mad(ceilOff, gy + (-jy), jy);   // b7:137 inner y: mad(_361, _295-_358, _358)
                #endif

                // map frame UV through _ScaleOffset into the atlas cell with half-texel clamp (b5:121 / b7:137)
                float2 atlasUv = float2(
                    AtlasAxis(uvX, _ScaleOffset.x, _ScaleOffset.z, invCols, cellU, texel.x),
                    AtlasAxis(uvY, _ScaleOffset.y, _ScaleOffset.w, invRows, cellV, texel.y));

                float4 mainSample = SAMPLE_TEXTURE2D(_MainTex, sampler_MainTex, atlasUv); // b5:121 / b7:421 (mip bias 0; _GlobalMipBias dropped)

                // ---- tint ----  (blob Fragment_b5:126,194-196 / b7:143,211-213)
                float3 rgb = mainSample.rgb;
                #ifdef _ENABLE_ADDITIVE_TEX
                    // additive overlay: rgb *= 1 + intensity*(addTex-1)  (blob b7:138,211-213)
                    float2 addUv = float2(mad(input.spriteUV.x, _AdditiveTex_ST.x, _AdditiveTex_ST.z),
                                          mad(input.spriteUV.y, _AdditiveTex_ST.y, _AdditiveTex_ST.w)); // b7:138
                    float4 addSample = SAMPLE_TEXTURE2D(_AdditiveTex, sampler_AdditiveTex, addUv);      // b7:138
                    rgb *= mad(_AdditiveTexIntensity, addSample.rgb + (-1.0), 1.0);                     // b7:211-213
                #endif
                rgb *= _TintColor.rgb;            // b5:194-196 / b7:211-213 (_270.xyz * _TintColor.xyz)
                // NOTE: the base/delta fragment blobs NEVER read the vertex-color interpolator (TEXCOORD2):
                //   RGB = mainSample*additive*_TintColor (b5:194-196 / b7:211-213), alpha = mainSample.w*_TintColor.w
                //   (b5:126 / b7:143). The vertex stage computes COLOR-modulated TEXCOORD_1_1 (b4:130-134) but frag_main
                //   ignores it. So NO vertex-color modulation here — it would be fabricated. input.color is left unused.
                float alpha = mainSample.w * _TintColor.w;   // b5:126 / b7:143 (_270.w * _TintColor.w) — no vertex alpha

                // fog (source applies HGRP atmosphere/volumetric fog; URP MixFog is the pixel-neutral equivalent)
                rgb = MixFog(rgb, input.fogFactor);

                // ---- output: Alpha (premultiplied) vs Additive (a=0) — matches HGRP_CharacterNPR_VFX_Fix ----
                // Source gates fog by _938=1-_BlendMode (b5:193/b7:210); blend-state + premultiply express the same.
                float outA = (_SurfaceType == 1.0) ? alpha : 1.0;       // opaque writes 1 (b5:198 surface gate)
                return half4(rgb * outA, (1.0 - _BlendMode) * outA);    // additive → a=0, alpha → premultiplied a
            }
            ENDHLSL
        }
    }
}
