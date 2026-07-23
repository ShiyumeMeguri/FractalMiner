using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGInkManager // TypeDefIndex: 37933
	{
		// Fields
		public NativeArray<Vector4> inkDataDynamic; // 0x10
		public NativeArray<Vector4> inkDataConfig; // 0x20
		public const int WATER_INK_DYNAMIC_DATA_VECTOR4_COUNT = 32; // Metadata: 0x0230373E
		public const int WATER_INK_CONFIG_DATA_VECTOR4_COUNT = 12; // Metadata: 0x0230373F
		public bool enabledLastUpdate; // 0x34
		private float[] m_isCharacterGrounded; // 0x38
		private float[] m_isCharacterSpeed; // 0x40
		private float[] m_isCharacterLanding; // 0x48
		private Vector4[] m_isCharacterForwardDir; // 0x50
		private List<InkData> m_inkDataList; // 0x58
	
		// Properties
		internal int LastExtraInkDataCount { get; private set; } // 0x0000000184D864F0-0x0000000184D86500 0x0000000184D86740-0x0000000184D86750
		// Int32 get_maxCapacity()
		int32_t Beyond::PoolCore::ObjectPool<System::Object>::get_maxCapacity(
		        ObjectPool_1_System_Object__3 *this,
		        MethodInfo *method)
		{
		  return this->fields.m_maxCapacity;
		}
		

		// Void set_Count(Int32)
		void UnityEngine::UIElements::UIR::LinkedPool<System::Object>::set_Count(
		        LinkedPool_1_System_Object_ *this,
		        int32_t value,
		        MethodInfo *method)
		{
		  this->fields._Count_k__BackingField = value;
		}
		
		public static HGInkManager instance { get => default; } // 0x0000000189B57FA0-0x0000000189B57FF8 
		// HGInkManager get_instance()
		HGInkManager *HG::Rendering::Runtime::HGInkManager::get_instance(MethodInfo *method)
		{
		  HGInkManager *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2397, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2397, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v4, v3);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_937(Patch, 0LL);
		  }
		  else
		  {
		    result = (HGInkManager *)HG::Rendering::Runtime::HGManagerContext::get_currentManagerContext(0LL);
		    if ( result )
		      return (HGInkManager *)result[2].monitor;
		  }
		  return result;
		}
		
	
		// Nested types
		private struct InkData // TypeDefIndex: 37932
		{
			// Fields
			private Vector2 posXZ; // 0x00
			private Vector2 forceDirection; // 0x08
			private float size; // 0x10
			private float velocityScale; // 0x14
			private float inkColorStrength; // 0x18
	
			// Constructors
			public InkData(Vector2 posXZ, Vector2 forceDirection, float size, float velocityScale, float inkColorStrength) {
				this.posXZ = default;
				this.forceDirection = default;
				this.size = default;
				this.velocityScale = default;
				this.inkColorStrength = default;
			} // 0x0000000184DA1480-0x0000000184DA14B0
			// HGInkManager+InkData(Vector2, Vector2, Single, Single, Single)
			void HG::Rendering::Runtime::HGInkManager::InkData::InkData(
			        HGInkManager_InkData *this,
			        Vector2 posXZ,
			        Vector2 forceDirection,
			        float size,
			        float velocityScale,
			        float inkColorStrength,
			        MethodInfo *method)
			{
			  this->velocityScale = velocityScale;
			  this->inkColorStrength = inkColorStrength;
			  this->size = size;
			  this->posXZ = posXZ;
			  this->forceDirection = forceDirection;
			}
			
	
			// Methods
			public Vector4 GetPack0() => default; // 0x0000000189B5B68C-0x0000000189B5B704
			// Vector4 GetPack0()
			Vector4 *HG::Rendering::Runtime::HGInkManager::InkData::GetPack0(
			        Vector4 *__return_ptr retstr,
			        HGInkManager_InkData *this,
			        MethodInfo *method)
			{
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			  Vector4 v9; // [rsp+20h] [rbp-18h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2340, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2340, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_923(&v9, Patch, this, 0LL);
			  }
			  else
			  {
			    retstr->x = this->posXZ.x;
			    retstr->y = this->posXZ.y;
			    retstr->z = this->forceDirection.x;
			    retstr->w = this->forceDirection.y;
			  }
			  return retstr;
			}
			
			public Vector4 GetPack1() => default; // 0x0000000189B5B704-0x0000000189B5B77C
			// Vector4 GetPack1()
			Vector4 *HG::Rendering::Runtime::HGInkManager::InkData::GetPack1(
			        Vector4 *__return_ptr retstr,
			        HGInkManager_InkData *this,
			        MethodInfo *method)
			{
			  float size; // eax
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v7; // rdx
			  __int64 v8; // rcx
			  Vector4 v10; // [rsp+20h] [rbp-18h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(2341, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(2341, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v8, v7);
			    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_923(&v10, Patch, this, 0LL);
			  }
			  else
			  {
			    size = this->size;
			    retstr->w = 0.0;
			    retstr->x = size;
			    retstr->y = this->velocityScale;
			    retstr->z = this->inkColorStrength;
			  }
			  return retstr;
			}
			
		}
	
		// Constructors
		public HGInkManager() {} // 0x0000000182ED7D30-0x0000000182ED7E70
		// HGInkManager()
		void HG::Rendering::Runtime::HGInkManager::HGInkManager(HGInkManager *this, MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *v15; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  List_1_HG_Rendering_Runtime_HGInkManager_InkData_ *v18; // rdi
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  MethodInfo *methoda; // [rsp+20h] [rbp-28h]
		  MethodInfo *methodc; // [rsp+20h] [rbp-28h]
		  MethodInfo *methodd; // [rsp+20h] [rbp-28h]
		  MethodInfo *methode; // [rsp+20h] [rbp-28h]
		  MethodInfo *methodb; // [rsp+20h] [rbp-28h]
		  NativeArray_1_UnityEngine_Vector4_ v27; // [rsp+30h] [rbp-18h] BYREF
		
		  this->fields.m_isCharacterGrounded = (Single__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Single, 4LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_isCharacterGrounded, v3, v4, v5, methoda);
		  this->fields.m_isCharacterSpeed = (Single__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Single, 4LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_isCharacterSpeed, v6, v7, v8, methodc);
		  this->fields.m_isCharacterLanding = (Single__Array *)il2cpp_array_new_specific_1(TypeInfo::System::Single, 4LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_isCharacterLanding, v9, v10, v11, methodd);
		  this->fields.m_isCharacterForwardDir = (Vector4__Array *)il2cpp_array_new_specific_1(
		                                                             TypeInfo::UnityEngine::Vector4,
		                                                             4LL);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_isCharacterForwardDir, v12, v13, v14, methode);
		  v15 = (List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInkManager::InkData>);
		  v18 = (List_1_HG_Rendering_Runtime_HGInkManager_InkData_ *)v15;
		  if ( !v15 )
		    sub_1800D8260(v17, v16);
		  System::Collections::Generic::List<Beyond::UI::UIText_RichTextAnalyzer::RichTextParam>::List(
		    v15,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInkManager::InkData>::List);
		  this->fields.m_inkDataList = v18;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_inkDataList, v19, v20, v21, methodb);
		  this->fields.enabledLastUpdate = 1;
		  v27 = 0LL;
		  Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray(
		    &v27,
		    32,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
		  this->fields.inkDataDynamic = v27;
		  v27 = 0LL;
		  Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray(
		    &v27,
		    12,
		    Allocator__Enum_Persistent,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
		  this->fields.inkDataConfig = v27;
		}
		
	
		// Methods
		internal void Initialize(HGRenderPipelineRuntimeResources resource) {} // 0x0000000183945650-0x0000000183945680
		// Void Initialize(HGRenderPipelineRuntimeResources)
		void HG::Rendering::Runtime::HGInkManager::Initialize(
		        HGInkManager *this,
		        HGRenderPipelineRuntimeResources *resource,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2398, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2398, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)resource,
		      0LL);
		  }
		}
		
		public void PipelineUpdate() {} // 0x00000001831C8470-0x00000001831C84E0
		// Void PipelineUpdate()
		void HG::Rendering::Runtime::HGInkManager::PipelineUpdate(HGInkManager *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  List_1_HG_Rendering_Runtime_HGInkManager_InkData_ *m_inkDataList; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size <= 2337 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_7;
		  if ( LODWORD(v3->_0.namespaze) <= 0x921 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !*(_QWORD *)&v3[49]._1.naturalAligment )
		  {
		LABEL_5:
		    HG::Rendering::Runtime::HGInkManager::SetInkDynamicData(this, 0LL);
		    m_inkDataList = this->fields.m_inkDataList;
		    if ( m_inkDataList )
		    {
		      ++m_inkDataList->fields._version;
		      m_inkDataList->fields._size = 0;
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2337, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		public void Release() {} // 0x0000000189B57DFC-0x0000000189B57E74
		// Void Release()
		void HG::Rendering::Runtime::HGInkManager::Release(HGInkManager *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2284, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2284, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( this->fields.inkDataDynamic.m_Buffer )
		      Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		        &this->fields.inkDataDynamic,
		        MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
		    if ( this->fields.inkDataConfig.m_Buffer )
		      Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		        &this->fields.inkDataConfig,
		        MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
		  }
		}
		
		public void UpdateInkConfig(HGInkSimulationConfig inkSimulationConfig) {} // 0x0000000183E457E0-0x0000000183E45860
		// Void UpdateInkConfig(HGInkSimulationConfig)
		void HG::Rendering::Runtime::HGInkManager::UpdateInkConfig(
		        HGInkManager *this,
		        HGInkSimulationConfig *inkSimulationConfig,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v8; // xmm1
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  __int128 v11; // xmm0
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  HGInkSimulationConfig v14; // [rsp+20h] [rbp-88h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 830 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x33E )
		        sub_1800D2AB0(v5, inkSimulationConfig);
		      if ( !*(_QWORD *)&v5[17]._1.token )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(830, 0LL);
		      if ( Patch )
		      {
		        v8 = *(_OWORD *)&inkSimulationConfig->inkRippleDensity;
		        *(_OWORD *)&v14.influence = *(_OWORD *)&inkSimulationConfig->influence;
		        v9 = *(_OWORD *)&inkSimulationConfig->inkDebugJacobi;
		        *(_OWORD *)&v14.inkRippleDensity = v8;
		        v10 = *(_OWORD *)&inkSimulationConfig->resolvedShaderParams.speedFactor;
		        *(_OWORD *)&v14.inkDebugJacobi = v9;
		        v11 = *(_OWORD *)&inkSimulationConfig->resolvedShaderParams.forceAngleRandom;
		        *(_OWORD *)&v14.resolvedShaderParams.speedFactor = v10;
		        v12 = *(_OWORD *)&inkSimulationConfig->resolvedShaderParams.landingInkSize;
		        *(_OWORD *)&v14.resolvedShaderParams.forceAngleRandom = v11;
		        v13 = *(_OWORD *)&inkSimulationConfig->resolvedShaderParams.viscosity;
		        *(_OWORD *)&v14.resolvedShaderParams.landingInkSize = v12;
		        *(_QWORD *)&v12 = *(_QWORD *)&inkSimulationConfig->resolvedShaderParams.idleForceChangeSpeed;
		        *(_OWORD *)&v14.resolvedShaderParams.viscosity = v13;
		        *(_QWORD *)&v14.resolvedShaderParams.idleForceChangeSpeed = v12;
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_328(Patch, (Object *)this, &v14, 0LL);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v5, inkSimulationConfig);
		  }
		LABEL_5:
		  this->fields.enabledLastUpdate = COERCE_FLOAT(*(_OWORD *)&inkSimulationConfig->influence) > 0.0;
		}
		
		public void UpdateInkParamsV2(int index, bool isCharacterGrounded, float isCharacterSpeed, bool isCharacterLanding, Vector4 characterForwardDir) {} // 0x0000000189B57E74-0x0000000189B57FA0
		// Void UpdateInkParamsV2(Int32, Boolean, Single, Boolean, Vector4)
		void HG::Rendering::Runtime::HGInkManager::UpdateInkParamsV2(
		        HGInkManager *this,
		        int32_t index,
		        bool isCharacterGrounded,
		        float isCharacterSpeed,
		        bool isCharacterLanding,
		        Vector4 *characterForwardDir,
		        MethodInfo *method)
		{
		  __int64 v7; // rbx
		  int v9; // esi
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *m_isCharacterGrounded; // rcx
		  Vector4 v12; // [rsp+40h] [rbp-28h] BYREF
		
		  v7 = index;
		  v9 = isCharacterGrounded;
		  if ( !IFix::WrappersManagerImpl::IsPatched(2399, 0LL) )
		  {
		    m_isCharacterGrounded = (ILFixDynamicMethodWrapper_2 *)this->fields.m_isCharacterGrounded;
		    if ( !m_isCharacterGrounded )
		      goto LABEL_12;
		    if ( (unsigned int)v7 >= m_isCharacterGrounded->fields.methodId )
		      goto LABEL_10;
		    *((float *)&m_isCharacterGrounded->fields.anonObj + v7) = (float)v9;
		    m_isCharacterGrounded = (ILFixDynamicMethodWrapper_2 *)this->fields.m_isCharacterSpeed;
		    if ( !m_isCharacterGrounded )
		      goto LABEL_12;
		    if ( (unsigned int)v7 >= m_isCharacterGrounded->fields.methodId )
		      goto LABEL_10;
		    *((float *)&m_isCharacterGrounded->fields.anonObj + v7) = isCharacterSpeed;
		    m_isCharacterGrounded = (ILFixDynamicMethodWrapper_2 *)this->fields.m_isCharacterLanding;
		    if ( !m_isCharacterGrounded )
		      goto LABEL_12;
		    if ( (unsigned int)v7 >= m_isCharacterGrounded->fields.methodId )
		LABEL_10:
		      sub_1800D2AB0(m_isCharacterGrounded, v10);
		    *((float *)&m_isCharacterGrounded->fields.anonObj + v7) = (float)isCharacterLanding;
		    m_isCharacterGrounded = (ILFixDynamicMethodWrapper_2 *)this->fields.m_isCharacterForwardDir;
		    if ( m_isCharacterGrounded )
		    {
		      v12 = *characterForwardDir;
		      sub_18003FEF0(m_isCharacterGrounded, v7, &v12);
		      return;
		    }
		LABEL_12:
		    sub_1800D8260(m_isCharacterGrounded, v10);
		  }
		  m_isCharacterGrounded = IFix::WrappersManagerImpl::GetPatch(2399, 0LL);
		  if ( !m_isCharacterGrounded )
		    goto LABEL_12;
		  v12 = *characterForwardDir;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_938(
		    m_isCharacterGrounded,
		    (Object *)this,
		    v7,
		    v9,
		    isCharacterSpeed,
		    isCharacterLanding,
		    &v12,
		    0LL);
		}
		
		internal void SetInkDynamicData() {} // 0x0000000182F3F8C0-0x0000000182F3FBF0
		// Void SetInkDynamicData()
		void HG::Rendering::Runtime::HGInkManager::SetInkDynamicData(HGInkManager *this, MethodInfo *method)
		{
		  Vector3Int *v2; // r8
		  ITilemap *v3; // r9
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  List_1_HG_Rendering_Runtime_HGInkManager_InkData_ *wrapperArray; // rdx
		  Single__Array *m_isCharacterGrounded; // rax
		  __m128 v8; // xmm1
		  __m128 v9; // xmm1
		  __m128 v10; // xmm1
		  __m128 v11; // xmm1
		  Single__Array *m_isCharacterSpeed; // rax
		  __m128 v13; // xmm1
		  __m128 v14; // xmm1
		  __m128 v15; // xmm1
		  __m128 v16; // xmm1
		  Single__Array *m_isCharacterLanding; // rax
		  __m128 v18; // xmm1
		  __m128 v19; // xmm1
		  __m128 v20; // xmm1
		  __m128 v21; // xmm1
		  Vector4__Array *m_isCharacterForwardDir; // rax
		  Vector4__Array *v23; // rax
		  Vector4__Array *v24; // rax
		  Vector4__Array *v25; // rax
		  Vector3Int *v26; // r8
		  ITilemap *v27; // r9
		  List_1_HG_Rendering_Runtime_HGInkManager_InkData_ *m_inkDataList; // rsi
		  int32_t size; // esi
		  int32_t v30; // r14d
		  int v31; // eax
		  int v32; // eax
		  int32_t v33; // ebx
		  Vector4 v34; // xmm0
		  Void *m_Buffer; // rax
		  TileBase *v36; // rdx
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  __int64 v38; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 i; // r15
		  __m128 v41; // [rsp+20h] [rbp-19h] BYREF
		  Vector4 v42; // [rsp+30h] [rbp-9h] BYREF
		  HGInkManager_InkData v43; // [rsp+40h] [rbp+7h] BYREF
		  HGInkManager_InkData v44; // [rsp+60h] [rbp+27h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (List_1_HG_Rendering_Runtime_HGInkManager_InkData_ *)v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_29;
		  if ( wrapperArray->fields._size > 2338 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = (List_1_HG_Rendering_Runtime_HGInkManager_InkData_ *)v5->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_29;
		    if ( wrapperArray->fields._size <= 0x922u )
		LABEL_30:
		      sub_1800D2AB0(v5, wrapperArray);
		    if ( wrapperArray[468].fields._items )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2338, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		        return;
		      }
		LABEL_29:
		      sub_1800D8260(v5, wrapperArray);
		    }
		  }
		  m_isCharacterGrounded = this->fields.m_isCharacterGrounded;
		  if ( !m_isCharacterGrounded )
		    goto LABEL_29;
		  if ( m_isCharacterGrounded->max_length.size < 4u )
		    goto LABEL_30;
		  v8 = _mm_shuffle_ps(
		         (__m128)LODWORD(m_isCharacterGrounded->vector[0]),
		         (__m128)LODWORD(m_isCharacterGrounded->vector[0]),
		         225);
		  v8.m128_f32[0] = m_isCharacterGrounded->vector[1];
		  v9 = _mm_shuffle_ps(v8, v8, 198);
		  v9.m128_f32[0] = m_isCharacterGrounded->vector[2];
		  v10 = _mm_shuffle_ps(v9, v9, 39);
		  v10.m128_f32[0] = m_isCharacterGrounded->vector[3];
		  v11 = _mm_shuffle_ps(v10, v10, 57);
		  *(__m128 *)this->fields.inkDataDynamic.m_Buffer = v11;
		  m_isCharacterSpeed = this->fields.m_isCharacterSpeed;
		  v41 = v11;
		  if ( !m_isCharacterSpeed )
		    goto LABEL_29;
		  if ( m_isCharacterSpeed->max_length.size < 4u )
		    goto LABEL_30;
		  v13 = _mm_shuffle_ps(
		          (__m128)LODWORD(m_isCharacterSpeed->vector[0]),
		          (__m128)LODWORD(m_isCharacterSpeed->vector[0]),
		          225);
		  v13.m128_f32[0] = m_isCharacterSpeed->vector[1];
		  v14 = _mm_shuffle_ps(v13, v13, 198);
		  v14.m128_f32[0] = m_isCharacterSpeed->vector[2];
		  v15 = _mm_shuffle_ps(v14, v14, 39);
		  v15.m128_f32[0] = m_isCharacterSpeed->vector[3];
		  v16 = _mm_shuffle_ps(v15, v15, 57);
		  *(__m128 *)&this->fields.inkDataDynamic.m_Buffer[16] = v16;
		  m_isCharacterLanding = this->fields.m_isCharacterLanding;
		  v41 = v16;
		  if ( !m_isCharacterLanding )
		    goto LABEL_29;
		  if ( m_isCharacterLanding->max_length.size < 4u )
		    goto LABEL_30;
		  v18 = _mm_shuffle_ps(
		          (__m128)LODWORD(m_isCharacterLanding->vector[0]),
		          (__m128)LODWORD(m_isCharacterLanding->vector[0]),
		          225);
		  v18.m128_f32[0] = m_isCharacterLanding->vector[1];
		  v19 = _mm_shuffle_ps(v18, v18, 198);
		  v19.m128_f32[0] = m_isCharacterLanding->vector[2];
		  v20 = _mm_shuffle_ps(v19, v19, 39);
		  v20.m128_f32[0] = m_isCharacterLanding->vector[3];
		  v21 = _mm_shuffle_ps(v20, v20, 57);
		  *(__m128 *)&this->fields.inkDataDynamic.m_Buffer[32] = v21;
		  m_isCharacterForwardDir = this->fields.m_isCharacterForwardDir;
		  v41 = v21;
		  if ( !m_isCharacterForwardDir )
		    goto LABEL_29;
		  if ( !m_isCharacterForwardDir->max_length.size )
		    goto LABEL_30;
		  *(Vector4 *)&this->fields.inkDataDynamic.m_Buffer[48] = m_isCharacterForwardDir->vector[0];
		  v23 = this->fields.m_isCharacterForwardDir;
		  if ( !v23 )
		    goto LABEL_29;
		  if ( v23->max_length.size <= 1u )
		    goto LABEL_30;
		  *(Vector4 *)&this->fields.inkDataDynamic.m_Buffer[64] = v23->vector[1];
		  v24 = this->fields.m_isCharacterForwardDir;
		  if ( !v24 )
		    goto LABEL_29;
		  if ( v24->max_length.size <= 2u )
		    goto LABEL_30;
		  *(Vector4 *)&this->fields.inkDataDynamic.m_Buffer[80] = v24->vector[2];
		  v25 = this->fields.m_isCharacterForwardDir;
		  if ( !v25 )
		    goto LABEL_29;
		  if ( v25->max_length.size <= 3u )
		    goto LABEL_30;
		  *(Vector4 *)&this->fields.inkDataDynamic.m_Buffer[96] = v25->vector[3];
		  *(TileAnimationData *)&this->fields.inkDataDynamic.m_Buffer[112] = *UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                                                        (TileAnimationData *)&v41,
		                                                                        (TileBase *)wrapperArray,
		                                                                        v2,
		                                                                        v3,
		                                                                        (MethodInfo *)v41.m128_u64[0]);
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)(unsigned int)(this->fields.inkDataDynamic.m_Length - 9);
		  m_inkDataList = this->fields.m_inkDataList;
		  if ( !m_inkDataList )
		    goto LABEL_29;
		  size = m_inkDataList->fields._size;
		  v30 = 0;
		  v31 = 0;
		  if ( (int)v5 >= 0 )
		    v31 = this->fields.inkDataDynamic.m_Length - 9;
		  v32 = v31 / 2;
		  *(unsigned __int64 *)((char *)v41.m128_u64 + 4) = 0LL;
		  v41.m128_i32[3] = 0;
		  v33 = 9;
		  v34 = (Vector4)v41.m128_u32[0];
		  if ( size >= v32 )
		    size = v32;
		  this->fields._LastExtraInkDataCount_k__BackingField = size;
		  m_Buffer = this->fields.inkDataDynamic.m_Buffer;
		  v34.x = (float)size;
		  v41 = (__m128)v34;
		  *(Vector4 *)&m_Buffer[128] = v34;
		  if ( size > 0 )
		  {
		    for ( i = 144LL; ; i += 32LL )
		    {
		      wrapperArray = this->fields.m_inkDataList;
		      if ( !wrapperArray )
		        break;
		      System::Collections::Generic::List<Cinemachine::TargetPositionCache_CacheCurve::Item>::get_Item(
		        (TargetPositionCache_CacheCurve_Item *)&v44,
		        (List_1_Cinemachine_TargetPositionCache_CacheCurve_Item_ *)wrapperArray,
		        v30,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInkManager::InkData>::get_Item);
		      v43 = v44;
		      v33 += 2;
		      *(Vector4 *)&this->fields.inkDataDynamic.m_Buffer[i] = *HG::Rendering::Runtime::HGInkManager::InkData::GetPack0(
		                                                                (Vector4 *)&v41,
		                                                                &v43,
		                                                                0LL);
		      wrapperArray = this->fields.m_inkDataList;
		      if ( !wrapperArray )
		        break;
		      System::Collections::Generic::List<Cinemachine::TargetPositionCache_CacheCurve::Item>::get_Item(
		        (TargetPositionCache_CacheCurve_Item *)&v44,
		        (List_1_Cinemachine_TargetPositionCache_CacheCurve_Item_ *)wrapperArray,
		        v30,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInkManager::InkData>::get_Item);
		      v43 = v44;
		      ++v30;
		      *(Vector4 *)&this->fields.inkDataDynamic.m_Buffer[i + 16] = *HG::Rendering::Runtime::HGInkManager::InkData::GetPack1(
		                                                                     &v42,
		                                                                     &v43,
		                                                                     0LL);
		      if ( v30 >= size )
		        goto LABEL_25;
		    }
		    goto LABEL_29;
		  }
		LABEL_25:
		  if ( v33 < this->fields.inkDataDynamic.m_Length )
		  {
		    v36 = (TileBase *)(16LL * v33);
		    do
		    {
		      TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                 (TileAnimationData *)&v42,
		                                 v36,
		                                 v26,
		                                 v27,
		                                 (MethodInfo *)v41.m128_u64[0]);
		      ++v33;
		      v36 = (TileBase *)(v38 + 16);
		      *(TileAnimationData *)&this->fields.inkDataDynamic.m_Buffer[(unsigned __int64)v36 - 16] = *TileAnimationDataNoRef;
		    }
		    while ( v33 < this->fields.inkDataDynamic.m_Length );
		  }
		}
		
		internal void SetInkConfigData([IsReadOnly] in HGInkSimulationShaderParamValues p, [IsReadOnly] in HGInkSimulationConfig inkSimulationConfig) {} // 0x0000000183A40B40-0x0000000183A40C90
		// Void SetInkConfigData(HGInkSimulationShaderParamValues ByRef, HGInkSimulationConfig ByRef)
		void HG::Rendering::Runtime::HGInkManager::SetInkConfigData(
		        HGInkManager *this,
		        HGInkSimulationShaderParamValues *p,
		        HGInkSimulationConfig *inkSimulationConfig,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  Void *m_Buffer; // rax
		  __int64 v10; // r8
		  TileAnimationData v11; // xmm1
		  Void *v12; // rax
		  TileAnimationData v13; // xmm1
		  Void *v14; // rax
		  TileAnimationData v15; // xmm1
		  Void *v16; // rax
		  TileAnimationData v17; // xmm1
		  Void *v18; // rax
		  float inkRippleDensity; // xmm2_4
		  float inkRippleStrength; // xmm3_4
		  __m128 v21; // xmm0
		  __m128 v22; // xmm0
		  __m128 v23; // xmm0
		  __m128 v24; // xmm0
		  __int64 v25; // rdx
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  int v27; // r8d
		  __int64 v28; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *methoda; // [rsp+20h] [rbp-20h]
		  TileAnimationData v31; // [rsp+30h] [rbp-10h] BYREF
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size > 1081 )
		  {
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		    if ( v6 )
		    {
		      if ( LODWORD(v6->_0.namespaze) <= 0x439 )
		        sub_1800D2AB0(v6, wrapperArray);
		      if ( !v6[23]._0.byval_arg.data.dummy )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1081, 0LL);
		      if ( Patch )
		      {
		        IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_416(Patch, (Object *)this, p, inkSimulationConfig, 0LL);
		        return;
		      }
		    }
		LABEL_9:
		    sub_1800D8260(v6, wrapperArray);
		  }
		LABEL_5:
		  m_Buffer = this->fields.inkDataConfig.m_Buffer;
		  v10 = 6LL;
		  v31 = *(TileAnimationData *)&p->speedRandom;
		  *(TileAnimationData *)m_Buffer = v31;
		  v11 = *(TileAnimationData *)&p->speedInkSizeFactor;
		  *(TileAnimationData *)&this->fields.inkDataConfig.m_Buffer[16] = v11;
		  v12 = this->fields.inkDataConfig.m_Buffer;
		  v31 = v11;
		  v13 = *(TileAnimationData *)&p->velocityScale;
		  *(TileAnimationData *)&v12[32] = v13;
		  v14 = this->fields.inkDataConfig.m_Buffer;
		  v31 = v13;
		  v15 = *(TileAnimationData *)&p->landingVelocityStrength;
		  *(TileAnimationData *)&v14[48] = v15;
		  v16 = this->fields.inkDataConfig.m_Buffer;
		  v31 = v15;
		  v17 = *(TileAnimationData *)&p->vorticity;
		  *(TileAnimationData *)&v16[64] = v17;
		  v18 = this->fields.inkDataConfig.m_Buffer;
		  inkRippleDensity = inkSimulationConfig->inkRippleDensity;
		  inkRippleStrength = inkSimulationConfig->inkRippleStrength;
		  v31 = v17;
		  v31.m_AnimationStartTime = 0.0;
		  v21 = (__m128)v31;
		  v21.m128_f32[0] = inkSimulationConfig->inkRippleIntensity;
		  v22 = _mm_shuffle_ps(v21, v21, 225);
		  v22.m128_f32[0] = inkRippleDensity;
		  v23 = _mm_shuffle_ps(v22, v22, 198);
		  v23.m128_f32[0] = inkRippleStrength;
		  v24 = _mm_shuffle_ps(v23, v23, 201);
		  *(__m128 *)&v18[80] = v24;
		  v31 = (TileAnimationData)v24;
		  if ( this->fields.inkDataConfig.m_Length > 6 )
		  {
		    v25 = 96LL;
		    do
		    {
		      TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                 &v31,
		                                 (TileBase *)v25,
		                                 (Vector3Int *)v10,
		                                 (ITilemap *)method,
		                                 methoda);
		      v10 = (unsigned int)(v27 + 1);
		      v25 = v28 + 16;
		      *(TileAnimationData *)&this->fields.inkDataConfig.m_Buffer[v25 - 16] = *TileAnimationDataNoRef;
		    }
		    while ( (int)v10 < this->fields.inkDataConfig.m_Length );
		  }
		}
		
		internal void PrepareInkFrameData([IsReadOnly] in HGInkSimulationConfig inkSimulationConfig, [IsReadOnly] in HGInkSimulationShaderParamValues shaderParams) {} // 0x0000000183A40AC0-0x0000000183A40B40
		// Void PrepareInkFrameData(HGInkSimulationConfig ByRef, HGInkSimulationShaderParamValues ByRef)
		void HG::Rendering::Runtime::HGInkManager::PrepareInkFrameData(
		        HGInkManager *this,
		        HGInkSimulationConfig *inkSimulationConfig,
		        HGInkSimulationShaderParamValues *shaderParams,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 1080 )
		  {
		LABEL_5:
		    HG::Rendering::Runtime::HGInkManager::SetInkConfigData(this, shaderParams, inkSimulationConfig, 0LL);
		    return;
		  }
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		  if ( !v6 )
		    goto LABEL_6;
		  if ( LODWORD(v6->_0.namespaze) <= 0x438 )
		    sub_1800D2AB0(v6, inkSimulationConfig);
		  if ( !v6[23]._0.namespaze )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1080, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v6, inkSimulationConfig);
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_417(Patch, (Object *)this, inkSimulationConfig, shaderParams, 0LL);
		}
		
		public void AddInkData(Vector2 posXZ, Vector2 forceDirection, float inkSize, float velocityScale, float inkColorStrength) {} // 0x0000000189B57CE4-0x0000000189B57DFC
		// Void AddInkData(Vector2, Vector2, Single, Single, Single)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGInkManager::AddInkData(
		        HGInkManager *this,
		        Vector2 posXZ,
		        Vector2 forceDirection,
		        float inkSize,
		        float velocityScale,
		        float inkColorStrength,
		        MethodInfo *method)
		{
		  __m128d v8; // xmm8
		  __m128d v9; // xmm7
		  __int64 v10; // rdx
		  List_1_HG_Rendering_Runtime_HGInkManager_InkData_ *m_inkDataList; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __m128d v13; // [rsp+40h] [rbp-58h] BYREF
		  unsigned __int64 v14; // [rsp+50h] [rbp-48h]
		  float v15; // [rsp+58h] [rbp-40h]
		
		  v8 = (__m128d)*(unsigned __int64 *)&posXZ;
		  v9 = (__m128d)*(unsigned __int64 *)&forceDirection;
		  if ( IFix::WrappersManagerImpl::IsPatched(2400, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2400, 0LL);
		    if ( !Patch )
		      goto LABEL_8;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_939(
		      Patch,
		      (Object *)this,
		      *(Vector2 *)&v8.m128d_f64[0],
		      *(Vector2 *)&v9.m128d_f64[0],
		      inkSize,
		      velocityScale,
		      inkColorStrength,
		      0LL);
		  }
		  else if ( inkSize >= 0.0 && velocityScale >= 0.0 && inkColorStrength >= 0.0 )
		  {
		    m_inkDataList = this->fields.m_inkDataList;
		    if ( m_inkDataList )
		    {
		      v15 = inkColorStrength;
		      v13 = _mm_unpacklo_pd(v8, v9);
		      v14 = _mm_unpacklo_ps(*(__m128 *)&inkSize, (__m128)LODWORD(velocityScale)).m128_u64[0];
		      sub_180498A18(
		        m_inkDataList,
		        &v13,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGInkManager::InkData>::Add);
		      return;
		    }
		LABEL_8:
		    sub_1800D8260(m_inkDataList, v10);
		  }
		}
		
	}
}
