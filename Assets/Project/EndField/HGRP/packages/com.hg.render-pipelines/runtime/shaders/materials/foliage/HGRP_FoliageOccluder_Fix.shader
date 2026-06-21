// HGRP Foliage Occluder — single occlusion-mask pass (URP port).
// Renders foliage geometry into a top-down orthographic XZ occlusion buffer; the fragment
// just stamps a constant 1.0 into the red channel and the Max blend accumulates coverage.
// Merged from: foliageoccluder.shader (HGRP/Foliage/FoliageOccluder — single inline variant, base `_`).
// Keywords: (none — only source multi_compile_local was `_ HG_ENABLE_MV`, motion vectors, dropped)
// Kept: orthographic top-down XZ projection about the occluder-camera center
//   (_FoliageOccluderCameraPosParam.zw) scaled by half-extent (_FoliageOccluderParams0.x);
//   additive-Max blend into R; ZWrite off; two-sided; clip-Z = 0 (depth-agnostic stamp).
// Removed (pixel-neutral pipeline infra, substituted by URP): SRP per-draw instancing array
//   (_ECSPerDraw_ECSPerDrawArray[instanceID] -> unity_ObjectToWorld via TransformObjectToWorld),
//   gl_InstanceIndex/gl_BaseInstanceARB instance addressing, HG_ENABLE_MV motion-vector variant,
//   SPIRV-Cross gl_Position/SV_Target plumbing.
//
// NOTE: _FoliageOccluderParams0 / _FoliageOccluderCameraPosParam are HGRP `ShaderVariablesGlobal`
//   globals (cbuffer packoffset c240/c241) with no URP equivalent global, so they are re-exposed
//   here as material Vector properties (set by the foliage-occluder render feature / C#).
//   _FoliageOccluderParams0.x = projection half-extent (world units mapped to clip ±1).
//   _FoliageOccluderCameraPosParam.zw = occluder-camera world XZ center.
// Output R=1 marks "foliage occludes here"; G/B/A unused (written 0, Max-blended).

Shader "HGRP/FoliageOccluder_Fix" {
    Properties {
        // HGRP ShaderVariablesGlobal re-exposed (no URP equivalent) — driven by the render feature.
        _FoliageOccluderParams0 ("Occluder Params0 (.x = projection half-extent)", Vector) = (1, 0, 0, 0)
        _FoliageOccluderCameraPosParam ("Occluder Camera Pos (.zw = world XZ center)", Vector) = (0, 0, 0, 0)
    }
    SubShader {
        Tags {
            "RenderPipeline"="UniversalPipeline"
            "RenderType"="Opaque"
        }
        LOD 100

        HLSLINCLUDE
            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            CBUFFER_START(UnityPerMaterial)
                float4 _FoliageOccluderParams0;
                float4 _FoliageOccluderCameraPosParam;
            CBUFFER_END
        ENDHLSL

        Pass {
            Name "FoliageOccluder"
            Tags { "LightMode"="UniversalForwardOnly" }   // source LIGHTMODE "Forward" (foliageoccluder.shader:11)

            // Render state 1:1 — foliageoccluder.shader:5-9
            Blend One One, One One
            BlendOp Max, Max
            ZClip On
            ZWrite Off
            Cull Off

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag

            struct Attributes {
                float4 positionOS : POSITION;   // source uses POSITION.w in the matrix mul (foliageoccluder.shader:84)
            };

            struct Varyings {
                float4 positionCS : SV_POSITION;
                // source also emits TEXCOORD0/1 = (0,0,0) and TEXCOORD2 = instanceID
                // (foliageoccluder.shader:74-81). All three are unused by the fragment -> dropped.
            };

            Varyings vert(Attributes v)
            {
                Varyings o;

                // World-space position. Source manually dots each row of objectToWorld with
                // POSITION (incl. POSITION.w) — column_major M[col].x/.z give worldX/worldZ
                // (foliageoccluder.shader:83-84). TransformObjectToWorld is the 1:1 mul(M, float4(pos.xyz, pos.w))
                // with the standard pos.w = 1; instanced _ECSPerDraw matrix -> unity_ObjectToWorld.
                float3 positionWS = TransformObjectToWorld(v.positionOS.xyz);

                // Orthographic top-down XZ projection about the occluder-camera center,
                // scaled by the half-extent (foliageoccluder.shader:83-86):
                //   clip.x =  (worldX - camParam.z) / params0.x
                //   clip.y = -(worldZ - camParam.w) / params0.x
                //   clip.z = 0 ; clip.w = 1
                float invExtent = 1.0 / _FoliageOccluderParams0.x;
                o.positionCS.x =  (positionWS.x - _FoliageOccluderCameraPosParam.z) * invExtent;
                o.positionCS.y = -(positionWS.z - _FoliageOccluderCameraPosParam.w) * invExtent;
                o.positionCS.z = 0.0;
                o.positionCS.w = 1.0;
                return o;
            }

            half4 frag(Varyings input) : SV_Target
            {
                // Constant occlusion stamp — foliageoccluder.shader:119-122.
                // Max-blended into R; G/B/A = 0.
                return half4(1.0, 0.0, 0.0, 0.0);
            }

            ENDHLSL
        }
    }
}
