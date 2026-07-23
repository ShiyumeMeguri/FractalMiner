using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("Post-processing/MotionBlur", new System.Type[1] {typeof(HGRenderPipeline) })]
	public class HGMotionBlur : VolumeComponent // TypeDefIndex: 38045
	{
		// Fields
		public BoolParameter enable; // 0x30
		public ClampedFloatParameter shutterAngle; // 0x38
		public ClampedFloatParameter blendFrame; // 0x40
		public ClampedIntParameter sampleCount; // 0x48
	
		// Constructors
		public HGMotionBlur() {} // 0x0000000184405910-0x0000000184405A20
		// HGMotionBlur()
		void HG::Rendering::Runtime::HGMotionBlur::HGMotionBlur(HGMotionBlur *this, MethodInfo *method)
		{
		  BoolParameter *v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rax
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  __int64 v11; // rax
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  IntParameter *v14; // rax
		  ClampedIntParameter *v15; // rdi
		  Type *v16; // rdx
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  MethodInfo *v19; // [rsp+20h] [rbp-8h]
		  MethodInfo *v20; // [rsp+20h] [rbp-8h]
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		  MethodInfo *v22; // [rsp+20h] [rbp-8h]
		
		  v3 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v3 )
		    goto LABEL_6;
		  v3->fields._.m_Value = 0;
		  v3->fields._._.overrideState = 0;
		  this->fields.enable = v3;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.enable, v4, v6, v7, v19);
		  v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v8 )
		    goto LABEL_6;
		  *(_DWORD *)(v8 + 24) = 1106247680;
		  *(_BYTE *)(v8 + 16) = 0;
		  *(_DWORD *)(v8 + 32) = 0;
		  *(_DWORD *)(v8 + 36) = 1135869952;
		  *(_DWORD *)(v8 + 40) = 1065353216;
		  this->fields.shutterAngle = (ClampedFloatParameter *)v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.shutterAngle, v4, v9, v10, v20);
		  v11 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v11 )
		    goto LABEL_6;
		  *(_DWORD *)(v11 + 24) = 0;
		  *(_BYTE *)(v11 + 16) = 0;
		  *(_DWORD *)(v11 + 32) = 0;
		  *(_DWORD *)(v11 + 36) = 1065353216;
		  *(_DWORD *)(v11 + 40) = 1065353216;
		  this->fields.blendFrame = (ClampedFloatParameter *)v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.blendFrame, v4, v12, v13, v21);
		  v14 = (IntParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedIntParameter);
		  v15 = (ClampedIntParameter *)v14;
		  if ( !v14 )
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  UnityEngine::Rendering::IntParameter::IntParameter(v14, 8, 0, 0LL);
		  v15->fields.min = 4;
		  v15->fields.max = 12;
		  this->fields.sampleCount = v15;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.sampleCount, v16, v17, v18, v22);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000183C23680-0x0000000183C23790
		// Boolean IsActive()
		bool HG::Rendering::Runtime::HGMotionBlur::IsActive(HGMotionBlur *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ClampedFloatParameter *wrapperArray; // rdx
		  BoolParameter *enable; // rbx
		  bool (*v6)(RuntimeType *, MethodInfo *); // r8
		  Il2CppMethodPointer methodPtr; // rdx
		  bool result; // al
		  VolumeParameter__Fields v9; // rax
		  char v10; // al
		  VolumeParameter__Fields v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  double v13; // xmm0_8
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (ClampedFloatParameter *)v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_23;
		  if ( SLODWORD(wrapperArray->fields._._.m_Value) > 1114 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( !v3 )
		      goto LABEL_23;
		    if ( LODWORD(v3->_0.namespaze) <= 0x45A )
		      sub_1800D2AB0(v3, wrapperArray);
		    if ( *(_QWORD *)&v3[23]._1.interfaces_count )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1114, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                 (ILFixDynamicMethodWrapper_20 *)Patch,
		                 (Object *)this,
		                 0LL);
		      goto LABEL_23;
		    }
		  }
		  enable = this->fields.enable;
		  if ( !enable )
		    goto LABEL_23;
		  sub_1800049A0(enable->klass);
		  v6 = (bool (*)(RuntimeType *, MethodInfo *))enable->klass->vtable.get_value.method;
		  methodPtr = enable->klass->vtable.set_value.methodPtr;
		  if ( v6 == System::RuntimeType::HasElementTypeImpl )
		  {
		    v9 = enable->fields._._;
		    if ( (*(_DWORD *)(*(_QWORD *)&v9 + 8LL) & 0x20000000) != 0 )
		      goto LABEL_22;
		    v10 = *(_BYTE *)(*(_QWORD *)&v9 + 10LL);
		    if ( v10 == 29 || v10 == 16 || v10 == 20 || v10 == 15 )
		      goto LABEL_22;
		LABEL_17:
		    result = 0;
		    goto LABEL_10;
		  }
		  if ( v6 == System::RuntimeType::get_IsGenericType )
		  {
		    result = System::RuntimeTypeHandle::HasInstantiation(enable, methodPtr);
		    goto LABEL_10;
		  }
		  if ( v6 != System::RuntimeType::get_IsGenericParameter )
		  {
		    result = ((__int64 (__fastcall *)(BoolParameter *, Il2CppMethodPointer))v6)(enable, methodPtr);
		    goto LABEL_10;
		  }
		  v11 = enable->fields._._;
		  if ( (*(_DWORD *)(*(_QWORD *)&v11 + 8LL) & 0x20000000) != 0
		    || *(_BYTE *)(*(_QWORD *)&v11 + 10LL) != 19 && *(_BYTE *)(*(_QWORD *)&v11 + 10LL) != 30 )
		  {
		    goto LABEL_17;
		  }
		LABEL_22:
		  result = 1;
		LABEL_10:
		  if ( result )
		  {
		    wrapperArray = this->fields.shutterAngle;
		    if ( wrapperArray )
		    {
		      v13 = sub_1800057D0(10LL, wrapperArray);
		      return *(float *)&v13 > 0.0;
		    }
		LABEL_23:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  return result;
		}
		
	}
}
