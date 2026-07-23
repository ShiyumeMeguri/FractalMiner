using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[CreateAssetMenu(fileName = "HGInkSimulationShaderParams", menuName = "HG/Ink Simulation Shader Params")]
	public class HGInkSimulationShaderParamsAsset : ScriptableObject // TypeDefIndex: 37604
	{
		// Fields
		public HGInkSimulationShaderParamValues values; // 0x18
	
		// Properties
		public HGInkSimulationShaderParamValues Values { get => default; set {} } // 0x0000000189CE3E40-0x0000000189CE3EE4 0x0000000189CE3EE4-0x0000000189CE3F94
		// HGInkSimulationShaderParamValues get_Values()
		HGInkSimulationShaderParamValues *HG::Rendering::Runtime::HGInkSimulationShaderParamsAsset::get_Values(
		        HGInkSimulationShaderParamValues *__return_ptr retstr,
		        HGInkSimulationShaderParamsAsset *this,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm1
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  __int128 v8; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  HGInkSimulationShaderParamValues *v12; // rax
		  __int128 v13; // xmm1
		  __int128 v14; // xmm0
		  HGInkSimulationShaderParamValues *result; // rax
		  HGInkSimulationShaderParamValues v16; // [rsp+20h] [rbp-58h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1079, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1079, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    v12 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_414(&v16, Patch, (Object *)this, 0LL);
		    v13 = *(_OWORD *)&v12->speedInkSizeFactor;
		    *(_OWORD *)&retstr->speedRandom = *(_OWORD *)&v12->speedRandom;
		    v14 = *(_OWORD *)&v12->velocityScale;
		    *(_OWORD *)&retstr->speedInkSizeFactor = v13;
		    v7 = *(_OWORD *)&v12->landingVelocityStrength;
		    *(_OWORD *)&retstr->velocityScale = v14;
		    v8 = *(_OWORD *)&v12->vorticity;
		  }
		  else
		  {
		    v5 = *(_OWORD *)&this->fields.values.speedInkSizeFactor;
		    *(_OWORD *)&retstr->speedRandom = *(_OWORD *)&this->fields.values.speedRandom;
		    v6 = *(_OWORD *)&this->fields.values.velocityScale;
		    *(_OWORD *)&retstr->speedInkSizeFactor = v5;
		    v7 = *(_OWORD *)&this->fields.values.landingVelocityStrength;
		    *(_OWORD *)&retstr->velocityScale = v6;
		    v8 = *(_OWORD *)&this->fields.values.vorticity;
		  }
		  *(_OWORD *)&retstr->landingVelocityStrength = v7;
		  result = retstr;
		  *(_OWORD *)&retstr->vorticity = v8;
		  return result;
		}
		

		// Void set_Values(HGInkSimulationShaderParamValues)
		void HG::Rendering::Runtime::HGInkSimulationShaderParamsAsset::set_Values(
		        HGInkSimulationShaderParamsAsset *this,
		        HGInkSimulationShaderParamValues *value,
		        MethodInfo *method)
		{
		  __int128 v5; // xmm1
		  __int128 v6; // xmm0
		  __int128 v7; // xmm1
		  __int128 v8; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v10; // rdx
		  __int64 v11; // rcx
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  __int128 v14; // xmm1
		  __int128 v15; // xmm0
		  HGInkSimulationShaderParamValues v16; // [rsp+20h] [rbp-58h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1372, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1372, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v11, v10);
		    v12 = *(_OWORD *)&value->speedInkSizeFactor;
		    *(_OWORD *)&v16.speedRandom = *(_OWORD *)&value->speedRandom;
		    v13 = *(_OWORD *)&value->velocityScale;
		    *(_OWORD *)&v16.speedInkSizeFactor = v12;
		    v14 = *(_OWORD *)&value->landingVelocityStrength;
		    *(_OWORD *)&v16.velocityScale = v13;
		    v15 = *(_OWORD *)&value->vorticity;
		    *(_OWORD *)&v16.landingVelocityStrength = v14;
		    *(_OWORD *)&v16.vorticity = v15;
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_547(Patch, (Object *)this, &v16, 0LL);
		  }
		  else
		  {
		    v5 = *(_OWORD *)&value->speedInkSizeFactor;
		    *(_OWORD *)&this->fields.values.speedRandom = *(_OWORD *)&value->speedRandom;
		    v6 = *(_OWORD *)&value->velocityScale;
		    *(_OWORD *)&this->fields.values.speedInkSizeFactor = v5;
		    v7 = *(_OWORD *)&value->landingVelocityStrength;
		    *(_OWORD *)&this->fields.values.velocityScale = v6;
		    v8 = *(_OWORD *)&value->vorticity;
		    *(_OWORD *)&this->fields.values.landingVelocityStrength = v7;
		    *(_OWORD *)&this->fields.values.vorticity = v8;
		  }
		}
		
	
		// Constructors
		public HGInkSimulationShaderParamsAsset() {} // 0x0000000189CE3DF4-0x0000000189CE3E40
		// HGInkSimulationShaderParamsAsset()
		void HG::Rendering::Runtime::HGInkSimulationShaderParamsAsset::HGInkSimulationShaderParamsAsset(
		        HGInkSimulationShaderParamsAsset *this,
		        MethodInfo *method)
		{
		  HGInkSimulationShaderParamValues *Default; // rax
		  __int128 v4; // xmm1
		  __int128 v5; // xmm2
		  __int128 v6; // xmm3
		  __int128 v7; // xmm4
		  HGInkSimulationShaderParamValues v8; // [rsp+20h] [rbp-58h] BYREF
		
		  Default = HG::Rendering::Runtime::HGInkSimulationShaderParamValues::get_Default(&v8, 0LL);
		  v4 = *(_OWORD *)&Default->speedInkSizeFactor;
		  v5 = *(_OWORD *)&Default->velocityScale;
		  v6 = *(_OWORD *)&Default->landingVelocityStrength;
		  v7 = *(_OWORD *)&Default->vorticity;
		  *(_OWORD *)&this->fields.values.speedRandom = *(_OWORD *)&Default->speedRandom;
		  *(_OWORD *)&this->fields.values.speedInkSizeFactor = v4;
		  *(_OWORD *)&this->fields.values.velocityScale = v5;
		  *(_OWORD *)&this->fields.values.landingVelocityStrength = v6;
		  *(_OWORD *)&this->fields.values.vorticity = v7;
		  UnityEngine::ScriptableObject::ScriptableObject((ScriptableObject *)this, 0LL);
		}
		
	
		// Methods
		private void Reset() {} // 0x0000000189CE3D78-0x0000000189CE3DF4
		// Void Reset()
		void HG::Rendering::Runtime::HGInkSimulationShaderParamsAsset::Reset(
		        HGInkSimulationShaderParamsAsset *this,
		        MethodInfo *method)
		{
		  HGInkSimulationShaderParamValues *Default; // rax
		  __int128 v4; // xmm1
		  __int128 v5; // xmm2
		  __int128 v6; // xmm3
		  __int128 v7; // xmm4
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  HGInkSimulationShaderParamValues v11; // [rsp+20h] [rbp-58h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1373, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1373, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_0((ILFixDynamicMethodWrapper_39 *)Patch, (Object *)this, 0LL);
		  }
		  else
		  {
		    Default = HG::Rendering::Runtime::HGInkSimulationShaderParamValues::get_Default(&v11, 0LL);
		    v4 = *(_OWORD *)&Default->speedInkSizeFactor;
		    v5 = *(_OWORD *)&Default->velocityScale;
		    v6 = *(_OWORD *)&Default->landingVelocityStrength;
		    v7 = *(_OWORD *)&Default->vorticity;
		    *(_OWORD *)&this->fields.values.speedRandom = *(_OWORD *)&Default->speedRandom;
		    *(_OWORD *)&this->fields.values.speedInkSizeFactor = v4;
		    *(_OWORD *)&this->fields.values.velocityScale = v5;
		    *(_OWORD *)&this->fields.values.landingVelocityStrength = v6;
		    *(_OWORD *)&this->fields.values.vorticity = v7;
		  }
		}
		
	}
}
