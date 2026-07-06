using System;
using UnityEngine;
using UnityEngine.HyperGryph.ECS;

namespace HG.Rendering.Runtime
{
	public static class HGSharedLightDataExtension
	{
		public static Entity GetEntity(this HGSharedLightData lightData)
		{
			// // Entity GetEntity(HGSharedLightData)
			// Entity_1 HG::Rendering::Runtime::HGSharedLightDataExtension::GetEntity(HGSharedLightData lightData, MethodInfo *method)
			// {
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   HGSharedLightData _unity_self; // [rsp+30h] [rbp+8h] BYREF
			//   Entity_1 v7; // [rsp+40h] [rbp+18h]
			// 
			//   _unity_self = lightData;
			//   if ( IFix::WrappersManagerImpl::IsPatched(1593, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1593, 0LL);
			//     if ( !Patch )
			//       sub_180B536AC(v5, v4);
			//     return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_607(Patch, _unity_self, 0LL);
			//   }
			//   else
			//   {
			//     v7.globalIndex = UnityEngine::HGSharedLightData::get_entityIndex_Injected(&_unity_self, 0LL);
			//     v7.version = UnityEngine::HGSharedLightData::get_entityVersion_Injected(&_unity_self, 0LL);
			//     return v7;
			//   }
			// }
			// 
			return null;
		}
	}
}
