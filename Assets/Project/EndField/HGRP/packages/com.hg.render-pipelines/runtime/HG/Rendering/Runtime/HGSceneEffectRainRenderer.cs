using System;
using HG.Rendering.Runtime.Rain;
using UnityEngine;
using UnityEngine.Rendering;

namespace HG.Rendering.Runtime
{
	public class HGSceneEffectRainRenderer : HGBaseSubRainRenderer
	{
		public HGSceneEffectRainRenderer()
		{
		}

		internal override void PrepareResources(RainCommonResources commonResources)
		{
			// // Void PrepareResources(RainCommonResources)
			// void HG::Rendering::Runtime::HGSceneEffectRainRenderer::PrepareResources(
			//         HGSceneEffectRainRenderer *this,
			//         RainCommonResources *commonResources,
			//         MethodInfo *method)
			// {
			//   Mesh *v5; // rdx
			//   Material *v6; // rcx
			//   PassConstructorID__Enum__Array *v7; // r8
			//   HGCamera *v8; // r9
			//   Shader *sceneEffectRainShader; // r9
			//   HGRenderPathBase_HGRenderPathResources *v10; // rdx
			//   PassConstructorID__Enum__Array *v11; // r8
			//   __int64 v12; // rdx
			//   Shader *m_sceneEffectRainShader; // rdi
			//   HGRenderPathBase_HGRenderPathResources *v14; // rdx
			//   PassConstructorID__Enum__Array *v15; // r8
			//   HGCamera *v16; // r9
			//   __int64 v17; // rdx
			//   Object_1 *m_sceneEffectRainMat; // rdi
			//   struct HGBaseSubRainRenderer__Class *v19; // rax
			//   Object_1 *v20; // rdi
			//   HideFlags__Enum *static_fields; // rax
			//   Object_1 *m_sceneEffectRainMesh; // rdi
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *v24; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v25; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v26; // [rsp+20h] [rbp-38h]
			//   Bounds v27; // [rsp+20h] [rbp-38h]
			//   MethodInfo *v28; // [rsp+28h] [rbp-30h]
			//   MethodInfo *v29; // [rsp+28h] [rbp-30h]
			//   MethodInfo *v30; // [rsp+28h] [rbp-30h]
			//   Bounds v31; // [rsp+38h] [rbp-20h] BYREF
			// 
			//   if ( !byte_18D8EDC98 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D8EDC98 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(1332, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1332, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
			//         (ILFixDynamicMethodWrapper_37 *)Patch,
			//         (Object *)this,
			//         (Object *)commonResources,
			//         0LL);
			//       return;
			//     }
			//     goto LABEL_21;
			//   }
			//   if ( !commonResources )
			//     goto LABEL_21;
			//   this.fields.m_sceneEffectRainMesh = commonResources.fields.sceneEffectRainMesh;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_sceneEffectRainMesh,
			//     (HGRenderPathBase_HGRenderPathResources *)v5,
			//     v7,
			//     v8,
			//     v24,
			//     v28);
			//   sceneEffectRainShader = commonResources.fields.sceneEffectRainShader;
			//   this.fields.m_sceneEffectRainShader = sceneEffectRainShader;
			//   sub_1800054D0(
			//     (HGRenderPathScene *)&this.fields.m_sceneEffectRainShader,
			//     v10,
			//     v11,
			//     (HGCamera *)sceneEffectRainShader,
			//     v25,
			//     v29);
			//   m_sceneEffectRainShader = this.fields.m_sceneEffectRainShader;
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGRenderPipelineMaterialCollector, v12);
			//   this.fields.m_sceneEffectRainMat = HG::Rendering::Runtime::HGRenderPipelineMaterialCollector::CreateStaticMaterial(
			//                                         m_sceneEffectRainShader,
			//                                         0,
			//                                         0LL);
			//   sub_1800054D0((HGRenderPathScene *)&this.fields.m_sceneEffectRainMat, v14, v15, v16, v26, v30);
			//   m_sceneEffectRainMat = (Object_1 *)this.fields.m_sceneEffectRainMat;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v17);
			//   if ( UnityEngine::Object::op_Inequality(0LL, m_sceneEffectRainMat, 0LL) )
			//   {
			//     v19 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
			//     v20 = (Object_1 *)this.fields.m_sceneEffectRainMat;
			//     if ( !TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer._1.cctor_finished_or_no_cctor )
			//     {
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer, v5);
			//       v19 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
			//     }
			//     static_fields = (HideFlags__Enum *)v19.static_fields;
			//     if ( !v20 )
			//       goto LABEL_21;
			//     UnityEngine::Object::set_hideFlags(v20, *static_fields, 0LL);
			//     v6 = this.fields.m_sceneEffectRainMat;
			//     if ( !v6 )
			//       goto LABEL_21;
			//     UnityEngine::Material::set_renderQueue(v6, this.fields._.rainRenderQueue, 0LL);
			//   }
			//   m_sceneEffectRainMesh = (Object_1 *)this.fields.m_sceneEffectRainMesh;
			//   if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v5);
			//   if ( UnityEngine::Object::op_Inequality(0LL, m_sceneEffectRainMesh, 0LL) )
			//   {
			//     v5 = this.fields.m_sceneEffectRainMesh;
			//     if ( v5 )
			//     {
			//       v27 = *UnityEngine::Mesh::get_bounds(&v31, v5, 0LL);
			//       this.fields.m_sceneEffectMeshExtents = v27.m_Extents;
			//       return;
			//     }
			// LABEL_21:
			//     sub_180B536AC(v6, v5);
			//   }
			// }
			// 
		}

		internal override void UpdateData(in RainCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera, float deltaTime)
		{
			// // Void UpdateData(RainCommonRenderingParam ByRef, HGCamera, Single)
			// void HG::Rendering::Runtime::HGSceneEffectRainRenderer::UpdateData(
			//         HGSceneEffectRainRenderer *this,
			//         RainCommonRenderingParam **rainCommonRenderingParam,
			//         HGCamera *hgCamera,
			//         float deltaTime,
			//         MethodInfo *method)
			// {
			//   float v5; // xmm1_4
			//   float v6; // xmm2_4
			//   __int64 sceneEffectRainTex; // rdx
			//   char *camera; // rcx
			//   RainCommonPreSettingParam *commonPresettingParam; // rsi
			//   float v13; // xmm7_4
			//   Beyond::JobMathf *v14; // rcx
			//   HGSceneEffectRainRenderer_SceneEffectRainRenderParams *m_sceneEffectRainRenderParams; // r15
			//   Transform *transform; // rax
			//   Vector3 *position; // rax
			//   __m128 sceneEffectRainRange_low; // xmm0
			//   __m128 maxRainHeight_low; // xmm1
			//   float v20; // xmm2_4
			//   HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v21; // rax
			//   __m128i v22; // xmm0
			//   RainCommonRenderingParam *v23; // rax
			//   float m_rainLayerOffset; // xmm1_4
			//   float streakLength; // xmm2_4
			//   unsigned int v26; // xmm0_4
			//   MethodInfo *v27; // r9
			//   float v28; // eax
			//   float v29; // xmm2_4
			//   Vector3 *v30; // rax
			//   __int64 v31; // r9
			//   __int64 v32; // xmm0_8
			//   __int64 v33; // xmm3_8
			//   Vector3 *v34; // rax
			//   PassConstructorID__Enum__Array *v35; // r8
			//   __int64 v36; // r9
			//   float z; // ecx
			//   HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v38; // rax
			//   RainCommonPreSettingParam *v39; // rax
			//   HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v40; // r9
			//   RainCommonPreSettingParam *v41; // rax
			//   __m128i v42; // xmm0
			//   int32_t sceneEffectRainLayerCount; // eax
			//   HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v44; // rax
			//   int v45; // xmm0_4
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   MethodInfo *P3; // [rsp+20h] [rbp-60h]
			//   MethodInfo *v48; // [rsp+28h] [rbp-58h]
			//   Vector3 v49; // [rsp+30h] [rbp-50h] BYREF
			//   Vector3 v50; // [rsp+40h] [rbp-40h] BYREF
			//   __int128 v51; // [rsp+50h] [rbp-30h] BYREF
			// 
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1333, 0LL) )
			//   {
			//     if ( *rainCommonRenderingParam )
			//     {
			//       commonPresettingParam = (*rainCommonRenderingParam).fields.commonPresettingParam;
			//       if ( commonPresettingParam )
			//       {
			//         v13 = (float)((float)((float)((float)((float)(0.5 / commonPresettingParam.fields.maxRainHeight)
			//                                             * (*rainCommonRenderingParam).fields.speed)
			//                                     * 0.050000001)
			//                             * commonPresettingParam.fields.sceneEffectRainMaxUVFlowSpeed)
			//                     * deltaTime)
			//             + this.fields.m_rainLayerOffset;
			//         System::MathF::Floor((System::MathF *)camera, v5);
			//         Beyond::JobMathf::Fmod(v14, 10.0, v6);
			//         m_sceneEffectRainRenderParams = this.fields.m_sceneEffectRainRenderParams;
			//         this.fields.m_rainLayerOffset = v13 + (float)(v13 - v13);
			//         if ( hgCamera )
			//         {
			//           camera = (char *)hgCamera.fields.camera;
			//           if ( camera )
			//           {
			//             transform = UnityEngine::Component::get_transform((Component *)camera, 0LL);
			//             if ( transform )
			//             {
			//               position = UnityEngine::Transform::get_position(&v50, transform, 0LL);
			//               camera = (char *)LODWORD(position.z);
			//               if ( m_sceneEffectRainRenderParams )
			//               {
			//                 *(_QWORD *)&m_sceneEffectRainRenderParams.fields.pos.x = *(_QWORD *)&position.x;
			//                 LODWORD(m_sceneEffectRainRenderParams.fields.pos.z) = (_DWORD)camera;
			//                 camera = (char *)this.fields.m_sceneEffectRainRenderParams;
			//                 sceneEffectRainRange_low = (__m128)LODWORD(commonPresettingParam.fields.sceneEffectRainRange);
			//                 maxRainHeight_low = (__m128)LODWORD(commonPresettingParam.fields.maxRainHeight);
			//                 sceneEffectRainRange_low.m128_f32[0] = sceneEffectRainRange_low.m128_f32[0]
			//                                                      / this.fields.m_sceneEffectMeshExtents.x;
			//                 maxRainHeight_low.m128_f32[0] = maxRainHeight_low.m128_f32[0] / this.fields.m_sceneEffectMeshExtents.y;
			//                 v20 = commonPresettingParam.fields.sceneEffectRainRange / this.fields.m_sceneEffectMeshExtents.z;
			//                 if ( camera )
			//                 {
			//                   *(_QWORD *)(camera + 28) = _mm_unpacklo_ps(sceneEffectRainRange_low, maxRainHeight_low).m128_u64[0];
			//                   *((float *)camera + 9) = v20;
			//                   camera = (char *)*rainCommonRenderingParam;
			//                   v21 = this.fields.m_sceneEffectRainRenderParams;
			//                   if ( *rainCommonRenderingParam )
			//                   {
			//                     v22 = _mm_loadu_si128((const __m128i *)camera + 2);
			//                     if ( v21 )
			//                     {
			//                       v21.fields.color = (Color)v22;
			//                       v23 = *rainCommonRenderingParam;
			//                       camera = (char *)this.fields.m_sceneEffectRainRenderParams;
			//                       m_rainLayerOffset = this.fields.m_rainLayerOffset;
			//                       if ( *rainCommonRenderingParam )
			//                       {
			//                         streakLength = v23.fields.streakLength;
			//                         DWORD1(v51) = LODWORD(v23.fields.sceneEffectRainWidthScale);
			//                         *(float *)&v26 = v23.fields.intensity * 0.0099999998;
			//                         *(float *)&v51 = m_rainLayerOffset;
			//                         *((_QWORD *)&v51 + 1) = __PAIR64__(v26, LODWORD(streakLength));
			//                         if ( camera )
			//                         {
			//                           *(_OWORD *)(camera + 40) = v51;
			//                           v27 = (MethodInfo *)this.fields.m_sceneEffectRainRenderParams;
			//                           if ( v27 )
			//                           {
			//                             camera = (char *)*rainCommonRenderingParam;
			//                             if ( *rainCommonRenderingParam )
			//                             {
			//                               sceneEffectRainTex = *((_QWORD *)camera + 42);
			//                               if ( sceneEffectRainTex )
			//                               {
			//                                 v28 = *((float *)camera + 27);
			//                                 v29 = *(float *)(sceneEffectRainTex + 28);
			//                                 *(_QWORD *)&v49.x = *(_QWORD *)(camera + 100);
			//                                 v49.z = v28;
			//                                 v30 = UnityEngine::Vector3::op_Multiply(&v50, &v49, v29, v27);
			//                                 v32 = *(_QWORD *)(v31 + 16);
			//                                 v33 = *(_QWORD *)&v30.x;
			//                                 v49.z = v30.z;
			//                                 v50.z = *(float *)(v31 + 24);
			//                                 *(_QWORD *)&v49.x = v33;
			//                                 *(_QWORD *)&v50.x = v32;
			//                                 v34 = UnityEngine::Vector3::op_Subtraction(
			//                                         (Vector3 *)&v51,
			//                                         &v50,
			//                                         &v49,
			//                                         (MethodInfo *)v31);
			//                                 z = v34.z;
			//                                 *(_QWORD *)(v36 + 56) = *(_QWORD *)&v34.x;
			//                                 *(float *)(v36 + 64) = z;
			//                                 camera = (char *)*rainCommonRenderingParam;
			//                                 v38 = this.fields.m_sceneEffectRainRenderParams;
			//                                 if ( *rainCommonRenderingParam )
			//                                 {
			//                                   if ( v38 )
			//                                   {
			//                                     v38.fields.rainDirectionJitterLevel = *((float *)camera + 37);
			//                                     camera = (char *)this.fields.m_sceneEffectRainRenderParams;
			//                                     if ( *rainCommonRenderingParam )
			//                                     {
			//                                       v39 = (*rainCommonRenderingParam).fields.commonPresettingParam;
			//                                       if ( v39 )
			//                                       {
			//                                         sceneEffectRainTex = (__int64)v39.fields.sceneEffectRainTex;
			//                                         if ( camera )
			//                                         {
			//                                           *((_QWORD *)camera + 12) = sceneEffectRainTex;
			//                                           sub_1800054D0(
			//                                             (HGRenderPathScene *)(camera + 96),
			//                                             (HGRenderPathBase_HGRenderPathResources *)sceneEffectRainTex,
			//                                             v35,
			//                                             (HGCamera *)v36,
			//                                             P3,
			//                                             v48);
			//                                           v40 = this.fields.m_sceneEffectRainRenderParams;
			//                                           if ( *rainCommonRenderingParam )
			//                                           {
			//                                             v41 = (*rainCommonRenderingParam).fields.commonPresettingParam;
			//                                             if ( v41 )
			//                                             {
			//                                               v42 = _mm_loadu_si128((const __m128i *)&v41.fields.sceneEffectRainTex_ST);
			//                                               if ( v40 )
			//                                               {
			//                                                 v40.fields.rainStreakTextureScaleOffset = (Vector4)v42;
			//                                                 camera = (char *)this.fields.m_sceneEffectRainRenderParams;
			//                                                 if ( *rainCommonRenderingParam )
			//                                                 {
			//                                                   sceneEffectRainLayerCount = (*rainCommonRenderingParam).fields.sceneEffectRainLayerCount;
			//                                                   sceneEffectRainTex = 4LL;
			//                                                   if ( sceneEffectRainLayerCount > 4 )
			//                                                     sceneEffectRainLayerCount = 4;
			//                                                   if ( camera )
			//                                                   {
			//                                                     *((_DWORD *)camera + 22) = sceneEffectRainLayerCount;
			//                                                     v44 = this.fields.m_sceneEffectRainRenderParams;
			//                                                     v45 = (hgCamera.fields.m_antialiasingMode & 2) != 0
			//                                                         ? 0x40000000
			//                                                         : 0;
			//                                                     if ( v44 )
			//                                                     {
			//                                                       LODWORD(v44.fields.rainWidthTaauFixFactor) = v45;
			//                                                       return;
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
			// LABEL_34:
			//     sub_180B536AC(camera, sceneEffectRainTex);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1333, 0LL);
			//   if ( !Patch )
			//     goto LABEL_34;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1381(
			//     Patch,
			//     (Object *)this,
			//     (SnowCommonRenderingParam **)rainCommonRenderingParam,
			//     (Object *)hgCamera,
			//     deltaTime,
			//     0LL);
			// }
			// 
		}

		internal override void SetMaterialData(in RainCommonRenderingParam rainCommonRenderingParam, ref ScriptableRenderContext context)
		{
			// // Void SetMaterialData(RainCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::HGSceneEffectRainRenderer::SetMaterialData(
			//         HGSceneEffectRainRenderer *this,
			//         RainCommonRenderingParam **rainCommonRenderingParam,
			//         ScriptableRenderContext *context,
			//         MethodInfo *method)
			// {
			//   unsigned __int64 cameraMask; // rdx
			//   float *p_CB0; // rcx
			//   HGSceneEffectRainRenderer_SceneEffectRainRenderParams *m_sceneEffectRainRenderParams; // rax
			//   float x; // xmm8_4
			//   float y; // xmm9_4
			//   float z; // xmm7_4
			//   float rainDirectionJitterLevel; // xmm6_4
			//   __m128i v14; // xmm7
			//   RainCommonRenderingParam *v15; // rax
			//   __m128i v16; // xmm6
			//   Material *m_sceneEffectRainMat; // rdi
			//   Material *v18; // rdi
			//   MaterialPropertyBlock *m_materialPropertyBlock; // rdi
			//   HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v20; // r8
			//   HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v21; // rax
			//   int32_t v22; // edx
			//   HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v23; // rax
			//   int32_t v24; // edx
			//   int32_t v25; // edx
			//   MethodInfo *v26; // r8
			//   HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v27; // rax
			//   Color *v28; // rax
			//   int32_t v29; // r10d
			//   MaterialPropertyBlock *v30; // rcx
			//   int32_t v31; // edx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __m128i rainStreakTextureScaleOffset; // [rsp+38h] [rbp-9h] BYREF
			//   Color v34; // [rsp+48h] [rbp+7h] BYREF
			// 
			//   if ( !byte_18D919DB4 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGUtils);
			//     sub_18003C530(&TypeInfo::UnityEngine::Mathf);
			//     byte_18D919DB4 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1334, 0LL) )
			//   {
			//     m_sceneEffectRainRenderParams = this.fields.m_sceneEffectRainRenderParams;
			//     if ( m_sceneEffectRainRenderParams )
			//     {
			//       x = m_sceneEffectRainRenderParams.fields.rainDirectionTargetPos.x;
			//       y = m_sceneEffectRainRenderParams.fields.rainDirectionTargetPos.y;
			//       z = m_sceneEffectRainRenderParams.fields.rainDirectionTargetPos.z;
			//       rainDirectionJitterLevel = m_sceneEffectRainRenderParams.fields.rainDirectionJitterLevel;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGUtils);
			//       v14 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                (Vector4 *)&rainStreakTextureScaleOffset,
			//                                                x,
			//                                                y,
			//                                                z,
			//                                                rainDirectionJitterLevel,
			//                                                0LL));
			//       v15 = *rainCommonRenderingParam;
			//       if ( *rainCommonRenderingParam )
			//       {
			//         p_CB0 = (float *)this.fields.m_sceneEffectRainRenderParams;
			//         cameraMask = (unsigned int)v15.fields.cameraMask;
			//         if ( p_CB0 )
			//         {
			//           v16 = _mm_loadu_si128((const __m128i *)HG::Rendering::Runtime::HGUtils::PackVector4(
			//                                                    (Vector4 *)&rainStreakTextureScaleOffset,
			//                                                    (float)(int)cameraMask,
			//                                                    v15.fields.sceneEffectRainLightingPercent,
			//                                                    p_CB0[23],
			//                                                    0LL));
			//           if ( *rainCommonRenderingParam )
			//           {
			//             if ( (*rainCommonRenderingParam).fields.enableRainLighting
			//               && (*rainCommonRenderingParam).fields.sceneEffectRainLightingPercent > TypeInfo::UnityEngine::Mathf.static_fields.Epsilon )
			//             {
			//               m_sceneEffectRainMat = this.fields.m_sceneEffectRainMat;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			//               cameraMask = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGRainRenderer.static_fields;
			//               if ( !m_sceneEffectRainMat )
			//                 goto LABEL_25;
			//               UnityEngine::Material::EnableKeyword(m_sceneEffectRainMat, *(String **)(cameraMask + 8), 0LL);
			//             }
			//             else
			//             {
			//               v18 = this.fields.m_sceneEffectRainMat;
			//               sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGRainRenderer);
			//               cameraMask = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGRainRenderer.static_fields;
			//               if ( !v18 )
			//                 goto LABEL_25;
			//               UnityEngine::Material::DisableKeyword(v18, *(String **)(cameraMask + 8), 0LL);
			//             }
			//             m_materialPropertyBlock = this.fields.m_materialPropertyBlock;
			//             sub_180002C70(TypeInfo::HG::Rendering::Runtime::HGShaderIDs);
			//             v20 = this.fields.m_sceneEffectRainRenderParams;
			//             cameraMask = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//             if ( v20 )
			//             {
			//               HG::Rendering::Runtime::HGEnvironmentUtils::SetTextureIfNotNull(
			//                 m_materialPropertyBlock,
			//                 *(_DWORD *)(cameraMask + 3156),
			//                 (Texture *)v20.fields.rainStreakTexture,
			//                 0LL);
			//               p_CB0 = (float *)this.fields.m_materialPropertyBlock;
			//               cameraMask = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//               v21 = this.fields.m_sceneEffectRainRenderParams;
			//               if ( v21 )
			//               {
			//                 if ( p_CB0 )
			//                 {
			//                   v22 = *(_DWORD *)(cameraMask + 3160);
			//                   rainStreakTextureScaleOffset = (__m128i)v21.fields.rainStreakTextureScaleOffset;
			//                   UnityEngine::MaterialPropertyBlock::SetVector(
			//                     (MaterialPropertyBlock *)p_CB0,
			//                     v22,
			//                     (Vector4 *)&rainStreakTextureScaleOffset,
			//                     0LL);
			//                   p_CB0 = (float *)this.fields.m_materialPropertyBlock;
			//                   cameraMask = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                   v23 = this.fields.m_sceneEffectRainRenderParams;
			//                   if ( v23 )
			//                   {
			//                     if ( p_CB0 )
			//                     {
			//                       v24 = *(_DWORD *)(cameraMask + 3172);
			//                       rainStreakTextureScaleOffset = (__m128i)v23.fields.rainParams;
			//                       UnityEngine::MaterialPropertyBlock::SetVector(
			//                         (MaterialPropertyBlock *)p_CB0,
			//                         v24,
			//                         (Vector4 *)&rainStreakTextureScaleOffset,
			//                         0LL);
			//                       p_CB0 = (float *)this.fields.m_materialPropertyBlock;
			//                       cameraMask = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                       if ( p_CB0 )
			//                       {
			//                         v25 = *(_DWORD *)(cameraMask + 3180);
			//                         rainStreakTextureScaleOffset = v14;
			//                         UnityEngine::MaterialPropertyBlock::SetVector(
			//                           (MaterialPropertyBlock *)p_CB0,
			//                           v25,
			//                           (Vector4 *)&rainStreakTextureScaleOffset,
			//                           0LL);
			//                         p_CB0 = (float *)&TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields._CB0;
			//                         v27 = this.fields.m_sceneEffectRainRenderParams;
			//                         if ( v27 )
			//                         {
			//                           rainStreakTextureScaleOffset = (__m128i)v27.fields.color;
			//                           v28 = UnityEngine::Color::op_Implicit(&v34, (Vector4 *)&rainStreakTextureScaleOffset, v26);
			//                           if ( this.fields.m_materialPropertyBlock )
			//                           {
			//                             v30 = this.fields.m_materialPropertyBlock;
			//                             rainStreakTextureScaleOffset = *(__m128i *)v28;
			//                             UnityEngine::MaterialPropertyBlock::SetVector(
			//                               v30,
			//                               v29,
			//                               (Vector4 *)&rainStreakTextureScaleOffset,
			//                               0LL);
			//                             p_CB0 = (float *)this.fields.m_materialPropertyBlock;
			//                             cameraMask = (unsigned __int64)TypeInfo::HG::Rendering::Runtime::HGShaderIDs.static_fields;
			//                             if ( p_CB0 )
			//                             {
			//                               v31 = *(_DWORD *)(cameraMask + 3176);
			//                               rainStreakTextureScaleOffset = v16;
			//                               UnityEngine::MaterialPropertyBlock::SetVector(
			//                                 (MaterialPropertyBlock *)p_CB0,
			//                                 v31,
			//                                 (Vector4 *)&rainStreakTextureScaleOffset,
			//                                 0LL);
			//                               return;
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
			// LABEL_25:
			//     sub_180B536AC(p_CB0, cameraMask);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1334, 0LL);
			//   if ( !Patch )
			//     goto LABEL_25;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_281(Patch, (Object *)this, rainCommonRenderingParam, context, 0LL);
			// }
			// 
		}

		internal override void UpdateRendererObjs(in RainCommonRenderingParam rainCommonRenderingParam, HGCamera hgCamera)
		{
			// // Void UpdateRendererObjs(RainCommonRenderingParam ByRef, HGCamera)
			// void HG::Rendering::Runtime::HGSceneEffectRainRenderer::UpdateRendererObjs(
			//         HGSceneEffectRainRenderer *this,
			//         RainCommonRenderingParam **rainCommonRenderingParam,
			//         HGCamera *hgCamera,
			//         MethodInfo *method)
			// {
			//   Renderer *v7; // rcx
			//   MeshRenderer__Array *v8; // rdx
			//   int v9; // ebx
			//   int32_t sceneEffectRainLayerCount; // r15d
			//   Transform__Array *m_sceneEffectRainTransList; // rax
			//   Transform *v12; // rdi
			//   Transform__Array *v13; // rax
			//   Transform *v14; // rdi
			//   __int64 (__fastcall *v15)(Transform *, MeshRenderer__Array *, HGCamera *, MethodInfo *); // rax
			//   __int64 v16; // rdi
			//   void (__fastcall *v17)(__int64, _QWORD); // rax
			//   String *v18; // rax
			//   String *v19; // rbp
			//   GameObject *v20; // rax
			//   Object_1 *v21; // rdi
			//   struct HGBaseSubRainRenderer__Class *v22; // rdx
			//   Transform__Array *v23; // rbp
			//   Transform *transform; // rax
			//   Transform *v25; // r14
			//   MeshRenderer__Array *m_sceneEffectRainRdList; // rbp
			//   Object *v27; // rax
			//   Object *v28; // r14
			//   Object *v29; // rax
			//   MeshFilter *v30; // rbp
			//   Object_1 *camera; // rbp
			//   Transform *v32; // rax
			//   Transform *v33; // rbp
			//   Transform *v34; // rax
			//   __int64 v35; // rdx
			//   __int64 v36; // rcx
			//   Transform *v37; // rdi
			//   void (__fastcall *v38)(Transform *, unsigned __int64 *); // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   HGSceneEffectRainRenderer_SceneEffectRainRenderParams *m_sceneEffectRainRenderParams; // rax
			//   GameObject *gameObject; // rax
			//   Transform__Array *v42; // rax
			//   Quaternion *identity; // rax
			//   Single__Array *s_sceneEffectLayerScale; // rdx
			//   struct HGSceneEffectRainRenderer__Class *v45; // rcx
			//   Transform *v46; // r9
			//   HGSceneEffectRainRenderer_SceneEffectRainRenderParams *v47; // rax
			//   __int64 v48; // xmm0_8
			//   float z; // eax
			//   struct HGSceneEffectRainRenderer__Class **static_fields; // rax
			//   float v51; // xmm1_4
			//   Transform__Array *v52; // rax
			//   MeshRenderer__Array *v53; // rax
			//   __int64 v54; // rax
			//   __int64 v55; // rax
			//   Int32 v56; // [rsp+30h] [rbp-88h] BYREF
			//   __int64 v57; // [rsp+38h] [rbp-80h]
			//   float v58; // [rsp+40h] [rbp-78h]
			//   unsigned __int64 v59; // [rsp+50h] [rbp-68h] BYREF
			//   int v60; // [rsp+58h] [rbp-60h]
			//   Vector3 v61; // [rsp+60h] [rbp-58h] BYREF
			//   Quaternion value; // [rsp+70h] [rbp-48h] BYREF
			//   Quaternion v63; // [rsp+80h] [rbp-38h] BYREF
			// 
			//   if ( !byte_18D8EDC99 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshFilter>);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshRenderer>);
			//     sub_18003C530(&TypeInfo::UnityEngine::GameObject);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     sub_18003C530(&off_18C9B5B28);
			//     byte_18D8EDC99 = 1;
			//   }
			//   if ( !byte_18D8EDC37 )
			//   {
			//     sub_18003C530(&TypeInfo::IFix::ILFixDynamicMethodWrapper);
			//     byte_18D8EDC37 = 1;
			//   }
			//   v7 = (Renderer *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper._1.cctor_finished_or_no_cctor )
			//   {
			//     il2cpp_runtime_class_init_0(TypeInfo::IFix::ILFixDynamicMethodWrapper, rainCommonRenderingParam);
			//     v7 = (Renderer *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = *(MeshRenderer__Array **)v7[7].fields._._.m_CachedPtr;
			//   if ( !v8 )
			//     goto LABEL_56;
			//   if ( v8.max_length.size <= 1335 )
			//     goto LABEL_9;
			//   if ( !LODWORD(v7[9].monitor) )
			//   {
			//     il2cpp_runtime_class_init_0(v7, v8);
			//     v7 = (Renderer *)TypeInfo::IFix::ILFixDynamicMethodWrapper;
			//   }
			//   v8 = *(MeshRenderer__Array **)v7[7].fields._._.m_CachedPtr;
			//   if ( !v8 )
			//     goto LABEL_56;
			//   if ( v8.max_length.size <= 0x537u )
			// LABEL_58:
			//     sub_180070270(v7, v8);
			//   if ( !v8[37].vector[3] )
			//   {
			// LABEL_9:
			//     if ( !*rainCommonRenderingParam )
			//       goto LABEL_56;
			//     v9 = 0;
			//     if ( (*rainCommonRenderingParam).fields.enable )
			//     {
			//       m_sceneEffectRainRenderParams = this.fields.m_sceneEffectRainRenderParams;
			//       if ( !m_sceneEffectRainRenderParams )
			//         goto LABEL_56;
			//       sceneEffectRainLayerCount = m_sceneEffectRainRenderParams.fields.sceneEffectRainLayerCount;
			//     }
			//     else
			//     {
			//       sceneEffectRainLayerCount = 0;
			//     }
			//     v56.m_value = 0;
			//     while ( 1 )
			//     {
			//       m_sceneEffectRainTransList = this.fields.m_sceneEffectRainTransList;
			//       if ( !m_sceneEffectRainTransList )
			//         break;
			//       v7 = (Renderer *)v9;
			//       if ( (unsigned int)v9 >= m_sceneEffectRainTransList.max_length.size )
			//         goto LABEL_58;
			//       v12 = m_sceneEffectRainTransList.vector[v9];
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//       if ( !byte_18D8F4EFA )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EFA = 1;
			//       }
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//       if ( !byte_18D8F4EAF )
			//       {
			//         sub_18003C530(&TypeInfo::UnityEngine::Object);
			//         byte_18D8F4EAF = 1;
			//       }
			//       if ( !v12 )
			//         goto LABEL_37;
			//       v7 = (Renderer *)TypeInfo::UnityEngine::Object;
			//       if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//         il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//       if ( !v12.fields._._.m_CachedPtr )
			//       {
			// LABEL_37:
			//         v18 = System::Int32::ToString(&v56, 0LL);
			//         v19 = System::String::Concat((String *)"!SCENE_EFFECT_RAIN_OBJ", v18, 0LL);
			//         v20 = (GameObject *)sub_180004920(TypeInfo::UnityEngine::GameObject);
			//         v21 = (Object_1 *)v20;
			//         if ( !v20 )
			//           break;
			//         UnityEngine::GameObject::GameObject(v20, v19, 0LL);
			//         v22 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
			//         if ( !TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(
			//             TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer,
			//             TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer);
			//           v22 = TypeInfo::HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer;
			//         }
			//         UnityEngine::Object::set_hideFlags(v21, v22.static_fields.RAIN_RSC_HIDE_FLAGS, 0LL);
			//         v23 = this.fields.m_sceneEffectRainTransList;
			//         transform = UnityEngine::GameObject::get_transform((GameObject *)v21, 0LL);
			//         v25 = transform;
			//         if ( !v23 )
			//           break;
			//         sub_180036D40(v23, transform);
			//         sub_18000FDA0(v23, v9, v25);
			//         m_sceneEffectRainRdList = this.fields.m_sceneEffectRainRdList;
			//         v27 = UnityEngine::GameObject::AddComponent<System::Object>(
			//                 (GameObject *)v21,
			//                 MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshRenderer>);
			//         v28 = v27;
			//         if ( !m_sceneEffectRainRdList )
			//           break;
			//         sub_180036D40(m_sceneEffectRainRdList, v27);
			//         sub_18000FDA0(m_sceneEffectRainRdList, v9, v28);
			//         v29 = UnityEngine::GameObject::AddComponent<System::Object>(
			//                 (GameObject *)v21,
			//                 MethodInfo::UnityEngine::GameObject::AddComponent<UnityEngine::MeshFilter>);
			//         v8 = this.fields.m_sceneEffectRainRdList;
			//         v30 = (MeshFilter *)v29;
			//         if ( !v8 )
			//           break;
			//         v7 = (Renderer *)v9;
			//         if ( (unsigned int)v9 >= v8.max_length.size )
			//           goto LABEL_58;
			//         v7 = (Renderer *)v8.vector[v9];
			//         if ( !v7 )
			//           break;
			//         UnityEngine::Renderer::SetMaterial(v7, this.fields.m_sceneEffectRainMat, 0LL);
			//         if ( !v30 )
			//           break;
			//         UnityEngine::MeshFilter::set_sharedMesh(v30, this.fields.m_sceneEffectRainMesh, 0LL);
			//         if ( hgCamera )
			//         {
			//           camera = (Object_1 *)hgCamera.fields.camera;
			//           if ( !TypeInfo::UnityEngine::Object._1.cctor_finished_or_no_cctor )
			//             il2cpp_runtime_class_init_0(TypeInfo::UnityEngine::Object, v8);
			//           if ( UnityEngine::Object::op_Inequality(camera, 0LL, 0LL) )
			//           {
			//             v32 = UnityEngine::GameObject::get_transform((GameObject *)v21, 0LL);
			//             v7 = (Renderer *)hgCamera.fields.camera;
			//             v33 = v32;
			//             if ( !v7 )
			//               break;
			//             v34 = UnityEngine::Component::get_transform((Component *)v7, 0LL);
			//             if ( !v33 )
			//               break;
			//             UnityEngine::Transform::SetParent(v33, v34, 1, 0LL);
			//             v37 = UnityEngine::GameObject::get_transform((GameObject *)v21, 0LL);
			//             if ( !v37 )
			//               sub_180B536AC(v36, v35);
			//             v38 = (void (__fastcall *)(Transform *, unsigned __int64 *))qword_18D8F52F8;
			//             v59 = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
			//             v60 = 0;
			//             if ( !qword_18D8F52F8 )
			//             {
			//               v38 = (void (__fastcall *)(Transform *, unsigned __int64 *))sub_180017470(
			//                                                                             "UnityEngine.Transform::set_localPosition_Inj"
			//                                                                             "ected(UnityEngine.Vector3&)");
			//               qword_18D8F52F8 = (__int64)v38;
			//             }
			//             v38(v37, &v59);
			//           }
			//         }
			//       }
			//       v13 = this.fields.m_sceneEffectRainTransList;
			//       if ( v9 < sceneEffectRainLayerCount )
			//       {
			//         if ( !v13 )
			//           break;
			//         v7 = (Renderer *)v9;
			//         if ( (unsigned int)v9 >= v13.max_length.size )
			//           goto LABEL_58;
			//         v7 = (Renderer *)v13.vector[v9];
			//         if ( !v7 )
			//           break;
			//         gameObject = UnityEngine::Component::get_gameObject((Component *)v7, 0LL);
			//         if ( !gameObject )
			//           break;
			//         UnityEngine::GameObject::SetActive(gameObject, 1, 0LL);
			//         v42 = this.fields.m_sceneEffectRainTransList;
			//         if ( !v42 )
			//           break;
			//         v7 = (Renderer *)v9;
			//         if ( (unsigned int)v9 >= v42.max_length.size )
			//           goto LABEL_58;
			//         identity = UnityEngine::Quaternion::get_identity(&v63, (MethodInfo *)v8);
			//         if ( !v46 )
			//           goto LABEL_94;
			//         value = *identity;
			//         UnityEngine::Transform::set_rotation_Injected(v46, &value, 0LL);
			//         v47 = this.fields.m_sceneEffectRainRenderParams;
			//         if ( !v47 )
			//           goto LABEL_94;
			//         v48 = *(_QWORD *)&v47.fields.scale.x;
			//         v45 = TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer;
			//         z = v47.fields.scale.z;
			//         v57 = v48;
			//         v58 = z;
			//         if ( !TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer._1.cctor_finished_or_no_cctor )
			//         {
			//           il2cpp_runtime_class_init_0(
			//             TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer,
			//             s_sceneEffectLayerScale);
			//           v45 = TypeInfo::HG::Rendering::Runtime::HGSceneEffectRainRenderer;
			//         }
			//         s_sceneEffectLayerScale = v45.static_fields.s_sceneEffectLayerScale;
			//         if ( !s_sceneEffectLayerScale )
			//           goto LABEL_94;
			//         if ( (unsigned int)v9 >= s_sceneEffectLayerScale.max_length.size )
			//           goto LABEL_93;
			//         static_fields = (struct HGSceneEffectRainRenderer__Class **)v45.static_fields;
			//         *(float *)&v57 = *(float *)&v57 * s_sceneEffectLayerScale.vector[v9];
			//         v45 = *static_fields;
			//         if ( !*static_fields )
			//           goto LABEL_94;
			//         if ( (unsigned int)v9 >= LODWORD(v45._0.namespaze) )
			//           goto LABEL_93;
			//         v51 = v58 * *((float *)&v45._0.byval_arg.data.__klassIndex + v9);
			//         v52 = this.fields.m_sceneEffectRainTransList;
			//         if ( !v52 )
			//           goto LABEL_94;
			//         v45 = (struct HGSceneEffectRainRenderer__Class *)v9;
			//         if ( (unsigned int)v9 >= v52.max_length.size )
			//           goto LABEL_93;
			//         v45 = (struct HGSceneEffectRainRenderer__Class *)v52.vector[v9];
			//         if ( !v45 )
			//           goto LABEL_94;
			//         *(_QWORD *)&v61.x = v57;
			//         v61.z = v51;
			//         UnityEngine::Transform::set_localScale_Injected((Transform *)v45, &v61, 0LL);
			//         v53 = this.fields.m_sceneEffectRainRdList;
			//         if ( !v53 )
			//           goto LABEL_94;
			//         v45 = (struct HGSceneEffectRainRenderer__Class *)v9;
			//         if ( (unsigned int)v9 >= v53.max_length.size )
			// LABEL_93:
			//           sub_180070270(v45, s_sceneEffectLayerScale);
			//         v45 = (struct HGSceneEffectRainRenderer__Class *)v53.vector[v9];
			//         if ( !v45 )
			// LABEL_94:
			//           sub_180B536AC(v45, s_sceneEffectLayerScale);
			//         UnityEngine::Renderer::Internal_SetPropertyBlock((Renderer *)v45, this.fields.m_materialPropertyBlock, 0LL);
			//       }
			//       else
			//       {
			//         if ( !v13 )
			//           break;
			//         v7 = (Renderer *)v9;
			//         if ( (unsigned int)v9 >= v13.max_length.size )
			//           goto LABEL_58;
			//         v14 = v13.vector[v9];
			//         if ( !v14 )
			//           break;
			//         v15 = (__int64 (__fastcall *)(Transform *, MeshRenderer__Array *, HGCamera *, MethodInfo *))qword_18D8F4D48;
			//         if ( !qword_18D8F4D48 )
			//         {
			//           v15 = (__int64 (__fastcall *)(Transform *, MeshRenderer__Array *, HGCamera *, MethodInfo *))il2cpp_resolve_icall_0("UnityEngine.Component::get_gameObject()");
			//           if ( !v15 )
			//           {
			//             v54 = sub_1802DBBE8("UnityEngine.Component::get_gameObject()");
			//             sub_18000F750(v54, 0LL);
			//           }
			//           qword_18D8F4D48 = (__int64)v15;
			//         }
			//         v16 = v15(v14, v8, hgCamera, method);
			//         if ( !v16 )
			//           break;
			//         v17 = (void (__fastcall *)(__int64, _QWORD))qword_18D8F4DF8;
			//         if ( !qword_18D8F4DF8 )
			//         {
			//           v17 = (void (__fastcall *)(__int64, _QWORD))il2cpp_resolve_icall_0("UnityEngine.GameObject::SetActive(System.Boolean)");
			//           if ( !v17 )
			//           {
			//             v55 = sub_1802DBBE8("UnityEngine.GameObject::SetActive(System.Boolean)");
			//             sub_18000F750(v55, 0LL);
			//           }
			//           qword_18D8F4DF8 = (__int64)v17;
			//         }
			//         v17(v16, 0LL);
			//       }
			//       v56.m_value = ++v9;
			//       if ( v9 >= 4 )
			//         return;
			//     }
			// LABEL_56:
			//     sub_180B536AC(v7, v8);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1335, 0LL);
			//   if ( !Patch )
			//     goto LABEL_56;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_287(
			//     Patch,
			//     (Object *)this,
			//     (SnowCommonRenderingParam **)rainCommonRenderingParam,
			//     (Object *)hgCamera,
			//     0LL);
			// }
			// 
		}

		internal override void Dispose()
		{
			// // Void Dispose()
			// void HG::Rendering::Runtime::HGSceneEffectRainRenderer::Dispose(HGSceneEffectRainRenderer *this, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   int32_t i; // ebx
			//   Transform__Array *m_sceneEffectRainTransList; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1336, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1336, 0LL);
			//     if ( !Patch )
			// LABEL_8:
			//       sub_180B536AC(v4, v3);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)this, 0LL);
			//   }
			//   else
			//   {
			//     for ( i = 0; ; ++i )
			//     {
			//       m_sceneEffectRainTransList = this.fields.m_sceneEffectRainTransList;
			//       if ( !m_sceneEffectRainTransList )
			//         goto LABEL_8;
			//       if ( i >= m_sceneEffectRainTransList.max_length.size )
			//         break;
			//       if ( (unsigned int)i >= m_sceneEffectRainTransList.max_length.size )
			//         sub_180070270(v4, v3);
			//       HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeRendererObj(
			//         (HGBaseSubRainRenderer *)this,
			//         m_sceneEffectRainTransList.vector[i],
			//         0LL);
			//     }
			//     HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::DisposeMaterial(
			//       (HGBaseSubRainRenderer *)this,
			//       this.fields.m_sceneEffectRainMat,
			//       0LL);
			//   }
			// }
			// 
		}

		public void <>iFixBaseProxy_SetMaterialData(ref RainCommonRenderingParam P0, ref ScriptableRenderContext P1)
		{
			// // Void <>iFixBaseProxy_SetMaterialData(RainCommonRenderingParam ByRef, ScriptableRenderContext ByRef)
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::__iFixBaseProxy_SetMaterialData(
			//         HGFarRainRenderer *this,
			//         RainCommonRenderingParam **P0,
			//         ScriptableRenderContext *P1,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::SetMaterialData((HGBaseSubRainRenderer *)this, P0, P1, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_UpdateRendererObjs(ref RainCommonRenderingParam P0, HGCamera P1)
		{
			// // Void <>iFixBaseProxy_UpdateRendererObjs(RainCommonRenderingParam ByRef, HGCamera)
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::__iFixBaseProxy_UpdateRendererObjs(
			//         HGFarRainRenderer *this,
			//         RainCommonRenderingParam **P0,
			//         HGCamera *P1,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::UpdateRendererObjs((HGBaseSubRainRenderer *)this, P0, P1, 0LL);
			// }
			// 
		}

		public void <>iFixBaseProxy_Dispose()
		{
			// // Void <>iFixBaseProxy_Dispose()
			// void HG::Rendering::Runtime::Rain::HGFarRainRenderer::__iFixBaseProxy_Dispose(
			//         HGFarRainRenderer *this,
			//         MethodInfo *method)
			// {
			//   HG::Rendering::Runtime::Rain::HGBaseSubRainRenderer::Dispose((HGBaseSubRainRenderer *)this, 0LL);
			// }
			// 
		}

		private Mesh m_sceneEffectRainMesh;

		private Vector3 m_sceneEffectMeshExtents;

		private Shader m_sceneEffectRainShader;

		private Material m_sceneEffectRainMat;

		private MaterialPropertyBlock m_materialPropertyBlock;

		private HGSceneEffectRainRenderer.SceneEffectRainRenderParams m_sceneEffectRainRenderParams;

		private float m_rainLayerOffset;

		private const int s_maxSceneEffectLayerCount = 4;

		[StaticFieldOffset(ThreadStatic = false, Offset = "0x00")]
		private static readonly float[] s_sceneEffectLayerScale;

		private const string s_sceneEffectRainObjPrefix = "!SCENE_EFFECT_RAIN_OBJ";

		private Transform[] m_sceneEffectRainTransList;

		private MeshRenderer[] m_sceneEffectRainRdList;

		internal class SceneEffectRainRenderParams
		{
			public SceneEffectRainRenderParams()
			{
				// // HGSceneEffectSnowRenderer+SceneEffectSnowRenderParams()
				// void HG::Rendering::Runtime::Snow::HGSceneEffectSnowRenderer::SceneEffectSnowRenderParams::SceneEffectSnowRenderParams(
				//         HGSceneEffectSnowRenderer_SceneEffectSnowRenderParams *this,
				//         MethodInfo *method)
				// {
				//   Vector3Int *v2; // r8
				//   ITilemap *v3; // r9
				//   TileBase *v5; // rdx
				//   Vector3Int *v6; // r8
				//   ITilemap *v7; // r9
				//   Color v8; // xmm1
				//   HGRenderPathBase_HGRenderPathResources *v9; // rdx
				//   PassConstructorID__Enum__Array *v10; // r8
				//   HGCamera *v11; // r9
				//   TileAnimationData v12; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   *(_QWORD *)&this.fields.pos.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
				//   this.fields.pos.z = 0.0;
				//   *(_QWORD *)&this.fields.scale.x = _mm_unpacklo_ps((__m128)0x3F800000u, (__m128)0x3F800000u).m128_u64[0];
				//   this.fields.scale.z = 1.0;
				//   this.fields.snowParams = (Vector4)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
				//                                         &v12,
				//                                         (TileBase *)method,
				//                                         v2,
				//                                         v3,
				//                                         (MethodInfo *)v12.m_AnimatedSprites);
				//   *(_QWORD *)&this.fields.snowDirection.x = _mm_unpacklo_ps((__m128)0LL, (__m128)0LL).m128_u64[0];
				//   this.fields.snowDirection.z = 0.0;
				//   v8 = (Color)*UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
				//                  &v12,
				//                  v5,
				//                  v6,
				//                  v7,
				//                  (MethodInfo *)v12.m_AnimatedSprites);
				//   this.fields.snowLayerCount = 1;
				//   this.fields.color = v8;
				//   this.fields.snowflakeTexture = UnityEngine::Texture2D::get_whiteTexture(0LL);
				//   sub_1800054D0(
				//     (HGRenderPathScene *)&this.fields.snowflakeTexture,
				//     v9,
				//     v10,
				//     v11,
				//     (MethodInfo *)v12.m_AnimatedSprites,
				//     *(MethodInfo **)&v12.m_AnimationSpeed);
				//   this.fields.snowflakeTextureTilingOffset = (Vector4)_mm_load_si128((const __m128i *)&xmmword_18A357570);
				// }
				// 
			}

			public Vector3 pos;

			public Vector3 scale;

			public Vector4 rainParams;

			public Vector3 rainDirectionTargetPos;

			public float rainDirectionJitterLevel;

			public Color color;

			public int sceneEffectRainLayerCount;

			public float rainWidthTaauFixFactor;

			public Texture2D rainStreakTexture;

			public Vector4 rainStreakTextureScaleOffset;
		}
	}
}
