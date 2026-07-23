using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.SDF
{
	internal class SDFBakeResources : ScriptableObject // TypeDefIndex: 38797
	{
		// Fields
		[SerializeField]
		private ComputeShader m_SDFRayMapCS; // 0x18
		[SerializeField]
		private ComputeShader m_SDFNormalsCS; // 0x20
		[SerializeField]
		private Shader m_SDFRayMapShader; // 0x28
	
		// Properties
		internal ComputeShader sdfRayMapCS { get => default; set {} } // 0x0000000189C7D7A4-0x0000000189C7D7F4 0x0000000189C7D8A8-0x0000000189C7D90C
		// ComputeShader get_sdfRayMapCS()
		ComputeShader *HG::Rendering::Runtime::SDF::SDFBakeResources::get_sdfRayMapCS(
		        SDFBakeResources *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5402, 0LL) )
		    return this->fields.m_SDFRayMapCS;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5402, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1275(Patch, (Object *)this, 0LL);
		}
		
		internal ComputeShader sdfNormalsCS { get => default; set {} } // 0x0000000189C7D754-0x0000000189C7D7A4 0x0000000189C7D844-0x0000000189C7D8A8
		// ComputeShader get_sdfNormalsCS()
		ComputeShader *HG::Rendering::Runtime::SDF::SDFBakeResources::get_sdfNormalsCS(
		        SDFBakeResources *this,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5404, 0LL) )
		    return this->fields.m_SDFNormalsCS;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5404, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1275(Patch, (Object *)this, 0LL);
		}
		
		internal Shader sdfRayMapShader { get => default; set {} } // 0x0000000189C7D7F4-0x0000000189C7D844 0x0000000189C7D90C-0x0000000189C7D970
		// Shader get_sdfRayMapShader()
		Shader *HG::Rendering::Runtime::SDF::SDFBakeResources::get_sdfRayMapShader(SDFBakeResources *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5406, 0LL) )
		    return this->fields.m_SDFRayMapShader;
		  Patch = IFix::WrappersManagerImpl::GetPatch(5406, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1100(Patch, (Object *)this, 0LL);
		}
		
	
		// Constructors
		public SDFBakeResources() {} // 0x0000000183573370-0x0000000183573380
		// SingletonScriptableObject`1[System.Object]()
		void Beyond::SingletonScriptableObject<System::Object>::SingletonScriptableObject(
		        SingletonScriptableObject_1_System_Object_ *this,
		        MethodInfo *method)
		{
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	}
}
