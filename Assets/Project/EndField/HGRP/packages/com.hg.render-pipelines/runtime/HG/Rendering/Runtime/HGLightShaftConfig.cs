using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGLightShaftConfig : IEnvConfig // TypeDefIndex: 37615
	{
		// Fields
		[Header("\u542F\u7528\u5149\u675F\u6CDB\u5149")]
		public bool enable; // 0x00
		[Header("\u6CDB\u5149\u5F3A\u5EA6")]
		[Range(0f, 10f)]
		public float bloomScale; // 0x04
		[Header("\u6CDB\u5149\u9608\u503C")]
		[Range(0f, 4f)]
		public float bloomThreshold; // 0x08
		[Header("\u6CDB\u5149\u6700\u9AD8\u4EAE\u5EA6")]
		[RangeExponential(0f, 100f, 5f)]
		public float bloomMaxBrightness; // 0x0C
		[Header("\u6CDB\u5149\u8272\u8C03")]
		public UnityEngine.Color bloomTint; // 0x10
		[Header("\u6CDB\u5149\u6269\u6563\u7A0B\u5EA6")]
		[Range(0f, 1f)]
		public float blurIntensity; // 0x20
		[Header("\u6CDB\u5149\u906E\u6321\u6DF1\u5EA6\u8303\u56F4")]
		[Range(0f, 5000f)]
		public float occlusionDepthRange; // 0x24
		[Header("\u542F\u7528\u5149\u675F\u906E\u853D")]
		public bool enableOcclusion; // 0x28
		[Header("\u906E\u853D\u906E\u7F69\u6697\u5EA6")]
		[Range(0f, 1f)]
		public float occlusionMaskDarkness; // 0x2C
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x30
		public static HGLightShaftConfig defaultConfig; // 0x00
	
		// Properties
		public bool lightShaftOcclusionActive { get => default; } // 0x0000000189CE4324-0x0000000189CE437C 
		// Boolean get_lightShaftOcclusionActive()
		bool HG::Rendering::Runtime::HGLightShaftConfig::get_lightShaftOcclusionActive(
		        HGLightShaftConfig *this,
		        MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  result = IFix::WrappersManagerImpl::IsPatched(1388, 0LL);
		  if ( result )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1388, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_562(Patch, this, 0LL);
		  }
		  else if ( this->enable )
		  {
		    return this->enableOcclusion;
		  }
		  return result;
		}
		
		public bool active { get => default; set {} } // 0x0000000183B835B0-0x0000000183B83650 0x00000001831D5130-0x00000001831D5170
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGLightShaftConfig::get_active(HGLightShaftConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1389 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x56D )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[29]._1.genericContainerHandle )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1389, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_562(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGLightShaftConfig::set_active(HGLightShaftConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1390, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1390, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_563(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGLightShaftConfig(bool active) : this() {
			enable = default;
			bloomScale = default;
			bloomThreshold = default;
			bloomMaxBrightness = default;
			bloomTint = default;
			blurIntensity = default;
			occlusionDepthRange = default;
			enableOcclusion = default;
			occlusionMaskDarkness = default;
			m_active = default;
		} // 0x0000000184CCFB40-0x0000000184CCFB90
		// HGLightShaftConfig(Boolean)
		void HG::Rendering::Runtime::HGLightShaftConfig::HGLightShaftConfig(
		        HGLightShaftConfig *this,
		        bool active,
		        MethodInfo *method)
		{
		  Vector4 v3; // xmm1
		  __int64 v4; // rdx
		  Vector4 v5; // [rsp+20h] [rbp-18h] BYREF
		
		  this->m_active = 0;
		  this->enable = 0;
		  *(_QWORD *)&this->bloomScale = 1045220557LL;
		  this->bloomMaxBrightness = 100.0;
		  v3 = *UnityEngine::Vector4::get_one(&v5, (MethodInfo *)this);
		  *(_DWORD *)(v4 + 32) = 1061997773;
		  *(_DWORD *)(v4 + 36) = 1148846080;
		  *(Vector4 *)(v4 + 16) = v3;
		  *(_BYTE *)(v4 + 40) = 0;
		  *(_DWORD *)(v4 + 44) = 1028443341;
		}
		
		static HGLightShaftConfig() {
			defaultConfig = default;
		} // 0x0000000184CCFAC0-0x0000000184CCFB40
		// HGLightShaftConfig()
		void HG::Rendering::Runtime::HGLightShaftConfig::cctor(MethodInfo *method)
		{
		  Vector4 *one; // rax
		  Vector4 v2; // xmm2
		  int v3; // edx
		  HGLightShaftConfig__StaticFields *static_fields; // rcx
		  __int128 v5; // xmm0
		  Vector4 v6; // [rsp+20h] [rbp-58h] BYREF
		  __int128 v7; // [rsp+30h] [rbp-48h]
		  __int128 v8; // [rsp+50h] [rbp-28h]
		
		  LODWORD(v7) = 0;
		  *(_QWORD *)((char *)&v7 + 4) = 1045220557LL;
		  HIDWORD(v7) = 1120403456;
		  v8 = 0LL;
		  one = UnityEngine::Vector4::get_one(&v6, 0LL);
		  *(_QWORD *)&v8 = 0x447A00003F4CCCCDLL;
		  v2 = *one;
		  BYTE8(v8) = v3;
		  HIDWORD(v8) = 1028443341;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGLightShaftConfig->static_fields;
		  *(_OWORD *)&static_fields->defaultConfig.enable = v7;
		  v5 = v8;
		  static_fields->defaultConfig.bloomTint = (Color)v2;
		  *(_OWORD *)&static_fields->defaultConfig.blurIntensity = v5;
		  *(_DWORD *)&static_fields->defaultConfig.m_active = v3;
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
