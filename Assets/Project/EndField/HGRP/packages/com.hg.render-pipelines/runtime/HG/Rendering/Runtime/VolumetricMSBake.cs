using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class VolumetricMSBake // TypeDefIndex: 38727
	{
		// Fields
		private MaterialPropertyBlock _propertyBlock; // 0x10
		private RenderTexture _msTexture; // 0x18
		private FMSArgs m_MsArgs; // 0x20
	
		// Properties
		public RenderTexture MSTexture { get => default; private set {} } // 0x0000000189C53FE8-0x0000000189C54038 0x0000000189C54038-0x0000000189C5409C
		// RenderTexture get_MSTexture()
		RenderTexture *HG::Rendering::Runtime::VolumetricMSBake::get_MSTexture(VolumetricMSBake *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5078, 0LL) )
		    return this->fields._msTexture;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5078, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_413(Patch, (Object *)this, 0LL);
		}
		

		// Void set_MSTexture(RenderTexture)
		void HG::Rendering::Runtime::VolumetricMSBake::set_MSTexture(
		        VolumetricMSBake *this,
		        RenderTexture *value,
		        MethodInfo *method)
		{
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  MethodInfo *v11; // [rsp+20h] [rbp-8h]
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5137, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5137, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		      (ILFixDynamicMethodWrapper_39 *)Patch,
		      (Object *)this,
		      (Object *)value,
		      0LL);
		  }
		  else
		  {
		    this->fields._msTexture = value;
		    sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields._msTexture, v5, v6, v7, v11);
		  }
		}
		
	
		// Nested types
		public struct FMSArgs : IEquatable<FMSArgs> // TypeDefIndex: 38726
		{
			// Fields
			public float m_Phase; // 0x00
			public float m_Phase2; // 0x04
			public float m_PhaseBlend; // 0x08
			public int m_MsOctaveCount; // 0x0C
			public float m_MssFactor; // 0x10
			public float m_MseFactor; // 0x14
			public float m_MspFactor; // 0x18
			public float m_OpticalDepthScale; // 0x1C
			public Vector4 m_EncodeParams; // 0x20
	
			// Methods
			[IDTag(0)]
			public bool Equals(FMSArgs other) => default; // 0x0000000189C5069C-0x0000000189C507D8
			// Boolean Equals(VolumetricMSBake+FMSArgs)
			bool HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::Equals(
			        VolumetricMSBake_FMSArgs *this,
			        VolumetricMSBake_FMSArgs *other,
			        MethodInfo *method)
			{
			  MethodInfo *v5; // r8
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v8; // rdx
			  __int64 v9; // rcx
			  __int128 v10; // xmm1
			  Vector4 m_EncodeParams; // xmm0
			  Vector4 v12; // [rsp+20h] [rbp-40h] BYREF
			  VolumetricMSBake_FMSArgs v13; // [rsp+30h] [rbp-30h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5138, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5138, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v9, v8);
			    v10 = *(_OWORD *)&other->m_MssFactor;
			    *(_OWORD *)&v13.m_Phase = *(_OWORD *)&other->m_Phase;
			    m_EncodeParams = other->m_EncodeParams;
			    *(_OWORD *)&v13.m_MssFactor = v10;
			    v13.m_EncodeParams = m_EncodeParams;
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1494(Patch, this, &v13, 0LL);
			  }
			  else if ( System::Single::Equals((Single *)this, COERCE_FLOAT(*(_OWORD *)&other->m_Phase), 0LL)
			         && System::Single::Equals((Single *)&this->m_Phase2, other->m_Phase2, 0LL)
			         && System::Single::Equals((Single *)&this->m_PhaseBlend, other->m_PhaseBlend, 0LL)
			         && this->m_MsOctaveCount == HIDWORD(*(_QWORD *)&other->m_PhaseBlend)
			         && System::Single::Equals((Single *)&this->m_MssFactor, COERCE_FLOAT(*(_OWORD *)&other->m_MssFactor), 0LL)
			         && System::Single::Equals((Single *)&this->m_MseFactor, other->m_MseFactor, 0LL)
			         && System::Single::Equals((Single *)&this->m_MspFactor, other->m_MspFactor, 0LL)
			         && System::Single::Equals((Single *)&this->m_OpticalDepthScale, other->m_OpticalDepthScale, 0LL) )
			  {
			    v12 = other->m_EncodeParams;
			    return Sirenix::Utilities::TypeExtensions::QuaternionEqualityComparer(
			             (Quaternion *)&this->m_EncodeParams,
			             (Quaternion *)&v12,
			             v5);
			  }
			  else
			  {
			    return 0;
			  }
			}
			
			[IDTag(1)]
			public override bool Equals(object obj) => default; // 0x0000000189C507D8-0x0000000189C50874
			// Boolean Equals(Object)
			bool HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::Equals(
			        VolumetricMSBake_FMSArgs *this,
			        Object *obj,
			        MethodInfo *method)
			{
			  _OWORD *v5; // rax
			  __int128 v6; // xmm1
			  Vector4 v7; // xmm0
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v10; // rdx
			  __int64 v11; // rcx
			  VolumetricMSBake_FMSArgs v12; // [rsp+20h] [rbp-38h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5139, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5139, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v11, v10);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1495(Patch, this, obj, 0LL);
			  }
			  else if ( obj
			         && (struct VolumetricMSBake_FMSArgs__Class *)obj->klass == TypeInfo::HG::Rendering::Runtime::VolumetricMSBake::FMSArgs )
			  {
			    v5 = (_OWORD *)sub_1800422D0(obj);
			    v6 = v5[1];
			    *(_OWORD *)&v12.m_Phase = *v5;
			    v7 = (Vector4)v5[2];
			    *(_OWORD *)&v12.m_MssFactor = v6;
			    v12.m_EncodeParams = v7;
			    return HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::Equals(this, &v12, 0LL);
			  }
			  else
			  {
			    return 0;
			  }
			}
			
			public override int GetHashCode() => default; // 0x0000000189C50874-0x0000000189C509BC
			// Int32 GetHashCode()
			int32_t HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::GetHashCode(
			        VolumetricMSBake_FMSArgs *this,
			        MethodInfo *method)
			{
			  float m_Phase; // xmm6_4
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v6; // rdx
			  __int64 v7; // rcx
			  Vector4 m_EncodeParams; // [rsp+20h] [rbp-40h] BYREF
			  HashCode v9; // [rsp+30h] [rbp-30h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5140, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5140, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v7, v6);
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1496(Patch, this, 0LL);
			  }
			  else
			  {
			    m_Phase = this->m_Phase;
			    memset(&v9, 0, sizeof(v9));
			    sub_1800036A0(TypeInfo::System::HashCode);
			    System::HashCode::Add<float>(&v9, m_Phase, MethodInfo::System::HashCode::Add<float>);
			    System::HashCode::Add<float>(&v9, this->m_Phase2, MethodInfo::System::HashCode::Add<float>);
			    System::HashCode::Add<float>(&v9, this->m_PhaseBlend, MethodInfo::System::HashCode::Add<float>);
			    System::HashCode::Add<unsigned int>(&v9, this->m_MsOctaveCount, MethodInfo::System::HashCode::Add<int>);
			    System::HashCode::Add<float>(&v9, this->m_MssFactor, MethodInfo::System::HashCode::Add<float>);
			    System::HashCode::Add<float>(&v9, this->m_MseFactor, MethodInfo::System::HashCode::Add<float>);
			    System::HashCode::Add<float>(&v9, this->m_MspFactor, MethodInfo::System::HashCode::Add<float>);
			    System::HashCode::Add<float>(&v9, this->m_OpticalDepthScale, MethodInfo::System::HashCode::Add<float>);
			    m_EncodeParams = this->m_EncodeParams;
			    System::HashCode::Add<UnityEngine::Vector4>(
			      &v9,
			      &m_EncodeParams,
			      MethodInfo::System::HashCode::Add<UnityEngine::Vector4>);
			    return System::HashCode::ToHashCode(&v9, 0LL);
			  }
			}
			
			public static bool operator ==(FMSArgs a, FMSArgs b) => default; // 0x0000000189C50A44-0x0000000189C50D30
			// Boolean op_Equality(VolumetricMSBake+FMSArgs, VolumetricMSBake+FMSArgs)
			bool HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::op_Equality(
			        VolumetricMSBake_FMSArgs *a,
			        VolumetricMSBake_FMSArgs *b,
			        MethodInfo *method)
			{
			  __int32 v5; // xmm4_4
			  Mathf__StaticFields *static_fields; // rax
			  float v7; // xmm3_4
			  float v8; // xmm2_4
			  float v9; // xmm3_4
			  float v10; // xmm2_4
			  Mathf__StaticFields *v11; // rax
			  float v12; // xmm3_4
			  float v13; // xmm2_4
			  float v14; // xmm3_4
			  float v15; // xmm2_4
			  float v16; // xmm3_4
			  float v17; // xmm2_4
			  Vector4 v18; // xmm5
			  Vector4 v19; // xmm2
			  float v20; // xmm4_4
			  float v21; // xmm1_4
			  float v22; // xmm1_4
			  float v23; // xmm3_4
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v26; // rdx
			  __int64 v27; // rcx
			  __int128 v28; // xmm1
			  Vector4 m_EncodeParams; // xmm0
			  __int128 v30; // xmm1
			  __int128 v31; // xmm0
			  Vector4 v32; // xmm1
			  VolumetricMSBake_FMSArgs v33; // [rsp+28h] [rbp-19h] BYREF
			  VolumetricMSBake_FMSArgs v34; // [rsp+58h] [rbp+17h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5077, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5077, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v27, v26);
			    v28 = *(_OWORD *)&b->m_MssFactor;
			    *(_OWORD *)&v33.m_Phase = *(_OWORD *)&b->m_Phase;
			    m_EncodeParams = b->m_EncodeParams;
			    *(_OWORD *)&v33.m_MssFactor = v28;
			    v30 = *(_OWORD *)&a->m_Phase;
			    v33.m_EncodeParams = m_EncodeParams;
			    v31 = *(_OWORD *)&a->m_MssFactor;
			    *(_OWORD *)&v34.m_Phase = v30;
			    v32 = a->m_EncodeParams;
			    *(_OWORD *)&v34.m_MssFactor = v31;
			    v34.m_EncodeParams = v32;
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1478(Patch, &v34, &v33, 0LL);
			  }
			  else
			  {
			    COERCE_FLOAT(v5 = _mm_load_si128((const __m128i *)&xmmword_18B9592D0).m128i_i32[0]);
			    static_fields = TypeInfo::UnityEngine::Mathf->static_fields;
			    if ( fmaxf(
			           fmaxf(COERCE_FLOAT(LODWORD(a->m_Phase) & v5), COERCE_FLOAT(LODWORD(b->m_Phase) & v5)) * 0.000001,
			           static_fields->Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(
			                                                           COERCE_FLOAT(*(_OWORD *)&b->m_Phase)
			                                                         - COERCE_FLOAT(*(_OWORD *)&a->m_Phase)) & v5) )
			      return 0;
			    v7 = _mm_shuffle_ps(*(__m128 *)&a->m_Phase, *(__m128 *)&a->m_Phase, 85).m128_f32[0];
			    v8 = _mm_shuffle_ps(*(__m128 *)&b->m_Phase, *(__m128 *)&b->m_Phase, 85).m128_f32[0];
			    if ( fmaxf(
			           fmaxf(COERCE_FLOAT(LODWORD(v7) & v5), COERCE_FLOAT(LODWORD(v8) & v5)) * 0.000001,
			           static_fields->Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(v8 - v7) & v5) )
			      return 0;
			    v9 = _mm_shuffle_ps(*(__m128 *)&a->m_Phase, *(__m128 *)&a->m_Phase, 170).m128_f32[0];
			    v10 = _mm_shuffle_ps(*(__m128 *)&b->m_Phase, *(__m128 *)&b->m_Phase, 170).m128_f32[0];
			    if ( fmaxf(
			           fmaxf(COERCE_FLOAT(LODWORD(v9) & v5), COERCE_FLOAT(LODWORD(v10) & v5)) * 0.000001,
			           static_fields->Epsilon * 8.0) <= COERCE_FLOAT(COERCE_UNSIGNED_INT(v10 - v9) & v5) )
			      return 0;
			    if ( HIDWORD(*(_QWORD *)&a->m_PhaseBlend) == HIDWORD(*(_QWORD *)&b->m_PhaseBlend)
			      && (v11 = TypeInfo::UnityEngine::Mathf->static_fields,
			          fmaxf(
			            fmaxf(COERCE_FLOAT(*(_OWORD *)&a->m_MssFactor & v5), COERCE_FLOAT(LODWORD(b->m_MssFactor) & v5)) * 0.000001,
			            v11->Epsilon * 8.0) > COERCE_FLOAT(COERCE_UNSIGNED_INT(
			                                                 COERCE_FLOAT(*(_OWORD *)&b->m_MssFactor)
			                                               - COERCE_FLOAT(*(_OWORD *)&a->m_MssFactor)) & v5))
			      && (v12 = _mm_shuffle_ps(*(__m128 *)&a->m_MssFactor, *(__m128 *)&a->m_MssFactor, 85).m128_f32[0],
			          v13 = _mm_shuffle_ps(*(__m128 *)&b->m_MssFactor, *(__m128 *)&b->m_MssFactor, 85).m128_f32[0],
			          fmaxf(fmaxf(COERCE_FLOAT(LODWORD(v12) & v5), COERCE_FLOAT(LODWORD(v13) & v5)) * 0.000001, v11->Epsilon * 8.0) > COERCE_FLOAT(COERCE_UNSIGNED_INT(v13 - v12) & v5))
			      && (v14 = _mm_shuffle_ps(*(__m128 *)&a->m_MssFactor, *(__m128 *)&a->m_MssFactor, 170).m128_f32[0],
			          v15 = _mm_shuffle_ps(*(__m128 *)&b->m_MssFactor, *(__m128 *)&b->m_MssFactor, 170).m128_f32[0],
			          fmaxf(fmaxf(COERCE_FLOAT(LODWORD(v14) & v5), COERCE_FLOAT(LODWORD(v15) & v5)) * 0.000001, v11->Epsilon * 8.0) > COERCE_FLOAT(COERCE_UNSIGNED_INT(v15 - v14) & v5))
			      && (v16 = _mm_shuffle_ps(*(__m128 *)&a->m_MssFactor, *(__m128 *)&a->m_MssFactor, 255).m128_f32[0],
			          v17 = _mm_shuffle_ps(*(__m128 *)&b->m_MssFactor, *(__m128 *)&b->m_MssFactor, 255).m128_f32[0],
			          fmaxf(fmaxf(COERCE_FLOAT(LODWORD(v16) & v5), COERCE_FLOAT(LODWORD(v17) & v5)) * 0.000001, v11->Epsilon * 8.0) > COERCE_FLOAT(COERCE_UNSIGNED_INT(v17 - v16) & v5)) )
			    {
			      v18 = a->m_EncodeParams;
			      v19 = b->m_EncodeParams;
			      v20 = _mm_shuffle_ps((__m128)v18, (__m128)v18, 85).m128_f32[0]
			          - _mm_shuffle_ps((__m128)v19, (__m128)v19, 85).m128_f32[0];
			      v21 = _mm_shuffle_ps((__m128)v18, (__m128)v18, 170).m128_f32[0];
			      v18.x = _mm_shuffle_ps((__m128)v18, (__m128)v18, 255).m128_f32[0];
			      v22 = v21 - _mm_shuffle_ps((__m128)v19, (__m128)v19, 170).m128_f32[0];
			      v23 = (float)(COERCE_FLOAT(*(_OWORD *)&a->m_EncodeParams) - v19.x)
			          * (float)(COERCE_FLOAT(*(_OWORD *)&a->m_EncodeParams) - v19.x);
			      v19.x = _mm_shuffle_ps((__m128)v19, (__m128)v19, 255).m128_f32[0];
			      return (float)((float)((float)((float)(v20 * v20) + v23) + (float)(v22 * v22))
			                   + (float)((float)(v18.x - v19.x) * (float)(v18.x - v19.x))) < 9.9999994e-11;
			    }
			    else
			    {
			      return 0;
			    }
			  }
			}
			
			public static bool operator !=(FMSArgs a, FMSArgs b) => default; // 0x0000000189C50D30-0x0000000189C50E0C
			// Boolean op_Inequality(VolumetricMSBake+FMSArgs, VolumetricMSBake+FMSArgs)
			bool HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::op_Inequality(
			        VolumetricMSBake_FMSArgs *a,
			        VolumetricMSBake_FMSArgs *b,
			        MethodInfo *method)
			{
			  __int128 v5; // xmm1
			  Vector4 v6; // xmm0
			  __int128 v7; // xmm1
			  __int128 v8; // xmm0
			  Vector4 v9; // xmm1
			  ILFixDynamicMethodWrapper_2 *Patch; // rax
			  __int64 v12; // rdx
			  __int64 v13; // rcx
			  __int128 v14; // xmm1
			  Vector4 m_EncodeParams; // xmm0
			  __int128 v16; // xmm1
			  __int128 v17; // xmm0
			  Vector4 v18; // xmm1
			  VolumetricMSBake_FMSArgs v19; // [rsp+20h] [rbp-60h] BYREF
			  VolumetricMSBake_FMSArgs v20; // [rsp+50h] [rbp-30h] BYREF
			
			  if ( IFix::WrappersManagerImpl::IsPatched(5076, 0LL) )
			  {
			    Patch = IFix::WrappersManagerImpl::GetPatch(5076, 0LL);
			    if ( !Patch )
			      sub_1800D8260(v13, v12);
			    v14 = *(_OWORD *)&b->m_MssFactor;
			    *(_OWORD *)&v20.m_Phase = *(_OWORD *)&b->m_Phase;
			    m_EncodeParams = b->m_EncodeParams;
			    *(_OWORD *)&v20.m_MssFactor = v14;
			    v16 = *(_OWORD *)&a->m_Phase;
			    v20.m_EncodeParams = m_EncodeParams;
			    v17 = *(_OWORD *)&a->m_MssFactor;
			    *(_OWORD *)&v19.m_Phase = v16;
			    v18 = a->m_EncodeParams;
			    *(_OWORD *)&v19.m_MssFactor = v17;
			    v19.m_EncodeParams = v18;
			    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1478(Patch, &v19, &v20, 0LL);
			  }
			  else
			  {
			    v5 = *(_OWORD *)&b->m_MssFactor;
			    *(_OWORD *)&v19.m_Phase = *(_OWORD *)&b->m_Phase;
			    v6 = b->m_EncodeParams;
			    *(_OWORD *)&v19.m_MssFactor = v5;
			    v7 = *(_OWORD *)&a->m_Phase;
			    v19.m_EncodeParams = v6;
			    v8 = *(_OWORD *)&a->m_MssFactor;
			    *(_OWORD *)&v20.m_Phase = v7;
			    v9 = a->m_EncodeParams;
			    *(_OWORD *)&v20.m_MssFactor = v8;
			    v20.m_EncodeParams = v9;
			    return !HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::op_Equality(&v20, &v19, 0LL);
			  }
			}
			
			public bool __iFixBaseProxy_Equals(object P0) => default; // 0x0000000189C509BC-0x0000000189C50A04
			// Boolean <>iFixBaseProxy_Equals(Object)
			bool HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::__iFixBaseProxy_Equals(
			        VolumetricMSBake_FMSArgs *this,
			        Object *P0,
			        MethodInfo *method)
			{
			  __int128 v4; // xmm1
			  Vector4 m_EncodeParams; // xmm0
			  Object *v6; // rax
			  _OWORD v8[3]; // [rsp+20h] [rbp-38h] BYREF
			
			  v4 = *(_OWORD *)&this->m_MssFactor;
			  v8[0] = *(_OWORD *)&this->m_Phase;
			  m_EncodeParams = this->m_EncodeParams;
			  v8[1] = v4;
			  v8[2] = m_EncodeParams;
			  v6 = (Object *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::VolumetricMSBake::FMSArgs, v8);
			  return System::ValueType::DefaultEquals(v6, P0, 0LL);
			}
			
			public int __iFixBaseProxy_GetHashCode() => default; // 0x0000000189C50A04-0x0000000189C50A44
			// Int32 <>iFixBaseProxy_GetHashCode()
			int32_t HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::__iFixBaseProxy_GetHashCode(
			        VolumetricMSBake_FMSArgs *this,
			        MethodInfo *method)
			{
			  __int128 v2; // xmm1
			  Vector4 m_EncodeParams; // xmm0
			  ValueType *v4; // rax
			  _OWORD v6[3]; // [rsp+20h] [rbp-38h] BYREF
			
			  v2 = *(_OWORD *)&this->m_MssFactor;
			  v6[0] = *(_OWORD *)&this->m_Phase;
			  m_EncodeParams = this->m_EncodeParams;
			  v6[1] = v2;
			  v6[2] = m_EncodeParams;
			  v4 = (ValueType *)il2cpp_value_box_0(TypeInfo::HG::Rendering::Runtime::VolumetricMSBake::FMSArgs, v6);
			  return System::ValueType::GetHashCode(v4, 0LL);
			}
			
		}
	
		// Constructors
		public VolumetricMSBake() {} // 0x00000001841E1670-0x00000001841E1680
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
		public void Release() {} // 0x0000000189C53F88-0x0000000189C53FE8
		// Void Release()
		void HG::Rendering::Runtime::VolumetricMSBake::Release(VolumetricMSBake *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5053, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5053, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    HG::Rendering::Runtime::VolumetricSDFUtils::ReleaseRenderTexture(&this->fields._msTexture, 0LL);
		  }
		}
		
		public void BakeMSTexture(CommandBuffer cmd, int sizeX, int sizeY, FMSArgs msArgs, Material cloudMat, bool force = false /* Metadata: 0x023040CB */) {} // 0x0000000189C53C48-0x0000000189C53F88
		// Void BakeMSTexture(CommandBuffer, Int32, Int32, VolumetricMSBake+FMSArgs, Material, Boolean)
		void HG::Rendering::Runtime::VolumetricMSBake::BakeMSTexture(
		        VolumetricMSBake *this,
		        CommandBuffer *cmd,
		        int32_t sizeX,
		        int32_t sizeY,
		        VolumetricMSBake_FMSArgs *msArgs,
		        Material *cloudMat,
		        bool force,
		        MethodInfo *method)
		{
		  VolumetricShaderIDs__StaticFields *static_fields; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  MaterialPropertyBlock *v14; // rdi
		  HGRuntimeGrassQuery_Node *v15; // rdx
		  HGRuntimeGrassQuery_Node *v16; // r8
		  Int32__Array **v17; // r9
		  BOOL v18; // ecx
		  __int128 v19; // xmm1
		  Vector4 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  Vector4 v23; // xmm1
		  __int128 v24; // xmm1
		  Vector4 v25; // xmm0
		  MaterialPropertyBlock *propertyBlock; // rdi
		  Texture *MSTexture; // rax
		  RenderTargetIdentifier *v28; // rax
		  __int128 v29; // xmm7
		  __int128 v30; // xmm8
		  __int64 v31; // xmm6_8
		  MaterialPropertyBlock *v32; // rax
		  __int128 v33; // xmm1
		  __int128 v34; // xmm0
		  __int128 v35; // xmm1
		  __int128 v36; // xmm1
		  Vector4 m_EncodeParams; // xmm0
		  MethodInfo *v38; // [rsp+28h] [rbp-B9h]
		  Matrix4x4 v39; // [rsp+58h] [rbp-89h] BYREF
		  RenderTextureDescriptor v40[2]; // [rsp+98h] [rbp-49h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(5073, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(5073, 0LL);
		    if ( !Patch )
		      goto LABEL_14;
		    v36 = *(_OWORD *)&msArgs->m_MssFactor;
		    *(_OWORD *)&v39.m00 = *(_OWORD *)&msArgs->m_Phase;
		    m_EncodeParams = msArgs->m_EncodeParams;
		    *(_OWORD *)&v39.m01 = v36;
		    *(Vector4 *)&v39.m02 = m_EncodeParams;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1479(
		      Patch,
		      (Object *)this,
		      (Object *)cmd,
		      sizeX,
		      sizeY,
		      (VolumetricMSBake_FMSArgs *)&v39,
		      (Object *)cloudMat,
		      force,
		      0LL);
		  }
		  else
		  {
		    if ( !this->fields._propertyBlock )
		    {
		      v14 = (MaterialPropertyBlock *)sub_18002C620(TypeInfo::UnityEngine::MaterialPropertyBlock);
		      if ( !v14 )
		        goto LABEL_14;
		      v14->fields.m_Ptr = UnityEngine::MaterialPropertyBlock::CreateImpl(0LL);
		      this->fields._propertyBlock = v14;
		      sub_18002D1B0((HGRuntimeGrassQuery_Node *)&this->fields, v15, v16, v17, v38);
		    }
		    memset(&v39, 0, 52);
		    UnityEngine::RenderTextureDescriptor::RenderTextureDescriptor(
		      (RenderTextureDescriptor *)&v39,
		      sizeX,
		      sizeY,
		      RenderTextureFormat__Enum_RHalf,
		      0LL);
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricSDFUtils);
		    *(_OWORD *)&v40[0]._width_k__BackingField = *(_OWORD *)&v39.m00;
		    v40[0]._memoryless_k__BackingField = LODWORD(v39.m03);
		    *(_OWORD *)&v40[0]._mipCount_k__BackingField = *(_OWORD *)&v39.m01;
		    *(_OWORD *)&v40[0]._dimension_k__BackingField = *(_OWORD *)&v39.m02;
		    if ( HG::Rendering::Runtime::VolumetricSDFUtils::CreateRenderTextureIfNeeded(&this->fields._msTexture, v40, 0LL) )
		    {
		      v18 = 1;
		    }
		    else
		    {
		      v19 = *(_OWORD *)&msArgs->m_MssFactor;
		      *(_OWORD *)&v40[0]._width_k__BackingField = *(_OWORD *)&msArgs->m_Phase;
		      v20 = msArgs->m_EncodeParams;
		      *(_OWORD *)&v40[0]._mipCount_k__BackingField = v19;
		      v21 = *(_OWORD *)&this->fields.m_MsArgs.m_Phase;
		      *(Vector4 *)&v40[0]._dimension_k__BackingField = v20;
		      v22 = *(_OWORD *)&this->fields.m_MsArgs.m_MssFactor;
		      *(_OWORD *)&v39.m00 = v21;
		      v23 = this->fields.m_MsArgs.m_EncodeParams;
		      *(_OWORD *)&v39.m01 = v22;
		      *(Vector4 *)&v39.m02 = v23;
		      v18 = HG::Rendering::Runtime::VolumetricMSBake::FMSArgs::op_Inequality(
		              (VolumetricMSBake_FMSArgs *)&v39,
		              (VolumetricMSBake_FMSArgs *)v40,
		              0LL);
		    }
		    if ( v18 || force )
		    {
		      v24 = *(_OWORD *)&msArgs->m_MssFactor;
		      *(_OWORD *)&this->fields.m_MsArgs.m_Phase = *(_OWORD *)&msArgs->m_Phase;
		      v25 = msArgs->m_EncodeParams;
		      propertyBlock = this->fields._propertyBlock;
		      *(_OWORD *)&this->fields.m_MsArgs.m_MssFactor = v24;
		      this->fields.m_MsArgs.m_EncodeParams = v25;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs);
		      static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		      if ( propertyBlock )
		      {
		        UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		          propertyBlock,
		          static_fields->_OpticalDepthScale,
		          this->fields.m_MsArgs.m_OpticalDepthScale,
		          0LL);
		        Patch = (ILFixDynamicMethodWrapper_2 *)this->fields._propertyBlock;
		        static_fields = TypeInfo::HG::Rendering::Runtime::VolumetricShaderIDs->static_fields;
		        if ( Patch )
		        {
		          UnityEngine::MaterialPropertyBlock::SetFloatImpl(
		            (MaterialPropertyBlock *)Patch,
		            static_fields->_InvOpticalDepthScale,
		            1.0 / this->fields.m_MsArgs.m_OpticalDepthScale,
		            0LL);
		          MSTexture = (Texture *)HG::Rendering::Runtime::VolumetricMSBake::get_MSTexture(this, 0LL);
		          v28 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
		                  (RenderTargetIdentifier *)v40,
		                  MSTexture,
		                  0LL);
		          v29 = *(_OWORD *)&v28->m_Type;
		          v30 = *(_OWORD *)&v28->m_BufferPointer;
		          v31 = *(_QWORD *)&v28->m_DepthSlice;
		          sub_1800036A0(TypeInfo::UnityEngine::Rendering::CoreUtils);
		          *(_OWORD *)&v40[0]._width_k__BackingField = v29;
		          *(_OWORD *)&v40[0]._mipCount_k__BackingField = v30;
		          *(_QWORD *)&v40[0]._dimension_k__BackingField = v31;
		          UnityEngine::Rendering::CoreUtils::SetRenderTarget(
		            cmd,
		            (RenderTargetIdentifier *)v40,
		            ClearFlag__Enum_None,
		            0,
		            CubemapFace__Enum_Unknown,
		            -1,
		            0LL);
		          Patch = (ILFixDynamicMethodWrapper_2 *)TypeInfo::UnityEngine::Matrix4x4->static_fields;
		          v32 = this->fields._propertyBlock;
		          if ( cmd )
		          {
		            v33 = *(_OWORD *)&Patch[2].klass;
		            *(_OWORD *)&v39.m00 = *(_OWORD *)&Patch[1].fields.methodId;
		            v34 = *(_OWORD *)&Patch[2].fields.virtualMachine;
		            *(_OWORD *)&v39.m01 = v33;
		            v35 = *(_OWORD *)&Patch[2].fields.anonObj;
		            *(_OWORD *)&v39.m02 = v34;
		            *(_OWORD *)&v39.m03 = v35;
		            UnityEngine::Rendering::CommandBuffer::DrawProcedural(
		              cmd,
		              &v39,
		              cloudMat,
		              12,
		              MeshTopology__Enum_Triangles,
		              3,
		              1,
		              v32,
		              0LL);
		            return;
		          }
		        }
		      }
		LABEL_14:
		      sub_1800D8260(Patch, static_fields);
		    }
		  }
		}
		
	}
}
