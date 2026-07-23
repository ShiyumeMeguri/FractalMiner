using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.TerrainV2
{
	[Serializable]
	public struct TerrainFakeVolumeData // TypeDefIndex: 38831
	{
		// Fields
		public TerrainFakeVolumeParams _Params; // 0x00
		public Texture2D _FakeVolumeOpacityMask; // 0xA0
		public Texture2D _FakeVolumeMask; // 0xA8
	
		// Methods
		public void SetupTerrainParams(HGRenderGraphContext context) {} // 0x0000000189C7DC20-0x0000000189C7E0AC
		// Void SetupTerrainParams(HGRenderGraphContext)
		void HG::Rendering::Runtime::TerrainV2::TerrainFakeVolumeData::SetupTerrainParams(
		        TerrainFakeVolumeData *this,
		        HGRenderGraphContext *context,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGShaderIDs__StaticFields *static_fields; // rcx
		  CommandBuffer *cmd; // r14
		  bool EnableFakeVolume; // bl
		  String *s_FakeVolume; // rdi
		  int32_t FakeVolumeOpacityMask; // ebx
		  RenderTargetIdentifier *v11; // rax
		  __int128 v12; // xmm1
		  int32_t FakeVolumeMask; // ebx
		  RenderTargetIdentifier *v14; // rax
		  __int128 v15; // xmm1
		  int32_t FakeCrackTint; // edx
		  int32_t FakeRefractionTint; // edx
		  int32_t FakeVolumeScatterExtinction; // edx
		  int32_t FakeVolumeScatterAlbedo; // edx
		  int32_t FakeDustFlowSpeed; // edx
		  int32_t FakeDustTint; // edx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  RenderTargetIdentifier v23; // [rsp+28h] [rbp-69h] BYREF
		  Color value; // [rsp+58h] [rbp-39h] BYREF
		  Color v25; // [rsp+68h] [rbp-29h] BYREF
		  Color v26; // [rsp+78h] [rbp-19h] BYREF
		  Color v27; // [rsp+88h] [rbp-9h] BYREF
		  Vector4 v28; // [rsp+98h] [rbp+7h] BYREF
		  Color v29; // [rsp+A8h] [rbp+17h] BYREF
		  RenderTargetIdentifier v30; // [rsp+B8h] [rbp+27h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5464, 0LL) )
		  {
		    if ( context )
		    {
		      cmd = context->fields.cmd;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      EnableFakeVolume = this->_Params._EnableFakeVolume;
		      s_FakeVolume = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FakeVolume;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::SetKeyword(cmd, s_FakeVolume, EnableFakeVolume, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields;
		      if ( cmd )
		      {
		        UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		          cmd,
		          static_fields->_FakeVolumeIoR,
		          this->_Params._FakeVolumeIoR,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		          cmd,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeVolumeFresnelStrength,
		          this->_Params._FakeVolumeFresnelStrength,
		          0LL);
		        UnityEngine::Rendering::CoreUtils::SetKeyword(
		          cmd,
		          TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FakeCrackCSM,
		          this->_Params._FakeVolumeMode == 1,
		          0LL);
		        FakeVolumeOpacityMask = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeVolumeOpacityMask;
		        v11 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                &v30,
		                (Texture *)this->_FakeVolumeOpacityMask,
		                0LL);
		        v12 = *(_OWORD *)&v11->m_BufferPointer;
		        *(_OWORD *)&v23.m_Type = *(_OWORD *)&v11->m_Type;
		        *(_QWORD *)&v23.m_DepthSlice = *(_QWORD *)&v11->m_DepthSlice;
		        *(_OWORD *)&v23.m_BufferPointer = v12;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, FakeVolumeOpacityMask, &v23, 0LL);
		        UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		          cmd,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeVolumeOpacityTiling,
		          this->_Params._FakeVolumeOpacityTiling,
		          0LL);
		        FakeVolumeMask = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeVolumeMask;
		        v14 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v30, (Texture *)this->_FakeVolumeMask, 0LL);
		        v15 = *(_OWORD *)&v14->m_BufferPointer;
		        *(_OWORD *)&v23.m_Type = *(_OWORD *)&v14->m_Type;
		        *(_QWORD *)&v23.m_DepthSlice = *(_QWORD *)&v14->m_DepthSlice;
		        *(_OWORD *)&v23.m_BufferPointer = v15;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, FakeVolumeMask, &v23, 0LL);
		        UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		          cmd,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeCrackLayerTiling,
		          this->_Params._FakeCrackLayerTiling,
		          0LL);
		        FakeCrackTint = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeCrackTint;
		        value = this->_Params._FakeCrackTint;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalColor_Injected(cmd, FakeCrackTint, &value, 0LL);
		        UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		          cmd,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeCrackHeightScale,
		          this->_Params._FakeCrackHeightScale,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		          cmd,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeCrackDepth,
		          this->_Params._FakeCrackDepth,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::SetGlobalInt(
		          cmd,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeCrackMarchSteps,
		          (int)this->_Params._FakeCrackMarchSteps,
		          0LL);
		        FakeRefractionTint = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeRefractionTint;
		        v25 = this->_Params._FakeRefractionTint;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalColor_Injected(cmd, FakeRefractionTint, &v25, 0LL);
		        UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		          cmd,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeRefractionLayerTiling,
		          this->_Params._FakeRefractionLayerTiling,
		          0LL);
		        FakeVolumeScatterExtinction = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeVolumeScatterExtinction;
		        v26 = this->_Params._FakeVolumeScatterExtinction;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalColor_Injected(cmd, FakeVolumeScatterExtinction, &v26, 0LL);
		        FakeVolumeScatterAlbedo = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeVolumeScatterAlbedo;
		        v27 = this->_Params._FakeVolumeScatterAlbedo;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalColor_Injected(cmd, FakeVolumeScatterAlbedo, &v27, 0LL);
		        UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		          cmd,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeRefractionHeightScale,
		          this->_Params._FakeRefractionHeightScale,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		          cmd,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeRefractionDepth,
		          this->_Params._FakeRefractionDepth,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::SetGlobalInt(
		          cmd,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeRefractionMarchSteps,
		          (int)this->_Params._FakeRefractionMarchSteps,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		          cmd,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeDustLayerTiling,
		          this->_Params._FakeDustLayerTiling,
		          0LL);
		        UnityEngine::Rendering::CommandBuffer::SetGlobalFloat(
		          cmd,
		          TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeDustDepth,
		          this->_Params._FakeDustDepth,
		          0LL);
		        FakeDustFlowSpeed = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeDustFlowSpeed;
		        v28 = this->_Params._FakeDustFlowSpeed;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalVector_Injected(cmd, FakeDustFlowSpeed, &v28, 0LL);
		        FakeDustTint = TypeInfo::HG::Rendering::Runtime::HGShaderIDs->static_fields->_FakeDustTint;
		        v29 = this->_Params._FakeDustTint;
		        UnityEngine::Rendering::CommandBuffer::SetGlobalColor_Injected(cmd, FakeDustTint, &v29, 0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(static_fields, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5464, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1584(Patch, this, (Object *)context, 0LL);
		}
		
		public static void ResetTerrainParams(HGRenderGraphContext context) {} // 0x0000000189C7DB68-0x0000000189C7DC20
		// Void ResetTerrainParams(HGRenderGraphContext)
		void HG::Rendering::Runtime::TerrainV2::TerrainFakeVolumeData::ResetTerrainParams(
		        HGRenderGraphContext *context,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  CommandBuffer *cmd; // rdi
		  String *s_FakeVolume; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5465, 0LL) )
		  {
		    if ( context )
		    {
		      cmd = context->fields.cmd;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      s_FakeVolume = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FakeVolume;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::SetKeyword(cmd, s_FakeVolume, 0, 0LL);
		      UnityEngine::Rendering::CoreUtils::SetKeyword(
		        cmd,
		        TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_FakeCrackCSM,
		        0,
		        0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5465, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)context, 0LL);
		}
		
		public HGTerrainFakeVolumeData ToDataCPP() => default; // 0x0000000183335890-0x0000000183335B80
		// HGTerrainFakeVolumeData ToDataCPP()
		HGTerrainFakeVolumeData *HG::Rendering::Runtime::TerrainV2::TerrainFakeVolumeData::ToDataCPP(
		        HGTerrainFakeVolumeData *__return_ptr retstr,
		        TerrainFakeVolumeData *this,
		        MethodInfo *method)
		{
		  Object_1 *v5; // rcx
		  __int64 v6; // rdx
		  float FakeVolumeFresnelStrength; // xmm1_4
		  bool EnableFakeVolume; // al
		  Texture2D *FakeVolumeOpacityMask; // rdi
		  bool v10; // zf
		  Color FakeCrackTint; // xmm0
		  int32_t FakeVolumeMode; // eax
		  float FakeCrackLayerTiling; // xmm1_4
		  Color FakeRefractionTint; // xmm0
		  float FakeCrackHeightScale; // xmm1_4
		  Color FakeVolumeScatterExtinction; // xmm0
		  float FakeCrackMarchSteps; // xmm1_4
		  __int128 v18; // xmm0
		  Color FakeVolumeScatterAlbedo; // xmm1
		  Color FakeDustTint; // xmm0
		  Vector4 FakeDustFlowSpeed; // xmm1
		  int32_t v22; // esi
		  int32_t InstanceID; // eax
		  Texture2D *FakeVolumeMask; // rdi
		  HGTerrainFakeVolumeData *v25; // rax
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  __int128 v29; // xmm0
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  __int128 v32; // xmm1
		  __int128 v33; // xmm0
		  int32_t m_fakeVolumeMask; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGTerrainFakeVolumeData v37; // [rsp+20h] [rbp-59h] BYREF
		
		  v5 = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = *(_QWORD *)v5[7].fields.m_CachedPtr;
		  if ( !v6 )
		    goto LABEL_28;
		  if ( *(int *)(v6 + 24) > 5466 )
		  {
		    if ( !LODWORD(v5[9].monitor) )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = (Object_1 *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = *(Object_1 **)v5[7].fields.m_CachedPtr;
		    if ( !v5 )
		      goto LABEL_28;
		    if ( LODWORD(v5[1].klass) <= 0x155A )
		      sub_1800D2AB0(v5, v6);
		    if ( v5[1823].monitor )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(5466, 0LL);
		      if ( Patch )
		      {
		        v25 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1585(&v37, Patch, this, 0LL);
		        goto LABEL_23;
		      }
		      goto LABEL_28;
		    }
		  }
		  sub_18033B9D0(&v37, 0LL, 164LL);
		  FakeVolumeFresnelStrength = this->_Params._FakeVolumeFresnelStrength;
		  EnableFakeVolume = this->_Params._EnableFakeVolume;
		  FakeVolumeOpacityMask = this->_FakeVolumeOpacityMask;
		  v37.m_fakeVolumeIoR = this->_Params._FakeVolumeIoR;
		  v10 = TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor == 0;
		  v37.m_fakeVolumeOpacityTiling = this->_Params._FakeVolumeOpacityTiling;
		  FakeCrackTint = this->_Params._FakeCrackTint;
		  v37.m_enableFakeVolume = EnableFakeVolume;
		  FakeVolumeMode = this->_Params._FakeVolumeMode;
		  v37.m_fakeCrackTint = FakeCrackTint;
		  v37.m_fakeVolumeMode = FakeVolumeMode;
		  FakeCrackTint.r = this->_Params._FakeCrackDepth;
		  v37.m_fakeVolumeFresnelStrength = FakeVolumeFresnelStrength;
		  FakeCrackLayerTiling = this->_Params._FakeCrackLayerTiling;
		  v37.m_fakeCrackDepth = FakeCrackTint.r;
		  FakeRefractionTint = this->_Params._FakeRefractionTint;
		  v37.m_fakeCrackLayerTiling = FakeCrackLayerTiling;
		  FakeCrackHeightScale = this->_Params._FakeCrackHeightScale;
		  v37.m_fakeRefractionTint = FakeRefractionTint;
		  FakeVolumeScatterExtinction = this->_Params._FakeVolumeScatterExtinction;
		  v37.m_fakeCrackHeightScale = FakeCrackHeightScale;
		  FakeCrackMarchSteps = this->_Params._FakeCrackMarchSteps;
		  v37.m_fakeVolumeScatterExtinction = FakeVolumeScatterExtinction;
		  v18 = *(_OWORD *)&this->_Params._FakeRefractionHeightScale;
		  v37.m_fakeCrackMarchSteps = FakeCrackMarchSteps;
		  v37.m_fakeRefractionLayerTiling = this->_Params._FakeRefractionLayerTiling;
		  FakeVolumeScatterAlbedo = this->_Params._FakeVolumeScatterAlbedo;
		  *(_OWORD *)&v37.m_fakeRefractionHeightScale = v18;
		  v37.m_fakeDustDepth = this->_Params._FakeDustDepth;
		  FakeDustTint = this->_Params._FakeDustTint;
		  v37.m_fakeVolumeScatterAlbedo = FakeVolumeScatterAlbedo;
		  FakeDustFlowSpeed = this->_Params._FakeDustFlowSpeed;
		  v37.m_fakeDustTint = FakeDustTint;
		  v37.m_fakeDustFlowSpeed = FakeDustFlowSpeed;
		  if ( v10 )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  v22 = 0;
		  if ( !FakeVolumeOpacityMask )
		    goto LABEL_13;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( FakeVolumeOpacityMask->fields._._.m_CachedPtr )
		  {
		    v5 = (Object_1 *)this->_FakeVolumeOpacityMask;
		    if ( !v5 )
		      goto LABEL_28;
		    InstanceID = UnityEngine::Object::GetInstanceID(v5, 0LL);
		  }
		  else
		  {
		LABEL_13:
		    InstanceID = 0;
		  }
		  FakeVolumeMask = this->_FakeVolumeMask;
		  v37.m_fakeVolumeOpacityMask = InstanceID;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !FakeVolumeMask )
		    goto LABEL_22;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !FakeVolumeMask->fields._._.m_CachedPtr )
		    goto LABEL_22;
		  v5 = (Object_1 *)this->_FakeVolumeMask;
		  if ( !v5 )
		LABEL_28:
		    sub_1800D8260(v5, v6);
		  v22 = UnityEngine::Object::GetInstanceID(v5, 0LL);
		LABEL_22:
		  v37.m_fakeVolumeMask = v22;
		  v25 = &v37;
		LABEL_23:
		  v26 = *(_OWORD *)&v25->m_fakeVolumeOpacityTiling;
		  *(_OWORD *)&retstr->m_enableFakeVolume = *(_OWORD *)&v25->m_enableFakeVolume;
		  v27 = *(_OWORD *)&v25->m_fakeCrackTint.b;
		  *(_OWORD *)&retstr->m_fakeVolumeOpacityTiling = v26;
		  v28 = *(_OWORD *)&v25->m_fakeCrackMarchSteps;
		  *(_OWORD *)&retstr->m_fakeCrackTint.b = v27;
		  v29 = *(_OWORD *)&v25->m_fakeRefractionTint.a;
		  *(_OWORD *)&retstr->m_fakeCrackMarchSteps = v28;
		  v30 = *(_OWORD *)&v25->m_fakeVolumeScatterExtinction.b;
		  *(_OWORD *)&retstr->m_fakeRefractionTint.a = v29;
		  v31 = *(_OWORD *)&v25->m_fakeVolumeScatterAlbedo.b;
		  *(_OWORD *)&retstr->m_fakeVolumeScatterExtinction.b = v30;
		  v32 = *(_OWORD *)&v25->m_fakeDustFlowSpeed.y;
		  *(_OWORD *)&retstr->m_fakeVolumeScatterAlbedo.b = v31;
		  *(_OWORD *)&retstr->m_fakeRefractionMarchSteps = *(_OWORD *)&v25->m_fakeRefractionMarchSteps;
		  v33 = *(_OWORD *)&v25->m_fakeDustTint.g;
		  m_fakeVolumeMask = v25->m_fakeVolumeMask;
		  *(_OWORD *)&retstr->m_fakeDustFlowSpeed.y = v32;
		  *(_OWORD *)&retstr->m_fakeDustTint.g = v33;
		  retstr->m_fakeVolumeMask = m_fakeVolumeMask;
		  return retstr;
		}
		
	}
}
