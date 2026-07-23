using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGStarConfig : IEnvConfig // TypeDefIndex: 37625
	{
		// Fields
		[Header("\u7ED8\u5236\u7FA4\u661F")]
		public bool enableStars; // 0x00
		[Header("\u7B2C\u4E00\u5C42\u5BC6\u5EA6Tilling")]
		[UnclampedRange(0.1f, 2f)]
		public float starsTilling; // 0x04
		[Header("\u661F\u661F\u95EA\u70C1\u901F\u5EA6")]
		[UnclampedRange(0f, 0.5f)]
		public float starsFlickerSpeed; // 0x08
		[Header("\u661F\u661F\u5927\u5C0FMinMax")]
		public Vector2 minMaxRange; // 0x0C
		[Header("\u661F\u661F\u989C\u82720")]
		public UnityEngine.Color starsTint; // 0x14
		[Header("\u661F\u661F\u989C\u82721")]
		public UnityEngine.Color starsTint1; // 0x24
		[Header("\u661F\u661F\u5149\u6655\u8303\u56F4")]
		[UnclampedRange(0f, 1f)]
		public float thresholdSoftness; // 0x34
		[Header("\u661F\u661F\u5BC6\u5EA6")]
		[UnclampedRange(0f, 1f)]
		public float starsDensity; // 0x38
		[Header("\u661F\u661F\u66DD\u5149\u5EA6")]
		[UnclampedRange(0f, 1000f)]
		public float starsExposure; // 0x3C
		[Header("\u661F\u661F\u5927\u5C0F\u968F\u673A\u79CD\u5B50")]
		[UnclampedRange(0f, 1f)]
		public float brightnessRandomSeed; // 0x40
		[Header("\u661F\u661F\u989C\u8272\u968F\u673A\u79CD\u5B50")]
		[UnclampedRange(0f, 1f)]
		public float colorRandomSeed; // 0x44
		[Header("\u661F\u661F\u5206\u5E03\u968F\u673A\u79CD\u5B50")]
		[UnclampedRange(0f, 1f)]
		public float distributionRandomSeed; // 0x48
		[Header("\u661F\u7FA4Mask\u56FE")]
		public Texture skyBoxStarRangeMap; // 0x50
		[Header("\u661F\u7FA4Mask\u56FE\u65CB\u8F6C")]
		[UnclampedRange(0f, 360f)]
		public float skyBoxStarDensityMapRotation; // 0x58
		[Header("\u661F\u73AF\u5BF9\u661F\u661F\u7684\u906E\u853D\u6027")]
		[UnclampedRange(0f, 1000f)]
		public float starRingStarCoverage; // 0x5C
		[Header("\u4E91\u5BF9\u661F\u661F\u7684\u906E\u853D\u6027")]
		[UnclampedRange(0f, 1f)]
		public float cloudRingStarCoverage; // 0x60
		[Header("\u661F\u7FA4Mask\u88C1\u526A\u9608\u503C")]
		[UnclampedRange(0f, 1f)]
		public float starDensityMapMaskThres; // 0x64
		[Header("\u661F\u7FA4Mask\u56FEDebugMode")]
		public DebugMode debugMode; // 0x68
		[Header("\u7ED8\u5236\u661F\u4E91")]
		public bool enableNebula; // 0x6C
		[Header("\u661F\u4E91\u8D34\u56FE")]
		public Texture nebulaMap; // 0x70
		[Header("\u661F\u4E91\u8D34\u56FE\u989C\u8272")]
		public UnityEngine.Color nebulaTint; // 0x78
		[Header("\u661F\u4E91\u8D34\u56FE\u65CB\u8F6C")]
		[UnclampedRange(0f, 360f)]
		public float nebulaMapRotation; // 0x88
		[Header("\u661F\u4E91\u5BF9\u661F\u661F\u7684\u906E\u853D\u6027")]
		[UnclampedRange(-5f, 10f)]
		public float nebulaStarConverage; // 0x8C
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x90
		public static HGStarConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183B72750-0x0000000183B727B0 0x00000001831D5270-0x00000001831D52B0
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGStarConfig::get_active(HGStarConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1403 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x57B )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[29].vtable.GetHashCode.method )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1403, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_572(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGStarConfig::set_active(HGStarConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1404, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1404, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_573(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Nested types
		public enum DebugMode // TypeDefIndex: 37624
		{
			Material = 0,
			RChannel = 1,
			GChannel = 2,
			BChannel = 3,
			RGBChannel = 4
		}
	
		// Constructors
		public HGStarConfig(bool active) : this() {
			enableStars = default;
			starsTilling = default;
			starsFlickerSpeed = default;
			minMaxRange = default;
			starsTint = default;
			starsTint1 = default;
			thresholdSoftness = default;
			starsDensity = default;
			starsExposure = default;
			brightnessRandomSeed = default;
			colorRandomSeed = default;
			distributionRandomSeed = default;
			skyBoxStarRangeMap = default;
			skyBoxStarDensityMapRotation = default;
			starRingStarCoverage = default;
			cloudRingStarCoverage = default;
			starDensityMapMaskThres = default;
			debugMode = default;
			enableNebula = default;
			nebulaMap = default;
			nebulaTint = default;
			nebulaMapRotation = default;
			nebulaStarConverage = default;
			m_active = default;
		} // 0x0000000184A1BD00-0x0000000184A1BDD0
		// HGStarConfig(Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGStarConfig::HGStarConfig(HGStarConfig *this, bool active, MethodInfo *method)
		{
		  __int64 v3; // r9
		  MethodInfo *v4; // rdx
		  Vector4 *one; // rax
		  __int64 v6; // r9
		  MethodInfo *v7; // rdx
		  Vector4 v8; // xmm1
		  __int64 v9; // r9
		  __int64 v10; // r10
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  __int64 v13; // r9
		  char v14; // r10
		  MethodInfo *v15; // rdx
		  Vector4 v16; // xmm1
		  __int64 v17; // r9
		  __int64 v18; // r10
		  Vector4 v19; // [rsp+20h] [rbp-18h] BYREF
		
		  this->m_active = 0;
		  this->enableStars = 0;
		  this->skyBoxStarRangeMap = 0LL;
		  this->starsTilling = 1.0;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&this->skyBoxStarRangeMap,
		    (HGRuntimeGrassQuery_Node *)active,
		    (HGRuntimeGrassQuery_Node *)method,
		    (Int32__Array **)this,
		    *(MethodInfo **)&v19.x);
		  *(_DWORD *)(v3 + 8) = 1036831949;
		  one = UnityEngine::Vector4::get_one(&v19, v4);
		  *(Vector4 *)(v6 + 20) = *one;
		  v8 = *UnityEngine::Vector4::get_one(&v19, v7);
		  *(_DWORD *)(v9 + 60) = 1120403456;
		  *(_DWORD *)(v9 + 56) = v10;
		  *(Vector4 *)(v9 + 36) = v8;
		  *(_QWORD *)(v9 + 88) = v10;
		  *(_DWORD *)(v9 + 96) = 1065353216;
		  *(_DWORD *)(v9 + 104) = v10;
		  *(_QWORD *)(v9 + 112) = v10;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)(v9 + 112), v11, v12, (Int32__Array **)v9, *(MethodInfo **)&v19.x);
		  *(_BYTE *)(v13 + 108) = v14;
		  v16 = *UnityEngine::Vector4::get_one(&v19, v15);
		  *(_DWORD *)(v17 + 140) = 1036831949;
		  *(_DWORD *)(v17 + 136) = v18;
		  *(Vector4 *)(v17 + 120) = v16;
		  *(_DWORD *)(v17 + 12) = 1120403456;
		  *(_DWORD *)(v17 + 16) = 1148846080;
		  *(_DWORD *)(v17 + 52) = 1056964608;
		  *(_QWORD *)(v17 + 64) = v18;
		  *(_DWORD *)(v17 + 72) = v18;
		  *(_DWORD *)(v17 + 100) = v18;
		}
		
		static HGStarConfig() {
			defaultConfig = default;
		} // 0x0000000184A1BBE0-0x0000000184A1BD00
		// HGStarConfig()
		void HG::Rendering::Runtime::HGStarConfig::cctor(MethodInfo *method)
		{
		  __int128 v1; // xmm2
		  __int128 v2; // xmm3
		  HGStarConfig__StaticFields *static_fields; // rcx
		  __int128 v4; // xmm4
		  __int128 v5; // xmm5
		  __int128 v6; // xmm6
		  __int128 v7; // xmm7
		  __int128 v8; // xmm8
		  __int128 v9; // xmm9
		  __int64 v10; // xmm0_8
		  HGRuntimeGrassQuery_Node *v11; // rdx
		  HGRuntimeGrassQuery_Node *v12; // r8
		  Int32__Array **v13; // r9
		  HGStarConfig v14; // [rsp+20h] [rbp-E8h] BYREF
		
		  memset(&v14, 0, sizeof(v14));
		  HG::Rendering::Runtime::HGStarConfig::HGStarConfig(&v14, 0, 0LL);
		  v1 = *(_OWORD *)&v14.minMaxRange.y;
		  v2 = *(_OWORD *)&v14.starsTint.a;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGStarConfig->static_fields;
		  v4 = *(_OWORD *)&v14.starsTint1.a;
		  v5 = *(_OWORD *)&v14.brightnessRandomSeed;
		  v6 = *(_OWORD *)&v14.skyBoxStarRangeMap;
		  v7 = *(_OWORD *)&v14.cloudRingStarCoverage;
		  v8 = *(_OWORD *)&v14.nebulaMap;
		  v9 = *(_OWORD *)&v14.nebulaTint.b;
		  v10 = *(_QWORD *)&v14.m_active;
		  *(_OWORD *)&static_fields->defaultConfig.enableStars = *(_OWORD *)&v14.enableStars;
		  *(_OWORD *)&static_fields->defaultConfig.minMaxRange.y = v1;
		  *(_OWORD *)&static_fields->defaultConfig.starsTint.a = v2;
		  *(_OWORD *)&static_fields->defaultConfig.starsTint1.a = v4;
		  *(_OWORD *)&static_fields->defaultConfig.brightnessRandomSeed = v5;
		  *(_OWORD *)&static_fields->defaultConfig.skyBoxStarRangeMap = v6;
		  *(_OWORD *)&static_fields->defaultConfig.cloudRingStarCoverage = v7;
		  *(_OWORD *)&static_fields->defaultConfig.nebulaMap = v8;
		  *(_OWORD *)&static_fields->defaultConfig.nebulaTint.b = v9;
		  *(_QWORD *)&static_fields->defaultConfig.m_active = v10;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGStarConfig->static_fields->defaultConfig.skyBoxStarRangeMap,
		    v11,
		    v12,
		    v13,
		    *(MethodInfo **)&v14.enableStars);
		}
		
	
		// Methods
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
	}
}
