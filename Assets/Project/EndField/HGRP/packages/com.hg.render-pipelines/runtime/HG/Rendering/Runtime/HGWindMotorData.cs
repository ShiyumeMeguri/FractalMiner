using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGWindMotorData // TypeDefIndex: 37702
	{
		// Fields
		public HGWindPriority windPriority; // 0x00
		public HGWindShape shape; // 0x04
		public float rangeIn; // 0x08
		[HideInInspector]
		public float length; // 0x0C
		[HideInInspector]
		public float width; // 0x10
		[HideInInspector]
		public float height; // 0x14
		public bool rectBackward; // 0x18
		[HideInInspector]
		public float radius; // 0x1C
		[Range(0f, 360f)]
		public float angle; // 0x20
		[Range(0f, 40f)]
		public float windSpeed; // 0x24
		public Orient focus; // 0x28
		public int motorInfo; // 0x2C
		[HideInInspector]
		public float distanceToCamera; // 0x30
	
		// Properties
		public bool IsSphere { get => default; } // 0x0000000189CF7074-0x0000000189CF70C4 
		// Boolean get_IsSphere()
		bool HG::Rendering::Runtime::HGWindMotorData::get_IsSphere(HGWindMotorData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1707, 0LL) )
		    return this->shape == 0;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1707, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_683(Patch, this, 0LL);
		}
		
		public bool IsRect { get => default; } // 0x0000000189CF7024-0x0000000189CF7074 
		// Boolean get_IsRect()
		bool HG::Rendering::Runtime::HGWindMotorData::get_IsRect(HGWindMotorData *this, MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v5; // rdx
		  __int64 v6; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1708, 0LL) )
		    return this->shape == 1;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1708, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v6, v5);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_683(Patch, this, 0LL);
		}
		
	}
}
