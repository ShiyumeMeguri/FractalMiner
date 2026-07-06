using System;
using System.Collections.Generic;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	public class VolumetricManager
	{
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x000025D2 File Offset: 0x000007D2
		public List<IVolumetricRenderObject> VolumetricRenderObjects
		{
			get
			{
				// // List`1[HG.Rendering.Runtime.IVolumetricRenderObject] get_VolumetricRenderObjects()
				// List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *HG::Rendering::Runtime::VolumetricManager::get_VolumetricRenderObjects(
				//         VolumetricManager *this,
				//         MethodInfo *method)
				// {
				//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rax
				//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
				//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
				//   ILFixDynamicMethodWrapper_2__Array *v7; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
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
				//     goto LABEL_8;
				//   if ( wrapperArray.max_length.size <= 804 )
				//     return this.fields.m_VolumetricRenderObjects;
				//   if ( !v3._1.cctor_finished_or_no_cctor )
				//   {
				//     il2cpp_runtime_class_init_0(v3, wrapperArray);
				//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
				//   }
				//   static_fields = v3.static_fields;
				//   v7 = static_fields.wrapperArray;
				//   if ( !static_fields.wrapperArray )
				//     goto LABEL_8;
				//   if ( v7.max_length.size <= 0x324u )
				//     sub_180070270(static_fields, wrapperArray);
				//   if ( !v7[22].vector[12] )
				//     return this.fields.m_VolumetricRenderObjects;
				//   Patch = IFix::WrappersManagerImpl::GetPatch(804, 0LL);
				//   if ( !Patch )
				// LABEL_8:
				//     sub_180B536AC(static_fields, wrapperArray);
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_305(Patch, (Object *)this, 0LL);
				// }
				// 
				return null;
			}
		}

		public VolumetricManager()
		{
		}

		public void Release()
		{
			// // Void Release()
			// void HG::Rendering::Runtime::VolumetricManager::Release(VolumetricManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *m_VolumetricRenderObjects; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9197B5 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Clear);
			//     byte_18D9197B5 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1930, 0LL) )
			//   {
			//     m_VolumetricRenderObjects = this.fields.m_VolumetricRenderObjects;
			//     if ( m_VolumetricRenderObjects )
			//     {
			//       sub_1823B99D0(
			//         m_VolumetricRenderObjects,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Clear);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(m_VolumetricRenderObjects, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1930, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void RegisterVolumetricRenderObject(IVolumetricRenderObject vro)
		{
			// // Void RegisterVolumetricRenderObject(IVolumetricRenderObject)
			// void HG::Rendering::Runtime::VolumetricManager::RegisterVolumetricRenderObject(
			//         VolumetricManager *this,
			//         IVolumetricRenderObject *vro,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *m_VolumetricRenderObjects; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9197B6 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Contains);
			//     byte_18D9197B6 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4374, 0LL) )
			//   {
			//     if ( !vro )
			//       return;
			//     m_VolumetricRenderObjects = (List_1_System_Object_ *)this.fields.m_VolumetricRenderObjects;
			//     if ( m_VolumetricRenderObjects )
			//     {
			//       if ( System::Collections::Generic::List<System::Object>::Contains(
			//              m_VolumetricRenderObjects,
			//              (Object *)vro,
			//              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Contains) )
			//       {
			//         return;
			//       }
			//       m_VolumetricRenderObjects = (List_1_System_Object_ *)this.fields.m_VolumetricRenderObjects;
			//       if ( m_VolumetricRenderObjects )
			//       {
			//         sub_1822AD140(m_VolumetricRenderObjects, (Object *)vro);
			//         return;
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(m_VolumetricRenderObjects, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4374, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)vro,
			//     0LL);
			// }
			// 
		}

		public void UnregisterVolumetricRenderObject(IVolumetricRenderObject vro)
		{
		}

		public void PipelineUpdate()
		{
			// // Void PipelineUpdate()
			// void HG::Rendering::Runtime::VolumetricManager::PipelineUpdate(VolumetricManager *this, MethodInfo *method)
			// {
			//   void *v3; // rcx
			//   __int64 v4; // rdx
			//   List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *m_VolumetricRenderObjects; // rbx
			//   Comparison_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *v6; // rdi
			//   struct MethodInfo *v7; // rsi
			//   Object__Array *items; // rbp
			//   int32_t size; // r14d
			//   __int64 v10; // rax
			//   __int64 v11; // rdx
			//   Object *v12; // rsi
			//   Comparison_1_Object_ *v13; // rax
			//   HGRenderPathBase_HGRenderPathResources *v14; // rdx
			//   PassConstructorID__Enum__Array *v15; // r8
			//   HGCamera *v16; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *methoda; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v19; // [rsp+28h] [rbp-10h]
			// 
			//   if ( !byte_18D8EDBAC )
			//   {
			//     sub_18003C530(&TypeInfo::System::Comparison<HG::Rendering::Runtime::IVolumetricRenderObject>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Sort);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::VolumetricManager::__c::_PipelineUpdate_b__7_0);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VolumetricManager::__c);
			//     byte_18D8EDBAC = 1;
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
			//   v4 = **((_QWORD **)v3 + 23);
			//   if ( !v4 )
			//     goto LABEL_19;
			//   if ( *(int *)(v4 + 24) > 1974 )
			//   {
			//     if ( !*((_DWORD *)v3 + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(v3, v4);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (void *)**((_QWORD **)v3 + 23);
			//     if ( !v3 )
			//       goto LABEL_19;
			//     if ( *((_DWORD *)v3 + 6) <= 0x7B6u )
			//       sub_180070270(v3, v4);
			//     if ( *((_QWORD *)v3 + 1978) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1974, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//         return;
			//       }
			//       goto LABEL_19;
			//     }
			//   }
			//   v3 = TypeInfo::HG::Rendering::Runtime::VolumetricManager::__c;
			//   m_VolumetricRenderObjects = this.fields.m_VolumetricRenderObjects;
			//   if ( !TypeInfo::HG::Rendering::Runtime::VolumetricManager::__c._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VolumetricManager::__c, v4);
			//     v3 = TypeInfo::HG::Rendering::Runtime::VolumetricManager::__c;
			//   }
			//   v6 = *(Comparison_1_HG_Rendering_Runtime_IVolumetricRenderObject_ **)(*((_QWORD *)v3 + 23) + 8LL);
			//   if ( !v6 )
			//   {
			//     if ( !*((_DWORD *)v3 + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(v3, v4);
			//       v3 = TypeInfo::HG::Rendering::Runtime::VolumetricManager::__c;
			//     }
			//     v12 = (Object *)**((_QWORD **)v3 + 23);
			//     v13 = (Comparison_1_Object_ *)sub_180004920(TypeInfo::System::Comparison<HG::Rendering::Runtime::IVolumetricRenderObject>);
			//     v6 = (Comparison_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *)v13;
			//     if ( v13 )
			//     {
			//       System::Comparison<System::Object>::Comparison(
			//         v13,
			//         v12,
			//         MethodInfo::HG::Rendering::Runtime::VolumetricManager::__c::_PipelineUpdate_b__7_0,
			//         0LL);
			//       TypeInfo::HG::Rendering::Runtime::VolumetricManager::__c.static_fields.__9__7_0 = v6;
			//       sub_1800054D0(
			//         (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::VolumetricManager::__c.static_fields.__9__7_0,
			//         v14,
			//         v15,
			//         v16,
			//         methoda,
			//         v19);
			//       goto LABEL_12;
			//     }
			// LABEL_19:
			//     sub_180B536AC(v3, v4);
			//   }
			// LABEL_12:
			//   if ( !m_VolumetricRenderObjects )
			//     goto LABEL_19;
			//   v7 = MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Sort;
			//   if ( !v6 )
			//     System::ThrowHelper::ThrowArgumentNullException(ExceptionArgument__Enum_comparison, 0LL);
			//   if ( m_VolumetricRenderObjects.fields._size > 1 )
			//   {
			//     items = (Object__Array *)m_VolumetricRenderObjects.fields._items;
			//     size = m_VolumetricRenderObjects.fields._size;
			//     v10 = ((__int64 (__fastcall *)(_QWORD))sub_18010B520)((const Il2CppRGCTXData)MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::Sort.klass.rgctx_data[52].rgctxDataDummy);
			//     if ( !*(_DWORD *)(v10 + 224) )
			//       il2cpp_runtime_class_init_0(v10, v11);
			//     System::Collections::Generic::ArraySortHelper<System::Object>::Sort(
			//       items,
			//       0,
			//       size,
			//       (Comparison_1_Object_ *)v6,
			//       (MethodInfo *)v7.klass.rgctx_data[51].rgctxDataDummy);
			//   }
			//   ++m_VolumetricRenderObjects.fields._version;
			// }
			// 
		}

		public List<HGVolumetricRenderItem> PrepareRenderItemsCPP(HGCamera hgCamera, HGVolumetricCloudSettingParameters volumetricParameters)
		{
			// // List`1[UnityEngine.HyperGryphEngineCode.HGVolumetricRenderItem] PrepareRenderItemsCPP(HGCamera, HGVolumetricCloudSettingParameters)
			// // Hidden C++ exception states: #wind=1
			// List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *HG::Rendering::Runtime::VolumetricManager::PrepareRenderItemsCPP(
			//         VolumetricManager *this,
			//         HGCamera *hgCamera,
			//         HGVolumetricCloudSettingParameters *volumetricParameters,
			//         MethodInfo *method)
			// {
			//   VolumetricManager *v6; // rbx
			//   struct ILFixDynamicMethodWrapper_2__Class *v7; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
			//   ILFixDynamicMethodWrapper_2__Array *v9; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   List_1_UnityEngine_HyperGryphEngineCode_HGVolumetricRenderItem_ *m_RenderItems; // rdi
			//   List_1_HG_Rendering_Runtime_IVolumetricRenderObject_ *m_VolumetricRenderObjects; // rdi
			//   __int64 v16; // rdx
			//   MethodInfo *methoda; // [rsp+20h] [rbp-58h]
			//   MethodInfo *v18; // [rsp+28h] [rbp-50h]
			//   _BYTE v19[24]; // [rsp+30h] [rbp-48h] BYREF
			//   Il2CppExceptionWrapper *v20; // [rsp+48h] [rbp-30h] BYREF
			//   List_1_T_Enumerator_System_Object_ v21; // [rsp+50h] [rbp-28h] BYREF
			// 
			//   v6 = this;
			//   if ( !byte_18D8EDBAD )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::HyperGryphEngineCode::HGVolumetricRenderItem>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricRenderObject>::GetEnumerator);
			//     byte_18D8EDBAD = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, hgCamera);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v7.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v7, hgCamera);
			//   if ( wrapperArray.max_length.size <= 1031 )
			//     goto LABEL_16;
			//   if ( !v7._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v7, hgCamera);
			//     v7 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v9 = v7.static_fields.wrapperArray;
			//   if ( !v9 )
			//     sub_180B536AC(v7, hgCamera);
			//   if ( v9.max_length.size <= 0x407u )
			//     sub_180070270(v7, hgCamera);
			//   if ( v9[28].vector[23] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1031, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_370(
			//              Patch,
			//              (Object *)v6,
			//              (Object *)hgCamera,
			//              (Object *)volumetricParameters,
			//              0LL);
			//   }
			//   else
			//   {
			// LABEL_16:
			//     m_RenderItems = v6.fields.m_RenderItems;
			//     if ( !m_RenderItems )
			//       sub_180B536AC(v7, hgCamera);
			//     ++m_RenderItems.fields._version;
			//     m_RenderItems.fields._size = 0;
			//     m_VolumetricRenderObjects = v6.fields.m_VolumetricRenderObjects;
			//     if ( !m_VolumetricRenderObjects )
			//       sub_180B536AC(v7, hgCamera);
			//     *(_OWORD *)&v19[8] = 0LL;
			//     *(_QWORD *)v19 = m_VolumetricRenderObjects;
			//     sub_1800054D0(
			//       (HGRenderPathScene *)v19,
			//       (HGRenderPathBase_HGRenderPathResources *)hgCamera,
			//       (PassConstructorID__Enum__Array *)volumetricParameters,
			//       (HGCamera *)method,
			//       methoda,
			//       v18);
			//     *(_DWORD *)&v19[8] = 0;
			//     *(_DWORD *)&v19[12] = m_VolumetricRenderObjects.fields._version;
			//     *(_QWORD *)&v19[16] = 0LL;
			//     *(_OWORD *)&v21._list = *(_OWORD *)v19;
			//     v21._current = 0LL;
			//     *(_QWORD *)v19 = 0LL;
			//     *(_QWORD *)&v19[8] = &v21;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v21,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::IVolumetricRenderObject>::MoveNext) )
			//       {
			//         if ( !v21._current )
			//           sub_1802DC2C8(0LL, v16);
			//         sub_1886C0DB8((VolumetricRenderObject *)v21._current, hgCamera, volumetricParameters, v6.fields.m_RenderItems);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v20 )
			//     {
			//       *(Il2CppExceptionWrapper *)v19 = (Il2CppExceptionWrapper)v20.ex;
			//       if ( *(_QWORD *)v19 )
			//         sub_18000F780(*(_QWORD *)v19);
			//       v6 = this;
			//     }
			//     return v6.fields.m_RenderItems;
			//   }
			// }
			// 
			return null;
		}

		private List<HGVolumetricRenderItem> m_RenderItems;

		private List<IVolumetricRenderObject> m_VolumetricRenderObjects;
	}
}
