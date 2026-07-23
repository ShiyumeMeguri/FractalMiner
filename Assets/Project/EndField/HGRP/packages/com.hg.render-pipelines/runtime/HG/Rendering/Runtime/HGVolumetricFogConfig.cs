using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGVolumetricFogConfig : IEnvConfig // TypeDefIndex: 37628
	{
		// Fields
		[Header("\u542F\u7528\u4F53\u79EF\u96FE")]
		public bool enable; // 0x00
		[Header("\u8D77\u59CB\u9AD8\u5EA6")]
		[UnclampedRange(-500f, 500f)]
		public float heightFogStartHeight; // 0x04
		[Header("\u6D53\u5EA6")]
		[RangeExponential(0f, 1f, 3f)]
		public float heightFogDensity; // 0x08
		[Header("\u8870\u51CF")]
		[UnclampedRange(0.001f, 2f)]
		public float heightFogFalloff; // 0x0C
		[Header("\u8D77\u59CB\u9AD8\u5EA6")]
		[Range(-500f, 500f)]
		public float heightFogStartHeightSecond; // 0x10
		[Header("\u6D53\u5EA6")]
		[RangeExponential(0f, 1f, 3f)]
		public float heightFogDensitySecond; // 0x14
		[Header("\u8870\u51CF")]
		[UnclampedRange(0.001f, 2f)]
		public float heightFogFalloffSecond; // 0x18
		[ColorUsage(false, true)]
		[Header("\u6563\u5C04\uFF08\u96FE\u7684\u989C\u8272\uFF09")]
		public UnityEngine.Color heightFogInscatter; // 0x1C
		[Header("\u6700\u5927\u4E0D\u900F\u660E\u5EA6")]
		[Range(0f, 1f)]
		public float heightFogMaxOpacity; // 0x2C
		[Header("\u8D77\u59CB\u8DDD\u79BB")]
		[UnclampedRange(0f, 200f)]
		public float heightFogStartDistance; // 0x30
		[Header("\u8D77\u59CB\u533A\u57DF\u8FC7\u6E21")]
		[UnclampedRangeExponential(0.001f, 1f, 3f)]
		public float heightFogStartTransition; // 0x34
		[Header("\u7ED3\u675F\u8DDD\u79BB")]
		[UnclampedRangeExponential(0f, 200000f, 3f)]
		public float heightFogCutoffDistance; // 0x38
		[Header("\u7ED3\u675F\u533A\u57DF\u8FC7\u6E21")]
		[UnclampedRangeExponential(0.001f, 1f, 3f)]
		public float heightFogCutoffTransition; // 0x3C
		[Header("\u65B9\u5411\u6563\u5C04\u8870\u51CF")]
		[Range(2f, 64f)]
		public float heightFogDirectionalInscatteringExponent; // 0x40
		[Header("\u65B9\u5411\u6563\u5C04\u8D77\u59CB\u8DDD\u79BB")]
		public float heightFogDirectionalInscatteringStartDistance; // 0x44
		[ColorUsage(false, true)]
		[Header("\u65B9\u5411\u6563\u5C04\u989C\u8272")]
		public UnityEngine.Color heightFogDirectionalInscattering; // 0x48
		[Header("\u65B9\u5411\u6563\u5C04\u8870\u51CF\uFF08\u79FB\u52A8\u7AEF\uFF09")]
		[Range(2f, 64f)]
		public float heightFogDirectionalInscatteringExponentMobile; // 0x58
		[ColorUsage(false, true)]
		[Header("\u65B9\u5411\u6563\u5C04\u989C\u8272\uFF08\u79FB\u52A8\u7AEF\uFF09")]
		public UnityEngine.Color heightFogDirectionalInscatteringMobile; // 0x5C
		[Header("\u6563\u5C04\u5206\u5E03")]
		[Range(-0.9f, 0.9f)]
		public float volumetricFogScatteringDistribution; // 0x6C
		[ColorUsage(false, true)]
		[Header("\u53CD\u5C04\u7387")]
		public UnityEngine.Color volumetricFogAlbedo; // 0x70
		[ColorUsage(false, true)]
		[Header("\u81EA\u53D1\u5149")]
		public UnityEngine.Color volumetricFogEmissive; // 0x80
		[Header("\u6D88\u5149\u6BD4\u4F8B")]
		[Range(0.1f, 10f)]
		public float volumetricFogExtinctionScale; // 0x90
		[Header("\u89C6\u91CE\u8DDD\u79BB")]
		[UnclampedRange(10f, 200f)]
		public float volumetricFogDistance; // 0x94
		[Header("\u5F00\u59CB\u8DDD\u79BB")]
		[UnclampedRange(0f, 50f)]
		public float volumetricFogStartDistance; // 0x98
		[Header("\u8FD1\u6DE1\u5165\u8DDD\u79BB")]
		[UnclampedRange(0f, 10f)]
		public float volumetricFogNearFadeInDistance; // 0x9C
		[Header("\u76F4\u63A5\u5149\u6563\u5C04\u5F3A\u5EA6")]
		[Range(0f, 10f)]
		public float volumetricFogDirectLightingScatteringIntensity; // 0xA0
		[Header("\u5929\u5149\u6563\u5C04\u5F3A\u5EA6")]
		[UnclampedRange(0f, 10f)]
		public float volumetricFogSkyLightingScatteringIntensity; // 0xA4
		[Header("\u5F00\u542F\u6D41\u52A8Noise")]
		public bool enableFlowNoise; // 0xA8
		[Header("\u6D41\u52A8Noise\u5F3A\u5EA6")]
		[Range(0f, 1f)]
		public float flowNoiseIntensity; // 0xAC
		[Header("\u6D41\u52A8Noise\u6DE1\u51FA\u8DDD\u79BB")]
		[Range(10f, 1000f)]
		public float flowNoiseDistance; // 0xB0
		[Header("\u6D41\u52A8Noise\u5BC6\u5EA6")]
		[Range(0f, 0.2f)]
		public float flowNoiseTilling; // 0xB4
		[Header("\u6D41\u52A8Noise\u6C34\u5E73\u65B9\u5411")]
		[Range(0f, 360f)]
		public float flowNoiseHorizontalDirAngle; // 0xB8
		[Header("\u6D41\u52A8Noise\u5782\u76F4\u65B9\u5411")]
		[Range(-90f, 90f)]
		public float flowNoiseVerticalDirAngle; // 0xBC
		public Vector3 flowNoiseDir; // 0xC0
		[Header("\u6D41\u52A8Noise\u901F\u5EA6")]
		[Range(0f, 2f)]
		public float flowNoiseSpeed; // 0xCC
		[Header("\u5F00\u542F\u4F53\u79EF\u5149\u6D41\u52A8Noise")]
		public bool enableVLFlowNoise; // 0xD0
		[HideInInspector]
		public Texture3D flowVLNoise3DTexture; // 0xD8
		[Header("\u4F53\u79EF\u5149\u6D41\u52A8Noise\u53C2\u6570\u81EA\u5B9A\u4E49")]
		public bool enableTwoParameter; // 0xE0
		[Header("\u6D41\u52A8Noise\u5F3A\u5EA6")]
		[Range(0f, 1f)]
		public float flowVLNoiseIntensity; // 0xE4
		[Header("\u6D41\u52A8Noise\u5BF9\u6BD4\u5EA6")]
		[Tooltip("\u4E24\u4E2A\u503C\u8D8A\u9760\u8FD1\u8FC7\u5EA6\u8D8A\u786C\uFF0Clerp(Min, Max, noise)")]
		public Vector2 flowVLNoiseRemapRange; // 0xE8
		[Header("\u6D41\u52A8Noise\u6DE1\u51FA\u8DDD\u79BB")]
		[Range(10f, 1000f)]
		public float flowVLNoiseDistance; // 0xF0
		[Header("\u6D41\u52A8Noise\u5BC6\u5EA6")]
		[Range(0f, 2f)]
		public float flowVLNoiseTilling; // 0xF4
		[Header("\u6D41\u52A8Noise\u4E09\u8F74\u7F29\u653E")]
		[Tooltip("\u5BF9Tilling\u7684XYZ\u8F74\u5411\u5206\u522B\u7F29\u653E")]
		public Vector3 flowVLNoiseTillingScale; // 0xF8
		[Header("\u6D41\u52A8Noise\u6C34\u5E73\u65B9\u5411")]
		[Range(0f, 360f)]
		public float flowVLNoiseHorizontalDirAngle; // 0x104
		[Header("\u6D41\u52A8Noise\u5782\u76F4\u65B9\u5411")]
		[Range(-90f, 90f)]
		public float flowVLNoiseVerticalDirAngle; // 0x108
		public Vector3 flowVLNoiseDir; // 0x10C
		[Header("\u6D41\u52A8Noise\u901F\u5EA6")]
		[Range(0f, 2f)]
		public float flowVLNoiseSpeed; // 0x118
		[HideInInspector]
		public Texture3D flowVLNoisePerturb3DTexture; // 0x120
		[Header("\u6270\u52A8\u566A\u58F0Tilling")]
		[Range(0.001f, 2f)]
		public float flowVLNoisePerturbTilling; // 0x128
		[Header("\u6270\u52A8\u566A\u58F0\u5F3A\u5EA6")]
		[Range(0f, 2f)]
		public float flowVLNoisePerturbIntensity; // 0x12C
		[Header("\u6270\u52A8\u566A\u58F0UV\u79FB\u52A8\u901F\u5EA6")]
		[Tooltip("XYZ\u4E3AUV\u7A7A\u95F4\u79FB\u52A8\u65B9\u5411\u4E0E\u901F\u5EA6")]
		public Vector3 flowVLNoisePerturbSpeed; // 0x130
		[HideInInspector]
		[SerializeField]
		private float m_backupVLNoiseIntensity; // 0x13C
		[HideInInspector]
		[SerializeField]
		private float m_backupVLNoiseDistance; // 0x140
		[HideInInspector]
		[SerializeField]
		private float m_backupVLNoiseTilling; // 0x144
		[HideInInspector]
		[SerializeField]
		private Vector3 m_backupVLNoiseTillingScale; // 0x148
		[HideInInspector]
		[SerializeField]
		private float m_backupVLNoiseHorizontalDirAngle; // 0x154
		[HideInInspector]
		[SerializeField]
		private float m_backupVLNoiseVerticalDirAngle; // 0x158
		[HideInInspector]
		[SerializeField]
		private float m_backupVLNoiseSpeed; // 0x15C
		[HideInInspector]
		[SerializeField]
		private Vector2 m_backupFlowVLNoiseRemapRange; // 0x160
		[HideInInspector]
		[SerializeField]
		private bool m_prevEnableTwoParameter; // 0x168
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x169
		public static HGVolumetricFogConfig defaultConfig; // 0x00
	
		// Properties
		public bool flowNoiseEnabled { get => default; } // 0x0000000183B9C2F0-0x0000000183B9C460 
		// Boolean get_flowNoiseEnabled()
		bool HG::Rendering::Runtime::HGVolumetricFogConfig::get_flowNoiseEnabled(
		        HGVolumetricFogConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  HGVolumetricFogConfig *v3; // rbx
		  int *static_fields; // rdx
		  bool supportVolumetricFog; // al
		  __int64 v7; // r8
		  ILFixDynamicMethodWrapper_2 *v8; // rax
		  __int64 v9; // r8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_24;
		  if ( *(int *)(*(_QWORD *)static_fields + 24LL) <= 1104 )
		    goto LABEL_49;
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  v7 = *(_QWORD *)static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_24;
		  if ( *(_DWORD *)(v7 + 24) <= 0x450u )
		    goto LABEL_46;
		  if ( !*(_QWORD *)(v7 + 8864) )
		  {
		LABEL_49:
		    if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGVolumetricFogConfig *)v2->static_fields;
		    static_fields = *(int **)&this->enable;
		    if ( !*(_QWORD *)&this->enable )
		      goto LABEL_24;
		    if ( static_fields[6] > 955 )
		    {
		      if ( !v2->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v2);
		        v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		      }
		      static_fields = (int *)v2->static_fields;
		      v9 = *(_QWORD *)static_fields;
		      if ( !*(_QWORD *)static_fields )
		        goto LABEL_24;
		      if ( *(_DWORD *)(v9 + 24) <= 0x3BBu )
		        goto LABEL_46;
		      if ( *(_QWORD *)(v9 + 7672) )
		      {
		        Patch = IFix::WrappersManagerImpl::GetPatch(955, 0LL);
		        if ( Patch )
		          goto LABEL_38;
		        goto LABEL_24;
		      }
		    }
		    if ( !v3->enable )
		      return 0;
		    if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGVolumetricFogConfig *)v2->static_fields;
		    static_fields = *(int **)&this->enable;
		    if ( !*(_QWORD *)&this->enable )
		      goto LABEL_24;
		    if ( static_fields[6] <= 956 )
		    {
		LABEL_18:
		      if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		      supportVolumetricFog = HG::Rendering::Runtime::HGVolumetricFogRenderer::get_supportVolumetricFog(0LL);
		LABEL_21:
		      if ( supportVolumetricFog )
		        return v3->enableFlowNoise;
		      return 0;
		    }
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGVolumetricFogConfig *)v2->static_fields;
		    v11 = *(_QWORD *)&this->enable;
		    if ( !*(_QWORD *)&this->enable )
		      goto LABEL_24;
		    if ( *(_DWORD *)(v11 + 24) > 0x3BCu )
		    {
		      if ( !*(_QWORD *)(v11 + 7680) )
		        goto LABEL_18;
		      Patch = IFix::WrappersManagerImpl::GetPatch(956, 0LL);
		      if ( Patch )
		      {
		LABEL_38:
		        supportVolumetricFog = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_379(Patch, v3, 0LL);
		        goto LABEL_21;
		      }
		LABEL_24:
		      sub_1800D8260(this, static_fields);
		    }
		LABEL_46:
		    sub_1800D2AB0(this, static_fields);
		  }
		  v8 = IFix::WrappersManagerImpl::GetPatch(1104, 0LL);
		  if ( !v8 )
		    goto LABEL_24;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_379(v8, v3, 0LL);
		}
		
		public bool flowVLNoiseEnabled { get => default; } // 0x0000000189CE4658-0x0000000189CE46C8 
		// Boolean get_flowVLNoiseEnabled()
		bool HG::Rendering::Runtime::HGVolumetricFogConfig::get_flowVLNoiseEnabled(
		        HGVolumetricFogConfig *this,
		        MethodInfo *method)
		{
		  bool result; // al
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1409, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1409, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_379(Patch, this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		    result = HG::Rendering::Runtime::HGVolumetricFogConfig::get_volumetricFogEnabled(this, 0LL);
		    if ( result )
		      return this->enableVLFlowNoise;
		  }
		  return result;
		}
		
		public bool volumetricFogAbleToEnable { get => default; } // 0x0000000183B9C540-0x0000000183B9C5C0 
		// Boolean get_volumetricFogAbleToEnable()
		bool HG::Rendering::Runtime::HGVolumetricFogConfig::get_volumetricFogAbleToEnable(
		        HGVolumetricFogConfig *this,
		        MethodInfo *method)
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
		    goto LABEL_8;
		  if ( wrapperArray->max_length.size > 956 )
		  {
		    if ( !v3->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v3);
		      v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		    if ( v3 )
		    {
		      if ( LODWORD(v3->_0.namespaze) <= 0x3BC )
		        sub_1800D2AB0(v3, method);
		      if ( !v3[20]._0.nestedTypes )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(956, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_379(Patch, this, 0LL);
		    }
		LABEL_8:
		    sub_1800D8260(v3, method);
		  }
		LABEL_5:
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		  return HG::Rendering::Runtime::HGVolumetricFogRenderer::get_supportVolumetricFog(0LL);
		}
		
		public bool volumetricFogEnabled { get => default; } // 0x0000000183B9C460-0x0000000183B9C540 
		// Boolean get_volumetricFogEnabled()
		bool HG::Rendering::Runtime::HGVolumetricFogConfig::get_volumetricFogEnabled(
		        HGVolumetricFogConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v2; // rax
		  HGVolumetricFogConfig *v3; // rbx
		  int *static_fields; // rdx
		  __int64 v6; // r8
		  int32_t v7; // ecx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rax
		
		  v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v3 = this;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  static_fields = (int *)v2->static_fields;
		  if ( !*(_QWORD *)static_fields )
		    goto LABEL_16;
		  if ( *(int *)(*(_QWORD *)static_fields + 24LL) > 955 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    static_fields = (int *)v2->static_fields;
		    v6 = *(_QWORD *)static_fields;
		    if ( !*(_QWORD *)static_fields )
		      goto LABEL_16;
		    if ( *(_DWORD *)(v6 + 24) <= 0x3BBu )
		      goto LABEL_31;
		    if ( *(_QWORD *)(v6 + 7672) )
		    {
		      v7 = 955;
		LABEL_23:
		      Patch = IFix::WrappersManagerImpl::GetPatch(v7, 0LL);
		      if ( Patch )
		        return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_379(Patch, v3, 0LL);
		LABEL_16:
		      sub_1800D8260(this, static_fields);
		    }
		  }
		  if ( !v3->enable )
		    return 0;
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  if ( !v2->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v2);
		    v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  this = (HGVolumetricFogConfig *)v2->static_fields;
		  static_fields = *(int **)&this->enable;
		  if ( !*(_QWORD *)&this->enable )
		    goto LABEL_16;
		  if ( static_fields[6] > 956 )
		  {
		    if ( !v2->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v2);
		      v2 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    this = (HGVolumetricFogConfig *)v2->static_fields;
		    v9 = *(_QWORD *)&this->enable;
		    if ( !*(_QWORD *)&this->enable )
		      goto LABEL_16;
		    if ( *(_DWORD *)(v9 + 24) > 0x3BCu )
		    {
		      if ( !*(_QWORD *)(v9 + 7680) )
		        goto LABEL_12;
		      v7 = 956;
		      goto LABEL_23;
		    }
		LABEL_31:
		    sub_1800D2AB0(this, static_fields);
		  }
		LABEL_12:
		  if ( !TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
		  return HG::Rendering::Runtime::HGVolumetricFogRenderer::get_supportVolumetricFog(0LL);
		}
		
		public bool active { get => default; set {} } // 0x0000000183A6EA80-0x0000000183A6EDA0 0x00000001831D5330-0x00000001831D5370
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGVolumetricFogConfig::get_active(HGVolumetricFogConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1410 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x582 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[30]._0.byval_arg.data.dummy )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1410, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_379(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGVolumetricFogConfig::set_active(
		        HGVolumetricFogConfig *this,
		        bool value,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1411, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1411, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_578(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGVolumetricFogConfig(bool active) : this() {
			enable = default;
			heightFogStartHeight = default;
			heightFogDensity = default;
			heightFogFalloff = default;
			heightFogStartHeightSecond = default;
			heightFogDensitySecond = default;
			heightFogFalloffSecond = default;
			heightFogInscatter = default;
			heightFogMaxOpacity = default;
			heightFogStartDistance = default;
			heightFogStartTransition = default;
			heightFogCutoffDistance = default;
			heightFogCutoffTransition = default;
			heightFogDirectionalInscatteringExponent = default;
			heightFogDirectionalInscatteringStartDistance = default;
			heightFogDirectionalInscattering = default;
			heightFogDirectionalInscatteringExponentMobile = default;
			heightFogDirectionalInscatteringMobile = default;
			volumetricFogScatteringDistribution = default;
			volumetricFogAlbedo = default;
			volumetricFogEmissive = default;
			volumetricFogExtinctionScale = default;
			volumetricFogDistance = default;
			volumetricFogStartDistance = default;
			volumetricFogNearFadeInDistance = default;
			volumetricFogDirectLightingScatteringIntensity = default;
			volumetricFogSkyLightingScatteringIntensity = default;
			enableFlowNoise = default;
			flowNoiseIntensity = default;
			flowNoiseDistance = default;
			flowNoiseTilling = default;
			flowNoiseHorizontalDirAngle = default;
			flowNoiseVerticalDirAngle = default;
			flowNoiseDir = default;
			flowNoiseSpeed = default;
			enableVLFlowNoise = default;
			flowVLNoise3DTexture = default;
			enableTwoParameter = default;
			flowVLNoiseIntensity = default;
			flowVLNoiseRemapRange = default;
			flowVLNoiseDistance = default;
			flowVLNoiseTilling = default;
			flowVLNoiseTillingScale = default;
			flowVLNoiseHorizontalDirAngle = default;
			flowVLNoiseVerticalDirAngle = default;
			flowVLNoiseDir = default;
			flowVLNoiseSpeed = default;
			flowVLNoisePerturb3DTexture = default;
			flowVLNoisePerturbTilling = default;
			flowVLNoisePerturbIntensity = default;
			flowVLNoisePerturbSpeed = default;
			m_backupVLNoiseIntensity = default;
			m_backupVLNoiseDistance = default;
			m_backupVLNoiseTilling = default;
			m_backupVLNoiseTillingScale = default;
			m_backupVLNoiseHorizontalDirAngle = default;
			m_backupVLNoiseVerticalDirAngle = default;
			m_backupVLNoiseSpeed = default;
			m_backupFlowVLNoiseRemapRange = default;
			m_prevEnableTwoParameter = default;
			m_active = default;
		} // 0x00000001847D6010-0x00000001847D62A0
		// HGVolumetricFogConfig(Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGVolumetricFogConfig::HGVolumetricFogConfig(
		        HGVolumetricFogConfig *this,
		        bool active,
		        MethodInfo *method)
		{
		  Vector4 v3; // xmm1
		  __int64 v4; // r9
		  MethodInfo *v5; // rdx
		  Quaternion v6; // xmm1
		  __int64 v7; // r9
		  MethodInfo *v8; // rdx
		  Quaternion v9; // xmm1
		  __int64 v10; // r9
		  MethodInfo *v11; // rdx
		  Vector4 *one; // rax
		  Vector4 *v13; // r9
		  MethodInfo *v14; // rdx
		  Quaternion v15; // xmm1
		  __int64 v16; // r9
		  __int64 v17; // r10
		  HGRuntimeGrassQuery_Node *v18; // rdx
		  HGRuntimeGrassQuery_Node *v19; // r8
		  __int64 v20; // r9
		  __int64 v21; // r10
		  HGRuntimeGrassQuery_Node *v22; // rdx
		  HGRuntimeGrassQuery_Node *v23; // r8
		  __int64 v24; // r9
		  __int64 v25; // r10
		  Quaternion v26; // [rsp+20h] [rbp-18h] BYREF
		
		  this->m_active = 0;
		  this->heightFogStartHeight = 0.0;
		  this->heightFogDensitySecond = 0.0;
		  this->enable = 0;
		  this->heightFogDensity = 0.02;
		  *(_QWORD *)&this->heightFogFalloff = 1045220557LL;
		  this->heightFogFalloffSecond = 0.2;
		  v3 = *UnityEngine::Vector4::get_one((Vector4 *)&v26, (MethodInfo *)active);
		  *(_QWORD *)(v4 + 44) = 1065353216LL;
		  *(_DWORD *)(v4 + 52) = 1028443341;
		  *(Vector4 *)(v4 + 28) = v3;
		  *(_DWORD *)(v4 + 56) = 1128792064;
		  *(_DWORD *)(v4 + 60) = 1028443341;
		  *(_DWORD *)(v4 + 64) = 1082130432;
		  *(_DWORD *)(v4 + 68) = 1120403456;
		  v6 = *UnityEngine::Quaternion::get_identity(&v26, v5);
		  *(_DWORD *)(v7 + 88) = 1082130432;
		  *(Quaternion *)(v7 + 72) = v6;
		  v9 = *UnityEngine::Quaternion::get_identity(&v26, v8);
		  *(_DWORD *)(v10 + 108) = 1045220557;
		  *(Quaternion *)(v10 + 92) = v9;
		  one = UnityEngine::Vector4::get_one((Vector4 *)&v26, v11);
		  v13[7] = *one;
		  v15 = *UnityEngine::Quaternion::get_identity(&v26, v14);
		  *(_DWORD *)(v16 + 144) = 1065353216;
		  *(_QWORD *)(v16 + 148) = 1114636288LL;
		  *(Quaternion *)(v16 + 128) = v15;
		  *(_DWORD *)(v16 + 156) = v17;
		  *(_DWORD *)(v16 + 160) = 1065353216;
		  *(_DWORD *)(v16 + 164) = 1065353216;
		  *(_BYTE *)(v16 + 168) = v17;
		  *(_DWORD *)(v16 + 172) = 1056964608;
		  *(_DWORD *)(v16 + 176) = 1114636288;
		  *(_QWORD *)(v16 + 180) = 1008981770LL;
		  *(_DWORD *)(v16 + 188) = v17;
		  *(_DWORD *)(v16 + 204) = v17;
		  *(_QWORD *)(v16 + 192) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  *(_DWORD *)(v16 + 200) = 1065353216;
		  *(_BYTE *)(v16 + 208) = v17;
		  *(_QWORD *)(v16 + 216) = v17;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v16 + 216), v18, v19, (Int32__Array **)v16, *(MethodInfo **)&v26.x);
		  *(_QWORD *)(v20 + 288) = v21;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v20 + 288), v22, v23, (Int32__Array **)v20, *(MethodInfo **)&v26.x);
		  *(_DWORD *)(v24 + 296) = 1028443341;
		  *(_DWORD *)(v24 + 300) = 1056964608;
		  *(_BYTE *)(v24 + 224) = v25;
		  *(_QWORD *)(v24 + 304) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  *(_DWORD *)(v24 + 312) = 0;
		  *(_QWORD *)(v24 + 228) = 1056964608LL;
		  *(_DWORD *)(v24 + 240) = 1114636288;
		  *(_DWORD *)(v24 + 244) = 1008981770;
		  *(_QWORD *)(v24 + 260) = v25;
		  *(_QWORD *)(v24 + 248) = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		  *(_DWORD *)(v24 + 256) = 1065353216;
		  *(_DWORD *)(v24 + 280) = v25;
		  *(_QWORD *)(v24 + 268) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  *(_DWORD *)(v24 + 276) = 1065353216;
		  *(_DWORD *)(v24 + 236) = 1065353216;
		  *(_DWORD *)(v24 + 316) = 1056964608;
		  *(_DWORD *)(v24 + 320) = 1114636288;
		  *(_DWORD *)(v24 + 324) = 1008981770;
		  *(_QWORD *)(v24 + 340) = v25;
		  *(_QWORD *)(v24 + 328) = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		  *(_DWORD *)(v24 + 336) = 1065353216;
		  *(_QWORD *)(v24 + 348) = v25;
		  *(_DWORD *)(v24 + 356) = 1065353216;
		  *(_BYTE *)(v24 + 360) = v25;
		}
		
		static HGVolumetricFogConfig() {
			defaultConfig = default;
		} // 0x00000001847D5E80-0x00000001847D6010
		// HGVolumetricFogConfig()
		void HG::Rendering::Runtime::HGVolumetricFogConfig::cctor(MethodInfo *method)
		{
		  Int32__Array **v1; // r9
		  __int64 v2; // rdx
		  _OWORD *v3; // rax
		  __int64 v4; // r8
		  HGVolumetricFogConfig *v5; // rcx
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  __int128 v8; // xmm0
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  HGVolumetricFogConfig__StaticFields *static_fields; // rcx
		  __int128 *v21; // rax
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  __int128 v32; // xmm1
		  __int128 v33; // xmm0
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  HGVolumetricFogConfig v36; // [rsp+20h] [rbp-2E8h] BYREF
		  _BYTE v37[376]; // [rsp+190h] [rbp-178h] BYREF
		
		  sub_18033B9D0(&v36, 0LL, 368LL);
		  HG::Rendering::Runtime::HGVolumetricFogConfig::HGVolumetricFogConfig(&v36, 0, 0LL);
		  v2 = 2LL;
		  v3 = v37;
		  v4 = 2LL;
		  v5 = &v36;
		  do
		  {
		    v3 += 8;
		    v6 = *(_OWORD *)&v5->enable;
		    v7 = *(_OWORD *)&v5->heightFogStartHeightSecond;
		    v5 = (HGVolumetricFogConfig *)((char *)v5 + 128);
		    *(v3 - 8) = v6;
		    v8 = *(_OWORD *)&v5[-1].flowVLNoiseDir.y;
		    *(v3 - 7) = v7;
		    v9 = *(_OWORD *)&v5[-1].flowVLNoisePerturb3DTexture;
		    *(v3 - 6) = v8;
		    v10 = *(_OWORD *)&v5[-1].flowVLNoisePerturbSpeed.x;
		    *(v3 - 5) = v9;
		    v11 = *(_OWORD *)&v5[-1].m_backupVLNoiseDistance;
		    *(v3 - 4) = v10;
		    v12 = *(_OWORD *)&v5[-1].m_backupVLNoiseTillingScale.z;
		    *(v3 - 3) = v11;
		    v13 = *(_OWORD *)&v5[-1].m_backupFlowVLNoiseRemapRange.x;
		    *(v3 - 2) = v12;
		    *(v3 - 1) = v13;
		    --v4;
		  }
		  while ( v4 );
		  v14 = *(_OWORD *)&v5->heightFogStartHeightSecond;
		  *v3 = *(_OWORD *)&v5->enable;
		  v15 = *(_OWORD *)&v5->heightFogInscatter.g;
		  v3[1] = v14;
		  v16 = *(_OWORD *)&v5->heightFogStartDistance;
		  v3[2] = v15;
		  v17 = *(_OWORD *)&v5->heightFogDirectionalInscatteringExponent;
		  v3[3] = v16;
		  v18 = *(_OWORD *)&v5->heightFogDirectionalInscattering.b;
		  v3[4] = v17;
		  v19 = *(_OWORD *)&v5->heightFogDirectionalInscatteringMobile.g;
		  v3[5] = v18;
		  v3[6] = v19;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig->static_fields;
		  v21 = (__int128 *)v37;
		  do
		  {
		    static_fields = (HGVolumetricFogConfig__StaticFields *)((char *)static_fields + 128);
		    v22 = *v21;
		    v23 = v21[1];
		    v21 += 8;
		    *(_OWORD *)&static_fields[-1].defaultConfig.flowVLNoiseDistance = v22;
		    v24 = *(v21 - 6);
		    *(_OWORD *)&static_fields[-1].defaultConfig.flowVLNoiseTillingScale.z = v23;
		    v25 = *(v21 - 5);
		    *(_OWORD *)&static_fields[-1].defaultConfig.flowVLNoiseDir.y = v24;
		    v26 = *(v21 - 4);
		    *(_OWORD *)&static_fields[-1].defaultConfig.flowVLNoisePerturb3DTexture = v25;
		    v27 = *(v21 - 3);
		    *(_OWORD *)&static_fields[-1].defaultConfig.flowVLNoisePerturbSpeed.x = v26;
		    v28 = *(v21 - 2);
		    *(_OWORD *)&static_fields[-1].defaultConfig.m_backupVLNoiseDistance = v27;
		    v29 = *(v21 - 1);
		    *(_OWORD *)&static_fields[-1].defaultConfig.m_backupVLNoiseTillingScale.z = v28;
		    *(_OWORD *)&static_fields[-1].defaultConfig.m_backupFlowVLNoiseRemapRange.x = v29;
		    --v2;
		  }
		  while ( v2 );
		  v30 = v21[1];
		  *(_OWORD *)&static_fields->defaultConfig.enable = *v21;
		  v31 = v21[2];
		  *(_OWORD *)&static_fields->defaultConfig.heightFogStartHeightSecond = v30;
		  v32 = v21[3];
		  *(_OWORD *)&static_fields->defaultConfig.heightFogInscatter.g = v31;
		  v33 = v21[4];
		  *(_OWORD *)&static_fields->defaultConfig.heightFogStartDistance = v32;
		  v34 = v21[5];
		  *(_OWORD *)&static_fields->defaultConfig.heightFogDirectionalInscatteringExponent = v33;
		  v35 = v21[6];
		  *(_OWORD *)&static_fields->defaultConfig.heightFogDirectionalInscattering.b = v34;
		  *(_OWORD *)&static_fields->defaultConfig.heightFogDirectionalInscatteringMobile.g = v35;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig->static_fields->defaultConfig.flowVLNoise3DTexture,
		    0LL,
		    0LL,
		    v1,
		    *(MethodInfo **)&v36.enable);
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
