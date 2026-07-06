using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class VolumetricWindFieldManager
	{
		// (get) Token: 0x06001BAD RID: 7085 RVA: 0x00002608 File Offset: 0x00000808
		public int WindFieldNum
		{
			get
			{
				// // Int32 get_WindFieldNum()
				// int32_t HG::Rendering::Runtime::VolumetricWindFieldManager::get_WindFieldNum(
				//         VolumetricWindFieldManager *this,
				//         MethodInfo *method)
				// {
				//   List_1_HG_Rendering_Runtime_IVolumetricWindField_ *windFieldList; // rax
				// 
				//   if ( !byte_18D919830 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricWindField>::get_Count);
				//     byte_18D919830 = 1;
				//   }
				//   if ( !this.fields._windFieldBuffer )
				//     return 0;
				//   windFieldList = this.fields.windFieldList;
				//   if ( !windFieldList )
				//     sub_180B536AC(this, method);
				//   return windFieldList.fields._size;
				// }
				// 
				return 0;
			}
		}

		// (get) Token: 0x06001BAE RID: 7086 RVA: 0x000025D2 File Offset: 0x000007D2
		public ComputeBuffer WindFieldBuffer
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

		public VolumetricWindFieldManager()
		{
		}

		public void Release()
		{
			// // Void Release()
			// void HG::Rendering::Runtime::VolumetricWindFieldManager::Release(VolumetricWindFieldManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4400, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4400, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::VolumetricWindFieldManager::ClearResources(this, 0LL);
			//   }
			// }
			// 
		}

		private void ClearResources()
		{
		}

		public void AddWindField(IVolumetricWindField windField)
		{
			// // Void AddWindField(IVolumetricWindField)
			// void HG::Rendering::Runtime::VolumetricWindFieldManager::AddWindField(
			//         VolumetricWindFieldManager *this,
			//         IVolumetricWindField *windField,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *windFieldList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919831 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricWindField>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricWindField>::Contains);
			//     byte_18D919831 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4359, 0LL) )
			//   {
			//     windFieldList = (List_1_System_Object_ *)this.fields.windFieldList;
			//     if ( windFieldList )
			//     {
			//       if ( System::Collections::Generic::List<System::Object>::Contains(
			//              windFieldList,
			//              (Object *)windField,
			//              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricWindField>::Contains) )
			//       {
			//         return;
			//       }
			//       windFieldList = (List_1_System_Object_ *)this.fields.windFieldList;
			//       if ( windFieldList )
			//       {
			//         sub_1822AD140(windFieldList, (Object *)windField);
			//         return;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(windFieldList, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4359, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)windField,
			//     0LL);
			// }
			// 
		}

		public void RemoveWindField(IVolumetricWindField windField)
		{
			// // Void RemoveWindField(IVolumetricWindField)
			// void HG::Rendering::Runtime::VolumetricWindFieldManager::RemoveWindField(
			//         VolumetricWindFieldManager *this,
			//         IVolumetricWindField *windField,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   List_1_System_Object_ *windFieldList; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919832 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricWindField>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricWindField>::Remove);
			//     byte_18D919832 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4361, 0LL) )
			//   {
			//     windFieldList = (List_1_System_Object_ *)this.fields.windFieldList;
			//     if ( windFieldList )
			//     {
			//       if ( !System::Collections::Generic::List<System::Object>::Contains(
			//               windFieldList,
			//               (Object *)windField,
			//               MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricWindField>::Contains) )
			//         return;
			//       windFieldList = (List_1_System_Object_ *)this.fields.windFieldList;
			//       if ( windFieldList )
			//       {
			//         System::Collections::Generic::List<System::Object>::Remove(
			//           windFieldList,
			//           (Object *)windField,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricWindField>::Remove);
			//         return;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(windFieldList, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4361, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)windField,
			//     0LL);
			// }
			// 
		}

		public void Tick()
		{
			// // Void Tick()
			// void HG::Rendering::Runtime::VolumetricWindFieldManager::Tick(VolumetricWindFieldManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4386, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4386, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::VolumetricWindFieldManager::UpdateBuffer(this, 0LL);
			//   }
			// }
			// 
		}

		private void UpdateBuffer()
		{
			// // Void UpdateBuffer()
			// void HG::Rendering::Runtime::VolumetricWindFieldManager::UpdateBuffer(
			//         VolumetricWindFieldManager *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   ComputeBuffer *v4; // rcx
			//   List_1_HG_Rendering_Runtime_IVolumetricWindField_ *windFieldList; // rbx
			//   int size; // ebx
			//   unsigned int v7; // esi
			//   __int64 v8; // r8
			//   __int64 v9; // r9
			//   ComputeBuffer *windFieldBuffer; // rcx
			//   ComputeBuffer *v11; // rax
			//   ComputeBuffer *v12; // rbx
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v13; // rdx
			//   VolumetricRenderer_VolumetricBounds *v14; // r8
			//   Material *v15; // r9
			//   FWindFieldData__Array *windFieldDataList; // rax
			//   Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v17; // rdx
			//   VolumetricRenderer_VolumetricBounds *v18; // r8
			//   Material *v19; // r9
			//   int32_t v20; // esi
			//   List_1_HG_Rendering_Runtime_IVolumetricWindField_ *v21; // rax
			//   FWindFieldData__Array *v22; // rbx
			//   __int64 v23; // r8
			//   Object *Item; // r14
			//   Vector4 Param1; // xmm1
			//   Vector4 Param2; // xmm0
			//   Vector4 Param3; // xmm1
			//   Vector4 Param4; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v30; // [rsp+20h] [rbp-68h]
			//   MethodInfo *v31; // [rsp+20h] [rbp-68h]
			//   MethodInfo *v32; // [rsp+28h] [rbp-60h]
			//   FWindFieldData v33; // [rsp+30h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D919833 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::ComputeBuffer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::FWindFieldData);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricWindField>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricWindField>::get_Item);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&off_18D523B40);
			//     byte_18D919833 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4387, 0LL) )
			//   {
			//     windFieldList = this.fields.windFieldList;
			//     if ( !windFieldList )
			//       goto LABEL_35;
			//     size = windFieldList.fields._size;
			//     sub_180002C70(TypeInfo::System::Math);
			//     v7 = 1;
			//     if ( size >= 1 )
			//       v7 = size;
			//     if ( !this.fields._windFieldBuffer
			//       || UnityEngine::ComputeBuffer::get_count(this.fields._windFieldBuffer, 0LL) != v7 )
			//     {
			//       windFieldBuffer = this.fields._windFieldBuffer;
			//       if ( windFieldBuffer )
			//         UnityEngine::ComputeBuffer::Dispose(windFieldBuffer, 0LL);
			//       v11 = (ComputeBuffer *)sub_180004920(TypeInfo::UnityEngine::ComputeBuffer);
			//       v12 = v11;
			//       if ( !v11 )
			//         goto LABEL_35;
			//       UnityEngine::ComputeBuffer::ComputeBuffer(v11, v7, 80, ComputeBufferType__Enum_Constant, 0LL);
			//       this.fields._windFieldBuffer = v12;
			//       sub_1800054D0(
			//         (VolumetricRenderer_VolumetricRenderItem *)&this.fields._windFieldBuffer,
			//         v13,
			//         v14,
			//         v15,
			//         v31,
			//         v32,
			//         SLODWORD(v33.Param0.x),
			//         SLODWORD(v33.Param0.z),
			//         v33.Param1.x,
			//         SLODWORD(v33.Param1.z),
			//         SLOBYTE(v33.Param2.x),
			//         SLOBYTE(v33.Param2.z),
			//         *(MethodInfo **)&v33.Param3.x);
			//       v4 = this.fields._windFieldBuffer;
			//       if ( !v4 )
			//         goto LABEL_35;
			//       UnityEngine::ComputeBuffer::SetName(v4, (String *)"windFieldBuffer", 0LL);
			//     }
			//     windFieldDataList = this.fields.windFieldDataList;
			//     if ( windFieldDataList )
			//     {
			//       if ( windFieldDataList.max_length.size != v7 )
			//       {
			//         this.fields.windFieldDataList = (FWindFieldData__Array *)il2cpp_array_new_specific_0(
			//                                                                     TypeInfo::HG::Rendering::Runtime::FWindFieldData,
			//                                                                     v7,
			//                                                                     v8,
			//                                                                     v9);
			//         sub_1800054D0(
			//           (VolumetricRenderer_VolumetricRenderItem *)&this.fields.windFieldDataList,
			//           v17,
			//           v18,
			//           v19,
			//           v30,
			//           v32,
			//           SLODWORD(v33.Param0.x),
			//           SLODWORD(v33.Param0.z),
			//           v33.Param1.x,
			//           SLODWORD(v33.Param1.z),
			//           SLOBYTE(v33.Param2.x),
			//           SLOBYTE(v33.Param2.z),
			//           *(MethodInfo **)&v33.Param3.x);
			//       }
			//       v20 = 0;
			//       while ( 1 )
			//       {
			//         v21 = this.fields.windFieldList;
			//         if ( !v21 )
			//           goto LABEL_35;
			//         v22 = this.fields.windFieldDataList;
			//         if ( v20 >= v21.fields._size )
			//           break;
			//         Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                  (List_1_System_Object_ *)this.fields.windFieldList,
			//                  v20,
			//                  MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::IVolumetricWindField>::get_Item);
			//         if ( !Item )
			//           goto LABEL_35;
			//         if ( !byte_18D919862 )
			//         {
			//           sub_18003C530(&TypeInfo::HG::Rendering::Runtime::IVolumetricWindField);
			//           byte_18D919862 = 1;
			//         }
			//         if ( *(_DWORD *)&Item.klass._1.method_count == 3220 )
			//         {
			//           HG::Rendering::Runtime::VolumetricWindFieldNode::GetWindFieldData(&v33, (VolumetricWindFieldNode *)Item, 0LL);
			//         }
			//         else if ( *(_DWORD *)&Item.klass._1.method_count == 3221 )
			//         {
			//           HG::Rendering::Runtime::VolumetricWindField::GetWindFieldData(&v33, (VolumetricWindField *)Item, 0LL);
			//         }
			//         else
			//         {
			//           sub_180833CCC(&v33, (unsigned int)(*(_DWORD *)&Item.klass._1.method_count - 3220), v23, Item);
			//         }
			//         if ( !v22 )
			//           goto LABEL_35;
			//         if ( (unsigned int)v20 >= v22.max_length.size )
			//           sub_180070270(v4, v3);
			//         Param1 = v33.Param1;
			//         v4 = (ComputeBuffer *)(10LL * v20++);
			//         *(Vector4 *)((char *)&v22.vector[0].Param0 + 8 * (_QWORD)v4) = v33.Param0;
			//         Param2 = v33.Param2;
			//         *(Vector4 *)((char *)&v22.vector[0].Param1 + 8 * (_QWORD)v4) = Param1;
			//         Param3 = v33.Param3;
			//         *(Vector4 *)((char *)&v22.vector[0].Param2 + 8 * (_QWORD)v4) = Param2;
			//         Param4 = v33.Param4;
			//         *(Vector4 *)((char *)&v22.vector[0].Param3 + 8 * (_QWORD)v4) = Param3;
			//         *(Vector4 *)((char *)&v22.vector[0].Param4 + 8 * (_QWORD)v4) = Param4;
			//       }
			//       v4 = this.fields._windFieldBuffer;
			//       if ( v4 )
			//       {
			//         UnityEngine::ComputeBuffer::SetData(v4, (Array *)this.fields.windFieldDataList, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_35:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4387, 0LL);
			//   if ( !Patch )
			//     goto LABEL_35;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private List<IVolumetricWindField> windFieldList;

		private FWindFieldData[] windFieldDataList;

		public ComputeBuffer _windFieldBuffer;

		public ComputeBuffer _defaultWindFieldBuffer;
	}
}
