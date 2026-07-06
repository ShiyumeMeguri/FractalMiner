using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.HyperGryphEngineCode;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGVolumetricFogRenderer
	{
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x000025D8 File Offset: 0x000007D8
		public static bool supportVolumetricFog
		{
			get
			{
				// // Boolean get_supportVolumetricFog()
				// bool HG::Rendering::Runtime::HGVolumetricFogRenderer::get_supportVolumetricFog(MethodInfo *method)
				// {
				//   HGRenderPipelineSettingHub *instance; // rax
				//   __int64 v2; // rdx
				//   __int64 v3; // rcx
				//   HGRenderPipelineSettingHub_HGRenderPipelineSettings *m_impl; // rax
				// 
				//   instance = HG::Rendering::Runtime::HGRenderPipelineSettingHub::get_instance(0LL);
				//   if ( !instance || (m_impl = instance.fields.m_impl) == 0LL )
				//     sub_180B536AC(v3, v2);
				//   return m_impl.fields._currentDeviceType_k__BackingField != 1;
				// }
				// 
				return default(bool);
			}
		}

		public HGVolumetricFogRenderer()
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

		public static Vector3Int GetVolumetricFogGridSize(Vector2Int viewRectSize, out Vector2Int volumetricFogGridToPixel)
		{
			// // Vector3Int GetVolumetricFogGridSize(Vector2Int, Vector2Int ByRef)
			// Vector3Int *HG::Rendering::Runtime::HGVolumetricFogRenderer::GetVolumetricFogGridSize(
			//         Vector3Int *__return_ptr retstr,
			//         Vector2Int viewRectSize,
			//         Vector2Int *volumetricFogGridToPixel,
			//         MethodInfo *method)
			// {
			//   HGVolumetricFogRenderer__StaticFields *static_fields; // rdx
			//   HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *s_settingParameters; // rcx
			//   Vector2Int maxSourceRTSize; // rdi
			//   Int32Enum__Enum v10; // eax
			//   Vector2Int v11; // rax
			//   unsigned __int64 v12; // rdi
			//   Int32Enum__Enum v13; // eax
			//   int32_t v14; // ebp
			//   unsigned __int64 v15; // rcx
			//   unsigned __int64 v16; // rax
			//   Vector2Int v17; // kr00_8
			//   Int32Enum__Enum m_Z; // eax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3Int *v20; // rax
			//   __int64 v21; // xmm0_8
			//   Vector3Int v23[3]; // [rsp+30h] [rbp-28h] BYREF
			//   Vector2Int divisora; // [rsp+60h] [rbp+8h]
			//   Vector2Int divisor; // [rsp+60h] [rbp+8h]
			// 
			//   if ( !byte_18D919D91 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     byte_18D919D91 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1278, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1278, 0LL);
			//     if ( Patch )
			//     {
			//       v20 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_490(v23, Patch, viewRectSize, volumetricFogGridToPixel, 0LL);
			//       v21 = *(_QWORD *)&v20.m_X;
			//       m_Z = v20.m_Z;
			//       *(_QWORD *)&retstr.m_X = v21;
			//       goto LABEL_17;
			//     }
			// LABEL_15:
			//     sub_180B536AC(s_settingParameters, static_fields);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//   s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//   if ( !s_settingParameters )
			//     goto LABEL_15;
			//   maxSourceRTSize = HG::Rendering::Runtime::HGVolumetricFogRenderer::HGVolumetricFogSettingParameters::get_maxSourceRTSize(
			//                       s_settingParameters,
			//                       0LL);
			//   s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//   if ( !s_settingParameters )
			//     goto LABEL_15;
			//   v10 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//           (SettingParameter_1_System_Int32Enum_ *)s_settingParameters.fields.gridPixelSize,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   v11 = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(maxSourceRTSize, v10, 0LL);
			//   v12 = (unsigned __int64)HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(viewRectSize, v11, 0LL);
			//   s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//   if ( !s_settingParameters )
			//     goto LABEL_15;
			//   v13 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//           (SettingParameter_1_System_Int32Enum_ *)s_settingParameters.fields.gridPixelSize,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   v14 = v13;
			//   static_fields = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields;
			//   s_settingParameters = static_fields.s_settingParameters;
			//   if ( !static_fields.s_settingParameters )
			//     goto LABEL_15;
			//   divisora.m_X = v13;
			//   divisora.m_Y = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                    (SettingParameter_1_System_Int32Enum_ *)s_settingParameters.fields.gridPixelSize,
			//                    MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   v15 = HIDWORD(v12);
			//   v16 = HIDWORD(*(unsigned __int64 *)&divisora);
			//   if ( (int)v12 <= v14 )
			//     LODWORD(v12) = v14;
			//   divisor.m_X = v12;
			//   if ( (int)v15 <= (int)v16 )
			//     LODWORD(v15) = v16;
			//   divisor.m_Y = v15;
			//   *volumetricFogGridToPixel = divisor;
			//   v17 = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(viewRectSize, divisor, 0LL);
			//   s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//   if ( !s_settingParameters )
			//     goto LABEL_15;
			//   m_Z = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//           (SettingParameter_1_System_Int32Enum_ *)s_settingParameters.fields.gridSizeZ,
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   *(Vector2Int *)&retstr.m_X = v17;
			// LABEL_17:
			//   retstr.m_Z = m_Z;
			//   return retstr;
			// }
			// 
			return null;
		}

		private int _GetVolumetricFogZSliceFromDepth(float sceneDepth, Vector3 gridZParams)
		{
			// // Int32 _GetVolumetricFogZSliceFromDepth(Single, Vector3)
			// int32_t HG::Rendering::Runtime::HGVolumetricFogRenderer::_GetVolumetricFogZSliceFromDepth(
			//         HGVolumetricFogRenderer *this,
			//         float sceneDepth,
			//         Vector3 *gridZParams,
			//         MethodInfo *method)
			// {
			//   double v6; // xmm0_8
			//   float v7; // xmm6_4
			//   __int64 v9; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   float z; // eax
			//   Vector3 v12; // [rsp+30h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D919D92 )
			//   {
			//     sub_18003C530(&TypeInfo::System::MathF);
			//     byte_18D919D92 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1283, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1283, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v9);
			//     z = gridZParams.z;
			//     *(_QWORD *)&v12.x = *(_QWORD *)&gridZParams.x;
			//     v12.z = z;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_491(Patch, (Object *)this, sceneDepth, &v12, 0LL);
			//   }
			//   else
			//   {
			//     v6 = sub_184D3C428();
			//     v7 = *(float *)&v6;
			//     sub_180002C70(TypeInfo::System::MathF);
			//     return (int)System::MathF::Truncate(v7 * gridZParams.z, 0LL);
			//   }
			// }
			// 
			return 0;
		}

		public static Vector3 GetVolumetricFogGridZParams(float volumetricFogStartDistance, float nearPlane, float farPlane, int gridSizeZ)
		{
			// // Vector3 GetVolumetricFogGridZParams(Single, Single, Single, Int32)
			// Vector3 *HG::Rendering::Runtime::HGVolumetricFogRenderer::GetVolumetricFogGridZParams(
			//         Vector3 *__return_ptr retstr,
			//         float volumetricFogStartDistance,
			//         float nearPlane,
			//         float farPlane,
			//         int32_t gridSizeZ,
			//         MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rdx
			//   HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *s_settingParameters; // rcx
			//   float v9; // xmm7_4
			//   float v10; // xmm6_4
			//   float v11; // xmm0_4
			//   float v12; // xmm1_4
			//   Vector3 *v13; // rax
			//   __int64 v14; // xmm0_8
			//   Vector3 v16[4]; // [rsp+40h] [rbp-58h] BYREF
			// 
			//   if ( !byte_18D919D93 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     byte_18D919D93 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1284, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1284, 0LL);
			//     if ( Patch )
			//     {
			//       v13 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_492(
			//               v16,
			//               Patch,
			//               volumetricFogStartDistance,
			//               nearPlane,
			//               farPlane,
			//               gridSizeZ,
			//               0LL);
			//       v14 = *(_QWORD *)&v13.x;
			//       *(float *)&v13 = v13.z;
			//       *(_QWORD *)&retstr.x = v14;
			//       LODWORD(retstr.z) = (_DWORD)v13;
			//       return retstr;
			//     }
			// LABEL_7:
			//     sub_180B536AC(s_settingParameters, Patch);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//   s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//   if ( !s_settingParameters )
			//     goto LABEL_7;
			//   v9 = fmaxf(nearPlane, volumetricFogStartDistance) + 0.094999999;
			//   v10 = (float)(int)HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                       (SettingParameter_1_System_Int32Enum_ *)s_settingParameters.fields.depthDistributionScale,
			//                       MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   v11 = sub_184D309D8();
			//   retstr.z = v10;
			//   v12 = (float)(farPlane - (float)(v11 * v9)) / (float)(farPlane - v9);
			//   retstr.y = v12;
			//   retstr.x = (float)(1.0 - v12) / v9;
			//   return retstr;
			// }
			// 
			return null;
		}

		private Vector2 _GetVolumetricFogGridToScreenSVPosRatio(Vector2Int viewRectSize, Vector3Int volumetricFogGridSize, Vector2 volumetricFogGridToPixel)
		{
			// // Vector2 _GetVolumetricFogGridToScreenSVPosRatio(Vector2Int, Vector3Int, Vector2)
			// Vector2 HG::Rendering::Runtime::HGVolumetricFogRenderer::_GetVolumetricFogGridToScreenSVPosRatio(
			//         HGVolumetricFogRenderer *this,
			//         Vector2Int viewRectSize,
			//         Vector3Int *volumetricFogGridSize,
			//         Vector2 volumetricFogGridToPixel,
			//         MethodInfo *method)
			// {
			//   MethodInfo *v9; // rdx
			//   __m128 v10; // xmm1
			//   __m128 v11; // xmm2
			//   __int64 v13; // rdx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rcx
			//   int32_t m_Z; // eax
			//   __int64 v16; // [rsp+30h] [rbp-38h]
			//   Vector3Int v17; // [rsp+40h] [rbp-28h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1285, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1285, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(0LL, v13);
			//     m_Z = volumetricFogGridSize.m_Z;
			//     *(_QWORD *)&v17.m_X = *(_QWORD *)&volumetricFogGridSize.m_X;
			//     v17.m_Z = m_Z;
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_493(
			//              Patch,
			//              (Object *)this,
			//              viewRectSize,
			//              &v17,
			//              volumetricFogGridToPixel,
			//              0LL);
			//   }
			//   else
			//   {
			//     v16 = ((__int64 (__fastcall *)(_QWORD, _QWORD))sub_184D038DC)(
			//             _mm_unpacklo_ps(
			//               (__m128)COERCE_UNSIGNED_INT((float)volumetricFogGridSize.m_X),
			//               (__m128)COERCE_UNSIGNED_INT((float)volumetricFogGridSize.m_Y)).m128_u64[0],
			//             volumetricFogGridToPixel);
			//     v10 = (__m128)HIDWORD(v16);
			//     v11 = (__m128)(unsigned int)v16;
			//     *(Vector2 *)&v17.m_X = UnityEngine::Vector2Int::op_Implicit(viewRectSize, v9);
			//     v10.m128_f32[0] = *((float *)&v16 + 1) / *(float *)&v17.m_Y;
			//     v11.m128_f32[0] = *(float *)&v16 / *(float *)&v17.m_X;
			//     return (Vector2)_mm_unpacklo_ps(v11, v10).m128_u64[0];
			//   }
			// }
			// 
			return null;
		}

		public static Vector3 VolumetricFogTemporalRandom(int frameNumber)
		{
			// // Vector3 VolumetricFogTemporalRandom(Int32)
			// Vector3 *HG::Rendering::Runtime::HGVolumetricFogRenderer::VolumetricFogTemporalRandom(
			//         Vector3 *__return_ptr retstr,
			//         int32_t frameNumber,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *s_settingParameters; // rcx
			//   MethodInfo *v7; // r8
			//   Vector3 *v8; // rax
			//   int32_t v9; // edi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v11; // xmm0_8
			//   float z; // eax
			//   __m128i v14; // [rsp+20h] [rbp-20h] BYREF
			//   __m128i si128; // [rsp+30h] [rbp-10h] BYREF
			// 
			//   if ( !byte_18D919D94 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D919D94 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1286, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1286, 0LL);
			//     if ( Patch )
			//     {
			//       v8 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_494((Vector3 *)&v14, Patch, frameNumber, 0LL);
			//       goto LABEL_12;
			//     }
			// LABEL_10:
			//     sub_180B536AC(s_settingParameters, v5);
			//   }
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//   s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//   if ( !s_settingParameters )
			//     goto LABEL_10;
			//   if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//          s_settingParameters.fields.enableTemporalReprojection,
			//          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//   {
			//     v9 = frameNumber & 0x3FF;
			//     v14.m128i_i32[0] = UnityEngine::Rendering::HaltonSequence::Get(v9, 2, 0LL);
			//     v14.m128i_i32[1] = UnityEngine::Rendering::HaltonSequence::Get(v9, 3, 0LL);
			//     v14.m128i_i64[1] = COERCE_UNSIGNED_INT(UnityEngine::Rendering::HaltonSequence::Get(v9, 5, 0LL));
			//     si128 = v14;
			//   }
			//   else
			//   {
			//     si128 = _mm_load_si128((const __m128i *)&xmmword_18C370DF0);
			//   }
			//   v8 = UnityEngine::Vector4::op_Implicit((Vector3 *)&v14, (Vector4 *)&si128, v7);
			// LABEL_12:
			//   v11 = *(_QWORD *)&v8.x;
			//   z = v8.z;
			//   *(_QWORD *)&retstr.x = v11;
			//   retstr.z = z;
			//   return retstr;
			// }
			// 
			return null;
		}

		public void SetupShaderVariablesGlobalVolumetricFog(ref ShaderVariablesGlobal cb, HGCamera hgCamera)
		{
			// // Void SetupShaderVariablesGlobalVolumetricFog(ShaderVariablesGlobal ByRef, HGCamera)
			// void HG::Rendering::Runtime::HGVolumetricFogRenderer::SetupShaderVariablesGlobalVolumetricFog(
			//         HGVolumetricFogRenderer *this,
			//         ShaderVariablesGlobal *cb,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   __int64 v7; // rdx
			//   void *camera; // rcx
			//   HGEnvironmentPhase *InterpolatedPhase; // rsi
			//   Vector2Int sceneRTSize_k__BackingField; // rbx
			//   Vector3Int *VolumetricFogGridSize; // rax
			//   float volumetricFogStartDistance; // xmm6_4
			//   __int64 v13; // xmm7_8
			//   float v14; // ebx
			//   float v15; // xmm0_4
			//   Vector3 *VolumetricFogGridZParams; // rax
			//   __int64 v17; // xmm11_8
			//   float z; // r15d
			//   MethodInfo *v19; // rdx
			//   MethodInfo *v20; // r8
			//   __m128 v21; // xmm9
			//   __m128 v22; // xmm10
			//   float volumetricFogNearFadeInDistance; // xmm0_4
			//   float v24; // xmm8_4
			//   Vector3 *v25; // rax
			//   float volumetricFogDistance; // xmm7_4
			//   __int64 v27; // xmm6_8
			//   float v28; // ebx
			//   Vector4 *v29; // rax
			//   Vector4 *v30; // rax
			//   Vector2Int v31; // rcx
			//   MethodInfo *v32; // rdx
			//   Vector2 v33; // rax
			//   Animator *v34; // rdx
			//   int32_t v35; // r8d
			//   MethodInfo *v36; // r9
			//   Vector3 *Vector; // rax
			//   __int64 v38; // xmm6_8
			//   float v39; // ebx
			//   float v40; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector3 v42; // [rsp+38h] [rbp-49h] BYREF
			//   Vector3 v; // [rsp+48h] [rbp-39h] BYREF
			//   Vector4 v44[7]; // [rsp+58h] [rbp-29h] BYREF
			// 
			//   if ( !byte_18D919D95 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     byte_18D919D95 = 1;
			//   }
			//   *(_QWORD *)&v.x = 0LL;
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1287, 0LL) )
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			//     if ( InterpolatedPhase )
			//     {
			//       if ( hgCamera )
			//       {
			//         sceneRTSize_k__BackingField = hgCamera.fields._sceneRTSize_k__BackingField;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//         VolumetricFogGridSize = HG::Rendering::Runtime::HGVolumetricFogRenderer::GetVolumetricFogGridSize(
			//                                   (Vector3Int *)&v42,
			//                                   sceneRTSize_k__BackingField,
			//                                   (Vector2Int *)&v,
			//                                   0LL);
			//         camera = hgCamera.fields.camera;
			//         volumetricFogStartDistance = InterpolatedPhase.fields.volumetricFogConfig.volumetricFogStartDistance;
			//         v13 = *(_QWORD *)&VolumetricFogGridSize.m_X;
			//         v14 = *(float *)&VolumetricFogGridSize.m_Z;
			//         if ( camera )
			//         {
			//           v15 = UnityEngine::Camera::get_nearClipPlane((Camera *)camera, 0LL);
			//           VolumetricFogGridZParams = HG::Rendering::Runtime::HGVolumetricFogRenderer::GetVolumetricFogGridZParams(
			//                                        &v42,
			//                                        volumetricFogStartDistance,
			//                                        v15,
			//                                        InterpolatedPhase.fields.volumetricFogConfig.volumetricFogDistance,
			//                                        SLODWORD(v14),
			//                                        0LL);
			//           v17 = *(_QWORD *)&VolumetricFogGridZParams.x;
			//           z = VolumetricFogGridZParams.z;
			//           *(Vector2 *)&v42.x = UnityEngine::Vector2Int::op_Implicit(hgCamera.fields._sceneRTSize_k__BackingField, v19);
			//           v21 = (__m128)0x3F800000u;
			//           v21.m128_f32[0] = 1.0 / v42.x;
			//           v22 = (__m128)0x3F800000u;
			//           v22.m128_f32[0] = 1.0 / v42.y;
			//           volumetricFogNearFadeInDistance = InterpolatedPhase.fields.volumetricFogConfig.volumetricFogNearFadeInDistance;
			//           v24 = volumetricFogNearFadeInDistance <= 0.0 ? 1000000.0 : 1.0 / volumetricFogNearFadeInDistance;
			//           *(_QWORD *)&v42.x = v13;
			//           v42.z = v14;
			//           v25 = UnityEngine::Vector3Int::op_Implicit((Vector3 *)v44, (Vector3Int *)&v42, v20);
			//           volumetricFogDistance = InterpolatedPhase.fields.volumetricFogConfig.volumetricFogDistance;
			//           v27 = *(_QWORD *)&v25.x;
			//           v28 = v25.z;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//           *(_QWORD *)&v42.x = v27;
			//           v42.z = v28;
			//           v29 = HG::Rendering::Runtime::HGUtils::PackVector4(v44, &v42, volumetricFogDistance, 0LL);
			//           *(_QWORD *)&v42.x = v17;
			//           v42.z = z;
			//           *(__m128i *)&cb._CharacterParams13.w = _mm_loadu_si128((const __m128i *)v29);
			//           v30 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                   v44,
			//                   &v42,
			//                   InterpolatedPhase.fields.volumetricFogConfig.volumetricFogScatteringDistribution,
			//                   0LL);
			//           v31 = *(Vector2Int *)&v.x;
			//           *(__m128i *)&cb._CharacterParams14.w = _mm_loadu_si128((const __m128i *)v30);
			//           v33 = UnityEngine::Vector2Int::op_Implicit(v31, v32);
			//           *(__m128i *)&cb._CharacterParams15.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                                                      v44,
			//                                                                                      (Vector2)*(_OWORD *)&_mm_unpacklo_ps(v21, v22),
			//                                                                                      v33,
			//                                                                                      0LL));
			//           *(__m128i *)&cb._CharacterParams16.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                                                      v44,
			//                                                                                      InterpolatedPhase.fields.volumetricFogConfig.volumetricFogDirectLightingScatteringIntensity,
			//                                                                                      InterpolatedPhase.fields.volumetricFogConfig.volumetricFogSkyLightingScatteringIntensity,
			//                                                                                      InterpolatedPhase.fields.volumetricFogConfig.volumetricFogStartDistance,
			//                                                                                      v24,
			//                                                                                      0LL));
			//           Vector = UnityEngine::Animator::GetVector((Vector3 *)v44, v34, v35, v36);
			//           v38 = *(_QWORD *)&Vector.x;
			//           v39 = Vector.z;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//           camera = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//           if ( camera )
			//           {
			//             v40 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                     *((SettingParameter_1_System_Single_ **)camera + 11),
			//                     MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//             *(_QWORD *)&v.x = v38;
			//             v.z = v39;
			//             *(__m128i *)&cb._InkSimulationWorldToUV.w = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                                                             v44,
			//                                                                                             &v,
			//                                                                                             v40,
			//                                                                                             0LL));
			//             return;
			//           }
			//         }
			//       }
			//     }
			// LABEL_13:
			//     sub_180B536AC(camera, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1287, 0LL);
			//   if ( !Patch )
			//     goto LABEL_13;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_333(Patch, (Object *)this, cb, (Object *)hgCamera, 0LL);
			// }
			// 
		}

		public static void ResetShaderVariablesGlobalVolumetricFog(ref ShaderVariablesGlobal cb)
		{
			// // Void ResetShaderVariablesGlobalVolumetricFog(ShaderVariablesGlobal ByRef)
			// void HG::Rendering::Runtime::HGVolumetricFogRenderer::ResetShaderVariablesGlobalVolumetricFog(
			//         ShaderVariablesGlobal *cb,
			//         MethodInfo *method)
			// {
			//   TileBase *v3; // rdx
			//   Vector3Int *v4; // r8
			//   ITilemap *v5; // r9
			//   TileBase *v6; // rdx
			//   Vector3Int *v7; // r8
			//   ITilemap *v8; // r9
			//   TileBase *v9; // rdx
			//   Vector3Int *v10; // r8
			//   ITilemap *v11; // r9
			//   TileBase *v12; // rdx
			//   Vector3Int *v13; // r8
			//   ITilemap *v14; // r9
			//   TileBase *v15; // rdx
			//   Vector3Int *v16; // r8
			//   ITilemap *v17; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v19; // rdx
			//   __int64 v20; // rcx
			//   TileAnimationData v21; // [rsp+20h] [rbp-18h] BYREF
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1289, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1289, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v20, v19);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_450(Patch, cb, 0LL);
			//   }
			//   else
			//   {
			//     *(__m128i *)&cb._CharacterParams13.w = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                                                                &v21,
			//                                                                                v3,
			//                                                                                v4,
			//                                                                                v5,
			//                                                                                (MethodInfo *)v21.m_AnimatedSprites));
			//     *(__m128i *)&cb._CharacterParams14.w = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                                                                &v21,
			//                                                                                v6,
			//                                                                                v7,
			//                                                                                v8,
			//                                                                                (MethodInfo *)v21.m_AnimatedSprites));
			//     *(__m128i *)&cb._CharacterParams15.w = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                                                                &v21,
			//                                                                                v9,
			//                                                                                v10,
			//                                                                                v11,
			//                                                                                (MethodInfo *)v21.m_AnimatedSprites));
			//     *(__m128i *)&cb._CharacterParams16.w = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                                                                &v21,
			//                                                                                v12,
			//                                                                                v13,
			//                                                                                v14,
			//                                                                                (MethodInfo *)v21.m_AnimatedSprites));
			//     *(__m128i *)&cb._InkSimulationWorldToUV.w = _mm_loadu_si128((const __m128i *)UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
			//                                                                                     &v21,
			//                                                                                     v15,
			//                                                                                     v16,
			//                                                                                     v17,
			//                                                                                     (MethodInfo *)v21.m_AnimatedSprites));
			//   }
			// }
			// 
		}

		public void SetupComputeVolumetricFogPassData(VolumetricFogPassConstructor.ComputeVolumetricFogPassData passData)
		{
			// // Void SetupComputeVolumetricFogPassData(VolumetricFogPassConstructor+ComputeVolumetricFogPassData)
			// void HG::Rendering::Runtime::HGVolumetricFogRenderer::SetupComputeVolumetricFogPassData(
			//         HGVolumetricFogRenderer *this,
			//         VolumetricFogPassConstructor_ComputeVolumetricFogPassData *passData,
			//         MethodInfo *method)
			// {
			//   HGCamera *v5; // rdx
			//   unsigned __int64 m_Z; // rcx
			//   HGCamera *hgCamera; // rbx
			//   HGCamera *v8; // rbx
			//   HGEnvironmentPhase *InterpolatedPhase; // rsi
			//   HGCamera *v10; // rbx
			//   Vector2Int sceneRTSize_k__BackingField; // rbx
			//   Vector3Int *VolumetricFogGridSize; // rax
			//   __int64 v13; // xmm0_8
			//   HGCamera *v14; // rax
			//   float volumetricFogStartDistance; // xmm6_4
			//   float v16; // xmm0_4
			//   Vector3 *VolumetricFogGridZParams; // rax
			//   float z; // ecx
			//   Vector3 *v19; // rax
			//   __int64 v20; // xmm0_8
			//   MethodInfo *v21; // r9
			//   Vector3 *v22; // rax
			//   float v23; // ecx
			//   HGCamera *v24; // rax
			//   Object_1 *historyVolumetricLightScatteringTexture; // rbx
			//   Vector3Int *WidthHeightAndVolumeDepth; // rax
			//   float v27; // ecx
			//   __int64 v28; // xmm0_8
			//   char v29; // al
			//   int32_t memoryless_k__BackingField; // eax
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   Int32Enum__Enum v33; // eax
			//   int32_t v34; // esi
			//   __int64 v35; // r14
			//   uint32_t CameraFrameCount; // ebx
			//   Vector3 *v37; // rax
			//   __int64 v38; // xmm0_8
			//   MethodInfo *v39; // r8
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   Vector4 v41; // [rsp+48h] [rbp-29h] BYREF
			//   Vector3 v42; // [rsp+58h] [rbp-19h] BYREF
			//   NativeArray_1_Unity_Mathematics_quaternion_ volumetricFogEmissive; // [rsp+68h] [rbp-9h] BYREF
			//   RenderTextureDescriptor v44; // [rsp+78h] [rbp+7h] BYREF
			// 
			//   if ( !byte_18D919D96 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     byte_18D919D96 = 1;
			//   }
			//   memset(&v44, 0, sizeof(v44));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1290, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1290, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)passData,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_28;
			//   }
			//   if ( !passData )
			//     goto LABEL_28;
			//   hgCamera = passData.fields.hgCamera;
			//   if ( !hgCamera )
			//     goto LABEL_28;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//   HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(
			//     &hgCamera.fields.volumetricIntegratedLightScatteringTexture,
			//     0LL);
			//   v8 = passData.fields.hgCamera;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//   InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(v8, 0LL);
			//   if ( !InterpolatedPhase )
			//     goto LABEL_28;
			//   v10 = passData.fields.hgCamera;
			//   if ( !v10 )
			//     goto LABEL_28;
			//   sceneRTSize_k__BackingField = v10.fields._sceneRTSize_k__BackingField;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//   VolumetricFogGridSize = HG::Rendering::Runtime::HGVolumetricFogRenderer::GetVolumetricFogGridSize(
			//                             (Vector3Int *)&v42,
			//                             sceneRTSize_k__BackingField,
			//                             &passData.fields.volumetricFogGridToPixel,
			//                             0LL);
			//   m_Z = (unsigned int)VolumetricFogGridSize.m_Z;
			//   v13 = *(_QWORD *)&VolumetricFogGridSize.m_X;
			//   v14 = passData.fields.hgCamera;
			//   *(_QWORD *)&passData.fields.volumetricFogGridSize.m_X = v13;
			//   passData.fields.volumetricFogGridSize.m_Z = m_Z;
			//   volumetricFogStartDistance = InterpolatedPhase.fields.volumetricFogConfig.volumetricFogStartDistance;
			//   if ( !v14 )
			//     goto LABEL_28;
			//   m_Z = (unsigned __int64)v14.fields.camera;
			//   if ( !m_Z )
			//     goto LABEL_28;
			//   v16 = UnityEngine::Camera::get_nearClipPlane((Camera *)m_Z, 0LL);
			//   VolumetricFogGridZParams = HG::Rendering::Runtime::HGVolumetricFogRenderer::GetVolumetricFogGridZParams(
			//                                &v42,
			//                                volumetricFogStartDistance,
			//                                v16,
			//                                InterpolatedPhase.fields.volumetricFogConfig.volumetricFogDistance,
			//                                passData.fields.volumetricFogGridSize.m_Z,
			//                                0LL);
			//   z = VolumetricFogGridZParams.z;
			//   *(_QWORD *)&passData.fields.volumetricFogZParams.x = *(_QWORD *)&VolumetricFogGridZParams.x;
			//   passData.fields.volumetricFogZParams.z = z;
			//   passData.fields.volumetricFogDistance = InterpolatedPhase.fields.volumetricFogConfig.volumetricFogDistance;
			//   volumetricFogEmissive = (NativeArray_1_Unity_Mathematics_quaternion_)InterpolatedPhase.fields.volumetricFogConfig.volumetricFogEmissive;
			//   v19 = HG::Rendering::Runtime::VectorSwizzleUtils::rgb(&v42, (Color *)&volumetricFogEmissive, 0LL);
			//   v20 = *(_QWORD *)&v19.x;
			//   *(float *)&v19 = v19.z;
			//   *(_QWORD *)&v41.x = v20;
			//   LODWORD(v41.z) = (_DWORD)v19;
			//   v22 = UnityEngine::Vector3::op_Multiply(&v42, (Vector3 *)&v41, 0.001, v21);
			//   v23 = v22.z;
			//   *(_QWORD *)&passData.fields.volumetricFogEmissive.x = *(_QWORD *)&v22.x;
			//   passData.fields.volumetricFogEmissive.z = v23;
			//   m_Z = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//   if ( !m_Z )
			//     goto LABEL_28;
			//   if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//           *(SettingParameter_1_System_Boolean_ **)(m_Z + 96),
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//     goto LABEL_17;
			//   v24 = passData.fields.hgCamera;
			//   if ( !v24 )
			//     goto LABEL_28;
			//   if ( !v24.fields.prevTransformReset
			//     && (historyVolumetricLightScatteringTexture = (Object_1 *)v24.fields.historyVolumetricLightScatteringTexture,
			//         sub_180002C70(TypeInfo::UnityEngine::Object),
			//         UnityEngine::Object::op_Inequality(historyVolumetricLightScatteringTexture, 0LL, 0LL)) )
			//   {
			//     v5 = passData.fields.hgCamera;
			//     if ( !v5 )
			//       goto LABEL_28;
			//     WidthHeightAndVolumeDepth = HG::Rendering::Runtime::HGVolumetricFogUtils::GetWidthHeightAndVolumeDepth(
			//                                   (Vector3Int *)&volumetricFogEmissive,
			//                                   v5.fields.historyVolumetricLightScatteringTexture,
			//                                   0LL);
			//     v27 = *(float *)&passData.fields.volumetricFogGridSize.m_Z;
			//     *(_QWORD *)&v41.x = *(_QWORD *)&passData.fields.volumetricFogGridSize.m_X;
			//     v28 = *(_QWORD *)&WidthHeightAndVolumeDepth.m_X;
			//     LODWORD(WidthHeightAndVolumeDepth) = WidthHeightAndVolumeDepth.m_Z;
			//     v41.z = v27;
			//     *(_QWORD *)&v42.x = v28;
			//     LODWORD(v42.z) = (_DWORD)WidthHeightAndVolumeDepth;
			//     v29 = sub_182447920(&v42, &v41);
			//   }
			//   else
			//   {
			// LABEL_17:
			//     v29 = 0;
			//   }
			//   passData.fields.temporalHistoryIsValid = v29;
			//   UnityEngine::RenderTextureDescriptor::RenderTextureDescriptor(
			//     &v44,
			//     passData.fields.volumetricFogGridSize.m_X,
			//     passData.fields.volumetricFogGridSize.m_Y,
			//     GraphicsFormat__Enum_R16G16B16A16_SFloat,
			//     0,
			//     1,
			//     0LL);
			//   v44._dimension_k__BackingField = 3;
			//   v44._volumeDepth_k__BackingField = passData.fields.volumetricFogGridSize.m_Z;
			//   UnityEngine::RenderTextureDescriptor::set_autoGenerateMips(&v44, 0, 0LL);
			//   UnityEngine::RenderTextureDescriptor::set_enableRandomWrite(&v44, 1, 0LL);
			//   memoryless_k__BackingField = v44._memoryless_k__BackingField;
			//   v31 = *(_OWORD *)&v44._mipCount_k__BackingField;
			//   *(_OWORD *)&passData.fields.volumeDesc._width_k__BackingField = *(_OWORD *)&v44._width_k__BackingField;
			//   v32 = *(_OWORD *)&v44._dimension_k__BackingField;
			//   *(_OWORD *)&passData.fields.volumeDesc._mipCount_k__BackingField = v31;
			//   *(_OWORD *)&passData.fields.volumeDesc._dimension_k__BackingField = v32;
			//   passData.fields.volumeDesc._memoryless_k__BackingField = memoryless_k__BackingField;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//   m_Z = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//   if ( !m_Z )
			// LABEL_28:
			//     sub_180B536AC(m_Z, v5);
			//   v33 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//           *(SettingParameter_1_System_Int32Enum_ **)(m_Z + 64),
			//           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//   if ( (int)v33 < 1 )
			//   {
			//     v33 = 1;
			//   }
			//   else if ( (int)v33 > 16 )
			//   {
			//     v33 = 16;
			//   }
			//   passData.fields.historyMissSuperSampleCount = v33;
			//   volumetricFogEmissive = 0LL;
			//   Unity::Collections::NativeArray<Unity::Mathematics::quaternion>::NativeArray(
			//     &volumetricFogEmissive,
			//     16,
			//     Allocator__Enum_Temp,
			//     NativeArrayOptions__Enum_ClearMemory,
			//     MethodInfo::Unity::Collections::NativeArray<UnityEngine::Vector4>::NativeArray);
			//   v34 = 0;
			//   v35 = 0LL;
			//   passData.fields.frameJitterOffsetValues = (NativeArray_1_UnityEngine_Vector4_)volumetricFogEmissive;
			//   while ( v34 < passData.fields.historyMissSuperSampleCount )
			//   {
			//     m_Z = (unsigned __int64)passData.fields.hgCamera;
			//     if ( !m_Z )
			//       goto LABEL_28;
			//     CameraFrameCount = HG::Rendering::Runtime::HGCamera::GetCameraFrameCount((HGCamera *)m_Z, 0LL);
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     v37 = HG::Rendering::Runtime::HGVolumetricFogRenderer::VolumetricFogTemporalRandom(
			//             (Vector3 *)&volumetricFogEmissive,
			//             CameraFrameCount - v34,
			//             0LL);
			//     v38 = *(_QWORD *)&v37.x;
			//     *(float *)&v37 = v37.z;
			//     *(_QWORD *)&v42.x = v38;
			//     LODWORD(v42.z) = (_DWORD)v37;
			//     ++v34;
			//     *(__m128i *)&passData.fields.frameJitterOffsetValues.m_Buffer[v35] = _mm_loadu_si128((const __m128i *)UnityEngine::Vector4::op_Implicit(&v41, &v42, v39));
			//     v35 += 16LL;
			//   }
			// }
			// 
		}

		public void ComputeVolumetricFogGridInjection(CommandBuffer cmd, ScriptableRenderContext renderContext, bool hasGridInjectionPass, VolumetricFogPassConstructor.ComputeVolumetricFogPassData passData)
		{
			// // Void ComputeVolumetricFogGridInjection(CommandBuffer, ScriptableRenderContext, Boolean, VolumetricFogPassConstructor+ComputeVolumetricFogPassData)
			// void HG::Rendering::Runtime::HGVolumetricFogRenderer::ComputeVolumetricFogGridInjection(
			//         HGVolumetricFogRenderer *this,
			//         CommandBuffer *cmd,
			//         ScriptableRenderContext renderContext,
			//         bool hasGridInjectionPass,
			//         VolumetricFogPassConstructor_ComputeVolumetricFogPassData *passData,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   void *Patch; // rcx
			//   VolumetricFogPassConstructor_ComputeVolumetricFogPassData *v11; // rdi
			//   int32_t memoryless_k__BackingField; // eax
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   HGRenderPathBase_HGRenderPathResources *v15; // rdx
			//   PassConstructorID__Enum__Array *v16; // r8
			//   HGCamera *v17; // r9
			//   HGRenderPathBase_HGRenderPathResources *v18; // rdx
			//   PassConstructorID__Enum__Array *v19; // r8
			//   HGCamera *v20; // r9
			//   int32_t v21; // eax
			//   __int128 v22; // xmm1
			//   __int128 v23; // xmm0
			//   RenderTexture *v24; // rax
			//   HGCamera *hgCamera; // rbx
			//   __int64 v26; // rdx
			//   HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *s_settingParameters; // rcx
			//   HGEnvironmentPhase *InterpolatedPhase; // r15
			//   ComputeShader *volumetricFogGridInjectionCS; // r14
			//   bool v30; // al
			//   Vector3 *v31; // rax
			//   float volumetricFogExtinctionScale; // xmm7_4
			//   __int64 v33; // xmm6_8
			//   float z; // ebx
			//   Vector4 *v35; // rax
			//   __m128i v36; // xmm6
			//   __m128i v37; // xmm0
			//   CBHandle *v38; // rax
			//   __m128i v39; // xmm6
			//   int32_t VolumetricFogVBufferA; // ebx
			//   RenderTargetIdentifier *v41; // rax
			//   __int128 v42; // xmm1
			//   int32_t VolumetricFogVBufferB; // ebx
			//   RenderTargetIdentifier *v44; // rax
			//   __int128 v45; // xmm1
			//   int32_t m_Z; // eax
			//   Vector3Int *v47; // rax
			//   MethodInfo *offset; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *offseta; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *size; // [rsp+30h] [rbp-D8h]
			//   MethodInfo *sizea; // [rsp+30h] [rbp-D8h]
			//   __int64 threadGroupsX; // [rsp+48h] [rbp-C0h] BYREF
			//   LocalKeyword keyword; // [rsp+50h] [rbp-B8h] BYREF
			//   __int128 v54; // [rsp+68h] [rbp-A0h]
			//   __int64 v55; // [rsp+78h] [rbp-90h]
			//   RenderTextureDescriptor v56; // [rsp+88h] [rbp-80h] BYREF
			//   LocalKeyword v57; // [rsp+C8h] [rbp-40h] BYREF
			//   Void source[16]; // [rsp+E0h] [rbp-28h] BYREF
			//   __m128i v59; // [rsp+F0h] [rbp-18h]
			//   ScriptableRenderContext P2; // [rsp+158h] [rbp+50h] BYREF
			// 
			//   P2.m_Ptr = renderContext.m_Ptr;
			//   if ( !byte_18D919D97 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&off_18C8F3048);
			//     sub_18003C530(&off_18C8F0CD8);
			//     sub_18003C530(&off_18D5E7AE8);
			//     byte_18D919D97 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1292, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1292, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_499(
			//         (ILFixDynamicMethodWrapper_2 *)Patch,
			//         (Object *)this,
			//         (Object *)cmd,
			//         P2,
			//         hasGridInjectionPass,
			//         (Object *)passData,
			//         0LL);
			//       return;
			//     }
			// LABEL_16:
			//     sub_180B536AC(Patch, v9);
			//   }
			//   if ( !hasGridInjectionPass )
			//     return;
			//   v11 = passData;
			//   if ( !passData )
			//     goto LABEL_16;
			//   memoryless_k__BackingField = passData.fields.volumeDesc._memoryless_k__BackingField;
			//   v13 = *(_OWORD *)&passData.fields.volumeDesc._mipCount_k__BackingField;
			//   *(_OWORD *)&v56._width_k__BackingField = *(_OWORD *)&passData.fields.volumeDesc._width_k__BackingField;
			//   v14 = *(_OWORD *)&passData.fields.volumeDesc._dimension_k__BackingField;
			//   v56._memoryless_k__BackingField = memoryless_k__BackingField;
			//   *(_OWORD *)&v56._mipCount_k__BackingField = v13;
			//   *(_OWORD *)&v56._dimension_k__BackingField = v14;
			//   v11.fields.vBufferA = HG::Rendering::Runtime::HGVolumetricFogUtils::GetAndCreateTemporaryRenderTexture(
			//                            &v56,
			//                            (String *)"_VolumetricFogVBufferA",
			//                            0LL);
			//   sub_1800054D0((HGRenderPathScene *)&v11.fields.vBufferA, v15, v16, v17, offset, size);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//   Patch = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//   if ( !Patch )
			//     goto LABEL_16;
			//   if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//          *((SettingParameter_1_System_Boolean_ **)Patch + 14),
			//          MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//   {
			//     v21 = v11.fields.volumeDesc._memoryless_k__BackingField;
			//     v22 = *(_OWORD *)&v11.fields.volumeDesc._mipCount_k__BackingField;
			//     *(_OWORD *)&v56._width_k__BackingField = *(_OWORD *)&v11.fields.volumeDesc._width_k__BackingField;
			//     v23 = *(_OWORD *)&v11.fields.volumeDesc._dimension_k__BackingField;
			//     v56._memoryless_k__BackingField = v21;
			//     *(_OWORD *)&v56._mipCount_k__BackingField = v22;
			//     *(_OWORD *)&v56._dimension_k__BackingField = v23;
			//     v24 = HG::Rendering::Runtime::HGVolumetricFogUtils::GetAndCreateTemporaryRenderTexture(
			//             &v56,
			//             (String *)"_VolumetricFogVBufferB",
			//             0LL);
			//   }
			//   else
			//   {
			//     v24 = 0LL;
			//   }
			//   v11.fields.vBufferB = v24;
			//   sub_1800054D0((HGRenderPathScene *)&v11.fields.vBufferB, v18, v19, v20, offseta, sizea);
			//   hgCamera = v11.fields.hgCamera;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//   InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(hgCamera, 0LL);
			//   if ( !InterpolatedPhase )
			//     goto LABEL_14;
			//   volumetricFogGridInjectionCS = v11.fields.volumetricFogGridInjectionCS;
			//   memset(&v57, 0, sizeof(v57));
			//   UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//     &v57,
			//     volumetricFogGridInjectionCS,
			//     (String *)"ENABLE_EMISSIVE_VBUFFER_B",
			//     0LL);
			//   *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v57.m_SpaceInfo.m_KeywordSpace;
			//   *(_QWORD *)&v54 = *(_QWORD *)&v57.m_Index;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//   s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//   if ( !s_settingParameters
			//     || (v30 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                 s_settingParameters.fields.enableEmissiveVBufferB,
			//                 MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit),
			//         !cmd) )
			//   {
			// LABEL_14:
			//     sub_180B536AC(s_settingParameters, v26);
			//   }
			//   UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//     cmd,
			//     volumetricFogGridInjectionCS,
			//     (LocalKeyword *)&keyword.m_Name,
			//     v30,
			//     0LL);
			//   *(_OWORD *)&keyword.m_Name = 0LL;
			//   v54 = 0LL;
			//   *(Color *)&keyword.m_Name = InterpolatedPhase.fields.volumetricFogConfig.volumetricFogAlbedo;
			//   v31 = HG::Rendering::Runtime::VectorSwizzleUtils::rgb((Vector3 *)&threadGroupsX, (Color *)&keyword.m_Name, 0LL);
			//   volumetricFogExtinctionScale = InterpolatedPhase.fields.volumetricFogConfig.volumetricFogExtinctionScale;
			//   v33 = *(_QWORD *)&v31.x;
			//   z = v31.z;
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//   threadGroupsX = v33;
			//   *(float *)&keyword.m_SpaceInfo.m_KeywordSpace = z;
			//   v35 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//           (Vector4 *)&keyword.m_Name,
			//           (Vector3 *)&threadGroupsX,
			//           volumetricFogExtinctionScale,
			//           0LL);
			//   threadGroupsX = *(_QWORD *)&v11.fields.volumetricFogEmissive.x;
			//   v36 = _mm_loadu_si128((const __m128i *)v35);
			//   *(float *)&keyword.m_SpaceInfo.m_KeywordSpace = v11.fields.volumetricFogEmissive.z;
			//   v37 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                            (Vector4 *)&keyword.m_Name,
			//                                            (Vector3 *)&threadGroupsX,
			//                                            0LL));
			//   *(__m128i *)source = v36;
			//   v59 = v37;
			//   sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//   v38 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//           (CBHandle *)&keyword.m_Name,
			//           &P2,
			//           32,
			//           0LL);
			//   v39 = *(__m128i *)&v38.bufferId;
			//   *(_QWORD *)&v54 = v38.ptr;
			//   Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)v54, source, 32LL, 0LL);
			//   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//   UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantBufferParam(
			//     cmd,
			//     volumetricFogGridInjectionCS,
			//     TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._VolumetricFogGridInjectionConstants,
			//     _mm_cvtsi128_si32(v39),
			//     _mm_cvtsi128_si32(_mm_srli_si128(v39, 4)),
			//     _mm_cvtsi128_si32(_mm_srli_si128(v39, 8)),
			//     0LL);
			//   VolumetricFogVBufferA = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._VolumetricFogVBufferA;
			//   v41 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//           (RenderTargetIdentifier *)&v56,
			//           (Texture *)v11.fields.vBufferA,
			//           0LL);
			//   v42 = *(_OWORD *)&v41.m_BufferPointer;
			//   *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v41.m_Type;
			//   v37.m128i_i64[0] = *(_QWORD *)&v41.m_DepthSlice;
			//   v54 = v42;
			//   v55 = v37.m128i_i64[0];
			//   UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//     cmd,
			//     volumetricFogGridInjectionCS,
			//     0,
			//     VolumetricFogVBufferA,
			//     (RenderTargetIdentifier *)&keyword.m_Name,
			//     0LL);
			//   VolumetricFogVBufferB = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._VolumetricFogVBufferB;
			//   v44 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//           (RenderTargetIdentifier *)&v56,
			//           (Texture *)v11.fields.vBufferB,
			//           0LL);
			//   v45 = *(_OWORD *)&v44.m_BufferPointer;
			//   *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v44.m_Type;
			//   v37.m128i_i64[0] = *(_QWORD *)&v44.m_DepthSlice;
			//   v54 = v45;
			//   v55 = v37.m128i_i64[0];
			//   UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//     cmd,
			//     volumetricFogGridInjectionCS,
			//     0,
			//     VolumetricFogVBufferB,
			//     (RenderTargetIdentifier *)&keyword.m_Name,
			//     0LL);
			//   m_Z = v11.fields.volumetricFogGridSize.m_Z;
			//   threadGroupsX = *(_QWORD *)&v11.fields.volumetricFogGridSize.m_X;
			//   LODWORD(keyword.m_SpaceInfo.m_KeywordSpace) = m_Z;
			//   v47 = HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(
			//           (Vector3Int *)&keyword.m_Name,
			//           (Vector3Int *)&threadGroupsX,
			//           4,
			//           0LL);
			//   UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//     cmd,
			//     volumetricFogGridInjectionCS,
			//     0,
			//     *(_QWORD *)&v47.m_X,
			//     HIDWORD(*(_QWORD *)&v47.m_X),
			//     v47.m_Z,
			//     0LL);
			// }
			// 
		}

		public void RenderVolumetricFogVoxelization(CommandBuffer cmd, VolumetricFogPassConstructor.ComputeVolumetricFogPassData passData)
		{
			// // Void RenderVolumetricFogVoxelization(CommandBuffer, VolumetricFogPassConstructor+ComputeVolumetricFogPassData)
			// void HG::Rendering::Runtime::HGVolumetricFogRenderer::RenderVolumetricFogVoxelization(
			//         HGVolumetricFogRenderer *this,
			//         CommandBuffer *cmd,
			//         VolumetricFogPassConstructor_ComputeVolumetricFogPassData *passData,
			//         MethodInfo *method)
			// {
			//   Object *v6; // r12
			//   HGVolumetricLocalFogManager *instance; // rax
			//   HGShaderIDs__StaticFields *static_fields; // rdx
			//   void *s_voxelizationMaterialPropertyBlock; // rcx
			//   List_1_HG_Rendering_Runtime_HGVolumetricLocalFog_ *volumetricLocalFogList; // rax
			//   List_1_System_Object_ *v11; // rbx
			//   HGCamera *hgCamera; // r15
			//   Camera *camera; // rsi
			//   Matrix4x4 *projectionMatrix; // rax
			//   float volumetricFogDistance; // xmm6_4
			//   __int128 v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   float v19; // xmm7_4
			//   float v20; // xmm8_4
			//   float v21; // xmm7_4
			//   float v22; // xmm6_4
			//   float v23; // xmm7_4
			//   Matrix4x4 *worldToCameraMatrix; // rax
			//   __int128 v25; // xmm1
			//   __int128 v26; // xmm0
			//   __int128 v27; // xmm1
			//   Matrix4x4 *v28; // rax
			//   __int128 v29; // xmm6
			//   __int128 v30; // xmm7
			//   __int128 v31; // xmm8
			//   __int128 v32; // xmm9
			//   HGVolumetricLocalFogManager *v33; // r13
			//   int32_t InstanceID; // eax
			//   NativeList_1_System_Int32_ v35; // xmm0
			//   float *m_Buffer; // rax
			//   float v37; // xmm6_4
			//   float v38; // xmm7_4
			//   __int128 v39; // xmm1
			//   __int128 v40; // xmm0
			//   __int128 v41; // xmm1
			//   MethodInfo *v42; // rdx
			//   Vector2 v43; // rax
			//   Vector2Int sceneRTSize_k__BackingField; // rdx
			//   int32_t v45; // r13d
			//   MaterialPropertyBlock *v46; // rsi
			//   MethodInfo *v47; // rdx
			//   __m128 m_X; // xmm2
			//   __m128 m_Y; // xmm1
			//   Vector4 *v50; // rax
			//   int32_t v51; // r10d
			//   int32_t VoxelizationFrameJitterOffset; // edx
			//   int32_t v53; // edx
			//   MaterialPropertyBlock *v54; // rcx
			//   Int32Enum__Enum v55; // eax
			//   Component *Item; // rsi
			//   Object_1 *klass; // rbx
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   __int64 v60; // xmm6_8
			//   float z; // ebx
			//   Transform *v62; // rax
			//   Vector3 *lossyScale; // rax
			//   __int64 v64; // xmm0_8
			//   double v65; // xmm0_8
			//   float v66; // xmm7_4
			//   Vector3 *v67; // rax
			//   __int64 v68; // xmm8_8
			//   float v69; // xmm6_4
			//   int32_t VolumetricFogZSliceFromDepth; // eax
			//   __int64 v71; // xmm0_8
			//   int v72; // r15d
			//   int32_t v73; // ebx
			//   int32_t v74; // ebx
			//   MaterialPropertyBlock *v75; // r12
			//   MaterialPropertyBlock *v76; // r12
			//   Transform *v77; // rax
			//   Vector3 *v78; // rax
			//   __int64 v79; // xmm0_8
			//   MethodInfo *v80; // r8
			//   Vector4 *v81; // rax
			//   MethodInfo *v82; // r8
			//   Vector4 *v83; // rax
			//   MaterialPropertyBlock *v84; // r10
			//   MaterialPropertyBlock *v85; // r12
			//   Transform *v86; // rax
			//   Matrix4x4 *worldToLocalMatrix; // rax
			//   __int128 v88; // xmm1
			//   __int128 v89; // xmm0
			//   __int128 v90; // xmm1
			//   int v91; // r12d
			//   Transform *v92; // rax
			//   Matrix4x4 *v93; // rax
			//   Material *v94; // r9
			//   __int128 v95; // xmm1
			//   __int128 v96; // xmm0
			//   __int128 v97; // xmm1
			//   __int64 v98; // r12
			//   Void *v99; // r15
			//   Transform *v100; // rax
			//   Matrix4x4 *localToWorldMatrix; // rax
			//   __int128 v102; // xmm1
			//   __int128 v103; // xmm2
			//   __int128 v104; // xmm3
			//   Mesh *quadMesh; // r15
			//   Material *v106; // rsi
			//   HGVolumetricFogRenderer__StaticFields *v107; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MaterialPropertyBlock *v109; // [rsp+40h] [rbp-C8h]
			//   Vector3Int volumetricFogGridSize; // [rsp+58h] [rbp-B0h] BYREF
			//   List_1_System_Object_ *v111; // [rsp+68h] [rbp-A0h]
			//   Vector2 VolumetricFogGridToScreenSVPosRatio; // [rsp+70h] [rbp-98h]
			//   HGCamera *v113; // [rsp+78h] [rbp-90h]
			//   Matrix4x4 v114; // [rsp+88h] [rbp-80h] BYREF
			//   Vector4 v115; // [rsp+C8h] [rbp-40h] BYREF
			//   Nullable_1_UnityEngine_Rendering_RenderStateBlock_ v116; // [rsp+D8h] [rbp-30h] BYREF
			//   Vector4 v117; // [rsp+148h] [rbp+40h] BYREF
			//   Vector3 v118; // [rsp+158h] [rbp+50h] BYREF
			//   Vector3 v119; // [rsp+168h] [rbp+60h] BYREF
			//   Vector3 m_Extents; // [rsp+178h] [rbp+70h] BYREF
			//   Vector3 v121; // [rsp+188h] [rbp+80h] BYREF
			//   Vector3 v122; // [rsp+198h] [rbp+90h] BYREF
			//   Vector3 v123; // [rsp+1A8h] [rbp+A0h] BYREF
			//   Vector3 v124; // [rsp+1B8h] [rbp+B0h] BYREF
			//   Vector3 v125; // [rsp+1C8h] [rbp+C0h] BYREF
			//   NativeArray_1_UnityEngine_Matrix4x4_ v126; // [rsp+1D8h] [rbp+D0h] BYREF
			//   Vector4 v127; // [rsp+1E8h] [rbp+E0h] BYREF
			//   Bounds v128; // [rsp+1F8h] [rbp+F0h] BYREF
			//   RenderTargetIdentifier v129; // [rsp+210h] [rbp+108h] BYREF
			//   RenderTargetIdentifier v130; // [rsp+238h] [rbp+130h] BYREF
			//   NativeList_1_System_Int32_ v131; // [rsp+260h] [rbp+158h] BYREF
			//   Matrix4x4 v132; // [rsp+278h] [rbp+170h] BYREF
			//   Vector3 v133; // [rsp+2B8h] [rbp+1B0h] BYREF
			//   Vector3 v134; // [rsp+2C8h] [rbp+1C0h] BYREF
			//   Vector3 v135; // [rsp+2D8h] [rbp+1D0h] BYREF
			//   _OWORD v136[7]; // [rsp+2E8h] [rbp+1E0h] BYREF
			//   Vector4 v137; // [rsp+358h] [rbp+250h] BYREF
			//   Vector4 v138; // [rsp+368h] [rbp+260h] BYREF
			// 
			//   v6 = (Object *)this;
			//   if ( !byte_18D919D98 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGVolumetricLocalFog>::get_Count);
			//     sub_18003C530(&MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGVolumetricLocalFog>::get_Item);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::GetSubArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray);
			//     sub_18003C530(&MethodInfo::Unity::Collections::NativeList<int>::get_Item);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//     sub_18003C530(&off_18C8F3988);
			//     byte_18D919D98 = 1;
			//   }
			//   v126 = 0LL;
			//   memset(&v129, 0, sizeof(v129));
			//   memset(&v128, 0, sizeof(v128));
			//   sub_1802F01E0(v136, 0LL, 112LL);
			//   memset(&v130, 0, sizeof(v130));
			//   if ( IFix::WrappersManagerImpl::IsPatched(1295, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1295, 0LL);
			//     if ( !Patch )
			//       goto LABEL_60;
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//       (ILFixDynamicMethodWrapper_28 *)Patch,
			//       v6,
			//       (Object *)cmd,
			//       (Object *)passData,
			//       0LL);
			//   }
			//   else
			//   {
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager);
			//     instance = HG::Rendering::Runtime::HGVolumetricLocalFogManager::get_instance(0LL);
			//     if ( !instance )
			//       goto LABEL_60;
			//     volumetricLocalFogList = HG::Rendering::Runtime::HGVolumetricLocalFogManager::get_volumetricLocalFogList(
			//                                instance,
			//                                0LL);
			//     v111 = (List_1_System_Object_ *)volumetricLocalFogList;
			//     v11 = (List_1_System_Object_ *)volumetricLocalFogList;
			//     if ( !volumetricLocalFogList )
			//       goto LABEL_60;
			//     if ( volumetricLocalFogList.fields._size )
			//     {
			//       if ( passData )
			//       {
			//         hgCamera = passData.fields.hgCamera;
			//         v113 = hgCamera;
			//         if ( hgCamera )
			//         {
			//           camera = hgCamera.fields.camera;
			//           if ( camera )
			//           {
			//             projectionMatrix = UnityEngine::Camera::get_projectionMatrix(
			//                                  (Matrix4x4 *)&v116,
			//                                  hgCamera.fields.camera,
			//                                  0LL);
			//             volumetricFogDistance = passData.fields.volumetricFogDistance;
			//             v16 = *(_OWORD *)&projectionMatrix.m01;
			//             *(_OWORD *)&v114.m00 = *(_OWORD *)&projectionMatrix.m00;
			//             v17 = *(_OWORD *)&projectionMatrix.m02;
			//             *(_OWORD *)&v114.m01 = v16;
			//             v18 = *(_OWORD *)&projectionMatrix.m03;
			//             *(_OWORD *)&v114.m02 = v17;
			//             *(_OWORD *)&v114.m03 = v18;
			//             *(float *)&v17 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
			//             v19 = passData.fields.volumetricFogDistance;
			//             v20 = -(float)(*(float *)&v17 + volumetricFogDistance);
			//             *(float *)&v17 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
			//             UnityEngine::Matrix4x4::set_Item(&v114, 10, v20 / (float)(v19 - *(float *)&v17), 0LL);
			//             v21 = passData.fields.volumetricFogDistance;
			//             *(float *)&v17 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
			//             v22 = passData.fields.volumetricFogDistance;
			//             v23 = -(float)((float)(v21 + v21) * *(float *)&v17);
			//             *(float *)&v17 = UnityEngine::Camera::get_nearClipPlane(camera, 0LL);
			//             UnityEngine::Matrix4x4::set_Item(&v114, 14, v23 / (float)(v22 - *(float *)&v17), 0LL);
			//             worldToCameraMatrix = UnityEngine::Camera::get_worldToCameraMatrix((Matrix4x4 *)&v116, camera, 0LL);
			//             v25 = *(_OWORD *)&worldToCameraMatrix.m01;
			//             *(_OWORD *)&v132.m00 = *(_OWORD *)&worldToCameraMatrix.m00;
			//             v26 = *(_OWORD *)&worldToCameraMatrix.m02;
			//             *(_OWORD *)&v132.m01 = v25;
			//             v27 = *(_OWORD *)&worldToCameraMatrix.m03;
			//             *(_OWORD *)&v132.m02 = v26;
			//             *(_OWORD *)&v132.m03 = v27;
			//             *(_OWORD *)&v116.hasValue = *(_OWORD *)&v114.m00;
			//             *(_OWORD *)&v116.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = *(_OWORD *)&v114.m01;
			//             *(_OWORD *)&v116.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = *(_OWORD *)&v114.m02;
			//             *(_OWORD *)&v116.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = *(_OWORD *)&v114.m03;
			//             v28 = UnityEngine::Matrix4x4::op_Multiply(&v114, (Matrix4x4 *)&v116, &v132, 0LL);
			//             v29 = *(_OWORD *)&v28.m00;
			//             v30 = *(_OWORD *)&v28.m01;
			//             v31 = *(_OWORD *)&v28.m02;
			//             v32 = *(_OWORD *)&v28.m03;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricLocalFogManager);
			//             v33 = HG::Rendering::Runtime::HGVolumetricLocalFogManager::get_instance(0LL);
			//             InstanceID = UnityEngine::Object::GetInstanceID((Object_1 *)camera, 0LL);
			//             if ( v33 )
			//             {
			//               *(_OWORD *)&v116.hasValue = v29;
			//               *(_OWORD *)&v116.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v30;
			//               *(_OWORD *)&v116.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v31;
			//               *(_OWORD *)&v116.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v32;
			//               v35 = *HG::Rendering::Runtime::HGVolumetricLocalFogManager::VolumetricLocalFogCulling(
			//                        (NativeList_1_System_Int32_ *)&v127,
			//                        v33,
			//                        (Matrix4x4 *)&v116,
			//                        InstanceID,
			//                        0LL);
			//               m_Buffer = (float *)passData.fields.frameJitterOffsetValues.m_Buffer;
			//               v131 = v35;
			//               v37 = *m_Buffer / (float)passData.fields.volumetricFogGridSize.m_X;
			//               v38 = m_Buffer[1] / (float)passData.fields.volumetricFogGridSize.m_Y;
			//               v39 = *(_OWORD *)&hgCamera.fields.mainViewConstants.nonJitteredProjMatrix.m01;
			//               *(_OWORD *)&v114.m00 = *(_OWORD *)&hgCamera.fields.mainViewConstants.nonJitteredProjMatrix.m00;
			//               v40 = *(_OWORD *)&hgCamera.fields.mainViewConstants.nonJitteredProjMatrix.m02;
			//               *(_OWORD *)&v114.m01 = v39;
			//               v41 = *(_OWORD *)&hgCamera.fields.mainViewConstants.nonJitteredProjMatrix.m03;
			//               *(_OWORD *)&v114.m02 = v40;
			//               *(_OWORD *)&v114.m03 = v41;
			//               *(float *)&v40 = UnityEngine::Matrix4x4::get_Item(&v114, 8, 0LL);
			//               UnityEngine::Matrix4x4::set_Item(&v114, 8, *(float *)&v40 + v37, 0LL);
			//               *(float *)&v40 = UnityEngine::Matrix4x4::get_Item(&v114, 9, 0LL);
			//               UnityEngine::Matrix4x4::set_Item(&v114, 9, *(float *)&v40 - v38, 0LL);
			//               v43 = UnityEngine::Vector2Int::op_Implicit(passData.fields.volumetricFogGridToPixel, v42);
			//               sceneRTSize_k__BackingField = hgCamera.fields._sceneRTSize_k__BackingField;
			//               v45 = 0;
			//               volumetricFogGridSize = passData.fields.volumetricFogGridSize;
			//               VolumetricFogGridToScreenSVPosRatio = HG::Rendering::Runtime::HGVolumetricFogRenderer::_GetVolumetricFogGridToScreenSVPosRatio(
			//                                                       (HGVolumetricFogRenderer *)v6,
			//                                                       sceneRTSize_k__BackingField,
			//                                                       &volumetricFogGridSize,
			//                                                       v43,
			//                                                       0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//               s_voxelizationMaterialPropertyBlock = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_voxelizationMaterialPropertyBlock;
			//               if ( s_voxelizationMaterialPropertyBlock )
			//               {
			//                 UnityEngine::MaterialPropertyBlock::Clear(
			//                   (MaterialPropertyBlock *)s_voxelizationMaterialPropertyBlock,
			//                   1,
			//                   0LL);
			//                 v46 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_voxelizationMaterialPropertyBlock;
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                 *(Vector2 *)&volumetricFogGridSize.m_X = UnityEngine::Vector2Int::op_Implicit(
			//                                                            passData.fields.volumetricFogGridToPixel,
			//                                                            v47);
			//                 m_X = (__m128)(unsigned int)volumetricFogGridSize.m_X;
			//                 m_Y = (__m128)(unsigned int)volumetricFogGridSize.m_Y;
			//                 m_X.m128_f32[0] = *(float *)&volumetricFogGridSize.m_X / VolumetricFogGridToScreenSVPosRatio.x;
			//                 m_Y.m128_f32[0] = *(float *)&volumetricFogGridSize.m_Y / VolumetricFogGridToScreenSVPosRatio.y;
			//                 v50 = (Vector4 *)sub_1825A3980(&v127, _mm_unpacklo_ps(m_X, m_Y).m128_u64[0]);
			//                 if ( v46 )
			//                 {
			//                   v117 = *v50;
			//                   UnityEngine::MaterialPropertyBlock::SetVector(v46, v51, &v117, 0LL);
			//                   s_voxelizationMaterialPropertyBlock = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_voxelizationMaterialPropertyBlock;
			//                   static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                   if ( s_voxelizationMaterialPropertyBlock )
			//                   {
			//                     VoxelizationFrameJitterOffset = static_fields._VoxelizationFrameJitterOffset;
			//                     v117 = *(Vector4 *)passData.fields.frameJitterOffsetValues.m_Buffer;
			//                     UnityEngine::MaterialPropertyBlock::SetVector(
			//                       (MaterialPropertyBlock *)s_voxelizationMaterialPropertyBlock,
			//                       VoxelizationFrameJitterOffset,
			//                       &v117,
			//                       0LL);
			//                     s_voxelizationMaterialPropertyBlock = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                     if ( TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_voxelizationMaterialPropertyBlock )
			//                     {
			//                       v53 = *((_DWORD *)s_voxelizationMaterialPropertyBlock + 279);
			//                       v54 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_voxelizationMaterialPropertyBlock;
			//                       *(_OWORD *)&v116.hasValue = *(_OWORD *)&v114.m00;
			//                       *(_OWORD *)&v116.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = *(_OWORD *)&v114.m01;
			//                       *(_OWORD *)&v116.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = *(_OWORD *)&v114.m02;
			//                       *(_OWORD *)&v116.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = *(_OWORD *)&v114.m03;
			//                       UnityEngine::MaterialPropertyBlock::SetMatrix(v54, v53, (Matrix4x4 *)&v116, 0LL);
			//                       if ( UnityEngine::SystemInfo::SupportsRenderTargetArrayIndexFromVertexShader(0LL) )
			//                       {
			//                         UnityEngine::Rendering::RenderTargetIdentifier::RenderTargetIdentifier(
			//                           &v129,
			//                           (Texture *)passData.fields.vBufferA,
			//                           0,
			//                           CubemapFace__Enum_Unknown,
			//                           -1,
			//                           0LL);
			//                         if ( !cmd )
			//                           goto LABEL_60;
			//                         *(_OWORD *)&v114.m00 = *(_OWORD *)&v129.m_Type;
			//                         *(_QWORD *)&v114.m02 = *(_QWORD *)&v129.m_DepthSlice;
			//                         *(_OWORD *)&v114.m01 = *(_OWORD *)&v129.m_BufferPointer;
			//                         UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
			//                           cmd,
			//                           (RenderTargetIdentifier *)&v114,
			//                           RenderBufferLoadAction__Enum_Load,
			//                           RenderBufferStoreAction__Enum_Store,
			//                           0LL);
			//                       }
			//                       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//                       s_voxelizationMaterialPropertyBlock = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//                       if ( s_voxelizationMaterialPropertyBlock )
			//                       {
			//                         v55 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
			//                                 *((SettingParameter_1_System_Int32Enum_ **)s_voxelizationMaterialPropertyBlock + 4),
			//                                 MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
			//                         Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray(
			//                           &v126,
			//                           v55,
			//                           Allocator__Enum_Temp,
			//                           NativeArrayOptions__Enum_ClearMemory,
			//                           MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::NativeArray);
			//                         while ( 1 )
			//                         {
			//                           if ( v45 >= v11.fields._size )
			//                             return;
			//                           Item = (Component *)System::Collections::Generic::List<System::Object>::get_Item(
			//                                                 v11,
			//                                                 v45,
			//                                                 MethodInfo::System::Collections::Generic::List<HG::Rendering::Runtime::HGVolumetricLocalFog>::get_Item);
			//                           if ( Unity::Collections::NativeList<int>::get_Item(
			//                                  &v131,
			//                                  v45,
			//                                  MethodInfo::Unity::Collections::NativeList<int>::get_Item) )
			//                           {
			//                             if ( !Item )
			//                               break;
			//                             klass = (Object_1 *)Item[1].klass;
			//                             sub_180002C70(TypeInfo::UnityEngine::Object);
			//                             if ( !UnityEngine::Object::op_Equality(klass, 0LL, 0LL) )
			//                             {
			//                               s_voxelizationMaterialPropertyBlock = Item[1].klass;
			//                               if ( !s_voxelizationMaterialPropertyBlock )
			//                                 break;
			//                               if ( UnityEngine::Material::FindPass(
			//                                      (Material *)s_voxelizationMaterialPropertyBlock,
			//                                      (String *)"VolumerticFogVoxelization",
			//                                      0LL) != -1 )
			//                               {
			//                                 transform = UnityEngine::Component::get_transform(Item, 0LL);
			//                                 if ( !transform )
			//                                   break;
			//                                 position = UnityEngine::Transform::get_position(&v133, transform, 0LL);
			//                                 v60 = *(_QWORD *)&position.x;
			//                                 z = position.z;
			//                                 v62 = UnityEngine::Component::get_transform(Item, 0LL);
			//                                 if ( !v62 )
			//                                   break;
			//                                 lossyScale = UnityEngine::Transform::get_lossyScale(&v134, v62, 0LL);
			//                                 *(_QWORD *)&v119.x = v60;
			//                                 v119.z = z;
			//                                 v64 = *(_QWORD *)&lossyScale.x;
			//                                 *(float *)&lossyScale = lossyScale.z;
			//                                 *(_QWORD *)&v118.x = v64;
			//                                 LODWORD(v118.z) = (_DWORD)lossyScale;
			//                                 UnityEngine::Bounds::Bounds(&v128, &v119, &v118, 0LL);
			//                                 m_Extents = v128.m_Extents;
			//                                 v65 = sub_18238EFA0(&m_Extents);
			//                                 v66 = *(float *)&v65;
			//                                 *(_QWORD *)&v121.x = *(_QWORD *)&v128.m_Center.x;
			//                                 LODWORD(v121.z) = _mm_cvtsi128_si32(_mm_srli_si128(*(__m128i *)&v128.m_Center.x, 8));
			//                                 v67 = UnityEngine::Matrix4x4::MultiplyPoint(
			//                                         &v135,
			//                                         &hgCamera.fields.mainViewConstants.viewMatrix,
			//                                         &v121,
			//                                         0LL);
			//                                 *(_QWORD *)&v122.x = *(_QWORD *)&passData.fields.volumetricFogZParams.x;
			//                                 v68 = *(_QWORD *)&v67.x;
			//                                 volumetricFogGridSize.m_X = LODWORD(v67.z);
			//                                 v69 = -*(float *)&volumetricFogGridSize.m_X;
			//                                 v122.z = passData.fields.volumetricFogZParams.z;
			//                                 VolumetricFogZSliceFromDepth = HG::Rendering::Runtime::HGVolumetricFogRenderer::_GetVolumetricFogZSliceFromDepth(
			//                                                                  (HGVolumetricFogRenderer *)v6,
			//                                                                  (float)-*(float *)&volumetricFogGridSize.m_X
			//                                                                - *(float *)&v65,
			//                                                                  &v122,
			//                                                                  0LL);
			//                                 v71 = *(_QWORD *)&passData.fields.volumetricFogZParams.x;
			//                                 v123.z = passData.fields.volumetricFogZParams.z;
			//                                 *(_QWORD *)&v123.x = v71;
			//                                 v72 = VolumetricFogZSliceFromDepth;
			//                                 v73 = HG::Rendering::Runtime::HGVolumetricFogRenderer::_GetVolumetricFogZSliceFromDepth(
			//                                         (HGVolumetricFogRenderer *)v6,
			//                                         v69 + v66,
			//                                         &v123,
			//                                         0LL);
			//                                 if ( v72 < 0 )
			//                                 {
			//                                   v72 = 0;
			//                                 }
			//                                 else if ( v72 > passData.fields.volumetricFogGridSize.m_Z - 1 )
			//                                 {
			//                                   v72 = passData.fields.volumetricFogGridSize.m_Z - 1;
			//                                 }
			//                                 if ( v73 < 0 )
			//                                 {
			//                                   v73 = 0;
			//                                 }
			//                                 else if ( v73 > passData.fields.volumetricFogGridSize.m_Z - 1 )
			//                                 {
			//                                   v73 = passData.fields.volumetricFogGridSize.m_Z - 1;
			//                                 }
			//                                 v74 = v73 - v72 + 1;
			//                                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//                                 v75 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_voxelizationMaterialPropertyBlock;
			//                                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                                 if ( !v75 )
			//                                   break;
			//                                 UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                   v75,
			//                                   TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._VoxelizationClosestSliceIndex,
			//                                   (float)v72,
			//                                   0LL);
			//                                 v76 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_voxelizationMaterialPropertyBlock;
			//                                 LODWORD(VolumetricFogGridToScreenSVPosRatio.x) = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._VoxelizationVolumePos;
			//                                 v77 = UnityEngine::Component::get_transform(Item, 0LL);
			//                                 if ( !v77 )
			//                                   break;
			//                                 v78 = UnityEngine::Transform::get_position((Vector3 *)&v117, v77, 0LL);
			//                                 v79 = *(_QWORD *)&v78.x;
			//                                 *(float *)&v78 = v78.z;
			//                                 *(_QWORD *)&v124.x = v79;
			//                                 LODWORD(v124.z) = (_DWORD)v78;
			//                                 v81 = UnityEngine::Vector4::op_Implicit(&v137, &v124, v80);
			//                                 if ( !v76 )
			//                                   break;
			//                                 v115 = *v81;
			//                                 UnityEngine::MaterialPropertyBlock::SetVector(
			//                                   v76,
			//                                   SLODWORD(VolumetricFogGridToScreenSVPosRatio.x),
			//                                   &v115,
			//                                   0LL);
			//                                 s_voxelizationMaterialPropertyBlock = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_voxelizationMaterialPropertyBlock;
			//                                 if ( !s_voxelizationMaterialPropertyBlock )
			//                                   break;
			//                                 UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                   (MaterialPropertyBlock *)s_voxelizationMaterialPropertyBlock,
			//                                   TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._VoxelizationVolumeRadius,
			//                                   v66,
			//                                   0LL);
			//                                 *(_QWORD *)&v125.x = v68;
			//                                 LODWORD(v125.z) = volumetricFogGridSize.m_X;
			//                                 v83 = UnityEngine::Vector4::op_Implicit(&v138, &v125, v82);
			//                                 if ( !v84 )
			//                                   break;
			//                                 v115 = *v83;
			//                                 UnityEngine::MaterialPropertyBlock::SetVector(
			//                                   v84,
			//                                   TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._VoxelizationViewSpacePos,
			//                                   &v115,
			//                                   0LL);
			//                                 v85 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_voxelizationMaterialPropertyBlock;
			//                                 volumetricFogGridSize.m_X = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._VoxelizationWorldToObject;
			//                                 v86 = UnityEngine::Component::get_transform(Item, 0LL);
			//                                 if ( !v86 )
			//                                   break;
			//                                 worldToLocalMatrix = UnityEngine::Transform::get_worldToLocalMatrix(&v132, v86, 0LL);
			//                                 if ( !v85 )
			//                                   break;
			//                                 v88 = *(_OWORD *)&worldToLocalMatrix.m01;
			//                                 *(_OWORD *)&v116.hasValue = *(_OWORD *)&worldToLocalMatrix.m00;
			//                                 v89 = *(_OWORD *)&worldToLocalMatrix.m02;
			//                                 *(_OWORD *)&v116.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v88;
			//                                 v90 = *(_OWORD *)&worldToLocalMatrix.m03;
			//                                 *(_OWORD *)&v116.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v89;
			//                                 *(_OWORD *)&v116.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v90;
			//                                 UnityEngine::MaterialPropertyBlock::SetMatrix(
			//                                   v85,
			//                                   volumetricFogGridSize.m_X,
			//                                   (Matrix4x4 *)&v116,
			//                                   0LL);
			//                                 if ( UnityEngine::SystemInfo::SupportsRenderTargetArrayIndexFromVertexShader(0LL) )
			//                                 {
			//                                   v98 = 0LL;
			//                                   if ( v74 > 0 )
			//                                   {
			//                                     v99 = v126.m_Buffer;
			//                                     do
			//                                     {
			//                                       v100 = UnityEngine::Component::get_transform(Item, 0LL);
			//                                       if ( !v100 )
			//                                         goto LABEL_60;
			//                                       localToWorldMatrix = UnityEngine::Transform::get_localToWorldMatrix(
			//                                                              (Matrix4x4 *)&v116,
			//                                                              v100,
			//                                                              0LL);
			//                                       ++v98;
			//                                       v102 = *(_OWORD *)&localToWorldMatrix.m01;
			//                                       v103 = *(_OWORD *)&localToWorldMatrix.m02;
			//                                       v104 = *(_OWORD *)&localToWorldMatrix.m03;
			//                                       *(_OWORD *)v99 = *(_OWORD *)&localToWorldMatrix.m00;
			//                                       *(_OWORD *)&v99[16] = v102;
			//                                       *(_OWORD *)&v99[32] = v103;
			//                                       *(_OWORD *)&v99[48] = v104;
			//                                       v99 += 64;
			//                                     }
			//                                     while ( v98 < v74 );
			//                                   }
			//                                   Unity::Collections::NativeArray<MagicaCloth::PhysicsManagerMeshData::SharedRenderMeshInfo>::GetSubArray(
			//                                     (NativeArray_1_MagicaCloth_PhysicsManagerMeshData_SharedRenderMeshInfo_ *)&v127,
			//                                     (NativeArray_1_MagicaCloth_PhysicsManagerMeshData_SharedRenderMeshInfo_ *)&v126,
			//                                     0,
			//                                     v74,
			//                                     MethodInfo::Unity::Collections::NativeArray<UnityEngine::Matrix4x4>::GetSubArray);
			//                                   quadMesh = HG::Rendering::Runtime::HGVolumetricFogUtils::get_quadMesh(0LL);
			//                                   v106 = (Material *)Item[1].klass;
			//                                   sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//                                   sub_1802F01E0(v136, 0LL, 112LL);
			//                                   if ( !cmd )
			//                                     break;
			//                                   *(_OWORD *)&v116.hasValue = v136[0];
			//                                   v107 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields;
			//                                   *(_OWORD *)&v116.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v136[1];
			//                                   *(_OWORD *)&v116.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v136[2];
			//                                   v109 = v107.s_voxelizationMaterialPropertyBlock;
			//                                   *(_OWORD *)&v116.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v136[3];
			//                                   *(_OWORD *)&v116.value.m_BlendState.m_BlendState7.m_DestinationAlphaBlendMode = v136[4];
			//                                   *(_OWORD *)&v116.value.m_RasterState.m_OffsetFactor = v136[5];
			//                                   *(_OWORD *)&v116.value.m_StencilState.m_FailOperationFront = v136[6];
			//                                   v115 = v127;
			//                                   UnityEngine::Rendering::CommandBuffer::DrawMeshInstanced(
			//                                     cmd,
			//                                     quadMesh,
			//                                     0,
			//                                     v106,
			//                                     -1,
			//                                     (NativeArray_1_UnityEngine_Matrix4x4_ *)&v115,
			//                                     v74,
			//                                     v109,
			//                                     &v116,
			//                                     0LL);
			//                                 }
			//                                 else
			//                                 {
			//                                   v91 = 0;
			//                                   if ( v74 > 0 )
			//                                   {
			//                                     do
			//                                     {
			//                                       UnityEngine::Rendering::RenderTargetIdentifier::RenderTargetIdentifier(
			//                                         &v130,
			//                                         (Texture *)passData.fields.vBufferA,
			//                                         0,
			//                                         CubemapFace__Enum_Unknown,
			//                                         v72 + v91,
			//                                         0LL);
			//                                       if ( !cmd )
			//                                         goto LABEL_60;
			//                                       *(_OWORD *)&v114.m00 = *(_OWORD *)&v130.m_Type;
			//                                       *(_QWORD *)&v114.m02 = *(_QWORD *)&v130.m_DepthSlice;
			//                                       *(_OWORD *)&v114.m01 = *(_OWORD *)&v130.m_BufferPointer;
			//                                       UnityEngine::Rendering::CommandBuffer::SetRenderTarget(
			//                                         cmd,
			//                                         (RenderTargetIdentifier *)&v114,
			//                                         RenderBufferLoadAction__Enum_Load,
			//                                         RenderBufferStoreAction__Enum_Store,
			//                                         0LL);
			//                                       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//                                       *(_QWORD *)&volumetricFogGridSize.m_X = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_voxelizationMaterialPropertyBlock;
			//                                       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                                       s_voxelizationMaterialPropertyBlock = *(void **)&volumetricFogGridSize.m_X;
			//                                       if ( !*(_QWORD *)&volumetricFogGridSize.m_X )
			//                                         goto LABEL_60;
			//                                       UnityEngine::MaterialPropertyBlock::SetFloatImpl(
			//                                         *(MaterialPropertyBlock **)&volumetricFogGridSize.m_X,
			//                                         TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._VoxelizationPassIndex,
			//                                         (float)v91,
			//                                         0LL);
			//                                       *(_QWORD *)&volumetricFogGridSize.m_X = HG::Rendering::Runtime::HGVolumetricFogUtils::get_quadMesh(0LL);
			//                                       v92 = UnityEngine::Component::get_transform(Item, 0LL);
			//                                       if ( !v92 )
			//                                         goto LABEL_60;
			//                                       v93 = UnityEngine::Transform::get_localToWorldMatrix(&v132, v92, 0LL);
			//                                       v94 = (Material *)Item[1].klass;
			//                                       v95 = *(_OWORD *)&v93.m01;
			//                                       *(_OWORD *)&v116.hasValue = *(_OWORD *)&v93.m00;
			//                                       v96 = *(_OWORD *)&v93.m02;
			//                                       *(_OWORD *)&v116.value.m_BlendState.m_BlendState1.m_DestinationAlphaBlendMode = v95;
			//                                       v97 = *(_OWORD *)&v93.m03;
			//                                       *(_OWORD *)&v116.value.m_BlendState.m_BlendState3.m_DestinationAlphaBlendMode = v96;
			//                                       *(_OWORD *)&v116.value.m_BlendState.m_BlendState5.m_DestinationAlphaBlendMode = v97;
			//                                       UnityEngine::Rendering::CommandBuffer::DrawMesh(
			//                                         cmd,
			//                                         *(Mesh **)&volumetricFogGridSize.m_X,
			//                                         (Matrix4x4 *)&v116,
			//                                         v94,
			//                                         0,
			//                                         -1,
			//                                         TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_voxelizationMaterialPropertyBlock,
			//                                         0LL);
			//                                     }
			//                                     while ( ++v91 < v74 );
			//                                   }
			//                                 }
			//                                 v6 = (Object *)this;
			//                                 hgCamera = v113;
			//                               }
			//                             }
			//                             v11 = v111;
			//                           }
			//                           ++v45;
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
			// LABEL_60:
			//       sub_180B536AC(s_voxelizationMaterialPropertyBlock, static_fields);
			//     }
			//   }
			// }
			// 
		}

		public void ComputeVolumetricFogLightScattering(CommandBuffer cmd, ScriptableRenderContext renderContext, bool hasGridInjectionPass, VolumetricFogPassConstructor.ComputeVolumetricFogPassData passData)
		{
			// // Void ComputeVolumetricFogLightScattering(CommandBuffer, ScriptableRenderContext, Boolean, VolumetricFogPassConstructor+ComputeVolumetricFogPassData)
			// void HG::Rendering::Runtime::HGVolumetricFogRenderer::ComputeVolumetricFogLightScattering(
			//         HGVolumetricFogRenderer *this,
			//         CommandBuffer *cmd,
			//         ScriptableRenderContext renderContext,
			//         bool hasGridInjectionPass,
			//         VolumetricFogPassConstructor_ComputeVolumetricFogPassData *passData,
			//         MethodInfo *method)
			// {
			//   __int64 v9; // rdx
			//   void *s_settingParameters; // rcx
			//   VolumetricFogPassConstructor_ComputeVolumetricFogPassData *v11; // rdi
			//   int32_t memoryless_k__BackingField; // eax
			//   __int128 v13; // xmm1
			//   __int128 v14; // xmm0
			//   HGRenderPathBase_HGRenderPathResources *v15; // rdx
			//   PassConstructorID__Enum__Array *v16; // r8
			//   HGCamera *v17; // r9
			//   HGCamera *hgCamera; // r13
			//   ComputeShader *volumetricFogLightScatteringCS; // rsi
			//   bool IsValid; // r12
			//   HGCamera *v21; // rbx
			//   __int64 v22; // rdx
			//   HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *v23; // rcx
			//   HGEnvironmentPhase *InterpolatedPhase; // r15
			//   bool v25; // al
			//   HGVolumetricFogRenderer__StaticFields *static_fields; // rcx
			//   bool v27; // al
			//   bool flowVLNoiseEnabled; // al
			//   float historyVolumetricLightScatteringPreExposure; // xmm8_4
			//   __int128 v30; // xmm0
			//   __int128 v31; // xmm1
			//   __int128 v32; // xmm0
			//   __int128 v33; // xmm1
			//   __int128 v34; // xmm0
			//   __int128 v35; // xmm1
			//   SHCoefficientsL1 *CoefficientsL1; // rax
			//   Vector4 shAr; // xmm11
			//   Vector4 shAg; // xmm12
			//   Vector4 shAb; // xmm13
			//   Vector3 *v40; // rax
			//   float volumetricFogExtinctionScale; // xmm7_4
			//   __int64 v42; // xmm6_8
			//   float z; // ebx
			//   Vector4 *v44; // rax
			//   Vector4 v45; // xmm0
			//   Vector4 *v46; // rax
			//   bool v47; // zf
			//   float v48; // xmm7_4
			//   float v49; // xmm10_4
			//   float v50; // xmm6_4
			//   MethodInfo *v51; // rdx
			//   Vector3 *fwd; // rax
			//   Quaternion rotationAtmosphere; // xmm0
			//   __int64 v54; // xmm3_8
			//   Vector3 *v55; // rax
			//   MethodInfo *v56; // r8
			//   Vector3 *v57; // rax
			//   float historyMissSuperSampleCount; // xmm2_4
			//   Vector4 *v59; // rax
			//   Vector4 v60; // xmm0
			//   Vector4 v61; // xmm0
			//   Vector3 *v62; // rax
			//   float directIntensity; // xmm2_4
			//   MethodInfo *v64; // r9
			//   Vector3 *v65; // rax
			//   __int64 v66; // xmm3_8
			//   Vector4 *v67; // rax
			//   __int64 v68; // xmm1_8
			//   float flowVLNoiseSpeed; // xmm2_4
			//   MethodInfo *v70; // r9
			//   Vector3 *v71; // rax
			//   __int64 v72; // xmm3_8
			//   Vector4 *v73; // rax
			//   float v74; // xmm9_4
			//   float flowVLNoiseTilling; // xmm2_4
			//   Vector4 *v76; // rax
			//   __int64 v77; // rdx
			//   _OWORD *v78; // rcx
			//   Vector4 v79; // xmm0
			//   Void *p_source; // rax
			//   __int128 v81; // xmm1
			//   __int128 v82; // xmm0
			//   __int128 v83; // xmm1
			//   __int128 v84; // xmm0
			//   __int128 v85; // xmm1
			//   __int128 v86; // xmm0
			//   __int128 v87; // xmm1
			//   __int128 v88; // xmm1
			//   __int128 v89; // xmm0
			//   CBHandle *v90; // rax
			//   __m128i v91; // xmm6
			//   int32_t VolumetricFogVBufferA; // ebx
			//   RenderTargetIdentifier *v93; // rax
			//   __int128 v94; // xmm1
			//   __int64 v95; // xmm0_8
			//   int32_t VolumetricFogVBufferB; // ebx
			//   RenderTargetIdentifier *v97; // rax
			//   __int128 v98; // xmm1
			//   __int64 v99; // xmm0_8
			//   int32_t VolumetricLight3DNoise; // ebx
			//   RenderTargetIdentifier *v101; // rax
			//   __int128 v102; // xmm1
			//   __int64 v103; // xmm0_8
			//   int32_t LightScattering; // ebx
			//   RenderTargetIdentifier *v105; // rax
			//   __int128 v106; // xmm1
			//   __int64 v107; // xmm0_8
			//   int32_t LightScatteringHistory; // ebx
			//   Texture *volumetricBlackTexture3D; // rdx
			//   RenderTargetIdentifier *v110; // rax
			//   __int128 v111; // xmm1
			//   __int64 v112; // xmm0_8
			//   TextureHandle punctualLightShadowResult; // xmm6
			//   int32_t PunctualLightShadowTexV2; // ebx
			//   RenderTargetIdentifier *v115; // rax
			//   __int128 v116; // xmm1
			//   __int64 v117; // xmm0_8
			//   float v118; // eax
			//   MethodInfo *offset; // [rsp+28h] [rbp-E0h]
			//   MethodInfo *size; // [rsp+30h] [rbp-D8h]
			//   Vector3 threadGroupsX; // [rsp+48h] [rbp-C0h] BYREF
			//   bool v122; // [rsp+58h] [rbp-B0h]
			//   LocalKeyword keyword; // [rsp+60h] [rbp-A8h] BYREF
			//   __int128 v124; // [rsp+78h] [rbp-90h]
			//   __int64 v125; // [rsp+88h] [rbp-80h]
			//   RenderTargetIdentifier v126; // [rsp+98h] [rbp-70h] BYREF
			//   Color volumetricFogAlbedo; // [rsp+C8h] [rbp-40h] BYREF
			//   RenderTextureDescriptor v128; // [rsp+D8h] [rbp-30h] BYREF
			//   LocalKeyword v129; // [rsp+118h] [rbp+10h] BYREF
			//   LocalKeyword v130; // [rsp+130h] [rbp+28h] BYREF
			//   LocalKeyword v131; // [rsp+148h] [rbp+40h] BYREF
			//   LocalKeyword v132; // [rsp+160h] [rbp+58h] BYREF
			//   LocalKeyword v133; // [rsp+178h] [rbp+70h] BYREF
			//   SphericalHarmonicsL2 v134; // [rsp+198h] [rbp+90h] BYREF
			//   _OWORD v135[27]; // [rsp+208h] [rbp+100h] BYREF
			//   Void source; // [rsp+3B8h] [rbp+2B0h] BYREF
			//   Void destination; // [rsp+468h] [rbp+360h] BYREF
			//   ScriptableRenderContext P2; // [rsp+638h] [rbp+530h] BYREF
			//   bool value; // [rsp+640h] [rbp+538h]
			// 
			//   value = hasGridInjectionPass;
			//   P2.m_Ptr = renderContext.m_Ptr;
			//   if ( !byte_18D919D99 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     sub_18003C530(&MethodInfo::Unity::Collections::LowLevel::Unsafe::NativeArrayUnsafeUtility::GetUnsafePtr<UnityEngine::Vector4>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//     sub_18003C530(&TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//     sub_18003C530(&off_18D5E7B40);
			//     sub_18003C530(&off_18D5E7B30);
			//     sub_18003C530(&off_18D5E7B68);
			//     sub_18003C530(&off_18C8F12F0);
			//     sub_18003C530(&off_18D5E7B60);
			//     sub_18003C530(&off_18D5E7B50);
			//     sub_18003C530(&off_18D5E7AE8);
			//     byte_18D919D99 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1302, 0LL) )
			//   {
			//     v11 = passData;
			//     if ( passData )
			//     {
			//       memoryless_k__BackingField = passData.fields.volumeDesc._memoryless_k__BackingField;
			//       v13 = *(_OWORD *)&passData.fields.volumeDesc._mipCount_k__BackingField;
			//       *(_OWORD *)&v128._width_k__BackingField = *(_OWORD *)&passData.fields.volumeDesc._width_k__BackingField;
			//       v14 = *(_OWORD *)&passData.fields.volumeDesc._dimension_k__BackingField;
			//       v128._memoryless_k__BackingField = memoryless_k__BackingField;
			//       *(_OWORD *)&v128._mipCount_k__BackingField = v13;
			//       *(_OWORD *)&v128._dimension_k__BackingField = v14;
			//       v11.fields.lightScattering = HG::Rendering::Runtime::HGVolumetricFogUtils::GetAndCreateTemporaryRenderTexture(
			//                                       &v128,
			//                                       (String *)"_LightScattering",
			//                                       0LL);
			//       sub_1800054D0((HGRenderPathScene *)&v11.fields.lightScattering, v15, v16, v17, offset, size);
			//       hgCamera = v11.fields.hgCamera;
			//       volumetricFogLightScatteringCS = v11.fields.volumetricFogLightScatteringCS;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//       s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//       if ( s_settingParameters )
			//       {
			//         if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                *((SettingParameter_1_System_Boolean_ **)s_settingParameters + 13),
			//                MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit)
			//           && v11.fields.punctualLightShadowActive )
			//         {
			//           sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//           IsValid = HG::Rendering::RenderGraphModule::TextureHandle::IsValid(
			//                       &v11.fields.punctualLightShadowResult,
			//                       0LL);
			//         }
			//         else
			//         {
			//           IsValid = 0;
			//         }
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//         s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//         if ( s_settingParameters )
			//         {
			//           v122 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                    *((SettingParameter_1_System_Boolean_ **)s_settingParameters + 15),
			//                    MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit)
			//               && (UnityEngine::SystemInfo::GetWaveIntrinsicsSupportedStages(0LL) & 0x20) != 0
			//               && (UnityEngine::SystemInfo::GetWaveIntrinsicsSupportedOperations(0LL) & 5) != 0;
			//           v21 = v11.fields.hgCamera;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGEnvironmentManager);
			//           InterpolatedPhase = HG::Rendering::Runtime::HGEnvironmentManager::GetInterpolatedPhase(v21, 0LL);
			//           if ( !InterpolatedPhase )
			//             goto LABEL_43;
			//           memset(&v129, 0, sizeof(v129));
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//             &v129,
			//             volumetricFogLightScatteringCS,
			//             (String *)"HAS_GRID_INJECTION_PASS",
			//             0LL);
			//           *(_QWORD *)&v124 = *(_QWORD *)&v129.m_Index;
			//           *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v129.m_SpaceInfo.m_KeywordSpace;
			//           if ( !cmd )
			//             goto LABEL_43;
			//           UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//             cmd,
			//             volumetricFogLightScatteringCS,
			//             (LocalKeyword *)&keyword.m_Name,
			//             value,
			//             0LL);
			//           memset(&v130, 0, sizeof(v130));
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//             &v130,
			//             volumetricFogLightScatteringCS,
			//             (String *)"ENABLE_EMISSIVE_VBUFFER_B",
			//             0LL);
			//           *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v130.m_SpaceInfo.m_KeywordSpace;
			//           *(_QWORD *)&v124 = *(_QWORD *)&v130.m_Index;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//           v23 = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//           if ( !v23 )
			//             goto LABEL_43;
			//           v25 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                   v23.fields.enableEmissiveVBufferB,
			//                   MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//           UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//             cmd,
			//             volumetricFogLightScatteringCS,
			//             (LocalKeyword *)&keyword.m_Name,
			//             v25,
			//             0LL);
			//           memset(&v131, 0, sizeof(v131));
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//             &v131,
			//             volumetricFogLightScatteringCS,
			//             (String *)"ENABLE_TEMPORAL_REPROJECTION",
			//             0LL);
			//           static_fields = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields;
			//           *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v131.m_SpaceInfo.m_KeywordSpace;
			//           *(_QWORD *)&v124 = *(_QWORD *)&v131.m_Index;
			//           v23 = static_fields.s_settingParameters;
			//           if ( !v23 )
			// LABEL_43:
			//             sub_180B536AC(v23, v22);
			//           v27 = HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                   v23.fields.enableTemporalReprojection,
			//                   MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//           UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//             cmd,
			//             volumetricFogLightScatteringCS,
			//             (LocalKeyword *)&keyword.m_Name,
			//             v27,
			//             0LL);
			//           memset(&v132, 0, sizeof(v132));
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//             &v132,
			//             volumetricFogLightScatteringCS,
			//             (String *)"ENABLE_VOLUMETRIC_LIGHT_FLOW_NOISE",
			//             0LL);
			//           *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v132.m_SpaceInfo.m_KeywordSpace;
			//           *(_QWORD *)&v124 = *(_QWORD *)&v132.m_Index;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
			//           flowVLNoiseEnabled = HG::Rendering::Runtime::HGVolumetricFogConfig::get_flowVLNoiseEnabled(
			//                                  &InterpolatedPhase.fields.volumetricFogConfig,
			//                                  0LL);
			//           UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//             cmd,
			//             volumetricFogLightScatteringCS,
			//             (LocalKeyword *)&keyword.m_Name,
			//             flowVLNoiseEnabled,
			//             0LL);
			//           memset(&v133, 0, sizeof(v133));
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//             &v133,
			//             volumetricFogLightScatteringCS,
			//             (String *)"ENABLE_SCALARIZE_DYNAMIC_LIGHTLOOP",
			//             0LL);
			//           *(_QWORD *)&v124 = *(_QWORD *)&v133.m_Index;
			//           *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v133.m_SpaceInfo.m_KeywordSpace;
			//           UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//             cmd,
			//             volumetricFogLightScatteringCS,
			//             (LocalKeyword *)&keyword.m_Name,
			//             v122,
			//             0LL);
			//           memset(&v126, 0, 24);
			//           UnityEngine::Rendering::LocalKeyword::LocalKeyword(
			//             (LocalKeyword *)&v126,
			//             volumetricFogLightScatteringCS,
			//             (String *)"HG_DISABLE_PUNCTUAL_LIGHT_SHADOW",
			//             0LL);
			//           *(_QWORD *)&v124 = v126.m_BufferPointer;
			//           *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v126.m_Type;
			//           UnityEngine::Rendering::CommandBuffer::SetKeyword(
			//             cmd,
			//             volumetricFogLightScatteringCS,
			//             (LocalKeyword *)&keyword.m_Name,
			//             !IsValid,
			//             0LL);
			//           if ( v11.fields.temporalHistoryIsValid )
			//           {
			//             if ( !hgCamera )
			//               goto LABEL_45;
			//             historyVolumetricLightScatteringPreExposure = hgCamera.fields.historyVolumetricLightScatteringPreExposure;
			//           }
			//           else
			//           {
			//             historyVolumetricLightScatteringPreExposure = 1.0;
			//           }
			//           v30 = *(_OWORD *)&InterpolatedPhase.fields.skyConfig.skyAmbientSH.shr0;
			//           v31 = *(_OWORD *)&InterpolatedPhase.fields.skyConfig.skyAmbientSH.shr4;
			//           v134.shb8 = InterpolatedPhase.fields.skyConfig.skyAmbientSH.shb8;
			//           *(_OWORD *)&v134.shr0 = v30;
			//           v32 = *(_OWORD *)&InterpolatedPhase.fields.skyConfig.skyAmbientSH.shr8;
			//           *(_OWORD *)&v134.shr4 = v31;
			//           v33 = *(_OWORD *)&InterpolatedPhase.fields.skyConfig.skyAmbientSH.shg3;
			//           *(_OWORD *)&v134.shr8 = v32;
			//           v34 = *(_OWORD *)&InterpolatedPhase.fields.skyConfig.skyAmbientSH.shg7;
			//           *(_OWORD *)&v134.shg3 = v33;
			//           v35 = *(_OWORD *)&InterpolatedPhase.fields.skyConfig.skyAmbientSH.shb2;
			//           *(_OWORD *)&v134.shg7 = v34;
			//           *(_QWORD *)&v134.shb6 = *(_QWORD *)&InterpolatedPhase.fields.skyConfig.skyAmbientSH.shb6;
			//           *(_OWORD *)&v134.shb2 = v35;
			//           CoefficientsL1 = HG::Rendering::Runtime::HGEnvironmentUtils::GetCoefficientsL1(
			//                              (SHCoefficientsL1 *)&v128,
			//                              &v134,
			//                              0LL);
			//           shAr = CoefficientsL1.shAr;
			//           shAg = CoefficientsL1.shAg;
			//           shAb = CoefficientsL1.shAb;
			//           sub_1802F01E0(v135, 0LL, 432LL);
			//           volumetricFogAlbedo = InterpolatedPhase.fields.volumetricFogConfig.volumetricFogAlbedo;
			//           v40 = HG::Rendering::Runtime::VectorSwizzleUtils::rgb(&threadGroupsX, &volumetricFogAlbedo, 0LL);
			//           volumetricFogExtinctionScale = InterpolatedPhase.fields.volumetricFogConfig.volumetricFogExtinctionScale;
			//           v42 = *(_QWORD *)&v40.x;
			//           z = v40.z;
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//           *(_QWORD *)&threadGroupsX.x = v42;
			//           threadGroupsX.z = z;
			//           v44 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                   (Vector4 *)&keyword.m_Name,
			//                   &threadGroupsX,
			//                   volumetricFogExtinctionScale,
			//                   0LL);
			//           *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&v11.fields.volumetricFogEmissive.x;
			//           v45 = *v44;
			//           threadGroupsX.z = v11.fields.volumetricFogEmissive.z;
			//           v135[0] = v45;
			//           v46 = HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)&keyword.m_Name, &threadGroupsX, 0LL);
			//           v47 = !v11.fields.temporalHistoryIsValid;
			//           v135[1] = *v46;
			//           if ( v47 )
			//           {
			//             v48 = 0.0;
			//           }
			//           else
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//             s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//             if ( !s_settingParameters )
			//               goto LABEL_45;
			//             v48 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                     *((SettingParameter_1_System_Single_ **)s_settingParameters + 9),
			//                     MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//           }
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//           s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//           if ( s_settingParameters )
			//           {
			//             v49 = HG::Rendering::Runtime::SettingParameter<float>::op_Implicit(
			//                     *((SettingParameter_1_System_Single_ **)s_settingParameters + 10),
			//                     MethodInfo::HG::Rendering::Runtime::SettingParameter<float>::op_Implicit);
			//             v50 = 1.0;
			//             if ( historyVolumetricLightScatteringPreExposure > 0.0 )
			//               v50 = 1.0 / historyVolumetricLightScatteringPreExposure;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//             v135[2] = *HG::Rendering::Runtime::HGUtils::PackVector4(
			//                          (Vector4 *)&keyword.m_Name,
			//                          v48,
			//                          v49,
			//                          historyVolumetricLightScatteringPreExposure,
			//                          v50,
			//                          0LL);
			//             fwd = UnityEngine::Vector3::get_fwd((Vector3 *)&volumetricFogAlbedo, v51);
			//             rotationAtmosphere = InterpolatedPhase.fields.lightConfig.rotationAtmosphere;
			//             v54 = *(_QWORD *)&fwd.x;
			//             *(float *)&fwd = fwd.z;
			//             *(_QWORD *)&threadGroupsX.x = v54;
			//             LODWORD(threadGroupsX.z) = (_DWORD)fwd;
			//             *(Quaternion *)&keyword.m_Name = rotationAtmosphere;
			//             v55 = UnityEngine::Quaternion::op_Multiply(
			//                     (Vector3 *)&volumetricFogAlbedo,
			//                     (Quaternion *)&keyword.m_Name,
			//                     &threadGroupsX,
			//                     0LL);
			//             *(_QWORD *)&rotationAtmosphere.x = *(_QWORD *)&v55.x;
			//             *(float *)&v55 = v55.z;
			//             *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&rotationAtmosphere.x;
			//             LODWORD(threadGroupsX.z) = (_DWORD)v55;
			//             v57 = UnityEngine::Vector3::op_UnaryNegation((Vector3 *)&volumetricFogAlbedo, &threadGroupsX, v56);
			//             historyMissSuperSampleCount = (float)v11.fields.historyMissSuperSampleCount;
			//             *(_QWORD *)&rotationAtmosphere.x = *(_QWORD *)&v57.x;
			//             *(float *)&v57 = v57.z;
			//             *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&rotationAtmosphere.x;
			//             LODWORD(threadGroupsX.z) = (_DWORD)v57;
			//             v59 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                     (Vector4 *)&keyword.m_Name,
			//                     &threadGroupsX,
			//                     historyMissSuperSampleCount,
			//                     0LL);
			//             v135[4] = shAr;
			//             v135[5] = shAg;
			//             v135[6] = shAb;
			//             v60 = *v59;
			//             threadGroupsX.z = v11.fields.volumetricFogEmissive.z;
			//             v135[3] = v60;
			//             *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&v11.fields.volumetricFogEmissive.x;
			//             v61 = *HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)&keyword.m_Name, &threadGroupsX, 0LL);
			//             *(Color *)&keyword.m_Name = InterpolatedPhase.fields.lightConfig.directColor;
			//             v135[7] = v61;
			//             v62 = HG::Rendering::Runtime::VectorSwizzleUtils::rgb(
			//                     (Vector3 *)&volumetricFogAlbedo,
			//                     (Color *)&keyword.m_Name,
			//                     0LL);
			//             directIntensity = InterpolatedPhase.fields.lightConfig.directIntensity;
			//             *(_QWORD *)&v61.x = *(_QWORD *)&v62.x;
			//             *(float *)&v62 = v62.z;
			//             *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&v61.x;
			//             LODWORD(threadGroupsX.z) = (_DWORD)v62;
			//             v65 = UnityEngine::Vector3::op_Multiply(
			//                     (Vector3 *)&volumetricFogAlbedo,
			//                     &threadGroupsX,
			//                     directIntensity,
			//                     v64);
			//             v66 = *(_QWORD *)&v65.x;
			//             *(float *)&v65 = v65.z;
			//             *(_QWORD *)&threadGroupsX.x = v66;
			//             LODWORD(threadGroupsX.z) = (_DWORD)v65;
			//             v67 = HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)&keyword.m_Name, &threadGroupsX, 0LL);
			//             v68 = *(_QWORD *)&InterpolatedPhase.fields.volumetricFogConfig.flowVLNoiseDir.x;
			//             v135[8] = *v67;
			//             flowVLNoiseSpeed = InterpolatedPhase.fields.volumetricFogConfig.flowVLNoiseSpeed;
			//             threadGroupsX.z = InterpolatedPhase.fields.volumetricFogConfig.flowVLNoiseDir.z;
			//             *(_QWORD *)&threadGroupsX.x = v68;
			//             v71 = UnityEngine::Vector3::op_Multiply(
			//                     (Vector3 *)&volumetricFogAlbedo,
			//                     &threadGroupsX,
			//                     flowVLNoiseSpeed,
			//                     v70);
			//             v72 = *(_QWORD *)&v71.x;
			//             *(float *)&v71 = v71.z;
			//             *(_QWORD *)&threadGroupsX.x = v72;
			//             LODWORD(threadGroupsX.z) = (_DWORD)v71;
			//             v73 = HG::Rendering::Runtime::HGUtils::PackVector4((Vector4 *)&keyword.m_Name, &threadGroupsX, 0LL);
			//             v74 = 1.0 / InterpolatedPhase.fields.volumetricFogConfig.flowVLNoiseDistance;
			//             flowVLNoiseTilling = InterpolatedPhase.fields.volumetricFogConfig.flowVLNoiseTilling;
			//             *(float *)&v68 = InterpolatedPhase.fields.volumetricFogConfig.flowVLNoiseIntensity;
			//             v135[9] = *v73;
			//             v76 = HG::Rendering::Runtime::HGUtils::PackVector4(
			//                     (Vector4 *)&keyword.m_Name,
			//                     *(float *)&v68,
			//                     flowVLNoiseTilling,
			//                     v74,
			//                     0LL);
			//             v77 = 3LL;
			//             v78 = v135;
			//             v79 = *v76;
			//             p_source = &source;
			//             v135[10] = v79;
			//             do
			//             {
			//               v81 = v78[1];
			//               *(_OWORD *)p_source = *v78;
			//               v82 = v78[2];
			//               *(_OWORD *)&p_source[16] = v81;
			//               v83 = v78[3];
			//               *(_OWORD *)&p_source[32] = v82;
			//               v84 = v78[4];
			//               *(_OWORD *)&p_source[48] = v83;
			//               v85 = v78[5];
			//               *(_OWORD *)&p_source[64] = v84;
			//               v86 = v78[6];
			//               *(_OWORD *)&p_source[80] = v85;
			//               v87 = v78[7];
			//               v78 += 8;
			//               *(_OWORD *)&p_source[96] = v86;
			//               p_source += 128;
			//               *(_OWORD *)&p_source[-16] = v87;
			//               --v77;
			//             }
			//             while ( v77 );
			//             v88 = v78[1];
			//             *(_OWORD *)p_source = *v78;
			//             v89 = v78[2];
			//             *(_OWORD *)&p_source[16] = v88;
			//             *(_OWORD *)&p_source[32] = v89;
			//             Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy(
			//               &destination,
			//               v11.fields.frameJitterOffsetValues.m_Buffer,
			//               256LL,
			//               0LL);
			//             sub_180002C70(TypeInfo::UnityEngine::Rendering::ScriptableRenderContext);
			//             v90 = UnityEngine::Rendering::ScriptableRenderContext::AllocateConstantBuffer(
			//                     (CBHandle *)&keyword.m_Name,
			//                     &P2,
			//                     432,
			//                     0LL);
			//             v91 = *(__m128i *)&v90.bufferId;
			//             *(_QWORD *)&v124 = v90.ptr;
			//             Unity::Collections::LowLevel::Unsafe::UnsafeUtility::MemCpy((Void *)v124, &source, 432LL, 0LL);
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//             UnityEngine::Rendering::CommandBuffer::Internal_SetComputeConstantBufferParam(
			//               cmd,
			//               volumetricFogLightScatteringCS,
			//               TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._VolumetricFogLightScatteringConstants,
			//               _mm_cvtsi128_si32(v91),
			//               _mm_cvtsi128_si32(_mm_srli_si128(v91, 4)),
			//               _mm_cvtsi128_si32(_mm_srli_si128(v91, 8)),
			//               0LL);
			//             if ( value )
			//             {
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//               VolumetricFogVBufferA = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._VolumetricFogVBufferA;
			//               v93 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                       (RenderTargetIdentifier *)&v128,
			//                       (Texture *)v11.fields.vBufferA,
			//                       0LL);
			//               v94 = *(_OWORD *)&v93.m_BufferPointer;
			//               *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v93.m_Type;
			//               v95 = *(_QWORD *)&v93.m_DepthSlice;
			//               v124 = v94;
			//               v125 = v95;
			//               UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//                 cmd,
			//                 volumetricFogLightScatteringCS,
			//                 0,
			//                 VolumetricFogVBufferA,
			//                 (RenderTargetIdentifier *)&keyword.m_Name,
			//                 0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//               s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//               if ( !s_settingParameters )
			//                 goto LABEL_45;
			//               if ( HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                      *((SettingParameter_1_System_Boolean_ **)s_settingParameters + 14),
			//                      MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//               {
			//                 sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//                 VolumetricFogVBufferB = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._VolumetricFogVBufferB;
			//                 v97 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                         (RenderTargetIdentifier *)&v128,
			//                         (Texture *)v11.fields.vBufferB,
			//                         0LL);
			//                 v98 = *(_OWORD *)&v97.m_BufferPointer;
			//                 *(_OWORD *)&keyword.m_Name = *(_OWORD *)&v97.m_Type;
			//                 v99 = *(_QWORD *)&v97.m_DepthSlice;
			//                 v124 = v98;
			//                 v125 = v99;
			//                 UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//                   cmd,
			//                   volumetricFogLightScatteringCS,
			//                   0,
			//                   VolumetricFogVBufferB,
			//                   (RenderTargetIdentifier *)&keyword.m_Name,
			//                   0LL);
			//               }
			//             }
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogConfig);
			//             if ( HG::Rendering::Runtime::HGVolumetricFogConfig::get_flowVLNoiseEnabled(
			//                    &InterpolatedPhase.fields.volumetricFogConfig,
			//                    0LL) )
			//             {
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//               VolumetricLight3DNoise = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._VolumetricLight3DNoise;
			//               v101 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                        (RenderTargetIdentifier *)&v128,
			//                        (Texture *)v11.fields.volumetricLight3DNoise,
			//                        0LL);
			//               v102 = *(_OWORD *)&v101.m_BufferPointer;
			//               *(_OWORD *)&v126.m_Type = *(_OWORD *)&v101.m_Type;
			//               v103 = *(_QWORD *)&v101.m_DepthSlice;
			//               *(_OWORD *)&v126.m_BufferPointer = v102;
			//               *(_QWORD *)&v126.m_DepthSlice = v103;
			//               UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//                 cmd,
			//                 volumetricFogLightScatteringCS,
			//                 0,
			//                 VolumetricLight3DNoise,
			//                 &v126,
			//                 0LL);
			//             }
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//             LightScattering = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LightScattering;
			//             v105 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                      (RenderTargetIdentifier *)&v128,
			//                      (Texture *)v11.fields.lightScattering,
			//                      0LL);
			//             v106 = *(_OWORD *)&v105.m_BufferPointer;
			//             *(_OWORD *)&v126.m_Type = *(_OWORD *)&v105.m_Type;
			//             v107 = *(_QWORD *)&v105.m_DepthSlice;
			//             *(_OWORD *)&v126.m_BufferPointer = v106;
			//             *(_QWORD *)&v126.m_DepthSlice = v107;
			//             UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//               cmd,
			//               volumetricFogLightScatteringCS,
			//               0,
			//               LightScattering,
			//               &v126,
			//               0LL);
			//             if ( !v11.fields.temporalHistoryIsValid )
			//             {
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//               LightScatteringHistory = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LightScatteringHistory;
			//               volumetricBlackTexture3D = (Texture *)HG::Rendering::Runtime::HGVolumetricFogUtils::get_volumetricBlackTexture3D(0LL);
			// LABEL_42:
			//               v110 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                        (RenderTargetIdentifier *)&v128,
			//                        volumetricBlackTexture3D,
			//                        0LL);
			//               v111 = *(_OWORD *)&v110.m_BufferPointer;
			//               *(_OWORD *)&v126.m_Type = *(_OWORD *)&v110.m_Type;
			//               v112 = *(_QWORD *)&v110.m_DepthSlice;
			//               *(_OWORD *)&v126.m_BufferPointer = v111;
			//               *(_QWORD *)&v126.m_DepthSlice = v112;
			//               UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//                 cmd,
			//                 volumetricFogLightScatteringCS,
			//                 0,
			//                 LightScatteringHistory,
			//                 &v126,
			//                 0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//               punctualLightShadowResult = v11.fields.punctualLightShadowResult;
			//               PunctualLightShadowTexV2 = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._PunctualLightShadowTexV2;
			//               sub_180002C70(TypeInfo::HG::Rendering::RenderGraphModule::TextureHandle);
			//               *(TextureHandle *)&keyword.m_Name = punctualLightShadowResult;
			//               v115 = HG::Rendering::RenderGraphModule::TextureHandle::op_Implicit(
			//                        (RenderTargetIdentifier *)&v128,
			//                        (TextureHandle *)&keyword.m_Name,
			//                        0LL);
			//               v116 = *(_OWORD *)&v115.m_BufferPointer;
			//               *(_OWORD *)&v126.m_Type = *(_OWORD *)&v115.m_Type;
			//               v117 = *(_QWORD *)&v115.m_DepthSlice;
			//               *(_OWORD *)&v126.m_BufferPointer = v116;
			//               *(_QWORD *)&v126.m_DepthSlice = v117;
			//               UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//                 cmd,
			//                 volumetricFogLightScatteringCS,
			//                 0,
			//                 PunctualLightShadowTexV2,
			//                 &v126,
			//                 0LL);
			//               v118 = *(float *)&v11.fields.volumetricFogGridSize.m_Z;
			//               *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&v11.fields.volumetricFogGridSize.m_X;
			//               threadGroupsX.z = v118;
			//               *(_QWORD *)&threadGroupsX.x = *(_QWORD *)&HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(
			//                                                           (Vector3Int *)&volumetricFogAlbedo,
			//                                                           (Vector3Int *)&threadGroupsX,
			//                                                           8,
			//                                                           0LL).m_X;
			//               UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//                 cmd,
			//                 volumetricFogLightScatteringCS,
			//                 0,
			//                 SLODWORD(threadGroupsX.x),
			//                 SLODWORD(threadGroupsX.y),
			//                 v11.fields.volumetricFogGridSize.m_Z,
			//                 0LL);
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//               HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&v11.fields.vBufferA, 0LL);
			//               HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&v11.fields.vBufferB, 0LL);
			//               return;
			//             }
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//             s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//             LightScatteringHistory = *((_DWORD *)s_settingParameters + 265);
			//             if ( hgCamera )
			//             {
			//               volumetricBlackTexture3D = (Texture *)hgCamera.fields.historyVolumetricLightScatteringTexture;
			//               goto LABEL_42;
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_45:
			//     sub_180B536AC(s_settingParameters, v9);
			//   }
			//   s_settingParameters = IFix::WrappersManagerImpl::GetPatch(1302, 0LL);
			//   if ( !s_settingParameters )
			//     goto LABEL_45;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_499(
			//     (ILFixDynamicMethodWrapper_2 *)s_settingParameters,
			//     (Object *)this,
			//     (Object *)cmd,
			//     P2,
			//     hasGridInjectionPass,
			//     (Object *)passData,
			//     0LL);
			// }
			// 
		}

		public void ComputeVolumetricFogFinalIntegration(CommandBuffer cmd, VolumetricFogPassConstructor.ComputeVolumetricFogPassData passData)
		{
			// // Void ComputeVolumetricFogFinalIntegration(CommandBuffer, VolumetricFogPassConstructor+ComputeVolumetricFogPassData)
			// void HG::Rendering::Runtime::HGVolumetricFogRenderer::ComputeVolumetricFogFinalIntegration(
			//         HGVolumetricFogRenderer *this,
			//         CommandBuffer *cmd,
			//         VolumetricFogPassConstructor_ComputeVolumetricFogPassData *passData,
			//         MethodInfo *method)
			// {
			//   HGCamera *v7; // rdx
			//   char *v8; // rcx
			//   int32_t memoryless_k__BackingField; // eax
			//   __int128 v10; // xmm1
			//   HGCamera *hgCamera; // rsi
			//   __int128 v12; // xmm0
			//   RenderTexture *v13; // rax
			//   PassConstructorID__Enum__Array *v14; // r8
			//   HGCamera *v15; // r9
			//   ComputeShader *volumetricFogFinalIntegrationCS; // rsi
			//   int32_t LightScattering; // r14d
			//   RenderTargetIdentifier *v18; // rax
			//   HGCamera *v19; // rdx
			//   HGShaderIDs__StaticFields *static_fields; // rcx
			//   __int128 v21; // xmm1
			//   __int64 v22; // xmm0_8
			//   int32_t RWIntegratedLightScattering; // r14d
			//   RenderTargetIdentifier *v24; // rax
			//   __int128 v25; // xmm1
			//   __int64 v26; // xmm0_8
			//   int32_t m_Z; // eax
			//   int32_t v28; // esi
			//   RenderTargetIdentifier *v29; // rax
			//   __int128 v30; // xmm1
			//   __int64 v31; // rdx
			//   HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *s_settingParameters; // rcx
			//   HGCamera *v33; // rdi
			//   PassConstructorID__Enum__Array *v34; // r8
			//   HGCamera *v35; // r9
			//   HGCamera *v36; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *threadGroupsY; // [rsp+28h] [rbp-59h]
			//   MethodInfo *threadGroupsYa; // [rsp+28h] [rbp-59h]
			//   MethodInfo *threadGroupsZ; // [rsp+30h] [rbp-51h]
			//   MethodInfo *threadGroupsZa; // [rsp+30h] [rbp-51h]
			//   Vector3Int threadGroupsX; // [rsp+48h] [rbp-39h] BYREF
			//   RenderTargetIdentifier v43; // [rsp+58h] [rbp-29h] BYREF
			//   RenderTextureDescriptor v44; // [rsp+88h] [rbp+7h] BYREF
			//   Vector3Int v45; // [rsp+C8h] [rbp+47h] BYREF
			// 
			//   if ( !byte_18D919D9A )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit);
			//     sub_18003C530(&off_18C8F0710);
			//     byte_18D919D9A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1305, 0LL) )
			//   {
			//     if ( passData )
			//     {
			//       memoryless_k__BackingField = passData.fields.volumeDesc._memoryless_k__BackingField;
			//       v10 = *(_OWORD *)&passData.fields.volumeDesc._mipCount_k__BackingField;
			//       hgCamera = passData.fields.hgCamera;
			//       *(_OWORD *)&v44._width_k__BackingField = *(_OWORD *)&passData.fields.volumeDesc._width_k__BackingField;
			//       v12 = *(_OWORD *)&passData.fields.volumeDesc._dimension_k__BackingField;
			//       v44._memoryless_k__BackingField = memoryless_k__BackingField;
			//       *(_OWORD *)&v44._mipCount_k__BackingField = v10;
			//       *(_OWORD *)&v44._dimension_k__BackingField = v12;
			//       v13 = HG::Rendering::Runtime::HGVolumetricFogUtils::GetAndCreateTemporaryRenderTexture(
			//               &v44,
			//               (String *)"_IntegratedLightScattering",
			//               0LL);
			//       if ( hgCamera )
			//       {
			//         hgCamera.fields.volumetricIntegratedLightScatteringTexture = v13;
			//         sub_1800054D0(
			//           (HGRenderPathScene *)&hgCamera.fields.volumetricIntegratedLightScatteringTexture,
			//           (HGRenderPathBase_HGRenderPathResources *)v7,
			//           v14,
			//           v15,
			//           threadGroupsY,
			//           threadGroupsZ);
			//         volumetricFogFinalIntegrationCS = passData.fields.volumetricFogFinalIntegrationCS;
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//         LightScattering = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._LightScattering;
			//         v18 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                 (RenderTargetIdentifier *)&v44,
			//                 (Texture *)passData.fields.lightScattering,
			//                 0LL);
			//         if ( !cmd )
			//           goto LABEL_17;
			//         v21 = *(_OWORD *)&v18.m_BufferPointer;
			//         *(_OWORD *)&v43.m_Type = *(_OWORD *)&v18.m_Type;
			//         v22 = *(_QWORD *)&v18.m_DepthSlice;
			//         *(_OWORD *)&v43.m_BufferPointer = v21;
			//         *(_QWORD *)&v43.m_DepthSlice = v22;
			//         UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//           cmd,
			//           volumetricFogFinalIntegrationCS,
			//           0,
			//           LightScattering,
			//           &v43,
			//           0LL);
			//         v19 = passData.fields.hgCamera;
			//         static_fields = TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         RWIntegratedLightScattering = static_fields._RWIntegratedLightScattering;
			//         if ( !v19 )
			// LABEL_17:
			//           sub_180B536AC(static_fields, v19);
			//         v24 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                 (RenderTargetIdentifier *)&v44,
			//                 (Texture *)v19.fields.volumetricIntegratedLightScatteringTexture,
			//                 0LL);
			//         v25 = *(_OWORD *)&v24.m_BufferPointer;
			//         *(_OWORD *)&v43.m_Type = *(_OWORD *)&v24.m_Type;
			//         v26 = *(_QWORD *)&v24.m_DepthSlice;
			//         *(_OWORD *)&v43.m_BufferPointer = v25;
			//         *(_QWORD *)&v43.m_DepthSlice = v26;
			//         UnityEngine::Rendering::CommandBuffer::SetComputeTextureParam(
			//           cmd,
			//           volumetricFogFinalIntegrationCS,
			//           0,
			//           RWIntegratedLightScattering,
			//           &v43,
			//           0LL);
			//         m_Z = passData.fields.volumetricFogGridSize.m_Z;
			//         *(_QWORD *)&threadGroupsX.m_X = *(_QWORD *)&passData.fields.volumetricFogGridSize.m_X;
			//         threadGroupsX.m_Z = m_Z;
			//         *(_QWORD *)&threadGroupsX.m_X = *(_QWORD *)&HG::Rendering::Runtime::HGVolumetricFogUtils::DivideAndRoundUp(
			//                                                       &v45,
			//                                                       &threadGroupsX,
			//                                                       8,
			//                                                       0LL).m_X;
			//         UnityEngine::Rendering::CommandBuffer::Internal_DispatchCompute(
			//           cmd,
			//           volumetricFogFinalIntegrationCS,
			//           0,
			//           threadGroupsX.m_X,
			//           threadGroupsX.m_Y,
			//           1,
			//           0LL);
			//         v7 = passData.fields.hgCamera;
			//         v8 = (char *)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//         v28 = *((_DWORD *)v8 + 267);
			//         if ( v7 )
			//         {
			//           v29 = UnityEngine::Rendering::RenderTargetIdentifier::op_Implicit(
			//                   (RenderTargetIdentifier *)&v44,
			//                   (Texture *)v7.fields.volumetricIntegratedLightScatteringTexture,
			//                   0LL);
			//           v30 = *(_OWORD *)&v29.m_BufferPointer;
			//           *(_OWORD *)&v43.m_Type = *(_OWORD *)&v29.m_Type;
			//           *(_QWORD *)&v43.m_DepthSlice = *(_QWORD *)&v29.m_DepthSlice;
			//           *(_OWORD *)&v43.m_BufferPointer = v30;
			//           UnityEngine::Rendering::CommandBuffer::SetGlobalTexture(cmd, v28, &v43, 0LL);
			//           sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer);
			//           s_settingParameters = TypeInfo::HG::Rendering::Runtime::HGVolumetricFogRenderer.static_fields.s_settingParameters;
			//           if ( !s_settingParameters )
			//             sub_180B536AC(0LL, v31);
			//           if ( !HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit(
			//                   s_settingParameters.fields.enableTemporalReprojection,
			//                   MethodInfo::HG::Rendering::Runtime::SettingParameter<bool>::op_Implicit) )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//             HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&passData.fields.lightScattering, 0LL);
			//             return;
			//           }
			//           v33 = passData.fields.hgCamera;
			//           if ( v33 )
			//           {
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//             HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(
			//               &v33.fields.historyVolumetricLightScatteringTexture,
			//               0LL);
			//             v8 = (char *)passData.fields.hgCamera;
			//             if ( v8 )
			//             {
			//               *((_QWORD *)v8 + 255) = passData.fields.lightScattering;
			//               sub_1800054D0(
			//                 (HGRenderPathScene *)(v8 + 2040),
			//                 (HGRenderPathBase_HGRenderPathResources *)v7,
			//                 v34,
			//                 v35,
			//                 threadGroupsYa,
			//                 threadGroupsZa);
			//               v36 = passData.fields.hgCamera;
			//               if ( v36 )
			//               {
			//                 v36.fields.historyVolumetricLightScatteringPreExposure = 1.0;
			//                 return;
			//               }
			//             }
			//           }
			//         }
			//       }
			//     }
			// LABEL_19:
			//     sub_180B536AC(v8, v7);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1305, 0LL);
			//   if ( !Patch )
			//     goto LABEL_19;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_11(
			//     (ILFixDynamicMethodWrapper_28 *)Patch,
			//     (Object *)this,
			//     (Object *)cmd,
			//     (Object *)passData,
			//     0LL);
			// }
			// 
		}

		public void ReleaseVolumetricFogTempRenderTexture(VolumetricFogPassConstructor.ComputeVolumetricFogPassData passData)
		{
			// // Void ReleaseVolumetricFogTempRenderTexture(VolumetricFogPassConstructor+ComputeVolumetricFogPassData)
			// void HG::Rendering::Runtime::HGVolumetricFogRenderer::ReleaseVolumetricFogTempRenderTexture(
			//         HGVolumetricFogRenderer *this,
			//         VolumetricFogPassConstructor_ComputeVolumetricFogPassData *passData,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   HGCamera *v6; // rcx
			//   HGCamera *hgCamera; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D919D9B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     byte_18D919D9B = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1306, 0LL) )
			//   {
			//     if ( passData )
			//     {
			//       hgCamera = passData.fields.hgCamera;
			//       if ( hgCamera )
			//       {
			//         sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//         HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(
			//           &hgCamera.fields.volumetricIntegratedLightScatteringTexture,
			//           0LL);
			//         v6 = passData.fields.hgCamera;
			//         if ( v6 )
			//         {
			//           HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(
			//             &v6.fields.historyVolumetricLightScatteringTexture,
			//             0LL);
			//           HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&passData.fields.vBufferA, 0LL);
			//           HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&passData.fields.vBufferB, 0LL);
			//           HG::Rendering::Runtime::HGUtils::ReleaseTemporaryRenderTexture(&passData.fields.lightScattering, 0LL);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_9:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1306, 0LL);
			//   if ( !Patch )
			//     goto LABEL_9;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//     (ILFixDynamicMethodWrapper_37 *)Patch,
			//     (Object *)this,
			//     (Object *)passData,
			//     0LL);
			// }
			// 
		}

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		public static readonly HGVolumetricFogRenderer.HGVolumetricFogSettingParameters s_settingParameters;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x08")]
		private static readonly MaterialPropertyBlock s_voxelizationMaterialPropertyBlock;

		public class HGVolumetricFogSettingParameters
		{
			// (get) Token: 0x0600067C RID: 1660 RVA: 0x000025D2 File Offset: 0x000007D2
			public Vector2Int maxSourceRTSize
			{
				get
				{
					// // Vector2Int get_maxSourceRTSize()
					// Vector2Int HG::Rendering::Runtime::HGVolumetricFogRenderer::HGVolumetricFogSettingParameters::get_maxSourceRTSize(
					//         HGVolumetricFogRenderer_HGVolumetricFogSettingParameters *this,
					//         MethodInfo *method)
					// {
					//   ILFixDynamicMethodWrapper_2 *Patch; // rax
					//   __int64 v5; // rdx
					//   __int64 v6; // rcx
					//   Vector2Int v7; // [rsp+40h] [rbp+18h]
					// 
					//   if ( !byte_18D919D9C )
					//   {
					//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
					//     byte_18D919D9C = 1;
					//   }
					//   if ( IFix::WrappersManagerImpl::IsPatched(1279, 0LL) )
					//   {
					//     Patch = IFix::WrappersManagerImpl::GetPatch(1279, 0LL);
					//     if ( !Patch )
					//       sub_180B536AC(v6, v5);
					//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_251(Patch, (Object *)this, 0LL);
					//   }
					//   else
					//   {
					//     v7.m_X = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
					//                (SettingParameter_1_System_Int32Enum_ *)this.fields.maxSourceRTWidth,
					//                MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
					//     v7.m_Y = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
					//                (SettingParameter_1_System_Int32Enum_ *)this.fields.maxSourceRTHeight,
					//                MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
					//     return v7;
					//   }
					// }
					// 
					return null;
				}
			}

			public HGVolumetricFogSettingParameters()
			{
			}

			public const string FEATURE_NAME = "VolumetricFog";

			public readonly SettingParameter<bool> enableVolumetricFog;

			public readonly SettingParameter<int> gridPixelSize;

			public readonly SettingParameter<int> gridSizeZ;

			public readonly SettingParameter<int> maxSourceRTWidth;

			public readonly SettingParameter<int> maxSourceRTHeight;

			public readonly SettingParameter<int> depthDistributionScale;

			public readonly SettingParameter<int> historyMissSuperSampleCount;

			public readonly SettingParameter<float> fogHistoryWeight;

			public readonly SettingParameter<float> lightScatteringSampleJitterMultiplier;

			public readonly SettingParameter<float> upsampleJitterMultiplier;

			public readonly SettingParameter<bool> enableTemporalReprojection;

			public readonly SettingParameter<bool> enablePunctualLightShadow;

			public readonly SettingParameter<bool> enableEmissiveVBufferB;

			public readonly SettingParameter<bool> enableScalarizeDynamicLightLoop;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 32)]
		public struct VolumetricFogGridInjectionConstants
		{
			public Vector4 _VolumetricFogGridInjectionParams0;

			public Vector4 _VolumetricFogGridInjectionParams1;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 432)]
		public struct VolumetricFogLightScatteringConstants
		{
			public Vector4 _VolumetricFogGridInjectionParams0;

			public Vector4 _VolumetricFogGridInjectionParams1;

			public Vector4 _VolumetricFogLightScatteringParams0;

			public Vector4 _VolumetricFogLightScatteringParams1;

			public Vector4 _VolumetricFogLightScatteringParams2;

			public Vector4 _VolumetricFogLightScatteringParams3;

			public Vector4 _VolumetricFogLightScatteringParams4;

			public Vector4 _VolumetricFogLightScatteringParams5;

			public Vector4 _VolumetricFogLightScatteringParams6;

			public Vector4 _VolumetricFogLightScatteringParams7;

			public Vector4 _VolumetricFogLightScatteringParams8;

			[FixedBuffer(typeof(float), 64)]
			public HGVolumetricFogRenderer.VolumetricFogLightScatteringConstants.<_LightScatteringFrameJitterOffsets>e__FixedBuffer _LightScatteringFrameJitterOffsets;

			[CompilerGenerated]
			[UnsafeValueType]
			[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 256)]
			public struct <_LightScatteringFrameJitterOffsets>e__FixedBuffer
			{
				public float FixedElementField;
			}
		}
	}
}
