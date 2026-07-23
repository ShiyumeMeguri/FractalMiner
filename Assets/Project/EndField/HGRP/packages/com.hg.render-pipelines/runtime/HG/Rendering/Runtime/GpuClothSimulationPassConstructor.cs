using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class GpuClothSimulationPassConstructor : IPassConstructor // TypeDefIndex: 38301
	{
		// Fields
		private int m_clothSingleDispatchHandle; // 0x10
		private int m_clothDataUploadHandle; // 0x14
		private int m_clothDataClearHandle; // 0x18
		private ComputeShader m_clothSingleDispatchCS; // 0x20
		private ComputeShader m_clothDataUploadCS; // 0x28
		private static int CLOTH_CONST_BUFFER_SIZE; // 0x00
		private static int CLOTH_UPLOAD_CONST_BUFFER_SIZE; // 0x04
		private static readonly RenderFunc<ClearPassData> s_clearFunc; // 0x08
		private static readonly RenderFunc<UploadPassData> s_uploadFunc; // 0x10
		private static readonly RenderFunc<PassData> s_dispatchFunc; // 0x18
		private static readonly RenderFunc<PassData> s_setDefaultFunc; // 0x20
	
		// Nested types
		internal struct PassInput // TypeDefIndex: 38295
		{
		}
	
		internal struct PassOutput // TypeDefIndex: 38296
		{
		}
	
		private class ClearPassData // TypeDefIndex: 38297
		{
			// Fields
			public int clothClearCSHandle; // 0x10
			public ComputeShader clearCS; // 0x18
			public IVec4 eleNum; // 0x20
			public uint clothNodeDataBufferID; // 0x30
			public uint clothBatchMetaDataBufferID; // 0x34
			public uint clothBatchCacheMapBufferID; // 0x38
	
			// Constructors
			public ClearPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		private class UploadPassData // TypeDefIndex: 38298
		{
			// Fields
			public int clothUploadCSHandle; // 0x10
			public ComputeShader clothUploadCS; // 0x18
			public IVec4 uploadConstData; // 0x20
			public int clothMetaUploadDataNum; // 0x30
			public unsafe ClothMetaDataCPP* clothMetaUploadData; // 0x38
			public int uploadDataMapNum; // 0x40
			public unsafe ClothGroupUploadDataMapCPP* uploadDataMap; // 0x48
			public int clothNodeUploadDataNum; // 0x50
			public unsafe ClothNodeDataCPP* clothNodeUploadData; // 0x58
			public int clothBatchMetaUploadDataNum; // 0x60
			public unsafe IVec4* clothBatchMetaUploadData; // 0x68
			public int clothBatchCacheMapUploadDataNum; // 0x70
			public unsafe IVec4* clothBatchCacheMapUploadData; // 0x78
			public uint clothMetaDataBufferID; // 0x80
			public uint clothNodeDataBufferID; // 0x84
			public uint clothBatchMetaDataBufferID; // 0x88
			public uint clothBatchCacheMapBufferID; // 0x8C
			public uint clothSkeletonDataBufferID; // 0x90
	
			// Constructors
			public UploadPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
	
		private class PassData // TypeDefIndex: 38299
		{
			// Fields
			public int clothNum; // 0x10
			public ClothConstDataCPP clothConstData; // 0x14
			public int clothSingleDispatchCSHandle; // 0xF4
			public ComputeShader clothSingleDispatchCS; // 0xF8
			public uint clothNodeDataBufferID; // 0x100
			public uint clothMetaDataBufferID; // 0x104
			public uint clothBatchMetaDataBufferID; // 0x108
			public uint clothBatchCacheMapBufferID; // 0x10C
			public uint clothSkeletonDataBufferID; // 0x110
	
			// Constructors
			public PassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public GpuClothSimulationPassConstructor() {} // Dummy constructor
		internal GpuClothSimulationPassConstructor(HGRenderPathBase.HGRenderPathResources resources) {} // 0x000000018454A730-0x000000018454A7F0
		// GpuClothSimulationPassConstructor(HGRenderPathBase+HGRenderPathResources)
		void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::GpuClothSimulationPassConstructor(
		        GpuClothSimulationPassConstructor *this,
		        HGRenderPathBase_HGRenderPathResources *resources,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  GpuClothSimulationPassConstructor *v5; // rbx
		  HGRenderPipelineRuntimeResources_ShaderResources *shaders; // rax
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  HGRenderPipelineRuntimeResources_ShaderResources *v9; // rax
		  int32_t Kernel; // eax
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		  MethodInfo *v12; // [rsp+20h] [rbp-8h]
		
		  v5 = this;
		  if ( !resources->defaultResources )
		    goto LABEL_2;
		  shaders = resources->defaultResources->fields.shaders;
		  if ( !shaders )
		    goto LABEL_2;
		  this->fields.m_clothSingleDispatchCS = shaders->fields.clothSingleDispatchCS;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->fields.m_clothSingleDispatchCS,
		    (Type *)resources,
		    (PropertyInfo_1 *)method,
		    v3,
		    v11);
		  this = (GpuClothSimulationPassConstructor *)v5->fields.m_clothSingleDispatchCS;
		  if ( !this )
		    goto LABEL_2;
		  v5->fields.m_clothSingleDispatchHandle = UnityEngine::ComputeShader::FindKernel(
		                                             (ComputeShader *)this,
		                                             (String *)"ClothSimMain",
		                                             0LL);
		  if ( !resources->defaultResources
		    || (v9 = resources->defaultResources->fields.shaders) == 0LL
		    || (v5->fields.m_clothDataUploadCS = v9->fields.clothDataUploadCS,
		        sub_18002D1B0((SingleFieldAccessor *)&v5->fields.m_clothDataUploadCS, (Type *)resources, v7, v8, v12),
		        (this = (GpuClothSimulationPassConstructor *)v5->fields.m_clothDataUploadCS) == 0LL)
		    || (Kernel = UnityEngine::ComputeShader::FindKernel((ComputeShader *)this, (String *)"ClothDataUploadMain", 0LL),
		        this = (GpuClothSimulationPassConstructor *)v5->fields.m_clothDataUploadCS,
		        v5->fields.m_clothDataUploadHandle = Kernel,
		        !this) )
		  {
		LABEL_2:
		    sub_1800D8260(this, resources);
		  }
		  v5->fields.m_clothDataClearHandle = UnityEngine::ComputeShader::FindKernel(
		                                        (ComputeShader *)this,
		                                        (String *)"ClothDataClearMain",
		                                        0LL);
		}
		
		static GpuClothSimulationPassConstructor() {} // 0x0000000184A1FC60-0x0000000184A1FE50
		// GpuClothSimulationPassConstructor()
		void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::cctor(MethodInfo *method)
		{
		  struct GpuClothSimulationPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  MonitorData *v6; // rbx
		  Type *static_fields; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  Object *v10; // rdi
		  RenderFunc_1_System_Object_ *v11; // rax
		  RenderFunc_1_System_Object_ *v12; // rbx
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Int32__Array **v15; // r9
		  Object *v16; // rdi
		  RenderFunc_1_System_Object_ *v17; // rax
		  Type__Class *v18; // rbx
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  Object *v22; // rdi
		  RenderFunc_1_System_Object_ *v23; // rax
		  MonitorData *v24; // rbx
		  Type *v25; // rdx
		  PropertyInfo_1 *v26; // r8
		  Int32__Array **v27; // r9
		  MethodInfo *v28; // [rsp+20h] [rbp-8h]
		  MethodInfo *v29; // [rsp+20h] [rbp-8h]
		  MethodInfo *v30; // [rsp+20h] [rbp-8h]
		  MethodInfo *v31; // [rsp+50h] [rbp+28h]
		
		  TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor->static_fields->CLOTH_CONST_BUFFER_SIZE = 224;
		  TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor->static_fields->CLOTH_UPLOAD_CONST_BUFFER_SIZE = 16;
		  v1 = TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::ClearPassData>);
		  v6 = (MonitorData *)v3;
		  if ( !v3 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor::__c::__cctor_b__27_0,
		    0LL);
		  static_fields = (Type *)TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor->static_fields;
		  static_fields->monitor = v6;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor->static_fields->s_clearFunc,
		    static_fields,
		    v8,
		    v9,
		    v28);
		  v10 = (Object *)TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor::__c->static_fields->__9;
		  v11 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::UploadPassData>);
		  v12 = v11;
		  if ( !v11 )
		    goto LABEL_4;
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v11,
		    v10,
		    MethodInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor::__c::__cctor_b__27_1,
		    0LL);
		  v13 = (Type *)TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor->static_fields;
		  v13->fields._impl.value = v12;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor->static_fields->s_uploadFunc,
		    v13,
		    v14,
		    v15,
		    v29);
		  v16 = (Object *)TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor::__c->static_fields->__9;
		  v17 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::PassData>);
		  v18 = (Type__Class *)v17;
		  if ( !v17
		    || (HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		          v17,
		          v16,
		          MethodInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor::__c::__cctor_b__27_2,
		          0LL),
		        v19 = (Type *)TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor->static_fields,
		        v19[1].klass = v18,
		        sub_18002D1B0(
		          (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor->static_fields->s_dispatchFunc,
		          v19,
		          v20,
		          v21,
		          v30),
		        v22 = (Object *)TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor::__c->static_fields->__9,
		        v23 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::PassData>),
		        (v24 = (MonitorData *)v23) == 0LL) )
		  {
		LABEL_4:
		    sub_1800D8260(v5, v4);
		  }
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v23,
		    v22,
		    MethodInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor::__c::__cctor_b__27_3,
		    0LL);
		  v25 = (Type *)TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor->static_fields;
		  v25[1].monitor = v24;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor->static_fields->s_setDefaultFunc,
		    v25,
		    v26,
		    v27,
		    v31);
		}
		
	
		// Methods
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189BB2598-0x0000000189BB2660
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        GpuClothSimulationPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  int v5; // xmm6_4
		  int v6; // xmm0_4
		  int v7; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int128 v11; // [rsp+20h] [rbp-28h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3192, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3192, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		  else
		  {
		    v5 = 1065353216;
		    if ( UnityEngine::HyperGryph::HGGpuClothManagerV2::IsClothSkeletonValid(0LL) )
		      v6 = 1065353216;
		    else
		      v6 = 0;
		    LODWORD(v11) = v6;
		    if ( UnityEngine::HyperGryph::HGGpuClothManagerV2::IsClothSkeletonFlipped(0LL) )
		      v7 = 1065353216;
		    else
		      v7 = 0;
		    DWORD1(v11) = v7;
		    if ( !UnityEngine::HyperGryph::HGGpuClothManagerV2::ShouldStep(0LL) )
		      v5 = 0;
		    *((_QWORD *)&v11 + 1) = __PAIR64__(COERCE_UNSIGNED_INT(UnityEngine::Time::get_time(0LL)), v5);
		    *(_OWORD *)&shaderVariablesGlobal[1]._LastWindGlobalParams0.z = v11;
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189BB2544-0x0000000189BB2598
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        GpuClothSimulationPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3193, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3193, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189BB1C48-0x0000000189BB24D0
		// Void ConstructPass(GpuClothSimulationPassConstructor+PassInput ByRef, GpuClothSimulationPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=4
		void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::ConstructPass(
		        GpuClothSimulationPassConstructor *this,
		        GpuClothSimulationPassConstructor_PassInput *input,
		        GpuClothSimulationPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  HGRenderGraph *v6; // rdi
		  GpuClothSimulationPassConstructor *v9; // rsi
		  GpuClothClearBufferDataCPP *ClearBufferData_CSharpWrapper; // rax
		  int32_t w; // r12d
		  GpuClothGroupUploadDataCPP *UploadData_CSharpWrapper; // rax
		  GpuClothRenderDataCPP *RenderData_CSharpWrapper; // rax
		  ProfilingSampler *v14; // rax
		  __int64 v15; // rdx
		  __int64 v16; // rcx
		  __m128i v17; // xmm0
		  ProfilingSampler *v18; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  ProfilingSampler *v21; // rax
		  uint32_t SkeletonBufferID; // esi
		  ProfilingSampler *v23; // rax
		  __int64 v24; // rdx
		  __int64 v25; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v27; // rdx
		  __int64 v28; // rcx
		  __m128i v29; // [rsp+40h] [rbp-3F8h] BYREF
		  HGRenderGraphBuilder v30; // [rsp+50h] [rbp-3E8h] BYREF
		  Object *v31; // [rsp+70h] [rbp-3C8h] BYREF
		  Object *v32; // [rsp+78h] [rbp-3C0h] BYREF
		  Object *v33; // [rsp+80h] [rbp-3B8h] BYREF
		  Object *v34; // [rsp+88h] [rbp-3B0h] BYREF
		  HGRenderGraphBuilder v35; // [rsp+90h] [rbp-3A8h] BYREF
		  HGRenderGraphBuilder v36; // [rsp+B0h] [rbp-388h] BYREF
		  GpuClothGroupUploadDataCPP v37; // [rsp+D0h] [rbp-368h] BYREF
		  __int128 v38; // [rsp+120h] [rbp-318h]
		  __int128 v39; // [rsp+130h] [rbp-308h]
		  __int128 v40; // [rsp+140h] [rbp-2F8h]
		  HGRenderGraphBuilder v41; // [rsp+150h] [rbp-2E8h] BYREF
		  HGRenderGraphBuilder v42; // [rsp+170h] [rbp-2C8h] BYREF
		  HGRenderGraphBuilder v43; // [rsp+190h] [rbp-2A8h] BYREF
		  HGRenderGraphBuilder v44; // [rsp+1B0h] [rbp-288h] BYREF
		  Il2CppExceptionWrapper *v45; // [rsp+1D0h] [rbp-268h] BYREF
		  Il2CppExceptionWrapper *v46; // [rsp+1D8h] [rbp-260h] BYREF
		  Il2CppExceptionWrapper *v47; // [rsp+1E0h] [rbp-258h] BYREF
		  Il2CppExceptionWrapper *v48; // [rsp+1E8h] [rbp-250h] BYREF
		  GpuClothGroupUploadDataCPP v49; // [rsp+1F0h] [rbp-248h] BYREF
		  __int128 v50; // [rsp+240h] [rbp-1F8h]
		  __int128 v51; // [rsp+250h] [rbp-1E8h]
		  __int128 v52; // [rsp+260h] [rbp-1D8h]
		  __int128 v53; // [rsp+270h] [rbp-1C8h]
		  __int128 v54; // [rsp+280h] [rbp-1B8h]
		  __int128 v55; // [rsp+290h] [rbp-1A8h]
		  Vector4 packedDeltaT; // [rsp+2A0h] [rbp-198h]
		  Vector4 clothParam1; // [rsp+2B0h] [rbp-188h]
		  __int128 v58; // [rsp+2C0h] [rbp-178h]
		  __int128 v59; // [rsp+2D0h] [rbp-168h]
		  __int128 v60; // [rsp+2E0h] [rbp-158h]
		  __int128 v61; // [rsp+2F0h] [rbp-148h]
		  __int128 v62; // [rsp+300h] [rbp-138h]
		  __int128 v63; // [rsp+310h] [rbp-128h]
		  __int64 v64; // [rsp+320h] [rbp-118h]
		  _OWORD v65[14]; // [rsp+330h] [rbp-108h] BYREF
		  __int64 v66; // [rsp+410h] [rbp-28h]
		
		  v6 = renderGraph;
		  v9 = this;
		  memset(&v41, 0, sizeof(v41));
		  v31 = 0LL;
		  memset(&v42, 0, sizeof(v42));
		  v32 = 0LL;
		  memset(&v43, 0, sizeof(v43));
		  v33 = 0LL;
		  v34 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(3194, 0LL) )
		  {
		    ClearBufferData_CSharpWrapper = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClearBufferData_CSharpWrapper(
		                                      (GpuClothClearBufferDataCPP *)&v35,
		                                      0LL);
		    *(_OWORD *)&v36.m_RenderPass = *(_OWORD *)&ClearBufferData_CSharpWrapper->shouldClear;
		    w = ClearBufferData_CSharpWrapper->eleNum.w;
		    UploadData_CSharpWrapper = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetUploadData_CSharpWrapper(&v49, 0LL);
		    v29 = *(__m128i *)&UploadData_CSharpWrapper->isValid;
		    *(__m128i *)&v37.isValid = v29;
		    v38 = *(_OWORD *)&UploadData_CSharpWrapper->clothMetaUploadDataNum;
		    *(_OWORD *)&v37.clothMetaUploadDataNum = v38;
		    v39 = *(_OWORD *)&UploadData_CSharpWrapper->clothNodeUploadDataNum;
		    *(_OWORD *)&v37.clothNodeUploadDataNum = v39;
		    v40 = *(_OWORD *)&UploadData_CSharpWrapper->clothBatchMetaUploadDataNum;
		    *(_OWORD *)&v37.clothBatchMetaUploadDataNum = v40;
		    *(_OWORD *)&v35.m_RenderPass = *(_OWORD *)&UploadData_CSharpWrapper->clothBatchCacheMapUploadDataNum;
		    *(_OWORD *)&v37.clothBatchCacheMapUploadDataNum = *(_OWORD *)&v35.m_RenderPass;
		    RenderData_CSharpWrapper = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetRenderData_CSharpWrapper(
		                                 (GpuClothRenderDataCPP *)v65,
		                                 0LL);
		    v50 = *(_OWORD *)&RenderData_CSharpWrapper->isValid;
		    v51 = *(_OWORD *)&RenderData_CSharpWrapper->clothConstData.packedDeltaT.z;
		    v52 = *(_OWORD *)&RenderData_CSharpWrapper->clothConstData.clothParam1.z;
		    v53 = *(_OWORD *)&RenderData_CSharpWrapper[1].clothNum;
		    v54 = *(_OWORD *)&RenderData_CSharpWrapper[1].clothConstData.packedDeltaT.w;
		    v55 = *(_OWORD *)&RenderData_CSharpWrapper[1].clothConstData.clothParam1.w;
		    packedDeltaT = RenderData_CSharpWrapper[2].clothConstData.packedDeltaT;
		    clothParam1 = RenderData_CSharpWrapper[2].clothConstData.clothParam1;
		    RenderData_CSharpWrapper = (GpuClothRenderDataCPP *)((char *)RenderData_CSharpWrapper + 128);
		    v58 = *(_OWORD *)&RenderData_CSharpWrapper->isValid;
		    v59 = *(_OWORD *)&RenderData_CSharpWrapper->clothConstData.packedDeltaT.z;
		    v60 = *(_OWORD *)&RenderData_CSharpWrapper->clothConstData.clothParam1.z;
		    v61 = *(_OWORD *)&RenderData_CSharpWrapper[1].clothNum;
		    v62 = *(_OWORD *)&RenderData_CSharpWrapper[1].clothConstData.packedDeltaT.w;
		    v63 = *(_OWORD *)&RenderData_CSharpWrapper[1].clothConstData.clothParam1.w;
		    v64 = *(_QWORD *)&RenderData_CSharpWrapper[2].clothConstData.packedDeltaT.x;
		    if ( LOBYTE(v36.m_RenderPass) )
		    {
		      v14 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0xB7u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !v6 )
		        sub_1800D8260(v16, v15);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v30,
		        v6,
		        (String *)"GpuClothDataClear",
		        &v31,
		        v14,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::ClearPassData>);
		      v41 = v30;
		      v30.m_RenderPass = 0LL;
		      v30.m_Resources = (HGRenderGraphResourceRegistry *)&v41;
		      try
		      {
		        LODWORD(v36.m_RenderGraph) = w;
		        HG::Rendering::Runtime::GpuClothSimulationPassConstructor::_PrepareClothClearPassData(
		          v9,
		          (GpuClothClearBufferDataCPP *)&v36,
		          (GpuClothSimulationPassConstructor_ClearPassData **)&v31,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v41,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor->static_fields->s_clearFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::ClearPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v45 )
		      {
		        v30.m_RenderPass = (HGRenderGraphPass *)v45->ex;
		        sub_180268AE0(&v30);
		        v6 = renderGraph;
		        v9 = this;
		        *(_OWORD *)&v35.m_RenderPass = *(_OWORD *)&v37.clothBatchCacheMapUploadDataNum;
		        v40 = *(_OWORD *)&v37.clothBatchMetaUploadDataNum;
		        v39 = *(_OWORD *)&v37.clothNodeUploadDataNum;
		        v38 = *(_OWORD *)&v37.clothMetaUploadDataNum;
		        v17 = *(__m128i *)&v37.isValid;
		        v29 = *(__m128i *)&v37.isValid;
		        goto LABEL_7;
		      }
		      sub_180268AE0(&v30);
		      v17 = v29;
		    }
		    else
		    {
		      v17 = v29;
		    }
		LABEL_7:
		    if ( (unsigned __int8)_mm_cvtsi128_si32(v17) )
		    {
		      v18 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0xB8u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !v6 )
		        goto LABEL_25;
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v36,
		        v6,
		        (String *)"GpuClothDataUpload",
		        &v32,
		        v18,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::UploadPassData>);
		      v42 = v36;
		      v30.m_RenderPass = 0LL;
		      v30.m_Resources = (HGRenderGraphResourceRegistry *)&v42;
		      try
		      {
		        *(__m128i *)&v37.isValid = v29;
		        *(_OWORD *)&v37.clothMetaUploadDataNum = v38;
		        *(_OWORD *)&v37.clothNodeUploadDataNum = v39;
		        *(_OWORD *)&v37.clothBatchMetaUploadDataNum = v40;
		        *(_OWORD *)&v37.clothBatchCacheMapUploadDataNum = *(_OWORD *)&v35.m_RenderPass;
		        HG::Rendering::Runtime::GpuClothSimulationPassConstructor::_PrepareClothUploadPassData(
		          v9,
		          &v37,
		          (GpuClothSimulationPassConstructor_UploadPassData **)&v32,
		          0LL);
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v42,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor->static_fields->s_uploadFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::UploadPassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v46 )
		      {
		        v30.m_RenderPass = (HGRenderGraphPass *)v46->ex;
		        sub_180268AE0(&v30);
		        v6 = renderGraph;
		        v9 = this;
		        goto LABEL_11;
		      }
		      sub_180268AE0(&v30);
		    }
		LABEL_11:
		    if ( !(_BYTE)v50 )
		      goto LABEL_15;
		    v21 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0xB9u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !v6 )
		      goto LABEL_25;
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v35,
		      v6,
		      (String *)"GpuClothSim",
		      &v33,
		      v21,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::PassData>);
		    v43 = v35;
		    v29.m128i_i64[0] = 0LL;
		    v29.m128i_i64[1] = (__int64)&v43;
		    try
		    {
		      v65[0] = v50;
		      v65[1] = v51;
		      v65[2] = v52;
		      v65[3] = v53;
		      v65[4] = v54;
		      v65[5] = v55;
		      v65[6] = packedDeltaT;
		      v65[7] = clothParam1;
		      v65[8] = v58;
		      v65[9] = v59;
		      v65[10] = v60;
		      v65[11] = v61;
		      v65[12] = v62;
		      v65[13] = v63;
		      v66 = v64;
		      HG::Rendering::Runtime::GpuClothSimulationPassConstructor::_PrepareClothSimPassData(
		        v9,
		        (GpuClothRenderDataCPP *)v65,
		        (GpuClothSimulationPassConstructor_PassData **)&v33,
		        0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v43,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor->static_fields->s_dispatchFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::PassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v47 )
		    {
		      *(Il2CppExceptionWrapper *)v29.m128i_i8 = (Il2CppExceptionWrapper)v47->ex;
		      sub_180268AE0(&v29);
		      v6 = renderGraph;
		LABEL_15:
		      SkeletonBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetSkeletonBufferID(0LL);
		      if ( !SkeletonBufferID )
		        return;
		      v23 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		              (Int32Enum__Enum)0xB9u,
		              MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		      if ( !v6 )
		LABEL_25:
		        sub_1800D8250(v20, v19);
		      HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		        &v35,
		        v6,
		        (String *)"GpuClothSetDefault",
		        &v34,
		        v23,
		        1,
		        ProfilingHGPass__Enum_None,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::PassData>);
		      v44 = v35;
		      v29.m128i_i64[0] = 0LL;
		      v29.m128i_i64[1] = (__int64)&v44;
		      try
		      {
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v44, 0, 0LL);
		        if ( !v34 )
		          sub_1800D8250(v25, v24);
		        LODWORD(v34[17].klass) = SkeletonBufferID;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor);
		        HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		          &v44,
		          (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::GpuClothSimulationPassConstructor->static_fields->s_setDefaultFunc,
		          0LL,
		          0,
		          MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::GpuClothSimulationPassConstructor::PassData>);
		      }
		      catch ( Il2CppExceptionWrapper *v48 )
		      {
		        *(Il2CppExceptionWrapper *)v29.m128i_i8 = (Il2CppExceptionWrapper)v48->ex;
		        sub_180268AE0(&v29);
		        return;
		      }
		    }
		    sub_180268AE0(&v29);
		    return;
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3194, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v28, v27);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1181(
		    Patch,
		    (Object *)v9,
		    input,
		    output,
		    (Object *)v6,
		    (Object *)camera,
		    0LL);
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189BB24D0-0x0000000189BB2544
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        GpuClothSimulationPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  HGManagerContext *currentManagerContext; // rax
		  __int64 v6; // rdx
		  GpuClothManager *gpuClothManager_k__BackingField; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3198, 0LL) )
		  {
		    currentManagerContext = HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( currentManagerContext )
		    {
		      gpuClothManager_k__BackingField = currentManagerContext->fields._gpuClothManager_k__BackingField;
		      if ( gpuClothManager_k__BackingField )
		      {
		        HG::Rendering::Runtime::GpuClothManager::FlipSkeletonFlag(gpuClothManager_k__BackingField, 0LL);
		        return;
		      }
		    }
		LABEL_6:
		    sub_1800D8260(gpuClothManager_k__BackingField, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3198, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184D80380-0x0000000184D803B0
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        GpuClothSimulationPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3199, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3199, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		}
		
		private void _PrepareClothClearPassData(GpuClothClearBufferDataCPP clearData, ref ClearPassData passData) {} // 0x0000000189BB279C-0x0000000189BB289C
		// Void _PrepareClothClearPassData(GpuClothClearBufferDataCPP, GpuClothSimulationPassConstructor+ClearPassData ByRef)
		void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::_PrepareClothClearPassData(
		        GpuClothSimulationPassConstructor *this,
		        GpuClothClearBufferDataCPP *clearData,
		        GpuClothSimulationPassConstructor_ClearPassData **passData,
		        MethodInfo *method)
		{
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  unsigned __int64 m_clothDataClearHandle; // rcx
		  __int128 v11; // xmm0
		  GpuClothSimulationPassConstructor_ClearPassData *v12; // r9
		  GpuClothSimulationPassConstructor_ClearPassData *v13; // rdi
		  uint32_t ClothNodeBufferID; // eax
		  GpuClothSimulationPassConstructor_ClearPassData *v15; // rdi
		  uint32_t ClothBatchMetaDataBufferID; // eax
		  GpuClothSimulationPassConstructor_ClearPassData *v17; // rbx
		  uint32_t ClothBatchCacheMapBufferID; // eax
		  int32_t w; // eax
		  MethodInfo *v20; // [rsp+20h] [rbp-38h]
		  GpuClothClearBufferDataCPP v21; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3195, 0LL) )
		  {
		    m_clothDataClearHandle = (unsigned int)this->fields.m_clothDataClearHandle;
		    if ( *passData )
		    {
		      (*passData)->fields.clothClearCSHandle = m_clothDataClearHandle;
		      m_clothDataClearHandle = (unsigned __int64)*passData;
		      if ( *passData )
		      {
		        *(_QWORD *)(m_clothDataClearHandle + 24) = this->fields.m_clothDataUploadCS;
		        sub_18002D1B0((SingleFieldAccessor *)(m_clothDataClearHandle + 24), v7, v8, v9, v20);
		        v11 = *(_OWORD *)&clearData->shouldClear;
		        v12 = *passData;
		        v21.eleNum.w = clearData->eleNum.w;
		        *(_OWORD *)&v21.shouldClear = v11;
		        if ( v12 )
		        {
		          v12->fields.eleNum = v21.eleNum;
		          v13 = *passData;
		          ClothNodeBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothNodeBufferID(0LL);
		          if ( v13 )
		          {
		            v13->fields.clothNodeDataBufferID = ClothNodeBufferID;
		            v15 = *passData;
		            ClothBatchMetaDataBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothBatchMetaDataBufferID(0LL);
		            if ( v15 )
		            {
		              v15->fields.clothBatchMetaDataBufferID = ClothBatchMetaDataBufferID;
		              v17 = *passData;
		              ClothBatchCacheMapBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothBatchCacheMapBufferID(0LL);
		              if ( v17 )
		              {
		                v17->fields.clothBatchCacheMapBufferID = ClothBatchCacheMapBufferID;
		                return;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_10:
		    sub_1800D8260(m_clothDataClearHandle, v7);
		  }
		  m_clothDataClearHandle = (unsigned __int64)IFix::WrappersManagerImpl::GetPatch(3195, 0LL);
		  if ( !m_clothDataClearHandle )
		    goto LABEL_10;
		  w = clearData->eleNum.w;
		  *(_OWORD *)&v21.shouldClear = *(_OWORD *)&clearData->shouldClear;
		  v21.eleNum.w = w;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1178(
		    (ILFixDynamicMethodWrapper_2 *)m_clothDataClearHandle,
		    (Object *)this,
		    &v21,
		    passData,
		    0LL);
		}
		
		private void _PrepareClothUploadPassData(GpuClothGroupUploadDataCPP uploadData, ref UploadPassData passData) {} // 0x0000000189BB2BE0-0x0000000189BB2E40
		// Void _PrepareClothUploadPassData(GpuClothGroupUploadDataCPP, GpuClothSimulationPassConstructor+UploadPassData ByRef)
		void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::_PrepareClothUploadPassData(
		        GpuClothSimulationPassConstructor *this,
		        GpuClothGroupUploadDataCPP *uploadData,
		        GpuClothSimulationPassConstructor_UploadPassData **passData,
		        MethodInfo *method)
		{
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  __int64 m_clothDataUploadHandle; // rcx
		  __m128i v11; // xmm2
		  GpuClothSimulationPassConstructor_UploadPassData *v12; // r9
		  __int64 v13; // rax
		  __m128i v14; // xmm2
		  __m128i v15; // xmm2
		  __m128i v16; // xmm1
		  __m128i v17; // xmm0
		  GpuClothSimulationPassConstructor_UploadPassData *v18; // rbx
		  uint32_t ClothMetaDataBufferID; // eax
		  GpuClothSimulationPassConstructor_UploadPassData *v20; // rbx
		  uint32_t ClothNodeBufferID; // eax
		  GpuClothSimulationPassConstructor_UploadPassData *v22; // rbx
		  uint32_t ClothBatchMetaDataBufferID; // eax
		  GpuClothSimulationPassConstructor_UploadPassData *v24; // rbx
		  uint32_t ClothBatchCacheMapBufferID; // eax
		  GpuClothSimulationPassConstructor_UploadPassData *v26; // rbx
		  uint32_t SkeletonBufferID; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  MethodInfo *v33; // [rsp+28h] [rbp-19h]
		  IVec4 v34; // [rsp+38h] [rbp-9h]
		  GpuClothGroupUploadDataCPP v35; // [rsp+48h] [rbp+7h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3196, 0LL) )
		  {
		    m_clothDataUploadHandle = (unsigned int)this->fields.m_clothDataUploadHandle;
		    if ( *passData )
		    {
		      (*passData)->fields.clothUploadCSHandle = m_clothDataUploadHandle;
		      m_clothDataUploadHandle = (__int64)*passData;
		      if ( *passData )
		      {
		        *(_QWORD *)(m_clothDataUploadHandle + 24) = this->fields.m_clothDataUploadCS;
		        sub_18002D1B0((SingleFieldAccessor *)(m_clothDataUploadHandle + 24), v7, v8, v9, v33);
		        m_clothDataUploadHandle = 1LL;
		        v11 = *(__m128i *)&uploadData->clothMetaUploadDataNum;
		        v12 = *passData;
		        v13 = HIDWORD(*(_QWORD *)&uploadData->isValid);
		        v34.x = _mm_cvtsi128_si32(v11);
		        if ( (int)v13 > 1 )
		          m_clothDataUploadHandle = (unsigned int)v13;
		        v34.y = m_clothDataUploadHandle;
		        if ( v12 )
		        {
		          *(_QWORD *)&v34.z = (unsigned int)HIDWORD(*(_QWORD *)&uploadData->isValid);
		          v12->fields.uploadConstData = v34;
		          m_clothDataUploadHandle = (__int64)*passData;
		          if ( *passData )
		          {
		            *(_DWORD *)(m_clothDataUploadHandle + 48) = _mm_cvtsi128_si32(v11);
		            m_clothDataUploadHandle = (__int64)*passData;
		            if ( *passData )
		            {
		              v14 = *(__m128i *)&uploadData->isValid;
		              *(_QWORD *)(m_clothDataUploadHandle + 56) = uploadData->clothMetaUploadData;
		              m_clothDataUploadHandle = (__int64)*passData;
		              if ( *passData )
		              {
		                *(_DWORD *)(m_clothDataUploadHandle + 64) = _mm_cvtsi128_si32(_mm_srli_si128(v14, 4));
		                m_clothDataUploadHandle = (__int64)*passData;
		                if ( *passData )
		                {
		                  *(_QWORD *)(m_clothDataUploadHandle + 72) = _mm_srli_si128(*(__m128i *)&uploadData->isValid, 8).m128i_u64[0];
		                  m_clothDataUploadHandle = (__int64)*passData;
		                  v15 = *(__m128i *)&uploadData->clothNodeUploadDataNum;
		                  if ( *passData )
		                  {
		                    *(_DWORD *)(m_clothDataUploadHandle + 80) = _mm_cvtsi128_si32(v15);
		                    m_clothDataUploadHandle = (__int64)*passData;
		                    if ( *passData )
		                    {
		                      v16 = *(__m128i *)&uploadData->clothBatchMetaUploadDataNum;
		                      *(_QWORD *)(m_clothDataUploadHandle + 88) = _mm_srli_si128(v15, 8).m128i_u64[0];
		                      m_clothDataUploadHandle = (__int64)*passData;
		                      if ( *passData )
		                      {
		                        *(_DWORD *)(m_clothDataUploadHandle + 96) = _mm_cvtsi128_si32(v16);
		                        m_clothDataUploadHandle = (__int64)*passData;
		                        if ( *passData )
		                        {
		                          v17 = *(__m128i *)&uploadData->clothBatchCacheMapUploadDataNum;
		                          *(_QWORD *)(m_clothDataUploadHandle + 104) = _mm_srli_si128(v16, 8).m128i_u64[0];
		                          m_clothDataUploadHandle = (__int64)*passData;
		                          if ( *passData )
		                          {
		                            *(_DWORD *)(m_clothDataUploadHandle + 112) = _mm_cvtsi128_si32(v17);
		                            m_clothDataUploadHandle = (__int64)*passData;
		                            if ( *passData )
		                            {
		                              *(_QWORD *)(m_clothDataUploadHandle + 120) = _mm_srli_si128(v17, 8).m128i_u64[0];
		                              v18 = *passData;
		                              ClothMetaDataBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothMetaDataBufferID(0LL);
		                              if ( v18 )
		                              {
		                                v18->fields.clothMetaDataBufferID = ClothMetaDataBufferID;
		                                v20 = *passData;
		                                ClothNodeBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothNodeBufferID(0LL);
		                                if ( v20 )
		                                {
		                                  v20->fields.clothNodeDataBufferID = ClothNodeBufferID;
		                                  v22 = *passData;
		                                  ClothBatchMetaDataBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothBatchMetaDataBufferID(0LL);
		                                  if ( v22 )
		                                  {
		                                    v22->fields.clothBatchMetaDataBufferID = ClothBatchMetaDataBufferID;
		                                    v24 = *passData;
		                                    ClothBatchCacheMapBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothBatchCacheMapBufferID(0LL);
		                                    if ( v24 )
		                                    {
		                                      v24->fields.clothBatchCacheMapBufferID = ClothBatchCacheMapBufferID;
		                                      v26 = *passData;
		                                      SkeletonBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetSkeletonBufferID(0LL);
		                                      if ( v26 )
		                                      {
		                                        v26->fields.clothSkeletonDataBufferID = SkeletonBufferID;
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
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_24:
		    sub_1800D8260(m_clothDataUploadHandle, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3196, 0LL);
		  if ( !Patch )
		    goto LABEL_24;
		  v29 = *(_OWORD *)&uploadData->clothMetaUploadDataNum;
		  *(_OWORD *)&v35.isValid = *(_OWORD *)&uploadData->isValid;
		  v30 = *(_OWORD *)&uploadData->clothNodeUploadDataNum;
		  *(_OWORD *)&v35.clothMetaUploadDataNum = v29;
		  v31 = *(_OWORD *)&uploadData->clothBatchMetaUploadDataNum;
		  *(_OWORD *)&v35.clothNodeUploadDataNum = v30;
		  v32 = *(_OWORD *)&uploadData->clothBatchCacheMapUploadDataNum;
		  *(_OWORD *)&v35.clothBatchMetaUploadDataNum = v31;
		  *(_OWORD *)&v35.clothBatchCacheMapUploadDataNum = v32;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1179(Patch, (Object *)this, &v35, passData, 0LL);
		}
		
		private void _PrepareClothSimPassData(GpuClothRenderDataCPP renderData, ref PassData data) {} // 0x0000000189BB289C-0x0000000189BB2BE0
		// Void _PrepareClothSimPassData(GpuClothRenderDataCPP, GpuClothSimulationPassConstructor+PassData ByRef)
		void HG::Rendering::Runtime::GpuClothSimulationPassConstructor::_PrepareClothSimPassData(
		        GpuClothSimulationPassConstructor *this,
		        GpuClothRenderDataCPP *renderData,
		        GpuClothSimulationPassConstructor_PassData **data,
		        MethodInfo *method)
		{
		  Int32__Array **v7; // r9
		  GpuClothSimulationPassConstructor_PassData *v8; // rcx
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  Vector4 packedDeltaT; // xmm0
		  __int128 v15; // xmm1
		  GpuClothSimulationPassConstructor_PassData *v16; // rdx
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm1
		  __int128 v21; // xmm0
		  __int64 v22; // rax
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  Vector4 v29; // xmm0
		  Vector4 clothParam1; // xmm1
		  ClothConstDataCPP_colliderInfos_e_FixedBuffer *p_colliderInfos; // rbx
		  __int64 v32; // rax
		  __int128 v33; // xmm0
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  __int128 v36; // xmm1
		  __int128 v37; // xmm0
		  __int128 v38; // xmm1
		  Vector4 v39; // xmm1
		  __int128 v40; // xmm0
		  __int128 v41; // xmm1
		  __int128 v42; // xmm0
		  __int128 v43; // xmm1
		  Vector4 v44; // xmm0
		  Vector4 v45; // xmm1
		  __int128 v46; // xmm0
		  __int128 v47; // xmm1
		  __int128 v48; // xmm0
		  __int128 v49; // xmm1
		  Vector4 v50; // xmm0
		  Vector4 v51; // xmm1
		  GpuClothSimulationPassConstructor_PassData *v52; // rbx
		  uint32_t ClothNodeBufferID; // eax
		  GpuClothSimulationPassConstructor_PassData *v54; // rbx
		  uint32_t ClothMetaDataBufferID; // eax
		  GpuClothSimulationPassConstructor_PassData *v56; // rbx
		  uint32_t ClothBatchMetaDataBufferID; // eax
		  GpuClothSimulationPassConstructor_PassData *v58; // rbx
		  uint32_t ClothBatchCacheMapBufferID; // eax
		  GpuClothSimulationPassConstructor_PassData *v60; // rbx
		  uint32_t SkeletonBufferID; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // r10
		  __int128 v63; // xmm1
		  __int128 v64; // xmm0
		  __int128 v65; // xmm1
		  __int128 v66; // xmm0
		  __int128 v67; // xmm1
		  Vector4 v68; // xmm0
		  Vector4 v69; // xmm0
		  ClothConstDataCPP_colliderInfos_e_FixedBuffer *v70; // rbx
		  __int64 v71; // rax
		  __int128 v72; // xmm0
		  __int128 v73; // xmm1
		  __int128 v74; // xmm0
		  __int128 v75; // xmm1
		  __int128 v76; // xmm0
		  MethodInfo *v77; // [rsp+20h] [rbp-108h]
		  _BYTE v78[232]; // [rsp+30h] [rbp-F8h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3197, 0LL) )
		  {
		    v8 = *data;
		    v9 = *(_OWORD *)&renderData->clothConstData.packedDeltaT.z;
		    *(_OWORD *)v78 = *(_OWORD *)&renderData->isValid;
		    v10 = *(_OWORD *)&renderData->clothConstData.clothParam1.z;
		    *(_OWORD *)&v78[16] = v9;
		    v11 = *(_OWORD *)&renderData[1].clothNum;
		    *(_OWORD *)&v78[32] = v10;
		    v12 = *(_OWORD *)&renderData[1].clothConstData.packedDeltaT.w;
		    *(_OWORD *)&v78[48] = v11;
		    v13 = *(_OWORD *)&renderData[1].clothConstData.clothParam1.w;
		    *(_OWORD *)&v78[64] = v12;
		    packedDeltaT = renderData[2].clothConstData.packedDeltaT;
		    *(_OWORD *)&v78[80] = v13;
		    v15 = *(_OWORD *)&renderData[2].clothConstData.colliderInfos.FixedElementField;
		    *(Vector4 *)&v78[96] = packedDeltaT;
		    v16 = (GpuClothSimulationPassConstructor_PassData *)&v78[128];
		    *(Vector4 *)&v78[112] = renderData[2].clothConstData.clothParam1;
		    v17 = *(_OWORD *)&renderData[3].clothConstData.packedDeltaT.y;
		    *(_OWORD *)&v78[128] = v15;
		    v18 = *(_OWORD *)&renderData[3].clothConstData.clothParam1.y;
		    *(_OWORD *)&v78[144] = v17;
		    v19 = *(_OWORD *)&renderData[4].isValid;
		    *(_OWORD *)&v78[160] = v18;
		    v20 = *(_OWORD *)&renderData[4].clothConstData.packedDeltaT.z;
		    *(_OWORD *)&v78[176] = v19;
		    v21 = *(_OWORD *)&renderData[4].clothConstData.clothParam1.z;
		    v22 = *(_QWORD *)&renderData[5].clothNum;
		    *(_OWORD *)&v78[192] = v20;
		    *(_OWORD *)&v78[208] = v21;
		    *(_QWORD *)&v78[224] = v22;
		    if ( v8 )
		    {
		      v23 = *(_OWORD *)&renderData->isValid;
		      v8->fields.clothNum = *(_DWORD *)&v78[4];
		      v24 = *(_OWORD *)&renderData->clothConstData.packedDeltaT.z;
		      v16 = *data;
		      *(_OWORD *)v78 = v23;
		      v25 = *(_OWORD *)&renderData->clothConstData.clothParam1.z;
		      *(_OWORD *)&v78[16] = v24;
		      v26 = *(_OWORD *)&renderData[1].clothNum;
		      *(_OWORD *)&v78[32] = v25;
		      v27 = *(_OWORD *)&renderData[1].clothConstData.packedDeltaT.w;
		      *(_OWORD *)&v78[48] = v26;
		      v28 = *(_OWORD *)&renderData[1].clothConstData.clothParam1.w;
		      *(_OWORD *)&v78[64] = v27;
		      v29 = renderData[2].clothConstData.packedDeltaT;
		      *(_OWORD *)&v78[80] = v28;
		      clothParam1 = renderData[2].clothConstData.clothParam1;
		      p_colliderInfos = &renderData[2].clothConstData.colliderInfos;
		      *(Vector4 *)&v78[96] = v29;
		      v8 = (GpuClothSimulationPassConstructor_PassData *)&v78[128];
		      v32 = *(_QWORD *)&p_colliderInfos[24].FixedElementField;
		      v33 = *(_OWORD *)&p_colliderInfos->FixedElementField;
		      *(Vector4 *)&v78[112] = clothParam1;
		      v34 = *(_OWORD *)&p_colliderInfos[4].FixedElementField;
		      *(_OWORD *)&v78[128] = v33;
		      v35 = *(_OWORD *)&p_colliderInfos[8].FixedElementField;
		      *(_OWORD *)&v78[144] = v34;
		      v36 = *(_OWORD *)&p_colliderInfos[12].FixedElementField;
		      *(_OWORD *)&v78[160] = v35;
		      v37 = *(_OWORD *)&p_colliderInfos[16].FixedElementField;
		      *(_OWORD *)&v78[176] = v36;
		      v38 = *(_OWORD *)&p_colliderInfos[20].FixedElementField;
		      *(_OWORD *)&v78[192] = v37;
		      *(_OWORD *)&v78[208] = v38;
		      *(_QWORD *)&v78[224] = v32;
		      if ( v16 )
		      {
		        v39 = *(Vector4 *)&v78[24];
		        v16->fields.clothConstData.packedDeltaT = *(Vector4 *)&v78[8];
		        v40 = *(_OWORD *)&v78[40];
		        v16->fields.clothConstData.clothParam1 = v39;
		        v41 = *(_OWORD *)&v78[56];
		        *(_OWORD *)&v16->fields.clothConstData.colliderInfos.FixedElementField = v40;
		        v42 = *(_OWORD *)&v78[72];
		        *(_OWORD *)((char *)&v16->fields.clothSingleDispatchCS + 4) = v41;
		        v43 = *(_OWORD *)&v78[88];
		        *(_OWORD *)&v16->fields.clothBatchCacheMapBufferID = v42;
		        v44 = *(Vector4 *)&v78[104];
		        *(_OWORD *)((char *)&v16[1].klass + 4) = v43;
		        v45 = *(Vector4 *)&v78[120];
		        v16[1].fields.clothConstData.packedDeltaT = v44;
		        v46 = *(_OWORD *)&v78[136];
		        v16[1].fields.clothConstData.clothParam1 = v45;
		        v47 = *(_OWORD *)&v78[152];
		        *(_OWORD *)&v16[1].fields.clothConstData.colliderInfos.FixedElementField = v46;
		        v48 = *(_OWORD *)&v78[168];
		        *(_OWORD *)((char *)&v16[1].fields.clothSingleDispatchCS + 4) = v47;
		        v49 = *(_OWORD *)&v78[184];
		        *(_OWORD *)&v16[1].fields.clothBatchCacheMapBufferID = v48;
		        v50 = *(Vector4 *)&v78[200];
		        *(_OWORD *)((char *)&v16[2].klass + 4) = v49;
		        v51 = *(Vector4 *)&v78[216];
		        v16[2].fields.clothConstData.packedDeltaT = v50;
		        v16[2].fields.clothConstData.clothParam1 = v51;
		        v8 = *data;
		        if ( *data )
		        {
		          *(_QWORD *)&v8[2].fields.clothSingleDispatchCSHandle = this->fields.m_clothSingleDispatchCS;
		          sub_18002D1B0(
		            (SingleFieldAccessor *)&v8[2].fields.clothSingleDispatchCSHandle,
		            (Type *)v16,
		            (PropertyInfo_1 *)0x80,
		            v7,
		            v77);
		          if ( *data )
		          {
		            LODWORD((*data)[2].fields.clothConstData.colliderInfos.FixedElementField) = this->fields.m_clothSingleDispatchHandle;
		            v52 = *data;
		            ClothNodeBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothNodeBufferID(0LL);
		            if ( v52 )
		            {
		              LODWORD(v52[2].fields.clothSingleDispatchCS) = ClothNodeBufferID;
		              v54 = *data;
		              ClothMetaDataBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothMetaDataBufferID(0LL);
		              if ( v54 )
		              {
		                HIDWORD(v54[2].fields.clothSingleDispatchCS) = ClothMetaDataBufferID;
		                v56 = *data;
		                ClothBatchMetaDataBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothBatchMetaDataBufferID(0LL);
		                if ( v56 )
		                {
		                  v56[2].fields.clothNodeDataBufferID = ClothBatchMetaDataBufferID;
		                  v58 = *data;
		                  ClothBatchCacheMapBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetClothBatchCacheMapBufferID(0LL);
		                  if ( v58 )
		                  {
		                    v58[2].fields.clothMetaDataBufferID = ClothBatchCacheMapBufferID;
		                    v60 = *data;
		                    SkeletonBufferID = UnityEngine::HyperGryph::HGGpuClothManagerV2::GetSkeletonBufferID(0LL);
		                    if ( v60 )
		                    {
		                      v60[2].fields.clothBatchMetaDataBufferID = SkeletonBufferID;
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
		    sub_1800D8260(v8, v16);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3197, 0LL);
		  if ( !Patch )
		    goto LABEL_13;
		  v63 = *(_OWORD *)&renderData->clothConstData.packedDeltaT.z;
		  *(_OWORD *)v78 = *(_OWORD *)&renderData->isValid;
		  v64 = *(_OWORD *)&renderData->clothConstData.clothParam1.z;
		  *(_OWORD *)&v78[16] = v63;
		  v65 = *(_OWORD *)&renderData[1].clothNum;
		  *(_OWORD *)&v78[32] = v64;
		  v66 = *(_OWORD *)&renderData[1].clothConstData.packedDeltaT.w;
		  *(_OWORD *)&v78[48] = v65;
		  v67 = *(_OWORD *)&renderData[1].clothConstData.clothParam1.w;
		  *(_OWORD *)&v78[64] = v66;
		  v68 = renderData[2].clothConstData.packedDeltaT;
		  *(_OWORD *)&v78[80] = v67;
		  *(Vector4 *)&v78[96] = v68;
		  v69 = renderData[2].clothConstData.clothParam1;
		  v70 = &renderData[2].clothConstData.colliderInfos;
		  *(Vector4 *)&v78[112] = v69;
		  v71 = *(_QWORD *)&v70[24].FixedElementField;
		  v72 = *(_OWORD *)&v70[4].FixedElementField;
		  *(_OWORD *)&v78[128] = *(_OWORD *)&v70->FixedElementField;
		  v73 = *(_OWORD *)&v70[8].FixedElementField;
		  *(_OWORD *)&v78[144] = v72;
		  v74 = *(_OWORD *)&v70[12].FixedElementField;
		  *(_OWORD *)&v78[160] = v73;
		  v75 = *(_OWORD *)&v70[16].FixedElementField;
		  *(_OWORD *)&v78[176] = v74;
		  v76 = *(_OWORD *)&v70[20].FixedElementField;
		  *(_OWORD *)&v78[192] = v75;
		  *(_OWORD *)&v78[208] = v76;
		  *(_QWORD *)&v78[224] = v71;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1180(Patch, (Object *)this, (GpuClothRenderDataCPP *)v78, data, 0LL);
		}
		
		private static unsafe CBHandle _AllocateConstBuffer<T>(HGRenderGraphContext context, T* ptr, int count, int capacity)
			where T : struct => default;
		private static unsafe ValueTuple<CBHandle, CBHandle> _AllocateClothNodeConstBuffer(HGRenderGraphContext context, ClothNodeDataCPP* ptr, int count) => default; // 0x0000000189BB2660-0x0000000189BB279C
		// ValueTuple`2[UnityEngine.Rendering.CBHandle,UnityEngine.Rendering.CBHandle] _AllocateClothNodeConstBuffer(HGRenderGraphContext, ClothNodeDataCPP*, Int32)
		ValueTuple_2_UnityEngine_Rendering_CBHandle_UnityEngine_Rendering_CBHandle_ *HG::Rendering::Runtime::GpuClothSimulationPassConstructor::_AllocateClothNodeConstBuffer(
		        ValueTuple_2_UnityEngine_Rendering_CBHandle_UnityEngine_Rendering_CBHandle_ *__return_ptr retstr,
		        HGRenderGraphContext *context,
		        ClothNodeDataCPP *ptr,
		        int32_t count,
		        MethodInfo *method)
		{
		  CBHandle *v9; // rax
		  __int128 v10; // xmm7
		  CBHandle *v11; // rax
		  __int128 v12; // xmm6
		  int32_t v13; // eax
		  void *v14; // rsi
		  ValueTuple_2_UnityEngine_Rendering_CBHandle_UnityEngine_Rendering_CBHandle_ *result; // rax
		  Void *destination; // [rsp+30h] [rbp-68h]
		  CBHandle v17; // [rsp+40h] [rbp-58h] BYREF
		
		  if ( !context )
		    sub_1800D8260(retstr, 0LL);
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
		  v9 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		         &v17,
		         &context->fields.renderContext,
		         65280,
		         0LL);
		  v10 = *(_OWORD *)&v9->bufferId;
		  destination = (Void *)v9->ptr;
		  v11 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
		          &v17,
		          &context->fields.renderContext,
		          65280,
		          0LL);
		  v12 = *(_OWORD *)&v11->bufferId;
		  v17.ptr = v11->ptr;
		  if ( count > 0 )
		  {
		    v13 = count;
		    if ( count >= 340 )
		      v13 = 340;
		    Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(destination, (Void *)ptr, 192 * v13, 0LL);
		  }
		  v14 = v17.ptr;
		  if ( count > 340 )
		    Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
		      (Void *)v17.ptr,
		      (Void *)&ptr[480],
		      192 * (count - 340),
		      0LL);
		  result = retstr;
		  *(_OWORD *)&retstr->Item1.bufferId = v10;
		  *(_OWORD *)&retstr->Item2.bufferId = v12;
		  retstr->Item1.ptr = destination;
		  retstr->Item2.ptr = v14;
		  return result;
		}
		
	}
}
