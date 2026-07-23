using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGTerrainDeformConfig : IEnvConfig // TypeDefIndex: 37626
	{
		// Fields
		[Header("\u5168\u5C40\u5730\u5F62\u5F62\u53D8\u5F3A\u5EA6")]
		[Range(0f, 1f)]
		public float deformGlobalStrength; // 0x00
		[Header("\u751F\u6548\u5EF6\u8FDF")]
		[Range(0f, 1f)]
		public float latency; // 0x04
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x08
		public static HGTerrainDeformConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183B9CF00-0x0000000183B9CF60 0x00000001831D52B0-0x00000001831D52F0
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGTerrainDeformConfig::get_active(HGTerrainDeformConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1405 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x57D )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[29].vtable.ToString.method )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1405, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_574(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGTerrainDeformConfig::set_active(
		        HGTerrainDeformConfig *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1406, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1406, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_575(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGTerrainDeformConfig(bool active) : this() {
			deformGlobalStrength = default;
			latency = default;
			m_active = default;
		} // 0x0000000184DA2110-0x0000000184DA2120
		// HGTerrainDeformConfig(Boolean)
		void HG::Rendering::Runtime::HGTerrainDeformConfig::HGTerrainDeformConfig(
		        HGTerrainDeformConfig *this,
		        bool active,
		        MethodInfo *method)
		{
		  this->m_active = 0;
		  *(_QWORD *)&this->deformGlobalStrength = 0LL;
		}
		
		static HGTerrainDeformConfig() {
			defaultConfig = default;
		} // 0x0000000184D6CC50-0x0000000184D6CF00
		// HGTerrainDeformConfig()
		void HG::Rendering::Runtime::HGTerrainDeformConfig::cctor(MethodInfo *method)
		{
		  HGTerrainDeformConfig__StaticFields *static_fields; // rcx
		
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGTerrainDeformConfig->static_fields;
		  *(_QWORD *)&static_fields->defaultConfig.deformGlobalStrength = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  *(_DWORD *)&static_fields->defaultConfig.m_active = 0;
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
