// HGRP Volumetric Local Fog — froxel-volume injection pass (single pass, vert+frag).
// Splats a proxy Box/Sphere fog volume into the camera-aligned exponential froxel LUT
// (a Texture3D array) that the volumetric-lighting integrator reads downstream. The vertex
// stage builds a screen-aligned slice quad from the volume's 8 object-space corners and routes
// it to one froxel depth-slice via SV_RenderTargetArrayIndex; the fragment stage reconstructs
// each froxel's object-space position, tests Box/Sphere containment, applies a near-camera fade,
// and writes the packed scattering/extinction/emissive volume format to two MRTs.
//
// Merged from: volumetriclocalfog/Sub0_Pass0_Vertex_b2 + Fragment_b3 (BOX, catch-all base),
//   Sub0_Pass0_Vertex_b4 + Fragment_b5 (SPHERE). Vertex b2==b4 bit-identical (shape only changes
//   the fragment containment test). BOX/INSTANCING b6/b7 + SPHERE/INSTANCING b8/b9 NOT merged
//   (SRP_INSTANCING dropped — see Removed).
// Keywords: _VOXELIZE_SHAPE_BOX, _VOXELIZE_SHAPE_SPHERE (KeywordEnum, mutually exclusive).
// Kept: 1:1 — slice-quad bounding-rect construction, exponential froxel slice depth decode,
//   view->volume-clip projection, froxel world/object-space reconstruction, Box(|p|<=0.5 AABB)
//   and Sphere(dot(p,p)<=0.25) containment, cubed near-camera fade, packed volume MRT layout
//   (RT0.rgb=scattering, RT0.w=absorption=extinction-luma(scattering), RT1.rgb=emissive).
// Removed: SRP per-instance draw array (INSTANCING_ON), SPIRV-Cross bitfield/SSA plumbing.
//
// NOTE: This is an SRP-INTERNAL voxelization entry point. URP has NO equivalent froxel-injection
//   stage, no "VolumerticFogVoxelization" LightMode, and does not provide the froxel constants
//   (_Globals_Voxelization* / the CB0 view-volume globals). They are kept as a documented external
//   cbuffer (HgFroxelGlobals / HgVoxelGlobals) that the driving render feature must bind — there is
//   no pixel-neutral URP global to map them to. The math inside is fully 1:1 (blob cites per block).
//   See gaps/TODO(1:1) for the plumbing that cannot be made URP-native in this pass.
//
// Packing note: the decompiler kept the symbol "_ViewMatrix" for the per-material float4x4 whose
//   row0=_Albedo.rgb, row1.x=_Extinction, row2.xyz=_Emissive.rgb. Re-exposed here as the clean
//   _Albedo/_Extinction/_Emissive material Properties (assembled into _MaterialPack at use site).

