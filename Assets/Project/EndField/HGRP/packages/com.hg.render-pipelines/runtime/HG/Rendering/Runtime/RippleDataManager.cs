using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class RippleDataManager
	{
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00002608 File Offset: 0x00000808
		public int Count
		{
			get
			{
				// // Int32 get_Count()
				// int32_t HG::Rendering::Runtime::RippleDataManager::get_Count(RippleDataManager *this, MethodInfo *method)
				// {
				//   List_1_HG_Rendering_Runtime_InputRippleData_ *list; // rax
				// 
				//   if ( !byte_18D919842 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Count);
				//     byte_18D919842 = 1;
				//   }
				//   list = this.fields._list;
				//   if ( !list )
				//     sub_180B536AC(this, method);
				//   return list.fields._size;
				// }
				// 
				return 0;
			}
		}

		public RippleDataManager([MetadataOffset(Offset = "0x01F92168")] int capacity = 8)
		{
		}

		public void Reset()
		{
			// // Void Reset()
			// void HG::Rendering::Runtime::RippleDataManager::Reset(RippleDataManager *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   List_1_HG_Rendering_Runtime_InputRippleData_ *list; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDBE6 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::Clear);
			//     byte_18D8EDBE6 = 1;
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
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_11;
			//   if ( wrapperArray.max_length.size <= 1951 )
			//     goto LABEL_9;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_11;
			//   if ( LODWORD(v3._0.namespaze) <= 0x79F )
			//     sub_180070270(v3, wrapperArray);
			//   if ( !*(_QWORD *)&v3[41]._1.cctor_finished_or_no_cctor )
			//   {
			// LABEL_9:
			//     list = this.fields._list;
			//     if ( list )
			//     {
			//       ++list.fields._version;
			//       list.fields._size = 0;
			//       this.fields._minIndex = -1;
			//       return;
			//     }
			// LABEL_11:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1951, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void Add(InputRippleData newData)
		{
			// // Void Add(InputRippleData)
			// void HG::Rendering::Runtime::RippleDataManager::Add(
			//         RippleDataManager *this,
			//         InputRippleData *newData,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   List_1_HG_Rendering_Runtime_InputRippleData_ *list; // rbx
			//   int32_t size; // ebx
			//   int32_t Length; // eax
			//   float priority; // eax
			//   __int128 v11; // xmm0
			//   float v12; // eax
			//   int32_t minIndex; // edx
			//   float v14; // eax
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm0
			//   SpatialPortalManager_FQueuedPortalObstructedData v17; // [rsp+20h] [rbp-40h] BYREF
			//   InputRippleData v18; // [rsp+40h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D91983D )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Capacity);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::set_Item);
			//     byte_18D91983D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1953, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1953, 0LL);
			//     if ( !Patch )
			//       goto LABEL_13;
			//     v16 = *(_OWORD *)&newData.positionXZ.x;
			//     v18.priority = newData.priority;
			//     *(_OWORD *)&v18.positionXZ.x = v16;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_758(Patch, (Object *)this, &v18, 0LL);
			//   }
			//   else
			//   {
			//     list = this.fields._list;
			//     if ( !list )
			//       goto LABEL_13;
			//     size = list.fields._size;
			//     Length = System::Threading::SparselyPopulatedArrayFragment<System::Object>::get_Length(
			//                (SparselyPopulatedArrayFragment_1_System_Object_ *)this.fields._list,
			//                MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Capacity);
			//     Patch = (ILFixDynamicMethodWrapper_2 *)this.fields._list;
			//     if ( size >= Length )
			//     {
			//       if ( Patch )
			//       {
			//         System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
			//           &v17,
			//           (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this.fields._list,
			//           this.fields._minIndex,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item);
			//         v18.priority = v17.fadeTime;
			//         priority = newData.priority;
			//         *(_OWORD *)&v18.positionXZ.x = *(_OWORD *)&v17.position.x;
			//         v11 = *(_OWORD *)&newData.positionXZ.x;
			//         v17.fadeTime = priority;
			//         *(_OWORD *)&v17.position.x = v11;
			//         if ( !HG::Rendering::Runtime::RippleDataManager::IsHigherPriority(this, (InputRippleData *)&v17, &v18, 0LL) )
			//           return;
			//         Patch = (ILFixDynamicMethodWrapper_2 *)this.fields._list;
			//         if ( Patch )
			//         {
			//           v12 = newData.priority;
			//           minIndex = this.fields._minIndex;
			//           *(_OWORD *)&v18.positionXZ.x = *(_OWORD *)&newData.positionXZ.x;
			//           v18.priority = v12;
			//           System::Collections::Generic::List<UnityEngine::Experimental::Rendering::ProbeBrickIndex::ReservedBrick>::set_Item(
			//             (List_1_UnityEngine_Experimental_Rendering_ProbeBrickIndex_ReservedBrick_ *)Patch,
			//             minIndex,
			//             (ProbeBrickIndex_ReservedBrick *)&v18,
			//             MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::set_Item);
			//           HG::Rendering::Runtime::RippleDataManager::FindMinIndex(this, 0LL);
			//           return;
			//         }
			//       }
			// LABEL_13:
			//       sub_180B536AC(Patch, v5);
			//     }
			//     if ( !Patch )
			//       goto LABEL_13;
			//     v14 = newData.priority;
			//     *(_OWORD *)&v18.positionXZ.x = *(_OWORD *)&newData.positionXZ.x;
			//     v18.priority = v14;
			//     sub_180409C3C(
			//       Patch,
			//       &v18,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::Add);
			//     v15 = *(_OWORD *)&newData.positionXZ.x;
			//     v18.priority = newData.priority;
			//     *(_OWORD *)&v18.positionXZ.x = v15;
			//     HG::Rendering::Runtime::RippleDataManager::UpdateMinIndexAfterAdd(this, &v18, 0LL);
			//   }
			// }
			// 
		}

		private void UpdateMinIndexAfterAdd(InputRippleData newData)
		{
			// // Void UpdateMinIndexAfterAdd(InputRippleData)
			// void HG::Rendering::Runtime::RippleDataManager::UpdateMinIndexAfterAdd(
			//         RippleDataManager *this,
			//         InputRippleData *newData,
			//         MethodInfo *method)
			// {
			//   List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *list; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float priority; // eax
			//   __int128 v8; // xmm0
			//   List_1_HG_Rendering_Runtime_InputRippleData_ *v9; // rax
			//   __int128 v10; // xmm0
			//   SpatialPortalManager_FQueuedPortalObstructedData v11; // [rsp+20h] [rbp-40h] BYREF
			//   InputRippleData v12; // [rsp+40h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D91983E )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item);
			//     byte_18D91983E = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1954, 0LL) )
			//   {
			//     if ( this.fields._minIndex != -1 )
			//     {
			//       list = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this.fields._list;
			//       if ( !list )
			//         goto LABEL_10;
			//       System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
			//         &v11,
			//         list,
			//         this.fields._minIndex,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item);
			//       v12.priority = v11.fadeTime;
			//       priority = newData.priority;
			//       *(_OWORD *)&v12.positionXZ.x = *(_OWORD *)&v11.position.x;
			//       v8 = *(_OWORD *)&newData.positionXZ.x;
			//       v11.fadeTime = priority;
			//       *(_OWORD *)&v11.position.x = v8;
			//       if ( !HG::Rendering::Runtime::RippleDataManager::IsLowerPriority(this, (InputRippleData *)&v11, &v12, 0LL) )
			//         return;
			//     }
			//     v9 = this.fields._list;
			//     if ( v9 )
			//     {
			//       this.fields._minIndex = v9.fields._size - 1;
			//       return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(Patch, list);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1954, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   v10 = *(_OWORD *)&newData.positionXZ.x;
			//   v12.priority = newData.priority;
			//   *(_OWORD *)&v12.positionXZ.x = v10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_758(Patch, (Object *)this, &v12, 0LL);
			// }
			// 
		}

		private void FindMinIndex()
		{
			// // Void FindMinIndex()
			// void HG::Rendering::Runtime::RippleDataManager::FindMinIndex(RippleDataManager *this, MethodInfo *method)
			// {
			//   List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *v3; // rdx
			//   __int64 v4; // rcx
			//   int32_t i; // edi
			//   List_1_HG_Rendering_Runtime_InputRippleData_ *list; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   SpatialPortalManager_FQueuedPortalObstructedData v8; // [rsp+20h] [rbp-60h] BYREF
			//   SpatialPortalManager_FQueuedPortalObstructedData v9; // [rsp+40h] [rbp-40h] BYREF
			//   SpatialPortalManager_FQueuedPortalObstructedData v10; // [rsp+60h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D91983F )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item);
			//     byte_18D91983F = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1957, 0LL) )
			//   {
			//     this.fields._minIndex = 0;
			//     for ( i = 1; ; ++i )
			//     {
			//       list = this.fields._list;
			//       if ( !list )
			//         break;
			//       if ( i >= list.fields._size )
			//         return;
			//       System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
			//         &v9,
			//         (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this.fields._list,
			//         i,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item);
			//       v3 = (List_1_Beyond_Gameplay_Audio_SpatialPortalManager_FQueuedPortalObstructedData_ *)this.fields._list;
			//       if ( !v3 )
			//         break;
			//       System::Collections::Generic::List<Beyond::Gameplay::Audio::SpatialPortalManager::FQueuedPortalObstructedData>::get_Item(
			//         &v8,
			//         v3,
			//         this.fields._minIndex,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::get_Item);
			//       v10 = v8;
			//       v8 = v9;
			//       if ( HG::Rendering::Runtime::RippleDataManager::IsLowerPriority(
			//              this,
			//              (InputRippleData *)&v8,
			//              (InputRippleData *)&v10,
			//              0LL) )
			//       {
			//         this.fields._minIndex = i;
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1957, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private bool IsHigherPriority(InputRippleData a, InputRippleData b)
		{
			// // Boolean IsHigherPriority(InputRippleData, InputRippleData)
			// bool HG::Rendering::Runtime::RippleDataManager::IsHigherPriority(
			//         RippleDataManager *this,
			//         InputRippleData *a,
			//         InputRippleData *b,
			//         MethodInfo *method)
			// {
			//   float v7; // xmm1_4
			//   __int64 v9; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float priority; // eax
			//   __int128 v12; // xmm0
			//   float v13; // eax
			//   InputRippleData v14; // [rsp+30h] [rbp-40h] BYREF
			//   InputRippleData v15; // [rsp+50h] [rbp-20h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1956, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1956, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v9);
			//     priority = b.priority;
			//     *(_OWORD *)&v14.positionXZ.x = *(_OWORD *)&b.positionXZ.x;
			//     v12 = *(_OWORD *)&a.positionXZ.x;
			//     v14.priority = priority;
			//     v13 = a.priority;
			//     *(_OWORD *)&v15.positionXZ.x = v12;
			//     v15.priority = v13;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_757(Patch, (Object *)this, &v15, &v14, 0LL);
			//   }
			//   else
			//   {
			//     v7 = a.priority;
			//     return v7 > b.priority || v7 == b.priority && b.distanceXZ > a.distanceXZ;
			//   }
			// }
			// 
			return default(bool);
		}

		private bool IsLowerPriority(InputRippleData a, InputRippleData b)
		{
			// // Boolean IsLowerPriority(InputRippleData, InputRippleData)
			// bool HG::Rendering::Runtime::RippleDataManager::IsLowerPriority(
			//         RippleDataManager *this,
			//         InputRippleData *a,
			//         InputRippleData *b,
			//         MethodInfo *method)
			// {
			//   __int64 v8; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float priority; // eax
			//   __int128 v11; // xmm0
			//   float v12; // eax
			//   InputRippleData v13; // [rsp+30h] [rbp-40h] BYREF
			//   InputRippleData v14; // [rsp+50h] [rbp-20h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1955, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1955, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v8);
			//     priority = b.priority;
			//     *(_OWORD *)&v13.positionXZ.x = *(_OWORD *)&b.positionXZ.x;
			//     v11 = *(_OWORD *)&a.positionXZ.x;
			//     v13.priority = priority;
			//     v12 = a.priority;
			//     *(_OWORD *)&v14.positionXZ.x = v11;
			//     v14.priority = v12;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_757(Patch, (Object *)this, &v14, &v13, 0LL);
			//   }
			//   else
			//   {
			//     return b.priority > a.priority || a.priority == b.priority && a.distanceXZ > b.distanceXZ;
			//   }
			// }
			// 
			return default(bool);
		}

		public InputRippleData[] ToArray()
		{
			// // InputRippleData[] ToArray()
			// InputRippleData__Array *HG::Rendering::Runtime::RippleDataManager::ToArray(RippleDataManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *list; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919840 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::ToArray);
			//     byte_18D919840 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4684, 0LL) )
			//   {
			//     list = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this.fields._list;
			//     if ( list )
			//       return (InputRippleData__Array *)System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::ToArray(
			//                                          list,
			//                                          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::ToArray);
			// LABEL_7:
			//     sub_180B536AC(list, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4684, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public List<InputRippleData> ToList()
		{
			// // List`1[HG.Rendering.Runtime.InputRippleData] ToList()
			// List_1_HG_Rendering_Runtime_InputRippleData_ *HG::Rendering::Runtime::RippleDataManager::ToList(
			//         RippleDataManager *this,
			//         MethodInfo *method)
			// {
			//   List_1_HG_Rendering_Runtime_InputRippleData_ *list; // rdi
			//   List_1_HG_Rendering_Runtime_InputRippleData_ *v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   List_1_HG_Rendering_Runtime_InputRippleData_ *v7; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919841 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>);
			//     byte_18D919841 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4685, 0LL) )
			//   {
			//     list = this.fields._list;
			//     v4 = (List_1_HG_Rendering_Runtime_InputRippleData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>);
			//     v7 = v4;
			//     if ( v4 )
			//     {
			//       System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::List(
			//         v4,
			//         (IEnumerable_1_HG_Rendering_Runtime_InputRippleData_ *)list,
			//         MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::InputRippleData>::List);
			//       return v7;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4685, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1346(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public void UpdateWaterState()
		{
			// // Void UpdateWaterState()
			// void HG::Rendering::Runtime::RippleDataManager::UpdateWaterState(RippleDataManager *this, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGManagerContext *currentManagerContext; // rax
			//   HGWaterManager *waterManager_k__BackingField; // rax
			//   bool m_isWaitingToDisable; // cl
			//   HGManagerContext *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGManagerContext *v10; // rax
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
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_17;
			//   if ( wrapperArray.max_length.size > 1958 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( !v3 )
			//       goto LABEL_17;
			//     if ( LODWORD(v3._0.namespaze) <= 0x7A6 )
			//       sub_180070270(v3, wrapperArray);
			//     if ( *(_QWORD *)&v3[41]._1.token )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1958, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//         return;
			//       }
			//       goto LABEL_17;
			//     }
			//   }
			//   currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//   if ( !currentManagerContext )
			//     goto LABEL_17;
			//   waterManager_k__BackingField = currentManagerContext.fields._waterManager_k__BackingField;
			//   if ( !waterManager_k__BackingField )
			//     goto LABEL_17;
			//   m_isWaitingToDisable = this.fields.m_isWaitingToDisable;
			//   if ( !waterManager_k__BackingField.fields.m_isRippleInputEmpty )
			//   {
			//     if ( m_isWaitingToDisable )
			//     {
			//       this.fields.m_isWaitingToDisable = 0;
			//       this.fields.m_emptyStartTime = -1.0;
			//     }
			//     v10 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( v10 )
			//     {
			//       v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v10.fields._waterManager_k__BackingField;
			//       if ( v3 )
			//       {
			//         HG::Rendering::Runtime::HGWaterManager::SetShouldRenderRippleState((HGWaterManager *)v3, 1, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_17:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			//   if ( !m_isWaitingToDisable )
			//   {
			//     this.fields.m_isWaitingToDisable = 1;
			//     this.fields.m_emptyStartTime = UnityEngine::Time::get_time(0LL);
			//     return;
			//   }
			//   if ( (float)(UnityEngine::Time::get_time(0LL) - this.fields.m_emptyStartTime) >= 10.0 )
			//   {
			//     v8 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
			//     if ( v8 )
			//     {
			//       v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v8.fields._waterManager_k__BackingField;
			//       if ( v3 )
			//       {
			//         HG::Rendering::Runtime::HGWaterManager::SetShouldRenderRippleState((HGWaterManager *)v3, 0, 0LL);
			//         this.fields.m_isWaitingToDisable = 0;
			//         return;
			//       }
			//     }
			//     goto LABEL_17;
			//   }
			// }
			// 
		}

		public List<InputRippleData> _list;

		private int _minIndex;

		private Coroutine m_leaveWaterCoroutine;

		private const float LEAVE_WATER_WAIT_TIME = 10f;

		private float m_emptyStartTime;

		private bool m_isWaitingToDisable;
	}
}
