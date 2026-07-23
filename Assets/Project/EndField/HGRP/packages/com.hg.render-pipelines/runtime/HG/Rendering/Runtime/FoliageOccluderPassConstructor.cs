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
	internal class FoliageOccluderPassConstructor : IPassConstructor // TypeDefIndex: 38268
	{
		// Fields
		private RTHandle m_foliageOccluderRenderTexture; // 0x10
		private RTHandle m_foliageOccluderMaskA; // 0x18
		private RTHandle m_foliageOccluderMaskB; // 0x20
		private MaterialPropertyBlock m_blitFoliageOccluderPropertyBlock; // 0x28
		private Material m_occluderMaterial; // 0x30
		private Mesh m_occluderMesh; // 0x38
		private Material m_blitMaterial; // 0x40
		private bool m_renderFirstFrame; // 0x48
		private bool m_renderTextureInitialized; // 0x49
		private static readonly RenderFunc<FoliageOccluderPassData> s_foliageOccluderRenderPass; // 0x00
		private static readonly RenderFunc<FoliageOccluderPassData> s_foliageOccluderBlitPass; // 0x08
		private static readonly RenderFunc<FoliageOccluderPassData> s_setFinalMaskPass; // 0x10
		private static Plane[] s_tempPlanes; // 0x18
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38264
		{
		}
	
		internal struct PassOutput // TypeDefIndex: 38265
		{
		}
	
		internal class FoliageOccluderPassData // TypeDefIndex: 38266
		{
			// Fields
			internal Material blitMat; // 0x10
			internal MaterialPropertyBlock blitMaterialPropertyBlock; // 0x18
			internal TextureHandle prevFinalTexture; // 0x20
			internal TextureHandle curFinalTexture; // 0x30
			internal TextureHandle occluderRenderTexture; // 0x40
			internal uint ecsRendererList; // 0x50
	
			// Constructors
			public FoliageOccluderPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public FoliageOccluderPassConstructor() {} // Dummy constructor
		internal FoliageOccluderPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x00000001849B8140-0x00000001849B8240
		// FoliageOccluderPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassConstructor(
		        FoliageOccluderPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  HGRenderPipelineRuntimeResources_ShaderResources *v7; // rdx
		  __int64 v8; // rcx
		  MaterialPropertyBlock *v9; // rdi
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  HGRenderPipelineRuntimeResources_AssetResources *assets; // rax
		  Type *v20; // rdx
		  PropertyInfo_1 *v21; // r8
		  Int32__Array **v22; // r9
		  MethodInfo *v23; // [rsp+20h] [rbp-8h]
		  MethodInfo *v24; // [rsp+20h] [rbp-8h]
		  MethodInfo *v25; // [rsp+20h] [rbp-8h]
		  MethodInfo *v26; // [rsp+50h] [rbp+28h]
		
		  this->fields.m_renderFirstFrame = 1;
		  v9 = (MaterialPropertyBlock *)sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock);
		  if ( !v9 )
		    goto LABEL_2;
		  v9->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  this->fields.m_blitFoliageOccluderPropertyBlock = v9;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_blitFoliageOccluderPropertyBlock, v10, v11, v12, v23);
		  if ( !resources->defaultResources
		    || (shaders = resources->defaultResources->fields.shaders) == 0LL
		    || !materialCollector
		    || (this->fields.m_occluderMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                            materialCollector,
		                                            shaders->fields.foliageOccluderPS,
		                                            1,
		                                            0LL),
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_occluderMaterial, v14, v15, v16, v24),
		        !resources->defaultResources)
		    || (assets = resources->defaultResources->fields.assets) == 0LL
		    || (this->fields.m_occluderMesh = assets->fields.defaultCubeMesh,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_occluderMesh, (Type *)v7, v17, v18, v25),
		        !resources->defaultResources)
		    || (v7 = resources->defaultResources->fields.shaders) == 0LL )
		  {
		LABEL_2:
		    sub_1800D8260(v8, v7);
		  }
		  this->fields.m_blitMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                  materialCollector,
		                                  v7->fields.foliageOccluderBlitPS,
		                                  1,
		                                  0LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_blitMaterial, v20, v21, v22, v26);
		}
		
		static FoliageOccluderPassConstructor() {} // 0x0000000184A7CE80-0x0000000184A7D020
		// FoliageOccluderPassConstructor()
		void HG::Rendering::Runtime::FoliageOccluderPassConstructor::cctor(MethodInfo *method)
		{
		  struct FoliageOccluderPassConstructor_c__Class *v1; // rax
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
		  Object *v16; // rdi
		  RenderFunc_1_System_Object_ *v17; // rax
		  RenderFunc_1_System_Object_ *v18; // rbx
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
		
		  v1 = TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassData>);
		  v6 = (Type__Class *)v3;
		  if ( !v3 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor::__c::__cctor_b__23_0,
		    0LL);
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor->static_fields;
		  static_fields->klass = v6;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor->static_fields,
		    static_fields,
		    v8,
		    v9,
		    v26);
		  v10 = (Object *)TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor::__c->static_fields->__9;
		  v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassData>);
		  v12 = (MonitorData *)v11;
		  if ( !v11
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v11,
		          v10,
		          MethodInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor::__c::__cctor_b__23_1,
		          0LL),
		        v13 = (Type *)TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor->static_fields,
		        v13->monitor = v12,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor->static_fields->s_foliageOccluderBlitPass,
		          v13,
		          v14,
		          v15,
		          v27),
		        v16 = (Object *)TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor::__c->static_fields->__9,
		        v17 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassData>),
		        (v18 = v17) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v17,
		    v16,
		    MethodInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor::__c::__cctor_b__23_2,
		    0LL);
		  v19 = (Type *)TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor->static_fields;
		  v19->fields._impl.value = v18;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor->static_fields->s_setFinalMaskPass,
		    v19,
		    v20,
		    v21,
		    v28);
		  v22 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Plane, 6LL);
		  v23 = (Type *)TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor->static_fields;
		  v23[1].klass = (Type__Class *)v22;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor->static_fields->s_tempPlanes,
		    v23,
		    v24,
		    v25,
		    v29);
		}
		
	
		// Methods
		private void InitializeRenderTexture() {} // 0x0000000189BAA054-0x0000000189BAA268
		// Void InitializeRenderTexture()
		void HG::Rendering::Runtime::FoliageOccluderPassConstructor::InitializeRenderTexture(
		        FoliageOccluderPassConstructor *this,
		        MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  MethodInfo *colorFormat; // [rsp+20h] [rbp-98h]
		  MethodInfo *colorFormata; // [rsp+20h] [rbp-98h]
		  MethodInfo *colorFormatb; // [rsp+20h] [rbp-98h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3141, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3141, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::RTHandles);
		    this->fields.m_foliageOccluderRenderTexture = UnityEngine::Rendering::RTHandles::Alloc(
		                                                    512,
		                                                    512,
		                                                    1,
		                                                    DepthBits__Enum_None,
		                                                    GraphicsFormat__Enum_R8_UNorm,
		                                                    FilterMode__Enum_Point,
		                                                    TextureWrapMode__Enum_Clamp,
		                                                    TextureDimension__Enum_Tex2D,
		                                                    0,
		                                                    0,
		                                                    0,
		                                                    0,
		                                                    1,
		                                                    0.0,
		                                                    MSAASamples__Enum_None,
		                                                    0,
		                                                    RenderTextureMemoryless__Enum_None,
		                                                    (String *)"occluderRenderTexture",
		                                                    0LL);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields, v3, v4, v5, colorFormat);
		    this->fields.m_foliageOccluderMaskA = UnityEngine::Rendering::RTHandles::Alloc(
		                                            512,
		                                            512,
		                                            1,
		                                            DepthBits__Enum_None,
		                                            GraphicsFormat__Enum_R8G8_UNorm,
		                                            FilterMode__Enum_Point,
		                                            TextureWrapMode__Enum_Clamp,
		                                            TextureDimension__Enum_Tex2D,
		                                            0,
		                                            0,
		                                            0,
		                                            0,
		                                            0,
		                                            0.0,
		                                            MSAASamples__Enum_None,
		                                            0,
		                                            RenderTextureMemoryless__Enum_None,
		                                            (String *)"FoliageOccluderFinalMaskA",
		                                            0LL);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_foliageOccluderMaskA, v6, v7, v8, colorFormata);
		    this->fields.m_foliageOccluderMaskB = UnityEngine::Rendering::RTHandles::Alloc(
		                                            512,
		                                            512,
		                                            1,
		                                            DepthBits__Enum_None,
		                                            GraphicsFormat__Enum_R8G8_UNorm,
		                                            FilterMode__Enum_Point,
		                                            TextureWrapMode__Enum_Clamp,
		                                            TextureDimension__Enum_Tex2D,
		                                            0,
		                                            0,
		                                            0,
		                                            0,
		                                            0,
		                                            0.0,
		                                            MSAASamples__Enum_None,
		                                            0,
		                                            RenderTextureMemoryless__Enum_None,
		                                            (String *)"FoliageOccluderFinalMaskB",
		                                            0LL);
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_foliageOccluderMaskB, v9, v10, v11, colorFormatb);
		    this->fields.m_renderTextureInitialized = 1;
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BAA000-0x0000000189BAA054
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::FoliageOccluderPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        FoliageOccluderPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3142, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3142, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BA9FAC-0x0000000189BAA000
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::FoliageOccluderPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        FoliageOccluderPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3143, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3143, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189BA937C-0x0000000189BA9F58
		// Void ConstructPass(FoliageOccluderPassConstructor+PassInput ByRef, FoliageOccluderPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=3
		void HG::Rendering::Runtime::FoliageOccluderPassConstructor::ConstructPass(
		        FoliageOccluderPassConstructor *this,
		        FoliageOccluderPassConstructor_PassInput *input,
		        FoliageOccluderPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  HGRenderGraph *v6; // rsi
		  FoliageOccluderPassConstructor *v9; // r14
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  HGFoliageOccluderRenderParams *Params; // r12
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  TextureHandle v18; // xmm12
		  TextureHandle blackTexture_k__BackingField; // xmm10
		  RTHandle *m_foliageOccluderMaskA; // rbx
		  TextureHandle v21; // xmm11
		  HGRenderGraphDefaultResources *defaultResources; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  __int64 v25; // rbx
		  __int128 v26; // xmm6
		  __int128 v27; // xmm7
		  __int128 v28; // xmm8
		  __int128 v29; // xmm9
		  FoliageOccluderPassConstructor__StaticFields *static_fields; // rcx
		  Void *m_Buffer; // r15
		  __int64 v32; // r12
		  __int64 v33; // rdx
		  __int64 v34; // r9
		  FoliageOccluderPassConstructor__StaticFields *v35; // rcx
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  __int64 v38; // r12
		  Camera *camera; // rbx
		  __int64 v40; // rdx
		  __int64 v41; // rcx
		  uint64_t SceneCullingMaskFromCamera; // r13
		  int32_t cullingMask; // ebx
		  uint32_t COMPOUND_CHARACTER_LAYER_MASK; // r9d
		  Object_1 *m_occluderMaterial; // rbx
		  __int64 v46; // rdx
		  __int64 v47; // rcx
		  int32_t InstanceID; // eax
		  uint32_t MaterialHandle; // r13d
		  Object_1 *m_occluderMesh; // rbx
		  __int64 v51; // rdx
		  __int64 v52; // rcx
		  int32_t v53; // eax
		  uint32_t GeometryHandle; // r15d
		  __int64 v55; // rdx
		  __int64 v56; // rcx
		  HGRenderGraphContext *HGContext; // rbx
		  uint32_t RendererList; // ebx
		  ProfilingSampler *v59; // rax
		  __int64 v60; // rdx
		  __int64 v61; // rcx
		  __int64 v62; // rdx
		  __int64 v63; // rcx
		  ProfilingSampler *v64; // rax
		  __int64 v65; // rdx
		  __int64 v66; // rcx
		  __int64 v67; // rcx
		  Object *v68; // rdx
		  unsigned int v69; // edx
		  unsigned __int64 v70; // r8
		  char v71; // dl
		  signed __int64 v72; // rtt
		  Object *v73; // r15
		  __int64 v74; // rdx
		  __int64 v75; // rcx
		  TextureHandle v76; // xmm0
		  Object *v77; // rdx
		  unsigned int v78; // edx
		  unsigned __int64 v79; // r8
		  char v80; // dl
		  signed __int64 v81; // rtt
		  __int64 v82; // rdx
		  __int64 v83; // rcx
		  __int64 v84; // rdx
		  __int64 v85; // rcx
		  __int64 v86; // rdx
		  __int64 v87; // rcx
		  ProfilingSampler *v88; // rax
		  __int64 v89; // rdx
		  __int64 v90; // rcx
		  __int64 v91; // rdx
		  __int64 v92; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v94; // rdx
		  __int64 v95; // rcx
		  Object *v96; // [rsp+50h] [rbp-1B8h] BYREF
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ v97; // [rsp+60h] [rbp-1A8h] BYREF
		  uint32_t viewHandle[2]; // [rsp+70h] [rbp-198h] BYREF
		  HGRenderGraphBuilder *v99; // [rsp+78h] [rbp-190h]
		  TextureHandle *v100; // [rsp+80h] [rbp-188h] BYREF
		  Object *v101; // [rsp+88h] [rbp-180h] BYREF
		  Matrix4x4 v102; // [rsp+90h] [rbp-178h] BYREF
		  HGRenderGraphBuilder v103; // [rsp+D0h] [rbp-138h] BYREF
		  TextureHandle v104; // [rsp+F0h] [rbp-118h]
		  TextureHandle v105; // [rsp+100h] [rbp-108h]
		  HGRenderGraphBuilder v106; // [rsp+110h] [rbp-F8h] BYREF
		  HGRenderGraphBuilder v107; // [rsp+130h] [rbp-D8h] BYREF
		  Il2CppExceptionWrapper *v108; // [rsp+150h] [rbp-B8h] BYREF
		  Il2CppExceptionWrapper *v109; // [rsp+158h] [rbp-B0h] BYREF
		  Il2CppExceptionWrapper *v110; // [rsp+160h] [rbp-A8h] BYREF
		
		  v6 = renderGraph;
		  v9 = this;
		  v97 = 0LL;
		  memset(&v106, 0, sizeof(v106));
		  v100 = 0LL;
		  memset(&v103, 0, sizeof(v103));
		  v96 = 0LL;
		  memset(&v107, 0, sizeof(v107));
		  v101 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3144, 0LL) )
		  {
		    if ( !v9->fields.m_renderTextureInitialized )
		      HG::Rendering::Runtime::FoliageOccluderPassConstructor::InitializeRenderTexture(v9, 0LL);
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( !currentManagerContext )
		      sub_1800D8260(v12, v11);
		    if ( !currentManagerContext->fields._foliageOccluderManager_k__BackingField )
		      sub_1800D8260(v12, v11);
		    Params = HG::Rendering::Runtime::HGFoliageOccluderManager::GetParams(
		               currentManagerContext->fields._foliageOccluderManager_k__BackingField,
		               0LL);
		    *(_QWORD *)viewHandle = Params;
		    if ( !v6 )
		      sub_1800D8260(v14, v13);
		    v18 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		             (TextureHandle *)&v102,
		             v6,
		             v9->fields.m_foliageOccluderRenderTexture,
		             0LL);
		    if ( !Params )
		      sub_1800D8260(v17, v16);
		    if ( Params->fields.curMaskIsA )
		    {
		      blackTexture_k__BackingField = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                        (TextureHandle *)&v102,
		                                        v6,
		                                        v9->fields.m_foliageOccluderMaskB,
		                                        0LL);
		      v104 = blackTexture_k__BackingField;
		      m_foliageOccluderMaskA = v9->fields.m_foliageOccluderMaskA;
		    }
		    else
		    {
		      blackTexture_k__BackingField = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		                                        (TextureHandle *)&v102,
		                                        v6,
		                                        v9->fields.m_foliageOccluderMaskA,
		                                        0LL);
		      v104 = blackTexture_k__BackingField;
		      m_foliageOccluderMaskA = v9->fields.m_foliageOccluderMaskB;
		    }
		    v21 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		             (TextureHandle *)&v102,
		             v6,
		             m_foliageOccluderMaskA,
		             0LL);
		    v105 = v21;
		    if ( v9->fields.m_renderFirstFrame )
		    {
		      defaultResources = HG::Rendering::RenderGraphModule::HGRenderGraph::get_defaultResources(v6, 0LL);
		      if ( !defaultResources )
		        sub_1800D8260(v24, v23);
		      blackTexture_k__BackingField = defaultResources->fields._blackTexture_k__BackingField;
		      v104 = blackTexture_k__BackingField;
		    }
		    v25 = 0LL;
		    if ( !Params->fields.shouldRender )
		      goto LABEL_53;
		    v26 = *(_OWORD *)&Params->fields.cullingMatrix.m00;
		    v27 = *(_OWORD *)&Params->fields.cullingMatrix.m01;
		    v28 = *(_OWORD *)&Params->fields.cullingMatrix.m02;
		    v29 = *(_OWORD *)&Params->fields.cullingMatrix.m03;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
		    static_fields = TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor->static_fields;
		    *(_OWORD *)&v102.m00 = v26;
		    *(_OWORD *)&v102.m01 = v27;
		    *(_OWORD *)&v102.m02 = v28;
		    *(_OWORD *)&v102.m03 = v29;
		    UnityEngine::GeometryUtility::CalculateFrustumPlanes(&v102, static_fields->s_tempPlanes, 0LL);
		    Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::NativeArray(
		      &v97,
		      6,
		      Allocator__Enum_Temp,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Plane>::NativeArray);
		    m_Buffer = v97.m_Buffer;
		    v32 = 6LL;
		    do
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
		      v35 = TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor->static_fields;
		      if ( !v35->s_tempPlanes )
		        sub_1800D8260(v35, v33);
		      sub_180002990(v35->s_tempPlanes, &v102, v25, v34);
		      *(_OWORD *)m_Buffer = *(_OWORD *)&v102.m00;
		      ++v25;
		      m_Buffer += 16;
		      --v32;
		    }
		    while ( v32 );
		    v38 = *(_QWORD *)viewHandle;
		    if ( !hgCamera )
		      sub_1800D8260(v37, v36);
		    camera = hgCamera->fields.camera;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    SceneCullingMaskFromCamera = HG::Rendering::Runtime::HGUtils::GetSceneCullingMaskFromCamera(camera, 0LL);
		    if ( !hgCamera->fields.camera )
		      sub_1800D8260(v41, v40);
		    cullingMask = UnityEngine::Camera::get_cullingMask(hgCamera->fields.camera, 0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    COMPOUND_CHARACTER_LAYER_MASK = TypeInfo::HG::Rendering::Runtime::HGCamera->static_fields->COMPOUND_CHARACTER_LAYER_MASK;
		    *(NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&v102.m00 = v97;
		    viewHandle[0] = UnityEngine::HyperGryph::HGCullingSystem::AddCullViewByPlanes(
		                      (NativeArray_1_UnityEngine_Plane_ *)&v102,
		                      0,
		                      SceneCullingMaskFromCamera,
		                      cullingMask & ~COMPOUND_CHARACTER_LAYER_MASK,
		                      0x80000u,
		                      0x80000u,
		                      &hgCamera->fields.lodCrossFadeConfig,
		                      0.0,
		                      CameraType__Enum_Shadow,
		                      0LL);
		    UnityEngine::HyperGryph::HGCullingSystem::DispatchBatchCullingJobs(0LL);
		    m_occluderMaterial = (Object_1 *)v9->fields.m_occluderMaterial;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(m_occluderMaterial, 0LL, 0LL) )
		    {
		      if ( !v9->fields.m_occluderMaterial )
		        sub_1800D8260(v47, v46);
		      InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)v9->fields.m_occluderMaterial, 0LL);
		      MaterialHandle = UnityEngine::HyperGryph::HGShadingStateSystem::GetMaterialHandle(InstanceID, 0LL);
		    }
		    else
		    {
		      MaterialHandle = 0;
		    }
		    m_occluderMesh = (Object_1 *)v9->fields.m_occluderMesh;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(m_occluderMesh, 0LL, 0LL) )
		    {
		      if ( !v9->fields.m_occluderMesh )
		        sub_1800D8260(v52, v51);
		      v53 = UnityEngine::Object::GetInstanceID((Object_1 *)v9->fields.m_occluderMesh, 0LL);
		      GeometryHandle = UnityEngine::HyperGryph::HGGeometrySystem::GetGeometryHandle(v53, 0LL);
		    }
		    else
		    {
		      GeometryHandle = 0;
		    }
		    HGContext = HG::Rendering::RenderGraphModule::HGRenderGraph::get_HGContext(v6, 0LL);
		    if ( !HGContext )
		      sub_1800D8260(v56, v55);
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		    RendererList = UnityEngine::HyperGryph::HGFoliageOccluderRender::CreateRendererList(
		                     viewHandle[0],
		                     MaterialHandle,
		                     GeometryHandle,
		                     HGShaderLightMode__Enum_Forward,
		                     HGContext->fields.renderContext.m_Ptr,
		                     0LL);
		    if ( !*(_BYTE *)(v38 + 16) )
		      goto LABEL_53;
		    v59 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x74u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    v106 = *(HGRenderGraphBuilder *)sub_1808AF378(
		                                      (unsigned int)&v102,
		                                      (_DWORD)v6,
		                                      (unsigned int)"Foliage Occluder Render",
		                                      (unsigned int)&v100,
		                                      (__int64)v59);
		    *(_QWORD *)viewHandle = 0LL;
		    v99 = &v106;
		    try
		    {
		      if ( !v100 )
		        sub_1800D8250(v61, v60);
		      v100[4] = v18;
		      if ( !v100 )
		        sub_1800D8250(v61, v60);
		      v100[5].handle.m_Value = RendererList;
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v106, 0, 0LL);
		      if ( !v100 )
		        sub_1800D8250(v63, v62);
		      *(__m128i *)&v102.m00 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        (TextureHandle *)&v97,
		        &v106,
		        v100 + 4,
		        0,
		        (Color *)&v102,
		        0,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v106,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor->static_fields->s_foliageOccluderRenderPass,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v108 )
		    {
		      *(Il2CppExceptionWrapper *)viewHandle = (Il2CppExceptionWrapper)v108->ex;
		      sub_180268AE0(viewHandle);
		      v6 = renderGraph;
		      v9 = this;
		      blackTexture_k__BackingField = v104;
		      v21 = v105;
		      goto LABEL_36;
		    }
		    sub_180268AE0(viewHandle);
		LABEL_36:
		    v64 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x75u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !v6 )
		      goto LABEL_88;
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      (HGRenderGraphBuilder *)&v102,
		      v6,
		      (String *)"Foliage Occluder Blit",
		      &v96,
		      v64,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassData>);
		    *(_OWORD *)&v103.m_RenderPass = *(_OWORD *)&v102.m00;
		    *(_OWORD *)&v103.m_RenderGraph = *(_OWORD *)&v102.m01;
		    v97.m_Buffer = 0LL;
		    *(_QWORD *)&v97.m_Length = &v103;
		    try
		    {
		      v68 = v96;
		      if ( !v96 )
		        sub_1800D8250(v67, 0LL);
		      v96[1].klass = (Object__Class *)v9->fields.m_blitMaterial;
		      if ( dword_18F35FD08 )
		      {
		        v69 = ((unsigned __int64)&v68[1] >> 12) & 0x1FFFFF;
		        v70 = (unsigned __int64)v69 >> 6;
		        v71 = v69 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v70 + 36190]);
		        do
		          v72 = qword_18F0BCBA0[v70 + 36190];
		        while ( v72 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v70 + 36190], v72 | (1LL << v71), v72) );
		      }
		      v73 = v96;
		      v76 = *HG::Rendering::RenderGraphModule::HGRenderGraph::ImportTexture(
		               (TextureHandle *)&v102,
		               v6,
		               v9->fields.m_foliageOccluderRenderTexture,
		               0LL);
		      if ( !v73 )
		        sub_1800D8250(v75, v74);
		      v73[4] = (Object)v76;
		      if ( !v96 )
		        sub_1800D8250(v75, v74);
		      v96[2] = (Object)blackTexture_k__BackingField;
		      if ( !v96 )
		        sub_1800D8250(v75, v74);
		      v96[3] = (Object)v21;
		      v77 = v96;
		      if ( !v96 )
		        sub_1800D8250(v75, 0LL);
		      v96[1].monitor = (MonitorData *)v9->fields.m_blitFoliageOccluderPropertyBlock;
		      if ( dword_18F35FD08 )
		      {
		        v78 = ((unsigned __int64)&v77[1].monitor >> 12) & 0x1FFFFF;
		        v79 = (unsigned __int64)v78 >> 6;
		        v80 = v78 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v79 + 36190]);
		        do
		          v81 = qword_18F0BCBA0[v79 + 36190];
		        while ( v81 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v79 + 36190], v81 | (1LL << v80), v81) );
		      }
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v103, 0, 0LL);
		      if ( !v96 )
		        sub_1800D8250(v83, v82);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		        (TextureHandle *)&v102,
		        &v103,
		        (TextureHandle *)&v96[4],
		        0LL);
		      if ( !v96 )
		        sub_1800D8250(v85, v84);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		        (TextureHandle *)&v102,
		        &v103,
		        (TextureHandle *)&v96[2],
		        0LL);
		      if ( !v96 )
		        sub_1800D8250(v87, v86);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        (TextureHandle *)&v102,
		        &v103,
		        (TextureHandle *)&v96[3],
		        0,
		        0,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v103,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor->static_fields->s_foliageOccluderBlitPass,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v109 )
		    {
		      v97.m_Buffer = (Void *)v109->ex;
		      sub_180268AE0(&v97);
		      v6 = renderGraph;
		      v9 = this;
		      v21 = v105;
		LABEL_53:
		      v88 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0x74u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !v6 )
		LABEL_88:
		        sub_1800D8250(v66, v65);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        (HGRenderGraphBuilder *)&v102,
		        v6,
		        (String *)"Foliage Occluder Set Final Mask",
		        &v101,
		        v88,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassData>);
		      *(_OWORD *)&v107.m_RenderPass = *(_OWORD *)&v102.m00;
		      *(_OWORD *)&v107.m_RenderGraph = *(_OWORD *)&v102.m01;
		      v97.m_Buffer = 0LL;
		      *(_QWORD *)&v97.m_Length = &v107;
		      try
		      {
		        if ( !v101 )
		          sub_1800D8250(v90, v89);
		        v101[3] = (Object)v21;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v107, 0, 0LL);
		        if ( !v101 )
		          sub_1800D8250(v92, v91);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		          (TextureHandle *)&v102,
		          &v107,
		          (TextureHandle *)&v101[3],
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v107,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::FoliageOccluderPassConstructor->static_fields->s_setFinalMaskPass,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::FoliageOccluderPassConstructor::FoliageOccluderPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v110 )
		      {
		        v97.m_Buffer = (Void *)v110->ex;
		        sub_180268AE0(&v97);
		        v9 = this;
		        goto LABEL_59;
		      }
		    }
		    sub_180268AE0(&v97);
		LABEL_59:
		    if ( v9->fields.m_renderFirstFrame )
		      v9->fields.m_renderFirstFrame = 0;
		    return;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3144, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v95, v94);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1158(
		    Patch,
		    (Object *)v9,
		    input,
		    output,
		    (Object *)v6,
		    (Object *)hgCamera,
		    0LL);
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BA9F58-0x0000000189BA9FAC
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::FoliageOccluderPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        FoliageOccluderPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3145, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3145, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184CDC890-0x0000000184CDC930
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::FoliageOccluderPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        FoliageOccluderPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  MaterialPropertyBlock *m_blitFoliageOccluderPropertyBlock; // rcx
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  RTHandle *m_foliageOccluderRenderTexture; // rcx
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  RTHandle *m_foliageOccluderMaskA; // rcx
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  RTHandle *m_foliageOccluderMaskB; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v20; // [rsp+20h] [rbp-8h]
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3146, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3146, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)this,
		        (Object *)renderGraph,
		        0LL);
		      return;
		    }
		LABEL_10:
		    sub_1800D8260(m_blitFoliageOccluderPropertyBlock, v5);
		  }
		  m_blitFoliageOccluderPropertyBlock = this->fields.m_blitFoliageOccluderPropertyBlock;
		  if ( !m_blitFoliageOccluderPropertyBlock )
		    goto LABEL_10;
		  UnityEngine::MaterialPropertyBlock::Clear(m_blitFoliageOccluderPropertyBlock, 1, 0LL);
		  m_foliageOccluderRenderTexture = this->fields.m_foliageOccluderRenderTexture;
		  if ( m_foliageOccluderRenderTexture )
		    UnityEngine::Rendering::RTHandle::Release(m_foliageOccluderRenderTexture, 0LL);
		  this->fields.m_foliageOccluderRenderTexture = 0LL;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v7, v8, v9, v20);
		  m_foliageOccluderMaskA = this->fields.m_foliageOccluderMaskA;
		  if ( m_foliageOccluderMaskA )
		    UnityEngine::Rendering::RTHandle::Release(m_foliageOccluderMaskA, 0LL);
		  this->fields.m_foliageOccluderMaskA = 0LL;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_foliageOccluderMaskA, v11, v12, v13, v21);
		  m_foliageOccluderMaskB = this->fields.m_foliageOccluderMaskB;
		  if ( m_foliageOccluderMaskB )
		    UnityEngine::Rendering::RTHandle::Release(m_foliageOccluderMaskB, 0LL);
		  this->fields.m_foliageOccluderMaskB = 0LL;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_foliageOccluderMaskB, v15, v16, v17, v22);
		}
		
	}
}
