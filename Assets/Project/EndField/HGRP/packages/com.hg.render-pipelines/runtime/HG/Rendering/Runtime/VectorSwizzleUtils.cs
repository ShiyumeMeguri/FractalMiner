using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class VectorSwizzleUtils // TypeDefIndex: 38707
	{
		// Extension methods
		[IDTag(0)]
		public static Vector2 xx(this float f) => default; // 0x0000000189C38394-0x0000000189C383F4
		// Vector2 xx(Single)
		// local variable allocation has failed, the output may be wrong!
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xx(float f, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4191, 0LL) )
		    return (Vector2)_mm_unpacklo_ps(*(__m128 *)&f, *(__m128 *)&f).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4191, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v5, v4);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1469(Patch, f, 0LL);
		}
		
		[IDTag(0)]
		public static Vector3 xxx(this float f) => default; // 0x0000000189C38670-0x0000000189C386E8
		// Vector3 xxx(Single)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxx(Vector3 *__return_ptr retstr, float f, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector3 *v7; // rax
		  __int64 v8; // xmm0_8
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1713, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1713, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_684(&v10, Patch, f, 0LL);
		    v8 = *(_QWORD *)&v7->x;
		    *(float *)&v7 = v7->z;
		    *(_QWORD *)&retstr->x = v8;
		    LODWORD(retstr->z) = (_DWORD)v7;
		  }
		  else
		  {
		    retstr->x = f;
		    retstr->y = f;
		    retstr->z = f;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xxxx(this float f) => default; // 0x0000000189C38A60-0x0000000189C38ACC
		// Vector4 xxxx(Single)
		// local variable allocation has failed, the output may be wrong!
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxx(Vector4 *__return_ptr retstr, float f, MethodInfo *method)
		{
		  Vector4 v4; // xmm6
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		
		  v4 = (Vector4)_mm_shuffle_ps(*(__m128 *)&f, *(__m128 *)&f, 0);
		  if ( IFix::WrappersManagerImpl::IsPatched(4192, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4192, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1212(&v9, Patch, v4.x, 0LL);
		  }
		  else
		  {
		    *retstr = v4;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector2 xx(this Vector2 v) => default; // 0x0000000189C38324-0x0000000189C38394
		// Vector2 xx(Vector2)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xx(Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  float x; // [rsp+20h] [rbp-28h]
		
		  x = v.x;
		  if ( !IFix::WrappersManagerImpl::IsPatched(4193, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(x), (__m128)LODWORD(x)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4193, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1351(Patch, v, 0LL);
		}
		
		[IDTag(2)]
		public static Vector2 xy(this Vector2 v) => default; // 0x0000000189C39830-0x0000000189C398A4
		// Vector2 xy(Vector2)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xy(Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4194, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.x), (__m128)LODWORD(v.y)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4194, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1351(Patch, v, 0LL);
		}
		
		[IDTag(0)]
		public static Vector2 yx(this Vector2 v) => default; // 0x0000000189C3C80C-0x0000000189C3C880
		// Vector2 yx(Vector2)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yx(Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4195, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v.y), (__m128)LODWORD(v.x)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4195, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1351(Patch, v, 0LL);
		}
		
		[IDTag(0)]
		public static Vector2 yy(this Vector2 v) => default; // 0x0000000189C3DCC8-0x0000000189C3DD38
		// Vector2 yy(Vector2)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yy(Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  float y; // [rsp+24h] [rbp-24h]
		
		  y = v.y;
		  if ( !IFix::WrappersManagerImpl::IsPatched(4196, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(y), (__m128)LODWORD(y)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4196, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1351(Patch, v, 0LL);
		}
		
		[IDTag(1)]
		public static Vector3 xxx(this Vector2 v) => default; // 0x0000000189C387E8-0x0000000189C38870
		// Vector3 xxx(Vector2)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxx(Vector3 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector3 *v8; // rax
		  __int64 v9; // xmm0_8
		  float x; // [rsp+20h] [rbp-38h]
		  Vector3 v12[2]; // [rsp+28h] [rbp-30h] BYREF
		
		  x = v.x;
		  if ( IFix::WrappersManagerImpl::IsPatched(4197, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4197, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1470(v12, Patch, v, 0LL);
		    v9 = *(_QWORD *)&v8->x;
		    *(float *)&v8 = v8->z;
		    *(_QWORD *)&retstr->x = v9;
		    LODWORD(retstr->z) = (_DWORD)v8;
		  }
		  else
		  {
		    retstr->x = x;
		    retstr->y = x;
		    retstr->z = x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 xxy(this Vector2 v) => default; // 0x0000000189C38E60-0x0000000189C38EF0
		// Vector3 xxy(Vector2)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxy(Vector3 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector3 *v8; // rax
		  __int64 v9; // xmm0_8
		  Vector3 v12[2]; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4198, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4198, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1470(v12, Patch, v, 0LL);
		    v9 = *(_QWORD *)&v8->x;
		    *(float *)&v8 = v8->z;
		    *(_QWORD *)&retstr->x = v9;
		    LODWORD(retstr->z) = (_DWORD)v8;
		  }
		  else
		  {
		    retstr->x = v.x;
		    *(Vector2 *)&retstr->y = v;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 xyx(this Vector2 v) => default; // 0x0000000189C39D08-0x0000000189C39D98
		// Vector3 xyx(Vector2)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyx(Vector3 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector3 *v8; // rax
		  __int64 v9; // xmm0_8
		  Vector3 v12[2]; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4199, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4199, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1470(v12, Patch, v, 0LL);
		    v9 = *(_QWORD *)&v8->x;
		    *(float *)&v8 = v8->z;
		    *(_QWORD *)&retstr->x = v9;
		    LODWORD(retstr->z) = (_DWORD)v8;
		  }
		  else
		  {
		    *(Vector2 *)&retstr->x = v;
		    retstr->z = v.x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 xyy(this Vector2 v) => default; // 0x0000000189C3A25C-0x0000000189C3A2EC
		// Vector3 xyy(Vector2)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyy(Vector3 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector3 *v8; // rax
		  __int64 v9; // xmm0_8
		  Vector3 v12[2]; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4200, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4200, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1470(v12, Patch, v, 0LL);
		    v9 = *(_QWORD *)&v8->x;
		    *(float *)&v8 = v8->z;
		    *(_QWORD *)&retstr->x = v9;
		    LODWORD(retstr->z) = (_DWORD)v8;
		  }
		  else
		  {
		    *(Vector2 *)&retstr->x = v;
		    retstr->z = v.y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 yxx(this Vector2 v) => default; // 0x0000000189C3CB0C-0x0000000189C3CB9C
		// Vector3 yxx(Vector2)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxx(Vector3 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector3 *v8; // rax
		  __int64 v9; // xmm0_8
		  Vector3 v12[2]; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4201, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4201, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1470(v12, Patch, v, 0LL);
		    v9 = *(_QWORD *)&v8->x;
		    *(float *)&v8 = v8->z;
		    *(_QWORD *)&retstr->x = v9;
		    LODWORD(retstr->z) = (_DWORD)v8;
		  }
		  else
		  {
		    retstr->x = v.y;
		    retstr->y = v.x;
		    retstr->z = v.x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 yxy(this Vector2 v) => default; // 0x0000000189C3D254-0x0000000189C3D2E4
		// Vector3 yxy(Vector2)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxy(Vector3 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector3 *v8; // rax
		  __int64 v9; // xmm0_8
		  Vector3 v12[2]; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4202, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4202, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1470(v12, Patch, v, 0LL);
		    v9 = *(_QWORD *)&v8->x;
		    *(float *)&v8 = v8->z;
		    *(_QWORD *)&retstr->x = v9;
		    LODWORD(retstr->z) = (_DWORD)v8;
		  }
		  else
		  {
		    retstr->x = v.y;
		    *(Vector2 *)&retstr->y = v;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 yyx(this Vector2 v) => default; // 0x0000000189C3E09C-0x0000000189C3E12C
		// Vector3 yyx(Vector2)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyx(Vector3 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector3 *v8; // rax
		  __int64 v9; // xmm0_8
		  Vector3 v12[2]; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4203, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4203, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1470(v12, Patch, v, 0LL);
		    v9 = *(_QWORD *)&v8->x;
		    *(float *)&v8 = v8->z;
		    *(_QWORD *)&retstr->x = v9;
		    LODWORD(retstr->z) = (_DWORD)v8;
		  }
		  else
		  {
		    retstr->x = v.y;
		    retstr->y = v.y;
		    retstr->z = v.x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 yyy(this Vector2 v) => default; // 0x0000000189C3E75C-0x0000000189C3E7E4
		// Vector3 yyy(Vector2)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyy(Vector3 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector3 *v8; // rax
		  __int64 v9; // xmm0_8
		  float y; // [rsp+24h] [rbp-34h]
		  Vector3 v12[2]; // [rsp+28h] [rbp-30h] BYREF
		
		  y = v.y;
		  if ( IFix::WrappersManagerImpl::IsPatched(4204, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4204, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1470(v12, Patch, v, 0LL);
		    v9 = *(_QWORD *)&v8->x;
		    *(float *)&v8 = v8->z;
		    *(_QWORD *)&retstr->x = v9;
		    LODWORD(retstr->z) = (_DWORD)v8;
		  }
		  else
		  {
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xxxx(this Vector2 v) => default; // 0x0000000189C389E4-0x0000000189C38A60
		// Vector4 xxxx(Vector2)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxx(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  float x; // [rsp+20h] [rbp-38h]
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  x = v.x;
		  if ( IFix::WrappersManagerImpl::IsPatched(4205, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4205, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v, 0LL);
		  }
		  else
		  {
		    *(__m128 *)retstr = _mm_shuffle_ps((__m128)LODWORD(x), (__m128)LODWORD(x), 0);
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xxxy(this Vector2 v) => default; // 0x0000000189C38BCC-0x0000000189C38C58
		// Vector4 xxxy(Vector2)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxy(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4206, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4206, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v, 0LL);
		  }
		  else
		  {
		    retstr->x = v.x;
		    retstr->y = v.x;
		    *(Vector2 *)&retstr->z = v;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xxyx(this Vector2 v) => default; // 0x0000000189C38FF8-0x0000000189C39084
		// Vector4 xxyx(Vector2)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyx(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4207, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4207, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v, 0LL);
		  }
		  else
		  {
		    retstr->x = v.x;
		    *(Vector2 *)&retstr->y = v;
		    retstr->w = v.x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xxyy(this Vector2 v) => default; // 0x0000000189C39104-0x0000000189C39190
		// Vector4 xxyy(Vector2)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyy(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4208, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4208, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v, 0LL);
		  }
		  else
		  {
		    retstr->x = v.x;
		    *(Vector2 *)&retstr->y = v;
		    retstr->w = v.y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xyxx(this Vector2 v) => default; // 0x0000000189C39F24-0x0000000189C39FB0
		// Vector4 xyxx(Vector2)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxx(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4209, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4209, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v, 0LL);
		  }
		  else
		  {
		    *(Vector2 *)&retstr->x = v;
		    retstr->z = v.x;
		    retstr->w = v.x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xyxy(this Vector2 v) => default; // 0x0000000189C3A03C-0x0000000189C3A0C8
		// Vector4 xyxy(Vector2)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxy(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4210, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4210, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v, 0LL);
		  }
		  else
		  {
		    *(Vector2 *)&retstr->x = v;
		    *(Vector2 *)&retstr->z = v;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xyyx(this Vector2 v) => default; // 0x0000000189C3A474-0x0000000189C3A500
		// Vector4 xyyx(Vector2)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyx(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4211, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4211, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v, 0LL);
		  }
		  else
		  {
		    *(Vector2 *)&retstr->x = v;
		    retstr->z = v.y;
		    retstr->w = v.x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xyyy(this Vector2 v) => default; // 0x0000000189C3A68C-0x0000000189C3A718
		// Vector4 xyyy(Vector2)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyy(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4212, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4212, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v, 0LL);
		  }
		  else
		  {
		    *(Vector2 *)&retstr->x = v;
		    retstr->z = v.y;
		    retstr->w = v.y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yxxx(this Vector2 v) => default; // 0x0000000189C3CE24-0x0000000189C3CEB0
		// Vector4 yxxx(Vector2)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxx(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4213, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4213, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v, 0LL);
		  }
		  else
		  {
		    retstr->x = v.y;
		    retstr->y = v.x;
		    retstr->z = v.x;
		    retstr->w = v.x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yxxy(this Vector2 v) => default; // 0x0000000189C3CF38-0x0000000189C3CFC4
		// Vector4 yxxy(Vector2)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxy(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4214, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4214, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v, 0LL);
		  }
		  else
		  {
		    retstr->x = v.y;
		    retstr->y = v.x;
		    *(Vector2 *)&retstr->z = v;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yxyx(this Vector2 v) => default; // 0x0000000189C3D368-0x0000000189C3D3F4
		// Vector4 yxyx(Vector2)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyx(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4215, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4215, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v, 0LL);
		  }
		  else
		  {
		    retstr->x = v.y;
		    *(Vector2 *)&retstr->y = v;
		    retstr->w = v.x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yxyy(this Vector2 v) => default; // 0x0000000189C3D504-0x0000000189C3D590
		// Vector4 yxyy(Vector2)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyy(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4216, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4216, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v, 0LL);
		  }
		  else
		  {
		    retstr->x = v.y;
		    *(Vector2 *)&retstr->y = v;
		    retstr->w = v.y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yyxx(this Vector2 v) => default; // 0x0000000189C3E2B0-0x0000000189C3E33C
		// Vector4 yyxx(Vector2)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxx(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4217, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4217, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v, 0LL);
		  }
		  else
		  {
		    retstr->x = v.y;
		    retstr->y = v.y;
		    retstr->z = v.x;
		    retstr->w = v.x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yyxy(this Vector2 v) => default; // 0x0000000189C3E4C8-0x0000000189C3E554
		// Vector4 yyxy(Vector2)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxy(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4218, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4218, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v, 0LL);
		  }
		  else
		  {
		    retstr->x = v.y;
		    retstr->y = v.y;
		    *(Vector2 *)&retstr->z = v;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yyyx(this Vector2 v) => default; // 0x0000000189C3E864-0x0000000189C3E8F0
		// Vector4 yyyx(Vector2)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyx(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4219, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4219, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v, 0LL);
		  }
		  else
		  {
		    retstr->x = v.y;
		    retstr->y = v.y;
		    retstr->z = v.y;
		    retstr->w = v.x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yyyy(this Vector2 v) => default; // 0x0000000189C3EA6C-0x0000000189C3EAE8
		// Vector4 yyyy(Vector2)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyy(Vector4 *__return_ptr retstr, Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  float y; // [rsp+24h] [rbp-34h]
		  Vector4 v10; // [rsp+28h] [rbp-30h] BYREF
		
		  y = v.y;
		  if ( IFix::WrappersManagerImpl::IsPatched(4220, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4220, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1323(&v10, Patch, v, 0LL);
		  }
		  else
		  {
		    *(__m128 *)retstr = _mm_shuffle_ps((__m128)LODWORD(y), (__m128)LODWORD(y), 0);
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector2 xx(this Vector3 v) => default; // 0x0000000189C382BC-0x0000000189C38324
		// Vector2 xx(Vector3)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xx(Vector3 *v, MethodInfo *method)
		{
		  __int64 v4; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4221, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->x), (__m128)LODWORD(v->x)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4221, 0LL);
		  if ( !Patch )
		    sub_1800D8260(0LL, v4);
		  z = v->z;
		  *(_QWORD *)&v7.x = *(_QWORD *)&v->x;
		  v7.z = z;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_253(Patch, &v7, 0LL);
		}
		
		[IDTag(1)]
		public static Vector2 xy(this Vector3 v) => default; // 0x0000000189C39908-0x0000000189C39974
		// Vector2 xy(Vector3)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xy(Vector3 *v, MethodInfo *method)
		{
		  __int64 v4; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1645, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->x), (__m128)LODWORD(v->y)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(1645, 0LL);
		  if ( !Patch )
		    sub_1800D8260(0LL, v4);
		  z = v->z;
		  *(_QWORD *)&v7.x = *(_QWORD *)&v->x;
		  v7.z = z;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_253(Patch, &v7, 0LL);
		}
		
		[IDTag(0)]
		public static Vector2 xz(this Vector3 v) => default; // 0x00000001832DF740-0x00000001832DF7A0
		// Vector2 xz(Vector3)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xz(Vector3 *v, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // xmm0_8
		  Vector3 v8; // [rsp+20h] [rbp-18h] BYREF
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 630 )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->x), (__m128)LODWORD(v->z)).m128_u64[0];
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x276 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[13].static_fields )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->x), (__m128)LODWORD(v->z)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(630, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, wrapperArray);
		  v7 = *(_QWORD *)&v->x;
		  v8.z = v->z;
		  *(_QWORD *)&v8.x = v7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_253(Patch, &v8, 0LL);
		}
		
		[IDTag(1)]
		public static Vector2 yx(this Vector3 v) => default; // 0x0000000189C3C7A0-0x0000000189C3C80C
		// Vector2 yx(Vector3)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yx(Vector3 *v, MethodInfo *method)
		{
		  __int64 v4; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4222, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->y), (__m128)LODWORD(v->x)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4222, 0LL);
		  if ( !Patch )
		    sub_1800D8260(0LL, v4);
		  z = v->z;
		  *(_QWORD *)&v7.x = *(_QWORD *)&v->x;
		  v7.z = z;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_253(Patch, &v7, 0LL);
		}
		
		[IDTag(1)]
		public static Vector2 yy(this Vector3 v) => default; // 0x0000000189C3DC5C-0x0000000189C3DCC8
		// Vector2 yy(Vector3)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yy(Vector3 *v, MethodInfo *method)
		{
		  __int64 v4; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4223, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->y), (__m128)LODWORD(v->y)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4223, 0LL);
		  if ( !Patch )
		    sub_1800D8260(0LL, v4);
		  z = v->z;
		  *(_QWORD *)&v7.x = *(_QWORD *)&v->x;
		  v7.z = z;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_253(Patch, &v7, 0LL);
		}
		
		[IDTag(0)]
		public static Vector2 yz(this Vector3 v) => default; // 0x0000000189C3F114-0x0000000189C3F180
		// Vector2 yz(Vector3)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yz(Vector3 *v, MethodInfo *method)
		{
		  __int64 v4; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4224, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->y), (__m128)LODWORD(v->z)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4224, 0LL);
		  if ( !Patch )
		    sub_1800D8260(0LL, v4);
		  z = v->z;
		  *(_QWORD *)&v7.x = *(_QWORD *)&v->x;
		  v7.z = z;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_253(Patch, &v7, 0LL);
		}
		
		[IDTag(0)]
		public static Vector2 zx(this Vector3 v) => default; // 0x0000000189C40D78-0x0000000189C40DE4
		// Vector2 zx(Vector3)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::zx(Vector3 *v, MethodInfo *method)
		{
		  __int64 v4; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4225, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->z), (__m128)LODWORD(v->x)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4225, 0LL);
		  if ( !Patch )
		    sub_1800D8260(0LL, v4);
		  z = v->z;
		  *(_QWORD *)&v7.x = *(_QWORD *)&v->x;
		  v7.z = z;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_253(Patch, &v7, 0LL);
		}
		
		[IDTag(0)]
		public static Vector2 zy(this Vector3 v) => default; // 0x0000000189C41ED4-0x0000000189C41F40
		// Vector2 zy(Vector3)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::zy(Vector3 *v, MethodInfo *method)
		{
		  __int64 v4; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1644, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->z), (__m128)LODWORD(v->y)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(1644, 0LL);
		  if ( !Patch )
		    sub_1800D8260(0LL, v4);
		  z = v->z;
		  *(_QWORD *)&v7.x = *(_QWORD *)&v->x;
		  v7.z = z;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_253(Patch, &v7, 0LL);
		}
		
		[IDTag(0)]
		public static Vector2 zz(this Vector3 v) => default; // 0x0000000189C43044-0x0000000189C430B0
		// Vector2 zz(Vector3)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::zz(Vector3 *v, MethodInfo *method)
		{
		  __int64 v4; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4226, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->z), (__m128)LODWORD(v->z)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4226, 0LL);
		  if ( !Patch )
		    sub_1800D8260(0LL, v4);
		  z = v->z;
		  *(_QWORD *)&v7.x = *(_QWORD *)&v->x;
		  v7.z = z;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_253(Patch, &v7, 0LL);
		}
		
		[IDTag(2)]
		public static Vector3 xxx(this Vector3 v) => default; // 0x0000000189C386E8-0x0000000189C3876C
		// Vector3 xxx(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4227, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4227, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    x = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		  }
		  retstr->z = x;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 xxy(this Vector3 v) => default; // 0x0000000189C38DD8-0x0000000189C38E60
		// Vector3 xxy(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v8; // rcx
		  float z; // eax
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v14[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4228, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4228, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, 0LL);
		    z = v->z;
		    *(_QWORD *)&v13.x = *(_QWORD *)&v->x;
		    v13.z = z;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v14, Patch, &v13, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    y = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    y = v->y;
		  }
		  retstr->z = y;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 xxz(this Vector3 v) => default; // 0x0000000189C39418-0x0000000189C394A0
		// Vector3 xxz(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  float v6; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v8; // rcx
		  float z; // eax
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v14[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4229, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4229, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, 0LL);
		    z = v->z;
		    *(_QWORD *)&v13.x = *(_QWORD *)&v->x;
		    v13.z = z;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v14, Patch, &v13, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    v6 = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    v6 = v->z;
		  }
		  retstr->z = v6;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 xyx(this Vector3 v) => default; // 0x0000000189C39C00-0x0000000189C39C88
		// Vector3 xyx(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4230, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4230, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    x = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    x = v->x;
		  }
		  retstr->z = x;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 xyy(this Vector3 v) => default; // 0x0000000189C3A2EC-0x0000000189C3A374
		// Vector3 xyy(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4231, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4231, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    y = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->x;
		    y = v->y;
		    retstr->y = y;
		  }
		  retstr->z = y;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 xyz(this Vector3 v) => default; // 0x00000001834409C0-0x0000000183440A30
		// Vector3 xyz(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // xmm0_8
		  Vector3 *v11; // rax
		  __int64 v12; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v14[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 925 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x39D )
		        sub_1800D2AB0(v5, wrapperArray);
		      if ( !*(_QWORD *)&v5[19]._1.field_count )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(925, 0LL);
		      if ( Patch )
		      {
		        v10 = *(_QWORD *)&v->x;
		        v13.z = v->z;
		        *(_QWORD *)&v13.x = v10;
		        v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v14, Patch, &v13, 0LL);
		        v12 = *(_QWORD *)&v11->x;
		        z = v11->z;
		        *(_QWORD *)&retstr->x = v12;
		        goto LABEL_6;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v5, wrapperArray);
		  }
		LABEL_5:
		  retstr->x = v->x;
		  retstr->y = v->y;
		  z = v->z;
		LABEL_6:
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 xzx(this Vector3 v) => default; // 0x0000000189C3AF2C-0x0000000189C3AFB4
		// Vector3 xzx(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xzx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4232, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4232, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    x = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    x = v->x;
		  }
		  retstr->z = x;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 xzy(this Vector3 v) => default; // 0x0000000189C3B360-0x0000000189C3B3E8
		// Vector3 xzy(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xzy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4233, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4233, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    y = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    y = v->y;
		  }
		  retstr->z = y;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 xzz(this Vector3 v) => default; // 0x0000000189C3B814-0x0000000189C3B89C
		// Vector3 xzz(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xzz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4234, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4234, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    v5 = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->x;
		    v5 = v->z;
		    retstr->y = v5;
		  }
		  retstr->z = v5;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 yxx(this Vector3 v) => default; // 0x0000000189C3CB9C-0x0000000189C3CC24
		// Vector3 yxx(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4235, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4235, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    x = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    x = v->x;
		    retstr->y = v->x;
		  }
		  retstr->z = x;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 yxy(this Vector3 v) => default; // 0x0000000189C3D14C-0x0000000189C3D1D4
		// Vector3 yxy(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4236, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4236, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    y = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    y = v->y;
		  }
		  retstr->z = y;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 yxz(this Vector3 v) => default; // 0x0000000189C3D828-0x0000000189C3D8B0
		// Vector3 yxz(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4237, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4237, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    v5 = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    v5 = v->z;
		  }
		  retstr->z = v5;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 yyx(this Vector3 v) => default; // 0x0000000189C3E12C-0x0000000189C3E1B4
		// Vector3 yyx(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v8; // rcx
		  float z; // eax
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v14[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4238, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4238, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, 0LL);
		    z = v->z;
		    *(_QWORD *)&v13.x = *(_QWORD *)&v->x;
		    v13.z = z;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v14, Patch, &v13, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    x = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    x = v->x;
		  }
		  retstr->z = x;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 yyy(this Vector3 v) => default; // 0x0000000189C3E6D8-0x0000000189C3E75C
		// Vector3 yyy(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4239, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4239, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    y = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		  }
		  retstr->z = y;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 yyz(this Vector3 v) => default; // 0x0000000189C3EC74-0x0000000189C3ECFC
		// Vector3 yyz(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  float v6; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v8; // rcx
		  float z; // eax
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v14[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4240, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4240, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, 0LL);
		    z = v->z;
		    *(_QWORD *)&v13.x = *(_QWORD *)&v->x;
		    v13.z = z;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v14, Patch, &v13, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    v6 = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    v6 = v->z;
		  }
		  retstr->z = v6;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 yzx(this Vector3 v) => default; // 0x0000000189C3F474-0x0000000189C3F4FC
		// Vector3 yzx(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yzx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4241, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4241, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    x = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    x = v->x;
		  }
		  retstr->z = x;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 yzy(this Vector3 v) => default; // 0x0000000189C3F928-0x0000000189C3F9B4
		// Vector3 yzy(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yzy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4242, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4242, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    y = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    y = v->y;
		  }
		  retstr->z = y;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 yzz(this Vector3 v) => default; // 0x0000000189C3FDE4-0x0000000189C3FE6C
		// Vector3 yzz(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yzz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4243, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4243, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    v5 = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    v5 = v->z;
		    retstr->y = v5;
		  }
		  retstr->z = v5;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 zxx(this Vector3 v) => default; // 0x0000000189C410F0-0x0000000189C41178
		// Vector3 zxx(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zxx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4244, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4244, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    x = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    x = v->x;
		    retstr->y = v->x;
		  }
		  retstr->z = x;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 zxy(this Vector3 v) => default; // 0x0000000189C41508-0x0000000189C41590
		// Vector3 zxy(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zxy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4245, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4245, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    y = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    y = v->y;
		  }
		  retstr->z = y;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 zxz(this Vector3 v) => default; // 0x0000000189C41A3C-0x0000000189C41AC4
		// Vector3 zxz(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zxz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4246, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4246, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    v5 = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    v5 = v->z;
		  }
		  retstr->z = v5;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 zyx(this Vector3 v) => default; // 0x0000000189C421D0-0x0000000189C42258
		// Vector3 zyx(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zyx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4247, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4247, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    x = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    x = v->x;
		  }
		  retstr->z = x;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 zyy(this Vector3 v) => default; // 0x0000000189C42704-0x0000000189C4278C
		// Vector3 zyy(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zyy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4248, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4248, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    y = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    y = v->y;
		    retstr->y = y;
		  }
		  retstr->z = y;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 zyz(this Vector3 v) => default; // 0x0000000189C42BA8-0x0000000189C42C34
		// Vector3 zyz(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zyz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4249, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4249, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    v5 = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    v5 = v->z;
		  }
		  retstr->z = v5;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 zzx(this Vector3 v) => default; // 0x0000000189C433B0-0x0000000189C43438
		// Vector3 zzx(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zzx(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v8; // rcx
		  float z; // eax
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v14[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4250, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4250, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, 0LL);
		    z = v->z;
		    *(_QWORD *)&v13.x = *(_QWORD *)&v->x;
		    v13.z = z;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v14, Patch, &v13, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    x = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    v5 = v->z;
		    retstr->x = v5;
		    retstr->y = v5;
		    x = v->x;
		  }
		  retstr->z = x;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 zzy(this Vector3 v) => default; // 0x0000000189C43848-0x0000000189C438D0
		// Vector3 zzy(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zzy(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v8; // rcx
		  float z; // eax
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v14[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4251, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4251, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, 0LL);
		    z = v->z;
		    *(_QWORD *)&v13.x = *(_QWORD *)&v->x;
		    v13.z = z;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v14, Patch, &v13, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    y = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    v5 = v->z;
		    retstr->x = v5;
		    retstr->y = v5;
		    y = v->y;
		  }
		  retstr->z = y;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector3 zzz(this Vector3 v) => default; // 0x0000000189C43C68-0x0000000189C43CEC
		// Vector3 zzz(Vector3)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zzz(Vector3 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector3 v13[2]; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4252, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4252, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v12.x = *(_QWORD *)&v->x;
		    v12.z = z;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_250(v13, Patch, &v12, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    v5 = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    v5 = v->z;
		    retstr->x = v5;
		    retstr->y = v5;
		  }
		  retstr->z = v5;
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 xxxx(this Vector3 v) => default; // 0x0000000189C388EC-0x0000000189C3896C
		// Vector4 xxxx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4253, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4253, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    *(__m128 *)retstr = _mm_shuffle_ps((__m128)LODWORD(v->x), (__m128)LODWORD(v->x), 0);
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xxxy(this Vector3 v) => default; // 0x0000000189C38ACC-0x0000000189C38B50
		// Vector4 xxxy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4254, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4254, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xxxz(this Vector3 v) => default; // 0x0000000189C38C58-0x0000000189C38CDC
		// Vector4 xxxz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4255, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4255, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xxyx(this Vector3 v) => default; // 0x0000000189C38F70-0x0000000189C38FF8
		// Vector4 xxyx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4256, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4256, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xxyy(this Vector3 v) => default; // 0x0000000189C3920C-0x0000000189C39290
		// Vector4 xxyy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v8; // rcx
		  float z; // eax
		  Vector3 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4257, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4257, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, 0LL);
		    z = v->z;
		    *(_QWORD *)&v11.x = *(_QWORD *)&v->x;
		    v11.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xxyz(this Vector3 v) => default; // 0x0000000189C39310-0x0000000189C39398
		// Vector4 xxyz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4258, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4258, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xxzx(this Vector3 v) => default; // 0x0000000189C39520-0x0000000189C395A8
		// Vector4 xxzx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4259, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4259, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xxzy(this Vector3 v) => default; // 0x0000000189C396A8-0x0000000189C39730
		// Vector4 xxzy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4260, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4260, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xxzz(this Vector3 v) => default; // 0x0000000189C39730-0x0000000189C397B4
		// Vector4 xxzz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  float v6; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v8; // rcx
		  float z; // eax
		  Vector3 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4261, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4261, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, 0LL);
		    z = v->z;
		    *(_QWORD *)&v11.x = *(_QWORD *)&v->x;
		    v11.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    v6 = v->z;
		    retstr->z = v6;
		    retstr->w = v6;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xyxx(this Vector3 v) => default; // 0x0000000189C39E9C-0x0000000189C39F24
		// Vector4 xyxx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4262, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4262, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xyxy(this Vector3 v) => default; // 0x0000000189C39FB0-0x0000000189C3A03C
		// Vector4 xyxy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4263, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4263, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xyxz(this Vector3 v) => default; // 0x0000000189C3A1D0-0x0000000189C3A25C
		// Vector4 xyxz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4264, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4264, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xyyx(this Vector3 v) => default; // 0x0000000189C3A580-0x0000000189C3A608
		// Vector4 xyyx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4265, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4265, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xyyy(this Vector3 v) => default; // 0x0000000189C3A608-0x0000000189C3A68C
		// Vector4 xyyy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4266, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4266, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xyyz(this Vector3 v) => default; // 0x0000000189C3A814-0x0000000189C3A89C
		// Vector4 xyyz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4267, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4267, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xyzx(this Vector3 v) => default; // 0x000000018323D580-0x000000018323D600
		// Vector4 xyzx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // xmm0_8
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 1305 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x519 )
		        sub_1800D2AB0(v5, wrapperArray);
		      if ( !v5[27].vtable.Equals.method )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1305, 0LL);
		      if ( Patch )
		      {
		        v9 = *(_QWORD *)&v->x;
		        v10.z = v->z;
		        *(_QWORD *)&v10.x = v9;
		        *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		        return retstr;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v5, wrapperArray);
		  }
		LABEL_5:
		  retstr->x = v->x;
		  retstr->y = v->y;
		  retstr->z = v->z;
		  retstr->w = v->x;
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xyzy(this Vector3 v) => default; // 0x0000000189C3A9A4-0x0000000189C3AA30
		// Vector4 xyzy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4268, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4268, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xyzz(this Vector3 v) => default; // 0x0000000189C3AB34-0x0000000189C3ABBC
		// Vector4 xyzz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4269, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4269, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    v5 = v->z;
		    retstr->z = v5;
		    retstr->w = v5;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xzxx(this Vector3 v) => default; // 0x0000000189C3B0B8-0x0000000189C3B140
		// Vector4 xzxx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4270, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4270, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xzxy(this Vector3 v) => default; // 0x0000000189C3B1C4-0x0000000189C3B250
		// Vector4 xzxy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4271, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4271, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xzxz(this Vector3 v) => default; // 0x0000000189C3B250-0x0000000189C3B2DC
		// Vector4 xzxz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4272, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4272, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xzyx(this Vector3 v) => default; // 0x0000000189C3B4EC-0x0000000189C3B578
		// Vector4 xzyx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4273, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4273, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xzyy(this Vector3 v) => default; // 0x0000000189C3B67C-0x0000000189C3B704
		// Vector4 xzyy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4274, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4274, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xzyz(this Vector3 v) => default; // 0x0000000189C3B704-0x0000000189C3B790
		// Vector4 xzyz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4275, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4275, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xzzx(this Vector3 v) => default; // 0x0000000189C3BA1C-0x0000000189C3BAA4
		// Vector4 xzzx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4276, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4276, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    v5 = v->z;
		    retstr->y = v5;
		    retstr->z = v5;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xzzy(this Vector3 v) => default; // 0x0000000189C3BB24-0x0000000189C3BBAC
		// Vector4 xzzy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4277, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4277, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    v5 = v->z;
		    retstr->y = v5;
		    retstr->z = v5;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 xzzz(this Vector3 v) => default; // 0x0000000189C3BC28-0x0000000189C3BCAC
		// Vector4 xzzz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4278, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4278, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    v5 = v->z;
		    retstr->y = v5;
		    retstr->z = v5;
		    retstr->w = v5;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yxxx(this Vector3 v) => default; // 0x0000000189C3CD24-0x0000000189C3CDA8
		// Vector4 yxxx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4279, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4279, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yxxy(this Vector3 v) => default; // 0x0000000189C3CEB0-0x0000000189C3CF38
		// Vector4 yxxy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4280, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4280, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yxxz(this Vector3 v) => default; // 0x0000000189C3D0C4-0x0000000189C3D14C
		// Vector4 yxxz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4281, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4281, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yxyx(this Vector3 v) => default; // 0x0000000189C3D478-0x0000000189C3D504
		// Vector4 yxyx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4282, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4282, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yxyy(this Vector3 v) => default; // 0x0000000189C3D590-0x0000000189C3D618
		// Vector4 yxyy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4283, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4283, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yxyz(this Vector3 v) => default; // 0x0000000189C3D698-0x0000000189C3D724
		// Vector4 yxyz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4284, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4284, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yxzx(this Vector3 v) => default; // 0x0000000189C3D934-0x0000000189C3D9C0
		// Vector4 yxzx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4285, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4285, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yxzy(this Vector3 v) => default; // 0x0000000189C3DAC8-0x0000000189C3DB54
		// Vector4 yxzy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4286, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4286, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yxzz(this Vector3 v) => default; // 0x0000000189C3DB54-0x0000000189C3DBDC
		// Vector4 yxzz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4287, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4287, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    v5 = v->z;
		    retstr->z = v5;
		    retstr->w = v5;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yyxx(this Vector3 v) => default; // 0x0000000189C3E33C-0x0000000189C3E3C0
		// Vector4 yyxx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v8; // rcx
		  float z; // eax
		  Vector3 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4288, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4288, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, 0LL);
		    z = v->z;
		    *(_QWORD *)&v11.x = *(_QWORD *)&v->x;
		    v11.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yyxy(this Vector3 v) => default; // 0x0000000189C3E3C0-0x0000000189C3E448
		// Vector4 yyxy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4289, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4289, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yyxz(this Vector3 v) => default; // 0x0000000189C3E554-0x0000000189C3E5DC
		// Vector4 yyxz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4290, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4290, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yyyx(this Vector3 v) => default; // 0x0000000189C3E8F0-0x0000000189C3E974
		// Vector4 yyyx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4291, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4291, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yyyy(this Vector3 v) => default; // 0x0000000189C3EAE8-0x0000000189C3EB6C
		// Vector4 yyyy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4292, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4292, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yyyz(this Vector3 v) => default; // 0x0000000189C3EBEC-0x0000000189C3EC74
		// Vector4 yyyz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4293, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4293, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yyzx(this Vector3 v) => default; // 0x0000000189C3EDFC-0x0000000189C3EE84
		// Vector4 yyzx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4294, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4294, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yyzy(this Vector3 v) => default; // 0x0000000189C3EF04-0x0000000189C3EF8C
		// Vector4 yyzy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4295, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4295, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yyzz(this Vector3 v) => default; // 0x0000000189C3F00C-0x0000000189C3F094
		// Vector4 yyzz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  float v6; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v8; // rcx
		  float z; // eax
		  Vector3 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4296, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4296, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, 0LL);
		    z = v->z;
		    *(_QWORD *)&v11.x = *(_QWORD *)&v->x;
		    v11.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    v6 = v->z;
		    retstr->z = v6;
		    retstr->w = v6;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yzxx(this Vector3 v) => default; // 0x0000000189C3F600-0x0000000189C3F688
		// Vector4 yzxx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4297, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4297, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yzxy(this Vector3 v) => default; // 0x0000000189C3F78C-0x0000000189C3F818
		// Vector4 yzxy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4298, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4298, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yzxz(this Vector3 v) => default; // 0x0000000189C3F818-0x0000000189C3F8A4
		// Vector4 yzxz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4299, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4299, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yzyx(this Vector3 v) => default; // 0x0000000189C3FABC-0x0000000189C3FB48
		// Vector4 yzyx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4300, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4300, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yzyy(this Vector3 v) => default; // 0x0000000189C3FBCC-0x0000000189C3FC54
		// Vector4 yzyy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4301, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4301, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yzyz(this Vector3 v) => default; // 0x0000000189C3FCD4-0x0000000189C3FD60
		// Vector4 yzyz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4302, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4302, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yzzx(this Vector3 v) => default; // 0x0000000189C3FFEC-0x0000000189C40074
		// Vector4 yzzx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4303, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4303, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    v5 = v->z;
		    retstr->y = v5;
		    retstr->z = v5;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yzzy(this Vector3 v) => default; // 0x0000000189C400F4-0x0000000189C4017C
		// Vector4 yzzy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4304, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4304, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    v5 = v->z;
		    retstr->y = v5;
		    retstr->z = v5;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 yzzz(this Vector3 v) => default; // 0x0000000189C4017C-0x0000000189C40204
		// Vector4 yzzz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4305, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4305, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    v5 = v->z;
		    retstr->y = v5;
		    retstr->z = v5;
		    retstr->w = v5;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zxxx(this Vector3 v) => default; // 0x0000000189C411F8-0x0000000189C4127C
		// Vector4 zxxx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4306, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4306, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zxxy(this Vector3 v) => default; // 0x0000000189C412F8-0x0000000189C41380
		// Vector4 zxxy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4307, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4307, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zxxz(this Vector3 v) => default; // 0x0000000189C41400-0x0000000189C41488
		// Vector4 zxxz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4308, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4308, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zxyx(this Vector3 v) => default; // 0x0000000189C41694-0x0000000189C41720
		// Vector4 zxyx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4309, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4309, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zxyy(this Vector3 v) => default; // 0x0000000189C417A4-0x0000000189C4182C
		// Vector4 zxyy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4310, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4310, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zxyz(this Vector3 v) => default; // 0x0000000189C41930-0x0000000189C419BC
		// Vector4 zxyz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4311, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4311, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zxzx(this Vector3 v) => default; // 0x0000000189C41BCC-0x0000000189C41C58
		// Vector4 zxzx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4312, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4312, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zxzy(this Vector3 v) => default; // 0x0000000189C41C58-0x0000000189C41CE4
		// Vector4 zxzy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4313, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4313, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zxzz(this Vector3 v) => default; // 0x0000000189C41D68-0x0000000189C41DF0
		// Vector4 zxzz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4314, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4314, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    v5 = v->z;
		    retstr->z = v5;
		    retstr->w = v5;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zyxx(this Vector3 v) => default; // 0x0000000189C4235C-0x0000000189C423E4
		// Vector4 zyxx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4315, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4315, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zyxy(this Vector3 v) => default; // 0x0000000189C424E8-0x0000000189C42574
		// Vector4 zyxy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4316, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4316, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zyxz(this Vector3 v) => default; // 0x0000000189C425F8-0x0000000189C42684
		// Vector4 zyxz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4317, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4317, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zyyx(this Vector3 v) => default; // 0x0000000189C4288C-0x0000000189C42914
		// Vector4 zyyx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4318, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4318, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zyyy(this Vector3 v) => default; // 0x0000000189C42994-0x0000000189C42A1C
		// Vector4 zyyy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4319, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4319, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zyyz(this Vector3 v) => default; // 0x0000000189C42A1C-0x0000000189C42AA4
		// Vector4 zyyz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4320, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4320, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zyzx(this Vector3 v) => default; // 0x0000000189C42D3C-0x0000000189C42DC8
		// Vector4 zyzx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4321, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4321, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zyzy(this Vector3 v) => default; // 0x0000000189C42E4C-0x0000000189C42ED8
		// Vector4 zyzy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v6; // rcx
		  float z; // eax
		  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4322, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4322, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, 0LL);
		    z = v->z;
		    *(_QWORD *)&v9.x = *(_QWORD *)&v->x;
		    v9.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zyzz(this Vector3 v) => default; // 0x0000000189C42F58-0x0000000189C42FE0
		// Vector4 zyzz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4323, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4323, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    v5 = v->z;
		    retstr->z = v5;
		    retstr->w = v5;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zzxx(this Vector3 v) => default; // 0x0000000189C434B8-0x0000000189C4353C
		// Vector4 zzxx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzxx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v8; // rcx
		  float z; // eax
		  Vector3 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4324, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4324, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, 0LL);
		    z = v->z;
		    *(_QWORD *)&v11.x = *(_QWORD *)&v->x;
		    v11.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    v5 = v->z;
		    retstr->x = v5;
		    retstr->y = v5;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zzxy(this Vector3 v) => default; // 0x0000000189C43638-0x0000000189C436C0
		// Vector4 zzxy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzxy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4325, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4325, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    v5 = v->z;
		    retstr->x = v5;
		    retstr->y = v5;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zzxz(this Vector3 v) => default; // 0x0000000189C436C0-0x0000000189C43748
		// Vector4 zzxz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzxz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4326, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4326, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    v5 = v->z;
		    retstr->x = v5;
		    retstr->y = v5;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zzyx(this Vector3 v) => default; // 0x0000000189C439D0-0x0000000189C43A58
		// Vector4 zzyx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzyx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4327, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4327, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    v5 = v->z;
		    retstr->x = v5;
		    retstr->y = v5;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zzyy(this Vector3 v) => default; // 0x0000000189C43AD8-0x0000000189C43B60
		// Vector4 zzyy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzyy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v8; // rcx
		  float z; // eax
		  Vector3 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4328, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4328, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, 0LL);
		    z = v->z;
		    *(_QWORD *)&v11.x = *(_QWORD *)&v->x;
		    v11.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    v5 = v->z;
		    retstr->x = v5;
		    retstr->y = v5;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zzyz(this Vector3 v) => default; // 0x0000000189C43B60-0x0000000189C43BE8
		// Vector4 zzyz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzyz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4329, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4329, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    v5 = v->z;
		    retstr->x = v5;
		    retstr->y = v5;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zzzx(this Vector3 v) => default; // 0x0000000189C43E64-0x0000000189C43EE8
		// Vector4 zzzx(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzzx(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4330, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4330, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    v5 = v->z;
		    retstr->x = v5;
		    retstr->y = v5;
		    retstr->z = v5;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zzzy(this Vector3 v) => default; // 0x0000000189C43F68-0x0000000189C43FF0
		// Vector4 zzzy(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzzy(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4331, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4331, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    v5 = v->z;
		    retstr->x = v5;
		    retstr->y = v5;
		    retstr->z = v5;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static Vector4 zzzz(this Vector3 v) => default; // 0x0000000189C4406C-0x0000000189C44164
		// Vector4 zzzz(Vector3)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzzz(Vector4 *__return_ptr retstr, Vector3 *v, MethodInfo *method)
		{
		  float v5; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v7; // rcx
		  float z; // eax
		  Vector3 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4332, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4332, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, 0LL);
		    z = v->z;
		    *(_QWORD *)&v10.x = *(_QWORD *)&v->x;
		    v10.z = z;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_501(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    v5 = v->z;
		    retstr->x = v5;
		    retstr->y = v5;
		    retstr->z = v5;
		    retstr->w = v5;
		  }
		  return retstr;
		}
		
		[IDTag(3)]
		public static Vector2 xx(this Vector4 v) => default; // 0x0000000189C3825C-0x0000000189C382BC
		// Vector2 xx(Vector4)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xx(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4333, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->x), (__m128)LODWORD(v->x)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4333, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_480(Patch, &v7, 0LL);
		}
		
		[IDTag(0)]
		public static Vector2 xy(this Vector4 v) => default; // 0x0000000189C398A4-0x0000000189C39908
		// Vector2 xy(Vector4)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xy(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1255, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->x), (__m128)LODWORD(v->y)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(1255, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_480(Patch, &v7, 0LL);
		}
		
		[IDTag(1)]
		public static Vector2 xz(this Vector4 v) => default; // 0x0000000189C3ABBC-0x0000000189C3AC20
		// Vector2 xz(Vector4)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xz(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4334, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->x), (__m128)LODWORD(v->z)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4334, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_480(Patch, &v7, 0LL);
		}
		
		public static Vector2 xw(this Vector4 v) => default; // 0x0000000189C377D8-0x0000000189C3783C
		// Vector2 xw(Vector4)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::xw(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4335, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->x), (__m128)LODWORD(v->w)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4335, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_480(Patch, &v7, 0LL);
		}
		
		[IDTag(2)]
		public static Vector2 yx(this Vector4 v) => default; // 0x0000000189C3C73C-0x0000000189C3C7A0
		// Vector2 yx(Vector4)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yx(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4336, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->y), (__m128)LODWORD(v->x)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4336, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_480(Patch, &v7, 0LL);
		}
		
		[IDTag(2)]
		public static Vector2 yy(this Vector4 v) => default; // 0x0000000189C3DD38-0x0000000189C3DD9C
		// Vector2 yy(Vector4)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yy(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4337, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->y), (__m128)LODWORD(v->y)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4337, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_480(Patch, &v7, 0LL);
		}
		
		[IDTag(1)]
		public static Vector2 yz(this Vector4 v) => default; // 0x0000000189C3F180-0x0000000189C3F1E4
		// Vector2 yz(Vector4)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yz(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4338, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->y), (__m128)LODWORD(v->z)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4338, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_480(Patch, &v7, 0LL);
		}
		
		public static Vector2 yw(this Vector4 v) => default; // 0x0000000189C3BCAC-0x0000000189C3BD10
		// Vector2 yw(Vector4)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::yw(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4339, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->y), (__m128)LODWORD(v->w)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4339, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_480(Patch, &v7, 0LL);
		}
		
		[IDTag(1)]
		public static Vector2 zx(this Vector4 v) => default; // 0x0000000189C40D14-0x0000000189C40D78
		// Vector2 zx(Vector4)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::zx(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4340, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->z), (__m128)LODWORD(v->x)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4340, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_480(Patch, &v7, 0LL);
		}
		
		[IDTag(1)]
		public static Vector2 zy(this Vector4 v) => default; // 0x0000000189C41E70-0x0000000189C41ED4
		// Vector2 zy(Vector4)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::zy(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4341, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->z), (__m128)LODWORD(v->y)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4341, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_480(Patch, &v7, 0LL);
		}
		
		[IDTag(1)]
		public static Vector2 zz(this Vector4 v) => default; // 0x0000000189C42FE0-0x0000000189C43044
		// Vector2 zz(Vector4)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::zz(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4342, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->z), (__m128)LODWORD(v->z)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4342, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_480(Patch, &v7, 0LL);
		}
		
		public static Vector2 zw(this Vector4 v) => default; // 0x0000000189C40284-0x0000000189C402E8
		// Vector2 zw(Vector4)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::zw(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4343, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->z), (__m128)LODWORD(v->w)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4343, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_480(Patch, &v7, 0LL);
		}
		
		public static Vector2 wx(this Vector4 v) => default; // 0x0000000189C35834-0x0000000189C35898
		// Vector2 wx(Vector4)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::wx(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4344, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->w), (__m128)LODWORD(v->x)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4344, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_480(Patch, &v7, 0LL);
		}
		
		public static Vector2 wy(this Vector4 v) => default; // 0x0000000189C362B8-0x0000000189C3631C
		// Vector2 wy(Vector4)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::wy(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4345, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->w), (__m128)LODWORD(v->y)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4345, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_480(Patch, &v7, 0LL);
		}
		
		public static Vector2 wz(this Vector4 v) => default; // 0x0000000189C36D48-0x0000000189C36DAC
		// Vector2 wz(Vector4)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::wz(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4346, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->w), (__m128)LODWORD(v->z)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4346, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_480(Patch, &v7, 0LL);
		}
		
		public static Vector2 ww(this Vector4 v) => default; // 0x0000000189C34DE0-0x0000000189C34E44
		// Vector2 ww(Vector4)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::ww(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4347, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(v->w), (__m128)LODWORD(v->w)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4347, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_480(Patch, &v7, 0LL);
		}
		
		[IDTag(3)]
		public static Vector3 xxx(this Vector4 v) => default; // 0x0000000189C3876C-0x0000000189C387E8
		// Vector3 xxx(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4348, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4348, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    z = v->x;
		    retstr->x = v->x;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector3 xxy(this Vector4 v) => default; // 0x0000000189C38D58-0x0000000189C38DD8
		// Vector3 xxy(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4349, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4349, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *v;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    z = v->y;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 xxz(this Vector4 v) => default; // 0x0000000189C39398-0x0000000189C39418
		// Vector3 xxz(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4350, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4350, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *v;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    z = v->z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 xxw(this Vector4 v) => default; // 0x0000000189C383F4-0x0000000189C38474
		// Vector3 xxw(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xxw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4351, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4351, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *v;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    z = v->w;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector3 xyx(this Vector4 v) => default; // 0x0000000189C39C88-0x0000000189C39D08
		// Vector3 xyx(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4352, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4352, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    z = v->x;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector3 xyy(this Vector4 v) => default; // 0x0000000189C3A374-0x0000000189C3A3F4
		// Vector3 xyy(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4353, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4353, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->x;
		    z = v->y;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 xyz(this Vector4 v) => default; // 0x000000018323DAB0-0x000000018323DC00
		// Vector3 xyz(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_7;
		  if ( wrapperArray->max_length.size > 1306 )
		  {
		    if ( !v5->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		    if ( v5 )
		    {
		      if ( LODWORD(v5->_0.namespaze) <= 0x51A )
		        sub_1800D2AB0(v5, wrapperArray);
		      if ( !v5[27].vtable.Finalize.methodPtr )
		        goto LABEL_5;
		      Patch = IFix::WrappersManagerImpl::GetPatch(1306, 0LL);
		      if ( Patch )
		      {
		        v13 = *v;
		        v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		        v11 = *(_QWORD *)&v10->x;
		        z = v10->z;
		        *(_QWORD *)&retstr->x = v11;
		        goto LABEL_6;
		      }
		    }
		LABEL_7:
		    sub_1800D8260(v5, wrapperArray);
		  }
		LABEL_5:
		  retstr->x = v->x;
		  retstr->y = v->y;
		  z = v->z;
		LABEL_6:
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 xyw(this Vector4 v) => default; // 0x0000000189C39974-0x0000000189C399F4
		// Vector3 xyw(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xyw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4354, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4354, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    z = v->w;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 xzx(this Vector4 v) => default; // 0x0000000189C3AEAC-0x0000000189C3AF2C
		// Vector3 xzx(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xzx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4355, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4355, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    z = v->x;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 xzy(this Vector4 v) => default; // 0x0000000189C3B3E8-0x0000000189C3B468
		// Vector3 xzy(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xzy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4356, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4356, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    z = v->y;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 xzz(this Vector4 v) => default; // 0x0000000189C3B89C-0x0000000189C3B91C
		// Vector3 xzz(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xzz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4357, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4357, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->x;
		    z = v->z;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 xzw(this Vector4 v) => default; // 0x0000000189C3AC20-0x0000000189C3ACA0
		// Vector3 xzw(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xzw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4358, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4358, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    z = v->w;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 xwx(this Vector4 v) => default; // 0x0000000189C37AB8-0x0000000189C37B38
		// Vector3 xwx(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xwx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4359, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4359, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->w;
		    z = v->x;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 xwy(this Vector4 v) => default; // 0x0000000189C37D44-0x0000000189C37DC4
		// Vector3 xwy(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xwy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4360, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4360, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->w;
		    z = v->y;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 xwz(this Vector4 v) => default; // 0x0000000189C37FD0-0x0000000189C38050
		// Vector3 xwz(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xwz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4361, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4361, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->w;
		    z = v->z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 xww(this Vector4 v) => default; // 0x0000000189C3783C-0x0000000189C378BC
		// Vector3 xww(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::xww(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4362, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4362, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->x;
		    z = v->w;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector3 yxx(this Vector4 v) => default; // 0x0000000189C3CC24-0x0000000189C3CCA4
		// Vector3 yxx(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4363, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4363, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    z = v->x;
		    retstr->y = v->x;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector3 yxy(this Vector4 v) => default; // 0x0000000189C3D1D4-0x0000000189C3D254
		// Vector3 yxy(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4364, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4364, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    z = v->y;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 yxz(this Vector4 v) => default; // 0x0000000189C3D7A8-0x0000000189C3D828
		// Vector3 yxz(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4365, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4365, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    z = v->z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 yxw(this Vector4 v) => default; // 0x0000000189C3C880-0x0000000189C3C900
		// Vector3 yxw(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yxw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4366, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4366, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    z = v->w;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector3 yyx(this Vector4 v) => default; // 0x0000000189C3E01C-0x0000000189C3E09C
		// Vector3 yyx(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4367, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4367, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *v;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    z = v->x;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector3 yyy(this Vector4 v) => default; // 0x0000000189C3E65C-0x0000000189C3E6D8
		// Vector3 yyy(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4368, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4368, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    z = v->y;
		    retstr->x = z;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 yyz(this Vector4 v) => default; // 0x0000000189C3ECFC-0x0000000189C3ED7C
		// Vector3 yyz(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4369, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4369, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *v;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    z = v->z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 yyw(this Vector4 v) => default; // 0x0000000189C3DD9C-0x0000000189C3DE1C
		// Vector3 yyw(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yyw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4370, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4370, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *v;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    z = v->w;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 yzx(this Vector4 v) => default; // 0x0000000189C3F4FC-0x0000000189C3F57C
		// Vector3 yzx(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yzx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4371, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4371, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    z = v->x;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 yzy(this Vector4 v) => default; // 0x0000000189C3F9B4-0x0000000189C3FA38
		// Vector3 yzy(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yzy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4372, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4372, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    z = v->y;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 yzz(this Vector4 v) => default; // 0x0000000189C3FE6C-0x0000000189C3FEEC
		// Vector3 yzz(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yzz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4373, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4373, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    z = v->z;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 yzw(this Vector4 v) => default; // 0x0000000189C3F1E4-0x0000000189C3F268
		// Vector3 yzw(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yzw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4374, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4374, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    z = v->w;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 ywx(this Vector4 v) => default; // 0x0000000189C3BF90-0x0000000189C3C010
		// Vector3 ywx(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::ywx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4375, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4375, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->w;
		    z = v->x;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 ywy(this Vector4 v) => default; // 0x0000000189C3C21C-0x0000000189C3C2A0
		// Vector3 ywy(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::ywy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4376, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4376, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->w;
		    z = v->y;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 ywz(this Vector4 v) => default; // 0x0000000189C3C4AC-0x0000000189C3C530
		// Vector3 ywz(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::ywz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4377, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4377, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->w;
		    z = v->z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 yww(this Vector4 v) => default; // 0x0000000189C3BD10-0x0000000189C3BD90
		// Vector3 yww(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::yww(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4378, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4378, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->y;
		    z = v->w;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 zxx(this Vector4 v) => default; // 0x0000000189C41070-0x0000000189C410F0
		// Vector3 zxx(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zxx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4379, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4379, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    z = v->x;
		    retstr->y = v->x;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 zxy(this Vector4 v) => default; // 0x0000000189C41590-0x0000000189C41610
		// Vector3 zxy(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zxy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4380, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4380, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    z = v->y;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 zxz(this Vector4 v) => default; // 0x0000000189C419BC-0x0000000189C41A3C
		// Vector3 zxz(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zxz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4381, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4381, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    z = v->z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 zxw(this Vector4 v) => default; // 0x0000000189C40DE4-0x0000000189C40E64
		// Vector3 zxw(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zxw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4382, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4382, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    z = v->w;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 zyx(this Vector4 v) => default; // 0x0000000189C42258-0x0000000189C422D8
		// Vector3 zyx(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zyx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4383, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4383, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    z = v->x;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 zyy(this Vector4 v) => default; // 0x0000000189C42684-0x0000000189C42704
		// Vector3 zyy(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zyy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4384, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4384, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    z = v->y;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 zyz(this Vector4 v) => default; // 0x0000000189C42B24-0x0000000189C42BA8
		// Vector3 zyz(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zyz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4385, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4385, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    z = v->z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 zyw(this Vector4 v) => default; // 0x0000000189C41F40-0x0000000189C41FC4
		// Vector3 zyw(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zyw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4386, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4386, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    z = v->w;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 zzx(this Vector4 v) => default; // 0x0000000189C43330-0x0000000189C433B0
		// Vector3 zzx(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zzx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float v5; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4387, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4387, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *v;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    v5 = v->z;
		    retstr->x = v5;
		    retstr->y = v5;
		    z = v->x;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 zzy(this Vector4 v) => default; // 0x0000000189C437C8-0x0000000189C43848
		// Vector3 zzy(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zzy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float v5; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4388, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4388, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *v;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    v5 = v->z;
		    retstr->x = v5;
		    retstr->y = v5;
		    z = v->y;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector3 zzz(this Vector4 v) => default; // 0x0000000189C43CEC-0x0000000189C43D68
		// Vector3 zzz(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zzz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4389, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4389, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 zzw(this Vector4 v) => default; // 0x0000000189C430B0-0x0000000189C43130
		// Vector3 zzw(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zzw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float v5; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4390, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4390, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *v;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    v5 = v->z;
		    retstr->x = v5;
		    retstr->y = v5;
		    z = v->w;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 zwx(this Vector4 v) => default; // 0x0000000189C40568-0x0000000189C405E8
		// Vector3 zwx(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zwx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4391, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4391, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->w;
		    z = v->x;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 zwy(this Vector4 v) => default; // 0x0000000189C407F4-0x0000000189C40878
		// Vector3 zwy(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zwy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4392, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4392, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->w;
		    z = v->y;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 zwz(this Vector4 v) => default; // 0x0000000189C40A84-0x0000000189C40B08
		// Vector3 zwz(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zwz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4393, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4393, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->w;
		    z = v->z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 zww(this Vector4 v) => default; // 0x0000000189C402E8-0x0000000189C40368
		// Vector3 zww(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::zww(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4394, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4394, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->z;
		    z = v->w;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 wxx(this Vector4 v) => default; // 0x0000000189C35B24-0x0000000189C35BA4
		// Vector3 wxx(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wxx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4395, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4395, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->w;
		    z = v->x;
		    retstr->y = v->x;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 wxy(this Vector4 v) => default; // 0x0000000189C35DA0-0x0000000189C35E20
		// Vector3 wxy(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wxy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4396, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4396, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->x;
		    z = v->y;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 wxz(this Vector4 v) => default; // 0x0000000189C3602C-0x0000000189C360AC
		// Vector3 wxz(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wxz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4397, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4397, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->x;
		    z = v->z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 wxw(this Vector4 v) => default; // 0x0000000189C35898-0x0000000189C35918
		// Vector3 wxw(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wxw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4398, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4398, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->x;
		    z = v->w;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 wyx(this Vector4 v) => default; // 0x0000000189C365AC-0x0000000189C3662C
		// Vector3 wyx(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wyx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4399, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4399, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->y;
		    z = v->x;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 wyy(this Vector4 v) => default; // 0x0000000189C36838-0x0000000189C368B8
		// Vector3 wyy(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wyy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4400, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4400, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->w;
		    z = v->y;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 wyz(this Vector4 v) => default; // 0x0000000189C36AB8-0x0000000189C36B3C
		// Vector3 wyz(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wyz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4401, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4401, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->y;
		    z = v->z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 wyw(this Vector4 v) => default; // 0x0000000189C3631C-0x0000000189C363A0
		// Vector3 wyw(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wyw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4402, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4402, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->y;
		    z = v->w;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 wzx(this Vector4 v) => default; // 0x0000000189C3703C-0x0000000189C370BC
		// Vector3 wzx(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wzx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4403, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4403, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->z;
		    z = v->x;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 wzy(this Vector4 v) => default; // 0x0000000189C372C8-0x0000000189C3734C
		// Vector3 wzy(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wzy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4404, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4404, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->z;
		    z = v->y;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 wzz(this Vector4 v) => default; // 0x0000000189C37558-0x0000000189C375D8
		// Vector3 wzz(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wzz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4405, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4405, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->w;
		    z = v->z;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 wzw(this Vector4 v) => default; // 0x0000000189C36DAC-0x0000000189C36E30
		// Vector3 wzw(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wzw(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4406, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4406, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->z;
		    z = v->w;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 wwx(this Vector4 v) => default; // 0x0000000189C350B8-0x0000000189C35138
		// Vector3 wwx(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wwx(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4407, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4407, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *v;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    z = v->x;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 wwy(this Vector4 v) => default; // 0x0000000189C35334-0x0000000189C353B4
		// Vector3 wwy(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wwy(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4408, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4408, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *v;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    z = v->y;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 wwz(this Vector4 v) => default; // 0x0000000189C355B4-0x0000000189C35634
		// Vector3 wwz(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::wwz(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4409, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4409, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *v;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    z = v->z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 www(this Vector4 v) => default; // 0x0000000189C34E44-0x0000000189C34EC0
		// Vector3 www(Vector4)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::www(Vector3 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4410, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4410, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *v;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_502(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    z = v->w;
		    retstr->x = z;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		[IDTag(3)]
		public static Vector4 xxxx(this Vector4 v) => default; // 0x0000000189C3896C-0x0000000189C389E4
		// Vector4 xxxx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4411, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4411, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    *(__m128 *)retstr = _mm_shuffle_ps((__m128)LODWORD(v->x), (__m128)LODWORD(v->x), 0);
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 xxxy(this Vector4 v) => default; // 0x0000000189C38B50-0x0000000189C38BCC
		// Vector4 xxxy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4412, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4412, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xxxz(this Vector4 v) => default; // 0x0000000189C38CDC-0x0000000189C38D58
		// Vector4 xxxz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4413, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4413, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 xxxw(this Vector4 v) => default; // 0x0000000189C38870-0x0000000189C388EC
		// Vector4 xxxw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4414, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4414, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = x;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 xxyx(this Vector4 v) => default; // 0x0000000189C39084-0x0000000189C39104
		// Vector4 xxyx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4415, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4415, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 xxyy(this Vector4 v) => default; // 0x0000000189C39190-0x0000000189C3920C
		// Vector4 xxyy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4416, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4416, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xxyz(this Vector4 v) => default; // 0x0000000189C39290-0x0000000189C39310
		// Vector4 xxyz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4417, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4417, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 xxyw(this Vector4 v) => default; // 0x0000000189C38EF0-0x0000000189C38F70
		// Vector4 xxyw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4418, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4418, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = v->y;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xxzx(this Vector4 v) => default; // 0x0000000189C395A8-0x0000000189C39628
		// Vector4 xxzx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4419, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4419, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xxzy(this Vector4 v) => default; // 0x0000000189C39628-0x0000000189C396A8
		// Vector4 xxzy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4420, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4420, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xxzz(this Vector4 v) => default; // 0x0000000189C397B4-0x0000000189C39830
		// Vector4 xxzz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4421, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4421, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    z = v->z;
		    retstr->z = z;
		    retstr->w = z;
		  }
		  return retstr;
		}
		
		public static Vector4 xxzw(this Vector4 v) => default; // 0x0000000189C394A0-0x0000000189C39520
		// Vector4 xxzw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4422, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4422, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = v->z;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 xxwx(this Vector4 v) => default; // 0x0000000189C384F0-0x0000000189C38570
		// Vector4 xxwx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4423, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4423, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = v->w;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 xxwy(this Vector4 v) => default; // 0x0000000189C38570-0x0000000189C385F0
		// Vector4 xxwy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4424, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4424, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = v->w;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 xxwz(this Vector4 v) => default; // 0x0000000189C385F0-0x0000000189C38670
		// Vector4 xxwz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4425, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4425, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    retstr->z = v->w;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 xxww(this Vector4 v) => default; // 0x0000000189C38474-0x0000000189C384F0
		// Vector4 xxww(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xxww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4426, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4426, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    x = v->x;
		    retstr->x = v->x;
		    retstr->y = x;
		    w = v->w;
		    retstr->z = w;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 xyxx(this Vector4 v) => default; // 0x0000000189C39E1C-0x0000000189C39E9C
		// Vector4 xyxx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4427, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4427, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 xyxy(this Vector4 v) => default; // 0x0000000189C3A0C8-0x0000000189C3A14C
		// Vector4 xyxy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4428, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4428, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xyxz(this Vector4 v) => default; // 0x0000000189C3A14C-0x0000000189C3A1D0
		// Vector4 xyxz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4429, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4429, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 xyxw(this Vector4 v) => default; // 0x0000000189C39D98-0x0000000189C39E1C
		// Vector4 xyxw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4430, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4430, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    retstr->z = v->x;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 xyyx(this Vector4 v) => default; // 0x0000000189C3A500-0x0000000189C3A580
		// Vector4 xyyx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4431, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4431, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 xyyy(this Vector4 v) => default; // 0x0000000189C3A718-0x0000000189C3A794
		// Vector4 xyyy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4432, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4432, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xyyz(this Vector4 v) => default; // 0x0000000189C3A794-0x0000000189C3A814
		// Vector4 xyyz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4433, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4433, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 xyyw(this Vector4 v) => default; // 0x0000000189C3A3F4-0x0000000189C3A474
		// Vector4 xyyw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4434, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4434, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xyzx(this Vector4 v) => default; // 0x0000000189C3A920-0x0000000189C3A9A4
		// Vector4 xyzx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4435, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4435, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xyzy(this Vector4 v) => default; // 0x0000000189C3AA30-0x0000000189C3AAB4
		// Vector4 xyzy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4436, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4436, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xyzz(this Vector4 v) => default; // 0x0000000189C3AAB4-0x0000000189C3AB34
		// Vector4 xyzz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4437, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4437, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    z = v->z;
		    retstr->z = z;
		    retstr->w = z;
		  }
		  return retstr;
		}
		
		public static Vector4 xyzw(this Vector4 v) => default; // 0x0000000189C3A89C-0x0000000189C3A920
		// Vector4 xyzw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4438, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4438, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    retstr->z = v->z;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 xywx(this Vector4 v) => default; // 0x0000000189C39A74-0x0000000189C39AF8
		// Vector4 xywx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xywx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4439, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4439, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    retstr->z = v->w;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 xywy(this Vector4 v) => default; // 0x0000000189C39AF8-0x0000000189C39B7C
		// Vector4 xywy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xywy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4440, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4440, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    retstr->z = v->w;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 xywz(this Vector4 v) => default; // 0x0000000189C39B7C-0x0000000189C39C00
		// Vector4 xywz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xywz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4441, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4441, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    retstr->z = v->w;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 xyww(this Vector4 v) => default; // 0x0000000189C399F4-0x0000000189C39A74
		// Vector4 xyww(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xyww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4442, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4442, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->y;
		    w = v->w;
		    retstr->z = w;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xzxx(this Vector4 v) => default; // 0x0000000189C3B038-0x0000000189C3B0B8
		// Vector4 xzxx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4443, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4443, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xzxy(this Vector4 v) => default; // 0x0000000189C3B140-0x0000000189C3B1C4
		// Vector4 xzxy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4444, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4444, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xzxz(this Vector4 v) => default; // 0x0000000189C3B2DC-0x0000000189C3B360
		// Vector4 xzxz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4445, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4445, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 xzxw(this Vector4 v) => default; // 0x0000000189C3AFB4-0x0000000189C3B038
		// Vector4 xzxw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4446, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4446, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    retstr->z = v->x;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xzyx(this Vector4 v) => default; // 0x0000000189C3B578-0x0000000189C3B5FC
		// Vector4 xzyx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4447, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4447, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xzyy(this Vector4 v) => default; // 0x0000000189C3B5FC-0x0000000189C3B67C
		// Vector4 xzyy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4448, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4448, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xzyz(this Vector4 v) => default; // 0x0000000189C3B790-0x0000000189C3B814
		// Vector4 xzyz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4449, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4449, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 xzyw(this Vector4 v) => default; // 0x0000000189C3B468-0x0000000189C3B4EC
		// Vector4 xzyw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4450, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4450, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    retstr->z = v->y;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xzzx(this Vector4 v) => default; // 0x0000000189C3B99C-0x0000000189C3BA1C
		// Vector4 xzzx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4451, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4451, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    z = v->z;
		    retstr->y = z;
		    retstr->z = z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xzzy(this Vector4 v) => default; // 0x0000000189C3BAA4-0x0000000189C3BB24
		// Vector4 xzzy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4452, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4452, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    z = v->z;
		    retstr->y = z;
		    retstr->z = z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 xzzz(this Vector4 v) => default; // 0x0000000189C3BBAC-0x0000000189C3BC28
		// Vector4 xzzz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4453, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4453, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    z = v->z;
		    retstr->y = z;
		    retstr->z = z;
		    retstr->w = z;
		  }
		  return retstr;
		}
		
		public static Vector4 xzzw(this Vector4 v) => default; // 0x0000000189C3B91C-0x0000000189C3B99C
		// Vector4 xzzw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4454, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4454, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    z = v->z;
		    retstr->y = z;
		    retstr->z = z;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 xzwx(this Vector4 v) => default; // 0x0000000189C3AD20-0x0000000189C3ADA4
		// Vector4 xzwx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4455, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4455, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    retstr->z = v->w;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 xzwy(this Vector4 v) => default; // 0x0000000189C3ADA4-0x0000000189C3AE28
		// Vector4 xzwy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4456, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4456, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    retstr->z = v->w;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 xzwz(this Vector4 v) => default; // 0x0000000189C3AE28-0x0000000189C3AEAC
		// Vector4 xzwz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4457, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4457, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    retstr->z = v->w;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 xzww(this Vector4 v) => default; // 0x0000000189C3ACA0-0x0000000189C3AD20
		// Vector4 xzww(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xzww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4458, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4458, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->z;
		    w = v->w;
		    retstr->z = w;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		public static Vector4 xwxx(this Vector4 v) => default; // 0x0000000189C37BBC-0x0000000189C37C3C
		// Vector4 xwxx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4459, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4459, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->w;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		public static Vector4 xwxy(this Vector4 v) => default; // 0x0000000189C37C3C-0x0000000189C37CC0
		// Vector4 xwxy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4460, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4460, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->w;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 xwxz(this Vector4 v) => default; // 0x0000000189C37CC0-0x0000000189C37D44
		// Vector4 xwxz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4461, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4461, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->w;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 xwxw(this Vector4 v) => default; // 0x0000000189C37B38-0x0000000189C37BBC
		// Vector4 xwxw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4462, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4462, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->w;
		    retstr->z = v->x;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 xwyx(this Vector4 v) => default; // 0x0000000189C37E48-0x0000000189C37ECC
		// Vector4 xwyx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4463, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4463, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->w;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 xwyy(this Vector4 v) => default; // 0x0000000189C37ECC-0x0000000189C37F4C
		// Vector4 xwyy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4464, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4464, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->w;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		public static Vector4 xwyz(this Vector4 v) => default; // 0x0000000189C37F4C-0x0000000189C37FD0
		// Vector4 xwyz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4465, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4465, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->w;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 xwyw(this Vector4 v) => default; // 0x0000000189C37DC4-0x0000000189C37E48
		// Vector4 xwyw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4466, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4466, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->w;
		    retstr->z = v->y;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 xwzx(this Vector4 v) => default; // 0x0000000189C380D4-0x0000000189C38158
		// Vector4 xwzx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4467, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4467, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->w;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 xwzy(this Vector4 v) => default; // 0x0000000189C38158-0x0000000189C381DC
		// Vector4 xwzy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4468, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4468, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->w;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 xwzz(this Vector4 v) => default; // 0x0000000189C381DC-0x0000000189C3825C
		// Vector4 xwzz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4469, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4469, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->w;
		    z = v->z;
		    retstr->z = z;
		    retstr->w = z;
		  }
		  return retstr;
		}
		
		public static Vector4 xwzw(this Vector4 v) => default; // 0x0000000189C38050-0x0000000189C380D4
		// Vector4 xwzw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4470, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4470, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    retstr->y = v->w;
		    retstr->z = v->z;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 xwwx(this Vector4 v) => default; // 0x0000000189C37938-0x0000000189C379B8
		// Vector4 xwwx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4471, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4471, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    w = v->w;
		    retstr->y = w;
		    retstr->z = w;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 xwwy(this Vector4 v) => default; // 0x0000000189C379B8-0x0000000189C37A38
		// Vector4 xwwy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4472, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4472, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    w = v->w;
		    retstr->y = w;
		    retstr->z = w;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 xwwz(this Vector4 v) => default; // 0x0000000189C37A38-0x0000000189C37AB8
		// Vector4 xwwz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4473, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4473, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    w = v->w;
		    retstr->y = w;
		    retstr->z = w;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 xwww(this Vector4 v) => default; // 0x0000000189C378BC-0x0000000189C37938
		// Vector4 xwww(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::xwww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4474, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4474, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->x;
		    w = v->w;
		    retstr->y = w;
		    retstr->z = w;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 yxxx(this Vector4 v) => default; // 0x0000000189C3CDA8-0x0000000189C3CE24
		// Vector4 yxxx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4475, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4475, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 yxxy(this Vector4 v) => default; // 0x0000000189C3CFC4-0x0000000189C3D044
		// Vector4 yxxy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4476, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4476, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yxxz(this Vector4 v) => default; // 0x0000000189C3D044-0x0000000189C3D0C4
		// Vector4 yxxz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4477, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4477, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 yxxw(this Vector4 v) => default; // 0x0000000189C3CCA4-0x0000000189C3CD24
		// Vector4 yxxw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4478, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4478, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 yxyx(this Vector4 v) => default; // 0x0000000189C3D3F4-0x0000000189C3D478
		// Vector4 yxyx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4479, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4479, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 yxyy(this Vector4 v) => default; // 0x0000000189C3D618-0x0000000189C3D698
		// Vector4 yxyy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4480, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4480, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yxyz(this Vector4 v) => default; // 0x0000000189C3D724-0x0000000189C3D7A8
		// Vector4 yxyz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4481, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4481, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 yxyw(this Vector4 v) => default; // 0x0000000189C3D2E4-0x0000000189C3D368
		// Vector4 yxyw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4482, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4482, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    retstr->z = v->y;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yxzx(this Vector4 v) => default; // 0x0000000189C3D9C0-0x0000000189C3DA44
		// Vector4 yxzx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4483, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4483, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yxzy(this Vector4 v) => default; // 0x0000000189C3DA44-0x0000000189C3DAC8
		// Vector4 yxzy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4484, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4484, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yxzz(this Vector4 v) => default; // 0x0000000189C3DBDC-0x0000000189C3DC5C
		// Vector4 yxzz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4485, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4485, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    z = v->z;
		    retstr->z = z;
		    retstr->w = z;
		  }
		  return retstr;
		}
		
		public static Vector4 yxzw(this Vector4 v) => default; // 0x0000000189C3D8B0-0x0000000189C3D934
		// Vector4 yxzw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4486, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4486, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    retstr->z = v->z;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 yxwx(this Vector4 v) => default; // 0x0000000189C3C980-0x0000000189C3CA04
		// Vector4 yxwx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4487, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4487, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    retstr->z = v->w;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 yxwy(this Vector4 v) => default; // 0x0000000189C3CA04-0x0000000189C3CA88
		// Vector4 yxwy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4488, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4488, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    retstr->z = v->w;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 yxwz(this Vector4 v) => default; // 0x0000000189C3CA88-0x0000000189C3CB0C
		// Vector4 yxwz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4489, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4489, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    retstr->z = v->w;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 yxww(this Vector4 v) => default; // 0x0000000189C3C900-0x0000000189C3C980
		// Vector4 yxww(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yxww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4490, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4490, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->x;
		    w = v->w;
		    retstr->z = w;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 yyxx(this Vector4 v) => default; // 0x0000000189C3E234-0x0000000189C3E2B0
		// Vector4 yyxx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4491, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4491, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 yyxy(this Vector4 v) => default; // 0x0000000189C3E448-0x0000000189C3E4C8
		// Vector4 yyxy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4492, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4492, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yyxz(this Vector4 v) => default; // 0x0000000189C3E5DC-0x0000000189C3E65C
		// Vector4 yyxz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4493, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4493, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 yyxw(this Vector4 v) => default; // 0x0000000189C3E1B4-0x0000000189C3E234
		// Vector4 yyxw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4494, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4494, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = v->x;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 yyyx(this Vector4 v) => default; // 0x0000000189C3E974-0x0000000189C3E9F0
		// Vector4 yyyx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4495, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4495, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(2)]
		public static Vector4 yyyy(this Vector4 v) => default; // 0x0000000189C3E9F0-0x0000000189C3EA6C
		// Vector4 yyyy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4496, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4496, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yyyz(this Vector4 v) => default; // 0x0000000189C3EB6C-0x0000000189C3EBEC
		// Vector4 yyyz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4497, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4497, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 yyyw(this Vector4 v) => default; // 0x0000000189C3E7E4-0x0000000189C3E864
		// Vector4 yyyw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4498, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4498, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yyzx(this Vector4 v) => default; // 0x0000000189C3EE84-0x0000000189C3EF04
		// Vector4 yyzx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4499, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4499, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yyzy(this Vector4 v) => default; // 0x0000000189C3EF8C-0x0000000189C3F00C
		// Vector4 yyzy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4500, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4500, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yyzz(this Vector4 v) => default; // 0x0000000189C3F094-0x0000000189C3F114
		// Vector4 yyzz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4501, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4501, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    z = v->z;
		    retstr->z = z;
		    retstr->w = z;
		  }
		  return retstr;
		}
		
		public static Vector4 yyzw(this Vector4 v) => default; // 0x0000000189C3ED7C-0x0000000189C3EDFC
		// Vector4 yyzw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4502, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4502, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = v->z;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 yywx(this Vector4 v) => default; // 0x0000000189C3DE9C-0x0000000189C3DF1C
		// Vector4 yywx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yywx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4503, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4503, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = v->w;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 yywy(this Vector4 v) => default; // 0x0000000189C3DF1C-0x0000000189C3DF9C
		// Vector4 yywy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yywy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4504, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4504, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = v->w;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 yywz(this Vector4 v) => default; // 0x0000000189C3DF9C-0x0000000189C3E01C
		// Vector4 yywz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yywz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4505, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4505, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    retstr->z = v->w;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 yyww(this Vector4 v) => default; // 0x0000000189C3DE1C-0x0000000189C3DE9C
		// Vector4 yyww(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yyww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4506, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4506, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    y = v->y;
		    retstr->x = y;
		    retstr->y = y;
		    w = v->w;
		    retstr->z = w;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yzxx(this Vector4 v) => default; // 0x0000000189C3F688-0x0000000189C3F708
		// Vector4 yzxx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4507, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4507, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yzxy(this Vector4 v) => default; // 0x0000000189C3F708-0x0000000189C3F78C
		// Vector4 yzxy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4508, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4508, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yzxz(this Vector4 v) => default; // 0x0000000189C3F8A4-0x0000000189C3F928
		// Vector4 yzxz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4509, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4509, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 yzxw(this Vector4 v) => default; // 0x0000000189C3F57C-0x0000000189C3F600
		// Vector4 yzxw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4510, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4510, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    retstr->z = v->x;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yzyx(this Vector4 v) => default; // 0x0000000189C3FB48-0x0000000189C3FBCC
		// Vector4 yzyx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4511, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4511, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yzyy(this Vector4 v) => default; // 0x0000000189C3FC54-0x0000000189C3FCD4
		// Vector4 yzyy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4512, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4512, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yzyz(this Vector4 v) => default; // 0x0000000189C3FD60-0x0000000189C3FDE4
		// Vector4 yzyz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4513, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4513, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 yzyw(this Vector4 v) => default; // 0x0000000189C3FA38-0x0000000189C3FABC
		// Vector4 yzyw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4514, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4514, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    retstr->z = v->y;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yzzx(this Vector4 v) => default; // 0x0000000189C3FF6C-0x0000000189C3FFEC
		// Vector4 yzzx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4515, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4515, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    z = v->z;
		    retstr->y = z;
		    retstr->z = z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yzzy(this Vector4 v) => default; // 0x0000000189C40074-0x0000000189C400F4
		// Vector4 yzzy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4516, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4516, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    z = v->z;
		    retstr->y = z;
		    retstr->z = z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 yzzz(this Vector4 v) => default; // 0x0000000189C40204-0x0000000189C40284
		// Vector4 yzzz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4517, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4517, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    z = v->z;
		    retstr->y = z;
		    retstr->z = z;
		    retstr->w = z;
		  }
		  return retstr;
		}
		
		public static Vector4 yzzw(this Vector4 v) => default; // 0x0000000189C3FEEC-0x0000000189C3FF6C
		// Vector4 yzzw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4518, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4518, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    z = v->z;
		    retstr->y = z;
		    retstr->z = z;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 yzwx(this Vector4 v) => default; // 0x0000000189C3F2E8-0x0000000189C3F36C
		// Vector4 yzwx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4519, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4519, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    retstr->z = v->w;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 yzwy(this Vector4 v) => default; // 0x0000000189C3F36C-0x0000000189C3F3F0
		// Vector4 yzwy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4520, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4520, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    retstr->z = v->w;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 yzwz(this Vector4 v) => default; // 0x0000000189C3F3F0-0x0000000189C3F474
		// Vector4 yzwz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4521, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4521, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    retstr->z = v->w;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 yzww(this Vector4 v) => default; // 0x0000000189C3F268-0x0000000189C3F2E8
		// Vector4 yzww(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::yzww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4522, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4522, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->z;
		    w = v->w;
		    retstr->z = w;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		public static Vector4 ywxx(this Vector4 v) => default; // 0x0000000189C3C094-0x0000000189C3C114
		// Vector4 ywxx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4523, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4523, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->w;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		public static Vector4 ywxy(this Vector4 v) => default; // 0x0000000189C3C114-0x0000000189C3C198
		// Vector4 ywxy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4524, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4524, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->w;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 ywxz(this Vector4 v) => default; // 0x0000000189C3C198-0x0000000189C3C21C
		// Vector4 ywxz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4525, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4525, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->w;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 ywxw(this Vector4 v) => default; // 0x0000000189C3C010-0x0000000189C3C094
		// Vector4 ywxw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4526, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4526, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->w;
		    retstr->z = v->x;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 ywyx(this Vector4 v) => default; // 0x0000000189C3C324-0x0000000189C3C3A8
		// Vector4 ywyx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4527, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4527, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->w;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 ywyy(this Vector4 v) => default; // 0x0000000189C3C3A8-0x0000000189C3C428
		// Vector4 ywyy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4528, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4528, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->w;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		public static Vector4 ywyz(this Vector4 v) => default; // 0x0000000189C3C428-0x0000000189C3C4AC
		// Vector4 ywyz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4529, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4529, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->w;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 ywyw(this Vector4 v) => default; // 0x0000000189C3C2A0-0x0000000189C3C324
		// Vector4 ywyw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4530, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4530, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->w;
		    retstr->z = v->y;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 ywzx(this Vector4 v) => default; // 0x0000000189C3C5B4-0x0000000189C3C638
		// Vector4 ywzx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4531, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4531, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->w;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 ywzy(this Vector4 v) => default; // 0x0000000189C3C638-0x0000000189C3C6BC
		// Vector4 ywzy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4532, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4532, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->w;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 ywzz(this Vector4 v) => default; // 0x0000000189C3C6BC-0x0000000189C3C73C
		// Vector4 ywzz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4533, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4533, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->w;
		    z = v->z;
		    retstr->z = z;
		    retstr->w = z;
		  }
		  return retstr;
		}
		
		public static Vector4 ywzw(this Vector4 v) => default; // 0x0000000189C3C530-0x0000000189C3C5B4
		// Vector4 ywzw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4534, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4534, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    retstr->y = v->w;
		    retstr->z = v->z;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 ywwx(this Vector4 v) => default; // 0x0000000189C3BE10-0x0000000189C3BE90
		// Vector4 ywwx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4535, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4535, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    w = v->w;
		    retstr->y = w;
		    retstr->z = w;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 ywwy(this Vector4 v) => default; // 0x0000000189C3BE90-0x0000000189C3BF10
		// Vector4 ywwy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4536, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4536, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    w = v->w;
		    retstr->y = w;
		    retstr->z = w;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 ywwz(this Vector4 v) => default; // 0x0000000189C3BF10-0x0000000189C3BF90
		// Vector4 ywwz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4537, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4537, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    w = v->w;
		    retstr->y = w;
		    retstr->z = w;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 ywww(this Vector4 v) => default; // 0x0000000189C3BD90-0x0000000189C3BE10
		// Vector4 ywww(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::ywww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4538, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4538, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->y;
		    w = v->w;
		    retstr->y = w;
		    retstr->z = w;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zxxx(this Vector4 v) => default; // 0x0000000189C4127C-0x0000000189C412F8
		// Vector4 zxxx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4539, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4539, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zxxy(this Vector4 v) => default; // 0x0000000189C41380-0x0000000189C41400
		// Vector4 zxxy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4540, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4540, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zxxz(this Vector4 v) => default; // 0x0000000189C41488-0x0000000189C41508
		// Vector4 zxxz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4541, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4541, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 zxxw(this Vector4 v) => default; // 0x0000000189C41178-0x0000000189C411F8
		// Vector4 zxxw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4542, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4542, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zxyx(this Vector4 v) => default; // 0x0000000189C41720-0x0000000189C417A4
		// Vector4 zxyx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4543, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4543, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zxyy(this Vector4 v) => default; // 0x0000000189C4182C-0x0000000189C418AC
		// Vector4 zxyy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4544, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4544, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zxyz(this Vector4 v) => default; // 0x0000000189C418AC-0x0000000189C41930
		// Vector4 zxyz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4545, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4545, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 zxyw(this Vector4 v) => default; // 0x0000000189C41610-0x0000000189C41694
		// Vector4 zxyw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4546, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4546, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    retstr->z = v->y;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zxzx(this Vector4 v) => default; // 0x0000000189C41B48-0x0000000189C41BCC
		// Vector4 zxzx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4547, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4547, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zxzy(this Vector4 v) => default; // 0x0000000189C41CE4-0x0000000189C41D68
		// Vector4 zxzy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4548, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4548, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zxzz(this Vector4 v) => default; // 0x0000000189C41DF0-0x0000000189C41E70
		// Vector4 zxzz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4549, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4549, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    z = v->z;
		    retstr->z = z;
		    retstr->w = z;
		  }
		  return retstr;
		}
		
		public static Vector4 zxzw(this Vector4 v) => default; // 0x0000000189C41AC4-0x0000000189C41B48
		// Vector4 zxzw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4550, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4550, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    retstr->z = v->z;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 zxwx(this Vector4 v) => default; // 0x0000000189C40EE4-0x0000000189C40F68
		// Vector4 zxwx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4551, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4551, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    retstr->z = v->w;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 zxwy(this Vector4 v) => default; // 0x0000000189C40F68-0x0000000189C40FEC
		// Vector4 zxwy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4552, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4552, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    retstr->z = v->w;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 zxwz(this Vector4 v) => default; // 0x0000000189C40FEC-0x0000000189C41070
		// Vector4 zxwz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4553, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4553, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    retstr->z = v->w;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 zxww(this Vector4 v) => default; // 0x0000000189C40E64-0x0000000189C40EE4
		// Vector4 zxww(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zxww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4554, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4554, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->x;
		    w = v->w;
		    retstr->z = w;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zyxx(this Vector4 v) => default; // 0x0000000189C423E4-0x0000000189C42464
		// Vector4 zyxx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4555, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4555, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zyxy(this Vector4 v) => default; // 0x0000000189C42464-0x0000000189C424E8
		// Vector4 zyxy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4556, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4556, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zyxz(this Vector4 v) => default; // 0x0000000189C42574-0x0000000189C425F8
		// Vector4 zyxz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4557, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4557, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 zyxw(this Vector4 v) => default; // 0x0000000189C422D8-0x0000000189C4235C
		// Vector4 zyxw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4558, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4558, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    retstr->z = v->x;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zyyx(this Vector4 v) => default; // 0x0000000189C4280C-0x0000000189C4288C
		// Vector4 zyyx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4559, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4559, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zyyy(this Vector4 v) => default; // 0x0000000189C42914-0x0000000189C42994
		// Vector4 zyyy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4560, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4560, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zyyz(this Vector4 v) => default; // 0x0000000189C42AA4-0x0000000189C42B24
		// Vector4 zyyz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4561, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4561, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 zyyw(this Vector4 v) => default; // 0x0000000189C4278C-0x0000000189C4280C
		// Vector4 zyyw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4562, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4562, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zyzx(this Vector4 v) => default; // 0x0000000189C42CB8-0x0000000189C42D3C
		// Vector4 zyzx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4563, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4563, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zyzy(this Vector4 v) => default; // 0x0000000189C42DC8-0x0000000189C42E4C
		// Vector4 zyzy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4564, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4564, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zyzz(this Vector4 v) => default; // 0x0000000189C42ED8-0x0000000189C42F58
		// Vector4 zyzz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4565, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4565, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    z = v->z;
		    retstr->z = z;
		    retstr->w = z;
		  }
		  return retstr;
		}
		
		public static Vector4 zyzw(this Vector4 v) => default; // 0x0000000189C42C34-0x0000000189C42CB8
		// Vector4 zyzw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4566, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4566, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    retstr->z = v->z;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 zywx(this Vector4 v) => default; // 0x0000000189C42044-0x0000000189C420C8
		// Vector4 zywx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zywx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4567, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4567, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    retstr->z = v->w;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 zywy(this Vector4 v) => default; // 0x0000000189C420C8-0x0000000189C4214C
		// Vector4 zywy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zywy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4568, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4568, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    retstr->z = v->w;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 zywz(this Vector4 v) => default; // 0x0000000189C4214C-0x0000000189C421D0
		// Vector4 zywz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zywz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4569, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4569, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    retstr->z = v->w;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 zyww(this Vector4 v) => default; // 0x0000000189C41FC4-0x0000000189C42044
		// Vector4 zyww(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zyww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4570, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4570, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->y;
		    w = v->w;
		    retstr->z = w;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zzxx(this Vector4 v) => default; // 0x0000000189C4353C-0x0000000189C435B8
		// Vector4 zzxx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4571, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4571, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zzxy(this Vector4 v) => default; // 0x0000000189C435B8-0x0000000189C43638
		// Vector4 zzxy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4572, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4572, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zzxz(this Vector4 v) => default; // 0x0000000189C43748-0x0000000189C437C8
		// Vector4 zzxz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4573, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4573, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 zzxw(this Vector4 v) => default; // 0x0000000189C43438-0x0000000189C434B8
		// Vector4 zzxw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4574, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4574, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		    retstr->z = v->x;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zzyx(this Vector4 v) => default; // 0x0000000189C43950-0x0000000189C439D0
		// Vector4 zzyx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4575, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4575, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zzyy(this Vector4 v) => default; // 0x0000000189C43A58-0x0000000189C43AD8
		// Vector4 zzyy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4576, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4576, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zzyz(this Vector4 v) => default; // 0x0000000189C43BE8-0x0000000189C43C68
		// Vector4 zzyz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4577, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4577, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 zzyw(this Vector4 v) => default; // 0x0000000189C438D0-0x0000000189C43950
		// Vector4 zzyw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4578, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4578, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		    retstr->z = v->y;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zzzx(this Vector4 v) => default; // 0x0000000189C43DE8-0x0000000189C43E64
		// Vector4 zzzx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4579, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4579, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		    retstr->z = z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zzzy(this Vector4 v) => default; // 0x0000000189C43EE8-0x0000000189C43F68
		// Vector4 zzzy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4580, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4580, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		    retstr->z = z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		[IDTag(1)]
		public static Vector4 zzzz(this Vector4 v) => default; // 0x0000000189C43FF0-0x0000000189C4406C
		// Vector4 zzzz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4581, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4581, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		    retstr->z = z;
		    retstr->w = z;
		  }
		  return retstr;
		}
		
		public static Vector4 zzzw(this Vector4 v) => default; // 0x0000000189C43D68-0x0000000189C43DE8
		// Vector4 zzzw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4582, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4582, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		    retstr->z = z;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 zzwx(this Vector4 v) => default; // 0x0000000189C431B0-0x0000000189C43230
		// Vector4 zzwx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4583, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4583, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		    retstr->z = v->w;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 zzwy(this Vector4 v) => default; // 0x0000000189C43230-0x0000000189C432B0
		// Vector4 zzwy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4584, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4584, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		    retstr->z = v->w;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 zzwz(this Vector4 v) => default; // 0x0000000189C432B0-0x0000000189C43330
		// Vector4 zzwz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4585, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4585, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		    retstr->z = v->w;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 zzww(this Vector4 v) => default; // 0x0000000189C43130-0x0000000189C431B0
		// Vector4 zzww(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zzww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4586, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4586, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    z = v->z;
		    retstr->x = z;
		    retstr->y = z;
		    w = v->w;
		    retstr->z = w;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		public static Vector4 zwxx(this Vector4 v) => default; // 0x0000000189C4066C-0x0000000189C406EC
		// Vector4 zwxx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4587, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4587, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->w;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		public static Vector4 zwxy(this Vector4 v) => default; // 0x0000000189C406EC-0x0000000189C40770
		// Vector4 zwxy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4588, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4588, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->w;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 zwxz(this Vector4 v) => default; // 0x0000000189C40770-0x0000000189C407F4
		// Vector4 zwxz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4589, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4589, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->w;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 zwxw(this Vector4 v) => default; // 0x0000000189C405E8-0x0000000189C4066C
		// Vector4 zwxw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4590, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4590, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->w;
		    retstr->z = v->x;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 zwyx(this Vector4 v) => default; // 0x0000000189C408FC-0x0000000189C40980
		// Vector4 zwyx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4591, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4591, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->w;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 zwyy(this Vector4 v) => default; // 0x0000000189C40980-0x0000000189C40A00
		// Vector4 zwyy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4592, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4592, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->w;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		public static Vector4 zwyz(this Vector4 v) => default; // 0x0000000189C40A00-0x0000000189C40A84
		// Vector4 zwyz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4593, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4593, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->w;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 zwyw(this Vector4 v) => default; // 0x0000000189C40878-0x0000000189C408FC
		// Vector4 zwyw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4594, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4594, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->w;
		    retstr->z = v->y;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 zwzx(this Vector4 v) => default; // 0x0000000189C40B8C-0x0000000189C40C10
		// Vector4 zwzx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4595, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4595, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->w;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 zwzy(this Vector4 v) => default; // 0x0000000189C40C10-0x0000000189C40C94
		// Vector4 zwzy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4596, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4596, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->w;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 zwzz(this Vector4 v) => default; // 0x0000000189C40C94-0x0000000189C40D14
		// Vector4 zwzz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4597, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4597, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->w;
		    z = v->z;
		    retstr->z = z;
		    retstr->w = z;
		  }
		  return retstr;
		}
		
		public static Vector4 zwzw(this Vector4 v) => default; // 0x0000000189C40B08-0x0000000189C40B8C
		// Vector4 zwzw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4598, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4598, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    retstr->y = v->w;
		    retstr->z = v->z;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 zwwx(this Vector4 v) => default; // 0x0000000189C403E8-0x0000000189C40468
		// Vector4 zwwx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4599, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4599, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    w = v->w;
		    retstr->y = w;
		    retstr->z = w;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 zwwy(this Vector4 v) => default; // 0x0000000189C40468-0x0000000189C404E8
		// Vector4 zwwy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4600, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4600, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    w = v->w;
		    retstr->y = w;
		    retstr->z = w;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 zwwz(this Vector4 v) => default; // 0x0000000189C404E8-0x0000000189C40568
		// Vector4 zwwz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4601, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4601, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    w = v->w;
		    retstr->y = w;
		    retstr->z = w;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 zwww(this Vector4 v) => default; // 0x0000000189C40368-0x0000000189C403E8
		// Vector4 zwww(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::zwww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4602, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4602, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->z;
		    w = v->w;
		    retstr->y = w;
		    retstr->z = w;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		public static Vector4 wxxx(this Vector4 v) => default; // 0x0000000189C35C24-0x0000000189C35CA0
		// Vector4 wxxx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4603, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4603, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		public static Vector4 wxxy(this Vector4 v) => default; // 0x0000000189C35CA0-0x0000000189C35D20
		// Vector4 wxxy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4604, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4604, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 wxxz(this Vector4 v) => default; // 0x0000000189C35D20-0x0000000189C35DA0
		// Vector4 wxxz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4605, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4605, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 wxxw(this Vector4 v) => default; // 0x0000000189C35BA4-0x0000000189C35C24
		// Vector4 wxxw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4606, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4606, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    x = v->x;
		    retstr->y = v->x;
		    retstr->z = x;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 wxyx(this Vector4 v) => default; // 0x0000000189C35EA4-0x0000000189C35F28
		// Vector4 wxyx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4607, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4607, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->x;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 wxyy(this Vector4 v) => default; // 0x0000000189C35F28-0x0000000189C35FA8
		// Vector4 wxyy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4608, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4608, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->x;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		public static Vector4 wxyz(this Vector4 v) => default; // 0x0000000189C35FA8-0x0000000189C3602C
		// Vector4 wxyz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4609, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4609, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->x;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 wxyw(this Vector4 v) => default; // 0x0000000189C35E20-0x0000000189C35EA4
		// Vector4 wxyw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4610, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4610, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->x;
		    retstr->z = v->y;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 wxzx(this Vector4 v) => default; // 0x0000000189C36130-0x0000000189C361B4
		// Vector4 wxzx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4611, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4611, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->x;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 wxzy(this Vector4 v) => default; // 0x0000000189C361B4-0x0000000189C36238
		// Vector4 wxzy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4612, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4612, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->x;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 wxzz(this Vector4 v) => default; // 0x0000000189C36238-0x0000000189C362B8
		// Vector4 wxzz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4613, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4613, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->x;
		    z = v->z;
		    retstr->z = z;
		    retstr->w = z;
		  }
		  return retstr;
		}
		
		public static Vector4 wxzw(this Vector4 v) => default; // 0x0000000189C360AC-0x0000000189C36130
		// Vector4 wxzw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4614, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4614, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->x;
		    retstr->z = v->z;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 wxwx(this Vector4 v) => default; // 0x0000000189C35998-0x0000000189C35A1C
		// Vector4 wxwx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4615, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4615, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->x;
		    retstr->z = v->w;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 wxwy(this Vector4 v) => default; // 0x0000000189C35A1C-0x0000000189C35AA0
		// Vector4 wxwy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4616, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4616, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->x;
		    retstr->z = v->w;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 wxwz(this Vector4 v) => default; // 0x0000000189C35AA0-0x0000000189C35B24
		// Vector4 wxwz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4617, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4617, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->x;
		    retstr->z = v->w;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 wxww(this Vector4 v) => default; // 0x0000000189C35918-0x0000000189C35998
		// Vector4 wxww(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wxww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4618, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4618, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->x;
		    w = v->w;
		    retstr->z = w;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		public static Vector4 wyxx(this Vector4 v) => default; // 0x0000000189C366B0-0x0000000189C36730
		// Vector4 wyxx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4619, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4619, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->y;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		public static Vector4 wyxy(this Vector4 v) => default; // 0x0000000189C36730-0x0000000189C367B4
		// Vector4 wyxy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4620, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4620, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->y;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 wyxz(this Vector4 v) => default; // 0x0000000189C367B4-0x0000000189C36838
		// Vector4 wyxz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4621, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4621, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->y;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 wyxw(this Vector4 v) => default; // 0x0000000189C3662C-0x0000000189C366B0
		// Vector4 wyxw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4622, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4622, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->y;
		    retstr->z = v->x;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 wyyx(this Vector4 v) => default; // 0x0000000189C36938-0x0000000189C369B8
		// Vector4 wyyx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4623, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4623, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 wyyy(this Vector4 v) => default; // 0x0000000189C369B8-0x0000000189C36A38
		// Vector4 wyyy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4624, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4624, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		public static Vector4 wyyz(this Vector4 v) => default; // 0x0000000189C36A38-0x0000000189C36AB8
		// Vector4 wyyz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4625, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4625, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 wyyw(this Vector4 v) => default; // 0x0000000189C368B8-0x0000000189C36938
		// Vector4 wyyw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4626, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4626, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    y = v->y;
		    retstr->y = y;
		    retstr->z = y;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 wyzx(this Vector4 v) => default; // 0x0000000189C36BC0-0x0000000189C36C44
		// Vector4 wyzx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4627, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4627, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->y;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 wyzy(this Vector4 v) => default; // 0x0000000189C36C44-0x0000000189C36CC8
		// Vector4 wyzy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4628, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4628, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->y;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 wyzz(this Vector4 v) => default; // 0x0000000189C36CC8-0x0000000189C36D48
		// Vector4 wyzz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4629, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4629, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->y;
		    z = v->z;
		    retstr->z = z;
		    retstr->w = z;
		  }
		  return retstr;
		}
		
		public static Vector4 wyzw(this Vector4 v) => default; // 0x0000000189C36B3C-0x0000000189C36BC0
		// Vector4 wyzw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4630, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4630, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->y;
		    retstr->z = v->z;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 wywx(this Vector4 v) => default; // 0x0000000189C36420-0x0000000189C364A4
		// Vector4 wywx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wywx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4631, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4631, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->y;
		    retstr->z = v->w;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 wywy(this Vector4 v) => default; // 0x0000000189C364A4-0x0000000189C36528
		// Vector4 wywy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wywy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4632, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4632, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->y;
		    retstr->z = v->w;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 wywz(this Vector4 v) => default; // 0x0000000189C36528-0x0000000189C365AC
		// Vector4 wywz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wywz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4633, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4633, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->y;
		    retstr->z = v->w;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 wyww(this Vector4 v) => default; // 0x0000000189C363A0-0x0000000189C36420
		// Vector4 wyww(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wyww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4634, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4634, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->y;
		    w = v->w;
		    retstr->z = w;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		public static Vector4 wzxx(this Vector4 v) => default; // 0x0000000189C37140-0x0000000189C371C0
		// Vector4 wzxx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4635, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4635, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->z;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		public static Vector4 wzxy(this Vector4 v) => default; // 0x0000000189C371C0-0x0000000189C37244
		// Vector4 wzxy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4636, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4636, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->z;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 wzxz(this Vector4 v) => default; // 0x0000000189C37244-0x0000000189C372C8
		// Vector4 wzxz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4637, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4637, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->z;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 wzxw(this Vector4 v) => default; // 0x0000000189C370BC-0x0000000189C37140
		// Vector4 wzxw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4638, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4638, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->z;
		    retstr->z = v->x;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 wzyx(this Vector4 v) => default; // 0x0000000189C373D0-0x0000000189C37454
		// Vector4 wzyx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4639, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4639, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->z;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 wzyy(this Vector4 v) => default; // 0x0000000189C37454-0x0000000189C374D4
		// Vector4 wzyy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4640, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4640, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->z;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		public static Vector4 wzyz(this Vector4 v) => default; // 0x0000000189C374D4-0x0000000189C37558
		// Vector4 wzyz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4641, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4641, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->z;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 wzyw(this Vector4 v) => default; // 0x0000000189C3734C-0x0000000189C373D0
		// Vector4 wzyw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4642, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4642, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->z;
		    retstr->z = v->y;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 wzzx(this Vector4 v) => default; // 0x0000000189C37658-0x0000000189C376D8
		// Vector4 wzzx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4643, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4643, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    z = v->z;
		    retstr->y = z;
		    retstr->z = z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 wzzy(this Vector4 v) => default; // 0x0000000189C376D8-0x0000000189C37758
		// Vector4 wzzy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4644, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4644, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    z = v->z;
		    retstr->y = z;
		    retstr->z = z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 wzzz(this Vector4 v) => default; // 0x0000000189C37758-0x0000000189C377D8
		// Vector4 wzzz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4645, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4645, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    z = v->z;
		    retstr->y = z;
		    retstr->z = z;
		    retstr->w = z;
		  }
		  return retstr;
		}
		
		public static Vector4 wzzw(this Vector4 v) => default; // 0x0000000189C375D8-0x0000000189C37658
		// Vector4 wzzw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4646, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4646, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    z = v->z;
		    retstr->y = z;
		    retstr->z = z;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 wzwx(this Vector4 v) => default; // 0x0000000189C36EB0-0x0000000189C36F34
		// Vector4 wzwx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4647, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4647, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->z;
		    retstr->z = v->w;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 wzwy(this Vector4 v) => default; // 0x0000000189C36F34-0x0000000189C36FB8
		// Vector4 wzwy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4648, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4648, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->z;
		    retstr->z = v->w;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 wzwz(this Vector4 v) => default; // 0x0000000189C36FB8-0x0000000189C3703C
		// Vector4 wzwz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Vector4 v9; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4649, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4649, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->z;
		    retstr->z = v->w;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 wzww(this Vector4 v) => default; // 0x0000000189C36E30-0x0000000189C36EB0
		// Vector4 wzww(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wzww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4650, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4650, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->x = v->w;
		    retstr->y = v->z;
		    w = v->w;
		    retstr->z = w;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		public static Vector4 wwxx(this Vector4 v) => default; // 0x0000000189C351B8-0x0000000189C35234
		// Vector4 wwxx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwxx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  float x; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4651, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4651, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    x = v->x;
		    retstr->z = v->x;
		    retstr->w = x;
		  }
		  return retstr;
		}
		
		public static Vector4 wwxy(this Vector4 v) => default; // 0x0000000189C35234-0x0000000189C352B4
		// Vector4 wwxy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwxy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4652, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4652, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    retstr->z = v->x;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 wwxz(this Vector4 v) => default; // 0x0000000189C352B4-0x0000000189C35334
		// Vector4 wwxz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwxz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4653, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4653, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    retstr->z = v->x;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 wwxw(this Vector4 v) => default; // 0x0000000189C35138-0x0000000189C351B8
		// Vector4 wwxw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwxw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4654, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4654, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    retstr->z = v->x;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 wwyx(this Vector4 v) => default; // 0x0000000189C35434-0x0000000189C354B4
		// Vector4 wwyx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwyx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4655, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4655, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    retstr->z = v->y;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 wwyy(this Vector4 v) => default; // 0x0000000189C354B4-0x0000000189C35534
		// Vector4 wwyy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwyy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  float y; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4656, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4656, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    y = v->y;
		    retstr->z = y;
		    retstr->w = y;
		  }
		  return retstr;
		}
		
		public static Vector4 wwyz(this Vector4 v) => default; // 0x0000000189C35534-0x0000000189C355B4
		// Vector4 wwyz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwyz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4657, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4657, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    retstr->z = v->y;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 wwyw(this Vector4 v) => default; // 0x0000000189C353B4-0x0000000189C35434
		// Vector4 wwyw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwyw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4658, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4658, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    retstr->z = v->y;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 wwzx(this Vector4 v) => default; // 0x0000000189C356B4-0x0000000189C35734
		// Vector4 wwzx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwzx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4659, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4659, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    retstr->z = v->z;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 wwzy(this Vector4 v) => default; // 0x0000000189C35734-0x0000000189C357B4
		// Vector4 wwzy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwzy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4660, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4660, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    retstr->z = v->z;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 wwzz(this Vector4 v) => default; // 0x0000000189C357B4-0x0000000189C35834
		// Vector4 wwzz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwzz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector4 v11; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4661, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4661, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    z = v->z;
		    retstr->z = z;
		    retstr->w = z;
		  }
		  return retstr;
		}
		
		public static Vector4 wwzw(this Vector4 v) => default; // 0x0000000189C35634-0x0000000189C356B4
		// Vector4 wwzw(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwzw(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4662, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4662, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    retstr->z = v->z;
		    retstr->w = v->w;
		  }
		  return retstr;
		}
		
		public static Vector4 wwwx(this Vector4 v) => default; // 0x0000000189C34F3C-0x0000000189C34FB8
		// Vector4 wwwx(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwwx(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4663, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4663, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    retstr->z = w;
		    retstr->w = v->x;
		  }
		  return retstr;
		}
		
		public static Vector4 wwwy(this Vector4 v) => default; // 0x0000000189C34FB8-0x0000000189C35038
		// Vector4 wwwy(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwwy(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4664, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4664, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    retstr->z = w;
		    retstr->w = v->y;
		  }
		  return retstr;
		}
		
		public static Vector4 wwwz(this Vector4 v) => default; // 0x0000000189C35038-0x0000000189C350B8
		// Vector4 wwwz(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwwz(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4665, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4665, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    retstr->z = w;
		    retstr->w = v->z;
		  }
		  return retstr;
		}
		
		public static Vector4 wwww(this Vector4 v) => default; // 0x0000000189C34EC0-0x0000000189C34F3C
		// Vector4 wwww(Vector4)
		Vector4 *HG::Rendering::Runtime::VectorSwizzleUtils::wwww(Vector4 *__return_ptr retstr, Vector4 *v, MethodInfo *method)
		{
		  float w; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector4 v10; // [rsp+20h] [rbp-28h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4666, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4666, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *v;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1352(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    w = v->w;
		    retstr->x = w;
		    retstr->y = w;
		    retstr->z = w;
		    retstr->w = w;
		  }
		  return retstr;
		}
		
		public static Vector2 rr(this UnityEngine.Color c) => default; // 0x0000000189C343A4-0x0000000189C34404
		// Vector2 rr(Color)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::rr(Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Color v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4667, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c->r), (__m128)LODWORD(c->r)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4667, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *c;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1471(Patch, &v7, 0LL);
		}
		
		public static Vector2 rg(this UnityEngine.Color c) => default; // 0x0000000189C33920-0x0000000189C33984
		// Vector2 rg(Color)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::rg(Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Color v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4668, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c->r), (__m128)LODWORD(c->g)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4668, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *c;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1471(Patch, &v7, 0LL);
		}
		
		public static Vector2 rb(this UnityEngine.Color c) => default; // 0x0000000189C32E9C-0x0000000189C32F00
		// Vector2 rb(Color)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::rb(Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Color v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4669, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c->r), (__m128)LODWORD(c->b)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4669, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *c;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1471(Patch, &v7, 0LL);
		}
		
		public static Vector2 ra(this UnityEngine.Color c) => default; // 0x0000000189C32418-0x0000000189C3247C
		// Vector2 ra(Color)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::ra(Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Color v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4670, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c->r), (__m128)LODWORD(c->a)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4670, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *c;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1471(Patch, &v7, 0LL);
		}
		
		public static Vector2 gr(this UnityEngine.Color c) => default; // 0x0000000189C31994-0x0000000189C319F8
		// Vector2 gr(Color)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::gr(Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Color v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4671, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c->g), (__m128)LODWORD(c->r)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4671, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *c;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1471(Patch, &v7, 0LL);
		}
		
		public static Vector2 gg(this UnityEngine.Color c) => default; // 0x0000000189C30F40-0x0000000189C30FA4
		// Vector2 gg(Color)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::gg(Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Color v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4672, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c->g), (__m128)LODWORD(c->g)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4672, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *c;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1471(Patch, &v7, 0LL);
		}
		
		public static Vector2 gb(this UnityEngine.Color c) => default; // 0x0000000189C304B0-0x0000000189C30514
		// Vector2 gb(Color)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::gb(Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Color v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4673, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c->g), (__m128)LODWORD(c->b)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4673, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *c;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1471(Patch, &v7, 0LL);
		}
		
		public static Vector2 ga(this UnityEngine.Color c) => default; // 0x0000000189C2FA20-0x0000000189C2FA84
		// Vector2 ga(Color)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::ga(Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Color v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4674, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c->g), (__m128)LODWORD(c->a)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4674, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *c;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1471(Patch, &v7, 0LL);
		}
		
		public static Vector2 br(this UnityEngine.Color c) => default; // 0x0000000189C2EF9C-0x0000000189C2F000
		// Vector2 br(Color)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::br(Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Color v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4675, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c->b), (__m128)LODWORD(c->r)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4675, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *c;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1471(Patch, &v7, 0LL);
		}
		
		public static Vector2 bg(this UnityEngine.Color c) => default; // 0x0000000189C2E50C-0x0000000189C2E570
		// Vector2 bg(Color)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::bg(Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Color v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4676, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c->b), (__m128)LODWORD(c->g)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4676, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *c;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1471(Patch, &v7, 0LL);
		}
		
		public static Vector2 bb(this UnityEngine.Color c) => default; // 0x0000000189C2DAB8-0x0000000189C2DB1C
		// Vector2 bb(Color)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::bb(Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Color v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4677, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c->b), (__m128)LODWORD(c->b)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4677, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *c;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1471(Patch, &v7, 0LL);
		}
		
		public static Vector2 ba(this UnityEngine.Color c) => default; // 0x0000000189C2D028-0x0000000189C2D08C
		// Vector2 ba(Color)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::ba(Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Color v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4678, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c->b), (__m128)LODWORD(c->a)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4678, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *c;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1471(Patch, &v7, 0LL);
		}
		
		public static Vector2 ar(this UnityEngine.Color c) => default; // 0x0000000189C2C5A4-0x0000000189C2C608
		// Vector2 ar(Color)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::ar(Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Color v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4679, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c->a), (__m128)LODWORD(c->r)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4679, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *c;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1471(Patch, &v7, 0LL);
		}
		
		public static Vector2 ag(this UnityEngine.Color c) => default; // 0x0000000189C2BB14-0x0000000189C2BB78
		// Vector2 ag(Color)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::ag(Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Color v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4680, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c->a), (__m128)LODWORD(c->g)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4680, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *c;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1471(Patch, &v7, 0LL);
		}
		
		public static Vector2 ab(this UnityEngine.Color c) => default; // 0x0000000189C2B084-0x0000000189C2B0E8
		// Vector2 ab(Color)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::ab(Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Color v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4681, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c->a), (__m128)LODWORD(c->b)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4681, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *c;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1471(Patch, &v7, 0LL);
		}
		
		public static Vector2 aa(this UnityEngine.Color c) => default; // 0x0000000189C2A630-0x0000000189C2A694
		// Vector2 aa(Color)
		Vector2 HG::Rendering::Runtime::VectorSwizzleUtils::aa(Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Color v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4682, 0LL) )
		    return (Vector2)_mm_unpacklo_ps((__m128)LODWORD(c->a), (__m128)LODWORD(c->a)).m128_u64[0];
		  Patch = IFix::WrappersManagerImpl::GetPatch(4682, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *c;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1471(Patch, &v7, 0LL);
		}
		
		public static Vector3 rrr(this UnityEngine.Color c) => default; // 0x0000000189C34B78-0x0000000189C34BF4
		// Vector3 rrr(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rrr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4683, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4683, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    z = c->r;
		    retstr->x = c->r;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 rrg(this UnityEngine.Color c) => default; // 0x0000000189C348FC-0x0000000189C3497C
		// Vector3 rrg(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rrg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Color v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4684, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4684, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *c;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    r = c->r;
		    retstr->x = c->r;
		    retstr->y = r;
		    z = c->g;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 rrb(this UnityEngine.Color c) => default; // 0x0000000189C34680-0x0000000189C34700
		// Vector3 rrb(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rrb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Color v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4685, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4685, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *c;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    r = c->r;
		    retstr->x = c->r;
		    retstr->y = r;
		    z = c->b;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 rra(this UnityEngine.Color c) => default; // 0x0000000189C34404-0x0000000189C34484
		// Vector3 rra(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rra(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Color v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4686, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4686, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *c;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    r = c->r;
		    retstr->x = c->r;
		    retstr->y = r;
		    z = c->a;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 rgr(this UnityEngine.Color c) => default; // 0x0000000189C34118-0x0000000189C34198
		// Vector3 rgr(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rgr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4687, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4687, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->r;
		    retstr->y = c->g;
		    z = c->r;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 rgg(this UnityEngine.Color c) => default; // 0x0000000189C33E9C-0x0000000189C33F1C
		// Vector3 rgg(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rgg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4688, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4688, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->r;
		    z = c->g;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 rgb(this UnityEngine.Color c) => default; // 0x0000000189C33C10-0x0000000189C33C90
		// Vector3 rgb(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rgb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1433, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1433, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->r;
		    retstr->y = c->g;
		    z = c->b;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 rga(this UnityEngine.Color c) => default; // 0x0000000189C33984-0x0000000189C33A04
		// Vector3 rga(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rga(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4689, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4689, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->r;
		    retstr->y = c->g;
		    z = c->a;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 rbr(this UnityEngine.Color c) => default; // 0x0000000189C33694-0x0000000189C33714
		// Vector3 rbr(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rbr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4690, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4690, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->r;
		    retstr->y = c->b;
		    z = c->r;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 rbg(this UnityEngine.Color c) => default; // 0x0000000189C33408-0x0000000189C33488
		// Vector3 rbg(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rbg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4691, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4691, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->r;
		    retstr->y = c->b;
		    z = c->g;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 rbb(this UnityEngine.Color c) => default; // 0x0000000189C3318C-0x0000000189C3320C
		// Vector3 rbb(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rbb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4692, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4692, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->r;
		    z = c->b;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 rba(this UnityEngine.Color c) => default; // 0x0000000189C32F00-0x0000000189C32F80
		// Vector3 rba(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rba(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4693, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4693, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->r;
		    retstr->y = c->b;
		    z = c->a;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 rar(this UnityEngine.Color c) => default; // 0x0000000189C32C10-0x0000000189C32C90
		// Vector3 rar(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rar(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4694, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4694, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->r;
		    retstr->y = c->a;
		    z = c->r;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 rag(this UnityEngine.Color c) => default; // 0x0000000189C32984-0x0000000189C32A04
		// Vector3 rag(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rag(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4695, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4695, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->r;
		    retstr->y = c->a;
		    z = c->g;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 rab(this UnityEngine.Color c) => default; // 0x0000000189C326F8-0x0000000189C32778
		// Vector3 rab(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::rab(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4696, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4696, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->r;
		    retstr->y = c->a;
		    z = c->b;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 raa(this UnityEngine.Color c) => default; // 0x0000000189C3247C-0x0000000189C324FC
		// Vector3 raa(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::raa(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4697, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4697, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->r;
		    z = c->a;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 grr(this UnityEngine.Color c) => default; // 0x0000000189C3219C-0x0000000189C3221C
		// Vector3 grr(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::grr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4698, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4698, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->g;
		    z = c->r;
		    retstr->y = c->r;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 grg(this UnityEngine.Color c) => default; // 0x0000000189C31F10-0x0000000189C31F90
		// Vector3 grg(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::grg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4699, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4699, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->g;
		    retstr->y = c->r;
		    z = c->g;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 grb(this UnityEngine.Color c) => default; // 0x0000000189C31C84-0x0000000189C31D04
		// Vector3 grb(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::grb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4700, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4700, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->g;
		    retstr->y = c->r;
		    z = c->b;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 gra(this UnityEngine.Color c) => default; // 0x0000000189C319F8-0x0000000189C31A78
		// Vector3 gra(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gra(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4701, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4701, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->g;
		    retstr->y = c->r;
		    z = c->a;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 ggr(this UnityEngine.Color c) => default; // 0x0000000189C31718-0x0000000189C31798
		// Vector3 ggr(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::ggr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Color v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4702, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4702, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *c;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    g = c->g;
		    retstr->x = g;
		    retstr->y = g;
		    z = c->r;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 ggg(this UnityEngine.Color c) => default; // 0x0000000189C314A4-0x0000000189C31520
		// Vector3 ggg(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::ggg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4703, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4703, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    z = c->g;
		    retstr->x = z;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 ggb(this UnityEngine.Color c) => default; // 0x0000000189C31224-0x0000000189C312A4
		// Vector3 ggb(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::ggb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Color v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4704, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4704, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *c;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    g = c->g;
		    retstr->x = g;
		    retstr->y = g;
		    z = c->b;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 gga(this UnityEngine.Color c) => default; // 0x0000000189C30FA4-0x0000000189C31024
		// Vector3 gga(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gga(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Color v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4705, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4705, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *c;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    g = c->g;
		    retstr->x = g;
		    retstr->y = g;
		    z = c->a;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 gbr(this UnityEngine.Color c) => default; // 0x0000000189C30CB4-0x0000000189C30D34
		// Vector3 gbr(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gbr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4706, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4706, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->g;
		    retstr->y = c->b;
		    z = c->r;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 gbg(this UnityEngine.Color c) => default; // 0x0000000189C30A24-0x0000000189C30AA8
		// Vector3 gbg(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gbg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4707, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4707, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->g;
		    retstr->y = c->b;
		    z = c->g;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 gbb(this UnityEngine.Color c) => default; // 0x0000000189C307A4-0x0000000189C30824
		// Vector3 gbb(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gbb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4708, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4708, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->g;
		    z = c->b;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 gba(this UnityEngine.Color c) => default; // 0x0000000189C30514-0x0000000189C30598
		// Vector3 gba(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gba(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4709, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4709, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->g;
		    retstr->y = c->b;
		    z = c->a;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 gar(this UnityEngine.Color c) => default; // 0x0000000189C30224-0x0000000189C302A4
		// Vector3 gar(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gar(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4710, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4710, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->g;
		    retstr->y = c->a;
		    z = c->r;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 gag(this UnityEngine.Color c) => default; // 0x0000000189C2FF94-0x0000000189C30018
		// Vector3 gag(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gag(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4711, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4711, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->g;
		    retstr->y = c->a;
		    z = c->g;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 gab(this UnityEngine.Color c) => default; // 0x0000000189C2FD04-0x0000000189C2FD88
		// Vector3 gab(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gab(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4712, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4712, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->g;
		    retstr->y = c->a;
		    z = c->b;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 gaa(this UnityEngine.Color c) => default; // 0x0000000189C2FA84-0x0000000189C2FB04
		// Vector3 gaa(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::gaa(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4713, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4713, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->g;
		    z = c->a;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 brr(this UnityEngine.Color c) => default; // 0x0000000189C2F7A4-0x0000000189C2F824
		// Vector3 brr(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::brr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4714, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4714, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->b;
		    z = c->r;
		    retstr->y = c->r;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 brg(this UnityEngine.Color c) => default; // 0x0000000189C2F518-0x0000000189C2F598
		// Vector3 brg(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::brg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4715, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4715, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->b;
		    retstr->y = c->r;
		    z = c->g;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 brb(this UnityEngine.Color c) => default; // 0x0000000189C2F28C-0x0000000189C2F30C
		// Vector3 brb(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::brb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4716, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4716, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->b;
		    retstr->y = c->r;
		    z = c->b;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 bra(this UnityEngine.Color c) => default; // 0x0000000189C2F000-0x0000000189C2F080
		// Vector3 bra(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bra(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4717, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4717, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->b;
		    retstr->y = c->r;
		    z = c->a;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 bgr(this UnityEngine.Color c) => default; // 0x0000000189C2ED10-0x0000000189C2ED90
		// Vector3 bgr(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bgr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4718, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4718, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->b;
		    retstr->y = c->g;
		    z = c->r;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 bgg(this UnityEngine.Color c) => default; // 0x0000000189C2EA90-0x0000000189C2EB10
		// Vector3 bgg(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bgg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4719, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4719, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->b;
		    z = c->g;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 bgb(this UnityEngine.Color c) => default; // 0x0000000189C2E800-0x0000000189C2E884
		// Vector3 bgb(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bgb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4720, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4720, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->b;
		    retstr->y = c->g;
		    z = c->b;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 bga(this UnityEngine.Color c) => default; // 0x0000000189C2E570-0x0000000189C2E5F4
		// Vector3 bga(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bga(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4721, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4721, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->b;
		    retstr->y = c->g;
		    z = c->a;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 bbr(this UnityEngine.Color c) => default; // 0x0000000189C2E290-0x0000000189C2E310
		// Vector3 bbr(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bbr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Color v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4722, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4722, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *c;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    b = c->b;
		    retstr->x = b;
		    retstr->y = b;
		    z = c->r;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 bbg(this UnityEngine.Color c) => default; // 0x0000000189C2E010-0x0000000189C2E090
		// Vector3 bbg(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bbg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Color v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4723, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4723, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *c;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    b = c->b;
		    retstr->x = b;
		    retstr->y = b;
		    z = c->g;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 bbb(this UnityEngine.Color c) => default; // 0x0000000189C2DD9C-0x0000000189C2DE18
		// Vector3 bbb(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bbb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4724, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4724, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    z = c->b;
		    retstr->x = z;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 bba(this UnityEngine.Color c) => default; // 0x0000000189C2DB1C-0x0000000189C2DB9C
		// Vector3 bba(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bba(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Color v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4725, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4725, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *c;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    b = c->b;
		    retstr->x = b;
		    retstr->y = b;
		    z = c->a;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 bar(this UnityEngine.Color c) => default; // 0x0000000189C2D82C-0x0000000189C2D8AC
		// Vector3 bar(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bar(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4726, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4726, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->b;
		    retstr->y = c->a;
		    z = c->r;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 bag(this UnityEngine.Color c) => default; // 0x0000000189C2D59C-0x0000000189C2D620
		// Vector3 bag(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bag(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4727, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4727, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->b;
		    retstr->y = c->a;
		    z = c->g;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 bab(this UnityEngine.Color c) => default; // 0x0000000189C2D30C-0x0000000189C2D390
		// Vector3 bab(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::bab(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4728, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4728, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->b;
		    retstr->y = c->a;
		    z = c->b;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 baa(this UnityEngine.Color c) => default; // 0x0000000189C2D08C-0x0000000189C2D10C
		// Vector3 baa(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::baa(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4729, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4729, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->b;
		    z = c->a;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 arr(this UnityEngine.Color c) => default; // 0x0000000189C2CDAC-0x0000000189C2CE2C
		// Vector3 arr(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::arr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4730, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4730, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->a;
		    z = c->r;
		    retstr->y = c->r;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 arg(this UnityEngine.Color c) => default; // 0x0000000189C2CB20-0x0000000189C2CBA0
		// Vector3 arg(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::arg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4731, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4731, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->a;
		    retstr->y = c->r;
		    z = c->g;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 arb(this UnityEngine.Color c) => default; // 0x0000000189C2C894-0x0000000189C2C914
		// Vector3 arb(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::arb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4732, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4732, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->a;
		    retstr->y = c->r;
		    z = c->b;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 ara(this UnityEngine.Color c) => default; // 0x0000000189C2C608-0x0000000189C2C688
		// Vector3 ara(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::ara(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4733, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4733, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->a;
		    retstr->y = c->r;
		    z = c->a;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 agr(this UnityEngine.Color c) => default; // 0x0000000189C2C318-0x0000000189C2C398
		// Vector3 agr(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::agr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4734, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4734, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->a;
		    retstr->y = c->g;
		    z = c->r;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 agg(this UnityEngine.Color c) => default; // 0x0000000189C2C098-0x0000000189C2C118
		// Vector3 agg(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::agg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4735, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4735, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->a;
		    z = c->g;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 agb(this UnityEngine.Color c) => default; // 0x0000000189C2BE08-0x0000000189C2BE8C
		// Vector3 agb(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::agb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4736, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4736, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->a;
		    retstr->y = c->g;
		    z = c->b;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 aga(this UnityEngine.Color c) => default; // 0x0000000189C2BB78-0x0000000189C2BBFC
		// Vector3 aga(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::aga(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4737, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4737, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->a;
		    retstr->y = c->g;
		    z = c->a;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 abr(this UnityEngine.Color c) => default; // 0x0000000189C2B888-0x0000000189C2B908
		// Vector3 abr(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::abr(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4738, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4738, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->a;
		    retstr->y = c->b;
		    z = c->r;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 abg(this UnityEngine.Color c) => default; // 0x0000000189C2B5F8-0x0000000189C2B67C
		// Vector3 abg(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::abg(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4739, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4739, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->a;
		    retstr->y = c->b;
		    z = c->g;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 abb(this UnityEngine.Color c) => default; // 0x0000000189C2B378-0x0000000189C2B3F8
		// Vector3 abb(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::abb(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4740, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4740, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->a;
		    z = c->b;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 aba(this UnityEngine.Color c) => default; // 0x0000000189C2B0E8-0x0000000189C2B16C
		// Vector3 aba(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::aba(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4741, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4741, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    retstr->x = c->a;
		    retstr->y = c->b;
		    z = c->a;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 aar(this UnityEngine.Color c) => default; // 0x0000000189C2AE08-0x0000000189C2AE88
		// Vector3 aar(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::aar(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Color v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4742, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4742, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *c;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    a = c->a;
		    retstr->x = a;
		    retstr->y = a;
		    z = c->r;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 aag(this UnityEngine.Color c) => default; // 0x0000000189C2AB88-0x0000000189C2AC08
		// Vector3 aag(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::aag(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Color v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4743, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4743, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *c;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    a = c->a;
		    retstr->x = a;
		    retstr->y = a;
		    z = c->g;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 aab(this UnityEngine.Color c) => default; // 0x0000000189C2A908-0x0000000189C2A988
		// Vector3 aab(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::aab(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Vector3 *v10; // rax
		  __int64 v11; // xmm0_8
		  Vector3 v13; // [rsp+20h] [rbp-28h] BYREF
		  Color v14; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4744, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4744, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v14 = *c;
		    v10 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v13, Patch, &v14, 0LL);
		    v11 = *(_QWORD *)&v10->x;
		    z = v10->z;
		    *(_QWORD *)&retstr->x = v11;
		  }
		  else
		  {
		    a = c->a;
		    retstr->x = a;
		    retstr->y = a;
		    z = c->b;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 aaa(this UnityEngine.Color c) => default; // 0x0000000189C2A694-0x0000000189C2A710
		// Vector3 aaa(Color)
		Vector3 *HG::Rendering::Runtime::VectorSwizzleUtils::aaa(Vector3 *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float z; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Vector3 *v9; // rax
		  __int64 v10; // xmm0_8
		  Vector3 v12; // [rsp+20h] [rbp-28h] BYREF
		  Color v13; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4745, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4745, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v13 = *c;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_589(&v12, Patch, &v13, 0LL);
		    v10 = *(_QWORD *)&v9->x;
		    z = v9->z;
		    *(_QWORD *)&retstr->x = v10;
		  }
		  else
		  {
		    z = c->a;
		    retstr->x = z;
		    retstr->y = z;
		  }
		  retstr->z = z;
		  return retstr;
		}
		
		public static UnityEngine.Color rrrr(this UnityEngine.Color c) => default; // 0x0000000189C34D68-0x0000000189C34DE0
		// Color rrrr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4746, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4746, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    *(__m128 *)retstr = _mm_shuffle_ps((__m128)LODWORD(c->r), (__m128)LODWORD(c->r), 0);
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rrrg(this UnityEngine.Color c) => default; // 0x0000000189C34CEC-0x0000000189C34D68
		// Color rrrg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4747, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4747, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    r = c->r;
		    retstr->r = c->r;
		    retstr->g = r;
		    retstr->b = r;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rrrb(this UnityEngine.Color c) => default; // 0x0000000189C34C70-0x0000000189C34CEC
		// Color rrrb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4748, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4748, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    r = c->r;
		    retstr->r = c->r;
		    retstr->g = r;
		    retstr->b = r;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rrra(this UnityEngine.Color c) => default; // 0x0000000189C34BF4-0x0000000189C34C70
		// Color rrra(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4749, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4749, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    r = c->r;
		    retstr->r = c->r;
		    retstr->g = r;
		    retstr->b = r;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rrgr(this UnityEngine.Color c) => default; // 0x0000000189C34AF8-0x0000000189C34B78
		// Color rrgr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrgr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4750, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4750, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    r = c->r;
		    retstr->r = c->r;
		    retstr->g = r;
		    retstr->b = c->g;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rrgg(this UnityEngine.Color c) => default; // 0x0000000189C34A7C-0x0000000189C34AF8
		// Color rrgg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrgg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Color v11; // [rsp+20h] [rbp-28h] BYREF
		  Color v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4751, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4751, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    r = c->r;
		    retstr->r = c->r;
		    retstr->g = r;
		    g = c->g;
		    retstr->b = g;
		    retstr->a = g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rrgb(this UnityEngine.Color c) => default; // 0x0000000189C349FC-0x0000000189C34A7C
		// Color rrgb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrgb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4752, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4752, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    r = c->r;
		    retstr->r = c->r;
		    retstr->g = r;
		    retstr->b = c->g;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rrga(this UnityEngine.Color c) => default; // 0x0000000189C3497C-0x0000000189C349FC
		// Color rrga(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4753, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4753, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    r = c->r;
		    retstr->r = c->r;
		    retstr->g = r;
		    retstr->b = c->g;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rrbr(this UnityEngine.Color c) => default; // 0x0000000189C3487C-0x0000000189C348FC
		// Color rrbr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4754, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4754, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    r = c->r;
		    retstr->r = c->r;
		    retstr->g = r;
		    retstr->b = c->b;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rrbg(this UnityEngine.Color c) => default; // 0x0000000189C347FC-0x0000000189C3487C
		// Color rrbg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4755, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4755, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    r = c->r;
		    retstr->r = c->r;
		    retstr->g = r;
		    retstr->b = c->b;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rrbb(this UnityEngine.Color c) => default; // 0x0000000189C34780-0x0000000189C347FC
		// Color rrbb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Color v11; // [rsp+20h] [rbp-28h] BYREF
		  Color v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4756, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4756, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    r = c->r;
		    retstr->r = c->r;
		    retstr->g = r;
		    b = c->b;
		    retstr->b = b;
		    retstr->a = b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rrba(this UnityEngine.Color c) => default; // 0x0000000189C34700-0x0000000189C34780
		// Color rrba(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4757, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4757, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    r = c->r;
		    retstr->r = c->r;
		    retstr->g = r;
		    retstr->b = c->b;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rrar(this UnityEngine.Color c) => default; // 0x0000000189C34600-0x0000000189C34680
		// Color rrar(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4758, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4758, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    r = c->r;
		    retstr->r = c->r;
		    retstr->g = r;
		    retstr->b = c->a;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rrag(this UnityEngine.Color c) => default; // 0x0000000189C34580-0x0000000189C34600
		// Color rrag(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4759, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4759, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    r = c->r;
		    retstr->r = c->r;
		    retstr->g = r;
		    retstr->b = c->a;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rrab(this UnityEngine.Color c) => default; // 0x0000000189C34500-0x0000000189C34580
		// Color rrab(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rrab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4760, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4760, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    r = c->r;
		    retstr->r = c->r;
		    retstr->g = r;
		    retstr->b = c->a;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rraa(this UnityEngine.Color c) => default; // 0x0000000189C34484-0x0000000189C34500
		// Color rraa(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rraa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Color v11; // [rsp+20h] [rbp-28h] BYREF
		  Color v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4761, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4761, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    r = c->r;
		    retstr->r = c->r;
		    retstr->g = r;
		    a = c->a;
		    retstr->b = a;
		    retstr->a = a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rgrr(this UnityEngine.Color c) => default; // 0x0000000189C34324-0x0000000189C343A4
		// Color rgrr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4762, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4762, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->g;
		    r = c->r;
		    retstr->b = c->r;
		    retstr->a = r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rgrg(this UnityEngine.Color c) => default; // 0x0000000189C342A0-0x0000000189C34324
		// Color rgrg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4763, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4763, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->g;
		    retstr->b = c->r;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rgrb(this UnityEngine.Color c) => default; // 0x0000000189C3421C-0x0000000189C342A0
		// Color rgrb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4764, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4764, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->g;
		    retstr->b = c->r;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rgra(this UnityEngine.Color c) => default; // 0x0000000189C34198-0x0000000189C3421C
		// Color rgra(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4765, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4765, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->g;
		    retstr->b = c->r;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rggr(this UnityEngine.Color c) => default; // 0x0000000189C34098-0x0000000189C34118
		// Color rggr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rggr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4766, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4766, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    g = c->g;
		    retstr->g = g;
		    retstr->b = g;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rggg(this UnityEngine.Color c) => default; // 0x0000000189C3401C-0x0000000189C34098
		// Color rggg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rggg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4767, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4767, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    g = c->g;
		    retstr->g = g;
		    retstr->b = g;
		    retstr->a = g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rggb(this UnityEngine.Color c) => default; // 0x0000000189C33F9C-0x0000000189C3401C
		// Color rggb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rggb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4768, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4768, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    g = c->g;
		    retstr->g = g;
		    retstr->b = g;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rgga(this UnityEngine.Color c) => default; // 0x0000000189C33F1C-0x0000000189C33F9C
		// Color rgga(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4769, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4769, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    g = c->g;
		    retstr->g = g;
		    retstr->b = g;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rgbr(this UnityEngine.Color c) => default; // 0x0000000189C33E18-0x0000000189C33E9C
		// Color rgbr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4770, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4770, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->g;
		    retstr->b = c->b;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rgbg(this UnityEngine.Color c) => default; // 0x0000000189C33D94-0x0000000189C33E18
		// Color rgbg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4771, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4771, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->g;
		    retstr->b = c->b;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rgbb(this UnityEngine.Color c) => default; // 0x0000000189C33D14-0x0000000189C33D94
		// Color rgbb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4772, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4772, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->g;
		    b = c->b;
		    retstr->b = b;
		    retstr->a = b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rgba(this UnityEngine.Color c) => default; // 0x0000000189C33C90-0x0000000189C33D14
		// Color rgba(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4773, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4773, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->g;
		    retstr->b = c->b;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rgar(this UnityEngine.Color c) => default; // 0x0000000189C33B8C-0x0000000189C33C10
		// Color rgar(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4774, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4774, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->g;
		    retstr->b = c->a;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rgag(this UnityEngine.Color c) => default; // 0x0000000189C33B08-0x0000000189C33B8C
		// Color rgag(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4775, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4775, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->g;
		    retstr->b = c->a;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rgab(this UnityEngine.Color c) => default; // 0x0000000189C33A84-0x0000000189C33B08
		// Color rgab(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4776, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4776, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->g;
		    retstr->b = c->a;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rgaa(this UnityEngine.Color c) => default; // 0x0000000189C33A04-0x0000000189C33A84
		// Color rgaa(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rgaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4777, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4777, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->g;
		    a = c->a;
		    retstr->b = a;
		    retstr->a = a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rbrr(this UnityEngine.Color c) => default; // 0x0000000189C338A0-0x0000000189C33920
		// Color rbrr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4778, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4778, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->b;
		    r = c->r;
		    retstr->b = c->r;
		    retstr->a = r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rbrg(this UnityEngine.Color c) => default; // 0x0000000189C3381C-0x0000000189C338A0
		// Color rbrg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4779, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4779, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->b;
		    retstr->b = c->r;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rbrb(this UnityEngine.Color c) => default; // 0x0000000189C33798-0x0000000189C3381C
		// Color rbrb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4780, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4780, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->b;
		    retstr->b = c->r;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rbra(this UnityEngine.Color c) => default; // 0x0000000189C33714-0x0000000189C33798
		// Color rbra(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4781, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4781, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->b;
		    retstr->b = c->r;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rbgr(this UnityEngine.Color c) => default; // 0x0000000189C33610-0x0000000189C33694
		// Color rbgr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbgr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4782, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4782, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->b;
		    retstr->b = c->g;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rbgg(this UnityEngine.Color c) => default; // 0x0000000189C33590-0x0000000189C33610
		// Color rbgg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbgg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4783, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4783, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->b;
		    g = c->g;
		    retstr->b = g;
		    retstr->a = g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rbgb(this UnityEngine.Color c) => default; // 0x0000000189C3350C-0x0000000189C33590
		// Color rbgb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbgb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4784, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4784, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->b;
		    retstr->b = c->g;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rbga(this UnityEngine.Color c) => default; // 0x0000000189C33488-0x0000000189C3350C
		// Color rbga(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4785, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4785, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->b;
		    retstr->b = c->g;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rbbr(this UnityEngine.Color c) => default; // 0x0000000189C33388-0x0000000189C33408
		// Color rbbr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4786, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4786, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    b = c->b;
		    retstr->g = b;
		    retstr->b = b;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rbbg(this UnityEngine.Color c) => default; // 0x0000000189C33308-0x0000000189C33388
		// Color rbbg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4787, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4787, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    b = c->b;
		    retstr->g = b;
		    retstr->b = b;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rbbb(this UnityEngine.Color c) => default; // 0x0000000189C3328C-0x0000000189C33308
		// Color rbbb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4788, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4788, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    b = c->b;
		    retstr->g = b;
		    retstr->b = b;
		    retstr->a = b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rbba(this UnityEngine.Color c) => default; // 0x0000000189C3320C-0x0000000189C3328C
		// Color rbba(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4789, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4789, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    b = c->b;
		    retstr->g = b;
		    retstr->b = b;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rbar(this UnityEngine.Color c) => default; // 0x0000000189C33108-0x0000000189C3318C
		// Color rbar(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4790, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4790, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->b;
		    retstr->b = c->a;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rbag(this UnityEngine.Color c) => default; // 0x0000000189C33084-0x0000000189C33108
		// Color rbag(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4791, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4791, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->b;
		    retstr->b = c->a;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rbab(this UnityEngine.Color c) => default; // 0x0000000189C33000-0x0000000189C33084
		// Color rbab(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4792, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4792, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->b;
		    retstr->b = c->a;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rbaa(this UnityEngine.Color c) => default; // 0x0000000189C32F80-0x0000000189C33000
		// Color rbaa(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rbaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4793, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4793, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->b;
		    a = c->a;
		    retstr->b = a;
		    retstr->a = a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rarr(this UnityEngine.Color c) => default; // 0x0000000189C32E1C-0x0000000189C32E9C
		// Color rarr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rarr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4794, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4794, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->a;
		    r = c->r;
		    retstr->b = c->r;
		    retstr->a = r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rarg(this UnityEngine.Color c) => default; // 0x0000000189C32D98-0x0000000189C32E1C
		// Color rarg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rarg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4795, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4795, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->a;
		    retstr->b = c->r;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rarb(this UnityEngine.Color c) => default; // 0x0000000189C32D14-0x0000000189C32D98
		// Color rarb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rarb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4796, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4796, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->a;
		    retstr->b = c->r;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rara(this UnityEngine.Color c) => default; // 0x0000000189C32C90-0x0000000189C32D14
		// Color rara(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rara(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4797, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4797, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->a;
		    retstr->b = c->r;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color ragr(this UnityEngine.Color c) => default; // 0x0000000189C32B8C-0x0000000189C32C10
		// Color ragr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::ragr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4798, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4798, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->a;
		    retstr->b = c->g;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color ragg(this UnityEngine.Color c) => default; // 0x0000000189C32B0C-0x0000000189C32B8C
		// Color ragg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::ragg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4799, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4799, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->a;
		    g = c->g;
		    retstr->b = g;
		    retstr->a = g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color ragb(this UnityEngine.Color c) => default; // 0x0000000189C32A88-0x0000000189C32B0C
		// Color ragb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::ragb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4800, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4800, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->a;
		    retstr->b = c->g;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color raga(this UnityEngine.Color c) => default; // 0x0000000189C32A04-0x0000000189C32A88
		// Color raga(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::raga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4801, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4801, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->a;
		    retstr->b = c->g;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rabr(this UnityEngine.Color c) => default; // 0x0000000189C32900-0x0000000189C32984
		// Color rabr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rabr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4802, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4802, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->a;
		    retstr->b = c->b;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rabg(this UnityEngine.Color c) => default; // 0x0000000189C3287C-0x0000000189C32900
		// Color rabg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rabg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4803, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4803, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->a;
		    retstr->b = c->b;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color rabb(this UnityEngine.Color c) => default; // 0x0000000189C327FC-0x0000000189C3287C
		// Color rabb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::rabb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4804, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4804, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->a;
		    b = c->b;
		    retstr->b = b;
		    retstr->a = b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color raba(this UnityEngine.Color c) => default; // 0x0000000189C32778-0x0000000189C327FC
		// Color raba(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::raba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4805, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4805, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    retstr->g = c->a;
		    retstr->b = c->b;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color raar(this UnityEngine.Color c) => default; // 0x0000000189C32678-0x0000000189C326F8
		// Color raar(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::raar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4806, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4806, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    a = c->a;
		    retstr->g = a;
		    retstr->b = a;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color raag(this UnityEngine.Color c) => default; // 0x0000000189C325F8-0x0000000189C32678
		// Color raag(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::raag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4807, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4807, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    a = c->a;
		    retstr->g = a;
		    retstr->b = a;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color raab(this UnityEngine.Color c) => default; // 0x0000000189C32578-0x0000000189C325F8
		// Color raab(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::raab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4808, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4808, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    a = c->a;
		    retstr->g = a;
		    retstr->b = a;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color raaa(this UnityEngine.Color c) => default; // 0x0000000189C324FC-0x0000000189C32578
		// Color raaa(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::raaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4809, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4809, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->r;
		    a = c->a;
		    retstr->g = a;
		    retstr->b = a;
		    retstr->a = a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color grrr(this UnityEngine.Color c) => default; // 0x0000000189C3239C-0x0000000189C32418
		// Color grrr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::grrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4810, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4810, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    r = c->r;
		    retstr->g = c->r;
		    retstr->b = r;
		    retstr->a = r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color grrg(this UnityEngine.Color c) => default; // 0x0000000189C3231C-0x0000000189C3239C
		// Color grrg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::grrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4811, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4811, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    r = c->r;
		    retstr->g = c->r;
		    retstr->b = r;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color grrb(this UnityEngine.Color c) => default; // 0x0000000189C3229C-0x0000000189C3231C
		// Color grrb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::grrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4812, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4812, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    r = c->r;
		    retstr->g = c->r;
		    retstr->b = r;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color grra(this UnityEngine.Color c) => default; // 0x0000000189C3221C-0x0000000189C3229C
		// Color grra(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::grra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4813, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4813, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    r = c->r;
		    retstr->g = c->r;
		    retstr->b = r;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color grgr(this UnityEngine.Color c) => default; // 0x0000000189C32118-0x0000000189C3219C
		// Color grgr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::grgr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4814, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4814, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->r;
		    retstr->b = c->g;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color grgg(this UnityEngine.Color c) => default; // 0x0000000189C32098-0x0000000189C32118
		// Color grgg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::grgg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4815, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4815, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->r;
		    g = c->g;
		    retstr->b = g;
		    retstr->a = g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color grgb(this UnityEngine.Color c) => default; // 0x0000000189C32014-0x0000000189C32098
		// Color grgb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::grgb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4816, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4816, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->r;
		    retstr->b = c->g;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color grga(this UnityEngine.Color c) => default; // 0x0000000189C31F90-0x0000000189C32014
		// Color grga(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::grga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4817, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4817, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->r;
		    retstr->b = c->g;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color grbr(this UnityEngine.Color c) => default; // 0x0000000189C31E8C-0x0000000189C31F10
		// Color grbr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::grbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4818, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4818, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->r;
		    retstr->b = c->b;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color grbg(this UnityEngine.Color c) => default; // 0x0000000189C31E08-0x0000000189C31E8C
		// Color grbg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::grbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4819, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4819, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->r;
		    retstr->b = c->b;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color grbb(this UnityEngine.Color c) => default; // 0x0000000189C31D88-0x0000000189C31E08
		// Color grbb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::grbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4820, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4820, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->r;
		    b = c->b;
		    retstr->b = b;
		    retstr->a = b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color grba(this UnityEngine.Color c) => default; // 0x0000000189C31D04-0x0000000189C31D88
		// Color grba(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::grba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4821, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4821, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->r;
		    retstr->b = c->b;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color grar(this UnityEngine.Color c) => default; // 0x0000000189C31C00-0x0000000189C31C84
		// Color grar(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::grar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4822, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4822, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->r;
		    retstr->b = c->a;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color grag(this UnityEngine.Color c) => default; // 0x0000000189C31B7C-0x0000000189C31C00
		// Color grag(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::grag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4823, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4823, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->r;
		    retstr->b = c->a;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color grab(this UnityEngine.Color c) => default; // 0x0000000189C31AF8-0x0000000189C31B7C
		// Color grab(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::grab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4824, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4824, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->r;
		    retstr->b = c->a;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color graa(this UnityEngine.Color c) => default; // 0x0000000189C31A78-0x0000000189C31AF8
		// Color graa(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::graa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4825, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4825, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->r;
		    a = c->a;
		    retstr->b = a;
		    retstr->a = a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color ggrr(this UnityEngine.Color c) => default; // 0x0000000189C31918-0x0000000189C31994
		// Color ggrr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Color v11; // [rsp+20h] [rbp-28h] BYREF
		  Color v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4826, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4826, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    g = c->g;
		    retstr->r = g;
		    retstr->g = g;
		    r = c->r;
		    retstr->b = c->r;
		    retstr->a = r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color ggrg(this UnityEngine.Color c) => default; // 0x0000000189C31898-0x0000000189C31918
		// Color ggrg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4827, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4827, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    g = c->g;
		    retstr->r = g;
		    retstr->g = g;
		    retstr->b = c->r;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color ggrb(this UnityEngine.Color c) => default; // 0x0000000189C31818-0x0000000189C31898
		// Color ggrb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4828, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4828, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    g = c->g;
		    retstr->r = g;
		    retstr->g = g;
		    retstr->b = c->r;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color ggra(this UnityEngine.Color c) => default; // 0x0000000189C31798-0x0000000189C31818
		// Color ggra(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4829, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4829, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    g = c->g;
		    retstr->r = g;
		    retstr->g = g;
		    retstr->b = c->r;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gggr(this UnityEngine.Color c) => default; // 0x0000000189C3169C-0x0000000189C31718
		// Color gggr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gggr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4830, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4830, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    g = c->g;
		    retstr->r = g;
		    retstr->g = g;
		    retstr->b = g;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gggg(this UnityEngine.Color c) => default; // 0x0000000189C31620-0x0000000189C3169C
		// Color gggg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gggg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4831, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4831, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    g = c->g;
		    retstr->r = g;
		    retstr->g = g;
		    retstr->b = g;
		    retstr->a = g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gggb(this UnityEngine.Color c) => default; // 0x0000000189C315A0-0x0000000189C31620
		// Color gggb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gggb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4832, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4832, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    g = c->g;
		    retstr->r = g;
		    retstr->g = g;
		    retstr->b = g;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color ggga(this UnityEngine.Color c) => default; // 0x0000000189C31520-0x0000000189C315A0
		// Color ggga(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4833, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4833, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    g = c->g;
		    retstr->r = g;
		    retstr->g = g;
		    retstr->b = g;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color ggbr(this UnityEngine.Color c) => default; // 0x0000000189C31424-0x0000000189C314A4
		// Color ggbr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4834, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4834, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    g = c->g;
		    retstr->r = g;
		    retstr->g = g;
		    retstr->b = c->b;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color ggbg(this UnityEngine.Color c) => default; // 0x0000000189C313A4-0x0000000189C31424
		// Color ggbg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4835, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4835, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    g = c->g;
		    retstr->r = g;
		    retstr->g = g;
		    retstr->b = c->b;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color ggbb(this UnityEngine.Color c) => default; // 0x0000000189C31324-0x0000000189C313A4
		// Color ggbb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Color v11; // [rsp+20h] [rbp-28h] BYREF
		  Color v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4836, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4836, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    g = c->g;
		    retstr->r = g;
		    retstr->g = g;
		    b = c->b;
		    retstr->b = b;
		    retstr->a = b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color ggba(this UnityEngine.Color c) => default; // 0x0000000189C312A4-0x0000000189C31324
		// Color ggba(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4837, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4837, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    g = c->g;
		    retstr->r = g;
		    retstr->g = g;
		    retstr->b = c->b;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color ggar(this UnityEngine.Color c) => default; // 0x0000000189C311A4-0x0000000189C31224
		// Color ggar(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4838, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4838, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    g = c->g;
		    retstr->r = g;
		    retstr->g = g;
		    retstr->b = c->a;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color ggag(this UnityEngine.Color c) => default; // 0x0000000189C31124-0x0000000189C311A4
		// Color ggag(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4839, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4839, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    g = c->g;
		    retstr->r = g;
		    retstr->g = g;
		    retstr->b = c->a;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color ggab(this UnityEngine.Color c) => default; // 0x0000000189C310A4-0x0000000189C31124
		// Color ggab(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4840, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4840, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    g = c->g;
		    retstr->r = g;
		    retstr->g = g;
		    retstr->b = c->a;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color ggaa(this UnityEngine.Color c) => default; // 0x0000000189C31024-0x0000000189C310A4
		// Color ggaa(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::ggaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Color v11; // [rsp+20h] [rbp-28h] BYREF
		  Color v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4841, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4841, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    g = c->g;
		    retstr->r = g;
		    retstr->g = g;
		    a = c->a;
		    retstr->b = a;
		    retstr->a = a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gbrr(this UnityEngine.Color c) => default; // 0x0000000189C30EC0-0x0000000189C30F40
		// Color gbrr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4842, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4842, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->b;
		    r = c->r;
		    retstr->b = c->r;
		    retstr->a = r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gbrg(this UnityEngine.Color c) => default; // 0x0000000189C30E3C-0x0000000189C30EC0
		// Color gbrg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4843, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4843, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->b;
		    retstr->b = c->r;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gbrb(this UnityEngine.Color c) => default; // 0x0000000189C30DB8-0x0000000189C30E3C
		// Color gbrb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4844, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4844, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->b;
		    retstr->b = c->r;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gbra(this UnityEngine.Color c) => default; // 0x0000000189C30D34-0x0000000189C30DB8
		// Color gbra(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4845, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4845, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->b;
		    retstr->b = c->r;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gbgr(this UnityEngine.Color c) => default; // 0x0000000189C30C30-0x0000000189C30CB4
		// Color gbgr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbgr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4846, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4846, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->b;
		    retstr->b = c->g;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gbgg(this UnityEngine.Color c) => default; // 0x0000000189C30BB0-0x0000000189C30C30
		// Color gbgg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbgg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4847, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4847, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->b;
		    g = c->g;
		    retstr->b = g;
		    retstr->a = g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gbgb(this UnityEngine.Color c) => default; // 0x0000000189C30B2C-0x0000000189C30BB0
		// Color gbgb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbgb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4848, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4848, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->b;
		    retstr->b = c->g;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gbga(this UnityEngine.Color c) => default; // 0x0000000189C30AA8-0x0000000189C30B2C
		// Color gbga(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4849, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4849, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->b;
		    retstr->b = c->g;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gbbr(this UnityEngine.Color c) => default; // 0x0000000189C309A4-0x0000000189C30A24
		// Color gbbr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4850, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4850, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    b = c->b;
		    retstr->g = b;
		    retstr->b = b;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gbbg(this UnityEngine.Color c) => default; // 0x0000000189C30924-0x0000000189C309A4
		// Color gbbg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4851, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4851, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    b = c->b;
		    retstr->g = b;
		    retstr->b = b;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gbbb(this UnityEngine.Color c) => default; // 0x0000000189C308A4-0x0000000189C30924
		// Color gbbb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4852, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4852, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    b = c->b;
		    retstr->g = b;
		    retstr->b = b;
		    retstr->a = b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gbba(this UnityEngine.Color c) => default; // 0x0000000189C30824-0x0000000189C308A4
		// Color gbba(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4853, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4853, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    b = c->b;
		    retstr->g = b;
		    retstr->b = b;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gbar(this UnityEngine.Color c) => default; // 0x0000000189C30720-0x0000000189C307A4
		// Color gbar(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4854, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4854, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->b;
		    retstr->b = c->a;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gbag(this UnityEngine.Color c) => default; // 0x0000000189C3069C-0x0000000189C30720
		// Color gbag(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4855, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4855, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->b;
		    retstr->b = c->a;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gbab(this UnityEngine.Color c) => default; // 0x0000000189C30618-0x0000000189C3069C
		// Color gbab(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4856, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4856, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->b;
		    retstr->b = c->a;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gbaa(this UnityEngine.Color c) => default; // 0x0000000189C30598-0x0000000189C30618
		// Color gbaa(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gbaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4857, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4857, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->b;
		    a = c->a;
		    retstr->b = a;
		    retstr->a = a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color garr(this UnityEngine.Color c) => default; // 0x0000000189C30430-0x0000000189C304B0
		// Color garr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::garr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4858, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4858, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->a;
		    r = c->r;
		    retstr->b = c->r;
		    retstr->a = r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color garg(this UnityEngine.Color c) => default; // 0x0000000189C303AC-0x0000000189C30430
		// Color garg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::garg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4859, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4859, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->a;
		    retstr->b = c->r;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color garb(this UnityEngine.Color c) => default; // 0x0000000189C30328-0x0000000189C303AC
		// Color garb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::garb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4860, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4860, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->a;
		    retstr->b = c->r;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gara(this UnityEngine.Color c) => default; // 0x0000000189C302A4-0x0000000189C30328
		// Color gara(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gara(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4861, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4861, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->a;
		    retstr->b = c->r;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gagr(this UnityEngine.Color c) => default; // 0x0000000189C301A0-0x0000000189C30224
		// Color gagr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gagr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4862, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4862, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->a;
		    retstr->b = c->g;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gagg(this UnityEngine.Color c) => default; // 0x0000000189C30120-0x0000000189C301A0
		// Color gagg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gagg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4863, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4863, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->a;
		    g = c->g;
		    retstr->b = g;
		    retstr->a = g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gagb(this UnityEngine.Color c) => default; // 0x0000000189C3009C-0x0000000189C30120
		// Color gagb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gagb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4864, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4864, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->a;
		    retstr->b = c->g;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gaga(this UnityEngine.Color c) => default; // 0x0000000189C30018-0x0000000189C3009C
		// Color gaga(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gaga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4865, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4865, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->a;
		    retstr->b = c->g;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gabr(this UnityEngine.Color c) => default; // 0x0000000189C2FF10-0x0000000189C2FF94
		// Color gabr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gabr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4866, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4866, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->a;
		    retstr->b = c->b;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gabg(this UnityEngine.Color c) => default; // 0x0000000189C2FE8C-0x0000000189C2FF10
		// Color gabg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gabg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4867, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4867, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->a;
		    retstr->b = c->b;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gabb(this UnityEngine.Color c) => default; // 0x0000000189C2FE0C-0x0000000189C2FE8C
		// Color gabb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gabb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4868, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4868, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->a;
		    b = c->b;
		    retstr->b = b;
		    retstr->a = b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gaba(this UnityEngine.Color c) => default; // 0x0000000189C2FD88-0x0000000189C2FE0C
		// Color gaba(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gaba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4869, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4869, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    retstr->g = c->a;
		    retstr->b = c->b;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gaar(this UnityEngine.Color c) => default; // 0x0000000189C2FC84-0x0000000189C2FD04
		// Color gaar(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gaar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4870, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4870, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    a = c->a;
		    retstr->g = a;
		    retstr->b = a;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gaag(this UnityEngine.Color c) => default; // 0x0000000189C2FC04-0x0000000189C2FC84
		// Color gaag(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gaag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4871, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4871, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    a = c->a;
		    retstr->g = a;
		    retstr->b = a;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gaab(this UnityEngine.Color c) => default; // 0x0000000189C2FB84-0x0000000189C2FC04
		// Color gaab(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gaab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4872, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4872, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    a = c->a;
		    retstr->g = a;
		    retstr->b = a;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color gaaa(this UnityEngine.Color c) => default; // 0x0000000189C2FB04-0x0000000189C2FB84
		// Color gaaa(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::gaaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4873, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4873, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->g;
		    a = c->a;
		    retstr->g = a;
		    retstr->b = a;
		    retstr->a = a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color brrr(this UnityEngine.Color c) => default; // 0x0000000189C2F9A4-0x0000000189C2FA20
		// Color brrr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::brrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4874, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4874, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    r = c->r;
		    retstr->g = c->r;
		    retstr->b = r;
		    retstr->a = r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color brrg(this UnityEngine.Color c) => default; // 0x0000000189C2F924-0x0000000189C2F9A4
		// Color brrg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::brrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4875, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4875, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    r = c->r;
		    retstr->g = c->r;
		    retstr->b = r;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color brrb(this UnityEngine.Color c) => default; // 0x0000000189C2F8A4-0x0000000189C2F924
		// Color brrb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::brrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4876, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4876, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    r = c->r;
		    retstr->g = c->r;
		    retstr->b = r;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color brra(this UnityEngine.Color c) => default; // 0x0000000189C2F824-0x0000000189C2F8A4
		// Color brra(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::brra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4877, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4877, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    r = c->r;
		    retstr->g = c->r;
		    retstr->b = r;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color brgr(this UnityEngine.Color c) => default; // 0x0000000189C2F720-0x0000000189C2F7A4
		// Color brgr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::brgr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4878, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4878, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->r;
		    retstr->b = c->g;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color brgg(this UnityEngine.Color c) => default; // 0x0000000189C2F6A0-0x0000000189C2F720
		// Color brgg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::brgg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4879, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4879, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->r;
		    g = c->g;
		    retstr->b = g;
		    retstr->a = g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color brgb(this UnityEngine.Color c) => default; // 0x0000000189C2F61C-0x0000000189C2F6A0
		// Color brgb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::brgb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4880, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4880, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->r;
		    retstr->b = c->g;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color brga(this UnityEngine.Color c) => default; // 0x0000000189C2F598-0x0000000189C2F61C
		// Color brga(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::brga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4881, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4881, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->r;
		    retstr->b = c->g;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color brbr(this UnityEngine.Color c) => default; // 0x0000000189C2F494-0x0000000189C2F518
		// Color brbr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::brbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4882, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4882, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->r;
		    retstr->b = c->b;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color brbg(this UnityEngine.Color c) => default; // 0x0000000189C2F410-0x0000000189C2F494
		// Color brbg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::brbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4883, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4883, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->r;
		    retstr->b = c->b;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color brbb(this UnityEngine.Color c) => default; // 0x0000000189C2F390-0x0000000189C2F410
		// Color brbb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::brbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4884, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4884, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->r;
		    b = c->b;
		    retstr->b = b;
		    retstr->a = b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color brba(this UnityEngine.Color c) => default; // 0x0000000189C2F30C-0x0000000189C2F390
		// Color brba(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::brba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4885, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4885, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->r;
		    retstr->b = c->b;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color brar(this UnityEngine.Color c) => default; // 0x0000000189C2F208-0x0000000189C2F28C
		// Color brar(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::brar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4886, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4886, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->r;
		    retstr->b = c->a;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color brag(this UnityEngine.Color c) => default; // 0x0000000189C2F184-0x0000000189C2F208
		// Color brag(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::brag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4887, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4887, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->r;
		    retstr->b = c->a;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color brab(this UnityEngine.Color c) => default; // 0x0000000189C2F100-0x0000000189C2F184
		// Color brab(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::brab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4888, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4888, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->r;
		    retstr->b = c->a;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color braa(this UnityEngine.Color c) => default; // 0x0000000189C2F080-0x0000000189C2F100
		// Color braa(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::braa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4889, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4889, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->r;
		    a = c->a;
		    retstr->b = a;
		    retstr->a = a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bgrr(this UnityEngine.Color c) => default; // 0x0000000189C2EF1C-0x0000000189C2EF9C
		// Color bgrr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4890, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4890, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->g;
		    r = c->r;
		    retstr->b = c->r;
		    retstr->a = r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bgrg(this UnityEngine.Color c) => default; // 0x0000000189C2EE98-0x0000000189C2EF1C
		// Color bgrg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4891, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4891, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->g;
		    retstr->b = c->r;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bgrb(this UnityEngine.Color c) => default; // 0x0000000189C2EE14-0x0000000189C2EE98
		// Color bgrb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4892, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4892, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->g;
		    retstr->b = c->r;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bgra(this UnityEngine.Color c) => default; // 0x0000000189C2ED90-0x0000000189C2EE14
		// Color bgra(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4893, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4893, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->g;
		    retstr->b = c->r;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bggr(this UnityEngine.Color c) => default; // 0x0000000189C2EC90-0x0000000189C2ED10
		// Color bggr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bggr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4894, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4894, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    g = c->g;
		    retstr->g = g;
		    retstr->b = g;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bggg(this UnityEngine.Color c) => default; // 0x0000000189C2EC10-0x0000000189C2EC90
		// Color bggg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bggg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4895, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4895, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    g = c->g;
		    retstr->g = g;
		    retstr->b = g;
		    retstr->a = g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bggb(this UnityEngine.Color c) => default; // 0x0000000189C2EB90-0x0000000189C2EC10
		// Color bggb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bggb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4896, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4896, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    g = c->g;
		    retstr->g = g;
		    retstr->b = g;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bgga(this UnityEngine.Color c) => default; // 0x0000000189C2EB10-0x0000000189C2EB90
		// Color bgga(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4897, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4897, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    g = c->g;
		    retstr->g = g;
		    retstr->b = g;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bgbr(this UnityEngine.Color c) => default; // 0x0000000189C2EA0C-0x0000000189C2EA90
		// Color bgbr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4898, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4898, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->g;
		    retstr->b = c->b;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bgbg(this UnityEngine.Color c) => default; // 0x0000000189C2E988-0x0000000189C2EA0C
		// Color bgbg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4899, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4899, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->g;
		    retstr->b = c->b;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bgbb(this UnityEngine.Color c) => default; // 0x0000000189C2E908-0x0000000189C2E988
		// Color bgbb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4900, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4900, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->g;
		    b = c->b;
		    retstr->b = b;
		    retstr->a = b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bgba(this UnityEngine.Color c) => default; // 0x0000000189C2E884-0x0000000189C2E908
		// Color bgba(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4901, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4901, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->g;
		    retstr->b = c->b;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bgar(this UnityEngine.Color c) => default; // 0x0000000189C2E77C-0x0000000189C2E800
		// Color bgar(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4902, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4902, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->g;
		    retstr->b = c->a;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bgag(this UnityEngine.Color c) => default; // 0x0000000189C2E6F8-0x0000000189C2E77C
		// Color bgag(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4903, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4903, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->g;
		    retstr->b = c->a;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bgab(this UnityEngine.Color c) => default; // 0x0000000189C2E674-0x0000000189C2E6F8
		// Color bgab(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4904, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4904, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->g;
		    retstr->b = c->a;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bgaa(this UnityEngine.Color c) => default; // 0x0000000189C2E5F4-0x0000000189C2E674
		// Color bgaa(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bgaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4905, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4905, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->g;
		    a = c->a;
		    retstr->b = a;
		    retstr->a = a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bbrr(this UnityEngine.Color c) => default; // 0x0000000189C2E490-0x0000000189C2E50C
		// Color bbrr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Color v11; // [rsp+20h] [rbp-28h] BYREF
		  Color v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4906, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4906, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    b = c->b;
		    retstr->r = b;
		    retstr->g = b;
		    r = c->r;
		    retstr->b = c->r;
		    retstr->a = r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bbrg(this UnityEngine.Color c) => default; // 0x0000000189C2E410-0x0000000189C2E490
		// Color bbrg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4907, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4907, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    b = c->b;
		    retstr->r = b;
		    retstr->g = b;
		    retstr->b = c->r;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bbrb(this UnityEngine.Color c) => default; // 0x0000000189C2E390-0x0000000189C2E410
		// Color bbrb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4908, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4908, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    b = c->b;
		    retstr->r = b;
		    retstr->g = b;
		    retstr->b = c->r;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bbra(this UnityEngine.Color c) => default; // 0x0000000189C2E310-0x0000000189C2E390
		// Color bbra(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4909, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4909, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    b = c->b;
		    retstr->r = b;
		    retstr->g = b;
		    retstr->b = c->r;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bbgr(this UnityEngine.Color c) => default; // 0x0000000189C2E210-0x0000000189C2E290
		// Color bbgr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbgr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4910, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4910, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    b = c->b;
		    retstr->r = b;
		    retstr->g = b;
		    retstr->b = c->g;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bbgg(this UnityEngine.Color c) => default; // 0x0000000189C2E190-0x0000000189C2E210
		// Color bbgg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbgg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Color v11; // [rsp+20h] [rbp-28h] BYREF
		  Color v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4911, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4911, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    b = c->b;
		    retstr->r = b;
		    retstr->g = b;
		    g = c->g;
		    retstr->b = g;
		    retstr->a = g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bbgb(this UnityEngine.Color c) => default; // 0x0000000189C2E110-0x0000000189C2E190
		// Color bbgb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbgb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4912, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4912, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    b = c->b;
		    retstr->r = b;
		    retstr->g = b;
		    retstr->b = c->g;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bbga(this UnityEngine.Color c) => default; // 0x0000000189C2E090-0x0000000189C2E110
		// Color bbga(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4913, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4913, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    b = c->b;
		    retstr->r = b;
		    retstr->g = b;
		    retstr->b = c->g;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bbbr(this UnityEngine.Color c) => default; // 0x0000000189C2DF94-0x0000000189C2E010
		// Color bbbr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4914, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4914, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    b = c->b;
		    retstr->r = b;
		    retstr->g = b;
		    retstr->b = b;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bbbg(this UnityEngine.Color c) => default; // 0x0000000189C2DF14-0x0000000189C2DF94
		// Color bbbg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4915, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4915, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    b = c->b;
		    retstr->r = b;
		    retstr->g = b;
		    retstr->b = b;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bbbb(this UnityEngine.Color c) => default; // 0x0000000189C2DE98-0x0000000189C2DF14
		// Color bbbb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4916, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4916, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    b = c->b;
		    retstr->r = b;
		    retstr->g = b;
		    retstr->b = b;
		    retstr->a = b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bbba(this UnityEngine.Color c) => default; // 0x0000000189C2DE18-0x0000000189C2DE98
		// Color bbba(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4917, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4917, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    b = c->b;
		    retstr->r = b;
		    retstr->g = b;
		    retstr->b = b;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bbar(this UnityEngine.Color c) => default; // 0x0000000189C2DD1C-0x0000000189C2DD9C
		// Color bbar(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4918, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4918, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    b = c->b;
		    retstr->r = b;
		    retstr->g = b;
		    retstr->b = c->a;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bbag(this UnityEngine.Color c) => default; // 0x0000000189C2DC9C-0x0000000189C2DD1C
		// Color bbag(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4919, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4919, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    b = c->b;
		    retstr->r = b;
		    retstr->g = b;
		    retstr->b = c->a;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bbab(this UnityEngine.Color c) => default; // 0x0000000189C2DC1C-0x0000000189C2DC9C
		// Color bbab(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4920, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4920, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    b = c->b;
		    retstr->r = b;
		    retstr->g = b;
		    retstr->b = c->a;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bbaa(this UnityEngine.Color c) => default; // 0x0000000189C2DB9C-0x0000000189C2DC1C
		// Color bbaa(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bbaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Color v11; // [rsp+20h] [rbp-28h] BYREF
		  Color v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4921, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4921, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    b = c->b;
		    retstr->r = b;
		    retstr->g = b;
		    a = c->a;
		    retstr->b = a;
		    retstr->a = a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color barr(this UnityEngine.Color c) => default; // 0x0000000189C2DA38-0x0000000189C2DAB8
		// Color barr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::barr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4922, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4922, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->a;
		    r = c->r;
		    retstr->b = c->r;
		    retstr->a = r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color barg(this UnityEngine.Color c) => default; // 0x0000000189C2D9B4-0x0000000189C2DA38
		// Color barg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::barg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4923, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4923, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->a;
		    retstr->b = c->r;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color barb(this UnityEngine.Color c) => default; // 0x0000000189C2D930-0x0000000189C2D9B4
		// Color barb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::barb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4924, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4924, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->a;
		    retstr->b = c->r;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bara(this UnityEngine.Color c) => default; // 0x0000000189C2D8AC-0x0000000189C2D930
		// Color bara(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bara(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4925, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4925, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->a;
		    retstr->b = c->r;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bagr(this UnityEngine.Color c) => default; // 0x0000000189C2D7A8-0x0000000189C2D82C
		// Color bagr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bagr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4926, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4926, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->a;
		    retstr->b = c->g;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bagg(this UnityEngine.Color c) => default; // 0x0000000189C2D728-0x0000000189C2D7A8
		// Color bagg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bagg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4927, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4927, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->a;
		    g = c->g;
		    retstr->b = g;
		    retstr->a = g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color bagb(this UnityEngine.Color c) => default; // 0x0000000189C2D6A4-0x0000000189C2D728
		// Color bagb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::bagb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4928, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4928, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->a;
		    retstr->b = c->g;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color baga(this UnityEngine.Color c) => default; // 0x0000000189C2D620-0x0000000189C2D6A4
		// Color baga(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::baga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4929, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4929, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->a;
		    retstr->b = c->g;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color babr(this UnityEngine.Color c) => default; // 0x0000000189C2D518-0x0000000189C2D59C
		// Color babr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::babr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4930, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4930, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->a;
		    retstr->b = c->b;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color babg(this UnityEngine.Color c) => default; // 0x0000000189C2D494-0x0000000189C2D518
		// Color babg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::babg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4931, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4931, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->a;
		    retstr->b = c->b;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color babb(this UnityEngine.Color c) => default; // 0x0000000189C2D414-0x0000000189C2D494
		// Color babb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::babb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4932, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4932, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->a;
		    b = c->b;
		    retstr->b = b;
		    retstr->a = b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color baba(this UnityEngine.Color c) => default; // 0x0000000189C2D390-0x0000000189C2D414
		// Color baba(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::baba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4933, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4933, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    retstr->g = c->a;
		    retstr->b = c->b;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color baar(this UnityEngine.Color c) => default; // 0x0000000189C2D28C-0x0000000189C2D30C
		// Color baar(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::baar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4934, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4934, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    a = c->a;
		    retstr->g = a;
		    retstr->b = a;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color baag(this UnityEngine.Color c) => default; // 0x0000000189C2D20C-0x0000000189C2D28C
		// Color baag(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::baag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4935, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4935, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    a = c->a;
		    retstr->g = a;
		    retstr->b = a;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color baab(this UnityEngine.Color c) => default; // 0x0000000189C2D18C-0x0000000189C2D20C
		// Color baab(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::baab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4936, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4936, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    a = c->a;
		    retstr->g = a;
		    retstr->b = a;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color baaa(this UnityEngine.Color c) => default; // 0x0000000189C2D10C-0x0000000189C2D18C
		// Color baaa(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::baaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4937, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4937, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->b;
		    a = c->a;
		    retstr->g = a;
		    retstr->b = a;
		    retstr->a = a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color arrr(this UnityEngine.Color c) => default; // 0x0000000189C2CFAC-0x0000000189C2D028
		// Color arrr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::arrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4938, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4938, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    r = c->r;
		    retstr->g = c->r;
		    retstr->b = r;
		    retstr->a = r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color arrg(this UnityEngine.Color c) => default; // 0x0000000189C2CF2C-0x0000000189C2CFAC
		// Color arrg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::arrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4939, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4939, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    r = c->r;
		    retstr->g = c->r;
		    retstr->b = r;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color arrb(this UnityEngine.Color c) => default; // 0x0000000189C2CEAC-0x0000000189C2CF2C
		// Color arrb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::arrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4940, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4940, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    r = c->r;
		    retstr->g = c->r;
		    retstr->b = r;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color arra(this UnityEngine.Color c) => default; // 0x0000000189C2CE2C-0x0000000189C2CEAC
		// Color arra(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::arra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4941, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4941, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    r = c->r;
		    retstr->g = c->r;
		    retstr->b = r;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color argr(this UnityEngine.Color c) => default; // 0x0000000189C2CD28-0x0000000189C2CDAC
		// Color argr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::argr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4942, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4942, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->r;
		    retstr->b = c->g;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color argg(this UnityEngine.Color c) => default; // 0x0000000189C2CCA8-0x0000000189C2CD28
		// Color argg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::argg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4943, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4943, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->r;
		    g = c->g;
		    retstr->b = g;
		    retstr->a = g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color argb(this UnityEngine.Color c) => default; // 0x0000000189C2CC24-0x0000000189C2CCA8
		// Color argb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::argb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4944, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4944, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->r;
		    retstr->b = c->g;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color arga(this UnityEngine.Color c) => default; // 0x0000000189C2CBA0-0x0000000189C2CC24
		// Color arga(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::arga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4945, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4945, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->r;
		    retstr->b = c->g;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color arbr(this UnityEngine.Color c) => default; // 0x0000000189C2CA9C-0x0000000189C2CB20
		// Color arbr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::arbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4946, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4946, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->r;
		    retstr->b = c->b;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color arbg(this UnityEngine.Color c) => default; // 0x0000000189C2CA18-0x0000000189C2CA9C
		// Color arbg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::arbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4947, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4947, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->r;
		    retstr->b = c->b;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color arbb(this UnityEngine.Color c) => default; // 0x0000000189C2C998-0x0000000189C2CA18
		// Color arbb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::arbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4948, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4948, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->r;
		    b = c->b;
		    retstr->b = b;
		    retstr->a = b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color arba(this UnityEngine.Color c) => default; // 0x0000000189C2C914-0x0000000189C2C998
		// Color arba(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::arba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4949, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4949, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->r;
		    retstr->b = c->b;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color arar(this UnityEngine.Color c) => default; // 0x0000000189C2C810-0x0000000189C2C894
		// Color arar(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::arar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4950, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4950, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->r;
		    retstr->b = c->a;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color arag(this UnityEngine.Color c) => default; // 0x0000000189C2C78C-0x0000000189C2C810
		// Color arag(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::arag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4951, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4951, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->r;
		    retstr->b = c->a;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color arab(this UnityEngine.Color c) => default; // 0x0000000189C2C708-0x0000000189C2C78C
		// Color arab(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::arab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4952, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4952, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->r;
		    retstr->b = c->a;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color araa(this UnityEngine.Color c) => default; // 0x0000000189C2C688-0x0000000189C2C708
		// Color araa(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::araa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4953, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4953, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->r;
		    a = c->a;
		    retstr->b = a;
		    retstr->a = a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color agrr(this UnityEngine.Color c) => default; // 0x0000000189C2C524-0x0000000189C2C5A4
		// Color agrr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::agrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4954, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4954, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->g;
		    r = c->r;
		    retstr->b = c->r;
		    retstr->a = r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color agrg(this UnityEngine.Color c) => default; // 0x0000000189C2C4A0-0x0000000189C2C524
		// Color agrg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::agrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4955, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4955, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->g;
		    retstr->b = c->r;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color agrb(this UnityEngine.Color c) => default; // 0x0000000189C2C41C-0x0000000189C2C4A0
		// Color agrb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::agrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4956, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4956, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->g;
		    retstr->b = c->r;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color agra(this UnityEngine.Color c) => default; // 0x0000000189C2C398-0x0000000189C2C41C
		// Color agra(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::agra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4957, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4957, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->g;
		    retstr->b = c->r;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aggr(this UnityEngine.Color c) => default; // 0x0000000189C2C298-0x0000000189C2C318
		// Color aggr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aggr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4958, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4958, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    g = c->g;
		    retstr->g = g;
		    retstr->b = g;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aggg(this UnityEngine.Color c) => default; // 0x0000000189C2C218-0x0000000189C2C298
		// Color aggg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aggg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4959, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4959, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    g = c->g;
		    retstr->g = g;
		    retstr->b = g;
		    retstr->a = g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aggb(this UnityEngine.Color c) => default; // 0x0000000189C2C198-0x0000000189C2C218
		// Color aggb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aggb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4960, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4960, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    g = c->g;
		    retstr->g = g;
		    retstr->b = g;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color agga(this UnityEngine.Color c) => default; // 0x0000000189C2C118-0x0000000189C2C198
		// Color agga(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::agga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4961, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4961, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    g = c->g;
		    retstr->g = g;
		    retstr->b = g;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color agbr(this UnityEngine.Color c) => default; // 0x0000000189C2C014-0x0000000189C2C098
		// Color agbr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::agbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4962, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4962, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->g;
		    retstr->b = c->b;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color agbg(this UnityEngine.Color c) => default; // 0x0000000189C2BF90-0x0000000189C2C014
		// Color agbg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::agbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4963, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4963, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->g;
		    retstr->b = c->b;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color agbb(this UnityEngine.Color c) => default; // 0x0000000189C2BF10-0x0000000189C2BF90
		// Color agbb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::agbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4964, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4964, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->g;
		    b = c->b;
		    retstr->b = b;
		    retstr->a = b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color agba(this UnityEngine.Color c) => default; // 0x0000000189C2BE8C-0x0000000189C2BF10
		// Color agba(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::agba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4965, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4965, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->g;
		    retstr->b = c->b;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color agar(this UnityEngine.Color c) => default; // 0x0000000189C2BD84-0x0000000189C2BE08
		// Color agar(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::agar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4966, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4966, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->g;
		    retstr->b = c->a;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color agag(this UnityEngine.Color c) => default; // 0x0000000189C2BD00-0x0000000189C2BD84
		// Color agag(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::agag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4967, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4967, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->g;
		    retstr->b = c->a;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color agab(this UnityEngine.Color c) => default; // 0x0000000189C2BC7C-0x0000000189C2BD00
		// Color agab(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::agab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4968, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4968, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->g;
		    retstr->b = c->a;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color agaa(this UnityEngine.Color c) => default; // 0x0000000189C2BBFC-0x0000000189C2BC7C
		// Color agaa(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::agaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4969, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4969, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->g;
		    a = c->a;
		    retstr->b = a;
		    retstr->a = a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color abrr(this UnityEngine.Color c) => default; // 0x0000000189C2BA94-0x0000000189C2BB14
		// Color abrr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::abrr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4970, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4970, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->b;
		    r = c->r;
		    retstr->b = c->r;
		    retstr->a = r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color abrg(this UnityEngine.Color c) => default; // 0x0000000189C2BA10-0x0000000189C2BA94
		// Color abrg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::abrg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4971, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4971, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->b;
		    retstr->b = c->r;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color abrb(this UnityEngine.Color c) => default; // 0x0000000189C2B98C-0x0000000189C2BA10
		// Color abrb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::abrb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4972, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4972, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->b;
		    retstr->b = c->r;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color abra(this UnityEngine.Color c) => default; // 0x0000000189C2B908-0x0000000189C2B98C
		// Color abra(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::abra(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4973, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4973, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->b;
		    retstr->b = c->r;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color abgr(this UnityEngine.Color c) => default; // 0x0000000189C2B804-0x0000000189C2B888
		// Color abgr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::abgr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4974, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4974, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->b;
		    retstr->b = c->g;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color abgg(this UnityEngine.Color c) => default; // 0x0000000189C2B784-0x0000000189C2B804
		// Color abgg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::abgg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4975, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4975, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->b;
		    g = c->g;
		    retstr->b = g;
		    retstr->a = g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color abgb(this UnityEngine.Color c) => default; // 0x0000000189C2B700-0x0000000189C2B784
		// Color abgb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::abgb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4976, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4976, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->b;
		    retstr->b = c->g;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color abga(this UnityEngine.Color c) => default; // 0x0000000189C2B67C-0x0000000189C2B700
		// Color abga(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::abga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4977, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4977, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->b;
		    retstr->b = c->g;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color abbr(this UnityEngine.Color c) => default; // 0x0000000189C2B578-0x0000000189C2B5F8
		// Color abbr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::abbr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4978, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4978, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    b = c->b;
		    retstr->g = b;
		    retstr->b = b;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color abbg(this UnityEngine.Color c) => default; // 0x0000000189C2B4F8-0x0000000189C2B578
		// Color abbg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::abbg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4979, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4979, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    b = c->b;
		    retstr->g = b;
		    retstr->b = b;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color abbb(this UnityEngine.Color c) => default; // 0x0000000189C2B478-0x0000000189C2B4F8
		// Color abbb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::abbb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4980, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4980, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    b = c->b;
		    retstr->g = b;
		    retstr->b = b;
		    retstr->a = b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color abba(this UnityEngine.Color c) => default; // 0x0000000189C2B3F8-0x0000000189C2B478
		// Color abba(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::abba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4981, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4981, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    b = c->b;
		    retstr->g = b;
		    retstr->b = b;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color abar(this UnityEngine.Color c) => default; // 0x0000000189C2B2F4-0x0000000189C2B378
		// Color abar(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::abar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4982, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4982, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->b;
		    retstr->b = c->a;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color abag(this UnityEngine.Color c) => default; // 0x0000000189C2B270-0x0000000189C2B2F4
		// Color abag(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::abag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4983, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4983, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->b;
		    retstr->b = c->a;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color abab(this UnityEngine.Color c) => default; // 0x0000000189C2B1EC-0x0000000189C2B270
		// Color abab(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::abab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v6; // rdx
		  __int64 v7; // rcx
		  Color v9; // [rsp+20h] [rbp-28h] BYREF
		  Color v10; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4984, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4984, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v7, v6);
		    v9 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v10, Patch, &v9, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->b;
		    retstr->b = c->a;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color abaa(this UnityEngine.Color c) => default; // 0x0000000189C2B16C-0x0000000189C2B1EC
		// Color abaa(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::abaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4985, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4985, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    retstr->r = c->a;
		    retstr->g = c->b;
		    a = c->a;
		    retstr->b = a;
		    retstr->a = a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aarr(this UnityEngine.Color c) => default; // 0x0000000189C2B008-0x0000000189C2B084
		// Color aarr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aarr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  float r; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Color v11; // [rsp+20h] [rbp-28h] BYREF
		  Color v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4986, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4986, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    a = c->a;
		    retstr->r = a;
		    retstr->g = a;
		    r = c->r;
		    retstr->b = c->r;
		    retstr->a = r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aarg(this UnityEngine.Color c) => default; // 0x0000000189C2AF88-0x0000000189C2B008
		// Color aarg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aarg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4987, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4987, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    a = c->a;
		    retstr->r = a;
		    retstr->g = a;
		    retstr->b = c->r;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aarb(this UnityEngine.Color c) => default; // 0x0000000189C2AF08-0x0000000189C2AF88
		// Color aarb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aarb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4988, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4988, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    a = c->a;
		    retstr->r = a;
		    retstr->g = a;
		    retstr->b = c->r;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aara(this UnityEngine.Color c) => default; // 0x0000000189C2AE88-0x0000000189C2AF08
		// Color aara(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aara(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4989, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4989, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    a = c->a;
		    retstr->r = a;
		    retstr->g = a;
		    retstr->b = c->r;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aagr(this UnityEngine.Color c) => default; // 0x0000000189C2AD88-0x0000000189C2AE08
		// Color aagr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aagr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4990, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4990, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    a = c->a;
		    retstr->r = a;
		    retstr->g = a;
		    retstr->b = c->g;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aagg(this UnityEngine.Color c) => default; // 0x0000000189C2AD08-0x0000000189C2AD88
		// Color aagg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aagg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  float g; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Color v11; // [rsp+20h] [rbp-28h] BYREF
		  Color v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4991, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4991, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    a = c->a;
		    retstr->r = a;
		    retstr->g = a;
		    g = c->g;
		    retstr->b = g;
		    retstr->a = g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aagb(this UnityEngine.Color c) => default; // 0x0000000189C2AC88-0x0000000189C2AD08
		// Color aagb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aagb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4992, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4992, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    a = c->a;
		    retstr->r = a;
		    retstr->g = a;
		    retstr->b = c->g;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aaga(this UnityEngine.Color c) => default; // 0x0000000189C2AC08-0x0000000189C2AC88
		// Color aaga(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aaga(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4993, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4993, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    a = c->a;
		    retstr->r = a;
		    retstr->g = a;
		    retstr->b = c->g;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aabr(this UnityEngine.Color c) => default; // 0x0000000189C2AB08-0x0000000189C2AB88
		// Color aabr(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aabr(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4994, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4994, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    a = c->a;
		    retstr->r = a;
		    retstr->g = a;
		    retstr->b = c->b;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aabg(this UnityEngine.Color c) => default; // 0x0000000189C2AA88-0x0000000189C2AB08
		// Color aabg(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aabg(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4995, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4995, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    a = c->a;
		    retstr->r = a;
		    retstr->g = a;
		    retstr->b = c->b;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aabb(this UnityEngine.Color c) => default; // 0x0000000189C2AA08-0x0000000189C2AA88
		// Color aabb(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aabb(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  float b; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v8; // rdx
		  __int64 v9; // rcx
		  Color v11; // [rsp+20h] [rbp-28h] BYREF
		  Color v12; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4996, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4996, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v9, v8);
		    v11 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v12, Patch, &v11, 0LL);
		  }
		  else
		  {
		    a = c->a;
		    retstr->r = a;
		    retstr->g = a;
		    b = c->b;
		    retstr->b = b;
		    retstr->a = b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aaba(this UnityEngine.Color c) => default; // 0x0000000189C2A988-0x0000000189C2AA08
		// Color aaba(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aaba(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4997, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4997, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    a = c->a;
		    retstr->r = a;
		    retstr->g = a;
		    retstr->b = c->b;
		    retstr->a = c->a;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aaar(this UnityEngine.Color c) => default; // 0x0000000189C2A88C-0x0000000189C2A908
		// Color aaar(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aaar(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4998, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4998, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    a = c->a;
		    retstr->r = a;
		    retstr->g = a;
		    retstr->b = a;
		    retstr->a = c->r;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aaag(this UnityEngine.Color c) => default; // 0x0000000189C2A80C-0x0000000189C2A88C
		// Color aaag(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aaag(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4999, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4999, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    a = c->a;
		    retstr->r = a;
		    retstr->g = a;
		    retstr->b = a;
		    retstr->a = c->g;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aaab(this UnityEngine.Color c) => default; // 0x0000000189C2A78C-0x0000000189C2A80C
		// Color aaab(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aaab(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5000, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5000, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    a = c->a;
		    retstr->r = a;
		    retstr->g = a;
		    retstr->b = a;
		    retstr->a = c->b;
		  }
		  return retstr;
		}
		
		public static UnityEngine.Color aaaa(this UnityEngine.Color c) => default; // 0x0000000189C2A710-0x0000000189C2A78C
		// Color aaaa(Color)
		Color *HG::Rendering::Runtime::VectorSwizzleUtils::aaaa(Color *__return_ptr retstr, Color *c, MethodInfo *method)
		{
		  float a; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  Color v10; // [rsp+20h] [rbp-28h] BYREF
		  Color v11; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5001, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5001, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v10 = *c;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1345(&v11, Patch, &v10, 0LL);
		  }
		  else
		  {
		    a = c->a;
		    retstr->r = a;
		    retstr->g = a;
		    retstr->b = a;
		    retstr->a = a;
		  }
		  return retstr;
		}
		
	}
}
