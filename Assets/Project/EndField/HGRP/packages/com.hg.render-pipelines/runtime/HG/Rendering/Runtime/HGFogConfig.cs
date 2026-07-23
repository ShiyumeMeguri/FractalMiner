using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGFogConfig : IEnvConfig // TypeDefIndex: 37600
	{
		// Fields
		[Header("\u542F\u7528\u5927\u6C14\u96FE")]
		public bool enable; // 0x00
		[Header("\u8D77\u59CB\u8DDD\u79BB")]
		[UnclampedRangeExponential(0f, 2000f, 3f)]
		public float startDistance; // 0x04
		[Header("\u8D77\u59CB\u9AD8\u5EA6")]
		[UnclampedRange(-100f, 100f)]
		public float startHeight; // 0x08
		[Header("\u8870\u51CF")]
		[UnclampedRangeExponential(1f, 2000f, 5f)]
		public float fallOffHeight; // 0x0C
		[Header("\u8DDD\u79BB\u8870\u51CF")]
		[UnclampedRangeExponential(0.01f, 1f, 5f)]
		public float fallOffDistance; // 0x10
		[Header("\u6563\u5C04")]
		public UnityEngine.Color mieScattering; // 0x14
		[RangeExponential(0f, 20f, 4f)]
		public float mieScatteringScale; // 0x24
		[Range(0f, 0.6f)]
		public float mieAnisotropy; // 0x28
		public UnityEngine.Color rayleighScattering; // 0x2C
		[RangeExponential(0f, 2f, 4f)]
		public float rayleighScatteringScale; // 0x3C
		public UnityEngine.Color inscatterAmbientColor; // 0x40
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x50
		public static HGFogConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183B708B0-0x0000000183B70910 0x00000001831D4FB0-0x00000001831D4FF0
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGFogConfig::get_active(HGFogConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1364 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x554 )
		    sub_1800D2AB0(v3, method);
		  if ( !*((_QWORD *)&v3[29]._0.byval_arg + 1) )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1364, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_540(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGFogConfig::set_active(HGFogConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1365, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1365, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_541(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGFogConfig(bool active) : this() {
			enable = default;
			startDistance = default;
			startHeight = default;
			fallOffHeight = default;
			fallOffDistance = default;
			mieScattering = default;
			mieScatteringScale = default;
			mieAnisotropy = default;
			rayleighScattering = default;
			rayleighScatteringScale = default;
			inscatterAmbientColor = default;
			m_active = default;
		} // 0x0000000184B48680-0x0000000184B48700
		// HGFogConfig(Boolean)
		void HG::Rendering::Runtime::HGFogConfig::HGFogConfig(HGFogConfig *this, bool active, MethodInfo *method)
		{
		  Vector4 v3; // xmm1
		  __int64 v4; // rdx
		  Vector4 v5; // xmm1
		  __int64 v6; // rdx
		  Quaternion *identity; // rax
		  Quaternion *v8; // rdx
		  Vector4 v9; // [rsp+20h] [rbp-18h] BYREF
		
		  this->m_active = 0;
		  this->enable = 0;
		  *(_QWORD *)&this->startDistance = 1112014848LL;
		  this->fallOffHeight = 50.0;
		  this->fallOffDistance = 1.0;
		  v3 = *UnityEngine::Vector4::get_one(&v9, (MethodInfo *)this);
		  *(_DWORD *)(v4 + 36) = 1065353216;
		  *(_DWORD *)(v4 + 40) = 1058642330;
		  *(Vector4 *)(v4 + 20) = v3;
		  v5 = *UnityEngine::Vector4::get_one(&v9, (MethodInfo *)v4);
		  *(_DWORD *)(v6 + 60) = -1082130432;
		  *(Vector4 *)(v6 + 44) = v5;
		  identity = UnityEngine::Quaternion::get_identity((Quaternion *)&v9, (MethodInfo *)v6);
		  v8[4] = *identity;
		}
		
		static HGFogConfig() {
			defaultConfig = default;
		} // 0x0000000184B485F0-0x0000000184B48680
		// HGFogConfig()
		void HG::Rendering::Runtime::HGFogConfig::cctor(MethodInfo *method)
		{
		  __int128 v1; // xmm1
		  HGFogConfig__StaticFields *static_fields; // rcx
		  int v3; // eax
		  __int128 v4; // xmm0
		  __int128 v5; // xmm1
		  Color inscatterAmbientColor; // xmm0
		  HGFogConfig v7; // [rsp+20h] [rbp-68h] BYREF
		
		  memset(&v7, 0, sizeof(v7));
		  HG::Rendering::Runtime::HGFogConfig::HGFogConfig(&v7, 0, 0LL);
		  v1 = *(_OWORD *)&v7.fallOffDistance;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGFogConfig->static_fields;
		  v3 = *(_DWORD *)&v7.m_active;
		  *(_OWORD *)&static_fields->defaultConfig.enable = *(_OWORD *)&v7.enable;
		  v4 = *(_OWORD *)&v7.mieScattering.a;
		  *(_OWORD *)&static_fields->defaultConfig.fallOffDistance = v1;
		  v5 = *(_OWORD *)&v7.rayleighScattering.g;
		  *(_OWORD *)&static_fields->defaultConfig.mieScattering.a = v4;
		  inscatterAmbientColor = v7.inscatterAmbientColor;
		  *(_OWORD *)&static_fields->defaultConfig.rayleighScattering.g = v5;
		  static_fields->defaultConfig.inscatterAmbientColor = inscatterAmbientColor;
		  *(_DWORD *)&static_fields->defaultConfig.m_active = v3;
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
