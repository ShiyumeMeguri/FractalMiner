using System;
using UnityEngine;
using UnityEngine.HyperGryph;

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGGlobalGameManagerAsset", order = 0)]
	public class HGGlobalGameManagerAsset : HGGlobalGameManagerAssetBase
	{
		public HGGlobalGameManagerAsset()
		{
			// // SingletonScriptableObject`1[System.Object]()
			// void Beyond::SingletonScriptableObject<System::Object>::SingletonScriptableObject(
			//         SingletonScriptableObject_1_System_Object_ *this,
			//         MethodInfo *method)
			// {
			//   UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
			// }
			// 
		}

		protected override HGManagerContextBase CreateManagerContext()
		{
			// // HGManagerContextBase CreateManagerContext()
			// HGManagerContextBase *HG::Rendering::Runtime::HGGlobalGameManagerAsset::CreateManagerContext(
			//         HGGlobalGameManagerAsset *this,
			//         MethodInfo *method)
			// {
			//   HGManagerContext *v3; // rax
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   HGManagerContextBase *v6; // rbx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8ED95B )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGManagerContext);
			//     byte_18D8ED95B = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(1907, 0LL) )
			//   {
			//     v3 = (HGManagerContext *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGManagerContext);
			//     v6 = (HGManagerContextBase *)v3;
			//     if ( v3 )
			//     {
			//       HG::Rendering::Runtime::HGManagerContext::HGManagerContext(v3, 0LL);
			//       return v6;
			//     }
			// LABEL_6:
			//     sub_180B536AC(v5, v4);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(1907, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_750(Patch, (Object *)this, 0LL);
			// }
			// 
			return null;
		}
	}
}
