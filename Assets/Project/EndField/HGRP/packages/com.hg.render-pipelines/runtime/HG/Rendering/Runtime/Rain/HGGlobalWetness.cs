using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.Rain
{
	public class HGGlobalWetness : HGBaseWetnessFeature // TypeDefIndex: 38851
	{
		// Fields
		private GlobalWetnessRenderParams m_globalWetnessRenderParams; // 0x18
	
		// Nested types
		private class GlobalWetnessRenderParams // TypeDefIndex: 38850
		{
			// Fields
			public float wetness; // 0x10
			public float wetnessBasePorosity; // 0x14
			public float wetnessPorosityFactor; // 0x18
			public float baseWetnessLevel; // 0x1C
			public float verticalWetnessScalar; // 0x20
			public float wetnessOcclusionRange; // 0x24
			public float farSceneWetnessDistanceFactor; // 0x28
			public float farSceneWetnessValue; // 0x2C
			public float wetnessProceduralForWater; // 0x30
			public float wetnessHighQualityReflection; // 0x34
	
			// Constructors
			public GlobalWetnessRenderParams() {} // 0x0000000184DA20E0-0x0000000184DA2100
			// HGGlobalWetness+GlobalWetnessRenderParams()
			void HG::Rendering::Runtime::Rain::HGGlobalWetness::GlobalWetnessRenderParams::GlobalWetnessRenderParams(
			        HGGlobalWetness_GlobalWetnessRenderParams *this,
			        MethodInfo *method)
			{
			  this->fields.baseWetnessLevel = 1.0;
			  this->fields.verticalWetnessScalar = 1.0;
			  this->fields.farSceneWetnessDistanceFactor = 1.0;
			  this->fields.farSceneWetnessValue = 1.0;
			}
			
		}
	
		// Constructors
		public HGGlobalWetness() {} // 0x0000000182EDA8E0-0x0000000182EDA930
		// HGGlobalWetness()
		void HG::Rendering::Runtime::Rain::HGGlobalWetness::HGGlobalWetness(HGGlobalWetness *this, MethodInfo *method)
		{
		  __int64 v3; // rax
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v4; // rdx
		  __int64 v5; // rcx
		  VolumetricRenderer_VolumetricBounds *v6; // r8
		  Int32__Array **v7; // r9
		  MethodInfo *v8; // [rsp+50h] [rbp+28h]
		  MethodInfo *v9; // [rsp+58h] [rbp+30h]
		  int32_t v10; // [rsp+60h] [rbp+38h]
		  int32_t v11; // [rsp+68h] [rbp+40h]
		  float v12; // [rsp+70h] [rbp+48h]
		  int32_t v13; // [rsp+78h] [rbp+50h]
		  bool v14; // [rsp+80h] [rbp+58h]
		  bool v15; // [rsp+88h] [rbp+60h]
		  MethodInfo *v16; // [rsp+90h] [rbp+68h]
		
		  v3 = sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Rain::HGGlobalWetness::GlobalWetnessRenderParams);
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  *(_DWORD *)(v3 + 28) = 1065353216;
		  *(_DWORD *)(v3 + 32) = 1065353216;
		  *(_DWORD *)(v3 + 40) = 1065353216;
		  *(_DWORD *)(v3 + 44) = 1065353216;
		  this->fields.m_globalWetnessRenderParams = (HGGlobalWetness_GlobalWetnessRenderParams *)v3;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_globalWetnessRenderParams,
		    v4,
		    v6,
		    v7,
		    v8,
		    v9,
		    v10,
		    v11,
		    v12,
		    v13,
		    v14,
		    v15,
		    v16);
		}
		
	
		// Methods
		internal override void UpdateData(RainCommonRenderingParam rainCommonRenderingParam, float deltaTime) {} // 0x0000000189CDB1C4-0x0000000189CDB34C
		// Void UpdateData(RainCommonRenderingParam, Single)
		void HG::Rendering::Runtime::Rain::HGGlobalWetness::UpdateData(
		        HGGlobalWetness *this,
		        RainCommonRenderingParam *rainCommonRenderingParam,
		        float deltaTime,
		        MethodInfo *method)
		{
		  __int64 v6; // rdx
		  RainCommonPreSettingParam *commonPresettingParam; // rcx
		  int v8; // ebx
		  HGGlobalWetness_GlobalWetnessRenderParams *m_globalWetnessRenderParams; // rax
		  HGGlobalWetness_GlobalWetnessRenderParams *v10; // rax
		  HGGlobalWetness_GlobalWetnessRenderParams *v11; // rax
		  HGGlobalWetness_GlobalWetnessRenderParams *v12; // rax
		  HGGlobalWetness_GlobalWetnessRenderParams *v13; // rax
		  HGGlobalWetness_GlobalWetnessRenderParams *v14; // rax
		  HGGlobalWetness_GlobalWetnessRenderParams *v15; // rax
		  HGGlobalWetness_GlobalWetnessRenderParams *v16; // rax
		  HGGlobalWetness_GlobalWetnessRenderParams *v17; // rax
		  HGGlobalWetness_GlobalWetnessRenderParams *v18; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		
		  v8 = 0;
		  if ( !IFix::WrappersManagerImpl::IsPatched(5480, 0LL) )
		  {
		    m_globalWetnessRenderParams = this->fields.m_globalWetnessRenderParams;
		    if ( rainCommonRenderingParam )
		    {
		      if ( m_globalWetnessRenderParams )
		      {
		        m_globalWetnessRenderParams->fields.wetness = rainCommonRenderingParam->fields.wetness;
		        v10 = this->fields.m_globalWetnessRenderParams;
		        if ( v10 )
		        {
		          v10->fields.wetnessBasePorosity = rainCommonRenderingParam->fields.wetnessBasePorosity;
		          v11 = this->fields.m_globalWetnessRenderParams;
		          if ( v11 )
		          {
		            v11->fields.wetnessPorosityFactor = rainCommonRenderingParam->fields.wetnessPorosityFactor;
		            commonPresettingParam = rainCommonRenderingParam->fields.commonPresettingParam;
		            v12 = this->fields.m_globalWetnessRenderParams;
		            if ( commonPresettingParam )
		            {
		              if ( v12 )
		              {
		                v12->fields.wetnessOcclusionRange = commonPresettingParam->fields.rainOcclusionMapRange;
		                v13 = this->fields.m_globalWetnessRenderParams;
		                if ( v13 )
		                {
		                  v13->fields.farSceneWetnessDistanceFactor = rainCommonRenderingParam->fields.farSceneWetnessDistanceFactor;
		                  v14 = this->fields.m_globalWetnessRenderParams;
		                  if ( v14 )
		                  {
		                    v14->fields.farSceneWetnessValue = rainCommonRenderingParam->fields.farSceneWetnessValue;
		                    v15 = this->fields.m_globalWetnessRenderParams;
		                    if ( v15 )
		                    {
		                      v15->fields.baseWetnessLevel = rainCommonRenderingParam->fields.baseWetnessLevel;
		                      v16 = this->fields.m_globalWetnessRenderParams;
		                      if ( v16 )
		                      {
		                        v16->fields.verticalWetnessScalar = rainCommonRenderingParam->fields.verticalWetnessScalar;
		                        v17 = this->fields.m_globalWetnessRenderParams;
		                        if ( v17 )
		                        {
		                          v17->fields.wetnessProceduralForWater = rainCommonRenderingParam->fields.wetnessProceduralForWater;
		                          v18 = this->fields.m_globalWetnessRenderParams;
		                          if ( v18 )
		                          {
		                            LOBYTE(v8) = rainCommonRenderingParam->fields.wetnessHighQualityKwEnabled;
		                            v18->fields.wetnessHighQualityReflection = (float)v8;
		                            return;
		                          }
		                        }
		                      }
		                    }
		                  }
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_16:
		    sub_1800D8260(commonPresettingParam, v6);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5480, 0LL);
		  if ( !Patch )
		    goto LABEL_16;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_66(
		    (ILFixDynamicMethodWrapper_9 *)Patch,
		    (Object *)this,
		    (Object *)rainCommonRenderingParam,
		    deltaTime,
		    0LL);
		}
		
		internal override void SetData(RainWetnessGlobalProps globalProps) {} // 0x0000000189CDAFE0-0x0000000189CDB1AC
		// Void SetData(RainWetnessGlobalProps)
		void HG::Rendering::Runtime::Rain::HGGlobalWetness::SetData(
		        HGGlobalWetness *this,
		        RainWetnessGlobalProps *globalProps,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGGlobalWetness_GlobalWetnessRenderParams *v6; // rcx
		  HGGlobalWetness_GlobalWetnessRenderParams *m_globalWetnessRenderParams; // rax
		  Vector4__Array *rainWetnessGlobalParams; // rsi
		  float wetness; // xmm8_4
		  float wetnessBasePorosity; // xmm9_4
		  float wetnessPorosityFactor; // xmm7_4
		  float wetnessOcclusionRange; // xmm6_4
		  Vector4 *v13; // rax
		  HGGlobalWetness_GlobalWetnessRenderParams *v14; // r8
		  Vector4__Array *v15; // rsi
		  Vector4 *v16; // rax
		  Vector4__Array *v17; // rdi
		  Vector4 *v18; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v20[3]; // [rsp+30h] [rbp-58h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5481, 0LL) )
		  {
		    if ( globalProps )
		    {
		      m_globalWetnessRenderParams = this->fields.m_globalWetnessRenderParams;
		      rainWetnessGlobalParams = globalProps->fields.rainWetnessGlobalParams;
		      if ( m_globalWetnessRenderParams )
		      {
		        wetness = m_globalWetnessRenderParams->fields.wetness;
		        wetnessBasePorosity = m_globalWetnessRenderParams->fields.wetnessBasePorosity;
		        wetnessPorosityFactor = m_globalWetnessRenderParams->fields.wetnessPorosityFactor;
		        wetnessOcclusionRange = m_globalWetnessRenderParams->fields.wetnessOcclusionRange;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        v13 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                v20,
		                wetness,
		                wetnessBasePorosity,
		                wetnessPorosityFactor,
		                wetnessOcclusionRange,
		                0LL);
		        if ( rainWetnessGlobalParams )
		        {
		          v20[0] = *v13;
		          sub_18003FEF0(rainWetnessGlobalParams, 0LL, v20);
		          v14 = this->fields.m_globalWetnessRenderParams;
		          v15 = globalProps->fields.rainWetnessGlobalParams;
		          if ( v14 )
		          {
		            v16 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                    v20,
		                    v14->fields.farSceneWetnessDistanceFactor,
		                    v14->fields.farSceneWetnessValue,
		                    v14->fields.baseWetnessLevel,
		                    v14->fields.verticalWetnessScalar,
		                    0LL);
		            if ( v15 )
		            {
		              v20[0] = *v16;
		              sub_18003FEF0(v15, 8LL, v20);
		              v6 = this->fields.m_globalWetnessRenderParams;
		              v17 = globalProps->fields.rainWetnessGlobalParams;
		              if ( v6 )
		              {
		                v18 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                        v20,
		                        v6->fields.wetnessProceduralForWater,
		                        v6->fields.wetnessHighQualityReflection,
		                        0.0,
		                        0.0,
		                        0LL);
		                if ( v17 )
		                {
		                  v20[0] = *v18;
		                  sub_18003FEF0(v17, 9LL, v20);
		                  return;
		                }
		              }
		            }
		          }
		        }
		      }
		    }
		LABEL_11:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5481, 0LL);
		  if ( !Patch )
		    goto LABEL_11;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)globalProps,
		    0LL);
		}
		
		internal override void ResetData(RainWetnessGlobalProps globalProps) {} // 0x0000000189CDAF10-0x0000000189CDAFE0
		// Void ResetData(RainWetnessGlobalProps)
		void HG::Rendering::Runtime::Rain::HGGlobalWetness::ResetData(
		        HGGlobalWetness *this,
		        RainWetnessGlobalProps *globalProps,
		        MethodInfo *method)
		{
		  TileBase *v5; // rdx
		  Vector4__Array *v6; // rcx
		  Vector3Int *v7; // r8
		  ITilemap *v8; // r9
		  TileAnimationData *TileAnimationDataNoRef; // rax
		  Vector4__Array *rainWetnessGlobalParams; // rcx
		  __m128i si128; // xmm0
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  __m128i v13; // [rsp+20h] [rbp-18h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5482, 0LL) )
		  {
		    if ( globalProps )
		    {
		      TileAnimationDataNoRef = UnityEngine::Tilemaps::TileBase::GetTileAnimationDataNoRef(
		                                 (TileAnimationData *)&v13,
		                                 v5,
		                                 v7,
		                                 v8,
		                                 (MethodInfo *)v13.m128i_i64[0]);
		      if ( globalProps->fields.rainWetnessGlobalParams )
		      {
		        rainWetnessGlobalParams = globalProps->fields.rainWetnessGlobalParams;
		        v13 = *(__m128i *)TileAnimationDataNoRef;
		        sub_18003FEF0(rainWetnessGlobalParams, 0LL, &v13);
		        v6 = globalProps->fields.rainWetnessGlobalParams;
		        si128 = _mm_load_si128((const __m128i *)&xmmword_18DC813D0);
		        if ( v6 )
		        {
		          v13 = si128;
		          sub_18003FEF0(v6, 8LL, &v13);
		          v6 = globalProps->fields.rainWetnessGlobalParams;
		          if ( v6 )
		          {
		            v13 = 0LL;
		            sub_18003FEF0(v6, 9LL, &v13);
		            return;
		          }
		        }
		      }
		    }
		LABEL_8:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5482, 0LL);
		  if ( !Patch )
		    goto LABEL_8;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)globalProps,
		    0LL);
		}
		
		public void __iFixBaseProxy_UpdateData(RainCommonRenderingParam P0, float P1) {} // 0x0000000189CDB1BC-0x0000000189CDB1C4
		// Void <>iFixBaseProxy_UpdateData(RainCommonRenderingParam, Single)
		void HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::__iFixBaseProxy_UpdateData(
		        HGWetnessVerticalFlow *this,
		        RainCommonRenderingParam *P0,
		        float P1,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::Rain::HGBaseWetnessFeature::UpdateData((HGBaseWetnessFeature *)this, P0, P1, 0LL);
		}
		
		public void __iFixBaseProxy_SetData(RainWetnessGlobalProps P0) {} // 0x0000000189CDB1B4-0x0000000189CDB1BC
		// Void <>iFixBaseProxy_SetData(RainWetnessGlobalProps)
		void HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::__iFixBaseProxy_SetData(
		        HGWetnessVerticalFlow *this,
		        RainWetnessGlobalProps *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::Rain::HGBaseWetnessFeature::SetData((HGBaseWetnessFeature *)this, P0, 0LL);
		}
		
		public void __iFixBaseProxy_ResetData(RainWetnessGlobalProps P0) {} // 0x0000000189CDB1AC-0x0000000189CDB1B4
		// Void <>iFixBaseProxy_ResetData(RainWetnessGlobalProps)
		void HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::__iFixBaseProxy_ResetData(
		        HGWetnessVerticalFlow *this,
		        RainWetnessGlobalProps *P0,
		        MethodInfo *method)
		{
		  HG::Rendering::Runtime::Rain::HGBaseWetnessFeature::ResetData((HGBaseWetnessFeature *)this, P0, 0LL);
		}
		
	}
}
