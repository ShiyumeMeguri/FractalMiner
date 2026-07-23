using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGAutoExposureConfig : IEnvConfig // TypeDefIndex: 37585
	{
		// Fields
		[Header("\u6A21\u5F0F")]
		public AutoExposureMode autoExposureMode; // 0x00
		[Header("\u624B\u5DE5\u8C03\u6574\u6700\u7EC8EV\uFF08\u81EA\u52A8\u66DD\u5149\u6A21\u5F0F\uFF09")]
		[Range(-8f, 8f)]
		public float autoExposureManualEvCompensationAuto; // 0x04
		[Header("\u63D0\u4EAE\u901F\u5EA6")]
		[Range(0.01f, 20f)]
		public float autoExposureLerpUpSpeed; // 0x08
		[Header("\u538B\u6697\u901F\u5EA6")]
		[Range(0.01f, 20f)]
		public float autoExposureLerpDownSpeed; // 0x0C
		[Header("\u6D4B\u5149\u8868\u7684EV\u503C\u8303\u56F4\uFF08\u8D85\u51FA\u8303\u56F4\u5219clamp\uFF09")]
		[HideInInspector]
		public Vector2 autoExposureEv100Range; // 0x10
		[Header("\u9650\u5236\u8F93\u5165\u50CF\u7D20\u7684EV\u503C\u8303\u56F4")]
		public Vector2 autoExposureEv100HistogramRange; // 0x18
		[Header("\u6D4B\u5149\u6A21\u5F0F")]
		public AutoExposureMeteringMode autoExposureMeteringMode; // 0x20
		[Header("\u4EAE\u5EA6\u8F93\u5165\u8303\u56F4")]
		[HideInInspector]
		public Vector2 autoExposurePixelLuminanceRange; // 0x24
		[Header("\u81EA\u52A8\u66DD\u5149\u8865\u507F\u503C\u8C03\u6574\u8303\u56F4")]
		public Vector2 autoExposureEvClampRange; // 0x2C
		[Header("\u624B\u5DE5\u8C03\u6574\u6700\u7EC8EV\uFF08\u624B\u52A8\u66DD\u5149\u6A21\u5F0F\uFF09")]
		[Range(-8f, 8f)]
		public float autoExposureManualEvCompensationManual; // 0x34
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x38
		public static HGAutoExposureConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183B5C6B0-0x0000000183B5C710 0x00000001831D4EB0-0x00000001831D4EF0
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGAutoExposureConfig::get_active(HGAutoExposureConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1325 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x52D )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[28]._0.typeMetadataHandle )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1325, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_381(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGAutoExposureConfig::set_active(
		        HGAutoExposureConfig *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1326, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1326, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_513(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGAutoExposureConfig(bool active) : this() {
			autoExposureMode = default;
			autoExposureManualEvCompensationAuto = default;
			autoExposureLerpUpSpeed = default;
			autoExposureLerpDownSpeed = default;
			autoExposureEv100Range = default;
			autoExposureEv100HistogramRange = default;
			autoExposureMeteringMode = default;
			autoExposurePixelLuminanceRange = default;
			autoExposureEvClampRange = default;
			autoExposureManualEvCompensationManual = default;
			m_active = default;
		} // 0x0000000184CC8470-0x0000000184CC84D0
		// HGAutoExposureConfig(Boolean)
		void HG::Rendering::Runtime::HGAutoExposureConfig::HGAutoExposureConfig(
		        HGAutoExposureConfig *this,
		        bool active,
		        MethodInfo *method)
		{
		  this->m_active = 0;
		  *(_QWORD *)&this->autoExposureMode = 0LL;
		  this->autoExposureLerpUpSpeed = 0.60000002;
		  this->autoExposureLerpDownSpeed = 0.60000002;
		  this->autoExposureEv100Range.x = -8.0;
		  this->autoExposureEv100Range.y = 4.0;
		  this->autoExposureEv100HistogramRange.x = -8.0;
		  *(_QWORD *)&this->autoExposureEv100HistogramRange.y = 1082130432LL;
		  this->autoExposurePixelLuminanceRange.x = 0.050000001;
		  this->autoExposurePixelLuminanceRange.y = 0.94999999;
		  this->autoExposureEvClampRange.x = -4.0;
		  *(_QWORD *)&this->autoExposureEvClampRange.y = 1082130432LL;
		}
		
		static HGAutoExposureConfig() {
			defaultConfig = default;
		} // 0x0000000184CC8400-0x0000000184CC8470
		// HGAutoExposureConfig()
		void HG::Rendering::Runtime::HGAutoExposureConfig::cctor(MethodInfo *method)
		{
		  __int128 v1; // xmm1
		  HGAutoExposureConfig__StaticFields *static_fields; // rcx
		  int v3; // eax
		  __int128 v4; // xmm0
		  HGAutoExposureConfig v5; // [rsp+20h] [rbp-48h] BYREF
		
		  memset(&v5, 0, sizeof(v5));
		  HG::Rendering::Runtime::HGAutoExposureConfig::HGAutoExposureConfig(&v5, 0, 0LL);
		  v1 = *(_OWORD *)&v5.autoExposureEv100Range.x;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGAutoExposureConfig->static_fields;
		  v3 = *(_DWORD *)&v5.m_active;
		  *(_OWORD *)&static_fields->defaultConfig.autoExposureMode = *(_OWORD *)&v5.autoExposureMode;
		  v4 = *(_OWORD *)&v5.autoExposureMeteringMode;
		  *(_OWORD *)&static_fields->defaultConfig.autoExposureEv100Range.x = v1;
		  *(_QWORD *)&v1 = *(_QWORD *)&v5.autoExposureEvClampRange.y;
		  *(_OWORD *)&static_fields->defaultConfig.autoExposureMeteringMode = v4;
		  *(_QWORD *)&static_fields->defaultConfig.autoExposureEvClampRange.y = v1;
		  *(_DWORD *)&static_fields->defaultConfig.m_active = v3;
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
		public bool IsActive() => default; // 0x0000000183EC9540-0x0000000183EC95A0
		// Boolean IsActive()
		bool HG::Rendering::Runtime::HGAutoExposureConfig::IsActive(HGAutoExposureConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 968 )
		    return 1;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x3C8 )
		    sub_1800D2AB0(v3, method);
		  if ( !*(_QWORD *)&v3[20]._1.element_size )
		    return 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(968, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_381(Patch, this, 0LL);
		}
		
	}
}
