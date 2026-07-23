using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct ClothMetaData // TypeDefIndex: 37560
	{
		// Fields
		public uint clothNodeIdxStart; // 0x00
		public uint clothNodeIdxEnd; // 0x04
		public uint batchIdxStart; // 0x08
		public uint iterNum; // 0x0C
		public float damping; // 0x10
		public float windFreqFactor; // 0x14
		public float windBalanceFactor; // 0x18
		public float windIntensityScale; // 0x1C
		public int4 groupOffset; // 0x20
		public Vector4 packedLongestAnchorDistance; // 0x30
		public Vector4 packedClothNormal; // 0x40
		public Vector4 localToWorld0; // 0x50
		public Vector4 localToWorld1; // 0x60
		public Vector4 localToWorld2; // 0x70
		public Vector4 worldToLocal0; // 0x80
		public Vector4 worldToLocal1; // 0x90
		public Vector4 worldToLocal2; // 0xA0
	
		// Methods
		public void SetLocalToWorld(Matrix4x4 localToWorld) {} // 0x0000000189C68A10-0x0000000189C68B80
		// Void SetLocalToWorld(Matrix4x4)
		void HG::Rendering::Runtime::ClothMetaData::SetLocalToWorld(
		        ClothMetaData *this,
		        Matrix4x4 *localToWorld,
		        MethodInfo *method)
		{
		  Matrix4x4 *inverse; // rax
		  __int128 v6; // xmm1
		  __int128 v7; // xmm0
		  __int128 v8; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  Vector4 v15; // [rsp+20h] [rbp-39h] BYREF
		  Matrix4x4 v16; // [rsp+30h] [rbp-29h] BYREF
		  Matrix4x4 v17; // [rsp+70h] [rbp+17h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1256, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1256, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    v12 = *(_OWORD *)&localToWorld->m01;
		    *(_OWORD *)&v16.m00 = *(_OWORD *)&localToWorld->m00;
		    v13 = *(_OWORD *)&localToWorld->m02;
		    *(_OWORD *)&v16.m01 = v12;
		    v14 = *(_OWORD *)&localToWorld->m03;
		    *(_OWORD *)&v16.m02 = v13;
		    *(_OWORD *)&v16.m03 = v14;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_482(Patch, this, &v16, 0LL);
		  }
		  else
		  {
		    this->localToWorld0 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow(
		                                                                      &v15,
		                                                                      localToWorld,
		                                                                      0,
		                                                                      0LL));
		    this->localToWorld1 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow(
		                                                                      &v15,
		                                                                      localToWorld,
		                                                                      1,
		                                                                      0LL));
		    this->localToWorld2 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow(
		                                                                      &v15,
		                                                                      localToWorld,
		                                                                      2,
		                                                                      0LL));
		    inverse = UnityEngine::Matrix4x4::get_inverse(&v17, localToWorld, 0LL);
		    v6 = *(_OWORD *)&inverse->m01;
		    *(_OWORD *)&v16.m00 = *(_OWORD *)&inverse->m00;
		    v7 = *(_OWORD *)&inverse->m02;
		    *(_OWORD *)&v16.m01 = v6;
		    v8 = *(_OWORD *)&inverse->m03;
		    *(_OWORD *)&v16.m02 = v7;
		    *(_OWORD *)&v16.m03 = v8;
		    this->worldToLocal0 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow(&v15, &v16, 0, 0LL));
		    this->worldToLocal1 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow(&v15, &v16, 1, 0LL));
		    this->worldToLocal2 = (Vector4)_mm_loadu_si128((const __m128i *)UnityEngine::Matrix4x4::GetRow(&v15, &v16, 2, 0LL));
		  }
		}
		
		public float GetWindIntensity() => default; // 0x0000000189C68970-0x0000000189C689C0
		// Single GetWindIntensity()
		float HG::Rendering::Runtime::ClothMetaData::GetWindIntensity(ClothMetaData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1257, 0LL) )
		    return this->windIntensityScale;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1257, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_483(Patch, this, 0LL);
		}
		
		public float GetWindSoftFactor() => default; // 0x0000000189C689C0-0x0000000189C68A10
		// Single GetWindSoftFactor()
		float HG::Rendering::Runtime::ClothMetaData::GetWindSoftFactor(ClothMetaData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1258, 0LL) )
		    return this->packedLongestAnchorDistance.z;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1258, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_483(Patch, this, 0LL);
		}
		
		public float GetTransformScale() => default; // 0x0000000189C68920-0x0000000189C68970
		// Single GetTransformScale()
		float HG::Rendering::Runtime::ClothMetaData::GetTransformScale(ClothMetaData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1259, 0LL) )
		    return this->packedLongestAnchorDistance.w;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1259, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_483(Patch, this, 0LL);
		}
		
	}
}
