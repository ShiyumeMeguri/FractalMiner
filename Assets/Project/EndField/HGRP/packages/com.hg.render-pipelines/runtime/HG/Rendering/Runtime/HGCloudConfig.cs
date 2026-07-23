using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGCloudConfig : IEnvConfig // TypeDefIndex: 37597
	{
		// Fields
		[Header("\u542F\u7528\u4E91")]
		public bool enable; // 0x00
		[Header("\u4E91\u7684\u8D34\u56FE")]
		public Texture cloudTexture; // 0x08
		[Header("\u989C\u8272")]
		public UnityEngine.Color cloudTint; // 0x10
		[Header("\u5BF9\u6BD4\u5EA6")]
		[UnclampedRange(-1f, 2f)]
		public float cloudContrast; // 0x20
		[Header("\u5149\u7167\u662F\u5426\u5F71\u54CD\u4E91\u7684\u4EAE\u5EA6")]
		public bool lightAffectCloud; // 0x24
		[Header("\u4E91\u7684\u4EAE\u5EA6\u8865\u507F")]
		[UnclampedRange(-5f, 5f)]
		public float cloudBrightness; // 0x28
		[Header("\u4E91\u7684\u4EAE\u5EA6")]
		[UnclampedRangeExponential(-5f, 5f, 2f)]
		public float cloudAbsoluteBrightness; // 0x2C
		[Header("\u4EAE\u5EA6\u662F\u5426\u5F71\u54CDAlpha")]
		public bool brightnessAffectCloudAlpha; // 0x30
		[Header("\u662F\u5426\u5728\u661F\u7403\u4E4B\u540E\u5355\u72EC\u7ED8\u5236")]
		public bool drawCloudAfterPlanet; // 0x31
		[Header("\u4E91\u7684\u8D34\u56FE\u6A21\u5F0F")]
		public CloudTextureMode cloudTextureMode; // 0x34
		[Header("R\u901A\u9053\u900F\u660E\u5EA6")]
		[Range(0f, 1f)]
		public float cloudOpacityR; // 0x38
		[Header("G\u901A\u9053\u900F\u660E\u5EA6")]
		[Range(0f, 1f)]
		public float cloudOpacityG; // 0x3C
		[Header("\u4E91\u7684\u8FD0\u52A8\u65B9\u5F0F")]
		public CloudFlowType cloudFlowType; // 0x40
		[Header("\u65CB\u8F6C\u89D2\u5EA6")]
		[Range(0f, 360f)]
		public int rotation; // 0x44
		[Header("\u4E91\u7684FlowMap")]
		public Texture cloudFlowMap; // 0x48
		[Header("\u79FB\u52A8\u901F\u5EA6")]
		[Range(-1f, 1f)]
		public float flowSpeed; // 0x50
		[Header("X\u8F74\u8FD0\u52A8\u65B9\u5411")]
		[Range(-1f, 1f)]
		public float flowDirectionX; // 0x54
		[Header("Y\u8F74\u8FD0\u52A8\u65B9\u5411")]
		[Range(-1f, 1f)]
		public float flowDirectionY; // 0x58
		[Header("\u4E91\u9699\u5149\u906E\u853D\u5C4F\u5E55\u5149\u675F")]
		public bool enableLightShaftCloudMask; // 0x5C
		[Header("\u906E\u853D\u8D34\u56FE")]
		public Texture lightShaftCloudMaskTexture; // 0x60
		[Header("\u542F\u7528\u4E91\u5F71")]
		public bool enableCloudShadow; // 0x68
		public HGCloudShadowConfig cloudShadowConfig; // 0x70
		[HideInInspector]
		public float cloudFadeAlpha; // 0xA8
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0xAC
		public static HGCloudConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183ADDFB0-0x0000000183ADE010 0x00000001831D4F30-0x00000001831D4F70
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGCloudConfig::get_active(HGCloudConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1347 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x543 )
		    sub_1800D2AB0(v3, method);
		  if ( !*(_QWORD *)&v3[28]._1.token )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1347, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_534(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGCloudConfig::set_active(HGCloudConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1348, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1348, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_535(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Nested types
		public enum CloudTextureMode // TypeDefIndex: 37595
		{
			SingleChannelRG = 0,
			ColorRGB = 1
		}
	
		public enum CloudFlowType // TypeDefIndex: 37596
		{
			None = 0,
			Procedural = 1,
			FlowMap = 2
		}
	
		// Constructors
		public HGCloudConfig(bool active) : this() {
			enable = default;
			cloudTexture = default;
			cloudTint = default;
			cloudContrast = default;
			lightAffectCloud = default;
			cloudBrightness = default;
			cloudAbsoluteBrightness = default;
			brightnessAffectCloudAlpha = default;
			drawCloudAfterPlanet = default;
			cloudTextureMode = default;
			cloudOpacityR = default;
			cloudOpacityG = default;
			cloudFlowType = default;
			rotation = default;
			cloudFlowMap = default;
			flowSpeed = default;
			flowDirectionX = default;
			flowDirectionY = default;
			enableLightShaftCloudMask = default;
			lightShaftCloudMaskTexture = default;
			enableCloudShadow = default;
			cloudShadowConfig = default;
			cloudFadeAlpha = default;
			m_active = default;
		} // 0x00000001849D64F0-0x00000001849D65C0
		// HGCloudConfig(Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGCloudConfig::HGCloudConfig(HGCloudConfig *this, bool active, MethodInfo *method)
		{
		  __int64 v3; // r9
		  __int64 v4; // r10
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  MethodInfo *v7; // rdx
		  Vector4 v8; // xmm1
		  __int64 v9; // r9
		  __int64 v10; // r10
		  Type *v11; // rdx
		  PropertyInfo_1 *v12; // r8
		  __int64 v13; // r9
		  char v14; // r10
		  Vector4 v15; // [rsp+20h] [rbp-18h] BYREF
		
		  this->m_active = 0;
		  this->enable = 0;
		  this->cloudTexture = 0LL;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->cloudTexture,
		    (Type *)active,
		    (PropertyInfo_1 *)method,
		    (Int32__Array **)this,
		    *(MethodInfo **)&v15.x);
		  *(_QWORD *)(v3 + 72) = v4;
		  sub_18002D1B0((SingleFieldAccessor *)(v3 + 72), v5, v6, (Int32__Array **)v3, *(MethodInfo **)&v15.x);
		  v8 = *UnityEngine::Vector4::get_one(&v15, v7);
		  *(_DWORD *)(v9 + 32) = 1065353216;
		  *(_DWORD *)(v9 + 40) = v10;
		  *(Vector4 *)(v9 + 16) = v8;
		  *(_DWORD *)(v9 + 44) = 1065353216;
		  *(_WORD *)(v9 + 48) = 1;
		  *(_BYTE *)(v9 + 36) = 1;
		  *(_DWORD *)(v9 + 52) = v10;
		  *(_DWORD *)(v9 + 56) = 1065353216;
		  *(_QWORD *)(v9 + 60) = 1065353216LL;
		  *(_DWORD *)(v9 + 68) = v10;
		  *(_QWORD *)(v9 + 80) = v10;
		  *(_DWORD *)(v9 + 88) = v10;
		  *(_BYTE *)(v9 + 92) = v10;
		  *(_QWORD *)(v9 + 96) = v10;
		  sub_18002D1B0((SingleFieldAccessor *)(v9 + 96), v11, v12, (Int32__Array **)v9, *(MethodInfo **)&v15.x);
		  *(_BYTE *)(v13 + 104) = v14;
		  *(_OWORD *)(v13 + 112) = 0LL;
		  *(_OWORD *)(v13 + 128) = 0LL;
		  *(_OWORD *)(v13 + 144) = 0LL;
		  *(_QWORD *)(v13 + 160) = 0LL;
		  *(_DWORD *)(v13 + 168) = 1065353216;
		}
		
		static HGCloudConfig() {
			defaultConfig = default;
		} // 0x00000001849D63B0-0x00000001849D64F0
		// HGCloudConfig()
		void HG::Rendering::Runtime::HGCloudConfig::cctor(MethodInfo *method)
		{
		  HGCloudConfig__StaticFields *static_fields; // rcx
		  Color cloudTint; // xmm1
		  __int128 v3; // xmm0
		  __int128 v4; // xmm1
		  __int128 v5; // xmm0
		  __int128 v6; // xmm1
		  __int128 v7; // xmm0
		  __int128 v8; // xmm1
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  __int128 v11; // xmm0
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  HGCloudConfig v15; // [rsp+20h] [rbp-168h] BYREF
		  HGCloudConfig v16; // [rsp+D0h] [rbp-B8h]
		
		  sub_18033B9D0(&v15, 0LL, 176LL);
		  HG::Rendering::Runtime::HGCloudConfig::HGCloudConfig(&v15, 0, 0LL);
		  v16 = v15;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGCloudConfig->static_fields;
		  cloudTint = v15.cloudTint;
		  *(_OWORD *)&static_fields->defaultConfig.enable = *(_OWORD *)&v15.enable;
		  v3 = *(_OWORD *)&v16.cloudContrast;
		  static_fields->defaultConfig.cloudTint = cloudTint;
		  v4 = *(_OWORD *)&v16.brightnessAffectCloudAlpha;
		  *(_OWORD *)&static_fields->defaultConfig.cloudContrast = v3;
		  v5 = *(_OWORD *)&v16.cloudFlowType;
		  *(_OWORD *)&static_fields->defaultConfig.brightnessAffectCloudAlpha = v4;
		  v6 = *(_OWORD *)&v16.flowSpeed;
		  *(_OWORD *)&static_fields->defaultConfig.cloudFlowType = v5;
		  v7 = *(_OWORD *)&v16.lightShaftCloudMaskTexture;
		  *(_OWORD *)&static_fields->defaultConfig.flowSpeed = v6;
		  v8 = *(_OWORD *)&v16.cloudShadowConfig.cloudShadowTexture;
		  *(_OWORD *)&static_fields->defaultConfig.lightShaftCloudMaskTexture = v7;
		  v9 = *(_OWORD *)&v16.cloudShadowConfig.cloudShadowEnvCenter.z;
		  *(_OWORD *)&static_fields->defaultConfig.cloudShadowConfig.cloudShadowTexture = v8;
		  v10 = *(_OWORD *)&v16.cloudShadowConfig.cloudShadowFlowDirection.y;
		  *(_OWORD *)&static_fields->defaultConfig.cloudShadowConfig.cloudShadowEnvCenter.z = v9;
		  v11 = *(_OWORD *)&v16.cloudShadowConfig.cloudShadowScaleEndDistance;
		  *(_OWORD *)&static_fields->defaultConfig.cloudShadowConfig.cloudShadowFlowDirection.y = v10;
		  *(_OWORD *)&static_fields->defaultConfig.cloudShadowConfig.cloudShadowScaleEndDistance = v11;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGCloudConfig->static_fields->defaultConfig.cloudTexture,
		    v12,
		    v13,
		    v14,
		    *(MethodInfo **)&v15.enable);
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
