using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using HG.Rendering.Runtime.Sludge;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class SludgePassConstructor : IPassConstructor // TypeDefIndex: 38427
	{
		// Fields
		internal static readonly int _Hit; // 0x00
		internal static readonly int _HitRange; // 0x04
		internal static readonly int _HitPosition; // 0x08
		internal static readonly int _DeltaTime; // 0x0C
		internal static readonly int _TotalTime; // 0x10
		internal static readonly int _AtlasTillingOffset; // 0x14
		private TextureHandle m_curSludgeTexture; // 0x10
		private TextureHandle m_prevSludgeTexture; // 0x20
		private TextureHandle m_prevSludgeThickness; // 0x30
		private TextureHandle m_prevSludgeMinHeight; // 0x40
		private TextureHandle m_curSludgeThickness; // 0x50
		private TextureHandle m_curSludgeMinHeight; // 0x60
		private MaterialPropertyBlock m_sludgeBlitPropertyBlock; // 0x70
		private Material m_sludgeBlitMaterial; // 0x78
		private Shader m_sludgeBlitShader; // 0x80
		private Material m_sludgeBlitMaterialV2; // 0x88
		private Shader m_sludgeBlitShaderV2; // 0x90
		private Texture2D m_defaultThicknessMap; // 0x98
		private RTHandle m_defaultThicknessMapRTHandle; // 0xA0
		private RTHandle m_defaultMinHeightRTHandle; // 0xA8
		private float m_lastTime; // 0xB0
		private static readonly RenderFunc<SludgePassData> s_sludgeFunc; // 0x18
		private static readonly RenderFunc<SludgePassDataV2> s_dynamicSludgeBlitFunc; // 0x20
		private static readonly RenderFunc<SludgePassDataV2> s_defaultBlitFunc; // 0x28
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38422
		{
			// Fields
			internal DepthBits depthBits; // 0x00
			internal GraphicsFormat depthFormat; // 0x04
		}
	
		internal struct PassOutput // TypeDefIndex: 38423
		{
		}
	
		internal class SludgePassData // TypeDefIndex: 38424
		{
			// Fields
			internal TextureHandle curSludgeTexture; // 0x10
			internal TextureHandle prevSludgeTexture; // 0x20
			internal Material sludgeBlitMaterial; // 0x30
			internal Mesh quadMesh; // 0x38
			internal MaterialPropertyBlock tempMaterialPropertyBlock; // 0x40
			internal float lastTime; // 0x48
			internal float curTime; // 0x4C
			internal List<HGDynamicSludgePassData> hgDynamicSludges; // 0x50
	
			// Constructors
			public SludgePassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		internal class SludgePassDataV2 // TypeDefIndex: 38425
		{
			// Fields
			internal int viewHandle; // 0x10
			internal TextureHandle prevSludgeThicknessTexture; // 0x14
			internal TextureHandle prevSludgeMinHeightTexture; // 0x24
			internal TextureHandle curSludgeThicknessTexture; // 0x34
			internal TextureHandle curSludgeMinHeightTexture; // 0x44
			internal Material blitMaterial; // 0x58
	
			// Constructors
			public SludgePassDataV2() {} // 0x00000001841E1670-0x00000001841E1680
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
		public SludgePassConstructor() {} // Dummy constructor
		internal SludgePassConstructor(HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000182EDB850-0x0000000182EDB920
		// SludgePassConstructor(HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::SludgePassConstructor::SludgePassConstructor(
		        SludgePassConstructor *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  __int64 v6; // rcx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  TextureHandle v9; // xmm0
		  HGRenderPipelineRuntimeResources *defaultResources; // rax
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  HGRuntimeGrassQuery_Node *v12; // r8
		  HGRenderPipelineRuntimeResources *v13; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *v14; // rax
		  TextureHandle v15; // [rsp+20h] [rbp-18h] BYREF
		  MethodInfo *v16; // [rsp+60h] [rbp+28h]
		
		  if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  this->fields.m_prevSludgeTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v15, 0LL);
		  this->fields.m_prevSludgeThickness = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v15, 0LL);
		  v9 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v15, 0LL);
		  defaultResources = resources->defaultResources;
		  this->fields.m_prevSludgeMinHeight = v9;
		  if ( !defaultResources
		    || (shaders = defaultResources->fields.shaders) == 0LL
		    || (this->fields.m_sludgeBlitShader = shaders->fields.sludgeBlitPS,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&this->fields.m_sludgeBlitShader,
		          v5,
		          v7,
		          v8,
		          *(MethodInfo **)&v15.handle),
		        (v13 = resources->defaultResources) == 0LL)
		    || (v14 = v13->fields.shaders) == 0LL )
		  {
		    sub_1800D8260(v6, v5);
		  }
		  this->fields.m_sludgeBlitShaderV2 = v14->fields.sludgePS;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_sludgeBlitShaderV2, v5, v12, (Int32__Array **)v13, v16);
		}
		
		static SludgePassConstructor() {} // 0x00000001849E2EE0-0x00000001849E3100
		// SludgePassConstructor()
		void HG::Rendering::Runtime::SludgePassConstructor::cctor(MethodInfo *method)
		{
		  struct SludgePassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_SludgePassConstructor_SludgePassData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  Object *v10; // rdi
		  RenderFunc_1_System_Object_ *v11; // rax
		  RenderFunc_1_HG_Rendering_Runtime_SludgePassConstructor_SludgePassDataV2_ *v12; // rbx
		  SludgePassConstructor__StaticFields *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  Object *v16; // rdi
		  RenderFunc_1_System_Object_ *v17; // rax
		  HGRuntimeGrassQuery_Node *v18; // rbx
		  HGRuntimeGrassQuery_Node *v19; // rdx
		  HGRuntimeGrassQuery_Node *v20; // r8
		  Int32__Array **v21; // r9
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		  MethodInfo *v23; // [rsp+20h] [rbp-8h]
		  MethodInfo *v24; // [rsp+50h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::SludgePassConstructor->static_fields->_Hit = UnityEngine::Shader::PropertyToID(
		                                                                                   (String *)"_Hit",
		                                                                                   0LL);
		  TypeInfo::HG::Rendering::Runtime::SludgePassConstructor->static_fields->_HitRange = UnityEngine::Shader::PropertyToID(
		                                                                                        (String *)"_HitRange",
		                                                                                        0LL);
		  TypeInfo::HG::Rendering::Runtime::SludgePassConstructor->static_fields->_HitPosition = UnityEngine::Shader::PropertyToID(
		                                                                                           (String *)"_HitPosition",
		                                                                                           0LL);
		  TypeInfo::HG::Rendering::Runtime::SludgePassConstructor->static_fields->_DeltaTime = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_DeltaTime",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::SludgePassConstructor->static_fields->_TotalTime = UnityEngine::Shader::PropertyToID(
		                                                                                         (String *)"_TotalTime",
		                                                                                         0LL);
		  TypeInfo::HG::Rendering::Runtime::SludgePassConstructor->static_fields->_AtlasTillingOffset = UnityEngine::Shader::PropertyToID(
		                                                                                                  (String *)"_AtlasTillingOffset",
		                                                                                                  0LL);
		  v1 = TypeInfo::HG::Rendering::Runtime::SludgePassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::SludgePassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::SludgePassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::SludgePassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::SludgePassConstructor::SludgePassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_SludgePassConstructor_SludgePassData_ *)v3;
		  if ( !v3 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::SludgePassConstructor::__c::__cctor_b__38_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::SludgePassConstructor->static_fields->s_sludgeFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::SludgePassConstructor->static_fields->s_sludgeFunc,
		    v7,
		    v8,
		    v9,
		    v22);
		  v10 = (Object *)TypeInfo::HG::Rendering::Runtime::SludgePassConstructor::__c->static_fields->__9;
		  v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::SludgePassConstructor::SludgePassDataV2>);
		  v12 = (RenderFunc_1_HG_Rendering_Runtime_SludgePassConstructor_SludgePassDataV2_ *)v11;
		  if ( !v11
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v11,
		          v10,
		          MethodInfo::HG::Rendering::Runtime::SludgePassConstructor::__c::__cctor_b__38_1,
		          0LL),
		        static_fields = TypeInfo::HG::Rendering::Runtime::SludgePassConstructor->static_fields,
		        static_fields->s_dynamicSludgeBlitFunc = v12,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::SludgePassConstructor->static_fields->s_dynamicSludgeBlitFunc,
		          (HGRuntimeGrassQuery_Node *)static_fields,
		          v14,
		          v15,
		          v23),
		        v16 = (Object *)TypeInfo::HG::Rendering::Runtime::SludgePassConstructor::__c->static_fields->__9,
		        v17 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::SludgePassConstructor::SludgePassDataV2>),
		        (v18 = (HGRuntimeGrassQuery_Node *)v17) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v17,
		    v16,
		    MethodInfo::HG::Rendering::Runtime::SludgePassConstructor::__c::__cctor_b__38_2,
		    0LL);
		  v19 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::SludgePassConstructor->static_fields;
		  v19->fields.parent = v18;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::SludgePassConstructor->static_fields->s_defaultBlitFunc,
		    v19,
		    v20,
		    v21,
		    v24);
		}
		
	
		// Methods
		private void CreateSludgeResourceIfNotInted(HGRenderPipelineMaterialCollector materialCollector) {} // 0x0000000189BD10B0-0x0000000189BD1354
		// Void CreateSludgeResourceIfNotInted(HGRenderPipelineMaterialCollector)
		void HG::Rendering::Runtime::SludgePassConstructor::CreateSludgeResourceIfNotInted(
		        SludgePassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        MethodInfo *method)
		{
		  Object_1 *m_sludgeBlitMaterial; // rbx
		  Byte__Array *v6; // rdx
		  Texture2D *m_defaultThicknessMap; // rcx
		  Object_1 *m_sludgeBlitMaterialV2; // rbx
		  Object_1 *v9; // rbx
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  MaterialPropertyBlock *v13; // rbx
		  HGRuntimeGrassQuery_Node *v14; // rdx
		  HGRuntimeGrassQuery_Node *v15; // r8
		  Int32__Array **v16; // r9
		  HGRuntimeGrassQuery_Node *v17; // rdx
		  HGRuntimeGrassQuery_Node *v18; // r8
		  Int32__Array **v19; // r9
		  Texture2D *v20; // rax
		  Texture2D *v21; // rbx
		  HGRuntimeGrassQuery_Node *v22; // rdx
		  HGRuntimeGrassQuery_Node *v23; // r8
		  Int32__Array **v24; // r9
		  __int64 v25; // rax
		  __int64 v26; // rax
		  __int64 v27; // rax
		  Texture *v28; // rbx
		  HGRuntimeGrassQuery_Node *v29; // rdx
		  HGRuntimeGrassQuery_Node *v30; // r8
		  Int32__Array **v31; // r9
		  Texture *whiteTexture; // rax
		  HGRuntimeGrassQuery_Node *v33; // rdx
		  HGRuntimeGrassQuery_Node *v34; // r8
		  Int32__Array **v35; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *mipCount; // [rsp+20h] [rbp-28h]
		  MethodInfo *mipCounta; // [rsp+20h] [rbp-28h]
		  MethodInfo *mipCountc; // [rsp+20h] [rbp-28h]
		  MethodInfo *mipCountd; // [rsp+20h] [rbp-28h]
		  MethodInfo *mipCountb; // [rsp+20h] [rbp-28h]
		  MethodInfo *mipCounte; // [rsp+20h] [rbp-28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3341, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3341, 0LL);
		    if ( !Patch )
		      goto LABEL_19;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)materialCollector,
		      0LL);
		  }
		  else
		  {
		    m_sludgeBlitMaterial = (Object_1 *)this->fields.m_sludgeBlitMaterial;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Implicit(m_sludgeBlitMaterial, 0LL)
		      || (m_sludgeBlitMaterialV2 = (Object_1 *)this->fields.m_sludgeBlitMaterialV2,
		          sub_1800036A0(TypeInfo::UnityEngine::Object),
		          !UnityEngine::Object::op_Implicit(m_sludgeBlitMaterialV2, 0LL))
		      || (v9 = (Object_1 *)this->fields.m_defaultThicknessMap,
		          sub_1800036A0(TypeInfo::UnityEngine::Object),
		          !UnityEngine::Object::op_Implicit(v9, 0LL)) )
		    {
		      if ( materialCollector )
		      {
		        this->fields.m_sludgeBlitMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                              materialCollector,
		                                              this->fields.m_sludgeBlitShader,
		                                              1,
		                                              0LL);
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_sludgeBlitMaterial, v10, v11, v12, mipCount);
		        v13 = (MaterialPropertyBlock *)sub_18002C620(TypeInfo::UnityEngine::MaterialPropertyBlock);
		        if ( v13 )
		        {
		          v13->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		          this->fields.m_sludgeBlitPropertyBlock = v13;
		          sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_sludgeBlitPropertyBlock, v14, v15, v16, mipCounta);
		          this->fields.m_sludgeBlitMaterialV2 = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                                  materialCollector,
		                                                  this->fields.m_sludgeBlitShaderV2,
		                                                  1,
		                                                  0LL);
		          sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_sludgeBlitMaterialV2, v17, v18, v19, mipCountc);
		          v20 = (Texture2D *)sub_18002C620(TypeInfo::UnityEngine::Texture2D);
		          v21 = v20;
		          if ( v20 )
		          {
		            UnityEngine::Texture2D::Texture2D(
		              v20,
		              4,
		              4,
		              GraphicsFormat__Enum_R8G8B8A8_UNorm,
		              1,
		              TextureCreationFlags__Enum_None,
		              0LL);
		            this->fields.m_defaultThicknessMap = v21;
		            sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_defaultThicknessMap, v22, v23, v24, mipCountd);
		            v6 = (Byte__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Byte, 64LL);
		            m_defaultThicknessMap = 0LL;
		            if ( v6 )
		            {
		              do
		              {
		                if ( (unsigned int)m_defaultThicknessMap >= v6->max_length.size
		                  || (v6->vector[(int)m_defaultThicknessMap] = 127,
		                      v25 = (int)m_defaultThicknessMap + 1LL,
		                      (unsigned int)v25 >= v6->max_length.size)
		                  || (v6->vector[v25] = 127,
		                      v26 = (int)m_defaultThicknessMap + 2LL,
		                      (unsigned int)v26 >= v6->max_length.size)
		                  || (v6->vector[v26] = -1,
		                      v27 = (int)m_defaultThicknessMap + 3LL,
		                      (unsigned int)v27 >= v6->max_length.size) )
		                {
		                  sub_1800D2AB0(m_defaultThicknessMap, v6);
		                }
		                m_defaultThicknessMap = (Texture2D *)(unsigned int)((_DWORD)m_defaultThicknessMap + 4);
		                v6->vector[v27] = -1;
		              }
		              while ( (int)m_defaultThicknessMap < 64 );
		              m_defaultThicknessMap = this->fields.m_defaultThicknessMap;
		              if ( m_defaultThicknessMap )
		              {
		                UnityEngine::Texture2D::SetPixelData<unsigned char>(
		                  m_defaultThicknessMap,
		                  v6,
		                  0,
		                  0,
		                  MethodInfo::UnityEngine::Texture2D::SetPixelData<unsigned char>);
		                m_defaultThicknessMap = this->fields.m_defaultThicknessMap;
		                if ( m_defaultThicknessMap )
		                {
		                  UnityEngine::Texture2D::Apply(m_defaultThicknessMap, 0LL);
		                  v28 = (Texture *)this->fields.m_defaultThicknessMap;
		                  sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		                  this->fields.m_defaultThicknessMapRTHandle = UnityEngine::Rendering::RTHandleSystem::Alloc(v28, 0LL);
		                  sub_18002D1B0(
		                    (HGRuntimeGrassQuery_Node *)&this->fields.m_defaultThicknessMapRTHandle,
		                    v29,
		                    v30,
		                    v31,
		                    mipCountb);
		                  whiteTexture = (Texture *)UnityEngine::Texture2D::get_whiteTexture(0LL);
		                  this->fields.m_defaultMinHeightRTHandle = UnityEngine::Rendering::RTHandleSystem::Alloc(
		                                                              whiteTexture,
		                                                              0LL);
		                  sub_18002D1B0(
		                    (HGRuntimeGrassQuery_Node *)&this->fields.m_defaultMinHeightRTHandle,
		                    v33,
		                    v34,
		                    v35,
		                    mipCounte);
		                  return;
		                }
		              }
		            }
		          }
		        }
		      }
		LABEL_19:
		      sub_1800D8260(m_defaultThicknessMap, v6);
		    }
		  }
		}
		
		public float GetCurrentTime() => default; // 0x0000000189BD1354-0x0000000189BD13B0
		// Single GetCurrentTime()
		float HG::Rendering::Runtime::SludgePassConstructor::GetCurrentTime(SludgePassConstructor *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3342, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3342, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		    return HG::Rendering::Runtime::HGRPTimeManager::get_gameplayTime(0LL);
		  }
		}
		
		private void PrepareSludgePassData(HGCamera hgCamera, ref SludgePassData passData) {} // 0x0000000189BD14AC-0x0000000189BD16D0
		// Void PrepareSludgePassData(HGCamera, SludgePassConstructor+SludgePassData ByRef)
		void HG::Rendering::Runtime::SludgePassConstructor::PrepareSludgePassData(
		        SludgePassConstructor *this,
		        HGCamera *hgCamera,
		        SludgePassConstructor_SludgePassData **passData,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  SludgePassConstructor_SludgePassData *sludgeManager_k__BackingField; // rcx
		  HGRuntimeGrassQuery_Node *v9; // r8
		  Int32__Array **v10; // r9
		  SludgePassConstructor_SludgePassData *v11; // rsi
		  HGManagerContext *currentManagerContext; // rax
		  Mesh *PlaneMesh; // rax
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  SludgePassConstructor_SludgePassData *v18; // rbp
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v19; // rax
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v20; // rsi
		  HGRuntimeGrassQuery_Node *v21; // rdx
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  HGManagerContext *v24; // rax
		  char v25; // dl
		  __int64 v26; // rcx
		  int v27; // r8d
		  int v28; // eax
		  float v29; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v31; // [rsp+20h] [rbp-18h]
		  MethodInfo *v32; // [rsp+20h] [rbp-18h]
		  MethodInfo *v33; // [rsp+20h] [rbp-18h]
		  MethodInfo *v34; // [rsp+20h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3343, 0LL) )
		  {
		    if ( *passData )
		    {
		      (*passData)->fields.curSludgeTexture = this->fields.m_curSludgeTexture;
		      if ( *passData )
		      {
		        (*passData)->fields.prevSludgeTexture = this->fields.m_prevSludgeTexture;
		        sludgeManager_k__BackingField = *passData;
		        if ( *passData )
		        {
		          sludgeManager_k__BackingField->fields.sludgeBlitMaterial = this->fields.m_sludgeBlitMaterial;
		          sub_18002D1B0(
		            (HGRuntimeGrassQuery_Node *)&sludgeManager_k__BackingField->fields.sludgeBlitMaterial,
		            v7,
		            v9,
		            v10,
		            v31);
		          v11 = *passData;
		          currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		          if ( currentManagerContext )
		          {
		            sludgeManager_k__BackingField = (SludgePassConstructor_SludgePassData *)currentManagerContext->fields._sludgeManager_k__BackingField;
		            if ( sludgeManager_k__BackingField )
		            {
		              PlaneMesh = HG::Rendering::Runtime::HGSludgeManager::GetPlaneMesh(
		                            (HGSludgeManager *)sludgeManager_k__BackingField,
		                            0LL);
		              if ( v11 )
		              {
		                v11->fields.quadMesh = PlaneMesh;
		                sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v11->fields.quadMesh, v7, v14, v15, v32);
		                sludgeManager_k__BackingField = *passData;
		                if ( *passData )
		                {
		                  sludgeManager_k__BackingField->fields.tempMaterialPropertyBlock = this->fields.m_sludgeBlitPropertyBlock;
		                  sub_18002D1B0(
		                    (HGRuntimeGrassQuery_Node *)&sludgeManager_k__BackingField->fields.tempMaterialPropertyBlock,
		                    v7,
		                    v16,
		                    v17,
		                    v33);
		                  if ( this->fields.m_lastTime == 0.0 )
		                    this->fields.m_lastTime = HG::Rendering::Runtime::SludgePassConstructor::GetCurrentTime(this, 0LL);
		                  if ( *passData )
		                  {
		                    if ( !(*passData)->fields.hgDynamicSludges )
		                    {
		                      v18 = *passData;
		                      v19 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Sludge::HGDynamicSludgePassData>);
		                      v20 = v19;
		                      if ( !v19 )
		                        goto LABEL_22;
		                      System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		                        v19,
		                        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::Sludge::HGDynamicSludgePassData>::List);
		                      v18->fields.hgDynamicSludges = (List_1_HG_Rendering_Runtime_Sludge_HGDynamicSludgePassData_ *)v20;
		                      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v18->fields.hgDynamicSludges, v21, v22, v23, v34);
		                    }
		                    v24 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		                    if ( v24 )
		                    {
		                      sludgeManager_k__BackingField = (SludgePassConstructor_SludgePassData *)v24->fields._sludgeManager_k__BackingField;
		                      if ( *passData )
		                      {
		                        if ( sludgeManager_k__BackingField )
		                        {
		                          HG::Rendering::Runtime::HGSludgeManager::GetActiveDynamicSludgePassData(
		                            (HGSludgeManager *)sludgeManager_k__BackingField,
		                            (*passData)->fields.hgDynamicSludges,
		                            this->fields.m_lastTime,
		                            0LL);
		                          HG::Rendering::Runtime::SludgePassConstructor::GetCurrentTime(this, 0LL);
		                          v28 = sub_1834464B0(v26, v25, v27);
		                          sludgeManager_k__BackingField = *passData;
		                          if ( *passData )
		                          {
		                            sludgeManager_k__BackingField->fields.lastTime = this->fields.m_lastTime;
		                            v29 = (float)((float)v28 * 0.033) + this->fields.m_lastTime;
		                            this->fields.m_lastTime = v29;
		                            if ( *passData )
		                            {
		                              (*passData)->fields.curTime = v29;
		                              return;
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_22:
		    sub_1800D8260(sludgeManager_k__BackingField, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3343, 0LL);
		  if ( !Patch )
		    goto LABEL_22;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1225(Patch, (Object *)this, (Object *)hgCamera, passData, 0LL);
		}
		
		private void PrepareSludgeTexture(HGRenderGraph renderGraph) {} // 0x0000000189BD16D0-0x0000000189BD1860
		// Void PrepareSludgeTexture(HGRenderGraph)
		void HG::Rendering::Runtime::SludgePassConstructor::PrepareSludgeTexture(
		        SludgePassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  HGSludgeManager *sludgeManager_k__BackingField; // rdx
		  __int64 v7; // rcx
		  HGSludgeConfig *Config; // rax
		  int32_t graphicsFormat; // esi
		  HGRenderGraphDefaultResources *defaultResources; // rax
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  MethodInfo *v14; // rdx
		  Color v15; // xmm2
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *width; // [rsp+28h] [rbp-89h]
		  Vector4 v18; // [rsp+38h] [rbp-79h] BYREF
		  TextureDesc v19; // [rsp+48h] [rbp-69h] BYREF
		  TextureDesc v20; // [rsp+A8h] [rbp-9h] BYREF
		
		  sub_18033B9D0(&v19, 0LL, 96LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(3344, 0LL) )
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      sludgeManager_k__BackingField = currentManagerContext->fields._sludgeManager_k__BackingField;
		      if ( sludgeManager_k__BackingField )
		      {
		        Config = HG::Rendering::Runtime::HGSludgeManager::GetConfig(
		                   (HGSludgeConfig *)&v18,
		                   sludgeManager_k__BackingField,
		                   0LL);
		        graphicsFormat = Config->graphicsFormat;
		        width = (MethodInfo *)Config->textureSize;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_prevSludgeTexture, 0LL) )
		        {
		          if ( !renderGraph )
		            goto LABEL_11;
		          defaultResources = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(renderGraph, 0LL);
		          if ( !defaultResources )
		            goto LABEL_11;
		          this->fields.m_prevSludgeTexture = defaultResources->fields._whiteTexture_k__BackingField;
		        }
		        HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v19, (int32_t)width, SHIDWORD(width), 0LL);
		        *(_WORD *)&v19.enableRandomWrite = 0;
		        v19.name = (String *)"curSludgeTexture";
		        v19.colorFormat = graphicsFormat;
		        v19.autoGenerateMips = 0;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v19.name, v11, v12, v13, width);
		        v15 = (Color)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::get_one(&v18, v14));
		        *(_OWORD *)&v20.width = *(_OWORD *)&v19.width;
		        *(_OWORD *)&v20.enableRandomWrite = *(_OWORD *)&v19.enableRandomWrite;
		        *(_OWORD *)&v20.colorFormat = *(_OWORD *)&v19.colorFormat;
		        *(_OWORD *)&v20.fastMemoryDesc.inFastMemory = *(_OWORD *)&v19.fastMemoryDesc.inFastMemory;
		        v19.clearColor = v15;
		        *(_OWORD *)&v20.bindTextureMS = *(_OWORD *)&v19.bindTextureMS;
		        v20.clearColor = v15;
		        if ( renderGraph )
		        {
		          this->fields.m_curSludgeTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                               (TextureHandle *)&v18,
		                                               renderGraph,
		                                               &v20,
		                                               0LL);
		          return;
		        }
		      }
		    }
		LABEL_11:
		    sub_1800D8260(v7, sludgeManager_k__BackingField);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3344, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)renderGraph,
		    0LL);
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BD1458-0x0000000189BD14AC
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::SludgePassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        SludgePassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3346, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3346, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BD1404-0x0000000189BD1458
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::SludgePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        SludgePassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3347, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3347, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BD04D0-0x0000000189BD10B0
		// Void ConstructPass(SludgePassConstructor+PassInput ByRef, SludgePassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=3
		void HG::Rendering::Runtime::SludgePassConstructor::ConstructPass(
		        SludgePassConstructor *this,
		        SludgePassConstructor_PassInput *input,
		        SludgePassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  HGRenderGraph *v6; // rsi
		  SludgePassConstructor *v9; // rdi
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  HGCamera *v12; // r15
		  HGRenderPipelineMaterialCollector *MaterialCollector; // rax
		  ProfilingSampler *v14; // rax
		  __int64 v15; // rdx
		  HGSludgeManager *sludgeManager_k__BackingField; // rcx
		  Object *v17; // r14
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  TextureHandle v20; // xmm0
		  ProfilingSampler *v21; // rax
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  __int64 v24; // r14
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  TextureHandle v27; // xmm0
		  __int64 v28; // r14
		  __int64 v29; // rdx
		  __int64 v30; // rcx
		  TextureHandle v31; // xmm0
		  float v32; // r12d
		  __int128 v33; // xmm3
		  __int128 v34; // xmm4
		  unsigned __int64 v35; // r8
		  signed __int64 v36; // rtt
		  unsigned int depthBits; // r13d
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  __int64 v40; // rdx
		  unsigned int v41; // edx
		  unsigned __int64 v42; // r8
		  signed __int64 v43; // rtt
		  __int64 v44; // r14
		  Object_1 *v45; // rcx
		  int32_t InstanceID; // eax
		  __int64 v47; // rdx
		  __int64 v48; // rcx
		  TextureHandle *v49; // r8
		  TextureHandle *p_m_curSludgeThickness; // r8
		  HGManagerContext *currentManagerContext; // rax
		  ProfilingSampler *v52; // rax
		  __int64 v53; // rdx
		  __int64 v54; // rcx
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v58; // rdx
		  __int64 v59; // rcx
		  unsigned int depthFormat; // [rsp+50h] [rbp-248h]
		  __int64 v61; // [rsp+58h] [rbp-240h] BYREF
		  __m128i si128; // [rsp+60h] [rbp-238h] BYREF
		  TextureHandle v63; // [rsp+70h] [rbp-228h] BYREF
		  TextureHandle v64; // [rsp+80h] [rbp-218h] BYREF
		  SludgePassConstructor_SludgePassData *passData; // [rsp+90h] [rbp-208h] BYREF
		  HGRenderGraphBuilder v66; // [rsp+98h] [rbp-200h] BYREF
		  Object *v67; // [rsp+B8h] [rbp-1E0h] BYREF
		  HGRenderGraphBuilder v68; // [rsp+C0h] [rbp-1D8h] BYREF
		  HGRenderGraphBuilder v69; // [rsp+E0h] [rbp-1B8h] BYREF
		  HGRenderGraphBuilder v70; // [rsp+100h] [rbp-198h] BYREF
		  __int128 v71; // [rsp+120h] [rbp-178h] BYREF
		  __int128 v72; // [rsp+130h] [rbp-168h]
		  __int128 v73; // [rsp+140h] [rbp-158h]
		  __int128 v74; // [rsp+150h] [rbp-148h] BYREF
		  __int128 v75; // [rsp+160h] [rbp-138h]
		  __m128i clearColor; // [rsp+170h] [rbp-128h]
		  Il2CppExceptionWrapper *v77; // [rsp+180h] [rbp-118h] BYREF
		  Il2CppExceptionWrapper *v78; // [rsp+188h] [rbp-110h] BYREF
		  Il2CppExceptionWrapper *v79; // [rsp+190h] [rbp-108h] BYREF
		  TextureDesc v80; // [rsp+1A0h] [rbp-F8h] BYREF
		  TextureDesc v81; // [rsp+200h] [rbp-98h] BYREF
		
		  v6 = renderGraph;
		  v9 = this;
		  memset(&v68, 0, sizeof(v68));
		  v61 = 0LL;
		  sub_18033B9D0(&v80, 0LL, 96LL);
		  sub_18033B9D0(&v71, 0LL, 96LL);
		  memset(&v70, 0, sizeof(v70));
		  v67 = 0LL;
		  memset(&v69, 0, sizeof(v69));
		  passData = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3348, 0LL) )
		  {
		    v12 = camera;
		    if ( !camera )
		      sub_1800D8260(v11, v10);
		    MaterialCollector = HG::Rendering::Runtime::HGCamera::get_MaterialCollector(camera, 0LL);
		    HG::Rendering::Runtime::SludgePassConstructor::CreateSludgeResourceIfNotInted(v9, MaterialCollector, 0LL);
		    if ( !UnityEngine::HyperGryph::HGSludgeRender::ShouldDrawThicknessMap(0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      v9->fields.m_prevSludgeThickness = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v63, 0LL);
		      v9->fields.m_prevSludgeMinHeight = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v63, 0LL);
		      v14 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x77u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !v6 )
		        goto LABEL_56;
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v66,
		        v6,
		        (String *)"SludgeBlitSetDefault",
		        &v67,
		        v14,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::SludgePassConstructor::SludgePassDataV2>);
		      v70 = v66;
		      si128.m128i_i64[0] = 0LL;
		      si128.m128i_i64[1] = (__int64)&v70;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v70, 0, 0LL);
		        v17 = v67;
		        v64 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                 &v63,
		                 v6,
		                 v9->fields.m_defaultThicknessMapRTHandle,
		                 0LL);
		        v20 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v63, &v70, &v64, 0LL);
		        if ( !v17 )
		          sub_1800D8250(v19, v18);
		        *(TextureHandle *)((char *)&v17[3] + 4) = v20;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v70,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::SludgePassConstructor->static_fields->s_defaultBlitFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::SludgePassConstructor::SludgePassDataV2>);
		      }
		      catch ( Il2CppExceptionWrapper *v77 )
		      {
		        *(Il2CppExceptionWrapper *)si128.m128i_i8 = (Il2CppExceptionWrapper)v77->ex;
		        sub_180268AE0(&si128);
		        v12 = camera;
		        v6 = renderGraph;
		        v9 = this;
		        goto LABEL_32;
		      }
		      sub_180268AE0(&si128);
		      goto LABEL_32;
		    }
		    v21 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x77u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !v6 )
		      sub_1800D8260(v23, v22);
		    v68 = *(HGRenderGraphBuilder *)sub_1808AFA14(
		                                     (unsigned int)&v66,
		                                     (_DWORD)v6,
		                                     (unsigned int)"RenderSludge",
		                                     (unsigned int)&v61,
		                                     (__int64)v21);
		    v64.handle = 0LL;
		    v64.fallBackResource = (ResourceHandle)&v68;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v68, 0, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v9->fields.m_prevSludgeThickness, 0LL) )
		      {
		        v9->fields.m_prevSludgeThickness = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                              &v63,
		                                              v6,
		                                              v9->fields.m_defaultThicknessMapRTHandle,
		                                              0LL);
		        v9->fields.m_prevSludgeMinHeight = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                              &v63,
		                                              v6,
		                                              v9->fields.m_defaultMinHeightRTHandle,
		                                              0LL);
		      }
		      v24 = v61;
		      v27 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               &v63,
		               &v68,
		               &v9->fields.m_prevSludgeThickness,
		               0LL);
		      if ( !v24 )
		        sub_1800D8250(v26, v25);
		      *(TextureHandle *)(v24 + 20) = v27;
		      v28 = v61;
		      v31 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               &v63,
		               &v68,
		               &v9->fields.m_prevSludgeMinHeight,
		               0LL);
		      if ( !v28 )
		        sub_1800D8250(v30, v29);
		      *(TextureHandle *)(v28 + 36) = v31;
		      v32 = COERCE_FLOAT(UnityEngine::HyperGryph::HGSludgeRender::GetDynamicThicknessMapSize(0LL));
		      sub_18033B9D0(&v81, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v81, SLODWORD(v32), SLODWORD(v32), 0LL);
		      v33 = *(_OWORD *)&v81.width;
		      v71 = *(_OWORD *)&v81.width;
		      v72 = *(_OWORD *)&v81.colorFormat;
		      v73 = *(_OWORD *)&v81.enableRandomWrite;
		      *(_QWORD *)&v74 = *(_QWORD *)&v81.bindTextureMS;
		      v34 = *(_OWORD *)&v81.fastMemoryDesc.inFastMemory;
		      v75 = *(_OWORD *)&v81.fastMemoryDesc.inFastMemory;
		      clearColor = (__m128i)v81.clearColor;
		      LODWORD(v72) = 8;
		      LOWORD(v73) = 0;
		      BYTE2(v73) = 0;
		      *((_QWORD *)&v74 + 1) = "curSludgeTexture";
		      if ( dword_18F35FD08 )
		      {
		        v35 = ((((unsigned __int64)&v74 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v35 + 36190]);
		        do
		          v36 = qword_18F0BCBA0[v35 + 36190];
		        while ( v36 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v35 + 36190],
		                         v36 | (1LL << ((((unsigned __int64)&v74 + 8) >> 12) & 0x3F)),
		                         v36) );
		        v34 = v75;
		        v33 = v71;
		      }
		      clearColor = _mm_load_si128((const __m128i *)&xmmword_18B959780);
		      *(_OWORD *)&v80.width = v33;
		      *(_OWORD *)&v80.colorFormat = v72;
		      *(_OWORD *)&v80.enableRandomWrite = v73;
		      *(_OWORD *)&v80.bindTextureMS = v74;
		      *(_OWORD *)&v80.fastMemoryDesc.inFastMemory = v34;
		      v80.clearColor = (Color)clearColor;
		      v9->fields.m_curSludgeThickness = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                           &v63,
		                                           v6,
		                                           &v80,
		                                           0LL);
		      v80.colorFormat = 5;
		      v9->fields.m_curSludgeMinHeight = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                           &v63,
		                                           v6,
		                                           &v80,
		                                           0LL);
		      depthBits = input->depthBits;
		      depthFormat = input->depthFormat;
		      *(float *)si128.m128i_i32 = v32;
		      *(float *)&si128.m128i_i32[1] = v32;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		      v63 = *HG::Rendering::Runtime::HGRenderPipeline::CreateDepthBuffer(
		               &v63,
		               v6,
		               0,
		               MSAASamples__Enum_None,
		               (DepthBits__Enum)depthBits,
		               (GraphicsFormat__Enum)depthFormat,
		               *(Vector2Int *)si128.m128i_i8,
		               0LL);
		      if ( !v61 )
		        sub_1800D8250(v39, v38);
		      *(TextureHandle *)(v61 + 52) = v9->fields.m_curSludgeThickness;
		      if ( !v61 )
		        sub_1800D8250(v39, v38);
		      *(TextureHandle *)(v61 + 68) = v9->fields.m_curSludgeMinHeight;
		      v40 = v61;
		      if ( !v61 )
		        sub_1800D8250(v39, 0LL);
		      *(_QWORD *)(v61 + 88) = v9->fields.m_sludgeBlitMaterialV2;
		      if ( dword_18F35FD08 )
		      {
		        v41 = ((unsigned __int64)(v40 + 88) >> 12) & 0x1FFFFF;
		        v42 = (unsigned __int64)v41 >> 6;
		        v40 = v41 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v42 + 36190]);
		        do
		          v43 = qword_18F0BCBA0[v42 + 36190];
		        while ( v43 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v42 + 36190], v43 | (1LL << v40), v43) );
		      }
		      v44 = v61;
		      v45 = (Object_1 *)camera->fields.camera;
		      if ( !v45 )
		        sub_1800D8250(0LL, v40);
		      InstanceID = UnityEngine::Object::GetInstanceID(v45, 0LL);
		      if ( !v44 )
		        sub_1800D8250(v48, v47);
		      *(_DWORD *)(v44 + 16) = InstanceID;
		      si128 = *(__m128i *)sub_183523A50(&si128, 4294934399LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        (TextureHandle *)&v66,
		        &v68,
		        v49,
		        0,
		        RenderBufferLoadAction__Enum_DontCare,
		        RenderBufferStoreAction__Enum_Store,
		        (Color *)&si128,
		        0,
		        0LL);
		      si128 = _mm_load_si128((const __m128i *)&xmmword_18B959780);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        (TextureHandle *)&v66,
		        &v68,
		        &v9->fields.m_curSludgeMinHeight,
		        1,
		        RenderBufferLoadAction__Enum_DontCare,
		        RenderBufferStoreAction__Enum_Store,
		        (Color *)&si128,
		        0,
		        0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		        (TextureHandle *)&v66,
		        &v68,
		        &v63,
		        DepthAccess__Enum_Write,
		        RenderBufferLoadAction__Enum_DontCare,
		        RenderBufferStoreAction__Enum_DontCare,
		        0.0,
		        0,
		        0,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v68,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::SludgePassConstructor->static_fields->s_dynamicSludgeBlitFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::SludgePassConstructor::SludgePassDataV2>);
		    }
		    catch ( Il2CppExceptionWrapper *v78 )
		    {
		      v64.handle = (ResourceHandle)v78->ex;
		      sub_180268AE0(&v64);
		      v9 = this;
		      p_m_curSludgeThickness = &this->fields.m_curSludgeThickness;
		      v6 = renderGraph;
		      if ( !renderGraph )
		        goto LABEL_56;
		      v12 = camera;
		      goto LABEL_31;
		    }
		    sub_180268AE0(&v64);
		    p_m_curSludgeThickness = &v9->fields.m_curSludgeThickness;
		LABEL_31:
		    v9->fields.m_prevSludgeThickness = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                                          (TextureHandle *)&v66,
		                                          v6,
		                                          p_m_curSludgeThickness,
		                                          1,
		                                          (String *)"prevSludgeThickness",
		                                          0LL);
		    v9->fields.m_prevSludgeMinHeight = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                                          (TextureHandle *)&v66,
		                                          v6,
		                                          &v9->fields.m_curSludgeMinHeight,
		                                          1,
		                                          (String *)"prevSludgeMinHeight",
		                                          0LL);
		LABEL_32:
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      sludgeManager_k__BackingField = currentManagerContext->fields._sludgeManager_k__BackingField;
		      if ( sludgeManager_k__BackingField )
		      {
		        if ( HG::Rendering::Runtime::HGSludgeManager::HasActiveSludge(sludgeManager_k__BackingField, 0LL) )
		        {
		          HG::Rendering::Runtime::SludgePassConstructor::PrepareSludgeTexture(v9, v6, 0LL);
		          v52 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                  (Int32Enum__Enum)0x77u,
		                  MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		          HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		            &v66,
		            v6,
		            (String *)"RenderSludge",
		            (Object **)&passData,
		            v52,
		            1,
		            ProfilingHGPass__Enum_None,
		            MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::SludgePassConstructor::SludgePassData>);
		          v69 = v66;
		          v64.handle = 0LL;
		          v64.fallBackResource = (ResourceHandle)&v69;
		          try
		          {
		            HG::Rendering::Runtime::SludgePassConstructor::PrepareSludgePassData(v9, v12, &passData, 0LL);
		            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v69, 0, 0LL);
		            if ( !passData )
		              sub_1800D8250(v54, v53);
		            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		              (TextureHandle *)&v66,
		              &v69,
		              &passData->fields.prevSludgeTexture,
		              0LL);
		            if ( !passData )
		              sub_1800D8250(v56, v55);
		            v63 = (TextureHandle)_mm_load_si128((const __m128i *)&xmmword_18B959780);
		            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		              (TextureHandle *)&v66,
		              &v69,
		              &passData->fields.curSludgeTexture,
		              0,
		              RenderBufferLoadAction__Enum_Clear,
		              RenderBufferStoreAction__Enum_Store,
		              (Color *)&v63,
		              0,
		              0LL);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::SludgePassConstructor);
		            HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		              &v69,
		              (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::SludgePassConstructor->static_fields->s_sludgeFunc,
		              0LL,
		              0,
		              MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::SludgePassConstructor::SludgePassData>);
		          }
		          catch ( Il2CppExceptionWrapper *v79 )
		          {
		            v64.handle = (ResourceHandle)v79->ex;
		            sub_180268AE0(&v64);
		            v6 = renderGraph;
		            v9 = this;
		            goto LABEL_40;
		          }
		          sub_180268AE0(&v64);
		LABEL_40:
		          v9->fields.m_prevSludgeTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                                              (TextureHandle *)&v66,
		                                              v6,
		                                              &v9->fields.m_curSludgeTexture,
		                                              1,
		                                              (String *)"prevSludgeTexture",
		                                              0LL);
		        }
		        return;
		      }
		    }
		LABEL_56:
		    sub_1800D8250(sludgeManager_k__BackingField, v15);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3348, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v59, v58);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1226(
		    Patch,
		    (Object *)v9,
		    input,
		    output,
		    (Object *)v6,
		    (Object *)camera,
		    0LL);
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BD13B0-0x0000000189BD1404
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::SludgePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        SludgePassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3349, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3349, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184CE2670-0x0000000184CE2730
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::SludgePassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        SludgePassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  Object_1 *m_sludgeBlitMaterial; // rdi
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  MethodInfo *v24; // [rsp+20h] [rbp-8h]
		  MethodInfo *v25; // [rsp+20h] [rbp-8h]
		  MethodInfo *v26; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3350, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3350, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v23, v22);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else
		  {
		    m_sludgeBlitMaterial = (Object_1 *)this->fields.m_sludgeBlitMaterial;
		    if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    UnityEngine::Rendering::CoreUtils::Destroy(m_sludgeBlitMaterial, 0LL);
		    UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)this->fields.m_sludgeBlitMaterialV2, 0LL);
		    this->fields.m_sludgeBlitMaterial = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_sludgeBlitMaterial, v6, v7, v8, v24);
		    this->fields.m_sludgeBlitMaterialV2 = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_sludgeBlitMaterialV2, v9, v10, v11, v25);
		    if ( this->fields.m_defaultThicknessMapRTHandle )
		    {
		      UnityEngine::Rendering::RTHandle::Release(this->fields.m_defaultThicknessMapRTHandle, 0LL);
		      this->fields.m_defaultThicknessMapRTHandle = 0LL;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_defaultThicknessMapRTHandle, v15, v16, v17, v26);
		    }
		    if ( this->fields.m_defaultMinHeightRTHandle )
		    {
		      UnityEngine::Rendering::RTHandle::Release(this->fields.m_defaultMinHeightRTHandle, 0LL);
		      this->fields.m_defaultMinHeightRTHandle = 0LL;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_defaultMinHeightRTHandle, v18, v19, v20, v26);
		    }
		    this->fields.m_defaultThicknessMap = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_defaultThicknessMap, v12, v13, v14, v26);
		    if ( this->fields.m_sludgeBlitPropertyBlock )
		      UnityEngine::MaterialPropertyBlock::Clear(this->fields.m_sludgeBlitPropertyBlock, 1, 0LL);
		  }
		}
		
	}
}
