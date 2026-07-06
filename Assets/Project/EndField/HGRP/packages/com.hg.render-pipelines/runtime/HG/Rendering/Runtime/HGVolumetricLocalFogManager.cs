using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class HGVolumetricLocalFogManager
	{
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x000025D2 File Offset: 0x000007D2
		public static HGVolumetricLocalFogManager instance
		{
			get
			{
				// // HGVolumetricLocalFogManager get_instance()
				// HGVolumetricLocalFogManager *HG::Rendering::Runtime::HGVolumetricLocalFogManager::get_instance(MethodInfo *method)
				// {
				//   __int64 v1; // rdx
				//   Lazy_1_HG_Rendering_Runtime_HGVolumetricLocalFogManager_ *s_instance; // rcx
				// 
				//   if ( !byte_18D919DA4 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager);
				//     sub_18003C530(&MethodInfo::System::Lazy<HG::Rendering::Runtime::HGVolumetricLocalFogManager>::get_Value);
				//     byte_18D919DA4 = 1;
				//   }
				//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager);
				//   s_instance = TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager.static_fields.s_instance;
				//   if ( !s_instance )
				//     sub_180B536AC(0LL, v1);
				//   return (HGVolumetricLocalFogManager *)System::Lazy<System::Object>::get_Value(
				//                                           (Lazy_1_Object_ *)s_instance,
				//                                           MethodInfo::System::Lazy<HG::Rendering::Runtime::HGVolumetricLocalFogManager>::get_Value);
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x06000690 RID: 1680 RVA: 0x000025D2 File Offset: 0x000007D2
		public List<HGVolumetricLocalFog> volumetricLocalFogList
		{
			get
			{
				// // List`1[HG.Rendering.Runtime.HGVolumetricLocalFog] get_volumetricLocalFogList()
				// List_1_HG_Rendering_Runtime_HGVolumetricLocalFog_ *HG::Rendering::Runtime::HGVolumetricLocalFogManager::get_volumetricLocalFogList(
				//         HGVolumetricLocalFogManager *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				// 
				//   if ( !IFix::WrappersManagerImpl::IsPatched(1296, 0LL) )
				//     return this.fields.m_localFogList;
				//   Patch = IFix::WrappersManagerImpl::GetPatch(1296, 0LL);
				//   if ( !Patch )
				//     sub_180B536AC(v6, v5);
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_500(Patch, (Object *)this, 0LL);
				// }
				// 
				return null;
			}
		}

		public HGVolumetricLocalFogManager()
		{
		}

		public void AddVolumetricLocalFog(HGVolumetricLocalFog localFog)
		{
			// // Void AddVolumetricLocalFog(HGVolumetricLocalFog)
			// void HG::Rendering::Runtime::HGVolumetricLocalFogManager::AddVolumetricLocalFog(
			//         HGVolumetricLocalFogManager *this,
			//         HGVolumetricLocalFog *localFog,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   BidirectionalDictionary_2_System_Object_System_Int32_ *m_localFogBiDict; // rcx
			//   HGVolumetricLocalFogManager_SPMDCullingNativeInout *v7; // rax
			//   HGVolumetricLocalFogManager_SPMDCullingNativeInout *v8; // rsi
			//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
			//   PassConstructorID__Enum__Array *v10; // r8
			//   HGCamera *v11; // r9
			//   int32_t Count; // esi
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   float z; // r14d
			//   Transform *v16; // rax
			//   Vector3 *lossyScale; // rax
			//   MethodInfo *v18; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v20; // [rsp+20h] [rbp-50h] BYREF
			//   MethodInfo *v21; // [rsp+28h] [rbp-48h]
			//   Bounds v22; // [rsp+30h] [rbp-40h] BYREF
			//   Bounds v23; // [rsp+50h] [rbp-20h] BYREF
			//   __int64 value; // [rsp+A8h] [rbp+38h] BYREF
			// 
			//   if ( !byte_18D919DA6 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::Add);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::TryGetValueByKey);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGVolumetricLocalFog>::Add);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout);
			//     byte_18D919DA6 = 1;
			//   }
			//   LODWORD(value) = 0;
			//   memset(&v23, 0, sizeof(v23));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1308, 0LL) )
			//   {
			//     m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this.fields.m_localFogBiDict;
			//     if ( !m_localFogBiDict )
			//       goto LABEL_18;
			//     if ( HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::TryGetValueByKey(
			//            m_localFogBiDict,
			//            (Object *)localFog,
			//            (int32_t *)&value,
			//            MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::TryGetValueByKey) )
			//     {
			//       return;
			//     }
			//     if ( !this.fields.m_cullingNativeInout )
			//     {
			//       v7 = (HGVolumetricLocalFogManager_SPMDCullingNativeInout *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout);
			//       v8 = v7;
			//       if ( !v7 )
			//         goto LABEL_18;
			//       HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::SPMDCullingNativeInout(v7, 0LL);
			//       this.fields.m_cullingNativeInout = v8;
			//       sub_1800054D0((HGRenderPathScene *)&this.fields.m_cullingNativeInout, v9, v10, v11, v20, v21);
			//     }
			//     m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this.fields.m_localFogBiDict;
			//     if ( m_localFogBiDict )
			//     {
			//       Count = HG::Rendering::Runtime::BidirectionalDictionary<System::Object,System::Object>::get_Count(
			//                 (BidirectionalDictionary_2_System_Object_System_Object_ *)m_localFogBiDict,
			//                 MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::get_Count);
			//       if ( localFog )
			//       {
			//         transform = UnityEngine::Component::get_transform((Component *)localFog, 0LL);
			//         if ( transform )
			//         {
			//           position = UnityEngine::Transform::get_position(&v22.m_Center, transform, 0LL);
			//           z = position.z;
			//           value = *(_QWORD *)&position.x;
			//           v16 = UnityEngine::Component::get_transform((Component *)localFog, 0LL);
			//           if ( v16 )
			//           {
			//             lossyScale = UnityEngine::Transform::get_lossyScale(&v22.m_Center, v16, 0LL);
			//             v18 = *(MethodInfo **)&lossyScale.x;
			//             *(float *)&lossyScale = lossyScale.z;
			//             v20 = v18;
			//             *(_QWORD *)&v22.m_Center.x = value;
			//             LODWORD(v21) = (_DWORD)lossyScale;
			//             v22.m_Center.z = z;
			//             UnityEngine::Bounds::Bounds(&v23, &v22.m_Center, (Vector3 *)&v20, 0LL);
			//             m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this.fields.m_localFogBiDict;
			//             if ( m_localFogBiDict )
			//             {
			//               HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::Add(
			//                 m_localFogBiDict,
			//                 (Object *)localFog,
			//                 Count,
			//                 MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::Add);
			//               m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this.fields.m_localFogList;
			//               if ( m_localFogBiDict )
			//               {
			//                 sub_1822AD140((List_1_System_Object_ *)m_localFogBiDict, (Object *)localFog);
			//                 m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this.fields.m_cullingNativeInout;
			//                 if ( m_localFogBiDict )
			//                 {
			//                   v22 = v23;
			//                   HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::Add(
			//                     (HGVolumetricLocalFogManager_SPMDCullingNativeInout *)m_localFogBiDict,
			//                     &v22,
			//                     0LL);
			//                   return;
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_18:
			//     sub_180B536AC(m_localFogBiDict, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1308, 0LL);
			//   if ( !Patch )
			//     goto LABEL_18;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)localFog,
			//     0LL);
			// }
			// 
		}

		public void RemoveVolumetricLocalFog(HGVolumetricLocalFog localFog)
		{
			// // Void RemoveVolumetricLocalFog(HGVolumetricLocalFog)
			// void HG::Rendering::Runtime::HGVolumetricLocalFogManager::RemoveVolumetricLocalFog(
			//         HGVolumetricLocalFogManager *this,
			//         HGVolumetricLocalFog *localFog,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   BidirectionalDictionary_2_System_Object_System_Int32_ *m_localFogBiDict; // rcx
			//   int32_t Count; // eax
			//   int32_t v8; // edi
			//   int32_t v9; // ebp
			//   Object *KeyByValue; // rax
			//   Object *v11; // r14
			//   List_1_HG_Rendering_Runtime_HGVolumetricLocalFog_ *m_localFogList; // rax
			//   HGRenderPathBase_HGRenderPathResources *v13; // rdx
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v17; // [rsp+20h] [rbp-18h]
			//   MethodInfo *v18; // [rsp+28h] [rbp-10h]
			//   int32_t value; // [rsp+58h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D919DA7 )
			//   {
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::Add);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::GetKeyByValue);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::Remove);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::TryGetValueByKey);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::get_Count);
			//     sub_18003C530(&MethodInfo::Unity::Collections::ListExtensions::RemoveAtSwapBack<HG::Rendering::Runtime::HGVolumetricLocalFog>);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGVolumetricLocalFog>::RemoveAt);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGVolumetricLocalFog>::get_Count);
			//     byte_18D919DA7 = 1;
			//   }
			//   value = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1311, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1311, 0LL);
			//     if ( !Patch )
			//       goto LABEL_22;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//       (ILFixDynamicMethodWrapper_37 *)Patch,
			//       (Object *)this,
			//       (Object *)localFog,
			//       0LL);
			//   }
			//   else
			//   {
			//     m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this.fields.m_localFogBiDict;
			//     if ( !m_localFogBiDict )
			//       goto LABEL_22;
			//     if ( !HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::TryGetValueByKey(
			//             m_localFogBiDict,
			//             (Object *)localFog,
			//             &value,
			//             MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::TryGetValueByKey) )
			//       return;
			//     m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this.fields.m_localFogBiDict;
			//     if ( !m_localFogBiDict )
			//       goto LABEL_22;
			//     Count = HG::Rendering::Runtime::BidirectionalDictionary<System::Object,System::Object>::get_Count(
			//               (BidirectionalDictionary_2_System_Object_System_Object_ *)m_localFogBiDict,
			//               MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::get_Count);
			//     v8 = value;
			//     m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this.fields.m_localFogBiDict;
			//     v9 = Count - 1;
			//     if ( value != Count - 1 )
			//     {
			//       if ( m_localFogBiDict )
			//       {
			//         KeyByValue = HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::GetKeyByValue(
			//                        m_localFogBiDict,
			//                        v9,
			//                        MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::GetKeyByValue);
			//         m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this.fields.m_localFogBiDict;
			//         v11 = KeyByValue;
			//         if ( m_localFogBiDict )
			//         {
			//           HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::Remove(
			//             m_localFogBiDict,
			//             (Object *)localFog,
			//             v8,
			//             MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::Remove);
			//           m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this.fields.m_localFogBiDict;
			//           if ( m_localFogBiDict )
			//           {
			//             HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::Remove(
			//               m_localFogBiDict,
			//               v11,
			//               v9,
			//               MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::Remove);
			//             m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this.fields.m_localFogBiDict;
			//             if ( m_localFogBiDict )
			//             {
			//               HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::Add(
			//                 m_localFogBiDict,
			//                 v11,
			//                 v8,
			//                 MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::Add);
			//               Unity::Collections::ListExtensions::RemoveAtSwapBack<System::Object>(
			//                 (List_1_System_Object_ *)this.fields.m_localFogList,
			//                 v8,
			//                 MethodInfo::Unity::Collections::ListExtensions::RemoveAtSwapBack<HG::Rendering::Runtime::HGVolumetricLocalFog>);
			//               m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this.fields.m_cullingNativeInout;
			//               if ( m_localFogBiDict )
			//               {
			//                 HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::RemoveAtSwapBack(
			//                   (HGVolumetricLocalFogManager_SPMDCullingNativeInout *)m_localFogBiDict,
			//                   v8,
			//                   0LL);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			// LABEL_22:
			//       sub_180B536AC(m_localFogBiDict, v5);
			//     }
			//     if ( !m_localFogBiDict )
			//       goto LABEL_22;
			//     HG::Rendering::Runtime::BidirectionalDictionary<System::Object,int>::Remove(
			//       m_localFogBiDict,
			//       (Object *)localFog,
			//       value,
			//       MethodInfo::HG::Rendering::Runtime::BidirectionalDictionary<HG::Rendering::Runtime::HGVolumetricLocalFog,int>::Remove);
			//     m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this.fields.m_localFogList;
			//     if ( !m_localFogBiDict )
			//       goto LABEL_22;
			//     System::Collections::Generic::List<System::Object>::RemoveAt(
			//       (List_1_System_Object_ *)m_localFogBiDict,
			//       v8,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGVolumetricLocalFog>::RemoveAt);
			//     m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this.fields.m_cullingNativeInout;
			//     if ( !m_localFogBiDict )
			//       goto LABEL_22;
			//     HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::RemoveAtSwapBack(
			//       (HGVolumetricLocalFogManager_SPMDCullingNativeInout *)m_localFogBiDict,
			//       v8,
			//       0LL);
			//     m_localFogList = this.fields.m_localFogList;
			//     if ( !m_localFogList )
			//       goto LABEL_22;
			//     if ( !m_localFogList.fields._size )
			//     {
			//       m_localFogBiDict = (BidirectionalDictionary_2_System_Object_System_Int32_ *)this.fields.m_cullingNativeInout;
			//       if ( !m_localFogBiDict )
			//         goto LABEL_22;
			//       HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::Dispose(
			//         (HGVolumetricLocalFogManager_SPMDCullingNativeInout *)m_localFogBiDict,
			//         0LL);
			//       this.fields.m_cullingNativeInout = 0LL;
			//       sub_1800054D0((HGRenderPathScene *)&this.fields.m_cullingNativeInout, v13, v14, v15, v17, v18);
			//     }
			//   }
			// }
			// 
		}

		public NativeList<int> VolumetricLocalFogCulling(Matrix4x4 cullingMatrix, int cameraGuid)
		{
			// // NativeList`1[System.Int32] VolumetricLocalFogCulling(Matrix4x4, Int32)
			// NativeList_1_System_Int32_ *HG::Rendering::Runtime::HGVolumetricLocalFogManager::VolumetricLocalFogCulling(
			//         NativeList_1_System_Int32_ *__return_ptr retstr,
			//         HGVolumetricLocalFogManager *this,
			//         Matrix4x4 *cullingMatrix,
			//         int32_t cameraGuid,
			//         MethodInfo *method)
			// {
			//   HGVolumetricLocalFogManager_SPMDCullingNativeInout *v9; // rdx
			//   HGVolumetricLocalFogManager_SPMDCullingNativeInout *m_cullingNativeInout; // rcx
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   NativeList_1_System_Int32_ *v14; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   NativeList_1_System_Int32_ v19; // xmm0
			//   NativeList_1_System_Int32_ *result; // rax
			//   NativeList_1_System_Int32_ v21; // [rsp+30h] [rbp-50h] BYREF
			//   Matrix4x4 v22; // [rsp+40h] [rbp-40h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1297, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1297, 0LL);
			//     if ( Patch )
			//     {
			//       v16 = *(_OWORD *)&cullingMatrix.m01;
			//       *(_OWORD *)&v22.m00 = *(_OWORD *)&cullingMatrix.m00;
			//       v17 = *(_OWORD *)&cullingMatrix.m02;
			//       *(_OWORD *)&v22.m01 = v16;
			//       v18 = *(_OWORD *)&cullingMatrix.m03;
			//       *(_OWORD *)&v22.m02 = v17;
			//       *(_OWORD *)&v22.m03 = v18;
			//       v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v21, Patch, (Object *)this, &v22, cameraGuid, 0LL);
			//       goto LABEL_8;
			//     }
			// LABEL_6:
			//     sub_180B536AC(m_cullingNativeInout, v9);
			//   }
			//   m_cullingNativeInout = this.fields.m_cullingNativeInout;
			//   if ( !m_cullingNativeInout )
			//     goto LABEL_6;
			//   HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::UpdateLocalFogTransform(
			//     m_cullingNativeInout,
			//     this.fields.m_localFogList,
			//     0LL);
			//   v9 = this.fields.m_cullingNativeInout;
			//   if ( !v9 )
			//     goto LABEL_6;
			//   v11 = *(_OWORD *)&cullingMatrix.m01;
			//   *(_OWORD *)&v22.m00 = *(_OWORD *)&cullingMatrix.m00;
			//   v12 = *(_OWORD *)&cullingMatrix.m02;
			//   *(_OWORD *)&v22.m01 = v11;
			//   v13 = *(_OWORD *)&cullingMatrix.m03;
			//   *(_OWORD *)&v22.m02 = v12;
			//   *(_OWORD *)&v22.m03 = v13;
			//   v14 = HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::VolumetricLocalFogCulling(
			//           &v21,
			//           v9,
			//           &v22,
			//           cameraGuid,
			//           0LL);
			// LABEL_8:
			//   v19 = *v14;
			//   result = retstr;
			//   *retstr = v19;
			//   return result;
			// }
			// 
			return null;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly Lazy<HGVolumetricLocalFogManager> s_instance;

		private readonly BidirectionalDictionary<HGVolumetricLocalFog, int> m_localFogBiDict;

		private readonly List<HGVolumetricLocalFog> m_localFogList;

		private HGVolumetricLocalFogManager.SPMDCullingNativeInout m_cullingNativeInout;

		public class SPMDCullingNativeInout : IDisposable
		{
			public SPMDCullingNativeInout()
			{
				// // HGVolumetricLocalFogManager+SPMDCullingNativeInout()
				// void HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::SPMDCullingNativeInout(
				//         HGVolumetricLocalFogManager_SPMDCullingNativeInout *this,
				//         MethodInfo *method)
				// {
				//   NativeList_1_System_Single_ v3; // [rsp+20h] [rbp-10h] BYREF
				// 
				//   if ( !byte_18D919DA9 )
				//   {
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<float>::NativeList);
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<int>::NativeList);
				//     byte_18D919DA9 = 1;
				//   }
				//   v3 = 0LL;
				//   Unity::Collections::NativeList<float>::NativeList(
				//     &v3,
				//     (AllocatorManager_AllocatorHandle)4,
				//     MethodInfo::Unity::Collections::NativeList<float>::NativeList);
				//   this.fields.centerXs = v3;
				//   v3 = 0LL;
				//   Unity::Collections::NativeList<float>::NativeList(
				//     &v3,
				//     (AllocatorManager_AllocatorHandle)4,
				//     MethodInfo::Unity::Collections::NativeList<float>::NativeList);
				//   this.fields.centerYs = v3;
				//   v3 = 0LL;
				//   Unity::Collections::NativeList<float>::NativeList(
				//     &v3,
				//     (AllocatorManager_AllocatorHandle)4,
				//     MethodInfo::Unity::Collections::NativeList<float>::NativeList);
				//   this.fields.centerZs = v3;
				//   v3 = 0LL;
				//   Unity::Collections::NativeList<float>::NativeList(
				//     &v3,
				//     (AllocatorManager_AllocatorHandle)4,
				//     MethodInfo::Unity::Collections::NativeList<float>::NativeList);
				//   this.fields.extentXs = v3;
				//   v3 = 0LL;
				//   Unity::Collections::NativeList<float>::NativeList(
				//     &v3,
				//     (AllocatorManager_AllocatorHandle)4,
				//     MethodInfo::Unity::Collections::NativeList<float>::NativeList);
				//   this.fields.extentYs = v3;
				//   v3 = 0LL;
				//   Unity::Collections::NativeList<float>::NativeList(
				//     &v3,
				//     (AllocatorManager_AllocatorHandle)4,
				//     MethodInfo::Unity::Collections::NativeList<float>::NativeList);
				//   this.fields.extentZs = v3;
				//   v3 = 0LL;
				//   Unity::Collections::NativeList<int>::NativeList(
				//     (NativeList_1_System_Int32_ *)&v3,
				//     (AllocatorManager_AllocatorHandle)4,
				//     MethodInfo::Unity::Collections::NativeList<int>::NativeList);
				//   this.fields.visibility = (NativeList_1_System_Int32_)v3;
				// }
				// 
			}

			public void Dispose()
			{
				// // Void Dispose()
				// void HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::Dispose(
				//         HGVolumetricLocalFogManager_SPMDCullingNativeInout *this,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				// 
				//   if ( !byte_18D919DAA )
				//   {
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<float>::Dispose);
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<int>::Dispose);
				//     byte_18D919DAA = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1313, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1313, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v5, v4);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     Unity::Collections::NativeList<float>::Dispose(
				//       &this.fields.centerXs,
				//       MethodInfo::Unity::Collections::NativeList<float>::Dispose);
				//     Unity::Collections::NativeList<float>::Dispose(
				//       &this.fields.centerYs,
				//       MethodInfo::Unity::Collections::NativeList<float>::Dispose);
				//     Unity::Collections::NativeList<float>::Dispose(
				//       &this.fields.centerZs,
				//       MethodInfo::Unity::Collections::NativeList<float>::Dispose);
				//     Unity::Collections::NativeList<float>::Dispose(
				//       &this.fields.extentXs,
				//       MethodInfo::Unity::Collections::NativeList<float>::Dispose);
				//     Unity::Collections::NativeList<float>::Dispose(
				//       &this.fields.extentYs,
				//       MethodInfo::Unity::Collections::NativeList<float>::Dispose);
				//     Unity::Collections::NativeList<float>::Dispose(
				//       &this.fields.extentZs,
				//       MethodInfo::Unity::Collections::NativeList<float>::Dispose);
				//     Unity::Collections::NativeList<int>::Dispose(
				//       &this.fields.visibility,
				//       MethodInfo::Unity::Collections::NativeList<int>::Dispose);
				//   }
				// }
				// 
			}

			public void Add(Bounds bounds)
			{
				// // Void Add(Bounds)
				// void HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::Add(
				//         HGVolumetricLocalFogManager_SPMDCullingNativeInout *this,
				//         Bounds *bounds,
				//         MethodInfo *method)
				// {
				//   float z; // eax
				//   float v6; // eax
				//   float v7; // eax
				//   float v8; // eax
				//   float v9; // eax
				//   float v10; // eax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v12; // rdx
				//   __int64 v13; // rcx
				//   __int64 v14; // xmm1_8
				//   Bounds value; // [rsp+20h] [rbp-20h] BYREF
				//   int32_t v16; // [rsp+68h] [rbp+28h] BYREF
				// 
				//   if ( !byte_18D919DAB )
				//   {
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<float>::Add);
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<int>::Add);
				//     byte_18D919DAB = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1309, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1309, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v13, v12);
				//     v14 = *(_QWORD *)&bounds.m_Extents.y;
				//     *(_OWORD *)&value.m_Center.x = *(_OWORD *)&bounds.m_Center.x;
				//     *(_QWORD *)&value.m_Extents.y = v14;
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_503(Patch, (Object *)this, &value, 0LL);
				//   }
				//   else
				//   {
				//     z = bounds.m_Center.z;
				//     *(_QWORD *)&value.m_Center.x = *(_QWORD *)&bounds.m_Center.x;
				//     value.m_Center.z = z;
				//     Unity::Collections::NativeList<float>::Add(
				//       &this.fields.centerXs,
				//       &value.m_Center.x,
				//       MethodInfo::Unity::Collections::NativeList<float>::Add);
				//     v6 = bounds.m_Center.z;
				//     *(_QWORD *)&value.m_Center.x = *(_QWORD *)&bounds.m_Center.x;
				//     value.m_Center.z = v6;
				//     Unity::Collections::NativeList<float>::Add(
				//       &this.fields.centerYs,
				//       &value.m_Center.y,
				//       MethodInfo::Unity::Collections::NativeList<float>::Add);
				//     v7 = bounds.m_Center.z;
				//     *(_QWORD *)&value.m_Center.x = *(_QWORD *)&bounds.m_Center.x;
				//     value.m_Center.z = v7;
				//     Unity::Collections::NativeList<float>::Add(
				//       &this.fields.centerZs,
				//       &value.m_Center.z,
				//       MethodInfo::Unity::Collections::NativeList<float>::Add);
				//     v8 = bounds.m_Extents.z;
				//     *(_QWORD *)&value.m_Center.x = *(_QWORD *)&bounds.m_Extents.x;
				//     value.m_Center.z = v8;
				//     Unity::Collections::NativeList<float>::Add(
				//       &this.fields.extentXs,
				//       &value.m_Center.x,
				//       MethodInfo::Unity::Collections::NativeList<float>::Add);
				//     v9 = bounds.m_Extents.z;
				//     *(_QWORD *)&value.m_Center.x = *(_QWORD *)&bounds.m_Extents.x;
				//     value.m_Center.z = v9;
				//     Unity::Collections::NativeList<float>::Add(
				//       &this.fields.extentYs,
				//       &value.m_Center.y,
				//       MethodInfo::Unity::Collections::NativeList<float>::Add);
				//     v10 = bounds.m_Extents.z;
				//     *(_QWORD *)&value.m_Center.x = *(_QWORD *)&bounds.m_Extents.x;
				//     value.m_Center.z = v10;
				//     Unity::Collections::NativeList<float>::Add(
				//       &this.fields.extentZs,
				//       &value.m_Center.z,
				//       MethodInfo::Unity::Collections::NativeList<float>::Add);
				//     v16 = 0;
				//     Unity::Collections::NativeList<int>::Add(
				//       &this.fields.visibility,
				//       &v16,
				//       MethodInfo::Unity::Collections::NativeList<int>::Add);
				//   }
				// }
				// 
			}

			public void RemoveAtSwapBack(int index)
			{
				// // Void RemoveAtSwapBack(Int32)
				// void HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::RemoveAtSwapBack(
				//         HGVolumetricLocalFogManager_SPMDCullingNativeInout *this,
				//         int32_t index,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				// 
				//   if ( !byte_18D919DAC )
				//   {
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<float>::RemoveAtSwapBack);
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<int>::RemoveAtSwapBack);
				//     byte_18D919DAC = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1312, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1312, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, index, 0LL);
				//   }
				//   else
				//   {
				//     Unity::Collections::NativeList<unsigned int>::RemoveAtSwapBack(
				//       (NativeList_1_System_UInt32_ *)&this.fields,
				//       index,
				//       MethodInfo::Unity::Collections::NativeList<float>::RemoveAtSwapBack);
				//     Unity::Collections::NativeList<unsigned int>::RemoveAtSwapBack(
				//       (NativeList_1_System_UInt32_ *)&this.fields.centerYs,
				//       index,
				//       MethodInfo::Unity::Collections::NativeList<float>::RemoveAtSwapBack);
				//     Unity::Collections::NativeList<unsigned int>::RemoveAtSwapBack(
				//       (NativeList_1_System_UInt32_ *)&this.fields.centerZs,
				//       index,
				//       MethodInfo::Unity::Collections::NativeList<float>::RemoveAtSwapBack);
				//     Unity::Collections::NativeList<unsigned int>::RemoveAtSwapBack(
				//       (NativeList_1_System_UInt32_ *)&this.fields.extentXs,
				//       index,
				//       MethodInfo::Unity::Collections::NativeList<float>::RemoveAtSwapBack);
				//     Unity::Collections::NativeList<unsigned int>::RemoveAtSwapBack(
				//       (NativeList_1_System_UInt32_ *)&this.fields.extentYs,
				//       index,
				//       MethodInfo::Unity::Collections::NativeList<float>::RemoveAtSwapBack);
				//     Unity::Collections::NativeList<unsigned int>::RemoveAtSwapBack(
				//       (NativeList_1_System_UInt32_ *)&this.fields.extentZs,
				//       index,
				//       MethodInfo::Unity::Collections::NativeList<float>::RemoveAtSwapBack);
				//     Unity::Collections::NativeList<unsigned int>::RemoveAtSwapBack(
				//       (NativeList_1_System_UInt32_ *)&this.fields.visibility,
				//       index,
				//       MethodInfo::Unity::Collections::NativeList<int>::RemoveAtSwapBack);
				//   }
				// }
				// 
			}

			public void UpdateLocalFogTransform(List<HGVolumetricLocalFog> localFogList)
			{
				// // Void UpdateLocalFogTransform(List`1[HG.Rendering.Runtime.HGVolumetricLocalFog])
				// void HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::UpdateLocalFogTransform(
				//         HGVolumetricLocalFogManager_SPMDCullingNativeInout *this,
				//         List_1_HG_Rendering_Runtime_HGVolumetricLocalFog_ *localFogList,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				//   int32_t v7; // ebx
				//   Object *Item; // rax
				//   Component *v9; // rdi
				//   Transform *transform; // rax
				//   Transform *v11; // rax
				//   Transform *v12; // rax
				//   Vector3 *position; // rax
				//   __int64 v14; // xmm6_8
				//   float z; // r15d
				//   Transform *v16; // rax
				//   Vector3 *lossyScale; // rax
				//   __int64 v18; // xmm0_8
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   Vector3 v20; // [rsp+28h] [rbp-29h] BYREF
				//   Vector3 v21; // [rsp+38h] [rbp-19h] BYREF
				//   Vector3 v22; // [rsp+48h] [rbp-9h] BYREF
				//   Vector3 v23; // [rsp+58h] [rbp+7h] BYREF
				//   Bounds value[2]; // [rsp+68h] [rbp+17h] BYREF
				// 
				//   if ( !byte_18D919DAD )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGVolumetricLocalFog>::get_Count);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGVolumetricLocalFog>::get_Item);
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<float>::set_Item);
				//     byte_18D919DAD = 1;
				//   }
				//   memset(value, 0, 24);
				//   if ( IFix::WrappersManagerImpl::IsPatched(1298, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1298, 0LL);
				//     if ( Patch )
				//     {
				//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
				//         (ILFixDynamicMethodWrapper_37 *)Patch,
				//         (Object *)this,
				//         (Object *)localFogList,
				//         0LL);
				//       return;
				//     }
				// LABEL_15:
				//     sub_180B536AC(v6, v5);
				//   }
				//   v7 = 0;
				//   if ( !localFogList )
				//     goto LABEL_15;
				//   while ( v7 < localFogList.fields._size )
				//   {
				//     Item = System::Collections::Generic::List<System::Object>::get_Item(
				//              (List_1_System_Object_ *)localFogList,
				//              v7,
				//              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGVolumetricLocalFog>::get_Item);
				//     v9 = (Component *)Item;
				//     if ( !Item )
				//       goto LABEL_15;
				//     transform = UnityEngine::Component::get_transform((Component *)Item, 0LL);
				//     if ( !transform )
				//       goto LABEL_15;
				//     if ( UnityEngine::Transform::get_hasChanged(transform, 0LL) )
				//     {
				//       v11 = UnityEngine::Component::get_transform(v9, 0LL);
				//       if ( !v11 )
				//         goto LABEL_15;
				//       UnityEngine::Transform::set_hasChanged(v11, 0, 0LL);
				//       v12 = UnityEngine::Component::get_transform(v9, 0LL);
				//       if ( !v12 )
				//         goto LABEL_15;
				//       position = UnityEngine::Transform::get_position(&v22, v12, 0LL);
				//       v14 = *(_QWORD *)&position.x;
				//       z = position.z;
				//       v16 = UnityEngine::Component::get_transform(v9, 0LL);
				//       if ( !v16 )
				//         goto LABEL_15;
				//       lossyScale = UnityEngine::Transform::get_lossyScale(&v23, v16, 0LL);
				//       *(_QWORD *)&v21.x = v14;
				//       v21.z = z;
				//       v18 = *(_QWORD *)&lossyScale.x;
				//       *(float *)&lossyScale = lossyScale.z;
				//       *(_QWORD *)&v20.x = v18;
				//       LODWORD(v20.z) = (_DWORD)lossyScale;
				//       UnityEngine::Bounds::Bounds(value, &v21, &v20, 0LL);
				//       Unity::Collections::NativeList<float>::set_Item(
				//         &this.fields.centerXs,
				//         v7,
				//         value[0].m_Center.x,
				//         MethodInfo::Unity::Collections::NativeList<float>::set_Item);
				//       Unity::Collections::NativeList<float>::set_Item(
				//         &this.fields.centerYs,
				//         v7,
				//         value[0].m_Center.y,
				//         MethodInfo::Unity::Collections::NativeList<float>::set_Item);
				//       Unity::Collections::NativeList<float>::set_Item(
				//         &this.fields.centerZs,
				//         v7,
				//         value[0].m_Center.z,
				//         MethodInfo::Unity::Collections::NativeList<float>::set_Item);
				//       Unity::Collections::NativeList<float>::set_Item(
				//         &this.fields.extentXs,
				//         v7,
				//         value[0].m_Extents.x,
				//         MethodInfo::Unity::Collections::NativeList<float>::set_Item);
				//       Unity::Collections::NativeList<float>::set_Item(
				//         &this.fields.extentYs,
				//         v7,
				//         value[0].m_Extents.y,
				//         MethodInfo::Unity::Collections::NativeList<float>::set_Item);
				//       Unity::Collections::NativeList<float>::set_Item(
				//         &this.fields.extentZs,
				//         v7,
				//         value[0].m_Extents.z,
				//         MethodInfo::Unity::Collections::NativeList<float>::set_Item);
				//     }
				//     ++v7;
				//   }
				// }
				// 
			}

			public NativeList<int> VolumetricLocalFogCulling(Matrix4x4 cullingMatrix, int cameraGuid)
			{
				// // NativeList`1[System.Int32] VolumetricLocalFogCulling(Matrix4x4, Int32)
				// NativeList_1_System_Int32_ *HG::Rendering::Runtime::HGVolumetricLocalFogManager::SPMDCullingNativeInout::VolumetricLocalFogCulling(
				//         NativeList_1_System_Int32_ *__return_ptr retstr,
				//         HGVolumetricLocalFogManager_SPMDCullingNativeInout *this,
				//         Matrix4x4 *cullingMatrix,
				//         int32_t cameraGuid,
				//         MethodInfo *method)
				// {
				//   __int128 v9; // xmm1
				//   __int128 v10; // xmm0
				//   __int128 v11; // xmm1
				//   NativeList_1_System_Int32_ visibility; // xmm0
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v14; // rdx
				//   __int64 v15; // rcx
				//   __int128 v16; // xmm1
				//   __int128 v17; // xmm0
				//   __int128 v18; // xmm1
				//   NativeList_1_System_Int32_ *result; // rax
				//   NativeArray_1_System_Single_ v20; // [rsp+58h] [rbp-61h] BYREF
				//   NativeArray_1_System_Int32_ v21; // [rsp+68h] [rbp-51h] BYREF
				//   NativeArray_1_System_Single_ v22; // [rsp+78h] [rbp-41h] BYREF
				//   NativeArray_1_System_Single_ v23; // [rsp+88h] [rbp-31h] BYREF
				//   NativeArray_1_System_Single_ v24; // [rsp+98h] [rbp-21h] BYREF
				//   NativeArray_1_System_Single_ v25; // [rsp+A8h] [rbp-11h] BYREF
				//   NativeArray_1_System_Single_ v26; // [rsp+B8h] [rbp-1h] BYREF
				//   Matrix4x4 v27; // [rsp+C8h] [rbp+Fh] BYREF
				// 
				//   if ( !byte_18D919DAE )
				//   {
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<int>::AsArray);
				//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<float>::AsArray);
				//     byte_18D919DAE = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1299, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1299, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v15, v14);
				//     v16 = *(_OWORD *)&cullingMatrix.m01;
				//     *(_OWORD *)&v27.m00 = *(_OWORD *)&cullingMatrix.m00;
				//     v17 = *(_OWORD *)&cullingMatrix.m02;
				//     *(_OWORD *)&v27.m01 = v16;
				//     v18 = *(_OWORD *)&cullingMatrix.m03;
				//     *(_OWORD *)&v27.m02 = v17;
				//     *(_OWORD *)&v27.m03 = v18;
				//     visibility = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(
				//                     (NativeList_1_System_Int32_ *)&v20,
				//                     Patch,
				//                     (Object *)this,
				//                     &v27,
				//                     cameraGuid,
				//                     0LL);
				//   }
				//   else
				//   {
				//     Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiAgentData>::AsArray(
				//       (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&v20,
				//       (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&this.fields,
				//       MethodInfo::Unity::Collections::NativeList<float>::AsArray);
				//     Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiAgentData>::AsArray(
				//       (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&v26,
				//       (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&this.fields.centerYs,
				//       MethodInfo::Unity::Collections::NativeList<float>::AsArray);
				//     Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiAgentData>::AsArray(
				//       (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&v25,
				//       (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&this.fields.centerZs,
				//       MethodInfo::Unity::Collections::NativeList<float>::AsArray);
				//     Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiAgentData>::AsArray(
				//       (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&v24,
				//       (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&this.fields.extentXs,
				//       MethodInfo::Unity::Collections::NativeList<float>::AsArray);
				//     Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiAgentData>::AsArray(
				//       (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&v23,
				//       (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&this.fields.extentYs,
				//       MethodInfo::Unity::Collections::NativeList<float>::AsArray);
				//     Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiAgentData>::AsArray(
				//       (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&v22,
				//       (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiAgentData_ *)&this.fields.extentZs,
				//       MethodInfo::Unity::Collections::NativeList<float>::AsArray);
				//     Unity::Collections::NativeList<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::AsArray(
				//       (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v21,
				//       (NativeList_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&this.fields.visibility,
				//       MethodInfo::Unity::Collections::NativeList<int>::AsArray);
				//     v9 = *(_OWORD *)&cullingMatrix.m00;
				//     *(_OWORD *)&v27.m01 = *(_OWORD *)&cullingMatrix.m01;
				//     v10 = *(_OWORD *)&cullingMatrix.m03;
				//     *(_OWORD *)&v27.m00 = v9;
				//     v11 = *(_OWORD *)&cullingMatrix.m02;
				//     *(_OWORD *)&v27.m03 = v10;
				//     *(_OWORD *)&v27.m02 = v11;
				//     UnityEngine::GeometryUtility::SPMDCullAABB(&v27, &v20, &v26, &v25, &v24, &v23, &v22, &v21, 0LL);
				//     visibility = this.fields.visibility;
				//   }
				//   result = retstr;
				//   *retstr = visibility;
				//   return result;
				// }
				// 
				return null;
			}

			public NativeList<float> centerXs;

			public NativeList<float> centerYs;

			public NativeList<float> centerZs;

			public NativeList<float> extentXs;

			public NativeList<float> extentYs;

			public NativeList<float> extentZs;

			public NativeList<int> visibility;
		}
	}
}
