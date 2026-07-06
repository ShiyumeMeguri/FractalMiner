using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace HG.Rendering.Runtime
{
	public class HGPunctualLightShadowManagerV2
	{
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x00002608 File Offset: 0x00000808
		private int m_dynamicPunctualShadowCasterCount
		{
			get
			{
				// // Int32 get_m_dynamicPunctualShadowCasterCount()
				// int32_t HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::get_m_dynamicPunctualShadowCasterCount(
				//         HGPunctualLightShadowManagerV2 *this,
				//         MethodInfo *method)
				// {
				//   return this.fields.m_dynamicEnvPunctualShadowCasterCount + this.fields.m_dynamicMovablePunctualShadowCasterCount;
				// }
				// 
				return 0;
			}
		}

		public HGPunctualLightShadowManagerV2()
		{
		}

		internal bool IsLightRenderingDynamicPunctualLight(Entity lightEntity)
		{
			// // Boolean IsLightRenderingDynamicPunctualLight(Entity)
			// bool HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::IsLightRenderingDynamicPunctualLight(
			//         HGPunctualLightShadowManagerV2 *this,
			//         Entity_1 lightEntity,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   int v6; // ebp
			//   LightCaster__Array *m_targetDynamicPunctualLights; // rcx
			//   Entity_1 v8; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919E9A )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     byte_18D919E9A = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1845, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1845, 0LL);
			//     if ( !Patch )
			// LABEL_11:
			//       sub_180B536AC(m_targetDynamicPunctualLights, v5);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_712(Patch, (Object *)this, lightEntity, 0LL);
			//   }
			//   else
			//   {
			//     v6 = 0;
			//     if ( this.fields.m_dynamicEnvPunctualShadowCasterCount + this.fields.m_dynamicMovablePunctualShadowCasterCount <= 0 )
			//     {
			//       return 0;
			//     }
			//     else
			//     {
			//       while ( 1 )
			//       {
			//         m_targetDynamicPunctualLights = this.fields.m_targetDynamicPunctualLights;
			//         if ( !m_targetDynamicPunctualLights )
			//           goto LABEL_11;
			//         v8 = *(Entity_1 *)sub_18037A2E0(m_targetDynamicPunctualLights, v6);
			//         sub_180002C70(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//         if ( UnityEngine::HyperGryph::ECS::Entity::op_Equality(v8, lightEntity, 0LL) )
			//           return 1;
			//         if ( ++v6 >= this.fields.m_dynamicMovablePunctualShadowCasterCount
			//                    + this.fields.m_dynamicEnvPunctualShadowCasterCount )
			//           return 0;
			//       }
			//     }
			//   }
			// }
			// 
			return default(bool);
		}

		internal bool IsLightShadowBaked(Entity lightEntity)
		{
			// // Boolean IsLightShadowBaked(Entity)
			// // Hidden C++ exception states: #wind=1
			// bool HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::IsLightShadowBaked(
			//         HGPunctualLightShadowManagerV2 *this,
			//         Entity_1 lightEntity,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *m_activePunctualLightCachedShadowDescs; // rdi
			//   bool v8; // al
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v12; // rdx
			//   __int64 v13; // rcx
			//   Il2CppException *ex; // [rsp+20h] [rbp-B8h]
			//   LightCaster key; // [rsp+30h] [rbp-A8h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_System_Text_RegularExpressions_Regex_CachedCodeEntryKey_System_Object_ v16; // [rsp+40h] [rbp-98h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ v17; // [rsp+78h] [rbp-60h] BYREF
			//   Il2CppExceptionWrapper *v18; // [rsp+B0h] [rbp-28h] BYREF
			//   HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc value; // [rsp+B8h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D919E9B )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::GetEnumerator);
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Deconstruct);
			//     byte_18D919E9B = 1;
			//   }
			//   key = 0LL;
			//   value = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1846, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1846, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v13, v12);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_712(Patch, (Object *)this, lightEntity, 0LL);
			//   }
			//   m_activePunctualLightCachedShadowDescs = this.fields.m_activePunctualLightCachedShadowDescs;
			//   if ( !m_activePunctualLightCachedShadowDescs )
			//     sub_180B536AC(v6, v5);
			//   System::Collections::Generic::Dictionary<System::Text::RegularExpressions::Regex::CachedCodeEntryKey,System::Object>::GetEnumerator(
			//     &v16,
			//     (Dictionary_2_System_Text_RegularExpressions_Regex_CachedCodeEntryKey_System_Object_ *)m_activePunctualLightCachedShadowDescs,
			//     MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::GetEnumerator);
			//   v17 = (Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_)v16;
			//   while ( 1 )
			//   {
			//     try
			//     {
			//       v8 = System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::MoveNext(
			//              &v17,
			//              MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::MoveNext);
			//     }
			//     catch ( Il2CppExceptionWrapper *v18 )
			//     {
			//       ex = v18.ex;
			//       if ( ex )
			//         sub_18000F780(ex);
			//       return 0;
			//     }
			//     if ( !v8 )
			//       return 0;
			//     *(LightCaster *)&v16._dictionary = v17._current.key;
			//     *(HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc *)&v16._current.key._options = v17._current.value;
			//     System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Deconstruct(
			//       (KeyValuePair_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)&v16,
			//       &key,
			//       &value,
			//       MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Deconstruct);
			//     sub_180002C70(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     if ( UnityEngine::HyperGryph::ECS::Entity::op_Equality(key.lightEntity, lightEntity, 0LL) )
			//       return 1;
			//   }
			// }
			// 
			return default(bool);
		}

		internal static void Initialize(HGRenderPipelineRuntimeResources renderPipelineResources)
		{
			// // Void Initialize(HGRenderPipelineRuntimeResources)
			// void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::Initialize(
			//         HGRenderPipelineRuntimeResources *renderPipelineResources,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
			//   Shader *shadowClearPS; // rbx
			//   Material *StaticMaterial; // rax
			//   OneofDescriptorProto *v8; // rdx
			//   FileDescriptor *v9; // r8
			//   MessageDescriptor *v10; // r9
			//   struct HGPunctualLightShadowManagerV2__Class *v11; // rcx
			//   Material *v12; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   String__Array *v14; // [rsp+50h] [rbp+28h]
			//   String *v15; // [rsp+58h] [rbp+30h]
			//   MethodInfo *v16; // [rsp+60h] [rbp+38h]
			// 
			//   if ( !byte_18D8EDD0D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
			//     byte_18D8EDD0D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1800, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1800, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)renderPipelineResources,
			//         0LL);
			//       return;
			//     }
			// LABEL_11:
			//     sub_180B536AC(v4, v3);
			//   }
			//   if ( !renderPipelineResources )
			//     goto LABEL_11;
			//   shaders = renderPipelineResources.fields.shaders;
			//   if ( !shaders )
			//     goto LABEL_11;
			//   shadowClearPS = shaders.fields.shadowClearPS;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector, v3);
			//   StaticMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
			//                      shadowClearPS,
			//                      0,
			//                      0LL);
			//   v11 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2;
			//   v12 = StaticMaterial;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2, v8);
			//     v11 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2;
			//   }
			//   v11.static_fields.s_clearShadowMaterial = v12;
			//   sub_1800054D0(
			//     (OneofDescriptor *)&TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_clearShadowMaterial,
			//     v8,
			//     v9,
			//     v10,
			//     v14,
			//     v15,
			//     v16);
			// }
			// 
		}

		internal void Release()
		{
			// // Void Release()
			// void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::Release(
			//         HGPunctualLightShadowManagerV2 *this,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(524, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(524, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else if ( this.fields.m_cachedPunctualLightShadowAtlas )
			//   {
			//     UnityEngine::Rendering::RTHandle::Release(this.fields.m_cachedPunctualLightShadowAtlas, 0LL);
			//   }
			// }
			// 
		}

		public void InvalidateAllShadowCaches()
		{
			// // Void InvalidateAllShadowCaches()
			// void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::InvalidateAllShadowCaches(
			//         HGPunctualLightShadowManagerV2 *this,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGPunctualLightStaticAtlasAllocator *punctualLightStaticAtlasAllocator; // rcx
			//   int v5; // edi
			//   LightCaster__Array *m_targetDynamicPunctualLights; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v8; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D919E9C )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Clear);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCaster);
			//     byte_18D919E9C = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1633, 0LL) )
			//   {
			//     punctualLightStaticAtlasAllocator = this.fields.punctualLightStaticAtlasAllocator;
			//     if ( punctualLightStaticAtlasAllocator )
			//     {
			//       HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::FreeAll(punctualLightStaticAtlasAllocator, 0LL);
			//       punctualLightStaticAtlasAllocator = (HGPunctualLightStaticAtlasAllocator *)this.fields.m_activePunctualLightCachedShadowDescs;
			//       if ( punctualLightStaticAtlasAllocator )
			//       {
			//         System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
			//           (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)punctualLightStaticAtlasAllocator,
			//           MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Clear);
			//         v5 = 0;
			//         while ( 1 )
			//         {
			//           m_targetDynamicPunctualLights = this.fields.m_targetDynamicPunctualLights;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//           punctualLightStaticAtlasAllocator = (HGPunctualLightStaticAtlasAllocator *)TypeInfo::HG::Rendering::Runtime::LightCaster.static_fields;
			//           if ( !m_targetDynamicPunctualLights )
			//             break;
			//           v8 = *(_OWORD *)&punctualLightStaticAtlasAllocator.klass;
			//           sub_1803EF6F4(m_targetDynamicPunctualLights, v5++, &v8);
			//           if ( v5 >= 4 )
			//             return;
			//         }
			//       }
			//     }
			// LABEL_11:
			//     sub_180B536AC(punctualLightStaticAtlasAllocator, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1633, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			// }
			// 
		}

		private bool IsPunctualLightShadowEnabled(HGSettingParameters settingParams)
		{
			// // Boolean IsPunctualLightShadowEnabled(HGSettingParameters)
			// bool HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::IsPunctualLightShadowEnabled(
			//         HGPunctualLightShadowManagerV2 *this,
			//         HGSettingParameters *settingParams,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGGraphicsFeatureManager__StaticFields *static_fields; // rcx
			//   HGGraphicsFeatureSwitch *punctualLightShadow; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919E9D )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D919E9D = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1631, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1631, 0LL);
			//     if ( !Patch )
			//       goto LABEL_10;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
			//              (ILFixDynamicMethodWrapper_36 *)Patch,
			//              (Object *)this,
			//              (Object *)settingParams,
			//              0LL);
			//   }
			//   else
			//   {
			//     if ( !settingParams )
			//       goto LABEL_10;
			//     if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//            settingParams.fields._punctualLightShadowEnabled_k__BackingField,
			//            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager.static_fields;
			//       punctualLightShadow = static_fields.punctualLightShadow;
			//       if ( punctualLightShadow )
			//         return punctualLightShadow.fields.m_defaultValue;
			// LABEL_10:
			//       sub_180B536AC(static_fields, v5);
			//     }
			//     return 0;
			//   }
			// }
			// 
			return default(bool);
		}

		private void AppendNewDynamicPunctualLight(HGSharedLightData curLight, LightCaster targetCaster, bool isCinematicMode, ref int currentDynamicSlotIndex, ref int currentEnvDynamicCasterCount, ref int currentMovableDynamicCasterCount)
		{
			// // Void AppendNewDynamicPunctualLight(HGSharedLightData, LightCaster, Boolean, Int32 ByRef, Int32 ByRef, Int32 ByRef)
			// void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::AppendNewDynamicPunctualLight(
			//         HGPunctualLightShadowManagerV2 *this,
			//         HGSharedLightData curLight,
			//         LightCaster *targetCaster,
			//         bool isCinematicMode,
			//         int32_t *currentDynamicSlotIndex,
			//         int32_t *currentEnvDynamicCasterCount,
			//         int32_t *currentMovableDynamicCasterCount,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   int32_t *v12; // rbx
			//   bool isDynamicShadowCaster; // al
			//   int32_t *v14; // rsi
			//   int32_t *v15; // r14
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int64 v17; // rdx
			//   __int64 v18; // rdx
			//   LightCaster v19; // [rsp+50h] [rbp-10h] BYREF
			//   HGSharedLightData v20; // [rsp+88h] [rbp+28h] BYREF
			// 
			//   v20 = curLight;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1643, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1643, 0LL);
			//     if ( Patch )
			//     {
			//       v19 = *targetCaster;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_630(
			//         Patch,
			//         (Object *)this,
			//         v20,
			//         &v19,
			//         isCinematicMode,
			//         currentDynamicSlotIndex,
			//         currentEnvDynamicCasterCount,
			//         currentMovableDynamicCasterCount,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_16;
			//   }
			//   v12 = currentDynamicSlotIndex;
			//   if ( *currentDynamicSlotIndex >= this.fields.m_dynamicEnvPunctualShadowCasterCount
			//                                  + this.fields.m_dynamicMovablePunctualShadowCasterCount )
			//     return;
			//   if ( isCinematicMode )
			//   {
			//     Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_targetDynamicPunctualLights;
			//     if ( Patch )
			//     {
			//       v18 = *currentDynamicSlotIndex;
			//       v19 = *targetCaster;
			//       sub_1803EF6F4(Patch, v18, &v19);
			//       ++*v12;
			//       return;
			//     }
			//     goto LABEL_16;
			//   }
			//   isDynamicShadowCaster = UnityEngine::HGSharedLightData::get_isDynamicShadowCaster(&v20, 0LL);
			//   v14 = currentMovableDynamicCasterCount;
			//   v15 = currentEnvDynamicCasterCount;
			//   if ( (isDynamicShadowCaster || *currentEnvDynamicCasterCount >= this.fields.m_dynamicEnvPunctualShadowCasterCount)
			//     && (!UnityEngine::HGSharedLightData::get_isDynamicShadowCaster(&v20, 0LL)
			//      || *v14 >= this.fields.m_dynamicMovablePunctualShadowCasterCount) )
			//   {
			//     goto LABEL_10;
			//   }
			//   Patch = (ILFixDynamicMethodWrapper_2 *)this.fields.m_targetDynamicPunctualLights;
			//   if ( !Patch )
			// LABEL_16:
			//     sub_180B536AC(Patch, v11);
			//   v17 = *v12;
			//   v19 = *targetCaster;
			//   sub_1803EF6F4(Patch, v17, &v19);
			// LABEL_10:
			//   ++*v12;
			//   if ( UnityEngine::HGSharedLightData::get_isDynamicShadowCaster(&v20, 0LL) )
			//     ++*v14;
			//   else
			//     ++*v15;
			// }
			// 
		}

		internal void PreparePunctualLightShadowCasters(NativeArray<VisibleLight> visibleLights, HGCamera hgCamera, HGSettingParameters settingParams, NativeArray<int> lightIndices, int punctualLightCount)
		{
			// // Void PreparePunctualLightShadowCasters(NativeArray`1[UnityEngine.Rendering.VisibleLight], HGCamera, HGSettingParameters, NativeArray`1[System.Int32], Int32)
			// // Hidden C++ exception states: #wind=3
			// void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PreparePunctualLightShadowCasters(
			//         HGPunctualLightShadowManagerV2 *this,
			//         NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights,
			//         HGCamera *hgCamera,
			//         HGSettingParameters *settingParams,
			//         NativeArray_1_System_Int32_ *lightIndices,
			//         int32_t punctualLightCount,
			//         MethodInfo *method)
			// {
			//   HGPunctualLightShadowManagerV2 *v10; // r14
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   float v13; // xmm0_4
			//   __int64 v14; // rdx
			//   int32_t m_punctualShadowAtlasBaseTileSize; // ebx
			//   unsigned __int64 v16; // rcx
			//   int v17; // eax
			//   int v18; // eax
			//   unsigned __int64 v19; // rbx
			//   HGPunctualLightStaticAtlasAllocator *punctualLightStaticAtlasAllocator; // rdi
			//   Vector2Int m_punctualShadowAtlasSize; // rax
			//   OneofDescriptorProto *v22; // rdx
			//   FileDescriptor *v23; // r8
			//   MessageDescriptor *v24; // r9
			//   int32_t m_X; // edi
			//   int32_t m_Y; // ebx
			//   OneofDescriptorProto *v27; // rdx
			//   FileDescriptor *v28; // r8
			//   MessageDescriptor *v29; // r9
			//   __int64 v30; // rdx
			//   __int64 v31; // rcx
			//   List_1_HG_Rendering_Runtime_LightCaster_ *m_castersToBeRemoved; // rbx
			//   Transform *transform; // rax
			//   __int64 v34; // rdx
			//   __int64 v35; // rcx
			//   __int64 v36; // rdx
			//   __int64 v37; // rcx
			//   unsigned __int64 lightEntity; // rcx
			//   HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc v39; // xmm6
			//   __int64 v40; // rdx
			//   Vector3 *worldPosition; // rax
			//   float v42; // xmm2_4
			//   __m128 v43; // xmm1
			//   __m128 v44; // xmm0
			//   float v45; // xmm7_4
			//   float shadowCullDistance_Injected; // xmm0_4
			//   List_1_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ *v47; // rcx
			//   __int64 v48; // rdx
			//   HGPunctualLightStaticAtlasAllocator *v49; // rcx
			//   unsigned __int64 v50; // rdx
			//   __int64 v51; // rdx
			//   Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *m_activePunctualLightCachedShadowDescs; // rcx
			//   int v53; // ebx
			//   LightCaster__Array *m_targetDynamicPunctualLights; // rdi
			//   int32_t v55; // r12d
			//   AttributeCollection *instance; // rax
			//   int32_t Count; // edi
			//   bool v58; // r15
			//   NativeArray_1_UnityEngine_Rendering_VisibleLight_ *v59; // r8
			//   __int64 v60; // r13
			//   HGPunctualLightStaticAtlasAllocator *v61; // rax
			//   __int64 v62; // rbx
			//   __int64 v63; // rax
			//   LightType__Enum type_Injected; // eax
			//   float v65; // xmm2_4
			//   __m128 version; // xmm1
			//   __m128 globalIndex; // xmm0
			//   float v68; // xmm6_4
			//   float m_punctualLightForceCullDistance; // xmm0_4
			//   bool HasExactlyOneCaster; // al
			//   int v71; // ecx
			//   int32_t i; // edi
			//   HGSharedLightData v73; // rbx
			//   Entity_1 Entity; // rax
			//   HGSharedLightData v75; // rbx
			//   Entity_1 v76; // rax
			//   int v77; // r15d
			//   int32_t j; // edi
			//   Entity_1 v79; // rbx
			//   LightCaster v80; // xmm6
			//   Dictionary_2_HG_Rendering_Runtime_LightCaster_System_Int32_ *m_targetPunctualAtlasAllocationThisFrame; // rbx
			//   int32_t SlotLevelFromIndex; // eax
			//   HGPunctualLightStaticAtlasAllocator *v83; // rax
			//   Boolean__Array *m_slotOccupied; // rax
			//   String *DebugName; // rax
			//   String *v86; // rax
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *m_targetUpdateRequest; // rax
			//   __int64 v88; // rdx
			//   Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *v89; // rcx
			//   LightCaster v90; // xmm6
			//   __int64 v91; // rdx
			//   __int64 v92; // rcx
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v93; // rax
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v94; // rax
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v95; // rcx
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v96; // rax
			//   Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *v97; // rdx
			//   __int64 v98; // rdx
			//   HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc v99; // xmm0
			//   int32_t v100; // r8d
			//   __int64 v101; // rcx
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v102; // rax
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v103; // rax
			//   __int64 m_cachedHashCode; // rdx
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v105; // rax
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v106; // rax
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v107; // rax
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v108; // rax
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v109; // rax
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v110; // rax
			//   __int64 v111; // rdx
			//   Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *v112; // rcx
			//   uint32_t v113; // ecx
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v114; // rax
			//   __int64 v115; // rbx
			//   Entity_1__Array *m_targetStaticPunctualLights; // rdi
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v117; // r15
			//   __int64 sourceSlot; // r15
			//   __int64 v119; // rdx
			//   __int64 v120; // rcx
			//   __int64 v121; // rax
			//   __int64 v122; // r8
			//   __int64 v123; // r9
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v124; // rax
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v125; // rax
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v126; // rax
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v127; // rax
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v128; // rdi
			//   HGSharedLightData *p_HGSharedLightData; // rcx
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v130; // rax
			//   int32_t v131; // eax
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v132; // rax
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v133; // rax
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v134; // rdi
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v135; // rax
			//   Entity_1 v136; // rax
			//   __int64 v137; // rdx
			//   __int64 v138; // rcx
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v139; // rbx
			//   __int64 v140; // rdx
			//   __int64 v141; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdi
			//   __int64 v143; // [rsp+0h] [rbp-348h] BYREF
			//   GraphicsFormat__Enum colorFormat[2]; // [rsp+20h] [rbp-328h]
			//   FilterMode__Enum filterMode[2]; // [rsp+28h] [rbp-320h]
			//   TextureWrapMode__Enum wrapMode[2]; // [rsp+30h] [rbp-318h]
			//   HGSharedLightData lightData; // [rsp+A0h] [rbp-2A8h] BYREF
			//   bool v148; // [rsp+A8h] [rbp-2A0h]
			//   LightCaster v149; // [rsp+B0h] [rbp-298h] BYREF
			//   bool HasShaderDefine; // [rsp+C0h] [rbp-288h]
			//   LightCaster requestLightCaster; // [rsp+D0h] [rbp-278h] BYREF
			//   int32_t v152; // [rsp+E0h] [rbp-268h] BYREF
			//   int32_t v153[3]; // [rsp+E4h] [rbp-264h] BYREF
			//   LightCaster current; // [rsp+F0h] [rbp-258h] BYREF
			//   unsigned __int64 v155; // [rsp+100h] [rbp-248h]
			//   HGSharedLightData _unity_self; // [rsp+110h] [rbp-238h] BYREF
			//   int32_t v157; // [rsp+118h] [rbp-230h] BYREF
			//   int32_t v158; // [rsp+11Ch] [rbp-22Ch] BYREF
			//   Vector3 v159; // [rsp+120h] [rbp-228h]
			//   HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc value; // [rsp+130h] [rbp-218h] BYREF
			//   unsigned __int64 v161; // [rsp+140h] [rbp-208h] BYREF
			//   float v162; // [rsp+148h] [rbp-200h]
			//   KeyValuePair_2_HG_Rendering_Runtime_LightCaster_System_Int32_ v163; // [rsp+150h] [rbp-1F8h] BYREF
			//   HGSharedLightData HGSharedLightData; // [rsp+170h] [rbp-1D8h] BYREF
			//   HGSharedLightData v165; // [rsp+178h] [rbp-1D0h] BYREF
			//   LightCaster key; // [rsp+180h] [rbp-1C8h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_System_Int32_ v167; // [rsp+190h] [rbp-1B8h] BYREF
			//   List_1_T_Enumerator_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ v168; // [rsp+1B8h] [rbp-190h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ v169; // [rsp+1D8h] [rbp-170h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector2Int_Beyond_Gameplay_RemoteFactory_RemoteFactoryGridSampler_SampleItem_ v170; // [rsp+210h] [rbp-138h] BYREF
			//   Il2CppExceptionWrapper *v171; // [rsp+248h] [rbp-100h] BYREF
			//   Il2CppExceptionWrapper *v172; // [rsp+250h] [rbp-F8h] BYREF
			//   Il2CppExceptionWrapper *v173; // [rsp+258h] [rbp-F0h] BYREF
			//   __int128 v174; // [rsp+260h] [rbp-E8h]
			//   __int128 v175; // [rsp+270h] [rbp-D8h]
			//   __int128 v176; // [rsp+280h] [rbp-C8h]
			//   __int128 v177; // [rsp+290h] [rbp-B8h]
			//   __int128 v178; // [rsp+2A0h] [rbp-A8h]
			//   __int128 v179; // [rsp+2B0h] [rbp-98h]
			//   __int128 v180; // [rsp+2C0h] [rbp-88h]
			//   __int128 v181; // [rsp+2D0h] [rbp-78h]
			//   __int128 v182; // [rsp+2E0h] [rbp-68h]
			//   int v183; // [rsp+2F0h] [rbp-58h]
			// 
			//   v10 = this;
			//   if ( !byte_18D919E9E )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::set_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::LightCaster>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,int>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,int>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::LightCaster>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::LightCaster>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,int>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Deconstruct);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,int>::Deconstruct);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCaster);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::LightCaster>::Add);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::LightCaster>::Clear);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::LightCaster>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafePtr<UnityEngine::Rendering::VisibleLight>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RTHandles);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&off_18D5F33D0);
			//     sub_18003C530(&off_18D5F33C0);
			//     byte_18D919E9E = 1;
			//   }
			//   memset(&v169, 0, sizeof(v169));
			//   key = 0LL;
			//   value = 0LL;
			//   _unity_self = 0LL;
			//   memset(&v168, 0, sizeof(v168));
			//   lightData = 0LL;
			//   requestLightCaster = 0LL;
			//   memset(&v167, 0, sizeof(v167));
			//   v153[0] = 0;
			//   HGSharedLightData = 0LL;
			//   v165 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1630, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1630, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v141, v140);
			//     requestLightCaster = (LightCaster)*lightIndices;
			//     v149 = (LightCaster)*visibleLights;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_606(
			//       Patch,
			//       (Object *)v10,
			//       (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&v149,
			//       (Object *)hgCamera,
			//       (Object *)settingParams,
			//       (NativeArray_1_System_Int32_ *)&requestLightCaster,
			//       punctualLightCount,
			//       0LL);
			//   }
			//   else if ( HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::IsPunctualLightShadowEnabled(
			//               v10,
			//               settingParams,
			//               0LL) )
			//   {
			//     if ( !settingParams )
			//       sub_180B536AC(v12, v11);
			//     v10.fields.m_punctualShadowAtlasBaseTileSize = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                                       (SettingParameter_1_System_Int32Enum_ *)settingParams.fields._punctualLightTileMaxSize_k__BackingField,
			//                                                       MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     v10.fields.m_dynamicEnvPunctualShadowCasterCount = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                                           (SettingParameter_1_System_Int32Enum_ *)settingParams.fields._punctualLightEnvDynamicCasterCount_k__BackingField,
			//                                                           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     v10.fields.m_dynamicMovablePunctualShadowCasterCount = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                                               (SettingParameter_1_System_Int32Enum_ *)settingParams.fields._punctualLightMovableDynamicCasterCount_k__BackingField,
			//                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     v13 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//             settingParams.fields._punctualLightShadowScreenSizeMin_k__BackingField,
			//             MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     v10.fields.m_punctualLightShadowScreenSizeMinSquared = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                                               settingParams.fields._punctualLightShadowScreenSizeMin_k__BackingField,
			//                                                               MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit)
			//                                                           * v13;
			//     v10.fields.m_punctualLightForceCullDistance = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                                                      settingParams.fields._punctualLightForceCullDistance_k__BackingField,
			//                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     v14 = (unsigned int)(v10.fields.m_dynamicMovablePunctualShadowCasterCount
			//                        + v10.fields.m_dynamicEnvPunctualShadowCasterCount);
			//     m_punctualShadowAtlasBaseTileSize = v10.fields.m_punctualShadowAtlasBaseTileSize;
			//     if ( (_DWORD)v14 )
			//     {
			//       v18 = sub_1826E82D0();
			//       v16 = (unsigned int)(4 * v10.fields.m_punctualShadowAtlasBaseTileSize);
			//       v17 = m_punctualShadowAtlasBaseTileSize * (v18 + 4);
			//     }
			//     else
			//     {
			//       v16 = (unsigned int)(4 * m_punctualShadowAtlasBaseTileSize);
			//       v17 = 4 * m_punctualShadowAtlasBaseTileSize;
			//     }
			//     v155 = __PAIR64__(v16, v17);
			//     v19 = __PAIR64__(v16, v17);
			//     punctualLightStaticAtlasAllocator = v10.fields.punctualLightStaticAtlasAllocator;
			//     if ( !punctualLightStaticAtlasAllocator )
			//       sub_180B536AC(v16, v14);
			//     punctualLightStaticAtlasAllocator.fields.m_atlasResolution = 4 * v10.fields.m_punctualShadowAtlasBaseTileSize;
			//     m_punctualShadowAtlasSize = v10.fields.m_punctualShadowAtlasSize;
			//     if ( m_punctualShadowAtlasSize.m_X != (_DWORD)v19
			//       || (v16 = HIDWORD(v19), m_punctualShadowAtlasSize.m_Y != HIDWORD(v19)) )
			//     {
			//       if ( v10.fields.m_cachedPunctualLightShadowAtlas )
			//       {
			//         UnityEngine::Rendering::RTHandle::Release(v10.fields.m_cachedPunctualLightShadowAtlas, 0LL);
			//         v10.fields.m_cachedPunctualLightShadowAtlas = 0LL;
			//         sub_1800054D0(
			//           (OneofDescriptor *)&v10.fields.m_cachedPunctualLightShadowAtlas,
			//           v22,
			//           v23,
			//           v24,
			//           *(String__Array **)colorFormat,
			//           *(String **)filterMode,
			//           *(MethodInfo **)wrapMode);
			//       }
			//       v10.fields.m_punctualShadowAtlasSize = (Vector2Int)v19;
			//     }
			//     if ( !v10.fields.m_cachedPunctualLightShadowAtlas )
			//     {
			//       m_X = v10.fields.m_punctualShadowAtlasSize.m_X;
			//       m_Y = v10.fields.m_punctualShadowAtlasSize.m_Y;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::RTHandles);
			//       v10.fields.m_cachedPunctualLightShadowAtlas = UnityEngine::Rendering::RTHandles::Alloc(
			//                                                        m_X,
			//                                                        m_Y,
			//                                                        1,
			//                                                        DepthBits__Enum_Depth16,
			//                                                        GraphicsFormat__Enum_R8G8B8A8_SRGB,
			//                                                        FilterMode__Enum_Point,
			//                                                        TextureWrapMode__Enum_Clamp,
			//                                                        TextureDimension__Enum_Tex2D,
			//                                                        0,
			//                                                        0,
			//                                                        0,
			//                                                        1,
			//                                                        1,
			//                                                        0.0,
			//                                                        MSAASamples__Enum_None,
			//                                                        0,
			//                                                        RenderTextureMemoryless__Enum_None,
			//                                                        (String *)"Punctual Shadowmap",
			//                                                        0LL);
			//       sub_1800054D0(
			//         (OneofDescriptor *)&v10.fields.m_cachedPunctualLightShadowAtlas,
			//         v27,
			//         v28,
			//         v29,
			//         *(String__Array **)colorFormat,
			//         *(String **)filterMode,
			//         *(MethodInfo **)wrapMode);
			//       HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::InvalidateAllShadowCaches(v10, 0LL);
			//     }
			//     if ( !v10.fields.m_targetPunctualAtlasAllocationThisFrame )
			//       sub_180B536AC(v16, v14);
			//     System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
			//       (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v10.fields.m_targetPunctualAtlasAllocationThisFrame,
			//       MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::Clear);
			//     m_castersToBeRemoved = v10.fields.m_castersToBeRemoved;
			//     if ( !m_castersToBeRemoved )
			//       sub_180B536AC(v31, v30);
			//     ++m_castersToBeRemoved.fields._version;
			//     m_castersToBeRemoved.fields._size = 0;
			//     if ( !hgCamera )
			//       sub_180B536AC(v31, v30);
			//     if ( !hgCamera.fields.camera )
			//       sub_180B536AC(v31, v30);
			//     transform = UnityEngine::Component::get_transform((Component *)hgCamera.fields.camera, 0LL);
			//     if ( !transform )
			//       sub_180B536AC(v35, v34);
			//     v159 = *UnityEngine::Transform::get_position((Vector3 *)&v163, transform, 0LL);
			//     if ( !v10.fields.m_activePunctualLightCachedShadowDescs )
			//       sub_180B536AC(v37, v36);
			//     v169 = *(Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)sub_180836C00(&v170, v10.fields.m_activePunctualLightCachedShadowDescs);
			//     v149.lightEntity = 0LL;
			//     *(_QWORD *)&v149.index = &v169;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::MoveNext(
			//                 &v169,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::MoveNext) )
			//       {
			//         *(LightCaster *)&v170._dictionary = v169._current.key;
			//         *(HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc *)&v170._current.key.m_X = v169._current.value;
			//         System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Deconstruct(
			//           (KeyValuePair_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)&v170,
			//           &key,
			//           &value,
			//           MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Deconstruct);
			//         current = key;
			//         v39 = value;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//         if ( HG::Rendering::Runtime::LightCaster::IsLightVaild(&current, 0LL) )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//           _unity_self = HG::Rendering::Runtime::LightCaster::GetHGSharedLightData(&current, 0LL);
			//           if ( UnityEngine::HGSharedLightData::get_isRuntimeShadowBaked_Injected(&_unity_self, 0LL) )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//             _unity_self = HG::Rendering::Runtime::LightCaster::GetHGSharedLightData(&current, 0LL);
			//             worldPosition = UnityEngine::HGSharedLightData::get_worldPosition((Vector3 *)&v163, &_unity_self, 0LL);
			//             v155 = *(_QWORD *)&worldPosition.x;
			//             v42 = worldPosition.z - v159.z;
			//             v43 = (__m128)HIDWORD(v155);
			//             v43.m128_f32[0] = *((float *)&v155 + 1) - v159.y;
			//             v44 = (__m128)(unsigned int)v155;
			//             v44.m128_f32[0] = *(float *)&v155 - v159.x;
			//             v161 = _mm_unpacklo_ps(v44, v43).m128_u64[0];
			//             v162 = v42;
			//             *(double *)v44.m128_u64 = sub_18238EFA0(&v161);
			//             v45 = v44.m128_f32[0];
			//             _unity_self = HG::Rendering::Runtime::LightCaster::GetHGSharedLightData(&current, 0LL);
			//             shadowCullDistance_Injected = UnityEngine::HGSharedLightData::get_shadowCullDistance_Injected(
			//                                             &_unity_self,
			//                                             0LL);
			//             if ( v10.fields.m_punctualLightForceCullDistance <= shadowCullDistance_Injected )
			//               shadowCullDistance_Injected = v10.fields.m_punctualLightForceCullDistance;
			//             if ( v45 < shadowCullDistance_Injected )
			//               continue;
			//           }
			//         }
			//         v47 = (List_1_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ *)v10.fields.m_castersToBeRemoved;
			//         if ( !v47 )
			//           sub_1802DC2C8(0LL, v40);
			//         System::Collections::Generic::List<Beyond::Gameplay::Core::SpawnerManager::SpawnDataDetail>::Add(
			//           v47,
			//           (SpawnerManager_SpawnDataDetail *)&current,
			//           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::LightCaster>::Add);
			//         v49 = v10.fields.punctualLightStaticAtlasAllocator;
			//         if ( !v49 )
			//           sub_1802DC2C8(0LL, v48);
			//         HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::Free(
			//           v49,
			//           _mm_cvtsi128_si32(_mm_srli_si128((__m128i)v39, 12)),
			//           0LL);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v171 )
			//     {
			//       v149.lightEntity = (Entity_1)v171.ex;
			//       lightEntity = (unsigned __int64)v149.lightEntity;
			//       if ( v149.lightEntity )
			//         sub_18000F780(*(_QWORD *)&v149.lightEntity);
			//       v10 = this;
			//     }
			//     v50 = (unsigned __int64)v10.fields.m_castersToBeRemoved;
			//     if ( !v50 )
			//       goto LABEL_190;
			//     System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::GetEnumerator(
			//       (List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)&v170,
			//       (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)v50,
			//       MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::LightCaster>::GetEnumerator);
			//     *(_OWORD *)&v168._list = *(_OWORD *)&v170._dictionary;
			//     v168._current = *(SpawnerManager_SpawnDataDetail *)&v170._current.key.m_X;
			//     v149.lightEntity = 0LL;
			//     *(_QWORD *)&v149.index = &v168;
			//     try
			//     {
			//       while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::Core::SpawnerManager::SpawnDataDetail>::MoveNext(
			//                 &v168,
			//                 MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::LightCaster>::MoveNext) )
			//       {
			//         m_activePunctualLightCachedShadowDescs = v10.fields.m_activePunctualLightCachedShadowDescs;
			//         if ( !m_activePunctualLightCachedShadowDescs )
			//           sub_1802DC2C8(0LL, v51);
			//         current = (LightCaster)v168._current;
			//         System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Remove(
			//           m_activePunctualLightCachedShadowDescs,
			//           &current,
			//           MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Remove);
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v172 )
			//     {
			//       v149.lightEntity = (Entity_1)v172.ex;
			//       if ( v149.lightEntity )
			//         sub_18000F780(*(_QWORD *)&v149.lightEntity);
			//       v10 = this;
			//     }
			//     v53 = 0;
			//     if ( v10.fields.m_dynamicMovablePunctualShadowCasterCount + v10.fields.m_dynamicEnvPunctualShadowCasterCount > 0 )
			//     {
			//       while ( 1 )
			//       {
			//         m_targetDynamicPunctualLights = v10.fields.m_targetDynamicPunctualLights;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//         lightEntity = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::LightCaster.static_fields;
			//         if ( !m_targetDynamicPunctualLights )
			//           break;
			//         v149 = *(LightCaster *)lightEntity;
			//         sub_1803EF6F4(m_targetDynamicPunctualLights, v53++, &v149);
			//         if ( v53 >= v10.fields.m_dynamicMovablePunctualShadowCasterCount
			//                   + v10.fields.m_dynamicEnvPunctualShadowCasterCount )
			//           goto LABEL_45;
			//       }
			// LABEL_190:
			//       sub_1802DC2C8(lightEntity, v50);
			//     }
			// LABEL_45:
			//     v152 = 0;
			//     v158 = 0;
			//     v157 = 0;
			//     v55 = 0;
			//     HasShaderDefine = UnityEngine::Rendering::GraphicsSettings::HasShaderDefine(
			//                         BuiltinShaderDefine__Enum_HG_RENDER_PATH_MOBILE,
			//                         0LL);
			//     instance = (AttributeCollection *)HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
			//     if ( !instance )
			//       goto LABEL_190;
			//     Count = System::ComponentModel::AttributeCollection::get_Count(instance, 0LL);
			//     LODWORD(v155) = Count;
			//     v58 = Count == 4;
			//     v148 = Count == 4;
			//     v59 = visibleLights;
			//     current = (LightCaster)*visibleLights;
			//     if ( punctualLightCount > 0 )
			//     {
			//       v60 = 0LL;
			//       while ( 1 )
			//       {
			//         v61 = v10.fields.punctualLightStaticAtlasAllocator;
			//         if ( !v61 )
			//           goto LABEL_190;
			//         lightEntity = (unsigned __int64)v61.fields.m_slotOccupied;
			//         if ( !lightEntity )
			//           goto LABEL_190;
			//         if ( v55 < *(_DWORD *)(lightEntity + 24) )
			//         {
			//           v62 = *(_QWORD *)&current.lightEntity + 148LL * *(int *)&lightIndices.m_Buffer[4 * v60];
			//           v63 = (__int64)&v59.m_Buffer[148 * *(int *)&lightIndices.m_Buffer[4 * v60]];
			//           v174 = *(_OWORD *)v63;
			//           v175 = *(_OWORD *)(v63 + 16);
			//           v176 = *(_OWORD *)(v63 + 32);
			//           v177 = *(_OWORD *)(v63 + 48);
			//           v178 = *(_OWORD *)(v63 + 64);
			//           v179 = *(_OWORD *)(v63 + 80);
			//           v180 = *(_OWORD *)(v63 + 96);
			//           v181 = *(_OWORD *)(v63 + 112);
			//           v182 = *(_OWORD *)(v63 + 128);
			//           v183 = *(_DWORD *)(v63 + 144);
			//           lightData = (HGSharedLightData)*((_QWORD *)&v182 + 1);
			//           type_Injected = UnityEngine::HGSharedLightData::get_type_Injected(&lightData, 0LL);
			//           lightEntity = HasShaderDefine;
			//           v50 = 0LL;
			//           if ( type_Injected == LightType__Enum_Point )
			//             v50 = HasShaderDefine;
			//           if ( !(_DWORD)v50 )
			//           {
			//             v163.key.lightEntity = *(Entity_1 *)(v62 + 116);
			//             v65 = *(float *)(v62 + 124) - v159.z;
			//             version = (__m128)v163.key.lightEntity.version;
			//             version.m128_f32[0] = *(float *)&v163.key.lightEntity.version - v159.y;
			//             globalIndex = (__m128)v163.key.lightEntity.globalIndex;
			//             globalIndex.m128_f32[0] = *(float *)&v163.key.lightEntity.globalIndex - v159.x;
			//             v161 = _mm_unpacklo_ps(globalIndex, version).m128_u64[0];
			//             v162 = v65;
			//             *(double *)globalIndex.m128_u64 = sub_18238EFA0(&v161);
			//             v68 = globalIndex.m128_f32[0];
			//             if ( UnityEngine::HGSharedLightData::get_type_Injected(&lightData, 0LL) == LightType__Enum_Point
			//               || UnityEngine::HGSharedLightData::get_type_Injected(&lightData, 0LL) == LightType__Enum_Spot )
			//             {
			//               if ( UnityEngine::HGSharedLightData::get_shadows_Injected(&lightData, 0LL) )
			//               {
			//                 m_punctualLightForceCullDistance = UnityEngine::HGSharedLightData::get_shadowCullDistance_Injected(
			//                                                      &lightData,
			//                                                      0LL);
			//                 if ( v10.fields.m_punctualLightForceCullDistance <= m_punctualLightForceCullDistance )
			//                   m_punctualLightForceCullDistance = v10.fields.m_punctualLightForceCullDistance;
			//                 if ( m_punctualLightForceCullDistance > v68 )
			//                 {
			//                   if ( UnityEngine::HGSharedLightData::get_type_Injected(&lightData, 0LL) == LightType__Enum_Spot )
			//                     goto LABEL_210;
			//                   if ( UnityEngine::HGSharedLightData::get_type_Injected(&lightData, 0LL) == LightType__Enum_Point )
			//                   {
			//                     HasExactlyOneCaster = UnityEngine::HGSharedLightData::IsPointLightHasExactlyOneCaster(
			//                                             &lightData,
			//                                             0LL);
			//                     v71 = 0;
			//                     if ( HasExactlyOneCaster )
			//                       LOBYTE(v71) = Count != 4;
			//                     if ( v71 | v58 )
			//                     {
			// LABEL_210:
			//                       if ( v152 < v10.fields.m_dynamicMovablePunctualShadowCasterCount
			//                                 + v10.fields.m_dynamicEnvPunctualShadowCasterCount
			//                         && (UnityEngine::HGSharedLightData::get_isDynamicShadowCaster(&lightData, 0LL)
			//                          && (UnityEngine::HGSharedLightData::get_castStaticObjects(&lightData, 0LL)
			//                           || UnityEngine::HGSharedLightData::get_castDynamicObjects(&lightData, 0LL))
			//                          || UnityEngine::HGSharedLightData::get_castDynamicObjects(&lightData, 0LL)) )
			//                       {
			//                         if ( UnityEngine::HGSharedLightData::get_type_Injected(&lightData, 0LL) )
			//                         {
			//                           for ( i = 0; i < 6; ++i )
			//                           {
			//                             if ( UnityEngine::HGSharedLightData::GetPointLightShadowCasterFace(
			//                                    &lightData,
			//                                    (CubemapFace__Enum)i,
			//                                    0LL) )
			//                             {
			//                               v73 = lightData;
			//                               Entity = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(lightData, 0LL);
			//                               v149 = 0LL;
			//                               HG::Rendering::Runtime::LightCaster::LightCaster(&v149, Entity, i, 0LL);
			//                               HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::AppendNewDynamicPunctualLight(
			//                                 v10,
			//                                 v73,
			//                                 &v149,
			//                                 v58,
			//                                 &v152,
			//                                 &v158,
			//                                 &v157,
			//                                 0LL);
			//                             }
			//                           }
			//                         }
			//                         else
			//                         {
			//                           v75 = lightData;
			//                           v76 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(lightData, 0LL);
			//                           v149 = 0LL;
			//                           HG::Rendering::Runtime::LightCaster::LightCaster(&v149, v76, 0, 0LL);
			//                           HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::AppendNewDynamicPunctualLight(
			//                             v10,
			//                             v75,
			//                             &v149,
			//                             v58,
			//                             &v152,
			//                             &v158,
			//                             &v157,
			//                             0LL);
			//                         }
			//                       }
			//                     }
			//                   }
			//                   if ( !UnityEngine::HGSharedLightData::get_isDynamicShadowCaster(&lightData, 0LL)
			//                     && UnityEngine::HGSharedLightData::get_castStaticObjects(&lightData, 0LL) )
			//                   {
			//                     v77 = UnityEngine::HGSharedLightData::get_type_Injected(&lightData, 0LL) != LightType__Enum_Spot
			//                         ? 6
			//                         : 1;
			//                     for ( j = 0; j < v77; ++j )
			//                     {
			//                       if ( UnityEngine::HGSharedLightData::get_type_Injected(&lightData, 0LL) == LightType__Enum_Point
			//                         && UnityEngine::HGSharedLightData::GetPointLightShadowCasterFace(
			//                              &lightData,
			//                              (CubemapFace__Enum)j,
			//                              0LL)
			//                         || UnityEngine::HGSharedLightData::get_type_Injected(&lightData, 0LL) == LightType__Enum_Spot )
			//                       {
			//                         v79 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(lightData, 0LL);
			//                         sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//                         HG::Rendering::Runtime::LightCaster::LightCaster(&requestLightCaster, v79, j, 0LL);
			//                         lightEntity = (unsigned __int64)v10.fields.m_targetPunctualAtlasAllocationThisFrame;
			//                         if ( !lightEntity )
			//                           goto LABEL_190;
			//                         v80 = requestLightCaster;
			//                         v149 = requestLightCaster;
			//                         if ( System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::ContainsKey(
			//                                (Dictionary_2_HG_Rendering_Runtime_LightCaster_System_Int32_ *)lightEntity,
			//                                &v149,
			//                                MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::ContainsKey) )
			//                         {
			//                           DebugName = UnityEngine::HGSharedLightData::GetDebugName(&lightData, 0LL);
			//                           v86 = System::String::Concat(
			//                                   (String *)"HGPunctualLightShadowManager: 当前灯光阴影存在异常，我们推测是特效误设置，请通知相关老师进行修改。灯光名：",
			//                                   DebugName,
			//                                   0LL);
			//                           HG::Rendering::HGRPLogger::LogCritical(v86, 0LL);
			//                         }
			//                         else
			//                         {
			//                           m_targetPunctualAtlasAllocationThisFrame = v10.fields.m_targetPunctualAtlasAllocationThisFrame;
			//                           lightEntity = (unsigned __int64)v10.fields.punctualLightStaticAtlasAllocator;
			//                           v50 = (unsigned int)v55++;
			//                           if ( !lightEntity )
			//                             goto LABEL_190;
			//                           SlotLevelFromIndex = HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::GetSlotLevelFromIndex(
			//                                                  (HGPunctualLightStaticAtlasAllocator *)lightEntity,
			//                                                  v50,
			//                                                  0LL);
			//                           if ( !m_targetPunctualAtlasAllocationThisFrame )
			//                             goto LABEL_190;
			//                           v149 = v80;
			//                           System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::Add(
			//                             m_targetPunctualAtlasAllocationThisFrame,
			//                             &v149,
			//                             SlotLevelFromIndex,
			//                             MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::Add);
			//                           v83 = v10.fields.punctualLightStaticAtlasAllocator;
			//                           if ( !v83 )
			//                             goto LABEL_190;
			//                           m_slotOccupied = v83.fields.m_slotOccupied;
			//                           if ( !m_slotOccupied )
			//                             goto LABEL_190;
			//                           if ( v55 >= m_slotOccupied.max_length.size )
			//                             break;
			//                         }
			//                       }
			//                     }
			//                     v58 = v148;
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//           ++v60;
			//           v59 = visibleLights;
			//           Count = v155;
			//           if ( v60 < punctualLightCount )
			//             continue;
			//         }
			//         break;
			//       }
			//     }
			//     m_targetUpdateRequest = v10.fields.m_targetUpdateRequest;
			//     if ( !m_targetUpdateRequest )
			//       goto LABEL_190;
			//     m_targetUpdateRequest.fields.requestType = 0;
			//     v50 = (unsigned __int64)v10.fields.m_targetPunctualAtlasAllocationThisFrame;
			//     if ( !v50 )
			//       goto LABEL_190;
			//     System::Collections::Generic::Dictionary<UnityEngine::Vector2Int,Beyond::Gameplay::RemoteFactory::RemoteFactoryGridSampler::SampleItem>::GetEnumerator(
			//       &v170,
			//       (Dictionary_2_UnityEngine_Vector2Int_Beyond_Gameplay_RemoteFactory_RemoteFactoryGridSampler_SampleItem_ *)v50,
			//       MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::GetEnumerator);
			//     v167 = (Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_System_Int32_)v170;
			//     current.lightEntity = 0LL;
			//     *(_QWORD *)&current.index = &v167;
			//     try
			//     {
			//       while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,int>::MoveNext(
			//                 &v167,
			//                 MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,int>::MoveNext) )
			//       {
			//         v163 = v167._current;
			//         System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,int>::Deconstruct(
			//           &v163,
			//           &key,
			//           v153,
			//           MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,int>::Deconstruct);
			//         v89 = v10.fields.m_activePunctualLightCachedShadowDescs;
			//         if ( !v89 )
			//           sub_1802DC2C8(0LL, v88);
			//         v90 = key;
			//         requestLightCaster = key;
			//         if ( System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::ContainsKey(
			//                v89,
			//                &requestLightCaster,
			//                MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::ContainsKey) )
			//         {
			//           v97 = v10.fields.m_activePunctualLightCachedShadowDescs;
			//           if ( !v97 )
			//             sub_1802DC2C8(v92, 0LL);
			//           requestLightCaster = v90;
			//           System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Item(
			//             &value,
			//             v97,
			//             &requestLightCaster,
			//             MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Item);
			//           v99 = value;
			//           v149 = (LightCaster)value;
			//           v100 = _mm_cvtsi128_si32((__m128i)value);
			//           v101 = (unsigned int)v153[0];
			//           if ( v100 >= v153[0] )
			//             goto LABEL_115;
			//           v102 = v10.fields.m_targetUpdateRequest;
			//           if ( !v102 )
			//             sub_1802DC2C8((unsigned int)v153[0], v98);
			//           if ( v102.fields.requestType >= 3 )
			//           {
			// LABEL_115:
			//             m_cachedHashCode = (unsigned int)v149.m_cachedHashCode;
			//           }
			//           else
			//           {
			//             v102.fields.requestType = 3;
			//             v103 = v10.fields.m_targetUpdateRequest;
			//             if ( !v103 )
			//               sub_1802DC2C8(v101, v98);
			//             m_cachedHashCode = (unsigned int)_mm_cvtsi128_si32(_mm_srli_si128((__m128i)v99, 12));
			//             v103.fields.sourceSlot = m_cachedHashCode;
			//             v105 = v10.fields.m_targetUpdateRequest;
			//             if ( !v105 )
			//               sub_1802DC2C8(v101, m_cachedHashCode);
			//             v105.fields.targetLevel = v101;
			//             v106 = v10.fields.m_targetUpdateRequest;
			//             if ( !v106 )
			//               sub_1802DC2C8(v101, m_cachedHashCode);
			//             v106.fields.requestLightCaster = v90;
			//           }
			//           if ( v100 > (int)v101 )
			//           {
			//             v107 = v10.fields.m_targetUpdateRequest;
			//             if ( !v107 )
			//               sub_1802DC2C8(v101, m_cachedHashCode);
			//             if ( v107.fields.requestType < 2 )
			//             {
			//               v107.fields.requestType = 2;
			//               v108 = v10.fields.m_targetUpdateRequest;
			//               if ( !v108 )
			//                 sub_1802DC2C8(v101, m_cachedHashCode);
			//               v108.fields.sourceSlot = m_cachedHashCode;
			//               v109 = v10.fields.m_targetUpdateRequest;
			//               if ( !v109 )
			//                 sub_1802DC2C8(v101, m_cachedHashCode);
			//               v109.fields.targetLevel = v101;
			//               v110 = v10.fields.m_targetUpdateRequest;
			//               if ( !v110 )
			//                 sub_1802DC2C8(v101, m_cachedHashCode);
			//               v110.fields.requestLightCaster = v90;
			//             }
			//           }
			//           v149.index = UnityEngine::Time::get_realtimeSinceStartup(0LL);
			//           v112 = v10.fields.m_activePunctualLightCachedShadowDescs;
			//           if ( !v112 )
			//             sub_1802DC2C8(0LL, v111);
			//           requestLightCaster = v149;
			//           v149 = v90;
			//           System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::set_Item(
			//             v112,
			//             &v149,
			//             (HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc *)&requestLightCaster,
			//             MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::set_Item);
			//         }
			//         else
			//         {
			//           v93 = v10.fields.m_targetUpdateRequest;
			//           if ( !v93 )
			//             sub_1802DC2C8(v92, v91);
			//           if ( v93.fields.requestType < 1 )
			//           {
			//             v93.fields.requestType = 1;
			//             v94 = v10.fields.m_targetUpdateRequest;
			//             if ( !v94 )
			//               sub_1802DC2C8(v92, v91);
			//             v94.fields.sourceSlot = -1;
			//             v95 = v10.fields.m_targetUpdateRequest;
			//             if ( !v95 )
			//               sub_1802DC2C8(0LL, v91);
			//             v95.fields.targetLevel = v153[0];
			//             v96 = v10.fields.m_targetUpdateRequest;
			//             if ( !v96 )
			//               sub_1802DC2C8(v95, v91);
			//             v96.fields.requestLightCaster = v90;
			//           }
			//         }
			//       }
			//     }
			//     catch ( Il2CppExceptionWrapper *v173 )
			//     {
			//       v50 = (unsigned __int64)&v143;
			//       current.lightEntity = (Entity_1)v173.ex;
			//       if ( current.lightEntity )
			//         sub_18000F780(*(_QWORD *)&current.lightEntity);
			//       v10 = this;
			//     }
			//     lightEntity = (unsigned __int64)v10.fields.m_targetUpdateRequest;
			//     if ( !lightEntity )
			//       goto LABEL_190;
			//     v113 = *(_DWORD *)(lightEntity + 16);
			//     if ( v113 )
			//     {
			//       lightEntity = v113 - 1;
			//       if ( (_DWORD)lightEntity )
			//       {
			//         if ( (unsigned int)(lightEntity - 1) > 1 )
			//           return;
			//         v114 = v10.fields.m_targetUpdateRequest;
			//         requestLightCaster = v114.fields.requestLightCaster;
			//         v115 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::ForceAllocForCaster(
			//                  v10,
			//                  &requestLightCaster,
			//                  v114.fields.targetLevel,
			//                  0LL);
			//         lightEntity = (unsigned __int64)v10.fields.punctualLightStaticAtlasAllocator;
			//         v50 = (unsigned __int64)v10.fields.m_targetUpdateRequest;
			//         if ( !v50 )
			//           goto LABEL_190;
			//         if ( !lightEntity )
			//           goto LABEL_190;
			//         HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::Free(
			//           (HGPunctualLightStaticAtlasAllocator *)lightEntity,
			//           *(_DWORD *)(v50 + 36),
			//           0LL);
			//         m_targetStaticPunctualLights = v10.fields.m_targetStaticPunctualLights;
			//         v117 = v10.fields.m_targetUpdateRequest;
			//         if ( !v117 )
			//           goto LABEL_190;
			//         sourceSlot = v117.fields.sourceSlot;
			//         sub_180002C70(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
			//         v121 = sub_1827D2700(v120, v119);
			//         if ( !m_targetStaticPunctualLights )
			//           goto LABEL_190;
			//         if ( (unsigned int)sourceSlot >= m_targetStaticPunctualLights.max_length.size )
			//           goto LABEL_189;
			//         m_targetStaticPunctualLights.vector[sourceSlot] = (Entity_1)v121;
			//         v50 = (unsigned __int64)v10.fields.m_activePunctualLightCachedShadowDescs;
			//         v124 = v10.fields.m_targetUpdateRequest;
			//         if ( !v124 )
			//           goto LABEL_190;
			//         if ( !v50 )
			//           goto LABEL_190;
			//         requestLightCaster = v124.fields.requestLightCaster;
			//         System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Item(
			//           (HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc *)&v149,
			//           (Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)v50,
			//           &requestLightCaster,
			//           MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Item);
			//         v125 = v10.fields.m_targetUpdateRequest;
			//         if ( !v125 )
			//           goto LABEL_190;
			//         v149.lightEntity.globalIndex = v125.fields.targetLevel;
			//         v149.m_cachedHashCode = v115;
			//         lightEntity = (unsigned __int64)v10.fields.m_activePunctualLightCachedShadowDescs;
			//         v126 = v10.fields.m_targetUpdateRequest;
			//         if ( !v126 )
			//           goto LABEL_190;
			//         if ( !lightEntity )
			//           goto LABEL_190;
			//         requestLightCaster = v149;
			//         v149 = v126.fields.requestLightCaster;
			//         System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::set_Item(
			//           (Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)lightEntity,
			//           &v149,
			//           (HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc *)&requestLightCaster,
			//           MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::set_Item);
			//         v127 = v10.fields.m_targetUpdateRequest;
			//         if ( !v127 )
			//           goto LABEL_190;
			//         v127.fields.targetSlot = v115;
			//         v128 = v10.fields.m_targetUpdateRequest;
			//         if ( !v128 )
			//           goto LABEL_190;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//         HGSharedLightData = HG::Rendering::Runtime::LightCaster::GetHGSharedLightData(
			//                               &v128.fields.requestLightCaster,
			//                               0LL);
			//         p_HGSharedLightData = &HGSharedLightData;
			//       }
			//       else
			//       {
			//         v130 = v10.fields.m_targetUpdateRequest;
			//         if ( !v130 )
			//           goto LABEL_190;
			//         requestLightCaster = v130.fields.requestLightCaster;
			//         v131 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::ForceAllocForCaster(
			//                  v10,
			//                  &requestLightCaster,
			//                  v130.fields.targetLevel,
			//                  0LL);
			//         v115 = v131;
			//         value = 0LL;
			//         value.shadowCacheSlotIndex = v131;
			//         lightEntity = (unsigned __int64)v10.fields.m_targetUpdateRequest;
			//         if ( !lightEntity )
			//           goto LABEL_190;
			//         value.targetRenderLevel = *(_DWORD *)(lightEntity + 40);
			//         value.lastVisitedTime = -1.0;
			//         lightEntity = (unsigned __int64)v10.fields.m_activePunctualLightCachedShadowDescs;
			//         v132 = v10.fields.m_targetUpdateRequest;
			//         if ( !v132 )
			//           goto LABEL_190;
			//         if ( !lightEntity )
			//           goto LABEL_190;
			//         requestLightCaster = (LightCaster)value;
			//         v149 = v132.fields.requestLightCaster;
			//         System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Add(
			//           (Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)lightEntity,
			//           &v149,
			//           (HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc *)&requestLightCaster,
			//           MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Add);
			//         v133 = v10.fields.m_targetUpdateRequest;
			//         if ( !v133 )
			//           goto LABEL_190;
			//         v133.fields.targetSlot = v115;
			//         v134 = v10.fields.m_targetUpdateRequest;
			//         if ( !v134 )
			//           goto LABEL_190;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//         v165 = HG::Rendering::Runtime::LightCaster::GetHGSharedLightData(&v134.fields.requestLightCaster, 0LL);
			//         p_HGSharedLightData = &v165;
			//       }
			//       UnityEngine::HGSharedLightData::set_isRuntimeShadowBaked_Injected(p_HGSharedLightData, 1, 0LL);
			//       v135 = v10.fields.m_targetUpdateRequest;
			//       v50 = (unsigned __int64)v10.fields.m_targetStaticPunctualLights;
			//       if ( !v135 || !v50 )
			//         goto LABEL_190;
			//       v136 = v135.fields.requestLightCaster.lightEntity;
			//       if ( (unsigned int)v115 < *(_DWORD *)(v50 + 24) )
			//       {
			//         *(Entity_1 *)(v50 + 8 * v115 + 32) = v136;
			//         return;
			//       }
			// LABEL_189:
			//       sub_180070260(lightEntity, v50, v122, v123);
			//     }
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::InvalidateAllShadowCaches(v10, 0LL);
			//     v139 = v10.fields.m_targetUpdateRequest;
			//     if ( !v139 )
			//       sub_180B536AC(v138, v137);
			//     v139.fields.requestType = 0;
			//   }
			// }
			// 
		}

		public int GetShadowCacheIndexForCaster(LightCaster lightCaster)
		{
			// // Int32 GetShadowCacheIndexForCaster(LightCaster)
			// int32_t HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
			//         HGPunctualLightShadowManagerV2 *this,
			//         LightCaster *lightCaster,
			//         MethodInfo *method)
			// {
			//   Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *v5; // rdx
			//   __int64 v6; // r9
			//   int v7; // edi
			//   Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *m_activePunctualLightCachedShadowDescs; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   LightCaster v11; // [rsp+20h] [rbp-30h] BYREF
			//   LightCaster v12; // [rsp+30h] [rbp-20h] BYREF
			//   LightCaster v13; // [rsp+40h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D919E9F )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::ContainsKey);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Item);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCaster);
			//     byte_18D919E9F = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1612, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1612, 0LL);
			//     if ( Patch )
			//     {
			//       v13 = *lightCaster;
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_620(Patch, (Object *)this, &v13, 0LL);
			//     }
			// LABEL_15:
			//     sub_180B536AC(m_activePunctualLightCachedShadowDescs, v5);
			//   }
			//   v7 = 0;
			//   if ( this.fields.m_dynamicEnvPunctualShadowCasterCount + this.fields.m_dynamicMovablePunctualShadowCasterCount <= 0 )
			//   {
			// LABEL_8:
			//     m_activePunctualLightCachedShadowDescs = this.fields.m_activePunctualLightCachedShadowDescs;
			//     if ( m_activePunctualLightCachedShadowDescs )
			//     {
			//       v13 = *lightCaster;
			//       if ( !System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::ContainsKey(
			//               m_activePunctualLightCachedShadowDescs,
			//               &v13,
			//               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::ContainsKey) )
			//         return -1;
			//       v5 = this.fields.m_activePunctualLightCachedShadowDescs;
			//       if ( v5 )
			//       {
			//         v13 = *lightCaster;
			//         return *(_DWORD *)(sub_180836C20(&v12, v5, &v13) + 12);
			//       }
			//     }
			//     goto LABEL_15;
			//   }
			//   while ( 1 )
			//   {
			//     m_activePunctualLightCachedShadowDescs = (Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)this.fields.m_targetDynamicPunctualLights;
			//     if ( !m_activePunctualLightCachedShadowDescs )
			//       goto LABEL_15;
			//     sub_18037A36C(m_activePunctualLightCachedShadowDescs, &v11, v7, v6);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//     v13 = *lightCaster;
			//     v12 = v11;
			//     if ( HG::Rendering::Runtime::LightCaster::op_Equality(&v13, &v12, 0LL) )
			//       return v7 + 40;
			//     if ( ++v7 >= this.fields.m_dynamicMovablePunctualShadowCasterCount
			//                + this.fields.m_dynamicEnvPunctualShadowCasterCount )
			//       goto LABEL_8;
			//   }
			// }
			// 
			return 0;
		}

		private int ForceAllocForCaster(LightCaster lightCaster, int targetLevel)
		{
			// // Int32 ForceAllocForCaster(LightCaster, Int32)
			// // Hidden C++ exception states: #wind=1
			// int32_t HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::ForceAllocForCaster(
			//         HGPunctualLightShadowManagerV2 *this,
			//         LightCaster *lightCaster,
			//         int32_t targetLevel,
			//         MethodInfo *method)
			// {
			//   int32_t v4; // edi
			//   HGPunctualLightShadowManagerV2 *v6; // rbx
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   int32_t result; // eax
			//   float v10; // xmm6_4
			//   __int64 v11; // rdx
			//   LightCaster__StaticFields *static_fields; // rcx
			//   float v13; // xmm0_4
			//   Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *v14; // rcx
			//   HGPunctualLightStaticAtlasAllocator *punctualLightStaticAtlasAllocator; // rsi
			//   Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *m_activePunctualLightCachedShadowDescs; // rdx
			//   LightCaster v17; // xmm6
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   LightCaster key; // [rsp+30h] [rbp-E8h] BYREF
			//   HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc value; // [rsp+40h] [rbp-D8h] BYREF
			//   Il2CppException *ex; // [rsp+50h] [rbp-C8h]
			//   Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *v24; // [rsp+58h] [rbp-C0h]
			//   LightCaster NULL_CASTER; // [rsp+60h] [rbp-B8h] BYREF
			//   Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ v26; // [rsp+70h] [rbp-A8h] BYREF
			//   Il2CppExceptionWrapper *v27; // [rsp+A8h] [rbp-70h] BYREF
			//   KeyValuePair_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ current; // [rsp+B0h] [rbp-68h] BYREF
			// 
			//   v4 = targetLevel;
			//   v6 = this;
			//   if ( !byte_18D919EA0 )
			//   {
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::GetEnumerator);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Remove);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Item);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Dispose);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::MoveNext);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Current);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Deconstruct);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCaster);
			//     sub_18003C530(&off_18D5F3420);
			//     byte_18D919EA0 = 1;
			//   }
			//   memset(&v26, 0, sizeof(v26));
			//   key = 0LL;
			//   value = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1645, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1645, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v20, v19);
			//     key = *lightCaster;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_631(Patch, (Object *)v6, &key, v4, 0LL);
			//   }
			//   else
			//   {
			//     if ( !v6.fields.punctualLightStaticAtlasAllocator )
			//       sub_180B536AC(v8, v7);
			//     result = HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::TryAlloc(
			//                v6.fields.punctualLightStaticAtlasAllocator,
			//                v4,
			//                0LL);
			//     if ( result == -1 )
			//     {
			//       v10 = 3.4028235e38;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::LightCaster.static_fields;
			//       NULL_CASTER = static_fields.NULL_CASTER;
			//       if ( !v6.fields.m_activePunctualLightCachedShadowDescs )
			//         sub_180B536AC(static_fields, v11);
			//       v26 = *(Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)sub_180836C00(&current, v6.fields.m_activePunctualLightCachedShadowDescs);
			//       ex = 0LL;
			//       v24 = &v26;
			//       try
			//       {
			//         while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::MoveNext(
			//                   &v26,
			//                   MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::MoveNext) )
			//         {
			//           current = v26._current;
			//           System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Deconstruct(
			//             &current,
			//             &key,
			//             &value,
			//             MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Deconstruct);
			//           if ( _mm_cvtsi128_si32((__m128i)value) == v4 )
			//           {
			//             v13 = _mm_shuffle_ps((__m128)value, (__m128)value, 170).m128_f32[0];
			//             if ( v10 > v13 )
			//             {
			//               v10 = v13;
			//               NULL_CASTER = key;
			//             }
			//           }
			//         }
			//       }
			//       catch ( Il2CppExceptionWrapper *v27 )
			//       {
			//         ex = v27.ex;
			//         if ( ex )
			//           sub_18000F780(ex);
			//         v4 = targetLevel;
			//         v6 = this;
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//       if ( !HG::Rendering::Runtime::LightCaster::IsLightVaild(&NULL_CASTER, 0LL) )
			//         goto LABEL_20;
			//       punctualLightStaticAtlasAllocator = v6.fields.punctualLightStaticAtlasAllocator;
			//       m_activePunctualLightCachedShadowDescs = v6.fields.m_activePunctualLightCachedShadowDescs;
			//       if ( !m_activePunctualLightCachedShadowDescs )
			//         goto LABEL_27;
			//       v17 = NULL_CASTER;
			//       key = NULL_CASTER;
			//       System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Item(
			//         &value,
			//         m_activePunctualLightCachedShadowDescs,
			//         &key,
			//         MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Item);
			//       if ( !punctualLightStaticAtlasAllocator
			//         || (HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::Free(
			//               punctualLightStaticAtlasAllocator,
			//               value.shadowCacheSlotIndex,
			//               0LL),
			//             (v14 = v6.fields.m_activePunctualLightCachedShadowDescs) == 0LL)
			//         || (key = v17,
			//             System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Remove(
			//               v14,
			//               &key,
			//               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Remove),
			//             (v14 = (Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)v6.fields.punctualLightStaticAtlasAllocator) == 0LL) )
			//       {
			// LABEL_27:
			//         sub_1802DC2C8(v14, m_activePunctualLightCachedShadowDescs);
			//       }
			//       result = HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::TryAlloc(
			//                  (HGPunctualLightStaticAtlasAllocator *)v14,
			//                  v4,
			//                  0LL);
			//       if ( result == -1 )
			//       {
			// LABEL_20:
			//         HG::Rendering::HGRPLogger::LogError(
			//           (String *)"HGPunctualLightShadowManagerV2: Internal error happens when allocating page for shadow caster.",
			//           0LL);
			//         return -1;
			//       }
			//     }
			//   }
			//   return result;
			// }
			// 
			return 0;
		}

		private void GetShadowRenderType(HGSharedLightData light, bool isDynamicRequest, out bool castStaticObjects, out bool castDynamicObjects)
		{
			// // Void GetShadowRenderType(HGSharedLightData, Boolean, Boolean ByRef, Boolean ByRef)
			// void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowRenderType(
			//         HGPunctualLightShadowManagerV2 *this,
			//         HGSharedLightData light,
			//         bool isDynamicRequest,
			//         bool *castStaticObjects,
			//         bool *castDynamicObjects,
			//         MethodInfo *method)
			// {
			//   bool *v9; // rbx
			//   __int64 v10; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   HGSharedLightData P1; // [rsp+58h] [rbp+10h] BYREF
			// 
			//   P1 = light;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1847, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1847, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v10);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_713(
			//       Patch,
			//       (Object *)this,
			//       P1,
			//       isDynamicRequest,
			//       castStaticObjects,
			//       castDynamicObjects,
			//       0LL);
			//   }
			//   else
			//   {
			//     v9 = castDynamicObjects;
			//     *castStaticObjects = 0;
			//     *v9 = 0;
			//     if ( isDynamicRequest )
			//     {
			//       if ( !UnityEngine::HGSharedLightData::get_isDynamicShadowCaster(&P1, 0LL) )
			//       {
			//         if ( UnityEngine::HGSharedLightData::get_castStaticObjects(&P1, 0LL) )
			//         {
			// LABEL_5:
			//           *v9 = 1;
			//           *castStaticObjects = 1;
			//           return;
			//         }
			//         goto LABEL_10;
			//       }
			//       if ( !UnityEngine::HGSharedLightData::get_castStaticObjects(&P1, 0LL)
			//         || UnityEngine::HGSharedLightData::get_castDynamicObjects(&P1, 0LL) )
			//       {
			//         if ( UnityEngine::HGSharedLightData::get_castStaticObjects(&P1, 0LL)
			//           || !UnityEngine::HGSharedLightData::get_castDynamicObjects(&P1, 0LL) )
			//         {
			//           goto LABEL_5;
			//         }
			// LABEL_10:
			//         *castStaticObjects = 0;
			//         *v9 = 1;
			//         return;
			//       }
			//     }
			//     *castStaticObjects = 1;
			//     *v9 = 0;
			//   }
			// }
			// 
		}

		private PerObjectData GetRendererConfig(HGSharedLightData light, bool isDynamicRequest)
		{
			// // PerObjectData GetRendererConfig(HGSharedLightData, Boolean)
			// PerObjectData__Enum HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetRendererConfig(
			//         HGPunctualLightShadowManagerV2 *this,
			//         HGSharedLightData light,
			//         bool isDynamicRequest,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   bool castStaticObjects; // [rsp+30h] [rbp-18h] BYREF
			//   bool castDynamicObjects; // [rsp+31h] [rbp-17h] BYREF
			// 
			//   castStaticObjects = 0;
			//   castDynamicObjects = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1848, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1848, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_714(Patch, (Object *)this, light, isDynamicRequest, 0LL);
			//   }
			//   else
			//   {
			//     HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowRenderType(
			//       this,
			//       light,
			//       isDynamicRequest,
			//       &castStaticObjects,
			//       &castDynamicObjects,
			//       0LL);
			//     return (castDynamicObjects ? 0x2000 : 0) | (castStaticObjects ? 22528 : 18432);
			//   }
			// }
			// 
			return (PerObjectData)PerObjectData.None;
		}

		private void GetECSRenderFlags(HGSharedLightData light, bool isDynamicRequest, out HGObjectFlags objectFlags, out HGObjectFlags objectFlagsMask, out HGRenderFlags renderFlags, out HGRenderFlags renderFlagsMask)
		{
			// // Void GetECSRenderFlags(HGSharedLightData, Boolean, HGObjectFlags ByRef, HGObjectFlags ByRef, HGRenderFlags ByRef, HGRenderFlags ByRef)
			// void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetECSRenderFlags(
			//         HGPunctualLightShadowManagerV2 *this,
			//         HGSharedLightData light,
			//         bool isDynamicRequest,
			//         HGObjectFlags__Enum *objectFlags,
			//         HGObjectFlags__Enum *objectFlagsMask,
			//         HGRenderFlags__Enum *renderFlags,
			//         HGRenderFlags__Enum *renderFlagsMask,
			//         MethodInfo *method)
			// {
			//   bool v12; // zf
			//   __int64 v13; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   bool castStaticObjects; // [rsp+50h] [rbp-38h] BYREF
			//   bool castDynamicObjects; // [rsp+51h] [rbp-37h] BYREF
			// 
			//   castStaticObjects = 0;
			//   castDynamicObjects = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1849, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1849, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v13);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_715(
			//       Patch,
			//       (Object *)this,
			//       light,
			//       isDynamicRequest,
			//       objectFlags,
			//       objectFlagsMask,
			//       renderFlags,
			//       renderFlagsMask,
			//       0LL);
			//   }
			//   else
			//   {
			//     *objectFlags = HGObjectFlags__Enum_RealtimeShadowCaster|HGObjectFlags__Enum_CastShadow;
			//     *objectFlagsMask = HGObjectFlags__Enum_RealtimeShadowCaster|HGObjectFlags__Enum_CastShadow;
			//     *renderFlags = HGRenderFlags__Enum_RealtimeShadowCaster|HGRenderFlags__Enum_CastShadow;
			//     *renderFlagsMask = HGRenderFlags__Enum_RealtimeShadowCaster|HGRenderFlags__Enum_CastShadow;
			//     HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowRenderType(
			//       this,
			//       light,
			//       isDynamicRequest,
			//       &castStaticObjects,
			//       &castDynamicObjects,
			//       0LL);
			//     v12 = !castStaticObjects;
			//     if ( castStaticObjects )
			//     {
			//       if ( !castDynamicObjects )
			//       {
			//         *objectFlags |= 0x4000000u;
			//         *objectFlagsMask |= 0x4000000u;
			//         *renderFlags |= 0x1000000u;
			//         *renderFlagsMask |= 0x1000000u;
			//       }
			//       v12 = !castStaticObjects;
			//     }
			//     if ( v12 && castDynamicObjects )
			//     {
			//       *objectFlagsMask |= 0x4000000u;
			//       *renderFlagsMask |= 0x1000000u;
			//     }
			//   }
			// }
			// 
		}

		private void PrepareRendererList(HGSharedLightData light, HGCamera hgCamera, ScriptableRenderContext context, Matrix4x4 viewProj, bool isDynamicRequest, ref RendererList rendererList)
		{
			// // Void PrepareRendererList(HGSharedLightData, HGCamera, ScriptableRenderContext, Matrix4x4, Boolean, RendererList ByRef)
			// void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PrepareRendererList(
			//         HGPunctualLightShadowManagerV2 *this,
			//         HGSharedLightData light,
			//         HGCamera *hgCamera,
			//         ScriptableRenderContext context,
			//         Matrix4x4 *viewProj,
			//         bool isDynamicRequest,
			//         RendererList *rendererList,
			//         MethodInfo *method)
			// {
			//   RendererList nullRendererList; // xmm0
			//   __int64 v11; // rdx
			//   Camera *camera; // rcx
			//   Matrix4x4 *v13; // rbx
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm1
			//   HGPunctualLightShadowManagerV2__StaticFields *static_fields; // rdx
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm1
			//   Plane__Array *s_cullPlanes; // rdx
			//   int32_t i; // ebx
			//   CullingResults v23; // xmm6
			//   PerObjectData__Enum RendererConfig; // eax
			//   Camera *v25; // r9
			//   int32_t v26; // ebx
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   ShaderTagId v30; // [rsp+58h] [rbp-B0h] BYREF
			//   CullingResults v31; // [rsp+68h] [rbp-A0h] BYREF
			//   Plane v32; // [rsp+78h] [rbp-90h] BYREF
			//   Matrix4x4 v33; // [rsp+88h] [rbp-80h] BYREF
			//   RendererListDesc v34; // [rsp+C8h] [rbp-40h] BYREF
			//   RendererListDesc v35; // [rsp+1A8h] [rbp+A0h] BYREF
			//   ScriptableCullingParameters cullingParameters; // [rsp+288h] [rbp+180h] BYREF
			//   HGSharedLightData _unity_self; // [rsp+900h] [rbp+7F8h] BYREF
			//   ScriptableRenderContext v38; // [rsp+910h] [rbp+808h] BYREF
			// 
			//   v38.m_Ptr = context.m_Ptr;
			//   _unity_self = light;
			//   if ( !byte_18D919EA1 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919EA1 = 1;
			//   }
			//   sub_1802F01E0(&cullingParameters, 0LL, 1592LL);
			//   v30.m_Id = 0;
			//   sub_1802F01E0(&v34, 0LL, 224LL);
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1850, 0LL) )
			//   {
			//     if ( UnityEngine::HyperGryph::HGGraphicsUtils::get_enableECSRenderer(0LL) )
			//     {
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
			//       nullRendererList = TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList.static_fields.nullRendererList;
			// LABEL_14:
			//       *rendererList = nullRendererList;
			//       return;
			//     }
			//     UnityEngine::HGSharedLightData::get_worldPosition(&v32.m_Normal, &_unity_self, 0LL);
			//     if ( UnityEngine::HGSharedLightData::get_type_Injected(&_unity_self, 0LL) == LightType__Enum_Spot )
			//       UnityEngine::HGSharedLightData::get_spotAngle_Injected(&_unity_self, 0LL);
			//     if ( hgCamera )
			//     {
			//       camera = hgCamera.fields.camera;
			//       if ( camera )
			//       {
			//         UnityEngine::Camera::TryGetCullingParameters(camera, &cullingParameters, 0LL);
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//         v13 = viewProj;
			//         v14 = *(_OWORD *)&viewProj.m01;
			//         *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m20 = *(_OWORD *)&viewProj.m00;
			//         v15 = *(_OWORD *)&viewProj.m02;
			//         *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m21 = v14;
			//         v16 = *(_OWORD *)&viewProj.m03;
			//         *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m22 = v15;
			//         *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m23 = v16;
			//         UnityEngine::Rendering::ScriptableCullingParameters::set_isOrthographic(&cullingParameters, 0, 0LL);
			//         cullingParameters.m_CameraProperties.cameraWorldToClip.m31 = 0.0;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//         v17 = *(_OWORD *)&v13.m01;
			//         *(_OWORD *)&v33.m00 = *(_OWORD *)&v13.m00;
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields;
			//         v19 = *(_OWORD *)&v13.m02;
			//         *(_OWORD *)&v33.m01 = v17;
			//         v20 = *(_OWORD *)&v13.m03;
			//         s_cullPlanes = static_fields.s_cullPlanes;
			//         *(_OWORD *)&v33.m02 = v19;
			//         *(_OWORD *)&v33.m03 = v20;
			//         UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v33, s_cullPlanes, 0LL);
			//         for ( i = 0; i < 6; ++i )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//           camera = (Camera *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_cullPlanes;
			//           if ( !camera )
			//             goto LABEL_16;
			//           sub_180037190(camera, &v32, i);
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
			//           v31 = (CullingResults)v32;
			//           UnityEngine::Rendering::ScriptableCullingParameters::SetCullingPlane(
			//             &cullingParameters,
			//             i,
			//             (Plane *)&v31,
			//             0LL);
			//         }
			//         sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//         v23 = *UnityEngine::Rendering::ScriptableRenderContext::Cull(&v31, &v38, &cullingParameters, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
			//         UnityEngine::Rendering::ShaderTagId::ShaderTagId(
			//           &v30,
			//           TypeInfo::HG::Rendering::Runtime::HGShaderPassNames.static_fields.s_ShadowCasterStr,
			//           0LL);
			//         RendererConfig = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetRendererConfig(
			//                            this,
			//                            _unity_self,
			//                            isDynamicRequest,
			//                            0LL);
			//         v25 = hgCamera.fields.camera;
			//         v26 = RendererConfig;
			//         v31 = v23;
			//         UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(&v34, v30, &v31, v25, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
			//         v34.renderQueueRange = TypeInfo::HG::Rendering::Runtime::HGRenderQueue.static_fields.k_RenderQueue_AllOpaque;
			//         v34.sortingCriteria = 59;
			//         v34.rendererConfiguration = v26;
			//         v35 = v34;
			//         nullRendererList = *UnityEngine::Rendering::ScriptableRenderContext::CreateRendererList(
			//                               (RendererList *)&v31,
			//                               &v38,
			//                               &v35,
			//                               0LL);
			//         goto LABEL_14;
			//       }
			//     }
			// LABEL_16:
			//     sub_180B536AC(camera, v11);
			//   }
			//   camera = (Camera *)IFix::WrappersManagerImpl::GetPatch(1850, 0LL);
			//   if ( !camera )
			//     goto LABEL_16;
			//   v27 = *(_OWORD *)&viewProj.m01;
			//   *(_OWORD *)&v33.m00 = *(_OWORD *)&viewProj.m00;
			//   v28 = *(_OWORD *)&viewProj.m02;
			//   *(_OWORD *)&v33.m01 = v27;
			//   v29 = *(_OWORD *)&viewProj.m03;
			//   *(_OWORD *)&v33.m02 = v28;
			//   *(_OWORD *)&v33.m03 = v29;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_716(
			//     (ILFixDynamicMethodWrapper_2 *)camera,
			//     (Object *)this,
			//     _unity_self,
			//     (Object *)hgCamera,
			//     v38,
			//     &v33,
			//     isDynamicRequest,
			//     rendererList,
			//     0LL);
			// }
			// 
		}

		private void PrepareECSRendererList(HGSharedLightData light, HGCamera hgCamera, ScriptableRenderContext context, Matrix4x4 worldToShadow, Matrix4x4 view, float projM11, bool isDynamicRequest, ref uint ecsShadowRendererList, ref uint ecsShadowGrassRendererList)
		{
			// // Void PrepareECSRendererList(HGSharedLightData, HGCamera, ScriptableRenderContext, Matrix4x4, Matrix4x4, Single, Boolean, UInt32 ByRef, UInt32 ByRef)
			// void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PrepareECSRendererList(
			//         HGPunctualLightShadowManagerV2 *this,
			//         HGSharedLightData light,
			//         HGCamera *hgCamera,
			//         ScriptableRenderContext context,
			//         Matrix4x4 *worldToShadow,
			//         Matrix4x4 *view,
			//         float projM11,
			//         bool isDynamicRequest,
			//         uint32_t *ecsShadowRendererList,
			//         uint32_t *ecsShadowGrassRendererList,
			//         MethodInfo *method)
			// {
			//   HGCamera *v12; // rsi
			//   HGPunctualLightShadowManagerV2 *v13; // r12
			//   bool enableOBBCullingBox_Injected; // al
			//   int32_t v15; // edx
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __m128 *inverse; // rax
			//   __m128 v20; // xmm8
			//   __m128 v21; // xmm7
			//   __m128i v22; // xmm6
			//   Vector3 *worldPosition; // rax
			//   float v24; // r14d
			//   __int64 v25; // xmm11_8
			//   Plane__Array *s_cullPlanes; // rdi
			//   unsigned __int64 v27; // xmm8_8
			//   float v28; // r15d
			//   MethodInfo *v29; // r9
			//   Vector3 *v30; // rax
			//   __int64 v31; // xmm3_8
			//   MethodInfo *v32; // r9
			//   Vector3 *v33; // rax
			//   __int64 v34; // xmm3_8
			//   __int64 v35; // rdx
			//   Camera *camera; // rcx
			//   Plane__Array *v37; // r13
			//   MethodInfo *v38; // r8
			//   Vector3 *v39; // rax
			//   __int64 v40; // xmm6_8
			//   float v41; // edi
			//   float shadowFarPlane_Injected; // xmm0_4
			//   MethodInfo *v43; // r9
			//   Vector3 *v44; // rax
			//   __int64 v45; // xmm3_8
			//   MethodInfo *v46; // r9
			//   Vector3 *v47; // rax
			//   __int64 v48; // xmm3_8
			//   Void *m_Buffer; // r15
			//   int i; // edi
			//   Vector3 *cullingBoxRelativePosition; // rax
			//   __int64 v52; // xmm0_8
			//   MethodInfo *v53; // r9
			//   Vector3 *v54; // rax
			//   __int64 v55; // xmm10_8
			//   float v56; // r13d
			//   Vector3 *cullingBoxHalfExtents; // rax
			//   float v58; // r14d
			//   Vector3 *cullingBoxOrientation; // rax
			//   __int64 v60; // xmm0_8
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ *v61; // rdi
			//   MethodInfo *v62; // rdx
			//   Vector3 *fwd; // rax
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ v64; // xmm0
			//   __int64 v65; // xmm3_8
			//   Vector3 *v66; // rax
			//   __int64 v67; // xmm7_8
			//   float v68; // r15d
			//   MethodInfo *v69; // rdx
			//   Vector3 *up; // rax
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ v71; // xmm0
			//   __int64 v72; // xmm3_8
			//   Vector3 *v73; // rax
			//   __int64 v74; // xmm8_8
			//   float v75; // r12d
			//   MethodInfo *v76; // rdx
			//   Vector3 *right; // rax
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ v78; // xmm0
			//   __int64 v79; // xmm1_8
			//   Vector3 *v80; // rax
			//   __int64 v81; // xmm9_8
			//   MethodInfo *v82; // r9
			//   Vector3 *v83; // rax
			//   __int64 v84; // xmm3_8
			//   MethodInfo *v85; // r9
			//   Vector3 *v86; // rax
			//   __int64 v87; // xmm3_8
			//   MethodInfo *v88; // r8
			//   Vector3 *v89; // rax
			//   __int64 v90; // xmm4_8
			//   Quaternion *v91; // rsi
			//   MethodInfo *v92; // r9
			//   Vector3 *v93; // rax
			//   __int64 v94; // xmm3_8
			//   MethodInfo *v95; // r9
			//   Vector3 *v96; // rax
			//   __int64 v97; // xmm3_8
			//   float y; // xmm2_4
			//   MethodInfo *v99; // r9
			//   Vector3 *v100; // rax
			//   __int64 v101; // xmm3_8
			//   MethodInfo *v102; // r9
			//   Vector3 *v103; // rax
			//   __int64 v104; // xmm3_8
			//   MethodInfo *v105; // r8
			//   Vector3 *v106; // rax
			//   __int64 v107; // xmm4_8
			//   float v108; // xmm2_4
			//   MethodInfo *v109; // r9
			//   Vector3 *v110; // rax
			//   __int64 v111; // xmm3_8
			//   MethodInfo *v112; // r9
			//   Vector3 *v113; // rax
			//   __int64 v114; // xmm3_8
			//   float x; // xmm2_4
			//   MethodInfo *v116; // r9
			//   Vector3 *v117; // rax
			//   __int64 v118; // xmm3_8
			//   MethodInfo *v119; // r9
			//   Vector3 *v120; // rax
			//   __int64 v121; // xmm3_8
			//   MethodInfo *v122; // r8
			//   Vector3 *v123; // rax
			//   __int64 v124; // xmm4_8
			//   float v125; // xmm2_4
			//   MethodInfo *v126; // r9
			//   Vector3 *v127; // rax
			//   __int64 v128; // xmm3_8
			//   MethodInfo *v129; // r9
			//   Vector3 *v130; // rax
			//   __int64 v131; // xmm3_8
			//   bool v132; // di
			//   __int128 v133; // xmm1
			//   __int128 v134; // xmm0
			//   uint32_t cullingMask; // r14d
			//   int32_t v136; // edi
			//   Camera *v137; // rdi
			//   uint64_t SceneCullingMaskFromCamera; // rax
			//   uint32_t v139; // r15d
			//   HGRenderFlags__Enum v140; // r14d
			//   HGRenderFlags__Enum v141; // esi
			//   uint32_t RendererList; // eax
			//   __int128 v143; // xmm1
			//   __int128 v144; // xmm0
			//   __int128 v145; // xmm1
			//   __int128 v146; // xmm1
			//   __int128 v147; // xmm0
			//   __int128 v148; // xmm1
			//   HGRenderKeyword__Enum methoda; // [rsp+28h] [rbp-E0h]
			//   float m_punctualLightShadowScreenSizeMinSquared; // [rsp+40h] [rbp-C8h]
			//   Vector3 v151; // [rsp+68h] [rbp-A0h] BYREF
			//   Vector3 v152; // [rsp+78h] [rbp-90h] BYREF
			//   Vector3 v153; // [rsp+88h] [rbp-80h] BYREF
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ v154; // [rsp+98h] [rbp-70h] BYREF
			//   Vector3 v155; // [rsp+A8h] [rbp-60h] BYREF
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ v156; // [rsp+B8h] [rbp-50h] BYREF
			//   HGObjectFlags__Enum objectFlagsMask; // [rsp+C8h] [rbp-40h] BYREF
			//   HGObjectFlags__Enum objectFlags; // [rsp+CCh] [rbp-3Ch] BYREF
			//   HGRenderFlags__Enum renderFlags; // [rsp+D0h] [rbp-38h] BYREF
			//   HGRenderFlags__Enum renderFlagsMask; // [rsp+D4h] [rbp-34h] BYREF
			//   float z; // [rsp+D8h] [rbp-30h]
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ v162; // [rsp+E8h] [rbp-20h] BYREF
			//   LODCrossFadeConfig v163; // [rsp+F8h] [rbp-10h] BYREF
			//   Matrix4x4 v164; // [rsp+138h] [rbp+30h] BYREF
			//   Matrix4x4 v165[2]; // [rsp+178h] [rbp+70h] BYREF
			//   HGSharedLightData _unity_self; // [rsp+260h] [rbp+158h] BYREF
			//   HGCamera *v168; // [rsp+268h] [rbp+160h]
			// 
			//   v168 = hgCamera;
			//   _unity_self = light;
			//   v12 = hgCamera;
			//   v13 = this;
			//   if ( !byte_18D919EA2 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     byte_18D919EA2 = 1;
			//   }
			//   objectFlags = HGObjectFlags__Enum_None;
			//   objectFlagsMask = HGObjectFlags__Enum_None;
			//   renderFlags = HGRenderFlags__Enum_None;
			//   renderFlagsMask = HGRenderFlags__Enum_None;
			//   v162 = 0LL;
			//   memset(&v163, 0, sizeof(v163));
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1851, 0LL) )
			//   {
			//     enableOBBCullingBox_Injected = UnityEngine::HGSharedLightData::get_enableOBBCullingBox_Injected(&_unity_self, 0LL);
			//     v15 = 6;
			//     if ( enableOBBCullingBox_Injected )
			//       v15 = 12;
			//     Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::EntityCommandBufferV2::VirtualEntityMap>::NativeArray(
			//       &v162,
			//       v15,
			//       Allocator__Enum_Temp,
			//       NativeArrayOptions__Enum_ClearMemory,
			//       MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//     v16 = *(_OWORD *)&worldToShadow.m01;
			//     *(_OWORD *)&v165[0].m00 = *(_OWORD *)&worldToShadow.m00;
			//     v17 = *(_OWORD *)&worldToShadow.m02;
			//     *(_OWORD *)&v165[0].m01 = v16;
			//     v18 = *(_OWORD *)&worldToShadow.m03;
			//     *(_OWORD *)&v165[0].m02 = v17;
			//     *(_OWORD *)&v165[0].m03 = v18;
			//     UnityEngine::GeometryUtility::CalculateFrustumPlanes(
			//       v165,
			//       TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_cullPlanes,
			//       0LL);
			//     inverse = (__m128 *)UnityEngine::Matrix4x4::get_inverse(v165, view, 0LL);
			//     v20 = _mm_xor_ps(inverse[2], (__m128)0x80000000);
			//     v21 = _mm_xor_ps((__m128)inverse[2].m128_u32[1], (__m128)0x80000000);
			//     v22 = (__m128i)_mm_xor_ps((__m128)inverse[2].m128_u32[2], (__m128)0x80000000);
			//     worldPosition = UnityEngine::HGSharedLightData::get_worldPosition(&v151, &_unity_self, 0LL);
			//     v25 = *(_QWORD *)&worldPosition.x;
			//     z = worldPosition.z;
			//     v24 = z;
			//     s_cullPlanes = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_cullPlanes;
			//     *(float *)&v17 = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&_unity_self, 0LL);
			//     v27 = _mm_unpacklo_ps(v20, v21).m128_u64[0];
			//     v28 = COERCE_FLOAT(_mm_cvtsi128_si32(v22));
			//     *(_QWORD *)&v155.x = v27;
			//     v155.z = v28;
			//     v30 = UnityEngine::Vector3::op_Multiply(&v151, &v155, *(float *)&v17, v29);
			//     *(_QWORD *)&v152.x = v25;
			//     v152.z = v24;
			//     v31 = *(_QWORD *)&v30.x;
			//     *(float *)&v30 = v30.z;
			//     *(_QWORD *)&v155.x = v31;
			//     LODWORD(v155.z) = (_DWORD)v30;
			//     v156 = 0LL;
			//     v33 = UnityEngine::Vector3::op_Addition(&v151, &v152, &v155, v32);
			//     *(_QWORD *)&v155.x = v27;
			//     v155.z = v28;
			//     v34 = *(_QWORD *)&v33.x;
			//     *(float *)&v33 = v33.z;
			//     *(_QWORD *)&v152.x = v34;
			//     LODWORD(v152.z) = (_DWORD)v33;
			//     UnityEngine::Plane::Plane((Plane *)&v156, &v155, &v152, 0LL);
			//     if ( s_cullPlanes )
			//     {
			//       v154 = v156;
			//       sub_18004D910(s_cullPlanes, 4LL, &v154);
			//       *(_QWORD *)&v152.x = v27;
			//       v152.z = v28;
			//       v37 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_cullPlanes;
			//       v39 = UnityEngine::Vector3::op_UnaryNegation(&v151, &v152, v38);
			//       v40 = *(_QWORD *)&v39.x;
			//       v41 = v39.z;
			//       shadowFarPlane_Injected = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&_unity_self, 0LL);
			//       *(_QWORD *)&v152.x = v27;
			//       v152.z = v28;
			//       v44 = UnityEngine::Vector3::op_Multiply(&v151, &v152, shadowFarPlane_Injected, v43);
			//       *(_QWORD *)&v155.x = v25;
			//       v155.z = v24;
			//       v45 = *(_QWORD *)&v44.x;
			//       *(float *)&v44 = v44.z;
			//       *(_QWORD *)&v152.x = v45;
			//       LODWORD(v152.z) = (_DWORD)v44;
			//       v156 = 0LL;
			//       v47 = UnityEngine::Vector3::op_Addition(&v151, &v155, &v152, v46);
			//       *(_QWORD *)&v155.x = v40;
			//       v155.z = v41;
			//       v48 = *(_QWORD *)&v47.x;
			//       *(float *)&v47 = v47.z;
			//       *(_QWORD *)&v152.x = v48;
			//       LODWORD(v152.z) = (_DWORD)v47;
			//       UnityEngine::Plane::Plane((Plane *)&v156, &v155, &v152, 0LL);
			//       if ( v37 )
			//       {
			//         v154 = v156;
			//         sub_18004D910(v37, 5LL, &v154);
			//         m_Buffer = v162.m_Buffer;
			//         for ( i = 0; i < 6; ++i )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//           camera = (Camera *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_cullPlanes;
			//           if ( !camera )
			//             goto LABEL_23;
			//           sub_180037190(camera, &v154, i);
			//           *(NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ *)m_Buffer = v154;
			//           m_Buffer += 16;
			//         }
			//         if ( UnityEngine::HGSharedLightData::get_enableOBBCullingBox_Injected(&_unity_self, 0LL) )
			//         {
			//           cullingBoxRelativePosition = UnityEngine::HGSharedLightData::get_cullingBoxRelativePosition(
			//                                          &v151,
			//                                          &_unity_self,
			//                                          0LL);
			//           *(_QWORD *)&v155.x = v25;
			//           v155.z = v24;
			//           v52 = *(_QWORD *)&cullingBoxRelativePosition.x;
			//           *(float *)&cullingBoxRelativePosition = cullingBoxRelativePosition.z;
			//           *(_QWORD *)&v152.x = v52;
			//           LODWORD(v152.z) = (_DWORD)cullingBoxRelativePosition;
			//           v54 = UnityEngine::Vector3::op_Addition(&v151, &v155, &v152, v53);
			//           v55 = *(_QWORD *)&v54.x;
			//           v56 = v54.z;
			//           cullingBoxHalfExtents = UnityEngine::HGSharedLightData::get_cullingBoxHalfExtents(&v151, &_unity_self, 0LL);
			//           v58 = cullingBoxHalfExtents.z;
			//           *(_QWORD *)&v155.x = *(_QWORD *)&cullingBoxHalfExtents.x;
			//           cullingBoxOrientation = UnityEngine::HGSharedLightData::get_cullingBoxOrientation(&v151, &_unity_self, 0LL);
			//           v60 = *(_QWORD *)&cullingBoxOrientation.x;
			//           *(float *)&cullingBoxOrientation = cullingBoxOrientation.z;
			//           *(_QWORD *)&v152.x = v60;
			//           LODWORD(v152.z) = (_DWORD)cullingBoxOrientation;
			//           v61 = (NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ *)sub_182504CA0(&v156, &v152);
			//           fwd = UnityEngine::Vector3::get_fwd(&v151, v62);
			//           v64 = *v61;
			//           v65 = *(_QWORD *)&fwd.x;
			//           v152.z = fwd.z;
			//           *(_QWORD *)&v152.x = v65;
			//           v154 = v64;
			//           v66 = UnityEngine::Quaternion::op_Multiply(&v153, (Quaternion *)&v154, &v152, 0LL);
			//           v67 = *(_QWORD *)&v66.x;
			//           v68 = v66.z;
			//           up = UnityEngine::Vector3::get_up(&v151, v69);
			//           v71 = *v61;
			//           v72 = *(_QWORD *)&up.x;
			//           v152.z = up.z;
			//           *(_QWORD *)&v152.x = v72;
			//           v154 = v71;
			//           v73 = UnityEngine::Quaternion::op_Multiply(&v151, (Quaternion *)&v154, &v152, 0LL);
			//           v74 = *(_QWORD *)&v73.x;
			//           v75 = v73.z;
			//           right = UnityEngine::Vector3::get_right(&v151, v76);
			//           v78 = *v61;
			//           v79 = *(_QWORD *)&right.x;
			//           *(float *)&right = right.z;
			//           *(_QWORD *)&v152.x = v79;
			//           LODWORD(v152.z) = (_DWORD)right;
			//           v154 = v78;
			//           v80 = UnityEngine::Quaternion::op_Multiply(&v151, (Quaternion *)&v154, &v152, 0LL);
			//           v81 = *(_QWORD *)&v80.x;
			//           *(float *)&v61 = v80.z;
			//           *(_QWORD *)&v151.x = v67;
			//           v151.z = v68;
			//           *(_QWORD *)&v152.x = v67;
			//           v152.z = v68;
			//           v83 = UnityEngine::Vector3::op_Multiply(&v153, &v152, v58, v82);
			//           v84 = *(_QWORD *)&v83.x;
			//           *(float *)&v83 = v83.z;
			//           *(_QWORD *)&v152.x = v84;
			//           LODWORD(v152.z) = (_DWORD)v83;
			//           *(_QWORD *)&v153.x = v55;
			//           v153.z = v56;
			//           v154 = 0LL;
			//           v86 = UnityEngine::Vector3::op_Addition((Vector3 *)&v156, &v153, &v152, v85);
			//           v87 = *(_QWORD *)&v86.x;
			//           *(float *)&v86 = v86.z;
			//           *(_QWORD *)&v153.x = v87;
			//           LODWORD(v153.z) = (_DWORD)v86;
			//           v89 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v156, &v151, v88);
			//           v90 = *(_QWORD *)&v89.x;
			//           *(float *)&v89 = v89.z;
			//           *(_QWORD *)&v151.x = v90;
			//           LODWORD(v151.z) = (_DWORD)v89;
			//           UnityEngine::Plane::Plane((Plane *)&v154, &v151, &v153, 0LL);
			//           v91 = (Quaternion *)v162.m_Buffer;
			//           *(_QWORD *)&v151.x = v67;
			//           v151.z = v68;
			//           *(NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ *)&v162.m_Buffer[96] = v154;
			//           v93 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v156, &v151, v58, v92);
			//           *(_QWORD *)&v153.x = v55;
			//           v153.z = v56;
			//           v94 = *(_QWORD *)&v93.x;
			//           *(float *)&v93 = v93.z;
			//           *(_QWORD *)&v151.x = v94;
			//           LODWORD(v151.z) = (_DWORD)v93;
			//           v154 = 0LL;
			//           v96 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v156, &v153, &v151, v95);
			//           *(_QWORD *)&v153.x = v67;
			//           v153.z = v68;
			//           v97 = *(_QWORD *)&v96.x;
			//           *(float *)&v96 = v96.z;
			//           *(_QWORD *)&v151.x = v97;
			//           LODWORD(v151.z) = (_DWORD)v96;
			//           UnityEngine::Plane::Plane((Plane *)&v154, &v153, &v151, 0LL);
			//           v152.z = v75;
			//           y = v155.y;
			//           v91[7] = (Quaternion)v154;
			//           v151.z = v75;
			//           *(_QWORD *)&v152.x = v74;
			//           *(_QWORD *)&v151.x = v74;
			//           v100 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v156, &v151, y, v99);
			//           v101 = *(_QWORD *)&v100.x;
			//           *(float *)&v100 = v100.z;
			//           *(_QWORD *)&v151.x = v101;
			//           LODWORD(v151.z) = (_DWORD)v100;
			//           *(_QWORD *)&v153.x = v55;
			//           v153.z = v56;
			//           v154 = 0LL;
			//           v103 = UnityEngine::Vector3::op_Addition((Vector3 *)&v156, &v153, &v151, v102);
			//           v104 = *(_QWORD *)&v103.x;
			//           *(float *)&v103 = v103.z;
			//           *(_QWORD *)&v151.x = v104;
			//           LODWORD(v151.z) = (_DWORD)v103;
			//           v106 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v156, &v152, v105);
			//           v107 = *(_QWORD *)&v106.x;
			//           *(float *)&v106 = v106.z;
			//           *(_QWORD *)&v153.x = v107;
			//           LODWORD(v153.z) = (_DWORD)v106;
			//           UnityEngine::Plane::Plane((Plane *)&v154, &v153, &v151, 0LL);
			//           v151.z = v75;
			//           v108 = v155.y;
			//           v91[8] = (Quaternion)v154;
			//           *(_QWORD *)&v151.x = v74;
			//           v110 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v156, &v151, v108, v109);
			//           *(_QWORD *)&v153.x = v55;
			//           v153.z = v56;
			//           v111 = *(_QWORD *)&v110.x;
			//           *(float *)&v110 = v110.z;
			//           *(_QWORD *)&v151.x = v111;
			//           LODWORD(v151.z) = (_DWORD)v110;
			//           v154 = 0LL;
			//           v113 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v156, &v153, &v151, v112);
			//           *(_QWORD *)&v153.x = v74;
			//           v153.z = v75;
			//           v114 = *(_QWORD *)&v113.x;
			//           *(float *)&v113 = v113.z;
			//           *(_QWORD *)&v151.x = v114;
			//           LODWORD(v151.z) = (_DWORD)v113;
			//           UnityEngine::Plane::Plane((Plane *)&v154, &v153, &v151, 0LL);
			//           LODWORD(v152.z) = (_DWORD)v61;
			//           x = v155.x;
			//           v91[9] = (Quaternion)v154;
			//           LODWORD(v151.z) = (_DWORD)v61;
			//           *(_QWORD *)&v152.x = v81;
			//           *(_QWORD *)&v151.x = v81;
			//           v117 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v156, &v151, x, v116);
			//           *(_QWORD *)&v153.x = v55;
			//           v153.z = v56;
			//           v118 = *(_QWORD *)&v117.x;
			//           *(float *)&v117 = v117.z;
			//           *(_QWORD *)&v151.x = v118;
			//           LODWORD(v151.z) = (_DWORD)v117;
			//           v154 = 0LL;
			//           v120 = UnityEngine::Vector3::op_Addition((Vector3 *)&v156, &v153, &v151, v119);
			//           v121 = *(_QWORD *)&v120.x;
			//           *(float *)&v120 = v120.z;
			//           *(_QWORD *)&v151.x = v121;
			//           LODWORD(v151.z) = (_DWORD)v120;
			//           v123 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v156, &v152, v122);
			//           v124 = *(_QWORD *)&v123.x;
			//           *(float *)&v123 = v123.z;
			//           *(_QWORD *)&v153.x = v124;
			//           LODWORD(v153.z) = (_DWORD)v123;
			//           UnityEngine::Plane::Plane((Plane *)&v154, &v153, &v151, 0LL);
			//           LODWORD(v151.z) = (_DWORD)v61;
			//           v125 = v155.x;
			//           v91[10] = (Quaternion)v154;
			//           *(_QWORD *)&v151.x = v81;
			//           v127 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v156, &v151, v125, v126);
			//           *(_QWORD *)&v153.x = v55;
			//           v153.z = v56;
			//           v128 = *(_QWORD *)&v127.x;
			//           *(float *)&v127 = v127.z;
			//           *(_QWORD *)&v151.x = v128;
			//           LODWORD(v151.z) = (_DWORD)v127;
			//           v154 = 0LL;
			//           v130 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v156, &v153, &v151, v129);
			//           *(_QWORD *)&v153.x = v81;
			//           LODWORD(v153.z) = (_DWORD)v61;
			//           v131 = *(_QWORD *)&v130.x;
			//           *(float *)&v130 = v130.z;
			//           *(_QWORD *)&v151.x = v131;
			//           LODWORD(v151.z) = (_DWORD)v130;
			//           UnityEngine::Plane::Plane((Plane *)&v154, &v153, &v151, 0LL);
			//           v24 = z;
			//           v13 = this;
			//           v91[11] = (Quaternion)v154;
			//           v12 = v168;
			//         }
			//         if ( v12 )
			//         {
			//           v132 = isDynamicRequest;
			//           v133 = *(_OWORD *)&v12.fields.lodCrossFadeConfig.c0.y;
			//           *(_OWORD *)&v163.cameraPosition.x = *(_OWORD *)&v12.fields.lodCrossFadeConfig.cameraPosition.x;
			//           v134 = *(_OWORD *)&v12.fields.lodCrossFadeConfig.c1.z;
			//           *(_OWORD *)&v163.c0.y = v133;
			//           *(_QWORD *)&v163.maxProjFactorSquared1 = *(_QWORD *)&v12.fields.lodCrossFadeConfig.maxProjFactorSquared1;
			//           *(_OWORD *)&v163.c1.z = v134;
			//           if ( !isDynamicRequest )
			//           {
			//             v163.c1.z = v24;
			//             *(_QWORD *)&v163.c1.x = v25;
			//             *(_QWORD *)&v163.c0.x = v25;
			//             v163.maxProjFactorSquared1 = projM11 * projM11;
			//             v163.maxProjFactorSquared0 = projM11 * projM11;
			//             v163.c0.z = v24;
			//             *(_QWORD *)&v163.cameraPosition.x = v25;
			//             v163.cameraPosition.z = v24;
			//           }
			//           v163.enableDither = 0;
			//           HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetECSRenderFlags(
			//             v13,
			//             _unity_self,
			//             isDynamicRequest,
			//             &objectFlags,
			//             &objectFlagsMask,
			//             &renderFlags,
			//             &renderFlagsMask,
			//             0LL);
			//           camera = v12.fields.camera;
			//           if ( v132 )
			//           {
			//             if ( camera )
			//             {
			//               cullingMask = UnityEngine::Camera::get_cullingMask(camera, 0LL);
			// LABEL_21:
			//               v137 = v12.fields.camera;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//               SceneCullingMaskFromCamera = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(v137, 0LL);
			//               m_punctualLightShadowScreenSizeMinSquared = v13.fields.m_punctualLightShadowScreenSizeMinSquared;
			//               v154 = v162;
			//               v139 = UnityEngine::HyperGryph::HGCullingSystem::AddCullViewByPlanes(
			//                        (NativeArray_1_UnityEngine_Plane_ *)&v154,
			//                        0,
			//                        SceneCullingMaskFromCamera,
			//                        cullingMask,
			//                        objectFlags,
			//                        objectFlagsMask,
			//                        &v163,
			//                        m_punctualLightShadowScreenSizeMinSquared,
			//                        CameraType__Enum_Shadow,
			//                        0LL);
			//               UnityEngine::HyperGryph::HGCullingSystem::DispatchBatchCullingJobs(0LL);
			//               sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//               v140 = renderFlags;
			//               v141 = renderFlagsMask;
			//               LOWORD(methoda) = 0;
			//               LODWORD(v137) = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                                 v139,
			//                                 (HGRenderFlags__Enum)(renderFlagsMask | 0x100),
			//                                 (HGRenderFlags__Enum)(renderFlags | 0x100),
			//                                 HGShaderLightMode__Enum_ShadowCaster,
			//                                 methoda,
			//                                 context.m_Ptr,
			//                                 0,
			//                                 0,
			//                                 0xFFFFFFFF,
			//                                 0,
			//                                 0,
			//                                 0LL);
			//               RendererList = UnityEngine::HyperGryph::HGGrassRender::CreateRendererList(
			//                                v139,
			//                                (HGRenderFlags__Enum)(v141 | 0x100),
			//                                (HGRenderFlags__Enum)(v140 | 0x100),
			//                                HGShaderLightMode__Enum_ShadowCaster,
			//                                context.m_Ptr,
			//                                0,
			//                                0LL);
			//               *ecsShadowRendererList = (unsigned int)v137;
			//               *ecsShadowGrassRendererList = RendererList;
			//               return;
			//             }
			//           }
			//           else if ( camera )
			//           {
			//             v136 = UnityEngine::Camera::get_cullingMask(camera, 0LL);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//             cullingMask = v136 & ~TypeInfo::HG::Rendering::Runtime::HGCamera.static_fields.COMPOUND_CHARACTER_LAYER_MASK;
			//             goto LABEL_21;
			//           }
			//         }
			//       }
			//     }
			// LABEL_23:
			//     sub_180B536AC(camera, v35);
			//   }
			//   camera = (Camera *)IFix::WrappersManagerImpl::GetPatch(1851, 0LL);
			//   if ( !camera )
			//     goto LABEL_23;
			//   v143 = *(_OWORD *)&view.m01;
			//   *(_OWORD *)&v165[0].m00 = *(_OWORD *)&view.m00;
			//   v144 = *(_OWORD *)&view.m02;
			//   *(_OWORD *)&v165[0].m01 = v143;
			//   v145 = *(_OWORD *)&view.m03;
			//   *(_OWORD *)&v165[0].m02 = v144;
			//   *(_OWORD *)&v165[0].m03 = v145;
			//   v146 = *(_OWORD *)&worldToShadow.m01;
			//   *(_OWORD *)&v164.m00 = *(_OWORD *)&worldToShadow.m00;
			//   v147 = *(_OWORD *)&worldToShadow.m02;
			//   *(_OWORD *)&v164.m01 = v146;
			//   v148 = *(_OWORD *)&worldToShadow.m03;
			//   *(_OWORD *)&v164.m02 = v147;
			//   *(_OWORD *)&v164.m03 = v148;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_717(
			//     (ILFixDynamicMethodWrapper_2 *)camera,
			//     (Object *)v13,
			//     _unity_self,
			//     (Object *)v12,
			//     context,
			//     &v164,
			//     v165,
			//     projM11,
			//     isDynamicRequest,
			//     ecsShadowRendererList,
			//     ecsShadowGrassRendererList,
			//     0LL);
			// }
			// 
		}

		private float GetPunctualLightShadowStrength(HGSharedLightData light, Vector3 cameraPos)
		{
			// // Single GetPunctualLightShadowStrength(HGSharedLightData, Vector3)
			// float HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetPunctualLightShadowStrength(
			//         HGPunctualLightShadowManagerV2 *this,
			//         HGSharedLightData light,
			//         Vector3 *cameraPos,
			//         MethodInfo *method)
			// {
			//   float shadowStrength_Injected; // xmm0_4
			//   float v7; // eax
			//   float v8; // xmm9_4
			//   Vector3 *worldPosition; // rax
			//   __int64 v10; // xmm1_8
			//   MethodInfo *v11; // r9
			//   Vector3 *v12; // rax
			//   __int64 v13; // xmm3_8
			//   double v14; // xmm0_8
			//   float v15; // xmm6_4
			//   float v16; // xmm8_4
			//   Beyond::JobMathf *v17; // rcx
			//   double v18; // xmm0_8
			//   __int64 v19; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v23; // [rsp+38h] [rbp-19h] BYREF
			//   Vector3 v24; // [rsp+48h] [rbp-9h] BYREF
			//   Vector3 v25[6]; // [rsp+58h] [rbp+7h] BYREF
			//   HGSharedLightData _unity_self; // [rsp+C0h] [rbp+6Fh] BYREF
			// 
			//   _unity_self = light;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1852, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1852, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v19);
			//     z = cameraPos.z;
			//     *(_QWORD *)&v24.x = *(_QWORD *)&cameraPos.x;
			//     v24.z = z;
			//     *(float *)&v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_718(Patch, (Object *)this, _unity_self, &v24, 0LL);
			//   }
			//   else
			//   {
			//     shadowStrength_Injected = UnityEngine::HGSharedLightData::get_shadowStrength_Injected(&_unity_self, 0LL);
			//     v7 = cameraPos.z;
			//     *(_QWORD *)&v23.x = *(_QWORD *)&cameraPos.x;
			//     v8 = shadowStrength_Injected;
			//     v23.z = v7;
			//     worldPosition = UnityEngine::HGSharedLightData::get_worldPosition(v25, &_unity_self, 0LL);
			//     v10 = *(_QWORD *)&worldPosition.x;
			//     *(float *)&worldPosition = worldPosition.z;
			//     *(_QWORD *)&v24.x = v10;
			//     LODWORD(v24.z) = (_DWORD)worldPosition;
			//     v12 = UnityEngine::Vector3::op_Subtraction(v25, &v24, &v23, v11);
			//     v13 = *(_QWORD *)&v12.x;
			//     *(float *)&v12 = v12.z;
			//     *(_QWORD *)&v24.x = v13;
			//     LODWORD(v24.z) = (_DWORD)v12;
			//     v14 = sub_18238EFA0(&v24);
			//     v15 = *(float *)&v14;
			//     v16 = fminf(
			//             UnityEngine::HGSharedLightData::get_shadowCullDistance_Injected(&_unity_self, 0LL),
			//             this.fields.m_punctualLightForceCullDistance);
			//     *(float *)&v14 = UnityEngine::HGSharedLightData::get_shadowFadeRatio_Injected(&_unity_self, 0LL);
			//     v18 = Beyond::JobMathf::ClampedLerp(v17, v8, (float)(v16 - v15) / (float)(v16 - (float)(*(float *)&v14 * v16)));
			//   }
			//   return *(float *)&v18;
			// }
			// 
			return 0f;
		}

		internal void RenderPunctualLightShadows(HGRenderGraph renderGraph, HGCamera hgCamera, HGSettingParameters settingParams, ref ShadowResult shadowResult)
		{
			// // Void RenderPunctualLightShadows(HGRenderGraph, HGCamera, HGSettingParameters, ShadowResult ByRef)
			// // Hidden C++ exception states: #wind=4
			// void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::RenderPunctualLightShadows(
			//         HGPunctualLightShadowManagerV2 *this,
			//         HGRenderGraph *renderGraph,
			//         HGCamera *hgCamera,
			//         HGSettingParameters *settingParams,
			//         ShadowResult *shadowResult,
			//         MethodInfo *method)
			// {
			//   HGPunctualLightShadowManagerV2 *v9; // r14
			//   __int64 z_low; // rdx
			//   unsigned __int64 camera; // rcx
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   __int64 v14; // xmm6_8
			//   HGPunctualLightStaticAtlasAllocator *punctualLightStaticAtlasAllocator; // rax
			//   Boolean__Array *m_slotOccupied; // rax
			//   int32_t size; // r12d
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *m_targetUpdateRequest; // rax
			//   __m128i v19; // xmm14
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v20; // rbx
			//   HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v21; // rax
			//   int32_t index; // edi
			//   HGObjectFlags__Enum targetSlot; // ebx
			//   Vector3 *worldPosition; // rax
			//   __int64 v25; // xmm6_8
			//   float z; // ebx
			//   float shadowNearPlane_Injected; // xmm8_4
			//   float shadowFarPlane_Injected; // xmm7_4
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   __int128 v30; // xmm8
			//   __int128 v31; // xmm9
			//   __int128 v32; // xmm10
			//   __int128 v33; // xmm11
			//   float spotAngle_Injected; // xmm13_4
			//   float v35; // xmm12_4
			//   float v36; // xmm7_4
			//   float shadowGuardAngle_Injected; // xmm6_4
			//   __int128 v38; // xmm7
			//   __int128 v39; // xmm8
			//   __int128 v40; // xmm9
			//   __int128 v41; // xmm10
			//   __int128 v42; // xmm11
			//   __m128 v43; // xmm15
			//   __int128 v44; // xmm12
			//   __int128 v45; // xmm13
			//   Matrix4x4 *ShadowTransform; // rax
			//   Vector4__Array *m_punctualLightShadowParams; // rdi
			//   float shadowNormalBias_Injected; // xmm0_4
			//   Vector4 *ShadowBias; // rax
			//   Vector4__Array *v50; // rdi
			//   float shadowStrength_Injected; // xmm0_4
			//   int32_t xMin; // r12d
			//   int m_X; // r15d
			//   int32_t yMin; // esi
			//   int m_Y; // r14d
			//   int32_t xMax; // edi
			//   int32_t v57; // ebx
			//   int32_t v58; // xmm4_4
			//   ProfilingSampler *v59; // rax
			//   __int64 v60; // rdx
			//   __int64 v61; // rcx
			//   Object *v62; // rax
			//   Object *v63; // rax
			//   Object *v64; // rbx
			//   __int64 v65; // rdx
			//   HGPunctualLightShadowManagerV2__StaticFields *static_fields; // rcx
			//   unsigned __int64 v67; // r8
			//   signed __int64 v68; // rtt
			//   Object *v69; // rbx
			//   __int64 v70; // rdx
			//   __int64 v71; // rcx
			//   TextureHandle v72; // xmm0
			//   Object *v73; // rbx
			//   __int64 v74; // rdx
			//   __int64 v75; // rcx
			//   float shadowBias_Injected; // xmm0_4
			//   HGSharedLightData v77; // rbx
			//   HGRenderGraphContext *m_RenderGraphContext; // rdi
			//   ScriptableRenderContext v79; // rdi
			//   Matrix4x4 *v80; // rax
			//   __int64 v81; // rdx
			//   __int64 v82; // rdx
			//   __int64 v83; // rcx
			//   HGRenderGraphContext *v84; // rbx
			//   void *m_Ptr; // rbx
			//   float v86; // xmm15_4
			//   uint32_t *v87; // r12
			//   uint32_t *v88; // rdi
			//   unsigned __int8 (__fastcall *v89)(HGSharedLightData *); // rax
			//   HGPunctualLightShadowManagerV2__StaticFields *v90; // rcx
			//   Matrix4x4 *inverse; // rax
			//   __m128 v92; // xmm8
			//   __m128 v93; // xmm8
			//   __m128 v94; // xmm6
			//   float v95; // xmm7_4
			//   Vector3 *v96; // rax
			//   __int64 v97; // xmm11_8
			//   float v98; // r15d
			//   Plane__Array *s_cullPlanes; // rdi
			//   float v100; // xmm0_4
			//   Vector3 *v101; // rax
			//   __int64 v102; // xmm1_8
			//   __int64 v103; // rdx
			//   __int64 v104; // rcx
			//   __int64 v105; // r8
			//   __int64 v106; // r9
			//   Plane__Array *v107; // rdi
			//   Vector3 *v108; // rax
			//   __int64 v109; // xmm9_8
			//   float v110; // esi
			//   float v111; // xmm0_4
			//   Vector3 *v112; // rax
			//   __int64 v113; // xmm1_8
			//   __int64 v114; // rdx
			//   __int64 v115; // rcx
			//   __int64 v116; // r8
			//   __int64 v117; // r9
			//   int i; // edi
			//   __int64 v119; // rdx
			//   Plane__Array *v120; // rcx
			//   unsigned __int8 (__fastcall *v121)(HGSharedLightData *); // rax
			//   void (__fastcall *v122)(HGSharedLightData *, Vector3 *); // rax
			//   Vector3 *v123; // rax
			//   __int64 v124; // xmm9_8
			//   float v125; // r12d
			//   void (__fastcall *v126)(HGSharedLightData *, Vector3 *); // rax
			//   void (__fastcall *v127)(HGSharedLightData *, Vector3 *); // rax
			//   __m128i v128; // xmm6
			//   Vector3 *v129; // rax
			//   __int64 v130; // xmm7_8
			//   float v131; // edi
			//   Vector3 *v132; // rax
			//   __int64 v133; // xmm8_8
			//   float v134; // esi
			//   Vector3 *v135; // rax
			//   float v136; // r15d
			//   Vector3 *v137; // rax
			//   __int64 v138; // xmm10_8
			//   Vector3 *v139; // rax
			//   __int64 v140; // xmm1_8
			//   MethodInfo *v141; // r9
			//   Vector3 *v142; // rax
			//   __int64 v143; // xmm1_8
			//   float v144; // ecx
			//   Vector3 *v145; // rax
			//   __int64 v146; // xmm7_8
			//   float v147; // edi
			//   Vector3 *v148; // rax
			//   __int64 v149; // xmm1_8
			//   MethodInfo *v150; // r9
			//   Vector3 *v151; // rax
			//   __int64 v152; // xmm1_8
			//   float v153; // ecx
			//   Vector3 *v154; // rax
			//   __int64 v155; // xmm7_8
			//   float v156; // edi
			//   Vector3 *v157; // rax
			//   __int64 v158; // xmm1_8
			//   MethodInfo *v159; // r9
			//   Vector3 *v160; // rax
			//   __int64 v161; // xmm1_8
			//   float v162; // ecx
			//   __int64 v163; // rdx
			//   __int64 v164; // rcx
			//   Camera *v165; // rdi
			//   __int64 (__fastcall *v166)(Camera *); // rax
			//   int v167; // esi
			//   uint32_t v168; // edi
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ v169; // xmm6
			//   Camera *v170; // rsi
			//   uint64_t SceneCullingMaskFromCamera; // rax
			//   float m_punctualLightShadowScreenSizeMinSquared; // xmm0_4
			//   uint32_t v173; // r15d
			//   void (*v174)(void); // rax
			//   HGRenderFlags__Enum v175; // edi
			//   HGRenderFlags__Enum v176; // esi
			//   uint32_t RendererList; // edi
			//   uint32_t v178; // eax
			//   __int64 v179; // rdx
			//   Entity_1 v180; // rcx
			//   ILFixDynamicMethodWrapper_2 *v181; // rax
			//   __int64 v182; // rdx
			//   __int64 v183; // rcx
			//   HGRenderFlags__Enum j; // r15d
			//   LightCaster__Array *m_targetDynamicPunctualLights; // rbx
			//   LightCaster *v186; // rax
			//   int32_t m_punctualShadowAtlasBaseTileSize; // esi
			//   int v188; // eax
			//   LightCaster__Array *v189; // rbx
			//   LightCaster *v190; // rax
			//   Vector3 *v191; // rax
			//   __int64 v192; // xmm8_8
			//   float v193; // edi
			//   int32_t v194; // ebx
			//   float v195; // xmm7_4
			//   float v196; // xmm6_4
			//   Matrix4x4 *v197; // rax
			//   __int128 v198; // xmm8
			//   __int128 v199; // xmm9
			//   __int128 v200; // xmm10
			//   __int128 v201; // xmm11
			//   float v202; // xmm13_4
			//   float v203; // xmm12_4
			//   float v204; // xmm7_4
			//   float v205; // xmm6_4
			//   __int128 v206; // xmm8
			//   __int128 v207; // xmm9
			//   __int128 v208; // xmm10
			//   __int128 v209; // xmm11
			//   __int128 v210; // xmm12
			//   __m128 v211; // xmm7
			//   __int128 v212; // xmm13
			//   __int128 v213; // xmm14
			//   Matrix4x4 *v214; // r8
			//   __int128 v215; // xmm15
			//   Vector4__Array *v216; // rbx
			//   float v217; // xmm0_4
			//   Vector4 *v218; // rax
			//   Vector4__Array *v219; // rbx
			//   float PunctualLightShadowStrength; // xmm0_4
			//   int32_t v221; // r12d
			//   int v222; // r15d
			//   int32_t v223; // esi
			//   int v224; // r14d
			//   int32_t v225; // edi
			//   int32_t v226; // ebx
			//   int32_t yMax; // eax
			//   float v228; // xmm4_4
			//   ProfilingSampler *v229; // rax
			//   __int64 v230; // rdx
			//   __int64 v231; // rcx
			//   Object *v232; // rax
			//   Object *v233; // rax
			//   Object *v234; // rbx
			//   __int64 v235; // rdx
			//   HGPunctualLightShadowManagerV2__StaticFields *v236; // rcx
			//   unsigned __int64 v237; // r8
			//   signed __int64 v238; // rtt
			//   Object *v239; // rbx
			//   __int64 v240; // rdx
			//   __int64 v241; // rcx
			//   TextureHandle v242; // xmm0
			//   Object *v243; // rbx
			//   __int64 v244; // rdx
			//   __int64 v245; // rcx
			//   float v246; // xmm0_4
			//   HGSharedLightData v247; // rbx
			//   HGRenderGraphContext *v248; // rdi
			//   ScriptableRenderContext v249; // rdi
			//   Matrix4x4 *v250; // rax
			//   __int64 v251; // rdx
			//   HGCamera *v252; // r12
			//   __int64 v253; // rdx
			//   __int64 v254; // rcx
			//   HGRenderGraphContext *v255; // rbx
			//   void *v256; // rbx
			//   uint32_t *v257; // rdi
			//   uint32_t *v258; // rsi
			//   unsigned __int8 (__fastcall *v259)(HGSharedLightData *); // rax
			//   HGPunctualLightShadowManagerV2__StaticFields *v260; // rcx
			//   Matrix4x4 *v261; // rax
			//   __m128 v262; // xmm8
			//   __m128 v263; // xmm8
			//   __m128 v264; // xmm6
			//   float v265; // xmm7_4
			//   Vector3 *v266; // rax
			//   __int64 v267; // xmm10_8
			//   float v268; // r15d
			//   Plane__Array *v269; // rdi
			//   float v270; // xmm0_4
			//   Vector3 *v271; // rax
			//   __int64 v272; // xmm1_8
			//   __int64 v273; // rdx
			//   __int64 v274; // rcx
			//   __int64 v275; // r8
			//   __int64 v276; // r9
			//   Plane__Array *v277; // rdi
			//   Vector3 *v278; // rax
			//   __int64 v279; // xmm9_8
			//   float v280; // esi
			//   float v281; // xmm0_4
			//   Vector3 *v282; // rax
			//   __int64 v283; // xmm1_8
			//   __int64 v284; // rdx
			//   __int64 v285; // rcx
			//   __int64 v286; // r8
			//   __int64 v287; // r9
			//   int k; // edi
			//   __int64 v289; // rdx
			//   Plane__Array *v290; // rcx
			//   unsigned __int8 (__fastcall *v291)(HGSharedLightData *); // rax
			//   void (__fastcall *v292)(HGSharedLightData *, Vector3 *); // rax
			//   Vector3 *v293; // rax
			//   __int64 v294; // xmm12_8
			//   void (__fastcall *v295)(HGSharedLightData *, Vector3 *); // rax
			//   void (__fastcall *v296)(HGSharedLightData *, Vector3 *); // rax
			//   void (__fastcall *v297)(Vector3 *, Matrix4x4 *); // rax
			//   RectInt v298; // xmm6
			//   Vector3 *v299; // rax
			//   __int64 v300; // xmm7_8
			//   float v301; // edi
			//   Vector3 *v302; // rax
			//   __int64 v303; // xmm8_8
			//   float v304; // esi
			//   Vector3 *v305; // rax
			//   float v306; // r15d
			//   Vector3 *v307; // rax
			//   __int64 v308; // xmm9_8
			//   float v309; // r12d
			//   Vector3 *v310; // rax
			//   __int64 v311; // xmm1_8
			//   Vector3 *v312; // rax
			//   float v313; // r12d
			//   float v314; // xmm11_4
			//   float v315; // xmm3_4
			//   __m128 v316; // xmm10
			//   __m128 v317; // xmm2
			//   __m128 v318; // xmm9
			//   __m128 v319; // xmm1
			//   Vector3 *v320; // rax
			//   __int64 v321; // xmm7_8
			//   float v322; // edi
			//   Vector3 *v323; // rax
			//   Vector3 *v324; // rax
			//   float v325; // xmm3_4
			//   __m128 v326; // xmm2
			//   __m128 v327; // xmm1
			//   Vector3 *v328; // rax
			//   __int64 v329; // xmm7_8
			//   float v330; // edi
			//   Vector3 *v331; // rax
			//   Vector3 *v332; // rax
			//   float v333; // xmm11_4
			//   __int64 v334; // rdx
			//   __int64 v335; // rcx
			//   Camera *v336; // rdi
			//   __int64 (__fastcall *v337)(Camera *); // rax
			//   uint32_t v338; // esi
			//   RectInt v339; // xmm6
			//   Camera *v340; // rdi
			//   uint64_t v341; // rax
			//   float v342; // xmm0_4
			//   uint32_t v343; // r15d
			//   void (*v344)(void); // rax
			//   HGObjectFlags__Enum v345; // edi
			//   HGRenderFlags__Enum v346; // esi
			//   uint32_t v347; // edi
			//   uint32_t v348; // eax
			//   __int64 v349; // rdx
			//   Object *v350; // rcx
			//   ILFixDynamicMethodWrapper_2 *v351; // rax
			//   __int64 v352; // rdx
			//   __int64 v353; // rcx
			//   ProfilingSampler *v354; // rax
			//   __int64 v355; // rdx
			//   __int64 v356; // rcx
			//   __int64 v357; // rdx
			//   Entity_1__Array *m_targetStaticPunctualLights; // rcx
			//   __int64 v359; // rdx
			//   Entity_1__Array *v360; // rcx
			//   __int64 v361; // rdx
			//   __int64 v362; // rcx
			//   Vector4__Array *v363; // rdi
			//   float v364; // xmm6_4
			//   int32_t m; // ebx
			//   Object *v366; // rbx
			//   __int64 v367; // rdx
			//   __int64 v368; // rcx
			//   TextureHandle v369; // xmm0
			//   Object *v370; // rdx
			//   int v371; // eax
			//   unsigned int v372; // edx
			//   unsigned __int64 v373; // r8
			//   char v374; // dl
			//   signed __int64 v375; // rtt
			//   Object *v376; // rdx
			//   MonitorData *v377; // rcx
			//   unsigned int v378; // edx
			//   unsigned __int64 v379; // r8
			//   char v380; // dl
			//   signed __int64 v381; // rtt
			//   Object *v382; // rdx
			//   Object__Class *m_punctualLightShadowParams2; // rcx
			//   unsigned int v384; // edx
			//   unsigned __int64 v385; // r8
			//   signed __int64 v386; // rtt
			//   int32_t n; // ebx
			//   int32_t ii; // edi
			//   __int64 v389; // rdx
			//   HGShadowConstantBufferUtils__StaticFields *v390; // rsi
			//   Matrix4x4__Array *m_punctualLightWorldToShadowMatrices; // rcx
			//   Matrix4x4 *v392; // rax
			//   int jj; // edi
			//   __int64 v394; // rdx
			//   HGShadowConstantBufferUtils__StaticFields *v395; // rsi
			//   Vector4__Array *v396; // rcx
			//   __int64 v397; // rax
			//   int kk; // edi
			//   __int64 v399; // rdx
			//   HGShadowConstantBufferUtils__StaticFields *v400; // rsi
			//   Vector4__Array *v401; // rcx
			//   __int64 v402; // rax
			//   float v403; // xmm2_4
			//   __int64 v404; // rdx
			//   ProfilingSampler *v405; // rax
			//   __int64 v406; // rdx
			//   __int64 v407; // rcx
			//   __int64 v408; // rdx
			//   __int64 v409; // rcx
			//   HGRenderGraphDefaultResources *m_DefaultResources; // rax
			//   __int64 v411; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v413; // rdx
			//   __int64 v414; // rcx
			//   HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-AA8h]
			//   HGRenderKeyword__Enum globalKeywordsa; // [rsp+20h] [rbp-AA8h]
			//   Vector3 v417; // [rsp+60h] [rbp-A68h] BYREF
			//   Vector3 v418; // [rsp+70h] [rbp-A58h] BYREF
			//   Vector3 v419; // [rsp+80h] [rbp-A48h] BYREF
			//   HGSharedLightData light; // [rsp+90h] [rbp-A38h] BYREF
			//   HGObjectFlags__Enum objectFlags; // [rsp+98h] [rbp-A30h] BYREF
			//   HGRenderFlags__Enum renderFlags; // [rsp+9Ch] [rbp-A2Ch] BYREF
			//   HGSharedLightData _unity_self; // [rsp+A0h] [rbp-A28h] BYREF
			//   HGSharedLightData HGSharedLightData; // [rsp+A8h] [rbp-A20h] BYREF
			//   HGRenderFlags__Enum renderFlagsMask; // [rsp+B0h] [rbp-A18h] BYREF
			//   Vector3 v426; // [rsp+B8h] [rbp-A10h] BYREF
			//   Entity_1 entity; // [rsp+C8h] [rbp-A00h] BYREF
			//   RectInt v428; // [rsp+D0h] [rbp-9F8h] BYREF
			//   RectInt v429; // [rsp+E0h] [rbp-9E8h] BYREF
			//   int32_t v430; // [rsp+F0h] [rbp-9D8h]
			//   HGObjectFlags__Enum objectFlagsMask; // [rsp+F4h] [rbp-9D4h] BYREF
			//   Object *v432; // [rsp+F8h] [rbp-9D0h] BYREF
			//   Object *v433; // [rsp+100h] [rbp-9C8h] BYREF
			//   Plane v434; // [rsp+108h] [rbp-9C0h] BYREF
			//   Matrix4x4 v435; // [rsp+120h] [rbp-9A8h] BYREF
			//   float v436; // [rsp+160h] [rbp-968h]
			//   HGObjectFlags__Enum v437; // [rsp+164h] [rbp-964h] BYREF
			//   HGObjectFlags__Enum v438; // [rsp+168h] [rbp-960h] BYREF
			//   Object *v439; // [rsp+170h] [rbp-958h] BYREF
			//   Plane v440; // [rsp+178h] [rbp-950h] BYREF
			//   __int64 v441; // [rsp+188h] [rbp-940h]
			//   Object *v442; // [rsp+190h] [rbp-938h] BYREF
			//   NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ v443; // [rsp+1A0h] [rbp-928h] BYREF
			//   Matrix4x4 v444; // [rsp+1B0h] [rbp-918h] BYREF
			//   RectInt v445; // [rsp+1F0h] [rbp-8D8h] BYREF
			//   Matrix4x4 v446; // [rsp+200h] [rbp-8C8h] BYREF
			//   Matrix4x4 v447; // [rsp+240h] [rbp-888h] BYREF
			//   HGPunctualLightShadowManagerV2 *v448; // [rsp+280h] [rbp-848h]
			//   Object *v449; // [rsp+288h] [rbp-840h]
			//   __int64 v450; // [rsp+290h] [rbp-838h]
			//   float v451; // [rsp+298h] [rbp-830h]
			//   TextureHandle *v452; // [rsp+2A0h] [rbp-828h] BYREF
			//   Plane v453; // [rsp+2A8h] [rbp-820h] BYREF
			//   Plane v454; // [rsp+2B8h] [rbp-810h] BYREF
			//   Vector4 v455; // [rsp+2C8h] [rbp-800h] BYREF
			//   Plane v456; // [rsp+2D8h] [rbp-7F0h] BYREF
			//   Plane v457; // [rsp+2E8h] [rbp-7E0h] BYREF
			//   Matrix4x4 v458; // [rsp+300h] [rbp-7C8h] BYREF
			//   Vector3 v459; // [rsp+340h] [rbp-788h] BYREF
			//   Vector3 v460; // [rsp+350h] [rbp-778h] BYREF
			//   Vector3 v461; // [rsp+360h] [rbp-768h] BYREF
			//   Vector3 v462; // [rsp+370h] [rbp-758h] BYREF
			//   Vector3 v463; // [rsp+380h] [rbp-748h] BYREF
			//   Vector3 v464; // [rsp+390h] [rbp-738h] BYREF
			//   Vector3 v465; // [rsp+3A0h] [rbp-728h] BYREF
			//   Vector3 v466; // [rsp+3B0h] [rbp-718h] BYREF
			//   Vector3 v467; // [rsp+3C0h] [rbp-708h] BYREF
			//   Vector3 v468; // [rsp+3D0h] [rbp-6F8h] BYREF
			//   Vector3 v469; // [rsp+3E0h] [rbp-6E8h] BYREF
			//   Vector3 v470; // [rsp+3F0h] [rbp-6D8h] BYREF
			//   Vector3 v471; // [rsp+400h] [rbp-6C8h] BYREF
			//   Vector3 v472; // [rsp+410h] [rbp-6B8h] BYREF
			//   Vector3 v473; // [rsp+420h] [rbp-6A8h] BYREF
			//   Vector3 v474; // [rsp+430h] [rbp-698h] BYREF
			//   Vector3 v475; // [rsp+440h] [rbp-688h] BYREF
			//   Vector3 v476; // [rsp+450h] [rbp-678h] BYREF
			//   Vector3 v477; // [rsp+460h] [rbp-668h] BYREF
			//   Vector3 v478; // [rsp+470h] [rbp-658h] BYREF
			//   Vector3 v479; // [rsp+480h] [rbp-648h] BYREF
			//   Vector3 v480; // [rsp+490h] [rbp-638h] BYREF
			//   Vector3 v481; // [rsp+4A0h] [rbp-628h] BYREF
			//   Vector3 v482; // [rsp+4B0h] [rbp-618h] BYREF
			//   Vector3 v483; // [rsp+4C0h] [rbp-608h] BYREF
			//   Vector3 v484; // [rsp+4D0h] [rbp-5F8h] BYREF
			//   Vector3 v485; // [rsp+4E0h] [rbp-5E8h] BYREF
			//   Vector3 v486; // [rsp+4F0h] [rbp-5D8h] BYREF
			//   Vector3 v487; // [rsp+500h] [rbp-5C8h] BYREF
			//   Vector3 v488; // [rsp+510h] [rbp-5B8h] BYREF
			//   Vector3 v489; // [rsp+520h] [rbp-5A8h] BYREF
			//   __int64 v490; // [rsp+530h] [rbp-598h]
			//   Vector3 v491; // [rsp+540h] [rbp-588h] BYREF
			//   Vector3 v492; // [rsp+550h] [rbp-578h] BYREF
			//   Vector3 v493; // [rsp+560h] [rbp-568h] BYREF
			//   Vector3 v494; // [rsp+570h] [rbp-558h] BYREF
			//   __int64 v495; // [rsp+580h] [rbp-548h]
			//   Vector3 v496; // [rsp+590h] [rbp-538h] BYREF
			//   __int64 v497; // [rsp+5A0h] [rbp-528h]
			//   Vector3 v498; // [rsp+5B0h] [rbp-518h] BYREF
			//   Vector3 v499; // [rsp+5C0h] [rbp-508h] BYREF
			//   Vector3 v500; // [rsp+5D0h] [rbp-4F8h] BYREF
			//   Vector3 v501; // [rsp+5E0h] [rbp-4E8h] BYREF
			//   Vector3 v502; // [rsp+5F0h] [rbp-4D8h] BYREF
			//   Vector3 v503; // [rsp+600h] [rbp-4C8h] BYREF
			//   Vector3 v504; // [rsp+610h] [rbp-4B8h] BYREF
			//   Vector3 v505; // [rsp+620h] [rbp-4A8h] BYREF
			//   Vector3 v506; // [rsp+630h] [rbp-498h] BYREF
			//   HGRenderGraphBuilder v507; // [rsp+640h] [rbp-488h] BYREF
			//   HGRenderGraphBuilder v508; // [rsp+660h] [rbp-468h] BYREF
			//   Vector3 v509; // [rsp+680h] [rbp-448h] BYREF
			//   __int64 v510; // [rsp+690h] [rbp-438h]
			//   HGRenderGraphBuilder v511; // [rsp+6A0h] [rbp-428h] BYREF
			//   HGRenderGraphBuilder v512; // [rsp+6C0h] [rbp-408h] BYREF
			//   Plane v513; // [rsp+6E0h] [rbp-3E8h] BYREF
			//   Plane v514; // [rsp+6F0h] [rbp-3D8h] BYREF
			//   __int128 v515; // [rsp+700h] [rbp-3C8h]
			//   EntityManager_1 v516; // [rsp+710h] [rbp-3B8h] BYREF
			//   __int128 v517; // [rsp+720h] [rbp-3A8h]
			//   Plane v518; // [rsp+730h] [rbp-398h] BYREF
			//   Plane v519; // [rsp+740h] [rbp-388h] BYREF
			//   Plane v520; // [rsp+750h] [rbp-378h] BYREF
			//   Plane v521; // [rsp+760h] [rbp-368h] BYREF
			//   Plane v522; // [rsp+770h] [rbp-358h] BYREF
			//   Plane v523; // [rsp+780h] [rbp-348h] BYREF
			//   Il2CppExceptionWrapper *v524; // [rsp+790h] [rbp-338h] BYREF
			//   Il2CppExceptionWrapper *v525; // [rsp+798h] [rbp-330h] BYREF
			//   Il2CppExceptionWrapper *v526; // [rsp+7A0h] [rbp-328h] BYREF
			//   Il2CppExceptionWrapper *v527; // [rsp+7A8h] [rbp-320h] BYREF
			//   Matrix4x4 v528; // [rsp+7B0h] [rbp-318h] BYREF
			//   Matrix4x4 v529; // [rsp+7F0h] [rbp-2D8h] BYREF
			//   Matrix4x4 v530; // [rsp+830h] [rbp-298h] BYREF
			//   Vector3 v531; // [rsp+870h] [rbp-258h] BYREF
			//   Vector3 v532; // [rsp+880h] [rbp-248h] BYREF
			//   Vector3 v533; // [rsp+890h] [rbp-238h] BYREF
			//   Vector3 v534; // [rsp+8A0h] [rbp-228h] BYREF
			//   Vector3 v535; // [rsp+8B0h] [rbp-218h] BYREF
			//   Vector3 v536; // [rsp+8C0h] [rbp-208h] BYREF
			//   Vector3 v537; // [rsp+8D0h] [rbp-1F8h] BYREF
			//   Vector3 v538; // [rsp+8E0h] [rbp-1E8h] BYREF
			//   Vector3 v539; // [rsp+8F0h] [rbp-1D8h] BYREF
			//   Vector3 v540; // [rsp+900h] [rbp-1C8h] BYREF
			//   Vector3 v541; // [rsp+910h] [rbp-1B8h] BYREF
			//   Vector3 v542; // [rsp+920h] [rbp-1A8h] BYREF
			//   Vector3 v543; // [rsp+930h] [rbp-198h] BYREF
			//   Vector3 v544; // [rsp+940h] [rbp-188h] BYREF
			//   Vector3 v545; // [rsp+950h] [rbp-178h] BYREF
			//   Vector3 v546; // [rsp+960h] [rbp-168h] BYREF
			//   Vector3 v547; // [rsp+970h] [rbp-158h] BYREF
			//   Vector3 v548; // [rsp+980h] [rbp-148h] BYREF
			//   Vector3 v549; // [rsp+990h] [rbp-138h] BYREF
			//   Vector3 v550; // [rsp+9A0h] [rbp-128h] BYREF
			//   Vector3 v551; // [rsp+9B0h] [rbp-118h] BYREF
			//   Vector3 v552; // [rsp+9C0h] [rbp-108h] BYREF
			//   TextureHandle v553; // [rsp+9D0h] [rbp-F8h] BYREF
			//   Vector4 v554; // [rsp+9E0h] [rbp-E8h] BYREF
			// 
			//   v9 = this;
			//   v448 = this;
			//   if ( !byte_18D919EA3 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPushDataPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPassData>);
			//     sub_18003C530(&MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPushDataPassData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::LightCaster);
			//     sub_18003C530(&MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     sub_18003C530(&off_18D5F2EA8);
			//     sub_18003C530(&off_18D5F2E98);
			//     sub_18003C530(&off_18D5F2E88);
			//     sub_18003C530(&off_18D5F2E78);
			//     byte_18D919EA3 = 1;
			//   }
			//   memset(&v512, 0, sizeof(v512));
			//   v452 = 0LL;
			//   _unity_self = 0LL;
			//   sub_1802F01E0(&v444, 0LL, 64LL);
			//   sub_1802F01E0(&v447, 0LL, 64LL);
			//   sub_1802F01E0(&v458, 0LL, 64LL);
			//   memset(&v507, 0, sizeof(v507));
			//   v433 = 0LL;
			//   v445 = 0LL;
			//   HGSharedLightData = 0LL;
			//   sub_1802F01E0(&v528, 0LL, 64LL);
			//   sub_1802F01E0(&v529, 0LL, 64LL);
			//   sub_1802F01E0(&v530, 0LL, 64LL);
			//   memset(&v508, 0, sizeof(v508));
			//   v432 = 0LL;
			//   memset(&v511, 0, sizeof(v511));
			//   v439 = 0LL;
			//   v516 = 0LL;
			//   v449 = 0LL;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1853, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1853, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v414, v413);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_721(
			//       Patch,
			//       (Object *)v9,
			//       (Object *)renderGraph,
			//       (Object *)hgCamera,
			//       (Object *)settingParams,
			//       shadowResult,
			//       0LL);
			//     return;
			//   }
			//   if ( !HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::IsPunctualLightShadowEnabled(v9, settingParams, 0LL) )
			//   {
			//     v405 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//              (Int32Enum__Enum)0x7Eu,
			//              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//     if ( !renderGraph )
			//       sub_180B536AC(v407, v406);
			//     v512 = *(HGRenderGraphBuilder *)sub_180836C50(
			//                                       (unsigned int)&v447,
			//                                       (_DWORD)renderGraph,
			//                                       (unsigned int)"Skip Punctual Light ShadowMap",
			//                                       (unsigned int)&v452,
			//                                       (__int64)v405);
			//     *(_QWORD *)&v434.m_Normal.x = 0LL;
			//     *(_QWORD *)&v434.m_Normal.z = &v512;
			//     try
			//     {
			//       m_DefaultResources = renderGraph.fields.m_DefaultResources;
			//       if ( !m_DefaultResources )
			//         sub_1802DC2C8(v409, v408);
			//       if ( !v452 )
			//         sub_1802DC2C8(v409, v408);
			//       v452[1] = m_DefaultResources.fields._defaultShadowTexture_k__BackingField;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//         &v512,
			//         (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_punctualLightShadowMapSkipRenderFunc,
			//         0LL,
			//         0,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPushDataPassData>);
			//       HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v512, 0, 0LL);
			//       shadowResult.punctualLightShadowActive = 0;
			//       if ( !v452 )
			//         sub_1802DC2C8(0LL, v411);
			//       shadowResult.punctualLightShadowResult = v452[1];
			//     }
			//     catch ( Il2CppExceptionWrapper *v525 )
			//     {
			//       *(Il2CppExceptionWrapper *)&v434.m_Normal.x = (Il2CppExceptionWrapper)v525.ex;
			//     }
			//     sub_180222690(&v434);
			//     return;
			//   }
			//   if ( !hgCamera )
			//     goto LABEL_245;
			//   camera = (unsigned __int64)hgCamera.fields.camera;
			//   if ( !camera )
			//     goto LABEL_245;
			//   transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//   if ( !transform )
			//     goto LABEL_245;
			//   position = UnityEngine::Transform::get_position(&v419, transform, 0LL);
			//   v14 = *(_QWORD *)&position.x;
			//   v441 = v14;
			//   v450 = v14;
			//   z_low = LODWORD(position.z);
			//   v436 = *(float *)&z_low;
			//   v451 = *(float *)&z_low;
			//   punctualLightStaticAtlasAllocator = v9.fields.punctualLightStaticAtlasAllocator;
			//   if ( !punctualLightStaticAtlasAllocator )
			//     goto LABEL_245;
			//   m_slotOccupied = punctualLightStaticAtlasAllocator.fields.m_slotOccupied;
			//   if ( !m_slotOccupied )
			//     goto LABEL_245;
			//   size = m_slotOccupied.max_length.size;
			//   v430 = size;
			//   m_targetUpdateRequest = v9.fields.m_targetUpdateRequest;
			//   if ( !m_targetUpdateRequest )
			//     goto LABEL_245;
			//   if ( !m_targetUpdateRequest.fields.requestType )
			//     goto LABEL_75;
			//   v19 = *(__m128i *)HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::GetRectFromSlotIndex(
			//                       (RectInt *)&v455,
			//                       v9.fields.punctualLightStaticAtlasAllocator,
			//                       m_targetUpdateRequest.fields.targetSlot,
			//                       0LL);
			//   v428 = (RectInt)v19;
			//   v20 = v9.fields.m_targetUpdateRequest;
			//   if ( !v20 )
			//     goto LABEL_245;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//   _unity_self = HG::Rendering::Runtime::LightCaster::GetHGSharedLightData(&v20.fields.requestLightCaster, 0LL);
			//   v21 = v9.fields.m_targetUpdateRequest;
			//   if ( !v21 )
			//     goto LABEL_245;
			//   index = v21.fields.requestLightCaster.index;
			//   targetSlot = v21.fields.targetSlot;
			//   objectFlags = targetSlot;
			//   if ( UnityEngine::HGSharedLightData::get_type_Injected(&_unity_self, 0LL) )
			//   {
			//     if ( UnityEngine::HGSharedLightData::get_type_Injected(&_unity_self, 0LL) != LightType__Enum_Point )
			//     {
			// LABEL_16:
			//       HG::Rendering::HGRPLogger::LogError((String *)"HGPunctualLightShadowManagerV2: Unexpected light type.", 0LL);
			//       return;
			//     }
			//     worldPosition = UnityEngine::HGSharedLightData::get_worldPosition(&v419, &_unity_self, 0LL);
			//     v25 = *(_QWORD *)&worldPosition.x;
			//     z = worldPosition.z;
			//     shadowNearPlane_Injected = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&_unity_self, 0LL);
			//     shadowFarPlane_Injected = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&_unity_self, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//     *(_QWORD *)&v417.x = v25;
			//     v417.z = z;
			//     HG::Rendering::Runtime::HGShadowUtils::ExtractPointLightMatrix(
			//       &v446,
			//       &v417,
			//       index,
			//       shadowNearPlane_Injected,
			//       shadowFarPlane_Injected,
			//       2.0,
			//       &v444,
			//       &v447,
			//       &v458,
			//       0LL);
			//     targetSlot = objectFlags;
			//   }
			//   else
			//   {
			//     localToWorldMatrix = UnityEngine::HGSharedLightData::get_localToWorldMatrix(&v446, &_unity_self, 0LL);
			//     v30 = *(_OWORD *)&localToWorldMatrix.m00;
			//     v31 = *(_OWORD *)&localToWorldMatrix.m01;
			//     v32 = *(_OWORD *)&localToWorldMatrix.m02;
			//     v33 = *(_OWORD *)&localToWorldMatrix.m03;
			//     spotAngle_Injected = UnityEngine::HGSharedLightData::get_spotAngle_Injected(&_unity_self, 0LL);
			//     v35 = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&_unity_self, 0LL);
			//     v36 = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&_unity_self, 0LL);
			//     shadowGuardAngle_Injected = UnityEngine::HGSharedLightData::get_shadowGuardAngle_Injected(&_unity_self, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//     *(_OWORD *)&v435.m00 = v30;
			//     *(_OWORD *)&v435.m01 = v31;
			//     *(_OWORD *)&v435.m02 = v32;
			//     *(_OWORD *)&v435.m03 = v33;
			//     HG::Rendering::Runtime::HGShadowUtils::ExtractSpotLightMatrix(
			//       &v446,
			//       &v435,
			//       spotAngle_Injected,
			//       v35,
			//       v36,
			//       shadowGuardAngle_Injected,
			//       &v444,
			//       &v447,
			//       &v458,
			//       0LL);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//   v38 = *(_OWORD *)&v444.m00;
			//   v435 = v444;
			//   v39 = *(_OWORD *)&v444.m01;
			//   v40 = *(_OWORD *)&v444.m02;
			//   v41 = *(_OWORD *)&v444.m03;
			//   v42 = *(_OWORD *)&v447.m00;
			//   v444 = v447;
			//   v43 = *(__m128 *)&v447.m01;
			//   v44 = *(_OWORD *)&v447.m02;
			//   v45 = *(_OWORD *)&v447.m03;
			//   ShadowTransform = HG::Rendering::Runtime::HGShadowUtils::GetShadowTransform(&v446, &v444, &v435, 0LL);
			//   v454 = *(Plane *)&ShadowTransform.m00;
			//   v453 = *(Plane *)&ShadowTransform.m01;
			//   v457 = *(Plane *)&ShadowTransform.m02;
			//   v456 = *(Plane *)&ShadowTransform.m03;
			//   camera = (unsigned __int64)v9.fields.m_punctualLightWorldToShadowMatrices;
			//   if ( !camera )
			//     goto LABEL_245;
			//   v435 = *ShadowTransform;
			//   sub_180077420(camera, (int)targetSlot, &v435);
			//   m_punctualLightShadowParams = v9.fields.m_punctualLightShadowParams;
			//   shadowNormalBias_Injected = UnityEngine::HGSharedLightData::get_shadowNormalBias_Injected(&_unity_self, 0LL);
			//   *(_OWORD *)&v435.m00 = v42;
			//   *(__m128 *)&v435.m01 = v43;
			//   *(_OWORD *)&v435.m02 = v44;
			//   *(_OWORD *)&v435.m03 = v45;
			//   ShadowBias = HG::Rendering::Runtime::HGShadowUtils::GetShadowBias(
			//                  &v455,
			//                  &v435,
			//                  (float)_mm_cvtsi128_si32(_mm_srli_si128(v19, 8)),
			//                  0.0,
			//                  shadowNormalBias_Injected,
			//                  HGShadowSampleMode__Enum_PCF_3x3,
			//                  0LL);
			//   if ( !m_punctualLightShadowParams )
			//     goto LABEL_245;
			//   v429 = (RectInt)*ShadowBias;
			//   sub_18004D910(m_punctualLightShadowParams, (int)targetSlot, &v429);
			//   v50 = v9.fields.m_punctualLightShadowParams;
			//   if ( !v50 )
			//     goto LABEL_245;
			//   shadowStrength_Injected = UnityEngine::HGSharedLightData::get_shadowStrength_Injected(&_unity_self, 0LL);
			//   *(float *)(sub_18003EB40(v50, (int)targetSlot) + 12) = shadowStrength_Injected;
			//   light = (HGSharedLightData)v9.fields.m_punctualLightShadowParams2;
			//   xMin = UnityEngine::RectInt::get_xMin(&v428, 0LL);
			//   m_X = v9.fields.m_punctualShadowAtlasSize.m_X;
			//   yMin = UnityEngine::RectInt::get_yMin(&v428, 0LL);
			//   m_Y = v9.fields.m_punctualShadowAtlasSize.m_Y;
			//   xMax = UnityEngine::RectInt::get_xMax(&v428, 0LL);
			//   v57 = this.fields.m_punctualShadowAtlasSize.m_X;
			//   *(float *)&v58 = (float)UnityEngine::RectInt::get_yMax(&v428, 0LL) / (float)this.fields.m_punctualShadowAtlasSize.m_Y;
			//   *(float *)&v428.m_XMin = (float)xMin / (float)m_X;
			//   *(float *)&v428.m_YMin = (float)yMin / (float)m_Y;
			//   *(float *)&v428.m_Width = (float)xMax / (float)v57;
			//   v428.m_Height = v58;
			//   if ( !*(_QWORD *)&light
			//     || (v429 = v428,
			//         ((void (__fastcall *)(_QWORD, _QWORD, _QWORD))sub_18004D910)(light, (int)objectFlags, &v429),
			//         v59 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                 (Int32Enum__Enum)0x7Du,
			//                 MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>),
			//         !renderGraph) )
			//   {
			// LABEL_245:
			//     sub_1802DC2C8(camera, z_low);
			//   }
			//   HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//     (HGRenderGraphBuilder *)&v447,
			//     renderGraph,
			//     (String *)"Render Punctual Light ShadowMaps",
			//     &v433,
			//     v59,
			//     1,
			//     ProfilingHGPass__Enum_Shadow,
			//     MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPassData>);
			//   *(_OWORD *)&v507.m_RenderPass = *(_OWORD *)&v447.m00;
			//   *(_OWORD *)&v507.m_RenderGraph = *(_OWORD *)&v447.m01;
			//   *(_QWORD *)&v428.m_XMin = 0LL;
			//   *(_QWORD *)&v428.m_Width = &v507;
			//   try
			//   {
			//     v62 = v433;
			//     if ( !v433 )
			//       sub_1802DC2C8(v61, v60);
			//     *(Object *)((char *)v433 + 60) = *(Object *)&v458.m00;
			//     *(Object *)((char *)v62 + 76) = *(Object *)&v458.m01;
			//     *(Object *)((char *)v62 + 92) = *(Object *)&v458.m02;
			//     *(Object *)((char *)v62 + 108) = *(Object *)&v458.m03;
			//     v63 = v433;
			//     if ( !v433 )
			//       sub_1802DC2C8(v61, v60);
			//     *(_OWORD *)((char *)&v433[7].monitor + 4) = v38;
			//     *(_OWORD *)((char *)&v63[8].monitor + 4) = v39;
			//     *(_OWORD *)((char *)&v63[9].monitor + 4) = v40;
			//     *(_OWORD *)((char *)&v63[10].monitor + 4) = v41;
			//     if ( !v433 )
			//       sub_1802DC2C8(v61, v60);
			//     *(__m128i *)((char *)v433 + 44) = v19;
			//     v64 = v433;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields;
			//     if ( !v64 )
			//       sub_1802DC2C8(static_fields, v65);
			//     v64[15].klass = (Object__Class *)static_fields.s_clearShadowMaterial;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v67 = (((unsigned __int64)&v64[15] >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6405E0[v67 + 36190]);
			//       do
			//         v68 = qword_18D6405E0[v67 + 36190];
			//       while ( v68 != _InterlockedCompareExchange64(
			//                        &qword_18D6405E0[v67 + 36190],
			//                        v68 | (1LL << (((unsigned __int64)&v64[15] >> 12) & 0x3F)),
			//                        v68) );
			//     }
			//     v69 = v433;
			//     v9 = this;
			//     v72 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//              (TextureHandle *)&v455,
			//              renderGraph,
			//              this.fields.m_cachedPunctualLightShadowAtlas,
			//              0LL);
			//     if ( !v69 )
			//       sub_1802DC2C8(v71, v70);
			//     *(TextureHandle *)&v69[13].monitor = v72;
			//     v73 = v433;
			//     shadowBias_Injected = UnityEngine::HGSharedLightData::get_shadowBias_Injected(&_unity_self, 0LL);
			//     if ( !v73 )
			//       sub_1802DC2C8(v75, v74);
			//     *(float *)&v73[2].monitor = shadowBias_Injected;
			//     v77 = _unity_self;
			//     m_RenderGraphContext = renderGraph.fields.m_RenderGraphContext;
			//     if ( !m_RenderGraphContext )
			//       sub_1802DC2C8(v75, v74);
			//     v79.m_Ptr = m_RenderGraphContext.fields.renderContext.m_Ptr;
			//     *(_OWORD *)&v435.m00 = v38;
			//     *(_OWORD *)&v435.m01 = v39;
			//     *(_OWORD *)&v435.m02 = v40;
			//     *(_OWORD *)&v435.m03 = v41;
			//     *(_OWORD *)&v444.m00 = v42;
			//     *(__m128 *)&v444.m01 = v43;
			//     *(_OWORD *)&v444.m02 = v44;
			//     *(_OWORD *)&v444.m03 = v45;
			//     v80 = UnityEngine::Matrix4x4::op_Multiply(&v446, &v444, &v435, 0LL);
			//     if ( !v433 )
			//       sub_1802DC2C8(0LL, v81);
			//     v435 = *v80;
			//     HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PrepareRendererList(
			//       this,
			//       v77,
			//       hgCamera,
			//       v79,
			//       &v435,
			//       0,
			//       (RendererList *)&v433[12].monitor,
			//       0LL);
			//     v84 = renderGraph.fields.m_RenderGraphContext;
			//     if ( !v84 )
			//       sub_1802DC2C8(v83, v82);
			//     m_Ptr = v84.fields.renderContext.m_Ptr;
			//     LODWORD(v86) = _mm_shuffle_ps(v43, v43, 85).m128_u32[0];
			//     if ( !v433 )
			//       sub_1802DC2C8(v83, v82);
			//     v87 = (uint32_t *)&v433[11].monitor + 1;
			//     v442 = (Object *)((char *)v433 + 188);
			//     v88 = (uint32_t *)&v433[12];
			//     entity = (Entity_1)&v433[12];
			//     *(_OWORD *)&v444.m00 = v38;
			//     *(_OWORD *)&v444.m01 = v39;
			//     *(_OWORD *)&v444.m02 = v40;
			//     *(_OWORD *)&v444.m03 = v41;
			//     light = _unity_self;
			//     if ( !byte_18D919EA2 )
			//     {
			//       sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//       sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//       sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
			//       sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       byte_18D919EA2 = 1;
			//     }
			//     v443 = 0LL;
			//     *(_QWORD *)&v417.x = 0LL;
			//     v417.z = 0.0;
			//     memset(&v447, 0, 56);
			//     objectFlags = HGObjectFlags__Enum_None;
			//     *(float *)&objectFlagsMask = 0.0;
			//     renderFlags = HGRenderFlags__Enum_None;
			//     renderFlagsMask = HGRenderFlags__Enum_None;
			//     if ( IFix::WrappersManagerImpl::IsPatched(1851, 0LL) )
			//     {
			//       v181 = IFix::WrappersManagerImpl::GetPatch(1851, 0LL);
			//       if ( !v181 )
			//         sub_1802DC2C8(v183, v182);
			//       *(_OWORD *)&v435.m00 = v38;
			//       *(_OWORD *)&v435.m01 = v39;
			//       *(_OWORD *)&v435.m02 = v40;
			//       *(_OWORD *)&v435.m03 = v41;
			//       *(Plane *)&v444.m00 = v454;
			//       *(Plane *)&v444.m01 = v453;
			//       *(Plane *)&v444.m02 = v457;
			//       *(Plane *)&v444.m03 = v456;
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_717(
			//         v181,
			//         (Object *)this,
			//         light,
			//         (Object *)hgCamera,
			//         (ScriptableRenderContext)m_Ptr,
			//         &v444,
			//         &v435,
			//         v86,
			//         0,
			//         v87,
			//         v88,
			//         0LL);
			//     }
			//     else
			//     {
			//       v89 = (unsigned __int8 (__fastcall *)(HGSharedLightData *))qword_18D92E828;
			//       if ( !qword_18D92E828 )
			//       {
			//         v89 = (unsigned __int8 (__fastcall *)(HGSharedLightData *))sub_180017470(
			//                                                                      "UnityEngine.HGSharedLightData::get_enableOBBCulling"
			//                                                                      "Box_Injected(UnityEngine.HGSharedLightData&)");
			//         qword_18D92E828 = (__int64)v89;
			//       }
			//       if ( v89(&light) )
			//         Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::EntityCommandBufferV2::VirtualEntityMap>::NativeArray(
			//           &v443,
			//           12,
			//           Allocator__Enum_Temp,
			//           NativeArrayOptions__Enum_ClearMemory,
			//           MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
			//       else
			//         Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::EntityCommandBufferV2::VirtualEntityMap>::NativeArray(
			//           &v443,
			//           6,
			//           Allocator__Enum_Temp,
			//           NativeArrayOptions__Enum_ClearMemory,
			//           MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//       v90 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields;
			//       *(Plane *)&v435.m00 = v454;
			//       *(Plane *)&v435.m01 = v453;
			//       *(Plane *)&v435.m02 = v457;
			//       *(Plane *)&v435.m03 = v456;
			//       UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v435, v90.s_cullPlanes, 0LL);
			//       inverse = UnityEngine::Matrix4x4::get_inverse(&v435, &v444, 0LL);
			//       *(_OWORD *)&v446.m00 = *(_OWORD *)&inverse.m00;
			//       *(_OWORD *)&v446.m01 = *(_OWORD *)&inverse.m01;
			//       v92 = *(__m128 *)&inverse.m02;
			//       *(_OWORD *)&v446.m03 = *(_OWORD *)&inverse.m03;
			//       *(_OWORD *)&v446.m00 = *(_OWORD *)&inverse.m00;
			//       *(_OWORD *)&v446.m01 = *(_OWORD *)&inverse.m01;
			//       *(_OWORD *)&v446.m03 = *(_OWORD *)&inverse.m03;
			//       *(_OWORD *)&v446.m01 = *(_OWORD *)&inverse.m01;
			//       *(_OWORD *)&v446.m03 = *(_OWORD *)&inverse.m03;
			//       v93 = _mm_xor_ps(v92, (__m128)0x80000000);
			//       v94 = _mm_xor_ps((__m128)LODWORD(inverse.m12), (__m128)0x80000000);
			//       v95 = -inverse.m22;
			//       v96 = UnityEngine::HGSharedLightData::get_worldPosition(&v419, &light, 0LL);
			//       v97 = *(_QWORD *)&v96.x;
			//       v437 = LODWORD(v96.z);
			//       v98 = *(float *)&v437;
			//       s_cullPlanes = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_cullPlanes;
			//       v100 = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&light, 0LL);
			//       *(_QWORD *)&v417.x = _mm_unpacklo_ps(v93, v94).m128_u64[0];
			//       v417.z = v95;
			//       v417 = *UnityEngine::Vector3::op_Multiply(&v419, &v417, v100, 0LL);
			//       *(_QWORD *)&v418.x = v97;
			//       v418.z = v98;
			//       v101 = UnityEngine::Vector3::op_Addition(&v419, &v418, &v417, 0LL);
			//       v102 = *(_QWORD *)&v101.x;
			//       *(float *)&v101 = v101.z;
			//       v434 = 0LL;
			//       *(_QWORD *)&v417.x = v102;
			//       LODWORD(v417.z) = (_DWORD)v101;
			//       *(_QWORD *)&v418.x = _mm_unpacklo_ps(v93, v94).m128_u64[0];
			//       v418.z = v95;
			//       UnityEngine::Plane::Plane(&v434, &v418, &v417, 0LL);
			//       if ( !s_cullPlanes )
			//         sub_1802DC2C8(v104, v103);
			//       if ( s_cullPlanes.max_length.size <= 4u )
			//         sub_180070260(v104, v103, v105, v106);
			//       s_cullPlanes.vector[4] = v434;
			//       v107 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_cullPlanes;
			//       *(_QWORD *)&v417.x = _mm_unpacklo_ps(v93, v94).m128_u64[0];
			//       v417.z = v95;
			//       v108 = UnityEngine::Vector3::op_UnaryNegation(&v419, &v417, 0LL);
			//       v109 = *(_QWORD *)&v108.x;
			//       v110 = v108.z;
			//       v111 = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&light, 0LL);
			//       *(_QWORD *)&v417.x = _mm_unpacklo_ps(v93, v94).m128_u64[0];
			//       v417.z = v95;
			//       v417 = *UnityEngine::Vector3::op_Multiply(&v419, &v417, v111, 0LL);
			//       *(_QWORD *)&v418.x = v97;
			//       v418.z = v98;
			//       v112 = UnityEngine::Vector3::op_Addition(&v419, &v418, &v417, 0LL);
			//       v113 = *(_QWORD *)&v112.x;
			//       *(float *)&v112 = v112.z;
			//       v440 = 0LL;
			//       *(_QWORD *)&v417.x = v113;
			//       LODWORD(v417.z) = (_DWORD)v112;
			//       *(_QWORD *)&v418.x = v109;
			//       v418.z = v110;
			//       UnityEngine::Plane::Plane(&v440, &v418, &v417, 0LL);
			//       if ( !v107 )
			//         sub_1802DC2C8(v115, v114);
			//       if ( v107.max_length.size <= 5u )
			//         sub_180070260(v115, v114, v116, v117);
			//       v107.vector[5] = v440;
			//       for ( i = 0; i < 6; ++i )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//         v120 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_cullPlanes;
			//         if ( !v120 )
			//           sub_1802DC2C8(0LL, v119);
			//         sub_180037190(v120, &v429, i);
			//         *(RectInt *)&v443.m_Buffer[16 * i] = v429;
			//       }
			//       v121 = (unsigned __int8 (__fastcall *)(HGSharedLightData *))qword_18D92E828;
			//       if ( !qword_18D92E828 )
			//       {
			//         v121 = (unsigned __int8 (__fastcall *)(HGSharedLightData *))sub_180017470(
			//                                                                       "UnityEngine.HGSharedLightData::get_enableOBBCullin"
			//                                                                       "gBox_Injected(UnityEngine.HGSharedLightData&)");
			//         qword_18D92E828 = (__int64)v121;
			//       }
			//       if ( v121(&light) )
			//       {
			//         *(_QWORD *)&v426.x = 0LL;
			//         v426.z = 0.0;
			//         v122 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))qword_18D92E830;
			//         if ( !qword_18D92E830 )
			//         {
			//           v122 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))sub_180017470(
			//                                                                         "UnityEngine.HGSharedLightData::get_cullingBoxRel"
			//                                                                         "ativePosition_Injected(UnityEngine.HGSharedLight"
			//                                                                         "Data&,UnityEngine.Vector3&)");
			//           qword_18D92E830 = (__int64)v122;
			//         }
			//         v122(&light, &v426);
			//         v417 = v426;
			//         *(_QWORD *)&v418.x = v97;
			//         v418.z = v98;
			//         v123 = UnityEngine::Vector3::op_Addition(&v419, &v418, &v417, 0LL);
			//         v124 = *(_QWORD *)&v123.x;
			//         v125 = v123.z;
			//         memset(&v426, 0, sizeof(v426));
			//         v126 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))qword_18D92E838;
			//         if ( !qword_18D92E838 )
			//         {
			//           v126 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))sub_180017470(
			//                                                                         "UnityEngine.HGSharedLightData::get_cullingBoxHal"
			//                                                                         "fExtents_Injected(UnityEngine.HGSharedLightData&"
			//                                                                         ",UnityEngine.Vector3&)");
			//           qword_18D92E838 = (__int64)v126;
			//         }
			//         v126(&light, &v426);
			//         *(_QWORD *)&v418.x = 0LL;
			//         v418.z = 0.0;
			//         v127 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))qword_18D92E840;
			//         if ( !qword_18D92E840 )
			//         {
			//           v127 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))sub_180017470(
			//                                                                         "UnityEngine.HGSharedLightData::get_cullingBoxOri"
			//                                                                         "entation_Injected(UnityEngine.HGSharedLightData&"
			//                                                                         ",UnityEngine.Vector3&)");
			//           qword_18D92E840 = (__int64)v127;
			//         }
			//         v127(&light, &v418);
			//         v417 = v418;
			//         v128 = _mm_loadu_si128((const __m128i *)sub_182504CA0(&v455, &v417));
			//         v417 = *UnityEngine::Vector3::get_fwd(&v419, 0LL);
			//         v429 = (RectInt)v128;
			//         v129 = UnityEngine::Quaternion::op_Multiply(&v419, (Quaternion *)&v429, &v417, 0LL);
			//         v130 = *(_QWORD *)&v129.x;
			//         v131 = v129.z;
			//         v417 = *UnityEngine::Vector3::get_up(&v419, 0LL);
			//         v429 = (RectInt)v128;
			//         v132 = UnityEngine::Quaternion::op_Multiply(&v419, (Quaternion *)&v429, &v417, 0LL);
			//         v133 = *(_QWORD *)&v132.x;
			//         v134 = v132.z;
			//         v417 = *UnityEngine::Vector3::get_right(&v419, 0LL);
			//         v429 = (RectInt)v128;
			//         v135 = UnityEngine::Quaternion::op_Multiply(&v419, (Quaternion *)&v429, &v417, 0LL);
			//         v128.m128i_i64[0] = *(_QWORD *)&v135.x;
			//         v136 = v135.z;
			//         *(_QWORD *)&v417.x = v130;
			//         v417.z = v131;
			//         v137 = UnityEngine::Vector3::op_UnaryNegation(&v419, &v417, 0LL);
			//         v138 = *(_QWORD *)&v137.x;
			//         v438 = LODWORD(v137.z);
			//         *(_QWORD *)&v417.x = v130;
			//         v417.z = v131;
			//         v417 = *UnityEngine::Vector3::op_Multiply(&v419, &v417, v426.z, 0LL);
			//         *(_QWORD *)&v418.x = v124;
			//         v418.z = v125;
			//         v139 = UnityEngine::Vector3::op_Addition(&v419, &v418, &v417, 0LL);
			//         v140 = *(_QWORD *)&v139.x;
			//         *(float *)&v139 = v139.z;
			//         v434 = 0LL;
			//         *(_QWORD *)&v417.x = v140;
			//         LODWORD(v417.z) = (_DWORD)v139;
			//         *(_QWORD *)&v418.x = v138;
			//         LODWORD(v418.z) = v438;
			//         UnityEngine::Plane::Plane(&v434, &v418, &v417, 0LL);
			//         *(Plane *)&v443.m_Buffer[96] = v434;
			//         *(_QWORD *)&v417.x = v130;
			//         v417.z = v131;
			//         v417 = *UnityEngine::Vector3::op_Multiply(&v419, &v417, v426.z, 0LL);
			//         *(_QWORD *)&v418.x = v124;
			//         v418.z = v125;
			//         v142 = UnityEngine::Vector3::op_Subtraction(&v419, &v418, &v417, v141);
			//         v143 = *(_QWORD *)&v142.x;
			//         v144 = v142.z;
			//         v440 = 0LL;
			//         *(_QWORD *)&v417.x = v143;
			//         v417.z = v144;
			//         *(_QWORD *)&v418.x = v130;
			//         v418.z = v131;
			//         UnityEngine::Plane::Plane(&v440, &v418, &v417, 0LL);
			//         *(Plane *)&v443.m_Buffer[112] = v440;
			//         *(_QWORD *)&v417.x = v133;
			//         v417.z = v134;
			//         v145 = UnityEngine::Vector3::op_UnaryNegation(&v419, &v417, 0LL);
			//         v146 = *(_QWORD *)&v145.x;
			//         v147 = v145.z;
			//         *(_QWORD *)&v417.x = v133;
			//         v417.z = v134;
			//         v417 = *UnityEngine::Vector3::op_Multiply(&v419, &v417, v426.y, 0LL);
			//         *(_QWORD *)&v418.x = v124;
			//         v418.z = v125;
			//         v148 = UnityEngine::Vector3::op_Addition(&v419, &v418, &v417, 0LL);
			//         v149 = *(_QWORD *)&v148.x;
			//         *(float *)&v148 = v148.z;
			//         v454 = 0LL;
			//         *(_QWORD *)&v417.x = v149;
			//         LODWORD(v417.z) = (_DWORD)v148;
			//         *(_QWORD *)&v418.x = v146;
			//         v418.z = v147;
			//         UnityEngine::Plane::Plane(&v454, &v418, &v417, 0LL);
			//         *(Plane *)&v443.m_Buffer[128] = v454;
			//         *(_QWORD *)&v417.x = v133;
			//         v417.z = v134;
			//         v417 = *UnityEngine::Vector3::op_Multiply(&v419, &v417, v426.y, 0LL);
			//         *(_QWORD *)&v418.x = v124;
			//         v418.z = v125;
			//         v151 = UnityEngine::Vector3::op_Subtraction(&v419, &v418, &v417, v150);
			//         v152 = *(_QWORD *)&v151.x;
			//         v153 = v151.z;
			//         v453 = 0LL;
			//         *(_QWORD *)&v417.x = v152;
			//         v417.z = v153;
			//         *(_QWORD *)&v418.x = v133;
			//         v418.z = v134;
			//         UnityEngine::Plane::Plane(&v453, &v418, &v417, 0LL);
			//         *(Plane *)&v443.m_Buffer[144] = v453;
			//         *(_QWORD *)&v417.x = v128.m128i_i64[0];
			//         v417.z = v136;
			//         v154 = UnityEngine::Vector3::op_UnaryNegation(&v419, &v417, 0LL);
			//         v155 = *(_QWORD *)&v154.x;
			//         v156 = v154.z;
			//         *(_QWORD *)&v417.x = v128.m128i_i64[0];
			//         v417.z = v136;
			//         v417 = *UnityEngine::Vector3::op_Multiply(&v419, &v417, v426.x, 0LL);
			//         *(_QWORD *)&v418.x = v124;
			//         v418.z = v125;
			//         v157 = UnityEngine::Vector3::op_Addition(&v419, &v418, &v417, 0LL);
			//         v158 = *(_QWORD *)&v157.x;
			//         *(float *)&v157 = v157.z;
			//         v457 = 0LL;
			//         *(_QWORD *)&v417.x = v158;
			//         LODWORD(v417.z) = (_DWORD)v157;
			//         *(_QWORD *)&v418.x = v155;
			//         v418.z = v156;
			//         UnityEngine::Plane::Plane(&v457, &v418, &v417, 0LL);
			//         *(Plane *)&v443.m_Buffer[160] = v457;
			//         *(_QWORD *)&v417.x = v128.m128i_i64[0];
			//         v417.z = v136;
			//         v417 = *UnityEngine::Vector3::op_Multiply(&v419, &v417, v426.x, 0LL);
			//         *(_QWORD *)&v418.x = v124;
			//         v418.z = v125;
			//         v160 = UnityEngine::Vector3::op_Subtraction(&v419, &v418, &v417, v159);
			//         v161 = *(_QWORD *)&v160.x;
			//         v162 = v160.z;
			//         v456 = 0LL;
			//         *(_QWORD *)&v417.x = v161;
			//         v417.z = v162;
			//         *(_QWORD *)&v418.x = v128.m128i_i64[0];
			//         v418.z = v136;
			//         UnityEngine::Plane::Plane(&v456, &v418, &v417, 0LL);
			//         *(Plane *)&v443.m_Buffer[176] = v456;
			//         v98 = *(float *)&v437;
			//         v87 = (uint32_t *)v442;
			//       }
			//       *(_OWORD *)&v447.m00 = *(_OWORD *)&hgCamera.fields.lodCrossFadeConfig.cameraPosition.x;
			//       *(_OWORD *)&v447.m01 = *(_OWORD *)&hgCamera.fields.lodCrossFadeConfig.c0.y;
			//       *(_OWORD *)&v447.m02 = *(_OWORD *)&hgCamera.fields.lodCrossFadeConfig.c1.z;
			//       LODWORD(v447.m13) = HIDWORD(*(_QWORD *)&hgCamera.fields.lodCrossFadeConfig.maxProjFactorSquared1);
			//       *(_QWORD *)&v447.m21 = v97;
			//       v447.m02 = v98;
			//       *(_QWORD *)&v447.m30 = v97;
			//       v447.m11 = v98;
			//       *(_QWORD *)&v447.m00 = v97;
			//       v447.m20 = v98;
			//       v447.m03 = v86 * v86;
			//       v447.m32 = v86 * v86;
			//       LOBYTE(v447.m13) = 0;
			//       HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetECSRenderFlags(
			//         this,
			//         light,
			//         0,
			//         &objectFlags,
			//         &objectFlagsMask,
			//         &renderFlags,
			//         &renderFlagsMask,
			//         0LL);
			//       v165 = hgCamera.fields.camera;
			//       if ( !v165 )
			//         sub_1802DC2C8(v164, v163);
			//       v166 = (__int64 (__fastcall *)(Camera *))qword_18D8F41E8;
			//       if ( !qword_18D8F41E8 )
			//       {
			//         v166 = (__int64 (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_cullingMask()");
			//         qword_18D8F41E8 = (__int64)v166;
			//       }
			//       v167 = v166(v165);
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGCamera);
			//       v168 = v167 & ~TypeInfo::HG::Rendering::Runtime::HGCamera.static_fields.COMPOUND_CHARACTER_LAYER_MASK;
			//       v169 = v443;
			//       v170 = hgCamera.fields.camera;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       SceneCullingMaskFromCamera = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(v170, 0LL);
			//       m_punctualLightShadowScreenSizeMinSquared = this.fields.m_punctualLightShadowScreenSizeMinSquared;
			//       v429 = (RectInt)v169;
			//       v173 = UnityEngine::HyperGryph::HGCullingSystem::AddCullViewByPlanes(
			//                (NativeArray_1_UnityEngine_Plane_ *)&v429,
			//                0,
			//                SceneCullingMaskFromCamera,
			//                v168,
			//                objectFlags,
			//                objectFlagsMask,
			//                (LODCrossFadeConfig *)&v447,
			//                m_punctualLightShadowScreenSizeMinSquared,
			//                CameraType__Enum_Shadow,
			//                0LL);
			//       v174 = (void (*)(void))qword_18D92FA60;
			//       if ( !qword_18D92FA60 )
			//       {
			//         v174 = (void (*)(void))sub_180017470("UnityEngine.HyperGryph.HGCullingSystem::DispatchBatchCullingJobs()");
			//         qword_18D92FA60 = (__int64)v174;
			//       }
			//       v174();
			//       v175 = renderFlagsMask;
			//       v176 = renderFlags;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//       LOWORD(globalKeywords) = 0;
			//       RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                        v173,
			//                        (HGRenderFlags__Enum)(v175 | 0x100),
			//                        (HGRenderFlags__Enum)(v176 | 0x100),
			//                        HGShaderLightMode__Enum_ShadowCaster,
			//                        globalKeywords,
			//                        m_Ptr,
			//                        0,
			//                        0,
			//                        0xFFFFFFFF,
			//                        0,
			//                        0,
			//                        0LL);
			//       v178 = UnityEngine::HyperGryph::HGGrassRender::CreateRendererList(
			//                v173,
			//                (HGRenderFlags__Enum)(renderFlagsMask | 0x100),
			//                (HGRenderFlags__Enum)(renderFlags | 0x100),
			//                HGShaderLightMode__Enum_ShadowCaster,
			//                m_Ptr,
			//                0,
			//                0LL);
			//       *v87 = RendererList;
			//       v180 = entity;
			//       *(_DWORD *)entity.globalIndex = v178;
			//     }
			//     if ( !v433 )
			//       sub_1802DC2C8(v180, v179);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//       (TextureHandle *)&v455,
			//       &v507,
			//       (TextureHandle *)&v433[13].monitor,
			//       DepthAccess__Enum_Write,
			//       RenderBufferLoadAction__Enum_Load,
			//       RenderBufferStoreAction__Enum_Store,
			//       0.0,
			//       0,
			//       0,
			//       0LL);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//       &v507,
			//       (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_punctualLightShadowMapRenderFunc,
			//       0LL,
			//       0,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPassData>);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v507, 0, 0LL);
			//   }
			//   catch ( Il2CppExceptionWrapper *v524 )
			//   {
			//     *(Il2CppExceptionWrapper *)&v428.m_XMin = (Il2CppExceptionWrapper)v524.ex;
			//     sub_180222690(&v428);
			//     z_low = LODWORD(v451);
			//     v436 = v451;
			//     v14 = v450;
			//     v441 = v450;
			//     size = v430;
			//     v9 = this;
			//     goto LABEL_75;
			//   }
			//   sub_180222690(&v428);
			//   v14 = v441;
			//   size = v430;
			// LABEL_75:
			//   for ( j = HGRenderFlags__Enum_None; ; ++j )
			//   {
			//     renderFlags = j;
			//     camera = (unsigned int)(v9.fields.m_dynamicMovablePunctualShadowCasterCount
			//                           + v9.fields.m_dynamicEnvPunctualShadowCasterCount);
			//     if ( (int)j >= (int)camera )
			//       break;
			//     m_targetDynamicPunctualLights = v9.fields.m_targetDynamicPunctualLights;
			//     if ( !m_targetDynamicPunctualLights )
			//       goto LABEL_245;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//     v186 = (LightCaster *)sub_18037A2E0(m_targetDynamicPunctualLights, (int)j);
			//     if ( HG::Rendering::Runtime::LightCaster::IsLightVaild(v186, 0LL) )
			//     {
			//       m_punctualShadowAtlasBaseTileSize = v9.fields.m_punctualShadowAtlasBaseTileSize;
			//       camera = j & 3;
			//       v188 = j;
			//       if ( (int)j < (int)HGRenderFlags__Enum_None )
			//       {
			//         v188 = j + 3;
			//         camera = (unsigned int)(camera - 4);
			//       }
			//       z_low = (unsigned int)(camera * v9.fields.m_punctualShadowAtlasBaseTileSize);
			//       v445.m_XMin = m_punctualShadowAtlasBaseTileSize * ((v188 >> 2) + 4);
			//       v445.m_YMin = z_low;
			//       v445.m_Width = m_punctualShadowAtlasBaseTileSize;
			//       v445.m_Height = m_punctualShadowAtlasBaseTileSize;
			//       v189 = v9.fields.m_targetDynamicPunctualLights;
			//       if ( !v189 )
			//         goto LABEL_245;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::LightCaster);
			//       v190 = (LightCaster *)sub_18037A2E0(v189, (int)j);
			//       HGSharedLightData = HG::Rendering::Runtime::LightCaster::GetHGSharedLightData(v190, 0LL);
			//       if ( UnityEngine::HGSharedLightData::get_type_Injected(&HGSharedLightData, 0LL) )
			//       {
			//         if ( UnityEngine::HGSharedLightData::get_type_Injected(&HGSharedLightData, 0LL) != LightType__Enum_Point )
			//           goto LABEL_16;
			//         v191 = UnityEngine::HGSharedLightData::get_worldPosition(&v534, &HGSharedLightData, 0LL);
			//         v192 = *(_QWORD *)&v191.x;
			//         v193 = v191.z;
			//         camera = (unsigned __int64)v9.fields.m_targetDynamicPunctualLights;
			//         if ( !camera )
			//           goto LABEL_245;
			//         v194 = *(_DWORD *)(sub_18037A2E0(camera, (int)j) + 8);
			//         v195 = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&HGSharedLightData, 0LL);
			//         v196 = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&HGSharedLightData, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//         *(_QWORD *)&v462.x = v192;
			//         v462.z = v193;
			//         HG::Rendering::Runtime::HGShadowUtils::ExtractPointLightMatrix(
			//           &v446,
			//           &v462,
			//           v194,
			//           v195,
			//           v196,
			//           2.0,
			//           &v528,
			//           &v529,
			//           &v530,
			//           0LL);
			//       }
			//       else
			//       {
			//         v197 = UnityEngine::HGSharedLightData::get_localToWorldMatrix(&v446, &HGSharedLightData, 0LL);
			//         v198 = *(_OWORD *)&v197.m00;
			//         v199 = *(_OWORD *)&v197.m01;
			//         v200 = *(_OWORD *)&v197.m02;
			//         v201 = *(_OWORD *)&v197.m03;
			//         v202 = UnityEngine::HGSharedLightData::get_spotAngle_Injected(&HGSharedLightData, 0LL);
			//         v203 = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&HGSharedLightData, 0LL);
			//         v204 = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&HGSharedLightData, 0LL);
			//         v205 = UnityEngine::HGSharedLightData::get_shadowGuardAngle_Injected(&HGSharedLightData, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//         *(_OWORD *)&v435.m00 = v198;
			//         *(_OWORD *)&v435.m01 = v199;
			//         *(_OWORD *)&v435.m02 = v200;
			//         *(_OWORD *)&v435.m03 = v201;
			//         HG::Rendering::Runtime::HGShadowUtils::ExtractSpotLightMatrix(
			//           &v446,
			//           &v435,
			//           v202,
			//           v203,
			//           v204,
			//           v205,
			//           &v528,
			//           &v529,
			//           &v530,
			//           0LL);
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
			//       v206 = *(_OWORD *)&v528.m00;
			//       v435 = v528;
			//       v207 = *(_OWORD *)&v528.m01;
			//       v208 = *(_OWORD *)&v528.m02;
			//       v209 = *(_OWORD *)&v528.m03;
			//       v210 = *(_OWORD *)&v529.m00;
			//       v444 = v529;
			//       v211 = *(__m128 *)&v529.m01;
			//       v212 = *(_OWORD *)&v529.m02;
			//       v213 = *(_OWORD *)&v529.m03;
			//       v214 = HG::Rendering::Runtime::HGShadowUtils::GetShadowTransform(&v446, &v444, &v435, 0LL);
			//       v215 = *(_OWORD *)&v214.m00;
			//       v517 = *(_OWORD *)&v214.m01;
			//       v515 = *(_OWORD *)&v214.m02;
			//       v429 = *(RectInt *)&v214.m03;
			//       camera = (unsigned __int64)v9.fields.m_punctualLightWorldToShadowMatrices;
			//       if ( !camera )
			//         goto LABEL_245;
			//       *(_OWORD *)&v435.m00 = v215;
			//       *(_OWORD *)&v435.m01 = *(_OWORD *)&v214.m01;
			//       *(_OWORD *)&v435.m02 = *(_OWORD *)&v214.m02;
			//       *(_OWORD *)&v435.m03 = *(_OWORD *)&v214.m03;
			//       sub_180077420(camera, (int)(j + size), &v435);
			//       v216 = v9.fields.m_punctualLightShadowParams;
			//       v217 = UnityEngine::HGSharedLightData::get_shadowNormalBias_Injected(&HGSharedLightData, 0LL);
			//       *(_OWORD *)&v435.m00 = v210;
			//       *(__m128 *)&v435.m01 = v211;
			//       *(_OWORD *)&v435.m02 = v212;
			//       *(_OWORD *)&v435.m03 = v213;
			//       v218 = HG::Rendering::Runtime::HGShadowUtils::GetShadowBias(
			//                &v554,
			//                &v435,
			//                (float)m_punctualShadowAtlasBaseTileSize,
			//                0.0,
			//                v217,
			//                HGShadowSampleMode__Enum_PCF_3x3,
			//                0LL);
			//       if ( !v216 )
			//         goto LABEL_245;
			//       *(Vector4 *)&v458.m00 = *v218;
			//       sub_18004D910(v216, (int)(j + size), &v458);
			//       v219 = v9.fields.m_punctualLightShadowParams;
			//       if ( !v219 )
			//         goto LABEL_245;
			//       *(_QWORD *)&v463.x = v441;
			//       v463.z = v436;
			//       PunctualLightShadowStrength = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetPunctualLightShadowStrength(
			//                                       v9,
			//                                       HGSharedLightData,
			//                                       &v463,
			//                                       0LL);
			//       *(float *)(sub_18003EB40(v219, (int)(j + size)) + 12) = PunctualLightShadowStrength;
			//       entity = (Entity_1)v9.fields.m_punctualLightShadowParams2;
			//       v221 = UnityEngine::RectInt::get_xMin(&v445, 0LL);
			//       v222 = v9.fields.m_punctualShadowAtlasSize.m_X;
			//       v223 = UnityEngine::RectInt::get_yMin(&v445, 0LL);
			//       v224 = v448.fields.m_punctualShadowAtlasSize.m_Y;
			//       v225 = UnityEngine::RectInt::get_xMax(&v445, 0LL);
			//       v226 = this.fields.m_punctualShadowAtlasSize.m_X;
			//       yMax = UnityEngine::RectInt::get_yMax(&v445, 0LL);
			//       v228 = (float)yMax / (float)v448.fields.m_punctualShadowAtlasSize.m_Y;
			//       v440.m_Normal.x = (float)v221 / (float)v222;
			//       v440.m_Normal.y = (float)v223 / (float)v224;
			//       v440.m_Normal.z = (float)v225 / (float)v226;
			//       v440.m_Distance = v228;
			//       camera = (unsigned __int64)entity;
			//       if ( !*(_QWORD *)&entity )
			//         goto LABEL_245;
			//       j = renderFlags;
			//       *(Plane *)&v458.m00 = v440;
			//       ((void (__fastcall *)(_QWORD, _QWORD, _QWORD))sub_18004D910)(entity, (int)(renderFlags + v430), &v458);
			//       v229 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//                (Int32Enum__Enum)0x7Du,
			//                MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//       if ( !renderGraph )
			//         goto LABEL_245;
			//       HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//         (HGRenderGraphBuilder *)&v458,
			//         renderGraph,
			//         (String *)"Render Punctual Light ShadowMaps",
			//         &v432,
			//         v229,
			//         1,
			//         ProfilingHGPass__Enum_Shadow,
			//         MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPassData>);
			//       *(_OWORD *)&v508.m_RenderPass = *(_OWORD *)&v458.m00;
			//       *(_OWORD *)&v508.m_RenderGraph = *(_OWORD *)&v458.m01;
			//       *(_QWORD *)&v434.m_Normal.x = 0LL;
			//       *(_QWORD *)&v434.m_Normal.z = &v508;
			//       try
			//       {
			//         v232 = v432;
			//         if ( !v432 )
			//           sub_1802DC2C8(v231, v230);
			//         *(Object *)((char *)v432 + 60) = *(Object *)&v530.m00;
			//         *(Object *)((char *)v232 + 76) = *(Object *)&v530.m01;
			//         *(Object *)((char *)v232 + 92) = *(Object *)&v530.m02;
			//         *(Object *)((char *)v232 + 108) = *(Object *)&v530.m03;
			//         v233 = v432;
			//         if ( !v432 )
			//           sub_1802DC2C8(v231, v230);
			//         *(_OWORD *)((char *)&v432[7].monitor + 4) = v206;
			//         *(_OWORD *)((char *)&v233[8].monitor + 4) = v207;
			//         *(_OWORD *)((char *)&v233[9].monitor + 4) = v208;
			//         *(_OWORD *)((char *)&v233[10].monitor + 4) = v209;
			//         if ( !v432 )
			//           sub_1802DC2C8(v231, v230);
			//         *(RectInt *)((char *)&v432[2].monitor + 4) = v445;
			//         v234 = v432;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//         v236 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields;
			//         if ( !v234 )
			//           sub_1802DC2C8(v236, v235);
			//         v234[15].klass = (Object__Class *)v236.s_clearShadowMaterial;
			//         if ( dword_18D8E43F8 )
			//         {
			//           v237 = (((unsigned __int64)&v234[15] >> 12) & 0x1FFFFF) >> 6;
			//           _m_prefetchw(&qword_18D6405E0[v237 + 36190]);
			//           do
			//             v238 = qword_18D6405E0[v237 + 36190];
			//           while ( v238 != _InterlockedCompareExchange64(
			//                             &qword_18D6405E0[v237 + 36190],
			//                             v238 | (1LL << (((unsigned __int64)&v234[15] >> 12) & 0x3F)),
			//                             v238) );
			//         }
			//         v239 = v432;
			//         v9 = this;
			//         v242 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//                   &v553,
			//                   renderGraph,
			//                   this.fields.m_cachedPunctualLightShadowAtlas,
			//                   0LL);
			//         if ( !v239 )
			//           sub_1802DC2C8(v241, v240);
			//         *(TextureHandle *)&v239[13].monitor = v242;
			//         v243 = v432;
			//         v246 = UnityEngine::HGSharedLightData::get_shadowBias_Injected(&HGSharedLightData, 0LL);
			//         if ( !v243 )
			//           sub_1802DC2C8(v245, v244);
			//         *(float *)&v243[2].monitor = v246;
			//         v247 = HGSharedLightData;
			//         v248 = renderGraph.fields.m_RenderGraphContext;
			//         if ( !v248 )
			//           sub_1802DC2C8(v245, v244);
			//         v249.m_Ptr = v248.fields.renderContext.m_Ptr;
			//         *(_OWORD *)&v435.m00 = v206;
			//         *(_OWORD *)&v435.m01 = v207;
			//         *(_OWORD *)&v435.m02 = v208;
			//         *(_OWORD *)&v435.m03 = v209;
			//         *(_OWORD *)&v444.m00 = v210;
			//         *(__m128 *)&v444.m01 = v211;
			//         *(_OWORD *)&v444.m02 = v212;
			//         *(_OWORD *)&v444.m03 = v213;
			//         v250 = UnityEngine::Matrix4x4::op_Multiply(&v446, &v444, &v435, 0LL);
			//         if ( !v432 )
			//           sub_1802DC2C8(0LL, v251);
			//         v435 = *v250;
			//         v252 = hgCamera;
			//         HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PrepareRendererList(
			//           this,
			//           v247,
			//           hgCamera,
			//           v249,
			//           &v435,
			//           1,
			//           (RendererList *)&v432[12].monitor,
			//           0LL);
			//         v255 = renderGraph.fields.m_RenderGraphContext;
			//         if ( !v255 )
			//           sub_1802DC2C8(v254, v253);
			//         v256 = v255.fields.renderContext.m_Ptr;
			//         if ( !v432 )
			//           sub_1802DC2C8(v254, v253);
			//         v257 = (uint32_t *)&v432[11].monitor + 1;
			//         entity = (Entity_1)((char *)&v432[11].monitor + 4);
			//         v258 = (uint32_t *)&v432[12];
			//         v442 = v432 + 12;
			//         *(_OWORD *)&v446.m00 = v206;
			//         *(_OWORD *)&v446.m01 = v207;
			//         *(_OWORD *)&v446.m02 = v208;
			//         *(_OWORD *)&v446.m03 = v209;
			//         light = HGSharedLightData;
			//         if ( !byte_18D919EA2 )
			//         {
			//           sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//           sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//           sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//           sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
			//           sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           byte_18D919EA2 = 1;
			//         }
			//         v428 = 0LL;
			//         *(_QWORD *)&v458.m00 = 0LL;
			//         v458.m20 = 0.0;
			//         memset(&v444, 0, 56);
			//         *(float *)&v437 = 0.0;
			//         v438 = HGObjectFlags__Enum_None;
			//         renderFlagsMask = HGRenderFlags__Enum_None;
			//         objectFlags = HGObjectFlags__Enum_None;
			//         if ( IFix::WrappersManagerImpl::IsPatched(1851, 0LL) )
			//         {
			//           v351 = IFix::WrappersManagerImpl::GetPatch(1851, 0LL);
			//           if ( !v351 )
			//             sub_1802DC2C8(v353, v352);
			//           *(_OWORD *)&v446.m00 = v206;
			//           *(_OWORD *)&v446.m01 = v207;
			//           *(_OWORD *)&v446.m02 = v208;
			//           *(_OWORD *)&v446.m03 = v209;
			//           *(_OWORD *)&v435.m00 = v215;
			//           *(_OWORD *)&v435.m01 = v517;
			//           *(_OWORD *)&v435.m02 = v515;
			//           *(RectInt *)&v435.m03 = v429;
			//           IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_717(
			//             v351,
			//             (Object *)this,
			//             light,
			//             (Object *)hgCamera,
			//             (ScriptableRenderContext)v256,
			//             &v435,
			//             &v446,
			//             _mm_shuffle_ps(v211, v211, 85).m128_f32[0],
			//             1,
			//             v257,
			//             v258,
			//             0LL);
			//         }
			//         else
			//         {
			//           v259 = (unsigned __int8 (__fastcall *)(HGSharedLightData *))qword_18D92E828;
			//           if ( !qword_18D92E828 )
			//           {
			//             v259 = (unsigned __int8 (__fastcall *)(HGSharedLightData *))sub_180017470(
			//                                                                           "UnityEngine.HGSharedLightData::get_enableOBBCu"
			//                                                                           "llingBox_Injected(UnityEngine.HGSharedLightData&)");
			//             qword_18D92E828 = (__int64)v259;
			//           }
			//           if ( v259(&light) )
			//             Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::EntityCommandBufferV2::VirtualEntityMap>::NativeArray(
			//               (NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ *)&v428,
			//               12,
			//               Allocator__Enum_Temp,
			//               NativeArrayOptions__Enum_ClearMemory,
			//               MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
			//           else
			//             Unity::Collections::NativeArray<UnityEngine::HyperGryph::ECS::EntityCommandBufferV2::VirtualEntityMap>::NativeArray(
			//               (NativeArray_1_UnityEngine_HyperGryph_ECS_EntityCommandBufferV2_VirtualEntityMap_ *)&v428,
			//               6,
			//               Allocator__Enum_Temp,
			//               NativeArrayOptions__Enum_ClearMemory,
			//               MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//           v260 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields;
			//           *(_OWORD *)&v435.m00 = v215;
			//           *(_OWORD *)&v435.m01 = v517;
			//           *(_OWORD *)&v435.m02 = v515;
			//           *(RectInt *)&v435.m03 = v429;
			//           UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v435, v260.s_cullPlanes, 0LL);
			//           v261 = UnityEngine::Matrix4x4::get_inverse(&v435, &v446, 0LL);
			//           *(_OWORD *)&v446.m00 = *(_OWORD *)&v261.m00;
			//           *(_OWORD *)&v446.m01 = *(_OWORD *)&v261.m01;
			//           v262 = *(__m128 *)&v261.m02;
			//           *(_OWORD *)&v446.m03 = *(_OWORD *)&v261.m03;
			//           *(_OWORD *)&v446.m00 = *(_OWORD *)&v261.m00;
			//           *(_OWORD *)&v446.m01 = *(_OWORD *)&v261.m01;
			//           *(_OWORD *)&v446.m03 = *(_OWORD *)&v261.m03;
			//           *(_OWORD *)&v446.m01 = *(_OWORD *)&v261.m01;
			//           *(_OWORD *)&v446.m03 = *(_OWORD *)&v261.m03;
			//           v263 = _mm_xor_ps(v262, (__m128)0x80000000);
			//           v264 = _mm_xor_ps((__m128)LODWORD(v261.m12), (__m128)0x80000000);
			//           v265 = -v261.m22;
			//           v266 = UnityEngine::HGSharedLightData::get_worldPosition(&v533, &light, 0LL);
			//           v267 = *(_QWORD *)&v266.x;
			//           v268 = v266.z;
			//           v269 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_cullPlanes;
			//           v270 = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&light, 0LL);
			//           *(_QWORD *)&v465.x = _mm_unpacklo_ps(v263, v264).m128_u64[0];
			//           v465.z = v265;
			//           v466 = *UnityEngine::Vector3::op_Multiply(&v532, &v465, v270, 0LL);
			//           *(_QWORD *)&v467.x = v267;
			//           v467.z = v268;
			//           v271 = UnityEngine::Vector3::op_Addition(&v531, &v467, &v466, 0LL);
			//           v272 = *(_QWORD *)&v271.x;
			//           *(float *)&v271 = v271.z;
			//           v518 = 0LL;
			//           *(_QWORD *)&v468.x = v272;
			//           LODWORD(v468.z) = (_DWORD)v271;
			//           *(_QWORD *)&v469.x = _mm_unpacklo_ps(v263, v264).m128_u64[0];
			//           v469.z = v265;
			//           UnityEngine::Plane::Plane(&v518, &v469, &v468, 0LL);
			//           if ( !v269 )
			//             sub_1802DC2C8(v274, v273);
			//           if ( v269.max_length.size <= 4u )
			//             sub_180070260(v274, v273, v275, v276);
			//           v269.vector[4] = v518;
			//           v277 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_cullPlanes;
			//           *(_QWORD *)&v464.x = _mm_unpacklo_ps(v263, v264).m128_u64[0];
			//           v464.z = v265;
			//           v278 = UnityEngine::Vector3::op_UnaryNegation(&v552, &v464, 0LL);
			//           v279 = *(_QWORD *)&v278.x;
			//           v280 = v278.z;
			//           v281 = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&light, 0LL);
			//           *(_QWORD *)&v471.x = _mm_unpacklo_ps(v263, v264).m128_u64[0];
			//           v471.z = v265;
			//           v472 = *UnityEngine::Vector3::op_Multiply(&v551, &v471, v281, 0LL);
			//           *(_QWORD *)&v473.x = v267;
			//           v473.z = v268;
			//           v282 = UnityEngine::Vector3::op_Addition(&v550, &v473, &v472, 0LL);
			//           v283 = *(_QWORD *)&v282.x;
			//           *(float *)&v282 = v282.z;
			//           v519 = 0LL;
			//           *(_QWORD *)&v474.x = v283;
			//           LODWORD(v474.z) = (_DWORD)v282;
			//           *(_QWORD *)&v475.x = v279;
			//           v475.z = v280;
			//           UnityEngine::Plane::Plane(&v519, &v475, &v474, 0LL);
			//           if ( !v277 )
			//             sub_1802DC2C8(v285, v284);
			//           if ( v277.max_length.size <= 5u )
			//             sub_180070260(v285, v284, v286, v287);
			//           v277.vector[5] = v519;
			//           for ( k = 0; k < 6; ++k )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//             v290 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_cullPlanes;
			//             if ( !v290 )
			//               sub_1802DC2C8(0LL, v289);
			//             sub_180037190(v290, &v455, k);
			//             *(Vector4 *)(*(_QWORD *)&v428.m_XMin + 16LL * k) = v455;
			//           }
			//           v291 = (unsigned __int8 (__fastcall *)(HGSharedLightData *))qword_18D92E828;
			//           if ( !qword_18D92E828 )
			//           {
			//             v291 = (unsigned __int8 (__fastcall *)(HGSharedLightData *))sub_180017470(
			//                                                                           "UnityEngine.HGSharedLightData::get_enableOBBCu"
			//                                                                           "llingBox_Injected(UnityEngine.HGSharedLightData&)");
			//             qword_18D92E828 = (__int64)v291;
			//           }
			//           if ( v291(&light) )
			//           {
			//             *(_QWORD *)&v418.x = 0LL;
			//             v418.z = 0.0;
			//             v292 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))qword_18D92E830;
			//             if ( !qword_18D92E830 )
			//             {
			//               v292 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))sub_180017470(
			//                                                                             "UnityEngine.HGSharedLightData::get_cullingBo"
			//                                                                             "xRelativePosition_Injected(UnityEngine.HGSha"
			//                                                                             "redLightData&,UnityEngine.Vector3&)");
			//               qword_18D92E830 = (__int64)v292;
			//             }
			//             v292(&light, &v418);
			//             v476 = v418;
			//             *(_QWORD *)&v477.x = v267;
			//             v477.z = v268;
			//             v293 = UnityEngine::Vector3::op_Addition(&v549, &v477, &v476, 0LL);
			//             v294 = *(_QWORD *)&v293.x;
			//             v490 = *(_QWORD *)&v293.x;
			//             objectFlagsMask = LODWORD(v293.z);
			//             memset(&v426, 0, sizeof(v426));
			//             v295 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))qword_18D92E838;
			//             if ( !qword_18D92E838 )
			//             {
			//               v295 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))sub_180017470(
			//                                                                             "UnityEngine.HGSharedLightData::get_cullingBo"
			//                                                                             "xHalfExtents_Injected(UnityEngine.HGSharedLi"
			//                                                                             "ghtData&,UnityEngine.Vector3&)");
			//               qword_18D92E838 = (__int64)v295;
			//             }
			//             v295(&light, &v426);
			//             *(_QWORD *)&v417.x = 0LL;
			//             v417.z = 0.0;
			//             v296 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))qword_18D92E840;
			//             if ( !qword_18D92E840 )
			//             {
			//               v296 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))sub_180017470(
			//                                                                             "UnityEngine.HGSharedLightData::get_cullingBo"
			//                                                                             "xOrientation_Injected(UnityEngine.HGSharedLi"
			//                                                                             "ghtData&,UnityEngine.Vector3&)");
			//               qword_18D92E840 = (__int64)v296;
			//             }
			//             v296(&light, &v417);
			//             v478 = v417;
			//             v479 = *UnityEngine::Vector3::op_Multiply(&v545, &v478, 0.017453292, 0LL);
			//             *(_OWORD *)&v458.m00 = 0LL;
			//             v297 = (void (__fastcall *)(Vector3 *, Matrix4x4 *))qword_18D8F4C40;
			//             if ( !qword_18D8F4C40 )
			//             {
			//               v297 = (void (__fastcall *)(Vector3 *, Matrix4x4 *))sub_180017470(
			//                                                                     "UnityEngine.Quaternion::Internal_FromEulerRad_Inject"
			//                                                                     "ed(UnityEngine.Vector3&,UnityEngine.Quaternion&)");
			//               qword_18D8F4C40 = (__int64)v297;
			//             }
			//             v297(&v479, &v458);
			//             v480 = *UnityEngine::Vector3::get_fwd(&v535, 0LL);
			//             v298 = *(RectInt *)&v458.m00;
			//             v429 = *(RectInt *)&v458.m00;
			//             v299 = UnityEngine::Quaternion::op_Multiply(&v536, (Quaternion *)&v429, &v480, 0LL);
			//             v300 = *(_QWORD *)&v299.x;
			//             v301 = v299.z;
			//             v481 = *UnityEngine::Vector3::get_up(&v537, 0LL);
			//             v429 = v298;
			//             v302 = UnityEngine::Quaternion::op_Multiply(&v538, (Quaternion *)&v429, &v481, 0LL);
			//             v303 = *(_QWORD *)&v302.x;
			//             v304 = v302.z;
			//             v470 = *UnityEngine::Vector3::get_right(&v539, 0LL);
			//             v429 = v298;
			//             v305 = UnityEngine::Quaternion::op_Multiply(&v540, (Quaternion *)&v429, &v470, 0LL);
			//             *(_QWORD *)&v298.m_XMin = *(_QWORD *)&v305.x;
			//             v306 = v305.z;
			//             *(_QWORD *)&v483.x = v300;
			//             v483.z = v301;
			//             v307 = UnityEngine::Vector3::op_UnaryNegation(&v541, &v483, 0LL);
			//             v308 = *(_QWORD *)&v307.x;
			//             v309 = v307.z;
			//             *(_QWORD *)&v484.x = v300;
			//             v484.z = v301;
			//             v485 = *UnityEngine::Vector3::op_Multiply(&v542, &v484, v426.z, 0LL);
			//             *(_QWORD *)&v486.x = v294;
			//             LODWORD(v486.z) = objectFlagsMask;
			//             v310 = UnityEngine::Vector3::op_Addition(&v543, &v486, &v485, 0LL);
			//             v311 = *(_QWORD *)&v310.x;
			//             *(float *)&v310 = v310.z;
			//             v520 = 0LL;
			//             *(_QWORD *)&v487.x = v311;
			//             LODWORD(v487.z) = (_DWORD)v310;
			//             *(_QWORD *)&v488.x = v308;
			//             v488.z = v309;
			//             UnityEngine::Plane::Plane(&v520, &v488, &v487, 0LL);
			//             *(Plane *)(*(_QWORD *)&v428.m_XMin + 96LL) = v520;
			//             *(_QWORD *)&v489.x = v300;
			//             v489.z = v301;
			//             v312 = UnityEngine::Vector3::op_Multiply(&v544, &v489, v426.z, 0LL);
			//             v510 = *(_QWORD *)&v312.x;
			//             v313 = *(float *)&objectFlagsMask;
			//             v314 = *(float *)&objectFlagsMask;
			//             v315 = *(float *)&objectFlagsMask - v312.z;
			//             v316 = (__m128)HIDWORD(v490);
			//             v317 = (__m128)HIDWORD(v490);
			//             v317.m128_f32[0] = *((float *)&v490 + 1) - *((float *)&v510 + 1);
			//             v318 = (__m128)(unsigned int)v490;
			//             v319 = (__m128)(unsigned int)v490;
			//             v319.m128_f32[0] = *(float *)&v490 - *(float *)&v510;
			//             v521 = 0LL;
			//             *(_QWORD *)&v509.x = _mm_unpacklo_ps(v319, v317).m128_u64[0];
			//             v509.z = v315;
			//             *(_QWORD *)&v506.x = v300;
			//             v506.z = v301;
			//             UnityEngine::Plane::Plane(&v521, &v506, &v509, 0LL);
			//             *(Plane *)(*(_QWORD *)&v428.m_XMin + 112LL) = v521;
			//             *(_QWORD *)&v460.x = v303;
			//             v460.z = v304;
			//             v320 = UnityEngine::Vector3::op_UnaryNegation(&v546, &v460, 0LL);
			//             v321 = *(_QWORD *)&v320.x;
			//             v322 = v320.z;
			//             *(_QWORD *)&v482.x = v303;
			//             v482.z = v304;
			//             v498 = *UnityEngine::Vector3::op_Multiply(&v547, &v482, v426.y, 0LL);
			//             *(_QWORD *)&v499.x = v294;
			//             v499.z = v313;
			//             v323 = UnityEngine::Vector3::op_Addition(&v548, &v499, &v498, 0LL);
			//             v319.m128_u64[0] = *(_QWORD *)&v323.x;
			//             *(float *)&v323 = v323.z;
			//             v522 = 0LL;
			//             *(_QWORD *)&v500.x = v319.m128_u64[0];
			//             LODWORD(v500.z) = (_DWORD)v323;
			//             *(_QWORD *)&v501.x = v321;
			//             v501.z = v322;
			//             UnityEngine::Plane::Plane(&v522, &v501, &v500, 0LL);
			//             *(Plane *)(*(_QWORD *)&v428.m_XMin + 128LL) = v522;
			//             *(_QWORD *)&v505.x = v303;
			//             v505.z = v304;
			//             v324 = UnityEngine::Vector3::op_Multiply(&v456.m_Normal, &v505, v426.y, 0LL);
			//             v497 = *(_QWORD *)&v324.x;
			//             v325 = v314 - v324.z;
			//             v326 = v316;
			//             v326.m128_f32[0] = v316.m128_f32[0] - *((float *)&v497 + 1);
			//             v327 = v318;
			//             v327.m128_f32[0] = v318.m128_f32[0] - *(float *)&v497;
			//             v523 = 0LL;
			//             *(_QWORD *)&v461.x = _mm_unpacklo_ps(v327, v326).m128_u64[0];
			//             v461.z = v325;
			//             *(_QWORD *)&v504.x = v303;
			//             v504.z = v304;
			//             UnityEngine::Plane::Plane(&v523, &v504, &v461, 0LL);
			//             *(Plane *)(*(_QWORD *)&v428.m_XMin + 144LL) = v523;
			//             *(_QWORD *)&v503.x = *(_QWORD *)&v298.m_XMin;
			//             v503.z = v306;
			//             v328 = UnityEngine::Vector3::op_UnaryNegation(&v457.m_Normal, &v503, 0LL);
			//             v329 = *(_QWORD *)&v328.x;
			//             v330 = v328.z;
			//             *(_QWORD *)&v502.x = *(_QWORD *)&v298.m_XMin;
			//             v502.z = v306;
			//             v459 = *UnityEngine::Vector3::op_Multiply(&v453.m_Normal, &v502, v426.x, 0LL);
			//             *(_QWORD *)&v491.x = v294;
			//             v491.z = v313;
			//             v331 = UnityEngine::Vector3::op_Addition(&v454.m_Normal, &v491, &v459, 0LL);
			//             v327.m128_u64[0] = *(_QWORD *)&v331.x;
			//             *(float *)&v331 = v331.z;
			//             v513 = 0LL;
			//             *(_QWORD *)&v492.x = v327.m128_u64[0];
			//             LODWORD(v492.z) = (_DWORD)v331;
			//             *(_QWORD *)&v493.x = v329;
			//             v493.z = v330;
			//             UnityEngine::Plane::Plane(&v513, &v493, &v492, 0LL);
			//             *(Plane *)(*(_QWORD *)&v428.m_XMin + 160LL) = v513;
			//             *(_QWORD *)&v494.x = *(_QWORD *)&v298.m_XMin;
			//             v494.z = v306;
			//             v332 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v443, &v494, v426.x, 0LL);
			//             v495 = *(_QWORD *)&v332.x;
			//             v333 = v314 - v332.z;
			//             v316.m128_f32[0] = v316.m128_f32[0] - *((float *)&v495 + 1);
			//             v318.m128_f32[0] = v318.m128_f32[0] - *(float *)&v495;
			//             v514 = 0LL;
			//             *(_QWORD *)&v496.x = _mm_unpacklo_ps(v318, v316).m128_u64[0];
			//             v496.z = v333;
			//             *(_QWORD *)&v419.x = *(_QWORD *)&v298.m_XMin;
			//             v419.z = v306;
			//             UnityEngine::Plane::Plane(&v514, &v419, &v496, 0LL);
			//             *(Plane *)(*(_QWORD *)&v428.m_XMin + 176LL) = v514;
			//             v252 = hgCamera;
			//           }
			//           *(_OWORD *)&v444.m00 = *(_OWORD *)&v252.fields.lodCrossFadeConfig.cameraPosition.x;
			//           *(_OWORD *)&v444.m01 = *(_OWORD *)&v252.fields.lodCrossFadeConfig.c0.y;
			//           *(_OWORD *)&v444.m02 = *(_OWORD *)&v252.fields.lodCrossFadeConfig.c1.z;
			//           *(_QWORD *)&v444.m03 = *(_QWORD *)&v252.fields.lodCrossFadeConfig.maxProjFactorSquared1;
			//           LOBYTE(v444.m13) = 0;
			//           HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetECSRenderFlags(
			//             this,
			//             light,
			//             1,
			//             &v437,
			//             &v438,
			//             &renderFlagsMask,
			//             (HGRenderFlags__Enum *)&objectFlags,
			//             0LL);
			//           v336 = v252.fields.camera;
			//           if ( !v336 )
			//             sub_1802DC2C8(v335, v334);
			//           v337 = (__int64 (__fastcall *)(Camera *))qword_18D8F41E8;
			//           if ( !qword_18D8F41E8 )
			//           {
			//             v337 = (__int64 (__fastcall *)(Camera *))sub_180017470("UnityEngine.Camera::get_cullingMask()");
			//             qword_18D8F41E8 = (__int64)v337;
			//           }
			//           v338 = v337(v336);
			//           v339 = v428;
			//           v340 = v252.fields.camera;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//           v341 = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(v340, 0LL);
			//           v342 = this.fields.m_punctualLightShadowScreenSizeMinSquared;
			//           v429 = v339;
			//           v343 = UnityEngine::HyperGryph::HGCullingSystem::AddCullViewByPlanes(
			//                    (NativeArray_1_UnityEngine_Plane_ *)&v429,
			//                    0,
			//                    v341,
			//                    v338,
			//                    v437,
			//                    v438,
			//                    (LODCrossFadeConfig *)&v444,
			//                    v342,
			//                    CameraType__Enum_Shadow,
			//                    0LL);
			//           v344 = (void (*)(void))qword_18D92FA60;
			//           if ( !qword_18D92FA60 )
			//           {
			//             v344 = (void (*)(void))sub_180017470("UnityEngine.HyperGryph.HGCullingSystem::DispatchBatchCullingJobs()");
			//             qword_18D92FA60 = (__int64)v344;
			//           }
			//           v344();
			//           v345 = objectFlags;
			//           v346 = renderFlagsMask;
			//           sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//           LOWORD(globalKeywordsa) = 0;
			//           v347 = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
			//                    v343,
			//                    (HGRenderFlags__Enum)(v345 | 0x100),
			//                    (HGRenderFlags__Enum)(v346 | 0x100),
			//                    HGShaderLightMode__Enum_ShadowCaster,
			//                    globalKeywordsa,
			//                    v256,
			//                    0,
			//                    0,
			//                    0xFFFFFFFF,
			//                    0,
			//                    0,
			//                    0LL);
			//           v348 = UnityEngine::HyperGryph::HGGrassRender::CreateRendererList(
			//                    v343,
			//                    (HGRenderFlags__Enum)(objectFlags | 0x100),
			//                    (HGRenderFlags__Enum)(renderFlagsMask | 0x100),
			//                    HGShaderLightMode__Enum_ShadowCaster,
			//                    v256,
			//                    0,
			//                    0LL);
			//           *(_DWORD *)entity.globalIndex = v347;
			//           v350 = v442;
			//           LODWORD(v442.klass) = v348;
			//           j = renderFlags;
			//         }
			//         if ( !v432 )
			//           sub_1802DC2C8(v350, v349);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
			//           (TextureHandle *)&v447,
			//           &v508,
			//           (TextureHandle *)&v432[13].monitor,
			//           DepthAccess__Enum_Write,
			//           RenderBufferLoadAction__Enum_Load,
			//           RenderBufferStoreAction__Enum_Store,
			//           0.0,
			//           0,
			//           0,
			//           0LL);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//           &v508,
			//           (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_punctualLightShadowMapRenderFunc,
			//           0LL,
			//           0,
			//           MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPassData>);
			//         HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v508, 0, 0LL);
			//       }
			//       catch ( Il2CppExceptionWrapper *v527 )
			//       {
			//         *(Il2CppExceptionWrapper *)&v434.m_Normal.x = (Il2CppExceptionWrapper)v527.ex;
			//         sub_180222690(&v434);
			//         v436 = v451;
			//         v14 = v450;
			//         v441 = v450;
			//         size = v430;
			//         v9 = this;
			//         j = renderFlags;
			//         continue;
			//       }
			//       sub_180222690(&v434);
			//       v14 = v441;
			//       size = v430;
			//     }
			//   }
			//   v354 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
			//            (Int32Enum__Enum)0x7Eu,
			//            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
			//   if ( !renderGraph )
			//     sub_1802DC2C8(v356, v355);
			//   HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
			//     (HGRenderGraphBuilder *)&v447,
			//     renderGraph,
			//     (String *)"Punctual Light ShadowMap Push Data",
			//     &v439,
			//     v354,
			//     1,
			//     ProfilingHGPass__Enum_Shadow,
			//     MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPushDataPassData>);
			//   *(_OWORD *)&v511.m_RenderPass = *(_OWORD *)&v447.m00;
			//   *(_OWORD *)&v511.m_RenderGraph = *(_OWORD *)&v447.m01;
			//   *(_QWORD *)&v440.m_Normal.x = 0LL;
			//   *(_QWORD *)&v440.m_Normal.z = &v511;
			//   try
			//   {
			//     for ( m = 0; m < size; ++m )
			//     {
			//       v516 = *UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager((EntityManager_1 *)&v447, 0LL);
			//       m_targetStaticPunctualLights = v9.fields.m_targetStaticPunctualLights;
			//       if ( !m_targetStaticPunctualLights )
			//         sub_1802DC2C8(0LL, v357);
			//       sub_180056B60(m_targetStaticPunctualLights, &entity, m);
			//       if ( UnityEngine::HyperGryph::ECS::EntityManager::HasEntity(&v516, entity, 0LL) )
			//       {
			//         v360 = v9.fields.m_targetStaticPunctualLights;
			//         if ( !v360 )
			//           sub_1802DC2C8(0LL, v359);
			//         sub_180056B60(v360, &v442, m);
			//         v449 = v442;
			//         v363 = v9.fields.m_punctualLightShadowParams;
			//         if ( !v363 )
			//           sub_1802DC2C8(v362, v361);
			//         *(_QWORD *)&v419.x = v14;
			//         v419.z = v436;
			//         v364 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetPunctualLightShadowStrength(
			//                  v9,
			//                  (HGSharedLightData)v449,
			//                  &v419,
			//                  0LL);
			//         *(float *)(sub_18003EB40(v363, m) + 12) = v364;
			//       }
			//       v14 = v441;
			//     }
			//     v366 = v439;
			//     v369 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
			//               (TextureHandle *)&v447,
			//               renderGraph,
			//               v9.fields.m_cachedPunctualLightShadowAtlas,
			//               0LL);
			//     if ( !v366 )
			//       sub_1802DC2C8(v368, v367);
			//     v366[1] = (Object)v369;
			//     v370 = v439;
			//     if ( !v439 )
			//       sub_1802DC2C8(v368, 0LL);
			//     v439[2].klass = (Object__Class *)v9.fields.m_punctualLightWorldToShadowMatrices;
			//     v371 = dword_18D8E43F8;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v372 = ((unsigned __int64)&v370[2] >> 12) & 0x1FFFFF;
			//       v373 = (unsigned __int64)v372 >> 6;
			//       v374 = v372 & 0x3F;
			//       _m_prefetchw(&qword_18D6405E0[v373 + 36190]);
			//       do
			//         v375 = qword_18D6405E0[v373 + 36190];
			//       while ( v375 != _InterlockedCompareExchange64(&qword_18D6405E0[v373 + 36190], v375 | (1LL << v374), v375) );
			//       v371 = dword_18D8E43F8;
			//     }
			//     v376 = v439;
			//     v377 = (MonitorData *)v9.fields.m_punctualLightShadowParams;
			//     if ( !v439 )
			//       sub_1802DC2C8(v377, 0LL);
			//     v439[2].monitor = v377;
			//     if ( v371 )
			//     {
			//       v378 = ((unsigned __int64)&v376[2].monitor >> 12) & 0x1FFFFF;
			//       v379 = (unsigned __int64)v378 >> 6;
			//       v380 = v378 & 0x3F;
			//       _m_prefetchw(&qword_18D6405E0[v379 + 36190]);
			//       do
			//         v381 = qword_18D6405E0[v379 + 36190];
			//       while ( v381 != _InterlockedCompareExchange64(&qword_18D6405E0[v379 + 36190], v381 | (1LL << v380), v381) );
			//       v371 = dword_18D8E43F8;
			//     }
			//     v382 = v439;
			//     m_punctualLightShadowParams2 = (Object__Class *)v9.fields.m_punctualLightShadowParams2;
			//     if ( !v439 )
			//       sub_1802DC2C8(m_punctualLightShadowParams2, 0LL);
			//     v439[3].klass = m_punctualLightShadowParams2;
			//     if ( v371 )
			//     {
			//       v384 = ((unsigned __int64)&v382[3] >> 12) & 0x1FFFFF;
			//       v385 = (unsigned __int64)v384 >> 6;
			//       v382 = (Object *)(v384 & 0x3F);
			//       _m_prefetchw(&qword_18D6405E0[v385 + 36190]);
			//       do
			//         v386 = qword_18D6405E0[v385 + 36190];
			//       while ( v386 != _InterlockedCompareExchange64(&qword_18D6405E0[v385 + 36190], v386 | (1LL << (char)v382), v386) );
			//     }
			//     if ( !v439 )
			//       sub_1802DC2C8(0LL, v382);
			//     v439[3].monitor = (MonitorData *)v9.fields.m_punctualShadowAtlasSize;
			//     for ( n = 0; ; ++n )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//       if ( n >= TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_maxShadowCasterCount )
			//         break;
			//       for ( ii = 0; ii < 16; ++ii )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//         v390 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//         m_punctualLightWorldToShadowMatrices = v9.fields.m_punctualLightWorldToShadowMatrices;
			//         if ( !m_punctualLightWorldToShadowMatrices )
			//           sub_1802DC2C8(0LL, v389);
			//         v392 = (Matrix4x4 *)sub_1804440E4(m_punctualLightWorldToShadowMatrices, n);
			//         *(&v390[2].shadowData._ASMIndirectWorldToShadow.m20 + 16 * n + ii) = UnityEngine::Matrix4x4::get_Item(
			//                                                                                v392,
			//                                                                                ii,
			//                                                                                0LL);
			//       }
			//       for ( jj = 0; jj < 4; ++jj )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//         v395 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//         v396 = v9.fields.m_punctualLightShadowParams;
			//         if ( !v396 )
			//           sub_1802DC2C8(0LL, v394);
			//         v397 = sub_18003EB40(v396, n);
			//         *(&v395[11].shadowData._ASMParams.x + 4 * n + jj) = sub_182637EE0(v397, (unsigned int)jj);
			//       }
			//       for ( kk = 0; kk < 4; ++kk )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//         v400 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields;
			//         v401 = v9.fields.m_punctualLightShadowParams2;
			//         if ( !v401 )
			//           sub_1802DC2C8(0LL, v399);
			//         v402 = sub_18003EB40(v401, n);
			//         *(&v400[14].shadowData._CSMShadowTexelSize.x + 4 * n + kk) = sub_182637EE0(v402, (unsigned int)kk);
			//       }
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
			//     v403 = 1.0 / (float)v448.fields.m_punctualShadowAtlasSize.m_Y;
			//     v434.m_Normal.x = 1.0 / (float)v9.fields.m_punctualShadowAtlasSize.m_X;
			//     v434.m_Normal.y = v403;
			//     v434.m_Normal.z = (float)v9.fields.m_punctualShadowAtlasSize.m_X;
			//     v434.m_Distance = (float)v448.fields.m_punctualShadowAtlasSize.m_Y;
			//     *(Plane *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils.static_fields[16].shadowData._CharacterShadowAtlasParams.FixedElementField = v434;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
			//       &v511,
			//       (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2.static_fields.s_punctualLightShadowMapPushDataFunc,
			//       0LL,
			//       0,
			//       MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPushDataPassData>);
			//     HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v511, 0, 0LL);
			//     shadowResult.punctualLightShadowActive = 1;
			//     if ( !v439 )
			//       sub_1802DC2C8(0LL, v404);
			//     shadowResult.punctualLightShadowResult = (TextureHandle)v439[1];
			//   }
			//   catch ( Il2CppExceptionWrapper *v526 )
			//   {
			//     *(Il2CppExceptionWrapper *)&v440.m_Normal.x = (Il2CppExceptionWrapper)v526.ex;
			//   }
			//   sub_180222690(&v440);
			// }
			// 
		}

		private float m_punctualLightShadowScreenSizeMinSquared;

		private float m_punctualLightForceCullDistance;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static int s_maxShadowCasterCount;

		private int m_punctualShadowAtlasBaseTileSize;

		private int m_dynamicEnvPunctualShadowCasterCount;

		private int m_dynamicMovablePunctualShadowCasterCount;

		private Vector2Int m_punctualShadowAtlasSize;

		internal HGPunctualLightStaticAtlasAllocator punctualLightStaticAtlasAllocator;

		internal Dictionary<LightCaster, HGPunctualLightShadowManagerV2.PunctualLightCachedShadowDesc> m_activePunctualLightCachedShadowDescs;

		private Dictionary<LightCaster, int> m_targetPunctualAtlasAllocationThisFrame;

		private HGPunctualLightShadowManagerV2.PunctualLightCacheUpdateRequest m_targetUpdateRequest;

		private List<LightCaster> m_castersToBeRemoved;

		private RTHandle m_cachedPunctualLightShadowAtlas;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static Material s_clearShadowMaterial;

		private Matrix4x4[] m_punctualLightWorldToShadowMatrices;

		private Vector4[] m_punctualLightShadowParams;

		private Vector4[] m_punctualLightShadowParams2;

		private Entity[] m_targetStaticPunctualLights;

		private LightCaster[] m_targetDynamicPunctualLights;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x10")]
		private static readonly RenderFunc<HGPunctualLightShadowManagerV2.PunctualLightShadowPassData> s_punctualLightShadowMapRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x18")]
		private static readonly RenderFunc<HGPunctualLightShadowManagerV2.PunctualLightShadowPushDataPassData> s_punctualLightShadowMapSkipRenderFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x20")]
		private static readonly RenderFunc<HGPunctualLightShadowManagerV2.PunctualLightShadowPushDataPassData> s_punctualLightShadowMapPushDataFunc;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x28")]
		private static Plane[] s_cullPlanes;

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 16)]
		internal struct PunctualLightCachedShadowDesc
		{
			public int targetRenderLevel;

			public bool isShadowCached;

			public float lastVisitedTime;

			public int shadowCacheSlotIndex;
		}

		private enum PunctualLightCacheUpdateRequestType
		{
			None,
			AllocNewChunk,
			SmallChunkToLargeChunk,
			LargeChunkToSmallChunk
		}

		private class PunctualLightCacheUpdateRequest
		{
			public PunctualLightCacheUpdateRequest()
			{
				// // HGPunctualLightShadowManagerV2+PunctualLightCacheUpdateRequest()
				// void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCacheUpdateRequest::PunctualLightCacheUpdateRequest(
				//         HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *this,
				//         MethodInfo *method)
				// {
				//   *(_QWORD *)&this.fields.sourceSlot = -1LL;
				//   this.fields.targetSlot = -1;
				// }
				// 
			}

			public HGPunctualLightShadowManagerV2.PunctualLightCacheUpdateRequestType requestType;

			public LightCaster requestLightCaster;

			public int sourceSlot;

			public int targetLevel;

			public int targetSlot;
		}

		private class PunctualLightShadowPassData
		{
			public PunctualLightShadowPassData()
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

			public HGCamera hgCamera;

			public CullingResults cullingResults;

			public float shadowBias;

			public RectInt renderRegion;

			public Matrix4x4 deviceProjYFlip;

			public Matrix4x4 view;

			public uint ecsShadowRendererList;

			public uint ecsShadowGrassList;

			public RendererList rendererList;

			public TextureHandle punctualLightCachedAtlas;

			public Material blitShadowMaterial;

			public Material clearShadowMaterial;
		}

		private class PunctualLightShadowPushDataPassData
		{
			public PunctualLightShadowPushDataPassData()
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

			public TextureHandle punctualLightCachedAtlas;

			public Matrix4x4[] punctualLightWorldToShadowMatrices;

			public Vector4[] punctualLightShadowParams;

			public Vector4[] punctualLightShadowParams2;

			public Vector2Int punctualLightCachedAtlasSize;
		}
	}
}
