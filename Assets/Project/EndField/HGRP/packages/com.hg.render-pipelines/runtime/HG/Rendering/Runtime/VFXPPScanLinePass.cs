using System;
using HG.Rendering.RenderGraphModule;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;

namespace HG.Rendering.Runtime
{
	public class VFXPPScanLinePass
	{
		public VFXPPScanLinePass()
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

		public static void PrepareScanLineMaterial(Shader scanlinePS)
		{
			// // Void PrepareScanLineMaterial(Shader)
			// void HG::Rendering::Runtime::VFXPPScanLinePass::PrepareScanLineMaterial(Shader *scanlinePS, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   struct VFXPPScanLinePass__Class *v4; // rax
			//   Object_1 *s_scanlineMaterial; // rbx
			//   __int64 v6; // rdx
			//   Material *StaticMaterial; // rax
			//   HGRenderPathBase_HGRenderPathResources *v8; // rdx
			//   PassConstructorID__Enum__Array *v9; // r8
			//   HGCamera *v10; // r9
			//   struct VFXPPScanLinePass__Class *v11; // rcx
			//   Material *v12; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   MethodInfo *v16; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v17; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D8ED99C )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     byte_18D8ED99C = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2122, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2122, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v15, v14);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)scanlinePS, 0LL);
			//   }
			//   else
			//   {
			//     v4 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//     if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass, v3);
			//       v4 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//     }
			//     s_scanlineMaterial = (Object_1 *)v4.static_fields.s_scanlineMaterial;
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v3);
			//     if ( UnityEngine::Object::op_Equality(s_scanlineMaterial, 0LL, 0LL) )
			//     {
			//       if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector, v6);
			//       StaticMaterial = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
			//                          scanlinePS,
			//                          0,
			//                          0LL);
			//       v11 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//       v12 = StaticMaterial;
			//       if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass, v8);
			//         v11 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//       }
			//       v11.static_fields.s_scanlineMaterial = v12;
			//       sub_1800054D0(
			//         (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial,
			//         v8,
			//         v9,
			//         v10,
			//         v16,
			//         v17);
			//     }
			//   }
			// }
			// 
		}

		public static Vector4 CalBoxVecNormalized(Vector4 boxPos, Vector4 center)
		{
			// // Vector4 CalBoxVecNormalized(Vector4, Vector4)
			// Vector4 *HG::Rendering::Runtime::VFXPPScanLinePass::CalBoxVecNormalized(
			//         Vector4 *__return_ptr retstr,
			//         Vector4 *boxPos,
			//         Vector4 *center,
			//         MethodInfo *method)
			// {
			//   Vector2 v7; // r8
			//   Vector2 v8; // r9
			//   __m128 x_low; // xmm3
			//   __m128 z_low; // xmm2
			//   double v11; // xmm0_8
			//   float x; // xmm1_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v14; // rdx
			//   __int64 v15; // rcx
			//   Vector4 v16; // xmm1
			//   Vector4 v18; // [rsp+30h] [rbp-38h] BYREF
			//   Vector4 v19; // [rsp+40h] [rbp-28h] BYREF
			//   Vector4 v20; // [rsp+50h] [rbp-18h] BYREF
			//   Vector2 v21; // [rsp+70h] [rbp+8h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(2123, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2123, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v15, v14);
			//     v16 = *boxPos;
			//     v18 = *center;
			//     v19 = v16;
			//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_785(&v20, Patch, &v19, &v18, 0LL);
			//   }
			//   else
			//   {
			//     x_low = (__m128)LODWORD(boxPos.x);
			//     z_low = (__m128)LODWORD(boxPos.z);
			//     x_low.m128_f32[0] = x_low.m128_f32[0] - center.x;
			//     z_low.m128_f32[0] = z_low.m128_f32[0] - center.z;
			//     v21 = sub_1842BE4B8(
			//             (Vector2)*(_OWORD *)&_mm_unpacklo_ps(x_low, z_low),
			//             (Vector2)*(_OWORD *)&_mm_unpacklo_ps((__m128)0x358637BDu, (__m128)0x358637BDu),
			//             v7,
			//             v8);
			//     *(_QWORD *)&v18.x = sub_182413630(&v21);
			//     v11 = sub_182413570(&v21);
			//     x = v18.x;
			//     z_low.m128_i32[0] = LODWORD(v18.y);
			//     retstr.y = 0.0;
			//     retstr.x = x;
			//     LODWORD(retstr.z) = z_low.m128_i32[0];
			//     retstr.w = *(float *)&v11;
			//   }
			//   return retstr;
			// }
			// 
			return null;
		}

		public static Mesh GetSurface()
		{
			// // Mesh GetSurface()
			// Mesh *HG::Rendering::Runtime::VFXPPScanLinePass::GetSurface(MethodInfo *method)
			// {
			//   __int64 v1; // r8
			//   __int64 v2; // r9
			//   __int64 v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   __int64 v6; // r8
			//   __int64 v7; // r9
			//   Vector3__Array *v8; // rdi
			//   __int64 v9; // rax
			//   __int64 v10; // r8
			//   __int64 v11; // r9
			//   Vector2__Array *v12; // rbx
			//   Array *v13; // rbp
			//   Mesh *v14; // rax
			//   Mesh *v15; // rsi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED99D )
			//   {
			//     sub_18003C530(&TypeInfo::System::Int32);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mesh);
			//     sub_18003C530(&D5DB579018C9E7156FBDD363CF02BDF5FC7931FF78332B7F05DB244870481D85_Field);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector2);
			//     sub_18003C530(&TypeInfo::UnityEngine::Vector3);
			//     sub_18003C530(&off_18C8E7128);
			//     byte_18D8ED99D = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2124, 0LL) )
			//   {
			//     v3 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector3, 10LL, v1, v2);
			//     v8 = (Vector3__Array *)v3;
			//     if ( !v3 )
			//       goto LABEL_28;
			//     if ( !*(_DWORD *)(v3 + 24) )
			//       goto LABEL_29;
			//     *(_QWORD *)(v3 + 32) = _mm_unpacklo_ps((__m128)0xBF000000, (__m128)0LL).m128_u64[0];
			//     *(_DWORD *)(v3 + 40) = 1041865114;
			//     if ( *(_DWORD *)(v3 + 24) <= 1u )
			//       goto LABEL_29;
			//     *(_QWORD *)(v3 + 44) = _mm_unpacklo_ps((__m128)0xBF000000, (__m128)0x3FC00000u).m128_u64[0];
			//     *(_DWORD *)(v3 + 52) = 1041865114;
			//     if ( *(_DWORD *)(v3 + 24) <= 2u )
			//       goto LABEL_29;
			//     *(_QWORD *)(v3 + 56) = _mm_unpacklo_ps((__m128)0xBE800000, (__m128)0LL).m128_u64[0];
			//     *(_DWORD *)(v3 + 64) = 1028443341;
			//     if ( *(_DWORD *)(v3 + 24) <= 3u )
			//       goto LABEL_29;
			//     *(_QWORD *)(v3 + 68) = _mm_unpacklo_ps((__m128)0xBE800000, (__m128)0x3FC00000u).m128_u64[0];
			//     *(_DWORD *)(v3 + 76) = 1028443341;
			//     if ( *(_DWORD *)(v3 + 24) <= 4u )
			//       goto LABEL_29;
			//     *(_QWORD *)(v3 + 80) = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//     *(_DWORD *)(v3 + 88) = 0;
			//     if ( *(_DWORD *)(v3 + 24) <= 5u )
			//       goto LABEL_29;
			//     *(_QWORD *)(v3 + 92) = _mm_unpacklo_ps((__m128)0LL, (__m128)0x3FC00000u).m128_u64[0];
			//     *(_DWORD *)(v3 + 100) = 0;
			//     if ( *(_DWORD *)(v3 + 24) <= 6u )
			//       goto LABEL_29;
			//     *(_QWORD *)(v3 + 104) = _mm_unpacklo_ps((__m128)0x3E800000u, (__m128)0LL).m128_u64[0];
			//     *(_DWORD *)(v3 + 112) = 1028443341;
			//     if ( *(_DWORD *)(v3 + 24) <= 7u )
			//       goto LABEL_29;
			//     *(_QWORD *)(v3 + 116) = _mm_unpacklo_ps((__m128)0x3E800000u, (__m128)0x3FC00000u).m128_u64[0];
			//     *(_DWORD *)(v3 + 124) = 1028443341;
			//     if ( *(_DWORD *)(v3 + 24) <= 8u )
			//       goto LABEL_29;
			//     *(_QWORD *)(v3 + 128) = _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0LL).m128_u64[0];
			//     *(_DWORD *)(v3 + 136) = 1041865114;
			//     if ( *(_DWORD *)(v3 + 24) <= 9u )
			//       goto LABEL_29;
			//     *(_QWORD *)(v3 + 140) = _mm_unpacklo_ps((__m128)0x3F000000u, (__m128)0x3FC00000u).m128_u64[0];
			//     *(_DWORD *)(v3 + 148) = 1041865114;
			//     v9 = il2cpp_array_new_specific_0(TypeInfo::UnityEngine::Vector2, 10LL, v6, v7);
			//     v12 = (Vector2__Array *)v9;
			//     if ( !v9 )
			//       goto LABEL_28;
			//     if ( !*(_DWORD *)(v9 + 24) )
			//       goto LABEL_29;
			//     *(_QWORD *)(v9 + 32) = 0LL;
			//     if ( *(_DWORD *)(v9 + 24) <= 1u )
			//       goto LABEL_29;
			//     *(_DWORD *)(v9 + 40) = 0;
			//     *(_DWORD *)(v9 + 44) = 1065353216;
			//     if ( *(_DWORD *)(v9 + 24) <= 2u )
			//       goto LABEL_29;
			//     *(_QWORD *)(v9 + 48) = 1048576000LL;
			//     if ( *(_DWORD *)(v9 + 24) <= 3u )
			//       goto LABEL_29;
			//     *(_DWORD *)(v9 + 56) = 1048576000;
			//     *(_DWORD *)(v9 + 60) = 1065353216;
			//     if ( *(_DWORD *)(v9 + 24) <= 4u
			//       || (*(_QWORD *)(v9 + 64) = 1056964608LL, *(_DWORD *)(v9 + 24) <= 5u)
			//       || (*(_DWORD *)(v9 + 72) = 1056964608, *(_DWORD *)(v9 + 76) = 1065353216, *(_DWORD *)(v9 + 24) <= 6u)
			//       || (*(_QWORD *)(v9 + 80) = 1061158912LL, *(_DWORD *)(v9 + 24) <= 7u)
			//       || (*(_DWORD *)(v9 + 88) = 1061158912, *(_DWORD *)(v9 + 92) = 1065353216, *(_DWORD *)(v9 + 24) <= 8u)
			//       || (*(_QWORD *)(v9 + 96) = 1065353216LL, *(_DWORD *)(v9 + 24) <= 9u) )
			//     {
			// LABEL_29:
			//       sub_180070270(v5, v4);
			//     }
			//     *(_DWORD *)(v9 + 104) = 1065353216;
			//     *(_DWORD *)(v9 + 108) = 1065353216;
			//     v13 = (Array *)il2cpp_array_new_specific_0(TypeInfo::System::Int32, 24LL, v10, v11);
			//     System::Runtime::CompilerServices::RuntimeHelpers::InitializeArray(
			//       v13,
			//       D5DB579018C9E7156FBDD363CF02BDF5FC7931FF78332B7F05DB244870481D85_Field,
			//       0LL);
			//     v14 = (Mesh *)sub_180004920(TypeInfo::UnityEngine::Mesh);
			//     v15 = v14;
			//     if ( v14 )
			//     {
			//       UnityEngine::Mesh::Mesh(v14, 0LL);
			//       UnityEngine::Mesh::set_vertices(v15, v8, 0LL);
			//       UnityEngine::Mesh::set_uv(v15, v12, 0LL);
			//       UnityEngine::Mesh::set_triangles(v15, (Int32__Array *)v13, 0LL);
			//       UnityEngine::Object::set_name((Object_1 *)v15, (String *)"HighlightSurface2", 0LL);
			//       UnityEngine::Object::set_hideFlags((Object_1 *)v15, HideFlags__Enum_HideAndDontSave, 0LL);
			//       UnityEngine::Mesh::UploadMeshData(v15, 1, 0LL);
			//       return v15;
			//     }
			// LABEL_28:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2124, 0LL);
			//   if ( !Patch )
			//     goto LABEL_28;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_366(Patch, 0LL);
			// }
			// 
			return null;
		}

