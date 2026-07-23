using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGTerrainRenderer : IDisposable // TypeDefIndex: 38621
	{
		// Fields
		public static TerrainPassType[] tessellationPassTypeMapping; // 0x00
		private readonly VirtualTextureRenderer m_vtRenderer; // 0x10
		private readonly HGTerrainRuntimeResources m_runtimeResources; // 0x18
		private readonly HGTerrainConfiguration m_configuration; // 0x20
		private readonly ushort m_treeDepth; // 0x28
		private readonly ChunkNode[] m_chunkNodes; // 0x30
		private readonly float m_geometryError; // 0x38
		private readonly int m_packedLaneWidth; // 0x3C
		private readonly int m_packedLayerInfoWidth; // 0x40
		private readonly MaterialPropertyBlock m_perDrawBlock; // 0x48
		private NativeArray<bool> m_splits; // 0xB0
		private NativeArray<int> m_visibility; // 0xC0
		private float m_geoLodMax; // 0xD0
		private readonly Dictionary<int, NativeList<ValueTuple<int, float>>> m_cameraRenderData; // 0xD8
		private readonly Dictionary<ushort, NativeArray<ValueTuple<int, float>>> m_fixedLevelRenderData; // 0xE0
		private ComputeBuffer m_perTerrainDataBuffer; // 0xE8
		private ComputeBuffer m_perTerrainFrameDataBuffer; // 0xF0
		private readonly Material m_terrainLitMaterial; // 0xF8
		private readonly LocalKeyword m_terrainLitMatLightmapOn; // 0x100
		private readonly Mesh m_tessellationQuadMesh; // 0x118
	
		// Properties
		private HGTerrainRuntimeResources.ChunkData chunkData { get => default; } // 0x0000000189C1A390-0x0000000189C1A430 
		// HGTerrainRuntimeResources+ChunkData get_chunkData()
		HGTerrainRuntimeResources_ChunkData *HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(
		        HGTerrainRuntimeResources_ChunkData *__return_ptr retstr,
		        HGTerrainRenderer *this,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGTerrainRuntimeResources *m_runtimeResources; // rax
		  __int128 v8; // xmm1
		  __int128 v9; // xmm0
		  Int32__Array *chunkLevel; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGTerrainRuntimeResources_ChunkData *v12; // rax
		  __int128 v13; // xmm1
		  HGTerrainRuntimeResources_ChunkData *result; // rax
		  HGTerrainRuntimeResources_ChunkData v15; // [rsp+20h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3941, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3941, 0LL);
		    if ( Patch )
		    {
		      v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1387(&v15, Patch, (Object *)this, 0LL);
		      v13 = *(_OWORD *)&v12->centerZs;
		      *(_OWORD *)&retstr->centerXs = *(_OWORD *)&v12->centerXs;
		      v9 = *(_OWORD *)&v12->extentYs;
		      *(_OWORD *)&retstr->centerZs = v13;
		      chunkLevel = v12->chunkLevel;
		      goto LABEL_7;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  m_runtimeResources = this->fields.m_runtimeResources;
		  if ( !m_runtimeResources )
		    goto LABEL_5;
		  v8 = *(_OWORD *)&m_runtimeResources->fields.chunkData.centerZs;
		  *(_OWORD *)&retstr->centerXs = *(_OWORD *)&m_runtimeResources->fields.chunkData.centerXs;
		  v9 = *(_OWORD *)&m_runtimeResources->fields.chunkData.extentYs;
		  *(_OWORD *)&retstr->centerZs = v8;
		  chunkLevel = m_runtimeResources->fields.chunkData.chunkLevel;
		LABEL_7:
		  *(_OWORD *)&retstr->extentYs = v9;
		  result = retstr;
		  retstr->chunkLevel = chunkLevel;
		  return result;
		}
		
		private Mesh chunkMesh { get => default; } // 0x0000000189C1A430-0x0000000189C1A494 
		// Mesh get_chunkMesh()
		Mesh *HG::Rendering::Runtime::HGTerrainRenderer::get_chunkMesh(HGTerrainRenderer *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  HGTerrainRuntimeResources *m_runtimeResources; // rax
		  HGTerrainRuntimeResources_MeshResources *meshes; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3942, 0LL) )
		  {
		    m_runtimeResources = this->fields.m_runtimeResources;
		    if ( m_runtimeResources )
		    {
		      meshes = m_runtimeResources->fields.meshes;
		      if ( meshes )
		        return meshes->fields.chunkMesh;
		    }
		LABEL_6:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3942, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_405(Patch, (Object *)this, 0LL);
		}
		
		private int[] packedSignificantLayerInfo { get => default; } // 0x0000000189C1A494-0x0000000189C1A4F0 
		// Int32[] get_packedSignificantLayerInfo()
		Int32__Array *HG::Rendering::Runtime::HGTerrainRenderer::get_packedSignificantLayerInfo(
		        HGTerrainRenderer *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  HGTerrainRuntimeResources *m_runtimeResources; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3943, 0LL) )
		  {
		    m_runtimeResources = this->fields.m_runtimeResources;
		    if ( m_runtimeResources )
		      return m_runtimeResources->fields.terrainLayerData.packedSignificantLayerInfo;
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3943, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1388(Patch, (Object *)this, 0LL);
		}
		
		private NativeArray<float> centerXs { get; } // 0x0000000184D8CE10-0x0000000184D8CE20 
		// ValueTuple`2[Boolean,Object] get_ResultOnSuccess()
		ValueTuple_2_Boolean_Object_ *System::Threading::Tasks::Task<System::ValueTuple<bool,System::Object>>::get_ResultOnSuccess(
		        ValueTuple_2_Boolean_Object_ *__return_ptr retstr,
		        Task_1_System_ValueTuple_2_Boolean_Object_ *this,
		        MethodInfo *method)
		{
		  ValueTuple_2_Boolean_Object_ *result; // rax
		
		  result = retstr;
		  *retstr = this->fields.m_result;
		  return result;
		}
		
		private NativeArray<float> centerYs { get; } // 0x0000000184DA1280-0x0000000184DA1290 
		// Vector4 get_ChannelB()
		Vector4 *PaintIn3D::P3dPaintReplaceChannels::get_ChannelB(
		        Vector4 *__return_ptr retstr,
		        P3dPaintReplaceChannels *this,
		        MethodInfo *method)
		{
		  Vector4 *result; // rax
		
		  result = retstr;
		  *retstr = this->fields.channelB;
		  return result;
		}
		
		private NativeArray<float> centerZs { get; } // 0x0000000184D8FD40-0x0000000184D8FD50 
		// Playable get_playable()
		Playable *UnityEngine::Timeline::RuntimeClip::get_playable(
		        Playable *__return_ptr retstr,
		        RuntimeClip *this,
		        MethodInfo *method)
		{
		  Playable *result; // rax
		
		  result = retstr;
		  *retstr = this->fields.m_Playable;
		  return result;
		}
		
		private NativeArray<float> extentXs { get; } // 0x0000000184D90620-0x0000000184D90630 
		// AnimationClipPlayable get_playable()
		AnimationClipPlayable *Beyond::Playables::SingleMixerAssetPlayer_4_TAsset_TAssetPlayable_TMixer_TOutput_::PlayableNode<System::Object,UnityEngine::Animations::AnimationClipPlayable,UnityEngine::Animations::AnimationMixerPlayable,UnityEngine::Animations::AnimationPlayableOutput>::get_playable(
		        AnimationClipPlayable *__return_ptr retstr,
		        SingleMixerAssetPlayer_4_TAsset_TAssetPlayable_TMixer_TOutput_PlayableNode_System_Object_UnityEngine_Animations_AnimationClipPlayable_UnityEngine_Animations_AnimationMixerPlayable_UnityEngine_Animations_AnimationPlayableOutput_ *this,
		        MethodInfo *method)
		{
		  AnimationClipPlayable *result; // rax
		
		  result = retstr;
		  *retstr = this->fields._playable_k__BackingField;
		  return result;
		}
		
		private NativeArray<float> extentYs { get; } // 0x0000000184D9DC90-0x0000000184D9DCA0 
		// NpcProxyOverrideEnvTalk+EnvTalkStruct get_value()
		NpcProxyOverrideEnvTalk_EnvTalkStruct *Beyond::Gameplay::ParamVariable<Beyond::Gameplay::Actions::NpcProxyOverrideEnvTalk::EnvTalkStruct>::get_value(
		        NpcProxyOverrideEnvTalk_EnvTalkStruct *__return_ptr retstr,
		        ParamVariable_1_Beyond_Gameplay_Actions_NpcProxyOverrideEnvTalk_EnvTalkStruct_ *this,
		        MethodInfo *method)
		{
		  NpcProxyOverrideEnvTalk_EnvTalkStruct *result; // rax
		
		  result = retstr;
		  *retstr = this->fields.m_value;
		  return result;
		}
		
		private NativeArray<float> extentZs { get; } // 0x0000000184DA1260-0x0000000184DA1270 
		// FloatProperty get_jobWeight()
		FloatProperty *UnityEngine::Animations::Rigging::TwoBoneIKConstraintJob::get_jobWeight(
		        FloatProperty *__return_ptr retstr,
		        TwoBoneIKConstraintJob *this,
		        MethodInfo *method)
		{
		  FloatProperty *result; // rax
		
		  result = retstr;
		  *retstr = this->_jobWeight_k__BackingField;
		  return result;
		}
		
	
		// Nested types
		public struct ChunkNode // TypeDefIndex: 38618
		{
			// Fields
			public Vector4 transform; // 0x00
			public short[] children; // 0x10
			public short parent; // 0x18
			public ushort level; // 0x1A
			public ushort lodData; // 0x1C
			public float distance; // 0x20
	
			// Methods
			public bool HasChildren() => default; // 0x0000000189C1D0B4-0x0000000189C1D11C
			// Boolean HasChildren()
			bool HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::HasChildren(
			        HGTerrainRenderer_ChunkNode *this,
			        MethodInfo *method)
			{
			  __int64 v3; // rdx
			  __int64 v4; // rcx
			  Int16__Array *children; // rax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3964, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3964, 0LL);
			    if ( Patch )
			      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1393(Patch, this, 0LL);
			LABEL_7:
			    sub_1800D8260(v4, v3);
			  }
			  children = this->children;
			  if ( !children )
			    goto LABEL_7;
			  if ( !children->max_length.size )
			    sub_1800D2AB0(v4, v3);
			  return children->vector[0] != -1;
			}
			
			public bool CheckSplit(ushort targetLod) => default; // 0x0000000189C1CEDC-0x0000000189C1CF50
			// Boolean CheckSplit(UInt16)
			bool HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::CheckSplit(
			        HGTerrainRenderer_ChunkNode *this,
			        uint16_t targetLod,
			        MethodInfo *method)
			{
			  bool result; // al
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v7; // rdx
			  __int64 v8; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3963, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3963, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v8, v7);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1394(Patch, this, targetLod, 0LL);
			  }
			  else
			  {
			    result = HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::HasChildren(this, 0LL);
			    if ( result )
			      return targetLod > (uint16_t)(this->lodData | 0xFF);
			  }
			  return result;
			}
			
			public void ClampAndSaveMorph(ushort targetLod) {} // 0x0000000189C1CF50-0x0000000189C1D040
			// Void ClampAndSaveMorph(UInt16)
			void HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::ClampAndSaveMorph(
			        HGTerrainRenderer_ChunkNode *this,
			        uint16_t targetLod,
			        MethodInfo *method)
			{
			  uint16_t lodData; // di
			  uint16_t v6; // bx
			  uint16_t v7; // di
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v9; // rdx
			  __int64 v10; // rcx
			
			  if ( IFix::WrappersManagerImpl::IsPatched(3966, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(3966, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v10, v9);
			    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1395(Patch, this, targetLod, 0LL);
			  }
			  else
			  {
			    lodData = this->lodData;
			    sub_1800036A0(TypeInfo::System::Math);
			    v6 = lodData | 0xFF;
			    v7 = lodData & 0xFF00;
			    if ( !byte_18F395692 )
			    {
			      sub_180035ED0(&MethodInfo::System::Math::ThrowMinMaxException<unsigned short>);
			      sub_180035ED0(&TypeInfo::System::Math);
			      byte_18F395692 = 1;
			    }
			    if ( v7 > v6 )
			    {
			      sub_1800036A0(TypeInfo::System::Math);
			      System::Math::ThrowMinMaxException<unsigned short>(
			        v7,
			        v6,
			        MethodInfo::System::Math::ThrowMinMaxException<unsigned short>);
			    }
			    if ( targetLod < v7 )
			    {
			      v6 = v7;
			    }
			    else if ( targetLod <= v6 )
			    {
			      v6 = targetLod;
			    }
			    this->lodData = v6;
			  }
			}
			
			public float GetMorphValue() => default; // 0x0000000189C1D040-0x0000000189C1D0B4
			// Single GetMorphValue()
			float HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::GetMorphValue(
			        HGTerrainRenderer_ChunkNode *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v5; // rdx
			  __int64 v6; // rcx
			
			  if ( !IFix::WrappersManagerImpl::IsPatched(3967, 0LL) )
			    return 1.0 - (float)((float)(unsigned __int8)this->lodData / 255.0);
			  Patch = IFix::WrappersManagerImpl::GetPatch(3967, 0LL);
			  if ( !Patch )
			    sub_1800D8260(v6, v5);
			  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1397(Patch, this, 0LL);
			}
			
		}
	
		public enum TerrainPassType // TypeDefIndex: 38619
		{
			Invalid = -1,
			GBuffer = 0,
			Feedback = 1,
			ShadowCaster = 2,
			TessellationGBuffer = 3,
			TerrainDepthOnly = 4,
			TessellationTerrainDepthOnly = 5,
			ScreenSpaceTerrain = 6,
			PassCount = 7
		}
	
		[IsReadOnly]
		private struct ChunkComparer : IComparer<ValueTuple<int, float>> // TypeDefIndex: 38620
		{
			// Fields
			private readonly ChunkNode[] m_chunkNodes; // 0x00
	
			// Constructors
			public ChunkComparer(ChunkNode[] chunkNodes) {
				m_chunkNodes = default;
			} // 0x0000000185392320-0x0000000185392328
			// Void WriteUnaligned[Object](Byte ByRef, Object)
			void System::Runtime::CompilerServices::Unsafe::WriteUnaligned<System::Object>(
			        uint8_t *destination,
			        Object *value,
			        MethodInfo *method)
			{
			  Int32__Array **v3; // r9
			  MethodInfo *v4; // [rsp+28h] [rbp+28h]
			
			  *(_QWORD *)destination = value;
			  sub_18002D1B0(
			    (HGRuntimeGrassQuery_Node *)destination,
			    (HGRuntimeGrassQuery_Node *)value,
			    (HGRuntimeGrassQuery_Node *)method,
			    v3,
			    v4);
			}
			
	
			// Methods
			public int Compare(ValueTuple<int, float> lhs, ValueTuple<int, float> rhs) => default; // 0x0000000189C1CE30-0x0000000189C1CEDC
			// Int32 Compare(ValueTuple`2[Int32,Single], ValueTuple`2[Int32,Single])
			int32_t HG::Rendering::Runtime::HGTerrainRenderer::ChunkComparer::Compare(
			        HGTerrainRenderer_ChunkComparer *this,
			        ValueTuple_2_Int32_Single_ lhs,
			        ValueTuple_2_Int32_Single_ rhs,
			        MethodInfo *method)
			{
			  __int64 v7; // rdx
			  HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // rcx
			  __int64 v9; // rax
			  float v10; // xmm6_4
			  __int64 v11; // rax
			  int32_t v12; // ecx
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			
			  if ( IFix::WrappersManagerImpl::IsPatched(4028, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(4028, 0LL);
			    if ( Patch )
			      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1418(Patch, this, lhs, rhs, 0LL);
			LABEL_8:
			    sub_1800D8260(m_chunkNodes, v7);
			  }
			  m_chunkNodes = this->m_chunkNodes;
			  if ( !this->m_chunkNodes )
			    goto LABEL_8;
			  v9 = sub_180444A00(m_chunkNodes, lhs.Item1);
			  m_chunkNodes = this->m_chunkNodes;
			  v10 = *(float *)(v9 + 32);
			  if ( !this->m_chunkNodes )
			    goto LABEL_8;
			  v11 = sub_180444A00(m_chunkNodes, rhs.Item1);
			  v12 = 1;
			  if ( *(float *)(v11 + 32) >= v10 )
			    return -1;
			  return v12;
			}
			
		}
	
		// Constructors
		public HGTerrainRenderer() {} // Dummy constructor
		public HGTerrainRenderer(TerrainResource terrainResource) {} // 0x0000000189C198B0-0x0000000189C1A390
		// HGTerrainRenderer(TerrainResource)
		void HG::Rendering::Runtime::HGTerrainRenderer::HGTerrainRenderer(
		        HGTerrainRenderer *this,
		        TerrainResource *terrainResource,
		        MethodInfo *method)
		{
		  VirtualTextureRenderer *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  VirtualTextureRenderer *v8; // rsi
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  __int128 v12; // xmm2
		  Texture2DArray *decalNormalMROTexArray; // xmm1_8
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  Texture2DArray *v17; // xmm1_8
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  HGTerrainConfiguration *m_configuration; // rax
		  HGTerrainRuntimeResources *m_runtimeResources; // rax
		  HGTerrainRuntimeResources_ChunkData *chunkData; // rax
		  __int128 v24; // xmm1
		  Int32__Array *chunkLevel; // xmm0_8
		  Single__Array *centerXs; // rax
		  __int64 size; // rsi
		  HGTerrainRuntimeResources_ChunkData *v28; // rax
		  Single__Array *v29; // rdx
		  __int128 v30; // xmm1
		  Int32__Array *v31; // xmm0_8
		  HGTerrainRuntimeResources_ChunkData *v32; // rax
		  Single__Array *centerYs; // rdx
		  __int128 v34; // xmm1
		  Int32__Array *v35; // xmm0_8
		  HGTerrainRuntimeResources_ChunkData *v36; // rax
		  Single__Array *centerZs; // rdx
		  __int128 v38; // xmm0
		  HGTerrainRuntimeResources_ChunkData *v39; // rax
		  Single__Array *extentXs; // rdx
		  __int128 v41; // xmm0
		  HGTerrainRuntimeResources_ChunkData *v42; // rax
		  Single__Array *extentYs; // rdx
		  __int128 v44; // xmm1
		  HGTerrainRuntimeResources_ChunkData *v45; // rax
		  Single__Array *extentZs; // rdx
		  __int128 v47; // xmm1
		  HGRuntimeGrassQuery_Node *v48; // rdx
		  HGRuntimeGrassQuery_Node *v49; // r8
		  Int32__Array **v50; // r9
		  int32_t v51; // ebx
		  __int64 v52; // r13
		  __int64 v53; // rsi
		  HGTerrainRuntimeResources_ChunkData *v54; // rax
		  MethodInfo *v55; // r9
		  __int128 v56; // xmm0
		  Int32__Array *v57; // xmm1_8
		  __int128 v58; // xmm0
		  int32_t v59; // r15d
		  __int16 v60; // r14
		  float v61; // xmm6_4
		  float v62; // r10d
		  HGRuntimeGrassQuery_Node *v63; // xmm0_8
		  Vector3 *v64; // rax
		  HGRuntimeGrassQuery_Node *v65; // xmm5_8
		  int v66; // r10d
		  __int64 v67; // xmm3_8
		  __int64 v68; // xmm4_8
		  MethodInfo *v69; // r9
		  Vector3 *v70; // rax
		  HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // r12
		  __int64 v72; // xmm3_8
		  int v73; // eax
		  __int64 v74; // rax
		  Int32__Array **v75; // r9
		  Mesh *chunkMesh; // rax
		  __int64 v77; // rdx
		  __int64 v78; // rcx
		  __int64 v79; // r8
		  double v80; // xmm0_8
		  __int64 v81; // rax
		  Vector3__Array *v82; // r14
		  Vector3__Array *v83; // r15
		  Vector2__Array *v84; // r12
		  UInt16__Array *v85; // rbx
		  int32_t v86; // esi
		  float v87; // xmm7_4
		  float v88; // xmm6_4
		  __int64 v89; // rax
		  int32_t v90; // r9d
		  int v91; // r8d
		  __int64 v92; // r10
		  int32_t v93; // r9d
		  int v94; // eax
		  __int64 v95; // r10
		  int32_t v96; // r9d
		  unsigned int v97; // r10d
		  __int64 v98; // rax
		  Mesh *v99; // rax
		  Object_1 *v100; // rsi
		  HGRuntimeGrassQuery_Node *v101; // rdx
		  HGRuntimeGrassQuery_Node *v102; // r8
		  Int32__Array **v103; // r9
		  HGTerrainRuntimeResources *v104; // rbx
		  Object_1 *terrainLitMaterial; // rbx
		  bool v106; // al
		  HGRuntimeGrassQuery_Node *v107; // r8
		  Int32__Array **v108; // r9
		  __int64 v109; // rax
		  Shader *v110; // rsi
		  Material *v111; // rax
		  Material *v112; // rbx
		  HGTerrainRuntimeResources_ShaderResources *shaders; // rdx
		  __int64 v114; // rcx
		  HGTerrainRuntimeResources *v115; // r9
		  Shader *terrainLitPS; // rdx
		  __int64 v117; // xmm1_8
		  HGRuntimeGrassQuery_Node *v118; // rdx
		  HGRuntimeGrassQuery_Node *v119; // r8
		  Int32__Array **v120; // r9
		  Dictionary_2_System_Int32_Unity_Collections_NativeList_1_System_ValueTuple_2_Int32_Single_ *v121; // rax
		  Dictionary_2_System_Int32_Unity_Collections_NativeList_1_System_ValueTuple_2_Int32_Single_ *v122; // rbx
		  HGRuntimeGrassQuery_Node *v123; // rdx
		  HGRuntimeGrassQuery_Node *v124; // r8
		  Int32__Array **v125; // r9
		  Dictionary_2_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_ *v126; // rax
		  Dictionary_2_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_ *v127; // rbx
		  HGRuntimeGrassQuery_Node *v128; // rdx
		  HGRuntimeGrassQuery_Node *v129; // r8
		  Int32__Array **v130; // r9
		  MaterialPropertyBlock *v131; // rbx
		  HGRuntimeGrassQuery_Node *v132; // rdx
		  HGRuntimeGrassQuery_Node *v133; // r8
		  Int32__Array **v134; // r9
		  MethodInfo *calculateBounds; // [rsp+28h] [rbp-E0h]
		  MethodInfo *calculateBoundsh; // [rsp+28h] [rbp-E0h]
		  MethodInfo *calculateBoundsi; // [rsp+28h] [rbp-E0h]
		  MethodInfo *calculateBoundsa; // [rsp+28h] [rbp-E0h]
		  MethodInfo *calculateBoundsb; // [rsp+28h] [rbp-E0h]
		  MethodInfo *calculateBoundsj; // [rsp+28h] [rbp-E0h]
		  MethodInfo *calculateBoundsc; // [rsp+28h] [rbp-E0h]
		  MethodInfo *calculateBoundsd; // [rsp+28h] [rbp-E0h]
		  MethodInfo *calculateBoundse; // [rsp+28h] [rbp-E0h]
		  MethodInfo *calculateBoundsf; // [rsp+28h] [rbp-E0h]
		  MethodInfo *calculateBoundsg; // [rsp+28h] [rbp-E0h]
		  LocalKeyword v146; // [rsp+48h] [rbp-C0h] BYREF
		  __int128 v147; // [rsp+68h] [rbp-A0h] BYREF
		  __int128 v148; // [rsp+78h] [rbp-90h]
		  __int128 v149; // [rsp+88h] [rbp-80h]
		  Int32__Array *v150; // [rsp+98h] [rbp-70h]
		  float z; // [rsp+A8h] [rbp-60h]
		  __int128 v152; // [rsp+B0h] [rbp-58h]
		  HGRuntimeGrassQuery_Node v153; // [rsp+C0h] [rbp-48h] BYREF
		  Vector3 v154; // [rsp+108h] [rbp+0h] BYREF
		  __int64 v155; // [rsp+118h] [rbp+10h]
		  __int64 v156; // [rsp+128h] [rbp+20h]
		  HGTerrainRuntimeResources_ChunkData v157; // [rsp+138h] [rbp+30h] BYREF
		  Vector3 v158; // [rsp+170h] [rbp+68h] BYREF
		  Vector3 v159[4]; // [rsp+180h] [rbp+78h] BYREF
		  float v160; // [rsp+200h] [rbp+F8h]
		
		  v152 = 0LL;
		  memset(&v153, 0, 24);
		  v5 = (VirtualTextureRenderer *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::VirtualTextureRenderer);
		  v8 = v5;
		  if ( !v5 )
		    goto LABEL_62;
		  HG::Rendering::Runtime::VirtualTextureRenderer::VirtualTextureRenderer(v5, terrainResource, 0LL);
		  this->fields.m_vtRenderer = v8;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v9, v10, v11, calculateBounds);
		  v12 = *(_OWORD *)&terrainResource->runtimeResources;
		  decalNormalMROTexArray = terrainResource->decalNormalMROTexArray;
		  v148 = *(_OWORD *)&terrainResource->terrainCollider;
		  this->fields.m_runtimeResources = (HGTerrainRuntimeResources *)v12;
		  *(_QWORD *)&v149 = decalNormalMROTexArray;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_runtimeResources, v14, v15, v16, calculateBoundsh);
		  v17 = terrainResource->decalNormalMROTexArray;
		  v148 = *(_OWORD *)&terrainResource->terrainCollider;
		  *(_QWORD *)&v149 = v17;
		  this->fields.m_configuration = terrainResource->configuration;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_configuration, v18, v19, v20, calculateBoundsi);
		  m_configuration = this->fields.m_configuration;
		  if ( !m_configuration )
		    goto LABEL_62;
		  this->fields.m_geometryError = m_configuration->fields.chunkedLodGeometryError;
		  m_runtimeResources = this->fields.m_runtimeResources;
		  if ( !m_runtimeResources )
		    goto LABEL_62;
		  this->fields.m_treeDepth = m_runtimeResources->fields.chunkTreeDepth;
		  chunkData = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(&v157, this, 0LL);
		  v24 = *(_OWORD *)&chunkData->extentYs;
		  v148 = *(_OWORD *)&chunkData->centerZs;
		  chunkLevel = chunkData->chunkLevel;
		  centerXs = chunkData->centerXs;
		  v150 = chunkLevel;
		  v149 = v24;
		  if ( !centerXs )
		    goto LABEL_62;
		  size = centerXs->max_length.size;
		  v28 = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(&v157, this, 0LL);
		  v29 = v28->centerXs;
		  v30 = *(_OWORD *)&v28->extentYs;
		  v148 = *(_OWORD *)&v28->centerZs;
		  v31 = v28->chunkLevel;
		  v149 = v30;
		  v150 = v31;
		  *(_OWORD *)&v146.m_SpaceInfo.m_KeywordSpace = 0LL;
		  Unity::Collections::NativeArray<float>::NativeArray(
		    (NativeArray_1_System_Single_ *)&v146,
		    v29,
		    Allocator__Enum_Persistent,
		    MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
		  this->fields._centerXs_k__BackingField = *(NativeArray_1_System_Single_ *)&v146.m_SpaceInfo.m_KeywordSpace;
		  v32 = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(&v157, this, 0LL);
		  centerYs = v32->centerYs;
		  v34 = *(_OWORD *)&v32->extentYs;
		  v148 = *(_OWORD *)&v32->centerZs;
		  v35 = v32->chunkLevel;
		  v149 = v34;
		  v150 = v35;
		  *(_OWORD *)&v146.m_SpaceInfo.m_KeywordSpace = 0LL;
		  Unity::Collections::NativeArray<float>::NativeArray(
		    (NativeArray_1_System_Single_ *)&v146,
		    centerYs,
		    Allocator__Enum_Persistent,
		    MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
		  this->fields._centerYs_k__BackingField = *(NativeArray_1_System_Single_ *)&v146.m_SpaceInfo.m_KeywordSpace;
		  v36 = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(&v157, this, 0LL);
		  centerZs = v36->centerZs;
		  *(_QWORD *)&v34 = v36->chunkLevel;
		  v147 = *(_OWORD *)&v36->centerXs;
		  v38 = *(_OWORD *)&v36->extentYs;
		  v150 = (Int32__Array *)v34;
		  v149 = v38;
		  *(_OWORD *)&v146.m_SpaceInfo.m_KeywordSpace = 0LL;
		  Unity::Collections::NativeArray<float>::NativeArray(
		    (NativeArray_1_System_Single_ *)&v146,
		    centerZs,
		    Allocator__Enum_Persistent,
		    MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
		  this->fields._centerZs_k__BackingField = *(NativeArray_1_System_Single_ *)&v146.m_SpaceInfo.m_KeywordSpace;
		  v39 = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(&v157, this, 0LL);
		  extentXs = v39->extentXs;
		  *(_QWORD *)&v34 = v39->chunkLevel;
		  v147 = *(_OWORD *)&v39->centerXs;
		  v41 = *(_OWORD *)&v39->extentYs;
		  v150 = (Int32__Array *)v34;
		  v149 = v41;
		  *(_OWORD *)&v146.m_SpaceInfo.m_KeywordSpace = 0LL;
		  Unity::Collections::NativeArray<float>::NativeArray(
		    (NativeArray_1_System_Single_ *)&v146,
		    extentXs,
		    Allocator__Enum_Persistent,
		    MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
		  this->fields._extentXs_k__BackingField = *(NativeArray_1_System_Single_ *)&v146.m_SpaceInfo.m_KeywordSpace;
		  v42 = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(&v157, this, 0LL);
		  extentYs = v42->extentYs;
		  v44 = *(_OWORD *)&v42->centerZs;
		  v147 = *(_OWORD *)&v42->centerXs;
		  *(_QWORD *)&v41 = v42->chunkLevel;
		  v148 = v44;
		  v150 = (Int32__Array *)v41;
		  *(_OWORD *)&v146.m_SpaceInfo.m_KeywordSpace = 0LL;
		  Unity::Collections::NativeArray<float>::NativeArray(
		    (NativeArray_1_System_Single_ *)&v146,
		    extentYs,
		    Allocator__Enum_Persistent,
		    MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
		  this->fields._extentYs_k__BackingField = *(NativeArray_1_System_Single_ *)&v146.m_SpaceInfo.m_KeywordSpace;
		  v45 = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(&v157, this, 0LL);
		  extentZs = v45->extentZs;
		  v47 = *(_OWORD *)&v45->centerZs;
		  v147 = *(_OWORD *)&v45->centerXs;
		  *(_QWORD *)&v41 = v45->chunkLevel;
		  v148 = v47;
		  v150 = (Int32__Array *)v41;
		  *(_OWORD *)&v146.m_SpaceInfo.m_KeywordSpace = 0LL;
		  Unity::Collections::NativeArray<float>::NativeArray(
		    (NativeArray_1_System_Single_ *)&v146,
		    extentZs,
		    Allocator__Enum_Persistent,
		    MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
		  this->fields._extentZs_k__BackingField = *(NativeArray_1_System_Single_ *)&v146.m_SpaceInfo.m_KeywordSpace;
		  this->fields.m_chunkNodes = (HGTerrainRenderer_ChunkNode__Array *)il2cpp_array_new_specific_1(
		                                                                      TypeInfo::HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode,
		                                                                      (unsigned int)size);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_chunkNodes, v48, v49, v50, calculateBoundsa);
		  v51 = 0;
		  if ( (int)size > 0 )
		  {
		    v52 = size;
		    v53 = 0LL;
		    while ( 1 )
		    {
		      v54 = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkData(&v157, this, 0LL);
		      v56 = *(_OWORD *)&v54->centerXs;
		      v148 = *(_OWORD *)&v54->centerZs;
		      v57 = v54->chunkLevel;
		      v147 = v56;
		      v58 = *(_OWORD *)&v54->extentYs;
		      v150 = v57;
		      v149 = v58;
		      if ( !v57 )
		        break;
		      if ( (unsigned int)v51 >= v57->max_length.size )
		        goto LABEL_61;
		      v59 = v57->vector[v51];
		      v60 = this->fields.m_treeDepth - v59 - 1;
		      v61 = *(float *)&this->fields._centerZs_k__BackingField.m_Buffer[4 * v53];
		      v62 = *(float *)&this->fields._extentZs_k__BackingField.m_Buffer[4 * v53];
		      v63 = (HGRuntimeGrassQuery_Node *)_mm_unpacklo_ps(
		                                          (__m128)*(_DWORD *)&this->fields._centerXs_k__BackingField.m_Buffer[4 * v53],
		                                          (__m128)*(_DWORD *)&this->fields._centerYs_k__BackingField.m_Buffer[4 * v53]).m128_u64[0];
		      *(_QWORD *)&v153.fields.bounds.m_Center.z = _mm_unpacklo_ps(
		                                                    (__m128)*(_DWORD *)&this->fields._extentXs_k__BackingField.m_Buffer[4 * v53],
		                                                    (__m128)*(_DWORD *)&this->fields._extentYs_k__BackingField.m_Buffer[4 * v53]).m128_u64[0];
		      *(float *)&v153.fields.left = v61;
		      v153.fields.bounds.m_Extents.y = v62;
		      v153.fields.parent = v63;
		      v64 = UnityEngine::Vector3::op_Addition(
		              &v158,
		              (Vector3 *)&v153.fields.parent,
		              (Vector3 *)&v153.fields.bounds.m_Center.z,
		              v55);
		      v154.z = v61;
		      v153.fields.right = v65;
		      LODWORD(v153.fields.grassInstanceBounds) = v66;
		      v67 = *(_QWORD *)&v64->x;
		      *(float *)&v64 = v64->z;
		      v155 = v67;
		      v160 = *(float *)&v64;
		      *(_QWORD *)&v154.x = v68;
		      v70 = UnityEngine::Vector3::op_Subtraction(v159, &v154, (Vector3 *)&v153.fields.right, v69);
		      m_chunkNodes = this->fields.m_chunkNodes;
		      v72 = *(_QWORD *)&v70->x;
		      z = v70->z;
		      v156 = v72;
		      v152 = 0LL;
		      memset(&v153, 0, 24);
		      if ( v51 )
		        v73 = (v51 - 1) / 4;
		      else
		        LOWORD(v73) = -1;
		      LOWORD(v153.monitor) = v73;
		      v74 = il2cpp_array_new_specific_1(TypeInfo::System::Int16, 4LL);
		      v7 = 0xFFFFFFFFLL;
		      if ( v59 )
		        v7 = (unsigned int)(4 * v51 + 1);
		      if ( !v74 )
		        break;
		      if ( !*(_DWORD *)(v74 + 24) )
		        goto LABEL_61;
		      *(_WORD *)(v74 + 32) = v7;
		      v7 = 0xFFFFFFFFLL;
		      if ( v59 )
		        v7 = (unsigned int)(4 * v51 + 2);
		      v6 = 1LL;
		      if ( *(_DWORD *)(v74 + 24) <= 1u )
		        goto LABEL_61;
		      *(_WORD *)(v74 + 34) = v7;
		      v7 = 0xFFFFFFFFLL;
		      if ( v59 )
		        v7 = (unsigned int)(4 * v51 + 3);
		      if ( *(_DWORD *)(v74 + 24) <= 2u )
		        goto LABEL_61;
		      *(_WORD *)(v74 + 36) = v7;
		      v7 = 0xFFFFFFFFLL;
		      if ( v59 )
		        v7 = (unsigned int)(4 * v51 + 4);
		      if ( *(_DWORD *)(v74 + 24) <= 3u )
		LABEL_61:
		        sub_1800D2AB0(v7, v6);
		      *(_WORD *)(v74 + 38) = v7;
		      v153.klass = (HGRuntimeGrassQuery_Node__Class *)v74;
		      sub_18002D1B0(
		        &v153,
		        (HGRuntimeGrassQuery_Node *)1,
		        (HGRuntimeGrassQuery_Node *)0xFFFFFFFFLL,
		        v75,
		        calculateBoundsb);
		      v146.m_Name = (String *)__PAIR64__(LODWORD(z), v156);
		      WORD1(v153.monitor) = v60;
		      WORD2(v153.monitor) = v60 << 8;
		      *(float *)&v146.m_SpaceInfo.m_KeywordSpace = *(float *)&v155 - *(float *)&v156;
		      *((float *)&v146.m_SpaceInfo.m_KeywordSpace + 1) = v160 - z;
		      v152 = *(_OWORD *)&v146.m_SpaceInfo.m_KeywordSpace;
		      if ( !m_chunkNodes )
		        break;
		      v147 = *(_OWORD *)&v146.m_SpaceInfo.m_KeywordSpace;
		      v148 = *(_OWORD *)&v153.klass;
		      *(_QWORD *)&v149 = *(_QWORD *)&v153.fields.bounds.m_Center.x;
		      sub_180590700(m_chunkNodes, v51++, &v147);
		      if ( ++v53 >= v52 )
		        goto LABEL_27;
		    }
		LABEL_62:
		    sub_1800D8260(v7, v6);
		  }
		LABEL_27:
		  chunkMesh = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkMesh(this, 0LL);
		  if ( !chunkMesh )
		    goto LABEL_62;
		  UnityEngine::Mesh::UploadMeshData(chunkMesh, 1, 0LL);
		  v80 = sub_182F114D0(v78, v77, v79);
		  v6 = (unsigned int)(32 % (int)*(float *)&v80);
		  v7 = (__int64)this->fields.m_runtimeResources;
		  this->fields.m_packedLaneWidth = 32 / (int)*(float *)&v80;
		  if ( !v7 )
		    goto LABEL_62;
		  this->fields.m_packedLayerInfoWidth = (32 / (int)*(float *)&v80 + *(_DWORD *)(v7 + 24) - 1)
		                                      / (32
		                                       / (int)*(float *)&v80);
		  v81 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 1089LL);
		  v82 = (Vector3__Array *)v81;
		  if ( !v81 )
		    goto LABEL_62;
		  v83 = (Vector3__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, *(unsigned int *)(v81 + 24));
		  v84 = (Vector2__Array *)il2cpp_array_new_specific_1(
		                            TypeInfo::UnityEngine::Vector2,
		                            (unsigned int)v82->max_length.size);
		  v85 = (UInt16__Array *)il2cpp_array_new_specific_1(TypeInfo::System::UInt16, 6144LL);
		  v86 = 0;
		  while ( v86 < v82->max_length.size )
		  {
		    v87 = (float)(v86 / 33) * 0.03125;
		    v88 = (float)(v86 % 33) * 0.03125;
		    *(float *)sub_180002E90(v82, v86) = v88;
		    *(_DWORD *)(sub_180002E90(v82, v86) + 4) = 0;
		    *(float *)(sub_180002E90(v82, v86) + 8) = v87;
		    if ( !v83 )
		      goto LABEL_62;
		    *(_DWORD *)sub_180002E90(v83, v86) = 0;
		    *(_DWORD *)(sub_180002E90(v83, v86) + 4) = 1065353216;
		    *(_DWORD *)(sub_180002E90(v83, v86) + 8) = 0;
		    if ( !v84 )
		      goto LABEL_62;
		    *(float *)sub_1800036C0(v84, v86) = v88;
		    v89 = sub_1800036C0(v84, v86++);
		    *(float *)(v89 + 4) = v87;
		  }
		  v90 = 0;
		  v6 = 0LL;
		  do
		  {
		    v91 = 0;
		    if ( !v85 )
		      goto LABEL_62;
		    do
		    {
		      if ( (unsigned int)v90 >= v85->max_length.size )
		        goto LABEL_61;
		      v7 = 33 * (unsigned int)(unsigned __int16)v6;
		      v92 = v90 + 1LL;
		      LOWORD(v7) = v91 + 33 * v6;
		      v85->vector[v90] = v7;
		      if ( (unsigned int)v92 >= v85->max_length.size )
		        goto LABEL_61;
		      v93 = v90 + 2;
		      v94 = (unsigned __int16)(v6 + 1);
		      v7 = (unsigned int)(33 * v94);
		      LOWORD(v7) = v91 + 33 * v94;
		      v85->vector[v92] = v7;
		      if ( (unsigned int)v93 >= v85->max_length.size )
		        goto LABEL_61;
		      v7 = 33 * (unsigned int)(unsigned __int16)v6;
		      v95 = v93 + 1LL;
		      LOWORD(v7) = v91 + 33 * v6 + 1;
		      v85->vector[v93] = v7;
		      if ( (unsigned int)v95 >= v85->max_length.size )
		        goto LABEL_61;
		      v96 = v93 + 2;
		      v7 = 33 * (unsigned int)(unsigned __int16)v6;
		      LOWORD(v7) = v91 + 33 * v6 + 34;
		      v85->vector[v95] = v7;
		      if ( (unsigned int)v96 >= v85->max_length.size )
		        goto LABEL_61;
		      v97 = v96 + 1;
		      v7 = 33 * (unsigned int)(unsigned __int16)v6;
		      v98 = v96;
		      v90 = v96 + 2;
		      LOWORD(v7) = v91 + 33 * v6 + 1;
		      v85->vector[v98] = v7;
		      if ( v97 >= v85->max_length.size )
		        goto LABEL_61;
		      v7 = 33 * (unsigned int)(unsigned __int16)(v6 + 1);
		      LOWORD(v7) = v91++ + 33 * (v6 + 1);
		      v85->vector[v97] = v7;
		    }
		    while ( v91 < 32 );
		    v6 = (unsigned int)(v6 + 1);
		  }
		  while ( (int)v6 < 32 );
		  v99 = (Mesh *)sub_18002C620(TypeInfo::UnityEngine::Mesh);
		  v100 = (Object_1 *)v99;
		  if ( !v99 )
		    goto LABEL_62;
		  UnityEngine::Mesh::Mesh(v99, 0LL);
		  UnityEngine::Object::set_name(v100, (String *)"HG_TessellationQuad", 0LL);
		  UnityEngine::Mesh::SetVertices((Mesh *)v100, v82, 0LL);
		  UnityEngine::Mesh::SetNormals((Mesh *)v100, v83, 0LL);
		  UnityEngine::Mesh::SetUVs((Mesh *)v100, 0, v84, 0LL);
		  UnityEngine::Mesh::SetIndices((Mesh *)v100, v85, MeshTopology__Enum_Triangles, 0, 1, 0, 0LL);
		  this->fields.m_tessellationQuadMesh = (Mesh *)v100;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_tessellationQuadMesh, v101, v102, v103, calculateBoundsj);
		  v104 = this->fields.m_runtimeResources;
		  if ( !v104 )
		    goto LABEL_62;
		  terrainLitMaterial = (Object_1 *)v104->fields.terrainLitMaterial;
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  v106 = UnityEngine::Object::op_Equality(terrainLitMaterial, 0LL, 0LL);
		  v7 = (__int64)this->fields.m_runtimeResources;
		  if ( v106 )
		  {
		    if ( !v7 )
		      goto LABEL_62;
		    v109 = *(_QWORD *)(v7 + 264);
		    if ( !v109 )
		      goto LABEL_62;
		    v110 = *(Shader **)(v109 + 16);
		    v111 = (Material *)sub_18002C620(TypeInfo::UnityEngine::Material);
		    v112 = v111;
		    if ( !v111 )
		      goto LABEL_62;
		    UnityEngine::Material::Material(v111, v110, 0LL);
		  }
		  else
		  {
		    if ( !v7 )
		      goto LABEL_62;
		    v112 = *(Material **)(v7 + 272);
		  }
		  this->fields.m_terrainLitMaterial = v112;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_terrainLitMaterial,
		    (HGRuntimeGrassQuery_Node *)v6,
		    v107,
		    v108,
		    calculateBoundsc);
		  v115 = this->fields.m_runtimeResources;
		  if ( !v115 )
		    goto LABEL_60;
		  shaders = v115->fields.shaders;
		  if ( !shaders )
		    goto LABEL_60;
		  terrainLitPS = shaders->fields.terrainLitPS;
		  memset(&v146, 0, sizeof(v146));
		  UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v146, terrainLitPS, (String *)"LIGHTMAP_ON", 0LL);
		  v117 = *(_QWORD *)&v146.m_Index;
		  *(_OWORD *)&this->fields.m_terrainLitMatLightmapOn.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v146.m_SpaceInfo.m_KeywordSpace;
		  *(_QWORD *)&this->fields.m_terrainLitMatLightmapOn.m_Index = v117;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_terrainLitMatLightmapOn.m_Name,
		    v118,
		    v119,
		    v120,
		    calculateBoundsd);
		  v121 = (Dictionary_2_System_Int32_Unity_Collections_NativeList_1_System_ValueTuple_2_Int32_Single_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>);
		  v122 = v121;
		  if ( !v121 )
		    goto LABEL_60;
		  System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::Dictionary(
		    v121,
		    MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::Dictionary);
		  this->fields.m_cameraRenderData = v122;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_cameraRenderData, v123, v124, v125, calculateBoundse);
		  v126 = (Dictionary_2_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_ *)sub_18002C620(TypeInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>);
		  v127 = v126;
		  if ( !v126
		    || (System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::Dictionary(
		          v126,
		          MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::Dictionary),
		        this->fields.m_fixedLevelRenderData = v127,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&this->fields.m_fixedLevelRenderData,
		          v128,
		          v129,
		          v130,
		          calculateBoundsf),
		        (v131 = (MaterialPropertyBlock *)sub_18002C620(TypeInfo::UnityEngine::MaterialPropertyBlock)) == 0LL) )
		  {
		LABEL_60:
		    sub_1800D8260(v114, shaders);
		  }
		  v131->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  this->fields.m_perDrawBlock = v131;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_perDrawBlock, v132, v133, v134, calculateBoundsg);
		}
		
		static HGTerrainRenderer() {} // 0x0000000189C19858-0x0000000189C198B0
		// HGTerrainRenderer()
		void HG::Rendering::Runtime::HGTerrainRenderer::cctor(MethodInfo *method)
		{
		  Array *v1; // rbx
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v3; // r8
		  Int32__Array **v4; // r9
		  MethodInfo *v5; // [rsp+50h] [rbp+28h]
		
		  v1 = (Array *)il2cpp_array_new_specific_1(TypeInfo::HG::Rendering::Runtime::HGTerrainRenderer::TerrainPassType, 7LL);
		  System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		    v1,
		    7181B72238B3207C547552CE4C3CAF309F6442FFF1C5A0BCC4DFC82D783C8754_Field,
		    0LL);
		  static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGTerrainRenderer->static_fields;
		  static_fields->klass = (HGRuntimeGrassQuery_Node__Class *)v1;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGTerrainRenderer->static_fields,
		    static_fields,
		    v3,
		    v4,
		    v5);
		}
		
	
		// Methods
		[IDTag(0)]
		public void TraverseAndCullQuadTreeFixedLevel(int l) {} // 0x0000000189C18AD4-0x0000000189C18C38
		// Void TraverseAndCullQuadTreeFixedLevel(Int32)
		void HG::Rendering::Runtime::HGTerrainRenderer::TraverseAndCullQuadTreeFixedLevel(
		        HGTerrainRenderer *this,
		        int32_t l,
		        MethodInfo *method)
		{
		  uint16_t v5; // ax
		  __int64 v6; // rdx
		  Dictionary_2_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_ *m_fixedLevelRenderData; // rcx
		  int32_t v8; // esi
		  int32_t v9; // eax
		  __int64 v10; // rbp
		  int i; // ebx
		  Void *m_Buffer; // r8
		  __int64 j; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  NativeArray_1_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ v15; // [rsp+30h] [rbp-18h] BYREF
		  __int64 v16; // [rsp+68h] [rbp+20h]
		
		  v15 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3944, 0LL) )
		  {
		    v5 = HG::Rendering::Runtime::HGTerrainRenderer::_ClampLevel(this, l, 0LL);
		    m_fixedLevelRenderData = this->fields.m_fixedLevelRenderData;
		    v8 = v5;
		    if ( m_fixedLevelRenderData )
		    {
		      if ( System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::ContainsKey(
		             m_fixedLevelRenderData,
		             v5,
		             MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::ContainsKey) )
		      {
		        return;
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
		      v9 = HG::Rendering::Runtime::HGTerrainUtils::Pow(4, v8, 0LL);
		      v10 = v9;
		      Unity::Collections::NativeArray<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::NativeArray(
		        &v15,
		        v9,
		        Allocator__Enum_TempJob,
		        NativeArrayOptions__Enum_ClearMemory,
		        MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::NativeArray);
		      for ( i = 0; ; i = 4 * i + 1 )
		      {
		        m_fixedLevelRenderData = (Dictionary_2_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_ *)this->fields.m_chunkNodes;
		        if ( !m_fixedLevelRenderData )
		          goto LABEL_15;
		        if ( i >= SLODWORD(m_fixedLevelRenderData->fields._entries) )
		          goto LABEL_12;
		        if ( *(_WORD *)(sub_180444A00(m_fixedLevelRenderData, i) + 26) == (_WORD)v8 )
		          break;
		      }
		      if ( (int)v10 > 0 )
		      {
		        m_Buffer = v15.m_Buffer;
		        for ( j = 0LL; j < v10; ++j )
		        {
		          v16 = (unsigned int)i++;
		          *(_QWORD *)&m_Buffer[8 * j] = v16;
		        }
		      }
		LABEL_12:
		      m_fixedLevelRenderData = this->fields.m_fixedLevelRenderData;
		      if ( m_fixedLevelRenderData )
		      {
		        System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::set_Item(
		          m_fixedLevelRenderData,
		          v8,
		          (NativeArray_1_System_ValueTuple_2_Int32_Single_ *)&v15,
		          MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::set_Item);
		        return;
		      }
		    }
		LABEL_15:
		    sub_1800D8260(m_fixedLevelRenderData, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3944, 0LL);
		  if ( !Patch )
		    goto LABEL_15;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, l, 0LL);
		}
		
		[IDTag(1)]
		public NativeList<ValueTuple<int, float>> TraverseAndCullQuadTreeFixedLevel(int l, Matrix4x4 cullingMatrix) => default; // 0x0000000189C18C38-0x0000000189C18ECC
		// NativeList`1[System.ValueTuple`2[Int32,Single]] TraverseAndCullQuadTreeFixedLevel(Int32, Matrix4x4)
		NativeList_1_System_ValueTuple_2_Int32_Single_ *HG::Rendering::Runtime::HGTerrainRenderer::TraverseAndCullQuadTreeFixedLevel(
		        NativeList_1_System_ValueTuple_2_Int32_Single_ *__return_ptr retstr,
		        HGTerrainRenderer *this,
		        int32_t l,
		        Matrix4x4 *cullingMatrix,
		        MethodInfo *method)
		{
		  HGTerrainRenderer_ChunkNode__Array *v9; // rcx
		  HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // rdx
		  int32_t size; // edx
		  NativeArray_1_System_Int32_ v12; // xmm0
		  NativeArray_1_System_Single_ extentYs_k__BackingField; // xmm1
		  NativeArray_1_System_Single_ extentZs_k__BackingField; // xmm0
		  NativeArray_1_System_Single_ centerZs_k__BackingField; // xmm1
		  NativeArray_1_System_Single_ extentXs_k__BackingField; // xmm0
		  NativeArray_1_System_Single_ centerXs_k__BackingField; // xmm1
		  NativeArray_1_System_Single_ centerYs_k__BackingField; // xmm0
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  int32_t v23; // r15d
		  __int64 v24; // r14
		  int i; // ebx
		  __int64 v26; // r15
		  NativeList_1_System_ValueTuple_2_Int32_Single_ v27; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  NativeList_1_System_ValueTuple_2_Int32_Single_ *result; // rax
		  NativeArray_1_System_Int32_ v33; // [rsp+50h] [rbp-B0h] BYREF
		  NativeList_1_BeyondDynamicBone_VirtualMesh_BaseLineWork_ v34; // [rsp+60h] [rbp-A0h] BYREF
		  NativeArray_1_System_Single_ v35; // [rsp+70h] [rbp-90h] BYREF
		  Matrix4x4 v36; // [rsp+80h] [rbp-80h] BYREF
		  NativeArray_1_System_Single_ v37; // [rsp+C0h] [rbp-40h] BYREF
		  NativeArray_1_System_Single_ v38; // [rsp+D0h] [rbp-30h] BYREF
		  NativeArray_1_System_Single_ v39; // [rsp+E0h] [rbp-20h] BYREF
		  NativeArray_1_System_Single_ v40; // [rsp+F0h] [rbp-10h] BYREF
		  NativeArray_1_System_Single_ v41; // [rsp+100h] [rbp+0h] BYREF
		
		  v34 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3951, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3951, 0LL);
		    if ( Patch )
		    {
		      v29 = *(_OWORD *)&cullingMatrix->m01;
		      *(_OWORD *)&v36.m00 = *(_OWORD *)&cullingMatrix->m00;
		      v30 = *(_OWORD *)&cullingMatrix->m02;
		      *(_OWORD *)&v36.m01 = v29;
		      v31 = *(_OWORD *)&cullingMatrix->m03;
		      *(_OWORD *)&v36.m02 = v30;
		      *(_OWORD *)&v36.m03 = v31;
		      v27 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1390(
		               (NativeList_1_System_ValueTuple_2_Int32_Single_ *)&v35,
		               Patch,
		               (Object *)this,
		               l,
		               &v36,
		               0LL);
		      goto LABEL_17;
		    }
		LABEL_15:
		    sub_1800D8260(v9, m_chunkNodes);
		  }
		  m_chunkNodes = this->fields.m_chunkNodes;
		  if ( !m_chunkNodes )
		    goto LABEL_15;
		  size = m_chunkNodes->max_length.size;
		  v33 = 0LL;
		  Unity::Collections::NativeArray<int>::NativeArray(
		    &v33,
		    size,
		    Allocator__Enum_Temp,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		  v12 = v33;
		  extentYs_k__BackingField = this->fields._extentYs_k__BackingField;
		  this->fields.m_visibility = v33;
		  v33 = v12;
		  extentZs_k__BackingField = this->fields._extentZs_k__BackingField;
		  v38 = extentYs_k__BackingField;
		  centerZs_k__BackingField = this->fields._centerZs_k__BackingField;
		  v37 = extentZs_k__BackingField;
		  extentXs_k__BackingField = this->fields._extentXs_k__BackingField;
		  v40 = centerZs_k__BackingField;
		  centerXs_k__BackingField = this->fields._centerXs_k__BackingField;
		  v39 = extentXs_k__BackingField;
		  centerYs_k__BackingField = this->fields._centerYs_k__BackingField;
		  v35 = centerXs_k__BackingField;
		  v19 = *(_OWORD *)&cullingMatrix->m01;
		  v41 = centerYs_k__BackingField;
		  v20 = *(_OWORD *)&cullingMatrix->m00;
		  *(_OWORD *)&v36.m01 = v19;
		  v21 = *(_OWORD *)&cullingMatrix->m03;
		  *(_OWORD *)&v36.m00 = v20;
		  v22 = *(_OWORD *)&cullingMatrix->m02;
		  *(_OWORD *)&v36.m03 = v21;
		  *(_OWORD *)&v36.m02 = v22;
		  UnityEngine::GeometryUtility::SPMDCullAABBNoFar(&v36, &v35, &v41, &v40, &v39, &v38, &v37, &v33, 0LL);
		  Unity::Collections::NativeList<BeyondDynamicBone::VirtualMesh::BaseLineWork>::NativeList(
		    &v34,
		    (AllocatorManager_AllocatorHandle)3,
		    MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::NativeList);
		  v23 = HG::Rendering::Runtime::HGTerrainRenderer::_ClampLevel(this, l, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
		  v24 = HG::Rendering::Runtime::HGTerrainUtils::Pow(4, v23, 0LL);
		  for ( i = 0; ; i = 4 * i + 1 )
		  {
		    v9 = this->fields.m_chunkNodes;
		    if ( !v9 )
		      goto LABEL_15;
		    if ( i >= v9->max_length.size )
		      goto LABEL_13;
		    if ( *(_WORD *)(sub_180444A00(v9, i) + 26) == (_WORD)v23 )
		      break;
		  }
		  if ( v24 > 0 )
		  {
		    v26 = 4LL * i;
		    do
		    {
		      if ( *(_DWORD *)&this->fields.m_visibility.m_Buffer[v26] )
		      {
		        v33.m_Buffer = (Void *)(unsigned int)i;
		        Unity::Collections::NativeList<BeyondDynamicBone::VirtualMesh::BaseLineWork>::Add(
		          &v34,
		          (VirtualMesh_BaseLineWork *)&v33,
		          MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::Add);
		      }
		      ++i;
		      v26 += 4LL;
		      --v24;
		    }
		    while ( v24 );
		  }
		LABEL_13:
		  Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		    (NativeArray_1_UnityEngine_Vector4_ *)&this->fields.m_visibility,
		    MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
		  v27 = (NativeList_1_System_ValueTuple_2_Int32_Single_)v34;
		LABEL_17:
		  result = retstr;
		  *retstr = v27;
		  return result;
		}
		
		public void TraverseAndCullQuadTree(Camera camera) {} // 0x0000000189C18ECC-0x0000000189C19238
		// Void TraverseAndCullQuadTree(Camera)
		void HG::Rendering::Runtime::HGTerrainRenderer::TraverseAndCullQuadTree(
		        HGTerrainRenderer *this,
		        Camera *camera,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Dictionary_2_System_Int32_Unity_Collections_NativeList_1_System_ValueTuple_2_Int32_Single_ *m_cameraRenderData; // rbx
		  int32_t InstanceID; // eax
		  int32_t pixelWidth; // ebx
		  float aspect; // xmm6_4
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // r8
		  __int64 v14; // r9
		  float v15; // xmm0_4
		  __int64 v16; // rcx
		  HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // rdx
		  int32_t size; // edx
		  int32_t v19; // edx
		  Matrix4x4 *cullingMatrix; // rax
		  NativeArray_1_System_Single_ extentZs_k__BackingField; // xmm1
		  NativeArray_1_System_Single_ extentYs_k__BackingField; // xmm0
		  NativeArray_1_System_Single_ extentXs_k__BackingField; // xmm1
		  NativeArray_1_System_Single_ centerZs_k__BackingField; // xmm0
		  NativeArray_1_System_Single_ centerYs_k__BackingField; // xmm1
		  NativeArray_1_System_Single_ centerXs_k__BackingField; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  Transform *transform; // rax
		  NativeList_1_BeyondDynamicBone_VirtualMesh_BaseLineWork_ v32; // xmm0
		  HGRuntimeGrassQuery_Node *v33; // rdx
		  HGRuntimeGrassQuery_Node *v34; // r8
		  Int32__Array **v35; // r9
		  Dictionary_2_System_Int32_Unity_Collections_NativeList_1_System_ValueTuple_2_Int32_Single_ *v36; // rbx
		  int32_t v37; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methoda; // [rsp+28h] [rbp-E0h]
		  _QWORD v40[3]; // [rsp+50h] [rbp-B8h] BYREF
		  Vector3 viewPoint; // [rsp+68h] [rbp-A0h] BYREF
		  HGTerrainRenderer_ChunkComparer v42; // [rsp+78h] [rbp-90h] BYREF
		  NativeList_1_BeyondDynamicBone_VirtualMesh_BaseLineWork_ v43; // [rsp+88h] [rbp-80h] BYREF
		  NativeList_1_BeyondDynamicBone_VirtualMesh_BaseLineWork_ v44; // [rsp+98h] [rbp-70h] BYREF
		  NativeArray_1_System_Single_ v45; // [rsp+A8h] [rbp-60h] BYREF
		  NativeArray_1_System_Single_ v46; // [rsp+B8h] [rbp-50h] BYREF
		  NativeArray_1_System_Single_ v47; // [rsp+C8h] [rbp-40h] BYREF
		  NativeArray_1_System_Single_ v48; // [rsp+D8h] [rbp-30h] BYREF
		  NativeArray_1_System_Single_ v49; // [rsp+E8h] [rbp-20h] BYREF
		  Matrix4x4 v50; // [rsp+F8h] [rbp-10h] BYREF
		  Matrix4x4 v51; // [rsp+138h] [rbp+30h] BYREF
		
		  *(_QWORD *)&viewPoint.x = 0LL;
		  viewPoint.z = 0.0;
		  v44 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3958, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3958, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)camera,
		        0LL);
		      return;
		    }
		LABEL_12:
		    sub_1800D8260(v6, v5);
		  }
		  m_cameraRenderData = this->fields.m_cameraRenderData;
		  if ( !camera )
		    goto LABEL_12;
		  InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)camera, 0LL);
		  if ( !m_cameraRenderData )
		    goto LABEL_12;
		  if ( !System::Collections::Generic::Dictionary<int,Beyond::UI::UIAtlasManager_UIAtlasPage::TextureRefHandle>::ContainsKey(
		          (Dictionary_2_System_Int32_Beyond_UI_UIAtlasManager_UIAtlasPage_TextureRefHandle_ *)m_cameraRenderData,
		          InstanceID,
		          MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::ContainsKey) )
		  {
		    pixelWidth = UnityEngine::Camera::get_pixelWidth(camera, 0LL);
		    UnityEngine::Camera::get_fieldOfView(camera, 0LL);
		    aspect = UnityEngine::Camera::get_aspect(camera, 0LL);
		    v15 = sub_180338A80(v12, v11, v13, v14);
		    HG::Rendering::Runtime::HGTerrainRenderer::_ComputeLodMax(this, pixelWidth, aspect * v15, 0LL);
		    m_chunkNodes = this->fields.m_chunkNodes;
		    if ( !m_chunkNodes )
		      goto LABEL_10;
		    size = m_chunkNodes->max_length.size;
		    *(_OWORD *)&v40[1] = 0LL;
		    Unity::Collections::NativeArray<BeyondDynamicBone::VertexAttribute>::NativeArray(
		      (NativeArray_1_BeyondDynamicBone_VertexAttribute_ *)&v40[1],
		      size,
		      Allocator__Enum_Temp,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<bool>::NativeArray);
		    m_chunkNodes = this->fields.m_chunkNodes;
		    this->fields.m_splits = *(NativeArray_1_System_Boolean_ *)&v40[1];
		    if ( !m_chunkNodes )
		      goto LABEL_10;
		    v19 = m_chunkNodes->max_length.size;
		    *(_OWORD *)&v40[1] = 0LL;
		    Unity::Collections::NativeArray<int>::NativeArray(
		      (NativeArray_1_System_Int32_ *)&v40[1],
		      v19,
		      Allocator__Enum_Temp,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		    this->fields.m_visibility = *(NativeArray_1_System_Int32_ *)&v40[1];
		    cullingMatrix = UnityEngine::Camera::get_cullingMatrix(&v51, camera, 0LL);
		    extentZs_k__BackingField = this->fields._extentZs_k__BackingField;
		    *(NativeArray_1_System_Int32_ *)&v40[1] = this->fields.m_visibility;
		    extentYs_k__BackingField = this->fields._extentYs_k__BackingField;
		    v45 = extentZs_k__BackingField;
		    extentXs_k__BackingField = this->fields._extentXs_k__BackingField;
		    v46 = extentYs_k__BackingField;
		    centerZs_k__BackingField = this->fields._centerZs_k__BackingField;
		    v47 = extentXs_k__BackingField;
		    centerYs_k__BackingField = this->fields._centerYs_k__BackingField;
		    v48 = centerZs_k__BackingField;
		    centerXs_k__BackingField = this->fields._centerXs_k__BackingField;
		    v49 = centerYs_k__BackingField;
		    v27 = *(_OWORD *)&cullingMatrix->m00;
		    v43 = (NativeList_1_BeyondDynamicBone_VirtualMesh_BaseLineWork_)centerXs_k__BackingField;
		    v28 = *(_OWORD *)&cullingMatrix->m01;
		    *(_OWORD *)&v50.m00 = v27;
		    v29 = *(_OWORD *)&cullingMatrix->m02;
		    *(_OWORD *)&v50.m01 = v28;
		    v30 = *(_OWORD *)&cullingMatrix->m03;
		    *(_OWORD *)&v50.m02 = v29;
		    *(_OWORD *)&v50.m03 = v30;
		    UnityEngine::GeometryUtility::SPMDCullAABBNoFar(
		      &v50,
		      (NativeArray_1_System_Single_ *)&v43,
		      &v49,
		      &v48,
		      &v47,
		      &v46,
		      &v45,
		      (NativeArray_1_System_Int32_ *)&v40[1],
		      0LL);
		    Unity::Collections::NativeList<BeyondDynamicBone::VirtualMesh::BaseLineWork>::NativeList(
		      &v44,
		      (AllocatorManager_AllocatorHandle)3,
		      MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::NativeList);
		    transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		    if ( !transform )
		      goto LABEL_10;
		    viewPoint = *UnityEngine::Transform::get_position((Vector3 *)&v40[1], transform, 0LL);
		    HG::Rendering::Runtime::HGTerrainRenderer::_UpdateGeometry(
		      this,
		      0,
		      &viewPoint,
		      (NativeList_1_System_ValueTuple_2_Int32_Single_ *)&v44,
		      0LL);
		    v32 = v44;
		    v42.m_chunkNodes = this->fields.m_chunkNodes;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v42, v33, v34, v35, methoda);
		    v43 = v32;
		    Unity::Collections::NativeSortExtension::Sort<System::ValueTuple<int,float>,HG::Rendering::Runtime::HGTerrainRenderer::ChunkComparer>(
		      (NativeList_1_System_ValueTuple_2_Int32_Single_ *)&v43,
		      v42,
		      MethodInfo::Unity::Collections::NativeSortExtension::Sort<System::ValueTuple<int,float>,HG::Rendering::Runtime::HGTerrainRenderer::ChunkComparer>);
		    v36 = this->fields.m_cameraRenderData;
		    v37 = UnityEngine::Object::GetInstanceID((Object_1 *)camera, 0LL);
		    if ( !v36 )
		LABEL_10:
		      sub_1800D8260(v16, m_chunkNodes);
		    v43 = v44;
		    System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::set_Item(
		      v36,
		      v37,
		      (NativeList_1_System_ValueTuple_2_Int32_Single_ *)&v43,
		      MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::set_Item);
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_ *)&this->fields.m_splits,
		      MethodInfo::Unity::Collections::NativeArray<bool>::Dispose);
		    Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		      (NativeArray_1_UnityEngine_Vector4_ *)&this->fields.m_visibility,
		      MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
		  }
		}
		
		public void GameUpdate(Camera camera) {} // 0x0000000189C15A74-0x0000000189C15D24
		// Void GameUpdate(Camera)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGTerrainRenderer::GameUpdate(HGTerrainRenderer *this, Camera *camera, MethodInfo *method)
		{
		  HGTerrainRenderer *v4; // rbx
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *m_cameraRenderData; // rcx
		  Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *m_fixedLevelRenderData; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  __int64 v14; // [rsp+0h] [rbp-E8h] BYREF
		  Il2CppException *ex; // [rsp+20h] [rbp-C8h]
		  void *v16; // [rsp+28h] [rbp-C0h]
		  NativeList_1_System_ValueTuple_2_Int32_Single_ value; // [rsp+30h] [rbp-B8h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_ v18; // [rsp+40h] [rbp-A8h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ v19; // [rsp+70h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v20; // [rsp+A0h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v21; // [rsp+A8h] [rbp-40h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32_Unity_Collections_NativeParallelHashMap_2_System_UInt32_Beyond_Gameplay_Core_DynamicScene_RuntimeAttachData_ v22; // [rsp+B0h] [rbp-38h] BYREF
		
		  v4 = this;
		  memset(&v18, 0, sizeof(v18));
		  if ( IFix::WrappersManagerImpl::IsPatched(3968, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3968, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)v4,
		      (Object *)camera,
		      0LL);
		  }
		  else
		  {
		    if ( !v4->fields.m_vtRenderer )
		      sub_1800D8260(v6, v5);
		    HG::Rendering::Runtime::VirtualTextureRenderer::GameUpdate(v4->fields.m_vtRenderer, camera, 0LL);
		    if ( !v4->fields.m_cameraRenderData )
		      sub_1800D8260(v8, v7);
		    System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::GetEnumerator(
		      &v19,
		      (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v4->fields.m_cameraRenderData,
		      MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::GetEnumerator);
		    v22 = (Dictionary_2_TKey_TValue_Enumerator_System_Int32_Unity_Collections_NativeParallelHashMap_2_System_UInt32_Beyond_Gameplay_Core_DynamicScene_RuntimeAttachData_)v19;
		    ex = 0LL;
		    v16 = &v22;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,Unity::Collections::NativeParallelHashMap<unsigned int,Beyond::Gameplay::Core::DynamicScene::RuntimeAttachData>>::MoveNext(
		                &v22,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::MoveNext) )
		      {
		        value = (NativeList_1_System_ValueTuple_2_Int32_Single_)v22._current.value;
		        Unity::Collections::NativeList<System::ValueTuple<int,float>>::Dispose(
		          &value,
		          MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::Dispose);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v20 )
		    {
		      ex = v20->ex;
		      m_cameraRenderData = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v4 = this;
		    }
		    m_fixedLevelRenderData = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v4->fields.m_fixedLevelRenderData;
		    if ( !m_fixedLevelRenderData )
		      goto LABEL_24;
		    System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::GetEnumerator(
		      &v19,
		      m_fixedLevelRenderData,
		      MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::GetEnumerator);
		    v18 = (Dictionary_2_TKey_TValue_Enumerator_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_)v19;
		    ex = 0LL;
		    v16 = &v18;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::MoveNext(
		                &v18,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::MoveNext) )
		      {
		        value = (NativeList_1_System_ValueTuple_2_Int32_Single_)v18._current.value;
		        Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
		          (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&value,
		          MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::Dispose);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v21 )
		    {
		      m_fixedLevelRenderData = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)&v14;
		      ex = v21->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v4 = this;
		    }
		    m_cameraRenderData = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v4->fields.m_cameraRenderData;
		    if ( !m_cameraRenderData
		      || (System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
		            m_cameraRenderData,
		            MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::Clear),
		          (m_cameraRenderData = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v4->fields.m_fixedLevelRenderData) == 0LL) )
		    {
		LABEL_24:
		      sub_1800D8250(m_cameraRenderData, m_fixedLevelRenderData);
		    }
		    System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
		      m_cameraRenderData,
		      MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::Clear);
		  }
		}
		
		public void BakeVirtualPages(ScriptableRenderContext context) {} // 0x0000000189C156A8-0x0000000189C15714
		// Void BakeVirtualPages(ScriptableRenderContext)
		void HG::Rendering::Runtime::HGTerrainRenderer::BakeVirtualPages(
		        HGTerrainRenderer *this,
		        ScriptableRenderContext context,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  VirtualTextureRenderer *m_vtRenderer; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3989, 0LL) )
		  {
		    m_vtRenderer = this->fields.m_vtRenderer;
		    if ( m_vtRenderer )
		    {
		      HG::Rendering::Runtime::VirtualTextureRenderer::Render(m_vtRenderer, context, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_vtRenderer, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3989, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_204(Patch, (Object *)this, context, 0LL);
		}
		
		public void PipelineUpdate(PerObjectData renderConfiguration, Vector2 vtCenter) {} // 0x0000000189C15E9C-0x0000000189C1684C
		// Void PipelineUpdate(PerObjectData, Vector2)
		void HG::Rendering::Runtime::HGTerrainRenderer::PipelineUpdate(
		        HGTerrainRenderer *this,
		        PerObjectData__Enum renderConfiguration,
		        Vector2 vtCenter,
		        MethodInfo *method)
		{
		  __int64 v6; // rdx
		  void *m_vtRenderer; // rcx
		  ComputeBuffer *v8; // rax
		  ComputeBuffer *v9; // rbx
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  Material *m_terrainLitMaterial; // rbx
		  ComputeBuffer *m_perTerrainDataBuffer; // r12
		  int32_t HGTerrainPerTerrain; // r15d
		  int32_t count; // eax
		  int32_t v17; // r14d
		  int32_t stride; // eax
		  Material *v19; // rbx
		  int32_t HGTerrainReflectionProbeTex; // r14d
		  Texture *ReflectionProbeArrayInternal; // rax
		  HGTerrainRuntimeResources *m_runtimeResources; // rax
		  HGTerrainRuntimeResources_TextureResources *textures; // rbx
		  Object_1 *lightmapColorTex; // rbx
		  char v25; // r14
		  VirtualTextureRenderer *v26; // rax
		  float y; // xmm0_4
		  float x; // xmm1_4
		  Void *m_Buffer; // rbx
		  SphericalHarmonicsL2 *defaultProbeSH; // rax
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  __int128 v33; // xmm1
		  __int128 v34; // xmm0
		  __int128 v35; // xmm1
		  SHCoefficientsL1 *CoefficientsL1; // rax
		  Vector4 shAg; // xmm4
		  Vector4 shAb; // xmm3
		  Material *v39; // rsi
		  SphericalHarmonicsL2 *ambientProbe; // rax
		  __int128 v41; // xmm1
		  __int128 v42; // xmm0
		  __int128 v43; // xmm1
		  __int128 v44; // xmm0
		  __int128 v45; // xmm1
		  float Item; // xmm9_4
		  float v47; // xmm8_4
		  float v48; // xmm6_4
		  float v49; // xmm9_4
		  float v50; // xmm8_4
		  float v51; // xmm6_4
		  float v52; // xmm9_4
		  float v53; // xmm8_4
		  float v54; // xmm6_4
		  float v55; // xmm6_4
		  float v56; // xmm6_4
		  float v57; // xmm6_4
		  HGTerrainRuntimeResources *v58; // rax
		  HGTerrainRuntimeResources_TextureResources *v59; // rax
		  HGTerrainRuntimeResources *v60; // rbx
		  HGTerrainRuntimeResources_TextureResources *v61; // rbx
		  Object_1 *lightmapDirTex; // rbx
		  Material *v63; // rbx
		  HGTerrainRuntimeResources *v64; // rax
		  HGTerrainRuntimeResources_TextureResources *v65; // rax
		  int32_t v66; // eax
		  ComputeBuffer *m_perTerrainFrameDataBuffer; // rcx
		  ComputeBuffer *v68; // rax
		  ComputeBuffer *v69; // rbx
		  HGRuntimeGrassQuery_Node *v70; // rdx
		  HGRuntimeGrassQuery_Node *v71; // r8
		  Int32__Array **v72; // r9
		  Material *v73; // rbx
		  ComputeBuffer *v74; // r15
		  int32_t HGTerrainPerTerrainFrame; // r14d
		  int32_t v76; // eax
		  int32_t v77; // esi
		  int32_t v78; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *size; // [rsp+28h] [rbp-E0h]
		  MethodInfo *sizea; // [rsp+28h] [rbp-E0h]
		  NativeArray_1_UnityEngine_Vector4_ v82; // [rsp+38h] [rbp-D0h] BYREF
		  SphericalHarmonicsL2 v83; // [rsp+48h] [rbp-C0h] BYREF
		  Vector2 vtCentera; // [rsp+B8h] [rbp-50h] BYREF
		  NativeArray_1_UnityEngine_Vector4_ v85; // [rsp+C8h] [rbp-40h] BYREF
		  SHCoefficientsL1 v86; // [rsp+108h] [rbp+0h] BYREF
		  SphericalHarmonicsL2 v87; // [rsp+138h] [rbp+30h] BYREF
		
		  vtCentera = vtCenter;
		  v85 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3994, 0LL) )
		  {
		    m_vtRenderer = this->fields.m_vtRenderer;
		    if ( m_vtRenderer )
		    {
		      HG::Rendering::Runtime::VirtualTextureRenderer::PipelineUpdate(
		        (VirtualTextureRenderer *)m_vtRenderer,
		        &vtCentera,
		        0LL);
		      m_vtRenderer = this->fields.m_vtRenderer;
		      if ( m_vtRenderer )
		      {
		        HG::Rendering::Runtime::VirtualTextureRenderer::SetupVTTexturesForMaterial(
		          (VirtualTextureRenderer *)m_vtRenderer,
		          this->fields.m_terrainLitMaterial,
		          0LL);
		        if ( !this->fields.m_perTerrainDataBuffer )
		        {
		          v8 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		          v9 = v8;
		          if ( !v8 )
		            goto LABEL_46;
		          UnityEngine::ComputeBuffer::ComputeBuffer(
		            v8,
		            6,
		            16,
		            ComputeBufferType__Enum_Constant,
		            ComputeBufferMode__Enum_Immutable,
		            0LL);
		          this->fields.m_perTerrainDataBuffer = v9;
		          sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_perTerrainDataBuffer, v10, v11, v12, size);
		        }
		        m_vtRenderer = this->fields.m_vtRenderer;
		        if ( m_vtRenderer )
		        {
		          HG::Rendering::Runtime::VirtualTextureRenderer::SetupVTDataBufferForMaterial(
		            (VirtualTextureRenderer *)m_vtRenderer,
		            this->fields.m_perTerrainDataBuffer,
		            0LL);
		          m_terrainLitMaterial = this->fields.m_terrainLitMaterial;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		          m_perTerrainDataBuffer = this->fields.m_perTerrainDataBuffer;
		          HGTerrainPerTerrain = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainPerTerrain;
		          m_vtRenderer = m_perTerrainDataBuffer;
		          if ( m_perTerrainDataBuffer )
		          {
		            count = UnityEngine::ComputeBuffer::get_count(m_perTerrainDataBuffer, 0LL);
		            m_vtRenderer = this->fields.m_perTerrainDataBuffer;
		            v17 = count;
		            if ( m_vtRenderer )
		            {
		              stride = UnityEngine::ComputeBuffer::get_stride((ComputeBuffer *)m_vtRenderer, 0LL);
		              if ( m_terrainLitMaterial )
		              {
		                UnityEngine::Material::SetConstantBufferImpl(
		                  m_terrainLitMaterial,
		                  HGTerrainPerTerrain,
		                  m_perTerrainDataBuffer,
		                  0,
		                  v17 * stride,
		                  0LL);
		                v19 = this->fields.m_terrainLitMaterial;
		                HGTerrainReflectionProbeTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainReflectionProbeTex;
		                ReflectionProbeArrayInternal = UnityEngine::Renderer::GetReflectionProbeArrayInternal(0LL);
		                if ( v19 )
		                {
		                  UnityEngine::Material::SetTextureImpl(
		                    v19,
		                    HGTerrainReflectionProbeTex,
		                    ReflectionProbeArrayInternal,
		                    0LL);
		                  if ( (renderConfiguration & 8) == 0 )
		                    goto LABEL_17;
		                  m_runtimeResources = this->fields.m_runtimeResources;
		                  if ( !m_runtimeResources )
		                    goto LABEL_46;
		                  textures = m_runtimeResources->fields.textures;
		                  if ( !textures )
		                    goto LABEL_46;
		                  lightmapColorTex = (Object_1 *)textures->fields.lightmapColorTex;
		                  sub_1800036A0(TypeInfo::UnityEngine::Object);
		                  if ( UnityEngine::Object::op_Inequality(lightmapColorTex, 0LL, 0LL) )
		                    v25 = 1;
		                  else
		LABEL_17:
		                    v25 = 0;
		                  Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray(
		                    &v85,
		                    v25 != 0 ? 5 : 12,
		                    Allocator__Enum_Temp,
		                    NativeArrayOptions__Enum_ClearMemory,
		                    MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
		                  v26 = this->fields.m_vtRenderer;
		                  if ( !v26 )
		                    goto LABEL_46;
		                  y = v26->fields._currentCenterPos_k__BackingField.y;
		                  x = v26->fields._currentCenterPos_k__BackingField.x;
		                  v82.m_Length = 0;
		                  v82.m_AllocatorLabel = 0;
		                  m_Buffer = v85.m_Buffer;
		                  *(float *)&v82.m_Buffer = x;
		                  *((float *)&v82.m_Buffer + 1) = y;
		                  *(_OWORD *)v85.m_Buffer = (unsigned __int64)v82.m_Buffer;
		                  *(__m128i *)&m_Buffer[16] = _mm_loadu_si128((const __m128i *)UnityEngine::ReflectionProbe::get_defaultTextureHDRDecodeValues(
		                                                                                 (Vector4 *)&v82,
		                                                                                 0LL));
		                  defaultProbeSH = UnityEngine::ReflectionProbe::get_defaultProbeSH(&v87, 0LL);
		                  v31 = *(_OWORD *)&defaultProbeSH->shr4;
		                  *(_OWORD *)&v83.shr0 = *(_OWORD *)&defaultProbeSH->shr0;
		                  v32 = *(_OWORD *)&defaultProbeSH->shr8;
		                  *(_OWORD *)&v83.shr4 = v31;
		                  v33 = *(_OWORD *)&defaultProbeSH->shg3;
		                  *(_OWORD *)&v83.shr8 = v32;
		                  v34 = *(_OWORD *)&defaultProbeSH->shg7;
		                  *(_OWORD *)&v83.shg3 = v33;
		                  v35 = *(_OWORD *)&defaultProbeSH->shb2;
		                  *(_OWORD *)&v83.shg7 = v34;
		                  *(_QWORD *)&v34 = *(_QWORD *)&defaultProbeSH->shb6;
		                  *(float *)&defaultProbeSH = defaultProbeSH->shb8;
		                  *(_QWORD *)&v83.shb6 = v34;
		                  LODWORD(v83.shb8) = (_DWORD)defaultProbeSH;
		                  *(_OWORD *)&v83.shb2 = v35;
		                  CoefficientsL1 = HG::Rendering::Runtime::HGEnvironmentUtils::GetCoefficientsL1(&v86, &v83, 0LL);
		                  shAg = CoefficientsL1->shAg;
		                  shAb = CoefficientsL1->shAb;
		                  *(Vector4 *)&m_Buffer[32] = CoefficientsL1->shAr;
		                  *(Vector4 *)&m_Buffer[48] = shAg;
		                  *(Vector4 *)&m_Buffer[64] = shAb;
		                  v39 = this->fields.m_terrainLitMaterial;
		                  if ( v25 )
		                  {
		                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                    m_vtRenderer = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                    v58 = this->fields.m_runtimeResources;
		                    if ( !v58 )
		                      goto LABEL_46;
		                    v59 = v58->fields.textures;
		                    if ( !v59 )
		                      goto LABEL_46;
		                    if ( !v39 )
		                      goto LABEL_46;
		                    UnityEngine::Material::SetTextureImpl(
		                      v39,
		                      *((_DWORD *)m_vtRenderer + 168),
		                      (Texture *)v59->fields.lightmapColorTex,
		                      0LL);
		                    v60 = this->fields.m_runtimeResources;
		                    if ( !v60 )
		                      goto LABEL_46;
		                    v61 = v60->fields.textures;
		                    if ( !v61 )
		                      goto LABEL_46;
		                    lightmapDirTex = (Object_1 *)v61->fields.lightmapDirTex;
		                    sub_1800036A0(TypeInfo::UnityEngine::Object);
		                    if ( UnityEngine::Object::op_Implicit(lightmapDirTex, 0LL) )
		                    {
		                      v63 = this->fields.m_terrainLitMaterial;
		                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                      m_vtRenderer = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		                      v64 = this->fields.m_runtimeResources;
		                      if ( !v64 )
		                        goto LABEL_46;
		                      v65 = v64->fields.textures;
		                      if ( !v65 || !v63 )
		                        goto LABEL_46;
		                      UnityEngine::Material::SetTextureImpl(
		                        v63,
		                        *((_DWORD *)m_vtRenderer + 169),
		                        (Texture *)v65->fields.lightmapDirTex,
		                        0LL);
		                    }
		                    m_vtRenderer = this->fields.m_terrainLitMaterial;
		                    if ( !m_vtRenderer )
		                      goto LABEL_46;
		                    UnityEngine::Material::EnableKeyword(
		                      (Material *)m_vtRenderer,
		                      &this->fields.m_terrainLitMatLightmapOn,
		                      0LL);
		                  }
		                  else
		                  {
		                    if ( !v39 )
		                      goto LABEL_46;
		                    UnityEngine::Material::DisableKeyword(
		                      this->fields.m_terrainLitMaterial,
		                      &this->fields.m_terrainLitMatLightmapOn,
		                      0LL);
		                    ambientProbe = UnityEngine::RenderSettings::get_ambientProbe(&v87, 0LL);
		                    v41 = *(_OWORD *)&ambientProbe->shr4;
		                    *(_OWORD *)&v83.shr0 = *(_OWORD *)&ambientProbe->shr0;
		                    v42 = *(_OWORD *)&ambientProbe->shr8;
		                    *(_OWORD *)&v83.shr4 = v41;
		                    v43 = *(_OWORD *)&ambientProbe->shg3;
		                    *(_OWORD *)&v83.shr8 = v42;
		                    v44 = *(_OWORD *)&ambientProbe->shg7;
		                    *(_OWORD *)&v83.shg3 = v43;
		                    v45 = *(_OWORD *)&ambientProbe->shb2;
		                    *(_OWORD *)&v83.shg7 = v44;
		                    *(_QWORD *)&v44 = *(_QWORD *)&ambientProbe->shb6;
		                    *(float *)&ambientProbe = ambientProbe->shb8;
		                    *(_QWORD *)&v83.shb6 = v44;
		                    LODWORD(v83.shb8) = (_DWORD)ambientProbe;
		                    *(_OWORD *)&v83.shb2 = v45;
		                    Item = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 0, 3, 0LL);
		                    v47 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 0, 1, 0LL);
		                    v48 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 0, 2, 0LL);
		                    *(float *)&v44 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 0, 0, 0LL);
		                    *(float *)&v82.m_Buffer = Item;
		                    *((float *)&v82.m_Buffer + 1) = v47;
		                    *(float *)&v82.m_Length = v48;
		                    *(float *)&v82.m_AllocatorLabel = *(float *)&v44
		                                                    - UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(
		                                                        &v83,
		                                                        0,
		                                                        6,
		                                                        0LL);
		                    *(NativeArray_1_UnityEngine_Vector4_ *)&m_Buffer[80] = v82;
		                    v49 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 1, 3, 0LL);
		                    v50 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 1, 1, 0LL);
		                    v51 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 1, 2, 0LL);
		                    *(float *)&v44 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 1, 0, 0LL);
		                    *(float *)&v82.m_Buffer = v49;
		                    *((float *)&v82.m_Buffer + 1) = v50;
		                    *(float *)&v82.m_Length = v51;
		                    *(float *)&v82.m_AllocatorLabel = *(float *)&v44
		                                                    - UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(
		                                                        &v83,
		                                                        1,
		                                                        6,
		                                                        0LL);
		                    *(NativeArray_1_UnityEngine_Vector4_ *)&m_Buffer[96] = v82;
		                    v52 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 2, 3, 0LL);
		                    v53 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 2, 1, 0LL);
		                    v54 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 2, 2, 0LL);
		                    *(float *)&v44 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 2, 0, 0LL);
		                    *(float *)&v82.m_Buffer = v52;
		                    *((float *)&v82.m_Buffer + 1) = v53;
		                    *(float *)&v82.m_Length = v54;
		                    *(float *)&v82.m_AllocatorLabel = *(float *)&v44
		                                                    - UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(
		                                                        &v83,
		                                                        2,
		                                                        6,
		                                                        0LL);
		                    *(NativeArray_1_UnityEngine_Vector4_ *)&m_Buffer[112] = v82;
		                    v55 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 0, 4, 0LL);
		                    *(float *)&v44 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 0, 5, 0LL);
		                    *(float *)&v82.m_Buffer = v55;
		                    HIDWORD(v82.m_Buffer) = v44;
		                    *(float *)&v82.m_Length = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 0, 6, 0LL)
		                                            * 3.0;
		                    v82.m_AllocatorLabel = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 0, 7, 0LL);
		                    *(NativeArray_1_UnityEngine_Vector4_ *)&m_Buffer[128] = v82;
		                    v56 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 1, 4, 0LL);
		                    *(float *)&v44 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 1, 5, 0LL);
		                    *(float *)&v82.m_Buffer = v56;
		                    HIDWORD(v82.m_Buffer) = v44;
		                    *(float *)&v82.m_Length = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 1, 6, 0LL)
		                                            * 3.0;
		                    v82.m_AllocatorLabel = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 1, 7, 0LL);
		                    *(NativeArray_1_UnityEngine_Vector4_ *)&m_Buffer[144] = v82;
		                    v57 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 2, 4, 0LL);
		                    *(float *)&v44 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 2, 5, 0LL);
		                    *(float *)&v82.m_Buffer = v57;
		                    HIDWORD(v82.m_Buffer) = v44;
		                    *(float *)&v82.m_Length = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 2, 6, 0LL)
		                                            * 3.0;
		                    v82.m_AllocatorLabel = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 2, 7, 0LL);
		                    *(NativeArray_1_UnityEngine_Vector4_ *)&m_Buffer[160] = v82;
		                    LODWORD(v82.m_Buffer) = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 0, 8, 0LL);
		                    HIDWORD(v82.m_Buffer) = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 1, 8, 0LL);
		                    v82.m_Length = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v83, 2, 8, 0LL);
		                    v82.m_AllocatorLabel = 1065353216;
		                    *(NativeArray_1_UnityEngine_Vector4_ *)&m_Buffer[176] = v82;
		                  }
		                  if ( !this->fields.m_perTerrainFrameDataBuffer
		                    || (v66 = UnityEngine::ComputeBuffer::get_count(this->fields.m_perTerrainFrameDataBuffer, 0LL),
		                        v66 != v85.m_Length) )
		                  {
		                    m_perTerrainFrameDataBuffer = this->fields.m_perTerrainFrameDataBuffer;
		                    if ( m_perTerrainFrameDataBuffer )
		                      UnityEngine::ComputeBuffer::Dispose(m_perTerrainFrameDataBuffer, 0LL);
		                    v68 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		                    v69 = v68;
		                    if ( !v68 )
		                      goto LABEL_46;
		                    UnityEngine::ComputeBuffer::ComputeBuffer(
		                      v68,
		                      v85.m_Length,
		                      16,
		                      ComputeBufferType__Enum_Constant,
		                      ComputeBufferMode__Enum_Immutable,
		                      0LL);
		                    this->fields.m_perTerrainFrameDataBuffer = v69;
		                    sub_18002D1B0(
		                      (HGRuntimeGrassQuery_Node *)&this->fields.m_perTerrainFrameDataBuffer,
		                      v70,
		                      v71,
		                      v72,
		                      sizea);
		                    v73 = this->fields.m_terrainLitMaterial;
		                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		                    v74 = this->fields.m_perTerrainFrameDataBuffer;
		                    HGTerrainPerTerrainFrame = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainPerTerrainFrame;
		                    m_vtRenderer = v74;
		                    if ( !v74 )
		                      goto LABEL_46;
		                    v76 = UnityEngine::ComputeBuffer::get_count(v74, 0LL);
		                    m_vtRenderer = this->fields.m_perTerrainFrameDataBuffer;
		                    v77 = v76;
		                    if ( !m_vtRenderer )
		                      goto LABEL_46;
		                    v78 = UnityEngine::ComputeBuffer::get_stride((ComputeBuffer *)m_vtRenderer, 0LL);
		                    if ( !v73 )
		                      goto LABEL_46;
		                    UnityEngine::Material::SetConstantBufferImpl(v73, HGTerrainPerTerrainFrame, v74, 0, v77 * v78, 0LL);
		                  }
		                  m_vtRenderer = this->fields.m_perTerrainFrameDataBuffer;
		                  if ( m_vtRenderer )
		                  {
		                    v82 = v85;
		                    sub_1808B0C90(m_vtRenderer, &v82);
		                    return;
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_46:
		    sub_1800D8260(m_vtRenderer, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3994, 0LL);
		  if ( !Patch )
		    goto LABEL_46;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1408(Patch, (Object *)this, renderConfiguration, vtCentera, 0LL);
		}
		
		public void SetTerrainBlendParamsGlobal(CommandBuffer cmd) {} // 0x0000000189C187A0-0x0000000189C18A70
		// Void SetTerrainBlendParamsGlobal(CommandBuffer)
		void HG::Rendering::Runtime::HGTerrainRenderer::SetTerrainBlendParamsGlobal(
		        HGTerrainRenderer *this,
		        CommandBuffer *cmd,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  VirtualTextureRenderer *m_vtRenderer; // rcx
		  ComputeBuffer *m_perTerrainDataBuffer; // rsi
		  int32_t HGTerrainPerTerrain; // ebp
		  int32_t count; // eax
		  int32_t v10; // r14d
		  int32_t stride; // eax
		  ComputeBuffer *m_perTerrainFrameDataBuffer; // rsi
		  int32_t HGTerrainPerTerrainFrame; // ebp
		  int32_t v14; // eax
		  int32_t v15; // r14d
		  int32_t v16; // eax
		  HGTerrainRuntimeResources *m_runtimeResources; // rax
		  int32_t m_Index; // esi
		  HGTerrainRuntimeResources_TextureResources *textures; // rax
		  Texture *lightmapColorTex; // rax
		  RenderTargetIdentifier *v21; // rax
		  __int64 v22; // rdx
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  __int128 v24; // xmm1
		  HGTerrainRuntimeResources *v25; // rax
		  int32_t HGTerrainLightmapInd; // esi
		  HGTerrainRuntimeResources_TextureResources *v27; // rax
		  Texture *lightmapDirTex; // rax
		  RenderTargetIdentifier *v29; // rax
		  __int128 v30; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RenderTargetIdentifier v32; // [rsp+30h] [rbp-68h] BYREF
		  RenderTargetIdentifier v33; // [rsp+60h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4008, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4008, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)cmd,
		        0LL);
		      return;
		    }
		    goto LABEL_25;
		  }
		  m_vtRenderer = this->fields.m_vtRenderer;
		  if ( !m_vtRenderer )
		    goto LABEL_25;
		  HG::Rendering::Runtime::VirtualTextureRenderer::SetVTTexturesGlobal(m_vtRenderer, cmd, 0LL);
		  if ( this->fields.m_perTerrainDataBuffer )
		  {
		    m_perTerrainDataBuffer = this->fields.m_perTerrainDataBuffer;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    HGTerrainPerTerrain = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainPerTerrain;
		    m_vtRenderer = (VirtualTextureRenderer *)this->fields.m_perTerrainDataBuffer;
		    if ( !m_vtRenderer )
		      goto LABEL_25;
		    count = UnityEngine::ComputeBuffer::get_count((ComputeBuffer *)m_vtRenderer, 0LL);
		    m_vtRenderer = (VirtualTextureRenderer *)this->fields.m_perTerrainDataBuffer;
		    v10 = count;
		    if ( !m_vtRenderer )
		      goto LABEL_25;
		    stride = UnityEngine::ComputeBuffer::get_stride((ComputeBuffer *)m_vtRenderer, 0LL);
		    if ( !cmd )
		      goto LABEL_25;
		    UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal(
		      cmd,
		      m_perTerrainDataBuffer,
		      HGTerrainPerTerrain,
		      0,
		      v10 * stride,
		      0LL);
		  }
		  if ( this->fields.m_perTerrainFrameDataBuffer )
		  {
		    m_perTerrainFrameDataBuffer = this->fields.m_perTerrainFrameDataBuffer;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    HGTerrainPerTerrainFrame = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainPerTerrainFrame;
		    m_vtRenderer = (VirtualTextureRenderer *)this->fields.m_perTerrainFrameDataBuffer;
		    if ( m_vtRenderer )
		    {
		      v14 = UnityEngine::ComputeBuffer::get_count((ComputeBuffer *)m_vtRenderer, 0LL);
		      m_vtRenderer = (VirtualTextureRenderer *)this->fields.m_perTerrainFrameDataBuffer;
		      v15 = v14;
		      if ( m_vtRenderer )
		      {
		        v16 = UnityEngine::ComputeBuffer::get_stride((ComputeBuffer *)m_vtRenderer, 0LL);
		        if ( cmd )
		        {
		          UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal(
		            cmd,
		            m_perTerrainFrameDataBuffer,
		            HGTerrainPerTerrainFrame,
		            0,
		            v15 * v16,
		            0LL);
		          goto LABEL_13;
		        }
		      }
		    }
		LABEL_25:
		    sub_1800D8260(m_vtRenderer, v5);
		  }
		LABEL_13:
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  m_vtRenderer = (VirtualTextureRenderer *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  m_runtimeResources = this->fields.m_runtimeResources;
		  m_Index = m_vtRenderer->fields.m_enableCompressKeywordCS.m_Index;
		  if ( !m_runtimeResources )
		    goto LABEL_25;
		  textures = m_runtimeResources->fields.textures;
		  if ( !textures )
		    goto LABEL_25;
		  lightmapColorTex = (Texture *)textures->fields.lightmapColorTex;
		  if ( !lightmapColorTex )
		    lightmapColorTex = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		  v21 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v33, lightmapColorTex, 0LL);
		  if ( !cmd )
		    goto LABEL_23;
		  v24 = *(_OWORD *)&v21->m_BufferPointer;
		  *(_OWORD *)&v32.m_Type = *(_OWORD *)&v21->m_Type;
		  *(_QWORD *)&v32.m_DepthSlice = *(_QWORD *)&v21->m_DepthSlice;
		  *(_OWORD *)&v32.m_BufferPointer = v24;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, m_Index, &v32, 0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		  v25 = this->fields.m_runtimeResources;
		  HGTerrainLightmapInd = static_fields->_HGTerrainLightmapInd;
		  if ( !v25 || (v27 = v25->fields.textures) == 0LL )
		LABEL_23:
		    sub_1800D8260(static_fields, v22);
		  lightmapDirTex = (Texture *)v27->fields.lightmapDirTex;
		  if ( !lightmapDirTex )
		    lightmapDirTex = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		  v29 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v33, lightmapDirTex, 0LL);
		  v30 = *(_OWORD *)&v29->m_BufferPointer;
		  *(_OWORD *)&v32.m_Type = *(_OWORD *)&v29->m_Type;
		  *(_QWORD *)&v32.m_DepthSlice = *(_QWORD *)&v29->m_DepthSlice;
		  *(_OWORD *)&v32.m_BufferPointer = v30;
		  UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, HGTerrainLightmapInd, &v32, 0LL);
		}
		
		private ushort _ClampLevel(int level) => default; // 0x0000000189C19238-0x0000000189C192A8
		// UInt16 _ClampLevel(Int32)
		uint16_t HG::Rendering::Runtime::HGTerrainRenderer::_ClampLevel(
		        HGTerrainRenderer *this,
		        int32_t level,
		        MethodInfo *method)
		{
		  int m_treeDepth; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3945, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3945, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(
		             (ILFixDynamicMethodWrapper_6 *)Patch,
		             (Object *)this,
		             (NaviDirection__Enum)level,
		             0LL);
		  }
		  else
		  {
		    m_treeDepth = this->fields.m_treeDepth;
		    sub_1800036A0(TypeInfo::System::Math);
		    if ( m_treeDepth - 1 <= level )
		      LOWORD(level) = m_treeDepth - 1;
		    return level;
		  }
		}
		
		private void _UpdateGeometry(int currIndex, [IsReadOnly] in Vector3 viewPoint, ref NativeList<ValueTuple<int, float>> nodeList) {} // 0x0000000189C1966C-0x0000000189C19858
		// Void _UpdateGeometry(Int32, Vector3 ByRef, NativeList`1[System.ValueTuple`2[Int32,Single]] ByRef)
		void HG::Rendering::Runtime::HGTerrainRenderer::_UpdateGeometry(
		        HGTerrainRenderer *this,
		        int32_t currIndex,
		        Vector3 *viewPoint,
		        NativeList_1_System_ValueTuple_2_Int32_Single_ *nodeList,
		        MethodInfo *method)
		{
		  __int64 v5; // rdi
		  __int64 v9; // rdx
		  HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // rcx
		  HGTerrainRenderer_ChunkNode *v11; // rsi
		  float v12; // xmm0_4
		  uint16_t v13; // r12
		  MethodInfo *v14; // r9
		  Void *m_Buffer; // rcx
		  Void *v16; // rax
		  __m128 v17; // xmm2
		  Void *v18; // rcx
		  float v19; // xmm1_4
		  Vector3 *v20; // rax
		  __int64 v21; // xmm3_8
		  int v22; // edi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 value; // [rsp+30h] [rbp-30h] BYREF
		  Vector3 v25; // [rsp+40h] [rbp-20h] BYREF
		  Vector3 v26; // [rsp+50h] [rbp-10h] BYREF
		
		  v5 = currIndex;
		  if ( IFix::WrappersManagerImpl::IsPatched(3960, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3960, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1398(Patch, (Object *)this, v5, viewPoint, nodeList, 0LL);
		      return;
		    }
		LABEL_15:
		    sub_1800D8260(m_chunkNodes, v9);
		  }
		  if ( !*(_DWORD *)&this->fields.m_visibility.m_Buffer[4 * v5] )
		    return;
		  m_chunkNodes = this->fields.m_chunkNodes;
		  if ( !m_chunkNodes )
		    goto LABEL_15;
		  v11 = (HGTerrainRenderer_ChunkNode *)sub_180444A00(m_chunkNodes, v5);
		  v12 = HG::Rendering::Runtime::HGTerrainRenderer::_DistFromAABBToPoint(this, viewPoint, v5, 0LL);
		  v13 = HG::Rendering::Runtime::HGTerrainRenderer::_ComputeChunkedLod(this, v12, 0LL);
		  if ( HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::CheckSplit(v11, v13, 0LL) )
		  {
		    HG::Rendering::Runtime::HGTerrainRenderer::_SplitGeometry(this, v5, viewPoint, 0LL);
		    v22 = 0;
		    while ( 1 )
		    {
		      m_chunkNodes = (HGTerrainRenderer_ChunkNode__Array *)v11->children;
		      if ( !m_chunkNodes )
		        break;
		      if ( (unsigned int)v22 >= m_chunkNodes->max_length.size )
		        sub_1800D2AB0(m_chunkNodes, v9);
		      HG::Rendering::Runtime::HGTerrainRenderer::_UpdateGeometry(
		        this,
		        *((__int16 *)&m_chunkNodes->vector[0].transform.x + v22++),
		        viewPoint,
		        nodeList,
		        0LL);
		      if ( v22 >= 4 )
		        return;
		    }
		    goto LABEL_15;
		  }
		  if ( (v11->lodData & 0xFF00) == 0 )
		    HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::ClampAndSaveMorph(v11, v13, 0LL);
		  m_Buffer = this->fields._centerYs_k__BackingField.m_Buffer;
		  v16 = this->fields._centerXs_k__BackingField.m_Buffer;
		  *(_QWORD *)&value.x = *(_QWORD *)&viewPoint->x;
		  v17 = (__m128)*(unsigned int *)&m_Buffer[4 * v5];
		  v18 = this->fields._centerZs_k__BackingField.m_Buffer;
		  *(_QWORD *)&v25.x = _mm_unpacklo_ps((__m128)*(_DWORD *)&v16[4 * v5], v17).m128_u64[0];
		  v19 = *(float *)&v18[4 * v5];
		  value.z = viewPoint->z;
		  v25.z = v19;
		  v20 = UnityEngine::Vector3::op_Subtraction(&v26, &v25, &value, v14);
		  v21 = *(_QWORD *)&v20->x;
		  *(float *)&v20 = v20->z;
		  *(_QWORD *)&v25.x = v21;
		  LODWORD(v25.z) = (_DWORD)v20;
		  v11->distance = sub_182F9FF00(&v25);
		  LODWORD(value.x) = v5;
		  value.y = HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::GetMorphValue(v11, 0LL);
		  Unity::Collections::NativeList<BeyondDynamicBone::VirtualMesh::BaseLineWork>::Add(
		    (NativeList_1_BeyondDynamicBone_VirtualMesh_BaseLineWork_ *)nodeList,
		    (VirtualMesh_BaseLineWork *)&value,
		    MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::Add);
		}
		
		private void _SplitGeometry(int currIndex, [IsReadOnly] in Vector3 viewPoint) {} // 0x0000000189C194E0-0x0000000189C1966C
		// Void _SplitGeometry(Int32, Vector3 ByRef)
		void HG::Rendering::Runtime::HGTerrainRenderer::_SplitGeometry(
		        HGTerrainRenderer *this,
		        int32_t currIndex,
		        Vector3 *viewPoint,
		        MethodInfo *method)
		{
		  __int64 v4; // rbx
		  __int64 v7; // rdx
		  HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // rcx
		  HGTerrainRenderer_ChunkNode *v9; // rax
		  Void *m_Buffer; // rcx
		  HGTerrainRenderer_ChunkNode *v11; // rbp
		  unsigned int v12; // r14d
		  Int16__Array *children; // rdi
		  HGTerrainRenderer_ChunkNode__Array *v14; // r12
		  __int64 v15; // rdi
		  float v16; // xmm0_4
		  uint16_t v17; // bx
		  HGTerrainRenderer_ChunkNode *v18; // rax
		  int32_t v19; // ebx
		  int32_t parent; // edx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v4 = currIndex;
		  if ( IFix::WrappersManagerImpl::IsPatched(3965, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3965, 0LL);
		    if ( !Patch )
		      goto LABEL_18;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1396(Patch, (Object *)this, v4, viewPoint, 0LL);
		  }
		  else
		  {
		    m_chunkNodes = this->fields.m_chunkNodes;
		    if ( !m_chunkNodes )
		      goto LABEL_18;
		    v9 = (HGTerrainRenderer_ChunkNode *)sub_180444A00(m_chunkNodes, v4);
		    m_Buffer = this->fields.m_splits.m_Buffer;
		    v11 = v9;
		    if ( !*(_BYTE *)&m_Buffer[v4] )
		    {
		      m_Buffer[v4] = (Void)1;
		      if ( HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::HasChildren(v9, 0LL) )
		      {
		        v12 = 0;
		        while ( 1 )
		        {
		          children = v11->children;
		          if ( !children )
		            break;
		          if ( v12 >= children->max_length.size )
		            sub_1800D2AB0(m_chunkNodes, v7);
		          v14 = this->fields.m_chunkNodes;
		          if ( !v14 )
		            break;
		          v15 = children->vector[v12];
		          v16 = HG::Rendering::Runtime::HGTerrainRenderer::_DistFromAABBToPoint(this, viewPoint, v15, 0LL);
		          v17 = HG::Rendering::Runtime::HGTerrainRenderer::_ComputeChunkedLod(this, v16, 0LL);
		          v18 = (HGTerrainRenderer_ChunkNode *)sub_180444A00(v14, v15);
		          HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::ClampAndSaveMorph(v18, v17, 0LL);
		          if ( (int)++v12 >= 4 )
		            goto LABEL_10;
		        }
		LABEL_18:
		        sub_1800D8260(m_chunkNodes, v7);
		      }
		    }
		LABEL_10:
		    LOWORD(v19) = v11->parent;
		    if ( (_WORD)v19 != 0xFFFF )
		    {
		      parent = v11->parent;
		      do
		      {
		        if ( this->fields.m_splits.m_Buffer[(__int16)v19] )
		          break;
		        HG::Rendering::Runtime::HGTerrainRenderer::_SplitGeometry(this, parent, viewPoint, 0LL);
		        m_chunkNodes = this->fields.m_chunkNodes;
		        if ( !m_chunkNodes )
		          goto LABEL_18;
		        v19 = *(__int16 *)(sub_180444A00(m_chunkNodes, (__int16)v19) + 24);
		        parent = v19;
		      }
		      while ( v19 != -1 );
		    }
		  }
		}
		
		private void _ComputeLodMax(int cameraWidth, float tanHalfHorizFov) {} // 0x0000000189C1935C-0x0000000189C193EC
		// Void _ComputeLodMax(Int32, Single)
		void HG::Rendering::Runtime::HGTerrainRenderer::_ComputeLodMax(
		        HGTerrainRenderer *this,
		        int32_t cameraWidth,
		        float tanHalfHorizFov,
		        MethodInfo *method)
		{
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  HGTerrainConfiguration *m_configuration; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3959, 0LL) )
		  {
		    m_configuration = this->fields.m_configuration;
		    if ( m_configuration )
		    {
		      this->fields.m_geoLodMax = (float)((float)((float)cameraWidth / tanHalfHorizFov) * this->fields.m_geometryError)
		                               / m_configuration->fields.chunkedLodPixelError;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3959, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_931(Patch, (Object *)this, cameraWidth, tanHalfHorizFov, 0LL);
		}
		
		private ushort _ComputeChunkedLod(float dist) => default; // 0x0000000189C192A8-0x0000000189C1935C
		// UInt16 _ComputeChunkedLod(Single)
		uint16_t HG::Rendering::Runtime::HGTerrainRenderer::_ComputeChunkedLod(
		        HGTerrainRenderer *this,
		        float dist,
		        MethodInfo *method)
		{
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  __int64 v6; // r8
		  int m_treeDepth; // ebx
		  double v8; // xmm0_8
		  float v9; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3962, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3962, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_112(
		             (ILFixDynamicMethodWrapper_6 *)Patch,
		             (Object *)this,
		             dist,
		             0LL);
		  }
		  else
		  {
		    m_treeDepth = this->fields.m_treeDepth;
		    v8 = sub_182F114D0(v5, v4, v6);
		    v9 = *(float *)&v8;
		    sub_1800036A0(TypeInfo::System::Math);
		    return sub_18301DE80((unsigned int)((m_treeDepth << 8) - (int)(float)(v9 * 256.0) - 1), 0LL, 0xFFFFLL);
		  }
		}
		
		private float _DistFromAABBToPoint([IsReadOnly] in Vector3 viewPoint, int index) => default; // 0x0000000189C193EC-0x0000000189C194E0
		// Single _DistFromAABBToPoint(Vector3 ByRef, Int32)
		float HG::Rendering::Runtime::HGTerrainRenderer::_DistFromAABBToPoint(
		        HGTerrainRenderer *this,
		        Vector3 *viewPoint,
		        int32_t index,
		        MethodInfo *method)
		{
		  __int64 v5; // rbx
		  Void *m_Buffer; // rax
		  __m128 v8; // xmm4
		  __m128 v9; // xmm2
		  float v10; // xmm1_4
		  float v11; // xmm3_4
		  Void *v12; // rcx
		  float z; // edx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  Vector3 point; // [rsp+30h] [rbp-38h] BYREF
		  Vector3 bExtent; // [rsp+40h] [rbp-28h] BYREF
		  Vector3 bCenter; // [rsp+50h] [rbp-18h] BYREF
		
		  v5 = index;
		  if ( IFix::WrappersManagerImpl::IsPatched(3961, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3961, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v17, v16);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1391(Patch, (Object *)this, viewPoint, v5, 0LL);
		  }
		  else
		  {
		    m_Buffer = this->fields._centerXs_k__BackingField.m_Buffer;
		    v8 = (__m128)*(unsigned int *)&this->fields._centerYs_k__BackingField.m_Buffer[4 * v5];
		    v9 = (__m128)*(unsigned int *)&this->fields._extentYs_k__BackingField.m_Buffer[4 * v5];
		    v10 = *(float *)&this->fields._extentZs_k__BackingField.m_Buffer[4 * v5];
		    v11 = *(float *)&this->fields._centerZs_k__BackingField.m_Buffer[4 * v5];
		    v12 = this->fields._extentXs_k__BackingField.m_Buffer;
		    z = viewPoint->z;
		    *(_QWORD *)&point.x = *(_QWORD *)&viewPoint->x;
		    point.z = z;
		    *(_QWORD *)&bExtent.x = _mm_unpacklo_ps((__m128)*(_DWORD *)&v12[4 * v5], v9).m128_u64[0];
		    *(_QWORD *)&bCenter.x = _mm_unpacklo_ps((__m128)*(_DWORD *)&m_Buffer[4 * v5], v8).m128_u64[0];
		    bExtent.z = v10;
		    bCenter.z = v11;
		    return UnityEngine::GeometryUtility::DistFromAABBToPoint_Injected(&bCenter, &bExtent, &point, 0LL);
		  }
		}
		
		public void RenderFixedLevel(int l, CommandBuffer cmd, [IsReadOnly] in RenderStateBlock? renderStateBlock) {} // 0x0000000189C17954-0x0000000189C17CD0
		// Void RenderFixedLevel(Int32, CommandBuffer, Nullable`1[UnityEngine.Rendering.RenderStateBlock] ByRef)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGTerrainRenderer::RenderFixedLevel(
		        HGTerrainRenderer *this,
		        int32_t l,
		        CommandBuffer *cmd,
		        Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *renderStateBlock,
		        MethodInfo *method)
		{
		  uint16_t v9; // ax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  float startTime; // ebx
		  MaterialPropertyBlock *m_perDrawBlock; // rcx
		  MaterialPropertyBlock *v15; // rsi
		  __int64 v16; // rdx
		  int32_t HGTerrainChunkTransform; // r12d
		  HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // rcx
		  _OWORD *v19; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  __int64 v22; // rdx
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  Mesh *chunkMesh; // rax
		  Matrix4x4__StaticFields *v25; // rdx
		  MaterialPropertyBlock *v26; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  NativeArray_1_System_ValueTuple_2_Int32_Single_ value; // [rsp+50h] [rbp-128h] BYREF
		  __int128 v31; // [rsp+60h] [rbp-118h]
		  AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle v32; // [rsp+70h] [rbp-108h]
		  Matrix4x4 identityMatrix; // [rsp+80h] [rbp-F8h] BYREF
		  NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ v34; // [rsp+C0h] [rbp-B8h] BYREF
		  Il2CppExceptionWrapper *v35; // [rsp+E0h] [rbp-98h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v36; // [rsp+F0h] [rbp-88h] BYREF
		
		  value = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(4010, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4010, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v29, v28);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1409(Patch, (Object *)this, l, (Object *)cmd, renderStateBlock, 0LL);
		  }
		  else
		  {
		    v9 = HG::Rendering::Runtime::HGTerrainRenderer::_ClampLevel(this, l, 0LL);
		    if ( !this->fields.m_fixedLevelRenderData )
		      sub_1800D8260(v11, v10);
		    if ( System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::TryGetValue(
		           this->fields.m_fixedLevelRenderData,
		           v9,
		           &value,
		           MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::TryGetValue) )
		    {
		      Unity::Collections::NativeArray_1_T_::ReadOnly<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::GetEnumerator(
		        (NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&identityMatrix,
		        (NativeArray_1_T_ReadOnly_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&value,
		        MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::GetEnumerator);
		      v34.m_Array = *(NativeArray_1_T_ReadOnly_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&identityMatrix.m00;
		      *(_OWORD *)&v34.m_Index = *(_OWORD *)&identityMatrix.m01;
		      value.m_Buffer = 0LL;
		      *(_QWORD *)&value.m_Length = &v34;
		      try
		      {
		        while ( Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::MoveNext(
		                  &v34,
		                  MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::MoveNext) )
		        {
		          startTime = v34.value.startTime;
		          v32 = v34.value;
		          m_perDrawBlock = this->fields.m_perDrawBlock;
		          if ( !m_perDrawBlock )
		            sub_1800D8250(0LL, v12);
		          UnityEngine::MaterialPropertyBlock::Clear(m_perDrawBlock, 1, 0LL);
		          v15 = this->fields.m_perDrawBlock;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		          HGTerrainChunkTransform = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainChunkTransform;
		          m_chunkNodes = this->fields.m_chunkNodes;
		          if ( !m_chunkNodes )
		            sub_1800D8250(0LL, v16);
		          v19 = (_OWORD *)sub_180444A00(m_chunkNodes, SLODWORD(startTime));
		          if ( !v15 )
		            sub_1800D8250(v21, v20);
		          *(_OWORD *)&identityMatrix.m00 = *v19;
		          UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		            v15,
		            HGTerrainChunkTransform,
		            (Vector4 *)&identityMatrix,
		            0LL);
		          static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		          *(_QWORD *)&v31 = 0LL;
		          *((_QWORD *)&v31 + 1) = (unsigned int)v32.type;
		          if ( !this->fields.m_perDrawBlock )
		            sub_1800D8250(static_fields, v22);
		          *(_OWORD *)&identityMatrix.m00 = v31;
		          UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		            this->fields.m_perDrawBlock,
		            static_fields->_HGTerrainChunkParam0,
		            (Vector4 *)&identityMatrix,
		            0LL);
		          chunkMesh = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkMesh(this, 0LL);
		          v25 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		          v26 = this->fields.m_perDrawBlock;
		          if ( !cmd )
		            sub_1800D8250(v26, v25);
		          v36 = *renderStateBlock;
		          identityMatrix = v25->identityMatrix;
		          UnityEngine::Rendering::CommandBuffer::DrawMesh(
		            cmd,
		            chunkMesh,
		            &identityMatrix,
		            this->fields.m_terrainLitMaterial,
		            SLODWORD(startTime),
		            2,
		            v26,
		            &v36,
		            0LL);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v35 )
		      {
		        value.m_Buffer = (Void *)v35->ex;
		        if ( value.m_Buffer )
		          sub_18007E1E0(value.m_Buffer);
		      }
		    }
		  }
		}
		
		public void RenderNodeList(NativeList<ValueTuple<int, float>> nodeList, CommandBuffer cmd, [IsReadOnly] in RenderStateBlock? renderStateBlock) {} // 0x0000000189C17CD0-0x0000000189C18030
		// Void RenderNodeList(NativeList`1[System.ValueTuple`2[Int32,Single]], CommandBuffer, Nullable`1[UnityEngine.Rendering.RenderStateBlock] ByRef)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGTerrainRenderer::RenderNodeList(
		        HGTerrainRenderer *this,
		        NativeList_1_System_ValueTuple_2_Int32_Single_ *nodeList,
		        CommandBuffer *cmd,
		        Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *renderStateBlock,
		        MethodInfo *method)
		{
		  NativeList_1_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *v7; // rsi
		  __int64 v9; // rdx
		  float startTime; // ebx
		  MaterialPropertyBlock *m_perDrawBlock; // rcx
		  MaterialPropertyBlock *v12; // r14
		  __int64 v13; // rdx
		  int32_t HGTerrainChunkTransform; // r13d
		  HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // rcx
		  _OWORD *v16; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  __int64 v19; // rdx
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  Mesh *chunkMesh; // rax
		  Matrix4x4__StaticFields *v22; // rdx
		  MaterialPropertyBlock *v23; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  __int128 v27; // [rsp+50h] [rbp-138h]
		  unsigned int type; // [rsp+64h] [rbp-124h]
		  Il2CppException *ex; // [rsp+68h] [rbp-120h]
		  Matrix4x4 value; // [rsp+80h] [rbp-108h] BYREF
		  NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ v31; // [rsp+C0h] [rbp-C8h] BYREF
		  Il2CppExceptionWrapper *v32; // [rsp+E0h] [rbp-A8h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v33; // [rsp+F0h] [rbp-98h] BYREF
		
		  v7 = (NativeList_1_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)nodeList;
		  if ( IFix::WrappersManagerImpl::IsPatched(4011, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4011, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v26, v25);
		    *(NativeList_1_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&value.m00 = *v7;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1410(
		      Patch,
		      (Object *)this,
		      (NativeList_1_System_ValueTuple_2_Int32_Single_ *)&value,
		      (Object *)cmd,
		      renderStateBlock,
		      0LL);
		  }
		  else
		  {
		    Unity::Collections::NativeList<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::GetEnumerator(
		      (NativeArray_1_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&value,
		      v7,
		      MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::GetEnumerator);
		    v31.m_Array = *(NativeArray_1_T_ReadOnly_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&value.m00;
		    *(_OWORD *)&v31.m_Index = *(_OWORD *)&value.m01;
		    try
		    {
		      while ( Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::MoveNext(
		                &v31,
		                MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::MoveNext) )
		      {
		        startTime = v31.value.startTime;
		        type = v31.value.type;
		        m_perDrawBlock = this->fields.m_perDrawBlock;
		        if ( !m_perDrawBlock )
		          sub_1800D8250(0LL, v9);
		        UnityEngine::MaterialPropertyBlock::Clear(m_perDrawBlock, 1, 0LL);
		        v12 = this->fields.m_perDrawBlock;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        HGTerrainChunkTransform = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainChunkTransform;
		        m_chunkNodes = this->fields.m_chunkNodes;
		        if ( !m_chunkNodes )
		          sub_1800D8250(0LL, v13);
		        v16 = (_OWORD *)sub_180444A00(m_chunkNodes, SLODWORD(startTime));
		        if ( !v12 )
		          sub_1800D8250(v18, v17);
		        *(_OWORD *)&value.m00 = *v16;
		        UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(v12, HGTerrainChunkTransform, (Vector4 *)&value, 0LL);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        *(_QWORD *)&v27 = 0LL;
		        *((_QWORD *)&v27 + 1) = type;
		        if ( !this->fields.m_perDrawBlock )
		          sub_1800D8250(static_fields, v19);
		        *(_OWORD *)&value.m00 = v27;
		        UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		          this->fields.m_perDrawBlock,
		          static_fields->_HGTerrainChunkParam0,
		          (Vector4 *)&value,
		          0LL);
		        chunkMesh = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkMesh(this, 0LL);
		        v22 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		        v23 = this->fields.m_perDrawBlock;
		        if ( !cmd )
		          sub_1800D8250(v23, v22);
		        v33 = *renderStateBlock;
		        value = v22->identityMatrix;
		        UnityEngine::Rendering::CommandBuffer::DrawMesh(
		          cmd,
		          chunkMesh,
		          &value,
		          this->fields.m_terrainLitMaterial,
		          SLODWORD(startTime),
		          2,
		          v23,
		          &v33,
		          0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v32 )
		    {
		      ex = v32->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v7 = (NativeList_1_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)nodeList;
		    }
		    Unity::Collections::NativeList<System::ValueTuple<int,float>>::Dispose(
		      (NativeList_1_System_ValueTuple_2_Int32_Single_ *)v7,
		      MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::Dispose);
		  }
		}
		
		public void RenderScreenSpaceTerrain(CommandBuffer cmd) {} // 0x0000000189C18030-0x0000000189C180B4
		// Void RenderScreenSpaceTerrain(CommandBuffer)
		void HG::Rendering::Runtime::HGTerrainRenderer::RenderScreenSpaceTerrain(
		        HGTerrainRenderer *this,
		        CommandBuffer *cmd,
		        MethodInfo *method)
		{
		  Material *m_terrainLitMaterial; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4012, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4012, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)cmd,
		      0LL);
		  }
		  else
		  {
		    m_terrainLitMaterial = this->fields.m_terrainLitMaterial;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, m_terrainLitMaterial, 0LL, 6, 0LL);
		  }
		}
		
		public void Render(int cameraGuid, CommandBuffer cmd, TerrainPassType passType, bool enableTessellation, [IsReadOnly] in RenderStateBlock? renderStateBlock) {} // 0x0000000189C180B4-0x0000000189C187A0
		// Void Render(Int32, CommandBuffer, HGTerrainRenderer+TerrainPassType, Boolean, Nullable`1[UnityEngine.Rendering.RenderStateBlock] ByRef)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::HGTerrainRenderer::Render(
		        HGTerrainRenderer *this,
		        int32_t cameraGuid,
		        CommandBuffer *cmd,
		        HGTerrainRenderer_TerrainPassType__Enum passType,
		        bool enableTessellation,
		        Nullable_1_UnityEngine_Rendering_RenderStateBlock_ *renderStateBlock,
		        MethodInfo *method)
		{
		  __int64 v7; // r15
		  Object *v8; // r13
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  Object_1 *deformableControlMap; // rbx
		  Material *m_terrainLitMaterial; // rbx
		  __int64 v17; // rdx
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  int32_t HGTerrainDeformableControlMap; // r12d
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  Texture *blackTexture; // r14
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  __int64 v25; // rdx
		  float startTime; // ebx
		  MaterialPropertyBlock *m_perDrawBlock; // rcx
		  MaterialPropertyBlock *v28; // r14
		  __int64 v29; // rdx
		  int32_t HGTerrainChunkTransform; // r12d
		  HGTerrainRenderer_ChunkNode__Array *m_chunkNodes; // rcx
		  _OWORD *v32; // rax
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  __int64 v35; // rdx
		  MaterialPropertyBlock *v36; // r14
		  int32_t HGTerrainChunkParam0; // r12d
		  HGTerrainRenderer_ChunkNode__Array *v38; // rcx
		  __int64 v39; // rax
		  __int64 v40; // rdx
		  __int64 v41; // rcx
		  __int64 v42; // rdx
		  __int64 v43; // r8
		  HGTerrainRenderer__StaticFields *v44; // rcx
		  HGTerrainRenderer_TerrainPassType__Enum__Array *tessellationPassTypeMapping; // rax
		  HGTerrainRenderer_ChunkNode__Array *v46; // rcx
		  HGTerrainRenderer_ChunkNode *v47; // rax
		  Mesh *chunkMesh; // r12
		  Matrix4x4__StaticFields *v49; // rcx
		  __int128 v50; // xmm6
		  __int128 v51; // xmm7
		  __int128 v52; // xmm8
		  __int128 v53; // xmm9
		  __int64 v54; // rdx
		  __int64 v55; // r8
		  HGTerrainRenderer__StaticFields *v56; // rcx
		  HGTerrainRenderer_TerrainPassType__Enum__Array *v57; // rax
		  HGTerrainRenderer_TerrainPassType__Enum v58; // ebx
		  MaterialPropertyBlock *v59; // r14
		  __int64 v60; // rdx
		  __int64 v61; // rcx
		  Material *v62; // r9
		  Matrix4x4__StaticFields *v63; // r14
		  MaterialPropertyBlock *v64; // r13
		  __int64 v65; // rdx
		  __int64 v66; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v68; // rdx
		  __int64 v69; // rcx
		  HGTerrainRenderer_TerrainPassType__Enum P3; // [rsp+20h] [rbp-208h]
		  bool P4[4]; // [rsp+28h] [rbp-200h]
		  MaterialPropertyBlock *P5; // [rsp+30h] [rbp-1F8h]
		  Material *v73; // [rsp+50h] [rbp-1D8h]
		  int32_t type; // [rsp+54h] [rbp-1D4h]
		  NativeParallelHashMap_2_System_UInt32_Beyond_Gameplay_Core_DynamicScene_RuntimeAttachData_ value; // [rsp+58h] [rbp-1D0h] BYREF
		  __int128 v76; // [rsp+68h] [rbp-1C0h]
		  Matrix4x4 identityMatrix; // [rsp+80h] [rbp-1A8h] BYREF
		  NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ v78; // [rsp+C0h] [rbp-168h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v79; // [rsp+E0h] [rbp-148h] BYREF
		  Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v80; // [rsp+150h] [rbp-D8h] BYREF
		  Il2CppExceptionWrapper *v81; // [rsp+1C0h] [rbp-68h] BYREF
		
		  v7 = passType;
		  v8 = (Object *)cmd;
		  value = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(4013, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4013, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v69, v68);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1411(
		      Patch,
		      (Object *)this,
		      cameraGuid,
		      v8,
		      (HGTerrainRenderer_TerrainPassType__Enum)v7,
		      enableTessellation,
		      renderStateBlock,
		      0LL);
		  }
		  else
		  {
		    if ( !this->fields.m_cameraRenderData )
		      sub_1800D8260(v12, v11);
		    if ( System::Collections::Generic::Dictionary<int,Unity::Collections::NativeParallelHashMap<unsigned int,Beyond::Gameplay::Core::DynamicScene::RuntimeAttachData>>::TryGetValue(
		           (Dictionary_2_System_Int32_Unity_Collections_NativeParallelHashMap_2_System_UInt32_Beyond_Gameplay_Core_DynamicScene_RuntimeAttachData_ *)this->fields.m_cameraRenderData,
		           cameraGuid,
		           &value,
		           MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::TryGetValue) )
		    {
		      if ( !enableTessellation )
		        goto LABEL_10;
		      if ( !this->fields.m_vtRenderer )
		        sub_1800D8260(v14, v13);
		      deformableControlMap = (Object_1 *)HG::Rendering::Runtime::VirtualTextureRenderer::get_deformableControlMap(
		                                           this->fields.m_vtRenderer,
		                                           0LL);
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( UnityEngine::Object::op_Inequality(deformableControlMap, 0LL, 0LL) )
		      {
		        m_terrainLitMaterial = this->fields.m_terrainLitMaterial;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		        HGTerrainDeformableControlMap = static_fields->_HGTerrainDeformableControlMap;
		        if ( !this->fields.m_vtRenderer )
		          sub_1800D8260(static_fields, v17);
		        blackTexture = HG::Rendering::Runtime::VirtualTextureRenderer::get_deformableControlMap(
		                         this->fields.m_vtRenderer,
		                         0LL);
		        if ( !m_terrainLitMaterial )
		          sub_1800D8260(v21, v20);
		      }
		      else
		      {
		LABEL_10:
		        m_terrainLitMaterial = this->fields.m_terrainLitMaterial;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		        HGTerrainDeformableControlMap = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainDeformableControlMap;
		        blackTexture = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		        if ( !m_terrainLitMaterial )
		          sub_1800D8260(v24, v23);
		      }
		      UnityEngine::Material::SetTextureImpl(m_terrainLitMaterial, HGTerrainDeformableControlMap, blackTexture, 0LL);
		      Unity::Collections::NativeList<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::GetEnumerator(
		        (NativeArray_1_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&identityMatrix,
		        (NativeList_1_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&value,
		        MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::GetEnumerator);
		      v78.m_Array = *(NativeArray_1_T_ReadOnly_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&identityMatrix.m00;
		      *(_OWORD *)&v78.m_Index = *(_OWORD *)&identityMatrix.m01;
		      value.m_HashMapData.m_Buffer = 0LL;
		      *(_QWORD *)&value.m_HashMapData.m_AllocatorLabel.Index = &v78;
		      try
		      {
		        while ( Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::MoveNext(
		                  &v78,
		                  MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::MoveNext) )
		        {
		          startTime = v78.value.startTime;
		          type = v78.value.type;
		          m_perDrawBlock = this->fields.m_perDrawBlock;
		          if ( !m_perDrawBlock )
		            sub_1800D8250(0LL, v25);
		          UnityEngine::MaterialPropertyBlock::Clear(m_perDrawBlock, 1, 0LL);
		          v28 = this->fields.m_perDrawBlock;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		          HGTerrainChunkTransform = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainChunkTransform;
		          m_chunkNodes = this->fields.m_chunkNodes;
		          if ( !m_chunkNodes )
		            sub_1800D8250(0LL, v29);
		          v32 = (_OWORD *)sub_180444A00(m_chunkNodes, SLODWORD(startTime));
		          if ( !v28 )
		            sub_1800D8250(v34, v33);
		          *(_OWORD *)&identityMatrix.m00 = *v32;
		          UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		            v28,
		            HGTerrainChunkTransform,
		            (Vector4 *)&identityMatrix,
		            0LL);
		          v36 = this->fields.m_perDrawBlock;
		          HGTerrainChunkParam0 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainChunkParam0;
		          v38 = this->fields.m_chunkNodes;
		          if ( !v38 )
		            sub_1800D8250(0LL, v35);
		          v39 = sub_180444A00(v38, SLODWORD(startTime));
		          *(_QWORD *)&v76 = 0LL;
		          DWORD2(v76) = type;
		          *((float *)&v76 + 3) = (float)*(unsigned __int16 *)(v39 + 26);
		          if ( !v36 )
		            sub_1800D8250(v41, v40);
		          *(_OWORD *)&identityMatrix.m00 = v76;
		          UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		            v36,
		            HGTerrainChunkParam0,
		            (Vector4 *)&identityMatrix,
		            0LL);
		          if ( !enableTessellation )
		            goto LABEL_29;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainRenderer);
		          v44 = TypeInfo::HG::Rendering::Runtime::HGTerrainRenderer->static_fields;
		          tessellationPassTypeMapping = v44->tessellationPassTypeMapping;
		          if ( !v44->tessellationPassTypeMapping )
		            sub_1800D8250(v44, v42);
		          if ( (unsigned int)v7 >= tessellationPassTypeMapping->max_length.size )
		            sub_1800D2AA0(v44, v42, v43);
		          if ( tessellationPassTypeMapping->vector[v7] == HGTerrainRenderer_TerrainPassType__Enum_Invalid )
		            goto LABEL_29;
		          v46 = this->fields.m_chunkNodes;
		          if ( !v46 )
		            sub_1800D8250(0LL, v42);
		          v47 = (HGTerrainRenderer_ChunkNode *)sub_180444A00(v46, SLODWORD(startTime));
		          if ( HG::Rendering::Runtime::HGTerrainRenderer::ChunkNode::HasChildren(v47, 0LL) )
		          {
		LABEL_29:
		            chunkMesh = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkMesh(this, 0LL);
		            v63 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		            v64 = this->fields.m_perDrawBlock;
		            sub_18033B9D0(&v79, 0LL, 112LL);
		            if ( !cmd )
		              sub_1800D8250(v66, v65);
		            v80 = v79;
		            identityMatrix = v63->identityMatrix;
		            P5 = v64;
		            *(_DWORD *)P4 = v7;
		            P3 = LODWORD(startTime);
		            v62 = this->fields.m_terrainLitMaterial;
		            v8 = (Object *)cmd;
		          }
		          else
		          {
		            chunkMesh = this->fields.m_tessellationQuadMesh;
		            v49 = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		            v50 = *(_OWORD *)&v49->identityMatrix.m00;
		            v51 = *(_OWORD *)&v49->identityMatrix.m01;
		            v52 = *(_OWORD *)&v49->identityMatrix.m02;
		            v53 = *(_OWORD *)&v49->identityMatrix.m03;
		            v73 = this->fields.m_terrainLitMaterial;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainRenderer);
		            v56 = TypeInfo::HG::Rendering::Runtime::HGTerrainRenderer->static_fields;
		            v57 = v56->tessellationPassTypeMapping;
		            if ( !v56->tessellationPassTypeMapping )
		              sub_1800D8250(v56, v54);
		            if ( (unsigned int)v7 >= v57->max_length.size )
		              sub_1800D2AA0(v56, v54, v55);
		            v58 = v57->vector[v7];
		            v59 = this->fields.m_perDrawBlock;
		            sub_18033B9D0(&v79, 0LL, 112LL);
		            if ( !v8 )
		              sub_1800D8250(v61, v60);
		            v80 = v79;
		            *(_OWORD *)&identityMatrix.m00 = v50;
		            *(_OWORD *)&identityMatrix.m01 = v51;
		            *(_OWORD *)&identityMatrix.m02 = v52;
		            *(_OWORD *)&identityMatrix.m03 = v53;
		            P5 = v59;
		            *(_DWORD *)P4 = v58;
		            P3 = HGTerrainRenderer_TerrainPassType__Enum_GBuffer;
		            v62 = v73;
		          }
		          UnityEngine::Rendering::CommandBuffer::DrawMesh(
		            (CommandBuffer *)v8,
		            chunkMesh,
		            &identityMatrix,
		            v62,
		            P3,
		            *(int32_t *)P4,
		            P5,
		            &v80,
		            0LL);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v81 )
		      {
		        value.m_HashMapData.m_Buffer = (UnsafeParallelHashMapData *)v81->ex;
		        if ( value.m_HashMapData.m_Buffer )
		          sub_18007E1E0(value.m_HashMapData.m_Buffer);
		      }
		    }
		  }
		}
		
		public void RenderFeedback(Camera camera, ScriptableRenderContext renderContext) {} // 0x0000000189C1684C-0x0000000189C17954
		// Void RenderFeedback(Camera, ScriptableRenderContext)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGTerrainRenderer::RenderFeedback(
		        HGTerrainRenderer *this,
		        Camera *camera,
		        ScriptableRenderContext renderContext,
		        MethodInfo *method)
		{
		  Object *v4; // r14
		  HGTerrainRenderer *v5; // rsi
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  VirtualTextureRenderer *m_vtRenderer; // rbx
		  Dictionary_2_System_Int32_Unity_Collections_NativeParallelHashMap_2_System_UInt32_Beyond_Gameplay_Core_DynamicScene_RuntimeAttachData_ *m_cameraRenderData; // rbx
		  int32_t InstanceID; // eax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  __int64 v15; // r8
		  __int64 v16; // r9
		  float v17; // xmm10_4
		  float v18; // xmm8_4
		  float farClipPlane; // xmm11_4
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  float v22; // xmm6_4
		  VirtualTextureRenderer *v23; // rbx
		  __m128 v24; // xmm6
		  __int128 v25; // xmm8
		  __int128 v26; // xmm9
		  __int128 v27; // xmm10
		  __int128 v28; // xmm11
		  int32_t Length; // eax
		  int v30; // r12d
		  __m128i v31; // xmm6
		  MethodInfo *v32; // r9
		  MethodInfo *v33; // r8
		  Vector4 *v34; // rax
		  __m128i *m_Buffer; // rbx
		  __m128i v36; // xmm6
		  MethodInfo *v37; // r9
		  __m128i v38; // xmm6
		  MethodInfo *v39; // r9
		  MethodInfo *v40; // r8
		  __m128i v41; // xmm6
		  MethodInfo *v42; // r9
		  __m128i v43; // xmm6
		  MethodInfo *v44; // r9
		  MethodInfo *v45; // r8
		  int v46; // eax
		  __int64 v47; // r13
		  __m128i v48; // xmm6
		  int32_t v49; // xmm2_4
		  float v50; // xmm0_4
		  MethodInfo *v51; // r9
		  float startTime; // ebx
		  int32_t type; // xmm12_4
		  float v54; // xmm13_4
		  float v55; // xmm14_4
		  float v56; // xmm15_4
		  char v57; // r13
		  float v58; // xmm5_4
		  float v59; // xmm2_4
		  unsigned __int32 v60; // xmm6_4
		  __int64 v61; // rdx
		  __int64 v62; // rdx
		  VirtualTextureRenderer *m_perDrawBlock; // rcx
		  AttachmentDescriptor *gpuFeedbackColorDesc; // rax
		  __int128 v65; // xmm2
		  __int128 v66; // xmm3
		  __int128 v67; // xmm4
		  __int128 v68; // xmm5
		  __int128 v69; // xmm6
		  Color m_ClearColor; // xmm7
		  __int64 v71; // xmm0_8
		  Void *v72; // rbx
		  AttachmentDescriptor *gpuFeedbackDepthDesc; // rax
		  __int128 v74; // xmm2
		  __int128 v75; // xmm3
		  __int128 v76; // xmm4
		  __int128 v77; // xmm5
		  __int128 v78; // xmm6
		  Color v79; // xmm7
		  __int64 v80; // xmm0_8
		  Void *v81; // rbx
		  int32_t v82; // ebx
		  Material *m_terrainLitMaterial; // rbx
		  int32_t HGTerrainFeedbackViewProj; // r13d
		  Matrix4x4 *GPUProjectionMatrix; // rax
		  __int128 v86; // xmm6
		  __int128 v87; // xmm7
		  __int128 v88; // xmm8
		  __int128 v89; // xmm9
		  Matrix4x4 *v90; // rax
		  ComputeBuffer *currGPUFeedbackBuffer; // rax
		  UnsafeParallelHashMapData *v92; // r14
		  __int64 v93; // r12
		  Void *v94; // rbx
		  MaterialPropertyBlock *v95; // r13
		  NativeArray_1_UnityEngine_Vector4_ *v96; // rax
		  MaterialPropertyBlock *v97; // r13
		  Mesh *chunkMesh; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v100; // rdx
		  __int64 v101; // rcx
		  char v102; // [rsp+40h] [rbp-2C8h]
		  NativeArray_1_UnityEngine_Vector4_ v103; // [rsp+50h] [rbp-2B8h] BYREF
		  int32_t name; // [rsp+60h] [rbp-2A8h]
		  int v105; // [rsp+64h] [rbp-2A4h]
		  NativeArray_1_UnityEngine_Vector4_ v106; // [rsp+70h] [rbp-298h] BYREF
		  NativeParallelHashMap_2_System_UInt32_Beyond_Gameplay_Core_DynamicScene_RuntimeAttachData_ value; // [rsp+80h] [rbp-288h] BYREF
		  NativeArray_1_System_Int32_ v108; // [rsp+90h] [rbp-278h] BYREF
		  Vector4 v109; // [rsp+A0h] [rbp-268h] BYREF
		  float v110; // [rsp+B0h] [rbp-258h]
		  float v111; // [rsp+B4h] [rbp-254h]
		  float v112; // [rsp+B8h] [rbp-250h]
		  Matrix4x4 identityMatrix; // [rsp+C0h] [rbp-248h] BYREF
		  Matrix4x4 v114; // [rsp+100h] [rbp-208h] BYREF
		  Matrix4x4 v115; // [rsp+140h] [rbp-1C8h] BYREF
		  NativeArray_1_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ v116; // [rsp+180h] [rbp-188h] BYREF
		  NativeArray_1_UnityEngine_Rendering_AttachmentDescriptor_ v117; // [rsp+190h] [rbp-178h] BYREF
		  NativeArray_1_T_ReadOnly_T_Enumerator_MagicaCloth_RestoreRotationConstraint_RotationData_ v118; // [rsp+1A0h] [rbp-168h] BYREF
		  NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ v119; // [rsp+1C8h] [rbp-140h] BYREF
		  Il2CppExceptionWrapper *v120; // [rsp+1E8h] [rbp-120h] BYREF
		  Il2CppExceptionWrapper *v121; // [rsp+1F0h] [rbp-118h] BYREF
		  Matrix4x4 v122[3]; // [rsp+1F8h] [rbp-110h] BYREF
		  ScriptableRenderContext P2; // [rsp+320h] [rbp+18h] BYREF
		
		  P2.m_Ptr = renderContext.m_Ptr;
		  v4 = (Object *)camera;
		  v5 = this;
		  value = 0LL;
		  v116 = 0LL;
		  v117 = 0LL;
		  v108 = 0LL;
		  v106 = 0LL;
		  memset(&v118, 0, sizeof(v118));
		  if ( IFix::WrappersManagerImpl::IsPatched(4015, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4015, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v101, v100);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1415(Patch, (Object *)v5, v4, P2, 0LL);
		  }
		  else
		  {
		    m_vtRenderer = v5->fields.m_vtRenderer;
		    if ( !m_vtRenderer )
		      sub_1800D8260(v7, v6);
		    if ( m_vtRenderer->fields._feedbackMode_k__BackingField == 1 )
		    {
		      m_cameraRenderData = (Dictionary_2_System_Int32_Unity_Collections_NativeParallelHashMap_2_System_UInt32_Beyond_Gameplay_Core_DynamicScene_RuntimeAttachData_ *)v5->fields.m_cameraRenderData;
		      if ( !v4 )
		        sub_1800D8260(v7, v6);
		      InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)v4, 0LL);
		      if ( !m_cameraRenderData )
		        sub_1800D8260(v12, v11);
		      if ( System::Collections::Generic::Dictionary<int,Unity::Collections::NativeParallelHashMap<unsigned int,Beyond::Gameplay::Core::DynamicScene::RuntimeAttachData>>::TryGetValue(
		             m_cameraRenderData,
		             InstanceID,
		             &value,
		             MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::TryGetValue) )
		      {
		        UnityEngine::Camera::get_fieldOfView((Camera *)v4, 0LL);
		        v17 = sub_180338A80(v14, v13, v15, v16);
		        v18 = UnityEngine::Camera::get_nearClipPlane((Camera *)v4, 0LL);
		        farClipPlane = UnityEngine::Camera::get_farClipPlane((Camera *)v4, 0LL);
		        v22 = (float)((float)-v18 * v17) * UnityEngine::Camera::get_aspect((Camera *)v4, 0LL);
		        v23 = v5->fields.m_vtRenderer;
		        if ( !v23 )
		          sub_1800D8260(v21, v20);
		        v24 = (__m128)_mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VirtualTextureRenderer::GetFeedbackSubViewRange(
		                                                         (ValueTuple_4_Single_Single_Single_Single_ *)&v103,
		                                                         v23,
		                                                         v22,
		                                                         -v22,
		                                                         (float)-v18 * v17,
		                                                         -(float)((float)-v18 * v17),
		                                                         0LL));
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
		        identityMatrix = *HG::Rendering::Runtime::HGTerrainUtils::PerspectiveOffCenter(
		                            &v114,
		                            v24.m128_f32[0],
		                            _mm_shuffle_ps(v24, v24, 85).m128_f32[0],
		                            _mm_shuffle_ps(v24, v24, 170).m128_f32[0],
		                            _mm_shuffle_ps(v24, v24, 255).m128_f32[0],
		                            v18,
		                            farClipPlane,
		                            0LL);
		        v25 = *(_OWORD *)&identityMatrix.m00;
		        v26 = *(_OWORD *)&identityMatrix.m01;
		        v27 = *(_OWORD *)&identityMatrix.m02;
		        v28 = *(_OWORD *)&identityMatrix.m03;
		        Length = Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::get_Length(
		                   (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&value,
		                   MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::get_Length);
		        Unity::Collections::NativeArray<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::NativeArray(
		          &v116,
		          Length,
		          Allocator__Enum_Temp,
		          NativeArrayOptions__Enum_ClearMemory,
		          MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::NativeArray);
		        v30 = 0;
		        v105 = 0;
		        v114 = *UnityEngine::Camera::get_worldToCameraMatrix(&v115, (Camera *)v4, 0LL);
		        *(_OWORD *)&v115.m00 = v25;
		        *(_OWORD *)&v115.m01 = v26;
		        *(_OWORD *)&v115.m02 = v27;
		        *(_OWORD *)&v115.m03 = v28;
		        v114 = *UnityEngine::Matrix4x4::op_Multiply(v122, &v115, &v114, 0LL);
		        Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray(
		          &v106,
		          5,
		          Allocator__Enum_Temp,
		          NativeArrayOptions__Enum_ClearMemory,
		          MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
		        v31 = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow((Vector4 *)&v103, &v114, 3, 0LL));
		        v103 = (NativeArray_1_UnityEngine_Vector4_)*UnityEngine::Matrix4x4::GetRow((Vector4 *)&v103, &v114, 0, 0LL);
		        *(__m128i *)&v115.m00 = v31;
		        v103 = (NativeArray_1_UnityEngine_Vector4_)*UnityEngine::Vector4::op_Addition(
		                                                      &v109,
		                                                      (Vector4 *)&v115,
		                                                      (Vector4 *)&v103,
		                                                      v32);
		        v34 = UnityEngine::Vector4::op_UnaryNegation((Vector4 *)&v115, (Vector4 *)&v103, v33);
		        m_Buffer = (__m128i *)v106.m_Buffer;
		        *(__m128i *)v106.m_Buffer = _mm_loadu_si128((const __m128i *)v34);
		        v36 = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow((Vector4 *)&v103, &v114, 0, 0LL));
		        v103 = (NativeArray_1_UnityEngine_Vector4_)*UnityEngine::Matrix4x4::GetRow((Vector4 *)&v103, &v114, 3, 0LL);
		        *(__m128i *)&v115.m00 = v36;
		        m_Buffer[1] = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Subtraction(
		                                                         &v109,
		                                                         (Vector4 *)&v115,
		                                                         (Vector4 *)&v103,
		                                                         v37));
		        v38 = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow((Vector4 *)&v103, &v114, 3, 0LL));
		        v103 = (NativeArray_1_UnityEngine_Vector4_)*UnityEngine::Matrix4x4::GetRow((Vector4 *)&v103, &v114, 1, 0LL);
		        *(__m128i *)&v115.m00 = v38;
		        v103 = (NativeArray_1_UnityEngine_Vector4_)*UnityEngine::Vector4::op_Addition(
		                                                      &v109,
		                                                      (Vector4 *)&v115,
		                                                      (Vector4 *)&v103,
		                                                      v39);
		        m_Buffer[2] = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_UnaryNegation(
		                                                         (Vector4 *)&v115,
		                                                         (Vector4 *)&v103,
		                                                         v40));
		        v41 = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow((Vector4 *)&v103, &v114, 1, 0LL));
		        v103 = (NativeArray_1_UnityEngine_Vector4_)*UnityEngine::Matrix4x4::GetRow((Vector4 *)&v103, &v114, 3, 0LL);
		        *(__m128i *)&v115.m00 = v41;
		        m_Buffer[3] = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Subtraction(
		                                                         &v109,
		                                                         (Vector4 *)&v115,
		                                                         (Vector4 *)&v103,
		                                                         v42));
		        v43 = _mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow((Vector4 *)&v103, &v114, 3, 0LL));
		        v103 = (NativeArray_1_UnityEngine_Vector4_)*UnityEngine::Matrix4x4::GetRow((Vector4 *)&v103, &v114, 2, 0LL);
		        *(__m128i *)&v115.m00 = v43;
		        v103 = (NativeArray_1_UnityEngine_Vector4_)*UnityEngine::Vector4::op_Addition(
		                                                      &v109,
		                                                      (Vector4 *)&v115,
		                                                      (Vector4 *)&v103,
		                                                      v44);
		        m_Buffer[4] = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_UnaryNegation(
		                                                         (Vector4 *)&v115,
		                                                         (Vector4 *)&v103,
		                                                         v45));
		        v103 = v106;
		        v46 = _mm_cvtsi128_si32(_mm_srli_si128((__m128i)v106, 8));
		        if ( v46 > 0 )
		        {
		          v47 = (unsigned int)v46;
		          do
		          {
		            v48 = _mm_loadu_si128(m_Buffer);
		            v49 = m_Buffer->m128i_i32[2];
		            v106.m_Buffer = (Void *)_mm_unpacklo_ps((__m128)m_Buffer->m128i_u32[0], (__m128)m_Buffer->m128i_u32[1]).m128_u64[0];
		            v106.m_Length = v49;
		            v50 = sub_182F9FF00(&v106);
		            *(__m128i *)&v115.m00 = v48;
		            *m_Buffer++ = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Multiply(
		                                                             &v109,
		                                                             (Vector4 *)&v115,
		                                                             1.0 / v50,
		                                                             v51));
		            --v47;
		          }
		          while ( v47 );
		        }
		        Unity::Collections::NativeList<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::GetEnumerator(
		          (NativeArray_1_T_Enumerator_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&v115,
		          (NativeList_1_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&value,
		          MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::GetEnumerator);
		        v119.m_Array = *(NativeArray_1_T_ReadOnly_Beyond_Gameplay_Core_AnimationQualityManager_TimeQualitySystem_FAnimationQualityTimerHandle_ *)&v115.m00;
		        *(_OWORD *)&v119.m_Index = *(_OWORD *)&v115.m01;
		        *(_QWORD *)&v115.m00 = 0LL;
		        *(_QWORD *)&v115.m20 = &v119;
		        try
		        {
		          v60 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_u32[0];
		          while ( Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<Beyond::Gameplay::Core::AnimationQualityManager_TimeQualitySystem::FAnimationQualityTimerHandle>::MoveNext(
		                    &v119,
		                    MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<System::ValueTuple<int,float>>::MoveNext) )
		          {
		            startTime = v119.value.startTime;
		            *(float *)&value.m_HashMapData.m_Buffer = v119.value.startTime;
		            type = v119.value.type;
		            name = v119.value.type;
		            v54 = *(float *)&v5->fields._centerXs_k__BackingField.m_Buffer[4 * SLODWORD(v119.value.startTime)];
		            v55 = *(float *)&v5->fields._centerYs_k__BackingField.m_Buffer[4 * SLODWORD(v119.value.startTime)];
		            v56 = *(float *)&v5->fields._centerZs_k__BackingField.m_Buffer[4 * SLODWORD(v119.value.startTime)];
		            v111 = *(float *)&v5->fields._extentXs_k__BackingField.m_Buffer[4 * SLODWORD(v119.value.startTime)];
		            v110 = *(float *)&v5->fields._extentYs_k__BackingField.m_Buffer[4 * SLODWORD(v119.value.startTime)];
		            v112 = *(float *)&v5->fields._extentZs_k__BackingField.m_Buffer[4 * SLODWORD(v119.value.startTime)];
		            v57 = 1;
		            v102 = 1;
		            Unity::Collections::NativeArray_1_T_::ReadOnly<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::GetEnumerator(
		              (NativeArray_1_T_ReadOnly_T_Enumerator_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v114,
		              (NativeArray_1_T_ReadOnly_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v103,
		              MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::GetEnumerator);
		            v118.m_Array = *(NativeArray_1_T_ReadOnly_MagicaCloth_RestoreRotationConstraint_RotationData_ *)&v114.m00;
		            *(_OWORD *)&v118.m_Index = *(_OWORD *)&v114.m01;
		            *(_QWORD *)&v118.value.localPos.z = *(_QWORD *)&v114.m02;
		            *(_QWORD *)&v109.x = 0LL;
		            *(_QWORD *)&v109.z = &v118;
		            try
		            {
		              while ( Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<MagicaCloth::RestoreRotationConstraint::RotationData>::MoveNext(
		                        &v118,
		                        MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<UnityEngine::Vector4>::MoveNext) )
		              {
		                v58 = _mm_shuffle_ps((__m128)v118.value, (__m128)v118.value, 85).m128_f32[0];
		                v59 = _mm_shuffle_ps((__m128)v118.value, (__m128)v118.value, 170).m128_f32[0];
		                v57 &= (float)((float)((float)((float)((float)(v58 * v55)
		                                                     + (float)(*(float *)&v118.value.vertexIndex * v54))
		                                             + (float)(v59 * v56))
		                                     + _mm_shuffle_ps((__m128)v118.value, (__m128)v118.value, 255).m128_f32[0])
		                             - (float)((float)((float)(COERCE_FLOAT(LODWORD(v58) & v60) * v110)
		                                             + (float)(COERCE_FLOAT(*(_DWORD *)&v118.value.vertexIndex & v60) * v111))
		                                     + (float)(COERCE_FLOAT(LODWORD(v59) & v60) * v112))) <= 0.0;
		                v102 = v57;
		              }
		            }
		            catch ( Il2CppExceptionWrapper *v120 )
		            {
		              *(Il2CppExceptionWrapper *)&v109.x = (Il2CppExceptionWrapper)v120->ex;
		              if ( *(_QWORD *)&v109.x )
		                sub_18007E1E0(*(_QWORD *)&v109.x);
		              v4 = (Object *)camera;
		              v5 = this;
		              v28 = *(_OWORD *)&identityMatrix.m03;
		              v27 = *(_OWORD *)&identityMatrix.m02;
		              v26 = *(_OWORD *)&identityMatrix.m01;
		              v25 = *(_OWORD *)&identityMatrix.m00;
		              v30 = v105;
		              v60 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_u32[0];
		              startTime = *(float *)&value.m_HashMapData.m_Buffer;
		              type = name;
		              v57 = v102;
		            }
		            if ( v57 )
		            {
		              v61 = v30++;
		              v105 = v30;
		              v106.m_Buffer = (Void *)__PAIR64__(type, LODWORD(startTime));
		              *(_QWORD *)&v116.m_Buffer[8 * v61] = __PAIR64__(type, LODWORD(startTime));
		            }
		          }
		        }
		        catch ( Il2CppExceptionWrapper *v121 )
		        {
		          *(Il2CppExceptionWrapper *)&v115.m00 = (Il2CppExceptionWrapper)v121->ex;
		          if ( *(_QWORD *)&v115.m00 )
		            sub_18007E1E0(*(_QWORD *)&v115.m00);
		          v4 = (Object *)camera;
		          v5 = this;
		          v28 = *(_OWORD *)&identityMatrix.m03;
		          v27 = *(_OWORD *)&identityMatrix.m02;
		          v26 = *(_OWORD *)&identityMatrix.m01;
		          v25 = *(_OWORD *)&identityMatrix.m00;
		          v30 = v105;
		        }
		        Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		          &v103,
		          MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
		        if ( v30 )
		        {
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::CommandBufferPool);
		          value.m_HashMapData.m_Buffer = (UnsafeParallelHashMapData *)UnityEngine::Rendering::CommandBufferPool::Get(
		                                                                        (String *)"HGTerrainFeedback",
		                                                                        0LL);
		          m_perDrawBlock = v5->fields.m_vtRenderer;
		          if ( !m_perDrawBlock )
		            goto LABEL_53;
		          v106.m_Buffer = (Void *)HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackDepth(
		                                    m_perDrawBlock,
		                                    0LL);
		          Unity::Collections::NativeArray<UnityEngine::Rendering::AttachmentDescriptor>::NativeArray(
		            &v117,
		            2,
		            Allocator__Enum_Temp,
		            NativeArrayOptions__Enum_ClearMemory,
		            MethodInfo::Unity::Collections::NativeArray<UnityEngine::Rendering::AttachmentDescriptor>::NativeArray);
		          m_perDrawBlock = v5->fields.m_vtRenderer;
		          if ( !m_perDrawBlock )
		            goto LABEL_53;
		          gpuFeedbackColorDesc = HG::Rendering::Runtime::VirtualTextureRenderer::get_gpuFeedbackColorDesc(
		                                   m_perDrawBlock,
		                                   0LL);
		          v65 = *(_OWORD *)&gpuFeedbackColorDesc->m_LoadStoreTarget.m_Type;
		          v66 = *(_OWORD *)&gpuFeedbackColorDesc->m_LoadStoreTarget.m_BufferPointer;
		          v67 = *(_OWORD *)&gpuFeedbackColorDesc->m_LoadStoreTarget.m_DepthSlice;
		          v68 = *(_OWORD *)&gpuFeedbackColorDesc->m_ResolveTarget.m_InstanceID;
		          v69 = *(_OWORD *)&gpuFeedbackColorDesc->m_ResolveTarget.m_MipLevel;
		          m_ClearColor = gpuFeedbackColorDesc->m_ClearColor;
		          v71 = *(_QWORD *)&gpuFeedbackColorDesc->m_ClearDepth;
		          v72 = v117.m_Buffer;
		          *(_OWORD *)v117.m_Buffer = *(_OWORD *)&gpuFeedbackColorDesc->m_LoadAction;
		          *(_OWORD *)&v72[16] = v65;
		          *(_OWORD *)&v72[32] = v66;
		          *(_OWORD *)&v72[48] = v67;
		          *(_OWORD *)&v72[64] = v68;
		          *(_OWORD *)&v72[80] = v69;
		          *(Color *)&v72[96] = m_ClearColor;
		          *(_QWORD *)&v72[112] = v71;
		          m_perDrawBlock = v5->fields.m_vtRenderer;
		          if ( !m_perDrawBlock )
		            goto LABEL_53;
		          gpuFeedbackDepthDesc = HG::Rendering::Runtime::VirtualTextureRenderer::get_gpuFeedbackDepthDesc(
		                                   m_perDrawBlock,
		                                   0LL);
		          v74 = *(_OWORD *)&gpuFeedbackDepthDesc->m_LoadStoreTarget.m_Type;
		          v75 = *(_OWORD *)&gpuFeedbackDepthDesc->m_LoadStoreTarget.m_BufferPointer;
		          v76 = *(_OWORD *)&gpuFeedbackDepthDesc->m_LoadStoreTarget.m_DepthSlice;
		          v77 = *(_OWORD *)&gpuFeedbackDepthDesc->m_ResolveTarget.m_InstanceID;
		          v78 = *(_OWORD *)&gpuFeedbackDepthDesc->m_ResolveTarget.m_MipLevel;
		          v79 = gpuFeedbackDepthDesc->m_ClearColor;
		          v80 = *(_QWORD *)&gpuFeedbackDepthDesc->m_ClearDepth;
		          *(_OWORD *)&v72[120] = *(_OWORD *)&gpuFeedbackDepthDesc->m_LoadAction;
		          *(_OWORD *)&v72[136] = v74;
		          *(_OWORD *)&v72[152] = v75;
		          *(_OWORD *)&v72[168] = v76;
		          *(_OWORD *)&v72[184] = v77;
		          *(_OWORD *)&v72[200] = v78;
		          *(Color *)&v72[216] = v79;
		          *(_QWORD *)&v72[232] = v80;
		          v81 = v106.m_Buffer;
		          if ( !v106.m_Buffer )
		            goto LABEL_53;
		          v62 = *(_QWORD *)&v106.m_Buffer[16];
		          if ( !v62 )
		            goto LABEL_53;
		          name = sub_180002F70(5LL, v62);
		          v62 = *(_QWORD *)&v81[16];
		          if ( !v62 )
		            goto LABEL_53;
		          v82 = sub_180002F70(7LL, v62);
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          v103 = (NativeArray_1_UnityEngine_Vector4_)v117;
		          UnityEngine::Rendering::ScriptableRenderContext::BeginRenderPass(
		            &P2,
		            name,
		            v82,
		            1,
		            (NativeArray_1_UnityEngine_Rendering_AttachmentDescriptor_ *)&v103,
		            1,
		            0LL);
		          Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
		            (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v117,
		            MethodInfo::Unity::Collections::NativeArray<UnityEngine::Rendering::AttachmentDescriptor>::Dispose);
		          Unity::Collections::NativeArray<int>::NativeArray(
		            &v108,
		            1,
		            Allocator__Enum_Temp,
		            NativeArrayOptions__Enum_ClearMemory,
		            MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		          *(_DWORD *)v108.m_Buffer = 0;
		          v103 = (NativeArray_1_UnityEngine_Vector4_)v108;
		          UnityEngine::Rendering::ScriptableRenderContext::BeginSubPass(
		            &P2,
		            (NativeArray_1_System_Int32_ *)&v103,
		            0,
		            0LL);
		          Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		            (NativeArray_1_UnityEngine_Vector4_ *)&v108,
		            MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
		          m_terrainLitMaterial = v5->fields.m_terrainLitMaterial;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		          HGTerrainFeedbackViewProj = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainFeedbackViewProj;
		          *(_OWORD *)&identityMatrix.m00 = v25;
		          *(_OWORD *)&identityMatrix.m01 = v26;
		          *(_OWORD *)&identityMatrix.m02 = v27;
		          *(_OWORD *)&identityMatrix.m03 = v28;
		          GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(v122, &identityMatrix, 1, 0LL);
		          v86 = *(_OWORD *)&GPUProjectionMatrix->m00;
		          v87 = *(_OWORD *)&GPUProjectionMatrix->m01;
		          v88 = *(_OWORD *)&GPUProjectionMatrix->m02;
		          v89 = *(_OWORD *)&GPUProjectionMatrix->m03;
		          if ( !v4 )
		            goto LABEL_53;
		          identityMatrix = *UnityEngine::Camera::get_worldToCameraMatrix(v122, (Camera *)v4, 0LL);
		          *(_OWORD *)&v114.m00 = v86;
		          *(_OWORD *)&v114.m01 = v87;
		          *(_OWORD *)&v114.m02 = v88;
		          *(_OWORD *)&v114.m03 = v89;
		          v90 = UnityEngine::Matrix4x4::op_Multiply(v122, &v114, &identityMatrix, 0LL);
		          if ( !m_terrainLitMaterial )
		            goto LABEL_53;
		          identityMatrix = *v90;
		          UnityEngine::Material::SetMatrixImpl_Injected(
		            m_terrainLitMaterial,
		            HGTerrainFeedbackViewProj,
		            &identityMatrix,
		            0LL);
		          m_perDrawBlock = v5->fields.m_vtRenderer;
		          if ( !m_perDrawBlock )
		            goto LABEL_53;
		          currGPUFeedbackBuffer = HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackBuffer(
		                                    m_perDrawBlock,
		                                    0LL);
		          v92 = value.m_HashMapData.m_Buffer;
		          if ( !value.m_HashMapData.m_Buffer )
		            goto LABEL_53;
		          UnityEngine::Rendering::CommandBuffer::SetRandomWriteTarget(
		            (CommandBuffer *)value.m_HashMapData.m_Buffer,
		            1,
		            currGPUFeedbackBuffer,
		            0,
		            0LL);
		          value.m_HashMapData.m_Buffer = (UnsafeParallelHashMapData *)v30;
		          if ( v30 > 0 )
		          {
		            v93 = 0LL;
		            while ( 1 )
		            {
		              v94 = *(Void **)&v116.m_Buffer[8 * v93];
		              v106.m_Buffer = v94;
		              m_perDrawBlock = (VirtualTextureRenderer *)v5->fields.m_perDrawBlock;
		              if ( !m_perDrawBlock )
		                break;
		              UnityEngine::MaterialPropertyBlock::Clear((MaterialPropertyBlock *)m_perDrawBlock, 1, 0LL);
		              v95 = v5->fields.m_perDrawBlock;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		              name = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainChunkTransform;
		              m_perDrawBlock = (VirtualTextureRenderer *)v5->fields.m_chunkNodes;
		              if ( !m_perDrawBlock )
		                break;
		              v96 = (NativeArray_1_UnityEngine_Vector4_ *)sub_180444A00(m_perDrawBlock, (int)v94);
		              if ( !v95 )
		                break;
		              v103 = *v96;
		              UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(v95, name, (Vector4 *)&v103, 0LL);
		              v97 = v5->fields.m_perDrawBlock;
		              name = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_HGTerrainChunkParam0;
		              m_perDrawBlock = v5->fields.m_vtRenderer;
		              if ( !m_perDrawBlock )
		                break;
		              v108.m_Buffer = 0LL;
		              v108.m_Length = HIDWORD(v106.m_Buffer);
		              *(float *)&v108.m_AllocatorLabel = (float)HG::Rendering::Runtime::VirtualTextureRenderer::get_currFeedbackWidth(
		                                                          m_perDrawBlock,
		                                                          0LL);
		              if ( !v97 )
		                break;
		              v103 = (NativeArray_1_UnityEngine_Vector4_)v108;
		              UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(v97, name, (Vector4 *)&v103, 0LL);
		              chunkMesh = HG::Rendering::Runtime::HGTerrainRenderer::get_chunkMesh(v5, 0LL);
		              identityMatrix = TypeInfo::UnityEngine::Matrix4x4->static_fields->identityMatrix;
		              UnityEngine::Rendering::CommandBuffer::DrawMesh(
		                (CommandBuffer *)v92,
		                chunkMesh,
		                &identityMatrix,
		                v5->fields.m_terrainLitMaterial,
		                (int32_t)v94,
		                1,
		                v5->fields.m_perDrawBlock,
		                0LL);
		              if ( ++v93 >= (__int64)value.m_HashMapData.m_Buffer )
		                goto LABEL_41;
		            }
		LABEL_53:
		            sub_1800D8250(m_perDrawBlock, v62);
		          }
		LABEL_41:
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		          UnityEngine::Rendering::ScriptableRenderContext::ExecuteCommandBuffer(&P2, (CommandBuffer *)v92, 0LL);
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::CommandBufferPool);
		          UnityEngine::Rendering::CommandBufferPool::Release((CommandBuffer *)v92, 0LL);
		          UnityEngine::Rendering::ScriptableRenderContext::EndSubPass(&P2, 0LL);
		          UnityEngine::Rendering::ScriptableRenderContext::EndRenderPass(&P2, 0LL);
		          Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
		            (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v116,
		            MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::Dispose);
		          m_perDrawBlock = v5->fields.m_vtRenderer;
		          if ( !m_perDrawBlock )
		            goto LABEL_53;
		          HG::Rendering::Runtime::VirtualTextureRenderer::MarkCurrentGPUFeedbackBufferFilled(m_perDrawBlock, 1, 0LL);
		        }
		        else
		        {
		          Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
		            (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v116,
		            MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::Dispose);
		        }
		      }
		    }
		  }
		}
		
		public int GetSignificantLayerInfo(float worldPosX, float worldPosZ) => default; // 0x0000000189C15D74-0x0000000189C15E9C
		// Int32 GetSignificantLayerInfo(Single, Single)
		int32_t HG::Rendering::Runtime::HGTerrainRenderer::GetSignificantLayerInfo(
		        HGTerrainRenderer *this,
		        float worldPosX,
		        float worldPosZ,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGTerrainRuntimeResources *m_packedLayerInfoWidth; // rcx
		  HGTerrainRuntimeResources *m_runtimeResources; // rax
		  float x; // xmm6_4
		  int32_t m_X; // ebx
		  int v10; // eax
		  int v11; // ebx
		  int v12; // esi
		  Int32__Array *packedSignificantLayerInfo; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4022, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4022, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1416(Patch, (Object *)this, worldPosX, worldPosZ, 0LL);
		LABEL_9:
		    sub_1800D8260(m_packedLayerInfoWidth, v5);
		  }
		  m_runtimeResources = this->fields.m_runtimeResources;
		  if ( !m_runtimeResources )
		    goto LABEL_9;
		  x = m_runtimeResources->fields.terrainPos.x;
		  m_X = m_runtimeResources->fields.terrainSize.m_X;
		  sub_1800036A0(TypeInfo::System::Math);
		  v10 = sub_18301DE80((unsigned int)(int)(float)(worldPosX - x), 0LL, (unsigned int)(m_X - 1));
		  m_packedLayerInfoWidth = this->fields.m_runtimeResources;
		  v11 = v10;
		  if ( !m_packedLayerInfoWidth )
		    goto LABEL_9;
		  v12 = sub_18301DE80(
		          (unsigned int)(int)(float)(worldPosZ - m_packedLayerInfoWidth->fields.terrainPos.z),
		          0LL,
		          (unsigned int)(m_packedLayerInfoWidth->fields.terrainSize.m_Y - 1));
		  packedSignificantLayerInfo = HG::Rendering::Runtime::HGTerrainRenderer::get_packedSignificantLayerInfo(this, 0LL);
		  m_packedLayerInfoWidth = (HGTerrainRuntimeResources *)(unsigned int)this->fields.m_packedLayerInfoWidth;
		  if ( !packedSignificantLayerInfo )
		    goto LABEL_9;
		  v14 = (unsigned int)(v11 >> 31);
		  LODWORD(v14) = v11 % this->fields.m_packedLaneWidth;
		  v15 = (unsigned int)(v11 / this->fields.m_packedLaneWidth + v12 * (_DWORD)m_packedLayerInfoWidth);
		  if ( (unsigned int)v15 >= packedSignificantLayerInfo->max_length.size )
		    sub_1800D2AB0(v15, v14);
		  return (packedSignificantLayerInfo->vector[(int)v15] >> ((4 * v14) & 0x1F)) & 0xF;
		}
		
		public void Dispose() {} // 0x0000000189C15714-0x0000000189C15A74
		// Void Dispose()
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGTerrainRenderer::Dispose(HGTerrainRenderer *this, MethodInfo *method)
		{
		  HGTerrainRenderer *v2; // rbx
		  __int64 v3; // rdx
		  ComputeBuffer *m_perTerrainDataBuffer; // rcx
		  ComputeBuffer *m_perTerrainFrameDataBuffer; // rcx
		  Void *m_Buffer; // rcx
		  Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *m_fixedLevelRenderData; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 v11; // [rsp+0h] [rbp-E8h] BYREF
		  NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_ centerXs_k__BackingField; // [rsp+20h] [rbp-C8h] BYREF
		  NativeList_1_System_ValueTuple_2_Int32_Single_ value; // [rsp+30h] [rbp-B8h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_ v14; // [rsp+40h] [rbp-A8h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ v15; // [rsp+70h] [rbp-78h] BYREF
		  Il2CppExceptionWrapper *v16; // [rsp+A0h] [rbp-48h] BYREF
		  Il2CppExceptionWrapper *v17; // [rsp+A8h] [rbp-40h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32_Unity_Collections_NativeParallelHashMap_2_System_UInt32_Beyond_Gameplay_Core_DynamicScene_RuntimeAttachData_ v18; // [rsp+B0h] [rbp-38h] BYREF
		
		  v2 = this;
		  memset(&v14, 0, sizeof(v14));
		  if ( IFix::WrappersManagerImpl::IsPatched(4023, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4023, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v2, 0LL);
		  }
		  else
		  {
		    centerXs_k__BackingField = (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_)v2->fields._centerXs_k__BackingField;
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      &centerXs_k__BackingField,
		      MethodInfo::Unity::Collections::NativeArray<float>::Dispose);
		    centerXs_k__BackingField = (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_)v2->fields._centerYs_k__BackingField;
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      &centerXs_k__BackingField,
		      MethodInfo::Unity::Collections::NativeArray<float>::Dispose);
		    centerXs_k__BackingField = (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_)v2->fields._centerZs_k__BackingField;
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      &centerXs_k__BackingField,
		      MethodInfo::Unity::Collections::NativeArray<float>::Dispose);
		    centerXs_k__BackingField = (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_)v2->fields._extentXs_k__BackingField;
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      &centerXs_k__BackingField,
		      MethodInfo::Unity::Collections::NativeArray<float>::Dispose);
		    centerXs_k__BackingField = (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_)v2->fields._extentYs_k__BackingField;
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      &centerXs_k__BackingField,
		      MethodInfo::Unity::Collections::NativeArray<float>::Dispose);
		    centerXs_k__BackingField = (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_)v2->fields._extentZs_k__BackingField;
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      &centerXs_k__BackingField,
		      MethodInfo::Unity::Collections::NativeArray<float>::Dispose);
		    m_perTerrainDataBuffer = v2->fields.m_perTerrainDataBuffer;
		    if ( m_perTerrainDataBuffer )
		      UnityEngine::ComputeBuffer::Dispose(m_perTerrainDataBuffer, 0LL);
		    m_perTerrainFrameDataBuffer = v2->fields.m_perTerrainFrameDataBuffer;
		    if ( m_perTerrainFrameDataBuffer )
		      UnityEngine::ComputeBuffer::Dispose(m_perTerrainFrameDataBuffer, 0LL);
		    if ( !v2->fields.m_cameraRenderData )
		      sub_1800D8260(m_perTerrainFrameDataBuffer, v3);
		    System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::GetEnumerator(
		      &v15,
		      (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v2->fields.m_cameraRenderData,
		      MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::GetEnumerator);
		    v18 = (Dictionary_2_TKey_TValue_Enumerator_System_Int32_Unity_Collections_NativeParallelHashMap_2_System_UInt32_Beyond_Gameplay_Core_DynamicScene_RuntimeAttachData_)v15;
		    centerXs_k__BackingField.m_Buffer = 0LL;
		    *(_QWORD *)&centerXs_k__BackingField.m_Length = &v18;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,Unity::Collections::NativeParallelHashMap<unsigned int,Beyond::Gameplay::Core::DynamicScene::RuntimeAttachData>>::MoveNext(
		                &v18,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::MoveNext) )
		      {
		        value = (NativeList_1_System_ValueTuple_2_Int32_Single_)v18._current.value;
		        Unity::Collections::NativeList<System::ValueTuple<int,float>>::Dispose(
		          &value,
		          MethodInfo::Unity::Collections::NativeList<System::ValueTuple<int,float>>::Dispose);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v16 )
		    {
		      centerXs_k__BackingField.m_Buffer = (Void *)v16->ex;
		      m_Buffer = centerXs_k__BackingField.m_Buffer;
		      if ( centerXs_k__BackingField.m_Buffer )
		        sub_18007E1E0(centerXs_k__BackingField.m_Buffer);
		      v2 = this;
		    }
		    m_fixedLevelRenderData = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v2->fields.m_fixedLevelRenderData;
		    if ( !m_fixedLevelRenderData )
		      goto LABEL_27;
		    System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::GetEnumerator(
		      &v15,
		      m_fixedLevelRenderData,
		      MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::GetEnumerator);
		    v14 = (Dictionary_2_TKey_TValue_Enumerator_System_UInt16_Unity_Collections_NativeArray_1_System_ValueTuple_2_Int32_Single_)v15;
		    centerXs_k__BackingField.m_Buffer = 0LL;
		    *(_QWORD *)&centerXs_k__BackingField.m_Length = &v14;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::MoveNext(
		                &v14,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::MoveNext) )
		      {
		        value = (NativeList_1_System_ValueTuple_2_Int32_Single_)v14._current.value;
		        Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
		          (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&value,
		          MethodInfo::Unity::Collections::NativeArray<System::ValueTuple<int,float>>::Dispose);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v17 )
		    {
		      m_fixedLevelRenderData = (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)&v11;
		      centerXs_k__BackingField.m_Buffer = (Void *)v17->ex;
		      if ( centerXs_k__BackingField.m_Buffer )
		        sub_18007E1E0(centerXs_k__BackingField.m_Buffer);
		      v2 = this;
		    }
		    m_Buffer = (Void *)v2->fields.m_cameraRenderData;
		    if ( !m_Buffer
		      || (System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
		            (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)m_Buffer,
		            MethodInfo::System::Collections::Generic::Dictionary<int,Unity::Collections::NativeList<System::ValueTuple<int,float>>>::Clear),
		          (m_Buffer = (Void *)v2->fields.m_fixedLevelRenderData) == 0LL)
		      || (System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
		            (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)m_Buffer,
		            MethodInfo::System::Collections::Generic::Dictionary<unsigned short,Unity::Collections::NativeArray<System::ValueTuple<int,float>>>::Clear),
		          (m_Buffer = (Void *)v2->fields.m_vtRenderer) == 0LL) )
		    {
		LABEL_27:
		      sub_1800D8250(m_Buffer, m_fixedLevelRenderData);
		    }
		    HG::Rendering::Runtime::VirtualTextureRenderer::Dispose((VirtualTextureRenderer *)m_Buffer, 0LL);
		  }
		}
		
		public HGTerrainRuntimeResources GetRuntimeResources() => default; // 0x0000000189C15D24-0x0000000189C15D74
		// HGTerrainRuntimeResources GetRuntimeResources()
		HGTerrainRuntimeResources *HG::Rendering::Runtime::HGTerrainRenderer::GetRuntimeResources(
		        HGTerrainRenderer *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4025, 0LL) )
		    return this->fields.m_runtimeResources;
		  Patch = IFix::WrappersManagerImpl::GetPatch(4025, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1417(Patch, (Object *)this, 0LL);
		}
		
		public void SetVTMaxPagePerFrame(int pageCount) {} // 0x0000000189C18A70-0x0000000189C18AD4
		// Void SetVTMaxPagePerFrame(Int32)
		void HG::Rendering::Runtime::HGTerrainRenderer::SetVTMaxPagePerFrame(
		        HGTerrainRenderer *this,
		        int32_t pageCount,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  VirtualTextureRenderer *m_vtRenderer; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4026, 0LL) )
		  {
		    m_vtRenderer = this->fields.m_vtRenderer;
		    if ( m_vtRenderer )
		    {
		      m_vtRenderer->fields._vtMaxPagePerFrame_k__BackingField = pageCount;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4026, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_29 *)Patch, (Object *)this, pageCount, 0LL);
		}
		
	}
}
