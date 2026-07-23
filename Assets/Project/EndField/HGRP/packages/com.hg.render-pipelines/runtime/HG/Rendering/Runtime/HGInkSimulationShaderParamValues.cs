using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime
{
	[Serializable]
	public struct HGInkSimulationShaderParamValues // TypeDefIndex: 37603
	{
		// Fields
		[Header("\u663E\u8272")]
		[Range(0f, 5f)]
		public float speedRandom; // 0x00
		public float existingDensityInfluence; // 0x04
		[Range(-1f, 1f)]
		public float angleThres; // 0x08
		[Range(0f, 2f)]
		public float speedFactor; // 0x0C
		[Range(0f, 0.5f)]
		public float speedInkSizeFactor; // 0x10
		[Range(0f, 2f)]
		public float inkSize; // 0x14
		[Range(0f, 0.5f)]
		public float inkDirectionOffset; // 0x18
		[Header("\u53D7\u529B")]
		[Range(0f, 1f)]
		public float forceAngleRandom; // 0x1C
		[Range(0f, 5f)]
		public float velocityScale; // 0x20
		[Range(-1f, 1f)]
		public float forceAngleThres; // 0x24
		[Header("\u843D\u6C34")]
		[Range(0f, 0.2f)]
		public float landingDensityStrength; // 0x28
		[Range(-1f, 1f)]
		public float landingInkSize; // 0x2C
		[Range(0f, 5f)]
		public float landingVelocityStrength; // 0x30
		[Header("\u8870\u51CF")]
		[Range(0f, 0.05f)]
		public float densityFadeRate; // 0x34
		[Range(0f, 0.5f)]
		public float velocityFadeRate; // 0x38
		[Header("\u6D41\u4F53")]
		[Range(0f, 0.1f)]
		public float viscosity; // 0x3C
		public float vorticity; // 0x40
		public float vorticitySamplingScale; // 0x44
		[Header("Idle")]
		[Range(0f, 10f)]
		public float idleForceStrength; // 0x48
		[Range(0f, 10f)]
		public float idleForceChangeSpeed; // 0x4C
	
		// Properties
		public static HGInkSimulationShaderParamValues Default { get => default; } // 0x000000018402B780-0x000000018402B7F0 
		// HGInkSimulationShaderParamValues get_Default()
		HGInkSimulationShaderParamValues *HG::Rendering::Runtime::HGInkSimulationShaderParamValues::get_Default(
		        HGInkSimulationShaderParamValues *__return_ptr retstr,
		        MethodInfo *method)
		{
		  __m128i si128; // xmm3
		  __m128i v4; // xmm2
		  __m128i v5; // xmm1
		  __m128i v6; // xmm0
		  HGInkSimulationShaderParamValues *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v9; // rdx
		  __int64 v10; // rcx
		  HGInkSimulationShaderParamValues *v11; // rax
		  __int128 v12; // xmm1
		  __int128 v13; // xmm0
		  HGInkSimulationShaderParamValues v14; // [rsp+20h] [rbp-58h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1370, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1370, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v10, v9);
		    v11 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_545(&v14, Patch, 0LL);
		    v12 = *(_OWORD *)&v11->speedInkSizeFactor;
		    *(_OWORD *)&retstr->speedRandom = *(_OWORD *)&v11->speedRandom;
		    v13 = *(_OWORD *)&v11->velocityScale;
		    *(_OWORD *)&retstr->speedInkSizeFactor = v12;
		    v5 = *(__m128i *)&v11->landingVelocityStrength;
		    *(_OWORD *)&retstr->velocityScale = v13;
		    v6 = *(__m128i *)&v11->vorticity;
		  }
		  else
		  {
		    si128 = _mm_load_si128((const __m128i *)&xmmword_18B959900);
		    v4 = _mm_load_si128((const __m128i *)&xmmword_18B959740);
		    v5 = _mm_load_si128((const __m128i *)&xmmword_18B959910);
		    v6 = _mm_load_si128((const __m128i *)&xmmword_18B959930);
		    *(__m128i *)&retstr->speedRandom = _mm_load_si128((const __m128i *)&xmmword_18B9598F0);
		    *(__m128i *)&retstr->speedInkSizeFactor = si128;
		    *(__m128i *)&retstr->velocityScale = v4;
		  }
		  *(__m128i *)&retstr->landingVelocityStrength = v5;
		  result = retstr;
		  *(__m128i *)&retstr->vorticity = v6;
		  return result;
		}
		
	
		// Methods
		public static HGInkSimulationShaderParamValues Lerp([IsReadOnly] in HGInkSimulationShaderParamValues a, [IsReadOnly] in HGInkSimulationShaderParamValues b, float t) => default; // 0x0000000189CE3AC8-0x0000000189CE3D78
		// HGInkSimulationShaderParamValues Lerp(HGInkSimulationShaderParamValues ByRef, HGInkSimulationShaderParamValues ByRef, Single)
		HGInkSimulationShaderParamValues *HG::Rendering::Runtime::HGInkSimulationShaderParamValues::Lerp(
		        HGInkSimulationShaderParamValues *__return_ptr retstr,
		        HGInkSimulationShaderParamValues *a,
		        HGInkSimulationShaderParamValues *b,
		        float t,
		        MethodInfo *method)
		{
		  Beyond::JobMathf *v8; // rcx
		  float speedRandom; // xmm0_4
		  float existingDensityInfluence; // xmm1_4
		  float v11; // xmm0_4
		  Beyond::JobMathf *v12; // rcx
		  float angleThres; // xmm1_4
		  float v14; // xmm0_4
		  Beyond::JobMathf *v15; // rcx
		  float speedFactor; // xmm1_4
		  float v17; // xmm0_4
		  Beyond::JobMathf *v18; // rcx
		  float speedInkSizeFactor; // xmm1_4
		  float v20; // xmm0_4
		  Beyond::JobMathf *v21; // rcx
		  float inkSize; // xmm1_4
		  float v23; // xmm0_4
		  Beyond::JobMathf *v24; // rcx
		  float inkDirectionOffset; // xmm1_4
		  float v26; // xmm0_4
		  Beyond::JobMathf *v27; // rcx
		  float forceAngleRandom; // xmm1_4
		  float v29; // xmm0_4
		  Beyond::JobMathf *v30; // rcx
		  float velocityScale; // xmm1_4
		  float v32; // xmm0_4
		  Beyond::JobMathf *v33; // rcx
		  float forceAngleThres; // xmm1_4
		  float v35; // xmm0_4
		  Beyond::JobMathf *v36; // rcx
		  float landingDensityStrength; // xmm1_4
		  float v38; // xmm0_4
		  Beyond::JobMathf *v39; // rcx
		  float landingInkSize; // xmm1_4
		  float v41; // xmm0_4
		  Beyond::JobMathf *v42; // rcx
		  float landingVelocityStrength; // xmm1_4
		  float v44; // xmm0_4
		  Beyond::JobMathf *v45; // rcx
		  float densityFadeRate; // xmm1_4
		  float v47; // xmm0_4
		  Beyond::JobMathf *v48; // rcx
		  float velocityFadeRate; // xmm1_4
		  float v50; // xmm0_4
		  Beyond::JobMathf *v51; // rcx
		  float viscosity; // xmm1_4
		  float v53; // xmm0_4
		  Beyond::JobMathf *v54; // rcx
		  float vorticity; // xmm0_4
		  Beyond::JobMathf *v56; // rcx
		  float vorticitySamplingScale; // xmm1_4
		  float v58; // xmm0_4
		  Beyond::JobMathf *v59; // rcx
		  float idleForceStrength; // xmm1_4
		  float v61; // xmm0_4
		  Beyond::JobMathf *v62; // rcx
		  float idleForceChangeSpeed; // xmm1_4
		  float v64; // xmm0_4
		  Beyond::JobMathf *v65; // rcx
		  __int128 v66; // xmm1
		  __int128 v67; // xmm0
		  __int128 v68; // xmm1
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __int64 v70; // rdx
		  __int64 v71; // rcx
		  HGInkSimulationShaderParamValues *v72; // rax
		  __int128 v73; // xmm1
		  __int128 v74; // xmm0
		  __int128 v75; // xmm1
		  __int128 v76; // xmm0
		  HGInkSimulationShaderParamValues v78; // [rsp+38h] [rbp-11h] BYREF
		
		  if ( IFix::WrappersManagerImpl::IsPatched(1371, 0LL) )
		  {
		    Patch = IFix::WrappersManagerImpl::GetPatch(1371, 0LL);
		    if ( !Patch )
		      sub_1800D8260(v71, v70);
		    v72 = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_546(&v78, Patch, a, b, t, 0LL);
		    v73 = *(_OWORD *)&v72->speedInkSizeFactor;
		    *(_OWORD *)&retstr->speedRandom = *(_OWORD *)&v72->speedRandom;
		    v74 = *(_OWORD *)&v72->velocityScale;
		    *(_OWORD *)&retstr->speedInkSizeFactor = v73;
		    v75 = *(_OWORD *)&v72->landingVelocityStrength;
		    *(_OWORD *)&retstr->velocityScale = v74;
		    v76 = *(_OWORD *)&v72->vorticity;
		    *(_OWORD *)&retstr->landingVelocityStrength = v75;
		    *(_OWORD *)&retstr->vorticity = v76;
		  }
		  else
		  {
		    speedRandom = a->speedRandom;
		    Beyond::JobMathf::ClampedLerp(v8, b->speedRandom, t, t);
		    existingDensityInfluence = b->existingDensityInfluence;
		    v78.speedRandom = speedRandom;
		    v11 = a->existingDensityInfluence;
		    Beyond::JobMathf::ClampedLerp(v12, existingDensityInfluence, t, t);
		    angleThres = b->angleThres;
		    v78.existingDensityInfluence = v11;
		    v14 = a->angleThres;
		    Beyond::JobMathf::ClampedLerp(v15, angleThres, t, t);
		    speedFactor = b->speedFactor;
		    v78.angleThres = v14;
		    v17 = a->speedFactor;
		    Beyond::JobMathf::ClampedLerp(v18, speedFactor, t, t);
		    speedInkSizeFactor = b->speedInkSizeFactor;
		    v78.speedFactor = v17;
		    v20 = a->speedInkSizeFactor;
		    Beyond::JobMathf::ClampedLerp(v21, speedInkSizeFactor, t, t);
		    inkSize = b->inkSize;
		    v78.speedInkSizeFactor = v20;
		    v23 = a->inkSize;
		    Beyond::JobMathf::ClampedLerp(v24, inkSize, t, t);
		    inkDirectionOffset = b->inkDirectionOffset;
		    v78.inkSize = v23;
		    v26 = a->inkDirectionOffset;
		    Beyond::JobMathf::ClampedLerp(v27, inkDirectionOffset, t, t);
		    forceAngleRandom = b->forceAngleRandom;
		    v78.inkDirectionOffset = v26;
		    v29 = a->forceAngleRandom;
		    Beyond::JobMathf::ClampedLerp(v30, forceAngleRandom, t, t);
		    velocityScale = b->velocityScale;
		    v78.forceAngleRandom = v29;
		    v32 = a->velocityScale;
		    Beyond::JobMathf::ClampedLerp(v33, velocityScale, t, t);
		    forceAngleThres = b->forceAngleThres;
		    v78.velocityScale = v32;
		    v35 = a->forceAngleThres;
		    Beyond::JobMathf::ClampedLerp(v36, forceAngleThres, t, t);
		    landingDensityStrength = b->landingDensityStrength;
		    v78.forceAngleThres = v35;
		    v38 = a->landingDensityStrength;
		    Beyond::JobMathf::ClampedLerp(v39, landingDensityStrength, t, t);
		    landingInkSize = b->landingInkSize;
		    v78.landingDensityStrength = v38;
		    v41 = a->landingInkSize;
		    Beyond::JobMathf::ClampedLerp(v42, landingInkSize, t, t);
		    landingVelocityStrength = b->landingVelocityStrength;
		    v78.landingInkSize = v41;
		    v44 = a->landingVelocityStrength;
		    Beyond::JobMathf::ClampedLerp(v45, landingVelocityStrength, t, t);
		    densityFadeRate = b->densityFadeRate;
		    v78.landingVelocityStrength = v44;
		    v47 = a->densityFadeRate;
		    Beyond::JobMathf::ClampedLerp(v48, densityFadeRate, t, t);
		    velocityFadeRate = b->velocityFadeRate;
		    v78.densityFadeRate = v47;
		    v50 = a->velocityFadeRate;
		    Beyond::JobMathf::ClampedLerp(v51, velocityFadeRate, t, t);
		    viscosity = b->viscosity;
		    v78.velocityFadeRate = v50;
		    v53 = a->viscosity;
		    Beyond::JobMathf::ClampedLerp(v54, viscosity, t, t);
		    v78.viscosity = v53;
		    vorticity = a->vorticity;
		    Beyond::JobMathf::ClampedLerp(v56, b->vorticity, t, t);
		    vorticitySamplingScale = b->vorticitySamplingScale;
		    v78.vorticity = vorticity;
		    v58 = a->vorticitySamplingScale;
		    Beyond::JobMathf::ClampedLerp(v59, vorticitySamplingScale, t, t);
		    idleForceStrength = b->idleForceStrength;
		    v78.vorticitySamplingScale = v58;
		    v61 = a->idleForceStrength;
		    Beyond::JobMathf::ClampedLerp(v62, idleForceStrength, t, t);
		    idleForceChangeSpeed = b->idleForceChangeSpeed;
		    v78.idleForceStrength = v61;
		    v64 = a->idleForceChangeSpeed;
		    Beyond::JobMathf::ClampedLerp(v65, idleForceChangeSpeed, t, t);
		    v66 = *(_OWORD *)&v78.velocityScale;
		    *(_OWORD *)&retstr->speedRandom = *(_OWORD *)&v78.speedRandom;
		    v78.idleForceChangeSpeed = v64;
		    *(_OWORD *)&retstr->speedInkSizeFactor = *(_OWORD *)&v78.speedInkSizeFactor;
		    v67 = *(_OWORD *)&v78.landingVelocityStrength;
		    *(_OWORD *)&retstr->velocityScale = v66;
		    v68 = *(_OWORD *)&v78.vorticity;
		    *(_OWORD *)&retstr->landingVelocityStrength = v67;
		    *(_OWORD *)&retstr->vorticity = v68;
		  }
		  return retstr;
		}
		
		public static HGInkSimulationShaderParamValues Resolve([IsReadOnly] in HGInkSimulationConfig c) => default; // 0x0000000183CF1D40-0x0000000183CF1E50
		// HGInkSimulationShaderParamValues Resolve(HGInkSimulationConfig ByRef)
		HGInkSimulationShaderParamValues *HG::Rendering::Runtime::HGInkSimulationShaderParamValues::Resolve(
		        HGInkSimulationShaderParamValues *__return_ptr retstr,
		        HGInkSimulationConfig *c,
		        MethodInfo *method)
		{
		  void *v5; // rcx
		  HGInkSimulationShaderParamsAsset *v6; // rdx
		  HGInkSimulationShaderParamsAsset *shaderParams; // rsi
		  __int128 v8; // xmm1
		  __int128 v9; // xmm0
		  __int128 v10; // xmm1
		  __int128 v11; // xmm0
		  HGInkSimulationShaderParamValues *result; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  HGInkSimulationShaderParamValues *Values; // rax
		  __int128 v15; // xmm1
		  __int128 v16; // xmm0
		  __int128 v17; // xmm1
		  HGInkSimulationShaderParamValues v18; // [rsp+20h] [rbp-58h] BYREF
		
		  v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  if ( !TypeInfo::IFix::ILFixDynamicMethodWrapper->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::IFix::ILFixDynamicMethodWrapper);
		    v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		  }
		  v6 = (HGInkSimulationShaderParamsAsset *)**((_QWORD **)v5 + 23);
		  if ( !v6 )
		    goto LABEL_14;
		  if ( SLODWORD(v6->fields.values.speedRandom) > 1078 )
		  {
		    if ( !*((_DWORD *)v5 + 56) )
		    {
		      il2cpp_runtime_class_init_1(v5);
		      v5 = TypeInfo::IFix::ILFixDynamicMethodWrapper;
		    }
		    v5 = (void *)**((_QWORD **)v5 + 23);
		    if ( !v5 )
		      goto LABEL_14;
		    if ( *((_DWORD *)v5 + 6) <= 0x436u )
		      sub_1800D2AB0(v5, v6);
		    if ( *((_QWORD *)v5 + 1082) )
		    {
		      Patch = IFix::WrappersManagerImpl::GetPatch(1078, 0LL);
		      if ( Patch )
		      {
		        Values = IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_415(&v18, Patch, c, 0LL);
		LABEL_25:
		        v15 = *(_OWORD *)&Values->speedInkSizeFactor;
		        *(_OWORD *)&retstr->speedRandom = *(_OWORD *)&Values->speedRandom;
		        v16 = *(_OWORD *)&Values->velocityScale;
		        *(_OWORD *)&retstr->speedInkSizeFactor = v15;
		        v17 = *(_OWORD *)&Values->landingVelocityStrength;
		        *(_OWORD *)&retstr->velocityScale = v16;
		        v11 = *(_OWORD *)&Values->vorticity;
		        *(_OWORD *)&retstr->landingVelocityStrength = v17;
		        goto LABEL_11;
		      }
		LABEL_14:
		      sub_1800D8260(v5, v6);
		    }
		  }
		  v5 = TypeInfo::UnityEngine::Object;
		  shaderParams = c->shaderParams;
		  if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		  {
		    il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		    v5 = TypeInfo::UnityEngine::Object;
		    if ( !TypeInfo::UnityEngine::Object->_1.cctor_finished_or_no_cctor )
		    {
		      il2cpp_runtime_class_init_1(TypeInfo::UnityEngine::Object);
		      v5 = TypeInfo::UnityEngine::Object;
		    }
		  }
		  if ( shaderParams )
		  {
		    if ( !*((_DWORD *)v5 + 56) )
		      il2cpp_runtime_class_init_1(v5);
		    if ( shaderParams->fields._._.m_CachedPtr )
		    {
		      v6 = c->shaderParams;
		      if ( v6 )
		      {
		        Values = HG::Rendering::Runtime::HGInkSimulationShaderParamsAsset::get_Values(&v18, v6, 0LL);
		        goto LABEL_25;
		      }
		      goto LABEL_14;
		    }
		  }
		  v8 = *(_OWORD *)&c->resolvedShaderParams.speedInkSizeFactor;
		  *(_OWORD *)&retstr->speedRandom = *(_OWORD *)&c->resolvedShaderParams.speedRandom;
		  v9 = *(_OWORD *)&c->resolvedShaderParams.velocityScale;
		  *(_OWORD *)&retstr->speedInkSizeFactor = v8;
		  v10 = *(_OWORD *)&c->resolvedShaderParams.landingVelocityStrength;
		  *(_OWORD *)&retstr->velocityScale = v9;
		  v11 = *(_OWORD *)&c->resolvedShaderParams.vorticity;
		  *(_OWORD *)&retstr->landingVelocityStrength = v10;
		LABEL_11:
		  result = retstr;
		  *(_OWORD *)&retstr->vorticity = v11;
		  return result;
		}
		
	}
}
