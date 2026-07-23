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
	internal class DepthOfFieldPassConstructor : IPassConstructor // TypeDefIndex: 38221
	{
		// Fields
		private bool m_enable; // 0x10
		private TextureHandle m_currentSceneColorTexture; // 0x14
		private TextureHandle m_previousSceneColorTexture; // 0x24
		private TextureHandle m_currentDownSampleCoCTexture; // 0x34
		private TextureHandle m_previousDownSampleCoCTexture; // 0x44
		private bool m_fallbackPreviousFrame; // 0x54
		private ComputeShader m_shader; // 0x58
		private Material m_mobileMaterial; // 0x60
		private MaterialPropertyBlock m_mbp; // 0x68
		private static readonly RenderFunc<CircleDepthOfFieldPassData> s_circleDepthOfDieldHighQualityRenderFunc; // 0x00
		private static readonly RenderFunc<CircleDepthOfFieldPassData> s_circleDepthOfFieldLowFarNearRenderFunc; // 0x08
		private static readonly RenderFunc<CircleDepthOfFieldPassData> s_circleDepthOfFieldLowFarRenderFunc; // 0x10
	
		// Properties
		public bool enable { get => default; } // 0x0000000189B9AC14-0x0000000189B9AC60 
		// Boolean get_enable()
		bool HG::Rendering::Runtime::DepthOfFieldPassConstructor::get_enable(
		        DepthOfFieldPassConstructor *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3054, 0LL) )
		    return this->fields.m_enable;
		  Patch = IFix::WrappersManagerImpl::GetPatch(3054, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Nested types
		private enum GaussianPassID // TypeDefIndex: 38215
		{
			CoC = 0,
			Temporal = 1,
			Downsample = 2,
			Horizonal = 3,
			Vertical = 4,
			Apply = 5
		}
	
		internal struct PassInput // TypeDefIndex: 38216
		{
			// Fields
			internal HGDepthOfFieldQuality quality; // 0x00
			internal float depthOfFieldMaxRadius; // 0x04
			internal TextureHandle motionVectorTexture; // 0x08
			internal TextureHandle sceneColor; // 0x18
			internal TextureHandle sceneDepth; // 0x28
			public ScriptableRenderContext renderContext; // 0x38
		}
	
		internal struct PassOutput // TypeDefIndex: 38217
		{
			// Fields
			internal TextureHandle result; // 0x00
		}
	
		private class CircleDepthOfFieldPassData // TypeDefIndex: 38218
		{
			// Fields
			public bool usePhysicalCamera; // 0x10
			public HGDepthOfFieldQuality quality; // 0x14
			public Vector4 param0; // 0x18
			public Vector4 param1; // 0x28
			public Vector4 param2; // 0x38
			public Vector4 param3; // 0x48
			public Vector4 nearStartColor; // 0x58
			public Vector4 nearEndColor; // 0x68
			public Vector4 farStartColor; // 0x78
			public Vector4 farEndColor; // 0x88
			public Vector4 screenSize; // 0x98
			public Vector4 downsampleScreenSize; // 0xA8
			public Vector4 tileCoCScreenSize; // 0xB8
			public Vector2Int screenSizeInt; // 0xC8
			public Vector2Int downsampleScreenSizeInt; // 0xD0
			public Vector2Int tileCoCScreenSizeInt; // 0xD8
			public TextureHandle sceneColorTexture; // 0xE0
			public TextureHandle sceneDepthTexture; // 0xF0
			public TextureHandle motionVectorTexture; // 0x100
			public TextureHandle cocTexture; // 0x110
			public TextureHandle downsampleCoCTexture; // 0x120
			public TextureHandle tileCoCTexture; // 0x130
			public TextureHandle blurTileCoCTexture; // 0x140
			public TextureHandle oneComponentVeritcalTexture0; // 0x150
			public TextureHandle oneComponentVeritcalTexture1; // 0x160
			public TextureHandle oneComponentHorizontalTexture; // 0x170
			public TextureHandle oneComponentAlphaTexture0; // 0x180
			public TextureHandle twoComponentsVerticalTexture0; // 0x190
			public TextureHandle twoComponentsVerticalTexture1; // 0x1A0
			public TextureHandle twoComponentsVerticalTexture2; // 0x1B0
			public TextureHandle farHorizontalTexture; // 0x1C0
			public TextureHandle previousDownSampleSceneColorTexture; // 0x1D0
			public TextureHandle currentDownSampleSceneColorTexture; // 0x1E0
			public TextureHandle previousDownSampleCoCTexture; // 0x1F0
			public TextureHandle outputTexture; // 0x200
			public ComputeShader computeShader; // 0x210
			public CBHandle cbHandle; // 0x218
			public TextureHandle blurTexture0; // 0x230
			public TextureHandle blurTexture1; // 0x240
			public MaterialPropertyBlock mpb; // 0x250
			public Material material; // 0x258
	
			// Constructors
			public CircleDepthOfFieldPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		public struct DepthOfFieldData // TypeDefIndex: 38219
		{
			// Fields
			public Vector4 param0; // 0x00
			public Vector4 param1; // 0x10
			public Vector4 param2; // 0x20
			public Vector4 param3; // 0x30
			public Vector4 downsampleScreenSize; // 0x40
			public Vector4 tileCoCScreenSize; // 0x50
			public Vector4 nearStartColor; // 0x60
			public Vector4 nearEndColor; // 0x70
			public Vector4 farStartColor; // 0x80
			public Vector4 farEndColor; // 0x90
		}
	
		// Constructors
		public DepthOfFieldPassConstructor() {} // Dummy constructor
		public DepthOfFieldPassConstructor(HGRenderPipelineMaterialCollector materialCollector, HGRenderPathBase.HGRenderPathResources resources) {} // 0x0000000182EDB920-0x0000000182EDBA40
		// DepthOfFieldPassConstructor(HGRenderPipelineMaterialCollector, HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::DepthOfFieldPassConstructor(
		        DepthOfFieldPassConstructor *this,
		        HGRenderPipelineMaterialCollector *materialCollector,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  Type *v7; // rdx
		  __int64 v8; // rcx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  TextureHandle v11; // xmm0
		  HGRenderPipelineRuntimeResources *defaultResources; // rax
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  HGRenderPipelineRuntimeResources_ShaderResources *v14; // rax
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  MaterialPropertyBlock *v18; // rdi
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  TextureHandle v22; // [rsp+20h] [rbp-18h] BYREF
		  MethodInfo *v23; // [rsp+60h] [rbp+28h]
		
		  if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  this->fields.m_currentSceneColorTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v22, 0LL);
		  this->fields.m_previousSceneColorTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v22, 0LL);
		  this->fields.m_currentDownSampleCoCTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                                  &v22,
		                                                  0LL);
		  v11 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v22, 0LL);
		  defaultResources = resources->defaultResources;
		  this->fields.m_previousDownSampleCoCTexture = v11;
		  if ( !defaultResources
		    || (shaders = defaultResources->fields.shaders) == 0LL
		    || (this->fields.m_shader = shaders->fields.circleDepthOfFieldCS,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_shader, v7, v9, v10, *(MethodInfo **)&v22.handle),
		        !resources->defaultResources)
		    || (v14 = resources->defaultResources->fields.shaders) == 0LL
		    || !materialCollector
		    || (this->fields.m_mobileMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateMaterial(
		                                          materialCollector,
		                                          v14->fields.depthOfFieldMobilePS,
		                                          0,
		                                          0LL),
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_mobileMaterial, v15, v16, v17, *(MethodInfo **)&v22.handle),
		        (v18 = (MaterialPropertyBlock *)sub_1800368D0(TypeInfo::UnityEngine::MaterialPropertyBlock)) == 0LL) )
		  {
		    sub_1800D8260(v8, v7);
		  }
		  v18->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		  this->fields.m_mbp = v18;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_mbp, v19, v20, v21, v23);
		}
		
		static DepthOfFieldPassConstructor() {} // 0x0000000184B35690-0x0000000184B357F0
		// DepthOfFieldPassConstructor()
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::cctor(MethodInfo *method)
		{
		  struct DepthOfFieldPassConstructor_c__Class *v1; // rax
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
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		  MethodInfo *v23; // [rsp+20h] [rbp-8h]
		  MethodInfo *v24; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		  v6 = (Type__Class *)v3;
		  if ( !v3 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::__cctor_b__38_0,
		    0LL);
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor->static_fields;
		  static_fields->klass = v6;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor->static_fields,
		    static_fields,
		    v8,
		    v9,
		    v22);
		  v10 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9;
		  v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		  v12 = (MonitorData *)v11;
		  if ( !v11
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v11,
		          v10,
		          MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::__cctor_b__38_1,
		          0LL),
		        v13 = (Type *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor->static_fields,
		        v13->monitor = v12,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor->static_fields->s_circleDepthOfFieldLowFarNearRenderFunc,
		          v13,
		          v14,
		          v15,
		          v23),
		        v16 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9,
		        v17 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>),
		        (v18 = v17) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v17,
		    v16,
		    MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::__cctor_b__38_2,
		    0LL);
		  v19 = (Type *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor->static_fields;
		  v19->fields._impl.value = v18;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor->static_fields->s_circleDepthOfFieldLowFarRenderFunc,
		    v19,
		    v20,
		    v21,
		    v24);
		}
		
	
		// Methods
		private void PrepareSharedParams(ref PassInput input, HGCamera camera, CircleDepthOfFieldPassData passData) {} // 0x0000000189B99FBC-0x0000000189B9A6C4
		// Void PrepareSharedParams(DepthOfFieldPassConstructor+PassInput ByRef, HGCamera, DepthOfFieldPassConstructor+CircleDepthOfFieldPassData)
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::PrepareSharedParams(
		        DepthOfFieldPassConstructor *this,
		        DepthOfFieldPassConstructor_PassInput *input,
		        HGCamera *camera,
		        DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *passData,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  Camera *v10; // rcx
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  HGDepthOfField *m_depthOfField; // rbx
		  float v13; // xmm12_4
		  bool usePhysicalProperties; // al
		  Camera_GateFitMode__Enum gateFit; // eax
		  float v16; // xmm8_4
		  float focalLength; // xmm0_4
		  __int128 v18; // xmm1
		  float v19; // xmm7_4
		  __int128 v20; // xmm0
		  float v21; // xmm11_4
		  float v22; // xmm0_4
		  __int128 v23; // xmm1
		  __int128 v24; // xmm2
		  float v25; // xmm6_4
		  float focusDistance; // xmm10_4
		  float v27; // xmm7_4
		  float farClipPlane; // xmm0_4
		  float v29; // xmm11_4
		  float v30; // xmm0_4
		  float v31; // xmm6_4
		  float v32; // xmm0_4
		  float v33; // xmm13_4
		  float v34; // xmm0_4
		  float v35; // xmm8_4
		  float v36; // xmm6_4
		  float v37; // xmm0_4
		  float nearRadius; // xmm10_4
		  float nearFocusStart; // xmm15_4
		  float v40; // xmm0_4
		  float v41; // xmm8_4
		  float v42; // xmm6_4
		  float farRadius; // xmm7_4
		  float farFocusStart; // xmm13_4
		  float farFocusEnd; // xmm14_4
		  __int64 v46; // rbx
		  double v47; // xmm0_8
		  Vector4 v48; // xmm0
		  Vector4 v49; // xmm0
		  MethodInfo *v50; // r8
		  MethodInfo *v51; // r8
		  MethodInfo *v52; // r8
		  MethodInfo *v53; // r8
		  __int64 v54; // rax
		  float v55; // xmm1_4
		  float v56; // xmm2_4
		  char v57; // dl
		  __int64 v58; // rcx
		  int v59; // r8d
		  char v60; // dl
		  __int64 v61; // rcx
		  int v62; // r8d
		  __int64 v63; // rax
		  float m_X; // xmm1_4
		  __m128i v65; // xmm0
		  __int64 v66; // rax
		  char v67; // dl
		  __int64 v68; // rcx
		  int v69; // r8d
		  char v70; // dl
		  __int64 v71; // rcx
		  int v72; // r8d
		  Type *v73; // rdx
		  PropertyInfo_1 *v74; // r8
		  Int32__Array **v75; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *P3; // [rsp+28h] [rbp-E0h]
		  float nearFocusEnd; // [rsp+38h] [rbp-D0h]
		  Vector2Int v79; // [rsp+38h] [rbp-D0h]
		  Color v80; // [rsp+40h] [rbp-C8h] BYREF
		  Vector4 defaultNearStartColor; // [rsp+58h] [rbp-B0h] BYREF
		  HGPhysicalCamera v82[5]; // [rsp+68h] [rbp-A0h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3055, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3055, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1136(
		        Patch,
		        (Object *)this,
		        input,
		        (Object *)camera,
		        (Object *)passData,
		        0LL);
		      return;
		    }
		    goto LABEL_37;
		  }
		  if ( !camera )
		    goto LABEL_37;
		  volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(camera, 0LL);
		  if ( !volumeComponentsData )
		    goto LABEL_37;
		  m_depthOfField = volumeComponentsData->fields.m_depthOfField;
		  v13 = 0.5;
		  if ( !m_depthOfField )
		    goto LABEL_37;
		  if ( !m_depthOfField->fields.scale )
		    v13 = 1.0;
		  if ( m_depthOfField->fields.focusMode )
		  {
		    usePhysicalProperties = 0;
		  }
		  else
		  {
		    v10 = camera->fields.camera;
		    if ( !v10 )
		      goto LABEL_37;
		    usePhysicalProperties = UnityEngine::Camera::get_usePhysicalProperties(v10, 0LL);
		  }
		  if ( !passData )
		    goto LABEL_37;
		  passData->fields.usePhysicalCamera = usePhysicalProperties;
		  passData->fields.quality = input->quality;
		  v10 = camera->fields.camera;
		  if ( !v10 )
		    goto LABEL_37;
		  gateFit = UnityEngine::Camera::get_gateFit(v10, 0LL);
		  v10 = camera->fields.camera;
		  if ( gateFit == Camera_GateFitMode__Enum_Horizontal )
		  {
		    if ( !v10 )
		      goto LABEL_37;
		    v16 = (float)(0.5 / UnityEngine::Camera::get_sensorSize(v10, 0LL).x)
		        * (float)camera->fields._taauRTSize_k__BackingField.m_X;
		  }
		  else
		  {
		    if ( !v10 )
		      goto LABEL_37;
		    v16 = (float)(int)HIDWORD(*(_QWORD *)&camera->fields._taauRTSize_k__BackingField)
		        * (float)(0.5 / UnityEngine::Camera::get_sensorSize(v10, 0LL).x);
		  }
		  v10 = camera->fields.camera;
		  if ( !v10 )
		    goto LABEL_37;
		  focalLength = UnityEngine::Camera::get_focalLength(v10, 0LL);
		  v18 = *(_OWORD *)&camera->fields._physicalParameters_k__BackingField.m_BladeCount;
		  v19 = focalLength;
		  v82[0].m_Anamorphism = camera->fields._physicalParameters_k__BackingField.m_Anamorphism;
		  v20 = *(_OWORD *)&camera->fields._physicalParameters_k__BackingField.m_Iso;
		  *(_OWORD *)&v82[0].m_BladeCount = v18;
		  *(_OWORD *)&v82[0].m_Iso = v20;
		  *(float *)&v20 = HG::Rendering::Runtime::HGPhysicalCamera::get_aperture(v82, 0LL);
		  v10 = camera->fields.camera;
		  v21 = *(float *)&v20;
		  if ( !v10 )
		    goto LABEL_37;
		  v22 = UnityEngine::Camera::get_focalLength(v10, 0LL);
		  v23 = *(_OWORD *)&camera->fields._physicalParameters_k__BackingField.m_Iso;
		  v24 = *(_OWORD *)&camera->fields._physicalParameters_k__BackingField.m_BladeCount;
		  v82[0].m_Anamorphism = camera->fields._physicalParameters_k__BackingField.m_Anamorphism;
		  v25 = v22 / 1000.0;
		  *(_OWORD *)&v82[0].m_Iso = v23;
		  *(_OWORD *)&v82[0].m_BladeCount = v24;
		  focusDistance = HG::Rendering::Runtime::HGPhysicalCamera::get_focusDistance(v82, 0LL);
		  v10 = camera->fields.camera;
		  v27 = (float)((float)((float)(v19 / v21) * v25) * v16) / fmaxf(focusDistance - v25, 0.000001);
		  if ( !v10 )
		    goto LABEL_37;
		  farClipPlane = UnityEngine::Camera::get_farClipPlane(v10, 0LL);
		  v10 = camera->fields.camera;
		  v29 = (float)(1.0 - (float)(focusDistance / farClipPlane)) * v27;
		  if ( !v10 )
		    goto LABEL_37;
		  v30 = UnityEngine::Camera::get_farClipPlane(v10, 0LL);
		  v10 = camera->fields.camera;
		  v31 = v30;
		  if ( !v10
		    || (v32 = UnityEngine::Camera::get_nearClipPlane(v10, 0LL), v10 = camera->fields.camera, v33 = v32, !v10)
		    || (v34 = UnityEngine::Camera::get_farClipPlane(v10, 0LL), v10 = camera->fields.camera, v35 = v34, !v10) )
		  {
		LABEL_37:
		    sub_1800D8260(v10, v9);
		  }
		  v36 = (float)(v31 - v33) * (float)(v27 * focusDistance);
		  v37 = UnityEngine::Camera::get_nearClipPlane(v10, 0LL);
		  nearRadius = m_depthOfField->fields.nearRadius;
		  nearFocusStart = m_depthOfField->fields.nearFocusStart;
		  v40 = v37 * v35;
		  v41 = 0.0;
		  v42 = v36 / v40;
		  nearFocusEnd = m_depthOfField->fields.nearFocusEnd;
		  if ( nearRadius < 0.0 )
		  {
		    nearRadius = 0.0;
		  }
		  else if ( nearRadius > input->depthOfFieldMaxRadius )
		  {
		    nearRadius = input->depthOfFieldMaxRadius;
		  }
		  farRadius = m_depthOfField->fields.farRadius;
		  farFocusStart = m_depthOfField->fields.farFocusStart;
		  farFocusEnd = m_depthOfField->fields.farFocusEnd;
		  if ( farRadius < 0.0 )
		  {
		    farRadius = 0.0;
		  }
		  else if ( farRadius > input->depthOfFieldMaxRadius )
		  {
		    farRadius = input->depthOfFieldMaxRadius;
		  }
		  v46 = HIDWORD(*(_QWORD *)&camera->fields._sceneRTSize_k__BackingField);
		  *(Vector2Int *)&v80.r = camera->fields._sceneRTSize_k__BackingField;
		  defaultNearStartColor.x = v29;
		  defaultNearStartColor.y = v42;
		  defaultNearStartColor.z = v13;
		  v47 = sub_1803369A0();
		  defaultNearStartColor.w = *(float *)&v47;
		  v48 = defaultNearStartColor;
		  defaultNearStartColor.w = 0.0;
		  defaultNearStartColor.x = nearFocusStart;
		  passData->fields.param0 = v48;
		  defaultNearStartColor.y = nearFocusEnd;
		  defaultNearStartColor.z = (float)((float)(int)v46 * nearRadius) / 1440.0;
		  v49 = defaultNearStartColor;
		  defaultNearStartColor.w = 0.0;
		  defaultNearStartColor.x = farFocusStart;
		  passData->fields.param1 = v49;
		  defaultNearStartColor.y = farFocusEnd;
		  defaultNearStartColor.z = (float)((float)SLODWORD(v80.g) * farRadius) / 1440.0;
		  passData->fields.param2 = defaultNearStartColor;
		  if ( camera->fields.prevTransformReset )
		    v41 = 1.0;
		  defaultNearStartColor.x = 0.0;
		  defaultNearStartColor.z = 0.0;
		  defaultNearStartColor.w = 0.0;
		  defaultNearStartColor.y = v41;
		  passData->fields.param3 = (Vector4)*(unsigned __int64 *)&defaultNearStartColor.x;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDepthOfField);
		  defaultNearStartColor = (Vector4)TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultNearStartColor;
		  passData->fields.nearStartColor = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                                &v80,
		                                                                                &defaultNearStartColor,
		                                                                                v50));
		  defaultNearStartColor = (Vector4)TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultNearEndColor;
		  passData->fields.nearEndColor = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                              &v80,
		                                                                              &defaultNearStartColor,
		                                                                              v51));
		  defaultNearStartColor = (Vector4)TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultFarStartColor;
		  passData->fields.farStartColor = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                               &v80,
		                                                                               &defaultNearStartColor,
		                                                                               v52));
		  defaultNearStartColor = (Vector4)TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultFarEndColor;
		  passData->fields.farEndColor = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                             &v80,
		                                                                             &defaultNearStartColor,
		                                                                             v53));
		  passData->fields.screenSize = (Vector4)_mm_loadu_si128((const __m128i *)&camera->fields._sceneRTSizeParam_k__BackingField);
		  passData->fields.screenSizeInt = camera->fields._sceneRTSize_k__BackingField;
		  v54 = HIDWORD(*(_QWORD *)&camera->fields._sceneRTSize_k__BackingField);
		  v55 = (float)(int)HIDWORD(*(_QWORD *)&camera->fields._sceneRTSize_k__BackingField);
		  defaultNearStartColor.x = (float)camera->fields._sceneRTSize_k__BackingField.m_X * v13;
		  v56 = 1.0 / (float)camera->fields._sceneRTSize_k__BackingField.m_X;
		  defaultNearStartColor.y = v55 * v13;
		  defaultNearStartColor.z = v56 / v13;
		  defaultNearStartColor.w = (float)(1.0 / (float)(int)v54) / v13;
		  passData->fields.downsampleScreenSize = defaultNearStartColor;
		  v79.m_X = sub_1834464B0(v58, v57, v59);
		  v79.m_Y = sub_1834464B0(v61, v60, v62);
		  passData->fields.downsampleScreenSizeInt = v79;
		  v63 = HIDWORD(*(_QWORD *)&camera->fields._sceneRTSize_k__BackingField);
		  m_X = (float)camera->fields._sceneRTSize_k__BackingField.m_X;
		  defaultNearStartColor.x = m_X * 0.125;
		  v65 = _mm_cvtsi32_si128(v63);
		  v66 = HIDWORD(*(_QWORD *)&camera->fields._sceneRTSize_k__BackingField);
		  defaultNearStartColor.z = (float)(1.0 / m_X) * 8.0;
		  defaultNearStartColor.y = _mm_cvtepi32_ps(v65).m128_f32[0] * 0.125;
		  defaultNearStartColor.w = (float)(1.0 / (float)(int)v66) * 8.0;
		  passData->fields.tileCoCScreenSize = defaultNearStartColor;
		  v79.m_X = sub_1834464B0(v68, v67, v69);
		  v79.m_Y = sub_1834464B0(v71, v70, v72);
		  passData->fields.tileCoCScreenSizeInt = v79;
		  passData->fields.computeShader = this->fields.m_shader;
		  sub_18002D1B0((SingleFieldAccessor *)&passData->fields.computeShader, v73, v74, v75, P3);
		}
		
		private void AllocateCoCTexture(CircleDepthOfFieldPassData passData, HGRenderGraphBuilder builder) {} // 0x0000000189B94710-0x0000000189B9485C
		// Void AllocateCoCTexture(DepthOfFieldPassConstructor+CircleDepthOfFieldPassData, HGRenderGraphBuilder)
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateCoCTexture(
		        DepthOfFieldPassConstructor *this,
		        DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *passData,
		        HGRenderGraphBuilder *builder,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  int v11; // r9d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v13; // xmm1
		  MethodInfo *v14; // [rsp+28h] [rbp-E0h]
		  _BYTE v15[104]; // [rsp+30h] [rbp-D8h] BYREF
		  HGRenderGraphBuilder v16; // [rsp+98h] [rbp-70h] BYREF
		  TextureDesc v17; // [rsp+B8h] [rbp-50h] BYREF
		
		  sub_18033B9D0(&v15[8], 0LL, 96LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(3056, 0LL) )
		  {
		    if ( passData )
		    {
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		        (TextureDesc *)&v15[8],
		        passData->fields.screenSizeInt.m_X,
		        passData->fields.screenSizeInt.m_Y,
		        0LL);
		      *(_QWORD *)&v15[64] = "Depth Of Field CoC";
		      v15[40] = 1;
		      *(_DWORD *)&v15[24] = 45;
		      sub_18002D1B0((SingleFieldAccessor *)&v15[64], v9, v10, (Int32__Array **)1, v14);
		      *(_DWORD *)&v15[32] = v11;
		      *(_DWORD *)&v15[28] = v11;
		      v17 = *(TextureDesc *)&v15[8];
		      passData->fields.cocTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                                       (TextureHandle *)&v16,
		                                       builder,
		                                       &v17,
		                                       0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3056, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  v13 = *(_OWORD *)&builder->m_RenderGraph;
		  *(_OWORD *)&v16.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		  *(_OWORD *)&v16.m_RenderGraph = v13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_766(Patch, (Object *)this, (Object *)passData, &v16, 0LL);
		}
		
		private void AllocateTransientDownsampleCoCTexture(CircleDepthOfFieldPassData passData, HGRenderGraphBuilder builder) {} // 0x0000000189B94DEC-0x0000000189B94F38
		// Void AllocateTransientDownsampleCoCTexture(DepthOfFieldPassConstructor+CircleDepthOfFieldPassData, HGRenderGraphBuilder)
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateTransientDownsampleCoCTexture(
		        DepthOfFieldPassConstructor *this,
		        DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *passData,
		        HGRenderGraphBuilder *builder,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  int v11; // r9d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v13; // xmm1
		  MethodInfo *v14; // [rsp+28h] [rbp-E0h]
		  _BYTE v15[104]; // [rsp+30h] [rbp-D8h] BYREF
		  HGRenderGraphBuilder v16; // [rsp+98h] [rbp-70h] BYREF
		  TextureDesc v17; // [rsp+B8h] [rbp-50h] BYREF
		
		  sub_18033B9D0(&v15[8], 0LL, 96LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(3057, 0LL) )
		  {
		    if ( passData )
		    {
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		        (TextureDesc *)&v15[8],
		        passData->fields.downsampleScreenSizeInt.m_X,
		        passData->fields.downsampleScreenSizeInt.m_Y,
		        0LL);
		      *(_QWORD *)&v15[64] = "Depth Of Field CoC Downsample";
		      v15[40] = 1;
		      *(_DWORD *)&v15[24] = 45;
		      sub_18002D1B0((SingleFieldAccessor *)&v15[64], v9, v10, (Int32__Array **)1, v14);
		      *(_DWORD *)&v15[32] = v11;
		      *(_DWORD *)&v15[28] = v11;
		      v17 = *(TextureDesc *)&v15[8];
		      passData->fields.downsampleCoCTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                                                 (TextureHandle *)&v16,
		                                                 builder,
		                                                 &v17,
		                                                 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3057, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  v13 = *(_OWORD *)&builder->m_RenderGraph;
		  *(_OWORD *)&v16.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		  *(_OWORD *)&v16.m_RenderGraph = v13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_766(Patch, (Object *)this, (Object *)passData, &v16, 0LL);
		}
		
		private void AllocateTemporalColorTextures(ref PassInput input, CircleDepthOfFieldPassData passData, HGRenderGraph renderGraph, HGRenderGraphBuilder builder) {} // 0x0000000189B94B14-0x0000000189B94DEC
		// Void AllocateTemporalColorTextures(DepthOfFieldPassConstructor+PassInput ByRef, DepthOfFieldPassConstructor+CircleDepthOfFieldPassData, HGRenderGraph, HGRenderGraphBuilder)
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateTemporalColorTextures(
		        DepthOfFieldPassConstructor *this,
		        DepthOfFieldPassConstructor_PassInput *input,
		        DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *passData,
		        HGRenderGraph *renderGraph,
		        HGRenderGraphBuilder *builder,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  bool IsValid; // al
		  TextureHandle *p_sceneColor; // r8
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  TextureHandle cocTexture; // xmm0
		  __int128 v21; // xmm1
		  MethodInfo *v22; // [rsp+20h] [rbp-E0h]
		  MethodInfo *v23; // [rsp+20h] [rbp-E0h]
		  HGRenderGraphBuilder v24; // [rsp+40h] [rbp-C0h] BYREF
		  TextureDesc v25; // [rsp+60h] [rbp-A0h] BYREF
		  TextureDesc v26; // [rsp+C0h] [rbp-40h] BYREF
		  TextureDesc v27; // [rsp+120h] [rbp+20h] BYREF
		
		  sub_18033B9D0(&v25, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3058, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3058, 0LL);
		    if ( Patch )
		    {
		      v21 = *(_OWORD *)&builder->m_RenderGraph;
		      *(_OWORD *)&v24.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		      *(_OWORD *)&v24.m_RenderGraph = v21;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1137(
		        Patch,
		        (Object *)this,
		        input,
		        (Object *)passData,
		        (Object *)renderGraph,
		        &v24,
		        0LL);
		      return;
		    }
		LABEL_11:
		    sub_1800D8260(Patch, v10);
		  }
		  if ( !passData )
		    goto LABEL_11;
		  HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		    &v25,
		    passData->fields.downsampleScreenSizeInt.m_X,
		    passData->fields.downsampleScreenSizeInt.m_Y,
		    0LL);
		  v25.name = (String *)"Depth Of Field Color Downsample";
		  v25.colorFormat = 74;
		  v25.enableRandomWrite = 1;
		  sub_18002D1B0((SingleFieldAccessor *)&v25.name, v12, v13, v14, v22);
		  v25.wrapMode = 1;
		  v25.filterMode = 1;
		  v26 = v25;
		  if ( !renderGraph )
		    goto LABEL_11;
		  this->fields.m_currentSceneColorTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                               (TextureHandle *)&v24,
		                                               renderGraph,
		                                               &v26,
		                                               0LL);
		  passData->fields.currentDownSampleSceneColorTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                                                           (TextureHandle *)&v24,
		                                                           builder,
		                                                           &this->fields.m_currentSceneColorTexture,
		                                                           0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  IsValid = HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_previousSceneColorTexture, 0LL);
		  p_sceneColor = &input->sceneColor;
		  if ( IsValid )
		    p_sceneColor = &this->fields.m_previousSceneColorTexture;
		  passData->fields.previousDownSampleSceneColorTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                                                            (TextureHandle *)&v24,
		                                                            builder,
		                                                            p_sceneColor,
		                                                            0LL);
		  HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		    &v25,
		    passData->fields.downsampleScreenSizeInt.m_X,
		    passData->fields.downsampleScreenSizeInt.m_Y,
		    0LL);
		  v25.name = (String *)"Depth Of Field CoC Downsample Temporal";
		  v25.colorFormat = 45;
		  v25.enableRandomWrite = 1;
		  sub_18002D1B0((SingleFieldAccessor *)&v25.name, v17, v18, v19, v23);
		  v25.wrapMode = 1;
		  v25.filterMode = 1;
		  v27 = v25;
		  this->fields.m_currentDownSampleCoCTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                  (TextureHandle *)&v24,
		                                                  renderGraph,
		                                                  &v27,
		                                                  0LL);
		  passData->fields.downsampleCoCTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                                             (TextureHandle *)&v24,
		                                             builder,
		                                             &this->fields.m_currentDownSampleCoCTexture,
		                                             0LL);
		  sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		  if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_previousDownSampleCoCTexture, 0LL) )
		    cocTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                    (TextureHandle *)&v24,
		                    builder,
		                    &this->fields.m_previousDownSampleCoCTexture,
		                    0LL);
		  else
		    cocTexture = passData->fields.cocTexture;
		  passData->fields.previousDownSampleCoCTexture = cocTexture;
		}
		
		private void AllocateFarHorizontalTexture(CircleDepthOfFieldPassData passData, HGRenderGraphBuilder builder) {} // 0x0000000189B9485C-0x0000000189B949A8
		// Void AllocateFarHorizontalTexture(DepthOfFieldPassConstructor+CircleDepthOfFieldPassData, HGRenderGraphBuilder)
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateFarHorizontalTexture(
		        DepthOfFieldPassConstructor *this,
		        DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *passData,
		        HGRenderGraphBuilder *builder,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  int v11; // r9d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v13; // xmm1
		  MethodInfo *v14; // [rsp+28h] [rbp-E0h]
		  _BYTE v15[104]; // [rsp+30h] [rbp-D8h] BYREF
		  HGRenderGraphBuilder v16; // [rsp+98h] [rbp-70h] BYREF
		  TextureDesc v17; // [rsp+B8h] [rbp-50h] BYREF
		
		  sub_18033B9D0(&v15[8], 0LL, 96LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(3059, 0LL) )
		  {
		    if ( passData )
		    {
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		        (TextureDesc *)&v15[8],
		        passData->fields.downsampleScreenSizeInt.m_X,
		        passData->fields.downsampleScreenSizeInt.m_Y,
		        0LL);
		      *(_QWORD *)&v15[64] = "Depth Of Field Far Horizontal";
		      v15[40] = 1;
		      *(_DWORD *)&v15[24] = 74;
		      sub_18002D1B0((SingleFieldAccessor *)&v15[64], v9, v10, (Int32__Array **)1, v14);
		      *(_DWORD *)&v15[32] = v11;
		      *(_DWORD *)&v15[28] = v11;
		      v17 = *(TextureDesc *)&v15[8];
		      passData->fields.farHorizontalTexture = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                                                 (TextureHandle *)&v16,
		                                                 builder,
		                                                 &v17,
		                                                 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3059, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  v13 = *(_OWORD *)&builder->m_RenderGraph;
		  *(_OWORD *)&v16.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		  *(_OWORD *)&v16.m_RenderGraph = v13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_766(Patch, (Object *)this, (Object *)passData, &v16, 0LL);
		}
		
		private void AllocateOneComponentVerticalTextures(CircleDepthOfFieldPassData passData, HGRenderGraphBuilder builder) {} // 0x0000000189B949A8-0x0000000189B94B14
		// Void AllocateOneComponentVerticalTextures(DepthOfFieldPassConstructor+CircleDepthOfFieldPassData, HGRenderGraphBuilder)
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateOneComponentVerticalTextures(
		        DepthOfFieldPassConstructor *this,
		        DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *passData,
		        HGRenderGraphBuilder *builder,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  int32_t v11; // r9d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v13; // xmm1
		  MethodInfo *v14; // [rsp+28h] [rbp-E0h]
		  HGRenderGraphBuilder v15; // [rsp+38h] [rbp-D0h] BYREF
		  TextureDesc v16; // [rsp+58h] [rbp-B0h] BYREF
		  TextureDesc v17; // [rsp+B8h] [rbp-50h] BYREF
		
		  sub_18033B9D0(&v16, 0LL, 96LL);
		  if ( !IFix::WrappersManagerImpl::IsPatched(3060, 0LL) )
		  {
		    if ( passData )
		    {
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		        &v16,
		        passData->fields.downsampleScreenSizeInt.m_X,
		        passData->fields.downsampleScreenSizeInt.m_Y,
		        0LL);
		      v16.name = (String *)"Depth Of Field Color One Component";
		      v16.enableRandomWrite = 1;
		      v16.colorFormat = 48;
		      sub_18002D1B0((SingleFieldAccessor *)&v16.name, v9, v10, (Int32__Array **)1, v14);
		      v16.wrapMode = v11;
		      v16.filterMode = v11;
		      v17 = v16;
		      passData->fields.oneComponentVeritcalTexture0 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                                                         (TextureHandle *)&v15,
		                                                         builder,
		                                                         &v17,
		                                                         0LL);
		      passData->fields.oneComponentVeritcalTexture1 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                                                         (TextureHandle *)&v15,
		                                                         builder,
		                                                         &v17,
		                                                         0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3060, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  v13 = *(_OWORD *)&builder->m_RenderGraph;
		  *(_OWORD *)&v15.m_RenderPass = *(_OWORD *)&builder->m_RenderPass;
		  *(_OWORD *)&v15.m_RenderGraph = v13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_766(Patch, (Object *)this, (Object *)passData, &v15, 0LL);
		}
		
		private void ConstructCircleDepthOfFieldHighFarNear(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189B94F38-0x0000000189B965C8
		// Void ConstructCircleDepthOfFieldHighFarNear(DepthOfFieldPassConstructor+PassInput ByRef, DepthOfFieldPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::ConstructCircleDepthOfFieldHighFarNear(
		        DepthOfFieldPassConstructor *this,
		        DepthOfFieldPassConstructor_PassInput *input,
		        DepthOfFieldPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  Object *v9; // r15
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  Object *P3; // rdi
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  __int64 v17; // rdx
		  __int64 v18; // rcx
		  HGDepthOfField *m_depthOfField; // r15
		  int v20; // eax
		  Camera *camera; // rsi
		  unsigned __int8 (__fastcall *v22)(Camera *); // rax
		  Camera *v23; // rsi
		  __int64 (__fastcall *v24)(Camera *); // rax
		  int v25; // eax
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  Camera *v28; // rsi
		  void (__fastcall *v29)(Camera *, Vector4 *); // rax
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  __m128i v32; // xmm7
		  void (__fastcall *v33)(Camera *, Vector4 *); // rax
		  float v34; // xmm7_4
		  Camera *v35; // rsi
		  double (__fastcall *v36)(Camera *); // rax
		  double v37; // xmm0_8
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  float v40; // xmm8_4
		  Camera *v41; // rsi
		  double (__fastcall *v42)(Camera *); // rax
		  double v43; // xmm0_8
		  float v44; // xmm6_4
		  float focusDistance; // xmm10_4
		  __int64 v46; // rdx
		  __int64 v47; // rcx
		  float v48; // xmm6_4
		  Camera *v49; // r14
		  float (__fastcall *v50)(Camera *); // rax
		  __int64 v51; // rdx
		  __int64 v52; // rcx
		  float v53; // xmm7_4
		  Camera *v54; // r14
		  double (__fastcall *v55)(Camera *); // rax
		  __int64 v56; // rdx
		  __int64 v57; // rcx
		  double v58; // xmm0_8
		  float v59; // xmm8_4
		  Camera *v60; // r14
		  double (__fastcall *v61)(Camera *); // rax
		  __int64 v62; // rdx
		  __int64 v63; // rcx
		  double v64; // xmm0_8
		  float v65; // xmm11_4
		  Camera *v66; // r14
		  double (__fastcall *v67)(Camera *); // rax
		  __int64 v68; // rdx
		  __int64 v69; // rcx
		  double v70; // xmm0_8
		  Camera *v71; // rsi
		  float (__fastcall *v72)(Camera *); // rax
		  float v73; // xmm8_4
		  float nearFocusStart; // xmm13_4
		  float nearFocusEnd; // xmm14_4
		  unsigned int v76; // xmm6_4
		  float v77; // xmm15_4
		  float farFocusStart; // xmm9_4
		  float farFocusEnd; // xmm10_4
		  float v80; // xmm11_4
		  double v81; // xmm0_8
		  unsigned int v82; // xmm3_4
		  unsigned int v83; // xmm2_4
		  float v84; // xmm7_4
		  float v85; // xmm4_4
		  __int64 v86; // rcx
		  float v87; // xmm2_4
		  float v88; // xmm1_4
		  int v89; // r8d
		  unsigned int v90; // esi
		  __int64 v91; // rcx
		  int v92; // r8d
		  unsigned int v93; // eax
		  float v94; // xmm4_4
		  __int64 v95; // rcx
		  float v96; // xmm2_4
		  float v97; // xmm12_4
		  int v98; // r8d
		  unsigned int v99; // ebx
		  __int64 v100; // rcx
		  int v101; // r8d
		  unsigned int v102; // eax
		  unsigned __int64 v103; // rdi
		  unsigned __int64 v104; // rdx
		  char v105; // di
		  signed __int64 v106; // rtt
		  ILFixDynamicMethodWrapper_2 *v107; // rax
		  __int64 v108; // rdx
		  __int64 v109; // rcx
		  Object *v110; // rbx
		  __int64 v111; // rdx
		  __int64 v112; // rcx
		  TextureHandle v113; // xmm0
		  Object *v114; // rbx
		  __int64 v115; // rdx
		  __int64 v116; // rcx
		  TextureHandle v117; // xmm0
		  Object *v118; // rbx
		  __int64 v119; // rdx
		  __int64 v120; // rcx
		  TextureHandle v121; // xmm0
		  __int64 v122; // rdx
		  __int64 v123; // rcx
		  int32_t monitor; // edi
		  int32_t monitor_high; // ebx
		  __int128 v126; // xmm2
		  __int128 v127; // xmm3
		  Color clearColor; // xmm4
		  unsigned __int64 v129; // r8
		  signed __int64 v130; // rtt
		  Object *v131; // rbx
		  __int64 v132; // rdx
		  __int64 v133; // rcx
		  TextureHandle v134; // xmm0
		  Object *v135; // rbx
		  __int64 v136; // rdx
		  __int64 v137; // rcx
		  TextureHandle v138; // xmm0
		  __int64 v139; // rdx
		  __int64 v140; // rcx
		  int32_t klass; // edi
		  int32_t klass_high; // ebx
		  __int128 v143; // xmm2
		  __int128 v144; // xmm3
		  Color v145; // xmm4
		  unsigned __int64 v146; // r8
		  signed __int64 v147; // rtt
		  Object *v148; // rbx
		  __int64 v149; // rdx
		  __int64 v150; // rcx
		  TextureHandle v151; // xmm0
		  int32_t v152; // edi
		  int32_t v153; // ebx
		  __int128 v154; // xmm2
		  __int128 v155; // xmm3
		  Color v156; // xmm4
		  unsigned __int64 v157; // r8
		  signed __int64 v158; // rtt
		  Object *v159; // rbx
		  __int64 v160; // rdx
		  __int64 v161; // rcx
		  TextureHandle v162; // xmm0
		  int32_t v163; // edi
		  int32_t v164; // ebx
		  __int128 v165; // xmm2
		  __int128 v166; // xmm3
		  Color v167; // xmm4
		  unsigned __int64 v168; // r8
		  signed __int64 v169; // rtt
		  Object *v170; // rbx
		  __int64 v171; // rdx
		  __int64 v172; // rcx
		  TextureHandle v173; // xmm0
		  Object *v174; // rbx
		  __int64 v175; // rdx
		  __int64 v176; // rcx
		  TextureHandle v177; // xmm0
		  Object *v178; // rbx
		  __int64 v179; // rdx
		  __int64 v180; // rcx
		  TextureHandle v181; // xmm0
		  Object *v182; // rbx
		  __int64 v183; // rdx
		  __int64 v184; // rcx
		  TextureHandle v185; // xmm0
		  __int64 v186; // rdx
		  __int64 v187; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v189; // rdx
		  __int64 v190; // rcx
		  __int64 v191; // rax
		  __int64 v192; // rax
		  __int64 v193; // rax
		  __int64 v194; // rax
		  __int64 v195; // rax
		  __int64 v196; // rax
		  __int64 v197; // rax
		  __int64 v198; // rax
		  __int64 v199; // rax
		  __int64 v200; // rax
		  __int64 v201; // rax
		  Vector4 defaultNearStartColor; // [rsp+40h] [rbp-548h] BYREF
		  Object *v203; // [rsp+50h] [rbp-538h] BYREF
		  HGRenderGraphBuilder v204; // [rsp+58h] [rbp-530h] BYREF
		  __int128 v205; // [rsp+80h] [rbp-508h] BYREF
		  __int128 v206; // [rsp+90h] [rbp-4F8h]
		  __int128 v207; // [rsp+A0h] [rbp-4E8h]
		  __int128 v208; // [rsp+B0h] [rbp-4D8h] BYREF
		  __int128 v209; // [rsp+C0h] [rbp-4C8h]
		  Color v210; // [rsp+D0h] [rbp-4B8h]
		  float v211; // [rsp+E0h] [rbp-4A8h]
		  HGRenderGraphBuilder v212; // [rsp+F0h] [rbp-498h] BYREF
		  HGPhysicalCamera physicalParameters_k__BackingField; // [rsp+110h] [rbp-478h] BYREF
		  _QWORD v214[2]; // [rsp+140h] [rbp-448h] BYREF
		  Il2CppExceptionWrapper *v215; // [rsp+150h] [rbp-438h] BYREF
		  TextureDesc v216; // [rsp+160h] [rbp-428h] BYREF
		  TextureDesc v217; // [rsp+1C0h] [rbp-3C8h] BYREF
		  TextureDesc v218; // [rsp+220h] [rbp-368h] BYREF
		  TextureDesc v219; // [rsp+280h] [rbp-308h] BYREF
		  TextureDesc v220; // [rsp+2E0h] [rbp-2A8h] BYREF
		  TextureDesc v221; // [rsp+340h] [rbp-248h] BYREF
		  TextureDesc v222; // [rsp+3A0h] [rbp-1E8h] BYREF
		  TextureDesc v223; // [rsp+400h] [rbp-188h] BYREF
		  TextureDesc v224; // [rsp+460h] [rbp-128h] BYREF
		
		  v9 = (Object *)this;
		  memset(&v204, 0, sizeof(v204));
		  v203 = 0LL;
		  sub_18033B9D0(&v218, 0LL, 96LL);
		  sub_18033B9D0(&v217, 0LL, 96LL);
		  sub_18033B9D0(&v205, 0LL, 96LL);
		  sub_18033B9D0(&v221, 0LL, 96LL);
		  sub_18033B9D0(&v223, 0LL, 96LL);
		  sub_18033B9D0(&v216, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3061, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3061, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v190, v189);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1138(
		      Patch,
		      v9,
		      input,
		      output,
		      (Object *)renderGraph,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else
		  {
		    v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0xA9u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    v204 = *(HGRenderGraphBuilder *)sub_1808AF1C4(
		                                      (unsigned int)&physicalParameters_k__BackingField,
		                                      (_DWORD)renderGraph,
		                                      (unsigned int)"Circle Depth of Field High",
		                                      (unsigned int)&v203,
		                                      (__int64)v10);
		    v214[0] = 0LL;
		    v214[1] = &v204;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v204, 0, 0LL);
		      P3 = v203;
		      memset(&physicalParameters_k__BackingField, 0, sizeof(physicalParameters_k__BackingField));
		      if ( IFix::WrappersManagerImpl::IsPatched(3055, 0LL) )
		      {
		        v107 = IFix::WrappersManagerImpl::GetPatch(3055, 0LL);
		        if ( !v107 )
		          sub_1800D8250(v109, v108);
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1136(v107, v9, input, (Object *)hgCamera, P3, 0LL);
		      }
		      else
		      {
		        if ( !hgCamera )
		          sub_1800D8250(v15, v14);
		        volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		        if ( !volumeComponentsData )
		          sub_1800D8250(v18, v17);
		        m_depthOfField = volumeComponentsData->fields.m_depthOfField;
		        v211 = 0.5;
		        if ( !m_depthOfField )
		          sub_1800D8250(v18, v17);
		        if ( !m_depthOfField->fields.scale )
		          v211 = 1.0;
		        if ( m_depthOfField->fields.focusMode )
		        {
		          v20 = 0;
		        }
		        else
		        {
		          camera = hgCamera->fields.camera;
		          if ( !camera )
		            sub_1800D8250(v18, v17);
		          v22 = (unsigned __int8 (__fastcall *)(Camera *))qword_18F36F160;
		          if ( !qword_18F36F160 )
		          {
		            v22 = (unsigned __int8 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_usePhysicalProperties()");
		            if ( !v22 )
		            {
		              v191 = sub_1802EE1B8("UnityEngine.Camera::get_usePhysicalProperties()");
		              sub_18007E1B0(v191, 0LL);
		            }
		            qword_18F36F160 = (__int64)v22;
		          }
		          v20 = v22(camera);
		        }
		        if ( !P3 )
		          sub_1800D8250(v18, v17);
		        LOBYTE(P3[1].klass) = v20 != 0;
		        HIDWORD(P3[1].klass) = input->quality;
		        v23 = hgCamera->fields.camera;
		        if ( !v23 )
		          sub_1800D8250(v18, v17);
		        v24 = (__int64 (__fastcall *)(Camera *))qword_18F36F170;
		        if ( !qword_18F36F170 )
		        {
		          v24 = (__int64 (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_gateFit()");
		          if ( !v24 )
		          {
		            v192 = sub_1802EE1B8("UnityEngine.Camera::get_gateFit()");
		            sub_18007E1B0(v192, 0LL);
		          }
		          qword_18F36F170 = (__int64)v24;
		        }
		        v25 = v24(v23);
		        v28 = hgCamera->fields.camera;
		        if ( v25 == 2 )
		        {
		          if ( !v28 )
		            sub_1800D8250(v27, v26);
		          *(_QWORD *)&defaultNearStartColor.x = 0LL;
		          v33 = (void (__fastcall *)(Camera *, Vector4 *))qword_18F36F1F0;
		          if ( !qword_18F36F1F0 )
		          {
		            v33 = (void (__fastcall *)(Camera *, Vector4 *))il2cpp_resolve_icall_1(
		                                                              "UnityEngine.Camera::get_sensorSize_Injected(UnityEngine.Vector2&)");
		            if ( !v33 )
		            {
		              v194 = sub_1802EE1B8("UnityEngine.Camera::get_sensorSize_Injected(UnityEngine.Vector2&)");
		              sub_18007E1B0(v194, 0LL);
		            }
		            qword_18F36F1F0 = (__int64)v33;
		          }
		          v33(v28, &defaultNearStartColor);
		          v32 = _mm_cvtsi32_si128(hgCamera->fields._taauRTSize_k__BackingField.m_X);
		        }
		        else
		        {
		          if ( !v28 )
		            sub_1800D8250(v27, v26);
		          *(_QWORD *)&defaultNearStartColor.x = 0LL;
		          v29 = (void (__fastcall *)(Camera *, Vector4 *))qword_18F36F1F0;
		          if ( !qword_18F36F1F0 )
		          {
		            v29 = (void (__fastcall *)(Camera *, Vector4 *))il2cpp_resolve_icall_1(
		                                                              "UnityEngine.Camera::get_sensorSize_Injected(UnityEngine.Vector2&)");
		            if ( !v29 )
		            {
		              v193 = sub_1802EE1B8("UnityEngine.Camera::get_sensorSize_Injected(UnityEngine.Vector2&)");
		              sub_18007E1B0(v193, 0LL);
		            }
		            qword_18F36F1F0 = (__int64)v29;
		          }
		          v29(v28, &defaultNearStartColor);
		          v32 = _mm_cvtsi32_si128(HIDWORD(*(_QWORD *)&hgCamera->fields._taauRTSize_k__BackingField));
		        }
		        v34 = _mm_cvtepi32_ps(v32).m128_f32[0] * (float)(0.5 / defaultNearStartColor.x);
		        v35 = hgCamera->fields.camera;
		        if ( !v35 )
		          sub_1800D8250(v31, v30);
		        v36 = (double (__fastcall *)(Camera *))qword_18F3A8A28;
		        if ( !qword_18F3A8A28 )
		        {
		          v36 = (double (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_focalLength()");
		          if ( !v36 )
		          {
		            v195 = sub_1802EE1B8("UnityEngine.Camera::get_focalLength()");
		            sub_18007E1B0(v195, 0LL);
		          }
		          qword_18F3A8A28 = (__int64)v36;
		        }
		        v37 = v36(v35);
		        physicalParameters_k__BackingField = hgCamera->fields._physicalParameters_k__BackingField;
		        v40 = *(float *)&v37
		            / HG::Rendering::Runtime::HGPhysicalCamera::get_aperture(&physicalParameters_k__BackingField, 0LL);
		        v41 = hgCamera->fields.camera;
		        if ( !v41 )
		          sub_1800D8250(v39, v38);
		        v42 = (double (__fastcall *)(Camera *))qword_18F3A8A28;
		        if ( !qword_18F3A8A28 )
		        {
		          v42 = (double (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_focalLength()");
		          if ( !v42 )
		          {
		            v196 = sub_1802EE1B8("UnityEngine.Camera::get_focalLength()");
		            sub_18007E1B0(v196, 0LL);
		          }
		          qword_18F3A8A28 = (__int64)v42;
		        }
		        v43 = v42(v41);
		        v44 = *(float *)&v43 / 1000.0;
		        physicalParameters_k__BackingField = hgCamera->fields._physicalParameters_k__BackingField;
		        focusDistance = HG::Rendering::Runtime::HGPhysicalCamera::get_focusDistance(
		                          &physicalParameters_k__BackingField,
		                          0LL);
		        v48 = (float)((float)(v44 * v40) * v34) / UnityEngine::Mathf::Max(focusDistance - v44, 0.000001, 0LL);
		        v49 = hgCamera->fields.camera;
		        if ( !v49 )
		          sub_1800D8250(v47, v46);
		        v50 = (float (__fastcall *)(Camera *))qword_18F36F0C0;
		        if ( !qword_18F36F0C0 )
		        {
		          v50 = (float (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_farClipPlane()");
		          if ( !v50 )
		          {
		            v197 = sub_1802EE1B8("UnityEngine.Camera::get_farClipPlane()");
		            sub_18007E1B0(v197, 0LL);
		          }
		          qword_18F36F0C0 = (__int64)v50;
		        }
		        v53 = (float)(1.0 - (float)(focusDistance / v50(v49))) * v48;
		        v54 = hgCamera->fields.camera;
		        if ( !v54 )
		          sub_1800D8250(v52, v51);
		        v55 = (double (__fastcall *)(Camera *))qword_18F36F0C0;
		        if ( !qword_18F36F0C0 )
		        {
		          v55 = (double (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_farClipPlane()");
		          if ( !v55 )
		          {
		            v198 = sub_1802EE1B8("UnityEngine.Camera::get_farClipPlane()");
		            sub_18007E1B0(v198, 0LL);
		          }
		          qword_18F36F0C0 = (__int64)v55;
		        }
		        v58 = v55(v54);
		        v59 = *(float *)&v58;
		        v60 = hgCamera->fields.camera;
		        if ( !v60 )
		          sub_1800D8250(v57, v56);
		        v61 = (double (__fastcall *)(Camera *))qword_18F36F0B0;
		        if ( !qword_18F36F0B0 )
		        {
		          v61 = (double (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_nearClipPlane()");
		          if ( !v61 )
		          {
		            v199 = sub_1802EE1B8("UnityEngine.Camera::get_nearClipPlane()");
		            sub_18007E1B0(v199, 0LL);
		          }
		          qword_18F36F0B0 = (__int64)v61;
		        }
		        v64 = v61(v60);
		        v65 = *(float *)&v64;
		        v66 = hgCamera->fields.camera;
		        if ( !v66 )
		          sub_1800D8250(v63, v62);
		        v67 = (double (__fastcall *)(Camera *))qword_18F36F0C0;
		        if ( !qword_18F36F0C0 )
		        {
		          v67 = (double (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_farClipPlane()");
		          if ( !v67 )
		          {
		            v200 = sub_1802EE1B8("UnityEngine.Camera::get_farClipPlane()");
		            sub_18007E1B0(v200, 0LL);
		          }
		          qword_18F36F0C0 = (__int64)v67;
		        }
		        v70 = v67(v66);
		        v71 = hgCamera->fields.camera;
		        if ( !v71 )
		          sub_1800D8250(v69, v68);
		        v72 = (float (__fastcall *)(Camera *))qword_18F36F0B0;
		        if ( !qword_18F36F0B0 )
		        {
		          v72 = (float (__fastcall *)(Camera *))il2cpp_resolve_icall_1("UnityEngine.Camera::get_nearClipPlane()");
		          if ( !v72 )
		          {
		            v201 = sub_1802EE1B8("UnityEngine.Camera::get_nearClipPlane()");
		            sub_18007E1B0(v201, 0LL);
		          }
		          qword_18F36F0B0 = (__int64)v72;
		        }
		        v73 = (float)((float)(v59 - v65) * (float)(v48 * focusDistance)) / (float)(v72(v71) * *(float *)&v70);
		        nearFocusStart = m_depthOfField->fields.nearFocusStart;
		        nearFocusEnd = m_depthOfField->fields.nearFocusEnd;
		        v76 = 0;
		        v77 = Rewired::Utils::MathTools::Clamp(
		                m_depthOfField->fields.nearRadius,
		                0.0,
		                input->depthOfFieldMaxRadius,
		                0LL);
		        farFocusStart = m_depthOfField->fields.farFocusStart;
		        farFocusEnd = m_depthOfField->fields.farFocusEnd;
		        v80 = Rewired::Utils::MathTools::Clamp(m_depthOfField->fields.farRadius, 0.0, input->depthOfFieldMaxRadius, 0LL);
		        Rewired::Utils::MathTools::Clamp(m_depthOfField->fields.temporalFactor, 0.1, 1.0, 0LL);
		        v81 = sub_1803369A0();
		        *(float *)&v82 = (float)((float)(int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField) * v77)
		                       / 1440.0;
		        *(float *)&v83 = (float)((float)(int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField) * v80)
		                       / 1440.0;
		        defaultNearStartColor.x = v53;
		        defaultNearStartColor.y = v73;
		        v84 = v211;
		        defaultNearStartColor.z = v211;
		        defaultNearStartColor.w = *(float *)&v81;
		        *(Vector4 *)&P3[1].monitor = defaultNearStartColor;
		        defaultNearStartColor.x = nearFocusStart;
		        defaultNearStartColor.y = nearFocusEnd;
		        *(_QWORD *)&defaultNearStartColor.z = v82;
		        *(Vector4 *)&P3[2].monitor = defaultNearStartColor;
		        defaultNearStartColor.x = farFocusStart;
		        defaultNearStartColor.y = farFocusEnd;
		        *(_QWORD *)&defaultNearStartColor.z = v83;
		        *(Vector4 *)&P3[3].monitor = defaultNearStartColor;
		        if ( hgCamera->fields.prevTransformReset )
		          v76 = 1065353216;
		        defaultNearStartColor.x = 0.0;
		        *(_QWORD *)&defaultNearStartColor.y = v76;
		        defaultNearStartColor.w = 0.0;
		        *(Vector4 *)&P3[4].monitor = defaultNearStartColor;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDepthOfField);
		        defaultNearStartColor = (Vector4)TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultNearStartColor;
		        *(__m128i *)&P3[5].monitor = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                        (Color *)&v212,
		                                                                        &defaultNearStartColor,
		                                                                        0LL));
		        defaultNearStartColor = (Vector4)TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultNearEndColor;
		        *(__m128i *)&P3[6].monitor = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                        (Color *)&v212,
		                                                                        &defaultNearStartColor,
		                                                                        0LL));
		        defaultNearStartColor = (Vector4)TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultFarStartColor;
		        *(__m128i *)&P3[7].monitor = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                        (Color *)&v212,
		                                                                        &defaultNearStartColor,
		                                                                        0LL));
		        defaultNearStartColor = (Vector4)TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultFarEndColor;
		        *(__m128i *)&P3[8].monitor = _mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                        (Color *)&v212,
		                                                                        &defaultNearStartColor,
		                                                                        0LL));
		        *(__m128i *)&P3[9].monitor = _mm_loadu_si128((const __m128i *)&hgCamera->fields._sceneRTSizeParam_k__BackingField);
		        P3[12].monitor = (MonitorData *)hgCamera->fields._sceneRTSize_k__BackingField;
		        v85 = (float)(int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField) * v84;
		        v86 = HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField);
		        v87 = (float)(1.0 / (float)(int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField)) / v84;
		        v88 = (float)(1.0 / (float)hgCamera->fields._sceneRTSize_k__BackingField.m_X) / v84;
		        defaultNearStartColor.x = (float)hgCamera->fields._sceneRTSize_k__BackingField.m_X * v84;
		        defaultNearStartColor.y = v85;
		        defaultNearStartColor.z = v88;
		        defaultNearStartColor.w = v87;
		        *(Vector4 *)&P3[10].monitor = defaultNearStartColor;
		        v90 = sub_1834464B0(v86, 0, v89);
		        v93 = sub_1834464B0(v91, 0, v92);
		        *(_QWORD *)&defaultNearStartColor.x = __PAIR64__(v93, v90);
		        P3[13].klass = (Object__Class *)__PAIR64__(v93, v90);
		        v94 = (float)(int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField) * 0.125;
		        v95 = HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField);
		        v96 = (float)(1.0 / (float)(int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField)) * 8.0;
		        v97 = (float)(1.0 / (float)hgCamera->fields._sceneRTSize_k__BackingField.m_X) * 8.0;
		        defaultNearStartColor.x = (float)hgCamera->fields._sceneRTSize_k__BackingField.m_X * 0.125;
		        defaultNearStartColor.y = v94;
		        defaultNearStartColor.z = v97;
		        defaultNearStartColor.w = v96;
		        *(Vector4 *)&P3[11].monitor = defaultNearStartColor;
		        v99 = sub_1834464B0(v95, 0, v98);
		        v102 = sub_1834464B0(v100, 0, v101);
		        *(_QWORD *)&defaultNearStartColor.x = __PAIR64__(v102, v99);
		        P3[13].monitor = (MonitorData *)__PAIR64__(v102, v99);
		        v9 = (Object *)this;
		        P3[33].klass = (Object__Class *)this->fields.m_shader;
		        if ( dword_18F35FD08 )
		        {
		          v103 = ((unsigned __int64)&P3[33] >> 12) & 0x1FFFFF;
		          v104 = v103 >> 6;
		          v105 = v103 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v104 + 36190]);
		          do
		            v106 = qword_18F0BCBA0[v104 + 36190];
		          while ( v106 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v104 + 36190], v106 | (1LL << v105), v106) );
		        }
		      }
		      v110 = v203;
		      v113 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                (TextureHandle *)&v212,
		                &v204,
		                &input->sceneColor,
		                0LL);
		      if ( !v110 )
		        sub_1800D8250(v112, v111);
		      v110[14] = (Object)v113;
		      v114 = v203;
		      v117 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                (TextureHandle *)&v212,
		                &v204,
		                &input->sceneDepth,
		                0LL);
		      if ( !v114 )
		        sub_1800D8250(v116, v115);
		      v114[15] = (Object)v117;
		      v118 = v203;
		      v121 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                (TextureHandle *)&v212,
		                &v204,
		                &input->motionVectorTexture,
		                0LL);
		      if ( !v118 )
		        sub_1800D8250(v120, v119);
		      v118[16] = (Object)v121;
		      v212 = v204;
		      HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateCoCTexture(
		        (DepthOfFieldPassConstructor *)v9,
		        (DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *)v203,
		        &v212,
		        0LL);
		      *(_OWORD *)&physicalParameters_k__BackingField.m_Iso = *(_OWORD *)&v204.m_RenderPass;
		      *(_OWORD *)&physicalParameters_k__BackingField.m_BladeCount = *(_OWORD *)&v204.m_RenderGraph;
		      HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateTemporalColorTextures(
		        (DepthOfFieldPassConstructor *)v9,
		        input,
		        (DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *)v203,
		        renderGraph,
		        (HGRenderGraphBuilder *)&physicalParameters_k__BackingField,
		        0LL);
		      if ( !v203 )
		        sub_1800D8250(v123, v122);
		      monitor = (int32_t)v203[13].monitor;
		      monitor_high = HIDWORD(v203[13].monitor);
		      sub_18033B9D0(&v219, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v219, monitor, monitor_high, 0LL);
		      v126 = *(_OWORD *)&v219.width;
		      v205 = *(_OWORD *)&v219.width;
		      v206 = *(_OWORD *)&v219.colorFormat;
		      v207 = *(_OWORD *)&v219.enableRandomWrite;
		      *(_QWORD *)&v208 = *(_QWORD *)&v219.bindTextureMS;
		      v127 = *(_OWORD *)&v219.fastMemoryDesc.inFastMemory;
		      v209 = *(_OWORD *)&v219.fastMemoryDesc.inFastMemory;
		      clearColor = v219.clearColor;
		      v210 = v219.clearColor;
		      LODWORD(v206) = 45;
		      LOBYTE(v207) = 1;
		      *((_QWORD *)&v208 + 1) = "Depth Of Field Tile CoC";
		      if ( dword_18F35FD08 )
		      {
		        v129 = ((((unsigned __int64)&v208 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v129 + 36190]);
		        do
		          v130 = qword_18F0BCBA0[v129 + 36190];
		        while ( v130 != _InterlockedCompareExchange64(
		                          &qword_18F0BCBA0[v129 + 36190],
		                          v130 | (1LL << ((((unsigned __int64)&v208 + 8) >> 12) & 0x3F)),
		                          v130) );
		        clearColor = v210;
		        v127 = v209;
		        v126 = v205;
		      }
		      *(_QWORD *)((char *)&v206 + 4) = 0x100000001LL;
		      *(_OWORD *)&v217.width = v126;
		      *(_OWORD *)&v217.colorFormat = v206;
		      *(_OWORD *)&v217.enableRandomWrite = v207;
		      *(_OWORD *)&v217.bindTextureMS = v208;
		      *(_OWORD *)&v217.fastMemoryDesc.inFastMemory = v127;
		      v217.clearColor = clearColor;
		      v131 = v203;
		      v134 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                (TextureHandle *)&v212,
		                &v204,
		                &v217,
		                0LL);
		      if ( !v131 )
		        sub_1800D8250(v133, v132);
		      v131[19] = (Object)v134;
		      v135 = v203;
		      v138 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                (TextureHandle *)&v212,
		                &v204,
		                &v217,
		                0LL);
		      if ( !v135 )
		        sub_1800D8250(v137, v136);
		      v135[20] = (Object)v138;
		      *(_OWORD *)&physicalParameters_k__BackingField.m_Iso = *(_OWORD *)&v204.m_RenderPass;
		      *(_OWORD *)&physicalParameters_k__BackingField.m_BladeCount = *(_OWORD *)&v204.m_RenderGraph;
		      HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateOneComponentVerticalTextures(
		        (DepthOfFieldPassConstructor *)v9,
		        (DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *)v203,
		        (HGRenderGraphBuilder *)&physicalParameters_k__BackingField,
		        0LL);
		      if ( !v203 )
		        sub_1800D8250(v140, v139);
		      klass = (int32_t)v203[13].klass;
		      klass_high = HIDWORD(v203[13].klass);
		      sub_18033B9D0(&v220, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v220, klass, klass_high, 0LL);
		      v143 = *(_OWORD *)&v220.width;
		      v205 = *(_OWORD *)&v220.width;
		      v206 = *(_OWORD *)&v220.colorFormat;
		      v207 = *(_OWORD *)&v220.enableRandomWrite;
		      *(_QWORD *)&v208 = *(_QWORD *)&v220.bindTextureMS;
		      v144 = *(_OWORD *)&v220.fastMemoryDesc.inFastMemory;
		      v209 = *(_OWORD *)&v220.fastMemoryDesc.inFastMemory;
		      v145 = v220.clearColor;
		      v210 = v220.clearColor;
		      LODWORD(v206) = 48;
		      LOBYTE(v207) = 1;
		      *((_QWORD *)&v208 + 1) = "Depth Of Field Color One Component";
		      if ( dword_18F35FD08 )
		      {
		        v146 = ((((unsigned __int64)&v208 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v146 + 36190]);
		        do
		          v147 = qword_18F0BCBA0[v146 + 36190];
		        while ( v147 != _InterlockedCompareExchange64(
		                          &qword_18F0BCBA0[v146 + 36190],
		                          v147 | (1LL << ((((unsigned __int64)&v208 + 8) >> 12) & 0x3F)),
		                          v147) );
		        v145 = v210;
		        v144 = v209;
		        v143 = v205;
		      }
		      *(_QWORD *)((char *)&v206 + 4) = 0x100000001LL;
		      *(_OWORD *)&v221.width = v143;
		      *(_OWORD *)&v221.colorFormat = v206;
		      *(_OWORD *)&v221.enableRandomWrite = v207;
		      *(_OWORD *)&v221.bindTextureMS = v208;
		      *(_OWORD *)&v221.fastMemoryDesc.inFastMemory = v144;
		      v221.clearColor = v145;
		      v148 = v203;
		      v151 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                (TextureHandle *)&v212,
		                &v204,
		                &v221,
		                0LL);
		      if ( !v148 )
		        sub_1800D8250(v150, v149);
		      v148[23] = (Object)v151;
		      if ( !v203 )
		        sub_1800D8250(v150, v149);
		      v152 = (int32_t)v203[13].klass;
		      v153 = HIDWORD(v203[13].klass);
		      sub_18033B9D0(&v222, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v222, v152, v153, 0LL);
		      v154 = *(_OWORD *)&v222.width;
		      v205 = *(_OWORD *)&v222.width;
		      v206 = *(_OWORD *)&v222.colorFormat;
		      v207 = *(_OWORD *)&v222.enableRandomWrite;
		      *(_QWORD *)&v208 = *(_QWORD *)&v222.bindTextureMS;
		      v155 = *(_OWORD *)&v222.fastMemoryDesc.inFastMemory;
		      v209 = *(_OWORD *)&v222.fastMemoryDesc.inFastMemory;
		      v156 = v222.clearColor;
		      v210 = v222.clearColor;
		      LODWORD(v206) = 45;
		      LOBYTE(v207) = 1;
		      *((_QWORD *)&v208 + 1) = "Depth Of Field Color One Component Alpha";
		      if ( dword_18F35FD08 )
		      {
		        v157 = ((((unsigned __int64)&v208 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v157 + 36190]);
		        do
		          v158 = qword_18F0BCBA0[v157 + 36190];
		        while ( v158 != _InterlockedCompareExchange64(
		                          &qword_18F0BCBA0[v157 + 36190],
		                          v158 | (1LL << ((((unsigned __int64)&v208 + 8) >> 12) & 0x3F)),
		                          v158) );
		        v156 = v210;
		        v155 = v209;
		        v154 = v205;
		      }
		      *(_QWORD *)((char *)&v206 + 4) = 0x100000001LL;
		      *(_OWORD *)&v223.width = v154;
		      *(_OWORD *)&v223.colorFormat = v206;
		      *(_OWORD *)&v223.enableRandomWrite = v207;
		      *(_OWORD *)&v223.bindTextureMS = v208;
		      *(_OWORD *)&v223.fastMemoryDesc.inFastMemory = v155;
		      v223.clearColor = v156;
		      v159 = v203;
		      v162 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                (TextureHandle *)&v212,
		                &v204,
		                &v223,
		                0LL);
		      if ( !v159 )
		        sub_1800D8250(v161, v160);
		      v159[24] = (Object)v162;
		      if ( !v203 )
		        sub_1800D8250(v161, v160);
		      v163 = (int32_t)v203[13].klass;
		      v164 = HIDWORD(v203[13].klass);
		      sub_18033B9D0(&v224, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v224, v163, v164, 0LL);
		      v165 = *(_OWORD *)&v224.width;
		      v205 = *(_OWORD *)&v224.width;
		      v206 = *(_OWORD *)&v224.colorFormat;
		      v207 = *(_OWORD *)&v224.enableRandomWrite;
		      *(_QWORD *)&v208 = *(_QWORD *)&v224.bindTextureMS;
		      v166 = *(_OWORD *)&v224.fastMemoryDesc.inFastMemory;
		      v209 = *(_OWORD *)&v224.fastMemoryDesc.inFastMemory;
		      v167 = v224.clearColor;
		      v210 = v224.clearColor;
		      LODWORD(v206) = 48;
		      LOBYTE(v207) = 1;
		      *((_QWORD *)&v208 + 1) = "Depth Of Field Color Two Components";
		      if ( dword_18F35FD08 )
		      {
		        v168 = ((((unsigned __int64)&v208 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v168 + 36190]);
		        do
		          v169 = qword_18F0BCBA0[v168 + 36190];
		        while ( v169 != _InterlockedCompareExchange64(
		                          &qword_18F0BCBA0[v168 + 36190],
		                          v169 | (1LL << ((((unsigned __int64)&v208 + 8) >> 12) & 0x3F)),
		                          v169) );
		        v167 = v210;
		        v166 = v209;
		        v165 = v205;
		      }
		      *(_QWORD *)((char *)&v206 + 4) = 0x100000001LL;
		      *(_OWORD *)&v216.width = v165;
		      *(_OWORD *)&v216.colorFormat = v206;
		      *(_OWORD *)&v216.enableRandomWrite = v207;
		      *(_OWORD *)&v216.bindTextureMS = v208;
		      *(_OWORD *)&v216.fastMemoryDesc.inFastMemory = v166;
		      v216.clearColor = v167;
		      v170 = v203;
		      v173 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                (TextureHandle *)&v212,
		                &v204,
		                &v216,
		                0LL);
		      if ( !v170 )
		        sub_1800D8250(v172, v171);
		      v170[25] = (Object)v173;
		      v174 = v203;
		      v177 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                (TextureHandle *)&v212,
		                &v204,
		                &v216,
		                0LL);
		      if ( !v174 )
		        sub_1800D8250(v176, v175);
		      v174[26] = (Object)v177;
		      v178 = v203;
		      v181 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(
		                (TextureHandle *)&v212,
		                &v204,
		                &v216,
		                0LL);
		      if ( !v178 )
		        sub_1800D8250(v180, v179);
		      v178[27] = (Object)v181;
		      *(_OWORD *)&physicalParameters_k__BackingField.m_Iso = *(_OWORD *)&v204.m_RenderPass;
		      *(_OWORD *)&physicalParameters_k__BackingField.m_BladeCount = *(_OWORD *)&v204.m_RenderGraph;
		      HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateFarHorizontalTexture(
		        (DepthOfFieldPassConstructor *)v9,
		        (DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *)v203,
		        (HGRenderGraphBuilder *)&physicalParameters_k__BackingField,
		        0LL);
		      v218 = *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(renderGraph, &input->sceneColor, 0LL);
		      v218.enableRandomWrite = 1;
		      v182 = v203;
		      defaultNearStartColor = (Vector4)*HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                          (TextureHandle *)&v212,
		                                          renderGraph,
		                                          &v218,
		                                          0LL);
		      v185 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		                (TextureHandle *)&v212,
		                &v204,
		                (TextureHandle *)&defaultNearStartColor,
		                0LL);
		      if ( !v182 )
		        sub_1800D8250(v184, v183);
		      v182[32] = (Object)v185;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v204,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor->static_fields->s_circleDepthOfDieldHighQualityRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		      if ( !v203 )
		        sub_1800D8250(v187, v186);
		      *output = (DepthOfFieldPassConstructor_PassOutput)v203[32];
		    }
		    catch ( Il2CppExceptionWrapper *v215 )
		    {
		      v214[0] = v215->ex;
		    }
		    sub_180268AE0(v214);
		  }
		}
		
		private void ConstructCircleDepthOfFieldLowFarNear(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189B965C8-0x0000000189B96FD4
		// Void ConstructCircleDepthOfFieldLowFarNear(DepthOfFieldPassConstructor+PassInput ByRef, DepthOfFieldPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::ConstructCircleDepthOfFieldLowFarNear(
		        DepthOfFieldPassConstructor *this,
		        DepthOfFieldPassConstructor_PassInput *input,
		        DepthOfFieldPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *v13; // rbx
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  TextureHandle v16; // xmm0
		  DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *v17; // rbx
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  TextureHandle v20; // xmm0
		  DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *v21; // rbx
		  __int64 v22; // rdx
		  __int64 v23; // rcx
		  TextureHandle v24; // xmm0
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  int32_t m_X; // edi
		  int32_t m_Y; // ebx
		  __int128 v29; // xmm2
		  __int128 v30; // xmm3
		  Color clearColor; // xmm4
		  unsigned __int64 v32; // r8
		  signed __int64 v33; // rtt
		  DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *v34; // rbx
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  TextureHandle v37; // xmm0
		  DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *v38; // rbx
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  TextureHandle v41; // xmm0
		  __int64 v42; // rdx
		  __int64 v43; // rcx
		  int32_t v44; // edi
		  int32_t v45; // ebx
		  __int128 v46; // xmm2
		  __int128 v47; // xmm3
		  Color v48; // xmm4
		  unsigned __int64 v49; // r8
		  signed __int64 v50; // rtt
		  DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *v51; // rbx
		  __int64 v52; // rdx
		  __int64 v53; // rcx
		  TextureHandle v54; // xmm0
		  int32_t v55; // edi
		  int32_t v56; // ebx
		  __int128 v57; // xmm2
		  __int128 v58; // xmm3
		  Color v59; // xmm4
		  unsigned __int64 v60; // r8
		  signed __int64 v61; // rtt
		  DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *v62; // rbx
		  __int64 v63; // rdx
		  __int64 v64; // rcx
		  TextureHandle v65; // xmm0
		  DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *v66; // rbx
		  __int64 v67; // rdx
		  __int64 v68; // rcx
		  TextureHandle v69; // xmm0
		  __int64 v70; // rdx
		  __int64 v71; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v73; // rdx
		  __int64 v74; // rcx
		  DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *passData; // [rsp+40h] [rbp-3C8h] BYREF
		  TextureHandle v76; // [rsp+48h] [rbp-3C0h] BYREF
		  HGRenderGraphBuilder v77; // [rsp+58h] [rbp-3B0h] BYREF
		  __int128 v78; // [rsp+80h] [rbp-388h] BYREF
		  __int128 v79; // [rsp+90h] [rbp-378h]
		  __int128 v80; // [rsp+A0h] [rbp-368h]
		  __int128 v81; // [rsp+B0h] [rbp-358h] BYREF
		  __int128 v82; // [rsp+C0h] [rbp-348h]
		  Color v83; // [rsp+D0h] [rbp-338h]
		  _QWORD v84[2]; // [rsp+E0h] [rbp-328h] BYREF
		  HGRenderGraphBuilder v85; // [rsp+F0h] [rbp-318h] BYREF
		  Il2CppExceptionWrapper *v86; // [rsp+110h] [rbp-2F8h] BYREF
		  HGRenderGraphBuilder v87; // [rsp+120h] [rbp-2E8h] BYREF
		  TextureDesc v88; // [rsp+140h] [rbp-2C8h] BYREF
		  TextureDesc v89; // [rsp+1A0h] [rbp-268h] BYREF
		  TextureDesc v90; // [rsp+200h] [rbp-208h] BYREF
		  TextureDesc v91; // [rsp+260h] [rbp-1A8h] BYREF
		  TextureDesc v92; // [rsp+2C0h] [rbp-148h] BYREF
		  TextureDesc v93; // [rsp+320h] [rbp-E8h] BYREF
		  TextureDesc v94; // [rsp+380h] [rbp-88h] BYREF
		
		  memset(&v77, 0, sizeof(v77));
		  passData = 0LL;
		  sub_18033B9D0(&v89, 0LL, 96LL);
		  sub_18033B9D0(&v88, 0LL, 96LL);
		  sub_18033B9D0(&v78, 0LL, 96LL);
		  sub_18033B9D0(&v92, 0LL, 96LL);
		  sub_18033B9D0(&v94, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3062, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3062, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v74, v73);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1138(
		      Patch,
		      (Object *)this,
		      input,
		      output,
		      (Object *)renderGraph,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else
		  {
		    v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0xA9u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    v77 = *(HGRenderGraphBuilder *)sub_1808AF1C4(
		                                     (unsigned int)&v85,
		                                     (_DWORD)renderGraph,
		                                     (unsigned int)"Circle Depth of Field Low Far Near",
		                                     (unsigned int)&passData,
		                                     (__int64)v10);
		    v84[0] = 0LL;
		    v84[1] = &v77;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v77, 0, 0LL);
		      HG::Rendering::Runtime::DepthOfFieldPassConstructor::PrepareSharedParams(this, input, hgCamera, passData, 0LL);
		      v13 = passData;
		      v16 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v76, &v77, &input->sceneColor, 0LL);
		      if ( !v13 )
		        sub_1800D8250(v15, v14);
		      v13->fields.sceneColorTexture = v16;
		      v17 = passData;
		      v20 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v76, &v77, &input->sceneDepth, 0LL);
		      if ( !v17 )
		        sub_1800D8250(v19, v18);
		      v17->fields.sceneDepthTexture = v20;
		      v21 = passData;
		      v24 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		               &v76,
		               &v77,
		               &input->motionVectorTexture,
		               0LL);
		      if ( !v21 )
		        sub_1800D8250(v23, v22);
		      v21->fields.motionVectorTexture = v24;
		      v87 = v77;
		      HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateCoCTexture(this, passData, &v87, 0LL);
		      v85 = v77;
		      HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateTemporalColorTextures(
		        this,
		        input,
		        passData,
		        renderGraph,
		        &v85,
		        0LL);
		      if ( !passData )
		        sub_1800D8250(v26, v25);
		      m_X = passData->fields.tileCoCScreenSizeInt.m_X;
		      m_Y = passData->fields.tileCoCScreenSizeInt.m_Y;
		      sub_18033B9D0(&v90, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v90, m_X, m_Y, 0LL);
		      v29 = *(_OWORD *)&v90.width;
		      v78 = *(_OWORD *)&v90.width;
		      v79 = *(_OWORD *)&v90.colorFormat;
		      v80 = *(_OWORD *)&v90.enableRandomWrite;
		      *(_QWORD *)&v81 = *(_QWORD *)&v90.bindTextureMS;
		      v30 = *(_OWORD *)&v90.fastMemoryDesc.inFastMemory;
		      v82 = *(_OWORD *)&v90.fastMemoryDesc.inFastMemory;
		      clearColor = v90.clearColor;
		      v83 = v90.clearColor;
		      LODWORD(v79) = 45;
		      LOBYTE(v80) = 1;
		      *((_QWORD *)&v81 + 1) = "Depth Of Field Tile CoC";
		      if ( dword_18F35FD08 )
		      {
		        v32 = ((((unsigned __int64)&v81 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v32 + 36190]);
		        do
		          v33 = qword_18F0BCBA0[v32 + 36190];
		        while ( v33 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v32 + 36190],
		                         v33 | (1LL << ((((unsigned __int64)&v81 + 8) >> 12) & 0x3F)),
		                         v33) );
		        clearColor = v83;
		        v30 = v82;
		        v29 = v78;
		      }
		      *(_QWORD *)((char *)&v79 + 4) = 0x100000001LL;
		      *(_OWORD *)&v88.width = v29;
		      *(_OWORD *)&v88.colorFormat = v79;
		      *(_OWORD *)&v88.enableRandomWrite = v80;
		      *(_OWORD *)&v88.bindTextureMS = v81;
		      *(_OWORD *)&v88.fastMemoryDesc.inFastMemory = v30;
		      v88.clearColor = clearColor;
		      v34 = passData;
		      v37 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(&v76, &v77, &v88, 0LL);
		      if ( !v34 )
		        sub_1800D8250(v36, v35);
		      v34->fields.tileCoCTexture = v37;
		      v38 = passData;
		      v41 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(&v76, &v77, &v88, 0LL);
		      if ( !v38 )
		        sub_1800D8250(v40, v39);
		      v38->fields.blurTileCoCTexture = v41;
		      v85 = v77;
		      HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateOneComponentVerticalTextures(
		        this,
		        passData,
		        &v85,
		        0LL);
		      if ( !passData )
		        sub_1800D8250(v43, v42);
		      v44 = passData->fields.downsampleScreenSizeInt.m_X;
		      v45 = passData->fields.downsampleScreenSizeInt.m_Y;
		      sub_18033B9D0(&v91, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v91, v44, v45, 0LL);
		      v46 = *(_OWORD *)&v91.width;
		      v78 = *(_OWORD *)&v91.width;
		      v79 = *(_OWORD *)&v91.colorFormat;
		      v80 = *(_OWORD *)&v91.enableRandomWrite;
		      *(_QWORD *)&v81 = *(_QWORD *)&v91.bindTextureMS;
		      v47 = *(_OWORD *)&v91.fastMemoryDesc.inFastMemory;
		      v82 = *(_OWORD *)&v91.fastMemoryDesc.inFastMemory;
		      v48 = v91.clearColor;
		      v83 = v91.clearColor;
		      LODWORD(v79) = 48;
		      LOBYTE(v80) = 1;
		      *((_QWORD *)&v81 + 1) = "Depth Of Field Color One Component";
		      if ( dword_18F35FD08 )
		      {
		        v49 = ((((unsigned __int64)&v81 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v49 + 36190]);
		        do
		          v50 = qword_18F0BCBA0[v49 + 36190];
		        while ( v50 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v49 + 36190],
		                         v50 | (1LL << ((((unsigned __int64)&v81 + 8) >> 12) & 0x3F)),
		                         v50) );
		        v48 = v83;
		        v47 = v82;
		        v46 = v78;
		      }
		      *(_QWORD *)((char *)&v79 + 4) = 0x100000001LL;
		      *(_OWORD *)&v92.width = v46;
		      *(_OWORD *)&v92.colorFormat = v79;
		      *(_OWORD *)&v92.enableRandomWrite = v80;
		      *(_OWORD *)&v92.bindTextureMS = v81;
		      *(_OWORD *)&v92.fastMemoryDesc.inFastMemory = v47;
		      v92.clearColor = v48;
		      v51 = passData;
		      v54 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(&v76, &v77, &v92, 0LL);
		      if ( !v51 )
		        sub_1800D8250(v53, v52);
		      v51->fields.oneComponentHorizontalTexture = v54;
		      if ( !passData )
		        sub_1800D8250(v53, v52);
		      v55 = passData->fields.downsampleScreenSizeInt.m_X;
		      v56 = passData->fields.downsampleScreenSizeInt.m_Y;
		      sub_18033B9D0(&v93, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v93, v55, v56, 0LL);
		      v57 = *(_OWORD *)&v93.width;
		      v78 = *(_OWORD *)&v93.width;
		      v79 = *(_OWORD *)&v93.colorFormat;
		      v80 = *(_OWORD *)&v93.enableRandomWrite;
		      *(_QWORD *)&v81 = *(_QWORD *)&v93.bindTextureMS;
		      v58 = *(_OWORD *)&v93.fastMemoryDesc.inFastMemory;
		      v82 = *(_OWORD *)&v93.fastMemoryDesc.inFastMemory;
		      v59 = v93.clearColor;
		      v83 = v93.clearColor;
		      LODWORD(v79) = 45;
		      LOBYTE(v80) = 1;
		      *((_QWORD *)&v81 + 1) = "Depth Of Field Color One Component Alpha";
		      if ( dword_18F35FD08 )
		      {
		        v60 = ((((unsigned __int64)&v81 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v60 + 36190]);
		        do
		          v61 = qword_18F0BCBA0[v60 + 36190];
		        while ( v61 != _InterlockedCompareExchange64(
		                         &qword_18F0BCBA0[v60 + 36190],
		                         v61 | (1LL << ((((unsigned __int64)&v81 + 8) >> 12) & 0x3F)),
		                         v61) );
		        v59 = v83;
		        v58 = v82;
		        v57 = v78;
		      }
		      *(_QWORD *)((char *)&v79 + 4) = 0x100000001LL;
		      *(_OWORD *)&v94.width = v57;
		      *(_OWORD *)&v94.colorFormat = v79;
		      *(_OWORD *)&v94.enableRandomWrite = v80;
		      *(_OWORD *)&v94.bindTextureMS = v81;
		      *(_OWORD *)&v94.fastMemoryDesc.inFastMemory = v58;
		      v94.clearColor = v59;
		      v62 = passData;
		      v65 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::CreateTransientTexture(&v76, &v77, &v94, 0LL);
		      if ( !v62 )
		        sub_1800D8250(v64, v63);
		      v62->fields.oneComponentAlphaTexture0 = v65;
		      v85 = v77;
		      HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateFarHorizontalTexture(this, passData, &v85, 0LL);
		      v89 = *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(renderGraph, &input->sceneColor, 0LL);
		      v89.enableRandomWrite = 1;
		      v66 = passData;
		      v76 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v76, renderGraph, &v89, 0LL);
		      v69 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		               (TextureHandle *)&v87,
		               &v77,
		               &v76,
		               0LL);
		      if ( !v66 )
		        sub_1800D8250(v68, v67);
		      v66->fields.outputTexture = v69;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v77,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor->static_fields->s_circleDepthOfFieldLowFarNearRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		      if ( !passData )
		        sub_1800D8250(v71, v70);
		      *output = (DepthOfFieldPassConstructor_PassOutput)passData->fields.outputTexture;
		    }
		    catch ( Il2CppExceptionWrapper *v86 )
		    {
		      v84[0] = v86->ex;
		    }
		    sub_180268AE0(v84);
		  }
		}
		
		private void ConstructCircleDepthOfFieldLowFar(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189B96FD4-0x0000000189B975C4
		// Void ConstructCircleDepthOfFieldLowFar(DepthOfFieldPassConstructor+PassInput ByRef, DepthOfFieldPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::ConstructCircleDepthOfFieldLowFar(
		        DepthOfFieldPassConstructor *this,
		        DepthOfFieldPassConstructor_PassInput *input,
		        DepthOfFieldPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *v13; // rbx
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  TextureHandle v16; // xmm0
		  DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *v17; // rbx
		  __int64 v18; // rdx
		  __int64 v19; // rcx
		  TextureHandle v20; // xmm0
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  int32_t m_X; // edi
		  int32_t m_Y; // ebx
		  __int128 v25; // xmm2
		  __int128 v26; // xmm3
		  Color clearColor; // xmm4
		  unsigned __int64 v28; // r8
		  signed __int64 v29; // rtt
		  DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *v30; // rbx
		  __int64 v31; // rdx
		  __int64 v32; // rcx
		  TextureHandle v33; // xmm0
		  DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *v34; // rbx
		  __int64 v35; // rdx
		  __int64 v36; // rcx
		  TextureHandle v37; // xmm0
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v41; // rdx
		  __int64 v42; // rcx
		  DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *passData; // [rsp+40h] [rbp-238h] BYREF
		  HGRenderGraphBuilder v44; // [rsp+48h] [rbp-230h] BYREF
		  TextureHandle v45; // [rsp+68h] [rbp-210h] BYREF
		  _QWORD v46[3]; // [rsp+78h] [rbp-200h] BYREF
		  HGRenderGraphBuilder v47; // [rsp+90h] [rbp-1E8h] BYREF
		  HGRenderGraphBuilder v48; // [rsp+B0h] [rbp-1C8h] BYREF
		  __int128 v49; // [rsp+D0h] [rbp-1A8h] BYREF
		  __int128 v50; // [rsp+E0h] [rbp-198h]
		  __int128 v51; // [rsp+F0h] [rbp-188h]
		  __int128 v52; // [rsp+100h] [rbp-178h] BYREF
		  __int128 v53; // [rsp+110h] [rbp-168h]
		  Color v54; // [rsp+120h] [rbp-158h]
		  Il2CppExceptionWrapper *v55; // [rsp+130h] [rbp-148h] BYREF
		  TextureDesc v56; // [rsp+140h] [rbp-138h] BYREF
		  TextureDesc v57; // [rsp+1A0h] [rbp-D8h] BYREF
		  TextureDesc v58; // [rsp+200h] [rbp-78h] BYREF
		
		  memset(&v44, 0, sizeof(v44));
		  passData = 0LL;
		  sub_18033B9D0(&v56, 0LL, 96LL);
		  sub_18033B9D0(&v58, 0LL, 96LL);
		  sub_18033B9D0(&v49, 0LL, 96LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(3063, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3063, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v42, v41);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1138(
		      Patch,
		      (Object *)this,
		      input,
		      output,
		      (Object *)renderGraph,
		      (Object *)hgCamera,
		      0LL);
		  }
		  else
		  {
		    v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0xA9u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v12, v11);
		    v44 = *(HGRenderGraphBuilder *)sub_1808AF1C4(
		                                     (unsigned int)&v48,
		                                     (_DWORD)renderGraph,
		                                     (unsigned int)"Circle Depth of Field Low Far",
		                                     (unsigned int)&passData,
		                                     (__int64)v10);
		    v46[0] = 0LL;
		    v46[1] = &v44;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v44, 0, 0LL);
		      HG::Rendering::Runtime::DepthOfFieldPassConstructor::PrepareSharedParams(this, input, hgCamera, passData, 0LL);
		      v13 = passData;
		      v16 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v45, &v44, &input->sceneColor, 0LL);
		      if ( !v13 )
		        sub_1800D8250(v15, v14);
		      v13->fields.sceneColorTexture = v16;
		      v17 = passData;
		      v20 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(&v45, &v44, &input->sceneDepth, 0LL);
		      if ( !v17 )
		        sub_1800D8250(v19, v18);
		      v17->fields.sceneDepthTexture = v20;
		      v47 = v44;
		      HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateCoCTexture(this, passData, &v47, 0LL);
		      v48 = v44;
		      HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateTransientDownsampleCoCTexture(
		        this,
		        passData,
		        &v48,
		        0LL);
		      if ( !passData )
		        sub_1800D8250(v22, v21);
		      m_X = passData->fields.downsampleScreenSizeInt.m_X;
		      m_Y = passData->fields.downsampleScreenSizeInt.m_Y;
		      sub_18033B9D0(&v57, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(&v57, m_X, m_Y, 0LL);
		      v25 = *(_OWORD *)&v57.width;
		      v49 = *(_OWORD *)&v57.width;
		      v50 = *(_OWORD *)&v57.colorFormat;
		      v51 = *(_OWORD *)&v57.enableRandomWrite;
		      *(_QWORD *)&v52 = *(_QWORD *)&v57.bindTextureMS;
		      v26 = *(_OWORD *)&v57.fastMemoryDesc.inFastMemory;
		      v53 = *(_OWORD *)&v57.fastMemoryDesc.inFastMemory;
		      clearColor = v57.clearColor;
		      v54 = v57.clearColor;
		      LODWORD(v50) = 74;
		      LOBYTE(v51) = 1;
		      *((_QWORD *)&v52 + 1) = "Depth Of Field Color Downsample";
		      if ( dword_18F35FD08 )
		      {
		        v28 = ((((unsigned __int64)&v52 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F103690[v28]);
		        do
		          v29 = qword_18F103690[v28];
		        while ( v29 != _InterlockedCompareExchange64(
		                         &qword_18F103690[v28],
		                         v29 | (1LL << ((((unsigned __int64)&v52 + 8) >> 12) & 0x3F)),
		                         v29) );
		        clearColor = v54;
		        v26 = v53;
		        v25 = v49;
		      }
		      *(_QWORD *)((char *)&v50 + 4) = 0x100000001LL;
		      *(_OWORD *)&v58.width = v25;
		      *(_OWORD *)&v58.colorFormat = v50;
		      *(_OWORD *)&v58.enableRandomWrite = v51;
		      *(_OWORD *)&v58.bindTextureMS = v52;
		      *(_OWORD *)&v58.fastMemoryDesc.inFastMemory = v26;
		      v58.clearColor = clearColor;
		      this->fields.m_currentSceneColorTexture = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                                   &v45,
		                                                   renderGraph,
		                                                   &v58,
		                                                   0LL);
		      v30 = passData;
		      v33 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		               &v45,
		               &v44,
		               &this->fields.m_currentSceneColorTexture,
		               0LL);
		      if ( !v30 )
		        sub_1800D8250(v32, v31);
		      v30->fields.currentDownSampleSceneColorTexture = v33;
		      v48 = v44;
		      HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateOneComponentVerticalTextures(
		        this,
		        passData,
		        &v48,
		        0LL);
		      v47 = v44;
		      HG::Rendering::Runtime::DepthOfFieldPassConstructor::AllocateFarHorizontalTexture(this, passData, &v47, 0LL);
		      v56 = *HG::Rendering::RenderGraphModule::HGRenderGraph::GetTextureDescRef(renderGraph, &input->sceneColor, 0LL);
		      v56.enableRandomWrite = 1;
		      v34 = passData;
		      v45 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(&v45, renderGraph, &v56, 0LL);
		      v37 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteTexture(
		               (TextureHandle *)&v47,
		               &v44,
		               &v45,
		               0LL);
		      if ( !v34 )
		        sub_1800D8250(v36, v35);
		      v34->fields.outputTexture = v37;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v44,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor->static_fields->s_circleDepthOfFieldLowFarRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		      if ( !passData )
		        sub_1800D8250(v39, v38);
		      *output = (DepthOfFieldPassConstructor_PassOutput)passData->fields.outputTexture;
		    }
		    catch ( Il2CppExceptionWrapper *v55 )
		    {
		      v46[0] = v55->ex;
		    }
		    sub_180268AE0(v46);
		  }
		}
		
		private void PrepareGaussion(ref PassInput input, ref DepthOfFieldData cbData, HGCamera camera) {} // 0x0000000189B99A80-0x0000000189B99FBC
		// Void PrepareGaussion(DepthOfFieldPassConstructor+PassInput ByRef, DepthOfFieldPassConstructor+DepthOfFieldData ByRef, HGCamera)
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::PrepareGaussion(
		        DepthOfFieldPassConstructor *this,
		        DepthOfFieldPassConstructor_PassInput *input,
		        DepthOfFieldPassConstructor_DepthOfFieldData *cbData,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  __int64 v9; // rdx
		  Camera *v10; // rcx
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  HGDepthOfField *m_depthOfField; // rdi
		  float v13; // xmm11_4
		  Camera_GateFitMode__Enum gateFit; // eax
		  float v15; // xmm8_4
		  float focalLength; // xmm0_4
		  __int128 v17; // xmm1
		  float v18; // xmm7_4
		  __int128 v19; // xmm0
		  float v20; // xmm12_4
		  float v21; // xmm0_4
		  __int128 v22; // xmm1
		  __int128 v23; // xmm2
		  float v24; // xmm6_4
		  float focusDistance; // xmm9_4
		  float v26; // xmm7_4
		  float farClipPlane; // xmm0_4
		  float v28; // xmm8_4
		  float v29; // xmm0_4
		  float v30; // xmm6_4
		  float v31; // xmm0_4
		  float v32; // xmm13_4
		  float v33; // xmm0_4
		  float v34; // xmm12_4
		  float v35; // xmm6_4
		  float v36; // xmm0_4
		  float nearRadius; // xmm1_4
		  float nearFocusStart; // xmm5_4
		  float nearFocusEnd; // xmm7_4
		  float v40; // xmm6_4
		  float farRadius; // xmm2_4
		  float farFocusStart; // xmm3_4
		  float farFocusEnd; // xmm4_4
		  Vector2Int sceneRTSize_k__BackingField; // rax
		  Vector4 v45; // xmm0
		  Vector4 v46; // xmm0
		  MethodInfo *v47; // r8
		  MethodInfo *v48; // r8
		  MethodInfo *v49; // r8
		  MethodInfo *v50; // r8
		  __int64 v51; // rax
		  float v52; // xmm1_4
		  float v53; // xmm2_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 defaultNearStartColor; // [rsp+38h] [rbp-81h] BYREF
		  Color v56; // [rsp+48h] [rbp-71h] BYREF
		  HGPhysicalCamera v57; // [rsp+58h] [rbp-61h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3064, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3064, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1139(Patch, (Object *)this, input, cbData, (Object *)camera, 0LL);
		      return;
		    }
		    goto LABEL_34;
		  }
		  if ( !camera )
		    goto LABEL_34;
		  volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(camera, 0LL);
		  if ( !volumeComponentsData )
		    goto LABEL_34;
		  m_depthOfField = volumeComponentsData->fields.m_depthOfField;
		  if ( !m_depthOfField )
		    goto LABEL_34;
		  if ( m_depthOfField->fields.scale )
		    v13 = 0.5;
		  else
		    v13 = 1.0;
		  if ( !m_depthOfField->fields.focusMode )
		  {
		    v10 = camera->fields.camera;
		    if ( !v10 )
		      goto LABEL_34;
		    UnityEngine::Camera::get_usePhysicalProperties(v10, 0LL);
		  }
		  v10 = camera->fields.camera;
		  if ( !v10 )
		    goto LABEL_34;
		  gateFit = UnityEngine::Camera::get_gateFit(v10, 0LL);
		  v10 = camera->fields.camera;
		  if ( gateFit == Camera_GateFitMode__Enum_Horizontal )
		  {
		    if ( !v10 )
		      goto LABEL_34;
		    *(Vector2 *)&defaultNearStartColor.x = UnityEngine::Camera::get_sensorSize(v10, 0LL);
		    v15 = (float)(0.5 / defaultNearStartColor.x) * (float)camera->fields._taauRTSize_k__BackingField.m_X;
		  }
		  else
		  {
		    if ( !v10 )
		      goto LABEL_34;
		    *(Vector2 *)&defaultNearStartColor.x = UnityEngine::Camera::get_sensorSize(v10, 0LL);
		    v15 = (float)(int)HIDWORD(*(_QWORD *)&camera->fields._taauRTSize_k__BackingField)
		        * (float)(0.5 / defaultNearStartColor.x);
		  }
		  v10 = camera->fields.camera;
		  if ( !v10 )
		    goto LABEL_34;
		  focalLength = UnityEngine::Camera::get_focalLength(v10, 0LL);
		  v17 = *(_OWORD *)&camera->fields._physicalParameters_k__BackingField.m_BladeCount;
		  v18 = focalLength;
		  v57.m_Anamorphism = camera->fields._physicalParameters_k__BackingField.m_Anamorphism;
		  v19 = *(_OWORD *)&camera->fields._physicalParameters_k__BackingField.m_Iso;
		  *(_OWORD *)&v57.m_BladeCount = v17;
		  *(_OWORD *)&v57.m_Iso = v19;
		  *(float *)&v19 = HG::Rendering::Runtime::HGPhysicalCamera::get_aperture(&v57, 0LL);
		  v10 = camera->fields.camera;
		  v20 = *(float *)&v19;
		  if ( !v10 )
		    goto LABEL_34;
		  v21 = UnityEngine::Camera::get_focalLength(v10, 0LL);
		  v22 = *(_OWORD *)&camera->fields._physicalParameters_k__BackingField.m_Iso;
		  v23 = *(_OWORD *)&camera->fields._physicalParameters_k__BackingField.m_BladeCount;
		  v57.m_Anamorphism = camera->fields._physicalParameters_k__BackingField.m_Anamorphism;
		  v24 = v21 / 1000.0;
		  *(_OWORD *)&v57.m_Iso = v22;
		  *(_OWORD *)&v57.m_BladeCount = v23;
		  focusDistance = HG::Rendering::Runtime::HGPhysicalCamera::get_focusDistance(&v57, 0LL);
		  v10 = camera->fields.camera;
		  v26 = (float)((float)((float)(v18 / v20) * v24) * v15) / fmaxf(focusDistance - v24, 0.000001);
		  if ( !v10 )
		    goto LABEL_34;
		  farClipPlane = UnityEngine::Camera::get_farClipPlane(v10, 0LL);
		  v10 = camera->fields.camera;
		  v28 = (float)(1.0 - (float)(focusDistance / farClipPlane)) * v26;
		  if ( !v10 )
		    goto LABEL_34;
		  v29 = UnityEngine::Camera::get_farClipPlane(v10, 0LL);
		  v10 = camera->fields.camera;
		  v30 = v29;
		  if ( !v10
		    || (v31 = UnityEngine::Camera::get_nearClipPlane(v10, 0LL), v10 = camera->fields.camera, v32 = v31, !v10)
		    || (v33 = UnityEngine::Camera::get_farClipPlane(v10, 0LL), v10 = camera->fields.camera, v34 = v33, !v10) )
		  {
		LABEL_34:
		    sub_1800D8260(v10, v9);
		  }
		  v35 = (float)(v30 - v32) * (float)(v26 * focusDistance);
		  v36 = UnityEngine::Camera::get_nearClipPlane(v10, 0LL);
		  nearRadius = m_depthOfField->fields.nearRadius;
		  nearFocusStart = m_depthOfField->fields.nearFocusStart;
		  nearFocusEnd = m_depthOfField->fields.nearFocusEnd;
		  v40 = v35 / (float)(v36 * v34);
		  if ( nearRadius < 0.0 )
		  {
		    nearRadius = 0.0;
		  }
		  else if ( nearRadius > input->depthOfFieldMaxRadius )
		  {
		    nearRadius = input->depthOfFieldMaxRadius;
		  }
		  farRadius = m_depthOfField->fields.farRadius;
		  farFocusStart = m_depthOfField->fields.farFocusStart;
		  farFocusEnd = m_depthOfField->fields.farFocusEnd;
		  if ( farRadius < 0.0 )
		  {
		    farRadius = 0.0;
		  }
		  else if ( farRadius > input->depthOfFieldMaxRadius )
		  {
		    farRadius = input->depthOfFieldMaxRadius;
		  }
		  sceneRTSize_k__BackingField = camera->fields._sceneRTSize_k__BackingField;
		  defaultNearStartColor.w = 0.0;
		  defaultNearStartColor.x = v28;
		  defaultNearStartColor.y = v40;
		  defaultNearStartColor.z = v13;
		  v45 = defaultNearStartColor;
		  defaultNearStartColor.w = 0.0;
		  defaultNearStartColor.x = nearFocusStart;
		  cbData->param0 = v45;
		  defaultNearStartColor.y = nearFocusEnd;
		  defaultNearStartColor.z = (float)((float)sceneRTSize_k__BackingField.m_Y * nearRadius) / 1440.0;
		  v46 = defaultNearStartColor;
		  defaultNearStartColor.w = 0.0;
		  defaultNearStartColor.x = farFocusStart;
		  cbData->param1 = v46;
		  defaultNearStartColor.y = farFocusEnd;
		  defaultNearStartColor.z = (float)((float)sceneRTSize_k__BackingField.m_Y * farRadius) / 1440.0;
		  cbData->param2 = defaultNearStartColor;
		  cbData->param3 = 0LL;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDepthOfField);
		  defaultNearStartColor = (Vector4)TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultNearStartColor;
		  cbData->nearStartColor = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                       &v56,
		                                                                       &defaultNearStartColor,
		                                                                       v47));
		  defaultNearStartColor = (Vector4)TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultNearEndColor;
		  cbData->nearEndColor = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                     &v56,
		                                                                     &defaultNearStartColor,
		                                                                     v48));
		  defaultNearStartColor = (Vector4)TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultFarStartColor;
		  cbData->farStartColor = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                      &v56,
		                                                                      &defaultNearStartColor,
		                                                                      v49));
		  defaultNearStartColor = (Vector4)TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultFarEndColor;
		  cbData->farEndColor = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Color::op_Implicit(
		                                                                    &v56,
		                                                                    &defaultNearStartColor,
		                                                                    v50));
		  v51 = HIDWORD(*(_QWORD *)&camera->fields._sceneRTSize_k__BackingField);
		  v52 = (float)(int)HIDWORD(*(_QWORD *)&camera->fields._sceneRTSize_k__BackingField);
		  defaultNearStartColor.x = (float)camera->fields._sceneRTSize_k__BackingField.m_X * v13;
		  v53 = 1.0 / (float)camera->fields._sceneRTSize_k__BackingField.m_X;
		  defaultNearStartColor.y = v52 * v13;
		  defaultNearStartColor.z = v53 / v13;
		  defaultNearStartColor.w = (float)(1.0 / (float)(int)v51) / v13;
		  cbData->downsampleScreenSize = defaultNearStartColor;
		}
		
		private static void SetupLowQualityPreamble(CircleDepthOfFieldPassData data, HGRenderGraphContext context) {} // 0x0000000189B9A6C4-0x0000000189B9AC14
		// Void SetupLowQualityPreamble(DepthOfFieldPassConstructor+CircleDepthOfFieldPassData, HGRenderGraphContext)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::SetupLowQualityPreamble(
		        DepthOfFieldPassConstructor_CircleDepthOfFieldPassData *data,
		        HGRenderGraphContext *context,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  CommandBuffer *cmd; // rsi
		  ComputeShader *computeShader; // r14
		  CBHandle *ConstantBuffer; // rax
		  __m128i offset; // xmm6
		  __int64 v11; // rdx
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  int32_t Kernel; // ebx
		  TextureHandle sceneDepthTexture; // xmm6
		  int32_t v17; // r12d
		  int32_t v18; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  RenderTargetIdentifier keyword; // [rsp+40h] [rbp-208h] BYREF
		  LocalKeyword v23; // [rsp+70h] [rbp-1D8h] BYREF
		  LocalKeyword v24; // [rsp+88h] [rbp-1C0h] BYREF
		  Il2CppExceptionWrapper *v25; // [rsp+A0h] [rbp-1A8h] BYREF
		  Vector4 param0; // [rsp+B0h] [rbp-198h] BYREF
		  Vector4 param1; // [rsp+C0h] [rbp-188h]
		  Vector4 param2; // [rsp+D0h] [rbp-178h]
		  Vector4 param3; // [rsp+E0h] [rbp-168h]
		  Vector4 downsampleScreenSize; // [rsp+F0h] [rbp-158h]
		  Vector4 tileCoCScreenSize; // [rsp+100h] [rbp-148h]
		  Vector4 nearStartColor; // [rsp+110h] [rbp-138h]
		  Vector4 nearEndColor; // [rsp+120h] [rbp-128h]
		  Vector4 farStartColor; // [rsp+130h] [rbp-118h]
		  Vector4 farEndColor; // [rsp+140h] [rbp-108h]
		  RenderTargetIdentifier v36; // [rsp+150h] [rbp-F8h] BYREF
		  _OWORD source[11]; // [rsp+180h] [rbp-C8h] BYREF
		  char v38; // [rsp+268h] [rbp+20h] BYREF
		
		  v38 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(3065, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3065, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v21, v20);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)data,
		      (Object *)context,
		      0LL);
		  }
		  else
		  {
		    if ( !context )
		      sub_1800D8260(v6, v5);
		    cmd = context->fields.cmd;
		    if ( !data )
		      sub_1800D8260(v6, v5);
		    computeShader = data->fields.computeShader;
		    sub_18033B9D0(&param0, 0LL, 160LL);
		    param0 = data->fields.param0;
		    param1 = data->fields.param1;
		    param2 = data->fields.param2;
		    param3 = data->fields.param3;
		    downsampleScreenSize = data->fields.downsampleScreenSize;
		    tileCoCScreenSize = data->fields.tileCoCScreenSize;
		    nearStartColor = data->fields.nearStartColor;
		    nearEndColor = data->fields.nearEndColor;
		    farStartColor = data->fields.farStartColor;
		    farEndColor = data->fields.farEndColor;
		    source[0] = param0;
		    source[1] = param1;
		    source[2] = param2;
		    source[3] = param3;
		    source[4] = downsampleScreenSize;
		    source[5] = tileCoCScreenSize;
		    source[6] = nearStartColor;
		    source[7] = nearEndColor;
		    source[8] = farStartColor;
		    source[9] = farEndColor;
		    sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		    ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                       (CBHandle *)&keyword,
		                       &context->fields.renderContext,
		                       160,
		                       0LL);
		    offset = *(__m128i *)&ConstantBuffer->bufferId;
		    keyword.m_BufferPointer = ConstantBuffer->ptr;
		    Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
		      (Void *)keyword.m_BufferPointer,
		      (Void *)source,
		      160LL,
		      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		    if ( !cmd )
		      sub_1800D8260(static_fields, v11);
		    UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantBufferParam(
		      cmd,
		      computeShader,
		      static_fields->_DepthOfFieldData,
		      offset.m128i_u32[0],
		      offset.m128i_i32[1],
		      _mm_cvtsi128_si32(_mm_srli_si128(offset, 8)),
		      0LL);
		    memset(&v24, 0, sizeof(v24));
		    UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v24, computeShader, (String *)"DOF_LOW_QUALITY", 0LL);
		    *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v24.m_SpaceInfo.m_KeywordSpace;
		    keyword.m_BufferPointer = *(void **)&v24.m_Index;
		    UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, computeShader, (LocalKeyword *)&keyword, 0LL);
		    memset(&v23, 0, sizeof(v23));
		    if ( data->fields.usePhysicalCamera )
		    {
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v23, computeShader, (String *)"DOF_PHYSICAL_MODE", 0LL);
		      *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v23.m_SpaceInfo.m_KeywordSpace;
		      keyword.m_BufferPointer = *(void **)&v23.m_Index;
		      UnityEngine::Rendering::CommandBuffer::EnableKeyword(cmd, computeShader, (LocalKeyword *)&keyword, 0LL);
		    }
		    else
		    {
		      UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v23, computeShader, (String *)"DOF_PHYSICAL_MODE", 0LL);
		      *(_OWORD *)&keyword.m_Type = *(_OWORD *)&v23.m_SpaceInfo.m_KeywordSpace;
		      keyword.m_BufferPointer = *(void **)&v23.m_Index;
		      UnityEngine::Rendering::CommandBuffer::DisableKeyword(cmd, computeShader, (LocalKeyword *)&keyword, 0LL);
		    }
		    UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		      (Int32Enum__Enum)0xAAu,
		      MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    v23.m_SpaceInfo.m_KeywordSpace = 0LL;
		    v23.m_Name = (String *)&v38;
		    try
		    {
		      if ( !computeShader )
		        sub_1800D8250(v14, v13);
		      Kernel = UnityEngine::ComputeShader::FindKernel(computeShader, (String *)"CircleDoFComputeCoC", 0LL);
		      sceneDepthTexture = data->fields.sceneDepthTexture;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      *(TextureHandle *)&keyword.m_Type = sceneDepthTexture;
		      keyword = *HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v36, (TextureHandle *)&keyword, 0LL);
		      UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		        cmd,
		        computeShader,
		        Kernel,
		        (String *)"_SceneDepthTexture",
		        &keyword,
		        0LL);
		      *(TextureHandle *)&keyword.m_Type = data->fields.cocTexture;
		      keyword = *HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(&v36, (TextureHandle *)&keyword, 0LL);
		      UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		        cmd,
		        computeShader,
		        Kernel,
		        (String *)"_DepthOfFieldCoCRWTexture",
		        &keyword,
		        0LL);
		      v17 = sub_1832DBD50();
		      v18 = sub_1832DBD50();
		      UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(cmd, computeShader, Kernel, v17, v18, 1, 0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v25 )
		    {
		      v23.m_SpaceInfo.m_KeywordSpace = v25->ex;
		      if ( v23.m_SpaceInfo.m_KeywordSpace )
		        sub_18007E1E0(v23.m_SpaceInfo.m_KeywordSpace);
		    }
		  }
		}
		
		private void ConstructGaussianDepthOfFieldFar(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189B975C4-0x0000000189B9957C
		// Void ConstructGaussianDepthOfFieldFar(DepthOfFieldPassConstructor+PassInput ByRef, DepthOfFieldPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=6
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::ConstructGaussianDepthOfFieldFar(
		        DepthOfFieldPassConstructor *this,
		        DepthOfFieldPassConstructor_PassInput *input,
		        DepthOfFieldPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  Object *P3; // r12
		  DepthOfFieldPassConstructor *v8; // r13
		  ProfilingSampler *v9; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  HGDepthOfField *m_depthOfField; // r14
		  float v16; // xmm14_4
		  Camera *camera; // rcx
		  Camera *v18; // rbx
		  __int64 (__fastcall *v19)(Camera *); // rax
		  int v20; // eax
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  Camera *v23; // rbx
		  void (__fastcall *v24)(Camera *, Vector4 *); // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  __m128i v27; // xmm7
		  void (__fastcall *v28)(Camera *, Vector4 *); // rax
		  float v29; // xmm7_4
		  Camera *v30; // rbx
		  double (__fastcall *v31)(Camera *); // rax
		  double v32; // xmm0_8
		  __int64 v33; // rdx
		  __int64 v34; // rcx
		  float v35; // xmm8_4
		  Camera *v36; // rbx
		  double (__fastcall *v37)(Camera *); // rax
		  double v38; // xmm0_8
		  float v39; // xmm6_4
		  float focusDistance; // xmm10_4
		  __int64 v41; // rdx
		  __int64 v42; // rcx
		  float v43; // xmm6_4
		  Camera *v44; // rbx
		  float (__fastcall *v45)(Camera *); // rax
		  __int64 v46; // rdx
		  __int64 v47; // rcx
		  float v48; // xmm7_4
		  Camera *v49; // rbx
		  double (__fastcall *v50)(Camera *); // rax
		  __int64 v51; // rdx
		  __int64 v52; // rcx
		  double v53; // xmm0_8
		  float v54; // xmm12_4
		  Camera *v55; // rbx
		  double (__fastcall *v56)(Camera *); // rax
		  __int64 v57; // rdx
		  __int64 v58; // rcx
		  double v59; // xmm0_8
		  float v60; // xmm9_4
		  Camera *v61; // rbx
		  double (__fastcall *v62)(Camera *); // rax
		  __int64 v63; // rdx
		  __int64 v64; // rcx
		  double v65; // xmm0_8
		  Camera *v66; // rbx
		  float (__fastcall *v67)(Camera *); // rax
		  float v68; // xmm12_4
		  float nearFocusStart; // xmm9_4
		  float nearFocusEnd; // xmm10_4
		  float v71; // xmm11_4
		  float farFocusStart; // xmm6_4
		  float farFocusEnd; // xmm8_4
		  float v74; // xmm0_4
		  float v75; // xmm3_4
		  float v76; // xmm2_4
		  float v77; // xmm3_4
		  __int64 v78; // rcx
		  float v79; // xmm13_4
		  ILFixDynamicMethodWrapper_2 *v80; // rax
		  __int64 v81; // rdx
		  __int64 v82; // rcx
		  CBHandle *ConstantBuffer; // rax
		  __int128 v84; // xmm6
		  Void *ptr; // xmm7_8
		  __int64 v86; // rdx
		  __int64 v87; // rcx
		  int v88; // r14d
		  Vector2Int sceneRTSize_k__BackingField; // rbx
		  unsigned __int64 v90; // rdx
		  signed __int64 v91; // rcx
		  __int128 v92; // xmm1
		  __int128 v93; // xmm2
		  __int128 v94; // xmm3
		  Color clearColor; // xmm4
		  unsigned __int64 v96; // r8
		  signed __int64 v97; // rtt
		  __int128 v98; // xmm1
		  __int128 v99; // xmm2
		  __int128 v100; // xmm3
		  Color v101; // xmm4
		  unsigned __int64 v102; // r8
		  signed __int64 v103; // rtt
		  ProfilingSampler *v104; // rax
		  __int64 v105; // rdx
		  __int64 v106; // rcx
		  Object *v107; // rax
		  Object *v108; // r15
		  __int64 v109; // rdx
		  __int64 v110; // rcx
		  TextureHandle v111; // xmm0
		  Object *v112; // rdx
		  int v113; // eax
		  unsigned __int64 v114; // rdx
		  unsigned __int64 v115; // r8
		  char v116; // dl
		  signed __int64 v117; // rtt
		  Object *v118; // rdx
		  Object__Class *m_mbp; // rcx
		  unsigned __int64 v120; // rdx
		  unsigned __int64 v121; // r8
		  char v122; // dl
		  signed __int64 v123; // rtt
		  Object *v124; // r15
		  HGCamera_VolumeComponentsData *v125; // rax
		  __int64 v126; // rdx
		  __int64 v127; // rcx
		  HGDepthOfField *v128; // rax
		  bool usePhysicalProperties; // al
		  Camera *v130; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *_9__31_0; // rsi
		  Object *v132; // r15
		  RenderFunc_1_System_Object_ *v133; // rax
		  __int64 v134; // rdx
		  __int64 v135; // rcx
		  unsigned __int64 v136; // rdx
		  char v137; // r8
		  signed __int64 v138; // rtt
		  ProfilingSampler *v139; // rax
		  __int64 v140; // rdx
		  __int64 v141; // rcx
		  Object *v142; // rax
		  Object *v143; // rsi
		  __int64 v144; // rdx
		  __int64 v145; // rcx
		  TextureHandle v146; // xmm0
		  Object *v147; // rsi
		  __int64 v148; // rdx
		  __int64 v149; // rcx
		  TextureHandle v150; // xmm0
		  Object *v151; // rdx
		  int v152; // eax
		  unsigned __int64 v153; // rdx
		  unsigned __int64 v154; // r8
		  char v155; // dl
		  signed __int64 v156; // rtt
		  Object *v157; // rdx
		  Object__Class *v158; // rcx
		  unsigned __int64 v159; // rdx
		  unsigned __int64 v160; // r8
		  char v161; // dl
		  signed __int64 v162; // rtt
		  RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *_9__31_1; // rsi
		  Object *v164; // r15
		  RenderFunc_1_System_Object_ *v165; // rax
		  __int64 v166; // rdx
		  __int64 v167; // rcx
		  unsigned __int64 v168; // rdx
		  char v169; // r8
		  signed __int64 v170; // rtt
		  ProfilingSampler *v171; // rax
		  __int64 v172; // rdx
		  __int64 v173; // rcx
		  Object *v174; // rax
		  Object *v175; // rsi
		  __int64 v176; // rdx
		  __int64 v177; // rcx
		  TextureHandle v178; // xmm0
		  Object *v179; // rdx
		  int v180; // eax
		  unsigned __int64 v181; // rdx
		  unsigned __int64 v182; // r8
		  char v183; // dl
		  signed __int64 v184; // rtt
		  Object *v185; // rdx
		  Object__Class *v186; // rcx
		  unsigned __int64 v187; // rdx
		  unsigned __int64 v188; // r8
		  char v189; // dl
		  signed __int64 v190; // rtt
		  RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *_9__31_2; // rsi
		  Object *v192; // r15
		  RenderFunc_1_System_Object_ *v193; // rax
		  __int64 v194; // rdx
		  __int64 v195; // rcx
		  unsigned __int64 v196; // rdx
		  char v197; // r8
		  signed __int64 v198; // rtt
		  ProfilingSampler *v199; // rax
		  __int64 v200; // rdx
		  __int64 v201; // rcx
		  Object *v202; // rax
		  Object *v203; // rsi
		  __int64 v204; // rdx
		  __int64 v205; // rcx
		  TextureHandle v206; // xmm0
		  Object *v207; // rdx
		  int v208; // eax
		  unsigned __int64 v209; // rdx
		  unsigned __int64 v210; // r8
		  char v211; // dl
		  signed __int64 v212; // rtt
		  Object *v213; // rdx
		  Object__Class *v214; // rcx
		  unsigned __int64 v215; // rdx
		  unsigned __int64 v216; // r8
		  char v217; // dl
		  signed __int64 v218; // rtt
		  RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *_9__31_3; // rsi
		  Object *v220; // r15
		  RenderFunc_1_System_Object_ *v221; // rax
		  __int64 v222; // rdx
		  __int64 v223; // rcx
		  unsigned __int64 v224; // rdx
		  char v225; // r8
		  signed __int64 v226; // rtt
		  ProfilingSampler *v227; // rax
		  __int64 v228; // rdx
		  __int64 v229; // rcx
		  Object *v230; // rax
		  Object *v231; // rsi
		  __int64 v232; // rdx
		  __int64 v233; // rcx
		  TextureHandle v234; // xmm0
		  Object *v235; // rsi
		  __int64 v236; // rdx
		  __int64 v237; // rcx
		  TextureHandle v238; // xmm0
		  Object *v239; // rsi
		  __int64 v240; // rdx
		  __int64 v241; // rcx
		  TextureHandle v242; // xmm0
		  Object *v243; // rdx
		  int v244; // eax
		  unsigned __int64 v245; // rdx
		  unsigned __int64 v246; // r8
		  char v247; // dl
		  signed __int64 v248; // rtt
		  Object *v249; // rdx
		  Object__Class *v250; // rcx
		  unsigned __int64 v251; // rdx
		  unsigned __int64 v252; // r8
		  char v253; // dl
		  signed __int64 v254; // rtt
		  RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *_9__31_4; // rsi
		  Object *v256; // r15
		  RenderFunc_1_System_Object_ *v257; // rax
		  __int64 v258; // rdx
		  __int64 v259; // rcx
		  unsigned __int64 v260; // rdx
		  char v261; // r8
		  signed __int64 v262; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v264; // rdx
		  __int64 v265; // rcx
		  Vector4 v266; // [rsp+50h] [rbp-528h] BYREF
		  Il2CppException *ex; // [rsp+60h] [rbp-518h] BYREF
		  HGRenderGraphBuilder *v268; // [rsp+68h] [rbp-510h]
		  Object *v269; // [rsp+70h] [rbp-508h] BYREF
		  Vector4 defaultNearStartColor; // [rsp+80h] [rbp-4F8h] BYREF
		  Object *v271; // [rsp+90h] [rbp-4E8h] BYREF
		  Object *v272; // [rsp+98h] [rbp-4E0h] BYREF
		  HGRenderGraphBuilder v273; // [rsp+A0h] [rbp-4D8h] BYREF
		  Object *v274; // [rsp+C0h] [rbp-4B8h] BYREF
		  Object *v275; // [rsp+C8h] [rbp-4B0h] BYREF
		  HGPhysicalCamera physicalParameters_k__BackingField; // [rsp+D0h] [rbp-4A8h] BYREF
		  TextureHandle v277; // [rsp+100h] [rbp-478h] BYREF
		  HGRenderGraphBuilder v278; // [rsp+110h] [rbp-468h] BYREF
		  __int128 v279; // [rsp+130h] [rbp-448h] BYREF
		  __int128 v280; // [rsp+140h] [rbp-438h]
		  __int128 v281; // [rsp+150h] [rbp-428h]
		  __int128 v282; // [rsp+160h] [rbp-418h] BYREF
		  __int128 v283; // [rsp+170h] [rbp-408h]
		  Color v284; // [rsp+180h] [rbp-3F8h]
		  TextureHandle v285; // [rsp+190h] [rbp-3E8h] BYREF
		  _QWORD v286[2]; // [rsp+1A0h] [rbp-3D8h] BYREF
		  HGRenderGraphBuilder v287; // [rsp+1B0h] [rbp-3C8h] BYREF
		  HGRenderGraphBuilder v288; // [rsp+1D0h] [rbp-3A8h] BYREF
		  HGRenderGraphBuilder v289; // [rsp+1F0h] [rbp-388h] BYREF
		  HGRenderGraphBuilder v290; // [rsp+210h] [rbp-368h] BYREF
		  TextureHandle v291; // [rsp+230h] [rbp-348h] BYREF
		  HGRenderGraphProfilingScope v292; // [rsp+240h] [rbp-338h] BYREF
		  DepthOfFieldPassConstructor_DepthOfFieldData P2; // [rsp+260h] [rbp-318h] BYREF
		  Il2CppExceptionWrapper *v294; // [rsp+300h] [rbp-278h] BYREF
		  Il2CppExceptionWrapper *v295; // [rsp+308h] [rbp-270h] BYREF
		  Il2CppExceptionWrapper *v296; // [rsp+310h] [rbp-268h] BYREF
		  Il2CppExceptionWrapper *v297; // [rsp+318h] [rbp-260h] BYREF
		  Il2CppExceptionWrapper *v298; // [rsp+320h] [rbp-258h] BYREF
		  Il2CppExceptionWrapper *v299; // [rsp+328h] [rbp-250h] BYREF
		  TextureDesc v300; // [rsp+330h] [rbp-248h] BYREF
		  TextureDesc v301; // [rsp+390h] [rbp-1E8h] BYREF
		  TextureDesc v302; // [rsp+3F0h] [rbp-188h] BYREF
		  TextureDesc v303; // [rsp+450h] [rbp-128h] BYREF
		
		  P3 = (Object *)renderGraph;
		  v8 = this;
		  memset(&v292, 0, sizeof(v292));
		  sub_18033B9D0(&v302, 0LL, 96LL);
		  sub_18033B9D0(&v300, 0LL, 96LL);
		  sub_18033B9D0(&v279, 0LL, 96LL);
		  memset(&v288, 0, sizeof(v288));
		  v271 = 0LL;
		  memset(&v287, 0, sizeof(v287));
		  v272 = 0LL;
		  memset(&v289, 0, sizeof(v289));
		  v274 = 0LL;
		  memset(&v290, 0, sizeof(v290));
		  v275 = 0LL;
		  memset(&v278, 0, sizeof(v278));
		  v269 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3066, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3066, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v265, v264);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1138(Patch, (Object *)v8, input, output, P3, (Object *)hgCamera, 0LL);
		  }
		  else
		  {
		    v9 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		           (Int32Enum__Enum)0xA9u,
		           MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    HG::Rendering::RenderGraphModule::HGRenderGraphProfilingScope::HGRenderGraphProfilingScope(
		      &v292,
		      (HGRenderGraph *)P3,
		      v9,
		      0LL);
		    v286[0] = 0LL;
		    v286[1] = &v292;
		    try
		    {
		      sub_18033B9D0(&P2, 0LL, 160LL);
		      memset(&physicalParameters_k__BackingField, 0, sizeof(physicalParameters_k__BackingField));
		      if ( IFix::WrappersManagerImpl::IsPatched(3064, 0LL) )
		      {
		        v80 = IFix::WrappersManagerImpl::GetPatch(3064, 0LL);
		        if ( !v80 )
		          sub_1800D8250(v82, v81);
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1139(v80, (Object *)v8, input, &P2, (Object *)hgCamera, 0LL);
		      }
		      else
		      {
		        if ( !hgCamera )
		          sub_1800D8250(v11, v10);
		        volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		        if ( !volumeComponentsData )
		          sub_1800D8250(v14, v13);
		        m_depthOfField = volumeComponentsData->fields.m_depthOfField;
		        if ( !m_depthOfField )
		          sub_1800D8250(v14, v13);
		        if ( m_depthOfField->fields.scale )
		          v16 = 0.5;
		        else
		          v16 = 1.0;
		        if ( !m_depthOfField->fields.focusMode )
		        {
		          camera = hgCamera->fields.camera;
		          if ( !camera )
		            sub_1800D8250(0LL, v13);
		          UnityEngine::Camera::get_usePhysicalProperties(camera, 0LL);
		        }
		        v18 = hgCamera->fields.camera;
		        if ( !v18 )
		          sub_1800D8250(v14, v13);
		        v19 = (__int64 (__fastcall *)(Camera *))qword_18F36F170;
		        if ( !qword_18F36F170 )
		        {
		          v19 = (__int64 (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Camera::get_gateFit()");
		          qword_18F36F170 = (__int64)v19;
		        }
		        v20 = v19(v18);
		        v23 = hgCamera->fields.camera;
		        if ( v20 == 2 )
		        {
		          if ( !v23 )
		            sub_1800D8250(v22, v21);
		          *(_QWORD *)&v266.x = 0LL;
		          v28 = (void (__fastcall *)(Camera *, Vector4 *))qword_18F36F1F0;
		          if ( !qword_18F36F1F0 )
		          {
		            v28 = (void (__fastcall *)(Camera *, Vector4 *))sub_180059EA0(
		                                                              "UnityEngine.Camera::get_sensorSize_Injected(UnityEngine.Vector2&)");
		            qword_18F36F1F0 = (__int64)v28;
		          }
		          v28(v23, &v266);
		          v27 = _mm_cvtsi32_si128(hgCamera->fields._taauRTSize_k__BackingField.m_X);
		        }
		        else
		        {
		          if ( !v23 )
		            sub_1800D8250(v22, v21);
		          *(_QWORD *)&v266.x = 0LL;
		          v24 = (void (__fastcall *)(Camera *, Vector4 *))qword_18F36F1F0;
		          if ( !qword_18F36F1F0 )
		          {
		            v24 = (void (__fastcall *)(Camera *, Vector4 *))sub_180059EA0(
		                                                              "UnityEngine.Camera::get_sensorSize_Injected(UnityEngine.Vector2&)");
		            qword_18F36F1F0 = (__int64)v24;
		          }
		          v24(v23, &v266);
		          v27 = _mm_cvtsi32_si128(HIDWORD(*(_QWORD *)&hgCamera->fields._taauRTSize_k__BackingField));
		        }
		        v29 = _mm_cvtepi32_ps(v27).m128_f32[0] * (float)(0.5 / v266.x);
		        v30 = hgCamera->fields.camera;
		        if ( !v30 )
		          sub_1800D8250(v26, v25);
		        v31 = (double (__fastcall *)(Camera *))qword_18F3A8A28;
		        if ( !qword_18F3A8A28 )
		        {
		          v31 = (double (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Camera::get_focalLength()");
		          qword_18F3A8A28 = (__int64)v31;
		        }
		        v32 = v31(v30);
		        physicalParameters_k__BackingField = hgCamera->fields._physicalParameters_k__BackingField;
		        v35 = *(float *)&v32
		            / HG::Rendering::Runtime::HGPhysicalCamera::get_aperture(&physicalParameters_k__BackingField, 0LL);
		        v36 = hgCamera->fields.camera;
		        if ( !v36 )
		          sub_1800D8250(v34, v33);
		        v37 = (double (__fastcall *)(Camera *))qword_18F3A8A28;
		        if ( !qword_18F3A8A28 )
		        {
		          v37 = (double (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Camera::get_focalLength()");
		          qword_18F3A8A28 = (__int64)v37;
		        }
		        v38 = v37(v36);
		        v39 = *(float *)&v38 / 1000.0;
		        physicalParameters_k__BackingField = hgCamera->fields._physicalParameters_k__BackingField;
		        focusDistance = HG::Rendering::Runtime::HGPhysicalCamera::get_focusDistance(
		                          &physicalParameters_k__BackingField,
		                          0LL);
		        v43 = (float)((float)(v39 * v35) * v29) / UnityEngine::Mathf::Max(focusDistance - v39, 0.000001, 0LL);
		        v44 = hgCamera->fields.camera;
		        if ( !v44 )
		          sub_1800D8250(v42, v41);
		        v45 = (float (__fastcall *)(Camera *))qword_18F36F0C0;
		        if ( !qword_18F36F0C0 )
		        {
		          v45 = (float (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Camera::get_farClipPlane()");
		          qword_18F36F0C0 = (__int64)v45;
		        }
		        v48 = (float)(1.0 - (float)(focusDistance / v45(v44))) * v43;
		        v49 = hgCamera->fields.camera;
		        if ( !v49 )
		          sub_1800D8250(v47, v46);
		        v50 = (double (__fastcall *)(Camera *))qword_18F36F0C0;
		        if ( !qword_18F36F0C0 )
		        {
		          v50 = (double (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Camera::get_farClipPlane()");
		          qword_18F36F0C0 = (__int64)v50;
		        }
		        v53 = v50(v49);
		        v54 = *(float *)&v53;
		        v55 = hgCamera->fields.camera;
		        if ( !v55 )
		          sub_1800D8250(v52, v51);
		        v56 = (double (__fastcall *)(Camera *))qword_18F36F0B0;
		        if ( !qword_18F36F0B0 )
		        {
		          v56 = (double (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Camera::get_nearClipPlane()");
		          qword_18F36F0B0 = (__int64)v56;
		        }
		        v59 = v56(v55);
		        v60 = *(float *)&v59;
		        v61 = hgCamera->fields.camera;
		        if ( !v61 )
		          sub_1800D8250(v58, v57);
		        v62 = (double (__fastcall *)(Camera *))qword_18F36F0C0;
		        if ( !qword_18F36F0C0 )
		        {
		          v62 = (double (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Camera::get_farClipPlane()");
		          qword_18F36F0C0 = (__int64)v62;
		        }
		        v65 = v62(v61);
		        v66 = hgCamera->fields.camera;
		        if ( !v66 )
		          sub_1800D8250(v64, v63);
		        v67 = (float (__fastcall *)(Camera *))qword_18F36F0B0;
		        if ( !qword_18F36F0B0 )
		        {
		          v67 = (float (__fastcall *)(Camera *))sub_180059EA0("UnityEngine.Camera::get_nearClipPlane()");
		          qword_18F36F0B0 = (__int64)v67;
		        }
		        v68 = (float)((float)(v54 - v60) * (float)(v43 * focusDistance)) / (float)(*(float *)&v65 * v67(v66));
		        nearFocusStart = m_depthOfField->fields.nearFocusStart;
		        nearFocusEnd = m_depthOfField->fields.nearFocusEnd;
		        v71 = Rewired::Utils::MathTools::Clamp(
		                m_depthOfField->fields.nearRadius,
		                0.0,
		                input->depthOfFieldMaxRadius,
		                0LL);
		        farFocusStart = m_depthOfField->fields.farFocusStart;
		        farFocusEnd = m_depthOfField->fields.farFocusEnd;
		        v74 = Rewired::Utils::MathTools::Clamp(m_depthOfField->fields.farRadius, 0.0, input->depthOfFieldMaxRadius, 0LL);
		        v75 = (float)((float)(int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField) * v71) / 1440.0;
		        v76 = (float)((float)(int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField) * v74) / 1440.0;
		        v266.x = v48;
		        v266.y = v68;
		        *(_QWORD *)&v266.z = LODWORD(v16);
		        P2.param0 = v266;
		        P2.param1.x = nearFocusStart;
		        P2.param1.y = nearFocusEnd;
		        P2.param1.z = v75;
		        P2.param1.w = 0.0;
		        P2.param2.x = farFocusStart;
		        P2.param2.y = farFocusEnd;
		        P2.param2.z = v76;
		        memset(&P2.param2.w, 0, 20);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDepthOfField);
		        defaultNearStartColor = (Vector4)TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultNearStartColor;
		        P2.nearStartColor = (Vector4)*UnityEngine::Color::op_Implicit((Color *)&v277, &defaultNearStartColor, 0LL);
		        defaultNearStartColor = (Vector4)TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultNearEndColor;
		        P2.nearEndColor = (Vector4)*UnityEngine::Color::op_Implicit((Color *)&v277, &defaultNearStartColor, 0LL);
		        defaultNearStartColor = (Vector4)TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultFarStartColor;
		        P2.farStartColor = (Vector4)*UnityEngine::Color::op_Implicit((Color *)&v277, &defaultNearStartColor, 0LL);
		        defaultNearStartColor = (Vector4)TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultFarEndColor;
		        P2.farEndColor = (Vector4)*UnityEngine::Color::op_Implicit((Color *)&v277, &defaultNearStartColor, 0LL);
		        v77 = (float)(int)HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField) * v16;
		        v78 = HIDWORD(*(_QWORD *)&hgCamera->fields._sceneRTSize_k__BackingField);
		        v79 = (float)(1.0 / (float)hgCamera->fields._sceneRTSize_k__BackingField.m_X) / v16;
		        P2.downsampleScreenSize.x = (float)hgCamera->fields._sceneRTSize_k__BackingField.m_X * v16;
		        P2.downsampleScreenSize.y = v77;
		        P2.downsampleScreenSize.z = v79;
		        P2.downsampleScreenSize.w = (float)(1.0 / (float)(int)v78) / v16;
		      }
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		      ConstantBuffer = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		                         (CBHandle *)&v273,
		                         &input->renderContext,
		                         160,
		                         0LL);
		      v84 = *(_OWORD *)&ConstantBuffer->bufferId;
		      *(_OWORD *)&physicalParameters_k__BackingField.m_Iso = *(_OWORD *)&ConstantBuffer->bufferId;
		      ptr = (Void *)ConstantBuffer->ptr;
		      *(_QWORD *)&physicalParameters_k__BackingField.m_BladeCount = ptr;
		      Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(ptr, (Void *)&P2, 160LL, 0LL);
		      v88 = 4
		          * !UnityEngine::SystemInfo::IsFormatSupported(GraphicsFormat__Enum_R16_SFloat, FormatUsage__Enum_Render, 0LL)
		          + 45;
		      if ( !hgCamera )
		        sub_1800D8250(v87, v86);
		      sceneRTSize_k__BackingField = hgCamera->fields._sceneRTSize_k__BackingField;
		      sub_18033B9D0(&v301, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		        &v301,
		        hgCamera->fields._sceneRTSize_k__BackingField.m_X,
		        sceneRTSize_k__BackingField.m_Y,
		        0LL);
		      v92 = *(_OWORD *)&v301.width;
		      v279 = *(_OWORD *)&v301.width;
		      v280 = *(_OWORD *)&v301.colorFormat;
		      v93 = *(_OWORD *)&v301.enableRandomWrite;
		      v281 = *(_OWORD *)&v301.enableRandomWrite;
		      *(_QWORD *)&v282 = *(_QWORD *)&v301.bindTextureMS;
		      v94 = *(_OWORD *)&v301.fastMemoryDesc.inFastMemory;
		      v283 = *(_OWORD *)&v301.fastMemoryDesc.inFastMemory;
		      clearColor = v301.clearColor;
		      v284 = v301.clearColor;
		      LODWORD(v280) = v88;
		      *((_QWORD *)&v282 + 1) = "Depth Of Field CoC";
		      if ( dword_18F35FD08 )
		      {
		        v96 = ((((unsigned __int64)&v282 + 8) >> 12) & 0x1FFFFF) >> 6;
		        v90 = (((unsigned __int64)&v282 + 8) >> 12) & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v96 + 36190]);
		        do
		        {
		          v91 = qword_18F0BCBA0[v96 + 36190] | (1LL << v90);
		          v97 = qword_18F0BCBA0[v96 + 36190];
		        }
		        while ( v97 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v96 + 36190], v91, v97) );
		        clearColor = v284;
		        v94 = v283;
		        v93 = v281;
		        v92 = v279;
		      }
		      *(_OWORD *)&v302.width = v92;
		      *(_OWORD *)&v302.colorFormat = v280;
		      *(_OWORD *)&v302.enableRandomWrite = v93;
		      *(_OWORD *)&v302.bindTextureMS = v282;
		      *(_OWORD *)&v302.fastMemoryDesc.inFastMemory = v94;
		      v302.clearColor = clearColor;
		      if ( !P3 )
		        sub_1800D8250(v91, v90);
		      v291 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                (TextureHandle *)&defaultNearStartColor,
		                (HGRenderGraph *)P3,
		                &v302,
		                0LL);
		      sub_18033B9D0(&v303, 0LL, 96LL);
		      HG::Rendering::RenderGraphModule::TextureDesc::TextureDesc(
		        &v303,
		        (int)P2.downsampleScreenSize.x,
		        (int)P2.downsampleScreenSize.y,
		        0LL);
		      v98 = *(_OWORD *)&v303.width;
		      v279 = *(_OWORD *)&v303.width;
		      v280 = *(_OWORD *)&v303.colorFormat;
		      v99 = *(_OWORD *)&v303.enableRandomWrite;
		      v281 = *(_OWORD *)&v303.enableRandomWrite;
		      *(_QWORD *)&v282 = *(_QWORD *)&v303.bindTextureMS;
		      v100 = *(_OWORD *)&v303.fastMemoryDesc.inFastMemory;
		      v283 = *(_OWORD *)&v303.fastMemoryDesc.inFastMemory;
		      v101 = v303.clearColor;
		      v284 = v303.clearColor;
		      LODWORD(v280) = 48;
		      *((_QWORD *)&v282 + 1) = "Depth Of Field Blur 0";
		      if ( dword_18F35FD08 )
		      {
		        v102 = ((((unsigned __int64)&v282 + 8) >> 12) & 0x1FFFFF) >> 6;
		        _m_prefetchw(&qword_18F0BCBA0[v102 + 36190]);
		        do
		          v103 = qword_18F0BCBA0[v102 + 36190];
		        while ( v103 != _InterlockedCompareExchange64(
		                          &qword_18F0BCBA0[v102 + 36190],
		                          v103 | (1LL << ((((unsigned __int64)&v282 + 8) >> 12) & 0x3F)),
		                          v103) );
		        v101 = v284;
		        v100 = v283;
		        v99 = v281;
		        v98 = v279;
		      }
		      *(_OWORD *)&v300.width = v98;
		      *(_OWORD *)&v300.colorFormat = v280;
		      *(_OWORD *)&v300.enableRandomWrite = v99;
		      *(_OWORD *)&v300.bindTextureMS = v282;
		      *(_OWORD *)&v300.fastMemoryDesc.inFastMemory = v100;
		      v300.clearColor = v101;
		      v277 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                (TextureHandle *)&defaultNearStartColor,
		                (HGRenderGraph *)P3,
		                &v300,
		                0LL);
		      v285 = *HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                (TextureHandle *)&defaultNearStartColor,
		                (HGRenderGraph *)P3,
		                &v300,
		                0LL);
		      defaultNearStartColor = (Vector4)*HG::Rendering::RenderGraphModule::HGRenderGraph::CreateTexture(
		                                          (TextureHandle *)&defaultNearStartColor,
		                                          (HGRenderGraph *)P3,
		                                          &input->sceneColor,
		                                          0LL);
		      v104 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		               (Int32Enum__Enum)0xA9u,
		               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v273,
		        (HGRenderGraph *)P3,
		        (String *)"Depth of Field 0",
		        &v271,
		        v104,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		      v288 = v273;
		      ex = 0LL;
		      v268 = &v288;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v288, 0, 0LL);
		        v107 = v271;
		        if ( !v271 )
		          sub_1800D8250(v106, v105);
		        *(_OWORD *)&v271[33].monitor = v84;
		        v107[34].monitor = (MonitorData *)ptr;
		        v108 = v271;
		        v111 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                  (TextureHandle *)&v266,
		                  &v288,
		                  &input->sceneDepth,
		                  0LL);
		        if ( !v108 )
		          sub_1800D8250(v110, v109);
		        v108[15] = (Object)v111;
		        v112 = v271;
		        if ( !v271 )
		          sub_1800D8250(v110, 0LL);
		        v271[37].monitor = (MonitorData *)v8->fields.m_mobileMaterial;
		        v113 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v114 = ((unsigned __int64)&v112[37].monitor >> 12) & 0x1FFFFF;
		          v115 = v114 >> 6;
		          v116 = v114 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v115 + 36190]);
		          do
		            v117 = qword_18F0BCBA0[v115 + 36190];
		          while ( v117 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v115 + 36190], v117 | (1LL << v116), v117) );
		          v113 = dword_18F35FD08;
		        }
		        v118 = v271;
		        m_mbp = (Object__Class *)v8->fields.m_mbp;
		        if ( !v271 )
		          sub_1800D8250(m_mbp, 0LL);
		        v271[37].klass = m_mbp;
		        if ( v113 )
		        {
		          v120 = ((unsigned __int64)&v118[37] >> 12) & 0x1FFFFF;
		          v121 = v120 >> 6;
		          v122 = v120 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v121 + 36190]);
		          do
		            v123 = qword_18F0BCBA0[v121 + 36190];
		          while ( v123 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v121 + 36190], v123 | (1LL << v122), v123) );
		        }
		        v124 = v271;
		        v125 = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		        if ( !v125 )
		          sub_1800D8250(v127, v126);
		        v128 = v125->fields.m_depthOfField;
		        if ( !v128 )
		          sub_1800D8250(v127, v126);
		        if ( v128->fields.focusMode )
		        {
		          usePhysicalProperties = 0;
		        }
		        else
		        {
		          v130 = hgCamera->fields.camera;
		          if ( !v130 )
		            sub_1800D8250(0LL, v126);
		          usePhysicalProperties = UnityEngine::Camera::get_usePhysicalProperties(v130, 0LL);
		        }
		        if ( !v124 )
		          sub_1800D8250(v127, v126);
		        LOBYTE(v124[1].klass) = usePhysicalProperties;
		        v266 = 0LL;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v273,
		          &v288,
		          &v291,
		          0,
		          RenderBufferLoadAction__Enum_DontCare,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&v266,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
		        _9__31_0 = TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_0;
		        if ( !_9__31_0 )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
		          v132 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9;
		          v133 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		          _9__31_0 = (RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *)v133;
		          if ( !v133 )
		            sub_1800D8250(v135, v134);
		          HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		            v133,
		            v132,
		            MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::_ConstructGaussianDepthOfFieldFar_b__31_0,
		            0LL);
		          TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_0 = _9__31_0;
		          if ( dword_18F35FD08 )
		          {
		            v136 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_0 >> 12) & 0x1FFFFF) >> 6;
		            v137 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_0 >> 12) & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v136 + 36190]);
		            do
		              v138 = qword_18F0BCBA0[v136 + 36190];
		            while ( v138 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v136 + 36190], v138 | (1LL << v137), v138) );
		          }
		        }
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v288,
		          (RenderFunc_1_System_Object_ *)_9__31_0,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v294 )
		      {
		        ex = v294->ex;
		        sub_180268AE0(&ex);
		        P3 = (Object *)renderGraph;
		        v8 = this;
		        ptr = *(Void **)&physicalParameters_k__BackingField.m_BladeCount;
		        v84 = *(_OWORD *)&physicalParameters_k__BackingField.m_Iso;
		        goto LABEL_85;
		      }
		      sub_180268AE0(&ex);
		LABEL_85:
		      v139 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		               (Int32Enum__Enum)0xA9u,
		               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v273,
		        (HGRenderGraph *)P3,
		        (String *)"Depth of Field 1",
		        &v272,
		        v139,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		      v287 = v273;
		      ex = 0LL;
		      v268 = &v287;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v287, 0, 0LL);
		        v142 = v272;
		        if ( !v272 )
		          sub_1800D8250(v141, v140);
		        *(_OWORD *)&v272[33].monitor = v84;
		        v142[34].monitor = (MonitorData *)ptr;
		        v143 = v272;
		        v146 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                  (TextureHandle *)&v273,
		                  &v287,
		                  &input->sceneColor,
		                  0LL);
		        if ( !v143 )
		          sub_1800D8250(v145, v144);
		        v143[14] = (Object)v146;
		        v147 = v272;
		        v150 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                  (TextureHandle *)&v273,
		                  &v287,
		                  &v291,
		                  0LL);
		        if ( !v147 )
		          sub_1800D8250(v149, v148);
		        v147[17] = (Object)v150;
		        v151 = v272;
		        if ( !v272 )
		          sub_1800D8250(v149, 0LL);
		        v272[37].monitor = (MonitorData *)v8->fields.m_mobileMaterial;
		        v152 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v153 = ((unsigned __int64)&v151[37].monitor >> 12) & 0x1FFFFF;
		          v154 = v153 >> 6;
		          v155 = v153 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v154 + 36190]);
		          do
		            v156 = qword_18F0BCBA0[v154 + 36190];
		          while ( v156 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v154 + 36190], v156 | (1LL << v155), v156) );
		          v152 = dword_18F35FD08;
		        }
		        v157 = v272;
		        v158 = (Object__Class *)v8->fields.m_mbp;
		        if ( !v272 )
		          sub_1800D8250(v158, 0LL);
		        v272[37].klass = v158;
		        if ( v152 )
		        {
		          v159 = ((unsigned __int64)&v157[37] >> 12) & 0x1FFFFF;
		          v160 = v159 >> 6;
		          v161 = v159 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v160 + 36190]);
		          do
		            v162 = qword_18F0BCBA0[v160 + 36190];
		          while ( v162 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v160 + 36190], v162 | (1LL << v161), v162) );
		        }
		        v266 = 0LL;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v273,
		          &v287,
		          &v285,
		          0,
		          RenderBufferLoadAction__Enum_DontCare,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&v266,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
		        _9__31_1 = TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_1;
		        if ( !_9__31_1 )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
		          v164 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9;
		          v165 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		          _9__31_1 = (RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *)v165;
		          if ( !v165 )
		            sub_1800D8250(v167, v166);
		          HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		            v165,
		            v164,
		            MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::_ConstructGaussianDepthOfFieldFar_b__31_1,
		            0LL);
		          TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_1 = _9__31_1;
		          if ( dword_18F35FD08 )
		          {
		            v168 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_1 >> 12) & 0x1FFFFF) >> 6;
		            v169 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_1 >> 12) & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v168 + 36190]);
		            do
		              v170 = qword_18F0BCBA0[v168 + 36190];
		            while ( v170 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v168 + 36190], v170 | (1LL << v169), v170) );
		          }
		        }
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v287,
		          (RenderFunc_1_System_Object_ *)_9__31_1,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v295 )
		      {
		        ex = v295->ex;
		        sub_180268AE0(&ex);
		        P3 = (Object *)renderGraph;
		        v8 = this;
		        ptr = *(Void **)&physicalParameters_k__BackingField.m_BladeCount;
		        v84 = *(_OWORD *)&physicalParameters_k__BackingField.m_Iso;
		        goto LABEL_105;
		      }
		      sub_180268AE0(&ex);
		LABEL_105:
		      v171 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		               (Int32Enum__Enum)0xA9u,
		               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v273,
		        (HGRenderGraph *)P3,
		        (String *)"Depth of Field 2",
		        &v274,
		        v171,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		      v289 = v273;
		      ex = 0LL;
		      v268 = &v289;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v289, 0, 0LL);
		        v174 = v274;
		        if ( !v274 )
		          sub_1800D8250(v173, v172);
		        *(_OWORD *)&v274[33].monitor = v84;
		        v174[34].monitor = (MonitorData *)ptr;
		        v175 = v274;
		        v178 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                  (TextureHandle *)&v273,
		                  &v289,
		                  &v285,
		                  0LL);
		        if ( !v175 )
		          sub_1800D8250(v177, v176);
		        v175[36] = (Object)v178;
		        v179 = v274;
		        if ( !v274 )
		          sub_1800D8250(v177, 0LL);
		        v274[37].monitor = (MonitorData *)v8->fields.m_mobileMaterial;
		        v180 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v181 = ((unsigned __int64)&v179[37].monitor >> 12) & 0x1FFFFF;
		          v182 = v181 >> 6;
		          v183 = v181 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v182 + 36190]);
		          do
		            v184 = qword_18F0BCBA0[v182 + 36190];
		          while ( v184 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v182 + 36190], v184 | (1LL << v183), v184) );
		          v180 = dword_18F35FD08;
		        }
		        v185 = v274;
		        v186 = (Object__Class *)v8->fields.m_mbp;
		        if ( !v274 )
		          sub_1800D8250(v186, 0LL);
		        v274[37].klass = v186;
		        if ( v180 )
		        {
		          v187 = ((unsigned __int64)&v185[37] >> 12) & 0x1FFFFF;
		          v188 = v187 >> 6;
		          v189 = v187 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v188 + 36190]);
		          do
		            v190 = qword_18F0BCBA0[v188 + 36190];
		          while ( v190 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v188 + 36190], v190 | (1LL << v189), v190) );
		        }
		        v266 = 0LL;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v273,
		          &v289,
		          &v277,
		          0,
		          RenderBufferLoadAction__Enum_DontCare,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&v266,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
		        _9__31_2 = TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_2;
		        if ( !_9__31_2 )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
		          v192 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9;
		          v193 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		          _9__31_2 = (RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *)v193;
		          if ( !v193 )
		            sub_1800D8250(v195, v194);
		          HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		            v193,
		            v192,
		            MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::_ConstructGaussianDepthOfFieldFar_b__31_2,
		            0LL);
		          TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_2 = _9__31_2;
		          if ( dword_18F35FD08 )
		          {
		            v196 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_2 >> 12) & 0x1FFFFF) >> 6;
		            v197 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_2 >> 12) & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v196 + 36190]);
		            do
		              v198 = qword_18F0BCBA0[v196 + 36190];
		            while ( v198 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v196 + 36190], v198 | (1LL << v197), v198) );
		          }
		        }
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v289,
		          (RenderFunc_1_System_Object_ *)_9__31_2,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v296 )
		      {
		        ex = v296->ex;
		        sub_180268AE0(&ex);
		        P3 = (Object *)renderGraph;
		        v8 = this;
		        ptr = *(Void **)&physicalParameters_k__BackingField.m_BladeCount;
		        v84 = *(_OWORD *)&physicalParameters_k__BackingField.m_Iso;
		        goto LABEL_124;
		      }
		      sub_180268AE0(&ex);
		LABEL_124:
		      v199 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		               (Int32Enum__Enum)0xA9u,
		               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v273,
		        (HGRenderGraph *)P3,
		        (String *)"Depth of Field 3",
		        &v275,
		        v199,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		      v290 = v273;
		      ex = 0LL;
		      v268 = &v290;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v290, 0, 0LL);
		        v202 = v275;
		        if ( !v275 )
		          sub_1800D8250(v201, v200);
		        *(_OWORD *)&v275[33].monitor = v84;
		        v202[34].monitor = (MonitorData *)ptr;
		        v203 = v275;
		        v206 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                  (TextureHandle *)&v273,
		                  &v290,
		                  &v277,
		                  0LL);
		        if ( !v203 )
		          sub_1800D8250(v205, v204);
		        v203[35] = (Object)v206;
		        v207 = v275;
		        if ( !v275 )
		          sub_1800D8250(v205, 0LL);
		        v275[37].monitor = (MonitorData *)v8->fields.m_mobileMaterial;
		        v208 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v209 = ((unsigned __int64)&v207[37].monitor >> 12) & 0x1FFFFF;
		          v210 = v209 >> 6;
		          v211 = v209 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v210 + 36190]);
		          do
		            v212 = qword_18F0BCBA0[v210 + 36190];
		          while ( v212 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v210 + 36190], v212 | (1LL << v211), v212) );
		          v208 = dword_18F35FD08;
		        }
		        v213 = v275;
		        v214 = (Object__Class *)v8->fields.m_mbp;
		        if ( !v275 )
		          sub_1800D8250(v214, 0LL);
		        v275[37].klass = v214;
		        if ( v208 )
		        {
		          v215 = ((unsigned __int64)&v213[37] >> 12) & 0x1FFFFF;
		          v216 = v215 >> 6;
		          v217 = v215 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v216 + 36190]);
		          do
		            v218 = qword_18F0BCBA0[v216 + 36190];
		          while ( v218 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v216 + 36190], v218 | (1LL << v217), v218) );
		        }
		        v277 = 0LL;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v273,
		          &v290,
		          &v285,
		          0,
		          RenderBufferLoadAction__Enum_DontCare,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&v277,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
		        _9__31_3 = TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_3;
		        if ( !_9__31_3 )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
		          v220 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9;
		          v221 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		          _9__31_3 = (RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *)v221;
		          if ( !v221 )
		            sub_1800D8250(v223, v222);
		          HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		            v221,
		            v220,
		            MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::_ConstructGaussianDepthOfFieldFar_b__31_3,
		            0LL);
		          TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_3 = _9__31_3;
		          if ( dword_18F35FD08 )
		          {
		            v224 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_3 >> 12) & 0x1FFFFF) >> 6;
		            v225 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_3 >> 12) & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v224 + 36190]);
		            do
		              v226 = qword_18F0BCBA0[v224 + 36190];
		            while ( v226 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v224 + 36190], v226 | (1LL << v225), v226) );
		          }
		        }
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v290,
		          (RenderFunc_1_System_Object_ *)_9__31_3,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v297 )
		      {
		        ex = v297->ex;
		        sub_180268AE0(&ex);
		        P3 = (Object *)renderGraph;
		        v8 = this;
		        ptr = *(Void **)&physicalParameters_k__BackingField.m_BladeCount;
		        v84 = *(_OWORD *)&physicalParameters_k__BackingField.m_Iso;
		        goto LABEL_143;
		      }
		      sub_180268AE0(&ex);
		LABEL_143:
		      v227 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		               (Int32Enum__Enum)0xA9u,
		               MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        (HGRenderGraphBuilder *)&physicalParameters_k__BackingField,
		        (HGRenderGraph *)P3,
		        (String *)"Depth of Field 4",
		        &v269,
		        v227,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		      *(_OWORD *)&v278.m_RenderPass = *(_OWORD *)&physicalParameters_k__BackingField.m_Iso;
		      *(_OWORD *)&v278.m_RenderGraph = *(_OWORD *)&physicalParameters_k__BackingField.m_BladeCount;
		      ex = 0LL;
		      v268 = &v278;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v278, 0, 0LL);
		        v230 = v269;
		        if ( !v269 )
		          sub_1800D8250(v229, v228);
		        *(_OWORD *)&v269[33].monitor = v84;
		        v230[34].monitor = (MonitorData *)ptr;
		        v231 = v269;
		        v234 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                  (TextureHandle *)&v273,
		                  &v278,
		                  &input->sceneColor,
		                  0LL);
		        if ( !v231 )
		          sub_1800D8250(v233, v232);
		        v231[14] = (Object)v234;
		        v235 = v269;
		        v238 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                  (TextureHandle *)&v273,
		                  &v278,
		                  &v291,
		                  0LL);
		        if ( !v235 )
		          sub_1800D8250(v237, v236);
		        v235[17] = (Object)v238;
		        v239 = v269;
		        v242 = *HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                  (TextureHandle *)&v273,
		                  &v278,
		                  &v285,
		                  0LL);
		        if ( !v239 )
		          sub_1800D8250(v241, v240);
		        v239[36] = (Object)v242;
		        v243 = v269;
		        if ( !v269 )
		          sub_1800D8250(v241, 0LL);
		        v269[37].monitor = (MonitorData *)v8->fields.m_mobileMaterial;
		        v244 = dword_18F35FD08;
		        if ( dword_18F35FD08 )
		        {
		          v245 = ((unsigned __int64)&v243[37].monitor >> 12) & 0x1FFFFF;
		          v246 = v245 >> 6;
		          v247 = v245 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v246 + 36190]);
		          do
		            v248 = qword_18F0BCBA0[v246 + 36190];
		          while ( v248 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v246 + 36190], v248 | (1LL << v247), v248) );
		          v244 = dword_18F35FD08;
		        }
		        v249 = v269;
		        v250 = (Object__Class *)v8->fields.m_mbp;
		        if ( !v269 )
		          sub_1800D8250(v250, 0LL);
		        v269[37].klass = v250;
		        if ( v244 )
		        {
		          v251 = ((unsigned __int64)&v249[37] >> 12) & 0x1FFFFF;
		          v252 = v251 >> 6;
		          v253 = v251 & 0x3F;
		          _m_prefetchw(&qword_18F0BCBA0[v252 + 36190]);
		          do
		            v254 = qword_18F0BCBA0[v252 + 36190];
		          while ( v254 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v252 + 36190], v254 | (1LL << v253), v254) );
		        }
		        v277 = 0LL;
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		          (TextureHandle *)&v273,
		          &v278,
		          (TextureHandle *)&defaultNearStartColor,
		          0,
		          RenderBufferLoadAction__Enum_DontCare,
		          RenderBufferStoreAction__Enum_Store,
		          (Color *)&v277,
		          0,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
		        _9__31_4 = TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_4;
		        if ( !_9__31_4 )
		        {
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c);
		          v256 = (Object *)TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9;
		          v257 = (RenderFunc_1_System_Object_ *)sub_18002C620(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		          _9__31_4 = (RenderFunc_1_HG_Rendering_Runtime_DepthOfFieldPassConstructor_CircleDepthOfFieldPassData_ *)v257;
		          if ( !v257 )
		            sub_1800D8250(v259, v258);
		          HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		            v257,
		            v256,
		            MethodInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c::_ConstructGaussianDepthOfFieldFar_b__31_4,
		            0LL);
		          TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_4 = _9__31_4;
		          if ( dword_18F35FD08 )
		          {
		            v260 = (((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_4 >> 12) & 0x1FFFFF) >> 6;
		            v261 = ((unsigned __int64)&TypeInfo::HG::Rendering::Runtime::DepthOfFieldPassConstructor::__c->static_fields->__9__31_4 >> 12) & 0x3F;
		            _m_prefetchw(&qword_18F0BCBA0[v260 + 36190]);
		            do
		              v262 = qword_18F0BCBA0[v260 + 36190];
		            while ( v262 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v260 + 36190], v262 | (1LL << v261), v262) );
		          }
		        }
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v278,
		          (RenderFunc_1_System_Object_ *)_9__31_4,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::DepthOfFieldPassConstructor::CircleDepthOfFieldPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v298 )
		      {
		        ex = v298->ex;
		        sub_180268AE0(&ex);
		        v8 = this;
		        goto LABEL_164;
		      }
		      sub_180268AE0(&ex);
		LABEL_164:
		      *(Vector4 *)output = defaultNearStartColor;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      v8->fields.m_previousSceneColorTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                                  (TextureHandle *)&v273,
		                                                  0LL);
		      v8->fields.m_currentSceneColorTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                                 (TextureHandle *)&v273,
		                                                 0LL);
		    }
		    catch ( Il2CppExceptionWrapper *v299 )
		    {
		      v286[0] = v299->ex;
		    }
		    sub_180269330(v286);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera hgCamera) {} // 0x0000000189B9957C-0x0000000189B9979C
		// Void ConstructPass(DepthOfFieldPassConstructor+PassInput ByRef, DepthOfFieldPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::ConstructPass(
		        DepthOfFieldPassConstructor *this,
		        DepthOfFieldPassConstructor_PassInput *input,
		        DepthOfFieldPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  TextureHandle v12; // xmm0
		  int32_t quality; // eax
		  TextureHandle v14; // xmm0
		  TextureHandle v15; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3077, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3077, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1138(
		        Patch,
		        (Object *)this,
		        input,
		        output,
		        (Object *)renderGraph,
		        (Object *)hgCamera,
		        0LL);
		      return;
		    }
		LABEL_16:
		    sub_1800D8260(Patch, v10);
		  }
		  this->fields.m_enable = HG::Rendering::Runtime::DepthOfFieldPassConstructor::IfEnable(this, hgCamera, input, 0LL);
		  if ( !HG::Rendering::Runtime::DepthOfFieldPassConstructor::get_enable(this, 0LL) )
		  {
		    *output = (DepthOfFieldPassConstructor_PassOutput)input->sceneColor;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    this->fields.m_previousSceneColorTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                                  &v15,
		                                                  0LL);
		    this->fields.m_currentSceneColorTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                                 &v15,
		                                                 0LL);
		    this->fields.m_previousDownSampleCoCTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                                     &v15,
		                                                     0LL);
		    v14 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v15, 0LL);
		    this->fields.m_fallbackPreviousFrame = 1;
		    this->fields.m_currentDownSampleCoCTexture = v14;
		    return;
		  }
		  if ( !hgCamera )
		    goto LABEL_16;
		  if ( hgCamera->fields.prevTransformReset )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    this->fields.m_previousSceneColorTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                                  &v15,
		                                                  0LL);
		    v12 = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v15, 0LL);
		    this->fields.m_fallbackPreviousFrame = 1;
		    this->fields.m_previousDownSampleCoCTexture = v12;
		  }
		  *output = (DepthOfFieldPassConstructor_PassOutput)input->sceneColor;
		  quality = input->quality;
		  input->quality = input->quality;
		  if ( quality )
		  {
		    switch ( quality )
		    {
		      case 1:
		        HG::Rendering::Runtime::DepthOfFieldPassConstructor::ConstructCircleDepthOfFieldLowFarNear(
		          this,
		          input,
		          output,
		          renderGraph,
		          hgCamera,
		          0LL);
		        break;
		      case 2:
		        HG::Rendering::Runtime::DepthOfFieldPassConstructor::ConstructCircleDepthOfFieldLowFar(
		          this,
		          input,
		          output,
		          renderGraph,
		          hgCamera,
		          0LL);
		        break;
		      case 3:
		        HG::Rendering::Runtime::DepthOfFieldPassConstructor::ConstructGaussianDepthOfFieldFar(
		          this,
		          input,
		          output,
		          renderGraph,
		          hgCamera,
		          0LL);
		        break;
		    }
		  }
		  else
		  {
		    HG::Rendering::Runtime::DepthOfFieldPassConstructor::ConstructCircleDepthOfFieldHighFarNear(
		      this,
		      input,
		      output,
		      renderGraph,
		      hgCamera,
		      0LL);
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189B99960-0x0000000189B999B4
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        DepthOfFieldPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3079, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3079, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189B9990C-0x0000000189B99960
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        DepthOfFieldPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3080, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3080, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189B9979C-0x0000000189B9990C
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        DepthOfFieldPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  __int64 v5; // rcx
		  TextureHandle *nullHandle; // rax
		  HGRenderGraph *renderGraph; // rdx
		  TextureHandle *v8; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  TextureHandle v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3081, 0LL) )
		  {
		    if ( input->passSkipped )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      this->fields.m_currentSceneColorTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                                   &v10,
		                                                   0LL);
		      this->fields.m_currentDownSampleCoCTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(
		                                                      &v10,
		                                                      0LL);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_currentSceneColorTexture, 0LL) )
		    {
		      renderGraph = input->renderGraph;
		      if ( !renderGraph )
		        goto LABEL_14;
		      nullHandle = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		                     &v10,
		                     renderGraph,
		                     &this->fields.m_currentSceneColorTexture,
		                     1,
		                     (String *)"Depth Of Field",
		                     0LL);
		    }
		    else
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v10, 0LL);
		    }
		    this->fields.m_previousSceneColorTexture = *nullHandle;
		    sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		    if ( !HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&this->fields.m_currentDownSampleCoCTexture, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      v8 = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v10, 0LL);
		LABEL_12:
		      this->fields.m_previousDownSampleCoCTexture = *v8;
		      return;
		    }
		    renderGraph = input->renderGraph;
		    if ( renderGraph )
		    {
		      v8 = HG::Rendering::RenderGraphModule::HGRenderGraph::PreserveTexture(
		             &v10,
		             renderGraph,
		             &this->fields.m_currentDownSampleCoCTexture,
		             1,
		             (String *)"Depth Of Field CoC",
		             0LL);
		      goto LABEL_12;
		    }
		LABEL_14:
		    sub_1800D8260(v5, renderGraph);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3081, 0LL);
		  if ( !Patch )
		    goto LABEL_14;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D80740-0x0000000184D80770
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::DepthOfFieldPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        DepthOfFieldPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3082, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3082, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		}
		
		public bool IfEnable(HGCamera hgCamera, ref PassInput input) => default; // 0x0000000189B999B4-0x0000000189B99A80
		// Boolean IfEnable(HGCamera, DepthOfFieldPassConstructor+PassInput ByRef)
		bool HG::Rendering::Runtime::DepthOfFieldPassConstructor::IfEnable(
		        DepthOfFieldPassConstructor *this,
		        HGCamera *hgCamera,
		        DepthOfFieldPassConstructor_PassInput *input,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  Camera *camera; // rcx
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  HGDepthOfField *m_depthOfField; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3078, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3078, 0LL);
		    if ( !Patch )
		      goto LABEL_11;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1141(Patch, (Object *)this, (Object *)hgCamera, input, 0LL);
		  }
		  else
		  {
		    if ( !hgCamera )
		      goto LABEL_11;
		    volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		    if ( !volumeComponentsData )
		      goto LABEL_11;
		    m_depthOfField = volumeComponentsData->fields.m_depthOfField;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality((Object_1 *)m_depthOfField, 0LL, 0LL) )
		    {
		      if ( !m_depthOfField )
		        goto LABEL_11;
		      if ( HG::Rendering::Runtime::HGDepthOfField::IsActive(m_depthOfField, 0LL) )
		      {
		        camera = hgCamera->fields.camera;
		        if ( camera )
		          return UnityEngine::Camera::get_cameraType(camera, 0LL) == CameraType__Enum_Game;
		LABEL_11:
		        sub_1800D8260(camera, v7);
		      }
		    }
		    return 0;
		  }
		}
		
	}
}
