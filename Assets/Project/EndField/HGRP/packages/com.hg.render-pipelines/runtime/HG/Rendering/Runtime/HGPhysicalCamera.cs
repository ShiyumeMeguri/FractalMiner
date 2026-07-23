using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGPhysicalCamera // TypeDefIndex: 38079
	{
		// Fields
		public const float kMinAperture = 0.7f; // Metadata: 0x02303882
		public const float kMaxAperture = 32f; // Metadata: 0x02303886
		public const int kMinBladeCount = 3; // Metadata: 0x0230388A
		public const int kMaxBladeCount = 11; // Metadata: 0x0230388B
		[Min(1f)]
		[SerializeField]
		private int m_Iso; // 0x00
		[Min(0f)]
		[SerializeField]
		private float m_ShutterSpeed; // 0x04
		[Range(0.7f, 32f)]
		[SerializeField]
		private float m_Aperture; // 0x08
		[Min(0.1f)]
		[SerializeField]
		private float m_FocusDistance; // 0x0C
		[Range(3f, 11f)]
		[SerializeField]
		private int m_BladeCount; // 0x10
		[SerializeField]
		private Vector2 m_Curvature; // 0x14
		[Range(0f, 1f)]
		[SerializeField]
		private float m_BarrelClipping; // 0x1C
		[Range(-1f, 1f)]
		[SerializeField]
		private float m_Anamorphism; // 0x20
	
		// Properties
		public float focusDistance { get => default; set {} } // 0x0000000189B74D2C-0x0000000189B74D7C 0x00000001837DB940-0x00000001837DB980
		// Single get_focusDistance()
		float HG::Rendering::Runtime::HGPhysicalCamera::get_focusDistance(HGPhysicalCamera *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1111, 0LL) )
		    return this->m_FocusDistance;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1111, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_407(Patch, this, 0LL);
		}
		

		// Void set_focusDistance(Single)
		void HG::Rendering::Runtime::HGPhysicalCamera::set_focusDistance(
		        HGPhysicalCamera *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(724, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(724, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_FocusDistance = fmaxf(value, 0.1);
		  }
		}
		
		public int iso { get => default; set {} } // 0x0000000189B74D7C-0x0000000189B74DC8 0x00000001837DB900-0x00000001837DB940
		// Int32 get_iso()
		int32_t HG::Rendering::Runtime::HGPhysicalCamera::get_iso(HGPhysicalCamera *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2755, 0LL) )
		    return this->m_Iso;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2755, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1006(Patch, this, 0LL);
		}
		

		// Void set_iso(Int32)
		void HG::Rendering::Runtime::HGPhysicalCamera::set_iso(HGPhysicalCamera *this, int32_t value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(721, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(721, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_286(Patch, this, value, 0LL);
		  }
		  else
		  {
		    if ( value <= 1 )
		      value = 1;
		    this->m_Iso = value;
		  }
		}
		
		public float shutterSpeed { get => default; set {} } // 0x0000000189B74DC8-0x0000000189B74E18 0x00000001837DB8C0-0x00000001837DB900
		// Single get_shutterSpeed()
		float HG::Rendering::Runtime::HGPhysicalCamera::get_shutterSpeed(HGPhysicalCamera *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2756, 0LL) )
		    return this->m_ShutterSpeed;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2756, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_407(Patch, this, 0LL);
		}
		

		// Void set_shutterSpeed(Single)
		void HG::Rendering::Runtime::HGPhysicalCamera::set_shutterSpeed(
		        HGPhysicalCamera *this,
		        float value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(722, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(722, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_ShutterSpeed = fmaxf(value, 0.0);
		  }
		}
		
		public float aperture { get => default; set {} } // 0x0000000189B74BE4-0x0000000189B74C34 0x00000001837DBAA0-0x00000001837DBB00
		// Single get_aperture()
		float HG::Rendering::Runtime::HGPhysicalCamera::get_aperture(HGPhysicalCamera *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1112, 0LL) )
		    return this->m_Aperture;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1112, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_407(Patch, this, 0LL);
		}
		

		// Void set_aperture(Single)
		void HG::Rendering::Runtime::HGPhysicalCamera::set_aperture(HGPhysicalCamera *this, float value, MethodInfo *method)
		{
		  float v4; // xmm6_4
		  int v5; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  v4 = value;
		  if ( IFix::WrappersManagerImpl::IsPatched(723, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(723, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(Patch, this, value, 0LL);
		  }
		  else
		  {
		    v5 = 1060320051;
		    if ( value < 0.69999999 || (v5 = 1107296256, value > 32.0) )
		      v4 = *(float *)&v5;
		    this->m_Aperture = v4;
		  }
		}
		
		public int bladeCount { get => default; set {} } // 0x0000000189B74C84-0x0000000189B74CD0 0x00000001837DBA40-0x00000001837DBAA0
		// Int32 get_bladeCount()
		int32_t HG::Rendering::Runtime::HGPhysicalCamera::get_bladeCount(HGPhysicalCamera *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2757, 0LL) )
		    return this->m_BladeCount;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2757, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1006(Patch, this, 0LL);
		}
		

		// Void set_bladeCount(Int32)
		void HG::Rendering::Runtime::HGPhysicalCamera::set_bladeCount(
		        HGPhysicalCamera *this,
		        int32_t value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(725, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(725, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_286(Patch, this, value, 0LL);
		  }
		  else
		  {
		    if ( value < 3 )
		    {
		      value = 3;
		      goto LABEL_4;
		    }
		    if ( value <= 11 )
		    {
		LABEL_4:
		      this->m_BladeCount = value;
		      return;
		    }
		    this->m_BladeCount = 11;
		  }
		}
		
		public Vector2 curvature { get => default; set {} } // 0x0000000189B74CD0-0x0000000189B74D2C 0x00000001837DB9E0-0x00000001837DBA40
		// Vector2 get_curvature()
		Vector2 HG::Rendering::Runtime::HGPhysicalCamera::get_curvature(HGPhysicalCamera *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2758, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(this->m_Curvature.x), (__m128)LODWORD(this->m_Curvature.y)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(2758, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1007(Patch, this, 0LL);
		}
		

		// Void set_curvature(Vector2)
		void HG::Rendering::Runtime::HGPhysicalCamera::set_curvature(HGPhysicalCamera *this, Vector2 value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(726, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(726, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_288(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_Curvature.x = fmaxf(value.x, 0.69999999);
		    this->m_Curvature.y = fminf(value.y, 32.0);
		  }
		}
		
		public float barrelClipping { get => default; set {} } // 0x0000000189B74C34-0x0000000189B74C84 0x00000001837DB880-0x00000001837DB8C0
		// Single get_barrelClipping()
		float HG::Rendering::Runtime::HGPhysicalCamera::get_barrelClipping(HGPhysicalCamera *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2759, 0LL) )
		    return this->m_BarrelClipping;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2759, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_407(Patch, this, 0LL);
		}
		

		// Void set_barrelClipping(Single)
		void HG::Rendering::Runtime::HGPhysicalCamera::set_barrelClipping(
		        HGPhysicalCamera *this,
		        float value,
		        MethodInfo *method)
		{
		  Beyond::JobMathf *v4; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(727, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(727, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(Patch, this, value, 0LL);
		  }
		  else
		  {
		    Beyond::JobMathf::Clamp01(v4, value);
		    this->m_BarrelClipping = value;
		  }
		}
		
		public float anamorphism { get => default; set {} } // 0x0000000183DF2F90-0x0000000183DF2FF0 0x00000001837DB980-0x00000001837DB9E0
		// Single get_anamorphism()
		float HG::Rendering::Runtime::HGPhysicalCamera::get_anamorphism(HGPhysicalCamera *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1059 )
		    return this->m_Anamorphism;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x423 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[22]._1.cctor_thread )
		    return this->m_Anamorphism;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1059, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, wrapperArray);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_407(Patch, this, 0LL);
		}
		

		// Void set_anamorphism(Single)
		void HG::Rendering::Runtime::HGPhysicalCamera::set_anamorphism(HGPhysicalCamera *this, float value, MethodInfo *method)
		{
		  float v4; // xmm6_4
		  int v5; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  v4 = value;
		  if ( IFix::WrappersManagerImpl::IsPatched(728, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(728, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(Patch, this, value, 0LL);
		  }
		  else
		  {
		    v5 = -1082130432;
		    if ( value < -1.0 || (v5 = 1065353216, value > 1.0) )
		      v4 = *(float *)&v5;
		    this->m_Anamorphism = v4;
		  }
		}
		
	
		// Methods
		[Obsolete("The CopyTo method is obsolete and does not work anymore. Use the assignement operator instead to get a copy of the HGPhysicalCamera parameters.", true)]
		public void CopyTo(HGPhysicalCamera c) {} // 0x0000000189B74B74-0x0000000189B74BE4
		// Void CopyTo(HGPhysicalCamera)
		void HG::Rendering::Runtime::HGPhysicalCamera::CopyTo(HGPhysicalCamera *this, HGPhysicalCamera *c, MethodInfo *method)
		{
		  __int64 v5; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float m_Anamorphism; // eax
		  __int128 v8; // xmm1
		  HGPhysicalCamera v9; // [rsp+20h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2760, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2760, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v5);
		    m_Anamorphism = c->m_Anamorphism;
		    v8 = *(_OWORD *)&c->m_BladeCount;
		    *(_OWORD *)&v9.m_Iso = *(_OWORD *)&c->m_Iso;
		    *(_OWORD *)&v9.m_BladeCount = v8;
		    v9.m_Anamorphism = m_Anamorphism;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1008(Patch, this, &v9, 0LL);
		  }
		}
		
		public static HGPhysicalCamera GetDefaults() => default; // 0x00000001837DB2C0-0x00000001837DB7E0
		// HGPhysicalCamera GetDefaults()
		HGPhysicalCamera *HG::Rendering::Runtime::HGPhysicalCamera::GetDefaults(
		        HGPhysicalCamera *__return_ptr retstr,
		        MethodInfo *method)
		{
		  Beyond::JobMathf *v3; // rcx
		  __int128 v4; // xmm0
		  float m_Anamorphism; // eax
		  __int128 v6; // xmm1
		  ILFixDynamicMethodWrapper_2 *v8; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  ILFixDynamicMethodWrapper_2 *v11; // rax
		  ILFixDynamicMethodWrapper_2 *v12; // rax
		  ILFixDynamicMethodWrapper_2 *v13; // rax
		  ILFixDynamicMethodWrapper_2 *v14; // rax
		  ILFixDynamicMethodWrapper_2 *v15; // rax
		  ILFixDynamicMethodWrapper_2 *v16; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGPhysicalCamera *v18; // rax
		  HGPhysicalCamera P0; // [rsp+20h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(720, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(720, 0LL);
		    if ( Patch )
		    {
		      v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_289(&P0, Patch, 0LL);
		      v4 = *(_OWORD *)&v18->m_Iso;
		      v6 = *(_OWORD *)&v18->m_BladeCount;
		      m_Anamorphism = v18->m_Anamorphism;
		      goto LABEL_17;
		    }
		    goto LABEL_34;
		  }
		  memset(&P0, 0, sizeof(P0));
		  if ( IFix::WrappersManagerImpl::IsPatched(721, 0LL) )
		  {
		    v8 = IFix::WrappersManagerImpl::GetPatch(721, 0LL);
		    if ( !v8 )
		      goto LABEL_34;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_286(v8, &P0, 200, 0LL);
		  }
		  else
		  {
		    P0.m_Iso = 200;
		  }
		  if ( IFix::WrappersManagerImpl::IsPatched(722, 0LL) )
		  {
		    v11 = IFix::WrappersManagerImpl::GetPatch(722, 0LL);
		    if ( !v11 )
		      goto LABEL_34;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(v11, &P0, 0.0049999999, 0LL);
		  }
		  else
		  {
		    P0.m_ShutterSpeed = 0.0049999999;
		  }
		  if ( IFix::WrappersManagerImpl::IsPatched(723, 0LL) )
		  {
		    v12 = IFix::WrappersManagerImpl::GetPatch(723, 0LL);
		    if ( !v12 )
		      goto LABEL_34;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(v12, &P0, 16.0, 0LL);
		  }
		  else
		  {
		    P0.m_Aperture = 16.0;
		  }
		  if ( IFix::WrappersManagerImpl::IsPatched(724, 0LL) )
		  {
		    v13 = IFix::WrappersManagerImpl::GetPatch(724, 0LL);
		    if ( !v13 )
		      goto LABEL_34;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(v13, &P0, 10.0, 0LL);
		  }
		  else
		  {
		    P0.m_FocusDistance = 10.0;
		  }
		  if ( IFix::WrappersManagerImpl::IsPatched(725, 0LL) )
		  {
		    v14 = IFix::WrappersManagerImpl::GetPatch(725, 0LL);
		    if ( !v14 )
		      goto LABEL_34;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_286(v14, &P0, 5, 0LL);
		  }
		  else
		  {
		    P0.m_BladeCount = 5;
		  }
		  HG::Rendering::Runtime::HGPhysicalCamera::set_curvature(
		    &P0,
		    (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x40000000u, (__m128)0x41300000u),
		    0LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(727, 0LL) )
		  {
		    v15 = IFix::WrappersManagerImpl::GetPatch(727, 0LL);
		    if ( !v15 )
		      goto LABEL_34;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(v15, &P0, 0.25, 0LL);
		  }
		  else
		  {
		    Beyond::JobMathf::Clamp01(v3, 11.0);
		    P0.m_BarrelClipping = 0.25;
		  }
		  if ( IFix::WrappersManagerImpl::IsPatched(728, 0LL) )
		  {
		    v16 = IFix::WrappersManagerImpl::GetPatch(728, 0LL);
		    if ( v16 )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(v16, &P0, 0.0, 0LL);
		      goto LABEL_16;
		    }
		LABEL_34:
		    sub_1800D8260(v10, v9);
		  }
		  P0.m_Anamorphism = 0.0;
		LABEL_16:
		  v4 = *(_OWORD *)&P0.m_Iso;
		  m_Anamorphism = P0.m_Anamorphism;
		  v6 = *(_OWORD *)&P0.m_BladeCount;
		LABEL_17:
		  *(_OWORD *)&retstr->m_Iso = v4;
		  *(_OWORD *)&retstr->m_BladeCount = v6;
		  retstr->m_Anamorphism = m_Anamorphism;
		  return retstr;
		}
		
	}
}