		internal static void PrepareResources(HGRenderPipelineRuntimeResources defaultResources)
		{
		}

		public static bool ShouldRequestVerticalOcclusionMap(HGCamera hgCamera)
		{
			// // Boolean ShouldRequestVerticalOcclusionMap(HGCamera)
			// bool HG::Rendering::Runtime::VFXPPScanLinePass::ShouldRequestVerticalOcclusionMap(
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rbx
			//   HGScanLine *m_hgScanLine; // rbx
			//   Vector4Parameter *boxPosition1; // rdi
			//   __m128 *v8; // rax
			//   Vector4Parameter *boxPosition2; // rdi
			//   __m128 v10; // xmm7
			//   __m128 *v11; // rax
			//   Vector4Parameter *boxPosition3; // rbx
			//   __m128 v13; // xmm6
			//   __int64 v14; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   _BYTE v17[16]; // [rsp+20h] [rbp-38h] BYREF
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
			//     goto LABEL_17;
			//   if ( wrapperArray.max_length.size <= 786 )
			//     goto LABEL_7;
			//   if ( !v3._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//   if ( !v3 )
			// LABEL_17:
			//     sub_180B536AC(v3, wrapperArray);
			//   if ( LODWORD(v3._0.namespaze) <= 0x312 )
			//     sub_180070270(v3, wrapperArray);
			//   if ( *(_QWORD *)&v3[16]._1.naturalAligment )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(786, 0LL);
			//     if ( Patch )
			//       return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8(
			//                (ILFixDynamicMethodWrapper_27 *)Patch,
			//                (Object *)hgCamera,
			//                0LL);
			//     goto LABEL_17;
			//   }
			// LABEL_7:
			//   if ( !hgCamera )
			//     goto LABEL_17;
			//   m_volumeComponentsData = hgCamera.fields.m_volumeComponentsData;
			//   if ( !m_volumeComponentsData )
			//     goto LABEL_17;
			//   m_hgScanLine = m_volumeComponentsData.fields.m_hgScanLine;
			//   if ( !m_hgScanLine )
			//     goto LABEL_17;
			//   boxPosition1 = m_hgScanLine.fields.boxPosition1;
			//   if ( !boxPosition1 )
			//     goto LABEL_17;
			//   sub_180003EE0(boxPosition1.klass);
			//   v8 = (__m128 *)((__int64 (__fastcall *)(_BYTE *, Vector4Parameter *, Il2CppMethodPointer))boxPosition1.klass.vtable.get_value.method)(
			//                    v17,
			//                    boxPosition1,
			//                    boxPosition1.klass.vtable.set_value.methodPtr);
			//   boxPosition2 = m_hgScanLine.fields.boxPosition2;
			//   v10 = *v8;
			//   if ( !boxPosition2 )
			//     goto LABEL_17;
			//   sub_180003EE0(boxPosition2.klass);
			//   v11 = (__m128 *)((__int64 (__fastcall *)(_BYTE *, Vector4Parameter *, Il2CppMethodPointer))boxPosition2.klass.vtable.get_value.method)(
			//                     v17,
			//                     boxPosition2,
			//                     boxPosition2.klass.vtable.set_value.methodPtr);
			//   boxPosition3 = m_hgScanLine.fields.boxPosition3;
			//   v13 = *v11;
			//   if ( !boxPosition3 )
			//     goto LABEL_17;
			//   sub_180003EE0(boxPosition3.klass);
			//   v14 = ((__int64 (__fastcall *)(_BYTE *, Vector4Parameter *, Il2CppMethodPointer))boxPosition3.klass.vtable.get_value.method)(
			//           v17,
			//           boxPosition3,
			//           boxPosition3.klass.vtable.set_value.methodPtr);
			//   return _mm_shuffle_ps(v10, v10, 255).m128_f32[0] == 1.0
			//       || _mm_shuffle_ps(v13, v13, 255).m128_f32[0] == 1.0
			//       || *(float *)(v14 + 12) == 1.0;
			// }
			// 
			return default(bool);
		}

		public static void RequestVerticalOcclusionMap(HGCamera hgCamera)
		{
			// // Void RequestVerticalOcclusionMap(HGCamera)
			// void HG::Rendering::Runtime::VFXPPScanLinePass::RequestVerticalOcclusionMap(HGCamera *hgCamera, MethodInfo *method)
			// {
			//   struct ILFixDynamicMethodWrapper_2__Class *v3; // rcx
			//   ILFixDynamicMethodWrapper_2__Array *wrapperArray; // rdx
			//   HGVerticalOcclusionMapManager *verticalOcclusionMapManager; // rbx
			//   __int64 v6; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   ILFixDynamicMethodWrapper_2 *v8; // rax
			// 
			//   if ( !byte_18D8ED99F )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     byte_18D8ED99F = 1;
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
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_22;
			//   if ( wrapperArray.max_length.size > 785 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     wrapperArray = v3.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_22;
			//     if ( wrapperArray.max_length.size <= 0x311u )
			//       goto LABEL_37;
			//     if ( wrapperArray[21].vector[29] )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(785, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)hgCamera, 0LL);
			//         return;
			//       }
			//       goto LABEL_22;
			//     }
			//   }
			//   if ( !hgCamera )
			//     goto LABEL_22;
			//   verticalOcclusionMapManager = hgCamera.fields.verticalOcclusionMapManager;
			//   if ( !verticalOcclusionMapManager )
			//     return;
			//   if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass, wrapperArray);
			//   if ( HG::Rendering::Runtime::VFXPPScanLinePass::ShouldRequestVerticalOcclusionMap(hgCamera, 0LL) )
			//   {
			//     HG::Rendering::Runtime::HGVerticalOcclusionMapManager::RegisterRequestUsage(
			//       verticalOcclusionMapManager,
			//       HGVerticalOcclusionMapManager_RequestUsageType__Enum_ScanlineHighlight,
			//       0LL);
			//     return;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, v6);
			//     v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   wrapperArray = v3.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_22;
			//   if ( wrapperArray.max_length.size > 749 )
			//   {
			//     if ( !v3._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//       v3 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     }
			//     v3 = (struct ILFixDynamicMethodWrapper_2__Class *)v3.static_fields.wrapperArray;
			//     if ( !v3 )
			//       goto LABEL_22;
			//     if ( LODWORD(v3._0.namespaze) > 0x2ED )
			//     {
			//       if ( !v3[16]._0.gc_desc )
			//         goto LABEL_20;
			//       v8 = IFix::WrappersManagerImpl::GetPatch(749, 0LL);
			//       if ( v8 )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_2(
			//           (ILFixDynamicMethodWrapper_28 *)v8,
			//           (Object *)verticalOcclusionMapManager,
			//           2,
			//           0LL);
			//         return;
			//       }
			// LABEL_22:
			//       sub_180B536AC(v3, wrapperArray);
			//     }
			// LABEL_37:
			//     sub_180070270(v3, wrapperArray);
			//   }
			// LABEL_20:
			//   verticalOcclusionMapManager.fields.m_requestType &= ~2u;
			// }
			// 
		}

