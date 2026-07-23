using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[AddComponentMenu("Rendering/TOD Environment Volume")]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	public class HGTimeOfDayEnvironmentVolume : HGEnvironmentVolumeBase // TypeDefIndex: 37655
	{
		// Fields
		[Header("TOD \u73AF\u5883\u914D\u7F6E")]
		[SerializeField]
		private HGTimeOfDayEnvironmentPhase _timeOfDayEnvPhase; // 0x58
		private static HGEnvironmentPhase s_timeOfDayEnvPhase; // 0x00
	
		// Properties
		public HGTimeOfDayEnvironmentPhase timeOfDayEnvPhase { get => default; set {} } // 0x0000000189CEBB58-0x0000000189CEBBA8 0x0000000189CEBBA8-0x0000000189CEBC0C
		// HGTimeOfDayEnvironmentPhase get_timeOfDayEnvPhase()
		HGTimeOfDayEnvironmentPhase *HG::Rendering::Runtime::HGTimeOfDayEnvironmentVolume::get_timeOfDayEnvPhase(
		        HGTimeOfDayEnvironmentVolume *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1527, 0LL) )
		    return this->fields._timeOfDayEnvPhase;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1527, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_624(Patch, (Object *)this, 0LL);
		}
		

		// Void set_timeOfDayEnvPhase(HGTimeOfDayEnvironmentPhase)
		void HG::Rendering::Runtime::HGTimeOfDayEnvironmentVolume::set_timeOfDayEnvPhase(
		        HGTimeOfDayEnvironmentVolume *this,
		        HGTimeOfDayEnvironmentPhase *value,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1528, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1528, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)value,
		      0LL);
		  }
		  else
		  {
		    this->fields._timeOfDayEnvPhase = value;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._timeOfDayEnvPhase, v5, v6, v7, v11);
		  }
		}
		
	
		// Constructors
		public HGTimeOfDayEnvironmentVolume() {} // 0x00000001842EDFC0-0x00000001842EDFD0
		// HGTimeOfDayEnvironmentVolume()
		void HG::Rendering::Runtime::HGTimeOfDayEnvironmentVolume::HGTimeOfDayEnvironmentVolume(
		        HGTimeOfDayEnvironmentVolume *this,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::HGEnvironmentVolumeBase::HGEnvironmentVolumeBase((HGEnvironmentVolumeBase *)this, 0LL);
		}
		
	
		// Methods
		public override bool IsValid() => default; // 0x0000000189CEBACC-0x0000000189CEBB58
		// Boolean IsValid()
		bool HG::Rendering::Runtime::HGTimeOfDayEnvironmentVolume::IsValid(
		        HGTimeOfDayEnvironmentVolume *this,
		        MethodInfo *method)
		{
		  Object_1 *timeOfDayEnvPhase; // rbx
		  bool result; // al
		  __int64 v5; // rdx
		  List_1_HG_Rendering_Runtime_HGEnvironmentPhaseSlice_ *envPhaseSliceList; // rcx
		  HGTimeOfDayEnvironmentPhase *v7; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1529, 0LL) )
		  {
		    timeOfDayEnvPhase = (Object_1 *)this->fields._timeOfDayEnvPhase;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    result = UnityEngine::Object::op_Inequality(timeOfDayEnvPhase, 0LL, 0LL);
		    if ( !result )
		      return result;
		    v7 = this->fields._timeOfDayEnvPhase;
		    if ( v7 )
		    {
		      envPhaseSliceList = v7->fields.envPhaseSliceList;
		      if ( envPhaseSliceList )
		        return envPhaseSliceList->fields._size > 0;
		    }
		LABEL_7:
		    sub_1800D8260(envPhaseSliceList, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1529, 0LL);
		  if ( !Patch )
		    goto LABEL_7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		}
		
		public override HGEnvironmentPhase GetEnvPhaseForInterpolate() => default; // 0x0000000189CEB76C-0x0000000189CEBACC
		// HGEnvironmentPhase GetEnvPhaseForInterpolate()
		HGEnvironmentPhase *HG::Rendering::Runtime::HGTimeOfDayEnvironmentVolume::GetEnvPhaseForInterpolate(
		        HGTimeOfDayEnvironmentVolume *this,
		        MethodInfo *method)
		{
		  Object_1 *s_timeOfDayEnvPhase; // rbx
		  __int64 v4; // rdx
		  HGEnvironmentPhase *v5; // rcx
		  Object *v6; // rax
		  HGRuntimeGrassQuery_Node *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v8; // r8
		  Int32__Array **v9; // r9
		  HGTimeOfDayEnvironmentPhase *timeOfDayEnvPhase; // rbx
		  List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *envPhaseSliceList; // rbx
		  int32_t size; // esi
		  float s_timeOfDay; // xmm6_4
		  __m128i v14; // xmm7
		  float v15; // xmm8_4
		  HGEnvironmentPhase *v16; // rbx
		  float v17; // xmm0_4
		  float v18; // xmm3_4
		  float v19; // xmm3_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v22; // [rsp+20h] [rbp-78h]
		  __m128i v23; // [rsp+30h] [rbp-68h] BYREF
		  RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry v24; // [rsp+40h] [rbp-58h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1530, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1530, 0LL);
		    if ( !Patch )
		      goto LABEL_19;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_210(Patch, (Object *)this, 0LL);
		  }
		  else if ( (unsigned __int8)sub_180006280(9LL, this) )
		  {
		    s_timeOfDayEnvPhase = (Object_1 *)TypeInfo::HG::Rendering::Runtime::HGTimeOfDayEnvironmentVolume->static_fields->s_timeOfDayEnvPhase;
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality(s_timeOfDayEnvPhase, 0LL, 0LL) )
		    {
		      v6 = UnityEngine::ScriptableObject::CreateInstance<System::Object>(MethodInfo::UnityEngine::ScriptableObject::CreateInstance<HG::Rendering::Runtime::HGEnvironmentPhase>);
		      static_fields = (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGTimeOfDayEnvironmentVolume->static_fields;
		      static_fields->klass = (HGRuntimeGrassQuery_Node__Class *)v6;
		      sub_18002D1B0(
		        (HGRuntimeGrassQuery_Node *)TypeInfo::HG::Rendering::Runtime::HGTimeOfDayEnvironmentVolume->static_fields,
		        static_fields,
		        v8,
		        v9,
		        v22);
		    }
		    timeOfDayEnvPhase = this->fields._timeOfDayEnvPhase;
		    if ( !timeOfDayEnvPhase )
		      goto LABEL_19;
		    envPhaseSliceList = (List_1_Beyond_Gameplay_RemoteFactory_RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry_ *)timeOfDayEnvPhase->fields.envPhaseSliceList;
		    if ( !envPhaseSliceList )
		      goto LABEL_19;
		    size = envPhaseSliceList->fields._size;
		    if ( size != 1 )
		    {
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      s_timeOfDay = HG::Rendering::Runtime::HGEnvironmentManager::get_s_timeOfDay(0LL);
		      System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::get_Item(
		        (RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry *)&v23,
		        envPhaseSliceList,
		        0,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentPhaseSlice>::get_Item);
		      v14 = v23;
		      System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::get_Item(
		        (RemoteFactoryUtil_FillBuildingCheckResultIterationContext_CoreZoneEntry *)&v23,
		        envPhaseSliceList,
		        size - 1,
		        MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentPhaseSlice>::get_Item);
		      v15 = *(float *)v23.m128i_i32;
		      v5 = TypeInfo::HG::Rendering::Runtime::HGTimeOfDayEnvironmentVolume->static_fields->s_timeOfDayEnvPhase;
		      if ( v5 )
		      {
		        v16 = (HGEnvironmentPhase *)_mm_srli_si128(v23, 8).m128i_u64[0];
		        HG::Rendering::Runtime::HGEnvironmentPhase::AssignFrom(v5, v16, 0LL);
		        v17 = (float)(24.0 - v15) + *(float *)v14.m128i_i32;
		        if ( v17 <= COERCE_FLOAT(1) )
		          return TypeInfo::HG::Rendering::Runtime::HGTimeOfDayEnvironmentVolume->static_fields->s_timeOfDayEnvPhase;
		        if ( s_timeOfDay >= v15 )
		          v18 = s_timeOfDay - v15;
		        else
		          v18 = (float)(24.0 - v15) + s_timeOfDay;
		        v19 = v18 / v17;
		        v5 = TypeInfo::HG::Rendering::Runtime::HGTimeOfDayEnvironmentVolume->static_fields->s_timeOfDayEnvPhase;
		        if ( v5 )
		        {
		          HG::Rendering::Runtime::HGEnvironmentPhase::Lerp(
		            v5,
		            v16,
		            (HGEnvironmentPhase *)_mm_srli_si128(v14, 8).m128i_i64[0],
		            v19,
		            0LL);
		          return TypeInfo::HG::Rendering::Runtime::HGTimeOfDayEnvironmentVolume->static_fields->s_timeOfDayEnvPhase;
		        }
		      }
		LABEL_19:
		      sub_1800D8260(v5, v4);
		    }
		    System::Collections::Generic::List<Beyond::Gameplay::RemoteFactory::RemoteFactoryUtil_FillBuildingCheckResultIterationContext::CoreZoneEntry>::get_Item(
		      &v24,
		      envPhaseSliceList,
		      0,
		      MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGEnvironmentPhaseSlice>::get_Item);
		    return *(HGEnvironmentPhase **)&v24.freeBusCount;
		  }
		  else
		  {
		    return 0LL;
		  }
		}
		
	}
}
