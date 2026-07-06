using System;
using System.Runtime.InteropServices;

namespace HG.Rendering.Runtime
{
	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
	internal struct ZonalHarmonicsL2
	{
		public static ZonalHarmonicsL2 GetHenyeyGreensteinPhaseFunction(float anisotropy)
		{
			return null;
		}

		public static void GetCornetteShanksPhaseFunction(ZonalHarmonicsL2 zh, float anisotropy)
		{
			// // Void GetCornetteShanksPhaseFunction(ZonalHarmonicsL2, Single)
			// void HG::Rendering::Runtime::ZonalHarmonicsL2::GetCornetteShanksPhaseFunction(
			//         ZonalHarmonicsL2 zh,
			//         float anisotropy,
			//         MethodInfo *method)
			// {
			//   __int64 v4; // rdx
			//   __int64 v5; // rcx
			//   ILFixDynamicMethodWrapper_2 *Patch; // rax
			// 
			//   if ( IFix::WrappersManagerImpl::IsPatched(1890, 0LL) )
			//   {
			//     Patch = IFix::WrappersManagerImpl::GetPatch(1890, 0LL);
			//     if ( Patch )
			//     {
			//       IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_737(Patch, zh, anisotropy, 0LL);
			//       return;
			//     }
			// LABEL_9:
			//     sub_180B536AC(v5, v4);
			//   }
			//   if ( !zh.coeffs )
			//     goto LABEL_9;
			//   if ( !zh.coeffs.max_length.size
			//     || (zh.coeffs.vector[0] = 0.28209499, zh.coeffs.max_length.size <= 1u)
			//     || (zh.coeffs.vector[1] = (float)((float)((float)(anisotropy * anisotropy) + 4.0) * (float)(anisotropy * 0.29316199))
			//                              / (float)((float)(anisotropy * anisotropy) + 2.0),
			//         zh.coeffs.max_length.size <= 2u) )
			//   {
			//     sub_180070270(v5, v4);
			//   }
			//   zh.coeffs.vector[2] = (float)((float)((float)((float)(anisotropy * anisotropy) * 0.32440299)
			//                                        * (float)(anisotropy * anisotropy))
			//                                + (float)((float)((float)(anisotropy * anisotropy) * 1.44179) + 0.126157))
			//                        / (float)((float)(anisotropy * anisotropy) + 2.0);
			// }
			// 
		}

		public float[] coeffs;
	}
}