		public static Vector4 CalAndChooseHeightValue(Vector4 scanLineCenterPos, Vector4 Box, Vector4 scanlineParams1, Vector4 detectDist, Vector3 beamHeight)
		{
			// // Vector4 CalAndChooseHeightValue(Vector4, Vector4, Vector4, Vector4, Vector3)
			// Vector4 *HG::Rendering::Runtime::VFXPPScanLinePass::CalAndChooseHeightValue(
			//         Vector4 *__return_ptr retstr,
			//         Vector4 *scanLineCenterPos,
			//         Vector4 *Box,
			//         Vector4 *scanlineParams1,
			//         Vector4 *detectDist,
			//         Vector3 *beamHeight,
			//         MethodInfo *method)
			// {
			//   __int64 v11; // rdx
			//   int v12; // ecx
			//   __int64 v13; // rdx
			//   int v14; // ecx
			//   float3 *v15; // rdx
			//   float3 *v16; // rcx
			//   float3 *v17; // r8
			//   float3 *v18; // r9
			//   float v19; // xmm6_4
			//   unsigned int v20; // xmm0_4
			//   System::MathF *v21; // rcx
			//   float x; // xmm0_4
			//   Vector4 v23; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   __int64 v25; // rcx
			//   Vector4 v26; // xmm1
			//   __int64 v27; // xmm0_8
			//   Vector4 v28; // xmm1
			//   Vector4 v29; // xmm0
			//   Vector4 *result; // rax
			//   Vector4 v31; // [rsp+48h] [rbp-41h] BYREF
			//   Vector4 v32; // [rsp+58h] [rbp-31h] BYREF
			//   Vector4 v33; // [rsp+68h] [rbp-21h] BYREF
			//   Vector4 v34; // [rsp+78h] [rbp-11h] BYREF
			//   Vector4 v35; // [rsp+88h] [rbp-1h] BYREF
			//   Vector4 v36; // [rsp+98h] [rbp+Fh] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2126, 0LL) )
			//   {
			//     sub_1802EB1B0(v12, v11);
			//     sub_1802EB1B0(v14, v13);
			//     v19 = sub_1802ECED0(v16, v15, v17, v18);
			//     *(float *)&v20 = fminf(v19, detectDist.w) / scanlineParams1.y;
			//     System::MathF::Floor(v21, 2.0);
			//     v31.w = 0.0;
			//     *(_QWORD *)&v31.y = v20;
			//     if ( v19 < 0.0 || detectDist.x < v19 )
			//     {
			//       if ( v19 <= detectDist.x || detectDist.y < v19 )
			//       {
			//         if ( v19 <= detectDist.y || detectDist.z < v19 )
			//         {
			//           v31.x = 0.0;
			//           goto LABEL_13;
			//         }
			//         x = beamHeight.x;
			//       }
			//       else
			//       {
			//         x = beamHeight.y;
			//       }
			//     }
			//     else
			//     {
			//       x = beamHeight.z;
			//     }
			//     v31.x = x;
			// LABEL_13:
			//     v23 = v31;
			//     goto LABEL_17;
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2126, 0LL);
			//   if ( !Patch )
			//     sub_180B536AC(v25, 0LL);
			//   v26 = *scanlineParams1;
			//   v27 = *(_QWORD *)&beamHeight.x;
			//   v31.z = beamHeight.z;
			//   *(_QWORD *)&v31.x = v27;
			//   v33 = v26;
			//   v28 = *scanLineCenterPos;
			//   v32 = *detectDist;
			//   v29 = *Box;
			//   v35 = v28;
			//   v34 = v29;
			//   v23 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_786(&v36, Patch, &v35, &v34, &v33, &v32, (Vector3 *)&v31, 0LL);
			// LABEL_17:
			//   result = retstr;
			//   *retstr = v23;
			//   return result;
			// }
			// 
			return null;
		}

		public static void TransferDataAndDrawMesh(HGRenderGraphContext ctx, Vector4 result, Vector4 Box, float meshHeight)
		{
			// // Void TransferDataAndDrawMesh(HGRenderGraphContext, Vector4, Vector4, Single)
			// void HG::Rendering::Runtime::VFXPPScanLinePass::TransferDataAndDrawMesh(
			//         HGRenderGraphContext *ctx,
			//         Vector4 *result,
			//         Vector4 *Box,
			//         float meshHeight,
			//         MethodInfo *method)
			// {
			//   float y; // xmm0_4
			//   int32_t count; // ebp
			//   MaterialPropertyBlock *s_materialPropertyBlock; // rsi
			//   MaterialPropertyBlock *cmd; // rcx
			//   HGShaderIDs__StaticFields *static_fields; // rdx
			//   int32_t BoxPosWS; // edx
			//   VFXPPScanLinePass__StaticFields *v14; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v16; // xmm1
			//   Vector4 v17; // [rsp+40h] [rbp-38h] BYREF
			//   Vector4 v18; // [rsp+50h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919430 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     byte_18D919430 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2127, 0LL) )
			//   {
			//     y = result.y;
			//     if ( y < 1.0 )
			//       return;
			//     count = (int)y;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     s_materialPropertyBlock = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_materialPropertyBlock;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//     if ( s_materialPropertyBlock )
			//     {
			//       UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//         s_materialPropertyBlock,
			//         static_fields._ScanLineHighlightHeight,
			//         result.x,
			//         0LL);
			//       cmd = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_materialPropertyBlock;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( cmd )
			//       {
			//         UnityEngine::MaterialPropertyBlock::SetFloatImpl(cmd, static_fields._CountPerArray, (float)count, 0LL);
			//         cmd = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_materialPropertyBlock;
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         if ( cmd )
			//         {
			//           BoxPosWS = static_fields._BoxPosWS;
			//           v17 = *Box;
			//           UnityEngine::MaterialPropertyBlock::SetVector(cmd, BoxPosWS, &v17, 0LL);
			//           cmd = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_materialPropertyBlock;
			//           static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//           if ( cmd )
			//           {
			//             UnityEngine::MaterialPropertyBlock::SetFloatImpl(cmd, static_fields._MeshHeight, meshHeight, 0LL);
			//             if ( ctx )
			//             {
			//               cmd = (MaterialPropertyBlock *)ctx.fields.cmd;
			//               v14 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//               static_fields = (HGShaderIDs__StaticFields *)v14.s_HighlightMesh;
			//               if ( cmd )
			//               {
			//                 UnityEngine::Rendering::CommandBuffer::DrawMeshInstancedProcedural(
			//                   (CommandBuffer *)cmd,
			//                   (Mesh *)static_fields,
			//                   0,
			//                   v14.s_HighlightMat,
			//                   0,
			//                   count,
			//                   v14.s_materialPropertyBlock,
			//                   0LL);
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(cmd, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2127, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   v16 = *result;
			//   v17 = *Box;
			//   v18 = v16;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_787(Patch, (Object *)ctx, &v18, &v17, meshHeight, 0LL);
			// }
			// 
		}

		public static void Draw(Vector4 Box, Vector4 scanLineCenterPos, Vector4 scanlineParams1, HighlightDataPack highlightDataPack, HGRenderGraphContext ctx)
		{
			// // Void Draw(Vector4, Vector4, Vector4, HighlightDataPack, HGRenderGraphContext)
			// void HG::Rendering::Runtime::VFXPPScanLinePass::Draw(
			//         Vector4 *Box,
			//         Vector4 *scanLineCenterPos,
			//         Vector4 *scanlineParams1,
			//         HighlightDataPack *highlightDataPack,
			//         HGRenderGraphContext *ctx,
			//         MethodInfo *method)
			// {
			//   Vector4 detectDistance; // xmm7
			//   Vector4 v11; // xmm1
			//   Vector4 v12; // xmm0
			//   __m128i v13; // xmm6
			//   Vector4 *v14; // rax
			//   Vector4 v15; // xmm0
			//   float meshHeight; // xmm3_4
			//   __int64 v17; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   __int128 v19; // xmm1
			//   Vector4 v20; // xmm0
			//   Vector4 v21; // xmm1
			//   Vector4 v22; // xmm0
			//   Vector3 v23; // [rsp+48h] [rbp-59h] BYREF
			//   Vector4 v24; // [rsp+58h] [rbp-49h] BYREF
			//   Vector4 v25; // [rsp+68h] [rbp-39h] BYREF
			//   Vector4 v26; // [rsp+78h] [rbp-29h] BYREF
			//   Vector4 v27[2]; // [rsp+88h] [rbp-19h] BYREF
			//   HighlightDataPack v28[2]; // [rsp+A8h] [rbp+7h] BYREF
			// 
			//   if ( !byte_18D919431 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     byte_18D919431 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2128, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2128, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v17);
			//     v19 = *(_OWORD *)&highlightDataPack.beamHeight.x;
			//     v28[0].detectDistance = highlightDataPack.detectDistance;
			//     v20 = *scanlineParams1;
			//     *(_OWORD *)&v28[0].beamHeight.x = v19;
			//     v21 = *scanLineCenterPos;
			//     v27[0] = v20;
			//     v22 = *Box;
			//     v26 = v21;
			//     v25 = v22;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_788(Patch, &v25, &v26, v27, v28, (Object *)ctx, 0LL);
			//   }
			//   else if ( Box.w == 1.0 )
			//   {
			//     detectDistance = highlightDataPack.detectDistance;
			//     *(_OWORD *)&v28[0].beamHeight.x = *(_OWORD *)&highlightDataPack.beamHeight.x;
			//     v28[0].detectDistance = detectDistance;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     v11 = *Box;
			//     v25 = *scanlineParams1;
			//     v12 = *scanLineCenterPos;
			//     *(_QWORD *)&v23.x = *(_QWORD *)&v28[0].beamHeight.x;
			//     v13 = _mm_loadl_epi64((const __m128i *)&highlightDataPack.beamHeight.z);
			//     v27[0] = v12;
			//     LODWORD(v23.z) = _mm_cvtsi128_si32(v13);
			//     v24 = detectDistance;
			//     v26 = v11;
			//     v14 = HG::Rendering::Runtime::VFXPPScanLinePass::CalAndChooseHeightValue(
			//             &v28[0].detectDistance,
			//             v27,
			//             &v26,
			//             &v25,
			//             &v24,
			//             &v23,
			//             0LL);
			//     v15 = *Box;
			//     meshHeight = highlightDataPack.meshHeight;
			//     v26 = *v14;
			//     v27[0] = v15;
			//     HG::Rendering::Runtime::VFXPPScanLinePass::TransferDataAndDrawMesh(ctx, &v26, v27, meshHeight, 0LL);
			//   }
			// }
			// 
		}

		public unsafe static VFXPPScanLinePassInput* GetCppPassInput(HGCamera hgCamera)
		{
			// // VFXPPScanLinePassInput* GetCppPassInput(HGCamera)
			// VFXPPScanLinePassInput *HG::Rendering::Runtime::VFXPPScanLinePass::GetCppPassInput(
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   __int64 (__fastcall *v3)(__int64); // rax
			//   __int64 v4; // rdx
			//   VFXPPScanLinePassInput *v5; // rbx
			//   VFXPPScanLinePass__StaticFields *static_fields; // rcx
			//   Texture *s_scanlineMaskTex; // rsi
			//   void *v8; // rdi
			//   void *m_CachedPtr; // rax
			//   Texture *s_blackBoxContourTex; // rsi
			//   struct VFXPPScanLinePass__Class *v11; // rax
			//   Material *s_HighlightMat; // rax
			//   Mesh *s_HighlightMesh; // rax
			//   __int64 v15; // rax
			//   Texture *v16; // rax
			//   Texture *v17; // rdi
			// 
			//   if ( !byte_18D8ED9A0 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     byte_18D8ED9A0 = 1;
			//   }
			//   if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass, method);
			//   HG::Rendering::Runtime::VFXPPScanLinePass::UpdateDataPack(hgCamera, 0LL);
			//   v3 = (__int64 (__fastcall *)(__int64))qword_18D8F57F8;
			//   if ( !qword_18D8F57F8 )
			//   {
			//     v3 = (__int64 (__fastcall *)(__int64))il2cpp_resolve_icall_0(
			//                                             "UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
			//     if ( !v3 )
			//     {
			//       v15 = sub_1802DBBE8("UnityEngine.HyperGryphEngineCode.HGRenderGraphCPP::AllocateTempFromCSharp(System.Int64)");
			//       sub_18000F750(v15, 0LL);
			//     }
			//     qword_18D8F57F8 = (__int64)v3;
			//   }
			//   v5 = (VFXPPScanLinePassInput *)v3(56LL);
			//   static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//   if ( !v5 )
			//     goto LABEL_39;
			//   v5.useScanLine = static_fields.s_useScanLine;
			//   v5.useBlackBox = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_useBlackBox;
			//   v5.scanLineUseMask = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanLineUseMask;
			//   v5.shouldDrawScanLineHighlight = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_shouldDrawScanlineHighlight;
			//   v5.scanLineDataPack = &TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack;
			//   s_scanlineMaskTex = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaskTex;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   v8 = 0LL;
			//   if ( !s_scanlineMaskTex )
			//     goto LABEL_19;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//   if ( s_scanlineMaskTex.fields._.m_CachedPtr )
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass, v4);
			//     static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v16 = static_fields.s_scanlineMaskTex;
			//     if ( !v16 )
			//       goto LABEL_39;
			//     m_CachedPtr = v16.fields._.m_CachedPtr;
			//   }
			//   else
			//   {
			// LABEL_19:
			//     m_CachedPtr = 0LL;
			//   }
			//   v5.scanlineMaskTex = m_CachedPtr;
			//   if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass, v4);
			//   s_blackBoxContourTex = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_blackBoxContourTex;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( s_blackBoxContourTex )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v4);
			//     if ( s_blackBoxContourTex.fields._.m_CachedPtr )
			//     {
			//       if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass, v4);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//       v17 = static_fields.s_blackBoxContourTex;
			//       if ( v17 )
			//       {
			//         v8 = v17.fields._.m_CachedPtr;
			//         goto LABEL_34;
			//       }
			// LABEL_39:
			//       sub_180B536AC(static_fields, v4);
			//     }
			//   }
			// LABEL_34:
			//   v5.blackBoxContourTex = v8;
			//   v11 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//   if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass, v4);
			//     v11 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//   }
			//   v5.highlightDataPack = &v11.static_fields.s_highlightDataPack;
			//   static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//   s_HighlightMat = static_fields.s_HighlightMat;
			//   if ( !s_HighlightMat )
			//     goto LABEL_39;
			//   v5.highlightMaterial = s_HighlightMat.fields._.m_CachedPtr;
			//   static_fields = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//   s_HighlightMesh = static_fields.s_HighlightMesh;
			//   if ( !s_HighlightMesh )
			//     goto LABEL_39;
			//   v5.highlightMesh = s_HighlightMesh.fields._.m_CachedPtr;
			//   return v5;
			// }
			// 
			return null;
		}

		public static void UpdateDataPack(HGCamera hgCamera)
		{
			// // Void UpdateDataPack(HGCamera)
			// void HG::Rendering::Runtime::VFXPPScanLinePass::UpdateDataPack(HGCamera *hgCamera, MethodInfo *method)
			// {
			//   _QWORD **v3; // rcx
			//   int *wrapperArray; // rdx
			//   HGCamera_VolumeComponentsData *m_volumeComponentsData; // rax
			//   Object *m_hgScanLine; // r14
			//   Object *m_hgBlackBox; // rbp
			//   int v8; // edi
			//   unsigned __int8 v9; // al
			//   int v10; // esi
			//   struct VFXPPScanLinePass__Class *v11; // rax
			//   unsigned __int8 v12; // al
			//   struct VFXPPScanLinePass__Class *v13; // rax
			//   __int64 v14; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v16; // rax
			//   ILFixDynamicMethodWrapper_2 *v17; // rax
			//   ILFixDynamicMethodWrapper_2 *v18; // rax
			//   Material *v19; // rdi
			//   struct HGShaderKeyWords__Class *v20; // rax
			//   HGShaderKeyWords__StaticFields *static_fields; // rax
			//   MonitorData *monitor; // r8
			//   _OWORD *v23; // rax
			//   char v24; // al
			//   __int64 v25; // rax
			//   HGRenderPathBase_HGRenderPathResources *v26; // rdx
			//   PassConstructorID__Enum__Array *v27; // r8
			//   HGCamera *v28; // r9
			//   struct VFXPPScanLinePass__Class *v29; // rcx
			//   Texture *v30; // rdi
			//   VFXPPScanLinePass__StaticFields *v31; // rdi
			//   VFXPPScanLinePass__StaticFields *v32; // rdi
			//   VFXPPScanLinePass__StaticFields *v33; // rdi
			//   VFXPPScanLinePass__StaticFields *v34; // rdi
			//   MonitorData *v35; // r8
			//   _OWORD *v36; // rax
			//   VFXPPScanLinePass__StaticFields *v37; // rdi
			//   VFXPPScanLinePass__StaticFields *v38; // rdi
			//   VFXPPScanLinePass__StaticFields *v39; // rdi
			//   VFXPPScanLinePass__StaticFields *v40; // rdi
			//   VFXPPScanLinePass__StaticFields *v41; // rdi
			//   VFXPPScanLinePass__StaticFields *v42; // rdi
			//   VFXPPScanLinePass__StaticFields *v43; // rdi
			//   VFXPPScanLinePass__StaticFields *v44; // rdi
			//   VFXPPScanLinePass__StaticFields *v45; // rdi
			//   VFXPPScanLinePass__StaticFields *v46; // rdi
			//   VFXPPScanLinePass__StaticFields *v47; // rdi
			//   VFXPPScanLinePass__StaticFields *v48; // rdi
			//   VFXPPScanLinePass__StaticFields *v49; // rdi
			//   VFXPPScanLinePass__StaticFields *v50; // rdi
			//   VFXPPScanLinePass__StaticFields *v51; // rdi
			//   VFXPPScanLinePass__StaticFields *v52; // rdi
			//   VFXPPScanLinePass__StaticFields *v53; // rdi
			//   VFXPPScanLinePass__StaticFields *v54; // rdi
			//   VFXPPScanLinePass__StaticFields *v55; // rdi
			//   VFXPPScanLinePass__StaticFields *v56; // rdi
			//   VFXPPScanLinePass__StaticFields *v57; // rdi
			//   VFXPPScanLinePass__StaticFields *v58; // rdi
			//   VFXPPScanLinePass__StaticFields *v59; // rdi
			//   VFXPPScanLinePass__StaticFields *v60; // rdi
			//   VFXPPScanLinePass__StaticFields *v61; // rdi
			//   VFXPPScanLinePass__StaticFields *v62; // rdi
			//   VFXPPScanLinePass__StaticFields *v63; // rdi
			//   VFXPPScanLinePass__StaticFields *v64; // rdi
			//   VFXPPScanLinePass__StaticFields *v65; // rdi
			//   VFXPPScanLinePass__StaticFields *v66; // rdi
			//   VFXPPScanLinePass__StaticFields *v67; // rdi
			//   VFXPPScanLinePass__StaticFields *v68; // rdi
			//   VFXPPScanLinePass__StaticFields *v69; // rdi
			//   VFXPPScanLinePass__StaticFields *v70; // rdi
			//   VFXPPScanLinePass__StaticFields *v71; // rdi
			//   VFXPPScanLinePass__StaticFields *v72; // rdi
			//   VFXPPScanLinePass__StaticFields *v73; // rdi
			//   Object__Class *klass; // r8
			//   _OWORD *v75; // rax
			//   MonitorData *v76; // r8
			//   _OWORD *v77; // rax
			//   Object__Class *v78; // r8
			//   _OWORD *v79; // rax
			//   Object__Class *v80; // r8
			//   _OWORD *v81; // rax
			//   MonitorData *v82; // r8
			//   bool ShouldRequestVerticalOcclusionMap; // al
			//   float *v84; // rbx
			//   VFXPPScanLinePass__StaticFields *v85; // rbx
			//   VFXPPScanLinePass__StaticFields *v86; // rbx
			//   VFXPPScanLinePass__StaticFields *v87; // rbx
			//   VFXPPScanLinePass__StaticFields *v88; // rbx
			//   VFXPPScanLinePass__StaticFields *v89; // rbx
			//   VFXPPScanLinePass__StaticFields *v90; // rbx
			//   MonitorData *v91; // r8
			//   _OWORD *v92; // rax
			//   MonitorData *v93; // r8
			//   _OWORD *v94; // rax
			//   Object__Class *v95; // r8
			//   _OWORD *v96; // rax
			//   VFXPPScanLinePass__StaticFields *v97; // rbx
			//   float v98; // xmm0_4
			//   VFXPPScanLinePass__StaticFields *v99; // rbx
			//   VFXPPScanLinePass__StaticFields *v100; // rbx
			//   float v101; // xmm0_4
			//   VFXPPScanLinePass__StaticFields *v102; // rbx
			//   VFXPPScanLinePass__StaticFields *v103; // rbx
			//   VFXPPScanLinePass__StaticFields *v104; // rbx
			//   VFXPPScanLinePass__StaticFields *v105; // rbx
			//   VFXPPScanLinePass__StaticFields *v106; // rbx
			//   VFXPPScanLinePass__StaticFields *v107; // rbx
			//   VFXPPScanLinePass__StaticFields *v108; // rbx
			//   VFXPPScanLinePass__StaticFields *v109; // rbx
			//   VFXPPScanLinePass__StaticFields *v110; // rbx
			//   VFXPPScanLinePass__StaticFields *v111; // rbx
			//   VFXPPScanLinePass__StaticFields *v112; // rbx
			//   VFXPPScanLinePass__StaticFields *v113; // rbx
			//   VFXPPScanLinePass__StaticFields *v114; // rbx
			//   __int64 v115; // rax
			//   HGRenderPathBase_HGRenderPathResources *v116; // rdx
			//   PassConstructorID__Enum__Array *v117; // r8
			//   HGCamera *v118; // r9
			//   VFXPPScanLinePass__StaticFields *v119; // rbx
			//   __int64 v120; // rdx
			//   struct VFXPPScanLinePass__Class *v121; // rax
			//   VFXPPScanLinePass__StaticFields *v122; // rbx
			//   __int64 v123; // rdx
			//   struct VFXPPScanLinePass__Class *v124; // rax
			//   VFXPPScanLinePass__StaticFields *v125; // rbx
			//   __int64 v126; // rdx
			//   struct VFXPPScanLinePass__Class *v127; // rax
			//   VFXPPScanLinePass__StaticFields *v128; // rbx
			//   VFXPPScanLinePass__StaticFields *v129; // rbx
			//   MethodInfo *v130; // [rsp+20h] [rbp-38h] BYREF
			//   MethodInfo *v131; // [rsp+28h] [rbp-30h]
			// 
			//   if ( !byte_18D8ED9A1 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     byte_18D8ED9A1 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, method);
			//   v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
			//   if ( !wrapperArray )
			//     goto LABEL_63;
			//   if ( wrapperArray[6] > 2129 )
			//   {
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//     wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
			//     v14 = *(_QWORD *)wrapperArray;
			//     if ( !*(_QWORD *)wrapperArray )
			//       goto LABEL_63;
			//     if ( *(_DWORD *)(v14 + 24) <= 0x851u )
			//       goto LABEL_87;
			//     if ( *(_QWORD *)(v14 + 17064) )
			//     {
			//       Patch = IFix::WrappersManagerImpl::GetPatch(2129, 0LL);
			//       if ( Patch )
			//       {
			//         IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)hgCamera, 0LL);
			//         return;
			//       }
			//       goto LABEL_63;
			//     }
			//   }
			//   if ( !hgCamera )
			//     goto LABEL_63;
			//   m_volumeComponentsData = hgCamera.fields.m_volumeComponentsData;
			//   if ( !m_volumeComponentsData )
			//     goto LABEL_63;
			//   m_hgScanLine = (Object *)m_volumeComponentsData.fields.m_hgScanLine;
			//   m_hgBlackBox = (Object *)m_volumeComponentsData.fields.m_hgBlackBox;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   v8 = 0;
			//   if ( !m_hgScanLine )
			//     goto LABEL_62;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( m_hgScanLine[1].klass )
			//   {
			//     if ( !byte_18D8EDC37 )
			//     {
			//       sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//       byte_18D8EDC37 = 1;
			//     }
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//     v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//     wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields.wrapperArray;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     if ( wrapperArray[6] <= 2130 )
			//       goto LABEL_29;
			//     if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//     wrapperArray = (int *)TypeInfo::IFix::ILFixDynamicMethodWrapper.static_fields;
			//     v16 = *(_QWORD *)wrapperArray;
			//     if ( !*(_QWORD *)wrapperArray )
			//       goto LABEL_63;
			//     if ( *(_DWORD *)(v16 + 24) <= 0x852u )
			//       goto LABEL_87;
			//     if ( *(_QWORD *)(v16 + 17072) )
			//     {
			//       v17 = IFix::WrappersManagerImpl::GetPatch(2130, 0LL);
			//       if ( !v17 )
			//         goto LABEL_63;
			//       v9 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v17, m_hgScanLine, 0LL);
			//     }
			//     else
			//     {
			// LABEL_29:
			//       wrapperArray = (int *)m_hgScanLine[3].klass;
			//       if ( !wrapperArray )
			//         goto LABEL_63;
			//       v9 = sub_1800023D0(10LL, wrapperArray);
			//       if ( v9 )
			//       {
			//         wrapperArray = (int *)m_hgScanLine[7].monitor;
			//         if ( !wrapperArray )
			//           goto LABEL_63;
			//         LOWORD(v3) = 10;
			//         v9 = sub_18003F9B0(v3, wrapperArray) > 0.0;
			//       }
			//     }
			//     v10 = v9;
			//   }
			//   else
			//   {
			// LABEL_62:
			//     v10 = 0;
			//   }
			//   v11 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//   if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass, wrapperArray);
			//     v11 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//   }
			//   v11.static_fields.s_useScanLine = v10 != 0;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !byte_18D8F4EFB )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EFB = 1;
			//   }
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//   if ( !byte_18D8F4EAF )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8F4EAF = 1;
			//   }
			//   if ( m_hgBlackBox )
			//   {
			//     if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, wrapperArray);
			//     if ( m_hgBlackBox[1].klass )
			//     {
			//       if ( !byte_18D8EDC37 )
			//       {
			//         sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//         byte_18D8EDC37 = 1;
			//       }
			//       v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, wrapperArray);
			//         v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       }
			//       wrapperArray = (int *)*v3[23];
			//       if ( !wrapperArray )
			//         goto LABEL_63;
			//       if ( wrapperArray[6] <= 2131 )
			//         goto LABEL_52;
			//       if ( !*((_DWORD *)v3 + 56) )
			//       {
			//         il2cpp_runtime_class_init_0(v3, wrapperArray);
			//         v3 = (_QWORD **)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//       }
			//       v3 = (_QWORD **)*v3[23];
			//       if ( !v3 )
			//         goto LABEL_63;
			//       if ( *((_DWORD *)v3 + 6) > 0x853u )
			//       {
			//         if ( v3[2135] )
			//         {
			//           v18 = IFix::WrappersManagerImpl::GetPatch(2131, 0LL);
			//           if ( !v18 )
			//             goto LABEL_63;
			//           v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)v18, m_hgBlackBox, 0LL);
			// LABEL_54:
			//           v8 = v12;
			//           goto LABEL_55;
			//         }
			// LABEL_52:
			//         wrapperArray = (int *)m_hgBlackBox[3].klass;
			//         if ( !wrapperArray )
			//           goto LABEL_63;
			//         v12 = sub_1800023D0(10LL, wrapperArray);
			//         if ( v12 )
			//         {
			//           wrapperArray = (int *)m_hgBlackBox[3].monitor;
			//           if ( !wrapperArray )
			//             goto LABEL_63;
			//           v12 = sub_1800023D0(10LL, wrapperArray);
			//         }
			//         goto LABEL_54;
			//       }
			// LABEL_87:
			//       sub_180070270(v3, wrapperArray);
			//     }
			//   }
			// LABEL_55:
			//   v13 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//   if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass, wrapperArray);
			//     v13 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//   }
			//   v13.static_fields.s_useBlackBox = v8 != 0;
			//   v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//   if ( TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_useScanLine )
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass, wrapperArray);
			//       v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//     }
			//     v19 = (Material *)v3[23][58];
			//     v20 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords;
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords, wrapperArray);
			//       v20 = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords;
			//     }
			//     static_fields = v20.static_fields;
			//     if ( !v19 )
			//       goto LABEL_63;
			//     UnityEngine::Material::EnableKeyword(v19, static_fields.s_UseScanLine, 0LL);
			//     if ( !m_hgScanLine )
			//       goto LABEL_63;
			//     monitor = m_hgScanLine[4].monitor;
			//     if ( !monitor )
			//       goto LABEL_63;
			//     v23 = (_OWORD *)sub_180040AD0(&v130, 10LL, monitor);
			//     v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     *((_OWORD *)v3 + 18) = *v23;
			//     wrapperArray = (int *)m_hgScanLine[5].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v24 = sub_1800023D0(10LL, wrapperArray);
			//     wrapperArray = (int *)&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_useScanLine;
			//     *((_BYTE *)wrapperArray + 2) = v24;
			//     v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//     if ( TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanLineUseMask )
			//     {
			//       wrapperArray = (int *)m_hgScanLine[6].klass;
			//       if ( !wrapperArray )
			//         goto LABEL_63;
			//       v25 = sub_18004EF00(10LL, wrapperArray);
			//       v29 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//       v30 = (Texture *)v25;
			//       if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass, v26);
			//         v29 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//       }
			//       v29.static_fields.s_scanlineMaskTex = v30;
			//       sub_1800054D0(
			//         (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaskTex,
			//         v26,
			//         v27,
			//         v28,
			//         v130,
			//         v131);
			//       wrapperArray = (int *)m_hgScanLine[6].monitor;
			//       if ( !wrapperArray )
			//         goto LABEL_63;
			//       v31 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//       LODWORD(v31.s_slDataPack.scanlineParams5.x) = sub_18004A780(10LL);
			//       wrapperArray = (int *)m_hgScanLine[6].monitor;
			//       if ( !wrapperArray )
			//         goto LABEL_63;
			//       v32 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//       LODWORD(v32.s_slDataPack.scanlineParams5.y) = (unsigned __int64)sub_18004A780(10LL) >> 32;
			//       wrapperArray = (int *)m_hgScanLine[7].klass;
			//       if ( !wrapperArray )
			//         goto LABEL_63;
			//       v33 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//       LODWORD(v33.s_slDataPack.scanlineParams5.z) = sub_18004A780(10LL);
			//       wrapperArray = (int *)m_hgScanLine[7].klass;
			//       if ( !wrapperArray )
			//         goto LABEL_63;
			//       v34 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//       LODWORD(v34.s_slDataPack.scanlineParams5.w) = (unsigned __int64)sub_18004A780(10LL) >> 32;
			//       v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//     }
			//     if ( !*((_DWORD *)v3 + 56) )
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v35 = m_hgScanLine[3].monitor;
			//     if ( !v35 )
			//       goto LABEL_63;
			//     v36 = (_OWORD *)sub_180040AD0(&v130, 10LL, v35);
			//     v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     *((_OWORD *)v3 + 12) = *v36;
			//     wrapperArray = (int *)m_hgScanLine[4].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v37 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v37.s_slDataPack.scanLineCenterPos.w = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[8].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v38 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v38.s_slDataPack.scanlineParams1.x = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[7].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v39 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v39.s_slDataPack.scanlineParams1.y = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[8].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v40 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v40.s_slDataPack.scanlineParams1.z = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[9].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v41 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v41.s_slDataPack.scanlineParams1.w = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[14].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v42 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v42.s_slDataPack.scanlineParams2.x = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[9].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v43 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v43.s_slDataPack.scanlineParams2.y = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[10].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v44 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v44.s_slDataPack.scanlineParams2.z = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[5].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v45 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v45.s_slDataPack.scanlineParams2.w = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[10].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v46 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v46.s_slDataPack.scanlineParams3.x = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[11].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v47 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v47.s_slDataPack.scanlineParams3.y = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[11].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v48 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v48.s_slDataPack.scanlineParams3.z = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[12].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v49 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v49.s_slDataPack.scanlineParams3.w = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[13].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v50 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v50.s_slDataPack.scanlineParams4.x = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[13].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v51 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v51.s_slDataPack.scanlineParams4.y = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[12].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v52 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v52.s_slDataPack.scanlineParams4.z = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[14].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v53 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v53.s_slDataPack.scanlineParams4.w = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[15].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v54 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v54.s_slDataPack.scanlineParams6.x = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[15].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v55 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v55.s_slDataPack.scanlineParams6.y = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[16].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v56 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v56.s_slDataPack.scanlineParams6.z = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[16].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v57 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v57.s_slDataPack.scanlineParams6.w = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[17].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v58 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v58.s_slDataPack.scanlineParams7.x = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[17].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v59 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v59.s_slDataPack.scanlineParams7.y = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[18].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v60 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v60.s_slDataPack.scanlineParams7.z = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[23].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v61 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v61.s_slDataPack.scanlineParams7.w = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[18].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v62 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v62.s_slDataPack.scanlineParams8.x = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[19].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v63 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v63.s_slDataPack.scanlineParams8.y = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[19].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v64 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v64.s_slDataPack.scanlineParams8.z = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[20].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v65 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v65.s_slDataPack.scanlineParams8.w = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[20].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v66 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v66.s_slDataPack.scanlineParams9.x = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[21].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v67 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v67.s_slDataPack.scanlineParams9.y = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[21].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v68 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v68.s_slDataPack.scanlineParams9.z = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[22].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v69 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v69.s_slDataPack.scanlineParams9.w = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[22].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v70 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v70.s_slDataPack.scanlineParams10.x = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[23].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v71 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v71.s_slDataPack.scanlineParams10.y = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[23].klass;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v72 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v72.s_slDataPack.scanlineParams10.z = sub_18003F9B0(10LL, wrapperArray);
			//     wrapperArray = (int *)m_hgScanLine[28].monitor;
			//     if ( !wrapperArray )
			//       goto LABEL_63;
			//     v73 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     v73.s_slDataPack.scanlineParams10.w = sub_18003F9B0(10LL, wrapperArray);
			//     klass = m_hgScanLine[27].klass;
			//     if ( !klass )
			//       goto LABEL_63;
			//     v75 = (_OWORD *)sub_180040AD0(&v130, 10LL, klass);
			//     v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     *((_OWORD *)v3 + 26) = *v75;
			//     v76 = m_hgScanLine[27].monitor;
			//     if ( !v76 )
			//       goto LABEL_63;
			//     v77 = (_OWORD *)sub_180040AD0(&v130, 10LL, v76);
			//     v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     *((_OWORD *)v3 + 27) = *v77;
			//     v78 = m_hgScanLine[28].klass;
			//     if ( !v78 )
			//       goto LABEL_63;
			//     v79 = (_OWORD *)sub_180040AD0(&v130, 10LL, v78);
			//     v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     *((_OWORD *)v3 + 28) = *v79;
			//     v80 = m_hgScanLine[26].klass;
			//     if ( !v80 )
			//       goto LABEL_63;
			//     v81 = (_OWORD *)sub_180040AD0(&v130, 10LL, v80);
			//     v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//     *((_OWORD *)v3 + 24) = *v81;
			//     v82 = m_hgScanLine[26].monitor;
			//     if ( !v82 )
			//       goto LABEL_63;
			//     TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineHighlightBeamTint = *(Color *)sub_180040AD0(&v130, 10LL, v82);
			//     ShouldRequestVerticalOcclusionMap = HG::Rendering::Runtime::VFXPPScanLinePass::ShouldRequestVerticalOcclusionMap(
			//                                           hgCamera,
			//                                           0LL);
			//     wrapperArray = (int *)&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_useScanLine;
			//     *((_BYTE *)wrapperArray + 3) = ShouldRequestVerticalOcclusionMap;
			//     v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//     if ( TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_shouldDrawScanlineHighlight )
			//     {
			//       if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//       {
			//         il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass, wrapperArray);
			//         v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//       }
			//       wrapperArray = (int *)m_hgScanLine[17].klass;
			//       if ( !wrapperArray )
			//         goto LABEL_63;
			//       v84 = (float *)v3[23];
			//       v84[122] = sub_18003F9B0(10LL, wrapperArray);
			//       wrapperArray = (int *)m_hgScanLine[17].monitor;
			//       if ( !wrapperArray )
			//         goto LABEL_63;
			//       v85 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//       v85.s_highlightDataPack.detectDistance.y = sub_18003F9B0(10LL, wrapperArray);
			//       wrapperArray = (int *)m_hgScanLine[18].klass;
			//       if ( !wrapperArray )
			//         goto LABEL_63;
			//       v86 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//       v86.s_highlightDataPack.detectDistance.z = sub_18003F9B0(10LL, wrapperArray);
			//       wrapperArray = (int *)m_hgScanLine[23].monitor;
			//       if ( !wrapperArray )
			//         goto LABEL_63;
			//       v87 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//       v87.s_highlightDataPack.detectDistance.w = sub_18003F9B0(10LL, wrapperArray);
			//       wrapperArray = (int *)m_hgScanLine[24].klass;
			//       if ( !wrapperArray )
			//         goto LABEL_63;
			//       v88 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//       v88.s_highlightDataPack.beamHeight.x = sub_18003F9B0(10LL, wrapperArray);
			//       wrapperArray = (int *)m_hgScanLine[24].monitor;
			//       if ( !wrapperArray )
			//         goto LABEL_63;
			//       v89 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//       v89.s_highlightDataPack.beamHeight.y = sub_18003F9B0(10LL, wrapperArray);
			//       wrapperArray = (int *)m_hgScanLine[25].klass;
			//       if ( !wrapperArray )
			//         goto LABEL_63;
			//       v90 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//       v90.s_highlightDataPack.beamHeight.z = sub_18003F9B0(10LL, wrapperArray);
			//       wrapperArray = (int *)m_hgScanLine[25].monitor;
			//       if ( !wrapperArray )
			//         goto LABEL_63;
			//       TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_highlightDataPack.meshHeight = sub_18003F9B0(10LL, wrapperArray);
			//       v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//     }
			//   }
			//   if ( !*((_DWORD *)v3 + 56) )
			//   {
			//     il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//   }
			//   if ( *((_BYTE *)v3[23] + 1) )
			//   {
			//     if ( !*((_DWORD *)v3 + 56) )
			//       il2cpp_runtime_class_init_0(v3, wrapperArray);
			//     if ( m_hgBlackBox )
			//     {
			//       v91 = m_hgBlackBox[4].monitor;
			//       if ( v91 )
			//       {
			//         v92 = (_OWORD *)sub_180040AD0(&v130, 10LL, v91);
			//         v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//         *((_OWORD *)v3 + 5) = *v92;
			//         v93 = m_hgBlackBox[6].monitor;
			//         if ( v93 )
			//         {
			//           v94 = (_OWORD *)sub_180040AD0(&v130, 10LL, v93);
			//           v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//           *((_OWORD *)v3 + 6) = *v94;
			//           v95 = m_hgBlackBox[4].klass;
			//           if ( v95 )
			//           {
			//             v96 = (_OWORD *)sub_180040AD0(&v130, 10LL, v95);
			//             v3 = (_QWORD **)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//             *((_OWORD *)v3 + 4) = *v96;
			//             wrapperArray = (int *)m_hgBlackBox[6].klass;
			//             v97 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//             if ( wrapperArray )
			//             {
			//               v98 = sub_18003F9B0(10LL, wrapperArray);
			//               wrapperArray = (int *)m_hgBlackBox[5].monitor;
			//               if ( wrapperArray )
			//               {
			//                 v97.s_slDataPack.blackBoxParams1.x = sub_18003F9B0(10LL, wrapperArray) * v98;
			//                 wrapperArray = (int *)m_hgBlackBox[5].klass;
			//                 if ( wrapperArray )
			//                 {
			//                   v99 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                   v99.s_slDataPack.blackBoxParams1.y = sub_18003F9B0(10LL, wrapperArray);
			//                   wrapperArray = (int *)m_hgBlackBox[8].klass;
			//                   v100 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                   if ( wrapperArray )
			//                   {
			//                     v101 = sub_18003F9B0(10LL, wrapperArray);
			//                     wrapperArray = (int *)m_hgBlackBox[7].monitor;
			//                     if ( wrapperArray )
			//                     {
			//                       v100.s_slDataPack.blackBoxParams1.z = sub_18003F9B0(10LL, wrapperArray) * v101;
			//                       wrapperArray = (int *)m_hgBlackBox[7].klass;
			//                       if ( wrapperArray )
			//                       {
			//                         v102 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                         v102.s_slDataPack.blackBoxParams1.w = sub_18003F9B0(10LL, wrapperArray);
			//                         wrapperArray = (int *)m_hgBlackBox[9].klass;
			//                         if ( wrapperArray )
			//                         {
			//                           v103 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                           LODWORD(v103.s_slDataPack.blackBoxParams2.x) = sub_18004A780(10LL);
			//                           wrapperArray = (int *)m_hgBlackBox[9].klass;
			//                           if ( wrapperArray )
			//                           {
			//                             v104 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                             LODWORD(v104.s_slDataPack.blackBoxParams2.y) = (unsigned __int64)sub_18004A780(10LL) >> 32;
			//                             wrapperArray = (int *)m_hgBlackBox[9].monitor;
			//                             if ( wrapperArray )
			//                             {
			//                               v105 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                               LODWORD(v105.s_slDataPack.blackBoxParams2.z) = sub_18004A780(10LL);
			//                               wrapperArray = (int *)m_hgBlackBox[9].monitor;
			//                               if ( wrapperArray )
			//                               {
			//                                 v106 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                                 LODWORD(v106.s_slDataPack.blackBoxParams2.w) = (unsigned __int64)sub_18004A780(10LL) >> 32;
			//                                 wrapperArray = (int *)m_hgBlackBox[10].klass;
			//                                 if ( wrapperArray )
			//                                 {
			//                                   v107 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                                   LODWORD(v107.s_slDataPack.blackBoxParams3.x) = sub_18004A780(10LL);
			//                                   wrapperArray = (int *)m_hgBlackBox[10].klass;
			//                                   if ( wrapperArray )
			//                                   {
			//                                     v108 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                                     LODWORD(v108.s_slDataPack.blackBoxParams3.y) = (unsigned __int64)sub_18004A780(10LL) >> 32;
			//                                     wrapperArray = (int *)m_hgBlackBox[10].monitor;
			//                                     if ( wrapperArray )
			//                                     {
			//                                       v109 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                                       LODWORD(v109.s_slDataPack.blackBoxParams3.z) = sub_18004A780(10LL);
			//                                       wrapperArray = (int *)m_hgBlackBox[10].monitor;
			//                                       if ( wrapperArray )
			//                                       {
			//                                         v110 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                                         LODWORD(v110.s_slDataPack.blackBoxParams3.w) = (unsigned __int64)sub_18004A780(10LL) >> 32;
			//                                         wrapperArray = (int *)m_hgBlackBox[11].monitor;
			//                                         if ( wrapperArray )
			//                                         {
			//                                           v111 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                                           LODWORD(v111.s_slDataPack.blackBoxParams4.x) = sub_18004A780(10LL);
			//                                           wrapperArray = (int *)m_hgBlackBox[11].monitor;
			//                                           if ( wrapperArray )
			//                                           {
			//                                             v112 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                                             LODWORD(v112.s_slDataPack.blackBoxParams4.y) = (unsigned __int64)sub_18004A780(10LL) >> 32;
			//                                             wrapperArray = (int *)m_hgBlackBox[12].klass;
			//                                             if ( wrapperArray )
			//                                             {
			//                                               v113 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                                               LODWORD(v113.s_slDataPack.blackBoxParams4.z) = sub_18004A780(10LL);
			//                                               wrapperArray = (int *)m_hgBlackBox[12].klass;
			//                                               if ( wrapperArray )
			//                                               {
			//                                                 v114 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                                                 LODWORD(v114.s_slDataPack.blackBoxParams4.w) = (unsigned __int64)sub_18004A780(10LL) >> 32;
			//                                                 wrapperArray = (int *)m_hgBlackBox[8].monitor;
			//                                                 if ( wrapperArray )
			//                                                 {
			//                                                   v115 = sub_18004EF00(10LL, wrapperArray);
			//                                                   v116 = (HGRenderPathBase_HGRenderPathResources *)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                                                   v116[30].defaultResources = (HGRenderPipelineRuntimeResources *)v115;
			//                                                   sub_1800054D0(
			//                                                     (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_blackBoxContourTex,
			//                                                     v116,
			//                                                     v117,
			//                                                     v118,
			//                                                     v130,
			//                                                     v131);
			//                                                   wrapperArray = (int *)m_hgBlackBox[12].monitor;
			//                                                   if ( wrapperArray )
			//                                                   {
			//                                                     v119 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                                                     v119.s_slDataPack.blackBoxParams5.x = (float)(unsigned __int8)sub_1800023D0(10LL, wrapperArray);
			//                                                     v121 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//                                                     if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//                                                     {
			//                                                       il2cpp_runtime_class_init_0(
			//                                                         TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass,
			//                                                         v120);
			//                                                       v121 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//                                                     }
			//                                                     wrapperArray = (int *)m_hgBlackBox[13].klass;
			//                                                     if ( wrapperArray )
			//                                                     {
			//                                                       v122 = v121.static_fields;
			//                                                       v122.s_slDataPack.blackBoxParams5.y = (float)(unsigned __int8)sub_1800023D0(10LL, wrapperArray);
			//                                                       v124 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//                                                       if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//                                                       {
			//                                                         il2cpp_runtime_class_init_0(
			//                                                           TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass,
			//                                                           v123);
			//                                                         v124 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//                                                       }
			//                                                       wrapperArray = (int *)m_hgBlackBox[13].monitor;
			//                                                       if ( wrapperArray )
			//                                                       {
			//                                                         v125 = v124.static_fields;
			//                                                         v125.s_slDataPack.blackBoxCenterPos.w = (float)(unsigned __int8)sub_1800023D0(10LL, wrapperArray);
			//                                                         v127 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//                                                         if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//                                                         {
			//                                                           il2cpp_runtime_class_init_0(
			//                                                             TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass,
			//                                                             v126);
			//                                                           v127 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//                                                         }
			//                                                         wrapperArray = (int *)m_hgBlackBox[11].klass;
			//                                                         if ( wrapperArray )
			//                                                         {
			//                                                           v128 = v127.static_fields;
			//                                                           LODWORD(v128.s_slDataPack.blackBoxParams5.z) = sub_18004A780(10LL);
			//                                                           wrapperArray = (int *)m_hgBlackBox[11].klass;
			//                                                           if ( wrapperArray )
			//                                                           {
			//                                                             v129 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                                                             LODWORD(v129.s_slDataPack.blackBoxParams5.w) = (unsigned __int64)sub_18004A780(10LL) >> 32;
			//                                                             return;
			//                                                           }
			//                                                         }
			//                                                       }
			//                                                     }
			//                                                   }
			//                                                 }
			//                                               }
			//                                             }
			//                                           }
			//                                         }
			//                                       }
			//                                     }
			//                                   }
			//                                 }
			//                               }
			//                             }
			//                           }
			//                         }
			//                       }
			//                     }
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_63:
			//     sub_180B536AC(v3, wrapperArray);
			//   }
			// }
			// 
		}

		public static void DrawScanLineMaterial(HGRenderGraphContext ctx, HGCamera hgCamera)
		{
			// // Void DrawScanLineMaterial(HGRenderGraphContext, HGCamera)
			// void HG::Rendering::Runtime::VFXPPScanLinePass::DrawScanLineMaterial(
			//         HGRenderGraphContext *ctx,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   Material *v5; // rbx
			//   _OWORD *p_s_useScanLine; // rcx
			//   void *static_fields; // rdx
			//   Material *s_scanlineMaterial; // rbx
			//   Material *v9; // rbx
			//   Material *v10; // rbx
			//   Material *v11; // rbx
			//   int32_t v12; // edx
			//   int32_t v13; // edx
			//   int32_t v14; // edx
			//   int32_t v15; // edx
			//   int32_t v16; // edx
			//   int32_t v17; // edx
			//   int32_t v18; // edx
			//   int32_t v19; // edx
			//   int32_t v20; // edx
			//   int32_t v21; // edx
			//   int32_t v22; // edx
			//   int32_t v23; // edx
			//   int32_t v24; // edx
			//   int32_t v25; // edx
			//   int32_t v26; // edx
			//   int32_t v27; // edx
			//   int32_t v28; // edx
			//   VFXPPScanLinePass__StaticFields *v29; // rax
			//   Vector4 boxPosition1; // xmm1
			//   __m128i v31; // xmm7
			//   VFXPPScanLinePass__StaticFields *v32; // rax
			//   Vector4 boxPosition2; // xmm1
			//   __m128i v34; // xmm8
			//   VFXPPScanLinePass__StaticFields *v35; // rax
			//   Vector4 boxPosition3; // xmm1
			//   __m128i v37; // xmm6
			//   int32_t v38; // edx
			//   int32_t v39; // edx
			//   int32_t v40; // edx
			//   Material *v41; // rbx
			//   Material *v42; // rbx
			//   Material *v43; // rbx
			//   int32_t v44; // edx
			//   int32_t v45; // edx
			//   int32_t v46; // edx
			//   int32_t v47; // edx
			//   int32_t v48; // edx
			//   int32_t v49; // edx
			//   int32_t v50; // edx
			//   int32_t v51; // edx
			//   CommandBuffer *cmd; // rdi
			//   Material *v53; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 scanLineCenterPos; // [rsp+38h] [rbp-9h] BYREF
			//   __m128i blackBoxContourColor; // [rsp+48h] [rbp+7h] BYREF
			//   Vector4 v57; // [rsp+58h] [rbp+17h] BYREF
			// 
			//   if ( !byte_18D919432 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     byte_18D919432 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(2132, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     HG::Rendering::Runtime::VFXPPScanLinePass::UpdateDataPack(hgCamera, 0LL);
			//     if ( TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_useScanLine )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//       s_scanlineMaterial = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//       if ( !s_scanlineMaterial )
			//         goto LABEL_55;
			//       UnityEngine::Material::EnableKeyword(s_scanlineMaterial, *((String **)static_fields + 38), 0LL);
			//       if ( TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanLineUseMask )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//         v10 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//         if ( !v10 )
			//           goto LABEL_55;
			//         UnityEngine::Material::EnableKeyword(v10, *((String **)static_fields + 40), 0LL);
			//       }
			//       else
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//         v9 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//         if ( !v9 )
			//           goto LABEL_55;
			//         UnityEngine::Material::DisableKeyword(v9, *((String **)static_fields + 40), 0LL);
			//       }
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//       v11 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       p_s_useScanLine = &TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_useScanLine;
			//       if ( !v11 )
			//         goto LABEL_55;
			//       v12 = *((_DWORD *)static_fields + 484);
			//       scanLineCenterPos = (Vector4)p_s_useScanLine[18];
			//       UnityEngine::Material::SetColor(v11, v12, (Color *)&scanLineCenterPos, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       UnityEngine::Material::SetTextureImpl(
			//         (Material *)p_s_useScanLine,
			//         *((_DWORD *)static_fields + 485),
			//         TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaskTex,
			//         0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v13 = *((_DWORD *)static_fields + 486);
			//       scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanLineCenterPos;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v13, &scanLineCenterPos, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v14 = *((_DWORD *)static_fields + 487);
			//       scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineParams1;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v14, &scanLineCenterPos, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v15 = *((_DWORD *)static_fields + 488);
			//       scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineParams2;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v15, &scanLineCenterPos, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v16 = *((_DWORD *)static_fields + 489);
			//       scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineParams3;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v16, &scanLineCenterPos, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v17 = *((_DWORD *)static_fields + 490);
			//       scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineParams4;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v17, &scanLineCenterPos, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v18 = *((_DWORD *)static_fields + 491);
			//       scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineParams5;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v18, &scanLineCenterPos, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v19 = *((_DWORD *)static_fields + 499);
			//       scanLineCenterPos = (Vector4)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineHighlightTint;
			//       UnityEngine::Material::SetColor((Material *)p_s_useScanLine, v19, (Color *)&scanLineCenterPos, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v20 = *((_DWORD *)static_fields + 500);
			//       scanLineCenterPos = (Vector4)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineHighlightBeamTint;
			//       UnityEngine::Material::SetColor((Material *)p_s_useScanLine, v20, (Color *)&scanLineCenterPos, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v21 = *((_DWORD *)static_fields + 492);
			//       scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineParams6;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v21, &scanLineCenterPos, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v22 = *((_DWORD *)static_fields + 493);
			//       scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineParams7;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v22, &scanLineCenterPos, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v23 = *((_DWORD *)static_fields + 494);
			//       scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineParams8;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v23, &scanLineCenterPos, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v24 = *((_DWORD *)static_fields + 495);
			//       scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineParams9;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v24, &scanLineCenterPos, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v25 = *((_DWORD *)static_fields + 496);
			//       scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineParams10;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v25, &scanLineCenterPos, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v26 = *((_DWORD *)static_fields + 501);
			//       scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.boxPosition1;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v26, &scanLineCenterPos, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v27 = *((_DWORD *)static_fields + 502);
			//       scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.boxPosition2;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v27, &scanLineCenterPos, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v28 = *((_DWORD *)static_fields + 503);
			//       scanLineCenterPos = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.boxPosition3;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v28, &scanLineCenterPos, 0LL);
			//       v29 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//       boxPosition1 = v29.s_slDataPack.boxPosition1;
			//       scanLineCenterPos = v29.s_slDataPack.scanLineCenterPos;
			//       blackBoxContourColor = (__m128i)boxPosition1;
			//       v31 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VFXPPScanLinePass::CalBoxVecNormalized(
			//                                                &v57,
			//                                                (Vector4 *)&blackBoxContourColor,
			//                                                &scanLineCenterPos,
			//                                                0LL));
			//       v32 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//       boxPosition2 = v32.s_slDataPack.boxPosition2;
			//       blackBoxContourColor = (__m128i)v32.s_slDataPack.scanLineCenterPos;
			//       scanLineCenterPos = boxPosition2;
			//       v34 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VFXPPScanLinePass::CalBoxVecNormalized(
			//                                                &v57,
			//                                                &scanLineCenterPos,
			//                                                (Vector4 *)&blackBoxContourColor,
			//                                                0LL));
			//       v35 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//       boxPosition3 = v35.s_slDataPack.boxPosition3;
			//       blackBoxContourColor = (__m128i)v35.s_slDataPack.scanLineCenterPos;
			//       scanLineCenterPos = boxPosition3;
			//       v37 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::VFXPPScanLinePass::CalBoxVecNormalized(
			//                                                &v57,
			//                                                &scanLineCenterPos,
			//                                                (Vector4 *)&blackBoxContourColor,
			//                                                0LL));
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v38 = *((_DWORD *)static_fields + 504);
			//       blackBoxContourColor = v31;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v38, (Vector4 *)&blackBoxContourColor, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v39 = *((_DWORD *)static_fields + 505);
			//       blackBoxContourColor = v34;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v39, (Vector4 *)&blackBoxContourColor, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v40 = *((_DWORD *)static_fields + 506);
			//       blackBoxContourColor = v37;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v40, (Vector4 *)&blackBoxContourColor, 0LL);
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//       v5 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//       if ( !v5 )
			//         goto LABEL_55;
			//       UnityEngine::Material::DisableKeyword(v5, *((String **)static_fields + 38), 0LL);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     if ( TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_useBlackBox )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//       v42 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//       if ( !v42 )
			//         goto LABEL_55;
			//       UnityEngine::Material::EnableKeyword(v42, *((String **)static_fields + 39), 0LL);
			//       v43 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       p_s_useScanLine = &TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_useScanLine;
			//       if ( !v43 )
			//         goto LABEL_55;
			//       v44 = *((_DWORD *)static_fields + 509);
			//       blackBoxContourColor = *((__m128i *)p_s_useScanLine + 5);
			//       UnityEngine::Material::SetColor(v43, v44, (Color *)&blackBoxContourColor, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v45 = *((_DWORD *)static_fields + 510);
			//       blackBoxContourColor = (__m128i)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.blackBoxContourColor;
			//       UnityEngine::Material::SetColor((Material *)p_s_useScanLine, v45, (Color *)&blackBoxContourColor, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v46 = *((_DWORD *)static_fields + 511);
			//       blackBoxContourColor = (__m128i)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.blackBoxCenterPos;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v46, (Vector4 *)&blackBoxContourColor, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v47 = *((_DWORD *)static_fields + 512);
			//       blackBoxContourColor = (__m128i)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.blackBoxParams1;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v47, (Vector4 *)&blackBoxContourColor, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v48 = *((_DWORD *)static_fields + 513);
			//       blackBoxContourColor = (__m128i)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.blackBoxParams2;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v48, (Vector4 *)&blackBoxContourColor, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v49 = *((_DWORD *)static_fields + 514);
			//       blackBoxContourColor = (__m128i)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.blackBoxParams3;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v49, (Vector4 *)&blackBoxContourColor, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v50 = *((_DWORD *)static_fields + 515);
			//       blackBoxContourColor = (__m128i)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.blackBoxParams4;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v50, (Vector4 *)&blackBoxContourColor, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       v51 = *((_DWORD *)static_fields + 516);
			//       blackBoxContourColor = (__m128i)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.blackBoxParams5;
			//       UnityEngine::Material::SetVector((Material *)p_s_useScanLine, v51, (Vector4 *)&blackBoxContourColor, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//       if ( !p_s_useScanLine )
			//         goto LABEL_55;
			//       UnityEngine::Material::SetTextureImpl(
			//         (Material *)p_s_useScanLine,
			//         *((_DWORD *)static_fields + 517),
			//         TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_blackBoxContourTex,
			//         0LL);
			//     }
			//     else
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//       v41 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords);
			//       static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderKeyWords.static_fields;
			//       if ( !v41 )
			//         goto LABEL_55;
			//       UnityEngine::Material::DisableKeyword(v41, *((String **)static_fields + 39), 0LL);
			//     }
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//     if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_useScanLine )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//       if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_useBlackBox )
			//         goto LABEL_53;
			//     }
			//     if ( ctx )
			//     {
			//       cmd = ctx.fields.cmd;
			//       sub_180002C70(p_s_useScanLine);
			//       v53 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_scanlineMaterial;
			//       sub_180002C70(TypeInfo::UnityEngine::Rendering::CoreUtils);
			//       UnityEngine::Rendering::CoreUtils::DrawFullScreen(cmd, v53, 0LL, 0, 0LL);
			//       p_s_useScanLine = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			// LABEL_53:
			//       sub_180002C70(p_s_useScanLine);
			//       HG::Rendering::Runtime::VFXPPScanLinePass::DrawScanlineHighlight(ctx, 0LL);
			//       return;
			//     }
			// LABEL_55:
			//     sub_180B536AC(p_s_useScanLine, static_fields);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(2132, 0LL);
			//   if ( !Patch )
			//     goto LABEL_55;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)ctx,
			//     (Object *)hgCamera,
			//     0LL);
			// }
			// 
		}

		public static void DrawScanlineHighlight(HGRenderGraphContext ctx)
		{
			// // Void DrawScanlineHighlight(HGRenderGraphContext)
			// void HG::Rendering::Runtime::VFXPPScanLinePass::DrawScanlineHighlight(HGRenderGraphContext *ctx, MethodInfo *method)
			// {
			//   MaterialPropertyBlock *s_materialPropertyBlock; // rbx
			//   HGShaderIDs__StaticFields *static_fields; // rdx
			//   MaterialPropertyBlock *v5; // rcx
			//   int32_t ScanLineHighlightBeamTint; // edx
			//   int32_t ScanLineParams1; // edx
			//   int32_t ScanLineParams8; // edx
			//   int32_t ScanLineParams9; // edx
			//   int32_t ScanLineParams10; // edx
			//   int32_t ScanLineCenterPos; // edx
			//   VFXPPScanLinePass__StaticFields *v12; // rax
			//   __int128 v13; // xmm1
			//   Vector4 v14; // xmm0
			//   Vector4 v15; // xmm1
			//   Vector4 boxPosition1; // xmm0
			//   VFXPPScanLinePass__StaticFields *v17; // rax
			//   __int128 v18; // xmm1
			//   Vector4 v19; // xmm0
			//   Vector4 v20; // xmm1
			//   Vector4 boxPosition2; // xmm0
			//   VFXPPScanLinePass__StaticFields *v22; // rax
			//   __int128 v23; // xmm1
			//   Vector4 v24; // xmm0
			//   Vector4 v25; // xmm1
			//   Vector4 boxPosition3; // xmm0
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v28; // [rsp+30h] [rbp-50h] BYREF
			//   Vector4 v29; // [rsp+40h] [rbp-40h] BYREF
			//   Vector4 v30; // [rsp+50h] [rbp-30h] BYREF
			//   HighlightDataPack v31; // [rsp+60h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D919433 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     byte_18D919433 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2133, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2133, 0LL);
			//     if ( !Patch )
			//       goto LABEL_14;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)ctx, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     if ( TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_useScanLine )
			//     {
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//       if ( TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_shouldDrawScanlineHighlight )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//         s_materialPropertyBlock = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_materialPropertyBlock;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         v5 = (MaterialPropertyBlock *)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//         if ( s_materialPropertyBlock )
			//         {
			//           ScanLineHighlightBeamTint = static_fields._ScanLineHighlightBeamTint;
			//           v28 = *(Vector4 *)&v5[16].fields.m_Ptr;
			//           UnityEngine::MaterialPropertyBlock::SetColor(
			//             s_materialPropertyBlock,
			//             ScanLineHighlightBeamTint,
			//             (Color *)&v28,
			//             0LL);
			//           v5 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_materialPropertyBlock;
			//           static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//           if ( v5 )
			//           {
			//             ScanLineParams1 = static_fields._ScanLineParams1;
			//             v28 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineParams1;
			//             UnityEngine::MaterialPropertyBlock::SetVector(v5, ScanLineParams1, &v28, 0LL);
			//             v5 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_materialPropertyBlock;
			//             static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//             if ( v5 )
			//             {
			//               ScanLineParams8 = static_fields._ScanLineParams8;
			//               v28 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineParams8;
			//               UnityEngine::MaterialPropertyBlock::SetVector(v5, ScanLineParams8, &v28, 0LL);
			//               v5 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_materialPropertyBlock;
			//               static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//               if ( v5 )
			//               {
			//                 ScanLineParams9 = static_fields._ScanLineParams9;
			//                 v28 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineParams9;
			//                 UnityEngine::MaterialPropertyBlock::SetVector(v5, ScanLineParams9, &v28, 0LL);
			//                 v5 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_materialPropertyBlock;
			//                 static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                 if ( v5 )
			//                 {
			//                   ScanLineParams10 = static_fields._ScanLineParams10;
			//                   v28 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanlineParams10;
			//                   UnityEngine::MaterialPropertyBlock::SetVector(v5, ScanLineParams10, &v28, 0LL);
			//                   v5 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_materialPropertyBlock;
			//                   static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                   if ( v5 )
			//                   {
			//                     ScanLineCenterPos = static_fields._ScanLineCenterPos;
			//                     v28 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_slDataPack.scanLineCenterPos;
			//                     UnityEngine::MaterialPropertyBlock::SetVector(v5, ScanLineCenterPos, &v28, 0LL);
			//                     v12 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                     v13 = *(_OWORD *)&v12.s_highlightDataPack.beamHeight.x;
			//                     v31.detectDistance = v12.s_highlightDataPack.detectDistance;
			//                     v14 = v12.s_slDataPack.scanlineParams1;
			//                     *(_OWORD *)&v31.beamHeight.x = v13;
			//                     v15 = v12.s_slDataPack.scanLineCenterPos;
			//                     v28 = v14;
			//                     boxPosition1 = v12.s_slDataPack.boxPosition1;
			//                     v29 = v15;
			//                     v30 = boxPosition1;
			//                     HG::Rendering::Runtime::VFXPPScanLinePass::Draw(&v30, &v29, &v28, &v31, ctx, 0LL);
			//                     v17 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                     v18 = *(_OWORD *)&v17.s_highlightDataPack.beamHeight.x;
			//                     v31.detectDistance = v17.s_highlightDataPack.detectDistance;
			//                     v19 = v17.s_slDataPack.scanlineParams1;
			//                     *(_OWORD *)&v31.beamHeight.x = v18;
			//                     v20 = v17.s_slDataPack.scanLineCenterPos;
			//                     v30 = v19;
			//                     boxPosition2 = v17.s_slDataPack.boxPosition2;
			//                     v29 = v20;
			//                     v28 = boxPosition2;
			//                     HG::Rendering::Runtime::VFXPPScanLinePass::Draw(&v28, &v29, &v30, &v31, ctx, 0LL);
			//                     v22 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields;
			//                     v23 = *(_OWORD *)&v22.s_highlightDataPack.beamHeight.x;
			//                     v31.detectDistance = v22.s_highlightDataPack.detectDistance;
			//                     v24 = v22.s_slDataPack.scanlineParams1;
			//                     *(_OWORD *)&v31.beamHeight.x = v23;
			//                     v25 = v22.s_slDataPack.scanLineCenterPos;
			//                     v30 = v24;
			//                     boxPosition3 = v22.s_slDataPack.boxPosition3;
			//                     v29 = v25;
			//                     v28 = boxPosition3;
			//                     HG::Rendering::Runtime::VFXPPScanLinePass::Draw(&v28, &v29, &v30, &v31, ctx, 0LL);
			//                     return;
			//                   }
			//                 }
			//               }
			//             }
			//           }
			//         }
			// LABEL_14:
			//         sub_180B536AC(v5, static_fields);
			//       }
			//     }
			//   }
			// }
			// 
		}

		public static bool CheckRuntimeResources()
		{
			// // Boolean CheckRuntimeResources()
			// bool HG::Rendering::Runtime::VFXPPScanLinePass::CheckRuntimeResources(MethodInfo *method)
			// {
			//   Object_1 *s_HighlightMesh; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			// 
			//   if ( !byte_18D919434 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     byte_18D919434 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(2134, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(2134, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_3((ILFixDynamicMethodWrapper_24 *)Patch, 0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     s_HighlightMesh = (Object_1 *)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_HighlightMesh;
			//     sub_180002C70(TypeInfo::UnityEngine::Object);
			//     LOBYTE(s_HighlightMesh) = UnityEngine::Object::op_Inequality(0LL, s_HighlightMesh, 0LL);
			//     return (unsigned __int8)s_HighlightMesh & UnityEngine::Object::op_Inequality(
			//                                                 0LL,
			//                                                 (Object_1 *)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_HighlightMat,
			//                                                 0LL);
			//   }
			// }
			// 
			return default(bool);
		}

		public static void Release()
		{
			// // Void Release()
			// void HG::Rendering::Runtime::VFXPPScanLinePass::Release(MethodInfo *method)
			// {
			//   __int64 v1; // rdx
			//   struct VFXPPScanLinePass__Class *v2; // rax
			//   MaterialPropertyBlock *s_materialPropertyBlock; // rcx
			//   __int64 v4; // rdx
			//   Object_1 *s_HighlightMat; // rbx
			//   HGRenderPathBase_HGRenderPathResources *v6; // rdx
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v10; // [rsp+50h] [rbp+28h]
			//   MethodInfo *v11; // [rsp+58h] [rbp+30h]
			// 
			//   if ( !byte_18D8ED9A2 )
			//   {
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::CoreUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass);
			//     byte_18D8ED9A2 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(498, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(498, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_9((ILFixDynamicMethodWrapper_28 *)Patch, 0LL);
			//       return;
			//     }
			// LABEL_10:
			//     sub_180B536AC(s_materialPropertyBlock, v1);
			//   }
			//   v2 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//   if ( !TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass, v1);
			//     v2 = TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass;
			//   }
			//   s_materialPropertyBlock = v2.static_fields.s_materialPropertyBlock;
			//   if ( !s_materialPropertyBlock )
			//     goto LABEL_10;
			//   UnityEngine::MaterialPropertyBlock::Clear(s_materialPropertyBlock, 1, 0LL);
			//   s_HighlightMat = (Object_1 *)TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_HighlightMat;
			//   if ( !TypeInfo::UnityEngine::Rendering::CoreUtils._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Rendering::CoreUtils, v4);
			//   UnityEngine::Rendering::CoreUtils::Destroy(s_HighlightMat, 0LL);
			//   TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_HighlightMat = 0LL;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&TypeInfo::HG::Rendering::Runtime::VFXPPScanLinePass.static_fields.s_HighlightMat,
			//     v6,
			//     v7,
			//     v8,
			//     v10,
			//     v11);
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static bool s_useScanLine;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x01")]
		private static bool s_useBlackBox;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x02")]
		private static bool s_scanLineUseMask;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x03")]
		private static bool s_shouldDrawScanlineHighlight;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static VFXPPScanLinePassInput s_vfxPPScanLinePassInput;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x40")]
		private static ScanLineDataPack s_slDataPack;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1D0")]
		private static Material s_scanlineMaterial;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1D8")]
		private static Texture s_scanlineMaskTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1E0")]
		private static Texture s_blackBoxContourTex;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x1E8")]
		private static HighlightDataPack s_highlightDataPack;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x208")]
		private static Mesh s_HighlightMesh;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x210")]
		private static Shader s_HighlightShader;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x218")]
		private static Material s_HighlightMat;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x220")]
		private static MaterialPropertyBlock s_materialPropertyBlock;
	}
}
