using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public struct HGSludgeConfig // TypeDefIndex: 37678
	{
		// Fields
		public Vector2Int textureSize; // 0x00
		public GraphicsFormat graphicsFormat; // 0x08
	
		// Properties
		public static HGSludgeConfig defaultConfig { get => default; } // 0x0000000182ED8110-0x0000000182ED8170 
		// HGSludgeConfig get_defaultConfig()
		HGSludgeConfig *HG::Rendering::Runtime::HGSludgeConfig::get_defaultConfig(
		        HGSludgeConfig *__return_ptr retstr,
		        MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		  HGSludgeConfig *v7; // rax
		  Vector2Int textureSize; // xmm0_8
		  HGSludgeConfig v9[2]; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1614, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1614, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v6, v5);
		    v7 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_652(v9, Patch, 0LL);
		    textureSize = v7->textureSize;
		    LODWORD(v7) = v7->graphicsFormat;
		    retstr->textureSize = textureSize;
		    retstr->graphicsFormat = (int)v7;
		  }
		  else
		  {
		    v9[0].textureSize = (Vector2Int)0x10000000100LL;
		    retstr->textureSize = (Vector2Int)0x10000000100LL;
		    retstr->graphicsFormat = 21;
		  }
		  return retstr;
		}
		
	}
}
