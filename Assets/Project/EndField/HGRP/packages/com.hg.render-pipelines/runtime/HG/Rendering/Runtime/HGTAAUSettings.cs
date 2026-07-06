using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	[Serializable]
	public class HGTAAUSettings
	{
		public HGTAAUSettings()
		{
			// // Void Lerp[HGWindConfig](HGWindConfig ByRef, HGWindConfig ByRef, Single)
			// void HG::Rendering::Runtime::HGCelestialConfig::HGCelestialAdvancedObjectConfig::Lerp<HG::Rendering::Runtime::HGWindConfig>(
			//         HGCelestialConfig_HGCelestialAdvancedObjectConfig *this,
			//         HGWindConfig *cSrc,
			//         HGWindConfig *cDst,
			//         float t,
			//         MethodInfo *method)
			// {
			//   ;
			// }
			// 
		}

		public static HGTAAUSettings DefaultTAAUSettings()
		{
			// // HGTAAUSettings DefaultTAAUSettings()
			// HGTAAUSettings *HG::Rendering::Runtime::HGTAAUSettings::DefaultTAAUSettings(MethodInfo *method)
			// {
			//   HGTAAUSettings *result; // rax
			//   __int64 v2; // rdx
			//   __int64 v3; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( !byte_18D8EDB28 )
			//   {
			//     sub_18003C530(&TypeInfo::HG::Rendering::Runtime::HGTAAUSettings);
			//     byte_18D8EDB28 = 1;
			//   }
			//   if ( !IFix::WrappersManagerImpl::IsPatched(3124, 0LL) )
			//   {
			//     result = (HGTAAUSettings *)sub_180004920(TypeInfo::HG::Rendering::Runtime::HGTAAUSettings);
			//     if ( result )
			//     {
			//       result.fields.scaleFactor = 1.0;
			//       return result;
			//     }
			// LABEL_6:
			//     sub_180B536AC(v3, v2);
			//   }
			//   Patch = IFix::WrappersManagerImpl::GetPatch(3124, 0LL);
			//   if ( !Patch )
			//     goto LABEL_6;
			//   return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1095(Patch, 0LL);
			// }
			// 
			return null;
		}

		[SerializeField]
		internal float scaleFactor;

		[SerializeField]
		internal float occlusionDepthDiff;

		[SerializeField]
		internal float minSharpenStrength;

		[SerializeField]
		internal float maxSharpenStrength;

		[SerializeField]
		internal float historyWeight;

		[SerializeField]
		internal float historyWeightInMotion;

		[SerializeField]
		internal float fastConvergeHistoryWeight;

		[SerializeField]
		internal float respnsiveAAWeight;

		[SerializeField]
		internal float detectMotionMin;

		[SerializeField]
		internal float detectMotionMax;

		[SerializeField]
		internal float characterMotionSensitivity;

		[SerializeField]
		internal float lumaWeight;
	}
}
