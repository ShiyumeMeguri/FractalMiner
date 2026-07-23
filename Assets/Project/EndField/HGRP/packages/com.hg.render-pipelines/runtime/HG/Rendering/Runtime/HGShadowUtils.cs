using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal static class HGShadowUtils // TypeDefIndex: 37894
	{
		// Fields
		public static readonly float k_MinShadowNearPlane; // 0x00
		public static readonly float k_MaxShadowNearPlane; // 0x04
		private static readonly Vector3[] k_CubemapOrthoBases; // 0x08
		private static Plane[] s_CachedPlanes; // 0x10
		public static readonly Matrix4x4[] kCubemapFaces; // 0x18
	
		// Constructors
		static HGShadowUtils() {} // 0x0000000189B520A8-0x0000000189B527FC
		// HGShadowUtils()
		void HG::Rendering::Runtime::HGShadowUtils::cctor(MethodInfo *method)
		{
		  __int64 v1; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  Vector3__Array *v4; // rbx
		  HGRuntimeGrassQuery_Node *v5; // rdx
		  HGRuntimeGrassQuery_Node *v6; // r8
		  Int32__Array **v7; // r9
		  __int64 v8; // rax
		  HGShadowUtils__StaticFields *static_fields; // rdx
		  HGRuntimeGrassQuery_Node *v10; // r8
		  Int32__Array **v11; // r9
		  __int64 v12; // rax
		  __m128i si128; // xmm8
		  __m128i v14; // xmm7
		  __m128i v15; // xmm6
		  __m128i v16; // xmm9
		  Matrix4x4__Array *v17; // rbx
		  __m128i v18; // xmm8
		  __m128i v19; // xmm6
		  __m128i v20; // xmm7
		  Vector4 v21; // xmm8
		  __m128i v22; // xmm6
		  __m128i v23; // xmm7
		  __m128i v24; // xmm6
		  Vector4 v25; // xmm7
		  __m128i v26; // xmm6
		  __m128i v27; // xmm8
		  __m128i v28; // xmm6
		  HGRuntimeGrassQuery_Node *v29; // rdx
		  HGRuntimeGrassQuery_Node *v30; // r8
		  Int32__Array **v31; // r9
		  MethodInfo *v32; // [rsp+28h] [rbp-E0h]
		  MethodInfo *v33; // [rsp+28h] [rbp-E0h]
		  __m128i v34; // [rsp+38h] [rbp-D0h] BYREF
		  __m128i v35; // [rsp+48h] [rbp-C0h] BYREF
		  __m128i v36; // [rsp+58h] [rbp-B0h] BYREF
		  __m128i v37; // [rsp+68h] [rbp-A0h] BYREF
		  Matrix4x4 v38; // [rsp+78h] [rbp-90h] BYREF
		  Matrix4x4 v39[2]; // [rsp+B8h] [rbp-50h] BYREF
		  MethodInfo *v40; // [rsp+168h] [rbp+60h]
		
		  TypeInfo::HG::Rendering::Runtime::HGShadowUtils->static_fields->k_MinShadowNearPlane = 0.000099999997;
		  TypeInfo::HG::Rendering::Runtime::HGShadowUtils->static_fields->k_MaxShadowNearPlane = 10.0;
		  v1 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Vector3, 18LL);
		  v4 = (Vector3__Array *)v1;
		  if ( !v1 )
		    goto LABEL_4;
		  v34.m128i_i32[2] = -1082130432;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  sub_180049BD0(v1, 0LL, &v34);
		  v34.m128i_i32[2] = 0;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
		  sub_180049BD0(v4, 1LL, &v34);
		  v34.m128i_i32[2] = 0;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0xBF800000, (__m128)0LL).m128_u64[0];
		  sub_180049BD0(v4, 2LL, &v34);
		  v34.m128i_i32[2] = 1065353216;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  sub_180049BD0(v4, 3LL, &v34);
		  v34.m128i_i32[2] = 0;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
		  sub_180049BD0(v4, 4LL, &v34);
		  v34.m128i_i32[2] = 0;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0LL).m128_u64[0];
		  sub_180049BD0(v4, 5LL, &v34);
		  v34.m128i_i32[2] = 0;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0LL).m128_u64[0];
		  sub_180049BD0(v4, 6LL, &v34);
		  v34.m128i_i32[2] = 1065353216;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  sub_180049BD0(v4, 7LL, &v34);
		  v34.m128i_i32[2] = 0;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
		  sub_180049BD0(v4, 8LL, &v34);
		  v34.m128i_i32[2] = 0;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0LL).m128_u64[0];
		  sub_180049BD0(v4, 9LL, &v34);
		  v34.m128i_i32[2] = -1082130432;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  sub_180049BD0(v4, 10LL, &v34);
		  v34.m128i_i32[2] = 0;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3F800000u).m128_u64[0];
		  sub_180049BD0(v4, 11LL, &v34);
		  v34.m128i_i32[2] = 0;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0LL).m128_u64[0];
		  sub_180049BD0(v4, 12LL, &v34);
		  v34.m128i_i32[2] = 0;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
		  sub_180049BD0(v4, 13LL, &v34);
		  v34.m128i_i32[2] = -1082130432;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  sub_180049BD0(v4, 14LL, &v34);
		  v34.m128i_i32[2] = 0;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0xBF800000, (__m128)0LL).m128_u64[0];
		  sub_180049BD0(v4, 15LL, &v34);
		  v34.m128i_i32[2] = 0;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0LL, (__m128)0xBF800000).m128_u64[0];
		  sub_180049BD0(v4, 16LL, &v34);
		  v34.m128i_i32[2] = 1065353216;
		  v34.m128i_i64[0] = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
		  sub_180049BD0(v4, 17LL, &v34);
		  TypeInfo::HG::Rendering::Runtime::HGShadowUtils->static_fields->k_CubemapOrthoBases = v4;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowUtils->static_fields->k_CubemapOrthoBases,
		    v5,
		    v6,
		    v7,
		    v32);
		  v8 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Plane, 6LL);
		  static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowUtils->static_fields;
		  static_fields->s_CachedPlanes = (Plane__Array *)v8;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowUtils->static_fields->s_CachedPlanes,
		    (HGRuntimeGrassQuery_Node *)static_fields,
		    v10,
		    v11,
		    v33);
		  v12 = il2cpp_array_new_specific_1(TypeInfo::UnityEngine::Matrix4x4, 6LL);
		  si128 = _mm_load_si128((const __m128i *)&xmmword_18DC81170);
		  v14 = _mm_load_si128((const __m128i *)&xmmword_18B959930);
		  v15 = _mm_load_si128((const __m128i *)&xmmword_18B959950);
		  v16 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		  v17 = (Matrix4x4__Array *)v12;
		  sub_18033B9D0(&v38, 0LL, 64LL);
		  v34 = v16;
		  v35 = v15;
		  v36 = v14;
		  v37 = si128;
		  UnityEngine::Matrix4x4::Matrix4x4(&v38, (Vector4 *)&v37, (Vector4 *)&v36, (Vector4 *)&v35, (Vector4 *)&v34, 0LL);
		  if ( !v17 )
		LABEL_4:
		    sub_1800D8260(v3, v2);
		  v39[0] = v38;
		  sub_180041540(v17, 0LL, v39);
		  v18 = _mm_load_si128((const __m128i *)&xmmword_18B959550);
		  v19 = _mm_load_si128((const __m128i *)&xmmword_18B9593A0);
		  sub_18033B9D0(&v38, 0LL, 64LL);
		  v37 = v16;
		  v36 = v19;
		  v35 = v14;
		  v34 = v18;
		  UnityEngine::Matrix4x4::Matrix4x4(&v38, (Vector4 *)&v34, (Vector4 *)&v35, (Vector4 *)&v36, (Vector4 *)&v37, 0LL);
		  v39[0] = v38;
		  sub_180041540(v17, 1LL, v39);
		  v20 = _mm_load_si128((const __m128i *)&xmmword_18DC81170);
		  v21 = (Vector4)v19;
		  v22 = _mm_load_si128((const __m128i *)&xmmword_18B959940);
		  sub_18033B9D0(&v38, 0LL, 64LL);
		  v37 = v16;
		  v36 = v22;
		  v35 = v20;
		  v34 = (__m128i)v21;
		  UnityEngine::Matrix4x4::Matrix4x4(&v38, (Vector4 *)&v34, (Vector4 *)&v35, (Vector4 *)&v36, (Vector4 *)&v37, 0LL);
		  v39[0] = v38;
		  sub_180041540(v17, 2LL, v39);
		  v23 = _mm_load_si128((const __m128i *)&xmmword_18B959550);
		  v24 = _mm_load_si128((const __m128i *)&xmmword_18B959930);
		  sub_18033B9D0(&v38, 0LL, 64LL);
		  v37 = v16;
		  v36 = v24;
		  v35 = v23;
		  v34 = (__m128i)v21;
		  UnityEngine::Matrix4x4::Matrix4x4(&v38, (Vector4 *)&v34, (Vector4 *)&v35, (Vector4 *)&v36, (Vector4 *)&v37, 0LL);
		  v39[0] = v38;
		  sub_180041540(v17, 3LL, v39);
		  v25 = (Vector4)v24;
		  v26 = _mm_load_si128((const __m128i *)&xmmword_18DC81170);
		  sub_18033B9D0(&v38, 0LL, 64LL);
		  v37 = v16;
		  v36 = v26;
		  v35 = (__m128i)v25;
		  v34 = (__m128i)v21;
		  UnityEngine::Matrix4x4::Matrix4x4(&v38, (Vector4 *)&v34, (Vector4 *)&v35, (Vector4 *)&v36, (Vector4 *)&v37, 0LL);
		  v39[0] = v38;
		  sub_180041540(v17, 4LL, v39);
		  v27 = _mm_load_si128((const __m128i *)&xmmword_18B959950);
		  v28 = _mm_load_si128((const __m128i *)&xmmword_18B959550);
		  sub_18033B9D0(&v38, 0LL, 64LL);
		  v37 = v16;
		  v36 = v28;
		  v35 = (__m128i)v25;
		  v34 = v27;
		  UnityEngine::Matrix4x4::Matrix4x4(&v38, (Vector4 *)&v34, (Vector4 *)&v35, (Vector4 *)&v36, (Vector4 *)&v37, 0LL);
		  v39[0] = v38;
		  sub_180041540(v17, 5LL, v39);
		  TypeInfo::HG::Rendering::Runtime::HGShadowUtils->static_fields->kCubemapFaces = v17;
		  sub_18002D1B0(
		    (HGRuntimeGrassQuery_Node *)&TypeInfo::HG::Rendering::Runtime::HGShadowUtils->static_fields->kCubemapFaces,
		    v29,
		    v30,
		    v31,
		    v40);
		}
		
	
		// Methods
		[IDTag(0)]
		public static float Asfloat(uint val) => default; // 0x0000000189B5082C-0x0000000189B50878
		// Single Asfloat(UInt32)
		float HG::Rendering::Runtime::HGShadowUtils::Asfloat(uint32_t val, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2232, 0LL) )
		    return *(float *)&val;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2232, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_41((ILFixDynamicMethodWrapper_24 *)Patch, val, 0LL);
		}
		
		[IDTag(1)]
		public static float Asfloat(int val) => default; // 0x0000000189B507E0-0x0000000189B5082C
		// Single Asfloat(Int32)
		float HG::Rendering::Runtime::HGShadowUtils::Asfloat(int32_t val, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2233, 0LL) )
		    return *(float *)&val;
		  Patch = IFix::WrappersManagerImpl::GetPatch(2233, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_41((ILFixDynamicMethodWrapper_24 *)Patch, val, 0LL);
		}
		
		public static int Asint(float val) => default; // 0x0000000189B50878-0x0000000189B508D0
		// Int32 Asint(Single)
		// local variable allocation has failed, the output may be wrong!
		int32_t HG::Rendering::Runtime::HGShadowUtils::Asint(float val, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2234, 0LL) )
		    return _mm_cvtsi128_si32(*(__m128i *)&val);
		  Patch = IFix::WrappersManagerImpl::GetPatch(2234, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v5, v4);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48((ILFixDynamicMethodWrapper_24 *)Patch, val, 0LL);
		}
		
		public static uint Asuint(float val) => default; // 0x0000000189B508D0-0x0000000189B50928
		// UInt32 Asuint(Single)
		// local variable allocation has failed, the output may be wrong!
		uint32_t HG::Rendering::Runtime::HGShadowUtils::Asuint(float val, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2235, 0LL) )
		    return _mm_cvtsi128_si32(*(__m128i *)&val);
		  Patch = IFix::WrappersManagerImpl::GetPatch(2235, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v5, v4);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_48((ILFixDynamicMethodWrapper_24 *)Patch, val, 0LL);
		}
		
		public static void ExtractDirectionalLightData([IsReadOnly] in VisibleLight visibleLight, Vector2 viewportSize, uint cascadeIndex, int cascadeCount, float[] cascadeRatios, float nearPlaneOffset, CullingResults cullResults, int lightIndex, out Matrix4x4 view, out Matrix4x4 projection, out Matrix4x4 deviceProjectionYFlip, out ShadowSplitData splitData) {
			view = default;
			projection = default;
			deviceProjectionYFlip = default;
			splitData = default;
		} // 0x0000000189B50928-0x0000000189B50C00
		// Void ExtractDirectionalLightData(VisibleLight ByRef, Vector2, UInt32, Int32, Single[], Single, CullingResults, Int32, Matrix4x4 ByRef, Matrix4x4 ByRef, Matrix4x4 ByRef, ShadowSplitData ByRef)
		void HG::Rendering::Runtime::HGShadowUtils::ExtractDirectionalLightData(
		        VisibleLight *visibleLight,
		        Vector2 viewportSize,
		        uint32_t cascadeIndex,
		        int32_t cascadeCount,
		        Single__Array *cascadeRatios,
		        float nearPlaneOffset,
		        CullingResults *cullResults,
		        int32_t lightIndex,
		        Matrix4x4 *view,
		        Matrix4x4 *projection,
		        Matrix4x4 *deviceProjectionYFlip,
		        ShadowSplitData *splitData,
		        MethodInfo *method)
		{
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  float m_ScreenSpaceArea; // eax
		  __int64 v25; // rdx
		  ILFixDynamicMethodWrapper_2 *Patch; // rcx
		  int m_AllocationInfo; // eax
		  unsigned int v28; // ebx
		  int32_t size; // edi
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  __int128 v32; // xmm1
		  Matrix4x4 *GPUProjectionMatrix; // rax
		  __int128 v34; // xmm1
		  __int128 v35; // xmm2
		  __int128 v36; // xmm3
		  CullingResults v37; // [rsp+78h] [rbp-90h] BYREF
		  Vector2 v38; // [rsp+88h] [rbp-80h]
		  Matrix4x4 v39; // [rsp+98h] [rbp-70h] BYREF
		  Matrix4x4 v40; // [rsp+D8h] [rbp-30h] BYREF
		  VisibleLight v41; // [rsp+118h] [rbp+10h] BYREF
		
		  v38 = viewportSize;
		  if ( IFix::WrappersManagerImpl::IsPatched(2162, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2162, 0LL);
		    if ( Patch )
		    {
		      v37 = *cullResults;
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_864(
		        Patch,
		        visibleLight,
		        viewportSize,
		        cascadeIndex,
		        cascadeCount,
		        (Object *)cascadeRatios,
		        nearPlaneOffset,
		        &v37,
		        lightIndex,
		        view,
		        projection,
		        deviceProjectionYFlip,
		        splitData,
		        0LL);
		      return;
		    }
		LABEL_11:
		    sub_1800D8260(Patch, v25);
		  }
		  sub_18033B9D0(splitData, 0LL, 188LL);
		  sub_1800036A0(TypeInfo::UnityEngine::Rendering::ShadowSplitData);
		  splitData->m_CullingPlaneCount = 0;
		  UnityEngine::Rendering::ShadowSplitData::set_shadowCascadeBlendCullingFactor(splitData, 0.60000002, 0LL);
		  v17 = *(_OWORD *)&visibleLight->m_FinalColor.a;
		  *(_OWORD *)&v41.m_LightType = *(_OWORD *)&visibleLight->m_LightType;
		  v18 = *(_OWORD *)&visibleLight->m_ScreenRect.m_Height;
		  *(_OWORD *)&v41.m_FinalColor.a = v17;
		  v19 = *(_OWORD *)&visibleLight->m_LocalToWorldMatrix.m30;
		  *(_OWORD *)&v41.m_ScreenRect.m_Height = v18;
		  v20 = *(_OWORD *)&visibleLight->m_LocalToWorldMatrix.m31;
		  *(_OWORD *)&v41.m_LocalToWorldMatrix.m30 = v19;
		  v21 = *(_OWORD *)&visibleLight->m_LocalToWorldMatrix.m32;
		  *(_OWORD *)&v41.m_LocalToWorldMatrix.m31 = v20;
		  v22 = *(_OWORD *)&visibleLight->m_LocalToWorldMatrix.m33;
		  *(_OWORD *)&v41.m_LocalToWorldMatrix.m32 = v21;
		  v23 = *(_OWORD *)&visibleLight->m_InstanceId;
		  *(_OWORD *)&v41.m_LocalToWorldMatrix.m33 = v22;
		  m_ScreenSpaceArea = visibleLight->m_ScreenSpaceArea;
		  *(_OWORD *)&v41.m_LightPriority = *(_OWORD *)&visibleLight->m_LightPriority;
		  *(_OWORD *)&v41.m_InstanceId = v23;
		  v41.m_ScreenSpaceArea = m_ScreenSpaceArea;
		  HG::Rendering::Runtime::VisibleLightExtensionMethods::GetForward((Vector3 *)&v37, &v41, 0LL);
		  m_AllocationInfo = 0;
		  v28 = 0;
		  v37.ptr = 0LL;
		  LODWORD(v37.m_AllocationInfo) = 0;
		  if ( !cascadeRatios )
		    goto LABEL_11;
		  size = 3;
		  if ( cascadeRatios->max_length.size >= 3 || (size = cascadeRatios->max_length.size, size > 0) )
		  {
		    do
		    {
		      if ( v28 >= cascadeRatios->max_length.size )
		        sub_1800D2AB0(Patch, v25);
		      sub_1831FBF70(&v37, v28++);
		    }
		    while ( (int)v28 < size );
		    m_AllocationInfo = (int)v37.m_AllocationInfo;
		  }
		  LODWORD(v37.m_AllocationInfo) = m_AllocationInfo;
		  UnityEngine::Rendering::CullingResults::ComputeDirectionalShadowMatricesAndCullingPrimitives(
		    cullResults,
		    lightIndex,
		    cascadeIndex,
		    cascadeCount,
		    (Vector3 *)&v37,
		    (int)v38.x,
		    nearPlaneOffset,
		    view,
		    projection,
		    splitData,
		    0LL);
		  v30 = *(_OWORD *)&projection->m01;
		  *(_OWORD *)&v39.m00 = *(_OWORD *)&projection->m00;
		  v31 = *(_OWORD *)&projection->m02;
		  *(_OWORD *)&v39.m01 = v30;
		  v32 = *(_OWORD *)&projection->m03;
		  *(_OWORD *)&v39.m02 = v31;
		  *(_OWORD *)&v39.m03 = v32;
		  GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(&v40, &v39, 1, 0LL);
		  v34 = *(_OWORD *)&GPUProjectionMatrix->m01;
		  v35 = *(_OWORD *)&GPUProjectionMatrix->m02;
		  v36 = *(_OWORD *)&GPUProjectionMatrix->m03;
		  *(_OWORD *)&deviceProjectionYFlip->m00 = *(_OWORD *)&GPUProjectionMatrix->m00;
		  *(_OWORD *)&deviceProjectionYFlip->m01 = v34;
		  *(_OWORD *)&deviceProjectionYFlip->m02 = v35;
		  *(_OWORD *)&deviceProjectionYFlip->m03 = v36;
		}
		
		private static void InvertView(ref Matrix4x4 view, out Matrix4x4 invview) {
			invview = default;
		} // 0x0000000189B51F34-0x0000000189B520A8
		// Void InvertView(Matrix4x4 ByRef, Matrix4x4 ByRef)
		void HG::Rendering::Runtime::HGShadowUtils::InvertView(Matrix4x4 *view, Matrix4x4 *invview, MethodInfo *method)
		{
		  Matrix4x4__StaticFields *static_fields; // r8
		  __int128 v6; // xmm1
		  __int128 v7; // xmm2
		  __int128 v8; // xmm3
		  float m00; // xmm0_4
		  float m11; // xmm5_4
		  float m21; // xmm4_4
		  float m02; // xmm6_4
		  float m12; // xmm8_4
		  float m22; // xmm7_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v16; // rdx
		  __int64 v17; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2236, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2236, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v17, v16);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_896(Patch, view, invview, 0LL);
		  }
		  else
		  {
		    static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    v6 = *(_OWORD *)&static_fields->zeroMatrix.m01;
		    v7 = *(_OWORD *)&static_fields->zeroMatrix.m02;
		    v8 = *(_OWORD *)&static_fields->zeroMatrix.m03;
		    *(_OWORD *)&invview->m00 = *(_OWORD *)&static_fields->zeroMatrix.m00;
		    *(_OWORD *)&invview->m01 = v6;
		    *(_OWORD *)&invview->m02 = v7;
		    *(_OWORD *)&invview->m03 = v8;
		    m00 = view->m00;
		    invview->m00 = view->m00;
		    *(float *)&v7 = view->m10;
		    LODWORD(invview->m01) = v7;
		    *(float *)&v6 = view->m20;
		    LODWORD(invview->m02) = v6;
		    *(float *)&v8 = view->m01;
		    LODWORD(invview->m10) = v8;
		    m11 = view->m11;
		    invview->m11 = m11;
		    m21 = view->m21;
		    invview->m12 = m21;
		    m02 = view->m02;
		    invview->m20 = m02;
		    m12 = view->m12;
		    invview->m21 = m12;
		    m22 = view->m22;
		    invview->m22 = m22;
		    invview->m33 = 1.0;
		    invview->m03 = -(float)((float)((float)(*(float *)&v7 * view->m13) + (float)(m00 * view->m03))
		                          + (float)(*(float *)&v6 * view->m23));
		    invview->m13 = -(float)((float)((float)(m11 * view->m13) + (float)(*(float *)&v8 * view->m03))
		                          + (float)(m21 * view->m23));
		    invview->m23 = -(float)((float)((float)(m12 * view->m13) + (float)(m02 * view->m03)) + (float)(m22 * view->m23));
		  }
		}
		
		private static void InvertOrthographic(ref Matrix4x4 proj, ref Matrix4x4 view, out Matrix4x4 vpinv) {
			vpinv = default;
		} // 0x0000000189B51B64-0x0000000189B51D0C
		// Void InvertOrthographic(Matrix4x4 ByRef, Matrix4x4 ByRef, Matrix4x4 ByRef)
		void HG::Rendering::Runtime::HGShadowUtils::InvertOrthographic(
		        Matrix4x4 *proj,
		        Matrix4x4 *view,
		        Matrix4x4 *vpinv,
		        MethodInfo *method)
		{
		  float v7; // xmm2_4
		  Matrix4x4__StaticFields *static_fields; // rcx
		  __int128 v9; // xmm1
		  __int128 v10; // xmm0
		  __int128 v11; // xmm1
		  float v12; // xmm3_4
		  float v13; // xmm2_4
		  Matrix4x4 *v14; // rax
		  __int128 v15; // xmm1
		  __int128 v16; // xmm2
		  __int128 v17; // xmm3
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v19; // rdx
		  __int64 v20; // rcx
		  Matrix4x4 v21; // [rsp+38h] [rbp-69h] BYREF
		  Matrix4x4 invview; // [rsp+78h] [rbp-29h] BYREF
		  Matrix4x4 v23; // [rsp+B8h] [rbp+17h] BYREF
		
		  sub_18033B9D0(&invview, 0LL, 64LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(2237, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2237, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v20, v19);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_897(Patch, proj, view, vpinv, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		    HG::Rendering::Runtime::HGShadowUtils::InvertView(view, &invview, 0LL);
		    v7 = 1.0 / proj->m00;
		    static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    v9 = *(_OWORD *)&static_fields->zeroMatrix.m01;
		    *(_OWORD *)&v21.m00 = *(_OWORD *)&static_fields->zeroMatrix.m00;
		    v10 = *(_OWORD *)&static_fields->zeroMatrix.m02;
		    *(_OWORD *)&v21.m01 = v9;
		    v11 = *(_OWORD *)&static_fields->zeroMatrix.m03;
		    *(_OWORD *)&v21.m02 = v10;
		    v12 = 1.0 / proj->m22;
		    v21.m11 = 1.0 / proj->m11;
		    *(float *)&v10 = v21.m11 * proj->m13;
		    *(_OWORD *)&v21.m03 = v11;
		    LODWORD(v21.m13) = v10;
		    *(float *)&v10 = (float)-proj->m23 * v12;
		    v21.m33 = 1.0;
		    v21.m00 = v7;
		    v13 = v7 * proj->m03;
		    LODWORD(v21.m23) = v10;
		    v21.m22 = v12;
		    v21.m03 = v13;
		    v23 = v21;
		    v21 = invview;
		    v14 = UnityEngine::Matrix4x4::op_Multiply(&invview, &v21, &v23, 0LL);
		    v15 = *(_OWORD *)&v14->m01;
		    v16 = *(_OWORD *)&v14->m02;
		    v17 = *(_OWORD *)&v14->m03;
		    *(_OWORD *)&vpinv->m00 = *(_OWORD *)&v14->m00;
		    *(_OWORD *)&vpinv->m01 = v15;
		    *(_OWORD *)&vpinv->m02 = v16;
		    *(_OWORD *)&vpinv->m03 = v17;
		  }
		}
		
		private static void InvertPerspective(ref Matrix4x4 proj, ref Matrix4x4 view, out Matrix4x4 vpinv) {
			vpinv = default;
		} // 0x0000000189B51D0C-0x0000000189B51F34
		// Void InvertPerspective(Matrix4x4 ByRef, Matrix4x4 ByRef, Matrix4x4 ByRef)
		void HG::Rendering::Runtime::HGShadowUtils::InvertPerspective(
		        Matrix4x4 *proj,
		        Matrix4x4 *view,
		        Matrix4x4 *vpinv,
		        MethodInfo *method)
		{
		  float v7; // xmm10_4
		  float m00; // xmm3_4
		  float v9; // xmm5_4
		  float v10; // xmm7_4
		  float m01; // xmm4_4
		  float m03; // xmm2_4
		  float v13; // xmm0_4
		  float v14; // xmm9_4
		  float v15; // xmm1_4
		  float v16; // xmm8_4
		  float v17; // xmm6_4
		  float v18; // xmm4_4
		  float m10; // xmm3_4
		  float v20; // xmm0_4
		  float v21; // xmm4_4
		  float v22; // xmm4_4
		  float v23; // xmm2_4
		  float v24; // xmm0_4
		  float m11; // xmm1_4
		  float v26; // xmm4_4
		  float m20; // xmm0_4
		  float v28; // xmm3_4
		  float v29; // xmm4_4
		  float v30; // xmm4_4
		  float v31; // xmm2_4
		  float v32; // xmm0_4
		  float m21; // xmm4_4
		  float v34; // xmm1_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v36; // rdx
		  __int64 v37; // rcx
		  Matrix4x4 invview; // [rsp+38h] [rbp-39h] BYREF
		
		  sub_18033B9D0(&invview, 0LL, 64LL);
		  if ( IFix::WrappersManagerImpl::IsPatched(2238, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2238, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v37, v36);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_897(Patch, proj, view, vpinv, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		    HG::Rendering::Runtime::HGShadowUtils::InvertView(view, &invview, 0LL);
		    v7 = proj->m22 / proj->m23;
		    m00 = invview.m00;
		    v9 = 1.0 / proj->m00;
		    v10 = 1.0 / proj->m11;
		    m01 = invview.m01;
		    m03 = invview.m03;
		    v13 = invview.m00 * v9;
		    v14 = v7 / proj->m22;
		    v15 = invview.m01 * v10;
		    v16 = v9 * proj->m02;
		    v17 = v10 * proj->m12;
		    vpinv->m30 = 0.0;
		    vpinv->m31 = 0.0;
		    vpinv->m00 = v13;
		    vpinv->m02 = m03 * v14;
		    v18 = (float)(m01 * v17) + (float)(m00 * v16);
		    vpinv->m01 = v15;
		    m10 = invview.m10;
		    v20 = invview.m10;
		    vpinv->m32 = v14;
		    v21 = v18 - invview.m02;
		    vpinv->m10 = v20 * v9;
		    vpinv->m33 = v7;
		    v22 = v21 + (float)(m03 * v7);
		    v23 = invview.m13 * v7;
		    v24 = invview.m13 * v14;
		    vpinv->m03 = v22;
		    m11 = invview.m11;
		    vpinv->m12 = v24;
		    v26 = (float)(m11 * v17) + (float)(m10 * v16);
		    m20 = invview.m20;
		    v28 = invview.m20 * v16;
		    v29 = v26 - invview.m12;
		    vpinv->m11 = m11 * v10;
		    vpinv->m20 = m20 * v9;
		    v30 = v29 + v23;
		    v31 = invview.m23 * v7;
		    v32 = invview.m23 * v14;
		    vpinv->m13 = v30;
		    m21 = invview.m21;
		    v34 = invview.m21;
		    vpinv->m22 = v32;
		    vpinv->m21 = v34 * v10;
		    vpinv->m23 = (float)((float)((float)(m21 * v17) + v28) - invview.m22) + v31;
		  }
		}
		
		public static Matrix4x4 ExtractSpotLightProjectionMatrix(float spotAngle, float nearPlane, float farPlane, float guardAngle) => default; // 0x0000000189B511E0-0x0000000189B513B8
		// Matrix4x4 ExtractSpotLightProjectionMatrix(Single, Single, Single, Single)
		Matrix4x4 *HG::Rendering::Runtime::HGShadowUtils::ExtractSpotLightProjectionMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        float spotAngle,
		        float nearPlane,
		        float farPlane,
		        float guardAngle,
		        MethodInfo *method)
		{
		  float v7; // xmm8_4
		  __int64 v8; // rdx
		  __int64 v9; // r8
		  __int64 v10; // r9
		  HGShadowUtils__StaticFields *static_fields; // rcx
		  float v12; // xmm7_4
		  float v13; // xmm6_4
		  float v14; // xmm1_4
		  float v15; // xmm2_4
		  float v16; // xmm8_4
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  Matrix4x4 *v22; // rax
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  Matrix4x4 v27; // [rsp+40h] [rbp-78h] BYREF
		
		  v7 = farPlane;
		  if ( IFix::WrappersManagerImpl::IsPatched(1898, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1898, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v21, v20);
		    v22 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_759(&v27, Patch, spotAngle, nearPlane, farPlane, guardAngle, 0LL);
		    v23 = *(_OWORD *)&v22->m01;
		    *(_OWORD *)&retstr->m00 = *(_OWORD *)&v22->m00;
		    v24 = *(_OWORD *)&v22->m02;
		    *(_OWORD *)&retstr->m01 = v23;
		    v25 = *(_OWORD *)&v22->m03;
		    *(_OWORD *)&retstr->m02 = v24;
		    *(_OWORD *)&retstr->m03 = v25;
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		    static_fields = TypeInfo::HG::Rendering::Runtime::HGShadowUtils->static_fields;
		    v12 = fmaxf(nearPlane, static_fields->k_MinShadowNearPlane);
		    if ( v12 > farPlane )
		    {
		      v7 = v12;
		    }
		    else if ( farPlane > (float)(v12 * 10000000.0) )
		    {
		      v7 = v12 * 10000000.0;
		    }
		    v13 = 1.0 / sub_180338A80(static_fields, v8, v9, v10);
		    sub_18033B9D0(&v27, 0LL, 64LL);
		    v27.m32 = -1.0;
		    v27.m00 = v13;
		    v14 = v7 + v12;
		    v27.m11 = v13;
		    v15 = v7 * -2.0;
		    v16 = v7 - v12;
		    v17 = *(_OWORD *)&v27.m01;
		    v27.m22 = (float)-v14 / v16;
		    *(_OWORD *)&retstr->m00 = *(_OWORD *)&v27.m00;
		    v18 = *(_OWORD *)&v27.m02;
		    *(_OWORD *)&retstr->m01 = v17;
		    *(_OWORD *)&retstr->m02 = v18;
		    v27.m23 = (float)(v15 * v12) / v16;
		    *(_OWORD *)&retstr->m03 = *(_OWORD *)&v27.m03;
		  }
		  return retstr;
		}
		
		public static Matrix4x4 ExtractSpotLightMatrix(Matrix4x4 localToWorld, float spotAngle, float nearPlane, float farPlane, float guardAngle, out Matrix4x4 view, out Matrix4x4 proj, out Matrix4x4 deviceProjYFlip) {
			view = default;
			proj = default;
			deviceProjYFlip = default;
			return default;
		} // 0x0000000189B50F00-0x0000000189B511E0
		// Matrix4x4 ExtractSpotLightMatrix(Matrix4x4, Single, Single, Single, Single, Matrix4x4 ByRef, Matrix4x4 ByRef, Matrix4x4 ByRef)
		Matrix4x4 *HG::Rendering::Runtime::HGShadowUtils::ExtractSpotLightMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        Matrix4x4 *localToWorld,
		        float spotAngle,
		        float nearPlane,
		        float farPlane,
		        float guardAngle,
		        Matrix4x4 *view,
		        Matrix4x4 *proj,
		        Matrix4x4 *deviceProjYFlip,
		        MethodInfo *method)
		{
		  Matrix4x4 *inverse; // rax
		  __int128 v15; // xmm1
		  __int128 v16; // xmm2
		  __int128 v17; // xmm3
		  float v18; // xmm0_4
		  Matrix4x4 *v19; // rax
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm2
		  __int128 v23; // xmm3
		  Matrix4x4 *GPUProjectionMatrix; // rax
		  __int128 v25; // xmm1
		  __int128 v26; // xmm6
		  __int128 v27; // xmm7
		  __int128 v28; // xmm8
		  __int128 v29; // xmm9
		  __int128 v30; // xmm0
		  __int128 v31; // xmm1
		  Matrix4x4 *v32; // rax
		  __int128 v33; // xmm1
		  __int128 v34; // xmm2
		  __int128 v35; // xmm3
		  __int128 v36; // xmm1
		  __int128 v37; // xmm0
		  __int128 v38; // xmm1
		  Matrix4x4 *v39; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v41; // rcx
		  __int128 v42; // xmm1
		  __int128 v43; // xmm0
		  __int128 v44; // xmm1
		  __int128 v45; // xmm1
		  __int128 v46; // xmm0
		  __int128 v47; // xmm1
		  Matrix4x4 *result; // rax
		  Matrix4x4 v49; // [rsp+68h] [rbp-A0h] BYREF
		  Matrix4x4 v50; // [rsp+A8h] [rbp-60h] BYREF
		  Matrix4x4 v51[2]; // [rsp+E8h] [rbp-20h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1897, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1897, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v41, 0LL);
		    v42 = *(_OWORD *)&localToWorld->m01;
		    *(_OWORD *)&v50.m00 = *(_OWORD *)&localToWorld->m00;
		    v43 = *(_OWORD *)&localToWorld->m02;
		    *(_OWORD *)&v50.m01 = v42;
		    v44 = *(_OWORD *)&localToWorld->m03;
		    *(_OWORD *)&v50.m02 = v43;
		    *(_OWORD *)&v50.m03 = v44;
		    v39 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_760(
		            v51,
		            Patch,
		            &v50,
		            spotAngle,
		            nearPlane,
		            farPlane,
		            guardAngle,
		            view,
		            proj,
		            deviceProjYFlip,
		            0LL);
		  }
		  else
		  {
		    inverse = UnityEngine::Matrix4x4::get_inverse(&v50, localToWorld, 0LL);
		    v15 = *(_OWORD *)&inverse->m01;
		    v16 = *(_OWORD *)&inverse->m02;
		    v17 = *(_OWORD *)&inverse->m03;
		    *(_OWORD *)&view->m00 = *(_OWORD *)&inverse->m00;
		    *(_OWORD *)&view->m01 = v15;
		    *(_OWORD *)&view->m02 = v16;
		    *(_OWORD *)&view->m03 = v17;
		    *(float *)&v15 = view->m22 * -1.0;
		    view->m20 = view->m20 * -1.0;
		    v18 = view->m21 * -1.0;
		    LODWORD(view->m22) = v15;
		    view->m21 = v18;
		    view->m23 = view->m23 * -1.0;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		    v19 = HG::Rendering::Runtime::HGShadowUtils::ExtractSpotLightProjectionMatrix(
		            &v50,
		            spotAngle,
		            nearPlane,
		            farPlane,
		            guardAngle,
		            0LL);
		    v20 = *(_OWORD *)&v19->m00;
		    v21 = *(_OWORD *)&v19->m01;
		    v22 = *(_OWORD *)&v19->m02;
		    v23 = *(_OWORD *)&v19->m03;
		    *(_OWORD *)&proj->m00 = *(_OWORD *)&v19->m00;
		    *(_OWORD *)&proj->m01 = v21;
		    *(_OWORD *)&proj->m02 = v22;
		    *(_OWORD *)&proj->m03 = v23;
		    *(_OWORD *)&v49.m00 = v20;
		    *(_OWORD *)&v49.m01 = v21;
		    *(_OWORD *)&v49.m02 = v22;
		    *(_OWORD *)&v49.m03 = v23;
		    GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(&v50, &v49, 0, 0LL);
		    v25 = *(_OWORD *)&proj->m01;
		    v26 = *(_OWORD *)&GPUProjectionMatrix->m00;
		    v27 = *(_OWORD *)&GPUProjectionMatrix->m01;
		    v28 = *(_OWORD *)&GPUProjectionMatrix->m02;
		    v29 = *(_OWORD *)&GPUProjectionMatrix->m03;
		    *(_OWORD *)&v49.m00 = *(_OWORD *)&proj->m00;
		    v30 = *(_OWORD *)&proj->m02;
		    *(_OWORD *)&v49.m01 = v25;
		    v31 = *(_OWORD *)&proj->m03;
		    *(_OWORD *)&v49.m02 = v30;
		    *(_OWORD *)&v49.m03 = v31;
		    v32 = UnityEngine::GL::GetGPUProjectionMatrix(&v50, &v49, 1, 0LL);
		    v33 = *(_OWORD *)&v32->m01;
		    v34 = *(_OWORD *)&v32->m02;
		    v35 = *(_OWORD *)&v32->m03;
		    *(_OWORD *)&deviceProjYFlip->m00 = *(_OWORD *)&v32->m00;
		    *(_OWORD *)&deviceProjYFlip->m01 = v33;
		    *(_OWORD *)&deviceProjYFlip->m02 = v34;
		    *(_OWORD *)&deviceProjYFlip->m03 = v35;
		    v36 = *(_OWORD *)&view->m01;
		    *(_OWORD *)&v49.m00 = *(_OWORD *)&view->m00;
		    v37 = *(_OWORD *)&view->m02;
		    *(_OWORD *)&v49.m01 = v36;
		    v38 = *(_OWORD *)&view->m03;
		    *(_OWORD *)&v49.m02 = v37;
		    *(_OWORD *)&v49.m03 = v38;
		    *(_OWORD *)&v50.m00 = v26;
		    *(_OWORD *)&v50.m01 = v27;
		    *(_OWORD *)&v50.m02 = v28;
		    *(_OWORD *)&v50.m03 = v29;
		    v39 = UnityEngine::Rendering::CoreMatrixUtils::MultiplyPerspectiveMatrix(v51, &v50, &v49, 0LL);
		  }
		  v45 = *(_OWORD *)&v39->m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v39->m00;
		  v46 = *(_OWORD *)&v39->m02;
		  *(_OWORD *)&retstr->m01 = v45;
		  v47 = *(_OWORD *)&v39->m03;
		  result = retstr;
		  *(_OWORD *)&retstr->m02 = v46;
		  *(_OWORD *)&retstr->m03 = v47;
		  return result;
		}
		
		public static Matrix4x4 GetPointLightViewMatrix(Vector3 lightPosition, int faceID) => default; // 0x0000000189B513B8-0x0000000189B51728
		// Matrix4x4 GetPointLightViewMatrix(Vector3, Int32)
		Matrix4x4 *HG::Rendering::Runtime::HGShadowUtils::GetPointLightViewMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        Vector3 *lightPosition,
		        int32_t faceID,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  Vector3__Array *k_CubemapOrthoBases; // rcx
		  float v9; // eax
		  __m128i si128; // xmm6
		  MethodInfo *v11; // rdx
		  Vector3 *one; // rax
		  __int64 v13; // xmm1_8
		  MethodInfo *v14; // rdx
		  MethodInfo *v15; // r8
		  Vector3 *v16; // rax
		  __int64 v17; // xmm4_8
		  Matrix4x4 *v18; // rax
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  Matrix4x4 *v22; // rax
		  __m128 v23; // xmm2
		  __m128 v24; // xmm3
		  __m128 v25; // xmm4
		  __m128 v26; // xmm5
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __m128i v29; // xmm1
		  float z; // eax
		  Matrix4x4 *v31; // rax
		  __int128 v32; // xmm1
		  Matrix4x4 *result; // rax
		  Vector3 v34; // [rsp+30h] [rbp-D0h] BYREF
		  Vector3 v35; // [rsp+40h] [rbp-C0h] BYREF
		  __int128 v36; // [rsp+50h] [rbp-B0h]
		  __int128 v37; // [rsp+60h] [rbp-A0h]
		  __int128 v38; // [rsp+70h] [rbp-90h]
		  __m128i v39; // [rsp+80h] [rbp-80h]
		  Vector3 v40; // [rsp+90h] [rbp-70h] BYREF
		  Quaternion v41; // [rsp+A0h] [rbp-60h] BYREF
		  Matrix4x4 v42; // [rsp+B0h] [rbp-50h] BYREF
		  Matrix4x4 v43; // [rsp+F0h] [rbp-10h] BYREF
		  Matrix4x4 v44; // [rsp+130h] [rbp+30h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2191, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2191, 0LL);
		    if ( Patch )
		    {
		      z = lightPosition->z;
		      *(_QWORD *)&v34.x = *(_QWORD *)&lightPosition->x;
		      v34.z = z;
		      v31 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_880(&v44, Patch, &v34, faceID, 0LL);
		      v32 = *(_OWORD *)&v31->m01;
		      *(_OWORD *)&retstr->m00 = *(_OWORD *)&v31->m00;
		      v28 = *(_OWORD *)&v31->m02;
		      *(_OWORD *)&retstr->m01 = v32;
		      v29 = *(__m128i *)&v31->m03;
		      goto LABEL_9;
		    }
		LABEL_7:
		    sub_1800D8260(k_CubemapOrthoBases, Patch);
		  }
		  sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		  k_CubemapOrthoBases = TypeInfo::HG::Rendering::Runtime::HGShadowUtils->static_fields->k_CubemapOrthoBases;
		  if ( !k_CubemapOrthoBases )
		    goto LABEL_7;
		  sub_180049C60(k_CubemapOrthoBases, &v40, 3 * faceID);
		  k_CubemapOrthoBases = TypeInfo::HG::Rendering::Runtime::HGShadowUtils->static_fields->k_CubemapOrthoBases;
		  if ( !k_CubemapOrthoBases )
		    goto LABEL_7;
		  sub_180049C60(k_CubemapOrthoBases, &v35, faceID + 2 * faceID + 1);
		  k_CubemapOrthoBases = TypeInfo::HG::Rendering::Runtime::HGShadowUtils->static_fields->k_CubemapOrthoBases;
		  if ( !k_CubemapOrthoBases )
		    goto LABEL_7;
		  sub_180049C60(k_CubemapOrthoBases, &v34, faceID + 2 * (faceID + 1));
		  *(_QWORD *)&v36 = __PAIR64__(LODWORD(v35.x), LODWORD(v40.x));
		  *((_QWORD *)&v36 + 1) = LODWORD(v34.x);
		  *(_QWORD *)&v37 = __PAIR64__(LODWORD(v35.y), LODWORD(v40.y));
		  *((_QWORD *)&v37 + 1) = LODWORD(v34.y);
		  *(_QWORD *)&v38 = __PAIR64__(LODWORD(v35.z), LODWORD(v40.z));
		  v9 = lightPosition->z;
		  si128 = _mm_load_si128((const __m128i *)&xmmword_18B959540);
		  *((_QWORD *)&v38 + 1) = LODWORD(v34.z);
		  *(_QWORD *)&v34.x = *(_QWORD *)&lightPosition->x;
		  v39 = si128;
		  v34.z = v9;
		  one = UnityEngine::Vector3::get_one(&v40, v11);
		  v13 = *(_QWORD *)&one->x;
		  *(float *)&one = one->z;
		  *(_QWORD *)&v35.x = v13;
		  LODWORD(v35.z) = (_DWORD)one;
		  v41 = *UnityEngine::Quaternion::get_identity(&v41, v14);
		  v16 = UnityEngine::Vector3::op_UnaryNegation(&v40, &v34, v15);
		  v17 = *(_QWORD *)&v16->x;
		  *(float *)&v16 = v16->z;
		  *(_QWORD *)&v34.x = v17;
		  LODWORD(v34.z) = (_DWORD)v16;
		  v18 = UnityEngine::Matrix4x4::TRS(&v42, &v34, &v41, &v35, 0LL);
		  v19 = *(_OWORD *)&v18->m01;
		  *(_OWORD *)&v43.m00 = *(_OWORD *)&v18->m00;
		  v20 = *(_OWORD *)&v18->m02;
		  *(_OWORD *)&v43.m01 = v19;
		  v21 = *(_OWORD *)&v18->m03;
		  *(_OWORD *)&v43.m02 = v20;
		  *(_OWORD *)&v42.m00 = v36;
		  *(_OWORD *)&v43.m03 = v21;
		  *(_OWORD *)&v42.m02 = v38;
		  *(_OWORD *)&v42.m01 = v37;
		  *(__m128i *)&v42.m03 = si128;
		  v22 = UnityEngine::Matrix4x4::op_Multiply(&v44, &v42, &v43, 0LL);
		  v23 = *(__m128 *)&v22->m00;
		  v24 = *(__m128 *)&v22->m01;
		  v25 = *(__m128 *)&v22->m02;
		  v26 = *(__m128 *)&v22->m03;
		  LODWORD(v36) = *(_OWORD *)&v22->m00;
		  DWORD1(v36) = _mm_shuffle_ps(v23, v23, 85).m128_u32[0];
		  DWORD2(v36) = _mm_shuffle_ps(v23, v23, 170).m128_u32[0];
		  DWORD1(v37) = _mm_shuffle_ps(v24, v24, 85).m128_u32[0];
		  DWORD2(v37) = _mm_shuffle_ps(v24, v24, 170).m128_u32[0];
		  LODWORD(v37) = v24.m128_i32[0];
		  DWORD1(v38) = _mm_shuffle_ps(v25, v25, 85).m128_u32[0];
		  DWORD2(v38) = _mm_shuffle_ps(v25, v25, 170).m128_u32[0];
		  HIDWORD(v36) = _mm_shuffle_ps(v23, v23, 255).m128_u32[0];
		  HIDWORD(v37) = _mm_shuffle_ps(v24, v24, 255).m128_u32[0];
		  LODWORD(v38) = v25.m128_i32[0];
		  v39.m128i_i32[0] = v26.m128_i32[0];
		  v39.m128i_i32[1] = _mm_shuffle_ps(v26, v26, 85).m128_u32[0];
		  v39.m128i_i32[2] = _mm_shuffle_ps(v26, v26, 170).m128_u32[0];
		  v27 = v37;
		  *(_OWORD *)&retstr->m00 = v36;
		  *(_OWORD *)&retstr->m01 = v27;
		  HIDWORD(v38) = _mm_shuffle_ps(v25, v25, 255).m128_u32[0];
		  v28 = v38;
		  v39.m128i_i32[3] = _mm_shuffle_ps(v26, v26, 255).m128_u32[0];
		  v29 = v39;
		LABEL_9:
		  result = retstr;
		  *(_OWORD *)&retstr->m02 = v28;
		  *(__m128i *)&retstr->m03 = v29;
		  return result;
		}
		
		public static Matrix4x4 ExtractPointLightMatrix(Vector3 lightPosition, int faceID, float nearPlane, float farPlane, float guardAngle, out Matrix4x4 view, out Matrix4x4 proj, out Matrix4x4 deviceProjYFlip) {
			view = default;
			proj = default;
			deviceProjYFlip = default;
			return default;
		} // 0x0000000189B50C00-0x0000000189B50F00
		// Matrix4x4 ExtractPointLightMatrix(Vector3, Int32, Single, Single, Single, Matrix4x4 ByRef, Matrix4x4 ByRef, Matrix4x4 ByRef)
		Matrix4x4 *HG::Rendering::Runtime::HGShadowUtils::ExtractPointLightMatrix(
		        Matrix4x4 *__return_ptr retstr,
		        Vector3 *lightPosition,
		        int32_t faceID,
		        float nearPlane,
		        float farPlane,
		        float guardAngle,
		        Matrix4x4 *view,
		        Matrix4x4 *proj,
		        Matrix4x4 *deviceProjYFlip,
		        MethodInfo *method)
		{
		  float z; // eax
		  Matrix4x4 *PointLightViewMatrix; // rax
		  __int128 v16; // xmm1
		  __int128 v17; // xmm2
		  __int128 v18; // xmm3
		  Matrix4x4 *v19; // rax
		  __int128 v20; // xmm2
		  __int128 v21; // xmm3
		  __int128 v22; // xmm4
		  __int128 v23; // xmm5
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  __int128 v26; // xmm1
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  Matrix4x4 *GPUProjectionMatrix; // rax
		  __int128 v31; // xmm1
		  __int128 v32; // xmm6
		  __int128 v33; // xmm7
		  __int128 v34; // xmm8
		  __int128 v35; // xmm9
		  __int128 v36; // xmm0
		  __int128 v37; // xmm1
		  Matrix4x4 *v38; // rax
		  __int128 v39; // xmm0
		  __int128 v40; // xmm1
		  __int128 v41; // xmm2
		  __int128 v42; // xmm3
		  __int128 v43; // xmm1
		  __int128 v44; // xmm0
		  __int128 v45; // xmm1
		  Matrix4x4 *v46; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v48; // rcx
		  __int64 v49; // xmm0_8
		  __int128 v50; // xmm1
		  __int128 v51; // xmm0
		  __int128 v52; // xmm1
		  Matrix4x4 *result; // rax
		  Vector3 v54; // [rsp+68h] [rbp-A0h] BYREF
		  Matrix4x4 v55; // [rsp+78h] [rbp-90h] BYREF
		  Matrix4x4 v56; // [rsp+B8h] [rbp-50h] BYREF
		  Matrix4x4 v57[2]; // [rsp+F8h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2190, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2190, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v48, 0LL);
		    v49 = *(_QWORD *)&lightPosition->x;
		    v54.z = lightPosition->z;
		    *(_QWORD *)&v54.x = v49;
		    v46 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_881(
		            v57,
		            Patch,
		            &v54,
		            faceID,
		            nearPlane,
		            farPlane,
		            guardAngle,
		            view,
		            proj,
		            deviceProjYFlip,
		            0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGShadowUtils);
		    z = lightPosition->z;
		    *(_QWORD *)&v54.x = *(_QWORD *)&lightPosition->x;
		    v54.z = z;
		    PointLightViewMatrix = HG::Rendering::Runtime::HGShadowUtils::GetPointLightViewMatrix(&v55, &v54, faceID, 0LL);
		    v16 = *(_OWORD *)&PointLightViewMatrix->m01;
		    v17 = *(_OWORD *)&PointLightViewMatrix->m02;
		    v18 = *(_OWORD *)&PointLightViewMatrix->m03;
		    *(_OWORD *)&view->m00 = *(_OWORD *)&PointLightViewMatrix->m00;
		    *(_OWORD *)&view->m01 = v16;
		    *(_OWORD *)&view->m02 = v17;
		    *(_OWORD *)&view->m03 = v18;
		    v19 = HG::Rendering::Runtime::HGShadowUtils::ExtractSpotLightProjectionMatrix(
		            &v55,
		            90.0,
		            nearPlane,
		            farPlane,
		            guardAngle,
		            0LL);
		    v20 = *(_OWORD *)&v19->m00;
		    v21 = *(_OWORD *)&v19->m01;
		    v22 = *(_OWORD *)&v19->m02;
		    v23 = *(_OWORD *)&v19->m03;
		    *(_OWORD *)&proj->m00 = *(_OWORD *)&v19->m00;
		    *(_OWORD *)&proj->m01 = v21;
		    *(_OWORD *)&proj->m02 = v22;
		    *(_OWORD *)&proj->m03 = v23;
		    v24 = *(_OWORD *)&view->m01;
		    *(_OWORD *)&v56.m00 = *(_OWORD *)&view->m00;
		    v25 = *(_OWORD *)&view->m02;
		    *(_OWORD *)&v56.m01 = v24;
		    v26 = *(_OWORD *)&view->m03;
		    *(_OWORD *)&v56.m02 = v25;
		    *(_OWORD *)&v56.m03 = v26;
		    *(_OWORD *)&v55.m00 = v20;
		    *(_OWORD *)&v55.m01 = v21;
		    *(_OWORD *)&v55.m02 = v22;
		    *(_OWORD *)&v55.m03 = v23;
		    UnityEngine::Matrix4x4::op_Multiply(v57, &v55, &v56, 0LL);
		    v27 = *(_OWORD *)&proj->m01;
		    *(_OWORD *)&v55.m00 = *(_OWORD *)&proj->m00;
		    v28 = *(_OWORD *)&proj->m02;
		    *(_OWORD *)&v55.m01 = v27;
		    v29 = *(_OWORD *)&proj->m03;
		    *(_OWORD *)&v55.m02 = v28;
		    *(_OWORD *)&v55.m03 = v29;
		    GPUProjectionMatrix = UnityEngine::GL::GetGPUProjectionMatrix(v57, &v55, 0, 0LL);
		    v31 = *(_OWORD *)&proj->m01;
		    v32 = *(_OWORD *)&GPUProjectionMatrix->m00;
		    v33 = *(_OWORD *)&GPUProjectionMatrix->m01;
		    v34 = *(_OWORD *)&GPUProjectionMatrix->m02;
		    v35 = *(_OWORD *)&GPUProjectionMatrix->m03;
		    *(_OWORD *)&v55.m00 = *(_OWORD *)&proj->m00;
		    v36 = *(_OWORD *)&proj->m02;
		    *(_OWORD *)&v55.m01 = v31;
		    v37 = *(_OWORD *)&proj->m03;
		    *(_OWORD *)&v55.m02 = v36;
		    *(_OWORD *)&v55.m03 = v37;
		    v38 = UnityEngine::GL::GetGPUProjectionMatrix(v57, &v55, 1, 0LL);
		    *(_OWORD *)&v56.m00 = v32;
		    *(_OWORD *)&v56.m01 = v33;
		    *(_OWORD *)&v56.m02 = v34;
		    v39 = *(_OWORD *)&v38->m00;
		    v40 = *(_OWORD *)&v38->m01;
		    v41 = *(_OWORD *)&v38->m02;
		    v42 = *(_OWORD *)&v38->m03;
		    *(_OWORD *)&v56.m03 = v35;
		    *(_OWORD *)&deviceProjYFlip->m00 = v39;
		    *(_OWORD *)&deviceProjYFlip->m01 = v40;
		    *(_OWORD *)&deviceProjYFlip->m02 = v41;
		    *(_OWORD *)&deviceProjYFlip->m03 = v42;
		    v43 = *(_OWORD *)&view->m01;
		    *(_OWORD *)&v55.m00 = *(_OWORD *)&view->m00;
		    v44 = *(_OWORD *)&view->m02;
		    *(_OWORD *)&v55.m01 = v43;
		    v45 = *(_OWORD *)&view->m03;
		    *(_OWORD *)&v55.m02 = v44;
		    *(_OWORD *)&v55.m03 = v45;
		    v46 = UnityEngine::Rendering::CoreMatrixUtils::MultiplyPerspectiveMatrix(v57, &v56, &v55, 0LL);
		  }
		  v50 = *(_OWORD *)&v46->m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v46->m00;
		  v51 = *(_OWORD *)&v46->m02;
		  *(_OWORD *)&retstr->m01 = v50;
		  v52 = *(_OWORD *)&v46->m03;
		  result = retstr;
		  *(_OWORD *)&retstr->m02 = v51;
		  *(_OWORD *)&retstr->m03 = v52;
		  return result;
		}
		
		public static void ApplySliceTransform(Vector2 scale, Vector2 offset, ref Matrix4x4 shadowTransform) {} // 0x0000000189B50670-0x0000000189B507E0
		// Void ApplySliceTransform(Vector2, Vector2, Matrix4x4 ByRef)
		void HG::Rendering::Runtime::HGShadowUtils::ApplySliceTransform(
		        Vector2 scale,
		        Vector2 offset,
		        Matrix4x4 *shadowTransform,
		        MethodInfo *method)
		{
		  Matrix4x4__StaticFields *static_fields; // rcx
		  __int128 v8; // xmm1
		  __int128 v9; // xmm3
		  __int128 v10; // xmm0
		  __int128 v11; // xmm0
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  Matrix4x4 *v15; // rax
		  __int128 v16; // xmm1
		  __int128 v17; // xmm2
		  __int128 v18; // xmm3
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  Vector2 v23; // [rsp+40h] [rbp-C8h]
		  Matrix4x4 v24; // [rsp+48h] [rbp-C0h] BYREF
		  Matrix4x4 v25; // [rsp+88h] [rbp-80h] BYREF
		  Matrix4x4 v26; // [rsp+C8h] [rbp-40h] BYREF
		
		  v23 = offset;
		  if ( IFix::WrappersManagerImpl::IsPatched(2239, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2239, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v21, v20);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_898(Patch, scale, offset, shadowTransform, 0LL);
		  }
		  else
		  {
		    static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    v8 = *(_OWORD *)&static_fields->identityMatrix.m01;
		    v9 = *(_OWORD *)&static_fields->identityMatrix.m02;
		    *(_OWORD *)&v24.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		    v10 = *(_OWORD *)&static_fields->identityMatrix.m03;
		    *(_OWORD *)&v24.m01 = v8;
		    *(_OWORD *)&v24.m03 = v10;
		    v24.m11 = scale.y;
		    v24.m13 = v23.y * scale.x;
		    v11 = *(_OWORD *)&shadowTransform->m00;
		    v24.m03 = v23.x * scale.x;
		    v12 = *(_OWORD *)&shadowTransform->m01;
		    *(_OWORD *)&v25.m00 = v11;
		    v13 = *(_OWORD *)&shadowTransform->m02;
		    *(_OWORD *)&v25.m01 = v12;
		    v14 = *(_OWORD *)&shadowTransform->m03;
		    *(_OWORD *)&v25.m02 = v13;
		    v24.m00 = scale.x;
		    *(_OWORD *)&v26.m00 = *(_OWORD *)&v24.m00;
		    *(_OWORD *)&v25.m03 = v14;
		    *(_OWORD *)&v26.m03 = *(_OWORD *)&v24.m03;
		    *(_OWORD *)&v26.m01 = *(_OWORD *)&v24.m01;
		    *(_OWORD *)&v26.m02 = v9;
		    v15 = UnityEngine::Matrix4x4::op_Multiply(&v24, &v26, &v25, 0LL);
		    v16 = *(_OWORD *)&v15->m01;
		    v17 = *(_OWORD *)&v15->m02;
		    v18 = *(_OWORD *)&v15->m03;
		    *(_OWORD *)&shadowTransform->m00 = *(_OWORD *)&v15->m00;
		    *(_OWORD *)&shadowTransform->m01 = v16;
		    *(_OWORD *)&shadowTransform->m02 = v17;
		    *(_OWORD *)&shadowTransform->m03 = v18;
		  }
		}
		
		public static Matrix4x4 GetShadowTransform(Matrix4x4 proj, Matrix4x4 view) => default; // 0x0000000189B518C0-0x0000000189B51B64
		// Matrix4x4 GetShadowTransform(Matrix4x4, Matrix4x4)
		Matrix4x4 *HG::Rendering::Runtime::HGShadowUtils::GetShadowTransform(
		        Matrix4x4 *__return_ptr retstr,
		        Matrix4x4 *proj,
		        Matrix4x4 *view,
		        MethodInfo *method)
		{
		  float m20; // xmm2_4
		  __int128 v8; // xmm1
		  __int128 v9; // xmm0
		  float m21; // xmm2_4
		  __int128 v11; // xmm0
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  float m22; // xmm2_4
		  __int128 v15; // xmm0
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  __int128 v19; // xmm0
		  __int128 v20; // xmm0
		  __int128 v21; // xmm1
		  __int128 v22; // xmm0
		  __int128 v23; // xmm1
		  __int128 v24; // xmm0
		  __int128 v25; // xmm1
		  __int128 v26; // xmm0
		  __int128 v27; // xmm1
		  Matrix4x4 *v28; // rax
		  Matrix4x4__StaticFields *static_fields; // rdx
		  __int128 v30; // xmm1
		  __int128 v31; // xmm0
		  __int128 v32; // xmm1
		  __int128 v33; // xmm0
		  __int128 v34; // xmm1
		  __int128 v35; // xmm0
		  __int128 v36; // xmm1
		  Matrix4x4 *v37; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v39; // rdx
		  __int64 v40; // rcx
		  __int128 v41; // xmm1
		  __int128 v42; // xmm0
		  __int128 v43; // xmm1
		  __int128 v44; // xmm0
		  __int128 v45; // xmm1
		  __int128 v46; // xmm0
		  __int128 v47; // xmm1
		  __int128 v48; // xmm1
		  __int128 v49; // xmm0
		  __int128 v50; // xmm1
		  Matrix4x4 *result; // rax
		  Matrix4x4 v52; // [rsp+38h] [rbp-D0h] BYREF
		  Matrix4x4 v53; // [rsp+78h] [rbp-90h] BYREF
		  Matrix4x4 v54; // [rsp+B8h] [rbp-50h] BYREF
		  Matrix4x4 v55; // [rsp+F8h] [rbp-10h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1899, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1899, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v40, v39);
		    v41 = *(_OWORD *)&view->m01;
		    *(_OWORD *)&v52.m00 = *(_OWORD *)&view->m00;
		    v42 = *(_OWORD *)&view->m02;
		    *(_OWORD *)&v52.m01 = v41;
		    v43 = *(_OWORD *)&view->m03;
		    *(_OWORD *)&v52.m02 = v42;
		    v44 = *(_OWORD *)&proj->m00;
		    *(_OWORD *)&v52.m03 = v43;
		    v45 = *(_OWORD *)&proj->m01;
		    *(_OWORD *)&v54.m00 = v44;
		    v46 = *(_OWORD *)&proj->m02;
		    *(_OWORD *)&v54.m01 = v45;
		    v47 = *(_OWORD *)&proj->m03;
		    *(_OWORD *)&v54.m02 = v46;
		    *(_OWORD *)&v54.m03 = v47;
		    v37 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_761(&v55, Patch, &v54, &v52, 0LL);
		  }
		  else
		  {
		    if ( UnityEngine::SystemInfo::UsesReversedZBuffer(0LL) )
		    {
		      m20 = proj->m20;
		      v8 = *(_OWORD *)&proj->m02;
		      *(_OWORD *)&v52.m01 = *(_OWORD *)&proj->m01;
		      v9 = *(_OWORD *)&proj->m03;
		      proj->m20 = -m20;
		      m21 = proj->m21;
		      *(_OWORD *)&v52.m03 = v9;
		      v11 = *(_OWORD *)&proj->m00;
		      *(_OWORD *)&v52.m02 = v8;
		      v12 = *(_OWORD *)&proj->m03;
		      *(_OWORD *)&v52.m00 = v11;
		      v13 = *(_OWORD *)&proj->m02;
		      proj->m21 = -m21;
		      m22 = proj->m22;
		      *(_OWORD *)&v52.m02 = v13;
		      v15 = *(_OWORD *)&proj->m00;
		      *(_OWORD *)&v52.m03 = v12;
		      v16 = *(_OWORD *)&proj->m01;
		      *(_OWORD *)&v52.m00 = v15;
		      v17 = *(_OWORD *)&proj->m03;
		      proj->m22 = -m22;
		      *(_OWORD *)&v52.m01 = v16;
		      v18 = *(_OWORD *)&proj->m01;
		      *(_OWORD *)&v52.m03 = v17;
		      v19 = *(_OWORD *)&proj->m00;
		      *(_OWORD *)&v52.m01 = v18;
		      *(float *)&v18 = proj->m23;
		      *(_OWORD *)&v52.m00 = v19;
		      v20 = *(_OWORD *)&proj->m02;
		      proj->m23 = -*(float *)&v18;
		      *(_OWORD *)&v52.m02 = v20;
		    }
		    v21 = *(_OWORD *)&view->m01;
		    *(_OWORD *)&v53.m00 = *(_OWORD *)&view->m00;
		    v22 = *(_OWORD *)&view->m02;
		    *(_OWORD *)&v53.m01 = v21;
		    v23 = *(_OWORD *)&view->m03;
		    *(_OWORD *)&v53.m02 = v22;
		    v24 = *(_OWORD *)&proj->m00;
		    *(_OWORD *)&v53.m03 = v23;
		    v25 = *(_OWORD *)&proj->m01;
		    *(_OWORD *)&v54.m00 = v24;
		    v26 = *(_OWORD *)&proj->m02;
		    *(_OWORD *)&v54.m01 = v25;
		    v27 = *(_OWORD *)&proj->m03;
		    *(_OWORD *)&v54.m02 = v26;
		    *(_OWORD *)&v54.m03 = v27;
		    v28 = UnityEngine::Matrix4x4::op_Multiply(&v55, &v54, &v53, 0LL);
		    static_fields = TypeInfo::UnityEngine::Matrix4x4->static_fields;
		    v30 = *(_OWORD *)&static_fields->identityMatrix.m01;
		    *(_OWORD *)&v53.m00 = *(_OWORD *)&static_fields->identityMatrix.m00;
		    v31 = *(_OWORD *)&static_fields->identityMatrix.m02;
		    v53.m00 = 0.5;
		    *(_OWORD *)&v53.m01 = v30;
		    v32 = *(_OWORD *)&static_fields->identityMatrix.m03;
		    v53.m11 = 0.5;
		    *(_OWORD *)&v53.m02 = v31;
		    v33 = *(_OWORD *)&v28->m00;
		    v53.m22 = 0.5;
		    *(_OWORD *)&v53.m03 = v32;
		    v34 = *(_OWORD *)&v28->m01;
		    v53.m03 = 0.5;
		    *(_OWORD *)&v52.m00 = v33;
		    v35 = *(_OWORD *)&v28->m02;
		    *(_OWORD *)&v52.m01 = v34;
		    v36 = *(_OWORD *)&v28->m03;
		    *(_QWORD *)&v53.m13 = 0x3F0000003F000000LL;
		    *(_OWORD *)&v52.m02 = v35;
		    *(_OWORD *)&v52.m03 = v36;
		    v54 = v53;
		    v37 = UnityEngine::Matrix4x4::op_Multiply(&v55, &v54, &v52, 0LL);
		  }
		  v48 = *(_OWORD *)&v37->m01;
		  *(_OWORD *)&retstr->m00 = *(_OWORD *)&v37->m00;
		  v49 = *(_OWORD *)&v37->m02;
		  *(_OWORD *)&retstr->m01 = v48;
		  v50 = *(_OWORD *)&v37->m03;
		  result = retstr;
		  *(_OWORD *)&retstr->m02 = v49;
		  *(_OWORD *)&retstr->m03 = v50;
		  return result;
		}
		
		public static Vector4 GetShadowBias(Matrix4x4 lightProjectionMatrix, float shadowResolution, float depthBiasScale, float normalBiasScale, HGShadowSampleMode sampleMode) => default; // 0x0000000189B51728-0x0000000189B51864
		// Vector4 GetShadowBias(Matrix4x4, Single, Single, Single, HGShadowSampleMode)
		Vector4 *HG::Rendering::Runtime::HGShadowUtils::GetShadowBias(
		        Vector4 *__return_ptr retstr,
		        Matrix4x4 *lightProjectionMatrix,
		        float shadowResolution,
		        float depthBiasScale,
		        float normalBiasScale,
		        HGShadowSampleMode__Enum sampleMode,
		        MethodInfo *method)
		{
		  float v10; // xmm3_4
		  float v11; // xmm2_4
		  float v12; // xmm1_4
		  float v13; // xmm0_4
		  ILFixDynamicMethodWrapper_2 *Patch; // rdx
		  __int64 v15; // rcx
		  __int128 v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  Vector4 v20; // [rsp+40h] [rbp-78h] BYREF
		  Matrix4x4 v21; // [rsp+50h] [rbp-68h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2112, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2112, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v15, 0LL);
		    v16 = *(_OWORD *)&lightProjectionMatrix->m01;
		    *(_OWORD *)&v21.m00 = *(_OWORD *)&lightProjectionMatrix->m00;
		    v17 = *(_OWORD *)&lightProjectionMatrix->m02;
		    *(_OWORD *)&v21.m01 = v16;
		    v18 = *(_OWORD *)&lightProjectionMatrix->m03;
		    *(_OWORD *)&v21.m02 = v17;
		    *(_OWORD *)&v21.m03 = v18;
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_850(
		                 &v20,
		                 Patch,
		                 &v21,
		                 shadowResolution,
		                 depthBiasScale,
		                 normalBiasScale,
		                 sampleMode,
		                 0LL);
		  }
		  else
		  {
		    v10 = (float)(2.0 / COERCE_FLOAT(*(_OWORD *)&lightProjectionMatrix->m00)) / shadowResolution;
		    v11 = v10 * normalBiasScale;
		    v12 = v10 * depthBiasScale;
		    if ( (sampleMode & 0xFFFFFFFB) != 0 )
		    {
		      v13 = 2.5;
		      if ( sampleMode - 1 <= 1 )
		        v13 = 1.5;
		      v12 = v12 * v13;
		      v11 = v11 * v13;
		    }
		    retstr->w = 0.0;
		    retstr->x = v12;
		    retstr->y = v11;
		    retstr->z = v10;
		  }
		  return retstr;
		}
		
		public static float GetShadowStrength(ref VisibleLight shadowLight) => default; // 0x0000000189B51864-0x0000000189B518C0
		// Single GetShadowStrength(VisibleLight ByRef)
		float HG::Rendering::Runtime::HGShadowUtils::GetShadowStrength(VisibleLight *shadowLight, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGSharedLightData _unity_self; // [rsp+40h] [rbp+18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2240, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2240, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_899(Patch, shadowLight, 0LL);
		  }
		  else
		  {
		    _unity_self = shadowLight->hgSharedLightData;
		    return UnityEngine::HGSharedLightData::get_shadowStrength_Injected(&_unity_self, 0LL);
		  }
		}
		
	}
}
