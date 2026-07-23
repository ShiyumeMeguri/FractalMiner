using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class HGTAAUSettings // TypeDefIndex: 38549
	{
		// Fields
		[SerializeField]
		internal float scaleFactor; // 0x10
		[SerializeField]
		internal float occlusionDepthDiff; // 0x14
		[SerializeField]
		internal float minSharpenStrength; // 0x18
		[SerializeField]
		internal float maxSharpenStrength; // 0x1C
		[SerializeField]
		internal float historyWeight; // 0x20
		[SerializeField]
		internal float historyWeightInMotion; // 0x24
		[SerializeField]
		internal float fastConvergeHistoryWeight; // 0x28
		[SerializeField]
		internal float respnsiveAAWeight; // 0x2C
		[SerializeField]
		internal float detectMotionMin; // 0x30
		[SerializeField]
		internal float detectMotionMax; // 0x34
		[SerializeField]
		internal float characterMotionSensitivity; // 0x38
		[SerializeField]
		internal float lumaWeight; // 0x3C
	
		// Constructors
		public HGTAAUSettings() {} // 0x00000001841E1670-0x00000001841E1680
		// Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
		void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
		        HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
		        HGWindConfig *cSrc,
		        HGWindConfig *cDst,
		        float t,
		        MethodInfo *method)
		{
		  ;
		}
		
	
		// Methods
		public static HGTAAUSettings DefaultTAAUSettings() => default; // 0x00000001837D8E10-0x00000001837D8E50
		// HGTAAUSettings DefaultTAAUSettings()
		HGTAAUSettings *HG::Rendering::Runtime::HGTAAUSettings::DefaultTAAUSettings(MethodInfo *method)
		{
		  HGTAAUSettings *result; // rax
		  __int64 v2; // rdx
		  __int64 v3; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(3725, 0LL) )
		  {
		    result = (HGTAAUSettings *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::HGTAAUSettings);
		    if ( result )
		    {
		      result->fields.scaleFactor = 1.0;
		      return result;
		    }
		LABEL_4:
		    sub_1800D8260(v3, v2);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(3725, 0LL);
		  if ( !Patch )
		    goto LABEL_4;
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1300(Patch, 0LL);
		}
		
	}
}
