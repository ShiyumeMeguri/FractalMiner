using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VolumetricSHBake // TypeDefIndex: 38767
	{
		// Fields
		private static int _numThetaSteps; // 0x00
		private static int _numPhiSteps; // 0x04
	
		// Properties
		public static ComputeBuffer SHBuffer { get; private set; } // 0x0000000184DA1E50-0x0000000184DA1E70 0x0000000189C654E0-0x0000000189C6550C
		// ComputeBuffer get_SHBuffer()
		ComputeBuffer *HG::Rendering::Runtime::VolumetricSHBake::get_SHBuffer(MethodInfo *method)
		{
		  return TypeInfo::HG::Rendering::Runtime::VolumetricSHBake->static_fields->_SHBuffer_k__BackingField;
		}
		

		// Void set_SHBuffer(ComputeBuffer)
		void HG::Rendering::Runtime::VolumetricSHBake::set_SHBuffer(ComputeBuffer *value, MethodInfo *method)
		{
		  VolumetricRenderer_VolumetricBounds *v2; // r8
		  Int32__Array **v3; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *static_fields; // rdx
		  MethodInfo *v5; // [rsp+28h] [rbp+28h]
		  bool v6; // [rsp+30h] [rbp+30h]
		  int32_t v7; // [rsp+38h] [rbp+38h]
		  int32_t v8; // [rsp+40h] [rbp+40h]
		  float v9; // [rsp+48h] [rbp+48h]
		  int32_t v10; // [rsp+50h] [rbp+50h]
		  bool v11; // [rsp+58h] [rbp+58h]
		  bool v12; // [rsp+60h] [rbp+60h]
		  MethodInfo *v13; // [rsp+68h] [rbp+68h]
		
		  static_fields = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)TypeInfo::HG::Rendering::Runtime::VolumetricSHBake->static_fields;
		  static_fields->monitor = (MonitorData *)value;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::VolumetricSHBake->static_fields->_SHBuffer_k__BackingField,
		    static_fields,
		    v2,
		    v3,
		    v5,
		    v6,
		    v7,
		    v8,
		    v9,
		    v10,
		    v11,
		    v12,
		    v13);
		}
		
	
		// Nested types
		public struct FSHSampleData // TypeDefIndex: 38766
		{
			// Fields
			public Vector4 Direction; // 0x00
			public Vector4 SHValue; // 0x10
		}
	
		// Constructors
		public VolumetricSHBake() {} // 0x00000001841E1670-0x00000001841E1680
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
		
	
		// Methods
		public static List<Vector4> GenerateSphereSamples(int NumThetaSteps, int NumPhiSteps) => default; // 0x0000000189C65170-0x0000000189C65398
		// List`1[UnityEngine.Vector4] GenerateSphereSamples(Int32, Int32)
		List_1_UnityEngine_Vector4_ *HG::Rendering::Runtime::VolumetricSHBake::GenerateSphereSamples(
		        int32_t NumThetaSteps,
		        int32_t NumPhiSteps,
		        MethodInfo *method)
		{
		  LowLevelList_1_System_Object_ *v5; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  List_1_UnityEngine_InputSystem_Layouts_InputControlLayout_Collection_LayoutMatcher_ *v8; // rdi
		  int32_t i; // r14d
		  int32_t j; // r15d
		  unsigned int v11; // xmm8_4
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  float v14; // xmm7_4
		  float value; // xmm0_4
		  Beyond::DampingMath *v16; // rcx
		  Beyond::DampingMath *v17; // rcx
		  Beyond::DampingMath *v18; // rcx
		  Beyond::DampingMath *v19; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v22; // [rsp+28h] [rbp-49h]
		  __int128 v23; // [rsp+38h] [rbp-39h]
		  _OWORD v24[7]; // [rsp+48h] [rbp-29h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5313, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5313, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1540(Patch, NumThetaSteps, NumPhiSteps, 0LL);
		LABEL_9:
		    sub_1800D8260(v7, v6);
		  }
		  v5 = (LowLevelList_1_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector4>);
		  v8 = (List_1_UnityEngine_InputSystem_Layouts_InputControlLayout_Collection_LayoutMatcher_ *)v5;
		  if ( !v5 )
		    goto LABEL_9;
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v5,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::List);
		  System::Collections::Generic::List<UnityEngine::InputSystem::Layouts::InputControlLayout_Collection::LayoutMatcher>::set_Capacity(
		    v8,
		    NumPhiSteps * NumThetaSteps,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::set_Capacity);
		  for ( i = 0; i < NumThetaSteps; ++i )
		  {
		    for ( j = 0; j < NumPhiSteps; ++j )
		    {
		      *(float *)&v11 = (float)(UnityEngine::Random::get_value(0LL) + (float)i) / (float)NumThetaSteps;
		      v14 = sub_1803386C0(v13, v12);
		      value = UnityEngine::Random::get_value(0LL);
		      Beyond::DampingMath::cosf(v16, (float)j);
		      *(float *)&v22 = (float)((float)((float)(value + (float)j) / (float)NumPhiSteps) * 6.2831855) * v14;
		      Beyond::DampingMath::sinf(v17, (float)j);
		      *((_QWORD *)&v22 + 1) = v11;
		      *((float *)&v22 + 1) = *(float *)&v22;
		      v24[0] = v22;
		      sub_183252A70(v8, v24, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::Add);
		      Beyond::DampingMath::cosf(v18, *(float *)&v22);
		      *(float *)&v23 = *(float *)&v22;
		      Beyond::DampingMath::sinf(v19, *(float *)&v22);
		      *((_QWORD *)&v23 + 1) = COERCE_UNSIGNED_INT(-*(float *)&v11);
		      *((float *)&v23 + 1) = *(float *)&v22;
		      v24[0] = v23;
		      sub_183252A70(v8, v24, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::Add);
		    }
		  }
		  return (List_1_UnityEngine_Vector4_ *)v8;
		}
		
		private static List<Vector4> SetupSphericalSamples(List<Vector4> SampleDirections) => default; // 0x0000000189C65398-0x0000000189C654E0
		// List`1[UnityEngine.Vector4] SetupSphericalSamples(List`1[UnityEngine.Vector4])
		List_1_UnityEngine_Vector4_ *HG::Rendering::Runtime::VolumetricSHBake::SetupSphericalSamples(
		        List_1_UnityEngine_Vector4_ *SampleDirections,
		        MethodInfo *method)
		{
		  int32_t v3; // ebx
		  LowLevelList_1_System_Object_ *v4; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  List_1_UnityEngine_Vector4_ *v7; // rdi
		  __m128 v8; // xmm6
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  float v13; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v16; // [rsp+20h] [rbp-48h]
		  __m128 v17; // [rsp+30h] [rbp-38h] BYREF
		  __int128 v18; // [rsp+40h] [rbp-28h] BYREF
		
		  v3 = 0;
		  if ( IFix::WrappersManagerImpl::IsPatched(5314, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5314, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1541(Patch, (Object *)SampleDirections, 0LL);
		LABEL_8:
		    sub_1800D8260(v6, v5);
		  }
		  v4 = (LowLevelList_1_System_Object_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector4>);
		  v7 = (List_1_UnityEngine_Vector4_ *)v4;
		  if ( !v4 )
		    goto LABEL_8;
		  System::Collections::Generic::LowLevelList<System::Object>::LowLevelList(
		    v4,
		    MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::List);
		  if ( !SampleDirections )
		    goto LABEL_8;
		  while ( v3 < SampleDirections->fields._size )
		  {
		    System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		      (ObjectTranslator_LuaCSFunctionPtr *)&v17,
		      (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)SampleDirections,
		      v3,
		      MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::get_Item);
		    v8 = v17;
		    *(float *)&v16 = sub_1803386C0(v10, v9) * 0.5;
		    v13 = sub_1803386C0(v12, v11) * 0.5;
		    *((float *)&v16 + 1) = v13 * _mm_shuffle_ps(v8, v8, 85).m128_f32[0];
		    *((float *)&v16 + 3) = v13 * v8.m128_f32[0];
		    *((float *)&v16 + 2) = v13 * _mm_shuffle_ps(v8, v8, 170).m128_f32[0];
		    v18 = v16;
		    sub_183252A70(v7, &v18, MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::Add);
		    ++v3;
		  }
		  return v7;
		}
		
		public static ComputeBuffer BuildSHSampleBuffer(int NumThetaSteps, int NumPhiSteps) => default; // 0x0000000189C64F34-0x0000000189C65170
		// ComputeBuffer BuildSHSampleBuffer(Int32, Int32)
		ComputeBuffer *HG::Rendering::Runtime::VolumetricSHBake::BuildSHSampleBuffer(
		        int32_t NumThetaSteps,
		        int32_t NumPhiSteps,
		        MethodInfo *method)
		{
		  struct VolumetricSHBake__Class *v5; // r8
		  VolumetricSHBake__StaticFields *static_fields; // rax
		  List_1_UnityEngine_Vector4_ *SphereSamples; // rbp
		  List_1_UnityEngine_Vector4_ *v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *v11; // rdi
		  int size; // ebx
		  int32_t v13; // esi
		  ComputeBuffer *SHBuffer_k__BackingField; // rcx
		  ComputeBuffer *v15; // rax
		  MonitorData *v16; // rbx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v17; // rdx
		  VolumetricRenderer_VolumetricBounds *v18; // r8
		  Int32__Array **v19; // r9
		  List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *v20; // rax
		  List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *v21; // rsi
		  int32_t i; // ebx
		  ObjectTranslator_LuaCSFunctionPtr v23; // xmm6
		  ComputeBuffer *v24; // rbx
		  Array *v25; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v28; // [rsp+20h] [rbp-68h]
		  bool v29; // [rsp+28h] [rbp-60h]
		  ObjectTranslator_LuaCSFunctionPtr v30; // [rsp+30h] [rbp-58h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v31; // [rsp+40h] [rbp-48h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v32; // [rsp+50h] [rbp-38h] BYREF
		  ObjectTranslator_LuaCSFunctionPtr v33; // [rsp+60h] [rbp-28h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5315, 0LL) )
		  {
		    v5 = TypeInfo::HG::Rendering::Runtime::VolumetricSHBake;
		    static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricSHBake->static_fields;
		    if ( static_fields->_SHBuffer_k__BackingField
		      && NumThetaSteps == static_fields->_numThetaSteps
		      && NumPhiSteps == static_fields->_numPhiSteps )
		    {
		      return v5->static_fields->_SHBuffer_k__BackingField;
		    }
		    static_fields->_numThetaSteps = NumThetaSteps;
		    TypeInfo::HG::Rendering::Runtime::VolumetricSHBake->static_fields->_numPhiSteps = NumPhiSteps;
		    SphereSamples = HG::Rendering::Runtime::VolumetricSHBake::GenerateSphereSamples(NumThetaSteps, NumPhiSteps, 0LL);
		    v8 = HG::Rendering::Runtime::VolumetricSHBake::SetupSphericalSamples(SphereSamples, 0LL);
		    v11 = (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)v8;
		    if ( v8 )
		    {
		      size = v8->fields._size;
		      sub_1800036A0(TypeInfo::System::Math);
		      v13 = 1;
		      if ( size >= 1 )
		        v13 = size;
		      SHBuffer_k__BackingField = TypeInfo::HG::Rendering::Runtime::VolumetricSHBake->static_fields->_SHBuffer_k__BackingField;
		      if ( SHBuffer_k__BackingField )
		        UnityEngine::ComputeBuffer::Dispose(SHBuffer_k__BackingField, 0LL);
		      v15 = (ComputeBuffer *)sub_18002C620(TypeInfo::UnityEngine::ComputeBuffer);
		      v16 = (MonitorData *)v15;
		      if ( v15 )
		      {
		        UnityEngine::ComputeBuffer::ComputeBuffer(v15, v13, 32, ComputeBufferType__Enum_Default, 0LL);
		        v17 = (Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *)TypeInfo::HG::Rendering::Runtime::VolumetricSHBake->static_fields;
		        v17->monitor = v16;
		        sub_18002D1B0(
		          (VolumetricRenderer_VolumetricRenderItem *)&TypeInfo::HG::Rendering::Runtime::VolumetricSHBake->static_fields->_SHBuffer_k__BackingField,
		          v17,
		          v18,
		          v19,
		          v28,
		          v29,
		          (int32_t)v30.ptr,
		          (int32_t)v30.target,
		          *(float *)&v31.ptr,
		          (int32_t)v31.target,
		          (bool)v32.ptr,
		          (bool)v32.target,
		          (MethodInfo *)v33.ptr);
		        v20 = (List_1_Beyond_Gameplay_XiraniteNexusBrain_SplineScanElement_SplineProgressInterval_ *)sub_18002C620(TypeInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSHBake::FSHSampleData>);
		        v21 = (List_1_Beyond_Gameplay_Core_AbilitySystem_ComboController_MappingModifier_Handle_ *)v20;
		        if ( v20 )
		        {
		          System::Collections::Generic::List<Beyond::Gameplay::XiraniteNexusBrain_SplineScanElement::SplineProgressInterval>::List(
		            v20,
		            MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSHBake::FSHSampleData>::List);
		          for ( i = 0; i < v11->fields._size; ++i )
		          {
		            if ( !SphereSamples )
		              goto LABEL_20;
		            System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		              &v30,
		              (List_1_XLua_ObjectTranslator_LuaCSFunctionPtr_ *)SphereSamples,
		              i,
		              MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::get_Item);
		            v23 = v30;
		            System::Collections::Generic::List<XLua::ObjectTranslator::LuaCSFunctionPtr>::get_Item(
		              &v31,
		              v11,
		              i,
		              MethodInfo::System::Collections::Generic::List<UnityEngine::Vector4>::get_Item);
		            v32 = v23;
		            v33 = v31;
		            sub_180461578(
		              v21,
		              &v32,
		              MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSHBake::FSHSampleData>::Add);
		          }
		          v24 = TypeInfo::HG::Rendering::Runtime::VolumetricSHBake->static_fields->_SHBuffer_k__BackingField;
		          v25 = (Array *)System::Collections::Generic::List<Beyond::Gameplay::Core::AbilitySystem_ComboController_MappingModifier::Handle>::ToArray(
		                           v21,
		                           MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::VolumetricSHBake::FSHSampleData>::ToArray);
		          if ( v24 )
		          {
		            UnityEngine::ComputeBuffer::SetData(v24, v25, 0LL);
		            v5 = TypeInfo::HG::Rendering::Runtime::VolumetricSHBake;
		            return v5->static_fields->_SHBuffer_k__BackingField;
		          }
		        }
		      }
		    }
		LABEL_20:
		    sub_1800D8260(v10, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5315, 0LL);
		  if ( !Patch )
		    goto LABEL_20;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1542(Patch, NumThetaSteps, NumPhiSteps, 0LL);
		}
		
	}
}