Shader "HGRP/VolumetricLocalFog_Fix" {
    Properties {
        [KeywordEnum(Box, Sphere)] _VOXELIZE_SHAPE ("Voxelize Shape", Float) = 0
        _Albedo ("Albedo", Color) = (1, 1, 1, 1)
        _Extinction ("Extinction", Range(0, 1)) = 0.5
        [HDR] _Emissive ("Emissive", Color) = (1, 1, 1, 1)
    }

    SubShader {
        Tags {
            "RenderPipeline" = "UniversalPipeline"
            "RenderType" = "Transparent"
            "Queue" = "Transparent"
        }
        LOD 100

        HLSLINCLUDE
        #include "Packages/com.unity.render-pipelines.universal/ShaderLibrary/Core.hlsl"

        // ---- Per-material constants (re-exposed from the decompiled "_ViewMatrix" pack) -----------
        CBUFFER_START(UnityPerMaterial)
            float4 _Albedo;       // .rgb scattering albedo (decompiled _ViewMatrix row0)
            float  _Extinction;   // sigma_t                (decompiled _ViewMatrix[1].x)
            float4 _Emissive;     // .rgb emissive          (decompiled _ViewMatrix row2.xyz)
        CBUFFER_END

        // BT.709 luma weights — decode of float3(0.21267290..f, 0.715152204..f, 0.072175003..f),
        // blob Fragment_b3:68 / Fragment_b5:68.
        static const float3 LUM = float3(0.2126729, 0.7151522, 0.0721750);

        // ---- HGRP froxel / voxelization globals (NO URP equivalent — bound by the render feature) -
        // Decompiled: cbuffer type_Globals (b2). Names verbatim from blob Vertex_b2:20-27.
        // TODO(1:1): URP exposes no froxel-injection globals; the driving ScriptableRenderFeature
        //   must populate this CBUFFER. vs blob Vertex_b2:20-27 / Fragment_b3:20-28.
        CBUFFER_START(HgVoxelGlobals)
            float    _VoxelizationPassIndex;              // blob Vertex_b2:22
            float    _VoxelizationClosestSliceIndex;      // blob Vertex_b2:23
            float2   _VoxelizationClipRatio;              // blob Vertex_b2:24
            float4   _VoxelizationFrameJitterOffset;      // blob Vertex_b2:25
            float4x4 _VoxelizationViewToVolumeClip;       // blob Vertex_b2:26 (column_major)
            float4x4 _VoxelizationWorldToObject;          // blob Fragment_b3:27 (column_major)
        CBUFFER_END

        // ---- HGRP view/volume global block (decompiled CB0UBO float4[166..167]) -------------------
        // The decompiled blob indexes a raw float4 array CB0_m0[] for: the volume's object->clip rows
        // [0..3], froxel-slice exp params [166] (vert) / [165] (frag near-fade), the volume-clip->world
        // inverse rows [24..27], and screen texel size [82].zw. These are HGRP ShaderVariablesGlobal /
        // per-volume push constants with NO URP analogue.
        // TODO(1:1): bind this raw block (or refactor the feature to named fields). Indices preserved
        //   1:1 from blob. vs blob Vertex_b2:10-13 + Fragment_b3:10-13.
        CBUFFER_START(HgFroxelGlobals)
            float4 _CB0[167];
        CBUFFER_END

        // _CB0 index aliases (kept 1:1 with the decompiled indices, named for readability) ----------
        #define VOL_OBJ2CLIP_R0   _CB0[0u]   // object->clip row0 (blob Vertex_b2:127)
        #define VOL_OBJ2CLIP_R1   _CB0[1u]   // object->clip row1
        #define VOL_OBJ2CLIP_R2   _CB0[2u]   // object->clip row2
        #define VOL_OBJ2CLIP_R3   _CB0[3u]   // object->clip row3 (translation)
        #define VOL_CLIP2WORLD_R0 _CB0[24u]  // volume-clip->world row0 (blob Fragment_b3:54)
        #define VOL_CLIP2WORLD_R1 _CB0[25u]  // volume-clip->world row1
        #define VOL_CLIP2WORLD_R2 _CB0[26u]  // volume-clip->world row2
        #define VOL_CLIP2WORLD_R3 _CB0[27u]  // volume-clip->world row3 (translation)
        #define VOL_SCREEN_TEXEL  _CB0[82u]  // .zw = 1/screenSize (blob Fragment_b3:50-51)
        #define VOL_SLICE_DECODE  _CB0[84u]  // .z=range .w=near for froxel linear-Z decode (blob Fragment_b3:52)
        #define VOL_NEAR_FADE     _CB0[165u] // .w = near-fade reference distance (blob Fragment_b3:60)
        #define VOL_SLICE_PARAMS  _CB0[166u] // .x=range .y=near .z=sliceCount (blob Vertex_b2:177)

        // Per-volume local->view basis. Decompiled as the global "_ViewMatrix"
        // (cbuffer type_ShaderVariablesGlobal, blob Vertex_b2:15-18) — the unit-volume's
        // local frame in view space. NO URP global maps to this (it is the volume's basis,
        // not the camera view matrix), so it is bound by the render feature alongside the
        // froxel globals.
        // TODO(1:1): render feature must bind this volume basis. vs blob Vertex_b2:15-18.
        CBUFFER_START(HgVoxelLocalBasis)
            float4x4 _VoxelizationLocalBasis;
        CBUFFER_END
        ENDHLSL

        Pass {
            // Name + LightMode kept VERBATIM from source (note the source's "Volumertic" misspelling,
            // m-e-r-t-i-c, NOT "Volumetric") — this string is the load-bearing dispatch key the driving
            // render feature must match exactly. vs source .shader:15,21.
            Name "VolumerticFogVoxelization"
            Tags { "LightMode" = "VolumerticFogVoxelization" } // TODO(1:1): no URP LightMode injects froxels; driven by a custom render feature. vs source .shader:21
            Blend One One, One One
            ZClip On
            ZWrite Off
            Cull Off

            HLSLPROGRAM
            #pragma target 5.0
            #pragma vertex vert
            #pragma fragment frag
            #pragma shader_feature_local _VOXELIZE_SHAPE_BOX
            #pragma shader_feature_local _VOXELIZE_SHAPE_SPHERE

            struct Attributes {
                uint vertexID : SV_VertexID;
            };

            struct Varyings {
                float  sliceDepth : TEXCOORD2;                  // view-space linear slice depth (blob Vertex_b2:179 TEXCOORD)
                float4 positionCS : SV_Position;
                uint   sliceLayer : SV_RenderTargetArrayIndex;  // froxel depth slice (blob Vertex_b2:176 gl_Layer)
            };

            // ============================================================
            // Vertex — build a screen-aligned slice quad from the volume's 8 object-space corners,
            //          route to one froxel slice. 1:1 from blob Vertex_b2:110-184 (== Vertex_b4).
            // ============================================================
            Varyings vert(Attributes input)
            {
                Varyings output = (Varyings)0;

                // Local axis half-vectors of the unit volume in its local->view frame. The blob reads
                // the global "_ViewMatrix" (cbuffer type_ShaderVariablesGlobal) which is the volume's
                // local basis, NOT the camera view matrix — so URP's UNITY_MATRIX_V does NOT apply here;
                // we mirror the blob matrix exactly via _VoxelizationLocalBasis. blob Vertex_b2:112-120.
                float4x4 V = _VoxelizationLocalBasis; // rows == blob _ViewMatrix[0..3]

                float yHX = -0.5f * V[1u].x;
                float yHY = -0.5f * V[1u].y;
                float yHZ = -0.5f * V[1u].z;                                  // blob Vertex_b2:112-114
                float xnX = mad(V[0u].x, -0.5f, yHX);
                float xnY = mad(V[0u].y, -0.5f, yHY);
                float xnZ = mad(V[0u].z, -0.5f, yHZ);                         // blob Vertex_b2:115-117
                float xpX = mad(V[0u].x, 0.5f, yHX);
                float xpY = mad(V[0u].y, 0.5f, yHY);
                float xpZ = mad(V[0u].z, 0.5f, yHZ);                          // blob Vertex_b2:118-120

                // Corner set A (y = -0.5): z = +0.5 and z = -0.5, both x = -0.5. blob Vertex_b2:121-126
                float c0X = mad(V[2u].x, 0.5f, xnX) + V[3u].x;
                float c0Y = mad(V[2u].y, 0.5f, xnY) + V[3u].y;
                float c0Z = mad(V[2u].z, 0.5f, xnZ) + V[3u].z;
                float c1X = mad(V[2u].x, -0.5f, xnX) + V[3u].x;
                float c1Y = mad(V[2u].y, -0.5f, xnY) + V[3u].y;
                float c1Z = mad(V[2u].z, -0.5f, xnZ) + V[3u].z;

                // Project corners c0 / c1 to clip XY through object->clip (CB0 rows 0..3). blob 127-136
                float c0CX = mad(VOL_OBJ2CLIP_R2.x, c0Z, mad(VOL_OBJ2CLIP_R0.x, c0X, c0Y * VOL_OBJ2CLIP_R1.x)) + VOL_OBJ2CLIP_R3.x;
                float c0CY = mad(VOL_OBJ2CLIP_R2.y, c0Z, mad(VOL_OBJ2CLIP_R0.y, c0X, c0Y * VOL_OBJ2CLIP_R1.y)) + VOL_OBJ2CLIP_R3.y;
                float c1CX = mad(VOL_OBJ2CLIP_R2.x, c1Z, mad(VOL_OBJ2CLIP_R0.x, c1X, c1Y * VOL_OBJ2CLIP_R1.x)) + VOL_OBJ2CLIP_R3.x;
                float c1CY = mad(VOL_OBJ2CLIP_R2.y, c1Z, mad(VOL_OBJ2CLIP_R0.y, c1X, c1Y * VOL_OBJ2CLIP_R1.y)) + VOL_OBJ2CLIP_R3.y;

                // Corner set B (y = -0.5, x = +0.5), z = +0.5 / -0.5. blob Vertex_b2:129-136
                float c2X = mad(V[2u].x, 0.5f, xpX) + V[3u].x;
                float c2Y = mad(V[2u].y, 0.5f, xpY) + V[3u].y;
                float c2Z = mad(V[2u].z, 0.5f, xpZ) + V[3u].z;
                float c3X = mad(V[2u].x, -0.5f, xpX) + V[3u].x;
                float c3Y = mad(V[2u].y, -0.5f, xpY) + V[3u].y;
                float c3Z = mad(V[2u].z, -0.5f, xpZ) + V[3u].z;
                float c2CX = mad(VOL_OBJ2CLIP_R2.x, c2Z, mad(VOL_OBJ2CLIP_R0.x, c2X, c2Y * VOL_OBJ2CLIP_R1.x)) + VOL_OBJ2CLIP_R3.x;
                float c2CY = mad(VOL_OBJ2CLIP_R2.y, c2Z, mad(VOL_OBJ2CLIP_R0.y, c2X, c2Y * VOL_OBJ2CLIP_R1.y)) + VOL_OBJ2CLIP_R3.y;
                float c3CX = mad(VOL_OBJ2CLIP_R2.x, c3Z, mad(VOL_OBJ2CLIP_R0.x, c3X, c3Y * VOL_OBJ2CLIP_R1.x)) + VOL_OBJ2CLIP_R3.x;
                float c3CY = mad(VOL_OBJ2CLIP_R2.y, c3Z, mad(VOL_OBJ2CLIP_R0.y, c3X, c3Y * VOL_OBJ2CLIP_R1.y)) + VOL_OBJ2CLIP_R3.y;

                // y = +0.5 corner family (mirror of the y = -0.5 family). blob Vertex_b2:137-169
                float yPX = 0.5f * V[1u].x;
                float yPY = 0.5f * V[1u].y;
                float yPZ = 0.5f * V[1u].z;                                   // blob Vertex_b2:137-139
                float xn2X = mad(V[0u].x, -0.5f, yPX);
                float xn2Y = mad(V[0u].y, -0.5f, yPY);
                float xn2Z = mad(V[0u].z, -0.5f, yPZ);                        // blob Vertex_b2:140-142
                float xp2X = mad(V[0u].x, 0.5f, yPX);
                float xp2Y = mad(V[0u].y, 0.5f, yPY);
                float xp2Z = mad(V[0u].z, 0.5f, yPZ);                         // blob Vertex_b2:143-145

                float c4X = mad(V[2u].x, 0.5f, xn2X) + V[3u].x;
                float c4Y = mad(V[2u].y, 0.5f, xn2Y) + V[3u].y;
                float c4Z = mad(V[2u].z, 0.5f, xn2Z) + V[3u].z;
                float c5X = mad(V[2u].x, -0.5f, xn2X) + V[3u].x;
                float c5Y = mad(V[2u].y, -0.5f, xn2Y) + V[3u].y;
                float c5Z = mad(V[2u].z, -0.5f, xn2Z) + V[3u].z;              // blob Vertex_b2:146-151
                float c4CX = mad(VOL_OBJ2CLIP_R2.x, c4Z, mad(VOL_OBJ2CLIP_R0.x, c4X, c4Y * VOL_OBJ2CLIP_R1.x)) + VOL_OBJ2CLIP_R3.x;
                float c4CY = mad(VOL_OBJ2CLIP_R2.y, c4Z, mad(VOL_OBJ2CLIP_R0.y, c4X, c4Y * VOL_OBJ2CLIP_R1.y)) + VOL_OBJ2CLIP_R3.y;
                float c5CX = mad(VOL_OBJ2CLIP_R2.x, c5Z, mad(VOL_OBJ2CLIP_R0.x, c5X, c5Y * VOL_OBJ2CLIP_R1.x)) + VOL_OBJ2CLIP_R3.x;
                float c5CY = mad(VOL_OBJ2CLIP_R2.y, c5Z, mad(VOL_OBJ2CLIP_R0.y, c5X, c5Y * VOL_OBJ2CLIP_R1.y)) + VOL_OBJ2CLIP_R3.y;

                float c6X = mad(V[2u].x, 0.5f, xp2X) + V[3u].x;
                float c6Y = mad(V[2u].y, 0.5f, xp2Y) + V[3u].y;
                float c6Z = mad(V[2u].z, 0.5f, xp2Z) + V[3u].z;
                float c7X = mad(V[2u].x, -0.5f, xp2X) + V[3u].x;
                float c7Y = mad(V[2u].y, -0.5f, xp2Y) + V[3u].y;
                float c7Z = mad(V[2u].z, -0.5f, xp2Z) + V[3u].z;              // blob Vertex_b2:154-159
                float c6CX = mad(VOL_OBJ2CLIP_R2.x, c6Z, mad(VOL_OBJ2CLIP_R0.x, c6X, c6Y * VOL_OBJ2CLIP_R1.x)) + VOL_OBJ2CLIP_R3.x;
                float c6CY = mad(VOL_OBJ2CLIP_R2.y, c6Z, mad(VOL_OBJ2CLIP_R0.y, c6X, c6Y * VOL_OBJ2CLIP_R1.y)) + VOL_OBJ2CLIP_R3.y;
                float c7CX = mad(VOL_OBJ2CLIP_R2.x, c7Z, mad(VOL_OBJ2CLIP_R0.x, c7X, c7Y * VOL_OBJ2CLIP_R1.x)) + VOL_OBJ2CLIP_R3.x;
                float c7CY = mad(VOL_OBJ2CLIP_R2.y, c7Z, mad(VOL_OBJ2CLIP_R0.y, c7X, c7Y * VOL_OBJ2CLIP_R1.y)) + VOL_OBJ2CLIP_R3.y;

                // Bounding rectangle of all 8 projected corners (10000000 clamp = +inf guard).
                // blob Vertex_b2:170-171 (min) and the max half built into 463/464 (172-174).
                float minX = min(min(min(c5CX, min(c4CX, min(min(min(min(c0CX, 10000000.0f), c1CX), c2CX), c3CX))), c6CX), c7CX);
                float minY = min(min(min(c5CY, min(c4CY, min(min(min(min(c0CY, 10000000.0f), c1CY), c2CY), c3CY))), c6CY), c7CY);
                float maxX = max(max(max(c5CX, max(c4CX, max(max(max(max(c0CX, -10000000.0f), c1CX), c2CX), c3CX))), c6CX), c7CX);
                float maxY = max(max(max(c5CY, max(c4CY, max(max(max(max(c0CY, -10000000.0f), c1CY), c2CY), c3CY))), c6CY), c7CY);

                // Select this quad corner by vertexID bits: x = bit0, y = bit1. blob Vertex_b2:172-174.
                uint  vid    = input.vertexID; // (blob subtracts gl_BaseVertexARB == 0 here)
                float selX   = float(vid & 1u);
                float selY   = float((vid >> 1u) & 1u);
                float quadX  = mad((maxX - minX), selX, minX); // blob Vertex_b2:173
                float quadY  = mad((maxY - minY), selY, minY); // blob Vertex_b2:174

                // Froxel slice index + exponential slice depth decode. blob Vertex_b2:175-179.
                float sliceF = _VoxelizationPassIndex + _VoxelizationClosestSliceIndex;
                output.sliceLayer = uint(int(sliceF));
                float sliceDepth = (exp2((trunc(sliceF) + _VoxelizationFrameJitterOffset.z) / VOL_SLICE_PARAMS.z)
                                    - VOL_SLICE_PARAMS.y) / VOL_SLICE_PARAMS.x;
                float negDepth   = -sliceDepth;
                output.sliceDepth = sliceDepth;

                // View(volume) -> volume-clip. blob Vertex_b2:180-183.
                output.positionCS.x = mad(_VoxelizationViewToVolumeClip[2u].x, negDepth, mad(_VoxelizationViewToVolumeClip[0u].x, quadX, quadY * _VoxelizationViewToVolumeClip[1u].x)) + _VoxelizationViewToVolumeClip[3u].x;
                output.positionCS.y = mad(_VoxelizationViewToVolumeClip[2u].y, negDepth, mad(_VoxelizationViewToVolumeClip[0u].y, quadX, quadY * _VoxelizationViewToVolumeClip[1u].y)) + _VoxelizationViewToVolumeClip[3u].y;
                output.positionCS.z = mad(_VoxelizationViewToVolumeClip[2u].z, negDepth, mad(_VoxelizationViewToVolumeClip[0u].z, quadX, quadY * _VoxelizationViewToVolumeClip[1u].z)) + _VoxelizationViewToVolumeClip[3u].z;
                output.positionCS.w = mad(_VoxelizationViewToVolumeClip[2u].w, negDepth, mad(_VoxelizationViewToVolumeClip[0u].w, quadX, quadY * _VoxelizationViewToVolumeClip[1u].w)) + _VoxelizationViewToVolumeClip[3u].w;

                return output;
            }

            struct FragOutput {
                float4 scatterExtinction : SV_Target0; // RGB scattering, A absorption (blob Fragment_b3:65-68)
                float4 emissive          : SV_Target1; // RGB emissive             (blob Fragment_b3:69-72)
            };

            // ============================================================
            // Fragment — reconstruct froxel object-space position, test containment, near-fade,
            //            write packed volume format. 1:1 from blob Fragment_b3:48-72 (BOX) /
            //            Fragment_b5:48-72 (SPHERE).
            // ============================================================
            FragOutput frag(Varyings input)
            {
                FragOutput o;

                // Near-fade depth term. The blob's main() does gl_FragCoord.w = 1/gl_FragCoord.w
                // (blob Fragment_b3:78), then frag line 60 takes 1/gl_FragCoord.w again — the two
                // reciprocals cancel, so the net value is the hardware-delivered SV_Position.w
                // (== 1/clipW). That is exactly input.positionCS.w here. 1:1, no extra reciprocal.
                float depthTerm = input.positionCS.w;

                // NDC from froxel pixel coord. blob Fragment_b3:50-51 (note y is negated).
                float ndcX = mad((input.positionCS.x * _VoxelizationClipRatio.x) * VOL_SCREEN_TEXEL.z, 2.0f, -1.0f);
                float ndcY = -mad((input.positionCS.y * _VoxelizationClipRatio.y) * VOL_SCREEN_TEXEL.w, 2.0f, -1.0f);

                // Linear-Z of the slice -> volume-clip Z. blob Fragment_b3:52.
                float clipZ = ((1.0f / input.sliceDepth) - VOL_SLICE_DECODE.w) / VOL_SLICE_DECODE.z;

                // Volume-clip -> world (homogeneous divide by w). blob Fragment_b3:53-56.
                float invWld = mad(VOL_CLIP2WORLD_R2.w, clipZ, mad(VOL_CLIP2WORLD_R0.w, ndcX, ndcY * VOL_CLIP2WORLD_R1.w)) + VOL_CLIP2WORLD_R3.w;
                float wX = (mad(VOL_CLIP2WORLD_R2.x, clipZ, mad(VOL_CLIP2WORLD_R0.x, ndcX, ndcY * VOL_CLIP2WORLD_R1.x)) + VOL_CLIP2WORLD_R3.x) / invWld;
                float wY = (mad(VOL_CLIP2WORLD_R2.y, clipZ, mad(VOL_CLIP2WORLD_R0.y, ndcX, ndcY * VOL_CLIP2WORLD_R1.y)) + VOL_CLIP2WORLD_R3.y) / invWld;
                float wZ = (mad(VOL_CLIP2WORLD_R2.z, clipZ, mad(VOL_CLIP2WORLD_R0.z, ndcX, ndcY * VOL_CLIP2WORLD_R1.z)) + VOL_CLIP2WORLD_R3.z) / invWld;

                // World -> object space (the unit-volume frame). blob Fragment_b3:57-59.
                float oX = mad(_VoxelizationWorldToObject[2u].x, wZ, mad(_VoxelizationWorldToObject[0u].x, wX, wY * _VoxelizationWorldToObject[1u].x)) + _VoxelizationWorldToObject[3u].x;
                float oY = mad(_VoxelizationWorldToObject[2u].y, wZ, mad(_VoxelizationWorldToObject[0u].y, wX, wY * _VoxelizationWorldToObject[1u].y)) + _VoxelizationWorldToObject[3u].y;
                float oZ = mad(_VoxelizationWorldToObject[2u].z, wZ, mad(_VoxelizationWorldToObject[0u].z, wX, wY * _VoxelizationWorldToObject[1u].z)) + _VoxelizationWorldToObject[3u].z;

                // Near-camera fade, cubed. blob Fragment_b3:60 / Fragment_b5:60.
                // fade = 1 - clamp(((1/clipW) / nearFadeRef - 0.6) * 2.5, 0, 1)
                float fade  = 1.0f - clamp(((depthTerm / VOL_NEAR_FADE.w) - 0.6f) * 2.5f, 0.0f, 1.0f);
                float fade3 = fade * fade * fade;

                // Containment coverage -> coverage * fade^3.
                float coverage;
            #if defined(_VOXELIZE_SHAPE_SPHERE)
                // Sphere: dot(p,p) <= 0.25 (radius 0.5). blob Fragment_b5:61.
                // asfloat((inside ? 0xffffffff : 0) & asuint(1.0)) = inside ? 1.0 : 0.0.
                bool insideSphere = (0.25f >= dot(float3(oX, oY, oZ), float3(oX, oY, oZ)));
                coverage = (insideSphere ? 1.0f : 0.0f) * fade3;
            #else
                // Box: reject if any |axis| > 0.5 (unit AABB). blob Fragment_b3:61.
                // asfloat(anyOutside ? 0u : asuint(fade^3)) = anyOutside ? 0.0 : fade^3.
                bool outside = (0.5f < oZ) || (oZ < -0.5f)
                            || (0.5f < oY) || (oY < -0.5f)
                            || (0.5f < oX) || (oX < -0.5f);
                coverage = outside ? 0.0f : fade3;
            #endif

                // Packed volume format. The decompiled "_ViewMatrix" here is the per-material pack:
                //   row0 = _Albedo.rgb (scattering albedo), row1.x = _Extinction, row2.xyz = _Emissive.
                // scattering = albedo * extinction. blob Fragment_b3:62-67.
                float3 scattering = _Albedo.rgb * _Extinction;
                o.scatterExtinction.xyz = coverage * scattering;

                // absorption = extinction - luma(scattering), clamped >= 0. blob Fragment_b3:68.
                o.scatterExtinction.w = coverage * max(-dot(scattering, LUM) + _Extinction, 0.0f);

                // emissive (RT1.rgb), RT1.w = 0. blob Fragment_b3:69-72.
                o.emissive.xyz = coverage * _Emissive.xyz;
                o.emissive.w   = 0.0f;

                return o;
            }
            ENDHLSL
        }
    }
}
