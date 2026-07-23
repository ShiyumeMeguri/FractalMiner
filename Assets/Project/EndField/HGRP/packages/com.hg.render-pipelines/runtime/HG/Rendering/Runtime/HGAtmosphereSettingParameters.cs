using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	public class HGAtmosphereSettingParameters // TypeDefIndex: 38601
	{
		// Fields
		public const string FEATURE_NAME = "SkyAtmosphere"; // Metadata: 0x02303F24
		public readonly SettingParameter<float> transmittanceLutSampleCount; // 0x10
		public readonly SettingParameter<int> transmittanceLutWidth; // 0x18
		public readonly SettingParameter<int> transmittanceLutHeight; // 0x20
		public readonly SettingParameter<float> multiScatteredLuminanceLutSampleCount; // 0x28
		public readonly SettingParameter<bool> multiScatteredLuminanceLutHighQuality; // 0x30
		public readonly SettingParameter<int> multiScatteredLuminanceLutWidth; // 0x38
		public readonly SettingParameter<int> multiScatteredLuminanceLutHeight; // 0x40
		public readonly SettingParameter<float> skyViewLutSampleCountMin; // 0x48
		public readonly SettingParameter<float> skyViewLutSampleCountMax; // 0x50
		public readonly SettingParameter<float> skyViewLutDistanceToSampleCountMax; // 0x58
		public readonly SettingParameter<int> skyViewLutWidth; // 0x60
		public readonly SettingParameter<int> skyViewLutHeight; // 0x68
		public readonly SettingParameter<int> fogLutWidth; // 0x70
		public readonly SettingParameter<int> fogLutHeight; // 0x78
		public readonly SettingParameter<float> fogLutEncodeDistanceRatio; // 0x80
		public readonly SettingParameter<bool> forceUseRenderPass; // 0x88
	
		// Properties
		public Vector4 transmittanceLutSizeAndInv { get => default; } // 0x0000000189C13718-0x0000000189C13828 
		// Vector4 get_transmittanceLutSizeAndInv()
		Vector4 *HG::Rendering::Runtime::HGAtmosphereSettingParameters::get_transmittanceLutSizeAndInv(
		        Vector4 *__return_ptr retstr,
		        HGAtmosphereSettingParameters *this,
		        MethodInfo *method)
		{
		  Int32Enum__Enum v5; // esi
		  Int32Enum__Enum v6; // edi
		  Int32Enum__Enum v7; // ebx
		  Int32Enum__Enum v8; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Vector4 v13; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3896, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3896, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(&v13, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v5 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		           (SettingParameter_1_System_Int32Enum_ *)this->fields.transmittanceLutWidth,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    v6 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		           (SettingParameter_1_System_Int32Enum_ *)this->fields.transmittanceLutHeight,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    v7 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		           (SettingParameter_1_System_Int32Enum_ *)this->fields.transmittanceLutWidth,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    v8 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		           (SettingParameter_1_System_Int32Enum_ *)this->fields.transmittanceLutHeight,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    retstr->y = (float)(int)v6;
		    retstr->x = (float)(int)v5;
		    retstr->w = 1.0 / (float)(int)v8;
		    retstr->z = 1.0 / (float)(int)v7;
		  }
		  return retstr;
		}
		
		public Vector4 multiScatteredLuminanceLutSizeAndInv { get => default; } // 0x0000000189C134F8-0x0000000189C13608 
		// Vector4 get_multiScatteredLuminanceLutSizeAndInv()
		Vector4 *HG::Rendering::Runtime::HGAtmosphereSettingParameters::get_multiScatteredLuminanceLutSizeAndInv(
		        Vector4 *__return_ptr retstr,
		        HGAtmosphereSettingParameters *this,
		        MethodInfo *method)
		{
		  Int32Enum__Enum v5; // esi
		  Int32Enum__Enum v6; // edi
		  Int32Enum__Enum v7; // ebx
		  Int32Enum__Enum v8; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Vector4 v13; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3897, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3897, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(&v13, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v5 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		           (SettingParameter_1_System_Int32Enum_ *)this->fields.multiScatteredLuminanceLutWidth,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    v6 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		           (SettingParameter_1_System_Int32Enum_ *)this->fields.multiScatteredLuminanceLutHeight,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    v7 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		           (SettingParameter_1_System_Int32Enum_ *)this->fields.multiScatteredLuminanceLutWidth,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    v8 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		           (SettingParameter_1_System_Int32Enum_ *)this->fields.multiScatteredLuminanceLutHeight,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    retstr->y = (float)(int)v6;
		    retstr->x = (float)(int)v5;
		    retstr->w = 1.0 / (float)(int)v8;
		    retstr->z = 1.0 / (float)(int)v7;
		  }
		  return retstr;
		}
		
		public Vector4 skyViewLutSizeAndInv { get => default; } // 0x0000000189C13608-0x0000000189C13718 
		// Vector4 get_skyViewLutSizeAndInv()
		Vector4 *HG::Rendering::Runtime::HGAtmosphereSettingParameters::get_skyViewLutSizeAndInv(
		        Vector4 *__return_ptr retstr,
		        HGAtmosphereSettingParameters *this,
		        MethodInfo *method)
		{
		  Int32Enum__Enum v5; // esi
		  Int32Enum__Enum v6; // edi
		  Int32Enum__Enum v7; // ebx
		  Int32Enum__Enum v8; // eax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  Vector4 v13; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(3898, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(3898, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    *retstr = *IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_350(&v13, Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    v5 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		           (SettingParameter_1_System_Int32Enum_ *)this->fields.skyViewLutWidth,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    v6 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		           (SettingParameter_1_System_Int32Enum_ *)this->fields.skyViewLutHeight,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    v7 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		           (SettingParameter_1_System_Int32Enum_ *)this->fields.skyViewLutWidth,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    v8 = HG::Rendering::Runtime::SettingParameter<System::Int32Enum>::op_Implicit(
		           (SettingParameter_1_System_Int32Enum_ *)this->fields.skyViewLutHeight,
		           MethodInfo::HG::Rendering::Runtime::SettingParameter<int>::op_Implicit);
		    retstr->y = (float)(int)v6;
		    retstr->x = (float)(int)v5;
		    retstr->w = 1.0 / (float)(int)v8;
		    retstr->z = 1.0 / (float)(int)v7;
		  }
		  return retstr;
		}
		
	
		// Constructors
		public HGAtmosphereSettingParameters() {} // 0x0000000183658420-0x0000000183658710
		// HGAtmosphereSettingParameters()
		void HG::Rendering::Runtime::HGAtmosphereSettingParameters::HGAtmosphereSettingParameters(
		        HGAtmosphereSettingParameters *this,
		        MethodInfo *method)
		{
		  Type *v3; // rdx
		  PropertyInfo_1 *v4; // r8
		  Int32__Array **v5; // r9
		  Type *v6; // rdx
		  PropertyInfo_1 *v7; // r8
		  Int32__Array **v8; // r9
		  Type *v9; // rdx
		  PropertyInfo_1 *v10; // r8
		  Int32__Array **v11; // r9
		  Type *v12; // rdx
		  PropertyInfo_1 *v13; // r8
		  Int32__Array **v14; // r9
		  Type *v15; // rdx
		  PropertyInfo_1 *v16; // r8
		  Int32__Array **v17; // r9
		  Type *v18; // rdx
		  PropertyInfo_1 *v19; // r8
		  Int32__Array **v20; // r9
		  Type *v21; // rdx
		  PropertyInfo_1 *v22; // r8
		  Int32__Array **v23; // r9
		  Type *v24; // rdx
		  PropertyInfo_1 *v25; // r8
		  Int32__Array **v26; // r9
		  Type *v27; // rdx
		  PropertyInfo_1 *v28; // r8
		  Int32__Array **v29; // r9
		  Type *v30; // rdx
		  PropertyInfo_1 *v31; // r8
		  Int32__Array **v32; // r9
		  Type *v33; // rdx
		  PropertyInfo_1 *v34; // r8
		  Int32__Array **v35; // r9
		  Type *v36; // rdx
		  PropertyInfo_1 *v37; // r8
		  Int32__Array **v38; // r9
		  Type *v39; // rdx
		  PropertyInfo_1 *v40; // r8
		  Int32__Array **v41; // r9
		  Type *v42; // rdx
		  PropertyInfo_1 *v43; // r8
		  Int32__Array **v44; // r9
		  Type *v45; // rdx
		  PropertyInfo_1 *v46; // r8
		  Int32__Array **v47; // r9
		  Type *v48; // rdx
		  PropertyInfo_1 *v49; // r8
		  Int32__Array **v50; // r9
		  MethodInfo *v51; // [rsp+20h] [rbp-8h]
		  MethodInfo *v52; // [rsp+20h] [rbp-8h]
		  MethodInfo *v53; // [rsp+20h] [rbp-8h]
		  MethodInfo *v54; // [rsp+20h] [rbp-8h]
		  MethodInfo *v55; // [rsp+20h] [rbp-8h]
		  MethodInfo *v56; // [rsp+20h] [rbp-8h]
		  MethodInfo *v57; // [rsp+20h] [rbp-8h]
		  MethodInfo *v58; // [rsp+20h] [rbp-8h]
		  MethodInfo *v59; // [rsp+20h] [rbp-8h]
		  MethodInfo *v60; // [rsp+20h] [rbp-8h]
		  MethodInfo *v61; // [rsp+20h] [rbp-8h]
		  MethodInfo *v62; // [rsp+20h] [rbp-8h]
		  MethodInfo *v63; // [rsp+20h] [rbp-8h]
		  MethodInfo *v64; // [rsp+20h] [rbp-8h]
		  MethodInfo *v65; // [rsp+20h] [rbp-8h]
		  MethodInfo *v66; // [rsp+50h] [rbp+28h]
		
		  this->fields.transmittanceLutSampleCount = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                               10.0,
		                                               (String *)"SkyAtmosphere",
		                                               (String *)"transmittanceLutSampleCount",
		                                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields, v3, v4, v5, v51);
		  this->fields.transmittanceLutWidth = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                         256,
		                                         (String *)"SkyAtmosphere",
		                                         (String *)"transmittanceLutWidth",
		                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.transmittanceLutWidth, v6, v7, v8, v52);
		  this->fields.transmittanceLutHeight = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                          64,
		                                          (String *)"SkyAtmosphere",
		                                          (String *)"transmittanceLutHeight",
		                                          MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.transmittanceLutHeight, v9, v10, v11, v53);
		  this->fields.multiScatteredLuminanceLutSampleCount = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                         15.0,
		                                                         (String *)"SkyAtmosphere",
		                                                         (String *)"multiScatteredLuminanceLutSampleCount",
		                                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.multiScatteredLuminanceLutSampleCount, v12, v13, v14, v54);
		  this->fields.multiScatteredLuminanceLutHighQuality = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                                         0,
		                                                         (String *)"SkyAtmosphere",
		                                                         (String *)"multiScatteredLuminanceLutHighQuality",
		                                                         MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.multiScatteredLuminanceLutHighQuality, v15, v16, v17, v55);
		  this->fields.multiScatteredLuminanceLutWidth = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                   32,
		                                                   (String *)"SkyAtmosphere",
		                                                   (String *)"multiScatteredLuminanceLutWidth",
		                                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.multiScatteredLuminanceLutWidth, v18, v19, v20, v56);
		  this->fields.multiScatteredLuminanceLutHeight = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                                    32,
		                                                    (String *)"SkyAtmosphere",
		                                                    (String *)"multiScatteredLuminanceLutHeight",
		                                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.multiScatteredLuminanceLutHeight, v21, v22, v23, v57);
		  this->fields.skyViewLutSampleCountMin = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                            2.0,
		                                            (String *)"SkyAtmosphere",
		                                            (String *)"skyViewLutSampleCountMin",
		                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.skyViewLutSampleCountMin, v24, v25, v26, v58);
		  this->fields.skyViewLutSampleCountMax = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                            32.0,
		                                            (String *)"SkyAtmosphere",
		                                            (String *)"skyViewLutSampleCountMax",
		                                            MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.skyViewLutSampleCountMax, v27, v28, v29, v59);
		  this->fields.skyViewLutDistanceToSampleCountMax = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                                      150.0,
		                                                      (String *)"SkyAtmosphere",
		                                                      (String *)"skyViewLutDistanceToSampleCountMax",
		                                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.skyViewLutDistanceToSampleCountMax, v30, v31, v32, v60);
		  this->fields.skyViewLutWidth = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                   128,
		                                   (String *)"SkyAtmosphere",
		                                   (String *)"skyViewLutWidth",
		                                   MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.skyViewLutWidth, v33, v34, v35, v61);
		  this->fields.skyViewLutHeight = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                    128,
		                                    (String *)"SkyAtmosphere",
		                                    (String *)"skyViewLutHeight",
		                                    MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.skyViewLutHeight, v36, v37, v38, v62);
		  this->fields.fogLutWidth = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                               64,
		                               (String *)"SkyAtmosphere",
		                               (String *)"fogLutWidth",
		                               MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.fogLutWidth, v39, v40, v41, v63);
		  this->fields.fogLutHeight = HG::Rendering::Runtime::SettingParameter::Create<int>(
		                                64,
		                                (String *)"SkyAtmosphere",
		                                (String *)"fogLutHeight",
		                                MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<int>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.fogLutHeight, v42, v43, v44, v64);
		  this->fields.fogLutEncodeDistanceRatio = HG::Rendering::Runtime::SettingParameter::Create<float>(
		                                             0.0099999998,
		                                             (String *)"SkyAtmosphere",
		                                             (String *)"fogLutEncodeDistanceRatio",
		                                             MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<float>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.fogLutEncodeDistanceRatio, v45, v46, v47, v65);
		  this->fields.forceUseRenderPass = HG::Rendering::Runtime::SettingParameter::Create<bool>(
		                                      0,
		                                      (String *)"SkyAtmosphere",
		                                      (String *)"forceUseRenderPass",
		                                      MethodInfo::HG::Rendering::Runtime::SettingParameter::Create<bool>);
		  sub_18002D1B0((SingleFieldAccessor *)&this->fields.forceUseRenderPass, v48, v49, v50, v66);
		}
		
	}
}
