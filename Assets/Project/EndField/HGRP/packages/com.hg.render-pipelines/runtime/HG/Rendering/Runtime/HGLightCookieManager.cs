using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGLightCookieManager // TypeDefIndex: 37768
	{
		// Fields
		private const int MAX_LIGHT_COOKIE_COUNT = 32; // Metadata: 0x023030EC
		private const int LIGHT_COOKIE_ATLAS_WIDTH = 4096; // Metadata: 0x023030ED
		private const int LIGHT_COOKIE_ATLAS_HEIGHT = 4096; // Metadata: 0x023030EF
		private Dictionary<Texture, RectInt> m_activeLightCookies; // 0x10
		private List<Texture> m_texturesInUse; // 0x18
		private List<Texture> m_texturesToBeRemoved; // 0x20
		private List<Texture> m_texturesToBeAdded; // 0x28
		private Dictionary<Entity, int> m_lightSlots; // 0x30
		private AtlasMaxRect m_lightCookieAtlasAllocator; // 0x38
		private Texture2D m_cachedLightCookieAtlas; // 0x40
		private GraphicsFormat m_lightCookieColorFormat; // 0x48
		private static readonly RenderFunc<UpdateLightCookieAtlasPassData> s_updateLightCookieAtlasRenderFunc; // 0x00
		private static readonly RenderFunc<LightCookieSetDataPassData> s_lightCookieSetDataPassRenderFunc; // 0x08
		private static Texture[] s_srcTextures; // 0x10
		private static Vector2Int[] s_srcDimensions; // 0x18
		private static Vector2Int[] s_dstPositions; // 0x20
		private static Vector2Int[] s_dstDimensions; // 0x28
		private static Vector4[] s_lightCookieData; // 0x30
		private static Matrix4x4[] s_lightCookieMatricesData; // 0x38
	
		// Nested types
		private class UpdateLightCookieAtlasPassData // TypeDefIndex: 37765
		{
			// Fields
			public Texture2D dstAtlas; // 0x10
			public int updateRequestCount; // 0x18
			public Texture[] srcTextures; // 0x20
			public Vector2Int[] dstPositions; // 0x28
			public Vector2Int[] srcDimensions; // 0x30
			public Vector2Int[] dstDimensions; // 0x38
	
			// Constructors
			public UpdateLightCookieAtlasPassData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		private class LightCookieSetDataPassData // TypeDefIndex: 37766
		{
			// Fields
			public Texture2D dstAtlas; // 0x10
			public Vector4[] lightCookieData; // 0x18
			public Matrix4x4[] lightCookieWorldToLightData; // 0x20
	
			// Constructors
			public LightCookieSetDataPassData() {} // 0x00000001841E1670-0x00000001841E1680
			// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			        HGWindConfig *cSrc,
			        HGWindConfig *cDst,
			        float t,
			        MethodInfo *method)
			{
			  ;
			}
			
		}
	
		// Constructors
		internal HGLightCookieManager() {} // 0x000000018425F0D0-0x000000018425F240
		// HGLightCookieManager()
		void HG::Rendering::Runtime::HGLightCookieManager::HGLightCookieManager(HGLightCookieManager *this, MethodInfo *method)
		{
		  Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Dictionary_2_UnityEngine_Texture_UnityEngine_RectInt_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v10; // rax
		  List_1_UnityEngine_Texture_ *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v15; // rax
		  List_1_UnityEngine_Texture_ *v16; // rdi
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v20; // rax
		  List_1_UnityEngine_Texture_ *v21; // rdi
		  Type *v22; // rdx
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Single_ *v25; // rax
		  Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Int32_ *v26; // rdi
		  Type *v27; // rdx
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  AtlasMaxRect *v30; // rax
		  AtlasMaxRect *v31; // rdi
		  Type *v32; // rdx
		  PropertyInfo_1 *v33; // r8
		  Int32__Array **v34; // r9
		  MethodInfo *v35; // [rsp+20h] [rbp-8h]
		  MethodInfo *v36; // [rsp+20h] [rbp-8h]
		  MethodInfo *v37; // [rsp+20h] [rbp-8h]
		  MethodInfo *v38; // [rsp+20h] [rbp-8h]
		  MethodInfo *v39; // [rsp+20h] [rbp-8h]
		  MethodInfo *v40; // [rsp+20h] [rbp-8h]
		
		  v3 = (Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>);
		  v6 = (Dictionary_2_UnityEngine_Texture_UnityEngine_RectInt_ *)v3;
		  if ( !v3 )
		    goto LABEL_8;
		  System::Collections::Generic::Dictionary<System::Object,Beyond::Gameplay::ShopSystem::UnlockInfo>::Dictionary(
		    v3,
		    MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::Dictionary);
		  this->fields.m_activeLightCookies = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v35);
		  v10 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::Texture>);
		  v11 = (List_1_UnityEngine_Texture_ *)v10;
		  if ( !v10 )
		    goto LABEL_8;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v10,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::List);
		  this->fields.m_texturesInUse = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_texturesInUse, v12, v13, v14, v36);
		  v15 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::Texture>);
		  v16 = (List_1_UnityEngine_Texture_ *)v15;
		  if ( !v15 )
		    goto LABEL_8;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v15,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::List);
		  this->fields.m_texturesToBeRemoved = v16;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_texturesToBeRemoved, v17, v18, v19, v37);
		  v20 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::Texture>);
		  v21 = (List_1_UnityEngine_Texture_ *)v20;
		  if ( !v20 )
		    goto LABEL_8;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v20,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::List);
		  this->fields.m_texturesToBeAdded = v21;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_texturesToBeAdded, v22, v23, v24, v38);
		  v25 = (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Single_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,int>);
		  v26 = (Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Int32_ *)v25;
		  if ( !v25
		    || (System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,float>::Dictionary(
		          v25,
		          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,int>::Dictionary),
		        this->fields.m_lightSlots = v26,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_lightSlots, v27, v28, v29, v39),
		        v30 = (AtlasMaxRect *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::AtlasMaxRect),
		        (v31 = v30) == 0LL) )
		  {
		LABEL_8:
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::Runtime::AtlasMaxRect::AtlasMaxRect(v30, 4096, 4096, 0LL);
		  this->fields.m_lightCookieAtlasAllocator = v31;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_lightCookieAtlasAllocator, v32, v33, v34, v40);
		  this->fields.m_lightCookieColorFormat = 102;
		  HG::Rendering::Runtime::HGLightCookieManager::InvalidateAllLightCookies(this, 0LL);
		}
		
		static HGLightCookieManager() {} // 0x00000001849DE3B0-0x00000001849DE600
		// HGLightCookieManager()
		void HG::Rendering::Runtime::HGLightCookieManager::cctor(MethodInfo *method)
		{
		  struct HGLightCookieManager_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Type__Class *v6; // rbx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  Object *v10; // rdi
		  RenderFunc_1_System_Object_ *v11; // rax
		  MonitorData *v12; // rbx
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  __int64 v16; // rax
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  __int64 v20; // rax
		  Type *v21; // rdx
		  PropertyInfo_1 *v22; // r8
		  Int32__Array **v23; // r9
		  __int64 v24; // rax
		  Type *v25; // rdx
		  PropertyInfo_1 *v26; // r8
		  Int32__Array **v27; // r9
		  __int64 v28; // rax
		  Type *v29; // rdx
		  PropertyInfo_1 *v30; // r8
		  Int32__Array **v31; // r9
		  __int64 v32; // rax
		  PropertyInfo_1 *v33; // r8
		  Type *v34; // rdx
		  Int32__Array **v35; // r9
		  __int64 v36; // rax
		  Type *v37; // rdx
		  PropertyInfo_1 *v38; // r8
		  Int32__Array **v39; // r9
		  MethodInfo *v40; // [rsp+20h] [rbp-8h]
		  MethodInfo *v41; // [rsp+20h] [rbp-8h]
		  MethodInfo *v42; // [rsp+20h] [rbp-8h]
		  MethodInfo *v43; // [rsp+20h] [rbp-8h]
		  MethodInfo *v44; // [rsp+20h] [rbp-8h]
		  MethodInfo *v45; // [rsp+20h] [rbp-8h]
		  MethodInfo *v46; // [rsp+20h] [rbp-8h]
		  MethodInfo *v47; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGLightCookieManager::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGLightCookieManager::UpdateLightCookieAtlasPassData>);
		  v6 = (Type__Class *)v3;
		  if ( !v3
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v3,
		          v2,
		          MethodInfo::HG::Rendering::Runtime::HGLightCookieManager::__c::__cctor_b__28_0,
		          0LL),
		        static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields,
		        static_fields->klass = v6,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields,
		          static_fields,
		          v8,
		          v9,
		          v40),
		        v10 = (Object *)TypeInfo::HG::Rendering::Runtime::HGLightCookieManager::__c->static_fields->__9,
		        v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGLightCookieManager::LightCookieSetDataPassData>),
		        (v12 = (MonitorData *)v11) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v11,
		    v10,
		    MethodInfo::HG::Rendering::Runtime::HGLightCookieManager::__c::__cctor_b__28_1,
		    0LL);
		  v13 = (Type *)TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields;
		  v13->monitor = v12;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields->s_lightCookieSetDataPassRenderFunc,
		    v13,
		    v14,
		    v15,
		    v41);
		  v16 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Texture, 32LL);
		  v17 = (Type *)TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields;
		  v17->fields._impl.value = (void *)v16;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields->s_srcTextures,
		    v17,
		    v18,
		    v19,
		    v42);
		  v20 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2Int, 32LL);
		  v21 = (Type *)TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields;
		  v21[1].klass = (Type__Class *)v20;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields->s_srcDimensions,
		    v21,
		    v22,
		    v23,
		    v43);
		  v24 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2Int, 32LL);
		  v25 = (Type *)TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields;
		  v25[1].monitor = (MonitorData *)v24;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields->s_dstPositions,
		    v25,
		    v26,
		    v27,
		    v44);
		  v28 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2Int, 32LL);
		  v29 = (Type *)TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields;
		  v29[1].fields._impl.value = (void *)v28;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields->s_dstDimensions,
		    v29,
		    v30,
		    v31,
		    v45);
		  v32 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector4, 32LL);
		  v33 = (PropertyInfo_1 *)TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields;
		  v33[3].klass = (PropertyInfo_1__Class *)v32;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields->s_lightCookieData,
		    v34,
		    v33,
		    v35,
		    v46);
		  v36 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Matrix4x4, 32LL);
		  v37 = (Type *)TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields;
		  v37[2].monitor = (MonitorData *)v36;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields->s_lightCookieMatricesData,
		    v37,
		    v38,
		    v39,
		    v47);
		}
		
	
		// Methods
		internal void Dispose() {} // 0x0000000184CAB490-0x0000000184CAB520
		// Void Dispose()
		void HG::Rendering::Runtime::HGLightCookieManager::Dispose(HGLightCookieManager *this, MethodInfo *method)
		{
		  struct Object_1__Class *v3; // rcx
		  Texture2D *m_cachedLightCookieAtlas; // rbx
		  Object_1 *v5; // rbx
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(550, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(550, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v3 = TypeInfo::UnityEngine::Object;
		    m_cachedLightCookieAtlas = this->fields.m_cachedLightCookieAtlas;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v3 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v3 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( m_cachedLightCookieAtlas )
		    {
		      if ( !v3->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v3);
		        v3 = TypeInfo::UnityEngine::Object;
		      }
		      if ( m_cachedLightCookieAtlas->fields._._.m_CachedPtr )
		      {
		        v5 = (Object_1 *)this->fields.m_cachedLightCookieAtlas;
		        if ( !v3->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(v3);
		        UnityEngine::Object::DestroyImmediate(v5, 0LL);
		        this->fields.m_cachedLightCookieAtlas = 0LL;
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_cachedLightCookieAtlas, v6, v7, v8, v12);
		      }
		    }
		  }
		}
		
		internal int GetLightCookieIndex(Entity light) => default; // 0x0000000189D071AC-0x0000000189D07218
		// Int32 GetLightCookieIndex(Entity)
		int32_t HG::Rendering::Runtime::HGLightCookieManager::GetLightCookieIndex(
		        HGLightCookieManager *this,
		        Entity_1 light,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1891, 0LL) )
		    return System::Collections::Generic::CollectionExtensions::GetValueOrDefault<UnityEngine::HyperGryph::ECS::Entity,int>(
		             (IReadOnlyDictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Int32_ *)this->fields.m_lightSlots,
		             light,
		             -1,
		             MethodInfo::System::Collections::Generic::CollectionExtensions::GetValueOrDefault<UnityEngine::HyperGryph::ECS::Entity,int>);
		  Patch = IFix::WrappersManagerImpl::GetPatch(1891, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v8, v7);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_756(Patch, (Object *)this, light, 0LL);
		}
		
		private bool IsLightCookiesEnabled(HGSettingParameters settingParams) => default; // 0x0000000189D07218-0x0000000189D0727C
		// Boolean IsLightCookiesEnabled(HGSettingParameters)
		bool HG::Rendering::Runtime::HGLightCookieManager::IsLightCookiesEnabled(
		        HGLightCookieManager *this,
		        HGSettingParameters *settingParams,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1892, 0LL) )
		    return !UnityEngine::Rendering::GraphicsSettings::HasShaderDefine(
		              BuiltinShaderDefine__Enum_HG_RENDER_PATH_MOBILE,
		              0LL);
		  Patch = IFix::WrappersManagerImpl::GetPatch(1892, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v8, v7);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		           (ILFixDynamicMethodWrapper_33 *)Patch,
		           (Object *)this,
		           (Object *)settingParams,
		           0LL);
		}
		
		public void InvalidateAllLightCookies() {} // 0x000000018425F240-0x000000018425F2B0
		// Void InvalidateAllLightCookies()
		void HG::Rendering::Runtime::HGLightCookieManager::InvalidateAllLightCookies(
		        HGLightCookieManager *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  AtlasMaxRect *m_lightCookieAtlasAllocator; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1893, 0LL) )
		  {
		    m_lightCookieAtlasAllocator = this->fields.m_lightCookieAtlasAllocator;
		    if ( m_lightCookieAtlasAllocator )
		    {
		      HG::Rendering::Runtime::AtlasMaxRect::Reset(m_lightCookieAtlasAllocator, 0LL);
		      m_lightCookieAtlasAllocator = (AtlasMaxRect *)this->fields.m_activeLightCookies;
		      if ( m_lightCookieAtlasAllocator )
		      {
		        System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::Clear(
		          (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)m_lightCookieAtlasAllocator,
		          MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::Clear);
		        m_lightCookieAtlasAllocator = (AtlasMaxRect *)this->fields.m_lightSlots;
		        if ( m_lightCookieAtlasAllocator )
		        {
		          System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::Clear(
		            (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)m_lightCookieAtlasAllocator,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,int>::Clear);
		          return;
		        }
		      }
		    }
		LABEL_6:
		    sub_1800D8260(m_lightCookieAtlasAllocator, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1893, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		internal void PrepareLightCookies(NativeArray<VisibleLight> visibleLights, HGCamera hgCamera, HGSettingParameters settingParams, NativeArray<int> lightIndices, int punctualLightCount) {} // 0x0000000189D0727C-0x0000000189D07A74
		// Void PrepareLightCookies(NativeArray`1[UnityEngine.Rendering.VisibleLight], HGCamera, HGSettingParameters, NativeArray`1[System.Int32], Int32)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGLightCookieManager::PrepareLightCookies(
		        HGLightCookieManager *this,
		        NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights,
		        HGCamera *hgCamera,
		        HGSettingParameters *settingParams,
		        NativeArray_1_System_Int32_ *lightIndices,
		        int32_t punctualLightCount,
		        MethodInfo *method)
		{
		  HGLightCookieManager *v10; // r14
		  Object_1 *m_cachedLightCookieAtlas; // rbx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  GraphicsFormat__Enum m_lightCookieColorFormat; // edi
		  Texture2D *v15; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  Texture2D *v18; // rbx
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  __int64 v28; // rdi
		  Void *m_Buffer; // r13
		  Void *v30; // r12
		  Void *v31; // rax
		  Object_1 *cookie_Injected; // rbx
		  Object *v33; // rax
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  Object *v36; // rbx
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  List_1_System_Object_ *m_texturesInUse; // r15
		  List_1_System_Object_ *v40; // rcx
		  __int64 v41; // rdx
		  Object *v42; // rbx
		  List_1_System_Object_ *v43; // rcx
		  __int64 v44; // rdx
		  List_1_System_Object_ *m_texturesToBeRemoved; // rcx
		  List_1_System_UInt64_ *v46; // rdx
		  __int64 v47; // rcx
		  Object *current; // rdi
		  AtlasMaxRect *m_lightCookieAtlasAllocator; // rbx
		  Dictionary_2_System_Object_UnityEngine_RectInt_ *m_activeLightCookies; // rdx
		  __int64 v51; // rdx
		  __int64 v52; // rcx
		  __int64 v53; // rdx
		  Dictionary_2_System_Object_UnityEngine_Vector3Int_ *v54; // rcx
		  List_1_UnityEngine_Texture_ *m_texturesToBeAdded; // rax
		  Object *v56; // rax
		  String *v57; // rax
		  int32_t v58; // r15d
		  int32_t i; // r13d
		  int size; // r12d
		  Dictionary_2_UnityEngine_Texture_UnityEngine_RectInt_ *v61; // rdi
		  int32_t count; // ebx
		  int32_t freeCount; // edi
		  int v64; // edi
		  Object *Item; // rax
		  Object *v66; // rbx
		  int v67; // eax
		  AtlasMaxRect *v68; // rdi
		  int32_t v69; // r12d
		  int32_t v70; // eax
		  int32_t v71; // r8d
		  Vector4 *p_ex; // rcx
		  int v73; // r12d
		  RectInt v74; // xmm1
		  List_1_UnityEngine_Texture_ *v75; // rax
		  __int64 v76; // rdx
		  __int64 v77; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rbx
		  MethodInfo *v79[5]; // [rsp+0h] [rbp-1C8h] BYREF
		  HGSharedLightData _unity_self; // [rsp+40h] [rbp-188h] BYREF
		  Il2CppException *ex; // [rsp+48h] [rbp-180h] BYREF
		  void *v82; // [rsp+50h] [rbp-178h]
		  int v83; // [rsp+58h] [rbp-170h] BYREF
		  Vector4 value; // [rsp+60h] [rbp-168h] BYREF
		  Object *key; // [rsp+70h] [rbp-158h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_Beyond_Gameplay_ScriptEntityId_System_Object_ v86; // [rsp+80h] [rbp-148h] BYREF
		  List_1_T_Enumerator_System_Object_ v87; // [rsp+B0h] [rbp-118h] BYREF
		  HGLightCookieManager *v88; // [rsp+C8h] [rbp-100h]
		  Dictionary_2_TKey_TValue_Enumerator_System_Object_UnityEngine_RectInt_ v89; // [rsp+D0h] [rbp-F8h] BYREF
		  Il2CppExceptionWrapper *v90; // [rsp+100h] [rbp-C8h] BYREF
		  Il2CppExceptionWrapper *v91; // [rsp+108h] [rbp-C0h] BYREF
		  __int128 v92; // [rsp+110h] [rbp-B8h]
		  __int128 v93; // [rsp+120h] [rbp-A8h]
		  __int128 v94; // [rsp+130h] [rbp-98h]
		  __int128 v95; // [rsp+140h] [rbp-88h]
		  __int128 v96; // [rsp+150h] [rbp-78h]
		  __int128 v97; // [rsp+160h] [rbp-68h]
		  __int128 v98; // [rsp+170h] [rbp-58h]
		  __int128 v99; // [rsp+180h] [rbp-48h]
		  __int128 v100; // [rsp+190h] [rbp-38h]
		  int v101; // [rsp+1A0h] [rbp-28h]
		
		  v10 = this;
		  v88 = this;
		  _unity_self = 0LL;
		  key = 0LL;
		  value = 0LL;
		  memset(&v87, 0, sizeof(v87));
		  if ( !IFix::WrappersManagerImpl::IsPatched(1894, 0LL) )
		  {
		    m_cachedLightCookieAtlas = (Object_1 *)v10->fields.m_cachedLightCookieAtlas;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(m_cachedLightCookieAtlas, 0LL, 0LL) )
		    {
		      m_lightCookieColorFormat = v10->fields.m_lightCookieColorFormat;
		      v15 = (Texture2D *)sub_18002C620(TypeInfo::UnityEngine::Texture2D);
		      v18 = v15;
		      if ( !v15 )
		        sub_1800D8260(v17, v16);
		      UnityEngine::Texture2D::Texture2D(v15, 4096, 4096, m_lightCookieColorFormat, TextureCreationFlags__Enum_None, 0LL);
		      v10->fields.m_cachedLightCookieAtlas = v18;
		      sub_18002D1B0((SingleFieldAccessor *)&v10->fields.m_cachedLightCookieAtlas, v19, v20, v21, v79[4]);
		      HG::Rendering::Runtime::HGLightCookieManager::InvalidateAllLightCookies(v10, 0LL);
		    }
		    if ( !v10->fields.m_texturesInUse )
		      sub_1800D8260(v13, v12);
		    sub_183127A90(
		      v10->fields.m_texturesInUse,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::Clear);
		    if ( !v10->fields.m_texturesToBeRemoved )
		      sub_1800D8260(v23, v22);
		    sub_183127A90(
		      v10->fields.m_texturesToBeRemoved,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::Clear);
		    if ( !v10->fields.m_texturesToBeAdded )
		      sub_1800D8260(v25, v24);
		    sub_183127A90(
		      v10->fields.m_texturesToBeAdded,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::Clear);
		    v28 = punctualLightCount;
		    if ( punctualLightCount > 0 )
		    {
		      m_Buffer = visibleLights->m_Buffer;
		      v30 = lightIndices->m_Buffer;
		      do
		      {
		        v31 = &m_Buffer[148 * *(_DWORD *)v30];
		        v92 = *(_OWORD *)v31;
		        v93 = *(_OWORD *)&v31[16];
		        v94 = *(_OWORD *)&v31[32];
		        v95 = *(_OWORD *)&v31[48];
		        v96 = *(_OWORD *)&v31[64];
		        v97 = *(_OWORD *)&v31[80];
		        v98 = *(_OWORD *)&v31[96];
		        v99 = *(_OWORD *)&v31[112];
		        v100 = *(_OWORD *)&v31[128];
		        v101 = *(_DWORD *)&v31[144];
		        _unity_self = (HGSharedLightData)*((_QWORD *)&v100 + 1);
		        cookie_Injected = (Object_1 *)UnityEngine::HGSharedLightData::get_cookie_Injected(&_unity_self, 0LL);
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( UnityEngine::Object::op_Inequality(cookie_Injected, 0LL, 0LL)
		          && (UnityEngine::HGSharedLightData::get_type_Injected(&_unity_self, 0LL) == LightType__Enum_Spot
		           || UnityEngine::HGSharedLightData::get_type_Injected(&_unity_self, 0LL) == LightType__Enum_Point) )
		        {
		          v33 = (Object *)UnityEngine::HGSharedLightData::get_cookie_Injected(&_unity_self, 0LL);
		          v36 = v33;
		          if ( !v10->fields.m_activeLightCookies )
		            sub_1800D8260(v35, v34);
		          if ( System::Collections::Generic::Dictionary<System::Object,UnityEngine::RectInt>::ContainsKey(
		                 (Dictionary_2_System_Object_UnityEngine_RectInt_ *)v10->fields.m_activeLightCookies,
		                 v33,
		                 MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::ContainsKey) )
		          {
		            goto LABEL_19;
		          }
		          if ( !v10->fields.m_texturesToBeAdded )
		            sub_1800D8260(v38, v37);
		          if ( System::Collections::Generic::List<System::Object>::Contains(
		                 (List_1_System_Object_ *)v10->fields.m_texturesToBeAdded,
		                 v36,
		                 MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::Contains) )
		          {
		LABEL_19:
		            m_texturesInUse = (List_1_System_Object_ *)v10->fields.m_texturesInUse;
		            if ( !m_texturesInUse )
		              sub_1800D8260(v38, v37);
		          }
		          else
		          {
		            m_texturesInUse = (List_1_System_Object_ *)v10->fields.m_texturesToBeAdded;
		            if ( !m_texturesInUse )
		              sub_1800D8260(v38, v37);
		          }
		          sub_182F01190(m_texturesInUse, v36);
		        }
		        v30 += 4;
		        --v28;
		      }
		      while ( v28 );
		    }
		    if ( !v10->fields.m_activeLightCookies )
		      sub_1800D8260(v27, v26);
		    System::Collections::Generic::Dictionary<Beyond::Gameplay::ScriptEntityId,System::Object>::GetEnumerator(
		      &v86,
		      (Dictionary_2_Beyond_Gameplay_ScriptEntityId_System_Object_ *)v10->fields.m_activeLightCookies,
		      MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::GetEnumerator);
		    v89 = (Dictionary_2_TKey_TValue_Enumerator_System_Object_UnityEngine_RectInt_)v86;
		    ex = 0LL;
		    v82 = &v89;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<System::Object,UnityEngine::RectInt>::MoveNext(
		                &v89,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<UnityEngine::Texture,UnityEngine::RectInt>::MoveNext) )
		      {
		        *(_OWORD *)&v86._dictionary = *(_OWORD *)&v89._current.key;
		        v86._current.key.scriptIdGlobal = *(_QWORD *)&v89._current.value.m_Width;
		        System::Collections::Generic::KeyValuePair<System::Object,UnityEngine::Vector4>::Deconstruct(
		          (KeyValuePair_2_System_Object_UnityEngine_Vector4_ *)&v86,
		          &key,
		          &value,
		          MethodInfo::System::Collections::Generic::KeyValuePair<UnityEngine::Texture,UnityEngine::RectInt>::Deconstruct);
		        v42 = key;
		        v43 = (List_1_System_Object_ *)v10->fields.m_texturesInUse;
		        if ( !v43 )
		          sub_1800D8250(0LL, v41);
		        if ( !System::Collections::Generic::List<System::Object>::Contains(
		                v43,
		                key,
		                MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::Contains) )
		        {
		          m_texturesToBeRemoved = (List_1_System_Object_ *)v10->fields.m_texturesToBeRemoved;
		          if ( !m_texturesToBeRemoved )
		            sub_1800D8250(0LL, v44);
		          sub_182F01190(m_texturesToBeRemoved, v42);
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v90 )
		    {
		      ex = v90->ex;
		      v40 = (List_1_System_Object_ *)ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      v10 = this;
		    }
		    v46 = (List_1_System_UInt64_ *)v10->fields.m_texturesToBeRemoved;
		    if ( v46 )
		    {
		      System::Collections::Generic::List<unsigned long>::GetEnumerator(
		        (List_1_T_Enumerator_System_UInt64_ *)&v86,
		        v46,
		        MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::GetEnumerator);
		      *(_OWORD *)&v87._list = *(_OWORD *)&v86._dictionary;
		      v87._current = (Object *)v86._current.key.scriptIdGlobal;
		      ex = 0LL;
		      v82 = &v87;
		      try
		      {
		        while ( System::Collections::Generic::List_1_T_::Enumerator<System::Object>::MoveNext(
		                  &v87,
		                  MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<UnityEngine::Texture>::MoveNext) )
		        {
		          current = v87._current;
		          m_lightCookieAtlasAllocator = v10->fields.m_lightCookieAtlasAllocator;
		          m_activeLightCookies = (Dictionary_2_System_Object_UnityEngine_RectInt_ *)v10->fields.m_activeLightCookies;
		          if ( !m_activeLightCookies )
		            sub_1800D8250(v47, 0LL);
		          System::Collections::Generic::Dictionary<System::Object,UnityEngine::RectInt>::get_Item(
		            (RectInt *)&v86,
		            m_activeLightCookies,
		            v87._current,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::get_Item);
		          value = *(Vector4 *)&v86._dictionary;
		          if ( !m_lightCookieAtlasAllocator )
		            sub_1800D8250(v52, v51);
		          HG::Rendering::Runtime::AtlasMaxRect::RemoveRect(m_lightCookieAtlasAllocator, (RectInt *)&value, 0LL);
		          v54 = (Dictionary_2_System_Object_UnityEngine_Vector3Int_ *)v10->fields.m_activeLightCookies;
		          if ( !v54 )
		            sub_1800D8250(0LL, v53);
		          System::Collections::Generic::Dictionary<System::Object,UnityEngine::Vector3Int>::Remove(
		            v54,
		            current,
		            MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::Remove);
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v91 )
		      {
		        v46 = (List_1_System_UInt64_ *)v79;
		        ex = v91->ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		        v10 = this;
		      }
		      v40 = (List_1_System_Object_ *)v10->fields.m_activeLightCookies;
		      if ( v40 )
		      {
		        m_texturesToBeAdded = v10->fields.m_texturesToBeAdded;
		        if ( m_texturesToBeAdded )
		        {
		          if ( LODWORD(v40->fields._syncRoot) + m_texturesToBeAdded->fields._size - LODWORD(v40[1].klass) > 32 )
		          {
		            v83 = 32;
		            v56 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v83);
		            v57 = System::String::Format(
		                    (String *)"HGLightCookieManager: 当前帧尝试创建的Light Cookie数量超过{0}，请灯光师检查一下灯光状态。",
		                    v56,
		                    0LL);
		            HG::Rendering::HGRPLogger::LogWarning(v57, 0LL);
		          }
		          v58 = 0;
		          for ( i = 0; ; i = v58 )
		          {
		            v75 = v10->fields.m_texturesToBeAdded;
		            if ( !v75 )
		              break;
		            size = v75->fields._size;
		            v61 = v10->fields.m_activeLightCookies;
		            if ( !v61 )
		              break;
		            count = v61->fields._count;
		            freeCount = v61->fields._freeCount;
		            sub_1800036A0(TypeInfo::System::Math);
		            v64 = freeCount - count + 32;
		            if ( size > v64 )
		              size = v64;
		            if ( i >= size )
		              return;
		            v40 = (List_1_System_Object_ *)v10->fields.m_texturesToBeAdded;
		            if ( !v40 )
		              break;
		            Item = System::Collections::Generic::List<System::Object>::get_Item(
		                     v40,
		                     v58,
		                     MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::get_Item);
		            v66 = Item;
		            if ( !Item )
		              break;
		            v67 = sub_180002F70(9LL, Item);
		            v68 = v88->fields.m_lightCookieAtlasAllocator;
		            if ( v67 == 4 )
		            {
		              v73 = sub_180002F70(5LL, v66);
		              v70 = sub_180002F70(7LL, v66);
		              if ( !v68 )
		                break;
		              v71 = 6 * v73;
		              p_ex = (Vector4 *)&ex;
		            }
		            else
		            {
		              v69 = sub_180002F70(5LL, v66);
		              v70 = sub_180002F70(7LL, v66);
		              if ( !v68 )
		                break;
		              v71 = v69;
		              p_ex = &value;
		            }
		            v74 = *HG::Rendering::Runtime::AtlasMaxRect::InsertRect((RectInt *)p_ex, v68, v71, v70, 0LL);
		            if ( _mm_cvtsi128_si32(_mm_srli_si128((__m128i)v74, 8)) )
		            {
		              v40 = (List_1_System_Object_ *)v10->fields.m_activeLightCookies;
		              if ( !v40 )
		                break;
		              *(RectInt *)&v86._dictionary = v74;
		              System::Collections::Generic::Dictionary<System::Object,UnityEngine::RectInt>::set_Item(
		                (Dictionary_2_System_Object_UnityEngine_RectInt_ *)v40,
		                v66,
		                (RectInt *)&v86,
		                MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::set_Item);
		            }
		            else
		            {
		              HG::Rendering::HGRPLogger::LogWarning(
		                (String *)"HGLightCookieManager: 由于LightCookie Atlas空间已占满，尝试创建Light Cookie失败，请灯光师检查一下灯光状态。",
		                0LL);
		            }
		            ++v58;
		          }
		        }
		      }
		    }
		    sub_1800D8250(v40, v46);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1894, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v77, v76);
		  *(NativeArray_1_System_Int32_ *)&v86._dictionary = *lightIndices;
		  value = (Vector4)*visibleLights;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_757(
		    Patch,
		    (Object *)v10,
		    (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&value,
		    (Object *)hgCamera,
		    (Object *)settingParams,
		    (NativeArray_1_System_Int32_ *)&v86,
		    punctualLightCount,
		    0LL);
		}
		
		internal void UpdateLightCookieAtlas(HGRenderGraph renderGraph, NativeArray<VisibleLight> visibleLights, HGCamera hgCamera, HGSettingParameters settingParams, NativeArray<int> lightIndices, int punctualLightCount) {} // 0x0000000189D07A74-0x0000000189D08A30
		// Void UpdateLightCookieAtlas(HGRenderGraph, NativeArray`1[UnityEngine.Rendering.VisibleLight], HGCamera, HGSettingParameters, NativeArray`1[System.Int32], Int32)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::HGLightCookieManager::UpdateLightCookieAtlas(
		        HGLightCookieManager *this,
		        HGRenderGraph *renderGraph,
		        NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights,
		        HGCamera *hgCamera,
		        HGSettingParameters *settingParams,
		        NativeArray_1_System_Int32_ *lightIndices,
		        int32_t punctualLightCount,
		        MethodInfo *method)
		{
		  Object *v10; // r13
		  HGLightCookieManager *v11; // r14
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  List_1_UnityEngine_Texture_ *m_texturesToBeAdded; // rbx
		  int32_t i; // esi
		  List_1_UnityEngine_Texture_ *v16; // rbx
		  Object *Item; // rax
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  Object *v20; // rbx
		  __int64 v21; // rdx
		  HGLightCookieManager__StaticFields *v22; // rcx
		  __int64 v23; // rdx
		  HGLightCookieManager__StaticFields *static_fields; // rcx
		  Texture__Array *s_srcTextures; // r15
		  __int64 v26; // rdx
		  HGLightCookieManager__StaticFields *v27; // rcx
		  Vector2Int__Array *s_srcDimensions; // r15
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  Vector2Int__Array *s_dstPositions; // r15
		  int2 xy; // rax
		  int2 v33; // rdx
		  int2 v34; // rcx
		  Vector2Int__Array *s_dstDimensions; // r15
		  Vector2Int size; // rbx
		  ProfilingSampler *v37; // rax
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  __int64 v40; // rcx
		  Object *v41; // rdx
		  unsigned __int64 v42; // rdx
		  unsigned __int64 v43; // r8
		  char v44; // dl
		  signed __int64 v45; // rtt
		  Object *v46; // rbx
		  __int64 v47; // rdx
		  HGLightCookieManager__StaticFields *v48; // rcx
		  unsigned __int64 v49; // rdx
		  unsigned __int64 v50; // r8
		  signed __int64 v51; // rtt
		  Object *v52; // r8
		  HGLightCookieManager__StaticFields *v53; // rcx
		  unsigned __int64 v54; // rdx
		  unsigned __int64 v55; // r8
		  char v56; // dl
		  signed __int64 v57; // rtt
		  Object *v58; // r8
		  HGLightCookieManager__StaticFields *v59; // rcx
		  unsigned __int64 v60; // rdx
		  unsigned __int64 v61; // r8
		  char v62; // dl
		  signed __int64 v63; // rtt
		  Object *v64; // r8
		  signed __int64 v65; // rcx
		  unsigned __int64 v66; // rdx
		  unsigned __int64 v67; // r8
		  signed __int64 v68; // rtt
		  List_1_UnityEngine_Texture_ *v69; // rax
		  __int64 v70; // rcx
		  ProfilingSampler *v71; // rax
		  __int64 v72; // rdx
		  __int64 v73; // rcx
		  __int64 v74; // rdx
		  Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *m_lightSlots; // rcx
		  __int64 v76; // rcx
		  int32_t v77; // r12d
		  int32_t j; // eax
		  Void *v79; // rax
		  Entity_1 Entity; // rbx
		  Object *cookie_Injected; // r13
		  __int64 v82; // rdx
		  Dictionary_2_System_Object_UnityEngine_RectInt_ *m_activeLightCookies; // rcx
		  __int64 v84; // rdx
		  Dictionary_2_UnityEngine_HyperGryph_ECS_Entity_System_Int32_ *v85; // rcx
		  __int64 v86; // rdx
		  Vector4__Array *s_lightCookieData; // rcx
		  Matrix4x4__Array *s_lightCookieMatricesData; // rbx
		  Matrix4x4 *v89; // rax
		  __int64 v90; // rdx
		  __int64 v91; // rcx
		  Matrix4x4 *localToWorldMatrix; // rax
		  __int128 v93; // xmm9
		  __int128 v94; // xmm10
		  __int128 v95; // xmm11
		  __int128 v96; // xmm12
		  float spotAngle_Injected; // xmm13_4
		  float shadowNearPlane_Injected; // xmm8_4
		  float shadowFarPlane_Injected; // xmm7_4
		  float shadowGuardAngle_Injected; // xmm6_4
		  Matrix4x4__Array *v101; // rbx
		  Matrix4x4 *ShadowTransform; // rax
		  __int64 v103; // rdx
		  __int64 v104; // rcx
		  Object *v105; // rax
		  String *v106; // rax
		  Object *v107; // rdx
		  unsigned __int64 v108; // rdx
		  unsigned __int64 v109; // r8
		  char v110; // dl
		  signed __int64 v111; // rtt
		  Object *v112; // rbx
		  __int64 v113; // rdx
		  HGLightCookieManager__StaticFields *v114; // rcx
		  __int64 v115; // rdx
		  unsigned __int64 v116; // r8
		  signed __int64 v117; // rtt
		  Object *v118; // r8
		  HGLightCookieManager__StaticFields *v119; // rcx
		  unsigned __int64 v120; // rdx
		  unsigned __int64 v121; // r8
		  char v122; // dl
		  signed __int64 v123; // rtt
		  __int64 v124; // rdx
		  __int64 v125; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rbx
		  Vector2Int v127; // [rsp+50h] [rbp-3F8h] BYREF
		  HGSharedLightData _unity_self; // [rsp+58h] [rbp-3F0h] BYREF
		  Object *v129; // [rsp+60h] [rbp-3E8h] BYREF
		  NativeArray_1_System_Int32_ v130; // [rsp+70h] [rbp-3D8h] BYREF
		  RectInt value; // [rsp+80h] [rbp-3C8h] BYREF
		  Object *v132; // [rsp+90h] [rbp-3B8h] BYREF
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ v133; // [rsp+A0h] [rbp-3A8h] BYREF
		  RectInt v134; // [rsp+B0h] [rbp-398h] BYREF
		  NativeArray_1_System_Int32_ v135; // [rsp+C0h] [rbp-388h] BYREF
		  Matrix4x4 v136; // [rsp+D0h] [rbp-378h] BYREF
		  HGRenderGraphBuilder v137; // [rsp+110h] [rbp-338h] BYREF
		  Matrix4x4 v138; // [rsp+130h] [rbp-318h] BYREF
		  HGRenderGraphBuilder v139; // [rsp+170h] [rbp-2D8h] BYREF
		  HGRenderGraphBuilder v140; // [rsp+190h] [rbp-2B8h] BYREF
		  Il2CppExceptionWrapper *v141; // [rsp+1B0h] [rbp-298h] BYREF
		  Il2CppExceptionWrapper *v142; // [rsp+1B8h] [rbp-290h] BYREF
		  Matrix4x4 v143; // [rsp+1C0h] [rbp-288h] BYREF
		  Matrix4x4 v144; // [rsp+200h] [rbp-248h] BYREF
		  Matrix4x4 v145; // [rsp+240h] [rbp-208h] BYREF
		  Matrix4x4 v146; // [rsp+280h] [rbp-1C8h] BYREF
		  Matrix4x4 v147; // [rsp+2C0h] [rbp-188h] BYREF
		  __int128 v148; // [rsp+300h] [rbp-148h]
		  __int128 v149; // [rsp+310h] [rbp-138h]
		  __int128 v150; // [rsp+320h] [rbp-128h]
		  __int128 v151; // [rsp+330h] [rbp-118h]
		  __int128 v152; // [rsp+340h] [rbp-108h]
		  __int128 v153; // [rsp+350h] [rbp-F8h]
		  __int128 v154; // [rsp+360h] [rbp-E8h]
		  __int128 v155; // [rsp+370h] [rbp-D8h]
		  __int128 v156; // [rsp+380h] [rbp-C8h]
		  int v157; // [rsp+390h] [rbp-B8h]
		
		  v10 = (Object *)renderGraph;
		  v11 = this;
		  value = 0LL;
		  memset(&v139, 0, sizeof(v139));
		  v129 = 0LL;
		  memset(&v140, 0, sizeof(v140));
		  v132 = 0LL;
		  _unity_self = 0LL;
		  v134 = 0LL;
		  sub_18033B9D0(&v144, 0LL, 64LL);
		  sub_18033B9D0(&v145, 0LL, 64LL);
		  sub_18033B9D0(&v146, 0LL, 64LL);
		  sub_18033B9D0(&v143, 0LL, 64LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(1895, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1895, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v125, v124);
		    v135 = *lightIndices;
		    value = (RectInt)*visibleLights;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_762(
		      Patch,
		      (Object *)v11,
		      v10,
		      (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&value,
		      (Object *)hgCamera,
		      (Object *)settingParams,
		      &v135,
		      punctualLightCount,
		      0LL);
		  }
		  else if ( HG::Rendering::Runtime::HGLightCookieManager::IsLightCookiesEnabled(v11, settingParams, 0LL) )
		  {
		    v130 = *lightIndices;
		    v133 = *visibleLights;
		    HG::Rendering::Runtime::HGLightCookieManager::PrepareLightCookies(
		      v11,
		      &v133,
		      hgCamera,
		      settingParams,
		      &v130,
		      punctualLightCount,
		      0LL);
		    v133.m_Buffer = (Void *)v11->fields.m_cachedLightCookieAtlas;
		    m_texturesToBeAdded = v11->fields.m_texturesToBeAdded;
		    if ( !m_texturesToBeAdded )
		      sub_1800D8260(v13, v12);
		    if ( m_texturesToBeAdded->fields._size )
		    {
		      for ( i = 0; ; ++i )
		      {
		        v16 = v11->fields.m_texturesToBeAdded;
		        if ( !v16 )
		          sub_1800D8260(v13, v12);
		        if ( i >= v16->fields._size )
		          break;
		        Item = System::Collections::Generic::List<System::Object>::get_Item(
		                 (List_1_System_Object_ *)v11->fields.m_texturesToBeAdded,
		                 i,
		                 MethodInfo::System::Collections::Generic::List<UnityEngine::Texture>::get_Item);
		        v20 = Item;
		        if ( !v11->fields.m_activeLightCookies )
		          sub_1800D8260(v19, v18);
		        if ( System::Collections::Generic::Dictionary<System::Object,UnityEngine::RectInt>::TryGetValue(
		               (Dictionary_2_System_Object_UnityEngine_RectInt_ *)v11->fields.m_activeLightCookies,
		               Item,
		               &value,
		               MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::TryGetValue) )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
		          static_fields = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields;
		          s_srcTextures = static_fields->s_srcTextures;
		          if ( !s_srcTextures )
		            sub_1800D8260(static_fields, v23);
		          sub_180031B10(static_fields->s_srcTextures, v20);
		          sub_180378FEC(s_srcTextures, i, v20);
		          v27 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields;
		          s_srcDimensions = v27->s_srcDimensions;
		          if ( !v20 )
		            sub_1800D8260(v27, v26);
		          v127.m_X = sub_180002F70(5LL, v20);
		          v127.m_Y = sub_180002F70(7LL, v20);
		          if ( !s_srcDimensions )
		            sub_1800D8260(v30, v29);
		          if ( (unsigned int)i >= s_srcDimensions->max_length.size )
		            sub_1800D2AB0(v30, v29);
		          s_srcDimensions->vector[i] = v127;
		          s_dstPositions = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields->s_dstPositions;
		          xy = Unity::Mathematics::int3::get_xy((int3 *)&value, 0LL);
		          if ( !s_dstPositions )
		            sub_1800D8260(v34, v33);
		          if ( (unsigned int)i >= s_dstPositions->max_length.size )
		            sub_1800D2AB0(v34, v33);
		          s_dstPositions->vector[i] = (Vector2Int)xy;
		          s_dstDimensions = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields->s_dstDimensions;
		          size = UnityEngine::RectInt::get_size(&value, 0LL);
		          if ( !s_dstDimensions )
		            sub_1800D8260(v13, v12);
		          if ( (unsigned int)i >= s_dstDimensions->max_length.size )
		            sub_1800D2AB0(v13, v12);
		          s_dstDimensions->vector[i] = size;
		        }
		        else
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
		          v22 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields;
		          if ( !v22->s_srcTextures )
		            sub_1800D8260(v22, v21);
		          sub_180378FEC(v22->s_srcTextures, i, 0LL);
		        }
		      }
		      v37 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x72u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !v10 )
		        sub_1800D8260(v39, v38);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v137,
		        (HGRenderGraph *)v10,
		        (String *)"Update LightCookie Atlas",
		        &v129,
		        v37,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGLightCookieManager::UpdateLightCookieAtlasPassData>);
		      v139 = v137;
		      v130.m_Buffer = 0LL;
		      *(_QWORD *)&v130.m_Length = &v139;
		      try
		      {
		        v41 = v129;
		        if ( !v129 )
		          sub_1800D8250(v40, 0LL);
		        v129[1].klass = (Object__Class *)v133.m_Buffer;
		        if ( dword_18F35FD08 )
		        {
		          v42 = ((unsigned __int64)&v41[1] >> 12) & 0x1FFFFF;
		          v43 = v42 >> 6;
		          v44 = v42 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v43 + 36190]);
		          do
		            v45 = qword_18F0BCBA0[v43 + 36190];
		          while ( v45 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v43 + 36190], v45 | (1LL << v44), v45) );
		        }
		        v46 = v129;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
		        v48 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields;
		        if ( !v46 )
		          sub_1800D8250(v48, v47);
		        v46[2].klass = (Object__Class *)v48->s_srcTextures;
		        v49 = (unsigned int)dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v50 = (((unsigned __int64)&v46[2] >> 12) & 0x1FFFFF) >> 6;
		          _m_prefetchw(&qword_18F0BCBA0[v50 + 36190]);
		          do
		            v51 = qword_18F0BCBA0[v50 + 36190];
		          while ( v51 != _InterlockedCompareExchange64(
		                           &qword_18F0BCBA0[v50 + 36190],
		                           v51 | (1LL << (((unsigned __int64)&v46[2] >> 12) & 0x3F)),
		                           v51) );
		          v49 = (unsigned int)dword_18F35FD08;
		        }
		        v52 = v129;
		        v53 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields;
		        if ( !v129 )
		          sub_1800D8250(v53, v49);
		        v129[3].klass = (Object__Class *)v53->s_srcDimensions;
		        if ( (_DWORD)v49 )
		        {
		          v54 = ((unsigned __int64)&v52[3] >> 12) & 0x1FFFFF;
		          v55 = v54 >> 6;
		          v56 = v54 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v55 + 36190]);
		          do
		            v57 = qword_18F0BCBA0[v55 + 36190];
		          while ( v57 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v55 + 36190], v57 | (1LL << v56), v57) );
		          v49 = (unsigned int)dword_18F35FD08;
		        }
		        v58 = v129;
		        v59 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields;
		        if ( !v129 )
		          sub_1800D8250(v59, v49);
		        v129[3].monitor = (MonitorData *)v59->s_dstDimensions;
		        if ( (_DWORD)v49 )
		        {
		          v60 = ((unsigned __int64)&v58[3].monitor >> 12) & 0x1FFFFF;
		          v61 = v60 >> 6;
		          v62 = v60 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v61 + 36190]);
		          do
		            v63 = qword_18F0BCBA0[v61 + 36190];
		          while ( v63 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v61 + 36190], v63 | (1LL << v62), v63) );
		          v49 = (unsigned int)dword_18F35FD08;
		        }
		        v64 = v129;
		        v65 = (signed __int64)TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields;
		        if ( !v129 )
		          sub_1800D8250(v65, v49);
		        v129[2].monitor = *(MonitorData **)(v65 + 32);
		        if ( (_DWORD)v49 )
		        {
		          v66 = ((unsigned __int64)&v64[2].monitor >> 12) & 0x1FFFFF;
		          v67 = v66 >> 6;
		          v49 = v66 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v67 + 36190]);
		          do
		          {
		            v65 = qword_18F0BCBA0[v67 + 36190] | (1LL << v49);
		            v68 = qword_18F0BCBA0[v67 + 36190];
		          }
		          while ( v68 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v67 + 36190], v65, v68) );
		        }
		        v69 = v11->fields.m_texturesToBeAdded;
		        if ( !v69 )
		          sub_1800D8250(v65, v49);
		        v70 = (unsigned int)v69->fields._size;
		        if ( !v129 )
		          sub_1800D8250(v70, v49);
		        LODWORD(v129[1].monitor) = v70;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v139,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields->s_updateLightCookieAtlasRenderFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGLightCookieManager::UpdateLightCookieAtlasPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v141 )
		      {
		        v130.m_Buffer = (Void *)v141->ex;
		        sub_180268AE0(&v130);
		        v10 = (Object *)renderGraph;
		        v11 = this;
		        goto LABEL_51;
		      }
		      sub_180268AE0(&v130);
		    }
		LABEL_51:
		    v71 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x73u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !v10 )
		      sub_1800D8250(v73, v72);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v137,
		      (HGRenderGraph *)v10,
		      (String *)"LightCookie SetData Pass",
		      &v132,
		      v71,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGLightCookieManager::LightCookieSetDataPassData>);
		    v140 = v137;
		    *(_QWORD *)&value.m_XMin = 0LL;
		    *(_QWORD *)&value.m_Width = &v140;
		    try
		    {
		      m_lightSlots = (Dictionary_2_Beyond_Gameplay_WorldSetting_MissionImportanceAndType_System_Object_ *)v11->fields.m_lightSlots;
		      if ( !m_lightSlots )
		        sub_1800D8250(0LL, v74);
		      System::Collections::Generic::Dictionary<Beyond::Gameplay::WorldSetting::MissionImportanceAndType,System::Object>::Clear(
		        m_lightSlots,
		        MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,int>::Clear);
		      v77 = 0;
		      for ( j = 0; ; j = v127.m_X + 1 )
		      {
		        v127.m_X = j;
		        if ( j >= punctualLightCount )
		          break;
		        v79 = &visibleLights->m_Buffer[148 * *(int *)&lightIndices->m_Buffer[4 * j]];
		        v148 = *(_OWORD *)v79;
		        v149 = *(_OWORD *)&v79[16];
		        v150 = *(_OWORD *)&v79[32];
		        v151 = *(_OWORD *)&v79[48];
		        v152 = *(_OWORD *)&v79[64];
		        v153 = *(_OWORD *)&v79[80];
		        v154 = *(_OWORD *)&v79[96];
		        v155 = *(_OWORD *)&v79[112];
		        v156 = *(_OWORD *)&v79[128];
		        v157 = *(_DWORD *)&v79[144];
		        _unity_self = (HGSharedLightData)*((_QWORD *)&v156 + 1);
		        Entity = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(
		                   *(HGSharedLightData *)((char *)&v156 + 8),
		                   0LL);
		        cookie_Injected = (Object *)UnityEngine::HGSharedLightData::get_cookie_Injected(&_unity_self, 0LL);
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        if ( UnityEngine::Object::op_Inequality((Object_1 *)cookie_Injected, 0LL, 0LL) )
		        {
		          m_activeLightCookies = (Dictionary_2_System_Object_UnityEngine_RectInt_ *)v11->fields.m_activeLightCookies;
		          if ( !m_activeLightCookies )
		            sub_1800D8250(0LL, v82);
		          if ( System::Collections::Generic::Dictionary<System::Object,UnityEngine::RectInt>::TryGetValue(
		                 m_activeLightCookies,
		                 cookie_Injected,
		                 &v134,
		                 MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::Texture,UnityEngine::RectInt>::TryGetValue) )
		          {
		            if ( v77 >= 32 )
		            {
		              v127.m_X = 32;
		              v105 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v127);
		              v106 = System::String::Format(
		                       (String *)"HGLightCookieManager: 当前使用Light Cookie的灯已经超过{0}盏，请灯光师检查状态",
		                       v105,
		                       0LL);
		              HG::Rendering::HGRPLogger::LogError(v106, 0LL);
		              break;
		            }
		            v85 = v11->fields.m_lightSlots;
		            if ( !v85 )
		              sub_1800D8250(0LL, v84);
		            System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,int>::Add(
		              v85,
		              Entity,
		              v77,
		              MethodInfo::System::Collections::Generic::Dictionary<UnityEngine::HyperGryph::ECS::Entity,int>::Add);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
		            s_lightCookieData = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields->s_lightCookieData;
		            *(float *)&v130.m_Buffer = (float)v134.m_XMin * 0.00024414062;
		            *((float *)&v130.m_Buffer + 1) = (float)v134.m_YMin * 0.00024414062;
		            *(float *)&v130.m_Length = (float)v134.m_Width * 0.00024414062;
		            *(float *)&v130.m_AllocatorLabel = (float)v134.m_Height * 0.00024414062;
		            if ( !s_lightCookieData )
		              sub_1800D8250(0LL, v86);
		            v135 = v130;
		            sub_18003FEF0(s_lightCookieData, v77, &v135);
		            if ( UnityEngine::HGSharedLightData::get_type_Injected(&_unity_self, 0LL) )
		            {
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
		              s_lightCookieMatricesData = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields->s_lightCookieMatricesData;
		              v143 = *UnityEngine::HGSharedLightData::get_localToWorldMatrix(&v138, &_unity_self, 0LL);
		              v135 = (NativeArray_1_System_Int32_)*UnityEngine::Matrix4x4::get_rotation((Quaternion *)&v137, &v143, 0LL);
		              v89 = UnityEngine::Matrix4x4::Rotate(&v138, (Quaternion *)&v135, 0LL);
		              if ( !s_lightCookieMatricesData )
		                sub_1800D8250(v91, v90);
		              v136 = *v89;
		              sub_180041540(s_lightCookieMatricesData, v77, &v136);
		            }
		            else
		            {
		              localToWorldMatrix = UnityEngine::HGSharedLightData::get_localToWorldMatrix(&v138, &_unity_self, 0LL);
		              v93 = *(_OWORD *)&localToWorldMatrix->m00;
		              v94 = *(_OWORD *)&localToWorldMatrix->m01;
		              v95 = *(_OWORD *)&localToWorldMatrix->m02;
		              v96 = *(_OWORD *)&localToWorldMatrix->m03;
		              spotAngle_Injected = UnityEngine::HGSharedLightData::get_spotAngle_Injected(&_unity_self, 0LL);
		              shadowNearPlane_Injected = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&_unity_self, 0LL);
		              shadowFarPlane_Injected = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&_unity_self, 0LL);
		              shadowGuardAngle_Injected = UnityEngine::HGSharedLightData::get_shadowGuardAngle_Injected(
		                                            &_unity_self,
		                                            0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		              *(_OWORD *)&v136.m00 = v93;
		              *(_OWORD *)&v136.m01 = v94;
		              *(_OWORD *)&v136.m02 = v95;
		              *(_OWORD *)&v136.m03 = v96;
		              HG::Rendering::Runtime::HGShadowUtils::ExtractSpotLightMatrix(
		                &v138,
		                &v136,
		                spotAngle_Injected,
		                shadowNearPlane_Injected,
		                shadowFarPlane_Injected,
		                shadowGuardAngle_Injected,
		                &v144,
		                &v145,
		                &v146,
		                0LL);
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
		              v101 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields->s_lightCookieMatricesData;
		              v136 = v144;
		              v138 = v145;
		              ShadowTransform = HG::Rendering::Runtime::HGShadowUtils::GetShadowTransform(&v147, &v138, &v136, 0LL);
		              if ( !v101 )
		                sub_1800D8250(v104, v103);
		              v138 = *ShadowTransform;
		              sub_180041540(v101, v77, &v138);
		            }
		            ++v77;
		          }
		        }
		      }
		      v107 = v132;
		      if ( !v132 )
		        sub_1800D8250(v76, 0LL);
		      v132[1].klass = (Object__Class *)v133.m_Buffer;
		      if ( dword_18F35FD08 )
		      {
		        v108 = ((unsigned __int64)&v107[1] >> 12) & 0x1FFFFF;
		        v109 = v108 >> 6;
		        v110 = v108 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v109 + 36190]);
		        do
		          v111 = qword_18F0BCBA0[v109 + 36190];
		        while ( v111 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v109 + 36190], v111 | (1LL << v110), v111) );
		      }
		      v112 = v132;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGLightCookieManager);
		      v114 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields;
		      if ( !v112 )
		        sub_1800D8250(v114, v113);
		      v112[1].monitor = (MonitorData *)v114->s_lightCookieData;
		      v115 = (unsigned int)dword_18F35FD08;
		      if ( dword_18F35FD08 )
		      {
		        v116 = (((unsigned __int64)&v112[1].monitor >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v116 + 36190]);
		        do
		          v117 = qword_18F0BCBA0[v116 + 36190];
		        while ( v117 != _InterlockedCompareExchange64(
		                          &qword_18F0BCBA0[v116 + 36190],
		                          v117 | (1LL << (((unsigned __int64)&v112[1].monitor >> 12) & 0x3F)),
		                          v117) );
		        v115 = (unsigned int)dword_18F35FD08;
		      }
		      v118 = v132;
		      v119 = TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields;
		      if ( !v132 )
		        sub_1800D8250(v119, v115);
		      v132[2].klass = (Object__Class *)v119->s_lightCookieMatricesData;
		      if ( (_DWORD)v115 )
		      {
		        v120 = ((unsigned __int64)&v118[2] >> 12) & 0x1FFFFF;
		        v121 = v120 >> 6;
		        v122 = v120 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v121 + 36190]);
		        do
		          v123 = qword_18F0BCBA0[v121 + 36190];
		        while ( v123 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v121 + 36190], v123 | (1LL << v122), v123) );
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v140,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGLightCookieManager->static_fields->s_lightCookieSetDataPassRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGLightCookieManager::LightCookieSetDataPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v142 )
		    {
		      *(Il2CppExceptionWrapper *)&value.m_XMin = (Il2CppExceptionWrapper)v142->ex;
		    }
		    sub_180268AE0(&value);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGLightCookieManager::InvalidateAllLightCookies(v11, 0LL);
		  }
		}
		
	}
}
