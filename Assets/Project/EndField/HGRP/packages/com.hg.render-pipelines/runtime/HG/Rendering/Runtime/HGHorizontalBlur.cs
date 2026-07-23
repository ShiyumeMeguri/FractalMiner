using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("HG/HorizontalBlur", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class HGHorizontalBlur : VolumeComponent // TypeDefIndex: 38044
	{
		// Fields
		public BoolParameter enabled; // 0x30
		public ClampedFloatParameter radius; // 0x38
		public BoolParameter useBlurTarget; // 0x40
		public ClampedFloatParameter blurTargetAngle; // 0x48
		public BoolParameter useBlurCenter; // 0x50
		public Vector2Parameter blurCenter; // 0x58
		public ClampedFloatParameter blurCenterFadeWidth; // 0x60
	
		// Constructors
		public HGHorizontalBlur() {} // 0x00000001845F5690-0x00000001845F5820
		// HGHorizontalBlur()
		void HG::Rendering::Runtime::HGHorizontalBlur::HGHorizontalBlur(HGHorizontalBlur *this, MethodInfo *method)
		{
		  BoolParameter *v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rax
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  BoolParameter *v11; // rax
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  __int64 v14; // rax
		  PropertyInfo_1 *v15; // r8
		  Int32__Array **v16; // r9
		  BoolParameter *v17; // rax
		  PropertyInfo_1 *v18; // r8
		  Int32__Array **v19; // r9
		  __int64 v20; // rax
		  PropertyInfo_1 *v21; // r8
		  Int32__Array **v22; // r9
		  __int64 v23; // rax
		  PropertyInfo_1 *v24; // r8
		  Int32__Array **v25; // r9
		  MethodInfo *v26; // [rsp+20h] [rbp-8h]
		  MethodInfo *v27; // [rsp+20h] [rbp-8h]
		  MethodInfo *v28; // [rsp+20h] [rbp-8h]
		  MethodInfo *v29; // [rsp+20h] [rbp-8h]
		  MethodInfo *v30; // [rsp+20h] [rbp-8h]
		  MethodInfo *v31; // [rsp+20h] [rbp-8h]
		  MethodInfo *v32; // [rsp+20h] [rbp-8h]
		
		  v3 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v3 )
		    goto LABEL_9;
		  v3->fields._.m_Value = 0;
		  v3->fields._._.overrideState = 0;
		  this->fields.enabled = v3;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.enabled, v4, v6, v7, v26);
		  v8 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v8 )
		    goto LABEL_9;
		  *(_DWORD *)(v8 + 36) = 1092616192;
		  *(_DWORD *)(v8 + 24) = 0;
		  *(_BYTE *)(v8 + 16) = 0;
		  *(_DWORD *)(v8 + 32) = 0;
		  *(_DWORD *)(v8 + 40) = 1065353216;
		  this->fields.radius = (ClampedFloatParameter *)v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.radius, v4, v9, v10, v27);
		  v11 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v11 )
		    goto LABEL_9;
		  v11->fields._.m_Value = 0;
		  v11->fields._._.overrideState = 0;
		  this->fields.useBlurTarget = v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.useBlurTarget, v4, v12, v13, v28);
		  v14 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v14 )
		    goto LABEL_9;
		  *(_DWORD *)(v14 + 24) = 0;
		  *(_BYTE *)(v14 + 16) = 0;
		  *(_DWORD *)(v14 + 32) = 0;
		  *(_DWORD *)(v14 + 36) = 1135837184;
		  *(_DWORD *)(v14 + 40) = 1065353216;
		  this->fields.blurTargetAngle = (ClampedFloatParameter *)v14;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.blurTargetAngle, v4, v15, v16, v29);
		  v17 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v17 )
		    goto LABEL_9;
		  v17->fields._.m_Value = 0;
		  v17->fields._._.overrideState = 0;
		  this->fields.useBlurCenter = v17;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.useBlurCenter, v4, v18, v19, v30);
		  v20 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v20
		    || (*(_DWORD *)(v20 + 24) = 1056964608,
		        *(_DWORD *)(v20 + 28) = 1056964608,
		        *(_BYTE *)(v20 + 16) = 0,
		        this->fields.blurCenter = (Vector2Parameter *)v20,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.blurCenter, v4, v21, v22, v31),
		        (v23 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter)) == 0) )
		  {
		LABEL_9:
		    sub_1800D8260(v5, v4);
		  }
		  *(_DWORD *)(v23 + 24) = 0;
		  *(_BYTE *)(v23 + 16) = 0;
		  *(_DWORD *)(v23 + 32) = 0;
		  *(_DWORD *)(v23 + 36) = 1065353216;
		  *(_DWORD *)(v23 + 40) = 1065353216;
		  this->fields.blurCenterFadeWidth = (ClampedFloatParameter *)v23;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.blurCenterFadeWidth, v4, v24, v25, v32);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000183E02130-0x0000000183E02240
		// Boolean IsActive()
		bool HG::Rendering::Runtime::HGHorizontalBlur::IsActive(HGHorizontalBlur *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ClampedFloatParameter *wrapperArray; // rdx
		  BoolParameter *enabled; // rbx
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
		  if ( SLODWORD(wrapperArray->fields._._.m_Value) > 1057 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( !v3 )
		      goto LABEL_23;
		    if ( LODWORD(v3->_0.namespaze) <= 0x421 )
		      sub_1800D2AB0(v3, wrapperArray);
		    if ( *(_QWORD *)&v3[22]._1.initializationExceptionGCHandle )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1057, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                 (ILFixDynamicMethodWrapper_20 *)Patch,
		                 (Object *)this,
		                 0LL);
		      goto LABEL_23;
		    }
		  }
		  enabled = this->fields.enabled;
		  if ( !enabled )
		    goto LABEL_23;
		  sub_1800049A0(enabled->klass);
		  v6 = (bool (*)(RuntimeType *, MethodInfo *))enabled->klass->vtable.get_value.method;
		  methodPtr = enabled->klass->vtable.set_value.methodPtr;
		  if ( v6 == System::RuntimeType::HasElementTypeImpl )
		  {
		    v9 = enabled->fields._._;
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
		    result = System::RuntimeTypeHandle::HasInstantiation(enabled, methodPtr);
		    goto LABEL_10;
		  }
		  if ( v6 != System::RuntimeType::get_IsGenericParameter )
		  {
		    result = ((__int64 (__fastcall *)(BoolParameter *, Il2CppMethodPointer))v6)(enabled, methodPtr);
		    goto LABEL_10;
		  }
		  v11 = enabled->fields._._;
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
		    wrapperArray = this->fields.radius;
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
