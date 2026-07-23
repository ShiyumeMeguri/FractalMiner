using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 4: HG.RenderPipelines.Runtime.dll - Assembly: HG.RenderPipelines.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 37354-38879

namespace HG.Rendering.Runtime.Rain
{
	public class HGWetnessVerticalFlow : HGBaseWetnessFeature // TypeDefIndex: 38855
	{
		// Fields
		private float m_verticalFlowUVOffset; // 0x18
		private WetnessVerticalFlowRenderParams m_wetnessVerticalFlowRenderParams; // 0x20
	
		// Nested types
		private class WetnessVerticalFlowRenderParams // TypeDefIndex: 38854
		{
			// Fields
			public Texture2D verticalFlowTexture; // 0x10
			public Vector4 verticalFlowTexture_ST; // 0x18
			public float verticalFlowNormalStrength; // 0x28
			public float verticalFlowSurfaceThreshold; // 0x2C
			public float verticalFlowPorosityBias; // 0x30
	
			// Constructors
			public WetnessVerticalFlowRenderParams() {} // 0x0000000182EDAE60-0x0000000182EDAEA0
		}
	
		// Constructors
		public HGWetnessVerticalFlow() {} // 0x0000000182EDAC50-0x0000000182EDACA0
		// HGWetnessVerticalFlow()
		void HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::HGWetnessVerticalFlow(
		        HGWetnessVerticalFlow *this,
		        MethodInfo *method)
		{
		  HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *v3; // rax
		  __int64 v4; // rdx
		  __int64 v5; // rcx
		  HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *v6; // rbx
		  Action_1_HG_Rendering_Runtime_VolumetricRenderer_VolumetricCallbackContext_ *v7; // rdx
		  VolumetricRenderer_VolumetricBounds *v8; // r8
		  Int32__Array **v9; // r9
		  MethodInfo *v10; // [rsp+50h] [rbp+28h]
		  MethodInfo *v11; // [rsp+58h] [rbp+30h]
		  int32_t v12; // [rsp+60h] [rbp+38h]
		  int32_t v13; // [rsp+68h] [rbp+40h]
		  float v14; // [rsp+70h] [rbp+48h]
		  int32_t v15; // [rsp+78h] [rbp+50h]
		  bool v16; // [rsp+80h] [rbp+58h]
		  bool v17; // [rsp+88h] [rbp+60h]
		  MethodInfo *v18; // [rsp+90h] [rbp+68h]
		
		  v3 = (HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *)sub_1800368D0(TypeInfo::HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::WetnessVerticalFlowRenderParams);
		  v6 = v3;
		  if ( !v3 )
		    sub_1800D8260(v5, v4);
		  HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::WetnessVerticalFlowRenderParams::WetnessVerticalFlowRenderParams(
		    v3,
		    0LL);
		  this->fields.m_wetnessVerticalFlowRenderParams = v6;
		  sub_18002D1B0(
		    (VolumetricRenderer_VolumetricRenderItem *)&this->fields.m_wetnessVerticalFlowRenderParams,
		    v7,
		    v8,
		    v9,
		    v10,
		    v11,
		    v12,
		    v13,
		    v14,
		    v15,
		    v16,
		    v17,
		    v18);
		}
		
	
		// Methods
		internal override void UpdateData(RainCommonRenderingParam rainCommonRenderingParam, float deltaTime) {} // 0x0000000189CDBA3C-0x0000000189CDBB68
		internal override void SetData(RainWetnessGlobalProps globalProps) {} // 0x0000000189CDB8D4-0x0000000189CDBA3C
		// Void SetData(RainWetnessGlobalProps)
		void HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::SetData(
		        HGWetnessVerticalFlow *this,
		        RainWetnessGlobalProps *globalProps,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *v6; // rcx
		  HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *m_wetnessVerticalFlowRenderParams; // rax
		  Vector4__Array *rainWetnessGlobalParams; // rsi
		  float m_verticalFlowUVOffset; // xmm8_4
		  float verticalFlowNormalStrength; // xmm7_4
		  float verticalFlowSurfaceThreshold; // xmm6_4
		  Vector4 *v12; // rax
		  Vector4__Array *v13; // rdi
		  Vector4 *v14; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v16[2]; // [rsp+30h] [rbp-48h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5487, 0LL) )
		  {
		    m_wetnessVerticalFlowRenderParams = this->fields.m_wetnessVerticalFlowRenderParams;
		    if ( m_wetnessVerticalFlowRenderParams )
		    {
		      if ( m_wetnessVerticalFlowRenderParams->fields.verticalFlowNormalStrength <= 0.0 )
		      {
		        sub_180073530(7LL, this, globalProps);
		        return;
		      }
		      if ( globalProps )
		      {
		        rainWetnessGlobalParams = globalProps->fields.rainWetnessGlobalParams;
		        m_verticalFlowUVOffset = this->fields.m_verticalFlowUVOffset;
		        verticalFlowNormalStrength = m_wetnessVerticalFlowRenderParams->fields.verticalFlowNormalStrength;
		        verticalFlowSurfaceThreshold = m_wetnessVerticalFlowRenderParams->fields.verticalFlowSurfaceThreshold;
		        sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		        v12 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                v16,
		                m_verticalFlowUVOffset,
		                verticalFlowNormalStrength,
		                verticalFlowSurfaceThreshold,
		                0LL);
		        if ( rainWetnessGlobalParams )
		        {
		          v16[0] = *v12;
		          sub_18003FEF0(rainWetnessGlobalParams, 1LL, v16);
		          v6 = this->fields.m_wetnessVerticalFlowRenderParams;
		          v13 = globalProps->fields.rainWetnessGlobalParams;
		          if ( v6 )
		          {
		            v14 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                    v16,
		                    v6->fields.verticalFlowTexture_ST.x,
		                    v6->fields.verticalFlowTexture_ST.y,
		                    v6->fields.verticalFlowPorosityBias,
		                    0LL);
		            if ( v13 )
		            {
		              v16[0] = *v14;
		              sub_18003FEF0(v13, 2LL, v16);
		              return;
		            }
		          }
		        }
		      }
		    }
		LABEL_12:
		    sub_1800D8260(v6, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5487, 0LL);
		  if ( !Patch )
		    goto LABEL_12;
		  IFix::ILFixDynamicMethodWrapper::__Gen_Wrap_1(
		    (ILFixDynamicMethodWrapper_39 *)Patch,
		    (Object *)this,
		    (Object *)globalProps,
		    0LL);
		}
		
