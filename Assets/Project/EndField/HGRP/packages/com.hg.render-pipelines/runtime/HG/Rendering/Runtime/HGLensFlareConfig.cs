using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HGLensFlareConfig : IEnvConfig
	{
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_defaultValue()
				// bool HG::Rendering::Runtime::SettingParameter<bool>::get_defaultValue(
				//         SettingParameter_1_System_Boolean_ *this,
				//         MethodInfo *method)
				// {
				//   return this.fields._defaultValue_k__BackingField;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_defaultValue(Boolean)
				// void HG::Rendering::Runtime::SettingParameter<bool>::set_defaultValue(
				//         SettingParameter_1_System_Boolean_ *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._defaultValue_k__BackingField = value;
				// }
				// 
			}
		}

		public HGLensFlareConfig(bool active)
		{
		}

		private void CopyOtherParameters(ref HGLensFlareConfig src)
		{
			// // Void CopyOtherParameters(HGLensFlareConfig ByRef)
			// void HG::Rendering::Runtime::HGLensFlareConfig::CopyOtherParameters(
			//         HGLensFlareConfig *this,
			//         HGLensFlareConfig *src,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1187, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1187, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_445(Patch, this, src, 0LL);
			//   }
			//   else
			//   {
			//     this.enable = src.enable;
			//     this.scale = src.scale;
			//     this.useOcclusion = src.useOcclusion;
			//     this.occlusionRadius = src.occlusionRadius;
			//     this.sampleCount = src.sampleCount;
			//     this.occlusionOffset = src.occlusionOffset;
			//     this.allowOffScreen = src.allowOffScreen;
			//   }
			// }
			// 
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		public LensFlareCommonSRP.SunSourceDirLightOverrideLensFlareData ToDirLightOverrideData()
		{
			// // LensFlareCommonSRP+SunSourceDirLightOverrideLensFlareData ToDirLightOverrideData()
			// LensFlareCommonSRP_SunSourceDirLightOverrideLensFlareData *HG::Rendering::Runtime::HGLensFlareConfig::ToDirLightOverrideData(
			//         LensFlareCommonSRP_SunSourceDirLightOverrideLensFlareData *__return_ptr retstr,
			//         HGLensFlareConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdi
			//   ILFixDynamicMethodWrapper_2__Array *v7; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   LensFlareCommonSRP_SunSourceDirLightOverrideLensFlareData *v11; // rax
			//   __int128 v12; // xmm1
			//   __m128 v13; // xmm0
			//   unsigned __int64 v14; // rdx
			//   signed __int64 v15; // rtt
			//   __m128 v16; // xmm2
			//   bool allowOffScreen; // al
			//   float scale; // xmm3_4
			//   float occlusionRadius; // xmm4_4
			//   float occlusionOffset; // xmm5_4
			//   __m128 v21; // xmm2
			//   __m128 v22; // xmm0
			//   __m128 v23; // xmm2
			//   LensFlareCommonSRP_SunSourceDirLightOverrideLensFlareData *result; // rax
			//   __int128 v25; // [rsp+20h] [rbp-68h] BYREF
			//   __m128 v26; // [rsp+30h] [rbp-58h]
			//   __m128 v27; // [rsp+40h] [rbp-48h]
			//   LensFlareCommonSRP_SunSourceDirLightOverrideLensFlareData v28; // [rsp+50h] [rbp-38h] BYREF
			// 
			//   v25 = 0LL;
			//   v26 = 0LL;
			//   v27 = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     sub_180B536AC(v5, this);
			//   if ( wrapperArray.max_length.size <= 1006 )
			//     goto LABEL_14;
			//   if ( !v5._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v5, this);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v7 = v5.static_fields.wrapperArray;
			//   if ( !v7 )
			//     sub_180B536AC(v5, this);
			//   if ( v7.max_length.size <= 0x3EEu )
			//     sub_180070270(v5, this);
			//   if ( v7[28].bounds )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1006, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_364(&v28, Patch, this, 0LL);
			//     v12 = *(_OWORD *)&v11.intensity;
			//     *(_OWORD *)&retstr.enable = *(_OWORD *)&v11.enable;
			//     v13 = *(__m128 *)&v11.sampleCount;
			//     *(_OWORD *)&retstr.intensity = v12;
			//   }
			//   else
			//   {
			// LABEL_14:
			//     LOBYTE(v25) = this.enable;
			//     *((_QWORD *)&v25 + 1) = this.lensFlareData;
			//     if ( dword_18D8E43F8 )
			//     {
			//       v14 = ((((unsigned __int64)&v25 + 8) >> 12) & 0x1FFFFF) >> 6;
			//       _m_prefetchw(&qword_18D6870D0[v14]);
			//       do
			//         v15 = qword_18D6870D0[v14];
			//       while ( v15 != _InterlockedCompareExchange64(
			//                        &qword_18D6870D0[v14],
			//                        v15 | (1LL << ((((unsigned __int64)&v25 + 8) >> 12) & 0x3F)),
			//                        v15) );
			//     }
			//     v26.m128_i8[8] = this.useOcclusion;
			//     v16 = v26;
			//     v27.m128_i32[0] = this.sampleCount;
			//     allowOffScreen = this.allowOffScreen;
			//     v16.m128_f32[0] = this.intensity;
			//     scale = this.scale;
			//     occlusionRadius = this.occlusionRadius;
			//     occlusionOffset = this.occlusionOffset;
			//     *(_OWORD *)&retstr.enable = v25;
			//     v27.m128_i8[8] = allowOffScreen;
			//     v21 = _mm_shuffle_ps(v16, v16, 225);
			//     v21.m128_f32[0] = scale;
			//     v22 = _mm_shuffle_ps(v27, v27, 225);
			//     v23 = _mm_shuffle_ps(v21, v21, 135);
			//     v22.m128_f32[0] = occlusionOffset;
			//     v23.m128_f32[0] = occlusionRadius;
			//     v13 = _mm_shuffle_ps(v22, v22, 225);
			//     *(__m128 *)&retstr.intensity = _mm_shuffle_ps(v23, v23, 57);
			//   }
			//   result = retstr;
			//   *(__m128 *)&retstr.sampleCount = v13;
			//   return result;
			// }
			// 
			return null;
		}

		[Header("启动镜头光晕")]
		public bool enable;

		[Header("镜头光晕Asset资源")]
		public LensFlareDataSRP lensFlareData;

		[Header("强度")]
		[UnclampedRange(0f, 100f)]
		public float intensity;

		[Header("大小")]
		[UnclampedRange(0f, 100f)]
		public float scale;

		[Header("启动遮挡")]
		public bool useOcclusion;

		[Header("遮挡检测半径(m)")]
		[UnclampedRange(0f, 10f)]
		public float occlusionRadius;

		[Range(1f, 32f)]
		[Header("遮挡检测采样数量")]
		public uint sampleCount;

		[Header("遮挡检测位置到相机距离的偏移值")]
		[UnclampedRange(0f, 100f)]
		public float occlusionOffset;

		[Header("离屏渲染")]
		public bool allowOffScreen;

		[HideInInspector]
		[SerializeField]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGLensFlareConfig defaultConfig;
	}
}
