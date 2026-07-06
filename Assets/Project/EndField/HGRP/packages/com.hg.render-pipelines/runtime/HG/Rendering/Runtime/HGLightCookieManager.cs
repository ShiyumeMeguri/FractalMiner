using System;
using System.Collections.Generic;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGLightCookieManager
	{
		internal HGLightCookieManager()
		{
		}

		internal void Dispose()
		{
		}

		internal int GetLightCookieIndex(Entity light)
		{
			// // Int32 GetLightCookieIndex(Entity)
			// int32_t HG::Rendering::Runtime::HGLightCookieManager::GetLightCookieIndex(
			//         HGLightCookieManager *this,
			//         Entity_1 light,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !byte_18D919E21 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::CollectionExtensions::GetValueOrDefault<UnityEngine::HyperGryph::ECS::Entity,int>);
			//     byte_18D919E21 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1588, 0LL) )
			//     return System::Collections::Generic::CollectionExtensions::GetValueOrDefault<UnityEngine::HyperGryph::ECS::Entity,int>(
			//              (IReadOnlyDictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Int32_ *)this.fields.m_lightSlots,
			//              light,
			//              -1,
			//              MethodInfo::System::Collections::Generic::CollectionExtensions::GetValueOrDefault<UnityEngine::HyperGryph::ECS::Entity,int>);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1588, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v8, v7);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_605(Patch, (Object *)this, light, 0LL);
			// }
			// 
			return 0;
		}

		private bool IsLightCookiesEnabled(HGSettingParameters settingParams)
		{
			// // Boolean IsLightCookiesEnabled(HGSettingParameters)
			// bool HG::Rendering::Runtime::HGLightCookieManager::IsLightCookiesEnabled(
			//         HGLightCookieManager *this,
			//         HGSettingParameters *settingParams,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1589, 0LL) )
			//     return !UnityEngine::Rendering::GraphicsSettings::HasShaderDefine(
			//               BuiltinShaderDefine__Enum_HG_RENDER_PATH_MOBILE,
			//               0LL);
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1589, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v8, v7);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//            (ILFixDynamicMethodWrapper_36 *)Patch,
			//            (Object *)this,
			//            (Object *)settingParams,
			//            0LL);
			// }
			// 
			return default(bool);
		}

		public void InvalidateAllLightCookies()
		{
			// // Void InvalidateAllLightCookies()
			// void HG::Rendering::Runtime::HGLightCookieManager::InvalidateAllLightCookies(
			//         HGLightCookieManager *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   AtlasMaxRect *m_lightCookieAtlasAllocator; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDCE5 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,int>::Clear);
			//     byte_18D8EDCE5 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1590, 0LL) )
			//   {
			//     m_lightCookieAtlasAllocator = this.fields.m_lightCookieAtlasAllocator;
			//     if ( m_lightCookieAtlasAllocator )
			//     {
			//       HG::Rendering::Runtime::AtlasMaxRect::Reset(m_lightCookieAtlasAllocator, 0LL);
			//       m_lightCookieAtlasAllocator = (AtlasMaxRect *)this.fields.m_activeLightCookies;
			//       if ( m_lightCookieAtlasAllocator )
			//       {
			//         System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::Clear(
			//           (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)m_lightCookieAtlasAllocator,
			//           MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::Clear);
			//         m_lightCookieAtlasAllocator = (AtlasMaxRect *)this.fields.m_lightSlots;
			//         if ( m_lightCookieAtlasAllocator )
			//         {
			//           System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::Clear(
			//             (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)m_lightCookieAtlasAllocator,
			//             MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,int>::Clear);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_8:
			//     sub_180B536AC(m_lightCookieAtlasAllocator, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1590, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		internal void PrepareLightCookies(NativeArray<VisibleLight> visibleLights, HGCamera hgCamera, HGSettingParameters settingParams, NativeArray<int> lightIndices, int punctualLightCount)
		{
			// // Void PrepareLightCookies(NativeArray`1[UnityEngine.Rendering.VisibleLight], HGCamera, HGSettingParameters, NativeArray`1[System.Int32], Int32)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGLightCookieManager::PrepareLightCookies(
			//         HGLightCookieManager *this,
			//         NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights,
			//         HGCamera *hgCamera,
			//         HGSettingParameters *settingParams,
			//         NativeArray_1_System_Int32_ *lightIndices,
			//         int32_t punctualLightCount,
			//         MethodInfo *method)
			// {
			//   HGLightCookieManager *v10; // r14
			//   Object_1 *m_cachedLightCookieAtlas; // rbx
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   GraphicsFormat__Enum m_lightCookieColorFormat; // edi
			//   Texture2D *v15; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   Texture2D *v18; // rbx
			//   OneofDescriptorProto *v19; // rdx
			//   FileDescriptor *v20; // r8
			//   MessageDescriptor *v21; // r9
			//   __int64 v22; // rdx
			//   __int64 v23; // rcx
			//   __int64 v24; // rdx
			//   __int64 v25; // rcx
			//   __int64 v26; // rdx
			//   __int64 v27; // rcx
			//   __int64 v28; // rdi
			//   Void *m_Buffer; // r13
			//   Void *v30; // r12
			//   Void *v31; // rax
			//   Object_1 *cookie_Injected; // rbx
			//   Object *v33; // rax
			//   __int64 v34; // rdx
			//   __int64 v35; // rcx
			//   Object *v36; // rbx
			//   __int64 v37; // rdx
			//   __int64 v38; // rcx
			//   List_1_System_Object_ *m_texturesInUse; // r15
			//   List_1_System_Object_ *v40; // rcx
			//   __int64 v41; // rdx
			//   Object *v42; // rbx
			//   List_1_System_Object_ *v43; // rcx
			//   __int64 v44; // rdx
			//   List_1_System_Object_ *m_texturesToBeRemoved; // rcx
			//   List_1_System_Object_ *v46; // rdx
			//   __int64 v47; // rcx
			//   __int64 v48; // r8
			//   Object *current; // rdi
			//   AtlasMaxRect *m_lightCookieAtlasAllocator; // rbx
			//   Dictionary_2_System_Object_UnityEngine_RectInt_ *m_activeLightCookies; // rdx
			//   __int64 v52; // rdx
			//   __int64 v53; // rcx
			//   __int64 v54; // rdx
			//   Dictionary_2_System_Object_UnityEngine_RectInt_ *v55; // rcx
			//   List_1_UnityEngine_Texture_ *m_texturesToBeAdded; // rax
			//   Object *v57; // rax
			//   String *v58; // rax
			//   int32_t v59; // r15d
			//   int32_t i; // r13d
			//   int size; // r12d
			//   Dictionary_2_UnityEngine_Texture_UnityEngine_RectInt_ *v62; // rdi
			//   int32_t count; // ebx
			//   int32_t freeCount; // edi
			//   int v65; // edi
			//   Object *Item; // rbx
			//   int v67; // eax
			//   AtlasMaxRect *v68; // rdi
			//   int32_t v69; // r12d
			//   int32_t v70; // eax
			//   int32_t v71; // r8d
			//   Vector4 *p_ex; // rcx
			//   int v73; // r12d
			//   RectInt v74; // xmm1
			//   List_1_UnityEngine_Texture_ *v75; // rax
			//   __int64 v76; // rdx
			//   __int64 v77; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rbx
			//   String__Array *v79[7]; // [rsp+0h] [rbp-1C8h] BYREF
			//   HGSharedLightData _unity_self; // [rsp+40h] [rbp-188h] BYREF
			//   Il2CppException *ex; // [rsp+48h] [rbp-180h] BYREF
			//   void *v82; // [rsp+50h] [rbp-178h]
			//   int v83; // [rsp+58h] [rbp-170h] BYREF
			//   Vector4 value; // [rsp+60h] [rbp-168h] BYREF
			//   Object *key; // [rsp+70h] [rbp-158h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ v86; // [rsp+80h] [rbp-148h] BYREF
			//   List_1_T_Enumerator_System_Object_ v87; // [rsp+B0h] [rbp-118h] BYREF
			//   HGLightCookieManager *v88; // [rsp+C8h] [rbp-100h]
			//   Dictionary_2_TKey_TValue_Enumerator_System_Object_UnityEngine_RectInt_ v89; // [rsp+D0h] [rbp-F8h] BYREF
			//   Il2CppExceptionWrapper *v90; // [rsp+100h] [rbp-C8h] BYREF
			//   Il2CppExceptionWrapper *v91; // [rsp+108h] [rbp-C0h] BYREF
			//   __int128 v92; // [rsp+110h] [rbp-B8h]
			//   __int128 v93; // [rsp+120h] [rbp-A8h]
			//   __int128 v94; // [rsp+130h] [rbp-98h]
			//   __int128 v95; // [rsp+140h] [rbp-88h]
			//   __int128 v96; // [rsp+150h] [rbp-78h]
			//   __int128 v97; // [rsp+160h] [rbp-68h]
			//   __int128 v98; // [rsp+170h] [rbp-58h]
			//   __int128 v99; // [rsp+180h] [rbp-48h]
			//   __int128 v100; // [rsp+190h] [rbp-38h]
			//   int v101; // [rsp+1A0h] [rbp-28h]
			// 
			//   v10 = this;
			//   v88 = this;
			//   if ( !byte_18D919E22 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::set_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Texture,UnityEngine::RectInt>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Texture>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Texture>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Texture,UnityEngine::RectInt>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Texture>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Texture,UnityEngine::RectInt>::get_Current);
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Texture,UnityEngine::RectInt>::Deconstruct);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::Contains);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::get_Item);
			//     sub_18003C530(&TypeInfo::System::Math);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafePtr<UnityEngine::Rendering::VisibleLight>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::UnityEngine::Texture2D);
			//     sub_18003C530(&off_18D5ECF60);
			//     sub_18003C530(&off_18D5ECFA8);
			//     byte_18D919E22 = 1;
			//   }
			//   _unity_self = 0LL;
			//   key = 0LL;
			//   value = 0LL;
			//   memset(&v87, 0, sizeof(v87));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1591, 0LL) )
			//   {
			//     m_cachedLightCookieAtlas = (Object_1 *)v10.fields.m_cachedLightCookieAtlas;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     if ( UnityEngine::Object::op_Equality(m_cachedLightCookieAtlas, 0LL, 0LL) )
			//     {
			//       m_lightCookieColorFormat = v10.fields.m_lightCookieColorFormat;
			//       v15 = (Texture2D *)sub_180004920(TypeInfo::UnityEngine::Texture2D);
			//       v18 = v15;
			//       if ( !v15 )
			//         sub_180B536AC(v17, v16);
			//       UnityEngine::Texture2D::Texture2D(v15, 4096, 4096, m_lightCookieColorFormat, TextureCreationFlags__Enum_None, 0LL);
			//       v10.fields.m_cachedLightCookieAtlas = v18;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&v10.fields.m_cachedLightCookieAtlas,
			//         v19,
			//         v20,
			//         v21,
			//         v79[4],
			//         (String *)v79[5],
			//         (MethodInfo *)v79[6]);
			//       HG::Rendering::Runtime::HGLightCookieManager::InvalidateAllLightCookies(v10, 0LL);
			//     }
			//     if ( !v10.fields.m_texturesInUse )
			//       sub_180B536AC(v13, v12);
			//     sub_1823B99D0(
			//       v10.fields.m_texturesInUse,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::Clear);
			//     if ( !v10.fields.m_texturesToBeRemoved )
			//       sub_180B536AC(v23, v22);
			//     sub_1823B99D0(
			//       v10.fields.m_texturesToBeRemoved,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::Clear);
			//     if ( !v10.fields.m_texturesToBeAdded )
			//       sub_180B536AC(v25, v24);
			//     sub_1823B99D0(
			//       v10.fields.m_texturesToBeAdded,
			//       MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::Clear);
			//     v28 = punctualLightCount;
			//     if ( punctualLightCount > 0 )
			//     {
			//       m_Buffer = visibleLights.m_Buffer;
			//       v30 = lightIndices.m_Buffer;
			//       do
			//       {
			//         v31 = &m_Buffer[148 * *(_DWORD *)v30];
			//         v92 = *(_OWORD *)v31;
			//         v93 = *(_OWORD *)&v31[16];
			//         v94 = *(_OWORD *)&v31[32];
			//         v95 = *(_OWORD *)&v31[48];
			//         v96 = *(_OWORD *)&v31[64];
			//         v97 = *(_OWORD *)&v31[80];
			//         v98 = *(_OWORD *)&v31[96];
			//         v99 = *(_OWORD *)&v31[112];
			//         v100 = *(_OWORD *)&v31[128];
			//         v101 = *(_DWORD *)&v31[144];
			//         _unity_self = (HGSharedLightData)*((_QWORD *)&v100 + 1);
			//         cookie_Injected = (Object_1 *)UnityEngine::HGSharedLightData::get_cookie_Injected(&_unity_self, 0LL);
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( UnityEngine::Object::op_Inequality(cookie_Injected, 0LL, 0LL)
			//           && (UnityEngine::HGSharedLightData::get_type_Injected(&_unity_self, 0LL) == LightType__Enum_Spot
			//            || UnityEngine::HGSharedLightData::get_type_Injected(&_unity_self, 0LL) == LightType__Enum_Point) )
			//         {
			//           v33 = (Object *)UnityEngine::HGSharedLightData::get_cookie_Injected(&_unity_self, 0LL);
			//           v36 = v33;
			//           if ( !v10.fields.m_activeLightCookies )
			//             sub_180B536AC(v35, v34);
			//           if ( System::Collections::Generic::Dictionary<System::Object,UnityEngine::RectInt>::ContainsKey(
			//                  (Dictionary_2_System_Object_UnityEngine_RectInt_ *)v10.fields.m_activeLightCookies,
			//                  v33,
			//                  MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::ContainsKey) )
			//           {
			//             goto LABEL_21;
			//           }
			//           if ( !v10.fields.m_texturesToBeAdded )
			//             sub_180B536AC(v38, v37);
			//           if ( System::Collections::Generic::List<System::Object>::Contains(
			//                  (List_1_System_Object_ *)v10.fields.m_texturesToBeAdded,
			//                  v36,
			//                  MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::Contains) )
			//           {
			// LABEL_21:
			//             m_texturesInUse = (List_1_System_Object_ *)v10.fields.m_texturesInUse;
			//             if ( !m_texturesInUse )
			//               sub_180B536AC(v38, v37);
			//           }
			//           else
			//           {
			//             m_texturesInUse = (List_1_System_Object_ *)v10.fields.m_texturesToBeAdded;
			//             if ( !m_texturesInUse )
			//               sub_180B536AC(v38, v37);
			//           }
			//           sub_1822AD140(m_texturesInUse, v36);
			//         }
			//         v30 += 4;
			//         --v28;
			//       }
			//       while ( v28 );
			//     }
			//     if ( !v10.fields.m_activeLightCookies )
			//       sub_180B536AC(v27, v26);
			//     System::Collections::Generic::Dictionary<Beyond::Gameplay::Core::WaterVolumePtr,System::ValueTuple<float,System::Int32Enum,System::Object>>::GetEnumerator(
			//       &v86,
			//       (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)v10.fields.m_activeLightCookies,
			//       MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::GetEnumerator);
			//     v89 = (Dictionary_2_TKey_TValue_Enumerator_System_Object_UnityEngine_RectInt_)v86;
			//     ex = 0LL;
			//     v82 = &v89;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,UnityEngine::RectInt>::MoveNext(
			//                 &v89,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Texture,UnityEngine::RectInt>::MoveNext) )
			//       {
			//         *(_OWORD *)&v86._dictionary = *(_OWORD *)&v89._current.key;
			//         v86._current.key.id = *(_QWORD *)&v89._current.value.m_Width;
			//         System::Collections::Generic::KeyValuePair<System::Object,UnityEngine::Vector4>::Deconstruct(
			//           (KeyValuePair_2_System_Object_UnityEngine_Vector4_ *)&v86,
			//           &key,
			//           &value,
			//           MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Texture,UnityEngine::RectInt>::Deconstruct);
			//         v42 = key;
			//         v43 = (List_1_System_Object_ *)v10.fields.m_texturesInUse;
			//         if ( !v43 )
			//           sub_1802DC2C8(0LL, v41);
			//         if ( !System::Collections::Generic::List<System::Object>::Contains(
			//                 v43,
			//                 key,
			//                 MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::Contains) )
			//         {
			//           m_texturesToBeRemoved = (List_1_System_Object_ *)v10.fields.m_texturesToBeRemoved;
			//           if ( !m_texturesToBeRemoved )
			//             sub_1802DC2C8(0LL, v44);
			//           sub_1822AD140(m_texturesToBeRemoved, v42);
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v90 )
			//     {
			//       ex = v90.ex;
			//       v40 = (List_1_System_Object_ *)ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       v10 = this;
			//     }
			//     v46 = (List_1_System_Object_ *)v10.fields.m_texturesToBeRemoved;
			//     if ( v46 )
			//     {
			//       System::Collections::Generic::List<System::Object>::GetEnumerator(
			//         (List_1_T_Enumerator_System_Object_ *)&v86,
			//         v46,
			//         MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::GetEnumerator);
			//       *(_OWORD *)&v87._list = *(_OWORD *)&v86._dictionary;
			//       v87._current = (Object *)v86._current.key.id;
			//       ex = 0LL;
			//       v82 = &v87;
			//       try
			//       {
			//         while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
			//                   &v87,
			//                   MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Texture>::MoveNext) )
			//         {
			//           current = v87._current;
			//           m_lightCookieAtlasAllocator = v10.fields.m_lightCookieAtlasAllocator;
			//           m_activeLightCookies = (Dictionary_2_System_Object_UnityEngine_RectInt_ *)v10.fields.m_activeLightCookies;
			//           if ( !m_activeLightCookies )
			//             sub_1802DC2C8(v47, 0LL);
			//           System::Collections::Generic::Dictionary<System::Object,UnityEngine::RectInt>::get_Item(
			//             (RectInt *)&v86,
			//             m_activeLightCookies,
			//             v87._current,
			//             MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::get_Item);
			//           value = *(Vector4 *)&v86._dictionary;
			//           if ( !m_lightCookieAtlasAllocator )
			//             sub_1802DC2C8(v53, v52);
			//           HG::Rendering::Runtime::AtlasMaxRect::RemoveRect(m_lightCookieAtlasAllocator, (RectInt *)&value, 0LL);
			//           v55 = (Dictionary_2_System_Object_UnityEngine_RectInt_ *)v10.fields.m_activeLightCookies;
			//           if ( !v55 )
			//             sub_1802DC2C8(0LL, v54);
			//           System::Collections::Generic::Dictionary<System::Object,UnityEngine::RectInt>::Remove(
			//             v55,
			//             current,
			//             MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::Remove);
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v91 )
			//       {
			//         v46 = (List_1_System_Object_ *)v79;
			//         ex = v91.ex;
			//         if ( ex )
			//           sub_18000F780(ex);
			//         v10 = this;
			//       }
			//       v40 = (List_1_System_Object_ *)v10.fields.m_activeLightCookies;
			//       if ( v40 )
			//       {
			//         m_texturesToBeAdded = v10.fields.m_texturesToBeAdded;
			//         if ( m_texturesToBeAdded )
			//         {
			//           if ( LODWORD(v40.fields._syncRoot) + m_texturesToBeAdded.fields._size - LODWORD(v40[1].klass) > 32 )
			//           {
			//             v83 = 32;
			//             v57 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v83, v48);
			//             v58 = System::String::Format(
			//                     (String *)"HGLightCookieManager: 当前帧尝试创建的Light Cookie数量超过{0}，请灯光师检查一下灯光状态。",
			//                     v57,
			//                     0LL);
			//             HG::Rendering::HGRPLogger::LogWarning(v58, 0LL);
			//           }
			//           v59 = 0;
			//           for ( i = 0; ; i = v59 )
			//           {
			//             v75 = v10.fields.m_texturesToBeAdded;
			//             if ( !v75 )
			//               break;
			//             size = v75.fields._size;
			//             v62 = v10.fields.m_activeLightCookies;
			//             if ( !v62 )
			//               break;
			//             count = v62.fields._count;
			//             freeCount = v62.fields._freeCount;
			//             sub_180002C70(TypeInfo::System::Math);
			//             v65 = freeCount - count + 32;
			//             if ( size > v65 )
			//               size = v65;
			//             if ( i >= size )
			//               return;
			//             v40 = (List_1_System_Object_ *)v10.fields.m_texturesToBeAdded;
			//             if ( !v40 )
			//               break;
			//             Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                      v40,
			//                      v59,
			//                      MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::get_Item);
			//             if ( !Item )
			//               break;
			//             v67 = sub_18003ED00(9LL);
			//             v68 = v88.fields.m_lightCookieAtlasAllocator;
			//             if ( v67 == 4 )
			//             {
			//               v73 = sub_18003ED00(5LL);
			//               v70 = sub_18003ED00(7LL);
			//               if ( !v68 )
			//                 break;
			//               v71 = 6 * v73;
			//               p_ex = (Vector4 *)&ex;
			//             }
			//             else
			//             {
			//               v69 = sub_18003ED00(5LL);
			//               v70 = sub_18003ED00(7LL);
			//               if ( !v68 )
			//                 break;
			//               v71 = v69;
			//               p_ex = &value;
			//             }
			//             v74 = *HG::Rendering::Runtime::AtlasMaxRect::InsertRect((RectInt *)p_ex, v68, v71, v70, 0LL);
			//             if ( _mm_cvtsi128_si32(_mm_srli_si128((__m128i)v74, 8)) )
			//             {
			//               v40 = (List_1_System_Object_ *)v10.fields.m_activeLightCookies;
			//               if ( !v40 )
			//                 break;
			//               *(RectInt *)&v86._dictionary = v74;
			//               System::Collections::Generic::Dictionary<System::Object,UnityEngine::RectInt>::set_Item(
			//                 (Dictionary_2_System_Object_UnityEngine_RectInt_ *)v40,
			//                 Item,
			//                 (RectInt *)&v86,
			//                 MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::set_Item);
			//             }
			//             else
			//             {
			//               HG::Rendering::HGRPLogger::LogWarning(
			//                 (String *)"HGLightCookieManager: 由于LightCookie Atlas空间已占满，尝试创建Light Cookie失败，请灯光师检查一下灯光状态。",
			//                 0LL);
			//             }
			//             ++v59;
			//           }
			//         }
			//       }
			//     }
			//     sub_1802DC2C8(v40, v46);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1591, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v77, v76);
			//   *(NativeArray_1_System_Int32_ *)&v86._dictionary = *lightIndices;
			//   value = (Vector4)*visibleLights;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_606(
			//     Patch,
			//     (Object *)v10,
			//     (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&value,
			//     (Object *)hgCamera,
			//     (Object *)settingParams,
			//     (NativeArray_1_System_Int32_ *)&v86,
			//     punctualLightCount,
			//     0LL);
			// }
			// 
		}

		internal void UpdateLightCookieAtlas(HGRenderGraph renderGraph, NativeArray<VisibleLight> visibleLights, HGCamera hgCamera, HGSettingParameters settingParams, NativeArray<int> lightIndices, int punctualLightCount)
		{
			// // Void UpdateLightCookieAtlas(HGRenderGraph, NativeArray`1[UnityEngine.Rendering.VisibleLight], HGCamera, HGSettingParameters, NativeArray`1[System.Int32], Int32)
			// // Hidden C++ exception states: #wind=2
			// void HG::Rendering::Runtime::HGLightCookieManager::UpdateLightCookieAtlas(
			//         HGLightCookieManager *this,
			//         HGRenderGraph *renderGraph,
			//         NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights,
			//         HGCamera *hgCamera,
			//         HGSettingParameters *settingParams,
			//         NativeArray_1_System_Int32_ *lightIndices,
			//         int32_t punctualLightCount,
			//         MethodInfo *method)
			// {
			//   Object *v10; // r13
			//   HGLightCookieManager *v11; // r14
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   List_1_UnityEngine_Texture_ *m_texturesToBeAdded; // rbx
			//   int32_t i; // esi
			//   List_1_UnityEngine_Texture_ *v16; // rbx
			//   Object *Item; // rax
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   Object *v20; // rbx
			//   __int64 v21; // rdx
			//   HGLightCookieManager__StaticFields *v22; // rcx
			//   __int64 v23; // rdx
			//   HGLightCookieManager__StaticFields *static_fields; // rcx
			//   Texture__Array *s_srcTextures; // r15
			//   __int64 v26; // rdx
			//   HGLightCookieManager__StaticFields *v27; // rcx
			//   Vector2Int__Array *s_srcDimensions; // r15
			//   __int64 v29; // rdx
			//   __int64 v30; // rcx
			//   Vector2Int__Array *s_dstPositions; // r15
			//   int2 xy; // rax
			//   int2 v33; // rdx
			//   int2 v34; // rcx
			//   Vector2Int__Array *s_dstDimensions; // r15
			//   Vector2Int size; // rbx
			//   ProfilingSampler *v37; // rax
			//   __int64 v38; // rdx
			//   __int64 v39; // rcx
			//   __int64 v40; // rcx
			//   Object *v41; // rdx
			//   unsigned __int64 v42; // rdx
			//   unsigned __int64 v43; // r8
			//   char v44; // dl
			//   signed __int64 v45; // rtt
			//   Object *v46; // rbx
			//   __int64 v47; // rdx
			//   HGLightCookieManager__StaticFields *v48; // rcx
			//   unsigned __int64 v49; // rdx
			//   unsigned __int64 v50; // r8
			//   signed __int64 v51; // rtt
			//   Object *v52; // r8
			//   HGLightCookieManager__StaticFields *v53; // rcx
			//   unsigned __int64 v54; // rdx
			//   unsigned __int64 v55; // r8
			//   char v56; // dl
			//   signed __int64 v57; // rtt
			//   Object *v58; // r8
			//   HGLightCookieManager__StaticFields *v59; // rcx
			//   unsigned __int64 v60; // rdx
			//   unsigned __int64 v61; // r8
			//   char v62; // dl
			//   signed __int64 v63; // rtt
			//   Object *v64; // r8
			//   signed __int64 v65; // rcx
			//   unsigned __int64 v66; // rdx
			//   unsigned __int64 v67; // r8
			//   signed __int64 v68; // rtt
			//   List_1_UnityEngine_Texture_ *v69; // rax
			//   __int64 v70; // rcx
			//   ProfilingSampler *v71; // rax
			//   __int64 v72; // rdx
			//   __int64 v73; // rcx
			//   __int64 v74; // rdx
			//   Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *m_lightSlots; // rcx
			//   __int64 v76; // rcx
			//   int32_t v77; // r12d
			//   int32_t j; // eax
			//   Void *v79; // rax
			//   Entity_1 Entity; // rbx
			//   Object *cookie_Injected; // r13
			//   __int64 v82; // rdx
			//   Dictionary_2_System_Object_UnityEngine_RectInt_ *m_activeLightCookies; // rcx
			//   __int64 v84; // rdx
			//   __int64 v85; // r8
			//   Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Int32_ *v86; // rcx
			//   __int64 v87; // rdx
			//   Vector4__Array *s_lightCookieData; // rcx
			//   Matrix4x4__Array *s_lightCookieMatricesData; // rbx
			//   Matrix4x4 *v90; // rax
			//   __int64 v91; // rdx
			//   __int64 v92; // rcx
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   __int128 v94; // xmm9
			//   __int128 v95; // xmm10
			//   __int128 v96; // xmm11
			//   __int128 v97; // xmm12
			//   float spotAngle_Injected; // xmm13_4
			//   float shadowNearPlane_Injected; // xmm8_4
			//   float shadowFarPlane_Injected; // xmm7_4
			//   float shadowGuardAngle_Injected; // xmm6_4
			//   Matrix4x4__Array *v102; // rbx
			//   Matrix4x4 *ShadowTransform; // rax
			//   __int64 v104; // rdx
			//   __int64 v105; // rcx
			//   Object *v106; // rax
			//   String *v107; // rax
			//   Object *v108; // rdx
			//   unsigned __int64 v109; // rdx
			//   unsigned __int64 v110; // r8
			//   char v111; // dl
			//   signed __int64 v112; // rtt
			//   Object *v113; // rbx
			//   __int64 v114; // rdx
			//   HGLightCookieManager__StaticFields *v115; // rcx
			//   __int64 v116; // rdx
			//   unsigned __int64 v117; // r8
			//   signed __int64 v118; // rtt
			//   Object *v119; // r8
			//   HGLightCookieManager__StaticFields *v120; // rcx
			//   unsigned __int64 v121; // rdx
			//   unsigned __int64 v122; // r8
			//   char v123; // dl
			//   signed __int64 v124; // rtt
			//   __int64 v125; // rdx
			//   __int64 v126; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rbx
			//   Vector2Int v128; // [rsp+50h] [rbp-408h] BYREF
			//   HGSharedLightData _unity_self; // [rsp+58h] [rbp-400h] BYREF
			//   Object *v130; // [rsp+60h] [rbp-3F8h] BYREF
			//   NativeArray_1_System_Int32_ v131; // [rsp+70h] [rbp-3E8h] BYREF
			//   RectInt value; // [rsp+80h] [rbp-3D8h] BYREF
			//   Object *v133; // [rsp+90h] [rbp-3C8h] BYREF
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ v134; // [rsp+A0h] [rbp-3B8h] BYREF
			//   RectInt v135; // [rsp+B0h] [rbp-3A8h] BYREF
			//   NativeArray_1_System_Int32_ v136; // [rsp+C0h] [rbp-398h] BYREF
			//   Matrix4x4 v137; // [rsp+D0h] [rbp-388h] BYREF
			//   HGRenderGraphBuilder v138; // [rsp+110h] [rbp-348h] BYREF
			//   Matrix4x4 v139; // [rsp+130h] [rbp-328h] BYREF
			//   HGRenderGraphBuilder v140; // [rsp+170h] [rbp-2E8h] BYREF
			//   HGRenderGraphBuilder v141; // [rsp+190h] [rbp-2C8h] BYREF
			//   Il2CppExceptionWrapper *v142; // [rsp+1B0h] [rbp-2A8h] BYREF
			//   Il2CppExceptionWrapper *v143; // [rsp+1B8h] [rbp-2A0h] BYREF
			//   Matrix4x4 v144; // [rsp+1C0h] [rbp-298h] BYREF
			//   Matrix4x4 v145; // [rsp+200h] [rbp-258h] BYREF
			//   Matrix4x4 v146; // [rsp+240h] [rbp-218h] BYREF
			//   Matrix4x4 v147; // [rsp+280h] [rbp-1D8h] BYREF
			//   Matrix4x4 v148; // [rsp+2C0h] [rbp-198h] BYREF
			//   __int128 v149; // [rsp+300h] [rbp-158h]
			//   __int128 v150; // [rsp+310h] [rbp-148h]
			//   __int128 v151; // [rsp+320h] [rbp-138h]
			//   __int128 v152; // [rsp+330h] [rbp-128h]
			//   __int128 v153; // [rsp+340h] [rbp-118h]
			//   __int128 v154; // [rsp+350h] [rbp-108h]
			//   __int128 v155; // [rsp+360h] [rbp-F8h]
			//   __int128 v156; // [rsp+370h] [rbp-E8h]
			//   __int128 v157; // [rsp+380h] [rbp-D8h]
			//   int v158; // [rsp+390h] [rbp-C8h]
			// 
			//   v10 = (Object *)renderGraph;
			//   v11 = this;
			//   if ( !byte_18D919E23 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::TryGetValue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGLightCookieManager::LightCookieSetDataPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGLightCookieManager::UpdateLightCookieAtlasPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGLightCookieManager::LightCookieSetDataPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGLightCookieManager::UpdateLightCookieAtlasPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::get_Item);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafePtr<UnityEngine::Rendering::VisibleLight>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D5ED100);
			//     sub_18003C530(&off_18D5ED128);
			//     sub_18003C530(&off_18D5ED120);
			//     byte_18D919E23 = 1;
			//   }
			//   value = 0LL;
			//   memset(&v140, 0, sizeof(v140));
			//   v130 = 0LL;
			//   memset(&v141, 0, sizeof(v141));
			//   v133 = 0LL;
			//   _unity_self = 0LL;
			//   v135 = 0LL;
			//   sub_1802F01E0(&v145, 0LL, 64LL);
			//   sub_1802F01E0(&v146, 0LL, 64LL);
			//   sub_1802F01E0(&v147, 0LL, 64LL);
			//   sub_1802F01E0(&v144, 0LL, 64LL);
			//   if ( IFix::WrappersManagerImpl::IsPatched(1592, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1592, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v126, v125);
			//     v136 = *lightIndices;
			//     value = (RectInt)*visibleLights;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_611(
			//       Patch,
			//       (Object *)v11,
			//       v10,
			//       (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&value,
			//       (Object *)hgCamera,
			//       (Object *)settingParams,
			//       &v136,
			//       punctualLightCount,
			//       0LL);
			//   }
			//   else if ( HG::Rendering::Runtime::HGLightCookieManager::IsLightCookiesEnabled(v11, settingParams, 0LL) )
			//   {
			//     v131 = *lightIndices;
			//     v134 = *visibleLights;
			//     HG::Rendering::Runtime::HGLightCookieManager::PrepareLightCookies(
			//       v11,
			//       &v134,
			//       hgCamera,
			//       settingParams,
			//       &v131,
			//       punctualLightCount,
			//       0LL);
			//     v134.m_Buffer = (Void *)v11.fields.m_cachedLightCookieAtlas;
			//     m_texturesToBeAdded = v11.fields.m_texturesToBeAdded;
			//     if ( !m_texturesToBeAdded )
			//       sub_180B536AC(v13, v12);
			//     if ( m_texturesToBeAdded.fields._size )
			//     {
			//       for ( i = 0; ; ++i )
			//       {
			//         v16 = v11.fields.m_texturesToBeAdded;
			//         if ( !v16 )
			//           sub_180B536AC(v13, v12);
			//         if ( i >= v16.fields._size )
			//           break;
			//         Item = System::Collections::Generic::List<System::Object>::get_Item(
			//                  (List_1_System_Object_ *)v11.fields.m_texturesToBeAdded,
			//                  i,
			//                  MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::get_Item);
			//         v20 = Item;
			//         if ( !v11.fields.m_activeLightCookies )
			//           sub_180B536AC(v19, v18);
			//         if ( System::Collections::Generic::Dictionary<System::Object,UnityEngine::RectInt>::TryGetValue(
			//                (Dictionary_2_System_Object_UnityEngine_RectInt_ *)v11.fields.m_activeLightCookies,
			//                Item,
			//                &value,
			//                MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::TryGetValue) )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
			//           static_fields = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager.static_fields;
			//           s_srcTextures = static_fields.s_srcTextures;
			//           if ( !s_srcTextures )
			//             sub_180B536AC(static_fields, v23);
			//           sub_180036D40(static_fields.s_srcTextures, v20);
			//           sub_180328478(s_srcTextures, i, v20);
			//           v27 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager.static_fields;
			//           s_srcDimensions = v27.s_srcDimensions;
			//           if ( !v20 )
			//             sub_180B536AC(v27, v26);
			//           v128.m_X = sub_18003ED00(5LL);
			//           v128.m_Y = sub_18003ED00(7LL);
			//           if ( !s_srcDimensions )
			//             sub_180B536AC(v30, v29);
			//           if ( (unsigned int)i >= s_srcDimensions.max_length.size )
			//             sub_180070270(v30, v29);
			//           s_srcDimensions.vector[i] = v128;
			//           s_dstPositions = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager.static_fields.s_dstPositions;
			//           xy = Unity::Mathematics::int3::get_xy((int3 *)&value, 0LL);
			//           if ( !s_dstPositions )
			//             sub_180B536AC(v34, v33);
			//           if ( (unsigned int)i >= s_dstPositions.max_length.size )
			//             sub_180070270(v34, v33);
			//           s_dstPositions.vector[i] = (Vector2Int)xy;
			//           s_dstDimensions = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager.static_fields.s_dstDimensions;
			//           size = UnityEngine::RectInt::get_size(&value, 0LL);
			//           if ( !s_dstDimensions )
			//             sub_180B536AC(v13, v12);
			//           if ( (unsigned int)i >= s_dstDimensions.max_length.size )
			//             sub_180070270(v13, v12);
			//           s_dstDimensions.vector[i] = size;
			//         }
			//         else
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
			//           v22 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager.static_fields;
			//           if ( !v22.s_srcTextures )
			//             sub_180B536AC(v22, v21);
			//           sub_180328478(v22.s_srcTextures, i, 0LL);
			//         }
			//       }
			//       v37 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//               (Int32Enum__Enum)0x71u,
			//               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !v10 )
			//         sub_180B536AC(v39, v38);
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         &v138,
			//         (HGRenderGraph *)v10,
			//         (String *)"Update LightCookie Atlas",
			//         &v130,
			//         v37,
			//         1,
			//         ProfilingHGPass__Enum_None,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGLightCookieManager::UpdateLightCookieAtlasPassData>);
			//       v140 = v138;
			//       v131.m_Buffer = 0LL;
			//       *(_QWORD *)&v131.m_Length = &v140;
			//       try
			//       {
			//         v41 = v130;
			//         if ( !v130 )
			//           sub_1802DC2C8(v40, 0LL);
			//         v130[1].klass = (Object__Class *)v134.m_Buffer;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v42 = ((unsigned __int64)&v41[1] >> 12) & 0x1FFFFF;
			//           v43 = v42 >> 6;
			//           v44 = v42 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v43 + 36190]);
			//           do
			//             v45 = qword_18D6405E0[v43 + 36190];
			//           while ( v45 != _InterlockedCompareExchange64(&qword_18D6405E0[v43 + 36190], v45 | (1LL << v44), v45) );
			//         }
			//         v46 = v130;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
			//         v48 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager.static_fields;
			//         if ( !v46 )
			//           sub_1802DC2C8(v48, v47);
			//         v46[2].klass = (Object__Class *)v48.s_srcTextures;
			//         v49 = (unsigned int)dword_18D8E43F8;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v50 = (((unsigned __int64)&v46[2] >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v50 + 36190]);
			//           do
			//             v51 = qword_18D6405E0[v50 + 36190];
			//           while ( v51 != _InterlockedCompareExchange64(
			//                            &qword_18D6405E0[v50 + 36190],
			//                            v51 | (1LL << (((unsigned __int64)&v46[2] >> 12) & 0x3F)),
			//                            v51) );
			//           v49 = (unsigned int)dword_18D8E43F8;
			//         }
			//         v52 = v130;
			//         v53 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager.static_fields;
			//         if ( !v130 )
			//           sub_1802DC2C8(v53, v49);
			//         v130[3].klass = (Object__Class *)v53.s_srcDimensions;
			//         if ( (_DWORD)v49 )
			//         {
			//           v54 = ((unsigned __int64)&v52[3] >> 12) & 0x1FFFFF;
			//           v55 = v54 >> 6;
			//           v56 = v54 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v55 + 36190]);
			//           do
			//             v57 = qword_18D6405E0[v55 + 36190];
			//           while ( v57 != _InterlockedCompareExchange64(&qword_18D6405E0[v55 + 36190], v57 | (1LL << v56), v57) );
			//           v49 = (unsigned int)dword_18D8E43F8;
			//         }
			//         v58 = v130;
			//         v59 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager.static_fields;
			//         if ( !v130 )
			//           sub_1802DC2C8(v59, v49);
			//         v130[3].monitor = (MonitorData *)v59.s_dstDimensions;
			//         if ( (_DWORD)v49 )
			//         {
			//           v60 = ((unsigned __int64)&v58[3].monitor >> 12) & 0x1FFFFF;
			//           v61 = v60 >> 6;
			//           v62 = v60 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v61 + 36190]);
			//           do
			//             v63 = qword_18D6405E0[v61 + 36190];
			//           while ( v63 != _InterlockedCompareExchange64(&qword_18D6405E0[v61 + 36190], v63 | (1LL << v62), v63) );
			//           v49 = (unsigned int)dword_18D8E43F8;
			//         }
			//         v64 = v130;
			//         v65 = (signed __int64)TypeInfo::HG::Rendering::Runtime::HGLightCookieManager.static_fields;
			//         if ( !v130 )
			//           sub_1802DC2C8(v65, v49);
			//         v130[2].monitor = *(MonitorData **)(v65 + 32);
			//         if ( (_DWORD)v49 )
			//         {
			//           v66 = ((unsigned __int64)&v64[2].monitor >> 12) & 0x1FFFFF;
			//           v67 = v66 >> 6;
			//           v49 = v66 & 0x3F;
			//           _m_prefetchw(&qword_18D6405E0[v67 + 36190]);
			//           do
			//           {
			//             v65 = qword_18D6405E0[v67 + 36190] | (1LL << v49);
			//             v68 = qword_18D6405E0[v67 + 36190];
			//           }
			//           while ( v68 != _InterlockedCompareExchange64(&qword_18D6405E0[v67 + 36190], v65, v68) );
			//         }
			//         v69 = v11.fields.m_texturesToBeAdded;
			//         if ( !v69 )
			//           sub_1802DC2C8(v65, v49);
			//         v70 = (unsigned int)v69.fields._size;
			//         if ( !v130 )
			//           sub_1802DC2C8(v70, v49);
			//         LODWORD(v130[1].monitor) = v70;
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v140,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGLightCookieManager.static_fields.s_updateLightCookieAtlasRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGLightCookieManager::UpdateLightCookieAtlasPassData>);
			//       }
			//       catch ( Il2CppExceptionWrapper *v142 )
			//       {
			//         v131.m_Buffer = (Void *)v142.ex;
			//         sub_180222690(&v131);
			//         v10 = (Object *)renderGraph;
			//         v11 = this;
			//         goto LABEL_53;
			//       }
			//       sub_180222690(&v131);
			//     }
			// LABEL_53:
			//     v71 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//             (Int32Enum__Enum)0x72u,
			//             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !v10 )
			//       sub_1802DC2C8(v73, v72);
			//     HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//       &v138,
			//       (HGRenderGraph *)v10,
			//       (String *)"LightCookie SetData Pass",
			//       &v133,
			//       v71,
			//       1,
			//       ProfilingHGPass__Enum_None,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGLightCookieManager::LightCookieSetDataPassData>);
			//     v141 = v138;
			//     *(_QWORD *)&value.m_XMin = 0LL;
			//     *(_QWORD *)&value.m_Width = &v141;
			//     try
			//     {
			//       m_lightSlots = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)v11.fields.m_lightSlots;
			//       if ( !m_lightSlots )
			//         sub_1802DC2C8(0LL, v74);
			//       System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::Clear(
			//         m_lightSlots,
			//         MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,int>::Clear);
			//       v77 = 0;
			//       for ( j = 0; ; j = v128.m_X + 1 )
			//       {
			//         v128.m_X = j;
			//         if ( j >= punctualLightCount )
			//           break;
			//         v79 = &visibleLights.m_Buffer[148 * *(int *)&lightIndices.m_Buffer[4 * j]];
			//         v149 = *(_OWORD *)v79;
			//         v150 = *(_OWORD *)&v79[16];
			//         v151 = *(_OWORD *)&v79[32];
			//         v152 = *(_OWORD *)&v79[48];
			//         v153 = *(_OWORD *)&v79[64];
			//         v154 = *(_OWORD *)&v79[80];
			//         v155 = *(_OWORD *)&v79[96];
			//         v156 = *(_OWORD *)&v79[112];
			//         v157 = *(_OWORD *)&v79[128];
			//         v158 = *(_DWORD *)&v79[144];
			//         _unity_self = (HGSharedLightData)*((_QWORD *)&v157 + 1);
			//         Entity = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(
			//                    *(HGSharedLightData *)((char *)&v157 + 8),
			//                    0LL);
			//         cookie_Injected = (Object *)UnityEngine::HGSharedLightData::get_cookie_Injected(&_unity_self, 0LL);
			//         sub_180002C70(TypeInfo::UnityEngine::Object);
			//         if ( UnityEngine::Object::op_Inequality((Object_1 *)cookie_Injected, 0LL, 0LL) )
			//         {
			//           m_activeLightCookies = (Dictionary_2_System_Object_UnityEngine_RectInt_ *)v11.fields.m_activeLightCookies;
			//           if ( !m_activeLightCookies )
			//             sub_1802DC2C8(0LL, v82);
			//           if ( System::Collections::Generic::Dictionary<System::Object,UnityEngine::RectInt>::TryGetValue(
			//                  m_activeLightCookies,
			//                  cookie_Injected,
			//                  &v135,
			//                  MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::TryGetValue) )
			//           {
			//             if ( v77 >= 32 )
			//             {
			//               v128.m_X = 32;
			//               v106 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v128, v85);
			//               v107 = System::String::Format(
			//                        (String *)"HGLightCookieManager: 当前使用Light Cookie的灯已经超过{0}盏，请灯光师检查状态",
			//                        v106,
			//                        0LL);
			//               HG::Rendering::HGRPLogger::LogError(v107, 0LL);
			//               break;
			//             }
			//             v86 = v11.fields.m_lightSlots;
			//             if ( !v86 )
			//               sub_1802DC2C8(0LL, v84);
			//             System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,int>::Add(
			//               v86,
			//               Entity,
			//               v77,
			//               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,int>::Add);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
			//             s_lightCookieData = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager.static_fields.s_lightCookieData;
			//             *(float *)&v131.m_Buffer = (float)v135.m_XMin * 0.00024414062;
			//             *((float *)&v131.m_Buffer + 1) = (float)v135.m_YMin * 0.00024414062;
			//             *(float *)&v131.m_Length = (float)v135.m_Width * 0.00024414062;
			//             *(float *)&v131.m_AllocatorLabel = (float)v135.m_Height * 0.00024414062;
			//             if ( !s_lightCookieData )
			//               sub_1802DC2C8(0LL, v87);
			//             v136 = v131;
			//             sub_18004D910(s_lightCookieData, v77, &v136);
			//             if ( UnityEngine::HGSharedLightData::get_type_Injected(&_unity_self, 0LL) )
			//             {
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
			//               s_lightCookieMatricesData = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager.static_fields.s_lightCookieMatricesData;
			//               v144 = *UnityEngine::HGSharedLightData::get_localToWorldMatrix(&v139, &_unity_self, 0LL);
			//               v136 = (NativeArray_1_System_Int32_)*UnityEngine::Matrix4x4::get_rotation((Quaternion *)&v138, &v144, 0LL);
			//               v90 = UnityEngine::Matrix4x4::Rotate(&v139, (Quaternion *)&v136, 0LL);
			//               if ( !s_lightCookieMatricesData )
			//                 sub_1802DC2C8(v92, v91);
			//               v137 = *v90;
			//               sub_180077420(s_lightCookieMatricesData, v77, &v137);
			//             }
			//             else
			//             {
			//               localToWorldMatrix = UnityEngine::HGSharedLightData::get_localToWorldMatrix(&v139, &_unity_self, 0LL);
			//               v94 = *(_OWORD *)&localToWorldMatrix.m00;
			//               v95 = *(_OWORD *)&localToWorldMatrix.m01;
			//               v96 = *(_OWORD *)&localToWorldMatrix.m02;
			//               v97 = *(_OWORD *)&localToWorldMatrix.m03;
			//               spotAngle_Injected = UnityEngine::HGSharedLightData::get_spotAngle_Injected(&_unity_self, 0LL);
			//               shadowNearPlane_Injected = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&_unity_self, 0LL);
			//               shadowFarPlane_Injected = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&_unity_self, 0LL);
			//               shadowGuardAngle_Injected = UnityEngine::HGSharedLightData::get_shadowGuardAngle_Injected(
			//                                             &_unity_self,
			//                                             0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//               *(_OWORD *)&v137.m00 = v94;
			//               *(_OWORD *)&v137.m01 = v95;
			//               *(_OWORD *)&v137.m02 = v96;
			//               *(_OWORD *)&v137.m03 = v97;
			//               HG::Rendering::Runtime::HGShadowUtils::ExtractSpotLightMatrix(
			//                 &v139,
			//                 &v137,
			//                 spotAngle_Injected,
			//                 shadowNearPlane_Injected,
			//                 shadowFarPlane_Injected,
			//                 shadowGuardAngle_Injected,
			//                 &v145,
			//                 &v146,
			//                 &v147,
			//                 0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
			//               v102 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager.static_fields.s_lightCookieMatricesData;
			//               v137 = v145;
			//               v139 = v146;
			//               ShadowTransform = HG::Rendering::Runtime::HGShadowUtils::GetShadowTransform(&v148, &v139, &v137, 0LL);
			//               if ( !v102 )
			//                 sub_1802DC2C8(v105, v104);
			//               v139 = *ShadowTransform;
			//               sub_180077420(v102, v77, &v139);
			//             }
			//             ++v77;
			//           }
			//         }
			//       }
			//       v108 = v133;
			//       if ( !v133 )
			//         sub_1802DC2C8(v76, 0LL);
			//       v133[1].klass = (Object__Class *)v134.m_Buffer;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v109 = ((unsigned __int64)&v108[1] >> 12) & 0x1FFFFF;
			//         v110 = v109 >> 6;
			//         v111 = v109 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v110 + 36190]);
			//         do
			//           v112 = qword_18D6405E0[v110 + 36190];
			//         while ( v112 != _InterlockedCompareExchange64(&qword_18D6405E0[v110 + 36190], v112 | (1LL << v111), v112) );
			//       }
			//       v113 = v133;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
			//       v115 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager.static_fields;
			//       if ( !v113 )
			//         sub_1802DC2C8(v115, v114);
			//       v113[1].monitor = (MonitorData *)v115.s_lightCookieData;
			//       v116 = (unsigned int)dword_18D8E43F8;
			//       if ( dword_18D8E43F8 )
			//       {
			//         v117 = (((unsigned __int64)&v113[1].monitor >> 12) & 0x1FFFFF) >> 6;
			//         _m_prefetchw(&qword_18D6405E0[v117 + 36190]);
			//         do
			//           v118 = qword_18D6405E0[v117 + 36190];
			//         while ( v118 != _InterlockedCompareExchange64(
			//                           &qword_18D6405E0[v117 + 36190],
			//                           v118 | (1LL << (((unsigned __int64)&v113[1].monitor >> 12) & 0x3F)),
			//                           v118) );
			//         v116 = (unsigned int)dword_18D8E43F8;
			//       }
			//       v119 = v133;
			//       v120 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager.static_fields;
			//       if ( !v133 )
			//         sub_1802DC2C8(v120, v116);
			//       v133[2].klass = (Object__Class *)v120.s_lightCookieMatricesData;
			//       if ( (_DWORD)v116 )
			//       {
			//         v121 = ((unsigned __int64)&v119[2] >> 12) & 0x1FFFFF;
			//         v122 = v121 >> 6;
			//         v123 = v121 & 0x3F;
			//         _m_prefetchw(&qword_18D6405E0[v122 + 36190]);
			//         do
			//           v124 = qword_18D6405E0[v122 + 36190];
			//         while ( v124 != _InterlockedCompareExchange64(&qword_18D6405E0[v122 + 36190], v124 | (1LL << v123), v124) );
			//       }
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v141,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGLightCookieManager.static_fields.s_lightCookieSetDataPassRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGLightCookieManager::LightCookieSetDataPassData>);
			//     }
			//     catch ( Il2CppExceptionWrapper *v143 )
			//     {
			//       *(Il2CppExceptionWrapper *)&value.m_XMin = (Il2CppExceptionWrapper)v143.ex;
			//     }
			//     sub_180222690(&value);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGLightCookieManager::InvalidateAllLightCookies(v11, 0LL);
			//   }
			// }
			// 
		}

		private const int MAX_LIGHT_COOKIE_COUNT = 32;

		private const int LIGHT_COOKIE_ATLAS_WIDTH = 4096;

		private const int LIGHT_COOKIE_ATLAS_HEIGHT = 4096;

		private Dictionary<Texture, RectInt> m_activeLightCookies;

		private List<Texture> m_texturesInUse;

		private List<Texture> m_texturesToBeRemoved;

		private List<Texture> m_texturesToBeAdded;

		private Dictionary<Entity, int> m_lightSlots;

		private AtlasMaxRect m_lightCookieAtlasAllocator;

		private Texture2D m_cachedLightCookieAtlas;

		private GraphicsFormat m_lightCookieColorFormat;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly RenderFunc<HGLightCookieManager.UpdateLightCookieAtlasPassData> s_updateLightCookieAtlasRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly RenderFunc<HGLightCookieManager.LightCookieSetDataPassData> s_lightCookieSetDataPassRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static Texture[] s_srcTextures;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static Vector2Int[] s_srcDimensions;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static Vector2Int[] s_dstPositions;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		private static Vector2Int[] s_dstDimensions;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x30")]
		private static Vector4[] s_lightCookieData;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x38")]
		private static Matrix4x4[] s_lightCookieMatricesData;

		private class UpdateLightCookieAtlasPassData
		{
			public UpdateLightCookieAtlasPassData()
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

			public Texture2D dstAtlas;

			public int updateRequestCount;

			public Texture[] srcTextures;

			public Vector2Int[] dstPositions;

			public Vector2Int[] srcDimensions;

			public Vector2Int[] dstDimensions;
		}

		private class LightCookieSetDataPassData
		{
			public LightCookieSetDataPassData()
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

			public Texture2D dstAtlas;

			public Vector4[] lightCookieData;

			public Matrix4x4[] lightCookieWorldToLightData;
		}
	}
}
