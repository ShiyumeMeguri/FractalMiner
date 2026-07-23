using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class BurleyNormalizedDuffusion // TypeDefIndex: 38604
	{
		// Constructors
		public BurleyNormalizedDuffusion() {} // 0x00000001841E1670-0x00000001841E1680
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
		[IDTag(0)]
		public static float GetPerpendicularScalingFactor(float SurfaceAlbedo) => default; // 0x0000000189C13278-0x0000000189C13304
		// Single GetPerpendicularScalingFactor(Single)
		float HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetPerpendicularScalingFactor(
		        float SurfaceAlbedo,
		        MethodInfo *method)
		{
		  double v3; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3899, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3899, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, SurfaceAlbedo, 0LL);
		  }
		  else
		  {
		    v3 = sub_1803369A0();
		    return (float)(*(float *)&v3 * 7.0) + (float)(1.85 - SurfaceAlbedo);
		  }
		}
		
		[IDTag(1)]
		public static Vector3 GetPerpendicularScalingFactor(UnityEngine.Color SurfaceAlbedo) => default; // 0x0000000189C13304-0x0000000189C133C0
		// Vector3 GetPerpendicularScalingFactor(Color)
		Vector3 *HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetPerpendicularScalingFactor(
		        Vector3 *__return_ptr retstr,
		        Color *SurfaceAlbedo,
		        MethodInfo *method)
		{
		  float PerpendicularScalingFactor; // xmm7_4
		  float v6; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-48h] BYREF
		  Color v14; // [rsp+30h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3900, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3900, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *SurfaceAlbedo;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    *(float *)&v10 = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		    LODWORD(retstr->z) = (_DWORD)v10;
		  }
		  else
		  {
		    PerpendicularScalingFactor = HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetPerpendicularScalingFactor(
		                                   SurfaceAlbedo->r,
		                                   0LL);
		    v6 = HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetPerpendicularScalingFactor(SurfaceAlbedo->g, 0LL);
		    retstr->z = HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetPerpendicularScalingFactor(SurfaceAlbedo->b, 0LL);
		    retstr->x = PerpendicularScalingFactor;
		    retstr->y = v6;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static float GetDiffuseSurfaceScalingFactor(float SurfaceAlbedo) => default; // 0x0000000189C13008-0x0000000189C1308C
		// Single GetDiffuseSurfaceScalingFactor(Single)
		float HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetDiffuseSurfaceScalingFactor(
		        float SurfaceAlbedo,
		        MethodInfo *method)
		{
		  double v3; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3901, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3901, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, SurfaceAlbedo, 0LL);
		  }
		  else
		  {
		    v3 = sub_1803369A0();
		    return (float)(*(float *)&v3 * 3.5) + (float)(1.9 - SurfaceAlbedo);
		  }
		}
		
		[IDTag(1)]
		public static Vector3 GetDiffuseSurfaceScalingFactor(UnityEngine.Color SurfaceAlbedo) => default; // 0x0000000189C1308C-0x0000000189C13148
		// Vector3 GetDiffuseSurfaceScalingFactor(Color)
		Vector3 *HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetDiffuseSurfaceScalingFactor(
		        Vector3 *__return_ptr retstr,
		        Color *SurfaceAlbedo,
		        MethodInfo *method)
		{
		  float DiffuseSurfaceScalingFactor; // xmm7_4
		  float v6; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-48h] BYREF
		  Color v14; // [rsp+30h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3902, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3902, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *SurfaceAlbedo;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    *(float *)&v10 = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		    LODWORD(retstr->z) = (_DWORD)v10;
		  }
		  else
		  {
		    DiffuseSurfaceScalingFactor = HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetDiffuseSurfaceScalingFactor(
		                                    SurfaceAlbedo->r,
		                                    0LL);
		    v6 = HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetDiffuseSurfaceScalingFactor(SurfaceAlbedo->g, 0LL);
		    retstr->z = HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetDiffuseSurfaceScalingFactor(SurfaceAlbedo->b, 0LL);
		    retstr->x = DiffuseSurfaceScalingFactor;
		    retstr->y = v6;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static float GetSearchLightDiffuseScalingFactor(float SurfaceAlbedo) => default; // 0x0000000189C1347C-0x0000000189C134F8
		// Single GetSearchLightDiffuseScalingFactor(Single)
		float HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetSearchLightDiffuseScalingFactor(
		        float SurfaceAlbedo,
		        MethodInfo *method)
		{
		  double v2; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3903, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3903, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, SurfaceAlbedo, 0LL);
		  }
		  else
		  {
		    v2 = sub_1803369A0();
		    return (float)(*(float *)&v2 * 100.0) + 3.5;
		  }
		}
		
		[IDTag(1)]
		public static Vector3 GetSearchLightDiffuseScalingFactor(UnityEngine.Color SurfaceAlbedo) => default; // 0x0000000189C133C0-0x0000000189C1347C
		// Vector3 GetSearchLightDiffuseScalingFactor(Color)
		Vector3 *HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetSearchLightDiffuseScalingFactor(
		        Vector3 *__return_ptr retstr,
		        Color *SurfaceAlbedo,
		        MethodInfo *method)
		{
		  float SearchLightDiffuseScalingFactor; // xmm7_4
		  float v6; // xmm6_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-48h] BYREF
		  Color v14; // [rsp+30h] [rbp-38h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3904, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3904, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *SurfaceAlbedo;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    *(float *)&v10 = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		    LODWORD(retstr->z) = (_DWORD)v10;
		  }
		  else
		  {
		    SearchLightDiffuseScalingFactor = HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetSearchLightDiffuseScalingFactor(
		                                        SurfaceAlbedo->r,
		                                        0LL);
		    v6 = HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetSearchLightDiffuseScalingFactor(SurfaceAlbedo->g, 0LL);
		    retstr->z = HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetSearchLightDiffuseScalingFactor(
		                  SurfaceAlbedo->b,
		                  0LL);
		    retstr->x = SearchLightDiffuseScalingFactor;
		    retstr->y = v6;
		  }
		  return retstr;
		}
		
		public static Vector3 GetMeanFreePathFromDiffuseMeanFreePath(UnityEngine.Color SurfaceAlbedo, Vector3 DiffuseMeanFreePath) => default; // 0x0000000189C13148-0x0000000189C13278
		// Vector3 GetMeanFreePathFromDiffuseMeanFreePath(Color, Vector3)
		Vector3 *HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetMeanFreePathFromDiffuseMeanFreePath(
		        Vector3 *__return_ptr retstr,
		        Color *SurfaceAlbedo,
		        Vector3 *DiffuseMeanFreePath,
		        MethodInfo *method)
		{
		  Vector3 *PerpendicularScalingFactor; // rax
		  float v8; // ebx
		  Vector3 *SearchLightDiffuseScalingFactor; // rax
		  float v10; // xmm1_4
		  float v11; // xmm1_4
		  float v12; // xmm2_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v14; // rcx
		  float z; // eax
		  Color v16; // xmm0
		  Vector3 *v17; // rax
		  Color v19; // [rsp+30h] [rbp-30h] BYREF
		  Color v20; // [rsp+40h] [rbp-20h] BYREF
		  Color v21; // [rsp+50h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3905, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3905, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, 0LL);
		    z = DiffuseMeanFreePath->z;
		    *(_QWORD *)&v20.r = *(_QWORD *)&DiffuseMeanFreePath->x;
		    v16 = *SurfaceAlbedo;
		    v20.b = z;
		    v19 = v16;
		    v17 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1373((Vector3 *)&v21, Patch, &v19, (Vector3 *)&v20, 0LL);
		    *(_QWORD *)&v16.r = *(_QWORD *)&v17->x;
		    *(float *)&v17 = v17->z;
		    *(_QWORD *)&retstr->x = *(_QWORD *)&v16.r;
		    LODWORD(retstr->z) = (_DWORD)v17;
		  }
		  else
		  {
		    v21 = *SurfaceAlbedo;
		    PerpendicularScalingFactor = HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetPerpendicularScalingFactor(
		                                   (Vector3 *)&v20,
		                                   &v21,
		                                   0LL);
		    v8 = PerpendicularScalingFactor->z;
		    *(_QWORD *)&v19.r = *(_QWORD *)&PerpendicularScalingFactor->x;
		    v20 = *SurfaceAlbedo;
		    SearchLightDiffuseScalingFactor = HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetSearchLightDiffuseScalingFactor(
		                                        (Vector3 *)&v21,
		                                        &v20,
		                                        0LL);
		    v10 = v19.g * DiffuseMeanFreePath->y;
		    *(_QWORD *)&v20.r = *(_QWORD *)&SearchLightDiffuseScalingFactor->x;
		    v11 = v10 / v20.g;
		    v12 = v8 * DiffuseMeanFreePath->z;
		    retstr->x = (float)(v19.r * DiffuseMeanFreePath->x) / v20.r;
		    retstr->y = v11;
		    retstr->z = v12 / SearchLightDiffuseScalingFactor->z;
		  }
		  return retstr;
		}
		
		public static Vector4 GetDiffuseMeanFreePathFromMeanFreePath(UnityEngine.Color SurfaceAlbedo, Vector4 MeanFreePath) => default; // 0x0000000189C12E00-0x0000000189C12F2C
		// Vector4 GetDiffuseMeanFreePathFromMeanFreePath(Color, Vector4)
		Vector4 *HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetDiffuseMeanFreePathFromMeanFreePath(
		        Vector4 *__return_ptr retstr,
		        Color *SurfaceAlbedo,
		        Vector4 *MeanFreePath,
		        MethodInfo *method)
		{
		  Vector3 *SearchLightDiffuseScalingFactor; // rax
		  float z; // ebx
		  Vector3 *PerpendicularScalingFactor; // rax
		  __m128 x_low; // xmm1
		  __m128 y_low; // xmm3
		  float v12; // xmm2_4
		  MethodInfo *v13; // r8
		  Vector4 *v14; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  Color v18; // xmm1
		  Vector4 v19; // xmm0
		  Vector4 *result; // rax
		  Vector4 v21; // [rsp+30h] [rbp-30h] BYREF
		  Color v22; // [rsp+40h] [rbp-20h] BYREF
		  Color v23; // [rsp+50h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3906, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3906, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v17, v16);
		    v18 = *SurfaceAlbedo;
		    v23 = (Color)*MeanFreePath;
		    v22 = v18;
		    v14 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1374(&v21, Patch, &v22, (Vector4 *)&v23, 0LL);
		  }
		  else
		  {
		    v23 = *SurfaceAlbedo;
		    SearchLightDiffuseScalingFactor = HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetSearchLightDiffuseScalingFactor(
		                                        (Vector3 *)&v22,
		                                        &v23,
		                                        0LL);
		    z = SearchLightDiffuseScalingFactor->z;
		    *(_QWORD *)&v21.x = *(_QWORD *)&SearchLightDiffuseScalingFactor->x;
		    v22 = *SurfaceAlbedo;
		    PerpendicularScalingFactor = HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetPerpendicularScalingFactor(
		                                   (Vector3 *)&v23,
		                                   &v22,
		                                   0LL);
		    x_low = (__m128)LODWORD(v21.x);
		    x_low.m128_f32[0] = v21.x * MeanFreePath->x;
		    y_low = (__m128)LODWORD(v21.y);
		    y_low.m128_f32[0] = v21.y * MeanFreePath->y;
		    *(_QWORD *)&v22.r = *(_QWORD *)&PerpendicularScalingFactor->x;
		    x_low.m128_f32[0] = x_low.m128_f32[0] / v22.r;
		    y_low.m128_f32[0] = y_low.m128_f32[0] / v22.g;
		    v12 = z * MeanFreePath->z;
		    *(_QWORD *)&v22.r = _mm_unpacklo_ps(x_low, y_low).m128_u64[0];
		    v22.b = v12 / PerpendicularScalingFactor->z;
		    v14 = UnityEngine::Vector4::op_Implicit((Vector4 *)&v23, (Vector3 *)&v22, v13);
		  }
		  v19 = *v14;
		  result = retstr;
		  *retstr = v19;
		  return result;
		}
		
		public static float GetDiffuseReflectProfileWithDiffuseMeanFreePath(float L, float S3D, float Radius) => default; // 0x0000000189C12F2C-0x0000000189C13008
		// Single GetDiffuseReflectProfileWithDiffuseMeanFreePath(Single, Single, Single)
		float HG::Rendering::Runtime::BurleyNormalizedDuffusion::GetDiffuseReflectProfileWithDiffuseMeanFreePath(
		        float L,
		        float S3D,
		        float Radius,
		        MethodInfo *method)
		{
		  float v5; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3907, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3907, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_98((ILFixDynamicMethodWrapper_17 *)Patch, L, S3D, Radius, 0LL);
		  }
		  else
		  {
		    v5 = sub_180335960();
		    return fmaxf((float)((float)(v5 + sub_180335960()) / (float)((float)(1.0 / S3D) * L)) * 0.039788734, 1.0e-12);
		  }
		}
		
	}
}
