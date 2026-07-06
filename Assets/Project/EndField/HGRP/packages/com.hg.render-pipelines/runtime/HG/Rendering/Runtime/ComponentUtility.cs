using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public static class ComponentUtility
	{
		public static bool IsHGCamera(Camera camera)
		{
			// // Boolean IsHGCamera(Camera)
			// bool HG::Rendering::Runtime::ComponentUtility::IsHGCamera(Camera *camera, MethodInfo *method)
			// {
			//   __int64 v3; // rdx
			//   __int64 v4; // rcx
			//   Object *v5; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D9193D5 )
			//   {
			//     sub_18003C530(&MethodInfo::UnityEngine::Component::GetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
			//     sub_18003C530(&TypeInfo::UnityEngine::Object);
			//     byte_18D9193D5 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(352, 0LL) )
			//   {
			//     if ( camera )
			//     {
			//       v5 = UnityEngine::Component::GetComponent<System::Object>(
			//              (Component *)camera,
			//              MethodInfo::UnityEngine::Component::GetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
			//       sub_180002C70(TypeInfo::UnityEngine::Object);
			//       return UnityEngine::Object::op_Inequality((Object_1 *)v5, 0LL, 0LL);
			//     }
			// LABEL_7:
			//     sub_180B536AC(v4, v3);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(352, 0LL);
			//   if ( !Patch )
			//     goto LABEL_7;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_8((ILFixDynamicMethodWrapper_27 *)Patch, (Object *)camera, 0LL);
			// }
			// 
			return default(bool);
		}
	}
}
