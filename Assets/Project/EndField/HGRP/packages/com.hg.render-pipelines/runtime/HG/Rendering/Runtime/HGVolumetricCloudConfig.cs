using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGVolumetricCloudConfig : IEnvConfig // TypeDefIndex: 37627
	{
		// Fields
		[Header("\u663E\u793A\u4F53\u79EF\u4E91")]
		public bool enabled; // 0x00
		[Header("\u7ACB\u5373\u6D88\u5931\uFF08\u5173\u95ED\u4F53\u79EF\u4E91\u65F6\u4E0D\u6DE1\u51FA\uFF09")]
		public bool instantDisappear; // 0x01
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x02
		public static HGVolumetricCloudConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183BB73A0-0x0000000183BB7400 0x00000001831D52F0-0x00000001831D5330
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGVolumetricCloudConfig::get_active(HGVolumetricCloudConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1407 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x57F )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[30]._0.gc_desc )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1407, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_576(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGVolumetricCloudConfig::set_active(
		        HGVolumetricCloudConfig *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1408, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1408, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_577(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGVolumetricCloudConfig(bool active) : this() {
			enabled = default;
			instantDisappear = default;
			m_active = default;
		} // 0x0000000184DA2120-0x0000000184DA2130
		// HGVolumetricCloudConfig(Boolean)
		void HG::Rendering::Runtime::HGVolumetricCloudConfig::HGVolumetricCloudConfig(
		        HGVolumetricCloudConfig *this,
		        bool active,
		        MethodInfo *method)
		{
		  this->m_active = active;
		  *(_WORD *)&this->enabled = 1;
		}
		
		static HGVolumetricCloudConfig() {
			defaultConfig = default;
		} // 0x0000000184D7D8B0-0x0000000184D7D8E0
		// HGVolumetricCloudConfig()
		void HG::Rendering::Runtime::HGVolumetricCloudConfig::cctor(MethodInfo *method)
		{
		  HGVolumetricCloudConfig__StaticFields *static_fields; // rcx
		
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGVolumetricCloudConfig->static_fields;
		  *(_WORD *)&static_fields->defaultConfig.enabled = 1;
		  static_fields->defaultConfig.m_active = 0;
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
