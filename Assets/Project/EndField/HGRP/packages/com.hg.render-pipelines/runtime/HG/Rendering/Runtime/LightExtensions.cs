using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using Unity.Mathematics;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class LightExtensions // TypeDefIndex: 37761
	{
		// Fields
		private const float CHARACTER_MAIN_LIGHT_CLAMP_MIN = 0.75f; // Metadata: 0x02303096
		private const float CHARACTER_MAIN_LIGHT_CLAMP_MAX = 1.25f; // Metadata: 0x0230309A
		private const float CHARACTER_MAIN_SATURATION_CLAMP_MIN = 0.35f; // Metadata: 0x0230309E
		private const float CHARACTER_MAIN_SATURATION_CLAMP_MAX = 0.7f; // Metadata: 0x023030A2
	
		// Methods
		private static float3 RgbToHsv(float3 c) => default; // 0x0000000189D043C0-0x0000000189D045A0
		// float3 RgbToHsv(float3)
		float3 *HG::Rendering::Runtime::LightExtensions::RgbToHsv(float3 *__return_ptr retstr, float3 *c, MethodInfo *method)
		{
		  float v5; // xmm0_4
		  float y; // xmm1_4
		  const __m128i *v7; // rax
		  __m128 v8; // xmm4
		  __m128 v9; // xmm5
		  float v10; // xmm4_4
		  __m128i v11; // xmm1
		  float v12; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v14; // rcx
		  float z; // eax
		  float3 *v16; // rax
		  __int64 v17; // xmm0_8
		  unsigned __int64 v19; // [rsp+30h] [rbp-30h] BYREF
		  __int64 v20; // [rsp+38h] [rbp-28h]
		  float3 v21; // [rsp+40h] [rbp-20h] BYREF
		  int v22; // [rsp+4Ch] [rbp-14h]
		  _BYTE v23[16]; // [rsp+50h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1856, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1856, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, 0LL);
		    z = c->z;
		    v19 = *(_QWORD *)&c->x;
		    *(float *)&v20 = z;
		    v16 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_746(&v21, Patch, (float3 *)&v19, 0LL);
		    v17 = *(_QWORD *)&v16->x;
		    *(float *)&v16 = v16->z;
		    *(_QWORD *)&retstr->x = v17;
		    LODWORD(retstr->z) = (_DWORD)v16;
		  }
		  else
		  {
		    v5 = c->z;
		    y = c->y;
		    v20 = 0x3F2AAAABBF800000LL;
		    v22 = -1096111445;
		    v19 = __PAIR64__(LODWORD(y), LODWORD(v5));
		    v21.x = y;
		    *(_QWORD *)&v21.y = LODWORD(v5);
		    v7 = (const __m128i *)sub_185F178F0(v23, &v19, &v21);
		    HIDWORD(v20) = LODWORD(c->x);
		    v21.x = *((float *)&v20 + 1);
		    v8 = (__m128)_mm_loadu_si128(v7);
		    LODWORD(v19) = v8.m128_i32[0];
		    LODWORD(v20) = _mm_shuffle_ps(v8, v8, 255).m128_u32[0];
		    LODWORD(v21.z) = _mm_shuffle_ps(v8, v8, 170).m128_u32[0];
		    HIDWORD(v19) = _mm_shuffle_ps(v8, v8, 85).m128_u32[0];
		    v21.y = *((float *)&v19 + 1);
		    v22 = v8.m128_i32[0];
		    v9 = (__m128)_mm_loadu_si128((const __m128i *)sub_185F178F0(v23, &v19, &v21));
		    v10 = _mm_shuffle_ps(v9, v9, 85).m128_f32[0];
		    v11 = (__m128i)_mm_shuffle_ps(v9, v9, 255);
		    if ( v10 > *(float *)v11.m128i_i32 )
		      v12 = *(float *)v11.m128i_i32;
		    else
		      v12 = v10;
		    LODWORD(retstr->z) = v9.m128_i32[0];
		    *(float *)v11.m128i_i32 = (float)((float)(*(float *)v11.m128i_i32 - v10)
		                                    / (float)((float)((float)(v9.m128_f32[0] - v12) * 6.0) + 0.000099999997))
		                            + _mm_shuffle_ps(v9, v9, 170).m128_f32[0];
		    LODWORD(retstr->x) = _mm_cvtsi128_si32(v11) & 0x7FFFFFFF;
		    retstr->y = (float)(v9.m128_f32[0] - v12) / (float)(v9.m128_f32[0] + 0.000099999997);
		  }
		  return retstr;
		}
		
		private static float3 HsvToRgb(float3 c) => default; // 0x0000000189D041A8-0x0000000189D043C0
		// float3 HsvToRgb(float3)
		float3 *HG::Rendering::Runtime::LightExtensions::HsvToRgb(float3 *__return_ptr retstr, float3 *c, MethodInfo *method)
		{
		  MethodInfo *v5; // r9
		  __m128 x_low; // xmm3
		  float3 *v7; // rax
		  __int64 v8; // xmm2_8
		  MethodInfo *v9; // r8
		  float3 *v10; // rax
		  __int64 v11; // xmm0_8
		  MethodInfo *v12; // r9
		  float3 *v13; // rax
		  MethodInfo *v14; // r9
		  float3 *v15; // rax
		  __int64 v16; // xmm2_8
		  MethodInfo *v17; // r8
		  float3 *v18; // rax
		  __int64 v19; // xmm0_8
		  MethodInfo *v20; // r9
		  float3 *v21; // rax
		  __int64 v22; // xmm2_8
		  MethodInfo *v23; // r8
		  float3 *v24; // rax
		  __int64 v25; // xmm4_8
		  float3 *v26; // rax
		  float v27; // xmm1_4
		  __int64 v28; // xmm4_8
		  MethodInfo *v29; // r9
		  float3 *v30; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v32; // rcx
		  float z; // eax
		  __int64 v34; // xmm0_8
		  float v35; // eax
		  MethodInfo *v37; // [rsp+20h] [rbp-50h]
		  float3 v38; // [rsp+30h] [rbp-40h] BYREF
		  float3 v39; // [rsp+40h] [rbp-30h] BYREF
		  float3 v40; // [rsp+50h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1857, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1857, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v32, 0LL);
		    z = c->z;
		    *(_QWORD *)&v39.x = *(_QWORD *)&c->x;
		    v39.z = z;
		    v30 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_746(&v40, Patch, &v39, 0LL);
		  }
		  else
		  {
		    x_low = (__m128)LODWORD(c->x);
		    *(_QWORD *)&v38.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F2AAAABu).m128_u64[0];
		    *(_QWORD *)&v39.x = _mm_unpacklo_ps(x_low, x_low).m128_u64[0];
		    v38.z = 0.33333334;
		    LODWORD(v39.z) = x_low.m128_i32[0];
		    v7 = Unity::Mathematics::float3::op_Addition(&v40, &v39, &v38, v5);
		    v8 = *(_QWORD *)&v7->x;
		    *(float *)&v7 = v7->z;
		    *(_QWORD *)&v39.x = v8;
		    LODWORD(v39.z) = (_DWORD)v7;
		    v10 = Unity::Mathematics::math::frac(&v40, &v39, v9);
		    v38.z = 3.0;
		    v11 = *(_QWORD *)&v10->x;
		    *(float *)&v10 = v10->z;
		    *(_QWORD *)&v39.x = v11;
		    *(_QWORD *)&v38.x = _mm_unpacklo_ps((__m128)0x40400000u, (__m128)0x40400000u).m128_u64[0];
		    LODWORD(v39.z) = (_DWORD)v10;
		    v13 = Unity::Mathematics::float3::op_Multiply(&v40, &v39, 6.0, v12);
		    x_low.m128_u64[0] = *(_QWORD *)&v13->x;
		    *(float *)&v13 = v13->z;
		    *(_QWORD *)&v39.x = x_low.m128_u64[0];
		    LODWORD(v39.z) = (_DWORD)v13;
		    v15 = Unity::Mathematics::float3::op_Subtraction(&v40, &v39, &v38, v14);
		    v16 = *(_QWORD *)&v15->x;
		    *(float *)&v15 = v15->z;
		    *(_QWORD *)&v39.x = v16;
		    LODWORD(v39.z) = (_DWORD)v15;
		    v18 = Unity::Mathematics::math::abs(&v40, &v39, v17);
		    v39.z = 1.0;
		    *(_QWORD *)&v39.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		    v19 = *(_QWORD *)&v18->x;
		    *(float *)&v18 = v18->z;
		    *(_QWORD *)&v38.x = v19;
		    LODWORD(v38.z) = (_DWORD)v18;
		    v21 = Unity::Mathematics::float3::op_Subtraction(&v40, &v38, &v39, v20);
		    v22 = *(_QWORD *)&v21->x;
		    *(float *)&v21 = v21->z;
		    *(_QWORD *)&v39.x = v22;
		    LODWORD(v39.z) = (_DWORD)v21;
		    v24 = Unity::Mathematics::math::saturate(&v40, &v39, v23);
		    x_low.m128_i32[0] = LODWORD(c->y);
		    v38.z = 1.0;
		    v25 = *(_QWORD *)&v24->x;
		    *(float *)&v24 = v24->z;
		    *(_QWORD *)&v39.x = v25;
		    LODWORD(v39.z) = (_DWORD)v24;
		    *(_QWORD *)&v38.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
		    v26 = Unity::Mathematics::math::lerp(&v40, &v38, &v39, x_low.m128_f32[0], v37);
		    v27 = c->z;
		    v28 = *(_QWORD *)&v26->x;
		    *(float *)&v26 = v26->z;
		    *(_QWORD *)&v39.x = v28;
		    LODWORD(v39.z) = (_DWORD)v26;
		    v30 = Unity::Mathematics::float3::op_Multiply(&v40, v27, &v39, v29);
		  }
		  v34 = *(_QWORD *)&v30->x;
		  v35 = v30->z;
		  *(_QWORD *)&retstr->x = v34;
		  retstr->z = v35;
		  return retstr;
		}
		
		[IDTag(0)]
		public static float4 GetCharacterLightColorAndIntensity(HGCamera hgCamera, UnityEngine.Color lightColor, float originalIntensity) => default; // 0x0000000189D03AE8-0x0000000189D03DB8
		// float4 GetCharacterLightColorAndIntensity(HGCamera, Color, Single)
		float4 *HG::Rendering::Runtime::LightExtensions::GetCharacterLightColorAndIntensity(
		        float4 *__return_ptr retstr,
		        HGCamera *hgCamera,
		        Color *lightColor,
		        float originalIntensity,
		        MethodInfo *method)
		{
		  MethodInfo *v8; // r8
		  __m128 v9; // xmm0
		  float3 *v10; // rax
		  __int64 v11; // rcx
		  float v12; // xmm4_4
		  __m128 y_low; // xmm2
		  float v14; // xmm7_4
		  float3 *v15; // rax
		  BoolParameter *charLightDialogMode; // rdx
		  __int64 v17; // rcx
		  float z; // esi
		  float v19; // xmm6_4
		  HGCamera_VolumeComponentsData *volumeComponentsData; // rax
		  HGCharacterVolume *m_hgCharacterVolume; // rax
		  __int64 v22; // rcx
		  float v23; // xmm4_4
		  float v24; // xmm5_4
		  float v25; // xmm9_4
		  float v26; // xmm3_4
		  float v27; // xmm4_4
		  float x; // xmm0_4
		  float y; // xmm1_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v32; // [rsp+30h] [rbp-50h] BYREF
		  Vector4 v33[2]; // [rsp+40h] [rbp-40h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1859, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1859, 0LL);
		    if ( Patch )
		    {
		      v33[0] = *(Vector4 *)lightColor;
		      *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_748(
		                   (float4 *)&v32,
		                   Patch,
		                   (Object *)hgCamera,
		                   (Color *)v33,
		                   originalIntensity,
		                   0LL);
		      return retstr;
		    }
		LABEL_14:
		    sub_1800D8260(v17, charLightDialogMode);
		  }
		  v33[0] = *(Vector4 *)sub_183C6CBA0(v33, lightColor);
		  v33[0] = *(Vector4 *)UnityEngine::Color::op_Implicit((Color *)&v32, v33, v8);
		  v9 = (__m128)_mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		                                                  &v32,
		                                                  (CinemachineSmoothPath_Waypoint *)v33,
		                                                  0LL));
		  *(_QWORD *)&v32.x = _mm_unpacklo_ps(v9, _mm_shuffle_ps(v9, v9, 85)).m128_u64[0];
		  LODWORD(v32.z) = _mm_shuffle_ps(v9, v9, 170).m128_u32[0];
		  v10 = HG::Rendering::Runtime::LightExtensions::RgbToHsv((float3 *)v33, (float3 *)&v32, 0LL);
		  v9.m128_u64[0] = *(_QWORD *)&v10->x;
		  *(float *)&v10 = v10->z;
		  *(_QWORD *)&v32.x = v9.m128_u64[0];
		  LODWORD(v32.z) = (_DWORD)v10;
		  v9.m128_f32[0] = sub_182EE75E0(v11);
		  y_low = (__m128)0x40400000u;
		  y_low.m128_f32[0] = (float)((float)((float)(3.0 - (float)(v9.m128_f32[0] + v9.m128_f32[0]))
		                                    * (float)(v9.m128_f32[0] * v9.m128_f32[0]))
		                            * -0.34999999)
		                    + 0.69999999;
		  if ( v32.y <= y_low.m128_f32[0] )
		    y_low = (__m128)LODWORD(v32.y);
		  v32.z = v12;
		  v14 = (float)(v12 / (float)(2.0 - y_low.m128_f32[0])) * (float)(2.0 - v32.y);
		  *(_QWORD *)&v32.x = _mm_unpacklo_ps((__m128)LODWORD(v32.x), y_low).m128_u64[0];
		  v15 = HG::Rendering::Runtime::LightExtensions::HsvToRgb((float3 *)v33, (float3 *)&v32, 0LL);
		  z = v15->z;
		  *(_QWORD *)&v32.x = *(_QWORD *)&v15->x;
		  if ( !hgCamera )
		    goto LABEL_14;
		  v19 = originalIntensity * hgCamera->fields.exposureAdaptation;
		  volumeComponentsData = HG::Rendering::Runtime::HGCamera::get_volumeComponentsData(hgCamera, 0LL);
		  if ( !volumeComponentsData )
		    goto LABEL_14;
		  m_hgCharacterVolume = volumeComponentsData->fields.m_hgCharacterVolume;
		  if ( !m_hgCharacterVolume )
		    goto LABEL_14;
		  charLightDialogMode = m_hgCharacterVolume->fields.charLightDialogMode;
		  if ( !charLightDialogMode )
		    goto LABEL_14;
		  sub_180006280(10LL, charLightDialogMode);
		  v25 = sub_182EE75E0(v22);
		  v26 = v19 - 1.25;
		  if ( (float)(v19 - 1.25) <= 0.0 )
		    v26 = 0.0;
		  v27 = v23 - v19;
		  if ( v27 <= 0.0 )
		    v27 = 0.0;
		  x = v32.x;
		  y = v32.y;
		  retstr->z = z;
		  retstr->x = x;
		  retstr->y = y;
		  retstr->w = (float)((float)((float)(v26 * v24) + v25) - (float)(v27 * v24)) * v14;
		  return retstr;
		}
		
		[IDTag(2)]
		public static float4 GetCharacterLightColorAndIntensity(ref HGLightConfig config, HGCamera hgCamera) => default; // 0x0000000189D03DB8-0x0000000189D03E58
		// float4 GetCharacterLightColorAndIntensity(HGLightConfig ByRef, HGCamera)
		float4 *HG::Rendering::Runtime::LightExtensions::GetCharacterLightColorAndIntensity(
		        float4 *__return_ptr retstr,
		        HGLightConfig *config,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  float directIntensityDividePi; // xmm3_4
		  float4 *CharacterLightColorAndIntensity; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  float4 v12; // xmm0
		  float4 *result; // rax
		  Color directColor; // [rsp+30h] [rbp-28h] BYREF
		  float4 v15; // [rsp+40h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1861, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1861, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    CharacterLightColorAndIntensity = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_750(
		                                        &v15,
		                                        Patch,
		                                        config,
		                                        (Object *)hgCamera,
		                                        0LL);
		  }
		  else
		  {
		    directIntensityDividePi = config->directIntensityDividePi;
		    directColor = config->directColor;
		    CharacterLightColorAndIntensity = HG::Rendering::Runtime::LightExtensions::GetCharacterLightColorAndIntensity(
		                                        &v15,
		                                        hgCamera,
		                                        &directColor,
		                                        directIntensityDividePi,
		                                        0LL);
		  }
		  v12 = *CharacterLightColorAndIntensity;
		  result = retstr;
		  *retstr = v12;
		  return result;
		}
		
	
		// Extension methods
		public static HGAdditionalLightData GetHGAdditionalLightData(this Light light) => default; // 0x00000001832026A0-0x00000001832028C0
		// HGAdditionalLightData GetHGAdditionalLightData(Light)
		HGAdditionalLightData *HG::Rendering::Runtime::LightExtensions::GetHGAdditionalLightData(
		        Light *light,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
		  int *wrapperArray; // rdx
		  __int64 (__fastcall *v5)(Light *); // rax
		  GameObject *v6; // rdi
		  struct MethodInfo *v7; // rbx
		  struct Type__Class *v8; // rcx
		  System::Type **rgctx_data; // rbx
		  System::Type *v10; // rbx
		  void (__fastcall *v11)(GameObject *, System::Type *, _QWORD, char *); // rax
		  HGRuntimeGrassQuery_Node *v12; // rdx
		  HGRuntimeGrassQuery_Node *v13; // r8
		  Int32__Array **v14; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v17; // rax
		  __int64 v18; // rax
		  __int128 v19; // [rsp+20h] [rbp-18h] BYREF
		  HGAdditionalLightData *v20; // [rsp+50h] [rbp+18h] BYREF
		
		  v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = (int *)v3->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_20;
		  if ( wrapperArray[6] <= 1067 )
		    goto LABEL_5;
		  if ( !v3->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v3);
		    v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3->static_fields->wrapperArray;
		  if ( !v3 )
		LABEL_20:
		    sub_1800D8260(v3, wrapperArray);
		  if ( LODWORD(v3->_0.namespaze) <= 0x42B )
		    sub_1800D2AB0(v3, wrapperArray);
		  if ( *(_QWORD *)&v3[22]._1.interfaces_count )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1067, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_410(Patch, (Object *)light, 0LL);
		    goto LABEL_20;
		  }
		LABEL_5:
		  if ( !light )
		    goto LABEL_20;
		  v5 = (__int64 (__fastcall *)(Light *))qword_18F36FBC8;
		  if ( !qword_18F36FBC8 )
		  {
		    v5 = (__int64 (__fastcall *)(Light *))il2cpp_resolve_icall_1("UnityEngine.Component::get_gameObject()");
		    if ( !v5 )
		    {
		      v17 = sub_1802EE1B8("UnityEngine.Component::get_gameObject()");
		      sub_18007E1B0(v17, 0LL);
		    }
		    qword_18F36FBC8 = (__int64)v5;
		  }
		  v6 = (GameObject *)v5(light);
		  if ( !v6 )
		    goto LABEL_20;
		  v7 = MethodInfo::UnityEngine::GameObject::TryGetComponent<HG::Rendering::Runtime::HGAdditionalLightData>;
		  if ( !MethodInfo::UnityEngine::GameObject::TryGetComponent<HG::Rendering::Runtime::HGAdditionalLightData>->rgctx_data )
		    sub_1800430B0(MethodInfo::UnityEngine::GameObject::TryGetComponent<HG::Rendering::Runtime::HGAdditionalLightData>);
		  v8 = TypeInfo::System::Type;
		  rgctx_data = (System::Type **)v7->rgctx_data;
		  v19 = 0LL;
		  v10 = *rgctx_data;
		  if ( !TypeInfo::System::Type->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::System::Type);
		    v8 = TypeInfo::System::Type;
		  }
		  if ( v10 )
		  {
		    if ( !v8->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v8);
		    v10 = (System::Type *)System::Type::internal_from_handle(v10, wrapperArray);
		  }
		  v11 = (void (__fastcall *)(GameObject *, System::Type *, _QWORD, char *))qword_18F36FC20;
		  if ( !qword_18F36FC20 )
		  {
		    v11 = (void (__fastcall *)(GameObject *, System::Type *, _QWORD, char *))il2cpp_resolve_icall_1(
		                                                                               "UnityEngine.GameObject::TryGetComponentFa"
		                                                                               "stPath(System.Type,System.Int32,System.IntPtr)");
		    if ( !v11 )
		    {
		      v18 = sub_1802EE1B8("UnityEngine.GameObject::TryGetComponentFastPath(System.Type,System.Int32,System.IntPtr)");
		      sub_18007E1B0(v18, 0LL);
		    }
		    qword_18F36FC20 = (__int64)v11;
		  }
		  v11(v6, v10, 0LL, (char *)&v19 + 8);
		  v20 = (HGAdditionalLightData *)v19;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v20, v12, v13, v14, (MethodInfo *)v19);
		  if ( (_QWORD)v19 )
		    return v20;
		  else
		    return (HGAdditionalLightData *)UnityEngine::GameObject::AddComponent<System::Object>(
		                                      v6,
		                                      MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HGAdditionalLightData>);
		}
		
		public static float4 GetOriginalColorAndIntensity(this HGSharedLightData light) => default; // 0x0000000189D040D4-0x0000000189D041A8
		// float4 GetOriginalColorAndIntensity(HGSharedLightData)
		float4 *HG::Rendering::Runtime::LightExtensions::GetOriginalColorAndIntensity(
		        float4 *__return_ptr retstr,
		        HGSharedLightData light,
		        MethodInfo *method)
		{
		  MethodInfo *v4; // r8
		  Vector4 v5; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v7; // rdx
		  __int64 v8; // rcx
		  float4 *result; // rax
		  Vector4 v10; // [rsp+20h] [rbp-20h] BYREF
		  Vector4 v11; // [rsp+30h] [rbp-10h] BYREF
		  HGSharedLightData _unity_self; // [rsp+58h] [rbp+18h] BYREF
		
		  _unity_self = light;
		  if ( IFix::WrappersManagerImpl::IsPatched(1858, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1858, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v8, v7);
		    v5 = (Vector4)*IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_747((float4 *)&v11, Patch, _unity_self, 0LL);
		  }
		  else
		  {
		    v10 = (Vector4)*UnityEngine::HGSharedLightData::get_color((Color *)&v10, &_unity_self, 0LL);
		    v10 = *(Vector4 *)sub_183C6CBA0(&v11, &v10);
		    v10 = (Vector4)*UnityEngine::Color::op_Implicit((Color *)&v11, &v10, v4);
		    v10 = *Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
		             &v11,
		             (CinemachineSmoothPath_Waypoint *)&v10,
		             0LL);
		    v10.w = UnityEngine::HGSharedLightData::get_intensity_Injected(&_unity_self, 0LL);
		    v5 = v10;
		  }
		  result = retstr;
		  *(Vector4 *)retstr = v5;
		  return result;
		}
		
		[IDTag(1)]
		public static float4 GetCharacterLightColorAndIntensity(this HGSharedLightData light, HGCamera hgCamera) => default; // 0x0000000189D03A2C-0x0000000189D03AE8
		// float4 GetCharacterLightColorAndIntensity(HGSharedLightData, HGCamera)
		float4 *HG::Rendering::Runtime::LightExtensions::GetCharacterLightColorAndIntensity(
		        float4 *__return_ptr retstr,
		        HGSharedLightData light,
		        HGCamera *hgCamera,
		        MethodInfo *method)
		{
		  __m128i v6; // xmm6
		  float intensity_Injected; // xmm0_4
		  float4 *CharacterLightColorAndIntensity; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  float4 v12; // xmm0
		  float4 *result; // rax
		  __m128i v14; // [rsp+30h] [rbp-38h] BYREF
		  float4 v15; // [rsp+40h] [rbp-28h] BYREF
		  HGSharedLightData _unity_self; // [rsp+78h] [rbp+10h] BYREF
		
		  _unity_self = light;
		  if ( IFix::WrappersManagerImpl::IsPatched(1860, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1860, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    CharacterLightColorAndIntensity = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_749(
		                                        &v15,
		                                        Patch,
		                                        _unity_self,
		                                        (Object *)hgCamera,
		                                        0LL);
		  }
		  else
		  {
		    v6 = _mm_loadu_si128((const __m128i *)UnityEngine::HGSharedLightData::get_color((Color *)&v14, &_unity_self, 0LL));
		    intensity_Injected = UnityEngine::HGSharedLightData::get_intensity_Injected(&_unity_self, 0LL);
		    v14 = v6;
		    CharacterLightColorAndIntensity = HG::Rendering::Runtime::LightExtensions::GetCharacterLightColorAndIntensity(
		                                        &v15,
		                                        hgCamera,
		                                        (Color *)&v14,
		                                        intensity_Injected,
		                                        0LL);
		  }
		  v12 = *CharacterLightColorAndIntensity;
		  result = retstr;
		  *retstr = v12;
		  return result;
		}
		
		[IDTag(0)]
		public static float GetLightFalloff(this HGSharedLightData hgSharedLightData, float distance2) => default; // 0x0000000189D03E58-0x0000000189D03FE0
		// Single GetLightFalloff(HGSharedLightData, Single)
		float HG::Rendering::Runtime::LightExtensions::GetLightFalloff(
		        HGSharedLightData hgSharedLightData,
		        float distance2,
		        MethodInfo *method)
		{
		  float cullingDistance_Injected; // xmm6_4
		  float v4; // xmm8_4
		  float falloffDistance_Injected; // xmm6_4
		  float v6; // xmm11_4
		  float farDistanceShowDistance_Injected; // xmm6_4
		  float v8; // xmm10_4
		  float farDistanceShowFalloffDistance_Injected; // xmm6_4
		  float v10; // xmm9_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v13; // rdx
		  __int64 v14; // rcx
		  HGSharedLightData _unity_self; // [rsp+90h] [rbp+10h] BYREF
		
		  _unity_self = hgSharedLightData;
		  if ( IFix::WrappersManagerImpl::IsPatched(1862, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1862, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v14, v13);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_751(Patch, _unity_self, distance2, 0LL);
		  }
		  else
		  {
		    cullingDistance_Injected = UnityEngine::HGSharedLightData::get_cullingDistance_Injected(&_unity_self, 0LL);
		    v4 = UnityEngine::HGSharedLightData::get_cullingDistance_Injected(&_unity_self, 0LL) * cullingDistance_Injected;
		    falloffDistance_Injected = UnityEngine::HGSharedLightData::get_falloffDistance_Injected(&_unity_self, 0LL);
		    v6 = UnityEngine::HGSharedLightData::get_falloffDistance_Injected(&_unity_self, 0LL) * falloffDistance_Injected;
		    farDistanceShowDistance_Injected = UnityEngine::HGSharedLightData::get_farDistanceShowDistance_Injected(
		                                         &_unity_self,
		                                         0LL);
		    v8 = UnityEngine::HGSharedLightData::get_farDistanceShowDistance_Injected(&_unity_self, 0LL)
		       * farDistanceShowDistance_Injected;
		    farDistanceShowFalloffDistance_Injected = UnityEngine::HGSharedLightData::get_farDistanceShowFalloffDistance_Injected(
		                                                &_unity_self,
		                                                0LL);
		    v10 = UnityEngine::HGSharedLightData::get_farDistanceShowFalloffDistance_Injected(&_unity_self, 0LL)
		        * farDistanceShowFalloffDistance_Injected;
		    if ( UnityEngine::HGSharedLightData::get_useCullingDistance_Injected(&_unity_self, 0LL)
		      && distance2 > v6
		      && v4 > distance2 )
		    {
		      return (float)(v4 - distance2) / (float)(v4 - v6);
		    }
		    else if ( UnityEngine::HGSharedLightData::get_useFarDistanceShow_Injected(&_unity_self, 0LL)
		           && distance2 > v8
		           && v10 > distance2 )
		    {
		      return (float)(distance2 - v8) / (float)(v10 - v8);
		    }
		    else
		    {
		      return 1.0;
		    }
		  }
		}
		
		[IDTag(1)]
		public static float GetLightFalloff(this Light light, float distance2) => default; // 0x0000000189D03FE0-0x0000000189D040D4
		// Single GetLightFalloff(Light, Single)
		float HG::Rendering::Runtime::LightExtensions::GetLightFalloff(Light *light, float distance2, MethodInfo *method)
		{
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  float cullingDistance; // xmm6_4
		  float v7; // xmm7_4
		  float falloffDistance; // xmm6_4
		  float v9; // xmm9_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1863, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1863, 0LL);
		    if ( Patch )
		      return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_111(
		               (ILFixDynamicMethodWrapper_6 *)Patch,
		               (Object *)light,
		               distance2,
		               0LL);
		LABEL_9:
		    sub_1800D8260(v5, v4);
		  }
		  if ( !light )
		    goto LABEL_9;
		  cullingDistance = UnityEngine::Light::get_cullingDistance(light, 0LL);
		  v7 = UnityEngine::Light::get_cullingDistance(light, 0LL) * cullingDistance;
		  falloffDistance = UnityEngine::Light::get_falloffDistance(light, 0LL);
		  v9 = UnityEngine::Light::get_falloffDistance(light, 0LL) * falloffDistance;
		  if ( UnityEngine::Light::get_useCullingDistance(light, 0LL) && distance2 > v9 && v7 > distance2 )
		    return (float)(v7 - distance2) / (float)(v7 - v9);
		  else
		    return 1.0;
		}
		
		public static HGLightAdditionalData GetLightAdditionalData(this HGSharedLightData light) => default; // 0x00000001832040F0-0x0000000183204530
		// HGLightAdditionalData GetLightAdditionalData(HGSharedLightData)
		HGLightAdditionalData *HG::Rendering::Runtime::LightExtensions::GetLightAdditionalData(
		        HGLightAdditionalData *__return_ptr retstr,
		        HGSharedLightData light,
		        MethodInfo *method)
		{
		  struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
		  ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
		  __int64 (__fastcall *v6)(HGSharedLightData *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
		  unsigned int v7; // ebx
		  __int64 (__fastcall *v8)(_QWORD); // rax
		  struct Light__Class **v9; // rax
		  struct Light__Class *v10; // rdx
		  __int64 v11; // rsi
		  struct Light__Class **v12; // rbx
		  struct Object_1__Class *v13; // rcx
		  __int64 (__fastcall *v14)(HGSharedLightData *, struct Light__Class *); // rax
		  unsigned int v15; // ebx
		  __int64 (__fastcall *v16)(_QWORD); // rax
		  struct Light__Class **v17; // rax
		  Object *v18; // rbx
		  struct ILFixDynamicMethodWrapper_2__Class *v19; // rcx
		  int *v20; // rdx
		  __int64 (__fastcall *v21)(Object *); // rax
		  GameObject *v22; // r14
		  struct MethodInfo *v23; // rbx
		  struct Type__Class *v24; // rcx
		  System::Type **rgctx_data; // rbx
		  System::Type *v26; // rbx
		  void (__fastcall *v27)(GameObject *, __int64, _QWORD, float *); // rax
		  HGRuntimeGrassQuery_Node *v28; // rdx
		  HGRuntimeGrassQuery_Node *v29; // r8
		  Int32__Array **v30; // r9
		  void *v31; // rbx
		  Vector4 *v32; // rax
		  float v33; // xmm0_4
		  float v34; // xmm1_4
		  Vector4 lightNPRData; // xmm3
		  __m128 v36; // xmm2
		  __m128 v37; // xmm2
		  __m128 v38; // xmm2
		  HGLightAdditionalData *lightAdditionalData; // rax
		  __int128 v41; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v43; // rax
		  __int64 v44; // rax
		  __int64 v45; // rax
		  __int64 v46; // rax
		  ILFixDynamicMethodWrapper_2 *v47; // rax
		  __int64 v48; // rax
		  __int64 v49; // rax
		  ILFixDynamicMethodWrapper_2 *v50; // rax
		  HGLightAdditionalData *v51; // rax
		  Vector4 v52; // [rsp+20h] [rbp-38h] BYREF
		  HGLightAdditionalData v53; // [rsp+30h] [rbp-28h] BYREF
		  void *v54; // [rsp+70h] [rbp+18h] BYREF
		  HGSharedLightData v55; // [rsp+78h] [rbp+20h] BYREF
		
		  v55 = light;
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_56;
		  if ( wrapperArray->max_length.size > 1066 )
		  {
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    wrapperArray = v4->static_fields->wrapperArray;
		    if ( !wrapperArray )
		      goto LABEL_56;
		    if ( wrapperArray->max_length.size <= 0x42Au )
		      goto LABEL_99;
		    if ( wrapperArray[29].vector[22] )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1066, 0LL);
		      if ( !Patch )
		        goto LABEL_56;
		      lightAdditionalData = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_412(&v53, Patch, v55, 0LL);
		LABEL_52:
		      v41 = *(_OWORD *)&lightAdditionalData->lightNPRType;
		      retstr->lightNPRData = lightAdditionalData->lightNPRData;
		      *(_OWORD *)&retstr->lightNPRType = v41;
		      return retstr;
		    }
		  }
		  v6 = (__int64 (__fastcall *)(HGSharedLightData *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18F36F758;
		  if ( !qword_18F36F758 )
		  {
		    v6 = (__int64 (__fastcall *)(HGSharedLightData *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))il2cpp_resolve_icall_1("UnityEngine.HGSharedLightData::get_instanceID_Injected(UnityEngine.HGSharedLightData&)");
		    if ( !v6 )
		    {
		      v43 = sub_1802EE1B8("UnityEngine.HGSharedLightData::get_instanceID_Injected(UnityEngine.HGSharedLightData&)");
		      sub_18007E1B0(v43, 0LL);
		    }
		    qword_18F36F758 = (__int64)v6;
		  }
		  v7 = v6(&v55, wrapperArray, method);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  v8 = (__int64 (__fastcall *)(_QWORD))qword_18F36FD88;
		  if ( !qword_18F36FD88 )
		  {
		    v8 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_1("UnityEngine.Object::FindObjectFromInstanceID(System.Int32)");
		    if ( !v8 )
		    {
		      v44 = sub_1802EE1B8("UnityEngine.Object::FindObjectFromInstanceID(System.Int32)");
		      sub_18007E1B0(v44, 0LL);
		    }
		    qword_18F36FD88 = (__int64)v8;
		  }
		  v9 = (struct Light__Class **)v8(v7);
		  v10 = TypeInfo::UnityEngine::Light;
		  v11 = 0LL;
		  v12 = v9;
		  if ( v9 )
		  {
		    if ( *v9 != TypeInfo::UnityEngine::Light )
		      sub_18031E1F4(v9, TypeInfo::UnityEngine::Light);
		  }
		  else
		  {
		    v12 = 0LL;
		  }
		  v13 = TypeInfo::UnityEngine::Object;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v13 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v13 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( !v12 )
		    goto LABEL_51;
		  if ( !v13->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(v13);
		  if ( !v12[2] )
		  {
		LABEL_51:
		    lightAdditionalData = UnityEngine::HGSharedLightData::get_lightAdditionalData(&v53, &v55, 0LL);
		    goto LABEL_52;
		  }
		  v14 = (__int64 (__fastcall *)(HGSharedLightData *, struct Light__Class *))qword_18F36F758;
		  if ( !qword_18F36F758 )
		  {
		    v14 = (__int64 (__fastcall *)(HGSharedLightData *, struct Light__Class *))il2cpp_resolve_icall_1(
		                                                                                "UnityEngine.HGSharedLightData::get_insta"
		                                                                                "nceID_Injected(UnityEngine.HGSharedLightData&)");
		    if ( !v14 )
		    {
		      v45 = sub_1802EE1B8("UnityEngine.HGSharedLightData::get_instanceID_Injected(UnityEngine.HGSharedLightData&)");
		      sub_18007E1B0(v45, 0LL);
		    }
		    qword_18F36F758 = (__int64)v14;
		  }
		  v15 = v14(&v55, v10);
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		  v16 = (__int64 (__fastcall *)(_QWORD))qword_18F36FD88;
		  if ( !qword_18F36FD88 )
		  {
		    v16 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_1("UnityEngine.Object::FindObjectFromInstanceID(System.Int32)");
		    if ( !v16 )
		    {
		      v46 = sub_1802EE1B8("UnityEngine.Object::FindObjectFromInstanceID(System.Int32)");
		      sub_18007E1B0(v46, 0LL);
		    }
		    qword_18F36FD88 = (__int64)v16;
		  }
		  v17 = (struct Light__Class **)v16(v15);
		  v18 = (Object *)v17;
		  if ( v17 )
		  {
		    if ( *v17 != TypeInfo::UnityEngine::Light )
		      sub_18031E1F4(v17, TypeInfo::UnityEngine::Light);
		  }
		  else
		  {
		    v18 = 0LL;
		  }
		  v19 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  v54 = 0LL;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v19 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v20 = (int *)v19->static_fields->wrapperArray;
		  if ( !v20 )
		    goto LABEL_55;
		  if ( v20[6] <= 1067 )
		    goto LABEL_26;
		  if ( !v19->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(v19);
		    v19 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v19 = (struct ILFixDynamicMethodWrapper_2__Class *)v19->static_fields->wrapperArray;
		  if ( !v19 )
		LABEL_55:
		    sub_1800D8260(v19, v20);
		  if ( LODWORD(v19->_0.namespaze) <= 0x42B )
		    sub_1800D2AB0(v19, v20);
		  if ( *(_QWORD *)&v19[22]._1.interfaces_count )
		  {
		    v47 = IFix::WrappersManagerImpl::GetPatch(1067, 0LL);
		    if ( v47 )
		    {
		      v31 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_410(v47, v18, 0LL);
		      goto LABEL_40;
		    }
		    goto LABEL_55;
		  }
		LABEL_26:
		  if ( !v18 )
		    goto LABEL_55;
		  v21 = (__int64 (__fastcall *)(Object *))qword_18F36FBC8;
		  if ( !qword_18F36FBC8 )
		  {
		    v21 = (__int64 (__fastcall *)(Object *))il2cpp_resolve_icall_1("UnityEngine.Component::get_gameObject()");
		    if ( !v21 )
		    {
		      v48 = sub_1802EE1B8("UnityEngine.Component::get_gameObject()");
		      sub_18007E1B0(v48, 0LL);
		    }
		    qword_18F36FBC8 = (__int64)v21;
		  }
		  v22 = (GameObject *)v21(v18);
		  if ( !v22 )
		    goto LABEL_55;
		  v23 = MethodInfo::UnityEngine::GameObject::TryGetComponent<HG::Rendering::Runtime::HGAdditionalLightData>;
		  if ( !MethodInfo::UnityEngine::GameObject::TryGetComponent<HG::Rendering::Runtime::HGAdditionalLightData>->rgctx_data )
		    sub_1800430B0(MethodInfo::UnityEngine::GameObject::TryGetComponent<HG::Rendering::Runtime::HGAdditionalLightData>);
		  v24 = TypeInfo::System::Type;
		  rgctx_data = (System::Type **)v23->rgctx_data;
		  v52 = 0LL;
		  v26 = *rgctx_data;
		  if ( !TypeInfo::System::Type->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::System::Type);
		    v24 = TypeInfo::System::Type;
		  }
		  if ( v26 )
		  {
		    if ( !v24->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(v24);
		    v11 = System::Type::internal_from_handle(v26, v20);
		  }
		  v27 = (void (__fastcall *)(GameObject *, __int64, _QWORD, float *))qword_18F36FC20;
		  if ( !qword_18F36FC20 )
		  {
		    v27 = (void (__fastcall *)(GameObject *, __int64, _QWORD, float *))il2cpp_resolve_icall_1(
		                                                                         "UnityEngine.GameObject::TryGetComponentFastPath"
		                                                                         "(System.Type,System.Int32,System.IntPtr)");
		    if ( !v27 )
		    {
		      v49 = sub_1802EE1B8("UnityEngine.GameObject::TryGetComponentFastPath(System.Type,System.Int32,System.IntPtr)");
		      sub_18007E1B0(v49, 0LL);
		    }
		    qword_18F36FC20 = (__int64)v27;
		  }
		  v27(v22, v11, 0LL, &v52.z);
		  v54 = *(void **)&v52.x;
		  sub_18002D1B0((HGRuntimeGrassQuery_Node *)&v54, v28, v29, v30, *(MethodInfo **)&v52.x);
		  if ( *(_QWORD *)&v52.x )
		  {
		    v31 = v54;
		  }
		  else
		  {
		    v31 = UnityEngine::GameObject::AddComponent<System::Object>(
		            v22,
		            MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HGAdditionalLightData>);
		    v54 = v31;
		  }
		LABEL_40:
		  if ( !v31 )
		    goto LABEL_56;
		  v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  wrapperArray = v4->static_fields->wrapperArray;
		  if ( !wrapperArray )
		    goto LABEL_56;
		  if ( wrapperArray->max_length.size > 1068 )
		  {
		    if ( !v4->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(v4);
		      v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v4 = (struct ILFixDynamicMethodWrapper_2__Class *)v4->static_fields->wrapperArray;
		    if ( !v4 )
		      goto LABEL_56;
		    if ( LODWORD(v4->_0.namespaze) > 0x42C )
		    {
		      if ( !*(_QWORD *)&v4[22]._1.naturalAligment )
		        goto LABEL_45;
		      v50 = IFix::WrappersManagerImpl::GetPatch(1068, 0LL);
		      if ( v50 )
		      {
		        v51 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_411(&v53, v50, (Object *)v31, 0LL);
		        lightNPRData = v51->lightNPRData;
		        v38 = *(__m128 *)&v51->lightNPRType;
		        goto LABEL_46;
		      }
		LABEL_56:
		      sub_1800D8260(v4, wrapperArray);
		    }
		LABEL_99:
		    sub_1800D2AB0(v4, wrapperArray);
		  }
		LABEL_45:
		  *(_OWORD *)&v53.lightNPRType = 0LL;
		  v32 = HG::Rendering::Runtime::HGAdditionalLightData::GetLightNPRData(&v52, (HGAdditionalLightData *)v31, 0LL);
		  v33 = *((float *)v31 + 33);
		  v34 = *((float *)v31 + 32);
		  lightNPRData = *v32;
		  v53.lightNPRType = *((_DWORD *)v31 + 15);
		  v53.LightCharacterOnly = *((_BYTE *)v31 + 125);
		  v36 = _mm_shuffle_ps(*(__m128 *)&v53.lightNPRType, *(__m128 *)&v53.lightNPRType, 147);
		  v36.m128_f32[0] = v33;
		  v37 = _mm_shuffle_ps(v36, v36, 39);
		  v37.m128_f32[0] = v34;
		  v38 = _mm_shuffle_ps(v37, v37, 201);
		LABEL_46:
		  retstr->lightNPRData = lightNPRData;
		  *(__m128 *)&retstr->lightNPRType = v38;
		  return retstr;
		}
		
	}
}
