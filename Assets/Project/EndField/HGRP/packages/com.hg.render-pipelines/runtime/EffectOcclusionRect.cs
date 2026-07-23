using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

public class EffectOcclusionRect : MonoBehaviour // TypeDefIndex: 37361
{
	// Properties
	public Vector3 Size { get => default; } // 0x0000000189B26F94-0x0000000189B26FDC 
	// Vector3 get_Size()
	Vector3 *EffectOcclusionRect::get_Size(Vector3 *__return_ptr retstr, EffectOcclusionRect *this, MethodInfo *method)
	{
	  Transform *transform; // rax
	  __int64 v5; // rdx
	  __int64 v6; // rcx
	  Vector3 *lossyScale; // rax
	  __int64 v8; // xmm0_8
	  Vector3 v10[2]; // [rsp+20h] [rbp-18h] BYREF
	
	  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
	  if ( !transform )
	    sub_1800D8260(v6, v5);
	  lossyScale = UnityEngine::Transform::get_lossyScale(v10, transform, 0LL);
	  v8 = *(_QWORD *)&lossyScale->x;
	  *(float *)&lossyScale = lossyScale->z;
	  *(_QWORD *)&retstr->x = v8;
	  LODWORD(retstr->z) = (_DWORD)lossyScale;
	  return retstr;
	}
	
	public Vector2 Center { get => default; } // 0x0000000189B269E8-0x0000000189B26A54 
	// Vector2 get_Center()
	Vector2 EffectOcclusionRect::get_Center(EffectOcclusionRect *this, MethodInfo *method)
	{
	  Transform *transform; // rax
	  __int64 v4; // rdx
	  __int64 v5; // rcx
	  __m128 x_low; // xmm6
	  Transform *v7; // rax
	  Vector3 v9; // [rsp+20h] [rbp-28h] BYREF
	
	  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
	  if ( !transform
	    || (x_low = (__m128)LODWORD(UnityEngine::Transform::get_position(&v9, transform, 0LL)->x),
	        (v7 = UnityEngine::Component::get_transform((Component *)this, 0LL)) == 0LL) )
	  {
	    sub_1800D8260(v5, v4);
	  }
	  return (Vector2)_mm_unpacklo_ps(x_low, (__m128)LODWORD(UnityEngine::Transform::get_position(&v9, v7, 0LL)->z)).m128_u64[0];
	}
	
	public Vector2 HalfExtents { get => default; } // 0x0000000189B26F04-0x0000000189B26F5C 
	// Vector2 get_HalfExtents()
	Vector2 EffectOcclusionRect::get_HalfExtents(EffectOcclusionRect *this, MethodInfo *method)
	{
	  Transform *transform; // rax
	  __int64 v3; // rdx
	  __int64 v4; // rcx
	  Vector3 *lossyScale; // rax
	  __m128 z_low; // xmm1
	  __m128 v7; // xmm2
	  Vector3 v9[2]; // [rsp+30h] [rbp-18h] BYREF
	
	  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
	  if ( !transform )
	    sub_1800D8260(v4, v3);
	  lossyScale = UnityEngine::Transform::get_lossyScale(v9, transform, 0LL);
	  z_low = (__m128)LODWORD(lossyScale->z);
	  z_low.m128_f32[0] = z_low.m128_f32[0] * 0.5;
	  v7 = (__m128)(unsigned int)*(_QWORD *)&lossyScale->x;
	  v7.m128_f32[0] = COERCE_FLOAT(*(_QWORD *)&lossyScale->x) * 0.5;
	  return (Vector2)_mm_unpacklo_ps(v7, z_low).m128_u64[0];
	}
	
	public float RotationAngle { get => default; } // 0x0000000189B26F5C-0x0000000189B26F94 
	// Single get_RotationAngle()
	float EffectOcclusionRect::get_RotationAngle(EffectOcclusionRect *this, MethodInfo *method)
	{
	  Transform *transform; // rax
	  __int64 v3; // rdx
	  __int64 v4; // rcx
	  Vector3 v6[2]; // [rsp+20h] [rbp-18h] BYREF
	
	  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
	  if ( !transform )
	    sub_1800D8260(v4, v3);
	  return UnityEngine::Transform::get_eulerAngles(v6, transform, 0LL)->y * 0.017453292;
	}
	

