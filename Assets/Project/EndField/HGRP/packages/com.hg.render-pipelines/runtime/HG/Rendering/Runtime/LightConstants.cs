using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal class LightConstants // TypeDefIndex: 37774
	{
		// Fields
		public const int MAX_DIRECTIONAL_LIGHTS = 4; // Metadata: 0x023030F1
		public const int NUM_DIR_LIGHT_DATA_BYTES = 5; // Metadata: 0x023030F2
		public const int NUM_LIGHT_COUNT_DATA_BYTES = 1; // Metadata: 0x023030F3
		public const int MAX_VISIBLE_LIGHTS = 256; // Metadata: 0x023030F4
	
		// Properties
		public static int NUM_PUNCTUAL_LIGHT_MASK_BYTES { get => default; } // 0x0000000189D0A5B8-0x0000000189D0A5FC 
		// Int32 get_NUM_PUNCTUAL_LIGHT_MASK_BYTES()
		int32_t HG::Rendering::Runtime::LightConstants::get_NUM_PUNCTUAL_LIGHT_MASK_BYTES(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1935, 0LL) )
		    return 32;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1935, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
		public static int NUM_PUNCTUAL_LIGHT_MASK_UNITS { get => default; } // 0x0000000189D0A5FC-0x0000000189D0A64C 
		// Int32 get_NUM_PUNCTUAL_LIGHT_MASK_UNITS()
		int32_t HG::Rendering::Runtime::LightConstants::get_NUM_PUNCTUAL_LIGHT_MASK_UNITS(MethodInfo *method)
		{
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v3; // rdx
		  __int64 v4; // rcx
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(1936, 0LL) )
		    return HG::Rendering::Runtime::LightConstants::get_NUM_PUNCTUAL_LIGHT_MASK_BYTES(0LL) / 4;
		  Patch = IFix::WrappersManagerImpl::GetPatch(1936, 0LL);
		  if ( !Patch )
		    sub_1800D8260(v4, v3);
		  return IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_14((ILFixDynamicMethodWrapper_30 *)Patch, 0LL);
		}
		
	
		// Constructors
		public LightConstants() {} // 0x00000001841E1670-0x00000001841E1680
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
		
	}
}
