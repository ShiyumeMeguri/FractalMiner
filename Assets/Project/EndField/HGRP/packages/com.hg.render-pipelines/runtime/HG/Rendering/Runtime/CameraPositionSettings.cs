using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 96)]
	public struct CameraPositionSettings
	{
		public static CameraPositionSettings NewDefault()
		{
			// // CameraPositionSettings NewDefault()
			// CameraPositionSettings *HG::Rendering::Runtime::CameraPositionSettings::NewDefault(
			//         CameraPositionSettings *__return_ptr retstr,
			//         MethodInfo *method)
			// {
			//   Animator *v3; // rdx
			//   int32_t v4; // r8d
			//   MethodInfo *v5; // r9
			//   Vector3 *Vector; // rax
			//   __int64 v7; // xmm1_8
			//   MethodInfo *v8; // rdx
			//   Quaternion v9; // xmm6
			//   __int128 *v10; // rax
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm2
			//   __int128 v13; // xmm3
			//   __int128 v14; // xmm4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rdx
			//   __int64 v17; // rcx
			//   CameraPositionSettings *v18; // rax
			//   Quaternion rotation; // xmm1
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   Quaternion v25; // [rsp+20h] [rbp-C8h] BYREF
			//   CameraPositionSettings v26; // [rsp+30h] [rbp-B8h] BYREF
			//   _BYTE v27[64]; // [rsp+90h] [rbp-58h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3437, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3437, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, v16);
			//     v18 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1226(&v26, Patch, 0LL);
			//     rotation = v18.rotation;
			//     *(_OWORD *)&retstr.mode = *(_OWORD *)&v18.mode;
			//     v20 = *(_OWORD *)&v18.worldToCameraMatrix.m00;
			//     retstr.rotation = rotation;
			//     v21 = *(_OWORD *)&v18.worldToCameraMatrix.m01;
			//     *(_OWORD *)&retstr.worldToCameraMatrix.m00 = v20;
			//     v22 = *(_OWORD *)&v18.worldToCameraMatrix.m02;
			//     *(_OWORD *)&retstr.worldToCameraMatrix.m01 = v21;
			//     v23 = *(_OWORD *)&v18.worldToCameraMatrix.m03;
			//     *(_OWORD *)&retstr.worldToCameraMatrix.m02 = v22;
			//     *(_OWORD *)&retstr.worldToCameraMatrix.m03 = v23;
			//   }
			//   else
			//   {
			//     sub_1802F01E0(&v26.position, 0LL, 92LL);
			//     v26.mode = 0;
			//     Vector = UnityEngine::Animator::GetVector((Vector3 *)&v25, v3, v4, v5);
			//     v7 = *(_QWORD *)&Vector.x;
			//     *(float *)&Vector = Vector.z;
			//     *(_QWORD *)&v26.position.x = v7;
			//     LODWORD(v26.position.z) = (_DWORD)Vector;
			//     v9 = (Quaternion)_mm_loadu_si128((const __m128i *)UnityEngine::Quaternion::get_identity(&v25, v8));
			//     v10 = (__int128 *)sub_182805160(v27);
			//     *(_OWORD *)&retstr.mode = *(_OWORD *)&v26.mode;
			//     v11 = *v10;
			//     v12 = v10[1];
			//     v13 = v10[2];
			//     v14 = v10[3];
			//     retstr.rotation = v9;
			//     *(_OWORD *)&retstr.worldToCameraMatrix.m00 = v11;
			//     *(_OWORD *)&retstr.worldToCameraMatrix.m01 = v12;
			//     *(_OWORD *)&retstr.worldToCameraMatrix.m02 = v13;
			//     *(_OWORD *)&retstr.worldToCameraMatrix.m03 = v14;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public Matrix4x4 ComputeWorldToCameraMatrix()
		{
			// // Matrix4x4 ComputeWorldToCameraMatrix()
			// Matrix4x4 *HG::Rendering::Runtime::CameraPositionSettings::ComputeWorldToCameraMatrix(
			//         Matrix4x4 *__return_ptr retstr,
			//         CameraPositionSettings *this,
			//         MethodInfo *method)
			// {
			//   Quaternion rotation; // xmm0
			//   float z; // eax
			//   Matrix4x4 *v7; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   Matrix4x4 *result; // rax
			//   Vector3 v15; // [rsp+20h] [rbp-68h] BYREF
			//   Quaternion v16; // [rsp+30h] [rbp-58h] BYREF
			//   Matrix4x4 v17; // [rsp+40h] [rbp-48h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3438, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3438, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1227(&v17, Patch, this, 0LL);
			//   }
			//   else
			//   {
			//     rotation = this.rotation;
			//     z = this.position.z;
			//     *(_QWORD *)&v15.x = *(_QWORD *)&this.position.x;
			//     v15.z = z;
			//     v16 = rotation;
			//     v7 = HG::Rendering::Runtime::GeometryUtils::CalculateWorldToCameraMatrixRHS(&v17, &v15, &v16, 0LL);
			//   }
			//   v11 = *(_OWORD *)&v7.m01;
			//   *(_OWORD *)&retstr.m00 = *(_OWORD *)&v7.m00;
			//   v12 = *(_OWORD *)&v7.m02;
			//   *(_OWORD *)&retstr.m01 = v11;
			//   v13 = *(_OWORD *)&v7.m03;
			//   result = retstr;
			//   *(_OWORD *)&retstr.m02 = v12;
			//   *(_OWORD *)&retstr.m03 = v13;
			//   return result;
			// }
			// 
			return null;
		}

		public Matrix4x4 GetUsedWorldToCameraMatrix()
		{
			// // Matrix4x4 GetUsedWorldToCameraMatrix()
			// Matrix4x4 *HG::Rendering::Runtime::CameraPositionSettings::GetUsedWorldToCameraMatrix(
			//         Matrix4x4 *__return_ptr retstr,
			//         CameraPositionSettings *this,
			//         MethodInfo *method)
			// {
			//   Matrix4x4 *v5; // rax
			//   __int128 v6; // xmm1
			//   __int128 v7; // xmm0
			//   __int128 v8; // xmm1
			//   __int64 v9; // rax
			//   ArgumentException *v10; // rax
			//   __int64 v11; // rdx
			//   __int64 v12; // rcx
			//   ArgumentException *v13; // rbx
			//   __int64 v14; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int128 v16; // xmm1
			//   Matrix4x4 *result; // rax
			//   Matrix4x4 v18; // [rsp+20h] [rbp-48h] BYREF
			// 
			//   if ( !byte_18D919746 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CameraPositionSettings);
			//     byte_18D919746 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3439, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3439, 0LL);
			//     if ( Patch )
			//     {
			//       v5 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1227(&v18, Patch, this, 0LL);
			//       goto LABEL_13;
			//     }
			// LABEL_11:
			//     sub_180B536AC(v12, v11);
			//   }
			//   if ( !this.mode )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CameraPositionSettings);
			//     v5 = HG::Rendering::Runtime::CameraPositionSettings::ComputeWorldToCameraMatrix(&v18, this, 0LL);
			// LABEL_13:
			//     v16 = *(_OWORD *)&v5.m01;
			//     *(_OWORD *)&retstr.m00 = *(_OWORD *)&v5.m00;
			//     v7 = *(_OWORD *)&v5.m02;
			//     *(_OWORD *)&retstr.m01 = v16;
			//     v8 = *(_OWORD *)&v5.m03;
			//     goto LABEL_14;
			//   }
			//   if ( this.mode != 1 )
			//   {
			//     v9 = sub_18000F7E0(&TypeInfo::System::ArgumentException);
			//     v10 = (ArgumentException *)sub_180004920(v9);
			//     v13 = v10;
			//     if ( v10 )
			//     {
			//       System::ArgumentException::ArgumentException(v10, 0LL);
			//       v14 = sub_18000F7E0(&MethodInfo::HG::Rendering::Runtime::CameraPositionSettings::GetUsedWorldToCameraMatrix);
			//       sub_18000F7C0(v13, v14);
			//     }
			//     goto LABEL_11;
			//   }
			//   v6 = *(_OWORD *)&this.worldToCameraMatrix.m01;
			//   *(_OWORD *)&retstr.m00 = *(_OWORD *)&this.worldToCameraMatrix.m00;
			//   v7 = *(_OWORD *)&this.worldToCameraMatrix.m02;
			//   *(_OWORD *)&retstr.m01 = v6;
			//   v8 = *(_OWORD *)&this.worldToCameraMatrix.m03;
			// LABEL_14:
			//   *(_OWORD *)&retstr.m02 = v7;
			//   result = retstr;
			//   *(_OWORD *)&retstr.m03 = v8;
			//   return result;
			// }
			// 
			return null;
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		[Obsolete("Since 2019.3, use CameraPositionSettings.NewDefault() instead.")]
		public static readonly CameraPositionSettings @default;

		public CameraPositionSettings.Mode mode;

		public Vector3 position;

		public Quaternion rotation;

		public Matrix4x4 worldToCameraMatrix;

		public enum Mode
		{
			ComputeWorldToCameraMatrix,
			UseWorldToCameraMatrixField
		}
	}
}
