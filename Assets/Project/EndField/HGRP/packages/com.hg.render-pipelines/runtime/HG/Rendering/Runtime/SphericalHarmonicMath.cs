using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	internal class SphericalHarmonicMath
	{
		public SphericalHarmonicMath()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		public static SphericalHarmonicsL2 Convolve(SphericalHarmonicsL2 sh, ZonalHarmonicsL2 zh)
		{
			// // SphericalHarmonicsL2 Convolve(SphericalHarmonicsL2, ZonalHarmonicsL2)
			// SphericalHarmonicsL2 *HG::Rendering::Runtime::SphericalHarmonicMath::Convolve(
			//         SphericalHarmonicsL2 *__return_ptr retstr,
			//         SphericalHarmonicsL2 *sh,
			//         ZonalHarmonicsL2 zh,
			//         MethodInfo *method)
			// {
			//   SphericalHarmonicsL2 *v5; // rdi
			//   Single__Array *coeffs; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   float3 *v8; // rcx
			//   float3 *v9; // r8
			//   float3 *v10; // r9
			//   int32_t v11; // r12d
			//   int32_t v12; // ebp
			//   int v13; // r14d
			//   int32_t v14; // r15d
			//   float v15; // xmm6_4
			//   int32_t v16; // ebx
			//   int32_t i; // edi
			//   float Item; // xmm0_4
			//   float v19; // eax
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   __int128 v24; // xmm1
			//   __int64 v25; // xmm0_8
			//   float shb8; // eax
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   __int128 v29; // xmm1
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   SphericalHarmonicsL2 *v32; // rax
			//   __int128 v33; // xmm1
			//   __int128 v34; // xmm0
			//   __int128 v35; // xmm1
			//   __int128 v36; // xmm0
			//   SphericalHarmonicsL2 v38; // [rsp+30h] [rbp-128h] BYREF
			//   SphericalHarmonicsL2 v39; // [rsp+A0h] [rbp-B8h] BYREF
			// 
			//   v5 = retstr;
			//   coeffs = zh.coeffs;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1891, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1891, 0LL);
			//     if ( Patch )
			//     {
			//       shb8 = sh.shb8;
			//       v27 = *(_OWORD *)&sh.shr4;
			//       *(_OWORD *)&v38.shr0 = *(_OWORD *)&sh.shr0;
			//       v28 = *(_OWORD *)&sh.shr8;
			//       v38.shb8 = shb8;
			//       *(_OWORD *)&v38.shr4 = v27;
			//       v29 = *(_OWORD *)&sh.shg3;
			//       *(_OWORD *)&v38.shr8 = v28;
			//       v30 = *(_OWORD *)&sh.shg7;
			//       *(_OWORD *)&v38.shg3 = v29;
			//       v31 = *(_OWORD *)&sh.shb2;
			//       *(_OWORD *)&v38.shg7 = v30;
			//       *(_QWORD *)&v38.shb6 = *(_QWORD *)&sh.shb6;
			//       *(_OWORD *)&v38.shb2 = v31;
			//       v32 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_738(&v39, Patch, &v38, (ZonalHarmonicsL2)coeffs, 0LL);
			//       v33 = *(_OWORD *)&v32.shr4;
			//       *(_OWORD *)&v5.shr0 = *(_OWORD *)&v32.shr0;
			//       v34 = *(_OWORD *)&v32.shr8;
			//       *(_OWORD *)&v5.shr4 = v33;
			//       v35 = *(_OWORD *)&v32.shg3;
			//       *(_OWORD *)&v5.shr8 = v34;
			//       v36 = *(_OWORD *)&v32.shg7;
			//       *(_OWORD *)&v5.shg3 = v35;
			//       v24 = *(_OWORD *)&v32.shb2;
			//       *(_OWORD *)&v5.shg7 = v36;
			//       v25 = *(_QWORD *)&v32.shb6;
			//       v19 = v32.shb8;
			//       goto LABEL_15;
			//     }
			// LABEL_13:
			//     sub_180B536AC(v8, Patch);
			//   }
			//   v11 = 0;
			//   v12 = 0;
			//   v13 = 1;
			//   if ( !coeffs )
			//     goto LABEL_13;
			//   do
			//   {
			//     if ( (unsigned int)v12 >= coeffs.max_length.size )
			//       sub_180070270(v8, Patch);
			//     v14 = v11;
			//     v15 = sub_1802ECED0(v8, (float3 *)Patch, v9, v10) * coeffs.vector[v12];
			//     if ( v11 <= v12 )
			//     {
			//       do
			//       {
			//         v16 = v14 + v12 * (v12 + 1);
			//         for ( i = 0; i < 3; ++i )
			//         {
			//           Item = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, i, v16, 0LL);
			//           UnityEngine::Rendering::SphericalHarmonicsL2::set_Item(sh, i, v16, Item * v15, 0LL);
			//         }
			//         ++v14;
			//       }
			//       while ( v14 <= v12 );
			//       coeffs = zh.coeffs;
			//       v5 = retstr;
			//     }
			//     ++v12;
			//     v13 += 2;
			//     --v11;
			//   }
			//   while ( v13 <= 5 );
			//   v19 = sh.shb8;
			//   v20 = *(_OWORD *)&sh.shr4;
			//   *(_OWORD *)&v5.shr0 = *(_OWORD *)&sh.shr0;
			//   v21 = *(_OWORD *)&sh.shr8;
			//   *(_OWORD *)&v5.shr4 = v20;
			//   v22 = *(_OWORD *)&sh.shg3;
			//   *(_OWORD *)&v5.shr8 = v21;
			//   v23 = *(_OWORD *)&sh.shg7;
			//   *(_OWORD *)&v5.shg3 = v22;
			//   v24 = *(_OWORD *)&sh.shb2;
			//   *(_OWORD *)&v5.shg7 = v23;
			//   v25 = *(_QWORD *)&sh.shb6;
			// LABEL_15:
			//   *(_OWORD *)&v5.shb2 = v24;
			//   *(_QWORD *)&v5.shb6 = v25;
			//   v5.shb8 = v19;
			//   return v5;
			// }
			// 
			return null;
		}

		public static SphericalHarmonicsL2 UndoCosineRescaling(SphericalHarmonicsL2 sh)
		{
			// // SphericalHarmonicsL2 UndoCosineRescaling(SphericalHarmonicsL2)
			// SphericalHarmonicsL2 *HG::Rendering::Runtime::SphericalHarmonicMath::UndoCosineRescaling(
			//         SphericalHarmonicsL2 *__return_ptr retstr,
			//         SphericalHarmonicsL2 *sh,
			//         MethodInfo *method)
			// {
			//   int32_t i; // ebp
			//   int32_t j; // esi
			//   float Item; // xmm6_4
			//   SphericalHarmonicMath__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   float shb8; // eax
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   __int64 v16; // xmm0_8
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   SphericalHarmonicsL2 *v23; // rax
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   SphericalHarmonicsL2 v29; // [rsp+30h] [rbp-F8h] BYREF
			//   SphericalHarmonicsL2 v30; // [rsp+A0h] [rbp-88h] BYREF
			// 
			//   if ( !byte_18D919EC8 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SphericalHarmonicMath);
			//     byte_18D919EC8 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1892, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1892, 0LL);
			//     if ( !Patch )
			// LABEL_13:
			//       sub_180B536AC(static_fields, Patch);
			//     v17 = *(_OWORD *)&sh.shr0;
			//     v18 = *(_OWORD *)&sh.shr4;
			//     v29.shb8 = sh.shb8;
			//     *(_OWORD *)&v29.shr0 = v17;
			//     v19 = *(_OWORD *)&sh.shr8;
			//     *(_OWORD *)&v29.shr4 = v18;
			//     v20 = *(_OWORD *)&sh.shg3;
			//     *(_OWORD *)&v29.shr8 = v19;
			//     v21 = *(_OWORD *)&sh.shg7;
			//     *(_OWORD *)&v29.shg3 = v20;
			//     v22 = *(_OWORD *)&sh.shb2;
			//     *(_OWORD *)&v29.shg7 = v21;
			//     *(_QWORD *)&v29.shb6 = *(_QWORD *)&sh.shb6;
			//     *(_OWORD *)&v29.shb2 = v22;
			//     v23 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_739(&v30, Patch, &v29, 0LL);
			//     v24 = *(_OWORD *)&v23.shr4;
			//     *(_OWORD *)&retstr.shr0 = *(_OWORD *)&v23.shr0;
			//     v25 = *(_OWORD *)&v23.shr8;
			//     *(_OWORD *)&retstr.shr4 = v24;
			//     v26 = *(_OWORD *)&v23.shg3;
			//     *(_OWORD *)&retstr.shr8 = v25;
			//     v27 = *(_OWORD *)&v23.shg7;
			//     *(_OWORD *)&retstr.shg3 = v26;
			//     v15 = *(_OWORD *)&v23.shb2;
			//     *(_OWORD *)&retstr.shg7 = v27;
			//     v16 = *(_QWORD *)&v23.shb6;
			//     shb8 = v23.shb8;
			//   }
			//   else
			//   {
			//     for ( i = 0; i < 3; ++i )
			//     {
			//       for ( j = 0; j < 9; ++j )
			//       {
			//         Item = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, i, j, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::SphericalHarmonicMath);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::SphericalHarmonicMath.static_fields;
			//         Patch = (ILFixDynamicMethodWrapper_2 *)static_fields.invNormConsts;
			//         if ( !static_fields.invNormConsts )
			//           goto LABEL_13;
			//         if ( (unsigned int)j >= Patch.fields.methodId )
			//           sub_180070270(static_fields, Patch);
			//         UnityEngine::Rendering::SphericalHarmonicsL2::set_Item(
			//           sh,
			//           i,
			//           j,
			//           Item * *((float *)&Patch.fields.anonObj + j),
			//           0LL);
			//       }
			//     }
			//     shb8 = sh.shb8;
			//     v11 = *(_OWORD *)&sh.shr4;
			//     *(_OWORD *)&retstr.shr0 = *(_OWORD *)&sh.shr0;
			//     v12 = *(_OWORD *)&sh.shr8;
			//     *(_OWORD *)&retstr.shr4 = v11;
			//     v13 = *(_OWORD *)&sh.shg3;
			//     *(_OWORD *)&retstr.shr8 = v12;
			//     v14 = *(_OWORD *)&sh.shg7;
			//     *(_OWORD *)&retstr.shg3 = v13;
			//     v15 = *(_OWORD *)&sh.shb2;
			//     *(_OWORD *)&retstr.shg7 = v14;
			//     v16 = *(_QWORD *)&sh.shb6;
			//   }
			//   *(_OWORD *)&retstr.shb2 = v15;
			//   *(_QWORD *)&retstr.shb6 = v16;
			//   retstr.shb8 = shb8;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static SphericalHarmonicsL2 PremultiplyCoefficients(SphericalHarmonicsL2 sh)
		{
			// // SphericalHarmonicsL2 PremultiplyCoefficients(SphericalHarmonicsL2)
			// SphericalHarmonicsL2 *HG::Rendering::Runtime::SphericalHarmonicMath::PremultiplyCoefficients(
			//         SphericalHarmonicsL2 *__return_ptr retstr,
			//         SphericalHarmonicsL2 *sh,
			//         MethodInfo *method)
			// {
			//   int32_t i; // ebp
			//   int32_t j; // esi
			//   float Item; // xmm6_4
			//   SphericalHarmonicMath__StaticFields *static_fields; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   float shb8; // eax
			//   __int128 v11; // xmm1
			//   __int128 v12; // xmm0
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   __int128 v15; // xmm1
			//   __int64 v16; // xmm0_8
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm0
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm0
			//   __int128 v22; // xmm1
			//   SphericalHarmonicsL2 *v23; // rax
			//   __int128 v24; // xmm1
			//   __int128 v25; // xmm0
			//   __int128 v26; // xmm1
			//   __int128 v27; // xmm0
			//   SphericalHarmonicsL2 v29; // [rsp+30h] [rbp-F8h] BYREF
			//   SphericalHarmonicsL2 v30; // [rsp+A0h] [rbp-88h] BYREF
			// 
			//   if ( !byte_18D919EC9 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::SphericalHarmonicMath);
			//     byte_18D919EC9 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1893, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1893, 0LL);
			//     if ( !Patch )
			// LABEL_13:
			//       sub_180B536AC(static_fields, Patch);
			//     v17 = *(_OWORD *)&sh.shr0;
			//     v18 = *(_OWORD *)&sh.shr4;
			//     v29.shb8 = sh.shb8;
			//     *(_OWORD *)&v29.shr0 = v17;
			//     v19 = *(_OWORD *)&sh.shr8;
			//     *(_OWORD *)&v29.shr4 = v18;
			//     v20 = *(_OWORD *)&sh.shg3;
			//     *(_OWORD *)&v29.shr8 = v19;
			//     v21 = *(_OWORD *)&sh.shg7;
			//     *(_OWORD *)&v29.shg3 = v20;
			//     v22 = *(_OWORD *)&sh.shb2;
			//     *(_OWORD *)&v29.shg7 = v21;
			//     *(_QWORD *)&v29.shb6 = *(_QWORD *)&sh.shb6;
			//     *(_OWORD *)&v29.shb2 = v22;
			//     v23 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_739(&v30, Patch, &v29, 0LL);
			//     v24 = *(_OWORD *)&v23.shr4;
			//     *(_OWORD *)&retstr.shr0 = *(_OWORD *)&v23.shr0;
			//     v25 = *(_OWORD *)&v23.shr8;
			//     *(_OWORD *)&retstr.shr4 = v24;
			//     v26 = *(_OWORD *)&v23.shg3;
			//     *(_OWORD *)&retstr.shr8 = v25;
			//     v27 = *(_OWORD *)&v23.shg7;
			//     *(_OWORD *)&retstr.shg3 = v26;
			//     v15 = *(_OWORD *)&v23.shb2;
			//     *(_OWORD *)&retstr.shg7 = v27;
			//     v16 = *(_QWORD *)&v23.shb6;
			//     shb8 = v23.shb8;
			//   }
			//   else
			//   {
			//     for ( i = 0; i < 3; ++i )
			//     {
			//       for ( j = 0; j < 9; ++j )
			//       {
			//         Item = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, i, j, 0LL);
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::SphericalHarmonicMath);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::SphericalHarmonicMath.static_fields;
			//         Patch = (ILFixDynamicMethodWrapper_2 *)static_fields.ks;
			//         if ( !Patch )
			//           goto LABEL_13;
			//         if ( (unsigned int)j >= Patch.fields.methodId )
			//           sub_180070270(static_fields, Patch);
			//         UnityEngine::Rendering::SphericalHarmonicsL2::set_Item(
			//           sh,
			//           i,
			//           j,
			//           Item * *((float *)&Patch.fields.anonObj + j),
			//           0LL);
			//       }
			//     }
			//     shb8 = sh.shb8;
			//     v11 = *(_OWORD *)&sh.shr4;
			//     *(_OWORD *)&retstr.shr0 = *(_OWORD *)&sh.shr0;
			//     v12 = *(_OWORD *)&sh.shr8;
			//     *(_OWORD *)&retstr.shr4 = v11;
			//     v13 = *(_OWORD *)&sh.shg3;
			//     *(_OWORD *)&retstr.shr8 = v12;
			//     v14 = *(_OWORD *)&sh.shg7;
			//     *(_OWORD *)&retstr.shg3 = v13;
			//     v15 = *(_OWORD *)&sh.shb2;
			//     *(_OWORD *)&retstr.shg7 = v14;
			//     v16 = *(_QWORD *)&sh.shb6;
			//   }
			//   *(_OWORD *)&retstr.shb2 = v15;
			//   *(_QWORD *)&retstr.shb6 = v16;
			//   retstr.shb8 = shb8;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static SphericalHarmonicsL2 RescaleCoefficients(SphericalHarmonicsL2 sh, float scalar)
		{
			// // SphericalHarmonicsL2 RescaleCoefficients(SphericalHarmonicsL2, Single)
			// SphericalHarmonicsL2 *HG::Rendering::Runtime::SphericalHarmonicMath::RescaleCoefficients(
			//         SphericalHarmonicsL2 *__return_ptr retstr,
			//         SphericalHarmonicsL2 *sh,
			//         float scalar,
			//         MethodInfo *method)
			// {
			//   int32_t i; // esi
			//   int32_t j; // ebp
			//   float Item; // xmm0_4
			//   float v9; // eax
			//   __int128 v10; // xmm1
			//   __int128 v11; // xmm0
			//   __int128 v12; // xmm1
			//   __int128 v13; // xmm0
			//   __int128 v14; // xmm1
			//   __int64 v15; // xmm0_8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v17; // rcx
			//   float shb8; // eax
			//   __int128 v19; // xmm1
			//   __int128 v20; // xmm0
			//   __int128 v21; // xmm1
			//   __int128 v22; // xmm0
			//   __int128 v23; // xmm1
			//   SphericalHarmonicsL2 *v24; // rax
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm0
			//   SphericalHarmonicsL2 v30; // [rsp+30h] [rbp-F8h] BYREF
			//   SphericalHarmonicsL2 v31; // [rsp+A0h] [rbp-88h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1894, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1894, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v17, 0LL);
			//     shb8 = sh.shb8;
			//     v19 = *(_OWORD *)&sh.shr4;
			//     *(_OWORD *)&v30.shr0 = *(_OWORD *)&sh.shr0;
			//     v20 = *(_OWORD *)&sh.shr8;
			//     v30.shb8 = shb8;
			//     *(_OWORD *)&v30.shr4 = v19;
			//     v21 = *(_OWORD *)&sh.shg3;
			//     *(_OWORD *)&v30.shr8 = v20;
			//     v22 = *(_OWORD *)&sh.shg7;
			//     *(_OWORD *)&v30.shg3 = v21;
			//     v23 = *(_OWORD *)&sh.shb2;
			//     *(_OWORD *)&v30.shg7 = v22;
			//     *(_QWORD *)&v30.shb6 = *(_QWORD *)&sh.shb6;
			//     *(_OWORD *)&v30.shb2 = v23;
			//     v24 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_740(&v31, Patch, &v30, scalar, 0LL);
			//     v25 = *(_OWORD *)&v24.shr4;
			//     *(_OWORD *)&retstr.shr0 = *(_OWORD *)&v24.shr0;
			//     v26 = *(_OWORD *)&v24.shr8;
			//     *(_OWORD *)&retstr.shr4 = v25;
			//     v27 = *(_OWORD *)&v24.shg3;
			//     *(_OWORD *)&retstr.shr8 = v26;
			//     v28 = *(_OWORD *)&v24.shg7;
			//     *(_OWORD *)&retstr.shg3 = v27;
			//     v14 = *(_OWORD *)&v24.shb2;
			//     *(_OWORD *)&retstr.shg7 = v28;
			//     v15 = *(_QWORD *)&v24.shb6;
			//     v9 = v24.shb8;
			//   }
			//   else
			//   {
			//     for ( i = 0; i < 3; ++i )
			//     {
			//       for ( j = 0; j < 9; ++j )
			//       {
			//         Item = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(sh, i, j, 0LL);
			//         UnityEngine::Rendering::SphericalHarmonicsL2::set_Item(sh, i, j, Item * scalar, 0LL);
			//       }
			//     }
			//     v9 = sh.shb8;
			//     v10 = *(_OWORD *)&sh.shr4;
			//     *(_OWORD *)&retstr.shr0 = *(_OWORD *)&sh.shr0;
			//     v11 = *(_OWORD *)&sh.shr8;
			//     *(_OWORD *)&retstr.shr4 = v10;
			//     v12 = *(_OWORD *)&sh.shg3;
			//     *(_OWORD *)&retstr.shr8 = v11;
			//     v13 = *(_OWORD *)&sh.shg7;
			//     *(_OWORD *)&retstr.shg3 = v12;
			//     v14 = *(_OWORD *)&sh.shb2;
			//     *(_OWORD *)&retstr.shg7 = v13;
			//     v15 = *(_QWORD *)&sh.shb6;
			//   }
			//   *(_OWORD *)&retstr.shb2 = v14;
			//   *(_QWORD *)&retstr.shb6 = v15;
			//   retstr.shb8 = v9;
			//   return retstr;
			// }
			// 
			return null;
		}

		public static void PackCoefficients(Vector4[] packedCoeffs, in SphericalHarmonicsL2 sh)
		{
			// // Void PackCoefficients(Vector4[], SphericalHarmonicsL2 ByRef)
			// void HG::Rendering::Runtime::SphericalHarmonicMath::PackCoefficients(
			//         Vector4__Array *packedCoeffs,
			//         SphericalHarmonicsL2 *sh,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   int32_t v7; // edi
			//   int32_t v8; // r14d
			//   float shb8; // eax
			//   __int128 v10; // xmm1
			//   __int128 v11; // xmm0
			//   __int128 v12; // xmm1
			//   __int128 v13; // xmm0
			//   __int128 v14; // xmm1
			//   float v15; // eax
			//   __int128 v16; // xmm2
			//   int v17; // xmm9_4
			//   __int128 v18; // xmm1
			//   __int128 v19; // xmm2
			//   __int128 v20; // xmm1
			//   __int128 v21; // xmm2
			//   float v22; // eax
			//   __int128 v23; // xmm2
			//   int v24; // xmm8_4
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm2
			//   __int128 v27; // xmm1
			//   __int128 v28; // xmm2
			//   float v29; // eax
			//   __int128 v30; // xmm2
			//   int v31; // xmm7_4
			//   __int128 v32; // xmm1
			//   __int128 v33; // xmm2
			//   __int128 v34; // xmm1
			//   __int128 v35; // xmm2
			//   float v36; // eax
			//   __int128 v37; // xmm2
			//   __int128 v38; // xmm1
			//   __int128 v39; // xmm2
			//   __int128 v40; // xmm1
			//   __int128 v41; // xmm2
			//   float v42; // xmm6_4
			//   __int64 v43; // rax
			//   __int64 v44; // r14
			//   float v45; // eax
			//   __int128 v46; // xmm1
			//   __int128 v47; // xmm0
			//   __int128 v48; // xmm1
			//   __int128 v49; // xmm0
			//   __int128 v50; // xmm1
			//   float v51; // eax
			//   __int128 v52; // xmm2
			//   int v53; // xmm9_4
			//   __int128 v54; // xmm1
			//   __int128 v55; // xmm2
			//   __int128 v56; // xmm1
			//   __int128 v57; // xmm2
			//   float v58; // eax
			//   __int128 v59; // xmm2
			//   int v60; // xmm8_4
			//   __int128 v61; // xmm1
			//   __int128 v62; // xmm2
			//   __int128 v63; // xmm1
			//   __int128 v64; // xmm2
			//   float v65; // eax
			//   __int128 v66; // xmm2
			//   float v67; // xmm7_4
			//   __int128 v68; // xmm1
			//   __int128 v69; // xmm2
			//   __int128 v70; // xmm1
			//   __int128 v71; // xmm2
			//   float Item; // xmm6_4
			//   __int64 v73; // rax
			//   float v74; // eax
			//   __int128 v75; // xmm1
			//   __int128 v76; // xmm0
			//   __int128 v77; // xmm1
			//   __int128 v78; // xmm0
			//   __int128 v79; // xmm1
			//   float v80; // eax
			//   __int128 v81; // xmm2
			//   __int128 v82; // xmm1
			//   int v83; // xmm8_4
			//   __int128 v84; // xmm2
			//   __int128 v85; // xmm1
			//   __int128 v86; // xmm2
			//   float v87; // eax
			//   __int128 v88; // xmm2
			//   __int128 v89; // xmm1
			//   int v90; // xmm7_4
			//   __int128 v91; // xmm2
			//   __int128 v92; // xmm1
			//   __int128 v93; // xmm2
			//   float v94; // xmm6_4
			//   float *v95; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   SphericalHarmonicsL2 v97; // [rsp+28h] [rbp-59h] BYREF
			// 
			//   v7 = 0;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1895, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1895, 0LL);
			//     if ( !Patch )
			// LABEL_9:
			//       sub_180B536AC(v6, v5);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_741(Patch, (Object *)packedCoeffs, sh, 0LL);
			//   }
			//   else
			//   {
			//     v8 = 0;
			//     do
			//     {
			//       if ( !packedCoeffs )
			//         goto LABEL_9;
			//       shb8 = sh.shb8;
			//       v10 = *(_OWORD *)&sh.shr4;
			//       *(_OWORD *)&v97.shr0 = *(_OWORD *)&sh.shr0;
			//       v11 = *(_OWORD *)&sh.shr8;
			//       v97.shb8 = shb8;
			//       *(_OWORD *)&v97.shr4 = v10;
			//       v12 = *(_OWORD *)&sh.shg3;
			//       *(_OWORD *)&v97.shr8 = v11;
			//       v13 = *(_OWORD *)&sh.shg7;
			//       *(_OWORD *)&v97.shg3 = v12;
			//       v14 = *(_OWORD *)&sh.shb2;
			//       *(_OWORD *)&v97.shg7 = v13;
			//       *(_QWORD *)&v97.shb6 = *(_QWORD *)&sh.shb6;
			//       *(_OWORD *)&v97.shb2 = v14;
			//       *(float *)&v13 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v97, v8, 3, 0LL);
			//       v15 = sh.shb8;
			//       v16 = *(_OWORD *)&sh.shr4;
			//       *(_OWORD *)&v97.shr0 = *(_OWORD *)&sh.shr0;
			//       v17 = v13;
			//       v18 = *(_OWORD *)&sh.shr8;
			//       v97.shb8 = v15;
			//       *(_OWORD *)&v97.shr4 = v16;
			//       v19 = *(_OWORD *)&sh.shg3;
			//       *(_OWORD *)&v97.shr8 = v18;
			//       v20 = *(_OWORD *)&sh.shg7;
			//       *(_OWORD *)&v97.shg3 = v19;
			//       v21 = *(_OWORD *)&sh.shb2;
			//       *(_OWORD *)&v97.shg7 = v20;
			//       *(_QWORD *)&v97.shb6 = *(_QWORD *)&sh.shb6;
			//       *(_OWORD *)&v97.shb2 = v21;
			//       *(float *)&v13 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v97, v8, 1, 0LL);
			//       v22 = sh.shb8;
			//       v23 = *(_OWORD *)&sh.shr4;
			//       *(_OWORD *)&v97.shr0 = *(_OWORD *)&sh.shr0;
			//       v24 = v13;
			//       v25 = *(_OWORD *)&sh.shr8;
			//       v97.shb8 = v22;
			//       *(_OWORD *)&v97.shr4 = v23;
			//       v26 = *(_OWORD *)&sh.shg3;
			//       *(_OWORD *)&v97.shr8 = v25;
			//       v27 = *(_OWORD *)&sh.shg7;
			//       *(_OWORD *)&v97.shg3 = v26;
			//       v28 = *(_OWORD *)&sh.shb2;
			//       *(_OWORD *)&v97.shg7 = v27;
			//       *(_QWORD *)&v97.shb6 = *(_QWORD *)&sh.shb6;
			//       *(_OWORD *)&v97.shb2 = v28;
			//       *(float *)&v13 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v97, v8, 2, 0LL);
			//       v29 = sh.shb8;
			//       v30 = *(_OWORD *)&sh.shr4;
			//       *(_OWORD *)&v97.shr0 = *(_OWORD *)&sh.shr0;
			//       v31 = v13;
			//       v32 = *(_OWORD *)&sh.shr8;
			//       *(_OWORD *)&v97.shr4 = v30;
			//       v33 = *(_OWORD *)&sh.shg3;
			//       *(_OWORD *)&v97.shr8 = v32;
			//       v34 = *(_OWORD *)&sh.shg7;
			//       *(_OWORD *)&v97.shg3 = v33;
			//       v35 = *(_OWORD *)&sh.shb2;
			//       *(_OWORD *)&v97.shg7 = v34;
			//       *(_QWORD *)&v97.shb6 = *(_QWORD *)&sh.shb6;
			//       *(_OWORD *)&v97.shb2 = v35;
			//       v97.shb8 = v29;
			//       *(float *)&v13 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v97, v8, 0, 0LL);
			//       v36 = sh.shb8;
			//       v37 = *(_OWORD *)&sh.shr4;
			//       *(_OWORD *)&v97.shr0 = *(_OWORD *)&sh.shr0;
			//       v38 = *(_OWORD *)&sh.shr8;
			//       v97.shb8 = v36;
			//       *(_OWORD *)&v97.shr4 = v37;
			//       v39 = *(_OWORD *)&sh.shg3;
			//       *(_OWORD *)&v97.shr8 = v38;
			//       v40 = *(_OWORD *)&sh.shg7;
			//       *(_OWORD *)&v97.shg3 = v39;
			//       v41 = *(_OWORD *)&sh.shb2;
			//       *(_OWORD *)&v97.shg7 = v40;
			//       *(_QWORD *)&v97.shb6 = *(_QWORD *)&sh.shb6;
			//       *(_OWORD *)&v97.shb2 = v41;
			//       v42 = *(float *)&v13 - UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v97, v8, 6, 0LL);
			//       v43 = sub_18003EB40(packedCoeffs, v8++);
			//       *(_DWORD *)v43 = v17;
			//       *(_DWORD *)(v43 + 4) = v24;
			//       *(_DWORD *)(v43 + 8) = v31;
			//       *(float *)(v43 + 12) = v42;
			//     }
			//     while ( v8 < 3 );
			//     v44 = 3LL;
			//     do
			//     {
			//       v45 = sh.shb8;
			//       v46 = *(_OWORD *)&sh.shr4;
			//       *(_OWORD *)&v97.shr0 = *(_OWORD *)&sh.shr0;
			//       v47 = *(_OWORD *)&sh.shr8;
			//       v97.shb8 = v45;
			//       *(_OWORD *)&v97.shr4 = v46;
			//       v48 = *(_OWORD *)&sh.shg3;
			//       *(_OWORD *)&v97.shr8 = v47;
			//       v49 = *(_OWORD *)&sh.shg7;
			//       *(_OWORD *)&v97.shg3 = v48;
			//       v50 = *(_OWORD *)&sh.shb2;
			//       *(_OWORD *)&v97.shg7 = v49;
			//       *(_QWORD *)&v97.shb6 = *(_QWORD *)&sh.shb6;
			//       *(_OWORD *)&v97.shb2 = v50;
			//       *(float *)&v49 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v97, v7, 4, 0LL);
			//       v51 = sh.shb8;
			//       v52 = *(_OWORD *)&sh.shr4;
			//       *(_OWORD *)&v97.shr0 = *(_OWORD *)&sh.shr0;
			//       v53 = v49;
			//       v54 = *(_OWORD *)&sh.shr8;
			//       v97.shb8 = v51;
			//       *(_OWORD *)&v97.shr4 = v52;
			//       v55 = *(_OWORD *)&sh.shg3;
			//       *(_OWORD *)&v97.shr8 = v54;
			//       v56 = *(_OWORD *)&sh.shg7;
			//       *(_OWORD *)&v97.shg3 = v55;
			//       v57 = *(_OWORD *)&sh.shb2;
			//       *(_OWORD *)&v97.shg7 = v56;
			//       *(_QWORD *)&v97.shb6 = *(_QWORD *)&sh.shb6;
			//       *(_OWORD *)&v97.shb2 = v57;
			//       *(float *)&v49 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v97, v7, 5, 0LL);
			//       v58 = sh.shb8;
			//       v59 = *(_OWORD *)&sh.shr4;
			//       *(_OWORD *)&v97.shr0 = *(_OWORD *)&sh.shr0;
			//       v60 = v49;
			//       v61 = *(_OWORD *)&sh.shr8;
			//       v97.shb8 = v58;
			//       *(_OWORD *)&v97.shr4 = v59;
			//       v62 = *(_OWORD *)&sh.shg3;
			//       *(_OWORD *)&v97.shr8 = v61;
			//       v63 = *(_OWORD *)&sh.shg7;
			//       *(_OWORD *)&v97.shg3 = v62;
			//       v64 = *(_OWORD *)&sh.shb2;
			//       *(_OWORD *)&v97.shg7 = v63;
			//       *(_QWORD *)&v97.shb6 = *(_QWORD *)&sh.shb6;
			//       *(_OWORD *)&v97.shb2 = v64;
			//       *(float *)&v49 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v97, v7, 6, 0LL);
			//       v65 = sh.shb8;
			//       v66 = *(_OWORD *)&sh.shr4;
			//       *(_OWORD *)&v97.shr0 = *(_OWORD *)&sh.shr0;
			//       v67 = *(float *)&v49;
			//       v68 = *(_OWORD *)&sh.shr8;
			//       *(_OWORD *)&v97.shr4 = v66;
			//       v69 = *(_OWORD *)&sh.shg3;
			//       *(_OWORD *)&v97.shr8 = v68;
			//       v70 = *(_OWORD *)&sh.shg7;
			//       *(_OWORD *)&v97.shg3 = v69;
			//       v71 = *(_OWORD *)&sh.shb2;
			//       *(_OWORD *)&v97.shg7 = v70;
			//       *(_QWORD *)&v97.shb6 = *(_QWORD *)&sh.shb6;
			//       *(_OWORD *)&v97.shb2 = v71;
			//       v97.shb8 = v65;
			//       Item = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v97, v7, 7, 0LL);
			//       v73 = sub_18003EB40(packedCoeffs, v44);
			//       ++v7;
			//       ++v44;
			//       *(_DWORD *)v73 = v53;
			//       *(float *)(v73 + 8) = v67 * 3.0;
			//       *(_DWORD *)(v73 + 4) = v60;
			//       *(float *)(v73 + 12) = Item;
			//     }
			//     while ( v7 < 3 );
			//     v74 = sh.shb8;
			//     v75 = *(_OWORD *)&sh.shr4;
			//     *(_OWORD *)&v97.shr0 = *(_OWORD *)&sh.shr0;
			//     v76 = *(_OWORD *)&sh.shr8;
			//     v97.shb8 = v74;
			//     *(_OWORD *)&v97.shr4 = v75;
			//     v77 = *(_OWORD *)&sh.shg3;
			//     *(_OWORD *)&v97.shr8 = v76;
			//     v78 = *(_OWORD *)&sh.shg7;
			//     *(_OWORD *)&v97.shg3 = v77;
			//     v79 = *(_OWORD *)&sh.shb2;
			//     *(_OWORD *)&v97.shg7 = v78;
			//     *(_QWORD *)&v97.shb6 = *(_QWORD *)&sh.shb6;
			//     *(_OWORD *)&v97.shb2 = v79;
			//     *(float *)&v78 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v97, 0, 8, 0LL);
			//     v80 = sh.shb8;
			//     v81 = *(_OWORD *)&sh.shr4;
			//     *(_OWORD *)&v97.shr0 = *(_OWORD *)&sh.shr0;
			//     v82 = *(_OWORD *)&sh.shr8;
			//     v97.shb8 = v80;
			//     *(_OWORD *)&v97.shr4 = v81;
			//     v83 = v78;
			//     v84 = *(_OWORD *)&sh.shg3;
			//     *(_OWORD *)&v97.shr8 = v82;
			//     v85 = *(_OWORD *)&sh.shg7;
			//     *(_OWORD *)&v97.shg3 = v84;
			//     v86 = *(_OWORD *)&sh.shb2;
			//     *(_OWORD *)&v97.shg7 = v85;
			//     *(_QWORD *)&v97.shb6 = *(_QWORD *)&sh.shb6;
			//     *(_OWORD *)&v97.shb2 = v86;
			//     *(float *)&v78 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v97, 1, 8, 0LL);
			//     v87 = sh.shb8;
			//     v88 = *(_OWORD *)&sh.shr4;
			//     *(_OWORD *)&v97.shr0 = *(_OWORD *)&sh.shr0;
			//     v89 = *(_OWORD *)&sh.shr8;
			//     v97.shb8 = v87;
			//     *(_OWORD *)&v97.shr4 = v88;
			//     v90 = v78;
			//     v91 = *(_OWORD *)&sh.shg3;
			//     *(_OWORD *)&v97.shr8 = v89;
			//     v92 = *(_OWORD *)&sh.shg7;
			//     *(_OWORD *)&v97.shg3 = v91;
			//     v93 = *(_OWORD *)&sh.shb2;
			//     *(_OWORD *)&v97.shg7 = v92;
			//     *(_QWORD *)&v97.shb6 = *(_QWORD *)&sh.shb6;
			//     *(_OWORD *)&v97.shb2 = v93;
			//     v94 = UnityEngine::Rendering::SphericalHarmonicsL2::get_Item(&v97, 2, 8, 0LL);
			//     v95 = (float *)sub_18003EB40(packedCoeffs, 6LL);
			//     *(_DWORD *)v95 = v83;
			//     *((_DWORD *)v95 + 1) = v90;
			//     v95[2] = v94;
			//     v95[3] = 1.0;
			//   }
			// }
			// 
		}

		private const float c0 = 0.2820948f;

		private const float c1 = 0.325735f;

		private const float c2 = 0.27313712f;

		private const float c3 = 0.07884789f;

		private const float c4 = 0.13656856f;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static float[] invNormConsts;

		private const float k0 = 0.2820948f;

		private const float k1 = 0.48860252f;

		private const float k2 = 1.0925485f;

		private const float k3 = 0.31539157f;

		private const float k4 = 0.54627424f;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static float[] ks;
	}
}
