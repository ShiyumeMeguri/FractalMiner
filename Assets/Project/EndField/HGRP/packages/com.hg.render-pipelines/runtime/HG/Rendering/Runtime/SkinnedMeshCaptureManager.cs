using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class SkinnedMeshCaptureManager
	{
		public SkinnedMeshCaptureManager()
		{
		}

		public void RequestCapture(MeshRenderer meshRenderer, SkinnedMeshRenderer skinnedMeshRenderer, MaterialPropertyBlock propertyBlock)
		{
			// // Void RequestCapture(MeshRenderer, SkinnedMeshRenderer, MaterialPropertyBlock)
			// void HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestCapture(
			//         SkinnedMeshCaptureManager *this,
			//         MeshRenderer *meshRenderer,
			//         SkinnedMeshRenderer *skinnedMeshRenderer,
			//         MaterialPropertyBlock *propertyBlock,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ *m_requests; // rcx
			//   Transform__Array *bones; // rax
			//   int32_t size; // r14d
			//   int v13; // esi
			//   int32_t v14; // ebx
			//   String *name; // rbx
			//   String *v16; // rax
			//   String *v17; // rax
			//   String *v18; // rbx
			//   String *v19; // rax
			//   String *v20; // rax
			//   Void *skinMatrices; // rbx
			//   int v22; // r14d
			//   Mesh *sharedMesh; // rax
			//   HGRenderPathBase_HGRenderPathResources *v24; // rdx
			//   PassConstructorID__Enum__Array *v25; // r8
			//   HGCamera *v26; // r9
			//   String *v27; // rax
			//   String *v28; // rax
			//   HGRenderPathBase_HGRenderPathResources *v29; // rdx
			//   PassConstructorID__Enum__Array *v30; // r8
			//   HGCamera *v31; // r9
			//   HGRenderPathBase_HGRenderPathResources *v32; // rdx
			//   PassConstructorID__Enum__Array *v33; // r8
			//   HGCamera *v34; // r9
			//   __int64 v35; // r10
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *P3; // [rsp+28h] [rbp-81h]
			//   MethodInfo *P3a; // [rsp+28h] [rbp-81h]
			//   MethodInfo *P3b; // [rsp+28h] [rbp-81h]
			//   MethodInfo *v40; // [rsp+30h] [rbp-79h]
			//   MethodInfo *v41; // [rsp+30h] [rbp-79h]
			//   MethodInfo *v42; // [rsp+30h] [rbp-79h]
			//   unsigned int InstanceID; // [rsp+38h] [rbp-71h]
			//   Void *v44; // [rsp+40h] [rbp-69h]
			//   _BYTE v45[40]; // [rsp+48h] [rbp-61h] BYREF
			//   __int128 v46; // [rsp+70h] [rbp-39h]
			//   SkinnedMeshCaptureManager_RequestData value; // [rsp+80h] [rbp-29h] BYREF
			//   _OWORD v48[2]; // [rsp+A8h] [rbp-1h] BYREF
			//   __int64 v49; // [rsp+C8h] [rbp+1Fh]
			// 
			//   if ( !byte_18D9193EE )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::TryGetValue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::set_Item);
			//     sub_18003C530(&off_18D4E5748);
			//     sub_18003C530(&off_18C9E5098);
			//     sub_18003C530(&off_18D4E5758);
			//     sub_18003C530(&off_18D4E5768);
			//     byte_18D9193EE = 1;
			//   }
			//   memset(&value, 0, sizeof(value));
			//   memset(&v45[8], 0, 32);
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1983, 0LL) )
			//   {
			//     if ( !skinnedMeshRenderer )
			//       goto LABEL_21;
			//     bones = UnityEngine::SkinnedMeshRenderer::get_bones(skinnedMeshRenderer, 0LL);
			//     if ( !bones )
			//       goto LABEL_21;
			//     size = bones.max_length.size;
			//     v13 = 48 * size + 64;
			//     if ( !meshRenderer )
			//       goto LABEL_21;
			//     InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)meshRenderer, 0LL);
			//     v14 = InstanceID;
			//     if ( !UnityEngine::SkinnedMeshRenderer::SkinMatricesRequestFinished(skinnedMeshRenderer, 0LL) )
			//     {
			//       name = UnityEngine::Object::get_name((Object_1 *)meshRenderer, 0LL);
			//       v16 = UnityEngine::Object::get_name((Object_1 *)skinnedMeshRenderer, 0LL);
			//       v17 = System::String::Concat(
			//               (String *)"Request capture but skinned mesh renderer request is not finished ",
			//               name,
			//               (String *)" ",
			//               v16,
			//               0LL);
			//       HG::Rendering::HGRPLogger::LogError(v17, 0LL);
			//       v14 = InstanceID;
			//     }
			//     m_requests = this.fields.m_requests;
			//     if ( !m_requests )
			//       goto LABEL_21;
			//     if ( System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::TryGetValue(
			//            m_requests,
			//            v14,
			//            &value,
			//            MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::TryGetValue) )
			//     {
			//       v18 = UnityEngine::Object::get_name((Object_1 *)meshRenderer, 0LL);
			//       v19 = UnityEngine::Object::get_name((Object_1 *)skinnedMeshRenderer, 0LL);
			//       v20 = System::String::Concat((String *)"request capture but mesh renderer is used ", v18, (String *)" ", v19, 0LL);
			//       HG::Rendering::HGRPLogger::LogError(v20, 0LL);
			//       m_requests = (Dictionary_2_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ *)value.skinnedMeshRenderer;
			//       skinMatrices = (Void *)value.skinMatrices;
			//       v44 = (Void *)value.skinMatrices;
			//       if ( !value.skinnedMeshRenderer )
			//         goto LABEL_21;
			//       UnityEngine::SkinnedMeshRenderer::RequestCurrentFrameSkinMatrices(value.skinnedMeshRenderer, 0LL, 0, 0LL);
			//       if ( v13 == value.bufferSize )
			//         goto LABEL_15;
			//       HG::Rendering::Runtime::SkinnedMeshCaptureManager::DelayFreeMem(this, skinMatrices, 0LL);
			//     }
			//     v44 = Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Malloc(v13, 16, Allocator__Enum_Persistent, 0LL);
			//     skinMatrices = v44;
			// LABEL_15:
			//     v22 = size + 1;
			//     sharedMesh = UnityEngine::SkinnedMeshRenderer::get_sharedMesh(skinnedMeshRenderer, 0LL);
			//     if ( sharedMesh )
			//     {
			//       v46 = UnityEngine::Mesh::GetBonesPerVertexValue(sharedMesh, 0LL) | 0x30u;
			//       *(_OWORD *)skinMatrices = v46;
			//       Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemClear(v44 + 16, 48 * v22, 0LL);
			//       if ( !UnityEngine::SkinnedMeshRenderer::RequestCurrentFrameSkinMatrices(
			//               skinnedMeshRenderer,
			//               v44 + 16,
			//               48 * v22,
			//               0LL) )
			//       {
			//         v27 = UnityEngine::Object::get_name((Object_1 *)skinnedMeshRenderer, 0LL);
			//         v28 = System::String::Concat((String *)"Skinned mesh renderer request capture failed ", v27, 0LL);
			//         HG::Rendering::HGRPLogger::LogError(v28, 0LL);
			//       }
			//       *(_QWORD *)v45 = meshRenderer;
			//       memset(&v45[8], 0, 32);
			//       sub_1800054D0((HGRenderPathScene *)v45, v24, v25, v26, P3, v40);
			//       *(_QWORD *)&v45[8] = skinnedMeshRenderer;
			//       sub_1800054D0((HGRenderPathScene *)&v45[8], v29, v30, v31, P3a, v41);
			//       *(_QWORD *)&v45[32] = propertyBlock;
			//       *(_QWORD *)&v45[16] = v44;
			//       *(_DWORD *)&v45[24] = v13;
			//       sub_1800054D0((HGRenderPathScene *)&v45[32], v32, v33, v34, P3b, v42);
			//       if ( v35 )
			//       {
			//         v48[0] = *(_OWORD *)v45;
			//         v49 = *(_QWORD *)&v45[32];
			//         v48[1] = *(_OWORD *)&v45[16];
			//         sub_18082C528(
			//           v35,
			//           InstanceID,
			//           v48,
			//           MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::set_Item);
			//         return;
			//       }
			//     }
			// LABEL_21:
			//     sub_180B536AC(m_requests, v9);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1983, 0LL);
			//   if ( !Patch )
			//     goto LABEL_21;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7(
			//     (ILFixDynamicMethodWrapper_20 *)Patch,
			//     (Object *)this,
			//     (Object *)meshRenderer,
			//     (Object *)skinnedMeshRenderer,
			//     (Object *)propertyBlock,
			//     0LL);
			// }
			// 
		}

		public void SetCaptureDataForPropertyBlock(ScriptableRenderContext context)
		{
			// // Void SetCaptureDataForPropertyBlock(ScriptableRenderContext)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::SkinnedMeshCaptureManager::SetCaptureDataForPropertyBlock(
			//         SkinnedMeshCaptureManager *this,
			//         ScriptableRenderContext context,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v6; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ *m_requests; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   struct MethodInfo *v14; // rbx
			//   Il2CppClass *klass; // rcx
			//   Il2CppClass *v16; // rcx
			//   __int64 v17; // rdx
			//   __int64 v18; // xmm1_8
			//   int32_t v19; // edi
			//   CBHandle *v20; // rax
			//   __int64 v21; // rsi
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   struct SkinnedMeshCaptureManager__Class *v24; // rax
			//   int32_t *p_BAKE_SKIN_MATRICES_CB; // rax
			//   MaterialPropertyBlock *v26; // rbx
			//   __int64 v27; // rdx
			//   MethodInfo *size; // [rsp+20h] [rbp-1A8h]
			//   MethodInfo *methoda; // [rsp+28h] [rbp-1A0h]
			//   Void *source[2]; // [rsp+30h] [rbp-198h]
			//   MaterialPropertyBlock *source_8; // [rsp+38h] [rbp-190h]
			//   __int128 v32; // [rsp+40h] [rbp-188h] BYREF
			//   __int128 v33; // [rsp+50h] [rbp-178h]
			//   MaterialPropertyBlock *v34; // [rsp+60h] [rbp-168h]
			//   Il2CppException *ex; // [rsp+68h] [rbp-160h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ *v36; // [rsp+70h] [rbp-158h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ v37; // [rsp+78h] [rbp-150h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ v38; // [rsp+C0h] [rbp-108h] BYREF
			//   Il2CppExceptionWrapper *v39; // [rsp+110h] [rbp-B8h] BYREF
			//   uint32_t bufferId[4]; // [rsp+118h] [rbp-B0h]
			//   Renderer *v41[2]; // [rsp+128h] [rbp-A0h]
			//   Void *destination; // [rsp+148h] [rbp-80h]
			//   MaterialPropertyBlock *properties; // [rsp+170h] [rbp-58h]
			//   CBHandle v44[3]; // [rsp+178h] [rbp-50h] BYREF
			//   ScriptableRenderContext P1; // [rsp+1D8h] [rbp+10h] BYREF
			// 
			//   P1.m_Ptr = context.m_Ptr;
			//   if ( !byte_18D8ED976 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Deconstruct);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SkinnedMeshCaptureManager);
			//     byte_18D8ED976 = 1;
			//   }
			//   v32 = 0LL;
			//   v33 = 0LL;
			//   v34 = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, context.m_Ptr);
			//     v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v4.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v4, context.m_Ptr);
			//   if ( wrapperArray.max_length.size <= 637 )
			//     goto LABEL_17;
			//   if ( !v4._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v4, context.m_Ptr);
			//     v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = v4.static_fields.wrapperArray;
			//   if ( !v6 )
			//     sub_180B536AC(v4, context.m_Ptr);
			//   if ( v6.max_length.size <= 0x27Du )
			//     sub_180070270(v4, context.m_Ptr);
			//   if ( v6[17].vector[25] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(637, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_197(Patch, (Object *)this, P1, 0LL);
			//   }
			//   else
			//   {
			// LABEL_17:
			//     m_requests = this.fields.m_requests;
			//     if ( !m_requests )
			//       sub_180B536AC(v4, context.m_Ptr);
			//     if ( m_requests.fields._count != m_requests.fields._freeCount )
			//     {
			//       System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::GetEnumerator(
			//         &v37,
			//         this.fields.m_requests,
			//         MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::GetEnumerator);
			//       v38 = v37;
			//       ex = 0LL;
			//       v36 = &v38;
			//       try
			//       {
			//         while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::MoveNext(
			//                   &v38,
			//                   MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::MoveNext) )
			//         {
			//           *(_OWORD *)&v37._dictionary = *(_OWORD *)&v38._current.key;
			//           *(_OWORD *)&v37._current.key = *(_OWORD *)&v38._current.value.skinnedMeshRenderer;
			//           source_8 = v38._current.value.propertyBlock;
			//           *(_OWORD *)&v37._current.value.skinnedMeshRenderer = *(_OWORD *)&v38._current.value.bufferSize;
			//           v14 = MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Deconstruct;
			//           klass = MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Deconstruct.klass;
			//           if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//             sub_18003C700(klass);
			//           v16 = v14.klass;
			//           if ( ((__int64)v16.vtable[0].methodPtr & 1) == 0 )
			//             sub_18003C700(v16);
			//           v32 = *(_OWORD *)&v37._version;
			//           v33 = *(_OWORD *)&v37._current.value.meshRenderer;
			//           v34 = source_8;
			//           sub_1800054D0((HGRenderPathScene *)&v32, v11, v12, v13, size, methoda);
			//           v18 = v32;
			//           *(_OWORD *)v41 = v32;
			//           *(_OWORD *)source = v33;
			//           properties = v34;
			//           if ( v34 )
			//           {
			//             if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//             if ( !byte_18D8F4EFA )
			//             {
			//               sub_18003C530(&TypeInfo::UnityEngine::Object);
			//               byte_18D8F4EFA = 1;
			//             }
			//             if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//             if ( !byte_18D8F4EAF )
			//             {
			//               sub_18003C530(&TypeInfo::UnityEngine::Object);
			//               byte_18D8F4EAF = 1;
			//             }
			//             if ( v18 )
			//             {
			//               if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                 il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//               if ( *(_QWORD *)(v18 + 16) )
			//               {
			//                 if ( !TypeInfo::UnityEngine::Rendering::ScriptableRenderContext._1.cctor_finished_or_no_cctor )
			//                   il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext, v17);
			//                 v19 = _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)source, 8));
			//                 v20 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(v44, &P1, v19, 0LL);
			//                 *(_OWORD *)bufferId = *(_OWORD *)&v20.bufferId;
			//                 destination = (Void *)v20.ptr;
			//                 v21 = HIDWORD(*(_QWORD *)&v20.bufferId);
			//                 Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(destination, source[0], v19, 0LL);
			//                 v24 = TypeInfo::HG::Rendering::Runtime::SkinnedMeshCaptureManager;
			//                 if ( !TypeInfo::HG::Rendering::Runtime::SkinnedMeshCaptureManager._1.cctor_finished_or_no_cctor )
			//                 {
			//                   il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::SkinnedMeshCaptureManager, v22);
			//                   v24 = TypeInfo::HG::Rendering::Runtime::SkinnedMeshCaptureManager;
			//                 }
			//                 p_BAKE_SKIN_MATRICES_CB = &v24.static_fields.BAKE_SKIN_MATRICES_CB;
			//                 v26 = properties;
			//                 if ( !properties )
			//                   sub_1802DC2C8(v23, v22);
			//                 UnityEngine::MaterialPropertyBlock::SetConstantBufferImpl0(
			//                   properties,
			//                   *p_BAKE_SKIN_MATRICES_CB,
			//                   bufferId[0],
			//                   v21,
			//                   v19,
			//                   0LL);
			//                 if ( !v41[0] )
			//                   sub_1802DC2C8(0LL, v27);
			//                 UnityEngine::Renderer::Internal_SetPropertyBlock(v41[0], v26, 0LL);
			//               }
			//             }
			//           }
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v39 )
			//       {
			//         ex = v39.ex;
			//         if ( ex )
			//           sub_18000F780(ex);
			//       }
			//     }
			//   }
			// }
			// 
		}

		private unsafe void DelayFreeMem(void* mem)
		{
			// // Void DelayFreeMem(Void*)
			// void HG::Rendering::Runtime::SkinnedMeshCaptureManager::DelayFreeMem(
			//         SkinnedMeshCaptureManager *this,
			//         Void *mem,
			//         MethodInfo *method)
			// {
			//   List_1_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ *m_PendingReleaseMem; // rcx
			//   SpawnerManager_SpawnDataDetail v6; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D9193EF )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SkinnedMeshCaptureManager::ReleaseData>::Add);
			//     byte_18D9193EF = 1;
			//   }
			//   m_PendingReleaseMem = (List_1_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ *)this.fields.m_PendingReleaseMem;
			//   v6.serverId = this.fields.m_frameCount + 10;
			//   *(_QWORD *)&v6.actionId = mem;
			//   if ( !m_PendingReleaseMem )
			//     sub_180B536AC(0LL, mem);
			//   System::Collections::Generic::List<Beyond::Gameplay::Core::SpawnerManager::SpawnDataDetail>::Add(
			//     m_PendingReleaseMem,
			//     &v6,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SkinnedMeshCaptureManager::ReleaseData>::Add);
			// }
			// 
		}

		public void Release(MeshRenderer meshRenderer)
		{
			// // Void Release(MeshRenderer)
			// void HG::Rendering::Runtime::SkinnedMeshCaptureManager::Release(
			//         SkinnedMeshCaptureManager *this,
			//         MeshRenderer *meshRenderer,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ *m_requests; // rcx
			//   int32_t InstanceID; // eax
			//   int32_t v8; // esi
			//   String *name; // rax
			//   String *v10; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   SkinnedMeshCaptureManager_RequestData value; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D9193F0 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::TryGetValue);
			//     sub_18003C530(&off_18D4E57B8);
			//     byte_18D9193F0 = 1;
			//   }
			//   memset(&value, 0, sizeof(value));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1984, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1984, 0LL);
			//     if ( !Patch )
			//       goto LABEL_12;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)meshRenderer,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !meshRenderer )
			//       goto LABEL_12;
			//     InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)meshRenderer, 0LL);
			//     m_requests = this.fields.m_requests;
			//     v8 = InstanceID;
			//     if ( !m_requests )
			//       goto LABEL_12;
			//     if ( System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::TryGetValue(
			//            m_requests,
			//            InstanceID,
			//            &value,
			//            MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::TryGetValue) )
			//     {
			//       HG::Rendering::Runtime::SkinnedMeshCaptureManager::DelayFreeMem(this, (Void *)value.skinMatrices, 0LL);
			//       m_requests = (Dictionary_2_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ *)value.meshRenderer;
			//       if ( value.meshRenderer )
			//       {
			//         UnityEngine::Renderer::Internal_SetPropertyBlock((Renderer *)value.meshRenderer, 0LL, 0LL);
			//         m_requests = this.fields.m_requests;
			//         if ( m_requests )
			//         {
			//           System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Remove(
			//             m_requests,
			//             v8,
			//             MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Remove);
			//           return;
			//         }
			//       }
			// LABEL_12:
			//       sub_180B536AC(m_requests, v5);
			//     }
			//     name = UnityEngine::Object::get_name((Object_1 *)meshRenderer, 0LL);
			//     v10 = System::String::Concat((String *)"Try to Release a invalid id in skinnedMeshCaptureManager ", name, 0LL);
			//     HG::Rendering::HGRPLogger::LogError(v10, 0LL);
			//   }
			// }
			// 
		}

		public void PipelineUpdate()
		{
			// // Void PipelineUpdate()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::SkinnedMeshCaptureManager::PipelineUpdate(
			//         SkinnedMeshCaptureManager *this,
			//         MethodInfo *method)
			// {
			//   PassConstructorID__Enum__Array *v2; // r8
			//   HGCamera *v3; // r9
			//   SkinnedMeshCaptureManager *v4; // rdi
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_SkinnedMeshCaptureManager_RequestData_ *m_requests; // rbx
			//   struct Object_1__Class *v12; // rcx
			//   List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *v13; // r8
			//   char *v14; // r9
			//   unsigned int v15; // ebx
			//   List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *size; // rdx
			//   __int64 v17; // rcx
			//   __int64 v18; // rax
			//   int v19; // esi
			//   __int128 v20; // xmm6
			//   __int128 v21; // xmm7
			//   __int64 v22; // xmm8_8
			//   Il2CppClass *klass; // rcx
			//   HGRenderPathBase_HGRenderPathResources *v24; // rdx
			//   PassConstructorID__Enum__Array *v25; // r8
			//   HGCamera *v26; // r9
			//   HGRenderPathBase_HGRenderPathResources *v27; // rdx
			//   PassConstructorID__Enum__Array *v28; // r8
			//   HGCamera *v29; // r9
			//   __m128d v30; // xmm6
			//   struct MethodInfo *v31; // rsi
			//   Il2CppClass *v32; // rcx
			//   Il2CppClass *v33; // rcx
			//   __int64 v34; // rdx
			//   Renderer *v35; // xmm6_8
			//   Renderer *v36; // rsi
			//   SkinnedMeshCaptureManager_ReleaseData__Array *items; // rcx
			//   List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *m_PendingReleaseMem; // rax
			//   List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *v39; // rax
			//   List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *v40; // rax
			//   __int64 v41; // [rsp+0h] [rbp-168h] BYREF
			//   __int128 v42; // [rsp+20h] [rbp-148h] BYREF
			//   __int128 v43; // [rsp+30h] [rbp-138h] BYREF
			//   __int128 v44; // [rsp+40h] [rbp-128h]
			//   __m128d v45; // [rsp+50h] [rbp-118h]
			//   __int64 v46; // [rsp+60h] [rbp-108h]
			//   _OWORD v47[3]; // [rsp+70h] [rbp-F8h] BYREF
			//   Il2CppException *ex; // [rsp+A0h] [rbp-C8h]
			//   __int128 *v49; // [rsp+A8h] [rbp-C0h]
			//   Renderer *v50[2]; // [rsp+B0h] [rbp-B8h] BYREF
			//   __int128 v51; // [rsp+C0h] [rbp-A8h]
			//   __int64 v52; // [rsp+D0h] [rbp-98h]
			//   _BYTE v53[56]; // [rsp+D8h] [rbp-90h] BYREF
			//   __int128 v54; // [rsp+110h] [rbp-58h]
			//   Il2CppExceptionWrapper *v55; // [rsp+120h] [rbp-48h] BYREF
			// 
			//   v4 = this;
			//   if ( !byte_18D8ED977 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Deconstruct);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SkinnedMeshCaptureManager::ReleaseData>::RemoveAt);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SkinnedMeshCaptureManager::ReleaseData>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SkinnedMeshCaptureManager::ReleaseData>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SkinnedMeshCaptureManager::ReleaseData>::set_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8ED977 = 1;
			//   }
			//   *(_OWORD *)v50 = 0LL;
			//   v51 = 0LL;
			//   v52 = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v5, method);
			//   if ( wrapperArray.max_length.size <= 1967 )
			//     goto LABEL_16;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, method);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v7 = v5.static_fields.wrapperArray;
			//   if ( !v7 )
			//     sub_180B536AC(v5, method);
			//   if ( v7.max_length.size <= 0x7AFu )
			//     sub_180070270(v5, method);
			//   if ( v7[54].vector[23] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1967, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v4, 0LL);
			//   }
			//   else
			//   {
			// LABEL_16:
			//     m_requests = v4.fields.m_requests;
			//     if ( !m_requests )
			//       sub_180B536AC(v5, method);
			//     memset(&v53[8], 0, 48);
			//     v54 = 0LL;
			//     *(_QWORD *)v53 = m_requests;
			//     sub_1800054D0(
			//       (HGRenderPathScene *)v53,
			//       (HGRenderPathBase_HGRenderPathResources *)method,
			//       v2,
			//       v3,
			//       (MethodInfo *)v42,
			//       *((MethodInfo **)&v42 + 1));
			//     *(_QWORD *)&v53[8] = (unsigned int)m_requests.fields._version;
			//     v15 = 0;
			//     DWORD2(v54) = 2;
			//     v42 = *(_OWORD *)v53;
			//     v43 = 0LL;
			//     v44 = 0LL;
			//     v45 = 0LL;
			//     v46 = *((_QWORD *)&v54 + 1);
			//     ex = 0LL;
			//     v49 = &v42;
			//     try
			//     {
			// LABEL_18:
			//       size = (List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *)v42;
			//       if ( !(_QWORD)v42 )
			//         sub_1802DC2C8(v12, 0LL);
			//       if ( DWORD2(v42) != *(_DWORD *)(v42 + 44) )
			//         System::ThrowHelper::ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion(0LL);
			//       LODWORD(v17) = HIDWORD(v42);
			//       while ( (unsigned int)v17 < *(_DWORD *)(v42 + 32) )
			//       {
			//         v13 = *(List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ **)(v42 + 24);
			//         v18 = (int)v17;
			//         v17 = (unsigned int)(v17 + 1);
			//         HIDWORD(v42) = v17;
			//         if ( !v13 )
			//           sub_1802DC2C8(v17, v42);
			//         if ( (unsigned int)v18 >= v13.fields._size )
			//           sub_180070260(v17, v42, v13, v18);
			//         v14 = (char *)v13 + 56 * v18;
			//         if ( *((int *)v14 + 8) >= 0 )
			//         {
			//           v19 = *((_DWORD *)v14 + 10);
			//           memset(v47, 0, sizeof(v47));
			//           v20 = *((_OWORD *)v14 + 3);
			//           v21 = *((_OWORD *)v14 + 4);
			//           v22 = *((_QWORD *)v14 + 10);
			//           klass = MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::MoveNext.klass;
			//           if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//             sub_18003C700(klass);
			//           LODWORD(v47[0]) = v19;
			//           *(_OWORD *)((char *)v47 + 8) = v20;
			//           *(_OWORD *)((char *)&v47[1] + 8) = v21;
			//           *((_QWORD *)&v47[2] + 1) = v22;
			//           sub_1800054D0(
			//             (HGRenderPathScene *)((char *)v47 + 8),
			//             (HGRenderPathBase_HGRenderPathResources *)size,
			//             (PassConstructorID__Enum__Array *)v13,
			//             (HGCamera *)v14,
			//             (MethodInfo *)v42,
			//             *((MethodInfo **)&v42 + 1));
			//           v43 = v47[0];
			//           v44 = v47[1];
			//           v45 = (__m128d)v47[2];
			//           sub_1800054D0(
			//             (HGRenderPathScene *)((char *)&v43 + 8),
			//             v24,
			//             v25,
			//             v26,
			//             (MethodInfo *)v42,
			//             *((MethodInfo **)&v42 + 1));
			//           *(_OWORD *)v53 = v43;
			//           *(_OWORD *)&v53[16] = v44;
			//           v30 = v45;
			//           *(__m128d *)&v53[32] = v45;
			//           v31 = MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Deconstruct;
			//           v32 = MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::SkinnedMeshCaptureManager::RequestData>::Deconstruct.klass;
			//           if ( ((__int64)v32.vtable[0].methodPtr & 1) == 0 )
			//             sub_18003C700(v32);
			//           v33 = v31.klass;
			//           if ( ((__int64)v33.vtable[0].methodPtr & 1) == 0 )
			//             sub_18003C700(v33);
			//           *(_OWORD *)v50 = *(_OWORD *)&v53[8];
			//           v51 = *(_OWORD *)&v53[24];
			//           v52 = *(_OWORD *)&_mm_unpackhi_pd(v30, v30);
			//           sub_1800054D0((HGRenderPathScene *)v50, v27, v28, v29, (MethodInfo *)v42, *((MethodInfo **)&v42 + 1));
			//           v35 = v50[0];
			//           v47[1] = v51;
			//           *(_QWORD *)&v47[2] = v52;
			//           v36 = v50[0];
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v34);
			//           if ( !byte_18D8F4EFA )
			//           {
			//             sub_18003C530(&TypeInfo::UnityEngine::Object);
			//             byte_18D8F4EFA = 1;
			//           }
			//           v12 = TypeInfo::UnityEngine::Object;
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v34);
			//           if ( !byte_18D8F4EAF )
			//           {
			//             sub_18003C530(&TypeInfo::UnityEngine::Object);
			//             byte_18D8F4EAF = 1;
			//           }
			//           if ( v36 )
			//           {
			//             v12 = TypeInfo::UnityEngine::Object;
			//             if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//               il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v34);
			//             if ( v36.fields._._.m_CachedPtr )
			//             {
			//               if ( !v35 )
			//                 sub_1802DC2C8(0LL, v34);
			//               UnityEngine::Renderer::Internal_SetPropertyBlock(v35, 0LL, 0LL);
			//             }
			//           }
			//           goto LABEL_18;
			//         }
			//       }
			//       HIDWORD(v42) = *(_DWORD *)(v42 + 32) + 1;
			//       v43 = 0LL;
			//       v44 = 0LL;
			//       v45 = 0LL;
			//     }
			//     catch ( Il2CppExceptionWrapper *v55 )
			//     {
			//       size = (List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *)&v41;
			//       ex = v55.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v15 = 0;
			//       v4 = this;
			//     }
			//     items = 0LL;
			//     m_PendingReleaseMem = v4.fields.m_PendingReleaseMem;
			//     if ( !m_PendingReleaseMem )
			// LABEL_82:
			//       sub_1802DC2C8(items, size);
			//     while ( (int)items < m_PendingReleaseMem.fields._size )
			//     {
			//       v39 = v4.fields.m_PendingReleaseMem;
			//       if ( !v39 )
			//         goto LABEL_82;
			//       if ( v15 >= v39.fields._size )
			//         goto LABEL_84;
			//       items = v39.fields._items;
			//       if ( !items )
			//         goto LABEL_82;
			//       if ( v15 >= items.max_length.size )
			//         goto LABEL_83;
			//       if ( items.vector[v15].frame < v4.fields.m_frameCount )
			//       {
			//         v40 = v4.fields.m_PendingReleaseMem;
			//         if ( !v40 )
			//           goto LABEL_82;
			//         if ( v15 >= v40.fields._size )
			//           goto LABEL_84;
			//         items = v40.fields._items;
			//         if ( !items )
			//           goto LABEL_82;
			//         if ( v15 >= items.max_length.size )
			//           goto LABEL_83;
			//         Unity::Collections::LowLevel::Unsafe::UnsafeUtility::Free(
			//           items.vector[v15].mem,
			//           Allocator__Enum_Persistent,
			//           0LL);
			//         v13 = v4.fields.m_PendingReleaseMem;
			//         if ( !v13 )
			//           goto LABEL_82;
			//         size = (List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *)v13.fields._size;
			//         if ( (unsigned int)((_DWORD)size - 1) >= v13.fields._size )
			// LABEL_84:
			//           System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//         items = v13.fields._items;
			//         if ( !items )
			//           goto LABEL_82;
			//         if ( (unsigned int)((_DWORD)size - 1) >= items.max_length.size )
			//           goto LABEL_83;
			//         size = (List_1_HG_Rendering_Runtime_SkinnedMeshCaptureManager_ReleaseData_ *)((char *)items
			//                                                                                     + 16 * ((_QWORD)&size.klass + 1));
			//         if ( v15 >= v13.fields._size )
			//           goto LABEL_84;
			//         if ( v15 >= items.max_length.size )
			// LABEL_83:
			//           sub_180070260(items, size, v13, v14);
			//         items.vector[v15] = *(SkinnedMeshCaptureManager_ReleaseData *)&size.klass;
			//         ++v13.fields._version;
			//         size = v4.fields.m_PendingReleaseMem;
			//         if ( !size )
			//           goto LABEL_82;
			//         System::Collections::Generic::List<Cinemachine::TargetPositionCache_CacheEntry::RecordingItem>::RemoveAt(
			//           (List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *)v4.fields.m_PendingReleaseMem,
			//           size.fields._size - 1,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::SkinnedMeshCaptureManager::ReleaseData>::RemoveAt);
			//       }
			//       else
			//       {
			//         ++v15;
			//       }
			//       items = (SkinnedMeshCaptureManager_ReleaseData__Array *)v15;
			//       m_PendingReleaseMem = v4.fields.m_PendingReleaseMem;
			//       if ( !m_PendingReleaseMem )
			//         goto LABEL_82;
			//     }
			//     ++v4.fields.m_frameCount;
			//   }
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly int BAKE_SKIN_MATRICES_CB;

		private readonly Dictionary<int, SkinnedMeshCaptureManager.RequestData> m_requests;

		private List<SkinnedMeshCaptureManager.ReleaseData> m_PendingReleaseMem;

		private uint m_frameCount;

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		private struct RequestData
		{
			public MeshRenderer meshRenderer;

			public SkinnedMeshRenderer skinnedMeshRenderer;

			public unsafe Vector4* skinMatrices;

			public int bufferSize;

			public MaterialPropertyBlock propertyBlock;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		private struct ReleaseData
		{
			public unsafe void* mem;

			public uint frame;
		}
	}
}
