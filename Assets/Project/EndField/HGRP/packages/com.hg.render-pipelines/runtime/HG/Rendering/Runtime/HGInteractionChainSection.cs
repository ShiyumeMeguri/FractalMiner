using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct HGInteractionChainSection // TypeDefIndex: 37741
	{
		// Fields
		public Vector2 VRange; // 0x00
		public float StartSize; // 0x08
		public bool Active; // 0x0C
	
		// Properties
		public static HGInteractionChainSection DefaultValue { get => default; } // 0x0000000189CFC1F8-0x0000000189CFC26C 
		// HGInteractionChainSection get_DefaultValue()
		HGInteractionChainSection *HG::Rendering::Runtime::HGInteractionChainSection::get_DefaultValue(
		        HGInteractionChainSection *__return_ptr retstr,
		        MethodInfo *method)
		{
		  HGInteractionChainSection v3; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGInteractionChainSection *result; // rax
		  HGInteractionChainSection v8; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1780, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1780, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    v3 = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_716(&v8, Patch, 0LL);
		  }
		  else
		  {
		    v8 = (HGInteractionChainSection)0LL;
		    v3 = (HGInteractionChainSection)0;
		  }
		  result = retstr;
		  *retstr = v3;
		  return result;
		}
		
	}
}
