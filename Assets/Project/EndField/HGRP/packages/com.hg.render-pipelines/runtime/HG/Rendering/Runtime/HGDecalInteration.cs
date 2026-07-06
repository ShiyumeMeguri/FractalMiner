using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGDecalInteration
	{
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x000025D8 File Offset: 0x000007D8
		public static bool enableMobileInteraction
		{
			get
			{
				// // Boolean get_ring()
				// bool Beyond::Gameplay::Factory::WireRendererInfoCollection<Beyond::Gameplay::Factory::WireRendererInfo>::get_ring(
				//         WireRendererInfoCollection_1_WireRendererInfo_ *this,
				//         MethodInfo *method)
				// {
				//   return 0;
				// }
				// 
				return default(bool);
			}
		}

		public HGDecalInteration()
		{
		}

		public void UpdateSettingAsset(HGInteractionSettingAsset _settingAsset)
		{
		}

		public void Release()
		{
			// // Void Release()
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGDecalInteration::Release(HGDecalInteration *this, MethodInfo *method)
			// {
			//   HGDecalInteration *v2; // rbx
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   Dictionary_2_System_Object_System_Object_ *busyChains; // rdx
			//   Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *freeChains; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   _BYTE v10[32]; // [rsp+0h] [rbp-A8h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v11; // [rsp+20h] [rbp-88h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v12; // [rsp+48h] [rbp-60h] BYREF
			//   List_1_T_Enumerator_System_Object_ v13; // [rsp+70h] [rbp-38h] BYREF
			//   Il2CppExceptionWrapper *v14; // [rsp+88h] [rbp-20h] BYREF
			//   Il2CppExceptionWrapper *v15; // [rsp+90h] [rbp-18h] BYREF
			// 
			//   v2 = this;
			//   if ( !byte_18D919E04 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionChain>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionChain>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionChain>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::HGInteractionChain>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionChain>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionChain>::GetEnumerator);
			//     byte_18D919E04 = 1;
			//   }
			//   memset(&v12, 0, sizeof(v12));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1500, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1500, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v2.fields.freeChains )
			//       sub_180B536AC(v4, v3);
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       (List_1_T_Enumerator_System_Object_ *)&v11,
			//       (List_1_System_Object_ *)v2.fields.freeChains,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionChain>::GetEnumerator);
			//     *(_OWORD *)&v13._list = *(_OWORD *)&v11._dictionary;
			//     v13._current = *(Object **)&v11._current.key;
			//     v11._dictionary = 0LL;
			//     *(_QWORD *)&v11._version = &v13;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                 &v13,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionChain>::MoveNext) )
			//       {
			//         if ( !v13._current )
			//           sub_1802DC2C8(0LL, busyChains);
			//         HG::Rendering::Runtime::HGInteractionChain::Reset((HGInteractionChain *)v13._current, 0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v14 )
			//     {
			//       busyChains = (Dictionary_2_System_Object_System_Object_ *)v10;
			//       v11._dictionary = (Dictionary_2_System_Int32Enum_System_Object_ *)v14.ex;
			//       if ( v11._dictionary )
			//         sub_18000F780(v11._dictionary);
			//       v2 = this;
			//     }
			//     freeChains = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)v2.fields.freeChains;
			//     if ( !freeChains )
			//       goto LABEL_28;
			//     sub_1823B99D0(
			//       freeChains,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionChain>::Clear);
			//     busyChains = (Dictionary_2_System_Object_System_Object_ *)v2.fields.busyChains;
			//     if ( !busyChains )
			//       goto LABEL_28;
			//     System::Collections::Generic::Dictionary<System::Object,System::Object>::GetEnumerator(
			//       (Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *)&v11,
			//       busyChains,
			//       MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::GetEnumerator);
			//     v12 = v11;
			//     v11._dictionary = 0LL;
			//     *(_QWORD *)&v11._version = &v12;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
			//                 &v12,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::MoveNext) )
			//       {
			//         if ( !v12._current.value )
			//           sub_1802DC2C8(0LL, busyChains);
			//         HG::Rendering::Runtime::HGInteractionChain::Reset((HGInteractionChain *)v12._current.value, 0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v15 )
			//     {
			//       busyChains = (Dictionary_2_System_Object_System_Object_ *)v10;
			//       v11._dictionary = (Dictionary_2_System_Int32Enum_System_Object_ *)v15.ex;
			//       if ( v11._dictionary )
			//         sub_18000F780(v11._dictionary);
			//       v2 = this;
			//     }
			//     freeChains = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)v2.fields.busyChains;
			//     if ( !freeChains )
			// LABEL_28:
			//       sub_1802DC2C8(freeChains, busyChains);
			//     System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RegionMapVoxelInfo>::Clear(
			//       freeChains,
			//       MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::Clear);
			//   }
			// }
			// 
		}

		private HGInteractionChain GetFreeChain()
		{
			// // HGInteractionChain GetFreeChain()
			// // Hidden C++ exception states: #wind=3 #try_helpers=1
			// HGInteractionChain *HG::Rendering::Runtime::HGDecalInteration::GetFreeChain(
			//         HGDecalInteration *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Object *current; // rsi
			//   List_1_System_Object_ *freeChains; // rcx
			//   HGInteractionSettingAsset *settingAsset; // r14
			//   struct HGInteractionChain__Class *element_class; // rdi
			//   __int64 instance_size; // rcx
			//   __int64 v12; // rdx
			//   struct HGInteractionChain__Class **v13; // rax
			//   __int64 v14; // rdx
			//   char *v15; // rcx
			//   __int64 v16; // r8
			//   char *v17; // rax
			//   unsigned __int64 v18; // r8
			//   __int64 v19; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   List_1_T_Enumerator_System_Object_ v26; // [rsp+38h] [rbp-50h] BYREF
			//   List_1_T_Enumerator_System_Object_ v27; // [rsp+50h] [rbp-38h] BYREF
			//   __int64 *v28; // [rsp+A0h] [rbp+18h] BYREF
			//   char v29; // [rsp+A8h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919E05 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionChain>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionChain>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionChain>::get_Current);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGInteractionChain);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionChain>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionChain>::Remove);
			//     byte_18D919E05 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1501, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1501, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v25, v24);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_571(Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     if ( !this.fields.freeChains )
			//       sub_180B536AC(v4, v3);
			//     System::Collections::Generic::List<System::Object>::GetEnumerator(
			//       &v26,
			//       (List_1_System_Object_ *)this.fields.freeChains,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionChain>::GetEnumerator);
			//     v27 = v26;
			//     v26._list = 0LL;
			//     *(_QWORD *)&v26._index = &v27;
			//     while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//               &v27,
			//               MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionChain>::MoveNext) )
			//     {
			//       current = v27._current;
			//       if ( !v27._current )
			//         sub_1802DC2C8(v6, v5);
			//       if ( LOBYTE(v27._current[1].klass) )
			//       {
			//         freeChains = (List_1_System_Object_ *)this.fields.freeChains;
			//         if ( !freeChains )
			//           sub_1802DC2C8(0LL, v5);
			//         System::Collections::Generic::List<System::Object>::Remove(
			//           freeChains,
			//           v27._current,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionChain>::Remove);
			//         return (HGInteractionChain *)current;
			//       }
			//     }
			//     settingAsset = this.fields.settingAsset;
			//     element_class = TypeInfo::HG::Rendering::Runtime::HGInteractionChain;
			//     if ( ((__int64)TypeInfo::HG::Rendering::Runtime::HGInteractionChain.vtable.Equals.methodPtr & 2) == 0 )
			//     {
			//       v28 = &qword_18CDB0B30;
			//       sub_1802924D0(&qword_18CDB0B30);
			//       sub_180060090(element_class, &v28);
			//       sub_180292530(v28);
			//     }
			//     if ( element_class._0.generic_class && ((__int64)element_class.vtable.Equals.methodPtr & 8) != 0 )
			//       element_class = (struct HGInteractionChain__Class *)element_class._0.element_class;
			//     instance_size = element_class._1.instance_size;
			//     if ( ((__int64)element_class.vtable.Equals.methodPtr & 0x20) != 0 )
			//     {
			//       if ( element_class._0.gc_desc )
			//       {
			//         v19 = sub_180005220(instance_size, element_class);
			//         _InterlockedIncrement64(&qword_18D8E51F8);
			//       }
			//       else
			//       {
			//         v19 = sub_180005D40(instance_size, element_class);
			//       }
			//       current = (Object *)v19;
			//     }
			//     else
			//     {
			//       v12 = 0LL;
			//       if ( dword_18D8E43FC == 1 )
			//         v12 = 3LL;
			//       v13 = (struct HGInteractionChain__Class **)sub_18002D3D0(instance_size, v12);
			//       current = (Object *)v13;
			//       *v13 = element_class;
			//       v13[1] = 0LL;
			//       v15 = (char *)(v13 + 2);
			//       v16 = element_class._1.instance_size;
			//       if ( element_class._1.instance_size >= 0x80 )
			//       {
			//         sub_1802F01E0(v15, 0LL, v16 - 16);
			//       }
			//       else
			//       {
			//         v17 = (char *)v13 + v16;
			//         v18 = (unsigned __int64)(v17 - v15 + 7) >> 3;
			//         if ( v15 > v17 )
			//           v18 = 0LL;
			//         if ( v18 )
			//           sub_1802F01E0(v15, 0LL, 8 * v18);
			//       }
			//       _InterlockedIncrement64(&qword_18D8E51F8);
			//     }
			//     if ( (BYTE1(element_class.vtable.Equals.methodPtr) & 2) != 0 )
			//       sub_18002E8C0((_DWORD)current, (unsigned int)sub_18007DC30, 0, (unsigned int)&v29, (__int64)&v28);
			//     if ( (dword_18D8F6F50 & 0x80u) != 0 )
			//       sub_1802DAEC4(current, element_class);
			//     il2cpp_runtime_class_init_0(element_class, v14);
			//     if ( !current )
			//       sub_1802DC2C8(v21, v20);
			//     HG::Rendering::Runtime::HGInteractionChain::HGInteractionChain((HGInteractionChain *)current, settingAsset, 0LL);
			//     return (HGInteractionChain *)current;
			//   }
			// }
			// 
			return null;
		}

		public void UpdateFromNodes(List<HGInteractionNode> nodes)
		{
			// // Void UpdateFromNodes(List`1[HG.Rendering.Runtime.HGInteractionNode])
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGDecalInteration::UpdateFromNodes(
			//         HGDecalInteration *this,
			//         List_1_HG_Rendering_Runtime_HGInteractionNode_ *nodes,
			//         MethodInfo *method)
			// {
			//   Object *v4; // rbx
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Il2CppException *v7; // rcx
			//   Dictionary_2_System_Int32_System_Object_ *monitor; // rcx
			//   __int64 v9; // rdx
			//   Object *FreeChain; // rax
			//   __int64 v11; // rdx
			//   Dictionary_2_System_Int32_System_Object_ *v12; // rcx
			//   Dictionary_2_System_Object_System_Object_ *v13; // rdx
			//   __int64 v14; // rdx
			//   KeyValuePair_2_System_Int32Enum_System_Object_ v15; // xmm6
			//   HGInteractionChain *v16; // rcx
			//   __int64 v17; // rdx
			//   HGInteractionChain *v18; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   Il2CppException *ex; // [rsp+20h] [rbp-2E8h]
			//   Il2CppException *v23; // [rsp+20h] [rbp-2E8h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v24; // [rsp+30h] [rbp-2D8h] BYREF
			//   Il2CppExceptionWrapper *v25; // [rsp+58h] [rbp-2B0h] BYREF
			//   Il2CppExceptionWrapper *v26; // [rsp+60h] [rbp-2A8h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v27; // [rsp+68h] [rbp-2A0h] BYREF
			//   List_1_T_Enumerator_HG_Rendering_Runtime_HGInteractionNode_ v28; // [rsp+90h] [rbp-278h] BYREF
			//   HGInteractionNode current; // [rsp+160h] [rbp-1A8h] BYREF
			//   List_1_T_Enumerator_HG_Rendering_Runtime_HGInteractionNode_ key; // [rsp+220h] [rbp-E8h] BYREF
			//   Object *value; // [rsp+328h] [rbp+20h] BYREF
			// 
			//   v4 = (Object *)this;
			//   if ( !byte_18D919E06 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::TryGetValue);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionNode>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionNode>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionNode>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::HGInteractionChain>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::GetEnumerator);
			//     byte_18D919E06 = 1;
			//   }
			//   sub_1802F01E0(&current, 0LL, 192LL);
			//   value = 0LL;
			//   memset(&v24, 0, sizeof(v24));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1502, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1502, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v21, v20);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_37 *)Patch, v4, (Object *)nodes, 0LL);
			//   }
			//   else
			//   {
			//     if ( !nodes )
			//       sub_180B536AC(v6, v5);
			//     System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::GetEnumerator(
			//       &key,
			//       nodes,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionNode>::GetEnumerator);
			//     v28 = key;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionNode>::MoveNext(
			//                 &v28,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::HGInteractionNode>::MoveNext) )
			//       {
			//         current = v28._current;
			//         monitor = (Dictionary_2_System_Int32_System_Object_ *)v4[1].monitor;
			//         *(_OWORD *)&key._list = *(_OWORD *)&v28._current.NodeKey;
			//         *(_OWORD *)&key._current.NodeKey = *(_OWORD *)&v28._current.localToWorldMatrix.m20;
			//         *(_OWORD *)&key._current.localToWorldMatrix.m20 = *(_OWORD *)&v28._current.localToWorldMatrix.m21;
			//         *(_OWORD *)&key._current.localToWorldMatrix.m21 = *(_OWORD *)&v28._current.localToWorldMatrix.m22;
			//         *(_OWORD *)&key._current.localToWorldMatrix.m22 = *(_OWORD *)&v28._current.localToWorldMatrix.m23;
			//         *(_OWORD *)&key._current.localToWorldMatrix.m23 = *(_OWORD *)&v28._current.prevLocalToWorldMatrix.m20;
			//         *(_OWORD *)&key._current.prevLocalToWorldMatrix.m20 = *(_OWORD *)&v28._current.prevLocalToWorldMatrix.m21;
			//         *(_OWORD *)&key._current.prevLocalToWorldMatrix.m21 = *(_OWORD *)&v28._current.prevLocalToWorldMatrix.m22;
			//         *(_OWORD *)&key._current.prevLocalToWorldMatrix.m22 = *(_OWORD *)&v28._current.prevLocalToWorldMatrix.m23;
			//         *(_OWORD *)&key._current.prevLocalToWorldMatrix.m23 = *(_OWORD *)&v28._current.length;
			//         *(_OWORD *)&key._current.length = *(_OWORD *)&v28._current.texture;
			//         *(_OWORD *)&key._current.texture = *(_OWORD *)&v28._current.heightScale;
			//         if ( !monitor )
			//           sub_1802DC2C8(0LL, &key._current.prevLocalToWorldMatrix.m22);
			//         if ( !System::Collections::Generic::Dictionary<int,System::Object>::TryGetValue(
			//                 monitor,
			//                 (int32_t)key._list,
			//                 &value,
			//                 MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::TryGetValue) )
			//         {
			//           FreeChain = (Object *)HG::Rendering::Runtime::HGDecalInteration::GetFreeChain((HGDecalInteration *)v4, 0LL);
			//           value = FreeChain;
			//           v12 = (Dictionary_2_System_Int32_System_Object_ *)v4[1].monitor;
			//           if ( !v12 )
			//             sub_1802DC2C8(0LL, v11);
			//           System::Collections::Generic::Dictionary<int,System::Object>::Add(
			//             v12,
			//             current.NodeKey,
			//             FreeChain,
			//             MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::Add);
			//         }
			//         if ( !value )
			//           sub_1802DC2C8(0LL, v9);
			//         HG::Rendering::Runtime::HGInteractionChain::PushNewNode((HGInteractionChain *)value, &current, 0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v25 )
			//     {
			//       ex = v25.ex;
			//       v7 = v25.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v4 = (Object *)this;
			//     }
			//     v13 = (Dictionary_2_System_Object_System_Object_ *)v4[1].monitor;
			//     if ( !v13 )
			//       sub_1802DC2C8(v7, 0LL);
			//     System::Collections::Generic::Dictionary<System::Object,System::Object>::GetEnumerator(
			//       (Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *)&v27,
			//       v13,
			//       MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::GetEnumerator);
			//     v24 = v27;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
			//                 &v24,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::MoveNext) )
			//       {
			//         v15 = v24._current;
			//         v16 = (HGInteractionChain *)_mm_srli_si128((__m128i)v24._current, 8).m128i_u64[0];
			//         if ( !v16 )
			//           sub_1802DC2C8(0LL, v14);
			//         HG::Rendering::Runtime::HGInteractionChain::UpdateChainFade(v16, 0LL);
			//         v18 = (HGInteractionChain *)_mm_srli_si128((__m128i)v15, 8).m128i_u64[0];
			//         if ( !v18 )
			//           sub_1802DC2C8(0LL, v17);
			//         HG::Rendering::Runtime::HGInteractionChain::UpdateRenderData(v18, 0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v26 )
			//     {
			//       v23 = v26.ex;
			//       if ( v23 )
			//         sub_18000F780(v23);
			//       v4 = (Object *)this;
			//     }
			//     HG::Rendering::Runtime::HGDecalInteration::UpdateChainState((HGDecalInteration *)v4, 0LL);
			//   }
			// }
			// 
		}

		private void UpdateChainState()
		{
			// // Void UpdateChainState()
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGDecalInteration::UpdateChainState(HGDecalInteration *this, MethodInfo *method)
			// {
			//   Object *v2; // rbx
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   List_1_System_Int32_ *list; // rcx
			//   KeyValuePair_2_System_Int32Enum_System_Object_ current; // xmm6
			//   int32_t frameCount; // eax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   HGInteractionChain *v10; // xmm0_8
			//   __int64 v11; // rdx
			//   List_1_System_Object_ *klass; // rcx
			//   __int64 v13; // rdx
			//   List_1_System_Int32_ *v14; // rcx
			//   List_1_System_Int32_ *v15; // rdx
			//   Dictionary_2_System_Int32_System_Object_ *monitor; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   __int64 v20; // [rsp+0h] [rbp-B8h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v21; // [rsp+20h] [rbp-98h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v22; // [rsp+48h] [rbp-70h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v23; // [rsp+60h] [rbp-58h] BYREF
			//   Il2CppExceptionWrapper *v24; // [rsp+88h] [rbp-30h] BYREF
			//   Il2CppExceptionWrapper *v25; // [rsp+90h] [rbp-28h] BYREF
			// 
			//   v2 = (Object *)this;
			//   if ( !byte_18D919E07 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::HGInteractionChain>::get_Key);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::HGInteractionChain>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInteractionChain>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     byte_18D919E07 = 1;
			//   }
			//   memset(&v23, 0, sizeof(v23));
			//   memset(&v22, 0, sizeof(v22));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1503, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1503, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v19, v18);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, v2, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v2[1].monitor )
			//       sub_180B536AC(v4, v3);
			//     v23 = *(Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *)sub_180835CFC(&v21, v2[1].monitor);
			//     v21._list = 0LL;
			//     *(_QWORD *)&v21._index = &v23;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
			//                 &v23,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::MoveNext) )
			//       {
			//         current = v23._current;
			//         frameCount = UnityEngine::Time::get_frameCount(0LL);
			//         v10 = (HGInteractionChain *)_mm_srli_si128((__m128i)current, 8).m128i_u64[0];
			//         if ( !v10 )
			//           sub_1802DC2C8(v9, v8);
			//         if ( frameCount > v10.fields.LastAccessFrame + 3 )
			//         {
			//           HG::Rendering::Runtime::HGInteractionChain::Reset(v10, 0LL);
			//           klass = (List_1_System_Object_ *)v2[1].klass;
			//           if ( !klass )
			//             sub_1802DC2C8(0LL, v11);
			//           sub_1822AD140(klass, (Object *)v10);
			//           v14 = (List_1_System_Int32_ *)v2[2].klass;
			//           if ( !v14 )
			//             sub_1802DC2C8(0LL, v13);
			//           sub_18231EF50(v14, _mm_cvtsi128_si32((__m128i)current));
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v24 )
			//     {
			//       v21._list = (List_1_System_UInt32_ *)v24.ex;
			//       list = (List_1_System_Int32_ *)v21._list;
			//       if ( v21._list )
			//         sub_18000F780(v21._list);
			//       v2 = (Object *)this;
			//     }
			//     v15 = (List_1_System_Int32_ *)v2[2].klass;
			//     if ( !v15 )
			//       goto LABEL_32;
			//     System::Collections::Generic::List<int>::GetEnumerator(
			//       (List_1_T_Enumerator_System_Int32_ *)&v21,
			//       v15,
			//       MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     v22 = v21;
			//     v21._list = 0LL;
			//     *(_QWORD *)&v21._index = &v22;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                 &v22,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//       {
			//         monitor = (Dictionary_2_System_Int32_System_Object_ *)v2[1].monitor;
			//         if ( !monitor )
			//           sub_1802DC2C8(0LL, v15);
			//         System::Collections::Generic::Dictionary<int,System::Object>::Remove(
			//           monitor,
			//           v22._current,
			//           MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::Remove);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v25 )
			//     {
			//       v15 = (List_1_System_Int32_ *)&v20;
			//       v21._list = (List_1_System_UInt32_ *)v25.ex;
			//       if ( v21._list )
			//         sub_18000F780(v21._list);
			//       v2 = (Object *)this;
			//     }
			//     list = (List_1_System_Int32_ *)v2[2].klass;
			//     if ( !list )
			// LABEL_32:
			//       sub_1802DC2C8(list, v15);
			//     ++list.fields._version;
			//     list.fields._size = 0;
			//   }
			// }
			// 
		}

		public void DrawAllChains(CommandBuffer cmd, Material material)
		{
			// // Void DrawAllChains(CommandBuffer, Material)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGDecalInteration::DrawAllChains(
			//         HGDecalInteration *this,
			//         CommandBuffer *cmd,
			//         Material *material,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __int64 v11; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v13; // rdx
			//   __int64 v14; // rcx
			//   Il2CppExceptionWrapper *v15; // [rsp+30h] [rbp-78h] BYREF
			//   Il2CppException *ex; // [rsp+38h] [rbp-70h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *v17; // [rsp+40h] [rbp-68h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v18; // [rsp+48h] [rbp-60h] BYREF
			//   _BYTE v19[48]; // [rsp+70h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919E08 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::HGInteractionChain>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::HGInteractionChain>::get_Value);
			//     byte_18D919E08 = 1;
			//   }
			//   memset(&v18, 0, sizeof(v18));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1504, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1504, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, v13);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//       (ILFixDynamicMethodWrapper_28 *)Patch,
			//       (Object *)this,
			//       (Object *)cmd,
			//       (Object *)material,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !material )
			//       sub_180B536AC(v8, v7);
			//     UnityEngine::Material::set_enableInstancing(material, 1, 0LL);
			//     if ( !this.fields.busyChains )
			//       sub_180B536AC(v10, v9);
			//     v18 = *(Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ *)sub_180835CFC(
			//                                                                                     v19,
			//                                                                                     this.fields.busyChains);
			//     ex = 0LL;
			//     v17 = &v18;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
			//                 &v18,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::HGInteractionChain>::MoveNext) )
			//       {
			//         if ( !v18._current.value )
			//           sub_1802DC2C8(0LL, v11);
			//         HG::Rendering::Runtime::HGInteractionChain::DrawChainNodes(
			//           (HGInteractionChain *)v18._current.value,
			//           cmd,
			//           material,
			//           0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v15 )
			//     {
			//       ex = v15.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//     }
			//   }
			// }
			// 
		}

		public HGDecalInteractionParametersV2 BuildNativeSettingParameters()
		{
			// // HGDecalInteractionParametersV2 BuildNativeSettingParameters()
			// HGDecalInteractionParametersV2 *HG::Rendering::Runtime::HGDecalInteration::BuildNativeSettingParameters(
			//         HGDecalInteractionParametersV2 *__return_ptr retstr,
			//         HGDecalInteration *this,
			//         MethodInfo *method)
			// {
			//   _QWORD **v5; // rcx
			//   __int64 v6; // rdx
			//   HGInteractionSettingAsset *settingAsset; // rdi
			//   HGInteractionSettingAsset *v8; // rax
			//   void *m_CachedPtr; // rdi
			//   Material *decalInteractionMaterial; // rbp
			//   HGInteractionSettingAsset *v11; // rax
			//   Material *v12; // rdi
			//   HGInteractionSettingAsset *v13; // rax
			//   float timeFadeSpeed; // xmm2_4
			//   __int128 v15; // xmm1
			//   __int128 v16; // xmm0
			//   __m128 v17; // xmm1
			//   __m128 v18; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGDecalInteractionParametersV2 *v21; // rax
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   HGDecalInteractionParametersV2 v24; // [rsp+20h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D8EDCCE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDCCE = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v6 = *v5[23];
			//   if ( !v6 )
			//     goto LABEL_42;
			//   if ( *(int *)(v6 + 24) > 1505 )
			//   {
			//     if ( !*((_DWORD *)v5 + 56) )
			//     {
			//       il2cpp_runtime_class_init_0(v5, v6);
			//       v5 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (_QWORD **)*v5[23];
			//     if ( !v5 )
			//       goto LABEL_42;
			//     if ( *((_DWORD *)v5 + 6) <= 0x5E1u )
			//       sub_180070270(v5, v6);
			//     if ( v5[1509] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1505, 0LL);
			//       if ( Patch )
			//       {
			//         v21 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_572(&v24, Patch, (Object *)this, 0LL);
			//         v22 = *(_OWORD *)&v21.m_decalNodeWidth;
			//         *(_OWORD *)&retstr.m_enableDecalInteraction = *(_OWORD *)&v21.m_enableDecalInteraction;
			//         v23 = *(_OWORD *)&v21.m_nodeDistanceThreshold;
			//         *(_OWORD *)&retstr.m_decalNodeWidth = v22;
			//         v18 = *(__m128 *)&v21.m_rotationThreshold;
			//         *(_OWORD *)&retstr.m_nodeDistanceThreshold = v23;
			//         goto LABEL_39;
			//       }
			//       goto LABEL_42;
			//     }
			//   }
			//   settingAsset = this.fields.settingAsset;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//   if ( !byte_18D8F4EFA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFA = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !settingAsset )
			//     goto LABEL_41;
			//   v5 = (_QWORD **)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//   if ( !settingAsset.fields._._.m_CachedPtr )
			//   {
			// LABEL_41:
			//     *(_OWORD *)&retstr.m_enableDecalInteraction = 0LL;
			//     *(_OWORD *)&retstr.m_decalNodeWidth = 0LL;
			//     *(_OWORD *)&retstr.m_nodeDistanceThreshold = 0LL;
			//     *(_OWORD *)&retstr.m_rotationThreshold = 0LL;
			//     return retstr;
			//   }
			//   v8 = this.fields.settingAsset;
			//   m_CachedPtr = 0LL;
			//   *(_DWORD *)(&v24.m_enableDecalInteraction + 1) = 0;
			//   *(_WORD *)(&v24.m_enableDecalInteraction + 5) = 0;
			//   *(&v24.m_enableDecalInteraction + 7) = 0;
			//   *((_DWORD *)&v24.m_timeFadeSpeed + 1) = 0;
			//   v24.m_enableDecalInteraction = 0;
			//   if ( !v8 )
			//     goto LABEL_42;
			//   decalInteractionMaterial = v8.fields.decalInteractionMaterial;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//   if ( !byte_18D8F4EAE )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAE = 1;
			//   }
			//   v5 = (_QWORD **)TypeInfo::UnityEngine::Object;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( decalInteractionMaterial )
			//   {
			//     v5 = (_QWORD **)TypeInfo::UnityEngine::Object;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v6);
			//     if ( decalInteractionMaterial.fields._.m_CachedPtr )
			//     {
			//       v11 = this.fields.settingAsset;
			//       if ( v11 )
			//       {
			//         v12 = v11.fields.decalInteractionMaterial;
			//         if ( v12 )
			//         {
			//           m_CachedPtr = v12.fields._.m_CachedPtr;
			//           goto LABEL_37;
			//         }
			//       }
			// LABEL_42:
			//       sub_180B536AC(v5, v6);
			//     }
			//   }
			// LABEL_37:
			//   v13 = this.fields.settingAsset;
			//   v24.m_decalInteractionMaterial = m_CachedPtr;
			//   if ( !v13 )
			//     goto LABEL_42;
			//   timeFadeSpeed = v13.fields.timeFadeSpeed;
			//   *(_OWORD *)&v24.m_decalNodeWidth = *(_OWORD *)&v13.fields.decalNodeWidth;
			//   v15 = *(_OWORD *)&v24.m_decalNodeWidth;
			//   *(_OWORD *)&v24.m_nodeDistanceThreshold = *(_OWORD *)&v13.fields.nodeDistanceThreshold;
			//   *(_QWORD *)&v24.m_rotationThreshold = *(_QWORD *)&v13.fields.rotationThreshold;
			//   *(_OWORD *)&retstr.m_enableDecalInteraction = *(_OWORD *)&v24.m_enableDecalInteraction;
			//   v16 = *(_OWORD *)&v24.m_nodeDistanceThreshold;
			//   *(_OWORD *)&retstr.m_decalNodeWidth = v15;
			//   v17 = _mm_shuffle_ps(*(__m128 *)&v24.m_rotationThreshold, *(__m128 *)&v24.m_rotationThreshold, 210);
			//   v17.m128_f32[0] = timeFadeSpeed;
			//   v18 = _mm_shuffle_ps(v17, v17, 201);
			//   *(_OWORD *)&retstr.m_nodeDistanceThreshold = v16;
			// LABEL_39:
			//   *(__m128 *)&retstr.m_rotationThreshold = v18;
			//   return retstr;
			// }
			// 
			return null;
		}

		private List<HGInteractionChain> freeChains;

		private Dictionary<int, HGInteractionChain> busyChains;

		private List<int> pendingFreeChains;

		private const int KEEP_BUSY_FRAMES = 3;

		private HGInteractionSettingAsset settingAsset;
	}
}
