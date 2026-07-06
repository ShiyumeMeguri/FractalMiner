using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class VolumetricLocalLightManager
	{
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x00002608 File Offset: 0x00000808
		public int LocalLightNum
		{
			get
			{
				// // Int32 get_LocalLightNum()
				// int32_t HG::Rendering::Runtime::VolumetricLocalLightManager::get_LocalLightNum(
				//         VolumetricLocalLightManager *this,
				//         MethodInfo *method)
				// {
				//   List_1_HG_Rendering_Runtime_VolumetricLocalLight_ *localLightList; // rax
				// 
				//   if ( !byte_18D9197A5 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::get_Count);
				//     byte_18D9197A5 = 1;
				//   }
				//   if ( !this.fields._localLightBuffer )
				//     return 0;
				//   localLightList = this.fields.localLightList;
				//   if ( !localLightList )
				//     sub_180B536AC(this, method);
				//   return localLightList.fields._size;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x000025D2 File Offset: 0x000007D2
		public ComputeBuffer LocalLightBuffer
		{
			get
			{
				// // ComputeBuffer get_WindFieldBuffer()
				// ComputeBuffer *HG::Rendering::Runtime::VolumetricWindFieldManager::get_WindFieldBuffer(
				//         VolumetricWindFieldManager *this,
				//         MethodInfo *method)
				// {
				//   ComputeBuffer *result; // rax
				// 
				//   result = this.fields._windFieldBuffer;
				//   if ( !result )
				//     return this.fields._defaultWindFieldBuffer;
				//   return result;
				// }
				// 
				return null;
			}
		}

		public VolumetricLocalLightManager()
		{
			// // VolumetricLocalLightManager()
			// void HG::Rendering::Runtime::VolumetricLocalLightManager::VolumetricLocalLightManager(
			//         VolumetricLocalLightManager *this,
			//         MethodInfo *method)
			// {
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v3; // rax
			//   __int64 v4; // rdx
			//   ComputeBuffer *defaultLocalLightBuffer; // rcx
			//   List_1_HG_Rendering_Runtime_VolumetricLocalLight_ *v6; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v7; // rdx
			//   PassConstructorID__Enum__Array *v8; // r8
			//   HGCamera *v9; // r9
			//   __int64 v10; // r8
			//   __int64 v11; // r9
			//   HGRenderPathBase_HGRenderPathResources *v12; // rdx
			//   PassConstructorID__Enum__Array *v13; // r8
			//   HGCamera *v14; // r9
			//   ComputeBuffer *v15; // rax
			//   ComputeBuffer *v16; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   __int64 v20; // r8
			//   __int64 v21; // r9
			//   Array *v22; // rax
			//   MethodInfo *v23; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v24; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v25; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v26; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v27; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v28; // [rsp+28h] [rbp-10h]
			// 
			//   if ( !byte_18D9197A4 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FLocalLightData);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>);
			//     sub_18003C530(&off_18D51F9C8);
			//     byte_18D9197A4 = 1;
			//   }
			//   v3 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>);
			//   v6 = (List_1_HG_Rendering_Runtime_VolumetricLocalLight_ *)v3;
			//   if ( !v3 )
			//     goto LABEL_8;
			//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//     v3,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::List);
			//   this.fields.localLightList = v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields, v7, v8, v9, v23, v26);
			//   this.fields.localLightDataList = (FLocalLightData__Array *)il2cpp_array_new_specific_0(
			//                                                                 TypeInfo::HG::Rendering::Runtime::FLocalLightData,
			//                                                                 5LL,
			//                                                                 v10,
			//                                                                 v11);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.localLightDataList, v12, v13, v14, v24, v27);
			//   v15 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//   v16 = v15;
			//   if ( !v15
			//     || (UnityEngine::ComputeBuffer::ComputeBuffer(v15, 1, 80, ComputeBufferType__Enum_Default, 0LL),
			//         this.fields._defaultLocalLightBuffer = v16,
			//         sub_1800054D0((HGRenderPathScene *)&this.fields._defaultLocalLightBuffer, v17, v18, v19, v25, v28),
			//         v22 = (Array *)il2cpp_array_new_specific_0(TypeInfo::HG::Rendering::Runtime::FLocalLightData, 1LL, v20, v21),
			//         (defaultLocalLightBuffer = this.fields._defaultLocalLightBuffer) == 0LL)
			//     || (UnityEngine::ComputeBuffer::SetData(defaultLocalLightBuffer, v22, 0LL),
			//         (defaultLocalLightBuffer = this.fields._defaultLocalLightBuffer) == 0LL) )
			//   {
			// LABEL_8:
			//     sub_180B536AC(defaultLocalLightBuffer, v4);
			//   }
			//   UnityEngine::ComputeBuffer::SetName(defaultLocalLightBuffer, (String *)"defaultLocalLightBuffer", 0LL);
			//   HG::Rendering::Runtime::VolumetricLocalLightManager::UpdateBuffer(this, 0LL);
			// }
			// 
		}

		public void Release()
		{
			// // Void Release()
			// void HG::Rendering::Runtime::VolumetricLocalLightManager::Release(
			//         VolumetricLocalLightManager *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4465, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4465, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::VolumetricLocalLightManager::ClearResources(this, 0LL);
			//   }
			// }
			// 
		}

		public void Tick()
		{
			// // Void Tick()
			// void HG::Rendering::Runtime::VolumetricLocalLightManager::Tick(VolumetricLocalLightManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4467, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4467, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::VolumetricLocalLightManager::UpdateBuffer(this, 0LL);
			//   }
			// }
			// 
		}

		private void ClearResources()
		{
		}

		public void AddLocalLight(VolumetricLocalLight localLight)
		{
			// // Void AddLocalLight(VolumetricLocalLight)
			// void HG::Rendering::Runtime::VolumetricLocalLightManager::AddLocalLight(
			//         VolumetricLocalLightManager *this,
			//         VolumetricLocalLight *localLight,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *localLightList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9197A6 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::Contains);
			//     byte_18D9197A6 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4469, 0LL) )
			//   {
			//     localLightList = (List_1_System_Object_ *)this.fields.localLightList;
			//     if ( localLightList )
			//     {
			//       if ( System::Collections::Generic::List<System::Object>::Contains(
			//              localLightList,
			//              (Object *)localLight,
			//              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::Contains) )
			//       {
			//         return;
			//       }
			//       localLightList = (List_1_System_Object_ *)this.fields.localLightList;
			//       if ( localLightList )
			//       {
			//         sub_1822AD140(localLightList, (Object *)localLight);
			//         HG::Rendering::Runtime::VolumetricLocalLightManager::UpdateBuffer(this, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(localLightList, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4469, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)localLight,
			//     0LL);
			// }
			// 
		}

		public void RemoveLocalLight(VolumetricLocalLight localLight)
		{
			// // Void RemoveLocalLight(VolumetricLocalLight)
			// void HG::Rendering::Runtime::VolumetricLocalLightManager::RemoveLocalLight(
			//         VolumetricLocalLightManager *this,
			//         VolumetricLocalLight *localLight,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *localLightList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9197A7 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::Remove);
			//     byte_18D9197A7 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4470, 0LL) )
			//   {
			//     localLightList = (List_1_System_Object_ *)this.fields.localLightList;
			//     if ( localLightList )
			//     {
			//       if ( !System::Collections::Generic::List<System::Object>::Contains(
			//               localLightList,
			//               (Object *)localLight,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::Contains) )
			//         return;
			//       localLightList = (List_1_System_Object_ *)this.fields.localLightList;
			//       if ( localLightList )
			//       {
			//         System::Collections::Generic::List<System::Object>::Remove(
			//           localLightList,
			//           (Object *)localLight,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::Remove);
			//         HG::Rendering::Runtime::VolumetricLocalLightManager::UpdateBuffer(this, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(localLightList, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4470, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)localLight,
			//     0LL);
			// }
			// 
		}

		private void UpdateBuffer()
		{
			// // Void UpdateBuffer()
			// void HG::Rendering::Runtime::VolumetricLocalLightManager::UpdateBuffer(
			//         VolumetricLocalLightManager *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   ComputeBuffer *v4; // rcx
			//   List_1_HG_Rendering_Runtime_VolumetricLocalLight_ *localLightList; // rbx
			//   int size; // ebx
			//   unsigned int v7; // esi
			//   __int64 v8; // r8
			//   __int64 v9; // r9
			//   ComputeBuffer *localLightBuffer; // rcx
			//   ComputeBuffer *v11; // rax
			//   ComputeBuffer *v12; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v13; // rdx
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   FLocalLightData__Array *localLightDataList; // rax
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   int32_t v20; // esi
			//   List_1_HG_Rendering_Runtime_VolumetricLocalLight_ *v21; // rax
			//   FLocalLightData__Array *v22; // rbx
			//   Object *Item; // rax
			//   FLocalLightData *LocalLightData; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v26; // [rsp+20h] [rbp-68h]
			//   MethodInfo *v27; // [rsp+20h] [rbp-68h]
			//   MethodInfo *v28; // [rsp+28h] [rbp-60h]
			//   FLocalLightData v29; // [rsp+30h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D9197A8 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FLocalLightData);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::get_Item);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&off_18D51FE40);
			//     byte_18D9197A8 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4468, 0LL) )
			//   {
			//     localLightList = this.fields.localLightList;
			//     if ( !localLightList )
			//       goto LABEL_28;
			//     size = localLightList.fields._size;
			//     sub_180002C70(TypeInfo::System::Math);
			//     v7 = 1;
			//     if ( size >= 1 )
			//       v7 = size;
			//     if ( !this.fields._localLightBuffer
			//       || UnityEngine::ComputeBuffer::get_count(this.fields._localLightBuffer, 0LL) != v7 )
			//     {
			//       localLightBuffer = this.fields._localLightBuffer;
			//       if ( localLightBuffer )
			//         UnityEngine::ComputeBuffer::Dispose(localLightBuffer, 0LL);
			//       v11 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//       v12 = v11;
			//       if ( !v11 )
			//         goto LABEL_28;
			//       UnityEngine::ComputeBuffer::ComputeBuffer(v11, v7, 80, ComputeBufferType__Enum_Default, 0LL);
			//       this.fields._localLightBuffer = v12;
			//       sub_1800054D0((HGRenderPathScene *)&this.fields._localLightBuffer, v13, v14, v15, v27, v28);
			//       v4 = this.fields._localLightBuffer;
			//       if ( !v4 )
			//         goto LABEL_28;
			//       UnityEngine::ComputeBuffer::SetName(v4, (String *)"localLightBuffer", 0LL);
			//     }
			//     localLightDataList = this.fields.localLightDataList;
			//     if ( localLightDataList )
			//     {
			//       if ( localLightDataList.max_length.size != v7 )
			//       {
			//         this.fields.localLightDataList = (FLocalLightData__Array *)il2cpp_array_new_specific_0(
			//                                                                       TypeInfo::HG::Rendering::Runtime::FLocalLightData,
			//                                                                       v7,
			//                                                                       v8,
			//                                                                       v9);
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.localLightDataList, v17, v18, v19, v26, v28);
			//       }
			//       v20 = 0;
			//       while ( 1 )
			//       {
			//         v21 = this.fields.localLightList;
			//         if ( !v21 )
			//           goto LABEL_28;
			//         v22 = this.fields.localLightDataList;
			//         if ( v20 >= v21.fields._size )
			//           break;
			//         Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                  (List_1_System_Object_ *)this.fields.localLightList,
			//                  v20,
			//                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricLocalLight>::get_Item);
			//         if ( !Item )
			//           goto LABEL_28;
			//         LocalLightData = HG::Rendering::Runtime::VolumetricLocalLight::GetLocalLightData(
			//                            &v29,
			//                            (VolumetricLocalLight *)Item,
			//                            0LL);
			//         if ( !v22 )
			//           goto LABEL_28;
			//         if ( (unsigned int)v20 >= v22.max_length.size )
			//           sub_180070270(v4, v3 * 10);
			//         v4 = (ComputeBuffer *)v20;
			//         v3 = v20++;
			//         *(_OWORD *)&v22.vector[v3].Position.x = *(_OWORD *)&LocalLightData.Position.x;
			//         *(_OWORD *)&v22.vector[v3].Color.x = *(_OWORD *)&LocalLightData.Color.x;
			//         *(_OWORD *)&v22.vector[v3].Direction.x = *(_OWORD *)&LocalLightData.Direction.x;
			//         *(_OWORD *)&v22.vector[v3].SpotAngles.x = *(_OWORD *)&LocalLightData.SpotAngles.x;
			//         *(_OWORD *)&v22.vector[v3].ShadowIntensity = *(_OWORD *)&LocalLightData.ShadowIntensity;
			//       }
			//       v4 = this.fields._localLightBuffer;
			//       if ( v4 )
			//       {
			//         UnityEngine::ComputeBuffer::SetData(v4, (Array *)this.fields.localLightDataList, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_28:
			//     sub_180B536AC(v4, v3 * 10);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4468, 0LL);
			//   if ( !Patch )
			//     goto LABEL_28;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private List<VolumetricLocalLight> localLightList;

		private FLocalLightData[] localLightDataList;

		public ComputeBuffer _localLightBuffer;

		public ComputeBuffer _defaultLocalLightBuffer;
	}
}
