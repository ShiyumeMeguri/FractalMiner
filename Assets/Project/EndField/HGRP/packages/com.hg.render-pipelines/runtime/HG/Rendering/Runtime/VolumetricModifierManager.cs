using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class VolumetricModifierManager
	{
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x00002608 File Offset: 0x00000808
		public int ModifierNum
		{
			get
			{
				// // Int32 get_ModifierNum()
				// int32_t HG::Rendering::Runtime::VolumetricModifierManager::get_ModifierNum(
				//         VolumetricModifierManager *this,
				//         MethodInfo *method)
				// {
				//   List_1_HG_Rendering_Runtime_VolumetricSDFModifier_ *modifierList; // rax
				// 
				//   if ( !byte_18D9197F2 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::get_Count);
				//     byte_18D9197F2 = 1;
				//   }
				//   if ( !this.fields._modifierBuffer )
				//     return 0;
				//   modifierList = this.fields.modifierList;
				//   if ( !modifierList )
				//     sub_180B536AC(this, method);
				//   return modifierList.fields._size;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x000025D2 File Offset: 0x000007D2
		public ComputeBuffer ModifierBuffer
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

		public VolumetricModifierManager()
		{
			// // VolumetricModifierManager()
			// void HG::Rendering::Runtime::VolumetricModifierManager::VolumetricModifierManager(
			//         VolumetricModifierManager *this,
			//         MethodInfo *method)
			// {
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v3; // rax
			//   __int64 v4; // rdx
			//   ComputeBuffer *defaultModifierBuffer; // rcx
			//   List_1_HG_Rendering_Runtime_VolumetricSDFModifier_ *v6; // rdi
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
			//   if ( !byte_18D9197F1 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FModifierData);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>);
			//     sub_18003C530(&off_18D521A38);
			//     byte_18D9197F1 = 1;
			//   }
			//   v3 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>);
			//   v6 = (List_1_HG_Rendering_Runtime_VolumetricSDFModifier_ *)v3;
			//   if ( !v3 )
			//     goto LABEL_8;
			//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//     v3,
			//     MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::List);
			//   this.fields.modifierList = v6;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields, v7, v8, v9, v23, v26);
			//   this.fields.modifierDataList = (FModifierData__Array *)il2cpp_array_new_specific_0(
			//                                                             TypeInfo::HG::Rendering::Runtime::FModifierData,
			//                                                             5LL,
			//                                                             v10,
			//                                                             v11);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.modifierDataList, v12, v13, v14, v24, v27);
			//   v15 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//   v16 = v15;
			//   if ( !v15
			//     || (UnityEngine::ComputeBuffer::ComputeBuffer(v15, 1, 48, ComputeBufferType__Enum_Default, 0LL),
			//         this.fields._defaultModifierBuffer = v16,
			//         sub_1800054D0((HGRenderPathScene *)&this.fields._defaultModifierBuffer, v17, v18, v19, v25, v28),
			//         v22 = (Array *)il2cpp_array_new_specific_0(TypeInfo::HG::Rendering::Runtime::FModifierData, 1LL, v20, v21),
			//         (defaultModifierBuffer = this.fields._defaultModifierBuffer) == 0LL)
			//     || (UnityEngine::ComputeBuffer::SetData(defaultModifierBuffer, v22, 0LL),
			//         (defaultModifierBuffer = this.fields._defaultModifierBuffer) == 0LL) )
			//   {
			// LABEL_8:
			//     sub_180B536AC(defaultModifierBuffer, v4);
			//   }
			//   UnityEngine::ComputeBuffer::SetName(defaultModifierBuffer, (String *)"defaultModifierBuffer", 0LL);
			//   HG::Rendering::Runtime::VolumetricModifierManager::UpdateBuffer(this, 0LL);
			// }
			// 
		}

		public void Release()
		{
			// // Void Release()
			// void HG::Rendering::Runtime::VolumetricModifierManager::Release(VolumetricModifierManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4563, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4563, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::VolumetricModifierManager::ClearResources(this, 0LL);
			//   }
			// }
			// 
		}

		public void Tick()
		{
			// // Void Tick()
			// void HG::Rendering::Runtime::VolumetricModifierManager::Tick(VolumetricModifierManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4565, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4565, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::VolumetricModifierManager::UpdateBuffer(this, 0LL);
			//   }
			// }
			// 
		}

		private void ClearResources()
		{
		}

		public void AddModifier(VolumetricSDFModifier modifier)
		{
			// // Void AddModifier(VolumetricSDFModifier)
			// void HG::Rendering::Runtime::VolumetricModifierManager::AddModifier(
			//         VolumetricModifierManager *this,
			//         VolumetricSDFModifier *modifier,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *modifierList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9197F3 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::Contains);
			//     byte_18D9197F3 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4567, 0LL) )
			//   {
			//     modifierList = (List_1_System_Object_ *)this.fields.modifierList;
			//     if ( modifierList )
			//     {
			//       if ( System::Collections::Generic::List<System::Object>::Contains(
			//              modifierList,
			//              (Object *)modifier,
			//              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::Contains) )
			//       {
			//         return;
			//       }
			//       modifierList = (List_1_System_Object_ *)this.fields.modifierList;
			//       if ( modifierList )
			//       {
			//         sub_1822AD140(modifierList, (Object *)modifier);
			//         HG::Rendering::Runtime::VolumetricModifierManager::UpdateBuffer(this, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(modifierList, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4567, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)modifier,
			//     0LL);
			// }
			// 
		}

		public void RemoveModifier(VolumetricSDFModifier modifier)
		{
			// // Void RemoveModifier(VolumetricSDFModifier)
			// void HG::Rendering::Runtime::VolumetricModifierManager::RemoveModifier(
			//         VolumetricModifierManager *this,
			//         VolumetricSDFModifier *modifier,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *modifierList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9197F4 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::Remove);
			//     byte_18D9197F4 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4568, 0LL) )
			//   {
			//     modifierList = (List_1_System_Object_ *)this.fields.modifierList;
			//     if ( modifierList )
			//     {
			//       if ( !System::Collections::Generic::List<System::Object>::Contains(
			//               modifierList,
			//               (Object *)modifier,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::Contains) )
			//         return;
			//       modifierList = (List_1_System_Object_ *)this.fields.modifierList;
			//       if ( modifierList )
			//       {
			//         System::Collections::Generic::List<System::Object>::Remove(
			//           modifierList,
			//           (Object *)modifier,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::Remove);
			//         HG::Rendering::Runtime::VolumetricModifierManager::UpdateBuffer(this, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(modifierList, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4568, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)modifier,
			//     0LL);
			// }
			// 
		}

		private void UpdateBuffer()
		{
			// // Void UpdateBuffer()
			// void HG::Rendering::Runtime::VolumetricModifierManager::UpdateBuffer(
			//         VolumetricModifierManager *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   ComputeBuffer *v4; // rcx
			//   List_1_HG_Rendering_Runtime_VolumetricSDFModifier_ *modifierList; // rbx
			//   int size; // ebx
			//   unsigned int v7; // esi
			//   __int64 v8; // r8
			//   __int64 v9; // r9
			//   ComputeBuffer *modifierBuffer; // rcx
			//   ComputeBuffer *v11; // rax
			//   ComputeBuffer *v12; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v13; // rdx
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   FModifierData__Array *modifierDataList; // rax
			//   HGRenderPathBase_HGRenderPathResources *v17; // rdx
			//   PassConstructorID__Enum__Array *v18; // r8
			//   HGCamera *v19; // r9
			//   int32_t v20; // esi
			//   List_1_HG_Rendering_Runtime_VolumetricSDFModifier_ *v21; // rax
			//   FModifierData__Array *v22; // rbx
			//   Object *Item; // rax
			//   FModifierData *ModifierData; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v26; // [rsp+20h] [rbp-48h]
			//   MethodInfo *v27; // [rsp+20h] [rbp-48h]
			//   MethodInfo *v28; // [rsp+28h] [rbp-40h]
			//   FModifierData v29; // [rsp+30h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D9197F5 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FModifierData);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::get_Item);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&off_18D521A70);
			//     byte_18D9197F5 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4566, 0LL) )
			//   {
			//     modifierList = this.fields.modifierList;
			//     if ( !modifierList )
			//       goto LABEL_28;
			//     size = modifierList.fields._size;
			//     sub_180002C70(TypeInfo::System::Math);
			//     v7 = 1;
			//     if ( size >= 1 )
			//       v7 = size;
			//     if ( !this.fields._modifierBuffer || UnityEngine::ComputeBuffer::get_count(this.fields._modifierBuffer, 0LL) != v7 )
			//     {
			//       modifierBuffer = this.fields._modifierBuffer;
			//       if ( modifierBuffer )
			//         UnityEngine::ComputeBuffer::Dispose(modifierBuffer, 0LL);
			//       v11 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//       v12 = v11;
			//       if ( !v11 )
			//         goto LABEL_28;
			//       UnityEngine::ComputeBuffer::ComputeBuffer(v11, v7, 48, ComputeBufferType__Enum_Default, 0LL);
			//       this.fields._modifierBuffer = v12;
			//       sub_1800054D0((HGRenderPathScene *)&this.fields._modifierBuffer, v13, v14, v15, v27, v28);
			//       v4 = this.fields._modifierBuffer;
			//       if ( !v4 )
			//         goto LABEL_28;
			//       UnityEngine::ComputeBuffer::SetName(v4, (String *)"modifierBuffer", 0LL);
			//     }
			//     modifierDataList = this.fields.modifierDataList;
			//     if ( modifierDataList )
			//     {
			//       if ( modifierDataList.max_length.size != v7 )
			//       {
			//         this.fields.modifierDataList = (FModifierData__Array *)il2cpp_array_new_specific_0(
			//                                                                   TypeInfo::HG::Rendering::Runtime::FModifierData,
			//                                                                   v7,
			//                                                                   v8,
			//                                                                   v9);
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.modifierDataList, v17, v18, v19, v26, v28);
			//       }
			//       v20 = 0;
			//       while ( 1 )
			//       {
			//         v21 = this.fields.modifierList;
			//         if ( !v21 )
			//           goto LABEL_28;
			//         v22 = this.fields.modifierDataList;
			//         if ( v20 >= v21.fields._size )
			//           break;
			//         Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                  (List_1_System_Object_ *)this.fields.modifierList,
			//                  v20,
			//                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSDFModifier>::get_Item);
			//         if ( !Item )
			//           goto LABEL_28;
			//         ModifierData = HG::Rendering::Runtime::VolumetricSDFModifier::GetModifierData(
			//                          &v29,
			//                          (VolumetricSDFModifier *)Item,
			//                          0LL);
			//         if ( !v22 )
			//           goto LABEL_28;
			//         if ( (unsigned int)v20 >= v22.max_length.size )
			//           sub_180070270(v4, v3 * 6);
			//         v4 = (ComputeBuffer *)v20;
			//         v3 = v20++;
			//         *(_OWORD *)&v22.vector[v3].Position.x = *(_OWORD *)&ModifierData.Position.x;
			//         *(_OWORD *)&v22.vector[v3].Payload.x = *(_OWORD *)&ModifierData.Payload.x;
			//         *(_OWORD *)&v22.vector[v3].Operation = *(_OWORD *)&ModifierData.Operation;
			//       }
			//       v4 = this.fields._modifierBuffer;
			//       if ( v4 )
			//       {
			//         UnityEngine::ComputeBuffer::SetData(v4, (Array *)this.fields.modifierDataList, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_28:
			//     sub_180B536AC(v4, v3 * 6);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4566, 0LL);
			//   if ( !Patch )
			//     goto LABEL_28;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private List<VolumetricSDFModifier> modifierList;

		private FModifierData[] modifierDataList;

		public ComputeBuffer _modifierBuffer;

		public ComputeBuffer _defaultModifierBuffer;
	}
}
