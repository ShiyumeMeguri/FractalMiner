using System;
using UnityEngine;

namespace HG.Rendering.Runtime
{
	public class HGAtmosphereSettingParameters
	{
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector4 transmittanceLutSizeAndInv
		{
			get
			{
				// // Vector4 get_transmittanceLutSizeAndInv()
				// Vector4 *HG::Rendering::Runtime::HGAtmosphereSettingParameters::get_transmittanceLutSizeAndInv(
				//         Vector4 *__return_ptr retstr,
				//         HGAtmosphereSettingParameters *this,
				//         MethodInfo *method)
				// {
				//   Int32Enum__Enum v5; // esi
				//   Int32Enum__Enum v6; // edi
				//   Int32Enum__Enum v7; // ebx
				//   Int32Enum__Enum v8; // eax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v10; // rdx
				//   __int64 v11; // rcx
				//   Vector4 v13; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( !byte_18D9196EE )
				//   {
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
				//     byte_18D9196EE = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(3280, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3280, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v11, v10);
				//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_312(&v13, Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     v5 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
				//            (SettingParameter_1_System_Int32Enum_ *)this.fields.transmittanceLutWidth,
				//            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
				//     v6 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
				//            (SettingParameter_1_System_Int32Enum_ *)this.fields.transmittanceLutHeight,
				//            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
				//     v7 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
				//            (SettingParameter_1_System_Int32Enum_ *)this.fields.transmittanceLutWidth,
				//            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
				//     v8 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
				//            (SettingParameter_1_System_Int32Enum_ *)this.fields.transmittanceLutHeight,
				//            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
				//     retstr.y = (float)(int)v6;
				//     retstr.x = (float)(int)v5;
				//     retstr.w = 1.0 / (float)(int)v8;
				//     retstr.z = 1.0 / (float)(int)v7;
				//   }
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x060014AB RID: 5291 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector4 multiScatteredLuminanceLutSizeAndInv
		{
			get
			{
				// // Vector4 get_multiScatteredLuminanceLutSizeAndInv()
				// Vector4 *HG::Rendering::Runtime::HGAtmosphereSettingParameters::get_multiScatteredLuminanceLutSizeAndInv(
				//         Vector4 *__return_ptr retstr,
				//         HGAtmosphereSettingParameters *this,
				//         MethodInfo *method)
				// {
				//   Int32Enum__Enum v5; // esi
				//   Int32Enum__Enum v6; // edi
				//   Int32Enum__Enum v7; // ebx
				//   Int32Enum__Enum v8; // eax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v10; // rdx
				//   __int64 v11; // rcx
				//   Vector4 v13; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( !byte_18D9196EF )
				//   {
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
				//     byte_18D9196EF = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(3281, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3281, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v11, v10);
				//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_312(&v13, Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     v5 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
				//            (SettingParameter_1_System_Int32Enum_ *)this.fields.multiScatteredLuminanceLutWidth,
				//            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
				//     v6 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
				//            (SettingParameter_1_System_Int32Enum_ *)this.fields.multiScatteredLuminanceLutHeight,
				//            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
				//     v7 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
				//            (SettingParameter_1_System_Int32Enum_ *)this.fields.multiScatteredLuminanceLutWidth,
				//            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
				//     v8 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
				//            (SettingParameter_1_System_Int32Enum_ *)this.fields.multiScatteredLuminanceLutHeight,
				//            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
				//     retstr.y = (float)(int)v6;
				//     retstr.x = (float)(int)v5;
				//     retstr.w = 1.0 / (float)(int)v8;
				//     retstr.z = 1.0 / (float)(int)v7;
				//   }
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		// (get) Token: 0x060014AC RID: 5292 RVA: 0x000025D2 File Offset: 0x000007D2
		public Vector4 skyViewLutSizeAndInv
		{
			get
			{
				// // Vector4 get_skyViewLutSizeAndInv()
				// Vector4 *HG::Rendering::Runtime::HGAtmosphereSettingParameters::get_skyViewLutSizeAndInv(
				//         Vector4 *__return_ptr retstr,
				//         HGAtmosphereSettingParameters *this,
				//         MethodInfo *method)
				// {
				//   Int32Enum__Enum v5; // esi
				//   Int32Enum__Enum v6; // edi
				//   Int32Enum__Enum v7; // ebx
				//   Int32Enum__Enum v8; // eax
				//   ILFixDynamicMethodWrapper_2 *Patch; // rax
				//   __int64 v10; // rdx
				//   __int64 v11; // rcx
				//   Vector4 v13; // [rsp+20h] [rbp-18h] BYREF
				// 
				//   if ( !byte_18D9196F0 )
				//   {
				//     sub_18003C530(&MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
				//     byte_18D9196F0 = 1;
				//   }
				//   if ( IFix::WrappersManagerImpl::IsPatched(3282, 0LL) )
				//   {
				//     Patch = IFix::WrappersManagerImpl::GetPatch(3282, 0LL);
				//     if ( !Patch )
				//       sub_180B536AC(v11, v10);
				//     *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_312(&v13, Patch, (Object *)this, 0LL);
				//   }
				//   else
				//   {
				//     v5 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
				//            (SettingParameter_1_System_Int32Enum_ *)this.fields.skyViewLutWidth,
				//            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
				//     v6 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
				//            (SettingParameter_1_System_Int32Enum_ *)this.fields.skyViewLutHeight,
				//            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
				//     v7 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
				//            (SettingParameter_1_System_Int32Enum_ *)this.fields.skyViewLutWidth,
				//            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
				//     v8 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
				//            (SettingParameter_1_System_Int32Enum_ *)this.fields.skyViewLutHeight,
				//            MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
				//     retstr.y = (float)(int)v6;
				//     retstr.x = (float)(int)v5;
				//     retstr.w = 1.0 / (float)(int)v8;
				//     retstr.z = 1.0 / (float)(int)v7;
				//   }
				//   return retstr;
				// }
				// 
				return null;
			}
		}

		public HGAtmosphereSettingParameters()
		{
		}

		public const string FEATURE_NAME = "SkyAtmosphere";

		public readonly SettingParameter<float> transmittanceLutSampleCount;

		public readonly SettingParameter<int> transmittanceLutWidth;

		public readonly SettingParameter<int> transmittanceLutHeight;

		public readonly SettingParameter<float> multiScatteredLuminanceLutSampleCount;

		public readonly SettingParameter<bool> multiScatteredLuminanceLutHighQuality;

		public readonly SettingParameter<int> multiScatteredLuminanceLutWidth;

		public readonly SettingParameter<int> multiScatteredLuminanceLutHeight;

		public readonly SettingParameter<float> skyViewLutSampleCountMin;

		public readonly SettingParameter<float> skyViewLutSampleCountMax;

		public readonly SettingParameter<float> skyViewLutDistanceToSampleCountMax;

		public readonly SettingParameter<int> skyViewLutWidth;

		public readonly SettingParameter<int> skyViewLutHeight;

		public readonly SettingParameter<int> fogLutWidth;

		public readonly SettingParameter<int> fogLutHeight;

		public readonly SettingParameter<float> fogLutEncodeDistanceRatio;

		public readonly SettingParameter<bool> forceUseRenderPass;
	}
}
