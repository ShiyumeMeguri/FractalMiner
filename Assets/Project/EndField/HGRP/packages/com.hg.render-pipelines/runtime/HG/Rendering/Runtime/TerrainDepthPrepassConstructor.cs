using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class TerrainDepthPrepassConstructor : IPassConstructor // TypeDefIndex: 38453
	{
		// Fields
		private static readonly RenderFunc<TerrainSubdivisionData> s_terrainSubdivisionFunc; // 0x00
		private static readonly RenderFunc<TerrainDepthPrepassData> s_terrainDepthPrepassRenderFunc; // 0x08
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38448
		{
			// Fields
			internal TextureHandle sceneDepth; // 0x00
			internal CullingResults cullingResults; // 0x10
			internal PerObjectData bakedLightingConfig; // 0x20
			internal bool enableTerrainTessellation; // 0x24
			internal bool enableTerrainSubdivision; // 0x25
			internal bool enableTerrainSubdivisionV2; // 0x26
			internal int terrainSubdMode; // 0x28
			internal int terrainSubdModeV2; // 0x2C
			internal int terrainGpuSubd; // 0x30
			internal int terrainPrimitivePixelLengthTargetLog2; // 0x34
			internal TextureHandle HZBTexture; // 0x38
		}
	
		internal struct PassOutput // TypeDefIndex: 38449
		{
			// Fields
			public TextureHandle terrainDepthBuffer; // 0x00
		}
	
		public class TerrainSubdivisionData // TypeDefIndex: 38450
		{
			// Fields
			public int subdivisionHandle; // 0x10
			public uint terrainCullViewHandle; // 0x14
			public uint editorTerrainCullViewHandle; // 0x18
			public bool enableTerrainTessellation; // 0x1C
			public bool enableTerrainSubdivision; // 0x1D
			public bool enableTerrainSubdivisionV2; // 0x1E
			public int terrainSubdMode; // 0x20
			public int terrainSubdModeV2; // 0x24
			public int terrainGpuSubd; // 0x28
			public int terrainPrimitivePixelLengthTargetLog2; // 0x2C
			public TextureHandle HZBTexture; // 0x30
	
			// Constructors
			public TerrainSubdivisionData() {} // 0x0000000189BD5E1C-0x0000000189BD5E54
			// TerrainDepthPrepassConstructor+TerrainSubdivisionData()
			void HG::Rendering::Runtime::TerrainDepthPrepassConstructor::TerrainSubdivisionData::TerrainSubdivisionData(
			        TerrainDepthPrepassConstructor_TerrainSubdivisionData *this,
			        MethodInfo *method)
			{
			  TextureHandle v3; // [rsp+20h] [rbp-18h] BYREF
			
			  if ( !TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle->_1.cctor_finished_or_no_cctor )
			    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			  this->fields.HZBTexture = *HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle(&v3, 0LL);
			}
			
		}
	
		public class TerrainDepthPrepassData // TypeDefIndex: 38451
		{
			// Fields
			public int subdivisionHandle; // 0x10
			public uint terrainCullViewHandle; // 0x14
			public uint editorTerrainCullViewHandle; // 0x18
			public bool enableTerrainTessellation; // 0x1C
			public bool enableTerrainSubdivision; // 0x1D
			public bool enableTerrainSubdivisionV2; // 0x1E
			public TextureHandle terrainDepthBuffer; // 0x20
	
			// Constructors
			public TerrainDepthPrepassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public TerrainDepthPrepassConstructor() {} // Dummy constructor
		internal TerrainDepthPrepassConstructor(HGRenderPathBase.HGRenderPathResources resources) {} // 0x00000001841E1670-0x00000001841E1680
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
		
		static TerrainDepthPrepassConstructor() {} // 0x0000000184CB3D40-0x0000000184CB3E40
		// TerrainDepthPrepassConstructor()
		void HG::Rendering::Runtime::TerrainDepthPrepassConstructor::cctor(MethodInfo *method)
		{
		  struct TerrainDepthPrepassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGRuntimeGrassQuery_Node__Class *v6; // rbx
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  Object *v10; // rdi
		  RenderFunc_1_System_Object_ *v11; // rax
		  MonitorData *v12; // rbx
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  MethodInfo *v16; // [rsp+20h] [rbp-8h]
		  MethodInfo *v17; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::TerrainDepthPrepassConstructor::TerrainSubdivisionData>);
		  v6 = (HGRuntimeGrassQuery_Node__Class *)v3;
		  if ( !v3
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v3,
		          v2,
		          MethodInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor::__c::__cctor_b__12_0,
		          0LL),
		        static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor->static_fields,
		        static_fields->klass = v6,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor->static_fields,
		          static_fields,
		          v8,
		          v9,
		          v16),
		        v10 = (Object *)TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor::__c->static_fields->__9,
		        v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::TerrainDepthPrepassConstructor::TerrainDepthPrepassData>),
		        (v12 = (MonitorData *)v11) == 0LL) )
		  {
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v11,
		    v10,
		    MethodInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor::__c::__cctor_b__12_1,
		    0LL);
		  v13 = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor->static_fields;
		  v13->monitor = v12;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor->static_fields->s_terrainDepthPrepassRenderFunc,
		    v13,
		    v14,
		    v15,
		    v17);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BD5DC8-0x0000000189BD5E1C
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::TerrainDepthPrepassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        TerrainDepthPrepassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3424, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3424, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BD5D74-0x0000000189BD5DC8
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::TerrainDepthPrepassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        TerrainDepthPrepassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3425, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3425, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BD56F0-0x0000000189BD5D20
		// Void ConstructPass(TerrainDepthPrepassConstructor+PassInput ByRef, TerrainDepthPrepassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=2
		void HG::Rendering::Runtime::TerrainDepthPrepassConstructor::ConstructPass(
		        TerrainDepthPrepassConstructor *this,
		        TerrainDepthPrepassConstructor_PassInput *input,
		        TerrainDepthPrepassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  Object *v6; // r15
		  TerrainDepthPrepassConstructor_PassOutput *v7; // r13
		  TerrainDepthPrepassConstructor_PassInput *v8; // rsi
		  ProfilingSampler *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  HGCamera *v15; // r14
		  __int64 subdivisionHandle; // rcx
		  __int64 terrainCullViewHandle; // rcx
		  __int64 editorTerrainCullViewHandle; // rcx
		  __int64 terrainSubdMode; // rcx
		  __int64 terrainSubdModeV2; // rcx
		  __int64 terrainGpuSubd; // rcx
		  __int64 terrainPrimitivePixelLengthTargetLog2; // rcx
		  Object *v23; // rbx
		  TextureHandle *nullHandle; // rax
		  __int64 v25; // rdx
		  __int64 v26; // rcx
		  ProfilingSampler *v27; // rax
		  __int64 v28; // rdx
		  __int64 v29; // rcx
		  __int64 v30; // rdx
		  __int64 v31; // rcx
		  Object *v32; // r12
		  Vector2Int sceneRTSize_k__BackingField; // rbx
		  __int64 v34; // rdx
		  __int64 v35; // rcx
		  TextureHandle v36; // xmm0
		  TextureHandle *v37; // r8
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  __int64 v40; // rcx
		  __int64 v41; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v43; // rdx
		  __int64 v44; // rcx
		  Object *v45; // [rsp+50h] [rbp-C8h] BYREF
		  Object *v46; // [rsp+58h] [rbp-C0h] BYREF
		  Il2CppException *ex; // [rsp+60h] [rbp-B8h] BYREF
		  HGRenderGraphBuilder *v48; // [rsp+68h] [rbp-B0h]
		  __m128i si128; // [rsp+70h] [rbp-A8h] BYREF
		  HGRenderGraphBuilder v50; // [rsp+80h] [rbp-98h] BYREF
		  HGRenderGraphBuilder v51; // [rsp+A0h] [rbp-78h] BYREF
		  HGRenderGraphBuilder v52; // [rsp+C0h] [rbp-58h] BYREF
		  Il2CppExceptionWrapper *v53; // [rsp+E0h] [rbp-38h] BYREF
		  Il2CppExceptionWrapper *v54; // [rsp+E8h] [rbp-30h] BYREF
		
		  v6 = (Object *)renderGraph;
		  v7 = output;
		  v8 = input;
		  v45 = 0LL;
		  v46 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(3426, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3426, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v44, v43);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1238(Patch, (Object *)this, v8, v7, v6, (Object *)camera, 0LL);
		  }
		  else
		  {
		    v10 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x12u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !v6 )
		      sub_1800D8260(v12, v11);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v50,
		      (HGRenderGraph *)v6,
		      (String *)"TerrainSubdivision",
		      &v45,
		      v10,
		      1,
		      ProfilingHGPass__Enum_PreDepth,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TerrainDepthPrepassConstructor::TerrainSubdivisionData>);
		    v52 = v50;
		    ex = 0LL;
		    v48 = &v52;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v52, 0, 0LL);
		      v15 = camera;
		      if ( !camera )
		        sub_1800D8250(v14, v13);
		      subdivisionHandle = (unsigned int)camera->fields.subdivisionHandle;
		      if ( !v45 )
		        sub_1800D8250(subdivisionHandle, v13);
		      LODWORD(v45[1].klass) = subdivisionHandle;
		      terrainCullViewHandle = camera->fields.terrainCullViewHandle;
		      if ( !v45 )
		        sub_1800D8250(terrainCullViewHandle, v13);
		      HIDWORD(v45[1].klass) = terrainCullViewHandle;
		      editorTerrainCullViewHandle = camera->fields.editorTerrainCullViewHandle;
		      if ( !v45 )
		        sub_1800D8250(editorTerrainCullViewHandle, v13);
		      LODWORD(v45[1].monitor) = editorTerrainCullViewHandle;
		      LOBYTE(editorTerrainCullViewHandle) = v8->enableTerrainTessellation;
		      if ( !v45 )
		        sub_1800D8250(editorTerrainCullViewHandle, v13);
		      BYTE4(v45[1].monitor) = editorTerrainCullViewHandle;
		      LOBYTE(editorTerrainCullViewHandle) = v8->enableTerrainSubdivision;
		      if ( !v45 )
		        sub_1800D8250(editorTerrainCullViewHandle, v13);
		      BYTE5(v45[1].monitor) = editorTerrainCullViewHandle;
		      LOBYTE(editorTerrainCullViewHandle) = v8->enableTerrainSubdivisionV2;
		      if ( !v45 )
		        sub_1800D8250(editorTerrainCullViewHandle, v13);
		      BYTE6(v45[1].monitor) = editorTerrainCullViewHandle;
		      terrainSubdMode = (unsigned int)v8->terrainSubdMode;
		      if ( !v45 )
		        sub_1800D8250(terrainSubdMode, v13);
		      LODWORD(v45[2].klass) = terrainSubdMode;
		      terrainSubdModeV2 = (unsigned int)v8->terrainSubdModeV2;
		      if ( !v45 )
		        sub_1800D8250(terrainSubdModeV2, v13);
		      HIDWORD(v45[2].klass) = terrainSubdModeV2;
		      terrainGpuSubd = (unsigned int)v8->terrainGpuSubd;
		      if ( !v45 )
		        sub_1800D8250(terrainGpuSubd, v13);
		      LODWORD(v45[2].monitor) = terrainGpuSubd;
		      terrainPrimitivePixelLengthTargetLog2 = (unsigned int)v8->terrainPrimitivePixelLengthTargetLog2;
		      if ( !v45 )
		        sub_1800D8250(terrainPrimitivePixelLengthTargetLog2, v13);
		      HIDWORD(v45[2].monitor) = terrainPrimitivePixelLengthTargetLog2;
		      v23 = v45;
		      sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		      if ( HG::Rendering::RenderGraphModule::TextureHandle::IsValid(&v8->HZBTexture, 0LL) )
		      {
		        nullHandle = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::ReadTexture(
		                       (TextureHandle *)&si128,
		                       &v52,
		                       &v8->HZBTexture,
		                       0LL);
		      }
		      else
		      {
		        sub_1800036A0(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
		        nullHandle = HG::Rendering::RenderGraphModule::TextureHandle::get_nullHandle((TextureHandle *)&si128, 0LL);
		      }
		      if ( !v23 )
		        sub_1800D8250(v26, v25);
		      v23[3] = *(Object *)nullHandle;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v52,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor->static_fields->s_terrainSubdivisionFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TerrainDepthPrepassConstructor::TerrainSubdivisionData>);
		    }
		    catch ( Il2CppExceptionWrapper *v53 )
		    {
		      ex = v53->ex;
		      sub_180268AE0(&ex);
		      v15 = camera;
		      v6 = (Object *)renderGraph;
		      v7 = output;
		      v8 = input;
		      goto LABEL_21;
		    }
		    sub_180268AE0(&ex);
		LABEL_21:
		    v27 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x13u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !v6 )
		      sub_1800D8250(v29, v28);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v50,
		      (HGRenderGraph *)v6,
		      (String *)"TerrainDepthPrepass",
		      &v46,
		      v27,
		      1,
		      ProfilingHGPass__Enum_PreDepth,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::TerrainDepthPrepassConstructor::TerrainDepthPrepassData>);
		    v51 = v50;
		    ex = 0LL;
		    v48 = &v51;
		    try
		    {
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v51, 0, 0LL);
		      v32 = v46;
		      if ( !v15 )
		        sub_1800D8250(v31, v30);
		      sceneRTSize_k__BackingField = v15->fields._sceneRTSize_k__BackingField;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGRenderPipeline);
		      v36 = *HG::Rendering::Runtime::HGRenderPipeline::CreateDepthBuffer(
		               (TextureHandle *)&si128,
		               (HGRenderGraph *)v6,
		               sceneRTSize_k__BackingField,
		               0LL);
		      if ( !v32 )
		        sub_1800D8250(v35, v34);
		      v32[2] = (Object)v36;
		      v37 = (TextureHandle *)v46;
		      if ( !v46 )
		        sub_1800D8250(v35, v34);
		      *v7 = (TerrainDepthPrepassConstructor_PassOutput)v46[2];
		      si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetColorAttachment(
		        (TextureHandle *)&v50,
		        &v51,
		        v37 + 2,
		        0,
		        RenderBufferLoadAction__Enum_Clear,
		        RenderBufferStoreAction__Enum_Store,
		        (Color *)&si128,
		        0,
		        0LL);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetDepthAttachment(
		        (TextureHandle *)&v50,
		        &v51,
		        &v8->sceneDepth,
		        DepthAccess__Enum_Write,
		        0,
		        0LL);
		      v39 = (unsigned int)v15->fields.subdivisionHandle;
		      if ( !v46 )
		        sub_1800D8250(v39, v38);
		      LODWORD(v46[1].klass) = v39;
		      v40 = v15->fields.terrainCullViewHandle;
		      if ( !v46 )
		        sub_1800D8250(v40, v38);
		      HIDWORD(v46[1].klass) = v40;
		      v41 = v15->fields.editorTerrainCullViewHandle;
		      if ( !v46 )
		        sub_1800D8250(v41, v38);
		      LODWORD(v46[1].monitor) = v41;
		      LOBYTE(v41) = v8->enableTerrainTessellation;
		      if ( !v46 )
		        sub_1800D8250(v41, v38);
		      BYTE4(v46[1].monitor) = v41;
		      LOBYTE(v41) = v8->enableTerrainSubdivision;
		      if ( !v46 )
		        sub_1800D8250(v41, v38);
		      BYTE5(v46[1].monitor) = v41;
		      LOBYTE(v41) = v8->enableTerrainSubdivisionV2;
		      if ( !v46 )
		        sub_1800D8250(v41, v38);
		      BYTE6(v46[1].monitor) = v41;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v51,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::TerrainDepthPrepassConstructor->static_fields->s_terrainDepthPrepassRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::TerrainDepthPrepassConstructor::TerrainDepthPrepassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v54 )
		    {
		      ex = v54->ex;
		      sub_180268AE0(&ex);
		      return;
		    }
		    sub_180268AE0(&ex);
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BD5D20-0x0000000189BD5D74
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::TerrainDepthPrepassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        TerrainDepthPrepassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3427, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3427, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D7FDE0-0x0000000184D7FE10
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::TerrainDepthPrepassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        TerrainDepthPrepassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3428, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3428, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		}
		
	}
}
