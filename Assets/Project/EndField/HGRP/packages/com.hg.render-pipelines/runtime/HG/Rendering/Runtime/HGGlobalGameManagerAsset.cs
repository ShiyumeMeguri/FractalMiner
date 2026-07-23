using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.HyperGryph;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGGlobalGameManagerAsset", order = 0)]
	public class HGGlobalGameManagerAsset : HGGlobalGameManagerAssetBase // TypeDefIndex: 37913
	{
		// Constructors
		public HGGlobalGameManagerAsset() {} // 0x0000000183573370-0x0000000183573380
		// SingletonScriptableObject`1[System.Object]()
		void Beyond::SingletonScriptableObject<System::Object>::SingletonScriptableObject(
		        SingletonScriptableObject_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	
		// Methods
		protected override HGManagerContextBase CreateManagerContext() => default; // 0x0000000182ED6C30-0x0000000182ED6C80
		// HGManagerContextBase CreateManagerContext()
		HGManagerContextBase *HG::Rendering::Runtime::HGGlobalGameManagerAsset::CreateManagerContext(
		        HGGlobalGameManagerAsset *this,
		        MethodInfo *method)
		{
		  HGManagerContext *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGManagerContextBase *v6; // rbx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(2261, 0LL) )
		  {
		    v3 = (HGManagerContext *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGManagerContext);
		    v6 = (HGManagerContextBase *)v3;
		    if ( v3 )
		    {
		      HG::Rendering::Runtime::HGManagerContext::HGManagerContext(v3, 0LL);
		      return v6;
		    }
		LABEL_4:
		    sub_1800D8260(v5, v4);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(2261, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_915(Patch, (Object *)this, 0LL);
		}
		
	}
}
