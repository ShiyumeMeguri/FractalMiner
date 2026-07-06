using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class VirtualTextureRenderer : IDisposable
	{
		// (get) Token: 0x06001606 RID: 5638 RVA: 0x000025D2 File Offset: 0x000007D2
		public ComputeBuffer terrainBakeDataBuffer
		{
			[CompilerGenerated]
			get
			{
				// // ValueInput`1[UnityEngine.Vector4] get_port()
				// ValueInput_1_UnityEngine_Vector4_ *FlowCanvas::Nodes::RelayValueInput<UnityEngine::Vector4>::get_port(
				//         RelayValueInput_1_UnityEngine_Vector4_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._port_k__BackingField;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001607 RID: 5639 RVA: 0x000025D2 File Offset: 0x000007D2
		public Texture deformableControlMap
		{
			get
			{
				// // String get_propertyPath()
				// String *NodeCanvas::Framework::Variable<UnityEngine::Vector4>::get_propertyPath(
				//         Variable_1_UnityEngine_Vector4_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._propertyPath;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001608 RID: 5640 RVA: 0x000025D2 File Offset: 0x000007D2
		public Texture2D currIndirectTexture
		{
			get
			{
				// // Texture2D get_currIndirectTexture()
				// Texture2D *HG::Rendering::Runtime::VirtualTextureRenderer::get_currIndirectTexture(
				//         VirtualTextureRenderer *this,
				//         MethodInfo *method)
				// {
				//   Texture2D__Array *m_indirectTextures; // r9
				//   uint32_t m_frameCount; // r8d
				//   __int64 v4; // rdx
				//   unsigned int v5; // r8d
				// 
				//   m_indirectTextures = this.fields.m_indirectTextures;
				//   m_frameCount = this.fields.m_frameCount;
				//   if ( !m_indirectTextures )
				//     sub_180B536AC(this, method);
				//   v4 = m_frameCount / 3;
				//   v5 = m_frameCount % 3;
				//   if ( v5 >= m_indirectTextures.max_length.size )
				//     sub_180070270(this, v4);
				//   return m_indirectTextures.vector[v5];
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001609 RID: 5641 RVA: 0x000025D2 File Offset: 0x000007D2
		public ref AttachmentDescriptor gpuFeedbackDepthDesc
		{
			get
			{
				// // AttachmentDescriptor& get_gpuFeedbackDepthDesc()
				// AttachmentDescriptor *HG::Rendering::Runtime::VirtualTextureRenderer::get_gpuFeedbackDepthDesc(
				//         VirtualTextureRenderer *this,
				//         MethodInfo *method)
				// {
				//   return &this.fields.m_gpuFeedbackDepthDesc;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600160A RID: 5642 RVA: 0x000025D2 File Offset: 0x000007D2
		public ref AttachmentDescriptor gpuFeedbackColorDesc
		{
			get
			{
				// // AttachmentDescriptor& get_gpuFeedbackColorDesc()
				// AttachmentDescriptor *HG::Rendering::Runtime::VirtualTextureRenderer::get_gpuFeedbackColorDesc(
				//         VirtualTextureRenderer *this,
				//         MethodInfo *method)
				// {
				//   return &this.fields.m_gpuFeedbackColorDesc;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600160B RID: 5643 RVA: 0x000025D2 File Offset: 0x000007D2
		public ComputeBuffer currGPUFeedbackBuffer
		{
			get
			{
				// // ComputeBuffer get_currGPUFeedbackBuffer()
				// ComputeBuffer *HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackBuffer(
				//         VirtualTextureRenderer *this,
				//         MethodInfo *method)
				// {
				//   ComputeBuffer__Array *m_gpuFeedbackBuffers; // rdx
				//   __int64 v3; // rax
				// 
				//   m_gpuFeedbackBuffers = this.fields.m_gpuFeedbackBuffers;
				//   if ( !m_gpuFeedbackBuffers )
				//     sub_180B536AC(this, 0LL);
				//   v3 = this.fields.m_frameCount & 3;
				//   if ( (unsigned int)v3 >= m_gpuFeedbackBuffers.max_length.size )
				//     sub_180070270(this, m_gpuFeedbackBuffers);
				//   return m_gpuFeedbackBuffers.vector[v3];
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600160C RID: 5644 RVA: 0x000025D2 File Offset: 0x000007D2
		public ref NativeArray<uint> currGPUFeedbackData
		{
			get
			{
				// // NativeArray`1[System.UInt32]& get_currGPUFeedbackData()
				// NativeArray_1_System_UInt32_ *HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackData(
				//         VirtualTextureRenderer *this,
				//         MethodInfo *method)
				// {
				//   __int64 v3; // rcx
				//   NativeArray_1_System_UInt32___Array *m_gpuFeedbackData; // rdx
				//   __int64 v5; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( IFix::WrappersManagerImpl::IsPatched(3366, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3366, 0LL);
				//     if ( Patch )
				//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1194(Patch, (Object *)this, 0LL);
				// LABEL_7:
				//     sub_180B536AC(v3, m_gpuFeedbackData);
				//   }
				//   m_gpuFeedbackData = this.fields.m_gpuFeedbackData;
				//   if ( !m_gpuFeedbackData )
				//     goto LABEL_7;
				//   v5 = this.fields.m_frameCount & 3;
				//   if ( (unsigned int)v5 >= m_gpuFeedbackData.max_length.size )
				//     sub_180070270(v3, m_gpuFeedbackData);
				//   return &m_gpuFeedbackData.vector[v5];
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600160D RID: 5645 RVA: 0x000025D2 File Offset: 0x000007D2
		public ref AsyncGPUReadbackRequest currGPUFeedbackRequest
		{
			get
			{
				// // AsyncGPUReadbackRequest& get_currGPUFeedbackRequest()
				// AsyncGPUReadbackRequest *HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackRequest(
				//         VirtualTextureRenderer *this,
				//         MethodInfo *method)
				// {
				//   AsyncGPUReadbackRequest__Array *m_gpuFeedbackRequests; // rdx
				//   __int64 v3; // rax
				// 
				//   m_gpuFeedbackRequests = this.fields.m_gpuFeedbackRequests;
				//   if ( !m_gpuFeedbackRequests )
				//     sub_180B536AC(this, 0LL);
				//   v3 = this.fields.m_frameCount & 3;
				//   if ( (unsigned int)v3 >= m_gpuFeedbackRequests.max_length.size )
				//     sub_180070270(this, m_gpuFeedbackRequests);
				//   return &m_gpuFeedbackRequests.vector[v3];
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x0600160E RID: 5646 RVA: 0x000025D8 File Offset: 0x000007D8
		public bool currGPUFeedbackBufferFilled
		{
			get
			{
				// // Boolean get_currGPUFeedbackBufferFilled()
				// bool HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackBufferFilled(
				//         VirtualTextureRenderer *this,
				//         MethodInfo *method)
				// {
				//   Boolean__Array *m_gpuFeedbackBufferFilled; // rdx
				//   __int64 v3; // rax
				// 
				//   m_gpuFeedbackBufferFilled = this.fields.m_gpuFeedbackBufferFilled;
				//   if ( !m_gpuFeedbackBufferFilled )
				//     sub_180B536AC(this, 0LL);
				//   v3 = this.fields.m_frameCount & 3;
				//   if ( (unsigned int)v3 >= m_gpuFeedbackBufferFilled.max_length.size )
				//     sub_180070270(this, m_gpuFeedbackBufferFilled);
				//   return m_gpuFeedbackBufferFilled.vector[v3];
				// }
				// 
				return default(bool);
			}
		}

		// (get) Token: 0x0600160F RID: 5647 RVA: 0x000025D2 File Offset: 0x000007D2
		public RTHandle currGPUFeedbackDepth
		{
			get
			{
				// // Transform get_controllerMask()
				// Transform *Beyond::Input::InputManager::get_controllerMask(InputManager_2 *this, MethodInfo *method)
				// {
				//   return this.fields._controllerMask_k__BackingField;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001610 RID: 5648 RVA: 0x00002CC8 File Offset: 0x00000EC8
		public HGTerrainConfiguration.VTFeedbackMode feedbackMode
		{
			[CompilerGenerated]
			get
			{
				// // Int32 get_containedPointerIds()
				// int32_t UnityEngine::UIElements::VisualElement::get_containedPointerIds(VisualElement *this, MethodInfo *method)
				// {
				//   return this.fields._containedPointerIds_k__BackingField;
				// }
				// 
				return HGTerrainConfiguration.VTFeedbackMode.CPUPhysicsFeedback;
			}
		}

		// (get) Token: 0x06001611 RID: 5649 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector2 terrainToVirtual
		{
			[CompilerGenerated]
			get
			{
				// // Vector2 get_terrainToVirtual()
				// Vector2 HG::Rendering::Runtime::VirtualTextureRenderer::get_terrainToVirtual(
				//         VirtualTextureRenderer *this,
				//         MethodInfo *method)
				// {
				//   return (Vector2)_mm_unpacklo_ps(
				//                     (__m128)LODWORD(this.fields._terrainToVirtual_k__BackingField.x),
				//                     (__m128)LODWORD(this.fields._terrainToVirtual_k__BackingField.y)).m128_u64[0];
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06001612 RID: 5650 RVA: 0x00002608 File Offset: 0x00000808
		public int currFeedbackWidth
		{
			get
			{
				// // Int32 get_currFeedbackWidth()
				// int32_t HG::Rendering::Runtime::VirtualTextureRenderer::get_currFeedbackWidth(
				//         VirtualTextureRenderer *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_feedbackWidth;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001613 RID: 5651 RVA: 0x00002608 File Offset: 0x00000808
		// (set) Token: 0x06001614 RID: 5652 RVA: 0x000025D0 File Offset: 0x000007D0
		public int vtMaxPagePerFrame
		{
			[CompilerGenerated]
			get
			{
				// // Int32 get_vtMaxPagePerFrame()
				// int32_t HG::Rendering::Runtime::VirtualTextureRenderer::get_vtMaxPagePerFrame(
				//         VirtualTextureRenderer *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._vtMaxPagePerFrame_k__BackingField;
				// }
				// 
				return 0;
			}
			[CompilerGenerated]
			set
			{
				// // Void set_vtMaxPagePerFrame(Int32)
				// void HG::Rendering::Runtime::VirtualTextureRenderer::set_vtMaxPagePerFrame(
				//         VirtualTextureRenderer *this,
				//         int32_t value,
				//         MethodInfo *method)
				// {
				//   this.fields._vtMaxPagePerFrame_k__BackingField = value;
				// }
				// 
			}
		}

		// (get) Token: 0x06001615 RID: 5653 RVA: 0x000025D2 File Offset: 0x000007D2
		// (set) Token: 0x06001616 RID: 5654 RVA: 0x000025D0 File Offset: 0x000007D0
		public Vector2 currentCenterPos
		{
			[CompilerGenerated]
			get
			{
				// // Vector2 get_currentCenterPos()
				// Vector2 HG::Rendering::Runtime::VirtualTextureRenderer::get_currentCenterPos(
				//         VirtualTextureRenderer *this,
				//         MethodInfo *method)
				// {
				//   return (Vector2)_mm_unpacklo_ps(
				//                     (__m128)LODWORD(this.fields._currentCenterPos_k__BackingField.x),
				//                     (__m128)LODWORD(this.fields._currentCenterPos_k__BackingField.y)).m128_u64[0];
				// }
				// 
				return null;
			}
			[CompilerGenerated]
			private set
			{
				// // Void set_currentCenterPos(Vector2)
				// void HG::Rendering::Runtime::VirtualTextureRenderer::set_currentCenterPos(
				//         VirtualTextureRenderer *this,
				//         Vector2 value,
				//         MethodInfo *method)
				// {
				//   this.fields._currentCenterPos_k__BackingField = value;
				// }
				// 
			}
		}

		public VirtualTextureRenderer(in TerrainResource terrainResource)
		{
			// // VirtualTextureRenderer(TerrainResource&)
			// void HG::Rendering::Runtime::VirtualTextureRenderer::VirtualTextureRenderer(
			//         VirtualTextureRenderer *this,
			//         TerrainResource *terrainResource,
			//         MethodInfo *method)
			// {
			//   HGCamera *v3; // r9
			//   __int64 v4; // r12
			//   HGTerrainRuntimeResources *runtimeResources; // rsi
			//   TerrainCollider *terrainCollider; // r9
			//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   unsigned __int64 m_splatIndexMap; // rdx
			//   __int64 m_vtBakeCS; // rcx
			//   PassConstructorID__Enum__Array *v13; // r8
			//   HGCamera *v14; // r9
			//   HGTerrainRuntimeResources_TextureResources *textures; // rax
			//   PassConstructorID__Enum__Array *v16; // r8
			//   HGCamera *v17; // r9
			//   HGTerrainRuntimeResources_TextureResources *v18; // rax
			//   PassConstructorID__Enum__Array *v19; // r8
			//   HGCamera *v20; // r9
			//   HGTerrainRuntimeResources_TextureResources *v21; // rax
			//   PassConstructorID__Enum__Array *v22; // r8
			//   HGCamera *v23; // r9
			//   HGTerrainRuntimeResources_TextureResources *v24; // rax
			//   PassConstructorID__Enum__Array *v25; // r8
			//   HGCamera *v26; // r9
			//   HGTerrainRuntimeResources_TextureResources *v27; // rax
			//   PassConstructorID__Enum__Array *v28; // r8
			//   HGCamera *v29; // r9
			//   HGTerrainRuntimeResources_TextureResources *v30; // rax
			//   PassConstructorID__Enum__Array *v31; // r8
			//   HGCamera *v32; // r9
			//   HGTerrainRuntimeResources_TextureResources *v33; // rax
			//   PassConstructorID__Enum__Array *v34; // r8
			//   HGCamera *v35; // r9
			//   HGTerrainRuntimeResources_TextureResources *v36; // rax
			//   PassConstructorID__Enum__Array *v37; // r8
			//   HGCamera *v38; // r9
			//   HGTerrainConfiguration *m_configuration; // rax
			//   HGTerrainConfiguration *v40; // rax
			//   bool v41; // al
			//   HGTerrainConfiguration *v42; // rax
			//   int32_t vtFeedbackMode; // eax
			//   HGTerrainRuntimeResources_ShaderResources *shaders; // rax
			//   int32_t Kernel; // eax
			//   ComputeShader *v46; // rdx
			//   __int64 v47; // xmm1_8
			//   HGRenderPathBase_HGRenderPathResources *v48; // rdx
			//   PassConstructorID__Enum__Array *v49; // r8
			//   HGCamera *v50; // r9
			//   ComputeShader *v51; // rdx
			//   __int64 v52; // xmm1_8
			//   HGRenderPathBase_HGRenderPathResources *v53; // rdx
			//   PassConstructorID__Enum__Array *v54; // r8
			//   HGCamera *v55; // r9
			//   RuntimePlatform__Enum platform; // eax
			//   PassConstructorID__Enum__Array *v57; // r8
			//   HGCamera *v58; // r9
			//   __int64 v59; // rax
			//   InvalidEnumArgumentException *v60; // rbx
			//   String *v61; // rax
			//   __int64 v62; // rax
			//   HGTerrainRuntimeResources_ShaderResources *v63; // rax
			//   ComputeShader *terrainBC3CompressCS; // rcx
			//   HGTerrainRuntimeResources_ShaderResources *v65; // rax
			//   float z; // eax
			//   float v67; // eax
			//   ComputeBuffer *v68; // rax
			//   ComputeBuffer *v69; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v70; // rdx
			//   PassConstructorID__Enum__Array *v71; // r8
			//   HGCamera *v72; // r9
			//   Vector4__Array *packedSplatInfo; // rax
			//   int v74; // ebx
			//   Void *m_Buffer; // r15
			//   Void *v76; // r14
			//   int v77; // eax
			//   int v78; // r14d
			//   int v79; // eax
			//   int v80; // ebx
			//   int v81; // eax
			//   int v82; // eax
			//   int v83; // r14d
			//   int v84; // eax
			//   int v85; // ebx
			//   int v86; // eax
			//   int v87; // eax
			//   int v88; // ebx
			//   unsigned int v89; // eax
			//   int v90; // ebx
			//   int v91; // eax
			//   int v92; // eax
			//   float m_Y; // xmm1_4
			//   __int128 v94; // xmm1
			//   float y; // xmm2_4
			//   HGTerrainConfiguration *v96; // rax
			//   HGTerrainConfiguration *v97; // rax
			//   int vtMinChunkSize; // r14d
			//   int32_t vtCacheSliceWidth; // eax
			//   int32_t v100; // r10d
			//   int32_t v101; // r9d
			//   int32_t v102; // eax
			//   int32_t v103; // eax
			//   int v104; // eax
			//   int v105; // ebx
			//   int v106; // eax
			//   float v107; // xmm4_4
			//   float v108; // xmm3_4
			//   float v109; // xmm4_4
			//   float v110; // xmm1_4
			//   MethodInfo *v111; // rdx
			//   float v112; // xmm4_4
			//   __int64 v113; // rdx
			//   __int64 v114; // rcx
			//   __int64 v115; // r8
			//   double v116; // xmm0_8
			//   HGTerrainConfiguration *v117; // r8
			//   int32_t v118; // r9d
			//   int32_t vtClipmapBaseOffset; // r8d
			//   int32_t v120; // ecx
			//   int32_t v121; // edx
			//   int32_t v122; // eax
			//   LRUCache *v123; // rax
			//   PassConstructorID__Enum__Array *v124; // r8
			//   HGCamera *v125; // r9
			//   Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *v126; // rax
			//   Dictionary_2_System_UInt32_System_Int32_ *v127; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v128; // rdx
			//   PassConstructorID__Enum__Array *v129; // r8
			//   HGCamera *v130; // r9
			//   List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *v131; // rax
			//   List_1_HG_Rendering_Runtime_VirtualTextureRenderer_GlobalUV_ *v132; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v133; // rdx
			//   PassConstructorID__Enum__Array *v134; // r8
			//   HGCamera *v135; // r9
			//   LowLevelList_1_System_Object_ *v136; // rax
			//   List_1_System_UInt32_ *v137; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v138; // rdx
			//   PassConstructorID__Enum__Array *v139; // r8
			//   HGCamera *v140; // r9
			//   __int64 v141; // r8
			//   __int64 v142; // r9
			//   HGRenderPathBase_HGRenderPathResources *v143; // rdx
			//   PassConstructorID__Enum__Array *v144; // r8
			//   HGCamera *v145; // r9
			//   int32_t i; // r14d
			//   Texture2D__Array *m_indirectTextures; // rax
			//   Texture2D__Array *v148; // r15
			//   int32_t m_indirectMaxWidth; // r12d
			//   Texture2D *v150; // rax
			//   Texture *v151; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v152; // rdx
			//   PassConstructorID__Enum__Array *v153; // r8
			//   HGCamera *v154; // r9
			//   Texture2DArray *decalNormalMROTexArray; // r9
			//   HGRenderPathBase_HGRenderPathResources *v156; // rdx
			//   PassConstructorID__Enum__Array *v157; // r8
			//   int32_t m_indirectMaxLevel; // ebx
			//   HGRenderPathBase_HGRenderPathResources *v159; // rdx
			//   PassConstructorID__Enum__Array *v160; // r8
			//   HGCamera *v161; // r9
			//   HGTerrainRuntimeResources_DecalPerInstanceData__Array *instanceData; // rax
			//   UInt32__Array *decalNodeKeys; // r14
			//   HGTerrainRuntimeResources_DecalIndices__Array *decalIndicesValues; // r15
			//   Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *v165; // rax
			//   Dictionary_2_System_UInt32_System_Int32__2 *v166; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v167; // rdx
			//   PassConstructorID__Enum__Array *v168; // r8
			//   HGCamera *v169; // r9
			//   __int64 v170; // r8
			//   __int64 v171; // r9
			//   unsigned int v172; // ebx
			//   UInt32__Array *blockNodeKeys; // rax
			//   UInt32__Array *v174; // r14
			//   HGTerrainRuntimeResources_BlockMasks__Array *blockMasksValues; // rsi
			//   Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *v176; // rax
			//   Dictionary_2_System_UInt32_System_UInt64__1 *v177; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v178; // rdx
			//   PassConstructorID__Enum__Array *v179; // r8
			//   HGCamera *v180; // r9
			//   unsigned int j; // ebx
			//   HGRenderPathBase_HGRenderPathResources *v182; // rdx
			//   PassConstructorID__Enum__Array *v183; // r8
			//   HGCamera *v184; // r9
			//   HGRenderPathBase_HGRenderPathResources *v185; // rdx
			//   PassConstructorID__Enum__Array *v186; // r8
			//   HGCamera *v187; // r9
			//   MethodInfo *methoda; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodu; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodb; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodc; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodd; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methode; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodf; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodg; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodh; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodi; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodj; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodk; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodv; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodl; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodw; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodm; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodn; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodo; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodp; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodx; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodq; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methody; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodr; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methods; // [rsp+28h] [rbp-69h]
			//   MethodInfo *methodt; // [rsp+28h] [rbp-69h]
			//   MethodInfo *v213; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v214; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v215; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v216; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v217; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v218; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v219; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v220; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v221; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v222; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v223; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v224; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v225; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v226; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v227; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v228; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v229; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v230; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v231; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v232; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v233; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v234; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v235; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v236; // [rsp+30h] [rbp-61h]
			//   MethodInfo *v237; // [rsp+30h] [rbp-61h]
			//   NativeArray_1_Unity_Mathematics_quaternion_ v238; // [rsp+38h] [rbp-59h] BYREF
			//   __int128 v239; // [rsp+48h] [rbp-49h] BYREF
			//   __int128 v240; // [rsp+58h] [rbp-39h] BYREF
			//   __int128 v241; // [rsp+68h] [rbp-29h] BYREF
			//   LocalKeyword v242; // [rsp+78h] [rbp-19h] BYREF
			//   LocalKeyword v243; // [rsp+98h] [rbp+7h] BYREF
			//   __int64 height; // [rsp+F8h] [rbp+67h]
			//   Vector2 heightb; // [rsp+F8h] [rbp+67h]
			//   int32_t heighta; // [rsp+F8h] [rbp+67h]
			// 
			//   v4 = 0LL;
			//   if ( !byte_18D919730 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Array::Fill<bool>);
			//     sub_18003C530(&TypeInfo::System::Boolean);
			//     sub_18003C530(&MethodInfo::UnityEngine::ComputeBuffer::SetData<UnityEngine::Vector4>);
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::UInt64 []>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::Int32 []>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Dictionary);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::UInt64 []>::Dictionary);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::Int32 []>::Dictionary);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<unsigned int,int>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<unsigned int,System::UInt64 []>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<unsigned int,System::Int32 []>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LRUCache);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<unsigned int>::List);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<unsigned int>);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//     sub_18003C530(&TypeInfo::UnityEngine::Texture2D);
			//     sub_18003C530(&TypeInfo::UnityEngine::Texture2D);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector4);
			//     sub_18003C530(&off_18D519330);
			//     sub_18003C530(&off_18D4F3AD8);
			//     sub_18003C530(&off_18D519340);
			//     byte_18D919730 = 1;
			//   }
			//   *(_WORD *)&this.fields.m_needVTTexturesSetup = 257;
			//   runtimeResources = terrainResource.runtimeResources;
			//   this.fields.m_configuration = terrainResource.configuration;
			//   v238 = 0LL;
			//   this.fields.m_frameCount = 0;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields,
			//     (HGRenderPathBase_HGRenderPathResources *)terrainResource,
			//     (PassConstructorID__Enum__Array *)method,
			//     v3,
			//     methoda,
			//     v213);
			//   terrainCollider = terrainResource.terrainCollider;
			//   this.fields.m_collider = terrainCollider;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_collider, v9, v10, (HGCamera *)terrainCollider, methodu, v214);
			//   if ( !runtimeResources )
			//     goto LABEL_113;
			//   textures = runtimeResources.fields.textures;
			//   if ( !textures )
			//     goto LABEL_113;
			//   this.fields.m_splatIndexMap = textures.fields.splatIndexMap;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_splatIndexMap,
			//     (HGRenderPathBase_HGRenderPathResources *)m_splatIndexMap,
			//     v13,
			//     v14,
			//     methodb,
			//     v215);
			//   v18 = runtimeResources.fields.textures;
			//   if ( !v18 )
			//     goto LABEL_113;
			//   this.fields.m_splatControlMap = v18.fields.splatControlMap;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_splatControlMap,
			//     (HGRenderPathBase_HGRenderPathResources *)m_splatIndexMap,
			//     v16,
			//     v17,
			//     methodc,
			//     v216);
			//   v21 = runtimeResources.fields.textures;
			//   if ( !v21 )
			//     goto LABEL_113;
			//   this.fields.m_splatsDiffuseArray = v21.fields.terrainLayerDiffuseArray;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_splatsDiffuseArray,
			//     (HGRenderPathBase_HGRenderPathResources *)m_splatIndexMap,
			//     v19,
			//     v20,
			//     methodd,
			//     v217);
			//   v24 = runtimeResources.fields.textures;
			//   if ( !v24 )
			//     goto LABEL_113;
			//   this.fields.m_splatsNormalArray = v24.fields.terrainLayerNormalArray;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_splatsNormalArray,
			//     (HGRenderPathBase_HGRenderPathResources *)m_splatIndexMap,
			//     v22,
			//     v23,
			//     methode,
			//     v218);
			//   v27 = runtimeResources.fields.textures;
			//   if ( !v27 )
			//     goto LABEL_113;
			//   this.fields.m_terrainNormalMap = v27.fields.normalmap;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_terrainNormalMap,
			//     (HGRenderPathBase_HGRenderPathResources *)m_splatIndexMap,
			//     v25,
			//     v26,
			//     methodf,
			//     v219);
			//   v30 = runtimeResources.fields.textures;
			//   if ( !v30 )
			//     goto LABEL_113;
			//   this.fields.m_colorVariationTex = v30.fields.colorVariationTex;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_colorVariationTex,
			//     (HGRenderPathBase_HGRenderPathResources *)m_splatIndexMap,
			//     v28,
			//     v29,
			//     methodg,
			//     v220);
			//   v33 = runtimeResources.fields.textures;
			//   if ( !v33 )
			//     goto LABEL_113;
			//   this.fields.m_terrainHeightmap = v33.fields.heightmap;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_terrainHeightmap,
			//     (HGRenderPathBase_HGRenderPathResources *)m_splatIndexMap,
			//     v31,
			//     v32,
			//     methodh,
			//     v221);
			//   v36 = runtimeResources.fields.textures;
			//   if ( !v36 )
			//     goto LABEL_113;
			//   this.fields.m_deformableControlMap = v36.fields.deformableControlMap;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_deformableControlMap,
			//     (HGRenderPathBase_HGRenderPathResources *)m_splatIndexMap,
			//     v34,
			//     v35,
			//     methodi,
			//     v222);
			//   m_configuration = this.fields.m_configuration;
			//   if ( !m_configuration )
			//     goto LABEL_113;
			//   this.fields._vtMaxPagePerFrame_k__BackingField = m_configuration.fields.vtMaxPagePerFrame;
			//   v40 = this.fields.m_configuration;
			//   if ( !v40 )
			//     goto LABEL_113;
			//   if ( v40.fields.vtEnableCompression )
			//   {
			//     v41 = 1;
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     v41 = HG::Rendering::Runtime::HGTerrainUtils::ForceUsingCompression(0LL);
			//   }
			//   this.fields.m_enableCompression = v41;
			//   if ( v41 )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     if ( !HG::Rendering::Runtime::HGTerrainUtils::SupportBufferToImageCopy(0LL) )
			//       this.fields.m_enableCompression = 0;
			//   }
			//   v42 = this.fields.m_configuration;
			//   if ( !v42 )
			//     goto LABEL_113;
			//   vtFeedbackMode = v42.fields.vtFeedbackMode;
			//   this.fields._feedbackMode_k__BackingField = vtFeedbackMode;
			//   if ( vtFeedbackMode == 1 )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     if ( !HG::Rendering::Runtime::HGTerrainUtils::SupportSSBOWriteInGraphicShader(0LL) )
			//       this.fields._feedbackMode_k__BackingField = 0;
			//   }
			//   shaders = runtimeResources.fields.shaders;
			//   if ( !shaders
			//     || (this.fields.m_vtBakeCS = shaders.fields.terrainVTBakeCS,
			//         sub_1800054D0(
			//           (HGRenderPathScene *)&this.fields.m_vtBakeCS,
			//           (HGRenderPathBase_HGRenderPathResources *)m_splatIndexMap,
			//           v37,
			//           v38,
			//           methodj,
			//           v223),
			//         (m_vtBakeCS = (__int64)this.fields.m_vtBakeCS) == 0) )
			//   {
			//     sub_180B536AC(m_vtBakeCS, m_splatIndexMap);
			//   }
			//   Kernel = UnityEngine::ComputeShader::FindKernel((ComputeShader *)m_vtBakeCS, (String *)"KMain", 0LL);
			//   v46 = this.fields.m_vtBakeCS;
			//   this.fields.m_vtBakeMainKernel = Kernel;
			//   memset(&v243, 0, sizeof(v243));
			//   UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v243, v46, (String *)"_VT_COMPRESSION", 0LL);
			//   v47 = *(_QWORD *)&v243.m_Index;
			//   *(_OWORD *)&this.fields.m_enableCompressKeywordCS.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v243.m_SpaceInfo.m_KeywordSpace;
			//   *(_QWORD *)&this.fields.m_enableCompressKeywordCS.m_Index = v47;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_enableCompressKeywordCS.m_Name, v48, v49, v50, methodk, v224);
			//   v51 = this.fields.m_vtBakeCS;
			//   memset(&v242, 0, sizeof(v242));
			//   UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v242, v51, (String *)"_VT_TERRAIN_DECAL", 0LL);
			//   v52 = *(_QWORD *)&v242.m_Index;
			//   *(_OWORD *)&this.fields.m_enableTerrainDecalCS.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v242.m_SpaceInfo.m_KeywordSpace;
			//   *(_QWORD *)&this.fields.m_enableTerrainDecalCS.m_Index = v52;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_enableTerrainDecalCS.m_Name, v53, v54, v55, methodv, v225);
			//   if ( this.fields.m_enableCompression )
			//   {
			//     platform = UnityEngine::Application::get_platform(0LL);
			//     m_splatIndexMap = (unsigned int)platform;
			//     if ( platform )
			//     {
			//       m_splatIndexMap = (unsigned int)(platform - 1);
			//       if ( platform != RuntimePlatform__Enum_OSXPlayer )
			//       {
			//         m_splatIndexMap = (unsigned int)(platform - 2);
			//         if ( platform == RuntimePlatform__Enum_WindowsPlayer )
			//           goto LABEL_39;
			//         if ( platform == RuntimePlatform__Enum_OSXWebPlayer
			//           || platform == RuntimePlatform__Enum_OSXDashboardPlayer
			//           || platform == RuntimePlatform__Enum_WindowsWebPlayer
			//           || platform == (RuntimePlatform__Enum_OSXDashboardPlayer|RuntimePlatform__Enum_WindowsPlayer) )
			//         {
			//           goto LABEL_37;
			//         }
			//         m_splatIndexMap = (unsigned int)(platform - 7);
			//         if ( platform == RuntimePlatform__Enum_WindowsEditor )
			//         {
			// LABEL_39:
			//           v63 = runtimeResources.fields.shaders;
			//           if ( !v63 )
			//             goto LABEL_113;
			//           terrainBC3CompressCS = v63.fields.terrainBC3CompressCS;
			// LABEL_43:
			//           this.fields.m_vtCompressCS = terrainBC3CompressCS;
			//           sub_1800054D0(
			//             (HGRenderPathScene *)&this.fields.m_vtCompressCS,
			//             (HGRenderPathBase_HGRenderPathResources *)m_splatIndexMap,
			//             v57,
			//             v58,
			//             methodl,
			//             v226);
			//           m_vtBakeCS = (__int64)this.fields.m_vtCompressCS;
			//           if ( !m_vtBakeCS )
			//             goto LABEL_113;
			//           this.fields.m_vtCompressMainKernel = UnityEngine::ComputeShader::FindKernel(
			//                                                   (ComputeShader *)m_vtBakeCS,
			//                                                   (String *)"KMain",
			//                                                   0LL);
			//           goto LABEL_45;
			//         }
			//         if ( platform != RuntimePlatform__Enum_IPhonePlayer && platform != RuntimePlatform__Enum_Android )
			//         {
			// LABEL_37:
			//           v59 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//           v60 = (InvalidEnumArgumentException *)sub_180004920(v59);
			//           if ( v60 )
			//           {
			//             v61 = (String *)sub_18000F7E0(&off_18D515678);
			//             System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v60, v61, 0LL);
			//             v62 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VirtualTextureRenderer::VirtualTextureRenderer);
			//             sub_18000F7C0(v60, v62);
			//           }
			//           goto LABEL_113;
			//         }
			//       }
			//     }
			//     v65 = runtimeResources.fields.shaders;
			//     if ( !v65 )
			//       goto LABEL_113;
			//     terrainBC3CompressCS = v65.fields.terrainASTCCompressCS;
			//     goto LABEL_43;
			//   }
			// LABEL_45:
			//   z = runtimeResources.fields.heightmapScale.z;
			//   *(_QWORD *)&this.fields.m_heightmapScale.x = *(_QWORD *)&runtimeResources.fields.heightmapScale.x;
			//   this.fields.m_heightmapScale.z = z;
			//   this.fields.m_terrainSize = runtimeResources.fields.terrainSize;
			//   this.fields.m_lightmapScaleOffset = (Vector4)_mm_loadu_si128((const __m128i *)&runtimeResources.fields.lightmapScaleOffset);
			//   v67 = runtimeResources.fields.terrainPos.z;
			//   *(_QWORD *)&this.fields.m_terrainPos.x = *(_QWORD *)&runtimeResources.fields.terrainPos.x;
			//   this.fields.m_terrainPos.z = v67;
			//   Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//     &v238,
			//     325,
			//     Allocator__Enum_Temp,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//   v68 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//   v69 = v68;
			//   if ( !v68 )
			//     goto LABEL_113;
			//   UnityEngine::ComputeBuffer::ComputeBuffer(
			//     v68,
			//     v238.m_Length,
			//     16,
			//     ComputeBufferType__Enum_Constant,
			//     ComputeBufferMode__Enum_Immutable,
			//     0LL);
			//   this.fields._terrainBakeDataBuffer_k__BackingField = v69;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields._terrainBakeDataBuffer_k__BackingField, v70, v71, v72, methodw, v227);
			//   packedSplatInfo = runtimeResources.fields.terrainLayerData.packedSplatInfo;
			//   if ( !packedSplatInfo )
			//     goto LABEL_113;
			//   v74 = 0;
			//   m_Buffer = v238.m_Buffer;
			//   if ( packedSplatInfo.max_length.size > 0 )
			//   {
			//     v76 = v238.m_Buffer + 2048;
			//     height = packedSplatInfo.max_length.size;
			//     while ( 1 )
			//     {
			//       m_vtBakeCS = (__int64)runtimeResources.fields.terrainLayerData.packedSplatInfo;
			//       if ( !m_vtBakeCS )
			//         break;
			//       sub_180037190(m_vtBakeCS, &v239, v74);
			//       *(_OWORD *)&v76[-2048] = v239;
			//       m_vtBakeCS = (__int64)runtimeResources.fields.terrainLayerData.splatsST;
			//       if ( !m_vtBakeCS )
			//         break;
			//       sub_180037190(m_vtBakeCS, &v240, v74);
			//       *(_OWORD *)&v76[-1024] = v240;
			//       m_vtBakeCS = (__int64)runtimeResources.fields.terrainLayerData.diffuseRemapScale;
			//       if ( !m_vtBakeCS )
			//         break;
			//       sub_180037190(m_vtBakeCS, &v241, v74);
			//       *(_OWORD *)v76 = v241;
			//       m_vtBakeCS = (__int64)runtimeResources.fields.terrainLayerData.maskMapRemapOffset;
			//       if ( !m_vtBakeCS )
			//         break;
			//       sub_180037190(m_vtBakeCS, &v242, v74);
			//       *(_OWORD *)&v76[1024] = *(_OWORD *)&v242.m_SpaceInfo.m_KeywordSpace;
			//       m_vtBakeCS = (__int64)runtimeResources.fields.terrainLayerData.maskMapRemapScale;
			//       if ( !m_vtBakeCS )
			//         break;
			//       sub_180037190(m_vtBakeCS, &v243, v74++);
			//       ++v4;
			//       *(_OWORD *)&v76[2048] = *(_OWORD *)&v243.m_SpaceInfo.m_KeywordSpace;
			//       v76 += 16;
			//       if ( v4 >= height )
			//         goto LABEL_55;
			//     }
			// LABEL_113:
			//     sub_180B536AC(m_vtBakeCS, m_splatIndexMap);
			//   }
			// LABEL_55:
			//   m_splatIndexMap = (unsigned __int64)this.fields.m_splatIndexMap;
			//   if ( !m_splatIndexMap )
			//     goto LABEL_113;
			//   v77 = sub_18003ED00(5LL);
			//   m_splatIndexMap = (unsigned __int64)this.fields.m_splatIndexMap;
			//   v78 = v77;
			//   if ( !m_splatIndexMap )
			//     goto LABEL_113;
			//   v79 = sub_18003ED00(7LL);
			//   m_splatIndexMap = (unsigned __int64)this.fields.m_splatIndexMap;
			//   v80 = v79;
			//   if ( !m_splatIndexMap )
			//     goto LABEL_113;
			//   v81 = sub_18003ED00(5LL);
			//   m_splatIndexMap = (unsigned __int64)this.fields.m_splatIndexMap;
			//   if ( !m_splatIndexMap )
			//     goto LABEL_113;
			//   *(float *)&v239 = 1.0 / (float)v78;
			//   *((float *)&v239 + 1) = 1.0 / (float)v80;
			//   *((float *)&v239 + 2) = (float)v81;
			//   *((float *)&v239 + 3) = (float)(int)sub_18003ED00(7LL);
			//   *(_OWORD *)&m_Buffer[5120] = v239;
			//   m_splatIndexMap = (unsigned __int64)this.fields.m_splatControlMap;
			//   if ( !m_splatIndexMap )
			//     goto LABEL_113;
			//   v82 = sub_18003ED00(5LL);
			//   m_splatIndexMap = (unsigned __int64)this.fields.m_splatControlMap;
			//   v83 = v82;
			//   if ( !m_splatIndexMap )
			//     goto LABEL_113;
			//   v84 = sub_18003ED00(7LL);
			//   m_splatIndexMap = (unsigned __int64)this.fields.m_splatControlMap;
			//   v85 = v84;
			//   if ( !m_splatIndexMap )
			//     goto LABEL_113;
			//   v86 = sub_18003ED00(5LL);
			//   m_splatIndexMap = (unsigned __int64)this.fields.m_splatControlMap;
			//   if ( !m_splatIndexMap )
			//     goto LABEL_113;
			//   *(float *)&v239 = 1.0 / (float)v83;
			//   *((float *)&v239 + 1) = 1.0 / (float)v85;
			//   *((float *)&v239 + 2) = (float)v86;
			//   *((float *)&v239 + 3) = (float)(int)sub_18003ED00(7LL);
			//   *(_OWORD *)&m_Buffer[5136] = v239;
			//   m_splatIndexMap = (unsigned __int64)this.fields.m_splatControlMap;
			//   if ( !m_splatIndexMap )
			//     goto LABEL_113;
			//   v87 = sub_18003ED00(5LL);
			//   m_splatIndexMap = (unsigned __int64)this.fields.m_splatIndexMap;
			//   v88 = v87;
			//   if ( !m_splatIndexMap )
			//     goto LABEL_113;
			//   v89 = sub_18003ED00(5LL);
			//   m_vtBakeCS = v89;
			//   m_splatIndexMap = (unsigned __int64)this.fields.m_splatControlMap;
			//   v90 = v88 / (int)v89;
			//   if ( !m_splatIndexMap )
			//     goto LABEL_113;
			//   v91 = sub_18003ED00(7LL);
			//   m_splatIndexMap = (unsigned __int64)this.fields.m_splatIndexMap;
			//   if ( !m_splatIndexMap )
			//     goto LABEL_113;
			//   v92 = v91 / (int)sub_18003ED00(7LL);
			//   *(float *)&v239 = 0.5 / (float)v90;
			//   *((float *)&v239 + 1) = 0.5 / (float)v92;
			//   *((float *)&v239 + 2) = (float)((float)v90 - 0.5) / (float)v90;
			//   *((float *)&v239 + 3) = (float)((float)v92 - 0.5) / (float)v92;
			//   *(_OWORD *)&m_Buffer[5152] = v239;
			//   m_Y = (float)runtimeResources.fields.terrainSize.m_Y;
			//   *(float *)&v239 = (float)runtimeResources.fields.terrainSize.m_X;
			//   *((float *)&v239 + 1) = m_Y;
			//   *((_QWORD *)&v239 + 1) = COERCE_UNSIGNED_INT(HG::Rendering::Runtime::VirtualTextureRenderer::_CalculateHeightNormFactor(this, 0LL));
			//   v94 = v239;
			//   HIDWORD(v239) = 1132462080;
			//   *(_OWORD *)&m_Buffer[5168] = v94;
			//   y = runtimeResources.fields.terrainPos.y;
			//   *(float *)&v239 = runtimeResources.fields.terrainPos.x;
			//   DWORD2(v239) = LODWORD(runtimeResources.fields.terrainPos.z);
			//   *((float *)&v239 + 1) = y;
			//   *(_OWORD *)&m_Buffer[5184] = v239;
			//   m_vtBakeCS = (__int64)this.fields._terrainBakeDataBuffer_k__BackingField;
			//   if ( !m_vtBakeCS )
			//     goto LABEL_113;
			//   *(NativeArray_1_Unity_Mathematics_quaternion_ *)&v243.m_SpaceInfo.m_KeywordSpace = v238;
			//   sub_180831F20(m_vtBakeCS, &v243);
			//   Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//     (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&v238,
			//     MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
			//   v96 = this.fields.m_configuration;
			//   if ( !v96 )
			//     goto LABEL_113;
			//   this.fields.m_virtualTextureResolution = v96.fields.virtualTextureResolution;
			//   v97 = this.fields.m_configuration;
			//   if ( !v97 )
			//     goto LABEL_113;
			//   vtMinChunkSize = v97.fields.vtMinChunkSize;
			//   this.fields.m_vtBaseMipBias = v97.fields.vtBaseMipBias;
			//   m_vtBakeCS = (__int64)this.fields.m_configuration;
			//   vtCacheSliceWidth = v97.fields.vtCacheSliceWidth;
			//   this.fields.m_cacheSliceWidth = vtCacheSliceWidth;
			//   if ( !m_vtBakeCS )
			//     goto LABEL_113;
			//   v100 = *(_DWORD *)(m_vtBakeCS + 56);
			//   this.fields.m_cacheSliceHeight = v100;
			//   v101 = *(_DWORD *)(m_vtBakeCS + 48);
			//   m_vtBakeCS = 256LL;
			//   this.fields.m_cacheSliceCount = v101;
			//   v102 = vtCacheSliceWidth / 256;
			//   this.fields.m_cacheColNumPerSlice = v102;
			//   this.fields.m_cacheRowNumPerSlice = v100 / 256;
			//   v103 = v102 * (v100 / 256);
			//   this.fields.m_cachePageCountPerSlice = v103;
			//   this.fields.m_cachePageCountTotal = v101 * v103;
			//   m_splatIndexMap = (unsigned __int64)runtimeResources.fields.textures;
			//   if ( !m_splatIndexMap )
			//     goto LABEL_113;
			//   m_splatIndexMap = *(_QWORD *)(m_splatIndexMap + 32);
			//   if ( !m_splatIndexMap )
			//     goto LABEL_113;
			//   v104 = sub_18003ED00(5LL);
			//   m_splatIndexMap = (unsigned __int64)runtimeResources.fields.textures;
			//   v105 = v104;
			//   if ( !m_splatIndexMap )
			//     goto LABEL_113;
			//   m_splatIndexMap = *(_QWORD *)(m_splatIndexMap + 32);
			//   if ( !m_splatIndexMap )
			//     goto LABEL_113;
			//   v106 = sub_18003ED00(7LL);
			//   v107 = (float)this.fields.m_virtualTextureResolution * (float)vtMinChunkSize;
			//   v108 = v107 / (float)(v105 - 1);
			//   this.fields.m_virtualToTerrain.x = v108;
			//   v109 = v107 / (float)(v106 - 1);
			//   this.fields.m_virtualToTerrain.y = v109;
			//   this.fields._terrainToVirtual_k__BackingField.x = 1.0 / v108;
			//   this.fields._terrainToVirtual_k__BackingField.y = 1.0 / v109;
			//   v110 = -runtimeResources.fields.terrainPos.z;
			//   this.fields.m_terrainPosOffset.x = -runtimeResources.fields.terrainPos.x;
			//   this.fields.m_terrainPosOffset.y = v110;
			//   heightb = UnityEngine::Vector2Int::op_Implicit(runtimeResources.fields.terrainSize, v111);
			//   this.fields.m_worldToVirtual.x = (float)(1.0 / heightb.x) / v108;
			//   this.fields.m_worldToVirtual.y = (float)(1.0 / heightb.y) / v112;
			//   v116 = sub_182376F20(v114, v113, v115);
			//   v117 = this.fields.m_configuration;
			//   this.fields.m_indirectMaxLevel = (int)*(float *)&v116;
			//   v118 = (int)*(float *)&v116 - 1;
			//   this.fields.m_indirectBaseLevel = v118;
			//   if ( !v117 )
			//     goto LABEL_113;
			//   m_vtBakeCS = (__int64)this.fields.m_configuration;
			//   vtClipmapBaseOffset = v117.fields.vtClipmapBaseOffset;
			//   this.fields.m_indirectOffset = vtClipmapBaseOffset;
			//   if ( !m_vtBakeCS )
			//     goto LABEL_113;
			//   v120 = *(_DWORD *)(m_vtBakeCS + 64);
			//   this.fields.m_indirectMaxOffset = v120;
			//   v121 = 8 << (v120 & 0x1F);
			//   this.fields.m_indirectMaxWidth = v121;
			//   this.fields.m_indirectLevel = v118 - vtClipmapBaseOffset;
			//   this.fields.m_indirectMaxHeight = v121 * v118;
			//   v122 = 8 << (vtClipmapBaseOffset & 0x1F);
			//   this.fields.m_indirectWidth = v122;
			//   this.fields.m_indirectMaxArea = v121 * v121;
			//   this.fields.m_indirectHalfWidth = v122 / 2;
			//   this.fields.m_blockWidth = -1;
			//   this.fields.m_blockHeight = -1;
			//   this.fields.m_feedbackWidth = -1;
			//   this.fields.m_feedbackHeight = -1;
			//   this.fields._currentCenterPos_k__BackingField = 0LL;
			//   v123 = (LRUCache *)sub_180004920(TypeInfo::HG::Rendering::Runtime::LRUCache);
			//   if ( !v123 )
			//     goto LABEL_113;
			//   this.fields.m_lruCache = v123;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_lruCache,
			//     (HGRenderPathBase_HGRenderPathResources *)m_splatIndexMap,
			//     v124,
			//     v125,
			//     methodm,
			//     v228);
			//   m_vtBakeCS = (__int64)this.fields.m_lruCache;
			//   if ( !m_vtBakeCS )
			//     goto LABEL_113;
			//   HG::Rendering::Runtime::LRUCache::Reset((LRUCache *)m_vtBakeCS, this.fields.m_cachePageCountTotal, 0LL);
			//   v126 = (Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<unsigned int,int>);
			//   v127 = (Dictionary_2_System_UInt32_System_Int32_ *)v126;
			//   if ( !v126 )
			//     goto LABEL_113;
			//   System::Collections::Generic::Dictionary<unsigned int,Beyond::Gameplay::Audio::VoiceBarkProcessor_VoiceEchoBarker::FBarkInfo>::Dictionary(
			//     v126,
			//     MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Dictionary);
			//   this.fields.m_nodeCacheLut = v127;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_nodeCacheLut, v128, v129, v130, methodn, v229);
			//   v131 = (List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>);
			//   v132 = (List_1_HG_Rendering_Runtime_VirtualTextureRenderer_GlobalUV_ *)v131;
			//   if ( !v131 )
			//     goto LABEL_113;
			//   System::Collections::Generic::List<Cinemachine::TargetPositionCache_CacheEntry::RecordingItem>::List(
			//     v131,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::List);
			//   this.fields.m_globalUVs = v132;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_globalUVs, v133, v134, v135, methodo, v230);
			//   v136 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<unsigned int>);
			//   v137 = (List_1_System_UInt32_ *)v136;
			//   if ( !v136 )
			//     goto LABEL_113;
			//   System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
			//     v136,
			//     MethodInfo::System::Collections::Generic::List<unsigned int>::List);
			//   this.fields.m_renderQueue = v137;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_renderQueue, v138, v139, v140, methodp, v231);
			//   this.fields.m_indirectTextures = (Texture2D__Array *)il2cpp_array_new_specific_0(
			//                                                           TypeInfo::UnityEngine::Texture2D,
			//                                                           3LL,
			//                                                           v141,
			//                                                           v142);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_indirectTextures, v143, v144, v145, methodx, v232);
			//   for ( i = 0; ; ++i )
			//   {
			//     m_indirectTextures = this.fields.m_indirectTextures;
			//     if ( !m_indirectTextures )
			//       goto LABEL_113;
			//     if ( i >= m_indirectTextures.max_length.size )
			//       break;
			//     v148 = this.fields.m_indirectTextures;
			//     m_indirectMaxWidth = this.fields.m_indirectMaxWidth;
			//     heighta = this.fields.m_indirectMaxHeight;
			//     v150 = (Texture2D *)sub_180004920(TypeInfo::UnityEngine::Texture2D);
			//     v151 = (Texture *)v150;
			//     if ( !v150 )
			//       goto LABEL_113;
			//     UnityEngine::Texture2D::Texture2D(
			//       v150,
			//       m_indirectMaxWidth,
			//       heighta,
			//       GraphicsFormat__Enum_R8G8B8A8_UNorm,
			//       TextureCreationFlags__Enum_None,
			//       0LL);
			//     UnityEngine::Texture::set_filterMode(v151, FilterMode__Enum_Point, 0LL);
			//     UnityEngine::Texture::set_wrapMode(v151, TextureWrapMode__Enum_Clamp, 0LL);
			//     UnityEngine::Texture2D::set_requestedMipmapLevel((Texture2D *)v151, 0, 0LL);
			//     sub_180328478(v148, i, v151);
			//   }
			//   HG::Rendering::Runtime::VirtualTextureRenderer::_AllocatePhysicalCacheResources(this, 0LL);
			//   this.fields.m_decalDiffuseTexArray = terrainResource.decalDiffuseTexArray;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_decalDiffuseTexArray, v152, v153, v154, methodq, v233);
			//   decalNormalMROTexArray = terrainResource.decalNormalMROTexArray;
			//   this.fields.m_decalNormalMROTexArray = decalNormalMROTexArray;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_decalNormalMROTexArray,
			//     v156,
			//     v157,
			//     (HGCamera *)decalNormalMROTexArray,
			//     methody,
			//     v234);
			//   m_indirectMaxLevel = this.fields.m_indirectMaxLevel;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//   this.fields.m_decalMaxLevel = HG::Rendering::Runtime::HGTerrainUtils::GetTerrainDecalMaxLevel(
			//                                    m_indirectMaxLevel,
			//                                    0LL);
			//   if ( runtimeResources.fields.decalResources.instanceData )
			//   {
			//     instanceData = runtimeResources.fields.decalResources.instanceData;
			//     if ( instanceData.max_length.value )
			//     {
			//       this.fields.m_decalInstanceData = instanceData;
			//       sub_1800054D0((HGRenderPathScene *)&this.fields.m_decalInstanceData, v159, v160, v161, methodr, v235);
			//       decalNodeKeys = runtimeResources.fields.decalResources.decalNodeKeys;
			//       decalIndicesValues = runtimeResources.fields.decalResources.decalIndicesValues;
			//       v165 = (Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<unsigned int,System::Int32 []>);
			//       v166 = (Dictionary_2_System_UInt32_System_Int32__2 *)v165;
			//       if ( !v165 )
			//         goto LABEL_113;
			//       System::Collections::Generic::Dictionary<unsigned int,Beyond::Gameplay::Audio::VoiceBarkProcessor_VoiceEchoBarker::FBarkInfo>::Dictionary(
			//         v165,
			//         MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::Int32 []>::Dictionary);
			//       this.fields.m_decalNodeLut = v166;
			//       sub_1800054D0((HGRenderPathScene *)&this.fields.m_decalNodeLut, v167, v168, v169, methods, v236);
			//       v172 = 0;
			//       if ( !decalNodeKeys )
			//         goto LABEL_113;
			//       while ( (signed int)v172 < decalNodeKeys.max_length.size )
			//       {
			//         m_vtBakeCS = (__int64)this.fields.m_decalNodeLut;
			//         if ( v172 >= decalNodeKeys.max_length.size )
			//           goto LABEL_107;
			//         if ( !decalIndicesValues )
			//           goto LABEL_113;
			//         if ( v172 >= decalIndicesValues.max_length.size )
			// LABEL_107:
			//           sub_180070270(m_vtBakeCS, m_splatIndexMap);
			//         if ( !m_vtBakeCS )
			//           goto LABEL_113;
			//         System::Collections::Generic::Dictionary<unsigned int,System::Object>::Add(
			//           (Dictionary_2_System_UInt32_System_Object_ *)m_vtBakeCS,
			//           decalNodeKeys.vector[v172],
			//           (Object *)decalIndicesValues.vector[v172].decalIndices,
			//           MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::Int32 []>::Add);
			//         ++v172;
			//       }
			//       blockNodeKeys = runtimeResources.fields.decalResources.blockNodeKeys;
			//       if ( !blockNodeKeys )
			//         goto LABEL_113;
			//       if ( blockNodeKeys.max_length.value )
			//       {
			//         v174 = runtimeResources.fields.decalResources.blockNodeKeys;
			//         blockMasksValues = runtimeResources.fields.decalResources.blockMasksValues;
			//         v176 = (Dictionary_2_System_UInt32_Beyond_Gameplay_Audio_VoiceBarkProcessor_VoiceEchoBarker_FBarkInfo_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<unsigned int,System::UInt64 []>);
			//         v177 = (Dictionary_2_System_UInt32_System_UInt64__1 *)v176;
			//         if ( !v176 )
			//           goto LABEL_113;
			//         System::Collections::Generic::Dictionary<unsigned int,Beyond::Gameplay::Audio::VoiceBarkProcessor_VoiceEchoBarker::FBarkInfo>::Dictionary(
			//           v176,
			//           MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::UInt64 []>::Dictionary);
			//         this.fields.m_decalBlockMaskLut = v177;
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.m_decalBlockMaskLut, v178, v179, v180, methodt, v237);
			//         for ( j = 0; (signed int)j < v174.max_length.size; ++j )
			//         {
			//           m_vtBakeCS = (__int64)this.fields.m_decalBlockMaskLut;
			//           if ( j >= v174.max_length.size )
			//             goto LABEL_107;
			//           if ( !blockMasksValues )
			//             goto LABEL_113;
			//           if ( j >= blockMasksValues.max_length.size )
			//             goto LABEL_107;
			//           if ( !m_vtBakeCS )
			//             goto LABEL_113;
			//           System::Collections::Generic::Dictionary<unsigned int,System::Object>::Add(
			//             (Dictionary_2_System_UInt32_System_Object_ *)m_vtBakeCS,
			//             v174.vector[j],
			//             (Object *)blockMasksValues.vector[j].blockMasks,
			//             MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::UInt64 []>::Add);
			//         }
			//       }
			//       this.fields.m_decalInstanceInfo = (Vector4__Array *)il2cpp_array_new_specific_0(
			//                                                              TypeInfo::UnityEngine::Vector4,
			//                                                              16LL,
			//                                                              v170,
			//                                                              v171);
			//       sub_1800054D0((HGRenderPathScene *)&this.fields.m_decalInstanceInfo, v182, v183, v184, methodt, v237);
			//     }
			//   }
			//   if ( this.fields._feedbackMode_k__BackingField == 1 )
			//   {
			//     this.fields.m_gpuFeedbackBufferFilled = (Boolean__Array *)il2cpp_array_new_specific_0(
			//                                                                  TypeInfo::System::Boolean,
			//                                                                  4LL,
			//                                                                  v160,
			//                                                                  v161);
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_gpuFeedbackBufferFilled, v185, v186, v187, methodr, v235);
			//     System::Array::Fill<bool>(this.fields.m_gpuFeedbackBufferFilled, 0, MethodInfo::System::Array::Fill<bool>);
			//   }
			// }
			// 
		}

		private static uint _PackNodeKey(int level, int row, int col)
		{
			// // UInt32 _PackNodeKey(Int32, Int32, Int32)
			// uint32_t HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(
			//         int32_t level,
			//         int32_t row,
			//         int32_t col,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3371, 0LL) )
			//     return col | ((row | (level << 13)) << 13);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3371, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v10, v9);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1196(Patch, level, row, col, 0LL);
			// }
			// 
			return 0U;
		}

		private static ValueTuple<int, int, int> _UnpackNodeKey(uint nodeKey)
		{
			// // ValueTuple`3[Int32,Int32,Int32] _UnpackNodeKey(UInt32)
			// ValueTuple_3_Int32_Int32_Int32_ *HG::Rendering::Runtime::VirtualTextureRenderer::_UnpackNodeKey(
			//         ValueTuple_3_Int32_Int32_Int32_ *__return_ptr retstr,
			//         uint32_t nodeKey,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   ValueTuple_3_Int32_Int32_Int32_ *v8; // rax
			//   __int64 v9; // xmm0_8
			//   ValueTuple_3_Int32_Int32_Int32_ v11[2]; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D91972F )
			//   {
			//     sub_18003C530(&MethodInfo::System::ValueTuple<int,int,int>::ValueTuple);
			//     byte_18D91972F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3370, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3370, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1195(v11, Patch, nodeKey, 0LL);
			//     v9 = *(_QWORD *)&v8.Item1;
			//     LODWORD(v8) = v8.Item3;
			//     *(_QWORD *)&retstr.Item1 = v9;
			//     retstr.Item3 = (int)v8;
			//   }
			//   else
			//   {
			//     retstr.Item1 = nodeKey >> 26;
			//     retstr.Item2 = (nodeKey >> 13) & 0x1FFF;
			//     retstr.Item3 = nodeKey & 0x1FFF;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::VirtualTextureRenderer::Dispose(VirtualTextureRenderer *this, MethodInfo *method)
			// {
			//   int32_t v2; // edi
			//   __int64 v4; // rdx
			//   ComputeBuffer *terrainBakeDataBuffer_k__BackingField; // rcx
			//   int32_t feedbackMode_k__BackingField; // eax
			//   Texture2D__Array *m_indirectTextures; // rbp
			//   Object_1 *v8; // rbx
			//   Object_1 *m_decalDiffuseTexArray; // rbx
			//   __int64 v10; // rax
			//   InvalidEnumArgumentException *v11; // rbx
			//   String *v12; // rax
			//   __int64 v13; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   v2 = 0;
			//   if ( !byte_18D919731 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::get_IsCreated);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::get_IsCreated);
			//     byte_18D919731 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3396, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3396, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//       return;
			//     }
			//     goto LABEL_21;
			//   }
			//   terrainBakeDataBuffer_k__BackingField = this.fields._terrainBakeDataBuffer_k__BackingField;
			//   if ( !terrainBakeDataBuffer_k__BackingField )
			//     goto LABEL_21;
			//   UnityEngine::ComputeBuffer::Dispose(terrainBakeDataBuffer_k__BackingField, 0LL);
			//   if ( this.fields.m_feedbackJitterSeq.m_Buffer )
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&this.fields.m_feedbackJitterSeq,
			//       MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::Dispose);
			//   feedbackMode_k__BackingField = this.fields._feedbackMode_k__BackingField;
			//   if ( feedbackMode_k__BackingField )
			//   {
			//     if ( feedbackMode_k__BackingField == 1 )
			//     {
			//       HG::Rendering::Runtime::VirtualTextureRenderer::_DestroyGPUFeedbackResources(this, 0LL);
			//       goto LABEL_12;
			//     }
			//     v10 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//     v11 = (InvalidEnumArgumentException *)sub_180004920(v10);
			//     if ( v11 )
			//     {
			//       v12 = (String *)sub_18000F7E0(&off_18D519398);
			//       System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v11, v12, 0LL);
			//       v13 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VirtualTextureRenderer::Dispose);
			//       sub_18000F7C0(v11, v13);
			//     }
			// LABEL_21:
			//     sub_180B536AC(terrainBakeDataBuffer_k__BackingField, v4);
			//   }
			//   if ( this.fields.m_cpuJitterOffsets.m_Buffer )
			//     Unity::Collections::NativeArray<int>::Dispose(
			//       &this.fields.m_cpuJitterOffsets,
			//       MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			// LABEL_12:
			//   m_indirectTextures = this.fields.m_indirectTextures;
			//   if ( !m_indirectTextures )
			//     goto LABEL_21;
			//   while ( v2 < m_indirectTextures.max_length.size )
			//   {
			//     if ( (unsigned int)v2 >= m_indirectTextures.max_length.size )
			//       sub_180070270(terrainBakeDataBuffer_k__BackingField, v4);
			//     v8 = (Object_1 *)m_indirectTextures.vector[v2];
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     HG::Rendering::Runtime::HGUtils::Destroy(v8, 0LL);
			//     ++v2;
			//   }
			//   m_decalDiffuseTexArray = (Object_1 *)this.fields.m_decalDiffuseTexArray;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//   HG::Rendering::Runtime::HGUtils::Destroy(m_decalDiffuseTexArray, 0LL);
			//   HG::Rendering::Runtime::HGUtils::Destroy((Object_1 *)this.fields.m_decalNormalMROTexArray, 0LL);
			//   HG::Rendering::Runtime::VirtualTextureRenderer::_DestroyPhysicalCacheResources(this, 0LL);
			// }
			// 
		}

		public void PipelineUpdate(in Vector2 vtCenter)
		{
			// // Void PipelineUpdate(Vector2 ByRef)
			// // Hidden C++ exception states: #wind=5
			// void HG::Rendering::Runtime::VirtualTextureRenderer::PipelineUpdate(
			//         VirtualTextureRenderer *this,
			//         Vector2 *vtCenter,
			//         MethodInfo *method)
			// {
			//   VirtualTextureRenderer *v4; // rsi
			//   uint32_t v5; // eax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector2 v10; // r8
			//   Vector2 v11; // r9
			//   int32_t i; // ebx
			//   int v13; // r14d
			//   int32_t j; // r12d
			//   int32_t k; // r15d
			//   uint32_t v16; // eax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   Vector2 v21; // rax
			//   __int64 v22; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   int32_t feedbackMode_k__BackingField; // eax
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   __int64 v28; // r8
			//   __m128 v29; // xmm7
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   System::MathF *v32; // rcx
			//   int v33; // ebx
			//   float v34; // xmm1_4
			//   float v35; // xmm0_4
			//   int v36; // r15d
			//   float v37; // xmm6_4
			//   System::MathF *v38; // rcx
			//   System::MathF *v39; // rcx
			//   System::MathF *v40; // rcx
			//   __int64 v41; // rdx
			//   __int64 v42; // rcx
			//   __int64 v43; // r8
			//   char v44; // dl
			//   __int64 v45; // rcx
			//   int v46; // r8d
			//   int v47; // ecx
			//   int32_t v48; // ebx
			//   char v49; // cl
			//   int32_t v50; // r15d
			//   int32_t v51; // r14d
			//   uint32_t v52; // eax
			//   __int64 v53; // rdx
			//   Dictionary_2_System_UInt32_System_Int32_ *m_nodeCacheLut; // rcx
			//   __int64 v55; // rdx
			//   uint32_t m; // r14d
			//   Dictionary_2_System_UInt32_System_Int32_ *v57; // rcx
			//   ValueTuple_3_Int32_Int32_Int32_ *v58; // rax
			//   int Item3; // r8d
			//   AsyncGPUReadbackRequest *currGPUFeedbackRequest; // rax
			//   AsyncGPUReadbackRequest *v61; // rax
			//   NativeArray_1_System_UInt32_ *currGPUFeedbackData; // r8
			//   AllocatorManager_AllocatorHandle v63; // edx
			//   int32_t n; // r12d
			//   int32_t ii; // r15d
			//   int v66; // ebx
			//   int32_t v67; // r13d
			//   int32_t v68; // r14d
			//   int32_t v69; // ebx
			//   uint32_t v70; // eax
			//   __int64 v71; // rdx
			//   Dictionary_2_System_UInt32_System_Int32_ *m_renderQueue; // rcx
			//   int32_t v73; // r8d
			//   int32_t jj; // edx
			//   uint32_t v75; // eax
			//   uint32_t v76; // ebx
			//   ValueTuple_3_Int32_Int32_Int32_ *v77; // rax
			//   int v78; // r8d
			//   int v79; // ebx
			//   __int64 v80; // rdx
			//   uint32_t v81; // r14d
			//   Dictionary_2_System_UInt32_System_Int32_ *v82; // rcx
			//   __int64 v83; // rdx
			//   __int64 v84; // rcx
			//   List_1_System_UInt32_ *v85; // rax
			//   LRUCache *v86; // rcx
			//   unsigned __int64 v87; // rax
			//   int32_t v88; // ebx
			//   unsigned __int64 v89; // rdx
			//   Dictionary_2_System_UInt32_System_Single_ *v90; // rcx
			//   Dictionary_2_System_UInt32_System_Int32_ *v91; // rcx
			//   __int64 v92; // rdx
			//   List_1_System_UInt32_ *v93; // rcx
			//   LRUCache *m_lruCache; // rcx
			//   Texture2D *currIndirectTexture; // rax
			//   __int64 v96; // rdx
			//   LRUCache *v97; // rcx
			//   __int64 v98; // rbx
			//   __int64 v99; // rax
			//   __int64 v100; // rdx
			//   __int64 v101; // rcx
			//   InvalidEnumArgumentException *v102; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v104; // rdx
			//   __int64 v105; // rcx
			//   String *v106; // rax
			//   __int64 v107; // rax
			//   AllocatorManager_AllocatorHandle allocator; // [rsp+30h] [rbp-1A8h] BYREF
			//   int32_t idx[6]; // [rsp+38h] [rbp-1A0h] BYREF
			//   NativeArray_1_T_Enumerator_System_Int32_ v110; // [rsp+50h] [rbp-188h] BYREF
			//   NativeArray_1_T_ReadOnly_T_Enumerator_System_UInt32_ v111; // [rsp+70h] [rbp-168h] BYREF
			//   int32_t v112; // [rsp+90h] [rbp-148h] BYREF
			//   NativeArray_1_System_UInt32_ *v113; // [rsp+98h] [rbp-140h]
			//   NativeList_1_System_Int32_ v114; // [rsp+A8h] [rbp-130h] BYREF
			//   List_1_T_Enumerator_HG_Rendering_Runtime_VirtualTextureRenderer_GlobalUV_ v115; // [rsp+B8h] [rbp-120h] BYREF
			//   NativeArray_1_T_ReadOnly_T_Enumerator_System_UInt32_ v116; // [rsp+E0h] [rbp-F8h] BYREF
			//   NativeArray_1_System_Int32_ m_Array; // [rsp+F8h] [rbp-E0h] BYREF
			//   int32_t v118[2]; // [rsp+108h] [rbp-D0h]
			//   ValueTuple_3_Int32_Int32_Int32_ v119; // [rsp+110h] [rbp-C8h] BYREF
			//   Il2CppExceptionWrapper *v120; // [rsp+120h] [rbp-B8h] BYREF
			//   Il2CppExceptionWrapper *v121; // [rsp+128h] [rbp-B0h] BYREF
			//   Il2CppExceptionWrapper *v122; // [rsp+130h] [rbp-A8h] BYREF
			//   List_1_T_Enumerator_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ v123; // [rsp+138h] [rbp-A0h] BYREF
			//   __int64 *value; // [rsp+1F8h] [rbp+20h] BYREF
			// 
			//   v4 = this;
			//   if ( !byte_18D919732 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<unsigned int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<unsigned int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::MoveNext);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<unsigned int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<unsigned int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<unsigned int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<unsigned int>::get_Count);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<unsigned int>::Add);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<int>::Add);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<unsigned int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<unsigned int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<unsigned int>::NativeList);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<int>::NativeList);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeSortExtension::Sort<unsigned int>);
			//     byte_18D919732 = 1;
			//   }
			//   v110.m_Array = 0LL;
			//   v114 = 0LL;
			//   LODWORD(value) = 0;
			//   idx[0] = 0;
			//   memset(&v115, 0, sizeof(v115));
			//   memset(&v116, 0, sizeof(v116));
			//   v112 = 0;
			//   m_Array = 0LL;
			//   *(_QWORD *)v118 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3373, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3373, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v105, v104);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1198(Patch, (Object *)v4, vtCenter, 0LL);
			//     return;
			//   }
			//   ++v4.fields.m_frameCount;
			//   Unity::Collections::NativeList<unsigned int>::NativeList(
			//     (NativeList_1_System_UInt32_ *)&v110,
			//     (AllocatorManager_AllocatorHandle)2,
			//     MethodInfo::Unity::Collections::NativeList<unsigned int>::NativeList);
			//   Unity::Collections::NativeList<int>::NativeList(
			//     &v114,
			//     (AllocatorManager_AllocatorHandle)2,
			//     MethodInfo::Unity::Collections::NativeList<int>::NativeList);
			//   v5 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(0, 0, 0, 0LL);
			//   allocator = (AllocatorManager_AllocatorHandle)v5;
			//   if ( !v4.fields.m_nodeCacheLut )
			//     sub_180B536AC(v7, v6);
			//   if ( System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue(
			//          v4.fields.m_nodeCacheLut,
			//          v5,
			//          (int32_t *)&value,
			//          MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue) )
			//   {
			//     if ( !v4.fields.m_lruCache )
			//       sub_180B536AC(v9, v8);
			//     HG::Rendering::Runtime::LRUCache::Lock(v4.fields.m_lruCache, (int32_t)value, 0LL);
			//     Unity::Collections::NativeList<int>::Add(
			//       &v114,
			//       (int32_t *)&value,
			//       MethodInfo::Unity::Collections::NativeList<int>::Add);
			//   }
			//   else
			//   {
			//     Unity::Collections::NativeList<unsigned int>::Add(
			//       (NativeList_1_System_UInt32_ *)&v110,
			//       (uint32_t *)&allocator.Index,
			//       MethodInfo::Unity::Collections::NativeList<unsigned int>::Add);
			//   }
			//   for ( i = 1; i < 3; ++i )
			//   {
			//     v13 = 1 << (i & 0x1F);
			//     for ( j = 0; j < v13; ++j )
			//     {
			//       for ( k = 0; k < v13; ++k )
			//       {
			//         v16 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(i, j, k, 0LL);
			//         if ( !v4.fields.m_nodeCacheLut )
			//           sub_180B536AC(v18, v17);
			//         if ( System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue(
			//                v4.fields.m_nodeCacheLut,
			//                v16,
			//                idx,
			//                MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue) )
			//         {
			//           if ( !v4.fields.m_lruCache )
			//             sub_180B536AC(v20, v19);
			//           HG::Rendering::Runtime::LRUCache::Lock(v4.fields.m_lruCache, idx[0], 0LL);
			//           Unity::Collections::NativeList<int>::Add(&v114, idx, MethodInfo::Unity::Collections::NativeList<int>::Add);
			//         }
			//       }
			//     }
			//   }
			//   v21 = sub_1842BE4B8(
			//           (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)LODWORD(vtCenter.x), (__m128)LODWORD(vtCenter.y)),
			//           (Vector2)*(_OWORD *)&_mm_unpacklo_ps(
			//                                  (__m128)LODWORD(v4.fields.m_terrainPosOffset.x),
			//                                  (__m128)LODWORD(v4.fields.m_terrainPosOffset.y)),
			//           v10,
			//           v11);
			//   v22 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_184D038DC)(
			//           v21,
			//           _mm_unpacklo_ps(
			//             (__m128)LODWORD(v4.fields.m_worldToVirtual.x),
			//             (__m128)LODWORD(v4.fields.m_worldToVirtual.y)).m128_u64[0]);
			//   value = (__int64 *)sub_182C9F010(v22);
			//   v4.fields._currentCenterPos_k__BackingField = (Vector2)value;
			//   feedbackMode_k__BackingField = v4.fields._feedbackMode_k__BackingField;
			//   if ( feedbackMode_k__BackingField )
			//   {
			//     if ( feedbackMode_k__BackingField != 1 )
			//     {
			//       v98 = sub_18003C530(&TypeInfo::System::ArgumentException);
			//       if ( (*(_BYTE *)(v98 + 312) & 2) == 0 )
			//       {
			//         value = &qword_18CDB0B30;
			//         sub_1802924D0(&qword_18CDB0B30);
			//         sub_180060090(v98, &value);
			//         sub_180292530(value);
			//       }
			//       if ( *(_QWORD *)(v98 + 96) && (*(_BYTE *)(v98 + 312) & 8) != 0 )
			//         v98 = *(_QWORD *)(v98 + 64);
			//       if ( (*(_BYTE *)(v98 + 312) & 0x20) != 0 )
			//       {
			//         v101 = *(unsigned int *)(v98 + 248);
			//         if ( *(_QWORD *)(v98 + 8) )
			//           v99 = sub_180004F80(v101, v98);
			//         else
			//           v99 = sub_180005D40(v101, v98);
			//       }
			//       else
			//       {
			//         v99 = sub_180005FB0(v98);
			//       }
			//       v102 = (InvalidEnumArgumentException *)v99;
			//       if ( (*(_BYTE *)(v98 + 313) & 2) != 0 )
			//         sub_18002E8C0(v99, (unsigned int)sub_18007DC30, 0, (unsigned int)&v112, (__int64)&value);
			//       if ( (dword_18D8F6F50 & 0x80u) != 0 )
			//         sub_1802DAEC4(v102, v98);
			//       il2cpp_runtime_class_init_0(v98, v100);
			//       if ( v102 )
			//       {
			//         v106 = (String *)sub_18003C530(&off_18D519460);
			//         System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v102, v106, 0LL);
			//         v107 = sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VirtualTextureRenderer::PipelineUpdate);
			//         sub_18000F7C0(v102, v107);
			//       }
			//       goto LABEL_127;
			//     }
			//     goto LABEL_48;
			//   }
			//   if ( !v4.fields.m_globalUVs )
			//     sub_180B536AC(v24, v23);
			//   System::Collections::Generic::List<Beyond::UI::UIText_RichTextAnalyzer::RichTextParam>::GetEnumerator(
			//     &v123,
			//     (List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *)v4.fields.m_globalUVs,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::GetEnumerator);
			//   *(_OWORD *)&v115._list = *(_OWORD *)&v123._list;
			//   *(_OWORD *)&v115._current.current.x = *(_OWORD *)&v123._current.richTextTagType;
			//   v115._current.dUVdy = (Vector2)v123._current.value.stringValue;
			//   v111.m_Array.m_Buffer = 0LL;
			//   *(_QWORD *)&v111.m_Array.m_Length = &v115;
			//   try
			//   {
			//     while ( System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::MoveNext(
			//               &v115,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::MoveNext) )
			//     {
			//       v29 = *(__m128 *)&v115._current.current.x;
			//       sub_182376F20(v27, v26, v28);
			//       v33 = sub_1825C6750(v31, v30);
			//       v34 = (float)v4.fields.m_virtualTextureResolution - 1.0;
			//       v35 = (float)v4.fields.m_virtualTextureResolution * _mm_shuffle_ps(v29, v29, 85).m128_f32[0];
			//       if ( v35 < 0.0 )
			//       {
			//         v35 = 0.0;
			//       }
			//       else if ( v35 > v34 )
			//       {
			//         v35 = (float)v4.fields.m_virtualTextureResolution - 1.0;
			//       }
			//       v36 = (int)v35;
			//       v37 = (float)v4.fields.m_virtualTextureResolution * v29.m128_f32[0];
			//       if ( v37 < 0.0 )
			//       {
			//         v37 = 0.0;
			//       }
			//       else if ( v37 > (float)((float)v4.fields.m_virtualTextureResolution - 1.0) )
			//       {
			//         v37 = (float)v4.fields.m_virtualTextureResolution - 1.0;
			//       }
			//       System::MathF::Floor(v32, v34);
			//       System::MathF::Floor(v38, v34);
			//       System::MathF::Floor(v39, v34);
			//       System::MathF::Floor(v40, v34);
			//       sub_182376F20(v42, v41, v43);
			//       v47 = sub_182592070(v45, v44, v46) + 1;
			//       if ( v33 > v47 )
			//         v47 = v33;
			//       if ( v47 < 0 )
			//       {
			//         v47 = 0;
			//       }
			//       else if ( v47 > v4.fields.m_indirectLevel - 1 )
			//       {
			//         v47 = v4.fields.m_indirectLevel - 1;
			//       }
			//       v48 = v4.fields.m_indirectMaxLevel - v47;
			//       v49 = v47 & 0x1F;
			//       v50 = v36 >> v49;
			//       v51 = (int)v37 >> v49;
			//       v52 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(v48, v50, v51, 0LL);
			//       LODWORD(value) = v52;
			//       m_nodeCacheLut = v4.fields.m_nodeCacheLut;
			//       if ( !m_nodeCacheLut )
			//         sub_1802DC2C8(0LL, v53);
			//       if ( !System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey(
			//               m_nodeCacheLut,
			//               v52,
			//               MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey) )
			//       {
			//         for ( m = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(v48 - 1, v50 >> 1, v51 >> 1, 0LL);
			//               ;
			//               m = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(idx[0] - 1, idx[1] >> 1, Item3 >> 1, 0LL) )
			//         {
			//           v57 = v4.fields.m_nodeCacheLut;
			//           if ( !v57 )
			//             sub_1802DC2C8(0LL, v55);
			//           if ( System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey(
			//                  v57,
			//                  m,
			//                  MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey)
			//             || v48 <= 1 )
			//           {
			//             break;
			//           }
			//           LODWORD(value) = m;
			//           v58 = HG::Rendering::Runtime::VirtualTextureRenderer::_UnpackNodeKey(&v119, m, 0LL);
			//           *(_QWORD *)idx = *(_QWORD *)&v58.Item1;
			//           Item3 = v58.Item3;
			//           v48 = idx[0];
			//           v113 = *(NativeArray_1_System_UInt32_ **)idx;
			//         }
			//       }
			//       Unity::Collections::NativeList<unsigned int>::Add(
			//         (NativeList_1_System_UInt32_ *)&v110,
			//         (uint32_t *)&value,
			//         MethodInfo::Unity::Collections::NativeList<unsigned int>::Add);
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v120 )
			//   {
			//     v111.m_Array.m_Buffer = (Void *)v120.ex;
			//     if ( v111.m_Array.m_Buffer )
			//       sub_18000F780(v111.m_Array.m_Buffer);
			//     v4 = this;
			// LABEL_48:
			//     if ( HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackBufferFilled(v4, 0LL) )
			//     {
			//       HG::Rendering::Runtime::VirtualTextureRenderer::MarkCurrentGPUFeedbackBufferFilled(v4, 0, 0LL);
			//       currGPUFeedbackRequest = HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackRequest(v4, 0LL);
			//       if ( !UnityEngine::Rendering::AsyncGPUReadbackRequest::IsDone_Injected(currGPUFeedbackRequest, 0LL) )
			//       {
			//         v61 = HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackRequest(v4, 0LL);
			//         UnityEngine::Rendering::AsyncGPUReadbackRequest::WaitForCompletion_Injected(v61, 0LL);
			//       }
			//       currGPUFeedbackData = HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackData(v4, 0LL);
			//       *(_QWORD *)idx = currGPUFeedbackData;
			//       v63 = 0;
			//       for ( n = 0; n < v4.fields.m_feedbackHeight; ++n )
			//       {
			//         for ( ii = 0; ii < v4.fields.m_feedbackWidth; ++ii )
			//         {
			//           v66 = *(_DWORD *)&currGPUFeedbackData.m_Buffer[4 * ii + 4 * n * v4.fields.m_feedbackWidth];
			//           if ( v63 != v66 )
			//           {
			//             v63 = *(AllocatorManager_AllocatorHandle *)&currGPUFeedbackData.m_Buffer[4 * ii
			//                                                                                     + 4 * n * v4.fields.m_feedbackWidth];
			//             allocator = v63;
			//             if ( v66 < 0 )
			//             {
			//               v67 = v4.fields.m_indirectMaxLevel - (HIBYTE(v66) & 0xF);
			//               v68 = (int)(((unsigned int)v66 >> 12) & 0xFFF) >> (HIBYTE(v66) & 0xF);
			//               v69 = (v66 & 0xFFF) >> (HIBYTE(v66) & 0xF);
			//               v70 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(v67, v68, v69, 0LL);
			//               LODWORD(value) = v70;
			//               m_renderQueue = v4.fields.m_nodeCacheLut;
			//               if ( !m_renderQueue )
			//                 goto LABEL_127;
			//               if ( !System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey(
			//                       m_renderQueue,
			//                       v70,
			//                       MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey) )
			//               {
			//                 v73 = v69 >> 1;
			//                 for ( jj = v68 >> 1; ; jj = SHIDWORD(v113) >> 1 )
			//                 {
			//                   v75 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(v67 - 1, jj, v73, 0LL);
			//                   v76 = v75;
			//                   m_renderQueue = v4.fields.m_nodeCacheLut;
			//                   if ( !m_renderQueue )
			//                     break;
			//                   if ( System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey(
			//                          m_renderQueue,
			//                          v75,
			//                          MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::ContainsKey)
			//                     || v67 <= 1 )
			//                   {
			//                     goto LABEL_62;
			//                   }
			//                   LODWORD(value) = v76;
			//                   v77 = HG::Rendering::Runtime::VirtualTextureRenderer::_UnpackNodeKey(
			//                           (ValueTuple_3_Int32_Int32_Int32_ *)&v111,
			//                           v76,
			//                           0LL);
			//                   v113 = *(NativeArray_1_System_UInt32_ **)&v77.Item1;
			//                   v78 = v77.Item3;
			//                   v67 = (int)v113;
			//                   *(_QWORD *)&v119.Item1 = v113;
			//                   v73 = v78 >> 1;
			//                 }
			// LABEL_127:
			//                 sub_1802DC2C8(m_renderQueue, v71);
			//               }
			// LABEL_62:
			//               Unity::Collections::NativeList<unsigned int>::Add(
			//                 (NativeList_1_System_UInt32_ *)&v110,
			//                 (uint32_t *)&value,
			//                 MethodInfo::Unity::Collections::NativeList<unsigned int>::Add);
			//               v63 = allocator;
			//               currGPUFeedbackData = *(NativeArray_1_System_UInt32_ **)idx;
			//             }
			//           }
			//         }
			//       }
			//     }
			//   }
			//   v111.m_Array = (NativeArray_1_T_ReadOnly_System_UInt32_)v110.m_Array;
			//   Unity::Collections::NativeSortExtension::Sort<unsigned int>(
			//     (NativeList_1_System_UInt32_ *)&v111,
			//     MethodInfo::Unity::Collections::NativeSortExtension::Sort<unsigned int>);
			//   m_renderQueue = (Dictionary_2_System_UInt32_System_Int32_ *)v4.fields.m_renderQueue;
			//   if ( !m_renderQueue )
			//     goto LABEL_127;
			//   ++HIDWORD(m_renderQueue.fields._entries);
			//   LODWORD(m_renderQueue.fields._entries) = 0;
			//   v79 = -1;
			//   Unity::Collections::NativeList<unsigned int>::GetEnumerator(
			//     (NativeArray_1_T_Enumerator_System_UInt32_ *)&v111,
			//     (NativeList_1_System_UInt32_ *)&v110,
			//     MethodInfo::Unity::Collections::NativeList<unsigned int>::GetEnumerator);
			//   v116 = v111;
			//   v111.m_Array.m_Buffer = 0LL;
			//   *(_QWORD *)&v111.m_Array.m_Length = &v116;
			//   try
			//   {
			//     while ( Unity::Collections::NativeArray_1_T__ReadOnly_T_::Enumerator<unsigned int>::MoveNext(
			//               &v116,
			//               MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<unsigned int>::MoveNext) )
			//     {
			//       v81 = v116.value;
			//       if ( v116.value != v79 )
			//       {
			//         v82 = v4.fields.m_nodeCacheLut;
			//         if ( !v82 )
			//           sub_1802DC2C8(0LL, v80);
			//         if ( System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue(
			//                v82,
			//                v116.value,
			//                &v112,
			//                MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue) )
			//         {
			//           m_lruCache = v4.fields.m_lruCache;
			//           if ( !m_lruCache )
			//             sub_1802DC2C8(0LL, v83);
			//           HG::Rendering::Runtime::LRUCache::Visit(m_lruCache, v112, 0LL);
			//         }
			//         else
			//         {
			//           v85 = v4.fields.m_renderQueue;
			//           if ( !v85 )
			//             sub_1802DC2C8(v84, v83);
			//           if ( v85.fields._size < v4.fields._vtMaxPagePerFrame_k__BackingField )
			//           {
			//             v86 = v4.fields.m_lruCache;
			//             if ( !v86 )
			//               sub_1802DC2C8(0LL, v83);
			//             v87 = (unsigned __int64)HG::Rendering::Runtime::LRUCache::Allocate(v86, v81, 0LL);
			//             v88 = v87;
			//             v89 = HIDWORD(v87);
			//             if ( HIDWORD(v87) != -1 )
			//             {
			//               v90 = (Dictionary_2_System_UInt32_System_Single_ *)v4.fields.m_nodeCacheLut;
			//               if ( !v90 )
			//                 sub_1802DC2C8(0LL, v89);
			//               System::Collections::Generic::Dictionary<unsigned int,float>::Remove(
			//                 v90,
			//                 HIDWORD(v87),
			//                 MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Remove);
			//             }
			//             v91 = v4.fields.m_nodeCacheLut;
			//             if ( !v91 )
			//               sub_1802DC2C8(0LL, v89);
			//             System::Collections::Generic::Dictionary<unsigned int,int>::Add(
			//               v91,
			//               v81,
			//               v88,
			//               MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Add);
			//             v93 = v4.fields.m_renderQueue;
			//             if ( !v93 )
			//               sub_1802DC2C8(0LL, v92);
			//             sub_1826AA8C0(v93, v81);
			//           }
			//         }
			//         v79 = v81;
			//       }
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v121 )
			//   {
			//     v111.m_Array.m_Buffer = (Void *)v121.ex;
			//     if ( v111.m_Array.m_Buffer )
			//       sub_18000F780(v111.m_Array.m_Buffer);
			//     v4 = this;
			//   }
			//   Unity::Collections::NativeList<unsigned int>::Dispose(
			//     (NativeList_1_System_UInt32_ *)&v110,
			//     MethodInfo::Unity::Collections::NativeList<unsigned int>::Dispose);
			//   currIndirectTexture = HG::Rendering::Runtime::VirtualTextureRenderer::get_currIndirectTexture(v4, 0LL);
			//   HG::Rendering::Runtime::VirtualTextureRenderer::_UpdateClipmapTexture(v4, currIndirectTexture, 0LL);
			//   Unity::Collections::NativeList<int>::GetEnumerator(
			//     &v110,
			//     &v114,
			//     MethodInfo::Unity::Collections::NativeList<int>::GetEnumerator);
			//   m_Array = v110.m_Array;
			//   *(_QWORD *)v118 = *(_QWORD *)&v110.m_Index;
			//   v110.m_Array.m_Buffer = 0LL;
			//   *(_QWORD *)&v110.m_Array.m_Length = &m_Array;
			//   try
			//   {
			//     while ( (unsigned __int8)sub_183038810(
			//                                &m_Array,
			//                                MethodInfo::Unity::Collections::NativeArray_1_T_::Enumerator<int>::MoveNext) )
			//     {
			//       v97 = v4.fields.m_lruCache;
			//       if ( !v97 )
			//         sub_1802DC2C8(0LL, v96);
			//       HG::Rendering::Runtime::LRUCache::Unlock(v97, v118[1], 0LL);
			//     }
			//   }
			//   catch ( Il2CppExceptionWrapper *v122 )
			//   {
			//     v110.m_Array.m_Buffer = (Void *)v122.ex;
			//     if ( v110.m_Array.m_Buffer )
			//       sub_18000F780(v110.m_Array.m_Buffer);
			//   }
			//   Unity::Collections::NativeList<int>::Dispose(&v114, MethodInfo::Unity::Collections::NativeList<int>::Dispose);
			// }
			// 
		}

		public void GameUpdate(Camera camera)
		{
			// // Void GameUpdate(Camera)
			// void HG::Rendering::Runtime::VirtualTextureRenderer::GameUpdate(
			//         VirtualTextureRenderer *this,
			//         Camera *camera,
			//         MethodInfo *method)
			// {
			//   bool refreshed; // bl
			//   bool v6; // al
			//   __int64 v7; // rdx
			//   TerrainCollider *m_globalUVs; // rcx
			//   int32_t feedbackMode_k__BackingField; // eax
			//   Transform *transform; // rax
			//   Transform *v11; // rbx
			//   __int64 v12; // rsi
			//   Vector3 *down; // rax
			//   float v14; // r8d
			//   __int64 v15; // xmm4_8
			//   __int64 v16; // xmm3_8
			//   int32_t v17; // r12d
			//   float i; // xmm13_4
			//   int32_t j; // r15d
			//   __int64 v20; // r8
			//   int v21; // r13d
			//   int v22; // esi
			//   int32_t m_Y; // edi
			//   Vector3 *v24; // rax
			//   __int64 v25; // xmm0_8
			//   Vector3 *v26; // rax
			//   __int64 v27; // xmm0_8
			//   __int64 v28; // xmm7_8
			//   float z; // edi
			//   MethodInfo *v30; // r9
			//   Vector3 *v31; // rax
			//   __int64 v32; // xmm6_8
			//   float v33; // ebx
			//   Vector3 *v34; // rax
			//   __int64 v35; // xmm0_8
			//   MethodInfo *v36; // r9
			//   float m_Distance; // xmm1_4
			//   MethodInfo *v38; // r9
			//   MethodInfo *v39; // rax
			//   float *v40; // rdx
			//   __int64 v41; // xmm0_8
			//   MethodInfo *v42; // r8
			//   __int64 v43; // r9
			//   float v44; // eax
			//   __int64 v45; // xmm5_8
			//   float v46; // r11d
			//   __int64 v47; // r10
			//   float v48; // eax
			//   MethodInfo *v49; // r8
			//   float v50; // xmm4_4
			//   MethodInfo *v51; // r9
			//   Vector3 *v52; // rax
			//   __int64 v53; // r9
			//   __int64 v54; // xmm3_8
			//   Vector3 *v55; // rsi
			//   MethodInfo *v56; // r8
			//   float v57; // xmm4_4
			//   MethodInfo *v58; // r9
			//   Vector3 *v59; // rax
			//   __int64 v60; // r10
			//   __int64 v61; // xmm3_8
			//   MethodInfo *v62; // r9
			//   Vector3 *v63; // rbx
			//   __int64 v64; // xmm7_8
			//   float v65; // edi
			//   __int64 v66; // xmm5_8
			//   float v67; // r11d
			//   MethodInfo *v68; // r9
			//   MethodInfo *v69; // rax
			//   __int64 v70; // xmm5_8
			//   float v71; // r11d
			//   MethodInfo *v72; // rax
			//   float *v73; // r9
			//   __int64 v74; // xmm0_8
			//   __int64 v75; // xmm4_8
			//   float v76; // r10d
			//   __int64 *v77; // r9
			//   __int64 *v78; // rax
			//   __int64 v79; // xmm0_8
			//   MethodInfo *v80; // r8
			//   __int64 *v81; // r8
			//   __m128i v82; // xmm2
			//   __m128 v83; // xmm3
			//   __m128 v84; // xmm1
			//   __int64 v85; // xmm0_8
			//   float v86; // eax
			//   __m128 v87; // xmm4
			//   __m128 v88; // xmm5
			//   MethodInfo *v89; // r8
			//   MethodInfo *v90; // r8
			//   float v91; // eax
			//   __int64 v92; // xmm5_8
			//   __int64 v93; // xmm4_8
			//   MethodInfo *v94; // r8
			//   MethodInfo *v95; // r8
			//   __m128 x_low; // xmm7
			//   unsigned int v97; // r10d
			//   __m128 v98; // xmm5
			//   __m128 v99; // xmm8
			//   __m128 v100; // xmm6
			//   __int64 v101; // rcx
			//   __int64 v102; // rcx
			//   Vector2 v103; // rax
			//   Vector2 v104; // r8
			//   Vector2 v105; // r9
			//   Vector2 v106; // xmm4_8
			//   __m128 v107; // xmm5
			//   __int64 v108; // rcx
			//   __int64 v109; // rcx
			//   Vector2 v110; // rax
			//   Vector2 v111; // r8
			//   Vector2 v112; // r9
			//   Vector2 v113; // xmm4_8
			//   Vector2 v114; // rax
			//   Vector2 v115; // r9
			//   AsyncGPUReadbackRequest *currGPUFeedbackRequest; // rdi
			//   NativeArray_1_System_UInt32_ *currGPUFeedbackData; // rbx
			//   ComputeBuffer *currGPUFeedbackBuffer; // rax
			//   __int64 v119; // rax
			//   InvalidEnumArgumentException *v120; // rbx
			//   String *v121; // rax
			//   __int64 v122; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Ray v124; // [rsp+48h] [rbp-C0h] BYREF
			//   Vector3 v125; // [rsp+68h] [rbp-A0h] BYREF
			//   Vector3 v126; // [rsp+78h] [rbp-90h] BYREF
			//   Transform *v127; // [rsp+88h] [rbp-80h]
			//   Ray v128; // [rsp+90h] [rbp-78h] BYREF
			//   HGTerrainRaycastHit v129; // [rsp+A8h] [rbp-60h] BYREF
			//   __int128 v130; // [rsp+E0h] [rbp-28h]
			//   Vector3 v131; // [rsp+F8h] [rbp-10h] BYREF
			//   Vector3 v132; // [rsp+108h] [rbp+0h] BYREF
			//   Vector3 v133; // [rsp+118h] [rbp+10h] BYREF
			//   Vector3 m_Normal; // [rsp+128h] [rbp+20h] BYREF
			//   Vector3 v135; // [rsp+138h] [rbp+30h] BYREF
			//   Vector3 v136; // [rsp+148h] [rbp+40h] BYREF
			//   Vector3 v137; // [rsp+158h] [rbp+50h] BYREF
			//   Vector3 v138; // [rsp+168h] [rbp+60h] BYREF
			//   Vector3 v139; // [rsp+178h] [rbp+70h] BYREF
			//   Vector3 v140; // [rsp+188h] [rbp+80h] BYREF
			//   Vector3 v141; // [rsp+198h] [rbp+90h] BYREF
			//   Vector3 v142; // [rsp+1A8h] [rbp+A0h] BYREF
			//   Vector3 v143; // [rsp+1B8h] [rbp+B0h] BYREF
			//   Vector3 v144; // [rsp+1C8h] [rbp+C0h] BYREF
			//   Vector3 v145; // [rsp+1D8h] [rbp+D0h] BYREF
			//   Vector3 v146; // [rsp+1E8h] [rbp+E0h] BYREF
			//   Vector3 m_Edge02; // [rsp+1F8h] [rbp+F0h] BYREF
			//   Vector3 v148; // [rsp+208h] [rbp+100h] BYREF
			//   Vector3 m_Edge01; // [rsp+218h] [rbp+110h] BYREF
			//   Vector3 v150; // [rsp+228h] [rbp+120h] BYREF
			//   Vector3 v151; // [rsp+238h] [rbp+130h] BYREF
			//   __int64 v152; // [rsp+248h] [rbp+140h]
			//   Vector3 v153; // [rsp+258h] [rbp+150h] BYREF
			//   Vector3 v154; // [rsp+268h] [rbp+160h] BYREF
			//   __int64 v155; // [rsp+278h] [rbp+170h]
			//   Vector3 v156; // [rsp+288h] [rbp+180h] BYREF
			//   Vector3 v157; // [rsp+298h] [rbp+190h] BYREF
			//   Vector3 v158; // [rsp+2A8h] [rbp+1A0h] BYREF
			//   Vector3 v159; // [rsp+2B8h] [rbp+1B0h] BYREF
			//   Vector3 v160; // [rsp+2C8h] [rbp+1C0h] BYREF
			//   Vector3 v161; // [rsp+2D8h] [rbp+1D0h] BYREF
			//   Vector3 v162; // [rsp+2E8h] [rbp+1E0h] BYREF
			//   __int64 v163; // [rsp+2F8h] [rbp+1F0h]
			//   Vector3 m_Direction; // [rsp+308h] [rbp+200h] BYREF
			//   Vector3 v165; // [rsp+318h] [rbp+210h] BYREF
			//   Vector3 v166; // [rsp+328h] [rbp+220h] BYREF
			//   AsyncGPUReadbackRequest v167; // [rsp+338h] [rbp+230h] BYREF
			//   __int128 v168; // [rsp+348h] [rbp+240h] BYREF
			//   unsigned __int64 v169; // [rsp+358h] [rbp+250h]
			//   Vector3 v170; // [rsp+368h] [rbp+260h] BYREF
			//   Vector3 v171; // [rsp+378h] [rbp+270h] BYREF
			//   Vector3 v172; // [rsp+388h] [rbp+280h] BYREF
			//   Vector3 v173; // [rsp+398h] [rbp+290h] BYREF
			//   Vector3 v174; // [rsp+3A8h] [rbp+2A0h] BYREF
			//   Vector3 v175; // [rsp+3B8h] [rbp+2B0h] BYREF
			//   Vector3 v176; // [rsp+3C8h] [rbp+2C0h] BYREF
			//   Vector3 v177; // [rsp+3D8h] [rbp+2D0h] BYREF
			//   Vector3 v178; // [rsp+3E8h] [rbp+2E0h] BYREF
			//   Vector3 v179; // [rsp+3F8h] [rbp+2F0h] BYREF
			//   Vector3 v180; // [rsp+408h] [rbp+300h] BYREF
			//   Vector3 v181[12]; // [rsp+418h] [rbp+310h] BYREF
			//   Vector2Int currScreenSize; // [rsp+4F0h] [rbp+3E8h] BYREF
			// 
			//   if ( !byte_18D919733 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::AsyncGPUReadback::RequestIntoNativeArray<unsigned int>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::Clear);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919733 = 1;
			//   }
			//   memset(&v128, 0, sizeof(v128));
			//   memset(&v129, 0, sizeof(v129));
			//   v130 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3350, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3350, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)camera,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_29;
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( UnityEngine::Object::op_Equality((Object_1 *)camera, 0LL, 0LL) )
			//     return;
			//   refreshed = HG::Rendering::Runtime::VirtualTextureRenderer::_RefreshIndirectTextureParams(this, 0LL);
			//   v6 = HG::Rendering::Runtime::VirtualTextureRenderer::_RefreshPhysicalCacheParams(this, 0LL);
			//   if ( v6 || refreshed )
			//   {
			//     this.fields.m_needVTDataBufferSetup = 1;
			//     if ( v6 )
			//       this.fields.m_needVTTexturesSetup = 1;
			//   }
			//   if ( !camera )
			//     goto LABEL_29;
			//   currScreenSize.m_X = UnityEngine::Camera::get_pixelWidth(camera, 0LL);
			//   currScreenSize.m_Y = UnityEngine::Camera::get_pixelHeight(camera, 0LL);
			//   feedbackMode_k__BackingField = this.fields._feedbackMode_k__BackingField;
			//   if ( feedbackMode_k__BackingField )
			//   {
			//     if ( feedbackMode_k__BackingField == 1 )
			//     {
			//       HG::Rendering::Runtime::VirtualTextureRenderer::_RefreshGPUFeedbackParams(this, &currScreenSize, 0LL);
			//       if ( HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackBufferFilled(this, 0LL) )
			//       {
			//         currGPUFeedbackRequest = HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackRequest(this, 0LL);
			//         currGPUFeedbackData = HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackData(this, 0LL);
			//         currGPUFeedbackBuffer = HG::Rendering::Runtime::VirtualTextureRenderer::get_currGPUFeedbackBuffer(this, 0LL);
			//         UnityEngine::Rendering::AsyncGPUReadback::RequestIntoNativeArray<unsigned int>(
			//           &v167,
			//           currGPUFeedbackData,
			//           currGPUFeedbackBuffer,
			//           0LL,
			//           MethodInfo::UnityEngine::Rendering::AsyncGPUReadback::RequestIntoNativeArray<unsigned int>);
			//         *currGPUFeedbackRequest = v167;
			//       }
			//       return;
			//     }
			//     v119 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//     v120 = (InvalidEnumArgumentException *)sub_180004920(v119);
			//     if ( v120 )
			//     {
			//       v121 = (String *)sub_18000F7E0(&off_18D519398);
			//       System::ComponentModel::InvalidEnumArgumentException::InvalidEnumArgumentException(v120, v121, 0LL);
			//       v122 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::VirtualTextureRenderer::GameUpdate);
			//       sub_18000F7C0(v120, v122);
			//     }
			// LABEL_29:
			//     sub_180B536AC(m_globalUVs, v7);
			//   }
			//   HG::Rendering::Runtime::VirtualTextureRenderer::_RefreshCPUFeedbackParams(this, &currScreenSize, 0LL);
			//   transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//   v127 = transform;
			//   v11 = transform;
			//   if ( !transform )
			//     goto LABEL_29;
			//   UnityEngine::Transform::get_position(&v126, transform, 0LL);
			//   m_globalUVs = (TerrainCollider *)this.fields.m_globalUVs;
			//   if ( !m_globalUVs )
			//     goto LABEL_29;
			//   ++HIDWORD(m_globalUVs[1].klass);
			//   LODWORD(m_globalUVs[1].klass) = 0;
			//   v12 = this.fields.m_frameCount % (__int64)(this.fields.m_blockWidth * this.fields.m_blockHeight);
			//   v163 = v12;
			//   down = UnityEngine::Vector3::get_down(&v126, (MethodInfo *)v12);
			//   v125.z = v14;
			//   *(_QWORD *)&v125.x = v15;
			//   v16 = *(_QWORD *)&down.x;
			//   *(float *)&down = down.z;
			//   *(_QWORD *)&v124.m_Origin.x = v16;
			//   LODWORD(v124.m_Origin.z) = (_DWORD)down;
			//   UnityEngine::Ray::Ray(&v128, &v125, &v124.m_Origin, 0LL);
			//   v17 = 0;
			//   for ( i = UnityEngine::Camera::get_fieldOfView(camera, 0LL); v17 < this.fields.m_feedbackHeight; ++v17 )
			//   {
			//     for ( j = 0; j < this.fields.m_feedbackWidth; ++j )
			//     {
			//       v20 = j + this.fields.m_feedbackWidth * v17;
			//       v21 = this.fields.m_blockWidth * j
			//           + *(__int16 *)&this.fields.m_feedbackJitterSeq.m_Buffer[4 * (int)v12
			//                                                                  + 4
			//                                                                  * *(_DWORD *)&this.fields.m_cpuJitterOffsets.m_Buffer[4 * v20]];
			//       v22 = this.fields.m_blockHeight * v17
			//           + *(__int16 *)&this.fields.m_feedbackJitterSeq.m_Buffer[4 * (int)v12
			//                                                                  + 2
			//                                                                  + 4
			//                                                                  * *(_DWORD *)&this.fields.m_cpuJitterOffsets.m_Buffer[4 * v20]];
			//       if ( v21 < currScreenSize.m_X )
			//       {
			//         m_Y = currScreenSize.m_Y;
			//         if ( v22 < currScreenSize.m_Y )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//           v24 = HG::Rendering::Runtime::HGTerrainUtils::ScreenPointToRay(
			//                   &v180,
			//                   v11,
			//                   i,
			//                   v21,
			//                   v22,
			//                   currScreenSize.m_X,
			//                   m_Y,
			//                   0LL);
			//           v25 = *(_QWORD *)&v24.x;
			//           *(float *)&v24 = v24.z;
			//           *(_QWORD *)&v125.x = v25;
			//           LODWORD(v125.z) = (_DWORD)v24;
			//           UnityEngine::Ray::set_direction(&v128, &v125, 0LL);
			//           m_globalUVs = this.fields.m_collider;
			//           if ( !m_globalUVs )
			//             goto LABEL_29;
			//           v124 = v128;
			//           if ( UnityEngine::TerrainCollider::HGTerrainRaycast(m_globalUVs, &v124, &v129, 1000.0, 0, 0LL) )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//             v26 = HG::Rendering::Runtime::HGTerrainUtils::ScreenPointToRay(
			//                     &v179,
			//                     v11,
			//                     i,
			//                     v21 + 1,
			//                     v22,
			//                     currScreenSize.m_X,
			//                     m_Y,
			//                     0LL);
			//             v27 = *(_QWORD *)&v26.x;
			//             *(float *)&v26 = v26.z;
			//             v28 = *(_QWORD *)&v128.m_Direction.x;
			//             z = v128.m_Direction.z;
			//             m_Direction = v128.m_Direction;
			//             *(_QWORD *)&v165.x = v27;
			//             LODWORD(v165.z) = (_DWORD)v26;
			//             v31 = UnityEngine::Vector3::op_Subtraction(&v176, &v165, &m_Direction, v30);
			//             v32 = *(_QWORD *)&v31.x;
			//             v33 = v31.z;
			//             v34 = HG::Rendering::Runtime::HGTerrainUtils::ScreenPointToRay(
			//                     &v170,
			//                     v127,
			//                     i,
			//                     v21,
			//                     v22 + 1,
			//                     currScreenSize.m_X,
			//                     currScreenSize.m_Y,
			//                     0LL);
			//             v35 = *(_QWORD *)&v34.x;
			//             *(float *)&v34 = v34.z;
			//             *(_QWORD *)&v131.x = v35;
			//             LODWORD(v131.z) = (_DWORD)v34;
			//             *(_QWORD *)&v166.x = v28;
			//             v166.z = z;
			//             UnityEngine::Vector3::op_Subtraction(&v171, &v131, &v166, v36);
			//             m_Distance = v129.m_Distance;
			//             *(_QWORD *)&v132.x = v32;
			//             v132.z = v33;
			//             v39 = (MethodInfo *)UnityEngine::Vector3::op_Multiply(&v172, v129.m_Distance, &v132, v38);
			//             v41 = *(_QWORD *)v40;
			//             v133.z = v40[2];
			//             *(_QWORD *)&v133.x = v41;
			//             UnityEngine::Vector3::op_Multiply(&v173, m_Distance, &v133, v39);
			//             m_Normal = v129.m_Normal;
			//             *(_QWORD *)&v135.x = v28;
			//             v135.z = z;
			//             UnityEngine::Vector3::Dot(&v135, &m_Normal, v42);
			//             v44 = *(float *)(v43 + 8);
			//             *(_QWORD *)&v137.x = *(_QWORD *)v43;
			//             *(_QWORD *)&v136.x = v45;
			//             v136.z = v46;
			//             v137.z = v44;
			//             v48 = *(float *)(v47 + 8);
			//             *(_QWORD *)&v142.x = *(_QWORD *)v47;
			//             *(_QWORD *)&v141.x = v45;
			//             v141.z = v46;
			//             v142.z = v48;
			//             *(_QWORD *)&v138.x = v28;
			//             v138.z = z;
			//             *(float *)&v41 = UnityEngine::Vector3::Dot(&v137, &v136, v49);
			//             v52 = UnityEngine::Vector3::op_Multiply(&v174, &v138, (float)-*(float *)&v41 * v50, v51);
			//             *(_QWORD *)&v140.x = *(_QWORD *)v53;
			//             v54 = *(_QWORD *)&v52.x;
			//             v139.z = v52.z;
			//             v140.z = *(float *)(v53 + 8);
			//             *(_QWORD *)&v139.x = v54;
			//             v55 = UnityEngine::Vector3::op_Addition(&v175, &v140, &v139, (MethodInfo *)v53);
			//             *(_QWORD *)&v143.x = v28;
			//             v143.z = z;
			//             *(float *)&v41 = UnityEngine::Vector3::Dot(&v142, &v141, v56);
			//             v59 = UnityEngine::Vector3::op_Multiply(v181, &v143, (float)-*(float *)&v41 * v57, v58);
			//             *(_QWORD *)&v145.x = *(_QWORD *)v60;
			//             v61 = *(_QWORD *)&v59.x;
			//             v144.z = v59.z;
			//             v145.z = *(float *)(v60 + 8);
			//             *(_QWORD *)&v144.x = v61;
			//             v63 = UnityEngine::Vector3::op_Addition(&v177, &v145, &v144, v62);
			//             v64 = *(_QWORD *)&v129.m_Edge02.x;
			//             v65 = v129.m_Edge02.z;
			//             m_Edge02 = v129.m_Edge02;
			//             *(_QWORD *)&v146.x = v66;
			//             v146.z = v67;
			//             v69 = (MethodInfo *)UnityEngine::Vector3::Cross(&v178, &m_Edge02, &v146, v68);
			//             m_Edge01 = v129.m_Edge01;
			//             *(_QWORD *)&v148.x = v70;
			//             v148.z = v71;
			//             v72 = (MethodInfo *)UnityEngine::Vector3::Cross((Vector3 *)&v167, &m_Edge01, &v148, v69);
			//             v74 = *(_QWORD *)v73;
			//             v151.z = v73[2];
			//             *(_QWORD *)&v150.x = v75;
			//             v150.z = v76;
			//             *(_QWORD *)&v151.x = v74;
			//             *(float *)&v74 = UnityEngine::Vector3::Dot(&v151, &v150, v72);
			//             LODWORD(v32) = *((_DWORD *)v77 + 2);
			//             v152 = *v77;
			//             *(float *)&v32 = *(float *)&v32 / *(float *)&v74;
			//             v79 = *v78;
			//             LODWORD(v78) = *((_DWORD *)v78 + 2);
			//             *(_QWORD *)&v154.x = v79;
			//             LODWORD(v154.z) = (_DWORD)v78;
			//             *(_QWORD *)&v153.x = v64;
			//             v153.z = v65;
			//             *(float *)&v79 = UnityEngine::Vector3::Dot(&v154, &v153, v80);
			//             v82 = (__m128i)*((unsigned int *)v81 + 2);
			//             v155 = *v81;
			//             v83 = (__m128)(unsigned int)v155;
			//             v84 = (__m128)HIDWORD(v155);
			//             v83.m128_f32[0] = *(float *)&v155 / *(float *)&v79;
			//             v84.m128_f32[0] = *((float *)&v155 + 1) / *(float *)&v79;
			//             *(float *)v82.m128i_i32 = *(float *)v82.m128i_i32 / *(float *)&v79;
			//             v85 = *(_QWORD *)&v55.x;
			//             v86 = v55.z;
			//             v89 = (MethodInfo *)(unsigned int)_mm_cvtsi128_si32(v82);
			//             *(_QWORD *)&v159.x = _mm_unpacklo_ps(v83, v84).m128_u64[0];
			//             LODWORD(v157.z) = v32;
			//             *(_QWORD *)&v156.x = v85;
			//             v156.z = v86;
			//             *(_QWORD *)&v157.x = _mm_unpacklo_ps(v88, v87).m128_u64[0];
			//             *(_QWORD *)&v158.x = v85;
			//             v158.z = v86;
			//             LODWORD(v159.z) = (_DWORD)v89;
			//             UnityEngine::Vector3::Dot(&v157, &v156, v89);
			//             UnityEngine::Vector3::Dot(&v159, &v158, v90);
			//             v91 = v63.z;
			//             *(_QWORD *)&v160.x = *(_QWORD *)&v63.x;
			//             *(_QWORD *)&v162.x = *(_QWORD *)&v160.x;
			//             LODWORD(v161.z) = v32;
			//             v160.z = v91;
			//             *(_QWORD *)&v161.x = v92;
			//             v162.z = v91;
			//             *(_QWORD *)&v126.x = v93;
			//             LODWORD(v126.z) = (_DWORD)v94;
			//             UnityEngine::Vector3::Dot(&v161, &v160, v94);
			//             UnityEngine::Vector3::Dot(&v126, &v162, v95);
			//             x_low = (__m128)LODWORD(v129.m_Edge01.x);
			//             x_low.m128_f32[0] = v129.m_Edge01.x * this.fields.m_worldToVirtual.x;
			//             v98 = (__m128)_mm_cvtsi32_si128(v97);
			//             v98.m128_f32[0] = v98.m128_f32[0] * this.fields.m_worldToVirtual.y;
			//             v99 = (__m128)LODWORD(v129.m_Edge02.x);
			//             v99.m128_f32[0] = v129.m_Edge02.x * this.fields.m_worldToVirtual.y;
			//             v100 = (__m128)_mm_cvtsi32_si128(LODWORD(v65));
			//             v100.m128_f32[0] = v100.m128_f32[0] * this.fields.m_worldToVirtual.y;
			//             v84.m128_f32[0] = (float)(v129.m_Position.x + this.fields.m_terrainPosOffset.x)
			//                             * this.fields.m_worldToVirtual.x;
			//             *((float *)&v130 + 1) = (float)(v129.m_Position.z + this.fields.m_terrainPosOffset.y)
			//                                   * this.fields.m_worldToVirtual.y;
			//             LODWORD(v130) = v84.m128_i32[0];
			//             sub_184D03A3C(v101, _mm_unpacklo_ps(x_low, v98).m128_u64[0]);
			//             v103 = (Vector2)sub_184D03A3C(v102, _mm_unpacklo_ps(v99, v100).m128_u64[0]);
			//             *(Vector2 *)&v124.m_Origin.x = sub_1842BE4B8(v106, v103, v104, v105);
			//             *((_QWORD *)&v130 + 1) = *(_QWORD *)&v124.m_Origin.x;
			//             sub_184D03A3C(v108, _mm_unpacklo_ps(x_low, v107).m128_u64[0]);
			//             v110 = (Vector2)sub_184D03A3C(v109, _mm_unpacklo_ps(v99, v100).m128_u64[0]);
			//             v114 = sub_1842BE4B8(v113, v110, v111, v112);
			//             *(Vector2 *)&v124.m_Origin.x = v114;
			//             if ( !*(_QWORD *)&v115 )
			//               goto LABEL_29;
			//             v168 = v130;
			//             v169 = _mm_unpacklo_ps((__m128)LODWORD(v124.m_Origin.x), (__m128)LODWORD(v114.y)).m128_u64[0];
			//             ((void (__fastcall *)(_QWORD, _QWORD, _QWORD))sub_180422500)(
			//               v115,
			//               &v168,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VirtualTextureRenderer::GlobalUV>::Add);
			//             v11 = v127;
			//           }
			//         }
			//       }
			//       LODWORD(v12) = v163;
			//     }
			//   }
			// }
			// 
		}

		public void Render(ScriptableRenderContext renderContext)
		{
			// // Void Render(ScriptableRenderContext)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::VirtualTextureRenderer::Render(
			//         VirtualTextureRenderer *this,
			//         ScriptableRenderContext renderContext,
			//         MethodInfo *method)
			// {
			//   VirtualTextureRenderer *v3; // r15
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   List_1_System_UInt32_ *m_renderQueue; // rbx
			//   CommandBuffer *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   CommandBuffer *v10; // r12
			//   ComputeShader *m_vtBakeCS; // rsi
			//   __int64 v12; // rdx
			//   HGShaderIDs__StaticFields *static_fields; // rcx
			//   ComputeBuffer *terrainBakeDataBuffer_k__BackingField; // rax
			//   __int64 v15; // rdx
			//   __int64 v16; // rcx
			//   int32_t count; // edi
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   int32_t stride; // ebx
			//   ComputeShader *v21; // rbx
			//   int32_t m_vtBakeMainKernel; // edi
			//   int32_t HGTerrainPhysicalBase; // esi
			//   RenderTargetIdentifier *v24; // rax
			//   __int128 v25; // xmm7
			//   __int64 v26; // xmm8_8
			//   ComputeShader *v27; // rbx
			//   int32_t v28; // edi
			//   int32_t HGTerrainColorVariationTex; // esi
			//   RenderTargetIdentifier *v30; // rax
			//   __int128 v31; // xmm7
			//   __int64 v32; // xmm8_8
			//   ComputeShader *v33; // rbx
			//   int32_t v34; // edi
			//   int32_t HGTerrainControlMap; // esi
			//   RenderTargetIdentifier *v36; // rax
			//   __int128 v37; // xmm7
			//   __int64 v38; // xmm8_8
			//   ComputeShader *v39; // rbx
			//   int32_t v40; // edi
			//   int32_t HGTerrainSplatIndexMap; // esi
			//   RenderTargetIdentifier *v42; // rax
			//   __int128 v43; // xmm7
			//   __int64 v44; // xmm8_8
			//   ComputeShader *v45; // rbx
			//   int32_t v46; // edi
			//   int32_t HGTerrainSplats; // esi
			//   RenderTargetIdentifier *v48; // rax
			//   __int128 v49; // xmm7
			//   __int64 v50; // xmm8_8
			//   ComputeShader *v51; // rbx
			//   int32_t v52; // edi
			//   int32_t HGTerrainNormals; // esi
			//   RenderTargetIdentifier *v54; // rax
			//   __int128 v55; // xmm7
			//   __int64 v56; // xmm8_8
			//   ComputeShader *v57; // rbx
			//   int32_t v58; // edi
			//   int32_t HGTerrainTerrainNormalmapTexture; // esi
			//   RenderTargetIdentifier *v60; // rax
			//   __int128 v61; // xmm7
			//   __int64 v62; // xmm8_8
			//   Object_1 *m_decalDiffuseTexArray; // rbx
			//   __int64 v64; // rdx
			//   Dictionary_2_System_UInt32_System_Object_ *m_decalInstanceInfo; // rcx
			//   HGTerrainConfiguration *m_configuration; // rbx
			//   ComputeShader *v67; // rbx
			//   int32_t v68; // edi
			//   int32_t HGTerrainDecalDiffuseTexArray; // esi
			//   RenderTargetIdentifier *v70; // rax
			//   __int128 v71; // xmm7
			//   __int64 v72; // xmm8_8
			//   ComputeShader *v73; // rbx
			//   int32_t v74; // edi
			//   int32_t HGTerrainDecalNormalMROTexArray; // esi
			//   RenderTargetIdentifier *v76; // rax
			//   __int128 v77; // xmm7
			//   __int64 v78; // xmm8_8
			//   ComputeShader *v79; // rbx
			//   int32_t v80; // edi
			//   int32_t HGTerrainHeightmap; // esi
			//   RenderTargetIdentifier *v82; // rax
			//   __int128 v83; // xmm7
			//   __int64 v84; // xmm8_8
			//   int32_t i; // ebx
			//   List_1_System_UInt32_ *v86; // rax
			//   ValueTuple_3_Int32_Int32_Int32_ *v87; // rax
			//   int Item3; // esi
			//   int32_t v89; // edi
			//   float v90; // xmm4_4
			//   unsigned int v91; // xmm3_4
			//   unsigned int v92; // xmm2_4
			//   int v93; // r9d
			//   float v94; // xmm1_4
			//   ComputeShader *v95; // rbx
			//   RenderTargetIdentifier *v96; // rax
			//   __int128 v97; // xmm7
			//   __int64 v98; // xmm8_8
			//   ComputeShader *v99; // rbx
			//   RenderTargetIdentifier *v100; // rax
			//   __int128 v101; // xmm7
			//   __int64 v102; // xmm8_8
			//   __int64 v103; // rdx
			//   __int64 v104; // r8
			//   bool v105; // bl
			//   int32_t m_decalMaxLevel; // eax
			//   int32_t v107; // ecx
			//   __int64 v108; // rcx
			//   int v109; // edi
			//   int32_t v110; // esi
			//   int v111; // ebx
			//   double v112; // xmm0_8
			//   signed int v113; // eax
			//   int v114; // esi
			//   uint32_t v115; // eax
			//   __int64 v116; // r8
			//   __int64 v117; // r9
			//   Object *v118; // rdi
			//   unsigned int v119; // eax
			//   MethodInfo *v120; // rbx
			//   HGTerrainRuntimeResources_DecalPerInstanceData *v121; // rax
			//   char v122; // cl
			//   int32_t Length; // esi
			//   __int64 v124; // rdx
			//   __int64 v125; // rcx
			//   __int64 v126; // r8
			//   __int64 v127; // rdx
			//   __int64 v128; // rcx
			//   double v129; // xmm0_8
			//   __int64 v130; // rcx
			//   char v131; // al
			//   int v132; // esi
			//   int v133; // ebx
			//   __int64 v134; // rdx
			//   __int64 v135; // rcx
			//   __int64 v136; // rdx
			//   __int64 v137; // rcx
			//   signed int v138; // eax
			//   int v139; // ebx
			//   __int64 v140; // r12
			//   int32_t j; // esi
			//   __int64 v142; // rdx
			//   __int64 v143; // r8
			//   __int64 v144; // r9
			//   MethodInfo *v145; // rbx
			//   HGTerrainRuntimeResources_DecalPerInstanceData *v146; // rax
			//   Object *v147; // rbx
			//   float v148; // xmm6_4
			//   ComputeShader *v149; // rbx
			//   ComputeShader *v150; // rdi
			//   int32_t HGTerrainDecalInstanceData; // ebx
			//   ComputeShader *v152; // rbx
			//   int32_t HGTerrainUVTransform; // r8d
			//   int32_t HGTerrainRTOffset; // r8d
			//   Vector4 v155; // xmm6
			//   ComputeShader *m_vtCompressCS; // rbx
			//   ComputeShader *v157; // rsi
			//   int32_t m_vtCompressMainKernel; // edi
			//   unsigned int v159; // eax
			//   Dictionary_2_System_UInt32_System_Int32_ *m_nodeCacheLut; // rbx
			//   RegexCharClass_SingleRange Item; // eax
			//   int32_t layer; // edi
			//   int32_t v163; // esi
			//   int32_t v164; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v166; // rdx
			//   __int64 v167; // rcx
			//   uint32_t key; // [rsp+70h] [rbp-2A8h]
			//   uint32_t keyd; // [rsp+70h] [rbp-2A8h]
			//   uint32_t keye; // [rsp+70h] [rbp-2A8h]
			//   uint32_t keya; // [rsp+70h] [rbp-2A8h]
			//   uint32_t keyb; // [rsp+70h] [rbp-2A8h]
			//   uint32_t keyc; // [rsp+70h] [rbp-2A8h]
			//   int32_t v174; // [rsp+74h] [rbp-2A4h]
			//   int32_t v175; // [rsp+74h] [rbp-2A4h]
			//   int32_t v176; // [rsp+74h] [rbp-2A4h]
			//   char v177; // [rsp+74h] [rbp-2A4h]
			//   unsigned int v178; // [rsp+78h] [rbp-2A0h]
			//   int v179; // [rsp+78h] [rbp-2A0h]
			//   int v180; // [rsp+78h] [rbp-2A0h]
			//   int32_t v181; // [rsp+78h] [rbp-2A0h]
			//   int32_t col; // [rsp+7Ch] [rbp-29Ch]
			//   int32_t cola; // [rsp+7Ch] [rbp-29Ch]
			//   int32_t colb; // [rsp+7Ch] [rbp-29Ch]
			//   int32_t v185; // [rsp+80h] [rbp-298h]
			//   unsigned int v186; // [rsp+80h] [rbp-298h]
			//   int v187; // [rsp+84h] [rbp-294h]
			//   int v188; // [rsp+84h] [rbp-294h]
			//   int v189; // [rsp+88h] [rbp-290h]
			//   ComputeBuffer *buffer; // [rsp+90h] [rbp-288h]
			//   ComputeBuffer *buffera; // [rsp+90h] [rbp-288h]
			//   int bufferb; // [rsp+90h] [rbp-288h]
			//   int bufferc; // [rsp+90h] [rbp-288h]
			//   RenderTargetIdentifier keyword; // [rsp+A0h] [rbp-278h] BYREF
			//   int v195; // [rsp+D0h] [rbp-248h]
			//   int v196; // [rsp+D4h] [rbp-244h]
			//   RenderTargetIdentifier rt; // [rsp+E0h] [rbp-238h] BYREF
			//   __int64 v198; // [rsp+110h] [rbp-208h]
			//   int32_t value[2]; // [rsp+118h] [rbp-200h] BYREF
			//   int v200; // [rsp+120h] [rbp-1F8h]
			//   int32_t v201; // [rsp+124h] [rbp-1F4h] BYREF
			//   int32_t level; // [rsp+128h] [rbp-1F0h]
			//   HashSet_1_UnityEngine_Vector3Int_ *v203; // [rsp+130h] [rbp-1E8h] BYREF
			//   int v204; // [rsp+138h] [rbp-1E0h]
			//   Vector4 v205; // [rsp+140h] [rbp-1D8h]
			//   __int128 v206; // [rsp+150h] [rbp-1C8h]
			//   Object *v207; // [rsp+160h] [rbp-1B8h] BYREF
			//   Object *v208; // [rsp+168h] [rbp-1B0h] BYREF
			//   NativeList_1_HG_Rendering_Runtime_HGTerrainRuntimeResources_DecalPerInstanceData_ v209; // [rsp+170h] [rbp-1A8h] BYREF
			//   Vector4 v210; // [rsp+180h] [rbp-198h]
			//   CommandBuffer *v211; // [rsp+190h] [rbp-188h]
			//   VirtualTextureRenderer *v212; // [rsp+198h] [rbp-180h]
			//   Object *v213; // [rsp+1A0h] [rbp-178h] BYREF
			//   unsigned __int64 v214; // [rsp+1A8h] [rbp-170h]
			//   __int128 v215; // [rsp+1B8h] [rbp-160h]
			//   HashSet_1_T_Enumerator_System_UInt32_ v216; // [rsp+1C8h] [rbp-150h] BYREF
			//   Il2CppException *ex; // [rsp+1E0h] [rbp-138h]
			//   HashSet_1_T_Enumerator_System_UInt32_ *v218; // [rsp+1E8h] [rbp-130h]
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ v219; // [rsp+1F0h] [rbp-128h] BYREF
			//   Vector4 val; // [rsp+210h] [rbp-108h] BYREF
			//   Vector4 v221; // [rsp+220h] [rbp-F8h] BYREF
			//   unsigned __int64 v222; // [rsp+230h] [rbp-E8h]
			//   Il2CppExceptionWrapper *v223; // [rsp+240h] [rbp-D8h] BYREF
			//   NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ v224; // [rsp+250h] [rbp-C8h] BYREF
			//   ValueTuple_3_Int32_Int32_Int32_ v225; // [rsp+260h] [rbp-B8h] BYREF
			//   ObjectPool_1_T_PooledObject_System_Collections_Generic_List_1_HG_Rendering_Runtime_HGRenderPipeline_RenderRequest_ v226; // [rsp+270h] [rbp-A8h] BYREF
			//   ScriptableRenderContext P1; // [rsp+328h] [rbp+10h] BYREF
			//   int32_t nameID; // [rsp+338h] [rbp+20h]
			// 
			//   P1.m_Ptr = renderContext.m_Ptr;
			//   v3 = this;
			//   v212 = this;
			//   if ( !byte_18D919734 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CommandBufferPool);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::CommandBuffer::SetComputeValueParam<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::CommandBuffer::SetComputeValueParam<UnityEngine::Vector4Int>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::UInt64 []>::TryGetValue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::Int32 []>::TryGetValue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::GenericPool<System::Collections::Generic::HashSet<int>>::Get);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::GenericPool<System::Collections::Generic::HashSet<int>>::Release);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::GenericPool<System::Collections::Generic::HashSet<int>>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::HashSet<int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<unsigned int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<unsigned int>::get_Item);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4Int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4Int>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::Add);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::AsArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::NativeList);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::get_Length);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&off_18D5192C0);
			//     byte_18D919734 = 1;
			//   }
			//   v210 = 0LL;
			//   v205 = 0LL;
			//   value[0] = 0;
			//   v209 = 0LL;
			//   v208 = 0LL;
			//   v213 = 0LL;
			//   v203 = 0LL;
			//   memset(&v216, 0, sizeof(v216));
			//   v207 = 0LL;
			//   v219 = 0LL;
			//   v201 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3368, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3368, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v167, v166);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_197(Patch, (Object *)v3, P1, 0LL);
			//     return;
			//   }
			//   m_renderQueue = v3.fields.m_renderQueue;
			//   if ( !m_renderQueue )
			//     sub_180B536AC(v5, v4);
			//   if ( !m_renderQueue.fields._size )
			//     return;
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::CommandBufferPool);
			//   v7 = UnityEngine::Rendering::CommandBufferPool::Get((String *)"TerrainVTBake", 0LL);
			//   v10 = v7;
			//   v211 = v7;
			//   if ( !v7 )
			//     sub_180B536AC(v9, v8);
			//   UnityEngine::Rendering::CommandBuffer::Clear(v7, 0LL);
			//   m_vtBakeCS = v3.fields.m_vtBakeCS;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//   static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//   nameID = static_fields._HGTerrainPerTerrain;
			//   terrainBakeDataBuffer_k__BackingField = v3.fields._terrainBakeDataBuffer_k__BackingField;
			//   buffer = terrainBakeDataBuffer_k__BackingField;
			//   if ( !terrainBakeDataBuffer_k__BackingField )
			//     sub_180B536AC(static_fields, v12);
			//   count = UnityEngine::ComputeBuffer::get_count(terrainBakeDataBuffer_k__BackingField, 0LL);
			//   if ( !v3.fields._terrainBakeDataBuffer_k__BackingField )
			//     sub_180B536AC(v16, v15);
			//   stride = UnityEngine::ComputeBuffer::get_stride(v3.fields._terrainBakeDataBuffer_k__BackingField, 0LL);
			//   if ( !v10 )
			//     sub_180B536AC(v19, v18);
			//   UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantComputeBufferParam(
			//     v10,
			//     m_vtBakeCS,
			//     nameID,
			//     buffer,
			//     0,
			//     count * stride,
			//     0LL);
			//   if ( v3.fields.m_enableCompression )
			//   {
			//     UnityEngine::Rendering::CommandBuffer::EnableKeyword(
			//       v10,
			//       v3.fields.m_vtBakeCS,
			//       &v3.fields.m_enableCompressKeywordCS,
			//       0LL);
			//     v21 = v3.fields.m_vtBakeCS;
			//     m_vtBakeMainKernel = v3.fields.m_vtBakeMainKernel;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     HGTerrainPhysicalBase = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainPhysicalBase;
			//     v24 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&rt, (Texture *)v3.fields.m_pageRt, 0LL);
			//     v25 = *(_OWORD *)&v24.m_BufferPointer;
			//     v26 = *(_QWORD *)&v24.m_DepthSlice;
			//     *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v24.m_Type;
			//     *(_OWORD *)&keyword.m_BufferPointer = v25;
			//     *(_QWORD *)&keyword.m_DepthSlice = v26;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//       v10,
			//       v21,
			//       m_vtBakeMainKernel,
			//       HGTerrainPhysicalBase,
			//       &keyword,
			//       0,
			//       0LL);
			//   }
			//   else
			//   {
			//     UnityEngine::Rendering::CommandBuffer::DisableKeyword(
			//       v10,
			//       v3.fields.m_vtBakeCS,
			//       &v3.fields.m_enableCompressKeywordCS,
			//       0LL);
			//   }
			//   v27 = v3.fields.m_vtBakeCS;
			//   v28 = v3.fields.m_vtBakeMainKernel;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//   HGTerrainColorVariationTex = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainColorVariationTex;
			//   v30 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&rt, (Texture *)v3.fields.m_colorVariationTex, 0LL);
			//   v31 = *(_OWORD *)&v30.m_BufferPointer;
			//   v32 = *(_QWORD *)&v30.m_DepthSlice;
			//   *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v30.m_Type;
			//   *(_OWORD *)&keyword.m_BufferPointer = v31;
			//   *(_QWORD *)&keyword.m_DepthSlice = v32;
			//   UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//     v10,
			//     v27,
			//     v28,
			//     HGTerrainColorVariationTex,
			//     &keyword,
			//     0LL);
			//   v33 = v3.fields.m_vtBakeCS;
			//   v34 = v3.fields.m_vtBakeMainKernel;
			//   HGTerrainControlMap = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainControlMap;
			//   v36 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&rt, (Texture *)v3.fields.m_splatControlMap, 0LL);
			//   v37 = *(_OWORD *)&v36.m_BufferPointer;
			//   v38 = *(_QWORD *)&v36.m_DepthSlice;
			//   *(_OWORD *)&rt.m_Type = *(_OWORD *)&v36.m_Type;
			//   *(_OWORD *)&rt.m_BufferPointer = v37;
			//   *(_QWORD *)&rt.m_DepthSlice = v38;
			//   UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(v10, v33, v34, HGTerrainControlMap, &rt, 0LL);
			//   v39 = v3.fields.m_vtBakeCS;
			//   v40 = v3.fields.m_vtBakeMainKernel;
			//   HGTerrainSplatIndexMap = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainSplatIndexMap;
			//   v42 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//           &keyword,
			//           (Texture *)v3.fields.m_splatIndexMap,
			//           0LL);
			//   v43 = *(_OWORD *)&v42.m_BufferPointer;
			//   v44 = *(_QWORD *)&v42.m_DepthSlice;
			//   *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v42.m_Type;
			//   *(_OWORD *)&keyword.m_BufferPointer = v43;
			//   *(_QWORD *)&keyword.m_DepthSlice = v44;
			//   UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(v10, v39, v40, HGTerrainSplatIndexMap, &keyword, 0LL);
			//   v45 = v3.fields.m_vtBakeCS;
			//   v46 = v3.fields.m_vtBakeMainKernel;
			//   HGTerrainSplats = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainSplats;
			//   v48 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//           &rt,
			//           (Texture *)v3.fields.m_splatsDiffuseArray,
			//           0LL);
			//   v49 = *(_OWORD *)&v48.m_BufferPointer;
			//   v50 = *(_QWORD *)&v48.m_DepthSlice;
			//   *(_OWORD *)&rt.m_Type = *(_OWORD *)&v48.m_Type;
			//   *(_OWORD *)&rt.m_BufferPointer = v49;
			//   *(_QWORD *)&rt.m_DepthSlice = v50;
			//   UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(v10, v45, v46, HGTerrainSplats, &rt, 0LL);
			//   v51 = v3.fields.m_vtBakeCS;
			//   v52 = v3.fields.m_vtBakeMainKernel;
			//   HGTerrainNormals = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainNormals;
			//   v54 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//           &keyword,
			//           (Texture *)v3.fields.m_splatsNormalArray,
			//           0LL);
			//   v55 = *(_OWORD *)&v54.m_BufferPointer;
			//   v56 = *(_QWORD *)&v54.m_DepthSlice;
			//   *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v54.m_Type;
			//   *(_OWORD *)&keyword.m_BufferPointer = v55;
			//   *(_QWORD *)&keyword.m_DepthSlice = v56;
			//   UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(v10, v51, v52, HGTerrainNormals, &keyword, 0LL);
			//   v57 = v3.fields.m_vtBakeCS;
			//   v58 = v3.fields.m_vtBakeMainKernel;
			//   HGTerrainTerrainNormalmapTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainTerrainNormalmapTexture;
			//   v60 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&rt, (Texture *)v3.fields.m_terrainNormalMap, 0LL);
			//   v61 = *(_OWORD *)&v60.m_BufferPointer;
			//   v62 = *(_QWORD *)&v60.m_DepthSlice;
			//   *(_OWORD *)&rt.m_Type = *(_OWORD *)&v60.m_Type;
			//   *(_OWORD *)&rt.m_BufferPointer = v61;
			//   *(_QWORD *)&rt.m_DepthSlice = v62;
			//   UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//     v10,
			//     v57,
			//     v58,
			//     HGTerrainTerrainNormalmapTexture,
			//     &rt,
			//     0LL);
			//   m_decalDiffuseTexArray = (Object_1 *)v3.fields.m_decalDiffuseTexArray;
			//   sub_180002C70(TypeInfo::UnityEngine::Object);
			//   if ( !UnityEngine::Object::op_Inequality(m_decalDiffuseTexArray, 0LL, 0LL) )
			//     goto LABEL_17;
			//   m_configuration = v3.fields.m_configuration;
			//   if ( !m_configuration )
			//     sub_180B536AC(m_decalInstanceInfo, v64);
			//   if ( m_configuration.fields.enableDecal )
			//   {
			//     LOBYTE(nameID) = 1;
			//     v67 = v3.fields.m_vtBakeCS;
			//     v68 = v3.fields.m_vtBakeMainKernel;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     HGTerrainDecalDiffuseTexArray = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainDecalDiffuseTexArray;
			//     v70 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//             &rt,
			//             (Texture *)v3.fields.m_decalDiffuseTexArray,
			//             0LL);
			//     v71 = *(_OWORD *)&v70.m_BufferPointer;
			//     v72 = *(_QWORD *)&v70.m_DepthSlice;
			//     *(_OWORD *)&rt.m_Type = *(_OWORD *)&v70.m_Type;
			//     *(_OWORD *)&rt.m_BufferPointer = v71;
			//     *(_QWORD *)&rt.m_DepthSlice = v72;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//       v10,
			//       v67,
			//       v68,
			//       HGTerrainDecalDiffuseTexArray,
			//       &rt,
			//       0LL);
			//     v73 = v3.fields.m_vtBakeCS;
			//     v74 = v3.fields.m_vtBakeMainKernel;
			//     HGTerrainDecalNormalMROTexArray = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainDecalNormalMROTexArray;
			//     v76 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//             &keyword,
			//             (Texture *)v3.fields.m_decalNormalMROTexArray,
			//             0LL);
			//     v77 = *(_OWORD *)&v76.m_BufferPointer;
			//     v78 = *(_QWORD *)&v76.m_DepthSlice;
			//     *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v76.m_Type;
			//     *(_OWORD *)&keyword.m_BufferPointer = v77;
			//     *(_QWORD *)&keyword.m_DepthSlice = v78;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//       v10,
			//       v73,
			//       v74,
			//       HGTerrainDecalNormalMROTexArray,
			//       &keyword,
			//       0LL);
			//     v79 = v3.fields.m_vtBakeCS;
			//     v80 = v3.fields.m_vtBakeMainKernel;
			//     HGTerrainHeightmap = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainHeightmap;
			//     v82 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//             &rt,
			//             (Texture *)v3.fields.m_terrainHeightmap,
			//             0LL);
			//     v83 = *(_OWORD *)&v82.m_BufferPointer;
			//     v84 = *(_QWORD *)&v82.m_DepthSlice;
			//     *(_OWORD *)&rt.m_Type = *(_OWORD *)&v82.m_Type;
			//     *(_OWORD *)&rt.m_BufferPointer = v83;
			//     *(_QWORD *)&rt.m_DepthSlice = v84;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(v10, v79, v80, HGTerrainHeightmap, &rt, 0LL);
			//   }
			//   else
			//   {
			// LABEL_17:
			//     LOBYTE(nameID) = 0;
			//   }
			//   for ( i = 0; ; i = v185 + 1 )
			//   {
			//     v185 = i;
			//     v86 = v3.fields.m_renderQueue;
			//     if ( !v86 )
			//       goto LABEL_119;
			//     if ( i >= v86.fields._size )
			//       break;
			//     key = (uint32_t)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                       (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)v3.fields.m_renderQueue,
			//                       i,
			//                       MethodInfo::System::Collections::Generic::List<unsigned int>::get_Item);
			//     v87 = HG::Rendering::Runtime::VirtualTextureRenderer::_UnpackNodeKey(&v225, key, 0LL);
			//     v214 = *(_QWORD *)&v87.Item1;
			//     Item3 = v87.Item3;
			//     v222 = v214;
			//     col = Item3;
			//     buffera = (ComputeBuffer *)HIDWORD(v214);
			//     v89 = v214;
			//     v90 = (float)((float)SHIDWORD(v214) / (float)(1 << (v214 & 0x1F))) * v212.fields.m_virtualToTerrain.y;
			//     *(float *)&v91 = (float)((float)Item3 / (float)(1 << (v214 & 0x1F))) * v3.fields.m_virtualToTerrain.x;
			//     *(float *)&v92 = (float)(1.0 / (float)(1 << (v214 & 0x1F))) * v212.fields.m_virtualToTerrain.y;
			//     v210.x = (float)(1.0 / (float)(1 << (v214 & 0x1F))) * v3.fields.m_virtualToTerrain.x;
			//     *(_QWORD *)&v210.y = __PAIR64__(v91, v92);
			//     v210.w = v90;
			//     if ( v3.fields.m_enableCompression )
			//     {
			//       *(_QWORD *)&v205.x = COERCE_UNSIGNED_INT((float)(i << 8));
			//       v205.z = (float)(i << 8);
			//       v205.w = 256.0;
			//     }
			//     else
			//     {
			//       if ( !v3.fields.m_nodeCacheLut )
			//         sub_180B536AC(v214 & 0x1F, v212);
			//       System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue(
			//         v3.fields.m_nodeCacheLut,
			//         key,
			//         value,
			//         MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue);
			//       v93 = (v3.fields.m_cachePageCountTotal - value[0]) / v3.fields.m_cachePageCountPerSlice;
			//       v94 = (float)(((v3.fields.m_cachePageCountTotal - value[0]) % v3.fields.m_cachePageCountPerSlice
			//                    / v3.fields.m_cacheColNumPerSlice) << 8);
			//       v205.x = (float)(((v3.fields.m_cachePageCountTotal - value[0])
			//                       % v3.fields.m_cachePageCountPerSlice
			//                       % v3.fields.m_cacheColNumPerSlice) << 8);
			//       v205.y = v94;
			//       v205.z = (float)v93;
			//       v205.w = 256.0;
			//       v95 = v3.fields.m_vtBakeCS;
			//       v174 = v3.fields.m_vtBakeMainKernel;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       keyd = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainPhysicalBase;
			//       v96 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//               &rt,
			//               (Texture *)v3.fields.m_physicalBaseRt,
			//               0LL);
			//       v97 = *(_OWORD *)&v96.m_BufferPointer;
			//       v98 = *(_QWORD *)&v96.m_DepthSlice;
			//       *(_OWORD *)&rt.m_Type = *(_OWORD *)&v96.m_Type;
			//       *(_OWORD *)&rt.m_BufferPointer = v97;
			//       *(_QWORD *)&rt.m_DepthSlice = v98;
			//       UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(v10, v95, v174, keyd, &rt, 0, 0LL);
			//       v99 = v3.fields.m_vtBakeCS;
			//       v175 = v3.fields.m_vtBakeMainKernel;
			//       keye = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainPhysicalNormal;
			//       v100 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                &keyword,
			//                (Texture *)v3.fields.m_physicalNormRt,
			//                0LL);
			//       v101 = *(_OWORD *)&v100.m_BufferPointer;
			//       v102 = *(_QWORD *)&v100.m_DepthSlice;
			//       *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v100.m_Type;
			//       *(_OWORD *)&keyword.m_BufferPointer = v101;
			//       *(_QWORD *)&keyword.m_DepthSlice = v102;
			//       UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(v10, v99, v175, keye, &keyword, 0, 0LL);
			//     }
			//     if ( !(_BYTE)nameID )
			//     {
			//       *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v3.fields.m_enableTerrainDecalCS.m_SpaceInfo.m_KeywordSpace;
			//       keyword.m_BufferPointer = *(void **)&v3.fields.m_enableTerrainDecalCS.m_Index;
			//       UnityEngine::Rendering::CommandBuffer::DisableComputeKeyword_Injected(
			//         v10,
			//         v3.fields.m_vtBakeCS,
			//         (LocalKeyword *)&keyword,
			//         0LL);
			//       goto LABEL_86;
			//     }
			//     value[1] = 2;
			//     Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::NativeList(
			//       &v209,
			//       (AllocatorManager_AllocatorHandle)2,
			//       MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::NativeList);
			//     v105 = 0;
			//     m_decalMaxLevel = v212.fields.m_decalMaxLevel;
			//     if ( v89 > v3.fields.m_decalMaxLevel )
			//     {
			//       v122 = (v89 - m_decalMaxLevel) & 0x1F;
			//       LODWORD(v198) = (int)buffera >> v122;
			//       level = Item3 >> v122;
			//       keyb = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(
			//                v3.fields.m_decalMaxLevel,
			//                (int)buffera >> v122,
			//                Item3 >> v122,
			//                0LL);
			//       v179 = v3.fields.m_indirectMaxLevel - v3.fields.m_decalMaxLevel;
			//       v177 = v179 & 0x1F;
			//       Length = 0;
			//       v109 = 1;
			//       v195 = 1;
			//       v129 = sub_182376F20(v125, v124, v126);
			//       v196 = (int)*(float *)&v129;
			//       v188 = (int)*(float *)&v129;
			//       if ( !v3.fields.m_decalBlockMaskLut )
			//         sub_180B536AC(v128, v127);
			//       if ( !System::Collections::Generic::Dictionary<unsigned int,System::Object>::TryGetValue(
			//               (Dictionary_2_System_UInt32_System_Object_ *)v3.fields.m_decalBlockMaskLut,
			//               keyb,
			//               &v208,
			//               MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::UInt64 []>::TryGetValue) )
			//         goto LABEL_76;
			//       if ( !v3.fields.m_decalNodeLut )
			//         sub_180B536AC(v130, v64);
			//       System::Collections::Generic::Dictionary<unsigned int,System::Object>::TryGetValue(
			//         (Dictionary_2_System_UInt32_System_Object_ *)v3.fields.m_decalNodeLut,
			//         keyb,
			//         &v213,
			//         MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::Int32 []>::TryGetValue);
			//       v131 = (v3.fields.m_indirectMaxLevel - v214) & 0x1F;
			//       v132 = ((_DWORD)buffera << v131) - ((_DWORD)v198 << (v179 & 0x1F));
			//       bufferc = v132;
			//       colb = (col << v131) - (level << (v179 & 0x1F));
			//       v133 = 1 << v131;
			//       v180 = 1 << v131;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::GenericPool<System::Collections::Generic::HashSet<int>>);
			//       UnityEngine::Rendering::ListPool<HG::Rendering::Runtime::HGRenderPipeline::RenderRequest>::Get(
			//         &v226,
			//         (List_1_HG_Rendering_Runtime_HGRenderPipeline_RenderRequest_ **)&v203,
			//         MethodInfo::UnityEngine::Rendering::GenericPool<System::Collections::Generic::HashSet<int>>::Get);
			//       if ( !v203 )
			//         sub_180B536AC(v135, v134);
			//       System::Collections::Generic::HashSet<UnityEngine::Vector3Int>::Clear(
			//         v203,
			//         MethodInfo::System::Collections::Generic::HashSet<int>::Clear);
			//       v138 = 0;
			//       keyc = 0;
			//       if ( v133 > 0 )
			//       {
			//         v136 = (unsigned int)v133;
			//         do
			//         {
			//           v139 = colb + ((v138 + v132) << v177);
			//           v198 = v136;
			//           do
			//           {
			//             v137 = v139 & 0x3F;
			//             v140 = 1LL << v137;
			//             for ( j = 0; ; ++j )
			//             {
			//               if ( !v208 )
			//                 sub_180B536AC(v137, v136);
			//               if ( j >= SLODWORD(v208[1].monitor) )
			//                 break;
			//               if ( (unsigned int)j >= LODWORD(v208[1].monitor) )
			//                 sub_180070270(v137, v136);
			//               if ( (v140 & (__int64)*(&v208[2].klass + j)) != 0 )
			//               {
			//                 if ( !v203 )
			//                   sub_180B536AC(v137, v136);
			//                 System::Collections::Generic::HashSet<int>::Add(
			//                   (HashSet_1_System_Int32_ *)v203,
			//                   j,
			//                   MethodInfo::System::Collections::Generic::HashSet<int>::Add);
			//               }
			//             }
			//             LOBYTE(v139) = v139 + 1;
			//             --v198;
			//           }
			//           while ( v198 );
			//           v138 = keyc + 1;
			//           keyc = v138;
			//           v132 = bufferc;
			//           v136 = (unsigned int)v180;
			//         }
			//         while ( v138 < v180 );
			//         v3 = this;
			//         v10 = v211;
			//       }
			//       if ( !v203 )
			//         sub_180B536AC(v137, v136);
			//       System::Collections::Generic::HashSet<int>::GetEnumerator(
			//         (HashSet_1_T_Enumerator_System_Int32_ *)&keyword,
			//         (HashSet_1_System_Int32_ *)v203,
			//         MethodInfo::System::Collections::Generic::HashSet<int>::GetEnumerator);
			//       *(_OWORD *)&v216._set = *(_OWORD *)&keyword.m_Type;
			//       *(_QWORD *)&v216._current = keyword.m_BufferPointer;
			//       ex = 0LL;
			//       v218 = &v216;
			//       try
			//       {
			//         while ( System::Collections::Generic::HashSet_1_T_::Enumerator<unsigned int>::MoveNext(
			//                   &v216,
			//                   MethodInfo::System::Collections::Generic::HashSet_1_T_::Enumerator<int>::MoveNext) )
			//         {
			//           if ( !v213 )
			//             sub_1802DC2C8(0LL, v142);
			//           if ( v216._current >= LODWORD(v213[1].monitor) )
			//             sub_180070260(v213, v142, v143, v144);
			//           if ( !v3.fields.m_decalInstanceData )
			//             sub_1802DC2C8(v213, v142);
			//           v145 = MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::Add;
			//           v146 = (HGTerrainRuntimeResources_DecalPerInstanceData *)sub_1804440E4(
			//                                                                      v3.fields.m_decalInstanceData,
			//                                                                      *((int *)&v213[2].klass + (int)v216._current));
			//           Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::Add(
			//             &v209,
			//             v146,
			//             v145);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v223 )
			//       {
			//         ex = v223.ex;
			//         if ( ex )
			//           sub_18000F780(ex);
			//         v3 = this;
			//         v10 = v211;
			//         v109 = 1;
			//         v196 = v188;
			// LABEL_75:
			//         v147 = (Object *)v203;
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::GenericPool<System::Collections::Generic::HashSet<int>>);
			//         UnityEngine::Rendering::UnsafeGenericPool<System::Object>::Release(
			//           v147,
			//           MethodInfo::UnityEngine::Rendering::GenericPool<System::Collections::Generic::HashSet<int>>::Release);
			//         Length = Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::get_Length(
			//                    (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v209,
			//                    MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::get_Length);
			//         v105 = Length != 0;
			// LABEL_76:
			//         m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3.fields.m_decalInstanceInfo;
			//         v206 = COERCE_UNSIGNED_INT((float)Length);
			//         if ( !m_decalInstanceInfo )
			//           goto LABEL_119;
			//         *(_OWORD *)&keyword.m_Type = v206;
			//         sub_18004D910(m_decalInstanceInfo, 0LL, &keyword);
			//         goto LABEL_78;
			//       }
			//       v109 = v195;
			//       goto LABEL_75;
			//     }
			//     v107 = v89 + 2;
			//     if ( v89 + 2 >= m_decalMaxLevel )
			//       v107 = v212.fields.m_decalMaxLevel;
			//     level = v107;
			//     v108 = ((_BYTE)v107 - (_BYTE)v89) & 0x1F;
			//     v109 = 1 << v108;
			//     v195 = 1 << v108;
			//     bufferb = (_DWORD)buffera << v108;
			//     v110 = Item3 << v108;
			//     cola = v110;
			//     v111 = 0;
			//     v204 = 0;
			//     v187 = 0;
			//     v112 = sub_182376F20(v108, v103, v104);
			//     v196 = (int)*(float *)&v112;
			//     v113 = 0;
			//     keya = 0;
			//     if ( v109 > 0 )
			//     {
			//       v114 = -v110;
			//       do
			//       {
			//         v189 = 0;
			//         LODWORD(m_decalInstanceInfo) = cola;
			//         v176 = cola;
			//         LODWORD(v64) = v113 + bufferb;
			//         v178 = v113 + bufferb;
			//         do
			//         {
			//           LODWORD(v198) = v114 + (_DWORD)m_decalInstanceInfo;
			//           v115 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(
			//                    level,
			//                    v64,
			//                    (int32_t)m_decalInstanceInfo,
			//                    0LL);
			//           m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3.fields.m_decalNodeLut;
			//           if ( !m_decalInstanceInfo )
			//             goto LABEL_119;
			//           if ( System::Collections::Generic::Dictionary<unsigned int,System::Object>::TryGetValue(
			//                  m_decalInstanceInfo,
			//                  v115,
			//                  &v207,
			//                  MethodInfo::System::Collections::Generic::Dictionary<unsigned int,System::Int32 []>::TryGetValue) )
			//           {
			//             v118 = v207;
			//             v119 = 0;
			//             v200 = 0;
			//             if ( !v207 )
			//               goto LABEL_119;
			//             while ( (signed int)v119 < SLODWORD(v118[1].monitor) )
			//             {
			//               if ( !v118 )
			//                 goto LABEL_119;
			//               if ( v119 >= LODWORD(v118[1].monitor) )
			//                 sub_180070260(m_decalInstanceInfo, v64, v116, v117);
			//               m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3.fields.m_decalInstanceData;
			//               if ( !m_decalInstanceInfo )
			//                 goto LABEL_119;
			//               v120 = MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::Add;
			//               v121 = (HGTerrainRuntimeResources_DecalPerInstanceData *)sub_1804440E4(
			//                                                                          m_decalInstanceInfo,
			//                                                                          *((int *)&v118[2].klass + (int)v119));
			//               Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::Add(
			//                 &v209,
			//                 v121,
			//                 v120);
			//               v119 = ++v200;
			//             }
			//             if ( !v207 )
			//               goto LABEL_119;
			//             v111 = LODWORD(v207[1].monitor) + v204;
			//             v204 = v111;
			//             v109 = v195;
			//           }
			//           m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3.fields.m_decalInstanceInfo;
			//           *(float *)&v215 = (float)v111;
			//           *(_QWORD *)((char *)&v215 + 4) = COERCE_UNSIGNED_INT((float)v187);
			//           HIDWORD(v215) = 0;
			//           if ( !m_decalInstanceInfo )
			//             goto LABEL_119;
			//           *(_OWORD *)&keyword.m_Type = v215;
			//           sub_18004D910(m_decalInstanceInfo, (int)v198, &keyword);
			//           v187 = v111;
			//           ++v189;
			//           m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)(unsigned int)++v176;
			//           v64 = v178;
			//         }
			//         while ( v189 < v109 );
			//         v113 = keya + 1;
			//         keya = v113;
			//         v114 += v109;
			//       }
			//       while ( v113 < v109 );
			//     }
			//     v105 = v111 > 0;
			// LABEL_78:
			//     if ( v105 )
			//     {
			//       m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3.fields.m_decalInstanceInfo;
			//       if ( !m_decalInstanceInfo )
			//         goto LABEL_119;
			//       *(float *)(sub_18003EB40(m_decalInstanceInfo, 0LL) + 8) = (float)v109;
			//       m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3.fields.m_decalInstanceInfo;
			//       if ( !m_decalInstanceInfo )
			//         goto LABEL_119;
			//       v148 = (float)v196;
			//       *(float *)(sub_18003EB40(m_decalInstanceInfo, 0LL) + 12) = v148;
			//       v149 = v3.fields.m_vtBakeCS;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       if ( !v10 )
			//         goto LABEL_119;
			//       UnityEngine::Rendering::CommandBuffer::SetComputeVectorArrayParam(
			//         v10,
			//         v149,
			//         TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainDecalInstanceInfos,
			//         v3.fields.m_decalInstanceInfo,
			//         0LL);
			//       v150 = v3.fields.m_vtBakeCS;
			//       HGTerrainDecalInstanceData = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainDecalInstanceData;
			//       Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiAgentData>::AsArray(
			//         &v224,
			//         (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&v209,
			//         MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::AsArray);
			//       *(NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&keyword.m_Type = v224;
			//       UnityEngine::Rendering::CommandBuffer::SetComputeValueParam<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>(
			//         v10,
			//         v150,
			//         HGTerrainDecalInstanceData,
			//         (NativeArray_1_HG_Rendering_Runtime_HGTerrainRuntimeResources_DecalPerInstanceData_ *)&keyword,
			//         MethodInfo::UnityEngine::Rendering::CommandBuffer::SetComputeValueParam<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>);
			//       *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v3.fields.m_enableTerrainDecalCS.m_SpaceInfo.m_KeywordSpace;
			//       keyword.m_BufferPointer = *(void **)&v3.fields.m_enableTerrainDecalCS.m_Index;
			//       UnityEngine::Rendering::CommandBuffer::EnableComputeKeyword_Injected(
			//         v10,
			//         v3.fields.m_vtBakeCS,
			//         (LocalKeyword *)&keyword,
			//         0LL);
			//     }
			//     else
			//     {
			//       if ( !v10 )
			//         goto LABEL_119;
			//       *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v3.fields.m_enableTerrainDecalCS.m_SpaceInfo.m_KeywordSpace;
			//       keyword.m_BufferPointer = *(void **)&v3.fields.m_enableTerrainDecalCS.m_Index;
			//       UnityEngine::Rendering::CommandBuffer::DisableComputeKeyword_Injected(
			//         v10,
			//         v3.fields.m_vtBakeCS,
			//         (LocalKeyword *)&keyword,
			//         0LL);
			//     }
			//     Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::Dispose(
			//       &v209,
			//       MethodInfo::Unity::Collections::NativeList<HG::Rendering::Runtime::HGTerrainRuntimeResources::DecalPerInstanceData>::Dispose);
			// LABEL_86:
			//     v152 = v3.fields.m_vtBakeCS;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     HGTerrainUVTransform = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainUVTransform;
			//     val = v210;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeVectorParam_Injected(v10, v152, HGTerrainUVTransform, &val, 0LL);
			//     HGTerrainRTOffset = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainRTOffset;
			//     v221 = v205;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeVectorParam_Injected(
			//       v10,
			//       v3.fields.m_vtBakeCS,
			//       HGTerrainRTOffset,
			//       &v221,
			//       0LL);
			//     UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//       v10,
			//       v3.fields.m_vtBakeCS,
			//       v3.fields.m_vtBakeMainKernel,
			//       32,
			//       32,
			//       1,
			//       0LL);
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//   UnityEngine::Rendering::ScriptableRenderContext::ExecuteCommandBuffer(&P1, v10, 0LL);
			//   if ( v3.fields.m_enableCompression )
			//   {
			//     UnityEngine::Rendering::CommandBuffer::Clear(v10, 0LL);
			//     Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::EntityCommandBufferV2::VirtualEntityMap>::NativeArray(
			//       &v219,
			//       1,
			//       Allocator__Enum_Temp,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4Int>::NativeArray);
			//     LODWORD(v206) = 64;
			//     DWORD1(v206) = v3.fields._vtMaxPagePerFrame_k__BackingField;
			//     *((_QWORD *)&v206 + 1) = 4096LL;
			//     *(_OWORD *)v219.m_Buffer = v206;
			//     v155 = (Vector4)v219;
			//     val = (Vector4)v219;
			//     m_vtCompressCS = v3.fields.m_vtCompressCS;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     v221 = v155;
			//     UnityEngine::Rendering::CommandBuffer::SetComputeValueParam<UnityEngine::Vector4Int>(
			//       v10,
			//       m_vtCompressCS,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainCompressCacheParam0,
			//       (NativeArray_1_UnityEngine_Vector4Int_ *)&v221,
			//       MethodInfo::UnityEngine::Rendering::CommandBuffer::SetComputeValueParam<UnityEngine::Vector4Int>);
			//     v157 = v3.fields.m_vtCompressCS;
			//     m_vtCompressMainKernel = v3.fields.m_vtCompressMainKernel;
			//     LODWORD(m_vtCompressCS) = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainCommonInput;
			//     rt = *UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&keyword, (Texture *)v3.fields.m_pageRt, 0LL);
			//     UnityEngine::Rendering::CommandBuffer::Internal_SetComputeTextureParam(
			//       v10,
			//       v157,
			//       m_vtCompressMainKernel,
			//       (int32_t)m_vtCompressCS,
			//       &rt,
			//       0,
			//       RenderTextureSubElement__Enum_Default,
			//       -1,
			//       0LL);
			//     UnityEngine::Rendering::CommandBuffer::Internal_SetComputeBufferParam(
			//       v10,
			//       v3.fields.m_vtCompressCS,
			//       v3.fields.m_vtCompressMainKernel,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainCommonOutput,
			//       v3.fields.m_pageBuffer,
			//       0,
			//       -1,
			//       0LL);
			//     UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//       v10,
			//       v3.fields.m_vtCompressCS,
			//       v3.fields.m_vtCompressMainKernel,
			//       v3.fields.m_compressCSGroupSize.m_X,
			//       v3.fields.m_compressCSGroupSize.m_Y,
			//       1,
			//       0LL);
			//     v181 = v3.fields._vtMaxPagePerFrame_k__BackingField << 16;
			//     v159 = 0;
			//     v186 = 0;
			//     v64 = 0LL;
			//     m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3.fields.m_renderQueue;
			//     if ( !m_decalInstanceInfo )
			// LABEL_119:
			//       sub_1802DC2C8(m_decalInstanceInfo, v64);
			//     nameID = 0;
			//     while ( (int)v64 < SLODWORD(m_decalInstanceInfo.fields._entries) )
			//     {
			//       m_nodeCacheLut = v3.fields.m_nodeCacheLut;
			//       m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3.fields.m_renderQueue;
			//       if ( m_decalInstanceInfo )
			//       {
			//         Item = System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
			//                  (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)m_decalInstanceInfo,
			//                  v159,
			//                  MethodInfo::System::Collections::Generic::List<unsigned int>::get_Item);
			//         if ( m_nodeCacheLut )
			//         {
			//           System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue(
			//             m_nodeCacheLut,
			//             *(_DWORD *)&Item,
			//             &v201,
			//             MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue);
			//           layer = (v3.fields.m_cachePageCountTotal - v201) / v3.fields.m_cachePageCountPerSlice;
			//           v163 = ((v3.fields.m_cachePageCountTotal - v201)
			//                 % v3.fields.m_cachePageCountPerSlice
			//                 % v3.fields.m_cacheColNumPerSlice) << 8;
			//           v164 = ((v3.fields.m_cachePageCountTotal - v201) % v3.fields.m_cachePageCountPerSlice
			//                 / v3.fields.m_cacheColNumPerSlice) << 8;
			//           UnityEngine::Rendering::CommandBuffer::CopyBufferToImage(
			//             v10,
			//             v3.fields.m_pageBuffer,
			//             nameID,
			//             (Texture *)v3.fields.m_physicalBaseTex,
			//             v163,
			//             v164,
			//             0,
			//             256,
			//             256,
			//             1,
			//             0,
			//             layer,
			//             0LL);
			//           UnityEngine::Rendering::CommandBuffer::CopyBufferToImage(
			//             v10,
			//             v3.fields.m_pageBuffer,
			//             v181 + nameID,
			//             (Texture *)v3.fields.m_physicalNormTex,
			//             v163,
			//             v164,
			//             0,
			//             256,
			//             256,
			//             1,
			//             0,
			//             layer,
			//             0LL);
			//           v159 = v186 + 1;
			//           v186 = v159;
			//           nameID += 4096;
			//           v64 = v159;
			//           m_decalInstanceInfo = (Dictionary_2_System_UInt32_System_Object_ *)v3.fields.m_renderQueue;
			//           if ( m_decalInstanceInfo )
			//             continue;
			//         }
			//       }
			//       goto LABEL_119;
			//     }
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     UnityEngine::Rendering::ScriptableRenderContext::ExecuteCommandBuffer(&P1, v10, 0LL);
			//     Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
			//       (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&val,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4Int>::Dispose);
			//   }
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::CommandBufferPool);
			//   UnityEngine::Rendering::CommandBufferPool::Release(v10, 0LL);
			// }
			// 
		}

		private void _UpdateClipmapTexture(Texture2D indirectTex)
		{
			// // Void _UpdateClipmapTexture(Texture2D)
			// void HG::Rendering::Runtime::VirtualTextureRenderer::_UpdateClipmapTexture(
			//         VirtualTextureRenderer *this,
			//         Texture2D *indirectTex,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   char v7; // dl
			//   __int64 v8; // rcx
			//   int v9; // r8d
			//   char v10; // dl
			//   __int64 v11; // rcx
			//   int v12; // r8d
			//   int32_t v13; // edx
			//   int32_t v14; // r8d
			//   int v15; // r13d
			//   int32_t v16; // r14d
			//   int32_t v17; // r15d
			//   int v18; // esi
			//   int32_t m_indirectLevel; // r12d
			//   __int64 v20; // rcx
			//   int v21; // ebx
			//   char v22; // dl
			//   int v23; // r8d
			//   int32_t v24; // r10d
			//   int v25; // r9d
			//   int32_t v26; // r12d
			//   int32_t v27; // r14d
			//   __int64 v28; // rdx
			//   int32_t v29; // r15d
			//   int32_t v30; // ebx
			//   Dictionary_2_System_UInt32_System_Int32_ *m_nodeCacheLut; // r13
			//   uint32_t v32; // eax
			//   uint32_t v33; // edx
			//   Dictionary_2_System_UInt32_System_Int32_ *v34; // r13
			//   uint32_t v35; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t col; // [rsp+20h] [rbp-98h]
			//   int v38; // [rsp+24h] [rbp-94h]
			//   int32_t v39; // [rsp+28h] [rbp-90h]
			//   int32_t v40; // [rsp+2Ch] [rbp-8Ch]
			//   int32_t v41; // [rsp+30h] [rbp-88h]
			//   int32_t v42; // [rsp+34h] [rbp-84h]
			//   int v43; // [rsp+38h] [rbp-80h]
			//   int v44; // [rsp+3Ch] [rbp-7Ch]
			//   int v45; // [rsp+40h] [rbp-78h]
			//   int32_t v46; // [rsp+44h] [rbp-74h]
			//   __int64 v47; // [rsp+48h] [rbp-70h]
			//   Void *v48; // [rsp+50h] [rbp-68h]
			//   Void *v49; // [rsp+58h] [rbp-60h]
			//   NativeArray_1_System_UInt32_ v50; // [rsp+60h] [rbp-58h] BYREF
			//   int32_t value; // [rsp+D8h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919735 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafePtr<unsigned int>);
			//     sub_18003C530(&MethodInfo::UnityEngine::Texture2D::GetRawTextureData<unsigned int>);
			//     byte_18D919735 = 1;
			//   }
			//   value = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3378, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3378, 0LL);
			//     if ( !Patch )
			//       goto LABEL_32;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)indirectTex,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !indirectTex )
			//       goto LABEL_32;
			//     UnityEngine::Texture2D::GetRawTextureData<unsigned int>(
			//       &v50,
			//       indirectTex,
			//       MethodInfo::UnityEngine::Texture2D::GetRawTextureData<unsigned int>);
			//     sub_182592070(v8, v7, v9);
			//     sub_182592070(v11, v10, v12);
			//     v15 = 0;
			//     v43 = 0;
			//     v38 = 0;
			//     v16 = 0;
			//     v17 = 0;
			//     v48 = 0LL;
			//     v18 = this.fields.m_indirectLevel - 1;
			//     if ( v18 >= 0 )
			//     {
			//       m_indirectLevel = this.fields.m_indirectLevel;
			//       v42 = m_indirectLevel;
			//       do
			//       {
			//         v49 = &v50.m_Buffer[4 * this.fields.m_indirectMaxArea * v18];
			//         v20 = v18 & 0x1F;
			//         v21 = 1 << v20;
			//         col = sub_182592070(v20, v13, v14);
			//         v13 = sub_182592070((unsigned int)(this.fields.m_indirectHalfWidth * v21), v22, v23);
			//         v24 = col;
			//         v46 = v13;
			//         if ( v18 == this.fields.m_indirectLevel - 1 )
			//         {
			//           v25 = v38;
			//         }
			//         else
			//         {
			//           v48 = &v50.m_Buffer[4 * this.fields.m_indirectMaxArea * m_indirectLevel];
			//           v25 = col - 2 * v17;
			//           v15 = v13 - 2 * v16;
			//           v38 = v25;
			//           v43 = v15;
			//         }
			//         v26 = 0;
			//         if ( this.fields.m_indirectWidth > 0 )
			//         {
			//           v27 = v13;
			//           v44 = v15 - v13;
			//           do
			//           {
			//             v14 = 0;
			//             v28 = 0LL;
			//             v41 = 0;
			//             v47 = 0LL;
			//             if ( this.fields.m_indirectWidth > 0 )
			//             {
			//               v29 = v24;
			//               v45 = v25 - v24;
			//               do
			//               {
			//                 v30 = this.fields.m_indirectMaxLevel - v18;
			//                 v39 = v27;
			//                 v40 = v29;
			//                 if ( v29 >= 0 && v27 >= 0 && v29 < 1 << (v30 & 0x1F) && v27 < 1 << (v30 & 0x1F) )
			//                 {
			//                   m_nodeCacheLut = this.fields.m_nodeCacheLut;
			//                   v32 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(v30, v27, v29, 0LL);
			//                   if ( !m_nodeCacheLut )
			//                     goto LABEL_32;
			//                   if ( System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue(
			//                          m_nodeCacheLut,
			//                          v32,
			//                          &value,
			//                          MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue) )
			//                   {
			// LABEL_24:
			//                     v33 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackIndirectParam(this, value, v30, 0LL);
			//                   }
			//                   else
			//                   {
			//                     if ( v18 == this.fields.m_indirectLevel - 1 )
			//                     {
			//                       while ( 1 )
			//                       {
			//                         --v30;
			//                         v34 = this.fields.m_nodeCacheLut;
			//                         v40 >>= 1;
			//                         v39 >>= 1;
			//                         v35 = HG::Rendering::Runtime::VirtualTextureRenderer::_PackNodeKey(v30, v39, v40, 0LL);
			//                         if ( !v34 )
			//                           break;
			//                         if ( System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue(
			//                                v34,
			//                                v35,
			//                                &value,
			//                                MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::TryGetValue) )
			//                         {
			//                           goto LABEL_24;
			//                         }
			//                       }
			// LABEL_32:
			//                       sub_180B536AC(v6, v5);
			//                     }
			//                     v33 = *(_DWORD *)&v48[4 * ((v29 + v45) / 2)
			//                                         + 4 * (__int64)(this.fields.m_indirectMaxWidth * ((v27 + v44) / 2))];
			//                   }
			//                   v14 = v41;
			//                   *(_DWORD *)&v49[4 * v47 + 4 * this.fields.m_indirectMaxWidth * v26] = v33;
			//                   v28 = v47;
			//                 }
			//                 ++v14;
			//                 ++v28;
			//                 ++v29;
			//                 v41 = v14;
			//                 v47 = v28;
			//               }
			//               while ( v14 < this.fields.m_indirectWidth );
			//             }
			//             v25 = v38;
			//             ++v26;
			//             v24 = col;
			//             ++v27;
			//           }
			//           while ( v26 < this.fields.m_indirectWidth );
			//           v13 = v46;
			//         }
			//         v16 = v13;
			//         v17 = col;
			//         m_indirectLevel = v42 - 1;
			//         --v18;
			//         v15 = v43;
			//         --v42;
			//       }
			//       while ( v18 >= 0 );
			//     }
			//     UnityEngine::Texture2D::Apply(indirectTex, 0, 0, 0LL);
			//   }
			// }
			// 
		}

		private bool _RefreshIndirectTextureParams()
		{
			// // Boolean _RefreshIndirectTextureParams()
			// bool HG::Rendering::Runtime::VirtualTextureRenderer::_RefreshIndirectTextureParams(
			//         VirtualTextureRenderer *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   HGTerrainConfiguration *m_configuration; // rax
			//   int32_t vtClipmapBaseOffset; // r8d
			//   int32_t v7; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3351, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3351, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// LABEL_7:
			//     sub_180B536AC(v4, v3);
			//   }
			//   m_configuration = this.fields.m_configuration;
			//   if ( !m_configuration )
			//     goto LABEL_7;
			//   vtClipmapBaseOffset = m_configuration.fields.vtClipmapBaseOffset;
			//   if ( vtClipmapBaseOffset == this.fields.m_indirectOffset )
			//     return 0;
			//   this.fields.m_indirectOffset = vtClipmapBaseOffset;
			//   v7 = 8 << (vtClipmapBaseOffset & 0x1F);
			//   this.fields.m_indirectWidth = v7;
			//   this.fields.m_indirectHalfWidth = v7 / 2;
			//   this.fields.m_indirectLevel = this.fields.m_indirectBaseLevel - vtClipmapBaseOffset;
			//   return 1;
			// }
			// 
			return default(bool);
		}

		private bool _RefreshPhysicalCacheParams()
		{
			// // Boolean _RefreshPhysicalCacheParams()
			// bool HG::Rendering::Runtime::VirtualTextureRenderer::_RefreshPhysicalCacheParams(
			//         VirtualTextureRenderer *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   LRUCache *m_lruCache; // rcx
			//   HGTerrainConfiguration *m_configuration; // rax
			//   int32_t vtCacheSliceWidth; // ebp
			//   int32_t vtCacheSliceHeight; // esi
			//   int32_t vtCacheSliceCount; // edi
			//   int32_t v10; // eax
			//   int32_t v11; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919736 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Clear);
			//     byte_18D919736 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3352, 0LL) )
			//   {
			//     m_configuration = this.fields.m_configuration;
			//     if ( m_configuration )
			//     {
			//       vtCacheSliceWidth = m_configuration.fields.vtCacheSliceWidth;
			//       vtCacheSliceHeight = m_configuration.fields.vtCacheSliceHeight;
			//       vtCacheSliceCount = m_configuration.fields.vtCacheSliceCount;
			//       if ( vtCacheSliceWidth == this.fields.m_cacheSliceWidth
			//         && vtCacheSliceHeight == this.fields.m_cacheSliceHeight
			//         && vtCacheSliceCount == this.fields.m_cacheSliceCount )
			//       {
			//         return 0;
			//       }
			//       HG::Rendering::Runtime::VirtualTextureRenderer::_DestroyPhysicalCacheResources(this, 0LL);
			//       this.fields.m_cacheSliceWidth = vtCacheSliceWidth;
			//       this.fields.m_cacheSliceHeight = vtCacheSliceHeight;
			//       this.fields.m_cacheSliceCount = vtCacheSliceCount;
			//       this.fields.m_cacheColNumPerSlice = vtCacheSliceWidth / 256;
			//       v3 = (unsigned int)(vtCacheSliceHeight >> 31);
			//       LODWORD(v3) = vtCacheSliceHeight % 256;
			//       this.fields.m_cacheRowNumPerSlice = vtCacheSliceHeight / 256;
			//       v10 = vtCacheSliceWidth / 256 * (vtCacheSliceHeight / 256);
			//       m_lruCache = this.fields.m_lruCache;
			//       this.fields.m_cachePageCountPerSlice = v10;
			//       v11 = vtCacheSliceCount * v10;
			//       this.fields.m_cachePageCountTotal = v11;
			//       if ( m_lruCache )
			//       {
			//         HG::Rendering::Runtime::LRUCache::Reset(m_lruCache, v11, 0LL);
			//         m_lruCache = (LRUCache *)this.fields.m_nodeCacheLut;
			//         if ( m_lruCache )
			//         {
			//           System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RegionMapVoxelInfo>::Clear(
			//             (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)m_lruCache,
			//             MethodInfo::System::Collections::Generic::Dictionary<unsigned int,int>::Clear);
			//           HG::Rendering::Runtime::VirtualTextureRenderer::_AllocatePhysicalCacheResources(this, 0LL);
			//           return 1;
			//         }
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(m_lruCache, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3352, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		private void _DestroyPhysicalCacheResources()
		{
			// // Void _DestroyPhysicalCacheResources()
			// void HG::Rendering::Runtime::VirtualTextureRenderer::_DestroyPhysicalCacheResources(
			//         VirtualTextureRenderer *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   RenderTexture *m_physicalBaseRt; // rcx
			//   Object_1 *m_physicalBaseTex; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919737 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D919737 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3353, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3353, 0LL);
			//     if ( !Patch )
			//       goto LABEL_12;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( !this.fields.m_enableCompression )
			//     {
			//       m_physicalBaseRt = this.fields.m_physicalBaseRt;
			//       if ( m_physicalBaseRt )
			//       {
			//         UnityEngine::RenderTexture::Release(m_physicalBaseRt, 0LL);
			//         m_physicalBaseRt = this.fields.m_physicalNormRt;
			//         if ( m_physicalBaseRt )
			//         {
			//           UnityEngine::RenderTexture::Release(m_physicalBaseRt, 0LL);
			//           return;
			//         }
			//       }
			// LABEL_12:
			//       sub_180B536AC(m_physicalBaseRt, v3);
			//     }
			//     m_physicalBaseTex = (Object_1 *)this.fields.m_physicalBaseTex;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     HG::Rendering::Runtime::HGUtils::Destroy(m_physicalBaseTex, 0LL);
			//     HG::Rendering::Runtime::HGUtils::Destroy((Object_1 *)this.fields.m_physicalNormTex, 0LL);
			//     m_physicalBaseRt = this.fields.m_pageRt;
			//     if ( !m_physicalBaseRt )
			//       goto LABEL_12;
			//     UnityEngine::RenderTexture::Release(m_physicalBaseRt, 0LL);
			//     m_physicalBaseRt = (RenderTexture *)this.fields.m_pageBuffer;
			//     if ( !m_physicalBaseRt )
			//       goto LABEL_12;
			//     UnityEngine::ComputeBuffer::Dispose((ComputeBuffer *)m_physicalBaseRt, 0LL);
			//   }
			// }
			// 
		}

		private void _AllocatePhysicalCacheResources()
		{
			// // Void _AllocatePhysicalCacheResources()
			// void HG::Rendering::Runtime::VirtualTextureRenderer::_AllocatePhysicalCacheResources(
			//         VirtualTextureRenderer *this,
			//         MethodInfo *method)
			// {
			//   int32_t m_cacheSliceWidth; // esi
			//   int32_t m_cacheSliceHeight; // ebp
			//   RenderTexture *v5; // rax
			//   RenderTexture *v6; // rdx
			//   RenderTexture *m_physicalBaseRt; // rcx
			//   RenderTexture *v8; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   HGCamera *v11; // r9
			//   RenderTextureDescriptor *descriptor; // rax
			//   int32_t memoryless_k__BackingField; // esi
			//   RenderTexture *v14; // rax
			//   RenderTexture *v15; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v16; // rdx
			//   PassConstructorID__Enum__Array *v17; // r8
			//   HGCamera *v18; // r9
			//   GraphicsFormat__Enum PlatformCompressionFormat; // esi
			//   int32_t v20; // ebp
			//   int32_t v21; // r14d
			//   int32_t m_cacheSliceCount; // r15d
			//   Texture2DArray *v23; // rax
			//   Texture *v24; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v25; // rdx
			//   PassConstructorID__Enum__Array *v26; // r8
			//   HGCamera *v27; // r9
			//   int32_t v28; // ebp
			//   int32_t v29; // r14d
			//   int32_t v30; // r15d
			//   Texture2DArray *v31; // rax
			//   Texture *v32; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v33; // rdx
			//   PassConstructorID__Enum__Array *v34; // r8
			//   HGCamera *v35; // r9
			//   int32_t vtMaxPagePerFrame_k__BackingField; // esi
			//   RenderTexture *v37; // rax
			//   RenderTexture *v38; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v39; // rdx
			//   PassConstructorID__Enum__Array *v40; // r8
			//   HGCamera *v41; // r9
			//   HGTerrainConfiguration *m_configuration; // rax
			//   int32_t vtMaxPagePerFrame; // esi
			//   ComputeBuffer *v44; // rax
			//   ComputeBuffer *v45; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v46; // rdx
			//   PassConstructorID__Enum__Array *v47; // r8
			//   HGCamera *v48; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *formata; // [rsp+20h] [rbp-B8h]
			//   MethodInfo *format; // [rsp+20h] [rbp-B8h]
			//   MethodInfo *formatb; // [rsp+20h] [rbp-B8h]
			//   MethodInfo *formatc; // [rsp+20h] [rbp-B8h]
			//   MethodInfo *formatd; // [rsp+20h] [rbp-B8h]
			//   MethodInfo *formate; // [rsp+20h] [rbp-B8h]
			//   MethodInfo *v56; // [rsp+28h] [rbp-B0h]
			//   MethodInfo *v57; // [rsp+28h] [rbp-B0h]
			//   MethodInfo *v58; // [rsp+28h] [rbp-B0h]
			//   MethodInfo *v59; // [rsp+28h] [rbp-B0h]
			//   MethodInfo *v60; // [rsp+28h] [rbp-B0h]
			//   MethodInfo *v61; // [rsp+28h] [rbp-B0h]
			//   __int128 v62; // [rsp+40h] [rbp-98h]
			//   __int128 v63; // [rsp+50h] [rbp-88h]
			//   __int128 v64; // [rsp+60h] [rbp-78h]
			//   RenderTextureDescriptor v65; // [rsp+70h] [rbp-68h] BYREF
			//   Vector2Int v66; // [rsp+F0h] [rbp+18h]
			// 
			//   if ( !byte_18D919738 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::RenderTexture);
			//     sub_18003C530(&TypeInfo::UnityEngine::Texture2DArray);
			//     byte_18D919738 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3354, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3354, 0LL);
			//     if ( !Patch )
			//       goto LABEL_21;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( !this.fields.m_enableCompression )
			//     {
			//       m_cacheSliceWidth = this.fields.m_cacheSliceWidth;
			//       m_cacheSliceHeight = this.fields.m_cacheSliceHeight;
			//       v5 = (RenderTexture *)sub_180004920(TypeInfo::UnityEngine::RenderTexture);
			//       v8 = v5;
			//       if ( v5 )
			//       {
			//         UnityEngine::RenderTexture::RenderTexture(
			//           v5,
			//           m_cacheSliceWidth,
			//           m_cacheSliceHeight,
			//           0,
			//           GraphicsFormat__Enum_R8G8B8A8_UNorm,
			//           0LL);
			//         sub_1800491C0(10LL, v8, 5LL);
			//         UnityEngine::RenderTexture::set_volumeDepth(v8, this.fields.m_cacheSliceCount, 0LL);
			//         UnityEngine::RenderTexture::set_useMipMap(v8, 0, 0LL);
			//         UnityEngine::RenderTexture::set_autoGenerateMips(v8, 0, 0LL);
			//         UnityEngine::RenderTexture::set_enableRandomWrite(v8, 1, 0LL);
			//         UnityEngine::Texture::set_wrapMode((Texture *)v8, TextureWrapMode__Enum_Clamp, 0LL);
			//         UnityEngine::Texture::set_filterMode((Texture *)v8, FilterMode__Enum_Bilinear, 0LL);
			//         UnityEngine::Texture::set_anisoLevel((Texture *)v8, 0, 0LL);
			//         this.fields.m_physicalBaseRt = v8;
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.m_physicalBaseRt, v9, v10, v11, formata, v56);
			//         m_physicalBaseRt = this.fields.m_physicalBaseRt;
			//         if ( m_physicalBaseRt )
			//         {
			//           UnityEngine::RenderTexture::Create(m_physicalBaseRt, 0LL);
			//           v6 = this.fields.m_physicalBaseRt;
			//           if ( v6 )
			//           {
			//             descriptor = UnityEngine::RenderTexture::get_descriptor(&v65, v6, 0LL);
			//             memoryless_k__BackingField = descriptor._memoryless_k__BackingField;
			//             v62 = *(_OWORD *)&descriptor._width_k__BackingField;
			//             v63 = *(_OWORD *)&descriptor._mipCount_k__BackingField;
			//             v64 = *(_OWORD *)&descriptor._dimension_k__BackingField;
			//             v14 = (RenderTexture *)sub_180004920(TypeInfo::UnityEngine::RenderTexture);
			//             v15 = v14;
			//             if ( v14 )
			//             {
			//               v65._memoryless_k__BackingField = memoryless_k__BackingField;
			//               *(_OWORD *)&v65._width_k__BackingField = v62;
			//               *(_OWORD *)&v65._mipCount_k__BackingField = v63;
			//               *(_OWORD *)&v65._dimension_k__BackingField = v64;
			//               UnityEngine::RenderTexture::RenderTexture(v14, &v65, 0LL);
			//               sub_1800491C0(10LL, v15, 5LL);
			//               UnityEngine::RenderTexture::set_volumeDepth(v15, this.fields.m_cacheSliceCount, 0LL);
			//               UnityEngine::RenderTexture::set_useMipMap(v15, 0, 0LL);
			//               UnityEngine::RenderTexture::set_autoGenerateMips(v15, 0, 0LL);
			//               UnityEngine::RenderTexture::set_enableRandomWrite(v15, 1, 0LL);
			//               UnityEngine::Texture::set_wrapMode((Texture *)v15, TextureWrapMode__Enum_Clamp, 0LL);
			//               UnityEngine::Texture::set_filterMode((Texture *)v15, FilterMode__Enum_Bilinear, 0LL);
			//               UnityEngine::Texture::set_anisoLevel((Texture *)v15, 0, 0LL);
			//               this.fields.m_physicalNormRt = v15;
			//               sub_1800054D0((HGRenderPathScene *)&this.fields.m_physicalNormRt, v16, v17, v18, format, v57);
			//               m_physicalBaseRt = this.fields.m_physicalNormRt;
			//               if ( m_physicalBaseRt )
			//               {
			//                 UnityEngine::RenderTexture::Create(m_physicalBaseRt, 0LL);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			// LABEL_21:
			//       sub_180B536AC(m_physicalBaseRt, v6);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGTerrainUtils);
			//     PlatformCompressionFormat = HG::Rendering::Runtime::HGTerrainUtils::GetPlatformCompressionFormat(0LL);
			//     v20 = this.fields.m_cacheSliceWidth;
			//     v21 = this.fields.m_cacheSliceHeight;
			//     m_cacheSliceCount = this.fields.m_cacheSliceCount;
			//     v23 = (Texture2DArray *)sub_180004920(TypeInfo::UnityEngine::Texture2DArray);
			//     v24 = (Texture *)v23;
			//     if ( !v23 )
			//       goto LABEL_21;
			//     UnityEngine::Texture2DArray::Texture2DArray(
			//       v23,
			//       v20,
			//       v21,
			//       m_cacheSliceCount,
			//       PlatformCompressionFormat,
			//       TextureCreationFlags__Enum_None,
			//       0LL);
			//     UnityEngine::Texture::set_wrapMode(v24, TextureWrapMode__Enum_Clamp, 0LL);
			//     UnityEngine::Texture::set_filterMode(v24, FilterMode__Enum_Bilinear, 0LL);
			//     UnityEngine::Texture::set_anisoLevel(v24, 0, 0LL);
			//     this.fields.m_physicalBaseTex = (Texture2DArray *)v24;
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_physicalBaseTex, v25, v26, v27, formatb, v58);
			//     v28 = this.fields.m_cacheSliceWidth;
			//     v29 = this.fields.m_cacheSliceHeight;
			//     v30 = this.fields.m_cacheSliceCount;
			//     v31 = (Texture2DArray *)sub_180004920(TypeInfo::UnityEngine::Texture2DArray);
			//     v32 = (Texture *)v31;
			//     if ( !v31 )
			//       goto LABEL_21;
			//     UnityEngine::Texture2DArray::Texture2DArray(
			//       v31,
			//       v28,
			//       v29,
			//       v30,
			//       PlatformCompressionFormat,
			//       TextureCreationFlags__Enum_None,
			//       0LL);
			//     UnityEngine::Texture::set_wrapMode(v32, TextureWrapMode__Enum_Clamp, 0LL);
			//     UnityEngine::Texture::set_filterMode(v32, FilterMode__Enum_Bilinear, 0LL);
			//     UnityEngine::Texture::set_anisoLevel(v32, 0, 0LL);
			//     this.fields.m_physicalNormTex = (Texture2DArray *)v32;
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_physicalNormTex, v33, v34, v35, formatc, v59);
			//     m_physicalBaseRt = (RenderTexture *)this.fields.m_physicalBaseTex;
			//     if ( !m_physicalBaseRt )
			//       goto LABEL_21;
			//     UnityEngine::Texture2DArray::Apply((Texture2DArray *)m_physicalBaseRt, 0, 1, 0LL);
			//     m_physicalBaseRt = (RenderTexture *)this.fields.m_physicalNormTex;
			//     if ( !m_physicalBaseRt )
			//       goto LABEL_21;
			//     UnityEngine::Texture2DArray::Apply((Texture2DArray *)m_physicalBaseRt, 0, 1, 0LL);
			//     vtMaxPagePerFrame_k__BackingField = this.fields._vtMaxPagePerFrame_k__BackingField;
			//     v37 = (RenderTexture *)sub_180004920(TypeInfo::UnityEngine::RenderTexture);
			//     v38 = v37;
			//     if ( !v37 )
			//       goto LABEL_21;
			//     UnityEngine::RenderTexture::RenderTexture(
			//       v37,
			//       vtMaxPagePerFrame_k__BackingField << 8,
			//       512,
			//       0,
			//       GraphicsFormat__Enum_R8G8B8A8_UNorm,
			//       0LL);
			//     sub_1800491C0(10LL, v38, 2LL);
			//     UnityEngine::RenderTexture::set_useMipMap(v38, 0, 0LL);
			//     UnityEngine::RenderTexture::set_autoGenerateMips(v38, 0, 0LL);
			//     UnityEngine::RenderTexture::set_enableRandomWrite(v38, 1, 0LL);
			//     this.fields.m_pageRt = v38;
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_pageRt, v39, v40, v41, formatd, v60);
			//     m_physicalBaseRt = this.fields.m_pageRt;
			//     if ( !m_physicalBaseRt )
			//       goto LABEL_21;
			//     UnityEngine::RenderTexture::Create(m_physicalBaseRt, 0LL);
			//     m_configuration = this.fields.m_configuration;
			//     if ( !m_configuration )
			//       goto LABEL_21;
			//     vtMaxPagePerFrame = m_configuration.fields.vtMaxPagePerFrame;
			//     v44 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//     v45 = v44;
			//     if ( !v44 )
			//       goto LABEL_21;
			//     UnityEngine::ComputeBuffer::ComputeBuffer(
			//       v44,
			//       vtMaxPagePerFrame << 13,
			//       16,
			//       ComputeBufferType__Enum_Structured,
			//       ComputeBufferMode__Enum_Immutable,
			//       0LL);
			//     this.fields.m_pageBuffer = v45;
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_pageBuffer, v46, v47, v48, formate, v61);
			//     v66.m_Y = 8;
			//     v66.m_X = 4 * vtMaxPagePerFrame;
			//     this.fields.m_compressCSGroupSize = v66;
			//   }
			// }
			// 
		}

		public ValueTuple<float, float, float, float> GetFeedbackSubViewRange(float origLeft, float origRight, float origBottom, float origTop)
		{
			// // ValueTuple`4[Single,Single,Single,Single] GetFeedbackSubViewRange(Single, Single, Single, Single)
			// ValueTuple_4_Single_Single_Single_Single_ *HG::Rendering::Runtime::VirtualTextureRenderer::GetFeedbackSubViewRange(
			//         ValueTuple_4_Single_Single_Single_Single_ *__return_ptr retstr,
			//         VirtualTextureRenderer *this,
			//         float origLeft,
			//         float origRight,
			//         float origBottom,
			//         float origTop,
			//         MethodInfo *method)
			// {
			//   float v9; // xmm6_4
			//   int v10; // eax
			//   float v11; // xmm4_4
			//   float m_blockHeight; // xmm0_4
			//   float v13; // xmm3_4
			//   float v14; // xmm0_4
			//   float v15; // xmm6_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v17; // rdx
			//   __int64 v18; // rcx
			//   ValueTuple_4_Single_Single_Single_Single_ v20; // [rsp+40h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919739 )
			//   {
			//     sub_18003C530(&MethodInfo::System::ValueTuple<float,float,float,float>::ValueTuple);
			//     byte_18D919739 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3392, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3392, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v18, v17);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1203(
			//                  &v20,
			//                  Patch,
			//                  (Object *)this,
			//                  origLeft,
			//                  origRight,
			//                  origBottom,
			//                  origTop,
			//                  0LL);
			//   }
			//   else
			//   {
			//     v9 = origRight - origLeft;
			//     v10 = *(_DWORD *)&this.fields.m_feedbackJitterSeq.m_Buffer[4
			//                                                               * ((int)this.fields.m_frameCount & (unsigned __int64)(this.fields.m_blockWidth * this.fields.m_blockHeight - 1LL))];
			//     v11 = (float)((float)((float)(origRight - origLeft) * (float)(__int16)v10) / (float)this.fields.m_blockWidth)
			//         + origLeft;
			//     m_blockHeight = (float)this.fields.m_blockHeight;
			//     retstr.Item1 = v11;
			//     v13 = (float)((float)((float)SHIWORD(v10) * (float)(origTop - origBottom)) / m_blockHeight) + origBottom;
			//     v14 = (float)this.fields.m_blockHeight;
			//     v15 = (float)(v9 / (float)this.fields.m_blockWidth) + v11;
			//     retstr.Item3 = v13;
			//     retstr.Item2 = v15;
			//     retstr.Item4 = (float)((float)(origTop - origBottom) / v14) + v13;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		private void _GenerateJitterSequenceForSSBO(int blockWidth, int blockHeight)
		{
			// // Void _GenerateJitterSequenceForSSBO(Int32, Int32)
			// void HG::Rendering::Runtime::VirtualTextureRenderer::_GenerateJitterSequenceForSSBO(
			//         VirtualTextureRenderer *this,
			//         int32_t blockWidth,
			//         int32_t blockHeight,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rbx
			//   int32_t v8; // r14d
			//   int v9; // r9d
			//   __int64 i; // r8
			//   int v11; // eax
			//   int v12; // edx
			//   int32_t v13; // eax
			//   int v14; // ecx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   int v18; // [rsp+30h] [rbp-28h]
			//   NativeArray_1_HG_Rendering_Runtime_HGTerrainUtils_Vector2Short_ v19; // [rsp+38h] [rbp-20h] BYREF
			// 
			//   v4 = 0LL;
			//   if ( !byte_18D91973A )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::get_IsCreated);
			//     byte_18D91973A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3363, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3363, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, v16);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_56(
			//       (ILFixDynamicMethodWrapper_20 *)Patch,
			//       (Object *)this,
			//       blockWidth,
			//       blockHeight,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( this.fields.m_feedbackJitterSeq.m_Buffer )
			//       Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
			//         (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&this.fields.m_feedbackJitterSeq,
			//         MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::Dispose);
			//     v8 = blockHeight * blockWidth;
			//     v19 = 0LL;
			//     Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::NativeArray(
			//       &v19,
			//       blockHeight * blockWidth,
			//       Allocator__Enum_Persistent,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::NativeArray);
			//     v9 = 0;
			//     this.fields.m_feedbackJitterSeq = v19;
			//     if ( blockHeight * blockWidth > 0 )
			//     {
			//       for ( i = 0LL; i < v8; *(_DWORD *)&this.fields.m_feedbackJitterSeq.m_Buffer[4 * i++] = v18 )
			//       {
			//         v11 = v9;
			//         v12 = v9++ >> 31;
			//         LOWORD(v18) = __SPAIR64__(v12, v11) % blockWidth;
			//         HIWORD(v18) = __SPAIR64__(v12, v11) / blockWidth;
			//       }
			//       do
			//       {
			//         v13 = UnityEngine::Random::RandomRangeInt(0, v8, 0LL);
			//         v14 = *(_DWORD *)&this.fields.m_feedbackJitterSeq.m_Buffer[4 * v4];
			//         *(_DWORD *)&this.fields.m_feedbackJitterSeq.m_Buffer[4 * v4++] = *(_DWORD *)&this.fields.m_feedbackJitterSeq.m_Buffer[4 * v13];
			//         *(_DWORD *)&this.fields.m_feedbackJitterSeq.m_Buffer[4 * v13] = v14;
			//       }
			//       while ( v4 < v8 );
			//     }
			//   }
			// }
			// 
		}

		private void _GenerateJitterSequenceForPhysX(int blockWidth, int blockHeight, int feedbackWidth, int feedbackHeight)
		{
			// // Void _GenerateJitterSequenceForPhysX(Int32, Int32, Int32, Int32)
			// void HG::Rendering::Runtime::VirtualTextureRenderer::_GenerateJitterSequenceForPhysX(
			//         VirtualTextureRenderer *this,
			//         int32_t blockWidth,
			//         int32_t blockHeight,
			//         int32_t feedbackWidth,
			//         int32_t feedbackHeight,
			//         MethodInfo *method)
			// {
			//   int v10; // edi
			//   int v11; // r9d
			//   __int64 i; // r8
			//   int v13; // eax
			//   int v14; // edx
			//   __int64 v15; // rsi
			//   int32_t v16; // eax
			//   int v17; // ecx
			//   int32_t v18; // r9d
			//   __int64 v19; // r8
			//   __int64 v20; // rdx
			//   Void *m_Buffer; // rcx
			//   int v22; // eax
			//   int32_t v23; // ebp
			//   __int64 v24; // rsi
			//   __int64 v25; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   int v27; // [rsp+40h] [rbp-28h]
			//   NativeArray_1_HG_Rendering_Runtime_HGTerrainUtils_Vector2Short_ v28; // [rsp+48h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D91973B )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::get_IsCreated);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<int>::get_IsCreated);
			//     byte_18D91973B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3359, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3359, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v25);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_818(
			//       Patch,
			//       (Object *)this,
			//       blockWidth,
			//       blockHeight,
			//       feedbackWidth,
			//       feedbackHeight,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( this.fields.m_feedbackJitterSeq.m_Buffer )
			//       Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::Dispose(
			//         (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&this.fields.m_feedbackJitterSeq,
			//         MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::Dispose);
			//     v10 = blockHeight * blockWidth;
			//     v28 = 0LL;
			//     Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::NativeArray(
			//       &v28,
			//       2 * blockHeight * blockWidth,
			//       Allocator__Enum_Persistent,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::HGTerrainUtils::Vector2Short>::NativeArray);
			//     v11 = 0;
			//     this.fields.m_feedbackJitterSeq = v28;
			//     if ( blockHeight * blockWidth > 0 )
			//     {
			//       for ( i = 0LL; i < v10; *(_DWORD *)&this.fields.m_feedbackJitterSeq.m_Buffer[4 * i++] = v27 )
			//       {
			//         v13 = v11;
			//         v14 = v11++ >> 31;
			//         LOWORD(v27) = __SPAIR64__(v14, v13) % blockWidth;
			//         HIWORD(v27) = __SPAIR64__(v14, v13) / blockWidth;
			//       }
			//       v15 = 0LL;
			//       do
			//       {
			//         v16 = UnityEngine::Random::RandomRangeInt(0, v10, 0LL);
			//         v17 = *(_DWORD *)&this.fields.m_feedbackJitterSeq.m_Buffer[4 * v15];
			//         *(_DWORD *)&this.fields.m_feedbackJitterSeq.m_Buffer[4 * v15++] = *(_DWORD *)&this.fields.m_feedbackJitterSeq.m_Buffer[4 * v16];
			//         *(_DWORD *)&this.fields.m_feedbackJitterSeq.m_Buffer[4 * v16] = v17;
			//       }
			//       while ( v15 < v10 );
			//     }
			//     v18 = v10;
			//     if ( v10 < this.fields.m_feedbackJitterSeq.m_Length )
			//     {
			//       v19 = 0LL;
			//       do
			//       {
			//         v20 = v19 + 4LL * v10;
			//         m_Buffer = this.fields.m_feedbackJitterSeq.m_Buffer;
			//         ++v18;
			//         v22 = *(_DWORD *)&m_Buffer[v19];
			//         v19 += 4LL;
			//         *(_DWORD *)&m_Buffer[v20] = v22;
			//       }
			//       while ( v18 < this.fields.m_feedbackJitterSeq.m_Length );
			//     }
			//     if ( this.fields.m_cpuJitterOffsets.m_Buffer )
			//       Unity::Collections::NativeArray<int>::Dispose(
			//         &this.fields.m_cpuJitterOffsets,
			//         MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
			//     v28 = 0LL;
			//     Unity::Collections::NativeArray<int>::NativeArray(
			//       (NativeArray_1_System_Int32_ *)&v28,
			//       feedbackHeight * feedbackWidth,
			//       Allocator__Enum_Persistent,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
			//     v23 = 0;
			//     this.fields.m_cpuJitterOffsets = (NativeArray_1_System_Int32_)v28;
			//     if ( this.fields.m_cpuJitterOffsets.m_Length > 0 )
			//     {
			//       v24 = 0LL;
			//       do
			//       {
			//         ++v23;
			//         *(_DWORD *)&this.fields.m_cpuJitterOffsets.m_Buffer[v24] = UnityEngine::Random::RandomRangeInt(0, v10, 0LL);
			//         v24 += 4LL;
			//       }
			//       while ( v23 < this.fields.m_cpuJitterOffsets.m_Length );
			//     }
			//     this.fields.m_frameCount = 0;
			//   }
			// }
			// 
		}

		private void _DestroyGPUFeedbackResources()
		{
			// // Void _DestroyGPUFeedbackResources()
			// void HG::Rendering::Runtime::VirtualTextureRenderer::_DestroyGPUFeedbackResources(
			//         VirtualTextureRenderer *this,
			//         MethodInfo *method)
			// {
			//   int32_t v2; // ebx
			//   __int64 v4; // rdx
			//   RTHandle *m_gpuFeedbackColor; // rcx
			//   ComputeBuffer__Array *m_gpuFeedbackBuffers; // rbp
			//   int32_t i; // esi
			//   ComputeBuffer *v8; // rcx
			//   RTHandle *m_gpuFeedbackDepth; // rcx
			//   AsyncGPUReadbackRequest__Array *m_gpuFeedbackRequests; // rbp
			//   int32_t j; // esi
			//   NativeArray_1_System_UInt32___Array *m_gpuFeedbackData; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   AsyncGPUReadbackRequest _unity_self; // [rsp+20h] [rbp-28h] BYREF
			//   NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ v15; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   v2 = 0;
			//   if ( !byte_18D91973C )
			//   {
			//     sub_18003C530(&MethodInfo::System::Array::Fill<bool>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<unsigned int>::Dispose);
			//     byte_18D91973C = 1;
			//   }
			//   _unity_self = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3364, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3364, 0LL);
			//     if ( !Patch )
			// LABEL_28:
			//       sub_180B536AC(v8, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     System::Array::Fill<bool>(this.fields.m_gpuFeedbackBufferFilled, 0, MethodInfo::System::Array::Fill<bool>);
			//     if ( this.fields.m_gpuFeedbackBuffers )
			//     {
			//       m_gpuFeedbackBuffers = this.fields.m_gpuFeedbackBuffers;
			//       for ( i = 0; i < m_gpuFeedbackBuffers.max_length.size; ++i )
			//       {
			//         if ( (unsigned int)i >= m_gpuFeedbackBuffers.max_length.size )
			// LABEL_26:
			//           sub_180070270(m_gpuFeedbackColor, v4);
			//         v8 = m_gpuFeedbackBuffers.vector[i];
			//         if ( !v8 )
			//           goto LABEL_28;
			//         UnityEngine::ComputeBuffer::Dispose(v8, 0LL);
			//       }
			//     }
			//     m_gpuFeedbackDepth = this.fields.m_gpuFeedbackDepth;
			//     if ( m_gpuFeedbackDepth )
			//       UnityEngine::Rendering::RTHandle::Release(m_gpuFeedbackDepth, 0LL);
			//     m_gpuFeedbackColor = this.fields.m_gpuFeedbackColor;
			//     if ( m_gpuFeedbackColor )
			//       UnityEngine::Rendering::RTHandle::Release(m_gpuFeedbackColor, 0LL);
			//     if ( this.fields.m_gpuFeedbackRequests )
			//     {
			//       m_gpuFeedbackRequests = this.fields.m_gpuFeedbackRequests;
			//       for ( j = 0; j < m_gpuFeedbackRequests.max_length.size; ++j )
			//       {
			//         if ( (unsigned int)j >= m_gpuFeedbackRequests.max_length.size )
			//           goto LABEL_26;
			//         _unity_self = m_gpuFeedbackRequests.vector[j];
			//         if ( !UnityEngine::Rendering::AsyncGPUReadbackRequest::IsDone_Injected(&_unity_self, 0LL) )
			//           UnityEngine::Rendering::AsyncGPUReadbackRequest::WaitForCompletion_Injected(&_unity_self, 0LL);
			//       }
			//     }
			//     if ( this.fields.m_gpuFeedbackData )
			//     {
			//       m_gpuFeedbackData = this.fields.m_gpuFeedbackData;
			//       while ( v2 < m_gpuFeedbackData.max_length.size )
			//       {
			//         if ( (unsigned int)v2 >= m_gpuFeedbackData.max_length.size )
			//           goto LABEL_26;
			//         v15 = (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_)m_gpuFeedbackData.vector[v2];
			//         Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::Dispose(
			//           &v15,
			//           MethodInfo::Unity::Collections::NativeArray<unsigned int>::Dispose);
			//         ++v2;
			//       }
			//     }
			//   }
			// }
			// 
		}

		private void _AllocateGPUFeedbackResources(int blockWidth, int blockHeight, int feedbackWidth, int feedbackHeight)
		{
			// // Void _AllocateGPUFeedbackResources(Int32, Int32, Int32, Int32)
			// void HG::Rendering::Runtime::VirtualTextureRenderer::_AllocateGPUFeedbackResources(
			//         VirtualTextureRenderer *this,
			//         int32_t blockWidth,
			//         int32_t blockHeight,
			//         int32_t feedbackWidth,
			//         int32_t feedbackHeight,
			//         MethodInfo *method)
			// {
			//   __int64 v10; // r8
			//   __int64 v11; // r9
			//   int32_t v12; // ebx
			//   HGRenderPathBase_HGRenderPathResources *v13; // rdx
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   __int64 v16; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int64 v18; // r8
			//   __int64 v19; // r9
			//   int32_t i; // edi
			//   ComputeBuffer__Array *m_gpuFeedbackBuffers; // rax
			//   ComputeBuffer__Array *v22; // r14
			//   ComputeBuffer *v23; // rax
			//   ComputeBuffer *v24; // rbp
			//   HGRenderPathBase_HGRenderPathResources *v25; // rdx
			//   PassConstructorID__Enum__Array *v26; // r8
			//   HGCamera *v27; // r9
			//   __int64 v28; // r8
			//   __int64 v29; // r9
			//   int32_t j; // edi
			//   NativeArray_1_System_UInt32___Array *m_gpuFeedbackData; // rax
			//   NativeArray_1_System_UInt32___Array *v32; // rbp
			//   __int64 v33; // rax
			//   HGRenderPathBase_HGRenderPathResources *v34; // rdx
			//   PassConstructorID__Enum__Array *v35; // r8
			//   HGCamera *v36; // r9
			//   int32_t m_feedbackWidth; // edi
			//   int32_t m_feedbackHeight; // ebx
			//   HGRenderPathBase_HGRenderPathResources *v39; // rdx
			//   PassConstructorID__Enum__Array *v40; // r8
			//   HGCamera *v41; // r9
			//   MethodInfo *v42; // rdx
			//   Color v43; // xmm1
			//   RenderTargetIdentifier *v44; // rax
			//   __int128 v45; // xmm2
			//   __int64 v46; // xmm0_8
			//   HGRenderPathBase_HGRenderPathResources *v47; // rdx
			//   PassConstructorID__Enum__Array *v48; // r8
			//   HGCamera *v49; // r9
			//   MethodInfo *v50; // rdx
			//   Color v51; // xmm1
			//   RenderTargetIdentifier *v52; // rax
			//   __int128 v53; // xmm2
			//   __int64 v54; // xmm0_8
			//   MethodInfo *usage; // [rsp+20h] [rbp-F8h]
			//   MethodInfo *usagea; // [rsp+20h] [rbp-F8h]
			//   MethodInfo *usageb; // [rsp+20h] [rbp-F8h]
			//   MethodInfo *usagec; // [rsp+20h] [rbp-F8h]
			//   MethodInfo *usaged; // [rsp+20h] [rbp-F8h]
			//   MethodInfo *filterMode; // [rsp+28h] [rbp-F0h]
			//   MethodInfo *filterModea; // [rsp+28h] [rbp-F0h]
			//   MethodInfo *filterModeb; // [rsp+28h] [rbp-F0h]
			//   MethodInfo *filterModec; // [rsp+28h] [rbp-F0h]
			//   MethodInfo *filterModed; // [rsp+28h] [rbp-F0h]
			//   NativeArray_1_System_UInt32_ v65; // [rsp+A0h] [rbp-78h] BYREF
			//   RenderTargetIdentifier v66; // [rsp+B0h] [rbp-68h] BYREF
			// 
			//   if ( !byte_18D91973D )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::AsyncGPUReadbackRequest);
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&TypeInfo::Unity::Collections::NativeArray<unsigned int>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<unsigned int>::NativeArray);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&off_18C9B4D38);
			//     byte_18D91973D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3365, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3365, 0LL);
			//     if ( !Patch )
			// LABEL_17:
			//       sub_180B536AC(Patch, v16);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_818(
			//       Patch,
			//       (Object *)this,
			//       blockWidth,
			//       blockHeight,
			//       feedbackWidth,
			//       feedbackHeight,
			//       0LL);
			//   }
			//   else
			//   {
			//     this.fields.m_feedbackWidth = feedbackWidth;
			//     this.fields.m_feedbackHeight = feedbackHeight;
			//     this.fields.m_blockWidth = blockWidth;
			//     this.fields.m_blockHeight = blockHeight;
			//     v12 = feedbackHeight * feedbackWidth;
			//     this.fields.m_gpuFeedbackBuffers = (ComputeBuffer__Array *)il2cpp_array_new_specific_0(
			//                                                                   TypeInfo::UnityEngine::ComputeBuffer,
			//                                                                   4LL,
			//                                                                   v10,
			//                                                                   v11);
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_gpuFeedbackBuffers, v13, v14, v15, usage, filterMode);
			//     for ( i = 0; ; ++i )
			//     {
			//       m_gpuFeedbackBuffers = this.fields.m_gpuFeedbackBuffers;
			//       if ( !m_gpuFeedbackBuffers )
			//         goto LABEL_17;
			//       if ( i >= m_gpuFeedbackBuffers.max_length.size )
			//         break;
			//       v22 = this.fields.m_gpuFeedbackBuffers;
			//       v23 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//       v24 = v23;
			//       if ( !v23 )
			//         goto LABEL_17;
			//       UnityEngine::ComputeBuffer::ComputeBuffer(
			//         v23,
			//         v12,
			//         4,
			//         ComputeBufferType__Enum_Structured,
			//         ComputeBufferMode__Enum_Immutable,
			//         0LL);
			//       sub_180328478(v22, i, v24);
			//     }
			//     this.fields.m_gpuFeedbackData = (NativeArray_1_System_UInt32___Array *)il2cpp_array_new_specific_0(
			//                                                                               TypeInfo::Unity::Collections::NativeArray<unsigned int>,
			//                                                                               4LL,
			//                                                                               v18,
			//                                                                               v19);
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_gpuFeedbackData, v25, v26, v27, usagea, filterModea);
			//     for ( j = 0; ; ++j )
			//     {
			//       m_gpuFeedbackData = this.fields.m_gpuFeedbackData;
			//       if ( !m_gpuFeedbackData )
			//         goto LABEL_17;
			//       if ( j >= m_gpuFeedbackData.max_length.size )
			//         break;
			//       v32 = this.fields.m_gpuFeedbackData;
			//       v65 = 0LL;
			//       Unity::Collections::NativeArray<unsigned int>::NativeArray(
			//         &v65,
			//         v12,
			//         Allocator__Enum_Persistent,
			//         NativeArrayOptions__Enum_ClearMemory,
			//         MethodInfo::Unity::Collections::NativeArray<unsigned int>::NativeArray);
			//       if ( (unsigned int)j >= v32.max_length.size )
			//         sub_180070270(Patch, v16);
			//       v33 = 2 * (j + 2LL);
			//       *(NativeArray_1_System_UInt32_ *)(&v32.klass + v33) = v65;
			//     }
			//     this.fields.m_gpuFeedbackRequests = (AsyncGPUReadbackRequest__Array *)il2cpp_array_new_specific_0(
			//                                                                              TypeInfo::UnityEngine::Rendering::AsyncGPUReadbackRequest,
			//                                                                              4LL,
			//                                                                              v28,
			//                                                                              v29);
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_gpuFeedbackRequests, v34, v35, v36, usageb, filterModeb);
			//     m_feedbackWidth = this.fields.m_feedbackWidth;
			//     m_feedbackHeight = this.fields.m_feedbackHeight;
			//     sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//     this.fields.m_gpuFeedbackDepth = UnityEngine::Rendering::RTHandles::Alloc(
			//                                         m_feedbackWidth,
			//                                         m_feedbackHeight,
			//                                         1,
			//                                         DepthBits__Enum_Depth32,
			//                                         GraphicsFormat__Enum_D32_SFloat,
			//                                         FilterMode__Enum_Point,
			//                                         TextureWrapMode__Enum_Clamp,
			//                                         TextureDimension__Enum_Tex2D,
			//                                         0,
			//                                         0,
			//                                         0,
			//                                         0,
			//                                         1,
			//                                         0.0,
			//                                         MSAASamples__Enum_None,
			//                                         0,
			//                                         RenderTextureMemoryless__Enum_Depth,
			//                                         (String *)"",
			//                                         0LL);
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_gpuFeedbackDepth, v39, v40, v41, usagec, filterModec);
			//     sub_1802F01E0(&this.fields.m_gpuFeedbackDepthDesc, 0LL, 120LL);
			//     v43 = (Color)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one((Vector4 *)&v65, v42));
			//     *(_QWORD *)&this.fields.m_gpuFeedbackDepthDesc.m_ClearDepth = 1065353216LL;
			//     this.fields.m_gpuFeedbackDepthDesc.m_LoadAction = 1;
			//     this.fields.m_gpuFeedbackDepthDesc.m_ClearColor = v43;
			//     v44 = UnityEngine::Rendering::RTHandle::op_Implicit(&v66, this.fields.m_gpuFeedbackDepth, 0LL);
			//     v45 = *(_OWORD *)&v44.m_BufferPointer;
			//     v46 = *(_QWORD *)&v44.m_DepthSlice;
			//     *(_OWORD *)&this.fields.m_gpuFeedbackDepthDesc.m_LoadStoreTarget.m_Type = *(_OWORD *)&v44.m_Type;
			//     *(_OWORD *)&this.fields.m_gpuFeedbackDepthDesc.m_LoadStoreTarget.m_BufferPointer = v45;
			//     *(_QWORD *)&this.fields.m_gpuFeedbackDepthDesc.m_LoadStoreTarget.m_DepthSlice = v46;
			//     this.fields.m_gpuFeedbackDepthDesc.m_Format = 93;
			//     this.fields.m_gpuFeedbackColor = UnityEngine::Rendering::RTHandles::Alloc(
			//                                         this.fields.m_feedbackWidth,
			//                                         this.fields.m_feedbackHeight,
			//                                         1,
			//                                         DepthBits__Enum_None,
			//                                         GraphicsFormat__Enum_R8G8B8A8_UNorm,
			//                                         FilterMode__Enum_Point,
			//                                         TextureWrapMode__Enum_Clamp,
			//                                         TextureDimension__Enum_Tex2D,
			//                                         0,
			//                                         0,
			//                                         0,
			//                                         0,
			//                                         1,
			//                                         0.0,
			//                                         MSAASamples__Enum_None,
			//                                         0,
			//                                         RenderTextureMemoryless__Enum_Color,
			//                                         (String *)"",
			//                                         0LL);
			//     sub_1800054D0((HGRenderPathScene *)&this.fields.m_gpuFeedbackColor, v47, v48, v49, usaged, filterModed);
			//     sub_1802F01E0(&this.fields.m_gpuFeedbackColorDesc, 0LL, 120LL);
			//     v51 = (Color)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one((Vector4 *)&v65, v50));
			//     *(_QWORD *)&this.fields.m_gpuFeedbackColorDesc.m_ClearDepth = 1065353216LL;
			//     this.fields.m_gpuFeedbackColorDesc.m_LoadAction = 1;
			//     this.fields.m_gpuFeedbackColorDesc.m_ClearColor = v51;
			//     v52 = UnityEngine::Rendering::RTHandle::op_Implicit(&v66, this.fields.m_gpuFeedbackColor, 0LL);
			//     v53 = *(_OWORD *)&v52.m_BufferPointer;
			//     v54 = *(_QWORD *)&v52.m_DepthSlice;
			//     *(_OWORD *)&this.fields.m_gpuFeedbackColorDesc.m_LoadStoreTarget.m_Type = *(_OWORD *)&v52.m_Type;
			//     *(_OWORD *)&this.fields.m_gpuFeedbackColorDesc.m_LoadStoreTarget.m_BufferPointer = v53;
			//     *(_QWORD *)&this.fields.m_gpuFeedbackColorDesc.m_LoadStoreTarget.m_DepthSlice = v54;
			//     this.fields.m_gpuFeedbackColorDesc.m_Format = 8;
			//   }
			// }
			// 
		}

		private void _RefreshGPUFeedbackParams(in Vector2Int currScreenSize)
		{
			// // Void _RefreshGPUFeedbackParams(Vector2Int ByRef)
			// void HG::Rendering::Runtime::VirtualTextureRenderer::_RefreshGPUFeedbackParams(
			//         VirtualTextureRenderer *this,
			//         Vector2Int *currScreenSize,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGTerrainConfiguration *m_configuration; // rsi
			//   int32_t vtSSBOBlockWidth; // esi
			//   int32_t vtSSBOBlockHeight; // edi
			//   int32_t v10; // r15d
			//   int32_t feedbackHeight; // ebp
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3362, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3362, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1192(Patch, (Object *)this, currScreenSize, 0LL);
			//       return;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v6, v5);
			//   }
			//   m_configuration = this.fields.m_configuration;
			//   if ( !m_configuration )
			//     goto LABEL_9;
			//   vtSSBOBlockWidth = m_configuration.fields.vtSSBOBlockWidth;
			//   vtSSBOBlockHeight = this.fields.m_configuration.fields.vtSSBOBlockHeight;
			//   if ( vtSSBOBlockWidth != this.fields.m_blockWidth || vtSSBOBlockHeight != this.fields.m_blockHeight )
			//     HG::Rendering::Runtime::VirtualTextureRenderer::_GenerateJitterSequenceForSSBO(
			//       this,
			//       vtSSBOBlockWidth,
			//       vtSSBOBlockHeight,
			//       0LL);
			//   v10 = (vtSSBOBlockWidth + currScreenSize.m_X - 1) / vtSSBOBlockWidth;
			//   feedbackHeight = (int)(vtSSBOBlockHeight + HIDWORD(*(unsigned __int64 *)currScreenSize) - 1) / vtSSBOBlockHeight;
			//   if ( __PAIR64__(feedbackHeight, v10) != *(_QWORD *)&this.fields.m_feedbackWidth )
			//   {
			//     HG::Rendering::Runtime::VirtualTextureRenderer::_DestroyGPUFeedbackResources(this, 0LL);
			//     HG::Rendering::Runtime::VirtualTextureRenderer::_AllocateGPUFeedbackResources(
			//       this,
			//       vtSSBOBlockWidth,
			//       vtSSBOBlockHeight,
			//       v10,
			//       feedbackHeight,
			//       0LL);
			//   }
			// }
			// 
		}

		private void _RefreshCPUFeedbackParams(in Vector2Int currScreenSize)
		{
			// // Void _RefreshCPUFeedbackParams(Vector2Int ByRef)
			// void HG::Rendering::Runtime::VirtualTextureRenderer::_RefreshCPUFeedbackParams(
			//         VirtualTextureRenderer *this,
			//         Vector2Int *currScreenSize,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGTerrainConfiguration *m_configuration; // rax
			//   int32_t vtFeedbackWidth; // r9d
			//   int32_t feedbackHeight; // r8d
			//   int32_t v10; // r10d
			//   int32_t v11; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3358, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3358, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1192(Patch, (Object *)this, currScreenSize, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   m_configuration = this.fields.m_configuration;
			//   if ( !m_configuration )
			//     goto LABEL_7;
			//   vtFeedbackWidth = m_configuration.fields.vtFeedbackWidth;
			//   this.fields.m_feedbackWidth = vtFeedbackWidth;
			//   feedbackHeight = m_configuration.fields.vtFeedbackHeight;
			//   this.fields.m_feedbackHeight = feedbackHeight;
			//   v10 = (vtFeedbackWidth + currScreenSize.m_X - 1) / vtFeedbackWidth;
			//   v11 = (int)(HIDWORD(*(unsigned __int64 *)currScreenSize) + feedbackHeight - 1) / feedbackHeight;
			//   if ( v10 != this.fields.m_blockWidth || v11 != this.fields.m_blockHeight )
			//   {
			//     this.fields.m_blockWidth = v10;
			//     this.fields.m_blockHeight = v11;
			//     HG::Rendering::Runtime::VirtualTextureRenderer::_GenerateJitterSequenceForPhysX(
			//       this,
			//       v10,
			//       v11,
			//       vtFeedbackWidth,
			//       feedbackHeight,
			//       0LL);
			//   }
			// }
			// 
		}

		private float _CalculateHeightNormFactor()
		{
			// // Single _CalculateHeightNormFactor()
			// float HG::Rendering::Runtime::VirtualTextureRenderer::_CalculateHeightNormFactor(
			//         VirtualTextureRenderer *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3384, 0LL) )
			//     return this.fields.m_heightmapScale.y * 2.0000916;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3384, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43((ILFixDynamicMethodWrapper_16 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return 0f;
		}

		public void SetupVTTexturesForMaterial(Material terrainLitMaterial)
		{
			// // Void SetupVTTexturesForMaterial(Material)
			// void HG::Rendering::Runtime::VirtualTextureRenderer::SetupVTTexturesForMaterial(
			//         VirtualTextureRenderer *this,
			//         Material *terrainLitMaterial,
			//         MethodInfo *method)
			// {
			//   int32_t HGTerrainIndirectTexture; // esi
			//   Texture2D *currIndirectTexture; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Texture *m_physicalBaseTex; // r8
			//   Texture *m_physicalNormTex; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D91973E )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     byte_18D91973E = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3381, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3381, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)terrainLitMaterial,
			//         0LL);
			//       return;
			//     }
			// LABEL_14:
			//     sub_180B536AC(v8, v7);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//   HGTerrainIndirectTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainIndirectTexture;
			//   currIndirectTexture = HG::Rendering::Runtime::VirtualTextureRenderer::get_currIndirectTexture(this, 0LL);
			//   if ( !terrainLitMaterial )
			//     goto LABEL_14;
			//   UnityEngine::Material::SetTextureImpl(
			//     terrainLitMaterial,
			//     HGTerrainIndirectTexture,
			//     (Texture *)currIndirectTexture,
			//     0LL);
			//   if ( this.fields.m_needVTTexturesSetup )
			//   {
			//     this.fields.m_needVTTexturesSetup = 0;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     if ( this.fields.m_enableCompression )
			//       m_physicalBaseTex = (Texture *)this.fields.m_physicalBaseTex;
			//     else
			//       m_physicalBaseTex = (Texture *)this.fields.m_physicalBaseRt;
			//     UnityEngine::Material::SetTextureImpl(
			//       terrainLitMaterial,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainPhysicalBase,
			//       m_physicalBaseTex,
			//       0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     if ( this.fields.m_enableCompression )
			//       m_physicalNormTex = (Texture *)this.fields.m_physicalNormTex;
			//     else
			//       m_physicalNormTex = (Texture *)this.fields.m_physicalNormRt;
			//     UnityEngine::Material::SetTextureImpl(
			//       terrainLitMaterial,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainPhysicalNormal,
			//       m_physicalNormTex,
			//       0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     UnityEngine::Material::SetTextureImpl(
			//       terrainLitMaterial,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainTerrainNormalmapTexture,
			//       (Texture *)this.fields.m_terrainNormalMap,
			//       0LL);
			//     UnityEngine::Material::SetTextureImpl(
			//       terrainLitMaterial,
			//       TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainHeightmap,
			//       (Texture *)this.fields.m_terrainHeightmap,
			//       0LL);
			//   }
			// }
			// 
		}

		public void SetVTTexturesGlobal(CommandBuffer cmd)
		{
			// // Void SetVTTexturesGlobal(CommandBuffer)
			// void HG::Rendering::Runtime::VirtualTextureRenderer::SetVTTexturesGlobal(
			//         VirtualTextureRenderer *this,
			//         CommandBuffer *cmd,
			//         MethodInfo *method)
			// {
			//   int32_t HGTerrainIndirectTexture; // ebx
			//   Texture2D *currIndirectTexture; // rax
			//   RenderTargetIdentifier *v7; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __int128 v10; // xmm1
			//   int32_t HGTerrainPhysicalBase; // ebx
			//   Texture *m_physicalBaseTex; // rdx
			//   RenderTargetIdentifier *v13; // rax
			//   __int64 v14; // xmm2_8
			//   __int128 v15; // xmm1
			//   int32_t HGTerrainPhysicalNormal; // ebx
			//   Texture *m_physicalNormTex; // rdx
			//   RenderTargetIdentifier *v18; // rax
			//   __int64 v19; // xmm2_8
			//   __int128 v20; // xmm1
			//   int32_t HGTerrainTerrainNormalmapTexture; // ebx
			//   RenderTargetIdentifier *v22; // rax
			//   __int128 v23; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v25; // rdx
			//   __int64 v26; // rcx
			//   RenderTargetIdentifier v27; // [rsp+20h] [rbp-60h] BYREF
			//   RenderTargetIdentifier v28; // [rsp+50h] [rbp-30h] BYREF
			// 
			//   if ( !byte_18D91973F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     byte_18D91973F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3386, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3386, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v26, v25);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)cmd,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     HGTerrainIndirectTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainIndirectTexture;
			//     currIndirectTexture = HG::Rendering::Runtime::VirtualTextureRenderer::get_currIndirectTexture(this, 0LL);
			//     v7 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v28, (Texture *)currIndirectTexture, 0LL);
			//     if ( !cmd )
			//       sub_180B536AC(v9, v8);
			//     v10 = *(_OWORD *)&v7.m_BufferPointer;
			//     *(_OWORD *)&v27.m_Type = *(_OWORD *)&v7.m_Type;
			//     *(_QWORD *)&v27.m_DepthSlice = *(_QWORD *)&v7.m_DepthSlice;
			//     *(_OWORD *)&v27.m_BufferPointer = v10;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, HGTerrainIndirectTexture, &v27, 0LL);
			//     HGTerrainPhysicalBase = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainPhysicalBase;
			//     if ( this.fields.m_enableCompression )
			//       m_physicalBaseTex = (Texture *)this.fields.m_physicalBaseTex;
			//     else
			//       m_physicalBaseTex = (Texture *)this.fields.m_physicalBaseRt;
			//     v13 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v28, m_physicalBaseTex, 0LL);
			//     v14 = *(_QWORD *)&v13.m_DepthSlice;
			//     v15 = *(_OWORD *)&v13.m_BufferPointer;
			//     *(_OWORD *)&v27.m_Type = *(_OWORD *)&v13.m_Type;
			//     *(_OWORD *)&v27.m_BufferPointer = v15;
			//     *(_QWORD *)&v27.m_DepthSlice = v14;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, HGTerrainPhysicalBase, &v27, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     HGTerrainPhysicalNormal = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainPhysicalNormal;
			//     if ( this.fields.m_enableCompression )
			//       m_physicalNormTex = (Texture *)this.fields.m_physicalNormTex;
			//     else
			//       m_physicalNormTex = (Texture *)this.fields.m_physicalNormRt;
			//     v18 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v28, m_physicalNormTex, 0LL);
			//     v19 = *(_QWORD *)&v18.m_DepthSlice;
			//     v20 = *(_OWORD *)&v18.m_BufferPointer;
			//     *(_OWORD *)&v27.m_Type = *(_OWORD *)&v18.m_Type;
			//     *(_OWORD *)&v27.m_BufferPointer = v20;
			//     *(_QWORD *)&v27.m_DepthSlice = v19;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, HGTerrainPhysicalNormal, &v27, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     HGTerrainTerrainNormalmapTexture = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._HGTerrainTerrainNormalmapTexture;
			//     v22 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//             &v28,
			//             (Texture *)this.fields.m_terrainNormalMap,
			//             0LL);
			//     v23 = *(_OWORD *)&v22.m_BufferPointer;
			//     *(_OWORD *)&v27.m_Type = *(_OWORD *)&v22.m_Type;
			//     *(_QWORD *)&v27.m_DepthSlice = *(_QWORD *)&v22.m_DepthSlice;
			//     *(_OWORD *)&v27.m_BufferPointer = v23;
			//     UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, HGTerrainTerrainNormalmapTexture, &v27, 0LL);
			//   }
			// }
			// 
		}

		public void SetupVTDataBufferForMaterial(ComputeBuffer perTerrainDataBuffer)
		{
			// // Void SetupVTDataBufferForMaterial(ComputeBuffer)
			// void HG::Rendering::Runtime::VirtualTextureRenderer::SetupVTDataBufferForMaterial(
			//         VirtualTextureRenderer *this,
			//         ComputeBuffer *perTerrainDataBuffer,
			//         MethodInfo *method)
			// {
			//   Void *m_Buffer; // rbx
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   __int128 v8; // xmm0
			//   __int128 v9; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v11; // [rsp+30h] [rbp-28h]
			//   NativeArray_1_Unity_Mathematics_quaternion_ v12; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919740 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::ComputeBuffer::SetData<UnityEngine::Vector4>);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//     byte_18D919740 = 1;
			//   }
			//   v12 = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3382, 0LL) )
			//   {
			//     if ( !this.fields.m_needVTDataBufferSetup )
			//       return;
			//     this.fields.m_needVTDataBufferSetup = 0;
			//     Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//       &v12,
			//       6,
			//       Allocator__Enum_Temp,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//     m_Buffer = v12.m_Buffer;
			//     *((_QWORD *)&v11 + 1) = this.fields._terrainToVirtual_k__BackingField;
			//     *(float *)&v11 = 1.0 / (float)this.fields.m_terrainSize.m_X;
			//     *((float *)&v11 + 1) = 1.0 / (float)(int)HIDWORD(*(_QWORD *)&this.fields.m_terrainSize);
			//     *(_OWORD *)v12.m_Buffer = v11;
			//     *(float *)&v11 = this.fields.m_terrainPos.x;
			//     *(_QWORD *)((char *)&v11 + 4) = *(_QWORD *)&this.fields.m_terrainPos.y;
			//     HIDWORD(v11) = HG::Rendering::Runtime::VirtualTextureRenderer::_CalculateHeightNormFactor(this, 0LL);
			//     v8 = v11;
			//     HIDWORD(v11) = 1132462080;
			//     *(_OWORD *)&m_Buffer[16] = v8;
			//     *(float *)&v11 = (float)this.fields.m_cacheSliceWidth;
			//     *((float *)&v11 + 1) = (float)this.fields.m_cacheSliceHeight;
			//     DWORD2(v11) = LODWORD(this.fields.m_vtBaseMipBias);
			//     v9 = v11;
			//     HIDWORD(v11) = 0;
			//     *(_OWORD *)&m_Buffer[32] = v9;
			//     *(float *)&v11 = (float)this.fields.m_indirectMaxWidth;
			//     *((float *)&v11 + 1) = (float)this.fields.m_indirectMaxHeight;
			//     *((float *)&v11 + 2) = (float)this.fields.m_virtualTextureResolution;
			//     *(_OWORD *)&m_Buffer[48] = v11;
			//     *(float *)&v11 = (float)this.fields.m_indirectWidth;
			//     *((float *)&v11 + 1) = (float)this.fields.m_indirectLevel;
			//     *(_OWORD *)&m_Buffer[64] = (unsigned __int64)v11;
			//     *(__m128i *)&m_Buffer[80] = _mm_loadu_si128((const __m128i *)&this.fields.m_lightmapScaleOffset);
			//     if ( perTerrainDataBuffer )
			//     {
			//       sub_180831F20(perTerrainDataBuffer, &v12);
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v7, v6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3382, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)perTerrainDataBuffer,
			//     0LL);
			// }
			// 
		}

		private uint _PackIndirectParam(int pageIndex, int level)
		{
			// // UInt32 _PackIndirectParam(Int32, Int32)
			// uint32_t HG::Rendering::Runtime::VirtualTextureRenderer::_PackIndirectParam(
			//         VirtualTextureRenderer *this,
			//         int32_t pageIndex,
			//         int32_t level,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3379, 0LL) )
			//     return ((this.fields.m_cachePageCountTotal - pageIndex)
			//           % this.fields.m_cachePageCountPerSlice
			//           % this.fields.m_cacheColNumPerSlice) | ((((level | (((this.fields.m_cachePageCountTotal - pageIndex)
			//                                                               / this.fields.m_cachePageCountPerSlice) << 8)) << 8) | ((this.fields.m_cachePageCountTotal - pageIndex) % this.fields.m_cachePageCountPerSlice / this.fields.m_cacheColNumPerSlice)) << 8);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3379, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v10, v9);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			//            (ILFixDynamicMethodWrapper_14 *)Patch,
			//            (Object *)this,
			//            (SocketOptionLevel__Enum)pageIndex,
			//            (SocketOptionName__Enum)level,
			//            0LL);
			// }
			// 
			return 0U;
		}

		public void MarkCurrentGPUFeedbackBufferFilled(bool filled)
		{
			// // Void MarkCurrentGPUFeedbackBufferFilled(Boolean)
			// void HG::Rendering::Runtime::VirtualTextureRenderer::MarkCurrentGPUFeedbackBufferFilled(
			//         VirtualTextureRenderer *this,
			//         bool filled,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Boolean__Array *m_gpuFeedbackBufferFilled; // r8
			//   __int64 v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3377, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3377, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13((ILFixDynamicMethodWrapper_28 *)Patch, (Object *)this, filled, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   m_gpuFeedbackBufferFilled = this.fields.m_gpuFeedbackBufferFilled;
			//   if ( !m_gpuFeedbackBufferFilled )
			//     goto LABEL_7;
			//   v8 = this.fields.m_frameCount & 3;
			//   if ( (unsigned int)v8 >= m_gpuFeedbackBufferFilled.max_length.size )
			//     sub_180070270(v6, v5);
			//   m_gpuFeedbackBufferFilled.vector[v8] = filled;
			// }
			// 
		}

		private void ClearArray<T>(NativeArray<T> array) where T : struct
		{
		}

		private const int VT_CLIPMAP_BASE_WIDTH = 8;

		private const int VT_CACHE_PAGE_RESOLUTION = 256;

		private const int VT_CACHE_PAGE_BUFFER_SIDE_SIZE = 64;

		private const int VT_CACHE_PAGE_BUFFER_SIZE = 4096;

		private const int VT_INDIRECT_TEX_BUFFER_COUNT = 3;

		private const int VT_GPU_FEEDBACK_BUFFER_COUNT = 4;

		private const float VT_CPU_FEEDBACK_RAYCAST_DIST = 1000f;

		public const int VT_WORK_GROUP_COUNT = 32;

		public const int VT_COMPRESS_LOCAL_THREAD_COUNT = 16;

		private readonly HGTerrainConfiguration m_configuration;

		private readonly Texture2D m_splatIndexMap;

		private readonly Texture2D m_splatControlMap;

		private readonly Texture2DArray m_splatsDiffuseArray;

		private readonly Texture2DArray m_splatsNormalArray;

		private readonly Texture2D m_terrainNormalMap;

		private readonly Texture2D m_colorVariationTex;

		private readonly Texture2D m_terrainHeightmap;

		private readonly Texture2D m_deformableControlMap;

		private readonly Dictionary<uint, int[]> m_decalNodeLut;

		private readonly Dictionary<uint, ulong[]> m_decalBlockMaskLut;

		private readonly HGTerrainRuntimeResources.DecalPerInstanceData[] m_decalInstanceData;

		private readonly ComputeShader m_vtBakeCS;

		private readonly ComputeShader m_vtCompressCS;

		private readonly TerrainCollider m_collider;

		private readonly int m_vtBakeMainKernel;

		private readonly int m_vtCompressMainKernel;

		private uint m_frameCount;

		private readonly LRUCache m_lruCache;

		private readonly Dictionary<uint, int> m_nodeCacheLut;

		private readonly List<VirtualTextureRenderer.GlobalUV> m_globalUVs;

		private readonly List<uint> m_renderQueue;

		private NativeArray<HGTerrainUtils.Vector2Short> m_feedbackJitterSeq;

		private RenderTexture m_physicalBaseRt;

		private RenderTexture m_physicalNormRt;

		private Texture2DArray m_physicalBaseTex;

		private Texture2DArray m_physicalNormTex;

		private RenderTexture m_pageRt;

		private ComputeBuffer m_pageBuffer;

		private readonly Texture2DArray m_decalDiffuseTexArray;

		private readonly Texture2DArray m_decalNormalMROTexArray;

		private readonly Texture2D[] m_indirectTextures;

		private ComputeBuffer[] m_gpuFeedbackBuffers;

		private NativeArray<uint>[] m_gpuFeedbackData;

		private AsyncGPUReadbackRequest[] m_gpuFeedbackRequests;

		private readonly bool[] m_gpuFeedbackBufferFilled;

		private RTHandle m_gpuFeedbackDepth;

		private RTHandle m_gpuFeedbackColor;

		private AttachmentDescriptor m_gpuFeedbackColorDesc;

		private AttachmentDescriptor m_gpuFeedbackDepthDesc;

		private NativeArray<int> m_cpuJitterOffsets;

		private readonly Vector3 m_heightmapScale;

		private readonly Vector2Int m_terrainSize;

		private readonly Vector4 m_lightmapScaleOffset;

		private readonly Vector3 m_terrainPos;

		private readonly int m_decalMaxLevel;

		private readonly Vector4[] m_decalInstanceInfo;

		private readonly bool m_enableCompression;

		private readonly LocalKeyword m_enableCompressKeywordCS;

		private readonly LocalKeyword m_enableTerrainDecalCS;

		private readonly int m_virtualTextureResolution;

		private readonly float m_vtBaseMipBias;

		private int m_cacheSliceWidth;

		private int m_cacheSliceHeight;

		private int m_cacheSliceCount;

		private int m_indirectOffset;

		private readonly int m_indirectMaxOffset;

		private int m_blockWidth;

		private int m_blockHeight;

		private int m_cacheColNumPerSlice;

		private int m_cacheRowNumPerSlice;

		private int m_cachePageCountPerSlice;

		private int m_cachePageCountTotal;

		private readonly Vector2 m_virtualToTerrain;

		private readonly Vector2 m_worldToVirtual;

		private readonly Vector2 m_terrainPosOffset;

		private readonly int m_indirectMaxLevel;

		private readonly int m_indirectBaseLevel;

		private readonly int m_indirectMaxWidth;

		private readonly int m_indirectMaxHeight;

		private readonly int m_indirectMaxArea;

		private int m_indirectWidth;

		private int m_indirectHalfWidth;

		private int m_indirectLevel;

		private int m_feedbackWidth;

		private int m_feedbackHeight;

		private Vector2Int m_compressCSGroupSize;

		private bool m_needVTTexturesSetup;

		private bool m_needVTDataBufferSetup;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 24)]
		public struct GlobalUV
		{
			public Vector2 current;

			public Vector2 dUVdx;

			public Vector2 dUVdy;
		}
	}
}
