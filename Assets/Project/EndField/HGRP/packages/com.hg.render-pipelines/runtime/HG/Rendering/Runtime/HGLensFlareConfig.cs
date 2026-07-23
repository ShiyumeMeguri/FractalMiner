using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGLensFlareConfig : IEnvConfig // TypeDefIndex: 37609
	{
		// Fields
		[Header("\u542F\u52A8\u955C\u5934\u5149\u6655")]
		public bool enable; // 0x00
		[Header("\u955C\u5934\u5149\u6655Asset\u8D44\u6E90")]
		public LensFlareDataSRP lensFlareData; // 0x08
		[Header("\u5F3A\u5EA6")]
		[UnclampedRange(0f, 100f)]
		public float intensity; // 0x10
		[Header("\u5927\u5C0F")]
		[UnclampedRange(0f, 100f)]
		public float scale; // 0x14
		[Header("\u542F\u52A8\u906E\u6321")]
		public bool useOcclusion; // 0x18
		[Header("\u906E\u6321\u68C0\u6D4B\u534A\u5F84(m)")]
		[UnclampedRange(0f, 10f)]
		public float occlusionRadius; // 0x1C
		[Header("\u906E\u6321\u68C0\u6D4B\u91C7\u6837\u6570\u91CF")]
		[Range(1f, 32f)]
		public uint sampleCount; // 0x20
		[Header("\u906E\u6321\u68C0\u6D4B\u4F4D\u7F6E\u5230\u76F8\u673A\u8DDD\u79BB\u7684\u504F\u79FB\u503C")]
		[UnclampedRange(0f, 100f)]
		public float occlusionOffset; // 0x24
		[Header("\u79BB\u5C4F\u6E32\u67D3")]
		public bool allowOffScreen; // 0x28
		[HideInInspector]
		[SerializeField]
		private bool m_active; // 0x29
		public static HGLensFlareConfig defaultConfig; // 0x00
	
		// Properties
		public bool active { get => default; set {} } // 0x0000000183B83550-0x0000000183B835B0 0x00000001831D50B0-0x00000001831D50F0
		// Boolean get_active()
		bool HG::Rendering::Runtime::HGLensFlareConfig::get_active(HGLensFlareConfig *this, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 1382 )
		    return this->m_active;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x566 )
		    sub_1800D2AB0(v3, method);
		  if ( !v3[29].static_fields )
		    return this->m_active;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1382, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, method);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_556(Patch, this, 0LL);
		}
		

		// Void set_active(Boolean)
		void HG::Rendering::Runtime::HGLensFlareConfig::set_active(HGLensFlareConfig *this, bool value, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1383, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1383, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_557(Patch, this, value, 0LL);
		  }
		  else
		  {
		    this->m_active = value;
		  }
		}
		
	
		// Constructors
		public HGLensFlareConfig(bool active) : this() {
			enable = default;
			lensFlareData = default;
			intensity = default;
			scale = default;
			useOcclusion = default;
			occlusionRadius = default;
			sampleCount = default;
			occlusionOffset = default;
			allowOffScreen = default;
			m_active = default;
		} // 0x0000000184CE1640-0x0000000184CE16A0
		// HGLensFlareConfig(Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGLensFlareConfig::HGLensFlareConfig(
		        HGLensFlareConfig *this,
		        bool active,
		        MethodInfo *method)
		{
		  __int64 v3; // r9
		  MethodInfo *v4; // [rsp+20h] [rbp-8h]
		
		  this->m_active = active;
		  this->enable = 0;
		  this->lensFlareData = 0LL;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&this->lensFlareData,
		    (Type *)active,
		    (PropertyInfo_1 *)method,
		    (Int32__Array **)this,
		    v4);
		  *(_DWORD *)(v3 + 16) = 1065353216;
		  *(_DWORD *)(v3 + 20) = 1065353216;
		  *(_BYTE *)(v3 + 24) = 0;
		  *(_DWORD *)(v3 + 28) = 1036831949;
		  *(_DWORD *)(v3 + 32) = 1;
		  *(_DWORD *)(v3 + 36) = 1028443341;
		  *(_BYTE *)(v3 + 40) = 0;
		}
		
		static HGLensFlareConfig() {
			defaultConfig = default;
		} // 0x0000000184CE15A0-0x0000000184CE1640
		// HGLensFlareConfig()
		void HG::Rendering::Runtime::HGLensFlareConfig::cctor(MethodInfo *method)
		{
		  Type *v1; // rdx
		  PropertyInfo_1 *v2; // r8
		  Int32__Array **v3; // r9
		  __int128 v4; // xmm1
		  HGLensFlareConfig__StaticFields *static_fields; // rcx
		  __int128 v6; // xmm2
		  Type *v7; // rdx
		  PropertyInfo_1 *v8; // r8
		  Int32__Array **v9; // r9
		  __int128 v10; // [rsp+20h] [rbp-38h] BYREF
		  __int128 v11; // [rsp+30h] [rbp-28h]
		  __int128 v12; // [rsp+40h] [rbp-18h]
		
		  v10 = 0LL;
		  v11 = 0LL;
		  v12 = 0LL;
		  sub_18002D1B0((SingleFieldAccessor *)((char *)&v10 + 8), v1, v2, v3, (MethodInfo *)v10);
		  *(_QWORD *)&v11 = 0x3F8000003F800000LL;
		  BYTE8(v11) = 0;
		  HIDWORD(v11) = 1036831949;
		  v4 = v11;
		  *(_QWORD *)&v12 = 0x3D4CCCCD00000001LL;
		  BYTE8(v12) = 0;
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig->static_fields;
		  v6 = v12;
		  *(_OWORD *)&static_fields->defaultConfig.enable = v10;
		  *(_OWORD *)&static_fields->defaultConfig.intensity = v4;
		  *(_OWORD *)&static_fields->defaultConfig.sampleCount = v6;
		  sub_18002D1B0(
		    (SingleFieldAccessor *)&TypeInfo::HG::Rendering::Runtime::HGLensFlareConfig->static_fields->defaultConfig.lensFlareData,
		    v7,
		    v8,
		    v9,
		    (MethodInfo *)v10);
		}
		
	
		// Methods
		private void CopyOtherParameters(ref HGLensFlareConfig src) {} // 0x0000000189CE4174-0x0000000189CE41F4
		// Void CopyOtherParameters(HGLensFlareConfig ByRef)
		void HG::Rendering::Runtime::HGLensFlareConfig::CopyOtherParameters(
		        HGLensFlareConfig *this,
		        HGLensFlareConfig *src,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1384, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1384, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_558(Patch, this, src, 0LL);
		  }
		  else
		  {
		    this->enable = src->enable;
		    this->scale = src->scale;
		    this->useOcclusion = src->useOcclusion;
		    this->occlusionRadius = src->occlusionRadius;
		    this->sampleCount = src->sampleCount;
		    this->occlusionOffset = src->occlusionOffset;
		    this->allowOffScreen = src->allowOffScreen;
		  }
		}
		
		public void Lerp<T>(ref ref T cSrc, ref ref T cDst, float t)
			where T : struct, IEnvConfig {}
		public LensFlareCommonSRP.SunSourceDirLightOverrideLensFlareData ToDirLightOverrideData() => default; // 0x0000000183C64260-0x0000000183C64430
		// LensFlareCommonSRP+SunSourceDirLightOverrideLensFlareData ToDirLightOverrideData()
		LensFlareCommonSRP_SunSourceDirLightOverrideLensFlareData *HG::Rendering::Runtime::HGLensFlareConfig::ToDirLightOverrideData(
		        LensFlareCommonSRP_SunSourceDirLightOverrideLensFlareData *__return_ptr retstr,
		        HGLensFlareConfig *this,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
		  ILFixDynamicMethodWrapper_2__Array *v7; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  LensFlareCommonSRP_SunSourceDirLightOverrideLensFlareData *v11; // rax
		  __int128 v12; // xmm1
		  __m128 v13; // xmm0
		  unsigned __int64 v14; // rdx
		  signed __int64 v15; // rtt
		  __m128 v16; // xmm2
		  bool allowOffScreen; // al
		  float scale; // xmm3_4
		  float occlusionRadius; // xmm4_4
		  float occlusionOffset; // xmm5_4
		  __m128 v21; // xmm2
		  __m128 v22; // xmm0
		  __m128 v23; // xmm2
		  LensFlareCommonSRP_SunSourceDirLightOverrideLensFlareData *result; // rax
		  __int128 v25; // [rsp+20h] [rbp-68h] BYREF
		  __m128 v26; // [rsp+30h] [rbp-58h]
		  __m128 v27; // [rsp+40h] [rbp-48h]
		  LensFlareCommonSRP_SunSourceDirLightOverrideLensFlareData v28; // [rsp+50h] [rbp-38h] BYREF
		
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v25 = 0LL;
		  v26 = 0LL;
		  v27 = 0LL;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    sub_1800D8260(v4, this);
		  if ( wrapperArray->max_length.size <= 1116 )
		    goto LABEL_12;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v7 = v4->static_fields->wrapperArray;
		  if ( !v7 )
		    sub_1800D8260(v4, this);
		  if ( v7->max_length.size <= 0x45Cu )
		    sub_1800D2AB0(v4, this);
		  if ( v7[31].vector[0] )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1116, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_423(&v28, Patch, this, 0LL);
		    v12 = *(_OWORD *)&v11->intensity;
		    *(_OWORD *)&retstr->enable = *(_OWORD *)&v11->enable;
		    v13 = *(__m128 *)&v11->sampleCount;
		    *(_OWORD *)&retstr->intensity = v12;
		  }
		  else
		  {
		LABEL_12:
		    LOBYTE(v25) = this->enable;
		    *((_QWORD *)&v25 + 1) = this->lensFlareData;
		    if ( dword_18F35FD08 )
		    {
		      v14 = ((((unsigned __int64)&v25 + 8) >> 12) & 0x1FFFFF) >> 6;
		      _m_prefetchw(&qword_18F103690[v14]);
		      do
		        v15 = qword_18F103690[v14];
		      while ( v15 != _InterlockedCompareExchange64(
		                       &qword_18F103690[v14],
		                       v15 | (1LL << ((((unsigned __int64)&v25 + 8) >> 12) & 0x3F)),
		                       v15) );
		    }
		    v26.m128_i8[8] = this->useOcclusion;
		    v16 = v26;
		    v27.m128_i32[0] = this->sampleCount;
		    allowOffScreen = this->allowOffScreen;
		    v16.m128_f32[0] = this->intensity;
		    scale = this->scale;
		    occlusionRadius = this->occlusionRadius;
		    occlusionOffset = this->occlusionOffset;
		    *(_OWORD *)&retstr->enable = v25;
		    v27.m128_i8[8] = allowOffScreen;
		    v21 = _mm_shuffle_ps(v16, v16, 225);
		    v21.m128_f32[0] = scale;
		    v22 = _mm_shuffle_ps(v27, v27, 225);
		    v23 = _mm_shuffle_ps(v21, v21, 135);
		    v22.m128_f32[0] = occlusionOffset;
		    v23.m128_f32[0] = occlusionRadius;
		    v13 = _mm_shuffle_ps(v22, v22, 225);
		    *(__m128 *)&retstr->intensity = _mm_shuffle_ps(v23, v23, 57);
		  }
		  result = retstr;
		  *(__m128 *)&retstr->sampleCount = v13;
		  return result;
		}
		
	}
}
