using System;
using IFix.Core;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public static class VectorSwizzleUtils
	{
		[IDTag(0)]
		public static Vector2 xx(this float f)
		{
			// // Vector2 xx(Single)
			// // local variable allocation has failed, the output may be wrong!
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xx(float f, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3538, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps(*(__m128 *)&f, *(__m128 *)&f).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3538, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v5, v4);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1257(Patch, f, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 xxx(this float f)
		{
			// // Vector3 xxx(Single)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxx(Vector3 *__return_ptr retstr, float f, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector3 *v7; // rax
			//   __int64 v8; // xmm0_8
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1444, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1444, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, v5);
			//     v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_541(&v10, Patch, f, 0LL);
			//     v8 = *(_QWORD *)&v7.x;
			//     *(float *)&v7 = v7.z;
			//     *(_QWORD *)&retstr.x = v8;
			//     LODWORD(retstr.z) = (_DWORD)v7;
			//   }
			//   else
			//   {
			//     retstr.x = f;
			//     retstr.y = f;
			//     retstr.z = f;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xxxx(this float f)
		{
			// // Vector4 xxxx(Single)
			// // local variable allocation has failed, the output may be wrong!
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxx(Vector4 *__return_ptr retstr, float f, MethodInfo *method)
			// {
			//   Vector4 v4; // xmm6
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   v4 = (Vector4)_mm_shuffle_ps(*(__m128 *)&f, *(__m128 *)&f, 0);
			//   if ( IFix::WrappersManagerImpl::IsPatched(3539, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3539, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1010(&v9, Patch, v4.x, 0LL);
			//   }
			//   else
			//   {
			//     *retstr = v4;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector2 xx(this Vector2 v)
		{
			// // Vector2 xx(Vector2)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xx(Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   float x; // [rsp+20h] [rbp-28h]
			// 
			//   x = v.x;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3540, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(x), (__m128)LODWORD(x)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3540, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1146(Patch, v, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector2 xy(this Vector2 v)
		{
			// // Vector2 xy(Vector2)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xy(Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3541, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.x), (__m128)LODWORD(v.y)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3541, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1146(Patch, v, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector2 yx(this Vector2 v)
		{
			// // Vector2 yx(Vector2)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yx(Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3542, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.y), (__m128)LODWORD(v.x)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3542, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1146(Patch, v, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector2 yy(this Vector2 v)
		{
			// // Vector2 yy(Vector2)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yy(Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   float y; // [rsp+24h] [rbp-24h]
			// 
			//   y = v.y;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3543, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(y), (__m128)LODWORD(y)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3543, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1146(Patch, v, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 xxx(this Vector2 v)
		{
			// // Vector3 xxx(Vector2)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxx(Vector3 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector3 *v8; // rax
			//   __int64 v9; // xmm0_8
			//   float x; // [rsp+20h] [rbp-38h]
			//   Vector3 v12[2]; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   x = v.x;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3544, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3544, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1258(v12, Patch, v, 0LL);
			//     v9 = *(_QWORD *)&v8.x;
			//     *(float *)&v8 = v8.z;
			//     *(_QWORD *)&retstr.x = v9;
			//     LODWORD(retstr.z) = (_DWORD)v8;
			//   }
			//   else
			//   {
			//     retstr.x = x;
			//     retstr.y = x;
			//     retstr.z = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 xxy(this Vector2 v)
		{
			// // Vector3 xxy(Vector2)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxy(Vector3 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector3 *v8; // rax
			//   __int64 v9; // xmm0_8
			//   Vector3 v12[2]; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3545, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3545, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1258(v12, Patch, v, 0LL);
			//     v9 = *(_QWORD *)&v8.x;
			//     *(float *)&v8 = v8.z;
			//     *(_QWORD *)&retstr.x = v9;
			//     LODWORD(retstr.z) = (_DWORD)v8;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     *(Vector2 *)&retstr.y = v;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 xyx(this Vector2 v)
		{
			// // Vector3 xyx(Vector2)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyx(Vector3 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector3 *v8; // rax
			//   __int64 v9; // xmm0_8
			//   Vector3 v12[2]; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3546, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3546, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1258(v12, Patch, v, 0LL);
			//     v9 = *(_QWORD *)&v8.x;
			//     *(float *)&v8 = v8.z;
			//     *(_QWORD *)&retstr.x = v9;
			//     LODWORD(retstr.z) = (_DWORD)v8;
			//   }
			//   else
			//   {
			//     *(Vector2 *)&retstr.x = v;
			//     retstr.z = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 xyy(this Vector2 v)
		{
			// // Vector3 xyy(Vector2)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyy(Vector3 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector3 *v8; // rax
			//   __int64 v9; // xmm0_8
			//   Vector3 v12[2]; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3547, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3547, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1258(v12, Patch, v, 0LL);
			//     v9 = *(_QWORD *)&v8.x;
			//     *(float *)&v8 = v8.z;
			//     *(_QWORD *)&retstr.x = v9;
			//     LODWORD(retstr.z) = (_DWORD)v8;
			//   }
			//   else
			//   {
			//     *(Vector2 *)&retstr.x = v;
			//     retstr.z = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 yxx(this Vector2 v)
		{
			// // Vector3 yxx(Vector2)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxx(Vector3 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector3 *v8; // rax
			//   __int64 v9; // xmm0_8
			//   Vector3 v12[2]; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3548, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3548, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1258(v12, Patch, v, 0LL);
			//     v9 = *(_QWORD *)&v8.x;
			//     *(float *)&v8 = v8.z;
			//     *(_QWORD *)&retstr.x = v9;
			//     LODWORD(retstr.z) = (_DWORD)v8;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     retstr.z = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 yxy(this Vector2 v)
		{
			// // Vector3 yxy(Vector2)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxy(Vector3 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector3 *v8; // rax
			//   __int64 v9; // xmm0_8
			//   Vector3 v12[2]; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3549, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3549, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1258(v12, Patch, v, 0LL);
			//     v9 = *(_QWORD *)&v8.x;
			//     *(float *)&v8 = v8.z;
			//     *(_QWORD *)&retstr.x = v9;
			//     LODWORD(retstr.z) = (_DWORD)v8;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     *(Vector2 *)&retstr.y = v;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 yyx(this Vector2 v)
		{
			// // Vector3 yyx(Vector2)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyx(Vector3 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector3 *v8; // rax
			//   __int64 v9; // xmm0_8
			//   Vector3 v12[2]; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3550, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3550, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1258(v12, Patch, v, 0LL);
			//     v9 = *(_QWORD *)&v8.x;
			//     *(float *)&v8 = v8.z;
			//     *(_QWORD *)&retstr.x = v9;
			//     LODWORD(retstr.z) = (_DWORD)v8;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.y;
			//     retstr.z = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 yyy(this Vector2 v)
		{
			// // Vector3 yyy(Vector2)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyy(Vector3 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector3 *v8; // rax
			//   __int64 v9; // xmm0_8
			//   float y; // [rsp+24h] [rbp-34h]
			//   Vector3 v12[2]; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   y = v.y;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3551, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3551, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1258(v12, Patch, v, 0LL);
			//     v9 = *(_QWORD *)&v8.x;
			//     *(float *)&v8 = v8.z;
			//     *(_QWORD *)&retstr.x = v9;
			//     LODWORD(retstr.z) = (_DWORD)v8;
			//   }
			//   else
			//   {
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xxxx(this Vector2 v)
		{
			// // Vector4 xxxx(Vector2)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxx(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   float x; // [rsp+20h] [rbp-38h]
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   x = v.x;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3552, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3552, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     *(__m128 *)retstr = _mm_shuffle_ps((__m128)LODWORD(x), (__m128)LODWORD(x), 0);
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xxxy(this Vector2 v)
		{
			// // Vector4 xxxy(Vector2)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxy(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3553, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3553, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.x;
			//     *(Vector2 *)&retstr.z = v;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xxyx(this Vector2 v)
		{
			// // Vector4 xxyx(Vector2)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyx(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3554, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3554, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     *(Vector2 *)&retstr.y = v;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xxyy(this Vector2 v)
		{
			// // Vector4 xxyy(Vector2)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyy(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3555, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3555, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     *(Vector2 *)&retstr.y = v;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xyxx(this Vector2 v)
		{
			// // Vector4 xyxx(Vector2)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxx(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3556, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3556, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     *(Vector2 *)&retstr.x = v;
			//     retstr.z = v.x;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xyxy(this Vector2 v)
		{
			// // Vector4 xyxy(Vector2)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxy(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3557, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3557, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     *(Vector2 *)&retstr.x = v;
			//     *(Vector2 *)&retstr.z = v;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xyyx(this Vector2 v)
		{
			// // Vector4 xyyx(Vector2)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyx(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3558, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3558, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     *(Vector2 *)&retstr.x = v;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xyyy(this Vector2 v)
		{
			// // Vector4 xyyy(Vector2)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyy(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3559, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3559, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     *(Vector2 *)&retstr.x = v;
			//     retstr.z = v.y;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yxxx(this Vector2 v)
		{
			// // Vector4 yxxx(Vector2)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxx(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3560, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3560, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     retstr.z = v.x;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yxxy(this Vector2 v)
		{
			// // Vector4 yxxy(Vector2)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxy(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3561, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3561, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     *(Vector2 *)&retstr.z = v;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yxyx(this Vector2 v)
		{
			// // Vector4 yxyx(Vector2)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyx(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3562, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3562, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     *(Vector2 *)&retstr.y = v;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yxyy(this Vector2 v)
		{
			// // Vector4 yxyy(Vector2)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyy(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3563, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3563, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     *(Vector2 *)&retstr.y = v;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yyxx(this Vector2 v)
		{
			// // Vector4 yyxx(Vector2)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxx(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3564, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3564, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.y;
			//     retstr.z = v.x;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yyxy(this Vector2 v)
		{
			// // Vector4 yyxy(Vector2)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxy(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3565, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3565, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.y;
			//     *(Vector2 *)&retstr.z = v;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yyyx(this Vector2 v)
		{
			// // Vector4 yyyx(Vector2)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyx(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3566, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3566, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.y;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yyyy(this Vector2 v)
		{
			// // Vector4 yyyy(Vector2)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyy(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   float y; // [rsp+24h] [rbp-34h]
			//   Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
			// 
			//   y = v.y;
			//   if ( IFix::WrappersManagerImpl::IsPatched(3567, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3567, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1117(&v10, Patch, v, 0LL);
			//   }
			//   else
			//   {
			//     *(__m128 *)retstr = _mm_shuffle_ps((__m128)LODWORD(y), (__m128)LODWORD(y), 0);
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector2 xx(this Vector3 v)
		{
			// // Vector2 xx(Vector3)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xx(Vector3 *v, MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3568, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.x), (__m128)LODWORD(v.x)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3568, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(0LL, v4);
			//   z = v.z;
			//   *(_QWORD *)&v7.x = *(_QWORD *)&v.x;
			//   v7.z = z;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_229(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector2 xy(this Vector3 v)
		{
			// // Vector2 xy(Vector3)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xy(Vector3 *v, MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1380, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.x), (__m128)LODWORD(v.y)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1380, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(0LL, v4);
			//   z = v.z;
			//   *(_QWORD *)&v7.x = *(_QWORD *)&v.x;
			//   v7.z = z;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_229(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector2 xz(this Vector3 v)
		{
			// // Vector2 xz(Vector3)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xz(Vector3 *v, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // xmm0_8
			//   Vector3 v8; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_8;
			//   if ( wrapperArray.max_length.size <= 598 )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.x), (__m128)LODWORD(v.z)).m128_u64[0];
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			//     goto LABEL_8;
			//   if ( LODWORD(v3._0.namespaze) <= 0x256 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( !*(_QWORD *)&v3[12]._1.naturalAligment )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.x), (__m128)LODWORD(v.z)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(598, 0LL);
			//   if ( !Patch )
			// LABEL_8:
			//     sub_180B536AC(v3, wrapperArray);
			//   v7 = *(_QWORD *)&v.x;
			//   v8.z = v.z;
			//   *(_QWORD *)&v8.x = v7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_229(Patch, &v8, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector2 yx(this Vector3 v)
		{
			// // Vector2 yx(Vector3)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yx(Vector3 *v, MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3569, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.y), (__m128)LODWORD(v.x)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3569, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(0LL, v4);
			//   z = v.z;
			//   *(_QWORD *)&v7.x = *(_QWORD *)&v.x;
			//   v7.z = z;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_229(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector2 yy(this Vector3 v)
		{
			// // Vector2 yy(Vector3)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yy(Vector3 *v, MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3570, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.y), (__m128)LODWORD(v.y)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3570, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(0LL, v4);
			//   z = v.z;
			//   *(_QWORD *)&v7.x = *(_QWORD *)&v.x;
			//   v7.z = z;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_229(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector2 yz(this Vector3 v)
		{
			// // Vector2 yz(Vector3)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yz(Vector3 *v, MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3571, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.y), (__m128)LODWORD(v.z)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3571, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(0LL, v4);
			//   z = v.z;
			//   *(_QWORD *)&v7.x = *(_QWORD *)&v.x;
			//   v7.z = z;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_229(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector2 zx(this Vector3 v)
		{
			// // Vector2 zx(Vector3)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::zx(Vector3 *v, MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3572, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.z), (__m128)LODWORD(v.x)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3572, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(0LL, v4);
			//   z = v.z;
			//   *(_QWORD *)&v7.x = *(_QWORD *)&v.x;
			//   v7.z = z;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_229(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector2 zy(this Vector3 v)
		{
			// // Vector2 zy(Vector3)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::zy(Vector3 *v, MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1379, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.z), (__m128)LODWORD(v.y)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1379, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(0LL, v4);
			//   z = v.z;
			//   *(_QWORD *)&v7.x = *(_QWORD *)&v.x;
			//   v7.z = z;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_229(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector2 zz(this Vector3 v)
		{
			// // Vector2 zz(Vector3)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::zz(Vector3 *v, MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3573, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.z), (__m128)LODWORD(v.z)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3573, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(0LL, v4);
			//   z = v.z;
			//   *(_QWORD *)&v7.x = *(_QWORD *)&v.x;
			//   v7.z = z;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_229(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector3 xxx(this Vector3 v)
		{
			// // Vector3 xxx(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3574, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3574, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     x = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//   }
			//   retstr.z = x;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 xxy(this Vector3 v)
		{
			// // Vector3 xxy(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v8; // rcx
			//   float z; // eax
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v14[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3575, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3575, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v13.x = *(_QWORD *)&v.x;
			//     v13.z = z;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v14, Patch, &v13, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     y = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     y = v.y;
			//   }
			//   retstr.z = y;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 xxz(this Vector3 v)
		{
			// // Vector3 xxz(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   float v6; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v8; // rcx
			//   float z; // eax
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v14[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3576, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3576, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v13.x = *(_QWORD *)&v.x;
			//     v13.z = z;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v14, Patch, &v13, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     v6 = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     v6 = v.z;
			//   }
			//   retstr.z = v6;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 xyx(this Vector3 v)
		{
			// // Vector3 xyx(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3577, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3577, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     x = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     x = v.x;
			//   }
			//   retstr.z = x;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 xyy(this Vector3 v)
		{
			// // Vector3 xyy(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3578, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3578, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     y = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     y = v.y;
			//     retstr.y = y;
			//   }
			//   retstr.z = y;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 xyz(this Vector3 v)
		{
			// // Vector3 xyz(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 *v11; // rax
			//   __int64 v12; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v14[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 850 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 0x352 )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !v5[18]._0.element_class )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(850, 0LL);
			//       if ( Patch )
			//       {
			//         v10 = *(_QWORD *)&v.x;
			//         v13.z = v.z;
			//         *(_QWORD *)&v13.x = v10;
			//         v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v14, Patch, &v13, 0LL);
			//         v12 = *(_QWORD *)&v11.x;
			//         z = v11.z;
			//         *(_QWORD *)&retstr.x = v12;
			//         goto LABEL_8;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_7:
			//   retstr.x = v.x;
			//   retstr.y = v.y;
			//   z = v.z;
			// LABEL_8:
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 xzx(this Vector3 v)
		{
			// // Vector3 xzx(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xzx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3579, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3579, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     x = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     x = v.x;
			//   }
			//   retstr.z = x;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 xzy(this Vector3 v)
		{
			// // Vector3 xzy(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xzy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3580, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3580, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     y = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     y = v.y;
			//   }
			//   retstr.z = y;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 xzz(this Vector3 v)
		{
			// // Vector3 xzz(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xzz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3581, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3581, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     v5 = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     v5 = v.z;
			//     retstr.y = v5;
			//   }
			//   retstr.z = v5;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 yxx(this Vector3 v)
		{
			// // Vector3 yxx(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3582, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3582, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     x = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     x = v.x;
			//     retstr.y = v.x;
			//   }
			//   retstr.z = x;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 yxy(this Vector3 v)
		{
			// // Vector3 yxy(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3583, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3583, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     y = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     y = v.y;
			//   }
			//   retstr.z = y;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 yxz(this Vector3 v)
		{
			// // Vector3 yxz(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3584, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3584, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     v5 = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     v5 = v.z;
			//   }
			//   retstr.z = v5;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 yyx(this Vector3 v)
		{
			// // Vector3 yyx(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v8; // rcx
			//   float z; // eax
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v14[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3585, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3585, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v13.x = *(_QWORD *)&v.x;
			//     v13.z = z;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v14, Patch, &v13, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     x = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     x = v.x;
			//   }
			//   retstr.z = x;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 yyy(this Vector3 v)
		{
			// // Vector3 yyy(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3586, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3586, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     y = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//   }
			//   retstr.z = y;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 yyz(this Vector3 v)
		{
			// // Vector3 yyz(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   float v6; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v8; // rcx
			//   float z; // eax
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v14[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3587, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3587, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v13.x = *(_QWORD *)&v.x;
			//     v13.z = z;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v14, Patch, &v13, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     v6 = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     v6 = v.z;
			//   }
			//   retstr.z = v6;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 yzx(this Vector3 v)
		{
			// // Vector3 yzx(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yzx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3588, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3588, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     x = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     x = v.x;
			//   }
			//   retstr.z = x;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 yzy(this Vector3 v)
		{
			// // Vector3 yzy(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yzy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3589, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3589, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     y = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     y = v.y;
			//   }
			//   retstr.z = y;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 yzz(this Vector3 v)
		{
			// // Vector3 yzz(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yzz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3590, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3590, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     v5 = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     v5 = v.z;
			//     retstr.y = v5;
			//   }
			//   retstr.z = v5;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 zxx(this Vector3 v)
		{
			// // Vector3 zxx(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zxx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3591, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3591, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     x = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     x = v.x;
			//     retstr.y = v.x;
			//   }
			//   retstr.z = x;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 zxy(this Vector3 v)
		{
			// // Vector3 zxy(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zxy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3592, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3592, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     y = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     y = v.y;
			//   }
			//   retstr.z = y;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 zxz(this Vector3 v)
		{
			// // Vector3 zxz(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zxz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3593, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3593, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     v5 = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     v5 = v.z;
			//   }
			//   retstr.z = v5;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 zyx(this Vector3 v)
		{
			// // Vector3 zyx(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zyx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3594, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3594, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     x = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     x = v.x;
			//   }
			//   retstr.z = x;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 zyy(this Vector3 v)
		{
			// // Vector3 zyy(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zyy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3595, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3595, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     y = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     y = v.y;
			//     retstr.y = y;
			//   }
			//   retstr.z = y;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 zyz(this Vector3 v)
		{
			// // Vector3 zyz(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zyz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3596, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3596, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     v5 = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     v5 = v.z;
			//   }
			//   retstr.z = v5;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 zzx(this Vector3 v)
		{
			// // Vector3 zzx(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zzx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v8; // rcx
			//   float z; // eax
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v14[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3597, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3597, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v13.x = *(_QWORD *)&v.x;
			//     v13.z = z;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v14, Patch, &v13, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     x = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     v5 = v.z;
			//     retstr.x = v5;
			//     retstr.y = v5;
			//     x = v.x;
			//   }
			//   retstr.z = x;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 zzy(this Vector3 v)
		{
			// // Vector3 zzy(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zzy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v8; // rcx
			//   float z; // eax
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v14[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3598, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3598, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v13.x = *(_QWORD *)&v.x;
			//     v13.z = z;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v14, Patch, &v13, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     y = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     v5 = v.z;
			//     retstr.x = v5;
			//     retstr.y = v5;
			//     y = v.y;
			//   }
			//   retstr.z = y;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector3 zzz(this Vector3 v)
		{
			// // Vector3 zzz(Vector3)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zzz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3599, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3599, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&v.x;
			//     v12.z = z;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_227(v13, Patch, &v12, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     v5 = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     v5 = v.z;
			//     retstr.x = v5;
			//     retstr.y = v5;
			//   }
			//   retstr.z = v5;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 xxxx(this Vector3 v)
		{
			// // Vector4 xxxx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3600, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3600, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     *(__m128 *)retstr = _mm_shuffle_ps((__m128)LODWORD(v.x), (__m128)LODWORD(v.x), 0);
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xxxy(this Vector3 v)
		{
			// // Vector4 xxxy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3601, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3601, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xxxz(this Vector3 v)
		{
			// // Vector4 xxxz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3602, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3602, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xxyx(this Vector3 v)
		{
			// // Vector4 xxyx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3603, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3603, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xxyy(this Vector3 v)
		{
			// // Vector4 xxyy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v8; // rcx
			//   float z; // eax
			//   Vector3 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3604, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3604, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v11.x = *(_QWORD *)&v.x;
			//     v11.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xxyz(this Vector3 v)
		{
			// // Vector4 xxyz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3605, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3605, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xxzx(this Vector3 v)
		{
			// // Vector4 xxzx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3606, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3606, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xxzy(this Vector3 v)
		{
			// // Vector4 xxzy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3607, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3607, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xxzz(this Vector3 v)
		{
			// // Vector4 xxzz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   float v6; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v8; // rcx
			//   float z; // eax
			//   Vector3 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3608, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3608, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v11.x = *(_QWORD *)&v.x;
			//     v11.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     v6 = v.z;
			//     retstr.z = v6;
			//     retstr.w = v6;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xyxx(this Vector3 v)
		{
			// // Vector4 xyxx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3609, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3609, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xyxy(this Vector3 v)
		{
			// // Vector4 xyxy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3610, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3610, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xyxz(this Vector3 v)
		{
			// // Vector4 xyxz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3611, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3611, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xyyx(this Vector3 v)
		{
			// // Vector4 xyyx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3612, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3612, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xyyy(this Vector3 v)
		{
			// // Vector4 xyyy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3613, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3613, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xyyz(this Vector3 v)
		{
			// // Vector4 xyyz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3614, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3614, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xyzx(this Vector3 v)
		{
			// // Vector4 xyzx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // xmm0_8
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 1164 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 0x48C )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !v5[24].vtable.Equals.method )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1164, 0LL);
			//       if ( Patch )
			//       {
			//         v9 = *(_QWORD *)&v.x;
			//         v10.z = v.z;
			//         *(_QWORD *)&v10.x = v9;
			//         *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//         return retstr;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_7:
			//   retstr.x = v.x;
			//   retstr.y = v.y;
			//   retstr.z = v.z;
			//   retstr.w = v.x;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xyzy(this Vector3 v)
		{
			// // Vector4 xyzy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3615, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3615, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xyzz(this Vector3 v)
		{
			// // Vector4 xyzz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3616, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3616, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     v5 = v.z;
			//     retstr.z = v5;
			//     retstr.w = v5;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xzxx(this Vector3 v)
		{
			// // Vector4 xzxx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3617, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3617, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xzxy(this Vector3 v)
		{
			// // Vector4 xzxy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3618, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3618, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xzxz(this Vector3 v)
		{
			// // Vector4 xzxz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3619, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3619, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xzyx(this Vector3 v)
		{
			// // Vector4 xzyx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3620, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3620, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xzyy(this Vector3 v)
		{
			// // Vector4 xzyy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3621, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3621, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xzyz(this Vector3 v)
		{
			// // Vector4 xzyz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3622, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3622, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xzzx(this Vector3 v)
		{
			// // Vector4 xzzx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3623, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3623, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     v5 = v.z;
			//     retstr.y = v5;
			//     retstr.z = v5;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xzzy(this Vector3 v)
		{
			// // Vector4 xzzy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3624, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3624, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     v5 = v.z;
			//     retstr.y = v5;
			//     retstr.z = v5;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 xzzz(this Vector3 v)
		{
			// // Vector4 xzzz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3625, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3625, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     v5 = v.z;
			//     retstr.y = v5;
			//     retstr.z = v5;
			//     retstr.w = v5;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yxxx(this Vector3 v)
		{
			// // Vector4 yxxx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3626, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3626, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yxxy(this Vector3 v)
		{
			// // Vector4 yxxy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3627, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3627, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yxxz(this Vector3 v)
		{
			// // Vector4 yxxz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3628, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3628, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yxyx(this Vector3 v)
		{
			// // Vector4 yxyx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3629, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3629, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yxyy(this Vector3 v)
		{
			// // Vector4 yxyy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3630, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3630, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yxyz(this Vector3 v)
		{
			// // Vector4 yxyz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3631, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3631, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yxzx(this Vector3 v)
		{
			// // Vector4 yxzx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3632, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3632, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yxzy(this Vector3 v)
		{
			// // Vector4 yxzy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3633, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3633, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yxzz(this Vector3 v)
		{
			// // Vector4 yxzz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3634, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3634, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     v5 = v.z;
			//     retstr.z = v5;
			//     retstr.w = v5;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yyxx(this Vector3 v)
		{
			// // Vector4 yyxx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v8; // rcx
			//   float z; // eax
			//   Vector3 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3635, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3635, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v11.x = *(_QWORD *)&v.x;
			//     v11.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yyxy(this Vector3 v)
		{
			// // Vector4 yyxy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3636, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3636, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yyxz(this Vector3 v)
		{
			// // Vector4 yyxz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3637, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3637, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yyyx(this Vector3 v)
		{
			// // Vector4 yyyx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3638, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3638, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yyyy(this Vector3 v)
		{
			// // Vector4 yyyy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3639, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3639, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yyyz(this Vector3 v)
		{
			// // Vector4 yyyz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3640, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3640, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yyzx(this Vector3 v)
		{
			// // Vector4 yyzx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3641, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3641, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yyzy(this Vector3 v)
		{
			// // Vector4 yyzy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3642, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3642, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yyzz(this Vector3 v)
		{
			// // Vector4 yyzz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   float v6; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v8; // rcx
			//   float z; // eax
			//   Vector3 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3643, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3643, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v11.x = *(_QWORD *)&v.x;
			//     v11.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     v6 = v.z;
			//     retstr.z = v6;
			//     retstr.w = v6;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yzxx(this Vector3 v)
		{
			// // Vector4 yzxx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3644, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3644, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yzxy(this Vector3 v)
		{
			// // Vector4 yzxy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3645, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3645, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yzxz(this Vector3 v)
		{
			// // Vector4 yzxz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3646, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3646, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yzyx(this Vector3 v)
		{
			// // Vector4 yzyx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3647, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3647, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yzyy(this Vector3 v)
		{
			// // Vector4 yzyy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3648, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3648, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yzyz(this Vector3 v)
		{
			// // Vector4 yzyz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3649, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3649, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yzzx(this Vector3 v)
		{
			// // Vector4 yzzx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3650, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3650, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     v5 = v.z;
			//     retstr.y = v5;
			//     retstr.z = v5;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yzzy(this Vector3 v)
		{
			// // Vector4 yzzy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3651, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3651, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     v5 = v.z;
			//     retstr.y = v5;
			//     retstr.z = v5;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 yzzz(this Vector3 v)
		{
			// // Vector4 yzzz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3652, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3652, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     v5 = v.z;
			//     retstr.y = v5;
			//     retstr.z = v5;
			//     retstr.w = v5;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zxxx(this Vector3 v)
		{
			// // Vector4 zxxx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3653, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3653, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zxxy(this Vector3 v)
		{
			// // Vector4 zxxy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3654, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3654, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zxxz(this Vector3 v)
		{
			// // Vector4 zxxz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3655, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3655, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zxyx(this Vector3 v)
		{
			// // Vector4 zxyx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3656, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3656, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zxyy(this Vector3 v)
		{
			// // Vector4 zxyy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3657, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3657, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zxyz(this Vector3 v)
		{
			// // Vector4 zxyz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3658, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3658, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zxzx(this Vector3 v)
		{
			// // Vector4 zxzx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3659, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3659, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zxzy(this Vector3 v)
		{
			// // Vector4 zxzy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3660, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3660, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zxzz(this Vector3 v)
		{
			// // Vector4 zxzz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3661, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3661, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     v5 = v.z;
			//     retstr.z = v5;
			//     retstr.w = v5;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zyxx(this Vector3 v)
		{
			// // Vector4 zyxx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3662, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3662, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zyxy(this Vector3 v)
		{
			// // Vector4 zyxy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3663, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3663, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zyxz(this Vector3 v)
		{
			// // Vector4 zyxz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3664, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3664, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zyyx(this Vector3 v)
		{
			// // Vector4 zyyx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3665, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3665, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zyyy(this Vector3 v)
		{
			// // Vector4 zyyy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3666, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3666, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zyyz(this Vector3 v)
		{
			// // Vector4 zyyz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3667, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3667, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zyzx(this Vector3 v)
		{
			// // Vector4 zyzx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3668, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3668, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zyzy(this Vector3 v)
		{
			// // Vector4 zyzy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v6; // rcx
			//   float z; // eax
			//   Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3669, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3669, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v6, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v9.x = *(_QWORD *)&v.x;
			//     v9.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zyzz(this Vector3 v)
		{
			// // Vector4 zyzz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3670, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3670, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     v5 = v.z;
			//     retstr.z = v5;
			//     retstr.w = v5;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zzxx(this Vector3 v)
		{
			// // Vector4 zzxx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v8; // rcx
			//   float z; // eax
			//   Vector3 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3671, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3671, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v11.x = *(_QWORD *)&v.x;
			//     v11.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     v5 = v.z;
			//     retstr.x = v5;
			//     retstr.y = v5;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zzxy(this Vector3 v)
		{
			// // Vector4 zzxy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3672, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3672, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     v5 = v.z;
			//     retstr.x = v5;
			//     retstr.y = v5;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zzxz(this Vector3 v)
		{
			// // Vector4 zzxz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3673, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3673, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     v5 = v.z;
			//     retstr.x = v5;
			//     retstr.y = v5;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zzyx(this Vector3 v)
		{
			// // Vector4 zzyx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3674, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3674, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     v5 = v.z;
			//     retstr.x = v5;
			//     retstr.y = v5;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zzyy(this Vector3 v)
		{
			// // Vector4 zzyy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v8; // rcx
			//   float z; // eax
			//   Vector3 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3675, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3675, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v11.x = *(_QWORD *)&v.x;
			//     v11.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     v5 = v.z;
			//     retstr.x = v5;
			//     retstr.y = v5;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zzyz(this Vector3 v)
		{
			// // Vector4 zzyz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3676, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3676, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     v5 = v.z;
			//     retstr.x = v5;
			//     retstr.y = v5;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zzzx(this Vector3 v)
		{
			// // Vector4 zzzx(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3677, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3677, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     v5 = v.z;
			//     retstr.x = v5;
			//     retstr.y = v5;
			//     retstr.z = v5;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zzzy(this Vector3 v)
		{
			// // Vector4 zzzy(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3678, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3678, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     v5 = v.z;
			//     retstr.x = v5;
			//     retstr.y = v5;
			//     retstr.z = v5;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector4 zzzz(this Vector3 v)
		{
			// // Vector4 zzzz(Vector3)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v7; // rcx
			//   float z; // eax
			//   Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3679, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3679, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, 0LL);
			//     z = v.z;
			//     *(_QWORD *)&v10.x = *(_QWORD *)&v.x;
			//     v10.z = z;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     v5 = v.z;
			//     retstr.x = v5;
			//     retstr.y = v5;
			//     retstr.z = v5;
			//     retstr.w = v5;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(3)]
		public static Vector2 xx(this Vector4 v)
		{
			// // Vector2 xx(Vector4)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xx(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3680, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.x), (__m128)LODWORD(v.x)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3680, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static Vector2 xy(this Vector4 v)
		{
			// // Vector2 xy(Vector4)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xy(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1119, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.x), (__m128)LODWORD(v.y)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1119, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector2 xz(this Vector4 v)
		{
			// // Vector2 xz(Vector4)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xz(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3681, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.x), (__m128)LODWORD(v.z)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3681, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 xw(this Vector4 v)
		{
			// // Vector2 xw(Vector4)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xw(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3682, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.x), (__m128)LODWORD(v.w)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3682, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector2 yx(this Vector4 v)
		{
			// // Vector2 yx(Vector4)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yx(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3683, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.y), (__m128)LODWORD(v.x)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3683, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector2 yy(this Vector4 v)
		{
			// // Vector2 yy(Vector4)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yy(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3684, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.y), (__m128)LODWORD(v.y)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3684, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector2 yz(this Vector4 v)
		{
			// // Vector2 yz(Vector4)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yz(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3685, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.y), (__m128)LODWORD(v.z)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3685, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 yw(this Vector4 v)
		{
			// // Vector2 yw(Vector4)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yw(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3686, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.y), (__m128)LODWORD(v.w)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3686, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector2 zx(this Vector4 v)
		{
			// // Vector2 zx(Vector4)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::zx(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3687, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.z), (__m128)LODWORD(v.x)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3687, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector2 zy(this Vector4 v)
		{
			// // Vector2 zy(Vector4)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::zy(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3688, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.z), (__m128)LODWORD(v.y)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3688, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector2 zz(this Vector4 v)
		{
			// // Vector2 zz(Vector4)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::zz(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3689, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.z), (__m128)LODWORD(v.z)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3689, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 zw(this Vector4 v)
		{
			// // Vector2 zw(Vector4)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::zw(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3690, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.z), (__m128)LODWORD(v.w)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3690, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 wx(this Vector4 v)
		{
			// // Vector2 wx(Vector4)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::wx(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3691, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.w), (__m128)LODWORD(v.x)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3691, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 wy(this Vector4 v)
		{
			// // Vector2 wy(Vector4)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::wy(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3692, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.w), (__m128)LODWORD(v.y)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3692, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 wz(this Vector4 v)
		{
			// // Vector2 wz(Vector4)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::wz(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3693, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.w), (__m128)LODWORD(v.z)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3693, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 ww(this Vector4 v)
		{
			// // Vector2 ww(Vector4)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::ww(Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3694, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.w), (__m128)LODWORD(v.w)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3694, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *v;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		[IDTag(3)]
		public static Vector3 xxx(this Vector4 v)
		{
			// // Vector3 xxx(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3695, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3695, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     z = v.x;
			//     retstr.x = v.x;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector3 xxy(this Vector4 v)
		{
			// // Vector3 xxy(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3696, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3696, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *v;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     z = v.y;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 xxz(this Vector4 v)
		{
			// // Vector3 xxz(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3697, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3697, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *v;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     z = v.z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 xxw(this Vector4 v)
		{
			// // Vector3 xxw(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3698, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3698, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *v;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     z = v.w;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector3 xyx(this Vector4 v)
		{
			// // Vector3 xyx(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3699, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3699, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     z = v.x;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector3 xyy(this Vector4 v)
		{
			// // Vector3 xyy(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3700, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3700, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     z = v.y;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 xyz(this Vector4 v)
		{
			// // Vector3 xyz(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v);
			//     v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v5.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_9;
			//   if ( wrapperArray.max_length.size > 1165 )
			//   {
			//     if ( !v5._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v5, wrapperArray);
			//       v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5.static_fields.wrapperArray;
			//     if ( v5 )
			//     {
			//       if ( LODWORD(v5._0.namespaze) <= 0x48D )
			//         sub_180070270(v5, wrapperArray);
			//       if ( !v5[24].vtable.Finalize.methodPtr )
			//         goto LABEL_7;
			//       Patch = IFix::WrappersManagerImpl::GetPatch(1165, 0LL);
			//       if ( Patch )
			//       {
			//         v13 = *v;
			//         v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//         v11 = *(_QWORD *)&v10.x;
			//         z = v10.z;
			//         *(_QWORD *)&retstr.x = v11;
			//         goto LABEL_8;
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, wrapperArray);
			//   }
			// LABEL_7:
			//   retstr.x = v.x;
			//   retstr.y = v.y;
			//   z = v.z;
			// LABEL_8:
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 xyw(this Vector4 v)
		{
			// // Vector3 xyw(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3701, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3701, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     z = v.w;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 xzx(this Vector4 v)
		{
			// // Vector3 xzx(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xzx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3702, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3702, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     z = v.x;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 xzy(this Vector4 v)
		{
			// // Vector3 xzy(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xzy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3703, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3703, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     z = v.y;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 xzz(this Vector4 v)
		{
			// // Vector3 xzz(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xzz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3704, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3704, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     z = v.z;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 xzw(this Vector4 v)
		{
			// // Vector3 xzw(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xzw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3705, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3705, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     z = v.w;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 xwx(this Vector4 v)
		{
			// // Vector3 xwx(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xwx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3706, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3706, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.w;
			//     z = v.x;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 xwy(this Vector4 v)
		{
			// // Vector3 xwy(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xwy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3707, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3707, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.w;
			//     z = v.y;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 xwz(this Vector4 v)
		{
			// // Vector3 xwz(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xwz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3708, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3708, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.w;
			//     z = v.z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 xww(this Vector4 v)
		{
			// // Vector3 xww(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xww(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3709, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3709, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     z = v.w;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector3 yxx(this Vector4 v)
		{
			// // Vector3 yxx(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3710, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3710, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     z = v.x;
			//     retstr.y = v.x;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector3 yxy(this Vector4 v)
		{
			// // Vector3 yxy(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3711, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3711, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     z = v.y;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 yxz(this Vector4 v)
		{
			// // Vector3 yxz(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3712, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3712, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     z = v.z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 yxw(this Vector4 v)
		{
			// // Vector3 yxw(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3713, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3713, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     z = v.w;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector3 yyx(this Vector4 v)
		{
			// // Vector3 yyx(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3714, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3714, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *v;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     z = v.x;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector3 yyy(this Vector4 v)
		{
			// // Vector3 yyy(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3715, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3715, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     z = v.y;
			//     retstr.x = z;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 yyz(this Vector4 v)
		{
			// // Vector3 yyz(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3716, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3716, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *v;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     z = v.z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 yyw(this Vector4 v)
		{
			// // Vector3 yyw(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3717, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3717, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *v;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     z = v.w;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 yzx(this Vector4 v)
		{
			// // Vector3 yzx(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yzx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3718, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3718, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     z = v.x;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 yzy(this Vector4 v)
		{
			// // Vector3 yzy(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yzy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3719, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3719, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     z = v.y;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 yzz(this Vector4 v)
		{
			// // Vector3 yzz(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yzz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3720, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3720, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     z = v.z;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 yzw(this Vector4 v)
		{
			// // Vector3 yzw(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yzw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3721, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3721, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     z = v.w;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 ywx(this Vector4 v)
		{
			// // Vector3 ywx(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::ywx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3722, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3722, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.w;
			//     z = v.x;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 ywy(this Vector4 v)
		{
			// // Vector3 ywy(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::ywy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3723, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3723, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.w;
			//     z = v.y;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 ywz(this Vector4 v)
		{
			// // Vector3 ywz(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::ywz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3724, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3724, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.w;
			//     z = v.z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 yww(this Vector4 v)
		{
			// // Vector3 yww(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yww(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3725, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3725, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     z = v.w;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 zxx(this Vector4 v)
		{
			// // Vector3 zxx(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zxx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3726, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3726, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     z = v.x;
			//     retstr.y = v.x;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 zxy(this Vector4 v)
		{
			// // Vector3 zxy(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zxy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3727, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3727, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     z = v.y;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 zxz(this Vector4 v)
		{
			// // Vector3 zxz(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zxz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3728, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3728, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     z = v.z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 zxw(this Vector4 v)
		{
			// // Vector3 zxw(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zxw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3729, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3729, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     z = v.w;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 zyx(this Vector4 v)
		{
			// // Vector3 zyx(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zyx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3730, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3730, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     z = v.x;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 zyy(this Vector4 v)
		{
			// // Vector3 zyy(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zyy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3731, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3731, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     z = v.y;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 zyz(this Vector4 v)
		{
			// // Vector3 zyz(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zyz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3732, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3732, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     z = v.z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 zyw(this Vector4 v)
		{
			// // Vector3 zyw(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zyw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3733, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3733, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     z = v.w;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 zzx(this Vector4 v)
		{
			// // Vector3 zzx(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zzx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3734, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3734, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *v;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     v5 = v.z;
			//     retstr.x = v5;
			//     retstr.y = v5;
			//     z = v.x;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 zzy(this Vector4 v)
		{
			// // Vector3 zzy(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zzy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3735, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3735, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *v;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     v5 = v.z;
			//     retstr.x = v5;
			//     retstr.y = v5;
			//     z = v.y;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector3 zzz(this Vector4 v)
		{
			// // Vector3 zzz(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zzz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3736, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3736, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 zzw(this Vector4 v)
		{
			// // Vector3 zzw(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zzw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float v5; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3737, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3737, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *v;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     v5 = v.z;
			//     retstr.x = v5;
			//     retstr.y = v5;
			//     z = v.w;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 zwx(this Vector4 v)
		{
			// // Vector3 zwx(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zwx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3738, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3738, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.w;
			//     z = v.x;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 zwy(this Vector4 v)
		{
			// // Vector3 zwy(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zwy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3739, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3739, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.w;
			//     z = v.y;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 zwz(this Vector4 v)
		{
			// // Vector3 zwz(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zwz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3740, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3740, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.w;
			//     z = v.z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 zww(this Vector4 v)
		{
			// // Vector3 zww(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zww(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3741, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3741, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     z = v.w;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 wxx(this Vector4 v)
		{
			// // Vector3 wxx(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wxx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3742, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3742, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     z = v.x;
			//     retstr.y = v.x;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 wxy(this Vector4 v)
		{
			// // Vector3 wxy(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wxy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3743, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3743, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.x;
			//     z = v.y;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 wxz(this Vector4 v)
		{
			// // Vector3 wxz(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wxz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3744, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3744, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.x;
			//     z = v.z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 wxw(this Vector4 v)
		{
			// // Vector3 wxw(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wxw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3745, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3745, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.x;
			//     z = v.w;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 wyx(this Vector4 v)
		{
			// // Vector3 wyx(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wyx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3746, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3746, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.y;
			//     z = v.x;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 wyy(this Vector4 v)
		{
			// // Vector3 wyy(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wyy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3747, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3747, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     z = v.y;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 wyz(this Vector4 v)
		{
			// // Vector3 wyz(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wyz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3748, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3748, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.y;
			//     z = v.z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 wyw(this Vector4 v)
		{
			// // Vector3 wyw(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wyw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3749, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3749, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.y;
			//     z = v.w;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 wzx(this Vector4 v)
		{
			// // Vector3 wzx(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wzx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3750, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3750, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.z;
			//     z = v.x;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 wzy(this Vector4 v)
		{
			// // Vector3 wzy(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wzy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3751, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3751, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.z;
			//     z = v.y;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 wzz(this Vector4 v)
		{
			// // Vector3 wzz(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wzz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3752, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3752, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     z = v.z;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 wzw(this Vector4 v)
		{
			// // Vector3 wzw(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wzw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3753, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3753, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.z;
			//     z = v.w;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 wwx(this Vector4 v)
		{
			// // Vector3 wwx(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wwx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3754, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3754, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *v;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     z = v.x;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 wwy(this Vector4 v)
		{
			// // Vector3 wwy(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wwy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3755, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3755, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *v;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     z = v.y;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 wwz(this Vector4 v)
		{
			// // Vector3 wwz(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wwz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3756, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3756, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *v;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     z = v.z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 www(this Vector4 v)
		{
			// // Vector3 www(Vector4)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::www(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3757, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3757, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *v;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_433(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     z = v.w;
			//     retstr.x = z;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(3)]
		public static Vector4 xxxx(this Vector4 v)
		{
			// // Vector4 xxxx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3758, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3758, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     *(__m128 *)retstr = _mm_shuffle_ps((__m128)LODWORD(v.x), (__m128)LODWORD(v.x), 0);
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 xxxy(this Vector4 v)
		{
			// // Vector4 xxxy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3759, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3759, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xxxz(this Vector4 v)
		{
			// // Vector4 xxxz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3760, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3760, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xxxw(this Vector4 v)
		{
			// // Vector4 xxxw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3761, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3761, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = x;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 xxyx(this Vector4 v)
		{
			// // Vector4 xxyx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3762, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3762, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 xxyy(this Vector4 v)
		{
			// // Vector4 xxyy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3763, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3763, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xxyz(this Vector4 v)
		{
			// // Vector4 xxyz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3764, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3764, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xxyw(this Vector4 v)
		{
			// // Vector4 xxyw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3765, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3765, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = v.y;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xxzx(this Vector4 v)
		{
			// // Vector4 xxzx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3766, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3766, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xxzy(this Vector4 v)
		{
			// // Vector4 xxzy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3767, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3767, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xxzz(this Vector4 v)
		{
			// // Vector4 xxzz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3768, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3768, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     z = v.z;
			//     retstr.z = z;
			//     retstr.w = z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xxzw(this Vector4 v)
		{
			// // Vector4 xxzw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3769, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3769, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = v.z;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xxwx(this Vector4 v)
		{
			// // Vector4 xxwx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3770, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3770, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = v.w;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xxwy(this Vector4 v)
		{
			// // Vector4 xxwy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3771, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3771, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = v.w;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xxwz(this Vector4 v)
		{
			// // Vector4 xxwz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3772, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3772, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     retstr.z = v.w;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xxww(this Vector4 v)
		{
			// // Vector4 xxww(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3773, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3773, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     x = v.x;
			//     retstr.x = v.x;
			//     retstr.y = x;
			//     w = v.w;
			//     retstr.z = w;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 xyxx(this Vector4 v)
		{
			// // Vector4 xyxx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3774, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3774, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 xyxy(this Vector4 v)
		{
			// // Vector4 xyxy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3775, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3775, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xyxz(this Vector4 v)
		{
			// // Vector4 xyxz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3776, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3776, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xyxw(this Vector4 v)
		{
			// // Vector4 xyxw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3777, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3777, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     retstr.z = v.x;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 xyyx(this Vector4 v)
		{
			// // Vector4 xyyx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3778, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3778, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 xyyy(this Vector4 v)
		{
			// // Vector4 xyyy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3779, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3779, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xyyz(this Vector4 v)
		{
			// // Vector4 xyyz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3780, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3780, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xyyw(this Vector4 v)
		{
			// // Vector4 xyyw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3781, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3781, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xyzx(this Vector4 v)
		{
			// // Vector4 xyzx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3782, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3782, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xyzy(this Vector4 v)
		{
			// // Vector4 xyzy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3783, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3783, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xyzz(this Vector4 v)
		{
			// // Vector4 xyzz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3784, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3784, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     z = v.z;
			//     retstr.z = z;
			//     retstr.w = z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xyzw(this Vector4 v)
		{
			// // Vector4 xyzw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3785, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3785, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     retstr.z = v.z;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xywx(this Vector4 v)
		{
			// // Vector4 xywx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xywx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3786, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3786, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     retstr.z = v.w;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xywy(this Vector4 v)
		{
			// // Vector4 xywy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xywy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3787, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3787, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     retstr.z = v.w;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xywz(this Vector4 v)
		{
			// // Vector4 xywz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xywz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3788, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3788, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     retstr.z = v.w;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xyww(this Vector4 v)
		{
			// // Vector4 xyww(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3789, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3789, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.y;
			//     w = v.w;
			//     retstr.z = w;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xzxx(this Vector4 v)
		{
			// // Vector4 xzxx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3790, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3790, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xzxy(this Vector4 v)
		{
			// // Vector4 xzxy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3791, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3791, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xzxz(this Vector4 v)
		{
			// // Vector4 xzxz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3792, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3792, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xzxw(this Vector4 v)
		{
			// // Vector4 xzxw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3793, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3793, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     retstr.z = v.x;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xzyx(this Vector4 v)
		{
			// // Vector4 xzyx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3794, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3794, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xzyy(this Vector4 v)
		{
			// // Vector4 xzyy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3795, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3795, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xzyz(this Vector4 v)
		{
			// // Vector4 xzyz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3796, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3796, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xzyw(this Vector4 v)
		{
			// // Vector4 xzyw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3797, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3797, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     retstr.z = v.y;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xzzx(this Vector4 v)
		{
			// // Vector4 xzzx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3798, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3798, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     z = v.z;
			//     retstr.y = z;
			//     retstr.z = z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xzzy(this Vector4 v)
		{
			// // Vector4 xzzy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3799, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3799, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     z = v.z;
			//     retstr.y = z;
			//     retstr.z = z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 xzzz(this Vector4 v)
		{
			// // Vector4 xzzz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3800, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3800, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     z = v.z;
			//     retstr.y = z;
			//     retstr.z = z;
			//     retstr.w = z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xzzw(this Vector4 v)
		{
			// // Vector4 xzzw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3801, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3801, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     z = v.z;
			//     retstr.y = z;
			//     retstr.z = z;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xzwx(this Vector4 v)
		{
			// // Vector4 xzwx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3802, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3802, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     retstr.z = v.w;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xzwy(this Vector4 v)
		{
			// // Vector4 xzwy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3803, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3803, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     retstr.z = v.w;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xzwz(this Vector4 v)
		{
			// // Vector4 xzwz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3804, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3804, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     retstr.z = v.w;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xzww(this Vector4 v)
		{
			// // Vector4 xzww(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3805, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3805, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.z;
			//     w = v.w;
			//     retstr.z = w;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xwxx(this Vector4 v)
		{
			// // Vector4 xwxx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3806, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3806, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.w;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xwxy(this Vector4 v)
		{
			// // Vector4 xwxy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3807, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3807, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.w;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xwxz(this Vector4 v)
		{
			// // Vector4 xwxz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3808, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3808, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.w;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xwxw(this Vector4 v)
		{
			// // Vector4 xwxw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3809, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3809, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.w;
			//     retstr.z = v.x;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xwyx(this Vector4 v)
		{
			// // Vector4 xwyx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3810, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3810, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.w;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xwyy(this Vector4 v)
		{
			// // Vector4 xwyy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3811, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3811, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.w;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xwyz(this Vector4 v)
		{
			// // Vector4 xwyz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3812, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3812, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.w;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xwyw(this Vector4 v)
		{
			// // Vector4 xwyw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3813, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3813, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.w;
			//     retstr.z = v.y;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xwzx(this Vector4 v)
		{
			// // Vector4 xwzx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3814, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3814, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.w;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xwzy(this Vector4 v)
		{
			// // Vector4 xwzy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3815, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3815, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.w;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xwzz(this Vector4 v)
		{
			// // Vector4 xwzz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3816, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3816, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.w;
			//     z = v.z;
			//     retstr.z = z;
			//     retstr.w = z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xwzw(this Vector4 v)
		{
			// // Vector4 xwzw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3817, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3817, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     retstr.y = v.w;
			//     retstr.z = v.z;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xwwx(this Vector4 v)
		{
			// // Vector4 xwwx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3818, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3818, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     w = v.w;
			//     retstr.y = w;
			//     retstr.z = w;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xwwy(this Vector4 v)
		{
			// // Vector4 xwwy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3819, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3819, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     w = v.w;
			//     retstr.y = w;
			//     retstr.z = w;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xwwz(this Vector4 v)
		{
			// // Vector4 xwwz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3820, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3820, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     w = v.w;
			//     retstr.y = w;
			//     retstr.z = w;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 xwww(this Vector4 v)
		{
			// // Vector4 xwww(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3821, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3821, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.x;
			//     w = v.w;
			//     retstr.y = w;
			//     retstr.z = w;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 yxxx(this Vector4 v)
		{
			// // Vector4 yxxx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3822, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3822, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 yxxy(this Vector4 v)
		{
			// // Vector4 yxxy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3823, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3823, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yxxz(this Vector4 v)
		{
			// // Vector4 yxxz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3824, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3824, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yxxw(this Vector4 v)
		{
			// // Vector4 yxxw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3825, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3825, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 yxyx(this Vector4 v)
		{
			// // Vector4 yxyx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3826, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3826, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 yxyy(this Vector4 v)
		{
			// // Vector4 yxyy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3827, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3827, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yxyz(this Vector4 v)
		{
			// // Vector4 yxyz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3828, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3828, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yxyw(this Vector4 v)
		{
			// // Vector4 yxyw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3829, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3829, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     retstr.z = v.y;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yxzx(this Vector4 v)
		{
			// // Vector4 yxzx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3830, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3830, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yxzy(this Vector4 v)
		{
			// // Vector4 yxzy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3831, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3831, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yxzz(this Vector4 v)
		{
			// // Vector4 yxzz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3832, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3832, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     z = v.z;
			//     retstr.z = z;
			//     retstr.w = z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yxzw(this Vector4 v)
		{
			// // Vector4 yxzw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3833, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3833, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     retstr.z = v.z;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yxwx(this Vector4 v)
		{
			// // Vector4 yxwx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3834, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3834, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     retstr.z = v.w;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yxwy(this Vector4 v)
		{
			// // Vector4 yxwy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3835, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3835, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     retstr.z = v.w;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yxwz(this Vector4 v)
		{
			// // Vector4 yxwz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3836, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3836, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     retstr.z = v.w;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yxww(this Vector4 v)
		{
			// // Vector4 yxww(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3837, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3837, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.x;
			//     w = v.w;
			//     retstr.z = w;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 yyxx(this Vector4 v)
		{
			// // Vector4 yyxx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3838, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3838, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 yyxy(this Vector4 v)
		{
			// // Vector4 yyxy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3839, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3839, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yyxz(this Vector4 v)
		{
			// // Vector4 yyxz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3840, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3840, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yyxw(this Vector4 v)
		{
			// // Vector4 yyxw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3841, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3841, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = v.x;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 yyyx(this Vector4 v)
		{
			// // Vector4 yyyx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3842, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3842, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static Vector4 yyyy(this Vector4 v)
		{
			// // Vector4 yyyy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3843, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3843, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yyyz(this Vector4 v)
		{
			// // Vector4 yyyz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3844, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3844, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yyyw(this Vector4 v)
		{
			// // Vector4 yyyw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3845, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3845, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yyzx(this Vector4 v)
		{
			// // Vector4 yyzx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3846, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3846, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yyzy(this Vector4 v)
		{
			// // Vector4 yyzy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3847, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3847, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yyzz(this Vector4 v)
		{
			// // Vector4 yyzz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3848, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3848, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     z = v.z;
			//     retstr.z = z;
			//     retstr.w = z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yyzw(this Vector4 v)
		{
			// // Vector4 yyzw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3849, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3849, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = v.z;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yywx(this Vector4 v)
		{
			// // Vector4 yywx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yywx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3850, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3850, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = v.w;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yywy(this Vector4 v)
		{
			// // Vector4 yywy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yywy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3851, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3851, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = v.w;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yywz(this Vector4 v)
		{
			// // Vector4 yywz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yywz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3852, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3852, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     retstr.z = v.w;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yyww(this Vector4 v)
		{
			// // Vector4 yyww(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3853, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3853, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     y = v.y;
			//     retstr.x = y;
			//     retstr.y = y;
			//     w = v.w;
			//     retstr.z = w;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yzxx(this Vector4 v)
		{
			// // Vector4 yzxx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3854, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3854, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yzxy(this Vector4 v)
		{
			// // Vector4 yzxy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3855, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3855, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yzxz(this Vector4 v)
		{
			// // Vector4 yzxz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3856, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3856, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yzxw(this Vector4 v)
		{
			// // Vector4 yzxw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3857, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3857, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     retstr.z = v.x;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yzyx(this Vector4 v)
		{
			// // Vector4 yzyx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3858, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3858, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yzyy(this Vector4 v)
		{
			// // Vector4 yzyy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3859, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3859, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yzyz(this Vector4 v)
		{
			// // Vector4 yzyz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3860, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3860, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yzyw(this Vector4 v)
		{
			// // Vector4 yzyw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3861, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3861, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     retstr.z = v.y;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yzzx(this Vector4 v)
		{
			// // Vector4 yzzx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3862, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3862, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     z = v.z;
			//     retstr.y = z;
			//     retstr.z = z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yzzy(this Vector4 v)
		{
			// // Vector4 yzzy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3863, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3863, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     z = v.z;
			//     retstr.y = z;
			//     retstr.z = z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 yzzz(this Vector4 v)
		{
			// // Vector4 yzzz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3864, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3864, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     z = v.z;
			//     retstr.y = z;
			//     retstr.z = z;
			//     retstr.w = z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yzzw(this Vector4 v)
		{
			// // Vector4 yzzw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3865, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3865, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     z = v.z;
			//     retstr.y = z;
			//     retstr.z = z;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yzwx(this Vector4 v)
		{
			// // Vector4 yzwx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3866, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3866, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     retstr.z = v.w;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yzwy(this Vector4 v)
		{
			// // Vector4 yzwy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3867, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3867, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     retstr.z = v.w;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yzwz(this Vector4 v)
		{
			// // Vector4 yzwz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3868, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3868, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     retstr.z = v.w;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 yzww(this Vector4 v)
		{
			// // Vector4 yzww(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3869, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3869, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.z;
			//     w = v.w;
			//     retstr.z = w;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 ywxx(this Vector4 v)
		{
			// // Vector4 ywxx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3870, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3870, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.w;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 ywxy(this Vector4 v)
		{
			// // Vector4 ywxy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3871, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3871, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.w;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 ywxz(this Vector4 v)
		{
			// // Vector4 ywxz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3872, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3872, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.w;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 ywxw(this Vector4 v)
		{
			// // Vector4 ywxw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3873, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3873, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.w;
			//     retstr.z = v.x;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 ywyx(this Vector4 v)
		{
			// // Vector4 ywyx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3874, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3874, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.w;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 ywyy(this Vector4 v)
		{
			// // Vector4 ywyy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3875, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3875, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.w;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 ywyz(this Vector4 v)
		{
			// // Vector4 ywyz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3876, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3876, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.w;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 ywyw(this Vector4 v)
		{
			// // Vector4 ywyw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3877, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3877, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.w;
			//     retstr.z = v.y;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 ywzx(this Vector4 v)
		{
			// // Vector4 ywzx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3878, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3878, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.w;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 ywzy(this Vector4 v)
		{
			// // Vector4 ywzy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3879, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3879, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.w;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 ywzz(this Vector4 v)
		{
			// // Vector4 ywzz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3880, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3880, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.w;
			//     z = v.z;
			//     retstr.z = z;
			//     retstr.w = z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 ywzw(this Vector4 v)
		{
			// // Vector4 ywzw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3881, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3881, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     retstr.y = v.w;
			//     retstr.z = v.z;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 ywwx(this Vector4 v)
		{
			// // Vector4 ywwx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3882, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3882, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     w = v.w;
			//     retstr.y = w;
			//     retstr.z = w;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 ywwy(this Vector4 v)
		{
			// // Vector4 ywwy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3883, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3883, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     w = v.w;
			//     retstr.y = w;
			//     retstr.z = w;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 ywwz(this Vector4 v)
		{
			// // Vector4 ywwz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3884, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3884, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     w = v.w;
			//     retstr.y = w;
			//     retstr.z = w;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 ywww(this Vector4 v)
		{
			// // Vector4 ywww(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3885, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3885, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.y;
			//     w = v.w;
			//     retstr.y = w;
			//     retstr.z = w;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zxxx(this Vector4 v)
		{
			// // Vector4 zxxx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3886, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3886, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zxxy(this Vector4 v)
		{
			// // Vector4 zxxy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3887, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3887, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zxxz(this Vector4 v)
		{
			// // Vector4 zxxz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3888, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3888, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zxxw(this Vector4 v)
		{
			// // Vector4 zxxw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3889, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3889, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zxyx(this Vector4 v)
		{
			// // Vector4 zxyx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3890, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3890, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zxyy(this Vector4 v)
		{
			// // Vector4 zxyy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3891, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3891, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zxyz(this Vector4 v)
		{
			// // Vector4 zxyz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3892, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3892, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zxyw(this Vector4 v)
		{
			// // Vector4 zxyw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3893, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3893, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     retstr.z = v.y;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zxzx(this Vector4 v)
		{
			// // Vector4 zxzx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3894, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3894, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zxzy(this Vector4 v)
		{
			// // Vector4 zxzy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3895, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3895, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zxzz(this Vector4 v)
		{
			// // Vector4 zxzz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3896, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3896, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     z = v.z;
			//     retstr.z = z;
			//     retstr.w = z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zxzw(this Vector4 v)
		{
			// // Vector4 zxzw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3897, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3897, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     retstr.z = v.z;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zxwx(this Vector4 v)
		{
			// // Vector4 zxwx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3898, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3898, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     retstr.z = v.w;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zxwy(this Vector4 v)
		{
			// // Vector4 zxwy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3899, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3899, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     retstr.z = v.w;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zxwz(this Vector4 v)
		{
			// // Vector4 zxwz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3900, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3900, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     retstr.z = v.w;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zxww(this Vector4 v)
		{
			// // Vector4 zxww(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3901, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3901, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.x;
			//     w = v.w;
			//     retstr.z = w;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zyxx(this Vector4 v)
		{
			// // Vector4 zyxx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3902, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3902, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zyxy(this Vector4 v)
		{
			// // Vector4 zyxy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3903, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3903, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zyxz(this Vector4 v)
		{
			// // Vector4 zyxz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3904, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3904, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zyxw(this Vector4 v)
		{
			// // Vector4 zyxw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3905, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3905, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     retstr.z = v.x;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zyyx(this Vector4 v)
		{
			// // Vector4 zyyx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3906, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3906, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zyyy(this Vector4 v)
		{
			// // Vector4 zyyy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3907, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3907, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zyyz(this Vector4 v)
		{
			// // Vector4 zyyz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3908, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3908, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zyyw(this Vector4 v)
		{
			// // Vector4 zyyw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3909, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3909, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zyzx(this Vector4 v)
		{
			// // Vector4 zyzx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3910, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3910, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zyzy(this Vector4 v)
		{
			// // Vector4 zyzy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3911, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3911, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zyzz(this Vector4 v)
		{
			// // Vector4 zyzz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3912, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3912, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     z = v.z;
			//     retstr.z = z;
			//     retstr.w = z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zyzw(this Vector4 v)
		{
			// // Vector4 zyzw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3913, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3913, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     retstr.z = v.z;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zywx(this Vector4 v)
		{
			// // Vector4 zywx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zywx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3914, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3914, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     retstr.z = v.w;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zywy(this Vector4 v)
		{
			// // Vector4 zywy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zywy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3915, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3915, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     retstr.z = v.w;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zywz(this Vector4 v)
		{
			// // Vector4 zywz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zywz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3916, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3916, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     retstr.z = v.w;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zyww(this Vector4 v)
		{
			// // Vector4 zyww(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3917, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3917, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.y;
			//     w = v.w;
			//     retstr.z = w;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zzxx(this Vector4 v)
		{
			// // Vector4 zzxx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3918, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3918, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zzxy(this Vector4 v)
		{
			// // Vector4 zzxy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3919, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3919, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zzxz(this Vector4 v)
		{
			// // Vector4 zzxz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3920, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3920, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zzxw(this Vector4 v)
		{
			// // Vector4 zzxw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3921, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3921, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//     retstr.z = v.x;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zzyx(this Vector4 v)
		{
			// // Vector4 zzyx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3922, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3922, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zzyy(this Vector4 v)
		{
			// // Vector4 zzyy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3923, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3923, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zzyz(this Vector4 v)
		{
			// // Vector4 zzyz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3924, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3924, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zzyw(this Vector4 v)
		{
			// // Vector4 zzyw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3925, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3925, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//     retstr.z = v.y;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zzzx(this Vector4 v)
		{
			// // Vector4 zzzx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3926, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3926, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//     retstr.z = z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zzzy(this Vector4 v)
		{
			// // Vector4 zzzy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3927, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3927, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//     retstr.z = z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static Vector4 zzzz(this Vector4 v)
		{
			// // Vector4 zzzz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3928, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3928, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//     retstr.z = z;
			//     retstr.w = z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zzzw(this Vector4 v)
		{
			// // Vector4 zzzw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3929, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3929, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//     retstr.z = z;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zzwx(this Vector4 v)
		{
			// // Vector4 zzwx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3930, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3930, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//     retstr.z = v.w;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zzwy(this Vector4 v)
		{
			// // Vector4 zzwy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3931, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3931, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//     retstr.z = v.w;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zzwz(this Vector4 v)
		{
			// // Vector4 zzwz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3932, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3932, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//     retstr.z = v.w;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zzww(this Vector4 v)
		{
			// // Vector4 zzww(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3933, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3933, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     z = v.z;
			//     retstr.x = z;
			//     retstr.y = z;
			//     w = v.w;
			//     retstr.z = w;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zwxx(this Vector4 v)
		{
			// // Vector4 zwxx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3934, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3934, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.w;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zwxy(this Vector4 v)
		{
			// // Vector4 zwxy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3935, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3935, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.w;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zwxz(this Vector4 v)
		{
			// // Vector4 zwxz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3936, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3936, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.w;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zwxw(this Vector4 v)
		{
			// // Vector4 zwxw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3937, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3937, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.w;
			//     retstr.z = v.x;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zwyx(this Vector4 v)
		{
			// // Vector4 zwyx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3938, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3938, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.w;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zwyy(this Vector4 v)
		{
			// // Vector4 zwyy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3939, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3939, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.w;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zwyz(this Vector4 v)
		{
			// // Vector4 zwyz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3940, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3940, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.w;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zwyw(this Vector4 v)
		{
			// // Vector4 zwyw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3941, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3941, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.w;
			//     retstr.z = v.y;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zwzx(this Vector4 v)
		{
			// // Vector4 zwzx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3942, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3942, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.w;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zwzy(this Vector4 v)
		{
			// // Vector4 zwzy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3943, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3943, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.w;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zwzz(this Vector4 v)
		{
			// // Vector4 zwzz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3944, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3944, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.w;
			//     z = v.z;
			//     retstr.z = z;
			//     retstr.w = z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zwzw(this Vector4 v)
		{
			// // Vector4 zwzw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3945, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3945, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     retstr.y = v.w;
			//     retstr.z = v.z;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zwwx(this Vector4 v)
		{
			// // Vector4 zwwx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3946, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3946, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     w = v.w;
			//     retstr.y = w;
			//     retstr.z = w;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zwwy(this Vector4 v)
		{
			// // Vector4 zwwy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3947, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3947, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     w = v.w;
			//     retstr.y = w;
			//     retstr.z = w;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zwwz(this Vector4 v)
		{
			// // Vector4 zwwz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3948, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3948, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     w = v.w;
			//     retstr.y = w;
			//     retstr.z = w;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 zwww(this Vector4 v)
		{
			// // Vector4 zwww(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3949, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3949, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.z;
			//     w = v.w;
			//     retstr.y = w;
			//     retstr.z = w;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wxxx(this Vector4 v)
		{
			// // Vector4 wxxx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3950, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3950, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wxxy(this Vector4 v)
		{
			// // Vector4 wxxy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3951, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3951, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wxxz(this Vector4 v)
		{
			// // Vector4 wxxz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3952, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3952, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wxxw(this Vector4 v)
		{
			// // Vector4 wxxw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3953, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3953, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     x = v.x;
			//     retstr.y = v.x;
			//     retstr.z = x;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wxyx(this Vector4 v)
		{
			// // Vector4 wxyx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3954, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3954, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.x;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wxyy(this Vector4 v)
		{
			// // Vector4 wxyy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3955, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3955, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.x;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wxyz(this Vector4 v)
		{
			// // Vector4 wxyz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3956, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3956, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.x;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wxyw(this Vector4 v)
		{
			// // Vector4 wxyw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3957, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3957, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.x;
			//     retstr.z = v.y;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wxzx(this Vector4 v)
		{
			// // Vector4 wxzx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3958, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3958, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.x;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wxzy(this Vector4 v)
		{
			// // Vector4 wxzy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3959, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3959, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.x;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wxzz(this Vector4 v)
		{
			// // Vector4 wxzz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3960, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3960, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.x;
			//     z = v.z;
			//     retstr.z = z;
			//     retstr.w = z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wxzw(this Vector4 v)
		{
			// // Vector4 wxzw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3961, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3961, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.x;
			//     retstr.z = v.z;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wxwx(this Vector4 v)
		{
			// // Vector4 wxwx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3962, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3962, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.x;
			//     retstr.z = v.w;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wxwy(this Vector4 v)
		{
			// // Vector4 wxwy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3963, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3963, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.x;
			//     retstr.z = v.w;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wxwz(this Vector4 v)
		{
			// // Vector4 wxwz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3964, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3964, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.x;
			//     retstr.z = v.w;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wxww(this Vector4 v)
		{
			// // Vector4 wxww(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3965, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3965, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.x;
			//     w = v.w;
			//     retstr.z = w;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wyxx(this Vector4 v)
		{
			// // Vector4 wyxx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3966, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3966, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.y;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wyxy(this Vector4 v)
		{
			// // Vector4 wyxy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3967, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3967, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.y;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wyxz(this Vector4 v)
		{
			// // Vector4 wyxz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3968, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3968, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.y;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wyxw(this Vector4 v)
		{
			// // Vector4 wyxw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3969, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3969, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.y;
			//     retstr.z = v.x;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wyyx(this Vector4 v)
		{
			// // Vector4 wyyx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3970, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3970, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wyyy(this Vector4 v)
		{
			// // Vector4 wyyy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3971, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3971, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wyyz(this Vector4 v)
		{
			// // Vector4 wyyz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3972, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3972, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wyyw(this Vector4 v)
		{
			// // Vector4 wyyw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3973, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3973, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     y = v.y;
			//     retstr.y = y;
			//     retstr.z = y;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wyzx(this Vector4 v)
		{
			// // Vector4 wyzx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3974, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3974, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.y;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wyzy(this Vector4 v)
		{
			// // Vector4 wyzy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3975, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3975, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.y;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wyzz(this Vector4 v)
		{
			// // Vector4 wyzz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3976, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3976, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.y;
			//     z = v.z;
			//     retstr.z = z;
			//     retstr.w = z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wyzw(this Vector4 v)
		{
			// // Vector4 wyzw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3977, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3977, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.y;
			//     retstr.z = v.z;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wywx(this Vector4 v)
		{
			// // Vector4 wywx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wywx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3978, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3978, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.y;
			//     retstr.z = v.w;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wywy(this Vector4 v)
		{
			// // Vector4 wywy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wywy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3979, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3979, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.y;
			//     retstr.z = v.w;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wywz(this Vector4 v)
		{
			// // Vector4 wywz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wywz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3980, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3980, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.y;
			//     retstr.z = v.w;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wyww(this Vector4 v)
		{
			// // Vector4 wyww(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3981, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3981, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.y;
			//     w = v.w;
			//     retstr.z = w;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wzxx(this Vector4 v)
		{
			// // Vector4 wzxx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3982, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3982, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.z;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wzxy(this Vector4 v)
		{
			// // Vector4 wzxy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3983, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3983, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.z;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wzxz(this Vector4 v)
		{
			// // Vector4 wzxz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3984, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3984, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.z;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wzxw(this Vector4 v)
		{
			// // Vector4 wzxw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3985, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3985, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.z;
			//     retstr.z = v.x;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wzyx(this Vector4 v)
		{
			// // Vector4 wzyx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3986, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3986, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.z;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wzyy(this Vector4 v)
		{
			// // Vector4 wzyy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3987, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3987, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.z;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wzyz(this Vector4 v)
		{
			// // Vector4 wzyz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3988, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3988, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.z;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wzyw(this Vector4 v)
		{
			// // Vector4 wzyw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3989, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3989, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.z;
			//     retstr.z = v.y;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wzzx(this Vector4 v)
		{
			// // Vector4 wzzx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3990, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3990, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     z = v.z;
			//     retstr.y = z;
			//     retstr.z = z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wzzy(this Vector4 v)
		{
			// // Vector4 wzzy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3991, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3991, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     z = v.z;
			//     retstr.y = z;
			//     retstr.z = z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wzzz(this Vector4 v)
		{
			// // Vector4 wzzz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3992, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3992, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     z = v.z;
			//     retstr.y = z;
			//     retstr.z = z;
			//     retstr.w = z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wzzw(this Vector4 v)
		{
			// // Vector4 wzzw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3993, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3993, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     z = v.z;
			//     retstr.y = z;
			//     retstr.z = z;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wzwx(this Vector4 v)
		{
			// // Vector4 wzwx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3994, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3994, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.z;
			//     retstr.z = v.w;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wzwy(this Vector4 v)
		{
			// // Vector4 wzwy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3995, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3995, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.z;
			//     retstr.z = v.w;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wzwz(this Vector4 v)
		{
			// // Vector4 wzwz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3996, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3996, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.z;
			//     retstr.z = v.w;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wzww(this Vector4 v)
		{
			// // Vector4 wzww(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3997, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3997, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.x = v.w;
			//     retstr.y = v.z;
			//     w = v.w;
			//     retstr.z = w;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wwxx(this Vector4 v)
		{
			// // Vector4 wwxx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   float x; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3998, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3998, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     x = v.x;
			//     retstr.z = v.x;
			//     retstr.w = x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wwxy(this Vector4 v)
		{
			// // Vector4 wwxy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(3999, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3999, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     retstr.z = v.x;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wwxz(this Vector4 v)
		{
			// // Vector4 wwxz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4000, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4000, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     retstr.z = v.x;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wwxw(this Vector4 v)
		{
			// // Vector4 wwxw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4001, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4001, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     retstr.z = v.x;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wwyx(this Vector4 v)
		{
			// // Vector4 wwyx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4002, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4002, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     retstr.z = v.y;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wwyy(this Vector4 v)
		{
			// // Vector4 wwyy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   float y; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4003, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4003, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     y = v.y;
			//     retstr.z = y;
			//     retstr.w = y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wwyz(this Vector4 v)
		{
			// // Vector4 wwyz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4004, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4004, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     retstr.z = v.y;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wwyw(this Vector4 v)
		{
			// // Vector4 wwyw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4005, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4005, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     retstr.z = v.y;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wwzx(this Vector4 v)
		{
			// // Vector4 wwzx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4006, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4006, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     retstr.z = v.z;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wwzy(this Vector4 v)
		{
			// // Vector4 wwzy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4007, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4007, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     retstr.z = v.z;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wwzz(this Vector4 v)
		{
			// // Vector4 wwzz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4008, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4008, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     z = v.z;
			//     retstr.z = z;
			//     retstr.w = z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wwzw(this Vector4 v)
		{
			// // Vector4 wwzw(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4009, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4009, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     retstr.z = v.z;
			//     retstr.w = v.w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wwwx(this Vector4 v)
		{
			// // Vector4 wwwx(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4010, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4010, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     retstr.z = w;
			//     retstr.w = v.x;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wwwy(this Vector4 v)
		{
			// // Vector4 wwwy(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4011, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4011, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     retstr.z = w;
			//     retstr.w = v.y;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wwwz(this Vector4 v)
		{
			// // Vector4 wwwz(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4012, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4012, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     retstr.z = w;
			//     retstr.w = v.z;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector4 wwww(this Vector4 v)
		{
			// // Vector4 wwww(Vector4)
			// Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
			// {
			//   float w; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4013, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4013, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *v;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1147(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     w = v.w;
			//     retstr.x = w;
			//     retstr.y = w;
			//     retstr.z = w;
			//     retstr.w = w;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector2 rr(this Color c)
		{
			// // Vector2 rr(Color)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::rr(Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Color v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4014, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c.r), (__m128)LODWORD(c.r)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4014, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *c;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 rg(this Color c)
		{
			// // Vector2 rg(Color)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::rg(Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Color v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4015, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c.r), (__m128)LODWORD(c.g)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4015, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *c;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 rb(this Color c)
		{
			// // Vector2 rb(Color)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::rb(Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Color v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4016, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c.r), (__m128)LODWORD(c.b)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4016, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *c;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 ra(this Color c)
		{
			// // Vector2 ra(Color)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::ra(Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Color v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4017, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c.r), (__m128)LODWORD(c.a)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4017, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *c;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 gr(this Color c)
		{
			// // Vector2 gr(Color)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::gr(Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Color v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4018, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c.g), (__m128)LODWORD(c.r)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4018, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *c;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 gg(this Color c)
		{
			// // Vector2 gg(Color)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::gg(Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Color v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4019, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c.g), (__m128)LODWORD(c.g)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4019, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *c;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 gb(this Color c)
		{
			// // Vector2 gb(Color)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::gb(Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Color v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4020, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c.g), (__m128)LODWORD(c.b)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4020, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *c;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 ga(this Color c)
		{
			// // Vector2 ga(Color)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::ga(Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Color v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4021, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c.g), (__m128)LODWORD(c.a)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4021, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *c;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 br(this Color c)
		{
			// // Vector2 br(Color)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::br(Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Color v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4022, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c.b), (__m128)LODWORD(c.r)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4022, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *c;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 bg(this Color c)
		{
			// // Vector2 bg(Color)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::bg(Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Color v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4023, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c.b), (__m128)LODWORD(c.g)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4023, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *c;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 bb(this Color c)
		{
			// // Vector2 bb(Color)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::bb(Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Color v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4024, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c.b), (__m128)LODWORD(c.b)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4024, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *c;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 ba(this Color c)
		{
			// // Vector2 ba(Color)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::ba(Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Color v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4025, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c.b), (__m128)LODWORD(c.a)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4025, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *c;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 ar(this Color c)
		{
			// // Vector2 ar(Color)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::ar(Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Color v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4026, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c.a), (__m128)LODWORD(c.r)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4026, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *c;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 ag(this Color c)
		{
			// // Vector2 ag(Color)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::ag(Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Color v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4027, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c.a), (__m128)LODWORD(c.g)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4027, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *c;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 ab(this Color c)
		{
			// // Vector2 ab(Color)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::ab(Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Color v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4028, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c.a), (__m128)LODWORD(c.b)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4028, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *c;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector2 aa(this Color c)
		{
			// // Vector2 aa(Color)
			// Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::aa(Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Color v7; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(4029, 0LL) )
			//     return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c.a), (__m128)LODWORD(c.a)).m128_u64[0];
			//   Patch = IFix::WrappersManagerImpl::GetPatch(4029, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v6, v5);
			//   v7 = *c;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1259(Patch, &v7, 0LL);
			// }
			// 
			return null;
		}

		public static Vector3 rrr(this Color c)
		{
			// // Vector3 rrr(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rrr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4030, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4030, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     z = c.r;
			//     retstr.x = c.r;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 rrg(this Color c)
		{
			// // Vector3 rrg(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rrg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Color v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4031, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4031, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *c;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.x = c.r;
			//     retstr.y = r;
			//     z = c.g;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 rrb(this Color c)
		{
			// // Vector3 rrb(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rrb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Color v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4032, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4032, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *c;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.x = c.r;
			//     retstr.y = r;
			//     z = c.b;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 rra(this Color c)
		{
			// // Vector3 rra(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rra(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Color v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4033, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4033, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *c;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.x = c.r;
			//     retstr.y = r;
			//     z = c.a;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 rgr(this Color c)
		{
			// // Vector3 rgr(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rgr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4034, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4034, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.r;
			//     retstr.y = c.g;
			//     z = c.r;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 rgg(this Color c)
		{
			// // Vector3 rgg(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rgg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4035, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4035, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.r;
			//     z = c.g;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 rgb(this Color c)
		{
			// // Vector3 rgb(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rgb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1206, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1206, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.r;
			//     retstr.y = c.g;
			//     z = c.b;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 rga(this Color c)
		{
			// // Vector3 rga(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rga(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4036, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4036, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.r;
			//     retstr.y = c.g;
			//     z = c.a;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 rbr(this Color c)
		{
			// // Vector3 rbr(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rbr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4037, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4037, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.r;
			//     retstr.y = c.b;
			//     z = c.r;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 rbg(this Color c)
		{
			// // Vector3 rbg(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rbg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4038, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4038, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.r;
			//     retstr.y = c.b;
			//     z = c.g;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 rbb(this Color c)
		{
			// // Vector3 rbb(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rbb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4039, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4039, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.r;
			//     z = c.b;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 rba(this Color c)
		{
			// // Vector3 rba(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rba(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4040, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4040, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.r;
			//     retstr.y = c.b;
			//     z = c.a;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 rar(this Color c)
		{
			// // Vector3 rar(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rar(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4041, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4041, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.r;
			//     retstr.y = c.a;
			//     z = c.r;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 rag(this Color c)
		{
			// // Vector3 rag(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rag(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4042, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4042, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.r;
			//     retstr.y = c.a;
			//     z = c.g;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 rab(this Color c)
		{
			// // Vector3 rab(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rab(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4043, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4043, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.r;
			//     retstr.y = c.a;
			//     z = c.b;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 raa(this Color c)
		{
			// // Vector3 raa(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::raa(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4044, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4044, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.r;
			//     z = c.a;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 grr(this Color c)
		{
			// // Vector3 grr(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::grr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4045, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4045, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.g;
			//     z = c.r;
			//     retstr.y = c.r;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 grg(this Color c)
		{
			// // Vector3 grg(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::grg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4046, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4046, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.g;
			//     retstr.y = c.r;
			//     z = c.g;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 grb(this Color c)
		{
			// // Vector3 grb(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::grb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4047, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4047, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.g;
			//     retstr.y = c.r;
			//     z = c.b;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 gra(this Color c)
		{
			// // Vector3 gra(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gra(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4048, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4048, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.g;
			//     retstr.y = c.r;
			//     z = c.a;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 ggr(this Color c)
		{
			// // Vector3 ggr(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::ggr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Color v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4049, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4049, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *c;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.x = g;
			//     retstr.y = g;
			//     z = c.r;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 ggg(this Color c)
		{
			// // Vector3 ggg(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::ggg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4050, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4050, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     z = c.g;
			//     retstr.x = z;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 ggb(this Color c)
		{
			// // Vector3 ggb(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::ggb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Color v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4051, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4051, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *c;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.x = g;
			//     retstr.y = g;
			//     z = c.b;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 gga(this Color c)
		{
			// // Vector3 gga(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gga(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Color v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4052, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4052, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *c;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.x = g;
			//     retstr.y = g;
			//     z = c.a;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 gbr(this Color c)
		{
			// // Vector3 gbr(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gbr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4053, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4053, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.g;
			//     retstr.y = c.b;
			//     z = c.r;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 gbg(this Color c)
		{
			// // Vector3 gbg(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gbg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4054, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4054, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.g;
			//     retstr.y = c.b;
			//     z = c.g;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 gbb(this Color c)
		{
			// // Vector3 gbb(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gbb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4055, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4055, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.g;
			//     z = c.b;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 gba(this Color c)
		{
			// // Vector3 gba(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gba(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4056, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4056, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.g;
			//     retstr.y = c.b;
			//     z = c.a;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 gar(this Color c)
		{
			// // Vector3 gar(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gar(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4057, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4057, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.g;
			//     retstr.y = c.a;
			//     z = c.r;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 gag(this Color c)
		{
			// // Vector3 gag(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gag(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4058, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4058, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.g;
			//     retstr.y = c.a;
			//     z = c.g;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 gab(this Color c)
		{
			// // Vector3 gab(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gab(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4059, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4059, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.g;
			//     retstr.y = c.a;
			//     z = c.b;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 gaa(this Color c)
		{
			// // Vector3 gaa(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gaa(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4060, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4060, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.g;
			//     z = c.a;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 brr(this Color c)
		{
			// // Vector3 brr(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::brr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4061, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4061, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.b;
			//     z = c.r;
			//     retstr.y = c.r;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 brg(this Color c)
		{
			// // Vector3 brg(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::brg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4062, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4062, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.b;
			//     retstr.y = c.r;
			//     z = c.g;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 brb(this Color c)
		{
			// // Vector3 brb(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::brb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4063, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4063, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.b;
			//     retstr.y = c.r;
			//     z = c.b;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 bra(this Color c)
		{
			// // Vector3 bra(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bra(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4064, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4064, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.b;
			//     retstr.y = c.r;
			//     z = c.a;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 bgr(this Color c)
		{
			// // Vector3 bgr(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bgr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4065, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4065, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.b;
			//     retstr.y = c.g;
			//     z = c.r;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 bgg(this Color c)
		{
			// // Vector3 bgg(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bgg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4066, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4066, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.b;
			//     z = c.g;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 bgb(this Color c)
		{
			// // Vector3 bgb(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bgb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4067, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4067, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.b;
			//     retstr.y = c.g;
			//     z = c.b;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 bga(this Color c)
		{
			// // Vector3 bga(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bga(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4068, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4068, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.b;
			//     retstr.y = c.g;
			//     z = c.a;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 bbr(this Color c)
		{
			// // Vector3 bbr(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bbr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Color v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4069, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4069, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *c;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.x = b;
			//     retstr.y = b;
			//     z = c.r;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 bbg(this Color c)
		{
			// // Vector3 bbg(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bbg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Color v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4070, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4070, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *c;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.x = b;
			//     retstr.y = b;
			//     z = c.g;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 bbb(this Color c)
		{
			// // Vector3 bbb(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bbb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4071, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4071, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     z = c.b;
			//     retstr.x = z;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 bba(this Color c)
		{
			// // Vector3 bba(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bba(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Color v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4072, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4072, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *c;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.x = b;
			//     retstr.y = b;
			//     z = c.a;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 bar(this Color c)
		{
			// // Vector3 bar(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bar(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4073, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4073, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.b;
			//     retstr.y = c.a;
			//     z = c.r;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 bag(this Color c)
		{
			// // Vector3 bag(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bag(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4074, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4074, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.b;
			//     retstr.y = c.a;
			//     z = c.g;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 bab(this Color c)
		{
			// // Vector3 bab(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bab(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4075, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4075, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.b;
			//     retstr.y = c.a;
			//     z = c.b;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 baa(this Color c)
		{
			// // Vector3 baa(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::baa(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4076, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4076, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.b;
			//     z = c.a;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 arr(this Color c)
		{
			// // Vector3 arr(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::arr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4077, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4077, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.a;
			//     z = c.r;
			//     retstr.y = c.r;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 arg(this Color c)
		{
			// // Vector3 arg(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::arg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4078, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4078, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.a;
			//     retstr.y = c.r;
			//     z = c.g;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 arb(this Color c)
		{
			// // Vector3 arb(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::arb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4079, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4079, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.a;
			//     retstr.y = c.r;
			//     z = c.b;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 ara(this Color c)
		{
			// // Vector3 ara(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::ara(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4080, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4080, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.a;
			//     retstr.y = c.r;
			//     z = c.a;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 agr(this Color c)
		{
			// // Vector3 agr(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::agr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4081, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4081, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.a;
			//     retstr.y = c.g;
			//     z = c.r;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 agg(this Color c)
		{
			// // Vector3 agg(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::agg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4082, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4082, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.a;
			//     z = c.g;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 agb(this Color c)
		{
			// // Vector3 agb(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::agb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4083, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4083, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.a;
			//     retstr.y = c.g;
			//     z = c.b;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 aga(this Color c)
		{
			// // Vector3 aga(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::aga(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4084, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4084, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.a;
			//     retstr.y = c.g;
			//     z = c.a;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 abr(this Color c)
		{
			// // Vector3 abr(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::abr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4085, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4085, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.a;
			//     retstr.y = c.b;
			//     z = c.r;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 abg(this Color c)
		{
			// // Vector3 abg(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::abg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4086, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4086, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.a;
			//     retstr.y = c.b;
			//     z = c.g;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 abb(this Color c)
		{
			// // Vector3 abb(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::abb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4087, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4087, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.a;
			//     z = c.b;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 aba(this Color c)
		{
			// // Vector3 aba(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::aba(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4088, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4088, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     retstr.x = c.a;
			//     retstr.y = c.b;
			//     z = c.a;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 aar(this Color c)
		{
			// // Vector3 aar(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::aar(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Color v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4089, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4089, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *c;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.x = a;
			//     retstr.y = a;
			//     z = c.r;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 aag(this Color c)
		{
			// // Vector3 aag(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::aag(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Color v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4090, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4090, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *c;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.x = a;
			//     retstr.y = a;
			//     z = c.g;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 aab(this Color c)
		{
			// // Vector3 aab(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::aab(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Vector3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
			//   Color v14; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4091, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4091, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v14 = *c;
			//     v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v13, Patch, &v14, 0LL);
			//     v11 = *(_QWORD *)&v10.x;
			//     z = v10.z;
			//     *(_QWORD *)&retstr.x = v11;
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.x = a;
			//     retstr.y = a;
			//     z = c.b;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Vector3 aaa(this Color c)
		{
			// // Vector3 aaa(Color)
			// Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::aaa(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Vector3 *v9; // rax
			//   __int64 v10; // xmm0_8
			//   Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
			//   Color v13; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4092, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4092, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v13 = *c;
			//     v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_454(&v12, Patch, &v13, 0LL);
			//     v10 = *(_QWORD *)&v9.x;
			//     z = v9.z;
			//     *(_QWORD *)&retstr.x = v10;
			//   }
			//   else
			//   {
			//     z = c.a;
			//     retstr.x = z;
			//     retstr.y = z;
			//   }
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rrrr(this Color c)
		{
			// // Color rrrr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4093, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4093, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     *(__m128 *)retstr = _mm_shuffle_ps((__m128)LODWORD(c.r), (__m128)LODWORD(c.r), 0);
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rrrg(this Color c)
		{
			// // Color rrrg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4094, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4094, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.r = c.r;
			//     retstr.g = r;
			//     retstr.b = r;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rrrb(this Color c)
		{
			// // Color rrrb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4095, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4095, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.r = c.r;
			//     retstr.g = r;
			//     retstr.b = r;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rrra(this Color c)
		{
			// // Color rrra(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4096, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4096, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.r = c.r;
			//     retstr.g = r;
			//     retstr.b = r;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rrgr(this Color c)
		{
			// // Color rrgr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrgr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4097, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4097, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.r = c.r;
			//     retstr.g = r;
			//     retstr.b = c.g;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rrgg(this Color c)
		{
			// // Color rrgg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrgg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Color v11; // [rsp+20h] [rbp-28h] BYREF
			//   Color v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4098, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4098, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.r = c.r;
			//     retstr.g = r;
			//     g = c.g;
			//     retstr.b = g;
			//     retstr.a = g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rrgb(this Color c)
		{
			// // Color rrgb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrgb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4099, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4099, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.r = c.r;
			//     retstr.g = r;
			//     retstr.b = c.g;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rrga(this Color c)
		{
			// // Color rrga(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4100, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4100, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.r = c.r;
			//     retstr.g = r;
			//     retstr.b = c.g;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rrbr(this Color c)
		{
			// // Color rrbr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4101, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4101, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.r = c.r;
			//     retstr.g = r;
			//     retstr.b = c.b;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rrbg(this Color c)
		{
			// // Color rrbg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4102, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4102, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.r = c.r;
			//     retstr.g = r;
			//     retstr.b = c.b;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rrbb(this Color c)
		{
			// // Color rrbb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Color v11; // [rsp+20h] [rbp-28h] BYREF
			//   Color v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4103, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4103, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.r = c.r;
			//     retstr.g = r;
			//     b = c.b;
			//     retstr.b = b;
			//     retstr.a = b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rrba(this Color c)
		{
			// // Color rrba(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4104, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4104, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.r = c.r;
			//     retstr.g = r;
			//     retstr.b = c.b;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rrar(this Color c)
		{
			// // Color rrar(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4105, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4105, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.r = c.r;
			//     retstr.g = r;
			//     retstr.b = c.a;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rrag(this Color c)
		{
			// // Color rrag(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4106, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4106, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.r = c.r;
			//     retstr.g = r;
			//     retstr.b = c.a;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rrab(this Color c)
		{
			// // Color rrab(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4107, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4107, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.r = c.r;
			//     retstr.g = r;
			//     retstr.b = c.a;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rraa(this Color c)
		{
			// // Color rraa(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rraa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Color v11; // [rsp+20h] [rbp-28h] BYREF
			//   Color v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4108, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4108, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     r = c.r;
			//     retstr.r = c.r;
			//     retstr.g = r;
			//     a = c.a;
			//     retstr.b = a;
			//     retstr.a = a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rgrr(this Color c)
		{
			// // Color rgrr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4109, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4109, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.g;
			//     r = c.r;
			//     retstr.b = c.r;
			//     retstr.a = r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rgrg(this Color c)
		{
			// // Color rgrg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4110, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4110, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.g;
			//     retstr.b = c.r;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rgrb(this Color c)
		{
			// // Color rgrb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4111, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4111, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.g;
			//     retstr.b = c.r;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rgra(this Color c)
		{
			// // Color rgra(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4112, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4112, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.g;
			//     retstr.b = c.r;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rggr(this Color c)
		{
			// // Color rggr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rggr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4113, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4113, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     g = c.g;
			//     retstr.g = g;
			//     retstr.b = g;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rggg(this Color c)
		{
			// // Color rggg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rggg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4114, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4114, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     g = c.g;
			//     retstr.g = g;
			//     retstr.b = g;
			//     retstr.a = g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rggb(this Color c)
		{
			// // Color rggb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rggb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4115, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4115, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     g = c.g;
			//     retstr.g = g;
			//     retstr.b = g;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rgga(this Color c)
		{
			// // Color rgga(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4116, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4116, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     g = c.g;
			//     retstr.g = g;
			//     retstr.b = g;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rgbr(this Color c)
		{
			// // Color rgbr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4117, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4117, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.g;
			//     retstr.b = c.b;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rgbg(this Color c)
		{
			// // Color rgbg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4118, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4118, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.g;
			//     retstr.b = c.b;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rgbb(this Color c)
		{
			// // Color rgbb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4119, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4119, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.g;
			//     b = c.b;
			//     retstr.b = b;
			//     retstr.a = b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rgba(this Color c)
		{
			// // Color rgba(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4120, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4120, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.g;
			//     retstr.b = c.b;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rgar(this Color c)
		{
			// // Color rgar(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4121, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4121, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.g;
			//     retstr.b = c.a;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rgag(this Color c)
		{
			// // Color rgag(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4122, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4122, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.g;
			//     retstr.b = c.a;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rgab(this Color c)
		{
			// // Color rgab(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4123, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4123, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.g;
			//     retstr.b = c.a;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rgaa(this Color c)
		{
			// // Color rgaa(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4124, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4124, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.g;
			//     a = c.a;
			//     retstr.b = a;
			//     retstr.a = a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rbrr(this Color c)
		{
			// // Color rbrr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4125, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4125, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.b;
			//     r = c.r;
			//     retstr.b = c.r;
			//     retstr.a = r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rbrg(this Color c)
		{
			// // Color rbrg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4126, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4126, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.b;
			//     retstr.b = c.r;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rbrb(this Color c)
		{
			// // Color rbrb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4127, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4127, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.b;
			//     retstr.b = c.r;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rbra(this Color c)
		{
			// // Color rbra(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4128, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4128, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.b;
			//     retstr.b = c.r;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rbgr(this Color c)
		{
			// // Color rbgr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbgr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4129, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4129, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.b;
			//     retstr.b = c.g;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rbgg(this Color c)
		{
			// // Color rbgg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbgg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4130, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4130, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.b;
			//     g = c.g;
			//     retstr.b = g;
			//     retstr.a = g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rbgb(this Color c)
		{
			// // Color rbgb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbgb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4131, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4131, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.b;
			//     retstr.b = c.g;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rbga(this Color c)
		{
			// // Color rbga(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4132, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4132, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.b;
			//     retstr.b = c.g;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rbbr(this Color c)
		{
			// // Color rbbr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4133, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4133, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     b = c.b;
			//     retstr.g = b;
			//     retstr.b = b;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rbbg(this Color c)
		{
			// // Color rbbg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4134, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4134, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     b = c.b;
			//     retstr.g = b;
			//     retstr.b = b;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rbbb(this Color c)
		{
			// // Color rbbb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4135, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4135, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     b = c.b;
			//     retstr.g = b;
			//     retstr.b = b;
			//     retstr.a = b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rbba(this Color c)
		{
			// // Color rbba(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4136, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4136, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     b = c.b;
			//     retstr.g = b;
			//     retstr.b = b;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rbar(this Color c)
		{
			// // Color rbar(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4137, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4137, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.b;
			//     retstr.b = c.a;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rbag(this Color c)
		{
			// // Color rbag(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4138, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4138, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.b;
			//     retstr.b = c.a;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rbab(this Color c)
		{
			// // Color rbab(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4139, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4139, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.b;
			//     retstr.b = c.a;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rbaa(this Color c)
		{
			// // Color rbaa(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4140, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4140, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.b;
			//     a = c.a;
			//     retstr.b = a;
			//     retstr.a = a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rarr(this Color c)
		{
			// // Color rarr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rarr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4141, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4141, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.a;
			//     r = c.r;
			//     retstr.b = c.r;
			//     retstr.a = r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rarg(this Color c)
		{
			// // Color rarg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rarg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4142, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4142, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.a;
			//     retstr.b = c.r;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rarb(this Color c)
		{
			// // Color rarb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rarb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4143, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4143, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.a;
			//     retstr.b = c.r;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rara(this Color c)
		{
			// // Color rara(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rara(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4144, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4144, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.a;
			//     retstr.b = c.r;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color ragr(this Color c)
		{
			// // Color ragr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::ragr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4145, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4145, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.a;
			//     retstr.b = c.g;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color ragg(this Color c)
		{
			// // Color ragg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::ragg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4146, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4146, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.a;
			//     g = c.g;
			//     retstr.b = g;
			//     retstr.a = g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color ragb(this Color c)
		{
			// // Color ragb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::ragb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4147, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4147, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.a;
			//     retstr.b = c.g;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color raga(this Color c)
		{
			// // Color raga(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::raga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4148, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4148, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.a;
			//     retstr.b = c.g;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rabr(this Color c)
		{
			// // Color rabr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rabr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4149, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4149, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.a;
			//     retstr.b = c.b;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rabg(this Color c)
		{
			// // Color rabg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rabg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4150, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4150, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.a;
			//     retstr.b = c.b;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color rabb(this Color c)
		{
			// // Color rabb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::rabb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4151, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4151, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.a;
			//     b = c.b;
			//     retstr.b = b;
			//     retstr.a = b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color raba(this Color c)
		{
			// // Color raba(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::raba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4152, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4152, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     retstr.g = c.a;
			//     retstr.b = c.b;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color raar(this Color c)
		{
			// // Color raar(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::raar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4153, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4153, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     a = c.a;
			//     retstr.g = a;
			//     retstr.b = a;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color raag(this Color c)
		{
			// // Color raag(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::raag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4154, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4154, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     a = c.a;
			//     retstr.g = a;
			//     retstr.b = a;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color raab(this Color c)
		{
			// // Color raab(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::raab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4155, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4155, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     a = c.a;
			//     retstr.g = a;
			//     retstr.b = a;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color raaa(this Color c)
		{
			// // Color raaa(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::raaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4156, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4156, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.r;
			//     a = c.a;
			//     retstr.g = a;
			//     retstr.b = a;
			//     retstr.a = a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color grrr(this Color c)
		{
			// // Color grrr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::grrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4157, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4157, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     r = c.r;
			//     retstr.g = c.r;
			//     retstr.b = r;
			//     retstr.a = r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color grrg(this Color c)
		{
			// // Color grrg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::grrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4158, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4158, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     r = c.r;
			//     retstr.g = c.r;
			//     retstr.b = r;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color grrb(this Color c)
		{
			// // Color grrb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::grrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4159, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4159, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     r = c.r;
			//     retstr.g = c.r;
			//     retstr.b = r;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color grra(this Color c)
		{
			// // Color grra(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::grra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4160, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4160, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     r = c.r;
			//     retstr.g = c.r;
			//     retstr.b = r;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color grgr(this Color c)
		{
			// // Color grgr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::grgr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4161, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4161, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.r;
			//     retstr.b = c.g;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color grgg(this Color c)
		{
			// // Color grgg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::grgg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4162, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4162, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.r;
			//     g = c.g;
			//     retstr.b = g;
			//     retstr.a = g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color grgb(this Color c)
		{
			// // Color grgb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::grgb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4163, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4163, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.r;
			//     retstr.b = c.g;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color grga(this Color c)
		{
			// // Color grga(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::grga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4164, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4164, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.r;
			//     retstr.b = c.g;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color grbr(this Color c)
		{
			// // Color grbr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::grbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4165, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4165, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.r;
			//     retstr.b = c.b;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color grbg(this Color c)
		{
			// // Color grbg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::grbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4166, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4166, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.r;
			//     retstr.b = c.b;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color grbb(this Color c)
		{
			// // Color grbb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::grbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4167, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4167, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.r;
			//     b = c.b;
			//     retstr.b = b;
			//     retstr.a = b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color grba(this Color c)
		{
			// // Color grba(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::grba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4168, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4168, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.r;
			//     retstr.b = c.b;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color grar(this Color c)
		{
			// // Color grar(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::grar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4169, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4169, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.r;
			//     retstr.b = c.a;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color grag(this Color c)
		{
			// // Color grag(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::grag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4170, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4170, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.r;
			//     retstr.b = c.a;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color grab(this Color c)
		{
			// // Color grab(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::grab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4171, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4171, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.r;
			//     retstr.b = c.a;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color graa(this Color c)
		{
			// // Color graa(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::graa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4172, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4172, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.r;
			//     a = c.a;
			//     retstr.b = a;
			//     retstr.a = a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color ggrr(this Color c)
		{
			// // Color ggrr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Color v11; // [rsp+20h] [rbp-28h] BYREF
			//   Color v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4173, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4173, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.r = g;
			//     retstr.g = g;
			//     r = c.r;
			//     retstr.b = c.r;
			//     retstr.a = r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color ggrg(this Color c)
		{
			// // Color ggrg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4174, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4174, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.r = g;
			//     retstr.g = g;
			//     retstr.b = c.r;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color ggrb(this Color c)
		{
			// // Color ggrb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4175, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4175, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.r = g;
			//     retstr.g = g;
			//     retstr.b = c.r;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color ggra(this Color c)
		{
			// // Color ggra(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4176, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4176, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.r = g;
			//     retstr.g = g;
			//     retstr.b = c.r;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gggr(this Color c)
		{
			// // Color gggr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gggr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4177, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4177, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.r = g;
			//     retstr.g = g;
			//     retstr.b = g;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gggg(this Color c)
		{
			// // Color gggg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gggg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4178, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4178, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.r = g;
			//     retstr.g = g;
			//     retstr.b = g;
			//     retstr.a = g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gggb(this Color c)
		{
			// // Color gggb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gggb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4179, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4179, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.r = g;
			//     retstr.g = g;
			//     retstr.b = g;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color ggga(this Color c)
		{
			// // Color ggga(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4180, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4180, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.r = g;
			//     retstr.g = g;
			//     retstr.b = g;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color ggbr(this Color c)
		{
			// // Color ggbr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4181, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4181, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.r = g;
			//     retstr.g = g;
			//     retstr.b = c.b;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color ggbg(this Color c)
		{
			// // Color ggbg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4182, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4182, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.r = g;
			//     retstr.g = g;
			//     retstr.b = c.b;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color ggbb(this Color c)
		{
			// // Color ggbb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Color v11; // [rsp+20h] [rbp-28h] BYREF
			//   Color v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4183, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4183, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.r = g;
			//     retstr.g = g;
			//     b = c.b;
			//     retstr.b = b;
			//     retstr.a = b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color ggba(this Color c)
		{
			// // Color ggba(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4184, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4184, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.r = g;
			//     retstr.g = g;
			//     retstr.b = c.b;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color ggar(this Color c)
		{
			// // Color ggar(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4185, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4185, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.r = g;
			//     retstr.g = g;
			//     retstr.b = c.a;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color ggag(this Color c)
		{
			// // Color ggag(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4186, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4186, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.r = g;
			//     retstr.g = g;
			//     retstr.b = c.a;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color ggab(this Color c)
		{
			// // Color ggab(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4187, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4187, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.r = g;
			//     retstr.g = g;
			//     retstr.b = c.a;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color ggaa(this Color c)
		{
			// // Color ggaa(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Color v11; // [rsp+20h] [rbp-28h] BYREF
			//   Color v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4188, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4188, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     g = c.g;
			//     retstr.r = g;
			//     retstr.g = g;
			//     a = c.a;
			//     retstr.b = a;
			//     retstr.a = a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gbrr(this Color c)
		{
			// // Color gbrr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4189, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4189, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.b;
			//     r = c.r;
			//     retstr.b = c.r;
			//     retstr.a = r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gbrg(this Color c)
		{
			// // Color gbrg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4190, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4190, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.b;
			//     retstr.b = c.r;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gbrb(this Color c)
		{
			// // Color gbrb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4191, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4191, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.b;
			//     retstr.b = c.r;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gbra(this Color c)
		{
			// // Color gbra(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4192, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4192, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.b;
			//     retstr.b = c.r;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gbgr(this Color c)
		{
			// // Color gbgr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbgr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4193, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4193, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.b;
			//     retstr.b = c.g;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gbgg(this Color c)
		{
			// // Color gbgg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbgg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4194, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4194, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.b;
			//     g = c.g;
			//     retstr.b = g;
			//     retstr.a = g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gbgb(this Color c)
		{
			// // Color gbgb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbgb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4195, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4195, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.b;
			//     retstr.b = c.g;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gbga(this Color c)
		{
			// // Color gbga(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4196, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4196, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.b;
			//     retstr.b = c.g;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gbbr(this Color c)
		{
			// // Color gbbr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4197, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4197, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     b = c.b;
			//     retstr.g = b;
			//     retstr.b = b;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gbbg(this Color c)
		{
			// // Color gbbg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4198, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4198, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     b = c.b;
			//     retstr.g = b;
			//     retstr.b = b;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gbbb(this Color c)
		{
			// // Color gbbb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4199, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4199, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     b = c.b;
			//     retstr.g = b;
			//     retstr.b = b;
			//     retstr.a = b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gbba(this Color c)
		{
			// // Color gbba(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4200, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4200, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     b = c.b;
			//     retstr.g = b;
			//     retstr.b = b;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gbar(this Color c)
		{
			// // Color gbar(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4201, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4201, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.b;
			//     retstr.b = c.a;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gbag(this Color c)
		{
			// // Color gbag(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4202, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4202, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.b;
			//     retstr.b = c.a;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gbab(this Color c)
		{
			// // Color gbab(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4203, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4203, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.b;
			//     retstr.b = c.a;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gbaa(this Color c)
		{
			// // Color gbaa(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4204, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4204, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.b;
			//     a = c.a;
			//     retstr.b = a;
			//     retstr.a = a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color garr(this Color c)
		{
			// // Color garr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::garr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4205, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4205, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.a;
			//     r = c.r;
			//     retstr.b = c.r;
			//     retstr.a = r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color garg(this Color c)
		{
			// // Color garg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::garg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4206, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4206, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.a;
			//     retstr.b = c.r;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color garb(this Color c)
		{
			// // Color garb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::garb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4207, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4207, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.a;
			//     retstr.b = c.r;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gara(this Color c)
		{
			// // Color gara(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gara(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4208, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4208, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.a;
			//     retstr.b = c.r;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gagr(this Color c)
		{
			// // Color gagr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gagr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4209, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4209, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.a;
			//     retstr.b = c.g;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gagg(this Color c)
		{
			// // Color gagg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gagg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4210, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4210, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.a;
			//     g = c.g;
			//     retstr.b = g;
			//     retstr.a = g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gagb(this Color c)
		{
			// // Color gagb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gagb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4211, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4211, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.a;
			//     retstr.b = c.g;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gaga(this Color c)
		{
			// // Color gaga(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gaga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4212, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4212, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.a;
			//     retstr.b = c.g;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gabr(this Color c)
		{
			// // Color gabr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gabr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4213, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4213, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.a;
			//     retstr.b = c.b;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gabg(this Color c)
		{
			// // Color gabg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gabg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4214, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4214, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.a;
			//     retstr.b = c.b;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gabb(this Color c)
		{
			// // Color gabb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gabb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4215, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4215, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.a;
			//     b = c.b;
			//     retstr.b = b;
			//     retstr.a = b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gaba(this Color c)
		{
			// // Color gaba(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gaba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4216, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4216, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     retstr.g = c.a;
			//     retstr.b = c.b;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gaar(this Color c)
		{
			// // Color gaar(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gaar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4217, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4217, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     a = c.a;
			//     retstr.g = a;
			//     retstr.b = a;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gaag(this Color c)
		{
			// // Color gaag(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gaag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4218, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4218, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     a = c.a;
			//     retstr.g = a;
			//     retstr.b = a;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gaab(this Color c)
		{
			// // Color gaab(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gaab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4219, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4219, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     a = c.a;
			//     retstr.g = a;
			//     retstr.b = a;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color gaaa(this Color c)
		{
			// // Color gaaa(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::gaaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4220, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4220, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.g;
			//     a = c.a;
			//     retstr.g = a;
			//     retstr.b = a;
			//     retstr.a = a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color brrr(this Color c)
		{
			// // Color brrr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::brrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4221, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4221, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     r = c.r;
			//     retstr.g = c.r;
			//     retstr.b = r;
			//     retstr.a = r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color brrg(this Color c)
		{
			// // Color brrg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::brrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4222, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4222, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     r = c.r;
			//     retstr.g = c.r;
			//     retstr.b = r;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color brrb(this Color c)
		{
			// // Color brrb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::brrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4223, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4223, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     r = c.r;
			//     retstr.g = c.r;
			//     retstr.b = r;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color brra(this Color c)
		{
			// // Color brra(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::brra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4224, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4224, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     r = c.r;
			//     retstr.g = c.r;
			//     retstr.b = r;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color brgr(this Color c)
		{
			// // Color brgr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::brgr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4225, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4225, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.r;
			//     retstr.b = c.g;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color brgg(this Color c)
		{
			// // Color brgg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::brgg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4226, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4226, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.r;
			//     g = c.g;
			//     retstr.b = g;
			//     retstr.a = g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color brgb(this Color c)
		{
			// // Color brgb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::brgb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4227, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4227, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.r;
			//     retstr.b = c.g;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color brga(this Color c)
		{
			// // Color brga(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::brga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4228, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4228, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.r;
			//     retstr.b = c.g;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color brbr(this Color c)
		{
			// // Color brbr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::brbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4229, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4229, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.r;
			//     retstr.b = c.b;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color brbg(this Color c)
		{
			// // Color brbg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::brbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4230, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4230, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.r;
			//     retstr.b = c.b;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color brbb(this Color c)
		{
			// // Color brbb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::brbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4231, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4231, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.r;
			//     b = c.b;
			//     retstr.b = b;
			//     retstr.a = b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color brba(this Color c)
		{
			// // Color brba(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::brba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4232, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4232, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.r;
			//     retstr.b = c.b;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color brar(this Color c)
		{
			// // Color brar(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::brar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4233, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4233, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.r;
			//     retstr.b = c.a;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color brag(this Color c)
		{
			// // Color brag(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::brag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4234, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4234, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.r;
			//     retstr.b = c.a;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color brab(this Color c)
		{
			// // Color brab(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::brab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4235, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4235, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.r;
			//     retstr.b = c.a;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color braa(this Color c)
		{
			// // Color braa(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::braa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4236, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4236, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.r;
			//     a = c.a;
			//     retstr.b = a;
			//     retstr.a = a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bgrr(this Color c)
		{
			// // Color bgrr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4237, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4237, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.g;
			//     r = c.r;
			//     retstr.b = c.r;
			//     retstr.a = r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bgrg(this Color c)
		{
			// // Color bgrg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4238, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4238, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.g;
			//     retstr.b = c.r;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bgrb(this Color c)
		{
			// // Color bgrb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4239, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4239, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.g;
			//     retstr.b = c.r;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bgra(this Color c)
		{
			// // Color bgra(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4240, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4240, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.g;
			//     retstr.b = c.r;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bggr(this Color c)
		{
			// // Color bggr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bggr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4241, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4241, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     g = c.g;
			//     retstr.g = g;
			//     retstr.b = g;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bggg(this Color c)
		{
			// // Color bggg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bggg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4242, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4242, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     g = c.g;
			//     retstr.g = g;
			//     retstr.b = g;
			//     retstr.a = g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bggb(this Color c)
		{
			// // Color bggb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bggb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4243, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4243, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     g = c.g;
			//     retstr.g = g;
			//     retstr.b = g;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bgga(this Color c)
		{
			// // Color bgga(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4244, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4244, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     g = c.g;
			//     retstr.g = g;
			//     retstr.b = g;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bgbr(this Color c)
		{
			// // Color bgbr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4245, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4245, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.g;
			//     retstr.b = c.b;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bgbg(this Color c)
		{
			// // Color bgbg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4246, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4246, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.g;
			//     retstr.b = c.b;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bgbb(this Color c)
		{
			// // Color bgbb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4247, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4247, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.g;
			//     b = c.b;
			//     retstr.b = b;
			//     retstr.a = b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bgba(this Color c)
		{
			// // Color bgba(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4248, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4248, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.g;
			//     retstr.b = c.b;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bgar(this Color c)
		{
			// // Color bgar(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4249, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4249, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.g;
			//     retstr.b = c.a;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bgag(this Color c)
		{
			// // Color bgag(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4250, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4250, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.g;
			//     retstr.b = c.a;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bgab(this Color c)
		{
			// // Color bgab(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4251, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4251, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.g;
			//     retstr.b = c.a;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bgaa(this Color c)
		{
			// // Color bgaa(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4252, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4252, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.g;
			//     a = c.a;
			//     retstr.b = a;
			//     retstr.a = a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bbrr(this Color c)
		{
			// // Color bbrr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Color v11; // [rsp+20h] [rbp-28h] BYREF
			//   Color v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4253, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4253, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.r = b;
			//     retstr.g = b;
			//     r = c.r;
			//     retstr.b = c.r;
			//     retstr.a = r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bbrg(this Color c)
		{
			// // Color bbrg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4254, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4254, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.r = b;
			//     retstr.g = b;
			//     retstr.b = c.r;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bbrb(this Color c)
		{
			// // Color bbrb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4255, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4255, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.r = b;
			//     retstr.g = b;
			//     retstr.b = c.r;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bbra(this Color c)
		{
			// // Color bbra(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4256, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4256, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.r = b;
			//     retstr.g = b;
			//     retstr.b = c.r;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bbgr(this Color c)
		{
			// // Color bbgr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbgr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4257, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4257, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.r = b;
			//     retstr.g = b;
			//     retstr.b = c.g;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bbgg(this Color c)
		{
			// // Color bbgg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbgg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Color v11; // [rsp+20h] [rbp-28h] BYREF
			//   Color v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4258, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4258, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.r = b;
			//     retstr.g = b;
			//     g = c.g;
			//     retstr.b = g;
			//     retstr.a = g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bbgb(this Color c)
		{
			// // Color bbgb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbgb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4259, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4259, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.r = b;
			//     retstr.g = b;
			//     retstr.b = c.g;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bbga(this Color c)
		{
			// // Color bbga(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4260, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4260, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.r = b;
			//     retstr.g = b;
			//     retstr.b = c.g;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bbbr(this Color c)
		{
			// // Color bbbr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4261, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4261, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.r = b;
			//     retstr.g = b;
			//     retstr.b = b;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bbbg(this Color c)
		{
			// // Color bbbg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4262, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4262, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.r = b;
			//     retstr.g = b;
			//     retstr.b = b;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bbbb(this Color c)
		{
			// // Color bbbb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4263, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4263, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.r = b;
			//     retstr.g = b;
			//     retstr.b = b;
			//     retstr.a = b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bbba(this Color c)
		{
			// // Color bbba(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4264, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4264, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.r = b;
			//     retstr.g = b;
			//     retstr.b = b;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bbar(this Color c)
		{
			// // Color bbar(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4265, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4265, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.r = b;
			//     retstr.g = b;
			//     retstr.b = c.a;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bbag(this Color c)
		{
			// // Color bbag(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4266, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4266, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.r = b;
			//     retstr.g = b;
			//     retstr.b = c.a;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bbab(this Color c)
		{
			// // Color bbab(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4267, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4267, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.r = b;
			//     retstr.g = b;
			//     retstr.b = c.a;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bbaa(this Color c)
		{
			// // Color bbaa(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Color v11; // [rsp+20h] [rbp-28h] BYREF
			//   Color v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4268, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4268, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     b = c.b;
			//     retstr.r = b;
			//     retstr.g = b;
			//     a = c.a;
			//     retstr.b = a;
			//     retstr.a = a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color barr(this Color c)
		{
			// // Color barr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::barr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4269, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4269, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.a;
			//     r = c.r;
			//     retstr.b = c.r;
			//     retstr.a = r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color barg(this Color c)
		{
			// // Color barg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::barg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4270, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4270, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.a;
			//     retstr.b = c.r;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color barb(this Color c)
		{
			// // Color barb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::barb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4271, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4271, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.a;
			//     retstr.b = c.r;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bara(this Color c)
		{
			// // Color bara(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bara(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4272, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4272, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.a;
			//     retstr.b = c.r;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bagr(this Color c)
		{
			// // Color bagr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bagr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4273, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4273, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.a;
			//     retstr.b = c.g;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bagg(this Color c)
		{
			// // Color bagg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bagg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4274, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4274, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.a;
			//     g = c.g;
			//     retstr.b = g;
			//     retstr.a = g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color bagb(this Color c)
		{
			// // Color bagb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::bagb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4275, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4275, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.a;
			//     retstr.b = c.g;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color baga(this Color c)
		{
			// // Color baga(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::baga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4276, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4276, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.a;
			//     retstr.b = c.g;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color babr(this Color c)
		{
			// // Color babr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::babr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4277, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4277, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.a;
			//     retstr.b = c.b;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color babg(this Color c)
		{
			// // Color babg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::babg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4278, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4278, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.a;
			//     retstr.b = c.b;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color babb(this Color c)
		{
			// // Color babb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::babb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4279, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4279, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.a;
			//     b = c.b;
			//     retstr.b = b;
			//     retstr.a = b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color baba(this Color c)
		{
			// // Color baba(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::baba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4280, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4280, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     retstr.g = c.a;
			//     retstr.b = c.b;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color baar(this Color c)
		{
			// // Color baar(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::baar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4281, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4281, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     a = c.a;
			//     retstr.g = a;
			//     retstr.b = a;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color baag(this Color c)
		{
			// // Color baag(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::baag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4282, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4282, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     a = c.a;
			//     retstr.g = a;
			//     retstr.b = a;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color baab(this Color c)
		{
			// // Color baab(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::baab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4283, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4283, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     a = c.a;
			//     retstr.g = a;
			//     retstr.b = a;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color baaa(this Color c)
		{
			// // Color baaa(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::baaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4284, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4284, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.b;
			//     a = c.a;
			//     retstr.g = a;
			//     retstr.b = a;
			//     retstr.a = a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color arrr(this Color c)
		{
			// // Color arrr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::arrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4285, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4285, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     r = c.r;
			//     retstr.g = c.r;
			//     retstr.b = r;
			//     retstr.a = r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color arrg(this Color c)
		{
			// // Color arrg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::arrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4286, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4286, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     r = c.r;
			//     retstr.g = c.r;
			//     retstr.b = r;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color arrb(this Color c)
		{
			// // Color arrb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::arrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4287, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4287, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     r = c.r;
			//     retstr.g = c.r;
			//     retstr.b = r;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color arra(this Color c)
		{
			// // Color arra(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::arra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4288, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4288, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     r = c.r;
			//     retstr.g = c.r;
			//     retstr.b = r;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color argr(this Color c)
		{
			// // Color argr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::argr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4289, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4289, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.r;
			//     retstr.b = c.g;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color argg(this Color c)
		{
			// // Color argg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::argg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4290, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4290, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.r;
			//     g = c.g;
			//     retstr.b = g;
			//     retstr.a = g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color argb(this Color c)
		{
			// // Color argb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::argb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4291, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4291, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.r;
			//     retstr.b = c.g;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color arga(this Color c)
		{
			// // Color arga(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::arga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4292, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4292, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.r;
			//     retstr.b = c.g;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color arbr(this Color c)
		{
			// // Color arbr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::arbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4293, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4293, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.r;
			//     retstr.b = c.b;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color arbg(this Color c)
		{
			// // Color arbg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::arbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4294, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4294, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.r;
			//     retstr.b = c.b;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color arbb(this Color c)
		{
			// // Color arbb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::arbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4295, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4295, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.r;
			//     b = c.b;
			//     retstr.b = b;
			//     retstr.a = b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color arba(this Color c)
		{
			// // Color arba(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::arba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4296, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4296, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.r;
			//     retstr.b = c.b;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color arar(this Color c)
		{
			// // Color arar(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::arar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4297, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4297, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.r;
			//     retstr.b = c.a;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color arag(this Color c)
		{
			// // Color arag(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::arag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4298, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4298, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.r;
			//     retstr.b = c.a;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color arab(this Color c)
		{
			// // Color arab(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::arab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4299, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4299, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.r;
			//     retstr.b = c.a;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color araa(this Color c)
		{
			// // Color araa(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::araa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4300, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4300, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.r;
			//     a = c.a;
			//     retstr.b = a;
			//     retstr.a = a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color agrr(this Color c)
		{
			// // Color agrr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::agrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4301, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4301, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.g;
			//     r = c.r;
			//     retstr.b = c.r;
			//     retstr.a = r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color agrg(this Color c)
		{
			// // Color agrg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::agrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4302, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4302, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.g;
			//     retstr.b = c.r;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color agrb(this Color c)
		{
			// // Color agrb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::agrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4303, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4303, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.g;
			//     retstr.b = c.r;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color agra(this Color c)
		{
			// // Color agra(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::agra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4304, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4304, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.g;
			//     retstr.b = c.r;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aggr(this Color c)
		{
			// // Color aggr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aggr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4305, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4305, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     g = c.g;
			//     retstr.g = g;
			//     retstr.b = g;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aggg(this Color c)
		{
			// // Color aggg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aggg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4306, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4306, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     g = c.g;
			//     retstr.g = g;
			//     retstr.b = g;
			//     retstr.a = g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aggb(this Color c)
		{
			// // Color aggb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aggb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4307, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4307, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     g = c.g;
			//     retstr.g = g;
			//     retstr.b = g;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color agga(this Color c)
		{
			// // Color agga(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::agga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4308, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4308, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     g = c.g;
			//     retstr.g = g;
			//     retstr.b = g;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color agbr(this Color c)
		{
			// // Color agbr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::agbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4309, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4309, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.g;
			//     retstr.b = c.b;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color agbg(this Color c)
		{
			// // Color agbg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::agbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4310, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4310, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.g;
			//     retstr.b = c.b;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color agbb(this Color c)
		{
			// // Color agbb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::agbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4311, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4311, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.g;
			//     b = c.b;
			//     retstr.b = b;
			//     retstr.a = b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color agba(this Color c)
		{
			// // Color agba(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::agba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4312, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4312, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.g;
			//     retstr.b = c.b;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color agar(this Color c)
		{
			// // Color agar(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::agar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4313, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4313, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.g;
			//     retstr.b = c.a;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color agag(this Color c)
		{
			// // Color agag(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::agag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4314, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4314, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.g;
			//     retstr.b = c.a;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color agab(this Color c)
		{
			// // Color agab(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::agab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4315, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4315, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.g;
			//     retstr.b = c.a;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color agaa(this Color c)
		{
			// // Color agaa(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::agaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4316, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4316, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.g;
			//     a = c.a;
			//     retstr.b = a;
			//     retstr.a = a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color abrr(this Color c)
		{
			// // Color abrr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::abrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4317, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4317, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.b;
			//     r = c.r;
			//     retstr.b = c.r;
			//     retstr.a = r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color abrg(this Color c)
		{
			// // Color abrg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::abrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4318, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4318, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.b;
			//     retstr.b = c.r;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color abrb(this Color c)
		{
			// // Color abrb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::abrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4319, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4319, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.b;
			//     retstr.b = c.r;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color abra(this Color c)
		{
			// // Color abra(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::abra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4320, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4320, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.b;
			//     retstr.b = c.r;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color abgr(this Color c)
		{
			// // Color abgr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::abgr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4321, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4321, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.b;
			//     retstr.b = c.g;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color abgg(this Color c)
		{
			// // Color abgg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::abgg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4322, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4322, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.b;
			//     g = c.g;
			//     retstr.b = g;
			//     retstr.a = g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color abgb(this Color c)
		{
			// // Color abgb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::abgb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4323, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4323, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.b;
			//     retstr.b = c.g;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color abga(this Color c)
		{
			// // Color abga(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::abga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4324, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4324, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.b;
			//     retstr.b = c.g;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color abbr(this Color c)
		{
			// // Color abbr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::abbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4325, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4325, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     b = c.b;
			//     retstr.g = b;
			//     retstr.b = b;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color abbg(this Color c)
		{
			// // Color abbg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::abbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4326, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4326, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     b = c.b;
			//     retstr.g = b;
			//     retstr.b = b;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color abbb(this Color c)
		{
			// // Color abbb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::abbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4327, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4327, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     b = c.b;
			//     retstr.g = b;
			//     retstr.b = b;
			//     retstr.a = b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color abba(this Color c)
		{
			// // Color abba(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::abba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4328, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4328, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     b = c.b;
			//     retstr.g = b;
			//     retstr.b = b;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color abar(this Color c)
		{
			// // Color abar(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::abar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4329, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4329, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.b;
			//     retstr.b = c.a;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color abag(this Color c)
		{
			// // Color abag(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::abag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4330, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4330, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.b;
			//     retstr.b = c.a;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color abab(this Color c)
		{
			// // Color abab(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::abab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v6; // rdx
			//   __int64 v7; // rcx
			//   Color v9; // [rsp+20h] [rbp-28h] BYREF
			//   Color v10; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4331, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4331, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v7, v6);
			//     v9 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v10, Patch, &v9, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.b;
			//     retstr.b = c.a;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color abaa(this Color c)
		{
			// // Color abaa(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::abaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4332, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4332, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     retstr.r = c.a;
			//     retstr.g = c.b;
			//     a = c.a;
			//     retstr.b = a;
			//     retstr.a = a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aarr(this Color c)
		{
			// // Color aarr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aarr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   float r; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Color v11; // [rsp+20h] [rbp-28h] BYREF
			//   Color v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4333, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4333, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.r = a;
			//     retstr.g = a;
			//     r = c.r;
			//     retstr.b = c.r;
			//     retstr.a = r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aarg(this Color c)
		{
			// // Color aarg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aarg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4334, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4334, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.r = a;
			//     retstr.g = a;
			//     retstr.b = c.r;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aarb(this Color c)
		{
			// // Color aarb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aarb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4335, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4335, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.r = a;
			//     retstr.g = a;
			//     retstr.b = c.r;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aara(this Color c)
		{
			// // Color aara(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aara(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4336, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4336, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.r = a;
			//     retstr.g = a;
			//     retstr.b = c.r;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aagr(this Color c)
		{
			// // Color aagr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aagr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4337, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4337, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.r = a;
			//     retstr.g = a;
			//     retstr.b = c.g;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aagg(this Color c)
		{
			// // Color aagg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aagg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   float g; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Color v11; // [rsp+20h] [rbp-28h] BYREF
			//   Color v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4338, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4338, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.r = a;
			//     retstr.g = a;
			//     g = c.g;
			//     retstr.b = g;
			//     retstr.a = g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aagb(this Color c)
		{
			// // Color aagb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aagb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4339, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4339, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.r = a;
			//     retstr.g = a;
			//     retstr.b = c.g;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aaga(this Color c)
		{
			// // Color aaga(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aaga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4340, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4340, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.r = a;
			//     retstr.g = a;
			//     retstr.b = c.g;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aabr(this Color c)
		{
			// // Color aabr(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aabr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4341, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4341, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.r = a;
			//     retstr.g = a;
			//     retstr.b = c.b;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aabg(this Color c)
		{
			// // Color aabg(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aabg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4342, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4342, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.r = a;
			//     retstr.g = a;
			//     retstr.b = c.b;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aabb(this Color c)
		{
			// // Color aabb(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aabb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   float b; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v8; // rdx
			//   __int64 v9; // rcx
			//   Color v11; // [rsp+20h] [rbp-28h] BYREF
			//   Color v12; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4343, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4343, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v9, v8);
			//     v11 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v12, Patch, &v11, 0LL);
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.r = a;
			//     retstr.g = a;
			//     b = c.b;
			//     retstr.b = b;
			//     retstr.a = b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aaba(this Color c)
		{
			// // Color aaba(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aaba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4344, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4344, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.r = a;
			//     retstr.g = a;
			//     retstr.b = c.b;
			//     retstr.a = c.a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aaar(this Color c)
		{
			// // Color aaar(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aaar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4345, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4345, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.r = a;
			//     retstr.g = a;
			//     retstr.b = a;
			//     retstr.a = c.r;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aaag(this Color c)
		{
			// // Color aaag(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aaag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4346, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4346, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.r = a;
			//     retstr.g = a;
			//     retstr.b = a;
			//     retstr.a = c.g;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aaab(this Color c)
		{
			// // Color aaab(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aaab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4347, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4347, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.r = a;
			//     retstr.g = a;
			//     retstr.b = a;
			//     retstr.a = c.b;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Color aaaa(this Color c)
		{
			// // Color aaaa(Color)
			// Color *HG::Rendering::Runtime::VectorSwizzleUtils::aaaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
			// {
			//   float a; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   Color v10; // [rsp+20h] [rbp-28h] BYREF
			//   Color v11; // [rsp+30h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(4348, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(4348, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v10 = *c;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1140(&v11, Patch, &v10, 0LL);
			//   }
			//   else
			//   {
			//     a = c.a;
			//     retstr.r = a;
			//     retstr.g = a;
			//     retstr.b = a;
			//     retstr.a = a;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}
	}
}
