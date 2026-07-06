using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using IFix.Core;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGTerrainRenderer : IDisposable
	{
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x00002C50 File Offset: 0x00000E50
		private HGTerrainRuntimeResources.ChunkData chunkData
		{
			get
			{
				// // HGTerrainRuntimeResources+ChunkData get_chunkData()
				// HGTerrainRuntimeResources_ChunkData *HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(
				//         HGTerrainRuntimeResources_ChunkData *__return_ptr retstr,
				//         HGTerrainRenderer *this,
				//         MethodInfo *method)
				// {
				//   HGTerrainRuntimeResources *m_runtimeResources; // rax
				//   __int128 v4; // xmm1
				//   __int128 v5; // xmm0
				//   HGTerrainRuntimeResources_ChunkData *result; // rax
				// 
				//   m_runtimeResources = this.fields.m_runtimeResources;
				//   if ( !m_runtimeResources )
				//     sub_180B536AC(retstr, this);
				//   v4 = *(_OWORD *)&m_runtimeResources.fields.chunkData.centerZs;
				//   *(_OWORD *)&retstr.centerXs = *(_OWORD *)&m_runtimeResources.fields.chunkData.centerXs;
				//   v5 = *(_OWORD *)&m_runtimeResources.fields.chunkData.extentYs;
				//   *(_OWORD *)&retstr.centerZs = v4;
				//   *(_QWORD *)&v4 = m_runtimeResources.fields.chunkData.chunkLevel;
				//   result = retstr;
				//   *(_OWORD *)&retstr.extentYs = v5;
				//   retstr.chunkLevel = (Int32__Array *)v4;
				//   return result;
				// }
				// 
				return default(HGTerrainRuntimeResources.ChunkData);
			}
		}

		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x000025D2 File Offset: 0x000007D2
		private Mesh chunkMesh
		{
			get
			{
				// // Mesh get_chunkMesh()
				// Mesh *HG::Rendering::Runtime::HGTerrainRenderer::get_chunkMesh(HGTerrainRenderer *this, MethodInfo *method)
				// {
				//   HGTerrainRuntimeResources *m_runtimeResources; // rax
				//   HGTerrainRuntimeResources_MeshResources *meshes; // rax
				// 
				//   m_runtimeResources = this.fields.m_runtimeResources;
				//   if ( !m_runtimeResources || (meshes = m_runtimeResources.fields.meshes) == 0LL )
				//     sub_180B536AC(this, method);
				//   return meshes.fields.chunkMesh;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x000025D2 File Offset: 0x000007D2
		private int[] packedSignificantLayerInfo
		{
			get
			{
				// // Int32[] get_packedSignificantLayerInfo()
				// Int32__Array *HG::Rendering::Runtime::HGTerrainRenderer::get_packedSignificantLayerInfo(
				//         HGTerrainRenderer *this,
				//         MethodInfo *method)
				// {
				//   HGTerrainRuntimeResources *m_runtimeResources; // rax
				// 
				//   m_runtimeResources = this.fields.m_runtimeResources;
				//   if ( !m_runtimeResources )
				//     sub_180B536AC(this, method);
				//   return m_runtimeResources.fields.terrainLayerData.packedSignificantLayerInfo;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x000025D2 File Offset: 0x000007D2
		private NativeArray<float> centerXs
		{
			[CompilerGenerated]
			get
			{
				// // ValueTuple`2[Boolean,Object] get_ResultOnSuccess()
				// ValueTuple_2_Boolean_Object_ *System::Threading::Tasks::Task<System::ValueTuple<bool,System::Object>>::get_ResultOnSuccess(
				//         ValueTuple_2_Boolean_Object_ *__return_ptr retstr,
				//         Task_1_System_ValueTuple_2_Boolean_Object_ *this,
				//         MethodInfo *method)
				// {
				//   ValueTuple_2_Boolean_Object_ *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.m_result;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x060015B4 RID: 5556 RVA: 0x000025D2 File Offset: 0x000007D2
		private NativeArray<float> centerYs
		{
			[CompilerGenerated]
			get
			{
				// // Vector4 get_ChannelB()
				// Vector4 *PaintIn3D::P3dPaintReplaceChannels::get_ChannelB(
				//         Vector4 *__return_ptr retstr,
				//         P3dPaintReplaceChannels *this,
				//         MethodInfo *method)
				// {
				//   Vector4 *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.channelB;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x000025D2 File Offset: 0x000007D2
		private NativeArray<float> centerZs
		{
			[CompilerGenerated]
			get
			{
				// // Playable get_playable()
				// Playable *UnityEngine::Timeline::RuntimeClip::get_playable(
				//         Playable *__return_ptr retstr,
				//         RuntimeClip *this,
				//         MethodInfo *method)
				// {
				//   Playable *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.m_Playable;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x060015B6 RID: 5558 RVA: 0x000025D2 File Offset: 0x000007D2
		private NativeArray<float> extentXs
		{
			[CompilerGenerated]
			get
			{
				// // AnimationClipPlayable get_playable()
				// AnimationClipPlayable *Beyond::Playables::SingleMixerAssetPlayer_4_TAsset_TAssetPlayable_TMixer_TOutput_::PlayableNode<System::Object,UnityEngine::Animations::AnimationClipPlayable,UnityEngine::Animations::AnimationMixerPlayable,UnityEngine::Animations::AnimationPlayableOutput>::get_playable(
				//         AnimationClipPlayable *__return_ptr retstr,
				//         SingleMixerAssetPlayer_4_TAsset_TAssetPlayable_TMixer_TOutput_PlayableNode_System_Object_UnityEngine_Animations_AnimationClipPlayable_UnityEngine_Animations_AnimationMixerPlayable_UnityEngine_Animations_AnimationPlayableOutput_ *this,
				//         MethodInfo *method)
				// {
				//   AnimationClipPlayable *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields._playable_k__BackingField;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x060015B7 RID: 5559 RVA: 0x000025D2 File Offset: 0x000007D2
		private NativeArray<float> extentYs
		{
			[CompilerGenerated]
			get
			{
				// // NpcProxyOverrideEnvTalk+EnvTalkStruct get_value()
				// NpcProxyOverrideEnvTalk_EnvTalkStruct *Beyond::Gameplay::ParamVariable<Beyond::Gameplay::Actions::NpcProxyOverrideEnvTalk::EnvTalkStruct>::get_value(
				//         NpcProxyOverrideEnvTalk_EnvTalkStruct *__return_ptr retstr,
				//         ParamVariable_1_Beyond_Gameplay_Actions_NpcProxyOverrideEnvTalk_EnvTalkStruct_ *this,
				//         MethodInfo *method)
				// {
				//   NpcProxyOverrideEnvTalk_EnvTalkStruct *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this.fields.m_value;
				//   return result;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x000025D2 File Offset: 0x000007D2
		private NativeArray<float> extentZs
		{
			[CompilerGenerated]
			get
			{
				// // FloatProperty get_jobWeight()
				// FloatProperty *UnityEngine::Animations::Rigging::TwoBoneIKConstraintJob::get_jobWeight(
				//         FloatProperty *__return_ptr retstr,
				//         TwoBoneIKConstraintJob *this,
				//         MethodInfo *method)
				// {
				//   FloatProperty *result; // rax
				// 
				//   result = retstr;
				//   *retstr = this._jobWeight_k__BackingField;
				//   return result;
				// }
				// 
				return null;
			}
		}

		public HGTerrainRenderer(TerrainResource terrainResource)
		{
			// // HGTerrainRenderer(TerrainResource)
			// void HG::Rendering::Runtime::HGTerrainRenderer::HGTerrainRenderer(
			//         HGTerrainRenderer *this,
			//         TerrainResource *terrainResource,
			//         MethodInfo *method)
			// {
			//   VirtualTextureRenderer *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   VirtualTextureRenderer *v8; // rsi
			//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   HGCamera *v11; // r9
			//   __int128 v12; // xmm2
			//   Texture2DArray *decalNormalMROTexArray; // xmm1_8
			//   HGRenderPathBase_HGRenderPathResources *v14; // rdx
			//   PassConstructorID__Enum__Array *v15; // r8
			//   HGCamera *v16; // r9
			//   Texture2DArray *v17; // xmm1_8
			//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
			//   PassConstructorID__Enum__Array *v19; // r8
			//   HGCamera *v20; // r9
			//   HGTerrainConfiguration *m_configuration; // rax
			//   HGTerrainRuntimeResources *m_runtimeResources; // rax
			//   HGTerrainRuntimeResources_ChunkData *chunkData; // rax
			//   __int128 v24; // xmm1
			//   Int32__Array *chunkLevel; // xmm0_8
			//   Single__Array *centerXs; // rax
			//   __int64 size; // rsi
			//   HGTerrainRuntimeResources_ChunkData *v28; // rax
			//   UInt32__Array *v29; // rdx
			//   __int128 v30; // xmm1
			//   Int32__Array *v31; // xmm0_8
			//   HGTerrainRuntimeResources_ChunkData *v32; // rax
			//   UInt32__Array *centerYs; // rdx
			//   __int128 v34; // xmm1
			//   Int32__Array *v35; // xmm0_8
			//   HGTerrainRuntimeResources_ChunkData *v36; // rax
			//   UInt32__Array *centerZs; // rdx
			//   __int128 v38; // xmm0
			//   HGTerrainRuntimeResources_ChunkData *v39; // rax
			//   UInt32__Array *extentXs; // rdx
			//   __int128 v41; // xmm0
			//   HGTerrainRuntimeResources_ChunkData *v42; // rax
			//   UInt32__Array *extentYs; // rdx
			//   __int128 v44; // xmm1
			//   HGTerrainRuntimeResources_ChunkData *v45; // rax
			//   UInt32__Array *extentZs; // rdx
			//   __int128 v47; // xmm1
			//   __int64 v48; // r8
			//   __int64 v49; // r9
			//   HGRenderPathBase_HGRenderPathResources *v50; // rdx
			//   PassConstructorID__Enum__Array *v51; // r8
			//   HGCamera *v52; // r9
			//   int32_t v53; // ebx
			//   __int64 v54; // r13
			//   __int64 v55; // rsi
			//   HGTerrainRuntimeResources_ChunkData *v56; // rax
			//   MethodInfo *v57; // r9
			//   __int128 v58; // xmm0
			//   Int32__Array *v59; // xmm1_8
			//   __int128 v60; // xmm0
			//   int32_t v61; // r15d
			//   __int16 v62; // r14
			//   float v63; // xmm6_4
			//   float v64; // r10d
			//   unsigned __int64 v65; // xmm0_8
			//   Vector3 *v66; // rax
			//   __int64 v67; // xmm5_8
			//   float v68; // r10d
			//   __int64 v69; // xmm3_8
			//   __int64 v70; // xmm4_8
			//   MethodInfo *v71; // r9
			//   Vector3 *v72; // rax
			//   __int64 v73; // r8
			//   __int64 v74; // r9
			//   HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // r12
			//   __int64 v76; // xmm3_8
			//   int v77; // eax
			//   __int64 v78; // rax
			//   HGCamera *v79; // r9
			//   Mesh *chunkMesh; // rax
			//   __int64 v81; // rdx
			//   __int64 v82; // rcx
			//   __int64 v83; // r8
			//   __int64 v84; // r9
			//   double v85; // xmm0_8
			//   __int64 v86; // r8
			//   __int64 v87; // rax
			//   __int64 v88; // r8
			//   __int64 v89; // r9
			//   Vector3__Array *v90; // r14
			//   Vector3__Array *v91; // r15
			//   __int64 v92; // r8
			//   __int64 v93; // r9
			//   Vector2__Array *v94; // r12
			//   __int64 v95; // r8
			//   __int64 v96; // r9
			//   UInt16__Array *v97; // rbx
			//   int32_t v98; // esi
			//   float v99; // xmm7_4
			//   float v100; // xmm6_4
			//   __int64 v101; // rax
			//   int32_t v102; // r9d
			//   int v103; // r8d
			//   __int64 v104; // r10
			//   int32_t v105; // r9d
			//   int v106; // eax
			//   __int64 v107; // r10
			//   int32_t v108; // r9d
			//   unsigned int v109; // r10d
			//   __int64 v110; // rax
			//   Mesh *v111; // rax
			//   Object_1 *v112; // rsi
			//   HGRenderPathBase_HGRenderPathResources *v113; // rdx
			//   PassConstructorID__Enum__Array *v114; // r8
			//   HGCamera *v115; // r9
			//   HGTerrainRuntimeResources *v116; // rbx
			//   Object_1 *terrainLitMaterial; // rbx
			//   bool v118; // al
			//   PassConstructorID__Enum__Array *v119; // r8
			//   HGCamera *v120; // r9
			//   __int64 v121; // rax
			//   Shader *v122; // rsi
			//   Material *v123; // rax
			//   Material *v124; // rbx
			//   HGTerrainRuntimeResources_ShaderResources *shaders; // rdx
			//   __int64 v126; // rcx
			//   HGTerrainRuntimeResources *v127; // r9
			//   Shader *terrainLitPS; // rdx
			//   __int64 v129; // xmm1_8
			//   HGRenderPathBase_HGRenderPathResources *v130; // rdx
			//   PassConstructorID__Enum__Array *v131; // r8
			//   HGCamera *v132; // r9
			//   Dictionary_2_System_Int32_Unity_Collections_NativeList_1_System_ValueTuple_2_Int32_Single_ *v133; // rax
			//   Dictionary_2_System_Int32_Unity_Collections_NativeList_1_System_ValueTuple_2_Int32_Single_ *v134; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v135; // rdx
			//   PassConstructorID__Enum__Array *v136; // r8
			//   HGCamera *v137; // r9
			//   Dictionary_2_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_ *v138; // rax
			//   Dictionary_2_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_ *v139; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v140; // rdx
			//   PassConstructorID__Enum__Array *v141; // r8
			//   HGCamera *v142; // r9
			//   MaterialPropertyBlock *v143; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v144; // rdx
			//   PassConstructorID__Enum__Array *v145; // r8
			//   HGCamera *v146; // r9
			//   MethodInfo *calculateBounds; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *calculateBoundsh; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *calculateBoundsi; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *calculateBoundsa; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *calculateBoundsb; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *calculateBoundsj; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *calculateBoundsc; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *calculateBoundsd; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *calculateBoundse; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *calculateBoundsf; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *calculateBoundsg; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *baseVertex; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *baseVertexh; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *baseVertexi; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *baseVertexa; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *baseVertexb; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *baseVertexj; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *baseVertexc; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *baseVertexd; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *baseVertexe; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *baseVertexf; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *baseVertexg; // [rsp+30h] [rbp-D8h]
			//   LocalKeyword v169; // [rsp+48h] [rbp-C0h] BYREF
			//   __int128 v170; // [rsp+68h] [rbp-A0h] BYREF
			//   __int128 v171; // [rsp+78h] [rbp-90h]
			//   __int128 v172; // [rsp+88h] [rbp-80h]
			//   Int32__Array *v173; // [rsp+98h] [rbp-70h]
			//   float z; // [rsp+A8h] [rbp-60h]
			//   __int128 v175; // [rsp+B0h] [rbp-58h]
			//   __int128 v176; // [rsp+C0h] [rbp-48h] BYREF
			//   __int64 v177; // [rsp+D0h] [rbp-38h]
			//   Vector3 v178; // [rsp+D8h] [rbp-30h] BYREF
			//   Vector3 v179; // [rsp+E8h] [rbp-20h] BYREF
			//   Vector3 v180; // [rsp+F8h] [rbp-10h] BYREF
			//   Vector3 v181; // [rsp+108h] [rbp+0h] BYREF
			//   __int64 v182; // [rsp+118h] [rbp+10h]
			//   __int64 v183; // [rsp+128h] [rbp+20h]
			//   HGTerrainRuntimeResources_ChunkData v184; // [rsp+138h] [rbp+30h] BYREF
			//   Vector3 v185; // [rsp+170h] [rbp+68h] BYREF
			//   Vector3 v186[4]; // [rsp+180h] [rbp+78h] BYREF
			//   float v187; // [rsp+200h] [rbp+F8h]
			// 
			//   if ( !byte_18D919703 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::Dictionary);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::Dictionary);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>);
			//     sub_18003C530(&TypeInfo::System::Int16);
			//     sub_18003C530(&TypeInfo::UnityEngine::MaterialPropertyBlock);
			//     sub_18003C530(&TypeInfo::UnityEngine::Material);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mesh);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::System::UInt16);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector2);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VirtualTextureRenderer);
			//     sub_18003C530(&off_18D515C70);
			//     sub_18003C530(&off_18D515C38);
			//     byte_18D919703 = 1;
			//   }
			//   v175 = 0LL;
			//   v177 = 0LL;
			//   v176 = 0LL;
			//   v5 = (VirtualTextureRenderer *)sub_180004920(TypeInfo::HG::Rendering::Runtime::VirtualTextureRenderer);
			//   v8 = v5;
			//   if ( !v5 )
			//     goto LABEL_64;
			//   HG::Rendering::Runtime::VirtualTextureRenderer::VirtualTextureRenderer(v5, terrainResource, 0LL);
			//   this.fields.m_vtRenderer = v8;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields, v9, v10, v11, calculateBounds, baseVertex);
			//   v12 = *(_OWORD *)&terrainResource.runtimeResources;
			//   decalNormalMROTexArray = terrainResource.decalNormalMROTexArray;
			//   v171 = *(_OWORD *)&terrainResource.terrainCollider;
			//   this.fields.m_runtimeResources = (HGTerrainRuntimeResources *)v12;
			//   *(_QWORD *)&v172 = decalNormalMROTexArray;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_runtimeResources, v14, v15, v16, calculateBoundsh, baseVertexh);
			//   v17 = terrainResource.decalNormalMROTexArray;
			//   v171 = *(_OWORD *)&terrainResource.terrainCollider;
			//   *(_QWORD *)&v172 = v17;
			//   this.fields.m_configuration = terrainResource.configuration;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_configuration, v18, v19, v20, calculateBoundsi, baseVertexi);
			//   m_configuration = this.fields.m_configuration;
			//   if ( !m_configuration )
			//     goto LABEL_64;
			//   this.fields.m_geometryError = m_configuration.fields.chunkedLodGeometryError;
			//   m_runtimeResources = this.fields.m_runtimeResources;
			//   if ( !m_runtimeResources )
			//     goto LABEL_64;
			//   this.fields.m_treeDepth = m_runtimeResources.fields.chunkTreeDepth;
			//   chunkData = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(&v184, this, 0LL);
			//   v24 = *(_OWORD *)&chunkData.extentYs;
			//   v171 = *(_OWORD *)&chunkData.centerZs;
			//   chunkLevel = chunkData.chunkLevel;
			//   centerXs = chunkData.centerXs;
			//   v173 = chunkLevel;
			//   v172 = v24;
			//   if ( !centerXs )
			//     goto LABEL_64;
			//   size = centerXs.max_length.size;
			//   v28 = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(&v184, this, 0LL);
			//   v29 = (UInt32__Array *)v28.centerXs;
			//   v30 = *(_OWORD *)&v28.extentYs;
			//   v171 = *(_OWORD *)&v28.centerZs;
			//   v31 = v28.chunkLevel;
			//   v172 = v30;
			//   v173 = v31;
			//   *(_OWORD *)&v169.m_SpaceInfo.m_KeywordSpace = 0LL;
			//   Unity::Collections::NativeArray<unsigned int>::NativeArray(
			//     (NativeArray_1_System_UInt32_ *)&v169,
			//     v29,
			//     Allocator__Enum_Persistent,
			//     MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
			//   this.fields._centerXs_k__BackingField = *(NativeArray_1_System_Single_ *)&v169.m_SpaceInfo.m_KeywordSpace;
			//   v32 = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(&v184, this, 0LL);
			//   centerYs = (UInt32__Array *)v32.centerYs;
			//   v34 = *(_OWORD *)&v32.extentYs;
			//   v171 = *(_OWORD *)&v32.centerZs;
			//   v35 = v32.chunkLevel;
			//   v172 = v34;
			//   v173 = v35;
			//   *(_OWORD *)&v169.m_SpaceInfo.m_KeywordSpace = 0LL;
			//   Unity::Collections::NativeArray<unsigned int>::NativeArray(
			//     (NativeArray_1_System_UInt32_ *)&v169,
			//     centerYs,
			//     Allocator__Enum_Persistent,
			//     MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
			//   this.fields._centerYs_k__BackingField = *(NativeArray_1_System_Single_ *)&v169.m_SpaceInfo.m_KeywordSpace;
			//   v36 = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(&v184, this, 0LL);
			//   centerZs = (UInt32__Array *)v36.centerZs;
			//   *(_QWORD *)&v34 = v36.chunkLevel;
			//   v170 = *(_OWORD *)&v36.centerXs;
			//   v38 = *(_OWORD *)&v36.extentYs;
			//   v173 = (Int32__Array *)v34;
			//   v172 = v38;
			//   *(_OWORD *)&v169.m_SpaceInfo.m_KeywordSpace = 0LL;
			//   Unity::Collections::NativeArray<unsigned int>::NativeArray(
			//     (NativeArray_1_System_UInt32_ *)&v169,
			//     centerZs,
			//     Allocator__Enum_Persistent,
			//     MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
			//   this.fields._centerZs_k__BackingField = *(NativeArray_1_System_Single_ *)&v169.m_SpaceInfo.m_KeywordSpace;
			//   v39 = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(&v184, this, 0LL);
			//   extentXs = (UInt32__Array *)v39.extentXs;
			//   *(_QWORD *)&v34 = v39.chunkLevel;
			//   v170 = *(_OWORD *)&v39.centerXs;
			//   v41 = *(_OWORD *)&v39.extentYs;
			//   v173 = (Int32__Array *)v34;
			//   v172 = v41;
			//   *(_OWORD *)&v169.m_SpaceInfo.m_KeywordSpace = 0LL;
			//   Unity::Collections::NativeArray<unsigned int>::NativeArray(
			//     (NativeArray_1_System_UInt32_ *)&v169,
			//     extentXs,
			//     Allocator__Enum_Persistent,
			//     MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
			//   this.fields._extentXs_k__BackingField = *(NativeArray_1_System_Single_ *)&v169.m_SpaceInfo.m_KeywordSpace;
			//   v42 = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(&v184, this, 0LL);
			//   extentYs = (UInt32__Array *)v42.extentYs;
			//   v44 = *(_OWORD *)&v42.centerZs;
			//   v170 = *(_OWORD *)&v42.centerXs;
			//   *(_QWORD *)&v41 = v42.chunkLevel;
			//   v171 = v44;
			//   v173 = (Int32__Array *)v41;
			//   *(_OWORD *)&v169.m_SpaceInfo.m_KeywordSpace = 0LL;
			//   Unity::Collections::NativeArray<unsigned int>::NativeArray(
			//     (NativeArray_1_System_UInt32_ *)&v169,
			//     extentYs,
			//     Allocator__Enum_Persistent,
			//     MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
			//   this.fields._extentYs_k__BackingField = *(NativeArray_1_System_Single_ *)&v169.m_SpaceInfo.m_KeywordSpace;
			//   v45 = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(&v184, this, 0LL);
			//   extentZs = (UInt32__Array *)v45.extentZs;
			//   v47 = *(_OWORD *)&v45.centerZs;
			//   v170 = *(_OWORD *)&v45.centerXs;
			//   *(_QWORD *)&v41 = v45.chunkLevel;
			//   v171 = v47;
			//   v173 = (Int32__Array *)v41;
			//   *(_OWORD *)&v169.m_SpaceInfo.m_KeywordSpace = 0LL;
			//   Unity::Collections::NativeArray<unsigned int>::NativeArray(
			//     (NativeArray_1_System_UInt32_ *)&v169,
			//     extentZs,
			//     Allocator__Enum_Persistent,
			//     MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
			//   this.fields._extentZs_k__BackingField = *(NativeArray_1_System_Single_ *)&v169.m_SpaceInfo.m_KeywordSpace;
			//   this.fields.m_chunkNodes = (HGTerrainRenderer_ChunkNode__Array *)il2cpp_array_new_specific_0(
			//                                                                       TypeInfo::HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode,
			//                                                                       (unsigned int)size,
			//                                                                       v48,
			//                                                                       v49);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_chunkNodes, v50, v51, v52, calculateBoundsa, baseVertexa);
			//   v53 = 0;
			//   if ( (int)size > 0 )
			//   {
			//     v54 = size;
			//     v55 = 0LL;
			//     while ( 1 )
			//     {
			//       v56 = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(&v184, this, 0LL);
			//       v58 = *(_OWORD *)&v56.centerXs;
			//       v171 = *(_OWORD *)&v56.centerZs;
			//       v59 = v56.chunkLevel;
			//       v170 = v58;
			//       v60 = *(_OWORD *)&v56.extentYs;
			//       v173 = v59;
			//       v172 = v60;
			//       if ( !v59 )
			//         break;
			//       if ( (unsigned int)v53 >= v59.max_length.size )
			//         goto LABEL_63;
			//       v61 = v59.vector[v53];
			//       v62 = this.fields.m_treeDepth - v61 - 1;
			//       v63 = *(float *)&this.fields._centerZs_k__BackingField.m_Buffer[4 * v55];
			//       v64 = *(float *)&this.fields._extentZs_k__BackingField.m_Buffer[4 * v55];
			//       v65 = _mm_unpacklo_ps(
			//               (__m128)*(_DWORD *)&this.fields._centerXs_k__BackingField.m_Buffer[4 * v55],
			//               (__m128)*(_DWORD *)&this.fields._centerYs_k__BackingField.m_Buffer[4 * v55]).m128_u64[0];
			//       *(_QWORD *)&v178.x = _mm_unpacklo_ps(
			//                              (__m128)*(_DWORD *)&this.fields._extentXs_k__BackingField.m_Buffer[4 * v55],
			//                              (__m128)*(_DWORD *)&this.fields._extentYs_k__BackingField.m_Buffer[4 * v55]).m128_u64[0];
			//       v179.z = v63;
			//       v178.z = v64;
			//       *(_QWORD *)&v179.x = v65;
			//       v66 = UnityEngine::Vector3::op_Addition(&v185, &v179, &v178, v57);
			//       v181.z = v63;
			//       *(_QWORD *)&v180.x = v67;
			//       v180.z = v68;
			//       v69 = *(_QWORD *)&v66.x;
			//       *(float *)&v66 = v66.z;
			//       v182 = v69;
			//       v187 = *(float *)&v66;
			//       *(_QWORD *)&v181.x = v70;
			//       v72 = UnityEngine::Vector3::op_Subtraction(v186, &v181, &v180, v71);
			//       m_chunkNodes = this.fields.m_chunkNodes;
			//       v76 = *(_QWORD *)&v72.x;
			//       z = v72.z;
			//       v183 = v76;
			//       v177 = 0LL;
			//       v175 = 0LL;
			//       v176 = 0LL;
			//       if ( v53 )
			//         v77 = (v53 - 1) / 4;
			//       else
			//         LOWORD(v77) = -1;
			//       WORD4(v176) = v77;
			//       v78 = il2cpp_array_new_specific_0(TypeInfo::System::Int16, 4LL, v73, v74);
			//       v7 = 0xFFFFFFFFLL;
			//       if ( v61 )
			//         v7 = (unsigned int)(4 * v53 + 1);
			//       if ( !v78 )
			//         break;
			//       if ( !*(_DWORD *)(v78 + 24) )
			//         goto LABEL_63;
			//       *(_WORD *)(v78 + 32) = v7;
			//       v7 = 0xFFFFFFFFLL;
			//       if ( v61 )
			//         v7 = (unsigned int)(4 * v53 + 2);
			//       v6 = 1LL;
			//       if ( *(_DWORD *)(v78 + 24) <= 1u )
			//         goto LABEL_63;
			//       *(_WORD *)(v78 + 34) = v7;
			//       v7 = 0xFFFFFFFFLL;
			//       if ( v61 )
			//         v7 = (unsigned int)(4 * v53 + 3);
			//       if ( *(_DWORD *)(v78 + 24) <= 2u )
			//         goto LABEL_63;
			//       *(_WORD *)(v78 + 36) = v7;
			//       v7 = 0xFFFFFFFFLL;
			//       if ( v61 )
			//         v7 = (unsigned int)(4 * v53 + 4);
			//       if ( *(_DWORD *)(v78 + 24) <= 3u )
			// LABEL_63:
			//         sub_180070270(v7, v6);
			//       *(_WORD *)(v78 + 38) = v7;
			//       *(_QWORD *)&v176 = v78;
			//       sub_1800054D0(
			//         (HGRenderPathScene *)&v176,
			//         (HGRenderPathBase_HGRenderPathResources *)1,
			//         (PassConstructorID__Enum__Array *)0xFFFFFFFFLL,
			//         v79,
			//         calculateBoundsb,
			//         baseVertexb);
			//       v169.m_Name = (String *)__PAIR64__(LODWORD(z), v183);
			//       WORD5(v176) = v62;
			//       WORD6(v176) = v62 << 8;
			//       *(float *)&v169.m_SpaceInfo.m_KeywordSpace = *(float *)&v182 - *(float *)&v183;
			//       *((float *)&v169.m_SpaceInfo.m_KeywordSpace + 1) = v187 - z;
			//       v175 = *(_OWORD *)&v169.m_SpaceInfo.m_KeywordSpace;
			//       if ( !m_chunkNodes )
			//         break;
			//       v170 = *(_OWORD *)&v169.m_SpaceInfo.m_KeywordSpace;
			//       v171 = v176;
			//       *(_QWORD *)&v172 = v177;
			//       sub_1805275B4(m_chunkNodes, v53++, &v170);
			//       if ( ++v55 >= v54 )
			//         goto LABEL_29;
			//     }
			// LABEL_64:
			//     sub_180B536AC(v7, v6);
			//   }
			// LABEL_29:
			//   chunkMesh = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkMesh(this, 0LL);
			//   if ( !chunkMesh )
			//     goto LABEL_64;
			//   UnityEngine::Mesh::UploadMeshData(chunkMesh, 1, 0LL);
			//   v85 = sub_182376F20(v82, v81, v83);
			//   v6 = (unsigned int)(32 % (int)*(float *)&v85);
			//   v7 = (__int64)this.fields.m_runtimeResources;
			//   this.fields.m_packedLaneWidth = 32 / (int)*(float *)&v85;
			//   v86 = (unsigned int)(32 / (int)*(float *)&v85);
			//   if ( !v7 )
			//     goto LABEL_64;
			//   this.fields.m_packedLayerInfoWidth = ((int)v86 + *(_DWORD *)(v7 + 24) - 1) / (int)v86;
			//   v87 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector3, 1089LL, v86, v84);
			//   v90 = (Vector3__Array *)v87;
			//   if ( !v87 )
			//     goto LABEL_64;
			//   v91 = (Vector3__Array *)il2cpp_array_new_specific_0(
			//                             TypeInfo::UnityEngine::Vector3,
			//                             *(unsigned int *)(v87 + 24),
			//                             v88,
			//                             v89);
			//   v94 = (Vector2__Array *)il2cpp_array_new_specific_0(
			//                             TypeInfo::UnityEngine::Vector2,
			//                             (unsigned int)v90.max_length.size,
			//                             v92,
			//                             v93);
			//   v97 = (UInt16__Array *)il2cpp_array_new_specific_0(TypeInfo::System::UInt16, 6144LL, v95, v96);
			//   v98 = 0;
			//   while ( v98 < v90.max_length.size )
			//   {
			//     v99 = (float)(v98 / 33) * 0.03125;
			//     v100 = (float)(v98 % 33) * 0.03125;
			//     *(float *)sub_18003EB60(v90, v98) = v100;
			//     *(_DWORD *)(sub_18003EB60(v90, v98) + 4) = 0;
			//     *(float *)(sub_18003EB60(v90, v98) + 8) = v99;
			//     if ( !v91 )
			//       goto LABEL_64;
			//     *(_DWORD *)sub_18003EB60(v91, v98) = 0;
			//     *(_DWORD *)(sub_18003EB60(v91, v98) + 4) = 1065353216;
			//     *(_DWORD *)(sub_18003EB60(v91, v98) + 8) = 0;
			//     if ( !v94 )
			//       goto LABEL_64;
			//     *(float *)sub_180002B90(v94, v98) = v100;
			//     v101 = sub_180002B90(v94, v98++);
			//     *(float *)(v101 + 4) = v99;
			//   }
			//   v102 = 0;
			//   v6 = 0LL;
			//   do
			//   {
			//     v103 = 0;
			//     if ( !v97 )
			//       goto LABEL_64;
			//     do
			//     {
			//       if ( (unsigned int)v102 >= v97.max_length.size )
			//         goto LABEL_63;
			//       v7 = 33 * (unsigned int)(unsigned __int16)v6;
			//       v104 = v102 + 1LL;
			//       LOWORD(v7) = v103 + 33 * v6;
			//       v97.vector[v102] = v7;
			//       if ( (unsigned int)v104 >= v97.max_length.size )
			//         goto LABEL_63;
			//       v105 = v102 + 2;
			//       v106 = (unsigned __int16)(v6 + 1);
			//       v7 = (unsigned int)(33 * v106);
			//       LOWORD(v7) = v103 + 33 * v106;
			//       v97.vector[v104] = v7;
			//       if ( (unsigned int)v105 >= v97.max_length.size )
			//         goto LABEL_63;
			//       v7 = 33 * (unsigned int)(unsigned __int16)v6;
			//       v107 = v105 + 1LL;
			//       LOWORD(v7) = v103 + 33 * v6 + 1;
			//       v97.vector[v105] = v7;
			//       if ( (unsigned int)v107 >= v97.max_length.size )
			//         goto LABEL_63;
			//       v108 = v105 + 2;
			//       v7 = 33 * (unsigned int)(unsigned __int16)v6;
			//       LOWORD(v7) = v103 + 33 * v6 + 34;
			//       v97.vector[v107] = v7;
			//       if ( (unsigned int)v108 >= v97.max_length.size )
			//         goto LABEL_63;
			//       v109 = v108 + 1;
			//       v7 = 33 * (unsigned int)(unsigned __int16)v6;
			//       v110 = v108;
			//       v102 = v108 + 2;
			//       LOWORD(v7) = v103 + 33 * v6 + 1;
			//       v97.vector[v110] = v7;
			//       if ( v109 >= v97.max_length.size )
			//         goto LABEL_63;
			//       v7 = 33 * (unsigned int)(unsigned __int16)(v6 + 1);
			//       LOWORD(v7) = v103++ + 33 * (v6 + 1);
			//       v97.vector[v109] = v7;
			//     }
			//     while ( v103 < 32 );
			//     v6 = (unsigned int)(v6 + 1);
			//   }
			//   while ( (int)v6 < 32 );
			//   v111 = (Mesh *)sub_180004920(TypeInfo::UnityEngine::Mesh);
			//   v112 = (Object_1 *)v111;
			//   if ( !v111 )
			//     goto LABEL_64;
			//   UnityEngine::Mesh::Mesh(v111, 0LL);
			//   UnityEngine::Object::set_name(v112, (String *)"HG_TessellationQuad", 0LL);
			//   UnityEngine::Mesh::SetVertices((Mesh *)v112, v90, 0LL);
			//   UnityEngine::Mesh::SetNormals((Mesh *)v112, v91, 0LL);
			//   UnityEngine::Mesh::SetUVs((Mesh *)v112, 0, v94, 0LL);
			//   UnityEngine::Mesh::SetIndices((Mesh *)v112, v97, MeshTopology__Enum_Triangles, 0, 1, 0, 0LL);
			//   this.fields.m_tessellationQuadMesh = (Mesh *)v112;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_tessellationQuadMesh,
			//     v113,
			//     v114,
			//     v115,
			//     calculateBoundsj,
			//     baseVertexj);
			//   v116 = this.fields.m_runtimeResources;
			//   if ( !v116 )
			//     goto LABEL_64;
			//   terrainLitMaterial = (Object_1 *)v116.fields.terrainLitMaterial;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   v118 = UnityEngine::Object::op_Equality(terrainLitMaterial, 0LL, 0LL);
			//   v7 = (__int64)this.fields.m_runtimeResources;
			//   if ( v118 )
			//   {
			//     if ( !v7 )
			//       goto LABEL_64;
			//     v121 = *(_QWORD *)(v7 + 264);
			//     if ( !v121 )
			//       goto LABEL_64;
			//     v122 = *(Shader **)(v121 + 16);
			//     v123 = (Material *)sub_180004920(TypeInfo::UnityEngine::Material);
			//     v124 = v123;
			//     if ( !v123 )
			//       goto LABEL_64;
			//     UnityEngine::Material::Material(v123, v122, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v7 )
			//       goto LABEL_64;
			//     v124 = *(Material **)(v7 + 272);
			//   }
			//   this.fields.m_terrainLitMaterial = v124;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_terrainLitMaterial,
			//     (HGRenderPathBase_HGRenderPathResources *)v6,
			//     v119,
			//     v120,
			//     calculateBoundsc,
			//     baseVertexc);
			//   v127 = this.fields.m_runtimeResources;
			//   if ( !v127 )
			//     goto LABEL_62;
			//   shaders = v127.fields.shaders;
			//   if ( !shaders )
			//     goto LABEL_62;
			//   terrainLitPS = shaders.fields.terrainLitPS;
			//   memset(&v169, 0, sizeof(v169));
			//   UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v169, terrainLitPS, (String *)"LIGHTMAP_ON", 0LL);
			//   v129 = *(_QWORD *)&v169.m_Index;
			//   *(_OWORD *)&this.fields.m_terrainLitMatLightmapOn.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v169.m_SpaceInfo.m_KeywordSpace;
			//   *(_QWORD *)&this.fields.m_terrainLitMatLightmapOn.m_Index = v129;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_terrainLitMatLightmapOn.m_Name,
			//     v130,
			//     v131,
			//     v132,
			//     calculateBoundsd,
			//     baseVertexd);
			//   v133 = (Dictionary_2_System_Int32_Unity_Collections_NativeList_1_System_ValueTuple_2_Int32_Single_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>);
			//   v134 = v133;
			//   if ( !v133 )
			//     goto LABEL_62;
			//   System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::Dictionary(
			//     v133,
			//     MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::Dictionary);
			//   this.fields.m_cameraRenderData = v134;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_cameraRenderData, v135, v136, v137, calculateBoundse, baseVertexe);
			//   v138 = (Dictionary_2_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>);
			//   v139 = v138;
			//   if ( !v138
			//     || (System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::Dictionary(
			//           v138,
			//           MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::Dictionary),
			//         this.fields.m_fixedLevelRenderData = v139,
			//         sub_1800054D0(
			//           (HGRenderPathScene *)&this.fields.m_fixedLevelRenderData,
			//           v140,
			//           v141,
			//           v142,
			//           calculateBoundsf,
			//           baseVertexf),
			//         (v143 = (MaterialPropertyBlock *)sub_180004920(TypeInfo::UnityEngine::MaterialPropertyBlock)) == 0LL) )
			//   {
			// LABEL_62:
			//     sub_180B536AC(v126, shaders);
			//   }
			//   v143.fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
			//   this.fields.m_perDrawBlock = v143;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_perDrawBlock, v144, v145, v146, calculateBoundsg, baseVertexg);
			// }
			// 
		}

		[IDTag(0)]
		public void TraverseAndCullQuadTreeFixedLevel(int l)
		{
			// // Void TraverseAndCullQuadTreeFixedLevel(Int32)
			// void HG::Rendering::Runtime::HGTerrainRenderer::TraverseAndCullQuadTreeFixedLevel(
			//         HGTerrainRenderer *this,
			//         int32_t l,
			//         MethodInfo *method)
			// {
			//   uint16_t v5; // ax
			//   __int64 v6; // rdx
			//   Dictionary_2_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_ *m_fixedLevelRenderData; // rcx
			//   int32_t v8; // esi
			//   int32_t v9; // eax
			//   __int64 v10; // rbp
			//   int i; // ebx
			//   Void *m_Buffer; // r8
			//   __int64 j; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   NativeArray_1_BeyondDynamicBone_VirtualMesh_BaseLineWork_ v15; // [rsp+30h] [rbp-18h] BYREF
			//   __int64 v16; // [rsp+68h] [rbp+20h]
			// 
			//   if ( !byte_18D919704 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::set_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::NativeArray);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<int,float>::ValueTuple);
			//     byte_18D919704 = 1;
			//   }
			//   v15 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3325, 0LL) )
			//   {
			//     v5 = HG::Rendering::Runtime::HGTerrainRenderer::_ClampLevel(this, l, 0LL);
			//     m_fixedLevelRenderData = this.fields.m_fixedLevelRenderData;
			//     v8 = v5;
			//     if ( m_fixedLevelRenderData )
			//     {
			//       if ( System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::ContainsKey(
			//              m_fixedLevelRenderData,
			//              v5,
			//              MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::ContainsKey) )
			//       {
			//         return;
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//       v9 = HG::Rendering::Runtime::HGTerrainUtils::Pow(4, v8, 0LL);
			//       v10 = v9;
			//       Unity::Collections::NativeArray<BeyondDynamicBone::VirtualMesh::BaseLineWork>::NativeArray(
			//         &v15,
			//         v9,
			//         Allocator__Enum_TempJob,
			//         NativeArrayOptions__Enum_ClearMemory,
			//         MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::NativeArray);
			//       for ( i = 0; ; i = 4 * i + 1 )
			//       {
			//         m_fixedLevelRenderData = (Dictionary_2_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_ *)this.fields.m_chunkNodes;
			//         if ( !m_fixedLevelRenderData )
			//           goto LABEL_17;
			//         if ( i >= SLODWORD(m_fixedLevelRenderData.fields._entries) )
			//           goto LABEL_14;
			//         if ( *(_WORD *)(sub_1803EEC28(m_fixedLevelRenderData, i) + 26) == (_WORD)v8 )
			//           break;
			//       }
			//       if ( (int)v10 > 0 )
			//       {
			//         m_Buffer = v15.m_Buffer;
			//         for ( j = 0LL; j < v10; ++j )
			//         {
			//           v16 = (unsigned int)i++;
			//           *(_QWORD *)&m_Buffer[8 * j] = v16;
			//         }
			//       }
			// LABEL_14:
			//       m_fixedLevelRenderData = this.fields.m_fixedLevelRenderData;
			//       if ( m_fixedLevelRenderData )
			//       {
			//         System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::set_Item(
			//           m_fixedLevelRenderData,
			//           v8,
			//           (NativeArray_1_System_ValueTuple_2_Int32_Single_ *)&v15,
			//           MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::set_Item);
			//         return;
			//       }
			//     }
			// LABEL_17:
			//     sub_180B536AC(m_fixedLevelRenderData, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3325, 0LL);
			//   if ( !Patch )
			//     goto LABEL_17;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, l, 0LL);
			// }
			// 
		}

		[IDTag(1)]
		public NativeList<ValueTuple<int, float>> TraverseAndCullQuadTreeFixedLevel(int l, Matrix4x4 cullingMatrix)
		{
			// // NativeList`1[System.ValueTuple`2[Int32,Single]] TraverseAndCullQuadTreeFixedLevel(Int32, Matrix4x4)
			// NativeList_1_System_ValueTuple_2_Int32_Single_ *HG::Rendering::Runtime::HGTerrainRenderer::TraverseAndCullQuadTreeFixedLevel(
			//         NativeList_1_System_ValueTuple_2_Int32_Single_ *__return_ptr retstr,
			//         HGTerrainRenderer *this,
			//         int32_t l,
			//         Matrix4x4 *cullingMatrix,
			//         MethodInfo *method)
			// {
			//   HGTerrainRenderer_ChunkNode__Array *v9; // rcx
			//   HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // rdx
			//   int32_t size; // edx
			//   NativeArray_1_System_Int32_ v12; // xmm0
			//   NativeArray_1_System_Single_ extentYs_k__BackingField; // xmm1
			//   NativeArray_1_System_Single_ extentZs_k__BackingField; // xmm0
			//   NativeArray_1_System_Single_ centerZs_k__BackingField; // xmm1
			//   NativeArray_1_System_Single_ extentXs_k__BackingField; // xmm0
			//   NativeArray_1_System_Single_ centerXs_k__BackingField; // xmm1
			//   NativeArray_1_System_Single_ centerYs_k__BackingField; // xmm0
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   int32_t v23; // r15d
			//   __int64 v24; // r14
			//   int i; // ebx
			//   __int64 v26; // r15
			//   NativeList_1_System_ValueTuple_2_Int32_Single_ v27; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   NativeList_1_System_ValueTuple_2_Int32_Single_ *result; // rax
			//   NativeArray_1_System_Int32_ v33; // [rsp+50h] [rbp-B0h] BYREF
			//   NativeList_1_BeyondDynamicBone_VirtualMesh_BaseLineWork_ v34; // [rsp+60h] [rbp-A0h] BYREF
			//   NativeArray_1_System_Single_ v35; // [rsp+70h] [rbp-90h] BYREF
			//   Matrix4x4 v36; // [rsp+80h] [rbp-80h] BYREF
			//   NativeArray_1_System_Single_ v37; // [rsp+C0h] [rbp-40h] BYREF
			//   NativeArray_1_System_Single_ v38; // [rsp+D0h] [rbp-30h] BYREF
			//   NativeArray_1_System_Single_ v39; // [rsp+E0h] [rbp-20h] BYREF
			//   NativeArray_1_System_Single_ v40; // [rsp+F0h] [rbp-10h] BYREF
			//   NativeArray_1_System_Single_ v41; // [rsp+100h] [rbp+0h] BYREF
			// 
			//   if ( !byte_18D919705 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::Add);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::NativeList);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<int,float>::ValueTuple);
			//     byte_18D919705 = 1;
			//   }
			//   v34 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3332, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3332, 0LL);
			//     if ( Patch )
			//     {
			//       v29 = *(_OWORD *)&cullingMatrix.m01;
			//       *(_OWORD *)&v36.m00 = *(_OWORD *)&cullingMatrix.m00;
			//       v30 = *(_OWORD *)&cullingMatrix.m02;
			//       *(_OWORD *)&v36.m01 = v29;
			//       v31 = *(_OWORD *)&cullingMatrix.m03;
			//       *(_OWORD *)&v36.m02 = v30;
			//       *(_OWORD *)&v36.m03 = v31;
			//       v27 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1182(
			//                (NativeList_1_System_ValueTuple_2_Int32_Single_ *)&v35,
			//                Patch,
			//                (Object *)this,
			//                l,
			//                &v36,
			//                0LL);
			//       goto LABEL_19;
			//     }
			// LABEL_17:
			//     sub_180B536AC(v9, m_chunkNodes);
			//   }
			//   m_chunkNodes = this.fields.m_chunkNodes;
			//   if ( !m_chunkNodes )
			//     goto LABEL_17;
			//   size = m_chunkNodes.max_length.size;
			//   v33 = 0LL;
			//   Unity::Collections::NativeArray<int>::NativeArray(
			//     &v33,
			//     size,
			//     Allocator__Enum_Temp,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//   v12 = v33;
			//   extentYs_k__BackingField = this.fields._extentYs_k__BackingField;
			//   this.fields.m_visibility = v33;
			//   v33 = v12;
			//   extentZs_k__BackingField = this.fields._extentZs_k__BackingField;
			//   v38 = extentYs_k__BackingField;
			//   centerZs_k__BackingField = this.fields._centerZs_k__BackingField;
			//   v37 = extentZs_k__BackingField;
			//   extentXs_k__BackingField = this.fields._extentXs_k__BackingField;
			//   v40 = centerZs_k__BackingField;
			//   centerXs_k__BackingField = this.fields._centerXs_k__BackingField;
			//   v39 = extentXs_k__BackingField;
			//   centerYs_k__BackingField = this.fields._centerYs_k__BackingField;
			//   v35 = centerXs_k__BackingField;
			//   v19 = *(_OWORD *)&cullingMatrix.m01;
			//   v41 = centerYs_k__BackingField;
			//   v20 = *(_OWORD *)&cullingMatrix.m00;
			//   *(_OWORD *)&v36.m01 = v19;
			//   v21 = *(_OWORD *)&cullingMatrix.m03;
			//   *(_OWORD *)&v36.m00 = v20;
			//   v22 = *(_OWORD *)&cullingMatrix.m02;
			//   *(_OWORD *)&v36.m03 = v21;
			//   *(_OWORD *)&v36.m02 = v22;
			//   UnityEngine::GeometryUtility::SPMDCullAABBNoFar(&v36, &v35, &v41, &v40, &v39, &v38, &v37, &v33, 0LL);
			//   Unity::Collections::NativeList<BeyondDynamicBone::VirtualMesh::BaseLineWork>::NativeList(
			//     &v34,
			//     (AllocatorManager_AllocatorHandle)3,
			//     MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::NativeList);
			//   v23 = HG::Rendering::Runtime::HGTerrainRenderer::_ClampLevel(this, l, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//   v24 = HG::Rendering::Runtime::HGTerrainUtils::Pow(4, v23, 0LL);
			//   for ( i = 0; ; i = 4 * i + 1 )
			//   {
			//     v9 = this.fields.m_chunkNodes;
			//     if ( !v9 )
			//       goto LABEL_17;
			//     if ( i >= v9.max_length.size )
			//       goto LABEL_15;
			//     if ( *(_WORD *)(sub_1803EEC28(v9, i) + 26) == (_WORD)v23 )
			//       break;
			//   }
			//   if ( v24 > 0 )
			//   {
			//     v26 = 4LL * i;
			//     do
			//     {
			//       if ( *(_DWORD *)&this.fields.m_visibility.m_Buffer[v26] )
			//       {
			//         v33.m_Buffer = (Void *)(unsigned int)i;
			//         Unity::Collections::NativeList<BeyondDynamicBone::VirtualMesh::BaseLineWork>::Add(
			//           &v34,
			//           (VirtualMesh_BaseLineWork *)&v33,
			//           MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::Add);
			//       }
			//       ++i;
			//       v26 += 4LL;
			//       --v24;
			//     }
			//     while ( v24 );
			//   }
			// LABEL_15:
			//   Unity::Collections::NativeArray<int>::Dispose(
			//     &this.fields.m_visibility,
			//     MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//   v27 = (NativeList_1_System_ValueTuple_2_Int32_Single_)v34;
			// LABEL_19:
			//   result = retstr;
			//   *retstr = v27;
			//   return result;
			// }
			// 
			return null;
		}

		public void TraverseAndCullQuadTree(Camera camera)
		{
			// // Void TraverseAndCullQuadTree(Camera)
			// void HG::Rendering::Runtime::HGTerrainRenderer::TraverseAndCullQuadTree(
			//         HGTerrainRenderer *this,
			//         Camera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Dictionary_2_System_Int32_Unity_Collections_NativeList_1_System_ValueTuple_2_Int32_Single_ *m_cameraRenderData; // rbx
			//   int32_t InstanceID; // eax
			//   int32_t pixelWidth; // ebx
			//   float aspect; // xmm6_4
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // r8
			//   __int64 v14; // r9
			//   float v15; // xmm0_4
			//   __int64 v16; // rcx
			//   HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // rdx
			//   int32_t size; // edx
			//   int32_t v19; // edx
			//   Matrix4x4 *cullingMatrix; // rax
			//   NativeArray_1_System_Single_ extentZs_k__BackingField; // xmm1
			//   NativeArray_1_System_Single_ extentYs_k__BackingField; // xmm0
			//   NativeArray_1_System_Single_ extentXs_k__BackingField; // xmm1
			//   NativeArray_1_System_Single_ centerZs_k__BackingField; // xmm0
			//   NativeArray_1_System_Single_ centerYs_k__BackingField; // xmm1
			//   NativeArray_1_System_Single_ centerXs_k__BackingField; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   Transform *transform; // rax
			//   NativeList_1_BeyondDynamicBone_VirtualMesh_BaseLineWork_ v32; // xmm0
			//   HGRenderPathBase_HGRenderPathResources *v33; // rdx
			//   PassConstructorID__Enum__Array *v34; // r8
			//   HGCamera *v35; // r9
			//   Dictionary_2_System_Int32_Unity_Collections_NativeList_1_System_ValueTuple_2_Int32_Single_ *v36; // rbx
			//   int32_t v37; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *methoda; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v40; // [rsp+30h] [rbp-D8h]
			//   _QWORD v41[3]; // [rsp+50h] [rbp-B8h] BYREF
			//   Vector3 viewPoint; // [rsp+68h] [rbp-A0h] BYREF
			//   HGTerrainRenderer_ChunkComparer v43; // [rsp+78h] [rbp-90h] BYREF
			//   NativeList_1_BeyondDynamicBone_VirtualMesh_BaseLineWork_ v44; // [rsp+88h] [rbp-80h] BYREF
			//   NativeList_1_BeyondDynamicBone_VirtualMesh_BaseLineWork_ v45; // [rsp+98h] [rbp-70h] BYREF
			//   NativeArray_1_System_Single_ v46; // [rsp+A8h] [rbp-60h] BYREF
			//   NativeArray_1_System_Single_ v47; // [rsp+B8h] [rbp-50h] BYREF
			//   NativeArray_1_System_Single_ v48; // [rsp+C8h] [rbp-40h] BYREF
			//   NativeArray_1_System_Single_ v49; // [rsp+D8h] [rbp-30h] BYREF
			//   NativeArray_1_System_Single_ v50; // [rsp+E8h] [rbp-20h] BYREF
			//   Matrix4x4 v51; // [rsp+F8h] [rbp-10h] BYREF
			//   Matrix4x4 v52; // [rsp+138h] [rbp+30h] BYREF
			// 
			//   if ( !byte_18D919706 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::set_Item);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<bool>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<bool>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::NativeList);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeSortExtension::Sort<System::ValueTuple<int,float>,HG::Rendering::Runtime::HGTerrainRenderer::ChunkComparer>);
			//     byte_18D919706 = 1;
			//   }
			//   *(_QWORD *)&viewPoint.x = 0LL;
			//   viewPoint.z = 0.0;
			//   v45 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3339, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3339, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)camera,
			//         0LL);
			//       return;
			//     }
			// LABEL_14:
			//     sub_180B536AC(v6, v5);
			//   }
			//   m_cameraRenderData = this.fields.m_cameraRenderData;
			//   if ( !camera )
			//     goto LABEL_14;
			//   InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)camera, 0LL);
			//   if ( !m_cameraRenderData )
			//     goto LABEL_14;
			//   if ( !System::Collections::Generic::Dictionary<int,Beyond::UI::UIAtlasManager_UIAtlasPage::TextureRefHandle>::ContainsKey(
			//           (Dictionary_2_System_Int32_Beyond_UI_UIAtlasManager_UIAtlasPage_TextureRefHandle_ *)m_cameraRenderData,
			//           InstanceID,
			//           MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::ContainsKey) )
			//   {
			//     pixelWidth = UnityEngine::Camera::get_pixelWidth(camera, 0LL);
			//     UnityEngine::Camera::get_fieldOfView(camera, 0LL);
			//     aspect = UnityEngine::Camera::get_aspect(camera, 0LL);
			//     v15 = sub_1802ED290(v12, v11, v13, v14);
			//     HG::Rendering::Runtime::HGTerrainRenderer::_ComputeLodMax(this, pixelWidth, aspect * v15, 0LL);
			//     m_chunkNodes = this.fields.m_chunkNodes;
			//     if ( !m_chunkNodes )
			//       goto LABEL_12;
			//     size = m_chunkNodes.max_length.size;
			//     *(_OWORD *)&v41[1] = 0LL;
			//     Unity::Collections::NativeArray<BeyondDynamicBone::VertexAttribute>::NativeArray(
			//       (NativeArray_1_BeyondDynamicBone_VertexAttribute_ *)&v41[1],
			//       size,
			//       Allocator__Enum_Temp,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<bool>::NativeArray);
			//     m_chunkNodes = this.fields.m_chunkNodes;
			//     this.fields.m_splits = *(NativeArray_1_System_Boolean_ *)&v41[1];
			//     if ( !m_chunkNodes )
			//       goto LABEL_12;
			//     v19 = m_chunkNodes.max_length.size;
			//     *(_OWORD *)&v41[1] = 0LL;
			//     Unity::Collections::NativeArray<int>::NativeArray(
			//       (NativeArray_1_System_Int32_ *)&v41[1],
			//       v19,
			//       Allocator__Enum_Temp,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//     this.fields.m_visibility = *(NativeArray_1_System_Int32_ *)&v41[1];
			//     cullingMatrix = UnityEngine::Camera::get_cullingMatrix(&v52, camera, 0LL);
			//     extentZs_k__BackingField = this.fields._extentZs_k__BackingField;
			//     *(NativeArray_1_System_Int32_ *)&v41[1] = this.fields.m_visibility;
			//     extentYs_k__BackingField = this.fields._extentYs_k__BackingField;
			//     v46 = extentZs_k__BackingField;
			//     extentXs_k__BackingField = this.fields._extentXs_k__BackingField;
			//     v47 = extentYs_k__BackingField;
			//     centerZs_k__BackingField = this.fields._centerZs_k__BackingField;
			//     v48 = extentXs_k__BackingField;
			//     centerYs_k__BackingField = this.fields._centerYs_k__BackingField;
			//     v49 = centerZs_k__BackingField;
			//     centerXs_k__BackingField = this.fields._centerXs_k__BackingField;
			//     v50 = centerYs_k__BackingField;
			//     v27 = *(_OWORD *)&cullingMatrix.m00;
			//     v44 = (NativeList_1_BeyondDynamicBone_VirtualMesh_BaseLineWork_)centerXs_k__BackingField;
			//     v28 = *(_OWORD *)&cullingMatrix.m01;
			//     *(_OWORD *)&v51.m00 = v27;
			//     v29 = *(_OWORD *)&cullingMatrix.m02;
			//     *(_OWORD *)&v51.m01 = v28;
			//     v30 = *(_OWORD *)&cullingMatrix.m03;
			//     *(_OWORD *)&v51.m02 = v29;
			//     *(_OWORD *)&v51.m03 = v30;
			//     UnityEngine::GeometryUtility::SPMDCullAABBNoFar(
			//       &v51,
			//       (NativeArray_1_System_Single_ *)&v44,
			//       &v50,
			//       &v49,
			//       &v48,
			//       &v47,
			//       &v46,
			//       (NativeArray_1_System_Int32_ *)&v41[1],
			//       0LL);
			//     Unity::Collections::NativeList<BeyondDynamicBone::VirtualMesh::BaseLineWork>::NativeList(
			//       &v45,
			//       (AllocatorManager_AllocatorHandle)3,
			//       MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::NativeList);
			//     transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//     if ( !transform )
			//       goto LABEL_12;
			//     viewPoint = *UnityEngine::Transform::get_position((Vector3 *)&v41[1], transform, 0LL);
			//     HG::Rendering::Runtime::HGTerrainRenderer::_UpdateGeometry(
			//       this,
			//       0,
			//       &viewPoint,
			//       (NativeList_1_System_ValueTuple_2_Int32_Single_ *)&v45,
			//       0LL);
			//     v32 = v45;
			//     v43.m_chunkNodes = this.fields.m_chunkNodes;
			//     sub_1800054D0((HGRenderPathScene *)&v43, v33, v34, v35, methoda, v40);
			//     v44 = v32;
			//     Unity::Collections::NativeSortExtension::Sort<System::ValueTuple<int,float>,HG::Rendering::Runtime::HGTerrainRenderer::ChunkComparer>(
			//       (NativeList_1_System_ValueTuple_2_Int32_Single_ *)&v44,
			//       v43,
			//       MethodInfo::Unity::Collections::NativeSortExtension::Sort<System::ValueTuple<int,float>,HG::Rendering::Runtime::HGTerrainRenderer::ChunkComparer>);
			//     v36 = this.fields.m_cameraRenderData;
			//     v37 = UnityEngine::Object::GetInstanceID((Object_1 *)camera, 0LL);
			//     if ( !v36 )
			// LABEL_12:
			//       sub_180B536AC(v16, m_chunkNodes);
			//     v44 = v45;
			//     System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::set_Item(
			//       v36,
			//       v37,
			//       (NativeList_1_System_ValueTuple_2_Int32_Single_ *)&v44,
			//       MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::set_Item);
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&this.fields.m_splits,
			//       MethodInfo::Unity::Collections::NativeArray<bool>::Dispose);
			//     Unity::Collections::NativeArray<int>::Dispose(
			//       &this.fields.m_visibility,
			//       MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//   }
			// }
			// 
		}

		public void GameUpdate(Camera camera)
		{
			// // Void GameUpdate(Camera)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGTerrainRenderer::GameUpdate(HGTerrainRenderer *this, Camera *camera, MethodInfo *method)
			// {
			//   HGTerrainRenderer *v4; // rbx
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *m_cameraRenderData; // rcx
			//   Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *m_fixedLevelRenderData; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   __int64 v14; // [rsp+0h] [rbp-E8h] BYREF
			//   Il2CppException *ex; // [rsp+20h] [rbp-C8h]
			//   void *v16; // [rsp+28h] [rbp-C0h]
			//   NativeList_1_System_ValueTuple_2_Int32_Single_ value; // [rsp+30h] [rbp-B8h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_ v18; // [rsp+40h] [rbp-A8h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ v19; // [rsp+70h] [rbp-78h] BYREF
			//   Il2CppExceptionWrapper *v20; // [rsp+A0h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v21; // [rsp+A8h] [rbp-40h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32_Unity_Collections_NativeList_1_System_ValueTuple_2_Int32_Single_ v22; // [rsp+B0h] [rbp-38h] BYREF
			// 
			//   v4 = this;
			//   if ( !byte_18D919707 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::get_Value);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::Dispose);
			//     byte_18D919707 = 1;
			//   }
			//   memset(&v18, 0, sizeof(v18));
			//   if ( IFix::WrappersManagerImpl::IsPatched(3349, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3349, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)v4,
			//       (Object *)camera,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !v4.fields.m_vtRenderer )
			//       sub_180B536AC(v6, v5);
			//     HG::Rendering::Runtime::VirtualTextureRenderer::GameUpdate(v4.fields.m_vtRenderer, camera, 0LL);
			//     if ( !v4.fields.m_cameraRenderData )
			//       sub_180B536AC(v8, v7);
			//     System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::GetEnumerator(
			//       &v19,
			//       (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v4.fields.m_cameraRenderData,
			//       MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::GetEnumerator);
			//     v22 = (Dictionary_2_TKey_TValue_Enumerator_System_Int32_Unity_Collections_NativeList_1_System_ValueTuple_2_Int32_Single_)v19;
			//     ex = 0LL;
			//     v16 = &v22;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::MoveNext(
			//                 &v22,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::MoveNext) )
			//       {
			//         value = v22._current.value;
			//         Unity::Collections::NativeList<System::ValueTuple<int,float>>::Dispose(
			//           &value,
			//           MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::Dispose);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v20 )
			//     {
			//       ex = v20.ex;
			//       m_cameraRenderData = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v4 = this;
			//     }
			//     m_fixedLevelRenderData = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v4.fields.m_fixedLevelRenderData;
			//     if ( !m_fixedLevelRenderData )
			//       goto LABEL_26;
			//     System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::GetEnumerator(
			//       &v19,
			//       m_fixedLevelRenderData,
			//       MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::GetEnumerator);
			//     v18 = (Dictionary_2_TKey_TValue_Enumerator_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_)v19;
			//     ex = 0LL;
			//     v16 = &v18;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::MoveNext(
			//                 &v18,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::MoveNext) )
			//       {
			//         value = (NativeList_1_System_ValueTuple_2_Int32_Single_)v18._current.value;
			//         Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
			//           (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&value,
			//           MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::Dispose);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v21 )
			//     {
			//       m_fixedLevelRenderData = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)&v14;
			//       ex = v21.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v4 = this;
			//     }
			//     m_cameraRenderData = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v4.fields.m_cameraRenderData;
			//     if ( !m_cameraRenderData
			//       || (System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
			//             m_cameraRenderData,
			//             MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::Clear),
			//           (m_cameraRenderData = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v4.fields.m_fixedLevelRenderData) == 0LL) )
			//     {
			// LABEL_26:
			//       sub_1802DC2C8(m_cameraRenderData, m_fixedLevelRenderData);
			//     }
			//     System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
			//       m_cameraRenderData,
			//       MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::Clear);
			//   }
			// }
			// 
		}

		public void BakeVirtualPages(ScriptableRenderContext context)
		{
			// // Void BakeVirtualPages(ScriptableRenderContext)
			// void HG::Rendering::Runtime::HGTerrainRenderer::BakeVirtualPages(
			//         HGTerrainRenderer *this,
			//         ScriptableRenderContext context,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   VirtualTextureRenderer *m_vtRenderer; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3367, 0LL) )
			//   {
			//     m_vtRenderer = this.fields.m_vtRenderer;
			//     if ( m_vtRenderer )
			//     {
			//       HG::Rendering::Runtime::VirtualTextureRenderer::Render(m_vtRenderer, context, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(m_vtRenderer, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3367, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_197(Patch, (Object *)this, context, 0LL);
			// }
			// 
		}

		public void PipelineUpdate(PerObjectData renderConfiguration, Vector2 vtCenter)
		{
			// // Void PipelineUpdate(PerObjectData, Vector2)
			// void HG::Rendering::Runtime::HGTerrainRenderer::PipelineUpdate(
			//         HGTerrainRenderer *this,
			//         PerObjectData__Enum renderConfiguration,
			//         Vector2 vtCenter,
			//         MethodInfo *method)
			// {
			//   __int64 v6; // rdx
			//   void *m_vtRenderer; // rcx
			//   ComputeBuffer *v8; // rax
			//   ComputeBuffer *v9; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v10; // rdx
			//   PassConstructorID__Enum__Array *v11; // r8
			//   HGCamera *v12; // r9
			//   Material *m_terrainLitMaterial; // rbx
			//   ComputeBuffer *m_perTerrainDataBuffer; // r12
			//   int32_t HGTerrainPerTerrain; // r15d
			//   int32_t count; // eax
			//   int32_t v17; // r14d
			//   int32_t stride; // eax
			//   Material *v19; // rbx
			//   int32_t HGTerrainReflectionProbeTex; // r14d
			//   Texture *ReflectionProbeArrayInternal; // rax
			//   HGTerrainRuntimeResources *m_runtimeResources; // rax
			//   HGTerrainRuntimeResources_TextureResources *textures; // rbx
			//   Object_1 *lightmapColorTex; // rbx
			//   char v25; // r14
			//   VirtualTextureRenderer *v26; // rax
			//   float y; // xmm0_4
			//   float x; // xmm1_4
			//   Void *m_Buffer; // rbx
			//   SphericalHarmonicsL2 *defaultProbeSH; // rax
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   __int128 v33; // xmm1
			//   __int128 v34; // xmm0
			//   __int128 v35; // xmm1
			//   SHCoefficientsL1 *CoefficientsL1; // rax
			//   Vector4 shAg; // xmm4
			//   Vector4 shAb; // xmm3
			//   Material *v39; // rsi
			//   SphericalHarmonicsL2 *ambientProbe; // rax
			//   __int128 v41; // xmm1
			//   __int128 v42; // xmm0
			//   __int128 v43; // xmm1
			//   __int128 v44; // xmm0
			//   __int128 v45; // xmm1
			//   float Item; // xmm9_4
			//   float v47; // xmm8_4
			//   float v48; // xmm6_4
			//   float v49; // xmm9_4
			//   float v50; // xmm8_4
			//   float v51; // xmm6_4
			//   float v52; // xmm9_4
			//   float v53; // xmm8_4
			//   float v54; // xmm6_4
			//   float v55; // xmm6_4
			//   float v56; // xmm6_4
			//   float v57; // xmm6_4
			//   HGTerrainRuntimeResources *v58; // rax
			//   HGTerrainRuntimeResources_TextureResources *v59; // rax
			//   HGTerrainRuntimeResources *v60; // rbx
			//   HGTerrainRuntimeResources_TextureResources *v61; // rbx
			//   Object_1 *lightmapDirTex; // rbx
			//   Material *v63; // rbx
			//   HGTerrainRuntimeResources *v64; // rax
			//   HGTerrainRuntimeResources_TextureResources *v65; // rax
			//   int32_t v66; // eax
			//   ComputeBuffer *m_perTerrainFrameDataBuffer; // rcx
			//   ComputeBuffer *v68; // rax
			//   ComputeBuffer *v69; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v70; // rdx
			//   PassConstructorID__Enum__Array *v71; // r8
			//   HGCamera *v72; // r9
			//   Material *v73; // rbx
			//   ComputeBuffer *v74; // r15
			//   int32_t HGTerrainPerTerrainFrame; // r14d
			//   int32_t v76; // eax
			//   int32_t v77; // esi
			//   int32_t v78; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *size; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *sizea; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *v82; // [rsp+30h] [rbp-D8h]
			//   NativeArray_1_Unity_Mathematics_quaternion_ v83; // [rsp+38h] [rbp-D0h] BYREF
			//   SphericalHarmonicsL2 v84; // [rsp+48h] [rbp-C0h] BYREF
			//   Vector2 vtCentera; // [rsp+B8h] [rbp-50h] BYREF
			//   NativeArray_1_Unity_Mathematics_quaternion_ v86; // [rsp+C8h] [rbp-40h] BYREF
			//   SHCoefficientsL1 v87; // [rsp+108h] [rbp+0h] BYREF
			//   SphericalHarmonicsL2 v88; // [rsp+138h] [rbp+30h] BYREF
			// 
			//   vtCentera = vtCenter;
			//   if ( !byte_18D919708 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::ComputeBuffer::SetData<UnityEngine::Vector4>);
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919708 = 1;
			//   }
			//   v86 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3372, 0LL) )
			//   {
			//     m_vtRenderer = this.fields.m_vtRenderer;
			//     if ( m_vtRenderer )
			//     {
			//       HG::Rendering::Runtime::VirtualTextureRenderer::PipelineUpdate(
			//         (VirtualTextureRenderer *)m_vtRenderer,
			//         &vtCentera,
			//         0LL);
			//       m_vtRenderer = this.fields.m_vtRenderer;
			//       if ( m_vtRenderer )
			//       {
			//         HG::Rendering::Runtime::VirtualTextureRenderer::SetupVTTexturesForMaterial(
			//           (VirtualTextureRenderer *)m_vtRenderer,
			//           this.fields.m_terrainLitMaterial,
			//           0LL);
			//         if ( !this.fields.m_perTerrainDataBuffer )
			//         {
			//           v8 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//           v9 = v8;
			//           if ( !v8 )
			//             goto LABEL_48;
			//           UnityEngine::ComputeBuffer::ComputeBuffer(
			//             v8,
			//             6,
			//             16,
			//             ComputeBufferType__Enum_Constant,
			//             ComputeBufferMode__Enum_Immutable,
			//             0LL);
			//           this.fields.m_perTerrainDataBuffer = v9;
			//           sub_1800054D0((HGRenderPathScene *)&this.fields.m_perTerrainDataBuffer, v10, v11, v12, size, v82);
			//         }
			//         m_vtRenderer = this.fields.m_vtRenderer;
			//         if ( m_vtRenderer )
			//         {
			//           HG::Rendering::Runtime::VirtualTextureRenderer::SetupVTDataBufferForMaterial(
			//             (VirtualTextureRenderer *)m_vtRenderer,
			//             this.fields.m_perTerrainDataBuffer,
			//             0LL);
			//           m_terrainLitMaterial = this.fields.m_terrainLitMaterial;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//           m_perTerrainDataBuffer = this.fields.m_perTerrainDataBuffer;
			//           HGTerrainPerTerrain = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainPerTerrain;
			//           m_vtRenderer = m_perTerrainDataBuffer;
			//           if ( m_perTerrainDataBuffer )
			//           {
			//             count = UnityEngine::ComputeBuffer::get_count(m_perTerrainDataBuffer, 0LL);
			//             m_vtRenderer = this.fields.m_perTerrainDataBuffer;
			//             v17 = count;
			//             if ( m_vtRenderer )
			//             {
			//               stride = UnityEngine::ComputeBuffer::get_stride((ComputeBuffer *)m_vtRenderer, 0LL);
			//               if ( m_terrainLitMaterial )
			//               {
			//                 UnityEngine::Material::SetConstantBufferImpl(
			//                   m_terrainLitMaterial,
			//                   HGTerrainPerTerrain,
			//                   m_perTerrainDataBuffer,
			//                   0,
			//                   v17 * stride,
			//                   0LL);
			//                 v19 = this.fields.m_terrainLitMaterial;
			//                 HGTerrainReflectionProbeTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainReflectionProbeTex;
			//                 ReflectionProbeArrayInternal = UnityEngine::Renderer::GetReflectionProbeArrayInternal(0LL);
			//                 if ( v19 )
			//                 {
			//                   UnityEngine::Material::SetTextureImpl(
			//                     v19,
			//                     HGTerrainReflectionProbeTex,
			//                     ReflectionProbeArrayInternal,
			//                     0LL);
			//                   if ( (renderConfiguration & 8) == 0 )
			//                     goto LABEL_19;
			//                   m_runtimeResources = this.fields.m_runtimeResources;
			//                   if ( !m_runtimeResources )
			//                     goto LABEL_48;
			//                   textures = m_runtimeResources.fields.textures;
			//                   if ( !textures )
			//                     goto LABEL_48;
			//                   lightmapColorTex = (Object_1 *)textures.fields.lightmapColorTex;
			//                   sub_180002C70(TypeInfo::UnityEngine::Object);
			//                   if ( UnityEngine::Object::op_Inequality(lightmapColorTex, 0LL, 0LL) )
			//                     v25 = 1;
			//                   else
			// LABEL_19:
			//                     v25 = 0;
			//                   Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//                     &v86,
			//                     v25 != 0 ? 5 : 12,
			//                     Allocator__Enum_Temp,
			//                     NativeArrayOptions__Enum_ClearMemory,
			//                     MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//                   v26 = this.fields.m_vtRenderer;
			//                   if ( !v26 )
			//                     goto LABEL_48;
			//                   y = v26.fields._currentCenterPos_k__BackingField.y;
			//                   x = v26.fields._currentCenterPos_k__BackingField.x;
			//                   v83.m_Length = 0;
			//                   v83.m_AllocatorLabel = 0;
			//                   m_Buffer = v86.m_Buffer;
			//                   *(float *)&v83.m_Buffer = x;
			//                   *((float *)&v83.m_Buffer + 1) = y;
			//                   *(_OWORD *)v86.m_Buffer = (unsigned __int64)v83.m_Buffer;
			//                   *(__m128i *)&m_Buffer[16] = _mm_loadu_si128((const __m128i *)UnityEngine::ReflectionProbe::get_defaultTextureHDRDecodeValues(
			//                                                                                  (Vector4 *)&v83,
			//                                                                                  0LL));
			//                   defaultProbeSH = UnityEngine::ReflectionProbe::get_defaultProbeSH(&v88, 0LL);
			//                   v31 = *(_OWORD *)&defaultProbeSH.shr4;
			//                   *(_OWORD *)&v84.shr0 = *(_OWORD *)&defaultProbeSH.shr0;
			//                   v32 = *(_OWORD *)&defaultProbeSH.shr8;
			//                   *(_OWORD *)&v84.shr4 = v31;
			//                   v33 = *(_OWORD *)&defaultProbeSH.shg3;
			//                   *(_OWORD *)&v84.shr8 = v32;
			//                   v34 = *(_OWORD *)&defaultProbeSH.shg7;
			//                   *(_OWORD *)&v84.shg3 = v33;
			//                   v35 = *(_OWORD *)&defaultProbeSH.shb2;
			//                   *(_OWORD *)&v84.shg7 = v34;
			//                   *(_QWORD *)&v34 = *(_QWORD *)&defaultProbeSH.shb6;
			//                   *(float *)&defaultProbeSH = defaultProbeSH.shb8;
			//                   *(_QWORD *)&v84.shb6 = v34;
			//                   LODWORD(v84.shb8) = (_DWORD)defaultProbeSH;
			//                   *(_OWORD *)&v84.shb2 = v35;
			//                   CoefficientsL1 = HG::Rendering::Runtime::HGEnvironmentUtils::GetCoefficientsL1(&v87, &v84, 0LL);
			//                   shAg = CoefficientsL1.shAg;
			//                   shAb = CoefficientsL1.shAb;
			//                   *(Vector4 *)&m_Buffer[32] = CoefficientsL1.shAr;
			//                   *(Vector4 *)&m_Buffer[48] = shAg;
			//                   *(Vector4 *)&m_Buffer[64] = shAb;
			//                   v39 = this.fields.m_terrainLitMaterial;
			//                   if ( v25 )
			//                   {
			//                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                     m_vtRenderer = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                     v58 = this.fields.m_runtimeResources;
			//                     if ( !v58 )
			//                       goto LABEL_48;
			//                     v59 = v58.fields.textures;
			//                     if ( !v59 )
			//                       goto LABEL_48;
			//                     if ( !v39 )
			//                       goto LABEL_48;
			//                     UnityEngine::Material::SetTextureImpl(
			//                       v39,
			//                       *((_DWORD *)m_vtRenderer + 164),
			//                       (Texture *)v59.fields.lightmapColorTex,
			//                       0LL);
			//                     v60 = this.fields.m_runtimeResources;
			//                     if ( !v60 )
			//                       goto LABEL_48;
			//                     v61 = v60.fields.textures;
			//                     if ( !v61 )
			//                       goto LABEL_48;
			//                     lightmapDirTex = (Object_1 *)v61.fields.lightmapDirTex;
			//                     sub_180002C70(TypeInfo::UnityEngine::Object);
			//                     if ( UnityEngine::Object::op_Implicit(lightmapDirTex, 0LL) )
			//                     {
			//                       v63 = this.fields.m_terrainLitMaterial;
			//                       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                       m_vtRenderer = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                       v64 = this.fields.m_runtimeResources;
			//                       if ( !v64 )
			//                         goto LABEL_48;
			//                       v65 = v64.fields.textures;
			//                       if ( !v65 || !v63 )
			//                         goto LABEL_48;
			//                       UnityEngine::Material::SetTextureImpl(
			//                         v63,
			//                         *((_DWORD *)m_vtRenderer + 165),
			//                         (Texture *)v65.fields.lightmapDirTex,
			//                         0LL);
			//                     }
			//                     m_vtRenderer = this.fields.m_terrainLitMaterial;
			//                     if ( !m_vtRenderer )
			//                       goto LABEL_48;
			//                     UnityEngine::Material::EnableKeyword(
			//                       (Material *)m_vtRenderer,
			//                       &this.fields.m_terrainLitMatLightmapOn,
			//                       0LL);
			//                   }
			//                   else
			//                   {
			//                     if ( !v39 )
			//                       goto LABEL_48;
			//                     UnityEngine::Material::DisableKeyword(
			//                       this.fields.m_terrainLitMaterial,
			//                       &this.fields.m_terrainLitMatLightmapOn,
			//                       0LL);
			//                     ambientProbe = UnityEngine::RenderSettings::get_ambientProbe(&v88, 0LL);
			//                     v41 = *(_OWORD *)&ambientProbe.shr4;
			//                     *(_OWORD *)&v84.shr0 = *(_OWORD *)&ambientProbe.shr0;
			//                     v42 = *(_OWORD *)&ambientProbe.shr8;
			//                     *(_OWORD *)&v84.shr4 = v41;
			//                     v43 = *(_OWORD *)&ambientProbe.shg3;
			//                     *(_OWORD *)&v84.shr8 = v42;
			//                     v44 = *(_OWORD *)&ambientProbe.shg7;
			//                     *(_OWORD *)&v84.shg3 = v43;
			//                     v45 = *(_OWORD *)&ambientProbe.shb2;
			//                     *(_OWORD *)&v84.shg7 = v44;
			//                     *(_QWORD *)&v44 = *(_QWORD *)&ambientProbe.shb6;
			//                     *(float *)&ambientProbe = ambientProbe.shb8;
			//                     *(_QWORD *)&v84.shb6 = v44;
			//                     LODWORD(v84.shb8) = (_DWORD)ambientProbe;
			//                     *(_OWORD *)&v84.shb2 = v45;
			//                     Item = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 0, 3, 0LL);
			//                     v47 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 0, 1, 0LL);
			//                     v48 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 0, 2, 0LL);
			//                     *(float *)&v44 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 0, 0, 0LL);
			//                     *(float *)&v83.m_Buffer = Item;
			//                     *((float *)&v83.m_Buffer + 1) = v47;
			//                     *(float *)&v83.m_Length = v48;
			//                     *(float *)&v83.m_AllocatorLabel = *(float *)&v44
			//                                                     - UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(
			//                                                         &v84,
			//                                                         0,
			//                                                         6,
			//                                                         0LL);
			//                     *(NativeArray_1_Unity_Mathematics_quaternion_ *)&m_Buffer[80] = v83;
			//                     v49 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 1, 3, 0LL);
			//                     v50 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 1, 1, 0LL);
			//                     v51 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 1, 2, 0LL);
			//                     *(float *)&v44 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 1, 0, 0LL);
			//                     *(float *)&v83.m_Buffer = v49;
			//                     *((float *)&v83.m_Buffer + 1) = v50;
			//                     *(float *)&v83.m_Length = v51;
			//                     *(float *)&v83.m_AllocatorLabel = *(float *)&v44
			//                                                     - UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(
			//                                                         &v84,
			//                                                         1,
			//                                                         6,
			//                                                         0LL);
			//                     *(NativeArray_1_Unity_Mathematics_quaternion_ *)&m_Buffer[96] = v83;
			//                     v52 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 2, 3, 0LL);
			//                     v53 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 2, 1, 0LL);
			//                     v54 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 2, 2, 0LL);
			//                     *(float *)&v44 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 2, 0, 0LL);
			//                     *(float *)&v83.m_Buffer = v52;
			//                     *((float *)&v83.m_Buffer + 1) = v53;
			//                     *(float *)&v83.m_Length = v54;
			//                     *(float *)&v83.m_AllocatorLabel = *(float *)&v44
			//                                                     - UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(
			//                                                         &v84,
			//                                                         2,
			//                                                         6,
			//                                                         0LL);
			//                     *(NativeArray_1_Unity_Mathematics_quaternion_ *)&m_Buffer[112] = v83;
			//                     v55 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 0, 4, 0LL);
			//                     *(float *)&v44 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 0, 5, 0LL);
			//                     *(float *)&v83.m_Buffer = v55;
			//                     HIDWORD(v83.m_Buffer) = v44;
			//                     *(float *)&v83.m_Length = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 0, 6, 0LL)
			//                                             * 3.0;
			//                     v83.m_AllocatorLabel = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 0, 7, 0LL);
			//                     *(NativeArray_1_Unity_Mathematics_quaternion_ *)&m_Buffer[128] = v83;
			//                     v56 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 1, 4, 0LL);
			//                     *(float *)&v44 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 1, 5, 0LL);
			//                     *(float *)&v83.m_Buffer = v56;
			//                     HIDWORD(v83.m_Buffer) = v44;
			//                     *(float *)&v83.m_Length = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 1, 6, 0LL)
			//                                             * 3.0;
			//                     v83.m_AllocatorLabel = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 1, 7, 0LL);
			//                     *(NativeArray_1_Unity_Mathematics_quaternion_ *)&m_Buffer[144] = v83;
			//                     v57 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 2, 4, 0LL);
			//                     *(float *)&v44 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 2, 5, 0LL);
			//                     *(float *)&v83.m_Buffer = v57;
			//                     HIDWORD(v83.m_Buffer) = v44;
			//                     *(float *)&v83.m_Length = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 2, 6, 0LL)
			//                                             * 3.0;
			//                     v83.m_AllocatorLabel = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 2, 7, 0LL);
			//                     *(NativeArray_1_Unity_Mathematics_quaternion_ *)&m_Buffer[160] = v83;
			//                     LODWORD(v83.m_Buffer) = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 0, 8, 0LL);
			//                     HIDWORD(v83.m_Buffer) = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 1, 8, 0LL);
			//                     v83.m_Length = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v84, 2, 8, 0LL);
			//                     v83.m_AllocatorLabel = 1065353216;
			//                     *(NativeArray_1_Unity_Mathematics_quaternion_ *)&m_Buffer[176] = v83;
			//                   }
			//                   if ( !this.fields.m_perTerrainFrameDataBuffer
			//                     || (v66 = UnityEngine::ComputeBuffer::get_count(this.fields.m_perTerrainFrameDataBuffer, 0LL),
			//                         v66 != v86.m_Length) )
			//                   {
			//                     m_perTerrainFrameDataBuffer = this.fields.m_perTerrainFrameDataBuffer;
			//                     if ( m_perTerrainFrameDataBuffer )
			//                       UnityEngine::ComputeBuffer::Dispose(m_perTerrainFrameDataBuffer, 0LL);
			//                     v68 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//                     v69 = v68;
			//                     if ( !v68 )
			//                       goto LABEL_48;
			//                     UnityEngine::ComputeBuffer::ComputeBuffer(
			//                       v68,
			//                       v86.m_Length,
			//                       16,
			//                       ComputeBufferType__Enum_Constant,
			//                       ComputeBufferMode__Enum_Immutable,
			//                       0LL);
			//                     this.fields.m_perTerrainFrameDataBuffer = v69;
			//                     sub_1800054D0(
			//                       (HGRenderPathScene *)&this.fields.m_perTerrainFrameDataBuffer,
			//                       v70,
			//                       v71,
			//                       v72,
			//                       sizea,
			//                       v82);
			//                     v73 = this.fields.m_terrainLitMaterial;
			//                     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                     v74 = this.fields.m_perTerrainFrameDataBuffer;
			//                     HGTerrainPerTerrainFrame = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainPerTerrainFrame;
			//                     m_vtRenderer = v74;
			//                     if ( !v74 )
			//                       goto LABEL_48;
			//                     v76 = UnityEngine::ComputeBuffer::get_count(v74, 0LL);
			//                     m_vtRenderer = this.fields.m_perTerrainFrameDataBuffer;
			//                     v77 = v76;
			//                     if ( !m_vtRenderer )
			//                       goto LABEL_48;
			//                     v78 = UnityEngine::ComputeBuffer::get_stride((ComputeBuffer *)m_vtRenderer, 0LL);
			//                     if ( !v73 )
			//                       goto LABEL_48;
			//                     UnityEngine::Material::SetConstantBufferImpl(v73, HGTerrainPerTerrainFrame, v74, 0, v77 * v78, 0LL);
			//                   }
			//                   m_vtRenderer = this.fields.m_perTerrainFrameDataBuffer;
			//                   if ( m_vtRenderer )
			//                   {
			//                     v83 = v86;
			//                     sub_180831F20(m_vtRenderer, &v83);
			//                     return;
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_48:
			//     sub_180B536AC(m_vtRenderer, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3372, 0LL);
			//   if ( !Patch )
			//     goto LABEL_48;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1199(Patch, (Object *)this, renderConfiguration, vtCentera, 0LL);
			// }
			// 
		}

		public void SetTerrainBlendParamsGlobal(CommandBuffer cmd)
		{
			// // Void SetTerrainBlendParamsGlobal(CommandBuffer)
			// void HG::Rendering::Runtime::HGTerrainRenderer::SetTerrainBlendParamsGlobal(
			//         HGTerrainRenderer *this,
			//         CommandBuffer *cmd,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   void *m_vtRenderer; // rcx
			//   ComputeBuffer *m_perTerrainDataBuffer; // rsi
			//   int32_t HGTerrainPerTerrain; // ebp
			//   int32_t count; // eax
			//   int32_t v10; // r14d
			//   int32_t stride; // eax
			//   ComputeBuffer *m_perTerrainFrameDataBuffer; // rsi
			//   int32_t HGTerrainPerTerrainFrame; // ebp
			//   int32_t v14; // eax
			//   int32_t v15; // r14d
			//   int32_t v16; // eax
			//   HGTerrainRuntimeResources *m_runtimeResources; // rax
			//   int32_t v18; // esi
			//   HGTerrainRuntimeResources_TextureResources *textures; // rax
			//   Texture2D *lightmapColorTex; // rax
			//   RenderTargetIdentifier *v21; // rax
			//   __int64 v22; // rdx
			//   HGShaderIDs__StaticFields *static_fields; // rcx
			//   __int128 v24; // xmm1
			//   HGTerrainRuntimeResources *v25; // rax
			//   int32_t HGTerrainLightmapInd; // esi
			//   HGTerrainRuntimeResources_TextureResources *v27; // rax
			//   Texture2D *lightmapDirTex; // rax
			//   RenderTargetIdentifier *v29; // rax
			//   __int128 v30; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   RenderTargetIdentifier v32; // [rsp+30h] [rbp-68h] BYREF
			//   RenderTargetIdentifier v33; // [rsp+60h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919709 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     byte_18D919709 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3385, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3385, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)cmd,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_27;
			//   }
			//   m_vtRenderer = this.fields.m_vtRenderer;
			//   if ( !m_vtRenderer )
			//     goto LABEL_27;
			//   HG::Rendering::Runtime::VirtualTextureRenderer::SetVTTexturesGlobal((VirtualTextureRenderer *)m_vtRenderer, cmd, 0LL);
			//   if ( this.fields.m_perTerrainDataBuffer )
			//   {
			//     m_perTerrainDataBuffer = this.fields.m_perTerrainDataBuffer;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     HGTerrainPerTerrain = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainPerTerrain;
			//     m_vtRenderer = this.fields.m_perTerrainDataBuffer;
			//     if ( !m_vtRenderer )
			//       goto LABEL_27;
			//     count = UnityEngine::ComputeBuffer::get_count((ComputeBuffer *)m_vtRenderer, 0LL);
			//     m_vtRenderer = this.fields.m_perTerrainDataBuffer;
			//     v10 = count;
			//     if ( !m_vtRenderer )
			//       goto LABEL_27;
			//     stride = UnityEngine::ComputeBuffer::get_stride((ComputeBuffer *)m_vtRenderer, 0LL);
			//     if ( !cmd )
			//       goto LABEL_27;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal(
			//       cmd,
			//       m_perTerrainDataBuffer,
			//       HGTerrainPerTerrain,
			//       0,
			//       v10 * stride,
			//       0LL);
			//   }
			//   if ( this.fields.m_perTerrainFrameDataBuffer )
			//   {
			//     m_perTerrainFrameDataBuffer = this.fields.m_perTerrainFrameDataBuffer;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     HGTerrainPerTerrainFrame = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainPerTerrainFrame;
			//     m_vtRenderer = this.fields.m_perTerrainFrameDataBuffer;
			//     if ( m_vtRenderer )
			//     {
			//       v14 = UnityEngine::ComputeBuffer::get_count((ComputeBuffer *)m_vtRenderer, 0LL);
			//       m_vtRenderer = this.fields.m_perTerrainFrameDataBuffer;
			//       v15 = v14;
			//       if ( m_vtRenderer )
			//       {
			//         v16 = UnityEngine::ComputeBuffer::get_stride((ComputeBuffer *)m_vtRenderer, 0LL);
			//         if ( cmd )
			//         {
			//           UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal(
			//             cmd,
			//             m_perTerrainFrameDataBuffer,
			//             HGTerrainPerTerrainFrame,
			//             0,
			//             v15 * v16,
			//             0LL);
			//           goto LABEL_15;
			//         }
			//       }
			//     }
			// LABEL_27:
			//     sub_180B536AC(m_vtRenderer, v5);
			//   }
			// LABEL_15:
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//   m_vtRenderer = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//   m_runtimeResources = this.fields.m_runtimeResources;
			//   v18 = *((_DWORD *)m_vtRenderer + 164);
			//   if ( !m_runtimeResources )
			//     goto LABEL_27;
			//   textures = m_runtimeResources.fields.textures;
			//   if ( !textures )
			//     goto LABEL_27;
			//   lightmapColorTex = textures.fields.lightmapColorTex;
			//   if ( !lightmapColorTex )
			//     lightmapColorTex = UnityEngine::Texture2D::get_blackTexture(0LL);
			//   v21 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v33, (Texture *)lightmapColorTex, 0LL);
			//   if ( !cmd )
			//     goto LABEL_25;
			//   v24 = *(_OWORD *)&v21.m_BufferPointer;
			//   *(_OWORD *)&v32.m_Type = *(_OWORD *)&v21.m_Type;
			//   *(_QWORD *)&v32.m_DepthSlice = *(_QWORD *)&v21.m_DepthSlice;
			//   *(_OWORD *)&v32.m_BufferPointer = v24;
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, v18, &v32, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//   static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//   v25 = this.fields.m_runtimeResources;
			//   HGTerrainLightmapInd = static_fields._HGTerrainLightmapInd;
			//   if ( !v25 || (v27 = v25.fields.textures) == 0LL )
			// LABEL_25:
			//     sub_180B536AC(static_fields, v22);
			//   lightmapDirTex = v27.fields.lightmapDirTex;
			//   if ( !lightmapDirTex )
			//     lightmapDirTex = UnityEngine::Texture2D::get_blackTexture(0LL);
			//   v29 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v33, (Texture *)lightmapDirTex, 0LL);
			//   v30 = *(_OWORD *)&v29.m_BufferPointer;
			//   *(_OWORD *)&v32.m_Type = *(_OWORD *)&v29.m_Type;
			//   *(_QWORD *)&v32.m_DepthSlice = *(_QWORD *)&v29.m_DepthSlice;
			//   *(_OWORD *)&v32.m_BufferPointer = v30;
			//   UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, HGTerrainLightmapInd, &v32, 0LL);
			// }
			// 
		}

		private ushort _ClampLevel(int level)
		{
			// // UInt16 _ClampLevel(Int32)
			// uint16_t HG::Rendering::Runtime::HGTerrainRenderer::_ClampLevel(
			//         HGTerrainRenderer *this,
			//         int32_t level,
			//         MethodInfo *method)
			// {
			//   int m_treeDepth; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( !byte_18D91970A )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D91970A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3326, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3326, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_47(
			//              (ILFixDynamicMethodWrapper_20 *)Patch,
			//              (Object *)this,
			//              level,
			//              0LL);
			//   }
			//   else
			//   {
			//     m_treeDepth = this.fields.m_treeDepth;
			//     sub_180002C70(TypeInfo::System::Math);
			//     if ( m_treeDepth - 1 <= level )
			//       LOWORD(level) = m_treeDepth - 1;
			//     return level;
			//   }
			// }
			// 
			return 0;
		}

		private void _UpdateGeometry(int currIndex, in Vector3 viewPoint, ref NativeList<ValueTuple<int, float>> nodeList)
		{
			// // Void _UpdateGeometry(Int32, Vector3 ByRef, NativeList`1[System.ValueTuple`2[Int32,Single]] ByRef)
			// void HG::Rendering::Runtime::HGTerrainRenderer::_UpdateGeometry(
			//         HGTerrainRenderer *this,
			//         int32_t currIndex,
			//         Vector3 *viewPoint,
			//         NativeList_1_System_ValueTuple_2_Int32_Single_ *nodeList,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdi
			//   __int64 v9; // rdx
			//   HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // rcx
			//   __int64 v11; // r14
			//   float v12; // xmm0_4
			//   uint16_t v13; // r12
			//   MethodInfo *v14; // r9
			//   Void *m_Buffer; // rcx
			//   Void *v16; // rax
			//   __m128 v17; // xmm2
			//   Void *v18; // rcx
			//   float v19; // xmm1_4
			//   Vector3 *v20; // rax
			//   __int64 v21; // xmm3_8
			//   double v22; // xmm0_8
			//   int v23; // edi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 value; // [rsp+30h] [rbp-30h] BYREF
			//   Vector3 v26; // [rsp+40h] [rbp-20h] BYREF
			//   Vector3 v27; // [rsp+50h] [rbp-10h] BYREF
			// 
			//   v7 = currIndex;
			//   if ( !byte_18D91970B )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::Add);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<int,float>::ValueTuple);
			//     byte_18D91970B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3341, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3341, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1190(Patch, (Object *)this, v7, viewPoint, nodeList, 0LL);
			//       return;
			//     }
			// LABEL_17:
			//     sub_180B536AC(m_chunkNodes, v9);
			//   }
			//   if ( !*(_DWORD *)&this.fields.m_visibility.m_Buffer[4 * v7] )
			//     return;
			//   m_chunkNodes = this.fields.m_chunkNodes;
			//   if ( !m_chunkNodes )
			//     goto LABEL_17;
			//   v11 = sub_1803EEC28(m_chunkNodes, v7);
			//   v12 = HG::Rendering::Runtime::HGTerrainRenderer::_DistFromAABBToPoint(this, viewPoint, v7, 0LL);
			//   v13 = HG::Rendering::Runtime::HGTerrainRenderer::_ComputeChunkedLod(this, v12, 0LL);
			//   if ( HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::CheckSplit((HGTerrainRenderer_ChunkNode *)v11, v13, 0LL) )
			//   {
			//     HG::Rendering::Runtime::HGTerrainRenderer::_SplitGeometry(this, v7, viewPoint, 0LL);
			//     v23 = 0;
			//     while ( 1 )
			//     {
			//       m_chunkNodes = *(HGTerrainRenderer_ChunkNode__Array **)(v11 + 16);
			//       if ( !m_chunkNodes )
			//         break;
			//       if ( (unsigned int)v23 >= m_chunkNodes.max_length.size )
			//         sub_180070270(m_chunkNodes, v9);
			//       HG::Rendering::Runtime::HGTerrainRenderer::_UpdateGeometry(
			//         this,
			//         *((__int16 *)&m_chunkNodes.vector[0].transform.x + v23++),
			//         viewPoint,
			//         nodeList,
			//         0LL);
			//       if ( v23 >= 4 )
			//         return;
			//     }
			//     goto LABEL_17;
			//   }
			//   if ( (*(_WORD *)(v11 + 28) & 0xFF00) == 0 )
			//     HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::ClampAndSaveMorph(
			//       (HGTerrainRenderer_ChunkNode *)v11,
			//       v13,
			//       0LL);
			//   m_Buffer = this.fields._centerYs_k__BackingField.m_Buffer;
			//   v16 = this.fields._centerXs_k__BackingField.m_Buffer;
			//   *(_QWORD *)&value.x = *(_QWORD *)&viewPoint.x;
			//   v17 = (__m128)*(unsigned int *)&m_Buffer[4 * v7];
			//   v18 = this.fields._centerZs_k__BackingField.m_Buffer;
			//   *(_QWORD *)&v26.x = _mm_unpacklo_ps((__m128)*(_DWORD *)&v16[4 * v7], v17).m128_u64[0];
			//   v19 = *(float *)&v18[4 * v7];
			//   value.z = viewPoint.z;
			//   v26.z = v19;
			//   v20 = UnityEngine::Vector3::op_Subtraction(&v27, &v26, &value, v14);
			//   v21 = *(_QWORD *)&v20.x;
			//   *(float *)&v20 = v20.z;
			//   *(_QWORD *)&v26.x = v21;
			//   LODWORD(v26.z) = (_DWORD)v20;
			//   v22 = sub_18238EFA0(&v26);
			//   *(_DWORD *)(v11 + 32) = LODWORD(v22);
			//   LODWORD(value.x) = v7;
			//   value.y = HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::GetMorphValue((HGTerrainRenderer_ChunkNode *)v11, 0LL);
			//   Unity::Collections::NativeList<BeyondDynamicBone::VirtualMesh::BaseLineWork>::Add(
			//     (NativeList_1_BeyondDynamicBone_VirtualMesh_BaseLineWork_ *)nodeList,
			//     (VirtualMesh_BaseLineWork *)&value,
			//     MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::Add);
			// }
			// 
		}

		private void _SplitGeometry(int currIndex, in Vector3 viewPoint)
		{
			// // Void _SplitGeometry(Int32, Vector3 ByRef)
			// void HG::Rendering::Runtime::HGTerrainRenderer::_SplitGeometry(
			//         HGTerrainRenderer *this,
			//         int32_t currIndex,
			//         Vector3 *viewPoint,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rbx
			//   __int64 v7; // rdx
			//   HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // rcx
			//   HGTerrainRenderer_ChunkNode *v9; // rax
			//   Void *m_Buffer; // rcx
			//   HGTerrainRenderer_ChunkNode *v11; // rbp
			//   unsigned int v12; // r14d
			//   Int16__Array *children; // rdi
			//   HGTerrainRenderer_ChunkNode__Array *v14; // r12
			//   __int64 v15; // rdi
			//   float v16; // xmm0_4
			//   uint16_t v17; // bx
			//   HGTerrainRenderer_ChunkNode *v18; // rax
			//   int32_t v19; // ebx
			//   int32_t parent; // edx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v4 = currIndex;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3346, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3346, 0LL);
			//     if ( !Patch )
			//       goto LABEL_18;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1188(Patch, (Object *)this, v4, viewPoint, 0LL);
			//   }
			//   else
			//   {
			//     m_chunkNodes = this.fields.m_chunkNodes;
			//     if ( !m_chunkNodes )
			//       goto LABEL_18;
			//     v9 = (HGTerrainRenderer_ChunkNode *)sub_1803EEC28(m_chunkNodes, v4);
			//     m_Buffer = this.fields.m_splits.m_Buffer;
			//     v11 = v9;
			//     if ( !*(_BYTE *)&m_Buffer[v4] )
			//     {
			//       m_Buffer[v4] = (Void)1;
			//       if ( HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::HasChildren(v9, 0LL) )
			//       {
			//         v12 = 0;
			//         while ( 1 )
			//         {
			//           children = v11.children;
			//           if ( !children )
			//             break;
			//           if ( v12 >= children.max_length.size )
			//             sub_180070270(m_chunkNodes, v7);
			//           v14 = this.fields.m_chunkNodes;
			//           if ( !v14 )
			//             break;
			//           v15 = children.vector[v12];
			//           v16 = HG::Rendering::Runtime::HGTerrainRenderer::_DistFromAABBToPoint(this, viewPoint, v15, 0LL);
			//           v17 = HG::Rendering::Runtime::HGTerrainRenderer::_ComputeChunkedLod(this, v16, 0LL);
			//           v18 = (HGTerrainRenderer_ChunkNode *)sub_1803EEC28(v14, v15);
			//           HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::ClampAndSaveMorph(v18, v17, 0LL);
			//           if ( (int)++v12 >= 4 )
			//             goto LABEL_10;
			//         }
			// LABEL_18:
			//         sub_180B536AC(m_chunkNodes, v7);
			//       }
			//     }
			// LABEL_10:
			//     LOWORD(v19) = v11.parent;
			//     if ( (_WORD)v19 != 0xFFFF )
			//     {
			//       parent = v11.parent;
			//       do
			//       {
			//         if ( this.fields.m_splits.m_Buffer[(__int16)v19] )
			//           break;
			//         HG::Rendering::Runtime::HGTerrainRenderer::_SplitGeometry(this, parent, viewPoint, 0LL);
			//         m_chunkNodes = this.fields.m_chunkNodes;
			//         if ( !m_chunkNodes )
			//           goto LABEL_18;
			//         v19 = *(__int16 *)(sub_1803EEC28(m_chunkNodes, (__int16)v19) + 24);
			//         parent = v19;
			//       }
			//       while ( v19 != -1 );
			//     }
			//   }
			// }
			// 
		}

		private void _ComputeLodMax(int cameraWidth, float tanHalfHorizFov)
		{
			// // Void _ComputeLodMax(Int32, Single)
			// void HG::Rendering::Runtime::HGTerrainRenderer::_ComputeLodMax(
			//         HGTerrainRenderer *this,
			//         int32_t cameraWidth,
			//         float tanHalfHorizFov,
			//         MethodInfo *method)
			// {
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   HGTerrainConfiguration *m_configuration; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3340, 0LL) )
			//   {
			//     m_configuration = this.fields.m_configuration;
			//     if ( m_configuration )
			//     {
			//       this.fields.m_geoLodMax = (float)((float)((float)cameraWidth / tanHalfHorizFov) * this.fields.m_geometryError)
			//                                / m_configuration.fields.chunkedLodPixelError;
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3340, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_180(
			//     (ILFixDynamicMethodWrapper_7 *)Patch,
			//     (Object *)this,
			//     cameraWidth,
			//     tanHalfHorizFov,
			//     0LL);
			// }
			// 
		}

		private ushort _ComputeChunkedLod(float dist)
		{
			// // UInt16 _ComputeChunkedLod(Single)
			// uint16_t HG::Rendering::Runtime::HGTerrainRenderer::_ComputeChunkedLod(
			//         HGTerrainRenderer *this,
			//         float dist,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   __int64 v6; // r8
			//   int m_treeDepth; // ebx
			//   double v8; // xmm0_8
			//   float v9; // xmm6_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			// 
			//   if ( !byte_18D91970C )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D91970C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3343, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3343, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_194(
			//              (ILFixDynamicMethodWrapper_7 *)Patch,
			//              (Object *)this,
			//              dist,
			//              0LL);
			//   }
			//   else
			//   {
			//     m_treeDepth = this.fields.m_treeDepth;
			//     v8 = sub_182376F20(v5, v4, v6);
			//     v9 = *(float *)&v8;
			//     sub_180002C70(TypeInfo::System::Math);
			//     return sub_182ACC210((unsigned int)((m_treeDepth << 8) - (int)(float)(v9 * 256.0) - 1), 0LL, 0xFFFFLL);
			//   }
			// }
			// 
			return 0;
		}

		private float _DistFromAABBToPoint(in Vector3 viewPoint, int index)
		{
			// // Single _DistFromAABBToPoint(Vector3 ByRef, Int32)
			// float HG::Rendering::Runtime::HGTerrainRenderer::_DistFromAABBToPoint(
			//         HGTerrainRenderer *this,
			//         Vector3 *viewPoint,
			//         int32_t index,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rbx
			//   Void *m_Buffer; // rax
			//   __m128 v8; // xmm4
			//   __m128 v9; // xmm2
			//   float v10; // xmm1_4
			//   float v11; // xmm3_4
			//   Void *v12; // rcx
			//   float z; // edx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   Vector3 point; // [rsp+30h] [rbp-38h] BYREF
			//   Vector3 bExtent; // [rsp+40h] [rbp-28h] BYREF
			//   Vector3 bCenter; // [rsp+50h] [rbp-18h] BYREF
			// 
			//   v5 = index;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3342, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3342, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, v16);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1183(Patch, (Object *)this, viewPoint, v5, 0LL);
			//   }
			//   else
			//   {
			//     m_Buffer = this.fields._centerXs_k__BackingField.m_Buffer;
			//     v8 = (__m128)*(unsigned int *)&this.fields._centerYs_k__BackingField.m_Buffer[4 * v5];
			//     v9 = (__m128)*(unsigned int *)&this.fields._extentYs_k__BackingField.m_Buffer[4 * v5];
			//     v10 = *(float *)&this.fields._extentZs_k__BackingField.m_Buffer[4 * v5];
			//     v11 = *(float *)&this.fields._centerZs_k__BackingField.m_Buffer[4 * v5];
			//     v12 = this.fields._extentXs_k__BackingField.m_Buffer;
			//     z = viewPoint.z;
			//     *(_QWORD *)&point.x = *(_QWORD *)&viewPoint.x;
			//     point.z = z;
			//     *(_QWORD *)&bExtent.x = _mm_unpacklo_ps((__m128)*(_DWORD *)&v12[4 * v5], v9).m128_u64[0];
			//     *(_QWORD *)&bCenter.x = _mm_unpacklo_ps((__m128)*(_DWORD *)&m_Buffer[4 * v5], v8).m128_u64[0];
			//     bExtent.z = v10;
			//     bCenter.z = v11;
			//     return UnityEngine::GeometryUtility::DistFromAABBToPoint_Injected(&bCenter, &bExtent, &point, 0LL);
			//   }
			// }
			// 
			return 0f;
		}

		public void RenderFixedLevel(int l, CommandBuffer cmd, in Nullable<RenderStateBlock> renderStateBlock)
		{
			// // Void RenderFixedLevel(Int32, CommandBuffer, Nullable`1[UnityEngine.Rendering.RenderStateBlock] ByRef)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGTerrainRenderer::RenderFixedLevel(
			//         HGTerrainRenderer *this,
			//         int32_t l,
			//         CommandBuffer *cmd,
			//         Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *renderStateBlock,
			//         MethodInfo *method)
			// {
			//   uint16_t v9; // ax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rdx
			//   float startTime; // ebx
			//   MaterialPropertyBlock *m_perDrawBlock; // rcx
			//   MaterialPropertyBlock *v15; // rsi
			//   __int64 v16; // rdx
			//   int32_t HGTerrainChunkTransform; // r12d
			//   HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // rcx
			//   _OWORD *v19; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   __int64 v22; // rdx
			//   HGShaderIDs__StaticFields *static_fields; // rcx
			//   Mesh *chunkMesh; // rsi
			//   Matrix4x4 *v25; // rax
			//   __int64 v26; // rdx
			//   MaterialPropertyBlock *v27; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   NativeArray_1_System_ValueTuple_2_Int32_Single_ value; // [rsp+50h] [rbp-168h] BYREF
			//   __int128 v32; // [rsp+60h] [rbp-158h]
			//   AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle v33; // [rsp+70h] [rbp-148h]
			//   Matrix4x4 v34; // [rsp+80h] [rbp-138h] BYREF
			//   NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ v35; // [rsp+C0h] [rbp-F8h] BYREF
			//   Il2CppExceptionWrapper *v36; // [rsp+E0h] [rbp-D8h] BYREF
			//   Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v37; // [rsp+F0h] [rbp-C8h] BYREF
			//   _BYTE v38[64]; // [rsp+160h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D91970D )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::TryGetValue);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::MoveNext);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::GetEnumerator);
			//     byte_18D91970D = 1;
			//   }
			//   value = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3387, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3387, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v30, v29);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1200(Patch, (Object *)this, l, (Object *)cmd, renderStateBlock, 0LL);
			//   }
			//   else
			//   {
			//     v9 = HG::Rendering::Runtime::HGTerrainRenderer::_ClampLevel(this, l, 0LL);
			//     if ( !this.fields.m_fixedLevelRenderData )
			//       sub_180B536AC(v11, v10);
			//     if ( System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::TryGetValue(
			//            this.fields.m_fixedLevelRenderData,
			//            v9,
			//            &value,
			//            MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::TryGetValue) )
			//     {
			//       Unity::Collections::NativeArray_1_T_::ReadOnly<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::GetEnumerator(
			//         (NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&v34,
			//         (NativeArray_1_T_ReadOnly_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&value,
			//         MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::GetEnumerator);
			//       v35.m_Array = *(NativeArray_1_T_ReadOnly_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&v34.m00;
			//       *(_OWORD *)&v35.m_Index = *(_OWORD *)&v34.m01;
			//       value.m_Buffer = 0LL;
			//       *(_QWORD *)&value.m_Length = &v35;
			//       try
			//       {
			//         while ( Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::MoveNext(
			//                   &v35,
			//                   MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::MoveNext) )
			//         {
			//           startTime = v35.value.startTime;
			//           v33 = v35.value;
			//           m_perDrawBlock = this.fields.m_perDrawBlock;
			//           if ( !m_perDrawBlock )
			//             sub_1802DC2C8(0LL, v12);
			//           UnityEngine::MaterialPropertyBlock::Clear(m_perDrawBlock, 1, 0LL);
			//           v15 = this.fields.m_perDrawBlock;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//           HGTerrainChunkTransform = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainChunkTransform;
			//           m_chunkNodes = this.fields.m_chunkNodes;
			//           if ( !m_chunkNodes )
			//             sub_1802DC2C8(0LL, v16);
			//           v19 = (_OWORD *)sub_1803EEC28(m_chunkNodes, SLODWORD(startTime));
			//           if ( !v15 )
			//             sub_1802DC2C8(v21, v20);
			//           *(_OWORD *)&v34.m00 = *v19;
			//           UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(v15, HGTerrainChunkTransform, (Vector4 *)&v34, 0LL);
			//           static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//           *(_QWORD *)&v32 = 0LL;
			//           *((_QWORD *)&v32 + 1) = (unsigned int)v33.type;
			//           if ( !this.fields.m_perDrawBlock )
			//             sub_1802DC2C8(static_fields, v22);
			//           *(_OWORD *)&v34.m00 = v32;
			//           UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
			//             this.fields.m_perDrawBlock,
			//             static_fields._HGTerrainChunkParam0,
			//             (Vector4 *)&v34,
			//             0LL);
			//           chunkMesh = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkMesh(this, 0LL);
			//           v25 = (Matrix4x4 *)sub_182805160(v38);
			//           v27 = this.fields.m_perDrawBlock;
			//           if ( !cmd )
			//             sub_1802DC2C8(v27, v26);
			//           v37 = *renderStateBlock;
			//           v34 = *v25;
			//           UnityEngine::Rendering::CommandBuffer::DrawMesh(
			//             cmd,
			//             chunkMesh,
			//             &v34,
			//             this.fields.m_terrainLitMaterial,
			//             SLODWORD(startTime),
			//             2,
			//             v27,
			//             &v37,
			//             0LL);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v36 )
			//       {
			//         value.m_Buffer = (Void *)v36.ex;
			//         if ( value.m_Buffer )
			//           sub_18000F780(value.m_Buffer);
			//       }
			//     }
			//   }
			// }
			// 
		}

		public void RenderNodeList(NativeList<ValueTuple<int, float>> nodeList, CommandBuffer cmd, in Nullable<RenderStateBlock> renderStateBlock)
		{
			// // Void RenderNodeList(NativeList`1[System.ValueTuple`2[Int32,Single]], CommandBuffer, Nullable`1[UnityEngine.Rendering.RenderStateBlock] ByRef)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGTerrainRenderer::RenderNodeList(
			//         HGTerrainRenderer *this,
			//         NativeList_1_System_ValueTuple_2_Int32_Single_ *nodeList,
			//         CommandBuffer *cmd,
			//         Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *renderStateBlock,
			//         MethodInfo *method)
			// {
			//   NativeList_1_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *v7; // rsi
			//   __int64 v9; // rdx
			//   float startTime; // ebx
			//   MaterialPropertyBlock *m_perDrawBlock; // rcx
			//   MaterialPropertyBlock *v12; // r14
			//   __int64 v13; // rdx
			//   int32_t HGTerrainChunkTransform; // r13d
			//   HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // rcx
			//   _OWORD *v16; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   __int64 v19; // rdx
			//   HGShaderIDs__StaticFields *static_fields; // rcx
			//   Mesh *chunkMesh; // r14
			//   Matrix4x4 *v22; // rax
			//   __int64 v23; // rdx
			//   MaterialPropertyBlock *v24; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   __int128 v28; // [rsp+50h] [rbp-178h]
			//   unsigned int type; // [rsp+64h] [rbp-164h]
			//   Il2CppException *ex; // [rsp+68h] [rbp-160h]
			//   Matrix4x4 value; // [rsp+80h] [rbp-148h] BYREF
			//   NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ v32; // [rsp+C0h] [rbp-108h] BYREF
			//   Il2CppExceptionWrapper *v33; // [rsp+E0h] [rbp-E8h] BYREF
			//   Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v34; // [rsp+F0h] [rbp-D8h] BYREF
			//   _BYTE v35[64]; // [rsp+160h] [rbp-68h] BYREF
			// 
			//   v7 = (NativeList_1_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)nodeList;
			//   if ( !byte_18D91970E )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::MoveNext);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::GetEnumerator);
			//     byte_18D91970E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3388, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3388, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v27, v26);
			//     *(NativeList_1_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&value.m00 = *v7;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1201(
			//       Patch,
			//       (Object *)this,
			//       (NativeList_1_System_ValueTuple_2_Int32_Single_ *)&value,
			//       (Object *)cmd,
			//       renderStateBlock,
			//       0LL);
			//   }
			//   else
			//   {
			//     Unity::Collections::NativeList<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::GetEnumerator(
			//       (NativeArray_1_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&value,
			//       v7,
			//       MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::GetEnumerator);
			//     v32.m_Array = *(NativeArray_1_T_ReadOnly_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&value.m00;
			//     *(_OWORD *)&v32.m_Index = *(_OWORD *)&value.m01;
			//     try
			//     {
			//       while ( Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::MoveNext(
			//                 &v32,
			//                 MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::MoveNext) )
			//       {
			//         startTime = v32.value.startTime;
			//         type = v32.value.type;
			//         m_perDrawBlock = this.fields.m_perDrawBlock;
			//         if ( !m_perDrawBlock )
			//           sub_1802DC2C8(0LL, v9);
			//         UnityEngine::MaterialPropertyBlock::Clear(m_perDrawBlock, 1, 0LL);
			//         v12 = this.fields.m_perDrawBlock;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         HGTerrainChunkTransform = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainChunkTransform;
			//         m_chunkNodes = this.fields.m_chunkNodes;
			//         if ( !m_chunkNodes )
			//           sub_1802DC2C8(0LL, v13);
			//         v16 = (_OWORD *)sub_1803EEC28(m_chunkNodes, SLODWORD(startTime));
			//         if ( !v12 )
			//           sub_1802DC2C8(v18, v17);
			//         *(_OWORD *)&value.m00 = *v16;
			//         UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(v12, HGTerrainChunkTransform, (Vector4 *)&value, 0LL);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         *(_QWORD *)&v28 = 0LL;
			//         *((_QWORD *)&v28 + 1) = type;
			//         if ( !this.fields.m_perDrawBlock )
			//           sub_1802DC2C8(static_fields, v19);
			//         *(_OWORD *)&value.m00 = v28;
			//         UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
			//           this.fields.m_perDrawBlock,
			//           static_fields._HGTerrainChunkParam0,
			//           (Vector4 *)&value,
			//           0LL);
			//         chunkMesh = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkMesh(this, 0LL);
			//         v22 = (Matrix4x4 *)sub_182805160(v35);
			//         v24 = this.fields.m_perDrawBlock;
			//         if ( !cmd )
			//           sub_1802DC2C8(v24, v23);
			//         v34 = *renderStateBlock;
			//         value = *v22;
			//         UnityEngine::Rendering::CommandBuffer::DrawMesh(
			//           cmd,
			//           chunkMesh,
			//           &value,
			//           this.fields.m_terrainLitMaterial,
			//           SLODWORD(startTime),
			//           2,
			//           v24,
			//           &v34,
			//           0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v33 )
			//     {
			//       ex = v33.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v7 = (NativeList_1_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)nodeList;
			//     }
			//     Unity::Collections::NativeList<System::ValueTuple<int,float>>::Dispose(
			//       (NativeList_1_System_ValueTuple_2_Int32_Single_ *)v7,
			//       MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::Dispose);
			//   }
			// }
			// 
		}

		public void RenderScreenSpaceTerrain(CommandBuffer cmd)
		{
			// // Void RenderScreenSpaceTerrain(CommandBuffer)
			// void HG::Rendering::Runtime::HGTerrainRenderer::RenderScreenSpaceTerrain(
			//         HGTerrainRenderer *this,
			//         CommandBuffer *cmd,
			//         MethodInfo *method)
			// {
			//   Material *m_terrainLitMaterial; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !byte_18D91970F )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     byte_18D91970F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3389, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3389, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)cmd,
			//       0LL);
			//   }
			//   else
			//   {
			//     m_terrainLitMaterial = this.fields.m_terrainLitMaterial;
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, m_terrainLitMaterial, 0LL, 6, 0LL);
			//   }
			// }
			// 
		}

		public void Render(int cameraGuid, CommandBuffer cmd, HGTerrainRenderer.TerrainPassType passType, bool enableTessellation, in Nullable<RenderStateBlock> renderStateBlock)
		{
			// // Void Render(Int32, CommandBuffer, HGTerrainRenderer+TerrainPassType, Boolean, Nullable`1[UnityEngine.Rendering.RenderStateBlock] ByRef)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGTerrainRenderer::Render(
			//         HGTerrainRenderer *this,
			//         int32_t cameraGuid,
			//         CommandBuffer *cmd,
			//         HGTerrainRenderer_TerrainPassType__Enum passType,
			//         bool enableTessellation,
			//         Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *renderStateBlock,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // r15
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   VirtualTextureRenderer *m_vtRenderer; // rbx
			//   Object_1 *m_deformableControlMap; // rbx
			//   Material *m_terrainLitMaterial; // rbx
			//   __int64 v18; // rdx
			//   HGShaderIDs__StaticFields *static_fields; // rcx
			//   int32_t HGTerrainDeformableControlMap; // r12d
			//   VirtualTextureRenderer *v21; // r14
			//   Texture2D *blackTexture; // r14
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   __int64 v25; // rdx
			//   float startTime; // ebx
			//   MaterialPropertyBlock *m_perDrawBlock; // rcx
			//   MaterialPropertyBlock *v28; // r14
			//   __int64 v29; // rdx
			//   int32_t HGTerrainChunkTransform; // r12d
			//   HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // rcx
			//   _OWORD *v32; // rax
			//   __int64 v33; // rdx
			//   __int64 v34; // rcx
			//   __int64 v35; // rdx
			//   MaterialPropertyBlock *v36; // r14
			//   int32_t HGTerrainChunkParam0; // r12d
			//   HGTerrainRenderer_ChunkNode__Array *v38; // rcx
			//   __int64 v39; // rax
			//   __int64 v40; // rdx
			//   __int64 v41; // rcx
			//   __int64 v42; // rdx
			//   __int64 v43; // r8
			//   __int64 v44; // r9
			//   HGTerrainRenderer__StaticFields *v45; // rcx
			//   HGTerrainRenderer_TerrainPassType__Enum__Array *tessellationPassTypeMapping; // rax
			//   HGTerrainRenderer_ChunkNode__Array *v47; // rcx
			//   HGTerrainRenderer_ChunkNode *v48; // rax
			//   Mesh *m_tessellationQuadMesh; // r12
			//   __int128 *v50; // rax
			//   __int128 v51; // xmm6
			//   __int128 v52; // xmm7
			//   __int128 v53; // xmm8
			//   __int128 v54; // xmm9
			//   Material *v55; // r13
			//   __int64 v56; // rdx
			//   __int64 v57; // r8
			//   __int64 v58; // r9
			//   HGTerrainRenderer__StaticFields *v59; // rcx
			//   HGTerrainRenderer_TerrainPassType__Enum__Array *v60; // rax
			//   HGTerrainRenderer_TerrainPassType__Enum v61; // ebx
			//   MaterialPropertyBlock *v62; // r14
			//   __int64 v63; // rdx
			//   __int64 v64; // rcx
			//   CommandBuffer *v65; // rax
			//   Material *v66; // r9
			//   Mesh *v67; // rdx
			//   Mesh *chunkMesh; // r13
			//   Matrix4x4 *v69; // r14
			//   MaterialPropertyBlock *v70; // r12
			//   __int64 v71; // rdx
			//   __int64 v72; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v74; // rdx
			//   __int64 v75; // rcx
			//   HGTerrainRenderer_TerrainPassType__Enum P3; // [rsp+20h] [rbp-278h]
			//   bool P4[4]; // [rsp+28h] [rbp-270h]
			//   MaterialPropertyBlock *P5; // [rsp+30h] [rbp-268h]
			//   Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *v79; // [rsp+38h] [rbp-260h]
			//   NativeList_1_System_ValueTuple_2_Int32_Single_ value; // [rsp+50h] [rbp-248h] BYREF
			//   __int128 v81; // [rsp+60h] [rbp-238h]
			//   Matrix4x4 v82; // [rsp+70h] [rbp-228h] BYREF
			//   AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle v83; // [rsp+B0h] [rbp-1E8h]
			//   NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ v84; // [rsp+B8h] [rbp-1E0h] BYREF
			//   __int128 v85; // [rsp+E0h] [rbp-1B8h] BYREF
			//   __int128 v86; // [rsp+F0h] [rbp-1A8h]
			//   __int128 v87; // [rsp+100h] [rbp-198h]
			//   __int128 v88; // [rsp+110h] [rbp-188h]
			//   __int128 v89; // [rsp+120h] [rbp-178h]
			//   __int128 v90; // [rsp+130h] [rbp-168h]
			//   __int128 v91; // [rsp+140h] [rbp-158h]
			//   Il2CppExceptionWrapper *v92; // [rsp+150h] [rbp-148h] BYREF
			//   _OWORD v93[7]; // [rsp+160h] [rbp-138h] BYREF
			//   _OWORD v94[11]; // [rsp+1D0h] [rbp-C8h] BYREF
			// 
			//   v7 = passType;
			//   if ( !byte_18D919710 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::TryGetValue);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::MoveNext);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainRenderer);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919710 = 1;
			//   }
			//   value = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3390, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3390, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v75, v74);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1202(
			//       Patch,
			//       (Object *)this,
			//       cameraGuid,
			//       (Object *)cmd,
			//       (HGTerrainRenderer_TerrainPassType__Enum)v7,
			//       enableTessellation,
			//       renderStateBlock,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !this.fields.m_cameraRenderData )
			//       sub_180B536AC(v12, v11);
			//     if ( System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::TryGetValue(
			//            this.fields.m_cameraRenderData,
			//            cameraGuid,
			//            &value,
			//            MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::TryGetValue) )
			//     {
			//       if ( !enableTessellation )
			//         goto LABEL_12;
			//       m_vtRenderer = this.fields.m_vtRenderer;
			//       if ( !m_vtRenderer )
			//         sub_180B536AC(v14, v13);
			//       m_deformableControlMap = (Object_1 *)m_vtRenderer.fields.m_deformableControlMap;
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       if ( UnityEngine::Object::op_Inequality(m_deformableControlMap, 0LL, 0LL) )
			//       {
			//         m_terrainLitMaterial = this.fields.m_terrainLitMaterial;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         HGTerrainDeformableControlMap = static_fields._HGTerrainDeformableControlMap;
			//         v21 = this.fields.m_vtRenderer;
			//         if ( !v21 )
			//           sub_180B536AC(static_fields, v18);
			//         blackTexture = v21.fields.m_deformableControlMap;
			//         if ( !m_terrainLitMaterial )
			//           sub_180B536AC(static_fields, v18);
			//       }
			//       else
			//       {
			// LABEL_12:
			//         m_terrainLitMaterial = this.fields.m_terrainLitMaterial;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         HGTerrainDeformableControlMap = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainDeformableControlMap;
			//         blackTexture = UnityEngine::Texture2D::get_blackTexture(0LL);
			//         if ( !m_terrainLitMaterial )
			//           sub_180B536AC(v24, v23);
			//       }
			//       UnityEngine::Material::SetTextureImpl(
			//         m_terrainLitMaterial,
			//         HGTerrainDeformableControlMap,
			//         (Texture *)blackTexture,
			//         0LL);
			//       Unity::Collections::NativeList<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::GetEnumerator(
			//         (NativeArray_1_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&v82,
			//         (NativeList_1_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&value,
			//         MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::GetEnumerator);
			//       v84.m_Array = *(NativeArray_1_T_ReadOnly_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&v82.m00;
			//       *(_OWORD *)&v84.m_Index = *(_OWORD *)&v82.m01;
			//       value.m_ListData = 0LL;
			//       *(_QWORD *)&value.m_DeprecatedAllocator.Index = &v84;
			//       try
			//       {
			//         while ( Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::MoveNext(
			//                   &v84,
			//                   MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::MoveNext) )
			//         {
			//           startTime = v84.value.startTime;
			//           v83 = v84.value;
			//           m_perDrawBlock = this.fields.m_perDrawBlock;
			//           if ( !m_perDrawBlock )
			//             sub_1802DC2C8(0LL, v25);
			//           UnityEngine::MaterialPropertyBlock::Clear(m_perDrawBlock, 1, 0LL);
			//           v28 = this.fields.m_perDrawBlock;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//           HGTerrainChunkTransform = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainChunkTransform;
			//           m_chunkNodes = this.fields.m_chunkNodes;
			//           if ( !m_chunkNodes )
			//             sub_1802DC2C8(0LL, v29);
			//           v32 = (_OWORD *)sub_1803EEC28(m_chunkNodes, SLODWORD(startTime));
			//           if ( !v28 )
			//             sub_1802DC2C8(v34, v33);
			//           *(_OWORD *)&v82.m00 = *v32;
			//           UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(v28, HGTerrainChunkTransform, (Vector4 *)&v82, 0LL);
			//           v36 = this.fields.m_perDrawBlock;
			//           HGTerrainChunkParam0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainChunkParam0;
			//           v38 = this.fields.m_chunkNodes;
			//           if ( !v38 )
			//             sub_1802DC2C8(0LL, v35);
			//           v39 = sub_1803EEC28(v38, SLODWORD(startTime));
			//           *(_QWORD *)&v81 = 0LL;
			//           DWORD2(v81) = v83.type;
			//           *((float *)&v81 + 3) = (float)*(unsigned __int16 *)(v39 + 26);
			//           if ( !v36 )
			//             sub_1802DC2C8(v41, v40);
			//           *(_OWORD *)&v82.m00 = v81;
			//           UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(v36, HGTerrainChunkParam0, (Vector4 *)&v82, 0LL);
			//           if ( !enableTessellation )
			//             goto LABEL_31;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainRenderer);
			//           v45 = TypeInfo::HG::Rendering::Runtime::HGTerrainRenderer.static_fields;
			//           tessellationPassTypeMapping = v45.tessellationPassTypeMapping;
			//           if ( !v45.tessellationPassTypeMapping )
			//             sub_1802DC2C8(v45, v42);
			//           if ( (unsigned int)v7 >= tessellationPassTypeMapping.max_length.size )
			//             sub_180070260(v45, v42, v43, v44);
			//           if ( tessellationPassTypeMapping.vector[v7] == HGTerrainRenderer_TerrainPassType__Enum_Invalid )
			//             goto LABEL_31;
			//           v47 = this.fields.m_chunkNodes;
			//           if ( !v47 )
			//             sub_1802DC2C8(0LL, v42);
			//           v48 = (HGTerrainRenderer_ChunkNode *)sub_1803EEC28(v47, SLODWORD(startTime));
			//           if ( HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::HasChildren(v48, 0LL) )
			//           {
			// LABEL_31:
			//             chunkMesh = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkMesh(this, 0LL);
			//             v69 = (Matrix4x4 *)sub_182805160(v93);
			//             v70 = this.fields.m_perDrawBlock;
			//             sub_1802F01E0(&v85, 0LL, 112LL);
			//             v65 = cmd;
			//             if ( !cmd )
			//               sub_1802DC2C8(v72, v71);
			//             v94[0] = v85;
			//             v94[1] = v86;
			//             v94[2] = v87;
			//             v94[3] = v88;
			//             v94[4] = v89;
			//             v94[5] = v90;
			//             v94[6] = v91;
			//             v82 = *v69;
			//             v79 = (Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)v94;
			//             P5 = v70;
			//             *(_DWORD *)P4 = v7;
			//             P3 = LODWORD(startTime);
			//             v66 = this.fields.m_terrainLitMaterial;
			//             v67 = chunkMesh;
			//           }
			//           else
			//           {
			//             m_tessellationQuadMesh = this.fields.m_tessellationQuadMesh;
			//             v50 = (__int128 *)sub_182805160(&v82);
			//             v51 = *v50;
			//             v52 = v50[1];
			//             v53 = v50[2];
			//             v54 = v50[3];
			//             v55 = this.fields.m_terrainLitMaterial;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainRenderer);
			//             v59 = TypeInfo::HG::Rendering::Runtime::HGTerrainRenderer.static_fields;
			//             v60 = v59.tessellationPassTypeMapping;
			//             if ( !v59.tessellationPassTypeMapping )
			//               sub_1802DC2C8(v59, v56);
			//             if ( (unsigned int)v7 >= v60.max_length.size )
			//               sub_180070260(v59, v56, v57, v58);
			//             v61 = v60.vector[v7];
			//             v62 = this.fields.m_perDrawBlock;
			//             sub_1802F01E0(&v85, 0LL, 112LL);
			//             v65 = cmd;
			//             if ( !cmd )
			//               sub_1802DC2C8(v64, v63);
			//             v93[0] = v85;
			//             v93[1] = v86;
			//             v93[2] = v87;
			//             v93[3] = v88;
			//             v93[4] = v89;
			//             v93[5] = v90;
			//             v93[6] = v91;
			//             *(_OWORD *)&v82.m00 = v51;
			//             *(_OWORD *)&v82.m01 = v52;
			//             *(_OWORD *)&v82.m02 = v53;
			//             *(_OWORD *)&v82.m03 = v54;
			//             v79 = (Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *)v93;
			//             P5 = v62;
			//             *(_DWORD *)P4 = v61;
			//             P3 = HGTerrainRenderer_TerrainPassType__Enum_GBuffer;
			//             v66 = v55;
			//             v67 = m_tessellationQuadMesh;
			//           }
			//           UnityEngine::Rendering::CommandBuffer::DrawMesh(v65, v67, &v82, v66, P3, *(int32_t *)P4, P5, v79, 0LL);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v92 )
			//       {
			//         value.m_ListData = (UnsafeList_1_System_ValueTuple_2_Int32_Single_ *)v92.ex;
			//         if ( value.m_ListData )
			//           sub_18000F780(value.m_ListData);
			//       }
			//     }
			//   }
			// }
			// 
		}

		public void RenderFeedback(Camera camera, ScriptableRenderContext renderContext)
		{
			// // Void RenderFeedback(Camera, ScriptableRenderContext)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGTerrainRenderer::RenderFeedback(
			//         HGTerrainRenderer *this,
			//         Camera *camera,
			//         ScriptableRenderContext renderContext,
			//         MethodInfo *method)
			// {
			//   Object *v4; // rdi
			//   HGTerrainRenderer *v5; // r14
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   VirtualTextureRenderer *m_vtRenderer; // rbx
			//   Dictionary_2_System_Int32_Unity_Collections_NativeList_1_System_ValueTuple_2_Int32_Single_ *m_cameraRenderData; // rbx
			//   int32_t InstanceID; // eax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   __int64 v15; // r8
			//   __int64 v16; // r9
			//   float v17; // xmm10_4
			//   float v18; // xmm8_4
			//   float farClipPlane; // xmm11_4
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   float v22; // xmm6_4
			//   VirtualTextureRenderer *v23; // rbx
			//   __m128 v24; // xmm6
			//   __int128 v25; // xmm8
			//   __int128 v26; // xmm9
			//   __int128 v27; // xmm10
			//   __int128 v28; // xmm11
			//   int32_t Length; // eax
			//   int v30; // r12d
			//   __m128i v31; // xmm6
			//   MethodInfo *v32; // r9
			//   MethodInfo *v33; // r8
			//   Vector4 *v34; // rax
			//   __m128i *m_Buffer; // rbx
			//   __m128i v36; // xmm6
			//   MethodInfo *v37; // r9
			//   __m128i v38; // xmm6
			//   MethodInfo *v39; // r9
			//   MethodInfo *v40; // r8
			//   __m128i v41; // xmm6
			//   MethodInfo *v42; // r9
			//   __m128i v43; // xmm6
			//   MethodInfo *v44; // r9
			//   MethodInfo *v45; // r8
			//   int v46; // eax
			//   __int64 v47; // r12
			//   __m128i v48; // xmm6
			//   int32_t v49; // xmm2_4
			//   double v50; // xmm0_8
			//   MethodInfo *v51; // r9
			//   float startTime; // ebx
			//   int32_t type; // xmm12_4
			//   float v54; // xmm13_4
			//   float v55; // xmm14_4
			//   float v56; // xmm15_4
			//   float v57; // xmm5_4
			//   float v58; // xmm2_4
			//   unsigned __int32 v59; // xmm6_4
			//   __int64 v60; // rdx
			//   RenderTexture *m_RT; // rdx
			//   char *m_perDrawBlock; // rcx
			//   VirtualTextureRenderer *v63; // rbx
			//   RTHandle *m_gpuFeedbackDepth; // rbx
			//   __int128 v65; // xmm2
			//   __int128 v66; // xmm3
			//   __int128 v67; // xmm4
			//   __int128 v68; // xmm5
			//   __int128 v69; // xmm6
			//   __int128 v70; // xmm7
			//   __int64 v71; // xmm0_8
			//   Void *v72; // rax
			//   __int128 v73; // xmm2
			//   __int128 v74; // xmm3
			//   __int128 v75; // xmm4
			//   __int128 v76; // xmm5
			//   __int128 v77; // xmm6
			//   __int128 v78; // xmm7
			//   __int64 v79; // xmm0_8
			//   int32_t v80; // ebx
			//   Material *m_terrainLitMaterial; // rbx
			//   int32_t HGTerrainFeedbackViewProj; // r13d
			//   Matrix4x4 *GPUProjectionMatrix; // rax
			//   __int128 v84; // xmm6
			//   __int128 v85; // xmm7
			//   __int128 v86; // xmm8
			//   __int128 v87; // xmm9
			//   Matrix4x4 *v88; // rax
			//   ComputeBuffer *currGPUFeedbackBuffer; // rax
			//   Void *v90; // rdi
			//   __int64 v91; // r13
			//   __int64 v92; // r12
			//   UnsafeList_1_System_ValueTuple_2_Int32_Single_ *v93; // rbx
			//   MaterialPropertyBlock *v94; // rdi
			//   NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *v95; // rax
			//   VirtualTextureRenderer *v96; // rax
			//   Mesh *chunkMesh; // rdi
			//   Mesh *v98; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v100; // rdx
			//   __int64 v101; // rcx
			//   char v102; // [rsp+40h] [rbp-2C8h]
			//   NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ v103; // [rsp+50h] [rbp-2B8h] BYREF
			//   int32_t name; // [rsp+60h] [rbp-2A8h]
			//   int v105; // [rsp+64h] [rbp-2A4h]
			//   NativeArray_1_Unity_Mathematics_quaternion_ v106; // [rsp+70h] [rbp-298h] BYREF
			//   NativeArray_1_System_Int32_ v107; // [rsp+80h] [rbp-288h] BYREF
			//   Vector4 v108; // [rsp+90h] [rbp-278h] BYREF
			//   float v109; // [rsp+A0h] [rbp-268h]
			//   float v110; // [rsp+A4h] [rbp-264h]
			//   float v111; // [rsp+A8h] [rbp-260h]
			//   NativeList_1_System_ValueTuple_2_Int32_Single_ value; // [rsp+B0h] [rbp-258h] BYREF
			//   Matrix4x4 v113; // [rsp+C0h] [rbp-248h] BYREF
			//   Matrix4x4 v114; // [rsp+100h] [rbp-208h] BYREF
			//   Matrix4x4 v115; // [rsp+140h] [rbp-1C8h] BYREF
			//   NativeArray_1_BeyondDynamicBone_VirtualMesh_BaseLineWork_ v116; // [rsp+180h] [rbp-188h] BYREF
			//   NativeArray_1_UnityEngine_Rendering_AttachmentDescriptor_ v117; // [rsp+190h] [rbp-178h] BYREF
			//   NativeArray_1_T_ReadOnly_T_Enumerator_MagicaCloth_RestoreRotationConstraint_RotationData_ v118; // [rsp+1A0h] [rbp-168h] BYREF
			//   NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ v119; // [rsp+1C8h] [rbp-140h] BYREF
			//   Il2CppExceptionWrapper *v120; // [rsp+1E8h] [rbp-120h] BYREF
			//   Il2CppExceptionWrapper *v121; // [rsp+1F0h] [rbp-118h] BYREF
			//   Matrix4x4 v122[3]; // [rsp+1F8h] [rbp-110h] BYREF
			//   ScriptableRenderContext P2; // [rsp+320h] [rbp+18h] BYREF
			// 
			//   P2.m_Ptr = renderContext.m_Ptr;
			//   v4 = (Object *)camera;
			//   v5 = this;
			//   if ( !byte_18D919711 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CommandBufferPool);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::TryGetValue);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::Vector4>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::MoveNext);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::Vector4>::MoveNext);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::Vector4>::get_Current);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Rendering::AttachmentDescriptor>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Rendering::AttachmentDescriptor>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::get_Length);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&MethodInfo::System::ValueTuple<int,float>::ValueTuple);
			//     sub_18003C530(&off_18D515870);
			//     byte_18D919711 = 1;
			//   }
			//   value = 0LL;
			//   v116 = 0LL;
			//   v117 = 0LL;
			//   v107 = 0LL;
			//   v106 = 0LL;
			//   memset(&v118, 0, sizeof(v118));
			//   if ( IFix::WrappersManagerImpl::IsPatched(3391, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3391, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v101, v100);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1205(Patch, (Object *)v5, v4, P2, 0LL);
			//   }
			//   else
			//   {
			//     m_vtRenderer = v5.fields.m_vtRenderer;
			//     if ( !m_vtRenderer )
			//       sub_180B536AC(v7, v6);
			//     if ( m_vtRenderer.fields._feedbackMode_k__BackingField == 1 )
			//     {
			//       m_cameraRenderData = v5.fields.m_cameraRenderData;
			//       if ( !v4 )
			//         sub_180B536AC(v7, v6);
			//       InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)v4, 0LL);
			//       if ( !m_cameraRenderData )
			//         sub_180B536AC(v12, v11);
			//       if ( System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::TryGetValue(
			//              m_cameraRenderData,
			//              InstanceID,
			//              &value,
			//              MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::TryGetValue) )
			//       {
			//         UnityEngine::Camera::get_fieldOfView((Camera *)v4, 0LL);
			//         v17 = sub_1802ED290(v14, v13, v15, v16);
			//         v18 = UnityEngine::Camera::get_nearClipPlane((Camera *)v4, 0LL);
			//         farClipPlane = UnityEngine::Camera::get_farClipPlane((Camera *)v4, 0LL);
			//         v22 = (float)((float)-v18 * v17) * UnityEngine::Camera::get_aspect((Camera *)v4, 0LL);
			//         v23 = v5.fields.m_vtRenderer;
			//         if ( !v23 )
			//           sub_180B536AC(v21, v20);
			//         v24 = (__m128)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VirtualTextureRenderer::GetFeedbackSubViewRange(
			//                                                          (ValueTuple_4_Single_Single_Single_Single_ *)&v103,
			//                                                          v23,
			//                                                          v22,
			//                                                          -v22,
			//                                                          (float)-v18 * v17,
			//                                                          -(float)((float)-v18 * v17),
			//                                                          0LL));
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//         v113 = *HG::Rendering::Runtime::HGTerrainUtils::PerspectiveOffCenter(
			//                   &v114,
			//                   v24.m128_f32[0],
			//                   _mm_shuffle_ps(v24, v24, 85).m128_f32[0],
			//                   _mm_shuffle_ps(v24, v24, 170).m128_f32[0],
			//                   _mm_shuffle_ps(v24, v24, 255).m128_f32[0],
			//                   v18,
			//                   farClipPlane,
			//                   0LL);
			//         v25 = *(_OWORD *)&v113.m00;
			//         v26 = *(_OWORD *)&v113.m01;
			//         v27 = *(_OWORD *)&v113.m02;
			//         v28 = *(_OWORD *)&v113.m03;
			//         Length = Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::get_Length(
			//                    (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&value,
			//                    MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::get_Length);
			//         Unity::Collections::NativeArray<BeyondDynamicBone::VirtualMesh::BaseLineWork>::NativeArray(
			//           &v116,
			//           Length,
			//           Allocator__Enum_Temp,
			//           NativeArrayOptions__Enum_ClearMemory,
			//           MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::NativeArray);
			//         v30 = 0;
			//         v105 = 0;
			//         v114 = *UnityEngine::Camera::get_worldToCameraMatrix(&v115, (Camera *)v4, 0LL);
			//         *(_OWORD *)&v115.m00 = v25;
			//         *(_OWORD *)&v115.m01 = v26;
			//         *(_OWORD *)&v115.m02 = v27;
			//         *(_OWORD *)&v115.m03 = v28;
			//         v114 = *UnityEngine::Matrix4x4::op_Multiply(v122, &v115, &v114, 0LL);
			//         Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//           &v106,
			//           5,
			//           Allocator__Enum_Temp,
			//           NativeArrayOptions__Enum_ClearMemory,
			//           MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//         v31 = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow((Vector4 *)&v103, &v114, 3, 0LL));
			//         v103 = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)*UnityEngine::Matrix4x4::GetRow(
			//                                                                                    (Vector4 *)&v103,
			//                                                                                    &v114,
			//                                                                                    0,
			//                                                                                    0LL);
			//         *(__m128i *)&v115.m00 = v31;
			//         v103 = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)*UnityEngine::Vector4::op_Addition(
			//                                                                                    &v108,
			//                                                                                    (Vector4 *)&v115,
			//                                                                                    (Vector4 *)&v103,
			//                                                                                    v32);
			//         v34 = UnityEngine::Vector4::op_UnaryNegation((Vector4 *)&v115, (Vector4 *)&v103, v33);
			//         m_Buffer = (__m128i *)v106.m_Buffer;
			//         *(__m128i *)v106.m_Buffer = _mm_loadu_si128((const __m128i *)v34);
			//         v36 = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow((Vector4 *)&v103, &v114, 0, 0LL));
			//         v103 = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)*UnityEngine::Matrix4x4::GetRow(
			//                                                                                    (Vector4 *)&v103,
			//                                                                                    &v114,
			//                                                                                    3,
			//                                                                                    0LL);
			//         *(__m128i *)&v115.m00 = v36;
			//         m_Buffer[1] = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Subtraction(
			//                                                          &v108,
			//                                                          (Vector4 *)&v115,
			//                                                          (Vector4 *)&v103,
			//                                                          v37));
			//         v38 = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow((Vector4 *)&v103, &v114, 3, 0LL));
			//         v103 = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)*UnityEngine::Matrix4x4::GetRow(
			//                                                                                    (Vector4 *)&v103,
			//                                                                                    &v114,
			//                                                                                    1,
			//                                                                                    0LL);
			//         *(__m128i *)&v115.m00 = v38;
			//         v103 = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)*UnityEngine::Vector4::op_Addition(
			//                                                                                    &v108,
			//                                                                                    (Vector4 *)&v115,
			//                                                                                    (Vector4 *)&v103,
			//                                                                                    v39);
			//         m_Buffer[2] = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_UnaryNegation(
			//                                                          (Vector4 *)&v115,
			//                                                          (Vector4 *)&v103,
			//                                                          v40));
			//         v41 = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow((Vector4 *)&v103, &v114, 1, 0LL));
			//         v103 = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)*UnityEngine::Matrix4x4::GetRow(
			//                                                                                    (Vector4 *)&v103,
			//                                                                                    &v114,
			//                                                                                    3,
			//                                                                                    0LL);
			//         *(__m128i *)&v115.m00 = v41;
			//         m_Buffer[3] = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Subtraction(
			//                                                          &v108,
			//                                                          (Vector4 *)&v115,
			//                                                          (Vector4 *)&v103,
			//                                                          v42));
			//         v43 = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow((Vector4 *)&v103, &v114, 3, 0LL));
			//         v103 = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)*UnityEngine::Matrix4x4::GetRow(
			//                                                                                    (Vector4 *)&v103,
			//                                                                                    &v114,
			//                                                                                    2,
			//                                                                                    0LL);
			//         *(__m128i *)&v115.m00 = v43;
			//         v103 = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)*UnityEngine::Vector4::op_Addition(
			//                                                                                    &v108,
			//                                                                                    (Vector4 *)&v115,
			//                                                                                    (Vector4 *)&v103,
			//                                                                                    v44);
			//         m_Buffer[4] = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_UnaryNegation(
			//                                                          (Vector4 *)&v115,
			//                                                          (Vector4 *)&v103,
			//                                                          v45));
			//         v103 = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)v106;
			//         v46 = _mm_cvtsi128_si32(_mm_srli_si128((__m128i)v106, 8));
			//         if ( v46 > 0 )
			//         {
			//           v47 = (unsigned int)v46;
			//           do
			//           {
			//             v48 = _mm_loadu_si128(m_Buffer);
			//             v49 = m_Buffer.m128i_i32[2];
			//             v106.m_Buffer = (Void *)_mm_unpacklo_ps((__m128)m_Buffer.m128i_u32[0], (__m128)m_Buffer.m128i_u32[1]).m128_u64[0];
			//             v106.m_Length = v49;
			//             v50 = sub_18238EFA0(&v106);
			//             *(__m128i *)&v115.m00 = v48;
			//             *m_Buffer++ = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Multiply(
			//                                                              &v108,
			//                                                              (Vector4 *)&v115,
			//                                                              1.0 / *(float *)&v50,
			//                                                              v51));
			//             --v47;
			//           }
			//           while ( v47 );
			//           v30 = v105;
			//         }
			//         Unity::Collections::NativeList<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::GetEnumerator(
			//           (NativeArray_1_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&v115,
			//           (NativeList_1_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&value,
			//           MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::GetEnumerator);
			//         v119.m_Array = *(NativeArray_1_T_ReadOnly_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&v115.m00;
			//         *(_OWORD *)&v119.m_Index = *(_OWORD *)&v115.m01;
			//         *(_QWORD *)&v115.m00 = 0LL;
			//         *(_QWORD *)&v115.m20 = &v119;
			//         try
			//         {
			//           v59 = _mm_load_si128((const __m128i *)&xmmword_18A357260).m128i_u32[0];
			//           while ( Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::MoveNext(
			//                     &v119,
			//                     MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::MoveNext) )
			//           {
			//             startTime = v119.value.startTime;
			//             *(float *)&value.m_ListData = v119.value.startTime;
			//             type = v119.value.type;
			//             name = v119.value.type;
			//             v54 = *(float *)&v5.fields._centerXs_k__BackingField.m_Buffer[4 * SLODWORD(v119.value.startTime)];
			//             v55 = *(float *)&v5.fields._centerYs_k__BackingField.m_Buffer[4 * SLODWORD(v119.value.startTime)];
			//             v56 = *(float *)&v5.fields._centerZs_k__BackingField.m_Buffer[4 * SLODWORD(v119.value.startTime)];
			//             v110 = *(float *)&v5.fields._extentXs_k__BackingField.m_Buffer[4 * SLODWORD(v119.value.startTime)];
			//             v109 = *(float *)&v5.fields._extentYs_k__BackingField.m_Buffer[4 * SLODWORD(v119.value.startTime)];
			//             v111 = *(float *)&v5.fields._extentZs_k__BackingField.m_Buffer[4 * SLODWORD(v119.value.startTime)];
			//             v102 = 1;
			//             Unity::Collections::NativeArray_1_T_::ReadOnly<MagicaCloth::RestoreRotationConstraint::RotationData>::GetEnumerator(
			//               (NativeArray_1_T_ReadOnly_T_Enumerator_MagicaCloth_RestoreRotationConstraint_RotationData_ *)&v114,
			//               (NativeArray_1_T_ReadOnly_MagicaCloth_RestoreRotationConstraint_RotationData_ *)&v103,
			//               MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::GetEnumerator);
			//             v118.m_Array = *(NativeArray_1_T_ReadOnly_MagicaCloth_RestoreRotationConstraint_RotationData_ *)&v114.m00;
			//             *(_OWORD *)&v118.m_Index = *(_OWORD *)&v114.m01;
			//             *(_QWORD *)&v118.value.localPos.z = *(_QWORD *)&v114.m02;
			//             *(_QWORD *)&v108.x = 0LL;
			//             *(_QWORD *)&v108.z = &v118;
			//             try
			//             {
			//               while ( Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<MagicaCloth::RestoreRotationConstraint::RotationData>::MoveNext(
			//                         &v118,
			//                         MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::Vector4>::MoveNext) )
			//               {
			//                 v57 = _mm_shuffle_ps((__m128)v118.value, (__m128)v118.value, 85).m128_f32[0];
			//                 v58 = _mm_shuffle_ps((__m128)v118.value, (__m128)v118.value, 170).m128_f32[0];
			//                 v102 &= (float)((float)((float)((float)((float)(v57 * v55)
			//                                                       + (float)(*(float *)&v118.value.vertexIndex * v54))
			//                                               + (float)(v58 * v56))
			//                                       + _mm_shuffle_ps((__m128)v118.value, (__m128)v118.value, 255).m128_f32[0])
			//                               - (float)((float)((float)(COERCE_FLOAT(LODWORD(v57) & v59) * v109)
			//                                               + (float)(COERCE_FLOAT(*(_DWORD *)&v118.value.vertexIndex & v59) * v110))
			//                                       + (float)(COERCE_FLOAT(LODWORD(v58) & v59) * v111))) <= 0.0;
			//               }
			//             }
			//             catch ( Il2CppExceptionWrapper *v120 )
			//             {
			//               *(Il2CppExceptionWrapper *)&v108.x = (Il2CppExceptionWrapper)v120.ex;
			//               if ( *(_QWORD *)&v108.x )
			//                 sub_18000F780(*(_QWORD *)&v108.x);
			//               v4 = (Object *)camera;
			//               v5 = this;
			//               v28 = *(_OWORD *)&v113.m03;
			//               v27 = *(_OWORD *)&v113.m02;
			//               v26 = *(_OWORD *)&v113.m01;
			//               v25 = *(_OWORD *)&v113.m00;
			//               v30 = v105;
			//               v59 = _mm_load_si128((const __m128i *)&xmmword_18A357260).m128i_u32[0];
			//               startTime = *(float *)&value.m_ListData;
			//               type = name;
			//             }
			//             if ( v102 )
			//             {
			//               v60 = v30++;
			//               v105 = v30;
			//               v106.m_Buffer = (Void *)__PAIR64__(type, LODWORD(startTime));
			//               *(_QWORD *)&v116.m_Buffer[8 * v60] = __PAIR64__(type, LODWORD(startTime));
			//             }
			//           }
			//         }
			//         catch ( Il2CppExceptionWrapper *v121 )
			//         {
			//           *(Il2CppExceptionWrapper *)&v115.m00 = (Il2CppExceptionWrapper)v121.ex;
			//           if ( *(_QWORD *)&v115.m00 )
			//             sub_18000F780(*(_QWORD *)&v115.m00);
			//           v4 = (Object *)camera;
			//           v5 = this;
			//           v28 = *(_OWORD *)&v113.m03;
			//           v27 = *(_OWORD *)&v113.m02;
			//           v26 = *(_OWORD *)&v113.m01;
			//           v25 = *(_OWORD *)&v113.m00;
			//           v30 = v105;
			//         }
			//         Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//           &v103,
			//           MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
			//         if ( v30 )
			//         {
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::CommandBufferPool);
			//           v106.m_Buffer = (Void *)UnityEngine::Rendering::CommandBufferPool::Get((String *)"HGTerrainFeedback", 0LL);
			//           v63 = v5.fields.m_vtRenderer;
			//           if ( !v63 )
			//             goto LABEL_56;
			//           m_gpuFeedbackDepth = v63.fields.m_gpuFeedbackDepth;
			//           Unity::Collections::NativeArray<UnityEngine::Rendering::AttachmentDescriptor>::NativeArray(
			//             &v117,
			//             2,
			//             Allocator__Enum_Temp,
			//             NativeArrayOptions__Enum_ClearMemory,
			//             MethodInfo::Unity::Collections::NativeArray<UnityEngine::Rendering::AttachmentDescriptor>::NativeArray);
			//           m_perDrawBlock = (char *)v5.fields.m_vtRenderer;
			//           if ( !m_perDrawBlock )
			//             goto LABEL_56;
			//           v65 = *(_OWORD *)(m_perDrawBlock + 344);
			//           v66 = *(_OWORD *)(m_perDrawBlock + 360);
			//           v67 = *(_OWORD *)(m_perDrawBlock + 376);
			//           v68 = *(_OWORD *)(m_perDrawBlock + 392);
			//           v69 = *(_OWORD *)(m_perDrawBlock + 408);
			//           v70 = *(_OWORD *)(m_perDrawBlock + 424);
			//           v71 = *((_QWORD *)m_perDrawBlock + 55);
			//           v72 = v117.m_Buffer;
			//           *(_OWORD *)v117.m_Buffer = *(_OWORD *)(m_perDrawBlock + 328);
			//           *(_OWORD *)&v72[16] = v65;
			//           *(_OWORD *)&v72[32] = v66;
			//           *(_OWORD *)&v72[48] = v67;
			//           *(_OWORD *)&v72[64] = v68;
			//           *(_OWORD *)&v72[80] = v69;
			//           *(_OWORD *)&v72[96] = v70;
			//           *(_QWORD *)&v72[112] = v71;
			//           m_perDrawBlock = (char *)v5.fields.m_vtRenderer;
			//           if ( !m_perDrawBlock )
			//             goto LABEL_56;
			//           v73 = *((_OWORD *)m_perDrawBlock + 29);
			//           v74 = *((_OWORD *)m_perDrawBlock + 30);
			//           v75 = *((_OWORD *)m_perDrawBlock + 31);
			//           v76 = *((_OWORD *)m_perDrawBlock + 32);
			//           v77 = *((_OWORD *)m_perDrawBlock + 33);
			//           v78 = *((_OWORD *)m_perDrawBlock + 34);
			//           v79 = *((_QWORD *)m_perDrawBlock + 70);
			//           *(_OWORD *)&v72[120] = *((_OWORD *)m_perDrawBlock + 28);
			//           *(_OWORD *)&v72[136] = v73;
			//           *(_OWORD *)&v72[152] = v74;
			//           *(_OWORD *)&v72[168] = v75;
			//           *(_OWORD *)&v72[184] = v76;
			//           *(_OWORD *)&v72[200] = v77;
			//           *(_OWORD *)&v72[216] = v78;
			//           *(_QWORD *)&v72[232] = v79;
			//           if ( !m_gpuFeedbackDepth )
			//             goto LABEL_56;
			//           m_RT = m_gpuFeedbackDepth.fields.m_RT;
			//           if ( !m_RT )
			//             goto LABEL_56;
			//           name = sub_18003ED00(5LL);
			//           m_RT = m_gpuFeedbackDepth.fields.m_RT;
			//           if ( !m_RT )
			//             goto LABEL_56;
			//           v80 = sub_18003ED00(7LL);
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           v103 = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)v117;
			//           UnityEngine::Rendering::ScriptableRenderContext::BeginRenderPass(
			//             &P2,
			//             name,
			//             v80,
			//             1,
			//             (NativeArray_1_UnityEngine_Rendering_AttachmentDescriptor_ *)&v103,
			//             1,
			//             0LL);
			//           Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
			//             (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v117,
			//             MethodInfo::Unity::Collections::NativeArray<UnityEngine::Rendering::AttachmentDescriptor>::Dispose);
			//           Unity::Collections::NativeArray<int>::NativeArray(
			//             &v107,
			//             1,
			//             Allocator__Enum_Temp,
			//             NativeArrayOptions__Enum_ClearMemory,
			//             MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//           *(_DWORD *)v107.m_Buffer = 0;
			//           v103 = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)v107;
			//           UnityEngine::Rendering::ScriptableRenderContext::BeginSubPass(
			//             &P2,
			//             (NativeArray_1_System_Int32_ *)&v103,
			//             0,
			//             0LL);
			//           Unity::Collections::NativeArray<int>::Dispose(
			//             &v107,
			//             MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//           m_terrainLitMaterial = v5.fields.m_terrainLitMaterial;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//           HGTerrainFeedbackViewProj = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainFeedbackViewProj;
			//           *(_OWORD *)&v113.m00 = v25;
			//           *(_OWORD *)&v113.m01 = v26;
			//           *(_OWORD *)&v113.m02 = v27;
			//           *(_OWORD *)&v113.m03 = v28;
			//           GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(v122, &v113, 1, 0LL);
			//           v84 = *(_OWORD *)&GPUProjectionMatrix.m00;
			//           v85 = *(_OWORD *)&GPUProjectionMatrix.m01;
			//           v86 = *(_OWORD *)&GPUProjectionMatrix.m02;
			//           v87 = *(_OWORD *)&GPUProjectionMatrix.m03;
			//           if ( !v4 )
			//             goto LABEL_56;
			//           v113 = *UnityEngine::Camera::get_worldToCameraMatrix(v122, (Camera *)v4, 0LL);
			//           *(_OWORD *)&v114.m00 = v84;
			//           *(_OWORD *)&v114.m01 = v85;
			//           *(_OWORD *)&v114.m02 = v86;
			//           *(_OWORD *)&v114.m03 = v87;
			//           v88 = UnityEngine::Matrix4x4::op_Multiply(v122, &v114, &v113, 0LL);
			//           if ( !m_terrainLitMaterial )
			//             goto LABEL_56;
			//           v113 = *v88;
			//           UnityEngine::Material::SetMatrixImpl_Injected(m_terrainLitMaterial, HGTerrainFeedbackViewProj, &v113, 0LL);
			//           m_perDrawBlock = (char *)v5.fields.m_vtRenderer;
			//           if ( !m_perDrawBlock )
			//             goto LABEL_56;
			//           currGPUFeedbackBuffer = HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackBuffer(
			//                                     (VirtualTextureRenderer *)m_perDrawBlock,
			//                                     0LL);
			//           v90 = v106.m_Buffer;
			//           if ( !v106.m_Buffer )
			//             goto LABEL_56;
			//           UnityEngine::Rendering::CommandBuffer::SetRandomWriteTarget(
			//             (CommandBuffer *)v106.m_Buffer,
			//             1,
			//             currGPUFeedbackBuffer,
			//             0,
			//             0LL);
			//           v91 = v30;
			//           if ( v30 > 0 )
			//           {
			//             v92 = 0LL;
			//             while ( 1 )
			//             {
			//               v93 = *(UnsafeList_1_System_ValueTuple_2_Int32_Single_ **)&v116.m_Buffer[8 * v92];
			//               value.m_ListData = v93;
			//               m_perDrawBlock = (char *)v5.fields.m_perDrawBlock;
			//               if ( !m_perDrawBlock )
			//                 break;
			//               UnityEngine::MaterialPropertyBlock::Clear((MaterialPropertyBlock *)m_perDrawBlock, 1, 0LL);
			//               v94 = v5.fields.m_perDrawBlock;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//               name = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainChunkTransform;
			//               m_perDrawBlock = (char *)v5.fields.m_chunkNodes;
			//               if ( !m_perDrawBlock )
			//                 break;
			//               v95 = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)sub_1803EEC28(
			//                                                                                          m_perDrawBlock,
			//                                                                                          (int)v93);
			//               if ( !v94 )
			//                 break;
			//               v103 = *v95;
			//               UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(v94, name, (Vector4 *)&v103, 0LL);
			//               m_perDrawBlock = (char *)v5.fields.m_perDrawBlock;
			//               v96 = v5.fields.m_vtRenderer;
			//               if ( !v96 )
			//                 break;
			//               v107.m_Buffer = 0LL;
			//               v107.m_Length = HIDWORD(value.m_ListData);
			//               *(float *)&v107.m_AllocatorLabel = (float)v96.fields.m_feedbackWidth;
			//               if ( !m_perDrawBlock )
			//                 break;
			//               v103 = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)v107;
			//               UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
			//                 (MaterialPropertyBlock *)m_perDrawBlock,
			//                 TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainChunkParam0,
			//                 (Vector4 *)&v103,
			//                 0LL);
			//               chunkMesh = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkMesh(v5, 0LL);
			//               v113 = *(Matrix4x4 *)sub_182805160(v122);
			//               v98 = chunkMesh;
			//               v90 = v106.m_Buffer;
			//               UnityEngine::Rendering::CommandBuffer::DrawMesh(
			//                 (CommandBuffer *)v106.m_Buffer,
			//                 v98,
			//                 &v113,
			//                 v5.fields.m_terrainLitMaterial,
			//                 (int32_t)v93,
			//                 1,
			//                 v5.fields.m_perDrawBlock,
			//                 0LL);
			//               if ( ++v92 >= v91 )
			//                 goto LABEL_44;
			//             }
			// LABEL_56:
			//             sub_1802DC2C8(m_perDrawBlock, m_RT);
			//           }
			// LABEL_44:
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           UnityEngine::Rendering::ScriptableRenderContext::ExecuteCommandBuffer(&P2, (CommandBuffer *)v90, 0LL);
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::CommandBufferPool);
			//           UnityEngine::Rendering::CommandBufferPool::Release((CommandBuffer *)v90, 0LL);
			//           UnityEngine::Rendering::ScriptableRenderContext::EndSubPass(&P2, 0LL);
			//           UnityEngine::Rendering::ScriptableRenderContext::EndRenderPass(&P2, 0LL);
			//           Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
			//             (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v116,
			//             MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::Dispose);
			//           m_perDrawBlock = (char *)v5.fields.m_vtRenderer;
			//           if ( !m_perDrawBlock )
			//             goto LABEL_56;
			//           HG::Rendering::Runtime::VirtualTextureRenderer::MarkCurrentGPUFeedbackBufferFilled(
			//             (VirtualTextureRenderer *)m_perDrawBlock,
			//             1,
			//             0LL);
			//         }
			//         else
			//         {
			//           Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
			//             (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v116,
			//             MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::Dispose);
			//         }
			//       }
			//     }
			//   }
			// }
			// 
		}

		public int GetSignificantLayerInfo(float worldPosX, float worldPosZ)
		{
			// // Int32 GetSignificantLayerInfo(Single, Single)
			// int32_t HG::Rendering::Runtime::HGTerrainRenderer::GetSignificantLayerInfo(
			//         HGTerrainRenderer *this,
			//         float worldPosX,
			//         float worldPosZ,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGTerrainRuntimeResources *m_packedLayerInfoWidth; // rcx
			//   HGTerrainRuntimeResources *m_runtimeResources; // rax
			//   float x; // xmm6_4
			//   int32_t m_X; // ebx
			//   int v10; // eax
			//   int v11; // ebx
			//   int v12; // esi
			//   Int32__Array *packedSignificantLayerInfo; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919712 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Math);
			//     byte_18D919712 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3394, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3394, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1206(Patch, (Object *)this, worldPosX, worldPosZ, 0LL);
			// LABEL_11:
			//     sub_180B536AC(m_packedLayerInfoWidth, v5);
			//   }
			//   m_runtimeResources = this.fields.m_runtimeResources;
			//   if ( !m_runtimeResources )
			//     goto LABEL_11;
			//   x = m_runtimeResources.fields.terrainPos.x;
			//   m_X = m_runtimeResources.fields.terrainSize.m_X;
			//   sub_180002C70(TypeInfo::System::Math);
			//   v10 = sub_182ACC210((unsigned int)(int)(float)(worldPosX - x), 0LL, (unsigned int)(m_X - 1));
			//   m_packedLayerInfoWidth = this.fields.m_runtimeResources;
			//   v11 = v10;
			//   if ( !m_packedLayerInfoWidth )
			//     goto LABEL_11;
			//   v12 = sub_182ACC210(
			//           (unsigned int)(int)(float)(worldPosZ - m_packedLayerInfoWidth.fields.terrainPos.z),
			//           0LL,
			//           (unsigned int)(m_packedLayerInfoWidth.fields.terrainSize.m_Y - 1));
			//   packedSignificantLayerInfo = HG::Rendering::Runtime::HGTerrainRenderer::get_packedSignificantLayerInfo(this, 0LL);
			//   m_packedLayerInfoWidth = (HGTerrainRuntimeResources *)(unsigned int)this.fields.m_packedLayerInfoWidth;
			//   if ( !packedSignificantLayerInfo )
			//     goto LABEL_11;
			//   v14 = (unsigned int)(v11 >> 31);
			//   LODWORD(v14) = v11 % this.fields.m_packedLaneWidth;
			//   v15 = (unsigned int)(v11 / this.fields.m_packedLaneWidth + v12 * (_DWORD)m_packedLayerInfoWidth);
			//   if ( (unsigned int)v15 >= packedSignificantLayerInfo.max_length.size )
			//     sub_180070270(v15, v14);
			//   return (packedSignificantLayerInfo.vector[(int)v15] >> ((4 * v14) & 0x1F)) & 0xF;
			// }
			// 
			return 0;
		}

		public void Dispose()
		{
			// // Void Dispose()
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGTerrainRenderer::Dispose(HGTerrainRenderer *this, MethodInfo *method)
			// {
			//   HGTerrainRenderer *v2; // rbx
			//   __int64 v3; // rdx
			//   ComputeBuffer *m_perTerrainDataBuffer; // rcx
			//   ComputeBuffer *m_perTerrainFrameDataBuffer; // rcx
			//   Void *m_Buffer; // rcx
			//   Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *m_fixedLevelRenderData; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __int64 v11; // [rsp+0h] [rbp-E8h] BYREF
			//   NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ centerXs_k__BackingField; // [rsp+20h] [rbp-C8h] BYREF
			//   NativeList_1_System_ValueTuple_2_Int32_Single_ value; // [rsp+30h] [rbp-B8h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_ v14; // [rsp+40h] [rbp-A8h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ v15; // [rsp+70h] [rbp-78h] BYREF
			//   Il2CppExceptionWrapper *v16; // [rsp+A0h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v17; // [rsp+A8h] [rbp-40h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32_Unity_Collections_NativeList_1_System_ValueTuple_2_Int32_Single_ v18; // [rsp+B0h] [rbp-38h] BYREF
			// 
			//   v2 = this;
			//   if ( !byte_18D919713 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::get_Value);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<float>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::Dispose);
			//     byte_18D919713 = 1;
			//   }
			//   memset(&v14, 0, sizeof(v14));
			//   if ( IFix::WrappersManagerImpl::IsPatched(3395, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3395, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			//     centerXs_k__BackingField = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)v2.fields._centerXs_k__BackingField;
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       &centerXs_k__BackingField,
			//       MethodInfo::Unity::Collections::NativeArray<float>::Dispose);
			//     centerXs_k__BackingField = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)v2.fields._centerYs_k__BackingField;
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       &centerXs_k__BackingField,
			//       MethodInfo::Unity::Collections::NativeArray<float>::Dispose);
			//     centerXs_k__BackingField = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)v2.fields._centerZs_k__BackingField;
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       &centerXs_k__BackingField,
			//       MethodInfo::Unity::Collections::NativeArray<float>::Dispose);
			//     centerXs_k__BackingField = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)v2.fields._extentXs_k__BackingField;
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       &centerXs_k__BackingField,
			//       MethodInfo::Unity::Collections::NativeArray<float>::Dispose);
			//     centerXs_k__BackingField = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)v2.fields._extentYs_k__BackingField;
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       &centerXs_k__BackingField,
			//       MethodInfo::Unity::Collections::NativeArray<float>::Dispose);
			//     centerXs_k__BackingField = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)v2.fields._extentZs_k__BackingField;
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//       &centerXs_k__BackingField,
			//       MethodInfo::Unity::Collections::NativeArray<float>::Dispose);
			//     m_perTerrainDataBuffer = v2.fields.m_perTerrainDataBuffer;
			//     if ( m_perTerrainDataBuffer )
			//       UnityEngine::ComputeBuffer::Dispose(m_perTerrainDataBuffer, 0LL);
			//     m_perTerrainFrameDataBuffer = v2.fields.m_perTerrainFrameDataBuffer;
			//     if ( m_perTerrainFrameDataBuffer )
			//       UnityEngine::ComputeBuffer::Dispose(m_perTerrainFrameDataBuffer, 0LL);
			//     if ( !v2.fields.m_cameraRenderData )
			//       sub_180B536AC(m_perTerrainFrameDataBuffer, v3);
			//     System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::GetEnumerator(
			//       &v15,
			//       (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v2.fields.m_cameraRenderData,
			//       MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::GetEnumerator);
			//     v18 = (Dictionary_2_TKey_TValue_Enumerator_System_Int32_Unity_Collections_NativeList_1_System_ValueTuple_2_Int32_Single_)v15;
			//     centerXs_k__BackingField.m_Buffer = 0LL;
			//     *(_QWORD *)&centerXs_k__BackingField.m_Length = &v18;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::MoveNext(
			//                 &v18,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::MoveNext) )
			//       {
			//         value = v18._current.value;
			//         Unity::Collections::NativeList<System::ValueTuple<int,float>>::Dispose(
			//           &value,
			//           MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::Dispose);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v16 )
			//     {
			//       centerXs_k__BackingField.m_Buffer = (Void *)v16.ex;
			//       m_Buffer = centerXs_k__BackingField.m_Buffer;
			//       if ( centerXs_k__BackingField.m_Buffer )
			//         sub_18000F780(centerXs_k__BackingField.m_Buffer);
			//       v2 = this;
			//     }
			//     m_fixedLevelRenderData = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v2.fields.m_fixedLevelRenderData;
			//     if ( !m_fixedLevelRenderData )
			//       goto LABEL_29;
			//     System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::GetEnumerator(
			//       &v15,
			//       m_fixedLevelRenderData,
			//       MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::GetEnumerator);
			//     v14 = (Dictionary_2_TKey_TValue_Enumerator_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_)v15;
			//     centerXs_k__BackingField.m_Buffer = 0LL;
			//     *(_QWORD *)&centerXs_k__BackingField.m_Length = &v14;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::MoveNext(
			//                 &v14,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::MoveNext) )
			//       {
			//         value = (NativeList_1_System_ValueTuple_2_Int32_Single_)v14._current.value;
			//         Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
			//           (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&value,
			//           MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::Dispose);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v17 )
			//     {
			//       m_fixedLevelRenderData = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)&v11;
			//       centerXs_k__BackingField.m_Buffer = (Void *)v17.ex;
			//       if ( centerXs_k__BackingField.m_Buffer )
			//         sub_18000F780(centerXs_k__BackingField.m_Buffer);
			//       v2 = this;
			//     }
			//     m_Buffer = (Void *)v2.fields.m_cameraRenderData;
			//     if ( !m_Buffer
			//       || (System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
			//             (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)m_Buffer,
			//             MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::Clear),
			//           (m_Buffer = (Void *)v2.fields.m_fixedLevelRenderData) == 0LL)
			//       || (System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
			//             (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)m_Buffer,
			//             MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::Clear),
			//           (m_Buffer = (Void *)v2.fields.m_vtRenderer) == 0LL) )
			//     {
			// LABEL_29:
			//       sub_1802DC2C8(m_Buffer, m_fixedLevelRenderData);
			//     }
			//     HG::Rendering::Runtime::VirtualTextureRenderer::Dispose((VirtualTextureRenderer *)m_Buffer, 0LL);
			//   }
			// }
			// 
		}

		public HGTerrainRuntimeResources GetRuntimeResources()
		{
			// // HGTerrainRuntimeResources GetRuntimeResources()
			// HGTerrainRuntimeResources *HG::Rendering::Runtime::HGTerrainRenderer::GetRuntimeResources(
			//         HGTerrainRenderer *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3397, 0LL) )
			//     return this.fields.m_runtimeResources;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3397, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1207(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public void SetVTMaxPagePerFrame(int pageCount)
		{
			// // Void SetVTMaxPagePerFrame(Int32)
			// void HG::Rendering::Runtime::HGTerrainRenderer::SetVTMaxPagePerFrame(
			//         HGTerrainRenderer *this,
			//         int32_t pageCount,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   VirtualTextureRenderer *m_vtRenderer; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3398, 0LL) )
			//   {
			//     m_vtRenderer = this.fields.m_vtRenderer;
			//     if ( m_vtRenderer )
			//     {
			//       m_vtRenderer.fields._vtMaxPagePerFrame_k__BackingField = pageCount;
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3398, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, pageCount, 0LL);
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGTerrainRenderer.TerrainPassType[] tessellationPassTypeMapping;

		private readonly VirtualTextureRenderer m_vtRenderer;

		private readonly HGTerrainRuntimeResources m_runtimeResources;

		private readonly HGTerrainConfiguration m_configuration;

		private readonly ushort m_treeDepth;

		private readonly HGTerrainRenderer.ChunkNode[] m_chunkNodes;

		private readonly float m_geometryError;

		private readonly int m_packedLaneWidth;

		private readonly int m_packedLayerInfoWidth;

		private readonly MaterialPropertyBlock m_perDrawBlock;

		private NativeArray<bool> m_splits;

		private NativeArray<int> m_visibility;

		private float m_geoLodMax;

		private readonly Dictionary<int, NativeList<ValueTuple<int, float>>> m_cameraRenderData;

		private readonly Dictionary<ushort, NativeArray<ValueTuple<int, float>>> m_fixedLevelRenderData;

		private ComputeBuffer m_perTerrainDataBuffer;

		private ComputeBuffer m_perTerrainFrameDataBuffer;

		private readonly Material m_terrainLitMaterial;

		private readonly LocalKeyword m_terrainLitMatLightmapOn;

		private readonly Mesh m_tessellationQuadMesh;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 40)]
		public struct ChunkNode
		{
			public bool HasChildren()
			{
				// // Boolean HasChildren()
				// bool HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::HasChildren(
				//         HGTerrainRenderer_ChunkNode *this,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // rdx
				//   __int64 v4; // rcx
				//   Int16__Array *children; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(3345, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3345, 0LL);
				//     if ( Patch )
				//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1185(Patch, this, 0LL);
				// LABEL_7:
				//     sub_180B536AC(v4, v3);
				//   }
				//   children = this.children;
				//   if ( !children )
				//     goto LABEL_7;
				//   if ( !children.max_length.size )
				//     sub_180070270(v4, v3);
				//   return children.vector[0] != -1;
				// }
				// 
				return default(bool);
			}

			public bool CheckSplit(ushort targetLod)
			{
				// // Boolean CheckSplit(UInt16)
				// bool HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::CheckSplit(
				//         HGTerrainRenderer_ChunkNode *this,
				//         uint16_t targetLod,
				//         MethodInfo *method)
				// {
				//   bool result; // al
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v7; // rdx
				//   __int64 v8; // rcx
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(3344, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3344, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v8, v7);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1186(Patch, this, targetLod, 0LL);
				//   }
				//   else
				//   {
				//     result = HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::HasChildren(this, 0LL);
				//     if ( result )
				//       return targetLod > (uint16_t)(this.lodData | 0xFF);
				//   }
				//   return result;
				// }
				// 
				return default(bool);
			}

			public void ClampAndSaveMorph(ushort targetLod)
			{
				// // Void ClampAndSaveMorph(UInt16)
				// void HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::ClampAndSaveMorph(
				//         HGTerrainRenderer_ChunkNode *this,
				//         uint16_t targetLod,
				//         MethodInfo *method)
				// {
				//   uint16_t lodData; // di
				//   uint16_t v6; // bx
				//   uint16_t v7; // di
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v9; // rdx
				//   __int64 v10; // rcx
				// 
				//   if ( !byte_18D919716 )
				//   {
				//     sub_18003C530(&TypeInfo::System::Math);
				//     byte_18D919716 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(3347, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3347, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v10, v9);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1187(Patch, this, targetLod, 0LL);
				//   }
				//   else
				//   {
				//     lodData = this.lodData;
				//     sub_180002C70(TypeInfo::System::Math);
				//     v6 = lodData | 0xFF;
				//     v7 = lodData & 0xFF00;
				//     if ( !byte_18D91972A )
				//     {
				//       sub_18003C530(&MethodInfo::System::Math::ThrowMinMaxException<unsigned short>);
				//       sub_18003C530(&TypeInfo::System::Math);
				//       byte_18D91972A = 1;
				//     }
				//     if ( v7 > v6 )
				//     {
				//       sub_180002C70(TypeInfo::System::Math);
				//       System::Math::ThrowMinMaxException<unsigned short>(
				//         v7,
				//         v6,
				//         MethodInfo::System::Math::ThrowMinMaxException<unsigned short>);
				//     }
				//     if ( targetLod < v7 )
				//     {
				//       v6 = v7;
				//     }
				//     else if ( targetLod <= v6 )
				//     {
				//       v6 = targetLod;
				//     }
				//     this.lodData = v6;
				//   }
				// }
				// 
			}

			public float GetMorphValue()
			{
				// // Single GetMorphValue()
				// float HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::GetMorphValue(
				//         HGTerrainRenderer_ChunkNode *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(3348, 0LL) )
				//     return 1.0 - (float)((float)(unsigned __int8)this.lodData / 255.0);
				//   Patch = IFix::WrappersManagerImpl::GetPatch(3348, 0LL);
				//   if ( !Patch )
				//     sub_180B536AC(v6, v5);
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1189(Patch, this, 0LL);
				// }
				// 
				return 0f;
			}

			public Vector4 transform;

			public short[] children;

			public short parent;

			public ushort level;

			public ushort lodData;

			public float distance;
		}

		public enum TerrainPassType
		{
			Invalid = -1,
			GBuffer,
			Feedback,
			ShadowCaster,
			TessellationGBuffer,
			TerrainDepthOnly,
			TessellationTerrainDepthOnly,
			ScreenSpaceTerrain,
			PassCount
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
		private readonly struct ChunkComparer : IComparer<ValueTuple<int, float>>
		{
			public ChunkComparer(HGTerrainRenderer.ChunkNode[] chunkNodes)
			{
				// // Void WriteUnaligned[Object](Byte ByRef, Object)
				// void System::Runtime::CompilerServices::Unsafe::WriteUnaligned<System::Object>(
				//         uint8_t *destination,
				//         Object *value,
				//         MethodInfo *method)
				// {
				//   HGCamera *v3; // r9
				//   MethodInfo *v4; // [rsp+28h] [rbp+28h]
				//   MethodInfo *v5; // [rsp+30h] [rbp+30h]
				// 
				//   *(_QWORD *)destination = value;
				//   sub_1800054D0(
				//     (HGRenderPathScene *)destination,
				//     (HGRenderPathBase_HGRenderPathResources *)value,
				//     (PassConstructorID__Enum__Array *)method,
				//     v3,
				//     v4,
				//     v5);
				// }
				// 
			}

			public int Compare(ValueTuple<int, float> lhs, ValueTuple<int, float> rhs)
			{
				// // Int32 Compare(ValueTuple`2[Int32,Single], ValueTuple`2[Int32,Single])
				// int32_t HG::Rendering::Runtime::HGTerrainRenderer::ChunkComparer::Compare(
				//         HGTerrainRenderer_ChunkComparer *this,
				//         ValueTuple_2_Int32_Single_ lhs,
				//         ValueTuple_2_Int32_Single_ rhs,
				//         MethodInfo *method)
				// {
				//   __int64 v7; // rdx
				//   HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // rcx
				//   __int64 v9; // rax
				//   float v10; // xmm6_4
				//   __int64 v11; // rax
				//   int32_t v12; // ecx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(3400, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3400, 0LL);
				//     if ( Patch )
				//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1208(Patch, this, lhs, rhs, 0LL);
				// LABEL_8:
				//     sub_180B536AC(m_chunkNodes, v7);
				//   }
				//   m_chunkNodes = this.m_chunkNodes;
				//   if ( !this.m_chunkNodes )
				//     goto LABEL_8;
				//   v9 = sub_1803EEC28(m_chunkNodes, lhs.Item1);
				//   m_chunkNodes = this.m_chunkNodes;
				//   v10 = *(float *)(v9 + 32);
				//   if ( !this.m_chunkNodes )
				//     goto LABEL_8;
				//   v11 = sub_1803EEC28(m_chunkNodes, rhs.Item1);
				//   v12 = 1;
				//   if ( *(float *)(v11 + 32) >= v10 )
				//     return -1;
				//   return v12;
				// }
				// 
				return 0;
			}

			private readonly HGTerrainRenderer.ChunkNode[] m_chunkNodes;
		}
	}
}
