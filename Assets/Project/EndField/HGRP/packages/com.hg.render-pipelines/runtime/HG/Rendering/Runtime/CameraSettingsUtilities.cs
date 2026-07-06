using System;
using IFix.Core;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public static class CameraSettingsUtilities
	{
		[IDTag(0)]
		public static void ApplySettings(this Camera cam, in CameraSettings settings)
		{
			// // Void ApplySettings(Camera, CameraSettings ByRef)
			// void HG::Rendering::Runtime::CameraSettingsUtilities::ApplySettings(
			//         Camera *cam,
			//         CameraSettings *settings,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Object *v7; // rdi
			//   GameObject *gameObject; // rax
			//   Object__Class *v9; // xmm0_8
			//   __m128 v10; // xmm6
			//   __int128 v11; // xmm0
			//   __int128 v12; // xmm1
			//   __int128 v13; // xmm0
			//   __int128 v14; // xmm1
			//   __int128 v15; // xmm0
			//   Matrix4x4 *UsedProjectionMatrix; // rax
			//   __int128 v17; // xmm1
			//   __int128 v18; // xmm0
			//   __int128 v19; // xmm1
			//   OneofDescriptorProto *v20; // rdx
			//   FileDescriptor *v21; // r8
			//   MessageDescriptor *v22; // r9
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   CameraSettings_Frustum v24; // [rsp+28h] [rbp-59h] BYREF
			//   Matrix4x4 v25; // [rsp+88h] [rbp+7h] BYREF
			// 
			//   if ( !byte_18D91974A )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::GetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CameraSettings::Frustum);
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
			//     byte_18D91974A = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3448, 0LL) )
			//   {
			//     if ( !cam )
			//       goto LABEL_11;
			//     v7 = UnityEngine::Component::GetComponent<System::Object>(
			//            (Component *)cam,
			//            MethodInfo::UnityEngine::Component::GetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
			//     if ( !v7 )
			//     {
			//       gameObject = UnityEngine::Component::get_gameObject((Component *)cam, 0LL);
			//       if ( !gameObject )
			//         goto LABEL_11;
			//       v7 = UnityEngine::GameObject::AddComponent<System::Object>(
			//              gameObject,
			//              MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
			//     }
			//     if ( v7 )
			//     {
			//       LODWORD(v7[13].monitor) = settings.defaultFrameSettings;
			//       v9 = *(Object__Class **)&settings.renderingPathCustomFrameSettings.materialQuality;
			//       v7[11] = (Object)settings.renderingPathCustomFrameSettings.bitDatas;
			//       v7[12].klass = v9;
			//       *(FrameSettingsOverrideMask *)((char *)v7 + 200) = settings.renderingPathCustomFrameSettingsOverrideMask;
			//       v10 = *(__m128 *)&settings.frustum.mode;
			//       sub_180002C70(TypeInfo::HG::Rendering::Runtime::CameraSettings::Frustum);
			//       UnityEngine::Camera::set_nearClipPlane(
			//         cam,
			//         fmaxf(0.0000099999997, _mm_shuffle_ps(v10, v10, 255).m128_f32[0]),
			//         0LL);
			//       UnityEngine::Camera::set_farClipPlane(
			//         cam,
			//         fmaxf(
			//           _mm_shuffle_ps(*(__m128 *)&settings.frustum.mode, *(__m128 *)&settings.frustum.mode, 255).m128_f32[0]
			//         + 0.000099999997,
			//           _mm_shuffle_ps(*(__m128 *)&settings.frustum.mode, *(__m128 *)&settings.frustum.mode, 170).m128_f32[0]),
			//         0LL);
			//       UnityEngine::Camera::set_fieldOfView(cam, settings.frustum.fieldOfView, 0LL);
			//       UnityEngine::Camera::set_aspect(cam, settings.frustum.aspect, 0LL);
			//       v11 = *(_OWORD *)&settings.frustum.mode;
			//       v12 = *(_OWORD *)&settings.frustum.fieldOfView;
			//       v24.projectionMatrix.m33 = settings.frustum.projectionMatrix.m33;
			//       *(_OWORD *)&v24.mode = v11;
			//       v13 = *(_OWORD *)&settings.frustum.projectionMatrix.m30;
			//       *(_OWORD *)&v24.fieldOfView = v12;
			//       v14 = *(_OWORD *)&settings.frustum.projectionMatrix.m31;
			//       *(_OWORD *)&v24.projectionMatrix.m30 = v13;
			//       v15 = *(_OWORD *)&settings.frustum.projectionMatrix.m32;
			//       *(_OWORD *)&v24.projectionMatrix.m31 = v14;
			//       *(_OWORD *)&v24.projectionMatrix.m32 = v15;
			//       UsedProjectionMatrix = HG::Rendering::Runtime::CameraSettings::Frustum::GetUsedProjectionMatrix(&v25, &v24, 0LL);
			//       v17 = *(_OWORD *)&UsedProjectionMatrix.m01;
			//       *(_OWORD *)&v24.mode = *(_OWORD *)&UsedProjectionMatrix.m00;
			//       v18 = *(_OWORD *)&UsedProjectionMatrix.m02;
			//       *(_OWORD *)&v24.fieldOfView = v17;
			//       v19 = *(_OWORD *)&UsedProjectionMatrix.m03;
			//       *(_OWORD *)&v24.projectionMatrix.m30 = v18;
			//       *(_OWORD *)&v24.projectionMatrix.m31 = v19;
			//       UnityEngine::Camera::set_projectionMatrix(cam, (Matrix4x4 *)&v24, 0LL);
			//       UnityEngine::Camera::set_useOcclusionCulling(cam, settings.culling.useOcclusionCulling, 0LL);
			//       UnityEngine::Camera::set_cullingMask(cam, settings.culling.cullingMask.m_Mask, 0LL);
			//       UnityEngine::Camera::set_overrideSceneCullingMask(cam, settings.culling.sceneCullingMaskOverride, 0LL);
			//       LODWORD(v7[2].klass) = settings.bufferClearing.clearColorMode;
			//       *(__m128i *)((char *)&v7[2] + 4) = _mm_loadu_si128((const __m128i *)&settings.bufferClearing.backgroundColorHDR);
			//       BYTE4(v7[3].klass) = settings.bufferClearing.clearDepth;
			//       LODWORD(v7[3].monitor) = settings.volumes.layerMask.m_Mask;
			//       v7[4].klass = (Object__Class *)settings.volumes.anchorOverride;
			//       sub_1800054D0(
			//         (OneofDescriptor *)&v7[4],
			//         v20,
			//         v21,
			//         v22,
			//         *(String__Array **)&v24.mode,
			//         *(String **)&v24.farClipPlaneRaw,
			//         *(MethodInfo **)&v24.fieldOfView);
			//       BYTE2(v7[8].klass) = settings.customRenderingSettings;
			//       HIDWORD(v7[7].klass) = settings.flipYMode;
			//       BYTE3(v7[8].klass) = settings.invertFaceCulling;
			//       HIDWORD(v7[10].klass) = LODWORD(settings.probeRangeCompressionFactor);
			//       return;
			//     }
			// LABEL_11:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3448, 0LL);
			//   if ( !Patch )
			//     goto LABEL_11;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1235(Patch, (Object *)cam, settings, 0LL);
			// }
			// 
		}

		[IDTag(1)]
		public static void ApplySettings(this Camera cam, in CameraPositionSettings settings)
		{
			// // Void ApplySettings(Camera, CameraPositionSettings ByRef)
			// void HG::Rendering::Runtime::CameraSettingsUtilities::ApplySettings(
			//         Camera *cam,
			//         CameraPositionSettings *settings,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   Transform *transform; // rax
			//   __int64 v8; // xmm0_8
			//   Transform *v9; // rax
			//   Quaternion v10; // xmm1
			//   __int128 v11; // xmm0
			//   __int128 v12; // xmm1
			//   __int128 v13; // xmm0
			//   __int128 v14; // xmm1
			//   Matrix4x4 *UsedWorldToCameraMatrix; // rax
			//   Quaternion v16; // xmm1
			//   __int128 v17; // xmm0
			//   __int128 v18; // xmm1
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v20; // rdx
			//   __int64 v21; // rcx
			//   Vector3 v22; // [rsp+20h] [rbp-69h] BYREF
			//   Quaternion rotation; // [rsp+30h] [rbp-59h] BYREF
			//   CameraPositionSettings v24; // [rsp+40h] [rbp-49h] BYREF
			//   Matrix4x4 v25; // [rsp+A0h] [rbp+17h] BYREF
			// 
			//   if ( !byte_18D91974B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::CameraPositionSettings);
			//     byte_18D91974B = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(3449, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(3449, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v21, v20);
			//     IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1236(Patch, (Object *)cam, settings, 0LL);
			//   }
			//   else
			//   {
			//     if ( !cam
			//       || (transform = UnityEngine::Component::get_transform((Component *)cam, 0LL)) == 0LL
			//       || (v8 = *(_QWORD *)&settings.position.x,
			//           v22.z = settings.position.z,
			//           *(_QWORD *)&v22.x = v8,
			//           UnityEngine::Transform::set_position(transform, &v22, 0LL),
			//           (v9 = UnityEngine::Component::get_transform((Component *)cam, 0LL)) == 0LL) )
			//     {
			//       sub_180B536AC(v6, v5);
			//     }
			//     rotation = settings.rotation;
			//     UnityEngine::Transform::set_rotation(v9, &rotation, 0LL);
			//     v10 = settings.rotation;
			//     *(_OWORD *)&v24.mode = *(_OWORD *)&settings.mode;
			//     v11 = *(_OWORD *)&settings.worldToCameraMatrix.m00;
			//     v24.rotation = v10;
			//     v12 = *(_OWORD *)&settings.worldToCameraMatrix.m01;
			//     *(_OWORD *)&v24.worldToCameraMatrix.m00 = v11;
			//     v13 = *(_OWORD *)&settings.worldToCameraMatrix.m02;
			//     *(_OWORD *)&v24.worldToCameraMatrix.m01 = v12;
			//     v14 = *(_OWORD *)&settings.worldToCameraMatrix.m03;
			//     *(_OWORD *)&v24.worldToCameraMatrix.m02 = v13;
			//     *(_OWORD *)&v24.worldToCameraMatrix.m03 = v14;
			//     sub_180002C70(TypeInfo::HG::Rendering::Runtime::CameraPositionSettings);
			//     UsedWorldToCameraMatrix = HG::Rendering::Runtime::CameraPositionSettings::GetUsedWorldToCameraMatrix(
			//                                 &v25,
			//                                 &v24,
			//                                 0LL);
			//     v16 = *(Quaternion *)&UsedWorldToCameraMatrix.m01;
			//     *(_OWORD *)&v24.mode = *(_OWORD *)&UsedWorldToCameraMatrix.m00;
			//     v17 = *(_OWORD *)&UsedWorldToCameraMatrix.m02;
			//     v24.rotation = v16;
			//     v18 = *(_OWORD *)&UsedWorldToCameraMatrix.m03;
			//     *(_OWORD *)&v24.worldToCameraMatrix.m00 = v17;
			//     *(_OWORD *)&v24.worldToCameraMatrix.m01 = v18;
			//     UnityEngine::Camera::set_worldToCameraMatrix(cam, (Matrix4x4 *)&v24, 0LL);
			//   }
			// }
			// 
		}
	}
}
