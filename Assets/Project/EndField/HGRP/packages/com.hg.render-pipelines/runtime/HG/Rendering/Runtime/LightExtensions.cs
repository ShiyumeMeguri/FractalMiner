using System;
using IFix.Core;
using Unity.Mathematics;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public static class LightExtensions
	{
		public static HGAdditionalLightData GetHGAdditionalLightData(this Light light)
		{
			// // HGAdditionalLightData GetHGAdditionalLightData(Light)
			// HGAdditionalLightData *HG::Rendering::Runtime::LightExtensions::GetHGAdditionalLightData(
			//         Light *light,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   int *wrapperArray; // rdx
			//   __int64 (__fastcall *v5)(Light *); // rax
			//   GameObject *v6; // rdi
			//   struct MethodInfo *v7; // rbx
			//   System::Type **rgctx_data; // rbx
			//   System::Type *v9; // rbx
			//   void (__fastcall *v10)(GameObject *, System::Type *, _QWORD, char *); // rax
			//   HGRenderPathBase_HGRenderPathResources *v11; // rdx
			//   PassConstructorID__Enum__Array *v12; // r8
			//   HGCamera *v13; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rax
			//   __int64 v17; // rax
			//   __int128 v18; // [rsp+20h] [rbp-18h] BYREF
			//   HGAdditionalLightData *v19; // [rsp+50h] [rbp+18h] BYREF
			// 
			//   if ( !byte_18D8EDCD9 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HGAdditionalLightData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::TryGetComponent<HG::Rendering::Runtime::HGAdditionalLightData>);
			//     byte_18D8EDCD9 = 1;
			//   }
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
			//   wrapperArray = (int *)v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_27;
			//   if ( wrapperArray[6] <= 968 )
			//     goto LABEL_9;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			// LABEL_27:
			//     sub_180B536AC(v3, wrapperArray);
			//   if ( LODWORD(v3._0.namespaze) <= 0x3C8 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( *(_QWORD *)&v3[20]._1.element_size )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(968, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_357(Patch, (Object *)light, 0LL);
			//     goto LABEL_27;
			//   }
			// LABEL_9:
			//   if ( !light )
			//     goto LABEL_27;
			//   v5 = (__int64 (__fastcall *)(Light *))qword_18D8F4D48;
			//   if ( !qword_18D8F4D48 )
			//   {
			//     v5 = (__int64 (__fastcall *)(Light *))il2cpp_resolve_icall_0("UnityEngine.Component::get_gameObject()");
			//     if ( !v5 )
			//     {
			//       v16 = sub_1802DBBE8("UnityEngine.Component::get_gameObject()");
			//       sub_18000F750(v16, 0LL);
			//     }
			//     qword_18D8F4D48 = (__int64)v5;
			//   }
			//   v6 = (GameObject *)v5(light);
			//   if ( !v6 )
			//     goto LABEL_27;
			//   v7 = MethodInfo::UnityEngine::GameObject::TryGetComponent<HG::Rendering::Runtime::HGAdditionalLightData>;
			//   if ( !MethodInfo::UnityEngine::GameObject::TryGetComponent<HG::Rendering::Runtime::HGAdditionalLightData>.rgctx_data )
			//   {
			//     sub_18003C530(&TypeInfo::System::Type);
			//     if ( !v7.rgctx_data )
			//       sub_180041F40(v7);
			//   }
			//   rgctx_data = (System::Type **)v7.rgctx_data;
			//   v18 = 0LL;
			//   v9 = *rgctx_data;
			//   if ( !TypeInfo::System::Type._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::Type, wrapperArray);
			//   if ( !byte_18D8F235A )
			//   {
			//     sub_18003C530(&TypeInfo::System::Type);
			//     byte_18D8F235A = 1;
			//   }
			//   if ( v9 )
			//   {
			//     if ( !TypeInfo::System::Type._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::System::Type, wrapperArray);
			//     v9 = (System::Type *)System::Type::internal_from_handle(v9, wrapperArray);
			//   }
			//   v10 = (void (__fastcall *)(GameObject *, System::Type *, _QWORD, char *))qword_18D8F4DB8;
			//   if ( !qword_18D8F4DB8 )
			//   {
			//     v10 = (void (__fastcall *)(GameObject *, System::Type *, _QWORD, char *))il2cpp_resolve_icall_0(
			//                                                                                "UnityEngine.GameObject::TryGetComponentFa"
			//                                                                                "stPath(System.Type,System.Int32,System.IntPtr)");
			//     if ( !v10 )
			//     {
			//       v17 = sub_1802DBBE8("UnityEngine.GameObject::TryGetComponentFastPath(System.Type,System.Int32,System.IntPtr)");
			//       sub_18000F750(v17, 0LL);
			//     }
			//     qword_18D8F4DB8 = (__int64)v10;
			//   }
			//   v10(v6, v9, 0LL, (char *)&v18 + 8);
			//   v19 = (HGAdditionalLightData *)v18;
			//   sub_1800054D0((HGRenderPathScene *)&v19, v11, v12, v13, (MethodInfo *)v18, *((MethodInfo **)&v18 + 1));
			//   if ( (_QWORD)v18 )
			//     return v19;
			//   else
			//     return (HGAdditionalLightData *)UnityEngine::GameObject::AddComponent<System::Object>(
			//                                       v6,
			//                                       MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HGAdditionalLightData>);
			// }
			// 
			return null;
		}

		private static float3 RgbToHsv(float3 c)
		{
			// // float3 RgbToHsv(float3)
			// float3 *HG::Rendering::Runtime::LightExtensions::RgbToHsv(float3 *__return_ptr retstr, float3 *c, MethodInfo *method)
			// {
			//   float v5; // xmm0_4
			//   float y; // xmm1_4
			//   const __m128i *v7; // rax
			//   __m128 v8; // xmm4
			//   __m128 v9; // xmm5
			//   float v10; // xmm4_4
			//   __m128i v11; // xmm1
			//   float v12; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v14; // rcx
			//   float z; // eax
			//   float3 *v16; // rax
			//   __int64 v17; // xmm0_8
			//   unsigned __int64 v19; // [rsp+30h] [rbp-30h] BYREF
			//   __int64 v20; // [rsp+38h] [rbp-28h]
			//   float3 v21; // [rsp+40h] [rbp-20h] BYREF
			//   int v22; // [rsp+4Ch] [rbp-14h]
			//   _BYTE v23[16]; // [rsp+50h] [rbp-10h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1555, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1555, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v14, 0LL);
			//     z = c.z;
			//     v19 = *(_QWORD *)&c.x;
			//     *(float *)&v20 = z;
			//     v16 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_597(&v21, Patch, (float3 *)&v19, 0LL);
			//     v17 = *(_QWORD *)&v16.x;
			//     *(float *)&v16 = v16.z;
			//     *(_QWORD *)&retstr.x = v17;
			//     LODWORD(retstr.z) = (_DWORD)v16;
			//   }
			//   else
			//   {
			//     v5 = c.z;
			//     y = c.y;
			//     v20 = 0x3F2AAAABBF800000LL;
			//     v22 = -1096111445;
			//     v19 = __PAIR64__(LODWORD(y), LODWORD(v5));
			//     v21.x = y;
			//     *(_QWORD *)&v21.y = LODWORD(v5);
			//     v7 = (const __m128i *)sub_184D3C2A4(v23, &v19, &v21);
			//     HIDWORD(v20) = LODWORD(c.x);
			//     v21.x = *((float *)&v20 + 1);
			//     v8 = (__m128)_mm_loadu_si128(v7);
			//     LODWORD(v19) = v8.m128_i32[0];
			//     LODWORD(v20) = _mm_shuffle_ps(v8, v8, 255).m128_u32[0];
			//     LODWORD(v21.z) = _mm_shuffle_ps(v8, v8, 170).m128_u32[0];
			//     HIDWORD(v19) = _mm_shuffle_ps(v8, v8, 85).m128_u32[0];
			//     v21.y = *((float *)&v19 + 1);
			//     v22 = v8.m128_i32[0];
			//     v9 = (__m128)_mm_loadu_si128((const __m128i *)sub_184D3C2A4(v23, &v19, &v21));
			//     v10 = _mm_shuffle_ps(v9, v9, 85).m128_f32[0];
			//     v11 = (__m128i)_mm_shuffle_ps(v9, v9, 255);
			//     if ( v10 > *(float *)v11.m128i_i32 )
			//       v12 = *(float *)v11.m128i_i32;
			//     else
			//       v12 = v10;
			//     LODWORD(retstr.z) = v9.m128_i32[0];
			//     *(float *)v11.m128i_i32 = (float)((float)(*(float *)v11.m128i_i32 - v10)
			//                                     / (float)((float)((float)(v9.m128_f32[0] - v12) * 6.0) + 0.000099999997))
			//                             + _mm_shuffle_ps(v9, v9, 170).m128_f32[0];
			//     LODWORD(retstr.x) = _mm_cvtsi128_si32(v11) & 0x7FFFFFFF;
			//     retstr.y = (float)(v9.m128_f32[0] - v12) / (float)(v9.m128_f32[0] + 0.000099999997);
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		private static float3 HsvToRgb(float3 c)
		{
			// // float3 HsvToRgb(float3)
			// float3 *HG::Rendering::Runtime::LightExtensions::HsvToRgb(float3 *__return_ptr retstr, float3 *c, MethodInfo *method)
			// {
			//   MethodInfo *v5; // r9
			//   __m128 x_low; // xmm3
			//   float3 *v7; // rax
			//   __int64 v8; // xmm2_8
			//   MethodInfo *v9; // r8
			//   float3 *v10; // rax
			//   __int64 v11; // xmm0_8
			//   MethodInfo *v12; // r9
			//   float3 *v13; // rax
			//   MethodInfo *v14; // r9
			//   float3 *v15; // rax
			//   __int64 v16; // xmm2_8
			//   MethodInfo *v17; // r8
			//   float3 *v18; // rax
			//   __int64 v19; // xmm0_8
			//   MethodInfo *v20; // r9
			//   float3 *v21; // rax
			//   __int64 v22; // xmm2_8
			//   MethodInfo *v23; // r8
			//   float3 *v24; // rax
			//   __int64 v25; // xmm4_8
			//   float3 *v26; // rax
			//   float v27; // xmm1_4
			//   __int64 v28; // xmm4_8
			//   MethodInfo *v29; // r9
			//   float3 *v30; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v32; // rcx
			//   float z; // eax
			//   __int64 v34; // xmm0_8
			//   float v35; // eax
			//   MethodInfo *v37; // [rsp+20h] [rbp-50h]
			//   float3 v38; // [rsp+30h] [rbp-40h] BYREF
			//   float3 v39; // [rsp+40h] [rbp-30h] BYREF
			//   float3 v40; // [rsp+50h] [rbp-20h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1556, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1556, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v32, 0LL);
			//     z = c.z;
			//     *(_QWORD *)&v39.x = *(_QWORD *)&c.x;
			//     v39.z = z;
			//     v30 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_597(&v40, Patch, &v39, 0LL);
			//   }
			//   else
			//   {
			//     x_low = (__m128)LODWORD(c.x);
			//     *(_QWORD *)&v38.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F2AAAABu).m128_u64[0];
			//     *(_QWORD *)&v39.x = _mm_unpacklo_ps(x_low, x_low).m128_u64[0];
			//     v38.z = 0.33333334;
			//     LODWORD(v39.z) = x_low.m128_i32[0];
			//     v7 = Unity::Mathematics::float3::op_Addition(&v40, &v39, &v38, v5);
			//     v8 = *(_QWORD *)&v7.x;
			//     *(float *)&v7 = v7.z;
			//     *(_QWORD *)&v39.x = v8;
			//     LODWORD(v39.z) = (_DWORD)v7;
			//     v10 = Unity::Mathematics::math::frac(&v40, &v39, v9);
			//     v38.z = 3.0;
			//     v11 = *(_QWORD *)&v10.x;
			//     *(float *)&v10 = v10.z;
			//     *(_QWORD *)&v39.x = v11;
			//     *(_QWORD *)&v38.x = _mm_unpacklo_ps((__m128)0x40400000u, (__m128)0x40400000u).m128_u64[0];
			//     LODWORD(v39.z) = (_DWORD)v10;
			//     v13 = Unity::Mathematics::float3::op_Multiply(&v40, &v39, 6.0, v12);
			//     x_low.m128_u64[0] = *(_QWORD *)&v13.x;
			//     *(float *)&v13 = v13.z;
			//     *(_QWORD *)&v39.x = x_low.m128_u64[0];
			//     LODWORD(v39.z) = (_DWORD)v13;
			//     v15 = Unity::Mathematics::float3::op_Subtraction(&v40, &v39, &v38, v14);
			//     v16 = *(_QWORD *)&v15.x;
			//     *(float *)&v15 = v15.z;
			//     *(_QWORD *)&v39.x = v16;
			//     LODWORD(v39.z) = (_DWORD)v15;
			//     v18 = Unity::Mathematics::math::abs(&v40, &v39, v17);
			//     v39.z = 1.0;
			//     *(_QWORD *)&v39.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
			//     v19 = *(_QWORD *)&v18.x;
			//     *(float *)&v18 = v18.z;
			//     *(_QWORD *)&v38.x = v19;
			//     LODWORD(v38.z) = (_DWORD)v18;
			//     v21 = Unity::Mathematics::float3::op_Subtraction(&v40, &v38, &v39, v20);
			//     v22 = *(_QWORD *)&v21.x;
			//     *(float *)&v21 = v21.z;
			//     *(_QWORD *)&v39.x = v22;
			//     LODWORD(v39.z) = (_DWORD)v21;
			//     v24 = Unity::Mathematics::math::saturate(&v40, &v39, v23);
			//     x_low.m128_i32[0] = LODWORD(c.y);
			//     v38.z = 1.0;
			//     v25 = *(_QWORD *)&v24.x;
			//     *(float *)&v24 = v24.z;
			//     *(_QWORD *)&v39.x = v25;
			//     LODWORD(v39.z) = (_DWORD)v24;
			//     *(_QWORD *)&v38.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
			//     v26 = Unity::Mathematics::math::lerp(&v40, &v38, &v39, x_low.m128_f32[0], v37);
			//     v27 = c.z;
			//     v28 = *(_QWORD *)&v26.x;
			//     *(float *)&v26 = v26.z;
			//     *(_QWORD *)&v39.x = v28;
			//     LODWORD(v39.z) = (_DWORD)v26;
			//     v30 = Unity::Mathematics::float3::op_Multiply(&v40, v27, &v39, v29);
			//   }
			//   v34 = *(_QWORD *)&v30.x;
			//   v35 = v30.z;
			//   *(_QWORD *)&retstr.x = v34;
			//   retstr.z = v35;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static float4 GetOriginalColorAndIntensity(this HGSharedLightData light)
		{
			// // float4 GetOriginalColorAndIntensity(HGSharedLightData)
			// float4 *HG::Rendering::Runtime::LightExtensions::GetOriginalColorAndIntensity(
			//         float4 *__return_ptr retstr,
			//         HGSharedLightData light,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v4; // r8
			//   Vector4 v5; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v7; // rdx
			//   __int64 v8; // rcx
			//   float4 *result; // rax
			//   Vector4 v10; // [rsp+20h] [rbp-20h] BYREF
			//   Vector4 v11; // [rsp+30h] [rbp-10h] BYREF
			//   HGSharedLightData _unity_self; // [rsp+58h] [rbp+18h] BYREF
			// 
			//   _unity_self = light;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1557, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1557, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v8, v7);
			//     v5 = (Vector4)*IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_598((float4 *)&v11, Patch, _unity_self, 0LL);
			//   }
			//   else
			//   {
			//     v10 = (Vector4)*UnityEngine::HGSharedLightData::get_color((Color *)&v10, &_unity_self, 0LL);
			//     v10 = *(Vector4 *)sub_182F8C840(&v11, &v10);
			//     v10 = (Vector4)*UnityEngine::Color::op_Implicit((Color *)&v11, &v10, v4);
			//     v10 = *Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//              &v11,
			//              (CinemachineSmoothPath_Waypoint *)&v10,
			//              0LL);
			//     v10.w = UnityEngine::HGSharedLightData::get_intensity_Injected(&_unity_self, 0LL);
			//     v5 = v10;
			//   }
			//   result = retstr;
			//   *(Vector4 *)retstr = v5;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static float4 GetCharacterLightColorAndIntensity(HGCamera hgCamera, Color lightColor, float originalIntensity)
		{
			// // float4 GetCharacterLightColorAndIntensity(HGCamera, Color, Single)
			// float4 *HG::Rendering::Runtime::LightExtensions::GetCharacterLightColorAndIntensity(
			//         float4 *__return_ptr retstr,
			//         HGCamera *hgCamera,
			//         Color *lightColor,
			//         float originalIntensity,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v8; // r8
			//   __m128 v9; // xmm0
			//   float3 *v10; // rax
			//   __int64 v11; // rcx
			//   float v12; // xmm4_4
			//   __m128 y_low; // xmm2
			//   float v14; // xmm7_4
			//   float3 *v15; // rax
			//   BoolParameter *charLightDialogMode; // rdx
			//   __int64 v17; // rcx
			//   float z; // esi
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
			//   float v20; // xmm6_4
			//   HGCharacterVolume *m_hgCharacterVolume; // rax
			//   __int64 v22; // rcx
			//   float v23; // xmm4_4
			//   float v24; // xmm5_4
			//   float v25; // xmm9_4
			//   float v26; // xmm3_4
			//   float v27; // xmm4_4
			//   float x; // xmm0_4
			//   float y; // xmm1_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v32; // [rsp+30h] [rbp-50h] BYREF
			//   Vector4 v33[2]; // [rsp+40h] [rbp-40h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1558, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1558, 0LL);
			//     if ( Patch )
			//     {
			//       v33[0] = *(Vector4 *)lightColor;
			//       *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_599(
			//                    (float4 *)&v32,
			//                    Patch,
			//                    (Object *)hgCamera,
			//                    (Color *)v33,
			//                    originalIntensity,
			//                    0LL);
			//       return retstr;
			//     }
			// LABEL_14:
			//     sub_180B536AC(v17, charLightDialogMode);
			//   }
			//   v33[0] = *(Vector4 *)sub_182F8C840(v33, lightColor);
			//   v33[0] = *(Vector4 *)UnityEngine::Color::op_Implicit((Color *)&v32, v33, v8);
			//   v9 = (__m128)_mm_loadu_si128((const __m128i *)Cinemachine::CinemachineSmoothPath::Waypoint::get_AsVector4(
			//                                                   &v32,
			//                                                   (CinemachineSmoothPath_Waypoint *)v33,
			//                                                   0LL));
			//   *(_QWORD *)&v32.x = _mm_unpacklo_ps(v9, _mm_shuffle_ps(v9, v9, 85)).m128_u64[0];
			//   LODWORD(v32.z) = _mm_shuffle_ps(v9, v9, 170).m128_u32[0];
			//   v10 = HG::Rendering::Runtime::LightExtensions::RgbToHsv((float3 *)v33, (float3 *)&v32, 0LL);
			//   v9.m128_u64[0] = *(_QWORD *)&v10.x;
			//   *(float *)&v10 = v10.z;
			//   *(_QWORD *)&v32.x = v9.m128_u64[0];
			//   LODWORD(v32.z) = (_DWORD)v10;
			//   v9.m128_f32[0] = sub_18238C950(v11);
			//   y_low = (__m128)0x40400000u;
			//   y_low.m128_f32[0] = (float)((float)((float)(3.0 - (float)(v9.m128_f32[0] + v9.m128_f32[0]))
			//                                     * (float)(v9.m128_f32[0] * v9.m128_f32[0]))
			//                             * -0.34999999)
			//                     + 0.69999999;
			//   if ( v32.y <= y_low.m128_f32[0] )
			//     y_low = (__m128)LODWORD(v32.y);
			//   v32.z = v12;
			//   v14 = (float)(v12 / (float)(2.0 - y_low.m128_f32[0])) * (float)(2.0 - v32.y);
			//   *(_QWORD *)&v32.x = _mm_unpacklo_ps((__m128)LODWORD(v32.x), y_low).m128_u64[0];
			//   v15 = HG::Rendering::Runtime::LightExtensions::HsvToRgb((float3 *)v33, (float3 *)&v32, 0LL);
			//   z = v15.z;
			//   *(_QWORD *)&v32.x = *(_QWORD *)&v15.x;
			//   if ( !hgCamera )
			//     goto LABEL_14;
			//   m_volumeComponentsData = hgCamera.fields.m_volumeComponentsData;
			//   v20 = originalIntensity * hgCamera.fields.exposureAdaptation;
			//   if ( !m_volumeComponentsData )
			//     goto LABEL_14;
			//   m_hgCharacterVolume = m_volumeComponentsData.fields.m_hgCharacterVolume;
			//   if ( !m_hgCharacterVolume )
			//     goto LABEL_14;
			//   charLightDialogMode = m_hgCharacterVolume.fields.charLightDialogMode;
			//   if ( !charLightDialogMode )
			//     goto LABEL_14;
			//   sub_1800023D0(10LL, charLightDialogMode);
			//   v25 = sub_18238C950(v22);
			//   v26 = v20 - 1.25;
			//   if ( (float)(v20 - 1.25) <= 0.0 )
			//     v26 = 0.0;
			//   v27 = v23 - v20;
			//   if ( v27 <= 0.0 )
			//     v27 = 0.0;
			//   x = v32.x;
			//   y = v32.y;
			//   retstr.z = z;
			//   retstr.x = x;
			//   retstr.y = y;
			//   retstr.w = (float)((float)((float)(v26 * v24) + v25) - (float)(v27 * v24)) * v14;
			//   return retstr;
			// }
			// 
			return null;
		}

		[IDTag(1)]
		public static float4 GetCharacterLightColorAndIntensity(this HGSharedLightData light, HGCamera hgCamera)
		{
			// // float4 GetCharacterLightColorAndIntensity(HGSharedLightData, HGCamera)
			// float4 *HG::Rendering::Runtime::LightExtensions::GetCharacterLightColorAndIntensity(
			//         float4 *__return_ptr retstr,
			//         HGSharedLightData light,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   __m128i v6; // xmm6
			//   float intensity_Injected; // xmm0_4
			//   float4 *CharacterLightColorAndIntensity; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   float4 v12; // xmm0
			//   float4 *result; // rax
			//   __m128i v14; // [rsp+30h] [rbp-38h] BYREF
			//   float4 v15; // [rsp+40h] [rbp-28h] BYREF
			//   HGSharedLightData _unity_self; // [rsp+78h] [rbp+10h] BYREF
			// 
			//   _unity_self = light;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1559, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1559, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     CharacterLightColorAndIntensity = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_600(
			//                                         &v15,
			//                                         Patch,
			//                                         _unity_self,
			//                                         (Object *)hgCamera,
			//                                         0LL);
			//   }
			//   else
			//   {
			//     v6 = _mm_loadu_si128((const __m128i *)UnityEngine::HGSharedLightData::get_color((Color *)&v14, &_unity_self, 0LL));
			//     intensity_Injected = UnityEngine::HGSharedLightData::get_intensity_Injected(&_unity_self, 0LL);
			//     v14 = v6;
			//     CharacterLightColorAndIntensity = HG::Rendering::Runtime::LightExtensions::GetCharacterLightColorAndIntensity(
			//                                         &v15,
			//                                         hgCamera,
			//                                         (Color *)&v14,
			//                                         intensity_Injected,
			//                                         0LL);
			//   }
			//   v12 = *CharacterLightColorAndIntensity;
			//   result = retstr;
			//   *retstr = v12;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(2)]
		public static float4 GetCharacterLightColorAndIntensity(ref HGLightConfig config, HGCamera hgCamera)
		{
			// // float4 GetCharacterLightColorAndIntensity(HGLightConfig ByRef, HGCamera)
			// float4 *HG::Rendering::Runtime::LightExtensions::GetCharacterLightColorAndIntensity(
			//         float4 *__return_ptr retstr,
			//         HGLightConfig *config,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   float directIntensityDividePi; // xmm3_4
			//   float4 *CharacterLightColorAndIntensity; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v10; // rdx
			//   __int64 v11; // rcx
			//   float4 v12; // xmm0
			//   float4 *result; // rax
			//   Color directColor; // [rsp+30h] [rbp-28h] BYREF
			//   float4 v15; // [rsp+40h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1560, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1560, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v11, v10);
			//     CharacterLightColorAndIntensity = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_601(
			//                                         &v15,
			//                                         Patch,
			//                                         config,
			//                                         (Object *)hgCamera,
			//                                         0LL);
			//   }
			//   else
			//   {
			//     directIntensityDividePi = config.directIntensityDividePi;
			//     directColor = config.directColor;
			//     CharacterLightColorAndIntensity = HG::Rendering::Runtime::LightExtensions::GetCharacterLightColorAndIntensity(
			//                                         &v15,
			//                                         hgCamera,
			//                                         &directColor,
			//                                         directIntensityDividePi,
			//                                         0LL);
			//   }
			//   v12 = *CharacterLightColorAndIntensity;
			//   result = retstr;
			//   *retstr = v12;
			//   return result;
			// }
			// 
			return null;
		}

		[IDTag(0)]
		public static float GetLightFalloff(this HGSharedLightData hgSharedLightData, float distance2)
		{
			// // Single GetLightFalloff(HGSharedLightData, Single)
			// float HG::Rendering::Runtime::LightExtensions::GetLightFalloff(
			//         HGSharedLightData hgSharedLightData,
			//         float distance2,
			//         MethodInfo *method)
			// {
			//   float cullingDistance_Injected; // xmm6_4
			//   float v4; // xmm7_4
			//   float falloffDistance_Injected; // xmm6_4
			//   float v6; // xmm9_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v9; // rdx
			//   __int64 v10; // rcx
			//   HGSharedLightData _unity_self; // [rsp+70h] [rbp+8h] BYREF
			// 
			//   _unity_self = hgSharedLightData;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1561, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1561, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v10, v9);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_602(Patch, _unity_self, distance2, 0LL);
			//   }
			//   else
			//   {
			//     cullingDistance_Injected = UnityEngine::HGSharedLightData::get_cullingDistance_Injected(&_unity_self, 0LL);
			//     v4 = UnityEngine::HGSharedLightData::get_cullingDistance_Injected(&_unity_self, 0LL) * cullingDistance_Injected;
			//     falloffDistance_Injected = UnityEngine::HGSharedLightData::get_falloffDistance_Injected(&_unity_self, 0LL);
			//     v6 = UnityEngine::HGSharedLightData::get_falloffDistance_Injected(&_unity_self, 0LL) * falloffDistance_Injected;
			//     if ( UnityEngine::HGSharedLightData::get_useCullingDistance_Injected(&_unity_self, 0LL)
			//       && distance2 > v6
			//       && v4 > distance2 )
			//     {
			//       return (float)(v4 - distance2) / (float)(v4 - v6);
			//     }
			//     else
			//     {
			//       return 1.0;
			//     }
			//   }
			// }
			// 
			return 0f;
		}

		[IDTag(1)]
		public static float GetLightFalloff(this Light light, float distance2)
		{
			// // Single GetLightFalloff(Light, Single)
			// float HG::Rendering::Runtime::LightExtensions::GetLightFalloff(Light *light, float distance2, MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   float cullingDistance; // xmm6_4
			//   float v7; // xmm7_4
			//   float falloffDistance; // xmm6_4
			//   float v9; // xmm9_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1562, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1562, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_195(
			//                (ILFixDynamicMethodWrapper_7 *)Patch,
			//                (Object *)light,
			//                distance2,
			//                0LL);
			// LABEL_9:
			//     sub_180B536AC(v5, v4);
			//   }
			//   if ( !light )
			//     goto LABEL_9;
			//   cullingDistance = UnityEngine::Light::get_cullingDistance(light, 0LL);
			//   v7 = UnityEngine::Light::get_cullingDistance(light, 0LL) * cullingDistance;
			//   falloffDistance = UnityEngine::Light::get_falloffDistance(light, 0LL);
			//   v9 = UnityEngine::Light::get_falloffDistance(light, 0LL) * falloffDistance;
			//   if ( UnityEngine::Light::get_useCullingDistance(light, 0LL) && distance2 > v9 && v7 > distance2 )
			//     return (float)(v7 - distance2) / (float)(v7 - v9);
			//   else
			//     return 1.0;
			// }
			// 
			return 0f;
		}

		public static HGLightAdditionalData GetLightAdditionalData(this HGSharedLightData light)
		{
			// // HGLightAdditionalData GetLightAdditionalData(HGSharedLightData)
			// HGLightAdditionalData *HG::Rendering::Runtime::LightExtensions::GetLightAdditionalData(
			//         HGLightAdditionalData *__return_ptr retstr,
			//         HGSharedLightData light,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v4; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   __int64 (__fastcall *v6)(HGSharedLightData *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *); // rax
			//   __int64 v7; // rdx
			//   unsigned int v8; // ebx
			//   __int64 (__fastcall *v9)(_QWORD); // rax
			//   struct Light__Class **v10; // rax
			//   struct Light__Class *v11; // rdx
			//   __int64 v12; // r14
			//   struct Light__Class **v13; // rbx
			//   __int64 (__fastcall *v14)(HGSharedLightData *, struct Light__Class *); // rax
			//   __int64 v15; // rdx
			//   unsigned int v16; // ebx
			//   __int64 (__fastcall *v17)(_QWORD); // rax
			//   struct Light__Class **v18; // rax
			//   struct Light__Class *v19; // rdx
			//   Object *v20; // rbx
			//   struct ILFixDynamicMethodWrapper_2__Class *v21; // rcx
			//   int *v22; // rdx
			//   __int64 (__fastcall *v23)(Object *); // rax
			//   GameObject *v24; // rdi
			//   struct MethodInfo *v25; // rbx
			//   System::Type **rgctx_data; // rbx
			//   System::Type *v27; // rbx
			//   void (__fastcall *v28)(GameObject *, __int64, _QWORD, float *); // rax
			//   HGRenderPathBase_HGRenderPathResources *v29; // rdx
			//   PassConstructorID__Enum__Array *v30; // r8
			//   HGCamera *v31; // r9
			//   void *v32; // rbx
			//   Vector4 *v33; // rax
			//   float v34; // xmm0_4
			//   float v35; // xmm1_4
			//   Vector4 lightNPRData; // xmm3
			//   __m128 v37; // xmm2
			//   __m128 v38; // xmm2
			//   __m128 v39; // xmm2
			//   HGLightAdditionalData *lightAdditionalData; // rax
			//   __int128 v42; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v44; // rax
			//   __int64 v45; // rax
			//   __int64 v46; // rax
			//   __int64 v47; // rax
			//   ILFixDynamicMethodWrapper_2 *v48; // rax
			//   __int64 v49; // rax
			//   __int64 v50; // rax
			//   ILFixDynamicMethodWrapper_2 *v51; // rax
			//   HGLightAdditionalData *v52; // rax
			//   Vector4 v53; // [rsp+20h] [rbp-38h] BYREF
			//   HGLightAdditionalData v54; // [rsp+30h] [rbp-28h] BYREF
			//   void *v55; // [rsp+70h] [rbp+18h] BYREF
			//   HGSharedLightData v56; // [rsp+78h] [rbp+20h] BYREF
			// 
			//   v56 = light;
			//   if ( !byte_18D8EDCDA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDCDA = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     ((void (__fastcall *)(_QWORD, _QWORD))il2cpp_runtime_class_init_0)(TypeInfo::IFix::ILFixDynamicMethodWrapper, light);
			//     v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v4.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_80;
			//   if ( wrapperArray.max_length.size > 967 )
			//   {
			//     if ( !v4._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v4, wrapperArray);
			//       v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v4.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_80;
			//     if ( wrapperArray.max_length.size <= 0x3C7u )
			//       goto LABEL_121;
			//     if ( wrapperArray[26].vector[31] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(967, 0LL);
			//       if ( !Patch )
			//         goto LABEL_80;
			//       lightAdditionalData = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_359(&v54, Patch, v56, 0LL);
			// LABEL_74:
			//       v42 = *(_OWORD *)&lightAdditionalData.lightNPRType;
			//       retstr.lightNPRData = lightAdditionalData.lightNPRData;
			//       *(_OWORD *)&retstr.lightNPRType = v42;
			//       return retstr;
			//     }
			//   }
			//   if ( !byte_18D8F4838 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Light);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4838 = 1;
			//   }
			//   v6 = (__int64 (__fastcall *)(HGSharedLightData *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))qword_18D8F4840;
			//   if ( !qword_18D8F4840 )
			//   {
			//     v6 = (__int64 (__fastcall *)(HGSharedLightData *, ILFixDynamicMethodWrapper_2__Array *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.HGSharedLightData::get_instanceID_Injected(UnityEngine.HGSharedLightData&)");
			//     if ( !v6 )
			//     {
			//       v44 = sub_1802DBBE8("UnityEngine.HGSharedLightData::get_instanceID_Injected(UnityEngine.HGSharedLightData&)");
			//       sub_18000F750(v44, 0LL);
			//     }
			//     qword_18D8F4840 = (__int64)v6;
			//   }
			//   v8 = v6(&v56, wrapperArray, method);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v7);
			//   v9 = (__int64 (__fastcall *)(_QWORD))qword_18D8F4F58;
			//   if ( !qword_18D8F4F58 )
			//   {
			//     v9 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_0("UnityEngine.Object::FindObjectFromInstanceID(System.Int32)");
			//     if ( !v9 )
			//     {
			//       v45 = sub_1802DBBE8("UnityEngine.Object::FindObjectFromInstanceID(System.Int32)");
			//       sub_18000F750(v45, 0LL);
			//     }
			//     qword_18D8F4F58 = (__int64)v9;
			//   }
			//   v10 = (struct Light__Class **)v9(v8);
			//   v11 = TypeInfo::UnityEngine::Light;
			//   v12 = 0LL;
			//   v13 = v10;
			//   if ( v10 )
			//   {
			//     if ( *v10 != TypeInfo::UnityEngine::Light )
			//       sub_1802DC21C(v10, TypeInfo::UnityEngine::Light);
			//   }
			//   else
			//   {
			//     v13 = 0LL;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, TypeInfo::UnityEngine::Light);
			//   if ( !byte_18D8F4EFA )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFA = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( !v13 )
			//     goto LABEL_73;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v11);
			//   if ( !v13[2] )
			//   {
			// LABEL_73:
			//     lightAdditionalData = UnityEngine::HGSharedLightData::get_lightAdditionalData(&v54, &v56, 0LL);
			//     goto LABEL_74;
			//   }
			//   if ( !byte_18D8F4838 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Light);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4838 = 1;
			//   }
			//   v14 = (__int64 (__fastcall *)(HGSharedLightData *, struct Light__Class *))qword_18D8F4840;
			//   if ( !qword_18D8F4840 )
			//   {
			//     v14 = (__int64 (__fastcall *)(HGSharedLightData *, struct Light__Class *))il2cpp_resolve_icall_0(
			//                                                                                 "UnityEngine.HGSharedLightData::get_insta"
			//                                                                                 "nceID_Injected(UnityEngine.HGSharedLightData&)");
			//     if ( !v14 )
			//     {
			//       v46 = sub_1802DBBE8("UnityEngine.HGSharedLightData::get_instanceID_Injected(UnityEngine.HGSharedLightData&)");
			//       sub_18000F750(v46, 0LL);
			//     }
			//     qword_18D8F4840 = (__int64)v14;
			//   }
			//   v16 = v14(&v56, v11);
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v15);
			//   v17 = (__int64 (__fastcall *)(_QWORD))qword_18D8F4F58;
			//   if ( !qword_18D8F4F58 )
			//   {
			//     v17 = (__int64 (__fastcall *)(_QWORD))il2cpp_resolve_icall_0("UnityEngine.Object::FindObjectFromInstanceID(System.Int32)");
			//     if ( !v17 )
			//     {
			//       v47 = sub_1802DBBE8("UnityEngine.Object::FindObjectFromInstanceID(System.Int32)");
			//       sub_18000F750(v47, 0LL);
			//     }
			//     qword_18D8F4F58 = (__int64)v17;
			//   }
			//   v18 = (struct Light__Class **)v17(v16);
			//   v19 = TypeInfo::UnityEngine::Light;
			//   v20 = (Object *)v18;
			//   if ( v18 )
			//   {
			//     if ( *v18 != TypeInfo::UnityEngine::Light )
			//       sub_1802DC21C(v18, TypeInfo::UnityEngine::Light);
			//   }
			//   else
			//   {
			//     v20 = 0LL;
			//   }
			//   if ( !byte_18D8EDCD9 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HGAdditionalLightData>);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::TryGetComponent<HG::Rendering::Runtime::HGAdditionalLightData>);
			//     byte_18D8EDCD9 = 1;
			//   }
			//   v55 = 0LL;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v21 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v19);
			//     v21 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v22 = (int *)v21.static_fields.wrapperArray;
			//   if ( !v22 )
			//     goto LABEL_79;
			//   if ( v22[6] <= 968 )
			//     goto LABEL_45;
			//   if ( !v21._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v21, v22);
			//     v21 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v21 = (struct ILFixDynamicMethodWrapper_2__Class *)v21.static_fields.wrapperArray;
			//   if ( !v21 )
			// LABEL_79:
			//     sub_180B536AC(v21, v22);
			//   if ( LODWORD(v21._0.namespaze) <= 0x3C8 )
			//     sub_180070270(v21, v22);
			//   if ( *(_QWORD *)&v21[20]._1.element_size )
			//   {
			//     v48 = IFix::WrappersManagerImpl::GetPatch(968, 0LL);
			//     if ( v48 )
			//     {
			//       v32 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_357(v48, v20, 0LL);
			//       goto LABEL_60;
			//     }
			//     goto LABEL_79;
			//   }
			// LABEL_45:
			//   if ( !v20 )
			//     goto LABEL_79;
			//   v23 = (__int64 (__fastcall *)(Object *))qword_18D8F4D48;
			//   if ( !qword_18D8F4D48 )
			//   {
			//     v23 = (__int64 (__fastcall *)(Object *))il2cpp_resolve_icall_0("UnityEngine.Component::get_gameObject()");
			//     if ( !v23 )
			//     {
			//       v49 = sub_1802DBBE8("UnityEngine.Component::get_gameObject()");
			//       sub_18000F750(v49, 0LL);
			//     }
			//     qword_18D8F4D48 = (__int64)v23;
			//   }
			//   v24 = (GameObject *)v23(v20);
			//   if ( !v24 )
			//     goto LABEL_79;
			//   v25 = MethodInfo::UnityEngine::GameObject::TryGetComponent<HG::Rendering::Runtime::HGAdditionalLightData>;
			//   if ( !MethodInfo::UnityEngine::GameObject::TryGetComponent<HG::Rendering::Runtime::HGAdditionalLightData>.rgctx_data )
			//   {
			//     sub_18003C530(&TypeInfo::System::Type);
			//     if ( !v25.rgctx_data )
			//       sub_180041F40(v25);
			//   }
			//   rgctx_data = (System::Type **)v25.rgctx_data;
			//   v53 = 0LL;
			//   v27 = *rgctx_data;
			//   if ( !TypeInfo::System::Type._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::System::Type, v22);
			//   if ( !byte_18D8F235A )
			//   {
			//     sub_18003C530(&TypeInfo::System::Type);
			//     byte_18D8F235A = 1;
			//   }
			//   if ( v27 )
			//   {
			//     if ( !TypeInfo::System::Type._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::System::Type, v22);
			//     v12 = System::Type::internal_from_handle(v27, v22);
			//   }
			//   v28 = (void (__fastcall *)(GameObject *, __int64, _QWORD, float *))qword_18D8F4DB8;
			//   if ( !qword_18D8F4DB8 )
			//   {
			//     v28 = (void (__fastcall *)(GameObject *, __int64, _QWORD, float *))il2cpp_resolve_icall_0(
			//                                                                          "UnityEngine.GameObject::TryGetComponentFastPath"
			//                                                                          "(System.Type,System.Int32,System.IntPtr)");
			//     if ( !v28 )
			//     {
			//       v50 = sub_1802DBBE8("UnityEngine.GameObject::TryGetComponentFastPath(System.Type,System.Int32,System.IntPtr)");
			//       sub_18000F750(v50, 0LL);
			//     }
			//     qword_18D8F4DB8 = (__int64)v28;
			//   }
			//   v28(v24, v12, 0LL, &v53.z);
			//   v55 = *(void **)&v53.x;
			//   sub_1800054D0((HGRenderPathScene *)&v55, v29, v30, v31, *(MethodInfo **)&v53.x, *(MethodInfo **)&v53.z);
			//   if ( *(_QWORD *)&v53.x )
			//   {
			//     v32 = v55;
			//   }
			//   else
			//   {
			//     v32 = UnityEngine::GameObject::AddComponent<System::Object>(
			//             v24,
			//             MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HGAdditionalLightData>);
			//     v55 = v32;
			//   }
			// LABEL_60:
			//   if ( !v32 )
			//     goto LABEL_80;
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//     v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v4.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_80;
			//   if ( wrapperArray.max_length.size > 969 )
			//   {
			//     if ( !v4._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v4, wrapperArray);
			//       v4 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v4 = (struct ILFixDynamicMethodWrapper_2__Class *)v4.static_fields.wrapperArray;
			//     if ( !v4 )
			//       goto LABEL_80;
			//     if ( LODWORD(v4._0.namespaze) > 0x3C9 )
			//     {
			//       if ( !*(_QWORD *)&v4[20]._1.static_fields_size )
			//         goto LABEL_67;
			//       v51 = IFix::WrappersManagerImpl::GetPatch(969, 0LL);
			//       if ( v51 )
			//       {
			//         v52 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_358(&v54, v51, (Object *)v32, 0LL);
			//         lightNPRData = v52.lightNPRData;
			//         v39 = *(__m128 *)&v52.lightNPRType;
			//         goto LABEL_68;
			//       }
			// LABEL_80:
			//       sub_180B536AC(v4, wrapperArray);
			//     }
			// LABEL_121:
			//     sub_180070270(v4, wrapperArray);
			//   }
			// LABEL_67:
			//   *(_OWORD *)&v54.lightNPRType = 0LL;
			//   v33 = HG::Rendering::Runtime::HGAdditionalLightData::GetLightNPRData(&v53, (HGAdditionalLightData *)v32, 0LL);
			//   v34 = *((float *)v32 + 33);
			//   v35 = *((float *)v32 + 32);
			//   lightNPRData = *v33;
			//   v54.lightNPRType = *((_DWORD *)v32 + 15);
			//   v54.LightCharacterOnly = *((_BYTE *)v32 + 125);
			//   v37 = _mm_shuffle_ps(*(__m128 *)&v54.lightNPRType, *(__m128 *)&v54.lightNPRType, 147);
			//   v37.m128_f32[0] = v34;
			//   v38 = _mm_shuffle_ps(v37, v37, 39);
			//   v38.m128_f32[0] = v35;
			//   v39 = _mm_shuffle_ps(v38, v38, 201);
			// LABEL_68:
			//   retstr.lightNPRData = lightNPRData;
			//   *(__m128 *)&retstr.lightNPRType = v39;
			//   return retstr;
			// }
			// 
			return null;
		}

		private const float CHARACTER_MAIN_LIGHT_CLAMP_MIN = 0.75f;

		private const float CHARACTER_MAIN_LIGHT_CLAMP_MAX = 1.25f;

		private const float CHARACTER_MAIN_SATURATION_CLAMP_MIN = 0.35f;

		private const float CHARACTER_MAIN_SATURATION_CLAMP_MAX = 0.7f;
	}
}
