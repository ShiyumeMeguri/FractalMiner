using System;
using System.Collections.Generic;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class HgSceneLightingData : MonoBehaviour
	{
		public HgSceneLightingData()
		{
			// // Singleton`1[System.Object]()
			// void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
			// {
			//   UnityEngine::Component::Component((Component *)this, 0LL);
			// }
			// 
		}

		internal static string Log(string msg, [MetadataOffset(Offset = "0x01F90DD6")] LogType type = LogType.Log)
		{
			// // String Log(String, LogType)
			// String *HG::Rendering::Runtime::HgSceneLightingData::Log(String *msg, LogType__Enum type, MethodInfo *method)
			// {
			//   char *v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			// 
			//   if ( !byte_18D919E36 )
			//   {
			//     sub_18003C530(&off_18D5ECC40);
			//     sub_18003C530(&off_18D5ECD78);
			//     sub_18003C530(&off_18D5ECD68);
			//     sub_18003C530(&off_18D5ECD58);
			//     byte_18D919E36 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1667, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1667, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_644(Patch, (Object *)msg, type, 0LL);
			//   }
			//   else
			//   {
			//     if ( type == LogType__Enum_Log )
			//     {
			//       v5 = "<color=white><b>[HG Scene Lighting Data]";
			//     }
			//     else if ( type == LogType__Enum_Warning )
			//     {
			//       v5 = "<color=yellow><b>[HG Scene Lighting Data]";
			//     }
			//     else
			//     {
			//       v5 = "<color=red><b>[HG Scene Lighting Data]";
			//     }
			//     return System::String::Concat((String *)v5, msg, (String *)"</b></color>", 0LL);
			//   }
			// }
			// 
			return null;
		}

		public static HgSceneLightingData GetSceneFirstActiveData()
		{
			// // HgSceneLightingData GetSceneFirstActiveData()
			// HgSceneLightingData *HG::Rendering::Runtime::HgSceneLightingData::GetSceneFirstActiveData(MethodInfo *method)
			// {
			//   Object__Array *v1; // rax
			//   __int64 v2; // rdx
			//   __int64 v3; // rcx
			//   Object__Array *v4; // rsi
			//   int32_t i; // ebx
			//   Component *v6; // rdi
			//   GameObject *gameObject; // rax
			//   GameObject *v8; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919E37 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Object::FindObjectsOfType<HG::Rendering::Runtime::HgSceneLightingData>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919E37 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1668, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1668, 0LL);
			//     if ( !Patch )
			// LABEL_21:
			//       sub_180B536AC(v3, v2);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_645(Patch, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     v1 = UnityEngine::Object::FindObjectsOfType<System::Object>(MethodInfo::UnityEngine::Object::FindObjectsOfType<HG::Rendering::Runtime::HgSceneLightingData>);
			//     v4 = v1;
			//     if ( v1 && v1.max_length.value )
			//     {
			//       for ( i = 0; i < v4.max_length.size; ++i )
			//       {
			//         if ( (unsigned int)i >= v4.max_length.size )
			//           sub_180070270(v3, v2);
			//         v6 = (Component *)v4.vector[i];
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( !UnityEngine::Object::op_Equality((Object_1 *)v6, 0LL, 0LL) )
			//         {
			//           if ( !v6 )
			//             goto LABEL_21;
			//           if ( UnityEngine::EventSystems::UIBehaviour::IsActive((UIBehaviour *)v6, 0LL) )
			//           {
			//             gameObject = UnityEngine::Component::get_gameObject(v6, 0LL);
			//             if ( !gameObject )
			//               goto LABEL_21;
			//             if ( UnityEngine::GameObject::get_activeInHierarchy(gameObject, 0LL) )
			//             {
			//               v8 = UnityEngine::Component::get_gameObject(v6, 0LL);
			//               if ( !v8 )
			//                 goto LABEL_21;
			//               if ( UnityEngine::GameObject::get_activeSelf(v8, 0LL) )
			//                 return (HgSceneLightingData *)v6;
			//             }
			//           }
			//         }
			//       }
			//     }
			//     return 0LL;
			//   }
			// }
			// 
			return null;
		}

		public static GameObject CreateLightingDataGameobject()
		{
			// // GameObject CreateLightingDataGameobject()
			// GameObject *HG::Rendering::Runtime::HgSceneLightingData::CreateLightingDataGameobject(MethodInfo *method)
			// {
			//   GameObject *v1; // rax
			//   __int64 v2; // rdx
			//   __int64 v3; // rcx
			//   GameObject *v4; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919E38 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HgSceneLightingData>);
			//     sub_18003C530(&TypeInfo::UnityEngine::GameObject);
			//     sub_18003C530(&off_18D5ECDA0);
			//     byte_18D919E38 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1669, 0LL) )
			//   {
			//     v1 = (GameObject *)sub_180004920(TypeInfo::UnityEngine::GameObject);
			//     v4 = v1;
			//     if ( v1 )
			//     {
			//       UnityEngine::GameObject::GameObject(v1, (String *)"!HgSceneLightingData", 0LL);
			//       UnityEngine::GameObject::AddComponent<System::Object>(
			//         v4,
			//         MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HgSceneLightingData>);
			//       return v4;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v3, v2);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1669, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_646(Patch, 0LL);
			// }
			// 
			return null;
		}

		public static GameObject GetOrCreateLightingData()
		{
			// // GameObject GetOrCreateLightingData()
			// GameObject *HG::Rendering::Runtime::HgSceneLightingData::GetOrCreateLightingData(MethodInfo *method)
			// {
			//   Object_1 *SceneFirstActiveData; // rbx
			//   __int64 v2; // rdx
			//   __int64 v3; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919E39 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D919E39 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1670, 0LL) )
			//   {
			//     SceneFirstActiveData = (Object_1 *)HG::Rendering::Runtime::HgSceneLightingData::GetSceneFirstActiveData(0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( !UnityEngine::Object::op_Inequality(SceneFirstActiveData, 0LL, 0LL) )
			//       return HG::Rendering::Runtime::HgSceneLightingData::CreateLightingDataGameobject(0LL);
			//     if ( SceneFirstActiveData )
			//       return UnityEngine::Component::get_gameObject((Component *)SceneFirstActiveData, 0LL);
			// LABEL_9:
			//     sub_180B536AC(v3, v2);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1670, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_646(Patch, 0LL);
			// }
			// 
			return null;
		}

		public void SetupScene()
		{
			// // Void SetupScene()
			// void HG::Rendering::Runtime::HgSceneLightingData::SetupScene(HgSceneLightingData *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   int32_t i; // esi
			//   List_1_UnityEngine_MeshRenderer_ *meshRenderers; // rax
			//   Object *Item; // r14
			//   HgSceneLightingData_LightmapUsageInfo *meshRendererLightmapUsageInfo; // r15
			//   int32_t Index; // r12d
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   __m128i v12; // xmm6
			//   int32_t j; // esi
			//   List_1_UnityEngine_Terrain_ *terrainRenderers; // rax
			//   Object *v15; // r14
			//   HgSceneLightingData_LightmapUsageInfo *terrainLightmapUsageInfo; // r15
			//   int32_t v17; // r12d
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   __m128i v20; // xmm6
			//   int32_t k; // esi
			//   List_1_UnityEngine_MeshRenderer_ *hlodRenderers; // rax
			//   Object *v23; // r14
			//   HgSceneLightingData_LightmapUsageInfo *hlodLightmapUsageInfo; // r15
			//   int32_t v25; // r12d
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   __m128i v28; // xmm6
			//   Object *v29; // rbx
			//   __int64 v30; // rcx
			//   Il2CppExceptionWrapper *v31; // rdx
			//   String *v32; // rbx
			//   String *v33; // rax
			//   String *v34; // rax
			//   Object *v35; // rbx
			//   __int64 v36; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Il2CppExceptionWrapper *v38; // rdi
			//   Il2CppClass *klass; // rbx
			//   __int64 v40; // rax
			//   Il2CppExceptionWrapper v41; // [rsp+20h] [rbp-68h] BYREF
			//   Il2CppExceptionWrapper *v42[2]; // [rsp+28h] [rbp-60h] BYREF
			//   int v43; // [rsp+38h] [rbp-50h]
			//   __m128i v44; // [rsp+40h] [rbp-48h] BYREF
			//   Vector4 v45; // [rsp+50h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D919E3A )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Debug);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::MeshRenderer>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Terrain>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Terrain>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::MeshRenderer>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18D5ECDE8);
			//     byte_18D919E3A = 1;
			//   }
			//   v43 = 0;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1671, 0LL) )
			//   {
			//     try
			//     {
			//       if ( this.fields.meshRenderers && this.fields.meshRenderers.fields._size > 0 )
			//       {
			//         for ( i = 0; ; ++i )
			//         {
			//           meshRenderers = this.fields.meshRenderers;
			//           if ( !meshRenderers )
			//             sub_180B536AC(v4, v3);
			//           if ( i >= meshRenderers.fields._size )
			//             break;
			//           Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                    (List_1_System_Object_ *)this.fields.meshRenderers,
			//                    i,
			//                    MethodInfo::System::Collections::Generic::List<UnityEngine::MeshRenderer>::get_Item);
			//           meshRendererLightmapUsageInfo = this.fields.meshRendererLightmapUsageInfo;
			//           sub_180002C70(TypeInfo::UnityEngine::Object);
			//           if ( !UnityEngine::Object::op_Equality((Object_1 *)Item, 0LL, 0LL) )
			//           {
			//             if ( !meshRendererLightmapUsageInfo )
			//               sub_180B536AC(v4, v3);
			//             Index = HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::GetIndex(
			//                       meshRendererLightmapUsageInfo,
			//                       i,
			//                       0LL);
			//             v12 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::GetScaleOffset(
			//                                                      &v45,
			//                                                      meshRendererLightmapUsageInfo,
			//                                                      i,
			//                                                      0LL));
			//             if ( !Item )
			//               sub_180B536AC(v11, v10);
			//             UnityEngine::Renderer::SetLightmapIndex((Renderer *)Item, Index, LightmapType__Enum_StaticLightmap, 0LL);
			//             v44 = v12;
			//             UnityEngine::Renderer::set_lightmapScaleOffset((Renderer *)Item, (Vector4 *)&v44, 0LL);
			//           }
			//         }
			//       }
			//       if ( this.fields.terrainRenderers && this.fields.terrainRenderers.fields._size > 0 )
			//       {
			//         for ( j = 0; ; ++j )
			//         {
			//           terrainRenderers = this.fields.terrainRenderers;
			//           if ( !terrainRenderers )
			//             sub_180B536AC(v4, v3);
			//           if ( j >= terrainRenderers.fields._size )
			//             break;
			//           v15 = System::Collections::Generic::List<System::Object>::get_Item(
			//                   (List_1_System_Object_ *)this.fields.terrainRenderers,
			//                   j,
			//                   MethodInfo::System::Collections::Generic::List<UnityEngine::Terrain>::get_Item);
			//           terrainLightmapUsageInfo = this.fields.terrainLightmapUsageInfo;
			//           sub_180002C70(TypeInfo::UnityEngine::Object);
			//           if ( !UnityEngine::Object::op_Equality((Object_1 *)v15, 0LL, 0LL) )
			//           {
			//             if ( !terrainLightmapUsageInfo )
			//               sub_180B536AC(v4, v3);
			//             v17 = HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::GetIndex(
			//                     terrainLightmapUsageInfo,
			//                     j,
			//                     0LL);
			//             v20 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::GetScaleOffset(
			//                                                      &v45,
			//                                                      terrainLightmapUsageInfo,
			//                                                      j,
			//                                                      0LL));
			//             if ( !v15 )
			//               sub_180B536AC(v19, v18);
			//             UnityEngine::Terrain::set_lightmapIndex((Terrain *)v15, v17, 0LL);
			//             v44 = v20;
			//             UnityEngine::Terrain::set_lightmapScaleOffset((Terrain *)v15, (Vector4 *)&v44, 0LL);
			//           }
			//         }
			//       }
			//       if ( this.fields.hlodRenderers && this.fields.hlodRenderers.fields._size > 0 )
			//       {
			//         for ( k = 0; ; ++k )
			//         {
			//           hlodRenderers = this.fields.hlodRenderers;
			//           if ( !hlodRenderers )
			//             sub_180B536AC(v4, v3);
			//           if ( k >= hlodRenderers.fields._size )
			//             break;
			//           v23 = System::Collections::Generic::List<System::Object>::get_Item(
			//                   (List_1_System_Object_ *)this.fields.hlodRenderers,
			//                   k,
			//                   MethodInfo::System::Collections::Generic::List<UnityEngine::MeshRenderer>::get_Item);
			//           hlodLightmapUsageInfo = this.fields.hlodLightmapUsageInfo;
			//           sub_180002C70(TypeInfo::UnityEngine::Object);
			//           if ( !UnityEngine::Object::op_Equality((Object_1 *)v23, 0LL, 0LL) )
			//           {
			//             if ( !hlodLightmapUsageInfo )
			//               sub_180B536AC(v4, v3);
			//             v25 = HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::GetIndex(
			//                     hlodLightmapUsageInfo,
			//                     k,
			//                     0LL);
			//             v28 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::GetScaleOffset(
			//                                                      &v45,
			//                                                      hlodLightmapUsageInfo,
			//                                                      k,
			//                                                      0LL));
			//             if ( !v23 )
			//               sub_180B536AC(v27, v26);
			//             UnityEngine::Renderer::SetLightmapIndex((Renderer *)v23, v25, LightmapType__Enum_StaticLightmap, 0LL);
			//             v44 = v28;
			//             UnityEngine::Renderer::set_lightmapScaleOffset((Renderer *)v23, (Vector4 *)&v44, 0LL);
			//           }
			//         }
			//       }
			//       HG::Rendering::Runtime::HgSceneLightingData::SetSceneLightmapData(this, 0LL);
			//     }
			//     catch ( Il2CppExceptionWrapper *v42 )
			//     {
			//       v38 = v42[0];
			//       klass = v42[0].ex.object.klass;
			//       v40 = sub_18000F7E0(&TypeInfo::System::Exception);
			//       if ( !(unsigned __int8)il2cpp_class_is_assignable_from_0(v40, klass) )
			//       {
			//         v41.ex = v38.ex;
			//         throw &v41;
			//       }
			//       v42[++v43] = (Il2CppExceptionWrapper *)v38.ex;
			//       v30 = v43 - 1;
			//       v31 = v42[v30 + 1];
			//       if ( v31 )
			//       {
			//         v32 = (String *)sub_18003F3E0(5LL, v31);
			//         v33 = (String *)sub_18000F7E0(&off_18D5ECDD8);
			//         v34 = System::String::Concat(v33, v32, 0LL);
			//         v35 = (Object *)HG::Rendering::Runtime::HgSceneLightingData::Log(v34, LogType__Enum_Error, 0LL);
			//         v36 = sub_18000F7E0(&TypeInfo::UnityEngine::Debug);
			//         sub_180002C70(v36);
			//         UnityEngine::Debug::LogError(v35, 0LL);
			//         return;
			//       }
			// LABEL_49:
			//       sub_180B536AC(v30, v31);
			//     }
			//     v29 = (Object *)HG::Rendering::Runtime::HgSceneLightingData::Log(
			//                       (String *)"Setup scene: [OK]. ",
			//                       LogType__Enum_Log,
			//                       0LL);
			//     sub_180002C70(TypeInfo::UnityEngine::Debug);
			//     UnityEngine::Debug::Log(v29, 0LL);
			//     return;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1671, 0LL);
			//   if ( !Patch )
			//     goto LABEL_49;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		public void SetSceneLightmapData()
		{
		}

		private const string MODULE_NAME = "[HG Scene Lighting Data]";

		private const string LIT_DATA_GO_NAME = "!HgSceneLightingData";

		[SerializeField]
		public List<MeshRenderer> meshRenderers;

		[SerializeField]
		public List<Terrain> terrainRenderers;

		[SerializeField]
		public List<MeshRenderer> hlodRenderers;

		[SerializeField]
		[Space]
		public HgSceneLightingData.LightmapUsageInfo meshRendererLightmapUsageInfo;

		[SerializeField]
		public HgSceneLightingData.LightmapUsageInfo terrainLightmapUsageInfo;

		[SerializeField]
		public HgSceneLightingData.LightmapUsageInfo hlodLightmapUsageInfo;

		[Space]
		[SerializeField]
		public List<HgSceneLightingData.HgLightmapData> lightmapData;

		[HideInInspector]
		[SerializeField]
		public List<Renderer> dummyManualHlod;

		[SerializeField]
		public List<Renderer> originalManualHlod;

		[SerializeField]
		public List<HgSceneLightingData.HgChunkLightingData> chunkLightingData;

		[Serializable]
		public class LightmapUsageInfo
		{
			public LightmapUsageInfo()
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}

			public int AddInfo(int index, Vector4 scaleOffset)
			{
				// // Int32 AddInfo(Int32, Vector4)
				// int32_t HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::AddInfo(
				//         HgSceneLightingData_LightmapUsageInfo *this,
				//         int32_t index,
				//         Vector4 *scaleOffset,
				//         MethodInfo *method)
				// {
				//   __int64 v7; // rdx
				//   List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *v8; // rax
				//   List_1_System_Int32_ *lightmapIndex; // rcx
				//   List_1_System_Int32_ *v10; // rdi
				//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
				//   PassConstructorID__Enum__Array *v12; // r8
				//   HGCamera *v13; // r9
				//   LowLevelList_1_System_Object_ *v14; // rax
				//   List_1_UnityEngine_Vector4_ *v15; // rdi
				//   HGRenderPathBase_HGRenderPathResources *v16; // rdx
				//   PassConstructorID__Enum__Array *v17; // r8
				//   HGCamera *v18; // r9
				//   List_1_System_Int32_ *v19; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   MethodInfo *v22; // [rsp+20h] [rbp-28h]
				//   MethodInfo *v23; // [rsp+28h] [rbp-20h]
				//   Vector4 v24; // [rsp+30h] [rbp-18h] BYREF
				// 
				//   if ( !byte_18D919E3C )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Add);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::Add);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::List);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::List);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<int>);
				//     sub_18003C530(&TypeInfo::System::Collections::Generic::List<UnityEngine::Vector4>);
				//     byte_18D919E3C = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(1676, 0LL) )
				//   {
				//     if ( !this.fields.lightmapIndex )
				//     {
				//       v8 = (List_1_Beyond_Gameplay_ZhuangfySleeveSolver_BoneData_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<int>);
				//       v10 = (List_1_System_Int32_ *)v8;
				//       if ( !v8 )
				//         goto LABEL_15;
				//       System::Collections::Generic::List<Beyond::Gameplay::ZhuangfySleeveSolver::BoneData>::List(
				//         v8,
				//         MethodInfo::System::Collections::Generic::List<int>::List);
				//       this.fields.lightmapIndex = v10;
				//       sub_1800054D0((HGRenderPathScene *)&this.fields, v11, v12, v13, v22, v23);
				//     }
				//     lightmapIndex = this.fields.lightmapIndex;
				//     if ( lightmapIndex )
				//     {
				//       sub_18231EF50(lightmapIndex, index);
				//       if ( !this.fields.lightmapScaleOffset )
				//       {
				//         v14 = (LowLevelList_1_System_Object_ *)sub_180004920(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector4>);
				//         v15 = (List_1_UnityEngine_Vector4_ *)v14;
				//         if ( !v14 )
				//           goto LABEL_15;
				//         System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
				//           v14,
				//           MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::List);
				//         this.fields.lightmapScaleOffset = v15;
				//         sub_1800054D0((HGRenderPathScene *)&this.fields.lightmapScaleOffset, v16, v17, v18, v22, v23);
				//       }
				//       lightmapIndex = (List_1_System_Int32_ *)this.fields.lightmapScaleOffset;
				//       if ( lightmapIndex )
				//       {
				//         v24 = *scaleOffset;
				//         sub_182571DC0(lightmapIndex, &v24, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::Add);
				//         v19 = this.fields.lightmapIndex;
				//         if ( v19 )
				//           return v19.fields._size - 1;
				//       }
				//     }
				// LABEL_15:
				//     sub_180B536AC(lightmapIndex, v7);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(1676, 0LL);
				//   if ( !Patch )
				//     goto LABEL_15;
				//   v24 = *scaleOffset;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_648(Patch, (Object *)this, index, &v24, 0LL);
				// }
				// 
				return 0;
			}

			public int GetIndex(int index)
			{
				// // Int32 GetIndex(Int32)
				// int32_t HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::GetIndex(
				//         HgSceneLightingData_LightmapUsageInfo *this,
				//         int32_t index,
				//         MethodInfo *method)
				// {
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v7; // rdx
				//   __int64 v8; // rcx
				// 
				//   if ( !byte_18D919E3D )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Item);
				//     byte_18D919E3D = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1672, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1672, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v8, v7);
				//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_47(
				//              (ILFixDynamicMethodWrapper_20 *)Patch,
				//              (Object *)this,
				//              index,
				//              0LL);
				//   }
				//   else if ( this.fields.lightmapIndex && index < this.fields.lightmapIndex.fields._size )
				//   {
				//     return (int32_t)System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::get_Item(
				//                       (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)this.fields.lightmapIndex,
				//                       index,
				//                       MethodInfo::System::Collections::Generic::List<int>::get_Item);
				//   }
				//   else
				//   {
				//     return -1;
				//   }
				// }
				// 
				return 0;
			}

			public Vector4 GetScaleOffset(int index)
			{
				// // Vector4 GetScaleOffset(Int32)
				// Vector4 *HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::GetScaleOffset(
				//         Vector4 *__return_ptr retstr,
				//         HgSceneLightingData_LightmapUsageInfo *this,
				//         int32_t index,
				//         MethodInfo *method)
				// {
				//   TileBase *v7; // rdx
				//   Vector3Int *v8; // r8
				//   ITilemap *v9; // r9
				//   Vector4 v10; // xmm0
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v12; // rdx
				//   __int64 v13; // rcx
				//   MethodInfo *v15; // [rsp+20h] [rbp-28h]
				//   Vector4 v16; // [rsp+30h] [rbp-18h] BYREF
				// 
				//   if ( !byte_18D919E3E )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::get_Count);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::get_Item);
				//     byte_18D919E3E = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1673, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1673, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v13, v12);
				//     v10 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_519(&v16, Patch, (Object *)this, index, 0LL);
				//     goto LABEL_11;
				//   }
				//   if ( this.fields.lightmapScaleOffset && index < this.fields.lightmapScaleOffset.fields._size )
				//   {
				//     System::Collections::Generic::List<Beyond::Gameplay::MissionSystem::NewMissionTag>::get_Item(
				//       (MissionSystem_NewMissionTag *)&v16,
				//       (List_1_Beyond_Gameplay_MissionSystem_NewMissionTag_ *)this.fields.lightmapScaleOffset,
				//       index,
				//       MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::get_Item);
				//     v10 = v16;
				// LABEL_11:
				//     *retstr = v10;
				//     return retstr;
				//   }
				//   *retstr = *(Vector4 *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
				//                           (TileAnimationData *)&v16,
				//                           v7,
				//                           v8,
				//                           v9,
				//                           v15);
				//   return retstr;
				// }
				// 
				return null;
			}

			public void Remove(int index)
			{
				// // Void Remove(Int32)
				// void HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::Remove(
				//         HgSceneLightingData_LightmapUsageInfo *this,
				//         int32_t index,
				//         MethodInfo *method)
				// {
				//   __int64 v5; // rdx
				//   List_1_System_UInt32_ *lightmapIndex; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D919E3F )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::RemoveAt);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::RemoveAt);
				//     byte_18D919E3F = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(1677, 0LL) )
				//   {
				//     lightmapIndex = (List_1_System_UInt32_ *)this.fields.lightmapIndex;
				//     if ( lightmapIndex )
				//     {
				//       System::Collections::Generic::List<unsigned int>::RemoveAt(
				//         lightmapIndex,
				//         index,
				//         MethodInfo::System::Collections::Generic::List<int>::RemoveAt);
				//       lightmapIndex = (List_1_System_UInt32_ *)this.fields.lightmapScaleOffset;
				//       if ( lightmapIndex )
				//       {
				//         System::Collections::Generic::List<Cinemachine::TargetPositionCache_CacheEntry::RecordingItem>::RemoveAt(
				//           (List_1_Cinemachine_TargetPositionCache_CacheEntry_RecordingItem_ *)lightmapIndex,
				//           index,
				//           MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::RemoveAt);
				//         return;
				//       }
				//     }
				// LABEL_8:
				//     sub_180B536AC(lightmapIndex, v5);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(1677, 0LL);
				//   if ( !Patch )
				//     goto LABEL_8;
				//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, index, 0LL);
				// }
				// 
			}

			public void Clear()
			{
				// // Void Clear()
				// void HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::Clear(
				//         HgSceneLightingData_LightmapUsageInfo *this,
				//         MethodInfo *method)
				// {
				//   List_1_System_Int32_ *lightmapIndex; // rcx
				//   List_1_UnityEngine_Vector4_ *lightmapScaleOffset; // rcx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v6; // rdx
				//   __int64 v7; // rcx
				// 
				//   if ( !byte_18D919E40 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::Clear);
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::Clear);
				//     byte_18D919E40 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1678, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1678, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v7, v6);
				//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     lightmapIndex = this.fields.lightmapIndex;
				//     if ( lightmapIndex )
				//     {
				//       ++lightmapIndex.fields._version;
				//       lightmapIndex.fields._size = 0;
				//     }
				//     lightmapScaleOffset = this.fields.lightmapScaleOffset;
				//     if ( lightmapScaleOffset )
				//     {
				//       ++lightmapScaleOffset.fields._version;
				//       lightmapScaleOffset.fields._size = 0;
				//     }
				//   }
				// }
				// 
			}

			public int Count()
			{
				// // Int32 Count()
				// int32_t HG::Rendering::Runtime::HgSceneLightingData::LightmapUsageInfo::Count(
				//         HgSceneLightingData_LightmapUsageInfo *this,
				//         MethodInfo *method)
				// {
				//   List_1_System_Int32_ *lightmapIndex; // rax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v5; // rdx
				//   __int64 v6; // rcx
				// 
				//   if ( !byte_18D919E41 )
				//   {
				//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<int>::get_Count);
				//     byte_18D919E41 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(1679, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(1679, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v6, v5);
				//     LODWORD(lightmapIndex) = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
				//                                (ILFixDynamicMethodWrapper_29 *)Patch,
				//                                (Object *)this,
				//                                0LL);
				//   }
				//   else
				//   {
				//     lightmapIndex = this.fields.lightmapIndex;
				//     if ( lightmapIndex )
				//       LODWORD(lightmapIndex) = lightmapIndex.fields._size;
				//   }
				//   return (int)lightmapIndex;
				// }
				// 
				return 0;
			}

			[SerializeField]
			public List<int> lightmapIndex;

			[SerializeField]
			public List<Vector4> lightmapScaleOffset;
		}

		[Serializable]
		public class HgLightmapData
		{
			// (get) Token: 0x060008D7 RID: 2263 RVA: 0x000025D2 File Offset: 0x000007D2
			public LightmapData UnityLightmapData
			{
				get
				{
					// // LightmapData get_UnityLightmapData()
					// LightmapData *HG::Rendering::Runtime::HgSceneLightingData::HgLightmapData::get_UnityLightmapData(
					//         HgSceneLightingData_HgLightmapData *this,
					//         MethodInfo *method)
					// {
					//   SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *v3; // rax
					//   __int64 v4; // rdx
					//   __int64 v5; // rcx
					//   ValueWatcher_1_System_Single_ *v6; // rbx
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					// 
					//   if ( !byte_18D919E42 )
					//   {
					//     sub_18003C530(&TypeInfo::UnityEngine::LightmapData);
					//     byte_18D919E42 = 1;
					//   }
					//   if ( !IFix::WrappersManagerImpl::IsPatched(1675, 0LL) )
					//   {
					//     v3 = (SortedList_2_TKey_TValue_ValueList_System_Object_System_Object_ *)sub_180004920(TypeInfo::UnityEngine::LightmapData);
					//     v6 = (ValueWatcher_1_System_Single_ *)v3;
					//     if ( v3 )
					//     {
					//       System::Collections::Generic::SortedList_2_TKey_TValue_::ValueList<System::Object,System::Object>::ValueList(
					//         v3,
					//         (SortedList_2_System_Object_System_Object_ *)this.fields.color,
					//         0LL);
					//       Rewired::Utils::Classes::Utility::ValueWatcher<float>::set_getValueDelegate(
					//         v6,
					//         (Func_1_Single_ *)this.fields.shadowmask,
					//         0LL);
					//       Rewired::Utils::Classes::Utility::ValueWatcher<bool>::set_getValueDelegate(
					//         (ValueWatcher_1_System_Boolean_ *)v6,
					//         (Func_1_Boolean_ *)this.fields.directional,
					//         0LL);
					//       return (LightmapData *)v6;
					//     }
					// LABEL_7:
					//     sub_180B536AC(v5, v4);
					//   }
					//   Patch = IFix::WrappersManagerImpl::GetPatch(1675, 0LL);
					//   if ( !Patch )
					//     goto LABEL_7;
					//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_647(Patch, (Object *)this, 0LL);
					// }
					// 
					return null;
				}
			}

			public HgLightmapData()
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}

			public HgLightmapData(LightmapData unityLmData)
			{
				// // HgSceneLightingData+HgLightmapData(LightmapData)
				// void HG::Rendering::Runtime::HgSceneLightingData::HgLightmapData::HgLightmapData(
				//         HgSceneLightingData_HgLightmapData *this,
				//         LightmapData *unityLmData,
				//         MethodInfo *method)
				// {
				//   HG::Rendering::Runtime::HgSceneLightingData::HgLightmapData::Assign(this, unityLmData, 0LL);
				// }
				// 
			}

			public void Assign(LightmapData unityLmData)
			{
			}

			public static HgSceneLightingData.HgLightmapData CreateFromUnityLightmapData(LightmapData unityLmData)
			{
				// // HgSceneLightingData+HgLightmapData CreateFromUnityLightmapData(LightmapData)
				// HgSceneLightingData_HgLightmapData *HG::Rendering::Runtime::HgSceneLightingData::HgLightmapData::CreateFromUnityLightmapData(
				//         LightmapData *unityLmData,
				//         MethodInfo *method)
				// {
				//   HgSceneLightingData_HgLightmapData *v3; // rax
				//   __int64 v4; // rdx
				//   __int64 v5; // rcx
				//   HgSceneLightingData_HgLightmapData *v6; // rbx
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				// 
				//   if ( !byte_18D919E43 )
				//   {
				//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HgSceneLightingData::HgLightmapData);
				//     byte_18D919E43 = 1;
				//   }
				//   if ( !IFix::WrappersManagerImpl::IsPatched(1681, 0LL) )
				//   {
				//     v3 = (HgSceneLightingData_HgLightmapData *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HgSceneLightingData::HgLightmapData);
				//     v6 = v3;
				//     if ( v3 )
				//     {
				//       HG::Rendering::Runtime::HgSceneLightingData::HgLightmapData::Assign(v3, unityLmData, 0LL);
				//       return v6;
				//     }
				// LABEL_7:
				//     sub_180B536AC(v5, v4);
				//   }
				//   Patch = IFix::WrappersManagerImpl::GetPatch(1681, 0LL);
				//   if ( !Patch )
				//     goto LABEL_7;
				//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_649(Patch, (Object *)unityLmData, 0LL);
				// }
				// 
				return null;
			}

			public Texture2D color;

			public Texture2D shadowmask;

			public Texture2D directional;
		}

		public class HgChunkLightingData
		{
			public HgChunkLightingData()
			{
				// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
				// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
				//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
				//         HGWindConfig *cSrc,
				//         HGWindConfig *cDst,
				//         float t,
				//         MethodInfo *method)
				// {
				//   ;
				// }
				// 
			}

			public float x;

			public float z;

			public float size;

			public List<Renderer> renderers;

			public List<List<int>> groupIndex;

			public int lightmapCount;
		}
	}
}
