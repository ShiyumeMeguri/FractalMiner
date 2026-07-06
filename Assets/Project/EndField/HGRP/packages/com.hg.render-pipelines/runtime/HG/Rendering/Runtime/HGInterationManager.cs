using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGInterationManager
	{
		public HGInterationManager()
		{
		}

		public void Release()
		{
			// // Void Release()
			// void HG::Rendering::Runtime::HGInterationManager::Release(HGInterationManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGDecalInteration *decalInteraction; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1535, 0LL) )
			//   {
			//     decalInteraction = this.fields.decalInteraction;
			//     if ( decalInteraction )
			//     {
			//       HG::Rendering::Runtime::HGDecalInteration::Release(decalInteraction, 0LL);
			//       return;
			//     }
			// LABEL_5:
			//     sub_180B536AC(decalInteraction, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1535, 0LL);
			//   if ( !Patch )
			//     goto LABEL_5;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		internal void PrepareResources(HGRenderPipelineRuntimeResources defaultResources)
		{
		}

		public void Register(IHGInteractionObject obj)
		{
			// // Void Register(IHGInteractionObject)
			// void HG::Rendering::Runtime::HGInterationManager::Register(
			//         HGInterationManager *this,
			//         IHGInteractionObject *obj,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *objects; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDCD1 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IHGInteractionObject>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IHGInteractionObject>::Contains);
			//     byte_18D8EDCD1 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1508, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1508, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)obj,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_10;
			//   }
			//   if ( !obj )
			//     return;
			//   objects = (List_1_System_Object_ *)this.fields.objects;
			//   if ( !objects )
			//     goto LABEL_10;
			//   if ( System::Collections::Generic::List<System::Object>::Contains(
			//          objects,
			//          (Object *)obj,
			//          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IHGInteractionObject>::Contains) )
			//   {
			//     return;
			//   }
			//   objects = (List_1_System_Object_ *)this.fields.objects;
			//   if ( !objects )
			// LABEL_10:
			//     sub_180B536AC(objects, v5);
			//   sub_1822AD140(objects, (Object *)obj);
			// }
			// 
		}

		public void Unregister(IHGInteractionObject obj)
		{
			// // Void Unregister(IHGInteractionObject)
			// void HG::Rendering::Runtime::HGInterationManager::Unregister(
			//         HGInterationManager *this,
			//         IHGInteractionObject *obj,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *objects; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDCD2 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IHGInteractionObject>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IHGInteractionObject>::Remove);
			//     byte_18D8EDCD2 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1510, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1510, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)obj,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_10;
			//   }
			//   if ( !obj )
			//     return;
			//   objects = (List_1_System_Object_ *)this.fields.objects;
			//   if ( !objects )
			//     goto LABEL_10;
			//   if ( !System::Collections::Generic::List<System::Object>::Contains(
			//           objects,
			//           (Object *)obj,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IHGInteractionObject>::Contains) )
			//     return;
			//   objects = (List_1_System_Object_ *)this.fields.objects;
			//   if ( !objects )
			// LABEL_10:
			//     sub_180B536AC(objects, v5);
			//   System::Collections::Generic::List<System::Object>::Remove(
			//     objects,
			//     (Object *)obj,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IHGInteractionObject>::Remove);
			// }
			// 
		}

		public void PipelineUpdate()
		{
			// // Void PipelineUpdate()
			// void HG::Rendering::Runtime::HGInterationManager::PipelineUpdate(HGInterationManager *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGInteractionSettingAsset *settingAsset; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDCD3 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDCD3 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   static_fields = v3.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_23;
			//   if ( wrapperArray.max_length.size > 1537 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = v3.static_fields;
			//     v7 = static_fields.wrapperArray;
			//     if ( static_fields.wrapperArray )
			//     {
			//       if ( v7.max_length.size <= 0x601u )
			//         sub_180070270(static_fields, wrapperArray);
			//       if ( !v7[42].vector[25] )
			//         goto LABEL_9;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1537, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_23:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			// LABEL_9:
			//   settingAsset = this.fields.settingAsset;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !byte_18D8F4EAE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAE = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( settingAsset )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//     if ( settingAsset.fields._._.m_CachedPtr )
			//     {
			//       HG::Rendering::Runtime::HGInterationManager::CollectInteractions(this, 0LL);
			//       HG::Rendering::Runtime::HGInterationManager::UpdateCppPipeline(this, 0, 0LL);
			//     }
			//   }
			// }
			// 
		}

		private void UpdateCppPipeline(bool updateMobile)
		{
			// // Void UpdateCppPipeline(Boolean)
			// void HG::Rendering::Runtime::HGInterationManager::UpdateCppPipeline(
			//         HGInterationManager *this,
			//         bool updateMobile,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int128 *v6; // rcx
			//   HGDecalInteration *decalInteraction; // rdx
			//   HGDecalInteractionParametersV2 *v8; // rax
			//   __int128 v9; // xmm1
			//   __int128 v10; // xmm0
			//   __int128 v11; // xmm1
			//   void (__fastcall *v12)(_OWORD *); // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   List_1_HG_Rendering_Runtime_HGInteractionNode_ *nodes; // rax
			//   struct MethodInfo *v16; // rsi
			//   __int64 size; // rdi
			//   Il2CppClass *klass; // rax
			//   _QWORD *rgctxDataDummy; // rbx
			//   __int64 v20; // rax
			//   __int64 v21; // rcx
			//   __int64 v22; // rax
			//   unsigned int v23; // ebx
			//   __int64 (__fastcall *v24)(__int64, _QWORD, __int64, _QWORD); // rax
			//   __int64 v25; // r14
			//   Il2CppClass *v26; // rax
			//   Il2CppRGCTXData v27; // rcx
			//   void (__fastcall *v28)(__int64, _QWORD, __int64); // rax
			//   unsigned int v29; // ebx
			//   __int64 i; // rsi
			//   List_1_HG_Rendering_Runtime_HGInteractionNode_ *v31; // rax
			//   Texture *texture; // rdi
			//   bool v33; // zf
			//   int32_t InstanceID; // eax
			//   Mesh *mesh; // rdi
			//   int32_t v36; // eax
			//   HGInteractionNodeV2 *v37; // rax
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm0
			//   __int128 v40; // xmm1
			//   __int128 v41; // xmm0
			//   __int128 v42; // xmm1
			//   __int128 v43; // xmm0
			//   __int128 v44; // xmm1
			//   __int128 v45; // xmm0
			//   __int128 v46; // xmm1
			//   __int128 v47; // xmm0
			//   int32_t m_mesh; // eax
			//   __int128 v49; // xmm1
			//   __int128 v50; // xmm0
			//   __int128 v51; // xmm1
			//   __int128 v52; // xmm0
			//   __int128 v53; // xmm1
			//   __int128 v54; // xmm0
			//   __int128 v55; // xmm1
			//   __int128 v56; // xmm0
			//   __int128 v57; // xmm1
			//   __int128 v58; // xmm0
			//   int32_t v59; // eax
			//   unsigned int v60; // ebx
			//   void (__fastcall *v61)(__int64, _QWORD, bool); // rax
			//   Il2CppClass *v62; // rcx
			//   void (__fastcall *v63)(__int64, __int64); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v65; // rax
			//   __int64 v66; // rax
			//   __int64 v67; // rax
			//   ILFixDynamicMethodWrapper_2 *v68; // rax
			//   __int64 v69; // rax
			//   __int64 v70; // rax
			//   HGInteractionNode v71; // [rsp+20h] [rbp-E0h] BYREF
			//   _DWORD v72[2]; // [rsp+E0h] [rbp-20h] BYREF
			//   __int128 v73; // [rsp+E8h] [rbp-18h]
			//   __int128 v74; // [rsp+F8h] [rbp-8h]
			//   __int128 v75; // [rsp+108h] [rbp+8h]
			//   __int128 v76; // [rsp+118h] [rbp+18h]
			//   Matrix4x4 prevLocalToWorldMatrix; // [rsp+128h] [rbp+28h]
			//   float GroundHeight; // [rsp+168h] [rbp+68h]
			//   bool bUseCCD; // [rsp+16Ch] [rbp+6Ch]
			//   __int16 v80; // [rsp+16Dh] [rbp+6Dh]
			//   char v81; // [rsp+16Fh] [rbp+6Fh]
			//   __int128 v82; // [rsp+170h] [rbp+70h]
			//   int32_t v83; // [rsp+180h] [rbp+80h]
			//   float x; // [rsp+184h] [rbp+84h]
			//   float y; // [rsp+188h] [rbp+88h]
			//   float heightScale; // [rsp+18Ch] [rbp+8Ch]
			//   int32_t v87; // [rsp+190h] [rbp+90h]
			//   _OWORD v88[4]; // [rsp+1A0h] [rbp+A0h] BYREF
			//   __int128 v89; // [rsp+1E0h] [rbp+E0h] BYREF
			//   __int128 v90; // [rsp+1F0h] [rbp+F0h]
			//   __int128 v91; // [rsp+200h] [rbp+100h]
			//   __int128 v92; // [rsp+210h] [rbp+110h]
			//   __int128 v93; // [rsp+220h] [rbp+120h]
			//   __int128 v94; // [rsp+230h] [rbp+130h]
			//   __int128 v95; // [rsp+240h] [rbp+140h]
			//   __int128 v96; // [rsp+250h] [rbp+150h]
			//   __int128 v97; // [rsp+260h] [rbp+160h]
			//   __int128 v98; // [rsp+270h] [rbp+170h]
			//   __int128 v99; // [rsp+280h] [rbp+180h]
			//   int32_t v100; // [rsp+290h] [rbp+190h]
			//   HGDecalInteractionParametersV2 v101; // [rsp+298h] [rbp+198h] BYREF
			//   HGInteractionNodeV2 v102; // [rsp+2D8h] [rbp+1D8h] BYREF
			// 
			//   if ( !byte_18D8EDCD4 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::get_Item);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::HGInteractionNodeV2>::Dispose);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::HGInteractionNodeV2>::NativeArray);
			//     byte_18D8EDCD4 = 1;
			//   }
			//   sub_1802F01E0(&v71, 0LL, 192LL);
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v6 = (__int128 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v5);
			//     v6 = (__int128 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   decalInteraction = (HGDecalInteration *)**((_QWORD **)v6 + 23);
			//   if ( !decalInteraction )
			//     goto LABEL_77;
			//   if ( SLODWORD(decalInteraction.fields.busyChains) <= 1539 )
			//     goto LABEL_9;
			//   if ( !*((_DWORD *)v6 + 56) )
			//   {
			//     il2cpp_runtime_class_init_0(v6, decalInteraction);
			//     v6 = (__int128 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   decalInteraction = (HGDecalInteration *)**((_QWORD **)v6 + 23);
			//   if ( !decalInteraction )
			// LABEL_77:
			//     sub_180B536AC(v6, decalInteraction);
			//   if ( LODWORD(decalInteraction.fields.busyChains) <= 0x603 )
			// LABEL_85:
			//     sub_180070270(v6, decalInteraction);
			//   if ( decalInteraction[257].monitor )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1539, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13(
			//         (ILFixDynamicMethodWrapper_28 *)Patch,
			//         (Object *)this,
			//         updateMobile,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_77;
			//   }
			// LABEL_9:
			//   decalInteraction = this.fields.decalInteraction;
			//   if ( !decalInteraction )
			//     goto LABEL_77;
			//   v8 = HG::Rendering::Runtime::HGDecalInteration::BuildNativeSettingParameters(&v101, decalInteraction, 0LL);
			//   v9 = *(_OWORD *)&v8.m_decalNodeWidth;
			//   v88[0] = *(_OWORD *)&v8.m_enableDecalInteraction;
			//   v10 = *(_OWORD *)&v8.m_nodeDistanceThreshold;
			//   v88[1] = v9;
			//   v11 = *(_OWORD *)&v8.m_rotationThreshold;
			//   v12 = (void (__fastcall *)(_OWORD *))qword_18D8F5AE0;
			//   v88[2] = v10;
			//   v88[3] = v11;
			//   if ( !qword_18D8F5AE0 )
			//   {
			//     v12 = (void (__fastcall *)(_OWORD *))il2cpp_resolve_icall_0(
			//                                            "UnityEngine.HyperGryph.HGInteractionManagerV2::UpdateSettingParameters_Inject"
			//                                            "ed(UnityEngine.HyperGryph.HGDecalInteractionParametersV2&)");
			//     if ( !v12 )
			//     {
			//       v65 = sub_1802DBBE8(
			//               "UnityEngine.HyperGryph.HGInteractionManagerV2::UpdateSettingParameters_Injected(UnityEngine.HyperGryph.HGD"
			//               "ecalInteractionParametersV2&)");
			//       sub_18000F750(v65, 0LL);
			//     }
			//     qword_18D8F5AE0 = (__int64)v12;
			//   }
			//   v12(v88);
			//   nodes = this.fields.nodes;
			//   if ( !nodes )
			//     sub_180B536AC(v14, v13);
			//   v16 = MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::HGInteractionNodeV2>::NativeArray;
			//   size = nodes.fields._size;
			//   klass = MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::HGInteractionNodeV2>::NativeArray.klass;
			//   if ( ((__int64)klass.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::HGInteractionNodeV2>::NativeArray.klass);
			//   rgctxDataDummy = klass.rgctx_data.rgctxDataDummy;
			//   v20 = rgctxDataDummy[4];
			//   if ( (*(_BYTE *)(v20 + 312) & 1) == 0 )
			//     sub_18003C700(rgctxDataDummy[4]);
			//   v21 = *(_QWORD *)(*(_QWORD *)(v20 + 192) + 16LL);
			//   if ( !*(_QWORD *)(v21 + 56) )
			//     sub_180041F40(v21);
			//   v22 = rgctxDataDummy[4];
			//   if ( (*(_BYTE *)(v22 + 312) & 1) == 0 )
			//     sub_18003C700(rgctxDataDummy[4]);
			//   v23 = Unity::Collections::LowLevel::Unsafe::UnsafeUtility::AlignOf<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>(*(MethodInfo **)(*(_QWORD *)(v22 + 192) + 40LL));
			//   v24 = (__int64 (__fastcall *)(__int64, _QWORD, __int64, _QWORD))qword_18D8F3FC0;
			//   if ( !qword_18D8F3FC0 )
			//   {
			//     v24 = (__int64 (__fastcall *)(__int64, _QWORD, __int64, _QWORD))il2cpp_resolve_icall_0(
			//                                                                       "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::M"
			//                                                                       "allocTracked(System.Int64,System.Int32,Unity.Colle"
			//                                                                       "ctions.Allocator,System.Int32)");
			//     if ( !v24 )
			//     {
			//       v66 = sub_1802DBBE8(
			//               "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MallocTracked(System.Int64,System.Int32,Unity.Collections"
			//               ".Allocator,System.Int32)");
			//       sub_18000F750(v66, 0LL);
			//     }
			//     qword_18D8F3FC0 = (__int64)v24;
			//   }
			//   v25 = v24(180 * size, v23, 2LL, 0LL);
			//   v26 = v16.klass;
			//   if ( ((__int64)v26.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v16.klass);
			//   v27.rgctxDataDummy = v26.rgctx_data[2].rgctxDataDummy;
			//   if ( !*((_QWORD *)v27.rgctxDataDummy + 7) )
			//     ((void (__fastcall *)(_QWORD))sub_180041F40)((Il2CppRGCTXData)v27.rgctxDataDummy);
			//   v28 = (void (__fastcall *)(__int64, _QWORD, __int64))qword_18D8F3FF0;
			//   if ( !qword_18D8F3FF0 )
			//   {
			//     v28 = (void (__fastcall *)(__int64, _QWORD, __int64))il2cpp_resolve_icall_0(
			//                                                            "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemSet(Syste"
			//                                                            "m.Void*,System.Byte,System.Int64)");
			//     if ( !v28 )
			//     {
			//       v67 = sub_1802DBBE8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemSet(System.Void*,System.Byte,System.Int64)");
			//       sub_18000F750(v67, 0LL);
			//     }
			//     qword_18D8F3FF0 = (__int64)v28;
			//   }
			//   v28(v25, 0LL, 180 * size);
			//   v29 = 0;
			//   for ( i = v25; ; i += 180LL )
			//   {
			//     v31 = this.fields.nodes;
			//     if ( !v31 )
			//       goto LABEL_77;
			//     if ( (signed int)v29 >= v31.fields._size )
			//       break;
			//     if ( v29 >= v31.fields._size )
			//       System::ThrowHelper::ThrowArgumentOutOfRange_IndexException(0LL);
			//     decalInteraction = (HGDecalInteration *)v31.fields._items;
			//     if ( !decalInteraction )
			//       goto LABEL_77;
			//     if ( v29 >= LODWORD(decalInteraction.fields.busyChains) )
			//       goto LABEL_85;
			//     v71 = *(HGInteractionNode *)&decalInteraction[4 * (int)v29].fields.pendingFreeChains;
			//     if ( !byte_18D8EDCD0 )
			//     {
			//       sub_18003C530(&TypeInfo::UnityEngine::Object);
			//       byte_18D8EDCD0 = 1;
			//     }
			//     if ( !byte_18D8EDC37 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EDC37 = 1;
			//     }
			//     v6 = (__int128 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, decalInteraction);
			//       v6 = (__int128 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     decalInteraction = (HGDecalInteration *)**((_QWORD **)v6 + 23);
			//     if ( !decalInteraction )
			//       goto LABEL_77;
			//     if ( SLODWORD(decalInteraction.fields.busyChains) <= 1534 )
			//       goto LABEL_40;
			//     if ( !*((_DWORD *)v6 + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(v6, decalInteraction);
			//       v6 = (__int128 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v6 = (__int128 *)**((_QWORD **)v6 + 23);
			//     if ( !v6 )
			//       goto LABEL_77;
			//     if ( *((_DWORD *)v6 + 6) <= 0x5FEu )
			//       goto LABEL_85;
			//     if ( *((_QWORD *)v6 + 1538) )
			//     {
			//       v68 = IFix::WrappersManagerImpl::GetPatch(1534, 0LL);
			//       if ( !v68 )
			//         goto LABEL_77;
			//       v37 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_588(&v102, v68, &v71, 0LL);
			//     }
			//     else
			//     {
			// LABEL_40:
			//       texture = v71.texture;
			//       v73 = *(_OWORD *)&v71.localToWorldMatrix.m00;
			//       v33 = TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor == 0;
			//       v80 = 0;
			//       v74 = *(_OWORD *)&v71.localToWorldMatrix.m01;
			//       v81 = 0;
			//       v75 = *(_OWORD *)&v71.localToWorldMatrix.m02;
			//       v72[0] = v71.NodeKey;
			//       v76 = *(_OWORD *)&v71.localToWorldMatrix.m03;
			//       v72[1] = v71.ProxyType;
			//       prevLocalToWorldMatrix = v71.prevLocalToWorldMatrix;
			//       bUseCCD = v71.bUseCCD;
			//       GroundHeight = v71.GroundHeight;
			//       v82 = *(_OWORD *)&v71.length;
			//       if ( v33 )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, decalInteraction);
			//       if ( !byte_18D8F4EAE )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EAE = 1;
			//       }
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, decalInteraction);
			//       if ( !byte_18D8F4EAF )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EAF = 1;
			//       }
			//       if ( !texture )
			//         goto LABEL_52;
			//       v6 = (__int128 *)TypeInfo::UnityEngine::Object;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, decalInteraction);
			//       if ( texture.fields._.m_CachedPtr )
			//       {
			//         if ( !v71.texture )
			//           goto LABEL_77;
			//         InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)v71.texture, 0LL);
			//       }
			//       else
			//       {
			// LABEL_52:
			//         InstanceID = 0;
			//       }
			//       mesh = v71.mesh;
			//       x = v71.extent.x;
			//       v33 = TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor == 0;
			//       y = v71.extent.y;
			//       heightScale = v71.heightScale;
			//       v83 = InstanceID;
			//       if ( v33 )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, decalInteraction);
			//       if ( !byte_18D8F4EAE )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EAE = 1;
			//       }
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, decalInteraction);
			//       if ( !byte_18D8F4EAF )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EAF = 1;
			//       }
			//       if ( !mesh )
			//         goto LABEL_65;
			//       v6 = (__int128 *)TypeInfo::UnityEngine::Object;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, decalInteraction);
			//       if ( mesh.fields._.m_CachedPtr )
			//       {
			//         if ( !v71.mesh )
			//           goto LABEL_77;
			//         v36 = UnityEngine::Object::GetInstanceID((Object_1 *)v71.mesh, 0LL);
			//       }
			//       else
			//       {
			// LABEL_65:
			//         v36 = 0;
			//       }
			//       v87 = v36;
			//       v37 = (HGInteractionNodeV2 *)v72;
			//     }
			//     v6 = &v89;
			//     ++v29;
			//     v38 = *(_OWORD *)&v37.m_localToWorldMatrix.m20;
			//     v89 = *(_OWORD *)&v37.m_nodeKey;
			//     v39 = *(_OWORD *)&v37.m_localToWorldMatrix.m21;
			//     v90 = v38;
			//     v40 = *(_OWORD *)&v37.m_localToWorldMatrix.m22;
			//     v91 = v39;
			//     v41 = *(_OWORD *)&v37.m_localToWorldMatrix.m23;
			//     v92 = v40;
			//     v42 = *(_OWORD *)&v37.m_prevLocalToWorldMatrix.m20;
			//     v93 = v41;
			//     v43 = *(_OWORD *)&v37.m_prevLocalToWorldMatrix.m21;
			//     v94 = v42;
			//     v44 = *(_OWORD *)&v37.m_prevLocalToWorldMatrix.m22;
			//     v95 = v43;
			//     v45 = *(_OWORD *)&v37.m_prevLocalToWorldMatrix.m23;
			//     v96 = v44;
			//     v46 = *(_OWORD *)&v37.m_length;
			//     v97 = v45;
			//     v47 = *(_OWORD *)&v37.m_texture;
			//     m_mesh = v37.m_mesh;
			//     v98 = v46;
			//     v99 = v47;
			//     v100 = m_mesh;
			//     v49 = v90;
			//     *(_OWORD *)i = v89;
			//     v50 = v91;
			//     *(_OWORD *)(i + 16) = v49;
			//     v51 = v92;
			//     *(_OWORD *)(i + 32) = v50;
			//     v52 = v93;
			//     *(_OWORD *)(i + 48) = v51;
			//     v53 = v94;
			//     *(_OWORD *)(i + 64) = v52;
			//     v54 = v95;
			//     *(_OWORD *)(i + 80) = v53;
			//     v55 = v96;
			//     *(_OWORD *)(i + 96) = v54;
			//     v56 = v97;
			//     *(_OWORD *)(i + 112) = v55;
			//     v57 = v98;
			//     *(_OWORD *)(i + 128) = v56;
			//     v58 = v99;
			//     v59 = v100;
			//     *(_OWORD *)(i + 144) = v57;
			//     *(_OWORD *)(i + 160) = v58;
			//     *(_DWORD *)(i + 176) = v59;
			//   }
			//   v60 = v31.fields._size;
			//   if ( !byte_18D8F5AD0 )
			//   {
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafeReadOnlyPtr<UnityEngine::HyperGryph::HGInteractionNodeV2>);
			//     byte_18D8F5AD0 = 1;
			//   }
			//   v61 = (void (__fastcall *)(__int64, _QWORD, bool))qword_18D8F5AD8;
			//   if ( !qword_18D8F5AD8 )
			//   {
			//     v61 = (void (__fastcall *)(__int64, _QWORD, bool))il2cpp_resolve_icall_0(
			//                                                         "UnityEngine.HyperGryph.HGInteractionManagerV2::UpdateFromNodes(S"
			//                                                         "ystem.IntPtr,System.Int32,System.Boolean)");
			//     if ( !v61 )
			//     {
			//       v69 = sub_1802DBBE8(
			//               "UnityEngine.HyperGryph.HGInteractionManagerV2::UpdateFromNodes(System.IntPtr,System.Int32,System.Boolean)");
			//       sub_18000F750(v69, 0LL);
			//     }
			//     qword_18D8F5AD8 = (__int64)v61;
			//   }
			//   v61(v25, v60, updateMobile);
			//   v62 = MethodInfo::Unity::Collections::NativeArray<UnityEngine::HyperGryph::HGInteractionNodeV2>::Dispose.klass;
			//   if ( ((__int64)v62.vtable[0].methodPtr & 1) == 0 )
			//     sub_18003C700(v62);
			//   if ( v25 )
			//   {
			//     v63 = (void (__fastcall *)(__int64, __int64))qword_18D8F3FC8;
			//     if ( !qword_18D8F3FC8 )
			//     {
			//       v63 = (void (__fastcall *)(__int64, __int64))il2cpp_resolve_icall_0(
			//                                                      "Unity.Collections.LowLevel.Unsafe.UnsafeUtility::FreeTracked(System"
			//                                                      ".Void*,Unity.Collections.Allocator)");
			//       if ( !v63 )
			//       {
			//         v70 = sub_1802DBBE8("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::FreeTracked(System.Void*,Unity.Collections.Allocator)");
			//         sub_18000F750(v70, 0LL);
			//       }
			//       qword_18D8F3FC8 = (__int64)v63;
			//     }
			//     v63(v25, 2LL);
			//   }
			// }
			// 
		}

		private void CollectInteractions()
		{
			// // Void CollectInteractions()
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGInterationManager::CollectInteractions(HGInterationManager *this, MethodInfo *method)
			// {
			//   MessageDescriptor *v2; // r9
			//   struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rbx
			//   ILFixDynamicMethodWrapper_2__Array *v6; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   List_1_HG_Rendering_Runtime_HGInteractionNode_ *nodes; // rbx
			//   FileDescriptor *size; // r8
			//   List_1_HG_Rendering_Runtime_IHGInteractionObject_ *objects; // rbx
			//   __int64 *v13; // rdx
			//   struct Object_1__Class *v14; // rcx
			//   HGInteractionComponent *containingType; // rbx
			//   bool v16; // zf
			//   unsigned int v17; // ecx
			//   __int64 v18; // rdi
			//   void (__fastcall __noreturn **v19)(); // rax
			//   unsigned int v20; // eax
			//   unsigned int v21; // ecx
			//   __int64 v22; // rax
			//   unsigned int v23; // r8d
			//   __int64 v24; // rdi
			//   unsigned int *v25; // rdx
			//   signed __int64 v26; // r9
			//   char v27; // r8
			//   __int64 v28; // rtt
			//   __int64 v29; // rdi
			//   __int64 v30; // rax
			//   __int64 v31; // rdi
			//   _QWORD **v32; // rcx
			//   __int64 v33; // r8
			//   __int64 v34; // rax
			//   void (__fastcall __noreturn **v35)(); // rax
			//   unsigned int v36; // eax
			//   unsigned int v37; // r8d
			//   __int64 v38; // rax
			//   unsigned int *v39; // rdx
			//   signed __int64 v40; // r9
			//   char v41; // r8
			//   __int64 v42; // rtt
			//   __int64 v43; // rdi
			//   __int64 v44; // rax
			//   __int64 v45; // rdi
			//   _QWORD **v46; // rcx
			//   __int64 v47; // r8
			//   __int64 v48; // rax
			//   List_1_HG_Rendering_Runtime_HGInteractionNode_ *v49; // r14
			//   unsigned int v50; // r8d
			//   __int64 v51; // rdi
			//   void (__fastcall __noreturn **v52)(); // rax
			//   unsigned int v53; // eax
			//   unsigned int v54; // r8d
			//   __int64 v55; // rax
			//   unsigned int *v56; // rdx
			//   signed __int64 v57; // r9
			//   __int64 *v58; // rdx
			//   char v59; // r8
			//   __int64 v60; // rtt
			//   __int64 v61; // rdi
			//   __int64 v62; // rax
			//   __int64 v63; // rdi
			//   _QWORD **v64; // rcx
			//   __int64 v65; // r8
			//   __int64 v66; // rax
			//   __int64 v67; // rdx
			//   struct IHGInteractionObject__Class *v68; // rdi
			//   HGInteractionComponent__Class *klass; // rsi
			//   unsigned __int16 v70; // cx
			//   unsigned __int16 v71; // dx
			//   Il2CppRuntimeInterfaceOffsetPair *interfaceOffsets; // r8
			//   __int64 v73; // r8
			//   String__Array *v74; // [rsp+20h] [rbp-A8h]
			//   String *v75; // [rsp+28h] [rbp-A0h]
			//   MethodInfo *v76; // [rsp+30h] [rbp-98h] BYREF
			//   int v77; // [rsp+38h] [rbp-90h] BYREF
			//   int v78; // [rsp+48h] [rbp-80h] BYREF
			//   int v79; // [rsp+58h] [rbp-70h] BYREF
			//   OneofDescriptor v80; // [rsp+68h] [rbp-60h] BYREF
			// 
			//   if ( !byte_18D8EDCD5 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IHGInteractionObject>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IHGInteractionObject>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IHGInteractionObject>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IHGInteractionObject>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDCD5 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v4.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v4, method);
			//   if ( wrapperArray.max_length.size <= 1538 )
			//     goto LABEL_17;
			//   if ( !v4._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v4, method);
			//     v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = v4.static_fields.wrapperArray;
			//   if ( !v6 )
			//     sub_180B536AC(v4, method);
			//   if ( v6.max_length.size <= 0x602u )
			//     sub_180070270(v4, method);
			//   if ( v6[42].vector[26] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1538, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			// LABEL_17:
			//     nodes = this.fields.nodes;
			//     if ( !nodes )
			//       sub_180B536AC(v4, method);
			//     ++nodes.fields._version;
			//     size = (FileDescriptor *)(unsigned int)nodes.fields._size;
			//     nodes.fields._size = 0;
			//     if ( (int)size > 0 )
			//       System::Array::Clear((Array *)nodes.fields._items, 0, (int32_t)size, 0LL);
			//     objects = this.fields.objects;
			//     if ( !objects )
			//       sub_180B536AC(v4, method);
			//     *(_OWORD *)&v80.monitor = 0LL;
			//     v80.klass = (OneofDescriptor__Class *)objects;
			//     sub_1800054D0(&v80, (OneofDescriptorProto *)method, size, v2, v74, v75, v76);
			//     LODWORD(v80.monitor) = 0;
			//     HIDWORD(v80.monitor) = objects.fields._version;
			//     *(_QWORD *)&v80.fields._._Index_k__BackingField = 0LL;
			//     *(_OWORD *)&v80.fields._._FullName_k__BackingField = *(_OWORD *)&v80.klass;
			//     v80.fields.containingType = 0LL;
			//     v80.klass = 0LL;
			//     v80.monitor = (MonitorData *)&v80.fields._._FullName_k__BackingField;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 (List_1_T_Enumerator_System_Object_ *)&v80.fields._._FullName_k__BackingField,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IHGInteractionObject>::MoveNext) )
			//       {
			//         containingType = (HGInteractionComponent *)v80.fields.containingType;
			//         v16 = v80.fields.containingType == 0LL;
			//         if ( v80.fields.containingType )
			//         {
			//           if ( (unsigned __int8)il2cpp_class_has_parent(v80.fields.containingType.klass, TypeInfo::UnityEngine::Object) )
			//           {
			//             v16 = containingType == 0LL;
			//             if ( containingType )
			//             {
			//               if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                 il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v13);
			//               if ( !byte_18D8F4EFB )
			//               {
			//                 v17 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//                 if ( (v17 & 1) != 0 )
			//                 {
			//                   v18 = (v17 >> 1) & 0xFFFFFFF;
			//                   switch ( v17 >> 29 )
			//                   {
			//                     case 1u:
			//                       v19 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v18);
			//                       goto LABEL_41;
			//                     case 2u:
			//                       v19 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v18);
			//                       goto LABEL_41;
			//                     case 3u:
			//                     case 6u:
			//                       v20 = (v17 >> 1) & 0xFFFFFFF;
			//                       v21 = v17 >> 29;
			//                       if ( v21 )
			//                       {
			//                         if ( v21 == 3 )
			//                         {
			//                           v19 = (void (__fastcall __noreturn **)())sub_180039480(v20);
			//                           goto LABEL_41;
			//                         }
			//                         if ( v21 == 6 )
			//                         {
			//                           v22 = sub_1802DF9C0(v20);
			//                           v19 = (void (__fastcall __noreturn **)())sub_18005F4B0(v22, 0LL);
			//                           goto LABEL_41;
			//                         }
			// LABEL_40:
			//                         v19 = 0LL;
			//                         goto LABEL_41;
			//                       }
			//                       if ( !v20 )
			//                         goto LABEL_40;
			//                       v16 = v20 == 1;
			//                       v19 = off_18A2C5600;
			//                       if ( !v16 )
			//                         goto LABEL_40;
			// LABEL_41:
			//                       if ( v19 )
			//                         _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v19);
			//                       break;
			//                     case 4u:
			//                       v19 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v18);
			//                       goto LABEL_41;
			//                     case 5u:
			//                       if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v18) )
			//                       {
			//                         v19 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v18);
			//                       }
			//                       else
			//                       {
			//                         v25 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v18);
			//                         v26 = il2cpp_string_new_len(
			//                                 qword_18D8E5198 + (int)v25[1] + *(int *)(qword_18D8E51A0 + 16),
			//                                 *v25);
			//                         v19 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                    (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v18),
			//                                                                    v26,
			//                                                                    0LL);
			//                         if ( !v19 )
			//                         {
			//                           if ( dword_18D8E43F8 )
			//                           {
			//                             v13 = &qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v18) >> 12) & 0x1FFFFF) >> 6];
			//                             v27 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v18) >> 12) & 0x3F;
			//                             _m_prefetchw(v13);
			//                             do
			//                               v28 = *v13;
			//                             while ( v28 != _InterlockedCompareExchange64(v13, *v13 | (1LL << v27), *v13) );
			//                           }
			//                           v19 = (void (__fastcall __noreturn **)())v26;
			//                         }
			//                       }
			//                       goto LABEL_41;
			//                     case 7u:
			//                       v29 = sub_1802DF920((unsigned int)v18);
			//                       v30 = *(_QWORD *)(v29 + 16);
			//                       v31 = (v29 - *(_QWORD *)(v30 + 128)) >> 5;
			//                       if ( *(_BYTE *)(v30 + 42) == 21 )
			//                       {
			//                         v32 = *(_QWORD ***)(v30 + 96);
			//                         if ( *v32 )
			//                         {
			//                           v33 = **v32 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                           v30 = sub_180039550(v33 / 92 + v33);
			//                         }
			//                         else
			//                         {
			//                           v30 = 0LL;
			//                         }
			//                       }
			//                       v77 = v31 + *(_DWORD *)(*(_QWORD *)(v30 + 104) + 32LL);
			//                       v34 = sub_1801B8ECC(
			//                               (unsigned int)&v77,
			//                               (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                               *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                               12,
			//                               (__int64)sub_1802C7760);
			//                       if ( !v34 )
			//                         goto LABEL_40;
			//                       v13 = (__int64 *)*(unsigned int *)(v34 + 8);
			//                       if ( (_DWORD)v13 == -1 )
			//                         goto LABEL_40;
			//                       v19 = (void (__fastcall __noreturn **)())((char *)v13
			//                                                               + qword_18D8E5198
			//                                                               + *(int *)(qword_18D8E51A0 + 72));
			//                       goto LABEL_41;
			//                     default:
			//                       break;
			//                   }
			//                 }
			//                 byte_18D8F4EFB = 1;
			//               }
			//               if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                 il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v13);
			//               if ( !byte_18D8F4EAF )
			//               {
			//                 v23 = _InterlockedExchangeAdd64((volatile signed __int64 *)&TypeInfo::UnityEngine::Object, 0LL);
			//                 if ( (v23 & 1) != 0 )
			//                 {
			//                   v24 = (v23 >> 1) & 0xFFFFFFF;
			//                   switch ( v23 >> 29 )
			//                   {
			//                     case 1u:
			//                       v35 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v24);
			//                       goto LABEL_89;
			//                     case 2u:
			//                       v35 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v24);
			//                       goto LABEL_89;
			//                     case 3u:
			//                     case 6u:
			//                       v36 = (v23 >> 1) & 0xFFFFFFF;
			//                       v37 = v23 >> 29;
			//                       if ( v37 )
			//                       {
			//                         if ( v37 == 3 )
			//                         {
			//                           v35 = (void (__fastcall __noreturn **)())sub_180039480(v36);
			//                           goto LABEL_89;
			//                         }
			//                         if ( v37 == 6 )
			//                         {
			//                           v38 = sub_1802DF9C0(v36);
			//                           v35 = (void (__fastcall __noreturn **)())sub_18005F4B0(v38, 0LL);
			//                           goto LABEL_89;
			//                         }
			//                       }
			//                       else if ( v36 == 1 )
			//                       {
			//                         v35 = off_18A2C5600;
			//                         goto LABEL_89;
			//                       }
			// LABEL_88:
			//                       v35 = 0LL;
			// LABEL_89:
			//                       if ( v35 )
			//                         _InterlockedExchange64((volatile __int64 *)&TypeInfo::UnityEngine::Object, (__int64)v35);
			//                       break;
			//                     case 4u:
			//                       v35 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v24);
			//                       goto LABEL_89;
			//                     case 5u:
			//                       if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v24) )
			//                       {
			//                         v35 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v24);
			//                       }
			//                       else
			//                       {
			//                         v39 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v24);
			//                         v40 = il2cpp_string_new_len(
			//                                 qword_18D8E5198 + (int)v39[1] + *(int *)(qword_18D8E51A0 + 16),
			//                                 *v39);
			//                         v35 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                    (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v24),
			//                                                                    v40,
			//                                                                    0LL);
			//                         if ( !v35 )
			//                         {
			//                           if ( dword_18D8E43F8 )
			//                           {
			//                             v13 = &qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v24) >> 12) & 0x1FFFFF) >> 6];
			//                             v41 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v24) >> 12) & 0x3F;
			//                             _m_prefetchw(v13);
			//                             do
			//                               v42 = *v13;
			//                             while ( v42 != _InterlockedCompareExchange64(v13, *v13 | (1LL << v41), *v13) );
			//                           }
			//                           v35 = (void (__fastcall __noreturn **)())v40;
			//                         }
			//                       }
			//                       goto LABEL_89;
			//                     case 7u:
			//                       v43 = sub_1802DF920((unsigned int)v24);
			//                       v44 = *(_QWORD *)(v43 + 16);
			//                       v45 = (v43 - *(_QWORD *)(v44 + 128)) >> 5;
			//                       if ( *(_BYTE *)(v44 + 42) == 21 )
			//                       {
			//                         v46 = *(_QWORD ***)(v44 + 96);
			//                         if ( *v46 )
			//                         {
			//                           v47 = **v46 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                           v44 = sub_180039550(v47 / 92 + v47);
			//                         }
			//                         else
			//                         {
			//                           v44 = 0LL;
			//                         }
			//                       }
			//                       v78 = v45 + *(_DWORD *)(*(_QWORD *)(v44 + 104) + 32LL);
			//                       v48 = sub_1801B8ECC(
			//                               (unsigned int)&v78,
			//                               (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                               *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                               12,
			//                               (__int64)sub_1802C7760);
			//                       if ( !v48 )
			//                         goto LABEL_88;
			//                       v13 = (__int64 *)*(unsigned int *)(v48 + 8);
			//                       if ( (_DWORD)v13 == -1 )
			//                         goto LABEL_88;
			//                       v35 = (void (__fastcall __noreturn **)())((char *)v13
			//                                                               + qword_18D8E5198
			//                                                               + *(int *)(qword_18D8E51A0 + 72));
			//                       goto LABEL_89;
			//                     default:
			//                       break;
			//                   }
			//                 }
			//                 byte_18D8F4EAF = 1;
			//               }
			//               v14 = TypeInfo::UnityEngine::Object;
			//               if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//                 il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v13);
			//               v16 = containingType.fields._._._._.m_CachedPtr == 0LL;
			//             }
			//           }
			//           else
			//           {
			//             v16 = containingType == 0LL;
			//           }
			//         }
			//         if ( !v16 )
			//         {
			//           v49 = this.fields.nodes;
			//           if ( !containingType )
			//             sub_1802DC2C8(v14, v13);
			//           if ( !byte_18D8EDCF1 )
			//           {
			//             v50 = _InterlockedExchangeAdd64(
			//                     (volatile signed __int64 *)&TypeInfo::HG::Rendering::Runtime::IHGInteractionObject,
			//                     0LL);
			//             if ( (v50 & 1) != 0 )
			//             {
			//               v51 = (v50 >> 1) & 0xFFFFFFF;
			//               switch ( v50 >> 29 )
			//               {
			//                 case 1u:
			//                   v52 = (void (__fastcall __noreturn **)())sub_18003C670((unsigned int)v51);
			//                   goto LABEL_126;
			//                 case 2u:
			//                   v52 = (void (__fastcall __noreturn **)())sub_18003C380((unsigned int)v51);
			//                   goto LABEL_126;
			//                 case 3u:
			//                 case 6u:
			//                   v53 = (v50 >> 1) & 0xFFFFFFF;
			//                   v54 = v50 >> 29;
			//                   if ( v54 )
			//                   {
			//                     if ( v54 == 3 )
			//                     {
			//                       v52 = (void (__fastcall __noreturn **)())sub_180039480(v53);
			//                       goto LABEL_126;
			//                     }
			//                     if ( v54 == 6 )
			//                     {
			//                       v55 = sub_1802DF9C0(v53);
			//                       v52 = (void (__fastcall __noreturn **)())sub_18005F4B0(v55, 0LL);
			//                       goto LABEL_126;
			//                     }
			//                   }
			//                   else if ( v53 == 1 )
			//                   {
			//                     v52 = off_18A2C5600;
			//                     goto LABEL_126;
			//                   }
			// LABEL_125:
			//                   v52 = 0LL;
			// LABEL_126:
			//                   if ( v52 )
			//                     _InterlockedExchange64(
			//                       (volatile __int64 *)&TypeInfo::HG::Rendering::Runtime::IHGInteractionObject,
			//                       (__int64)v52);
			//                   break;
			//                 case 4u:
			//                   v52 = (void (__fastcall __noreturn **)())sub_1802DF920((unsigned int)v51);
			//                   goto LABEL_126;
			//                 case 5u:
			//                   if ( *(_QWORD *)(qword_18D8F6F98 + 8 * v51) )
			//                   {
			//                     v52 = *(void (__fastcall __noreturn ***)())(qword_18D8F6F98 + 8 * v51);
			//                   }
			//                   else
			//                   {
			//                     v56 = (unsigned int *)(qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 8) + 8 * v51);
			//                     v57 = il2cpp_string_new_len(qword_18D8E5198 + (int)v56[1] + *(int *)(qword_18D8E51A0 + 16), *v56);
			//                     v52 = (void (__fastcall __noreturn **)())_InterlockedCompareExchange64(
			//                                                                (volatile signed __int64 *)(qword_18D8F6F98 + 8 * v51),
			//                                                                v57,
			//                                                                0LL);
			//                     if ( !v52 )
			//                     {
			//                       if ( dword_18D8E43F8 )
			//                       {
			//                         v58 = &qword_18D6870D0[(((unsigned __int64)(qword_18D8F6F98 + 8 * v51) >> 12) & 0x1FFFFF) >> 6];
			//                         v59 = ((unsigned __int64)(qword_18D8F6F98 + 8 * v51) >> 12) & 0x3F;
			//                         _m_prefetchw(v58);
			//                         do
			//                           v60 = *v58;
			//                         while ( v60 != _InterlockedCompareExchange64(v58, *v58 | (1LL << v59), *v58) );
			//                       }
			//                       v52 = (void (__fastcall __noreturn **)())v57;
			//                     }
			//                   }
			//                   goto LABEL_126;
			//                 case 7u:
			//                   v61 = sub_1802DF920((unsigned int)v51);
			//                   v62 = *(_QWORD *)(v61 + 16);
			//                   v63 = (v61 - *(_QWORD *)(v62 + 128)) >> 5;
			//                   if ( *(_BYTE *)(v62 + 42) == 21 )
			//                   {
			//                     v64 = *(_QWORD ***)(v62 + 96);
			//                     if ( *v64 )
			//                     {
			//                       v65 = **v64 - (qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 160));
			//                       v62 = sub_180039550(v65 / 92 + v65);
			//                     }
			//                     else
			//                     {
			//                       v62 = 0LL;
			//                     }
			//                   }
			//                   v79 = v63 + *(_DWORD *)(*(_QWORD *)(v62 + 104) + 32LL);
			//                   v66 = sub_1801B8ECC(
			//                           (unsigned int)&v79,
			//                           (int)qword_18D8E5198 + *(_DWORD *)(qword_18D8E51A0 + 64),
			//                           *(int *)(qword_18D8E51A0 + 68) / 0xCuLL,
			//                           12,
			//                           (__int64)sub_1802C7760);
			//                   if ( !v66 )
			//                     goto LABEL_125;
			//                   v67 = *(unsigned int *)(v66 + 8);
			//                   if ( (_DWORD)v67 == -1 )
			//                     goto LABEL_125;
			//                   v52 = (void (__fastcall __noreturn **)())(v67 + qword_18D8E5198 + *(int *)(qword_18D8E51A0 + 72));
			//                   goto LABEL_126;
			//                 default:
			//                   break;
			//               }
			//             }
			//             byte_18D8EDCF1 = 1;
			//           }
			//           if ( *(_DWORD *)&containingType.klass._1.method_count == 3140 )
			//           {
			//             HG::Rendering::Runtime::HGInteractionComponent::CollectInteractionNodes(containingType, v49, 0LL);
			//           }
			//           else if ( *(_DWORD *)&containingType.klass._1.method_count == 3141 )
			//           {
			//             HG::Rendering::Runtime::HGCapsuleShadowHelper::CollectInteractionNodes(
			//               (HGCapsuleShadowHelper *)containingType,
			//               v49,
			//               0LL);
			//           }
			//           else
			//           {
			//             v68 = TypeInfo::HG::Rendering::Runtime::IHGInteractionObject;
			//             klass = containingType.klass;
			//             sub_180003EE0(containingType.klass);
			//             v70 = 0;
			//             v71 = *(_WORD *)&klass._1.naturalAligment;
			//             if ( v71 )
			//             {
			//               interfaceOffsets = klass.interfaceOffsets;
			//               while ( (struct IHGInteractionObject__Class *)interfaceOffsets[v70].interfaceType != v68 )
			//               {
			//                 if ( ++v70 >= v71 )
			//                   goto LABEL_135;
			//               }
			//               v73 = (__int64)(&klass.vtable.Equals.method + 2 * interfaceOffsets[v70].offset);
			//             }
			//             else
			//             {
			// LABEL_135:
			//               v73 = sub_18003CDA0(containingType, v68, 0LL);
			//             }
			//             (*(void (__fastcall **)(HGInteractionComponent *, List_1_HG_Rendering_Runtime_HGInteractionNode_ *, _QWORD))v73)(
			//               containingType,
			//               v49,
			//               *(_QWORD *)(v73 + 8));
			//           }
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v76 )
			//     {
			//       v80.klass = (OneofDescriptor__Class *)v76.methodPointer;
			//       if ( v80.klass )
			//         sub_18000F780(v80.klass);
			//     }
			//   }
			// }
			// 
		}

		private void BatchInstanceDraw(CommandBuffer cmd, ScriptableRenderContext renderContext, int batchStart, int batchEnd, Material material)
		{
			// // Void BatchInstanceDraw(CommandBuffer, ScriptableRenderContext, Int32, Int32, Material)
			// void HG::Rendering::Runtime::HGInterationManager::BatchInstanceDraw(
			//         HGInterationManager *this,
			//         CommandBuffer *cmd,
			//         ScriptableRenderContext renderContext,
			//         int32_t batchStart,
			//         int32_t batchEnd,
			//         Material *material,
			//         MethodInfo *method)
			// {
			//   int v7; // ebx
			//   List_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   List_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *renderDatas; // rax
			//   int v14; // edi
			//   signed int v15; // eax
			//   signed int v16; // r13d
			//   int32_t count; // r15d
			//   CBHandle *v18; // rax
			//   char *ptr; // xmm0_8
			//   int32_t v20; // eax
			//   __int64 v21; // rax
			//   char *v22; // rcx
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   __int128 v33; // xmm1
			//   __int128 v34; // xmm0
			//   __int128 v35; // xmm1
			//   List_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *v36; // rdx
			//   Shader *shader; // rbx
			//   String *s_InteractionUseCCD; // r8
			//   int v39; // [rsp+48h] [rbp-C0h]
			//   int32_t v40; // [rsp+4Ch] [rbp-BCh]
			//   signed int v41; // [rsp+50h] [rbp-B8h]
			//   LocalKeyword v42; // [rsp+58h] [rbp-B0h] BYREF
			//   uint32_t bufferId_8[4]; // [rsp+70h] [rbp-98h]
			//   LocalKeyword keyword_8; // [rsp+80h] [rbp-88h] BYREF
			//   char *v45; // [rsp+A8h] [rbp-60h]
			//   HGInteractionNodeRenderData v46; // [rsp+B0h] [rbp-58h] BYREF
			//   HGInteractionNodeRenderData v47; // [rsp+1A0h] [rbp+98h] BYREF
			//   HGInteractionNodeRenderData v48; // [rsp+290h] [rbp+188h] BYREF
			//   ScriptableRenderContext P2; // [rsp+3C8h] [rbp+2C0h] BYREF
			// 
			//   P2.m_Ptr = renderContext.m_Ptr;
			//   v7 = 0;
			//   if ( !byte_18D919E16 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919E16 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1540, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1540, 0LL);
			//     if ( !Patch )
			//       goto LABEL_25;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(
			//       Patch,
			//       (Object *)this,
			//       (Object *)cmd,
			//       P2,
			//       batchStart,
			//       batchEnd,
			//       (Object *)material,
			//       0LL);
			//   }
			//   else if ( batchEnd >= batchStart )
			//   {
			//     renderDatas = this.fields.renderDatas;
			//     if ( !renderDatas )
			//       goto LABEL_25;
			//     if ( batchEnd < renderDatas.fields._size && batchStart < renderDatas.fields._size )
			//     {
			//       v14 = batchEnd - batchStart;
			//       v41 = 0;
			//       v15 = 0;
			//       v16 = ((int)((unsigned __int64)(1374389535LL * v14) >> 32) >> 5)
			//           + ((unsigned int)((unsigned __int64)(1374389535LL * v14) >> 32) >> 31)
			//           + 1;
			//       if ( v16 > 0 )
			//       {
			//         v39 = 0;
			//         while ( 1 )
			//         {
			//           count = v15 == v14 / 100 ? v14 + 1 - 100 * v16 + 100 : 100;
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           v18 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                   (CBHandle *)&v42,
			//                   &P2,
			//                   224 * count,
			//                   0LL);
			//           v40 = 0;
			//           *(_OWORD *)bufferId_8 = *(_OWORD *)&v18.bufferId;
			//           ptr = (char *)v18.ptr;
			//           v20 = 0;
			//           v45 = ptr;
			//           if ( count > 0 )
			//             break;
			// LABEL_16:
			//           v36 = this.fields.renderDatas;
			//           if ( !v36
			//             || (System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item(
			//                   &v46,
			//                   v36,
			//                   batchStart,
			//                   MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item),
			//                 (v36 = this.fields.renderDatas) == 0LL)
			//             || (System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item(
			//                   &v47,
			//                   v36,
			//                   batchStart,
			//                   MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item),
			//                 (v36 = this.fields.renderDatas) == 0LL)
			//             || (System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item(
			//                   &v48,
			//                   v36,
			//                   batchStart,
			//                   MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item),
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs),
			//                 !cmd)
			//             || (UnityEngine::Rendering::CommandBuffer::SetGlobalConstantBufferInternal0(
			//                   cmd,
			//                   bufferId_8[0],
			//                   TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._InteractionDataCB,
			//                   bufferId_8[1],
			//                   22400,
			//                   0LL),
			//                 !material) )
			//           {
			//             sub_180B536AC(Patch, v36);
			//           }
			//           shader = UnityEngine::Material::get_shader(material, 0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//           s_InteractionUseCCD = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_InteractionUseCCD;
			//           memset(&v42, 0, sizeof(v42));
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v42, shader, s_InteractionUseCCD, 0LL);
			//           v7 = 0;
			//           keyword_8 = v42;
			//           UnityEngine::Rendering::CommandBuffer::SetKeyword(cmd, material, &keyword_8, v46.ccdKeyword, 0LL);
			//           UnityEngine::Rendering::CommandBuffer::HGDrawMeshInstanced(
			//             cmd,
			//             v48.mesh,
			//             0,
			//             material,
			//             v47.passIndex,
			//             count,
			//             0LL,
			//             0LL);
			//           v39 += 100;
			//           v15 = v41 + 1;
			//           v41 = v15;
			//           if ( v15 >= v16 )
			//             return;
			//         }
			//         while ( 1 )
			//         {
			//           v11 = this.fields.renderDatas;
			//           if ( !v11 )
			//             break;
			//           System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item(
			//             &v46,
			//             v11,
			//             batchStart + v20 + v39,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item);
			//           v21 = v7;
			//           v7 += 224;
			//           v22 = &v45[v21];
			//           v23 = *(_OWORD *)&v46.instanceData.localToWorld.m01;
			//           *(_OWORD *)v22 = *(_OWORD *)&v46.instanceData.localToWorld.m00;
			//           v24 = *(_OWORD *)&v46.instanceData.localToWorld.m02;
			//           *((_OWORD *)v22 + 1) = v23;
			//           v25 = *(_OWORD *)&v46.instanceData.localToWorld.m03;
			//           *((_OWORD *)v22 + 2) = v24;
			//           v26 = *(_OWORD *)&v46.instanceData.worldToLocal.m00;
			//           *((_OWORD *)v22 + 3) = v25;
			//           v27 = *(_OWORD *)&v46.instanceData.worldToLocal.m01;
			//           *((_OWORD *)v22 + 4) = v26;
			//           v28 = *(_OWORD *)&v46.instanceData.worldToLocal.m02;
			//           *((_OWORD *)v22 + 5) = v27;
			//           v29 = *(_OWORD *)&v46.instanceData.worldToLocal.m03;
			//           *((_OWORD *)v22 + 6) = v28;
			//           Patch = (ILFixDynamicMethodWrapper_2 *)(v22 + 128);
			//           v30 = *(_OWORD *)&v46.instanceData.prevLocalToWorld.m00;
			//           *(_OWORD *)&Patch[-1].fields.methodId = v29;
			//           v31 = *(_OWORD *)&v46.instanceData.prevLocalToWorld.m01;
			//           *(_OWORD *)&Patch.klass = v30;
			//           v32 = *(_OWORD *)&v46.instanceData.prevLocalToWorld.m02;
			//           *(_OWORD *)&Patch.fields.virtualMachine = v31;
			//           v33 = *(_OWORD *)&v46.instanceData.prevLocalToWorld.m03;
			//           *(_OWORD *)&Patch.fields.anonObj = v32;
			//           v34 = *(_OWORD *)&v46.instanceData.radius;
			//           *(_OWORD *)&Patch[1].monitor = v33;
			//           v35 = *(_OWORD *)&v46.instanceData.groundHeight;
			//           v20 = ++v40;
			//           *(_OWORD *)&Patch[1].fields.methodId = v34;
			//           *(_OWORD *)&Patch[2].klass = v35;
			//           if ( v40 >= count )
			//             goto LABEL_16;
			//         }
			// LABEL_25:
			//         sub_180B536AC(Patch, v11);
			//       }
			//     }
			//   }
			// }
			// 
		}

		public void DrawInteractions(CommandBuffer cmd, ScriptableRenderContext renderContext, Material material, Bounds bounds)
		{
			// // Void DrawInteractions(CommandBuffer, ScriptableRenderContext, Material, Bounds)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGInterationManager::DrawInteractions(
			//         HGInterationManager *this,
			//         CommandBuffer *cmd,
			//         ScriptableRenderContext renderContext,
			//         Material *material,
			//         Bounds *bounds,
			//         MethodInfo *method)
			// {
			//   Object *v6; // r15
			//   void *m_Ptr; // rbx
			//   Object *v8; // r12
			//   HGInterationManager *v9; // rsi
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __int64 v12; // rdx
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rcx
			//   __int64 v14; // rdx
			//   List_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *renderDatas; // rcx
			//   Comparison_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *v16; // rax
			//   List_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *i; // rdx
			//   Matrix4x4 *p_prevLocalToWorld; // rcx
			//   Comparison_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *v19; // r14
			//   unsigned int v20; // r14d
			//   List_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *v21; // rax
			//   List_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *v22; // rax
			//   __int64 v23; // rdx
			//   __int64 v24; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // r14
			//   List_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *batchStart; // [rsp+40h] [rbp-5E8h]
			//   unsigned int batchStarta; // [rsp+40h] [rbp-5E8h]
			//   Il2CppException *batchStartb; // [rsp+40h] [rbp-5E8h]
			//   Bounds v29; // [rsp+50h] [rbp-5D8h] BYREF
			//   Bounds v30; // [rsp+70h] [rbp-5B8h] BYREF
			//   Il2CppExceptionWrapper *v31; // [rsp+90h] [rbp-598h] BYREF
			//   HGInteractionNodeRenderData v32; // [rsp+A0h] [rbp-588h] BYREF
			//   HGInteractionNode current; // [rsp+190h] [rbp-498h] BYREF
			//   List_1_T_Enumerator_HG_Rendering_Runtime_HGInteractionNode_ v34; // [rsp+250h] [rbp-3D8h] BYREF
			//   HGInteractionNodeRenderData renderData; // [rsp+320h] [rbp-308h] BYREF
			//   HGInteractionNodeRenderData v36; // [rsp+410h] [rbp-218h] BYREF
			//   HGInteractionNodeRenderData v37; // [rsp+500h] [rbp-128h] BYREF
			// 
			//   v6 = (Object *)material;
			//   m_Ptr = renderContext.m_Ptr;
			//   v8 = (Object *)cmd;
			//   v9 = this;
			//   if ( !byte_18D919E17 )
			//   {
			//     sub_18003C530(&TypeInfo::System::Comparison<HG::Rendering::Runtime::HGInteractionNodeRenderData>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionNode>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionNode>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionNode>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::HGInteractionNodeRenderData::Sorter);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::Sort);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919E17 = 1;
			//   }
			//   sub_1802F01E0(&current, 0LL, 192LL);
			//   sub_1802F01E0(&renderData, 0LL, 240LL);
			//   sub_1802F01E0(&v36, 0LL, 240LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1541, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1541, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v24, v23);
			//     v29 = *bounds;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_590(
			//       Patch,
			//       (Object *)v9,
			//       v8,
			//       (ScriptableRenderContext)m_Ptr,
			//       v6,
			//       &v29,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Implicit((Object_1 *)v6, 0LL) )
			//     {
			//       if ( !v9.fields.renderDatas )
			//         sub_180B536AC(v11, v10);
			//       System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
			//         (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)v9.fields.renderDatas,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::Clear);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//       if ( !static_fields.terrainDeform )
			//         sub_180B536AC(static_fields, v12);
			//       if ( !v9.fields.nodes )
			//         sub_180B536AC(static_fields, v12);
			//       System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::GetEnumerator(
			//         (List_1_T_Enumerator_HG_Rendering_Runtime_HGInteractionNode_ *)&v32,
			//         v9.fields.nodes,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::GetEnumerator);
			//       *(_OWORD *)&v34._list = *(_OWORD *)&v32.instanceData.localToWorld.m00;
			//       v34._current = *(HGInteractionNode *)&v32.instanceData.localToWorld.m01;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionNode>::MoveNext(
			//                   &v34,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionNode>::MoveNext) )
			//         {
			//           current = v34._current;
			//           v29 = *HG::Rendering::Runtime::HGInteractionNode::GetBounds(&v30, &current, 0LL);
			//           v30 = *bounds;
			//           if ( UnityEngine::Bounds::Intersects(&v29, &v30, 0LL) )
			//           {
			//             if ( HG::Rendering::Runtime::HGInteractionNode::BuildRenderData(&current, &renderData, 0LL) )
			//             {
			//               renderDatas = v9.fields.renderDatas;
			//               if ( !renderDatas )
			//                 sub_1802DC2C8(0LL, v14);
			//               v32 = renderData;
			//               System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::Add(
			//                 renderDatas,
			//                 &v32,
			//                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::Add);
			//             }
			//             else
			//             {
			//               HG::Rendering::Runtime::HGInteractionNode::DrawNode(&current, (CommandBuffer *)v8, (Material *)v6, 0LL);
			//             }
			//           }
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v31 )
			//       {
			//         batchStartb = v31.ex;
			//         if ( batchStartb )
			//           sub_18000F780(batchStartb);
			//         v6 = (Object *)material;
			//         m_Ptr = renderContext.m_Ptr;
			//         v8 = (Object *)cmd;
			//         v9 = this;
			//       }
			//       batchStart = v9.fields.renderDatas;
			//       v16 = (Comparison_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *)sub_180004920(TypeInfo::System::Comparison<HG::Rendering::Runtime::HGInteractionNodeRenderData>);
			//       v19 = v16;
			//       if ( !v16 )
			//         goto LABEL_40;
			//       System::Comparison<HG::Rendering::Runtime::HGInteractionNodeRenderData>::Comparison(
			//         v16,
			//         0LL,
			//         MethodInfo::HG::Rendering::Runtime::HGInteractionNodeRenderData::Sorter,
			//         0LL);
			//       if ( !batchStart )
			//         goto LABEL_40;
			//       System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::Sort(
			//         batchStart,
			//         v19,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::Sort);
			//       p_prevLocalToWorld = 0LL;
			//       batchStarta = 0;
			//       v20 = 0;
			//       for ( i = 0LL; ; i = (List_1_HG_Rendering_Runtime_HGInteractionNodeRenderData_ *)++v20 )
			//       {
			//         v21 = v9.fields.renderDatas;
			//         if ( !v21 )
			//           goto LABEL_40;
			//         if ( (int)i >= v21.fields._size )
			//           break;
			//         if ( v20 )
			//         {
			//           i = v9.fields.renderDatas;
			//           if ( !i )
			//             goto LABEL_40;
			//           System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item(
			//             &v32,
			//             i,
			//             v20,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item);
			//           v36 = v32;
			//           p_prevLocalToWorld = &v36.instanceData.prevLocalToWorld;
			//           i = v9.fields.renderDatas;
			//           if ( !i )
			//             goto LABEL_40;
			//           System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item(
			//             &v32,
			//             i,
			//             v20 - 1,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNodeRenderData>::get_Item);
			//           v37 = v32;
			//           if ( HG::Rendering::Runtime::HGInteractionNodeRenderData::Match(&v36, &v37, 0LL) )
			//           {
			//             p_prevLocalToWorld = (Matrix4x4 *)batchStarta;
			//           }
			//           else
			//           {
			//             HG::Rendering::Runtime::HGInterationManager::BatchInstanceDraw(
			//               v9,
			//               (CommandBuffer *)v8,
			//               (ScriptableRenderContext)m_Ptr,
			//               batchStarta,
			//               v20 - 1,
			//               (Material *)v6,
			//               0LL);
			//             p_prevLocalToWorld = (Matrix4x4 *)v20;
			//             batchStarta = v20;
			//           }
			//         }
			//       }
			//       v22 = v9.fields.renderDatas;
			//       if ( !v22 )
			// LABEL_40:
			//         sub_1802DC2C8(p_prevLocalToWorld, i);
			//       HG::Rendering::Runtime::HGInterationManager::BatchInstanceDraw(
			//         v9,
			//         (CommandBuffer *)v8,
			//         (ScriptableRenderContext)m_Ptr,
			//         (int32_t)p_prevLocalToWorld,
			//         v22.fields._size - 1,
			//         (Material *)v6,
			//         0LL);
			//     }
			//   }
			// }
			// 
		}

		public void DrawInteractionsMobile(CommandBuffer cmd)
		{
			// // Void DrawInteractionsMobile(CommandBuffer)
			// void HG::Rendering::Runtime::HGInterationManager::DrawInteractionsMobile(
			//         HGInterationManager *this,
			//         CommandBuffer *cmd,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   HGInteractionSettingAsset *settingAsset; // rbx
			//   Object_1 *decalInteractionMaterial; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919E18 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919E18 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1542, 0LL) )
			//   {
			//     settingAsset = this.fields.settingAsset;
			//     if ( settingAsset )
			//     {
			//       decalInteractionMaterial = (Object_1 *)settingAsset.fields.decalInteractionMaterial;
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       UnityEngine::Object::op_Implicit(decalInteractionMaterial, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1542, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)cmd,
			//     0LL);
			// }
			// 
		}

		private const int MAX_BATCH_INSTANCE_NUM = 100;

		private List<IHGInteractionObject> objects;

		private List<HGInteractionNode> nodes;

		private List<HGInteractionNodeRenderData> renderDatas;

		private HGDecalInteration decalInteraction;

		private HGInteractionSettingAsset settingAsset;
	}
}
