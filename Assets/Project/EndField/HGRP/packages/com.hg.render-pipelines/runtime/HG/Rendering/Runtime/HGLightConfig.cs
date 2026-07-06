using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 352)]
	public struct HGLightConfig : IEnvConfig
	{
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x000025D8 File Offset: 0x000007D8
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x000025D0 File Offset: 0x000007D0
		public bool active
		{
			get
			{
				// // Boolean get_fullyExited()
				// bool UnityEngine::EventSystems::PointerEventData::get_fullyExited(PointerEventData *this, MethodInfo *method)
				// {
				//   return this.fields._fullyExited_k__BackingField;
				// }
				// 
				return default(bool);
			}
			set
			{
				// // Void set_fullyExited(Boolean)
				// void UnityEngine::EventSystems::PointerEventData::set_fullyExited(
				//         PointerEventData *this,
				//         bool value,
				//         MethodInfo *method)
				// {
				//   this.fields._fullyExited_k__BackingField = value;
				// }
				// 
			}
		}

		private HGLightConfig(bool active)
		{
			// // HGLightConfig(Boolean)
			// void HG::Rendering::Runtime::HGLightConfig::HGLightConfig(HGLightConfig *this, bool active, MethodInfo *method)
			// {
			//   Color si128; // xmm0
			//   Vector4 v5; // xmm1
			//   MethodInfo *v6; // rdx
			//   Quaternion *identity; // rax
			//   Vector4 v8; // xmm3
			//   void (__fastcall *v9)(unsigned __int64 *, Vector4 *, unsigned __int64 *, __int128 *); // rax
			//   __int128 v10; // xmm1
			//   __int128 v11; // xmm0
			//   __int128 v12; // xmm1
			//   MethodInfo *v13; // rdx
			//   MethodInfo *v14; // rdx
			//   MethodInfo *v15; // rdx
			//   MethodInfo *v16; // rdx
			//   __int64 v17; // rax
			//   unsigned __int64 v18; // [rsp+30h] [rbp-39h] BYREF
			//   int v19; // [rsp+38h] [rbp-31h]
			//   unsigned __int64 v20; // [rsp+40h] [rbp-29h] BYREF
			//   int v21; // [rsp+48h] [rbp-21h]
			//   Vector4 v22; // [rsp+50h] [rbp-19h] BYREF
			//   Quaternion v23; // [rsp+60h] [rbp-9h] BYREF
			//   __int128 v24; // [rsp+70h] [rbp+7h] BYREF
			//   __int128 v25; // [rsp+80h] [rbp+17h]
			//   __int128 v26; // [rsp+90h] [rbp+27h]
			//   __int128 v27; // [rsp+A0h] [rbp+37h]
			// 
			//   si128 = (Color)_mm_load_si128((const __m128i *)&xmmword_18A357A70);
			//   this.m_active = active;
			//   this.directColor = si128;
			//   this.directColorMode = 0;
			//   v5 = *UnityEngine::Vector4::get_one(&v22, 0LL);
			//   this.directColorTemperature = 5500.0;
			//   this.directLux = 120000.0;
			//   this.directCustomColor = (Color)v5;
			//   this.directEV100 = 12.5;
			//   *(_QWORD *)&this.directSpecularIntensity = 1065353216LL;
			//   this.directPitchYaw = (Vector2)v6;
			//   this.indirectDiffuseFactor = 1.0;
			//   *(_QWORD *)&this.indirectSpecularFactor = 1065353216LL;
			//   this.atmospherePitchYawMode = (int)v6;
			//   this.atmospherePitchYaw = (Vector2)1107296256LL;
			//   this.lightShaftPitchYawMode = (int)v6;
			//   this.lightShaftPitchYaw = (Vector2)1107296256LL;
			//   this.sunDiscPitchYawMode = (int)v6;
			//   this.sunDiscPitchYaw.x = 30.0;
			//   *(_QWORD *)&this.sunDiscPitchYaw.y = 1141309440LL;
			//   this.lensFlarePitchYaw = (Vector2)1107296256LL;
			//   this.cloudShadowPitchYawMode = 1;
			//   this.cloudShadowPitchYaw = (Vector2)1119092736LL;
			//   this.heightFogDirectionalInscatteringPitchYawMode = (int)v6;
			//   this.heightFogDirectionalInscatteringPitchYaw = (Vector2)1119092736LL;
			//   this.preExposure = 0.00014386119;
			//   this.directIntensity = 17.26335;
			//   this.directIntensityDividePi = 5.4950938;
			//   identity = UnityEngine::Quaternion::get_identity(&v23, v6);
			//   v8 = (Vector4)*identity;
			//   this.rotationDirect = *identity;
			//   *(_QWORD *)&this.forwardDirect.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   this.forwardDirect.z = 1.0;
			//   v9 = (void (__fastcall *)(unsigned __int64 *, Vector4 *, unsigned __int64 *, __int128 *))qword_18D8F4BC8;
			//   v18 = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
			//   v20 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//   v19 = 1065353216;
			//   v21 = 0;
			//   v22 = v8;
			//   v24 = 0LL;
			//   v25 = 0LL;
			//   v26 = 0LL;
			//   v27 = 0LL;
			//   if ( !qword_18D8F4BC8 )
			//   {
			//     v9 = (void (__fastcall *)(unsigned __int64 *, Vector4 *, unsigned __int64 *, __int128 *))il2cpp_resolve_icall_0(
			//                                                                                                "UnityEngine.Matrix4x4::TR"
			//                                                                                                "S_Injected(UnityEngine.Ve"
			//                                                                                                "ctor3&,UnityEngine.Quater"
			//                                                                                                "nion&,UnityEngine.Vector3"
			//                                                                                                "&,UnityEngine.Matrix4x4&)");
			//     if ( !v9 )
			//     {
			//       v17 = sub_1802DBBE8(
			//               "UnityEngine.Matrix4x4::TRS_Injected(UnityEngine.Vector3&,UnityEngine.Quaternion&,UnityEngine.Vector3&,Unit"
			//               "yEngine.Matrix4x4&)");
			//       sub_18000F750(v17, 0LL);
			//     }
			//     qword_18D8F4BC8 = (__int64)v9;
			//   }
			//   v9(&v20, &v22, &v18, &v24);
			//   v10 = v25;
			//   *(_OWORD *)&this.localToWorld.m00 = v24;
			//   v11 = v26;
			//   *(_OWORD *)&this.localToWorld.m01 = v10;
			//   v12 = v27;
			//   *(_OWORD *)&this.localToWorld.m02 = v11;
			//   *(_OWORD *)&this.localToWorld.m03 = v12;
			//   this.rotationAtmosphere = *UnityEngine::Quaternion::get_identity(&v23, v13);
			//   this.rotationLightShaft = *UnityEngine::Quaternion::get_identity(&v23, v14);
			//   this.rotationSunDisc = *UnityEngine::Quaternion::get_identity(&v23, v15);
			//   this.rotationLensFlare = *UnityEngine::Quaternion::get_identity(&v23, v16);
			//   this.rotationCloudShadow = *(Quaternion *)sub_182504D40(&v23);
			//   this.rotationHeightFogDirectionalInscattering = *(Quaternion *)sub_182504D40(&v23);
			// }
			// 
		}

		public Color UpdateDirectFinalColor()
		{
			// // Color UpdateDirectFinalColor()
			// Color *HG::Rendering::Runtime::HGLightConfig::UpdateDirectFinalColor(
			//         Color *__return_ptr retstr,
			//         HGLightConfig *this,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v5; // r9
			//   __m128i si128; // xmm6
			//   Vector4 v7; // xmm0
			//   MethodInfo *v8; // r9
			//   Vector4 *v9; // rax
			//   float directIntensityDividePi; // xmm2_4
			//   MethodInfo *v11; // r9
			//   Vector4 *v12; // rax
			//   float v13; // xmm2_4
			//   Color v14; // xmm6
			//   MethodInfo *v15; // r8
			//   Color *gamma; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v18; // rdx
			//   __int64 v19; // rcx
			//   Color v21; // [rsp+20h] [rbp-40h] BYREF
			//   __m128i directColor; // [rsp+30h] [rbp-30h] BYREF
			//   Vector4 v23; // [rsp+40h] [rbp-20h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1188, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1188, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v19, v18);
			//     gamma = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_446((Color *)&v23, Patch, this, 0LL);
			//     goto LABEL_11;
			//   }
			//   if ( UnityEngine::Rendering::GraphicsSettings::get_lightsUseLinearIntensity(0LL) )
			//   {
			//     si128 = _mm_load_si128((const __m128i *)&xmmword_18A357460);
			//     v7 = *(Vector4 *)sub_182F8C840(&directColor, this);
			//     directColor = si128;
			//     v21 = (Color)v7;
			//     v9 = UnityEngine::Vector4::Scale(&v23, (Vector4 *)&directColor, (Vector4 *)&v21, v8);
			//     directIntensityDividePi = this.directIntensityDividePi;
			//     directColor = *(__m128i *)v9;
			//     v12 = UnityEngine::Vector4::op_Multiply(&v23, (Vector4 *)&directColor, directIntensityDividePi, v11);
			//   }
			//   else
			//   {
			//     v13 = this.directIntensityDividePi;
			//     directColor = (__m128i)this.directColor;
			//     directColor = *(__m128i *)UnityEngine::Vector4::op_Multiply(&v23, (Vector4 *)&directColor, v13, v5);
			//     v12 = (Vector4 *)sub_182F8C840(&v23, &directColor);
			//   }
			//   v14 = (Color)_mm_loadu_si128((const __m128i *)v12);
			//   v21 = v14;
			//   if ( UnityEngine::QualitySettings::get_activeColorSpace(0LL) == ColorSpace__Enum_Gamma )
			//   {
			//     gamma = UnityEngine::Color::get_gamma((Color *)&v23, &v21, v15);
			// LABEL_11:
			//     *retstr = *gamma;
			//     return retstr;
			//   }
			//   *retstr = v14;
			//   return retstr;
			// }
			// 
			return null;
		}

		public void Lerp<T>(ref T cSrc, ref T cDst, float t) where T : struct, IEnvConfig
		{
		}

		public LensFlareCommonSRP.SunSourceDirLightOverrideLightData ToDirLightOverrideData()
		{
			// // LensFlareCommonSRP+SunSourceDirLightOverrideLightData ToDirLightOverrideData()
			// LensFlareCommonSRP_SunSourceDirLightOverrideLightData *HG::Rendering::Runtime::HGLightConfig::ToDirLightOverrideData(
			//         LensFlareCommonSRP_SunSourceDirLightOverrideLightData *__return_ptr retstr,
			//         HGLightConfig *this,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rax
			//   ILFixDynamicMethodWrapper_2__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   Quaternion rotationLensFlare; // xmm0
			//   __m128i directColor; // xmm2
			//   double v10; // xmm1_8
			//   ILFixDynamicMethodWrapper_2__Array *v12; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   LensFlareCommonSRP_SunSourceDirLightOverrideLightData *v14; // rax
			//   __int128 v15; // xmm1
			//   __int64 v16; // xmm0_8
			//   LensFlareCommonSRP_SunSourceDirLightOverrideLightData v17; // [rsp+20h] [rbp-38h] BYREF
			// 
			//   memset(&v17, 0, sizeof(v17));
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
			//   static_fields = v5.static_fields;
			//   wrapperArray = static_fields.wrapperArray;
			//   if ( !static_fields.wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 1007 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     static_fields = v5.static_fields;
			//     v12 = static_fields.wrapperArray;
			//     if ( static_fields.wrapperArray )
			//     {
			//       if ( v12.max_length.size <= 0x3EFu )
			//         sub_180070270(static_fields, wrapperArray);
			//       if ( !v12[28].max_length.value )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1007, 0LL);
			//       if ( Patch )
			//       {
			//         v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_365(&v17, Patch, this, 0LL);
			//         v15 = *(_OWORD *)&v14.dirLightFoward.x;
			//         retstr.rotationLensFlare = v14.rotationLensFlare;
			//         v16 = *(_QWORD *)&v14.color.g;
			//         *(float *)&v14 = v14.color.a;
			//         *(_OWORD *)&retstr.dirLightFoward.x = v15;
			//         *(_QWORD *)&retstr.color.g = v16;
			//         LODWORD(retstr.color.a) = (_DWORD)v14;
			//         return retstr;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(static_fields, wrapperArray);
			//   }
			// LABEL_7:
			//   rotationLensFlare = this.rotationLensFlare;
			//   directColor = (__m128i)this.directColor;
			//   v17.dirLightFoward.z = this.forwardDirect.z;
			//   v10 = *(double *)&this.forwardDirect.x;
			//   retstr.rotationLensFlare = rotationLensFlare;
			//   v17.color = (Color)directColor;
			//   *(_QWORD *)&rotationLensFlare.z = *(_QWORD *)&v17.dirLightFoward.z;
			//   *(double *)&rotationLensFlare.x = v10;
			//   *(Quaternion *)&retstr.dirLightFoward.x = rotationLensFlare;
			//   *(_QWORD *)&retstr.color.g = *(_QWORD *)&v17.color.g;
			//   LODWORD(retstr.color.a) = _mm_cvtsi128_si32(_mm_srli_si128(directColor, 12));
			//   return retstr;
			// }
			// 
			return null;
		}

		[Header("直接光 - 颜色")]
		[SerializeField]
		public Color directColor;

		[Header("直接光 - 颜色模式")]
		[SerializeField]
		public HGLightConfig.ColorMode directColorMode;

		public Color directCustomColor;

		[Range(1000f, 15000f)]
		public float directColorTemperature;

		[UnclampedRangeExponential(0f, 200000f, 3f)]
		[Header("直接光 - 照度")]
		public float directLux;

		[Header("直接光 - 预曝光 EV100")]
		[UnclampedRange(-4f, 20f)]
		public float directEV100;

		[UnclampedRange(0f, 1f)]
		[Header("直接光 - 高光强度")]
		public float directSpecularIntensity;

		[UnclampedRange(0f, 2f)]
		[Header("直接光 - 高光范围")]
		public float directSoftSourceRadius;

		[Header("直接光 - Pitch Yaw")]
		public Vector2 directPitchYaw;

		[UnclampedRange(0f, 5f)]
		[Header("间接光 - Diffuse 系数")]
		public float indirectDiffuseFactor;

		[UnclampedRange(0f, 5f)]
		[Header("间接光 - Specular 系数")]
		public float indirectSpecularFactor;

		public HGLightConfig.IndirectSpecularFactorType indirectSpecularFactorType;

		[Header("大气散射光源方向来源")]
		public HGLightConfig.PitchYawMode atmospherePitchYawMode;

		[Header("大气散射光源 Pitch Yaw")]
		public Vector2 atmospherePitchYaw;

		[Header("屏幕光束光源方向来源")]
		public HGLightConfig.PitchYawMode lightShaftPitchYawMode;

		[Header("屏幕光束光源 Pitch Yaw")]
		public Vector2 lightShaftPitchYaw;

		[Header("SunDisc散射光源方向来源")]
		public HGLightConfig.PitchYawMode sunDiscPitchYawMode;

		[Header("SunDisc大气散射光源 Pitch Yaw")]
		public Vector2 sunDiscPitchYaw;

		[Header("镜头光晕光源方向来源")]
		public HGLightConfig.PitchYawMode lensFlarePitchYawMode;

		[Header("镜头光晕光源方向来源 Pitch Yaw")]
		public Vector2 lensFlarePitchYaw;

		[Header("云影光源方向来源")]
		public HGLightConfig.PitchYawMode cloudShadowPitchYawMode;

		[Header("云影光源方向来源 Pitch Yaw")]
		public Vector2 cloudShadowPitchYaw;

		[Header("高度雾方向散射光源方向来源")]
		public HGLightConfig.PitchYawMode heightFogDirectionalInscatteringPitchYawMode;

		[Header("高度雾方向散射光源 Pitch Yaw")]
		public Vector2 heightFogDirectionalInscatteringPitchYaw;

		[HideInInspector]
		public float preExposure;

		[HideInInspector]
		public float directIntensity;

		[HideInInspector]
		public float directIntensityDividePi;

		[HideInInspector]
		public Quaternion rotationDirect;

		[HideInInspector]
		public Vector3 forwardDirect;

		[HideInInspector]
		public Matrix4x4 localToWorld;

		[HideInInspector]
		public Quaternion rotationAtmosphere;

		[HideInInspector]
		public Quaternion rotationLightShaft;

		[HideInInspector]
		public Quaternion rotationSunDisc;

		[HideInInspector]
		public Quaternion rotationLensFlare;

		[HideInInspector]
		public Quaternion rotationCloudShadow;

		[HideInInspector]
		public Quaternion rotationHeightFogDirectionalInscattering;

		[HideInInspector]
		[SerializeField]
		private bool m_active;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static HGLightConfig defaultConfig;

		public enum ColorMode
		{
			ColorTemperature,
			Custom,
			Mix
		}

		public enum PitchYawMode
		{
			DirLight,
			Custom
		}

		public enum IndirectSpecularFactorType
		{
			FollowDiffuse,
			Individual
		}
	}
}
