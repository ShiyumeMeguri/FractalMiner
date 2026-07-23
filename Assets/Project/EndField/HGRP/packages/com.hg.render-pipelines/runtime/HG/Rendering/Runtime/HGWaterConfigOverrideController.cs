using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal sealed class HGWaterConfigOverrideController // TypeDefIndex: 38780
	{
		// Fields
		private const int MAX_ACTIVE_OVERRIDES = 4; // Metadata: 0x0230424C
		private readonly WaterConfigOverride[] m_waterConfigOverrides; // 0x10
		private readonly List<int> m_activeWaterConfigOverrideIndices; // 0x18
		private readonly List<WaterConfigAdjustment> m_frameAppliedWaterConfigAdjustments; // 0x20
		private readonly List<HGWaterConfig.MaterialData> m_frameOriginalWaterConfigData; // 0x28
	
		// Properties
		public bool HasOverrides { get => default; } // 0x000000018334DB30-0x000000018334DBA0 
		// Boolean get_HasOverrides()
		bool HG::Rendering::Runtime::HGWaterConfigOverrideController::get_HasOverrides(
		        HGWaterConfigOverrideController *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  List_1_System_Int32_ *m_activeWaterConfigOverrideIndices; // rax
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
		  if ( wrapperArray->max_length.size <= 1029 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_7;
		  if ( LODWORD(v3->_0.namespaze) <= 0x405 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[21].vtable.ToString.method )
		  {
		LABEL_5:
		    m_activeWaterConfigOverrideIndices = this->fields.m_activeWaterConfigOverrideIndices;
		    if ( m_activeWaterConfigOverrideIndices )
		      return m_activeWaterConfigOverrideIndices->fields._size > 0;
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1029, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
	
		// Nested types
		private struct WaterConfigOverride // TypeDefIndex: 38778
		{
			// Fields
			public bool active; // 0x00
			public HGWaterConfig targetConfig; // 0x08
			public float lerpFactor; // 0x10
		}
	
		private struct WaterConfigAdjustment // TypeDefIndex: 38779
		{
			// Fields
			public bool active; // 0x00
			public int materialIndex; // 0x04
			public HGWaterConfig targetConfig; // 0x08
			public float lerpFactor; // 0x10
		}
	
		// Constructors
		public HGWaterConfigOverrideController() {} // 0x0000000182ED7560-0x0000000182ED76A0
		// HGWaterConfigOverrideController()
		void HG::Rendering::Runtime::HGWaterConfigOverrideController::HGWaterConfigOverrideController(
		        HGWaterConfigOverrideController *this,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v3; // rdx
		  HGRuntimeGrassQuery_Node *v4; // r8
		  Int32__Array **v5; // r9
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  __int64 v8; // rdi
		  __int64 v9; // rax
		  HGRuntimeGrassQuery_Node *v10; // rdx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  Int32__Array **v12; // r9
		  HGRuntimeGrassQuery_Node *v13; // rdx
		  HGRuntimeGrassQuery_Node *v14; // r8
		  Int32__Array **v15; // r9
		  __int64 v16; // rdi
		  __int64 v17; // rax
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  Int32__Array **v20; // r9
		  HGRuntimeGrassQuery_Node *v21; // rdx
		  HGRuntimeGrassQuery_Node *v22; // r8
		  Int32__Array **v23; // r9
		  __int64 v24; // rdi
		  __int64 v25; // rax
		  HGRuntimeGrassQuery_Node *v26; // rdx
		  HGRuntimeGrassQuery_Node *v27; // r8
		  Int32__Array **v28; // r9
		  HGRuntimeGrassQuery_Node *v29; // rdx
		  HGRuntimeGrassQuery_Node *v30; // r8
		  Int32__Array **v31; // r9
		  MethodInfo *v32; // [rsp+20h] [rbp-8h]
		  MethodInfo *v33; // [rsp+20h] [rbp-8h]
		  MethodInfo *v34; // [rsp+20h] [rbp-8h]
		  MethodInfo *v35; // [rsp+20h] [rbp-8h]
		  MethodInfo *v36; // [rsp+20h] [rbp-8h]
		  MethodInfo *v37; // [rsp+20h] [rbp-8h]
		  MethodInfo *v38; // [rsp+50h] [rbp+28h]
		
		  this->fields.m_waterConfigOverrides = (HGWaterConfigOverrideController_WaterConfigOverride__Array *)il2cpp_array_new_specific_1(TypeInfo::HG::Rendering::Runtime::HGWaterConfigOverrideController::WaterConfigOverride, 64LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v3, v4, v5, v32);
		  v8 = sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
		  if ( !v8 )
		    goto LABEL_2;
		  v9 = ((__int64 (__fastcall *)(_QWORD))sub_18011C4C0)((const Il2CppRGCTXData)MethodInfo::System::Collections::Generic::List<int>::List->klass->rgctx_data[1].rgctxDataDummy);
		  *(_QWORD *)(v8 + 16) = il2cpp_array_new_specific_1(v9, 4LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v8 + 16), v10, v11, v12, v33);
		  this->fields.m_activeWaterConfigOverrideIndices = (List_1_System_Int32_ *)v8;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_activeWaterConfigOverrideIndices, v13, v14, v15, v34);
		  v16 = sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterConfigOverrideController::WaterConfigAdjustment>);
		  if ( !v16
		    || (v17 = ((__int64 (__fastcall *)(_QWORD))sub_18011C4C0)((const Il2CppRGCTXData)MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterConfigOverrideController::WaterConfigAdjustment>::List->klass->rgctx_data[1].rgctxDataDummy),
		        *(_QWORD *)(v16 + 16) = il2cpp_array_new_specific_1(v17, 4LL),
		        sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v16 + 16), v18, v19, v20, v35),
		        this->fields.m_frameAppliedWaterConfigAdjustments = (List_1_HG_Rendering_Runtime_HGWaterConfigOverrideController_WaterConfigAdjustment_ *)v16,
		        sub_18002D1B0(
		          (HGRuntimeGrassQuery_Node *)&this->fields.m_frameAppliedWaterConfigAdjustments,
		          v21,
		          v22,
		          v23,
		          v36),
		        (v24 = sub_1800368D0(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterConfig::MaterialData>)) == 0) )
		  {
		LABEL_2:
		    sub_1800D8260(v7, v6);
		  }
		  v25 = ((__int64 (__fastcall *)(_QWORD))sub_18011C4C0)((const Il2CppRGCTXData)MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterConfig::MaterialData>::List->klass->rgctx_data[1].rgctxDataDummy);
		  *(_QWORD *)(v24 + 16) = il2cpp_array_new_specific_1(v25, 4LL);
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v24 + 16), v26, v27, v28, v37);
		  this->fields.m_frameOriginalWaterConfigData = (List_1_HG_Rendering_Runtime_HGWaterConfig_MaterialData_ *)v24;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields.m_frameOriginalWaterConfigData, v29, v30, v31, v38);
		}
		
	
		// Methods
		public bool SetOverride(int materialIndex, HGWaterConfig targetConfig, float lerpFactor) => default; // 0x0000000189C62AB0-0x0000000189C62C70
		// Boolean SetOverride(Int32, HGWaterConfig, Single)
		bool HG::Rendering::Runtime::HGWaterConfigOverrideController::SetOverride(
		        HGWaterConfigOverrideController *this,
		        int32_t materialIndex,
		        HGWaterConfig *targetConfig,
		        float lerpFactor,
		        MethodInfo *method)
		{
		  float v5; // xmm1_4
		  __int64 v6; // rdi
		  HGRuntimeGrassQuery_Node *v9; // rdx
		  HGWaterConfigOverrideController_WaterConfigOverride__Array *m_waterConfigOverrides; // rcx
		  HGRuntimeGrassQuery_Node *v11; // r8
		  List_1_System_Int32_ *m_activeWaterConfigOverrideIndices; // rax
		  Int32__Array **v13; // r9
		  Beyond::JobMathf *v14; // rcx
		  __int64 v15; // r9
		  Object *v17; // rbx
		  Object *v18; // rax
		  Object *v19; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *P3; // [rsp+20h] [rbp-60h]
		  int v22; // [rsp+30h] [rbp-50h] BYREF
		  __int128 v23; // [rsp+38h] [rbp-48h] BYREF
		  __int64 v24; // [rsp+48h] [rbp-38h]
		  __int128 v25; // [rsp+50h] [rbp-30h] BYREF
		  __int64 v26; // [rsp+60h] [rbp-20h]
		
		  v6 = materialIndex;
		  if ( IFix::WrappersManagerImpl::IsPatched(5334, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5334, 0LL);
		    if ( !Patch )
		      goto LABEL_14;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1547(
		             Patch,
		             (Object *)this,
		             v6,
		             (Object *)targetConfig,
		             lerpFactor,
		             0LL);
		  }
		  else
		  {
		    if ( HG::Rendering::Runtime::HGWaterConfigOverrideController::IsValidWaterConfigMaterialIndex(v6, 0LL) )
		    {
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Equality((Object_1 *)targetConfig, 0LL, 0LL) )
		      {
		        m_waterConfigOverrides = this->fields.m_waterConfigOverrides;
		        if ( !m_waterConfigOverrides )
		          goto LABEL_14;
		        if ( *(_BYTE *)sub_1803C0734(m_waterConfigOverrides, v6) )
		          goto LABEL_9;
		        m_activeWaterConfigOverrideIndices = this->fields.m_activeWaterConfigOverrideIndices;
		        if ( !m_activeWaterConfigOverrideIndices )
		          goto LABEL_14;
		        if ( m_activeWaterConfigOverrideIndices->fields._size < 4 )
		        {
		          sub_183081250(
		            this->fields.m_activeWaterConfigOverrideIndices,
		            (unsigned int)v6,
		            MethodInfo::System::Collections::Generic::List<int>::Add);
		LABEL_9:
		          v13 = (Int32__Array **)this->fields.m_waterConfigOverrides;
		          *(_QWORD *)&v23 = 1LL;
		          *((_QWORD *)&v23 + 1) = targetConfig;
		          v24 = 0LL;
		          sub_18002D1B0((HGRuntimeGrassQuery_Node *)((char *)&v23 + 8), v9, v11, v13, P3);
		          Beyond::JobMathf::Clamp01(v14, v5);
		          *(float *)&v24 = lerpFactor;
		          if ( v15 )
		          {
		            v25 = v23;
		            v26 = v24;
		            sub_1804B2EDC(v15, v6, &v25);
		            return 1;
		          }
		LABEL_14:
		          sub_1800D8260(m_waterConfigOverrides, v9);
		        }
		        v22 = 4;
		        v17 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v22);
		        v22 = v6;
		        v18 = (Object *)il2cpp_value_box_0(TypeInfo::System::Int32, &v22);
		        v19 = (Object *)System::String::Format(
		                          (String *)"[HGWaterConfigOverride] capacity ({0}) exceeded; ignoring override for material index {1}.",
		                          v17,
		                          v18,
		                          0LL);
		        sub_1800036A0(TypeInfo::UnityEngine::Debug);
		        UnityEngine::Debug::LogWarning(v19, 0LL);
		      }
		    }
		    return 0;
		  }
		}
		
		public bool SetOverrideFactor(int materialIndex, float lerpFactor) => default; // 0x0000000189C629B4-0x0000000189C62AB0
		// Boolean SetOverrideFactor(Int32, Single)
		bool HG::Rendering::Runtime::HGWaterConfigOverrideController::SetOverrideFactor(
		        HGWaterConfigOverrideController *this,
		        int32_t materialIndex,
		        float lerpFactor,
		        MethodInfo *method)
		{
		  float v4; // xmm1_4
		  __int64 v5; // rbx
		  __int64 v8; // rdx
		  HGWaterConfigOverrideController_WaterConfigOverride__Array *m_waterConfigOverrides; // rcx
		  __int128 v10; // xmm2
		  Beyond::JobMathf *v11; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v14; // [rsp+30h] [rbp-58h] BYREF
		  float v15[4]; // [rsp+40h] [rbp-48h]
		  __int128 v16; // [rsp+50h] [rbp-38h] BYREF
		  __int64 v17; // [rsp+60h] [rbp-28h]
		
		  v5 = materialIndex;
		  if ( IFix::WrappersManagerImpl::IsPatched(5335, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5335, 0LL);
		    if ( !Patch )
		      goto LABEL_10;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1548(Patch, (Object *)this, v5, lerpFactor, 0LL);
		  }
		  else
		  {
		    if ( HG::Rendering::Runtime::HGWaterConfigOverrideController::IsValidWaterConfigMaterialIndex(v5, 0LL) )
		    {
		      m_waterConfigOverrides = this->fields.m_waterConfigOverrides;
		      if ( !m_waterConfigOverrides )
		        goto LABEL_10;
		      if ( *(_BYTE *)sub_1803C0734(m_waterConfigOverrides, v5) )
		      {
		        m_waterConfigOverrides = this->fields.m_waterConfigOverrides;
		        if ( m_waterConfigOverrides )
		        {
		          sub_1803C07D0(m_waterConfigOverrides, &v14, v5);
		          v10 = v14;
		          Beyond::JobMathf::Clamp01(v11, v4);
		          m_waterConfigOverrides = this->fields.m_waterConfigOverrides;
		          v15[0] = lerpFactor;
		          if ( m_waterConfigOverrides )
		          {
		            v17 = *(_QWORD *)v15;
		            v16 = v10;
		            sub_1804B2EDC(m_waterConfigOverrides, v5, &v16);
		            return 1;
		          }
		        }
		LABEL_10:
		        sub_1800D8260(m_waterConfigOverrides, v8);
		      }
		    }
		    return 0;
		  }
		}
		
		public bool ClearOverride(int materialIndex) => default; // 0x0000000189C625A0-0x0000000189C62650
		// Boolean ClearOverride(Int32)
		bool HG::Rendering::Runtime::HGWaterConfigOverrideController::ClearOverride(
		        HGWaterConfigOverrideController *this,
		        int32_t materialIndex,
		        MethodInfo *method)
		{
		  __int64 v3; // rbx
		  __int64 v5; // rdx
		  List_1_System_Int32_ *m_waterConfigOverrides; // rcx
		  __int64 v7; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = materialIndex;
		  if ( IFix::WrappersManagerImpl::IsPatched(5336, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5336, 0LL);
		    if ( !Patch )
		      goto LABEL_10;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_17(
		             (ILFixDynamicMethodWrapper_13 *)Patch,
		             (Object *)this,
		             (NaviDirection__Enum)v3,
		             0LL);
		  }
		  else
		  {
		    if ( HG::Rendering::Runtime::HGWaterConfigOverrideController::IsValidWaterConfigMaterialIndex(v3, 0LL) )
		    {
		      m_waterConfigOverrides = (List_1_System_Int32_ *)this->fields.m_waterConfigOverrides;
		      if ( !m_waterConfigOverrides )
		        goto LABEL_10;
		      if ( *(_BYTE *)sub_1803C0734(m_waterConfigOverrides, v3) )
		      {
		        m_waterConfigOverrides = (List_1_System_Int32_ *)this->fields.m_waterConfigOverrides;
		        if ( m_waterConfigOverrides )
		        {
		          v7 = sub_1803C0734(m_waterConfigOverrides, v3);
		          *(_OWORD *)v7 = 0LL;
		          *(_QWORD *)(v7 + 16) = 0LL;
		          m_waterConfigOverrides = this->fields.m_activeWaterConfigOverrideIndices;
		          if ( m_waterConfigOverrides )
		          {
		            System::Collections::Generic::List<int>::Remove(
		              m_waterConfigOverrides,
		              v3,
		              MethodInfo::System::Collections::Generic::List<int>::Remove);
		            return 1;
		          }
		        }
		LABEL_10:
		        sub_1800D8260(m_waterConfigOverrides, v5);
		      }
		    }
		    return 0;
		  }
		}
		
		public void ApplyForFrame(ref NativeArray<Vector4> waterGPUData) {} // 0x0000000189C62430-0x0000000189C625A0
		// Void ApplyForFrame(NativeArray`1[UnityEngine.Vector4] ByRef)
		void HG::Rendering::Runtime::HGWaterConfigOverrideController::ApplyForFrame(
		        HGWaterConfigOverrideController *this,
		        NativeArray_1_UnityEngine_Vector4_ *waterGPUData,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGWaterConfigOverrideController_WaterConfigOverride__Array *m_waterConfigOverrides; // rcx
		  int32_t i; // ebx
		  List_1_System_Int32_ *m_activeWaterConfigOverrideIndices; // rax
		  int32_t Item; // eax
		  int32_t v10; // esi
		  Object_1 *v11; // r14
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  float v14; // xmm1_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGWaterConfigOverrideController_WaterConfigAdjustment v16; // [rsp+20h] [rbp-60h] BYREF
		  HGWaterConfigOverrideController_WaterConfigAdjustment adjustment; // [rsp+38h] [rbp-48h] BYREF
		  _BYTE v18[8]; // [rsp+50h] [rbp-30h] BYREF
		  Object_1 *x; // [rsp+58h] [rbp-28h]
		  float v20; // [rsp+60h] [rbp-20h]
		
		  memset(&adjustment, 0, sizeof(adjustment));
		  memset(&v16, 0, sizeof(v16));
		  if ( !IFix::WrappersManagerImpl::IsPatched(1030, 0LL) )
		  {
		    for ( i = 0; ; ++i )
		    {
		      m_activeWaterConfigOverrideIndices = this->fields.m_activeWaterConfigOverrideIndices;
		      if ( !m_activeWaterConfigOverrideIndices )
		        break;
		      if ( i >= m_activeWaterConfigOverrideIndices->fields._size )
		        return;
		      Item = System::Collections::Generic::List<int>::get_Item(
		               this->fields.m_activeWaterConfigOverrideIndices,
		               i,
		               MethodInfo::System::Collections::Generic::List<int>::get_Item);
		      m_waterConfigOverrides = this->fields.m_waterConfigOverrides;
		      v10 = Item;
		      if ( !m_waterConfigOverrides )
		        break;
		      sub_1803C07D0(m_waterConfigOverrides, v18, Item);
		      if ( v18[0] )
		      {
		        sub_1800036A0(TypeInfo::UnityEngine::Object);
		        v11 = x;
		        if ( !UnityEngine::Object::op_Equality(x, 0LL, 0LL) )
		        {
		          v14 = v20;
		          if ( v20 > 0.0 )
		          {
		            *(_QWORD *)&v16.lerpFactor = 0LL;
		            *(_DWORD *)&v16.active = 1;
		            v16.materialIndex = v10;
		            v16.targetConfig = (HGWaterConfig *)v11;
		            sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v16.targetConfig, v5, v12, v13, *(MethodInfo **)&v16.active);
		            v16.lerpFactor = v14;
		            adjustment = v16;
		            HG::Rendering::Runtime::HGWaterConfigOverrideController::ApplyAdjustmentForFrame(
		              this,
		              waterGPUData,
		              &adjustment,
		              0LL);
		          }
		        }
		      }
		    }
		LABEL_12:
		    sub_1800D8260(m_waterConfigOverrides, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1030, 0LL);
		  if ( !Patch )
		    goto LABEL_12;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_399(Patch, (Object *)this, waterGPUData, 0LL);
		}
		
		public void RestoreFrame(ref NativeArray<Vector4> waterGPUData) {} // 0x0000000189C62890-0x0000000189C629B4
		// Void RestoreFrame(NativeArray`1[UnityEngine.Vector4] ByRef)
		void HG::Rendering::Runtime::HGWaterConfigOverrideController::RestoreFrame(
		        HGWaterConfigOverrideController *this,
		        NativeArray_1_UnityEngine_Vector4_ *waterGPUData,
		        MethodInfo *method)
		{
		  List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *m_frameOriginalWaterConfigData; // rdx
		  List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *v6; // rcx
		  List_1_HG_Rendering_Runtime_HGWaterConfigOverrideController_WaterConfigAdjustment_ *m_frameAppliedWaterConfigAdjustments; // rdi
		  int32_t size; // edi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGWaterConfig_MaterialData v10; // [rsp+20h] [rbp-50h] BYREF
		  HGWaterConfig_MaterialData originalData; // [rsp+30h] [rbp-40h] BYREF
		  __int64 v12; // [rsp+40h] [rbp-30h]
		  HGWaterConfigOverrideController_WaterConfigAdjustment adjustment; // [rsp+50h] [rbp-20h] BYREF
		
		  memset(&adjustment, 0, sizeof(adjustment));
		  if ( !IFix::WrappersManagerImpl::IsPatched(1040, 0LL) )
		  {
		    m_frameAppliedWaterConfigAdjustments = this->fields.m_frameAppliedWaterConfigAdjustments;
		    if ( m_frameAppliedWaterConfigAdjustments )
		    {
		      size = m_frameAppliedWaterConfigAdjustments->fields._size;
		      while ( --size >= 0 )
		      {
		        m_frameOriginalWaterConfigData = (List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *)this->fields.m_frameAppliedWaterConfigAdjustments;
		        if ( !m_frameOriginalWaterConfigData )
		          goto LABEL_12;
		        System::Collections::Generic::List<Beyond::UI::UIText_RichTextAnalyzer::RichTextParam>::get_Item(
		          (UIText_RichTextAnalyzer_RichTextParam *)&originalData,
		          m_frameOriginalWaterConfigData,
		          size,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterConfigOverrideController::WaterConfigAdjustment>::get_Item);
		        m_frameOriginalWaterConfigData = (List_1_Beyond_UI_UIText_RichTextAnalyzer_RichTextParam_ *)this->fields.m_frameOriginalWaterConfigData;
		        *(_QWORD *)&adjustment.lerpFactor = v12;
		        *(HGWaterConfig_MaterialData *)&adjustment.active = originalData;
		        if ( !m_frameOriginalWaterConfigData )
		          goto LABEL_12;
		        System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::get_Item(
		          (RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry *)&v10,
		          (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)m_frameOriginalWaterConfigData,
		          size,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterConfig::MaterialData>::get_Item);
		        originalData = v10;
		        HG::Rendering::Runtime::HGWaterConfigOverrideController::RestoreAdjustment(
		          waterGPUData,
		          &adjustment,
		          &originalData,
		          0LL);
		      }
		      v6 = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this->fields.m_frameAppliedWaterConfigAdjustments;
		      if ( v6 )
		      {
		        System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::Clear(
		          v6,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterConfigOverrideController::WaterConfigAdjustment>::Clear);
		        v6 = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)this->fields.m_frameOriginalWaterConfigData;
		        if ( v6 )
		        {
		          ++v6->fields._version;
		          v6->fields._size = 0;
		          return;
		        }
		      }
		    }
		LABEL_12:
		    sub_1800D8260(v6, m_frameOriginalWaterConfigData);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1040, 0LL);
		  if ( !Patch )
		    goto LABEL_12;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_399(Patch, (Object *)this, waterGPUData, 0LL);
		}
		
		private void ApplyAdjustmentForFrame(ref NativeArray<Vector4> waterGPUData, ref WaterConfigAdjustment adjustment) {} // 0x0000000189C62350-0x0000000189C62430
		// Void ApplyAdjustmentForFrame(NativeArray`1[UnityEngine.Vector4] ByRef, HGWaterConfigOverrideController+WaterConfigAdjustment ByRef)
		void HG::Rendering::Runtime::HGWaterConfigOverrideController::ApplyAdjustmentForFrame(
		        HGWaterConfigOverrideController *this,
		        NativeArray_1_UnityEngine_Vector4_ *waterGPUData,
		        HGWaterConfigOverrideController_WaterConfigAdjustment *adjustment,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  List_1_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ *m_frameAppliedWaterConfigAdjustments; // rcx
		  __int64 v9; // xmm1_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGWaterConfig_MaterialData originalData; // [rsp+30h] [rbp-38h] BYREF
		  __int128 v12; // [rsp+40h] [rbp-28h] BYREF
		  __int64 v13; // [rsp+50h] [rbp-18h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1031, 0LL) )
		  {
		    originalData = 0LL;
		    if ( !HG::Rendering::Runtime::HGWaterConfigOverrideController::TryApplyAdjustment(
		            waterGPUData,
		            adjustment,
		            &originalData,
		            0LL) )
		      return;
		    m_frameAppliedWaterConfigAdjustments = (List_1_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ *)this->fields.m_frameAppliedWaterConfigAdjustments;
		    if ( m_frameAppliedWaterConfigAdjustments )
		    {
		      v9 = *(_QWORD *)&adjustment->lerpFactor;
		      v12 = *(_OWORD *)&adjustment->active;
		      v13 = v9;
		      sub_180490768(
		        m_frameAppliedWaterConfigAdjustments,
		        &v12,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterConfigOverrideController::WaterConfigAdjustment>::Add);
		      m_frameAppliedWaterConfigAdjustments = (List_1_Beyond_Gameplay_Core_SpawnerManager_SpawnDataDetail_ *)this->fields.m_frameOriginalWaterConfigData;
		      if ( m_frameAppliedWaterConfigAdjustments )
		      {
		        System::Collections::Generic::List<Beyond::Gameplay::Core::SpawnerManager::SpawnDataDetail>::Add(
		          m_frameAppliedWaterConfigAdjustments,
		          (SpawnerManager_SpawnDataDetail *)&originalData,
		          MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGWaterConfig::MaterialData>::Add);
		        return;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(m_frameAppliedWaterConfigAdjustments, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1031, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_398(Patch, (Object *)this, waterGPUData, adjustment, 0LL);
		}
		
		private static bool TryApplyAdjustment(ref NativeArray<Vector4> waterGPUData, ref WaterConfigAdjustment adjustment, ref HGWaterConfig.MaterialData originalData) => default; // 0x0000000189C62C70-0x0000000189C62E78
		// Boolean TryApplyAdjustment(NativeArray`1[UnityEngine.Vector4] ByRef, HGWaterConfigOverrideController+WaterConfigAdjustment ByRef, HGWaterConfig+MaterialData ByRef)
		// Hidden C++ exception states: #wind=1
		bool HG::Rendering::Runtime::HGWaterConfigOverrideController::TryApplyAdjustment(
		        NativeArray_1_UnityEngine_Vector4_ *waterGPUData,
		        HGWaterConfigOverrideController_WaterConfigAdjustment *adjustment,
		        HGWaterConfig_MaterialData *originalData,
		        MethodInfo *method)
		{
		  Object_1 *targetConfig; // rbx
		  __int64 v8; // rdx
		  HGWaterConfig *v9; // rcx
		  float lerpFactor; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  Il2CppExceptionWrapper *v15; // [rsp+30h] [rbp-68h] BYREF
		  HGWaterConfig_MaterialData materialData; // [rsp+38h] [rbp-60h] BYREF
		  HGWaterConfig_MaterialData v17; // [rsp+48h] [rbp-50h] BYREF
		  HGWaterConfig_MaterialData v18; // [rsp+58h] [rbp-40h] BYREF
		  Il2CppException *ex; // [rsp+68h] [rbp-30h]
		  _OWORD v20[2]; // [rsp+70h] [rbp-28h] BYREF
		
		  materialData = 0LL;
		  v17 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1032, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1032, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_397(Patch, waterGPUData, adjustment, originalData, 0LL);
		  }
		  else
		  {
		    if ( adjustment->active
		      && HG::Rendering::Runtime::HGWaterConfigOverrideController::IsValidWaterConfigMaterialIndex(
		           adjustment->materialIndex,
		           0LL) )
		    {
		      targetConfig = (Object_1 *)adjustment->targetConfig;
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      if ( !UnityEngine::Object::op_Equality(targetConfig, 0LL, 0LL) )
		      {
		        *originalData = *HG::Rendering::Runtime::HGWaterConfig::MaterialData::New(&v18, 0LL);
		        HG::Rendering::Runtime::HGWaterConfigOverrideController::CopyMaterialDataFromGPU(
		          waterGPUData,
		          adjustment->materialIndex,
		          originalData,
		          0LL);
		        materialData = *HG::Rendering::Runtime::HGWaterConfig::MaterialData::New(&v18, 0LL);
		        v17 = *HG::Rendering::Runtime::HGWaterConfig::MaterialData::New(&v18, 0LL);
		        v18.vector4Array.m_Buffer = (Void *)&materialData;
		        *(_QWORD *)&v18.vector4Array.m_Length = &v17;
		        ex = 0LL;
		        v20[0] = v18;
		        try
		        {
		          v9 = adjustment->targetConfig;
		          if ( !v9 )
		            sub_1800D8250(0LL, v8);
		          HG::Rendering::Runtime::HGWaterConfig::CopyConfig(v9, &materialData, 0LL);
		          lerpFactor = adjustment->lerpFactor;
		          sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGWaterConfig);
		          HG::Rendering::Runtime::HGWaterConfig::LerpConfig(&v17, originalData, &materialData, lerpFactor, 0LL);
		          HG::Rendering::Runtime::HGWaterConfigOverrideController::CopyMaterialDataToGPU(
		            waterGPUData,
		            adjustment->materialIndex,
		            &v17.vector4Array,
		            0LL);
		        }
		        catch ( Il2CppExceptionWrapper *v15 )
		        {
		          ex = v15->ex;
		          sub_182CB9440(v20);
		          if ( ex )
		            sub_18007E1E0(ex);
		          return 1;
		        }
		        sub_182CB9440(v20);
		        return 1;
		      }
		    }
		    return 0;
		  }
		}
		
		private static void RestoreAdjustment(ref NativeArray<Vector4> waterGPUData, ref WaterConfigAdjustment adjustment, ref HGWaterConfig.MaterialData originalData) {} // 0x0000000189C62800-0x0000000189C62890
		// Void RestoreAdjustment(NativeArray`1[UnityEngine.Vector4] ByRef, HGWaterConfigOverrideController+WaterConfigAdjustment ByRef, HGWaterConfig+MaterialData ByRef)
		void HG::Rendering::Runtime::HGWaterConfigOverrideController::RestoreAdjustment(
		        NativeArray_1_UnityEngine_Vector4_ *waterGPUData,
		        HGWaterConfigOverrideController_WaterConfigAdjustment *adjustment,
		        HGWaterConfig_MaterialData *originalData,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1041, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1041, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_400(Patch, waterGPUData, adjustment, originalData, 0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGWaterConfigOverrideController::CopyMaterialDataToGPU(
		      waterGPUData,
		      adjustment->materialIndex,
		      &originalData->vector4Array,
		      0LL);
		    if ( originalData->vector4Array.m_Buffer )
		      Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose(
		        &originalData->vector4Array,
		        MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::Dispose);
		  }
		}
		
		private static void CopyMaterialDataFromGPU(ref NativeArray<Vector4> waterGPUData, int materialIndex, ref HGWaterConfig.MaterialData materialData) {} // 0x0000000189C62650-0x0000000189C62700
		// Void CopyMaterialDataFromGPU(NativeArray`1[UnityEngine.Vector4] ByRef, Int32, HGWaterConfig+MaterialData ByRef)
		void HG::Rendering::Runtime::HGWaterConfigOverrideController::CopyMaterialDataFromGPU(
		        NativeArray_1_UnityEngine_Vector4_ *waterGPUData,
		        int32_t materialIndex,
		        HGWaterConfig_MaterialData *materialData,
		        MethodInfo *method)
		{
		  int32_t v7; // edi
		  __int64 v8; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  v7 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(1035, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1035, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_393(Patch, waterGPUData, materialIndex, materialData, 0LL);
		  }
		  else
		  {
		    v8 = 16 * (20 * materialIndex + 18LL);
		    do
		    {
		      v12 = *(Vector4 *)&waterGPUData->m_Buffer[v8];
		      HG::Rendering::Runtime::HGWaterConfig::MaterialData::SetValue(materialData, v7++, &v12, 0LL);
		      v8 += 16LL;
		    }
		    while ( v7 < 20 );
		  }
		}
		
		private static void CopyMaterialDataToGPU(ref NativeArray<Vector4> waterGPUData, int materialIndex, ref NativeArray<Vector4> materialData) {} // 0x0000000189C62700-0x0000000189C627A8
		// Void CopyMaterialDataToGPU(NativeArray`1[UnityEngine.Vector4] ByRef, Int32, NativeArray`1[UnityEngine.Vector4] ByRef)
		void HG::Rendering::Runtime::HGWaterConfigOverrideController::CopyMaterialDataToGPU(
		        NativeArray_1_UnityEngine_Vector4_ *waterGPUData,
		        int32_t materialIndex,
		        NativeArray_1_UnityEngine_Vector4_ *materialData,
		        MethodInfo *method)
		{
		  __int64 v7; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  v7 = 0LL;
		  if ( IFix::WrappersManagerImpl::IsPatched(1039, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1039, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_396(Patch, waterGPUData, materialIndex, materialData, 0LL);
		  }
		  else
		  {
		    do
		    {
		      *(__m128i *)&waterGPUData->m_Buffer[320 * materialIndex + 288 + v7] = _mm_loadu_si128((const __m128i *)&materialData->m_Buffer[v7]);
		      v7 += 16LL;
		    }
		    while ( v7 < 320 );
		  }
		}
		
		private static bool IsValidWaterConfigMaterialIndex(int materialIndex) => default; // 0x0000000189C627A8-0x0000000189C62800
		// Boolean IsValidWaterConfigMaterialIndex(Int32)
		bool HG::Rendering::Runtime::HGWaterConfigOverrideController::IsValidWaterConfigMaterialIndex(
		        int32_t materialIndex,
		        MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  result = IFix::WrappersManagerImpl::IsPatched(1033, 0LL);
		  if ( result )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1033, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_95(
		             (ILFixDynamicMethodWrapper_17 *)Patch,
		             (AudioLogChannel__Enum)materialIndex,
		             0LL);
		  }
		  else if ( materialIndex >= 0 )
		  {
		    return materialIndex < 64;
		  }
		  return result;
		}
		
	}
}
