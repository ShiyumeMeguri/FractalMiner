using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct CameraPositionSettings // TypeDefIndex: 38659
	{
		// Fields
		[Obsolete("Since 2019.3, use CameraPositionSettings.NewDefault() instead.")]
		public static readonly CameraPositionSettings @default; // 0x00
		public Mode mode; // 0x00
		public Vector3 position; // 0x04
		public Quaternion rotation; // 0x10
		public Matrix4x4 worldToCameraMatrix; // 0x20
	
		// Nested types
		public enum Mode // TypeDefIndex: 38658
		{
			ComputeWorldToCameraMatrix = 0,
			UseWorldToCameraMatrixField = 1
		}
	
		// Constructors
		static CameraPositionSettings() {
			default = default;
		} // 0x00000001841E1670-0x00000001841E1680
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
		public static CameraPositionSettings NewDefault() => default; // 0x0000000189C1C6C4-0x0000000189C1C7BC
		// CameraPositionSettings NewDefault()
		CameraPositionSettings *HG::Rendering::Runtime::CameraPositionSettings::NewDefault(
		        CameraPositionSettings *__return_ptr retstr,
		        MethodInfo *method)
		{
		  Animator *v3; // rdx
		  int32_t v4; // r8d
		  MethodInfo *v5; // r9
		  Vector3 *Vector; // rax
		  __int64 v7; // xmm1_8
		  MethodInfo *v8; // rdx
		  Quaternion v9; // xmm5
		  struct Matrix4x4__Class *v10; // rax
		  _OWORD *p_m00; // rcx
		  __int128 v12; // xmm2
		  __int128 v13; // xmm3
		  __int128 v14; // xmm4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		  CameraPositionSettings *v18; // rax
		  Quaternion rotation; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  Quaternion v25; // [rsp+20h] [rbp-78h] BYREF
		  CameraPositionSettings v26; // [rsp+30h] [rbp-68h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4065, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4065, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v17, v16);
		    v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1435(&v26, Patch, 0LL);
		    rotation = v18->rotation;
		    *(_OWORD *)&retstr->mode = *(_OWORD *)&v18->mode;
		    v20 = *(_OWORD *)&v18->worldToCameraMatrix.m00;
		    retstr->rotation = rotation;
		    v21 = *(_OWORD *)&v18->worldToCameraMatrix.m01;
		    *(_OWORD *)&retstr->worldToCameraMatrix.m00 = v20;
		    v22 = *(_OWORD *)&v18->worldToCameraMatrix.m02;
		    *(_OWORD *)&retstr->worldToCameraMatrix.m01 = v21;
		    v23 = *(_OWORD *)&v18->worldToCameraMatrix.m03;
		    *(_OWORD *)&retstr->worldToCameraMatrix.m02 = v22;
		    *(_OWORD *)&retstr->worldToCameraMatrix.m03 = v23;
		  }
		  else
		  {
		    sub_18033B9D0(&v26.position, 0LL, 92LL);
		    v26.mode = 0;
		    Vector = UnityEngine::Animator::GetVector((Vector3 *)&v25, v3, v4, v5);
		    v7 = *(_QWORD *)&Vector->x;
		    *(float *)&Vector = Vector->z;
		    *(_QWORD *)&v26.position.x = v7;
		    LODWORD(v26.position.z) = (_DWORD)Vector;
		    v9 = (Quaternion)_mm_loadu_si128((const __m128i *)UnityEngine::Quaternion::get_identity(&v25, v8));
		    v10 = TypeInfo::UnityEngine::Matrix4x4;
		    *(_OWORD *)&retstr->mode = *(_OWORD *)&v26.mode;
		    p_m00 = (_OWORD *)&v10->static_fields->zeroMatrix.m00;
		    retstr->rotation = v9;
		    v12 = p_m00[5];
		    v13 = p_m00[6];
		    v14 = p_m00[7];
		    *(_OWORD *)&retstr->worldToCameraMatrix.m00 = p_m00[4];
		    *(_OWORD *)&retstr->worldToCameraMatrix.m01 = v12;
		    *(_OWORD *)&retstr->worldToCameraMatrix.m02 = v13;
		    *(_OWORD *)&retstr->worldToCameraMatrix.m03 = v14;
		  }
		  return retstr;
		}
		
		public Matrix4x4 ComputeWorldToCameraMatrix() => default; // 0x0000000189C1C514-0x0000000189C1C5C8
		// Matrix4x4 ComputeWorldToCameraMatrix()
		Matrix4x4 *HG::Rendering::Runtime::CameraPositionSettings::ComputeWorldToCameraMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        CameraPositionSettings *this,
		        MethodInfo *method)
		{
		  Quaternion rotation; // xmm0
		  float z; // eax
		  Matrix4x4 *v7; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  Matrix4x4 *result; // rax
		  Vector3 v15; // [rsp+20h] [rbp-68h] BYREF
		  Quaternion v16; // [rsp+30h] [rbp-58h] BYREF
		  Matrix4x4 v17; // [rsp+40h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4066, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4066, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1436(&v17, Patch, this, 0LL);
		  }
		  else
		  {
		    rotation = this->rotation;
		    z = this->position.z;
		    *(_QWORD *)&v15.x = *(_QWORD *)&this->position.x;
		    v15.z = z;
		    v16 = rotation;
		    v7 = HG::Rendering::Runtime::GeometryUtils::CalculateWorldToCameraMatrixRHS(&v17, &v15, &v16, 0LL);
		  }
		  v11 = *(_OWORD *)&v7->m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v7->m00;
		  v12 = *(_OWORD *)&v7->m02;
		  *(_OWORD *)&retstr->m01 = v11;
		  v13 = *(_OWORD *)&v7->m03;
		  result = retstr;
		  *(_OWORD *)&retstr->m02 = v12;
		  *(_OWORD *)&retstr->m03 = v13;
		  return result;
		}
		
		public Matrix4x4 GetUsedWorldToCameraMatrix() => default; // 0x0000000189C1C5C8-0x0000000189C1C6C4
		// Matrix4x4 GetUsedWorldToCameraMatrix()
		Matrix4x4 *HG::Rendering::Runtime::CameraPositionSettings::GetUsedWorldToCameraMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        CameraPositionSettings *this,
		        MethodInfo *method)
		{
		  Matrix4x4 *v5; // rax
		  __int128 v6; // xmm1
		  __int128 v7; // xmm0
		  __int128 v8; // xmm1
		  __int64 v9; // rax
		  ArgumentException *v10; // rax
		  __int64 v11; // rdx
		  __int64 v12; // rcx
		  ArgumentException *v13; // rbx
		  __int64 v14; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int128 v16; // xmm1
		  Matrix4x4 *result; // rax
		  Matrix4x4 v18; // [rsp+20h] [rbp-48h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4067, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4067, 0LL);
		    if ( Patch )
		    {
		      v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1436(&v18, Patch, this, 0LL);
		      goto LABEL_11;
		    }
		LABEL_9:
		    sub_1800D8260(v12, v11);
		  }
		  if ( !this->mode )
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CameraPositionSettings);
		    v5 = HG::Rendering::Runtime::CameraPositionSettings::ComputeWorldToCameraMatrix(&v18, this, 0LL);
		LABEL_11:
		    v16 = *(_OWORD *)&v5->m01;
		    *(_OWORD *)&retstr->m00 = *(_OWORD *)&v5->m00;
		    v7 = *(_OWORD *)&v5->m02;
		    *(_OWORD *)&retstr->m01 = v16;
		    v8 = *(_OWORD *)&v5->m03;
		    goto LABEL_12;
		  }
		  if ( this->mode != 1 )
		  {
		    v9 = sub_18007E180(&TypeInfo::System::ArgumentException);
		    v10 = (ArgumentException *)sub_18002C620(v9);
		    v13 = v10;
		    if ( v10 )
		    {
		      System::ArgumentException::ArgumentException(v10, 0LL);
		      v14 = sub_18007E180(&MethodInfo::HG::Rendering::Runtime::CameraPositionSettings::GetUsedWorldToCameraMatrix);
		      sub_18007E190(v13, v14);
		    }
		    goto LABEL_9;
		  }
		  v6 = *(_OWORD *)&this->worldToCameraMatrix.m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&this->worldToCameraMatrix.m00;
		  v7 = *(_OWORD *)&this->worldToCameraMatrix.m02;
		  *(_OWORD *)&retstr->m01 = v6;
		  v8 = *(_OWORD *)&this->worldToCameraMatrix.m03;
		LABEL_12:
		  *(_OWORD *)&retstr->m02 = v7;
		  result = retstr;
		  *(_OWORD *)&retstr->m03 = v8;
		  return result;
		}
		
	}
}
