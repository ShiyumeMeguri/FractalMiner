using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGWindUtils // TypeDefIndex: 37714
	{
		// Fields
		public const float MAX_SYSTEM_WIND_SPEED = 30f; // Metadata: 0x02303080
	
		// Constructors
		public HGWindUtils() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
	
		// Methods
		public static float WindSpeedToBeaufortWindScale(float windSpeed) => default; // 0x0000000189CF8740-0x0000000189CF87C4
		// Single WindSpeedToBeaufortWindScale(Single)
		float HG::Rendering::Runtime::HGWindUtils::WindSpeedToBeaufortWindScale(float windSpeed, MethodInfo *method)
		{
		  float v2; // xmm2_4
		  System::MathF *v4; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1719, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1719, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, windSpeed, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::System::MathF);
		    System::MathF::Pow(v4, 0.62772799, v2);
		    return (float)(windSpeed * 1.2355) + (float)(windSpeed * 0.017746501);
		  }
		}
		
		public static Vector3 WindEulerAngleToDirection(float horizontalAngle, float verticalAngle) => default; // 0x0000000189CF8650-0x0000000189CF8740
		// Vector3 WindEulerAngleToDirection(Single, Single)
		Vector3 *HG::Rendering::Runtime::HGWindUtils::WindEulerAngleToDirection(
		        Vector3 *__return_ptr retstr,
		        float horizontalAngle,
		        float verticalAngle,
		        MethodInfo *method)
		{
		  __int64 v5; // rax
		  Quaternion *v6; // r8
		  Quaternion v7; // xmm0
		  __int64 v8; // xmm3_8
		  Vector3 *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  __int64 v13; // xmm0_8
		  float z; // eax
		  Vector3 v16; // [rsp+30h] [rbp-58h] BYREF
		  Vector3 v17; // [rsp+40h] [rbp-48h] BYREF
		  Quaternion v18; // [rsp+50h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1720, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1720, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v12, v11);
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_690(&v17, Patch, horizontalAngle, verticalAngle, 0LL);
		  }
		  else
		  {
		    sub_182FA5990(&v18);
		    v5 = sub_186351688(&v17, _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0LL).m128_u64[0]);
		    v7 = *v6;
		    v8 = *(_QWORD *)v5;
		    LODWORD(v5) = *(_DWORD *)(v5 + 8);
		    *(_QWORD *)&v16.x = v8;
		    LODWORD(v16.z) = v5;
		    v18 = v7;
		    v9 = UnityEngine::Quaternion::op_Multiply(&v17, &v18, &v16, 0LL);
		  }
		  v13 = *(_QWORD *)&v9->x;
		  z = v9->z;
		  *(_QWORD *)&retstr->x = v13;
		  retstr->z = z;
		  return retstr;
		}
		
	}
}
