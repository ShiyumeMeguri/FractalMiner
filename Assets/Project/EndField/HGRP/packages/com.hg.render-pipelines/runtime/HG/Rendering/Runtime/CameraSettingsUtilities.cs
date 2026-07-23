using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class CameraSettingsUtilities // TypeDefIndex: 38668
	{
		// Extension methods
		[IDTag(0)]
		public static void ApplySettings(this Camera cam, [IsReadOnly] in CameraSettings settings) {} // 0x0000000189C1C914-0x0000000189C1CBE0
		// Void ApplySettings(Camera, CameraSettings ByRef)
		void HG::Rendering::Runtime::CameraSettingsUtilities::ApplySettings(
		        Camera *cam,
		        CameraSettings *settings,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Object *v7; // rdi
		  GameObject *gameObject; // rax
		  BitArray128 *renderingPathCustomFrameSettings; // rax
		  uint64_t v10; // xmm0_8
		  __int128 v11; // xmm0
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  __int128 v18; // xmm0
		  __int128 v19; // xmm1
		  __int128 v20; // xmm0
		  __int128 v21; // xmm0
		  __int128 v22; // xmm1
		  __int128 v23; // xmm0
		  __int128 v24; // xmm1
		  __int128 v25; // xmm0
		  Matrix4x4 *UsedProjectionMatrix; // rax
		  __int128 v27; // xmm1
		  __int128 v28; // xmm0
		  __int128 v29; // xmm1
		  Type *v30; // rdx
		  PropertyInfo_1 *v31; // r8
		  Int32__Array **v32; // r9
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  CameraSettings_Frustum v34; // [rsp+28h] [rbp-49h] BYREF
		  Matrix4x4 v35; // [rsp+88h] [rbp+17h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(4078, 0LL) )
		  {
		    if ( !cam )
		      goto LABEL_9;
		    v7 = UnityEngine::Component::GetComponent<System::Object>(
		           (Component *)cam,
		           MethodInfo::UnityEngine::Component::GetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
		    if ( !v7 )
		    {
		      gameObject = UnityEngine::Component::get_gameObject((Component *)cam, 0LL);
		      if ( !gameObject )
		        goto LABEL_9;
		      v7 = UnityEngine::GameObject::AddComponent<System::Object>(
		             gameObject,
		             MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
		    }
		    if ( v7 )
		    {
		      LODWORD(v7[13].monitor) = settings->defaultFrameSettings;
		      renderingPathCustomFrameSettings = (BitArray128 *)HG::Rendering::Runtime::HGAdditionalCameraData::get_renderingPathCustomFrameSettings(
		                                                          (HGAdditionalCameraData *)v7,
		                                                          0LL);
		      v10 = *(_QWORD *)&settings->renderingPathCustomFrameSettings.materialQuality;
		      *renderingPathCustomFrameSettings = settings->renderingPathCustomFrameSettings.bitDatas;
		      renderingPathCustomFrameSettings[1].data1 = v10;
		      *(FrameSettingsOverrideMask *)((char *)v7 + 200) = settings->renderingPathCustomFrameSettingsOverrideMask;
		      v11 = *(_OWORD *)&settings->frustum.mode;
		      v12 = *(_OWORD *)&settings->frustum.fieldOfView;
		      v34.projectionMatrix.m33 = settings->frustum.projectionMatrix.m33;
		      *(_OWORD *)&v34.mode = v11;
		      v13 = *(_OWORD *)&settings->frustum.projectionMatrix.m30;
		      *(_OWORD *)&v34.fieldOfView = v12;
		      v14 = *(_OWORD *)&settings->frustum.projectionMatrix.m31;
		      *(_OWORD *)&v34.projectionMatrix.m30 = v13;
		      v15 = *(_OWORD *)&settings->frustum.projectionMatrix.m32;
		      *(_OWORD *)&v34.projectionMatrix.m31 = v14;
		      *(_OWORD *)&v34.projectionMatrix.m32 = v15;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CameraSettings::Frustum);
		      *(float *)&v15 = HG::Rendering::Runtime::CameraSettings::Frustum::get_nearClipPlane(&v34, 0LL);
		      UnityEngine::Camera::set_nearClipPlane(cam, *(float *)&v15, 0LL);
		      v16 = *(_OWORD *)&settings->frustum.mode;
		      v17 = *(_OWORD *)&settings->frustum.fieldOfView;
		      v34.projectionMatrix.m33 = settings->frustum.projectionMatrix.m33;
		      *(_OWORD *)&v34.mode = v16;
		      v18 = *(_OWORD *)&settings->frustum.projectionMatrix.m30;
		      *(_OWORD *)&v34.fieldOfView = v17;
		      v19 = *(_OWORD *)&settings->frustum.projectionMatrix.m31;
		      *(_OWORD *)&v34.projectionMatrix.m30 = v18;
		      v20 = *(_OWORD *)&settings->frustum.projectionMatrix.m32;
		      *(_OWORD *)&v34.projectionMatrix.m31 = v19;
		      *(_OWORD *)&v34.projectionMatrix.m32 = v20;
		      *(float *)&v20 = HG::Rendering::Runtime::CameraSettings::Frustum::get_farClipPlane(&v34, 0LL);
		      UnityEngine::Camera::set_farClipPlane(cam, *(float *)&v20, 0LL);
		      UnityEngine::Camera::set_fieldOfView(cam, settings->frustum.fieldOfView, 0LL);
		      UnityEngine::Camera::set_aspect(cam, settings->frustum.aspect, 0LL);
		      v21 = *(_OWORD *)&settings->frustum.mode;
		      v22 = *(_OWORD *)&settings->frustum.fieldOfView;
		      v34.projectionMatrix.m33 = settings->frustum.projectionMatrix.m33;
		      *(_OWORD *)&v34.mode = v21;
		      v23 = *(_OWORD *)&settings->frustum.projectionMatrix.m30;
		      *(_OWORD *)&v34.fieldOfView = v22;
		      v24 = *(_OWORD *)&settings->frustum.projectionMatrix.m31;
		      *(_OWORD *)&v34.projectionMatrix.m30 = v23;
		      v25 = *(_OWORD *)&settings->frustum.projectionMatrix.m32;
		      *(_OWORD *)&v34.projectionMatrix.m31 = v24;
		      *(_OWORD *)&v34.projectionMatrix.m32 = v25;
		      UsedProjectionMatrix = HG::Rendering::Runtime::CameraSettings::Frustum::GetUsedProjectionMatrix(&v35, &v34, 0LL);
		      v27 = *(_OWORD *)&UsedProjectionMatrix->m01;
		      *(_OWORD *)&v34.mode = *(_OWORD *)&UsedProjectionMatrix->m00;
		      v28 = *(_OWORD *)&UsedProjectionMatrix->m02;
		      *(_OWORD *)&v34.fieldOfView = v27;
		      v29 = *(_OWORD *)&UsedProjectionMatrix->m03;
		      *(_OWORD *)&v34.projectionMatrix.m30 = v28;
		      *(_OWORD *)&v34.projectionMatrix.m31 = v29;
		      UnityEngine::Camera::set_projectionMatrix(cam, (Matrix4x4 *)&v34, 0LL);
		      UnityEngine::Camera::set_useOcclusionCulling(cam, settings->culling.useOcclusionCulling, 0LL);
		      UnityEngine::Camera::set_cullingMask(cam, settings->culling.cullingMask.m_Mask, 0LL);
		      UnityEngine::Camera::set_overrideSceneCullingMask(cam, settings->culling.sceneCullingMaskOverride, 0LL);
		      LODWORD(v7[2].klass) = settings->bufferClearing.clearColorMode;
		      *(__m128i *)((char *)&v7[2] + 4) = _mm_loadu_si128((const __m128i *)&settings->bufferClearing.backgroundColorHDR);
		      BYTE4(v7[3].klass) = settings->bufferClearing.clearDepth;
		      LODWORD(v7[3].monitor) = settings->volumes.layerMask.m_Mask;
		      v7[4].klass = (Object__Class *)settings->volumes.anchorOverride;
		      sub_18002D1B0((SingleFieldAccessor *)&v7[4], v30, v31, v32, *(MethodInfo **)&v34.mode);
		      BYTE2(v7[8].klass) = settings->customRenderingSettings;
		      HIDWORD(v7[7].klass) = settings->flipYMode;
		      BYTE3(v7[8].klass) = settings->invertFaceCulling;
		      HIDWORD(v7[10].klass) = LODWORD(settings->probeRangeCompressionFactor);
		      return;
		    }
		LABEL_9:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(4078, 0LL);
		  if ( !Patch )
		    goto LABEL_9;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1445(Patch, (Object *)cam, settings, 0LL);
		}
		
		[IDTag(1)]
		public static void ApplySettings(this Camera cam, [IsReadOnly] in CameraPositionSettings settings) {} // 0x0000000189C1C7BC-0x0000000189C1C914
		// Void ApplySettings(Camera, CameraPositionSettings ByRef)
		void HG::Rendering::Runtime::CameraSettingsUtilities::ApplySettings(
		        Camera *cam,
		        CameraPositionSettings *settings,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  Transform *transform; // rax
		  __int64 v8; // xmm0_8
		  Transform *v9; // rax
		  Quaternion v10; // xmm1
		  __int128 v11; // xmm0
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  Matrix4x4 *UsedWorldToCameraMatrix; // rax
		  Quaternion v16; // xmm1
		  __int128 v17; // xmm0
		  __int128 v18; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v20; // rdx
		  __int64 v21; // rcx
		  Vector3 v22; // [rsp+20h] [rbp-69h] BYREF
		  Quaternion rotation; // [rsp+30h] [rbp-59h] BYREF
		  CameraPositionSettings v24; // [rsp+40h] [rbp-49h] BYREF
		  Matrix4x4 v25; // [rsp+A0h] [rbp+17h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(4079, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(4079, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v21, v20);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1446(Patch, (Object *)cam, settings, 0LL);
		  }
		  else
		  {
		    if ( !cam
		      || (transform = UnityEngine::Component::get_transform((Component *)cam, 0LL)) == 0LL
		      || (v8 = *(_QWORD *)&settings->position.x,
		          v22.z = settings->position.z,
		          *(_QWORD *)&v22.x = v8,
		          UnityEngine::Transform::set_position(transform, &v22, 0LL),
		          (v9 = UnityEngine::Component::get_transform((Component *)cam, 0LL)) == 0LL) )
		    {
		      sub_1800D8260(v6, v5);
		    }
		    rotation = settings->rotation;
		    UnityEngine::Transform::set_rotation(v9, &rotation, 0LL);
		    v10 = settings->rotation;
		    *(_OWORD *)&v24.mode = *(_OWORD *)&settings->mode;
		    v11 = *(_OWORD *)&settings->worldToCameraMatrix.m00;
		    v24.rotation = v10;
		    v12 = *(_OWORD *)&settings->worldToCameraMatrix.m01;
		    *(_OWORD *)&v24.worldToCameraMatrix.m00 = v11;
		    v13 = *(_OWORD *)&settings->worldToCameraMatrix.m02;
		    *(_OWORD *)&v24.worldToCameraMatrix.m01 = v12;
		    v14 = *(_OWORD *)&settings->worldToCameraMatrix.m03;
		    *(_OWORD *)&v24.worldToCameraMatrix.m02 = v13;
		    *(_OWORD *)&v24.worldToCameraMatrix.m03 = v14;
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::CameraPositionSettings);
		    UsedWorldToCameraMatrix = HG::Rendering::Runtime::CameraPositionSettings::GetUsedWorldToCameraMatrix(
		                                &v25,
		                                &v24,
		                                0LL);
		    v16 = *(Quaternion *)&UsedWorldToCameraMatrix->m01;
		    *(_OWORD *)&v24.mode = *(_OWORD *)&UsedWorldToCameraMatrix->m00;
		    v17 = *(_OWORD *)&UsedWorldToCameraMatrix->m02;
		    v24.rotation = v16;
		    v18 = *(_OWORD *)&UsedWorldToCameraMatrix->m03;
		    *(_OWORD *)&v24.worldToCameraMatrix.m00 = v17;
		    *(_OWORD *)&v24.worldToCameraMatrix.m01 = v18;
		    UnityEngine::Camera::set_worldToCameraMatrix(cam, (Matrix4x4 *)&v24, 0LL);
		  }
		}
		
	}
}
