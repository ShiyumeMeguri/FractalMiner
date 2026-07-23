using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public static class HGSharedLightDataExtension // TypeDefIndex: 37769
	{
		// Extension methods
		public static Entity GetEntity(this HGSharedLightData lightData) => default; // 0x0000000189D08BE8-0x0000000189D08C54
		// Entity GetEntity(HGSharedLightData)
		Entity_1 HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(HGSharedLightData lightData, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGSharedLightData _unity_self; // [rsp+30h] [rbp+8h] BYREF
		  Entity_1 v7; // [rsp+40h] [rbp+18h]
		
		  _unity_self = lightData;
		  if ( IFix::WrappersManagerImpl::IsPatched(1896, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1896, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v5, v4);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_758(Patch, _unity_self, 0LL);
		  }
		  else
		  {
		    v7.globalIndex = UnityEngine::HGSharedLightData::get_entityIndex_Injected(&_unity_self, 0LL);
		    v7.version = UnityEngine::HGSharedLightData::get_entityVersion_Injected(&_unity_self, 0LL);
		    return v7;
		  }
		}
		
	}
}
