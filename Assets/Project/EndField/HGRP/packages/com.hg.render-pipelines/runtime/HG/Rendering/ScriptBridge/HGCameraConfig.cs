using System;
using System.Runtime.InteropServices;
using HG.Rendering.Runtime;
using UnityEngine;

namespace HG.Rendering.ScriptBridge
{
	public class HGCameraConfig
	{
		public HGCameraConfig()
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

		public static HGCameraConfig.HGCameraComponentsAttached ConfigMainCamera(Camera camera)
		{
			// // HGCameraConfig+HGCameraComponentsAttached ConfigMainCamera(Camera)
			// HGCameraConfig_HGCameraComponentsAttached *HG::Rendering::ScriptBridge::HGCameraConfig::ConfigMainCamera(
			//         HGCameraConfig_HGCameraComponentsAttached *__return_ptr retstr,
			//         Camera *camera,
			//         MethodInfo *method)
			// {
			//   __int64 v5; // rdx
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v6; // rdx
			//   __int64 v7; // rcx
			//   HGCamera *v8; // rdi
			//   GameObject *gameObject; // rax
			//   Object *v10; // rax
			//   Bounds *v11; // r8
			//   Object__Array *m_AdditionalCameraData; // r9
			//   Object__Array *v13; // r9
			//   IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *v14; // rdx
			//   Bounds *v15; // r8
			//   HGCameraConfig_HGCameraComponentsAttached v16; // xmm0
			//   HGCameraConfig_HGCameraComponentsAttached *result; // rax
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   _BYTE v19[40]; // [rsp+20h] [rbp-28h] BYREF
			// 
			//   if ( !byte_18D8ED943 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HGDepthOfField>);
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     byte_18D8ED943 = 1;
			//   }
			//   if ( IFix::WrappersManagerImpl::IsPatched(27, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(27, 0LL);
			//     if ( Patch )
			//     {
			//       v16 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_18(
			//                (HGCameraConfig_HGCameraComponentsAttached *)&v19[16],
			//                Patch,
			//                (Object *)camera,
			//                0LL);
			//       goto LABEL_11;
			//     }
			// LABEL_7:
			//     sub_180B536AC(v7, v6);
			//   }
			//   HG::Rendering::ScriptBridge::HGCameraConfig::ApplyTableCameraSettings(camera, 0LL);
			//   if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//     il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v5);
			//   v8 = HG::Rendering::Runtime::HGCamera::GetOrCreate(camera, 0, 0LL);
			//   if ( !camera )
			//     goto LABEL_7;
			//   gameObject = UnityEngine::Component::get_gameObject((Component *)camera, 0LL);
			//   if ( !gameObject )
			//     goto LABEL_7;
			//   v10 = UnityEngine::GameObject::AddComponent<System::Object>(
			//           gameObject,
			//           MethodInfo::UnityEngine::GameObject::AddComponent<HG::Rendering::Runtime::HGDepthOfField>);
			//   if ( !v8 )
			//     goto LABEL_7;
			//   m_AdditionalCameraData = (Object__Array *)v8.fields.m_AdditionalCameraData;
			//   *(_OWORD *)v19 = (unsigned __int64)v10;
			//   ((void (__stdcall *)(BSP *, IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *, Bounds *, Object__Array *))sub_1800054D0)(
			//     (BSP *)v19,
			//     v6,
			//     v11,
			//     m_AdditionalCameraData);
			//   *(_QWORD *)&v19[8] = v13;
			//   ((void (__stdcall *)(BSP *, IEnumerable_1_HG_Rendering_Runtime_CSG_CSGPolygon_ *, Bounds *, Object__Array *, MethodInfo *))sub_1800054D0)(
			//     (BSP *)&v19[8],
			//     v14,
			//     v15,
			//     v13,
			//     *(MethodInfo **)v19);
			//   v16 = *(HGCameraConfig_HGCameraComponentsAttached *)v19;
			// LABEL_11:
			//   result = retstr;
			//   *retstr = v16;
			//   return result;
			// }
			// 
			return default(HGCameraConfig.HGCameraComponentsAttached);
		}

		public static void ConfigUICamera(Camera camera)
		{
			// // Void ConfigUICamera(Camera)
			// void HG::Rendering::ScriptBridge::HGCameraConfig::ConfigUICamera(Camera *camera, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGCamera *v4; // rax
			//   __int64 v5; // rdx
			//   Camera *m_AdditionalCameraData; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED944 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     byte_18D8ED944 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(30, 0LL) )
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v3);
			//     v4 = HG::Rendering::Runtime::HGCamera::GetOrCreate(camera, 0, 0LL);
			//     if ( v4 )
			//     {
			//       m_AdditionalCameraData = (Camera *)v4.fields.m_AdditionalCameraData;
			//       if ( m_AdditionalCameraData )
			//       {
			//         HIDWORD(m_AdditionalCameraData[3].klass) = 1;
			//         m_AdditionalCameraData = v4.fields.camera;
			//         if ( m_AdditionalCameraData )
			//         {
			//           UnityEngine::Camera::SetLightWeight(m_AdditionalCameraData, 1, 0LL);
			//           return;
			//         }
			//       }
			//     }
			// LABEL_10:
			//     sub_180B536AC(m_AdditionalCameraData, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(30, 0LL);
			//   if ( !Patch )
			//     goto LABEL_10;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)camera, 0LL);
			// }
			// 
		}

		private static void ApplyTableCameraSettings(Camera camera)
		{
			// // Void ApplyTableCameraSettings(Camera)
			// void HG::Rendering::ScriptBridge::HGCameraConfig::ApplyTableCameraSettings(Camera *camera, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   HGCamera *v4; // rax
			//   __int64 v5; // rdx
			//   __int64 v6; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED945 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGCamera);
			//     byte_18D8ED945 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(28, 0LL) )
			//   {
			//     if ( !TypeInfo::HG::Rendering::Runtime::HGCamera._1.cctor_finished_or_no_cctor )
			//       il2cpp_runtime_class_init_0(TypeInfo::HG::Rendering::Runtime::HGCamera, v3);
			//     v4 = HG::Rendering::Runtime::HGCamera::GetOrCreate(camera, 0, 0LL);
			//     if ( v4 )
			//     {
			//       v4.fields.applyTableSettings = 1;
			//       return;
			//     }
			// LABEL_8:
			//     sub_180B536AC(v6, v5);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(28, 0LL);
			//   if ( !Patch )
			//     goto LABEL_8;
			//   IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_37 *)Patch, (Object *)camera, 0LL);
			// }
			// 
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		public struct HGCameraComponentsAttached
		{
			public HGDepthOfField depthOfField;

			public HGAdditionalCameraData cameraAdditionalData;
		}
	}
}
