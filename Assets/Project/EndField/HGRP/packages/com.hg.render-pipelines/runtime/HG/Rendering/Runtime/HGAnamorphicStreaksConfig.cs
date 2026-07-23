using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGAnamorphicStreaksConfig : IEnvConfig // TypeDefIndex: 37583
	{
		// Fields
		[Header("\u542F\u7528\u6761\u72B6\u6CDB\u5149")]
		public bool enable; // 0x00
		[Header("\u6CDB\u5149\u5F3A\u5EA6")]
		[Range(0f, 10f)]
		public float bloomScale; // 0x04
		[Header("\u6CDB\u5149\u9608\u503C")]
		[Min(0f)]
		public float bloomThreshold; // 0x08
		[Header("\u6CDB\u5149\u6700\u9AD8\u4EAE\u5EA6")]
		[Range(0f, 100f)]
		public float bloomMaxBrightness; // 0x0C
		[ColorUsage(false, true)]
		[Header("\u6CDB\u5149\u8272\u8C03")]
		public UnityEngine.Color bloomTint; // 0x10
		[Header("\u6CDB\u5149\u6269\u6563\u7A0B\u5EA6")]
		[Range(0f, 1f)]
		public float blurIntensity; // 0x20
		[Header("\u6CDB\u5149\u65B9\u5411")]
		[Range(0f, 180f)]
		public float blurDirAngle; // 0x24
		[Header("\u8FC7\u6EE4\u50CF\u7D20\u5927\u5C0F")]
		public AnamorphicStreaksFilterSize filterSize; // 0x28
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x2C
		public static HGAnamorphicStreaksConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183BB5A50-0x0000000183BB5B50 0x00000001831D4E30-0x00000001831D4E70
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGAnamorphicStreaksConfig::get_active(HGAnamorphicStreaksConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1320 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x528 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[28]._0.element_class )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1320, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_508(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGAnamorphicStreaksConfig::set_active(
		        HGAnamorphicStreaksConfig *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1321, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1321, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_509(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGAnamorphicStreaksConfig(bool active) : this() {
			enable = default;
			bloomScale = default;
			bloomThreshold = default;
			bloomMaxBrightness = default;
			bloomTint = default;
			blurIntensity = default;
			blurDirAngle = default;
			filterSize = default;
			m_active = default;
		} // 0x0000000184CE1C60-0x0000000184CE1CB0
		// HGAnamorphicStreaksConfig(Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGAnamorphicStreaksConfig::HGAnamorphicStreaksConfig(
		        HGAnamorphicStreaksConfig *this,
		        bool active,
		        MethodInfo *method)
		{
		  Vector4 v3; // xmm1
		  __int64 v4; // r8
		  Vector4 v5; // [rsp+20h] [rbp-18h] BYREF
		
		  this->m_active = active;
		  this->enable = 0;
		  this->bloomScale = 1.0;
		  this->bloomThreshold = 4.0;
		  this->bloomMaxBrightness = 100.0;
		  v3 = *UnityEngine::Vector4::get_one(&v5, (MethodInfo *)active);
		  *(_QWORD *)(v4 + 32) = 1060320051LL;
		  *(_DWORD *)(v4 + 40) = 0;
		  *(Vector4 *)(v4 + 16) = v3;
		}
		
		static HGAnamorphicStreaksConfig() {
			defaultConfig = default;
		} // 0x0000000184CE1BF0-0x0000000184CE1C60
		// HGAnamorphicStreaksConfig()
		void HG::Rendering::Runtime::HGAnamorphicStreaksConfig::cctor(MethodInfo *method)
		{
		  MethodInfo *v1; // rdx
		  Vector4 *one; // rax
		  Vector4 v3; // xmm2
		  HGAnamorphicStreaksConfig__StaticFields *static_fields; // rcx
		  __int128 v5; // xmm0
		  Vector4 v6; // [rsp+20h] [rbp-48h] BYREF
		  __int128 v7; // [rsp+30h] [rbp-38h]
		  __int128 v8; // [rsp+50h] [rbp-18h]
		
		  *(_QWORD *)&v7 = 0x3F80000000000000LL;
		  *((_QWORD *)&v7 + 1) = 0x42C8000040800000LL;
		  v8 = 0LL;
		  one = UnityEngine::Vector4::get_one(&v6, v1);
		  *(_QWORD *)&v8 = 1060320051LL;
		  DWORD2(v8) = 0;
		  v3 = *one;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGAnamorphicStreaksConfig->static_fields;
		  *(_OWORD *)&static_fields->defaultConfig.enable = v7;
		  v5 = v8;
		  static_fields->defaultConfig.bloomTint = (Color)v3;
		  *(_OWORD *)&static_fields->defaultConfig.blurIntensity = v5;
		}
		
	
		// Methods
		public Vector2 GetBlurDir() => default; // 0x0000000189C6D980-0x0000000189C6DA04
		// Vector2 GetBlurDir()
		Vector2 HG::Rendering::Runtime::HGAnamorphicStreaksConfig::GetBlurDir(
		        HGAnamorphicStreaksConfig *this,
		        MethodInfo *method)
		{
		  float v2; // xmm1_4
		  Beyond::DampingMath *v4; // rcx
		  __m128 blurDirAngle_low; // xmm7
		  Beyond::DampingMath *v6; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1322, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1322, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_510(Patch, this, 0LL);
		  }
		  else
		  {
		    blurDirAngle_low = (__m128)LODWORD(this->blurDirAngle);
		    blurDirAngle_low.m128_f32[0] = blurDirAngle_low.m128_f32[0] * 0.017453292;
		    Beyond::DampingMath::cosf(v4, v2);
		    Beyond::DampingMath::sinf(v6, v2);
		    return (Vector2)_mm_unpacklo_ps(blurDirAngle_low, blurDirAngle_low).m128_u64[0];
		  }
		}
		
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
