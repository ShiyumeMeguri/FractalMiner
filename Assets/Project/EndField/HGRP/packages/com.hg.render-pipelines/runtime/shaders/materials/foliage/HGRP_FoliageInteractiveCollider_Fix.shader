// HGRP Foliage Interactive Collider — Unified Fix shader.
// A single top-down ORTHOGRAPHIC "occluder" pass that bakes the world-space HEIGHT of foliage
// colliders into an interaction/heightfield buffer. The vertex stage projects the XZ world plane
// straight onto clip XY (no camera view/proj) and the fragment writes the encoded world-Y height;
// the host pass uses Blend One One + BlendOp Min so each texel keeps the LOWEST covering height,
// which the foliage system later reads to bend grass around dynamic colliders.
//
// Merged from: foliageinteractivecollider.shader (HGRP/Foliage/FoliageInteractiveCollider).
//   Base (#else catch-all): Sub0_Pass0_Vertex_b1.hlsl + Sub0_Pass0_Fragment_b2.hlsl.
//   Delta (HG_ENABLE_MV && INSTANCING_ON): Sub0_Pass0_Vertex_b3 / _Fragment_b4 — byte-identical
//   to the base (the keywords change zero emitted math), so nothing extra is folded in.
//
// Keywords: (none — no shader_feature; the source's HG_ENABLE_MV / INSTANCING_ON are no-op permutation keys).
// Kept: per-instance object->world transform, XZ->clipXY orthographic projection, world-Y height
//   encode (Y*0.5+0.5), UV + instanceID passthrough interpolators (carried 1:1; unused by the base frag),
//   the FoliageOccluder LightMode tag, additive-min blend / ZClip On / Cull Off render state.
// Removed: SPIRV-Cross statics & SPIRV_Cross_Input/Output plumbing, the explicit _LocalToWorldMatrices[]
//   cbuffer + gl_InstanceIndex/gl_BaseInstanceARB indexing (replaced by URP unity_ObjectToWorld /
//   TransformObjectToWorld under UNITY_INSTANCING), motion-vector / instancing keyword permutations.
//
// NOTE: this is a custom-LightMode pass ("FoliageOccluder"); URP will only schedule it from a matching
//   custom ScriptableRenderPass / RendererFeature. No UniversalForward/ShadowCaster/Depth passes exist
//   in the source, so none are synthesized here.
// NOTE: output is float4(height01, height01, 0, 1) where height01 = worldPosY*0.5 + 0.5
//   (matches Fragment_b2 lines 29-32, fed by Vertex_b1 lines 53-56).

Shader "HGRP/FoliageInteractiveCollider_Fix"
{
    Properties
    {
        // This source shader has NO material properties; the pass is driven entirely by mesh data
        // (POSITION + TEXCOORD0) and the per-instance object->world matrix.
    }

    SubShader
    {
        Tags { "RenderPipeline" = "UniversalPipeline" "RenderType" = "Opaque" }
        LOD 100

        Pass
        {
            Name "FoliageOccluder"
            Tags { "LightMode" = "FoliageOccluder" }

            // Source render state (foliageinteractivecollider.shader lines 5-8):
            //   Blend One One, One One  /  BlendOp Min, Min  /  ZClip On  /  Cull Off
            Blend One One, One One
            BlendOp Min, Min
            ZClip On
            Cull Off

            HLSLPROGRAM
            #pragma target 3.5
            #pragma vertex vert
            #pragma fragment frag
            // Keep instancing support so unity_ObjectToWorld resolves the correct per-instance matrix
            // (the source indexed _LocalToWorldMatrices[gl_InstanceIndex - gl_BaseInstanceARB]).
            #pragma multi_compile_instancing

            #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

            struct Attributes
            {
                float3 positionOS : POSITION;
                float2 uv         : TEXCOORD0;
                UNITY_VERTEX_INPUT_INSTANCE_ID
            };

            struct Varyings
            {
                float4 positionCS : SV_POSITION;
                float4 height      : TEXCOORD1; // worldPosY*0.5+0.5 broadcast to .xxxx (Vertex_b1 lines 53-56)
                float4 uv          : TEXCOORD2; // (uv.x, uv.y, uv.x, uv.y) passthrough (Vertex_b1 lines 59-62)
                nointerpolation uint instanceIndex : TEXCOORD3; // instance id passthrough (Vertex_b1 line 63)
            };

            Varyings vert(Attributes input)
            {
                Varyings output = (Varyings)0;
                UNITY_SETUP_INSTANCE_ID(input);

                // 1:1 object->world transform. Source builds mul(_LocalToWorldMatrices[i], float4(POSITION,1)).xyz
                // by hand (Vertex_b1 lines 50-52); URP's TransformObjectToWorld == the same per-instance matrix.
                float3 positionWS = TransformObjectToWorld(input.positionOS);

                // Orthographic top-down projection: XZ world plane -> clip XY, z=1, w=1.
                //   gl_Position.x =  worldX                  (Vertex_b1 line 52)
                //   gl_Position.y = -worldZ  ((-0.0f)-worldZ)(Vertex_b1 line 51)
                //   gl_Position.z =  1.0                     (Vertex_b1 line 57)
                //   gl_Position.w =  1.0                     (Vertex_b1 line 58)
                output.positionCS = float4(positionWS.x, -positionWS.z, 1.0, 1.0);

                // World-Y height encoded into [0,1] and broadcast to all 4 channels (Vertex_b1 lines 53-56).
                float height01 = mad(positionWS.y, 0.5, 0.5);
                output.height = float4(height01, height01, height01, height01);

                // UV duplicated into xyxy (Vertex_b1 lines 59-62) and instance id passthrough (line 63:
                // TEXCOORD_2 = gl_InstanceIndex - gl_BaseInstanceARB). Under UNITY_INSTANCING the local
                // instance id (unity_InstanceID) is exactly that base-relative index; 0 otherwise.
                output.uv = float4(input.uv.x, input.uv.y, input.uv.x, input.uv.y);
                #if defined(UNITY_INSTANCING_ENABLED) || defined(UNITY_PROCEDURAL_INSTANCING_ENABLED) || defined(UNITY_STEREO_INSTANCING_ENABLED)
                output.instanceIndex = unity_InstanceID;
                #else
                output.instanceIndex = 0u;
                #endif

                return output;
            }

            float4 frag(Varyings input) : SV_Target
            {
                // SV_Target = (height01, height01, 0, 1)  (Fragment_b2 lines 29-32).
                // Fragment input TEXCOORD1 (== input.height) carries the height.xxxx from the vertex;
                // input.uv (TEXCOORD2) and input.instanceIndex (TEXCOORD3) are passed through but
                // unused by the base fragment — kept to preserve the source interpolator layout 1:1.
                return float4(input.height.x, input.height.y, 0.0, 1.0);
            }
            ENDHLSL
        }
    }
}
