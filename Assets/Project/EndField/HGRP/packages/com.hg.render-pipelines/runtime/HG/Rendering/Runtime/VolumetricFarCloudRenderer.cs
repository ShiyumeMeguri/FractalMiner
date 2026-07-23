using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VolumetricFarCloudRenderer // TypeDefIndex: 38721
	{
		// Fields
		private static readonly float MAX_FAR_CLOUD_FORCE_UPDATE_DISTANCE; // 0x00
		private Vector3 m_BakedFarCloudCenter; // 0x10
		private Vector3 m_BakedFarCloudLastCenter; // 0x1C
		private Vector3 m_BakedFarCloudLastLastCenter; // 0x28
		private VolumetricPipelineRT[] m_FarCloudComposeColors; // 0x38
		private VolumetricPipelineRT[] m_FarCloudComposeDepths; // 0x40
		private int m_FrameIndex; // 0x48
		private VolumetricPipelineRT[] m_FarCloudTAAColors; // 0x50
		private VolumetricPipelineRT[] m_FarCloudTAADepths; // 0x58
		private VolumetricPipelineRT m_FarCloudPanoramicColorRT; // 0x60
		private VolumetricPipelineRT m_FarCloudPanoramicDepthRT; // 0x68
		private VolumetricPipelineRT m_FarCloudDrawColorRT; // 0x70
		private VolumetricPipelineRT m_FarCloudDrawDepthRT; // 0x78
		private VolumetricPipelineRT m_FarCloudEmptySkipRT; // 0x80
		private Vector3 semicircularForward; // 0x88
		private Vector3 semicircularRight; // 0x94
		private Vector3 semicircularUp; // 0xA0
		private int slicingIndex; // 0xAC
		private Vector2 slicingCount; // 0xB0
		private float m_BakedFarCloudLastLastTime; // 0xB8
		private float m_BakedFarCloudLastTime; // 0xBC
		private float m_BakedFarCloudTime; // 0xC0
		private MaterialPropertyBlock m_propertyBlock; // 0xC8
		private MaterialPropertyBlock m_emptySkipPropertyBlock; // 0xD0
		private int lastAccessFrame; // 0xD8
	
		// Constructors
		public VolumetricFarCloudRenderer() {} // 0x0000000189C50558-0x0000000189C5069C
		// VolumetricFarCloudRenderer()
		void HG::Rendering::Runtime::VolumetricFarCloudRenderer::VolumetricFarCloudRenderer(
		        VolumetricFarCloudRenderer *this,
		        MethodInfo *method)
		{
		  int32_t v2; // r8d
		  MethodInfo *v3; // r9
		  Vector3 *Vector; // rax
		  Animator *z_low; // rdx
		  int32_t v7; // r8d
		  MethodInfo *v8; // r9
		  Vector3 *v9; // rax
		  float z; // ecx
		  Animator *v11; // rdx
		  int32_t v12; // r8d
		  MethodInfo *v13; // r9
		  Vector3 *v14; // rax
		  float v15; // ecx
		  HGRuntimeGrassQuery_Node *v16; // rdx
		  HGRuntimeGrassQuery_Node *v17; // r8
		  Int32__Array **v18; // r9
		  HGRuntimeGrassQuery_Node *v19; // rdx
		  HGRuntimeGrassQuery_Node *v20; // r8
		  Int32__Array **v21; // r9
		  HGRuntimeGrassQuery_Node *v22; // rdx
		  HGRuntimeGrassQuery_Node *v23; // r8
		  Int32__Array **v24; // r9
		  HGRuntimeGrassQuery_Node *v25; // rdx
		  HGRuntimeGrassQuery_Node *v26; // r8
		  Int32__Array **v27; // r9
		  Animator *v28; // rdx
		  int32_t v29; // r8d
		  MethodInfo *v30; // r9
		  Vector3 *v31; // rax
		  float v32; // ecx
		  Animator *v33; // rdx
		  int32_t v34; // r8d
		  MethodInfo *v35; // r9
		  Vector3 *v36; // rax
		  float v37; // ecx
		  Animator *v38; // rdx
		  int32_t v39; // r8d
		  MethodInfo *v40; // r9
		  Vector3 *v41; // rax
		  float v42; // ecx
		  Vector3 v43[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  Vector = UnityEngine::Animator::GetVector(v43, (Animator *)method, v2, v3);
		  z_low = (Animator *)LODWORD(Vector->z);
		  *(_QWORD *)&this->fields.m_BakedFarCloudCenter.x = *(_QWORD *)&Vector->x;
		  LODWORD(this->fields.m_BakedFarCloudCenter.z) = (_DWORD)z_low;
		  v9 = UnityEngine::Animator::GetVector(v43, z_low, v7, v8);
		  z = v9->z;
		  *(_QWORD *)&this->fields.m_BakedFarCloudLastCenter.x = *(_QWORD *)&v9->x;
		  this->fields.m_BakedFarCloudLastCenter.z = z;
		  v14 = UnityEngine::Animator::GetVector(v43, v11, v12, v13);
		  v15 = v14->z;
		  *(_QWORD *)&this->fields.m_BakedFarCloudLastLastCenter.x = *(_QWORD *)&v14->x;
		  this->fields.m_BakedFarCloudLastLastCenter.z = v15;
		  this->fields.m_FarCloudComposeColors = (VolumetricPipelineRT__Array *)il2cpp_array_new_specific_1(
		                                                                          TypeInfo::HG::Rendering::Runtime::VolumetricPipelineRT,
		                                                                          2LL);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_FarCloudComposeColors,
		    v16,
		    v17,
		    v18,
		    *(MethodInfo **)&v43[0].x);
		  this->fields.m_FarCloudComposeDepths = (VolumetricPipelineRT__Array *)il2cpp_array_new_specific_1(
		                                                                          TypeInfo::HG::Rendering::Runtime::VolumetricPipelineRT,
		                                                                          2LL);
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->fields.m_FarCloudComposeDepths,
		    v19,
		    v20,
		    v21,
		    *(MethodInfo **)&v43[0].x);
		  this->fields.m_FarCloudTAAColors = (VolumetricPipelineRT__Array *)il2cpp_array_new_specific_1(
		                                                                      TypeInfo::HG::Rendering::Runtime::VolumetricPipelineRT,
		                                                                      2LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_FarCloudTAAColors, v22, v23, v24, *(MethodInfo **)&v43[0].x);
		  this->fields.m_FarCloudTAADepths = (VolumetricPipelineRT__Array *)il2cpp_array_new_specific_1(
		                                                                      TypeInfo::HG::Rendering::Runtime::VolumetricPipelineRT,
		                                                                      2LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_FarCloudTAADepths, v25, v26, v27, *(MethodInfo **)&v43[0].x);
		  v31 = UnityEngine::Animator::GetVector(v43, v28, v29, v30);
		  v32 = v31->z;
		  *(_QWORD *)&this->fields.semicircularForward.x = *(_QWORD *)&v31->x;
		  this->fields.semicircularForward.z = v32;
		  v36 = UnityEngine::Animator::GetVector(v43, v33, v34, v35);
		  v37 = v36->z;
		  *(_QWORD *)&this->fields.semicircularRight.x = *(_QWORD *)&v36->x;
		  this->fields.semicircularRight.z = v37;
		  v41 = UnityEngine::Animator::GetVector(v43, v38, v39, v40);
		  v42 = v41->z;
		  *(_QWORD *)&this->fields.semicircularUp.x = *(_QWORD *)&v41->x;
		  this->fields.semicircularUp.z = v42;
		  this->fields.slicingCount.x = 1.0;
		  this->fields.slicingCount.y = 1.0;
		}
		
		static VolumetricFarCloudRenderer() {} // 0x0000000184DA1E00-0x0000000184DA1E20
		// VolumetricFarCloudRenderer()
		void HG::Rendering::Runtime::VolumetricFarCloudRenderer::cctor(MethodInfo *method)
		{
		  LODWORD(TypeInfo::HG::Rendering::Runtime::VolumetricFarCloudRenderer->static_fields->MAX_FAR_CLOUD_FORCE_UPDATE_DISTANCE) = (VolumetricFarCloudRenderer__StaticFields)1112014848;
		}
		
	
		// Methods
		public void MarkUsed() {} // 0x0000000189C4C18C-0x0000000189C4C1E4
		// Void MarkUsed()
		void HG::Rendering::Runtime::VolumetricFarCloudRenderer::MarkUsed(VolumetricFarCloudRenderer *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5070, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5070, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.lastAccessFrame = UnityEngine::Time::get_frameCount(0LL);
		  }
		}
		
		public bool CanBeReleased() => default; // 0x0000000189C4BEF8-0x0000000189C4BF54
		// Boolean CanBeReleased()
		bool HG::Rendering::Runtime::VolumetricFarCloudRenderer::CanBeReleased(
		        VolumetricFarCloudRenderer *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5050, 0LL) )
		    return UnityEngine::Time::get_frameCount(0LL) - this->fields.lastAccessFrame > 5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5050, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public void Initialize() {} // 0x0000000189C4BF54-0x0000000189C4C008
		// Void Initialize()
		void HG::Rendering::Runtime::VolumetricFarCloudRenderer::Initialize(
		        VolumetricFarCloudRenderer *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  MaterialPropertyBlock *v5; // rdi
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  MaterialPropertyBlock *v9; // rdi
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v14; // [rsp+20h] [rbp-8h]
		  MethodInfo *v15; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5069, 0LL) )
		  {
		    v5 = (MaterialPropertyBlock *)sub_18002C620(TypeInfo::UnityEngine::MaterialPropertyBlock);
		    if ( v5 )
		    {
		      v5->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		      this->fields.m_propertyBlock = v5;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_propertyBlock, v6, v7, v8, v14);
		      v9 = (MaterialPropertyBlock *)sub_18002C620(TypeInfo::UnityEngine::MaterialPropertyBlock);
		      if ( v9 )
		      {
		        v9->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		        this->fields.m_emptySkipPropertyBlock = v9;
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_emptySkipPropertyBlock, v10, v11, v12, v15);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5069, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void Release() {} // 0x0000000189C4C3AC-0x0000000189C4C42C
		// Void Release()
		void HG::Rendering::Runtime::VolumetricFarCloudRenderer::Release(VolumetricFarCloudRenderer *this, MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  HGRuntimeGrassQuery_Node *v6; // rdx
		  HGRuntimeGrassQuery_Node *v7; // r8
		  Int32__Array **v8; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		  MethodInfo *v13; // [rsp+50h] [rbp+28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5051, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5051, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VolumetricFarCloudRenderer::ReleaseFarCloudRTs(this, 1, 0LL);
		    this->fields.m_propertyBlock = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_propertyBlock, v3, v4, v5, v12);
		    this->fields.m_emptySkipPropertyBlock = 0LL;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_emptySkipPropertyBlock, v6, v7, v8, v13);
		  }
		}
		
		private void ReleaseFarCloudRTs(bool full) {} // 0x0000000189C4C23C-0x0000000189C4C3AC
		// Void ReleaseFarCloudRTs(Boolean)
		void HG::Rendering::Runtime::VolumetricFarCloudRenderer::ReleaseFarCloudRTs(
		        VolumetricFarCloudRenderer *this,
		        bool full,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  VolumetricPipelineRT__Array *m_FarCloudComposeDepths; // rcx
		  int i; // edi
		  VolumetricPipelineRT__Array *m_FarCloudComposeColors; // rbp
		  VolumetricPipelineRT **v9; // rax
		  VolumetricPipelineRT **v10; // rax
		  VolumetricPipelineRT **v11; // rax
		  VolumetricPipelineRT **v12; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5052, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5052, 0LL);
		    if ( !Patch )
		LABEL_10:
		      sub_1800D8260(m_FarCloudComposeDepths, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, full, 0LL);
		  }
		  else
		  {
		    for ( i = 0; i < 2; ++i )
		    {
		      m_FarCloudComposeColors = this->fields.m_FarCloudComposeColors;
		      if ( !m_FarCloudComposeColors )
		        goto LABEL_10;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      v9 = (VolumetricPipelineRT **)sub_1800036C0(m_FarCloudComposeColors, i);
		      HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v9, full, 0LL);
		      m_FarCloudComposeDepths = this->fields.m_FarCloudComposeDepths;
		      if ( !m_FarCloudComposeDepths )
		        goto LABEL_10;
		      v10 = (VolumetricPipelineRT **)sub_1800036C0(m_FarCloudComposeDepths, i);
		      HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v10, full, 0LL);
		      m_FarCloudComposeDepths = this->fields.m_FarCloudTAAColors;
		      if ( !m_FarCloudComposeDepths )
		        goto LABEL_10;
		      v11 = (VolumetricPipelineRT **)sub_1800036C0(m_FarCloudComposeDepths, i);
		      HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v11, full, 0LL);
		      m_FarCloudComposeDepths = this->fields.m_FarCloudTAADepths;
		      if ( !m_FarCloudComposeDepths )
		        goto LABEL_10;
		      v12 = (VolumetricPipelineRT **)sub_1800036C0(m_FarCloudComposeDepths, i);
		      HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(v12, full, 0LL);
		    }
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this->fields.m_FarCloudPanoramicColorRT, full, 0LL);
		    HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this->fields.m_FarCloudPanoramicDepthRT, full, 0LL);
		    HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this->fields.m_FarCloudDrawColorRT, full, 0LL);
		    HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this->fields.m_FarCloudDrawDepthRT, full, 0LL);
		    HG::Rendering::Runtime::VolumetricSDFUtils::ReleasePipelineRT(&this->fields.m_FarCloudEmptySkipRT, full, 0LL);
		  }
		}
		
		public void PostRender() {} // 0x0000000189C4C1E4-0x0000000189C4C23C
		// Void PostRender()
		void HG::Rendering::Runtime::VolumetricFarCloudRenderer::PostRender(
		        VolumetricFarCloudRenderer *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5102, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5102, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::VolumetricFarCloudRenderer::ReleaseFarCloudRTs(this, 0, 0LL);
		  }
		}
		
		public void UpdatePanoramicRT(HGCamera hgCamera, CommandBuffer cmd, Material cloudMat, MaterialPropertyBlock propertyBlock, HGVolumetricCloudSettingParameters volumetricParameters, bool force) {} // 0x0000000189C4F7F0-0x0000000189C50038
		// Void UpdatePanoramicRT(HGCamera, CommandBuffer, Material, MaterialPropertyBlock, HGVolumetricCloudSettingParameters, Boolean)
		void HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdatePanoramicRT(
		        VolumetricFarCloudRenderer *this,
		        HGCamera *hgCamera,
		        CommandBuffer *cmd,
		        Material *cloudMat,
		        MaterialPropertyBlock *propertyBlock,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        bool force,
		        MethodInfo *method)
		{
		  Animator *v12; // rdx
		  void *m_FarCloudPanoramicColorRT; // rcx
		  Int32Enum__Enum v14; // edi
		  Int32Enum__Enum v15; // ebx
		  RenderTexture *RT; // rax
		  RenderTexture *v17; // r15
		  Texture *v18; // rdi
		  Component *camera; // rbx
		  int32_t v20; // r8d
		  MethodInfo *v21; // r9
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  MethodInfo *v24; // r9
		  float z; // ebx
		  __int64 v26; // xmm6_8
		  float v27; // eax
		  Vector3 *v28; // rax
		  __int64 v29; // xmm3_8
		  float v30; // xmm7_4
		  Animator *v31; // rdx
		  int32_t v32; // r8d
		  MethodInfo *v33; // r9
		  MethodInfo *v34; // r8
		  Vector4 *v35; // rax
		  int32_t v36; // r10d
		  MaterialPropertyBlock *v37; // rcx
		  Vector3 *Vector; // rax
		  __int64 v39; // xmm1_8
		  float v40; // eax
		  __m128 v41; // xmm0
		  MethodInfo *v42; // rdx
		  Vector2 v43; // rax
		  MaterialPropertyBlock *m_propertyBlock; // rbx
		  __m128 y_low; // xmm6
		  bool v46; // cc
		  VolumetricShaderIDs__StaticFields *static_fields; // rax
		  int32_t FarCloudMarchRangeLocal; // edi
		  Vector4 *v49; // rax
		  MethodInfo *v50; // r8
		  Vector4 *v51; // rax
		  MaterialPropertyBlock *v52; // r10
		  int32_t v53; // r11d
		  MethodInfo *v54; // r8
		  Vector4 *v55; // rax
		  MaterialPropertyBlock *v56; // r10
		  int32_t v57; // r11d
		  int v58; // edi
		  int v59; // ebx
		  int v60; // eax
		  float FloatImpl; // xmm0_4
		  MaterialPropertyBlock *v62; // rbx
		  float v63; // xmm6_4
		  VolumetricShaderIDs__StaticFields *v64; // rcx
		  int32_t FlowSpeedScale; // edi
		  MethodInfo *v66; // rdx
		  float magnitude; // xmm7_4
		  float v68; // xmm0_4
		  MaterialPropertyBlock *v69; // rbx
		  int32_t FlowTime; // edi
		  float time; // xmm0_4
		  int v72; // eax
		  MethodInfo *v73; // r8
		  Vector3 v74; // [rsp+58h] [rbp-49h] BYREF
		  Vector3 m_BakedFarCloudCenter; // [rsp+68h] [rbp-39h] BYREF
		  Vector3 depthRT; // [rsp+78h] [rbp-29h] BYREF
		  Vector4 v77; // [rsp+88h] [rbp-19h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5089, 0LL) )
		  {
		    if ( volumetricParameters )
		    {
		      v14 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		              (SettingParameter_1_System_Int32Enum_ *)volumetricParameters->fields.panoramicSizeX,
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		      v15 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		              (SettingParameter_1_System_Int32Enum_ *)volumetricParameters->fields.panoramicSizeY,
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		      HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		        (String *)"m_FarCloudPanoramicColorRT",
		        &this->fields.m_FarCloudPanoramicColorRT,
		        v14,
		        v15,
		        RTLifeCycle__Enum_Persist,
		        RenderTextureFormat__Enum_ARGBHalf,
		        0,
		        0LL);
		      HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		        (String *)"m_FarCloudPanoramicDepthRT",
		        &this->fields.m_FarCloudPanoramicDepthRT,
		        v14,
		        v15,
		        RTLifeCycle__Enum_Persist,
		        RenderTextureFormat__Enum_RHalf,
		        0,
		        0LL);
		      m_FarCloudPanoramicColorRT = this->fields.m_FarCloudPanoramicColorRT;
		      if ( m_FarCloudPanoramicColorRT )
		      {
		        RT = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		               (VolumetricPipelineRT *)m_FarCloudPanoramicColorRT,
		               0LL);
		        m_FarCloudPanoramicColorRT = this->fields.m_FarCloudPanoramicDepthRT;
		        v17 = RT;
		        if ( m_FarCloudPanoramicColorRT )
		        {
		          *(_QWORD *)&depthRT.x = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                    (VolumetricPipelineRT *)m_FarCloudPanoramicColorRT,
		                                    0LL);
		          v18 = *(Texture **)&depthRT.x;
		          if ( hgCamera )
		          {
		            camera = (Component *)hgCamera->fields.camera;
		            sub_1800036A0(TypeInfo::UnityEngine::Object);
		            if ( UnityEngine::Object::op_Implicit((Object_1 *)camera, 0LL) )
		            {
		              if ( !camera )
		                goto LABEL_34;
		              transform = UnityEngine::Component::get_transform(camera, 0LL);
		              if ( !transform )
		                goto LABEL_34;
		              position = UnityEngine::Transform::get_position(&m_BakedFarCloudCenter, transform, 0LL);
		            }
		            else
		            {
		              position = UnityEngine::Animator::GetVector(&m_BakedFarCloudCenter, v12, v20, v21);
		            }
		            z = position->z;
		            v26 = *(_QWORD *)&position->x;
		            v27 = this->fields.m_BakedFarCloudCenter.z;
		            *(_QWORD *)&m_BakedFarCloudCenter.x = *(_QWORD *)&this->fields.m_BakedFarCloudCenter.x;
		            m_BakedFarCloudCenter.z = v27;
		            *(_QWORD *)&v74.x = v26;
		            v74.z = z;
		            v28 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v77, &v74, &m_BakedFarCloudCenter, v24);
		            v29 = *(_QWORD *)&v28->x;
		            *(float *)&v28 = v28->z;
		            *(_QWORD *)&m_BakedFarCloudCenter.x = v29;
		            LODWORD(m_BakedFarCloudCenter.z) = (_DWORD)v28;
		            v30 = sub_182F9FF00(&m_BakedFarCloudCenter);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		            m_FarCloudPanoramicColorRT = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		            if ( cloudMat )
		            {
		              if ( UnityEngine::Material::GetFloatImpl(cloudMat, *((_DWORD *)m_FarCloudPanoramicColorRT + 152), 0LL) < v30
		                || force )
		              {
		                Vector = UnityEngine::Animator::GetVector((Vector3 *)&v77, v31, v32, v33);
		                *(_QWORD *)&m_BakedFarCloudCenter.x = *(_QWORD *)&this->fields.m_BakedFarCloudCenter.x;
		                *(_QWORD *)&v74.x = *(_QWORD *)&Vector->x;
		                if ( (float)((float)((float)((float)(m_BakedFarCloudCenter.y - v74.y)
		                                           * (float)(m_BakedFarCloudCenter.y - v74.y))
		                                   + (float)((float)(m_BakedFarCloudCenter.x - v74.x)
		                                           * (float)(m_BakedFarCloudCenter.x - v74.x)))
		                           + (float)((float)(this->fields.m_BakedFarCloudCenter.z - Vector->z)
		                                   * (float)(this->fields.m_BakedFarCloudCenter.z - Vector->z))) >= 9.9999994e-11 )
		                {
		                  v39 = *(_QWORD *)&this->fields.m_BakedFarCloudCenter.x;
		                  v40 = this->fields.m_BakedFarCloudCenter.z;
		                }
		                else
		                {
		                  v39 = v26;
		                  v40 = z;
		                }
		                *(_QWORD *)&this->fields.m_BakedFarCloudLastCenter.x = v39;
		                this->fields.m_BakedFarCloudLastCenter.z = v40;
		                m_FarCloudPanoramicColorRT = this->fields.m_propertyBlock;
		                *(_QWORD *)&this->fields.m_BakedFarCloudCenter.x = v26;
		                this->fields.m_BakedFarCloudCenter.z = z;
		                if ( m_FarCloudPanoramicColorRT )
		                {
		                  UnityEngine::MaterialPropertyBlock::CopyFrom(
		                    (MaterialPropertyBlock *)m_FarCloudPanoramicColorRT,
		                    propertyBlock,
		                    0LL);
		                  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                  m_FarCloudPanoramicColorRT = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                  if ( propertyBlock )
		                  {
		                    v41 = *(__m128 *)UnityEngine::MaterialPropertyBlock::GetVector(
		                                       &v77,
		                                       propertyBlock,
		                                       *((_DWORD *)m_FarCloudPanoramicColorRT + 42),
		                                       0LL);
		                    v77 = (Vector4)v41;
		                    v43 = UnityEngine::Vector4::op_Implicit(&v77, v42);
		                    m_propertyBlock = this->fields.m_propertyBlock;
		                    *(Vector2 *)&v74.x = v43;
		                    y_low = (__m128)LODWORD(v43.y);
		                    v46 = v43.y <= 0.0;
		                    static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                    FarCloudMarchRangeLocal = static_fields->_FarCloudMarchRangeLocal;
		                    if ( v46 )
		                      y_low = 0LL;
		                    v41.m128_f32[0] = UnityEngine::MaterialPropertyBlock::GetFloatImpl(
		                                        propertyBlock,
		                                        static_fields->_InvGlobalScale,
		                                        0LL)
		                                    * 10000.0;
		                    v49 = (Vector4 *)sub_183240A00(&v77, _mm_unpacklo_ps(y_low, v41).m128_u64[0]);
		                    if ( m_propertyBlock )
		                    {
		                      v77 = *v49;
		                      UnityEngine::MaterialPropertyBlock::SetVector(m_propertyBlock, FarCloudMarchRangeLocal, &v77, 0LL);
		                      m_BakedFarCloudCenter = this->fields.m_BakedFarCloudCenter;
		                      v51 = UnityEngine::Vector4::op_Implicit(&v77, &m_BakedFarCloudCenter, v50);
		                      if ( v52 )
		                      {
		                        v77 = *v51;
		                        UnityEngine::MaterialPropertyBlock::SetVector(v52, v53, &v77, 0LL);
		                        m_BakedFarCloudCenter = this->fields.m_BakedFarCloudLastCenter;
		                        v55 = UnityEngine::Vector4::op_Implicit(&v77, &m_BakedFarCloudCenter, v54);
		                        if ( v56 )
		                        {
		                          v77 = *v55;
		                          UnityEngine::MaterialPropertyBlock::SetVector(v56, v57, &v77, 0LL);
		                          *(_QWORD *)&m_BakedFarCloudCenter.x = this->fields.m_propertyBlock;
		                          m_FarCloudPanoramicColorRT = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                          v74.x = *((float *)m_FarCloudPanoramicColorRT + 158);
		                          if ( v17 )
		                          {
		                            v58 = sub_180002F70(5LL, v17);
		                            v59 = sub_180002F70(7LL, v17);
		                            v60 = sub_180002F70(5LL, v17);
		                            v77.x = (float)v58;
		                            v77.z = 1.0 / (float)v60;
		                            v77.y = (float)v59;
		                            v77.w = 1.0 / (float)(int)sub_180002F70(7LL, v17);
		                            if ( *(_QWORD *)&m_BakedFarCloudCenter.x )
		                            {
		                              UnityEngine::MaterialPropertyBlock::SetVector(
		                                *(MaterialPropertyBlock **)&m_BakedFarCloudCenter.x,
		                                SLODWORD(v74.x),
		                                &v77,
		                                0LL);
		                              FloatImpl = UnityEngine::Material::GetFloatImpl(
		                                            cloudMat,
		                                            TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FlowTimeScale,
		                                            0LL);
		                              v62 = this->fields.m_propertyBlock;
		                              v63 = FloatImpl;
		                              v64 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                              FlowSpeedScale = v64->_FlowSpeedScale;
		                              v77 = *UnityEngine::Material::GetVector(&v77, cloudMat, v64->_WindSpeed, 0LL);
		                              magnitude = UnityEngine::Vector4::get_magnitude(&v77, v66);
		                              v68 = UnityEngine::MaterialPropertyBlock::GetFloatImpl(
		                                      propertyBlock,
		                                      TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_GlobalScale,
		                                      0LL);
		                              if ( v62 )
		                              {
		                                UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                  v62,
		                                  FlowSpeedScale,
		                                  (float)((float)(v68 * magnitude) * 0.050000001) / v63,
		                                  0LL);
		                                v69 = this->fields.m_propertyBlock;
		                                FlowTime = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FlowTime;
		                                time = UnityEngine::Time::get_time(0LL);
		                                if ( v69 )
		                                {
		                                  UnityEngine::MaterialPropertyBlock::SetFloatImpl(v69, FlowTime, time * v63, 0LL);
		                                  UnityEngine::Material::GetInt(
		                                    cloudMat,
		                                    TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PanoramicMarchStepNumEdit,
		                                    0LL);
		                                  HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                    volumetricParameters->fields.farCloudMarchStepScale,
		                                    MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		                                  v72 = sub_1832DBD50();
		                                  v12 = (Animator *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		                                  m_FarCloudPanoramicColorRT = this->fields.m_propertyBlock;
		                                  if ( m_FarCloudPanoramicColorRT )
		                                  {
		                                    UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                      (MaterialPropertyBlock *)m_FarCloudPanoramicColorRT,
		                                      TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_PanoramicMarchStepNum,
		                                      (float)v72,
		                                      0LL);
		                                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		                                    HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
		                                      cmd,
		                                      v17,
		                                      *(RenderTexture **)&depthRT.x,
		                                      RenderBufferLoadAction__Enum_DontCare,
		                                      RenderBufferStoreAction__Enum_Store,
		                                      0LL);
		                                    HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(
		                                      cmd,
		                                      cloudMat,
		                                      this->fields.m_propertyBlock,
		                                      5,
		                                      0,
		                                      0LL);
		                                    UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                                      propertyBlock,
		                                      TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudColor,
		                                      (Texture *)v17,
		                                      0LL);
		                                    UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                                      propertyBlock,
		                                      TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudDepth,
		                                      *(Texture **)&depthRT.x,
		                                      0LL);
		                                    depthRT = this->fields.m_BakedFarCloudCenter;
		                                    v35 = UnityEngine::Vector4::op_Implicit(&v77, &depthRT, v73);
		                                    v37 = propertyBlock;
		                                    goto LABEL_16;
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
		              else
		              {
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                m_FarCloudPanoramicColorRT = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                if ( propertyBlock )
		                {
		                  UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                    propertyBlock,
		                    *((_DWORD *)m_FarCloudPanoramicColorRT + 203),
		                    (Texture *)v17,
		                    0LL);
		                  UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                    propertyBlock,
		                    TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudDepth,
		                    v18,
		                    0LL);
		                  depthRT = this->fields.m_BakedFarCloudCenter;
		                  v35 = UnityEngine::Vector4::op_Implicit(&v77, &depthRT, v34);
		                  v37 = propertyBlock;
		LABEL_16:
		                  v77 = *v35;
		                  UnityEngine::MaterialPropertyBlock::SetVector(v37, v36, &v77, 0LL);
		                  return;
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_34:
		    sub_1800D8260(m_FarCloudPanoramicColorRT, v12);
		  }
		  m_FarCloudPanoramicColorRT = IFix::WrappersManagerImpl::GetPatch(5089, 0LL);
		  if ( !m_FarCloudPanoramicColorRT )
		    goto LABEL_34;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1485(
		    (ILFixDynamicMethodWrapper_2 *)m_FarCloudPanoramicColorRT,
		    (Object *)this,
		    (Object *)hgCamera,
		    (Object *)cmd,
		    (Object *)cloudMat,
		    (Object *)propertyBlock,
		    (Object *)volumetricParameters,
		    force,
		    0LL);
		}
		
		private void UpdateDynamicFarCloudRT(HGCamera hgCamera, CommandBuffer cmd, Material cloudMat, MaterialPropertyBlock propertyBlock, int farCloudSize, HGVolumetricCloudSettingParameters volumetricParameters, bool force = false /* Metadata: 0x023040C6 */, bool axisChanged = false /* Metadata: 0x023040C7 */) {} // 0x0000000189C4C42C-0x0000000189C4F574
		// Void UpdateDynamicFarCloudRT(HGCamera, CommandBuffer, Material, MaterialPropertyBlock, Int32, HGVolumetricCloudSettingParameters, Boolean, Boolean)
		void HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdateDynamicFarCloudRT(
		        VolumetricFarCloudRenderer *this,
		        HGCamera *hgCamera,
		        CommandBuffer *cmd,
		        Material *cloudMat,
		        MaterialPropertyBlock *propertyBlock,
		        int32_t farCloudSize,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        bool force,
		        bool axisChanged,
		        MethodInfo *method)
		{
		  _DWORD *m_FarCloudComposeDepths; // rdx
		  VolumetricPipelineRT *m_propertyBlock; // rcx
		  Component *camera; // rbx
		  int y; // eax
		  __int64 v18; // r8
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  void *v21; // xmm8_8
		  float z; // edi
		  void *v23; // xmm9_8
		  float v24; // r14d
		  double v25; // xmm0_8
		  float v26; // xmm6_4
		  bool v27; // r12
		  int32_t slicingIndex; // ebx
		  MethodInfo *v29; // r8
		  float time; // xmm3_4
		  void *v31; // xmm0_8
		  float v32; // eax
		  void *v33; // xmm1_8
		  float v34; // eax
		  float m_BakedFarCloudTime; // xmm0_4
		  float m_BakedFarCloudLastTime; // xmm0_4
		  float v37; // xmm0_4
		  Int32Enum__Enum v38; // ebx
		  SettingParameter_1_System_Boolean_ *farCloudEnableTAA; // rcx
		  bool v40; // al
		  int v41; // r14d
		  bool v42; // sf
		  unsigned int v43; // eax
		  unsigned int v44; // eax
		  __m128 v45; // xmm6
		  MaterialPropertyBlock *v46; // r12
		  float v47; // xmm0_4
		  float v48; // eax
		  MethodInfo *v49; // r8
		  Vector4 *v50; // rax
		  MaterialPropertyBlock *v51; // r10
		  MaterialPropertyBlock *v52; // r12
		  Matrix4x4 *Matrix; // rax
		  float v54; // xmm1_4
		  float v55; // xmm8_4
		  __int128 v56; // xmm1
		  __int128 v57; // xmm0
		  Vector4 *v58; // rax
		  float v59; // eax
		  MethodInfo *v60; // r8
		  Vector4 *v61; // rax
		  MaterialPropertyBlock *v62; // r10
		  VolumetricShaderIDs__StaticFields *static_fields; // rdx
		  _OWORD *v64; // rax
		  MaterialPropertyBlock *v65; // r10
		  float FloatImpl; // xmm9_4
		  float v67; // xmm0_4
		  float v68; // xmm6_4
		  float deltaTime; // xmm11_4
		  MethodInfo *v70; // r9
		  MethodInfo *v71; // r9
		  __m128 v72; // xmm12
		  __m128 v73; // xmm0
		  float v74; // xmm12_4
		  __m128 v75; // xmm15
		  float v76; // xmm13_4
		  float v77; // xmm10_4
		  float v78; // xmm15_4
		  float v79; // xmm13_4
		  float v80; // xmm10_4
		  __m128 v81; // xmm0
		  float v82; // xmm14_4
		  float v83; // xmm11_4
		  float v84; // xmm14_4
		  float v85; // xmm9_4
		  float v86; // xmm14_4
		  float v87; // xmm11_4
		  VolumetricShaderIDs__StaticFields *v88; // rdx
		  float v89; // xmm6_4
		  MaterialPropertyBlock *v90; // rbx
		  int32_t v91; // eax
		  MaterialPropertyBlock *v92; // rbx
		  MaterialPropertyBlock *v93; // rbx
		  MaterialPropertyBlock *v94; // rbx
		  __m128i v95; // xmm2
		  unsigned int v96; // eax
		  unsigned int v97; // eax
		  Shader *v98; // rbx
		  String *v99; // r8
		  __int64 v100; // rdx
		  __int64 v101; // rcx
		  int32_t v102; // ebx
		  Shader *v103; // rax
		  String *v104; // r8
		  Shader *v105; // rax
		  String *v106; // r8
		  Shader *v107; // rax
		  String *v108; // r8
		  Shader *shader; // rbx
		  String *s_FarCloudFramingCheckerboard; // r8
		  __int64 v111; // rdx
		  __int64 v112; // rcx
		  Shader *v113; // rax
		  String *s_FarCloudFramingQuarter; // r8
		  Shader *v115; // rax
		  String *s_FarCloudFraming4x2; // r8
		  Shader *v117; // rax
		  String *s_FarCloudFraming4x4; // r8
		  int i; // ebx
		  VolumetricPipelineRT **v120; // rax
		  VolumetricPipelineRT **v121; // rax
		  VolumetricPipelineRT__Array *m_FarCloudComposeColors; // r8
		  bool v123; // al
		  VolumetricPipelineRT **v124; // rax
		  VolumetricPipelineRT **v125; // rax
		  VolumetricPipelineRT *v126; // rax
		  bool v127; // al
		  int v128; // ebx
		  bool v129; // al
		  VolumetricPipelineRT *v130; // rax
		  bool v131; // al
		  VolumetricPipelineRT *v132; // rax
		  bool v133; // al
		  VolumetricPipelineRT *v134; // rax
		  char v135; // al
		  float v136; // xmm6_4
		  float v137; // xmm7_4
		  double v138; // xmm1_8
		  System::Math *v139; // rcx
		  int32_t v140; // ebx
		  double v141; // xmm1_8
		  System::Math *v142; // rcx
		  RenderTextureFormat__Enum format; // eax
		  _DWORD *p_InvPartialVPMatrix; // rdx
		  VolumetricPipelineRT *m_FarCloudEmptySkipRT; // rcx
		  RenderTexture *RT; // rax
		  RenderTexture *v147; // rbx
		  RenderTexture *v148; // rdi
		  float v149; // xmm9_4
		  float v150; // xmm10_4
		  float v151; // xmm6_4
		  float v152; // xmm0_4
		  Shader *v153; // rbx
		  String *s_FarCloudSlicingReproject; // r8
		  __int64 v155; // r8
		  Texture *v156; // rax
		  Texture *v157; // rax
		  Texture *v158; // rax
		  __int64 v159; // r12
		  Texture *v160; // rax
		  Texture *v161; // rax
		  Texture *v162; // rax
		  RenderTexture *v163; // rax
		  RenderTexture *v164; // rdi
		  RenderTexture *v165; // rax
		  MaterialPropertyBlock *v166; // rbx
		  Texture *v167; // rax
		  MaterialPropertyBlock *v168; // rbx
		  Texture *v169; // rax
		  MaterialPropertyBlock *v170; // rbx
		  MaterialPropertyBlock *m_KeywordSpace; // rcx
		  __m128i si128; // xmm0
		  int32_t FarCloudSlicingUVRescale; // edx
		  int v174; // ebx
		  int32_t v175; // edi
		  int32_t v176; // eax
		  int v177; // eax
		  int v178; // eax
		  RenderTexture *v179; // rbx
		  int v180; // eax
		  int32_t v181; // eax
		  int v182; // ebx
		  unsigned int v183; // edi
		  int v184; // eax
		  float v185; // xmm6_4
		  __m128i v186; // xmm0
		  float v187; // xmm7_4
		  float v188; // xmm10_4
		  float v189; // xmm9_4
		  __int64 v190; // rdx
		  __int64 v191; // rcx
		  float v192; // xmm10_4
		  MaterialPropertyBlock *v193; // rbx
		  MaterialPropertyBlock *v194; // rbx
		  bool v195; // cc
		  int32_t v196; // eax
		  float v197; // xmm0_4
		  MaterialPropertyBlock *v198; // rbx
		  MaterialPropertyBlock *v199; // rbx
		  SettingParameter_1_System_Boolean_ *farCloudFramingCubicSample; // rcx
		  bool v201; // al
		  VolumetricPipelineRT__Array *v202; // rdx
		  VolumetricPipelineRT *v203; // rcx
		  Shader *v204; // rbx
		  String *v205; // r8
		  __int64 v206; // r8
		  RenderTexture *v207; // rax
		  RenderTexture *v208; // rbx
		  MaterialPropertyBlock *v209; // rbx
		  RenderTexture *v210; // rax
		  MaterialPropertyBlock *v211; // rbx
		  int32_t v212; // r14d
		  MaterialPropertyBlock *v213; // rbx
		  MaterialPropertyBlock *v214; // rbx
		  int32_t v215; // r14d
		  Texture *v216; // rax
		  MaterialPropertyBlock *v217; // rbx
		  int32_t klass; // r14d
		  Texture *v219; // rax
		  MaterialPropertyBlock *v220; // rbx
		  int32_t FarCloudTAACubicSample; // r14d
		  bool v222; // al
		  RenderTexture *v223; // rax
		  RenderTexture *v224; // rdi
		  RenderTexture *v225; // rbx
		  MaterialPropertyBlock *v226; // rbx
		  Shader *v227; // rbx
		  String *v228; // r8
		  Shader *v229; // rax
		  String *v230; // r8
		  Shader *v231; // rax
		  String *v232; // r8
		  Shader *v233; // rax
		  String *v234; // r8
		  Shader *v235; // rax
		  String *s_FarCloudFramingComposeInPass; // r8
		  MaterialPropertyBlock *v237; // rbx
		  __int64 v238; // rdx
		  __int64 v239; // rcx
		  MaterialPropertyBlock *v240; // rdi
		  int32_t vrUsage_k__BackingField; // r12d
		  MaterialPropertyBlock *v242; // rdi
		  int32_t v243; // r12d
		  Texture *v244; // rax
		  MaterialPropertyBlock *v245; // rdi
		  int32_t v246; // r12d
		  Texture *v247; // rax
		  MaterialPropertyBlock *v248; // rdi
		  int32_t FarCloudReconstructCubicSample; // r12d
		  bool v250; // al
		  RenderTexture *v251; // rax
		  RenderTexture *v252; // rdi
		  RenderTexture *v253; // rbx
		  MaterialPropertyBlock *v254; // rbx
		  Texture *v255; // rax
		  RenderTargetIdentifier *v256; // rax
		  __int64 v257; // xmm8_8
		  __int128 v258; // xmm6
		  __int128 v259; // xmm7
		  Texture *v260; // rax
		  RenderTargetIdentifier *v261; // rax
		  __int128 v262; // xmm1
		  __int64 v263; // xmm0_8
		  __int64 v264; // rdx
		  __int64 v265; // r8
		  VolumetricPipelineRT *v266; // rcx
		  Texture *v267; // rax
		  RenderTargetIdentifier *v268; // rax
		  __int64 v269; // xmm8_8
		  __int128 v270; // xmm6
		  __int128 v271; // xmm7
		  Texture *v272; // rax
		  RenderTargetIdentifier *v273; // rax
		  __int128 v274; // xmm1
		  __int64 v275; // xmm0_8
		  int32_t v276; // ebx
		  VolumetricPipelineRT__Array *v277; // rax
		  Texture *v278; // rax
		  RenderTargetIdentifier *v279; // rax
		  __int64 v280; // xmm8_8
		  __int128 v281; // xmm6
		  __int128 v282; // xmm7
		  Texture *v283; // rax
		  RenderTargetIdentifier *v284; // rax
		  __int128 v285; // xmm1
		  __int64 v286; // xmm0_8
		  __int64 v287; // rdx
		  VolumetricPipelineRT *v288; // rcx
		  __int64 v289; // r8
		  VolumetricPipelineRT__Array *v290; // rax
		  Texture *v291; // rax
		  RenderTargetIdentifier *v292; // rax
		  __int64 v293; // xmm8_8
		  __int128 v294; // xmm6
		  __int128 v295; // xmm7
		  Texture *v296; // rax
		  RenderTargetIdentifier *v297; // rax
		  __int128 v298; // xmm1
		  __int64 v299; // xmm0_8
		  int v300; // edi
		  int32_t FarCloudColor; // edx
		  int32_t FarCloudEmptySkipRT; // r14d
		  Texture *v303; // rax
		  VolumetricShaderIDs__StaticFields *v304; // rdx
		  VolumetricShaderIDs__StaticFields *v305; // rdx
		  float v306; // xmm6_4
		  Shader *v307; // rbx
		  String *v308; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  char v310; // [rsp+88h] [rbp-80h]
		  char v311; // [rsp+88h] [rbp-80h]
		  char v312; // [rsp+88h] [rbp-80h]
		  char v313; // [rsp+88h] [rbp-80h]
		  bool v314; // [rsp+89h] [rbp-7Fh]
		  LocalKeyword value; // [rsp+98h] [rbp-70h] BYREF
		  bool v316; // [rsp+B8h] [rbp-50h]
		  bool v317; // [rsp+B9h] [rbp-4Fh]
		  int32_t height; // [rsp+BCh] [rbp-4Ch]
		  bool v319; // [rsp+C0h] [rbp-48h]
		  int32_t v320; // [rsp+C4h] [rbp-44h]
		  int v321; // [rsp+C8h] [rbp-40h]
		  LocalKeyword v322; // [rsp+D8h] [rbp-30h] BYREF
		  int v323; // [rsp+F8h] [rbp-10h]
		  int32_t name; // [rsp+FCh] [rbp-Ch]
		  LocalKeyword v325; // [rsp+108h] [rbp+0h] BYREF
		  int32_t width[2]; // [rsp+128h] [rbp+20h]
		  int x; // [rsp+130h] [rbp+28h]
		  RenderTexture *colorRT; // [rsp+138h] [rbp+30h]
		  int32_t v329[2]; // [rsp+140h] [rbp+38h]
		  Matrix4x4 keyword; // [rsp+148h] [rbp+40h] BYREF
		  Texture *v331; // [rsp+188h] [rbp+80h]
		  LocalKeyword v332; // [rsp+190h] [rbp+88h] BYREF
		  float v333; // [rsp+1A8h] [rbp+A0h]
		  Texture *v334; // [rsp+1B0h] [rbp+A8h]
		  Matrix4x4 v335; // [rsp+1B8h] [rbp+B0h] BYREF
		  Texture *v336; // [rsp+1F8h] [rbp+F0h]
		  LocalKeyword v337; // [rsp+200h] [rbp+F8h] BYREF
		  RenderTargetIdentifier v338[5]; // [rsp+218h] [rbp+110h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5098, 0LL) )
		  {
		    if ( !hgCamera )
		      goto LABEL_279;
		    camera = (Component *)hgCamera->fields.camera;
		    y = (int)this->fields.slicingCount.y;
		    x = (int)this->fields.slicingCount.x;
		    v329[0] = y;
		    v323 = x * y;
		    v319 = x * y > 1;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Implicit((Object_1 *)camera, 0LL) )
		    {
		      if ( !camera )
		        goto LABEL_279;
		      transform = UnityEngine::Component::get_transform(camera, 0LL);
		      if ( !transform )
		        goto LABEL_279;
		      position = UnityEngine::Transform::get_position((Vector3 *)&value, transform, 0LL);
		      v21 = *(void **)&position->x;
		      z = position->z;
		    }
		    else
		    {
		      z = COERCE_FLOAT(_mm_cvtsi128_si32((__m128i)0LL));
		      v21 = (void *)_mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		    }
		    value.m_SpaceInfo.m_KeywordSpace = *(void **)&this->fields.m_BakedFarCloudCenter.x;
		    if ( (float)((float)((float)((float)(*((float *)&value.m_SpaceInfo.m_KeywordSpace + 1) - 0.0)
		                               * (float)(*((float *)&value.m_SpaceInfo.m_KeywordSpace + 1) - 0.0))
		                       + (float)((float)(*(float *)&value.m_SpaceInfo.m_KeywordSpace - 0.0)
		                               * (float)(*(float *)&value.m_SpaceInfo.m_KeywordSpace - 0.0)))
		               + (float)((float)(this->fields.m_BakedFarCloudCenter.z - 0.0)
		                       * (float)(this->fields.m_BakedFarCloudCenter.z - 0.0))) >= 9.9999994e-11 )
		    {
		      v23 = *(void **)&this->fields.m_BakedFarCloudCenter.x;
		      v24 = this->fields.m_BakedFarCloudCenter.z;
		    }
		    else
		    {
		      v23 = v21;
		      v24 = z;
		    }
		    value.m_SpaceInfo.m_KeywordSpace = v23;
		    *(float *)&value.m_Name = v24;
		    v325.m_SpaceInfo.m_KeywordSpace = v21;
		    *(float *)&v325.m_Name = z;
		    v25 = sub_1833FD010(&v325, &value, v18);
		    v26 = *(float *)&v25;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricFarCloudRenderer);
		    if ( v26 <= TypeInfo::HG::Rendering::Runtime::VolumetricFarCloudRenderer->static_fields->MAX_FAR_CLOUD_FORCE_UPDATE_DISTANCE )
		    {
		      v314 = force;
		      v27 = force;
		      if ( !force )
		        goto LABEL_15;
		    }
		    else
		    {
		      v27 = 1;
		      v314 = 1;
		    }
		    this->fields.slicingIndex = v323 - 1;
		LABEL_15:
		    slicingIndex = this->fields.slicingIndex;
		    v316 = slicingIndex == v323 - 1;
		    time = UnityEngine::Time::get_time(0LL);
		    v333 = time;
		    if ( !slicingIndex )
		    {
		      v31 = *(void **)&this->fields.m_BakedFarCloudCenter.x;
		      v32 = this->fields.m_BakedFarCloudCenter.z;
		      LODWORD(value.m_Name) = 0;
		      value.m_SpaceInfo.m_KeywordSpace = (void *)_mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		      v325.m_SpaceInfo.m_KeywordSpace = v31;
		      *(float *)&v325.m_Name = v32;
		      if ( UnityEngine::Vector3::op_Equality((Vector3 *)&v325, (Vector3 *)&value, v29) )
		      {
		        v33 = v21;
		        v34 = z;
		      }
		      else
		      {
		        v33 = *(void **)&this->fields.m_BakedFarCloudLastCenter.x;
		        v34 = this->fields.m_BakedFarCloudLastCenter.z;
		      }
		      *(_QWORD *)&this->fields.m_BakedFarCloudLastLastCenter.x = v33;
		      this->fields.m_BakedFarCloudLastLastCenter.z = v34;
		      m_BakedFarCloudTime = this->fields.m_BakedFarCloudTime;
		      *(_QWORD *)&this->fields.m_BakedFarCloudLastCenter.x = v23;
		      *(_QWORD *)&this->fields.m_BakedFarCloudCenter.x = v21;
		      this->fields.m_BakedFarCloudLastCenter.z = v24;
		      this->fields.m_BakedFarCloudCenter.z = z;
		      if ( m_BakedFarCloudTime == 0.0 )
		        m_BakedFarCloudLastTime = time;
		      else
		        m_BakedFarCloudLastTime = this->fields.m_BakedFarCloudLastTime;
		      this->fields.m_BakedFarCloudLastLastTime = m_BakedFarCloudLastTime;
		      if ( this->fields.m_BakedFarCloudTime == 0.0 )
		        v37 = time;
		      else
		        v37 = this->fields.m_BakedFarCloudTime;
		      this->fields.m_BakedFarCloudLastTime = v37;
		      ++this->fields.m_FrameIndex;
		      this->fields.m_BakedFarCloudTime = time;
		      v314 = v27;
		    }
		    if ( !volumetricParameters )
		      goto LABEL_279;
		    v38 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		            (SettingParameter_1_System_Int32Enum_ *)volumetricParameters->fields.farCloudFramingLevel,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<HG::Rendering::Runtime::EFarCloudFramingQuality>::op_Implicit);
		    farCloudEnableTAA = volumetricParameters->fields.farCloudEnableTAA;
		    v320 = v38;
		    v40 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		            farCloudEnableTAA,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    v317 = v40;
		    if ( v38 )
		    {
		      LODWORD(colorRT) = 1;
		      v41 = this->fields.m_FrameIndex % 2;
		    }
		    else
		    {
		      LODWORD(colorRT) = 0;
		      v41 = 0;
		      v314 = v27;
		    }
		    if ( v40 )
		    {
		      v42 = this->fields.m_FrameIndex < 0;
		      v43 = this->fields.m_FrameIndex & 0x80000001;
		      v321 = v43;
		      if ( !v42 )
		      {
		LABEL_35:
		        m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_propertyBlock;
		        if ( !m_propertyBlock )
		          goto LABEL_279;
		        UnityEngine::MaterialPropertyBlock::CopyFrom((MaterialPropertyBlock *)m_propertyBlock, propertyBlock, 0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		        m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		        if ( !propertyBlock )
		          goto LABEL_279;
		        v45 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::MaterialPropertyBlock::GetVector(
		                                                         (Vector4 *)&v322,
		                                                         propertyBlock,
		                                                         m_propertyBlock[1].fields.Desc._vrUsage_k__BackingField,
		                                                         0LL));
		        v46 = this->fields.m_propertyBlock;
		        name = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudMarchRangeLocal;
		        v47 = UnityEngine::MaterialPropertyBlock::GetFloatImpl(
		                propertyBlock,
		                TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvGlobalScale,
		                0LL)
		            * 10000.0;
		        if ( !v46 )
		          goto LABEL_279;
		        value.m_Name = 0LL;
		        *((float *)&value.m_SpaceInfo.m_KeywordSpace + 1) = v47;
		        LODWORD(value.m_SpaceInfo.m_KeywordSpace) = _mm_shuffle_ps(v45, v45, 85).m128_u32[0];
		        UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(v46, name, (Vector4 *)&value, 0LL);
		        v48 = this->fields.m_BakedFarCloudCenter.z;
		        value.m_SpaceInfo.m_KeywordSpace = *(void **)&this->fields.m_BakedFarCloudCenter.x;
		        *(float *)&value.m_Name = v48;
		        v50 = UnityEngine::Vector4::op_Implicit((Vector4 *)&v322, (Vector3 *)&value, v49);
		        if ( !v51 )
		          goto LABEL_279;
		        *(Vector4 *)&value.m_SpaceInfo.m_KeywordSpace = *v50;
		        UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		          v51,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudCenter,
		          (Vector4 *)&value,
		          0LL);
		        v52 = this->fields.m_propertyBlock;
		        name = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudCenterLocal;
		        Matrix = UnityEngine::MaterialPropertyBlock::GetMatrix(
		                   &v335,
		                   propertyBlock,
		                   TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_BoxWorldToLocal,
		                   0LL);
		        v54 = this->fields.m_BakedFarCloudCenter.y;
		        v55 = 1.0;
		        *(float *)&value.m_SpaceInfo.m_KeywordSpace = this->fields.m_BakedFarCloudCenter.x;
		        *(float *)&value.m_Name = this->fields.m_BakedFarCloudCenter.z;
		        *((float *)&value.m_SpaceInfo.m_KeywordSpace + 1) = v54;
		        v56 = *(_OWORD *)&Matrix->m00;
		        HIDWORD(value.m_Name) = 1065353216;
		        *(_OWORD *)&keyword.m00 = v56;
		        v57 = *(_OWORD *)&Matrix->m01;
		        *(_OWORD *)&keyword.m02 = *(_OWORD *)&Matrix->m02;
		        *(_OWORD *)&keyword.m01 = v57;
		        *(_OWORD *)&keyword.m03 = *(_OWORD *)&Matrix->m03;
		        v58 = UnityEngine::Matrix4x4::op_Multiply((Vector4 *)&v322, &keyword, (Vector4 *)&value, 0LL);
		        if ( !v52 )
		          goto LABEL_279;
		        *(Vector4 *)&value.m_SpaceInfo.m_KeywordSpace = *v58;
		        UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(v52, name, (Vector4 *)&value, 0LL);
		        v59 = this->fields.m_BakedFarCloudLastCenter.z;
		        value.m_SpaceInfo.m_KeywordSpace = *(void **)&this->fields.m_BakedFarCloudLastCenter.x;
		        *(float *)&value.m_Name = v59;
		        v61 = UnityEngine::Vector4::op_Implicit((Vector4 *)&v322, (Vector3 *)&value, v60);
		        if ( !v62 )
		          goto LABEL_279;
		        *(Vector4 *)&value.m_SpaceInfo.m_KeywordSpace = *v61;
		        UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		          v62,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudLastCenter,
		          (Vector4 *)&value,
		          0LL);
		        m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_propertyBlock;
		        if ( !m_propertyBlock )
		          goto LABEL_279;
		        *(float *)&value.m_SpaceInfo.m_KeywordSpace = (float)farCloudSize;
		        *((float *)&value.m_SpaceInfo.m_KeywordSpace + 1) = (float)farCloudSize;
		        *(float *)&value.m_Name = 1.0 / (float)farCloudSize;
		        static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		        *((float *)&value.m_Name + 1) = *(float *)&value.m_Name;
		        UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		          (MaterialPropertyBlock *)m_propertyBlock,
		          static_fields->_FarCloudSize,
		          (Vector4 *)&value,
		          0LL);
		        v64 = (_OWORD *)sub_183240A00(&v322, _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0]);
		        if ( !v65 )
		          goto LABEL_279;
		        *(_OWORD *)&value.m_SpaceInfo.m_KeywordSpace = *v64;
		        UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		          v65,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NDCRescaleRatio,
		          (Vector4 *)&value,
		          0LL);
		        FloatImpl = UnityEngine::MaterialPropertyBlock::GetFloatImpl(
		                      propertyBlock,
		                      TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_GlobalScale,
		                      0LL);
		        if ( !cloudMat )
		          goto LABEL_279;
		        v67 = UnityEngine::Material::GetFloatImpl(
		                cloudMat,
		                TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NoiseTiling,
		                0LL);
		        m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_propertyBlock;
		        v68 = FloatImpl / v67;
		        if ( !m_propertyBlock )
		          goto LABEL_279;
		        UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		          (MaterialPropertyBlock *)m_propertyBlock,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindOffsetScale,
		          v68,
		          0LL);
		        m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_propertyBlock;
		        if ( !m_propertyBlock )
		          goto LABEL_279;
		        UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		          (MaterialPropertyBlock *)m_propertyBlock,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvWindOffsetScale,
		          1.0 / v68,
		          0LL);
		        deltaTime = UnityEngine::Time::get_deltaTime(0LL);
		        *(float *)&name = deltaTime;
		        *(Vector4 *)&value.m_SpaceInfo.m_KeywordSpace = *UnityEngine::Material::GetVector(
		                                                           (Vector4 *)&v322,
		                                                           cloudMat,
		                                                           TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindSpeed,
		                                                           0LL);
		        *(Vector4 *)&value.m_SpaceInfo.m_KeywordSpace = *UnityEngine::Vector4::op_Multiply(
		                                                           (Vector4 *)&v322,
		                                                           (Vector4 *)&value,
		                                                           FloatImpl,
		                                                           v70);
		        v72 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Multiply(
		                                                         (Vector4 *)&v322,
		                                                         (Vector4 *)&value,
		                                                         deltaTime,
		                                                         v71));
		        *(float *)&height = v72.m128_f32[0] * 0.050000001;
		        v73 = _mm_shuffle_ps(v72, v72, 85);
		        v73.m128_f32[0] = v73.m128_f32[0] * 0.050000001;
		        v74 = _mm_shuffle_ps(v72, v72, 170).m128_f32[0] * 0.050000001;
		        *(__m128 *)&v325.m_SpaceInfo.m_KeywordSpace = v73;
		        v75 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Material::GetVector(
		                                                         (Vector4 *)&v322,
		                                                         cloudMat,
		                                                         TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindSpeed2,
		                                                         0LL));
		        v76 = _mm_shuffle_ps(v75, v75, 85).m128_f32[0];
		        v77 = _mm_shuffle_ps(v75, v75, 170).m128_f32[0];
		        v78 = (float)((float)(v75.m128_f32[0] * FloatImpl) * deltaTime) * 0.050000001;
		        v79 = (float)((float)(v76 * FloatImpl) * deltaTime) * 0.050000001;
		        v80 = (float)((float)(v77 * FloatImpl) * deltaTime) * 0.050000001;
		        v81 = (__m128)_mm_loadu_si128((const __m128i *)UnityEngine::Material::GetVector(
		                                                         (Vector4 *)&v322,
		                                                         cloudMat,
		                                                         TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindSpeed3,
		                                                         0LL));
		        v82 = _mm_shuffle_ps(v81, v81, 85).m128_f32[0];
		        v83 = _mm_shuffle_ps(v81, v81, 170).m128_f32[0] * FloatImpl;
		        v81.m128_f32[0] = v81.m128_f32[0] * FloatImpl;
		        v84 = v82 * FloatImpl;
		        v85 = *(float *)&name;
		        v86 = (float)(v84 * *(float *)&name) * 0.050000001;
		        *(float *)width = (float)(v81.m128_f32[0] * *(float *)&name) * 0.050000001;
		        v87 = (float)(v83 * *(float *)&name) * 0.050000001;
		        m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_propertyBlock;
		        if ( !m_propertyBlock )
		          goto LABEL_279;
		        value.m_SpaceInfo.m_KeywordSpace = (void *)__PAIR64__((unsigned int)v325.m_SpaceInfo.m_KeywordSpace, height);
		        v88 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		        value.m_Name = (String *)LODWORD(v74);
		        UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		          (MaterialPropertyBlock *)m_propertyBlock,
		          v88->_WindOffset,
		          (Vector4 *)&value,
		          0LL);
		        m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_propertyBlock;
		        if ( !m_propertyBlock )
		          goto LABEL_279;
		        value.m_SpaceInfo.m_KeywordSpace = (void *)__PAIR64__(LODWORD(v79), LODWORD(v78));
		        value.m_Name = (String *)LODWORD(v80);
		        UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		          (MaterialPropertyBlock *)m_propertyBlock,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindOffset2,
		          (Vector4 *)&value,
		          0LL);
		        m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_propertyBlock;
		        if ( !m_propertyBlock )
		          goto LABEL_279;
		        value.m_SpaceInfo.m_KeywordSpace = (void *)__PAIR64__(LODWORD(v86), width[0]);
		        value.m_Name = (String *)LODWORD(v87);
		        UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		          (MaterialPropertyBlock *)m_propertyBlock,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_WindOffset3,
		          (Vector4 *)&value,
		          0LL);
		        if ( this->fields.m_BakedFarCloudTime == 0.0 || v323 <= 1 )
		          v89 = 1.0;
		        else
		          v89 = (float)(this->fields.m_BakedFarCloudTime - this->fields.m_BakedFarCloudLastTime) / v85;
		        v90 = this->fields.m_propertyBlock;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		        if ( !v90 )
		          goto LABEL_279;
		        UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		          v90,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudDeltaTimeScale,
		          v89,
		          0LL);
		        m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_propertyBlock;
		        if ( !m_propertyBlock )
		          goto LABEL_279;
		        UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		          (MaterialPropertyBlock *)m_propertyBlock,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudFrameCountMod8,
		          (float)(this->fields.m_FrameIndex % 8),
		          0LL);
		        _mm_cvtsi32_si128(
		          UnityEngine::Material::GetInt(
		            cloudMat,
		            TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudMarchStepNumEdit,
		            0LL));
		        HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		          volumetricParameters->fields.farCloudMarchStepScale,
		          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		        if ( v314 )
		          HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		            volumetricParameters->fields.farCloudFullUpdateMarchStepScale,
		            MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		        v91 = sub_1832DBD50();
		        v92 = this->fields.m_propertyBlock;
		        height = v91;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		        if ( !v92 )
		          goto LABEL_279;
		        UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		          v92,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudMarchStepNum,
		          (float)height,
		          0LL);
		        width[0] = farCloudSize;
		        height = farCloudSize;
		        if ( !(_DWORD)colorRT || axisChanged )
		        {
		          shader = UnityEngine::Material::get_shader(cloudMat, 0LL);
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		          s_FarCloudFramingCheckerboard = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FarCloudFramingCheckerboard;
		          memset(&v332, 0, sizeof(v332));
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v332, shader, s_FarCloudFramingCheckerboard, 0LL);
		          if ( !cmd )
		            sub_1800D8250(v112, v111);
		          *(_OWORD *)&keyword.m00 = *(_OWORD *)&v332.m_SpaceInfo.m_KeywordSpace;
		          *(_QWORD *)&keyword.m01 = *(_QWORD *)&v332.m_Index;
		          UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(
		            cmd,
		            cloudMat,
		            (LocalKeyword *)&keyword,
		            0LL);
		          v113 = UnityEngine::Material::get_shader(cloudMat, 0LL);
		          s_FarCloudFramingQuarter = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FarCloudFramingQuarter;
		          memset(&v322, 0, sizeof(v322));
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v322, v113, s_FarCloudFramingQuarter, 0LL);
		          *(_OWORD *)&keyword.m00 = *(_OWORD *)&v322.m_SpaceInfo.m_KeywordSpace;
		          *(_QWORD *)&keyword.m01 = *(_QWORD *)&v322.m_Index;
		          UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(
		            cmd,
		            cloudMat,
		            (LocalKeyword *)&keyword,
		            0LL);
		          v115 = UnityEngine::Material::get_shader(cloudMat, 0LL);
		          s_FarCloudFraming4x2 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FarCloudFraming4x2;
		          memset(&value, 0, sizeof(value));
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&value, v115, s_FarCloudFraming4x2, 0LL);
		          *(_OWORD *)&keyword.m00 = *(_OWORD *)&value.m_SpaceInfo.m_KeywordSpace;
		          *(_QWORD *)&keyword.m01 = *(_QWORD *)&value.m_Index;
		          UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(
		            cmd,
		            cloudMat,
		            (LocalKeyword *)&keyword,
		            0LL);
		          v117 = UnityEngine::Material::get_shader(cloudMat, 0LL);
		          s_FarCloudFraming4x4 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FarCloudFraming4x4;
		          memset(&v325, 0, sizeof(v325));
		          UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v325, v117, s_FarCloudFraming4x4, 0LL);
		          *(_OWORD *)&keyword.m00 = *(_OWORD *)&v325.m_SpaceInfo.m_KeywordSpace;
		          *(_QWORD *)&keyword.m01 = *(_QWORD *)&v325.m_Index;
		          UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(
		            cmd,
		            cloudMat,
		            (LocalKeyword *)&keyword,
		            0LL);
		          goto LABEL_86;
		        }
		        v93 = this->fields.m_propertyBlock;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		        if ( !v93 )
		          goto LABEL_279;
		        UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		          v93,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudFrameCountMod16,
		          (float)(this->fields.m_FrameIndex % 16),
		          0LL);
		        m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_propertyBlock;
		        if ( !m_propertyBlock )
		          goto LABEL_279;
		        UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		          (MaterialPropertyBlock *)m_propertyBlock,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudFrameCountMod32,
		          (float)(this->fields.m_FrameIndex % 32),
		          0LL);
		        m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_propertyBlock;
		        if ( !m_propertyBlock )
		          goto LABEL_279;
		        UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		          (MaterialPropertyBlock *)m_propertyBlock,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudFrameCountMod64,
		          (float)(this->fields.m_FrameIndex % 64),
		          0LL);
		        m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_propertyBlock;
		        if ( !m_propertyBlock )
		          goto LABEL_279;
		        UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		          (MaterialPropertyBlock *)m_propertyBlock,
		          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudFrameCountMod128,
		          (float)(this->fields.m_FrameIndex % 128),
		          0LL);
		        switch ( v320 )
		        {
		          case 1:
		            v94 = this->fields.m_propertyBlock;
		            width[0] = farCloudSize / 2;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		            if ( !v94 )
		              goto LABEL_279;
		            v96 = this->fields.m_FrameIndex & 0x80000001;
		            if ( this->fields.m_FrameIndex >= 0 )
		              goto LABEL_80;
		            v97 = ((_BYTE)v96 - 1) | 0xFFFFFFFE;
		            break;
		          case 2:
		            v94 = this->fields.m_propertyBlock;
		            width[0] = farCloudSize / 2;
		            height = farCloudSize / 2;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		            if ( !v94 )
		              goto LABEL_279;
		            v96 = this->fields.m_FrameIndex & 0x80000003;
		            if ( this->fields.m_FrameIndex >= 0 )
		              goto LABEL_80;
		            v97 = ((_BYTE)v96 - 1) | 0xFFFFFFFC;
		            break;
		          case 3:
		            v94 = this->fields.m_propertyBlock;
		            width[0] = farCloudSize / 4;
		            height = farCloudSize / 2;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		            if ( !v94 )
		              goto LABEL_279;
		            v96 = this->fields.m_FrameIndex & 0x80000007;
		            if ( this->fields.m_FrameIndex >= 0 )
		            {
		LABEL_80:
		              v95 = _mm_cvtsi32_si128(v96);
		              goto LABEL_81;
		            }
		            v97 = ((_BYTE)v96 - 1) | 0xFFFFFFF8;
		            break;
		          case 4:
		            v94 = this->fields.m_propertyBlock;
		            width[0] = farCloudSize / 4;
		            height = farCloudSize / 4;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		            if ( !v94 )
		              goto LABEL_279;
		            v95 = _mm_cvtsi32_si128(this->fields.m_FrameIndex % 16);
		LABEL_81:
		            UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		              v94,
		              TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudPixelSubOffset,
		              _mm_cvtepi32_ps(v95).m128_f32[0],
		              0LL);
		            goto LABEL_82;
		          default:
		LABEL_82:
		            v98 = UnityEngine::Material::get_shader(cloudMat, 0LL);
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		            v99 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FarCloudFramingCheckerboard;
		            memset(&v322, 0, sizeof(v322));
		            UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v322, v98, v99, 0LL);
		            if ( !cmd )
		              sub_1800D8250(v101, v100);
		            v102 = v320;
		            *(_OWORD *)&keyword.m00 = *(_OWORD *)&v322.m_SpaceInfo.m_KeywordSpace;
		            *(_QWORD *)&keyword.m01 = *(_QWORD *)&v322.m_Index;
		            UnityEngine::Rendering::CommandBuffer::SetMaterialKeyword_Injected(
		              cmd,
		              cloudMat,
		              (LocalKeyword *)&keyword,
		              v320 == 1,
		              0LL);
		            v103 = UnityEngine::Material::get_shader(cloudMat, 0LL);
		            v104 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FarCloudFramingQuarter;
		            memset(&value, 0, sizeof(value));
		            UnityEngine::Rendering::LocalKeyword::LocalKeyword(&value, v103, v104, 0LL);
		            *(_OWORD *)&keyword.m00 = *(_OWORD *)&value.m_SpaceInfo.m_KeywordSpace;
		            *(_QWORD *)&keyword.m01 = *(_QWORD *)&value.m_Index;
		            UnityEngine::Rendering::CommandBuffer::SetMaterialKeyword_Injected(
		              cmd,
		              cloudMat,
		              (LocalKeyword *)&keyword,
		              v102 == 2,
		              0LL);
		            v105 = UnityEngine::Material::get_shader(cloudMat, 0LL);
		            v106 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FarCloudFraming4x2;
		            memset(&v325, 0, sizeof(v325));
		            UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v325, v105, v106, 0LL);
		            *(_OWORD *)&keyword.m00 = *(_OWORD *)&v325.m_SpaceInfo.m_KeywordSpace;
		            *(_QWORD *)&keyword.m01 = *(_QWORD *)&v325.m_Index;
		            UnityEngine::Rendering::CommandBuffer::SetMaterialKeyword_Injected(
		              cmd,
		              cloudMat,
		              (LocalKeyword *)&keyword,
		              v102 == 3,
		              0LL);
		            v107 = UnityEngine::Material::get_shader(cloudMat, 0LL);
		            v108 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FarCloudFraming4x4;
		            memset(&v332, 0, sizeof(v332));
		            UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v332, v107, v108, 0LL);
		            *(_OWORD *)&keyword.m00 = *(_OWORD *)&v332.m_SpaceInfo.m_KeywordSpace;
		            *(_QWORD *)&keyword.m01 = *(_QWORD *)&v332.m_Index;
		            UnityEngine::Rendering::CommandBuffer::SetMaterialKeyword_Injected(
		              cmd,
		              cloudMat,
		              (LocalKeyword *)&keyword,
		              v102 == 4,
		              0LL);
		LABEL_86:
		            for ( i = 0; i < 2; ++i )
		            {
		              v325.m_SpaceInfo.m_KeywordSpace = this->fields.m_FarCloudComposeColors;
		              if ( !v325.m_SpaceInfo.m_KeywordSpace )
		                goto LABEL_279;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		              v120 = (VolumetricPipelineRT **)sub_1800036C0(v325.m_SpaceInfo.m_KeywordSpace, i);
		              HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		                (String *)"m_FarCloudComposeColors",
		                v120,
		                farCloudSize,
		                farCloudSize,
		                RTLifeCycle__Enum_Persist,
		                RenderTextureFormat__Enum_ARGBHalf,
		                0,
		                0LL);
		              m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudComposeDepths;
		              if ( !m_propertyBlock )
		                goto LABEL_279;
		              v121 = (VolumetricPipelineRT **)sub_1800036C0(m_propertyBlock, i);
		              HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		                (String *)"m_FarCloudComposeDepths",
		                v121,
		                farCloudSize,
		                farCloudSize,
		                RTLifeCycle__Enum_Persist,
		                RenderTextureFormat__Enum_RHalf,
		                0,
		                0LL);
		              m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudComposeColors;
		              if ( !m_propertyBlock )
		                goto LABEL_279;
		              if ( (unsigned int)i >= m_propertyBlock->fields.Desc._width_k__BackingField )
		                goto LABEL_291;
		              m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock->fields.Desc._msaaSamples_k__BackingField
		                                                        + i);
		              if ( !m_propertyBlock )
		                goto LABEL_279;
		              v325.m_SpaceInfo.m_KeywordSpace = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                  m_propertyBlock,
		                                                  0LL);
		              v123 = UnityEngine::SystemInfo::SupportsCubicFilter(0LL);
		              if ( v123 )
		                v123 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                         volumetricParameters->fields.farCloudFramingCubicSample,
		                         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		              m_propertyBlock = (VolumetricPipelineRT *)v325.m_SpaceInfo.m_KeywordSpace;
		              if ( !v325.m_SpaceInfo.m_KeywordSpace )
		                goto LABEL_279;
		              UnityEngine::Texture::set_cubicSample((Texture *)v325.m_SpaceInfo.m_KeywordSpace, v123, 0LL);
		              v325.m_SpaceInfo.m_KeywordSpace = this->fields.m_FarCloudTAAColors;
		              if ( !v325.m_SpaceInfo.m_KeywordSpace )
		                goto LABEL_279;
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		              v124 = (VolumetricPipelineRT **)sub_1800036C0(v325.m_SpaceInfo.m_KeywordSpace, i);
		              HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		                (String *)"m_FarCloudTAAColors",
		                v124,
		                farCloudSize,
		                farCloudSize,
		                RTLifeCycle__Enum_Persist,
		                RenderTextureFormat__Enum_ARGBHalf,
		                0,
		                0LL);
		              m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudTAADepths;
		              if ( !m_propertyBlock )
		                goto LABEL_279;
		              v125 = (VolumetricPipelineRT **)sub_1800036C0(m_propertyBlock, i);
		              HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		                (String *)"m_FarCloudTAADepths",
		                v125,
		                farCloudSize,
		                farCloudSize,
		                RTLifeCycle__Enum_Persist,
		                RenderTextureFormat__Enum_RHalf,
		                0,
		                0LL);
		              m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudTAAColors;
		              if ( !m_propertyBlock )
		                goto LABEL_279;
		              v126 = (VolumetricPipelineRT *)sub_1804A5398(m_propertyBlock, i);
		              if ( !v126 )
		                goto LABEL_279;
		              v325.m_SpaceInfo.m_KeywordSpace = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v126, 0LL);
		              v127 = UnityEngine::SystemInfo::SupportsCubicFilter(0LL);
		              if ( v127 )
		                v127 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                         volumetricParameters->fields.farCloudTAACubicSample,
		                         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		              m_propertyBlock = (VolumetricPipelineRT *)v325.m_SpaceInfo.m_KeywordSpace;
		              if ( !v325.m_SpaceInfo.m_KeywordSpace )
		                goto LABEL_279;
		              UnityEngine::Texture::set_cubicSample((Texture *)v325.m_SpaceInfo.m_KeywordSpace, v127, 0LL);
		            }
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		            HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		              (String *)"m_FarCloudDrawColorRT",
		              &this->fields.m_FarCloudDrawColorRT,
		              width[0],
		              height,
		              RTLifeCycle__Enum_Persist,
		              RenderTextureFormat__Enum_ARGBHalf,
		              0,
		              0LL);
		            HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		              (String *)"m_FarCloudDrawDepthRT",
		              &this->fields.m_FarCloudDrawDepthRT,
		              width[0],
		              height,
		              RTLifeCycle__Enum_Persist,
		              RenderTextureFormat__Enum_RHalf,
		              0,
		              0LL);
		            v128 = 0;
		            v310 = 0;
		            do
		            {
		              m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudComposeColors;
		              if ( !m_propertyBlock )
		                goto LABEL_279;
		              if ( (unsigned int)v128 >= m_propertyBlock->fields.Desc._width_k__BackingField )
		                goto LABEL_291;
		              m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock->fields.Desc._msaaSamples_k__BackingField
		                                                        + v128);
		              if ( !m_propertyBlock )
		                goto LABEL_279;
		              v129 = HG::Rendering::Runtime::VolumetricPipelineRT::ConsumeFreshlyCreated(m_propertyBlock, 0LL);
		              m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudComposeDepths;
		              v311 = v310 | v129;
		              if ( !m_propertyBlock )
		                goto LABEL_279;
		              v130 = (VolumetricPipelineRT *)sub_1804A5398(m_propertyBlock, v128);
		              if ( !v130 )
		                goto LABEL_279;
		              v131 = HG::Rendering::Runtime::VolumetricPipelineRT::ConsumeFreshlyCreated(v130, 0LL);
		              m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudTAAColors;
		              v312 = v311 | v131;
		              if ( !m_propertyBlock )
		                goto LABEL_279;
		              v132 = (VolumetricPipelineRT *)sub_1804A5398(m_propertyBlock, v128);
		              if ( !v132 )
		                goto LABEL_279;
		              v133 = HG::Rendering::Runtime::VolumetricPipelineRT::ConsumeFreshlyCreated(v132, 0LL);
		              m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudTAADepths;
		              v313 = v312 | v133;
		              if ( !m_propertyBlock )
		                goto LABEL_279;
		              v134 = (VolumetricPipelineRT *)sub_1804A5398(m_propertyBlock, v128);
		              if ( !v134 )
		                goto LABEL_279;
		              v135 = v313 | HG::Rendering::Runtime::VolumetricPipelineRT::ConsumeFreshlyCreated(v134, 0LL);
		              ++v128;
		              v310 = v135;
		            }
		            while ( v128 < 2 );
		            if ( v135 && !v314 )
		            {
		              v314 = 1;
		              this->fields.slicingIndex = v323 - 1;
		              v316 = 1;
		            }
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		            v136 = UnityEngine::Material::GetFloatImpl(
		                     cloudMat,
		                     TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudEmptySkipRTScale,
		                     0LL);
		            v137 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                     volumetricParameters->fields.farCloudEmptySkipSizeScale,
		                     MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit)
		                 * v136;
		            sub_1800036A0(TypeInfo::System::Math);
		            *(_QWORD *)&v138 = COERCE_UNSIGNED_INT((float)farCloudSize);
		            *(float *)&v138 = *(float *)&v138 * v137;
		            System::Math::Ceiling(v139, v138);
		            v140 = (int)*(float *)&v138;
		            *(_QWORD *)&v141 = COERCE_UNSIGNED_INT((float)farCloudSize);
		            LODWORD(colorRT) = v140;
		            *(float *)&v141 = *(float *)&v141 * v137;
		            System::Math::Ceiling(v142, v141);
		            height = (int)*(float *)&v141;
		            sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		            format = RenderTextureFormat__Enum_ARGBHalf;
		            if ( v323 <= 1 )
		              format = RenderTextureFormat__Enum_RGHalf;
		            HG::Rendering::Runtime::VolumetricSDFUtils::CreatePipelineRTIfNeeded(
		              (String *)"m_FarCloudEmptySkipRT",
		              &this->fields.m_FarCloudEmptySkipRT,
		              v140,
		              (int)*(float *)&v141,
		              RTLifeCycle__Enum_Persist,
		              format,
		              0,
		              0LL);
		            m_FarCloudEmptySkipRT = this->fields.m_FarCloudEmptySkipRT;
		            if ( m_FarCloudEmptySkipRT )
		            {
		              RT = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_FarCloudEmptySkipRT, 0LL);
		              m_FarCloudEmptySkipRT = (VolumetricPipelineRT *)this->fields.m_emptySkipPropertyBlock;
		              v147 = RT;
		              if ( m_FarCloudEmptySkipRT )
		              {
		                UnityEngine::MaterialPropertyBlock::CopyFrom(
		                  (MaterialPropertyBlock *)m_FarCloudEmptySkipRT,
		                  this->fields.m_propertyBlock,
		                  0LL);
		                v325.m_SpaceInfo.m_KeywordSpace = this->fields.m_emptySkipPropertyBlock;
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                m_FarCloudEmptySkipRT = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		                p_InvPartialVPMatrix = &TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvPartialVPMatrix;
		                v320 = p_InvPartialVPMatrix[195];
		                if ( v147 )
		                {
		                  v148 = v147;
		                  v149 = (float)(int)sub_180002F70(5LL, v147);
		                  v150 = (float)(int)sub_180002F70(7LL, v147);
		                  v151 = 1.0 / (float)(int)sub_180002F70(5LL, v147);
		                  v152 = (float)(int)sub_180002F70(7LL, v147);
		                  if ( v325.m_SpaceInfo.m_KeywordSpace )
		                  {
		                    value.m_SpaceInfo.m_KeywordSpace = (void *)__PAIR64__(LODWORD(v150), LODWORD(v149));
		                    *(float *)&value.m_Name = v151;
		                    *((float *)&value.m_Name + 1) = 1.0 / v152;
		                    UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		                      (MaterialPropertyBlock *)v325.m_SpaceInfo.m_KeywordSpace,
		                      v320,
		                      (Vector4 *)&value,
		                      0LL);
		                    m_FarCloudEmptySkipRT = (VolumetricPipelineRT *)this->fields.m_emptySkipPropertyBlock;
		                    if ( m_FarCloudEmptySkipRT )
		                    {
		                      value.m_Name = 0LL;
		                      *(float *)&value.m_SpaceInfo.m_KeywordSpace = 1.0 / (float)((float)farCloudSize * v137);
		                      *((float *)&value.m_SpaceInfo.m_KeywordSpace + 1) = *(float *)&value.m_SpaceInfo.m_KeywordSpace;
		                      UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		                        (MaterialPropertyBlock *)m_FarCloudEmptySkipRT,
		                        TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudEmptySkipUVScale,
		                        (Vector4 *)&value,
		                        0LL);
		                      m_FarCloudEmptySkipRT = (VolumetricPipelineRT *)this->fields.m_emptySkipPropertyBlock;
		                      if ( m_FarCloudEmptySkipRT )
		                      {
		                        value.m_Name = 0LL;
		                        value.m_SpaceInfo.m_KeywordSpace = (void *)__PAIR64__(
		                                                                     (float)height / (float)((float)farCloudSize * v137),
		                                                                     (float)(int)colorRT
		                                                                   / (float)((float)farCloudSize * v137));
		                        UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		                          (MaterialPropertyBlock *)m_FarCloudEmptySkipRT,
		                          TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_NDCRescaleRatio,
		                          (Vector4 *)&value,
		                          0LL);
		                        v153 = UnityEngine::Material::get_shader(cloudMat, 0LL);
		                        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		                        s_FarCloudSlicingReproject = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FarCloudSlicingReproject;
		                        memset(&v332, 0, sizeof(v332));
		                        UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v332, v153, s_FarCloudSlicingReproject, 0LL);
		                        *(_OWORD *)&keyword.m00 = *(_OWORD *)&v332.m_SpaceInfo.m_KeywordSpace;
		                        *(_QWORD *)&keyword.m01 = *(_QWORD *)&v332.m_Index;
		                        UnityEngine::Rendering::CommandBuffer::SetMaterialKeyword_Injected(
		                          cmd,
		                          cloudMat,
		                          (LocalKeyword *)&keyword,
		                          v319,
		                          0LL);
		                        HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTarget(cmd, v148, 0LL);
		                        HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(
		                          cmd,
		                          cloudMat,
		                          this->fields.m_emptySkipPropertyBlock,
		                          11,
		                          0,
		                          0LL);
		                        m_FarCloudEmptySkipRT = (VolumetricPipelineRT *)this->fields.m_propertyBlock;
		                        if ( m_FarCloudEmptySkipRT )
		                        {
		                          UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                            (MaterialPropertyBlock *)m_FarCloudEmptySkipRT,
		                            TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudEmptySkipRT,
		                            (Texture *)v148,
		                            0LL);
		                          m_FarCloudEmptySkipRT = (VolumetricPipelineRT *)this->fields.m_FarCloudComposeColors;
		                          if ( m_FarCloudEmptySkipRT )
		                          {
		                            if ( (unsigned int)v41 >= m_FarCloudEmptySkipRT->fields.Desc._width_k__BackingField )
		                              goto LABEL_289;
		                            m_FarCloudEmptySkipRT = (VolumetricPipelineRT *)*((_QWORD *)&m_FarCloudEmptySkipRT->fields.Desc._msaaSamples_k__BackingField
		                                                                            + v41);
		                            if ( !m_FarCloudEmptySkipRT )
		                              goto LABEL_290;
		                            v156 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                m_FarCloudEmptySkipRT,
		                                                0LL);
		                            p_InvPartialVPMatrix = this->fields.m_FarCloudComposeDepths;
		                            v334 = v156;
		                            if ( !p_InvPartialVPMatrix )
		                              goto LABEL_290;
		                            if ( (unsigned int)v41 >= p_InvPartialVPMatrix[6] )
		                              goto LABEL_289;
		                            m_FarCloudEmptySkipRT = *(VolumetricPipelineRT **)&p_InvPartialVPMatrix[2 * v41 + 8];
		                            if ( !m_FarCloudEmptySkipRT )
		                              goto LABEL_290;
		                            v157 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                m_FarCloudEmptySkipRT,
		                                                0LL);
		                            p_InvPartialVPMatrix = this->fields.m_FarCloudComposeColors;
		                            v331 = v157;
		                            if ( !p_InvPartialVPMatrix )
		                              goto LABEL_290;
		                            m_FarCloudEmptySkipRT = (VolumetricPipelineRT *)(unsigned int)(1 - v41);
		                            if ( (unsigned int)m_FarCloudEmptySkipRT >= p_InvPartialVPMatrix[6] )
		                              goto LABEL_289;
		                            m_FarCloudEmptySkipRT = *(VolumetricPipelineRT **)&p_InvPartialVPMatrix[2 * (int)m_FarCloudEmptySkipRT + 8];
		                            if ( !m_FarCloudEmptySkipRT )
		                              goto LABEL_290;
		                            v158 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                m_FarCloudEmptySkipRT,
		                                                0LL);
		                            p_InvPartialVPMatrix = this->fields.m_FarCloudComposeDepths;
		                            v336 = v158;
		                            if ( !p_InvPartialVPMatrix )
		                              goto LABEL_290;
		                            m_FarCloudEmptySkipRT = (VolumetricPipelineRT *)(unsigned int)(1 - v41);
		                            if ( (unsigned int)m_FarCloudEmptySkipRT >= p_InvPartialVPMatrix[6] )
		LABEL_289:
		                              sub_1800D2AA0(m_FarCloudEmptySkipRT, p_InvPartialVPMatrix, v155);
		                            m_FarCloudEmptySkipRT = *(VolumetricPipelineRT **)&p_InvPartialVPMatrix[2 * (int)m_FarCloudEmptySkipRT + 8];
		                            if ( m_FarCloudEmptySkipRT )
		                            {
		                              v325.m_SpaceInfo.m_KeywordSpace = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                                  m_FarCloudEmptySkipRT,
		                                                                  0LL);
		                              if ( v317 )
		                              {
		                                m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudTAAColors;
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                v159 = v321;
		                                if ( (unsigned int)v321 >= m_propertyBlock->fields.Desc._width_k__BackingField )
		                                  goto LABEL_291;
		                                m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock->fields.Desc._msaaSamples_k__BackingField
		                                                                          + v321);
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                v160 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                    m_propertyBlock,
		                                                    0LL);
		                                m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudTAADepths;
		                                v334 = v160;
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                if ( (unsigned int)v159 >= m_propertyBlock->fields.Desc._width_k__BackingField )
		                                  goto LABEL_291;
		                                m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock->fields.Desc._msaaSamples_k__BackingField
		                                                                          + v159);
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                v161 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                    m_propertyBlock,
		                                                    0LL);
		                                m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudTAAColors;
		                                v331 = v161;
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                if ( (unsigned int)(1 - v159) >= m_propertyBlock->fields.Desc._width_k__BackingField )
		                                  goto LABEL_291;
		                                m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock->fields.Desc._msaaSamples_k__BackingField
		                                                                          + 1
		                                                                          - (int)v159);
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                v162 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                    m_propertyBlock,
		                                                    0LL);
		                                m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudTAADepths;
		                                v336 = v162;
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                if ( (unsigned int)(1 - v159) >= m_propertyBlock->fields.Desc._width_k__BackingField )
		                                  goto LABEL_291;
		                                m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock->fields.Desc._msaaSamples_k__BackingField
		                                                                          + 1
		                                                                          - (int)v159);
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                v325.m_SpaceInfo.m_KeywordSpace = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                                    m_propertyBlock,
		                                                                    0LL);
		                              }
		                              else
		                              {
		                                LODWORD(v159) = v321;
		                              }
		                              if ( v314 )
		                              {
		                                v227 = UnityEngine::Material::get_shader(cloudMat, 0LL);
		                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		                                v228 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FarCloudFramingQuarter;
		                                memset(&value, 0, sizeof(value));
		                                UnityEngine::Rendering::LocalKeyword::LocalKeyword(&value, v227, v228, 0LL);
		                                v322 = value;
		                                UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(
		                                  cmd,
		                                  cloudMat,
		                                  &v322,
		                                  0LL);
		                                v229 = UnityEngine::Material::get_shader(cloudMat, 0LL);
		                                v230 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FarCloudFramingCheckerboard;
		                                memset(&v337, 0, sizeof(v337));
		                                UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v337, v229, v230, 0LL);
		                                v322 = v337;
		                                UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(
		                                  cmd,
		                                  cloudMat,
		                                  &v322,
		                                  0LL);
		                                v231 = UnityEngine::Material::get_shader(cloudMat, 0LL);
		                                v232 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FarCloudFraming4x2;
		                                memset(v338, 0, 24);
		                                UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		                                  (LocalKeyword *)v338,
		                                  v231,
		                                  v232,
		                                  0LL);
		                                *(_OWORD *)&v322.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v338[0].m_Type;
		                                *(_QWORD *)&v322.m_Index = v338[0].m_BufferPointer;
		                                UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(
		                                  cmd,
		                                  cloudMat,
		                                  &v322,
		                                  0LL);
		                                v233 = UnityEngine::Material::get_shader(cloudMat, 0LL);
		                                v234 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FarCloudFraming4x4;
		                                memset(&v335, 0, 24);
		                                UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		                                  (LocalKeyword *)&v335,
		                                  v233,
		                                  v234,
		                                  0LL);
		                                *(_OWORD *)&v322.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v335.m00;
		                                *(_QWORD *)&v322.m_Index = *(_QWORD *)&v335.m01;
		                                UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(
		                                  cmd,
		                                  cloudMat,
		                                  &v322,
		                                  0LL);
		                                v235 = UnityEngine::Material::get_shader(cloudMat, 0LL);
		                                s_FarCloudFramingComposeInPass = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FarCloudFramingComposeInPass;
		                                memset(&keyword, 0, 24);
		                                UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		                                  (LocalKeyword *)&keyword,
		                                  v235,
		                                  s_FarCloudFramingComposeInPass,
		                                  0LL);
		                                *(_OWORD *)&v322.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&keyword.m00;
		                                *(_QWORD *)&v322.m_Index = *(_QWORD *)&keyword.m01;
		                                UnityEngine::Rendering::CommandBuffer::DisableMaterialKeyword_Injected(
		                                  cmd,
		                                  cloudMat,
		                                  &v322,
		                                  0LL);
		                                v237 = this->fields.m_propertyBlock;
		                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                                if ( !v237 )
		                                  sub_1800D8250(v239, v238);
		                                *(__m128i *)&v322.m_SpaceInfo.m_KeywordSpace = _mm_load_si128((const __m128i *)&xmmword_18B959740);
		                                UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		                                  v237,
		                                  TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudSlicingUVRescale,
		                                  (Vector4 *)&v322,
		                                  0LL);
		                                v240 = this->fields.m_propertyBlock;
		                                m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                vrUsage_k__BackingField = m_propertyBlock[7].fields.Desc._vrUsage_k__BackingField;
		                                if ( this->fields.m_FrameIndex > 1 )
		                                  v55 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                          volumetricParameters->fields.farCloudFramingComposeRatio,
		                                          MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		                                if ( !v240 )
		                                  goto LABEL_279;
		                                UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                  v240,
		                                  vrUsage_k__BackingField,
		                                  v55,
		                                  0LL);
		                                v242 = this->fields.m_propertyBlock;
		                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                                m_FarCloudComposeColors = this->fields.m_FarCloudComposeColors;
		                                m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                v243 = *((_DWORD *)&m_propertyBlock[6].fields.bUsed + 1);
		                                if ( !m_FarCloudComposeColors )
		                                  goto LABEL_279;
		                                if ( (unsigned int)(1 - v41) >= m_FarCloudComposeColors->max_length.size )
		                                  goto LABEL_291;
		                                m_propertyBlock = m_FarCloudComposeColors->vector[1 - v41];
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                v244 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                    m_propertyBlock,
		                                                    0LL);
		                                if ( !v242 )
		                                  goto LABEL_279;
		                                UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(v242, v243, v244, 0LL);
		                                m_FarCloudComposeColors = this->fields.m_FarCloudComposeDepths;
		                                v245 = this->fields.m_propertyBlock;
		                                m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                v246 = (int32_t)m_propertyBlock[6].fields.rt;
		                                if ( !m_FarCloudComposeColors )
		                                  goto LABEL_279;
		                                if ( (unsigned int)(1 - v41) >= m_FarCloudComposeColors->max_length.size )
		                                  goto LABEL_291;
		                                m_propertyBlock = m_FarCloudComposeColors->vector[1 - v41];
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                v247 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                    m_propertyBlock,
		                                                    0LL);
		                                if ( !v245 )
		                                  goto LABEL_279;
		                                UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(v245, v246, v247, 0LL);
		                                v248 = this->fields.m_propertyBlock;
		                                FarCloudReconstructCubicSample = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudReconstructCubicSample;
		                                v250 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                         volumetricParameters->fields.farCloudFramingCubicSample,
		                                         MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		                                if ( !v248 )
		                                  goto LABEL_279;
		                                UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                  v248,
		                                  FarCloudReconstructCubicSample,
		                                  (float)v250,
		                                  0LL);
		                                m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudComposeColors;
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                if ( (unsigned int)v41 >= m_propertyBlock->fields.Desc._width_k__BackingField )
		                                  goto LABEL_291;
		                                m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock->fields.Desc._msaaSamples_k__BackingField
		                                                                          + v41);
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                v251 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
		                                m_FarCloudComposeDepths = this->fields.m_FarCloudComposeDepths;
		                                v252 = v251;
		                                if ( !m_FarCloudComposeDepths )
		                                  goto LABEL_279;
		                                if ( (unsigned int)v41 >= m_FarCloudComposeDepths[6] )
		                                  goto LABEL_291;
		                                m_propertyBlock = *(VolumetricPipelineRT **)&m_FarCloudComposeDepths[2 * v41 + 8];
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                v253 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
		                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		                                HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
		                                  cmd,
		                                  v252,
		                                  v253,
		                                  RenderBufferLoadAction__Enum_DontCare,
		                                  RenderBufferStoreAction__Enum_Store,
		                                  0LL);
		                                if ( force )
		                                {
		                                  *(__m128i *)&v322.m_SpaceInfo.m_KeywordSpace = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		                                  UnityEngine::Rendering::CommandBuffer::ClearRenderTarget(
		                                    cmd,
		                                    0,
		                                    1,
		                                    (Color *)&v322,
		                                    0LL);
		                                }
		                                v254 = this->fields.m_propertyBlock;
		                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		                                HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(cmd, cloudMat, v254, 6, 0, 0LL);
		                                m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudComposeColors;
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                if ( (unsigned int)v41 >= m_propertyBlock->fields.Desc._width_k__BackingField )
		                                  goto LABEL_291;
		                                m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock->fields.Desc._msaaSamples_k__BackingField
		                                                                          + v41);
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                v255 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                    m_propertyBlock,
		                                                    0LL);
		                                v256 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                                         (RenderTargetIdentifier *)&keyword,
		                                         v255,
		                                         0LL);
		                                m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudComposeColors;
		                                v257 = *(_QWORD *)&v256->m_DepthSlice;
		                                v258 = *(_OWORD *)&v256->m_Type;
		                                v259 = *(_OWORD *)&v256->m_BufferPointer;
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                if ( (unsigned int)(1 - v41) >= m_propertyBlock->fields.Desc._width_k__BackingField )
		                                  goto LABEL_291;
		                                m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock->fields.Desc._msaaSamples_k__BackingField
		                                                                          + 1
		                                                                          - v41);
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                v260 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                    m_propertyBlock,
		                                                    0LL);
		                                v261 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                                         (RenderTargetIdentifier *)&v335,
		                                         v260,
		                                         0LL);
		                                v262 = *(_OWORD *)&v261->m_BufferPointer;
		                                *(_OWORD *)&keyword.m00 = *(_OWORD *)&v261->m_Type;
		                                v263 = *(_QWORD *)&v261->m_DepthSlice;
		                                *(_OWORD *)&keyword.m01 = v262;
		                                *(_QWORD *)&keyword.m02 = v263;
		                                *(_OWORD *)&v335.m00 = v258;
		                                *(_OWORD *)&v335.m01 = v259;
		                                *(_QWORD *)&v335.m02 = v257;
		                                UnityEngine::Rendering::CommandBuffer::CopyTexture_Internal(
		                                  cmd,
		                                  (RenderTargetIdentifier *)&v335,
		                                  -1,
		                                  -1,
		                                  -1,
		                                  -1,
		                                  -1,
		                                  -1,
		                                  (RenderTargetIdentifier *)&keyword,
		                                  -1,
		                                  -1,
		                                  -1,
		                                  -1,
		                                  1,
		                                  0LL);
		                                v266 = (VolumetricPipelineRT *)this->fields.m_FarCloudComposeDepths;
		                                if ( !v266 )
		                                  goto LABEL_287;
		                                if ( (unsigned int)v41 >= v266->fields.Desc._width_k__BackingField )
		                                  sub_1800D2AA0(v266, v264, v265);
		                                v266 = (VolumetricPipelineRT *)*((_QWORD *)&v266->fields.Desc._msaaSamples_k__BackingField
		                                                               + v41);
		                                if ( !v266 )
		LABEL_287:
		                                  sub_1800D8250(v266, v264);
		                                v267 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v266, 0LL);
		                                v268 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v338, v267, 0LL);
		                                m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudComposeDepths;
		                                v269 = *(_QWORD *)&v268->m_DepthSlice;
		                                v270 = *(_OWORD *)&v268->m_Type;
		                                v271 = *(_OWORD *)&v268->m_BufferPointer;
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                if ( (unsigned int)(1 - v41) >= m_propertyBlock->fields.Desc._width_k__BackingField )
		                                  goto LABEL_291;
		                                m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock->fields.Desc._msaaSamples_k__BackingField
		                                                                          + 1
		                                                                          - v41);
		                                if ( !m_propertyBlock )
		                                  goto LABEL_279;
		                                v272 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                    m_propertyBlock,
		                                                    0LL);
		                                v273 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                                         (RenderTargetIdentifier *)&v335,
		                                         v272,
		                                         0LL);
		                                v274 = *(_OWORD *)&v273->m_BufferPointer;
		                                *(_OWORD *)&keyword.m00 = *(_OWORD *)&v273->m_Type;
		                                v275 = *(_QWORD *)&v273->m_DepthSlice;
		                                *(_OWORD *)&keyword.m01 = v274;
		                                *(_QWORD *)&keyword.m02 = v275;
		                                *(_OWORD *)&v335.m00 = v270;
		                                *(_OWORD *)&v335.m01 = v271;
		                                *(_QWORD *)&v335.m02 = v269;
		                                UnityEngine::Rendering::CommandBuffer::CopyTexture_Internal(
		                                  cmd,
		                                  (RenderTargetIdentifier *)&v335,
		                                  -1,
		                                  -1,
		                                  -1,
		                                  -1,
		                                  -1,
		                                  -1,
		                                  (RenderTargetIdentifier *)&keyword,
		                                  -1,
		                                  -1,
		                                  -1,
		                                  -1,
		                                  1,
		                                  0LL);
		                                if ( v317 )
		                                {
		                                  v276 = 0;
		                                  while ( 1 )
		                                  {
		                                    v277 = this->fields.m_FarCloudComposeColors;
		                                    if ( !v277 )
		                                      goto LABEL_279;
		                                    if ( (unsigned int)v41 >= v277->max_length.size )
		                                      goto LABEL_291;
		                                    m_propertyBlock = v277->vector[v41];
		                                    if ( !m_propertyBlock )
		                                      goto LABEL_279;
		                                    v278 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                        m_propertyBlock,
		                                                        0LL);
		                                    v279 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                                             (RenderTargetIdentifier *)&keyword,
		                                             v278,
		                                             0LL);
		                                    m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudTAAColors;
		                                    v280 = *(_QWORD *)&v279->m_DepthSlice;
		                                    v281 = *(_OWORD *)&v279->m_Type;
		                                    v282 = *(_OWORD *)&v279->m_BufferPointer;
		                                    if ( !m_propertyBlock )
		                                      goto LABEL_279;
		                                    if ( (unsigned int)v276 >= m_propertyBlock->fields.Desc._width_k__BackingField )
		                                      goto LABEL_291;
		                                    m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock->fields.Desc._msaaSamples_k__BackingField
		                                                                              + v276);
		                                    if ( !m_propertyBlock )
		                                      goto LABEL_279;
		                                    v283 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                        m_propertyBlock,
		                                                        0LL);
		                                    v284 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                                             (RenderTargetIdentifier *)&v335,
		                                             v283,
		                                             0LL);
		                                    v285 = *(_OWORD *)&v284->m_BufferPointer;
		                                    *(_OWORD *)&keyword.m00 = *(_OWORD *)&v284->m_Type;
		                                    v286 = *(_QWORD *)&v284->m_DepthSlice;
		                                    *(_OWORD *)&keyword.m01 = v285;
		                                    *(_QWORD *)&keyword.m02 = v286;
		                                    *(_OWORD *)&v335.m00 = v281;
		                                    *(_OWORD *)&v335.m01 = v282;
		                                    *(_QWORD *)&v335.m02 = v280;
		                                    UnityEngine::Rendering::CommandBuffer::CopyTexture_Internal(
		                                      cmd,
		                                      (RenderTargetIdentifier *)&v335,
		                                      -1,
		                                      -1,
		                                      -1,
		                                      -1,
		                                      -1,
		                                      -1,
		                                      (RenderTargetIdentifier *)&keyword,
		                                      -1,
		                                      -1,
		                                      -1,
		                                      -1,
		                                      1,
		                                      0LL);
		                                    v290 = this->fields.m_FarCloudComposeDepths;
		                                    if ( !v290 )
		                                      goto LABEL_286;
		                                    if ( (unsigned int)v41 >= v290->max_length.size )
		                                      sub_1800D2AA0(v288, v287, v289);
		                                    v288 = v290->vector[v41];
		                                    if ( !v288 )
		LABEL_286:
		                                      sub_1800D8250(v288, v287);
		                                    v291 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v288, 0LL);
		                                    v292 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(v338, v291, 0LL);
		                                    m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudTAADepths;
		                                    v293 = *(_QWORD *)&v292->m_DepthSlice;
		                                    v294 = *(_OWORD *)&v292->m_Type;
		                                    v295 = *(_OWORD *)&v292->m_BufferPointer;
		                                    if ( !m_propertyBlock )
		                                      goto LABEL_279;
		                                    if ( (unsigned int)v276 >= m_propertyBlock->fields.Desc._width_k__BackingField )
		                                      goto LABEL_291;
		                                    m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock->fields.Desc._msaaSamples_k__BackingField
		                                                                              + v276);
		                                    if ( !m_propertyBlock )
		                                      goto LABEL_279;
		                                    v296 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                        m_propertyBlock,
		                                                        0LL);
		                                    v297 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                                             (RenderTargetIdentifier *)&v335,
		                                             v296,
		                                             0LL);
		                                    v298 = *(_OWORD *)&v297->m_BufferPointer;
		                                    *(_OWORD *)&keyword.m00 = *(_OWORD *)&v297->m_Type;
		                                    v299 = *(_QWORD *)&v297->m_DepthSlice;
		                                    *(_OWORD *)&keyword.m01 = v298;
		                                    *(_QWORD *)&keyword.m02 = v299;
		                                    *(_OWORD *)&v335.m00 = v294;
		                                    *(_OWORD *)&v335.m01 = v295;
		                                    *(_QWORD *)&v335.m02 = v293;
		                                    UnityEngine::Rendering::CommandBuffer::CopyTexture_Internal(
		                                      cmd,
		                                      (RenderTargetIdentifier *)&v335,
		                                      -1,
		                                      -1,
		                                      -1,
		                                      -1,
		                                      -1,
		                                      -1,
		                                      (RenderTargetIdentifier *)&keyword,
		                                      -1,
		                                      -1,
		                                      -1,
		                                      -1,
		                                      1,
		                                      0LL);
		                                    if ( ++v276 >= 2 )
		                                      goto LABEL_272;
		                                  }
		                                }
		                                goto LABEL_272;
		                              }
		                              m_propertyBlock = this->fields.m_FarCloudDrawColorRT;
		                              if ( !m_propertyBlock )
		                                goto LABEL_279;
		                              v163 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
		                              m_propertyBlock = this->fields.m_FarCloudDrawDepthRT;
		                              v164 = v163;
		                              colorRT = v163;
		                              if ( !m_propertyBlock )
		                                goto LABEL_279;
		                              v165 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
		                              v166 = this->fields.m_propertyBlock;
		                              *(_QWORD *)width = v165;
		                              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                              m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		                              m_FarCloudComposeColors = this->fields.m_FarCloudComposeColors;
		                              m_FarCloudComposeDepths = &TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvPartialVPMatrix;
		                              v320 = m_FarCloudComposeDepths[177];
		                              if ( !m_FarCloudComposeColors )
		                                goto LABEL_279;
		                              m_propertyBlock = (VolumetricPipelineRT *)(unsigned int)(1 - v41);
		                              if ( (unsigned int)m_propertyBlock >= m_FarCloudComposeColors->max_length.size )
		                                goto LABEL_291;
		                              m_propertyBlock = m_FarCloudComposeColors->vector[(int)m_propertyBlock];
		                              if ( !m_propertyBlock )
		                                goto LABEL_279;
		                              v167 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                  m_propertyBlock,
		                                                  0LL);
		                              if ( !v166 )
		                                goto LABEL_279;
		                              UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(v166, v320, v167, 0LL);
		                              m_FarCloudComposeColors = this->fields.m_FarCloudComposeDepths;
		                              v168 = this->fields.m_propertyBlock;
		                              m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                              v320 = (int32_t)m_propertyBlock[6].fields.rt;
		                              if ( !m_FarCloudComposeColors )
		                                goto LABEL_279;
		                              if ( (unsigned int)(1 - v41) >= m_FarCloudComposeColors->max_length.size )
		                                goto LABEL_291;
		                              m_propertyBlock = m_FarCloudComposeColors->vector[1 - v41];
		                              if ( !m_propertyBlock )
		                                goto LABEL_279;
		                              v169 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                  m_propertyBlock,
		                                                  0LL);
		                              if ( !v168 )
		                                goto LABEL_279;
		                              UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(v168, v320, v169, 0LL);
		                              if ( v323 > 1 )
		                              {
		                                if ( !v164 )
		                                  goto LABEL_279;
		                                sub_180002F70(5LL, v164);
		                                v174 = sub_1832DBD50();
		                                sub_180002F70(7LL, v164);
		                                v175 = sub_1832DBD50();
		                                v176 = v175 * (this->fields.slicingIndex / x);
		                                v321 = v174 * (this->fields.slicingIndex % x);
		                                height = v176;
		                                v177 = sub_180002F70(5LL, colorRT);
		                                v178 = v177 - v321;
		                                if ( v174 < v178 )
		                                  v178 = v174;
		                                x = v178;
		                                v179 = colorRT;
		                                v180 = sub_180002F70(7LL, colorRT);
		                                v181 = v180 - height;
		                                if ( v175 < v181 )
		                                  v181 = v175;
		                                v320 = v181;
		                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		                                HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
		                                  cmd,
		                                  v179,
		                                  *(RenderTexture **)width,
		                                  RenderBufferLoadAction__Enum_Load,
		                                  RenderBufferStoreAction__Enum_Store,
		                                  0LL);
		                                if ( force )
		                                {
		                                  *(__m128i *)&value.m_SpaceInfo.m_KeywordSpace = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		                                  UnityEngine::Rendering::CommandBuffer::ClearRenderTarget(
		                                    cmd,
		                                    0,
		                                    1,
		                                    (Color *)&value,
		                                    0LL);
		                                }
		                                *(float *)&value.m_SpaceInfo.m_KeywordSpace = (float)v321;
		                                *((float *)&value.m_SpaceInfo.m_KeywordSpace + 1) = (float)height;
		                                *(float *)&value.m_Name = (float)x;
		                                *((float *)&value.m_Name + 1) = (float)v320;
		                                *(_OWORD *)&v322.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&value.m_SpaceInfo.m_KeywordSpace;
		                                UnityEngine::Rendering::CommandBuffer::SetViewport_Injected(cmd, (Rect *)&v322, 0LL);
		                                value.m_SpaceInfo.m_KeywordSpace = this->fields.m_propertyBlock;
		                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                                v329[0] = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudSlicingUVRescale;
		                                v182 = sub_180002F70(5LL, v179);
		                                v183 = sub_180002F70(7LL, colorRT);
		                                v184 = sub_180002F70(5LL, colorRT);
		                                v185 = (float)x / (float)v182;
		                                v186 = _mm_cvtsi32_si128(v183);
		                                v164 = colorRT;
		                                v187 = (float)v320 / _mm_cvtepi32_ps(v186).m128_f32[0];
		                                v188 = (float)height;
		                                v189 = (float)v321 / (float)v184;
		                                v192 = v188 / (float)(int)sub_180002F70(7LL, colorRT);
		                                if ( !value.m_SpaceInfo.m_KeywordSpace )
		                                  sub_1800D8250(v191, v190);
		                                FarCloudSlicingUVRescale = v329[0];
		                                m_KeywordSpace = (MaterialPropertyBlock *)value.m_SpaceInfo.m_KeywordSpace;
		                                value.m_SpaceInfo.m_KeywordSpace = (void *)__PAIR64__(LODWORD(v187), LODWORD(v185));
		                                value.m_Name = (String *)__PAIR64__(LODWORD(v192), LODWORD(v189));
		                                si128 = *(__m128i *)&value.m_SpaceInfo.m_KeywordSpace;
		                              }
		                              else
		                              {
		                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		                                HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
		                                  cmd,
		                                  v164,
		                                  *(RenderTexture **)width,
		                                  RenderBufferLoadAction__Enum_DontCare,
		                                  RenderBufferStoreAction__Enum_Store,
		                                  0LL);
		                                if ( force )
		                                {
		                                  *(__m128i *)&value.m_SpaceInfo.m_KeywordSpace = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		                                  UnityEngine::Rendering::CommandBuffer::ClearRenderTarget(
		                                    cmd,
		                                    0,
		                                    1,
		                                    (Color *)&value,
		                                    0LL);
		                                }
		                                v170 = this->fields.m_propertyBlock;
		                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                                if ( !v170 )
		                                  goto LABEL_279;
		                                m_KeywordSpace = v170;
		                                si128 = _mm_load_si128((const __m128i *)&xmmword_18B959740);
		                                FarCloudSlicingUVRescale = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudSlicingUVRescale;
		                              }
		                              *(__m128i *)&value.m_SpaceInfo.m_KeywordSpace = si128;
		                              UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		                                m_KeywordSpace,
		                                FarCloudSlicingUVRescale,
		                                (Vector4 *)&value,
		                                0LL);
		                              v193 = this->fields.m_propertyBlock;
		                              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		                              HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(cmd, cloudMat, v193, 6, 0, 0LL);
		                              if ( !v316 )
		                                goto LABEL_272;
		                              v194 = this->fields.m_propertyBlock;
		                              value.m_SpaceInfo.m_KeywordSpace = v194;
		                              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                              v195 = this->fields.m_FrameIndex <= 1;
		                              m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                              v196 = m_propertyBlock[7].fields.Desc._vrUsage_k__BackingField;
		                              v329[0] = v196;
		                              if ( v195 )
		                              {
		                                v197 = 1.0;
		                              }
		                              else
		                              {
		                                v197 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                         volumetricParameters->fields.farCloudFramingComposeRatio,
		                                         MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		                                v196 = v329[0];
		                                v194 = (MaterialPropertyBlock *)value.m_SpaceInfo.m_KeywordSpace;
		                              }
		                              if ( !v194 )
		                                goto LABEL_279;
		                              UnityEngine::MaterialPropertyBlock::SetFloatImpl(v194, v196, v197, 0LL);
		                              v198 = this->fields.m_propertyBlock;
		                              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                              if ( !v198 )
		                                goto LABEL_279;
		                              UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                                v198,
		                                TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudCurrentColor,
		                                (Texture *)v164,
		                                0LL);
		                              m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_propertyBlock;
		                              if ( !m_propertyBlock )
		                                goto LABEL_279;
		                              UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                                (MaterialPropertyBlock *)m_propertyBlock,
		                                TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudCurrentDepth,
		                                *(Texture **)width,
		                                0LL);
		                              v199 = this->fields.m_propertyBlock;
		                              farCloudFramingCubicSample = volumetricParameters->fields.farCloudFramingCubicSample;
		                              v329[0] = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudReconstructCubicSample;
		                              v201 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                       farCloudFramingCubicSample,
		                                       MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		                              if ( v199 )
		                              {
		                                UnityEngine::MaterialPropertyBlock::SetFloatImpl(v199, v329[0], (float)v201, 0LL);
		                                v204 = UnityEngine::Material::get_shader(cloudMat, 0LL);
		                                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		                                v205 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FarCloudFramingComposeInPass;
		                                memset(&v322, 0, sizeof(v322));
		                                UnityEngine::Rendering::LocalKeyword::LocalKeyword(&v322, v204, v205, 0LL);
		                                *(_OWORD *)&keyword.m00 = *(_OWORD *)&v322.m_SpaceInfo.m_KeywordSpace;
		                                *(_QWORD *)&keyword.m01 = *(_QWORD *)&v322.m_Index;
		                                UnityEngine::Rendering::CommandBuffer::SetMaterialKeyword_Injected(
		                                  cmd,
		                                  cloudMat,
		                                  (LocalKeyword *)&keyword,
		                                  axisChanged,
		                                  0LL);
		                                v203 = (VolumetricPipelineRT *)this->fields.m_FarCloudComposeColors;
		                                if ( v203 )
		                                {
		                                  if ( (unsigned int)v41 >= v203->fields.Desc._width_k__BackingField )
		                                    goto LABEL_281;
		                                  v203 = (VolumetricPipelineRT *)*((_QWORD *)&v203->fields.Desc._msaaSamples_k__BackingField
		                                                                 + v41);
		                                  if ( !v203 )
		                                    goto LABEL_282;
		                                  v207 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v203, 0LL);
		                                  v202 = this->fields.m_FarCloudComposeDepths;
		                                  value.m_SpaceInfo.m_KeywordSpace = v207;
		                                  if ( !v202 )
		                                    goto LABEL_282;
		                                  if ( (unsigned int)v41 >= v202->max_length.size )
		LABEL_281:
		                                    sub_1800D2AA0(v203, v202, v206);
		                                  v203 = v202->vector[v41];
		                                  if ( v203 )
		                                  {
		                                    v208 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(v203, 0LL);
		                                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		                                    HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
		                                      cmd,
		                                      (RenderTexture *)value.m_SpaceInfo.m_KeywordSpace,
		                                      v208,
		                                      RenderBufferLoadAction__Enum_DontCare,
		                                      RenderBufferStoreAction__Enum_Store,
		                                      0LL);
		                                    if ( force )
		                                    {
		                                      *(__m128i *)&v322.m_SpaceInfo.m_KeywordSpace = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		                                      UnityEngine::Rendering::CommandBuffer::ClearRenderTarget(
		                                        cmd,
		                                        0,
		                                        1,
		                                        (Color *)&v322,
		                                        0LL);
		                                    }
		                                    v209 = this->fields.m_propertyBlock;
		                                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		                                    HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(
		                                      cmd,
		                                      cloudMat,
		                                      v209,
		                                      7,
		                                      0,
		                                      0LL);
		                                    m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudComposeColors;
		                                    if ( !m_propertyBlock )
		                                      goto LABEL_279;
		                                    if ( (unsigned int)v41 >= m_propertyBlock->fields.Desc._width_k__BackingField )
		                                      goto LABEL_291;
		                                    m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock->fields.Desc._msaaSamples_k__BackingField
		                                                                              + v41);
		                                    if ( !m_propertyBlock )
		                                      goto LABEL_279;
		                                    v210 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(m_propertyBlock, 0LL);
		                                    m_FarCloudComposeDepths = this->fields.m_FarCloudComposeDepths;
		                                    value.m_SpaceInfo.m_KeywordSpace = v210;
		                                    if ( !m_FarCloudComposeDepths )
		                                      goto LABEL_279;
		                                    if ( (unsigned int)v41 >= m_FarCloudComposeDepths[6] )
		                                      goto LABEL_291;
		                                    m_propertyBlock = *(VolumetricPipelineRT **)&m_FarCloudComposeDepths[2 * v41 + 8];
		                                    if ( !m_propertyBlock )
		                                      goto LABEL_279;
		                                    *(_QWORD *)v329 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                        m_propertyBlock,
		                                                        0LL);
		                                    if ( v317 )
		                                    {
		                                      v211 = this->fields.m_propertyBlock;
		                                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                                      m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs;
		                                      m_FarCloudComposeDepths = &TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_InvPartialVPMatrix;
		                                      v212 = m_FarCloudComposeDepths[200];
		                                      if ( this->fields.m_FrameIndex > 1 )
		                                        v55 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
		                                                volumetricParameters->fields.farCloudTAABlendRatio,
		                                                MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
		                                      if ( !v211 )
		                                        goto LABEL_279;
		                                      UnityEngine::MaterialPropertyBlock::SetFloatImpl(v211, v212, v55, 0LL);
		                                      v213 = this->fields.m_propertyBlock;
		                                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                                      if ( !v213 )
		                                        goto LABEL_279;
		                                      UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                                        v213,
		                                        TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudTAACurrentColor,
		                                        (Texture *)value.m_SpaceInfo.m_KeywordSpace,
		                                        0LL);
		                                      m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_propertyBlock;
		                                      if ( !m_propertyBlock )
		                                        goto LABEL_279;
		                                      UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                                        (MaterialPropertyBlock *)m_propertyBlock,
		                                        TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudTAACurrentDepth,
		                                        *(Texture **)v329,
		                                        0LL);
		                                      m_FarCloudComposeColors = this->fields.m_FarCloudTAAColors;
		                                      v214 = this->fields.m_propertyBlock;
		                                      m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                      v215 = *((_DWORD *)&m_propertyBlock[6].fields._WasFreshlyCreated_k__BackingField
		                                             + 1);
		                                      if ( !m_FarCloudComposeColors )
		                                        goto LABEL_279;
		                                      if ( (unsigned int)(1 - v159) < m_FarCloudComposeColors->max_length.size )
		                                      {
		                                        m_propertyBlock = m_FarCloudComposeColors->vector[1 - (int)v159];
		                                        if ( !m_propertyBlock )
		                                          goto LABEL_279;
		                                        v216 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                            m_propertyBlock,
		                                                            0LL);
		                                        if ( !v214 )
		                                          goto LABEL_279;
		                                        UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(v214, v215, v216, 0LL);
		                                        m_FarCloudComposeColors = this->fields.m_FarCloudTAADepths;
		                                        v217 = this->fields.m_propertyBlock;
		                                        m_propertyBlock = (VolumetricPipelineRT *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                        klass = (int32_t)m_propertyBlock[7].klass;
		                                        if ( !m_FarCloudComposeColors )
		                                          goto LABEL_279;
		                                        if ( (unsigned int)(1 - v159) < m_FarCloudComposeColors->max_length.size )
		                                        {
		                                          m_propertyBlock = m_FarCloudComposeColors->vector[1 - (int)v159];
		                                          if ( !m_propertyBlock )
		                                            goto LABEL_279;
		                                          v219 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                              m_propertyBlock,
		                                                              0LL);
		                                          if ( !v217 )
		                                            goto LABEL_279;
		                                          UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(v217, klass, v219, 0LL);
		                                          v220 = this->fields.m_propertyBlock;
		                                          FarCloudTAACubicSample = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudTAACubicSample;
		                                          v222 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		                                                   volumetricParameters->fields.farCloudTAACubicSample,
		                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		                                          if ( !v220 )
		                                            goto LABEL_279;
		                                          UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                            v220,
		                                            FarCloudTAACubicSample,
		                                            (float)v222,
		                                            0LL);
		                                          m_propertyBlock = (VolumetricPipelineRT *)this->fields.m_FarCloudTAAColors;
		                                          if ( !m_propertyBlock )
		                                            goto LABEL_279;
		                                          if ( (unsigned int)v159 < m_propertyBlock->fields.Desc._width_k__BackingField )
		                                          {
		                                            m_propertyBlock = (VolumetricPipelineRT *)*((_QWORD *)&m_propertyBlock->fields.Desc._msaaSamples_k__BackingField
		                                                                                      + (int)v159);
		                                            if ( !m_propertyBlock )
		                                              goto LABEL_279;
		                                            v223 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                     m_propertyBlock,
		                                                     0LL);
		                                            m_FarCloudComposeDepths = this->fields.m_FarCloudTAADepths;
		                                            v224 = v223;
		                                            if ( !m_FarCloudComposeDepths )
		                                              goto LABEL_279;
		                                            if ( (unsigned int)v159 < m_FarCloudComposeDepths[6] )
		                                            {
		                                              m_propertyBlock = *(VolumetricPipelineRT **)&m_FarCloudComposeDepths[2 * (int)v159 + 8];
		                                              if ( !m_propertyBlock )
		                                                goto LABEL_279;
		                                              v225 = HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                       m_propertyBlock,
		                                                       0LL);
		                                              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		                                              HG::Rendering::Runtime::VolumetricSDFUtils::SetRenderTargets(
		                                                cmd,
		                                                v224,
		                                                v225,
		                                                RenderBufferLoadAction__Enum_DontCare,
		                                                RenderBufferStoreAction__Enum_Store,
		                                                0LL);
		                                              if ( force )
		                                              {
		                                                *(__m128i *)&v322.m_SpaceInfo.m_KeywordSpace = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		                                                UnityEngine::Rendering::CommandBuffer::ClearRenderTarget(
		                                                  cmd,
		                                                  0,
		                                                  1,
		                                                  (Color *)&v322,
		                                                  0LL);
		                                              }
		                                              v226 = this->fields.m_propertyBlock;
		                                              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		                                              HG::Rendering::Runtime::VolumetricSDFUtils::CustomBlit(
		                                                cmd,
		                                                cloudMat,
		                                                v226,
		                                                8,
		                                                0,
		                                                0LL);
		                                              goto LABEL_272;
		                                            }
		                                          }
		                                        }
		                                      }
		LABEL_291:
		                                      sub_1800D2AA0(m_propertyBlock, m_FarCloudComposeDepths, m_FarCloudComposeColors);
		                                    }
		LABEL_272:
		                                    v300 = v323;
		                                    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                                    FarCloudColor = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudColor;
		                                    if ( v300 <= 1 )
		                                    {
		                                      UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                                        propertyBlock,
		                                        FarCloudColor,
		                                        v334,
		                                        0LL);
		                                      UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                                        propertyBlock,
		                                        TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudDepth,
		                                        v331,
		                                        0LL);
		LABEL_276:
		                                      v307 = UnityEngine::Material::get_shader(cloudMat, 0LL);
		                                      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords);
		                                      v308 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderKeywords->static_fields->s_FarCloudSlicingReproject;
		                                      memset(&keyword, 0, 24);
		                                      UnityEngine::Rendering::LocalKeyword::LocalKeyword(
		                                        (LocalKeyword *)&keyword,
		                                        v307,
		                                        v308,
		                                        0LL);
		                                      *(_OWORD *)&v335.m00 = *(_OWORD *)&keyword.m00;
		                                      *(_QWORD *)&v335.m01 = *(_QWORD *)&keyword.m01;
		                                      UnityEngine::Rendering::CommandBuffer::SetMaterialKeyword_Injected(
		                                        cmd,
		                                        cloudMat,
		                                        (LocalKeyword *)&v335,
		                                        v319,
		                                        0LL);
		                                      this->fields.slicingIndex = (this->fields.slicingIndex + 1) % v300;
		                                      return;
		                                    }
		                                    UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                                      propertyBlock,
		                                      FarCloudColor,
		                                      v336,
		                                      0LL);
		                                    UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                                      propertyBlock,
		                                      TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudDepth,
		                                      (Texture *)v325.m_SpaceInfo.m_KeywordSpace,
		                                      0LL);
		                                    UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                                      propertyBlock,
		                                      TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudColor2,
		                                      v334,
		                                      0LL);
		                                    UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                                      propertyBlock,
		                                      TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudDepth2,
		                                      v331,
		                                      0LL);
		                                    FarCloudEmptySkipRT = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudEmptySkipRT;
		                                    m_propertyBlock = this->fields.m_FarCloudEmptySkipRT;
		                                    if ( m_propertyBlock )
		                                    {
		                                      v303 = (Texture *)HG::Rendering::Runtime::VolumetricPipelineRT::get_RT(
		                                                          m_propertyBlock,
		                                                          0LL);
		                                      UnityEngine::MaterialPropertyBlock::HGSetTextureImpl(
		                                        propertyBlock,
		                                        FarCloudEmptySkipRT,
		                                        v303,
		                                        0LL);
		                                      value.m_SpaceInfo.m_KeywordSpace = *(void **)&this->fields.m_BakedFarCloudLastCenter.x;
		                                      v325.m_SpaceInfo.m_KeywordSpace = value.m_SpaceInfo.m_KeywordSpace;
		                                      v304 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                      v325.m_Name = (String *)LODWORD(this->fields.m_BakedFarCloudLastCenter.z);
		                                      LODWORD(v304) = v304->_FarCloudSlicingPrevCenter;
		                                      *(_OWORD *)&v322.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v325.m_SpaceInfo.m_KeywordSpace;
		                                      UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		                                        propertyBlock,
		                                        (int32_t)v304,
		                                        (Vector4 *)&v322,
		                                        0LL);
		                                      value.m_SpaceInfo.m_KeywordSpace = *(void **)&this->fields.m_BakedFarCloudLastLastCenter.x;
		                                      v325.m_SpaceInfo.m_KeywordSpace = value.m_SpaceInfo.m_KeywordSpace;
		                                      v305 = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		                                      v325.m_Name = (String *)LODWORD(this->fields.m_BakedFarCloudLastLastCenter.z);
		                                      LODWORD(v305) = v305->_FarCloudSlicingPrev2Center;
		                                      *(_OWORD *)&v322.m_SpaceInfo.m_KeywordSpace = *(_OWORD *)&v325.m_SpaceInfo.m_KeywordSpace;
		                                      UnityEngine::MaterialPropertyBlock::SetVectorImpl_Injected(
		                                        propertyBlock,
		                                        (int32_t)v305,
		                                        (Vector4 *)&v322,
		                                        0LL);
		                                      UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                        propertyBlock,
		                                        TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudReprojectLerpRatio,
		                                        (float)(this->fields.slicingIndex + 1) / (float)v300,
		                                        0LL);
		                                      v306 = v333 - this->fields.m_BakedFarCloudLastLastTime;
		                                      UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                        propertyBlock,
		                                        TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudReprojectDeltaTimeScale,
		                                        (float)(v333 - this->fields.m_BakedFarCloudLastTime) / *(float *)&name,
		                                        0LL);
		                                      UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		                                        propertyBlock,
		                                        TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_FarCloudReprojectDeltaTimeScale2,
		                                        v306 / *(float *)&name,
		                                        0LL);
		                                      goto LABEL_276;
		                                    }
		LABEL_279:
		                                    sub_1800D8250(m_propertyBlock, m_FarCloudComposeDepths);
		                                  }
		                                }
		                              }
		LABEL_282:
		                              sub_1800D8250(v203, v202);
		                            }
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		LABEL_290:
		            sub_1800D8250(m_FarCloudEmptySkipRT, p_InvPartialVPMatrix);
		        }
		        v96 = v97 + 1;
		        goto LABEL_80;
		      }
		      v44 = (((_BYTE)v43 - 1) | 0xFFFFFFFE) + 1;
		    }
		    else
		    {
		      v44 = 0;
		    }
		    v321 = v44;
		    goto LABEL_35;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5098, 0LL);
		  if ( !Patch )
		    goto LABEL_279;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1486(
		    Patch,
		    (Object *)this,
		    (Object *)hgCamera,
		    (Object *)cmd,
		    (Object *)cloudMat,
		    (Object *)propertyBlock,
		    farCloudSize,
		    (Object *)volumetricParameters,
		    force,
		    axisChanged,
		    0LL);
		}
		
		public void UpdateOctahedronRT(HGCamera camera, CommandBuffer cmd, Material cloudMat, MaterialPropertyBlock propertyBlock, HGVolumetricCloudSettingParameters volumetricParameters, bool force = false /* Metadata: 0x023040C8 */) {} // 0x0000000189C4F574-0x0000000189C4F7F0
		// Void UpdateOctahedronRT(HGCamera, CommandBuffer, Material, MaterialPropertyBlock, HGVolumetricCloudSettingParameters, Boolean)
		void HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdateOctahedronRT(
		        VolumetricFarCloudRenderer *this,
		        HGCamera *camera,
		        CommandBuffer *cmd,
		        Material *cloudMat,
		        MaterialPropertyBlock *propertyBlock,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        bool force,
		        MethodInfo *method)
		{
		  __int64 v12; // rdx
		  ILFixDynamicMethodWrapper_2 *static_fields; // rcx
		  float v14; // xmm6_4
		  float v15; // xmm2_4
		  float FloatImpl; // xmm0_4
		  Int32Enum__Enum v17; // eax
		  float v18; // xmm6_4
		  Int32Enum__Enum farCloudSize; // eax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5097, 0LL) )
		  {
		    if ( volumetricParameters )
		    {
		      if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		             volumetricParameters->fields.octahedronEnableSlicing,
		             MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
		      {
		        v14 = (float)(int)HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                            (SettingParameter_1_System_Int32Enum_ *)volumetricParameters->fields.octahedronSlicingCountX,
		                            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		        v15 = (float)(int)HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                            (SettingParameter_1_System_Int32Enum_ *)volumetricParameters->fields.octahedronSlicingCountY,
		                            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		      }
		      else
		      {
		        v14 = 1.0;
		        v15 = 1.0;
		      }
		      if ( (float)((float)((float)(this->fields.slicingCount.y - v15) * (float)(this->fields.slicingCount.y - v15))
		                 + (float)((float)(this->fields.slicingCount.x - v14) * (float)(this->fields.slicingCount.x - v14))) >= 9.9999994e-11 )
		      {
		        this->fields.slicingIndex = 0;
		        this->fields.slicingCount.x = v14;
		        this->fields.slicingCount.y = v15;
		      }
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		      static_fields = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		      if ( cloudMat )
		      {
		        FloatImpl = UnityEngine::Material::GetFloatImpl(cloudMat, HIDWORD(static_fields[16].klass), 0LL);
		        v17 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                (SettingParameter_1_System_Int32Enum_ *)volumetricParameters->fields.octahedronSize,
		                MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		        static_fields = (ILFixDynamicMethodWrapper_2 *)TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		        v18 = 1.0 - (float)((float)(1.0 / (float)(int)v17) * (float)(FloatImpl + FloatImpl));
		        if ( propertyBlock )
		        {
		          UnityEngine::MaterialPropertyBlock::SetFloatImpl(propertyBlock, HIDWORD(static_fields[16].monitor), v18, 0LL);
		          UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		            propertyBlock,
		            TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields->_OctahedronUVInvRescale,
		            1.0 / v18,
		            0LL);
		          farCloudSize = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                           (SettingParameter_1_System_Int32Enum_ *)volumetricParameters->fields.octahedronSize,
		                           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		          HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdateDynamicFarCloudRT(
		            this,
		            camera,
		            cmd,
		            cloudMat,
		            propertyBlock,
		            farCloudSize,
		            volumetricParameters,
		            force,
		            0,
		            0LL);
		          return;
		        }
		      }
		    }
		LABEL_12:
		    sub_1800D8260(static_fields, v12);
		  }
		  static_fields = IFix::WrappersManagerImpl::GetPatch(5097, 0LL);
		  if ( !static_fields )
		    goto LABEL_12;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1485(
		    static_fields,
		    (Object *)this,
		    (Object *)camera,
		    (Object *)cmd,
		    (Object *)cloudMat,
		    (Object *)propertyBlock,
		    (Object *)volumetricParameters,
		    force,
		    0LL);
		}
		
		private bool IsDirectionOutside(Vector3 dir) => default; // 0x0000000189C4C008-0x0000000189C4C18C
		// Boolean IsDirectionOutside(Vector3)
		bool HG::Rendering::Runtime::VolumetricFarCloudRenderer::IsDirectionOutside(
		        VolumetricFarCloudRenderer *this,
		        Vector3 *dir,
		        MethodInfo *method)
		{
		  MethodInfo *v5; // r8
		  float v6; // eax
		  __int64 v7; // xmm0_8
		  float v8; // eax
		  __int64 v9; // xmm3_8
		  __int64 v10; // xmm1_8
		  __int64 v11; // xmm0_8
		  MethodInfo *v12; // r8
		  __int64 v13; // rcx
		  double v14; // xmm0_8
		  float v15; // xmm8_4
		  MethodInfo *v16; // r8
		  __int64 v17; // rcx
		  double v18; // xmm0_8
		  float v19; // xmm2_4
		  __int64 v21; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v24; // [rsp+20h] [rbp-60h] BYREF
		  Vector3 v25; // [rsp+30h] [rbp-50h] BYREF
		  Vector3 v26; // [rsp+40h] [rbp-40h] BYREF
		  Vector3 v27[2]; // [rsp+50h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5127, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5127, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v21);
		    z = dir->z;
		    *(_QWORD *)&v27[0].x = *(_QWORD *)&dir->x;
		    v27[0].z = z;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_255(Patch, (Object *)this, v27, 0LL);
		  }
		  else
		  {
		    v6 = dir->z;
		    *(_QWORD *)&v24.x = *(_QWORD *)&dir->x;
		    v7 = *(_QWORD *)&this->fields.semicircularForward.x;
		    v24.z = v6;
		    v8 = this->fields.semicircularForward.z;
		    *(_QWORD *)&v25.x = v7;
		    v25.z = v8;
		    UnityEngine::Vector3::Dot(&v25, &v24, v5);
		    v9 = *(_QWORD *)&dir->x;
		    v10 = *(_QWORD *)&this->fields.semicircularRight.x;
		    v11 = *(_QWORD *)&this->fields.semicircularUp.x;
		    v25.z = dir->z;
		    v24.z = this->fields.semicircularRight.z;
		    v26.z = dir->z;
		    v27[0].z = this->fields.semicircularUp.z;
		    *(_QWORD *)&v25.x = v9;
		    *(_QWORD *)&v24.x = v10;
		    *(_QWORD *)&v26.x = v9;
		    *(_QWORD *)&v27[0].x = v11;
		    UnityEngine::Vector3::Dot(&v24, &v25, v12);
		    v14 = sub_1803345E0(v13);
		    v15 = *(float *)&v14 * 57.29578;
		    UnityEngine::Vector3::Dot(v27, &v26, v16);
		    v18 = sub_1803345E0(v17);
		    v19 = *(float *)&v18 * 57.29578;
		    return v15 > 80.0 || v15 < -80.0 || v19 > 40.0 || v19 < -40.0;
		  }
		}
		
		public void UpdateSemicircularRT(HGCamera hgCamera, CommandBuffer cmd, Material cloudMat, MaterialPropertyBlock propertyBlock, HGVolumetricCloudSettingParameters volumetricParameters, bool force) {} // 0x0000000189C50038-0x0000000189C50558
		// Void UpdateSemicircularRT(HGCamera, CommandBuffer, Material, MaterialPropertyBlock, HGVolumetricCloudSettingParameters, Boolean)
		void HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdateSemicircularRT(
		        VolumetricFarCloudRenderer *this,
		        HGCamera *hgCamera,
		        CommandBuffer *cmd,
		        Material *cloudMat,
		        MaterialPropertyBlock *propertyBlock,
		        HGVolumetricCloudSettingParameters *volumetricParameters,
		        bool force,
		        MethodInfo *method)
		{
		  __int64 v12; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  Component *camera; // rdi
		  Transform *transform; // rax
		  Vector3 *forward; // rax
		  __int64 v17; // xmm7_8
		  float z; // r15d
		  Transform *v19; // rax
		  Vector3 *right; // rax
		  __int64 v21; // xmm8_8
		  float v22; // r12d
		  Transform *v23; // rax
		  Vector3 *up; // rax
		  __int64 v25; // xmm9_8
		  int32_t v26; // r8d
		  MethodInfo *v27; // r9
		  Vector3 *Vector; // rax
		  float v29; // edx
		  MethodInfo *v30; // r8
		  Vector4 *v31; // rax
		  int32_t v32; // r10d
		  MethodInfo *v33; // r8
		  int32_t v34; // r10d
		  MethodInfo *v35; // r8
		  int32_t v36; // r10d
		  float fieldOfView; // xmm6_4
		  float aspect; // xmm0_4
		  float v39; // xmm6_4
		  double v40; // xmm0_8
		  bool axisChanged; // di
		  MethodInfo *v42; // r8
		  int32_t v43; // r10d
		  MethodInfo *v44; // r8
		  int32_t v45; // r10d
		  MethodInfo *v46; // r8
		  int32_t v47; // r10d
		  Int32Enum__Enum farCloudSize; // eax
		  float v49; // [rsp+58h] [rbp-69h]
		  __int64 v50; // [rsp+68h] [rbp-59h] BYREF
		  float v51; // [rsp+70h] [rbp-51h]
		  Vector3 semicircularForward; // [rsp+78h] [rbp-49h] BYREF
		  Vector4 v53[5]; // [rsp+88h] [rbp-39h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5101, 0LL) )
		  {
		    this->fields.slicingIndex = 0;
		    this->fields.slicingCount.x = 1.0;
		    this->fields.slicingCount.y = 1.0;
		    if ( hgCamera )
		    {
		      camera = (Component *)hgCamera->fields.camera;
		      if ( camera )
		      {
		        transform = UnityEngine::Component::get_transform((Component *)hgCamera->fields.camera, 0LL);
		        if ( transform )
		        {
		          forward = UnityEngine::Transform::get_forward(&semicircularForward, transform, 0LL);
		          v17 = *(_QWORD *)&forward->x;
		          z = forward->z;
		          v19 = UnityEngine::Component::get_transform(camera, 0LL);
		          if ( v19 )
		          {
		            right = UnityEngine::Transform::get_right(&semicircularForward, v19, 0LL);
		            v21 = *(_QWORD *)&right->x;
		            v22 = right->z;
		            v23 = UnityEngine::Component::get_transform(camera, 0LL);
		            if ( v23 )
		            {
		              up = UnityEngine::Transform::get_up(&semicircularForward, v23, 0LL);
		              v25 = *(_QWORD *)&up->x;
		              v49 = up->z;
		              Vector = UnityEngine::Animator::GetVector((Vector3 *)v53, (Animator *)LODWORD(v49), v26, v27);
		              v50 = *(_QWORD *)&this->fields.semicircularForward.x;
		              *(_QWORD *)&semicircularForward.x = *(_QWORD *)&Vector->x;
		              if ( (float)((float)((float)((float)(*((float *)&v50 + 1) - semicircularForward.y)
		                                         * (float)(*((float *)&v50 + 1) - semicircularForward.y))
		                                 + (float)((float)(*(float *)&v50 - semicircularForward.x)
		                                         * (float)(*(float *)&v50 - semicircularForward.x)))
		                         + (float)((float)(this->fields.semicircularForward.z - Vector->z)
		                                 * (float)(this->fields.semicircularForward.z - Vector->z))) < 9.9999994e-11 )
		              {
		                *(_QWORD *)&this->fields.semicircularForward.x = v17;
		                *(_QWORD *)&this->fields.semicircularRight.x = v21;
		                *(_QWORD *)&this->fields.semicircularUp.x = v25;
		                this->fields.semicircularForward.z = z;
		                this->fields.semicircularRight.z = v22;
		                this->fields.semicircularUp.z = v29;
		              }
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		              semicircularForward = this->fields.semicircularForward;
		              v31 = UnityEngine::Vector4::op_Implicit(v53, &semicircularForward, v30);
		              if ( propertyBlock )
		              {
		                v53[0] = *v31;
		                UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v32, v53, 0LL);
		                semicircularForward = this->fields.semicircularRight;
		                v53[0] = *UnityEngine::Vector4::op_Implicit(v53, &semicircularForward, v33);
		                UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v34, v53, 0LL);
		                semicircularForward = this->fields.semicircularUp;
		                v53[0] = *UnityEngine::Vector4::op_Implicit(v53, &semicircularForward, v35);
		                UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v36, v53, 0LL);
		                fieldOfView = UnityEngine::Camera::get_fieldOfView((Camera *)camera, 0LL);
		                aspect = UnityEngine::Camera::get_aspect((Camera *)camera, 0LL);
		                semicircularForward.z = this->fields.semicircularForward.z;
		                v50 = v17;
		                v51 = z;
		                v39 = 90.0 - (float)((float)(aspect * fieldOfView) * 0.5);
		                *(_QWORD *)&semicircularForward.x = *(_QWORD *)&this->fields.semicircularForward.x;
		                v40 = sub_182F3EB50(&v50, &semicircularForward);
		                if ( *(float *)&v40 <= (float)(v39 * 0.94999999) )
		                {
		                  axisChanged = 0;
		                }
		                else
		                {
		                  axisChanged = 1;
		                  *(_QWORD *)&this->fields.semicircularForward.x = v17;
		                  *(_QWORD *)&this->fields.semicircularRight.x = v21;
		                  *(_QWORD *)&this->fields.semicircularUp.x = v25;
		                  this->fields.semicircularForward.z = z;
		                  this->fields.semicircularRight.z = v22;
		                  this->fields.semicircularUp.z = v49;
		                }
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		                semicircularForward = this->fields.semicircularForward;
		                v53[0] = *UnityEngine::Vector4::op_Implicit(v53, &semicircularForward, v42);
		                UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v43, v53, 0LL);
		                semicircularForward = this->fields.semicircularRight;
		                v53[0] = *UnityEngine::Vector4::op_Implicit(v53, &semicircularForward, v44);
		                UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v45, v53, 0LL);
		                semicircularForward = this->fields.semicircularUp;
		                v53[0] = *UnityEngine::Vector4::op_Implicit(v53, &semicircularForward, v46);
		                UnityEngine::MaterialPropertyBlock::SetVector(propertyBlock, v47, v53, 0LL);
		                if ( volumetricParameters )
		                {
		                  farCloudSize = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                                   (SettingParameter_1_System_Int32Enum_ *)volumetricParameters->fields.semicircularSize,
		                                   MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		                  HG::Rendering::Runtime::VolumetricFarCloudRenderer::UpdateDynamicFarCloudRT(
		                    this,
		                    hgCamera,
		                    cmd,
		                    cloudMat,
		                    propertyBlock,
		                    farCloudSize,
		                    volumetricParameters,
		                    force,
		                    axisChanged,
		                    0LL);
		                  return;
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_16:
		    sub_1800D8260(Patch, v12);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5101, 0LL);
		  if ( !Patch )
		    goto LABEL_16;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1485(
		    Patch,
		    (Object *)this,
		    (Object *)hgCamera,
		    (Object *)cmd,
		    (Object *)cloudMat,
		    (Object *)propertyBlock,
		    (Object *)volumetricParameters,
		    force,
		    0LL);
		}
		
	}
}