		internal override void ResetData(RainWetnessGlobalProps globalProps) {} // 0x0000000189CDB7C4-0x0000000189CDB8D4
		// Void ResetData(RainWetnessGlobalProps)
		void HG::Rendering::Runtime::Rain::HGWetnessVerticalFlow::ResetData(
		        HGWetnessVerticalFlow *this,
		        RainWetnessGlobalProps *globalProps,
		        MethodInfo *method)
		{
		  __int64 v5; // rdx
		  HGWetnessVerticalFlow_WetnessVerticalFlowRenderParams *m_wetnessVerticalFlowRenderParams; // rcx
		  Vector4__Array *rainWetnessGlobalParams; // rsi
		  float m_verticalFlowUVOffset; // xmm6_4
		  Vector4 *v9; // rax
		  Vector4__Array *v10; // rbx
		  Vector4 *v11; // rax
		  ILFixDynamicMethodWrapper_2 *Patch; // rax
		  Vector4 v13; // [rsp+30h] [rbp-28h] BYREF
		
		  if ( !IFix::WrappersManagerImpl::IsPatched(5488, 0LL) )
		  {
		    if ( globalProps )
		    {
		      rainWetnessGlobalParams = globalProps->fields.rainWetnessGlobalParams;
		      m_verticalFlowUVOffset = this->fields.m_verticalFlowUVOffset;
		      sub_1800036A0(TypeInfo::HG::Rendering::Runtime::HGUtils);
		      v9 = HG::Rendering::Runtime::HGUtils::PackVector4(&v13, m_verticalFlowUVOffset, 0.0, 0.0, 0LL);
		      if ( rainWetnessGlobalParams )
		      {
		        v13 = *v9;
		        sub_18003FEF0(rainWetnessGlobalParams, 1LL, &v13);
		        m_wetnessVerticalFlowRenderParams = this->fields.m_wetnessVerticalFlowRenderParams;
		        v10 = globalProps->fields.rainWetnessGlobalParams;
		        if ( m_wetnessVerticalFlowRenderParams )
		        {
		          v11 = HG::Rendering::Runtime::HGUtils::PackVector4(
		                  &v13,
		                  m_wetnessVerticalFlowRenderParams->fields.verticalFlowTexture_ST.x,
		                  m_wetnessVerticalFlowRenderParams->fields.verticalFlowTexture_ST.y,
		                  0.0,
		                  0LL);
		          if ( v10 )
		          {
		            v13 = *v11;
		            sub_18003FEF0(v10, 2LL, &v13);
		            return;
		          }
		        }
		      }
		    }
		LABEL_8:
		    sub_1800D8260(m_wetnessVerticalFlowRenderParams, v5);
		  }
		  Patch = IFix::WrappersManagerImpl::GetPatch(5488, 0LL);
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
