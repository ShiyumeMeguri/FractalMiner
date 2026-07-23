using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGWaterEnvConfig : IEnvConfig // TypeDefIndex: 37629
	{
		// Fields
		[Header("\u5F00\u542Fenv\u6C34\u6CE2\u4EA4\u4E92\u5F71\u54CD")]
		public bool enableWaterInteractionAdjust; // 0x00
		[Header("\u6C34\u6CE2\u4EA4\u4E92\u5F3A\u5EA6Multiplier")]
		[UnclampedRange(0f, 5f)]
		public float waterInteractionStrengthMultiplier; // 0x04
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x08
		public static HGWaterEnvConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183BB68F0-0x0000000183BB6950 0x00000001831D5370-0x00000001831D53B0
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGWaterEnvConfig::get_active(HGWaterEnvConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1412 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x584 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[30]._0.this_arg.data.dummy )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1412, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_579(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGWaterEnvConfig::set_active(HGWaterEnvConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1413, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1413, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_580(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGWaterEnvConfig(bool active) : this() {
			enableWaterInteractionAdjust = default;
			waterInteractionStrengthMultiplier = default;
			m_active = default;
		} // 0x0000000184DA2130-0x0000000184DA2140
		// HGWaterEnvConfig(Boolean)
		void HG::Rendering::Runtime::HGWaterEnvConfig::HGWaterEnvConfig(
		        HGWaterEnvConfig *this,
		        bool active,
		        MethodInfo *method)
		{
		  this->m_active = active;
		  this->enableWaterInteractionAdjust = 0;
		  this->waterInteractionStrengthMultiplier = 1.0;
		}
		
		static HGWaterEnvConfig() {
			defaultConfig = default;
		} // 0x0000000184D5EAA0-0x0000000184D5EAE0
		// HGWaterEnvConfig()
		void HG::Rendering::Runtime::HGWaterEnvConfig::cctor(MethodInfo *method)
		{
		  HGWaterEnvConfig__StaticFields *static_fields; // rcx
		
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGWaterEnvConfig->static_fields;
		  *(_QWORD *)&static_fields->defaultConfig.enableWaterInteractionAdjust = 0x3F80000000000000LL;
		  *(_DWORD *)&static_fields->defaultConfig.m_active = 0;
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
