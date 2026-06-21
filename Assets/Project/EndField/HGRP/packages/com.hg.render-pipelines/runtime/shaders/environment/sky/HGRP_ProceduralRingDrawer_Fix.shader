// HGRP Procedural Ring Drawer — single unlit textured pass.
// Draws a procedurally-built ring/halo mesh (e.g. a planetary ring or sky halo) as a flat,
// fullbright textured quad: object->world->clip transform, tiled _MainTex lookup, and the raw
// texture sample written straight to the target. No lighting, no fog, no blending state in the
// source — it is the plainest possible "blit a textured mesh through the standard MVP" drawer.
//
// Merged from: proceduralringdrawer.shader (HGRP/ProceduralRingDrawer) — single pass, single variant.
//   Vertex   (inline Blob 1): source lines 59-71  (no keyword ladder; code is inline in the .shader).
//   Fragment (inline Blob 2): source lines 107-114 (no keyword ladder; code is inline in the .shader).
//
// Keywords: (none — the source declares no #pragma multi_compile_local / shader_feature; one variant only).
// Kept: standard object->world (_unity_ObjectToWorld) then world->clip (_unity_MatrixVP) transform,
//   _MainTex tiling/offset via _MainTex_ST (mad(uv, ST.xy, ST.zw)), single _MainTex sample through a
//   Linear/Clamp sampler written verbatim to SV_Target, LOD 100, ZClip On, RenderType Opaque.
// Removed: SPIRV-Cross plumbing (gl_Position / SPIRV_Cross_Input/Output / static I/O globals),
//   the hand-rolled type_UnityPerDraw (_unity_ObjectToWorld) + type_UnityPerFrame (_unity_MatrixVP)
//   + type_Globals (_Globals_MainTex_ST) cbuffers — replaced by URP TransformObjectToWorld /
//   UNITY_MATRIX_VP / UnityPerMaterial _MainTex_ST. No instancing/TAA/motion keys exist in the source.
//
// NOTE: [HDR] _Color is declared in the source Properties (line 4) but the compiled fragment Blob 2
//   (source lines 109-113) writes the RAW texture sample with NO _Color multiply — _Color is unused
//   by this variant. It is preserved as a property for material/inspector compat but is intentionally
//   NOT applied in frag (applying it would deviate from the 1:1 compiled base). See gaps / TODO below.
// NOTE: source sampler = sampler_LinearClamp (Linear filter, Clamp wrap) — provided by URP Core.hlsl
//   (GlobalSamplers), so it is NOT re-declared here (a manual SAMPLER would be an X3003 duplicate).

Shader "HGRP/ProceduralRingDrawer_Fix"
{
    Properties
    {
        [HideInInspector] _MainTex ("Texture", 2D) = "white" {}   // sampled as T0 (source line 91)
        // Declared in source (line 4) but UNUSED by the compiled fragment — kept for compat, not applied.
        [HDR] _Color ("Color and Alpha (unused by base variant)", Color) = (1, 1, 1, 1)
    }

    SubShader
    {
        Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
        LOD 100

        Pass
        {
            Name "ProceduralRingDrawer"
            // Source: Pass has NO "LightMode" tag (HGRP default unlit draw). Mapped to URP's forward
            // path so an opaque material renders it directly.
            Tags { "LightMode" = "UniversalForwardOnly" }

            // Source render state (proceduralringdrawer.shader lines 11-13): only "ZClip On" is set;
            // Blend/ZTest/ZWrite/Cull/Stencil are left at pipeline defaults (opaque: ZWrite On, ZTest LEqual).
            ZClip On

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                // Tiling/offset for _MainTex. Source: type_Globals._Globals_MainTex_ST (source line 38),
                // consumed as mad(uv, ST.xy, ST.zw) at source lines 69-70.
                float4 _MainTex_ST;
                // Declared for compat; not read by frag (see header NOTE).
                float4 _Color;
            CBUFFER_END

            // T0 (source line 91). sampler_LinearClamp comes from Core.hlsl (GlobalSamplers) — not redeclared.
            TEXTURE2D(_MainTex);

            struct Attributes
            {
                float3 positionOS : POSITION;   // source POSITION (.w forced to 1 in the transform)
                float2 uv         : TEXCOORD0;   // source TEXCOORD
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float2 uv         : TEXCOORD0;   // source TEXCOORD_1
            };

            Varyings vert(Attributes input)
            {
                Varyings output = (Varyings)0;

                // object->world then world->clip. Source builds this by hand:
                //   worldPos = mul(_unity_ObjectToWorld, float4(POSITION.xyz, 1))   (source lines 61-64)
                //   clipPos  = mul(_unity_MatrixVP, worldPos)                       (source lines 65-68)
                // URP: TransformObjectToWorld == mul(_unity_ObjectToWorld, float4(pos,1)).xyz, and
                // mul(UNITY_MATRIX_VP, float4(worldPos,1)) == TransformWorldToHClip. 1:1 transform chain.
                float3 positionWS = TransformObjectToWorld(input.positionOS);   // source lines 61-64
                output.positionCS = mul(UNITY_MATRIX_VP, float4(positionWS, 1.0)); // source lines 65-68

                // Tiled UV: TEXCOORD_1.xy = mad(TEXCOORD.xy, _MainTex_ST.xy, _MainTex_ST.zw). Source lines 69-70.
                output.uv.x = mad(input.uv.x, _MainTex_ST.x, _MainTex_ST.z);   // source line 69
                output.uv.y = mad(input.uv.y, _MainTex_ST.y, _MainTex_ST.w);   // source line 70
                return output;
            }

            float4 frag(Varyings input) : SV_Target
            {
                // Raw texture sample written straight to SV_Target — source lines 109-113:
                //   _33 = T0.Sample(sampler_LinearClamp, uv); SV_Target.xyzw = _33.xyzw;
                // No _Color multiply in the compiled base variant (see header NOTE).
                float4 col = SAMPLE_TEXTURE2D(_MainTex, sampler_LinearClamp, input.uv); // source line 109
                return col;                                                             // source lines 110-113
                // TODO(1:1): source declares [HDR] _Color (source line 4) but the compiled fragment
                // (source lines 109-113) never multiplies by it — _Color is dead in this variant, so it
                // is intentionally NOT applied. If a non-base variant that uses _Color is ever found, fold
                // a `col *= _Color;` here. vs source lines 109-113.
            }
            ENDHLSL
        }
    }
}
