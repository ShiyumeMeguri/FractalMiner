using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal abstract class HGRenderPipelineResources : RenderPipelineResources // TypeDefIndex: 38154
	{
		// Properties
		protected override string packagePath { get; } // 0x0000000189B894A0-0x0000000189B894FC 
		// String get_packagePath()
		String *HG::Rendering::Runtime::HGRenderPipelineResources::get_packagePath(
		        HGRenderPipelineResources *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2988, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2988, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_5((ILFixDynamicMethodWrapper_26 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		    return HG::Rendering::Runtime::HGUtils::GetHGRenderPipelinePath(0LL);
		  }
		}
		
	
		// Constructors
		protected HGRenderPipelineResources() {} // 0x0000000183573370-0x0000000183573380
		// SingletonScriptableObject`1[System.Object]()
		void Beyond::SingletonScriptableObject<System::Object>::SingletonScriptableObject(
		        SingletonScriptableObject_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	
		// Methods
		public string __iFixBaseProxy_get_packagePath() => default; // 0x00000001811EC580-0x00000001811EC590
		// RuntimePhysicGroupData& NullRef[RuntimePhysicGroupData]()
		RuntimePhysicGroupData *System::Runtime::CompilerServices::Unsafe::NullRef<Beyond::Gameplay::Core::DynamicScene::RuntimePhysicGroupData>(
		        MethodInfo *method)
		{
		  return 0LL;
		}
		
	}
}
