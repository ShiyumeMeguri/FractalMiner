using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class GPUParticleSystemBase // TypeDefIndex: 37720
	{
		// Fields
		protected const int MAX_INSTANCE_COUNT = 64; // Metadata: 0x02303084
		private ComputeBuffer m_perInstanceBuffer; // 0x10
		private ComputeBuffer m_generalSystemAttributeBuffer; // 0x18
		private ComputeBuffer m_particleAttributesBuffer; // 0x20
		private ComputeBuffer m_liveListBuffer; // 0x28
		private ComputeBuffer m_deadListBuffer; // 0x30
		private ComputeBuffer m_deadCountBuffer; // 0x38
		private ComputeBuffer m_drawIndirectArgsBuffer; // 0x40
		private GraphicsBuffer m_quadIndexBuffer; // 0x48
		private GeneralSystemAttributes m_generalSystemAttributes; // 0x50
		private GPUParticleShaders m_shaders; // 0x60
		private List<PerInstanceData> m_perInstanceData; // 0x70
		private List<int> m_instancesToClear; // 0x78
		private Material m_material; // 0x80
		private List<int> m_instances; // 0x88
		private List<int> m_freePool; // 0x90
		private int m_gpuInstanceCount; // 0x98
		private int m_maxParticleEmitRate; // 0x9C
		internal OptionalSystemFeatures? optionalSystemFeatures; // 0xA0
	
		// Properties
		private int particleCapacity { get => default; } // 0x0000000189CFA444-0x0000000189CFA490 
		// Int32 get_particleCapacity()
		int32_t HG::Rendering::Runtime::GPUParticleSystemBase::get_particleCapacity(
		        GPUParticleSystemBase *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1728, 0LL) )
		    return this->fields.m_generalSystemAttributes.particleCapacity;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1728, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		private int particleAttribSize { get => default; } // 0x0000000189CFA3F8-0x0000000189CFA444 
		// Int32 get_particleAttribSize()
		int32_t HG::Rendering::Runtime::GPUParticleSystemBase::get_particleAttribSize(
		        GPUParticleSystemBase *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1729, 0LL) )
		    return this->fields.m_generalSystemAttributes.particleAttribSize;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1729, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		private int instanceCapacity { get => default; } // 0x0000000189CFA308-0x0000000189CFA354 
		// Int32 get_instanceCapacity()
		int32_t HG::Rendering::Runtime::GPUParticleSystemBase::get_instanceCapacity(
		        GPUParticleSystemBase *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1730, 0LL) )
		    return this->fields.m_generalSystemAttributes.instanceCapacity;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1730, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		private int maxParticleCount { get => default; } // 0x0000000189CFA3A8-0x0000000189CFA3F8 
		// Int32 get_maxParticleCount()
		int32_t HG::Rendering::Runtime::GPUParticleSystemBase::get_maxParticleCount(
		        GPUParticleSystemBase *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1731, 0LL) )
		    return this->fields.m_generalSystemAttributes.particleCapacity
		         * this->fields.m_generalSystemAttributes.instanceCapacity;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1731, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		private int fixedParticleAttribSize { get => default; } // 0x0000000189CFA268-0x0000000189CFA2B8 
		// Int32 get_fixedParticleAttribSize()
		int32_t HG::Rendering::Runtime::GPUParticleSystemBase::get_fixedParticleAttribSize(
		        GPUParticleSystemBase *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1732, 0LL) )
		    return 32;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1732, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		internal int maxAvailableParticleCount { get => default; } // 0x0000000189CFA354-0x0000000189CFA3A8 
		// Int32 get_maxAvailableParticleCount()
		int32_t HG::Rendering::Runtime::GPUParticleSystemBase::get_maxAvailableParticleCount(
		        GPUParticleSystemBase *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1733, 0LL) )
		    return this->fields.m_generalSystemAttributes.particleCapacity * this->fields.m_gpuInstanceCount;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1733, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
		internal int gpuInstanceCount { get => default; } // 0x0000000189CFA2B8-0x0000000189CFA308 
		// Int32 get_gpuInstanceCount()
		int32_t HG::Rendering::Runtime::GPUParticleSystemBase::get_gpuInstanceCount(
		        GPUParticleSystemBase *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1734, 0LL) )
		    return this->fields.m_gpuInstanceCount;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1734, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Nested types
		private struct FixedParticleAttrib // TypeDefIndex: 37719
		{
			// Fields
			internal Vector4 var0; // 0x00
			internal Vector4 var1; // 0x10
		}
	
		// Constructors
		protected GPUParticleSystemBase() {} // 0x0000000189CF9B1C-0x0000000189CF9C74
		// GPUParticleSystemBase()
		void HG::Rendering::Runtime::GPUParticleSystemBase::GPUParticleSystemBase(
		        GPUParticleSystemBase *this,
		        MethodInfo *method)
		{
		  int32_t instanceCapacity; // esi
		  List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *v4; // rax
		  __int64 v5; // rdx
		  List_1_System_Int32_ *m_instances; // rcx
		  List_1_System_Int32_ *v7; // rdi
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  int32_t v11; // esi
		  List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *v12; // rax
		  List_1_System_Int32_ *v13; // rdi
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  int32_t v17; // edi
		  List_1_System_Int32_ *m_freePool; // rsi
		  int32_t v19; // eax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v20; // rax
		  List_1_System_Int32_ *v21; // rdi
		  Type *v22; // rdx
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  MethodInfo *v25; // [rsp+20h] [rbp-8h]
		  MethodInfo *v26; // [rsp+20h] [rbp-8h]
		  MethodInfo *v27; // [rsp+20h] [rbp-8h]
		
		  instanceCapacity = HG::Rendering::Runtime::GPUParticleSystemBase::get_instanceCapacity(this, 0LL);
		  v4 = (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<int>);
		  v7 = (List_1_System_Int32_ *)v4;
		  if ( !v4 )
		    goto LABEL_9;
		  System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::List(
		    v4,
		    instanceCapacity,
		    MethodInfo::System::Collections::Generic::List<int>::List);
		  this->fields.m_instances = v7;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_instances, v8, v9, v10, v25);
		  v11 = HG::Rendering::Runtime::GPUParticleSystemBase::get_instanceCapacity(this, 0LL);
		  v12 = (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<int>);
		  v13 = (List_1_System_Int32_ *)v12;
		  if ( !v12 )
		    goto LABEL_9;
		  System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::List(
		    v12,
		    v11,
		    MethodInfo::System::Collections::Generic::List<int>::List);
		  this->fields.m_freePool = v13;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_freePool, v14, v15, v16, v26);
		  v17 = 0;
		  if ( HG::Rendering::Runtime::GPUParticleSystemBase::get_instanceCapacity(this, 0LL) > 0 )
		  {
		    while ( 1 )
		    {
		      m_instances = this->fields.m_instances;
		      if ( !m_instances )
		        break;
		      sub_183081250(m_instances, 0xFFFFFFFFLL, MethodInfo::System::Collections::Generic::List<int>::Add);
		      m_freePool = this->fields.m_freePool;
		      v19 = HG::Rendering::Runtime::GPUParticleSystemBase::get_instanceCapacity(this, 0LL);
		      if ( !m_freePool )
		        break;
		      sub_183081250(
		        m_freePool,
		        (unsigned int)(v19 - v17++ - 1),
		        MethodInfo::System::Collections::Generic::List<int>::Add);
		      if ( v17 >= HG::Rendering::Runtime::GPUParticleSystemBase::get_instanceCapacity(this, 0LL) )
		        goto LABEL_7;
		    }
		LABEL_9:
		    sub_1800D8260(m_instances, v5);
		  }
		LABEL_7:
		  v20 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<int>);
		  v21 = (List_1_System_Int32_ *)v20;
		  if ( !v20 )
		    goto LABEL_9;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v20,
		    MethodInfo::System::Collections::Generic::List<int>::List);
		  this->fields.m_instancesToClear = v21;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_instancesToClear, v22, v23, v24, v27);
		  this->fields.m_gpuInstanceCount = 0;
		}
		
		protected GPUParticleSystemBase([IsReadOnly] in GPUParticleShaders shaders, [IsReadOnly] in GeneralSystemAttributes generalSystemAttributes, [IsReadOnly] in OptionalSystemFeatures? optionalSystemFeatures, Material material) {} // 0x0000000189CF9C74-0x0000000189CFA268
		// GPUParticleSystemBase(GPUParticleShaders&, GeneralSystemAttributes&, Nullable`1[HG.Rendering.Runtime.OptionalSystemFeatures]&, Material)
		void HG::Rendering::Runtime::GPUParticleSystemBase::GPUParticleSystemBase(
		        GPUParticleSystemBase *this,
		        GPUParticleShaders *shaders,
		        GeneralSystemAttributes *generalSystemAttributes,
		        Nullable_1_HG_Rendering_Runtime_OptionalSystemFeatures_ *optionalSystemFeatures,
		        Material *material,
		        MethodInfo *method)
		{
		  int32_t particleAttribSize; // ebx
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  __int128 v15; // xmm1
		  __int128 v16; // xmm2
		  int32_t instanceCapacity; // esi
		  List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *v18; // rax
		  __int64 v19; // rdx
		  GraphicsBuffer *m_perInstanceData; // rcx
		  List_1_HG_Rendering_Runtime_PerInstanceData_ *v21; // rbx
		  Type *v22; // rdx
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  int32_t v25; // esi
		  List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *v26; // rax
		  List_1_System_Int32_ *v27; // rbx
		  Type *v28; // rdx
		  PropertyInfo_1 *v29; // r8
		  Int32__Array **v30; // r9
		  int32_t v31; // esi
		  List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *v32; // rax
		  List_1_System_Int32_ *v33; // rbx
		  Type *v34; // rdx
		  PropertyInfo_1 *v35; // r8
		  Int32__Array **v36; // r9
		  int32_t v37; // ebx
		  List_1_System_Int32_ *m_freePool; // rsi
		  int32_t v39; // eax
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v40; // rax
		  List_1_System_Int32_ *v41; // rbx
		  Type *v42; // rdx
		  PropertyInfo_1 *v43; // r8
		  Int32__Array **v44; // r9
		  int32_t v45; // esi
		  ComputeBuffer *v46; // rax
		  ComputeBuffer *v47; // rbx
		  Type *v48; // rdx
		  PropertyInfo_1 *v49; // r8
		  Int32__Array **v50; // r9
		  ComputeBuffer *v51; // rax
		  ComputeBuffer *v52; // rbx
		  Type *v53; // rdx
		  PropertyInfo_1 *v54; // r8
		  Int32__Array **v55; // r9
		  ComputeBuffer *v56; // rax
		  ComputeBuffer *v57; // rbx
		  Type *v58; // rdx
		  PropertyInfo_1 *v59; // r8
		  Int32__Array **v60; // r9
		  int32_t maxParticleCount; // r14d
		  int32_t v62; // esi
		  ComputeBuffer *v63; // rax
		  ComputeBuffer *v64; // rbx
		  Type *v65; // rdx
		  PropertyInfo_1 *v66; // r8
		  Int32__Array **v67; // r9
		  int32_t v68; // esi
		  ComputeBuffer *v69; // rax
		  ComputeBuffer *v70; // rbx
		  Type *v71; // rdx
		  PropertyInfo_1 *v72; // r8
		  Int32__Array **v73; // r9
		  int32_t v74; // esi
		  ComputeBuffer *v75; // rax
		  ComputeBuffer *v76; // rbx
		  Type *v77; // rdx
		  PropertyInfo_1 *v78; // r8
		  Int32__Array **v79; // r9
		  int32_t v80; // esi
		  ComputeBuffer *v81; // rax
		  ComputeBuffer *v82; // rbx
		  Type *v83; // rdx
		  PropertyInfo_1 *v84; // r8
		  Int32__Array **v85; // r9
		  GraphicsBuffer *v86; // rax
		  GraphicsBuffer *v87; // rbx
		  Type *v88; // rdx
		  PropertyInfo_1 *v89; // r8
		  Int32__Array **v90; // r9
		  Void *m_Buffer; // rax
		  MethodInfo *v92; // [rsp+28h] [rbp-89h]
		  MethodInfo *v93; // [rsp+28h] [rbp-89h]
		  MethodInfo *v94; // [rsp+28h] [rbp-89h]
		  MethodInfo *v95; // [rsp+28h] [rbp-89h]
		  MethodInfo *v96; // [rsp+28h] [rbp-89h]
		  MethodInfo *v97; // [rsp+28h] [rbp-89h]
		  MethodInfo *v98; // [rsp+28h] [rbp-89h]
		  MethodInfo *v99; // [rsp+28h] [rbp-89h]
		  MethodInfo *v100; // [rsp+28h] [rbp-89h]
		  MethodInfo *v101; // [rsp+28h] [rbp-89h]
		  MethodInfo *v102; // [rsp+28h] [rbp-89h]
		  MethodInfo *v103; // [rsp+28h] [rbp-89h]
		  MethodInfo *v104; // [rsp+28h] [rbp-89h]
		  MethodInfo *v105; // [rsp+28h] [rbp-89h]
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ v106; // [rsp+38h] [rbp-79h] BYREF
		  NativeArray_1_System_UInt32_ v107; // [rsp+48h] [rbp-69h] BYREF
		  OptionalSystemFeatures v108; // [rsp+58h] [rbp-59h] BYREF
		  Keyframe v109; // [rsp+88h] [rbp-29h] BYREF
		  OptionalSystemFeatures v110; // [rsp+A8h] [rbp-9h] BYREF
		
		  v106 = 0LL;
		  this->fields.m_generalSystemAttributes = *generalSystemAttributes;
		  particleAttribSize = this->fields.m_generalSystemAttributes.particleAttribSize;
		  v107 = 0LL;
		  this->fields.m_generalSystemAttributes.particleAttribSize = particleAttribSize
		                                                            + HG::Rendering::Runtime::GPUParticleSystemBase::get_fixedParticleAttribSize(
		                                                                this,
		                                                                0LL);
		  if ( optionalSystemFeatures->hasValue )
		  {
		    System::Nullable<HG::Rendering::Runtime::OptionalSystemFeatures>::get_Value(
		      &v108,
		      optionalSystemFeatures,
		      MethodInfo::System::Nullable<HG::Rendering::Runtime::OptionalSystemFeatures>::get_Value);
		    v110 = v108;
		    if ( _mm_srli_si128(*(__m128i *)&v108, 8).m128i_i8[4] )
		    {
		      System::Nullable<UnityEngine::Keyframe>::get_Value(
		        &v109,
		        (Nullable_1_UnityEngine_Keyframe_ *)&v110.gpuEventFeature,
		        MethodInfo::System::Nullable<HG::Rendering::Runtime::GPUEventFeature>::get_Value);
		      *(_OWORD *)&v108.sceneRTFeature.hasValue = *(_OWORD *)&v109.m_Time;
		      *(float *)&v108.gpuEventFeature.value.guid._d = v109.m_OutWeight;
		      *(_QWORD *)&v108.gpuEventFeature.value.guid._a = *(_QWORD *)&v109.m_WeightedMode;
		      if ( LOBYTE(v109.m_WeightedMode) )
		        this->fields.m_generalSystemAttributes.padding0 = *(_QWORD *)&System::Nullable<Beyond::Gameplay::Core::ProjectileComponent::FinishOptions>::get_Value(
		                                                                        (Nullable_1_Beyond_Gameplay_Core_ProjectileComponent_FinishOptions_ *)&v108.gpuEventFeature.value,
		                                                                        MethodInfo::System::Nullable<HG::Rendering::Runtime::GPUEventSender>::get_Value);
		    }
		  }
		  this->fields.m_shaders = *shaders;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_shaders, v10, v11, v12, v92);
		  this->fields.m_material = material;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_material, v13, v14, (Int32__Array **)material, v93);
		  v15 = *(_OWORD *)&optionalSystemFeatures->value.gpuEventFeature.hasValue;
		  v16 = *(_OWORD *)&optionalSystemFeatures->value.gpuEventFeature.value.guid._h;
		  *(_OWORD *)&this->fields.optionalSystemFeatures.hasValue = *(_OWORD *)&optionalSystemFeatures->hasValue;
		  *(_OWORD *)&this->fields.optionalSystemFeatures.value.gpuEventFeature.hasValue = v15;
		  *(_OWORD *)&this->fields.optionalSystemFeatures.value.gpuEventFeature.value.guid._h = v16;
		  instanceCapacity = HG::Rendering::Runtime::GPUParticleSystemBase::get_instanceCapacity(this, 0LL);
		  v18 = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>);
		  v21 = (List_1_HG_Rendering_Runtime_PerInstanceData_ *)v18;
		  if ( !v18 )
		    goto LABEL_25;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::List(
		    v18,
		    instanceCapacity,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::List);
		  this->fields.m_perInstanceData = v21;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_perInstanceData, v22, v23, v24, v94);
		  v25 = HG::Rendering::Runtime::GPUParticleSystemBase::get_instanceCapacity(this, 0LL);
		  v26 = (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<int>);
		  v27 = (List_1_System_Int32_ *)v26;
		  if ( !v26 )
		    goto LABEL_25;
		  System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::List(
		    v26,
		    v25,
		    MethodInfo::System::Collections::Generic::List<int>::List);
		  this->fields.m_instances = v27;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_instances, v28, v29, v30, v95);
		  v31 = HG::Rendering::Runtime::GPUParticleSystemBase::get_instanceCapacity(this, 0LL);
		  v32 = (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<int>);
		  v33 = (List_1_System_Int32_ *)v32;
		  if ( !v32 )
		    goto LABEL_25;
		  System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::List(
		    v32,
		    v31,
		    MethodInfo::System::Collections::Generic::List<int>::List);
		  this->fields.m_freePool = v33;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_freePool, v34, v35, v36, v96);
		  v37 = 0;
		  if ( HG::Rendering::Runtime::GPUParticleSystemBase::get_instanceCapacity(this, 0LL) > 0 )
		  {
		    while ( 1 )
		    {
		      m_perInstanceData = (GraphicsBuffer *)this->fields.m_perInstanceData;
		      if ( !m_perInstanceData )
		        break;
		      memset(&v108, 0, 32);
		      sub_180461578(
		        m_perInstanceData,
		        &v108,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::Add);
		      m_perInstanceData = (GraphicsBuffer *)this->fields.m_instances;
		      if ( !m_perInstanceData )
		        break;
		      sub_183081250(m_perInstanceData, 0xFFFFFFFFLL, MethodInfo::System::Collections::Generic::List<int>::Add);
		      m_freePool = this->fields.m_freePool;
		      v39 = HG::Rendering::Runtime::GPUParticleSystemBase::get_instanceCapacity(this, 0LL);
		      if ( !m_freePool )
		        break;
		      sub_183081250(
		        m_freePool,
		        (unsigned int)(v39 - v37++ - 1),
		        MethodInfo::System::Collections::Generic::List<int>::Add);
		      if ( v37 >= HG::Rendering::Runtime::GPUParticleSystemBase::get_instanceCapacity(this, 0LL) )
		        goto LABEL_13;
		    }
		LABEL_25:
		    sub_1800D8260(m_perInstanceData, v19);
		  }
		LABEL_13:
		  v40 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<int>);
		  v41 = (List_1_System_Int32_ *)v40;
		  if ( !v40 )
		    goto LABEL_25;
		  System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		    v40,
		    MethodInfo::System::Collections::Generic::List<int>::List);
		  this->fields.m_instancesToClear = v41;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_instancesToClear, v42, v43, v44, v97);
		  this->fields.m_gpuInstanceCount = 0;
		  v45 = HG::Rendering::Runtime::GPUParticleSystemBase::get_instanceCapacity(this, 0LL);
		  v46 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		  v47 = v46;
		  if ( !v46 )
		    goto LABEL_25;
		  UnityEngine::ComputeBuffer::ComputeBuffer(v46, v45, 32, ComputeBufferType__Enum_Constant, 0LL);
		  this->fields.m_perInstanceBuffer = v47;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v48, v49, v50, v98);
		  v51 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		  v52 = v51;
		  if ( !v51 )
		    goto LABEL_25;
		  UnityEngine::ComputeBuffer::ComputeBuffer(v51, 1, 16, ComputeBufferType__Enum_Constant, 0LL);
		  this->fields.m_generalSystemAttributeBuffer = v52;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_generalSystemAttributeBuffer, v53, v54, v55, v99);
		  v56 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		  v57 = v56;
		  if ( !v56 )
		    goto LABEL_25;
		  UnityEngine::ComputeBuffer::ComputeBuffer(v56, 1, 20, ComputeBufferType__Enum_DrawIndirect, 0LL);
		  this->fields.m_drawIndirectArgsBuffer = v57;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_drawIndirectArgsBuffer, v58, v59, v60, v100);
		  maxParticleCount = HG::Rendering::Runtime::GPUParticleSystemBase::get_maxParticleCount(this, 0LL);
		  v62 = HG::Rendering::Runtime::GPUParticleSystemBase::get_particleAttribSize(this, 0LL);
		  v63 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		  v64 = v63;
		  if ( !v63 )
		    goto LABEL_25;
		  UnityEngine::ComputeBuffer::ComputeBuffer(
		    v63,
		    maxParticleCount * v62 / 16,
		    16,
		    ComputeBufferType__Enum_Structured,
		    0LL);
		  this->fields.m_particleAttributesBuffer = v64;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_particleAttributesBuffer, v65, v66, v67, v101);
		  v68 = HG::Rendering::Runtime::GPUParticleSystemBase::get_maxParticleCount(this, 0LL);
		  v69 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		  v70 = v69;
		  if ( !v69 )
		    goto LABEL_25;
		  UnityEngine::ComputeBuffer::ComputeBuffer(v69, v68, 4, ComputeBufferType__Enum_Default, 0LL);
		  this->fields.m_liveListBuffer = v70;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_liveListBuffer, v71, v72, v73, v102);
		  v74 = HG::Rendering::Runtime::GPUParticleSystemBase::get_maxParticleCount(this, 0LL);
		  v75 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		  v76 = v75;
		  if ( !v75 )
		    goto LABEL_25;
		  UnityEngine::ComputeBuffer::ComputeBuffer(v75, v74, 4, ComputeBufferType__Enum_Default, 0LL);
		  this->fields.m_deadListBuffer = v76;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_deadListBuffer, v77, v78, v79, v103);
		  v80 = HG::Rendering::Runtime::GPUParticleSystemBase::get_instanceCapacity(this, 0LL);
		  v81 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		  v82 = v81;
		  if ( !v81 )
		    goto LABEL_25;
		  UnityEngine::ComputeBuffer::ComputeBuffer(v81, v80, 4, ComputeBufferType__Enum_Default, 0LL);
		  this->fields.m_deadCountBuffer = v82;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_deadCountBuffer, v83, v84, v85, v104);
		  v86 = (GraphicsBuffer *)sub_18002C620(TypeInfo::UnityEngine::GraphicsBuffer);
		  v87 = v86;
		  if ( !v86 )
		    goto LABEL_25;
		  UnityEngine::GraphicsBuffer::GraphicsBuffer(v86, GraphicsBuffer_Target__Enum_Index, 6, 4, 0LL);
		  this->fields.m_quadIndexBuffer = v87;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.m_quadIndexBuffer, v88, v89, v90, v105);
		  Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::NativeArray(
		    &v106,
		    1,
		    Allocator__Enum_Temp,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::GeneralSystemAttributes>::NativeArray);
		  *(GeneralSystemAttributes *)v106.m_Buffer = this->fields.m_generalSystemAttributes;
		  m_perInstanceData = (GraphicsBuffer *)this->fields.m_generalSystemAttributeBuffer;
		  if ( !m_perInstanceData )
		    goto LABEL_25;
		  sub_1808B4DCC(m_perInstanceData, &v106);
		  Unity::Collections::NativeArray<unsigned int>::NativeArray(
		    &v107,
		    6,
		    Allocator__Enum_Temp,
		    NativeArrayOptions__Enum_ClearMemory,
		    MethodInfo::Unity::Collections::NativeArray<unsigned int>::NativeArray);
		  m_Buffer = v107.m_Buffer;
		  *(_DWORD *)v107.m_Buffer = 0;
		  *(_DWORD *)&m_Buffer[4] = 1;
		  *(_DWORD *)&m_Buffer[8] = 2;
		  *(_DWORD *)&m_Buffer[12] = 2;
		  *(_DWORD *)&m_Buffer[16] = 1;
		  *(_DWORD *)&m_Buffer[20] = 3;
		  m_perInstanceData = this->fields.m_quadIndexBuffer;
		  if ( !m_perInstanceData )
		    goto LABEL_25;
		  UnityEngine::GraphicsBuffer::SetData<unsigned int>(
		    m_perInstanceData,
		    &v107,
		    MethodInfo::UnityEngine::GraphicsBuffer::SetData<unsigned int>);
		}
		
	
		// Methods
		internal virtual void Dispose() {} // 0x0000000189CF94C8-0x0000000189CF9598
		// Void Dispose()
		void HG::Rendering::Runtime::GPUParticleSystemBase::Dispose(GPUParticleSystemBase *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  ComputeBuffer *m_perInstanceBuffer; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(559, 0LL) )
		  {
		    m_perInstanceBuffer = this->fields.m_perInstanceBuffer;
		    if ( m_perInstanceBuffer )
		    {
		      UnityEngine::ComputeBuffer::Dispose(m_perInstanceBuffer, 0LL);
		      m_perInstanceBuffer = this->fields.m_generalSystemAttributeBuffer;
		      if ( m_perInstanceBuffer )
		      {
		        UnityEngine::ComputeBuffer::Dispose(m_perInstanceBuffer, 0LL);
		        m_perInstanceBuffer = this->fields.m_particleAttributesBuffer;
		        if ( m_perInstanceBuffer )
		        {
		          UnityEngine::ComputeBuffer::Dispose(m_perInstanceBuffer, 0LL);
		          m_perInstanceBuffer = this->fields.m_liveListBuffer;
		          if ( m_perInstanceBuffer )
		          {
		            UnityEngine::ComputeBuffer::Dispose(m_perInstanceBuffer, 0LL);
		            m_perInstanceBuffer = this->fields.m_deadListBuffer;
		            if ( m_perInstanceBuffer )
		            {
		              UnityEngine::ComputeBuffer::Dispose(m_perInstanceBuffer, 0LL);
		              m_perInstanceBuffer = this->fields.m_deadCountBuffer;
		              if ( m_perInstanceBuffer )
		              {
		                UnityEngine::ComputeBuffer::Dispose(m_perInstanceBuffer, 0LL);
		                m_perInstanceBuffer = this->fields.m_drawIndirectArgsBuffer;
		                if ( m_perInstanceBuffer )
		                {
		                  UnityEngine::ComputeBuffer::Dispose(m_perInstanceBuffer, 0LL);
		                  m_perInstanceBuffer = (ComputeBuffer *)this->fields.m_quadIndexBuffer;
		                  if ( m_perInstanceBuffer )
		                  {
		                    UnityEngine::GraphicsBuffer::Dispose((GraphicsBuffer *)m_perInstanceBuffer, 0LL);
		                    return;
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_12:
		    sub_1800D8260(m_perInstanceBuffer, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(559, 0LL);
		  if ( !Patch )
		    goto LABEL_12;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		protected int GetGPUIndex(int cpuIndex) => default; // 0x0000000189CF9598-0x0000000189CF9608
		// Int32 GetGPUIndex(Int32)
		int32_t HG::Rendering::Runtime::GPUParticleSystemBase::GetGPUIndex(
		        GPUParticleSystemBase *this,
		        int32_t cpuIndex,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Int32_ *m_instances; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1735, 0LL) )
		  {
		    m_instances = this->fields.m_instances;
		    if ( m_instances )
		      return System::Collections::Generic::List<int>::get_Item(
		               m_instances,
		               cpuIndex,
		               MethodInfo::System::Collections::Generic::List<int>::get_Item);
		LABEL_5:
		    sub_1800D8260(m_instances, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1735, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_235(
		           (ILFixDynamicMethodWrapper_6 *)Patch,
		           (Object *)this,
		           (NaviDirection__Enum)cpuIndex,
		           0LL);
		}
		
		protected virtual void OnInstanceCreated(int gpuIndex, [IsReadOnly] in PerInstanceData perInstanceData) {} // 0x0000000189CF96BC-0x0000000189CF97A8
		// Void OnInstanceCreated(Int32, PerInstanceData ByRef)
		void HG::Rendering::Runtime::GPUParticleSystemBase::OnInstanceCreated(
		        GPUParticleSystemBase *this,
		        int32_t gpuIndex,
		        PerInstanceData *perInstanceData,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  List_1_HG_Rendering_Runtime_VolumetricSHBake_FSHSampleData_ *m_perInstanceData; // rcx
		  Vector4 v9; // xmm1
		  int32_t emitRate; // edi
		  int32_t m_maxParticleEmitRate; // ebx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  VolumetricSHBake_FSHSampleData v13; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1736, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1736, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_695(Patch, (Object *)this, gpuIndex, perInstanceData, 0LL);
		      return;
		    }
		LABEL_9:
		    sub_1800D8260(m_perInstanceData, v7);
		  }
		  m_perInstanceData = (List_1_HG_Rendering_Runtime_VolumetricSHBake_FSHSampleData_ *)this->fields.m_perInstanceData;
		  if ( !m_perInstanceData )
		    goto LABEL_9;
		  v9 = *(Vector4 *)&perInstanceData->emitRate;
		  v13.Direction = perInstanceData->position;
		  v13.SHValue = v9;
		  System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSHBake::FSHSampleData>::set_Item(
		    m_perInstanceData,
		    gpuIndex,
		    &v13,
		    MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::set_Item);
		  m_perInstanceData = (List_1_HG_Rendering_Runtime_VolumetricSHBake_FSHSampleData_ *)this->fields.m_perInstanceBuffer;
		  if ( !m_perInstanceData )
		    goto LABEL_9;
		  UnityEngine::ComputeBuffer::SetData<HG::Rendering::Runtime::PerInstanceData>(
		    (ComputeBuffer *)m_perInstanceData,
		    this->fields.m_perInstanceData,
		    MethodInfo::UnityEngine::ComputeBuffer::SetData<HG::Rendering::Runtime::PerInstanceData>);
		  m_perInstanceData = (List_1_HG_Rendering_Runtime_VolumetricSHBake_FSHSampleData_ *)this->fields.m_instancesToClear;
		  if ( !m_perInstanceData )
		    goto LABEL_9;
		  sub_183081250(m_perInstanceData, (unsigned int)gpuIndex, MethodInfo::System::Collections::Generic::List<int>::Add);
		  emitRate = perInstanceData->emitRate;
		  m_maxParticleEmitRate = this->fields.m_maxParticleEmitRate;
		  sub_1800036A0(TypeInfo::System::Math);
		  if ( emitRate < m_maxParticleEmitRate )
		    emitRate = m_maxParticleEmitRate;
		  this->fields.m_maxParticleEmitRate = emitRate;
		}
		
		protected virtual void OnInstanceRemoved(int gpuIndexToRemove, int gpuIndexToMove) {} // 0x0000000189CF97A8-0x0000000189CF99A4
		// Void OnInstanceRemoved(Int32, Int32)
		void HG::Rendering::Runtime::GPUParticleSystemBase::OnInstanceRemoved(
		        GPUParticleSystemBase *this,
		        int32_t gpuIndexToRemove,
		        int32_t gpuIndexToMove,
		        MethodInfo *method)
		{
		  ComputeBuffer *m_perInstanceBuffer; // rcx
		  int32_t i; // edi
		  List_1_HG_Rendering_Runtime_PerInstanceData_ *m_perInstanceData; // rdx
		  int32_t m_maxParticleEmitRate; // ebx
		  float actualWidth; // eax
		  List_1_HG_Rendering_Runtime_PerInstanceData_ *v12; // rbx
		  int32_t particleAttribSize; // ebx
		  int32_t particleCapacity; // eax
		  ComputeBuffer *m_particleAttributesBuffer; // rsi
		  int32_t size; // edi
		  int32_t v17; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MultiColumnCollectionHeader_ViewState_ColumnState v19; // [rsp+30h] [rbp-58h] BYREF
		  MultiColumnCollectionHeader_ViewState_ColumnState v20; // [rsp+50h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1737, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1737, 0LL);
		    if ( !Patch )
		      goto LABEL_14;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_272(
		      (ILFixDynamicMethodWrapper_6 *)Patch,
		      (Object *)this,
		      (UIInertiaViewPager_State__Enum)gpuIndexToRemove,
		      (UIInertiaViewPager_State__Enum)gpuIndexToMove,
		      0LL);
		  }
		  else
		  {
		    this->fields.m_maxParticleEmitRate = 0;
		    for ( i = 0; i < this->fields.m_gpuInstanceCount; ++i )
		    {
		      if ( i != gpuIndexToRemove )
		      {
		        m_perInstanceData = this->fields.m_perInstanceData;
		        if ( !m_perInstanceData )
		          goto LABEL_14;
		        System::Collections::Generic::List<UnityEngine::UIElements::Internal::MultiColumnCollectionHeader_ViewState::ColumnState>::get_Item(
		          &v20,
		          (List_1_UnityEngine_UIElements_Internal_MultiColumnCollectionHeader_ViewState_ColumnState_ *)m_perInstanceData,
		          i,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::get_Item);
		        m_maxParticleEmitRate = this->fields.m_maxParticleEmitRate;
		        sub_1800036A0(TypeInfo::System::Math);
		        actualWidth = v20.actualWidth;
		        if ( SLODWORD(v20.actualWidth) < m_maxParticleEmitRate )
		          actualWidth = *(float *)&m_maxParticleEmitRate;
		        *(float *)&this->fields.m_maxParticleEmitRate = actualWidth;
		      }
		    }
		    if ( gpuIndexToMove != gpuIndexToRemove )
		    {
		      v12 = this->fields.m_perInstanceData;
		      m_perInstanceData = v12;
		      if ( v12 )
		      {
		        System::Collections::Generic::List<UnityEngine::UIElements::Internal::MultiColumnCollectionHeader_ViewState::ColumnState>::get_Item(
		          &v19,
		          (List_1_UnityEngine_UIElements_Internal_MultiColumnCollectionHeader_ViewState_ColumnState_ *)v12,
		          gpuIndexToMove,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::get_Item);
		        v20 = v19;
		        System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSHBake::FSHSampleData>::set_Item(
		          (List_1_HG_Rendering_Runtime_VolumetricSHBake_FSHSampleData_ *)v12,
		          gpuIndexToRemove,
		          (VolumetricSHBake_FSHSampleData *)&v20,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::PerInstanceData>::set_Item);
		        m_perInstanceBuffer = this->fields.m_perInstanceBuffer;
		        if ( m_perInstanceBuffer )
		        {
		          UnityEngine::ComputeBuffer::SetData<HG::Rendering::Runtime::PerInstanceData>(
		            m_perInstanceBuffer,
		            this->fields.m_perInstanceData,
		            MethodInfo::UnityEngine::ComputeBuffer::SetData<HG::Rendering::Runtime::PerInstanceData>);
		          particleAttribSize = HG::Rendering::Runtime::GPUParticleSystemBase::get_particleAttribSize(this, 0LL);
		          particleCapacity = HG::Rendering::Runtime::GPUParticleSystemBase::get_particleCapacity(this, 0LL);
		          m_particleAttributesBuffer = this->fields.m_particleAttributesBuffer;
		          size = particleAttribSize * particleCapacity;
		          sub_1800036A0(TypeInfo::UnityEngine::Graphics);
		          UnityEngine::Graphics::CopyBuffer(
		            m_particleAttributesBuffer,
		            gpuIndexToMove * size,
		            m_particleAttributesBuffer,
		            gpuIndexToRemove * size,
		            size,
		            0LL);
		          v17 = HG::Rendering::Runtime::GPUParticleSystemBase::get_particleCapacity(this, 0LL);
		          UnityEngine::Graphics::CopyBuffer(
		            this->fields.m_deadListBuffer,
		            gpuIndexToMove * 4 * v17,
		            this->fields.m_deadListBuffer,
		            gpuIndexToRemove * 4 * v17,
		            4 * v17,
		            0LL);
		          UnityEngine::Graphics::CopyBuffer(
		            this->fields.m_deadCountBuffer,
		            4 * gpuIndexToMove,
		            this->fields.m_deadCountBuffer,
		            4 * gpuIndexToRemove,
		            4,
		            0LL);
		          return;
		        }
		      }
		LABEL_14:
		      sub_1800D8260(m_perInstanceBuffer, m_perInstanceData);
		    }
		  }
		}
		
		protected int CreateInstance([IsReadOnly] in PerInstanceData perInstanceData) => default; // 0x0000000189CF93D4-0x0000000189CF94C8
		// Int32 CreateInstance(PerInstanceData ByRef)
		int32_t HG::Rendering::Runtime::GPUParticleSystemBase::CreateInstance(
		        GPUParticleSystemBase *this,
		        PerInstanceData *perInstanceData,
		        MethodInfo *method)
		{
		  List_1_System_Int32_ *v5; // rdx
		  List_1_System_Int32_ *m_instances; // rcx
		  List_1_System_Int32_ *m_freePool; // rax
		  int32_t Item; // eax
		  int32_t v9; // esi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1738, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1738, 0LL);
		    if ( !Patch )
		      goto LABEL_9;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_696(Patch, (Object *)this, perInstanceData, 0LL);
		  }
		  else
		  {
		    m_freePool = this->fields.m_freePool;
		    if ( !m_freePool )
		      goto LABEL_9;
		    if ( m_freePool->fields._size )
		    {
		      Item = System::Collections::Generic::List<int>::get_Item(
		               this->fields.m_freePool,
		               m_freePool->fields._size - 1,
		               MethodInfo::System::Collections::Generic::List<int>::get_Item);
		      v5 = this->fields.m_freePool;
		      v9 = Item;
		      if ( v5 )
		      {
		        System::Collections::Generic::List<unsigned long>::RemoveAt(
		          (List_1_System_UInt64_ *)this->fields.m_freePool,
		          v5->fields._size - 1,
		          MethodInfo::System::Collections::Generic::List<int>::RemoveAt);
		        m_instances = this->fields.m_instances;
		        if ( m_instances )
		        {
		          System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::set_Item(
		            (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)m_instances,
		            v9,
		            (RegexCharClass_SingleRange)this->fields.m_gpuInstanceCount,
		            MethodInfo::System::Collections::Generic::List<int>::set_Item);
		          HG::Rendering::Runtime::GPUParticleSystemBase::OnInstanceCreated(
		            this,
		            this->fields.m_gpuInstanceCount,
		            perInstanceData,
		            0LL);
		          ++this->fields.m_gpuInstanceCount;
		          return v9;
		        }
		      }
		LABEL_9:
		      sub_1800D8260(m_instances, v5);
		    }
		    return -1;
		  }
		}
		
		internal bool RemoveInstance(int index) => default; // 0x0000000189CF99A4-0x0000000189CF9B1C
		// Boolean RemoveInstance(Int32)
		bool HG::Rendering::Runtime::GPUParticleSystemBase::RemoveInstance(
		        GPUParticleSystemBase *this,
		        int32_t index,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  List_1_System_Int32_ *m_instances; // rcx
		  List_1_System_Int32_ *v7; // rax
		  int32_t Item; // eax
		  RegexCharClass_SingleRange v9; // ebp
		  int32_t i; // esi
		  List_1_System_Int32_ *v11; // rax
		  int32_t v12; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1739, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1739, 0LL);
		    if ( !Patch )
		      goto LABEL_18;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_17(
		             (ILFixDynamicMethodWrapper_13 *)Patch,
		             (Object *)this,
		             (NaviDirection__Enum)index,
		             0LL);
		  }
		  else
		  {
		    m_instances = this->fields.m_instances;
		    if ( !m_instances )
		      goto LABEL_18;
		    if ( System::Collections::Generic::List<int>::get_Item(
		           m_instances,
		           index,
		           MethodInfo::System::Collections::Generic::List<int>::get_Item) != -1 )
		    {
		      v7 = this->fields.m_instances;
		      if ( !v7 )
		        goto LABEL_18;
		      if ( index < v7->fields._size )
		      {
		        Item = System::Collections::Generic::List<int>::get_Item(
		                 this->fields.m_instances,
		                 index,
		                 MethodInfo::System::Collections::Generic::List<int>::get_Item);
		        m_instances = this->fields.m_instances;
		        v9 = (RegexCharClass_SingleRange)Item;
		        if ( m_instances )
		        {
		          System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::set_Item(
		            (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)m_instances,
		            index,
		            (RegexCharClass_SingleRange)-1,
		            MethodInfo::System::Collections::Generic::List<int>::set_Item);
		          for ( i = 0; ; ++i )
		          {
		            v11 = this->fields.m_instances;
		            if ( !v11 )
		              goto LABEL_18;
		            if ( i >= v11->fields._size )
		              goto LABEL_14;
		            v12 = System::Collections::Generic::List<int>::get_Item(
		                    this->fields.m_instances,
		                    i,
		                    MethodInfo::System::Collections::Generic::List<int>::get_Item);
		            m_instances = (List_1_System_Int32_ *)(unsigned int)(this->fields.m_gpuInstanceCount - 1);
		            if ( v12 == (_DWORD)m_instances )
		              break;
		          }
		          m_instances = this->fields.m_instances;
		          if ( m_instances )
		          {
		            System::Collections::Generic::List<System::Text::RegularExpressions::RegexCharClass::SingleRange>::set_Item(
		              (List_1_System_Text_RegularExpressions_RegexCharClass_SingleRange_ *)m_instances,
		              i,
		              v9,
		              MethodInfo::System::Collections::Generic::List<int>::set_Item);
		LABEL_14:
		            sub_18008D530(6LL, this, *(unsigned int *)&v9, (unsigned int)(this->fields.m_gpuInstanceCount - 1));
		            m_instances = this->fields.m_freePool;
		            if ( m_instances )
		            {
		              sub_183081250(m_instances, (unsigned int)index, MethodInfo::System::Collections::Generic::List<int>::Add);
		              --this->fields.m_gpuInstanceCount;
		              return 1;
		            }
		          }
		        }
		LABEL_18:
		        sub_1800D8260(m_instances, v5);
		      }
		    }
		    return 0;
		  }
		}
		
		internal virtual GPUParticleSystemManager.SimulateContext AcquireSimulateContext() => default; // 0x0000000189CF91E4-0x0000000189CF93D4
		// GPUParticleSystemManager+SimulateContext AcquireSimulateContext()
		GPUParticleSystemManager_SimulateContext *HG::Rendering::Runtime::GPUParticleSystemBase::AcquireSimulateContext(
		        GPUParticleSystemManager_SimulateContext *__return_ptr retstr,
		        GPUParticleSystemBase *this,
		        MethodInfo *method)
		{
		  List_1_System_Int32_ *v5; // rdx
		  __int64 v6; // rcx
		  List_1_System_Int32_ *m_instancesToClear; // rax
		  Action_1_Google_Protobuf_IMessage_ *v8; // rsi
		  Int32__Array *v9; // rax
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Int32__Array **v12; // r9
		  Type *v13; // rdx
		  PropertyInfo_1 *v14; // r8
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  Type *v17; // rdx
		  PropertyInfo_1 *v18; // r8
		  Type *v19; // rdx
		  PropertyInfo_1 *v20; // r8
		  Type *v21; // rdx
		  PropertyInfo_1 *v22; // r8
		  Type *v23; // rdx
		  PropertyInfo_1 *v24; // r8
		  Type *v25; // rdx
		  PropertyInfo_1 *v26; // r8
		  Type *v27; // rdx
		  PropertyInfo_1 *v28; // r8
		  GeneralSystemAttributes m_generalSystemAttributes; // xmm0
		  int32_t m_maxParticleEmitRate; // eax
		  Type *v31; // rdx
		  PropertyInfo_1 *v32; // r8
		  Int32__Array **v33; // r9
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  __int128 v36; // xmm1
		  __int128 v37; // xmm0
		  GeneralSystemAttributes generalSystemAttributes; // xmm1
		  __int128 v39; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  GPUParticleSystemManager_SimulateContext *v41; // rax
		  __int128 v42; // xmm1
		  __int128 v43; // xmm0
		  __int128 v44; // xmm1
		  __int128 v45; // xmm0
		  GPUParticleSystemManager_SimulateContext *result; // rax
		  __int128 v47; // [rsp+28h] [rbp-89h] BYREF
		  __int128 v48; // [rsp+38h] [rbp-79h] BYREF
		  __int128 v49; // [rsp+48h] [rbp-69h] BYREF
		  __int128 v50; // [rsp+58h] [rbp-59h] BYREF
		  SingleFieldAccessor v51[2]; // [rsp+68h] [rbp-49h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1740, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1740, 0LL);
		    if ( Patch )
		    {
		      v41 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_697(
		              (GPUParticleSystemManager_SimulateContext *)&v51[0].fields.hasDelegate,
		              Patch,
		              (Object *)this,
		              0LL);
		      v42 = *(_OWORD *)&v41->perInstanceBuffer;
		      *(_OWORD *)&retstr->emitShader = *(_OWORD *)&v41->emitShader;
		      v43 = *(_OWORD *)&v41->systemAttributesBuffer;
		      *(_OWORD *)&retstr->perInstanceBuffer = v42;
		      v44 = *(_OWORD *)&v41->liveListBuffer;
		      *(_OWORD *)&retstr->systemAttributesBuffer = v43;
		      v45 = *(_OWORD *)&v41->deadCountBuffer;
		      *(_OWORD *)&retstr->liveListBuffer = v44;
		      generalSystemAttributes = v41->generalSystemAttributes;
		      *(_OWORD *)&retstr->deadCountBuffer = v45;
		      v39 = *(_OWORD *)&v41->instanceCount;
		      goto LABEL_10;
		    }
		    goto LABEL_8;
		  }
		  m_instancesToClear = this->fields.m_instancesToClear;
		  v8 = 0LL;
		  if ( !m_instancesToClear )
		    goto LABEL_8;
		  if ( m_instancesToClear->fields._size )
		  {
		    v9 = System::Collections::Generic::List<int>::ToArray(
		           this->fields.m_instancesToClear,
		           MethodInfo::System::Collections::Generic::List<int>::ToArray);
		    v5 = this->fields.m_instancesToClear;
		    v8 = (Action_1_Google_Protobuf_IMessage_ *)v9;
		    if ( v5 )
		    {
		      ++v5->fields._version;
		      v5->fields._size = 0;
		      goto LABEL_6;
		    }
		LABEL_8:
		    sub_1800D8260(v6, v5);
		  }
		LABEL_6:
		  sub_18033B9D0((char *)&v47 + 8, 0LL, 104LL);
		  *(_QWORD *)&v47 = this->fields.m_shaders.emitShader;
		  ((void (__stdcall *)(SingleFieldAccessor *, Type *, PropertyInfo_1 *, Int32__Array **))sub_18002D1B0)(
		    (SingleFieldAccessor *)&v47,
		    v10,
		    v11,
		    v12);
		  *((_QWORD *)&v47 + 1) = this->fields.m_shaders.simulateShader;
		  sub_18002D1B0((SingleFieldAccessor *)((char *)&v47 + 8), v13, v14, *((Int32__Array ***)&v47 + 1), (MethodInfo *)v47);
		  *(_QWORD *)&v48 = this->fields.m_perInstanceBuffer;
		  sub_18002D1B0((SingleFieldAccessor *)&v48, v15, v16, (Int32__Array **)v48, (MethodInfo *)v47);
		  *((_QWORD *)&v48 + 1) = this->fields.m_generalSystemAttributeBuffer;
		  sub_18002D1B0((SingleFieldAccessor *)((char *)&v48 + 8), v17, v18, *((Int32__Array ***)&v48 + 1), (MethodInfo *)v47);
		  *((_QWORD *)&v49 + 1) = this->fields.m_particleAttributesBuffer;
		  sub_18002D1B0((SingleFieldAccessor *)((char *)&v49 + 8), v19, v20, *((Int32__Array ***)&v49 + 1), (MethodInfo *)v47);
		  *(_QWORD *)&v50 = this->fields.m_liveListBuffer;
		  sub_18002D1B0((SingleFieldAccessor *)&v50, v21, v22, (Int32__Array **)v50, (MethodInfo *)v47);
		  *((_QWORD *)&v50 + 1) = this->fields.m_deadListBuffer;
		  sub_18002D1B0((SingleFieldAccessor *)((char *)&v50 + 8), v23, v24, *((Int32__Array ***)&v50 + 1), (MethodInfo *)v47);
		  v51[0].klass = (SingleFieldAccessor__Class *)this->fields.m_deadCountBuffer;
		  sub_18002D1B0(v51, v25, v26, (Int32__Array **)v51[0].klass, (MethodInfo *)v47);
		  v51[0].monitor = (MonitorData *)this->fields.m_drawIndirectArgsBuffer;
		  sub_18002D1B0((SingleFieldAccessor *)&v51[0].monitor, v27, v28, (Int32__Array **)v51[0].monitor, (MethodInfo *)v47);
		  m_generalSystemAttributes = this->fields.m_generalSystemAttributes;
		  LODWORD(v51[0].fields.setValueDelegate) = this->fields.m_gpuInstanceCount;
		  m_maxParticleEmitRate = this->fields.m_maxParticleEmitRate;
		  v51[0].fields._ = (FieldAccessorBase__Fields)m_generalSystemAttributes;
		  HIDWORD(v51[0].fields.setValueDelegate) = m_maxParticleEmitRate;
		  v51[0].fields.clearDelegate = v8;
		  sub_18002D1B0((SingleFieldAccessor *)&v51[0].fields.clearDelegate, v31, v32, v33, (MethodInfo *)v47);
		  v34 = v48;
		  *(_OWORD *)&retstr->emitShader = v47;
		  v35 = v49;
		  *(_OWORD *)&retstr->perInstanceBuffer = v34;
		  v36 = v50;
		  *(_OWORD *)&retstr->systemAttributesBuffer = v35;
		  v37 = *(_OWORD *)&v51[0].klass;
		  *(_OWORD *)&retstr->liveListBuffer = v36;
		  generalSystemAttributes = (GeneralSystemAttributes)v51[0].fields._;
		  *(_OWORD *)&retstr->deadCountBuffer = v37;
		  v39 = *(_OWORD *)&v51[0].fields.setValueDelegate;
		LABEL_10:
		  result = retstr;
		  retstr->generalSystemAttributes = generalSystemAttributes;
		  *(_OWORD *)&retstr->instanceCount = v39;
		  return result;
		}
		
		internal virtual GPUParticleSystemManager.RenderContext AcquireRenderContext() => default; // 0x0000000189CF90B8-0x0000000189CF91E4
		// GPUParticleSystemManager+RenderContext AcquireRenderContext()
		GPUParticleSystemManager_RenderContext *HG::Rendering::Runtime::GPUParticleSystemBase::AcquireRenderContext(
		        GPUParticleSystemManager_RenderContext *__return_ptr retstr,
		        GPUParticleSystemBase *this,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  Type *v8; // rdx
		  PropertyInfo_1 *v9; // r8
		  Type *v10; // rdx
		  PropertyInfo_1 *v11; // r8
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Type *v14; // rdx
		  PropertyInfo_1 *v15; // r8
		  Type *v16; // rdx
		  PropertyInfo_1 *v17; // r8
		  __int128 v18; // xmm1
		  int32_t m_gpuInstanceCount; // r9d
		  FieldAccessorBase__Fields v20; // xmm0
		  __int128 v21; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v23; // rdx
		  __int64 v24; // rcx
		  GPUParticleSystemManager_RenderContext *v25; // rax
		  __int128 v26; // xmm1
		  GPUParticleSystemManager_RenderContext *result; // rax
		  __int128 v28; // [rsp+20h] [rbp-29h] BYREF
		  SingleFieldAccessor v29[2]; // [rsp+30h] [rbp-19h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1741, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1741, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v24, v23);
		    v25 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_698(
		            (GPUParticleSystemManager_RenderContext *)&v29[0].fields.hasDelegate,
		            Patch,
		            (Object *)this,
		            0LL);
		    v26 = *(_OWORD *)&v25->drawIndirectArgsBuffer;
		    *(_OWORD *)&retstr->mesh = *(_OWORD *)&v25->mesh;
		    v20 = *(FieldAccessorBase__Fields *)&v25->particleAttributesBuffer;
		    *(_OWORD *)&retstr->drawIndirectArgsBuffer = v26;
		    v21 = *(_OWORD *)&v25->generalSystemAttributeBuffer;
		  }
		  else
		  {
		    sub_18033B9D0(&v28, 0LL, 64LL);
		    v29[0].fields._.getValueDelegate = (Func_2_Google_Protobuf_IMessage_Object_ *)this->fields.m_particleAttributesBuffer;
		    sub_18002D1B0((SingleFieldAccessor *)&v29[0].fields, v5, v6, v7, (MethodInfo *)v28);
		    v29[0].fields._.descriptor = (FieldDescriptor *)this->fields.m_liveListBuffer;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&v29[0].fields._.descriptor,
		      v8,
		      v9,
		      (Int32__Array **)v29[0].fields._.descriptor,
		      (MethodInfo *)v28);
		    *((_QWORD *)&v28 + 1) = this->fields.m_quadIndexBuffer;
		    sub_18002D1B0((SingleFieldAccessor *)((char *)&v28 + 8), v10, v11, *((Int32__Array ***)&v28 + 1), (MethodInfo *)v28);
		    v29[0].klass = (SingleFieldAccessor__Class *)this->fields.m_drawIndirectArgsBuffer;
		    sub_18002D1B0(v29, v12, v13, (Int32__Array **)v29[0].klass, (MethodInfo *)v28);
		    v29[0].fields.setValueDelegate = (Action_2_Google_Protobuf_IMessage_Object_ *)this->fields.m_generalSystemAttributeBuffer;
		    sub_18002D1B0(
		      (SingleFieldAccessor *)&v29[0].fields.setValueDelegate,
		      v14,
		      v15,
		      (Int32__Array **)v29[0].fields.setValueDelegate,
		      (MethodInfo *)v28);
		    v29[0].monitor = (MonitorData *)this->fields.m_material;
		    sub_18002D1B0((SingleFieldAccessor *)&v29[0].monitor, v16, v17, (Int32__Array **)v29[0].monitor, (MethodInfo *)v28);
		    v18 = *(_OWORD *)&v29[0].klass;
		    m_gpuInstanceCount = this->fields.m_gpuInstanceCount;
		    *(_OWORD *)&retstr->mesh = v28;
		    LODWORD(v29[0].fields.clearDelegate) = m_gpuInstanceCount;
		    v20 = v29[0].fields._;
		    *(_OWORD *)&retstr->drawIndirectArgsBuffer = v18;
		    v21 = *(_OWORD *)&v29[0].fields.setValueDelegate;
		  }
		  *(FieldAccessorBase__Fields *)&retstr->particleAttributesBuffer = v20;
		  result = retstr;
		  *(_OWORD *)&retstr->generalSystemAttributeBuffer = v21;
		  return result;
		}
		
		internal void Modify([IsReadOnly] in GeneralSystemAttributes generalSystemAttributes) {} // 0x0000000189CF9608-0x0000000189CF96BC
		// Void Modify(GeneralSystemAttributes ByRef)
		void HG::Rendering::Runtime::GPUParticleSystemBase::Modify(
		        GPUParticleSystemBase *this,
		        GeneralSystemAttributes *generalSystemAttributes,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  ComputeBuffer *m_generalSystemAttributeBuffer; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  NativeArray_1_Beyond_Gameplay_Core_AtmosphereNpcMgr_AtmosphereNpcAoiController_AoiResult_ v8; // [rsp+30h] [rbp-18h] BYREF
		
		  v8 = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(1742, 0LL) )
		  {
		    this->fields.m_generalSystemAttributes = *generalSystemAttributes;
		    Unity::Collections::NativeArray<Beyond::Gameplay::Core::AtmosphereNpcMgr_AtmosphereNpcAoiController::AoiResult>::NativeArray(
		      &v8,
		      1,
		      Allocator__Enum_Temp,
		      NativeArrayOptions__Enum_ClearMemory,
		      MethodInfo::Unity::Collections::NativeArray<HG::Rendering::Runtime::GeneralSystemAttributes>::NativeArray);
		    *(GeneralSystemAttributes *)v8.m_Buffer = *generalSystemAttributes;
		    m_generalSystemAttributeBuffer = this->fields.m_generalSystemAttributeBuffer;
		    if ( m_generalSystemAttributeBuffer )
		    {
		      sub_1808B4DCC(m_generalSystemAttributeBuffer, &v8);
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(m_generalSystemAttributeBuffer, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1742, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_699(Patch, (Object *)this, generalSystemAttributes, 0LL);
		}
		
	}
}
