using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGInkSimulationConfig : IEnvConfig // TypeDefIndex: 37602
	{
		// Fields
		public static IEnumerable InkSimulationWorldSizeList; // 0x00
		[Header("\u5168\u5C40\u5F3A\u5EA6")]
		[Range(0f, 1f)]
		public float influence; // 0x00
		[Header("\u8986\u76D6\u8303\u56F4")]
		public float worldSize; // 0x04
		[Header("\u7981\u6B62\u6C34\u4F53\u6C34\u58A8\u529F\u80FD")]
		public bool disableWaterInk; // 0x08
		[Header("\u7981\u6B62\u6C34\u58A8\u6D9F\u6F2A")]
		public bool disableInkRipple; // 0x09
		[Header("\u6C34\u58A8\u6D9F\u6F2A\u91CF")]
		[Range(0f, 0.5f)]
		public float inkRippleIntensity; // 0x0C
		[Header("\u6C34\u58A8\u6D9F\u6F2A\u5BC6\u5EA6")]
		[Range(0f, 0.2f)]
		public float inkRippleDensity; // 0x10
		[Header("\u6C34\u58A8\u6D9F\u6F2A\u5F3A\u5EA6")]
		[Range(0f, 1f)]
		public float inkRippleStrength; // 0x14
		[Header("\u6C34\u58A8\u7740\u8272\u53C2\u6570")]
		public HGInkSimulationShaderParamsAsset shaderParams; // 0x18
		[Header("\u8C03\u8BD5\u53C2\u6570")]
		[Range(0f, 128f)]
		public float inkDebugJacobi; // 0x20
		[HideInInspector]
		public HGInkSimulationShaderParamValues resolvedShaderParams; // 0x24
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x74
		public static readonly HGInkSimulationConfig defaultConfig; // 0x08
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183B91180-0x0000000183B911E0 0x00000001831D5030-0x00000001831D5070
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGInkSimulationConfig::get_active(HGInkSimulationConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1368 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x558 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[29]._0.castClass )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1368, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_543(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGInkSimulationConfig::set_active(
		        HGInkSimulationConfig *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1369, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1369, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_544(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGInkSimulationConfig(bool active) : this() {
			influence = default;
			worldSize = default;
			disableWaterInk = default;
			disableInkRipple = default;
			inkRippleIntensity = default;
			inkRippleDensity = default;
			inkRippleStrength = default;
			shaderParams = default;
			inkDebugJacobi = default;
			resolvedShaderParams = default;
			m_active = default;
		} // 0x000000018402B700-0x000000018402B780
		// HGInkSimulationConfig(Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGInkSimulationConfig::HGInkSimulationConfig(
		        HGInkSimulationConfig *this,
		        bool active,
		        MethodInfo *method)
		{
		  Int32__Array **v3; // r9
		  HGInkSimulationShaderParamValues *Default; // rax
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  __int128 v8; // xmm2
		  __int128 v9; // xmm3
		  __int128 v10; // xmm4
		  HGInkSimulationShaderParamValues v11; // [rsp+20h] [rbp-58h] BYREF
		
		  this->m_active = 0;
		  this->influence = 0.0;
		  *(_QWORD *)&this->inkRippleIntensity = 0LL;
		  this->inkRippleStrength = 0.0;
		  this->shaderParams = 0LL;
		  *(_WORD *)&this->disableWaterInk = 257;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->shaderParams,
		    (Type *)active,
		    (PropertyInfo_1 *)method,
		    v3,
		    *(MethodInfo **)&v11.speedRandom);
		  Default = HG::Rendering::Runtime::HGInkSimulationShaderParamValues::get_Default(&v11, 0LL);
		  v6 = *(_OWORD *)&Default->speedRandom;
		  v7 = *(_OWORD *)&Default->speedInkSizeFactor;
		  v8 = *(_OWORD *)&Default->velocityScale;
		  v9 = *(_OWORD *)&Default->landingVelocityStrength;
		  v10 = *(_OWORD *)&Default->vorticity;
		  this->worldSize = 32.0;
		  *(_OWORD *)&this->resolvedShaderParams.speedRandom = v6;
		  this->inkDebugJacobi = 0.0;
		  *(_OWORD *)&this->resolvedShaderParams.speedInkSizeFactor = v7;
		  *(_OWORD *)&this->resolvedShaderParams.velocityScale = v8;
		  *(_OWORD *)&this->resolvedShaderParams.landingVelocityStrength = v9;
		  *(_OWORD *)&this->resolvedShaderParams.vorticity = v10;
		}
		
		static HGInkSimulationConfig() {
			InkSimulationWorldSizeList = default;
			defaultConfig = default;
		} // 0x000000018402B570-0x000000018402B700
		// HGInkSimulationConfig()
		void HG::Rendering::Runtime::HGInkSimulationConfig::cctor(MethodInfo *method)
		{
		  ValueDropdownList_1_System_Single_ *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  ValueDropdownList_1_System_Single_ *v4; // rbx
		  Type *v5; // rdx
		  PropertyInfo_1 *v6; // r8
		  Int32__Array **v7; // r9
		  __int128 v8; // xmm2
		  __int128 v9; // xmm3
		  HGInkSimulationConfig__StaticFields *static_fields; // rcx
		  __int128 v11; // xmm4
		  __int128 v12; // xmm5
		  __int128 v13; // xmm6
		  __int128 v14; // xmm7
		  __int64 v15; // xmm0_8
		  Type *v16; // rdx
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  HGInkSimulationConfig v19; // [rsp+20h] [rbp-A8h] BYREF
		
		  v1 = (ValueDropdownList_1_System_Single_ *)sub_1800368D0(TypeInfo::Sirenix::OdinInspector::ValueDropdownList<float>);
		  v4 = v1;
		  if ( !v1 )
		    sub_1800D8260(v3, v2);
		  Sirenix::OdinInspector::ValueDropdownList<float>::ValueDropdownList(
		    v1,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<float>::ValueDropdownList);
		  Sirenix::OdinInspector::ValueDropdownList<float>::Add(
		    v4,
		    (String *)"16",
		    16.0,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<float>::Add);
		  Sirenix::OdinInspector::ValueDropdownList<float>::Add(
		    v4,
		    (String *)"32",
		    32.0,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<float>::Add);
		  Sirenix::OdinInspector::ValueDropdownList<float>::Add(
		    v4,
		    (String *)"64",
		    64.0,
		    MethodInfo::Sirenix::OdinInspector::ValueDropdownList<float>::Add);
		  TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig->static_fields->InkSimulationWorldSizeList = (IEnumerable *)v4;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig->static_fields,
		    v5,
		    v6,
		    v7,
		    *(MethodInfo **)&v19.influence);
		  memset(&v19, 0, sizeof(v19));
		  HG::Rendering::Runtime::HGInkSimulationConfig::HGInkSimulationConfig(&v19, 0, 0LL);
		  v8 = *(_OWORD *)&v19.inkRippleDensity;
		  v9 = *(_OWORD *)&v19.inkDebugJacobi;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig->static_fields;
		  v11 = *(_OWORD *)&v19.resolvedShaderParams.speedFactor;
		  v12 = *(_OWORD *)&v19.resolvedShaderParams.forceAngleRandom;
		  v13 = *(_OWORD *)&v19.resolvedShaderParams.landingInkSize;
		  v14 = *(_OWORD *)&v19.resolvedShaderParams.viscosity;
		  v15 = *(_QWORD *)&v19.resolvedShaderParams.idleForceChangeSpeed;
		  *(_OWORD *)&static_fields->defaultConfig.influence = *(_OWORD *)&v19.influence;
		  *(_OWORD *)&static_fields->defaultConfig.inkRippleDensity = v8;
		  *(_OWORD *)&static_fields->defaultConfig.inkDebugJacobi = v9;
		  *(_OWORD *)&static_fields->defaultConfig.resolvedShaderParams.speedFactor = v11;
		  *(_OWORD *)&static_fields->defaultConfig.resolvedShaderParams.forceAngleRandom = v12;
		  *(_OWORD *)&static_fields->defaultConfig.resolvedShaderParams.landingInkSize = v13;
		  *(_OWORD *)&static_fields->defaultConfig.resolvedShaderParams.viscosity = v14;
		  *(_QWORD *)&static_fields->defaultConfig.resolvedShaderParams.idleForceChangeSpeed = v15;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGInkSimulationConfig->static_fields->defaultConfig.shaderParams,
		    v16,
		    v17,
		    v18,
		    *(MethodInfo **)&v19.influence);
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
