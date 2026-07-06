using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class HGWindUtils
	{
		public HGWindUtils()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		public static float WindSpeedToBeaufortWindScale(float windSpeed)
		{
			// // Single WindSpeedToBeaufortWindScale(Single)
			// float HG::Rendering::Runtime::HGWindUtils::WindSpeedToBeaufortWindScale(float windSpeed, MethodInfo *method)
			// {
			//   float v2; // xmm2_4
			//   System::MathF *v4; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			// 
			//   if ( !byte_18D919DD8 )
			//   {
			//     sub_18003C530(&TypeInfo::System::MathF);
			//     byte_18D919DD8 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1450, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1450, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_59((ILFixDynamicMethodWrapper_7 *)Patch, windSpeed, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::System::MathF);
			//     System::MathF::Pow(v4, 0.62772799, v2);
			//     return (float)(windSpeed * 1.2355) + (float)(windSpeed * 0.017746501);
			//   }
			// }
			// 
			return 0f;
		}

		public static Vector3 WindEulerAngleToDirection(float horizontalAngle, float verticalAngle)
		{
			// // Vector3 WindEulerAngleToDirection(Single, Single)
			// Vector3 *HG::Rendering::Runtime::HGWindUtils::WindEulerAngleToDirection(
			//         Vector3 *__return_ptr retstr,
			//         float horizontalAngle,
			//         float verticalAngle,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rax
			//   Quaternion *v6; // r8
			//   Quaternion v7; // xmm0
			//   __int64 v8; // xmm3_8
			//   Vector3 *v9; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   __int64 v13; // xmm0_8
			//   float z; // eax
			//   Vector3 v16; // [rsp+30h] [rbp-58h] BYREF
			//   Vector3 v17; // [rsp+40h] [rbp-48h] BYREF
			//   Quaternion v18; // [rsp+50h] [rbp-38h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1451, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1451, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v12, v11);
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_547(&v17, Patch, horizontalAngle, verticalAngle, 0LL);
			//   }
			//   else
			//   {
			//     sub_182504D40(&v18);
			//     v5 = sub_1851404A4(&v17, _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0LL).m128_u64[0]);
			//     v7 = *v6;
			//     v8 = *(_QWORD *)v5;
			//     LODWORD(v5) = *(_DWORD *)(v5 + 8);
			//     *(_QWORD *)&v16.x = v8;
			//     LODWORD(v16.z) = v5;
			//     v18 = v7;
			//     v9 = UnityEngine::Quaternion::op_Multiply(&v17, &v18, &v16, 0LL);
			//   }
			//   v13 = *(_QWORD *)&v9.x;
			//   z = v9.z;
			//   *(_QWORD *)&retstr.x = v13;
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public const float MAX_SYSTEM_WIND_SPEED = 30f;
	}
}
