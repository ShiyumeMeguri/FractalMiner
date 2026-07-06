using System;
using System.Collections.Generic;
using HG.Rendering.Runtime.Sludge;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class HGSludgeManager
	{
		public HGSludgeManager()
		{
			// // HGSludgeManager()
			// void HG::Rendering::Runtime::HGSludgeManager::HGSludgeManager(HGSludgeManager *this, MethodInfo *method)
			// {
			//   int32_t graphicsFormat; // eax
			//   Vector2Int textureSize; // xmm0_8
			//   Dictionary_2_System_Int32_System_Object_ *v5; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_Sludge_HGDynamicSludge_ *v8; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   HGCamera *v11; // r9
			//   int32_t m_X; // esi
			//   int32_t m_Y; // ebp
			//   AtlasMaxRect *v14; // rax
			//   AtlasMaxRect *v15; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v16; // rdx
			//   PassConstructorID__Enum__Array *v17; // r8
			//   HGCamera *v18; // r9
			//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v19; // rax
			//   List_1_System_Int32_ *v20; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v21; // rdx
			//   PassConstructorID__Enum__Array *v22; // r8
			//   HGCamera *v23; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGSludgeConfig *v25; // rax
			//   __int64 v26; // [rsp+20h] [rbp-18h] BYREF
			//   MethodInfo *v27; // [rsp+28h] [rbp-10h]
			//   MethodInfo *v28; // [rsp+60h] [rbp+28h]
			//   MethodInfo *v29; // [rsp+68h] [rbp+30h]
			// 
			//   if ( !byte_18D8EDCA1 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::AtlasMaxRect);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::Dictionary);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::List);
			//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<int>);
			//     byte_18D8EDCA1 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1349, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1349, 0LL);
			//     if ( !Patch )
			//       goto LABEL_6;
			//     v25 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_510((HGSludgeConfig *)&v26, Patch, 0LL);
			//     textureSize = v25.textureSize;
			//     graphicsFormat = v25.graphicsFormat;
			//   }
			//   else
			//   {
			//     v26 = 0x10000000100LL;
			//     graphicsFormat = 21;
			//     textureSize = (Vector2Int)0x10000000100LL;
			//   }
			//   this.fields.m_config.textureSize = textureSize;
			//   this.fields.m_config.graphicsFormat = graphicsFormat;
			//   v5 = (Dictionary_2_System_Int32_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>);
			//   v8 = (Dictionary_2_System_Int32_HG_Rendering_Runtime_Sludge_HGDynamicSludge_ *)v5;
			//   if ( !v5 )
			//     goto LABEL_6;
			//   System::Collections::Generic::Dictionary<int,System::Object>::Dictionary(
			//     v5,
			//     MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::Dictionary);
			//   this.fields.m_dynamicSludges = v8;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_dynamicSludges, v9, v10, v11, (MethodInfo *)v26, v27);
			//   m_X = this.fields.m_config.textureSize.m_X;
			//   m_Y = this.fields.m_config.textureSize.m_Y;
			//   v14 = (AtlasMaxRect *)sub_180004920(TypeInfo::HG::Rendering::Runtime::AtlasMaxRect);
			//   v15 = v14;
			//   if ( !v14
			//     || (HG::Rendering::Runtime::AtlasMaxRect::AtlasMaxRect(v14, m_X, m_Y, 0LL),
			//         this.fields.m_atlasMaxRect = v15,
			//         sub_1800054D0((HGRenderPathScene *)&this.fields.m_atlasMaxRect, v16, v17, v18, (MethodInfo *)v26, v27),
			//         v19 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>),
			//         (v20 = (List_1_System_Int32_ *)v19) == 0LL) )
			//   {
			// LABEL_6:
			//     sub_180B536AC(v7, v6);
			//   }
			//   System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
			//     v19,
			//     MethodInfo::System::Collections::Generic::List<int>::List);
			//   this.fields.m_cacheOutDateList = v20;
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_cacheOutDateList, v21, v22, v23, v28, v29);
			// }
			// 
		}

		public float GetTime()
		{
			// // Single GetTime()
			// float HG::Rendering::Runtime::HGSludgeManager::GetTime(HGSludgeManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !byte_18D919DB7 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			//     byte_18D919DB7 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1350, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1350, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_43((ILFixDynamicMethodWrapper_16 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
			//     return HG::Rendering::Runtime::HGRPTimeManager::get_gameplayTime(0LL);
			//   }
			// }
			// 
			return 0f;
		}

		public void Initialize(Mesh planeMesh)
		{
		}

		public void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::HGSludgeManager::Dispose(HGSludgeManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *m_dynamicSludges; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DB8 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::Clear);
			//     byte_18D919DB8 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1352, 0LL) )
			//   {
			//     m_dynamicSludges = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)this.fields.m_dynamicSludges;
			//     if ( m_dynamicSludges )
			//     {
			//       System::Collections::Generic::Dictionary<UnityEngine::Vector3Int,Beyond::Gameplay::RemoteFactory::RegionMapVoxelInfo>::Clear(
			//         m_dynamicSludges,
			//         MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::Clear);
			//       m_dynamicSludges = (Dictionary_2_UnityEngine_Vector3Int_Beyond_Gameplay_RemoteFactory_RegionMapVoxelInfo_ *)this.fields.m_atlasMaxRect;
			//       if ( m_dynamicSludges )
			//       {
			//         HG::Rendering::Runtime::AtlasMaxRect::Reset((AtlasMaxRect *)m_dynamicSludges, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(m_dynamicSludges, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1352, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void GameplayUpdate()
		{
			// // Void GameplayUpdate()
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGSludgeManager::GameplayUpdate(HGSludgeManager *this, MethodInfo *method)
			// {
			//   HGSludgeManager *v2; // rbx
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
			//   ILFixDynamicMethodWrapper_2__Array *v5; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_Sludge_HGDynamicSludge_ *m_dynamicSludges; // rdi
			//   List_1_System_Int32_ *m_cacheOutDateList; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   Dictionary_2_System_Object_System_Object_ *dictionary; // rcx
			//   PassConstructorID__Enum__Array *v13; // r8
			//   KeyValuePair_2_System_Int32Enum_System_Object_ current; // xmm6
			//   float *v15; // rdi
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   float Time; // xmm0_4
			//   List_1_System_Int32_ *v19; // rcx
			//   Dictionary_2_System_Object_System_Object_ *v20; // r9
			//   __int64 v21; // r9
			//   __int64 v22; // [rsp+0h] [rbp-C8h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v23; // [rsp+20h] [rbp-A8h] BYREF
			//   List_1_T_Enumerator_System_UInt32_ v24; // [rsp+48h] [rbp-80h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v25; // [rsp+60h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v26; // [rsp+88h] [rbp-40h] BYREF
			//   Il2CppExceptionWrapper *v27; // [rsp+90h] [rbp-38h] BYREF
			// 
			//   v2 = this;
			//   if ( !byte_18D8EDCA2 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::get_Key);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::GetEnumerator);
			//     byte_18D8EDCA2 = 1;
			//   }
			//   memset(&v24, 0, sizeof(v24));
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
			//     sub_180B536AC(v3, method);
			//   if ( wrapperArray.max_length.size <= 1354 )
			//     goto LABEL_16;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v5 = v3.static_fields.wrapperArray;
			//   if ( !v5 )
			//     sub_180B536AC(v3, method);
			//   if ( v5.max_length.size <= 0x54Au )
			//     sub_180070270(v3, method);
			//   if ( v5[37].vector[22] )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1354, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)v2, 0LL);
			//   }
			//   else
			//   {
			// LABEL_16:
			//     m_dynamicSludges = v2.fields.m_dynamicSludges;
			//     if ( !m_dynamicSludges )
			//       sub_180B536AC(v3, method);
			//     if ( m_dynamicSludges.fields._count != m_dynamicSludges.fields._freeCount )
			//     {
			//       m_cacheOutDateList = v2.fields.m_cacheOutDateList;
			//       if ( !m_cacheOutDateList )
			//         sub_180B536AC(v3, method);
			//       ++m_cacheOutDateList.fields._version;
			//       m_cacheOutDateList.fields._size = 0;
			//       if ( !v2.fields.m_dynamicSludges )
			//         sub_180B536AC(v3, method);
			//       System::Collections::Generic::Dictionary<System::Object,System::Object>::GetEnumerator(
			//         (Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *)&v23,
			//         (Dictionary_2_System_Object_System_Object_ *)v2.fields.m_dynamicSludges,
			//         MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::GetEnumerator);
			//       v25 = v23;
			//       v23._dictionary = 0LL;
			//       *(_QWORD *)&v23._version = &v25;
			//       try
			//       {
			//         while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
			//                   &v25,
			//                   MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::MoveNext) )
			//         {
			//           current = v25._current;
			//           v15 = (float *)_mm_srli_si128((__m128i)v25._current, 8).m128i_u64[0];
			//           Time = HG::Rendering::Runtime::HGSludgeManager::GetTime(v2, 0LL);
			//           if ( !v15 )
			//             sub_1802DC2C8(v17, v16);
			//           if ( (float)(Time - v15[32]) > (float)((float)(v15[31] + v15[30]) + 0.1) )
			//           {
			//             v19 = v2.fields.m_cacheOutDateList;
			//             if ( !v19 )
			//               sub_1802DC2C8(0LL, v16);
			//             sub_18231EF50(v19, _mm_cvtsi128_si32((__m128i)current));
			//           }
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v26 )
			//       {
			//         v11 = (HGRenderPathBase_HGRenderPathResources *)&v22;
			//         v23._dictionary = (Dictionary_2_System_Int32Enum_System_Object_ *)v26.ex;
			//         dictionary = (Dictionary_2_System_Object_System_Object_ *)v23._dictionary;
			//         if ( v23._dictionary )
			//           sub_18000F780(v23._dictionary);
			//         v2 = this;
			//       }
			//       v20 = (Dictionary_2_System_Object_System_Object_ *)v2.fields.m_cacheOutDateList;
			//       if ( !v20 )
			//         sub_1802DC2C8(dictionary, v11);
			//       *(_OWORD *)&v23._version = 0LL;
			//       v23._dictionary = (Dictionary_2_System_Int32Enum_System_Object_ *)v20;
			//       ((void (__stdcall *)(HGRenderPathScene *, HGRenderPathBase_HGRenderPathResources *, PassConstructorID__Enum__Array *, HGCamera *))sub_1800054D0)(
			//         (HGRenderPathScene *)&v23,
			//         v11,
			//         v13,
			//         (HGCamera *)v20);
			//       v23._version = 0;
			//       v23._index = *(_DWORD *)(v21 + 28);
			//       v23._current.key = 0;
			//       *(_OWORD *)&v24._list = *(_OWORD *)&v23._dictionary;
			//       *(_QWORD *)&v24._current = *(_QWORD *)&v23._current.key;
			//       v23._dictionary = 0LL;
			//       *(_QWORD *)&v23._version = &v24;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<unsigned int>::MoveNext(
			//                   &v24,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<int>::MoveNext) )
			//           HG::Rendering::Runtime::HGSludgeManager::ReleaseDynamicSludge(v2, v24._current, 0LL);
			//       }
			//       catch ( Il2CppExceptionWrapper *v27 )
			//       {
			//         v23._dictionary = (Dictionary_2_System_Int32Enum_System_Object_ *)v27.ex;
			//         if ( v23._dictionary )
			//           sub_18000F780(v23._dictionary);
			//       }
			//     }
			//   }
			// }
			// 
		}

		public Mesh GetPlaneMesh()
		{
			// // Mesh GetPlaneMesh()
			// Mesh *HG::Rendering::Runtime::HGSludgeManager::GetPlaneMesh(HGSludgeManager *this, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1363, 0LL) )
			//     return this.fields.m_planeMesh;
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1363, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_355(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}

		public bool HasActiveSludge()
		{
			// // Boolean HasActiveSludge()
			// bool HG::Rendering::Runtime::HGSludgeManager::HasActiveSludge(HGSludgeManager *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_Sludge_HGDynamicSludge_ *m_dynamicSludges; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DB9 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::get_Count);
			//     byte_18D919DB9 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1364, 0LL) )
			//   {
			//     m_dynamicSludges = this.fields.m_dynamicSludges;
			//     if ( m_dynamicSludges )
			//       return m_dynamicSludges.fields._count - m_dynamicSludges.fields._freeCount > 0;
			// LABEL_7:
			//     sub_180B536AC(m_dynamicSludges, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1364, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)this, 0LL);
			// }
			// 
			return default(bool);
		}

		public void GetActiveDynamicSludgePassData(List<HGDynamicSludgePassData> result, float lastTime)
		{
			// // Void GetActiveDynamicSludgePassData(List`1[HG.Rendering.Runtime.Sludge.HGDynamicSludgePassData], Single)
			// // Hidden C++ exception states: #wind=1
			// void HG::Rendering::Runtime::HGSludgeManager::GetActiveDynamicSludgePassData(
			//         HGSludgeManager *this,
			//         List_1_HG_Rendering_Runtime_Sludge_HGDynamicSludgePassData_ *result,
			//         float lastTime,
			//         MethodInfo *method)
			// {
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   __m128i v10; // xmm3
			//   __int128 v11; // xmm4
			//   __int128 v12; // xmm5
			//   __int128 v13; // xmm7
			//   __int128 v14; // xmm8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   Il2CppException *ex; // [rsp+30h] [rbp-188h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v19; // [rsp+40h] [rbp-178h] BYREF
			//   Il2CppExceptionWrapper *v20; // [rsp+68h] [rbp-150h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Int32Enum_System_Object_ v21; // [rsp+70h] [rbp-148h] BYREF
			//   SphericalHarmonicsL2 v22; // [rsp+A0h] [rbp-118h] BYREF
			//   _BYTE v23[80]; // [rsp+110h] [rbp-A8h] BYREF
			//   _BYTE v24[28]; // [rsp+160h] [rbp-58h]
			// 
			//   if ( !byte_18D919DBA )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::get_Value);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Sludge::HGDynamicSludgePassData>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Sludge::HGDynamicSludgePassData>::Clear);
			//     byte_18D919DBA = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1365, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1365, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, v16);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_52(
			//       (ILFixDynamicMethodWrapper_9 *)Patch,
			//       (Object *)this,
			//       (Object *)result,
			//       lastTime,
			//       0LL);
			//   }
			//   else
			//   {
			//     if ( !result )
			//       sub_180B536AC(v7, v6);
			//     ++result.fields._version;
			//     result.fields._size = 0;
			//     if ( !this.fields.m_dynamicSludges )
			//       sub_180B536AC(v7, v6);
			//     System::Collections::Generic::Dictionary<System::Object,System::Object>::GetEnumerator(
			//       (Dictionary_2_TKey_TValue_Enumerator_System_Object_System_Object_ *)&v21,
			//       (Dictionary_2_System_Object_System_Object_ *)this.fields.m_dynamicSludges,
			//       MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::GetEnumerator);
			//     v19 = v21;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Int32Enum,System::Object>::MoveNext(
			//                 &v19,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::MoveNext) )
			//       {
			//         sub_1802F01E0(v23, 0LL, 108LL);
			//         if ( !v19._current.value )
			//           sub_1802DC2C8(v9, v8);
			//         v10 = _mm_loadu_si128((const __m128i *)&v19._current.value[2].monitor);
			//         v11 = *(_OWORD *)&v19._current.value[3].monitor;
			//         v12 = *(_OWORD *)&v19._current.value[4].monitor;
			//         v13 = *(_OWORD *)&v19._current.value[5].monitor;
			//         v14 = *(_OWORD *)&v19._current.value[6].monitor;
			//         *(_QWORD *)v24 = v19._current.value[7].monitor;
			//         v24[8] = *((float *)&v19._current.value[8].klass + 1) >= lastTime;
			//         *(__m128i *)&v24[12] = _mm_loadu_si128((const __m128i *)((char *)&v19._current.value[8].klass + 4));
			//         *(__m128i *)&v22.shr0 = v10;
			//         *(_OWORD *)&v22.shr4 = v11;
			//         *(_OWORD *)&v22.shr8 = v12;
			//         *(_OWORD *)&v22.shg3 = v13;
			//         *(_OWORD *)&v22.shg7 = v14;
			//         *(_OWORD *)&v22.shb2 = *(_OWORD *)v24;
			//         *(_QWORD *)&v22.shb6 = *(_QWORD *)&v24[16];
			//         LODWORD(v22.shb8) = _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v24[12], 12));
			//         System::Collections::Generic::List<UnityEngine::Rendering::SphericalHarmonicsL2>::Add(
			//           (List_1_UnityEngine_Rendering_SphericalHarmonicsL2_ *)result,
			//           &v22,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Sludge::HGDynamicSludgePassData>::Add);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v20 )
			//     {
			//       ex = v20.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//     }
			//   }
			// }
			// 
		}

		public HGSludgeConfig GetConfig()
		{
			// // HGSludgeConfig GetConfig()
			// HGSludgeConfig *HG::Rendering::Runtime::HGSludgeManager::GetConfig(
			//         HGSludgeConfig *__return_ptr retstr,
			//         HGSludgeManager *this,
			//         MethodInfo *method)
			// {
			//   Vector2Int textureSize; // xmm0_8
			//   int32_t graphicsFormat; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   HGSludgeConfig *v10; // rax
			//   HGSludgeConfig v12[2]; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1366, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1366, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_515(v12, Patch, (Object *)this, 0LL);
			//     textureSize = v10.textureSize;
			//     graphicsFormat = v10.graphicsFormat;
			//   }
			//   else
			//   {
			//     textureSize = this.fields.m_config.textureSize;
			//     graphicsFormat = this.fields.m_config.graphicsFormat;
			//   }
			//   retstr.textureSize = textureSize;
			//   retstr.graphicsFormat = graphicsFormat;
			//   return retstr;
			// }
			// 
			return null;
		}

		public int RequireDynamicSludge(Vector2Int texelSize, float rebornTime, float rebornAnimTime)
		{
			// // Int32 RequireDynamicSludge(Vector2Int, Single, Single)
			// int32_t HG::Rendering::Runtime::HGSludgeManager::RequireDynamicSludge(
			//         HGSludgeManager *this,
			//         Vector2Int texelSize,
			//         float rebornTime,
			//         float rebornAnimTime,
			//         MethodInfo *method)
			// {
			//   int32_t v7; // eax
			//   __int64 v8; // rax
			//   AtlasMaxRect *m_atlasMaxRect; // rdx
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_Sludge_HGDynamicSludge_ *m_dynamicSludges; // rcx
			//   __int64 v11; // r13
			//   int32_t m_X; // esi
			//   int32_t v13; // r15d
			//   int32_t xMin; // r14d
			//   int32_t v15; // edi
			//   int32_t yMin; // eax
			//   float v17; // xmm0_4
			//   __m128 v18; // xmm6
			//   MethodInfo *v19; // rdx
			//   Quaternion *identity; // rax
			//   __m128 v21; // xmm2
			//   __m128 v22; // xmm1
			//   Quaternion v23; // xmm0
			//   __m128 v24; // xmm5
			//   float v25; // xmm4_4
			//   Matrix4x4 *v26; // rax
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm2
			//   __int128 v29; // xmm3
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   int32_t key; // [rsp+38h] [rbp-71h]
			//   __int128 v33; // [rsp+48h] [rbp-61h] BYREF
			//   Vector3 v34; // [rsp+58h] [rbp-51h] BYREF
			//   Quaternion v35; // [rsp+68h] [rbp-41h] BYREF
			//   Matrix4x4 v36; // [rsp+78h] [rbp-31h] BYREF
			//   int m_Y; // [rsp+114h] [rbp+6Bh]
			// 
			//   m_Y = texelSize.m_Y;
			//   if ( !byte_18D919DBB )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::Add);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Sludge::HGDynamicSludge);
			//     byte_18D919DBB = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1367, 0LL) )
			//   {
			//     v7 = this.fields.m_dynamicSludgeGUID + 1;
			//     this.fields.m_dynamicSludgeGUID = v7;
			//     key = v7;
			//     v8 = sub_180004920(TypeInfo::HG::Rendering::Runtime::Sludge::HGDynamicSludge);
			//     v11 = v8;
			//     if ( v8 )
			//     {
			//       *(float *)(v8 + 120) = rebornTime;
			//       *(float *)(v8 + 124) = rebornAnimTime;
			//       *(Vector2Int *)(v8 + 16) = texelSize;
			//       m_atlasMaxRect = this.fields.m_atlasMaxRect;
			//       if ( m_atlasMaxRect )
			//       {
			//         *(RectInt *)(v8 + 24) = *HG::Rendering::Runtime::AtlasMaxRect::InsertRect(
			//                                    (RectInt *)&v35,
			//                                    m_atlasMaxRect,
			//                                    texelSize.m_X,
			//                                    m_Y,
			//                                    0LL);
			//         m_X = this.fields.m_config.textureSize.m_X;
			//         v13 = this.fields.m_config.textureSize.m_Y;
			//         xMin = UnityEngine::RectInt::get_xMin((RectInt *)(v11 + 24), 0LL);
			//         v15 = this.fields.m_config.textureSize.m_X;
			//         yMin = UnityEngine::RectInt::get_yMin((RectInt *)(v11 + 24), 0LL);
			//         *(float *)&v33 = (float)texelSize.m_X / (float)m_X;
			//         *((float *)&v33 + 1) = (float)m_Y / (float)v13;
			//         v17 = (float)this.fields.m_config.textureSize.m_Y;
			//         *((float *)&v33 + 2) = (float)xMin / (float)v15;
			//         *((float *)&v33 + 3) = (float)yMin / v17;
			//         *(_OWORD *)(v11 + 40) = v33;
			//         v18 = (__m128)*(unsigned int *)(v11 + 48);
			//         v18.m128_f32[0] = (float)((float)(v18.m128_f32[0] + v18.m128_f32[0]) + *(float *)(v11 + 40)) - 1.0;
			//         identity = UnityEngine::Quaternion::get_identity(&v35, v19);
			//         v21 = (__m128)*(unsigned int *)(v11 + 40);
			//         v22 = (__m128)*(unsigned int *)(v11 + 44);
			//         v21.m128_f32[0] = v21.m128_f32[0] + v21.m128_f32[0];
			//         v22.m128_f32[0] = v22.m128_f32[0] + v22.m128_f32[0];
			//         v23 = *identity;
			//         v34.z = v25;
			//         *(_QWORD *)&v34.x = _mm_unpacklo_ps(v21, v22).m128_u64[0];
			//         DWORD2(v33) = 0;
			//         v35 = v23;
			//         *(_QWORD *)&v33 = _mm_unpacklo_ps(v18, v24).m128_u64[0];
			//         v26 = UnityEngine::Matrix4x4::TRS(&v36, (Vector3 *)&v33, &v35, &v34, 0LL);
			//         v27 = *(_OWORD *)&v26.m01;
			//         v28 = *(_OWORD *)&v26.m02;
			//         v29 = *(_OWORD *)&v26.m03;
			//         *(_OWORD *)(v11 + 56) = *(_OWORD *)&v26.m00;
			//         *(_OWORD *)(v11 + 72) = v27;
			//         *(_OWORD *)(v11 + 88) = v28;
			//         *(_OWORD *)(v11 + 104) = v29;
			//         m_dynamicSludges = this.fields.m_dynamicSludges;
			//         if ( m_dynamicSludges )
			//         {
			//           System::Collections::Generic::Dictionary<int,System::Object>::Add(
			//             (Dictionary_2_System_Int32_System_Object_ *)m_dynamicSludges,
			//             key,
			//             (Object *)v11,
			//             MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::Add);
			//           return key;
			//         }
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(m_dynamicSludges, m_atlasMaxRect);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1367, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_518(
			//            Patch,
			//            (Object *)this,
			//            texelSize,
			//            rebornTime,
			//            rebornAnimTime,
			//            0LL);
			// }
			// 
			return 0;
		}

		public Vector4 GetTillingScale(int handle)
		{
			// // Vector4 GetTillingScale(Int32)
			// Vector4 *HG::Rendering::Runtime::HGSludgeManager::GetTillingScale(
			//         Vector4 *__return_ptr retstr,
			//         HGSludgeManager *this,
			//         int32_t handle,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_Sludge_HGDynamicSludge_ *m_dynamicSludges; // rcx
			//   Object *Item; // rax
			//   Vector4 v10; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 *result; // rax
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919DBC )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::get_Item);
			//     byte_18D919DBC = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1373, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1373, 0LL);
			//     if ( Patch )
			//     {
			//       v10 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_519(&v13, Patch, (Object *)this, handle, 0LL);
			//       goto LABEL_10;
			//     }
			// LABEL_8:
			//     sub_180B536AC(m_dynamicSludges, v7);
			//   }
			//   m_dynamicSludges = this.fields.m_dynamicSludges;
			//   if ( !m_dynamicSludges )
			//     goto LABEL_8;
			//   Item = System::Collections::Generic::Dictionary<int,System::Object>::get_Item(
			//            (Dictionary_2_System_Int32_System_Object_ *)m_dynamicSludges,
			//            handle,
			//            MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::get_Item);
			//   if ( !Item )
			//     goto LABEL_8;
			//   v10 = *(Vector4 *)&Item[2].monitor;
			// LABEL_10:
			//   result = retstr;
			//   *retstr = v10;
			//   return result;
			// }
			// 
			return null;
		}

		public void HitPosition(int handle, Vector2 uvPoint, float range)
		{
			// // Void HitPosition(Int32, Vector2, Single)
			// void HG::Rendering::Runtime::HGSludgeManager::HitPosition(
			//         HGSludgeManager *this,
			//         int32_t handle,
			//         Vector2 uvPoint,
			//         float range,
			//         MethodInfo *method)
			// {
			//   __int64 v8; // rdx
			//   Dictionary_2_System_Int32_HG_Rendering_Runtime_Sludge_HGDynamicSludge_ *m_dynamicSludges; // rcx
			//   float *Item; // rax
			//   float *v11; // rsi
			//   int32_t m_X; // ebx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v15; // [rsp+38h] [rbp-40h]
			// 
			//   if ( !byte_18D919DBD )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::get_Item);
			//     byte_18D919DBD = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1374, 0LL) )
			//   {
			//     m_dynamicSludges = this.fields.m_dynamicSludges;
			//     if ( m_dynamicSludges )
			//     {
			//       Item = (float *)System::Collections::Generic::Dictionary<int,System::Object>::get_Item(
			//                         (Dictionary_2_System_Int32_System_Object_ *)m_dynamicSludges,
			//                         handle,
			//                         MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::get_Item);
			//       v11 = Item;
			//       if ( Item )
			//       {
			//         m_X = this.fields.m_config.textureSize.m_X;
			//         *((float *)&v15 + 1) = (float)(uvPoint.x * Item[10]) + Item[12];
			//         *((float *)&v15 + 2) = (float)(uvPoint.y * Item[11]) + Item[13];
			//         LODWORD(v15) = HG::Rendering::Runtime::HGSludgeManager::GetTime(this, 0LL);
			//         *((float *)&v15 + 3) = range / (float)m_X;
			//         *(_OWORD *)(v11 + 33) = v15;
			//         v11[32] = HG::Rendering::Runtime::HGSludgeManager::GetTime(this, 0LL);
			//         return;
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(m_dynamicSludges, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1374, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_520(Patch, (Object *)this, handle, uvPoint, range, 0LL);
			// }
			// 
		}

		public void ReleaseDynamicSludge(int handle)
		{
			// // Void ReleaseDynamicSludge(Int32)
			// void HG::Rendering::Runtime::HGSludgeManager::ReleaseDynamicSludge(
			//         HGSludgeManager *this,
			//         int32_t handle,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   Dictionary_2_System_Int32_System_Object_ *m_dynamicSludges; // rcx
			//   Object *Item; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919DBE )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::get_Item);
			//     byte_18D919DBE = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1355, 0LL) )
			//   {
			//     m_dynamicSludges = (Dictionary_2_System_Int32_System_Object_ *)this.fields.m_dynamicSludges;
			//     if ( m_dynamicSludges )
			//     {
			//       if ( !System::Collections::Generic::Dictionary<int,System::Object>::ContainsKey(
			//               m_dynamicSludges,
			//               handle,
			//               MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::ContainsKey) )
			//         return;
			//       m_dynamicSludges = (Dictionary_2_System_Int32_System_Object_ *)this.fields.m_dynamicSludges;
			//       if ( m_dynamicSludges )
			//       {
			//         Item = System::Collections::Generic::Dictionary<int,System::Object>::get_Item(
			//                  m_dynamicSludges,
			//                  handle,
			//                  MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::get_Item);
			//         m_dynamicSludges = (Dictionary_2_System_Int32_System_Object_ *)this.fields.m_atlasMaxRect;
			//         if ( Item )
			//         {
			//           if ( m_dynamicSludges )
			//           {
			//             HG::Rendering::Runtime::AtlasMaxRect::RemoveRect(
			//               (AtlasMaxRect *)m_dynamicSludges,
			//               (RectInt *)&Item[1].monitor,
			//               0LL);
			//             m_dynamicSludges = (Dictionary_2_System_Int32_System_Object_ *)this.fields.m_dynamicSludges;
			//             if ( m_dynamicSludges )
			//             {
			//               System::Collections::Generic::Dictionary<int,System::Object>::Remove(
			//                 m_dynamicSludges,
			//                 handle,
			//                 MethodInfo::System::Collections::Generic::Dictionary<int,HG::Rendering::Runtime::Sludge::HGDynamicSludge>::Remove);
			//               return;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_12:
			//     sub_180B536AC(m_dynamicSludges, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1355, 0LL);
			//   if ( !Patch )
			//     goto LABEL_12;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, handle, 0LL);
			// }
			// 
		}

		private HGSludgeConfig m_config;

		private int m_dynamicSludgeGUID;

		private Dictionary<int, HGDynamicSludge> m_dynamicSludges;

		private List<int> m_cacheOutDateList;

		private AtlasMaxRect m_atlasMaxRect;

		private Mesh m_planeMesh;
	}
}
