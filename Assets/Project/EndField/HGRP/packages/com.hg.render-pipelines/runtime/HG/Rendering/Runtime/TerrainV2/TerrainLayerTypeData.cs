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
	public struct TerrainLayerTypeData // TypeDefIndex: 38833
	{
		// Fields
		[SerializeField]
		public TerrainGlintData _glintData; // 0x00
		[SerializeField]
		public TerrainSubsurfaceData _subsurfaceData; // 0x30
		[SerializeField]
		public TerrainFakeVolumeData _fakeVolumeData; // 0x48
		[SerializeField]
		public TerrainFakeShadowData _fakeShadowData; // 0xF8
	
		// Methods
		public void SetupTerrainParams(HGRenderGraphContext context) {} // 0x0000000189C7E3DC-0x0000000189C7E4DC
		// Void SetupTerrainParams(HGRenderGraphContext)
		void HG::Rendering::Runtime::TerrainV2::TerrainLayerTypeData::SetupTerrainParams(
		        TerrainLayerTypeData *this,
		        HGRenderGraphContext *context,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  CommandBuffer *cmd; // rdi
		  String *s_HasTerrainLayerTypeData; // rsi
		  BOOL v9; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5470, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5470, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1588(Patch, this, (Object *)context, 0LL);
		      return;
		    }
		LABEL_9:
		    sub_1800D8260(v6, v5);
		  }
		  HG::Rendering::Runtime::TerrainV2::TerrainGlintData::SetupTerrainParams(&this->_glintData, context, 0LL);
		  HG::Rendering::Runtime::TerrainV2::TerrainSubsurfaceData::SetupTerrainParams(&this->_subsurfaceData, context, 0LL);
		  HG::Rendering::Runtime::TerrainV2::TerrainFakeVolumeData::SetupTerrainParams(&this->_fakeVolumeData, context, 0LL);
		  HG::Rendering::Runtime::TerrainV2::TerrainFakeShadowData::SetupTerrainParams(&this->_fakeShadowData, context, 0LL);
		  if ( !context )
		    goto LABEL_9;
		  cmd = context->fields.cmd;
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		  s_HasTerrainLayerTypeData = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_HasTerrainLayerTypeData;
		  v9 = this->_glintData._EnableFakeGlint
		    || this->_subsurfaceData._Params._UseSubsurfaceProfile
		    || this->_fakeVolumeData._Params._EnableFakeVolume;
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		  UnityEngine::Rendering::CoreUtils::SetKeyword(cmd, s_HasTerrainLayerTypeData, v9, 0LL);
		}
		
		public static void ResetTerrainParams(HGRenderGraphContext context) {} // 0x0000000189C7E320-0x0000000189C7E3DC
		// Void ResetTerrainParams(HGRenderGraphContext)
		void HG::Rendering::Runtime::TerrainV2::TerrainLayerTypeData::ResetTerrainParams(
		        HGRenderGraphContext *context,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  CommandBuffer *cmd; // rdi
		  String *s_HasTerrainLayerTypeData; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5471, 0LL) )
		  {
		    HG::Rendering::Runtime::TerrainV2::TerrainGlintData::ResetTerrainParams(context, 0LL);
		    HG::Rendering::Runtime::TerrainV2::TerrainFakeVolumeData::ResetTerrainParams(context, 0LL);
		    HG::Rendering::Runtime::TerrainV2::TerrainSubsurfaceData::ResetTerrainParams(context, 0LL);
		    HG::Rendering::Runtime::TerrainV2::TerrainFakeShadowData::ResetTerrainParams(context, 0LL);
		    if ( context )
		    {
		      cmd = context->fields.cmd;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
		      s_HasTerrainLayerTypeData = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords->static_fields->s_HasTerrainLayerTypeData;
		      sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		      UnityEngine::Rendering::CoreUtils::SetKeyword(cmd, s_HasTerrainLayerTypeData, 0, 0LL);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5471, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)context, 0LL);
		}
		
		public void PrepareTerrainDataCPP(ref HGTerrainLayerTypeData layerTypeData) {} // 0x0000000183335220-0x0000000183335510
		// Void PrepareTerrainDataCPP(HGTerrainLayerTypeData ByRef)
		void HG::Rendering::Runtime::TerrainV2::TerrainLayerTypeData::PrepareTerrainDataCPP(
		        TerrainLayerTypeData *this,
		        HGTerrainLayerTypeData *layerTypeData,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  bool EnableFakeGlint; // al
		  float GlintTopBlendSmoothness; // xmm2_4
		  float GlintTopBlendThreshold; // xmm3_4
		  __m128i GlintColor; // xmm0
		  __m128 v11; // xmm1
		  __int128 v12; // xmm2
		  __m128 v13; // xmm1
		  float a; // ecx
		  __int64 v15; // xmm3_8
		  __m128 v16; // xmm1
		  HGTerrainSubsurfaceData *v17; // rax
		  int32_t m_terrainStencil; // ecx
		  HGTerrainFakeVolumeData *v19; // rax
		  TerrainFakeShadowData *p_fakeShadowData; // rbx
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  __int128 v33; // xmm1
		  __int128 v34; // xmm0
		  __int128 v35; // xmm1
		  __int128 v36; // xmm0
		  __int128 v37; // xmm1
		  float FakeShadowPenumbra; // xmm0_4
		  float FakeShadowStrength; // xmm1_4
		  float FakeShadowMarchSteps; // xmm2_4
		  float FakeShadowDistanceLerp; // ecx
		  __m128 v42; // xmm4
		  __m128 v43; // xmm4
		  __m128 v44; // xmm4
		  __m128 v45; // xmm4
		  ILFixDynamicMethodWrapper_2 *v46; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGTerrainGlintData *v48; // rax
		  ILFixDynamicMethodWrapper_2 *v49; // rax
		  HGTerrainFakeShadowData *v50; // rax
		  HGTerrainFakeShadowData v51; // [rsp+20h] [rbp-E0h] BYREF
		  HGTerrainGlintData v52; // [rsp+38h] [rbp-C8h] BYREF
		  __int128 v53; // [rsp+70h] [rbp-90h]
		  __int128 v54; // [rsp+80h] [rbp-80h]
		  __int128 v55; // [rsp+90h] [rbp-70h]
		  __int128 v56; // [rsp+A0h] [rbp-60h]
		  __int128 v57; // [rsp+B0h] [rbp-50h]
		  __int128 v58; // [rsp+C0h] [rbp-40h]
		  __int128 v59; // [rsp+D0h] [rbp-30h]
		  __int128 v60; // [rsp+E0h] [rbp-20h]
		  __int128 v61; // [rsp+F0h] [rbp-10h]
		  __int128 v62; // [rsp+100h] [rbp+0h]
		  int v63; // [rsp+110h] [rbp+10h]
		  HGTerrainFakeVolumeData v64; // [rsp+120h] [rbp+20h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_16;
		  if ( wrapperArray->max_length.size <= 5472 )
		    goto LABEL_41;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_16;
		  if ( wrapperArray->max_length.size <= 0x1560u )
		    goto LABEL_38;
		  if ( !wrapperArray[152].vector[0] )
		  {
		LABEL_41:
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v5->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_16;
		    if ( wrapperArray->max_length.size <= 5460 )
		      goto LABEL_9;
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v5->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_16;
		    if ( wrapperArray->max_length.size <= 0x1554u )
		      goto LABEL_38;
		    if ( wrapperArray[151].vector[24] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(5460, 0LL);
		      if ( !Patch )
		        goto LABEL_16;
		      v48 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1581(&v52, Patch, &this->_glintData, 0LL);
		      v16 = *(__m128 *)&v48->m_enableFakeGlint;
		      a = v48->m_glintColor.a;
		      v12 = *(_OWORD *)&v48->m_glintScale;
		      v15 = *(_QWORD *)&v48->m_glintColor.g;
		    }
		    else
		    {
		LABEL_9:
		      EnableFakeGlint = this->_glintData._EnableFakeGlint;
		      GlintTopBlendSmoothness = this->_glintData._GlintTopBlendSmoothness;
		      GlintTopBlendThreshold = this->_glintData._GlintTopBlendThreshold;
		      *(_OWORD *)&v52.m_glintStrength = *(_OWORD *)&this->_glintData._GlintStrength;
		      *(_WORD *)(&v52.m_enableFakeGlint + 1) = 0;
		      GlintColor = (__m128i)this->_glintData._GlintColor;
		      *(&v52.m_enableFakeGlint + 3) = 0;
		      v52.m_enableFakeGlint = EnableFakeGlint;
		      v52.m_glintColor = (Color)GlintColor;
		      v11 = _mm_shuffle_ps(*(__m128 *)&v52.m_enableFakeGlint, *(__m128 *)&v52.m_enableFakeGlint, 225);
		      v11.m128_f32[0] = GlintTopBlendSmoothness;
		      v12 = *(_OWORD *)&v52.m_glintScale;
		      v13 = _mm_shuffle_ps(v11, v11, 198);
		      v13.m128_f32[0] = GlintTopBlendThreshold;
		      a = COERCE_FLOAT(_mm_cvtsi128_si32(_mm_srli_si128(GlintColor, 12)));
		      v15 = *(_OWORD *)&GlintColor >> 32;
		      v16 = _mm_shuffle_ps(v13, v13, 201);
		    }
		    *(__m128 *)&layerTypeData->m_glintData.m_enableFakeGlint = v16;
		    *(_OWORD *)&layerTypeData->m_glintData.m_glintScale = v12;
		    *(_QWORD *)&layerTypeData->m_glintData.m_glintColor.g = v15;
		    layerTypeData->m_glintData.m_glintColor.a = a;
		    v17 = HG::Rendering::Runtime::TerrainV2::TerrainSubsurfaceData::ToDataCPP(
		            (HGTerrainSubsurfaceData *)&v51,
		            &this->_subsurfaceData,
		            0LL);
		    m_terrainStencil = v17->m_terrainStencil;
		    *(_OWORD *)&layerTypeData->m_subsurfaceData.m_useSubsurfaceProfile = *(_OWORD *)&v17->m_useSubsurfaceProfile;
		    layerTypeData->m_subsurfaceData.m_terrainStencil = m_terrainStencil;
		    v19 = HG::Rendering::Runtime::TerrainV2::TerrainFakeVolumeData::ToDataCPP(&v64, &this->_fakeVolumeData, 0LL);
		    p_fakeShadowData = &this->_fakeShadowData;
		    v21 = *(_OWORD *)&v19->m_fakeVolumeOpacityTiling;
		    v53 = *(_OWORD *)&v19->m_enableFakeVolume;
		    v22 = *(_OWORD *)&v19->m_fakeCrackTint.b;
		    v54 = v21;
		    v23 = *(_OWORD *)&v19->m_fakeCrackMarchSteps;
		    v55 = v22;
		    v24 = *(_OWORD *)&v19->m_fakeRefractionTint.a;
		    v56 = v23;
		    v25 = *(_OWORD *)&v19->m_fakeVolumeScatterExtinction.b;
		    v57 = v24;
		    v26 = *(_OWORD *)&v19->m_fakeVolumeScatterAlbedo.b;
		    v58 = v25;
		    v27 = *(_OWORD *)&v19->m_fakeDustFlowSpeed.y;
		    v59 = v26;
		    v60 = *(_OWORD *)&v19->m_fakeRefractionMarchSteps;
		    v28 = *(_OWORD *)&v19->m_fakeDustTint.g;
		    LODWORD(v19) = v19->m_fakeVolumeMask;
		    v61 = v27;
		    v62 = v28;
		    v63 = (int)v19;
		    v29 = v54;
		    *(_OWORD *)&layerTypeData->m_fakeVolumeData.m_enableFakeVolume = v53;
		    v30 = v55;
		    *(_OWORD *)&layerTypeData->m_fakeVolumeData.m_fakeVolumeOpacityTiling = v29;
		    v31 = v56;
		    *(_OWORD *)&layerTypeData->m_fakeVolumeData.m_fakeCrackTint.b = v30;
		    v32 = v57;
		    *(_OWORD *)&layerTypeData->m_fakeVolumeData.m_fakeCrackMarchSteps = v31;
		    v33 = v58;
		    *(_OWORD *)&layerTypeData->m_fakeVolumeData.m_fakeRefractionTint.a = v32;
		    v34 = v59;
		    *(_OWORD *)&layerTypeData->m_fakeVolumeData.m_fakeVolumeScatterExtinction.b = v33;
		    v35 = v60;
		    *(_OWORD *)&layerTypeData->m_fakeVolumeData.m_fakeVolumeScatterAlbedo.b = v34;
		    v36 = v61;
		    *(_OWORD *)&layerTypeData->m_fakeVolumeData.m_fakeRefractionMarchSteps = v35;
		    v37 = v62;
		    LODWORD(v19) = v63;
		    *(_OWORD *)&layerTypeData->m_fakeVolumeData.m_fakeDustFlowSpeed.y = v36;
		    *(_OWORD *)&layerTypeData->m_fakeVolumeData.m_fakeDustTint.g = v37;
		    layerTypeData->m_fakeVolumeData.m_fakeVolumeMask = (int)v19;
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v5->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_16;
		    if ( wrapperArray->max_length.size <= 5469 )
		    {
		LABEL_14:
		      FakeShadowPenumbra = p_fakeShadowData->_FakeShadowPenumbra;
		      FakeShadowStrength = p_fakeShadowData->_FakeShadowStrength;
		      FakeShadowMarchSteps = p_fakeShadowData->_FakeShadowMarchSteps;
		      FakeShadowDistanceLerp = p_fakeShadowData->_FakeShadowDistanceLerp;
		      v51.m_enableFakeShadow = p_fakeShadowData->_EnableFakeShadow;
		      *(_WORD *)(&v51.m_enableFakeShadow + 1) = 0;
		      *(&v51.m_enableFakeShadow + 3) = 0;
		      v42 = _mm_shuffle_ps(*(__m128 *)&v51.m_enableFakeShadow, *(__m128 *)&v51.m_enableFakeShadow, 225);
		      v42.m128_f32[0] = FakeShadowPenumbra;
		      v43 = _mm_shuffle_ps(v42, v42, 198);
		      v43.m128_f32[0] = FakeShadowStrength;
		      v44 = _mm_shuffle_ps(v43, v43, 39);
		      v44.m128_f32[0] = FakeShadowMarchSteps;
		      v45 = _mm_shuffle_ps(v44, v44, 57);
		LABEL_15:
		      *(__m128 *)&layerTypeData->m_fakeShadowData.m_enableFakeShadow = v45;
		      layerTypeData->m_fakeShadowData.m_fakeShadowDistanceLerp = FakeShadowDistanceLerp;
		      return;
		    }
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( !v5 )
		LABEL_16:
		      sub_1800D8260(v5, wrapperArray);
		    if ( LODWORD(v5->_0.namespaze) > 0x155D )
		    {
		      if ( !v5[116]._0.implementedInterfaces )
		        goto LABEL_14;
		      v49 = IFix::WrappersManagerImpl::GetPatch(5469, 0LL);
		      if ( v49 )
		      {
		        v50 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1587(&v51, v49, p_fakeShadowData, 0LL);
		        v45 = *(__m128 *)&v50->m_enableFakeShadow;
		        FakeShadowDistanceLerp = v50->m_fakeShadowDistanceLerp;
		        goto LABEL_15;
		      }
		      goto LABEL_16;
		    }
		LABEL_38:
		    sub_1800D2AB0(v5, wrapperArray);
		  }
		  v46 = IFix::WrappersManagerImpl::GetPatch(5472, 0LL);
		  if ( !v46 )
		    goto LABEL_16;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1589(v46, this, layerTypeData, 0LL);
		}
		
	}
}
