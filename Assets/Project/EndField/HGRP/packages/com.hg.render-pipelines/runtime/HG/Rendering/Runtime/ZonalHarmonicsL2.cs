using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	internal struct ZonalHarmonicsL2 // TypeDefIndex: 37895
	{
		// Fields
		public float[] coeffs; // 0x00
	
		// Methods
		public static ZonalHarmonicsL2 GetHenyeyGreensteinPhaseFunction(float anisotropy) => default; // 0x0000000189B5730C-0x0000000189B5741C
		public static void GetCornetteShanksPhaseFunction(ZonalHarmonicsL2 zh, float anisotropy) {} // 0x0000000189B57200-0x0000000189B5730C
		// Void GetCornetteShanksPhaseFunction(ZonalHarmonicsL2, Single)
		void HG::Rendering::Runtime::ZonalHarmonicsL2::GetCornetteShanksPhaseFunction(
		        ZonalHarmonicsL2 zh,
		        float anisotropy,
		        MethodInfo *method)
		{
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  if ( IFix::WrappersManagerImpl::IsPatched(2242, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(2242, 0LL);
		    if ( Patch )
		    {
		      IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_901(Patch, zh, anisotropy, 0LL);
		      return;
		    }
		LABEL_9:
		    sub_1800D8260(v5, v4);
		  }
		  if ( !zh.coeffs )
		    goto LABEL_9;
		  if ( !zh.coeffs->max_length.size
		    || (zh.coeffs->vector[0] = 0.28209499, zh.coeffs->max_length.size <= 1u)
		    || (zh.coeffs->vector[1] = (float)((float)((float)(anisotropy * anisotropy) + 4.0) * (float)(anisotropy * 0.29316199))
		                             / (float)((float)(anisotropy * anisotropy) + 2.0),
		        zh.coeffs->max_length.size <= 2u) )
		  {
		    sub_1800D2AB0(v5, v4);
		  }
		  zh.coeffs->vector[2] = (float)((float)((float)((float)(anisotropy * anisotropy) * 0.32440299)
		                                       * (float)(anisotropy * anisotropy))
		                               + (float)((float)((float)(anisotropy * anisotropy) * 1.44179) + 0.126157))
		                       / (float)((float)(anisotropy * anisotropy) + 2.0);
		}
		
	}
}