	// Constructors
	public EffectOcclusionRect() {} // 0x0000000185393520-0x0000000185393538
	// Singleton`1[System.Object]()
	void RootMotion::Singleton<System::Object>::Singleton(Singleton_1_System_Object__1 *this, MethodInfo *method)
	{
	  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
	    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
	}
	

	// Methods
	public ValueTuple<Vector4, Vector4, Vector4> GetShaderData(Vector2 circleCenter) => default; // 0x0000000189B26A54-0x0000000189B26BCC
	// ValueTuple`3[UnityEngine.Vector4,UnityEngine.Vector4,UnityEngine.Vector4] GetShaderData(Vector2)
	ValueTuple_3_UnityEngine_Vector4_UnityEngine_Vector4_UnityEngine_Vector4_ *EffectOcclusionRect::GetShaderData(
	        ValueTuple_3_UnityEngine_Vector4_UnityEngine_Vector4_UnityEngine_Vector4_ *__return_ptr retstr,
	        EffectOcclusionRect *this,
	        Vector2 circleCenter,
	        MethodInfo *method)
	{
	  float v4; // xmm1_4
	  float RotationAngle; // xmm0_4
	  Beyond::DampingMath *v9; // rcx
	  Beyond::DampingMath *v10; // rcx
	  Vector2 Center; // rax
	  __int64 v12; // rax
	  unsigned int v13; // xmm6_4
	  ValueTuple_3_UnityEngine_Vector4_UnityEngine_Vector4_UnityEngine_Vector4_ *result; // rax
	  _BYTE v15[24]; // [rsp+28h] [rbp-29h]
	  Vector4 v16; // [rsp+40h] [rbp-11h]
	  Vector4 v17; // [rsp+50h] [rbp-1h]
	  float v18; // [rsp+B8h] [rbp+67h]
	
	  RotationAngle = EffectOcclusionRect::get_RotationAngle(this, 0LL);
	  Beyond::DampingMath::cosf(v9, v4);
	  Beyond::DampingMath::sinf(v10, v4);
	  Center = EffectOcclusionRect::get_Center(this, 0LL);
	  v12 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(circleCenter, Center);
	  *(float *)&v13 = (float)(*(float *)&v12 * RotationAngle) - (float)(*((float *)&v12 + 1) * RotationAngle);
	  circleCenter.x = (float)(*(float *)&v12 * RotationAngle) + (float)(*((float *)&v12 + 1) * RotationAngle);
	  LODWORD(v18) = *(_QWORD *)&EffectOcclusionRect::get_Center(this, 0LL);
	  *(Vector2 *)v15 = EffectOcclusionRect::get_Center(this, 0LL);
	  *(_DWORD *)&v15[8] = *(_QWORD *)&EffectOcclusionRect::get_HalfExtents(this, 0LL);
	  v16.w = 0.0;
	  *(_QWORD *)&v16.y = LODWORD(EffectOcclusionRect::get_HalfExtents(this, 0LL).y);
	  result = retstr;
	  v17.x = v18;
	  *(_QWORD *)&v17.y = *(_QWORD *)&v15[4];
	  *(float *)&v15[12] = -RotationAngle;
	  v17.w = v16.y;
	  *(float *)&v15[8] = RotationAngle;
	  *(_QWORD *)&v15[16] = __PAIR64__(LODWORD(circleCenter.x), v13);
	  v16.x = RotationAngle;
	  v16.y = RotationAngle;
	  retstr->Item1 = v17;
	  retstr->Item2 = *(Vector4 *)&v15[8];
	  retstr->Item3 = v16;
	  return result;
	}
	
	private void OnEnable() {} // 0x0000000189B26EC0-0x0000000189B26F04
	// Void OnEnable()
	void EffectOcclusionRect::OnEnable(EffectOcclusionRect *this, MethodInfo *method)
	{
	  HGVFXManager *instance; // rax
	  __int64 v4; // rdx
	  __int64 v5; // rcx
	
	  if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
	    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
	  instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
	  if ( !instance )
	    sub_1800D8260(v5, v4);
	  HG::Rendering::Runtime::HGVFXManager::RegisterRect(instance, this, 0LL);
	}
	
