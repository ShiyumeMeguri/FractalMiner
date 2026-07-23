using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class HGEnvironmentUtils // TypeDefIndex: 37639
	{
		// Fields
		private static Mesh s_skydomeStarMesh; // 0x00
	
		// Methods
		public static Vector3 Transform3x3(Vector3 val, Vector3 up, Vector3 forward, Vector3 right) => default; // 0x0000000189CE37A4-0x0000000189CE3938
		// Vector3 Transform3x3(Vector3, Vector3, Vector3, Vector3)
		Vector3 *HG::Rendering::Runtime::HGEnvironmentUtils::Transform3x3(
		        Vector3 *__return_ptr retstr,
		        Vector3 *val,
		        Vector3 *up,
		        Vector3 *forward,
		        Vector3 *right,
		        MethodInfo *method)
		{
		  MethodInfo *v10; // r8
		  float v11; // eax
		  __int64 v12; // xmm0_8
		  float v13; // eax
		  __int64 v14; // xmm1_8
		  __int64 v15; // xmm3_8
		  float v16; // eax
		  MethodInfo *v17; // r8
		  __int64 v18; // xmm1_8
		  __int64 v19; // xmm3_8
		  float v20; // eax
		  MethodInfo *v21; // r8
		  float v22; // xmm5_4
		  float v23; // xmm4_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v25; // rcx
		  __int64 v26; // xmm0_8
		  float z; // eax
		  __int64 v28; // xmm0_8
		  Vector3 *v29; // rax
		  __int64 v30; // xmm0_8
		  Vector3 v32; // [rsp+48h] [rbp-9h] BYREF
		  Vector3 v33; // [rsp+58h] [rbp+7h] BYREF
		  Vector3 v34; // [rsp+68h] [rbp+17h] BYREF
		  Vector3 v35; // [rsp+78h] [rbp+27h] BYREF
		  Vector3 v36; // [rsp+88h] [rbp+37h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1451, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1451, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v25, 0LL);
		    v26 = *(_QWORD *)&right->x;
		    v33.z = right->z;
		    v32.z = forward->z;
		    z = up->z;
		    *(_QWORD *)&v33.x = v26;
		    v28 = *(_QWORD *)&forward->x;
		    v34.z = z;
		    v35.z = val->z;
		    *(_QWORD *)&v32.x = v28;
		    *(_QWORD *)&v34.x = *(_QWORD *)&up->x;
		    *(_QWORD *)&v35.x = *(_QWORD *)&val->x;
		    v29 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_597(&v36, Patch, &v35, &v34, &v32, &v33, 0LL);
		    v30 = *(_QWORD *)&v29->x;
		    *(float *)&v29 = v29->z;
		    *(_QWORD *)&retstr->x = v30;
		    LODWORD(retstr->z) = (_DWORD)v29;
		  }
		  else
		  {
		    v11 = right->z;
		    *(_QWORD *)&v32.x = *(_QWORD *)&right->x;
		    v12 = *(_QWORD *)&val->x;
		    v32.z = v11;
		    v13 = val->z;
		    *(_QWORD *)&v33.x = v12;
		    v33.z = v13;
		    UnityEngine::Vector3::Dot(&v33, &v32, v10);
		    v14 = *(_QWORD *)&val->x;
		    v15 = *(_QWORD *)&up->x;
		    v33.z = up->z;
		    v16 = val->z;
		    *(_QWORD *)&v32.x = v14;
		    v32.z = v16;
		    *(_QWORD *)&v33.x = v15;
		    UnityEngine::Vector3::Dot(&v32, &v33, v17);
		    v18 = *(_QWORD *)&val->x;
		    v19 = *(_QWORD *)&forward->x;
		    v33.z = forward->z;
		    v20 = val->z;
		    *(_QWORD *)&v32.x = v18;
		    v32.z = v20;
		    *(_QWORD *)&v33.x = v19;
		    retstr->z = UnityEngine::Vector3::Dot(&v32, &v33, v21);
		    retstr->x = v22;
		    retstr->y = v23;
		  }
		  return retstr;
		}
		
		public static float LerpExponential(float a, float b, float t, float e) => default; // 0x0000000189CE320C-0x0000000189CE32EC
		// Single LerpExponential(Single, Single, Single, Single)
		float HG::Rendering::Runtime::HGEnvironmentUtils::LerpExponential(
		        float a,
		        float b,
		        float t,
		        float e,
		        MethodInfo *method)
		{
		  Beyond::JobMathf *v6; // rcx
		  double v7; // xmm0_8
		  float v8; // xmm6_4
		  double v9; // xmm0_8
		  float result; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v12; // rdx
		  __int64 v13; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1452, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1452, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v13, v12);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_494((ILFixDynamicMethodWrapper_3 *)Patch, a, b, t, e, 0LL);
		  }
		  else
		  {
		    if ( b <= a )
		    {
		      v9 = sub_1803369A0();
		      v8 = 1.0 - *(float *)&v9;
		    }
		    else
		    {
		      v7 = sub_1803369A0();
		      v8 = *(float *)&v7;
		    }
		    result = a;
		    Beyond::JobMathf::ClampedLerp(v6, b, v8, e);
		  }
		  return result;
		}
		
		public static UnityEngine.Color GetColorFromTemperature(float t) => default; // 0x0000000189CE2F34-0x0000000189CE3190
		// Color GetColorFromTemperature(Single)
		Color *HG::Rendering::Runtime::HGEnvironmentUtils::GetColorFromTemperature(
		        Color *__return_ptr retstr,
		        float t,
		        MethodInfo *method)
		{
		  float v4; // xmm8_4
		  MethodInfo *v5; // r8
		  int v6; // xmm0_4
		  float v7; // xmm7_4
		  float v8; // xmm4_4
		  float v9; // xmm7_4
		  float v10; // xmm5_4
		  float v11; // xmm4_4
		  float v12; // xmm0_4
		  float v13; // xmm2_4
		  float v14; // xmm1_4
		  float v15; // xmm4_4
		  float v16; // xmm3_4
		  float v17; // xmm2_4
		  float v18; // xmm0_4
		  Color *gamma; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v21; // rdx
		  __int64 v22; // rcx
		  Color v23; // xmm0
		  Color *result; // rax
		  Color v25; // [rsp+20h] [rbp-58h] BYREF
		  Color v26; // [rsp+30h] [rbp-48h] BYREF
		
		  v4 = t;
		  if ( IFix::WrappersManagerImpl::IsPatched(1453, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1453, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v22, v21);
		    gamma = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_599(&v26, Patch, t, 0LL);
		  }
		  else
		  {
		    v6 = 1148846080;
		    if ( t < 1000.0 || (v6 = 1181376512, t > 15000.0) )
		      v4 = *(float *)&v6;
		    v7 = (float)((float)((float)(v4 * 0.00015411826) + 0.86011773) + (float)((float)(v4 * v4) * 0.00000012864122))
		       / (float)((float)((float)(v4 * 0.00084242021) + 1.0) + (float)((float)(v4 * v4) * 0.00000070814514));
		    v8 = v7 * 3.0;
		    v9 = v7 + v7;
		    v10 = (float)((float)((float)(v4 * 0.000042280626) + 0.31739873) + (float)((float)(v4 * v4) * 0.000000042048168))
		        / (float)((float)(1.0 - (float)(v4 * 0.000028974182)) + (float)((float)(v4 * v4) * 0.00000016145606));
		    v11 = v8 / (float)((float)(v9 - (float)(v10 * 8.0)) + 4.0);
		    v12 = (float)(v10 + v10) / (float)((float)(v9 - (float)(v10 * 8.0)) + 4.0);
		    v13 = (float)(1.0 / v12) * v11;
		    v14 = (float)((float)(1.0 - v11) - v12) * (float)(1.0 / v12);
		    v15 = (float)((float)(v13 * -0.969266) + 1.8760108) + (float)(v14 * 0.041556001);
		    v16 = (float)((float)(v13 * 3.2404542) - 1.5371385) + (float)(v14 * -0.4985314);
		    v17 = (float)((float)(v13 * 0.055643398) - 0.20402589) + (float)(v14 * 1.0572252);
		    if ( v16 <= v15 )
		      v18 = v15;
		    else
		      v18 = v16;
		    if ( v18 <= v17 )
		      v18 = v17;
		    v25.a = 1.0;
		    v25.r = v16 / v18;
		    v25.g = v15 / v18;
		    v25.b = v17 / v18;
		    gamma = UnityEngine::Color::get_gamma(&v26, &v25, v5);
		  }
		  v23 = *gamma;
		  result = retstr;
		  *retstr = v23;
		  return result;
		}
		
		public static float GetExposureFromEV100(float ev100) => default; // 0x0000000189CE3190-0x0000000189CE320C
		// Single GetExposureFromEV100(Single)
		float HG::Rendering::Runtime::HGEnvironmentUtils::GetExposureFromEV100(float ev100, MethodInfo *method)
		{
		  double v2; // xmm0_8
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1455, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1455, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_516(Patch, ev100, 0LL);
		  }
		  else
		  {
		    v2 = sub_1803369A0();
		    return 1.0 / (float)(*(float *)&v2 * 1.2);
		  }
		}
		
		public static void TentToCoefficients(float tentTipAltitude, float tentTipValue, float tentWidth, out float layerWidth, out float linTerm0, out float linTerm1, out float constTerm0, out float constTerm1) {
			layerWidth = default;
			linTerm0 = default;
			linTerm1 = default;
			constTerm0 = default;
			constTerm1 = default;
		} // 0x0000000189CE364C-0x0000000189CE37A4
		// Void TentToCoefficients(Single, Single, Single, Single ByRef, Single ByRef, Single ByRef, Single ByRef, Single ByRef)
		void HG::Rendering::Runtime::HGEnvironmentUtils::TentToCoefficients(
		        float tentTipAltitude,
		        float tentTipValue,
		        float tentWidth,
		        float *layerWidth,
		        float *linTerm0,
		        float *linTerm1,
		        float *constTerm0,
		        float *constTerm1,
		        MethodInfo *method)
		{
		  __int64 v10; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1432, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1432, 0LL);
		    if ( !Patch )
		      sub_1800D8260(0LL, v10);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_588(
		      Patch,
		      tentTipAltitude,
		      tentTipValue,
		      tentWidth,
		      layerWidth,
		      linTerm0,
		      linTerm1,
		      constTerm0,
		      constTerm1,
		      0LL);
		  }
		  else if ( tentWidth <= 0.0 || tentTipValue <= 0.0 )
		  {
		    *layerWidth = 0.0;
		    *linTerm0 = 0.0;
		    *linTerm1 = 0.0;
		    *constTerm0 = 0.0;
		    *constTerm1 = 0.0;
		  }
		  else
		  {
		    *layerWidth = tentTipAltitude;
		    *linTerm0 = tentTipValue / tentWidth;
		    *linTerm1 = -(float)(tentTipValue / tentWidth);
		    *constTerm0 = tentTipValue - (float)(tentTipAltitude * *linTerm0);
		    *constTerm1 = tentTipValue - (float)(tentTipAltitude * *linTerm1);
		  }
		}
		
		public static Mesh GenerateStarMesh(bool forceRegenerate = false /* Metadata: 0x02302FDF */) => default; // 0x00000001831D3290-0x00000001831D35B0
		// Mesh GenerateStarMesh(Boolean)
		Mesh *HG::Rendering::Runtime::HGEnvironmentUtils::GenerateStarMesh(bool forceRegenerate, MethodInfo *method)
		{
		  Mesh *s_skydomeStarMesh; // rbx
		  struct Object_1__Class *v4; // rdx
		  Mesh *v5; // rbx
		  bool v6; // al
		  __int64 v7; // rax
		  __int64 v8; // rdx
		  Mesh *v9; // rcx
		  Vector3__Array *v10; // rdi
		  __int64 v11; // rax
		  Vector2__Array *v12; // rbx
		  Array *v13; // rbp
		  Mesh *v14; // rax
		  Object_1 *v15; // rsi
		  Type *v16; // rdx
		  PropertyInfo_1 *v17; // r8
		  Int32__Array **v18; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v21; // [rsp+20h] [rbp-8h]
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1456, 0LL) )
		  {
		    s_skydomeStarMesh = TypeInfo::HG::Rendering::Runtime::HGEnvironmentUtils->static_fields->s_skydomeStarMesh;
		    v4 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v4 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v4 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( s_skydomeStarMesh )
		    {
		      if ( !v4->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(v4);
		        v4 = TypeInfo::UnityEngine::Object;
		      }
		      if ( s_skydomeStarMesh->fields._.m_CachedPtr && !forceRegenerate )
		        return TypeInfo::HG::Rendering::Runtime::HGEnvironmentUtils->static_fields->s_skydomeStarMesh;
		    }
		    v5 = TypeInfo::HG::Rendering::Runtime::HGEnvironmentUtils->static_fields->s_skydomeStarMesh;
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::UnityEngine::Object;
		      if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		      {
		        il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		        v4 = TypeInfo::UnityEngine::Object;
		      }
		    }
		    if ( v5 )
		    {
		      if ( !v4->_1.cctor_finished_or_no_cctor )
		        il2cpp_runtime_class_init_1(v4);
		      v6 = v5->fields._.m_CachedPtr == 0LL;
		    }
		    else
		    {
		      v6 = 1;
		    }
		    if ( !forceRegenerate && !v6 )
		      return TypeInfo::HG::Rendering::Runtime::HGEnvironmentUtils->static_fields->s_skydomeStarMesh;
		    v7 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 4LL);
		    v10 = (Vector3__Array *)v7;
		    if ( !v7 )
		      goto LABEL_19;
		    if ( !*(_DWORD *)(v7 + 24) )
		      goto LABEL_33;
		    *(_QWORD *)(v7 + 32) = _mm_unpacklo_ps((__m128)0xBF800000, (__m128)0xBF800000).m128_u64[0];
		    *(_DWORD *)(v7 + 40) = 0;
		    if ( *(_DWORD *)(v7 + 24) <= 1u )
		      goto LABEL_33;
		    *(_QWORD *)(v7 + 44) = _mm_unpacklo_ps((__m128)0xBF800000, (__m128)0x3F800000u).m128_u64[0];
		    *(_DWORD *)(v7 + 52) = 0;
		    if ( *(_DWORD *)(v7 + 24) <= 2u )
		      goto LABEL_33;
		    *(_QWORD *)(v7 + 56) = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0xBF800000).m128_u64[0];
		    *(_DWORD *)(v7 + 64) = 0;
		    if ( *(_DWORD *)(v7 + 24) <= 3u )
		      goto LABEL_33;
		    *(_QWORD *)(v7 + 68) = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		    *(_DWORD *)(v7 + 76) = 0;
		    v11 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2, *(unsigned int *)(v7 + 24));
		    v12 = (Vector2__Array *)v11;
		    if ( !v11 )
		      goto LABEL_19;
		    if ( !*(_DWORD *)(v11 + 24)
		      || (*(_QWORD *)(v11 + 32) = 0LL, *(_DWORD *)(v11 + 24) <= 1u)
		      || (*(_DWORD *)(v11 + 40) = 0, *(_DWORD *)(v11 + 44) = 1065353216, *(_DWORD *)(v11 + 24) <= 2u)
		      || (*(_QWORD *)(v11 + 48) = 1065353216LL, *(_DWORD *)(v11 + 24) <= 3u) )
		    {
		LABEL_33:
		      sub_1800D2AB0(v9, v8);
		    }
		    *(_DWORD *)(v11 + 56) = 1065353216;
		    *(_DWORD *)(v11 + 60) = 1065353216;
		    v13 = (Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 6LL);
		    System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		      v13,
		      4F3A974D03B4939FC26A965844D8E5F89E151FF80F59BB8AF511CC703F5DA157_Field,
		      0LL);
		    v14 = (Mesh *)sub_1800368D0(TypeInfo::UnityEngine::Mesh);
		    v15 = (Object_1 *)v14;
		    if ( v14 )
		    {
		      UnityEngine::Mesh::Mesh(v14, 0LL);
		      UnityEngine::Object::set_name(v15, (String *)"SkydomeMesh", 0LL);
		      UnityEngine::Mesh::set_vertices((Mesh *)v15, v10, 0LL);
		      UnityEngine::Mesh::set_uv((Mesh *)v15, v12, 0LL);
		      UnityEngine::Mesh::set_triangles((Mesh *)v15, (Int32__Array *)v13, 0LL);
		      UnityEngine::Object::set_hideFlags(v15, HideFlags__Enum_HideAndDontSave, 0LL);
		      TypeInfo::HG::Rendering::Runtime::HGEnvironmentUtils->static_fields->s_skydomeStarMesh = (Mesh *)v15;
		      sub_18002D1B0(
		        (SingleFieldAccessor *)TypeInfo::HG::Rendering::Runtime::HGEnvironmentUtils->static_fields,
		        v16,
		        v17,
		        v18,
		        v21);
		      v9 = TypeInfo::HG::Rendering::Runtime::HGEnvironmentUtils->static_fields->s_skydomeStarMesh;
		      if ( v9 )
		      {
		        UnityEngine::Mesh::UploadMeshData(v9, 1, 0LL);
		        return TypeInfo::HG::Rendering::Runtime::HGEnvironmentUtils->static_fields->s_skydomeStarMesh;
		      }
		    }
		LABEL_19:
		    sub_1800D8260(v9, v8);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1456, 0LL);
		  if ( !Patch )
		    goto LABEL_19;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_601(Patch, forceRegenerate, 0LL);
		}
		
		public static Mesh CreateGoldbergPolyhedron(int subdivisions) => default; // 0x0000000183C013C0-0x0000000183C015F0
		// Mesh CreateGoldbergPolyhedron(Int32)
		Mesh *HG::Rendering::Runtime::HGEnvironmentUtils::CreateGoldbergPolyhedron(int32_t subdivisions, MethodInfo *method)
		{
		  __int64 v2; // rbx
		  __int64 v3; // rdx
		  __int64 z_low; // rcx
		  Mesh *Icosahedron; // rbp
		  Vector3__Array *v6; // rax
		  Vector3__Array *v7; // rdi
		  Vector2__Array *v8; // rsi
		  int32_t i; // ebx
		  __int64 v10; // rax
		  __int64 v11; // rax
		  __int64 v12; // xmm0_8
		  MethodInfo *v13; // r9
		  Vector3 *v14; // rax
		  double v15; // xmm0_8
		  float v16; // xmm7_4
		  float v17; // xmm0_4
		  __int64 v18; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector3 v21; // [rsp+20h] [rbp-A8h] BYREF
		  _BYTE v22[16]; // [rsp+30h] [rbp-98h] BYREF
		  Vector3 v23[10]; // [rsp+40h] [rbp-88h] BYREF
		
		  v2 = (unsigned int)subdivisions;
		  if ( IFix::WrappersManagerImpl::IsPatched(1457, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1457, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_602(Patch, v2, 0LL);
		LABEL_5:
		    sub_1800D8260(z_low, v3 * 3);
		  }
		  Icosahedron = HG::Rendering::Runtime::HGEnvironmentUtils::CreateIcosahedron(0LL);
		  if ( (int)v2 > 0 )
		  {
		    do
		    {
		      Icosahedron = HG::Rendering::Runtime::HGEnvironmentUtils::Subdivide(Icosahedron, 0LL);
		      --v2;
		    }
		    while ( v2 );
		  }
		  if ( !Icosahedron )
		    goto LABEL_5;
		  v6 = UnityEngine::Mesh::GetAllocArrayFromChannel<UnityEngine::Vector3>(
		         Icosahedron,
		         VertexAttribute__Enum_Position,
		         MethodInfo::UnityEngine::Mesh::GetAllocArrayFromChannel<UnityEngine::Vector3>);
		  v7 = v6;
		  if ( !v6 )
		    goto LABEL_5;
		  v8 = (Vector2__Array *)il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector2, (unsigned int)v6->max_length.size);
		  for ( i = 0; i < v7->max_length.size; ++i )
		  {
		    v10 = sub_180002E90(v7, i);
		    v11 = sub_182FAE2B0(v22, v10);
		    v12 = *(_QWORD *)v11;
		    LODWORD(v11) = *(_DWORD *)(v11 + 8);
		    *(_QWORD *)&v21.x = v12;
		    LODWORD(v21.z) = v11;
		    v14 = UnityEngine::Vector3::op_Multiply(v23, &v21, 1.0, v13);
		    if ( (unsigned int)i >= v7->max_length.size )
		      goto LABEL_15;
		    v3 = i;
		    *(_QWORD *)&v7->vector[v3].x = *(_QWORD *)&v14->x;
		    z_low = LODWORD(v14->z);
		    LODWORD(v7->vector[v3].z) = z_low;
		    if ( (unsigned int)i >= v7->max_length.size )
		      goto LABEL_15;
		    v15 = sub_1803345E0(z_low);
		    v16 = (float)(*(float *)&v15 / 6.2831855) + 0.5;
		    v17 = (float)(sub_180334170() / 3.1415927) + 0.5;
		    if ( !v8 )
		      goto LABEL_5;
		    if ( (unsigned int)i >= v8->max_length.size )
		LABEL_15:
		      sub_1800D2AB0(z_low, v3 * 3);
		    v18 = i;
		    v8->vector[v18].x = v16;
		    v8->vector[v18].y = v17;
		  }
		  UnityEngine::Mesh::set_vertices(Icosahedron, v7, 0LL);
		  UnityEngine::Mesh::set_uv(Icosahedron, v8, 0LL);
		  UnityEngine::Mesh::RecalculateNormals(Icosahedron, MeshUpdateFlags__Enum_Default, 0LL);
		  UnityEngine::Object::set_hideFlags((Object_1 *)Icosahedron, HideFlags__Enum_HideAndDontSave, 0LL);
		  UnityEngine::Mesh::UploadMeshData(Icosahedron, 1, 0LL);
		  UnityEngine::Object::set_name((Object_1 *)Icosahedron, (String *)"GoldbergPolyhedron", 0LL);
		  return Icosahedron;
		}
		
		public static Mesh CreateIcosahedron() => default; // 0x00000001831D2D90-0x00000001831D31D0
		// Mesh CreateIcosahedron()
		Mesh *HG::Rendering::Runtime::HGEnvironmentUtils::CreateIcosahedron(MethodInfo *method)
		{
		  Mesh *v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  Mesh *v4; // rsi
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  __m128 v7; // xmm6
		  __int64 v8; // rdi
		  __int64 v9; // rax
		  __m128 v10; // xmm0
		  int v11; // eax
		  __int64 v12; // rax
		  int v13; // eax
		  __int64 v14; // rax
		  int v15; // eax
		  __int64 v16; // rax
		  int v17; // eax
		  __int64 v18; // rax
		  int v19; // eax
		  __int64 v20; // rax
		  int v21; // eax
		  __int64 v22; // rax
		  int v23; // eax
		  __int64 v24; // rax
		  int v25; // eax
		  __int64 v26; // rax
		  int v27; // eax
		  __int64 v28; // rax
		  int v29; // eax
		  __int64 v30; // rax
		  __int64 v31; // rax
		  Array *v32; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  unsigned __int64 v35; // [rsp+28h] [rbp-19h] BYREF
		  float v36; // [rsp+30h] [rbp-11h]
		  _BYTE v37[24]; // [rsp+38h] [rbp-9h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1458, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1458, 0LL);
		    if ( !Patch )
		      goto LABEL_6;
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_432(Patch, 0LL);
		  }
		  else
		  {
		    v1 = (Mesh *)sub_1800368D0(TypeInfo::UnityEngine::Mesh);
		    v4 = v1;
		    if ( !v1 )
		      goto LABEL_6;
		    UnityEngine::Mesh::Mesh(v1, 0LL);
		    if ( 5.0 < 0.0 )
		    {
		      v10 = (__m128)0x40A00000u;
		      v10.m128_f32[0] = sub_1803386C0(v6, v5);
		      v7 = v10;
		    }
		    else
		    {
		      v7 = 0LL;
		      v7.m128_f32[0] = fsqrt(5.0);
		    }
		    v7.m128_f32[0] = (float)(v7.m128_f32[0] + 1.0) * 0.5;
		    v35 = _mm_unpacklo_ps((__m128)0xBF800000, v7).m128_u64[0];
		    v8 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 12LL);
		    v36 = 0.0;
		    v9 = sub_182FAE2B0(v37, &v35);
		    if ( !v8 )
		LABEL_6:
		      sub_1800D8260(v3, v2);
		    if ( !*(_DWORD *)(v8 + 24) )
		      goto LABEL_21;
		    *(_QWORD *)(v8 + 32) = *(_QWORD *)v9;
		    v11 = *(_DWORD *)(v9 + 8);
		    v35 = _mm_unpacklo_ps((__m128)0x3F800000u, v7).m128_u64[0];
		    v36 = 0.0;
		    *(_DWORD *)(v8 + 40) = v11;
		    v12 = sub_182FAE2B0(v37, &v35);
		    if ( *(_DWORD *)(v8 + 24) <= 1u )
		      goto LABEL_21;
		    *(_QWORD *)(v8 + 44) = *(_QWORD *)v12;
		    v13 = *(_DWORD *)(v12 + 8);
		    v36 = 0.0;
		    v35 = _mm_unpacklo_ps((__m128)0xBF800000, _mm_xor_ps(v7, (__m128)0x80000000)).m128_u64[0];
		    *(_DWORD *)(v8 + 52) = v13;
		    v14 = sub_182FAE2B0(v37, &v35);
		    if ( *(_DWORD *)(v8 + 24) <= 2u )
		      goto LABEL_21;
		    *(_QWORD *)(v8 + 56) = *(_QWORD *)v14;
		    v15 = *(_DWORD *)(v14 + 8);
		    v36 = 0.0;
		    *(_DWORD *)(v8 + 64) = v15;
		    v35 = _mm_unpacklo_ps((__m128)0x3F800000u, _mm_xor_ps(v7, (__m128)0x80000000)).m128_u64[0];
		    v16 = sub_182FAE2B0(v37, &v35);
		    if ( *(_DWORD *)(v8 + 24) <= 3u )
		      goto LABEL_21;
		    *(_QWORD *)(v8 + 68) = *(_QWORD *)v16;
		    v17 = *(_DWORD *)(v16 + 8);
		    v35 = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
		    v36 = v7.m128_f32[0];
		    *(_DWORD *)(v8 + 76) = v17;
		    v18 = sub_182FAE2B0(v37, &v35);
		    if ( *(_DWORD *)(v8 + 24) <= 4u )
		      goto LABEL_21;
		    *(_QWORD *)(v8 + 80) = *(_QWORD *)v18;
		    v19 = *(_DWORD *)(v18 + 8);
		    v35 = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		    v36 = v7.m128_f32[0];
		    *(_DWORD *)(v8 + 88) = v19;
		    v20 = sub_182FAE2B0(v37, &v35);
		    if ( *(_DWORD *)(v8 + 24) <= 5u )
		      goto LABEL_21;
		    *(_QWORD *)(v8 + 92) = *(_QWORD *)v20;
		    v21 = *(_DWORD *)(v20 + 8);
		    v35 = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
		    v36 = -v7.m128_f32[0];
		    *(_DWORD *)(v8 + 100) = v21;
		    v22 = sub_182FAE2B0(v37, &v35);
		    if ( *(_DWORD *)(v8 + 24) <= 6u )
		      goto LABEL_21;
		    *(_QWORD *)(v8 + 104) = *(_QWORD *)v22;
		    v23 = *(_DWORD *)(v22 + 8);
		    v35 = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		    v36 = -v7.m128_f32[0];
		    *(_DWORD *)(v8 + 112) = v23;
		    v24 = sub_182FAE2B0(v37, &v35);
		    if ( *(_DWORD *)(v8 + 24) <= 7u )
		      goto LABEL_21;
		    *(_QWORD *)(v8 + 116) = *(_QWORD *)v24;
		    v25 = *(_DWORD *)(v24 + 8);
		    v35 = _mm_unpacklo_ps(v7, (__m128)0LL).m128_u64[0];
		    v36 = -1.0;
		    *(_DWORD *)(v8 + 124) = v25;
		    v26 = sub_182FAE2B0(v37, &v35);
		    if ( *(_DWORD *)(v8 + 24) <= 8u )
		      goto LABEL_21;
		    *(_QWORD *)(v8 + 128) = *(_QWORD *)v26;
		    v27 = *(_DWORD *)(v26 + 8);
		    v35 = _mm_unpacklo_ps(v7, (__m128)0LL).m128_u64[0];
		    v36 = 1.0;
		    *(_DWORD *)(v8 + 136) = v27;
		    v28 = sub_182FAE2B0(v37, &v35);
		    if ( *(_DWORD *)(v8 + 24) <= 9u )
		      goto LABEL_21;
		    *(_QWORD *)(v8 + 140) = *(_QWORD *)v28;
		    v29 = *(_DWORD *)(v28 + 8);
		    v36 = -1.0;
		    v35 = _mm_unpacklo_ps(_mm_xor_ps(v7, (__m128)0x80000000), (__m128)0LL).m128_u64[0];
		    *(_DWORD *)(v8 + 148) = v29;
		    v30 = sub_182FAE2B0(v37, &v35);
		    if ( *(_DWORD *)(v8 + 24) <= 0xAu
		      || (*(_QWORD *)(v8 + 152) = *(_QWORD *)v30,
		          *(_DWORD *)(v8 + 160) = *(_DWORD *)(v30 + 8),
		          v35 = _mm_unpacklo_ps(_mm_xor_ps(v7, (__m128)0x80000000), (__m128)0LL).m128_u64[0],
		          v36 = 1.0,
		          v31 = sub_182FAE2B0(v37, &v35),
		          *(_DWORD *)(v8 + 24) <= 0xBu) )
		    {
		LABEL_21:
		      sub_1800D2AB0(v3, v2);
		    }
		    *(_QWORD *)(v8 + 164) = *(_QWORD *)v31;
		    *(_DWORD *)(v8 + 172) = *(_DWORD *)(v31 + 8);
		    v32 = (Array *)il2cpp_array_new_specific_1(TypeInfo::System::Int32, 60LL);
		    System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
		      v32,
		      DCBEA4AF8FCA3574A40E0078B6F6F21226FA3AA4D9B1062ACDF0409F822D7375_Field,
		      0LL);
		    UnityEngine::Mesh::set_vertices(v4, (Vector3__Array *)v8, 0LL);
		    UnityEngine::Mesh::set_triangles(v4, (Int32__Array *)v32, 0LL);
		    UnityEngine::Mesh::RecalculateNormals(v4, MeshUpdateFlags__Enum_Default, 0LL);
		    return v4;
		  }
		}
		
		public static Mesh Subdivide(Mesh mesh) => default; // 0x00000001831D2400-0x00000001831D2710
		// Mesh Subdivide(Mesh)
		Mesh *HG::Rendering::Runtime::HGEnvironmentUtils::Subdivide(Mesh *mesh, MethodInfo *method)
		{
		  int32_t v3; // r13d
		  __int64 v4; // rdx
		  Func_2_Google_Protobuf_IMessage_Object_ *getValueDelegate; // rcx
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  Int32__Array *triangles; // rbx
		  List_1_UnityEngine_Vector3_ *v10; // rax
		  Func_2_Google_Protobuf_IMessage_Object_ *v11; // rdi
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *v15; // rax
		  Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *v16; // rax
		  SingleFieldAccessor__Class *v17; // rdi
		  Type *v18; // rdx
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  __int64 v21; // rsi
		  __int64 v22; // r14
		  unsigned int v23; // esi
		  unsigned int v24; // r14d
		  unsigned int v25; // edi
		  unsigned int MiddleVertex_17_0; // r12d
		  unsigned int v27; // r15d
		  unsigned int v28; // ebp
		  Vector3__Array *v29; // rax
		  Int32__Array *v30; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  MethodInfo *v33; // [rsp+20h] [rbp-78h]
		  __m128i v34; // [rsp+20h] [rbp-78h]
		  MethodInfo *v35; // [rsp+20h] [rbp-78h]
		  SingleFieldAccessor param_0004de02; // [rsp+30h] [rbp-68h] BYREF
		  List_1_System_Int32_ *v38; // [rsp+B0h] [rbp+18h]
		
		  v3 = 0;
		  param_0004de02.klass = 0LL;
		  param_0004de02.fields._.getValueDelegate = 0LL;
		  if ( !IFix::WrappersManagerImpl::IsPatched(1459, 0LL) )
		  {
		    if ( mesh )
		    {
		      param_0004de02.monitor = (MonitorData *)UnityEngine::Mesh::GetAllocArrayFromChannel<UnityEngine::Vector3>(
		                                                mesh,
		                                                VertexAttribute__Enum_Position,
		                                                MethodInfo::UnityEngine::Mesh::GetAllocArrayFromChannel<UnityEngine::Vector3>);
		      sub_18002D1B0((SingleFieldAccessor *)&param_0004de02.monitor, v6, v7, v8, v33);
		      triangles = UnityEngine::Mesh::get_triangles(mesh, 0LL);
		      v34 = *(__m128i *)&param_0004de02.klass;
		      v10 = (List_1_UnityEngine_Vector3_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<UnityEngine::Vector3>);
		      v11 = (Func_2_Google_Protobuf_IMessage_Object_ *)v10;
		      if ( v10 )
		      {
		        System::Collections::Generic::List<UnityEngine::Vector3>::List(
		          v10,
		          (IEnumerable_1_UnityEngine_Vector3_ *)_mm_srli_si128(v34, 8).m128i_i64[0],
		          MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::List);
		        param_0004de02.fields._.getValueDelegate = v11;
		        sub_18002D1B0((SingleFieldAccessor *)&param_0004de02.fields, v12, v13, v14, (MethodInfo *)v34.m128i_i64[0]);
		        v15 = (List_1_Beyond_Gameplay_Core_CinematicTimelineManagerBase_TimelineHandle_AsyncCompileAnimationOutput_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::List<int>);
		        v38 = (List_1_System_Int32_ *)v15;
		        if ( v15 )
		        {
		          System::Collections::Generic::List<Beyond::Gameplay::Core::CinematicTimelineManagerBase_TimelineHandle::AsyncCompileAnimationOutput>::List(
		            v15,
		            MethodInfo::System::Collections::Generic::List<int>::List);
		          v16 = (Dictionary_2_System_Object_Beyond_Gameplay_ShopSystem_UnlockInfo_ *)sub_1800368D0(TypeInfo::System::Collections::Generic::Dictionary<System::String,int>);
		          v17 = (SingleFieldAccessor__Class *)v16;
		          if ( v16 )
		          {
		            System::Collections::Generic::Dictionary<System::Object,Beyond::Gameplay::ShopSystem::UnlockInfo>::Dictionary(
		              v16,
		              MethodInfo::System::Collections::Generic::Dictionary<System::String,int>::Dictionary);
		            param_0004de02.klass = v17;
		            sub_18002D1B0(&param_0004de02, v18, v19, v20, v35);
		            if ( triangles )
		            {
		              while ( v3 < triangles->max_length.size )
		              {
		                if ( (unsigned int)v3 >= triangles->max_length.size
		                  || (v21 = v3 + 1LL, (unsigned int)v21 >= triangles->max_length.size)
		                  || (v22 = v3 + 2LL, (unsigned int)v22 >= triangles->max_length.size) )
		                {
		                  sub_1800D2AB0(getValueDelegate, v4);
		                }
		                v23 = triangles->vector[v21];
		                v24 = triangles->vector[v22];
		                v25 = triangles->vector[v3];
		                MiddleVertex_17_0 = HG::Rendering::Runtime::HGEnvironmentUtils::_Subdivide_g__GetMiddleVertex_17_0(
		                                      v25,
		                                      v23,
		                                      (HGEnvironmentUtils_c_DisplayClass17_0 *)&param_0004de02,
		                                      0LL);
		                v27 = HG::Rendering::Runtime::HGEnvironmentUtils::_Subdivide_g__GetMiddleVertex_17_0(
		                        v23,
		                        v24,
		                        (HGEnvironmentUtils_c_DisplayClass17_0 *)&param_0004de02,
		                        0LL);
		                v28 = HG::Rendering::Runtime::HGEnvironmentUtils::_Subdivide_g__GetMiddleVertex_17_0(
		                        v24,
		                        v25,
		                        (HGEnvironmentUtils_c_DisplayClass17_0 *)&param_0004de02,
		                        0LL);
		                sub_183081250(v38, v25, MethodInfo::System::Collections::Generic::List<int>::Add);
		                sub_183081250(v38, MiddleVertex_17_0, MethodInfo::System::Collections::Generic::List<int>::Add);
		                sub_183081250(v38, v28, MethodInfo::System::Collections::Generic::List<int>::Add);
		                sub_183081250(v38, v23, MethodInfo::System::Collections::Generic::List<int>::Add);
		                sub_183081250(v38, v27, MethodInfo::System::Collections::Generic::List<int>::Add);
		                sub_183081250(v38, MiddleVertex_17_0, MethodInfo::System::Collections::Generic::List<int>::Add);
		                sub_183081250(v38, v24, MethodInfo::System::Collections::Generic::List<int>::Add);
		                sub_183081250(v38, v28, MethodInfo::System::Collections::Generic::List<int>::Add);
		                sub_183081250(v38, v27, MethodInfo::System::Collections::Generic::List<int>::Add);
		                sub_183081250(v38, MiddleVertex_17_0, MethodInfo::System::Collections::Generic::List<int>::Add);
		                sub_183081250(v38, v27, MethodInfo::System::Collections::Generic::List<int>::Add);
		                sub_183081250(v38, v28, MethodInfo::System::Collections::Generic::List<int>::Add);
		                v3 += 3;
		              }
		              getValueDelegate = param_0004de02.fields._.getValueDelegate;
		              if ( param_0004de02.fields._.getValueDelegate )
		              {
		                v29 = (Vector3__Array *)System::Collections::Generic::List<UnityEngine::InputSystem::HID::HID::HIDElementDescriptor>::ToArray(
		                                          (List_1_UnityEngine_InputSystem_HID_HID_HIDElementDescriptor_ *)param_0004de02.fields._.getValueDelegate,
		                                          MethodInfo::System::Collections::Generic::List<UnityEngine::Vector3>::ToArray);
		                UnityEngine::Mesh::set_vertices(mesh, v29, 0LL);
		                v30 = System::Collections::Generic::List<int>::ToArray(
		                        v38,
		                        MethodInfo::System::Collections::Generic::List<int>::ToArray);
		                UnityEngine::Mesh::set_triangles(mesh, v30, 0LL);
		                UnityEngine::Mesh::RecalculateNormals(mesh, MeshUpdateFlags__Enum_Default, 0LL);
		                return mesh;
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_3:
		    sub_1800D8260(getValueDelegate, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1459, 0LL);
		  if ( !Patch )
		    goto LABEL_3;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_405(Patch, (Object *)mesh, 0LL);
		}
		
		public static float SkydomeStarHalfFovCos(float starRadius, float distanceToStar) => default; // 0x0000000189CE35D4-0x0000000189CE364C
		// Single SkydomeStarHalfFovCos(Single, Single)
		float HG::Rendering::Runtime::HGEnvironmentUtils::SkydomeStarHalfFovCos(
		        float starRadius,
		        float distanceToStar,
		        MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1460, 0LL) )
		    return sub_1803386C0(v4, v3);
		  Patch = IFix::WrappersManagerImpl::GetPatch(1460, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v8, v7);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_320(Patch, starRadius, distanceToStar, 0LL);
		}
		
	
		// Extension methods
		[IDTag(1)]
		public static float MinComponent(this Vector2 v) => default; // 0x0000000189CE33C4-0x0000000189CE3430
		// Single MinComponent(Vector2)
		float HG::Rendering::Runtime::HGEnvironmentUtils::MinComponent(Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1446, 0LL) )
		    return fminf(v.x, v.y);
		  Patch = IFix::WrappersManagerImpl::GetPatch(1446, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_595(Patch, v, 0LL);
		}
		
		[IDTag(0)]
		public static float MaxComponent(this Vector2 v) => default; // 0x0000000189CE3358-0x0000000189CE33C4
		// Single MaxComponent(Vector2)
		float HG::Rendering::Runtime::HGEnvironmentUtils::MaxComponent(Vector2 v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1447, 0LL) )
		    return fmaxf(v.x, v.y);
		  Patch = IFix::WrappersManagerImpl::GetPatch(1447, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_595(Patch, v, 0LL);
		}
		
		[IDTag(0)]
		public static float MinComponent(this Vector3 v) => default; // 0x00000001831F5650-0x00000001831F56C0
		// Single MinComponent(Vector3)
		float HG::Rendering::Runtime::HGEnvironmentUtils::MinComponent(Vector3 *v, MethodInfo *method)
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
		  if ( wrapperArray->max_length.size <= 627 )
		    return fminf(v->x, fminf(v->y, v->z));
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		    goto LABEL_6;
		  if ( LODWORD(v3->_0.namespaze) <= 0x273 )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( !v3[13]._0.nestedTypes )
		    return fminf(v->x, fminf(v->y, v->z));
		  Patch = IFix::WrappersManagerImpl::GetPatch(627, 0LL);
		  if ( !Patch )
		LABEL_6:
		    sub_1800D8260(v3, wrapperArray);
		  v7 = *(_QWORD *)&v->x;
		  v8.z = v->z;
		  *(_QWORD *)&v8.x = v7;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_251(Patch, &v8, 0LL);
		}
		
		[IDTag(1)]
		public static float MaxComponent(this Vector3 v) => default; // 0x00000001831F5610-0x00000001831F5650
		// Single MaxComponent(Vector3)
		float HG::Rendering::Runtime::HGEnvironmentUtils::MaxComponent(Vector3 *v, MethodInfo *method)
		{
		  __int64 v4; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  float z; // eax
		  Vector3 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1448, 0LL) )
		    return fmaxf(v->x, fmaxf(v->y, v->z));
		  Patch = IFix::WrappersManagerImpl::GetPatch(1448, 0LL);
		  if ( !Patch )
		    sub_1800D8260(0LL, v4);
		  z = v->z;
		  *(_QWORD *)&v7.x = *(_QWORD *)&v->x;
		  v7.z = z;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_251(Patch, &v7, 0LL);
		}
		
		[IDTag(2)]
		public static float MinComponent(this Vector4 v) => default; // 0x0000000189CE3430-0x0000000189CE349C
		// Single MinComponent(Vector4)
		float HG::Rendering::Runtime::HGEnvironmentUtils::MinComponent(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1449, 0LL) )
		    return fminf(v->x, fminf(v->y, fminf(v->z, v->w)));
		  Patch = IFix::WrappersManagerImpl::GetPatch(1449, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_596(Patch, &v7, 0LL);
		}
		
		[IDTag(2)]
		public static float MaxComponent(this Vector4 v) => default; // 0x0000000189CE32EC-0x0000000189CE3358
		// Single MaxComponent(Vector4)
		float HG::Rendering::Runtime::HGEnvironmentUtils::MaxComponent(Vector4 *v, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Vector4 v7; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1450, 0LL) )
		    return fmaxf(v->x, fmaxf(v->y, fmaxf(v->z, v->w)));
		  Patch = IFix::WrappersManagerImpl::GetPatch(1450, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  v7 = *v;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_596(Patch, &v7, 0LL);
		}
		
		public static SHCoefficientsL1 GetCoefficientsL1(this SphericalHarmonicsL2 sh) => default; // 0x000000018390EDD0-0x000000018390F060
		// SHCoefficientsL1 GetCoefficientsL1(SphericalHarmonicsL2)
		SHCoefficientsL1 *HG::Rendering::Runtime::HGEnvironmentUtils::GetCoefficientsL1(
		        SHCoefficientsL1 *__return_ptr retstr,
		        SphericalHarmonicsL2 *sh,
		        MethodInfo *method)
		{
		  __m128 v3; // xmm0
		  SphericalHarmonicsL2 *v5; // rbx
		  struct ILFixDynamicMethodWrapper_2__Class *v6; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  __m128 v8; // xmm13
		  float Item; // xmm12_4
		  float v10; // xmm11_4
		  float v11; // xmm9_4
		  __m128 v12; // xmm10
		  __m128 v13; // xmm10
		  __m128 v14; // xmm10
		  __m128 v15; // xmm8
		  float v16; // xmm7_4
		  float v17; // xmm6_4
		  float v18; // xmm0_4
		  __m128 v19; // xmm13
		  __m128 v20; // xmm13
		  SHCoefficientsL1 *result; // rax
		  __m128 v22; // xmm8
		  __m128 v23; // xmm13
		  __m128 v24; // xmm8
		  __m128 v25; // xmm8
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  SHCoefficientsL1 *v32; // rax
		  Vector4 shAg; // xmm1
		  Vector4 shAb; // xmm0
		  SHCoefficientsL1 v35; // [rsp+30h] [rbp-128h] BYREF
		  SphericalHarmonicsL2 v36; // [rsp+60h] [rbp-F8h] BYREF
		
		  v5 = sh;
		  v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    *(double *)v3.m128_u64 = il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v6->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_6;
		  if ( wrapperArray->max_length.size <= 911 )
		  {
		LABEL_5:
		    v3.m128_f32[0] = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(v5, 0, 3, 0LL);
		    v8 = v3;
		    Item = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(v5, 0, 1, 0LL);
		    v10 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(v5, 0, 2, 0LL);
		    v11 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(v5, 0, 0, 0LL);
		    v3.m128_f32[0] = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(v5, 1, 3, 0LL);
		    v12 = _mm_shuffle_ps(v3, v3, 225);
		    v12.m128_f32[0] = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(v5, 1, 1, 0LL);
		    v13 = _mm_shuffle_ps(v12, v12, 198);
		    v13.m128_f32[0] = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(v5, 1, 2, 0LL);
		    v14 = _mm_shuffle_ps(v13, v13, 39);
		    v14.m128_f32[0] = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(v5, 1, 0, 0LL);
		    v3.m128_f32[0] = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(v5, 2, 3, 0LL);
		    v15 = v3;
		    v16 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(v5, 2, 1, 0LL);
		    v17 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(v5, 2, 2, 0LL);
		    v18 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(v5, 2, 0, 0LL);
		    v19 = _mm_shuffle_ps(v8, v8, 225);
		    v19.m128_f32[0] = Item;
		    v20 = _mm_shuffle_ps(v19, v19, 198);
		    v20.m128_f32[0] = v10;
		    result = retstr;
		    v22 = _mm_shuffle_ps(v15, v15, 225);
		    v22.m128_f32[0] = v16;
		    v23 = _mm_shuffle_ps(v20, v20, 39);
		    v23.m128_f32[0] = v11;
		    v24 = _mm_shuffle_ps(v22, v22, 198);
		    v24.m128_f32[0] = v17;
		    v25 = _mm_shuffle_ps(v24, v24, 39);
		    retstr->shAr = (Vector4)_mm_shuffle_ps(v23, v23, 57);
		    v25.m128_f32[0] = v18;
		    retstr->shAg = (Vector4)_mm_shuffle_ps(v14, v14, 57);
		    retstr->shAb = (Vector4)_mm_shuffle_ps(v25, v25, 57);
		    return result;
		  }
		  if ( !v6->_1.cctor_finished_or_no_cctor )
		  {
		    *(double *)v3.m128_u64 = il2cpp_runtime_class_init_1(v6);
		    v6 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (struct ILFixDynamicMethodWrapper_2__Class *)v6->static_fields->wrapperArray;
		  if ( !v6 )
		    goto LABEL_6;
		  if ( LODWORD(v6->_0.namespaze) <= 0x38F )
		    sub_1800D2AB0(v6, sh);
		  if ( !v6[19].interfaceOffsets )
		    goto LABEL_5;
		  sh = (SphericalHarmonicsL2 *)IFix::WrappersManagerImpl::GetPatch(911, 0LL);
		  if ( !sh )
		LABEL_6:
		    sub_1800D8260(v6, sh);
		  v26 = *(_OWORD *)&v5->shr0;
		  v27 = *(_OWORD *)&v5->shr4;
		  v36.shb8 = v5->shb8;
		  *(_OWORD *)&v36.shr0 = v26;
		  v28 = *(_OWORD *)&v5->shr8;
		  *(_OWORD *)&v36.shr4 = v27;
		  v29 = *(_OWORD *)&v5->shg3;
		  *(_OWORD *)&v36.shr8 = v28;
		  v30 = *(_OWORD *)&v5->shg7;
		  *(_OWORD *)&v36.shg3 = v29;
		  v31 = *(_OWORD *)&v5->shb2;
		  *(_OWORD *)&v36.shg7 = v30;
		  *(_QWORD *)&v36.shb6 = *(_QWORD *)&v5->shb6;
		  *(_OWORD *)&v36.shb2 = v31;
		  v32 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_365(&v35, (ILFixDynamicMethodWrapper_2 *)sh, &v36, 0LL);
		  shAg = v32->shAg;
		  retstr->shAr = v32->shAr;
		  shAb = v32->shAb;
		  result = retstr;
		  retstr->shAg = shAg;
		  retstr->shAb = shAb;
		  return result;
		}
		
		public static SHCoefficientsL2 GetCoefficientsL2(this SphericalHarmonicsL2 sh) => default; // 0x0000000189CE2A88-0x0000000189CE2F34
		// SHCoefficientsL2 GetCoefficientsL2(SphericalHarmonicsL2)
		SHCoefficientsL2 *HG::Rendering::Runtime::HGEnvironmentUtils::GetCoefficientsL2(
		        SHCoefficientsL2 *__return_ptr retstr,
		        SphericalHarmonicsL2 *sh,
		        MethodInfo *method)
		{
		  float Item; // xmm7_4
		  float v6; // xmm9_4
		  float v7; // xmm8_4
		  float v8; // xmm7_4
		  float v9; // xmm6_4
		  float v10; // xmm9_4
		  float v11; // xmm8_4
		  float v12; // xmm7_4
		  float v13; // xmm6_4
		  float v14; // xmm7_4
		  float v15; // xmm6_4
		  float v16; // xmm0_4
		  Vector4 v17; // xmm1
		  Vector4 v18; // xmm0
		  Vector4 v19; // xmm1
		  Vector4 v20; // xmm0
		  Vector4 v21; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v23; // rcx
		  __int128 v24; // xmm0
		  Vector4 v25; // xmm1
		  Vector4 v26; // xmm0
		  Vector4 v27; // xmm1
		  Vector4 v28; // xmm0
		  Vector4 v29; // xmm1
		  SHCoefficientsL2 *v30; // rax
		  Vector4 shAg; // xmm1
		  Vector4 shAb; // xmm0
		  Vector4 shBr; // xmm1
		  Vector4 shBg; // xmm0
		  Vector4 shBb; // xmm1
		  Vector4 shC; // xmm0
		  __int128 v38; // [rsp+28h] [rbp-E0h] BYREF
		  Vector4 v39; // [rsp+38h] [rbp-D0h]
		  Vector4 v40; // [rsp+48h] [rbp-C0h]
		  Vector4 v41; // [rsp+58h] [rbp-B0h]
		  Vector4 v42; // [rsp+68h] [rbp-A0h]
		  Vector4 v43; // [rsp+78h] [rbp-90h]
		  Vector4 v44; // [rsp+88h] [rbp-80h]
		  Vector4 v45; // [rsp+98h] [rbp-70h]
		  SHCoefficientsL2 v46; // [rsp+A8h] [rbp-60h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1454, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1454, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v23, 0LL);
		    v24 = *(_OWORD *)&sh->shr0;
		    v25 = *(Vector4 *)&sh->shr4;
		    v44.z = sh->shb8;
		    v38 = v24;
		    v26 = *(Vector4 *)&sh->shr8;
		    v39 = v25;
		    v27 = *(Vector4 *)&sh->shg3;
		    v40 = v26;
		    v28 = *(Vector4 *)&sh->shg7;
		    v41 = v27;
		    v29 = *(Vector4 *)&sh->shb2;
		    v42 = v28;
		    *(_QWORD *)&v44.x = *(_QWORD *)&sh->shb6;
		    v43 = v29;
		    v30 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_600(&v46, Patch, (SphericalHarmonicsL2 *)&v38, 0LL);
		    shAg = v30->shAg;
		    retstr->shAr = v30->shAr;
		    shAb = v30->shAb;
		    retstr->shAg = shAg;
		    shBr = v30->shBr;
		    retstr->shAb = shAb;
		    shBg = v30->shBg;
		    retstr->shBr = shBr;
		    shBb = v30->shBb;
		    retstr->shBg = shBg;
		    shC = v30->shC;
		    retstr->shBb = shBb;
		    retstr->shC = shC;
		  }
		  else
		  {
		    v45.x = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 3, 0LL);
		    v45.y = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 1, 0LL);
		    v45.z = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 2, 0LL);
		    Item = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 0, 0LL);
		    v45.w = Item - UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 6, 0LL);
		    v6 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 3, 0LL);
		    v7 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 1, 0LL);
		    v8 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 2, 0LL);
		    v9 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 0, 0LL);
		    *(_QWORD *)&v39.x = __PAIR64__(LODWORD(v7), LODWORD(v6));
		    v39.z = v8;
		    v39.w = v9 - UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 6, 0LL);
		    v10 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 3, 0LL);
		    v11 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 1, 0LL);
		    v12 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 2, 0LL);
		    v13 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 0, 0LL);
		    *(_QWORD *)&v40.x = __PAIR64__(LODWORD(v11), LODWORD(v10));
		    v40.z = v12;
		    v40.w = v13 - UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 6, 0LL);
		    v41.x = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 4, 0LL);
		    v41.y = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 5, 0LL);
		    v41.z = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 6, 0LL) * 3.0;
		    v41.w = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 7, 0LL);
		    v42.x = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 4, 0LL);
		    v42.y = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 5, 0LL);
		    v42.z = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 6, 0LL) * 3.0;
		    v42.w = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 7, 0LL);
		    v43.x = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 4, 0LL);
		    v43.y = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 5, 0LL);
		    v43.z = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 6, 0LL) * 3.0;
		    v43.w = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 7, 0LL);
		    v14 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 0, 8, 0LL);
		    v15 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 1, 8, 0LL);
		    v16 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, 2, 8, 0LL);
		    v17 = v40;
		    retstr->shAr = v45;
		    *(_QWORD *)&v44.z = LODWORD(v16) | 0x3F80000000000000LL;
		    retstr->shAg = v39;
		    v18 = v41;
		    retstr->shAb = v17;
		    v19 = v42;
		    retstr->shBr = v18;
		    v20 = v43;
		    retstr->shBg = v19;
		    *(_QWORD *)&v44.x = __PAIR64__(LODWORD(v15), LODWORD(v14));
		    v21 = v44;
		    retstr->shBb = v20;
		    retstr->shC = v21;
		  }
		  return retstr;
		}
		
		[IDTag(0)]
		public static void SetTextureIfNotNull(this MaterialPropertyBlock materialPropertyBlock, int nameId, Texture texture) {} // 0x0000000189CE3538-0x0000000189CE35D4
		// Void SetTextureIfNotNull(MaterialPropertyBlock, Int32, Texture)
		void HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
		        MaterialPropertyBlock *materialPropertyBlock,
		        int32_t nameId,
		        Texture *texture,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1461, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality((Object_1 *)texture, 0LL, 0LL) )
		      return;
		    if ( materialPropertyBlock )
		    {
		      UnityEngine::MaterialPropertyBlock::SetTextureImpl(materialPropertyBlock, nameId, texture, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1461, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_56(
		    (ILFixDynamicMethodWrapper_17 *)Patch,
		    (Object *)materialPropertyBlock,
		    (AkCallbackType__Enum)nameId,
		    (Object *)texture,
		    0LL);
		}
		
		[IDTag(1)]
		public static void SetTextureIfNotNull(this MaterialPropertyBlock materialPropertyBlock, string name, Texture texture) {} // 0x0000000189CE349C-0x0000000189CE3538
		// Void SetTextureIfNotNull(MaterialPropertyBlock, String, Texture)
		void HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
		        MaterialPropertyBlock *materialPropertyBlock,
		        String *name,
		        Texture *texture,
		        MethodInfo *method)
		{
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1462, 0LL) )
		  {
		    sub_1800036A0(TypeInfo::UnityEngine::Object);
		    if ( UnityEngine::Object::op_Equality((Object_1 *)texture, 0LL, 0LL) )
		      return;
		    if ( materialPropertyBlock )
		    {
		      UnityEngine::MaterialPropertyBlock::SetTexture(materialPropertyBlock, name, texture, 0LL);
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v8, v7);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(1462, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
		    (ILFixDynamicMethodWrapper_30 *)Patch,
		    (Object *)materialPropertyBlock,
		    (Object *)name,
		    (Object *)texture,
		    0LL);
		}
		
		public static void SetColorIfNecessary(this Light light, UnityEngine.Color value) {} // 0x0000000182EDF1D0-0x0000000182EDF350
		// Void SetColorIfNecessary(Light, Color)
		void HG::Rendering::Runtime::HGEnvironmentUtils::SetColorIfNecessary(Light *light, Color *value, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  void (__fastcall *v7)(Light *, Color *); // rax
		  Color v8; // xmm1
		  MethodInfo *v9; // r8
		  Color v10; // xmm3
		  MethodInfo *v11; // r8
		  __m128 *v12; // rax
		  __m128 v13; // xmm5
		  float v14; // xmm4_4
		  float v15; // xmm2_4
		  void (__fastcall *v16)(Light *, Color *); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v18; // rax
		  Color v19; // [rsp+20h] [rbp-38h] BYREF
		  Color v20; // [rsp+30h] [rbp-28h] BYREF
		  Color v21; // [rsp+40h] [rbp-18h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_12;
		  if ( wrapperArray->max_length.size <= 642 )
		    goto LABEL_5;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		LABEL_12:
		    sub_1800D8260(v5, value);
		  if ( LODWORD(v5->_0.namespaze) <= 0x282 )
		    sub_1800D2AB0(v5, value);
		  if ( *(_QWORD *)&v5[13]._1.token )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(642, 0LL);
		    if ( Patch )
		    {
		      v19 = *value;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_260(Patch, (Object *)light, &v19, 0LL);
		      return;
		    }
		    goto LABEL_12;
		  }
		LABEL_5:
		  if ( !light )
		    goto LABEL_12;
		  v7 = (void (__fastcall *)(Light *, Color *))qword_18F36F6F8;
		  v19 = 0LL;
		  if ( !qword_18F36F6F8 )
		  {
		    v7 = (void (__fastcall *)(Light *, Color *))il2cpp_resolve_icall_1("UnityEngine.Light::get_color_Injected(UnityEngine.Color&)");
		    if ( !v7 )
		    {
		      v18 = sub_1802EE1B8("UnityEngine.Light::get_color_Injected(UnityEngine.Color&)");
		      sub_18007E1B0(v18, 0LL);
		    }
		    qword_18F36F6F8 = (__int64)v7;
		  }
		  v7(light, &v19);
		  v8 = *value;
		  v20 = v19;
		  v19 = v8;
		  v10 = *UnityEngine::Color::op_Implicit(&v21, (Vector4 *)&v19, v9);
		  v12 = (__m128 *)UnityEngine::Color::op_Implicit(&v19, (Vector4 *)&v20, v11);
		  v13 = *v12;
		  v14 = _mm_shuffle_ps(v13, v13, 85).m128_f32[0] - _mm_shuffle_ps((__m128)v10, (__m128)v10, 85).m128_f32[0];
		  v8.r = _mm_shuffle_ps(*v12, *v12, 170).m128_f32[0] - _mm_shuffle_ps((__m128)v10, (__m128)v10, 170).m128_f32[0];
		  v13.m128_f32[0] = _mm_shuffle_ps(v13, v13, 255).m128_f32[0];
		  v15 = (float)(COERCE_FLOAT(*v12) - v10.r) * (float)(COERCE_FLOAT(*v12) - v10.r);
		  v10.r = _mm_shuffle_ps((__m128)v10, (__m128)v10, 255).m128_f32[0];
		  if ( (float)((float)((float)((float)(v14 * v14) + v15) + (float)(v8.r * v8.r))
		             + (float)((float)(v13.m128_f32[0] - v10.r) * (float)(v13.m128_f32[0] - v10.r))) >= 9.9999994e-11 )
		  {
		    v16 = (void (__fastcall *)(Light *, Color *))qword_18F36F700;
		    v20 = *value;
		    if ( !qword_18F36F700 )
		    {
		      v16 = (void (__fastcall *)(Light *, Color *))sub_180059EA0("UnityEngine.Light::set_color_Injected(UnityEngine.Color&)");
		      qword_18F36F700 = (__int64)v16;
		    }
		    v16(light, &v20);
		  }
		}
		
		public static void SetIntensityIfNecessary(this Light light, float value) {} // 0x0000000182EDF400-0x0000000182EDF500
		// Void SetIntensityIfNecessary(Light, Single)
		void HG::Rendering::Runtime::HGEnvironmentUtils::SetIntensityIfNecessary(Light *light, float value, MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  float (__fastcall *v6)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
		  float v7; // xmm0_4
		  __int32 v8; // xmm2_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rax
		
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  if ( wrapperArray->max_length.size <= 643 )
		    goto LABEL_5;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = (struct ILFixDynamicMethodWrapper_2__Class *)v4->static_fields->wrapperArray;
		  if ( !v4 )
		LABEL_10:
		    sub_1800D8260(v4, wrapperArray);
		  if ( LODWORD(v4->_0.namespaze) <= 0x283 )
		    sub_1800D2AB0(v4, wrapperArray);
		  if ( *(_QWORD *)&v4[13]._1.field_count )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(643, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)light, value, 0LL);
		      return;
		    }
		    goto LABEL_10;
		  }
		LABEL_5:
		  if ( !light )
		    goto LABEL_10;
		  v6 = (float (__fastcall *)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18F36F6C8;
		  if ( !qword_18F36F6C8 )
		  {
		    v6 = (float (__fastcall *)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))il2cpp_resolve_icall_1(
		                                                                                              "UnityEngine.Light::get_intensity()");
		    if ( !v6 )
		    {
		      v10 = sub_1802EE1B8("UnityEngine.Light::get_intensity()");
		      sub_18007E1B0(v10, 0LL);
		    }
		    qword_18F36F6C8 = (__int64)v6;
		  }
		  v7 = v6(light, wrapperArray, method);
		  COERCE_FLOAT(v8 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_i32[0]);
		  if ( fmaxf(
		         fmaxf(COERCE_FLOAT(LODWORD(v7) & v8), COERCE_FLOAT(LODWORD(value) & v8)) * 0.000001,
		         TypeInfo::UnityEngine::Mathf->static_fields->Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(value - v7) & v8) )
		    UnityEngine::Light::set_intensity(light, value, 0LL);
		}
		
		public static void SetSpecularIntensityIfNecessary(this Light light, float value) {} // 0x0000000182EDF540-0x0000000182EDF640
		// Void SetSpecularIntensityIfNecessary(Light, Single)
		void HG::Rendering::Runtime::HGEnvironmentUtils::SetSpecularIntensityIfNecessary(
		        Light *light,
		        float value,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  float (__fastcall *v6)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
		  float v7; // xmm0_4
		  __int32 v8; // xmm2_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rax
		
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  if ( wrapperArray->max_length.size <= 644 )
		    goto LABEL_5;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = (struct ILFixDynamicMethodWrapper_2__Class *)v4->static_fields->wrapperArray;
		  if ( !v4 )
		LABEL_10:
		    sub_1800D8260(v4, wrapperArray);
		  if ( LODWORD(v4->_0.namespaze) <= 0x284 )
		    sub_1800D2AB0(v4, wrapperArray);
		  if ( *(_QWORD *)&v4[13]._1.interfaces_count )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(644, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)light, value, 0LL);
		      return;
		    }
		    goto LABEL_10;
		  }
		LABEL_5:
		  if ( !light )
		    goto LABEL_10;
		  v6 = (float (__fastcall *)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18F36F6D8;
		  if ( !qword_18F36F6D8 )
		  {
		    v6 = (float (__fastcall *)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))il2cpp_resolve_icall_1(
		                                                                                              "UnityEngine.Light::get_spe"
		                                                                                              "cularIntensity()");
		    if ( !v6 )
		    {
		      v10 = sub_1802EE1B8("UnityEngine.Light::get_specularIntensity()");
		      sub_18007E1B0(v10, 0LL);
		    }
		    qword_18F36F6D8 = (__int64)v6;
		  }
		  v7 = v6(light, wrapperArray, method);
		  COERCE_FLOAT(v8 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_i32[0]);
		  if ( fmaxf(
		         fmaxf(COERCE_FLOAT(LODWORD(v7) & v8), COERCE_FLOAT(LODWORD(value) & v8)) * 0.000001,
		         TypeInfo::UnityEngine::Mathf->static_fields->Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(value - v7) & v8) )
		    UnityEngine::Light::set_specularIntensity(light, value, 0LL);
		}
		
		public static void SetSoftSourceRaidiusIfNecessary(this Light light, float value) {} // 0x0000000182EDF680-0x0000000182EDF780
		// Void SetSoftSourceRaidiusIfNecessary(Light, Single)
		void HG::Rendering::Runtime::HGEnvironmentUtils::SetSoftSourceRaidiusIfNecessary(
		        Light *light,
		        float value,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  float (__fastcall *v6)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
		  float v7; // xmm0_4
		  __int32 v8; // xmm2_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rax
		
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_10;
		  if ( wrapperArray->max_length.size <= 645 )
		    goto LABEL_5;
		  if ( !v4->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v4);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v4 = (struct ILFixDynamicMethodWrapper_2__Class *)v4->static_fields->wrapperArray;
		  if ( !v4 )
		LABEL_10:
		    sub_1800D8260(v4, wrapperArray);
		  if ( LODWORD(v4->_0.namespaze) <= 0x285 )
		    sub_1800D2AB0(v4, wrapperArray);
		  if ( *(_QWORD *)&v4[13]._1.naturalAligment )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(645, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_15((ILFixDynamicMethodWrapper_18 *)Patch, (Object *)light, value, 0LL);
		      return;
		    }
		    goto LABEL_10;
		  }
		LABEL_5:
		  if ( !light )
		    goto LABEL_10;
		  v6 = (float (__fastcall *)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18F36F6E8;
		  if ( !qword_18F36F6E8 )
		  {
		    v6 = (float (__fastcall *)(Light *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))il2cpp_resolve_icall_1(
		                                                                                              "UnityEngine.Light::get_softSourceRadius()");
		    if ( !v6 )
		    {
		      v10 = sub_1802EE1B8("UnityEngine.Light::get_softSourceRadius()");
		      sub_18007E1B0(v10, 0LL);
		    }
		    qword_18F36F6E8 = (__int64)v6;
		  }
		  v7 = v6(light, wrapperArray, method);
		  COERCE_FLOAT(v8 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_i32[0]);
		  if ( fmaxf(
		         fmaxf(COERCE_FLOAT(LODWORD(v7) & v8), COERCE_FLOAT(LODWORD(value) & v8)) * 0.000001,
		         TypeInfo::UnityEngine::Mathf->static_fields->Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(value - v7) & v8) )
		    UnityEngine::Light::set_softSourceRadius(light, value, 0LL);
		}
		
		public static void SetLensFlareComponentEnableIfNecessary(this LensFlareComponentSRP lensFlareComponent, bool value) {} // 0x0000000182EDF7C0-0x0000000182EDF860
		// Void SetLensFlareComponentEnableIfNecessary(LensFlareComponentSRP, Boolean)
		// local variable allocation has failed, the output may be wrong!
		void HG::Rendering::Runtime::HGEnvironmentUtils::SetLensFlareComponentEnableIfNecessary(
		        LensFlareComponentSRP *lensFlareComponent,
		        bool value,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v5; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // r8
		  unsigned __int8 (__fastcall *v7)(LensFlareComponentSRP *); // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rax
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v5->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_9;
		  if ( wrapperArray->max_length.size <= 646 )
		    goto LABEL_5;
		  if ( !v5->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v5);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v5 = (struct ILFixDynamicMethodWrapper_2__Class *)v5->static_fields->wrapperArray;
		  if ( !v5 )
		LABEL_9:
		    sub_1800D8260(v5, value);
		  if ( LODWORD(v5->_0.namespaze) <= 0x286 )
		    sub_1800D2AB0(v5, value);
		  if ( v5[13].vtable.Equals.methodPtr )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(646, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
		        (ILFixDynamicMethodWrapper_18 *)Patch,
		        (Object *)lensFlareComponent,
		        value,
		        0LL);
		      return;
		    }
		    goto LABEL_9;
		  }
		LABEL_5:
		  if ( !lensFlareComponent )
		    goto LABEL_9;
		  v7 = (unsigned __int8 (__fastcall *)(LensFlareComponentSRP *))qword_18F36FBA8;
		  if ( !qword_18F36FBA8 )
		  {
		    v7 = (unsigned __int8 (__fastcall *)(LensFlareComponentSRP *))il2cpp_resolve_icall_1("UnityEngine.Behaviour::get_enabled()");
		    if ( !v7 )
		    {
		      v9 = sub_1802EE1B8("UnityEngine.Behaviour::get_enabled()");
		      sub_18007E1B0(v9, 0LL);
		    }
		    qword_18F36FBA8 = (__int64)v7;
		  }
		  if ( v7(lensFlareComponent) != value )
		    UnityEngine::Behaviour::set_enabled((Behaviour *)lensFlareComponent, value, 0LL);
		}
		
		public static void SetLensFlareDataIfNecessary(this LensFlareComponentSRP lensFlareComponent, LensFlareDataSRP value) {} // 0x0000000182EDF150-0x0000000182EDF1D0
		// Void SetLensFlareDataIfNecessary(LensFlareComponentSRP, LensFlareDataSRP)
		void HG::Rendering::Runtime::HGEnvironmentUtils::SetLensFlareDataIfNecessary(
		        LensFlareComponentSRP *lensFlareComponent,
		        LensFlareDataSRP *value,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Object_1 *m_LensFlareData; // rdi
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(647, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(647, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		        (ILFixDynamicMethodWrapper_39 *)Patch,
		        (Object *)lensFlareComponent,
		        (Object *)value,
		        0LL);
		      return;
		    }
		LABEL_7:
		    sub_1800D8260(v6, v5);
		  }
		  if ( !lensFlareComponent )
		    goto LABEL_7;
		  m_LensFlareData = (Object_1 *)lensFlareComponent->fields.m_LensFlareData;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  if ( !UnityEngine::Object::op_Equality(m_LensFlareData, (Object_1 *)value, 0LL) )
		    UnityEngine::Rendering::LensFlareComponentSRP::set_lensFlareData(lensFlareComponent, value, 0LL);
		}
		
	}
}
