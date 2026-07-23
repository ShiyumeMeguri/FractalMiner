using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.ScriptBridge
{
	public class HGCameraConfig // TypeDefIndex: 37412
	{
		// Nested types
		public struct HGCameraComponentsAttached // TypeDefIndex: 37411
		{
			// Fields
			public HGDepthOfField depthOfField; // 0x00
			public HGAdditionalCameraData cameraAdditionalData; // 0x08
		}
	
		// Constructors
		public HGCameraConfig() {} // 0x00000001841E1670-0x00000001841E1680
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
		public static HGCameraComponentsAttached ConfigMainCamera(Camera camera) => default; // 0x000000018394ECB0-0x000000018394ED90
		// HGCameraConfig+HGCameraComponentsAttached ConfigMainCamera(Camera)
		HGCameraConfig_HGCameraComponentsAttached *HG::Rendering::ScriptBridge::HGCameraConfig::ConfigMainCamera(
		        HGCameraConfig_HGCameraComponentsAttached *__return_ptr retstr,
		        Camera *camera,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGCamera *v7; // rdi
		  GameObject *gameObject; // rax
		  Object *v9; // rbx
		  Int32__Array **additionalCameraData; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v11; // rdx
		  VolumetricRenderer_VolumetricBounds *v12; // r8
		  Int32__Array **v13; // r9
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v14; // rdx
		  VolumetricRenderer_VolumetricBounds *v15; // r8
		  HGCameraConfig_HGCameraComponentsAttached v16; // xmm0
		  HGCameraConfig_HGCameraComponentsAttached *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGCameraConfig_HGCameraComponentsAttached v19; // [rsp+20h] [rbp-28h] BYREF
		  HGCameraConfig_HGCameraComponentsAttached v20; // [rsp+30h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(21, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(21, 0LL);
		    if ( Patch )
		    {
		      v16 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14(&v20, Patch, (Object *)camera, 0LL);
		      goto LABEL_9;
		    }
		LABEL_5:
		    sub_1800D8260(v6, v5);
		  }
		  HG::Rendering::ScriptBridge::HGCameraConfig::ApplyTableCameraSettings(camera, 0LL);
		  if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		    il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		  v7 = HG::Rendering::Runtime::HGCamera::GetOrCreate(camera, 0, 0LL);
		  if ( !camera )
		    goto LABEL_5;
		  gameObject = UnityEngine::Component::get_gameObject((Component *)camera, 0LL);
		  if ( !gameObject )
		    goto LABEL_5;
		  v9 = UnityEngine::GameObject::AddComponent<System::Object>(
		         gameObject,
		         MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HGDepthOfField>);
		  if ( !v7 )
		    goto LABEL_5;
		  additionalCameraData = (Int32__Array **)HG::Rendering::Runtime::HGCamera::get_additionalCameraData(v7, 0LL);
		  v19 = (HGCameraConfig_HGCameraComponentsAttached)(unsigned __int64)v9;
		  ((void (__stdcall *)(VolumetricRenderer_VolumetricRenderItem *, Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *, VolumetricRenderer_VolumetricBounds *, Int32__Array **))sub_18002D1B0)(
		    (VolumetricRenderer_VolumetricRenderItem *)&v19,
		    v11,
		    v12,
		    additionalCameraData);
		  v19.cameraAdditionalData = (HGAdditionalCameraData *)v13;
		  ((void (__stdcall *)(VolumetricRenderer_VolumetricRenderItem *, Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *, VolumetricRenderer_VolumetricBounds *, Int32__Array **, MethodInfo *))sub_18002D1B0)(
		    (VolumetricRenderer_VolumetricRenderItem *)&v19.cameraAdditionalData,
		    v14,
		    v15,
		    v13,
		    (MethodInfo *)v19.depthOfField);
		  v16 = v19;
		LABEL_9:
		  result = retstr;
		  *retstr = v16;
		  return result;
		}
		
		public static void ConfigUICamera(Camera camera) {} // 0x000000018394ED90-0x000000018394EE20
		// Void ConfigUICamera(Camera)
		void HG::Rendering::ScriptBridge::HGCameraConfig::ConfigUICamera(Camera *camera, MethodInfo *method)
		{
		  HGCamera *v3; // rax
		  __int64 v4; // rdx
		  Camera *v5; // rcx
		  HGCamera *v6; // rbx
		  HGAdditionalCameraData *additionalCameraData; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(25, 0LL) )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    v3 = HG::Rendering::Runtime::HGCamera::GetOrCreate(camera, 0, 0LL);
		    v6 = v3;
		    if ( v3 )
		    {
		      additionalCameraData = HG::Rendering::Runtime::HGCamera::get_additionalCameraData(v3, 0LL);
		      if ( additionalCameraData )
		      {
		        additionalCameraData->fields.hgRenderPath = 1;
		        v5 = v6->fields.camera;
		        if ( v5 )
		        {
		          UnityEngine::Camera::SetLightWeight(v5, 1, 0LL);
		          return;
		        }
		      }
		    }
		LABEL_5:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(25, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)camera, 0LL);
		}
		
		private static void ApplyTableCameraSettings(Camera camera) {} // 0x000000018394E700-0x000000018394E760
		// Void ApplyTableCameraSettings(Camera)
		void HG::Rendering::ScriptBridge::HGCameraConfig::ApplyTableCameraSettings(Camera *camera, MethodInfo *method)
		{
		  HGCamera *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(22, 0LL) )
		  {
		    if ( !TypeInfo::HG::Rendering::Runtime::HGCamera->_1.cctor_finished_or_no_cctor )
		      il2cpp_runtime_class_init_1(TypeInfo::HG::Rendering::Runtime::HGCamera);
		    v3 = HG::Rendering::Runtime::HGCamera::GetOrCreate(camera, 0, 0LL);
		    if ( v3 )
		    {
		      v3->fields.applyTableSettings = 1;
		      return;
		    }
		LABEL_6:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(22, 0LL);
		  if ( !Patch )
		    goto LABEL_6;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)camera, 0LL);
		}
		
	}
}
