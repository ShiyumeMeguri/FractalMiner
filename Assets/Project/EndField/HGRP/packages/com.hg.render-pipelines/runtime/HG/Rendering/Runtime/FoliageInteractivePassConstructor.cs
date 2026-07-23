using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class FoliageInteractivePassConstructor : IPassConstructor // TypeDefIndex: 38263
	{
		// Fields
		internal static readonly int _LastCenterPos; // 0x00
		internal static readonly int _LastCenterSize; // 0x04
		internal static readonly int _CurCenterPos; // 0x08
		internal static readonly int _CurCenterSize; // 0x0C
		internal static readonly int _DeltaTime; // 0x10
		internal static readonly int _RaiseSpeed; // 0x14
		internal static readonly int _PerInstanceData; // 0x18
		private RTHandle m_defaultDualHeightTexture; // 0x10
		private TextureHandle m_curDualHeightTexture; // 0x18
		private TextureHandle m_prevDualHeightTexture; // 0x28
		private MaterialPropertyBlock m_dualHeightBlitPropertyBlock; // 0x38
		private Material m_foliageInteriaveBlitMaterial; // 0x40
		private Material m_foliageInteriaveColliderMaterial; // 0x48
		private Vector3 m_curCenterPosition; // 0x50
		private Vector3 m_curCenterSize; // 0x5C
		private Vector3 m_lastCenterPosition; // 0x68
		private Vector3 m_lastCenterSize; // 0x74
		private float m_lastTime; // 0x80
		private static readonly RenderFunc<FoliageInteractivePassData> s_foliageInteractiveFunc; // 0x20
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38259
		{
			// Fields
			internal HGSettingParameters settingParams; // 0x00
		}
	
		internal struct PassOutput // TypeDefIndex: 38260
		{
		}
	
		internal class FoliageInteractivePassData // TypeDefIndex: 38261
		{
			// Fields
			internal TextureHandle curDualHeightTexture; // 0x10
			internal TextureHandle prevDualHeightTexture; // 0x20
			internal Material foliageInteriaveBlitMaterial; // 0x30
			internal Material foliageInteriaveColliderMaterial; // 0x38
			internal MaterialPropertyBlock tempMaterialPropertyBlock; // 0x40
			internal Vector3 curCenterPosition; // 0x48
			internal Vector3 curCenterSize; // 0x54
			internal Vector3 lastCenterPosition; // 0x60
			internal Vector3 lastCenterSize; // 0x6C
			internal float deltaTime; // 0x78
	
			// Constructors
			public FoliageInteractivePassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public FoliageInteractivePassConstructor() {} // Dummy constructor
		internal FoliageInteractivePassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000182EDB010-0x0000000182EDB0E0
		// FoliageInteractivePassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::FoliageInteractivePassConstructor::FoliageInteractivePassConstructor(
		        FoliageInteractivePassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  Texture *blackTexture; // rbp
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // r8
		  MethodInfo *methoda; // [rsp+20h] [rbp-28h]
		  TextureHandle v15; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  this->fields.m_prevDualHeightTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v15, 0LL);
		  blackTexture = (Texture *)UnityEngine::Texture2D::get_blackTexture(0LL);
		  if ( !TypeInfo::UnityEngine::Rendering::RTHandles->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::RTHandles);
		  this->fields.m_defaultDualHeightTexture = UnityEngine::Rendering::RTHandleSystem::Alloc(blackTexture, 0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v8, v9, v10, methoda);
		  if ( !resources->defaultResources || (shaders = resources->defaultResources->fields.shaders) == 0LL )
		    sub_1800D8260(v12, v11);
		  HG::Rendering::Runtime::FoliageInteractivePassConstructor::InitializeFoliageInteractiveResource(
		    this,
		    materialCollector,
		    shaders->fields.foliageInteractiveBlitPS,
		    resources->defaultResources->fields.shaders->fields.foliageInteractiveColliderPS,
		    0LL);
		}
		
		static FoliageInteractivePassConstructor() {} // 0x0000000184B2ABD0-0x0000000184B2AD40
		// FoliageInteractivePassConstructor()
		void HG::Rendering::Runtime::FoliageInteractivePassConstructor::cctor(MethodInfo *method)
		{
		  struct FoliageInteractivePassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_FoliageInteractivePassConstructor_FoliageInteractivePassData_ *v6; // rbx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor->static_fields->_LastCenterPos = UnityEngine::Shader::PropertyToID((String *)"_LastCenterPos", 0LL);
		  TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor->static_fields->_LastCenterSize = UnityEngine::Shader::PropertyToID((String *)"_LastCenterSize", 0LL);
		  TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor->static_fields->_CurCenterPos = UnityEngine::Shader::PropertyToID((String *)"_CurCenterPos", 0LL);
		  TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor->static_fields->_CurCenterSize = UnityEngine::Shader::PropertyToID((String *)"_CurCenterSize", 0LL);
		  TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor->static_fields->_DeltaTime = UnityEngine::Shader::PropertyToID(
		                                                                                                     (String *)"_DeltaTime",
		                                                                                                     0LL);
		  TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor->static_fields->_RaiseSpeed = UnityEngine::Shader::PropertyToID((String *)"_RaiseSpeed", 0LL);
		  TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor->static_fields->_PerInstanceData = UnityEngine::Shader::PropertyToID((String *)"PerInstanceData", 0LL);
		  v1 = TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::FoliageInteractivePassConstructor::FoliageInteractivePassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_FoliageInteractivePassConstructor_FoliageInteractivePassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor::__c::__cctor_b__32_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor->static_fields->s_foliageInteractiveFunc = v6;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor->static_fields->s_foliageInteractiveFunc,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		private void InitializeFoliageInteractiveResource(HGRenderPipelineMaterialCollector materialCollector, Shader blitShader, Shader colliderShader) {} // 0x0000000182EDA7C0-0x0000000182EDA880
		// Void InitializeFoliageInteractiveResource(HGRenderPipelineMaterialCollector, Shader, Shader)
		void HG::Rendering::Runtime::FoliageInteractivePassConstructor::InitializeFoliageInteractiveResource(
		        FoliageInteractivePassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        Shader *blitShader,
		        Shader *colliderShader,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  MaterialPropertyBlock *v17; // rdi
		  Type *v18; // rdx
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *P3; // [rsp+20h] [rbp-18h]
		  MethodInfo *P3b; // [rsp+20h] [rbp-18h]
		  MethodInfo *P3a; // [rsp+20h] [rbp-18h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3132, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3132, 0LL);
		    if ( !Patch )
		      goto LABEL_4;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
		      (ILFixDynamicMethodWrapper_10 *)Patch,
		      (Object *)this,
		      (Object *)materialCollector,
		      (Object *)blitShader,
		      (Object *)colliderShader,
		      0LL);
		  }
		  else
		  {
		    if ( !materialCollector
		      || (this->fields.m_foliageInteriaveBlitMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                                          materialCollector,
		                                                          blitShader,
		                                                          1,
		                                                          0LL),
		          sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_foliageInteriaveBlitMaterial, v11, v12, v13, P3),
		          this->fields.m_foliageInteriaveColliderMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                                              materialCollector,
		                                                              colliderShader,
		                                                              1,
		                                                              0LL),
		          sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_foliageInteriaveColliderMaterial, v14, v15, v16, P3b),
		          (v17 = (MaterialPropertyBlock *)sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock)) == 0LL) )
		    {
		LABEL_4:
		      sub_1800D8260(v10, v9);
		    }
		    v17->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		    this->fields.m_dualHeightBlitPropertyBlock = v17;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_dualHeightBlitPropertyBlock, v18, v19, v20, P3a);
		  }
		}
		
		private void PrepareFoliageInteractPassData(HGCamera hgCamera, ref FoliageInteractivePassData passData) {} // 0x0000000189BA905C-0x0000000189BA91D0
		// Void PrepareFoliageInteractPassData(HGCamera, FoliageInteractivePassConstructor+FoliageInteractivePassData ByRef)
		void HG::Rendering::Runtime::FoliageInteractivePassConstructor::PrepareFoliageInteractPassData(
		        FoliageInteractivePassConstructor *this,
		        HGCamera *hgCamera,
		        FoliageInteractivePassConstructor_FoliageInteractivePassData **passData,
		        MethodInfo *method)
		{
		  Type *v7; // rdx
		  __int64 z_low; // rcx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  PropertyInfo_1 *v13; // r8
		  FoliageInteractivePassConstructor_FoliageInteractivePassData *v14; // r9
		  float z; // eax
		  FoliageInteractivePassConstructor_FoliageInteractivePassData *v16; // rax
		  FoliageInteractivePassConstructor_FoliageInteractivePassData *v17; // rax
		  FoliageInteractivePassConstructor_FoliageInteractivePassData *v18; // rax
		  float v19; // eax
		  __int64 v20; // xmm0_8
		  float v21; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v23; // [rsp+20h] [rbp-18h]
		  MethodInfo *v24; // [rsp+20h] [rbp-18h]
		  MethodInfo *v25; // [rsp+20h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3133, 0LL) )
		  {
		    if ( *passData )
		    {
		      (*passData)->fields.curDualHeightTexture = this->fields.m_curDualHeightTexture;
		      if ( *passData )
		      {
		        (*passData)->fields.prevDualHeightTexture = this->fields.m_prevDualHeightTexture;
		        z_low = (__int64)*passData;
		        if ( *passData )
		        {
		          *(_QWORD *)(z_low + 48) = this->fields.m_foliageInteriaveBlitMaterial;
		          sub_18002D1B0((SingleFieldAccessor *)(z_low + 48), v7, v9, v10, v23);
		          z_low = (__int64)*passData;
		          if ( *passData )
		          {
		            *(_QWORD *)(z_low + 56) = this->fields.m_foliageInteriaveColliderMaterial;
		            sub_18002D1B0((SingleFieldAccessor *)(z_low + 56), v7, v11, v12, v24);
		            v14 = *passData;
		            z = this->fields.m_curCenterPosition.z;
		            if ( *passData )
		            {
		              *(_QWORD *)&v14->fields.curCenterPosition.x = *(_QWORD *)&this->fields.m_curCenterPosition.x;
		              v14->fields.curCenterPosition.z = z;
		              v16 = *passData;
		              z_low = LODWORD(this->fields.m_curCenterSize.z);
		              if ( *passData )
		              {
		                *(_QWORD *)&v16->fields.curCenterSize.x = *(_QWORD *)&this->fields.m_curCenterSize.x;
		                LODWORD(v16->fields.curCenterSize.z) = z_low;
		                v17 = *passData;
		                z_low = LODWORD(this->fields.m_lastCenterPosition.z);
		                if ( *passData )
		                {
		                  *(_QWORD *)&v17->fields.lastCenterPosition.x = *(_QWORD *)&this->fields.m_lastCenterPosition.x;
		                  LODWORD(v17->fields.lastCenterPosition.z) = z_low;
		                  v18 = *passData;
		                  z_low = LODWORD(this->fields.m_lastCenterSize.z);
		                  if ( *passData )
		                  {
		                    *(_QWORD *)&v18->fields.lastCenterSize.x = *(_QWORD *)&this->fields.m_lastCenterSize.x;
		                    LODWORD(v18->fields.lastCenterSize.z) = z_low;
		                    z_low = (__int64)*passData;
		                    if ( *passData )
		                    {
		                      *(_QWORD *)(z_low + 64) = this->fields.m_dualHeightBlitPropertyBlock;
		                      sub_18002D1B0((SingleFieldAccessor *)(z_low + 64), v7, v13, (Int32__Array **)v14, v25);
		                      v19 = this->fields.m_curCenterPosition.z;
		                      *(_QWORD *)&this->fields.m_lastCenterPosition.x = *(_QWORD *)&this->fields.m_curCenterPosition.x;
		                      v20 = *(_QWORD *)&this->fields.m_curCenterSize.x;
		                      this->fields.m_lastCenterPosition.z = v19;
		                      v21 = this->fields.m_curCenterSize.z;
		                      *(_QWORD *)&this->fields.m_lastCenterSize.x = v20;
		                      this->fields.m_lastCenterSize.z = v21;
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
		LABEL_13:
		    sub_1800D8260(z_low, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3133, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1156(Patch, (Object *)this, (Object *)hgCamera, passData, 0LL);
		}
		
		private void PrepareFoliageInteractTexture(HGRenderGraph renderGraph) {} // 0x0000000189BA91D0-0x0000000189BA937C
		// Void PrepareFoliageInteractTexture(HGRenderGraph)
		void HG::Rendering::Runtime::FoliageInteractivePassConstructor::PrepareFoliageInteractTexture(
		        FoliageInteractivePassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  HGFoliageInteractiveManager *foliageInteractiveManager_k__BackingField; // rdx
		  __int64 v7; // rcx
		  HGFoliageInteractiveConfig *Config; // rax
		  __m128i v9; // xmm6
		  int32_t graphicsFormat; // esi
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  MethodInfo *v14; // rdx
		  Color v15; // xmm2
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGFoliageInteractiveConfig v17; // [rsp+28h] [rbp-E0h] BYREF
		  _BYTE v18[104]; // [rsp+40h] [rbp-C8h] BYREF
		  TextureDesc v19; // [rsp+A8h] [rbp-60h] BYREF
		
		  sub_18033B9D0(&v18[8], 0LL, 96LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(3134, 0LL) )
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      foliageInteractiveManager_k__BackingField = currentManagerContext->fields._foliageInteractiveManager_k__BackingField;
		      if ( foliageInteractiveManager_k__BackingField )
		      {
		        Config = HG::Rendering::Runtime::HGFoliageInteractiveManager::GetConfig(
		                   &v17,
		                   foliageInteractiveManager_k__BackingField,
		                   0LL);
		        v9 = *(__m128i *)&Config->textureSize.m_X;
		        graphicsFormat = Config->graphicsFormat;
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_prevDualHeightTexture, 0LL) )
		        {
		          if ( !renderGraph )
		            goto LABEL_10;
		          this->fields.m_prevDualHeightTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                                    (TextureHandle *)&v17,
		                                                    renderGraph,
		                                                    this->fields.m_defaultDualHeightTexture,
		                                                    0LL);
		        }
		        HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		          (TextureDesc *)&v18[8],
		          _mm_cvtsi128_si32(v9),
		          _mm_cvtsi128_si32(_mm_srli_si128(v9, 4)),
		          0LL);
		        *(_WORD *)&v18[40] = 0;
		        *(_QWORD *)&v18[64] = "curDualHeightTexture";
		        *(_DWORD *)&v18[24] = graphicsFormat;
		        v18[42] = 0;
		        sub_18002D1B0((SingleFieldAccessor *)&v18[64], v11, v12, v13, *(MethodInfo **)&v17.textureSize);
		        v15 = (Color)_mm_loadu_si128((const __m128i *)UnityEngine::Color::get_yellow((Color *)&v17, v14));
		        v18[85] = 1;
		        *(_OWORD *)&v19.width = *(_OWORD *)&v18[8];
		        *(_OWORD *)&v19.enableRandomWrite = *(_OWORD *)&v18[40];
		        *(_OWORD *)&v19.colorFormat = *(_OWORD *)&v18[24];
		        *(_OWORD *)&v19.fastMemoryDesc.inFastMemory = *(_OWORD *)&v18[72];
		        *(Color *)&v18[88] = v15;
		        *(_OWORD *)&v19.bindTextureMS = *(_OWORD *)&v18[56];
		        v19.clearColor = v15;
		        if ( renderGraph )
		        {
		          this->fields.m_curDualHeightTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                   (TextureHandle *)&v17,
		                                                   renderGraph,
		                                                   &v19,
		                                                   0LL);
		          return;
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(v7, foliageInteractiveManager_k__BackingField);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3134, 0LL);
		  if ( !Patch )
		    goto LABEL_10;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)renderGraph,
		    0LL);
		}
		
		private void PostPrepareFoliageInteractTexture(HGRenderGraph renderGraph) {} // 0x0000000189BA8FD0-0x0000000189BA905C
		// Void PostPrepareFoliageInteractTexture(HGRenderGraph)
		void HG::Rendering::Runtime::FoliageInteractivePassConstructor::PostPrepareFoliageInteractTexture(
		        FoliageInteractivePassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v8; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3135, 0LL) )
		  {
		    if ( renderGraph )
		    {
		      this->fields.m_prevDualHeightTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                                                &v8,
		                                                renderGraph,
		                                                &this->fields.m_curDualHeightTexture,
		                                                1,
		                                                (String *)"FoliageInteractivePass",
		                                                0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3135, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)renderGraph,
		    0LL);
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BA8EC0-0x0000000189BA8FD0
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::FoliageInteractivePassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        FoliageInteractivePassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v6; // rdx
		  HGFoliageInteractiveManager *foliageInteractiveManager_k__BackingField; // rcx
		  float z; // eax
		  __int64 v9; // xmm5_8
		  MethodInfo *z_low; // r8
		  __int64 v11; // xmm0_8
		  float v12; // eax
		  Vector4 *v13; // rax
		  __int64 v14; // xmm5_8
		  MethodInfo *v15; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 centerPosition; // [rsp+20h] [rbp-20h] BYREF
		  Vector3 centerSize; // [rsp+30h] [rbp-10h] BYREF
		
		  *(_QWORD *)&centerPosition.x = 0LL;
		  centerPosition.z = 0.0;
		  *(_QWORD *)&centerSize.x = 0LL;
		  centerSize.z = 0.0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3136, 0LL) )
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      foliageInteractiveManager_k__BackingField = currentManagerContext->fields._foliageInteractiveManager_k__BackingField;
		      if ( foliageInteractiveManager_k__BackingField )
		      {
		        HG::Rendering::Runtime::HGFoliageInteractiveManager::GetCenter(
		          foliageInteractiveManager_k__BackingField,
		          (Vector3 *)&centerPosition,
		          &centerSize,
		          0LL);
		        z = centerSize.z;
		        v9 = *(_QWORD *)&centerPosition.x;
		        z_low = (MethodInfo *)LODWORD(centerPosition.z);
		        *(_QWORD *)&this->fields.m_curCenterSize.x = *(_QWORD *)&centerSize.x;
		        v11 = *(_QWORD *)&this->fields.m_lastCenterPosition.x;
		        this->fields.m_curCenterSize.z = z;
		        v12 = this->fields.m_lastCenterPosition.z;
		        *(_QWORD *)&this->fields.m_curCenterPosition.x = v9;
		        *(_QWORD *)&centerSize.x = v11;
		        centerSize.z = v12;
		        LODWORD(this->fields.m_curCenterPosition.z) = (_DWORD)z_low;
		        v13 = UnityEngine::Vector4::op_Implicit(&centerPosition, &centerSize, z_low);
		        *(_QWORD *)&centerSize.x = v14;
		        LODWORD(centerSize.z) = (_DWORD)v15;
		        *(__m128i *)&shaderVariablesGlobal->_CharacterParams0.w = _mm_loadu_si128((const __m128i *)v13);
		        *(__m128i *)&shaderVariablesGlobal->_VFXParams3.w = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(
		                                                                                               &centerPosition,
		                                                                                               &centerSize,
		                                                                                               v15));
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(foliageInteractiveManager_k__BackingField, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3136, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BA8E6C-0x0000000189BA8EC0
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::FoliageInteractivePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        FoliageInteractivePassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3137, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3137, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BA8A54-0x0000000189BA8DC0
		// Void ConstructPass(FoliageInteractivePassConstructor+PassInput ByRef, FoliageInteractivePassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::FoliageInteractivePassConstructor::ConstructPass(
		        FoliageInteractivePassConstructor *this,
		        FoliageInteractivePassConstructor_PassInput *input,
		        FoliageInteractivePassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  HGRenderGraph *v6; // rdi
		  FoliageInteractivePassConstructor *v9; // rbx
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  char v14; // dl
		  __int64 v15; // rcx
		  int v16; // r8d
		  float v17; // xmm7_4
		  ProfilingSampler *v18; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  FoliageInteractivePassConstructor_FoliageInteractivePassData *passData; // [rsp+50h] [rbp-98h] BYREF
		  Il2CppExceptionWrapper *v29; // [rsp+58h] [rbp-90h] BYREF
		  _QWORD v30[2]; // [rsp+60h] [rbp-88h] BYREF
		  __m128i si128; // [rsp+70h] [rbp-78h] BYREF
		  HGRenderGraphBuilder v32; // [rsp+80h] [rbp-68h] BYREF
		  HGRenderGraphBuilder v33; // [rsp+A0h] [rbp-48h] BYREF
		
		  v6 = renderGraph;
		  v9 = this;
		  passData = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3138, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3138, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v27, v26);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1157(
		      Patch,
		      (Object *)v9,
		      input,
		      output,
		      (Object *)v6,
		      (Object *)camera,
		      0LL);
		  }
		  else
		  {
		    if ( !input->settingParams )
		      sub_1800D8260(v11, v10);
		    if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		           input->settingParams->fields._foliageInteractiveEnable_k__BackingField,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		    {
		      if ( !v6 )
		        sub_1800D8260(v13, v12);
		      if ( !v6->fields._enableCppRenderPath_k__BackingField )
		      {
		        if ( v9->fields.m_lastTime == 0.0 )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		          v9->fields.m_lastTime = HG::Rendering::Runtime::HGRPTimeManager::get_gameplayTime(0LL);
		        }
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRPTimeManager);
		        HG::Rendering::Runtime::HGRPTimeManager::get_gameplayTime(0LL);
		        v17 = (float)(int)sub_1834464B0(v15, v14, v16) * 0.033;
		        v9->fields.m_lastTime = v9->fields.m_lastTime + v17;
		        HG::Rendering::Runtime::FoliageInteractivePassConstructor::PrepareFoliageInteractTexture(v9, v6, 0LL);
		        v18 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		                (Int32Enum__Enum)0x76u,
		                MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		        HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		          &v32,
		          v6,
		          (String *)"Foliage Interactive",
		          (Object **)&passData,
		          v18,
		          1,
		          ProfilingHGPass__Enum_None,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FoliageInteractivePassConstructor::FoliageInteractivePassData>);
		        v33 = v32;
		        v30[0] = 0LL;
		        v30[1] = &v33;
		        try
		        {
		          HG::Rendering::Runtime::FoliageInteractivePassConstructor::PrepareFoliageInteractPassData(
		            v9,
		            camera,
		            &passData,
		            0LL);
		          if ( !passData )
		            sub_1800D8250(v20, v19);
		          passData->fields.deltaTime = v17;
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v33, 0, 0LL);
		          if ( !passData )
		            sub_1800D8250(v22, v21);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		            (TextureHandle *)&si128,
		            &v33,
		            &passData->fields.prevDualHeightTexture,
		            0LL);
		          if ( !passData )
		            sub_1800D8250(v24, v23);
		          si128 = _mm_load_si128((const __m128i *)&xmmword_18DA45AF0);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		            (TextureHandle *)&v32,
		            &v33,
		            &passData->fields.curDualHeightTexture,
		            0,
		            RenderBufferLoadAction__Enum_DontCare,
		            RenderBufferStoreAction__Enum_Store,
		            (Color *)&si128,
		            0,
		            0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor);
		          HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		            &v33,
		            (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::FoliageInteractivePassConstructor->static_fields->s_foliageInteractiveFunc,
		            0LL,
		            0,
		            MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FoliageInteractivePassConstructor::FoliageInteractivePassData>);
		        }
		        catch ( Il2CppExceptionWrapper *v29 )
		        {
		          v30[0] = v29->ex;
		          sub_180268AE0(v30);
		          v6 = renderGraph;
		          v9 = this;
		          goto LABEL_14;
		        }
		        sub_180268AE0(v30);
		LABEL_14:
		        HG::Rendering::Runtime::FoliageInteractivePassConstructor::PostPrepareFoliageInteractTexture(v9, v6, 0LL);
		      }
		    }
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BA8DC0-0x0000000189BA8E6C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::FoliageInteractivePassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        FoliageInteractivePassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  HGRenderGraph *renderGraph; // rdi
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v9; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3139, 0LL) )
		  {
		    renderGraph = input->renderGraph;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_prevDualHeightTexture, 0LL) )
		      return;
		    if ( renderGraph )
		    {
		      this->fields.m_prevDualHeightTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                                                &v9,
		                                                renderGraph,
		                                                &this->fields.m_prevDualHeightTexture,
		                                                1,
		                                                (String *)"FoliageInteractivePass",
		                                                0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v7, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3139, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184CE76A0-0x0000000184CE7740
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::FoliageInteractivePassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        FoliageInteractivePassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  Object_1 *m_foliageInteriaveBlitMaterial; // rdi
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Material *v8; // r9
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  __int64 v11; // rdx
		  MaterialPropertyBlock *m_dualHeightBlitPropertyBlock; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3140, 0LL) )
		  {
		    m_foliageInteriaveBlitMaterial = (Object_1 *)this->fields.m_foliageInteriaveBlitMaterial;
		    if ( !TypeInfo::UnityEngine::Rendering::CoreUtils->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Rendering::CoreUtils);
		    UnityEngine::Rendering::CoreUtils::Destroy(m_foliageInteriaveBlitMaterial, 0LL);
		    UnityEngine::Rendering::CoreUtils::Destroy((Object_1 *)this->fields.m_foliageInteriaveColliderMaterial, 0LL);
		    this->fields.m_foliageInteriaveBlitMaterial = 0LL;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_foliageInteriaveBlitMaterial, v6, v7, 0LL, v14);
		    this->fields.m_foliageInteriaveColliderMaterial = v8;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&this->fields.m_foliageInteriaveColliderMaterial,
		      v9,
		      v10,
		      (Int32__Array **)v8,
		      v15);
		    m_dualHeightBlitPropertyBlock = this->fields.m_dualHeightBlitPropertyBlock;
		    if ( m_dualHeightBlitPropertyBlock )
		    {
		      UnityEngine::MaterialPropertyBlock::Clear(m_dualHeightBlitPropertyBlock, 1, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(m_dualHeightBlitPropertyBlock, v11);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3140, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)renderGraph,
		    0LL);
		}
		
	}
}
