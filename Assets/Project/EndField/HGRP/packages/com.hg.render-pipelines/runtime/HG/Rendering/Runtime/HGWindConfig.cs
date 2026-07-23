using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGWindConfig : IEnvConfig // TypeDefIndex: 37630
	{
		// Fields
		[Range(0f, 30f)]
		[Tooltip("\u5F53\u524D Env \u7684\u5168\u5C40\u98CE\u901F (\u7C73/\u79D2)")]
		public float speed; // 0x00
		[Range(0f, 360f)]
		[Space(10f)]
		[Tooltip("\u6C34\u5E73\u9762\u5185\u7684\u98CE\u5411\uFF0C0 \u4E3A\u6B63\u5317\uFF08z \u8F74\u6B63\u65B9\u5411\uFF09\uFF0C90 \u4E3A\u6B63\u4E1C\uFF08x \u8F74\u6B63\u65B9\u5411\uFF09")]
		public float horizontalDirectionAngle; // 0x04
		[Range(-90f, 90f)]
		[Tooltip("\u5782\u76F4\u65B9\u5411\u98CE\u5411\uFF0C\u8C03\u6574\u8303\u56F4 -90 \u5230 90")]
		public float verticalDirectionAngle; // 0x08
		[HideInInspector]
		public Vector3 direction; // 0x0C
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x18
		public static HGWindConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183B99C20-0x0000000183B99C80 0x00000001831D53B0-0x00000001831D53F0
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGWindConfig::get_active(HGWindConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1414 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x586 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[30]._0.element_class )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1414, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_581(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGWindConfig::set_active(HGWindConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1415, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1415, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_582(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGWindConfig(bool active) : this() {
			speed = default;
			horizontalDirectionAngle = default;
			verticalDirectionAngle = default;
			direction = default;
			m_active = default;
		} // 0x0000000184CD8990-0x0000000184CD89C0
		// HGWindConfig(Boolean)
		void HG::Rendering::Runtime::HGWindConfig::HGWindConfig(HGWindConfig *this, bool active, MethodInfo *method)
		{
		  this->verticalDirectionAngle = 0.0;
		  this->m_active = 0;
		  *(_QWORD *)&this->speed = 1065353216LL;
		  *(_QWORD *)&this->direction.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  this->direction.z = 1.0;
		}
		
		static HGWindConfig() {
			defaultConfig = default;
		} // 0x0000000184CD8930-0x0000000184CD8990
		// HGWindConfig()
		void HG::Rendering::Runtime::HGWindConfig::cctor(MethodInfo *method)
		{
		  HGWindConfig__StaticFields *static_fields; // rcx
		
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGWindConfig->static_fields;
		  *(_OWORD *)&static_fields->defaultConfig.speed = 0x3F800000uLL;
		  *(_QWORD *)&static_fields->defaultConfig.direction.y = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		  *(_DWORD *)&static_fields->defaultConfig.m_active = 0;
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
