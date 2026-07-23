using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class ComponentUtility // TypeDefIndex: 37511
	{
		// Methods
		public static bool IsHGCamera(Camera camera) => default; // 0x0000000189B34C00-0x0000000189B34C78
		// Boolean IsHGCamera(Camera)
		bool HG::Rendering::Runtime::ComponentUtility::IsHGCamera(Camera *camera, MethodInfo *method)
		{
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		  Object *v5; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(359, 0LL) )
		  {
		    if ( camera )
		    {
		      v5 = UnityEngine::Component::GetComponent<System::Object>(
		             (Component *)camera,
		             MethodInfo::UnityEngine::Component::GetComponent<HG::Rendering::Runtime::HGAdditionalCameraData>);
		      sub_1800036A0(TypeInfo::UnityEngine::Object);
		      return UnityEngine::Object::op_Inequality((Object_1 *)v5, 0LL, 0LL);
		    }
		LABEL_5:
		    sub_1800D8260(v4, v3);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(359, 0LL);
		  if ( !Patch )
		    goto LABEL_5;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_20 *)Patch, (Object *)camera, 0LL);
		}
		
	}
}
