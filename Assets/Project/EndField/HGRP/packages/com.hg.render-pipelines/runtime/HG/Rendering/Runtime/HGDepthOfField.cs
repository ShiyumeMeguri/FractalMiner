using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[RequireComponent(typeof(Camera))]
	public class HGDepthOfField : MonoBehaviour // TypeDefIndex: 38041
	{
		// Fields
		public bool enable; // 0x18
		public static readonly UnityEngine.Color defaultNearStartColor; // 0x00
		public static readonly UnityEngine.Color defaultNearEndColor; // 0x10
		public static readonly UnityEngine.Color defaultFarStartColor; // 0x20
		public static readonly UnityEngine.Color defaultFarEndColor; // 0x30
		public HGDepthOfFieldFocusMode focusMode; // 0x1C
		public HGDepthOfFieldScale scale; // 0x20
		public HGDepthOfFieldType type; // 0x24
		[Min(0f)]
		public float nearFocusStart; // 0x28
		[Min(0f)]
		public float nearFocusEnd; // 0x2C
		[Min(0f)]
		public float nearRadius; // 0x30
		[Min(0f)]
		public float farFocusStart; // 0x34
		[Min(0f)]
		public float farFocusEnd; // 0x38
		[Min(0f)]
		public float farRadius; // 0x3C
		[Min(0f)]
		public float focusRange; // 0x40
		[Min(0.1f)]
		public float temporalFactor; // 0x44
		public bool hgDebugCommand; // 0x48
		private bool m_manualEnable; // 0x49
		private const float kMaxNearBlurRadius = 10f; // Metadata: 0x0230385A
		private const float kMaxFarBlurRadius = 10f; // Metadata: 0x0230385E
		private const float kMinGradientDistance = 0.1f; // Metadata: 0x02303862
	
		// Properties
		public bool manualEnable { get => default; set {} } // 0x0000000183E5E5A0-0x0000000183E5E600 0x0000000189B6B124-0x0000000189B6B17C
		// Boolean get_manualEnable()
		bool HG::Rendering::Runtime::HGDepthOfField::get_manualEnable(HGDepthOfField *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
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
		  if ( wrapperArray->max_length.size > 1108 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x454 )
		        sub_1800D2AB0(v3, wrapperArray);
		      if ( !*(_QWORD *)&v3[23]._1.instance_size )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1108, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                 (ILFixDynamicMethodWrapper_20 *)Patch,
		                 (Object *)this,
		                 0LL);
		    }
		LABEL_7:
		    sub_1800D8260(v3, wrapperArray);
		  }
		LABEL_5:
		  if ( this->fields.hgDebugCommand )
		    return this->fields.m_manualEnable;
		  else
		    return this->fields.enable;
		}
		

		// Void set_manualEnable(Boolean)
		void HG::Rendering::Runtime::HGDepthOfField::set_manualEnable(HGDepthOfField *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2682, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2682, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields.m_manualEnable = value;
		  }
		}
		
	
		// Constructors
		public HGDepthOfField() {} // 0x0000000184D7FC80-0x0000000184D7FCC0
		// HGDepthOfField()
		void HG::Rendering::Runtime::HGDepthOfField::HGDepthOfField(HGDepthOfField *this, MethodInfo *method)
		{
		  this->fields.focusMode = 1;
		  this->fields.scale = 1;
		  this->fields.nearRadius = 1.0;
		  this->fields.farRadius = 1.0;
		  this->fields.temporalFactor = 0.5;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		}
		
		static HGDepthOfField() {} // 0x0000000184D4F9E0-0x0000000184D4FA50
		// HGDepthOfField()
		void HG::Rendering::Runtime::HGDepthOfField::cctor(MethodInfo *method)
		{
		  Color si128; // xmm1
		  Color v2; // xmm0
		  Color v3; // xmm1
		
		  si128 = (Color)_mm_load_si128((const __m128i *)&xmmword_18DA45AD0);
		  TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultNearStartColor = (Color)_mm_load_si128((const __m128i *)&xmmword_18DA45AC0);
		  v2 = (Color)_mm_load_si128((const __m128i *)&xmmword_18DA45B10);
		  TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultNearEndColor = si128;
		  v3 = (Color)_mm_load_si128((const __m128i *)&xmmword_18DA45B30);
		  TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultFarStartColor = v2;
		  TypeInfo::HG::Rendering::Runtime::HGDepthOfField->static_fields->defaultFarEndColor = v3;
		}
		
	
		// Methods
		public HGDepthOfFieldData GetSerializeData() => default; // 0x0000000189B6AD0C-0x0000000189B6AE4C
		// HGDepthOfFieldData GetSerializeData()
		HGDepthOfFieldData *HG::Rendering::Runtime::HGDepthOfField::GetSerializeData(HGDepthOfField *this, MethodInfo *method)
		{
		  unsigned int focusMode; // edi
		  unsigned int type; // esi
		  unsigned int scale; // ebp
		  float nearFocusStart; // xmm6_4
		  float nearFocusEnd; // xmm7_4
		  float nearRadius; // xmm8_4
		  float farFocusStart; // xmm9_4
		  float farFocusEnd; // xmm10_4
		  float farRadius; // xmm11_4
		  float temporalFactor; // xmm12_4
		  HGDepthOfFieldData *v13; // rax
		  __int64 v14; // rdx
		  __int64 v15; // rcx
		  HGDepthOfFieldData *v16; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2683, 0LL) )
		  {
		    focusMode = this->fields.focusMode;
		    type = this->fields.type;
		    scale = this->fields.scale;
		    nearFocusStart = this->fields.nearFocusStart;
		    nearFocusEnd = this->fields.nearFocusEnd;
		    nearRadius = this->fields.nearRadius;
		    farFocusStart = this->fields.farFocusStart;
		    farFocusEnd = this->fields.farFocusEnd;
		    farRadius = this->fields.farRadius;
		    temporalFactor = this->fields.temporalFactor;
		    v13 = (HGDepthOfFieldData *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::HGDepthOfFieldData);
		    v16 = v13;
		    if ( v13 )
		    {
		      HG::Rendering::Runtime::HGDepthOfFieldData::HGDepthOfFieldData(
		        v13,
		        (HGDepthOfFieldFocusMode__Enum)focusMode,
		        (HGDepthOfFieldType__Enum)type,
		        (HGDepthOfFieldScale__Enum)scale,
		        nearFocusStart,
		        nearFocusEnd,
		        nearRadius,
		        farFocusStart,
		        farFocusEnd,
		        farRadius,
		        temporalFactor,
		        0LL);
		      return v16;
		    }
		LABEL_5:
		    sub_1800D8260(v15, v14);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2683, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_987(Patch, (Object *)this, 0LL);
		}
		
		public void SetSerializeData(HGDepthOfFieldData data) {} // 0x0000000189B6B034-0x0000000189B6B0C0
		// Void SetSerializeData(HGDepthOfFieldData)
		void HG::Rendering::Runtime::HGDepthOfField::SetSerializeData(
		        HGDepthOfField *this,
		        HGDepthOfFieldData *data,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2684, 0LL) )
		  {
		    if ( data )
		    {
		      this->fields.type = data->fields.type;
		      this->fields.nearFocusStart = data->fields.nearFocusStart;
		      this->fields.nearFocusEnd = data->fields.nearFocusEnd;
		      this->fields.nearRadius = data->fields.nearRadius;
		      this->fields.farFocusStart = data->fields.farFocusStart;
		      this->fields.farFocusEnd = data->fields.farFocusEnd;
		      this->fields.farRadius = data->fields.farRadius;
		      this->fields.temporalFactor = data->fields.temporalFactor;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2684, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)data,
		    0LL);
		}
		
		public HGDepthOfFieldData GetDefaultFieldData() => default; // 0x0000000189B6AC80-0x0000000189B6AD0C
		// HGDepthOfFieldData GetDefaultFieldData()
		HGDepthOfFieldData *HG::Rendering::Runtime::HGDepthOfField::GetDefaultFieldData(
		        HGDepthOfField *this,
		        MethodInfo *method)
		{
		  HGDepthOfFieldData *result; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2685, 0LL) )
		  {
		    result = (HGDepthOfFieldData *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGDepthOfFieldData);
		    if ( result )
		    {
		      result->fields.type = 0;
		      result->fields.nearFocusStart = 0.0;
		      result->fields.nearFocusEnd = 0.0;
		      result->fields.farFocusStart = 0.0;
		      result->fields.farFocusEnd = 0.0;
		      result->fields.mode = 1;
		      result->fields.scale = 1;
		      result->fields.nearRadius = 1.0;
		      result->fields.farRadius = 1.0;
		      result->fields.temporalFactor = 0.5;
		      return result;
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2685, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_987(Patch, (Object *)this, 0LL);
		}
		
		public void ToReset() {} // 0x0000000189B6B0C0-0x0000000189B6B124
		// Void ToReset()
		void HG::Rendering::Runtime::HGDepthOfField::ToReset(HGDepthOfField *this, MethodInfo *method)
		{
		  HGDepthOfFieldData *DefaultFieldData; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2686, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2686, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    this->fields.enable = 0;
		    DefaultFieldData = HG::Rendering::Runtime::HGDepthOfField::GetDefaultFieldData(this, 0LL);
		    HG::Rendering::Runtime::HGDepthOfField::SetSerializeData(this, DefaultFieldData, 0LL);
		  }
		}
		
		public void SetByDistance(float focusDistance, float nearBlurAmount, float farBlurAmount, float focusBandRatio = 0.15f /* Metadata: 0x02303852 */) {} // 0x0000000189B6AF3C-0x0000000189B6B034
		// Void SetByDistance(Single, Single, Single, Single)
		void HG::Rendering::Runtime::HGDepthOfField::SetByDistance(
		        HGDepthOfField *this,
		        float focusDistance,
		        float nearBlurAmount,
		        float farBlurAmount,
		        float focusBandRatio,
		        MethodInfo *method)
		{
		  HGDepthOfFieldData *v7; // rax
		  __int64 v8; // rcx
		  HGDepthOfFieldData *v9; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2687, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGDepthOfField);
		    v7 = HG::Rendering::Runtime::HGDepthOfField::CalcDataByDistance(
		           focusDistance,
		           nearBlurAmount,
		           farBlurAmount,
		           focusBandRatio,
		           0LL);
		    v9 = v7;
		    if ( v7 )
		    {
		      this->fields.focusMode = v7->fields.mode;
		      this->fields.type = v7->fields.type;
		      this->fields.scale = v7->fields.scale;
		      this->fields.nearFocusStart = v7->fields.nearFocusStart;
		      this->fields.nearFocusEnd = v7->fields.nearFocusEnd;
		      this->fields.nearRadius = v7->fields.nearRadius;
		      this->fields.farFocusStart = v7->fields.farFocusStart;
		      this->fields.farFocusEnd = v7->fields.farFocusEnd;
		      this->fields.farRadius = v7->fields.farRadius;
		      return;
		    }
		LABEL_5:
		    sub_1800D8260(v8, v9);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2687, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_13(
		    (ILFixDynamicMethodWrapper_10 *)Patch,
		    (Object *)this,
		    focusDistance,
		    nearBlurAmount,
		    farBlurAmount,
		    focusBandRatio,
		    0LL);
		}
		
		public static HGDepthOfFieldData CalcDataByDistance(float focusDistance, float nearBlurAmount, float farBlurAmount, float focusBandRatio = 0.15f /* Metadata: 0x02303856 */) => default; // 0x0000000189B6AAB8-0x0000000189B6AC80
		// HGDepthOfFieldData CalcDataByDistance(Single, Single, Single, Single)
		HGDepthOfFieldData *HG::Rendering::Runtime::HGDepthOfField::CalcDataByDistance(
		        float focusDistance,
		        float nearBlurAmount,
		        float farBlurAmount,
		        float focusBandRatio,
		        MethodInfo *method)
		{
		  Beyond::JobMathf *v5; // rcx
		  float v6; // xmm6_4
		  float v7; // xmm8_4
		  float v8; // xmm9_4
		  float v9; // xmm7_4
		  float v10; // xmm11_4
		  _DWORD *v11; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		  Beyond::JobMathf *v14; // rcx
		  float *v15; // rax
		  float v16; // xmm5_4
		  float v17; // xmm10_4
		  Beyond::JobMathf *v18; // rcx
		  Beyond::JobMathf *v19; // rcx
		  HGDepthOfFieldData *result; // rax
		  float v21; // xmm5_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2688, 0LL) )
		  {
		    v6 = fmaxf(focusDistance, 0.1);
		    v7 = fmaxf(nearBlurAmount, 0.0);
		    v8 = fmaxf(farBlurAmount, 0.0);
		    Beyond::JobMathf::Clamp01(v5, nearBlurAmount);
		    v9 = (float)(focusBandRatio * v6) + v6;
		    v10 = fmaxf(0.0, v6 - (float)(focusBandRatio * v6));
		    v11 = (_DWORD *)sub_18002C620(TypeInfo::HG::Rendering::Runtime::HGDepthOfFieldData);
		    if ( v11 )
		    {
		      v11[5] = 0;
		      v11[13] = 1056964608;
		      v11[4] = 1;
		      v11[6] = 1;
		      Beyond::JobMathf::Clamp01((Beyond::JobMathf *)1, v7 - 10.0);
		      v15 = (float *)Beyond::JobMathf::ClampedLerp(v14, v10, fmaxf(0.0, v7 - 10.0) / 10.0, focusBandRatio);
		      v15[8] = v10;
		      v15[10] = v9;
		      v15[9] = fminf(v7, v16);
		      v15[7] = fmaxf(fminf(0.0, v10 - 0.1), 0.0);
		      v17 = fmaxf(0.0, v8 - v16) / v16;
		      Beyond::JobMathf::Clamp01(v18, v8 - v16);
		      result = (HGDepthOfFieldData *)Beyond::JobMathf::ClampedLerp(v19, v9, v17, focusBandRatio);
		      result->fields.farRadius = fminf(v8, v21);
		      result->fields.farFocusEnd = fmaxf(fmaxf(v6 * 0.5, 5.0) + v9, v9 + 0.1);
		      return result;
		    }
		LABEL_5:
		    sub_1800D8260(v13, v12);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2688, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_988(
		           Patch,
		           focusDistance,
		           nearBlurAmount,
		           farBlurAmount,
		           focusBandRatio,
		           0LL);
		}
		
		public bool IsActive() => default; // 0x0000000183E5E4F0-0x0000000183E5E5A0
		// Boolean IsActive()
		bool HG::Rendering::Runtime::HGDepthOfField::IsActive(HGDepthOfField *this, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rdx
		  ILFixDynamicMethodWrapper_2__StaticFields *wrapperArray; // rcx
		  bool m_manualEnable; // al
		  ILFixDynamicMethodWrapper_2__Array *v8; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  ILFixDynamicMethodWrapper_2__Array *v10; // rax
		  ILFixDynamicMethodWrapper_2 *v11; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = v2->static_fields;
		  wrapperArray = (ILFixDynamicMethodWrapper_2__StaticFields *)static_fields->wrapperArray;
		  if ( !static_fields->wrapperArray )
		    goto LABEL_13;
		  if ( SLODWORD(wrapperArray[3].wrapperArray) > 1107 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = v2->static_fields;
		    v8 = static_fields->wrapperArray;
		    if ( !static_fields->wrapperArray )
		      goto LABEL_13;
		    if ( v8->max_length.size <= 0x453u )
		      goto LABEL_29;
		    if ( v8[30].vector[27] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1107, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                 (ILFixDynamicMethodWrapper_20 *)Patch,
		                 (Object *)this,
		                 0LL);
		      goto LABEL_13;
		    }
		  }
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields;
		  static_fields = (ILFixDynamicMethodWrapper_2__StaticFields *)wrapperArray->wrapperArray;
		  if ( !wrapperArray->wrapperArray )
		    goto LABEL_13;
		  if ( SLODWORD(static_fields[3].wrapperArray) <= 1108 )
		    goto LABEL_9;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v2->static_fields;
		  v10 = wrapperArray->wrapperArray;
		  if ( !wrapperArray->wrapperArray )
		LABEL_13:
		    sub_1800D8260(wrapperArray, static_fields);
		  if ( v10->max_length.size <= 0x454u )
		LABEL_29:
		    sub_1800D2AB0(wrapperArray, static_fields);
		  if ( v10[30].vector[28] )
		  {
		    v11 = IFix::WrappersManagerImpl::GetPatch(1108, 0LL);
		    if ( v11 )
		    {
		      m_manualEnable = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(
		                         (ILFixDynamicMethodWrapper_20 *)v11,
		                         (Object *)this,
		                         0LL);
		      return m_manualEnable
		          && (HG::Rendering::Runtime::HGDepthOfField::IsNearFocusActive(this, 0LL)
		           || HG::Rendering::Runtime::HGDepthOfField::IsFarFocusActive(this, 0LL))
		          && UnityEngine::SystemInfo::SupportsComputeShaders(0LL);
		    }
		    goto LABEL_13;
		  }
		LABEL_9:
		  if ( this->fields.hgDebugCommand )
		    m_manualEnable = this->fields.m_manualEnable;
		  else
		    m_manualEnable = this->fields.enable;
		  return m_manualEnable
		      && (HG::Rendering::Runtime::HGDepthOfField::IsNearFocusActive(this, 0LL)
		       || HG::Rendering::Runtime::HGDepthOfField::IsFarFocusActive(this, 0LL))
		      && UnityEngine::SystemInfo::SupportsComputeShaders(0LL);
		}
		
		public bool IsNearFocusActive() => default; // 0x0000000189B6AEC4-0x0000000189B6AF3C
		// Boolean IsNearFocusActive()
		bool HG::Rendering::Runtime::HGDepthOfField::IsNearFocusActive(HGDepthOfField *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1109, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1109, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( this->fields.focusMode == 1 )
		    {
		      if ( this->fields.nearFocusEnd > this->fields.nearFocusStart )
		        return this->fields.nearRadius > 0.0;
		    }
		    else if ( !this->fields.focusMode )
		    {
		      return this->fields.nearRadius > 0.0;
		    }
		    return 0;
		  }
		}
		
		public bool IsFarFocusActive() => default; // 0x0000000189B6AE4C-0x0000000189B6AEC4
		// Boolean IsFarFocusActive()
		bool HG::Rendering::Runtime::HGDepthOfField::IsFarFocusActive(HGDepthOfField *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1110, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1110, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( this->fields.focusMode == 1 )
		    {
		      if ( this->fields.farFocusEnd > this->fields.farFocusStart )
		        return this->fields.farRadius > 0.0;
		    }
		    else if ( !this->fields.focusMode )
		    {
		      return this->fields.farRadius > 0.0;
		    }
		    return 0;
		  }
		}
		
	}
}
