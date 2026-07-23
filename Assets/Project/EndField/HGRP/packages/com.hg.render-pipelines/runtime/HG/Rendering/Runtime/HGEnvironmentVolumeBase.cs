using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Beyond;
using UnityEngine;
using UnityEngine.Serialization;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public abstract class HGEnvironmentVolumeBase : VFXPlayableMonoBase, IComparable<HG.Rendering.Runtime.HGEnvironmentVolumeBase> // TypeDefIndex: 37645
	{
		// Fields
		[FormerlySerializedAs("volumeType")]
		[Header("Volume \u7C7B\u578B")]
		[SerializeField]
		private EnvVolumeType _volumeType; // 0x20
		[NonSerialized]
		private bool _drawGizmos; // 0x24
		[FormerlySerializedAs("blendMode")]
		[Header("\u8FC7\u6E21\u65B9\u5F0F")]
		[SerializeField]
		private EnvBlendMode _blendMode; // 0x28
		[FormerlySerializedAs("priority")]
		[Header("\u4F18\u5148\u7EA7")]
		[SerializeField]
		private EnvPriority _priority; // 0x2C
		[FormerlySerializedAs("blendDistance")]
		[Header("\u8FC7\u6E21\u8DDD\u79BB")]
		[SerializeField]
		[UnclampedRangeExponential(1f, 200f, 2f)]
		private float _blendDistance; // 0x30
		[FormerlySerializedAs("fadeInDuration")]
		[Header("\u6DE1\u5165\u65F6\u95F4 (s)")]
		[SerializeField]
		[UnclampedRange(0f, 20f)]
		private float _fadeInDuration; // 0x34
		[FormerlySerializedAs("fadeOutDuration")]
		[Header("\u6DE1\u51FA\u65F6\u95F4 (s)")]
		[SerializeField]
		[UnclampedRange(0f, 20f)]
		private float _fadeOutDuration; // 0x38
		[Header("\u81EA\u5B9A\u4E49\u8FC7\u6E21\u503C")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _manualBlendFactor; // 0x3C
		[FormerlySerializedAs("polyLineShape")]
		[HideInInspector]
		[SerializeField]
		private BeyondPolyLineShape _polyLineShape; // 0x40
		[NonSerialized]
		public readonly Dictionary<HGCamera, InterpolateDataPerCamera> dataPerCameras; // 0x50
	
		// Properties
		public EnvVolumeType volumeType { get; set; } // 0x0000000182FA09A0-0x0000000182FA0A00 0x0000000183D0B4B0-0x0000000183D0B4F0
		// EnvVolumeType get_volumeType()
		EnvVolumeType__Enum HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_volumeType(
		        HGEnvironmentVolumeBase *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 617 )
		    return this->fields._volumeType;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x269 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[13]._0.declaringType )
		    return this->fields._volumeType;
		  Patch = IFix::WrappersManagerImpl::GetPatch(617, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_volumeType(EnvVolumeType)
		void HG::Rendering::Runtime::HGEnvironmentVolumeBase::set_volumeType(
		        HGEnvironmentVolumeBase *this,
		        EnvVolumeType__Enum value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1470, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1470, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_66(
		      (ILFixDynamicMethodWrapper_20 *)Patch,
		      (Object *)this,
		      (ETestEnum__Enum)value,
		      0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGEnvironmentVolumeBase::_UpdateVolumeType(this, value, 0LL);
		  }
		}
		
		public EnvBlendMode blendMode { get; set; } // 0x00000001831062E0-0x0000000183106340 0x0000000183D0B470-0x0000000183D0B4B0
		// EnvBlendMode get_blendMode()
		EnvBlendMode__Enum HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_blendMode(
		        HGEnvironmentVolumeBase *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 623 )
		    return this->fields._blendMode;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x26F )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[13]._0.fields )
		    return this->fields._blendMode;
		  Patch = IFix::WrappersManagerImpl::GetPatch(623, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_blendMode(EnvBlendMode)
		void HG::Rendering::Runtime::HGEnvironmentVolumeBase::set_blendMode(
		        HGEnvironmentVolumeBase *this,
		        EnvBlendMode__Enum value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1473, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1473, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_66(
		      (ILFixDynamicMethodWrapper_20 *)Patch,
		      (Object *)this,
		      (ETestEnum__Enum)value,
		      0LL);
		  }
		  else
		  {
		    this->fields._blendMode = value;
		  }
		}
		
		public EnvPriority priority { get; set; } // 0x00000001838A0860-0x00000001838A0890 0x0000000183D0B4F0-0x0000000183D0B530
		// EnvPriority get_priority()
		EnvPriority__Enum HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_priority(
		        HGEnvironmentVolumeBase *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(616, 0LL) )
		    return this->fields._priority;
		  Patch = IFix::WrappersManagerImpl::GetPatch(616, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_priority(EnvPriority)
		void HG::Rendering::Runtime::HGEnvironmentVolumeBase::set_priority(
		        HGEnvironmentVolumeBase *this,
		        EnvPriority__Enum value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1474, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1474, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_66(
		      (ILFixDynamicMethodWrapper_20 *)Patch,
		      (Object *)this,
		      (ETestEnum__Enum)value,
		      0LL);
		  }
		  else
		  {
		    HG::Rendering::Runtime::HGEnvironmentVolumeBase::_UpdatePriority(this, value, 0LL);
		  }
		}
		
		public float blendDistance { get; set; } // 0x0000000183D76FE0-0x0000000183D77040 0x0000000183D0B430-0x0000000183D0B470
		// Single get_blendDistance()
		float HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_blendDistance(
		        HGEnvironmentVolumeBase *this,
		        MethodInfo *method)
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
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 629 )
		    return this->fields._blendDistance;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x275 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[13].interfaceOffsets )
		    return this->fields._blendDistance;
		  Patch = IFix::WrappersManagerImpl::GetPatch(629, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, wrapperArray);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_blendDistance(Single)
		void HG::Rendering::Runtime::HGEnvironmentVolumeBase::set_blendDistance(
		        HGEnvironmentVolumeBase *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1476, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1476, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields._blendDistance = value;
		  }
		}
		
		public float fadeInDuration { get; set; } // 0x0000000183E657A0-0x0000000183E65800 0x0000000183D0B3F0-0x0000000183D0B430
		// Single get_fadeInDuration()
		float HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_fadeInDuration(
		        HGEnvironmentVolumeBase *this,
		        MethodInfo *method)
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
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 638 )
		    return this->fields._fadeInDuration;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x27E )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !*(_QWORD *)&v3[13]._1.instance_size )
		    return this->fields._fadeInDuration;
		  Patch = IFix::WrappersManagerImpl::GetPatch(638, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, wrapperArray);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_fadeInDuration(Single)
		void HG::Rendering::Runtime::HGEnvironmentVolumeBase::set_fadeInDuration(
		        HGEnvironmentVolumeBase *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1477, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1477, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields._fadeInDuration = value;
		  }
		}
		
		public float fadeOutDuration { get; set; } // 0x0000000183EA30C0-0x0000000183EA3120 0x0000000183D0B3B0-0x0000000183D0B3F0
		// Single get_fadeOutDuration()
		float HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_fadeOutDuration(
		        HGEnvironmentVolumeBase *this,
		        MethodInfo *method)
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
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 639 )
		    return this->fields._fadeOutDuration;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x27F )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !*(_QWORD *)&v3[13]._1.element_size )
		    return this->fields._fadeOutDuration;
		  Patch = IFix::WrappersManagerImpl::GetPatch(639, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, wrapperArray);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_fadeOutDuration(Single)
		void HG::Rendering::Runtime::HGEnvironmentVolumeBase::set_fadeOutDuration(
		        HGEnvironmentVolumeBase *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1478, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1478, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields._fadeOutDuration = value;
		  }
		}
		
		public float manualBlendFactor { get; set; } // 0x0000000189CE3938-0x0000000189CE3988 0x0000000189CE3988-0x0000000189CE39E4
		// Single get_manualBlendFactor()
		float HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_manualBlendFactor(
		        HGEnvironmentVolumeBase *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(641, 0LL) )
		    return this->fields._manualBlendFactor;
		  Patch = IFix::WrappersManagerImpl::GetPatch(641, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46((ILFixDynamicMethodWrapper_15 *)Patch, (Object *)this, 0LL);
		}
		

		// Void set_manualBlendFactor(Single)
		void HG::Rendering::Runtime::HGEnvironmentVolumeBase::set_manualBlendFactor(
		        HGEnvironmentVolumeBase *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1479, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1479, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)this, value, 0LL);
		  }
		  else
		  {
		    this->fields._manualBlendFactor = value;
		  }
		}
		
		public BeyondPolyLineShape polyLineShape { get; set; } // 0x0000000182FA0940-0x0000000182FA09A0 0x0000000183D0B370-0x0000000183D0B3B0
		// BeyondPolyLineShape get_polyLineShape()
		BeyondPolyLineShape *HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_polyLineShape(
		        HGEnvironmentVolumeBase *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 628 )
		    return this->fields._polyLineShape;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x274 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[13]._0.implementedInterfaces )
		    return this->fields._polyLineShape;
		  Patch = IFix::WrappersManagerImpl::GetPatch(628, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_252(Patch, (Object *)this, 0LL);
		}
		

		// Void set_polyLineShape(BeyondPolyLineShape)
		void HG::Rendering::Runtime::HGEnvironmentVolumeBase::set_polyLineShape(
		        HGEnvironmentVolumeBase *this,
		        BeyondPolyLineShape *value,
		        MethodInfo *method)
		{
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1480, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1480, 0LL);
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
		    this->fields._polyLineShape = value;
		    sub_18002D1B0((SingleFieldAccessor *)&this->fields._polyLineShape, v5, v6, v7, v11);
		  }
		}
		
		public bool timeFadingOut { get; set; } // 0x0000000184D867D0-0x0000000184D867E0 0x0000000184D86810-0x0000000184D86820
		// Boolean get_exists()
		bool FlowCanvas::Nodes::TryGetValue<UnityEngine::Ray>::get_exists(
		        TryGetValue_1_UnityEngine_Ray_ *this,
		        MethodInfo *method)
		{
		  return this->fields._exists_k__BackingField;
		}
		

		// Void set_exists(Boolean)
		void FlowCanvas::Nodes::TryGetValue<UnityEngine::Ray>::set_exists(
		        TryGetValue_1_UnityEngine_Ray_ *this,
		        bool value,
		        MethodInfo *method)
		{
		  this->fields._exists_k__BackingField = value;
		}
		
		public float timeFadingFactor { get; set; } // 0x0000000184D87860-0x0000000184D87870 0x0000000184D91480-0x0000000184D91490
		// Single get_DefaultValue()
		float Google::Protobuf::FieldCodec<float>::get_DefaultValue(FieldCodec_1_System_Single_ *this, MethodInfo *method)
		{
		  return this->fields._DefaultValue_k__BackingField;
		}
		

		// Void set_Depth(Single)
		void HG::Rendering::HgMath::CellGrid3D<System::Object>::set_Depth(
		        CellGrid3D_1_System_Object_ *this,
		        float value,
		        MethodInfo *method)
		{
		  this->fields._Depth_k__BackingField = value;
		}
		
	
		// Nested types
		public struct InterpolateDataPerCamera // TypeDefIndex: 37644
		{
			// Fields
			public float timeFadingFactor; // 0x00
		}
	
		// Constructors
		protected HGEnvironmentVolumeBase() {} // 0x00000001842EDFD0-0x00000001842EE050
		// HGEnvironmentVolumeBase()
		void HG::Rendering::Runtime::HGEnvironmentVolumeBase::HGEnvironmentVolumeBase(
		        HGEnvironmentVolumeBase *this,
		        MethodInfo *method)
		{
		  Dictionary_2_System_Object_HG_Rendering_Runtime_VolumetricEncodedTexture_PropertyIDPack_ *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  Dictionary_2_HG_Rendering_Runtime_HGCamera_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *v6; // rdi
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+20h] [rbp-8h]
		
		  this->fields._priority = 200;
		  this->fields._blendDistance = 5.0;
		  this->fields._fadeInDuration = 3.0;
		  this->fields._fadeOutDuration = 3.0;
		  this->fields._manualBlendFactor = 1.0;
		  v3 = (Dictionary_2_System_Object_HG_Rendering_Runtime_VolumetricEncodedTexture_PropertyIDPack_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>);
		  v6 = (Dictionary_2_HG_Rendering_Runtime_HGCamera_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *)v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  System::Collections::Generic::Dictionary<System::Object,HG::Rendering::Runtime::VolumetricEncodedTexture::PropertyIDPack>::Dictionary(
		    v3,
		    MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::Dictionary);
		  this->fields.dataPerCameras = v6;
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.dataPerCameras, v7, v8, v9, v10);
		  PaintIn3D::P3dButtonClearAll::P3dButtonClearAll((P3dButtonClearAll *)this, 0LL);
		}
		
	
		// Methods
		public abstract bool IsValid();
		public abstract HGEnvironmentPhase GetEnvPhaseForInterpolate();
		public bool Contains(Vector3 triggerPos) => default; // 0x0000000182FA0280-0x0000000182FA0310
		// Boolean Contains(Vector3)
		bool HG::Rendering::Runtime::HGEnvironmentVolumeBase::Contains(
		        HGEnvironmentVolumeBase *this,
		        Vector3 *triggerPos,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v11[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 624 )
		  {
		LABEL_5:
		    z = triggerPos->z;
		    *(_QWORD *)&v11[0].x = *(_QWORD *)&triggerPos->x;
		    v11[0].z = z;
		    return HG::Rendering::Runtime::HGEnvironmentVolumeBase::_DistanceToEdge(this, v11, 0LL) > 0.0;
		  }
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		    goto LABEL_6;
		  if ( LODWORD(v5->_0.namespaze) <= 0x270 )
		    sub_1800D2AB0(v5, triggerPos);
		  if ( !v5[13]._0.events )
		    goto LABEL_5;
		  Patch = IFix::WrappersManagerImpl::GetPatch(624, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v5, triggerPos);
		  v10 = *(_QWORD *)&triggerPos->x;
		  v11[0].z = triggerPos->z;
		  *(_QWORD *)&v11[0].x = v10;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_255(Patch, (Object *)this, v11, 0LL);
		}
		
		public int CompareTo(HGEnvironmentVolumeBase other) => default; // 0x00000001838A0710-0x00000001838A0860
		// Int32 CompareTo(HGEnvironmentVolumeBase)
		int32_t HG::Rendering::Runtime::HGEnvironmentVolumeBase::CompareTo(
		        HGEnvironmentVolumeBase *this,
		        HGEnvironmentVolumeBase *other,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  EnvPriority__Enum priority; // esi
		  EnvPriority__Enum v8; // edi
		  __int64 v9; // rax
		  Object *v10; // r8
		  struct EnvPriority__Enum__Class *v11; // rsi
		  Object *v12; // rbx
		  int32_t result; // eax
		  EnvVolumeType__Enum volumeType; // edi
		  __int64 v15; // rax
		  Object *v16; // r8
		  struct EnvVolumeType__Enum__Class *v17; // rsi
		  Object *v18; // rbx
		  String *v19; // rdi
		  __int64 v20; // rax
		  SystemException *v21; // rax
		  SystemException *v22; // rbx
		  __int64 v23; // rax
		  __int64 v24; // rsi
		  __int64 v25; // rbx
		  __int64 v26; // rax
		  Object__Array *v27; // rdi
		  __int64 v28; // rax
		  __int64 v29; // rbx
		  __int64 v30; // rbx
		  String *v31; // rax
		  String *v32; // rdi
		  __int64 v33; // rax
		  SystemException *v34; // rax
		  SystemException *v35; // rbx
		  __int64 v36; // rax
		  String *v37; // rdi
		  __int64 v38; // rax
		  SystemException *v39; // rax
		  SystemException *v40; // rbx
		  __int64 v41; // rax
		  __int64 object_1; // rsi
		  __int64 v43; // rbx
		  __int64 v44; // rax
		  Object__Array *v45; // rdi
		  __int64 v46; // rax
		  __int64 v47; // rbx
		  __int64 v48; // rbx
		  String *v49; // rax
		  String *ResourceString; // rdi
		  __int64 v51; // rax
		  SystemException *v52; // rax
		  SystemException *v53; // rbx
		  __int64 v54; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  void *v56; // [rsp+20h] [rbp-28h] BYREF
		  __int64 v57; // [rsp+28h] [rbp-20h]
		  unsigned __int32 v58; // [rsp+30h] [rbp-18h]
		  unsigned __int32 v59; // [rsp+68h] [rbp+20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(615, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(615, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_114(
		               (ILFixDynamicMethodWrapper_17 *)Patch,
		               (Object *)this,
		               (Object *)other,
		               0LL);
		    goto LABEL_12;
		  }
		  priority = HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_priority(this, 0LL);
		  if ( !other )
		    goto LABEL_12;
		  if ( priority != HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_priority(other, 0LL) )
		  {
		    v8 = HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_priority(this, 0LL);
		    v59 = HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_priority(other, 0LL);
		    v9 = il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::EnvPriority, &v59);
		    v11 = TypeInfo::HG::Rendering::Runtime::EnvPriority;
		    v12 = (Object *)v9;
		    v56 = TypeInfo::HG::Rendering::Runtime::EnvPriority;
		    v57 = -1LL;
		    v58 = v8;
		    if ( !TypeInfo::System::Enum->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::System::Enum);
		    result = System::Enum::InternalCompareTo((System::Enum *)&v56, v12, v10);
		    if ( result < 2 )
		      return result;
		    if ( result == 2 )
		    {
		      object_1 = il2cpp_type_get_object_1(&v11->_0.byval_arg);
		      if ( v12 )
		      {
		        v43 = il2cpp_type_get_object_1(&v12->klass->_0.byval_arg);
		        v44 = sub_180035ED0(&TypeInfo::System::Object);
		        v45 = (Object__Array *)il2cpp_array_new_specific_1(v44, 2LL);
		        if ( v43 )
		        {
		          v46 = sub_180032CB0(3LL, v43);
		          v47 = v46;
		          if ( v45 )
		          {
		            sub_180031B10(v45, v46);
		            sub_180005370(v45, 0LL, v47);
		            if ( object_1 )
		            {
		              v48 = sub_180032CB0(3LL, object_1);
		              sub_180031B10(v45, v48);
		              sub_180005370(v45, 1LL, v48);
		              v49 = (String *)sub_180035ED0(&off_18E32EA80);
		              ResourceString = System::Environment::GetResourceString(v49, v45, 0LL);
		              v51 = sub_180035ED0(&TypeInfo::System::ArgumentException);
		              v52 = (SystemException *)sub_1800368D0(v51);
		              v53 = v52;
		              if ( v52 )
		              {
		                System::SystemException::SystemException(v52, ResourceString, 0LL);
		                v53->fields._._HResult = -2147024809;
		                v54 = sub_180035ED0(&MethodInfo::System::Enum::CompareTo);
		                sub_18007E190(v53, v54);
		              }
		            }
		          }
		        }
		      }
		    }
		    else
		    {
		      v37 = (String *)sub_180035ED0(&off_18E32EA98);
		      v38 = sub_180035ED0(&TypeInfo::System::InvalidOperationException);
		      v39 = (SystemException *)sub_1800368D0(v38);
		      v40 = v39;
		      if ( v39 )
		      {
		        System::SystemException::SystemException(v39, v37, 0LL);
		        v40->fields._._HResult = -2146233079;
		        v41 = sub_180035ED0(&MethodInfo::System::Enum::CompareTo);
		        sub_18007E190(v40, v41);
		      }
		    }
		LABEL_12:
		    sub_1800D8260(v6, v5);
		  }
		  volumeType = HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_volumeType(this, 0LL);
		  v59 = HG::Rendering::Runtime::HGEnvironmentVolumeBase::get_volumeType(other, 0LL);
		  v15 = il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::EnvVolumeType, &v59);
		  v17 = TypeInfo::HG::Rendering::Runtime::EnvVolumeType;
		  v18 = (Object *)v15;
		  v56 = TypeInfo::HG::Rendering::Runtime::EnvVolumeType;
		  v57 = -1LL;
		  v58 = volumeType;
		  if ( !TypeInfo::System::Enum->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::System::Enum);
		  result = System::Enum::InternalCompareTo((System::Enum *)&v56, v18, v16);
		  if ( result >= 2 )
		  {
		    if ( result == 2 )
		    {
		      v24 = il2cpp_type_get_object_1(&v17->_0.byval_arg);
		      if ( v18 )
		      {
		        v25 = il2cpp_type_get_object_1(&v18->klass->_0.byval_arg);
		        v26 = sub_180035ED0(&TypeInfo::System::Object);
		        v27 = (Object__Array *)il2cpp_array_new_specific_1(v26, 2LL);
		        if ( v25 )
		        {
		          v28 = sub_180032CB0(3LL, v25);
		          v29 = v28;
		          if ( v27 )
		          {
		            sub_180031B10(v27, v28);
		            sub_180005370(v27, 0LL, v29);
		            if ( v24 )
		            {
		              v30 = sub_180032CB0(3LL, v24);
		              sub_180031B10(v27, v30);
		              sub_180005370(v27, 1LL, v30);
		              v31 = (String *)sub_180035ED0(&off_18E32EA80);
		              v32 = System::Environment::GetResourceString(v31, v27, 0LL);
		              v33 = sub_180035ED0(&TypeInfo::System::ArgumentException);
		              v34 = (SystemException *)sub_1800368D0(v33);
		              v35 = v34;
		              if ( v34 )
		              {
		                System::SystemException::SystemException(v34, v32, 0LL);
		                v35->fields._._HResult = -2147024809;
		                v36 = sub_180035ED0(&MethodInfo::System::Enum::CompareTo);
		                sub_18007E190(v35, v36);
		              }
		            }
		          }
		        }
		      }
		    }
		    else
		    {
		      v19 = (String *)sub_180035ED0(&off_18E32EA98);
		      v20 = sub_180035ED0(&TypeInfo::System::InvalidOperationException);
		      v21 = (SystemException *)sub_1800368D0(v20);
		      v22 = v21;
		      if ( v21 )
		      {
		        System::SystemException::SystemException(v21, v19, 0LL);
		        v22->fields._._HResult = -2146233079;
		        v23 = sub_180035ED0(&MethodInfo::System::Enum::CompareTo);
		        sub_18007E190(v22, v23);
		      }
		    }
		    goto LABEL_12;
		  }
		  return result;
		}
		
		public float GetDistanceBlendFactor(Vector3 triggerPos) => default; // 0x0000000183D76EA0-0x0000000183D76FE0
		// Single GetDistanceBlendFactor(Vector3)
		float HG::Rendering::Runtime::HGEnvironmentVolumeBase::GetDistanceBlendFactor(
		        HGEnvironmentVolumeBase *this,
		        Vector3 *triggerPos,
		        MethodInfo *method)
		{
		  float v3; // xmm1_4
		  Vector3 *v5; // rdi
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  int32_t volumeType; // eax
		  float z; // eax
		  float v10; // xmm0_4
		  float v11; // xmm6_4
		  float blendDistance; // xmm0_4
		  float result; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v15; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *v16; // rax
		  ILFixDynamicMethodWrapper_2 *v17; // rax
		  Vector3 v18; // [rsp+20h] [rbp-28h] BYREF
		
		  v5 = triggerPos;
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_17;
		  if ( wrapperArray->max_length.size <= 634 )
		    goto LABEL_43;
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  triggerPos = (Vector3 *)v6->static_fields->wrapperArray;
		  if ( !triggerPos )
		    goto LABEL_17;
		  if ( LODWORD(triggerPos[2].x) <= 0x27A )
		    goto LABEL_39;
		  if ( *(_QWORD *)&triggerPos[425].y )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(634, 0LL);
		    if ( !Patch )
		      goto LABEL_17;
		    v15 = *(_QWORD *)&v5->x;
		    v18.z = v5->z;
		    *(_QWORD *)&v18.x = v15;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_254(Patch, (Object *)this, &v18, 0LL);
		  }
		  else
		  {
		LABEL_43:
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    triggerPos = (Vector3 *)v6->static_fields->wrapperArray;
		    if ( !triggerPos )
		      goto LABEL_17;
		    if ( SLODWORD(triggerPos[2].x) <= 617 )
		      goto LABEL_9;
		    if ( !v6->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v6);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    triggerPos = (Vector3 *)v6->static_fields->wrapperArray;
		    if ( !triggerPos )
		      goto LABEL_17;
		    if ( LODWORD(triggerPos[2].x) <= 0x269 )
		      goto LABEL_39;
		    if ( *(_QWORD *)&triggerPos[414].x )
		    {
		      v16 = IFix::WrappersManagerImpl::GetPatch(617, 0LL);
		      if ( !v16 )
		        goto LABEL_17;
		      volumeType = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		                     (ILFixDynamicMethodWrapper_31 *)v16,
		                     (Object *)this,
		                     0LL);
		    }
		    else
		    {
		LABEL_9:
		      volumeType = this->fields._volumeType;
		    }
		    if ( volumeType )
		    {
		      z = v5->z;
		      *(_QWORD *)&v18.x = *(_QWORD *)&v5->x;
		      v18.z = z;
		      v10 = HG::Rendering::Runtime::HGEnvironmentVolumeBase::_DistanceToEdge(this, &v18, 0LL);
		      v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      v11 = v10;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      triggerPos = (Vector3 *)v6->static_fields->wrapperArray;
		      if ( !triggerPos )
		        goto LABEL_17;
		      if ( SLODWORD(triggerPos[2].x) <= 629 )
		      {
		LABEL_15:
		        blendDistance = this->fields._blendDistance;
		LABEL_16:
		        result = v11 / (float)(blendDistance + COERCE_FLOAT(1));
		        Beyond::JobMathf::Clamp01((Beyond::JobMathf *)v6, v3);
		        return result;
		      }
		      if ( !v6->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v6);
		        v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		      if ( !v6 )
		LABEL_17:
		        sub_1800D8260(v6, triggerPos);
		      if ( LODWORD(v6->_0.namespaze) > 0x275 )
		      {
		        if ( !v6[13].interfaceOffsets )
		          goto LABEL_15;
		        v17 = IFix::WrappersManagerImpl::GetPatch(629, 0LL);
		        if ( v17 )
		        {
		          blendDistance = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                            (ILFixDynamicMethodWrapper_15 *)v17,
		                            (Object *)this,
		                            0LL);
		          goto LABEL_16;
		        }
		        goto LABEL_17;
		      }
		LABEL_39:
		      sub_1800D2AB0(v6, triggerPos);
		    }
		    return 1.0;
		  }
		}
		
		protected override void OnPlay() {} // 0x000000018389E9D0-0x000000018389EA40
		// Void OnPlay()
		void HG::Rendering::Runtime::HGEnvironmentVolumeBase::OnPlay(HGEnvironmentVolumeBase *this, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  Dictionary_2_HG_Rendering_Runtime_HGCamera_HG_Rendering_Runtime_HGEnvironmentVolumeBase_InterpolateDataPerCamera_ *dataPerCameras; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1481, 0LL) )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    HG::Rendering::Runtime::HGEnvironmentManager::Register(this, 0LL);
		    dataPerCameras = this->fields.dataPerCameras;
		    if ( dataPerCameras )
		    {
		      System::Collections::Generic::Dictionary<Beyond::Gameplay::Core::WaterVolumePtr,System::ValueTuple<float,System::Int32Enum,System::Object>>::Clear(
		        (Dictionary_2_Beyond_Gameplay_Core_WaterVolumePtr_System_ValueTuple_3_Single_Int32Enum_Object_ *)dataPerCameras,
		        MethodInfo::System::Collections::Generic::Dictionary<HG::Rendering::Runtime::HGCamera,HG::Rendering::Runtime::HGEnvironmentVolumeBase::InterpolateDataPerCamera>::Clear);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(dataPerCameras, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1481, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		}
		
		protected override void OnStop() {} // 0x000000018389E870-0x000000018389E8C0
		// Void OnStop()
		void HG::Rendering::Runtime::HGEnvironmentVolumeBase::OnStop(HGEnvironmentVolumeBase *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1484, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1484, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		    HG::Rendering::Runtime::HGEnvironmentManager::Unregister(this, 0LL);
		  }
		}
		
		private void _UpdateVolumeType(EnvVolumeType value) {} // 0x0000000183D0B320-0x0000000183D0B370
		// Void _UpdateVolumeType(EnvVolumeType)
		void HG::Rendering::Runtime::HGEnvironmentVolumeBase::_UpdateVolumeType(
		        HGEnvironmentVolumeBase *this,
		        EnvVolumeType__Enum value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1471, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1471, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_66(
		      (ILFixDynamicMethodWrapper_20 *)Patch,
		      (Object *)this,
		      (ETestEnum__Enum)value,
		      0LL);
		  }
		  else if ( this->fields._volumeType != value )
		  {
		    if ( UnityEngine::Behaviour::get_isActiveAndEnabled((Behaviour *)this, 0LL) )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      HG::Rendering::Runtime::HGEnvironmentManager::set_sortNeeded(1, 0LL);
		    }
		    this->fields._volumeType = value;
		  }
		}
		
		private void _UpdatePriority(EnvPriority value) {} // 0x0000000183D0B530-0x0000000183D0B5A0
		// Void _UpdatePriority(EnvPriority)
		void HG::Rendering::Runtime::HGEnvironmentVolumeBase::_UpdatePriority(
		        HGEnvironmentVolumeBase *this,
		        EnvPriority__Enum value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1475, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1475, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_66(
		      (ILFixDynamicMethodWrapper_20 *)Patch,
		      (Object *)this,
		      (ETestEnum__Enum)value,
		      0LL);
		  }
		  else if ( this->fields._priority != value )
		  {
		    if ( UnityEngine::Behaviour::get_isActiveAndEnabled((Behaviour *)this, 0LL) )
		    {
		      if ( !TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
		      HG::Rendering::Runtime::HGEnvironmentManager::set_sortNeeded(1, 0LL);
		    }
		    this->fields._priority = value;
		  }
		}
		
		private float _DistanceToEdge(Vector3 triggerPos) => default; // 0x0000000182FA0310-0x0000000182FA0940
		// Single _DistanceToEdge(Vector3)
		float HG::Rendering::Runtime::HGEnvironmentVolumeBase::_DistanceToEdge(
		        HGEnvironmentVolumeBase *this,
		        Vector3 *triggerPos,
		        MethodInfo *method)
		{
		  BeyondPolyLineShape *wrapperArray; // rcx
		  ILFixDynamicMethodWrapper_2__Array *v6; // rdx
		  int32_t volumeType; // edx
		  BeyondPolyLineShape *polyLineShape; // rax
		  int32_t blendMode; // eax
		  float v10; // eax
		  __int64 v12; // rdx
		  __int64 (__fastcall *v13)(HGEnvironmentVolumeBase *, __int64, MethodInfo *); // rax
		  __int64 v14; // rsi
		  void (__fastcall *v15)(__int64, Quaternion *); // rax
		  void (__fastcall *v16)(Quaternion *, Quaternion *); // rax
		  __int64 (__fastcall *v17)(HGEnvironmentVolumeBase *); // rax
		  __int64 v18; // rsi
		  void (__fastcall *v19)(__int64, Vector3 *); // rax
		  __int64 v20; // xmm0_8
		  float v21; // eax
		  MethodInfo *v22; // r9
		  Vector3 *v23; // rax
		  __int64 v24; // xmm3_8
		  Vector3 *v25; // rax
		  __int64 v26; // xmm7_8
		  bool v27; // zf
		  unsigned int z_low; // edi
		  __m128 si128; // xmm6
		  unsigned __int64 v30; // xmm7_8
		  float v31; // edi
		  __int64 (__fastcall *v32)(HGEnvironmentVolumeBase *); // rax
		  __int64 v33; // rbx
		  void (__fastcall *v34)(__int64, Vector3 *); // rax
		  struct ILFixDynamicMethodWrapper_2__Class *v35; // r9
		  int v36; // ecx
		  unsigned __int64 v37; // xmm0_8
		  Vector3 *v38; // rax
		  __int64 v39; // xmm3_8
		  MethodInfo *v40; // r9
		  Vector3 *v41; // rax
		  struct ILFixDynamicMethodWrapper_2__Class *v42; // r9
		  float v43; // xmm8_4
		  float v44; // xmm8_4
		  __m128 v45; // xmm6
		  __m128 v46; // xmm7
		  BeyondPolyLineShape *v48; // rsi
		  float blendDistance; // xmm2_4
		  float v50; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v52; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *v53; // rax
		  int32_t v54; // eax
		  int v55; // edx
		  Transform *v56; // rax
		  Vector3 *v57; // rax
		  __int64 v58; // xmm6_8
		  float v59; // esi
		  Vector3 *v60; // rax
		  float v61; // esi
		  Transform *v62; // rax
		  Quaternion v63; // xmm6
		  Transform *v64; // rax
		  Vector3 *v65; // rax
		  __int64 v66; // xmm0_8
		  __int64 v67; // xmm0_8
		  MethodInfo *v68; // r9
		  Vector3 *v69; // rax
		  __int64 v70; // xmm3_8
		  Vector3 *v71; // rax
		  __int64 v72; // xmm0_8
		  Vector3 *v73; // rax
		  __m128 v74; // xmm8
		  float v75; // xmm7_4
		  double v76; // xmm0_8
		  Transform *transform; // rax
		  Vector3 *lossyScale; // rax
		  __int64 v79; // xmm6_8
		  float z; // esi
		  Vector3 *v81; // rax
		  __int64 v82; // xmm0_8
		  float v83; // xmm6_4
		  Transform *v84; // rax
		  __int64 v85; // xmm1_8
		  Vector3 *position; // rax
		  __int64 v87; // xmm0_8
		  __int64 v88; // r8
		  double v89; // xmm0_8
		  __int64 v90; // rax
		  __int64 v91; // rax
		  ILFixDynamicMethodWrapper_2 *v92; // rax
		  Vector3 *v93; // rax
		  __int64 v94; // rax
		  ILFixDynamicMethodWrapper_2 *v95; // rax
		  Vector3 *v96; // rax
		  ILFixDynamicMethodWrapper_2 *v97; // rax
		  ILFixDynamicMethodWrapper_2 *v98; // rax
		  ILFixDynamicMethodWrapper_2 *v99; // rax
		  ILFixDynamicMethodWrapper_2 *v100; // rax
		  BeyondPolyLineShape *v101; // rax
		  ILFixDynamicMethodWrapper_2 *v102; // rax
		  ILFixDynamicMethodWrapper_2 *v103; // rax
		  Vector3 v104; // [rsp+20h] [rbp-29h] BYREF
		  Vector3 v105; // [rsp+30h] [rbp-19h] BYREF
		  Quaternion v106; // [rsp+40h] [rbp-9h] BYREF
		  Quaternion v107; // [rsp+50h] [rbp+7h] BYREF
		  Quaternion v108; // [rsp+60h] [rbp+17h] BYREF
		  Vector2 v109; // [rsp+C8h] [rbp+7Fh] BYREF
		
		  wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **(ILFixDynamicMethodWrapper_2__Array ***)&wrapperArray[1].fields.m_height;
		  if ( !v6 )
		    goto LABEL_77;
		  if ( v6->max_length.size > 625 )
		  {
		    if ( !LODWORD(wrapperArray[1].fields.m_convexPolygons) )
		    {
		      il2cpp_runtime_class_init_1(wrapperArray);
		      wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = **(ILFixDynamicMethodWrapper_2__Array ***)&wrapperArray[1].fields.m_height;
		    if ( !v6 )
		      goto LABEL_77;
		    if ( v6->max_length.size <= 0x271u )
		      goto LABEL_170;
		    if ( v6[17].vector[13] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(625, 0LL);
		      if ( !Patch )
		        goto LABEL_77;
		      v52 = *(_QWORD *)&triggerPos->x;
		      v104.z = triggerPos->z;
		      *(_QWORD *)&v104.x = v52;
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_254(Patch, (Object *)this, &v104, 0LL);
		    }
		  }
		  if ( !LODWORD(wrapperArray[1].fields.m_convexPolygons) )
		  {
		    il2cpp_runtime_class_init_1(wrapperArray);
		    wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **(ILFixDynamicMethodWrapper_2__Array ***)&wrapperArray[1].fields.m_height;
		  if ( !v6 )
		    goto LABEL_77;
		  if ( v6->max_length.size <= 617 )
		    goto LABEL_9;
		  if ( !LODWORD(wrapperArray[1].fields.m_convexPolygons) )
		  {
		    il2cpp_runtime_class_init_1(wrapperArray);
		    wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **(ILFixDynamicMethodWrapper_2__Array ***)&wrapperArray[1].fields.m_height;
		  if ( !v6 )
		    goto LABEL_77;
		  if ( v6->max_length.size <= 0x269u )
		    goto LABEL_170;
		  if ( v6[17].vector[5] )
		  {
		    v53 = IFix::WrappersManagerImpl::GetPatch(617, 0LL);
		    if ( !v53 )
		      goto LABEL_77;
		    v54 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1((ILFixDynamicMethodWrapper_31 *)v53, (Object *)this, 0LL);
		    wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    volumeType = v54;
		  }
		  else
		  {
		LABEL_9:
		    volumeType = this->fields._volumeType;
		  }
		  if ( volumeType != 3 )
		  {
		    if ( !volumeType )
		      return 3.4028235e38;
		    v12 = (unsigned int)(volumeType - 1);
		    if ( (_DWORD)v12 )
		    {
		      v55 = v12 - 1;
		      if ( !v55 )
		      {
		        transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
		        if ( !transform )
		          goto LABEL_77;
		        lossyScale = UnityEngine::Transform::get_lossyScale((Vector3 *)&v107, transform, 0LL);
		        v79 = *(_QWORD *)&lossyScale->x;
		        z = lossyScale->z;
		        if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		          il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        *(_QWORD *)&v106.x = v79;
		        v106.z = z;
		        v81 = HG::Rendering::Runtime::HGUtils::Abs((Vector3 *)&v107, (Vector3 *)&v106, 0LL);
		        v82 = *(_QWORD *)&v81->x;
		        *(float *)&v81 = v81->z;
		        *(_QWORD *)&v106.x = v82;
		        LODWORD(v106.z) = (_DWORD)v81;
		        v83 = HG::Rendering::Runtime::HGEnvironmentUtils::MinComponent((Vector3 *)&v106, 0LL);
		        v84 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		        if ( !v84 )
		          goto LABEL_77;
		        v85 = *(_QWORD *)&triggerPos->x;
		        v106.z = triggerPos->z;
		        *(_QWORD *)&v106.x = v85;
		        position = UnityEngine::Transform::get_position((Vector3 *)&v107, v84, 0LL);
		        v87 = *(_QWORD *)&position->x;
		        *(float *)&position = position->z;
		        *(_QWORD *)&v105.x = v87;
		        LODWORD(v105.z) = (_DWORD)position;
		        v89 = sub_1833FD010(&v105, &v106, v88);
		        return fmaxf((float)(v83 * 0.5) - *(float *)&v89, 0.0);
		      }
		      if ( v55 != 2 )
		        return 0.0;
		      v56 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( !v56 )
		        goto LABEL_77;
		      v57 = UnityEngine::Transform::get_lossyScale((Vector3 *)&v106, v56, 0LL);
		      v58 = *(_QWORD *)&v57->x;
		      v59 = v57->z;
		      if ( !TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      *(_QWORD *)&v104.x = v58;
		      v104.z = v59;
		      v60 = HG::Rendering::Runtime::HGUtils::Abs(&v105, &v104, 0LL);
		      v61 = v60->z;
		      *(_QWORD *)&v106.x = *(_QWORD *)&v60->x;
		      v62 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( !v62 )
		        goto LABEL_77;
		      v108 = *UnityEngine::Transform::get_rotation(&v108, v62, 0LL);
		      v63 = *UnityEngine::Quaternion::Inverse(&v107, &v108, 0LL);
		      v64 = UnityEngine::Component::get_transform((Component *)this, 0LL);
		      if ( !v64 )
		        goto LABEL_77;
		      v65 = UnityEngine::Transform::get_position(&v105, v64, 0LL);
		      v66 = *(_QWORD *)&v65->x;
		      *(float *)&v65 = v65->z;
		      *(_QWORD *)&v104.x = v66;
		      v67 = *(_QWORD *)&triggerPos->x;
		      LODWORD(v104.z) = (_DWORD)v65;
		      *(float *)&v65 = triggerPos->z;
		      *(_QWORD *)&v105.x = v67;
		      LODWORD(v105.z) = (_DWORD)v65;
		      v69 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v107, &v105, &v104, v68);
		      v108 = v63;
		      v70 = *(_QWORD *)&v69->x;
		      *(float *)&v69 = v69->z;
		      *(_QWORD *)&v105.x = v70;
		      LODWORD(v105.z) = (_DWORD)v69;
		      v71 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v107, &v108, &v105, 0LL);
		      v72 = *(_QWORD *)&v71->x;
		      *(float *)&v71 = v71->z;
		      *(_QWORD *)&v105.x = v72;
		      LODWORD(v105.z) = (_DWORD)v71;
		      v73 = HG::Rendering::Runtime::HGUtils::Abs((Vector3 *)&v107, &v105, 0LL);
		      v74 = (__m128)*(unsigned __int64 *)&v73->x;
		      v105.z = v73->z;
		      *(_QWORD *)&v105.x = v74.m128_u64[0];
		      v109 = HG::Rendering::Runtime::VectorSwizzleUtils::xz(&v105, 0LL);
		      v75 = fminf(v106.x, v61) * 0.5;
		      v76 = sub_182FA2AF0(&v109);
		      return fminf(
		               fmaxf(v75 - *(float *)&v76, 0.0),
		               fmaxf((float)(v106.y * 0.5) - _mm_shuffle_ps(v74, v74, 85).m128_f32[0], 0.0));
		    }
		    else
		    {
		      v13 = (__int64 (__fastcall *)(HGEnvironmentVolumeBase *, __int64, MethodInfo *))qword_18F36FBC0;
		      if ( !qword_18F36FBC0 )
		      {
		        v13 = (__int64 (__fastcall *)(HGEnvironmentVolumeBase *, __int64, MethodInfo *))sub_180059EA0(
		                                                                                          "UnityEngine.Component::get_transform()");
		        qword_18F36FBC0 = (__int64)v13;
		      }
		      v14 = v13(this, v12, method);
		      if ( !v14 )
		        goto LABEL_77;
		      v15 = (void (__fastcall *)(__int64, Quaternion *))qword_18F370110;
		      v107 = 0LL;
		      if ( !qword_18F370110 )
		      {
		        v15 = (void (__fastcall *)(__int64, Quaternion *))il2cpp_resolve_icall_1(
		                                                            "UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
		        if ( !v15 )
		        {
		          v90 = sub_1802EE1B8("UnityEngine.Transform::get_rotation_Injected(UnityEngine.Quaternion&)");
		          sub_18007E1B0(v90, 0LL);
		        }
		        qword_18F370110 = (__int64)v15;
		      }
		      v15(v14, &v107);
		      v16 = (void (__fastcall *)(Quaternion *, Quaternion *))qword_18F36FAA8;
		      v106 = v107;
		      v108 = 0LL;
		      if ( !qword_18F36FAA8 )
		      {
		        v16 = (void (__fastcall *)(Quaternion *, Quaternion *))sub_180059EA0(
		                                                                 "UnityEngine.Quaternion::Inverse_Injected(UnityEngine.Qu"
		                                                                 "aternion&,UnityEngine.Quaternion&)");
		        qword_18F36FAA8 = (__int64)v16;
		      }
		      v16(&v106, &v108);
		      v17 = (__int64 (__fastcall *)(HGEnvironmentVolumeBase *))qword_18F36FBC0;
		      if ( !qword_18F36FBC0 )
		      {
		        v17 = (__int64 (__fastcall *)(HGEnvironmentVolumeBase *))sub_180059EA0("UnityEngine.Component::get_transform()");
		        qword_18F36FBC0 = (__int64)v17;
		      }
		      v18 = v17(this);
		      if ( !v18 )
		        goto LABEL_77;
		      *(_QWORD *)&v104.x = 0LL;
		      v104.z = 0.0;
		      v19 = (void (__fastcall *)(__int64, Vector3 *))qword_18F3700F0;
		      if ( !qword_18F3700F0 )
		      {
		        v19 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		        if ( !v19 )
		        {
		          v91 = sub_1802EE1B8("UnityEngine.Transform::get_position_Injected(UnityEngine.Vector3&)");
		          sub_18007E1B0(v91, 0LL);
		        }
		        qword_18F3700F0 = (__int64)v19;
		      }
		      v19(v18, &v104);
		      *(_QWORD *)&v106.x = *(_QWORD *)&v104.x;
		      v20 = *(_QWORD *)&triggerPos->x;
		      v106.z = v104.z;
		      v21 = triggerPos->z;
		      *(_QWORD *)&v105.x = v20;
		      v105.z = v21;
		      v23 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v107, &v105, (Vector3 *)&v106, v22);
		      v24 = *(_QWORD *)&v23->x;
		      *(float *)&v23 = v23->z;
		      *(_QWORD *)&v106.x = v24;
		      LODWORD(v106.z) = (_DWORD)v23;
		      v25 = UnityEngine::Quaternion::op_Multiply((Vector3 *)&v107, &v108, (Vector3 *)&v106, 0LL);
		      v26 = *(_QWORD *)&v25->x;
		      v27 = TypeInfo::HG::Rendering::Runtime::HGUtils->_1.cctor_finished_or_no_cctor == 0;
		      z_low = LODWORD(v25->z);
		      *(_QWORD *)&v106.x = *(_QWORD *)&v25->x;
		      if ( v27 )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v6 = **(ILFixDynamicMethodWrapper_2__Array ***)&wrapperArray[1].fields.m_height;
		      if ( !v6 )
		        goto LABEL_77;
		      si128 = (__m128)_mm_load_si128((const __m128i *)&xmmword_18B9592D0);
		      if ( v6->max_length.size <= 626 )
		        goto LABEL_49;
		      if ( !LODWORD(wrapperArray[1].fields.m_convexPolygons) )
		      {
		        il2cpp_runtime_class_init_1(wrapperArray);
		        wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      wrapperArray = **(BeyondPolyLineShape ***)&wrapperArray[1].fields.m_height;
		      if ( !wrapperArray )
		        goto LABEL_77;
		      if ( LODWORD(wrapperArray->fields.m_position.x) <= 0x272 )
		        goto LABEL_170;
		      if ( wrapperArray[37].monitor )
		      {
		        v92 = IFix::WrappersManagerImpl::GetPatch(626, 0LL);
		        if ( !v92 )
		          goto LABEL_77;
		        *(_QWORD *)&v106.x = v26;
		        LODWORD(v106.z) = z_low;
		        v93 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(&v105, v92, (Vector3 *)&v106, 0LL);
		        v30 = *(_QWORD *)&v93->x;
		        v31 = v93->z;
		      }
		      else
		      {
		LABEL_49:
		        v30 = _mm_unpacklo_ps(_mm_and_ps((__m128)LODWORD(v106.x), si128), _mm_and_ps((__m128)LODWORD(v106.y), si128)).m128_u64[0];
		        v31 = COERCE_FLOAT(_mm_cvtsi128_si32((__m128i)_mm_and_ps((__m128)_mm_cvtsi32_si128(z_low), si128)));
		      }
		      v32 = (__int64 (__fastcall *)(HGEnvironmentVolumeBase *))qword_18F36FBC0;
		      if ( !qword_18F36FBC0 )
		      {
		        v32 = (__int64 (__fastcall *)(HGEnvironmentVolumeBase *))sub_180059EA0("UnityEngine.Component::get_transform()");
		        qword_18F36FBC0 = (__int64)v32;
		      }
		      v33 = v32(this);
		      if ( !v33 )
		        goto LABEL_77;
		      *(_QWORD *)&v104.x = 0LL;
		      v104.z = 0.0;
		      v34 = (void (__fastcall *)(__int64, Vector3 *))qword_18F370198;
		      if ( !qword_18F370198 )
		      {
		        v34 = (void (__fastcall *)(__int64, Vector3 *))il2cpp_resolve_icall_1(
		                                                         "UnityEngine.Transform::get_lossyScale_Injected(UnityEngine.Vector3&)");
		        if ( !v34 )
		        {
		          v94 = sub_1802EE1B8("UnityEngine.Transform::get_lossyScale_Injected(UnityEngine.Vector3&)");
		          sub_18007E1B0(v94, 0LL);
		        }
		        qword_18F370198 = (__int64)v34;
		      }
		      v34(v33, &v104);
		      v35 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		        v35 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      wrapperArray = (BeyondPolyLineShape *)v35->static_fields->wrapperArray;
		      if ( !wrapperArray )
		        goto LABEL_77;
		      if ( SLODWORD(wrapperArray->fields.m_position.x) <= 626 )
		        goto LABEL_58;
		      if ( !v35->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v35);
		        v35 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v6 = v35->static_fields->wrapperArray;
		      if ( !v6 )
		        goto LABEL_77;
		      if ( v6->max_length.size <= 0x272u )
		        goto LABEL_170;
		      if ( v6[17].vector[14] )
		      {
		        v95 = IFix::WrappersManagerImpl::GetPatch(626, 0LL);
		        if ( !v95 )
		          goto LABEL_77;
		        *(Vector3 *)&v106.x = v104;
		        v96 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250((Vector3 *)&v107, v95, (Vector3 *)&v106, 0LL);
		        v35 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		        v37 = *(_QWORD *)&v96->x;
		        v36 = LODWORD(v96->z);
		      }
		      else
		      {
		LABEL_58:
		        v36 = _mm_cvtsi128_si32((__m128i)_mm_and_ps((__m128)LODWORD(v104.z), si128));
		        v37 = _mm_unpacklo_ps(_mm_and_ps((__m128)LODWORD(v104.x), si128), _mm_and_ps((__m128)LODWORD(v104.y), si128)).m128_u64[0];
		      }
		      LODWORD(v106.z) = v36;
		      *(_QWORD *)&v106.x = v37;
		      *(_QWORD *)&v105.x = v30;
		      v105.z = v31;
		      v38 = UnityEngine::Vector3::op_Multiply((Vector3 *)&v107, (Vector3 *)&v106, 0.5, (MethodInfo *)v35);
		      v39 = *(_QWORD *)&v38->x;
		      *(float *)&v38 = v38->z;
		      *(_QWORD *)&v106.x = v39;
		      LODWORD(v106.z) = (_DWORD)v38;
		      v41 = UnityEngine::Vector3::op_Subtraction((Vector3 *)&v107, (Vector3 *)&v106, &v105, v40);
		      v43 = v41->z;
		      *(_QWORD *)&v106.x = *(_QWORD *)&v41->x;
		      v45 = _mm_shuffle_ps((__m128)*(unsigned __int64 *)&v106.x, (__m128)*(unsigned __int64 *)&v106.x, 85);
		      v44 = fmaxf(v43, 0.0);
		      v46 = (__m128)*(unsigned __int64 *)&v106.x;
		      v45.m128_f32[0] = fmaxf(v45.m128_f32[0], 0.0);
		      v46.m128_f32[0] = fmaxf(v106.x, 0.0);
		      if ( !v42->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v42);
		        v42 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      wrapperArray = (BeyondPolyLineShape *)v42->static_fields->wrapperArray;
		      if ( !wrapperArray )
		        goto LABEL_77;
		      if ( SLODWORD(wrapperArray->fields.m_position.x) <= 627 )
		        return fminf(v46.m128_f32[0], fminf(v45.m128_f32[0], v44));
		      if ( !v42->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v42);
		        v42 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      v6 = v42->static_fields->wrapperArray;
		      if ( !v6 )
		        goto LABEL_77;
		      if ( v6->max_length.size <= 0x273u )
		        goto LABEL_170;
		      if ( v6[17].vector[15] )
		      {
		        v97 = IFix::WrappersManagerImpl::GetPatch(627, 0LL);
		        if ( !v97 )
		          goto LABEL_77;
		        v106.z = v44;
		        *(_QWORD *)&v106.x = _mm_unpacklo_ps(v46, v45).m128_u64[0];
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_251(v97, (Vector3 *)&v106, 0LL);
		      }
		      else
		      {
		        return fminf(v46.m128_f32[0], fminf(v45.m128_f32[0], v44));
		      }
		    }
		  }
		  if ( !LODWORD(wrapperArray[1].fields.m_convexPolygons) )
		  {
		    il2cpp_runtime_class_init_1(wrapperArray);
		    wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **(ILFixDynamicMethodWrapper_2__Array ***)&wrapperArray[1].fields.m_height;
		  if ( !v6 )
		    goto LABEL_77;
		  if ( v6->max_length.size <= 628 )
		    goto LABEL_15;
		  if ( !LODWORD(wrapperArray[1].fields.m_convexPolygons) )
		  {
		    il2cpp_runtime_class_init_1(wrapperArray);
		    wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **(ILFixDynamicMethodWrapper_2__Array ***)&wrapperArray[1].fields.m_height;
		  if ( !v6 )
		    goto LABEL_77;
		  if ( v6->max_length.size <= 0x274u )
		    goto LABEL_170;
		  if ( v6[17].vector[16] )
		  {
		    v98 = IFix::WrappersManagerImpl::GetPatch(628, 0LL);
		    if ( !v98 )
		      goto LABEL_77;
		    polyLineShape = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_252(v98, (Object *)this, 0LL);
		    wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_15:
		    polyLineShape = this->fields._polyLineShape;
		  }
		  if ( !polyLineShape )
		    return 0.0;
		  if ( !LODWORD(wrapperArray[1].fields.m_convexPolygons) )
		  {
		    il2cpp_runtime_class_init_1(wrapperArray);
		    wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **(ILFixDynamicMethodWrapper_2__Array ***)&wrapperArray[1].fields.m_height;
		  if ( !v6 )
		    goto LABEL_77;
		  if ( v6->max_length.size <= 623 )
		    goto LABEL_21;
		  if ( !LODWORD(wrapperArray[1].fields.m_convexPolygons) )
		  {
		    il2cpp_runtime_class_init_1(wrapperArray);
		    wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **(ILFixDynamicMethodWrapper_2__Array ***)&wrapperArray[1].fields.m_height;
		  if ( !v6 )
		    goto LABEL_77;
		  if ( v6->max_length.size <= 0x26Fu )
		    goto LABEL_170;
		  if ( v6[17].vector[11] )
		  {
		    v99 = IFix::WrappersManagerImpl::GetPatch(623, 0LL);
		    if ( !v99 )
		      goto LABEL_77;
		    blendMode = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_7((ILFixDynamicMethodWrapper_26 *)v99, (Object *)this, 0LL);
		    wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  else
		  {
		LABEL_21:
		    blendMode = this->fields._blendMode;
		  }
		  if ( blendMode != 1 )
		  {
		    if ( !LODWORD(wrapperArray[1].fields.m_convexPolygons) )
		    {
		      il2cpp_runtime_class_init_1(wrapperArray);
		      wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v6 = **(ILFixDynamicMethodWrapper_2__Array ***)&wrapperArray[1].fields.m_height;
		    if ( !v6 )
		      goto LABEL_77;
		    if ( v6->max_length.size <= 628 )
		      goto LABEL_27;
		    if ( !LODWORD(wrapperArray[1].fields.m_convexPolygons) )
		    {
		      il2cpp_runtime_class_init_1(wrapperArray);
		      wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = **(BeyondPolyLineShape ***)&wrapperArray[1].fields.m_height;
		    if ( !wrapperArray )
		      goto LABEL_77;
		    if ( LODWORD(wrapperArray->fields.m_position.x) > 0x274 )
		    {
		      if ( *(_QWORD *)&wrapperArray[37].fields.m_position.x )
		      {
		        v103 = IFix::WrappersManagerImpl::GetPatch(628, 0LL);
		        if ( !v103 )
		          goto LABEL_77;
		        wrapperArray = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_252(v103, (Object *)this, 0LL);
		        goto LABEL_28;
		      }
		LABEL_27:
		      wrapperArray = this->fields._polyLineShape;
		LABEL_28:
		      if ( wrapperArray )
		      {
		        v10 = triggerPos->z;
		        *(_QWORD *)&v106.x = *(_QWORD *)&triggerPos->x;
		        v106.z = v10;
		        return Beyond::BeyondPolyLineShape::GetDistanceToEdgeInArea(wrapperArray, (Vector3 *)&v106, 0.1, 0LL);
		      }
		LABEL_77:
		      sub_1800D8260(wrapperArray, v6);
		    }
		LABEL_170:
		    sub_1800D2AB0(wrapperArray, v6);
		  }
		  if ( !LODWORD(wrapperArray[1].fields.m_convexPolygons) )
		  {
		    il2cpp_runtime_class_init_1(wrapperArray);
		    wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **(ILFixDynamicMethodWrapper_2__Array ***)&wrapperArray[1].fields.m_height;
		  if ( !v6 )
		    goto LABEL_77;
		  if ( v6->max_length.size <= 628 )
		    goto LABEL_69;
		  if ( !LODWORD(wrapperArray[1].fields.m_convexPolygons) )
		  {
		    il2cpp_runtime_class_init_1(wrapperArray);
		    wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **(ILFixDynamicMethodWrapper_2__Array ***)&wrapperArray[1].fields.m_height;
		  if ( !v6 )
		    goto LABEL_77;
		  if ( v6->max_length.size <= 0x274u )
		    goto LABEL_170;
		  if ( v6[17].vector[16] )
		  {
		    v100 = IFix::WrappersManagerImpl::GetPatch(628, 0LL);
		    if ( !v100 )
		      goto LABEL_77;
		    v101 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_252(v100, (Object *)this, 0LL);
		    wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    v48 = v101;
		  }
		  else
		  {
		LABEL_69:
		    v48 = this->fields._polyLineShape;
		  }
		  if ( !LODWORD(wrapperArray[1].fields.m_convexPolygons) )
		  {
		    il2cpp_runtime_class_init_1(wrapperArray);
		    wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **(ILFixDynamicMethodWrapper_2__Array ***)&wrapperArray[1].fields.m_height;
		  if ( !v6 )
		    goto LABEL_77;
		  if ( v6->max_length.size <= 629 )
		    goto LABEL_74;
		  if ( !LODWORD(wrapperArray[1].fields.m_convexPolygons) )
		  {
		    il2cpp_runtime_class_init_1(wrapperArray);
		    wrapperArray = (BeyondPolyLineShape *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = **(ILFixDynamicMethodWrapper_2__Array ***)&wrapperArray[1].fields.m_height;
		  if ( !v6 )
		    goto LABEL_77;
		  if ( v6->max_length.size <= 0x275u )
		    goto LABEL_170;
		  if ( v6[17].vector[17] )
		  {
		    v102 = IFix::WrappersManagerImpl::GetPatch(629, 0LL);
		    if ( !v102 )
		      goto LABEL_77;
		    blendDistance = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_46(
		                      (ILFixDynamicMethodWrapper_15 *)v102,
		                      (Object *)this,
		                      0LL);
		  }
		  else
		  {
		LABEL_74:
		    blendDistance = this->fields._blendDistance;
		  }
		  if ( !v48 )
		    goto LABEL_77;
		  v50 = triggerPos->z;
		  *(_QWORD *)&v106.x = *(_QWORD *)&triggerPos->x;
		  v106.z = v50;
		  return Beyond::BeyondPolyLineShape::GetDistanceToEdgeInArea(v48, (Vector3 *)&v106, blendDistance, 0LL);
		}
		
		public void __iFixBaseProxy_OnPlay() {} // 0x000000018745BF58-0x000000018745BF60
		// Void <>iFixBaseProxy_OnPlay()
		void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnPlay(VFXSceneDark *this, MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPlayableMonoBase::OnPlay((VFXPlayableMonoBase *)this, 0LL);
		}
		
		public void __iFixBaseProxy_OnStop() {} // 0x0000000186FE0B3C-0x0000000186FE0B44
		// Void <>iFixBaseProxy_OnStop()
		void HG::Rendering::Runtime::VFXSceneDark::__iFixBaseProxy_OnStop(VFXSceneDark *this, MethodInfo *method)
		{
		  HG::Rendering::Runtime::VFXPlayableMonoBase::OnStop((VFXPlayableMonoBase *)this, 0LL);
		}
		
	}
}
