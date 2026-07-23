using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal static class VisibleLightExtensionMethods // TypeDefIndex: 37797
	{
		// Nested types
		public struct VisibleLightAxisAndPosition // TypeDefIndex: 37796
		{
			// Fields
			public Vector3 Position; // 0x00
			public Vector3 Forward; // 0x0C
			public Vector3 Up; // 0x18
			public Vector3 Right; // 0x24
		}
	
		// Extension methods
		public static Vector3 GetPosition(this VisibleLight value) => default; // 0x0000000189D15168-0x0000000189D15298
		// Vector3 GetPosition(VisibleLight)
		Vector3 *HG::Rendering::Runtime::VisibleLightExtensionMethods::GetPosition(
		        Vector3 *__return_ptr retstr,
		        VisibleLight *value,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm1
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  MethodInfo *v8; // r8
		  Vector3 *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v11; // rcx
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  float m_ScreenSpaceArea; // eax
		  __int64 v20; // xmm0_8
		  float z; // eax
		  Vector4 v23; // [rsp+20h] [rbp-E0h] BYREF
		  Vector3 v24; // [rsp+30h] [rbp-D0h] BYREF
		  Matrix4x4 v25; // [rsp+40h] [rbp-C0h] BYREF
		  VisibleLight v26; // [rsp+80h] [rbp-80h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1917, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1917, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, 0LL);
		    v12 = *(_OWORD *)&value->m_FinalColor.a;
		    *(_OWORD *)&v26.m_LightType = *(_OWORD *)&value->m_LightType;
		    v13 = *(_OWORD *)&value->m_ScreenRect.m_Height;
		    *(_OWORD *)&v26.m_FinalColor.a = v12;
		    v14 = *(_OWORD *)&value->m_LocalToWorldMatrix.m30;
		    *(_OWORD *)&v26.m_ScreenRect.m_Height = v13;
		    v15 = *(_OWORD *)&value->m_LocalToWorldMatrix.m31;
		    *(_OWORD *)&v26.m_LocalToWorldMatrix.m30 = v14;
		    v16 = *(_OWORD *)&value->m_LocalToWorldMatrix.m32;
		    *(_OWORD *)&v26.m_LocalToWorldMatrix.m31 = v15;
		    v17 = *(_OWORD *)&value->m_LocalToWorldMatrix.m33;
		    *(_OWORD *)&v26.m_LocalToWorldMatrix.m32 = v16;
		    v18 = *(_OWORD *)&value->m_InstanceId;
		    *(_OWORD *)&v26.m_LocalToWorldMatrix.m33 = v17;
		    m_ScreenSpaceArea = value->m_ScreenSpaceArea;
		    *(_OWORD *)&v26.m_LightPriority = *(_OWORD *)&value->m_LightPriority;
		    *(_OWORD *)&v26.m_InstanceId = v18;
		    v26.m_ScreenSpaceArea = m_ScreenSpaceArea;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_768(&v24, Patch, &v26, 0LL);
		  }
		  else
		  {
		    v5 = *(_OWORD *)&value->m_LocalToWorldMatrix.m01;
		    *(_OWORD *)&v25.m00 = *(_OWORD *)&value->m_LocalToWorldMatrix.m00;
		    v6 = *(_OWORD *)&value->m_LocalToWorldMatrix.m02;
		    *(_OWORD *)&v25.m01 = v5;
		    v7 = *(_OWORD *)&value->m_LocalToWorldMatrix.m03;
		    *(_OWORD *)&v25.m02 = v6;
		    *(_OWORD *)&v25.m03 = v7;
		    v23 = *UnityEngine::Matrix4x4::GetColumn(&v23, &v25, 3, 0LL);
		    v9 = UnityEngine::Vector4::op_Implicit(&v24, &v23, v8);
		  }
		  v20 = *(_QWORD *)&v9->x;
		  z = v9->z;
		  *(_QWORD *)&retstr->x = v20;
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector4 GetHomogeneousPosition(this VisibleLight value) => default; // 0x0000000189D15064-0x0000000189D15168
		// Vector4 GetHomogeneousPosition(VisibleLight)
		Vector4 *HG::Rendering::Runtime::VisibleLightExtensionMethods::GetHomogeneousPosition(
		        Vector4 *__return_ptr retstr,
		        VisibleLight *value,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm1
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  Vector4 *Column; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v10; // rcx
		  __int128 v11; // xmm1
		  __int128 v12; // xmm0
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  float m_ScreenSpaceArea; // eax
		  Vector4 v19; // xmm0
		  Vector4 *result; // rax
		  Vector4 v21; // [rsp+20h] [rbp-F8h] BYREF
		  Matrix4x4 v22; // [rsp+30h] [rbp-E8h] BYREF
		  VisibleLight v23; // [rsp+70h] [rbp-A8h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1976, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1976, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, 0LL);
		    v11 = *(_OWORD *)&value->m_FinalColor.a;
		    *(_OWORD *)&v23.m_LightType = *(_OWORD *)&value->m_LightType;
		    v12 = *(_OWORD *)&value->m_ScreenRect.m_Height;
		    *(_OWORD *)&v23.m_FinalColor.a = v11;
		    v13 = *(_OWORD *)&value->m_LocalToWorldMatrix.m30;
		    *(_OWORD *)&v23.m_ScreenRect.m_Height = v12;
		    v14 = *(_OWORD *)&value->m_LocalToWorldMatrix.m31;
		    *(_OWORD *)&v23.m_LocalToWorldMatrix.m30 = v13;
		    v15 = *(_OWORD *)&value->m_LocalToWorldMatrix.m32;
		    *(_OWORD *)&v23.m_LocalToWorldMatrix.m31 = v14;
		    v16 = *(_OWORD *)&value->m_LocalToWorldMatrix.m33;
		    *(_OWORD *)&v23.m_LocalToWorldMatrix.m32 = v15;
		    v17 = *(_OWORD *)&value->m_InstanceId;
		    *(_OWORD *)&v23.m_LocalToWorldMatrix.m33 = v16;
		    m_ScreenSpaceArea = value->m_ScreenSpaceArea;
		    *(_OWORD *)&v23.m_LightPriority = *(_OWORD *)&value->m_LightPriority;
		    *(_OWORD *)&v23.m_InstanceId = v17;
		    v23.m_ScreenSpaceArea = m_ScreenSpaceArea;
		    Column = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_795(&v21, Patch, &v23, 0LL);
		  }
		  else
		  {
		    v5 = *(_OWORD *)&value->m_LocalToWorldMatrix.m01;
		    *(_OWORD *)&v22.m00 = *(_OWORD *)&value->m_LocalToWorldMatrix.m00;
		    v6 = *(_OWORD *)&value->m_LocalToWorldMatrix.m02;
		    *(_OWORD *)&v22.m01 = v5;
		    v7 = *(_OWORD *)&value->m_LocalToWorldMatrix.m03;
		    *(_OWORD *)&v22.m02 = v6;
		    *(_OWORD *)&v22.m03 = v7;
		    Column = UnityEngine::Matrix4x4::GetColumn(&v21, &v22, 3, 0LL);
		  }
		  v19 = *Column;
		  result = retstr;
		  *retstr = v19;
		  return result;
		}
		
		public static Vector3 GetForward(this VisibleLight value) => default; // 0x0000000189D14F34-0x0000000189D15064
		// Vector3 GetForward(VisibleLight)
		Vector3 *HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward(
		        Vector3 *__return_ptr retstr,
		        VisibleLight *value,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm1
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  MethodInfo *v8; // r8
		  Vector3 *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v11; // rcx
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  float m_ScreenSpaceArea; // eax
		  __int64 v20; // xmm0_8
		  float z; // eax
		  Vector4 v23; // [rsp+20h] [rbp-E0h] BYREF
		  Vector3 v24; // [rsp+30h] [rbp-D0h] BYREF
		  Matrix4x4 v25; // [rsp+40h] [rbp-C0h] BYREF
		  VisibleLight v26; // [rsp+80h] [rbp-80h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1914, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1914, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, 0LL);
		    v12 = *(_OWORD *)&value->m_FinalColor.a;
		    *(_OWORD *)&v26.m_LightType = *(_OWORD *)&value->m_LightType;
		    v13 = *(_OWORD *)&value->m_ScreenRect.m_Height;
		    *(_OWORD *)&v26.m_FinalColor.a = v12;
		    v14 = *(_OWORD *)&value->m_LocalToWorldMatrix.m30;
		    *(_OWORD *)&v26.m_ScreenRect.m_Height = v13;
		    v15 = *(_OWORD *)&value->m_LocalToWorldMatrix.m31;
		    *(_OWORD *)&v26.m_LocalToWorldMatrix.m30 = v14;
		    v16 = *(_OWORD *)&value->m_LocalToWorldMatrix.m32;
		    *(_OWORD *)&v26.m_LocalToWorldMatrix.m31 = v15;
		    v17 = *(_OWORD *)&value->m_LocalToWorldMatrix.m33;
		    *(_OWORD *)&v26.m_LocalToWorldMatrix.m32 = v16;
		    v18 = *(_OWORD *)&value->m_InstanceId;
		    *(_OWORD *)&v26.m_LocalToWorldMatrix.m33 = v17;
		    m_ScreenSpaceArea = value->m_ScreenSpaceArea;
		    *(_OWORD *)&v26.m_LightPriority = *(_OWORD *)&value->m_LightPriority;
		    *(_OWORD *)&v26.m_InstanceId = v18;
		    v26.m_ScreenSpaceArea = m_ScreenSpaceArea;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_768(&v24, Patch, &v26, 0LL);
		  }
		  else
		  {
		    v5 = *(_OWORD *)&value->m_LocalToWorldMatrix.m01;
		    *(_OWORD *)&v25.m00 = *(_OWORD *)&value->m_LocalToWorldMatrix.m00;
		    v6 = *(_OWORD *)&value->m_LocalToWorldMatrix.m02;
		    *(_OWORD *)&v25.m01 = v5;
		    v7 = *(_OWORD *)&value->m_LocalToWorldMatrix.m03;
		    *(_OWORD *)&v25.m02 = v6;
		    *(_OWORD *)&v25.m03 = v7;
		    v23 = *UnityEngine::Matrix4x4::GetColumn(&v23, &v25, 2, 0LL);
		    v9 = UnityEngine::Vector4::op_Implicit(&v24, &v23, v8);
		  }
		  v20 = *(_QWORD *)&v9->x;
		  z = v9->z;
		  *(_QWORD *)&retstr->x = v20;
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 GetUp(this VisibleLight value) => default; // 0x0000000189D153C4-0x0000000189D154F4
		// Vector3 GetUp(VisibleLight)
		Vector3 *HG::Rendering::Runtime::VisibleLightExtensionMethods::GetUp(
		        Vector3 *__return_ptr retstr,
		        VisibleLight *value,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm1
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  MethodInfo *v8; // r8
		  Vector3 *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v11; // rcx
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  float m_ScreenSpaceArea; // eax
		  __int64 v20; // xmm0_8
		  float z; // eax
		  Vector4 v23; // [rsp+20h] [rbp-E0h] BYREF
		  Vector3 v24; // [rsp+30h] [rbp-D0h] BYREF
		  Matrix4x4 v25; // [rsp+40h] [rbp-C0h] BYREF
		  VisibleLight v26; // [rsp+80h] [rbp-80h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1929, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1929, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, 0LL);
		    v12 = *(_OWORD *)&value->m_FinalColor.a;
		    *(_OWORD *)&v26.m_LightType = *(_OWORD *)&value->m_LightType;
		    v13 = *(_OWORD *)&value->m_ScreenRect.m_Height;
		    *(_OWORD *)&v26.m_FinalColor.a = v12;
		    v14 = *(_OWORD *)&value->m_LocalToWorldMatrix.m30;
		    *(_OWORD *)&v26.m_ScreenRect.m_Height = v13;
		    v15 = *(_OWORD *)&value->m_LocalToWorldMatrix.m31;
		    *(_OWORD *)&v26.m_LocalToWorldMatrix.m30 = v14;
		    v16 = *(_OWORD *)&value->m_LocalToWorldMatrix.m32;
		    *(_OWORD *)&v26.m_LocalToWorldMatrix.m31 = v15;
		    v17 = *(_OWORD *)&value->m_LocalToWorldMatrix.m33;
		    *(_OWORD *)&v26.m_LocalToWorldMatrix.m32 = v16;
		    v18 = *(_OWORD *)&value->m_InstanceId;
		    *(_OWORD *)&v26.m_LocalToWorldMatrix.m33 = v17;
		    m_ScreenSpaceArea = value->m_ScreenSpaceArea;
		    *(_OWORD *)&v26.m_LightPriority = *(_OWORD *)&value->m_LightPriority;
		    *(_OWORD *)&v26.m_InstanceId = v18;
		    v26.m_ScreenSpaceArea = m_ScreenSpaceArea;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_768(&v24, Patch, &v26, 0LL);
		  }
		  else
		  {
		    v5 = *(_OWORD *)&value->m_LocalToWorldMatrix.m01;
		    *(_OWORD *)&v25.m00 = *(_OWORD *)&value->m_LocalToWorldMatrix.m00;
		    v6 = *(_OWORD *)&value->m_LocalToWorldMatrix.m02;
		    *(_OWORD *)&v25.m01 = v5;
		    v7 = *(_OWORD *)&value->m_LocalToWorldMatrix.m03;
		    *(_OWORD *)&v25.m02 = v6;
		    *(_OWORD *)&v25.m03 = v7;
		    v23 = *UnityEngine::Matrix4x4::GetColumn(&v23, &v25, 1, 0LL);
		    v9 = UnityEngine::Vector4::op_Implicit(&v24, &v23, v8);
		  }
		  v20 = *(_QWORD *)&v9->x;
		  z = v9->z;
		  *(_QWORD *)&retstr->x = v20;
		  retstr->z = z;
		  return retstr;
		}
		
		public static Vector3 GetRight(this VisibleLight value) => default; // 0x0000000189D15298-0x0000000189D153C4
		// Vector3 GetRight(VisibleLight)
		Vector3 *HG::Rendering::Runtime::VisibleLightExtensionMethods::GetRight(
		        Vector3 *__return_ptr retstr,
		        VisibleLight *value,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm1
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  MethodInfo *v8; // r8
		  Vector3 *v9; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v11; // rcx
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  float m_ScreenSpaceArea; // eax
		  __int64 v20; // xmm0_8
		  float z; // eax
		  Vector4 v23; // [rsp+20h] [rbp-E0h] BYREF
		  Vector3 v24; // [rsp+30h] [rbp-D0h] BYREF
		  Matrix4x4 v25; // [rsp+40h] [rbp-C0h] BYREF
		  VisibleLight v26; // [rsp+80h] [rbp-80h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1928, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1928, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, 0LL);
		    v12 = *(_OWORD *)&value->m_FinalColor.a;
		    *(_OWORD *)&v26.m_LightType = *(_OWORD *)&value->m_LightType;
		    v13 = *(_OWORD *)&value->m_ScreenRect.m_Height;
		    *(_OWORD *)&v26.m_FinalColor.a = v12;
		    v14 = *(_OWORD *)&value->m_LocalToWorldMatrix.m30;
		    *(_OWORD *)&v26.m_ScreenRect.m_Height = v13;
		    v15 = *(_OWORD *)&value->m_LocalToWorldMatrix.m31;
		    *(_OWORD *)&v26.m_LocalToWorldMatrix.m30 = v14;
		    v16 = *(_OWORD *)&value->m_LocalToWorldMatrix.m32;
		    *(_OWORD *)&v26.m_LocalToWorldMatrix.m31 = v15;
		    v17 = *(_OWORD *)&value->m_LocalToWorldMatrix.m33;
		    *(_OWORD *)&v26.m_LocalToWorldMatrix.m32 = v16;
		    v18 = *(_OWORD *)&value->m_InstanceId;
		    *(_OWORD *)&v26.m_LocalToWorldMatrix.m33 = v17;
		    m_ScreenSpaceArea = value->m_ScreenSpaceArea;
		    *(_OWORD *)&v26.m_LightPriority = *(_OWORD *)&value->m_LightPriority;
		    *(_OWORD *)&v26.m_InstanceId = v18;
		    v26.m_ScreenSpaceArea = m_ScreenSpaceArea;
		    v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_768(&v24, Patch, &v26, 0LL);
		  }
		  else
		  {
		    v5 = *(_OWORD *)&value->m_LocalToWorldMatrix.m01;
		    *(_OWORD *)&v25.m00 = *(_OWORD *)&value->m_LocalToWorldMatrix.m00;
		    v6 = *(_OWORD *)&value->m_LocalToWorldMatrix.m02;
		    *(_OWORD *)&v25.m01 = v5;
		    v7 = *(_OWORD *)&value->m_LocalToWorldMatrix.m03;
		    *(_OWORD *)&v25.m02 = v6;
		    *(_OWORD *)&v25.m03 = v7;
		    v23 = *UnityEngine::Matrix4x4::GetColumn(&v23, &v25, 0, 0LL);
		    v9 = UnityEngine::Vector4::op_Implicit(&v24, &v23, v8);
		  }
		  v20 = *(_QWORD *)&v9->x;
		  z = v9->z;
		  *(_QWORD *)&retstr->x = v20;
		  retstr->z = z;
		  return retstr;
		}
		
		public static VisibleLightAxisAndPosition GetAxisAndPosition(this VisibleLight value) => default; // 0x0000000189D14D0C-0x0000000189D14F34
		// VisibleLightExtensionMethods+VisibleLightAxisAndPosition GetAxisAndPosition(VisibleLight)
		VisibleLightExtensionMethods_VisibleLightAxisAndPosition *HG::Rendering::Runtime::VisibleLightExtensionMethods::GetAxisAndPosition(
		        VisibleLightExtensionMethods_VisibleLightAxisAndPosition *__return_ptr retstr,
		        VisibleLight *value,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm1
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  MethodInfo *v8; // r8
		  Vector3 *v9; // rax
		  __int64 v10; // xmm3_8
		  MethodInfo *v11; // r8
		  Vector3 *v12; // rax
		  __int64 v13; // xmm3_8
		  MethodInfo *v14; // r8
		  Vector3 *v15; // rax
		  __int64 v16; // xmm3_8
		  MethodInfo *v17; // r8
		  Vector3 *v18; // rax
		  __int128 v19; // xmm1
		  __int64 v20; // xmm3_8
		  __int128 v21; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v23; // rcx
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  __int128 v26; // xmm1
		  __int128 v27; // xmm0
		  __int128 v28; // xmm1
		  __int128 v29; // xmm0
		  __int128 v30; // xmm1
		  float m_ScreenSpaceArea; // eax
		  VisibleLightExtensionMethods_VisibleLightAxisAndPosition *v32; // rax
		  VisibleLightExtensionMethods_VisibleLightAxisAndPosition *result; // rax
		  Vector4 v34; // [rsp+20h] [rbp-E0h] BYREF
		  Vector3 v35; // [rsp+30h] [rbp-D0h] BYREF
		  VisibleLightExtensionMethods_VisibleLightAxisAndPosition v36; // [rsp+40h] [rbp-C0h] BYREF
		  Matrix4x4 v37; // [rsp+70h] [rbp-90h] BYREF
		  VisibleLight v38; // [rsp+B0h] [rbp-50h] BYREF
		
		  memset(&v36, 0, sizeof(v36));
		  if ( IFix::WrappersManagerImpl::IsPatched(1977, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1977, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v23, 0LL);
		    v24 = *(_OWORD *)&value->m_FinalColor.a;
		    *(_OWORD *)&v38.m_LightType = *(_OWORD *)&value->m_LightType;
		    v25 = *(_OWORD *)&value->m_ScreenRect.m_Height;
		    *(_OWORD *)&v38.m_FinalColor.a = v24;
		    v26 = *(_OWORD *)&value->m_LocalToWorldMatrix.m30;
		    *(_OWORD *)&v38.m_ScreenRect.m_Height = v25;
		    v27 = *(_OWORD *)&value->m_LocalToWorldMatrix.m31;
		    *(_OWORD *)&v38.m_LocalToWorldMatrix.m30 = v26;
		    v28 = *(_OWORD *)&value->m_LocalToWorldMatrix.m32;
		    *(_OWORD *)&v38.m_LocalToWorldMatrix.m31 = v27;
		    v29 = *(_OWORD *)&value->m_LocalToWorldMatrix.m33;
		    *(_OWORD *)&v38.m_LocalToWorldMatrix.m32 = v28;
		    v30 = *(_OWORD *)&value->m_InstanceId;
		    *(_OWORD *)&v38.m_LocalToWorldMatrix.m33 = v29;
		    m_ScreenSpaceArea = value->m_ScreenSpaceArea;
		    *(_OWORD *)&v38.m_LightPriority = *(_OWORD *)&value->m_LightPriority;
		    *(_OWORD *)&v38.m_InstanceId = v30;
		    v38.m_ScreenSpaceArea = m_ScreenSpaceArea;
		    v32 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_796(&v36, Patch, &v38, 0LL);
		    v19 = *(_OWORD *)&v32->Forward.y;
		    *(_OWORD *)&retstr->Position.x = *(_OWORD *)&v32->Position.x;
		    v21 = *(_OWORD *)&v32->Up.z;
		  }
		  else
		  {
		    v5 = *(_OWORD *)&value->m_LocalToWorldMatrix.m01;
		    *(_OWORD *)&v37.m00 = *(_OWORD *)&value->m_LocalToWorldMatrix.m00;
		    v6 = *(_OWORD *)&value->m_LocalToWorldMatrix.m02;
		    *(_OWORD *)&v37.m01 = v5;
		    v7 = *(_OWORD *)&value->m_LocalToWorldMatrix.m03;
		    *(_OWORD *)&v37.m02 = v6;
		    *(_OWORD *)&v37.m03 = v7;
		    v34 = *UnityEngine::Matrix4x4::GetColumn(&v34, &v37, 3, 0LL);
		    v9 = UnityEngine::Vector4::op_Implicit(&v35, &v34, v8);
		    v10 = *(_QWORD *)&v9->x;
		    *(float *)&v9 = v9->z;
		    *(_QWORD *)&v36.Position.x = v10;
		    LODWORD(v36.Position.z) = (_DWORD)v9;
		    v34 = *UnityEngine::Matrix4x4::GetColumn(&v34, &v37, 2, 0LL);
		    v12 = UnityEngine::Vector4::op_Implicit(&v35, &v34, v11);
		    v13 = *(_QWORD *)&v12->x;
		    *(float *)&v12 = v12->z;
		    *(_QWORD *)&v36.Forward.x = v13;
		    LODWORD(v36.Forward.z) = (_DWORD)v12;
		    v34 = *UnityEngine::Matrix4x4::GetColumn(&v34, &v37, 1, 0LL);
		    v15 = UnityEngine::Vector4::op_Implicit(&v35, &v34, v14);
		    v16 = *(_QWORD *)&v15->x;
		    *(float *)&v15 = v15->z;
		    *(_QWORD *)&v36.Up.x = v16;
		    LODWORD(v36.Up.z) = (_DWORD)v15;
		    v34 = *UnityEngine::Matrix4x4::GetColumn(&v34, &v37, 0, 0LL);
		    v18 = UnityEngine::Vector4::op_Implicit(&v35, &v34, v17);
		    v19 = *(_OWORD *)&v36.Forward.y;
		    v20 = *(_QWORD *)&v18->x;
		    *(float *)&v18 = v18->z;
		    *(_QWORD *)&v36.Right.x = v20;
		    LODWORD(v36.Right.z) = (_DWORD)v18;
		    *(_OWORD *)&retstr->Position.x = *(_OWORD *)&v36.Position.x;
		    v21 = *(_OWORD *)&v36.Up.z;
		  }
		  *(_OWORD *)&retstr->Forward.y = v19;
		  result = retstr;
		  *(_OWORD *)&retstr->Up.z = v21;
		  return result;
		}
		
	}
}
