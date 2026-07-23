using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	[VolumeComponentMenuForRenderPipeline("HG/BlackBox", new System.Type[1] {typeof(HGRenderPipeline) })]
	public sealed class HGBlackBox : VolumeComponent // TypeDefIndex: 38018
	{
		// Fields
		public BoolParameter enabled; // 0x30
		public BoolParameter useBlackBox; // 0x38
		public Vector4Parameter centerPos; // 0x40
		public ColorParameter blendColor; // 0x48
		public ClampedFloatParameter blendWidth; // 0x50
		public ClampedFloatParameter blendProgress; // 0x58
		public FloatParameter blendRadius; // 0x60
		public ColorParameter contourColor; // 0x68
		public ClampedFloatParameter contourRangeWidth; // 0x70
		public ClampedFloatParameter contourRangeProgress; // 0x78
		public FloatParameter contourRangeRadius; // 0x80
		public Texture2DParameter contourTexture; // 0x88
		public Vector2Parameter contourTexTiling; // 0x90
		public Vector2Parameter contourTexUVSpeed; // 0x98
		public Vector2Parameter disturbTexTiling; // 0xA0
		public Vector2Parameter disturbTexUVSpeed; // 0xA8
		public Vector2Parameter disturbIntensity; // 0xB0
		public Vector2Parameter maskTexTiling; // 0xB8
		public Vector2Parameter maskTexUVSpeed; // 0xC0
		public BoolParameter useDisturb; // 0xC8
		public BoolParameter useMask; // 0xD0
		public BoolParameter useMaskAsAlpha; // 0xD8
	
		// Constructors
		public HGBlackBox() {} // 0x000000018402E7C0-0x000000018402EC80
		// HGBlackBox()
		void HG::Rendering::Runtime::HGBlackBox::HGBlackBox(HGBlackBox *this, MethodInfo *method)
		{
		  BoolParameter *v3; // rax
		  Type *v4; // rdx
		  __int64 v5; // rcx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  BoolParameter *v8; // rax
		  PropertyInfo_1 *v9; // r8
		  Int32__Array **v10; // r9
		  __int64 v11; // rax
		  PropertyInfo_1 *v12; // r8
		  Int32__Array **v13; // r9
		  MethodInfo *v14; // rdx
		  Quaternion v15; // xmm6
		  __int64 v16; // rax
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  __int64 v19; // rax
		  PropertyInfo_1 *v20; // r8
		  Int32__Array **v21; // r9
		  __int64 v22; // rax
		  PropertyInfo_1 *v23; // r8
		  Int32__Array **v24; // r9
		  __int64 v25; // rax
		  PropertyInfo_1 *v26; // r8
		  Int32__Array **v27; // r9
		  MethodInfo *v28; // rdx
		  Quaternion v29; // xmm6
		  __int64 v30; // rax
		  PropertyInfo_1 *v31; // r8
		  Int32__Array **v32; // r9
		  __int64 v33; // rax
		  PropertyInfo_1 *v34; // r8
		  Int32__Array **v35; // r9
		  __int64 v36; // rax
		  PropertyInfo_1 *v37; // r8
		  Int32__Array **v38; // r9
		  __int64 v39; // rax
		  PropertyInfo_1 *v40; // r8
		  Int32__Array **v41; // r9
		  Texture2DParameter *v42; // rax
		  Texture2DParameter *v43; // rdi
		  Type *v44; // rdx
		  PropertyInfo_1 *v45; // r8
		  Int32__Array **v46; // r9
		  __int64 v47; // rax
		  PropertyInfo_1 *v48; // r8
		  Int32__Array **v49; // r9
		  __int64 v50; // rax
		  PropertyInfo_1 *v51; // r8
		  Int32__Array **v52; // r9
		  __int64 v53; // rax
		  PropertyInfo_1 *v54; // r8
		  Int32__Array **v55; // r9
		  __int64 v56; // rax
		  PropertyInfo_1 *v57; // r8
		  Int32__Array **v58; // r9
		  __int64 v59; // rax
		  PropertyInfo_1 *v60; // r8
		  Int32__Array **v61; // r9
		  __int64 v62; // rax
		  PropertyInfo_1 *v63; // r8
		  Int32__Array **v64; // r9
		  __int64 v65; // rax
		  PropertyInfo_1 *v66; // r8
		  Int32__Array **v67; // r9
		  BoolParameter *v68; // rax
		  PropertyInfo_1 *v69; // r8
		  Int32__Array **v70; // r9
		  BoolParameter *v71; // rax
		  PropertyInfo_1 *v72; // r8
		  Int32__Array **v73; // r9
		  BoolParameter *v74; // rax
		  PropertyInfo_1 *v75; // r8
		  Int32__Array **v76; // r9
		  Quaternion v77; // [rsp+20h] [rbp-28h] BYREF
		
		  v3 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v3 )
		    goto LABEL_24;
		  v3->fields._.m_Value = 0;
		  v3->fields._._.overrideState = 0;
		  this->fields.enabled = v3;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.enabled, v4, v6, v7, *(MethodInfo **)&v77.x);
		  v8 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v8 )
		    goto LABEL_24;
		  v8->fields._.m_Value = 0;
		  v8->fields._._.overrideState = 0;
		  this->fields.useBlackBox = v8;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.useBlackBox, v4, v9, v10, *(MethodInfo **)&v77.x);
		  v11 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector4Parameter);
		  if ( !v11 )
		    goto LABEL_24;
		  *(_BYTE *)(v11 + 16) = 0;
		  *(_OWORD *)(v11 + 24) = 0LL;
		  this->fields.centerPos = (Vector4Parameter *)v11;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.centerPos, v4, v12, v13, *(MethodInfo **)&v77.x);
		  v15 = *UnityEngine::Quaternion::get_identity(&v77, v14);
		  v16 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v16 )
		    goto LABEL_24;
		  *(Quaternion *)(v16 + 24) = v15;
		  *(_WORD *)(v16 + 40) = 0;
		  *(_BYTE *)(v16 + 42) = 1;
		  *(_BYTE *)(v16 + 16) = 0;
		  this->fields.blendColor = (ColorParameter *)v16;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.blendColor, v4, v17, v18, *(MethodInfo **)&v77.x);
		  v19 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v19 )
		    goto LABEL_24;
		  *(_DWORD *)(v19 + 24) = 1101004800;
		  *(_BYTE *)(v19 + 16) = 0;
		  *(_DWORD *)(v19 + 32) = 0;
		  *(_DWORD *)(v19 + 36) = 1120403456;
		  *(_DWORD *)(v19 + 40) = 1065353216;
		  this->fields.blendWidth = (ClampedFloatParameter *)v19;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.blendWidth, v4, v20, v21, *(MethodInfo **)&v77.x);
		  v22 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v22 )
		    goto LABEL_24;
		  *(_DWORD *)(v22 + 24) = 0;
		  *(_BYTE *)(v22 + 16) = 0;
		  *(_DWORD *)(v22 + 32) = 0;
		  *(_DWORD *)(v22 + 36) = 1065353216;
		  *(_DWORD *)(v22 + 40) = 1065353216;
		  this->fields.blendProgress = (ClampedFloatParameter *)v22;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.blendProgress, v4, v23, v24, *(MethodInfo **)&v77.x);
		  v25 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::FloatParameter);
		  if ( !v25 )
		    goto LABEL_24;
		  *(_DWORD *)(v25 + 24) = 1140457472;
		  *(_BYTE *)(v25 + 16) = 0;
		  this->fields.blendRadius = (FloatParameter *)v25;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.blendRadius, v4, v26, v27, *(MethodInfo **)&v77.x);
		  v29 = *UnityEngine::Quaternion::get_identity(&v77, v28);
		  v30 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ColorParameter);
		  if ( !v30 )
		    goto LABEL_24;
		  *(Quaternion *)(v30 + 24) = v29;
		  *(_WORD *)(v30 + 40) = 0;
		  *(_BYTE *)(v30 + 42) = 1;
		  *(_BYTE *)(v30 + 16) = 0;
		  this->fields.contourColor = (ColorParameter *)v30;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.contourColor, v4, v31, v32, *(MethodInfo **)&v77.x);
		  v33 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v33 )
		    goto LABEL_24;
		  *(_DWORD *)(v33 + 24) = 1101004800;
		  *(_BYTE *)(v33 + 16) = 0;
		  *(_DWORD *)(v33 + 32) = 0;
		  *(_DWORD *)(v33 + 36) = 1120403456;
		  *(_DWORD *)(v33 + 40) = 1065353216;
		  this->fields.contourRangeWidth = (ClampedFloatParameter *)v33;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.contourRangeWidth, v4, v34, v35, *(MethodInfo **)&v77.x);
		  v36 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::ClampedFloatParameter);
		  if ( !v36 )
		    goto LABEL_24;
		  *(_DWORD *)(v36 + 24) = 0;
		  *(_BYTE *)(v36 + 16) = 0;
		  *(_DWORD *)(v36 + 32) = 0;
		  *(_DWORD *)(v36 + 36) = 1065353216;
		  *(_DWORD *)(v36 + 40) = 1065353216;
		  this->fields.contourRangeProgress = (ClampedFloatParameter *)v36;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.contourRangeProgress, v4, v37, v38, *(MethodInfo **)&v77.x);
		  v39 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::FloatParameter);
		  if ( !v39 )
		    goto LABEL_24;
		  *(_DWORD *)(v39 + 24) = 1140457472;
		  *(_BYTE *)(v39 + 16) = 0;
		  this->fields.contourRangeRadius = (FloatParameter *)v39;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.contourRangeRadius, v4, v40, v41, *(MethodInfo **)&v77.x);
		  v42 = (Texture2DParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::Texture2DParameter);
		  v43 = v42;
		  if ( !v42 )
		    goto LABEL_24;
		  UnityEngine::Rendering::Texture2DParameter::Texture2DParameter(v42, 0LL, 0, 0LL);
		  this->fields.contourTexture = v43;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.contourTexture, v44, v45, v46, *(MethodInfo **)&v77.x);
		  v47 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v47 )
		    goto LABEL_24;
		  *(_DWORD *)(v47 + 24) = 1101004800;
		  *(_DWORD *)(v47 + 28) = 1101004800;
		  *(_BYTE *)(v47 + 16) = 0;
		  this->fields.contourTexTiling = (Vector2Parameter *)v47;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.contourTexTiling, v4, v48, v49, *(MethodInfo **)&v77.x);
		  v50 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v50 )
		    goto LABEL_24;
		  *(_QWORD *)(v50 + 24) = 0LL;
		  *(_BYTE *)(v50 + 16) = 0;
		  this->fields.contourTexUVSpeed = (Vector2Parameter *)v50;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.contourTexUVSpeed, v4, v51, v52, *(MethodInfo **)&v77.x);
		  v53 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v53 )
		    goto LABEL_24;
		  *(_DWORD *)(v53 + 24) = 1101004800;
		  *(_DWORD *)(v53 + 28) = 1101004800;
		  *(_BYTE *)(v53 + 16) = 0;
		  this->fields.disturbTexTiling = (Vector2Parameter *)v53;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.disturbTexTiling, v4, v54, v55, *(MethodInfo **)&v77.x);
		  v56 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v56 )
		    goto LABEL_24;
		  *(_QWORD *)(v56 + 24) = 0LL;
		  *(_BYTE *)(v56 + 16) = 0;
		  this->fields.disturbTexUVSpeed = (Vector2Parameter *)v56;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.disturbTexUVSpeed, v4, v57, v58, *(MethodInfo **)&v77.x);
		  v59 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v59 )
		    goto LABEL_24;
		  *(_QWORD *)(v59 + 24) = 0LL;
		  *(_BYTE *)(v59 + 16) = 0;
		  this->fields.disturbIntensity = (Vector2Parameter *)v59;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.disturbIntensity, v4, v60, v61, *(MethodInfo **)&v77.x);
		  v62 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v62 )
		    goto LABEL_24;
		  *(_DWORD *)(v62 + 24) = 1101004800;
		  *(_DWORD *)(v62 + 28) = 1101004800;
		  *(_BYTE *)(v62 + 16) = 0;
		  this->fields.maskTexTiling = (Vector2Parameter *)v62;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.maskTexTiling, v4, v63, v64, *(MethodInfo **)&v77.x);
		  v65 = sub_1800368D0(TypeInfo::UnityEngine::Rendering::Vector2Parameter);
		  if ( !v65 )
		    goto LABEL_24;
		  *(_QWORD *)(v65 + 24) = 0LL;
		  *(_BYTE *)(v65 + 16) = 0;
		  this->fields.maskTexUVSpeed = (Vector2Parameter *)v65;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.maskTexUVSpeed, v4, v66, v67, *(MethodInfo **)&v77.x);
		  v68 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v68 )
		    goto LABEL_24;
		  v68->fields._.m_Value = 1;
		  v68->fields._._.overrideState = 0;
		  this->fields.useDisturb = v68;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.useDisturb, v4, v69, v70, *(MethodInfo **)&v77.x);
		  v71 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter);
		  if ( !v71
		    || (v71->fields._.m_Value = 1,
		        v71->fields._._.overrideState = 0,
		        this->fields.useMask = v71,
		        sub_18002D1B0((SingleFieldAccessor *)&this->fields.useMask, v4, v72, v73, *(MethodInfo **)&v77.x),
		        (v74 = (BoolParameter *)sub_1800368D0(TypeInfo::UnityEngine::Rendering::BoolParameter)) == 0LL) )
		  {
		LABEL_24:
		    sub_1800D8260(v5, v4);
		  }
		  v74->fields._.m_Value = 1;
		  v74->fields._._.overrideState = 0;
		  this->fields.useMaskAsAlpha = v74;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.useMaskAsAlpha, v4, v75, v76, *(MethodInfo **)&v77.x);
		  UnityEngine::Rendering::VolumeComponent::VolumeComponent((VolumeComponent *)this, 0LL);
		}
		
	
		// Methods
		public bool IsActive() => default; // 0x0000000183A161B0-0x0000000183A162C0
		// Boolean IsActive()
		bool HG::Rendering::Runtime::HGBlackBox::IsActive(HGBlackBox *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  BoolParameter *wrapperArray; // rdx
		  BoolParameter *enabled; // rbx
		  bool (*v6)(RuntimeType *, MethodInfo *); // r8
		  Il2CppMethodPointer methodPtr; // rdx
		  bool result; // al
		  VolumeParameter__Fields v9; // rax
		  char v10; // al
		  VolumeParameter__Fields v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (BoolParameter *)v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_23;
		  if ( *(int *)&wrapperArray->fields._.m_Value > 2563 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( !v3 )
		      goto LABEL_23;
		    if ( LODWORD(v3->_0.namespaze) <= 0xA03 )
		      sub_1800D2AB0(v3, wrapperArray);
		    if ( v3[54]._1.cctor_thread )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(2563, 0LL);
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
		    wrapperArray = this->fields.useBlackBox;
		    if ( wrapperArray )
		      return sub_180006280(10LL, wrapperArray);
		LABEL_23:
		    sub_1800D8260(v3, wrapperArray);
		  }
		  return result;
		}
		
	}
}