	private void OnDisable() {} // 0x0000000189B26D10-0x0000000189B26D54
	// Void OnDisable()
	void EffectOcclusionRect::OnDisable(EffectOcclusionRect *this, MethodInfo *method)
	{
	  HGVFXManager *instance; // rax
	  __int64 v4; // rdx
	  __int64 v5; // rcx
	
	  if ( !TypeInfo::HG::Rendering::Runtime::HGVFXManager->_1.cctor_finished_or_no_cctor )
	    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGVFXManager);
	  instance = HG::Rendering::Runtime::HGVFXManager::get_instance(0LL);
	  if ( !instance )
	    sub_1800D8260(v5, v4);
	  HG::Rendering::Runtime::HGVFXManager::UnregisterRect(instance, this, 0LL);
	}
	
	public bool IntersectsCircle(Vector2 circleCenter, float circleRadius) => default; // 0x0000000189B26BCC-0x0000000189B26D10
	// Boolean IntersectsCircle(Vector2, Single)
	bool EffectOcclusionRect::IntersectsCircle(
	        EffectOcclusionRect *this,
	        Vector2 circleCenter,
	        float circleRadius,
	        MethodInfo *method)
	{
	  float v4; // xmm1_4
	  Vector2 Center; // rax
	  Beyond::DampingMath *v9; // rcx
	  float x; // xmm7_4
	  float v11; // xmm0_4
	  Beyond::DampingMath *v12; // rcx
	  __m128 v13; // xmm9
	  __m128 v14; // xmm6
	  Vector2 HalfExtents; // rax
	  __m128 x_low; // xmm3
	  __m128 v17; // xmm1
	  __m128 v18; // xmm0
	  __m128 y_low; // xmm2
	  __int64 v21; // [rsp+20h] [rbp-58h]
	  __int64 v22; // [rsp+20h] [rbp-58h]
	
	  Center = EffectOcclusionRect::get_Center(this, 0LL);
	  v21 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_1858CAD18)(circleCenter, Center);
	  circleCenter.x = EffectOcclusionRect::get_RotationAngle(this, 0LL);
	  Beyond::DampingMath::cosf(v9, v4);
	  x = circleCenter.x;
	  v11 = circleCenter.x;
	  Beyond::DampingMath::sinf(v12, v4);
	  v14 = (__m128)(unsigned int)v21;
	  v13 = (__m128)(unsigned int)v21;
	  v13.m128_f32[0] = (float)(*(float *)&v21 * x) - (float)(*((float *)&v21 + 1) * v11);
	  v14.m128_f32[0] = (float)(*(float *)&v21 * v11) + (float)(*((float *)&v21 + 1) * x);
	  HalfExtents = EffectOcclusionRect::get_HalfExtents(this, 0LL);
	  x_low = v13;
	  v17 = _mm_xor_ps((__m128)LODWORD(HalfExtents.x), (__m128)0x80000000);
	  if ( v17.m128_f32[0] > v13.m128_f32[0] )
	  {
	    x_low = v17;
	  }
	  else if ( v13.m128_f32[0] > HalfExtents.x )
	  {
	    x_low = (__m128)LODWORD(HalfExtents.x);
	  }
	  v18 = _mm_xor_ps((__m128)LODWORD(HalfExtents.y), (__m128)0x80000000);
	  y_low = v14;
	  if ( v18.m128_f32[0] > v14.m128_f32[0] )
	  {
	    y_low = v18;
	  }
	  else if ( v14.m128_f32[0] > HalfExtents.y )
	  {
	    y_low = (__m128)LODWORD(HalfExtents.y);
	  }
	  v22 = sub_1858CAD18(_mm_unpacklo_ps(v13, v14).m128_u64[0], _mm_unpacklo_ps(x_low, y_low).m128_u64[0]);
	  return (float)(circleRadius * circleRadius) >= (float)((float)(*((float *)&v22 + 1) * *((float *)&v22 + 1))
	                                                       + (float)(*(float *)&v22 * *(float *)&v22));
	}
	
	private void OnDrawGizmos() {} // 0x0000000189B26D54-0x0000000189B26EC0
	// Void OnDrawGizmos()
	void EffectOcclusionRect::OnDrawGizmos(EffectOcclusionRect *this, MethodInfo *method)
	{
	  Transform *transform; // rax
	  __int64 v4; // rdx
	  __int64 v5; // rcx
	  __m128i v6; // xmm6
	  Transform *v7; // rax
	  MethodInfo *position; // rax
	  Vector3 *one; // rax
	  __int64 *v10; // rdx
	  __int64 v11; // xmm0_8
	  float z; // ecx
	  __int64 v13; // xmm1_8
	  Matrix4x4 *v14; // rax
	  __int128 v15; // xmm1
	  __int128 v16; // xmm0
	  __int128 v17; // xmm1
	  Animator *v18; // rdx
	  int32_t v19; // r8d
	  MethodInfo *v20; // r9
	  Vector3 *Vector; // rax
	  __int64 v22; // xmm6_8
	  float v23; // ebx
	  Vector3 *Size; // rax
	  Vector3 v25; // [rsp+38h] [rbp-79h] BYREF
	  Vector3 v26; // [rsp+48h] [rbp-69h] BYREF
	  __m128i si128; // [rsp+58h] [rbp-59h] BYREF
	  __m128i v28; // [rsp+68h] [rbp-49h] BYREF
	  Matrix4x4 v29; // [rsp+78h] [rbp-39h] BYREF
	  Matrix4x4 v30; // [rsp+B8h] [rbp+7h] BYREF
	
	  si128 = _mm_load_si128((const __m128i *)&xmmword_18DC81340);
	  UnityEngine::Gizmos::set_color((Color *)&si128, 0LL);
	  transform = UnityEngine::Component::get_transform((Component *)this, 0LL);
	  if ( !transform
	    || (UnityEngine::Transform::get_eulerAngles(&v25, transform, 0LL),
	        v6 = _mm_loadu_si128((const __m128i *)sub_182FA5990(&v28)),
	        (v7 = UnityEngine::Component::get_transform((Component *)this, 0LL)) == 0LL) )
	  {
	    sub_1800D8260(v5, v4);
	  }
	  position = (MethodInfo *)UnityEngine::Transform::get_position((Vector3 *)&si128, v7, 0LL);
	  one = UnityEngine::Vector3::get_one(&v25, position);
	  v11 = *v10;
	  v28 = v6;
	  z = one->z;
	  v13 = *(_QWORD *)&one->x;
	  LODWORD(one) = *((_DWORD *)v10 + 2);
	  v26.z = z;
	  *(_QWORD *)&v26.x = v13;
	  *(_QWORD *)&v25.x = v11;
	  LODWORD(v25.z) = (_DWORD)one;
	  v14 = UnityEngine::Matrix4x4::TRS(&v30, &v25, (Quaternion *)&v28, &v26, 0LL);
	  v15 = *(_OWORD *)&v14->m01;
	  *(_OWORD *)&v29.m00 = *(_OWORD *)&v14->m00;
	  v16 = *(_OWORD *)&v14->m02;
	  *(_OWORD *)&v29.m01 = v15;
	  v17 = *(_OWORD *)&v14->m03;
	  *(_OWORD *)&v29.m02 = v16;
	  *(_OWORD *)&v29.m03 = v17;
	  UnityEngine::Gizmos::set_matrix(&v29, 0LL);
	  Vector = UnityEngine::Animator::GetVector((Vector3 *)&si128, v18, v19, v20);
	  v22 = *(_QWORD *)&Vector->x;
	  v23 = Vector->z;
	  Size = EffectOcclusionRect::get_Size((Vector3 *)&si128, this, 0LL);
	  *(_QWORD *)&v26.x = v22;
	  v26.z = v23;
	  *(_QWORD *)&v16 = *(_QWORD *)&Size->x;
	  *(float *)&Size = Size->z;
	  *(_QWORD *)&v25.x = v16;
	  LODWORD(v25.z) = (_DWORD)Size;
	  UnityEngine::Gizmos::DrawWireCube(&v26, &v25, 0LL);
	}
	
}

