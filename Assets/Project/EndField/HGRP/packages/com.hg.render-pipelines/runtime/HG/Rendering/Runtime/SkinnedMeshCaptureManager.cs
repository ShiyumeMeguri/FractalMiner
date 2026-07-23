using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class SkinnedMeshCaptureManager // TypeDefIndex: 37924
	{
		// Fields
		private static readonly int BAKE_SKIN_MATRICES_CB; // 0x00
		private readonly Dictionary<int, RequestData> m_requests; // 0x10
		private List<ReleaseData> m_PendingReleaseMem; // 0x18
		private uint m_frameCount; // 0x20
	
		// Nested types
		private struct RequestData // TypeDefIndex: 37922
		{
			// Fields
			public MeshRenderer meshRenderer; // 0x00
			public SkinnedMeshRenderer skinnedMeshRenderer; // 0x08
			public unsafe Vector4* skinMatrices; // 0x10
			public int bufferSize; // 0x18
			public MaterialPropertyBlock propertyBlock; // 0x20
		}
	
		private struct ReleaseData // TypeDefIndex: 37923
		{
			// Fields
			public unsafe void* mem; // 0x00
			public uint frame; // 0x08
		}
	
		// Constructors
		public SkinnedMeshCaptureManager() {} // 0x0000000182ED8550-0x0000000182ED85D0
		// SkinnedMeshCaptureManager()
		void HG::Rendering::Runtime::SkinnedMeshCaptureManager::SkinnedMeshCaptureManager(
		        SkinnedMeshCaptureManager *this,
		        MethodInfo *method)
		{
		  Dictionary_2_System_Int32_Beyond_UI_UIText_RichTextAnalyzer_RichTextTag_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ *v6; // rdi
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *v10; // rax
		  List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *v11; // rdi
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		  MethodInfo *v16; // [rsp+50h] [rbp+28h]
		
		  v3 = (Dictionary_2_System_Int32_Beyond_UI_UIText_RichTextAnalyzer_RichTextTag_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>);
		  v6 = (Dictionary_2_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ *)v3;
		  if ( !v3
		    || (System::Collections::Generic::Dictionary<int,Beyond::UI::UIText_RichTextAnalyzer::RichTextTag>::Dictionary(
		          v3,
		          MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Dictionary),
		        this->fields.m_requests = v6,
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v7, v8, v9, v15),
		        v10 = (List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SkinnedMeshCaptureManager::ReleaseData>),
		        (v11 = (List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *)v10) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  System::Collections::Generic::List<Beyond::UI::UIText_RichTextAnalyzer::RichTextParam>::List(
		    v10,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SkinnedMeshCaptureManager::ReleaseData>::List);
		  this->fields.m_PendingReleaseMem = v11;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_PendingReleaseMem, v12, v13, v14, v16);
		}
		
		static SkinnedMeshCaptureManager() {} // 0x0000000184D80D50-0x0000000184D80D80
		// SkinnedMeshCaptureManager()
		void HG::Rendering::Runtime::SkinnedMeshCaptureManager::cctor(MethodInfo *method)
		{
		  TypeInfo::HG::Rendering::Runtime::SkinnedMeshCaptureManager->static_fields->BAKE_SKIN_MATRICES_CB = UnityEngine::Shader::PropertyToID((String *)"BakedSkinMatrices", 0LL);
		}
		
	
		// Methods
		public void RequestCapture(MeshRenderer meshRenderer, SkinnedMeshRenderer skinnedMeshRenderer, MaterialPropertyBlock propertyBlock) {} // 0x0000000189B5BC44-0x0000000189B5BF4C
		// Void RequestCapture(MeshRenderer, SkinnedMeshRenderer, MaterialPropertyBlock)
		void HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestCapture(
		        SkinnedMeshCaptureManager *this,
		        MeshRenderer *meshRenderer,
		        SkinnedMeshRenderer *skinnedMeshRenderer,
		        MaterialPropertyBlock *propertyBlock,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ *m_requests; // rcx
		  Transform__Array *bones; // rax
		  int32_t size; // r14d
		  int v13; // esi
		  int32_t v14; // ebx
		  String *name; // rbx
		  String *v16; // rax
		  String *v17; // rax
		  String *v18; // rbx
		  String *v19; // rax
		  String *v20; // rax
		  Void *skinMatrices; // r13
		  Mesh *sharedMesh; // rax
		  int32_t v23; // ebx
		  HGRuntimeGrassQuery_Node *v24; // rdx
		  HGRuntimeGrassQuery_Node *v25; // r8
		  Int32__Array **v26; // r9
		  String *v27; // rax
		  String *v28; // rax
		  HGRuntimeGrassQuery_Node *v29; // rdx
		  HGRuntimeGrassQuery_Node *v30; // r8
		  Int32__Array **v31; // r9
		  HGRuntimeGrassQuery_Node *v32; // rdx
		  HGRuntimeGrassQuery_Node *v33; // r8
		  Int32__Array **v34; // r9
		  __int64 v35; // r10
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v37; // [rsp+28h] [rbp-81h]
		  MethodInfo *v38; // [rsp+28h] [rbp-81h]
		  MethodInfo *v39; // [rsp+28h] [rbp-81h]
		  unsigned int InstanceID; // [rsp+38h] [rbp-71h]
		  _BYTE v41[40]; // [rsp+40h] [rbp-69h] BYREF
		  __int128 v42; // [rsp+68h] [rbp-41h]
		  SkinnedMeshCaptureManager_RequestData value; // [rsp+78h] [rbp-31h] BYREF
		  _OWORD v44[2]; // [rsp+A8h] [rbp-1h] BYREF
		  __int64 v45; // [rsp+C8h] [rbp+1Fh]
		
		  memset(&value, 0, sizeof(value));
		  memset(&v41[8], 0, 32);
		  if ( !IFix::WrappersManagerImpl::IsPatched(2353, 0LL) )
		  {
		    if ( !skinnedMeshRenderer )
		      goto LABEL_19;
		    bones = UnityEngine::SkinnedMeshRenderer::get_bones(skinnedMeshRenderer, 0LL);
		    if ( !bones )
		      goto LABEL_19;
		    size = bones->max_length.size;
		    v13 = 48 * size + 64;
		    if ( !meshRenderer )
		      goto LABEL_19;
		    InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)meshRenderer, 0LL);
		    v14 = InstanceID;
		    if ( !UnityEngine::SkinnedMeshRenderer::SkinMatricesRequestFinished(skinnedMeshRenderer, 0LL) )
		    {
		      name = UnityEngine::Object::get_name((Object_1 *)meshRenderer, 0LL);
		      v16 = UnityEngine::Object::get_name((Object_1 *)skinnedMeshRenderer, 0LL);
		      v17 = System::String::Concat(
		              (String *)"Request capture but skinned mesh renderer request is not finished ",
		              name,
		              (String *)" ",
		              v16,
		              0LL);
		      HG::Rendering::HGRPLogger::LogError(v17, 0LL);
		      v14 = InstanceID;
		    }
		    m_requests = this->fields.m_requests;
		    if ( !m_requests )
		      goto LABEL_19;
		    if ( System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::TryGetValue(
		           m_requests,
		           v14,
		           &value,
		           MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::TryGetValue) )
		    {
		      v18 = UnityEngine::Object::get_name((Object_1 *)meshRenderer, 0LL);
		      v19 = UnityEngine::Object::get_name((Object_1 *)skinnedMeshRenderer, 0LL);
		      v20 = System::String::Concat((String *)"request capture but mesh renderer is used ", v18, (String *)" ", v19, 0LL);
		      HG::Rendering::HGRPLogger::LogError(v20, 0LL);
		      m_requests = (Dictionary_2_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ *)value.skinnedMeshRenderer;
		      skinMatrices = (Void *)value.skinMatrices;
		      if ( !value.skinnedMeshRenderer )
		        goto LABEL_19;
		      UnityEngine::SkinnedMeshRenderer::RequestCurrentFrameSkinMatrices(value.skinnedMeshRenderer, 0LL, 0, 0LL);
		      if ( v13 == value.bufferSize )
		        goto LABEL_13;
		      HG::Rendering::Runtime::SkinnedMeshCaptureManager::DelayFreeMem(this, skinMatrices, 0LL);
		    }
		    skinMatrices = Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Malloc(v13, 16, Allocator__Enum_Persistent, 0LL);
		LABEL_13:
		    sharedMesh = UnityEngine::SkinnedMeshRenderer::get_sharedMesh(skinnedMeshRenderer, 0LL);
		    if ( sharedMesh )
		    {
		      v42 = UnityEngine::Mesh::GetBonesPerVertexValue(sharedMesh, 0LL) | 0x30u;
		      v23 = 48 * (size + 1);
		      *(_OWORD *)skinMatrices = v42;
		      Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemClear(skinMatrices + 16, v23, 0LL);
		      if ( !UnityEngine::SkinnedMeshRenderer::RequestCurrentFrameSkinMatrices(
		              skinnedMeshRenderer,
		              skinMatrices + 16,
		              v23,
		              0LL) )
		      {
		        v27 = UnityEngine::Object::get_name((Object_1 *)skinnedMeshRenderer, 0LL);
		        v28 = System::String::Concat((String *)"Skinned mesh renderer request capture failed ", v27, 0LL);
		        HG::Rendering::HGRPLogger::LogError(v28, 0LL);
		      }
		      *(_QWORD *)v41 = meshRenderer;
		      memset(&v41[8], 0, 32);
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)v41, v24, v25, v26, v37);
		      *(_QWORD *)&v41[8] = skinnedMeshRenderer;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v41[8], v29, v30, v31, v38);
		      *(_QWORD *)&v41[32] = propertyBlock;
		      *(_QWORD *)&v41[16] = skinMatrices;
		      *(_DWORD *)&v41[24] = 48 * size + 64;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v41[32], v32, v33, v34, v39);
		      if ( v35 )
		      {
		        v44[0] = *(_OWORD *)v41;
		        v45 = *(_QWORD *)&v41[32];
		        v44[1] = *(_OWORD *)&v41[16];
		        sub_1808AB970(
		          v35,
		          InstanceID,
		          v44,
		          MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::set_Item);
		        return;
		      }
		    }
		LABEL_19:
		    sub_1800D8260(m_requests, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2353, 0LL);
		  if ( !Patch )
		    goto LABEL_19;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
		    (ILFixDynamicMethodWrapper_10 *)Patch,
		    (Object *)this,
		    (Object *)meshRenderer,
		    (Object *)skinnedMeshRenderer,
		    (Object *)propertyBlock,
		    0LL);
		}
		
		public void SetCaptureDataForPropertyBlock(ScriptableRenderContext context) {} // 0x0000000183D438B0-0x0000000183D43CA0
		// Void SetCaptureDataForPropertyBlock(ScriptableRenderContext)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::SkinnedMeshCaptureManager::SetCaptureDataForPropertyBlock(
		        SkinnedMeshCaptureManager *this,
		        ScriptableRenderContext context,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v6; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ *m_requests; // rbx
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  struct MethodInfo *v14; // rbx
		  Il2CppClass *klass; // rcx
		  Il2CppClass *v16; // rcx
		  __int64 v17; // xmm1_8
		  struct Object_1__Class *v18; // rcx
		  int32_t v19; // edi
		  CBHandle *v20; // rax
		  __int64 v21; // rsi
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  struct SkinnedMeshCaptureManager__Class *v24; // rax
		  int32_t *p_BAKE_SKIN_MATRICES_CB; // rax
		  MaterialPropertyBlock *v26; // rbx
		  __int64 v27; // rdx
		  MethodInfo *size; // [rsp+20h] [rbp-1A8h]
		  Void *source[2]; // [rsp+30h] [rbp-198h]
		  MaterialPropertyBlock *source_8; // [rsp+38h] [rbp-190h]
		  __int128 v31; // [rsp+40h] [rbp-188h] BYREF
		  __int128 v32; // [rsp+50h] [rbp-178h]
		  MaterialPropertyBlock *v33; // [rsp+60h] [rbp-168h]
		  Il2CppException *ex; // [rsp+68h] [rbp-160h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ *v35; // [rsp+70h] [rbp-158h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ v36; // [rsp+78h] [rbp-150h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ v37; // [rsp+C0h] [rbp-108h] BYREF
		  Il2CppExceptionWrapper *v38; // [rsp+110h] [rbp-B8h] BYREF
		  uint32_t bufferId[4]; // [rsp+118h] [rbp-B0h]
		  Renderer *v40[2]; // [rsp+128h] [rbp-A0h]
		  Void *destination; // [rsp+148h] [rbp-80h]
		  MaterialPropertyBlock *properties; // [rsp+170h] [rbp-58h]
		  CBHandle v43[3]; // [rsp+178h] [rbp-50h] BYREF
		  ScriptableRenderContext P1; // [rsp+1D8h] [rbp+10h] BYREF
		
		  P1.m_Ptr = context.m_Ptr;
		  v31 = 0LL;
		  v32 = 0LL;
		  v33 = 0LL;
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v4, context.m_Ptr);
		  if ( wrapperArray->max_length.size <= 675 )
		    goto LABEL_13;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = v4->static_fields->wrapperArray;
		  if ( !v6 )
		    sub_1800D8260(v4, context.m_Ptr);
		  if ( v6->max_length.size <= 0x2A3u )
		    sub_1800D2AB0(v4, context.m_Ptr);
		  if ( v6[18].vector[27] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(675, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_204(Patch, (Object *)this, P1, 0LL);
		  }
		  else
		  {
		LABEL_13:
		    m_requests = this->fields.m_requests;
		    if ( !m_requests )
		      sub_1800D8260(v4, context.m_Ptr);
		    if ( m_requests->fields._count != m_requests->fields._freeCount )
		    {
		      System::Collections::Generic::Dictionary<unsigned long,Beyond::Gameplay::Core::ErosionManager::InactiveSludgeEntry>::GetEnumerator(
		        (Dictionary_2_TKey_TValue_Enumerator_System_UInt64_Beyond_Gameplay_Core_ErosionManager_InactiveSludgeEntry_ *)&v36,
		        (Dictionary_2_System_UInt64_Beyond_Gameplay_Core_ErosionManager_InactiveSludgeEntry_ *)this->fields.m_requests,
		        MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::GetEnumerator);
		      v37 = v36;
		      ex = 0LL;
		      v35 = &v37;
		      try
		      {
		        while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::MoveNext(
		                  &v37,
		                  MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::MoveNext) )
		        {
		          *(_OWORD *)&v36._dictionary = *(_OWORD *)&v37._current.key;
		          *(_OWORD *)&v36._current.key = *(_OWORD *)&v37._current.value.skinnedMeshRenderer;
		          source_8 = v37._current.value.propertyBlock;
		          *(_OWORD *)&v36._current.value.skinnedMeshRenderer = *(_OWORD *)&v37._current.value.bufferSize;
		          v14 = MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Deconstruct;
		          klass = MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Deconstruct->klass;
		          if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		            sub_1800360B0(klass, v11);
		          v16 = v14->klass;
		          if ( ((__int64)v16->vtable[0].methodPtr & 1) == 0 )
		            sub_1800360B0(v16, v11);
		          v31 = *(_OWORD *)&v36._version;
		          v32 = *(_OWORD *)&v36._current.value.meshRenderer;
		          v33 = source_8;
		          sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v31, v11, v12, v13, size);
		          v17 = v31;
		          *(_OWORD *)v40 = v31;
		          *(_OWORD *)source = v32;
		          properties = v33;
		          if ( v33 )
		          {
		            v18 = TypeInfo::UnityEngine::Object;
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		              v18 = TypeInfo::UnityEngine::Object;
		              if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		              {
		                il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		                v18 = TypeInfo::UnityEngine::Object;
		              }
		            }
		            if ( v17 )
		            {
		              if ( !v18->_1.cctor_finished_or_no_cctor )
		                il2cpp_runtime_class_init_1(v18);
		              if ( *(_QWORD *)(v17 + 16) )
		              {
		                if ( !TypeInfo::UnityEngine::Rendering::ScriptableRenderContext->_1.cctor_finished_or_no_cctor )
		                  il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                v19 = _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)source, 8));
		                v20 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(v43, &P1, v19, 0LL);
		                *(_OWORD *)bufferId = *(_OWORD *)&v20->bufferId;
		                destination = (Void *)v20->ptr;
		                v21 = HIDWORD(*(_QWORD *)&v20->bufferId);
		                Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(destination, source[0], v19, 0LL);
		                v24 = TypeInfo::HG::Rendering::Runtime::SkinnedMeshCaptureManager;
		                if ( !TypeInfo::HG::Rendering::Runtime::SkinnedMeshCaptureManager->_1.cctor_finished_or_no_cctor )
		                {
		                  il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::SkinnedMeshCaptureManager);
		                  v24 = TypeInfo::HG::Rendering::Runtime::SkinnedMeshCaptureManager;
		                }
		                p_BAKE_SKIN_MATRICES_CB = &v24->static_fields->BAKE_SKIN_MATRICES_CB;
		                v26 = properties;
		                if ( !properties )
		                  sub_1800D8250(v23, v22);
		                UnityEngine::MaterialPropertyBlock::SetConstantBufferImpl0(
		                  properties,
		                  *p_BAKE_SKIN_MATRICES_CB,
		                  bufferId[0],
		                  v21,
		                  v19,
		                  0LL);
		                if ( !v40[0] )
		                  sub_1800D8250(0LL, v27);
		                UnityEngine::Renderer::Internal_SetPropertyBlock(v40[0], v26, 0LL);
		              }
		            }
		          }
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v38 )
		      {
		        ex = v38->ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		      }
		    }
		  }
		}
		
		private unsafe void DelayFreeMem(void* mem) {} // 0x0000000189B5BAE4-0x0000000189B5BB30
		// Void DelayFreeMem(Void*)
		void HG::Rendering::Runtime::SkinnedMeshCaptureManager::DelayFreeMem(
		        SkinnedMeshCaptureManager *this,
		        Void *mem,
		        MethodInfo *method)
		{
		  List_1_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ *m_PendingReleaseMem; // r9
		  SpawnerManager_SpawnDataDetail v4; // [rsp+20h] [rbp-18h] BYREF
		
		  m_PendingReleaseMem = (List_1_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ *)this->fields.m_PendingReleaseMem;
		  v4.serverId = this->fields.m_frameCount + 10;
		  *(_QWORD *)&v4.actionId = mem;
		  if ( !m_PendingReleaseMem )
		    sub_1800D8260(this, mem);
		  System::Collections::Generic::List<Beyond::Gameplay::Core::SpawnerManager::SpawnDataDetail>::Add(
		    m_PendingReleaseMem,
		    &v4,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SkinnedMeshCaptureManager::ReleaseData>::Add);
		}
		
		public void Release(MeshRenderer meshRenderer) {} // 0x0000000189B5BB30-0x0000000189B5BC44
		// Void Release(MeshRenderer)
		void HG::Rendering::Runtime::SkinnedMeshCaptureManager::Release(
		        SkinnedMeshCaptureManager *this,
		        MeshRenderer *meshRenderer,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ *m_requests; // rcx
		  int32_t InstanceID; // eax
		  int32_t v8; // esi
		  String *name; // rax
		  String *v10; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  SkinnedMeshCaptureManager_RequestData value; // [rsp+20h] [rbp-38h] BYREF
		
		  memset(&value, 0, sizeof(value));
		  if ( IFix::WrappersManagerImpl::IsPatched(2354, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2354, 0LL);
		    if ( !Patch )
		      goto LABEL_10;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)meshRenderer,
		      0LL);
		  }
		  else
		  {
		    if ( !meshRenderer )
		      goto LABEL_10;
		    InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)meshRenderer, 0LL);
		    m_requests = this->fields.m_requests;
		    v8 = InstanceID;
		    if ( !m_requests )
		      goto LABEL_10;
		    if ( System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::TryGetValue(
		           m_requests,
		           InstanceID,
		           &value,
		           MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::TryGetValue) )
		    {
		      HG::Rendering::Runtime::SkinnedMeshCaptureManager::DelayFreeMem(this, (Void *)value.skinMatrices, 0LL);
		      m_requests = (Dictionary_2_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ *)value.meshRenderer;
		      if ( value.meshRenderer )
		      {
		        UnityEngine::Renderer::Internal_SetPropertyBlock((Renderer *)value.meshRenderer, 0LL, 0LL);
		        m_requests = this->fields.m_requests;
		        if ( m_requests )
		        {
		          System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Remove(
		            m_requests,
		            v8,
		            MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Remove);
		          return;
		        }
		      }
		LABEL_10:
		      sub_1800D8260(m_requests, v5);
		    }
		    name = UnityEngine::Object::get_name((Object_1 *)meshRenderer, 0LL);
		    v10 = System::String::Concat((String *)"Try to Release a invalid id in skinnedMeshCaptureManager ", name, 0LL);
		    HG::Rendering::HGRPLogger::LogError(v10, 0LL);
		  }
		}
		
		public void PipelineUpdate() {} // 0x0000000183BBA9C0-0x0000000183BBAF90
		// Void PipelineUpdate()
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::SkinnedMeshCaptureManager::PipelineUpdate(
		        SkinnedMeshCaptureManager *this,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v2; // r8
		  Int32__Array **v3; // r9
		  SkinnedMeshCaptureManager *v4; // rdi
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
		  ILFixDynamicMethodWrapper_2__Array *v7; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Dictionary_2_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ *m_requests; // rbx
		  struct Object_1__Class *v12; // rcx
		  List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *v13; // r8
		  unsigned int v14; // ebx
		  List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *size; // rdx
		  __int64 v16; // rcx
		  __int64 v17; // rax
		  char *v18; // r9
		  int v19; // esi
		  __int128 v20; // xmm6
		  __int128 v21; // xmm7
		  __int64 v22; // xmm8_8
		  Il2CppClass *klass; // rcx
		  HGRuntimeGrassQuery_Node *v24; // rdx
		  HGRuntimeGrassQuery_Node *v25; // r8
		  Int32__Array **v26; // r9
		  HGRuntimeGrassQuery_Node *v27; // rdx
		  HGRuntimeGrassQuery_Node *v28; // r8
		  Int32__Array **v29; // r9
		  __m128d v30; // xmm6
		  struct MethodInfo *v31; // rsi
		  Il2CppClass *v32; // rcx
		  Il2CppClass *v33; // rcx
		  __int64 v34; // rdx
		  Renderer *v35; // xmm6_8
		  Renderer *v36; // rsi
		  SkinnedMeshCaptureManager_ReleaseData__Array *items; // rcx
		  List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *m_PendingReleaseMem; // rax
		  List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *v39; // rax
		  List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *v40; // rax
		  __int64 v41; // [rsp+0h] [rbp-168h] BYREF
		  __int128 v42; // [rsp+20h] [rbp-148h] BYREF
		  __int128 v43; // [rsp+30h] [rbp-138h] BYREF
		  __int128 v44; // [rsp+40h] [rbp-128h]
		  __m128d v45; // [rsp+50h] [rbp-118h]
		  Bounds__Array *grassInstanceBounds; // [rsp+60h] [rbp-108h]
		  _OWORD v47[3]; // [rsp+70h] [rbp-F8h] BYREF
		  Il2CppException *ex; // [rsp+A0h] [rbp-C8h]
		  __int128 *v49; // [rsp+A8h] [rbp-C0h]
		  Renderer *v50[2]; // [rsp+B0h] [rbp-B8h] BYREF
		  __int128 v51; // [rsp+C0h] [rbp-A8h]
		  __int64 v52; // [rsp+D0h] [rbp-98h]
		  HGRuntimeGrassQuery_Node v53; // [rsp+D8h] [rbp-90h] BYREF
		  Il2CppExceptionWrapper *v54; // [rsp+120h] [rbp-48h] BYREF
		
		  v4 = this;
		  *(_OWORD *)v50 = 0LL;
		  v51 = 0LL;
		  v52 = 0LL;
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v5, method);
		  if ( wrapperArray->max_length.size <= 2324 )
		    goto LABEL_12;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v7 = v5->static_fields->wrapperArray;
		  if ( !v7 )
		    sub_1800D8260(v5, method);
		  if ( v7->max_length.size <= 0x914u )
		    sub_1800D2AB0(v5, method);
		  if ( v7[64].vector[20] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2324, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)v4, 0LL);
		  }
		  else
		  {
		LABEL_12:
		    m_requests = v4->fields.m_requests;
		    if ( !m_requests )
		      sub_1800D8260(v5, method);
		    memset(&v53.monitor, 0, 64);
		    v53.klass = (HGRuntimeGrassQuery_Node__Class *)m_requests;
		    sub_18002D1B0(&v53, (HGRuntimeGrassQuery_Node *)method, v2, v3, (MethodInfo *)v42);
		    v53.monitor = (MonitorData *)(unsigned int)m_requests->fields._version;
		    v14 = 0;
		    LODWORD(v53.fields.grassInstanceBounds) = 2;
		    v42 = *(_OWORD *)&v53.klass;
		    v43 = 0LL;
		    v44 = 0LL;
		    v45 = 0LL;
		    grassInstanceBounds = v53.fields.grassInstanceBounds;
		    ex = 0LL;
		    v49 = &v42;
		    try
		    {
		LABEL_14:
		      size = (List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *)v42;
		      if ( !(_QWORD)v42 )
		        sub_1800D8250(v12, 0LL);
		      if ( DWORD2(v42) != *(_DWORD *)(v42 + 44) )
		        System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
		      LODWORD(v16) = HIDWORD(v42);
		      while ( (unsigned int)v16 < *(_DWORD *)(v42 + 32) )
		      {
		        v13 = *(List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ **)(v42 + 24);
		        v17 = (int)v16;
		        v16 = (unsigned int)(v16 + 1);
		        HIDWORD(v42) = v16;
		        if ( !v13 )
		          sub_1800D8250(v16, v42);
		        if ( (unsigned int)v17 >= v13->fields._size )
		          sub_1800D2AA0(v16, v42, v13);
		        v18 = (char *)v13 + 56 * v17;
		        if ( *((int *)v18 + 8) >= 0 )
		        {
		          v19 = *((_DWORD *)v18 + 10);
		          memset(v47, 0, sizeof(v47));
		          v20 = *((_OWORD *)v18 + 3);
		          v21 = *((_OWORD *)v18 + 4);
		          v22 = *((_QWORD *)v18 + 10);
		          klass = MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::MoveNext->klass;
		          if ( ((__int64)klass->vtable[0].methodPtr & 1) == 0 )
		            sub_1800360B0(klass, v42);
		          LODWORD(v47[0]) = v19;
		          *(_OWORD *)((char *)v47 + 8) = v20;
		          *(_OWORD *)((char *)&v47[1] + 8) = v21;
		          *((_QWORD *)&v47[2] + 1) = v22;
		          sub_18002D1B0(
		            (HGRuntimeGrassQuery_Node *)((char *)v47 + 8),
		            (HGRuntimeGrassQuery_Node *)size,
		            (HGRuntimeGrassQuery_Node *)v13,
		            (Int32__Array **)v18,
		            (MethodInfo *)v42);
		          v43 = v47[0];
		          v44 = v47[1];
		          v45 = (__m128d)v47[2];
		          sub_18002D1B0((HGRuntimeGrassQuery_Node *)((char *)&v43 + 8), v24, v25, v26, (MethodInfo *)v42);
		          *(_OWORD *)&v53.klass = v43;
		          *(_OWORD *)&v53.fields.bounds.m_Center.x = v44;
		          v30 = v45;
		          *(__m128d *)&v53.fields.bounds.m_Extents.y = v45;
		          v31 = MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Deconstruct;
		          v32 = MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Deconstruct->klass;
		          if ( ((__int64)v32->vtable[0].methodPtr & 1) == 0 )
		            sub_1800360B0(v32, v27);
		          v33 = v31->klass;
		          if ( ((__int64)v33->vtable[0].methodPtr & 1) == 0 )
		            sub_1800360B0(v33, v27);
		          *(_OWORD *)v50 = *(_OWORD *)&v53.monitor;
		          v51 = *(_OWORD *)&v53.fields.bounds.m_Center.z;
		          v52 = *(_OWORD *)&_mm_unpackhi_pd(v30, v30);
		          sub_18002D1B0((HGRuntimeGrassQuery_Node *)v50, v27, v28, v29, (MethodInfo *)v42);
		          v35 = v50[0];
		          v47[1] = v51;
		          *(_QWORD *)&v47[2] = v52;
		          v36 = v50[0];
		          v12 = TypeInfo::UnityEngine::Object;
		          if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		          {
		            il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		            v12 = TypeInfo::UnityEngine::Object;
		            if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		            {
		              il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		              v12 = TypeInfo::UnityEngine::Object;
		            }
		          }
		          if ( v36 )
		          {
		            if ( !v12->_1.cctor_finished_or_no_cctor )
		              il2cpp_runtime_class_init_1(v12);
		            if ( v36->fields._._.m_CachedPtr )
		            {
		              if ( !v35 )
		                sub_1800D8250(0LL, v34);
		              UnityEngine::Renderer::Internal_SetPropertyBlock(v35, 0LL, 0LL);
		            }
		          }
		          goto LABEL_14;
		        }
		      }
		      HIDWORD(v42) = *(_DWORD *)(v42 + 32) + 1;
		      v43 = 0LL;
		      v44 = 0LL;
		      v45 = 0LL;
		    }
		    catch ( Il2CppExceptionWrapper *v54 )
		    {
		      size = (List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *)&v41;
		      ex = v54->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v14 = 0;
		      v4 = this;
		    }
		    items = 0LL;
		    m_PendingReleaseMem = v4->fields.m_PendingReleaseMem;
		    if ( !m_PendingReleaseMem )
		LABEL_73:
		      sub_1800D8250(items, size);
		    while ( (int)items < m_PendingReleaseMem->fields._size )
		    {
		      v39 = v4->fields.m_PendingReleaseMem;
		      if ( !v39 )
		        goto LABEL_73;
		      if ( v14 >= v39->fields._size )
		        goto LABEL_75;
		      items = v39->fields._items;
		      if ( !items )
		        goto LABEL_73;
		      if ( v14 >= items->max_length.size )
		        goto LABEL_74;
		      if ( items->vector[v14].frame < v4->fields.m_frameCount )
		      {
		        v40 = v4->fields.m_PendingReleaseMem;
		        if ( !v40 )
		          goto LABEL_73;
		        if ( v14 >= v40->fields._size )
		          goto LABEL_75;
		        items = v40->fields._items;
		        if ( !items )
		          goto LABEL_73;
		        if ( v14 >= items->max_length.size )
		          goto LABEL_74;
		        Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Free(
		          items->vector[v14].mem,
		          Allocator__Enum_Persistent,
		          0LL);
		        v13 = v4->fields.m_PendingReleaseMem;
		        if ( !v13 )
		          goto LABEL_73;
		        size = (List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *)v13->fields._size;
		        if ( (unsigned int)((_DWORD)size - 1) >= v13->fields._size )
		LABEL_75:
		          System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
		        items = v13->fields._items;
		        if ( !items )
		          goto LABEL_73;
		        if ( (unsigned int)((_DWORD)size - 1) >= items->max_length.size )
		          goto LABEL_74;
		        size = (List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *)((char *)items
		                                                                                    + 16 * ((_QWORD)&size->klass + 1));
		        if ( v14 >= v13->fields._size )
		          goto LABEL_75;
		        if ( v14 >= items->max_length.size )
		LABEL_74:
		          sub_1800D2AA0(items, size, v13);
		        items->vector[v14] = *(SkinnedMeshCaptureManager_ReleaseData *)&size->klass;
		        ++v13->fields._version;
		        size = v4->fields.m_PendingReleaseMem;
		        if ( !size )
		          goto LABEL_73;
		        System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::RemoveAt(
		          (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)v4->fields.m_PendingReleaseMem,
		          size->fields._size - 1,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SkinnedMeshCaptureManager::ReleaseData>::RemoveAt);
		      }
		      else
		      {
		        ++v14;
		      }
		      items = (SkinnedMeshCaptureManager_ReleaseData__Array *)v14;
		      m_PendingReleaseMem = v4->fields.m_PendingReleaseMem;
		      if ( !m_PendingReleaseMem )
		        goto LABEL_73;
		    }
		    ++v4->fields.m_frameCount;
		  }
		}
		
	}
}
