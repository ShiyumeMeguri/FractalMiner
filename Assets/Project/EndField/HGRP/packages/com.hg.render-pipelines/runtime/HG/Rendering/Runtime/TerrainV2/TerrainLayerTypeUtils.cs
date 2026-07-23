using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.HyperGryphEngineCode;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.TerrainV2
{
	public static class TerrainLayerTypeUtils // TypeDefIndex: 38834
	{
		// Methods
		public static bool HasTerrainSimpleSubsurface() => default; // 0x0000000183335000-0x0000000183335220
		// Boolean HasTerrainSimpleSubsurface()
		bool HG::Rendering::Runtime::TerrainV2::TerrainLayerTypeUtils::HasTerrainSimpleSubsurface(MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v1; // rdx
		  int *wrapperArray; // rcx
		  bool v3; // di
		  Object *instance; // rbx
		  Object__Class *klass; // rax
		  int32_t namespaze; // eax
		  bool v7; // si
		  struct HGGraphicsFeatureManager__Class *v8; // rax
		  HGGraphicsFeatureSwitch *terrainSimpleSubsurface; // rbx
		  bool m_defaultValue; // al
		  __int64 v11; // rdx
		  HGTerrainV2__StaticFields *static_fields; // rcx
		  _OWORD *v13; // rax
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2__Array *v24; // r8
		  ILFixDynamicMethodWrapper_2 *v25; // rax
		  ILFixDynamicMethodWrapper_2 *v26; // rax
		  _BYTE v27[272]; // [rsp+20h] [rbp-118h] BYREF
		
		  v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_26;
		  if ( wrapperArray[6] > 1105 )
		  {
		    if ( !v1->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v1);
		      v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v1 = (struct ILFixDynamicMethodWrapper_2__Class *)v1->static_fields->wrapperArray;
		    if ( !v1 )
		      goto LABEL_26;
		    if ( LODWORD(v1->_0.namespaze) <= 0x451 )
		      goto LABEL_48;
		    if ( *(_QWORD *)&v1[23]._1.cctor_finished_or_no_cctor )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1105, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		      goto LABEL_26;
		    }
		  }
		  v3 = 0;
		  instance = (Object *)HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
		  if ( !instance )
		    goto LABEL_26;
		  v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)v1->static_fields;
		  if ( !*(_QWORD *)wrapperArray )
		    goto LABEL_26;
		  if ( *(int *)(*(_QWORD *)wrapperArray + 24LL) <= 672 )
		    goto LABEL_10;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v24 = v1->static_fields->wrapperArray;
		  if ( !v24 )
		    goto LABEL_26;
		  if ( v24->max_length.size <= 0x2A0u )
		    goto LABEL_48;
		  if ( v24[18].vector[24] )
		  {
		    v25 = IFix::WrappersManagerImpl::GetPatch(672, 0LL);
		    if ( !v25 )
		      goto LABEL_26;
		    namespaze = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v25, instance, 0LL);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_10:
		    klass = instance[1].klass;
		    if ( !klass )
		      goto LABEL_26;
		    namespaze = (int32_t)klass->_0.namespaze;
		  }
		  v7 = namespaze == 1;
		  v8 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager);
		    v8 = TypeInfo::HG::Rendering::Runtime::HGGraphicsFeatureManager;
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  terrainSimpleSubsurface = v8->static_fields->terrainSimpleSubsurface;
		  if ( !terrainSimpleSubsurface )
		    goto LABEL_26;
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_26;
		  if ( wrapperArray[6] <= 412 )
		  {
		LABEL_19:
		    m_defaultValue = terrainSimpleSubsurface->fields.m_defaultValue;
		    goto LABEL_20;
		  }
		  if ( !v1->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v1);
		    v1 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)v1->static_fields->wrapperArray;
		  if ( !wrapperArray )
		LABEL_26:
		    sub_1800D8260(wrapperArray, v1);
		  if ( (unsigned int)wrapperArray[6] <= 0x19C )
		LABEL_48:
		    sub_1800D2AB0(wrapperArray, v1);
		  if ( !*((_QWORD *)wrapperArray + 416) )
		    goto LABEL_19;
		  v26 = IFix::WrappersManagerImpl::GetPatch(412, 0LL);
		  if ( !v26 )
		    goto LABEL_26;
		  m_defaultValue = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                     (ILFixDynamicMethodWrapper_20 *)v26,
		                     (Object *)terrainSimpleSubsurface,
		                     0LL);
		LABEL_20:
		  if ( m_defaultValue && !v7 )
		  {
		    v11 = 2LL;
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGTerrainV2->static_fields;
		    v13 = v27;
		    do
		    {
		      v13 += 8;
		      v14 = *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._glintData._EnableFakeGlint;
		      v15 = *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._glintData._GlintScale;
		      static_fields = (HGTerrainV2__StaticFields *)((char *)static_fields + 128);
		      *(v13 - 8) = v14;
		      v16 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeRefractionHeightScale;
		      *(v13 - 7) = v15;
		      v17 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustDepth;
		      *(v13 - 6) = v16;
		      v18 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustFlowSpeed.w;
		      *(v13 - 5) = v17;
		      v19 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustTint.a;
		      *(v13 - 4) = v18;
		      v20 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._FakeVolumeMask;
		      *(v13 - 3) = v19;
		      v21 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeShadowData._FakeShadowStrength;
		      *(v13 - 2) = v20;
		      *(v13 - 1) = v21;
		      --v11;
		    }
		    while ( v11 );
		    *v13 = *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._glintData._EnableFakeGlint;
		    return v27[48];
		  }
		  return v3;
		}
		
		public static unsafe HGTerrainLayerTypeData* GetNativeLayerTypeData() => default; // 0x0000000183334950-0x0000000183334A40
		// HGTerrainLayerTypeData* GetNativeLayerTypeData()
		HGTerrainLayerTypeData *HG::Rendering::Runtime::TerrainV2::TerrainLayerTypeUtils::GetNativeLayerTypeData(
		        MethodInfo *method)
		{
		  __int64 (__fastcall *v1)(__int64); // rax
		  HGTerrainLayerTypeData *v2; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  HGTerrainLayerTypeData *v5; // rbx
		  __int64 v6; // rdx
		  HGTerrainV2__StaticFields *static_fields; // rcx
		  TerrainLayerTypeData *v8; // rax
		  Color v9; // xmm0
		  HGTerrainLayerTypeData *result; // rax
		  __int64 v11; // rax
		  TerrainLayerTypeData v12; // [rsp+20h] [rbp-118h] BYREF
		
		  sub_18033B9D0(&v12, 0LL, 272LL);
		  v1 = (__int64 (__fastcall *)(__int64))qword_18F370618;
		  if ( !qword_18F370618 )
		  {
		    v1 = (__int64 (__fastcall *)(__int64))il2cpp_resolve_icall_1(
		                                            "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		    if ( !v1 )
		    {
		      v11 = sub_1802EE1B8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
		      sub_18007E1B0(v11, 0LL);
		    }
		    qword_18F370618 = (__int64)v1;
		  }
		  v2 = (HGTerrainLayerTypeData *)v1(400LL);
		  v5 = v2;
		  if ( !v2 )
		    sub_1800D8260(v4, v3);
		  v2->m_bHasLayerTypeData = 0;
		  v6 = 2LL;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGTerrainV2->static_fields;
		  v8 = &v12;
		  do
		  {
		    v8 = (TerrainLayerTypeData *)((char *)v8 + 128);
		    v9 = *(Color *)&static_fields->_LayerTypeData_k__BackingField._glintData._EnableFakeGlint;
		    static_fields = (HGTerrainV2__StaticFields *)((char *)static_fields + 128);
		    v8[-1]._fakeVolumeData._Params._FakeVolumeScatterExtinction = v9;
		    v8[-1]._fakeVolumeData._Params._FakeVolumeScatterAlbedo = static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeVolumeScatterAlbedo;
		    *(_OWORD *)&v8[-1]._fakeVolumeData._Params._FakeRefractionHeightScale = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeRefractionHeightScale;
		    *(_OWORD *)&v8[-1]._fakeVolumeData._Params._FakeDustDepth = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustDepth;
		    *(_OWORD *)&v8[-1]._fakeVolumeData._Params._FakeDustFlowSpeed.w = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustFlowSpeed.w;
		    *(_OWORD *)&v8[-1]._fakeVolumeData._Params._FakeDustTint.a = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustTint.a;
		    *(_OWORD *)&v8[-1]._fakeVolumeData._FakeVolumeMask = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._FakeVolumeMask;
		    *(_OWORD *)&v8[-1]._fakeShadowData._FakeShadowStrength = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeShadowData._FakeShadowStrength;
		    --v6;
		  }
		  while ( v6 );
		  *(_OWORD *)&v8->_glintData._EnableFakeGlint = *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._glintData._EnableFakeGlint;
		  HG::Rendering::Runtime::TerrainV2::TerrainLayerTypeData::PrepareTerrainDataCPP(&v12, v5, 0LL);
		  result = v5;
		  v5->m_bHasLayerTypeData = 1;
		  return result;
		}
		
	}
}
