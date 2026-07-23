using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.RenderGraphModule;
using Unity.Collections;
using UnityEngine;
using UnityEngine.HyperGryph;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class LightClusteringPassConstructor : IDisposable, IPassConstructor // TypeDefIndex: 37781
	{
		// Fields
		internal const int MAX_PUNCTUAL_LIGHT_INDICES_COUNT = 256; // Metadata: 0x023030F6
		private NativeArray<VisibleLight> m_visibleLights; // 0x10
		private NativeArray<PunctualLightSortStruct> m_punctualLightSortArray; // 0x20
		private NativeArray<int> m_punctualLightIndices; // 0x30
		private NativeArray<float> m_punctualLightDistances; // 0x40
		private int m_punctualLightCount; // 0x50
		private int m_directionalLightIndex; // 0x54
		private uint m_lightMaskSpotOrPointWithOBB; // 0x58
		private uint m_lightMaskSpotOrPointWithoutOBB; // 0x5C
		private uint m_lightMaskLinearWithOBB; // 0x60
		private uint m_lightMaskLinearWithoutOBB; // 0x64
		private LightCulling m_lightCulling; // 0x68
		private static readonly RenderFunc<LightCullingPassData> s_lightCullingRenderFunc; // 0x00
	
		// Nested types
		private struct PunctualLightSortStruct : IComparable<PunctualLightSortStruct> // TypeDefIndex: 37775
		{
			// Fields
			public int index; // 0x00
			public float distance; // 0x04
			private int priority; // 0x08
			public static PunctualLightSortStruct INVALID_LIGHT; // 0x00
	
			// Constructors
			public PunctualLightSortStruct(int inIndex, float inDistance, int inPriority) {
				index = default;
				distance = default;
				priority = default;
			} // 0x0000000184DA2210-0x0000000184DA2220
			// LightClusteringPassConstructor+PunctualLightSortStruct(Int32, Single, Int32)
			void HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct::PunctualLightSortStruct(
			        LightClusteringPassConstructor_PunctualLightSortStruct *this,
			        int32_t inIndex,
			        float inDistance,
			        int32_t inPriority,
			        MethodInfo *method)
			{
			  this->distance = inDistance;
			  this->index = inIndex;
			  this->priority = inPriority;
			}
			
			static PunctualLightSortStruct() {
				INVALID_LIGHT = default;
			} // 0x0000000184DA21D0-0x0000000184DA2210
			// LightClusteringPassConstructor+PunctualLightSortStruct()
			void HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct::cctor(MethodInfo *method)
			{
			  LightClusteringPassConstructor_PunctualLightSortStruct__StaticFields *static_fields; // rcx
			
			  static_fields = TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct->static_fields;
			  *(_QWORD *)&static_fields->INVALID_LIGHT.index = 0x7F7FFFFFFFFFFFFFLL;
			  static_fields->INVALID_LIGHT.priority = 0x80000000;
			}
			
	
			// Methods
			public int CompareTo(PunctualLightSortStruct other) => default; // 0x0000000189D0FF00-0x0000000189D0FF90
			// Int32 CompareTo(LightClusteringPassConstructor+PunctualLightSortStruct)
			int32_t HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct::CompareTo(
			        LightClusteringPassConstructor_PunctualLightSortStruct *this,
			        LightClusteringPassConstructor_PunctualLightSortStruct *other,
			        MethodInfo *method)
			{
			  __int64 v6; // rdx
			  ILFixDynamicMethodWrapper_2 *Patch; // rcx
			  int32_t priority; // eax
			  LightClusteringPassConstructor_PunctualLightSortStruct v9; // [rsp+20h] [rbp-18h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(1967, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(1967, 0LL);
			    if ( !Patch )
			      sub_1800D8260(0LL, v6);
			    priority = other->priority;
			    *(_QWORD *)&v9.index = *(_QWORD *)&other->index;
			    v9.priority = priority;
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_790(Patch, this, &v9, 0LL);
			  }
			  else if ( this->priority == other->priority )
			  {
			    return System::Single::CompareTo((Single *)&this->distance, other->distance, 0LL);
			  }
			  else
			  {
			    return System::Int32::CompareTo((Int32 *)&other->priority, this->priority, 0LL);
			  }
			}
			
		}
	
		internal struct PassInput // TypeDefIndex: 37776
		{
			// Fields
			internal CullingResults cullingResults; // 0x00
			internal LightCullResult lightCullResult; // 0x10
			internal BinningPass.BinningData binningData; // 0x20
			internal ComputeBufferHandle binningBuffer; // 0x3C
			internal HGSettingParameters settingParams; // 0x48
			internal bool outputTileResult; // 0x50
		}
	
		internal struct PassOutput // TypeDefIndex: 37778
		{
			// Fields
			internal Vector4 directionalLightDir; // 0x00
			internal unsafe fixed /* 0x00000000-0x00000000 */ int punctualLightIndices[0]; // 0x10
			internal int punctualLightCount; // 0x410
			internal int directionalLightIndex; // 0x414
			internal ComputeBufferHandle drawTileArgs; // 0x418
			internal ComputeBufferHandle tileInstanceIndices; // 0x420
			internal GraphicsBuffer quadIndexBuffer; // 0x428
		}
	
		private class LightCullingPassData // TypeDefIndex: 37779
		{
			// Fields
			public HGCamera hgCamera; // 0x10
			public TextureHandle depthTexture; // 0x18
			public LightCulling lightCulling; // 0x28
			public ComputeBufferHandle binningBuffer; // 0x30
			public float renderingScale; // 0x38
	
			// Constructors
			public LightCullingPassData() {} // 0x00000001841E1670-0x00000001841E1680
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
		public LightClusteringPassConstructor() {} // 0x00000001841A2850-0x00000001841A2950
		// LightClusteringPassConstructor()
		void HG::Rendering::Runtime::LightClusteringPassConstructor::LightClusteringPassConstructor(
		        LightClusteringPassConstructor *this,
		        MethodInfo *method)
		{
		  NativeArray_1_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_ v3; // xmm0
		  NativeArray_1_System_Single_ v4; // xmm0
		  LightCullingGPU *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  LightCulling *v8; // rdi
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  NativeArray_1_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_ v12; // [rsp+30h] [rbp-18h] BYREF
		  MethodInfo *v13; // [rsp+70h] [rbp+28h]
		
		  v12 = 0LL;
		  Unity::Collections::NativeArray<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>::NativeArray(
		    &v12,
		    256,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>::NativeArray);
		  v3 = v12;
		  this->fields.m_directionalLightIndex = -1;
		  this->fields.m_punctualLightSortArray = v3;
		  v12 = 0LL;
		  Unity::Collections::NativeArray<int>::NativeArray(
		    (NativeArray_1_System_Int32_ *)&v12,
		    256,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<int>::NativeArray);
		  this->fields.m_punctualLightIndices = (NativeArray_1_System_Int32_)v12;
		  v12 = 0LL;
		  Unity::Collections::NativeArray<float>::NativeArray(
		    (NativeArray_1_System_Single_ *)&v12,
		    256,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<float>::NativeArray);
		  v4 = (NativeArray_1_System_Single_)v12;
		  this->fields.m_punctualLightCount = 0;
		  this->fields.m_punctualLightDistances = v4;
		  v5 = (LightCullingGPU *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::LightCullingGPU);
		  v8 = (LightCulling *)v5;
		  if ( !v5 )
		    sub_1800D8260(v7, v6);
		  HG::Rendering::Runtime::LightCullingGPU::LightCullingGPU(v5, 0LL);
		  this->fields.m_lightCulling = v8;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_lightCulling, v9, v10, v11, v13);
		}
		
		static LightClusteringPassConstructor() {} // 0x0000000184D2CBB0-0x0000000184D2CC40
		// LightClusteringPassConstructor()
		void HG::Rendering::Runtime::LightClusteringPassConstructor::cctor(MethodInfo *method)
		{
		  struct LightClusteringPassConstructor_c__Class *v1; // rax
		  Object *v2; // rdi
		  RenderFunc_1_System_Object_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  RenderFunc_1_HG_Rendering_Runtime_LightClusteringPassConstructor_LightCullingPassData_ *v6; // rbx
		  HGRuntimeGrassQuery_Node *v7; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		
		  v1 = TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor::__c;
		  if ( !TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor::__c->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor::__c);
		    v1 = TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor::__c;
		  }
		  v2 = (Object *)v1->static_fields->__9;
		  v3 = (RenderFunc_1_System_Object_ *)sub_1800368D0(TypeInfo::HG::Rendering::RenderGraphModule::RenderFunc<HG::Rendering::Runtime::LightClusteringPassConstructor::LightCullingPassData>);
		  v6 = (RenderFunc_1_HG_Rendering_Runtime_LightClusteringPassConstructor_LightCullingPassData_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::RenderGraphModule::RenderFunc<System::Object>::RenderFunc(
		    v3,
		    v2,
		    MethodInfo::HG::Rendering::Runtime::LightClusteringPassConstructor::__c::__cctor_b__28_0,
		    0LL);
		  TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor->static_fields->s_lightCullingRenderFunc = v6;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor->static_fields,
		    v7,
		    v8,
		    v9,
		    v10);
		}
		
	
		// Methods
		public void SetupState(CullingResults cullingResults, LightCullResult lightCullResult, HGCamera camera, HGSettingParameters settingParameters) {} // 0x0000000189D09F50-0x0000000189D0A32C
		// Void SetupState(CullingResults, LightCullResult, HGCamera, HGSettingParameters)
		void HG::Rendering::Runtime::LightClusteringPassConstructor::SetupState(
		        LightClusteringPassConstructor *this,
		        CullingResults *cullingResults,
		        LightCullResult *lightCullResult,
		        HGCamera *camera,
		        HGSettingParameters *settingParameters,
		        MethodInfo *method)
		{
		  HGCamera *v8; // r14
		  __m128i v10; // xmm6
		  int32_t v11; // r9d
		  int v12; // r12d
		  __int64 v13; // rdx
		  Component *shadowManager; // rcx
		  Transform *transform; // rax
		  Vector3 *position; // rax
		  MethodInfo *v17; // r9
		  __int64 v18; // xmm6_8
		  int32_t v19; // r15d
		  __int64 v20; // rsi
		  Void *m_Buffer; // rdi
		  __int64 v22; // r13
		  float z; // r14d
		  LightClusteringPassConstructor_PunctualLightSortStruct__StaticFields *static_fields; // rcx
		  Void *v25; // rax
		  int32_t priority; // edx
		  float v27; // eax
		  Vector3 *v28; // rax
		  uint64_t v29; // xmm3_8
		  MethodInfo *v30; // rdx
		  float sqrMagnitude; // xmm0_4
		  Void *v32; // rax
		  int v33; // ecx
		  __int64 m_Length; // rsi
		  __int64 v35; // rdi
		  LightClusteringPassConstructor_PunctualLightSortStruct__StaticFields *v36; // rcx
		  Void *v37; // rax
		  int32_t v38; // edx
		  Void *v39; // r9
		  __int64 v40; // r8
		  int v41; // eax
		  Int32Enum__Enum v42; // eax
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ m_visibleLights; // xmm1
		  CullingResults v44; // xmm1
		  Vector3 v45; // [rsp+58h] [rbp-49h] BYREF
		  Vector3 v46; // [rsp+68h] [rbp-39h] BYREF
		  JobHandle v47; // [rsp+78h] [rbp-29h] BYREF
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ v48; // [rsp+88h] [rbp-19h] BYREF
		  __m128i m_punctualLightSortArray; // [rsp+98h] [rbp-9h] BYREF
		  JobHandle v50; // [rsp+A8h] [rbp+7h] BYREF
		
		  v8 = camera;
		  if ( !IFix::WrappersManagerImpl::IsPatched(1937, 0LL) )
		  {
		    Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::ConvertExistingDataToNativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>(
		      (NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ *)&m_punctualLightSortArray,
		      (Void *)lightCullResult->visibleLightsPtr,
		      lightCullResult->visibleLightCount,
		      Allocator__Enum_None,
		      MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::ConvertExistingDataToNativeArray<UnityEngine::Rendering::VisibleLight>);
		    v10 = m_punctualLightSortArray;
		    v11 = _mm_cvtsi128_si32(_mm_srli_si128(m_punctualLightSortArray, 8));
		    if ( v11 > 256 )
		      v11 = 256;
		    Unity::Collections::NativeArray<Beyond::Gameplay::Core::PointQuerySystem::PQSJobData>::GetSubArray(
		      (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&v48,
		      (NativeArray_1_Beyond_Gameplay_Core_PointQuerySystem_PQSJobData_ *)&m_punctualLightSortArray,
		      0,
		      v11,
		      MethodInfo::Unity::Collections::NativeArray<UnityEngine::Rendering::VisibleLight>::GetSubArray);
		    this->fields.m_visibleLights = v48;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
		    m_punctualLightSortArray = v10;
		    v12 = 0;
		    this->fields.m_directionalLightIndex = HG::Rendering::Runtime::LightClusteringPassConstructor::GetDirectionalLightIndex(
		                                             (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&m_punctualLightSortArray,
		                                             0LL);
		    if ( v8 )
		    {
		      shadowManager = (Component *)v8->fields.camera;
		      if ( shadowManager )
		      {
		        transform = UnityEngine::Component::get_transform(shadowManager, 0LL);
		        if ( transform )
		        {
		          position = UnityEngine::Transform::get_position((Vector3 *)&v48, transform, 0LL);
		          v18 = *(_QWORD *)&position->x;
		          v19 = 0;
		          if ( this->fields.m_visibleLights.m_Length > 0 )
		          {
		            v20 = 0LL;
		            m_Buffer = this->fields.m_visibleLights.m_Buffer;
		            v22 = 0LL;
		            z = position->z;
		            do
		            {
		              if ( *(_DWORD *)m_Buffer == 2 || !*(_DWORD *)m_Buffer )
		              {
		                ++v12;
		                *(_DWORD *)&this->fields.m_punctualLightIndices.m_Buffer[v22] = v19;
		                v22 += 4LL;
		                v27 = *(float *)&m_Buffer[124];
		                *(_QWORD *)&v46.x = *(_QWORD *)&m_Buffer[116];
		                *(_QWORD *)&v45.x = v18;
		                v45.z = z;
		                v46.z = v27;
		                v28 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&m_punctualLightSortArray, &v46, &v45, v17);
		                v29 = *(_QWORD *)&v28->x;
		                *(float *)&v28 = v28->z;
		                v47.jobGroup = v29;
		                v47.jobType = (int)v28;
		                LODWORD(v48.m_Buffer) = v19;
		                sqrMagnitude = UnityEngine::Vector3::get_sqrMagnitude((Vector3 *)&v47, v30);
		                v32 = this->fields.m_punctualLightSortArray.m_Buffer;
		                v33 = *(_DWORD *)&m_Buffer[112];
		                *((float *)&v48.m_Buffer + 1) = sqrMagnitude;
		                *(_QWORD *)&v32[v20] = v48.m_Buffer;
		                *(_DWORD *)&v32[v20 + 8] = v33;
		              }
		              else
		              {
		                sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct);
		                static_fields = TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct->static_fields;
		                v25 = this->fields.m_punctualLightSortArray.m_Buffer;
		                priority = static_fields->INVALID_LIGHT.priority;
		                *(_QWORD *)&v25[v20] = *(_QWORD *)&static_fields->INVALID_LIGHT.index;
		                *(_DWORD *)&v25[v20 + 8] = priority;
		              }
		              ++v19;
		              m_Buffer += 148;
		              v20 += 12LL;
		            }
		            while ( v19 < this->fields.m_visibleLights.m_Length );
		            v8 = camera;
		          }
		          m_Length = this->fields.m_visibleLights.m_Length;
		          if ( (int)m_Length < this->fields.m_punctualLightSortArray.m_Length )
		          {
		            v35 = 12 * m_Length;
		            do
		            {
		              sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct);
		              LODWORD(m_Length) = m_Length + 1;
		              v36 = TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct->static_fields;
		              v37 = this->fields.m_punctualLightSortArray.m_Buffer;
		              v38 = v36->INVALID_LIGHT.priority;
		              *(_QWORD *)&v37[v35] = *(_QWORD *)&v36->INVALID_LIGHT.index;
		              *(_DWORD *)&v37[v35 + 8] = v38;
		              v35 += 12LL;
		            }
		            while ( (int)m_Length < this->fields.m_punctualLightSortArray.m_Length );
		          }
		          m_punctualLightSortArray = (__m128i)this->fields.m_punctualLightSortArray;
		          Unity::Collections::NativeSortExtension::SortJob<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>(
		            (SortJob_2_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_NativeSortExtension_DefaultComparer_1_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_ *)&v48,
		            (NativeArray_1_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_ *)&m_punctualLightSortArray,
		            MethodInfo::Unity::Collections::NativeSortExtension::SortJob<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>);
		          v50 = 0LL;
		          m_punctualLightSortArray = 0LL;
		          Unity::Collections::SortJob<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct,Unity::Collections::NativeSortExtension::DefaultComparer<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>>::Schedule(
		            &v47,
		            (SortJob_2_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_NativeSortExtension_DefaultComparer_1_HG_Rendering_Runtime_LightClusteringPassConstructor_PunctualLightSortStruct_ *)&v48,
		            (JobHandle *)&m_punctualLightSortArray,
		            MethodInfo::Unity::Collections::SortJob<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct,Unity::Collections::NativeSortExtension::DefaultComparer<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>>::Schedule);
		          v50 = v47;
		          Unity::Jobs::JobHandle::Complete(&v50, 0LL);
		          if ( v12 > 0 )
		          {
		            v39 = this->fields.m_punctualLightSortArray.m_Buffer;
		            v13 = 0LL;
		            v40 = 0LL;
		            do
		            {
		              v41 = *(_DWORD *)&v39[v40];
		              v40 += 12LL;
		              *(_DWORD *)&this->fields.m_punctualLightIndices.m_Buffer[4 * v13] = v41;
		              v39 = this->fields.m_punctualLightSortArray.m_Buffer;
		              shadowManager = (Component *)this->fields.m_punctualLightDistances.m_Buffer;
		              *((_DWORD *)&shadowManager->klass + v13++) = *(_DWORD *)&v39[v40 - 8];
		            }
		            while ( v13 < v12 );
		          }
		          if ( settingParameters )
		          {
		            v42 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		                    (SettingParameter_1_System_Int32Enum_ *)settingParameters->fields._punctualLightMaxCount_k__BackingField,
		                    MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		            if ( v12 < (int)v42 )
		              v42 = v12;
		            this->fields.m_punctualLightCount = v42;
		            shadowManager = (Component *)v8->fields.shadowManager;
		            if ( shadowManager )
		            {
		              shadowManager = (Component *)shadowManager[15].klass;
		              if ( shadowManager )
		              {
		                m_visibleLights = this->fields.m_visibleLights;
		                m_punctualLightSortArray = (__m128i)this->fields.m_punctualLightIndices;
		                v48 = m_visibleLights;
		                HG::Rendering::Runtime::HGPunctualLightShadowManagerV2::PreparePunctualLightShadowCasters(
		                  (HGPunctualLightShadowManagerV2 *)shadowManager,
		                  &v48,
		                  v8,
		                  settingParameters,
		                  (NativeArray_1_System_Int32_ *)&m_punctualLightSortArray,
		                  v42,
		                  0LL);
		                shadowManager = (Component *)this->fields.m_lightCulling;
		                if ( shadowManager )
		                {
		                  HG::Rendering::Runtime::LightCulling::FrameSetup((LightCulling *)shadowManager, v8, 0LL);
		                  return;
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_29:
		    sub_1800D8260(shadowManager, v13);
		  }
		  shadowManager = (Component *)IFix::WrappersManagerImpl::GetPatch(1937, 0LL);
		  if ( !shadowManager )
		    goto LABEL_29;
		  v44 = *cullingResults;
		  m_punctualLightSortArray = *(__m128i *)lightCullResult;
		  v48 = (NativeArray_1_UnityEngine_Rendering_VisibleLight_)v44;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_786(
		    (ILFixDynamicMethodWrapper_2 *)shadowManager,
		    (Object *)this,
		    (CullingResults *)&v48,
		    (LightCullResult *)&m_punctualLightSortArray,
		    (Object *)v8,
		    (Object *)settingParameters,
		    0LL);
		}
		
		private static int GetDirectionalLightIndex(NativeArray<VisibleLight> visibleLights) => default; // 0x0000000189D09C44-0x0000000189D09E54
		// Int32 GetDirectionalLightIndex(NativeArray`1[UnityEngine.Rendering.VisibleLight])
		int32_t HG::Rendering::Runtime::LightClusteringPassConstructor::GetDirectionalLightIndex(
		        NativeArray_1_UnityEngine_Rendering_VisibleLight_ *visibleLights,
		        MethodInfo *method)
		{
		  int32_t v3; // esi
		  int32_t v4; // edi
		  Object_1 *SunSourceLight; // rbp
		  float intensity_Injected; // xmm6_4
		  int32_t m_Length; // r15d
		  Void *i; // rbx
		  int v9; // eax
		  __int128 v10; // xmm1
		  __int128 v11; // xmm0
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ v18; // xmm1
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ v19; // xmm0
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ v20; // xmm1
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ v21; // xmm0
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ v22; // xmm1
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ v23; // xmm0
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ v24; // xmm1
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ v25; // xmm0
		  __int64 v26; // rdx
		  __int64 v27; // rcx
		  int32_t instanceID_Injected; // r14d
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ v31[10]; // [rsp+20h] [rbp-188h] BYREF
		  int v32; // [rsp+C0h] [rbp-E8h]
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ v33; // [rsp+D0h] [rbp-D8h]
		  __int128 v34; // [rsp+E0h] [rbp-C8h]
		  __int128 v35; // [rsp+F0h] [rbp-B8h]
		  __int128 v36; // [rsp+100h] [rbp-A8h]
		  __int128 v37; // [rsp+110h] [rbp-98h]
		  __int128 v38; // [rsp+120h] [rbp-88h]
		  __int128 v39; // [rsp+130h] [rbp-78h]
		  __int128 v40; // [rsp+140h] [rbp-68h]
		  __int128 v41; // [rsp+150h] [rbp-58h]
		  int v42; // [rsp+160h] [rbp-48h]
		  HGSharedLightData _unity_self; // [rsp+1C0h] [rbp+18h] BYREF
		
		  _unity_self = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1938, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1938, 0LL);
		    if ( !Patch )
		LABEL_16:
		      sub_1800D8260(v27, v26);
		    v31[0] = *visibleLights;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_780(Patch, v31, 0LL);
		  }
		  else
		  {
		    if ( visibleLights->m_Length )
		    {
		      v3 = -1;
		      v4 = 0;
		      SunSourceLight = (Object_1 *)UnityEngine::Light::GetSunSourceLight(0LL);
		      intensity_Injected = 0.0;
		      if ( visibleLights->m_Length <= 0 )
		        return v3;
		      m_Length = visibleLights->m_Length;
		      for ( i = visibleLights->m_Buffer; ; i += 148 )
		      {
		        v9 = *(_DWORD *)&i[144];
		        v10 = *(_OWORD *)&i[16];
		        v33 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)i;
		        v11 = *(_OWORD *)&i[32];
		        v34 = v10;
		        v12 = *(_OWORD *)&i[48];
		        v35 = v11;
		        v13 = *(_OWORD *)&i[64];
		        v36 = v12;
		        v14 = *(_OWORD *)&i[80];
		        v37 = v13;
		        v15 = *(_OWORD *)&i[96];
		        v38 = v14;
		        v16 = *(_OWORD *)&i[112];
		        v39 = v15;
		        v17 = *(_OWORD *)&i[128];
		        v40 = v16;
		        v18 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&i[16];
		        v41 = v17;
		        v42 = v9;
		        v31[1] = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)i;
		        v19 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&i[32];
		        v31[2] = v18;
		        v20 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&i[48];
		        v31[3] = v19;
		        v21 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&i[64];
		        v31[4] = v20;
		        v22 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&i[80];
		        v31[5] = v21;
		        v23 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&i[96];
		        v31[6] = v22;
		        v24 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&i[112];
		        v31[7] = v23;
		        v25 = *(NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&i[128];
		        v31[8] = v24;
		        v31[9] = v25;
		        v32 = v9;
		        _unity_self = *(HGSharedLightData *)&v25.m_Length;
		        if ( LODWORD(v33.m_Buffer) == 1 )
		        {
		          sub_1800036A0(TypeInfo::UnityEngine::Object);
		          if ( UnityEngine::Object::op_Inequality(SunSourceLight, 0LL, 0LL) )
		          {
		            instanceID_Injected = UnityEngine::HGSharedLightData::get_instanceID_Injected(&_unity_self, 0LL);
		            if ( !SunSourceLight )
		              goto LABEL_16;
		            if ( instanceID_Injected == UnityEngine::Object::GetInstanceID(SunSourceLight, 0LL) )
		              return v4;
		          }
		          if ( UnityEngine::HGSharedLightData::get_intensity_Injected(&_unity_self, 0LL) > intensity_Injected )
		          {
		            intensity_Injected = UnityEngine::HGSharedLightData::get_intensity_Injected(&_unity_self, 0LL);
		            v3 = v4;
		          }
		        }
		        if ( ++v4 >= m_Length )
		          return v3;
		      }
		    }
		    return -1;
		  }
		}
		
		internal void TryGetDirectionalLightDir(ref Vector4 lightDir, HGCamera camera) {} // 0x0000000189D0A37C-0x0000000189D0A5B8
		// Void TryGetDirectionalLightDir(Vector4 ByRef, HGCamera)
		void HG::Rendering::Runtime::LightClusteringPassConstructor::TryGetDirectionalLightDir(
		        LightClusteringPassConstructor *this,
		        Vector4 *lightDir,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  HGEnvironmentVolumeCameraComponent *envVolumeCameraComponent; // rbp
		  Void *v10; // rax
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  Light *light; // rax
		  HGEnvironmentVolumeCameraComponent *v20; // rax
		  HGEnvironmentPhase *interpolatedPhase; // rax
		  __int64 v22; // xmm0_8
		  float z; // ecx
		  Void *v24; // rax
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  __int128 v32; // xmm0
		  Vector3 *Forward; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v35; // [rsp+40h] [rbp-B8h] BYREF
		  VisibleLight v36; // [rsp+50h] [rbp-A8h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1959, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1959, 0LL);
		    if ( !Patch )
		      goto LABEL_13;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_787(Patch, (Object *)this, lightDir, (Object *)camera, 0LL);
		  }
		  else if ( this->fields.m_directionalLightIndex >= 0
		         && this->fields.m_directionalLightIndex < this->fields.m_visibleLights.m_Length )
		  {
		    if ( camera )
		    {
		      envVolumeCameraComponent = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(camera, 0LL);
		      v10 = &this->fields.m_visibleLights.m_Buffer[148 * this->fields.m_directionalLightIndex];
		      v11 = *(_OWORD *)&v10[16];
		      *(_OWORD *)&v36.m_LightType = *(_OWORD *)v10;
		      v12 = *(_OWORD *)&v10[32];
		      *(_OWORD *)&v36.m_FinalColor.a = v11;
		      v13 = *(_OWORD *)&v10[48];
		      *(_OWORD *)&v36.m_ScreenRect.m_Height = v12;
		      v14 = *(_OWORD *)&v10[64];
		      *(_OWORD *)&v36.m_LocalToWorldMatrix.m30 = v13;
		      v15 = *(_OWORD *)&v10[80];
		      *(_OWORD *)&v36.m_LocalToWorldMatrix.m31 = v14;
		      v16 = *(_OWORD *)&v10[96];
		      *(_OWORD *)&v36.m_LocalToWorldMatrix.m32 = v15;
		      v17 = *(_OWORD *)&v10[128];
		      *(_OWORD *)&v36.m_LocalToWorldMatrix.m33 = v16;
		      v18 = *(_OWORD *)&v10[112];
		      LODWORD(v10) = *(_DWORD *)&v10[144];
		      *(_OWORD *)&v36.m_LightPriority = v18;
		      *(_OWORD *)&v36.m_InstanceId = v17;
		      LODWORD(v36.m_ScreenSpaceArea) = (_DWORD)v10;
		      light = UnityEngine::Rendering::VisibleLight::get_light(&v36, 0LL);
		      if ( envVolumeCameraComponent )
		      {
		        if ( !HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::UseDirLightDataFromEnvDirectly(
		                envVolumeCameraComponent,
		                light,
		                0LL) )
		        {
		          v24 = &this->fields.m_visibleLights.m_Buffer[148 * this->fields.m_directionalLightIndex];
		          v25 = *(_OWORD *)&v24[16];
		          *(_OWORD *)&v36.m_LightType = *(_OWORD *)v24;
		          v26 = *(_OWORD *)&v24[32];
		          *(_OWORD *)&v36.m_FinalColor.a = v25;
		          v27 = *(_OWORD *)&v24[48];
		          *(_OWORD *)&v36.m_ScreenRect.m_Height = v26;
		          v28 = *(_OWORD *)&v24[64];
		          *(_OWORD *)&v36.m_LocalToWorldMatrix.m30 = v27;
		          v29 = *(_OWORD *)&v24[80];
		          *(_OWORD *)&v36.m_LocalToWorldMatrix.m31 = v28;
		          v30 = *(_OWORD *)&v24[96];
		          *(_OWORD *)&v36.m_LocalToWorldMatrix.m32 = v29;
		          v31 = *(_OWORD *)&v24[112];
		          *(_OWORD *)&v36.m_LocalToWorldMatrix.m33 = v30;
		          v32 = *(_OWORD *)&v24[128];
		          LODWORD(v24) = *(_DWORD *)&v24[144];
		          *(_OWORD *)&v36.m_LightPriority = v31;
		          *(_OWORD *)&v36.m_InstanceId = v32;
		          LODWORD(v36.m_ScreenSpaceArea) = (_DWORD)v24;
		          Forward = HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward(&v35, &v36, 0LL);
		          v22 = *(_QWORD *)&Forward->x;
		          z = Forward->z;
		          goto LABEL_11;
		        }
		        v20 = HG::Rendering::Runtime::HGCamera::get_envVolumeCameraComponent(camera, 0LL);
		        if ( v20 )
		        {
		          interpolatedPhase = HG::Rendering::Runtime::HGEnvironmentVolumeCameraComponent::get_interpolatedPhase(
		                                v20,
		                                0LL);
		          if ( interpolatedPhase )
		          {
		            v22 = *(_QWORD *)&interpolatedPhase->fields.lightConfig.forwardDirect.x;
		            z = interpolatedPhase->fields.lightConfig.forwardDirect.z;
		LABEL_11:
		            lightDir->x = -*(float *)&v22;
		            lightDir->z = -z;
		            lightDir->y = -*((float *)&v22 + 1);
		            return;
		          }
		        }
		      }
		    }
		LABEL_13:
		    sub_1800D8260(v8, v7);
		  }
		}
		
		void IPassConstructor.PrepareShaderVariablesGlobal(ref ShaderVariablesGlobal shaderVariablesGlobal) {} // 0x0000000189D09EFC-0x0000000189D09F50
		// Void HG.Rendering.Runtime.IPassConstructor.PrepareShaderVariablesGlobal(ShaderVariablesGlobal ByRef)
		void HG::Rendering::Runtime::LightClusteringPassConstructor::HG_Rendering_Runtime_IPassConstructor_PrepareShaderVariablesGlobal(
		        LightClusteringPassConstructor *this,
		        ShaderVariablesGlobal *shaderVariablesGlobal,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1960, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1960, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_378(Patch, (Object *)this, shaderVariablesGlobal, 0LL);
		  }
		}
		
		void IPassConstructor.OnPreRendering(ref PassEventInput input) {} // 0x0000000189D09EA8-0x0000000189D09EFC
		// Void HG.Rendering.Runtime.IPassConstructor.OnPreRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::LightClusteringPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPreRendering(
		        LightClusteringPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1961, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1961, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		internal void ConstructPass(ref PassInput input, ref PassOutput output, HGRenderGraph renderGraph, HGCamera camera) {} // 0x0000000189D095D0-0x0000000189D09C44
		// Void ConstructPass(LightClusteringPassConstructor+PassInput ByRef, LightClusteringPassConstructor+PassOutput ByRef, HGRenderGraph, HGCamera)
		// Hidden C++ exception states: #wind=1
		void HG::Rendering::Runtime::LightClusteringPassConstructor::ConstructPass(
		        LightClusteringPassConstructor *this,
		        LightClusteringPassConstructor_PassInput *input,
		        LightClusteringPassConstructor_PassOutput *output,
		        HGRenderGraph *renderGraph,
		        HGCamera *camera,
		        MethodInfo *method)
		{
		  LightClusteringPassConstructor_PassOutput *v7; // r14
		  LightClusteringPassConstructor *v9; // rdi
		  HGSettingParameters *settingParams; // rax
		  HGCamera *v11; // r13
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  HGLightCookieManager *lightCookieManager; // rsi
		  CullingResults m_visibleLights; // xmm6
		  HGSettingParameters *v16; // rax
		  __int64 m_punctualLightCount; // rcx
		  ProfilingSampler *v18; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  __int64 v21; // rcx
		  Object *v22; // rdx
		  unsigned int v23; // edx
		  unsigned __int64 v24; // r8
		  char v25; // dl
		  signed __int64 v26; // rtt
		  LightCulling *m_lightCulling; // r12
		  __int128 v28; // xmm6
		  HGRenderGraph *v29; // xmm7_8
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ v30; // xmm8
		  int32_t m_directionalLightIndex; // r9d
		  int32_t v32; // r10d
		  __int64 m_lightMaskSpotOrPointWithoutOBB; // rcx
		  __int64 m_lightMaskLinearWithOBB; // rdx
		  uint32_t m_lightMaskLinearWithoutOBB; // r8d
		  __int64 v36; // rdx
		  LightCulling *v37; // rcx
		  __int64 v38; // rdx
		  __int64 v39; // rcx
		  LightCulling *v40; // r12
		  __int128 v41; // xmm6
		  __int128 v42; // xmm7
		  LightCulling__Class *klass; // r9
		  const MethodInfo *v44; // rax
		  __int64 v45; // rcx
		  Object *v46; // rdx
		  unsigned int v47; // edx
		  unsigned __int64 v48; // r8
		  char v49; // dl
		  signed __int64 v50; // rtt
		  ComputeBufferHandle *v51; // r12
		  ComputeBufferHandle v52; // rax
		  ComputeBufferHandle v53; // rdx
		  ComputeBufferHandle v54; // rcx
		  __int64 v55; // rdx
		  int32_t v56; // r8d
		  LightClusteringPassConstructor_PassOutput *v57; // r9
		  LightCulling *v58; // rcx
		  unsigned __int64 v59; // r8
		  signed __int64 v60; // rtt
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v62; // rdx
		  __int64 v63; // rcx
		  int32_t uintCount; // [rsp+50h] [rbp-128h]
		  CullingResults cullingResults; // [rsp+60h] [rbp-118h] BYREF
		  Object *v66; // [rsp+70h] [rbp-108h] BYREF
		  LightCullResult lightCullResult; // [rsp+80h] [rbp-F8h] BYREF
		  LightClusteringPassConstructor_PassOutput *v68; // [rsp+90h] [rbp-E8h]
		  HGRenderGraphBuilder v69; // [rsp+A0h] [rbp-D8h] BYREF
		  NativeArray_1_System_Single_ v70; // [rsp+C0h] [rbp-B8h] BYREF
		  NativeArray_1_System_Int32_ v71; // [rsp+D0h] [rbp-A8h] BYREF
		  HGRenderGraphBuilder v72; // [rsp+E0h] [rbp-98h] BYREF
		  Il2CppExceptionWrapper *v73; // [rsp+100h] [rbp-78h] BYREF
		  NativeArray_1_UnityEngine_Rendering_VisibleLight_ v74; // [rsp+110h] [rbp-68h] BYREF
		
		  v7 = output;
		  v9 = this;
		  v68 = output;
		  v66 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1962, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1962, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v63, v62);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_789(
		      Patch,
		      (Object *)v9,
		      input,
		      v7,
		      (Object *)renderGraph,
		      (Object *)camera,
		      0LL);
		  }
		  else
		  {
		    settingParams = input->settingParams;
		    lightCullResult = input->lightCullResult;
		    cullingResults = input->cullingResults;
		    v11 = camera;
		    HG::Rendering::Runtime::LightClusteringPassConstructor::SetupState(
		      v9,
		      &cullingResults,
		      &lightCullResult,
		      camera,
		      settingParams,
		      0LL);
		    if ( !camera )
		      sub_1800D8260(v13, v12);
		    lightCookieManager = camera->fields.lightCookieManager;
		    m_visibleLights = (CullingResults)v9->fields.m_visibleLights;
		    v16 = input->settingParams;
		    m_punctualLightCount = (unsigned int)v9->fields.m_punctualLightCount;
		    if ( !lightCookieManager )
		      sub_1800D8260(m_punctualLightCount, v12);
		    lightCullResult = (LightCullResult)v9->fields.m_punctualLightIndices;
		    cullingResults = m_visibleLights;
		    HG::Rendering::Runtime::HGLightCookieManager::UpdateLightCookieAtlas(
		      lightCookieManager,
		      renderGraph,
		      (NativeArray_1_UnityEngine_Rendering_VisibleLight_ *)&cullingResults,
		      camera,
		      v16,
		      (NativeArray_1_System_Int32_ *)&lightCullResult,
		      m_punctualLightCount,
		      0LL);
		    v18 = UnityEngine::Rendering::ProfilingSampler::Get<System::Int32Enum>(
		            (Int32Enum__Enum)0x70u,
		            MethodInfo::UnityEngine::Rendering::ProfilingSampler::Get<HG::Rendering::Runtime::HGProfileId>);
		    if ( !renderGraph )
		      sub_1800D8260(v20, v19);
		    HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<System::Object>(
		      &v69,
		      renderGraph,
		      (String *)"Compute GPU Light Buffers",
		      &v66,
		      v18,
		      1,
		      ProfilingHGPass__Enum_None,
		      MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraph::AddRenderPass<HG::Rendering::Runtime::LightClusteringPassConstructor::LightCullingPassData>);
		    v72 = v69;
		    lightCullResult.visibleLightsPtr = 0LL;
		    *(_QWORD *)&lightCullResult.visibleLightCount = &v72;
		    try
		    {
		      v22 = v66;
		      if ( !v66 )
		        sub_1800D8250(v21, 0LL);
		      v66[1].klass = (Object__Class *)camera;
		      if ( dword_18F35FD08 )
		      {
		        v23 = ((unsigned __int64)&v22[1] >> 12) & 0x1FFFFF;
		        v24 = (unsigned __int64)v23 >> 6;
		        v25 = v23 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v24 + 36190]);
		        do
		          v26 = qword_18F0BCBA0[v24 + 36190];
		        while ( v26 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v24 + 36190], v26 | (1LL << v25), v26) );
		      }
		      m_lightCulling = v9->fields.m_lightCulling;
		      v28 = *(_OWORD *)&input->binningData.tileSize;
		      v29 = *(HGRenderGraph **)&input->binningData.xyOffset;
		      uintCount = input->binningData.uintCount;
		      v30 = v9->fields.m_visibleLights;
		      Unity::Collections::NativeArray<MagicaCloth::TwistConstraint::TwistData>::GetSubArray(
		        (NativeArray_1_MagicaCloth_TwistConstraint_TwistData_ *)&v71,
		        (NativeArray_1_MagicaCloth_TwistConstraint_TwistData_ *)&v9->fields.m_punctualLightIndices,
		        0,
		        v9->fields.m_punctualLightCount,
		        MethodInfo::Unity::Collections::NativeArray<int>::GetSubArray);
		      Unity::Collections::NativeArray<MagicaCloth::TwistConstraint::TwistData>::GetSubArray(
		        (NativeArray_1_MagicaCloth_TwistConstraint_TwistData_ *)&v70,
		        (NativeArray_1_MagicaCloth_TwistConstraint_TwistData_ *)&v9->fields.m_punctualLightDistances,
		        0,
		        v9->fields.m_punctualLightCount,
		        MethodInfo::Unity::Collections::NativeArray<float>::GetSubArray);
		      m_directionalLightIndex = v9->fields.m_directionalLightIndex;
		      v32 = v9->fields.m_punctualLightCount;
		      m_lightMaskSpotOrPointWithoutOBB = v9->fields.m_lightMaskSpotOrPointWithoutOBB;
		      m_lightMaskLinearWithOBB = v9->fields.m_lightMaskLinearWithOBB;
		      m_lightMaskLinearWithoutOBB = v9->fields.m_lightMaskLinearWithoutOBB;
		      LODWORD(cullingResults.ptr) = v9->fields.m_lightMaskSpotOrPointWithOBB;
		      HIDWORD(cullingResults.ptr) = m_lightMaskSpotOrPointWithoutOBB;
		      cullingResults.m_AllocationInfo = (CullingAllocationInfo *)__PAIR64__(
		                                                                   m_lightMaskLinearWithoutOBB,
		                                                                   m_lightMaskLinearWithOBB);
		      if ( !m_lightCulling )
		        sub_1800D8250(m_lightMaskSpotOrPointWithoutOBB, m_lightMaskLinearWithOBB);
		      v74 = v30;
		      *(_OWORD *)&v69.m_RenderPass = v28;
		      v69.m_RenderGraph = v29;
		      *(_DWORD *)&v69.m_Disposed = uintCount;
		      HG::Rendering::Runtime::LightCulling::PrepareCPUData(
		        m_lightCulling,
		        camera,
		        (BinningPass_BinningData *)&v69,
		        &v74,
		        &v71,
		        &v70,
		        m_directionalLightIndex,
		        v32,
		        (uint4 *)&cullingResults,
		        0LL);
		      v37 = v9->fields.m_lightCulling;
		      if ( !v37 )
		        sub_1800D8250(0LL, v36);
		      HG::Rendering::Runtime::LightCulling::SetOuputTileDrawBuffers(v37, input->outputTileResult, 0LL);
		      v40 = v9->fields.m_lightCulling;
		      if ( !v40 )
		        sub_1800D8250(v39, v38);
		      v41 = *(_OWORD *)&v72.m_RenderPass;
		      v42 = *(_OWORD *)&v72.m_RenderGraph;
		      sub_1800049A0(v40->klass);
		      klass = v40->klass;
		      v44 = v40->klass->vtable.PrepareRenderGraphBuffers.method;
		      *(_OWORD *)&v69.m_RenderPass = v41;
		      *(_OWORD *)&v69.m_RenderGraph = v42;
		      ((void (__fastcall *)(LightCulling *, HGRenderGraph *, HGRenderGraphBuilder *, Il2CppMethodPointer))v44)(
		        v40,
		        renderGraph,
		        &v69,
		        klass->vtable.PrepareGPUData.methodPtr);
		      v46 = v66;
		      if ( !v66 )
		        sub_1800D8250(v45, 0LL);
		      v66[2].monitor = (MonitorData *)v9->fields.m_lightCulling;
		      if ( dword_18F35FD08 )
		      {
		        v47 = ((unsigned __int64)&v46[2].monitor >> 12) & 0x1FFFFF;
		        v48 = (unsigned __int64)v47 >> 6;
		        v49 = v47 & 0x3F;
		        _m_prefetchw(&qword_18F0BCBA0[v48 + 36190]);
		        do
		          v50 = qword_18F0BCBA0[v48 + 36190];
		        while ( v50 != _InterlockedCompareExchange64(&qword_18F0BCBA0[v48 + 36190], v50 | (1LL << v49), v50) );
		      }
		      v51 = (ComputeBufferHandle *)v66;
		      v52 = HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::WriteComputeBuffer(&v72, &input->binningBuffer, 0LL);
		      if ( !v51 )
		        ((void (__fastcall __noreturn *)(_QWORD, _QWORD))sub_1800D8250)(v54, v53);
		      v51[6] = v52;
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::AllowPassCulling(&v72, 0, 0LL);
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor);
		      HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<System::Object>(
		        &v72,
		        (RenderFunc_1_System_Object_ *)TypeInfo::HG::Rendering::Runtime::LightClusteringPassConstructor->static_fields->s_lightCullingRenderFunc,
		        0LL,
		        0,
		        MethodInfo::HG::Rendering::RenderGraphModule::HGRenderGraphBuilder::SetRenderFunc<HG::Rendering::Runtime::LightClusteringPassConstructor::LightCullingPassData>);
		    }
		    catch ( Il2CppExceptionWrapper *v73 )
		    {
		      lightCullResult.visibleLightsPtr = v73->ex;
		      sub_180268AE0(&lightCullResult);
		      v11 = camera;
		      v7 = output;
		      v9 = this;
		      goto LABEL_20;
		    }
		    sub_180268AE0(&lightCullResult);
		LABEL_20:
		    HG::Rendering::Runtime::LightClusteringPassConstructor::TryGetDirectionalLightDir(
		      v9,
		      &v7->directionalLightDir,
		      v11,
		      0LL);
		    v7[18].tileInstanceIndices.handle.m_Value = v9->fields.m_directionalLightIndex;
		    v7[18].drawTileArgs.handle._type_k__BackingField = v9->fields.m_punctualLightCount;
		    v56 = 0;
		    if ( v9->fields.m_punctualLightIndices.m_Length > 0 )
		    {
		      v55 = 0LL;
		      v57 = v68;
		      do
		      {
		        *(int32_t *)((char *)&v57->punctualLightIndices.FixedElementField + v55) = *(_DWORD *)&v9->fields.m_punctualLightIndices.m_Buffer[v55];
		        ++v56;
		        v55 += 4LL;
		      }
		      while ( v56 < v9->fields.m_punctualLightIndices.m_Length );
		    }
		    v58 = v9->fields.m_lightCulling;
		    if ( !v58
		      || (*(ComputeBufferHandle *)&v7[18].tileInstanceIndices.handle._type_k__BackingField = HG::Rendering::Runtime::LightCulling::get_DrawTileArgsBufferHandle(
		                                                                                               v58,
		                                                                                               0LL),
		          (v58 = v9->fields.m_lightCulling) == 0LL)
		      || (v7[18].quadIndexBuffer = (GraphicsBuffer *)HG::Rendering::Runtime::LightCulling::get_TileInstanceIndicesBufferHandle(
		                                                       v58,
		                                                       0LL),
		          (v58 = v9->fields.m_lightCulling) == 0LL) )
		    {
		      sub_1800D8250(v58, v55);
		    }
		    *(_QWORD *)&v7[19].directionalLightDir.x = HG::Rendering::Runtime::LightCulling::get_QuadIndexBuffer(v58, 0LL);
		    if ( dword_18F35FD08 )
		    {
		      v59 = (((unsigned __int64)&v7[19] >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F0BCBA0[v59 + 36190]);
		      do
		        v60 = qword_18F0BCBA0[v59 + 36190];
		      while ( v60 != _InterlockedCompareExchange64(
		                       &qword_18F0BCBA0[v59 + 36190],
		                       v60 | (1LL << (((unsigned __int64)&v7[19] >> 12) & 0x3F)),
		                       v60) );
		    }
		  }
		}
		
		void IPassConstructor.OnPostRendering(ref PassEventInput input) {} // 0x0000000189D09E54-0x0000000189D09EA8
		// Void HG.Rendering.Runtime.IPassConstructor.OnPostRendering(PassEventInput ByRef)
		void HG::Rendering::Runtime::LightClusteringPassConstructor::HG_Rendering_Runtime_IPassConstructor_OnPostRendering(
		        LightClusteringPassConstructor *this,
		        PassEventInput *input,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1963, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1963, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, (Object *)this, input, 0LL);
		  }
		}
		
		void IPassConstructor.Dispose(HGRenderGraph renderGraph) {} // 0x0000000184CE1E30-0x0000000184CE1E70
		// Void HG.Rendering.Runtime.IPassConstructor.Dispose(HGRenderGraph)
		void HG::Rendering::Runtime::LightClusteringPassConstructor::HG_Rendering_Runtime_IPassConstructor_Dispose(
		        LightClusteringPassConstructor *this,
		        HGRenderGraph *renderGraph,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1964, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1964, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)renderGraph,
		      0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::LightClusteringPassConstructor::Dispose(this, 0LL);
		  }
		}
		
		void IDisposable.Dispose() {} // 0x0000000189D0A32C-0x0000000189D0A37C
		// Void System.IDisposable.Dispose()
		void HG::Rendering::Runtime::LightClusteringPassConstructor::System_IDisposable_Dispose(
		        LightClusteringPassConstructor *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1966, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1966, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::LightClusteringPassConstructor::Dispose(this, 0LL);
		  }
		}
		
		public void Dispose() {} // 0x0000000184CE1E70-0x0000000184CE1EF0
		// Void Dispose()
		void HG::Rendering::Runtime::LightClusteringPassConstructor::Dispose(
		        LightClusteringPassConstructor *this,
		        MethodInfo *method)
		{
		  __int64 v3; // rcx
		  LightCulling *m_lightCulling; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1965, 0LL) )
		  {
		    Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		      (NativeArray_1_UnityEngine_Vector4_ *)&this->fields.m_punctualLightIndices,
		      MethodInfo::Unity::Collections::NativeArray<int>::Dispose);
		    Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		      (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_ *)&this->fields.m_punctualLightDistances,
		      MethodInfo::Unity::Collections::NativeArray<float>::Dispose);
		    m_lightCulling = this->fields.m_lightCulling;
		    if ( m_lightCulling )
		    {
		      sub_180003290(5LL, m_lightCulling);
		      Unity::Collections::NativeArray<BeyondDynamicBone::TeamManager::TeamData>::Dispose(
		        (NativeArray_1_BeyondDynamicBone_TeamManager_TeamData_ *)&this->fields.m_punctualLightSortArray,
		        MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::LightClusteringPassConstructor::PunctualLightSortStruct>::Dispose);
		      return;
		    }
		LABEL_4:
		    sub_1800D8260(v3, m_lightCulling);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1965, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
	}
}
