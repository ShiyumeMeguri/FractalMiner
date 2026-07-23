using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryph.ECS;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGPunctualLightShadowManagerV2 // TypeDefIndex: 37859
	{
		// Fields
		private float m_punctualLightShadowScreenSizeMinSquared; // 0x10
		private float m_punctualLightForceCullDistance; // 0x14
		private static int s_maxShadowCasterCount; // 0x00
		private int m_punctualShadowAtlasBaseTileSize; // 0x18
		private int m_dynamicEnvPunctualShadowCasterCount; // 0x1C
		private int m_dynamicMovablePunctualShadowCasterCount; // 0x20
		private Vector2Int m_punctualShadowAtlasSize; // 0x24
		internal HGPunctualLightStaticAtlasAllocator punctualLightStaticAtlasAllocator; // 0x30
		internal Dictionary<LightCaster, PunctualLightCachedShadowDesc> m_activePunctualLightCachedShadowDescs; // 0x38
		private Dictionary<LightCaster, int> m_targetPunctualAtlasAllocationThisFrame; // 0x40
		private PunctualLightCacheUpdateRequest m_targetUpdateRequest; // 0x48
		private List<LightCaster> m_castersToBeRemoved; // 0x50
		private RTHandle m_cachedPunctualLightShadowAtlas; // 0x58
		private static Material s_clearShadowMaterial; // 0x08
		private Matrix4x4[] m_punctualLightWorldToShadowMatrices; // 0x60
		private Vector4[] m_punctualLightShadowParams; // 0x68
		private Vector4[] m_punctualLightShadowParams2; // 0x70
		private Entity[] m_targetStaticPunctualLights; // 0x78
		private LightCaster[] m_targetDynamicPunctualLights; // 0x80
		private static readonly RenderFunc<PunctualLightShadowPassData> s_punctualLightShadowMapRenderFunc; // 0x10
		private static readonly RenderFunc<PunctualLightShadowPushDataPassData> s_punctualLightShadowMapSkipRenderFunc; // 0x18
		private static readonly RenderFunc<PunctualLightShadowPushDataPassData> s_punctualLightShadowMapPushDataFunc; // 0x20
		private static Plane[] s_cullPlanes; // 0x28
	
		// Properties
		private int m_dynamicPunctualShadowCasterCount { get => default; } // 0x0000000189B4F6CC-0x0000000189B4F71C 
		// Int32 get_m_dynamicPunctualShadowCasterCount()
		int32_t HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::get_m_dynamicPunctualShadowCasterCount(
		        HGPunctualLightShadowManagerV2 *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1922, 0LL) )
		    return this->fields.m_dynamicEnvPunctualShadowCasterCount + this->fields.m_dynamicMovablePunctualShadowCasterCount;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1922, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Nested types
		internal struct PunctualLightCachedShadowDesc // TypeDefIndex: 37853
		{
			// Fields
			public int targetRenderLevel; // 0x00
			public bool isShadowCached; // 0x04
			public float lastVisitedTime; // 0x08
			public int shadowCacheSlotIndex; // 0x0C
		}
	
		private enum PunctualLightCacheUpdateRequestType // TypeDefIndex: 37854
		{
			None = 0,
			AllocNewChunk = 1,
			SmallChunkToLargeChunk = 2,
			LargeChunkToSmallChunk = 3
		}
	
		private class PunctualLightCacheUpdateRequest // TypeDefIndex: 37855
		{
			// Fields
			public PunctualLightCacheUpdateRequestType requestType; // 0x10
			public LightCaster requestLightCaster; // 0x14
			public int sourceSlot; // 0x24
			public int targetLevel; // 0x28
			public int targetSlot; // 0x2C
	
			// Constructors
			public PunctualLightCacheUpdateRequest() {} // 0x0000000184DA1460-0x0000000184DA1470
			// HGPunctualLightShadowManagerV2+PunctualLightCacheUpdateRequest()
			void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCacheUpdateRequest::PunctualLightCacheUpdateRequest(
			        HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *this,
			        MethodInfo *method)
			{
			  *(_QWORD *)&this->fields.sourceSlot = -1LL;
			  this->fields.targetSlot = -1;
			}
			
		}
	
		private class PunctualLightShadowPassData // TypeDefIndex: 37856
		{
			// Fields
			public HGCamera hgCamera; // 0x10
			public CullingResults cullingResults; // 0x18
			public float shadowBias; // 0x28
			public RectInt renderRegion; // 0x2C
			public Matrix4x4 deviceProjYFlip; // 0x3C
			public Matrix4x4 view; // 0x7C
			public uint ecsShadowRendererList; // 0xBC
			public uint ecsShadowGrassList; // 0xC0
			public uint ecsShadowTreeList; // 0xC4
			public RendererList rendererList; // 0xC8
			public TextureHandle punctualLightCachedAtlas; // 0xD8
			public Material blitShadowMaterial; // 0xE8
			public Material clearShadowMaterial; // 0xF0
	
			// Constructors
			public PunctualLightShadowPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		private class PunctualLightShadowPushDataPassData // TypeDefIndex: 37857
		{
			// Fields
			public TextureHandle punctualLightCachedAtlas; // 0x10
			public Matrix4x4[] punctualLightWorldToShadowMatrices; // 0x20
			public Vector4[] punctualLightShadowParams; // 0x28
			public Vector4[] punctualLightShadowParams2; // 0x30
			public Vector2Int punctualLightCachedAtlasSize; // 0x38
	
			// Constructors
			public PunctualLightShadowPushDataPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public HGPunctualLightShadowManagerV2() {} // 0x000000018434B670-0x000000018434B8C0
		// HGPunctualLightShadowManagerV2()
		void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::HGPunctualLightShadowManagerV2(
		        HGPunctualLightShadowManagerV2 *this,
		        MethodInfo *method)
		{
		  Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *v10; // rax
		  Dictionary_2_HG_Rendering_Runtime_LightCaster_System_Int32_ *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  __int64 v15; // rax
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  LowLevelList_1_System_Object_ *v18; // rax
		  List_1_HG_Rendering_Runtime_LightCaster_ *v19; // rdi
		  Type *v20; // rdx
		  PropertyInfo_1 *v21; // r8
		  Int32__Array **v22; // r9
		  struct HGPunctualLightShadowManagerV2__Class *v23; // rax
		  Type *v24; // rdx
		  PropertyInfo_1 *v25; // r8
		  Int32__Array **v26; // r9
		  Type *v27; // rdx
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  Type *v30; // rdx
		  PropertyInfo_1 *v31; // r8
		  Int32__Array **v32; // r9
		  Type *v33; // rdx
		  PropertyInfo_1 *v34; // r8
		  Int32__Array **v35; // r9
		  Type *v36; // rdx
		  PropertyInfo_1 *v37; // r8
		  Int32__Array **v38; // r9
		  int32_t m_punctualShadowAtlasBaseTileSize; // esi
		  HGPunctualLightStaticAtlasAllocator *v40; // rax
		  HGPunctualLightStaticAtlasAllocator *v41; // rdi
		  Type *v42; // rdx
		  PropertyInfo_1 *v43; // r8
		  Int32__Array **v44; // r9
		  MethodInfo *v45; // [rsp+20h] [rbp-8h]
		  MethodInfo *v46; // [rsp+20h] [rbp-8h]
		  MethodInfo *v47; // [rsp+20h] [rbp-8h]
		  MethodInfo *v48; // [rsp+20h] [rbp-8h]
		  MethodInfo *v49; // [rsp+20h] [rbp-8h]
		  MethodInfo *v50; // [rsp+20h] [rbp-8h]
		  MethodInfo *v51; // [rsp+20h] [rbp-8h]
		  MethodInfo *v52; // [rsp+20h] [rbp-8h]
		  MethodInfo *v53; // [rsp+20h] [rbp-8h]
		  MethodInfo *v54; // [rsp+50h] [rbp+28h]
		
		  this->fields.m_punctualLightShadowScreenSizeMinSquared = 0.001;
		  this->fields.m_punctualLightForceCullDistance = 200.0;
		  this->fields.m_punctualShadowAtlasBaseTileSize = -1;
		  this->fields.m_dynamicEnvPunctualShadowCasterCount = 6;
		  this->fields.m_dynamicMovablePunctualShadowCasterCount = 2;
		  this->fields.m_punctualShadowAtlasSize = TypeInfo::UnityEngine::Vector2Int->static_fields->s_Zero;
		  v3 = (Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>);
		  v6 = v3;
		  if ( !v3 )
		    goto LABEL_9;
		  System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Dictionary(
		    v3,
		    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Dictionary);
		  this->fields.m_activePunctualLightCachedShadowDescs = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_activePunctualLightCachedShadowDescs, v7, v8, v9, v45);
		  v10 = (Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>);
		  v11 = (Dictionary_2_HG_Rendering_Runtime_LightCaster_System_Int32_ *)v10;
		  if ( !v10 )
		    goto LABEL_9;
		  System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Dictionary(
		    v10,
		    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::Dictionary);
		  this->fields.m_targetPunctualAtlasAllocationThisFrame = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_targetPunctualAtlasAllocationThisFrame, v12, v13, v14, v46);
		  v15 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCacheUpdateRequest);
		  if ( !v15 )
		    goto LABEL_9;
		  *(_QWORD *)(v15 + 36) = -1LL;
		  *(_DWORD *)(v15 + 44) = -1;
		  this->fields.m_targetUpdateRequest = (HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *)v15;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_targetUpdateRequest, v4, v16, v17, v47);
		  v18 = (LowLevelList_1_System_Object_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::LightCaster>);
		  v19 = (List_1_HG_Rendering_Runtime_LightCaster_ *)v18;
		  if ( !v18 )
		    goto LABEL_9;
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v18,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::LightCaster>::List);
		  this->fields.m_castersToBeRemoved = v19;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_castersToBeRemoved, v20, v21, v22, v48);
		  v23 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		    v23 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2;
		  }
		  this->fields.m_punctualLightWorldToShadowMatrices = (Matrix4x4__Array *)il2cpp_array_new_specific_1(
		                                                                            TypeInfo::UnityEngine::Matrix4x4,
		                                                                            v23->static_fields->s_maxShadowCasterCount);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_punctualLightWorldToShadowMatrices, v24, v25, v26, v49);
		  this->fields.m_punctualLightShadowParams = (Vector4__Array *)il2cpp_array_new_specific_1(
		                                                                 TypeInfo::UnityEngine::Vector4,
		                                                                 TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_maxShadowCasterCount);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_punctualLightShadowParams, v27, v28, v29, v50);
		  this->fields.m_punctualLightShadowParams2 = (Vector4__Array *)il2cpp_array_new_specific_1(
		                                                                  TypeInfo::UnityEngine::Vector4,
		                                                                  TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_maxShadowCasterCount);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_punctualLightShadowParams2, v30, v31, v32, v51);
		  this->fields.m_targetStaticPunctualLights = (Entity_1__Array *)il2cpp_array_new_specific_1(
		                                                                   TypeInfo::UnityEngine::HyperGryph::ECS::Entity,
		                                                                   40LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_targetStaticPunctualLights, v33, v34, v35, v52);
		  this->fields.m_targetDynamicPunctualLights = (LightCaster__Array *)il2cpp_array_new_specific_1(
		                                                                       TypeInfo::HG::Rendering::Runtime::LightCaster,
		                                                                       32LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_targetDynamicPunctualLights, v36, v37, v38, v53);
		  m_punctualShadowAtlasBaseTileSize = this->fields.m_punctualShadowAtlasBaseTileSize;
		  v40 = (HGPunctualLightStaticAtlasAllocator *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator);
		  v41 = v40;
		  if ( !v40 )
		LABEL_9:
		    sub_1800D8260(v5, v4);
		  HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::HGPunctualLightStaticAtlasAllocator(
		    v40,
		    3,
		    4 * m_punctualShadowAtlasBaseTileSize,
		    0LL);
		  this->fields.punctualLightStaticAtlasAllocator = v41;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.punctualLightStaticAtlasAllocator, v42, v43, v44, v54);
		}
		
		static HGPunctualLightShadowManagerV2() {} // 0x0000000184A3FBF0-0x0000000184A3FDA0
		// HGPunctualLightShadowManagerV2()
		void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::cctor(MethodInfo *method)
		{
		  struct HGPunctualLightShadowManagerV2_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_System_Object_ *v6; // rbx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  Object *v10; // rdi
		  RenderFunc_1_System_Object_ *v11; // rax
		  Type__Class *v12; // rbx
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  Object *v16; // rdi
		  RenderFunc_1_System_Object_ *v17; // rax
		  MonitorData *v18; // rbx
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  __int64 v22; // rax
		  Type *v23; // rdx
		  PropertyInfo_1 *v24; // r8
		  Int32__Array **v25; // r9
		  MethodInfo *v26; // [rsp+20h] [rbp-8h]
		  MethodInfo *v27; // [rsp+20h] [rbp-8h]
		  MethodInfo *v28; // [rsp+20h] [rbp-8h]
		  MethodInfo *v29; // [rsp+50h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_maxShadowCasterCount = 56;
		  v1 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPassData>);
		  v6 = v3;
		  if ( !v3 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::__c::__cctor_b__49_0,
		    0LL);
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields;
		  static_fields->fields._impl.value = v6;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_punctualLightShadowMapRenderFunc,
		    static_fields,
		    v8,
		    v9,
		    v26);
		  v10 = (Object *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::__c->static_fields->__9;
		  v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPushDataPassData>);
		  v12 = (Type__Class *)v11;
		  if ( !v11
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v11,
		          v10,
		          MethodInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::__c::__cctor_b__49_1,
		          0LL),
		        v13 = (Type *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields,
		        v13[1].klass = v12,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_punctualLightShadowMapSkipRenderFunc,
		          v13,
		          v14,
		          v15,
		          v27),
		        v16 = (Object *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::__c->static_fields->__9,
		        v17 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPushDataPassData>),
		        (v18 = (MonitorData *)v17) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v17,
		    v16,
		    MethodInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::__c::__cctor_b__49_2,
		    0LL);
		  v19 = (Type *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields;
		  v19[1].monitor = v18;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_punctualLightShadowMapPushDataFunc,
		    v19,
		    v20,
		    v21,
		    v28);
		  v22 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Plane, 6LL);
		  v23 = (Type *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields;
		  v23[1].fields._impl.value = (void *)v22;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_cullPlanes,
		    v23,
		    v24,
		    v25,
		    v29);
		}
		
	
		// Methods
		internal bool IsLightRenderingDynamicPunctualLight(Entity lightEntity) => default; // 0x0000000189B489D4-0x0000000189B48A98
		// Boolean IsLightRenderingDynamicPunctualLight(Entity)
		bool HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::IsLightRenderingDynamicPunctualLight(
		        HGPunctualLightShadowManagerV2 *this,
		        Entity_1 lightEntity,
		        MethodInfo *method)
		{
		  int v5; // ebp
		  __int64 v6; // rdx
		  LightCaster__Array *m_targetDynamicPunctualLights; // rcx
		  Entity_1 v8; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2180, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2180, 0LL);
		    if ( !Patch )
		LABEL_9:
		      sub_1800D8260(m_targetDynamicPunctualLights, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_873(Patch, (Object *)this, lightEntity, 0LL);
		  }
		  else
		  {
		    v5 = 0;
		    if ( HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::get_m_dynamicPunctualShadowCasterCount(this, 0LL) <= 0 )
		    {
		      return 0;
		    }
		    else
		    {
		      while ( 1 )
		      {
		        m_targetDynamicPunctualLights = this->fields.m_targetDynamicPunctualLights;
		        if ( !m_targetDynamicPunctualLights )
		          goto LABEL_9;
		        v8 = *(Entity_1 *)sub_1803C0774(m_targetDynamicPunctualLights, v5);
		        sub_1800036A0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		        if ( UnityEngine::HyperGryph::ECS::Entity::op_Equality(v8, lightEntity, 0LL) )
		          return 1;
		        if ( ++v5 >= HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::get_m_dynamicPunctualShadowCasterCount(
		                       this,
		                       0LL) )
		          return 0;
		      }
		    }
		  }
		}
		
		internal bool IsLightShadowBaked(Entity lightEntity) => default; // 0x0000000189B48A98-0x0000000189B48C3C
		// Boolean IsLightShadowBaked(Entity)
		// Hidden C++ exception states: #wind=1
		bool HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::IsLightShadowBaked(
		        HGPunctualLightShadowManagerV2 *this,
		        Entity_1 lightEntity,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  bool v7; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  Il2CppException *ex; // [rsp+20h] [rbp-B8h]
		  LightCaster key; // [rsp+30h] [rbp-A8h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_System_Text_RegularExpressions_Regex_CachedCodeEntryKey_System_Object_ v15; // [rsp+40h] [rbp-98h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ v16; // [rsp+78h] [rbp-60h] BYREF
		  Il2CppExceptionWrapper *v17; // [rsp+B0h] [rbp-28h] BYREF
		  HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc value; // [rsp+B8h] [rbp-20h] BYREF
		
		  key = 0LL;
		  value = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2181, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2181, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_873(Patch, (Object *)this, lightEntity, 0LL);
		  }
		  if ( !this->fields.m_activePunctualLightCachedShadowDescs )
		    sub_1800D8260(v6, v5);
		  System::Collections::Generic::Dictionary<System::Text::RegularExpressions::Regex::CachedCodeEntryKey,System::Object>::GetEnumerator(
		    &v15,
		    (Dictionary_2_System_Text_RegularExpressions_Regex_CachedCodeEntryKey_System_Object_ *)this->fields.m_activePunctualLightCachedShadowDescs,
		    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::GetEnumerator);
		  v16 = (Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_)v15;
		  while ( 1 )
		  {
		    try
		    {
		      v7 = System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::MoveNext(
		             &v16,
		             MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::MoveNext);
		    }
		    catch ( Il2CppExceptionWrapper *v17 )
		    {
		      ex = v17->ex;
		      if ( ex )
		        sub_18007E1E0(ex);
		      return 0;
		    }
		    if ( !v7 )
		      return 0;
		    *(LightCaster *)&v15._dictionary = v16._current.key;
		    *(HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc *)&v15._current.key._options = v16._current.value;
		    System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Deconstruct(
		      (KeyValuePair_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)&v15,
		      &key,
		      &value,
		      MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Deconstruct);
		    sub_1800036A0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		    if ( UnityEngine::HyperGryph::ECS::Entity::op_Equality(key.lightEntity, lightEntity, 0LL) )
		      return 1;
		  }
		}
		
		internal static void Initialize(HGRenderPipelineRuntimeResources renderPipelineResources) {} // 0x00000001848ADDD0-0x00000001848ADE80
		// Void Initialize(HGRenderPipelineRuntimeResources)
		void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::Initialize(
		        HGRenderPipelineRuntimeResources *renderPipelineResources,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  Shader *shadowClearPS; // rbx
		  Material *StaticMaterial; // rax
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  struct HGPunctualLightShadowManagerV2__Class *v10; // rcx
		  MonitorData *v11; // rbx
		  Type *static_fields; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v14; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2128, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2128, 0LL);
		    if ( !Patch )
		      goto LABEL_4;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)renderPipelineResources,
		      0LL);
		  }
		  else
		  {
		    if ( !renderPipelineResources || (shaders = renderPipelineResources->fields.shaders) == 0LL )
		LABEL_4:
		      sub_1800D8260(v4, v3);
		    shadowClearPS = shaders->fields.shadowClearPS;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
		    StaticMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
		                       shadowClearPS,
		                       0,
		                       0LL);
		    v10 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2;
		    v11 = (MonitorData *)StaticMaterial;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		      v10 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2;
		    }
		    static_fields = (Type *)v10->static_fields;
		    static_fields->monitor = v11;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_clearShadowMaterial,
		      static_fields,
		      v8,
		      v9,
		      v14);
		  }
		}
		
		internal void Release() {} // 0x00000001849D3720-0x00000001849D3750
		// Void Release()
		void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::Release(
		        HGPunctualLightShadowManagerV2 *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(549, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(549, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else if ( this->fields.m_cachedPunctualLightShadowAtlas )
		  {
		    UnityEngine::Rendering::RTHandle::Release(this->fields.m_cachedPunctualLightShadowAtlas, 0LL);
		  }
		}
		
		public void InvalidateAllShadowCaches() {} // 0x0000000189B4890C-0x0000000189B489D4
		// Void InvalidateAllShadowCaches()
		void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::InvalidateAllShadowCaches(
		        HGPunctualLightShadowManagerV2 *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  HGPunctualLightStaticAtlasAllocator *punctualLightStaticAtlasAllocator; // rcx
		  int v5; // edi
		  LightCaster__Array *m_targetDynamicPunctualLights; // rsi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v8; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1943, 0LL) )
		  {
		    punctualLightStaticAtlasAllocator = this->fields.punctualLightStaticAtlasAllocator;
		    if ( punctualLightStaticAtlasAllocator )
		    {
		      HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::FreeAll(punctualLightStaticAtlasAllocator, 0LL);
		      punctualLightStaticAtlasAllocator = (HGPunctualLightStaticAtlasAllocator *)this->fields.m_activePunctualLightCachedShadowDescs;
		      if ( punctualLightStaticAtlasAllocator )
		      {
		        System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
		          (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)punctualLightStaticAtlasAllocator,
		          MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Clear);
		        v5 = 0;
		        while ( 1 )
		        {
		          m_targetDynamicPunctualLights = this->fields.m_targetDynamicPunctualLights;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		          punctualLightStaticAtlasAllocator = (HGPunctualLightStaticAtlasAllocator *)TypeInfo::HG::Rendering::Runtime::LightCaster->static_fields;
		          if ( !m_targetDynamicPunctualLights )
		            break;
		          v8 = *(_OWORD *)&punctualLightStaticAtlasAllocator->klass;
		          sub_180430AC4(m_targetDynamicPunctualLights, v5++, &v8);
		          if ( v5 >= 4 )
		            return;
		        }
		      }
		    }
		LABEL_9:
		    sub_1800D8260(punctualLightStaticAtlasAllocator, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1943, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private bool IsPunctualLightShadowEnabled(HGSettingParameters settingParams) => default; // 0x0000000189B48C3C-0x0000000189B48CE0
		// Boolean IsPunctualLightShadowEnabled(HGSettingParameters)
		bool HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::IsPunctualLightShadowEnabled(
		        HGPunctualLightShadowManagerV2 *this,
		        HGSettingParameters *settingParams,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGGraphicsFeatureSwitch *punctualLightShadow; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1941, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1941, 0LL);
		    if ( !Patch )
		      goto LABEL_8;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5(
		             (ILFixDynamicMethodWrapper_33 *)Patch,
		             (Object *)this,
		             (Object *)settingParams,
		             0LL);
		  }
		  else
		  {
		    if ( !settingParams )
		      goto LABEL_8;
		    if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		           settingParams->fields._punctualLightShadowEnabled_k__BackingField,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		      punctualLightShadow = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->static_fields->punctualLightShadow;
		      if ( punctualLightShadow )
		        return HG::Rendering::Runtime::HGGraphicsFeatureSwitch::get_enabledForCPUCommands(punctualLightShadow, 0LL);
		LABEL_8:
		      sub_1800D8260(punctualLightShadow, v5);
		    }
		    return 0;
		  }
		}
		
		private bool LightConsiderAsSpotlight(HGSharedLightData curLight) => default; // 0x0000000189B48CE0-0x0000000189B48D50
		// Boolean LightConsiderAsSpotlight(HGSharedLightData)
		bool HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::LightConsiderAsSpotlight(
		        HGPunctualLightShadowManagerV2 *this,
		        HGSharedLightData curLight,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  HGSharedLightData _unity_self; // [rsp+38h] [rbp+10h] BYREF
		
		  _unity_self = curLight;
		  if ( IFix::WrappersManagerImpl::IsPatched(1954, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1954, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_783(Patch, (Object *)this, _unity_self, 0LL);
		  }
		  else
		  {
		    return UnityEngine::HGSharedLightData::get_type_Injected(&_unity_self, 0LL) == LightType__Enum_Spot
		        || UnityEngine::HGSharedLightData::get_enableOverrideShadowLight_Injected(&_unity_self, 0LL);
		  }
		}
		
		private void AppendNewDynamicPunctualLight(HGSharedLightData curLight, LightCaster targetCaster, bool isCinematicMode, ref int currentDynamicSlotIndex, ref int currentEnvDynamicCasterCount, ref int currentMovableDynamicCasterCount) {} // 0x0000000189B47EDC-0x0000000189B4803C
		// Void AppendNewDynamicPunctualLight(HGSharedLightData, LightCaster, Boolean, Int32 ByRef, Int32 ByRef, Int32 ByRef)
		void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::AppendNewDynamicPunctualLight(
		        HGPunctualLightShadowManagerV2 *this,
		        HGSharedLightData curLight,
		        LightCaster *targetCaster,
		        bool isCinematicMode,
		        int32_t *currentDynamicSlotIndex,
		        int32_t *currentEnvDynamicCasterCount,
		        int32_t *currentMovableDynamicCasterCount,
		        MethodInfo *method)
		{
		  int32_t *v11; // rdi
		  int32_t v12; // ebx
		  __int64 v13; // rdx
		  bool isDynamicShadowCaster; // al
		  int32_t *v15; // rbx
		  int32_t *v16; // r14
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  __int64 v18; // rdx
		  __int64 v19; // rdx
		  LightCaster v20; // [rsp+50h] [rbp-10h] BYREF
		  HGSharedLightData v21; // [rsp+88h] [rbp+28h] BYREF
		
		  v21 = curLight;
		  if ( IFix::WrappersManagerImpl::IsPatched(1955, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1955, 0LL);
		    if ( Patch )
		    {
		      v20 = *targetCaster;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_784(
		        Patch,
		        (Object *)this,
		        v21,
		        &v20,
		        isCinematicMode,
		        currentDynamicSlotIndex,
		        currentEnvDynamicCasterCount,
		        currentMovableDynamicCasterCount,
		        0LL);
		      return;
		    }
		    goto LABEL_16;
		  }
		  v11 = currentDynamicSlotIndex;
		  v12 = *currentDynamicSlotIndex;
		  if ( v12 >= HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::get_m_dynamicPunctualShadowCasterCount(this, 0LL) )
		    return;
		  if ( isCinematicMode )
		  {
		    Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_targetDynamicPunctualLights;
		    if ( Patch )
		    {
		      v19 = *v11;
		      v20 = *targetCaster;
		      sub_180430AC4(Patch, v19, &v20);
		      ++*v11;
		      return;
		    }
		    goto LABEL_16;
		  }
		  isDynamicShadowCaster = UnityEngine::HGSharedLightData::get_isDynamicShadowCaster(&v21, 0LL);
		  v15 = currentMovableDynamicCasterCount;
		  v16 = currentEnvDynamicCasterCount;
		  if ( (isDynamicShadowCaster || *currentEnvDynamicCasterCount >= this->fields.m_dynamicEnvPunctualShadowCasterCount)
		    && (!UnityEngine::HGSharedLightData::get_isDynamicShadowCaster(&v21, 0LL)
		     || *v15 >= this->fields.m_dynamicMovablePunctualShadowCasterCount) )
		  {
		    goto LABEL_10;
		  }
		  Patch = (ILFixDynamicMethodWrapper_2 *)this->fields.m_targetDynamicPunctualLights;
		  if ( !Patch )
		LABEL_16:
		    sub_1800D8260(Patch, v13);
		  v18 = *v11;
		  v20 = *targetCaster;
		  sub_180430AC4(Patch, v18, &v20);
		LABEL_10:
		  ++*v11;
		  if ( UnityEngine::HGSharedLightData::get_isDynamicShadowCaster(&v21, 0LL) )
		    ++*v15;
		  else
		    ++*v16;
		}
		
		internal void PreparePunctualLightShadowCasters(NativeArray<VisibleLight> visibleLights, HGCamera hgCamera, HGSettingParameters settingParams, NativeArray<int> lightIndices, int punctualLightCount) {} // 0x0000000189B49990-0x0000000189B4AED8
		// Void PreparePunctualLightShadowCasters(NativeArray`1[UnityEngine.Rendering.VisibleLight], HGCamera, HGSettingParameters, NativeArray`1[System.Int32], Int32)
		// Hidden C++ exception states: #wind=3
		void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PreparePunctualLightShadowCasters(
		        HGPunctualLightShadowManagerV2 *this,
		        NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights,
		        HGCamera *hgCamera,
		        HGSettingParameters *settingParams,
		        NativeArray_1_System_Int32_ *lightIndices,
		        int32_t punctualLightCount,
		        MethodInfo *method)
		{
		  HGPunctualLightShadowManagerV2 *v10; // r14
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  float v13; // xmm0_4
		  int32_t m_dynamicPunctualShadowCasterCount; // eax
		  __int64 v15; // rdx
		  int32_t m_punctualShadowAtlasBaseTileSize; // ebx
		  unsigned __int64 v17; // rcx
		  int v18; // eax
		  int v19; // eax
		  unsigned __int64 v20; // rbx
		  HGPunctualLightStaticAtlasAllocator *punctualLightStaticAtlasAllocator; // rdi
		  Vector2Int m_punctualShadowAtlasSize; // rax
		  Type *v23; // rdx
		  PropertyInfo_1 *v24; // r8
		  Int32__Array **v25; // r9
		  int32_t m_X; // edi
		  int32_t m_Y; // ebx
		  Type *v28; // rdx
		  PropertyInfo_1 *v29; // r8
		  Int32__Array **v30; // r9
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  List_1_HG_Rendering_Runtime_LightCaster_ *m_castersToBeRemoved; // rbx
		  Transform *transform; // rax
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  __int64 v37; // rdx
		  __int64 v38; // rcx
		  unsigned __int64 lightEntity; // rcx
		  HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc v40; // xmm6
		  __int64 v41; // rdx
		  Vector3 *worldPosition; // rax
		  float v43; // xmm2_4
		  __m128 v44; // xmm1
		  __m128 v45; // xmm0
		  float v46; // xmm7_4
		  float shadowCullDistance_Injected; // xmm0_4
		  List_1_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ *v48; // rcx
		  __int64 v49; // rdx
		  HGPunctualLightStaticAtlasAllocator *v50; // rcx
		  unsigned __int64 v51; // rdx
		  __int64 v52; // rdx
		  Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *m_activePunctualLightCachedShadowDescs; // rcx
		  int32_t v54; // ebx
		  LightCaster__Array *m_targetDynamicPunctualLights; // rdi
		  int32_t v56; // r13d
		  bool HasShaderDefine; // r12
		  HGRenderPipelineSettingHub *instance; // rax
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ *v59; // r15
		  signed __int64 v60; // rdi
		  __int64 v61; // rbx
		  __int64 v62; // rax
		  LightType__Enum type_Injected; // eax
		  BOOL v64; // edx
		  float v65; // xmm2_4
		  __m128 high_high; // xmm1
		  __m128 high_low; // xmm0
		  float v68; // xmm6_4
		  float m_punctualLightForceCullDistance; // xmm0_4
		  BOOL v70; // r12d
		  bool v71; // al
		  int32_t v72; // eax
		  int32_t i; // edi
		  HGSharedLightData v74; // rbx
		  Entity_1 v75; // rax
		  HGSharedLightData v76; // rbx
		  Entity_1 Entity; // rax
		  int32_t v78; // edi
		  Entity_1 v79; // rbx
		  LightCaster v80; // xmm6
		  Dictionary_2_HG_Rendering_Runtime_LightCaster_System_Int32_ *m_targetPunctualAtlasAllocationThisFrame; // rbx
		  int32_t SlotLevelFromIndex; // eax
		  String *DebugName; // rax
		  String *v84; // rax
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *m_targetUpdateRequest; // rax
		  __int64 v86; // rdx
		  Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *v87; // rcx
		  LightCaster v88; // xmm6
		  __int64 v89; // rdx
		  __int64 v90; // rcx
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v91; // rax
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v92; // rax
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v93; // rcx
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v94; // rax
		  Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *v95; // rdx
		  __int64 v96; // rdx
		  HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc v97; // xmm0
		  int32_t v98; // r8d
		  __int64 v99; // rcx
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v100; // rax
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v101; // rax
		  __int64 m_cachedHashCode; // rdx
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v103; // rax
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v104; // rax
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v105; // rax
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v106; // rax
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v107; // rax
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v108; // rax
		  __int64 v109; // rdx
		  Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *v110; // rcx
		  uint32_t v111; // ecx
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v112; // rax
		  __int64 v113; // rbx
		  Entity_1__Array *m_targetStaticPunctualLights; // rdi
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v115; // r15
		  __int64 sourceSlot; // r15
		  __int64 v117; // rdx
		  __int64 v118; // rcx
		  __int64 v119; // rax
		  __int64 v120; // r8
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v121; // rax
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v122; // rax
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v123; // rax
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v124; // rax
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v125; // rdi
		  HGSharedLightData *p_HGSharedLightData; // rcx
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v127; // rax
		  int32_t v128; // eax
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v129; // rax
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v130; // rax
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v131; // rdi
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v132; // rax
		  Entity_1 v133; // rax
		  __int64 v134; // rdx
		  __int64 v135; // rcx
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v136; // rbx
		  __int64 v137; // rdx
		  __int64 v138; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rdi
		  __int64 v140; // [rsp+0h] [rbp-338h] BYREF
		  GraphicsFormat__Enum colorFormat[2]; // [rsp+20h] [rbp-318h]
		  bool v142; // [rsp+A0h] [rbp-298h]
		  bool v143; // [rsp+A1h] [rbp-297h]
		  HGSharedLightData curLight; // [rsp+A8h] [rbp-290h] BYREF
		  LightCaster v145; // [rsp+B0h] [rbp-288h] BYREF
		  LightCaster requestLightCaster; // [rsp+C0h] [rbp-278h] BYREF
		  unsigned __int64 v147; // [rsp+D0h] [rbp-268h]
		  int32_t v148; // [rsp+E0h] [rbp-258h] BYREF
		  int32_t v149[3]; // [rsp+E4h] [rbp-254h] BYREF
		  LightCaster current; // [rsp+F0h] [rbp-248h] BYREF
		  HGSharedLightData _unity_self; // [rsp+100h] [rbp-238h] BYREF
		  int32_t v152; // [rsp+108h] [rbp-230h] BYREF
		  int32_t v153; // [rsp+10Ch] [rbp-22Ch] BYREF
		  Vector3 v154; // [rsp+110h] [rbp-228h]
		  HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc value; // [rsp+120h] [rbp-218h] BYREF
		  unsigned __int64 v156; // [rsp+130h] [rbp-208h] BYREF
		  float v157; // [rsp+138h] [rbp-200h]
		  KeyValuePair_2_Beyond_Byte_UInt128_System_Int32_ v158; // [rsp+140h] [rbp-1F8h] BYREF
		  HGSharedLightData HGSharedLightData; // [rsp+160h] [rbp-1D8h] BYREF
		  HGSharedLightData v160; // [rsp+168h] [rbp-1D0h] BYREF
		  LightCaster key; // [rsp+170h] [rbp-1C8h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_System_Int32_ v162; // [rsp+180h] [rbp-1B8h] BYREF
		  List_1_T_Enumerator_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ v163; // [rsp+1A8h] [rbp-190h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ v164; // [rsp+1C8h] [rbp-170h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_UnityEngine_Vector2Int_Beyond_Gameplay_RemoteFactory_RemoteFactoryGridSampler_SampleItem_ v165; // [rsp+200h] [rbp-138h] BYREF
		  Il2CppExceptionWrapper *v166; // [rsp+238h] [rbp-100h] BYREF
		  Il2CppExceptionWrapper *v167; // [rsp+240h] [rbp-F8h] BYREF
		  Il2CppExceptionWrapper *v168; // [rsp+248h] [rbp-F0h] BYREF
		  __int128 v169; // [rsp+250h] [rbp-E8h]
		  __int128 v170; // [rsp+260h] [rbp-D8h]
		  __int128 v171; // [rsp+270h] [rbp-C8h]
		  __int128 v172; // [rsp+280h] [rbp-B8h]
		  __int128 v173; // [rsp+290h] [rbp-A8h]
		  __int128 v174; // [rsp+2A0h] [rbp-98h]
		  __int128 v175; // [rsp+2B0h] [rbp-88h]
		  __int128 v176; // [rsp+2C0h] [rbp-78h]
		  __int128 v177; // [rsp+2D0h] [rbp-68h]
		  int v178; // [rsp+2E0h] [rbp-58h]
		
		  v10 = this;
		  memset(&v164, 0, sizeof(v164));
		  key = 0LL;
		  value = 0LL;
		  _unity_self = 0LL;
		  memset(&v163, 0, sizeof(v163));
		  curLight = 0LL;
		  requestLightCaster = 0LL;
		  memset(&v162, 0, sizeof(v162));
		  v149[0] = 0;
		  HGSharedLightData = 0LL;
		  v160 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1940, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1940, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v138, v137);
		    requestLightCaster = (LightCaster)*lightIndices;
		    v145 = (LightCaster)*visibleLights;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_757(
		      Patch,
		      (Object *)v10,
		      (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&v145,
		      (Object *)hgCamera,
		      (Object *)settingParams,
		      (NativeArray_1_System_Int32_ *)&requestLightCaster,
		      punctualLightCount,
		      0LL);
		  }
		  else if ( HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::IsPunctualLightShadowEnabled(
		              v10,
		              settingParams,
		              0LL) )
		  {
		    if ( !settingParams )
		      sub_1800D8260(v12, v11);
		    v10->fields.m_punctualShadowAtlasBaseTileSize = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                                      (SettingParameter_1_System_Int32Enum_ *)settingParams->fields._punctualLightTileMaxSize_k__BackingField,
		                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    v10->fields.m_dynamicEnvPunctualShadowCasterCount = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                                          (SettingParameter_1_System_Int32Enum_ *)settingParams->fields._punctualLightEnvDynamicCasterCount_k__BackingField,
		                                                          MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    v10->fields.m_dynamicMovablePunctualShadowCasterCount = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                                              (SettingParameter_1_System_Int32Enum_ *)settingParams->fields._punctualLightMovableDynamicCasterCount_k__BackingField,
		                                                              MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    v13 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		            settingParams->fields._punctualLightShadowScreenSizeMin_k__BackingField,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		    v10->fields.m_punctualLightShadowScreenSizeMinSquared = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                                              settingParams->fields._punctualLightShadowScreenSizeMin_k__BackingField,
		                                                              MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit)
		                                                          * v13;
		    v10->fields.m_punctualLightForceCullDistance = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                                     settingParams->fields._punctualLightForceCullDistance_k__BackingField,
		                                                     MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		    m_dynamicPunctualShadowCasterCount = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::get_m_dynamicPunctualShadowCasterCount(
		                                           v10,
		                                           0LL);
		    m_punctualShadowAtlasBaseTileSize = v10->fields.m_punctualShadowAtlasBaseTileSize;
		    if ( m_dynamicPunctualShadowCasterCount )
		    {
		      HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::get_m_dynamicPunctualShadowCasterCount(v10, 0LL);
		      v19 = sub_1832DBD50();
		      v17 = (unsigned int)(4 * v10->fields.m_punctualShadowAtlasBaseTileSize);
		      v18 = m_punctualShadowAtlasBaseTileSize * (v19 + 4);
		    }
		    else
		    {
		      v17 = (unsigned int)(4 * m_punctualShadowAtlasBaseTileSize);
		      v18 = 4 * m_punctualShadowAtlasBaseTileSize;
		    }
		    v147 = __PAIR64__(v17, v18);
		    v20 = __PAIR64__(v17, v18);
		    punctualLightStaticAtlasAllocator = v10->fields.punctualLightStaticAtlasAllocator;
		    if ( !punctualLightStaticAtlasAllocator )
		      sub_1800D8260(v17, v15);
		    punctualLightStaticAtlasAllocator->fields.m_atlasResolution = 4 * v10->fields.m_punctualShadowAtlasBaseTileSize;
		    m_punctualShadowAtlasSize = v10->fields.m_punctualShadowAtlasSize;
		    if ( m_punctualShadowAtlasSize.m_X != (_DWORD)v20
		      || (v17 = HIDWORD(v20), m_punctualShadowAtlasSize.m_Y != HIDWORD(v20)) )
		    {
		      if ( v10->fields.m_cachedPunctualLightShadowAtlas )
		      {
		        UnityEngine::Rendering::RTHandle::Release(v10->fields.m_cachedPunctualLightShadowAtlas, 0LL);
		        v10->fields.m_cachedPunctualLightShadowAtlas = 0LL;
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&v10->fields.m_cachedPunctualLightShadowAtlas,
		          v23,
		          v24,
		          v25,
		          *(MethodInfo **)colorFormat);
		      }
		      v10->fields.m_punctualShadowAtlasSize = (Vector2Int)v20;
		    }
		    if ( !v10->fields.m_cachedPunctualLightShadowAtlas )
		    {
		      m_X = v10->fields.m_punctualShadowAtlasSize.m_X;
		      m_Y = v10->fields.m_punctualShadowAtlasSize.m_Y;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		      v10->fields.m_cachedPunctualLightShadowAtlas = UnityEngine::Rendering::RTHandles::Alloc(
		                                                       m_X,
		                                                       m_Y,
		                                                       1,
		                                                       DepthBits__Enum_Depth16,
		                                                       GraphicsFormat__Enum_R8G8B8A8_SRGB,
		                                                       FilterMode__Enum_Point,
		                                                       TextureWrapMode__Enum_Clamp,
		                                                       TextureDimension__Enum_Tex2D,
		                                                       0,
		                                                       0,
		                                                       0,
		                                                       1,
		                                                       1,
		                                                       0.0,
		                                                       MSAASamples__Enum_None,
		                                                       0,
		                                                       RenderTextureMemoryless__Enum_None,
		                                                       (String *)"Punctual Shadowmap",
		                                                       0LL);
		      sub_18002D1B0(
		        (SingleFieldAccessor *)&v10->fields.m_cachedPunctualLightShadowAtlas,
		        v28,
		        v29,
		        v30,
		        *(MethodInfo **)colorFormat);
		      HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::InvalidateAllShadowCaches(v10, 0LL);
		    }
		    if ( !v10->fields.m_targetPunctualAtlasAllocationThisFrame )
		      sub_1800D8260(v17, v15);
		    System::Collections::Generic::Dictionary<Unity::VisualScripting::FullSerializer::Internal::fsPortableReflection::AttributeQuery,System::Object>::Clear(
		      (Dictionary_2_Unity_VisualScripting_FullSerializer_Internal_fsPortableReflection_AttributeQuery_System_Object_ *)v10->fields.m_targetPunctualAtlasAllocationThisFrame,
		      MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::Clear);
		    m_castersToBeRemoved = v10->fields.m_castersToBeRemoved;
		    if ( !m_castersToBeRemoved )
		      sub_1800D8260(v32, v31);
		    ++m_castersToBeRemoved->fields._version;
		    m_castersToBeRemoved->fields._size = 0;
		    if ( !hgCamera )
		      sub_1800D8260(v32, v31);
		    if ( !hgCamera->fields.camera )
		      sub_1800D8260(v32, v31);
		    transform = UnityEngine::Component::get_transform((Component *)hgCamera->fields.camera, 0LL);
		    if ( !transform )
		      sub_1800D8260(v36, v35);
		    v154 = *UnityEngine::Transform::get_position((Vector3 *)&v158, transform, 0LL);
		    if ( !v10->fields.m_activePunctualLightCachedShadowDescs )
		      sub_1800D8260(v38, v37);
		    v164 = *(Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)sub_1808AE734(&v165, v10->fields.m_activePunctualLightCachedShadowDescs);
		    v145.lightEntity = 0LL;
		    *(_QWORD *)&v145.index = &v164;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::MoveNext(
		                &v164,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::MoveNext) )
		      {
		        *(LightCaster *)&v165._dictionary = v164._current.key;
		        *(HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc *)&v165._current.key.m_X = v164._current.value;
		        System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Deconstruct(
		          (KeyValuePair_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)&v165,
		          &key,
		          &value,
		          MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Deconstruct);
		        current = key;
		        v40 = value;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		        if ( HG::Rendering::Runtime::LightCaster::IsLightVaild(&current, 0LL) )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		          _unity_self = HG::Rendering::Runtime::LightCaster::GetHGSharedLightData(&current, 0LL);
		          if ( UnityEngine::HGSharedLightData::get_isRuntimeShadowBaked_Injected(&_unity_self, 0LL) )
		          {
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		            _unity_self = HG::Rendering::Runtime::LightCaster::GetHGSharedLightData(&current, 0LL);
		            worldPosition = UnityEngine::HGSharedLightData::get_worldPosition((Vector3 *)&v158, &_unity_self, 0LL);
		            v147 = *(_QWORD *)&worldPosition->x;
		            v43 = worldPosition->z - v154.z;
		            v44 = (__m128)HIDWORD(v147);
		            v44.m128_f32[0] = *((float *)&v147 + 1) - v154.y;
		            v45 = (__m128)(unsigned int)v147;
		            v45.m128_f32[0] = *(float *)&v147 - v154.x;
		            v156 = _mm_unpacklo_ps(v45, v44).m128_u64[0];
		            v157 = v43;
		            v46 = sub_182F9FF00(&v156);
		            _unity_self = HG::Rendering::Runtime::LightCaster::GetHGSharedLightData(&current, 0LL);
		            shadowCullDistance_Injected = UnityEngine::HGSharedLightData::get_shadowCullDistance_Injected(
		                                            &_unity_self,
		                                            0LL);
		            if ( v10->fields.m_punctualLightForceCullDistance <= shadowCullDistance_Injected )
		              shadowCullDistance_Injected = v10->fields.m_punctualLightForceCullDistance;
		            if ( v46 < shadowCullDistance_Injected )
		              continue;
		          }
		        }
		        v48 = (List_1_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ *)v10->fields.m_castersToBeRemoved;
		        if ( !v48 )
		          sub_1800D8250(0LL, v41);
		        System::Collections::Generic::List<Beyond::Gameplay::Core::SpawnerManager::SpawnDataDetail>::Add(
		          v48,
		          (SpawnerManager_SpawnDataDetail *)&current,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::LightCaster>::Add);
		        v50 = v10->fields.punctualLightStaticAtlasAllocator;
		        if ( !v50 )
		          sub_1800D8250(0LL, v49);
		        HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::Free(
		          v50,
		          _mm_cvtsi128_si32(_mm_srli_si128((__m128i)v40, 12)),
		          0LL);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v166 )
		    {
		      v145.lightEntity = (Entity_1)v166->ex;
		      lightEntity = (unsigned __int64)v145.lightEntity;
		      if ( v145.lightEntity )
		        sub_18007E1E0(*(_QWORD *)&v145.lightEntity);
		      v10 = this;
		    }
		    v51 = (unsigned __int64)v10->fields.m_castersToBeRemoved;
		    if ( !v51 )
		      goto LABEL_188;
		    System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::GetEnumerator(
		      (List_1_T_Enumerator_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)&v165,
		      (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)v51,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::LightCaster>::GetEnumerator);
		    *(_OWORD *)&v163._list = *(_OWORD *)&v165._dictionary;
		    v163._current = *(SpawnerManager_SpawnDataDetail *)&v165._current.key.m_X;
		    v145.lightEntity = 0LL;
		    *(_QWORD *)&v145.index = &v163;
		    try
		    {
		      while ( System::Collections::Generic::List_1_T_::Enumerator<Beyond::Gameplay::Core::SpawnerManager::SpawnDataDetail>::MoveNext(
		                &v163,
		                MethodInfo::System::Collections::Generic::List_1_T_::Enumerator<HG::Rendering::Runtime::LightCaster>::MoveNext) )
		      {
		        m_activePunctualLightCachedShadowDescs = v10->fields.m_activePunctualLightCachedShadowDescs;
		        if ( !m_activePunctualLightCachedShadowDescs )
		          sub_1800D8250(0LL, v52);
		        current = (LightCaster)v163._current;
		        System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Remove(
		          m_activePunctualLightCachedShadowDescs,
		          &current,
		          MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Remove);
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v167 )
		    {
		      v145.lightEntity = (Entity_1)v167->ex;
		      if ( v145.lightEntity )
		        sub_18007E1E0(*(_QWORD *)&v145.lightEntity);
		      v10 = this;
		    }
		    v54 = 0;
		    if ( HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::get_m_dynamicPunctualShadowCasterCount(v10, 0LL) > 0 )
		    {
		      while ( 1 )
		      {
		        m_targetDynamicPunctualLights = v10->fields.m_targetDynamicPunctualLights;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		        lightEntity = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::LightCaster->static_fields;
		        if ( !m_targetDynamicPunctualLights )
		          break;
		        v145 = *(LightCaster *)lightEntity;
		        sub_180430AC4(m_targetDynamicPunctualLights, v54++, &v145);
		        if ( v54 >= HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::get_m_dynamicPunctualShadowCasterCount(
		                      v10,
		                      0LL) )
		          goto LABEL_43;
		      }
		LABEL_188:
		      sub_1800D8250(lightEntity, v51);
		    }
		LABEL_43:
		    v148 = 0;
		    v153 = 0;
		    v152 = 0;
		    v56 = 0;
		    HasShaderDefine = UnityEngine::Rendering::GraphicsSettings::HasShaderDefine(
		                        BuiltinShaderDefine__Enum_HG_RENDER_PATH_MOBILE,
		                        0LL);
		    v142 = HasShaderDefine;
		    instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		    if ( !instance )
		      goto LABEL_188;
		    v143 = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_currentDeviceType(instance, 0LL) == HGDeviceType__Enum_Cinematic;
		    v59 = visibleLights;
		    current = (LightCaster)*visibleLights;
		    if ( punctualLightCount > 0 )
		    {
		      v60 = 0LL;
		      v147 = 0LL;
		      while ( 1 )
		      {
		        lightEntity = (unsigned __int64)v10->fields.punctualLightStaticAtlasAllocator;
		        if ( !lightEntity )
		          goto LABEL_188;
		        if ( v56 < HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::get_SlotCount(
		                     (HGPunctualLightStaticAtlasAllocator *)lightEntity,
		                     0LL) )
		        {
		          v61 = *(_QWORD *)&current.lightEntity + 148LL * *(int *)&lightIndices->m_Buffer[4 * v60];
		          v62 = (__int64)&v59->m_Buffer[148 * *(int *)&lightIndices->m_Buffer[4 * v60]];
		          v169 = *(_OWORD *)v62;
		          v170 = *(_OWORD *)(v62 + 16);
		          v171 = *(_OWORD *)(v62 + 32);
		          v172 = *(_OWORD *)(v62 + 48);
		          v173 = *(_OWORD *)(v62 + 64);
		          v174 = *(_OWORD *)(v62 + 80);
		          v175 = *(_OWORD *)(v62 + 96);
		          v176 = *(_OWORD *)(v62 + 112);
		          v177 = *(_OWORD *)(v62 + 128);
		          v178 = *(_DWORD *)(v62 + 144);
		          curLight = (HGSharedLightData)*((_QWORD *)&v177 + 1);
		          type_Injected = UnityEngine::HGSharedLightData::get_type_Injected(&curLight, 0LL);
		          v64 = 0;
		          if ( type_Injected == LightType__Enum_Point )
		            v64 = HasShaderDefine;
		          if ( !v64 || UnityEngine::HGSharedLightData::get_enableOverrideShadowLight_Injected(&curLight, 0LL) )
		          {
		            v158.key.high = *(_QWORD *)(v61 + 116);
		            v65 = *(float *)(v61 + 124) - v154.z;
		            high_high = (__m128)HIDWORD(v158.key.high);
		            high_high.m128_f32[0] = *((float *)&v158.key.high + 1) - v154.y;
		            high_low = (__m128)LODWORD(v158.key.high);
		            high_low.m128_f32[0] = *(float *)&v158.key.high - v154.x;
		            v156 = _mm_unpacklo_ps(high_low, high_high).m128_u64[0];
		            v157 = v65;
		            v68 = sub_182F9FF00(&v156);
		            if ( UnityEngine::HGSharedLightData::get_type_Injected(&curLight, 0LL) == LightType__Enum_Point
		              || UnityEngine::HGSharedLightData::get_type_Injected(&curLight, 0LL) == LightType__Enum_Spot )
		            {
		              if ( UnityEngine::HGSharedLightData::get_shadows_Injected(&curLight, 0LL) )
		              {
		                m_punctualLightForceCullDistance = UnityEngine::HGSharedLightData::get_shadowCullDistance_Injected(
		                                                     &curLight,
		                                                     0LL);
		                if ( v10->fields.m_punctualLightForceCullDistance <= m_punctualLightForceCullDistance )
		                  m_punctualLightForceCullDistance = v10->fields.m_punctualLightForceCullDistance;
		                if ( m_punctualLightForceCullDistance > v68 )
		                {
		                  v70 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::LightConsiderAsSpotlight(
		                          v10,
		                          curLight,
		                          0LL);
		                  v71 = UnityEngine::HGSharedLightData::get_type_Injected(&curLight, 0LL) == LightType__Enum_Point
		                     && UnityEngine::HGSharedLightData::IsPointLightHasExactlyOneCaster(&curLight, 0LL);
		                  if ( v71 || v70 || v143 )
		                  {
		                    v72 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::get_m_dynamicPunctualShadowCasterCount(
		                            v10,
		                            0LL);
		                    if ( v148 < v72
		                      && (UnityEngine::HGSharedLightData::get_isDynamicShadowCaster(&curLight, 0LL)
		                       && (UnityEngine::HGSharedLightData::get_castStaticObjects(&curLight, 0LL)
		                        || UnityEngine::HGSharedLightData::get_castDynamicObjects(&curLight, 0LL))
		                       || UnityEngine::HGSharedLightData::get_castDynamicObjects(&curLight, 0LL)) )
		                    {
		                      if ( v70 )
		                      {
		                        v76 = curLight;
		                        Entity = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(curLight, 0LL);
		                        v145 = 0LL;
		                        HG::Rendering::Runtime::LightCaster::LightCaster(&v145, Entity, 0, 0LL);
		                        HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::AppendNewDynamicPunctualLight(
		                          v10,
		                          v76,
		                          &v145,
		                          v143,
		                          &v148,
		                          &v153,
		                          &v152,
		                          0LL);
		                      }
		                      else
		                      {
		                        for ( i = 0; i < 6; ++i )
		                        {
		                          if ( UnityEngine::HGSharedLightData::GetPointLightShadowCasterFace(
		                                 &curLight,
		                                 (CubemapFace__Enum)i,
		                                 0LL) )
		                          {
		                            v74 = curLight;
		                            v75 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(curLight, 0LL);
		                            v145 = 0LL;
		                            HG::Rendering::Runtime::LightCaster::LightCaster(&v145, v75, i, 0LL);
		                            HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::AppendNewDynamicPunctualLight(
		                              v10,
		                              v74,
		                              &v145,
		                              v143,
		                              &v148,
		                              &v153,
		                              &v152,
		                              0LL);
		                          }
		                        }
		                        v59 = visibleLights;
		                        v60 = v147;
		                      }
		                    }
		                  }
		                  if ( !UnityEngine::HGSharedLightData::get_isDynamicShadowCaster(&curLight, 0LL)
		                    && UnityEngine::HGSharedLightData::get_castStaticObjects(&curLight, 0LL) )
		                  {
		                    v78 = 0;
		                    do
		                    {
		                      lightEntity = UnityEngine::HGSharedLightData::get_type_Injected(&curLight, 0LL) == LightType__Enum_Point
		                                 && UnityEngine::HGSharedLightData::GetPointLightShadowCasterFace(
		                                      &curLight,
		                                      (CubemapFace__Enum)v78,
		                                      0LL);
		                      if ( (unsigned int)lightEntity | v70 )
		                      {
		                        v79 = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(curLight, 0LL);
		                        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		                        HG::Rendering::Runtime::LightCaster::LightCaster(&requestLightCaster, v79, v78, 0LL);
		                        lightEntity = (unsigned __int64)v10->fields.m_targetPunctualAtlasAllocationThisFrame;
		                        if ( !lightEntity )
		                          goto LABEL_188;
		                        v80 = requestLightCaster;
		                        v145 = requestLightCaster;
		                        if ( System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::ContainsKey(
		                               (Dictionary_2_HG_Rendering_Runtime_LightCaster_System_Int32_ *)lightEntity,
		                               &v145,
		                               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::ContainsKey) )
		                        {
		                          DebugName = UnityEngine::HGSharedLightData::GetDebugName(&curLight, 0LL);
		                          v84 = System::String::Concat(
		                                  (String *)"HGPunctualLightShadowManager: 当前灯光阴影存在异常，我们推测是特效误设置，请通知相关老师进行修改。灯光名：",
		                                  DebugName,
		                                  0LL);
		                          HG::Rendering::HGRPLogger::LogCritical(v84, 0LL);
		                        }
		                        else
		                        {
		                          m_targetPunctualAtlasAllocationThisFrame = v10->fields.m_targetPunctualAtlasAllocationThisFrame;
		                          lightEntity = (unsigned __int64)v10->fields.punctualLightStaticAtlasAllocator;
		                          v51 = (unsigned int)v56++;
		                          if ( !lightEntity )
		                            goto LABEL_188;
		                          SlotLevelFromIndex = HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::GetSlotLevelFromIndex(
		                                                 (HGPunctualLightStaticAtlasAllocator *)lightEntity,
		                                                 v51,
		                                                 0LL);
		                          if ( !m_targetPunctualAtlasAllocationThisFrame )
		                            goto LABEL_188;
		                          v145 = v80;
		                          System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::Add(
		                            m_targetPunctualAtlasAllocationThisFrame,
		                            &v145,
		                            SlotLevelFromIndex,
		                            MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::Add);
		                          lightEntity = (unsigned __int64)v10->fields.punctualLightStaticAtlasAllocator;
		                          if ( !lightEntity )
		                            goto LABEL_188;
		                          if ( v56 >= HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::get_SlotCount(
		                                        (HGPunctualLightStaticAtlasAllocator *)lightEntity,
		                                        0LL) )
		                            break;
		                        }
		                      }
		                      ++v78;
		                    }
		                    while ( v78 < (v70 ? 1 : 6) );
		                    v59 = visibleLights;
		                    v60 = v147;
		                  }
		                  HasShaderDefine = v142;
		                }
		              }
		            }
		          }
		          v147 = ++v60;
		          if ( v60 < punctualLightCount )
		            continue;
		        }
		        break;
		      }
		    }
		    m_targetUpdateRequest = v10->fields.m_targetUpdateRequest;
		    if ( !m_targetUpdateRequest )
		      goto LABEL_188;
		    m_targetUpdateRequest->fields.requestType = 0;
		    v51 = (unsigned __int64)v10->fields.m_targetPunctualAtlasAllocationThisFrame;
		    if ( !v51 )
		      goto LABEL_188;
		    System::Collections::Generic::Dictionary<UnityEngine::Vector2Int,Beyond::Gameplay::RemoteFactory::RemoteFactoryGridSampler::SampleItem>::GetEnumerator(
		      &v165,
		      (Dictionary_2_UnityEngine_Vector2Int_Beyond_Gameplay_RemoteFactory_RemoteFactoryGridSampler_SampleItem_ *)v51,
		      MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,int>::GetEnumerator);
		    v162 = (Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_System_Int32_)v165;
		    current.lightEntity = 0LL;
		    *(_QWORD *)&current.index = &v162;
		    try
		    {
		      while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,int>::MoveNext(
		                &v162,
		                MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,int>::MoveNext) )
		      {
		        v158.key = (UInt128)v162._current.key;
		        v158.value = v162._current.value;
		        System::Collections::Generic::KeyValuePair<Beyond::Byte::UInt128,int>::Deconstruct(
		          &v158,
		          (UInt128 *)&key,
		          v149,
		          MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,int>::Deconstruct);
		        v87 = v10->fields.m_activePunctualLightCachedShadowDescs;
		        if ( !v87 )
		          sub_1800D8250(0LL, v86);
		        v88 = key;
		        requestLightCaster = key;
		        if ( System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::ContainsKey(
		               v87,
		               &requestLightCaster,
		               MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::ContainsKey) )
		        {
		          v95 = v10->fields.m_activePunctualLightCachedShadowDescs;
		          if ( !v95 )
		            sub_1800D8250(v90, 0LL);
		          requestLightCaster = v88;
		          System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Item(
		            &value,
		            v95,
		            &requestLightCaster,
		            MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Item);
		          v97 = value;
		          v145 = (LightCaster)value;
		          v98 = _mm_cvtsi128_si32((__m128i)value);
		          v99 = (unsigned int)v149[0];
		          if ( v98 >= v149[0] )
		            goto LABEL_113;
		          v100 = v10->fields.m_targetUpdateRequest;
		          if ( !v100 )
		            sub_1800D8250((unsigned int)v149[0], v96);
		          if ( v100->fields.requestType >= 3 )
		          {
		LABEL_113:
		            m_cachedHashCode = (unsigned int)v145.m_cachedHashCode;
		          }
		          else
		          {
		            v100->fields.requestType = 3;
		            v101 = v10->fields.m_targetUpdateRequest;
		            if ( !v101 )
		              sub_1800D8250(v99, v96);
		            m_cachedHashCode = (unsigned int)_mm_cvtsi128_si32(_mm_srli_si128((__m128i)v97, 12));
		            v101->fields.sourceSlot = m_cachedHashCode;
		            v103 = v10->fields.m_targetUpdateRequest;
		            if ( !v103 )
		              sub_1800D8250(v99, m_cachedHashCode);
		            v103->fields.targetLevel = v99;
		            v104 = v10->fields.m_targetUpdateRequest;
		            if ( !v104 )
		              sub_1800D8250(v99, m_cachedHashCode);
		            v104->fields.requestLightCaster = v88;
		          }
		          if ( v98 > (int)v99 )
		          {
		            v105 = v10->fields.m_targetUpdateRequest;
		            if ( !v105 )
		              sub_1800D8250(v99, m_cachedHashCode);
		            if ( v105->fields.requestType < 2 )
		            {
		              v105->fields.requestType = 2;
		              v106 = v10->fields.m_targetUpdateRequest;
		              if ( !v106 )
		                sub_1800D8250(v99, m_cachedHashCode);
		              v106->fields.sourceSlot = m_cachedHashCode;
		              v107 = v10->fields.m_targetUpdateRequest;
		              if ( !v107 )
		                sub_1800D8250(v99, m_cachedHashCode);
		              v107->fields.targetLevel = v99;
		              v108 = v10->fields.m_targetUpdateRequest;
		              if ( !v108 )
		                sub_1800D8250(v99, m_cachedHashCode);
		              v108->fields.requestLightCaster = v88;
		            }
		          }
		          v145.index = UnityEngine::Time::get_realtimeSinceStartup(0LL);
		          v110 = v10->fields.m_activePunctualLightCachedShadowDescs;
		          if ( !v110 )
		            sub_1800D8250(0LL, v109);
		          requestLightCaster = v145;
		          v145 = v88;
		          System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::set_Item(
		            v110,
		            &v145,
		            (HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc *)&requestLightCaster,
		            MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::set_Item);
		        }
		        else
		        {
		          v91 = v10->fields.m_targetUpdateRequest;
		          if ( !v91 )
		            sub_1800D8250(v90, v89);
		          if ( v91->fields.requestType < 1 )
		          {
		            v91->fields.requestType = 1;
		            v92 = v10->fields.m_targetUpdateRequest;
		            if ( !v92 )
		              sub_1800D8250(v90, v89);
		            v92->fields.sourceSlot = -1;
		            v93 = v10->fields.m_targetUpdateRequest;
		            if ( !v93 )
		              sub_1800D8250(0LL, v89);
		            v93->fields.targetLevel = v149[0];
		            v94 = v10->fields.m_targetUpdateRequest;
		            if ( !v94 )
		              sub_1800D8250(v93, v89);
		            v94->fields.requestLightCaster = v88;
		          }
		        }
		      }
		    }
		    catch ( Il2CppExceptionWrapper *v168 )
		    {
		      v51 = (unsigned __int64)&v140;
		      current.lightEntity = (Entity_1)v168->ex;
		      if ( current.lightEntity )
		        sub_18007E1E0(*(_QWORD *)&current.lightEntity);
		      v10 = this;
		    }
		    lightEntity = (unsigned __int64)v10->fields.m_targetUpdateRequest;
		    if ( !lightEntity )
		      goto LABEL_188;
		    v111 = *(_DWORD *)(lightEntity + 16);
		    if ( v111 )
		    {
		      lightEntity = v111 - 1;
		      if ( (_DWORD)lightEntity )
		      {
		        if ( (unsigned int)(lightEntity - 1) > 1 )
		          return;
		        v112 = v10->fields.m_targetUpdateRequest;
		        requestLightCaster = v112->fields.requestLightCaster;
		        v113 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::ForceAllocForCaster(
		                 v10,
		                 &requestLightCaster,
		                 v112->fields.targetLevel,
		                 0LL);
		        lightEntity = (unsigned __int64)v10->fields.punctualLightStaticAtlasAllocator;
		        v51 = (unsigned __int64)v10->fields.m_targetUpdateRequest;
		        if ( !v51 )
		          goto LABEL_188;
		        if ( !lightEntity )
		          goto LABEL_188;
		        HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::Free(
		          (HGPunctualLightStaticAtlasAllocator *)lightEntity,
		          *(_DWORD *)(v51 + 36),
		          0LL);
		        m_targetStaticPunctualLights = v10->fields.m_targetStaticPunctualLights;
		        v115 = v10->fields.m_targetUpdateRequest;
		        if ( !v115 )
		          goto LABEL_188;
		        sourceSlot = v115->fields.sourceSlot;
		        sub_1800036A0(TypeInfo::UnityEngine::HyperGryph::ECS::Entity);
		        v119 = sub_183963640(v118, v117);
		        if ( !m_targetStaticPunctualLights )
		          goto LABEL_188;
		        if ( (unsigned int)sourceSlot >= m_targetStaticPunctualLights->max_length.size )
		          goto LABEL_187;
		        m_targetStaticPunctualLights->vector[sourceSlot] = (Entity_1)v119;
		        v51 = (unsigned __int64)v10->fields.m_activePunctualLightCachedShadowDescs;
		        v121 = v10->fields.m_targetUpdateRequest;
		        if ( !v121 )
		          goto LABEL_188;
		        if ( !v51 )
		          goto LABEL_188;
		        requestLightCaster = v121->fields.requestLightCaster;
		        System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Item(
		          (HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc *)&v145,
		          (Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)v51,
		          &requestLightCaster,
		          MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Item);
		        v122 = v10->fields.m_targetUpdateRequest;
		        if ( !v122 )
		          goto LABEL_188;
		        v145.lightEntity.globalIndex = v122->fields.targetLevel;
		        v145.m_cachedHashCode = v113;
		        lightEntity = (unsigned __int64)v10->fields.m_activePunctualLightCachedShadowDescs;
		        v123 = v10->fields.m_targetUpdateRequest;
		        if ( !v123 )
		          goto LABEL_188;
		        if ( !lightEntity )
		          goto LABEL_188;
		        requestLightCaster = v145;
		        v145 = v123->fields.requestLightCaster;
		        System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::set_Item(
		          (Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)lightEntity,
		          &v145,
		          (HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc *)&requestLightCaster,
		          MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::set_Item);
		        v124 = v10->fields.m_targetUpdateRequest;
		        if ( !v124 )
		          goto LABEL_188;
		        v124->fields.targetSlot = v113;
		        v125 = v10->fields.m_targetUpdateRequest;
		        if ( !v125 )
		          goto LABEL_188;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		        HGSharedLightData = HG::Rendering::Runtime::LightCaster::GetHGSharedLightData(
		                              &v125->fields.requestLightCaster,
		                              0LL);
		        p_HGSharedLightData = &HGSharedLightData;
		      }
		      else
		      {
		        v127 = v10->fields.m_targetUpdateRequest;
		        if ( !v127 )
		          goto LABEL_188;
		        requestLightCaster = v127->fields.requestLightCaster;
		        v128 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::ForceAllocForCaster(
		                 v10,
		                 &requestLightCaster,
		                 v127->fields.targetLevel,
		                 0LL);
		        v113 = v128;
		        value = 0LL;
		        value.shadowCacheSlotIndex = v128;
		        lightEntity = (unsigned __int64)v10->fields.m_targetUpdateRequest;
		        if ( !lightEntity )
		          goto LABEL_188;
		        value.targetRenderLevel = *(_DWORD *)(lightEntity + 40);
		        value.lastVisitedTime = -1.0;
		        lightEntity = (unsigned __int64)v10->fields.m_activePunctualLightCachedShadowDescs;
		        v129 = v10->fields.m_targetUpdateRequest;
		        if ( !v129 )
		          goto LABEL_188;
		        if ( !lightEntity )
		          goto LABEL_188;
		        requestLightCaster = (LightCaster)value;
		        v145 = v129->fields.requestLightCaster;
		        System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Add(
		          (Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)lightEntity,
		          &v145,
		          (HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc *)&requestLightCaster,
		          MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Add);
		        v130 = v10->fields.m_targetUpdateRequest;
		        if ( !v130 )
		          goto LABEL_188;
		        v130->fields.targetSlot = v113;
		        v131 = v10->fields.m_targetUpdateRequest;
		        if ( !v131 )
		          goto LABEL_188;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		        v160 = HG::Rendering::Runtime::LightCaster::GetHGSharedLightData(&v131->fields.requestLightCaster, 0LL);
		        p_HGSharedLightData = &v160;
		      }
		      UnityEngine::HGSharedLightData::set_isRuntimeShadowBaked_Injected(p_HGSharedLightData, 1, 0LL);
		      v132 = v10->fields.m_targetUpdateRequest;
		      v51 = (unsigned __int64)v10->fields.m_targetStaticPunctualLights;
		      if ( !v132 || !v51 )
		        goto LABEL_188;
		      v133 = v132->fields.requestLightCaster.lightEntity;
		      if ( (unsigned int)v113 < *(_DWORD *)(v51 + 24) )
		      {
		        *(Entity_1 *)(v51 + 8 * v113 + 32) = v133;
		        return;
		      }
		LABEL_187:
		      sub_1800D2AA0(lightEntity, v51, v120);
		    }
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::InvalidateAllShadowCaches(v10, 0LL);
		    v136 = v10->fields.m_targetUpdateRequest;
		    if ( !v136 )
		      sub_1800D8260(v135, v134);
		    v136->fields.requestType = 0;
		  }
		}
		
		public int GetShadowCacheIndexForCaster(LightCaster lightCaster) => default; // 0x0000000189B486D4-0x0000000189B48808
		// Int32 GetShadowCacheIndexForCaster(LightCaster)
		int32_t HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowCacheIndexForCaster(
		        HGPunctualLightShadowManagerV2 *this,
		        LightCaster *lightCaster,
		        MethodInfo *method)
		{
		  int v5; // edi
		  Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *v6; // rdx
		  __int64 v7; // r9
		  Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *m_activePunctualLightCachedShadowDescs; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  LightCaster v11; // [rsp+20h] [rbp-30h] BYREF
		  LightCaster v12; // [rsp+30h] [rbp-20h] BYREF
		  LightCaster v13; // [rsp+40h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1919, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1919, 0LL);
		    if ( Patch )
		    {
		      v13 = *lightCaster;
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_773(Patch, (Object *)this, &v13, 0LL);
		    }
		LABEL_13:
		    sub_1800D8260(m_activePunctualLightCachedShadowDescs, v6);
		  }
		  v5 = 0;
		  if ( HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::get_m_dynamicPunctualShadowCasterCount(this, 0LL) <= 0 )
		  {
		LABEL_6:
		    m_activePunctualLightCachedShadowDescs = this->fields.m_activePunctualLightCachedShadowDescs;
		    if ( m_activePunctualLightCachedShadowDescs )
		    {
		      v13 = *lightCaster;
		      if ( !System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::ContainsKey(
		              m_activePunctualLightCachedShadowDescs,
		              &v13,
		              MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::ContainsKey) )
		        return -1;
		      v6 = this->fields.m_activePunctualLightCachedShadowDescs;
		      if ( v6 )
		      {
		        v13 = *lightCaster;
		        return *(_DWORD *)(sub_1808AE754(&v12, v6, &v13) + 12);
		      }
		    }
		    goto LABEL_13;
		  }
		  while ( 1 )
		  {
		    m_activePunctualLightCachedShadowDescs = (Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)this->fields.m_targetDynamicPunctualLights;
		    if ( !m_activePunctualLightCachedShadowDescs )
		      goto LABEL_13;
		    sub_1803C0830(m_activePunctualLightCachedShadowDescs, &v11, v5, v7);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		    v13 = *lightCaster;
		    v12 = v11;
		    if ( HG::Rendering::Runtime::LightCaster::op_Equality(&v13, &v12, 0LL) )
		      return v5 + 40;
		    if ( ++v5 >= HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::get_m_dynamicPunctualShadowCasterCount(
		                   this,
		                   0LL) )
		      goto LABEL_6;
		  }
		}
		
		private int ForceAllocForCaster(LightCaster lightCaster, int targetLevel) => default; // 0x0000000189B4803C-0x0000000189B48344
		// Int32 ForceAllocForCaster(LightCaster, Int32)
		// Hidden C++ exception states: #wind=1
		int32_t HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::ForceAllocForCaster(
		        HGPunctualLightShadowManagerV2 *this,
		        LightCaster *lightCaster,
		        int32_t targetLevel,
		        MethodInfo *method)
		{
		  int32_t v4; // edi
		  HGPunctualLightShadowManagerV2 *v6; // rbx
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  int32_t result; // eax
		  float v10; // xmm6_4
		  __int64 v11; // rdx
		  LightCaster__StaticFields *static_fields; // rcx
		  float v13; // xmm0_4
		  Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *v14; // rcx
		  HGPunctualLightStaticAtlasAllocator *punctualLightStaticAtlasAllocator; // rsi
		  Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *m_activePunctualLightCachedShadowDescs; // rdx
		  LightCaster v17; // xmm6
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  LightCaster key; // [rsp+30h] [rbp-E8h] BYREF
		  HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc value; // [rsp+40h] [rbp-D8h] BYREF
		  Il2CppException *ex; // [rsp+50h] [rbp-C8h]
		  Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *v24; // [rsp+58h] [rbp-C0h]
		  LightCaster NULL_CASTER; // [rsp+60h] [rbp-B8h] BYREF
		  Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ v26; // [rsp+70h] [rbp-A8h] BYREF
		  Il2CppExceptionWrapper *v27; // [rsp+A8h] [rbp-70h] BYREF
		  KeyValuePair_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ current; // [rsp+B0h] [rbp-68h] BYREF
		
		  v4 = targetLevel;
		  v6 = this;
		  memset(&v26, 0, sizeof(v26));
		  key = 0LL;
		  value = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1957, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1957, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v20, v19);
		    key = *lightCaster;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_785(Patch, (Object *)v6, &key, v4, 0LL);
		  }
		  else
		  {
		    if ( !v6->fields.punctualLightStaticAtlasAllocator )
		      sub_1800D8260(v8, v7);
		    result = HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::TryAlloc(
		               v6->fields.punctualLightStaticAtlasAllocator,
		               v4,
		               0LL);
		    if ( result == -1 )
		    {
		      v10 = 3.4028235e38;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		      static_fields = TypeInfo::HG::Rendering::Runtime::LightCaster->static_fields;
		      NULL_CASTER = static_fields->NULL_CASTER;
		      if ( !v6->fields.m_activePunctualLightCachedShadowDescs )
		        sub_1800D8260(static_fields, v11);
		      v26 = *(Dictionary_2_TKey_TValue_Enumerator_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)sub_1808AE734(&current, v6->fields.m_activePunctualLightCachedShadowDescs);
		      ex = 0LL;
		      v24 = &v26;
		      try
		      {
		        while ( System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::MoveNext(
		                  &v26,
		                  MethodInfo::System::Collections::Generic::Dictionary_2_TKey_TValue_::Enumerator<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::MoveNext) )
		        {
		          current = v26._current;
		          System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Deconstruct(
		            &current,
		            &key,
		            &value,
		            MethodInfo::System::Collections::Generic::KeyValuePair<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Deconstruct);
		          if ( _mm_cvtsi128_si32((__m128i)value) == v4 )
		          {
		            v13 = _mm_shuffle_ps((__m128)value, (__m128)value, 170).m128_f32[0];
		            if ( v10 > v13 )
		            {
		              v10 = v13;
		              NULL_CASTER = key;
		            }
		          }
		        }
		      }
		      catch ( Il2CppExceptionWrapper *v27 )
		      {
		        ex = v27->ex;
		        if ( ex )
		          sub_18007E1E0(ex);
		        v4 = targetLevel;
		        v6 = this;
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		      if ( !HG::Rendering::Runtime::LightCaster::IsLightVaild(&NULL_CASTER, 0LL) )
		        goto LABEL_18;
		      punctualLightStaticAtlasAllocator = v6->fields.punctualLightStaticAtlasAllocator;
		      m_activePunctualLightCachedShadowDescs = v6->fields.m_activePunctualLightCachedShadowDescs;
		      if ( !m_activePunctualLightCachedShadowDescs )
		        goto LABEL_25;
		      v17 = NULL_CASTER;
		      key = NULL_CASTER;
		      System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Item(
		        &value,
		        m_activePunctualLightCachedShadowDescs,
		        &key,
		        MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::get_Item);
		      if ( !punctualLightStaticAtlasAllocator
		        || (HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::Free(
		              punctualLightStaticAtlasAllocator,
		              value.shadowCacheSlotIndex,
		              0LL),
		            (v14 = v6->fields.m_activePunctualLightCachedShadowDescs) == 0LL)
		        || (key = v17,
		            System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Remove(
		              v14,
		              &key,
		              MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::LightCaster,HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightCachedShadowDesc>::Remove),
		            (v14 = (Dictionary_2_HG_Rendering_Runtime_LightCaster_HG_Rendering_Runtime_HGPunctualLightShadowManagerV2_PunctualLightCachedShadowDesc_ *)v6->fields.punctualLightStaticAtlasAllocator) == 0LL) )
		      {
		LABEL_25:
		        sub_1800D8250(v14, m_activePunctualLightCachedShadowDescs);
		      }
		      result = HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::TryAlloc(
		                 (HGPunctualLightStaticAtlasAllocator *)v14,
		                 v4,
		                 0LL);
		      if ( result == -1 )
		      {
		LABEL_18:
		        HG::Rendering::HGRPLogger::LogError(
		          (String *)"HGPunctualLightShadowManagerV2: Internal error happens when allocating page for shadow caster.",
		          0LL);
		        return -1;
		      }
		    }
		  }
		  return result;
		}
		
		private void GetShadowRenderType(HGSharedLightData light, bool isDynamicRequest, out bool castStaticObjects, out bool castDynamicObjects) {
			castStaticObjects = default;
			castDynamicObjects = default;
		} // 0x0000000189B48808-0x0000000189B4890C
		// Void GetShadowRenderType(HGSharedLightData, Boolean, Boolean ByRef, Boolean ByRef)
		void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowRenderType(
		        HGPunctualLightShadowManagerV2 *this,
		        HGSharedLightData light,
		        bool isDynamicRequest,
		        bool *castStaticObjects,
		        bool *castDynamicObjects,
		        MethodInfo *method)
		{
		  bool *v9; // rbx
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  HGSharedLightData P1; // [rsp+58h] [rbp+10h] BYREF
		
		  P1 = light;
		  if ( IFix::WrappersManagerImpl::IsPatched(2182, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2182, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_874(
		      Patch,
		      (Object *)this,
		      P1,
		      isDynamicRequest,
		      castStaticObjects,
		      castDynamicObjects,
		      0LL);
		  }
		  else
		  {
		    v9 = castDynamicObjects;
		    *castStaticObjects = 0;
		    *v9 = 0;
		    if ( isDynamicRequest )
		    {
		      if ( !UnityEngine::HGSharedLightData::get_isDynamicShadowCaster(&P1, 0LL) )
		      {
		        if ( UnityEngine::HGSharedLightData::get_castStaticObjects(&P1, 0LL) )
		        {
		LABEL_5:
		          *v9 = 1;
		          *castStaticObjects = 1;
		          return;
		        }
		        goto LABEL_10;
		      }
		      if ( !UnityEngine::HGSharedLightData::get_castStaticObjects(&P1, 0LL)
		        || UnityEngine::HGSharedLightData::get_castDynamicObjects(&P1, 0LL) )
		      {
		        if ( UnityEngine::HGSharedLightData::get_castStaticObjects(&P1, 0LL)
		          || !UnityEngine::HGSharedLightData::get_castDynamicObjects(&P1, 0LL) )
		        {
		          goto LABEL_5;
		        }
		LABEL_10:
		        *castStaticObjects = 0;
		        *v9 = 1;
		        return;
		      }
		    }
		    *castStaticObjects = 1;
		    *v9 = 0;
		  }
		}
		
		private PerObjectData GetRendererConfig(HGSharedLightData light, bool isDynamicRequest) => default; // 0x0000000189B4861C-0x0000000189B486D4
		// PerObjectData GetRendererConfig(HGSharedLightData, Boolean)
		PerObjectData__Enum HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetRendererConfig(
		        HGPunctualLightShadowManagerV2 *this,
		        HGSharedLightData light,
		        bool isDynamicRequest,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  bool castStaticObjects; // [rsp+30h] [rbp-18h] BYREF
		  bool castDynamicObjects; // [rsp+31h] [rbp-17h] BYREF
		
		  castStaticObjects = 0;
		  castDynamicObjects = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2183, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2183, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_875(Patch, (Object *)this, light, isDynamicRequest, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowRenderType(
		      this,
		      light,
		      isDynamicRequest,
		      &castStaticObjects,
		      &castDynamicObjects,
		      0LL);
		    return (castDynamicObjects ? 0x2000 : 0) | (castStaticObjects ? 22528 : 18432);
		  }
		}
		
		private void GetECSRenderFlags(HGSharedLightData light, bool isDynamicRequest, out HGObjectFlags objectFlags, out HGObjectFlags objectFlagsMask, out HGRenderFlags renderFlags, out HGRenderFlags renderFlagsMask) {
			objectFlags = default;
			objectFlagsMask = default;
			renderFlags = default;
			renderFlagsMask = default;
		} // 0x0000000189B48344-0x0000000189B484BC
		// Void GetECSRenderFlags(HGSharedLightData, Boolean, HGObjectFlags ByRef, HGObjectFlags ByRef, HGRenderFlags ByRef, HGRenderFlags ByRef)
		void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetECSRenderFlags(
		        HGPunctualLightShadowManagerV2 *this,
		        HGSharedLightData light,
		        bool isDynamicRequest,
		        HGObjectFlags__Enum *objectFlags,
		        HGObjectFlags__Enum *objectFlagsMask,
		        HGRenderFlags__Enum *renderFlags,
		        HGRenderFlags__Enum *renderFlagsMask,
		        MethodInfo *method)
		{
		  HGObjectFlags__Enum *v11; // rdi
		  HGRenderFlags__Enum *v12; // r14
		  HGRenderFlags__Enum *v13; // rbx
		  HGSharedLightData v14; // rdx
		  bool v15; // dl
		  bool v16; // cl
		  bool v17; // zf
		  MethodInfo *v18; // rcx
		  Entity_1 Entity; // rbx
		  __int64 v20; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  bool castDynamicObjects; // [rsp+50h] [rbp-10h] BYREF
		  bool castStaticObjects; // [rsp+51h] [rbp-Fh] BYREF
		  HGSharedLightData lighta; // [rsp+98h] [rbp+38h] BYREF
		
		  lighta = light;
		  castStaticObjects = 0;
		  castDynamicObjects = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(2184, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2184, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v20);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_876(
		      Patch,
		      (Object *)this,
		      lighta,
		      isDynamicRequest,
		      objectFlags,
		      objectFlagsMask,
		      renderFlags,
		      renderFlagsMask,
		      0LL);
		  }
		  else
		  {
		    v11 = objectFlagsMask;
		    v12 = renderFlags;
		    v13 = renderFlagsMask;
		    v14 = lighta;
		    *objectFlags = HGObjectFlags__Enum_RealtimeShadowCaster|HGObjectFlags__Enum_CastShadow;
		    *v11 = HGObjectFlags__Enum_RealtimeShadowCaster|HGObjectFlags__Enum_CastShadow;
		    *v12 = HGRenderFlags__Enum_RealtimeShadowCaster|HGRenderFlags__Enum_CastShadow;
		    *v13 = HGRenderFlags__Enum_RealtimeShadowCaster|HGRenderFlags__Enum_CastShadow;
		    HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetShadowRenderType(
		      this,
		      v14,
		      isDynamicRequest,
		      &castStaticObjects,
		      &castDynamicObjects,
		      0LL);
		    v15 = castStaticObjects;
		    v16 = castDynamicObjects;
		    v17 = !castStaticObjects;
		    if ( castStaticObjects )
		    {
		      if ( !castDynamicObjects )
		      {
		        *objectFlags |= 0x4000000u;
		        *v11 |= 0x4000000u;
		        *v12 |= 0x1000000u;
		        *v13 |= 0x1000000u;
		      }
		      v17 = !v15;
		    }
		    if ( v16 && v17 )
		    {
		      *v11 |= 0x4000000u;
		      *v13 |= 0x1000000u;
		    }
		    if ( UnityEngine::HGSharedLightData::get_enableHDCharacterShadow_Injected(&lighta, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		      if ( HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::get_isActive(v18) )
		      {
		        Entity = HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(lighta, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGHDPLSCharacterShadowManager);
		        if ( HG::Rendering::Runtime::HGHDPLSCharacterShadowManager::IsHDPLSLight(Entity, 0LL) )
		          *v11 |= 0x10000000u;
		      }
		    }
		  }
		}
		
		private void PrepareRendererList(HGSharedLightData light, HGCamera hgCamera, ScriptableRenderContext context, Matrix4x4 viewProj, bool isDynamicRequest, ref RendererList rendererList) {} // 0x0000000189B4AED8-0x0000000189B4B2DC
		// Void PrepareRendererList(HGSharedLightData, HGCamera, ScriptableRenderContext, Matrix4x4, Boolean, RendererList ByRef)
		void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PrepareRendererList(
		        HGPunctualLightShadowManagerV2 *this,
		        HGSharedLightData light,
		        HGCamera *hgCamera,
		        ScriptableRenderContext context,
		        Matrix4x4 *viewProj,
		        bool isDynamicRequest,
		        RendererList *rendererList,
		        MethodInfo *method)
		{
		  RendererList nullRendererList; // xmm0
		  __int64 v11; // rdx
		  Camera *camera; // rcx
		  Matrix4x4 *v13; // rbx
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm1
		  HGPunctualLightShadowManagerV2__StaticFields *static_fields; // rdx
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  Plane__Array *s_cullPlanes; // rdx
		  int32_t i; // ebx
		  __int64 v23; // r9
		  CullingResults v24; // xmm6
		  PerObjectData__Enum RendererConfig; // eax
		  Camera *v26; // r9
		  int32_t v27; // ebx
		  __int128 v28; // xmm1
		  __int128 v29; // xmm0
		  __int128 v30; // xmm1
		  ShaderTagId v31; // [rsp+58h] [rbp-B0h] BYREF
		  CullingResults v32; // [rsp+68h] [rbp-A0h] BYREF
		  Plane v33; // [rsp+78h] [rbp-90h] BYREF
		  Matrix4x4 v34; // [rsp+88h] [rbp-80h] BYREF
		  RendererListDesc v35; // [rsp+C8h] [rbp-40h] BYREF
		  RendererListDesc v36; // [rsp+1A8h] [rbp+A0h] BYREF
		  ScriptableCullingParameters cullingParameters; // [rsp+288h] [rbp+180h] BYREF
		  HGSharedLightData _unity_self; // [rsp+900h] [rbp+7F8h] BYREF
		  ScriptableRenderContext v39; // [rsp+910h] [rbp+808h] BYREF
		
		  v39.m_Ptr = context.m_Ptr;
		  _unity_self = light;
		  sub_18033B9D0(&cullingParameters, 0LL, 1592LL);
		  v31.m_Id = 0;
		  sub_18033B9D0(&v35, 0LL, 224LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(2186, 0LL) )
		  {
		    if ( UnityEngine::HyperGryph::HGGraphicsUtils::get_enableECSRenderer(0LL) )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList);
		      nullRendererList = TypeInfo::UnityEngine::Rendering::RendererUtils::RendererList->static_fields->nullRendererList;
		LABEL_12:
		      *rendererList = nullRendererList;
		      return;
		    }
		    UnityEngine::HGSharedLightData::get_worldPosition(&v33.m_Normal, &_unity_self, 0LL);
		    if ( UnityEngine::HGSharedLightData::get_type_Injected(&_unity_self, 0LL) == LightType__Enum_Spot )
		      UnityEngine::HGSharedLightData::get_spotAngle_Injected(&_unity_self, 0LL);
		    if ( hgCamera )
		    {
		      camera = hgCamera->fields.camera;
		      if ( camera )
		      {
		        UnityEngine::Camera::TryGetCullingParameters(camera, &cullingParameters, 0LL);
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
		        v13 = viewProj;
		        v14 = *(_OWORD *)&viewProj->m01;
		        *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m20 = *(_OWORD *)&viewProj->m00;
		        v15 = *(_OWORD *)&viewProj->m02;
		        *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m21 = v14;
		        v16 = *(_OWORD *)&viewProj->m03;
		        *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m22 = v15;
		        *(_OWORD *)&cullingParameters.m_CameraProperties.cameraClipToWorld.m23 = v16;
		        UnityEngine::Rendering::ScriptableCullingParameters::set_isOrthographic(&cullingParameters, 0, 0LL);
		        cullingParameters.m_CameraProperties.cameraWorldToClip.m31 = 0.0;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		        v17 = *(_OWORD *)&v13->m01;
		        *(_OWORD *)&v34.m00 = *(_OWORD *)&v13->m00;
		        static_fields = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields;
		        v19 = *(_OWORD *)&v13->m02;
		        *(_OWORD *)&v34.m01 = v17;
		        v20 = *(_OWORD *)&v13->m03;
		        s_cullPlanes = static_fields->s_cullPlanes;
		        *(_OWORD *)&v34.m02 = v19;
		        *(_OWORD *)&v34.m03 = v20;
		        UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v34, s_cullPlanes, 0LL);
		        for ( i = 0; i < 6; ++i )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		          camera = (Camera *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_cullPlanes;
		          if ( !camera )
		            goto LABEL_14;
		          sub_180002990(camera, &v33, i, v23);
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableCullingParameters);
		          v32 = (CullingResults)v33;
		          UnityEngine::Rendering::ScriptableCullingParameters::SetCullingPlane(
		            &cullingParameters,
		            i,
		            (Plane *)&v32,
		            0LL);
		        }
		        sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		        v24 = *UnityEngine::Rendering::ScriptableRenderContext::Cull(&v32, &v39, &cullingParameters, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderPassNames);
		        UnityEngine::Rendering::ShaderTagId::ShaderTagId(
		          &v31,
		          TypeInfo::HG::Rendering::Runtime::HGShaderPassNames->static_fields->s_ShadowCasterStr,
		          0LL);
		        RendererConfig = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetRendererConfig(
		                           this,
		                           _unity_self,
		                           isDynamicRequest,
		                           0LL);
		        v26 = hgCamera->fields.camera;
		        v27 = RendererConfig;
		        v32 = v24;
		        UnityEngine::Rendering::RendererUtils::RendererListDesc::RendererListDesc(&v35, v31, &v32, v26, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderQueue);
		        v35.renderQueueRange = TypeInfo::HG::Rendering::Runtime::HGRenderQueue->static_fields->k_RenderQueue_AllOpaque;
		        v35.sortingCriteria = 59;
		        v35.rendererConfiguration = v27;
		        v36 = v35;
		        nullRendererList = *UnityEngine::Rendering::ScriptableRenderContext::CreateRendererList(
		                              (RendererList *)&v32,
		                              &v39,
		                              &v36,
		                              0LL);
		        goto LABEL_12;
		      }
		    }
		LABEL_14:
		    sub_1800D8260(camera, v11);
		  }
		  camera = (Camera *)IFix::WrappersManagerImpl::GetPatch(2186, 0LL);
		  if ( !camera )
		    goto LABEL_14;
		  v28 = *(_OWORD *)&viewProj->m01;
		  *(_OWORD *)&v34.m00 = *(_OWORD *)&viewProj->m00;
		  v29 = *(_OWORD *)&viewProj->m02;
		  *(_OWORD *)&v34.m01 = v28;
		  v30 = *(_OWORD *)&viewProj->m03;
		  *(_OWORD *)&v34.m02 = v29;
		  *(_OWORD *)&v34.m03 = v30;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_877(
		    (ILFixDynamicMethodWrapper_2 *)camera,
		    (Object *)this,
		    _unity_self,
		    (Object *)hgCamera,
		    v39,
		    &v34,
		    isDynamicRequest,
		    rendererList,
		    0LL);
		}
		
		private void PrepareECSRendererList(HGSharedLightData light, HGCamera hgCamera, ScriptableRenderContext context, Matrix4x4 worldToShadow, Matrix4x4 view, float projM11, bool isDynamicRequest, ref uint ecsShadowRendererList, ref uint ecsShadowGrassRendererList, ref uint ecsShadowTreeRendererList) {} // 0x0000000189B48D50-0x0000000189B49990
		// Void PrepareECSRendererList(HGSharedLightData, HGCamera, ScriptableRenderContext, Matrix4x4, Matrix4x4, Single, Boolean, UInt32 ByRef, UInt32 ByRef, UInt32 ByRef)
		void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PrepareECSRendererList(
		        HGPunctualLightShadowManagerV2 *this,
		        HGSharedLightData light,
		        HGCamera *hgCamera,
		        ScriptableRenderContext context,
		        Matrix4x4 *worldToShadow,
		        Matrix4x4 *view,
		        float projM11,
		        bool isDynamicRequest,
		        uint32_t *ecsShadowRendererList,
		        uint32_t *ecsShadowGrassRendererList,
		        uint32_t *ecsShadowTreeRendererList,
		        MethodInfo *method)
		{
		  HGPunctualLightShadowManagerV2 *v12; // r12
		  HGCamera *v14; // rsi
		  bool enableOBBCullingBox_Injected; // al
		  int32_t v16; // edx
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  __m128 *inverse; // rax
		  __m128 v21; // xmm8
		  __m128 v22; // xmm6
		  float v23; // xmm7_4
		  Vector3 *worldPosition; // rax
		  float z; // r14d
		  __int64 v26; // xmm9_8
		  __int64 v27; // xmm11_8
		  Vector3 *overrideShadowLightPosition; // rax
		  Plane__Array *s_cullPlanes; // rdi
		  float shadowNearPlane_Injected; // xmm0_4
		  unsigned __int64 v31; // xmm8_8
		  MethodInfo *v32; // r9
		  Vector3 *v33; // rax
		  __int64 v34; // xmm3_8
		  MethodInfo *v35; // r9
		  Vector3 *v36; // rax
		  __int64 v37; // xmm3_8
		  __int64 v38; // rdx
		  Camera *camera; // rcx
		  Plane__Array *v40; // r13
		  MethodInfo *v41; // r8
		  Vector3 *v42; // rax
		  __int64 v43; // xmm6_8
		  float v44; // edi
		  float shadowFarPlane_Injected; // xmm0_4
		  MethodInfo *v46; // r9
		  Vector3 *v47; // rax
		  __int64 v48; // xmm3_8
		  MethodInfo *v49; // r9
		  Vector3 *v50; // rax
		  __int64 v51; // xmm3_8
		  Void *m_Buffer; // r15
		  int i; // edi
		  __int64 v54; // r9
		  Vector3 *cullingBoxRelativePosition; // rax
		  __int64 v56; // xmm0_8
		  MethodInfo *v57; // r9
		  Vector3 *v58; // rax
		  __int64 v59; // xmm10_8
		  float v60; // r13d
		  Vector3 *cullingBoxHalfExtents; // rax
		  float v62; // r14d
		  Vector3 *cullingBoxOrientation; // rax
		  __int64 v64; // xmm0_8
		  __int64 v65; // r8
		  __int64 v66; // r9
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *v67; // rdi
		  MethodInfo *v68; // rdx
		  Vector3 *fwd; // rax
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ v70; // xmm0
		  __int64 v71; // xmm3_8
		  Vector3 *v72; // rax
		  __int64 v73; // xmm7_8
		  float v74; // r15d
		  MethodInfo *v75; // rdx
		  Vector3 *up; // rax
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ v77; // xmm0
		  __int64 v78; // xmm3_8
		  Vector3 *v79; // rax
		  __int64 v80; // xmm8_8
		  float v81; // r12d
		  MethodInfo *v82; // rdx
		  Vector3 *right; // rax
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ v84; // xmm0
		  __int64 v85; // xmm1_8
		  Vector3 *v86; // rax
		  __int64 v87; // xmm9_8
		  MethodInfo *v88; // r9
		  Vector3 *v89; // rax
		  __int64 v90; // xmm3_8
		  MethodInfo *v91; // r9
		  Vector3 *v92; // rax
		  __int64 v93; // xmm3_8
		  MethodInfo *v94; // r8
		  Vector3 *v95; // rax
		  __int64 v96; // xmm4_8
		  Quaternion *v97; // rsi
		  MethodInfo *v98; // r9
		  Vector3 *v99; // rax
		  __int64 v100; // xmm3_8
		  MethodInfo *v101; // r9
		  Vector3 *v102; // rax
		  __int64 v103; // xmm3_8
		  float y; // xmm2_4
		  MethodInfo *v105; // r9
		  Vector3 *v106; // rax
		  __int64 v107; // xmm3_8
		  MethodInfo *v108; // r9
		  Vector3 *v109; // rax
		  __int64 v110; // xmm3_8
		  MethodInfo *v111; // r8
		  Vector3 *v112; // rax
		  __int64 v113; // xmm4_8
		  float v114; // xmm2_4
		  MethodInfo *v115; // r9
		  Vector3 *v116; // rax
		  __int64 v117; // xmm3_8
		  MethodInfo *v118; // r9
		  Vector3 *v119; // rax
		  __int64 v120; // xmm3_8
		  float x; // xmm2_4
		  MethodInfo *v122; // r9
		  Vector3 *v123; // rax
		  __int64 v124; // xmm3_8
		  MethodInfo *v125; // r9
		  Vector3 *v126; // rax
		  __int64 v127; // xmm3_8
		  MethodInfo *v128; // r8
		  Vector3 *v129; // rax
		  __int64 v130; // xmm4_8
		  float v131; // xmm2_4
		  MethodInfo *v132; // r9
		  Vector3 *v133; // rax
		  __int64 v134; // xmm3_8
		  MethodInfo *v135; // r9
		  Vector3 *v136; // rax
		  __int64 v137; // xmm3_8
		  bool v138; // di
		  __int128 v139; // xmm1
		  __int128 v140; // xmm0
		  uint32_t cullingMask; // r14d
		  int32_t v142; // edi
		  Camera *v143; // rdi
		  uint64_t SceneCullingMaskFromCamera; // rax
		  uint32_t v145; // r12d
		  HGRenderFlags__Enum v146; // r15d
		  HGRenderFlags__Enum v147; // r14d
		  uint32_t RendererList; // esi
		  uint32_t v149; // eax
		  __int128 v150; // xmm1
		  __int128 v151; // xmm0
		  __int128 v152; // xmm1
		  __int128 v153; // xmm1
		  __int128 v154; // xmm0
		  __int128 v155; // xmm1
		  HGRenderKeyword__Enum methoda; // [rsp+28h] [rbp-E0h]
		  float m_punctualLightShadowScreenSizeMinSquared; // [rsp+40h] [rbp-C8h]
		  Vector3 v158; // [rsp+78h] [rbp-90h] BYREF
		  Vector3 v159; // [rsp+88h] [rbp-80h] BYREF
		  Vector3 v160; // [rsp+98h] [rbp-70h] BYREF
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ v161; // [rsp+A8h] [rbp-60h] BYREF
		  Vector3 v162; // [rsp+B8h] [rbp-50h] BYREF
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ v163; // [rsp+C8h] [rbp-40h] BYREF
		  float v164; // [rsp+D8h] [rbp-30h]
		  HGObjectFlags__Enum objectFlagsMask; // [rsp+DCh] [rbp-2Ch] BYREF
		  HGObjectFlags__Enum objectFlags; // [rsp+E0h] [rbp-28h] BYREF
		  HGRenderFlags__Enum renderFlags; // [rsp+E4h] [rbp-24h] BYREF
		  HGRenderFlags__Enum renderFlagsMask; // [rsp+E8h] [rbp-20h] BYREF
		  float v169; // [rsp+ECh] [rbp-1Ch]
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ v170; // [rsp+F8h] [rbp-10h] BYREF
		  LODCrossFadeConfig v171; // [rsp+108h] [rbp+0h] BYREF
		  Matrix4x4 v172; // [rsp+148h] [rbp+40h] BYREF
		  Matrix4x4 v173[2]; // [rsp+188h] [rbp+80h] BYREF
		  HGSharedLightData _unity_self; // [rsp+270h] [rbp+168h] BYREF
		  HGCamera *v176; // [rsp+278h] [rbp+170h]
		
		  v176 = hgCamera;
		  _unity_self = light;
		  v12 = this;
		  objectFlags = HGObjectFlags__Enum_None;
		  objectFlagsMask = HGObjectFlags__Enum_None;
		  v14 = hgCamera;
		  renderFlags = HGRenderFlags__Enum_None;
		  v170 = 0LL;
		  renderFlagsMask = HGRenderFlags__Enum_None;
		  memset(&v171, 0, sizeof(v171));
		  if ( !IFix::WrappersManagerImpl::IsPatched(2187, 0LL) )
		  {
		    enableOBBCullingBox_Injected = UnityEngine::HGSharedLightData::get_enableOBBCullingBox_Injected(&_unity_self, 0LL);
		    v16 = 6;
		    if ( enableOBBCullingBox_Injected )
		      v16 = 12;
		    Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::NativeArray(
		      &v170,
		      v16,
		      Allocator__Enum_Temp,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		    v17 = *(_OWORD *)&worldToShadow->m01;
		    *(_OWORD *)&v173[0].m00 = *(_OWORD *)&worldToShadow->m00;
		    v18 = *(_OWORD *)&worldToShadow->m02;
		    *(_OWORD *)&v173[0].m01 = v17;
		    v19 = *(_OWORD *)&worldToShadow->m03;
		    *(_OWORD *)&v173[0].m02 = v18;
		    *(_OWORD *)&v173[0].m03 = v19;
		    UnityEngine::GeometryUtility::CalculateFrustumPlanes(
		      v173,
		      TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_cullPlanes,
		      0LL);
		    inverse = (__m128 *)UnityEngine::Matrix4x4::get_inverse(v173, view, 0LL);
		    v21 = _mm_xor_ps(inverse[2], (__m128)0x80000000);
		    v22 = _mm_xor_ps((__m128)inverse[2].m128_u32[1], (__m128)0x80000000);
		    v23 = -inverse[2].m128_f32[2];
		    worldPosition = UnityEngine::HGSharedLightData::get_worldPosition(&v158, &_unity_self, 0LL);
		    z = worldPosition->z;
		    v26 = *(_QWORD *)&worldPosition->x;
		    v169 = z;
		    v27 = v26;
		    v164 = z;
		    if ( UnityEngine::HGSharedLightData::get_enableOverrideShadowLight_Injected(&_unity_self, 0LL) )
		    {
		      overrideShadowLightPosition = UnityEngine::HGSharedLightData::get_overrideShadowLightPosition(
		                                      &v158,
		                                      &_unity_self,
		                                      0LL);
		      z = overrideShadowLightPosition->z;
		      v27 = *(_QWORD *)&overrideShadowLightPosition->x;
		      v164 = z;
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		    s_cullPlanes = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_cullPlanes;
		    shadowNearPlane_Injected = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&_unity_self, 0LL);
		    v31 = _mm_unpacklo_ps(v21, v22).m128_u64[0];
		    *(_QWORD *)&v162.x = v31;
		    v162.z = v23;
		    v33 = UnityEngine::Vector3::op_Multiply(&v158, &v162, shadowNearPlane_Injected, v32);
		    *(_QWORD *)&v159.x = v27;
		    v159.z = z;
		    v34 = *(_QWORD *)&v33->x;
		    *(float *)&v33 = v33->z;
		    *(_QWORD *)&v162.x = v34;
		    LODWORD(v162.z) = (_DWORD)v33;
		    v163 = 0LL;
		    v36 = UnityEngine::Vector3::op_Addition(&v158, &v159, &v162, v35);
		    v162.z = v23;
		    *(_QWORD *)&v162.x = v31;
		    v37 = *(_QWORD *)&v36->x;
		    *(float *)&v36 = v36->z;
		    *(_QWORD *)&v159.x = v37;
		    LODWORD(v159.z) = (_DWORD)v36;
		    UnityEngine::Plane::Plane((Plane *)&v163, &v162, &v159, 0LL);
		    if ( s_cullPlanes )
		    {
		      v161 = v163;
		      sub_18003FEF0(s_cullPlanes, 4LL, &v161);
		      v159.z = v23;
		      *(_QWORD *)&v159.x = v31;
		      v40 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_cullPlanes;
		      v42 = UnityEngine::Vector3::op_UnaryNegation(&v158, &v159, v41);
		      v43 = *(_QWORD *)&v42->x;
		      v44 = v42->z;
		      shadowFarPlane_Injected = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&_unity_self, 0LL);
		      v159.z = v23;
		      *(_QWORD *)&v159.x = v31;
		      v47 = UnityEngine::Vector3::op_Multiply(&v158, &v159, shadowFarPlane_Injected, v46);
		      *(_QWORD *)&v162.x = v27;
		      v162.z = z;
		      v48 = *(_QWORD *)&v47->x;
		      *(float *)&v47 = v47->z;
		      *(_QWORD *)&v159.x = v48;
		      LODWORD(v159.z) = (_DWORD)v47;
		      v163 = 0LL;
		      v50 = UnityEngine::Vector3::op_Addition(&v158, &v162, &v159, v49);
		      *(_QWORD *)&v162.x = v43;
		      v162.z = v44;
		      v51 = *(_QWORD *)&v50->x;
		      *(float *)&v50 = v50->z;
		      *(_QWORD *)&v159.x = v51;
		      LODWORD(v159.z) = (_DWORD)v50;
		      UnityEngine::Plane::Plane((Plane *)&v163, &v162, &v159, 0LL);
		      if ( v40 )
		      {
		        v161 = v163;
		        sub_18003FEF0(v40, 5LL, &v161);
		        m_Buffer = v170.m_Buffer;
		        for ( i = 0; i < 6; ++i )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		          camera = (Camera *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_cullPlanes;
		          if ( !camera )
		            goto LABEL_23;
		          sub_180002990(camera, &v161, i, v54);
		          *(NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)m_Buffer = v161;
		          m_Buffer += 16;
		        }
		        if ( UnityEngine::HGSharedLightData::get_enableOBBCullingBox_Injected(&_unity_self, 0LL) )
		        {
		          cullingBoxRelativePosition = UnityEngine::HGSharedLightData::get_cullingBoxRelativePosition(
		                                         &v158,
		                                         &_unity_self,
		                                         0LL);
		          *(_QWORD *)&v162.x = v26;
		          v56 = *(_QWORD *)&cullingBoxRelativePosition->x;
		          v159.z = cullingBoxRelativePosition->z;
		          v162.z = v169;
		          *(_QWORD *)&v159.x = v56;
		          v58 = UnityEngine::Vector3::op_Addition(&v158, &v162, &v159, v57);
		          v59 = *(_QWORD *)&v58->x;
		          v60 = v58->z;
		          cullingBoxHalfExtents = UnityEngine::HGSharedLightData::get_cullingBoxHalfExtents(&v158, &_unity_self, 0LL);
		          v62 = cullingBoxHalfExtents->z;
		          *(_QWORD *)&v162.x = *(_QWORD *)&cullingBoxHalfExtents->x;
		          cullingBoxOrientation = UnityEngine::HGSharedLightData::get_cullingBoxOrientation(&v158, &_unity_self, 0LL);
		          v64 = *(_QWORD *)&cullingBoxOrientation->x;
		          *(float *)&cullingBoxOrientation = cullingBoxOrientation->z;
		          *(_QWORD *)&v159.x = v64;
		          LODWORD(v159.z) = (_DWORD)cullingBoxOrientation;
		          v67 = (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)sub_182FA5910(&v163, &v159, v65, v66);
		          fwd = UnityEngine::Vector3::get_fwd(&v158, v68);
		          v70 = *v67;
		          v71 = *(_QWORD *)&fwd->x;
		          v159.z = fwd->z;
		          *(_QWORD *)&v159.x = v71;
		          v161 = v70;
		          v72 = UnityEngine::Quaternion::op_Multiply(&v160, (Quaternion *)&v161, &v159, 0LL);
		          v73 = *(_QWORD *)&v72->x;
		          v74 = v72->z;
		          up = UnityEngine::Vector3::get_up(&v158, v75);
		          v77 = *v67;
		          v78 = *(_QWORD *)&up->x;
		          v159.z = up->z;
		          *(_QWORD *)&v159.x = v78;
		          v161 = v77;
		          v79 = UnityEngine::Quaternion::op_Multiply(&v158, (Quaternion *)&v161, &v159, 0LL);
		          v80 = *(_QWORD *)&v79->x;
		          v81 = v79->z;
		          right = UnityEngine::Vector3::get_right(&v158, v82);
		          v84 = *v67;
		          v85 = *(_QWORD *)&right->x;
		          *(float *)&right = right->z;
		          *(_QWORD *)&v159.x = v85;
		          LODWORD(v159.z) = (_DWORD)right;
		          v161 = v84;
		          v86 = UnityEngine::Quaternion::op_Multiply(&v158, (Quaternion *)&v161, &v159, 0LL);
		          v87 = *(_QWORD *)&v86->x;
		          *(float *)&v67 = v86->z;
		          *(_QWORD *)&v158.x = v73;
		          v158.z = v74;
		          *(_QWORD *)&v159.x = v73;
		          v159.z = v74;
		          v89 = UnityEngine::Vector3::op_Multiply(&v160, &v159, v62, v88);
		          v90 = *(_QWORD *)&v89->x;
		          *(float *)&v89 = v89->z;
		          *(_QWORD *)&v159.x = v90;
		          LODWORD(v159.z) = (_DWORD)v89;
		          *(_QWORD *)&v160.x = v59;
		          v160.z = v60;
		          v161 = 0LL;
		          v92 = UnityEngine::Vector3::op_Addition((Vector3 *)&v163, &v160, &v159, v91);
		          v93 = *(_QWORD *)&v92->x;
		          *(float *)&v92 = v92->z;
		          *(_QWORD *)&v160.x = v93;
		          LODWORD(v160.z) = (_DWORD)v92;
		          v95 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v163, &v158, v94);
		          v96 = *(_QWORD *)&v95->x;
		          *(float *)&v95 = v95->z;
		          *(_QWORD *)&v158.x = v96;
		          LODWORD(v158.z) = (_DWORD)v95;
		          UnityEngine::Plane::Plane((Plane *)&v161, &v158, &v160, 0LL);
		          v97 = (Quaternion *)v170.m_Buffer;
		          *(_QWORD *)&v158.x = v73;
		          v158.z = v74;
		          *(NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v170.m_Buffer[96] = v161;
		          v99 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v163, &v158, v62, v98);
		          *(_QWORD *)&v160.x = v59;
		          v160.z = v60;
		          v100 = *(_QWORD *)&v99->x;
		          *(float *)&v99 = v99->z;
		          *(_QWORD *)&v158.x = v100;
		          LODWORD(v158.z) = (_DWORD)v99;
		          v161 = 0LL;
		          v102 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v163, &v160, &v158, v101);
		          *(_QWORD *)&v160.x = v73;
		          v160.z = v74;
		          v103 = *(_QWORD *)&v102->x;
		          *(float *)&v102 = v102->z;
		          *(_QWORD *)&v158.x = v103;
		          LODWORD(v158.z) = (_DWORD)v102;
		          UnityEngine::Plane::Plane((Plane *)&v161, &v160, &v158, 0LL);
		          v159.z = v81;
		          y = v162.y;
		          v97[7] = (Quaternion)v161;
		          v158.z = v81;
		          *(_QWORD *)&v159.x = v80;
		          *(_QWORD *)&v158.x = v80;
		          v106 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v163, &v158, y, v105);
		          v107 = *(_QWORD *)&v106->x;
		          *(float *)&v106 = v106->z;
		          *(_QWORD *)&v158.x = v107;
		          LODWORD(v158.z) = (_DWORD)v106;
		          *(_QWORD *)&v160.x = v59;
		          v160.z = v60;
		          v161 = 0LL;
		          v109 = UnityEngine::Vector3::op_Addition((Vector3 *)&v163, &v160, &v158, v108);
		          v110 = *(_QWORD *)&v109->x;
		          *(float *)&v109 = v109->z;
		          *(_QWORD *)&v158.x = v110;
		          LODWORD(v158.z) = (_DWORD)v109;
		          v112 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v163, &v159, v111);
		          v113 = *(_QWORD *)&v112->x;
		          *(float *)&v112 = v112->z;
		          *(_QWORD *)&v160.x = v113;
		          LODWORD(v160.z) = (_DWORD)v112;
		          UnityEngine::Plane::Plane((Plane *)&v161, &v160, &v158, 0LL);
		          v158.z = v81;
		          v114 = v162.y;
		          v97[8] = (Quaternion)v161;
		          *(_QWORD *)&v158.x = v80;
		          v116 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v163, &v158, v114, v115);
		          *(_QWORD *)&v160.x = v59;
		          v160.z = v60;
		          v117 = *(_QWORD *)&v116->x;
		          *(float *)&v116 = v116->z;
		          *(_QWORD *)&v158.x = v117;
		          LODWORD(v158.z) = (_DWORD)v116;
		          v161 = 0LL;
		          v119 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v163, &v160, &v158, v118);
		          *(_QWORD *)&v160.x = v80;
		          v160.z = v81;
		          v120 = *(_QWORD *)&v119->x;
		          *(float *)&v119 = v119->z;
		          *(_QWORD *)&v158.x = v120;
		          LODWORD(v158.z) = (_DWORD)v119;
		          UnityEngine::Plane::Plane((Plane *)&v161, &v160, &v158, 0LL);
		          LODWORD(v159.z) = (_DWORD)v67;
		          x = v162.x;
		          v97[9] = (Quaternion)v161;
		          LODWORD(v158.z) = (_DWORD)v67;
		          *(_QWORD *)&v159.x = v87;
		          *(_QWORD *)&v158.x = v87;
		          v123 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v163, &v158, x, v122);
		          *(_QWORD *)&v160.x = v59;
		          v160.z = v60;
		          v124 = *(_QWORD *)&v123->x;
		          *(float *)&v123 = v123->z;
		          *(_QWORD *)&v158.x = v124;
		          LODWORD(v158.z) = (_DWORD)v123;
		          v161 = 0LL;
		          v126 = UnityEngine::Vector3::op_Addition((Vector3 *)&v163, &v160, &v158, v125);
		          v127 = *(_QWORD *)&v126->x;
		          *(float *)&v126 = v126->z;
		          *(_QWORD *)&v158.x = v127;
		          LODWORD(v158.z) = (_DWORD)v126;
		          v129 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&v163, &v159, v128);
		          v130 = *(_QWORD *)&v129->x;
		          *(float *)&v129 = v129->z;
		          *(_QWORD *)&v160.x = v130;
		          LODWORD(v160.z) = (_DWORD)v129;
		          UnityEngine::Plane::Plane((Plane *)&v161, &v160, &v158, 0LL);
		          LODWORD(v158.z) = (_DWORD)v67;
		          v131 = v162.x;
		          v97[10] = (Quaternion)v161;
		          *(_QWORD *)&v158.x = v87;
		          v133 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v163, &v158, v131, v132);
		          *(_QWORD *)&v160.x = v59;
		          v160.z = v60;
		          v134 = *(_QWORD *)&v133->x;
		          *(float *)&v133 = v133->z;
		          *(_QWORD *)&v158.x = v134;
		          LODWORD(v158.z) = (_DWORD)v133;
		          v161 = 0LL;
		          v136 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v163, &v160, &v158, v135);
		          *(_QWORD *)&v160.x = v87;
		          LODWORD(v160.z) = (_DWORD)v67;
		          v137 = *(_QWORD *)&v136->x;
		          *(float *)&v136 = v136->z;
		          *(_QWORD *)&v158.x = v137;
		          LODWORD(v158.z) = (_DWORD)v136;
		          UnityEngine::Plane::Plane((Plane *)&v161, &v160, &v158, 0LL);
		          z = v164;
		          v12 = this;
		          v97[11] = (Quaternion)v161;
		          v14 = v176;
		        }
		        if ( v14 )
		        {
		          v138 = isDynamicRequest;
		          v139 = *(_OWORD *)&v14->fields.lodCrossFadeConfig.c0.y;
		          *(_OWORD *)&v171.cameraPosition.x = *(_OWORD *)&v14->fields.lodCrossFadeConfig.cameraPosition.x;
		          v140 = *(_OWORD *)&v14->fields.lodCrossFadeConfig.c1.z;
		          *(_OWORD *)&v171.c0.y = v139;
		          *(_QWORD *)&v171.maxProjFactorSquared1 = *(_QWORD *)&v14->fields.lodCrossFadeConfig.maxProjFactorSquared1;
		          *(_OWORD *)&v171.c1.z = v140;
		          if ( !isDynamicRequest )
		          {
		            v171.c1.z = z;
		            *(_QWORD *)&v171.c1.x = v27;
		            *(_QWORD *)&v171.c0.x = v27;
		            v171.maxProjFactorSquared1 = projM11 * projM11;
		            v171.maxProjFactorSquared0 = projM11 * projM11;
		            v171.c0.z = z;
		            *(_QWORD *)&v171.cameraPosition.x = v27;
		            v171.cameraPosition.z = z;
		          }
		          v171.enableDither = 0;
		          HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetECSRenderFlags(
		            v12,
		            _unity_self,
		            isDynamicRequest,
		            &objectFlags,
		            &objectFlagsMask,
		            &renderFlags,
		            &renderFlagsMask,
		            0LL);
		          camera = v14->fields.camera;
		          if ( v138 )
		          {
		            if ( camera )
		            {
		              cullingMask = UnityEngine::Camera::get_cullingMask(camera, 0LL);
		LABEL_21:
		              v143 = v14->fields.camera;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		              SceneCullingMaskFromCamera = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(v143, 0LL);
		              m_punctualLightShadowScreenSizeMinSquared = v12->fields.m_punctualLightShadowScreenSizeMinSquared;
		              v161 = v170;
		              v145 = UnityEngine::HyperGryph::HGCullingSystem::AddCullViewByPlanes(
		                       (NativeArray_1_UnityEngine_Plane_ *)&v161,
		                       0,
		                       SceneCullingMaskFromCamera,
		                       cullingMask,
		                       objectFlags,
		                       objectFlagsMask,
		                       &v171,
		                       m_punctualLightShadowScreenSizeMinSquared,
		                       CameraType__Enum_Shadow,
		                       0LL);
		              UnityEngine::HyperGryph::HGCullingSystem::DispatchBatchCullingJobs(0LL);
		              sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		              v146 = renderFlags;
		              v147 = renderFlagsMask;
		              LOWORD(methoda) = 0;
		              RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                               v145,
		                               (HGRenderFlags__Enum)(renderFlagsMask | 0x100),
		                               (HGRenderFlags__Enum)(renderFlags | 0x100),
		                               HGShaderLightMode__Enum_ShadowCaster,
		                               methoda,
		                               context.m_Ptr,
		                               0,
		                               0,
		                               0xFFFFFFFF,
		                               0,
		                               0,
		                               0LL);
		              LODWORD(v143) = UnityEngine::HyperGryph::HGGrassRender::CreateRendererList(
		                                v145,
		                                (HGRenderFlags__Enum)(v147 | 0x100),
		                                (HGRenderFlags__Enum)(v146 | 0x100),
		                                HGShaderLightMode__Enum_ShadowCaster,
		                                context.m_Ptr,
		                                0,
		                                0LL);
		              v149 = UnityEngine::HyperGryph::HGTreeRender::CreateRendererList(
		                       v145,
		                       (HGRenderFlags__Enum)(v147 | 0x100),
		                       (HGRenderFlags__Enum)(v146 | 0x100),
		                       HGShaderLightMode__Enum_ShadowCaster,
		                       context.m_Ptr,
		                       0,
		                       0LL);
		              *ecsShadowRendererList = RendererList;
		              *ecsShadowGrassRendererList = (unsigned int)v143;
		              *ecsShadowTreeRendererList = v149;
		              return;
		            }
		          }
		          else if ( camera )
		          {
		            v142 = UnityEngine::Camera::get_cullingMask(camera, 0LL);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		            cullingMask = v142 & ~TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields->COMPOUND_CHARACTER_LAYER_MASK;
		            goto LABEL_21;
		          }
		        }
		      }
		    }
		LABEL_23:
		    sub_1800D8260(camera, v38);
		  }
		  camera = (Camera *)IFix::WrappersManagerImpl::GetPatch(2187, 0LL);
		  if ( !camera )
		    goto LABEL_23;
		  v150 = *(_OWORD *)&view->m01;
		  *(_OWORD *)&v173[0].m00 = *(_OWORD *)&view->m00;
		  v151 = *(_OWORD *)&view->m02;
		  *(_OWORD *)&v173[0].m01 = v150;
		  v152 = *(_OWORD *)&view->m03;
		  *(_OWORD *)&v173[0].m02 = v151;
		  *(_OWORD *)&v173[0].m03 = v152;
		  v153 = *(_OWORD *)&worldToShadow->m01;
		  *(_OWORD *)&v172.m00 = *(_OWORD *)&worldToShadow->m00;
		  v154 = *(_OWORD *)&worldToShadow->m02;
		  *(_OWORD *)&v172.m01 = v153;
		  v155 = *(_OWORD *)&worldToShadow->m03;
		  *(_OWORD *)&v172.m02 = v154;
		  *(_OWORD *)&v172.m03 = v155;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_878(
		    (ILFixDynamicMethodWrapper_2 *)camera,
		    (Object *)v12,
		    _unity_self,
		    (Object *)v14,
		    context,
		    &v172,
		    v173,
		    projM11,
		    isDynamicRequest,
		    ecsShadowRendererList,
		    ecsShadowGrassRendererList,
		    ecsShadowTreeRendererList,
		    0LL);
		}
		
		private float GetPunctualLightShadowStrength(HGSharedLightData light, Vector3 cameraPos) => default; // 0x0000000189B484BC-0x0000000189B4861C
		// Single GetPunctualLightShadowStrength(HGSharedLightData, Vector3)
		float HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetPunctualLightShadowStrength(
		        HGPunctualLightShadowManagerV2 *this,
		        HGSharedLightData light,
		        Vector3 *cameraPos,
		        MethodInfo *method)
		{
		  float shadowStrength_Injected; // xmm0_4
		  float v7; // eax
		  float v8; // xmm9_4
		  Vector3 *worldPosition; // rax
		  __int64 v10; // xmm1_8
		  MethodInfo *v11; // r9
		  Vector3 *v12; // rax
		  __int64 v13; // xmm3_8
		  float v14; // xmm6_4
		  float v15; // xmm8_4
		  float v16; // xmm7_4
		  float v17; // xmm8_4
		  float result; // xmm0_4
		  Beyond::JobMathf *v19; // rcx
		  __int64 v20; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v23; // [rsp+38h] [rbp-19h] BYREF
		  Vector3 v24; // [rsp+48h] [rbp-9h] BYREF
		  Vector3 v25[6]; // [rsp+58h] [rbp+7h] BYREF
		  HGSharedLightData _unity_self; // [rsp+C0h] [rbp+6Fh] BYREF
		
		  _unity_self = light;
		  if ( IFix::WrappersManagerImpl::IsPatched(2188, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2188, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v20);
		    z = cameraPos->z;
		    *(_QWORD *)&v24.x = *(_QWORD *)&cameraPos->x;
		    v24.z = z;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_879(Patch, (Object *)this, _unity_self, &v24, 0LL);
		  }
		  else
		  {
		    shadowStrength_Injected = UnityEngine::HGSharedLightData::get_shadowStrength_Injected(&_unity_self, 0LL);
		    v7 = cameraPos->z;
		    *(_QWORD *)&v23.x = *(_QWORD *)&cameraPos->x;
		    v8 = shadowStrength_Injected;
		    v23.z = v7;
		    worldPosition = UnityEngine::HGSharedLightData::get_worldPosition(v25, &_unity_self, 0LL);
		    v10 = *(_QWORD *)&worldPosition->x;
		    *(float *)&worldPosition = worldPosition->z;
		    *(_QWORD *)&v24.x = v10;
		    LODWORD(v24.z) = (_DWORD)worldPosition;
		    v12 = UnityEngine::Vector3::op_Subtraction(v25, &v24, &v23, v11);
		    v13 = *(_QWORD *)&v12->x;
		    *(float *)&v12 = v12->z;
		    *(_QWORD *)&v24.x = v13;
		    LODWORD(v24.z) = (_DWORD)v12;
		    v14 = sub_182F9FF00(&v24);
		    v15 = fminf(
		            UnityEngine::HGSharedLightData::get_shadowCullDistance_Injected(&_unity_self, 0LL),
		            this->fields.m_punctualLightForceCullDistance);
		    v16 = v15 - v14;
		    v17 = v15 - (float)(UnityEngine::HGSharedLightData::get_shadowFadeRatio_Injected(&_unity_self, 0LL) * v15);
		    result = 0.0;
		    Beyond::JobMathf::ClampedLerp(v19, v8, v16 / v17, *(float *)&v13);
		  }
		  return result;
		}
		
		internal void RenderPunctualLightShadows(HGRenderGraph renderGraph, HGCamera hgCamera, HGSettingParameters settingParams, ref ShadowResult shadowResult) {} // 0x0000000189B4B2DC-0x0000000189B4F6CC
		// Void RenderPunctualLightShadows(HGRenderGraph, HGCamera, HGSettingParameters, ShadowResult ByRef)
		// Hidden C++ exception states: #wind=4
		void HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::RenderPunctualLightShadows(
		        HGPunctualLightShadowManagerV2 *this,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        HGSettingParameters *settingParams,
		        ShadowResult *shadowResult,
		        MethodInfo *method)
		{
		  HGPunctualLightShadowManagerV2 *v9; // r14
		  HGPunctualLightStaticAtlasAllocator *punctualLightStaticAtlasAllocator; // rdx
		  unsigned __int64 camera; // rcx
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  __int64 v14; // xmm8_8
		  float z; // r12d
		  int32_t SlotCount; // r15d
		  RectInt v17; // xmm14
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *m_targetUpdateRequest; // rbx
		  HGPunctualLightShadowManagerV2_PunctualLightCacheUpdateRequest *v19; // rax
		  int32_t index; // edi
		  HGRenderFlags__Enum targetSlot; // ebx
		  Vector3 *v22; // rax
		  __int64 v23; // xmm6_8
		  float v24; // ebx
		  float v25; // xmm8_4
		  float v26; // xmm7_4
		  Matrix4x4 *localToWorldMatrix; // rax
		  __int128 v28; // xmm8
		  __int128 v29; // xmm9
		  __int128 v30; // xmm10
		  __int128 v31; // xmm11
		  float spotAngle_Injected; // xmm13_4
		  float v33; // xmm12_4
		  float v34; // xmm7_4
		  float shadowGuardAngle_Injected; // xmm6_4
		  Vector3 *overrideShadowLightPosition; // rax
		  __int64 v37; // xmm6_8
		  float v38; // ebx
		  __int64 v39; // r8
		  __int64 v40; // r9
		  Quaternion *v41; // rax
		  Matrix4x4 *v42; // rax
		  __int128 v43; // xmm8
		  __int128 v44; // xmm9
		  __int128 v45; // xmm10
		  __int128 v46; // xmm11
		  float overrideShadowLightSpotAngle_Injected; // xmm13_4
		  float shadowNearPlane_Injected; // xmm12_4
		  float shadowFarPlane_Injected; // xmm7_4
		  __int128 v50; // xmm7
		  __int128 v51; // xmm8
		  __int128 v52; // xmm10
		  __int128 v53; // xmm11
		  __int128 v54; // xmm12
		  __m128 v55; // xmm9
		  __int128 v56; // xmm13
		  __int128 v57; // xmm15
		  Matrix4x4 *ShadowTransform; // rax
		  Vector4__Array *m_punctualLightShadowParams; // rdi
		  float shadowNormalBias_Injected; // xmm0_4
		  Vector4 *ShadowBias; // rax
		  Vector4__Array *v62; // rdi
		  float v63; // xmm6_4
		  Vector4__Array *v64; // rdi
		  float shadowStrength_Injected; // xmm0_4
		  int32_t xMin; // r12d
		  int m_X; // r15d
		  int32_t yMin; // esi
		  int m_Y; // r14d
		  int32_t xMax; // edi
		  int32_t v71; // ebx
		  float v72; // xmm4_4
		  ProfilingSampler *v73; // rax
		  __int64 v74; // rdx
		  __int64 v75; // rcx
		  Object *v76; // rax
		  Object *v77; // rax
		  Object *v78; // rbx
		  __int64 v79; // rdx
		  HGPunctualLightShadowManagerV2__StaticFields *static_fields; // rcx
		  unsigned __int64 v81; // r8
		  signed __int64 v82; // rtt
		  Object *v83; // rbx
		  __int64 v84; // rdx
		  __int64 v85; // rcx
		  TextureHandle v86; // xmm0
		  Object *v87; // rbx
		  __int64 v88; // rdx
		  __int64 v89; // rcx
		  float shadowBias_Injected; // xmm0_4
		  HGSharedLightData v91; // rbx
		  HGRenderGraphContext *HGContext; // rax
		  __int64 v93; // rdx
		  __int64 v94; // rcx
		  ScriptableRenderContext v95; // rdi
		  Matrix4x4 *v96; // rax
		  __int64 v97; // rdx
		  HGCamera *v98; // r12
		  HGSharedLightData v99; // rbx
		  HGRenderGraphContext *v100; // rax
		  __int64 v101; // rdx
		  __int64 v102; // rcx
		  void *m_Ptr; // rdi
		  float v104; // xmm9_4
		  uint32_t *v105; // rsi
		  uint32_t *v106; // r15
		  unsigned __int8 (__fastcall *v107)(HGSharedLightData *); // rax
		  HGPunctualLightShadowManagerV2__StaticFields *v108; // rcx
		  Matrix4x4 *inverse; // rax
		  __m128 v110; // xmm8
		  __m128 v111; // xmm6
		  __m128 v112; // xmm7
		  __m128 v113; // xmm8
		  __m128 v114; // xmm6
		  float v115; // xmm7_4
		  Vector3 *worldPosition; // rax
		  uint32_t *v117; // xmm12_8
		  uint32_t *v118; // xmm11_8
		  unsigned __int32 v119; // r15d
		  Vector3 *v120; // rax
		  Plane__Array *s_cullPlanes; // rbx
		  float v122; // xmm0_4
		  __m128 v123; // xmm2
		  __m128 v124; // xmm1
		  Vector3 *v125; // rax
		  __int64 v126; // rdx
		  __int64 v127; // rcx
		  __int64 v128; // r8
		  Plane__Array *v129; // rbx
		  Vector3 *v130; // rax
		  __int64 v131; // xmm10_8
		  float v132; // esi
		  float v133; // xmm0_4
		  Vector3 *v134; // rax
		  __int64 v135; // xmm1_8
		  __int64 v136; // rdx
		  __int64 v137; // rcx
		  __int64 v138; // r8
		  int i; // ebx
		  __int64 v140; // rdx
		  __int64 v141; // r9
		  Plane__Array *v142; // rcx
		  unsigned __int8 (__fastcall *v143)(HGSharedLightData *); // rax
		  void (__fastcall *v144)(HGSharedLightData *, Vector3 *); // rax
		  Vector3 *v145; // rax
		  __int64 v146; // xmm8_8
		  float v147; // ebx
		  void (__fastcall *v148)(HGSharedLightData *, Entity_1 *); // rax
		  void (__fastcall *v149)(HGSharedLightData *, Vector3 *); // rax
		  __int64 v150; // r8
		  __int64 v151; // r9
		  __m128i v152; // xmm6
		  Vector3 *v153; // rax
		  __int64 v154; // xmm7_8
		  float v155; // esi
		  Vector3 *v156; // rax
		  __int64 v157; // xmm10_8
		  float v158; // r15d
		  Vector3 *v159; // rax
		  __int64 v160; // xmm14_8
		  float v161; // r12d
		  Vector3 *v162; // rax
		  __int64 v163; // xmm15_8
		  __m128 y_low; // xmm12
		  __m128 v165; // xmm1
		  __m128 x_low; // xmm11
		  __m128 v167; // xmm0
		  Vector3 *v168; // rax
		  MethodInfo *v169; // r9
		  Vector3 *v170; // rax
		  float v171; // ecx
		  Vector3 *v172; // rax
		  float v173; // esi
		  __m128 version; // xmm6
		  __m128 v175; // xmm1
		  __m128 v176; // xmm0
		  Vector3 *v177; // rax
		  float v178; // xmm2_4
		  __m128 v179; // xmm1
		  MethodInfo *v180; // r9
		  Vector3 *v181; // rax
		  float v182; // ecx
		  Vector3 *v183; // rax
		  __int64 v184; // xmm10_8
		  float v185; // esi
		  __m128 globalIndex; // xmm6
		  __m128 v187; // xmm1
		  __m128 v188; // xmm0
		  Vector3 *v189; // rax
		  float v190; // xmm2_4
		  __m128 v191; // xmm1
		  MethodInfo *v192; // r9
		  Vector3 *v193; // rax
		  float v194; // ecx
		  __int64 v195; // rdx
		  __int64 v196; // rcx
		  Camera *v197; // rbx
		  __int64 (__fastcall *v198)(Camera *); // rax
		  int v199; // esi
		  uint32_t v200; // ebx
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ v201; // xmm6
		  Camera *v202; // rsi
		  uint64_t SceneCullingMaskFromCamera; // rax
		  float m_punctualLightShadowScreenSizeMinSquared; // xmm0_4
		  uint32_t v205; // r15d
		  void (*v206)(void); // rax
		  HGRenderFlags__Enum v207; // ebx
		  HGRenderFlags__Enum v208; // esi
		  uint32_t RendererList; // esi
		  uint32_t v210; // ebx
		  uint32_t v211; // eax
		  __int64 v212; // rdx
		  uint32_t *v213; // rcx
		  ILFixDynamicMethodWrapper_2 *v214; // rax
		  __int64 v215; // rdx
		  __int64 v216; // rcx
		  __m128 v217; // xmm7
		  int32_t j; // ebx
		  LightCaster__Array *m_targetDynamicPunctualLights; // rdi
		  LightCaster *v220; // rax
		  int32_t m_punctualShadowAtlasBaseTileSize; // esi
		  int v222; // eax
		  LightCaster__Array *v223; // rdi
		  LightCaster *v224; // rax
		  Vector3 *v225; // rax
		  __int64 v226; // xmm8_8
		  float v227; // edi
		  int32_t v228; // ebx
		  float v229; // xmm7_4
		  float v230; // xmm6_4
		  Matrix4x4 *v231; // rax
		  __int128 v232; // xmm8
		  __int128 v233; // xmm9
		  __int128 v234; // xmm10
		  __int128 v235; // xmm11
		  float v236; // xmm13_4
		  float v237; // xmm12_4
		  float v238; // xmm7_4
		  float v239; // xmm6_4
		  Vector3 *v240; // rax
		  __int64 v241; // xmm6_8
		  float v242; // ebx
		  __int64 v243; // r8
		  __int64 v244; // r9
		  Quaternion *v245; // rax
		  Matrix4x4 *v246; // rax
		  __int128 v247; // xmm8
		  __int128 v248; // xmm9
		  __int128 v249; // xmm10
		  __int128 v250; // xmm11
		  float v251; // xmm13_4
		  float v252; // xmm12_4
		  float v253; // xmm7_4
		  __int128 v254; // xmm8
		  __int128 v255; // xmm9
		  __int128 v256; // xmm10
		  __int128 v257; // xmm11
		  __int128 v258; // xmm12
		  __m128 v259; // xmm7
		  __int128 v260; // xmm13
		  __int128 v261; // xmm14
		  Matrix4x4 *v262; // r8
		  __int128 v263; // xmm15
		  Vector4__Array *v264; // rdi
		  float v265; // xmm0_4
		  Vector4 *v266; // rax
		  Vector4__Array *v267; // rdi
		  float v268; // xmm6_4
		  Vector4__Array *v269; // rdi
		  float v270; // xmm0_4
		  int32_t v271; // r12d
		  int v272; // r15d
		  int32_t v273; // esi
		  int v274; // r14d
		  int32_t v275; // edi
		  int32_t v276; // ebx
		  int32_t yMax; // eax
		  float v278; // xmm4_4
		  ProfilingSampler *v279; // rax
		  __int64 v280; // rdx
		  __int64 v281; // rcx
		  Object *v282; // rax
		  Object *v283; // rax
		  Object *v284; // rbx
		  __int64 v285; // rdx
		  HGPunctualLightShadowManagerV2__StaticFields *v286; // rcx
		  unsigned __int64 v287; // r8
		  signed __int64 v288; // rtt
		  Object *v289; // rbx
		  __int64 v290; // rdx
		  __int64 v291; // rcx
		  TextureHandle v292; // xmm0
		  Object *v293; // rbx
		  __int64 v294; // rdx
		  __int64 v295; // rcx
		  float v296; // xmm0_4
		  HGSharedLightData v297; // rdi
		  HGRenderGraphContext *v298; // rax
		  __int64 v299; // rdx
		  __int64 v300; // rcx
		  ScriptableRenderContext v301; // rbx
		  Matrix4x4 *v302; // rax
		  __int64 v303; // rdx
		  HGCamera *v304; // r12
		  HGSharedLightData v305; // rbx
		  HGRenderGraphContext *v306; // rax
		  __int64 v307; // rdx
		  __int64 v308; // rcx
		  void *v309; // rdi
		  uint32_t *v310; // rsi
		  uint32_t *v311; // r15
		  unsigned __int8 (__fastcall *v312)(HGSharedLightData *); // rax
		  HGPunctualLightShadowManagerV2__StaticFields *v313; // rcx
		  Matrix4x4 *v314; // rax
		  __m128 v315; // xmm8
		  __m128 v316; // xmm0
		  __m128 v317; // xmm8
		  __m128 v318; // xmm6
		  float v319; // xmm7_4
		  Vector3 *v320; // rax
		  __int64 v321; // xmm11_8
		  __int64 v322; // xmm9_8
		  float v323; // esi
		  Vector3 *v324; // rax
		  Plane__Array *v325; // rbx
		  float v326; // xmm2_4
		  __m128 v327; // xmm1
		  Vector3 *v328; // rax
		  __int64 v329; // rdx
		  __int64 v330; // rcx
		  __int64 v331; // r8
		  Plane__Array *v332; // rbx
		  __m128 v333; // xmm0
		  Vector3 *v334; // rax
		  __int64 v335; // xmm10_8
		  float v336; // r15d
		  float v337; // xmm2_4
		  __m128 v338; // xmm1
		  Vector3 *v339; // rax
		  __int64 v340; // rdx
		  __int64 v341; // rcx
		  __int64 v342; // r8
		  int kk; // ebx
		  __int64 v344; // rdx
		  __int64 v345; // r9
		  Plane__Array *v346; // rcx
		  unsigned __int8 (__fastcall *v347)(HGSharedLightData *); // rax
		  void (__fastcall *v348)(HGSharedLightData *, Vector3 *); // rax
		  Vector3 *v349; // rax
		  Object *v350; // xmm11_8
		  void (__fastcall *v351)(HGSharedLightData *, Vector3 *); // rax
		  void (__fastcall *v352)(HGSharedLightData *, Vector3 *); // rax
		  __int64 v353; // r8
		  __int64 v354; // r9
		  __m128i v355; // xmm6
		  Vector3 *v356; // rax
		  __int64 v357; // xmm7_8
		  float v358; // ebx
		  Vector3 *v359; // rax
		  __int64 v360; // xmm14_8
		  float v361; // esi
		  Vector3 *v362; // rax
		  __int64 v363; // xmm15_8
		  float v364; // r15d
		  Vector3 *v365; // rax
		  __int64 v366; // xmm12_8
		  float v367; // r12d
		  float v368; // xmm9_4
		  __m128 v369; // xmm1
		  float v370; // xmm10_4
		  __m128 v371; // xmm0
		  Vector3 *v372; // rax
		  float v373; // r12d
		  float v374; // xmm13_4
		  __m128 v375; // xmm12
		  __m128 v376; // xmm2
		  __m128 v377; // xmm11
		  __m128 v378; // xmm1
		  Vector3 *v379; // rax
		  float v380; // ebx
		  float v381; // xmm8_4
		  __m128 v382; // xmm1
		  float v383; // xmm9_4
		  __m128 v384; // xmm0
		  Object *v385; // xmm10_8
		  Vector3 *v386; // rax
		  __m128 v387; // xmm2
		  __m128 v388; // xmm1
		  Vector3 *v389; // rax
		  __int64 v390; // xmm14_8
		  float v391; // ebx
		  float v392; // xmm8_4
		  __m128 v393; // xmm1
		  float v394; // xmm9_4
		  __m128 v395; // xmm0
		  Vector3 *v396; // rax
		  __int64 v397; // rdx
		  __int64 v398; // rcx
		  Camera *v399; // rbx
		  __int64 (__fastcall *v400)(Camera *); // rax
		  uint32_t v401; // esi
		  Quaternion v402; // xmm6
		  Camera *v403; // rbx
		  uint64_t v404; // rax
		  float v405; // xmm0_4
		  uint32_t v406; // r15d
		  void (*v407)(void); // rax
		  HGRenderFlags__Enum v408; // ebx
		  HGRenderFlags__Enum v409; // esi
		  uint32_t v410; // esi
		  uint32_t v411; // ebx
		  uint32_t v412; // eax
		  ILFixDynamicMethodWrapper_2 *v413; // rax
		  __int64 v414; // rdx
		  __int64 v415; // rcx
		  Object *v416; // rbx
		  ProfilingSampler *v417; // rax
		  __int64 v418; // rdx
		  __int64 v419; // rcx
		  __int64 v420; // rdx
		  Entity_1__Array *m_targetStaticPunctualLights; // rcx
		  __int64 v422; // rdx
		  Entity_1__Array *v423; // rcx
		  __int64 v424; // rdx
		  __int64 v425; // rcx
		  Vector4__Array *v426; // rdi
		  float v427; // xmm6_4
		  __int64 v428; // rdx
		  __int64 v429; // rcx
		  Vector4__Array *v430; // rdi
		  float PunctualLightShadowStrength; // xmm6_4
		  int32_t k; // ebx
		  Object *v433; // rbx
		  TextureHandle v434; // xmm6
		  Object *v435; // rbx
		  Object__Class *m_punctualLightWorldToShadowMatrices; // rdi
		  unsigned __int64 v437; // r8
		  signed __int64 v438; // rtt
		  Object *v439; // rbx
		  MonitorData *v440; // rdi
		  unsigned __int64 v441; // r8
		  signed __int64 v442; // rtt
		  Object *v443; // rbx
		  Object__Class *v444; // rdi
		  unsigned __int64 v445; // r8
		  signed __int64 v446; // rtt
		  Object *v447; // rdi
		  MonitorData *m_punctualShadowAtlasSize; // rbx
		  int32_t m; // ebx
		  int32_t n; // edi
		  __int64 v451; // rdx
		  HGShadowConstantBufferUtils__StaticFields *v452; // rsi
		  Matrix4x4__Array *v453; // rcx
		  Matrix4x4 *v454; // rax
		  int ii; // edi
		  __int64 v456; // rdx
		  HGShadowConstantBufferUtils__StaticFields *v457; // rsi
		  Vector4__Array *v458; // rcx
		  __int64 v459; // rax
		  int jj; // edi
		  __int64 v461; // rdx
		  HGShadowConstantBufferUtils__StaticFields *v462; // rsi
		  Vector4__Array *v463; // rcx
		  __int64 v464; // rax
		  float v465; // xmm2_4
		  TextureHandle *v466; // rdi
		  ProfilingSampler *v467; // rax
		  __int64 v468; // rdx
		  __int64 v469; // rcx
		  TextureHandle *v470; // rbx
		  HGRenderGraphDefaultResources *defaultResources; // rax
		  __int64 v472; // rdx
		  __int64 v473; // rcx
		  __int64 v474; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v476; // rdx
		  __int64 v477; // rcx
		  HGRenderKeyword__Enum globalKeywords; // [rsp+20h] [rbp-A68h]
		  HGRenderKeyword__Enum globalKeywordsa; // [rsp+20h] [rbp-A68h]
		  Vector3 v480; // [rsp+70h] [rbp-A18h] BYREF
		  Vector3 v481; // [rsp+80h] [rbp-A08h] BYREF
		  HGSharedLightData light; // [rsp+90h] [rbp-9F8h] BYREF
		  HGRenderFlags__Enum renderFlags; // [rsp+98h] [rbp-9F0h] BYREF
		  HGRenderFlags__Enum v484; // [rsp+9Ch] [rbp-9ECh] BYREF
		  HGSharedLightData _unity_self; // [rsp+A0h] [rbp-9E8h] BYREF
		  HGSharedLightData HGSharedLightData; // [rsp+A8h] [rbp-9E0h] BYREF
		  Vector3 v487; // [rsp+B0h] [rbp-9D8h] BYREF
		  HGRenderFlags__Enum renderFlagsMask[4]; // [rsp+C0h] [rbp-9C8h] BYREF
		  Vector3 v489; // [rsp+D0h] [rbp-9B8h] BYREF
		  HGObjectFlags__Enum objectFlagsMask[4]; // [rsp+E0h] [rbp-9A8h] BYREF
		  Quaternion v491; // [rsp+F0h] [rbp-998h] BYREF
		  HGObjectFlags__Enum z_low; // [rsp+100h] [rbp-988h] BYREF
		  Vector3 v493[2]; // [rsp+108h] [rbp-980h] BYREF
		  Matrix4x4 v494; // [rsp+120h] [rbp-968h] BYREF
		  HGObjectFlags__Enum objectFlags; // [rsp+160h] [rbp-928h] BYREF
		  Plane v496; // [rsp+168h] [rbp-920h] BYREF
		  Object *v497; // [rsp+178h] [rbp-910h] BYREF
		  Object *v498; // [rsp+180h] [rbp-908h] BYREF
		  float v499; // [rsp+188h] [rbp-900h]
		  int32_t v500; // [rsp+18Ch] [rbp-8FCh]
		  Entity_1 entity; // [rsp+190h] [rbp-8F8h] BYREF
		  float v502; // [rsp+198h] [rbp-8F0h]
		  Plane v503; // [rsp+1A0h] [rbp-8E8h] BYREF
		  HGRenderGraphBuilder v504; // [rsp+1B0h] [rbp-8D8h] BYREF
		  Object *v505; // [rsp+1D0h] [rbp-8B8h] BYREF
		  uint32_t *m_punctualLightShadowParams2; // [rsp+1D8h] [rbp-8B0h]
		  Object *v507; // [rsp+1E0h] [rbp-8A8h] BYREF
		  int v508; // [rsp+1E8h] [rbp-8A0h]
		  __int64 v509; // [rsp+1F0h] [rbp-898h]
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ v510; // [rsp+200h] [rbp-888h] BYREF
		  Matrix4x4 v511; // [rsp+210h] [rbp-878h] BYREF
		  uint32_t *v512; // [rsp+250h] [rbp-838h]
		  RectInt v513; // [rsp+258h] [rbp-830h] BYREF
		  HGSharedLightData v514; // [rsp+268h] [rbp-820h] BYREF
		  Matrix4x4 v515; // [rsp+270h] [rbp-818h] BYREF
		  HGPunctualLightShadowManagerV2 *v516; // [rsp+2B0h] [rbp-7D8h]
		  TextureHandle *v517; // [rsp+2B8h] [rbp-7D0h] BYREF
		  Vector4 v518; // [rsp+2C0h] [rbp-7C8h] BYREF
		  __int64 v519; // [rsp+2D0h] [rbp-7B8h]
		  float v520; // [rsp+2D8h] [rbp-7B0h]
		  __int128 v521; // [rsp+2E0h] [rbp-7A8h]
		  Plane v522; // [rsp+2F0h] [rbp-798h] BYREF
		  Plane v523; // [rsp+300h] [rbp-788h] BYREF
		  Matrix4x4 v524; // [rsp+310h] [rbp-778h] BYREF
		  Vector3 v525; // [rsp+350h] [rbp-738h] BYREF
		  Vector3 v526; // [rsp+360h] [rbp-728h] BYREF
		  Vector3 v527; // [rsp+370h] [rbp-718h] BYREF
		  Object *v528; // [rsp+380h] [rbp-708h]
		  Vector3 v529; // [rsp+390h] [rbp-6F8h] BYREF
		  Vector3 v530; // [rsp+3A0h] [rbp-6E8h] BYREF
		  Vector3 v531; // [rsp+3B0h] [rbp-6D8h] BYREF
		  Vector3 v532; // [rsp+3C0h] [rbp-6C8h] BYREF
		  Vector3 v533; // [rsp+3D0h] [rbp-6B8h] BYREF
		  Vector3 v534; // [rsp+3E0h] [rbp-6A8h] BYREF
		  Vector3 v535; // [rsp+3F0h] [rbp-698h] BYREF
		  Vector3 v536; // [rsp+400h] [rbp-688h] BYREF
		  Vector3 v537; // [rsp+410h] [rbp-678h] BYREF
		  Vector3 v538; // [rsp+420h] [rbp-668h] BYREF
		  Vector3 v539; // [rsp+430h] [rbp-658h] BYREF
		  Vector3 v540; // [rsp+440h] [rbp-648h] BYREF
		  Vector3 v541; // [rsp+450h] [rbp-638h] BYREF
		  Vector3 v542; // [rsp+460h] [rbp-628h] BYREF
		  Vector3 v543; // [rsp+470h] [rbp-618h] BYREF
		  Vector3 v544; // [rsp+480h] [rbp-608h] BYREF
		  Vector3 v545; // [rsp+490h] [rbp-5F8h] BYREF
		  Vector3 v546; // [rsp+4A0h] [rbp-5E8h] BYREF
		  Vector3 v547; // [rsp+4B0h] [rbp-5D8h] BYREF
		  Vector3 v548; // [rsp+4C0h] [rbp-5C8h] BYREF
		  __int64 v549; // [rsp+4D0h] [rbp-5B8h]
		  Vector3 v550; // [rsp+4E0h] [rbp-5A8h] BYREF
		  Vector3 v551; // [rsp+4F0h] [rbp-598h] BYREF
		  Vector3 v552; // [rsp+500h] [rbp-588h] BYREF
		  Vector3 v553; // [rsp+510h] [rbp-578h] BYREF
		  Vector3 v554; // [rsp+520h] [rbp-568h] BYREF
		  __int64 v555; // [rsp+530h] [rbp-558h]
		  Vector3 v556; // [rsp+540h] [rbp-548h] BYREF
		  Vector3 v557; // [rsp+550h] [rbp-538h] BYREF
		  Vector3 v558; // [rsp+560h] [rbp-528h] BYREF
		  Vector3 v559; // [rsp+570h] [rbp-518h] BYREF
		  Vector3 v560; // [rsp+580h] [rbp-508h] BYREF
		  Vector3 v561; // [rsp+590h] [rbp-4F8h] BYREF
		  HGRenderGraphBuilder v562; // [rsp+5A0h] [rbp-4E8h] BYREF
		  HGRenderGraphBuilder v563; // [rsp+5C0h] [rbp-4C8h] BYREF
		  Vector3 v564; // [rsp+5E0h] [rbp-4A8h] BYREF
		  Vector3 v565; // [rsp+5F0h] [rbp-498h] BYREF
		  Vector3 v566; // [rsp+600h] [rbp-488h] BYREF
		  Plane v567; // [rsp+610h] [rbp-478h] BYREF
		  Plane v568; // [rsp+620h] [rbp-468h] BYREF
		  Vector3 v569; // [rsp+630h] [rbp-458h] BYREF
		  __int64 v570; // [rsp+640h] [rbp-448h]
		  Vector3 v571; // [rsp+650h] [rbp-438h] BYREF
		  Matrix4x4 v572; // [rsp+660h] [rbp-428h] BYREF
		  HGRenderGraphBuilder v573; // [rsp+6A0h] [rbp-3E8h] BYREF
		  HGRenderGraphBuilder v574; // [rsp+6C0h] [rbp-3C8h] BYREF
		  __int128 v575; // [rsp+6E0h] [rbp-3A8h]
		  Plane v576; // [rsp+6F0h] [rbp-398h] BYREF
		  Plane v577; // [rsp+700h] [rbp-388h] BYREF
		  Plane v578; // [rsp+710h] [rbp-378h] BYREF
		  Plane v579; // [rsp+720h] [rbp-368h] BYREF
		  Plane v580; // [rsp+730h] [rbp-358h] BYREF
		  Plane v581; // [rsp+740h] [rbp-348h] BYREF
		  Plane v582; // [rsp+750h] [rbp-338h] BYREF
		  Plane v583; // [rsp+760h] [rbp-328h] BYREF
		  EntityManager v584; // [rsp+770h] [rbp-318h] BYREF
		  Il2CppExceptionWrapper *v585; // [rsp+780h] [rbp-308h] BYREF
		  Il2CppExceptionWrapper *v586; // [rsp+788h] [rbp-300h] BYREF
		  Il2CppExceptionWrapper *v587; // [rsp+790h] [rbp-2F8h] BYREF
		  Matrix4x4 v588; // [rsp+7A0h] [rbp-2E8h] BYREF
		  Matrix4x4 v589; // [rsp+7E0h] [rbp-2A8h] BYREF
		  Matrix4x4 v590; // [rsp+820h] [rbp-268h] BYREF
		  Il2CppExceptionWrapper *v591; // [rsp+860h] [rbp-228h] BYREF
		  Vector3 v592; // [rsp+868h] [rbp-220h] BYREF
		  Vector3 v593; // [rsp+878h] [rbp-210h] BYREF
		  Vector3 v594; // [rsp+888h] [rbp-200h] BYREF
		  Vector3 v595; // [rsp+898h] [rbp-1F0h] BYREF
		  Vector3 v596; // [rsp+8A8h] [rbp-1E0h] BYREF
		  Vector3 v597; // [rsp+8B8h] [rbp-1D0h] BYREF
		  Vector3 v598; // [rsp+8C8h] [rbp-1C0h] BYREF
		  Vector3 v599; // [rsp+8D8h] [rbp-1B0h] BYREF
		  Vector3 v600; // [rsp+8E8h] [rbp-1A0h] BYREF
		  Vector3 v601; // [rsp+8F8h] [rbp-190h] BYREF
		  Vector3 v602; // [rsp+908h] [rbp-180h] BYREF
		  Vector3 v603; // [rsp+918h] [rbp-170h] BYREF
		  Vector3 v604; // [rsp+928h] [rbp-160h] BYREF
		  Vector3 v605; // [rsp+938h] [rbp-150h] BYREF
		  Vector3 v606; // [rsp+948h] [rbp-140h] BYREF
		  Vector3 v607; // [rsp+958h] [rbp-130h] BYREF
		  char v608[16]; // [rsp+968h] [rbp-120h] BYREF
		  Vector4 v609; // [rsp+978h] [rbp-110h] BYREF
		  TextureHandle v610; // [rsp+988h] [rbp-100h] BYREF
		  char v611[184]; // [rsp+998h] [rbp-F0h] BYREF
		
		  v9 = this;
		  v516 = this;
		  memset(&v573, 0, sizeof(v573));
		  v517 = 0LL;
		  _unity_self = 0LL;
		  sub_18033B9D0(&v524, 0LL, 64LL);
		  sub_18033B9D0(&v515, 0LL, 64LL);
		  sub_18033B9D0(&v511, 0LL, 64LL);
		  memset(&v562, 0, sizeof(v562));
		  v497 = 0LL;
		  v513 = 0LL;
		  HGSharedLightData = 0LL;
		  sub_18033B9D0(&v588, 0LL, 64LL);
		  sub_18033B9D0(&v589, 0LL, 64LL);
		  sub_18033B9D0(&v590, 0LL, 64LL);
		  memset(&v563, 0, sizeof(v563));
		  v498 = 0LL;
		  memset(&v574, 0, sizeof(v574));
		  v505 = 0LL;
		  v584 = 0LL;
		  v514 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(2189, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2189, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v477, v476);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_882(
		      Patch,
		      (Object *)v9,
		      (Object *)renderGraph,
		      (Object *)hgCamera,
		      (Object *)settingParams,
		      shadowResult,
		      0LL);
		  }
		  else
		  {
		    if ( HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::IsPunctualLightShadowEnabled(v9, settingParams, 0LL) )
		    {
		      if ( !hgCamera )
		        goto LABEL_233;
		      camera = (unsigned __int64)hgCamera->fields.camera;
		      if ( !camera )
		        goto LABEL_233;
		      transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
		      if ( !transform )
		        goto LABEL_233;
		      position = UnityEngine::Transform::get_position(&v487, transform, 0LL);
		      v14 = *(_QWORD *)&position->x;
		      v509 = v14;
		      v519 = v14;
		      z = position->z;
		      v499 = z;
		      v520 = z;
		      camera = (unsigned __int64)v9->fields.punctualLightStaticAtlasAllocator;
		      if ( !camera )
		        goto LABEL_233;
		      SlotCount = HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::get_SlotCount(
		                    (HGPunctualLightStaticAtlasAllocator *)camera,
		                    0LL);
		      v500 = SlotCount;
		      camera = (unsigned __int64)v9->fields.m_targetUpdateRequest;
		      if ( !camera )
		        goto LABEL_233;
		      if ( !*(_DWORD *)(camera + 16) )
		      {
		LABEL_75:
		        v217 = (__m128)0x3F800000u;
		        goto LABEL_76;
		      }
		      punctualLightStaticAtlasAllocator = v9->fields.punctualLightStaticAtlasAllocator;
		      if ( !punctualLightStaticAtlasAllocator )
		        goto LABEL_233;
		      v17 = *HG::Rendering::Runtime::HGPunctualLightStaticAtlasAllocator::GetRectFromSlotIndex(
		               (RectInt *)&v518,
		               punctualLightStaticAtlasAllocator,
		               *(_DWORD *)(camera + 44),
		               0LL);
		      *(RectInt *)&v504.m_RenderPass = v17;
		      m_targetUpdateRequest = v9->fields.m_targetUpdateRequest;
		      if ( !m_targetUpdateRequest )
		        goto LABEL_233;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		      _unity_self = HG::Rendering::Runtime::LightCaster::GetHGSharedLightData(
		                      &m_targetUpdateRequest->fields.requestLightCaster,
		                      0LL);
		      v19 = v9->fields.m_targetUpdateRequest;
		      if ( !v19 )
		        goto LABEL_233;
		      index = v19->fields.requestLightCaster.index;
		      targetSlot = v19->fields.targetSlot;
		      v484 = targetSlot;
		      if ( UnityEngine::HGSharedLightData::get_enableOverrideShadowLight_Injected(&_unity_self, 0LL) )
		      {
		        overrideShadowLightPosition = UnityEngine::HGSharedLightData::get_overrideShadowLightPosition(
		                                        &v487,
		                                        &_unity_self,
		                                        0LL);
		        v37 = *(_QWORD *)&overrideShadowLightPosition->x;
		        v38 = overrideShadowLightPosition->z;
		        v480 = *UnityEngine::HGSharedLightData::get_overrideShadowLightRotation(&v487, &_unity_self, 0LL);
		        v41 = (Quaternion *)sub_182FA5910(&v518, &v480, v39, v40);
		        *(_QWORD *)&v480.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		        v480.z = 1.0;
		        v491 = *v41;
		        *(_QWORD *)&v489.x = v37;
		        v489.z = v38;
		        v42 = UnityEngine::Matrix4x4::TRS(&v572, &v489, &v491, &v480, 0LL);
		        v43 = *(_OWORD *)&v42->m00;
		        v44 = *(_OWORD *)&v42->m01;
		        v45 = *(_OWORD *)&v42->m02;
		        v46 = *(_OWORD *)&v42->m03;
		        overrideShadowLightSpotAngle_Injected = UnityEngine::HGSharedLightData::get_overrideShadowLightSpotAngle_Injected(
		                                                  &_unity_self,
		                                                  0LL);
		        shadowNearPlane_Injected = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&_unity_self, 0LL);
		        shadowFarPlane_Injected = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&_unity_self, 0LL);
		        LODWORD(v37) = UnityEngine::HGSharedLightData::get_shadowGuardAngle_Injected(&_unity_self, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		        *(_OWORD *)&v494.m00 = v43;
		        *(_OWORD *)&v494.m01 = v44;
		        *(_OWORD *)&v494.m02 = v45;
		        *(_OWORD *)&v494.m03 = v46;
		        HG::Rendering::Runtime::HGShadowUtils::ExtractSpotLightMatrix(
		          &v572,
		          &v494,
		          overrideShadowLightSpotAngle_Injected,
		          shadowNearPlane_Injected,
		          shadowFarPlane_Injected,
		          *(float *)&v37,
		          &v524,
		          &v515,
		          &v511,
		          0LL);
		      }
		      else
		      {
		        if ( UnityEngine::HGSharedLightData::get_type_Injected(&_unity_self, 0LL) == LightType__Enum_Spot )
		        {
		          localToWorldMatrix = UnityEngine::HGSharedLightData::get_localToWorldMatrix(&v494, &_unity_self, 0LL);
		          v28 = *(_OWORD *)&localToWorldMatrix->m00;
		          v29 = *(_OWORD *)&localToWorldMatrix->m01;
		          v30 = *(_OWORD *)&localToWorldMatrix->m02;
		          v31 = *(_OWORD *)&localToWorldMatrix->m03;
		          spotAngle_Injected = UnityEngine::HGSharedLightData::get_spotAngle_Injected(&_unity_self, 0LL);
		          v33 = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&_unity_self, 0LL);
		          v34 = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&_unity_self, 0LL);
		          shadowGuardAngle_Injected = UnityEngine::HGSharedLightData::get_shadowGuardAngle_Injected(&_unity_self, 0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		          *(_OWORD *)&v494.m00 = v28;
		          *(_OWORD *)&v494.m01 = v29;
		          *(_OWORD *)&v494.m02 = v30;
		          *(_OWORD *)&v494.m03 = v31;
		          HG::Rendering::Runtime::HGShadowUtils::ExtractSpotLightMatrix(
		            &v572,
		            &v494,
		            spotAngle_Injected,
		            v33,
		            v34,
		            shadowGuardAngle_Injected,
		            &v524,
		            &v515,
		            &v511,
		            0LL);
		LABEL_18:
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		          v50 = *(_OWORD *)&v524.m00;
		          v494 = v524;
		          v51 = *(_OWORD *)&v524.m01;
		          v52 = *(_OWORD *)&v524.m02;
		          v53 = *(_OWORD *)&v524.m03;
		          v54 = *(_OWORD *)&v515.m00;
		          v524 = v515;
		          v55 = *(__m128 *)&v515.m01;
		          v56 = *(_OWORD *)&v515.m02;
		          v57 = *(_OWORD *)&v515.m03;
		          ShadowTransform = HG::Rendering::Runtime::HGShadowUtils::GetShadowTransform(&v572, &v524, &v494, 0LL);
		          v496 = *(Plane *)&ShadowTransform->m00;
		          v503 = *(Plane *)&ShadowTransform->m01;
		          v523 = *(Plane *)&ShadowTransform->m02;
		          v522 = *(Plane *)&ShadowTransform->m03;
		          camera = (unsigned __int64)v9->fields.m_punctualLightWorldToShadowMatrices;
		          if ( camera )
		          {
		            v494 = *ShadowTransform;
		            sub_180041540(camera, (int)targetSlot, &v494);
		            m_punctualLightShadowParams = v9->fields.m_punctualLightShadowParams;
		            shadowNormalBias_Injected = UnityEngine::HGSharedLightData::get_shadowNormalBias_Injected(&_unity_self, 0LL);
		            *(_OWORD *)&v494.m00 = v54;
		            *(__m128 *)&v494.m01 = v55;
		            *(_OWORD *)&v494.m02 = v56;
		            *(_OWORD *)&v494.m03 = v57;
		            ShadowBias = HG::Rendering::Runtime::HGShadowUtils::GetShadowBias(
		                           &v518,
		                           &v494,
		                           (float)_mm_cvtsi128_si32(_mm_srli_si128((__m128i)v17, 8)),
		                           0.0,
		                           shadowNormalBias_Injected,
		                           HGShadowSampleMode__Enum_PCF_3x3,
		                           0LL);
		            if ( m_punctualLightShadowParams )
		            {
		              v491 = (Quaternion)*ShadowBias;
		              sub_18003FEF0(m_punctualLightShadowParams, (int)targetSlot, &v491);
		              v62 = v9->fields.m_punctualLightShadowParams;
		              if ( v62 )
		              {
		                v63 = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&_unity_self, 0LL);
		                *(float *)(sub_180002100(v62, (int)targetSlot) + 8) = v63;
		                v64 = v9->fields.m_punctualLightShadowParams;
		                if ( v64 )
		                {
		                  shadowStrength_Injected = UnityEngine::HGSharedLightData::get_shadowStrength_Injected(
		                                              &_unity_self,
		                                              0LL);
		                  *(float *)(sub_180002100(v64, (int)targetSlot) + 12) = shadowStrength_Injected;
		                  m_punctualLightShadowParams2 = (uint32_t *)v9->fields.m_punctualLightShadowParams2;
		                  xMin = UnityEngine::RectInt::get_xMin((RectInt *)&v504, 0LL);
		                  m_X = v9->fields.m_punctualShadowAtlasSize.m_X;
		                  yMin = UnityEngine::RectInt::get_yMin((RectInt *)&v504, 0LL);
		                  m_Y = v9->fields.m_punctualShadowAtlasSize.m_Y;
		                  xMax = UnityEngine::RectInt::get_xMax((RectInt *)&v504, 0LL);
		                  v71 = this->fields.m_punctualShadowAtlasSize.m_X;
		                  v72 = (float)UnityEngine::RectInt::get_yMax((RectInt *)&v504, 0LL)
		                      / (float)this->fields.m_punctualShadowAtlasSize.m_Y;
		                  *(float *)&v504.m_RenderPass = (float)xMin / (float)m_X;
		                  *((float *)&v504.m_RenderPass + 1) = (float)yMin / (float)m_Y;
		                  *(float *)&v504.m_Resources = (float)xMax / (float)v71;
		                  *((float *)&v504.m_Resources + 1) = v72;
		                  if ( m_punctualLightShadowParams2 )
		                  {
		                    v491 = *(Quaternion *)&v504.m_RenderPass;
		                    sub_18003FEF0(m_punctualLightShadowParams2, (int)v484, &v491);
		                    v73 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                            (Int32Enum__Enum)0x7Eu,
		                            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		                    if ( renderGraph )
		                    {
		                      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		                        (HGRenderGraphBuilder *)&v515,
		                        renderGraph,
		                        (String *)"Render Punctual Light ShadowMaps",
		                        &v497,
		                        v73,
		                        1,
		                        ProfilingHGPass__Enum_Shadow,
		                        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPassData>);
		                      *(_OWORD *)&v562.m_RenderPass = *(_OWORD *)&v515.m00;
		                      *(_OWORD *)&v562.m_RenderGraph = *(_OWORD *)&v515.m01;
		                      v504.m_RenderPass = 0LL;
		                      v504.m_Resources = (HGRenderGraphResourceRegistry *)&v562;
		                      try
		                      {
		                        v76 = v497;
		                        if ( !v497 )
		                          sub_1800D8250(v75, v74);
		                        *(Object *)((char *)v497 + 60) = *(Object *)&v511.m00;
		                        *(Object *)((char *)v76 + 76) = *(Object *)&v511.m01;
		                        *(Object *)((char *)v76 + 92) = *(Object *)&v511.m02;
		                        *(Object *)((char *)v76 + 108) = *(Object *)&v511.m03;
		                        v77 = v497;
		                        if ( !v497 )
		                          sub_1800D8250(v75, v74);
		                        *(_OWORD *)((char *)&v497[7].monitor + 4) = v50;
		                        *(_OWORD *)((char *)&v77[8].monitor + 4) = v51;
		                        *(_OWORD *)((char *)&v77[9].monitor + 4) = v52;
		                        *(_OWORD *)((char *)&v77[10].monitor + 4) = v53;
		                        if ( !v497 )
		                          sub_1800D8250(v75, v74);
		                        *(RectInt *)((char *)&v497[2].monitor + 4) = v17;
		                        v78 = v497;
		                        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		                        static_fields = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields;
		                        if ( !v78 )
		                          sub_1800D8250(static_fields, v79);
		                        v78[15].klass = (Object__Class *)static_fields->s_clearShadowMaterial;
		                        if ( dword_18F35FD08 )
		                        {
		                          v81 = (((unsigned __int64)&v78[15] >> 12) & 0x1FFFFF) >> 6;
		                          _m_prefetchw(&qword_18F0BCBA0[v81 + 36190]);
		                          do
		                            v82 = qword_18F0BCBA0[v81 + 36190];
		                          while ( v82 != _InterlockedCompareExchange64(
		                                           &qword_18F0BCBA0[v81 + 36190],
		                                           v82 | (1LL << (((unsigned __int64)&v78[15] >> 12) & 0x3F)),
		                                           v82) );
		                        }
		                        v83 = v497;
		                        v9 = this;
		                        v86 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                 (TextureHandle *)&v518,
		                                 renderGraph,
		                                 this->fields.m_cachedPunctualLightShadowAtlas,
		                                 0LL);
		                        if ( !v83 )
		                          sub_1800D8250(v85, v84);
		                        *(TextureHandle *)&v83[13].monitor = v86;
		                        v87 = v497;
		                        shadowBias_Injected = UnityEngine::HGSharedLightData::get_shadowBias_Injected(&_unity_self, 0LL);
		                        if ( !v87 )
		                          sub_1800D8250(v89, v88);
		                        *(float *)&v87[2].monitor = shadowBias_Injected;
		                        v91 = _unity_self;
		                        HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		                        if ( !HGContext )
		                          sub_1800D8250(v94, v93);
		                        v95.m_Ptr = HGContext->fields.renderContext.m_Ptr;
		                        *(_OWORD *)&v494.m00 = v50;
		                        *(_OWORD *)&v494.m01 = v51;
		                        *(_OWORD *)&v494.m02 = v52;
		                        *(_OWORD *)&v494.m03 = v53;
		                        *(_OWORD *)&v511.m00 = v54;
		                        *(__m128 *)&v511.m01 = v55;
		                        *(_OWORD *)&v511.m02 = v56;
		                        *(_OWORD *)&v511.m03 = v57;
		                        v96 = UnityEngine::Matrix4x4::op_Multiply(&v572, &v511, &v494, 0LL);
		                        if ( !v497 )
		                          sub_1800D8250(0LL, v97);
		                        v494 = *v96;
		                        v98 = hgCamera;
		                        HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PrepareRendererList(
		                          this,
		                          v91,
		                          hgCamera,
		                          v95,
		                          &v494,
		                          0,
		                          (RendererList *)&v497[12].monitor,
		                          0LL);
		                        v99 = _unity_self;
		                        v100 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		                        if ( !v100 )
		                          sub_1800D8250(v102, v101);
		                        m_Ptr = v100->fields.renderContext.m_Ptr;
		                        LODWORD(v104) = _mm_shuffle_ps(v55, v55, 85).m128_u32[0];
		                        if ( !v497 )
		                          sub_1800D8250(v102, v101);
		                        v105 = (uint32_t *)&v497[11].monitor + 1;
		                        *(_QWORD *)&v521 = (char *)v497 + 188;
		                        v106 = (uint32_t *)&v497[12];
		                        v507 = v497 + 12;
		                        m_punctualLightShadowParams2 = (uint32_t *)&v497[12].klass + 1;
		                        *(_OWORD *)&v511.m00 = v50;
		                        *(_OWORD *)&v511.m01 = v51;
		                        *(_OWORD *)&v511.m02 = v52;
		                        *(_OWORD *)&v511.m03 = v53;
		                        light = v99;
		                        v510 = 0LL;
		                        *(_QWORD *)&v480.x = 0LL;
		                        v480.z = 0.0;
		                        memset(&v515, 0, 56);
		                        objectFlags = HGObjectFlags__Enum_None;
		                        *(float *)objectFlagsMask = 0.0;
		                        renderFlags = HGRenderFlags__Enum_None;
		                        renderFlagsMask[0] = HGRenderFlags__Enum_None;
		                        if ( IFix::WrappersManagerImpl::IsPatched(2187, 0LL) )
		                        {
		                          v214 = IFix::WrappersManagerImpl::GetPatch(2187, 0LL);
		                          if ( !v214 )
		                            sub_1800D8250(v216, v215);
		                          *(_OWORD *)&v494.m00 = v50;
		                          *(_OWORD *)&v494.m01 = v51;
		                          *(_OWORD *)&v494.m02 = v52;
		                          *(_OWORD *)&v494.m03 = v53;
		                          *(Plane *)&v511.m00 = v496;
		                          *(Plane *)&v511.m01 = v503;
		                          *(Plane *)&v511.m02 = v523;
		                          *(Plane *)&v511.m03 = v522;
		                          IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_878(
		                            v214,
		                            (Object *)this,
		                            light,
		                            (Object *)hgCamera,
		                            (ScriptableRenderContext)m_Ptr,
		                            &v511,
		                            &v494,
		                            v104,
		                            0,
		                            v105,
		                            v106,
		                            m_punctualLightShadowParams2,
		                            0LL);
		                        }
		                        else
		                        {
		                          v107 = (unsigned __int8 (__fastcall *)(HGSharedLightData *))qword_18F3AA2E8;
		                          if ( !qword_18F3AA2E8 )
		                          {
		                            v107 = (unsigned __int8 (__fastcall *)(HGSharedLightData *))sub_180059EA0(
		                                                                                          "UnityEngine.HGSharedLightData:"
		                                                                                          ":get_enableOBBCullingBox_Injec"
		                                                                                          "ted(UnityEngine.HGSharedLightData&)");
		                            qword_18F3AA2E8 = (__int64)v107;
		                          }
		                          if ( v107(&light) )
		                            Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::NativeArray(
		                              &v510,
		                              12,
		                              Allocator__Enum_Temp,
		                              NativeArrayOptions__Enum_ClearMemory,
		                              MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
		                          else
		                            Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::NativeArray(
		                              &v510,
		                              6,
		                              Allocator__Enum_Temp,
		                              NativeArrayOptions__Enum_ClearMemory,
		                              MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
		                          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		                          v108 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields;
		                          *(Plane *)&v494.m00 = v496;
		                          *(Plane *)&v494.m01 = v503;
		                          *(Plane *)&v494.m02 = v523;
		                          *(Plane *)&v494.m03 = v522;
		                          UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v494, v108->s_cullPlanes, 0LL);
		                          inverse = UnityEngine::Matrix4x4::get_inverse(&v572, &v511, 0LL);
		                          *(_OWORD *)&v494.m00 = *(_OWORD *)&inverse->m00;
		                          *(_OWORD *)&v494.m01 = *(_OWORD *)&inverse->m01;
		                          v110 = *(__m128 *)&inverse->m02;
		                          *(_OWORD *)&v494.m03 = *(_OWORD *)&inverse->m03;
		                          *(_OWORD *)&v494.m00 = *(_OWORD *)&inverse->m00;
		                          *(_OWORD *)&v494.m01 = *(_OWORD *)&inverse->m01;
		                          v111 = v110;
		                          *(_OWORD *)&v494.m03 = *(_OWORD *)&inverse->m03;
		                          *(_OWORD *)&v494.m01 = *(_OWORD *)&inverse->m01;
		                          v112 = v110;
		                          *(_OWORD *)&v494.m03 = *(_OWORD *)&inverse->m03;
		                          v113 = _mm_xor_ps(v110, (__m128)0x80000000);
		                          v114 = _mm_xor_ps(_mm_shuffle_ps(v111, v111, 85), (__m128)0x80000000);
		                          v115 = -_mm_shuffle_ps(v112, v112, 170).m128_f32[0];
		                          worldPosition = UnityEngine::HGSharedLightData::get_worldPosition(&v487, &light, 0LL);
		                          v117 = *(uint32_t **)&worldPosition->x;
		                          z_low = LODWORD(worldPosition->z);
		                          v118 = v117;
		                          v512 = v117;
		                          v119 = z_low;
		                          v484 = z_low;
		                          if ( UnityEngine::HGSharedLightData::get_enableOverrideShadowLight_Injected(&light, 0LL) )
		                          {
		                            v120 = UnityEngine::HGSharedLightData::get_overrideShadowLightPosition(&v487, &light, 0LL);
		                            v118 = *(uint32_t **)&v120->x;
		                            v512 = *(uint32_t **)&v120->x;
		                            v119 = LODWORD(v120->z);
		                            v484 = v119;
		                          }
		                          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		                          s_cullPlanes = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_cullPlanes;
		                          v122 = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&light, 0LL);
		                          v123 = v114;
		                          v123.m128_f32[0] = v114.m128_f32[0] * v122;
		                          v124 = v113;
		                          v124.m128_f32[0] = v113.m128_f32[0] * v122;
		                          *(_QWORD *)&v480.x = _mm_unpacklo_ps(v124, v123).m128_u64[0];
		                          v480.z = v115 * v122;
		                          *(_QWORD *)&v489.x = v118;
		                          LODWORD(v489.z) = v119;
		                          v125 = UnityEngine::Vector3::op_Addition(&v487, &v489, &v480, 0LL);
		                          v124.m128_u64[0] = *(_QWORD *)&v125->x;
		                          *(float *)&v125 = v125->z;
		                          v496 = 0LL;
		                          *(_QWORD *)&v480.x = v124.m128_u64[0];
		                          LODWORD(v480.z) = (_DWORD)v125;
		                          *(_QWORD *)&v489.x = _mm_unpacklo_ps(v113, v114).m128_u64[0];
		                          v489.z = v115;
		                          UnityEngine::Plane::Plane(&v496, &v489, &v480, 0LL);
		                          if ( !s_cullPlanes )
		                            sub_1800D8250(v127, v126);
		                          if ( s_cullPlanes->max_length.size <= 4u )
		                            sub_1800D2AA0(v127, v126, v128);
		                          s_cullPlanes->vector[4] = v496;
		                          v129 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_cullPlanes;
		                          *(_QWORD *)&v480.x = _mm_unpacklo_ps(v113, v114).m128_u64[0];
		                          v480.z = v115;
		                          v130 = UnityEngine::Vector3::op_UnaryNegation(&v487, &v480, 0LL);
		                          v131 = *(_QWORD *)&v130->x;
		                          v132 = v130->z;
		                          v133 = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&light, 0LL);
		                          v114.m128_f32[0] = v114.m128_f32[0] * v133;
		                          v113.m128_f32[0] = v113.m128_f32[0] * v133;
		                          *(_QWORD *)&v480.x = _mm_unpacklo_ps(v113, v114).m128_u64[0];
		                          v480.z = v115 * v133;
		                          *(_QWORD *)&v489.x = v118;
		                          LODWORD(v489.z) = v119;
		                          v134 = UnityEngine::Vector3::op_Addition(&v487, &v489, &v480, 0LL);
		                          v135 = *(_QWORD *)&v134->x;
		                          *(float *)&v134 = v134->z;
		                          v503 = 0LL;
		                          *(_QWORD *)&v480.x = v135;
		                          LODWORD(v480.z) = (_DWORD)v134;
		                          *(_QWORD *)&v489.x = v131;
		                          v489.z = v132;
		                          UnityEngine::Plane::Plane(&v503, &v489, &v480, 0LL);
		                          if ( !v129 )
		                            sub_1800D8250(v137, v136);
		                          if ( v129->max_length.size <= 5u )
		                            sub_1800D2AA0(v137, v136, v138);
		                          v129->vector[5] = v503;
		                          for ( i = 0; i < 6; ++i )
		                          {
		                            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		                            v142 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_cullPlanes;
		                            if ( !v142 )
		                              sub_1800D8250(0LL, v140);
		                            sub_180002990(v142, &v491, i, v141);
		                            *(Quaternion *)&v510.m_Buffer[16 * i] = v491;
		                          }
		                          v143 = (unsigned __int8 (__fastcall *)(HGSharedLightData *))qword_18F3AA2E8;
		                          if ( !qword_18F3AA2E8 )
		                          {
		                            v143 = (unsigned __int8 (__fastcall *)(HGSharedLightData *))sub_180059EA0(
		                                                                                          "UnityEngine.HGSharedLightData:"
		                                                                                          ":get_enableOBBCullingBox_Injec"
		                                                                                          "ted(UnityEngine.HGSharedLightData&)");
		                            qword_18F3AA2E8 = (__int64)v143;
		                          }
		                          if ( v143(&light) )
		                          {
		                            *(_QWORD *)&v493[0].x = 0LL;
		                            v493[0].z = 0.0;
		                            v144 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))qword_18F3AA2F0;
		                            if ( !qword_18F3AA2F0 )
		                            {
		                              v144 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))sub_180059EA0(
		                                                                                            "UnityEngine.HGSharedLightDat"
		                                                                                            "a::get_cullingBoxRelativePos"
		                                                                                            "ition_Injected(UnityEngine.H"
		                                                                                            "GSharedLightData&,UnityEngine.Vector3&)");
		                              qword_18F3AA2F0 = (__int64)v144;
		                            }
		                            v144(&light, v493);
		                            v480 = v493[0];
		                            *(_QWORD *)&v489.x = v117;
		                            LODWORD(v489.z) = z_low;
		                            v145 = UnityEngine::Vector3::op_Addition(&v487, &v489, &v480, 0LL);
		                            v146 = *(_QWORD *)&v145->x;
		                            v147 = v145->z;
		                            entity = 0LL;
		                            v502 = 0.0;
		                            v148 = (void (__fastcall *)(HGSharedLightData *, Entity_1 *))qword_18F3AA2F8;
		                            if ( !qword_18F3AA2F8 )
		                            {
		                              v148 = (void (__fastcall *)(HGSharedLightData *, Entity_1 *))sub_180059EA0(
		                                                                                             "UnityEngine.HGSharedLightDa"
		                                                                                             "ta::get_cullingBoxHalfExten"
		                                                                                             "ts_Injected(UnityEngine.HGS"
		                                                                                             "haredLightData&,UnityEngine.Vector3&)");
		                              qword_18F3AA2F8 = (__int64)v148;
		                            }
		                            v148(&light, &entity);
		                            memset(v493, 0, 12);
		                            v149 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))qword_18F3AA300;
		                            if ( !qword_18F3AA300 )
		                            {
		                              v149 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))sub_180059EA0(
		                                                                                            "UnityEngine.HGSharedLightDat"
		                                                                                            "a::get_cullingBoxOrientation"
		                                                                                            "_Injected(UnityEngine.HGShar"
		                                                                                            "edLightData&,UnityEngine.Vector3&)");
		                              qword_18F3AA300 = (__int64)v149;
		                            }
		                            v149(&light, v493);
		                            v480 = v493[0];
		                            v152 = _mm_loadu_si128((const __m128i *)sub_182FA5910(&v518, &v480, v150, v151));
		                            v480 = *UnityEngine::Vector3::get_fwd(&v487, 0LL);
		                            v491 = (Quaternion)v152;
		                            v153 = UnityEngine::Quaternion::op_Multiply(&v487, &v491, &v480, 0LL);
		                            *(_QWORD *)&v481.x = *(_QWORD *)&v153->x;
		                            v154 = *(_QWORD *)&v481.x;
		                            v155 = v153->z;
		                            v480 = *UnityEngine::Vector3::get_up(&v487, 0LL);
		                            v491 = (Quaternion)v152;
		                            v156 = UnityEngine::Quaternion::op_Multiply(&v487, &v491, &v480, 0LL);
		                            *(_QWORD *)&v493[0].x = *(_QWORD *)&v156->x;
		                            v157 = *(_QWORD *)&v493[0].x;
		                            v158 = v156->z;
		                            v480 = *UnityEngine::Vector3::get_right(&v487, 0LL);
		                            v491 = (Quaternion)v152;
		                            v159 = UnityEngine::Quaternion::op_Multiply(&v487, &v491, &v480, 0LL);
		                            *(_QWORD *)&v489.x = *(_QWORD *)&v159->x;
		                            v160 = *(_QWORD *)&v489.x;
		                            v161 = v159->z;
		                            *(_QWORD *)&v480.x = v154;
		                            v480.z = v155;
		                            v162 = UnityEngine::Vector3::op_UnaryNegation(&v487, &v480, 0LL);
		                            v163 = *(_QWORD *)&v162->x;
		                            z_low = LODWORD(v162->z);
		                            *(float *)v152.m128i_i32 = v502;
		                            y_low = (__m128)LODWORD(v481.y);
		                            v165 = (__m128)LODWORD(v481.y);
		                            v165.m128_f32[0] = v481.y * v502;
		                            x_low = (__m128)LODWORD(v481.x);
		                            v167 = (__m128)LODWORD(v481.x);
		                            v167.m128_f32[0] = v481.x * v502;
		                            *(_QWORD *)&v481.x = _mm_unpacklo_ps(v167, v165).m128_u64[0];
		                            v481.z = v155 * v502;
		                            *(_QWORD *)&v480.x = v146;
		                            v480.z = v147;
		                            v168 = UnityEngine::Vector3::op_Addition(&v487, &v480, &v481, 0LL);
		                            v165.m128_u64[0] = *(_QWORD *)&v168->x;
		                            *(float *)&v168 = v168->z;
		                            v496 = 0LL;
		                            *(_QWORD *)&v481.x = v165.m128_u64[0];
		                            LODWORD(v481.z) = (_DWORD)v168;
		                            *(_QWORD *)&v480.x = v163;
		                            LODWORD(v480.z) = z_low;
		                            UnityEngine::Plane::Plane(&v496, &v480, &v481, 0LL);
		                            *(Plane *)&v510.m_Buffer[96] = v496;
		                            y_low.m128_f32[0] = y_low.m128_f32[0] * *(float *)v152.m128i_i32;
		                            x_low.m128_f32[0] = x_low.m128_f32[0] * *(float *)v152.m128i_i32;
		                            *(_QWORD *)&v481.x = _mm_unpacklo_ps(x_low, y_low).m128_u64[0];
		                            v481.z = v155 * *(float *)v152.m128i_i32;
		                            *(_QWORD *)&v480.x = v146;
		                            v480.z = v147;
		                            v170 = UnityEngine::Vector3::op_Subtraction(&v487, &v480, &v481, v169);
		                            v165.m128_u64[0] = *(_QWORD *)&v170->x;
		                            v171 = v170->z;
		                            v503 = 0LL;
		                            *(_QWORD *)&v481.x = v165.m128_u64[0];
		                            v481.z = v171;
		                            *(_QWORD *)&v480.x = v154;
		                            v480.z = v155;
		                            UnityEngine::Plane::Plane(&v503, &v480, &v481, 0LL);
		                            *(Plane *)&v510.m_Buffer[112] = v503;
		                            *(_QWORD *)&v481.x = v157;
		                            v481.z = v158;
		                            v172 = UnityEngine::Vector3::op_UnaryNegation(&v487, &v481, 0LL);
		                            x_low.m128_u64[0] = *(_QWORD *)&v172->x;
		                            v173 = v172->z;
		                            version = (__m128)entity.version;
		                            v175 = (__m128)entity.version;
		                            v175.m128_f32[0] = *(float *)&entity.version * v493[0].y;
		                            v176 = (__m128)entity.version;
		                            v176.m128_f32[0] = *(float *)&entity.version * v493[0].x;
		                            *(_QWORD *)&v481.x = _mm_unpacklo_ps(v176, v175).m128_u64[0];
		                            v481.z = *(float *)&entity.version * v158;
		                            *(_QWORD *)&v480.x = v146;
		                            v480.z = v147;
		                            v177 = UnityEngine::Vector3::op_Addition(&v487, &v480, &v481, 0LL);
		                            v175.m128_u64[0] = *(_QWORD *)&v177->x;
		                            *(float *)&v177 = v177->z;
		                            v523 = 0LL;
		                            *(_QWORD *)&v481.x = v175.m128_u64[0];
		                            LODWORD(v481.z) = (_DWORD)v177;
		                            *(_QWORD *)&v480.x = x_low.m128_u64[0];
		                            v480.z = v173;
		                            UnityEngine::Plane::Plane(&v523, &v480, &v481, 0LL);
		                            *(Plane *)&v510.m_Buffer[128] = v523;
		                            v178 = version.m128_f32[0] * v158;
		                            v179 = version;
		                            v179.m128_f32[0] = version.m128_f32[0] * v493[0].y;
		                            version.m128_f32[0] = version.m128_f32[0] * v493[0].x;
		                            *(_QWORD *)&v481.x = _mm_unpacklo_ps(version, v179).m128_u64[0];
		                            v481.z = v178;
		                            *(_QWORD *)&v480.x = v146;
		                            v480.z = v147;
		                            v181 = UnityEngine::Vector3::op_Subtraction(&v487, &v480, &v481, v180);
		                            v179.m128_u64[0] = *(_QWORD *)&v181->x;
		                            v182 = v181->z;
		                            v522 = 0LL;
		                            *(_QWORD *)&v481.x = v179.m128_u64[0];
		                            v481.z = v182;
		                            *(_QWORD *)&v480.x = v157;
		                            v480.z = v158;
		                            UnityEngine::Plane::Plane(&v522, &v480, &v481, 0LL);
		                            *(Plane *)&v510.m_Buffer[144] = v522;
		                            *(_QWORD *)&v481.x = v160;
		                            v481.z = v161;
		                            v183 = UnityEngine::Vector3::op_UnaryNegation(&v487, &v481, 0LL);
		                            v184 = *(_QWORD *)&v183->x;
		                            v185 = v183->z;
		                            globalIndex = (__m128)entity.globalIndex;
		                            v187 = (__m128)entity.globalIndex;
		                            v187.m128_f32[0] = *(float *)&entity.globalIndex * v489.y;
		                            v188 = (__m128)entity.globalIndex;
		                            v188.m128_f32[0] = *(float *)&entity.globalIndex * v489.x;
		                            *(_QWORD *)&v481.x = _mm_unpacklo_ps(v188, v187).m128_u64[0];
		                            v481.z = *(float *)&entity.globalIndex * v161;
		                            *(_QWORD *)&v480.x = v146;
		                            v480.z = v147;
		                            v189 = UnityEngine::Vector3::op_Addition(&v487, &v480, &v481, 0LL);
		                            v187.m128_u64[0] = *(_QWORD *)&v189->x;
		                            *(float *)&v189 = v189->z;
		                            v568 = 0LL;
		                            *(_QWORD *)&v481.x = v187.m128_u64[0];
		                            LODWORD(v481.z) = (_DWORD)v189;
		                            *(_QWORD *)&v480.x = v184;
		                            v480.z = v185;
		                            UnityEngine::Plane::Plane(&v568, &v480, &v481, 0LL);
		                            *(Plane *)&v510.m_Buffer[160] = v568;
		                            v190 = globalIndex.m128_f32[0] * v161;
		                            v191 = globalIndex;
		                            v191.m128_f32[0] = globalIndex.m128_f32[0] * v489.y;
		                            globalIndex.m128_f32[0] = globalIndex.m128_f32[0] * v489.x;
		                            *(_QWORD *)&v481.x = _mm_unpacklo_ps(globalIndex, v191).m128_u64[0];
		                            v481.z = v190;
		                            *(_QWORD *)&v480.x = v146;
		                            v480.z = v147;
		                            v193 = UnityEngine::Vector3::op_Subtraction(&v487, &v480, &v481, v192);
		                            v191.m128_u64[0] = *(_QWORD *)&v193->x;
		                            v194 = v193->z;
		                            v567 = 0LL;
		                            *(_QWORD *)&v481.x = v191.m128_u64[0];
		                            v481.z = v194;
		                            *(_QWORD *)&v480.x = v160;
		                            v480.z = v161;
		                            UnityEngine::Plane::Plane(&v567, &v480, &v481, 0LL);
		                            *(Plane *)&v510.m_Buffer[176] = v567;
		                            v118 = v512;
		                            v119 = v484;
		                            v98 = hgCamera;
		                          }
		                          *(_OWORD *)&v515.m00 = *(_OWORD *)&v98->fields.lodCrossFadeConfig.cameraPosition.x;
		                          *(_OWORD *)&v515.m01 = *(_OWORD *)&v98->fields.lodCrossFadeConfig.c0.y;
		                          *(_OWORD *)&v515.m02 = *(_OWORD *)&v98->fields.lodCrossFadeConfig.c1.z;
		                          LODWORD(v515.m13) = HIDWORD(*(_QWORD *)&v98->fields.lodCrossFadeConfig.maxProjFactorSquared1);
		                          *(_QWORD *)&v515.m21 = v118;
		                          LODWORD(v515.m02) = v119;
		                          *(_QWORD *)&v515.m30 = v118;
		                          LODWORD(v515.m11) = v119;
		                          *(_QWORD *)&v515.m00 = v118;
		                          LODWORD(v515.m20) = v119;
		                          v515.m03 = v104 * v104;
		                          v515.m32 = v104 * v104;
		                          LOBYTE(v515.m13) = 0;
		                          HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetECSRenderFlags(
		                            this,
		                            light,
		                            0,
		                            &objectFlags,
		                            objectFlagsMask,
		                            &renderFlags,
		                            renderFlagsMask,
		                            0LL);
		                          v197 = v98->fields.camera;
		                          if ( !v197 )
		                            sub_1800D8250(v196, v195);
		                          v198 = (__int64 (__fastcall *)(Camera *))qword_18F36F120;
		                          if ( !qword_18F36F120 )
		                          {
		                            v198 = (__int64 (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Camera::get_cullingMask()");
		                            qword_18F36F120 = (__int64)v198;
		                          }
		                          v199 = v198(v197);
		                          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		                          v200 = v199 & ~TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields->COMPOUND_CHARACTER_LAYER_MASK;
		                          v201 = v510;
		                          v202 = v98->fields.camera;
		                          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		                          SceneCullingMaskFromCamera = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(
		                                                         v202,
		                                                         0LL);
		                          m_punctualLightShadowScreenSizeMinSquared = this->fields.m_punctualLightShadowScreenSizeMinSquared;
		                          v491 = (Quaternion)v201;
		                          v205 = UnityEngine::HyperGryph::HGCullingSystem::AddCullViewByPlanes(
		                                   (NativeArray_1_UnityEngine_Plane_ *)&v491,
		                                   0,
		                                   SceneCullingMaskFromCamera,
		                                   v200,
		                                   objectFlags,
		                                   objectFlagsMask[0],
		                                   (LODCrossFadeConfig *)&v515,
		                                   m_punctualLightShadowScreenSizeMinSquared,
		                                   CameraType__Enum_Shadow,
		                                   0LL);
		                          v206 = (void (*)(void))qword_18F3AB298;
		                          if ( !qword_18F3AB298 )
		                          {
		                            v206 = (void (*)(void))sub_180059EA0(
		                                                     "UnityEngine.HyperGryph.HGCullingSystem::DispatchBatchCullingJobs()");
		                            qword_18F3AB298 = (__int64)v206;
		                          }
		                          v206();
		                          v207 = renderFlagsMask[0];
		                          v208 = renderFlags;
		                          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                          LOWORD(globalKeywords) = 0;
		                          RendererList = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                                           v205,
		                                           (HGRenderFlags__Enum)(v207 | 0x100),
		                                           (HGRenderFlags__Enum)(v208 | 0x100),
		                                           HGShaderLightMode__Enum_ShadowCaster,
		                                           globalKeywords,
		                                           m_Ptr,
		                                           0,
		                                           0,
		                                           0xFFFFFFFF,
		                                           0,
		                                           0,
		                                           0LL);
		                          v210 = UnityEngine::HyperGryph::HGGrassRender::CreateRendererList(
		                                   v205,
		                                   (HGRenderFlags__Enum)(renderFlagsMask[0] | 0x100),
		                                   (HGRenderFlags__Enum)(renderFlags | 0x100),
		                                   HGShaderLightMode__Enum_ShadowCaster,
		                                   m_Ptr,
		                                   0,
		                                   0LL);
		                          v211 = UnityEngine::HyperGryph::HGTreeRender::CreateRendererList(
		                                   v205,
		                                   (HGRenderFlags__Enum)(renderFlagsMask[0] | 0x100),
		                                   (HGRenderFlags__Enum)(renderFlags | 0x100),
		                                   HGShaderLightMode__Enum_ShadowCaster,
		                                   m_Ptr,
		                                   0,
		                                   0LL);
		                          *(_DWORD *)v521 = RendererList;
		                          LODWORD(v507->klass) = v210;
		                          v213 = m_punctualLightShadowParams2;
		                          *m_punctualLightShadowParams2 = v211;
		                        }
		                        if ( !v497 )
		                          sub_1800D8250(v213, v212);
		                        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		                          (TextureHandle *)&v518,
		                          &v562,
		                          (TextureHandle *)&v497[13].monitor,
		                          DepthAccess__Enum_Write,
		                          RenderBufferLoadAction__Enum_Load,
		                          RenderBufferStoreAction__Enum_Store,
		                          0.0,
		                          0,
		                          0,
		                          0LL);
		                        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		                          &v562,
		                          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_punctualLightShadowMapRenderFunc,
		                          0LL,
		                          0,
		                          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPassData>);
		                        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v562, 0, 0LL);
		                      }
		                      catch ( Il2CppExceptionWrapper *v591 )
		                      {
		                        v504.m_RenderPass = (HGRenderGraphPass *)v591->ex;
		                        sub_180268AE0(&v504);
		                        z = v520;
		                        v499 = v520;
		                        v14 = v519;
		                        v509 = v519;
		                        v9 = this;
		                        SlotCount = v500;
		                        goto LABEL_75;
		                      }
		                      sub_180268AE0(&v504);
		                      v217 = (__m128)0x3F800000u;
		                      v14 = v509;
		                      SlotCount = v500;
		                      z = v499;
		LABEL_76:
		                      for ( j = 0; ; ++j )
		                      {
		                        renderFlags = j;
		                        if ( j >= HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::get_m_dynamicPunctualShadowCasterCount(
		                                    v9,
		                                    0LL) )
		                        {
		                          v417 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                                   (Int32Enum__Enum)0x7Fu,
		                                   MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		                          if ( !renderGraph )
		                            sub_1800D8250(v419, v418);
		                          HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		                            (HGRenderGraphBuilder *)&v515,
		                            renderGraph,
		                            (String *)"Punctual Light ShadowMap Push Data",
		                            &v505,
		                            v417,
		                            1,
		                            ProfilingHGPass__Enum_Shadow,
		                            MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPushDataPassData>);
		                          *(_OWORD *)&v574.m_RenderPass = *(_OWORD *)&v515.m00;
		                          *(_OWORD *)&v574.m_RenderGraph = *(_OWORD *)&v515.m01;
		                          *(_QWORD *)&v503.m_Normal.x = 0LL;
		                          *(_QWORD *)&v503.m_Normal.z = &v574;
		                          try
		                          {
		                            for ( k = 0; k < SlotCount; ++k )
		                            {
		                              v584 = *UnityEngine::HyperGryph::ECS::EntityManager::GetRendererEntityManager(
		                                        (EntityManager *)&v515,
		                                        0LL);
		                              m_targetStaticPunctualLights = v9->fields.m_targetStaticPunctualLights;
		                              if ( !m_targetStaticPunctualLights )
		                                sub_1800D8250(0LL, v420);
		                              sub_180036DD0(m_targetStaticPunctualLights, &entity, k);
		                              if ( UnityEngine::HyperGryph::ECS::EntityManager::HasEntity(&v584, entity, 0LL) )
		                              {
		                                v423 = v9->fields.m_targetStaticPunctualLights;
		                                if ( !v423 )
		                                  sub_1800D8250(0LL, v422);
		                                sub_180036DD0(v423, &v507, k);
		                                v514 = (HGSharedLightData)v507;
		                                v426 = v9->fields.m_punctualLightShadowParams;
		                                if ( !v426 )
		                                  sub_1800D8250(v425, v424);
		                                v427 = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&v514, 0LL);
		                                *(float *)(sub_180002100(v426, k) + 8) = v427;
		                                v430 = v9->fields.m_punctualLightShadowParams;
		                                if ( !v430 )
		                                  sub_1800D8250(v429, v428);
		                                *(_QWORD *)&v487.x = v14;
		                                v487.z = z;
		                                PunctualLightShadowStrength = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetPunctualLightShadowStrength(
		                                                                v9,
		                                                                v514,
		                                                                &v487,
		                                                                0LL);
		                                *(float *)(sub_180002100(v430, k) + 12) = PunctualLightShadowStrength;
		                              }
		                            }
		                            v433 = v505;
		                            v434 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                      (TextureHandle *)&v515,
		                                      renderGraph,
		                                      v9->fields.m_cachedPunctualLightShadowAtlas,
		                                      0LL);
		                            sub_180003640(v433);
		                            v433[1] = (Object)v434;
		                            v435 = v505;
		                            m_punctualLightWorldToShadowMatrices = (Object__Class *)v9->fields.m_punctualLightWorldToShadowMatrices;
		                            sub_180003640(v505);
		                            v435[2].klass = m_punctualLightWorldToShadowMatrices;
		                            if ( dword_18F35FD08 )
		                            {
		                              v437 = (((unsigned __int64)&v435[2] >> 12) & 0x1FFFFF) >> 6;
		                              _m_prefetchw(&qword_18F0BCBA0[v437 + 36190]);
		                              do
		                                v438 = qword_18F0BCBA0[v437 + 36190];
		                              while ( v438 != _InterlockedCompareExchange64(
		                                                &qword_18F0BCBA0[v437 + 36190],
		                                                v438 | (1LL << (((unsigned __int64)&v435[2] >> 12) & 0x3F)),
		                                                v438) );
		                            }
		                            v439 = v505;
		                            v440 = (MonitorData *)v9->fields.m_punctualLightShadowParams;
		                            sub_180003640(v505);
		                            v439[2].monitor = v440;
		                            if ( dword_18F35FD08 )
		                            {
		                              v441 = (((unsigned __int64)&v439[2].monitor >> 12) & 0x1FFFFF) >> 6;
		                              _m_prefetchw(&qword_18F0BCBA0[v441 + 36190]);
		                              do
		                                v442 = qword_18F0BCBA0[v441 + 36190];
		                              while ( v442 != _InterlockedCompareExchange64(
		                                                &qword_18F0BCBA0[v441 + 36190],
		                                                v442 | (1LL << (((unsigned __int64)&v439[2].monitor >> 12) & 0x3F)),
		                                                v442) );
		                            }
		                            v443 = v505;
		                            v444 = (Object__Class *)v9->fields.m_punctualLightShadowParams2;
		                            sub_180003640(v505);
		                            v443[3].klass = v444;
		                            if ( dword_18F35FD08 )
		                            {
		                              v445 = (((unsigned __int64)&v443[3] >> 12) & 0x1FFFFF) >> 6;
		                              _m_prefetchw(&qword_18F0BCBA0[v445 + 36190]);
		                              do
		                                v446 = qword_18F0BCBA0[v445 + 36190];
		                              while ( v446 != _InterlockedCompareExchange64(
		                                                &qword_18F0BCBA0[v445 + 36190],
		                                                v446 | (1LL << (((unsigned __int64)&v443[3] >> 12) & 0x3F)),
		                                                v446) );
		                            }
		                            v447 = v505;
		                            m_punctualShadowAtlasSize = (MonitorData *)v9->fields.m_punctualShadowAtlasSize;
		                            sub_180003640(v505);
		                            v447[3].monitor = m_punctualShadowAtlasSize;
		                            for ( m = 0; ; ++m )
		                            {
		                              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		                              if ( m >= TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_maxShadowCasterCount )
		                                break;
		                              for ( n = 0; n < 16; ++n )
		                              {
		                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		                                v452 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		                                v453 = v9->fields.m_punctualLightWorldToShadowMatrices;
		                                if ( !v453 )
		                                  sub_1800D8250(0LL, v451);
		                                v454 = (Matrix4x4 *)sub_18049E964(v453, m);
		                                *(&v452[2].shadowData._ASMWorldToShadowBaseMatrix.m21 + 16 * m + n) = UnityEngine::Matrix4x4::get_Item(v454, n, 0LL);
		                              }
		                              for ( ii = 0; ii < 4; ++ii )
		                              {
		                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		                                v457 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		                                v458 = v9->fields.m_punctualLightShadowParams;
		                                if ( !v458 )
		                                  sub_1800D8250(0LL, v456);
		                                v459 = sub_180002100(v458, m);
		                                *(&v457[11].shadowData._PunctualLightShadowTexelSize.z + 4 * m + ii) = sub_1832E0B20(v459, (unsigned int)ii);
		                              }
		                              for ( jj = 0; jj < 4; ++jj )
		                              {
		                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		                                v462 = TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields;
		                                v463 = v9->fields.m_punctualLightShadowParams2;
		                                if ( !v463 )
		                                  sub_1800D8250(0LL, v461);
		                                v464 = sub_180002100(v463, m);
		                                *(&v462[13].shadowData._ASMWorldToShadowBaseMatrix.m01 + 4 * m + jj) = sub_1832E0B20(v464, (unsigned int)jj);
		                              }
		                            }
		                            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils);
		                            v465 = 1.0 / (float)v516->fields.m_punctualShadowAtlasSize.m_Y;
		                            v496.m_Normal.x = 1.0 / (float)v9->fields.m_punctualShadowAtlasSize.m_X;
		                            v496.m_Normal.y = v465;
		                            v496.m_Normal.z = (float)v9->fields.m_punctualShadowAtlasSize.m_X;
		                            v496.m_Distance = (float)v516->fields.m_punctualShadowAtlasSize.m_Y;
		                            *(Plane *)&TypeInfo::HG::Rendering::Runtime::HGShadowConstantBufferUtils->static_fields[15].shadowData._ASMIndirectWorldToShadow.m02 = v496;
		                            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		                            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		                              &v574,
		                              (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_punctualLightShadowMapPushDataFunc,
		                              0LL,
		                              0,
		                              MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPushDataPassData>);
		                            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v574, 0, 0LL);
		                            shadowResult->punctualLightShadowActive = 1;
		                            v466 = (TextureHandle *)v505;
		                            sub_180003640(v505);
		                            shadowResult->punctualLightShadowResult = v466[1];
		                          }
		                          catch ( Il2CppExceptionWrapper *v586 )
		                          {
		                            *(Il2CppExceptionWrapper *)&v503.m_Normal.x = (Il2CppExceptionWrapper)v586->ex;
		                          }
		                          sub_180268AE0(&v503);
		                          return;
		                        }
		                        m_targetDynamicPunctualLights = v9->fields.m_targetDynamicPunctualLights;
		                        if ( !m_targetDynamicPunctualLights )
		                          goto LABEL_233;
		                        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		                        v220 = (LightCaster *)sub_1803C0774(m_targetDynamicPunctualLights, j);
		                        if ( HG::Rendering::Runtime::LightCaster::IsLightVaild(v220, 0LL) )
		                          break;
		LABEL_146:
		                        SlotCount = v500;
		                      }
		                      m_punctualShadowAtlasBaseTileSize = v9->fields.m_punctualShadowAtlasBaseTileSize;
		                      camera = j & 3;
		                      v222 = j;
		                      if ( j < 0 )
		                      {
		                        v222 = j + 3;
		                        camera = (unsigned int)(camera - 4);
		                      }
		                      punctualLightStaticAtlasAllocator = (HGPunctualLightStaticAtlasAllocator *)(unsigned int)(camera * v9->fields.m_punctualShadowAtlasBaseTileSize);
		                      v513.m_XMin = m_punctualShadowAtlasBaseTileSize * ((v222 >> 2) + 4);
		                      v513.m_YMin = (int)punctualLightStaticAtlasAllocator;
		                      v513.m_Width = m_punctualShadowAtlasBaseTileSize;
		                      v513.m_Height = m_punctualShadowAtlasBaseTileSize;
		                      v223 = v9->fields.m_targetDynamicPunctualLights;
		                      if ( !v223 )
		                        goto LABEL_233;
		                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightCaster);
		                      v224 = (LightCaster *)sub_1803C0774(v223, j);
		                      HGSharedLightData = HG::Rendering::Runtime::LightCaster::GetHGSharedLightData(v224, 0LL);
		                      if ( UnityEngine::HGSharedLightData::get_enableOverrideShadowLight_Injected(
		                             &HGSharedLightData,
		                             0LL) )
		                      {
		                        v240 = UnityEngine::HGSharedLightData::get_overrideShadowLightPosition(
		                                 &v593,
		                                 &HGSharedLightData,
		                                 0LL);
		                        v241 = *(_QWORD *)&v240->x;
		                        v242 = v240->z;
		                        v529 = *UnityEngine::HGSharedLightData::get_overrideShadowLightRotation(
		                                  &v594,
		                                  &HGSharedLightData,
		                                  0LL);
		                        v245 = (Quaternion *)sub_182FA5910(v608, &v529, v243, v244);
		                        *(_QWORD *)&v530.x = _mm_unpacklo_ps(v217, v217).m128_u64[0];
		                        LODWORD(v530.z) = v217.m128_i32[0];
		                        v491 = *v245;
		                        *(_QWORD *)&v531.x = v241;
		                        v531.z = v242;
		                        v246 = UnityEngine::Matrix4x4::TRS(&v572, &v531, &v491, &v530, 0LL);
		                        v247 = *(_OWORD *)&v246->m00;
		                        v248 = *(_OWORD *)&v246->m01;
		                        v249 = *(_OWORD *)&v246->m02;
		                        v250 = *(_OWORD *)&v246->m03;
		                        v251 = UnityEngine::HGSharedLightData::get_overrideShadowLightSpotAngle_Injected(
		                                 &HGSharedLightData,
		                                 0LL);
		                        v252 = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&HGSharedLightData, 0LL);
		                        v253 = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&HGSharedLightData, 0LL);
		                        LODWORD(v241) = UnityEngine::HGSharedLightData::get_shadowGuardAngle_Injected(
		                                          &HGSharedLightData,
		                                          0LL);
		                        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		                        *(_OWORD *)&v494.m00 = v247;
		                        *(_OWORD *)&v494.m01 = v248;
		                        *(_OWORD *)&v494.m02 = v249;
		                        *(_OWORD *)&v494.m03 = v250;
		                        HG::Rendering::Runtime::HGShadowUtils::ExtractSpotLightMatrix(
		                          &v572,
		                          &v494,
		                          v251,
		                          v252,
		                          v253,
		                          *(float *)&v241,
		                          &v588,
		                          &v589,
		                          &v590,
		                          0LL);
		                      }
		                      else
		                      {
		                        if ( UnityEngine::HGSharedLightData::get_type_Injected(&HGSharedLightData, 0LL) == LightType__Enum_Spot )
		                        {
		                          v231 = UnityEngine::HGSharedLightData::get_localToWorldMatrix(&v572, &HGSharedLightData, 0LL);
		                          v232 = *(_OWORD *)&v231->m00;
		                          v233 = *(_OWORD *)&v231->m01;
		                          v234 = *(_OWORD *)&v231->m02;
		                          v235 = *(_OWORD *)&v231->m03;
		                          v236 = UnityEngine::HGSharedLightData::get_spotAngle_Injected(&HGSharedLightData, 0LL);
		                          v237 = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&HGSharedLightData, 0LL);
		                          v238 = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&HGSharedLightData, 0LL);
		                          v239 = UnityEngine::HGSharedLightData::get_shadowGuardAngle_Injected(&HGSharedLightData, 0LL);
		                          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		                          *(_OWORD *)&v494.m00 = v232;
		                          *(_OWORD *)&v494.m01 = v233;
		                          *(_OWORD *)&v494.m02 = v234;
		                          *(_OWORD *)&v494.m03 = v235;
		                          HG::Rendering::Runtime::HGShadowUtils::ExtractSpotLightMatrix(
		                            &v572,
		                            &v494,
		                            v236,
		                            v237,
		                            v238,
		                            v239,
		                            &v588,
		                            &v589,
		                            &v590,
		                            0LL);
		                          goto LABEL_90;
		                        }
		                        v225 = UnityEngine::HGSharedLightData::get_worldPosition(&v592, &HGSharedLightData, 0LL);
		                        v226 = *(_QWORD *)&v225->x;
		                        v227 = v225->z;
		                        camera = (unsigned __int64)v9->fields.m_targetDynamicPunctualLights;
		                        if ( !camera )
		                          goto LABEL_233;
		                        v228 = *(_DWORD *)(sub_1803C0774(camera, j) + 8);
		                        v229 = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&HGSharedLightData, 0LL);
		                        v230 = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&HGSharedLightData, 0LL);
		                        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		                        *(_QWORD *)&v481.x = v226;
		                        v481.z = v227;
		                        HG::Rendering::Runtime::HGShadowUtils::ExtractPointLightMatrix(
		                          &v572,
		                          &v481,
		                          v228,
		                          v229,
		                          v230,
		                          2.0,
		                          &v588,
		                          &v589,
		                          &v590,
		                          0LL);
		                      }
		                      j = renderFlags;
		LABEL_90:
		                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		                      v254 = *(_OWORD *)&v588.m00;
		                      v494 = v588;
		                      v255 = *(_OWORD *)&v588.m01;
		                      v256 = *(_OWORD *)&v588.m02;
		                      v257 = *(_OWORD *)&v588.m03;
		                      v258 = *(_OWORD *)&v589.m00;
		                      v511 = v589;
		                      v259 = *(__m128 *)&v589.m01;
		                      v260 = *(_OWORD *)&v589.m02;
		                      v261 = *(_OWORD *)&v589.m03;
		                      v262 = HG::Rendering::Runtime::HGShadowUtils::GetShadowTransform(&v572, &v511, &v494, 0LL);
		                      v263 = *(_OWORD *)&v262->m00;
		                      v521 = *(_OWORD *)&v262->m01;
		                      v575 = *(_OWORD *)&v262->m02;
		                      v491 = *(Quaternion *)&v262->m03;
		                      camera = (unsigned __int64)v9->fields.m_punctualLightWorldToShadowMatrices;
		                      if ( !camera )
		                        goto LABEL_233;
		                      *(_OWORD *)&v494.m00 = v263;
		                      *(_OWORD *)&v494.m01 = *(_OWORD *)&v262->m01;
		                      *(_OWORD *)&v494.m02 = *(_OWORD *)&v262->m02;
		                      *(_OWORD *)&v494.m03 = *(_OWORD *)&v262->m03;
		                      sub_180041540(camera, j + SlotCount, &v494);
		                      v264 = v9->fields.m_punctualLightShadowParams;
		                      v265 = UnityEngine::HGSharedLightData::get_shadowNormalBias_Injected(&HGSharedLightData, 0LL);
		                      *(_OWORD *)&v494.m00 = v258;
		                      *(__m128 *)&v494.m01 = v259;
		                      *(_OWORD *)&v494.m02 = v260;
		                      *(_OWORD *)&v494.m03 = v261;
		                      v266 = HG::Rendering::Runtime::HGShadowUtils::GetShadowBias(
		                               &v609,
		                               &v494,
		                               (float)m_punctualShadowAtlasBaseTileSize,
		                               0.0,
		                               v265,
		                               HGShadowSampleMode__Enum_PCF_3x3,
		                               0LL);
		                      if ( !v264 )
		                        goto LABEL_233;
		                      *(Vector4 *)&v504.m_RenderPass = *v266;
		                      sub_18003FEF0(v264, j + SlotCount, &v504);
		                      v267 = v9->fields.m_punctualLightShadowParams;
		                      if ( !v267 )
		                        goto LABEL_233;
		                      v268 = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&HGSharedLightData, 0LL);
		                      *(float *)(sub_180002100(v267, j + SlotCount) + 8) = v268;
		                      v269 = v9->fields.m_punctualLightShadowParams;
		                      if ( !v269 )
		                        goto LABEL_233;
		                      *(_QWORD *)&v532.x = v509;
		                      v532.z = z;
		                      v270 = HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetPunctualLightShadowStrength(
		                               v9,
		                               HGSharedLightData,
		                               &v532,
		                               0LL);
		                      *(float *)(sub_180002100(v269, j + SlotCount) + 12) = v270;
		                      v507 = (Object *)v9->fields.m_punctualLightShadowParams2;
		                      v271 = UnityEngine::RectInt::get_xMin(&v513, 0LL);
		                      v272 = v9->fields.m_punctualShadowAtlasSize.m_X;
		                      v273 = UnityEngine::RectInt::get_yMin(&v513, 0LL);
		                      v274 = v516->fields.m_punctualShadowAtlasSize.m_Y;
		                      v275 = UnityEngine::RectInt::get_xMax(&v513, 0LL);
		                      v276 = this->fields.m_punctualShadowAtlasSize.m_X;
		                      yMax = UnityEngine::RectInt::get_yMax(&v513, 0LL);
		                      v278 = (float)yMax / (float)v516->fields.m_punctualShadowAtlasSize.m_Y;
		                      v503.m_Normal.x = (float)v271 / (float)v272;
		                      v503.m_Normal.y = (float)v273 / (float)v274;
		                      v503.m_Normal.z = (float)v275 / (float)v276;
		                      v503.m_Distance = v278;
		                      camera = (unsigned __int64)v507;
		                      if ( !v507 )
		                        goto LABEL_233;
		                      *(Plane *)&v504.m_RenderPass = v503;
		                      sub_18003FEF0(v507, (int)(v500 + renderFlags), &v504);
		                      v279 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                               (Int32Enum__Enum)0x7Eu,
		                               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		                      if ( !renderGraph )
		                        goto LABEL_233;
		                      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		                        &v504,
		                        renderGraph,
		                        (String *)"Render Punctual Light ShadowMaps",
		                        &v498,
		                        v279,
		                        1,
		                        ProfilingHGPass__Enum_Shadow,
		                        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPassData>);
		                      v563 = v504;
		                      *(_QWORD *)&v496.m_Normal.x = 0LL;
		                      *(_QWORD *)&v496.m_Normal.z = &v563;
		                      try
		                      {
		                        v282 = v498;
		                        if ( !v498 )
		                          sub_1800D8250(v281, v280);
		                        *(Object *)((char *)v498 + 60) = *(Object *)&v590.m00;
		                        *(Object *)((char *)v282 + 76) = *(Object *)&v590.m01;
		                        *(Object *)((char *)v282 + 92) = *(Object *)&v590.m02;
		                        *(Object *)((char *)v282 + 108) = *(Object *)&v590.m03;
		                        v283 = v498;
		                        if ( !v498 )
		                          sub_1800D8250(v281, v280);
		                        *(_OWORD *)((char *)&v498[7].monitor + 4) = v254;
		                        *(_OWORD *)((char *)&v283[8].monitor + 4) = v255;
		                        *(_OWORD *)((char *)&v283[9].monitor + 4) = v256;
		                        *(_OWORD *)((char *)&v283[10].monitor + 4) = v257;
		                        if ( !v498 )
		                          sub_1800D8250(v281, v280);
		                        *(RectInt *)((char *)&v498[2].monitor + 4) = v513;
		                        v284 = v498;
		                        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		                        v286 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields;
		                        if ( !v284 )
		                          sub_1800D8250(v286, v285);
		                        v284[15].klass = (Object__Class *)v286->s_clearShadowMaterial;
		                        if ( dword_18F35FD08 )
		                        {
		                          v287 = (((unsigned __int64)&v284[15] >> 12) & 0x1FFFFF) >> 6;
		                          _m_prefetchw(&qword_18F0BCBA0[v287 + 36190]);
		                          do
		                            v288 = qword_18F0BCBA0[v287 + 36190];
		                          while ( v288 != _InterlockedCompareExchange64(
		                                            &qword_18F0BCBA0[v287 + 36190],
		                                            v288 | (1LL << (((unsigned __int64)&v284[15] >> 12) & 0x3F)),
		                                            v288) );
		                        }
		                        v289 = v498;
		                        v9 = this;
		                        v292 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                  &v610,
		                                  renderGraph,
		                                  this->fields.m_cachedPunctualLightShadowAtlas,
		                                  0LL);
		                        if ( !v289 )
		                          sub_1800D8250(v291, v290);
		                        *(TextureHandle *)&v289[13].monitor = v292;
		                        v293 = v498;
		                        v296 = UnityEngine::HGSharedLightData::get_shadowBias_Injected(&HGSharedLightData, 0LL);
		                        if ( !v293 )
		                          sub_1800D8250(v295, v294);
		                        *(float *)&v293[2].monitor = v296;
		                        v297 = HGSharedLightData;
		                        v298 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		                        if ( !v298 )
		                          sub_1800D8250(v300, v299);
		                        v301.m_Ptr = v298->fields.renderContext.m_Ptr;
		                        *(_OWORD *)&v494.m00 = v254;
		                        *(_OWORD *)&v494.m01 = v255;
		                        *(_OWORD *)&v494.m02 = v256;
		                        *(_OWORD *)&v494.m03 = v257;
		                        *(_OWORD *)&v511.m00 = v258;
		                        *(__m128 *)&v511.m01 = v259;
		                        *(_OWORD *)&v511.m02 = v260;
		                        *(_OWORD *)&v511.m03 = v261;
		                        v302 = UnityEngine::Matrix4x4::op_Multiply(&v572, &v511, &v494, 0LL);
		                        if ( !v498 )
		                          sub_1800D8250(0LL, v303);
		                        v494 = *v302;
		                        v304 = hgCamera;
		                        HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PrepareRendererList(
		                          this,
		                          v297,
		                          hgCamera,
		                          v301,
		                          &v494,
		                          1,
		                          (RendererList *)&v498[12].monitor,
		                          0LL);
		                        v305 = HGSharedLightData;
		                        v306 = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(renderGraph, 0LL);
		                        if ( !v306 )
		                          sub_1800D8250(v308, v307);
		                        v309 = v306->fields.renderContext.m_Ptr;
		                        if ( !v498 )
		                          sub_1800D8250(v308, v307);
		                        v310 = (uint32_t *)&v498[11].monitor + 1;
		                        v512 = (uint32_t *)&v498[11].monitor + 1;
		                        v311 = (uint32_t *)&v498[12];
		                        entity = (Entity_1)&v498[12];
		                        m_punctualLightShadowParams2 = (uint32_t *)&v498[12].klass + 1;
		                        *(_OWORD *)&v511.m00 = v254;
		                        *(_OWORD *)&v511.m01 = v255;
		                        *(_OWORD *)&v511.m02 = v256;
		                        *(_OWORD *)&v511.m03 = v257;
		                        light = v305;
		                        *(_OWORD *)&v504.m_RenderPass = 0LL;
		                        v507 = 0LL;
		                        v508 = 0;
		                        memset(&v524, 0, 56);
		                        objectFlags = HGObjectFlags__Enum_None;
		                        z_low = HGObjectFlags__Enum_None;
		                        renderFlagsMask[0] = HGRenderFlags__Enum_None;
		                        v484 = HGRenderFlags__Enum_None;
		                        if ( IFix::WrappersManagerImpl::IsPatched(2187, 0LL) )
		                        {
		                          v413 = IFix::WrappersManagerImpl::GetPatch(2187, 0LL);
		                          if ( !v413 )
		                            sub_1800D8250(v415, v414);
		                          *(_OWORD *)&v494.m00 = v254;
		                          *(_OWORD *)&v494.m01 = v255;
		                          *(_OWORD *)&v494.m02 = v256;
		                          *(_OWORD *)&v494.m03 = v257;
		                          *(_OWORD *)&v511.m00 = v263;
		                          *(_OWORD *)&v511.m01 = v521;
		                          *(_OWORD *)&v511.m02 = v575;
		                          *(Quaternion *)&v511.m03 = v491;
		                          IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_878(
		                            v413,
		                            (Object *)this,
		                            light,
		                            (Object *)hgCamera,
		                            (ScriptableRenderContext)v309,
		                            &v511,
		                            &v494,
		                            _mm_shuffle_ps(v259, v259, 85).m128_f32[0],
		                            1,
		                            v310,
		                            v311,
		                            m_punctualLightShadowParams2,
		                            0LL);
		                        }
		                        else
		                        {
		                          v312 = (unsigned __int8 (__fastcall *)(HGSharedLightData *))qword_18F3AA2E8;
		                          if ( !qword_18F3AA2E8 )
		                          {
		                            v312 = (unsigned __int8 (__fastcall *)(HGSharedLightData *))sub_180059EA0(
		                                                                                          "UnityEngine.HGSharedLightData:"
		                                                                                          ":get_enableOBBCullingBox_Injec"
		                                                                                          "ted(UnityEngine.HGSharedLightData&)");
		                            qword_18F3AA2E8 = (__int64)v312;
		                          }
		                          if ( v312(&light) )
		                            Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::NativeArray(
		                              (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v504,
		                              12,
		                              Allocator__Enum_Temp,
		                              NativeArrayOptions__Enum_ClearMemory,
		                              MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
		                          else
		                            Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::NativeArray(
		                              (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v504,
		                              6,
		                              Allocator__Enum_Temp,
		                              NativeArrayOptions__Enum_ClearMemory,
		                              MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
		                          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		                          v313 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields;
		                          *(_OWORD *)&v494.m00 = v263;
		                          *(_OWORD *)&v494.m01 = v521;
		                          *(_OWORD *)&v494.m02 = v575;
		                          *(Quaternion *)&v494.m03 = v491;
		                          UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v494, v313->s_cullPlanes, 0LL);
		                          v314 = UnityEngine::Matrix4x4::get_inverse(&v572, &v511, 0LL);
		                          *(_OWORD *)&v494.m00 = *(_OWORD *)&v314->m00;
		                          *(_OWORD *)&v494.m01 = *(_OWORD *)&v314->m01;
		                          v315 = *(__m128 *)&v314->m02;
		                          *(_OWORD *)&v494.m03 = *(_OWORD *)&v314->m03;
		                          *(_OWORD *)&v494.m00 = *(_OWORD *)&v314->m00;
		                          *(_OWORD *)&v494.m01 = *(_OWORD *)&v314->m01;
		                          *(_OWORD *)&v494.m03 = *(_OWORD *)&v314->m03;
		                          *(_OWORD *)&v494.m01 = *(_OWORD *)&v314->m01;
		                          *(_OWORD *)&v494.m03 = *(_OWORD *)&v314->m03;
		                          v316 = (__m128)0x80000000;
		                          v317 = _mm_xor_ps(v315, (__m128)0x80000000);
		                          v318 = _mm_xor_ps((__m128)LODWORD(v314->m12), (__m128)0x80000000);
		                          v319 = -v314->m22;
		                          v320 = UnityEngine::HGSharedLightData::get_worldPosition(&v595, &light, 0LL);
		                          v321 = *(_QWORD *)&v320->x;
		                          objectFlagsMask[0] = LODWORD(v320->z);
		                          v322 = v321;
		                          v323 = *(float *)objectFlagsMask;
		                          if ( UnityEngine::HGSharedLightData::get_enableOverrideShadowLight_Injected(&light, 0LL) )
		                          {
		                            v324 = UnityEngine::HGSharedLightData::get_overrideShadowLightPosition(&v596, &light, 0LL);
		                            v322 = *(_QWORD *)&v324->x;
		                            v323 = v324->z;
		                          }
		                          *(double *)v316.m128_u64 = sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		                          v325 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_cullPlanes;
		                          v316.m128_f32[0] = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&light, 0LL);
		                          v326 = v316.m128_f32[0] * v319;
		                          v327 = v316;
		                          v327.m128_f32[0] = v316.m128_f32[0] * v318.m128_f32[0];
		                          v316.m128_f32[0] = v316.m128_f32[0] * v317.m128_f32[0];
		                          *(_QWORD *)&v533.x = _mm_unpacklo_ps(v316, v327).m128_u64[0];
		                          v533.z = v326;
		                          *(_QWORD *)&v534.x = v322;
		                          v534.z = v323;
		                          v328 = UnityEngine::Vector3::op_Addition(&v605, &v534, &v533, 0LL);
		                          v327.m128_u64[0] = *(_QWORD *)&v328->x;
		                          *(float *)&v328 = v328->z;
		                          v576 = 0LL;
		                          *(_QWORD *)&v535.x = v327.m128_u64[0];
		                          LODWORD(v535.z) = (_DWORD)v328;
		                          *(_QWORD *)&v536.x = _mm_unpacklo_ps(v317, v318).m128_u64[0];
		                          v536.z = v319;
		                          UnityEngine::Plane::Plane(&v576, &v536, &v535, 0LL);
		                          if ( !v325 )
		                            sub_1800D8250(v330, v329);
		                          if ( v325->max_length.size <= 4u )
		                            sub_1800D2AA0(v330, v329, v331);
		                          v325->vector[4] = v576;
		                          v332 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_cullPlanes;
		                          v333 = _mm_unpacklo_ps(v317, v318);
		                          *(_QWORD *)&v537.x = v333.m128_u64[0];
		                          v537.z = v319;
		                          v334 = UnityEngine::Vector3::op_UnaryNegation(&v602, &v537, 0LL);
		                          v335 = *(_QWORD *)&v334->x;
		                          v336 = v334->z;
		                          v333.m128_f32[0] = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&light, 0LL);
		                          v337 = v333.m128_f32[0] * v319;
		                          v338 = v333;
		                          v338.m128_f32[0] = v333.m128_f32[0] * v318.m128_f32[0];
		                          v333.m128_f32[0] = v333.m128_f32[0] * v317.m128_f32[0];
		                          *(_QWORD *)&v538.x = _mm_unpacklo_ps(v333, v338).m128_u64[0];
		                          v538.z = v337;
		                          *(_QWORD *)&v539.x = v322;
		                          v539.z = v323;
		                          v339 = UnityEngine::Vector3::op_Addition(&v601, &v539, &v538, 0LL);
		                          v338.m128_u64[0] = *(_QWORD *)&v339->x;
		                          *(float *)&v339 = v339->z;
		                          v577 = 0LL;
		                          *(_QWORD *)&v540.x = v338.m128_u64[0];
		                          LODWORD(v540.z) = (_DWORD)v339;
		                          *(_QWORD *)&v541.x = v335;
		                          v541.z = v336;
		                          UnityEngine::Plane::Plane(&v577, &v541, &v540, 0LL);
		                          if ( !v332 )
		                            sub_1800D8250(v341, v340);
		                          if ( v332->max_length.size <= 5u )
		                            sub_1800D2AA0(v341, v340, v342);
		                          v332->vector[5] = v577;
		                          for ( kk = 0; kk < 6; ++kk )
		                          {
		                            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		                            v346 = TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_cullPlanes;
		                            if ( !v346 )
		                              sub_1800D8250(0LL, v344);
		                            sub_180002990(v346, &v518, kk, v345);
		                            *((Vector4 *)&v504.m_RenderPass->klass + kk) = v518;
		                          }
		                          v347 = (unsigned __int8 (__fastcall *)(HGSharedLightData *))qword_18F3AA2E8;
		                          if ( !qword_18F3AA2E8 )
		                          {
		                            v347 = (unsigned __int8 (__fastcall *)(HGSharedLightData *))sub_180059EA0(
		                                                                                          "UnityEngine.HGSharedLightData:"
		                                                                                          ":get_enableOBBCullingBox_Injec"
		                                                                                          "ted(UnityEngine.HGSharedLightData&)");
		                            qword_18F3AA2E8 = (__int64)v347;
		                          }
		                          if ( v347(&light) )
		                          {
		                            *(_QWORD *)&v489.x = 0LL;
		                            v489.z = 0.0;
		                            v348 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))qword_18F3AA2F0;
		                            if ( !qword_18F3AA2F0 )
		                            {
		                              v348 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))sub_180059EA0(
		                                                                                            "UnityEngine.HGSharedLightDat"
		                                                                                            "a::get_cullingBoxRelativePos"
		                                                                                            "ition_Injected(UnityEngine.H"
		                                                                                            "GSharedLightData&,UnityEngine.Vector3&)");
		                              qword_18F3AA2F0 = (__int64)v348;
		                            }
		                            v348(&light, &v489);
		                            v542 = v489;
		                            *(_QWORD *)&v543.x = v321;
		                            LODWORD(v543.z) = objectFlagsMask[0];
		                            v349 = UnityEngine::Vector3::op_Addition(&v598, &v543, &v542, 0LL);
		                            v350 = *(Object **)&v349->x;
		                            v507 = v350;
		                            v528 = v350;
		                            objectFlagsMask[0] = LODWORD(v349->z);
		                            memset(v493, 0, 12);
		                            v351 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))qword_18F3AA2F8;
		                            if ( !qword_18F3AA2F8 )
		                            {
		                              v351 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))sub_180059EA0(
		                                                                                            "UnityEngine.HGSharedLightDat"
		                                                                                            "a::get_cullingBoxHalfExtents"
		                                                                                            "_Injected(UnityEngine.HGShar"
		                                                                                            "edLightData&,UnityEngine.Vector3&)");
		                              qword_18F3AA2F8 = (__int64)v351;
		                            }
		                            v351(&light, v493);
		                            *(_QWORD *)&v480.x = 0LL;
		                            v480.z = 0.0;
		                            v352 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))qword_18F3AA300;
		                            if ( !qword_18F3AA300 )
		                            {
		                              v352 = (void (__fastcall *)(HGSharedLightData *, Vector3 *))sub_180059EA0(
		                                                                                            "UnityEngine.HGSharedLightDat"
		                                                                                            "a::get_cullingBoxOrientation"
		                                                                                            "_Injected(UnityEngine.HGShar"
		                                                                                            "edLightData&,UnityEngine.Vector3&)");
		                              qword_18F3AA300 = (__int64)v352;
		                            }
		                            v352(&light, &v480);
		                            v544 = v480;
		                            v355 = _mm_loadu_si128((const __m128i *)sub_182FA5910(v611, &v544, v353, v354));
		                            v545 = *UnityEngine::Vector3::get_fwd(&v599, 0LL);
		                            v491 = (Quaternion)v355;
		                            v356 = UnityEngine::Quaternion::op_Multiply(&v606, &v491, &v545, 0LL);
		                            v549 = *(_QWORD *)&v356->x;
		                            v357 = v549;
		                            v358 = v356->z;
		                            v546 = *UnityEngine::Vector3::get_up(&v607, 0LL);
		                            v491 = (Quaternion)v355;
		                            v359 = UnityEngine::Quaternion::op_Multiply(&v597, &v491, &v546, 0LL);
		                            v570 = *(_QWORD *)&v359->x;
		                            v360 = v570;
		                            v361 = v359->z;
		                            v547 = *UnityEngine::Vector3::get_right(&v604, 0LL);
		                            v491 = (Quaternion)v355;
		                            v362 = UnityEngine::Quaternion::op_Multiply(&v603, &v491, &v547, 0LL);
		                            v555 = *(_QWORD *)&v362->x;
		                            v363 = v555;
		                            v364 = v362->z;
		                            *(_QWORD *)&v548.x = v357;
		                            v548.z = v358;
		                            v365 = UnityEngine::Vector3::op_UnaryNegation(&v600, &v548, 0LL);
		                            v366 = *(_QWORD *)&v365->x;
		                            v367 = v365->z;
		                            v355.m128i_i32[0] = LODWORD(v493[0].z);
		                            v368 = *((float *)&v549 + 1);
		                            v369 = (__m128)HIDWORD(v549);
		                            v369.m128_f32[0] = *((float *)&v549 + 1) * v493[0].z;
		                            v370 = *(float *)&v549;
		                            v371 = (__m128)(unsigned int)v549;
		                            v371.m128_f32[0] = *(float *)&v549 * v493[0].z;
		                            *(_QWORD *)&v550.x = _mm_unpacklo_ps(v371, v369).m128_u64[0];
		                            v550.z = v358 * v493[0].z;
		                            *(_QWORD *)&v565.x = v350;
		                            LODWORD(v565.z) = objectFlagsMask[0];
		                            v372 = UnityEngine::Vector3::op_Addition(&v567.m_Normal, &v565, &v550, 0LL);
		                            v369.m128_u64[0] = *(_QWORD *)&v372->x;
		                            *(float *)&v372 = v372->z;
		                            v578 = 0LL;
		                            *(_QWORD *)&v564.x = v369.m128_u64[0];
		                            LODWORD(v564.z) = (_DWORD)v372;
		                            *(_QWORD *)&v527.x = v366;
		                            v527.z = v367;
		                            UnityEngine::Plane::Plane(&v578, &v527, &v564, 0LL);
		                            *(Plane *)&v504.m_RenderPass->fields.depthAttachment.clearStencil = v578;
		                            v373 = *(float *)objectFlagsMask;
		                            v374 = *(float *)objectFlagsMask;
		                            v375 = (__m128)HIDWORD(v528);
		                            v376 = (__m128)HIDWORD(v528);
		                            v376.m128_f32[0] = *((float *)&v528 + 1) - (float)(v368 * *(float *)v355.m128i_i32);
		                            v377 = (__m128)(unsigned int)v528;
		                            v378 = (__m128)(unsigned int)v528;
		                            v378.m128_f32[0] = *(float *)&v528 - (float)(v370 * *(float *)v355.m128i_i32);
		                            v579 = 0LL;
		                            *(_QWORD *)&v526.x = _mm_unpacklo_ps(v378, v376).m128_u64[0];
		                            v526.z = *(float *)objectFlagsMask - (float)(v358 * *(float *)v355.m128i_i32);
		                            *(_QWORD *)&v525.x = v357;
		                            v525.z = v358;
		                            UnityEngine::Plane::Plane(&v579, &v525, &v526, 0LL);
		                            *(Plane *)&v504.m_RenderPass->fields._refCount_k__BackingField = v579;
		                            *(_QWORD *)&v571.x = v360;
		                            v571.z = v361;
		                            v379 = UnityEngine::Vector3::op_UnaryNegation(&v568.m_Normal, &v571, 0LL);
		                            *(_QWORD *)&v521 = *(_QWORD *)&v379->x;
		                            v380 = v379->z;
		                            v355.m128i_i32[0] = LODWORD(v493[0].y);
		                            v381 = *((float *)&v570 + 1);
		                            v382 = (__m128)HIDWORD(v570);
		                            v382.m128_f32[0] = *((float *)&v570 + 1) * v493[0].y;
		                            v383 = *(float *)&v570;
		                            v384 = (__m128)(unsigned int)v570;
		                            v384.m128_f32[0] = *(float *)&v570 * v493[0].y;
		                            *(_QWORD *)&v569.x = _mm_unpacklo_ps(v384, v382).m128_u64[0];
		                            v569.z = v361 * v493[0].y;
		                            v385 = v507;
		                            *(_QWORD *)&v560.x = v507;
		                            v560.z = v373;
		                            v386 = UnityEngine::Vector3::op_Addition(&v522.m_Normal, &v560, &v569, 0LL);
		                            v382.m128_u64[0] = *(_QWORD *)&v386->x;
		                            *(float *)&v386 = v386->z;
		                            v580 = 0LL;
		                            *(_QWORD *)&v561.x = v382.m128_u64[0];
		                            LODWORD(v561.z) = (_DWORD)v386;
		                            *(_QWORD *)&v551.x = v521;
		                            v551.z = v380;
		                            UnityEngine::Plane::Plane(&v580, &v551, &v561, 0LL);
		                            *(Plane *)&v504.m_RenderPass->fields.resourceWriteLists = v580;
		                            v387 = v375;
		                            v387.m128_f32[0] = v375.m128_f32[0] - (float)(v381 * *(float *)v355.m128i_i32);
		                            v388 = v377;
		                            v388.m128_f32[0] = v377.m128_f32[0] - (float)(v383 * *(float *)v355.m128i_i32);
		                            v583 = 0LL;
		                            *(_QWORD *)&v552.x = _mm_unpacklo_ps(v388, v387).m128_u64[0];
		                            v552.z = v374 - (float)(v361 * *(float *)v355.m128i_i32);
		                            *(_QWORD *)&v553.x = v360;
		                            v553.z = v361;
		                            UnityEngine::Plane::Plane(&v583, &v553, &v552, 0LL);
		                            *(Plane *)&v504.m_RenderPass->fields.usedRendererListList = v583;
		                            *(_QWORD *)&v554.x = v363;
		                            v554.z = v364;
		                            v389 = UnityEngine::Vector3::op_UnaryNegation(&v523.m_Normal, &v554, 0LL);
		                            v390 = *(_QWORD *)&v389->x;
		                            v391 = v389->z;
		                            v355.m128i_i32[0] = LODWORD(v493[0].x);
		                            v392 = *((float *)&v555 + 1);
		                            v393 = (__m128)HIDWORD(v555);
		                            v393.m128_f32[0] = *((float *)&v555 + 1) * v493[0].x;
		                            v394 = *(float *)&v555;
		                            v395 = (__m128)(unsigned int)v555;
		                            v395.m128_f32[0] = *(float *)&v555 * v493[0].x;
		                            *(_QWORD *)&v556.x = _mm_unpacklo_ps(v395, v393).m128_u64[0];
		                            v556.z = v364 * v493[0].x;
		                            *(_QWORD *)&v557.x = v385;
		                            v557.z = v373;
		                            v396 = UnityEngine::Vector3::op_Addition((Vector3 *)&v510, &v557, &v556, 0LL);
		                            v393.m128_u64[0] = *(_QWORD *)&v396->x;
		                            *(float *)&v396 = v396->z;
		                            v581 = 0LL;
		                            *(_QWORD *)&v566.x = v393.m128_u64[0];
		                            LODWORD(v566.z) = (_DWORD)v396;
		                            *(_QWORD *)&v558.x = v390;
		                            v558.z = v391;
		                            UnityEngine::Plane::Plane(&v581, &v558, &v566, 0LL);
		                            *(Plane *)&v504.m_RenderPass->fields.m_childPasses = v581;
		                            v375.m128_f32[0] = v375.m128_f32[0] - (float)(v392 * *(float *)v355.m128i_i32);
		                            v377.m128_f32[0] = v377.m128_f32[0] - (float)(v394 * *(float *)v355.m128i_i32);
		                            v582 = 0LL;
		                            *(_QWORD *)&v559.x = _mm_unpacklo_ps(v377, v375).m128_u64[0];
		                            v559.z = v374 - (float)(v364 * *(float *)v355.m128i_i32);
		                            *(_QWORD *)&v487.x = v363;
		                            v487.z = v364;
		                            UnityEngine::Plane::Plane(&v582, &v487, &v559, 0LL);
		                            *(Plane *)&v504.m_RenderPass[1].klass = v582;
		                            v304 = hgCamera;
		                          }
		                          *(_OWORD *)&v524.m00 = *(_OWORD *)&v304->fields.lodCrossFadeConfig.cameraPosition.x;
		                          *(_OWORD *)&v524.m01 = *(_OWORD *)&v304->fields.lodCrossFadeConfig.c0.y;
		                          *(_OWORD *)&v524.m02 = *(_OWORD *)&v304->fields.lodCrossFadeConfig.c1.z;
		                          *(_QWORD *)&v524.m03 = *(_QWORD *)&v304->fields.lodCrossFadeConfig.maxProjFactorSquared1;
		                          LOBYTE(v524.m13) = 0;
		                          HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::GetECSRenderFlags(
		                            this,
		                            light,
		                            1,
		                            &objectFlags,
		                            &z_low,
		                            renderFlagsMask,
		                            &v484,
		                            0LL);
		                          v399 = v304->fields.camera;
		                          if ( !v399 )
		                            sub_1800D8250(v398, v397);
		                          v400 = (__int64 (__fastcall *)(Camera *))qword_18F36F120;
		                          if ( !qword_18F36F120 )
		                          {
		                            v400 = (__int64 (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Camera::get_cullingMask()");
		                            qword_18F36F120 = (__int64)v400;
		                          }
		                          v401 = v400(v399);
		                          v402 = *(Quaternion *)&v504.m_RenderPass;
		                          v403 = v304->fields.camera;
		                          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		                          v404 = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(v403, 0LL);
		                          v405 = this->fields.m_punctualLightShadowScreenSizeMinSquared;
		                          v491 = v402;
		                          v406 = UnityEngine::HyperGryph::HGCullingSystem::AddCullViewByPlanes(
		                                   (NativeArray_1_UnityEngine_Plane_ *)&v491,
		                                   0,
		                                   v404,
		                                   v401,
		                                   objectFlags,
		                                   z_low,
		                                   (LODCrossFadeConfig *)&v524,
		                                   v405,
		                                   CameraType__Enum_Shadow,
		                                   0LL);
		                          v407 = (void (*)(void))qword_18F3AB298;
		                          if ( !qword_18F3AB298 )
		                          {
		                            v407 = (void (*)(void))sub_180059EA0(
		                                                     "UnityEngine.HyperGryph.HGCullingSystem::DispatchBatchCullingJobs()");
		                            qword_18F3AB298 = (__int64)v407;
		                          }
		                          v407();
		                          v408 = v484;
		                          v409 = renderFlagsMask[0];
		                          sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		                          LOWORD(globalKeywordsa) = 0;
		                          v410 = UnityEngine::HyperGryph::HGMeshRender::CreateRendererList(
		                                   v406,
		                                   (HGRenderFlags__Enum)(v408 | 0x100),
		                                   (HGRenderFlags__Enum)(v409 | 0x100),
		                                   HGShaderLightMode__Enum_ShadowCaster,
		                                   globalKeywordsa,
		                                   v309,
		                                   0,
		                                   0,
		                                   0xFFFFFFFF,
		                                   0,
		                                   0,
		                                   0LL);
		                          v411 = UnityEngine::HyperGryph::HGGrassRender::CreateRendererList(
		                                   v406,
		                                   (HGRenderFlags__Enum)(v484 | 0x100),
		                                   (HGRenderFlags__Enum)(renderFlagsMask[0] | 0x100),
		                                   HGShaderLightMode__Enum_ShadowCaster,
		                                   v309,
		                                   0,
		                                   0LL);
		                          v412 = UnityEngine::HyperGryph::HGTreeRender::CreateRendererList(
		                                   v406,
		                                   (HGRenderFlags__Enum)(v484 | 0x100),
		                                   (HGRenderFlags__Enum)(renderFlagsMask[0] | 0x100),
		                                   HGShaderLightMode__Enum_ShadowCaster,
		                                   v309,
		                                   0,
		                                   0LL);
		                          *v512 = v410;
		                          *(_DWORD *)entity.globalIndex = v411;
		                          *m_punctualLightShadowParams2 = v412;
		                        }
		                        v416 = v498;
		                        sub_180003640(v498);
		                        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		                          (TextureHandle *)&v515,
		                          &v563,
		                          (TextureHandle *)&v416[13].monitor,
		                          DepthAccess__Enum_Write,
		                          RenderBufferLoadAction__Enum_Load,
		                          RenderBufferStoreAction__Enum_Store,
		                          0.0,
		                          0,
		                          0,
		                          0LL);
		                        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		                          &v563,
		                          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_punctualLightShadowMapRenderFunc,
		                          0LL,
		                          0,
		                          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPassData>);
		                        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v563, 0, 0LL);
		                      }
		                      catch ( Il2CppExceptionWrapper *v585 )
		                      {
		                        *(Il2CppExceptionWrapper *)&v496.m_Normal.x = (Il2CppExceptionWrapper)v585->ex;
		                        sub_180268AE0(&v496);
		                        z = v520;
		                        v499 = v520;
		                        v14 = v519;
		                        v509 = v519;
		                        v217 = (__m128)0x3F800000u;
		                        v9 = this;
		                        j = renderFlags;
		                        goto LABEL_146;
		                      }
		                      sub_180268AE0(&v496);
		                      v217 = (__m128)0x3F800000u;
		                      v14 = v509;
		                      j = renderFlags;
		                      z = v499;
		                      goto LABEL_146;
		                    }
		                  }
		                }
		              }
		            }
		          }
		LABEL_233:
		          sub_1800D8250(camera, punctualLightStaticAtlasAllocator);
		        }
		        v22 = UnityEngine::HGSharedLightData::get_worldPosition(&v487, &_unity_self, 0LL);
		        v23 = *(_QWORD *)&v22->x;
		        v24 = v22->z;
		        v25 = UnityEngine::HGSharedLightData::get_shadowNearPlane_Injected(&_unity_self, 0LL);
		        v26 = UnityEngine::HGSharedLightData::get_shadowFarPlane_Injected(&_unity_self, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		        *(_QWORD *)&v480.x = v23;
		        v480.z = v24;
		        HG::Rendering::Runtime::HGShadowUtils::ExtractPointLightMatrix(
		          &v494,
		          &v480,
		          index,
		          v25,
		          v26,
		          2.0,
		          &v524,
		          &v515,
		          &v511,
		          0LL);
		      }
		      targetSlot = v484;
		      goto LABEL_18;
		    }
		    v467 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		             (Int32Enum__Enum)0x7Fu,
		             MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v469, v468);
		    v573 = *(HGRenderGraphBuilder *)sub_1808AE784(
		                                      (unsigned int)&v515,
		                                      (_DWORD)renderGraph,
		                                      (unsigned int)"Skip Punctual Light ShadowMap",
		                                      (unsigned int)&v517,
		                                      (__int64)v467);
		    *(_QWORD *)&v496.m_Normal.x = 0LL;
		    *(_QWORD *)&v496.m_Normal.z = &v573;
		    try
		    {
		      v470 = v517;
		      defaultResources = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		      if ( !defaultResources )
		        sub_1800D8250(v473, v472);
		      if ( !v470 )
		        sub_1800D8250(v473, v472);
		      v470[1] = defaultResources->fields._defaultShadowTexture_k__BackingField;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v573,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::HGPunctualLightShadowManagerV2->static_fields->s_punctualLightShadowMapSkipRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PunctualLightShadowPushDataPassData>);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v573, 0, 0LL);
		      shadowResult->punctualLightShadowActive = 0;
		      if ( !v517 )
		        sub_1800D8250(0LL, v474);
		      shadowResult->punctualLightShadowResult = v517[1];
		    }
		    catch ( Il2CppExceptionWrapper *v587 )
		    {
		      *(Il2CppExceptionWrapper *)&v496.m_Normal.x = (Il2CppExceptionWrapper)v587->ex;
		    }
		    sub_180268AE0(&v496);
		  }
		}
		
	}
}
