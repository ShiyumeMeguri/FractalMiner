using System;
using System.Runtime.InteropServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime.TerrainV2
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TerrainLayerTypeData
	{
		public void SetupTerrainParams(HGRenderGraphContext context)
		{
			// // Void SetupTerrainParams(HGRenderGraphContext)
			// void HG::Rendering::Runtime::TerrainV2::TerrainLayerTypeData::SetupTerrainParams(
			//         TerrainLayerTypeData *this,
			//         HGRenderGraphContext *context,
			//         MethodInfo *method)
			// {
			//   BOOL EnableFakeVolume; // esi
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   CommandBuffer *cmd; // rdi
			//   String *s_HasTerrainLayerTypeData; // rbp
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   EnableFakeVolume = 1;
			//   if ( !byte_18D919D41 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     byte_18D919D41 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(4770, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4770, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1379(Patch, this, (Object *)context, 0LL);
			//       return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(v7, v6);
			//   }
			//   HG::Rendering::Runtime::TerrainV2::TerrainGlintData::SetupTerrainParams(&this._glintData, context, 0LL);
			//   HG::Rendering::Runtime::TerrainV2::TerrainSubsurfaceData::SetupTerrainParams(&this._subsurfaceData, context, 0LL);
			//   HG::Rendering::Runtime::TerrainV2::TerrainFakeVolumeData::SetupTerrainParams(&this._fakeVolumeData, context, 0LL);
			//   HG::Rendering::Runtime::TerrainV2::TerrainFakeShadowData::SetupTerrainParams(&this._fakeShadowData, context, 0LL);
			//   if ( !context )
			//     goto LABEL_10;
			//   cmd = context.fields.cmd;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//   s_HasTerrainLayerTypeData = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_HasTerrainLayerTypeData;
			//   if ( !this._glintData._EnableFakeGlint && !this._subsurfaceData._Params._UseSubsurfaceProfile )
			//     EnableFakeVolume = this._fakeVolumeData._Params._EnableFakeVolume;
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//   UnityEngine::Rendering::CoreUtils::SetKeyword(cmd, s_HasTerrainLayerTypeData, EnableFakeVolume, 0LL);
			// }
			// 
		}

		public static void ResetTerrainParams(HGRenderGraphContext context)
		{
			// // Void ResetTerrainParams(HGRenderGraphContext)
			// void HG::Rendering::Runtime::TerrainV2::TerrainLayerTypeData::ResetTerrainParams(
			//         HGRenderGraphContext *context,
			//         MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   CommandBuffer *cmd; // rdi
			//   String *s_HasTerrainLayerTypeData; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919D42 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     byte_18D919D42 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4771, 0LL) )
			//   {
			//     HG::Rendering::Runtime::TerrainV2::TerrainGlintData::ResetTerrainParams(context, 0LL);
			//     HG::Rendering::Runtime::TerrainV2::TerrainFakeVolumeData::ResetTerrainParams(context, 0LL);
			//     HG::Rendering::Runtime::TerrainV2::TerrainSubsurfaceData::ResetTerrainParams(context, 0LL);
			//     HG::Rendering::Runtime::TerrainV2::TerrainFakeShadowData::ResetTerrainParams(context, 0LL);
			//     if ( context )
			//     {
			//       cmd = context.fields.cmd;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//       s_HasTerrainLayerTypeData = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields.s_HasTerrainLayerTypeData;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       UnityEngine::Rendering::CoreUtils::SetKeyword(cmd, s_HasTerrainLayerTypeData, 0, 0LL);
			//       return;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4771, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)context, 0LL);
			// }
			// 
		}

		public void PrepareTerrainDataCPP(ref HGTerrainLayerTypeData layerTypeData)
		{
			// // Void PrepareTerrainDataCPP(HGTerrainLayerTypeData ByRef)
			// void HG::Rendering::Runtime::TerrainV2::TerrainLayerTypeData::PrepareTerrainDataCPP(
			//         TerrainLayerTypeData *this,
			//         HGTerrainLayerTypeData *layerTypeData,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   bool EnableFakeGlint; // al
			//   float GlintTopBlendSmoothness; // xmm2_4
			//   float GlintTopBlendThreshold; // xmm3_4
			//   __m128i GlintColor; // xmm0
			//   __m128 v11; // xmm1
			//   __int128 v12; // xmm2
			//   __m128 v13; // xmm1
			//   float a; // ecx
			//   __int64 v15; // xmm3_8
			//   __m128 v16; // xmm1
			//   HGTerrainSubsurfaceData *v17; // rax
			//   int32_t m_terrainStencil; // ecx
			//   HGTerrainFakeVolumeData *v19; // rax
			//   TerrainFakeShadowData *p_fakeShadowData; // rbx
			//   bool v21; // zf
			//   HGTerrainFakeVolumeData *p_m_fakeVolumeData; // rdx
			//   __int128 v23; // xmm1
			//   __int128 v24; // xmm0
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   __int128 v33; // xmm1
			//   __int128 v34; // xmm0
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm0
			//   __int128 v37; // xmm1
			//   __int128 v38; // xmm0
			//   __int128 v39; // xmm1
			//   float FakeShadowPenumbra; // xmm0_4
			//   float FakeShadowStrength; // xmm1_4
			//   float FakeShadowMarchSteps; // xmm2_4
			//   float FakeShadowDistanceLerp; // ecx
			//   __m128 v44; // xmm4
			//   __m128 v45; // xmm4
			//   __m128 v46; // xmm4
			//   __m128 v47; // xmm4
			//   ILFixDynamicMethodWrapper_2 *v48; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGTerrainGlintData *v50; // rax
			//   ILFixDynamicMethodWrapper_2 *v51; // rax
			//   HGTerrainFakeShadowData *v52; // rax
			//   HGTerrainFakeShadowData v53; // [rsp+20h] [rbp-E0h] BYREF
			//   HGTerrainGlintData v54; // [rsp+38h] [rbp-C8h] BYREF
			//   __int128 v55; // [rsp+70h] [rbp-90h]
			//   __int128 v56; // [rsp+80h] [rbp-80h]
			//   __int128 v57; // [rsp+90h] [rbp-70h]
			//   __int128 v58; // [rsp+A0h] [rbp-60h]
			//   __int128 v59; // [rsp+B0h] [rbp-50h]
			//   __int128 v60; // [rsp+C0h] [rbp-40h]
			//   __int128 v61; // [rsp+D0h] [rbp-30h]
			//   __int128 v62; // [rsp+E0h] [rbp-20h]
			//   __int128 v63; // [rsp+F0h] [rbp-10h]
			//   __int128 v64; // [rsp+100h] [rbp+0h]
			//   int v65; // [rsp+110h] [rbp+10h]
			//   HGTerrainFakeVolumeData v66; // [rsp+120h] [rbp+20h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, layerTypeData);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_22;
			//   if ( wrapperArray.max_length.size <= 4772 )
			//     goto LABEL_7;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, wrapperArray);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_22;
			//   if ( wrapperArray.max_length.size <= 0x12A4u )
			//     goto LABEL_44;
			//   if ( !wrapperArray[132].vector[20] )
			//   {
			// LABEL_7:
			//     if ( !byte_18D8EDC37 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       byte_18D8EDC37 = 1;
			//     }
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v5.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_22;
			//     if ( wrapperArray.max_length.size <= 4760 )
			//       goto LABEL_13;
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v5.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_22;
			//     if ( wrapperArray.max_length.size <= 0x1298u )
			//       goto LABEL_44;
			//     if ( wrapperArray[132].vector[8] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(4760, 0LL);
			//       if ( !Patch )
			//         goto LABEL_22;
			//       v50 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1372(&v54, Patch, &this._glintData, 0LL);
			//       v16 = *(__m128 *)&v50.m_enableFakeGlint;
			//       a = v50.m_glintColor.a;
			//       v12 = *(_OWORD *)&v50.m_glintScale;
			//       v15 = *(_QWORD *)&v50.m_glintColor.g;
			//     }
			//     else
			//     {
			// LABEL_13:
			//       EnableFakeGlint = this._glintData._EnableFakeGlint;
			//       GlintTopBlendSmoothness = this._glintData._GlintTopBlendSmoothness;
			//       GlintTopBlendThreshold = this._glintData._GlintTopBlendThreshold;
			//       *(_OWORD *)&v54.m_glintStrength = *(_OWORD *)&this._glintData._GlintStrength;
			//       *(_WORD *)(&v54.m_enableFakeGlint + 1) = 0;
			//       GlintColor = (__m128i)this._glintData._GlintColor;
			//       *(&v54.m_enableFakeGlint + 3) = 0;
			//       v54.m_enableFakeGlint = EnableFakeGlint;
			//       v54.m_glintColor = (Color)GlintColor;
			//       v11 = _mm_shuffle_ps(*(__m128 *)&v54.m_enableFakeGlint, *(__m128 *)&v54.m_enableFakeGlint, 225);
			//       v11.m128_f32[0] = GlintTopBlendSmoothness;
			//       v12 = *(_OWORD *)&v54.m_glintScale;
			//       v13 = _mm_shuffle_ps(v11, v11, 198);
			//       v13.m128_f32[0] = GlintTopBlendThreshold;
			//       a = COERCE_FLOAT(_mm_cvtsi128_si32(_mm_srli_si128(GlintColor, 12)));
			//       v15 = *(_OWORD *)&GlintColor >> 32;
			//       v16 = _mm_shuffle_ps(v13, v13, 201);
			//     }
			//     *(__m128 *)&layerTypeData.m_glintData.m_enableFakeGlint = v16;
			//     *(_OWORD *)&layerTypeData.m_glintData.m_glintScale = v12;
			//     *(_QWORD *)&layerTypeData.m_glintData.m_glintColor.g = v15;
			//     layerTypeData.m_glintData.m_glintColor.a = a;
			//     v17 = HG::Rendering::Runtime::TerrainV2::TerrainSubsurfaceData::ToDataCPP(
			//             (HGTerrainSubsurfaceData *)&v53,
			//             &this._subsurfaceData,
			//             0LL);
			//     m_terrainStencil = v17.m_terrainStencil;
			//     *(_OWORD *)&layerTypeData.m_subsurfaceData.m_useSubsurfaceProfile = *(_OWORD *)&v17.m_useSubsurfaceProfile;
			//     layerTypeData.m_subsurfaceData.m_terrainStencil = m_terrainStencil;
			//     v19 = HG::Rendering::Runtime::TerrainV2::TerrainFakeVolumeData::ToDataCPP(&v66, &this._fakeVolumeData, 0LL);
			//     p_fakeShadowData = &this._fakeShadowData;
			//     v21 = byte_18D8EDC37 == 0;
			//     p_m_fakeVolumeData = &layerTypeData.m_fakeVolumeData;
			//     v23 = *(_OWORD *)&v19.m_fakeVolumeOpacityTiling;
			//     v55 = *(_OWORD *)&v19.m_enableFakeVolume;
			//     v24 = *(_OWORD *)&v19.m_fakeCrackTint.b;
			//     v56 = v23;
			//     v25 = *(_OWORD *)&v19.m_fakeCrackMarchSteps;
			//     v57 = v24;
			//     v26 = *(_OWORD *)&v19.m_fakeRefractionTint.a;
			//     v58 = v25;
			//     v27 = *(_OWORD *)&v19.m_fakeVolumeScatterExtinction.b;
			//     v59 = v26;
			//     v28 = *(_OWORD *)&v19.m_fakeVolumeScatterAlbedo.b;
			//     v60 = v27;
			//     v29 = *(_OWORD *)&v19.m_fakeDustFlowSpeed.y;
			//     v61 = v28;
			//     v62 = *(_OWORD *)&v19.m_fakeRefractionMarchSteps;
			//     v30 = *(_OWORD *)&v19.m_fakeDustTint.g;
			//     LODWORD(v19) = v19.m_fakeVolumeMask;
			//     v63 = v29;
			//     v64 = v30;
			//     v65 = (int)v19;
			//     v31 = v56;
			//     *(_OWORD *)&layerTypeData.m_fakeVolumeData.m_enableFakeVolume = v55;
			//     v32 = v57;
			//     *(_OWORD *)&layerTypeData.m_fakeVolumeData.m_fakeVolumeOpacityTiling = v31;
			//     v33 = v58;
			//     *(_OWORD *)&layerTypeData.m_fakeVolumeData.m_fakeCrackTint.b = v32;
			//     v34 = v59;
			//     *(_OWORD *)&layerTypeData.m_fakeVolumeData.m_fakeCrackMarchSteps = v33;
			//     v35 = v60;
			//     *(_OWORD *)&layerTypeData.m_fakeVolumeData.m_fakeRefractionTint.a = v34;
			//     v36 = v61;
			//     *(_OWORD *)&layerTypeData.m_fakeVolumeData.m_fakeVolumeScatterExtinction.b = v35;
			//     v37 = v62;
			//     *(_OWORD *)&layerTypeData.m_fakeVolumeData.m_fakeVolumeScatterAlbedo.b = v36;
			//     v38 = v63;
			//     *(_OWORD *)&layerTypeData.m_fakeVolumeData.m_fakeRefractionMarchSteps = v37;
			//     v39 = v64;
			//     LODWORD(v19) = v65;
			//     *(_OWORD *)&layerTypeData.m_fakeVolumeData.m_fakeDustFlowSpeed.y = v38;
			//     *(_OWORD *)&layerTypeData.m_fakeVolumeData.m_fakeDustTint.g = v39;
			//     layerTypeData.m_fakeVolumeData.m_fakeVolumeMask = (int)v19;
			//     if ( v21 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EDC37 = 1;
			//     }
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, p_m_fakeVolumeData);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v5.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_22;
			//     if ( wrapperArray.max_length.size <= 4769 )
			//     {
			// LABEL_20:
			//       FakeShadowPenumbra = p_fakeShadowData._FakeShadowPenumbra;
			//       FakeShadowStrength = p_fakeShadowData._FakeShadowStrength;
			//       FakeShadowMarchSteps = p_fakeShadowData._FakeShadowMarchSteps;
			//       FakeShadowDistanceLerp = p_fakeShadowData._FakeShadowDistanceLerp;
			//       v53.m_enableFakeShadow = p_fakeShadowData._EnableFakeShadow;
			//       *(_WORD *)(&v53.m_enableFakeShadow + 1) = 0;
			//       *(&v53.m_enableFakeShadow + 3) = 0;
			//       v44 = _mm_shuffle_ps(*(__m128 *)&v53.m_enableFakeShadow, *(__m128 *)&v53.m_enableFakeShadow, 225);
			//       v44.m128_f32[0] = FakeShadowPenumbra;
			//       v45 = _mm_shuffle_ps(v44, v44, 198);
			//       v45.m128_f32[0] = FakeShadowStrength;
			//       v46 = _mm_shuffle_ps(v45, v45, 39);
			//       v46.m128_f32[0] = FakeShadowMarchSteps;
			//       v47 = _mm_shuffle_ps(v46, v46, 57);
			// LABEL_21:
			//       *(__m128 *)&layerTypeData.m_fakeShadowData.m_enableFakeShadow = v47;
			//       layerTypeData.m_fakeShadowData.m_fakeShadowDistanceLerp = FakeShadowDistanceLerp;
			//       return;
			//     }
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( !v5 )
			// LABEL_22:
			//       sub_180B536AC(v5, wrapperArray);
			//     if ( LODWORD(v5._0.namespaze) > 0x12A1 )
			//     {
			//       if ( !v5[101]._1.unity_user_data )
			//         goto LABEL_20;
			//       v51 = IFix::WrappersManagerImpl::GetPatch(4769, 0LL);
			//       if ( v51 )
			//       {
			//         v52 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1378(&v53, v51, p_fakeShadowData, 0LL);
			//         v47 = *(__m128 *)&v52.m_enableFakeShadow;
			//         FakeShadowDistanceLerp = v52.m_fakeShadowDistanceLerp;
			//         goto LABEL_21;
			//       }
			//       goto LABEL_22;
			//     }
			// LABEL_44:
			//     sub_180070270(v5, wrapperArray);
			//   }
			//   v48 = IFix::WrappersManagerImpl::GetPatch(4772, 0LL);
			//   if ( !v48 )
			//     goto LABEL_22;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1380(v48, this, layerTypeData, 0LL);
			// }
			// 
		}

		[SerializeField]
		public TerrainGlintData _glintData;

		[SerializeField]
		public TerrainSubsurfaceData _subsurfaceData;

		[SerializeField]
		public TerrainFakeVolumeData _fakeVolumeData;

		[SerializeField]
		public TerrainFakeShadowData _fakeShadowData;
	}
}
