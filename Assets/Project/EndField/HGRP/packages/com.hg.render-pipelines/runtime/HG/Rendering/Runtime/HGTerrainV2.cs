using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime.TerrainV2;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.HyperGryph;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[ExecuteInEditMode]
	public class HGTerrainV2 : MonoBehaviour // TypeDefIndex: 38651
	{
		// Fields
		public string atlasPageRootPathField; // 0x18
		public bool atlasBytesCompressed; // 0x20
		private uint m_regionHandle; // 0x24
		private TerrainInfo m_terrainInfo; // 0x28
		private NativeArray<UnityEngine.HyperGryph.SplatLayerData> m_layerDataArray; // 0x58
		private NativeArray<UnityEngine.HyperGryph.TerrainNodeData> m_nodeDataArray; // 0x68
		private NativeArray<ulong> m_sectorSplatInfoArray; // 0x78
		private bool m_phase0HasSetup; // 0x88
	
		// Properties
		public static TerrainLayerTypeData LayerTypeData { get; private set; } // 0x0000000184DA1CB0-0x0000000184DA1D30 0x0000000189C235E0-0x0000000189C23660
		// TerrainLayerTypeData get_LayerTypeData()
		TerrainLayerTypeData *HG::Rendering::Runtime::HGTerrainV2::get_LayerTypeData(
		        TerrainLayerTypeData *__return_ptr retstr,
		        MethodInfo *method)
		{
		  __int64 v2; // r8
		  HGTerrainV2__StaticFields *static_fields; // rdx
		  TerrainLayerTypeData *v4; // rax
		  Color v5; // xmm0
		  Color v6; // xmm1
		  __int128 v7; // xmm0
		  __int128 v8; // xmm1
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  __int128 v11; // xmm0
		  __int128 v12; // xmm1
		
		  v2 = 2LL;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGTerrainV2->static_fields;
		  v4 = retstr;
		  do
		  {
		    v4 = (TerrainLayerTypeData *)((char *)v4 + 128);
		    v5 = *(Color *)&static_fields->_LayerTypeData_k__BackingField._glintData._EnableFakeGlint;
		    v6 = *(Color *)&static_fields->_LayerTypeData_k__BackingField._glintData._GlintScale;
		    static_fields = (HGTerrainV2__StaticFields *)((char *)static_fields + 128);
		    v4[-1]._fakeVolumeData._Params._FakeVolumeScatterExtinction = v5;
		    v7 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeRefractionHeightScale;
		    v4[-1]._fakeVolumeData._Params._FakeVolumeScatterAlbedo = v6;
		    v8 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustDepth;
		    *(_OWORD *)&v4[-1]._fakeVolumeData._Params._FakeRefractionHeightScale = v7;
		    v9 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustFlowSpeed.w;
		    *(_OWORD *)&v4[-1]._fakeVolumeData._Params._FakeDustDepth = v8;
		    v10 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustTint.a;
		    *(_OWORD *)&v4[-1]._fakeVolumeData._Params._FakeDustFlowSpeed.w = v9;
		    v11 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._FakeVolumeMask;
		    *(_OWORD *)&v4[-1]._fakeVolumeData._Params._FakeDustTint.a = v10;
		    v12 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeShadowData._FakeShadowStrength;
		    *(_OWORD *)&v4[-1]._fakeVolumeData._FakeVolumeMask = v11;
		    *(_OWORD *)&v4[-1]._fakeShadowData._FakeShadowStrength = v12;
		    --v2;
		  }
		  while ( v2 );
		  *(_OWORD *)&v4->_glintData._EnableFakeGlint = *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._glintData._EnableFakeGlint;
		  return retstr;
		}
		

		// Void set_LayerTypeData(TerrainLayerTypeData)
		void HG::Rendering::Runtime::HGTerrainV2::set_LayerTypeData(TerrainLayerTypeData *value, MethodInfo *method)
		{
		  Int32__Array **v2; // r9
		  HGTerrainV2__StaticFields *static_fields; // rdx
		  __int64 v4; // rax
		  __int128 v5; // xmm1
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  Color FakeCrackTint; // xmm0
		  __int128 v11; // xmm1
		  MethodInfo *v12; // [rsp+28h] [rbp+28h]
		
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGTerrainV2->static_fields;
		  v4 = 2LL;
		  do
		  {
		    v5 = *(_OWORD *)&value->_glintData._GlintScale;
		    *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._glintData._EnableFakeGlint = *(_OWORD *)&value->_glintData._EnableFakeGlint;
		    v6 = *(_OWORD *)&value->_glintData._GlintColor.g;
		    *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._glintData._GlintScale = v5;
		    v7 = *(_OWORD *)&value->_subsurfaceData._Params._UseSubsurfaceProfile;
		    *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._glintData._GlintColor.g = v6;
		    v8 = *(_OWORD *)&value->_subsurfaceData._SubsurfaceProfile;
		    *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._subsurfaceData._Params._UseSubsurfaceProfile = v7;
		    v9 = *(_OWORD *)&value->_fakeVolumeData._Params._FakeVolumeFresnelStrength;
		    *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._subsurfaceData._SubsurfaceProfile = v8;
		    FakeCrackTint = value->_fakeVolumeData._Params._FakeCrackTint;
		    *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeVolumeFresnelStrength = v9;
		    v11 = *(_OWORD *)&value->_fakeVolumeData._Params._FakeCrackHeightScale;
		    value = (TerrainLayerTypeData *)((char *)value + 128);
		    static_fields->_LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeCrackTint = FakeCrackTint;
		    static_fields = (HGTerrainV2__StaticFields *)((char *)static_fields + 128);
		    *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeShadowData._FakeShadowStrength = v11;
		    --v4;
		  }
		  while ( v4 );
		  *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._glintData._EnableFakeGlint = *(_OWORD *)&value->_glintData._EnableFakeGlint;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGTerrainV2->static_fields->_LayerTypeData_k__BackingField._subsurfaceData._SubsurfaceProfile,
		    (HGRuntimeGrassQuery_Node *)static_fields,
		    (HGRuntimeGrassQuery_Node *)0x80,
		    v2,
		    v12);
		}
		
		public static bool NewEditorTerrainRendering { get => default; } // 0x0000000189C235A0-0x0000000189C235E0 
		// Boolean get_NewEditorTerrainRendering()
		bool HG::Rendering::Runtime::HGTerrainV2::get_NewEditorTerrainRendering(MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  result = IFix::WrappersManagerImpl::IsPatched(4054, 0LL);
		  if ( result )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4054, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v4, v3);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_4((ILFixDynamicMethodWrapper_23 *)Patch, 0LL);
		  }
		  return result;
		}
		
	
		// Constructors
		public HGTerrainV2() {} // 0x0000000184D84C40-0x0000000184D84C60
		// P3dModel()
		void PaintIn3D::P3dModel::P3dModel(P3dModel *this, MethodInfo *method)
		{
		  this->fields.includeScale = 1;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
	
		// Methods
		public void SetupFromParams_Phase0(ref TerrainInfo terrainInfo, NativeArray<UnityEngine.HyperGryph.SplatLayerData> layerDataArray, NativeArray<UnityEngine.HyperGryph.TerrainNodeData> nodeDataArray, NativeArray<ulong> sectorSplatInfoArray, string atlasPageRootPath, uint regionHandle, bool atlasBytesCompressed_) {} // 0x0000000184CA5B30-0x0000000184CA5CE0
		// Void SetupFromParams_Phase0(TerrainInfo ByRef, NativeArray`1[UnityEngine.HyperGryph.SplatLayerData], NativeArray`1[UnityEngine.HyperGryph.TerrainNodeData], NativeArray`1[System.UInt64], String, UInt32, Boolean)
		void HG::Rendering::Runtime::HGTerrainV2::SetupFromParams_Phase0(
		        HGTerrainV2 *this,
		        TerrainInfo *terrainInfo,
		        NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ *layerDataArray,
		        NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ *nodeDataArray,
		        NativeArray_1_System_UInt64_ *sectorSplatInfoArray,
		        String *atlasPageRootPath,
		        uint32_t regionHandle,
		        bool atlasBytesCompressed_,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  __int64 v16; // xmm0_8
		  int v17; // eax
		  __int128 v18; // xmm2
		  NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ v19; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ v23; // xmm1
		  NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ v24; // xmm0
		  MethodInfo *v25; // [rsp+20h] [rbp-68h]
		  NativeArray_1_System_UInt64_ v26; // [rsp+50h] [rbp-38h] BYREF
		  NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ v27; // [rsp+60h] [rbp-28h] BYREF
		  NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ v28; // [rsp+70h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4055, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4055, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v22, v21);
		    v23 = *nodeDataArray;
		    v26 = *sectorSplatInfoArray;
		    v24 = *layerDataArray;
		    v27 = v23;
		    v28 = v24;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1428(
		      Patch,
		      (Object *)this,
		      terrainInfo,
		      &v28,
		      &v27,
		      &v26,
		      (Object *)atlasPageRootPath,
		      regionHandle,
		      atlasBytesCompressed_,
		      0LL);
		  }
		  else
		  {
		    this->fields.atlasPageRootPathField = atlasPageRootPath;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.atlasPageRootPathField, v13, v14, v15, v25);
		    this->fields.m_regionHandle = regionHandle;
		    v16 = *(_QWORD *)&terrainInfo->heightmapPageSize;
		    v17 = *(_DWORD *)&terrainInfo->albedoTexPageSize;
		    v18 = *(_OWORD *)&terrainInfo->terrainSize;
		    *(_OWORD *)&this->fields.m_terrainInfo.terrainPosition.x = *(_OWORD *)&terrainInfo->terrainPosition.x;
		    *(_OWORD *)&this->fields.m_terrainInfo.terrainSize = v18;
		    *(_QWORD *)&this->fields.m_terrainInfo.heightmapPageSize = v16;
		    v19 = *layerDataArray;
		    *(_DWORD *)&this->fields.m_terrainInfo.albedoTexPageSize = v17;
		    this->fields.atlasBytesCompressed = atlasBytesCompressed_;
		    v26 = (NativeArray_1_System_UInt64_)v19;
		    HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase0_g__CopyNativeArray_14_0<UnityEngine::HyperGryph::SplatLayerData>(
		      (NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ *)&v26,
		      &this->fields.m_layerDataArray,
		      MethodInfo::HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase0_g__CopyNativeArray_14_0<UnityEngine::HyperGryph::SplatLayerData>);
		    v26 = (NativeArray_1_System_UInt64_)*nodeDataArray;
		    HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase0_g__CopyNativeArray_14_0<UnityEngine::HyperGryph::TerrainNodeData>(
		      (NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ *)&v26,
		      &this->fields.m_nodeDataArray,
		      MethodInfo::HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase0_g__CopyNativeArray_14_0<UnityEngine::HyperGryph::TerrainNodeData>);
		    v26 = *sectorSplatInfoArray;
		    HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase0_g__CopyNativeArray_14_0<unsigned long>(
		      &v26,
		      &this->fields.m_sectorSplatInfoArray,
		      MethodInfo::HG::Rendering::Runtime::HGTerrainV2::_SetupFromParams_Phase0_g__CopyNativeArray_14_0<unsigned long>);
		    this->fields.m_phase0HasSetup = 1;
		  }
		}
		
		public void SetupFromParams_Phase1(ref TerrainLayerTypeData layerTypeData, ComputeShader terrainCS, ComputeShader terrainRTCS, Shader terrainPS, Texture2D splatIndexMap, int splatTier, bool enableHalfVTSize, bool enableHalfAtlasSize, GraphicsFormat mobileSplatControlFormat) {} // 0x00000001837E2EA0-0x00000001837E3130
		// Void SetupFromParams_Phase1(TerrainLayerTypeData ByRef, ComputeShader, ComputeShader, Shader, Texture2D, Int32, Boolean, Boolean, GraphicsFormat)
		void HG::Rendering::Runtime::HGTerrainV2::SetupFromParams_Phase1(
		        HGTerrainV2 *this,
		        TerrainLayerTypeData *layerTypeData,
		        ComputeShader *terrainCS,
		        ComputeShader *terrainRTCS,
		        Shader *terrainPS,
		        Texture2D *splatIndexMap,
		        int32_t splatTier,
		        bool enableHalfVTSize,
		        bool enableHalfAtlasSize,
		        GraphicsFormat__Enum mobileSplatControlFormat,
		        MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  HGRuntimeGrassQuery_Node *v16; // rdx
		  HGManagerContext *v17; // rbx
		  ILFixDynamicMethodWrapper_2 *terrainStreamingManager_k__BackingField; // rcx
		  bool v19; // bp
		  bool v20; // si
		  bool v21; // r14
		  HGRenderPipeline *currentPipeline; // rax
		  HGRenderPipeline *v23; // rax
		  HGRenderPipeline *v24; // rax
		  String *atlasPageRootPathField; // rcx
		  NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ m_nodeDataArray; // xmm1
		  NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ m_layerDataArray; // xmm0
		  HGRuntimeGrassQuery_Node *v28; // r8
		  Int32__Array **v29; // r9
		  MethodInfo *P3; // [rsp+20h] [rbp-C8h]
		  GraphicsFormat__Enum P9; // [rsp+50h] [rbp-98h]
		  bool atlasBytesCompressed; // [rsp+88h] [rbp-60h]
		  NativeArray_1_System_UInt64_ m_sectorSplatInfoArray; // [rsp+A0h] [rbp-48h] BYREF
		  NativeArray_1_UnityEngine_HyperGryph_TerrainNodeData_ v34; // [rsp+B0h] [rbp-38h] BYREF
		  NativeArray_1_UnityEngine_HyperGryph_SplatLayerData_ v35; // [rsp+C0h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4056, 0LL) )
		  {
		    HG::Rendering::Runtime::HGTerrainV2::UpdateLayerTypeData(layerTypeData, 0LL);
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    v17 = currentManagerContext;
		    if ( currentManagerContext )
		    {
		      terrainStreamingManager_k__BackingField = (ILFixDynamicMethodWrapper_2 *)currentManagerContext->fields._terrainStreamingManager_k__BackingField;
		      if ( !terrainStreamingManager_k__BackingField )
		        goto LABEL_4;
		      HG::Rendering::Runtime::HGTerrainStreamingManager::Dispose(
		        (HGTerrainStreamingManager *)terrainStreamingManager_k__BackingField,
		        0LL);
		    }
		    v19 = 0;
		    v20 = 0;
		    v21 = 0;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		    if ( HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL) )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipeline->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		      currentPipeline = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		      if ( !currentPipeline )
		        goto LABEL_4;
		      terrainStreamingManager_k__BackingField = (ILFixDynamicMethodWrapper_2 *)currentPipeline->fields._settingParameters_k__BackingField;
		      if ( !terrainStreamingManager_k__BackingField )
		        goto LABEL_4;
		      v19 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		              (SettingParameter_1_System_Boolean_ *)terrainStreamingManager_k__BackingField[32].klass,
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		      v23 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		      if ( !v23 )
		        goto LABEL_4;
		      terrainStreamingManager_k__BackingField = (ILFixDynamicMethodWrapper_2 *)v23->fields._settingParameters_k__BackingField;
		      if ( !terrainStreamingManager_k__BackingField )
		        goto LABEL_4;
		      v20 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		              (SettingParameter_1_System_Boolean_ *)terrainStreamingManager_k__BackingField[32].monitor,
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		      v24 = HG::Rendering::Runtime::HGRenderPipeline::get_currentPipeline(0LL);
		      if ( !v24 )
		        goto LABEL_4;
		      terrainStreamingManager_k__BackingField = (ILFixDynamicMethodWrapper_2 *)v24->fields._settingParameters_k__BackingField;
		      if ( !terrainStreamingManager_k__BackingField )
		        goto LABEL_4;
		      v21 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
		              (SettingParameter_1_System_Boolean_ *)terrainStreamingManager_k__BackingField[32].fields.virtualMachine,
		              MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
		    }
		    atlasPageRootPathField = this->fields.atlasPageRootPathField;
		    m_nodeDataArray = this->fields.m_nodeDataArray;
		    atlasBytesCompressed = this->fields.atlasBytesCompressed;
		    P9 = this->fields.m_regionHandle;
		    m_sectorSplatInfoArray = this->fields.m_sectorSplatInfoArray;
		    m_layerDataArray = this->fields.m_layerDataArray;
		    v34 = m_nodeDataArray;
		    v35 = m_layerDataArray;
		    UnityEngine::HyperGryph::HGTerrainManager::SetupTerrainManager(
		      atlasPageRootPathField,
		      &this->fields.m_terrainInfo,
		      terrainCS,
		      terrainRTCS,
		      terrainPS,
		      splatIndexMap,
		      &v35,
		      splatTier,
		      &v34,
		      &m_sectorSplatInfoArray,
		      P9,
		      enableHalfVTSize,
		      enableHalfAtlasSize,
		      mobileSplatControlFormat,
		      v19,
		      v20,
		      v21,
		      atlasBytesCompressed,
		      0LL);
		    if ( !v17 )
		    {
		LABEL_21:
		      sub_18026B6C0(&this->fields.m_layerDataArray);
		      sub_18026B780(&this->fields.m_nodeDataArray);
		      sub_18026B840(&this->fields.m_sectorSplatInfoArray);
		      this->fields.m_phase0HasSetup = 0;
		      return;
		    }
		    terrainStreamingManager_k__BackingField = (ILFixDynamicMethodWrapper_2 *)v17->fields._terrainStreamingManager_k__BackingField;
		    if ( terrainStreamingManager_k__BackingField )
		    {
		      terrainStreamingManager_k__BackingField->fields.virtualMachine = (VirtualMachine *)this->fields.atlasPageRootPathField;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&terrainStreamingManager_k__BackingField->fields, v16, v28, v29, P3);
		      goto LABEL_21;
		    }
		LABEL_4:
		    sub_1800D8260(terrainStreamingManager_k__BackingField, v16);
		  }
		  terrainStreamingManager_k__BackingField = IFix::WrappersManagerImpl::GetPatch(4056, 0LL);
		  if ( !terrainStreamingManager_k__BackingField )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1429(
		    terrainStreamingManager_k__BackingField,
		    (Object *)this,
		    layerTypeData,
		    (Object *)terrainCS,
		    (Object *)terrainRTCS,
		    (Object *)terrainPS,
		    (Object *)splatIndexMap,
		    splatTier,
		    enableHalfVTSize,
		    enableHalfAtlasSize,
		    mobileSplatControlFormat,
		    0LL);
		}
		
		public void Cleanup() {} // 0x0000000189C22F48-0x0000000189C23084
		// Void Cleanup()
		void HG::Rendering::Runtime::HGTerrainV2::Cleanup(HGTerrainV2 *this, MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v4; // rdx
		  HGTerrainStreamingManager *terrainStreamingManager_k__BackingField; // rcx
		  __int64 v6; // rdx
		  _OWORD *v7; // rax
		  _OWORD *v8; // rcx
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  HGManagerContext *v16; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  _BYTE v18[272]; // [rsp+20h] [rbp-228h] BYREF
		  _BYTE v19[280]; // [rsp+130h] [rbp-118h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4057, 0LL) )
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      terrainStreamingManager_k__BackingField = currentManagerContext->fields._terrainStreamingManager_k__BackingField;
		      if ( !terrainStreamingManager_k__BackingField )
		        goto LABEL_13;
		      HG::Rendering::Runtime::HGTerrainStreamingManager::Dispose(terrainStreamingManager_k__BackingField, 0LL);
		    }
		    UnityEngine::HyperGryph::HGTerrainManager::CleanupTerrainManager(0LL);
		    sub_18033B9D0(v18, 0LL, 272LL);
		    v6 = 2LL;
		    v7 = v19;
		    v8 = v18;
		    do
		    {
		      v9 = v8[1];
		      *v7 = *v8;
		      v10 = v8[2];
		      v7[1] = v9;
		      v11 = v8[3];
		      v7[2] = v10;
		      v12 = v8[4];
		      v7[3] = v11;
		      v13 = v8[5];
		      v7[4] = v12;
		      v14 = v8[6];
		      v7[5] = v13;
		      v15 = v8[7];
		      v8 += 8;
		      v7[6] = v14;
		      v7 += 8;
		      *(v7 - 1) = v15;
		      --v6;
		    }
		    while ( v6 );
		    *v7 = *v8;
		    sub_1837E2B90(v19);
		    if ( !HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
		      goto LABEL_11;
		    v16 = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( v16 )
		    {
		      terrainStreamingManager_k__BackingField = (HGTerrainStreamingManager *)v16->fields._subsurfaceProfileManager_k__BackingField;
		      if ( terrainStreamingManager_k__BackingField )
		      {
		        HG::Rendering::Runtime::SubsurfaceProfileManager::UnregisterFromTerrain(
		          (SubsurfaceProfileManager *)terrainStreamingManager_k__BackingField,
		          0LL);
		LABEL_11:
		        UnityEngine::HyperGryph::HGSubsurfaceProfileManager::UnregisterFromTerrain(0LL);
		        this->fields.m_phase0HasSetup = 0;
		        return;
		      }
		    }
		LABEL_13:
		    sub_1800D8260(terrainStreamingManager_k__BackingField, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4057, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		private static void UpdateLayerTypeData(ref TerrainLayerTypeData data) {} // 0x00000001837E2980-0x00000001837E2B50
		// Void UpdateLayerTypeData(TerrainLayerTypeData ByRef)
		void HG::Rendering::Runtime::HGTerrainV2::UpdateLayerTypeData(TerrainLayerTypeData *data, MethodInfo *method)
		{
		  __int64 v3; // rdi
		  _OWORD *v4; // rax
		  __int64 v5; // rcx
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  HGManagerContext *currentManagerContext; // rax
		  HGTerrainV2__StaticFields *static_fields; // rdx
		  SubsurfaceProfileManager *subsurfaceProfileManager_k__BackingField; // rcx
		  __int64 v17; // r8
		  _OWORD *v18; // rax
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  __int128 v26; // xmm1
		  HGTerrainV2__StaticFields *v27; // rcx
		  _OWORD *v28; // rax
		  __int128 v29; // xmm0
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  __int128 v32; // xmm1
		  __int128 v33; // xmm0
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  __int128 v36; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  _BYTE v38[64]; // [rsp+20h] [rbp-118h] BYREF
		  HGSubsurfaceProfile *profile; // [rsp+60h] [rbp-D8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4059, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4059, 0LL);
		    if ( !Patch )
		      goto LABEL_9;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1430(Patch, data, 0LL);
		  }
		  else
		  {
		    v3 = 2LL;
		    v4 = v38;
		    v5 = 2LL;
		    do
		    {
		      v4 += 8;
		      v6 = *(_OWORD *)&data->_glintData._EnableFakeGlint;
		      v7 = *(_OWORD *)&data->_glintData._GlintScale;
		      data = (TerrainLayerTypeData *)((char *)data + 128);
		      *(v4 - 8) = v6;
		      v8 = *(_OWORD *)&data[-1]._fakeVolumeData._Params._FakeRefractionHeightScale;
		      *(v4 - 7) = v7;
		      v9 = *(_OWORD *)&data[-1]._fakeVolumeData._Params._FakeDustDepth;
		      *(v4 - 6) = v8;
		      v10 = *(_OWORD *)&data[-1]._fakeVolumeData._Params._FakeDustFlowSpeed.w;
		      *(v4 - 5) = v9;
		      v11 = *(_OWORD *)&data[-1]._fakeVolumeData._Params._FakeDustTint.a;
		      *(v4 - 4) = v10;
		      v12 = *(_OWORD *)&data[-1]._fakeVolumeData._FakeVolumeMask;
		      *(v4 - 3) = v11;
		      v13 = *(_OWORD *)&data[-1]._fakeShadowData._FakeShadowStrength;
		      *(v4 - 2) = v12;
		      *(v4 - 1) = v13;
		      --v5;
		    }
		    while ( v5 );
		    *v4 = *(_OWORD *)&data->_glintData._EnableFakeGlint;
		    sub_1837E2B90(v38);
		    if ( HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL) )
		    {
		      currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		      if ( !currentManagerContext )
		        goto LABEL_9;
		      subsurfaceProfileManager_k__BackingField = currentManagerContext->fields._subsurfaceProfileManager_k__BackingField;
		      v17 = 2LL;
		      static_fields = TypeInfo::HG::Rendering::Runtime::HGTerrainV2->static_fields;
		      v18 = v38;
		      do
		      {
		        v18 += 8;
		        v19 = *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._glintData._EnableFakeGlint;
		        v20 = *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._glintData._GlintScale;
		        static_fields = (HGTerrainV2__StaticFields *)((char *)static_fields + 128);
		        *(v18 - 8) = v19;
		        v21 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeRefractionHeightScale;
		        *(v18 - 7) = v20;
		        v22 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustDepth;
		        *(v18 - 6) = v21;
		        v23 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustFlowSpeed.w;
		        *(v18 - 5) = v22;
		        v24 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustTint.a;
		        *(v18 - 4) = v23;
		        v25 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeVolumeData._FakeVolumeMask;
		        *(v18 - 3) = v24;
		        v26 = *(_OWORD *)&static_fields[-1]._LayerTypeData_k__BackingField._fakeShadowData._FakeShadowStrength;
		        *(v18 - 2) = v25;
		        *(v18 - 1) = v26;
		        --v17;
		      }
		      while ( v17 );
		      *v18 = *(_OWORD *)&static_fields->_LayerTypeData_k__BackingField._glintData._EnableFakeGlint;
		      if ( !subsurfaceProfileManager_k__BackingField )
		LABEL_9:
		        sub_1800D8260(subsurfaceProfileManager_k__BackingField, static_fields);
		      HG::Rendering::Runtime::SubsurfaceProfileManager::RegisterFromTerrain(
		        subsurfaceProfileManager_k__BackingField,
		        profile,
		        0LL);
		    }
		    v27 = TypeInfo::HG::Rendering::Runtime::HGTerrainV2->static_fields;
		    v28 = v38;
		    do
		    {
		      v28 += 8;
		      v29 = *(_OWORD *)&v27->_LayerTypeData_k__BackingField._glintData._EnableFakeGlint;
		      v30 = *(_OWORD *)&v27->_LayerTypeData_k__BackingField._glintData._GlintScale;
		      v27 = (HGTerrainV2__StaticFields *)((char *)v27 + 128);
		      *(v28 - 8) = v29;
		      v31 = *(_OWORD *)&v27[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeRefractionHeightScale;
		      *(v28 - 7) = v30;
		      v32 = *(_OWORD *)&v27[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustDepth;
		      *(v28 - 6) = v31;
		      v33 = *(_OWORD *)&v27[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustFlowSpeed.w;
		      *(v28 - 5) = v32;
		      v34 = *(_OWORD *)&v27[-1]._LayerTypeData_k__BackingField._fakeVolumeData._Params._FakeDustTint.a;
		      *(v28 - 4) = v33;
		      v35 = *(_OWORD *)&v27[-1]._LayerTypeData_k__BackingField._fakeVolumeData._FakeVolumeMask;
		      *(v28 - 3) = v34;
		      v36 = *(_OWORD *)&v27[-1]._LayerTypeData_k__BackingField._fakeShadowData._FakeShadowStrength;
		      *(v28 - 2) = v35;
		      *(v28 - 1) = v36;
		      --v3;
		    }
		    while ( v3 );
		    *v28 = *(_OWORD *)&v27->_LayerTypeData_k__BackingField._glintData._EnableFakeGlint;
		    UnityEngine::HyperGryph::HGSubsurfaceProfileManager::RegisterFromTerrain(profile, 0LL);
		  }
		}
		
		public static void GenerateConeMapMipmaps(ComputeShader cs, Texture2D[] coneMapTextures) {} // 0x0000000189C23084-0x0000000189C235A0
		// Void GenerateConeMapMipmaps(ComputeShader, Texture2D[])
		void HG::Rendering::Runtime::HGTerrainV2::GenerateConeMapMipmaps(
		        ComputeShader *cs,
		        Texture2D__Array *coneMapTextures,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  int32_t i; // esi
		  Object_1 *v8; // rdi
		  int v9; // r13d
		  int v10; // esi
		  int32_t anisoLevel; // r14d
		  FilterMode__Enum filterMode; // r12d
		  RenderTexture *v13; // rax
		  RenderTexture *v14; // rdi
		  CommandBuffer *v15; // r12
		  int32_t j; // r14d
		  Object_1 *v17; // rsi
		  int32_t v18; // r13d
		  RenderTargetIdentifier *v19; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  __int128 v22; // xmm1
		  __int64 v23; // xmm0_8
		  RenderTargetIdentifier *v24; // rax
		  __int128 v25; // xmm1
		  __int64 v26; // xmm0_8
		  RenderTargetIdentifier *v27; // rax
		  __int128 v28; // xmm7
		  __int128 v29; // xmm8
		  __int64 v30; // xmm6_8
		  RenderTargetIdentifier *v31; // rax
		  __int128 v32; // xmm1
		  Object *name; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  int32_t kernelIndex; // [rsp+78h] [rbp-90h]
		  int v36; // [rsp+7Ch] [rbp-8Ch]
		  int v37; // [rsp+80h] [rbp-88h]
		  Vector4 v38; // [rsp+88h] [rbp-80h]
		  RenderTargetIdentifier v39; // [rsp+98h] [rbp-70h] BYREF
		  RenderTargetIdentifier v40; // [rsp+C8h] [rbp-40h] BYREF
		  Vector4 v41; // [rsp+F8h] [rbp-10h] BYREF
		  int v42; // [rsp+180h] [rbp+78h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4060, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4060, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)cs,
		        (Object *)coneMapTextures,
		        0LL);
		      return;
		    }
		    goto LABEL_31;
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Object);
		  if ( UnityEngine::Object::op_Equality((Object_1 *)cs, 0LL, 0LL) || !coneMapTextures )
		    return;
		  for ( i = 0; ; ++i )
		  {
		    if ( i >= coneMapTextures->max_length.size )
		      return;
		    if ( (unsigned int)i >= coneMapTextures->max_length.size )
		LABEL_29:
		      sub_1800D2AB0(v6, v5);
		    v8 = (Object_1 *)coneMapTextures->vector[i];
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Inequality(v8, 0LL, 0LL) )
		      break;
		  }
		  if ( !v8 )
		    goto LABEL_31;
		  v37 = sub_180002F70(5LL, v8);
		  v9 = v37;
		  v10 = sub_180002F70(7LL, v8);
		  anisoLevel = UnityEngine::Texture::get_anisoLevel((Texture *)v8, 0LL);
		  filterMode = UnityEngine::Texture::get_filterMode((Texture *)v8, 0LL);
		  if ( !v37 )
		    return;
		  if ( !cs
		    || (kernelIndex = UnityEngine::ComputeShader::FindKernel(cs, (String *)"BuildSingleTextureMipmap", 0LL),
		        v13 = (RenderTexture *)sub_18002C620(TypeInfo::UnityEngine::RenderTexture),
		        (v14 = v13) == 0LL) )
		  {
		LABEL_31:
		    sub_1800D8260(v6, v5);
		  }
		  UnityEngine::RenderTexture::RenderTexture(v13, v37 >> 1, v10 >> 1, 0, GraphicsFormat__Enum_R8_UNorm, 0LL);
		  sub_180040340(10LL, v14, 2LL);
		  UnityEngine::RenderTexture::set_volumeDepth(v14, 1, 0LL);
		  UnityEngine::Texture::set_anisoLevel((Texture *)v14, anisoLevel, 0LL);
		  UnityEngine::Texture::set_filterMode((Texture *)v14, filterMode, 0LL);
		  UnityEngine::Texture::set_wrapMode((Texture *)v14, TextureWrapMode__Enum_Repeat, 0LL);
		  UnityEngine::RenderTexture::set_autoGenerateMips(v14, 0, 0LL);
		  UnityEngine::RenderTexture::set_useMipMap(v14, 0, 0LL);
		  UnityEngine::RenderTexture::set_enableRandomWrite(v14, 1, 0LL);
		  UnityEngine::Object::set_name((Object_1 *)v14, (String *)"HGTerrainConvertFunc.coneMapMipmapHelper", 0LL);
		  UnityEngine::RenderTexture::Create(v14, 0LL);
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::CommandBufferPool);
		  v15 = UnityEngine::Rendering::CommandBufferPool::Get(0LL);
		  for ( j = 0; j < coneMapTextures->max_length.size; ++j )
		  {
		    if ( (unsigned int)j >= coneMapTextures->max_length.size )
		      goto LABEL_29;
		    v17 = (Object_1 *)coneMapTextures->vector[j];
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( !UnityEngine::Object::op_Equality(v17, 0LL, 0LL) )
		    {
		      if ( !v17 )
		        goto LABEL_31;
		      if ( UnityEngine::Texture2D::get_format((Texture2D *)v17, 0LL) != TextureFormat__Enum_R8
		        || UnityEngine::Texture::get_isDataSRGB((Texture *)v17, 0LL) )
		      {
		        name = (Object *)UnityEngine::Object::get_name(v17, 0LL);
		        HG::Rendering::HGRPLogger::LogError<System::Object>(
		          (String *)"Terrain cone map {0} is SRGB or not R8 format, this should not happen",
		          name,
		          MethodInfo::HG::Rendering::HGRPLogger::LogError<System::String>);
		      }
		      else
		      {
		        v42 = 0;
		        while ( 1 )
		        {
		          v36 = v9;
		          if ( v42 >= UnityEngine::Texture::get_mipmapCount((Texture *)v17, 0LL) - 1 )
		            break;
		          v18 = v9 >> 1;
		          v19 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v40, (Texture *)v17, 0LL);
		          if ( !v15 )
		            sub_1800D8260(v21, v20);
		          v22 = *(_OWORD *)&v19->m_BufferPointer;
		          *(_OWORD *)&v39.m_Type = *(_OWORD *)&v19->m_Type;
		          v23 = *(_QWORD *)&v19->m_DepthSlice;
		          *(_OWORD *)&v39.m_BufferPointer = v22;
		          *(_QWORD *)&v39.m_DepthSlice = v23;
		          UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		            v15,
		            cs,
		            kernelIndex,
		            (String *)"_SrcMip",
		            &v39,
		            0LL);
		          v24 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v40, (Texture *)v14, 0LL);
		          v25 = *(_OWORD *)&v24->m_BufferPointer;
		          *(_OWORD *)&v39.m_Type = *(_OWORD *)&v24->m_Type;
		          v26 = *(_QWORD *)&v24->m_DepthSlice;
		          *(_OWORD *)&v39.m_BufferPointer = v25;
		          *(_QWORD *)&v39.m_DepthSlice = v26;
		          UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
		            v15,
		            cs,
		            kernelIndex,
		            (String *)"_TempDstMip",
		            &v39,
		            0,
		            0LL);
		          v38.w = 0.0;
		          v38.x = (float)v18;
		          *(_QWORD *)&v38.y = COERCE_UNSIGNED_INT((float)v42);
		          v41 = v38;
		          UnityEngine::Rendering::CommandBuffer::SetComputeVectorParam(v15, cs, (String *)"_DstMipSize", &v41, 0LL);
		          UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
		            v15,
		            cs,
		            kernelIndex,
		            (v18 + 7) / 8,
		            (v18 + 7) / 8,
		            1,
		            0LL);
		          v27 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v40, (Texture *)v14, 0LL);
		          v28 = *(_OWORD *)&v27->m_Type;
		          v29 = *(_OWORD *)&v27->m_BufferPointer;
		          v30 = *(_QWORD *)&v27->m_DepthSlice;
		          v31 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(&v40, (Texture *)v17, 0LL);
		          v32 = *(_OWORD *)&v31->m_BufferPointer;
		          *(_OWORD *)&v39.m_Type = *(_OWORD *)&v31->m_Type;
		          *(_QWORD *)&v39.m_DepthSlice = *(_QWORD *)&v31->m_DepthSlice;
		          *(_OWORD *)&v39.m_BufferPointer = v32;
		          *(_OWORD *)&v40.m_Type = v28;
		          *(_OWORD *)&v40.m_BufferPointer = v29;
		          *(_QWORD *)&v40.m_DepthSlice = v30;
		          UnityEngine::Rendering::CommandBuffer::CopyTexture(v15, &v40, 0, 0, 0, 0, v18, v18, &v39, 0, ++v42, 0, 0, 0LL);
		          v9 = v36 >> 1;
		        }
		        v9 = v37;
		      }
		    }
		  }
		  sub_1800036A0(TypeInfo::UnityEngine::Graphics);
		  UnityEngine::Graphics::ExecuteCommandBuffer(v15, 0LL);
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::CommandBufferPool);
		  UnityEngine::Rendering::CommandBufferPool::Release(v15, 0LL);
		  UnityEngine::RenderTexture::Release(v14, 0LL);
		}
		
	}
}
